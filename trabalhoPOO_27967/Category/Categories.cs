/*
*	<copyright file="trabalhoPOO_27967.Category.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 4:45:58 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:This file has the definition and methods to work with the plurality of Category.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 4:45:58 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Categories
    {
        #region Attributes
        List<Category> _cats;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Categories()
        {
            _cats = new List<Category>();
        }

        /// <summary>
        /// The constructor to use when a list of categories is given.
        /// </summary>
        /// <param name="cats"></param>
        public Categories(List<Category> cats)
        {
            _cats = cats;
        }


        #endregion

        #region Properties
        /// <summary>
        /// The property used to get and set the list of categories.
        /// </summary>
        public List<Category> Cats
        {
            get { return _cats; }
            set { _cats = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        ///Method used to add a category to a list of categories. 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AddCategory(Category c)
        {
            if (c == null) return false;
            _cats.Add(c);
            return true;
        }

        /// <summary>
        /// Method used to remove a category from a list of categories.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool RemoveCategory(Category c)
        {
            foreach (Category cate in _cats)
            {
                if (cate == c)
                {
                    _cats.Remove(cate);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a category exists on a list of makes, given its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistCategory(int id)
        {
            foreach (Category cate in _cats)
            {
                if (cate.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a Category exists on a list of categories, given its name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistCategory(string name)
        {
            foreach (Category cate in _cats)
            {
                if (cate.Name == name)
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
        ~Categories()
        {
        }
        #endregion

        #endregion
    }
}
