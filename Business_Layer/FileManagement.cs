/*
*	<copyright file="Business_Layer.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/11/2024 12:04:37 PM</date>
*	<description></description>
**/
using Data_BestSale;
using System;
using System.IO;

namespace Business_Layer
{
    /// <summary>
    /// Purpose:
    /// Created by: zecun
    /// Created on: 12/11/2024 12:04:37 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public static class FileManagement
    {

        #region Methods

        /// <summary>
        /// Method used to save a Store to a binary file.
        /// </summary>
        /// <param name="fileName">Name of file where to save.</param>
        /// <returns>True - Saved Successfully</returns>
        /// <returns>IOException - There was a problem with the input you were trying to save.</returns>
        /// <returns>Exception - There was a problem saving the store. Data not stored.</returns>
        public static bool SaveStore(string fileName) {
            try
            {
                Store.SaveStoreBin(fileName);
                return true;
            
            }
            catch (IOException e)
            {
                throw e;

            }
            catch (Exception excep)
            {
                throw excep;
            }
            
        }

        public static bool LoadStore(string fileName)
        {




        }

        public static void ClearStoreMemory()
        {
            Store.ClearStore();
        }


        #endregion
    }
}
