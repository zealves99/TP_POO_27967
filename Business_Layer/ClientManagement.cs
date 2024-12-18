/*
*	<copyright file="Business_Layer.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/10/2024 10:57:31 PM</date>
*	<description>This file has all the necessary calls to the back end to manage clients.</description>
**/
using System;
using System.Xml.Schema;
using Business_Object;
using Data_BestSale;
using BestSale_Validations;

namespace Business_Layer
{
    /// <summary>
    /// Purpose:This namespace has all the necessary calls to the back end to manage clients.
    /// Created by: zecun
    /// Created on: 12/10/2024 10:57:31 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class ClientManagement
    {

        #region Methods

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Create a Client and add it to the store's list of clients.
        /// </summary>
        /// <param name="name">Client's Name</param>
        /// <param name="contact">Client's Contact</param>
        /// <returns>True - Client Successfully created and added to the list.</returns>
        /// <returns>Exception - An error occurred in the process.
        public static bool CreateClientInStore(string name, string contact)
        {
            try
            {
                if (BestSale_Validations.BestSale_Validations.ValidatePhoneNumber(contact))
                {
                    bool aux = Client.CreateClientFromNameContact(name, contact, out Client newClient);
                    aux = Store.InsertClientInStore(newClient);
                    return aux;
                }
                return false;
            }
            catch(Exceptions.InvalidPhoneNumberException invalidPhoneNumber)
            {
                throw invalidPhoneNumber;
            }
            catch (Exception excep)
            {
                throw (excep);
            }
        }
        #endregion

        #endregion
    }
}
