using System;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Win32;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.Global_Classes
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        private const string CredentialsRegistryPath = @"HKEY_CURRENT_USER\Software\DVLD";
        private const string UserNameValueName = "UserName";
        private const string PasswordValueName = "Password";

        // Encrypt plain text string into a Base64 encoded encrypted string using DPAPI
        private static string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;

            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            // Protect data scoped to the current Windows user
            byte[] encryptedBytes = ProtectedData.Protect(plainBytes, null, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encryptedBytes);
        }

        // Decrypt Base64 encoded encrypted string back to plain text
        private static string DecryptString(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText)) return string.Empty;

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                // Unprotect data scoped to the current Windows user
                byte[] plainBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);

                return Encoding.UTF8.GetString(plainBytes);
            }
            catch
            {
                return string.Empty; // Fallback if decryption fails or tampering occurs
            }
        }

        public static bool RememberUsernameAndPassword(string UserName, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(UserName))
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"Software\DVLD", throwOnMissingSubKey: false);
                    return true;
                }

                // Encrypt both username and password before writing to the registry
                string encryptedUser = EncryptString(UserName);
                string encryptedPass = EncryptString(Password);

                Registry.SetValue(CredentialsRegistryPath, UserNameValueName, encryptedUser, RegistryValueKind.String);
                Registry.SetValue(CredentialsRegistryPath, PasswordValueName, encryptedPass, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            try
            {
                object? StoredUserName = Registry.GetValue(CredentialsRegistryPath, UserNameValueName, null);
                object? StoredPassword = Registry.GetValue(CredentialsRegistryPath, PasswordValueName, null);

                if (StoredUserName is string encryptedUserNameValue &&
                    StoredPassword is string encryptedPasswordValue &&
                    !string.IsNullOrEmpty(encryptedUserNameValue))
                {
                    // Decrypt the stored values before passing them back
                    UserName = DecryptString(encryptedUserNameValue);
                    Password = DecryptString(encryptedPasswordValue);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}