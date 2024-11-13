﻿/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/10/2024 7:42:03 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: Class with the agregation of sales of a store.
    /// Created by: Jose Alves a27967
    /// Created on: 11/10/2024 7:42:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Sales
    {
        #region Attributes
        static List<Sale> _salesStored;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Sales()
        {
        }

        /// <summary>
        /// The constructor to use when the sales' List is given.
        /// </summary>
        /// <param name="sales"></param>
        public Sales(List<Sale> sales)
        {
            _salesStored = sales;
        }


        #endregion

        #region Properties

        /// <summary>
        /// Method to find a sale in a list of sales, given its ID.
        /// </summary>
        /// <param name="idSale"></param>
        /// <returns></returns>
        public Sale GetSale(int idSale)
        {
            foreach(Sale s in _salesStored)
            {
                if (s.Id==idSale)return s;
            }
            return null;
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
        ~Sales()
        {
        }
        #endregion

        #endregion
    }
}