/*
*	<copyright file="InvalidPhoneNumberException.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>12/17/2024 6:23:56 PM</date>
*	<description>This file contains the exceptions to be handled by the app, when it comes to the validation of phone numbers.</description>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// This exception to be throws when a string doesn't match the phone number pattern.
    /// </summary>
    public class InvalidPhoneNumberException : ApplicationException
    {
        public InvalidPhoneNumberException() : base("Invalid Phone Number") { }
        
        public InvalidPhoneNumberException(string message) : base(message) { }

        public InvalidPhoneNumberException(string message, Exception e)
        {
            throw new InvalidPhoneNumberException(e.Message + "-" + message);
        }
        
    }
}
