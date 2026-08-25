using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {
        public static bool GetTestTypeInfoByID(int TestTypeID,
            out string TestTypeTitle, out string TestDescription, out decimal TestFees)
        {
            TestTypeTitle = string.Empty;
            TestDescription = string.Empty;
            TestFees = decimal.Zero;
            string Query = "SELECT TestTypeTitle, TestTypeDescription, TestTypeFees FROM TestTypes WHERE TestTypeID = @TestTypeID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if(Reader.Read())
            {
                TestTypeTitle = Reader.IsDBNull(0) ? string.Empty : Reader.GetString(0);
                TestDescription = Reader.IsDBNull(1) ? string.Empty : Reader.GetString(1);
                TestFees = Reader.IsDBNull(2) ? decimal.Zero : Reader.GetDecimal(2);
                return true;
            }
            return false;
        }

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT * FROM TestTypes order by TestTypeID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewTestType(int TestTypeID,string Title, string Description, decimal Fees)
        {
            string Query = @"Insert Into TestTypes (TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees)
                            Values (@TestTypeID,@TestTypeTitle,@TestTypeDescription,@ApplicationFees);
                            SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", Title);
            Command.Parameters.AddWithValue("@TestTypeDescription", Description);
            Command.Parameters.AddWithValue("@ApplicationFees", Fees);
            Connection.Open();
            object result = Command.ExecuteScalar();
            return result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }

        public static bool UpdateTestType(int TestTypeID, string Title, string Description, decimal Fees)
        {
            string Query = @"Update  TestTypes  
                            set TestTypeTitle = @TestTypeTitle,
                                TestTypeDescription=@TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                                where TestTypeID = @TestTypeID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", Title);
            Command.Parameters.AddWithValue("@TestTypeDescription", Description);
            Command.Parameters.AddWithValue("@TestTypeFees", Fees);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}
