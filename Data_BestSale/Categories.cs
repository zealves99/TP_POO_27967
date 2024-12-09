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
using System.Xml.Linq;
using trabalhoPOO_27967.Interface;

namespace Data_BestSale
{
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
            var aux=obj as Category;
            
            ///If the ID is given
            if (obj is int)
            {
                foreach (Category cate in _cats)
                {
                    if (cate.Id == aux.Id)
                    {
                        return true;
                    }
                }
            }

            ///The Name is given
            if(obj is string)
            {
                foreach (Category cate in _cats)
                {
                    if (cate.Name == aux.Name)
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
        ~Categories()
        {
        }
        #endregion

        #endregion
    }
}
