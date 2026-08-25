using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsTestType
    {
        enum enMode { AddNew, Update };
        enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest, StreetTest };
        public clsTestType.enTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { set; get; }

        public clsTestType()
        {
            this.ID = clsTestType.enTestType.VisionTest;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Fees = 0;
            Mode = enMode.AddNew;
        }
        public clsTestType(clsTestType.enTestType ID, string TestTypeTitel, string Description, decimal TestTypeFees)
        {
            this.ID = ID;
            this.Title = TestTypeTitel;
            this.Description = Description;
            this.Fees = TestTypeFees;
            Mode = enMode.Update;
        }

        private bool _AddNewTestType()
        {
            this.ID = (clsTestType.enTestType)clsTestTypeData.AddNewTestType((int)this.ID, this.Title, this.Description, this.Fees);
            return this.Title != string.Empty;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees);
        }

        public static clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string Title = string.Empty, Description = string.Empty; decimal Fees = 0;
            return clsTestTypeData.GetTestTypeInfoByID((int)TestTypeID, out Title, out Description, out Fees) ? new clsTestType(TestTypeID, Title, Description, Fees) : null;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateTestType();
            }
            return false;
        }
    }
}
