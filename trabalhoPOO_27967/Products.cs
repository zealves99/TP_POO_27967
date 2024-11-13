/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/9/2024 6:34:19 PM</date>
*	<description></description>
**/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Class to manage a group of more than one product.
    /// Created by: Jose Alves a27967
    /// Created on: 11/9/2024 6:34:19 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Products
    {
        #region Attributes
        List<Product> _prods; //como faço uma propriedade para isto? Não consigo dar return do array, certo?
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Products()
        {
            _prods = new List<Product>();
        }

        /// <summary>
        /// The constructor to use when list of Product is given.
        /// </summary>
        /// <param name="products"></param>
        public Products(List<Product> products)
        {
            _prods = products;
        }



        #endregion

        #region Properties
        /// <summary>
        /// Property used to get and set the list of products.
        /// </summary>
        public List<Product> Prods
        {
            get { return _prods; }
            set { _prods = value; }
        }
        #endregion



        #region Overrides

        /// <summary>
        /// Override of the ToString() Method to convert the data of a list fo products to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in _prods)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// This method returns the price of a product, given a certain array position.
        /// </summary>
        /// <param name="p">Position in array.</param>
        /// <returns></returns>
        public decimal ValueInPosition(int p)
        {
            return this.Prods[p].Price;
        }

        /// <summary>
        /// This method inserts a product in a list of products.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Returns true or False, depending on whether or not it succeeded in inserting the product into the list. </returns>
        public bool InsertProduct(Product p)
        {
            if (p == null) return false;
            _prods.Add(p);
            return true;
        }

        /// <summary>
        /// This method searches for a product in an array, given its refference.
        /// </summary>
        /// <param name="reff"></param>
        /// <returns>Returns the product if found</returns>
        public Product SearchProduct(string reff)
        {
            foreach (Product p in _prods)
            {
                if(p.Reference==reff) return p;
            }
            return null;
        }

        /// <summary>
        /// Method used to calculate the total price of products in a list of products.
        /// </summary>
        /// <returns></returns>
        public decimal TotalPrice()
        {
            return _prods.Sum(p => p.Price);

        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Products()
        {
        }
        #endregion

        #endregion
    }
}
