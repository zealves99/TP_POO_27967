/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/10/2024 7:42:03 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace Data_BestSale
{
    /// <summary>
    /// Purpose: Class with the agregation of sales of a store.
    /// Created by: Jose Alves a27967
    /// Created on: 11/10/2024 7:42:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Sales : IListManagement
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
            _salesStored = new List<Sale>();
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
        /// Property used to get and set a list of sales.
        /// </summary>
        public List<Sale> SalesStored
        {
            get { return _salesStored; }
            set { _salesStored = value; }
        }

        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method to find a sale in a list of sales, given its ID.
        /// </summary>
        /// <param name="idSale"></param>
        /// <returns></returns>
        public Sale GetSale(int idSale)
        {
            foreach (Sale s in _salesStored)
            {
                if (s.Id == idSale) return s;
            }
            return null;
        }

        /// <summary>
        /// Method used to add a sale to a sales' list.
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        public bool Add(object obj)
        {
            if (obj == null) return false;
            if (obj is Sale)
            {
                _salesStored.Add((Sale)obj);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to remove a sale from a list of sales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Remove(object obj)
        {
            if (obj == null) return false;
            Sale aux = (Sale)obj;
            if (Exist(aux.Id))
            {
                if (obj is Sale)
                {
                    _salesStored.Remove(aux);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to check if a sale exists in a list of sales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Exist(object obj)
        {
            if (obj == null) return false;
            if(obj is int)
            {
                foreach (Sale s in _salesStored)
                {
                    if (s.Id == (int)obj)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to Clear a list of Sales.
        /// </summary>
        public void ClearSales()
        {
            _salesStored.Clear();
        }
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
