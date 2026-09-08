using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        int _DriverID;
        clsDriver _Driver;
        DataTable _dtDriverLocalLicenseHistory;
        DataTable _dtDriverInternationalLicenseHistory;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
            _dtDriverLocalLicenseHistory = new DataTable();
            _dtDriverInternationalLicenseHistory = new DataTable();
        }


        // Ensure Clear() is safe even if LoadInfo was never called; DataTables are initialized in constructor.

        private void _LoadLocalLicenseInfo()
        {
            _dtDriverLocalLicenseHistory = clsDriver.GetLicenses(_DriverID);
            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicenseHistory;
            lblLocalLicensesRecords.Text = _dtDriverLocalLicenseHistory.Rows.Count.ToString();
        }

        private void _LoadInternationalLicenseInfo()
        {
            _dtDriverInternationalLicenseHistory = clsDriver.GetInternationalLicenses(_DriverID);
            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicenseHistory;
            lblInternationalLicensesRecords.Text = _dtDriverInternationalLicenseHistory.Rows.Count.ToString();
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(_DriverID);
            if(_Driver==null)
            {
                // No driver found: clear displayed data instead of showing modal message box.
                _dtDriverLocalLicenseHistory.Clear();
                dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicenseHistory;
                lblLocalLicensesRecords.Text = "0";

                _dtDriverInternationalLicenseHistory.Clear();
                dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicenseHistory;
                lblInternationalLicensesRecords.Text = "0";
                return;
            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriver.FindByPersonID(PersonID);
            if (_Driver == null)
            {
                // No driver found: clear displayed data instead of showing modal message box.
                _dtDriverLocalLicenseHistory.Clear();
                dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicenseHistory;
                lblLocalLicensesRecords.Text = "0";

                _dtDriverInternationalLicenseHistory.Clear();
                dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicenseHistory;
                lblInternationalLicensesRecords.Text = "0";
                return;
            }

            _DriverID = _Driver.DriverID;
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        public void Clear()
        {
            _dtDriverInternationalLicenseHistory.Clear();
            _dtDriverLocalLicenseHistory.Clear();

        }
    }
}
