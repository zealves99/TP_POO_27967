﻿/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 4:45:58 PM</date>
*	<description>This file has the definition and methods to work with the plurality of Category.</description>
**/
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Data_BestSale
{
    [Serializable]
    /// <summary>
    /// Purpose:This file has the definition and methods to work with the plurality of Category.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 4:45:58 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Categories : IListManagement
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
        public bool Add(object obj)
        {
            if (obj == null) return false;
            if (obj is Category)
            {
                _cats.Add((Category)obj);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to remove a category from a list of categories.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Remove(object obj)
        {
            if (obj == null) return false;
            var aux = obj as Category;
            if (Exist(aux.Id) || Exist(aux.Name))
            {
                _cats.Remove((Category)obj);
                return true;

            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a category exists on a list of makes, given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exist(object obj)
        {
            if (obj == null) return false;
            
            
            ///If the ID is given
            if (obj is int)
            {
                int aux = (int)obj;
                foreach (Category cate in _cats)
                {
                    if (cate.Id == aux)
                    {
                        return true;
                    }
                }
            }

            ///The Name is given
            if(obj is string)
            {
                string aux = (string)obj;
                foreach (Category cate in _cats)
                {
                    if (cate.Name == aux)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to Clear a list of Categories.
        /// </summary>
        public bool ClearCategories()
        {
            try
            {
                _cats.Clear();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// This method returns a category, given its name or id.
        /// </summary>
        /// <param name="obj">The ID or Name of the Category.</param>
        /// <returns>The category</returns>
        public Category GetCategory(object obj)
        {
            if (obj == null) return null;
            if (obj is int)
            {
                if (this.Exist((int)obj))
                {
                    foreach (Category cat in _cats)
                    {
                        if (cat.Id == (int)obj)
                        {
                            return cat;
                        }
                    }
                }
            }
            if (obj is string)
            {
                if (this.Exist((string)obj))
                {
                    foreach (Category cat in _cats)
                    {
                        if (cat.Name == (string)obj)
                        {
                            return cat;
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
        ~Categories()
        {
        }
        #endregion

        #endregion
    }
}
