using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public enum enGendor { Male, Female };

        public static bool GetCountryInfoByID(int CountryID, out string CountryName)
        {
            CountryName = string.Empty;
            string Query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                CountryName = Reader.IsDBNull(0) ? string.Empty : Reader.GetString(0);
                return true;
            }
            return false;
        }

        public static bool GetCountryInfoByName(string CountryName, out int ID)
        {
            ID = 0;
            string Query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                ID = Reader.GetInt16(0);
                return true;
            }
            return false;
        }

        public static DataTable GetAllCountries()
        {
            string Query = "SELECT * FROM Countries order by CountryName";
            DataTable dt = new DataTable();
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }
    }
}
