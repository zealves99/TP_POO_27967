/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>10/29/2024 4:23:56 PM</date>
*	<description></description>
**/
using System;
using System.Text.RegularExpressions;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 10/29/2024 4:23:56 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Client
    {
        #region Attributes
        int clientID;
        string name;
        string contact;
        static int clientCount=0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Client()
        {
            clientID = ++clientCount ;
            name = "No Name";
            contact = "999999999";
        }

        public Client(string n, string c)
        {
            clientID = ++clientCount;
            name = n;
            contact = c;
            //COMO POSSO FAZER PARA TESTAR SE A STRING PODE SER CONTATCO? DEVO FAZE-LO NO CONSTRUTOR OU FORA?
        }

        #endregion

        #region Properties
        /// <summary>
        /// Property that sets or returns the ID of a client.
        /// </summary>
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        /// <summary>
        /// Property that sets or returns the Name of a client.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Property that sets or returns the Contact of a client.
        /// </summary>
        public string Contact
        {
            get { return contact; }
            set
            {
                string pattern = @"^(2|9)\d{8}$"; //Defines the pattern to be a number starting by 9 or 2 with 8 more numbers after (as a portuguese mobile or landline number).
                bool isGood = Regex.IsMatch(value, pattern); //Verifies if the value meets the criteria.

                if (isGood) contact = value;

                //COMO POSSO RETORNAR UM ERRO CASO A STRING NAO CORRESPONDA?
            }
        }

        /// <summary>
        /// Property that sets or returns the amount of clients.
        /// </summary>
        public static int ClientCount
        {
            get { return ClientCount; }

            set { ClientCount = value; }
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
        ~Client()
        {
        }
        #endregion

        #endregion
    }
}
