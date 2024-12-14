/*
*	<copyright file="Business_Layer.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/10/2024 10:57:31 PM</date>
*	<description></description>
**/
using System;
using System.Xml.Schema;
using Business_Object;
using Data_BestSale;

namespace Business_Layer
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 12/10/2024 10:57:31 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ManageClients
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ManageClients()
        {
        }

        #endregion

        #region Properties
        #endregion



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
        public static bool CreateClientInStore(string name, string contact) {
            Client client;
            try
            {
                Client.CreateClientFromNameContact(name, contact, out client);
                Store.InsertClientInStore(client);
                return true;
            }
            catch (Exception excep)
            {
                throw (excep);
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ManageClients()
        {
        }
        #endregion

        #endregion
    }
}
