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
        //public bool InsertContact(string contact) {

        //} 
        public bool CreateClient(SimpleClient sc) {
            
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
