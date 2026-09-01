using System.Configuration;

namespace DVLD_DataAccess
{
    internal static class DataAccessSettings
    {
        public static string ConnectionString
        {
            get
            {
                // 1. Try to read the connection string from App.config
                var configString = ConfigurationManager.ConnectionStrings["DVLDConnection"]?.ConnectionString;

                // 2. If App.config is missing or empty, fallback to Windows Authentication
                if (string.IsNullOrEmpty(configString))
                {
                    return "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;";
                }

                // 3. Otherwise, use the one from App.config
                return configString;
            }
        }
    }
}