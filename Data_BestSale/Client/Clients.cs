/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/12/2024 9:25:28 PM</date>
*	<description>Class with the definition and methods to manage a list of clients.</description>
**/
using System;
using System.Collections.Generic;

namespace Data_BestSale
{
    [Serializable]
    /// <summary>
    /// Purpose: Class with the definition and methods to manage a list of clients.
    /// Created by: Jose Alves a27967
    /// Created on: 11/12/2024 9:25:28 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Clients : IListManagementItem<Client>
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
        /// Method to add a client to a clients' list.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns>True - Client has been successfully added to the list.</returns>
        /// <returns>False - The list already contains the client or an error occurred.</returns>
        public bool Add(Client client)
        {
            if(client==null || Exist(client))
            {
                return false;
            }
            _clientList.Add(client);
            return true;
        }

        /// <summary>
        /// Method to remove a client from the store's client list.
        /// </summary>
        /// <param name="client">The client instance to remove.</param>
        /// <returns>True - Client Removed successfully.</returns>
        /// <returns>False - Client was NOT removed.</returns>
        public bool Remove(Client client)
        {
            if (client == null || !(Exist(client)))
            {
                return false;
            }
            _clientList.Remove(client);
            return true;
        }

        /// <summary>
        /// Method to check if a client is listed on a clients' list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exist(Client client)
        {
            foreach(Client _client in _clientList)
            {
                if(_client.ClientID==client.ClientID)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to get a client from a clients' list.
        /// </summary>
        /// <param name="id">The Id of the client you want to find. n</param>
        /// <returns>The instance of client.</returns>
        public Client GetClient(int id)
        {
            foreach (Client client in _clientList)
            {
                if (client.ClientID == id)
                {
                    return client;
                }
            }
            return null;
        }

        /// <summary>
        /// Method used to Clear a list of Clients.
        /// </summary>
        public bool ClearClients()
        {
            try
            {
                _clientList.Clear();
                return true;
            }
            catch
            {
                return false;
            }
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
