﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACAdjustIncreaseOrDecreaseAssets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAdjustIncreaseOrDecreaseAssetsInfo
    //Created Date:10 Tháng Chín 2018
    //-----------------------------------------------------------

    public class ACAdjustIncreaseOrDecreaseAssetsInfo : BusinessObject
    {
        public ACAdjustIncreaseOrDecreaseAssetsInfo()
        {
        }
        #region Variables
        protected int _aCAdjustIncreaseOrDecreaseAssetID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aCAdjustIncreaseOrDecreaseAssetNo = String.Empty;
        protected DateTime _aCAdjustIncreaseOrDecreaseAssetDate = DateTime.MaxValue;
        protected String _aCAdjustIncreaseOrDecreaseAssetType = String.Empty;
        protected int _fK_ACObjectID;
        protected String _aCObjectType = String.Empty;
        protected String _aCObjectContactAddressLine3 = String.Empty;
        protected String _aCObjectTaxNumber = String.Empty;
        protected int _fK_GECurrencyID;
        protected decimal _aCAdjustIncreaseOrDecreaseAssetExchangeRate;
        protected int _fK_BRBranchID;
        protected int _fK_BRInvoiceBranchID;
        protected int _fK_ACAccountPurchaseID;
        protected String _sTToolbarActionName = String.Empty;
        protected String _aCAdjustIncreaseOrDecreaseAssetPostedStatus = DefaultStatus;
        #endregion

        #region Public properties
        public int ACAdjustIncreaseOrDecreaseAssetID
        {
            get { return _aCAdjustIncreaseOrDecreaseAssetID; }
            set
            {
                if (value != this._aCAdjustIncreaseOrDecreaseAssetID)
                {
                    _aCAdjustIncreaseOrDecreaseAssetID = value;
                    NotifyChanged("ACAdjustIncreaseOrDecreaseAssetID");
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
        public String ACAdjustIncreaseOrDecreaseAssetNo
        {
            get { return _aCAdjustIncreaseOrDecreaseAssetNo; }
            set
            {
                if (value != this._aCAdjustIncreaseOrDecreaseAssetNo)
                {
                    _aCAdjustIncreaseOrDecreaseAssetNo = value;
                    NotifyChanged("ACAdjustIncreaseOrDecreaseAssetNo");
                }
            }
        }
        public DateTime ACAdjustIncreaseOrDecreaseAssetDate
        {
            get { return _aCAdjustIncreaseOrDecreaseAssetDate; }
            set
            {
                if (value != this._aCAdjustIncreaseOrDecreaseAssetDate)
                {
                    _aCAdjustIncreaseOrDecreaseAssetDate = value;
                    NotifyChanged("ACAdjustIncreaseOrDecreaseAssetDate");
                }
            }
        }
        public String ACAdjustIncreaseOrDecreaseAssetType
        {
            get { return _aCAdjustIncreaseOrDecreaseAssetType; }
            set
            {
                if (value != this._aCAdjustIncreaseOrDecreaseAssetType)
                {
                    _aCAdjustIncreaseOrDecreaseAssetType = value;
                    NotifyChanged("ACAdjustIncreaseOrDecreaseAssetType");
                }
            }
        }
        public int FK_ACObjectID
        {
            get { return _fK_ACObjectID; }
            set
            {
                if (value != this._fK_ACObjectID)
                {
                    _fK_ACObjectID = value;
                    NotifyChanged("FK_ACObjectID");
                }
            }
        }
        public String ACObjectType
        {
            get { return _aCObjectType; }
            set
            {
                if (value != this._aCObjectType)
                {
                    _aCObjectType = value;
                    NotifyChanged("ACObjectType");
                }
            }
        }
        public String ACObjectContactAddressLine3
        {
            get { return _aCObjectContactAddressLine3; }
            set
            {
                if (value != this._aCObjectContactAddressLine3)
                {
                    _aCObjectContactAddressLine3 = value;
                    NotifyChanged("ACObjectContactAddressLine3");
                }
            }
        }
        public String ACObjectTaxNumber
        {
            get { return _aCObjectTaxNumber; }
            set
            {
                if (value != this._aCObjectTaxNumber)
                {
                    _aCObjectTaxNumber = value;
                    NotifyChanged("ACObjectTaxNumber");
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
        public decimal ACAdjustIncreaseOrDecreaseAssetExchangeRate
        {
            get { return _aCAdjustIncreaseOrDecreaseAssetExchangeRate; }
            set
            {
                if (value != this._aCAdjustIncreaseOrDecreaseAssetExchangeRate)
                {
                    _aCAdjustIncreaseOrDecreaseAssetExchangeRate = value;
                    NotifyChanged("ACAdjustIncreaseOrDecreaseAssetExchangeRate");
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
        public int FK_BRInvoiceBranchID
        {
            get { return _fK_BRInvoiceBranchID; }
            set
            {
                if (value != this._fK_BRInvoiceBranchID)
                {
                    _fK_BRInvoiceBranchID = value;
                    NotifyChanged("FK_BRInvoiceBranchID");
                }
            }
        }
        public int FK_ACAccountPurchaseID
        {
            get { return _fK_ACAccountPurchaseID; }
            set
            {
                if (value != this._fK_ACAccountPurchaseID)
                {
                    _fK_ACAccountPurchaseID = value;
                    NotifyChanged("FK_ACAccountPurchaseID");
                }
            }
        }
        public String STToolbarActionName
        {
            get { return _sTToolbarActionName; }
            set
            {
                if (value != this._sTToolbarActionName)
                {
                    _sTToolbarActionName = value;
                    NotifyChanged("STToolbarActionName");
                }
            }
        }
        public String ACAdjustIncreaseOrDecreaseAssetPostedStatus
        {
            get { return _aCAdjustIncreaseOrDecreaseAssetPostedStatus; }
            set
            {
                if (value != this._aCAdjustIncreaseOrDecreaseAssetPostedStatus)
                {
                    _aCAdjustIncreaseOrDecreaseAssetPostedStatus = value;
                    NotifyChanged("ACAdjustIncreaseOrDecreaseAssetPostedStatus");
                }
            }
        }
        #endregion

        #region Extra Properties
        public DateTime ACAdjustIODAssetDateFrom { get; set; }
        public DateTime ACAdjustIODAssetDateTo { get; set; }
        public string ACAssObjectAccessKey { get; set; }
        public string ACObjectAccessKey { get; set; }
        #endregion
    }
    #endregion
}