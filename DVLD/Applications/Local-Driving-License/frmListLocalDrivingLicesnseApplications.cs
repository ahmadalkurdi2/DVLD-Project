using DVLD.Tests;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicesnseApplications : Form
    {
        DataTable _dtAllLocalDrivingLicenseApplications;
        public frmListLocalDrivingLicesnseApplications()
        {
            InitializeComponent();

            // attach safe context menu handler at runtime (replace designer handler)
            try
            {
                if (this.contextMenuStrip1 != null)
                {
                    this.contextMenuStrip1.Opening -= contextMenuStrip1_Opening;
                    this.contextMenuStrip1.Opening += contextMenuStrip1_Opening_Safe;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void frmListLocalDrivingLicesnseApplications_Load(object sender, EventArgs e)
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _dtAllLocalDrivingLicenseApplications;
            lblRecordsCount.Text = _dtAllLocalDrivingLicenseApplications.DefaultView.Count.ToString();

            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 150;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 150;
            }
            // populate filter options and set default selection
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No.", "Full Name", "Status" });
            cbFilterBy.SelectedIndex = 0;
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hide if "None" selected or nothing selected
            txtFilterValue.Visible = cbFilterBy.SelectedIndex > 0;
            txtFilterValue.Text = string.Empty;
            if (txtFilterValue.Visible)
                txtFilterValue.Focus();

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Empty;
            lblRecordsCount.Text = _dtAllLocalDrivingLicenseApplications.DefaultView.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = string.Empty;
            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || FilterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = _dtAllLocalDrivingLicenseApplications.DefaultView.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = $"[{FilterColumn}] = {id}";
                else
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "1=0"; // no match for invalid numeric input
            }
            else
            {
                // escape single quotes inside the value
                string val = txtFilterValue.Text.Trim().Replace("'", "''");
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '%{val}%'";
            }

            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void dgvLocalDrivingLicenseApplications_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvLocalDrivingLicenseApplications.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dgvLocalDrivingLicenseApplications.ClearSelection();
                    dgvLocalDrivingLicenseApplications.Rows[hit.RowIndex].Selected = true;
                    dgvLocalDrivingLicenseApplications.CurrentCell = dgvLocalDrivingLicenseApplications.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _ScheduleTest(clsTestType.enTestType TestType)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            frmListTestAppointments frm = new frmListTestAppointments(LocalDrivingLicenseApplicationID, TestType);
            frm.ShowDialog();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
            int TotalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            bool LicenseExists = localDrivingLicenseApplication.IsLicenseIssued();

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;
            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editToolStripMenuItem.Enabled = !LicenseExists && (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            ScheduleTestsMenue.Enabled = !LicenseExists;

            CancelApplicaitonToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            ScheduleTestsMenue.Enabled = !LicenseExists;
            DeleteApplicationToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            bool PassedVisionTest = localDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest);
            bool PassedWrittenTest = localDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = localDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            ScheduleTestsMenue.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            if (ScheduleTestsMenue.Enabled)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;
                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }
        }

        private void contextMenuStrip1_Opening_Safe(object sender, CancelEventArgs e)
        {
            try
            {
                // call the existing opening handler; this ensures designer behavior is preserved while protecting against exceptions
                contextMenuStrip1_Opening(sender, e);
            }
            catch (Exception ex)
            {
                // Log and prevent the context menu from opening to avoid crashes caused by handler exceptions
                Console.WriteLine("Suppressed exception in contextMenuStrip1_Opening: " + ex);
                e.Cancel = true;
            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            int LicenseID = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID).GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show("Not implemented yet");
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
            if (localDrivingLicenseApplication != null)
                if (localDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicesnseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Could not cancel application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
            if (localDrivingLicenseApplication != null)
                if (localDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    frmListLocalDrivingLicesnseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Could not delete application, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("Please select an application first_ScheduleTest.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
            MessageBox.Show("Not implemented yet");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
