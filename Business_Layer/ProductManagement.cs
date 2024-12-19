/*
*	<copyright file="Business_Layer.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/14/2024 4:28:51 PM</date>
*	<description>This file has all the necessary calls to the back end to manage products, categories, makes and warranties.</description>
**/
using Data_BestSale;
using System;

namespace Business_Layer
{
    /// <summary>
    /// Purpose: This namespace has all the necessary calls to the back end to manage products, categories, makes and warranties.
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
        /// <returns>Throws an exception - An error occurred in the process.</returns>
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
        /// <summary>
        /// This method creates a new make and inserts it on the store's list of makes.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True or false, wether it added the make to the list or not.</returns>
        public static bool CreateMakeInStore(string name)
        {
            Make.CreateMake(name, out Make newMake);
            return Store.InsertMakeInStore(newMake);
        }

        /// <summary>
        /// This method returns the ID of a make in the store's list, given its name.
        /// </summary>
        /// <param name="name">The name of the make</param>
        /// <returns>The ID of the make.</returns>
        public static int GetMakeIdFromName(string name)
        {
            return Store.GetMakeIdFromNameInStore(name);
        }

        #endregion

        #region Category
        /// <summary>
        /// This method creates and inserts a Category in a store's list.
        /// </summary>
        /// <param name="name">The Category's name.</param>
        /// <returns>True - Category created and added successfully.</returns>
        /// <returns>False - The Category couldn't be added to the list.</returns>
        public static bool CreateCategoryInStore(string name)
        {
            Category.CreateCategory(name, out Category newCategory);
            return Store.InsertCategoryInStore(newCategory);
        }

        /// <summary>
        /// This method returns the ID of a Category in the store's list, given its name.
        /// </summary>
        /// <param name="name">The name of the category</param>
        /// <returns>The ID of the category</returns>
        public static int GetCategoryIdFromName(string name)
        {
            return Store.GetCategoryIdFromNameInStore(name);
        }
        #endregion

        #region Sale
        /// <summary>
        /// Method used to create a new sale in a store, given the client ID and the product's sold references.
        /// </summary>
        /// <param name="clientID">The ID of the client who made the purchase.</param>
        /// <param name="products">The references of the products sold.</param>
        /// <returns>True - Sale created and added successfully.</returns>
        /// <returns>False - Sale not added to the store's list.</returns>
        public static bool CreateSaleInStore(int clientID, params string[] products)
        {
            bool aux;
            Sale newSale = Sale.CreateSale(clientID);
            aux = newSale.InsertProductOnSale(products);
            aux = Store.InsertSaleInStore(newSale);

            return aux;
        }
        #endregion


        #endregion



        #endregion
    }
}
