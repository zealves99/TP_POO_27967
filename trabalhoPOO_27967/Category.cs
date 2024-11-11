﻿/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:20:47 AM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Definition of Category and methods to deal with Category operations.
    /// Created by: Jose Alves a27967
    /// Created on: 11/6/2024 11:20:47 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Category
    {
        #region Attributes
        int _id;
        string _name;
        static int _catCount=0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Category()
        {
        }

        /// <summary>
        /// The constructor to use when the name of a category is given.
        /// </summary>
        /// <param name="name"></param>
        public Category(string name)
        {
            _id = ++_catCount;
            _name = name;
        }
        #endregion

        #region Properties

        /// <summary>
        /// The property to get and set the ID of a category.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// The property to get and set the name of a Category.
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
        ~Category()
        {
        }
        #endregion

        #endregion
    }
}
