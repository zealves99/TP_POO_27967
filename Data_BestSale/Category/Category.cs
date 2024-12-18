/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:20:47 AM</date>
*	<description></description>
**/
using System;

namespace Data_BestSale
{
    [Serializable]
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
            _id = ++_catCount;
            _name = string.Empty;
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
        /// <summary>
        /// Method that overrides Equals() and verifies if a categry matches another one.
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

            ///Casts the object to be Category.
            Category cat = obj as Category;
            return (this.Id == cat.Id || _name == cat.Name);
        }

        /// <summary>
        /// Redefinition of the Equal operator.
        /// </summary>
        /// <param name="cat1"></param>
        /// <param name="cat2"></param>
        /// <returns></returns>
        public static bool operator ==(Category cat1, Category cat2)
        {
            return (cat1.Equals(cat2));
        }

        /// <summary>
        /// Redefinition of the Not Equal Operator.
        /// </summary>
        /// <param name="cat1"></param>
        /// <param name="cat2"></param>
        /// <returns></returns>
        public static bool operator !=(Category cat1, Category cat2)
        {
            return !(cat1.Equals(cat2));
        }
        #endregion

        #region OtherMethods
        /// <summary>
        /// This method creates a new category instance.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <returns>True - if succeeded</returns>
        /// <returns>Exception - An error occurred.<returns>
        public static bool CreateCategory(string name, out Category category)
        {
            try
            {
                category = new Category(name);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
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
