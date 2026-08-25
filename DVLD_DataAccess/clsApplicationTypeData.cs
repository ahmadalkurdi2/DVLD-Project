using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsApplicationTypeData
    {
        public static bool GetApplicationTypeInfoByID(int ApplicationTypeID, out string ApplicationTypeTitle, out decimal ApplicationFees)
        {
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = 0;

            string Query = "SELECT ApplicationTypeTitle, ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                ApplicationTypeTitle = Reader.GetString(0);
                ApplicationFees = Reader.GetDecimal(1);
                return true;
            }
            return false;
        }

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            string Query = "select * from ApplicationTypes order by ApplicationTypeTitle";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewApplicationType(string ApplicationTypeTitle, decimal ApplicationFees)
        {
            string Query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@ApplicationTypeTitle,@ApplicationFees)
                            SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            Connection.Open();
            object Result = Command.ExecuteScalar();
            return Result == DBNull.Value ? -1 : Convert.ToInt32(Result);
        }

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            string Query = @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @ApplicationTypeTitle,
                                ApplicationFees = @ApplicationFees
                                where ApplicationTypeID = @ApplicationTypeID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection); Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}
