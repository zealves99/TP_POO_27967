﻿/*
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
using System.Web;

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
        /// <returns>False - An error occurred.</returns>
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
            catch(Exceptions.InvalidPhoneNumberException)
            {
                ///The method returns false, so that the front end does not depend on C#. Returns a primitive data type.
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Teste(string n, string c)
        {
            Client test = new Client(n, c);
            bool aux=Store.InsertClientInStore(test);
            return aux;
        }
        #endregion

        #endregion
    }
}
