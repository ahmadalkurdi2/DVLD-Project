using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID,
            out int LicenseID, out DateTime DetainDate,
            out decimal FineFees, out int CreatedByUserID,
            out bool IsReleased, out DateTime ReleaseDate,
            out int ReleasedByUserID, out int ReleaseApplicationID)
        {
            LicenseID = 0;
            DetainDate = DateTime.MinValue;
            FineFees = 0;
            CreatedByUserID = 0;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = 0;
            ReleaseApplicationID = 0;

            string Query = "SELECT LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID FROM DetainedLicenses WHERE DetainID = @DetainID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);


            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {

                LicenseID = Reader.GetInt32(0);
                DetainDate = Reader.GetDateTime(1);
                FineFees = Reader.GetDecimal(2);
                CreatedByUserID = Reader.GetInt32(3);
                IsReleased = Reader.GetBoolean(4);
                ReleaseDate = Reader.IsDBNull(5) ? DateTime.MinValue : Reader.GetDateTime(5);
                ReleasedByUserID = Reader.IsDBNull(6) ? -1 : Reader.GetInt32(6);
                ReleaseApplicationID = Reader.IsDBNull(7) ? -1 : Reader.GetInt32(7);
                return true;
            }
            return false;
        }

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, out int DetainID, out DateTime DetainDate,
         out decimal FineFees, out int CreatedByUserID,
         out bool IsReleased, out DateTime ReleaseDate,
         out int ReleasedByUserID, out int ReleaseApplicationID)
        {
            DetainID = 0;
            DetainDate = DateTime.MinValue;
            FineFees = 0;
            CreatedByUserID = 0;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = 0;
            ReleaseApplicationID = 0;

            string Query = "SELECT top 1 DetainID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID FROM DetainedLicenses WHERE LicenseID = @LicenseID order by DetainID desc";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                DetainID = Reader.GetInt32(0);
                DetainDate = Reader.GetDateTime(1);
                FineFees = Reader.GetDecimal(2);
                CreatedByUserID = Reader.GetInt32(3);
                IsReleased = Reader.GetBoolean(4);
                ReleaseDate = Reader.IsDBNull(5) ? DateTime.MinValue : Reader.GetDateTime(5);
                ReleasedByUserID = Reader.IsDBNull(6) ? -1 : Reader.GetInt32(6);
                ReleaseApplicationID = Reader.IsDBNull(7) ? -1 : Reader.GetInt32(7);
                return true;
            }
            return false;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            string Query = "select * from detainedLicenses_View order by IsReleased ,DetainID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate,
            decimal FineFees, int CreatedByUserID)
        {
            string Query = @"INSERT INTO dbo.DetainedLicenses
                               (LicenseID,
                               DetainDate,
                               FineFees,
                               CreatedByUserID,
                               IsReleased
                               )
                            VALUES
                               (@LicenseID,
                               @DetainDate, 
                               @FineFees, 
                               @CreatedByUserID,
                               0
                             );
                            
                            SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Connection.Open();
            object Result = Command.ExecuteScalar();
            return Result == DBNull.Value ? -1 : Convert.ToInt32(Result);
        }

        public static bool UpdateDetainedLicense(int DetainID,
            int LicenseID, DateTime DetainDate,
            decimal FineFees, int CreatedByUserID)
        {
            string Query = @"UPDATE dbo.DetainedLicenses
                              SET LicenseID = @LicenseID, 
                              DetainDate = @DetainDate, 
                              FineFees = @FineFees,
                              CreatedByUserID = @CreatedByUserID  
                              WHERE DetainID=@DetainID;";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool ReleaseDetainedLicense(int DetainID,
                 int ReleasedByUserID, int ReleaseApplicationID)
        {
            string Query = @"UPDATE dbo.DetainedLicenses
                     SET IsReleased = 1,
                         ReleaseDate = @ReleaseDate,
                         ReleasedByUserID = @ReleasedByUserID,
                         ReleaseApplicationID = @ReleaseApplicationID
                     WHERE DetainID = @DetainID";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            Command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            string Query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            Connection.Open();
            object result = Command.ExecuteScalar();
            return result != null;
        }
    }
}
