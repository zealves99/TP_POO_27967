/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/2/2024 4:40:12 PM</date>
*	<description></description>
**/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Linq;

namespace Data_BestSale
{
    [Serializable]
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
        int _makeID;
        int _categoryID;
        Warranty _warranty; //in Years
        int _stock;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Product()
        {
            _reference = string.Empty;
            _price = -1;
            _makeID = -1;
            _categoryID = -1;
            _stock = 0;
        }

        /// <summary>
        /// Constructor for when the reference, price and warranty duration are given.
        /// </summary>
        /// <param name="reff"></param>
        /// <param name="pri"></param>
        public Product(string reff, decimal price, Warranty warranty, int make, int category)
        {
            _reference = reff;
            _price = price;
            _makeID = make;
            _categoryID = category;
            _warranty = warranty;

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
            set { _price = value; }
        }

        /// <summary>
        /// Property to set and get the Make of a product.
        /// </summary>
        public int MakeID
        {
            get { return _makeID; }
            set { _makeID = value; }

        }

        /// <summary>
        /// Property to set and get the Category of a product.
        /// </summary>
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        /// <summary>
        /// Property to get and set the existing stock of a product.
        /// </summary>
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public Warranty Warranty
        {
            get { return _warranty; }
            set { _warranty = value; }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Redefinition of the method to compare two products.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {   
            if (obj == null) return false;
            Product product = obj as Product;
            if (product.Reference == _reference) return true;
            return false;
        }

        /// <summary>
        /// Redefinition of the equal operator.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Product p1, Product p2)
        {
            return (p1.Equals(p2));
        }

        /// <summary>
        /// Redefinition of the different operator.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Product p1, Product p2)
        {
            return !(p1.Equals(p2));
        }

        /// <summary>
        /// Override of the ToString() Method to convert the data of a product into a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Product ID: {_reference}");
            sb.AppendLine($"Price: {_price}€");
            sb.AppendLine(_makeID.ToString());
            sb.AppendLine(_warranty.ToString());

            return sb.ToString();
        }

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
