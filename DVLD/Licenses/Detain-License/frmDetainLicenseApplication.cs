using DVLD.Global_Classes;
using DVLD.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Licenses.Detain_License
{
    public partial class frmDetainLicenseApplication : Form
    {
        int _DetainID = -1;
        int _SelectedLicenseID = -1;
        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }

        private void lblDetainID_Click(object sender, EventArgs e)
        {

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            // Validate Fine Fees
            if (string.IsNullOrWhiteSpace(txtFineFees.Text) || !sbyte.TryParse(txtFineFees.Text, out sbyte fineFees))
            {
                errorProvider1.SetError(txtFineFees, "Please enter a valid whole number (e.g., 10).");
                MessageBox.Show("Fine Fees must be a valid whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFineFees.Focus();
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _DetainID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(
                fineFees, clsGlobal.CurrentUser.UserID);

            if (_DetainID == -1)
            {
                // Optionally update a label or log the error – no message box
                lblDetainID.Text = "Failed";
                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            // Success – no message box, just update UI
            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            btnDetain.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;
            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = _SelectedLicenseID != -1;

            if (_SelectedLicenseID == -1)
            {
                btnDetain.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                btnDetain.Enabled = false;
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selected = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo;
            if (selected == null || selected.DriverInfo == null)
            {
                MessageBox.Show("Please select a license first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(selected.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else
                errorProvider1.SetError(txtFineFees, null);

            if (!clsValidation.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
            else
                errorProvider1.SetError(txtFineFees, null);
        }
    }
}
