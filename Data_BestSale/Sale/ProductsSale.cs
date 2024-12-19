/*
*	<copyright file="Data_BestSale.Sale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/18/2024 4:29:26 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace Data_BestSale
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 12/18/2024 4:29:26 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ProductsSale
    {
        #region Attributes
        /// <summary>
        /// The string is the reference of the product.
        /// The int is the amount purchased.
        /// </summary>
        Dictionary<string, int> _prodsInSale; 
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ProductsSale()
        {
        }

        #endregion

        #region Properties
        /// <summary>
        /// The property to get and set the list of products in a sale.
        /// </summary>
        public Dictionary<string, int> ProdsInSale
        {
            get {return _prodsInSale;}
            set { _prodsInSale = value;}
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// This method adds a reference and amount of a product to the list of products.
        /// </summary>
        /// <param name="reff">The reference of the product to add</param>
        /// <returns>True - Product added successfully.</returns>
        /// <returns>ArgumentNullException - The reference is not valid</returns>
        public bool AddProductSale(string reff)
        {

            try
            {
                if (_prodsInSale.ContainsKey(reff))
                {
                    _prodsInSale[reff] ++;
                    return true;
                }
                else
                {
                    _prodsInSale.Add(reff,1);
                    return true;
                }
            }
            catch (ArgumentNullException argNullExcep) 
            {
                throw argNullExcep;
            }
        }

        /// <summary>
        /// This method removes the reference of a product in the list of products.
        /// </summary>
        /// <param name="reff">The reference of the product to add</param>
        /// <returns>True - Product removed successfully.</returns>
        /// <returns>ArgumentNullException - The reference is not valid</returns>
        public bool RemoveProductSale(string reff)
        {
            try
            {
                _prodsInSale.Remove(reff);
                return true;
            }
            catch(ArgumentNullException argNullExcep)
            {
                throw argNullExcep;
            }
        }

        /// <summary>
        /// This method verifies if a product with a given reference is in a list of products.
        /// </summary>
        /// <param name="reff"></param>
        /// <returns>True - The product is on the list.</returns>
        /// <returns>False - The product is not on the list.</returns>
        public bool ExistProductSale(string reff)
        {
            return _prodsInSale.ContainsKey(reff);
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ProductsSale()
        {
        }
        #endregion

        #endregion
    }
}
