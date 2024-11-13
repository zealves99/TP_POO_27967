/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>10/29/2024 4:23:56 PM</date>
*	<description></description>
**/
using System;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Definition of Client and methods to deal with Client operations.
    /// Created by: Jose Alves a27967
    /// Created on: 10/29/2024 4:23:56 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Client
    {
        #region Attributes
        int _clientID;
        string _name;
        string _contact;
        static int _clientCount=0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Client()
        {
            _clientID = ++_clientCount ;
            _name = "No Name";
            _contact = "999999999";
        }

        /// <summary>
        /// Constructor to use when a name and a contact are given.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        public Client(string n, string c)
        {
            _clientID = ++_clientCount;
            _name = n;
            _contact = c;
            //COMO POSSO FAZER PARA TESTAR SE A STRING PODE SER CONTATCO? DEVO FAZE-LO NO CONSTRUTOR OU FORA?
        }

        #endregion

        #region Properties
        /// <summary>
        /// Property that sets or returns the ID of a client.
        /// </summary>
        public int ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }

        /// <summary>
        /// Property that sets or returns the Name of a client.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Property that sets or returns the Contact of a client.
        /// </summary>
        public string Contact
        {
            get { return _contact; }
            set
            {
                string pattern = @"^(2|9)\d{8}$"; //Defines the pattern to be a number starting by 9 or 2 with 8 more numbers after (as a portuguese mobile or landline number).
                bool isGood = Regex.IsMatch(value, pattern); //Verifies if the value meets the criteria.

                if (isGood) _contact = value;

                //COMO POSSO RETORNAR UM ERRO CASO A STRING NAO CORRESPONDA?
            }
        }

        /// <summary>
        /// Property that sets or returns the amount of clients.
        /// </summary>
        public static int ClientCount
        {
            get { return _clientCount; }

            set { _clientCount = value; }
        }
        #endregion



        #region Overrides

        /// <summary>
        /// Redefine the ToString Function to show a client's info.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Client ID: {_clientID}");
            sb.AppendLine($"Name: {_name}");
            sb.AppendLine($"Contact: {_contact}");

            return sb.ToString();
        }

        /// <summary>
        /// Redefine the Equals operator to verify if a client matches the other.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            /// Veriffies if the object given is null.
            if (obj == null)
            {
                return false;
            }

            ///Casts the object to be Client.
            Client client = obj as Client;
            return (this._clientID == client._clientID && _name == client._name);
        }

        /// <summary>
        /// Redefinition of the == operator.
        /// </summary>
        /// <param name="cli1"></param>
        /// <param name="cli2"></param>
        /// <returns></returns>
        public static bool operator == (Client cli1, Client cli2)
        {
            return( cli1.Equals(cli2) );
        }

        /// <summary>
        /// Redefinition of the != operator.
        /// </summary>
        /// <param name="cli1"></param>
        /// <param name="cli2"></param>
        /// <returns></returns>
        public static bool operator !=(Client cli1, Client cli2)
        {
            return !(cli1.Equals(cli2));
        }
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
