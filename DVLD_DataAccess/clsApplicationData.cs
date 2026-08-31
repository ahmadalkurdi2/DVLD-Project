using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {
        public static bool GetApplicationInfoByID(int ApplicationID, out int ApplicantPersonID, out DateTime ApplicationDate, out int ApplicationTypeID,
            out byte ApplicationStatus, out DateTime LastStatusDate,
            out decimal PaidFees, out int CreatedByUserID)
        {
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeID = 0;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = 0;

            string Query = "select * from Applications where ApplicationID=@ApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                int idxApplicant = Reader.GetOrdinal("ApplicantPersonID");
                int idxApplicationDate = Reader.GetOrdinal("ApplicationDate");
                int idxApplicationTypeID = Reader.GetOrdinal("ApplicationTypeID");
                int idxApplicationStatus = Reader.GetOrdinal("ApplicationStatus");
                int idxLastStatusDate = Reader.GetOrdinal("LastStatusDate");
                int idxPaidFees = Reader.GetOrdinal("PaidFees");
                int idxCreatedByUserID = Reader.GetOrdinal("CreatedByUserID");

                if (!Reader.IsDBNull(idxApplicant)) ApplicantPersonID = Reader.GetInt32(idxApplicant);
                if (!Reader.IsDBNull(idxApplicationDate)) ApplicationDate = Reader.GetDateTime(idxApplicationDate);
                if (!Reader.IsDBNull(idxApplicationTypeID)) ApplicationTypeID = Reader.GetInt32(idxApplicationTypeID);
                if (!Reader.IsDBNull(idxApplicationStatus)) ApplicationStatus = Reader.GetByte(idxApplicationStatus);
                if (!Reader.IsDBNull(idxLastStatusDate)) LastStatusDate = Reader.GetDateTime(idxLastStatusDate);
                if (!Reader.IsDBNull(idxPaidFees)) PaidFees = Reader.GetDecimal(idxPaidFees);
                if (!Reader.IsDBNull(idxCreatedByUserID)) CreatedByUserID = Reader.GetInt32(idxCreatedByUserID);

                return true;
            }
            return false;
        }

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            string Query = "select * from ApplicationsList_View order by ApplicationDate desc";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID)
        {
            string Query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Connection.Open();
            object Result = Command.ExecuteScalar();
            return Result == DBNull.Value ? -1 : Convert.ToInt32(Result);
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID)
        {
            string Query = @"Update  Applications  
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where ApplicationID=@ApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            string Query = "delete  Applications where ApplicationID = @ApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            string Query = "select found = 1 from Applications where ApplicationID = @ApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            return Reader.HasRows;
        }

        public static int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            string Query = "SELECT ActiveApplicationID=ApplicationID FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationStatus=1";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Connection.Open();
            object Result = Command.ExecuteScalar();
            if (Result == null || Result == DBNull.Value)
                return -1;
            return Convert.ToInt32(Result);
        }

        public static bool DoesPersonHaveActiveApplication(int personID, int applicationTypeID)
        {
            return GetActiveApplicationID(personID, applicationTypeID) != -1;
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            string Query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            Connection.Open();
            object Result = Command.ExecuteScalar();
            if (Result == null || Result == DBNull.Value)
                return -1;
            return Convert.ToInt32(Result);
        }

        public static bool UpdateStatus(int ApplicationID, short NewStatus,DateTime LastStatusDate)
        {
            string Query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@NewStatus", NewStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}
