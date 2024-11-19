/*
*	<copyright file="trabalhoPOO_27967.Category.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 4:20:11 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using trabalhoPOO_27967.Interface;

namespace trabalhoPOO_27967
{
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

            //ACRESCENTAR NAS OUTRAS CLASSES DE AGREGACAO!!!!
            if(obj is Warranty){
                var aux = obj as Warranty;
            }
            if (Exist(aux.ProdID))
            {
                if (obj is Warranty)
                {
                    _warrants.Remove((Warranty)obj);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to confirm if a warranty exists on a list of warranties, given the product ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
