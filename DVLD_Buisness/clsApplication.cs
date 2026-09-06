using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum enMode { AddNew, Update };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense, ReplaceLostDrivingLicense,
            ReplaceDamagedDrivingLicense, ReleaseDetainedDrivingLicsense, NewInternationalLicense, RetakeTest
        }
        public enMode Mode = enMode.AddNew;
        public enum enApplicationStatus { New = 1, Cancelled, Completed };

        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public clsPerson PersonInfo { set; get; }
        public string ApplicantFullName
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID).FullName;
            }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo;
        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.MinValue;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            Mode = enMode.AddNew;
        }

        public clsApplication(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            int newId = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            if (newId != -1)
            {
                this.ApplicationID = newId;
                return true;
            }
            return false;
        }
        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        public static clsApplication FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue; int ApplicationTypeID = -1;
            byte ApplicationStatus = 1; DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = 0; int CreatedByUserID = -1;

            bool IsFound = clsApplicationData.GetApplicationInfoByID(ApplicationID, out ApplicantPersonID,
                                    out ApplicationDate, out ApplicationTypeID,
                                    out ApplicationStatus, out LastStatusDate,
                                    out PaidFees, out CreatedByUserID);
            if (IsFound)
                return new clsApplication(ApplicationID, ApplicantPersonID,
                                     ApplicationDate, ApplicationTypeID,
                                    (enApplicationStatus)ApplicationStatus, LastStatusDate,
                                     PaidFees, CreatedByUserID);
            else
                return null;

        }

        public bool Cancel()
        {
            this.LastStatusDate = DateTime.Now;
            this.ApplicationStatus = enApplicationStatus.Cancelled;
            return clsApplicationData.UpdateStatus(ApplicationID, 2, this.LastStatusDate);
        }

        public bool SetComplete()
        {
            this.LastStatusDate = DateTime.Now;
            this.ApplicationStatus = enApplicationStatus.Completed;
            return clsApplicationData.UpdateStatus(ApplicationID, 3, this.LastStatusDate);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }

        public bool Delete()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationData.IsApplicationExist(ApplicationID);
        }
        
        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }

        public bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID,clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }


        public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationTypeID)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);
        }
    }
}
