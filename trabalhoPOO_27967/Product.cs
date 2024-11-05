/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>11/2/2024 4:40:12 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 11/2/2024 4:40:12 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Product
    {
        #region Attributes
        string reference;
        double price;
        static int stock;
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
        public Product(string reff, double pri)
        {
            reference = reff;
            price = pri;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Property to set and get the reference of a product.
        /// </summary>
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
            
        }

        /// <summary>
        /// Property to get and set the value of the price of a product.
        /// </summary>
        public double Price
        {
            get { return price; }
            set {  price = value; }
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
