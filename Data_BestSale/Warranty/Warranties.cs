﻿/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 4:20:11 PM</date>
*	<description>This file has the definition and methods to work with the plurality of Warranty.</description>
**/
using System;
using System.Collections.Generic;


namespace Data_BestSale
{
    [Serializable]
    /// <summary>
    /// Purpose:This file has the definition and methods to work with the plurality of Warranty.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 4:20:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Warranties: IListManagement
    {
        #region Attributes
        List<Warranty> _warrants;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Warranties()
        {
            _warrants = new List<Warranty>();
        }

        /// <summary>
        /// The constructor to use when a list of Warranties is given.
        /// </summary>
        /// <param name="warrants"></param>
        public Warranties(List<Warranty> warrants)
        {
            _warrants = warrants;
        }



        #endregion

        #region Properties
        /// <summary>
        /// Property used to get and set the list of warranties.
        /// </summary>
        public List<Warranty> Warrants
        {
            get { return _warrants; }
            set { _warrants = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        // <summary>
        /// Method used to add a warranty to a list of warranties.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Add(object obj)
        {
            if (obj == null) return false;
            if(obj is Warranty)
            {
                _warrants.Add((Warranty)obj);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to remove a warranty from a list of warranties.
        /// </summary>
        /// <param name="camp"></param>
        /// <returns></returns>
        public bool Remove(object obj)
        {
            if (obj == null) return false;
            Warranty aux;

            //ACRESCENTAR NAS OUTRAS CLASSES DE AGREGACAO!!!!
            if (obj is Warranty){
                aux = obj as Warranty;
                if (Exist(aux.ProdID))
                {
                    if (obj is Warranty)
                    {
                        _warrants.Remove((Warranty)obj);
                        return true;
                    }
                }
            }
            
            return false;
        }

        /// <summary>
        /// Method used to confirm if a warranty exists on a list of warranties, given the product ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True - If Warranty exists in the list of Warranties</returns>
        /// <returns>False - If Warranty does not exist in the list of Warranties</returns>
        public bool Exist(object obj)
        {
            if (obj == null) return false;
            if (obj is string)
            {
                foreach (Warranty w in _warrants)
                {
                    if (w.ProdID == (string)obj)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to Clear a list of Warranties.
        /// </summary>
        public void ClearWarranties()
        {
            _warrants.Clear();
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Warranties()
        {
        }
        #endregion

        #endregion
    }
}
