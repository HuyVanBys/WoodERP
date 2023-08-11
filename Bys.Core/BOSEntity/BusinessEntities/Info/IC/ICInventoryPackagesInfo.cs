﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICInventoryPackages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICInventoryPackagesInfo
    //Created Date:Thursday, October 13, 2011
    //-----------------------------------------------------------

    public class ICInventoryPackagesInfo : BusinessObject
    {
        public ICInventoryPackagesInfo()
        {
        }
        #region Variables
        protected int _iCInventoryPackageID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICStockID;
        protected int _fK_ICPackageID;
        protected int _fK_ICProductID;
        protected decimal _iCInventoryPackageQty;
        #endregion

        #region Public properties
        public int ICInventoryPackageID
        {
            get { return _iCInventoryPackageID; }
            set
            {
                if (value != this._iCInventoryPackageID)
                {
                    _iCInventoryPackageID = value;
                    NotifyChanged("ICInventoryPackageID");
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
        public decimal ICInventoryPackageQty
        {
            get { return _iCInventoryPackageQty; }
            set
            {
                if (value != this._iCInventoryPackageQty)
                {
                    _iCInventoryPackageQty = value;
                    NotifyChanged("ICInventoryPackageQty");
                }
            }
        }
        #endregion
    }
    #endregion
}