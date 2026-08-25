using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID, out int ApplicationID,
            out int LicenseClassID)
        {
            ApplicationID = 0;
            LicenseClassID = 0;

            string Query = @"SELECT ApplicationID, LicenseClassID
                     FROM LocalDrivingLicenseApplications
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                ApplicationID = Reader.GetInt32(0);
                LicenseClassID = Reader.GetInt32(1);
                return true;
            }
            return false;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID, out int LocalDrivingLicenseApplicationID,
         out int LicenseClassID)
        {
            LocalDrivingLicenseApplicationID = 0;
            LicenseClassID = 0;

            string Query = @"SELECT LocalDrivingLicenseApplicationID, LicenseClassID
                            FROM LocalDrivingLicenseApplications
                            WHERE ApplicationID = @ApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                LocalDrivingLicenseApplicationID = Reader.GetInt32(0);
                LicenseClassID = Reader.GetInt32(1);
                return true;
            }
            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            string Query = @"SELECT LocalDrivingLicenseApplicationID, 
                            ClassName, 
                            NationalNo, 
                            ApplicationDate,
                            FullName,
                            PassedTestCount,
                            Status
                     FROM LocalDrivingLicenseApplications_View
                     ORDER BY ApplicationDate DESC;";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            string Query = @"INSERT INTO LocalDrivingLicenseApplications ( 
                            ApplicationID,LicenseClassID)
                             VALUES (@ApplicationID,@LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            Connection.Open();
            object Result = Command.ExecuteScalar();
            return Result == DBNull.Value ? -1 : Convert.ToInt32(Result);
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            string Query = @"Update  LocalDrivingLicenseApplications  
                            set ApplicationID = @ApplicationID,
                                LicenseClassID = @LicenseClassID
                            where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            string Query = @"Delete LocalDrivingLicenseApplications 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            string Query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            Connection.Open();
            object result = Command.ExecuteScalar();
            return result != null;
        }

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            string Query = @"SELECT TOP 1 1
                     FROM LocalDrivingLicenseApplications 
                     INNER JOIN TestAppointments 
                         ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                     INNER JOIN Tests 
                         ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                     WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @AppID
                       AND TestAppointments.TestTypeID = @TypeID
                     ORDER BY TestAppointments.TestAppointmentID DESC";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Connection.Open();
            object result = Command.ExecuteScalar();
            return result != null;
        }

        public static sbyte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            string Query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Connection.Open();
            object result = Command.ExecuteScalar();
            return (result == null || result == DBNull.Value) ? (sbyte)-1 : Convert.ToSByte(result);
        }

        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationID, int testTypeID)
        {
            string query = @"SELECT TOP 1 1
                     FROM TestAppointments
                     WHERE LocalDrivingLicenseApplicationID = @AppID
                       AND TestTypeID = @TypeID
                       AND IsLocked = 0
                       AND AppointmentDate >= CAST(GETDATE() AS DATE)
                     ORDER BY TestAppointmentID DESC";

            using var connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", localDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TypeID", testTypeID);

            connection.Open();
            object result = command.ExecuteScalar();
            return result != null;
        }
    }
}

