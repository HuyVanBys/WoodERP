﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRConfigRewardBestSellers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRConfigRewardBestSellersInfo
    //Created Date:Wednesday, July 25, 2018
    //-----------------------------------------------------------

    public class HRConfigRewardBestSellersInfo : BusinessObject
    {
        public HRConfigRewardBestSellersInfo()
        {
        }
        #region Variables
        protected int _hRConfigRewardBestSellerID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _hRBestSellerType = String.Empty;
        protected decimal _hRConfigRewardBestSellerAmount;
        protected decimal _hRConfigRewardBestSellerSalesFrom;
        protected decimal _hRConfigRewardBestSellerSalesTo;
        protected String _hRConfigRewardBestSellerDependenceType = String.Empty;
        protected decimal _hRConfigRewardBestSellerDependenceSalesFrom;
        protected decimal _hRConfigRewardBestSellerDependenceSalesTo;
        protected String _hRConfigRewardBestSellerType = String.Empty;
        #endregion

        #region Public properties
        public int HRConfigRewardBestSellerID
        {
            get { return _hRConfigRewardBestSellerID; }
            set
            {
                if (value != this._hRConfigRewardBestSellerID)
                {
                    _hRConfigRewardBestSellerID = value;
                    NotifyChanged("HRConfigRewardBestSellerID");
                }
            }
        }
        public DateTime AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                    NotifyChanged("AACreatedDate");
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                    NotifyChanged("AACreatedUser");
                }
            }
        }
        public DateTime AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                    NotifyChanged("AAUpdatedDate");
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
                    NotifyChanged("AAUpdatedUser");
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                    NotifyChanged("AAStatus");
                }
            }
        }
        public String HRBestSellerType
        {
            get { return _hRBestSellerType; }
            set
            {
                if (value != this._hRBestSellerType)
                {
                    _hRBestSellerType = value;
                    NotifyChanged("HRBestSellerType");
                }
            }
        }
        public decimal HRConfigRewardBestSellerAmount
        {
            get { return _hRConfigRewardBestSellerAmount; }
            set
            {
                if (value != this._hRConfigRewardBestSellerAmount)
                {
                    _hRConfigRewardBestSellerAmount = value;
                    NotifyChanged("HRConfigRewardBestSellerAmount");
                }
            }
        }
        public decimal HRConfigRewardBestSellerSalesFrom
        {
            get { return _hRConfigRewardBestSellerSalesFrom; }
            set
            {
                if (value != this._hRConfigRewardBestSellerSalesFrom)
                {
                    _hRConfigRewardBestSellerSalesFrom = value;
                    NotifyChanged("HRConfigRewardBestSellerSalesFrom");
                }
            }
        }
        public decimal HRConfigRewardBestSellerSalesTo
        {
            get { return _hRConfigRewardBestSellerSalesTo; }
            set
            {
                if (value != this._hRConfigRewardBestSellerSalesTo)
                {
                    _hRConfigRewardBestSellerSalesTo = value;
                    NotifyChanged("HRConfigRewardBestSellerSalesTo");
                }
            }
        }
        public String HRConfigRewardBestSellerDependenceType
        {
            get { return _hRConfigRewardBestSellerDependenceType; }
            set
            {
                if (value != this._hRConfigRewardBestSellerDependenceType)
                {
                    _hRConfigRewardBestSellerDependenceType = value;
                    NotifyChanged("HRConfigRewardBestSellerDependenceType");
                }
            }
        }
        public decimal HRConfigRewardBestSellerDependenceSalesFrom
        {
            get { return _hRConfigRewardBestSellerDependenceSalesFrom; }
            set
            {
                if (value != this._hRConfigRewardBestSellerDependenceSalesFrom)
                {
                    _hRConfigRewardBestSellerDependenceSalesFrom = value;
                    NotifyChanged("HRConfigRewardBestSellerDependenceSalesFrom");
                }
            }
        }
        public decimal HRConfigRewardBestSellerDependenceSalesTo
        {
            get { return _hRConfigRewardBestSellerDependenceSalesTo; }
            set
            {
                if (value != this._hRConfigRewardBestSellerDependenceSalesTo)
                {
                    _hRConfigRewardBestSellerDependenceSalesTo = value;
                    NotifyChanged("HRConfigRewardBestSellerDependenceSalesTo");
                }
            }
        }
        public String HRConfigRewardBestSellerType
        {
            get { return _hRConfigRewardBestSellerType; }
            set
            {
                if (value != this._hRConfigRewardBestSellerType)
                {
                    _hRConfigRewardBestSellerType = value;
                    NotifyChanged("HRConfigRewardBestSellerType");
                }
            }
        }
        #endregion
    }
    #endregion
}