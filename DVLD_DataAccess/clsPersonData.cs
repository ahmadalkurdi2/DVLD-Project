using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Input;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, out string FirstName, out string SecondName,
  out string ThirdName, out string LastName, out string NationalNo, out DateTime DateOfBirth,
   out byte Gendor, out string Address, out string Phone, out string Email,
   out short NationalityCountryID, out string ImagePath)
        {
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            NationalityCountryID = 0;
            NationalNo = string.Empty;
            DateOfBirth = DateTime.MinValue;
            ImagePath = string.Empty;
            Gendor = 0;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;

            string Query = @"SELECT FirstName, SecondName, ThirdName, LastName,
                            NationalNo, DateOfBirth, Gendor, Address,
                            Phone, Email, NationalityCountryID, ImagePath
                     FROM People
                     WHERE PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                FirstName = Reader.GetString(0);
                SecondName = Reader.GetString(1);
                ThirdName = Reader.IsDBNull(2) ? string.Empty : Reader.GetString(2);

                LastName = Reader.GetString(3);
                NationalNo = Reader.GetString(4);
                DateOfBirth = Reader.GetDateTime(5);
                Gendor = Reader.GetByte(6);
                Address = Reader.GetString(7);
                Phone = Reader.GetString(8);
                Email = Reader.IsDBNull(9) ? string.Empty : Reader.GetString(9);

                NationalityCountryID = Reader.GetInt16(10);
                ImagePath = Reader.IsDBNull(11) ? string.Empty : Reader.GetString(11);
                return true;
            }
            return false;
        }

        public static bool GetPersonInfoByNationalNo(
                string nationalNo, out int personId, out string firstName, out string secondName,
        out string thirdName, out string lastName, out DateTime dateOfBirth,
         out byte gender, out string address, out string phone, out string email,
         out short nationalityCountryID, out string imagePath)
        {
            // Initialize out parameters
            personId = 0;
            firstName = string.Empty;
            secondName = string.Empty;
            thirdName = string.Empty;
            lastName = string.Empty;
            dateOfBirth = DateTime.MinValue;
            gender = 0;
            address = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            nationalityCountryID = 0;
            imagePath = string.Empty;

            string query = @"SELECT PersonID, FirstName, SecondName, ThirdName, LastName,
                             DateOfBirth, Gendor, Address,
                            Phone, Email, NationalityCountryID, ImagePath
                     FROM People
                     WHERE NationalNo = @NationalNo";

            using var connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                personId = reader.GetInt32(0);
                firstName = reader.GetString(1);
                secondName = reader.GetString(2);
                thirdName = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                lastName = reader.GetString(4);
                dateOfBirth = reader.GetDateTime(5);
                gender = reader.GetByte(6);
                address = reader.GetString(7);
                phone = reader.GetString(8);
                email = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                nationalityCountryID = reader.GetInt16(10);
                imagePath = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                return true;
            }

            return false;
        }

        public static int AddNewPerson(string FirstName, string SecondName,
        string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
        byte Gendor, string Address, string Phone, string Email,
        short NationalityCountryID, string ImagePath)
        {
            string Query = @"INSERT INTO People (FirstName, SecondName, ThirdName,LastName,NationalNo,
                                           DateOfBirth,Gendor,Address,Phone, Email, NationalityCountryID,ImagePath)
                     VALUES (@FirstName, @SecondName,@ThirdName, @LastName, @NationalNo,
                             @DateOfBirth,@Gendor,@Address,@Phone, @Email,@NationalityCountryID,@ImagePath);
                     SELECT SCOPE_IDENTITY();";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", string.IsNullOrWhiteSpace(ThirdName) ? DBNull.Value : (object)ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(Email) ? DBNull.Value : (object)Email);
            Command.Parameters.AddWithValue("@ImagePath", string.IsNullOrWhiteSpace(ImagePath) ? DBNull.Value : (object)ImagePath);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            Connection.Open();
            object Result = Command.ExecuteScalar();
            return Result == DBNull.Value ? -1 : Convert.ToInt32(Result);
        }

        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName,
        string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
        byte Gendor, string Address, string Phone, string Email,
        short NationalityCountryID, string ImagePath)
        {
            string Query = @"Update  People  
                    set FirstName = @FirstName,
                        SecondName = @SecondName,
                        ThirdName = @ThirdName,
                        LastName = @LastName, 
                        NationalNo = @NationalNo,
                        DateOfBirth = @DateOfBirth,
                        Gendor=@Gendor,
                        Address = @Address,  
                        Phone = @Phone,
                        Email = @Email, 
                        NationalityCountryID = @NationalityCountryID,
                        ImagePath =@ImagePath
                        where PersonID = @PersonID";

            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", string.IsNullOrWhiteSpace(ThirdName) ? DBNull.Value : (object)ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(Email) ? DBNull.Value : (object)Email);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@ImagePath", string.IsNullOrWhiteSpace(ImagePath) ? DBNull.Value : (object)ImagePath);

            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string Query = @"
            SELECT People.PersonID,
            People.NationalNo,
            People.FirstName,
            People.SecondName,
            People.ThirdName,
            People.LastName,
            People.DateOfBirth,
            People.Gendor,
            CASE 
                WHEN People.Gendor = 0 THEN 'Male' 
                ELSE 'Female' 
            END AS GendorCaption,
            People.Address,
            People.Phone,
            People.Email,
            People.NationalityCountryID,
            Countries.CountryName,
            People.ImagePath
        FROM People
        INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
        ORDER BY People.FirstName";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            dt.Load(Reader);
            return dt;
        }

        public static bool DeletePerson(int PersonID)
        {
            string Query = @"Delete People where PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Connection.Open();
            return Command.ExecuteNonQuery() > 0;
        }

        public static bool IsPersonExist(int PersonID)
        {
            string Query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Connection.Open();
            using var Reader = Command.ExecuteReader();
            return Reader.HasRows;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            string Query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";
            using var Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            using var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            Connection.Open();
            using var Reader = Command.ExecuteReader();
            return Reader.HasRows;
        }
    }
}
