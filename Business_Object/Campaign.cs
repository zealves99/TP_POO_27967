/*
*	<copyright file="trabalhoPOO_27967.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Jose Alves a27967</author>
*   <date>11/6/2024 11:21:43 AM</date>
*	<description></description>
**/
using System;

namespace Business_Object
{
    /// <summary>
    /// Purpose: Definition of Campaign and methods to deal with Campaign operations.
    /// Created by: Jose Alves a27967
    /// Created on: 11/6/2024 11:21:43 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Campaign
    {
        #region Attributes
        int _id;
        string _name;
        decimal _discount;
        DateTime _startDate;
        DateTime _endDate;
        static int _campaignCount;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Campaign()
        {
            _id = ++_campaignCount;
            _name = string.Empty;
            _discount = 0m;
            _startDate = DateTime.MinValue;
            _endDate = DateTime.MaxValue;
        }

        /// <summary>
        /// Constructor used to create a campaign when a name, a decimal value of discount, start and ending dates are given. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="discount"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public Campaign(string name, decimal discount, DateTime startDate, DateTime endDate)
        {
            _id = ++_campaignCount;
            _name = name;
            _discount = discount;
            _startDate = startDate;
            _endDate = endDate;
        }





        #endregion

        #region Properties

        /// <summary>
        /// Property used to get and set the ID of a Campaign.
        /// </summary>
        public int Id{
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Property used to get and set the Name of a Campaign.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Property used to get and set the Decimal Discount of a Campaign.
        /// </summary>
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        /// Property used to get and set the Start Date of a Campaign.
        /// </summary>
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        /// Property used to get and set the End Date of a Campaign.
        /// </summary>
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        /// <summary>
        /// Property used to get and set the Campaign Counter.
        /// </summary>
        public int CampaignCount
        {
            get { return _campaignCount; }
            set { _campaignCount = value; }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Redefine the Equals operator to verify if a campaign matches the other.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            /// Veriffies if the object given is null.
            if (obj == null)
            {
                return false;
            }

            ///Casts the object to be Campaign.
            Campaign camp = obj as Campaign;
            return (this.Id == camp.Id && _name == camp.Name);
        }

        /// <summary>
        /// Redefinition of the == operator.
        /// </summary>
        /// <param name="cli1"></param>
        /// <param name="cli2"></param>
        /// <returns></returns>
        public static bool operator ==(Campaign camp1, Campaign camp2)
        {
            return (camp1.Equals(camp2));
        }

        /// <summary>
        /// Redefinition of the != operator.
        /// </summary>
        /// <param name="cli1"></param>
        /// <param name="cli2"></param>
        /// <returns></returns>
        public static bool operator !=(Campaign camp1, Campaign camp2)
        {
            return !(camp1.Equals(camp2));
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Method to verify if a certaign campaign is applicable, according to its start and end dates.
        /// </summary>
        /// <param name="camp"></param>
        /// <returns></returns>
        static public bool VerifyApplicability(Campaign camp)
        {
            /// Verifies if the actual date is in between the start and end dates of the campaign.
            if (camp.StartDate <= DateTime.Now && camp.EndDate >= DateTime.Now)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Campaign()
        {
        }
        #endregion

        #endregion
    }
}
