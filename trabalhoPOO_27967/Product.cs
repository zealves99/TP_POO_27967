/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/2/2024 4:40:12 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Definition of product and methods to deal with product operations.
    /// Created by: Jose Alves a27967
    /// Created on: 11/2/2024 4:40:12 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Product
    {
        #region Attributes
        string _reference;
        decimal _price;
        Make _make;
        Category _category;
        int _stock;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Constructor for when the reference and price are given.
        /// </summary>
        /// <param name="reff"></param>
        /// <param name="pri"></param>
        public Product(string reff, decimal pri, Make ma, Category cat)
        {
            _reference = reff;
            _price = pri;
            _make = ma;
            _category = cat;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Property to set and get the reference of a product.
        /// </summary>
        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }
            
        }

        /// <summary>
        /// Property to get and set the price of a product.
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set {  _price = value; }
        }

        /// <summary>
        /// Property to set and get the Make of a product.
        /// </summary>
        public Make Make
        {
            get { return _make; }
            set { _make = value; }

        }

        /// <summary>
        /// Property to set and get the Category of a product.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Property to get and set the existing stock of a product.
        /// </summary>
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
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
        ~Product()
        {
        }
        #endregion

        #endregion
    }
}
