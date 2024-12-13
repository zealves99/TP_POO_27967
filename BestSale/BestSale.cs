﻿/*
*	<copyright file="BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>12/17/2024 6:23:56 PM</date>
*	<description>This file contains the frond end of the app..</description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //Used to verify if a string meets certain criteria.
using Business_Layer;
using System.IO;

namespace BestSale
{
    class BestSale
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool a;

            try
            {
                a = ClientManagement.CreateClientInStore("Jose Alves", "962310421");
            }
            catch (IOException ioExcep)
            {
                Console.WriteLine(ioExcep.Message);
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }

            try
            {
                a = ProductManagement.CreateMakeInStore("Benfica");
                int id = ProductManagement.GetMakeIdFromName("Benfica");
                a = ProductManagement.CreateCategoryInStore("Melhor do Mundo");
                int cat = ProductManagement.GetCategoryIdFromName("Melhor do Mundo");
                a = ProductManagement.CreateNewProductInStore("1A34", 23.9m, id, cat , 3, "Nao gostar de batatas.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}
