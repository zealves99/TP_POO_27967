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
using System.Xml.Linq;
using trabalhoPOO_27967.Interface;

namespace Data_BestSale
{
    /// <summary>
    /// Purpose:This file has the definition and methods to work with the plurality of Make.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 4:33:51 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Makes : IListManagement
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
        public bool Add(object obj)
        {
            if (obj == null) return false;
            if (obj is Make) {
                _makeList.Add((Make)obj);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to remove a make from a list of makes.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool Remove(object obj)
        {
            if (obj == null) return false;
            var aux = obj as Make;
            if (Exist(aux.ID))
            {
                _makeList.Remove((Make)obj);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a make exists on a list of makes, given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exist(object obj)
        {
            if (obj == null) return false;
            if (obj is int)
            {
                foreach (Make make in _makeList)
                {
                    if (make.ID == (int)obj)
                    {
                        return true;
                    }
                }
            }
            if(obj is string)
            {
                foreach (Make make in _makeList)
                {
                    if (make.Name == (string)obj)
                    {
                        return true;
                    }
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
