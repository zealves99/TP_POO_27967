using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BestSale_Validations
{
    public static class BestSale_Validations
    {
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^(2|9)\d{8}$"; //Defines the pattern to be a number starting by 9 or 2 with 8 more numbers after (as a portuguese mobile or landline number).
            return Regex.IsMatch(phoneNumber, pattern); //Verifies if the value meets the criteria.

        }
    }
}
