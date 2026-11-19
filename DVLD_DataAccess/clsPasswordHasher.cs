using System;
using System.Security.Cryptography;
using System.Text;

namespace DVLD_DataAccess
{
    public static class clsPasswordHasher
    {
        public static string HashPassword(string Password)
        {
            byte[] HashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(Password));
            return Convert.ToHexString(HashBytes).ToLowerInvariant();
        }

        public static bool VerifyPassword(string Password, string StoredPassword)
        {
            if (StoredPassword.Length != 64)
                return false;

            byte[] ExpectedHash;
            try
            {
                ExpectedHash = Convert.FromHexString(StoredPassword);
            }
            catch (FormatException)
            {
                return false;
            }

            byte[] ActualHash = SHA256.HashData(Encoding.UTF8.GetBytes(Password));
            return CryptographicOperations.FixedTimeEquals(ActualHash, ExpectedHash);
        }
    }
}
