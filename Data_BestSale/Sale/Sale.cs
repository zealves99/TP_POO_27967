/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:21:53 AM</date>
*	<description>Definition of Sale and methods to deal with Sale operations.</description>
**/
using System;
using System.CodeDom;
using System.Linq;
using System.Text;

namespace Data_BestSale
{
    [Serializable]
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
        ProductsSale _products;
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
            _products= new ProductsSale();
            _client= new Client();
            _campaigns= new Campaign();
        }

        /// <summary>
        /// Constructor used when a client, a product array and a campaign to be used are given.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="products"></param>
        /// <param name="camp"></param>
        public Sale(Client client, ProductsSale products, Campaign camp)
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
        public ProductsSale Products
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
        /// <returns>The total price to pay.</returns>
        public decimal TotalPrice()
        {
            decimal total = 0;
            Products aux = Store.GetStoreProdList();

            total=aux.TotalPrice();

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
        public bool InsertProductOnSale(string reff, int amount)
        {
            return _products.AddProductSale(reff, amount);
        }

        /// <summary>
        /// Method used to remove a product from a sale.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool RemoveProductFromSale(string reff)
        {
            return _products.RemoveProductSale(reff);
        }

        /// <summary>
        /// Method used to verify if a product is on a sale.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool ExistProductOnSale(string reff)
        {
            return _products.ExistProductSale(reff);
        }

        /// <summary>
        /// Method to calculate when a warranty is due to expire.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="reff"></param>
        /// <returns></returns>
        public DateTime WarrantyExpirationDate(string reff)
        {
            Products prod = Store.GetStoreProdList();
            return (prod.WarratyExpirationDateForProduct(this.SaleDate, reff));
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
