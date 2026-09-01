using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_DataAccess
{
    internal static class clsDataAccessSettings
    {
        public static string ConnectionString
        {
            get
            {
                return "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;";
            }
        }
    }
}
