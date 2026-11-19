using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Security.Cryptography;

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

            string Query = "SELECT PersonID, UserName, IsActive FROM Users WHERE UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                PersonID = Reader.GetInt32(0);
                UserName = Reader.GetString(1);
                IsActive = Reader.GetBoolean(2);
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
            string Query = "SELECT UserID, UserName, IsActive FROM Users WHERE PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                UserID = Reader.GetInt32(0);
                UserName = Reader.GetString(1);
                IsActive = Reader.GetBoolean(2);
                return true;
            }
            return false;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password, out int PersonID, out int UserID, out bool IsActive)
        {
            UserID = 0;
            PersonID = 0;
            IsActive = false;

            string query = "SELECT UserID, PersonID, Password, IsActive FROM Users WHERE UserName = @Username";
            using var connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", UserName);

            connection.Open();
            int foundUserID;
            int foundPersonID;
            bool foundIsActive;
            string storedPassword;
            using (var reader = command.ExecuteReader())
            {
                if (!reader.Read())
                    return false;

                foundUserID = reader.GetInt32(0);
                foundPersonID = reader.GetInt32(1);
                storedPassword = reader.GetString(2);
                foundIsActive = reader.GetBoolean(3);
            }

            bool isLegacyPassword = storedPassword.Length != 64 || !IsHexString(storedPassword);
            bool passwordMatches = isLegacyPassword
                ? string.Equals(Password, storedPassword, StringComparison.Ordinal)
                : clsPasswordHasher.VerifyPassword(Password, storedPassword);
            if (!passwordMatches)
                return false;

            if (isLegacyPassword)
            {
                using var updateCommand = new SqlCommand(
                    "UPDATE Users SET Password = @Password WHERE UserID = @UserID", connection);
                updateCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 64).Value = clsPasswordHasher.HashPassword(Password);
                updateCommand.Parameters.AddWithValue("@UserID", foundUserID);
                updateCommand.ExecuteNonQuery();
            }

            UserID = foundUserID;
            PersonID = foundPersonID;
            IsActive = foundIsActive;
            return true;
        }

        private static bool IsHexString(string Value)
        {
            foreach (char Character in Value)
            {
                if (!Uri.IsHexDigit(Character))
                    return false;
            }
            return true;
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
            Command.Parameters.Add("@Password", SqlDbType.NVarChar, 64).Value = clsPasswordHasher.HashPassword(Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            Connection.Open();
            object result = Command.ExecuteScalar();
            return result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName,
             bool IsActive)
        {
            string Query = @"UPDATE Users
                            SET PersonID = @PersonID,
                                UserName = @UserName,
                                IsActive = @IsActive
                            WHERE UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
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
            try
            {
                using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                using var Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@UserID", UserID);
                Connection.Open();
                return Command.ExecuteNonQuery() > 0;
            }
            catch (SqlException)
            {
                // Delete failed — likely due to a foreign key constraint
                // (e.g. InternationalLicenses.CreatedByUserID references this user).
                return false;
            }
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

        public static bool VerifyPassword(int UserID, string Password)
        {
            const string Query = "SELECT Password FROM Users WHERE UserID = @UserID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Connection.Open();
            object storedPassword = Command.ExecuteScalar();
            if (storedPassword == null || storedPassword == DBNull.Value)
                return false;

            string storedPasswordText = Convert.ToString(storedPassword);
            bool isHash = storedPasswordText.Length == 64 && IsHexString(storedPasswordText);
            return isHash
                ? clsPasswordHasher.VerifyPassword(Password, storedPasswordText)
                : string.Equals(Password, storedPasswordText, StringComparison.Ordinal);
        }

        public static bool ChangePassword(int UserID, string CurrentPassword, string NewPassword)
        {
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            Connection.Open();
            using var Transaction = Connection.BeginTransaction();

            const string selectQuery = "SELECT Password FROM Users WITH (UPDLOCK, ROWLOCK) WHERE UserID = @UserID";
            using var selectCommand = new SqlCommand(selectQuery, Connection, Transaction);
            selectCommand.Parameters.AddWithValue("@UserID", UserID);
            object storedPassword = selectCommand.ExecuteScalar();
            if (storedPassword == null || storedPassword == DBNull.Value)
            {
                Transaction.Rollback();
                return false;
            }

            string storedPasswordText = Convert.ToString(storedPassword);
            bool isHash = storedPasswordText.Length == 64 && IsHexString(storedPasswordText);
            bool passwordMatches = isHash
                ? clsPasswordHasher.VerifyPassword(CurrentPassword, storedPasswordText)
                : string.Equals(CurrentPassword, storedPasswordText, StringComparison.Ordinal);
            if (!passwordMatches)
            {
                Transaction.Rollback();
                return false;
            }

            const string updateQuery = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";
            using var updateCommand = new SqlCommand(updateQuery, Connection, Transaction);
            updateCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 64).Value = clsPasswordHasher.HashPassword(NewPassword);
            updateCommand.Parameters.AddWithValue("@UserID", UserID);
            bool updated = updateCommand.ExecuteNonQuery() > 0;
            if (updated)
                Transaction.Commit();
            else
                Transaction.Rollback();
            return updated;
        }
    }
}
