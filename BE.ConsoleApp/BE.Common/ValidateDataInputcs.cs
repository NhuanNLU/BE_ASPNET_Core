using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Common
{
    public static class ValidateDataInputcs
    {
        public static bool ChecValidatenumber(string inputNumber)
        {
            return int.TryParse(inputNumber, out _);
        }
        public static bool CheckValidateString(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return false;
            if(int.TryParse(inputString, out int num)) return false;
            if(inputString.Length > 200) return false;
            return true;
        }
    }
}
