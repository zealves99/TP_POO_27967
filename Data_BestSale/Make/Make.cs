/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:22:09 AM</date>
*	<description></description>
**/
using System;
using System.Diagnostics.Contracts;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Data_BestSale
{
    [Serializable]
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
            _id = ++_makeCount;
            _name = string.Empty;
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
        /// <summary>
        /// Override of the ToString() method to convert the data of a Make to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Make : " + _name);
        }

        /// <summary>
        /// The redefinition of the Equals() Method, to verify if a make matches another one.
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

            ///Casts the object to be Make.
            Make make = obj as Make;
            return (this.ID == make.ID || this.Name == make.Name);
        }

        /// <summary>
        /// The redefinition of the Equal operator.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(Make m1, Make m2)
        {
            return (m1.Equals(m2));
        }

        /// <summary>
        /// The redefinition of the NOt Equal operator.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator !=(Make m1, Make m2)
        {
            return !(m1.Equals(m2));
        }
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method to create a new make, given its name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="make"></param>
        /// <returns></returns>
        public static bool CreateMake(string name, out Make make)
        {
            try
            {
                make = new Make(name);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method used to get the ID of a make.
        /// </summary>
        /// <returns>The ID of the make.</returns>
        public int GetMakeID()
        {
            return this.ID;
        }
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
