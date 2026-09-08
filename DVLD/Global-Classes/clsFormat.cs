using System;

namespace DVLD.Global_Classes
{
    public class clsFormat
    {
        public static string DateToShort(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }
    }
}