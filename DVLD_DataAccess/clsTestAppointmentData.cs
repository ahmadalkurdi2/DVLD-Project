using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {
        public static bool GetTestAppointmentInfoByID(int TestAppointmentID,
            out int TestTypeID, out int LocalDrivingLicenseApplicationID,
            out DateTime AppointmentDate, out decimal PaidFees, out int CreatedByUserID, out bool IsLocked, out int RetakeTestApplicationID)
        {
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            RetakeTestApplicationID = 0;

            string Query = "SELECT TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, CreatedByUserID, PaidFees, IsLocked, RetakeTestApplicationID FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                TestTypeID = Reader.GetInt32(0);
                LocalDrivingLicenseApplicationID = Reader.GetInt32(1);
                AppointmentDate = Reader.GetDateTime(2);
                CreatedByUserID = Reader.GetInt32(3);
                PaidFees = Reader.GetDecimal(4);
                IsLocked = Reader.GetBoolean(5);
                RetakeTestApplicationID = Reader.IsDBNull(6) ? -1 : Reader.GetInt32(6);
                return true;
            }
            return false;
        }

        public static bool GetLastTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID,
            out int TestAppointmentID, out DateTime AppointmentDate,
            out decimal PaidFees, out int CreatedByUserID, out bool IsLocked, out int RetakeTestApplicationID)
        {
            TestAppointmentID = 0;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            RetakeTestApplicationID = 0;

            string Query = @"SELECT top 1 TestAppointmentID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID
                FROM TestAppointments
                WHERE (TestTypeID = @TestTypeID) 
                AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                order by TestAppointmentID Desc";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                TestAppointmentID = Reader.GetInt32(0);
                AppointmentDate = Reader.GetDateTime(1);
                PaidFees = Reader.GetDecimal(2);
                CreatedByUserID = Reader.GetInt32(3);
                IsLocked = Reader.GetBoolean(4);
                RetakeTestApplicationID = Reader.IsDBNull(5) ? -1 : Reader.GetInt32(5);
                return true;
            }
            return false;
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();
            string Query = @"select * from TestAppointments_View order by AppointmentDate Desc";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            string Query = @"SELECT TestAppointmentID, AppointmentDate,PaidFees, IsLocked
                        FROM TestAppointments
                        WHERE  
                        (TestTypeID = @TestTypeID) 
                        AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                        order by TestAppointmentID desc;";
            DataTable dt = new DataTable();
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, int RetakeTestApplicationID)
        {
            string Query = @"Insert Into TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID)
                            Values (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,0,@RetakeTestApplicationID);
                
                            SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (RetakeTestApplicationID == -1)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            Connection.Open();
            object result = Command.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate, decimal PaidFees,
             int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            string Query = @"Update  TestAppointments  
                            set TestTypeID = @TestTypeID,
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                AppointmentDate = @AppointmentDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsLocked=@IsLocked,
                                RetakeTestApplicationID=@RetakeTestApplicationID
                                where TestAppointmentID = @TestAppointmentID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)

                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static int GetTestID(int TestAppointmentID)
        {
            string Query = @"select TestID from Tests where TestAppointmentID=@TestAppointmentID;";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Connection.Open();
            object result = Command.ExecuteScalar();
            return result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }
    }
}
