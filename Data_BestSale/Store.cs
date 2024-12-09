/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 5:01:23 PM</date>
*	<description></description>
**/
using System;


namespace Data_BestSale
{
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
        static Warranties _warrantList;
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
            _warrantList = new Warranties();
        }

        /// <summary>
        /// The constructor to use when all the lists are given.
        /// </summary>
        /// <param name="cl"></param>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <param name="w"></param>
        public Store(Clients cl, Products p, Sales s, Makes m, Categories c, Warranties w)
        {
            _clientList=cl;
            _prodList=p;
            _saleList=s;
            _makeList=m;
            _catList=c;
            _warrantList=w;
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

        /// <summary>
        /// The property to get and set de warranties' list.
        /// </summary>
        public Warranties WarrantList
        {
            get { return _warrantList; }
            set { _warrantList = value; }
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
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Store()
        {
        }
        #endregion

        #endregion
    }
}
