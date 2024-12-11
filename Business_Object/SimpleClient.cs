/*
*	<copyright file="Business_Object.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/10/2024 10:26:03 PM</date>
*	<description></description>
**/
using System;
using System.Runtime.Remoting.Messaging;

namespace Business_Object
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 12/10/2024 10:26:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class SimpleClient
    {
        #region Attributes
        string _name;
        int _clientID;
            
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public SimpleClient()
        {
        }

        /// <summary>
        /// The constructor used to create a simple form of a client, given its name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="clientID"></param>
        public SimpleClient(string name)
        {
            _name = name;
            _clientID = -1;
        }



        #endregion

        #region Properties
        /// <summary>
        /// Property used to get and set the name of a SimpleClient object.
        /// </summary>
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Property used to get and set the ID of a SimpleClient object.
        /// </summary>
        public int ClientID {
            get { return _clientID;}
            set { _clientID = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~SimpleClient()
        {
        }
        #endregion

        #endregion
    }
}
