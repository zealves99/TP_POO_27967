/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 5:01:23 PM</date>
*	<description>This class has the definition and properties to manage a store.</description>
**/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Business_Object;

namespace Data_BestSale
{
    [Serializable]
    /// <summary>
    /// Purpose: This class has the definition and properties to manage a store.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 5:01:23 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Store
    {
        #region Attributes
        static Clients _clientList;
        static Products _prodList;
        static Sales _saleList;
        static Makes _makeList;
        static Categories _catList;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Store()
        {
            _clientList = new Clients();
            _prodList = new Products();
            _saleList = new Sales();
            _makeList = new Makes();
            _catList = new Categories();
        }

        /// <summary>
        /// The constructor to use when all the lists are given.
        /// </summary>
        /// <param name="cl"></param>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <param name="c"></param>
        public Store(Clients cl, Products p, Sales s, Makes m, Categories c)
        {
            _clientList = cl;
            _prodList = p;
            _saleList = s;
            _makeList = m;
            _catList = c;
        }

        #endregion

        #region Properties
        /// <summary>
        /// The property used to get and set the clients' list.
        /// </summary>
        public Clients ClientLIst
        {
            get { return _clientList; }
            set { _clientList = value; }
        }

        /// <summary>
        /// The property to get and set de products' list.
        /// </summary>
        public Products ProdList
        {
            get { return _prodList; }
            set { _prodList = value; }
        }

        /// <summary>
        /// The property to get and set de sales' list.
        /// </summary>
        public Sales SaleList
        {
            get { return _saleList; }
            set { _saleList = value; }
        }

        /// <summary>
        /// The property to get and set de makes' list.
        /// </summary>
        public Makes MakeList
        {
            get { return _makeList; }
            set { _makeList = value; }
        }

        /// <summary>
        /// The property to get and set de categories' list.
        /// </summary>
        public Categories CatList
        {
            get { return _catList; }
            set { _catList = value; }
        }


        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method that gets a make's name from the list of makes in a store.
        /// </summary>
        /// <param name="makeID"></param>
        /// <returns>The name of the make, if found. Otherwise, returns 'Not Found'</returns>
        public static string GetMakeNameFromID(int makeID)
        {
            foreach(Make m in _makeList.MakeList)
            {
                if (m.ID == makeID) return m.Name;
            }

            return ("Not Found");
        }

        /// <summary>
        /// Inserts a client in the store's list of clients, if it's not already there.
        /// </summary>
        /// <param name="client"></param>
        /// <returns>True - Client has been successfully added to the list.</returns>
        /// <returns>False - Client already exists or an error occurred.<returns>
        public static bool InsertClientInStore(Client client)
        {
            return _clientList.Add(client);
        }

        #region Files
        /// <summary>
        /// Save a Store to a binary file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveStoreBin(string fileName)
        {
            try
            {
                FileStream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch (IOException ioExcep)
            {

                throw ioExcep;
            }
            catch (Exception excep)
            {
                throw excep;
            }
        }

        /// <summary>
        /// Method used to clear the data of a store from memory.
        /// </summary>
        public static bool ClearStore()
        {
            try
            {
                _clientList.ClearClients();
                _catList.ClearCategories();
                _makeList.ClearMakes();
                _prodList.ClearProducts();
                _saleList.ClearSales();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Load a Stor from a binary file.
        /// </summary>
        /// <param name="fileName">Name of file where the data is stored.</param>
        /// <returns>True - Store loaded successfully.</returns>
        /// <returns>False - The file does not exist.<returns>
        /// <returns>IO exception - There was an error with the I/O<returns>
        /// <returns>Exception - An error occurred.<returns>
        public static bool LoadStoreBin(string fileName)
        {
            ///Verify if a file with that name exists and has content in it.
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Store store = new Store();
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    store = (Store)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException ioExcep)
                {

                    throw ioExcep;
                }
                catch (Exception excep)
                {
                    throw excep;
                }
            }
            return false;
        }
        #endregion

        #region Products 
        /// <summary>
        /// Method used to add a product to the list of products of a store.
        /// </summary>
        /// <param name="prod">The product to add.</param>
        /// <returns>True - Product added to the list.</returns>
        /// <returns>False - The product already exists on the list.<returns>
        public static bool InsertProductInStore(Product prod)
        {
            if (_prodList.Exist(prod)) return false;
            else
            {
                _prodList.Add(prod);
                return true;
            }
        }

        /// <summary>
        /// Method that returns a product price from the list of products in a store, given its reference.
        /// </summary>
        /// <param name="reference">The reference wanted.</param>
        /// <returns>The product that matches that reference.</returns>
        public static decimal GetProductPriceInStoreFromReference(string reference)
        {
            Product prod = _prodList.SearchProduct(reference);
            return prod.Price;
        }

        /// <summary>
        /// Method used to get the store's product list
        /// </summary>
        /// <returns>The product list.</returns>
        public static Products GetStoreProdList()
        {
            return _prodList;
        }

        #endregion

        #region Makes
        /// <summary>
        /// Method to get the ID of a make in a store's list, given its name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The ID of the make</returns>
        /// <returns>-50 if the make does not exist on the list.<returns>
        public static int GetMakeIdFromNameInStore(string name)
        {
            if (_makeList.Exist(name))
            {
                Make aux = _makeList.GetMake(name);
                return (aux.GetMakeID());
            }
            else return -50;
        }

        /// <summary>
        /// Method to insert a make on a store's list of makes.
        /// </summary>
        /// <param name="make">The make to insert on the list</param>
        /// <returns>True or false, wheter it was added or not.</returns>
        public static bool InsertMakeInStore(Make make)
        {
            return _makeList.Add(make);     
        }
        #endregion

        #region Category

        /// <summary>
        /// This method finds the ID of a Category, given its name.
        /// </summary>
        /// <param name="name">The name of the Make</param>
        /// <returns>The ID of the Category</returns>
        /// <returns>-100 - There's no category with that name on the list.<returns>
        public static int GetCategoryIdFromNameInStore(string name)
        {
            if(_catList.Exist(name))
            {
                Category aux= _catList.GetCategory(name);
                return aux.Id;
            }
            return -100;
        }

        /// <summary>
        ///This method adds a Category to a store's list of categories. 
        /// </summary>
        /// <param name="cat"></param>
        /// <returns>True or false, wheter it succeeded or not.</returns>
        public static bool InsertCategoryInStore(Category cat)
        {
            return _catList.Add(cat);
        }
        #endregion

        #endregion

        #region Destructor
        ///// <summary>
        ///// The destructor.
        ///// </summary>
        //~Store()
        //{
        //}
        #endregion

        #endregion
    }
}
