/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:21:53 AM</date>
*	<description></description>
**/
using System;
using System.CodeDom;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Definition of Sale and methods to deal with Sale operations.
    /// Created by: Jose Alves a27967
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
        Products _products;
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
        public Sale(Client client, Products products, Campaign camp)
        {
            _id = ++_numSales;
            _client = client;
            _products = products;
            _totalPrice = TotalPrice(products, camp);
            _saleDate = DateTime.Now;
        }



        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Client Client
        {
            get { return (_client); }
            set { _client = value; }
        }

        public Products Products
        {
            get { return _products; }
            set { _products = value; }
        }
            

        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public DateTime SaleDate
        {
            get { return _saleDate; }
            set { _saleDate = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public decimal TotalPrice(Products products, Campaign camp)
        {
            decimal total = 0;
            for(int i=0; i < MAX_PRODUCTS; i++)
            {
                total += products.ValueInPosition(i);
            }

            if (Campaign.VerifyApplicability(camp))
            {
                total *= (1-camp.Discount);
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
