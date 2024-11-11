/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/9/2024 6:34:19 PM</date>
*	<description></description>
**/
using System;

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
        const int MAX_PRODS = 10;
        #region Attributes
        Product[] _prods; //como faço uma propriedade para isto? Não consigo dar return do array, certo?
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Products()
        {
        }

        /// <summary>
        /// The constructor to use when an array of Product is given.
        /// </summary>
        /// <param name="products"></param>
        public Products(Product[] products)
        {
            _prods = products;
        }



        #endregion

        #region Properties
        public Product[] Prods
        {
            get { return _prods; }
            set { _prods = value; }
        }
        #endregion



        #region Overrides
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
        /// This method inserts a product in an array of products, in the first available position.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Returns true or False, depending on whether or not it succeeded in inserting the product into the array. </returns>
        public bool InsertProduct(Product p)
        {
            for (int i = 0; i < MAX_PRODS; i++)
            {
                if (this.Prods[i] == null)
                {
                    this.Prods[i] = p;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method searches for a product in an array, given its refference.
        /// </summary>
        /// <param name="reff"></param>
        /// <returns>Returns the product if found</returns>
        public Product SearchProduct(string reff)
        {
            for (int i = 0; i < MAX_PRODS; i++)
            {
                if(this.Prods[i].Reference == reff) return this.Prods[i];
            }
            return null;
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
