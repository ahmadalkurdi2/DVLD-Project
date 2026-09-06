using DVLD.Global_Classes;
using DVLD.Licenses.Local_Licenses;
using DVLD.Licenses.Local_Licenses.Controls;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Renew_Local_License
{
    public partial class frmRenewLocalDrivingLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        private clsLicense _SelectedLicense = null;

        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            try
            {
                ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

                // Set application date
                lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
                lblIssueDate.Text = lblApplicationDate.Text;
                lblExpirationDate.Text = "N/A";
                lblTotalFees.Text = "0.00";  // Initialize total fees

                // Safely get application fees
                var appType = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense);
                if (appType != null)
                    lblApplicationFees.Text = appType.Fees.ToString("0.00");
                else
                {
                    MessageBox.Show("Application type 'Renew Driving License' not found in the database.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblApplicationFees.Text = "0.00";
                    btnRenew.Enabled = false;
                }

                // Safely get current user
                if (clsGlobal.CurrentUser != null)
                    lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                else
                {
                    MessageBox.Show("No current user logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblCreatedBy.Text = "Unknown";
                    btnRenew.Enabled = false;
                }

                // Initially disable buttons/links and clear renewal-related labels
                btnRenew.Enabled = false;
                llShowLicenseHistory.Enabled = false;
                llShowLicenseInfo.Enabled = false;
                lblApplicationID.Text = "N/A";
                lblRenewedLicenseID.Text = "N/A";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during form load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int selectedLicenseID)
        {
            try
            {
                // Reset UI
                btnRenew.Enabled = false;
                llShowLicenseHistory.Enabled = false;
                llShowLicenseInfo.Enabled = false;
                lblOldLicenseID.Text = string.Empty;
                lblExpirationDate.Text = "N/A";
                lblLicenseFees.Text = "0.00";
                lblTotalFees.Text = "0.00";
                txtNotes.Text = string.Empty;

                if (selectedLicenseID == -1)
                    return;

                // Get the selected license info from the control
                _SelectedLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;
                if (_SelectedLicense == null)
                {
                    MessageBox.Show("Selected license could not be retrieved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update basic info
                lblOldLicenseID.Text = selectedLicenseID.ToString();
                llShowLicenseHistory.Enabled = true;

                // Display current license details
                decimal licenseFees = _SelectedLicense.LicenseClassInfo?.ClassFees ?? 0;
                lblLicenseFees.Text = licenseFees.ToString("0.00");
                txtNotes.Text = _SelectedLicense.Notes ?? string.Empty;

                // --- FIX: Calculate total fees using arithmetic addition ---
                // Get application fees from the label (already stored as string)
                if (decimal.TryParse(lblApplicationFees.Text, out decimal appFees))
                {
                    decimal total = appFees + licenseFees;   // <-- arithmetic addition
                    lblTotalFees.Text = total.ToString("0.00");
                }
                else
                {
                    // Fallback: just show license fees
                    lblTotalFees.Text = licenseFees.ToString("0.00");
                }

                // Check if license is expired
                if (!_SelectedLicense.IsLicenseExpired())
                {
                    MessageBox.Show($"Selected License is not yet expired. It will expire on: {clsFormat.DateToShort(_SelectedLicense.ExpirationDate)}",
                                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblExpirationDate.Text = clsFormat.DateToShort(_SelectedLicense.ExpirationDate);
                    btnRenew.Enabled = false;
                    return;
                }

                // Check if license is active
                if (!_SelectedLicense.IsActive)
                {
                    MessageBox.Show("Selected License is not active. Please choose an active license.",
                                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRenew.Enabled = false;
                    return;
                }

                // Eligible for renewal → calculate new expiration date
                int validityLength = _SelectedLicense.LicenseClassInfo?.DefaultValidityLength ?? 0;
                if (validityLength > 0)
                    lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(validityLength));
                else
                    lblExpirationDate.Text = "Invalid validity length";

                btnRenew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the selected license: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (_SelectedLicense == null)
            {
                MessageBox.Show("No valid license selected for renewal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                if (clsGlobal.CurrentUser == null)
                {
                    MessageBox.Show("No user logged in. Renewal cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsLicense newLicense = _SelectedLicense.RenewLicense(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);
                if (newLicense == null)
                {
                    MessageBox.Show("Failed to renew the license. Please check the application logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _NewLicenseID = newLicense.LicenseID;
                lblApplicationID.Text = newLicense.ApplicationID.ToString();
                lblRenewedLicenseID.Text = _NewLicenseID.ToString();

                MessageBox.Show($"License renewed successfully with ID = {_NewLicenseID}", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRenew.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                llShowLicenseInfo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred during renewal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRenewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("License history feature is not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_NewLicenseID > 0)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No renewed license to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}