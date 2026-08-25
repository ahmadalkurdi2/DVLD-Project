using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, out int PersonID, out string UserName,
            out string Password, out bool IsActive)
        {
            PersonID = 0;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;

            string Query = "SELECT PersonID, UserName, Password, IsActive FROM Users WHERE UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                PersonID = Reader.GetInt32(0);
                UserName = Reader.GetString(1);
                Password = Reader.GetString(2);
                IsActive = Reader.GetBoolean(3);
                return true;
            }
            return false;
        }

        public static bool GetUserInfoByPersonID(int PersonID, out int UserID, out string UserName,
          out string Password, out bool IsActive)
        {
            UserID = 0;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            string Query = "SELECT * FROM Users WHERE PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                UserID = Reader.GetInt32(0);
                UserName = Reader.GetString(1);
                Password = Reader.GetString(2);
                IsActive = Reader.GetBoolean(3);
                return true;
            }
            return false;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password, out int PersonID, out int UserID, out bool IsActive)
        {
            UserID = 0;
            PersonID = 0;
            IsActive = false;

            string query = @"SELECT UserID, PersonID, UserName, Password, IsActive 
                     FROM Users 
                     WHERE UserName = @Username AND Password = @Password";

            using var connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                UserID = reader.GetInt32(0);
                PersonID = reader.GetInt32(1);
                IsActive = reader.GetBoolean(4);
                return true;
            }

            return false;
        }

        public static int AddNewUser(int PersonID, string UserName,
             string Password, bool IsActive)
        {
            string Query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)
                             VALUES (@PersonID, @UserName,@Password,@IsActive);
                             SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            Connection.Open();
            object result = Command.ExecuteScalar();
            return result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName,
             string Password, bool IsActive)
        {
            string Query = @"Update  Users  
                            set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                                where UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@UserID", UserID);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string Query = @"SELECT  Users.UserID, Users.PersonID,
                            FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName,
                             Users.UserName, Users.IsActive
                             FROM  Users INNER JOIN
                                    People ON Users.PersonID = People.PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Connection.Open();
            using var reader = Command.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public static bool DeleteUser(int UserID)
        {
            string Query = @"Delete Users 
                                where UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool IsUserExist(int UserID)
        {
            string Query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            return Reader.HasRows;
        }

        public static bool IsUserExist(string UserName)
        {
            string Query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            return Reader.HasRows;
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            string Query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            return Reader.HasRows;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            string Query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@Password", NewPassword);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }
    }
}
