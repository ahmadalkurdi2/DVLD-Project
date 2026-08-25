using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public enum enMode { AddNew, Update };
        public enMode Mode { get;private set; }

        public int ID { set; get; }
        public string Title { set; get; }
        public decimal Fees { set; get; }

        public clsApplicationType()
        {
            this.ID = -1;
            this.Title = string.Empty;
            this.Fees = 0;
            Mode = enMode.AddNew;
        }
        public clsApplicationType(int ID, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            this.ID = ID;
            this.Title = ApplicationTypeTitle;
            this.Fees = ApplicationTypeFees;
            Mode = enMode.Update;
        }
        private bool _AddNewApplicationType()
        {
            return clsApplicationTypeData.AddNewApplicationType(this.Title, this.Fees) != -1;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        public static clsApplicationType Find(int ID)
        {
            string Title = string.Empty;
            decimal Fees = 0;

            if (clsApplicationTypeData.GetApplicationTypeInfoByID(ID, out Title, out Fees))
                return new clsApplicationType(ID, Title, Fees);
            else
                return null;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateApplicationType();
            }
            return false;
        }
    }
}
