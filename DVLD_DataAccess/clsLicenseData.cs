using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsLicenseData
    {
        public static bool GetLicenseInfoByID(int LicenseID, out int ApplicationID, out int DriverID, out int LicenseClass,
            out DateTime IssueDate, out DateTime ExpirationDate, out string Notes,
            out decimal PaidFees, out bool IsActive, out byte IssueReason, out int CreatedByUserID)
        {
            ApplicationID = 0;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = 0;

            string Query = "SELECT ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID FROM Licenses WHERE LicenseID = @LicenseID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            Connection.Open();
            using var reader = Command.ExecuteReader();
            if (reader.Read())
            {
                ApplicationID = reader.GetInt32(0);
                DriverID = reader.GetInt32(1);
                LicenseClass = reader.GetInt32(2);
                IssueDate = reader.GetDateTime(3);
                ExpirationDate = reader.GetDateTime(4);
                Notes = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                PaidFees = reader.GetDecimal(6);
                IsActive = reader.GetBoolean(7);
                IssueReason = reader.GetByte(8);
                CreatedByUserID = reader.GetInt32(9);
                return true;
            }
            return false;
        }

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT * FROM Licenses";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Connection.Open();
            using var reader = Command.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public static DataTable GetDriverLicenses(int DriverID)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT     
                           Licenses.LicenseID,
                           ApplicationID,
		                   LicenseClasses.ClassName, Licenses.IssueDate, 
		                   Licenses.ExpirationDate, Licenses.IsActive
                           FROM Licenses INNER JOIN
                                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID=@DriverID
                            Order By IsActive Desc, ExpirationDate Desc";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            Connection.Open();
            using var reader = Command.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // ==========================================
        // FIXED AddNewLicense – now validates DriverID
        // ==========================================
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
             DateTime IssueDate, DateTime ExpirationDate, string Notes,
             decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            // 1. Check if the DriverID actually exists in the Drivers table
            if (!_DriverExists(DriverID))
            {
                // The caller should ensure a valid driver exists before calling this method.
                // Return -1 to indicate failure; the caller can then create a driver record.
                return -1;
            }

            string Query = @"
                              INSERT INTO Licenses
                               (ApplicationID,
                                DriverID,
                                LicenseClass,
                                IssueDate,
                                ExpirationDate,
                                Notes,
                                PaidFees,
                                IsActive,IssueReason,
                                CreatedByUserID)
                         VALUES
                               (
                               @ApplicationID,
                               @DriverID,
                               @LicenseClass,
                               @IssueDate,
                               @ExpirationDate,
                               @Notes,
                               @PaidFees,
                               @IsActive,@IssueReason, 
                               @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            object result = Command.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int insertedID))
            {
                return insertedID;
            }
            return -1;
        }

        // Helper method to check if a Driver exists
        private static bool _DriverExists(int DriverID)
        {
            string Query = "SELECT COUNT(*) FROM Drivers WHERE DriverID = @DriverID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Connection.Open();
            int count = (int)Command.ExecuteScalar();
            return count > 0;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
             DateTime IssueDate, DateTime ExpirationDate, string Notes,
             decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            string Query = @"UPDATE Licenses
                           SET ApplicationID=@ApplicationID, DriverID = @DriverID,
                              LicenseClass = @LicenseClass,
                              IssueDate = @IssueDate,
                              ExpirationDate = @ExpirationDate,
                              Notes = @Notes,
                              PaidFees = @PaidFees,
                              IsActive = @IsActive,IssueReason=@IssueReason,
                              CreatedByUserID = @CreatedByUserID
                         WHERE LicenseID=@LicenseID";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            string Query = @"SELECT Licenses.LicenseID FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE Licenses.LicenseClass = @LicenseClass 
                              AND Drivers.PersonID = @PersonID
                              And IsActive=1;";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            Connection.Open();
            object result = Command.ExecuteScalar();
            if (result == null || result == DBNull.Value)
                return -1;
            return Convert.ToInt32(result);
        }

        public static bool DeactivateLicense(int LicenseID)
        {
            string Query = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID=@LicenseID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}