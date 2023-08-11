﻿using BOSLib;
using System;
namespace BOSERP
{
    #region GEHistoryDetailOfProductBranchPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEHistoryDetailOfProductBranchPricesInfo
    //Created Date:Friday, May 03, 2013
    //-----------------------------------------------------------

    public class GEHistoryDetailOfProductBranchPricesInfo : BusinessObject
    {
        public GEHistoryDetailOfProductBranchPricesInfo()
        {
        }
        #region Variables
        protected int _gEHistoryDetailOfProductBranchPriceID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_GEObjectHistoryID;
        protected int _fK_BRBranchID;
        protected int _fK_GECurrencyID;
        protected decimal _gEHistoryDetailOfProductBranchPriceOldValue;
        protected decimal _gEHistoryDetailOfProductBranchPriceNewValue;
        #endregion

        #region Public properties
        public int GEHistoryDetailOfProductBranchPriceID
        {
            get { return _gEHistoryDetailOfProductBranchPriceID; }
            set
            {
                if (value != this._gEHistoryDetailOfProductBranchPriceID)
                {
                    _gEHistoryDetailOfProductBranchPriceID = value;
                    NotifyChanged("GEHistoryDetailOfProductBranchPriceID");
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
        public int FK_GEObjectHistoryID
        {
            get { return _fK_GEObjectHistoryID; }
            set
            {
                if (value != this._fK_GEObjectHistoryID)
                {
                    _fK_GEObjectHistoryID = value;
                    NotifyChanged("FK_GEObjectHistoryID");
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
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public decimal GEHistoryDetailOfProductBranchPriceOldValue
        {
            get { return _gEHistoryDetailOfProductBranchPriceOldValue; }
            set
            {
                if (value != this._gEHistoryDetailOfProductBranchPriceOldValue)
                {
                    _gEHistoryDetailOfProductBranchPriceOldValue = value;
                    NotifyChanged("GEHistoryDetailOfProductBranchPriceOldValue");
                }
            }
        }
        public decimal GEHistoryDetailOfProductBranchPriceNewValue
        {
            get { return _gEHistoryDetailOfProductBranchPriceNewValue; }
            set
            {
                if (value != this._gEHistoryDetailOfProductBranchPriceNewValue)
                {
                    _gEHistoryDetailOfProductBranchPriceNewValue = value;
                    NotifyChanged("GEHistoryDetailOfProductBranchPriceNewValue");
                }
            }
        }
        #endregion

        #region Extra properties
        public string BRBranchName { get; set; }
        public string GECurrencyName { get; set; }
        public string ADUserName { get; set; }
        public DateTime GEObjectHistoryDate { get; set; }
        #endregion
    }
    #endregion
}