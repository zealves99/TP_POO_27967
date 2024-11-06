/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>11/6/2024 11:21:53 AM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 11/6/2024 11:21:53 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    /// 

    public class Sale
    {
        #region Attributes
        int _id;
        Client _client;
        Product[] _products;
        decimal _totalPrice;
        DateTime _saleDate;
        static int _numSales;
        #endregion

        const int MAX_PRODUCTS = 10;

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Sale()
        {
        }

        /// <summary>
        /// Constructor used when a client, a product array and a campaign to be used are given.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="products"></param>
        /// <param name="camp"></param>
        public Sale(Client client, Product[] products, Campaign camp)
        {
            _id = ++_numSales;
            _client = client;
            _products = products;
            _totalPrice = TotalPrice(products, camp);
            _saleDate = DateTime.Now;
        }



        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public decimal TotalPrice(Product[] products, Campaign camp)
        {
            decimal total = 0;
            for(int i=0; i < MAX_PRODUCTS; i++)
            {
                total += products[i].Price;
            }

            if (Campaign.VerifyApplicability(camp))
            {
                total *= camp.Discount;
            }

            return total;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Sale()
        {
        }
        #endregion

        #endregion
    }
}
