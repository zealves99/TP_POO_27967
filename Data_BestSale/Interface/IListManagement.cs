/*
*	<copyright file="Data_BestSale.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/15/2024 04:21:43 PM</date>
*	<description>Defines the interface to use in List Management</description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_BestSale
{
    public interface IListManagement
    {
        bool Add(object obj);

        bool Remove(object obj);

        bool Exist(object obj);
    }
}
