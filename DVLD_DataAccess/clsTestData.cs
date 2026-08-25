using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsTestData
    {
        public static bool GetTestInfoByID(int TestID,
             out int TestAppointmentID, out bool TestResult,
             out string Notes, out int CreatedByUserID)
        {
            // Out params must be assigned before returning
            TestAppointmentID = 0;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = 0;

            // Explicit columns - protects against schema changes
            string Query = @"SELECT TestAppointmentID, TestResult, Notes, CreatedByUserID 
                     FROM Tests 
                     WHERE TestID = @TestID";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

            Connection.Open();

            // ✅ WRAPPED IN USING - Guarantees Close/Dispose even on exceptions!
            using var Reader = Command.ExecuteReader();

            if (Reader.Read())
            {
                // Using ordinal positions (faster) and explicit type methods
                TestAppointmentID = Reader.GetInt32(0);
                TestResult = Reader.GetBoolean(1);
                Notes = Reader.IsDBNull(2) ? string.Empty : Reader.GetString(2);
                CreatedByUserID = Reader.GetInt32(3);
                return true;
            }

            return false; // Not found
                          // No try-catch needed at all!
        }

        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass(int PersonID, int LicenseClassID, int TestTypeID, out int TestID,
              out int TestAppointmentID, out bool TestResult,
              out string Notes, out int CreatedByUserID)
        {
            TestID = 0;
            TestAppointmentID = 0;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = 0;
            string Query = @"SELECT  top 1 Tests.TestID, 
                Tests.TestAppointmentID, Tests.TestResult, 
			    Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
                FROM            LocalDrivingLicenseApplications INNER JOIN
                                         Tests INNER JOIN
                                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                WHERE        (Applications.ApplicantPersonID = @PersonID) 
                        AND (LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID)
                        AND ( TestAppointments.TestTypeID=@TestTypeID)
                ORDER BY Tests.TestAppointmentID DESC";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                TestID = Reader.GetInt32(0);
                TestAppointmentID = Reader.GetInt32(1);
                TestResult = Reader.GetBoolean(2);
                Notes = Reader.IsDBNull(3) ? string.Empty : Reader.GetString(3);
                CreatedByUserID = Reader.GetInt32(4);
                return true;
            }
            return false;
        }

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Tests order by TestID";
            using var Command = new SqlCommand(Query, Connection);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewTest(int TestAppointmentID, bool TestResult,
             string Notes, int CreatedByUserID)
        {
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Tests (TestAppointmentID,TestResult,
                                                Notes,   CreatedByUserID)
                            Values (@TestAppointmentID,@TestResult,
                                                @Notes,   @CreatedByUserID);
                            
                                UPDATE TestAppointments 
                                SET IsLocked=1 where TestAppointmentID = @TestAppointmentID;

                                SELECT SCOPE_IDENTITY();";
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            if (!string.IsNullOrWhiteSpace(Notes))
                Command.Parameters.AddWithValue("@Notes", Notes);
            else
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            try
            {
                object result = Command.ExecuteScalar();
                return result == DBNull.Value ? -1 : Convert.ToInt32(result);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Failed to add test for Appointment {TestAppointmentID}.", sqlEx);
            }
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult,
             string Notes, int CreatedByUserID)
        {
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update  Tests  
                            set TestAppointmentID = @TestAppointmentID,
                                TestResult=@TestResult,
                                Notes = @Notes,
                                CreatedByUserID=@CreatedByUserID
                                where TestID = @TestID";
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            if (!string.IsNullOrWhiteSpace(Notes))
                Command.Parameters.AddWithValue("@Notes", Notes);
            else
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT count(TestTypeID)
                         FROM Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
						 where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestResult=1";
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Connection.Open();
            object result = Command.ExecuteScalar();
            return Convert.ToByte(result);
        }
    }
}
