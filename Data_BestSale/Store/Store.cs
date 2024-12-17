/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 5:01:23 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data_BestSale
{
    /// <summary>
    /// Purpose: This class has the definition and properties to manage a store.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 5:01:23 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class Store
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

        ///// <summary>
        ///// The default Constructor.
        ///// </summary>
        //public Store()
        //{
        //    _clientList = new Clients();
        //    _prodList = new Products();
        //    _saleList = new Sales();
        //    _makeList = new Makes();
        //    _catList = new Categories();
        //}

        ///// <summary>
        ///// The constructor to use when all the lists are given.
        ///// </summary>
        ///// <param name="cl"></param>
        ///// <param name="p"></param>
        ///// <param name="s"></param>
        ///// <param name="m"></param>
        ///// <param name="c"></param>
        //public Store(Clients cl, Products p, Sales s, Makes m, Categories c)
        //{
        //    _clientList=cl;
        //    _prodList=p;
        //    _saleList=s;
        //    _makeList=m;
        //    _catList=c;
        //}

        #endregion

        #region Properties
        ///// <summary>
        ///// The property used to get and set the clients' list.
        ///// </summary>
        //public Clients ClientLIst
        //{
        //    get { return _clientList; }
        //    set { _clientList = value; }
        //}

        ///// <summary>
        ///// The property to get and set de products' list.
        ///// </summary>
        //public Products ProdList
        //{
        //    get { return _prodList; }
        //    set { _prodList = value; }
        //}

        ///// <summary>
        ///// The property to get and set de sales' list.
        ///// </summary>
        //public Sales SaleList
        //{
        //    get { return _saleList; }
        //    set { _saleList = value; }
        //}

        ///// <summary>
        ///// The property to get and set de makes' list.
        ///// </summary>
        //public Makes MakeList
        //{
        //    get { return _makeList; }
        //    set { _makeList = value; }
        //}

        ///// <summary>
        ///// The property to get and set de categories' list.
        ///// </summary>
        //public Categories CatList
        //{
        //    get { return _catList; }
        //    set { _catList = value; }
        //}


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
        /// Save a Store to a file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveStoreBin(string fileName)
        {
            try
            {
                FileStream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, _clientList);
                bin.Serialize(stream, _prodList);
                bin.Serialize(stream, _saleList);
                bin.Serialize(stream, _makeList);
                bin.Serialize(stream, _catList);
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
        public static void ClearStore()
        {
            _clientList.ClearClients();
            _catList.ClearCategories();
            _makeList.ClearMakes();
            _prodList.ClearProducts();
            _saleList.ClearSales();
        }

        /// <summary>
        /// Load a Stor from a binary file.
        /// </summary>
        /// <param name="fileName">Name of file where the data is stored.</param>
        /// <returns></returns>
        public static bool LoadStoreBin(string fileName)
        {
            ///Verify if a file with that name exists and has content in it.
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    _clientList=(Clients)bin.Deserialize(stream);
                    _prodList=(Products)bin.Deserialize(stream);
                    _saleList=(Sales)bin.Deserialize(stream);
                    _makeList = (Makes)bin.Deserialize(stream);
                    _catList=(Categories)bin.Deserialize(stream);
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
