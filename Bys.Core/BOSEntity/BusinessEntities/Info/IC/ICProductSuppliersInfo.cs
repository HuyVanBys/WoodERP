﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductSuppliers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductSuppliersInfo
    //Created Date:Tuesday, September 20, 2011
    //-----------------------------------------------------------

    public class ICProductSuppliersInfo : BusinessObject
    {
        public ICProductSuppliersInfo()
        {
        }
        #region Variables
        protected int _iCProductSupplierID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APSupplierID;
        protected int _fK_ICProductID;
        protected decimal _iCProductSupplierPrice;
        protected String _iCProductSupplierNumber = String.Empty;
        protected String _iCProductSupplierBarcode = String.Empty;
        #endregion

        #region Public properties
        public int ICProductSupplierID
        {
            get { return _iCProductSupplierID; }
            set
            {
                if (value != this._iCProductSupplierID)
                {
                    _iCProductSupplierID = value;
                    NotifyChanged("ICProductSupplierID");
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
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
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
        public decimal ICProductSupplierPrice
        {
            get { return _iCProductSupplierPrice; }
            set
            {
                if (value != this._iCProductSupplierPrice)
                {
                    _iCProductSupplierPrice = value;
                    NotifyChanged("ICProductSupplierPrice");
                }
            }
        }
        public String ICProductSupplierNumber
        {
            get { return _iCProductSupplierNumber; }
            set
            {
                if (value != this._iCProductSupplierNumber)
                {
                    _iCProductSupplierNumber = value;
                    NotifyChanged("ICProductSupplierNumber");
                }
            }
        }
        public String ICProductSupplierBarcode
        {
            get { return _iCProductSupplierBarcode; }
            set
            {
                if (value != this._iCProductSupplierBarcode)
                {
                    _iCProductSupplierBarcode = value;
                    NotifyChanged("ICProductSupplierBarcode");
                }
            }
        }
        #endregion
    }
    #endregion
}