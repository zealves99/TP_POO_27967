/*
*	<copyright file="Business_Layer.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>zecun</author>
*   <date>12/11/2024 12:04:37 PM</date>
*	<description>This File contains the calls to the methods to save data to a file.</description>
**/
using Data_BestSale;
using System;
using System.Dynamic;
using System.IO;

namespace Business_Layer
{
    /// <summary>
    /// Purpose:This File contains the calls to the methods to save data to a file.
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
            Store store=new Store();
            try
            {
                bool a= store.SaveStoreBin(fileName);
                return a;
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

        /// <summary>
        /// Method used to load a Store from a binary file.
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        /// <returns>True - Store loaded successfully</returns>
        /// <returns>False - There's no file with that name./returns>
        /// <returns>IO exception - There was an error with the I/O</returns>
        /// <returns>Exception - An error occurred.</returns>
        public static bool LoadStore(string fileName)
        {
            try
            {
                bool aux = Store.LoadStoreBin(fileName);
                return aux;

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

        public static void ClearStoreMemory()
        {
            Store.ClearStore();
        }


        #endregion
    }
}
