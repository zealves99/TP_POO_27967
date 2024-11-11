/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/10/2024 7:42:03 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:
    /// Created by: Jose Alves a27967
    /// Created on: 11/10/2024 7:42:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Sales
    {
        #region Attributes
        const int MAX_SALES = 10;

        Sale[] _salesStored;
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
        /// The constructor to use when the sales' array is given.
        /// </summary>
        /// <param name="sales"></param>
        public Sales(Sale[] sales)
        {
            _salesStored = sales;
        }


        #endregion

        #region Properties

        public Sale GetSale(int idSale)
        {
            for(int i = 0; i < MAX_SALES; i++)
            {
                if (this._salesStored[i].Id==idSale) return this._salesStored[i];
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
