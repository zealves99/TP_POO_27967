/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:22:09 AM</date>
*	<description></description>
**/
using System;
using System.Runtime.Remoting.Messaging;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Definition of Make and methods to deal with Make operations.
    /// Created by: Jose Alves a27967
    /// Created on: 11/6/2024 11:22:09 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Make
    {
        #region Attributes
        int _id;
        string _name;
        static int _makeCount=0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Make()
        {
        }

        /// <summary>
        /// Constructor when the name of the make is given. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Make(string name)
        {
            _id = ++_makeCount;
            _name = name;
        }



        #endregion

        #region Properties

        /// <summary>
        /// Property to set and get the ID of a Make.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Property to get and set the Name of a Make.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        ~Make()
        {
        }
        #endregion

        #endregion
    }
}
