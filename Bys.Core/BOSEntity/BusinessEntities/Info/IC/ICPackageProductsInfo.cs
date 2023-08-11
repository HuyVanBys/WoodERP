﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICPackageProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICPackageProductsInfo
    //Created Date:Wednesday, September 21, 2011
    //-----------------------------------------------------------

    public class ICPackageProductsInfo : BusinessObject
    {
        public ICPackageProductsInfo()
        {
        }
        #region Variables
        protected int _iCPackageProductID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICPackageID;
        protected int _fK_ICProductID;
        protected decimal _iCPackageProductQty;
        #endregion

        #region Public properties
        public int ICPackageProductID
        {
            get { return _iCPackageProductID; }
            set
            {
                if (value != this._iCPackageProductID)
                {
                    _iCPackageProductID = value;
                    NotifyChanged("ICPackageProductID");
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
        public decimal ICPackageProductQty
        {
            get { return _iCPackageProductQty; }
            set
            {
                if (value != this._iCPackageProductQty)
                {
                    _iCPackageProductQty = value;
                    NotifyChanged("ICPackageProductQty");
                }
            }
        }
        #endregion

        #region Extra Properties
        /// <summary>
        /// Gets or sets product's no
        /// </summary>
        public String ICProductNo { get; set; }
        /// <summary>
        /// Gets or sets product's name
        /// </summary>
        public String ICProductName { get; set; }
        /// <summary>
        /// Gets or sets supplier id of product
        /// </summary>
        public String APSupplierName { get; set; }
        /// <summary>
        /// Gets or sets product group id
        /// </summary>
        public String ICProductGroupName { get; set; }
        /// <summary>
        /// Gets or sets product supplier no
        /// </summary>
        public string ICProductSupplierNumber { get; set; }
        /// <summary>
        /// Gets or sets product description
        /// </summary>
        public string ICProductDesc { get; set; }
        #endregion
    }
    #endregion
}