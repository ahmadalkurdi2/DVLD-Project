using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD.Licenses.Local_Licenses;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : Form
    {
        int _SelectedLicenseID = -1;

        public frmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            clsLicense license = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;
            
            // Always update basic license info
            _SelectedLicenseID = obj;

            // Enable/disable links based on selection
            llShowLicenseHistory.Enabled = (obj != -1 && license?.DriverInfo != null);
            llShowLicenseInfo.Enabled = (obj != -1); // Always allow viewing license info

            // Clear all detain-related labels if no valid license or not detained
            if (obj == -1 || license == null || !license.IsDetained)
            {
                lblLicenseID.Text = obj == -1 ? "" : obj.ToString();
                lblDetainID.Text = "";
                lblCreatedBy.Text = "";
                lblDetainDate.Text = "";
                lblApplicationFees.Text = "";
                lblFineFees.Text = "";
                lblTotalFees.Text = "";
                btnRelease.Enabled = false;

                // Show message if license is selected but not detained
                if (obj != -1 && license != null && !license.IsDetained)
                {
                    MessageBox.Show("This license is not detained. You can only release detained licenses.", "Not Detained",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            // --- Valid detained license found ---

            // 1. Basic license info
            lblLicenseID.Text = license.LicenseID.ToString();

            // 2. Detain info
            lblDetainID.Text = license.DetainedInfo.DetainID.ToString();
            lblCreatedBy.Text = license.DetainedInfo.CreatedByUserInfo?.UserName ?? "N/A";
            lblDetainDate.Text = clsFormat.DateToShort(license.DetainedInfo.DetainDate);

            // 3. Fees: get the application type fee properly
            var appType = clsApplicationType.Find(
                (int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense);

            if (appType == null)
            {
                MessageBox.Show("Application type not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            // IMPORTANT: Use the correct property name for the fee.
            // In your clsApplicationType, it might be "Fees", "ApplicationFees", or "Fee".
            // Adjust the line below accordingly.
            decimal appFees = appType.Fees;              // <-- Change if needed
            decimal fineFees = license.DetainedInfo.FineFees;

            lblApplicationFees.Text = appFees.ToString("0.00");
            lblFineFees.Text = fineFees.ToString("0.00");
            // Use arithmetic addition – no string concatenation!
            lblTotalFees.Text = (appFees + fineFees).ToString("0.00");

            // 4. Enable the release button
            btnRelease.Enabled = true;

            
        }

        private void frmReleaseDetainedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var license = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;
            if (license?.DriverInfo == null)
            {
                MessageBox.Show("No driver information available.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmShowPersonLicenseHistory frm =
                new frmShowPersonLicenseHistory(license.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_SelectedLicenseID == -1)
            {
                MessageBox.Show("No license selected.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            clsLicense license = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;
            
            if (license == null || _SelectedLicenseID == -1)
            {
                MessageBox.Show("No valid detained license selected.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation: Check if license is detained
            if (!license.IsDetained)
            {
                MessageBox.Show("This license is not detained. You cannot release a license that is not detained.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRelease.Enabled = false;
                return;
            }

            // Confirm with user
            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            // ========================================================================
            //  IMPORTANT: Your business class clsDetainedLicense has a method:
            //    public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
            //  It does NOT have an 'out' parameter.
            //
            //  You need to obtain (or create) a ReleaseApplicationID before calling this.
            //  In your original code you had 'out ApplicationID' – if you have a different
            //  overload, use that. Otherwise, create the application first and pass its ID.
            // ========================================================================

            // EXAMPLE: Create a new application (pseudo-code – replace with your actual logic)
            // int releaseAppID = clsApplication.AddNewApplication( ... );
            // For now, we use -1 as a placeholder – YOU MUST REPLACE THIS.
            int releaseApplicationID = -1;   // <-- Replace with real ID

            // Call the method as it exists in the business class
            bool IsReleased = license.ReleaseDetainedLicense(
                clsGlobal.CurrentUser.UserID,
               ref releaseApplicationID
            );

            if (!IsReleased)
            {
                MessageBox.Show("Failed to release the detained license.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Success – show the application ID (you need to supply a valid one)
            lblApplicationID.Text = releaseApplicationID.ToString();

            MessageBox.Show("Detained license released successfully.", "Detained License Released",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the license info to update the "Is Detained" label to "No"
            ctrlDriverLicenseInfoWithFilter1.RefreshLicenseInfo();

            // Disable further actions
            btnRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            // llShowLicenseInfo remains enabled (it's already enabled)
        }
    }
}