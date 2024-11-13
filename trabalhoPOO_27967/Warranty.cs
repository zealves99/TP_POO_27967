/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/13/2024 4:17:18 PM</date>
*	<description></description>
**/
using System;
using System.Diagnostics.Contracts;
using System.Text;
using System.Xml.Linq;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose: This class contains the definition and methods to manage warranties.
    /// Created by: Jose Alves a27967
    /// Created on: 11/13/2024 4:17:18 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Warranty
    {
        #region Attributes
        string _prodID;
        int _durationInYears;
        string _conditions;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Warranty()
        {
        }

        /// <summary>
        /// The constructor to use when the ID of the product, duration (in years) and the conditions are given.
        /// </summary>
        /// <param name="prodID"></param>
        /// <param name="durationInYears"></param>
        /// <param name="conditions"></param>
        public Warranty(string prodID, int durationInYears, string conditions)
        {
            _prodID = prodID;
            _durationInYears = durationInYears;
            _conditions = conditions;
        }



        #endregion

        #region Properties

        /// <summary>
        /// Property to get and set the ID of the product to which the warranty is about.
        /// </summary>
        public string ProdID
        {
            get {  return _prodID; }
            set { _prodID = value; }
        }

        /// <summary>
        /// The property to set and get the duration of a warranty (in years).
        /// </summary>
        public int DurationInYears
        {
            get { return _durationInYears; }
            set { _durationInYears = value; }
        }

        /// <summary>
        /// The property to get and set the terms of a warranty.
        /// </summary>
        public string Conditions
        {
            get { return _conditions; }
            set { _conditions = value; }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Method to show the information of a Warranty.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Warranty Data: ");
            sb.AppendLine($"Duration: {_durationInYears} years");
            sb.AppendLine($"Terms: {_conditions}");

            return sb.ToString();
        }
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method to calculate when a warranty is due to expire.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="reff"></param>
        /// <returns></returns>
        public DateTime ExpirationDate(Sale s, string reff)
        {
            Product p = s.Products.SearchProduct(reff);
            return (s.SaleDate.AddYears(_durationInYears));
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Warranty()
        {
        }
        #endregion

        #endregion
    }
}
