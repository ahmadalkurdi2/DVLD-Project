using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsDriverData
    {
        public static bool GetDriverInfoByDriverID(int DriverID,
            out int PersonID, out int CreatedByUserID, out DateTime CreatedDate)
        {
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.MinValue;

            string Query = @"SELECT PersonID, CreatedByUserID, CreatedDate FROM Drivers 
                                WHERE DriverID = @DriverID";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Connection.Open();
            using var reader = Command.ExecuteReader();
            if (reader.Read())
            {
                PersonID = reader.GetInt32(0);
                CreatedByUserID = reader.GetInt32(1);
                CreatedDate = reader.GetDateTime(2);
                return true;
            }
            return false;
        }

        public static bool GetDriverInfoByPersonID(int PersonID, out int DriverID,
            out int CreatedByUserID, out DateTime CreatedDate)
        {
            DriverID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.MinValue;

            string Query = @"SELECT DriverID, CreatedByUserID, CreatedDate 
                     FROM Drivers 
                     WHERE PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Connection.Open();
            using var reader = Command.ExecuteReader();
            if (reader.Read())
            {
                DriverID = reader.GetInt32(0);
                CreatedByUserID = reader.GetInt32(1);
                CreatedDate = reader.GetDateTime(2);
                return true;
            }
            return false;
        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            string Query = @"SELECT DriverID, PersonID,NationalNo, FullName, CreatedDate,NumberOfActiveLicenses
                            FROM Drivers_View 
                            ORDER BY FullName";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var reader = Command.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            string Query = @"Insert Into Drivers (PersonID,CreatedByUserID,CreatedDate)
                            Values (@PersonID,@CreatedByUserID,@CreatedDate);
                            SELECT SCOPE_IDENTITY();";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            Connection.Open();
            object result = Command.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int insertedID))
            {
                return insertedID;
            }
            return -1;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID)
        {
            string Query = @"Update  Drivers  
                            set PersonID = @PersonID,
                                CreatedByUserID = @CreatedByUserID
                                where DriverID = @DriverID";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}
