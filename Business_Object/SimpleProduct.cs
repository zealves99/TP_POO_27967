/*
*	<copyright file="Business_Object.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/11/2024 11:18:40 AM</date>
*	<description></description>
**/
using System;

namespace Business_Object
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 12/11/2024 11:18:40 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class SimpleProduct
    {
        #region Attributes
        string _reference;
        decimal _price;
        int _makeID;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public SimpleProduct()
        {
        }

        /// <summary>
        /// The constructor to use when a reference, price and makeID are given.
        /// </summary>
        /// <param name="reff">Product Reference</param>
        /// <param name="price">Product Price</param>
        /// <param name="make">Make ID</param>
        public SimpleProduct(string reff, decimal price, int make) {
            _reference = reff;
            _price = price;
            _makeID = make;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Property to set and get the reference of a SimpleProduct object.
        /// </summary>
        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }

        }

        /// <summary>
        /// Property to get and set the price of a SimpleProduct object.
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// Property to set and get the Make of a SimpleProduct object.
        /// </summary>
        public int Make
        {
            get { return _makeID; }
            set { _makeID = value; }

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
        ~SimpleProduct()
        {
        }
        #endregion

        #endregion
    }
}
