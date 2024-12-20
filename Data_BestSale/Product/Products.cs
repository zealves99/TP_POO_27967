/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/9/2024 6:34:19 PM</date>
*	<description>Class to manage a group of more than one product.</description>
**/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Data_BestSale
{
    [Serializable]
    /// <summary>
    /// Purpose: Class to manage a group of more than one product.
    /// Created by: Jose Alves a27967
    /// Created on: 11/9/2024 6:34:19 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Products : IListManagement
    {
        #region Attributes
        Dictionary<string, Product> _prods;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Products()
        {
            _prods = new Dictionary<string, Product>();
        }

        /// <summary>
        /// The constructor to use when list of Product is given.
        /// </summary>
        /// <param name="products"></param>
        public Products(Dictionary<string, Product> products)
        {
            _prods = products;
        }



        #endregion

        #region Properties
        /// <summary>
        /// Property used to get and set the list of products.
        /// </summary>
        public Dictionary<string, Product> Prods
        {
            get { return _prods; }
            set { _prods = value; }
        }
        #endregion



        #region Overrides

        /// <summary>
        /// Override of the ToString() Method to convert the data of a list fo products to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in _prods)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// This method returns the price of a product, given its reference.
        /// </summary>
        /// <param name="p">Position in array.</param>
        /// <returns>The price of the product</returns>
        public decimal PriceByReference(string reff)
        {
            _prods.TryGetValue(reff, out Product prod);
            return prod.Price;
        }

        /// <summary>
        /// This method inserts a product in a list of products.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Returns true or False, depending on whether or not it succeeded in inserting the product into the list. </returns>
        public bool Add(object obj)
        {
            if (obj == null) return false;
            ///The type of var is defined by the compiler in the compiling process.
            var aux=obj as Product;
            if (Exist(aux.Reference))
            {
                if (obj is Product)
                {
                    _prods.Add(aux.Reference, (Product)obj);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to verify if a product is on a products' list, given its Reference.
        /// </summary>
        /// <param name="reff"></param>
        /// <returns></returns>
        public bool Exist(object obj)
        {
            if (obj == null) return false;
            if (obj is string)
            {
                if (_prods.TryGetValue((string)obj, out Product p)) return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to remove a product from a Products' list.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Remove(object obj)
        {
            if (obj == null) return false;
            Product p = (Product)obj;
            if (Exist(p.Reference))
            {
                _prods.Remove(p.Reference);
                return true; ///Product removed successfully
            }
            return false; ///Product was not removed.
        }

        /// <summary>
        /// This method searches for a product in the list of products, given its refference.
        /// </summary>
        /// <param name="reff"></param>
        /// <returns>Returns the product if found</returns>
        public Product SearchProduct(string reff)
        {
            ///Verifies if the refference is registered in the dictionary.
            if(_prods.TryGetValue(reff, out Product p)) return p;
            return null;
        }

        /// <summary>
        /// Method used to calculate the total price of products in a list of products.
        /// </summary>
        /// <returns></returns>
        public decimal TotalPrice()
        {
            ///lambda funtion tells the Sum() function that, for each Product p in _prods, it should use the price value.
            return _prods.Values.Sum(p => p.Price);

        }

        /// <summary>
        /// Method used to calculate the warranty's expiration date of a product on a list of products.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="reff"></param>
        /// <returns></returns>
        public DateTime WarratyExpirationDateForProduct(DateTime date, string reff)
        {
            Product p = SearchProduct(reff);
            {
                return (date.AddYears(p.Warranty.DurationInYears));
            }
        }

        /// <summary>
        /// Method used to Clear a list of Products.
        /// </summary>
        public bool ClearProducts()
        {
            try{
                _prods.Clear();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Products()
        {
        }
        #endregion

        #endregion
    }
}
