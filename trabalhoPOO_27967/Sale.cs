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
using System.Linq;
using System.Text;

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
        decimal _totPrice;
        DateTime _saleDate;
        static int _numSales;
        Campaign _campaigns;
        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Sale()
        {
            _products= new Products();
            _client= new Client();
            _campaigns= new Campaign();
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
            _totPrice = TotalPrice();
            _saleDate = DateTime.Now;
        }



        #endregion

        #region Properties
        /// <summary>
        /// Property used to get and set the ID of a Sale.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Property used to get and set the information of the Client who made the purchase.
        /// </summary>
        public Client Client
        {
            get { return (_client); }
            set { _client = value; }
        }

        /// <summary>
        /// Property used to get and set the list of products in a Sale.
        /// </summary>
        public Products Products
        {
            get { return _products; }
            set { _products = value; }
        }

        /// <summary>
        /// Property used to get and set the total price of a Sale.
        /// </summary>
        public decimal TotPrice
        {
            get { return _totPrice; }
            set { _totPrice = value; }
        }

        /// <summary>
        /// Property used to get and set the Date of a Sale.
        /// </summary>
        public DateTime SaleDate
        {
            get { return _saleDate; }
            set { _saleDate = value; }
        }

        /// <summary>
        /// Property used to get and set the Campaigns applicable to a Sale.
        /// </summary>
        public Campaign Campaigns
        {
            get { return _campaigns; }
            set { _campaigns = value; }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Redefinition of the Equals method to compare two sales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Sale sale = obj as Sale;
            return (sale.Id==this.Id);
        }

        /// <summary>
        /// Redefiniiton of the equal operator.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Sale s1, Sale s2)
        {
            return(s1.Equals(s2));
        }

        /// <summary>
        /// Redefinition of the different operator.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator !=(Sale s1, Sale s2)
        {
            return !(s1.Equals(s2));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_products.ToString());
            sb.AppendLine("Total " + this.TotalPrice().ToString() + "\u20AC"); ///\u20AC é o unicode para o símbolo de euro.
            return sb.ToString();

        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Method to calculate the total price of a sale, given the products list and a campaign code.
        /// </summary>
        /// <param name="products"></param>
        /// <param name="camp"></param>
        /// <returns></returns>
        public decimal TotalPrice()
        {
            decimal total = 0;

            total=_products.TotalPrice();

            if (Campaign.VerifyApplicability(this.Campaigns))
            {
                total *= (1-this.Campaigns.Discount);
            }

            return total;
        }

        /// <summary>
        /// Method used to insert a product on a sale's list.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool InsertProductOnSale(Product p)
        {
            return _products.InsertProduct(p);
        }

        /// <summary>
        /// Method to calculate when a warranty is due to expire.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="reff"></param>
        /// <returns></returns>
        public DateTime WarrantyExpirationDate(string reff)
        {
            return (_products.WarratyExpirationDateForProduct(this.SaleDate, reff));
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
