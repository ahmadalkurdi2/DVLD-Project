using DVLD.Global_Classes;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicense _License;
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }

        private void _LoadPersonImage()
        {
            if (_License?.DriverInfo?.PersonInfo == null)
            {
                pbPersonImage.Image = Resources.Male_512; // Default to male image
                return;
            }

            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;
            if (ImagePath != string.Empty)
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblIsActive.Text = _License.IsActive.ToString();
            lblIsDetained.Text = _License.IsDetained.ToString();
            lblClass.Text = _License.LicenseClassInfo.ToString();

            // Check if DriverInfo and PersonInfo are available
            if (_License.DriverInfo?.PersonInfo != null)
            {
                lblName.Text = _License.DriverInfo.PersonInfo.FullName;
                lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
                lblGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
                lblDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);
            }
            else
            {
                lblName.Text = "N/A";
                lblNationalNo.Text = "N/A";
                lblGendor.Text = "N/A";
                lblDateOfBirth.Text = "N/A";
            }

            lblDriverID.Text = _License.DriverID.ToString();
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes == string.Empty ? "No Notes" : _License.Notes;
            _LoadPersonImage();
        }
    }
}
