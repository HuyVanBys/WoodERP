﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductBranchPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductBranchPricesInfo
    //Created Date:Tuesday, September 27, 2011
    //-----------------------------------------------------------

    public class ICProductBranchPricesInfo : BusinessObject
    {
        public ICProductBranchPricesInfo()
        {
        }
        #region Variables
        protected int _iCProductBranchPriceID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_BRBranchID;
        protected int _fK_ICProductID;
        protected int _fK_GeCurrencyID;
        protected decimal _iCProductBranchPrice;
        protected String _iCProductBranchPriceType;
        #endregion

        #region Public properties
        public int ICProductBranchPriceID
        {
            get { return _iCProductBranchPriceID; }
            set
            {
                if (value != this._iCProductBranchPriceID)
                {
                    _iCProductBranchPriceID = value;
                    NotifyChanged("ICProductBranchPriceID");
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
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
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
        public int FK_GECurrencyID
        {
            get { return _fK_GeCurrencyID; }
            set
            {
                if (value != this._fK_GeCurrencyID)
                {
                    _fK_GeCurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public decimal ICProductBranchPrice
        {
            get { return _iCProductBranchPrice; }
            set
            {
                if (value != this._iCProductBranchPrice)
                {
                    _iCProductBranchPrice = value;
                    NotifyChanged("ICProductBranchPrice");
                }
            }
        }
        public String ICProductBranchPriceType
        {
            get { return _iCProductBranchPriceType; }
            set
            {
                if (value != this._iCProductBranchPriceType)
                {
                    _iCProductBranchPriceType = value;
                    NotifyChanged("ICProductBranchPriceType");
                }
            }
        }
        #endregion
    }
    #endregion
}