﻿/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/14/2024 3:57:04 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace trabalhoPOO_27967
{
    /// <summary>
    /// Purpose:This file has the definition and methods to work with the plurality of Campaign.
    /// Created by: Jose Alves a27967
    /// Created on: 11/14/2024 3:57:04 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Campaigns
    {
        #region Attributes
        List<Campaign> _camps;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Campaigns()
        {
            _camps = new List<Campaign>();
        }

        /// <summary>
        /// The constructor to use when a list of Campaigns is given.
        /// </summary>
        /// <param name="p"></param>
        public Campaigns(List<Campaign> p) { 
            _camps = p;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Property used to get and set a Campaign list.
        /// </summary>
        public List<Campaign> Camps
        {
            get{  return _camps; }
            set{ _camps = value; }
        }
        #endregion



        #region Overrides
        
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method used to add a campaign to a list of campaigns.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AddCampaign(Campaign c)
        {
            if(c==null)return false;
            _camps.Add(c);
            return true;
        }

        /// <summary>
        /// Method used to remove a campaign from a list of campaigns.
        /// </summary>
        /// <param name="camp"></param>
        /// <returns></returns>
        public bool RemoveCampaign(Campaign camp)
        {
            foreach (Campaign c in _camps)
            {
                if (c == camp)
                {
                    _camps.Remove(camp);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to confirm if a campaign exists on a list of campaigns.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistCampaign(int id)
        {
            foreach (Campaign c in _camps)
            {
                if (c.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Campaigns()
        {
        }
        #endregion

        #endregion
    }
}
