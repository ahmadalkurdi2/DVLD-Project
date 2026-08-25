using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsLicenseClassData
    {
        public static bool GetLicenseClassInfoByID(int LicenseClassID,
            out string ClassName, out string ClassDescription, out byte MinimumAllowedAge,
            out byte DefaultValidityLength, out decimal ClassFees)
        {
            ClassName =string.Empty;
            ClassDescription =string.Empty;
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;

            string Query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if(Reader.Read())
            {
                ClassName = Reader.GetString(0);
                ClassDescription = Reader.GetString(1);
                MinimumAllowedAge = Reader.GetByte(2);
                DefaultValidityLength = Reader.GetByte(3);
                ClassFees = Reader.GetDecimal(4);
                return true;
            }
            return false;
        }

        public static bool GetLicenseClassInfoByClassName(string ClassName, out int LicenseClassID,
            out string ClassDescription, out byte MinimumAllowedAge,
           out byte DefaultValidityLength, out decimal ClassFees)
        {
            LicenseClassID = 0;
            ClassDescription=string.Empty;
            MinimumAllowedAge=0;
            DefaultValidityLength = 0;
            ClassFees=0;

            string Query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClassName", ClassName);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if(Reader.Read())
            {
                LicenseClassID = Reader.GetInt32(0);
                ClassDescription= Reader.GetString(1);
                MinimumAllowedAge=Reader.GetByte(2);
                DefaultValidityLength= Reader.GetByte(3);
                ClassFees = Reader.GetDecimal(4);
                return true;
            }
            return false;
        }

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT * FROM LicenseClasses order by ClassName";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static int AddNewLicenseClass(string ClassName, string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            string Query = @"Insert Into LicenseClasses 
           (
            ClassName,ClassDescription,MinimumAllowedAge, 
            DefaultValidityLength,ClassFees)
                            Values ( 
            @ClassName,@ClassDescription,@MinimumAllowedAge, 
            @DefaultValidityLength,@ClassFees);
                            
                            SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClassName", ClassName);
            Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", ClassFees);

            Connection.Open();
            object Result = Command.ExecuteScalar();

            return Result == DBNull.Value ? -1 : Convert.ToInt32(Result);
        }

        public static bool UpdateLicenseClass(int LicenseClassID, string ClassName,
            string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            string Query = @"Update  LicenseClasses  
                            set ClassName = @ClassName,
                                ClassDescription = @ClassDescription,
                                MinimumAllowedAge = @MinimumAllowedAge,
                                DefaultValidityLength = @DefaultValidityLength,
                                ClassFees = @ClassFees
                                where LicenseClassID = @LicenseClassID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@ClassName", ClassName);
            Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", ClassFees);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}
