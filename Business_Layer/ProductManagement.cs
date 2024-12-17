/*
*	<copyright file="Business_Layer.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/14/2024 4:28:51 PM</date>
*	<description></description>
**/
using Data_BestSale;
using System;

namespace Business_Layer
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 12/14/2024 4:28:51 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class ProductManagement
    {


        #region Methods

        #region Overrides
        #endregion

        #region OtherMethods
        #region Products
        /// <summary>
        /// Method used to create and add a product to a store.
        /// </summary>
        /// <param name="reff">The reference of the product</param>
        /// <param name="price">The price of the product</param>
        /// <param name="makeID">The ID of the make of the product</param>
        /// <param name="categoryID">The ID of the category of the product</param>
        /// <param name="warrantyDuration">The warranty duration in years</param>
        /// <param name="warrantyConditions">The terms of the warranty</param>
        /// <returns>True - Product successfully created and added to the store's list.</returns>
        /// <returns>Throws an exception - An error occurred in the process.<returns>
        public static bool CreateNewProductInStore(string reff, decimal price, int makeID, int categoryID, int warrantyDuration, string warrantyConditions)
        {
            try
            {
                Product prod = Product.CreateProductWithWarranty(reff, price, makeID, categoryID, warrantyDuration, warrantyConditions);
                Store.InsertProductInStore(prod);
                return true;
            }
            catch(Exception excep)
            {
                throw excep;
            }
        }

        /// <summary>
        /// Mtehod that returns the price of a certain product, given its reference.
        /// </summary>
        /// <param name="reference">The reference of the product</param>
        /// <returns>The price of the product</returns>
        public static decimal GetProductPriceFromReference(string reference)
        {
            return Store.GetProductPriceInStoreFromReference(reference);
        }
        #endregion

        #region Make
        public static bool CreateMake()

        #endregion

        #endregion



        #endregion
    }
}
