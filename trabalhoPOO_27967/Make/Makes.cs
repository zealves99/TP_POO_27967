/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 4:33:51 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:This file has the definition and methods to work with the plurality of Make.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 4:33:51 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Makes
    {
        #region Attributes
        List<Make> _makeList;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Makes()
        {
            _makeList = new List<Make>();
        }

        /// <summary>
        /// The constructor to use when a list of Make is given.
        /// </summary>
        /// <param name="m"></param>
        public Makes(List<Make> m)
        {
            _makeList = m;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The property to get and set a list of Make.
        /// </summary>
        public List<Make> MakeList
        {
            get { return _makeList; }
            set { _makeList = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        ///Method used to add a make to a list of makes. 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool AddMake(Make m)
        {
            if (m == null) return false;
            _makeList.Add(m);
            return true;
        }

        /// <summary>
        /// Method used to remove a make from a list of makes.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool RemoveMake(Make m)
        {
            foreach (Make make in _makeList)
            {
                if (make == m)
                {
                    _makeList.Remove(make);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a make exists on a list of makes, given its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistMake(int id)
        {
            foreach (Make make in _makeList)
            {
                if(make.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a make exists on a list of makes, given its name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistMake(string name)
        {
            foreach (Make make in _makeList)
            {
                if (make.Name == name)
                {
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
        ~Makes()
        {
        }
        #endregion

        #endregion
    }
}
