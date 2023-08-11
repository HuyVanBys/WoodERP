﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICTransferItemPackages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICTransferItemPackagesInfo
    //Created Date:Wednesday, October 12, 2011
    //-----------------------------------------------------------

    public class ICTransferItemPackagesInfo : BusinessObject
    {
        public ICTransferItemPackagesInfo()
        {
        }
        #region Variables
        protected int _iCTransferItemPackageID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICTransferItemID;
        protected int _fK_ICStockID;
        protected int _fK_ICProductID;
        protected int _fK_ICPackageID;
        protected decimal _iCTransferItemPackageQty;
        #endregion

        #region Public properties
        public int ICTransferItemPackageID
        {
            get { return _iCTransferItemPackageID; }
            set
            {
                if (value != this._iCTransferItemPackageID)
                {
                    _iCTransferItemPackageID = value;
                    NotifyChanged("ICTransferItemPackageID");
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
        public int FK_ICTransferItemID
        {
            get { return _fK_ICTransferItemID; }
            set
            {
                if (value != this._fK_ICTransferItemID)
                {
                    _fK_ICTransferItemID = value;
                    NotifyChanged("FK_ICTransferItemID");
                }
            }
        }
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
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
        public int FK_ICPackageID
        {
            get { return _fK_ICPackageID; }
            set
            {
                if (value != this._fK_ICPackageID)
                {
                    _fK_ICPackageID = value;
                    NotifyChanged("FK_ICPackageID");
                }
            }
        }
        public decimal ICTransferItemPackageQty
        {
            get { return _iCTransferItemPackageQty; }
            set
            {
                if (value != this._iCTransferItemPackageQty)
                {
                    _iCTransferItemPackageQty = value;
                    NotifyChanged("ICTransferItemPackageQty");
                }
            }
        }
        #endregion

        #region Extra Properties
        public string ICPackageNo { get; set; }
        #endregion
    }
    #endregion
}