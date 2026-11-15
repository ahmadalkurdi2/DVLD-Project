using DVLD_Business;
using Microsoft.Win32;

namespace DVLD.Global_Classes
{// C#
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        private const string CredentialsRegistryPath = @"HKEY_CURRENT_USER\Software\DVLD";
        private const string UserNameValueName = "UserName";
        private const string PasswordValueName = "Password";

        public static bool RememberUsernameAndPassword(string UserName, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(UserName))
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"Software\DVLD", throwOnMissingSubKey: false);
                    return true;
                }

                Registry.SetValue(CredentialsRegistryPath, UserNameValueName, UserName, RegistryValueKind.String);
                Registry.SetValue(CredentialsRegistryPath, PasswordValueName, Password, RegistryValueKind.String);

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

                if (StoredUserName is string UserNameValue &&
                    StoredPassword is string PasswordValue &&
                    !string.IsNullOrEmpty(UserNameValue))
                {
                    UserName = UserNameValue;
                    Password = PasswordValue;
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
