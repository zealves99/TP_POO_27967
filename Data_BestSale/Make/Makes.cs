﻿/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 4:33:51 PM</date>
*	<description>This file has the definition and methods to work with the plurality of Make.</description>
**/
using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Data_BestSale
{
    [Serializable]
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

        /// <summary>
        /// Method used to Clear a list of Makes.
        /// </summary>
        public bool ClearMakes()
        {
            try{
            _makeList.Clear();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// This method finds a make instance, given its ID or Name.
        /// </summary>
        /// <param name="id">The Make ID</param>
        /// <returns>The make instance</returns>
        public Make GetMake(object obj )
        {
            if (obj == null) return null;
            if (obj is int)
            {
                if (this.Exist((int)obj))
                {
                    foreach (Make make in _makeList)
                    {
                        if (make.ID == (int)obj)
                        {
                            return make;
                        }
                    }
                }
            }
            if (obj is string)
            {
                if (this.Exist((string)obj))
                {
                    foreach (Make make in _makeList)
                    {
                        if (make.Name == (string)obj)
                        {
                            return make;
                        }
                    }
                }
            }
            return null;
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
