using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int ID { set; get; }
        public string CountryName { set; get; }

        //private clsCountry()
        //{
        //    this.ID = -1;
        //    this.CountryName = string.Empty;
        //}
        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
        public static clsCountry Find(int ID)
        {
            string CountryName = string.Empty;
            if (clsCountryData.GetCountryInfoByID(ID, out CountryName))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }
        public static clsCountry Find(string CountryName)
        {
            int ID = -1;
            if (clsCountryData.GetCountryInfoByName(CountryName, out ID))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
