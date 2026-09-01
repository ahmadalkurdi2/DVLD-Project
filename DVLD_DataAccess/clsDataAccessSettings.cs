using System.Configuration;

namespace DVLD_DataAccess
{
    internal static class clsDataAccessSettings
    {
        public static string ConnectionString
        {
            get
            {
                // Notice the full "System.Configuration." prefix to avoid conflicts
                return System.Configuration.ConfigurationManager.ConnectionStrings["DVLDConnection"].ConnectionString;
            }
        }
    }
}