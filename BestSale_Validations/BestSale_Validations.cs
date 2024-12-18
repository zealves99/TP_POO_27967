/*
*	<copyright file="BestSale_Validations.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>12/17/2024 6:23:56 PM</date>
*	<description>This file contains the validations to be made by the app.</description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exceptions;

namespace BestSale_Validations
{
    public static class BestSale_Validations
    {
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^(2|9)\d{8}$"; //Defines the pattern to be a number starting by 9 or 2 with 8 more numbers after (as a portuguese mobile or landline number).
            if (Regex.IsMatch(phoneNumber, pattern)) return true; //Verifies if the value meets the criteria.

            else throw new InvalidPhoneNumberException();

        }
    }
}
