/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/12/2024 9:25:28 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Class with the definition and methods to manage a list of clients.
    /// Created by: Jose Alves a27967
    /// Created on: 11/12/2024 9:25:28 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Clients
    {
        #region Attributes
        static List<Client> _clientList;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Clients()
        {
            _clientList = new List<Client>();
        }


        #endregion

        #region Properties

        /// <summary>
        /// Property used to get and set the client list.
        /// </summary>
        public List<Client> ClientList
        {
            get{ return _clientList; }
            set{ _clientList = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method to add a client to the store's client list.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool AddClient(Client cli)
        {
            if (cli == null) return false;
            this.ClientList.Add(cli);
            return true;
        }

        /// <summary>
        /// Method to remove a client from the store's client list.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool RemoveClient(Client cli)
        {
            foreach(Client client in _clientList)
            {
                if (client == cli)
                {
                    _clientList.Remove(cli);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Clients()
        {
        }
        #endregion

        #endregion
    }
}
