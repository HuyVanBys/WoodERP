﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICStockConfigRates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICStockConfigRatesInfo
    //Created Date:Saturday, January 5, 2019
    //-----------------------------------------------------------

    public class ICStockConfigRatesInfo : BusinessObject
    {
        public ICStockConfigRatesInfo()
        {
        }
        #region Variables
        protected int _iCStockConfigRateID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected String _iCStockConfigRateNo = String.Empty;
        protected String _iCStockConfigRateName = String.Empty;
        protected String _iCStockConfigRateDesc = String.Empty;
        protected String _iCStockConfigRateProductType = String.Empty;
        protected String _iCStockConfigRateProductDesc = String.Empty;
        protected bool _iCStockConfigRateIsIncrease = true;
        protected decimal _iCStockConfigRatePercent;
        #endregion

        #region Public properties
        public int ICStockConfigRateID
        {
            get { return _iCStockConfigRateID; }
            set
            {
                if (value != this._iCStockConfigRateID)
                {
                    _iCStockConfigRateID = value;
                    NotifyChanged("ICStockConfigRateID");
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
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                    NotifyChanged("FK_ICProductGroupID");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public String ICStockConfigRateNo
        {
            get { return _iCStockConfigRateNo; }
            set
            {
                if (value != this._iCStockConfigRateNo)
                {
                    _iCStockConfigRateNo = value;
                    NotifyChanged("ICStockConfigRateNo");
                }
            }
        }
        public String ICStockConfigRateName
        {
            get { return _iCStockConfigRateName; }
            set
            {
                if (value != this._iCStockConfigRateName)
                {
                    _iCStockConfigRateName = value;
                    NotifyChanged("ICStockConfigRateName");
                }
            }
        }
        public String ICStockConfigRateDesc
        {
            get { return _iCStockConfigRateDesc; }
            set
            {
                if (value != this._iCStockConfigRateDesc)
                {
                    _iCStockConfigRateDesc = value;
                    NotifyChanged("ICStockConfigRateDesc");
                }
            }
        }
        public String ICStockConfigRateProductType
        {
            get { return _iCStockConfigRateProductType; }
            set
            {
                if (value != this._iCStockConfigRateProductType)
                {
                    _iCStockConfigRateProductType = value;
                    NotifyChanged("ICStockConfigRateProductType");
                }
            }
        }
        public String ICStockConfigRateProductDesc
        {
            get { return _iCStockConfigRateProductDesc; }
            set
            {
                if (value != this._iCStockConfigRateProductDesc)
                {
                    _iCStockConfigRateProductDesc = value;
                    NotifyChanged("ICStockConfigRateProductDesc");
                }
            }
        }
        public bool ICStockConfigRateIsIncrease
        {
            get { return _iCStockConfigRateIsIncrease; }
            set
            {
                if (value != this._iCStockConfigRateIsIncrease)
                {
                    _iCStockConfigRateIsIncrease = value;
                    NotifyChanged("ICStockConfigRateIsIncrease");
                }
            }
        }
        public decimal ICStockConfigRatePercent
        {
            get { return _iCStockConfigRatePercent; }
            set
            {
                if (value != this._iCStockConfigRatePercent)
                {
                    _iCStockConfigRatePercent = value;
                    NotifyChanged("ICStockConfigRatePercent");
                }
            }
        }
        #endregion
    }
    #endregion
}