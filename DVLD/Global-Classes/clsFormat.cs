using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Global_Classes
{
    public class clsFormat
    {
        public static string DateToShort(DateTime date)
        {
            return date.ToString("dd/mm/yyyy");
        }
    }
}
