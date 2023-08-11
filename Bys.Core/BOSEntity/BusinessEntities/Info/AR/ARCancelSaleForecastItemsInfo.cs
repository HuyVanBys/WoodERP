﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARCancelSaleForecastItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCancelSaleForecastItemsInfo
    //Created Date:Tuesday, November 10, 2015
    //-----------------------------------------------------------

    public class ARCancelSaleForecastItemsInfo : BusinessObject
    {
        public ARCancelSaleForecastItemsInfo()
        {
        }
        #region Variables
        protected int _aRCancelSaleForecastItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARCancelSaleForecastID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICStockID;
        protected int _fK_ARSaleForecastID;
        protected int _fK_ARSaleForecastItemID;
        protected String _aRCancelSaleForecastItemProductType = String.Empty;
        protected String _aRCancelSaleForecastItemProductSerialNo = String.Empty;
        protected String _aRCancelSaleForecastItemProductAttribute = String.Empty;
        protected String _aRCancelSaleForecastItemProductName = String.Empty;
        protected String _aRCancelSaleForecastItemProductDesc = String.Empty;
        protected decimal _aRCancelSaleForecastItemProductUnitPrice;
        protected decimal _aRCancelSaleForecastItemProductUnitCost;
        protected decimal _aRCancelSaleForecastItemProductDiscount;
        protected decimal _aRCancelSaleForecastItemProductTaxPercent;
        protected decimal _aRCancelSaleForecastItemProductQty;
        protected decimal _aRCancelSaleForecastItemSaleForecastQty;
        protected decimal _aRCancelSaleForecastItemTotalQty;
        protected decimal _aRCancelSaleForecastItemPrice;
        protected decimal _aRCancelSaleForecastItemTaxAmount;
        protected decimal _aRCancelSaleForecastItemDiscountAmount;
        protected decimal _aRCancelSaleForecastItemNetAmount;
        protected decimal _aRCancelSaleForecastItemTotalAmount;
        protected decimal _aRCancelSaleForecastItemTotalCost;
        protected String _aRCancelSaleForecastItemProductSupplierNo = String.Empty;
        protected String _aRCancelSaleForecastItemComment = String.Empty;
        protected string _aRCancelSaleForecastItemProductNoOfOldSys = string.Empty;
        protected string _aRCancelSaleForecastItemProductCustomerNumber = string.Empty;
        #endregion

        #region Public properties
        public int ARCancelSaleForecastItemID
        {
            get { return _aRCancelSaleForecastItemID; }
            set
            {
                if (value != this._aRCancelSaleForecastItemID)
                {
                    _aRCancelSaleForecastItemID = value;
                    NotifyChanged("ARCancelSaleForecastItemID");
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
        public int FK_ARCancelSaleForecastID
        {
            get { return _fK_ARCancelSaleForecastID; }
            set
            {
                if (value != this._fK_ARCancelSaleForecastID)
                {
                    _fK_ARCancelSaleForecastID = value;
                    NotifyChanged("FK_ARCancelSaleForecastID");
                }
            }
        }
        public int FK_ICDepartmentID
        {
            get { return _fK_ICDepartmentID; }
            set
            {
                if (value != this._fK_ICDepartmentID)
                {
                    _fK_ICDepartmentID = value;
                    NotifyChanged("FK_ICDepartmentID");
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
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
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
        public int FK_ARSaleForecastID
        {
            get { return _fK_ARSaleForecastID; }
            set
            {
                if (value != this._fK_ARSaleForecastID)
                {
                    _fK_ARSaleForecastID = value;
                    NotifyChanged("FK_ARSaleForecastID");
                }
            }
        }
        public int FK_ARSaleForecastItemID
        {
            get { return _fK_ARSaleForecastItemID; }
            set
            {
                if (value != this._fK_ARSaleForecastItemID)
                {
                    _fK_ARSaleForecastItemID = value;
                    NotifyChanged("FK_ARSaleForecastItemID");
                }
            }
        }
        public String ARCancelSaleForecastItemProductType
        {
            get { return _aRCancelSaleForecastItemProductType; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductType)
                {
                    _aRCancelSaleForecastItemProductType = value;
                    NotifyChanged("ARCancelSaleForecastItemProductType");
                }
            }
        }
        public String ARCancelSaleForecastItemProductSerialNo
        {
            get { return _aRCancelSaleForecastItemProductSerialNo; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductSerialNo)
                {
                    _aRCancelSaleForecastItemProductSerialNo = value;
                    NotifyChanged("ARCancelSaleForecastItemProductSerialNo");
                }
            }
        }
        public String ARCancelSaleForecastItemProductAttribute
        {
            get { return _aRCancelSaleForecastItemProductAttribute; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductAttribute)
                {
                    _aRCancelSaleForecastItemProductAttribute = value;
                    NotifyChanged("ARCancelSaleForecastItemProductAttribute");
                }
            }
        }
        public String ARCancelSaleForecastItemProductName
        {
            get { return _aRCancelSaleForecastItemProductName; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductName)
                {
                    _aRCancelSaleForecastItemProductName = value;
                    NotifyChanged("ARCancelSaleForecastItemProductName");
                }
            }
        }
        public String ARCancelSaleForecastItemProductDesc
        {
            get { return _aRCancelSaleForecastItemProductDesc; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductDesc)
                {
                    _aRCancelSaleForecastItemProductDesc = value;
                    NotifyChanged("ARCancelSaleForecastItemProductDesc");
                }
            }
        }
        public decimal ARCancelSaleForecastItemProductUnitPrice
        {
            get { return _aRCancelSaleForecastItemProductUnitPrice; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductUnitPrice)
                {
                    _aRCancelSaleForecastItemProductUnitPrice = value;
                    NotifyChanged("ARCancelSaleForecastItemProductUnitPrice");
                }
            }
        }
        public decimal ARCancelSaleForecastItemProductUnitCost
        {
            get { return _aRCancelSaleForecastItemProductUnitCost; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductUnitCost)
                {
                    _aRCancelSaleForecastItemProductUnitCost = value;
                    NotifyChanged("ARCancelSaleForecastItemProductUnitCost");
                }
            }
        }
        public decimal ARCancelSaleForecastItemProductDiscount
        {
            get { return _aRCancelSaleForecastItemProductDiscount; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductDiscount)
                {
                    _aRCancelSaleForecastItemProductDiscount = value;
                    NotifyChanged("ARCancelSaleForecastItemProductDiscount");
                }
            }
        }
        public decimal ARCancelSaleForecastItemProductTaxPercent
        {
            get { return _aRCancelSaleForecastItemProductTaxPercent; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductTaxPercent)
                {
                    _aRCancelSaleForecastItemProductTaxPercent = value;
                    NotifyChanged("ARCancelSaleForecastItemProductTaxPercent");
                }
            }
        }
        public decimal ARCancelSaleForecastItemProductQty
        {
            get { return _aRCancelSaleForecastItemProductQty; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductQty)
                {
                    _aRCancelSaleForecastItemProductQty = value;
                    NotifyChanged("ARCancelSaleForecastItemProductQty");
                }
            }
        }
        public decimal ARCancelSaleForecastItemSaleForecastQty
        {
            get { return _aRCancelSaleForecastItemSaleForecastQty; }
            set
            {
                if (value != this._aRCancelSaleForecastItemSaleForecastQty)
                {
                    _aRCancelSaleForecastItemSaleForecastQty = value;
                    NotifyChanged("ARCancelSaleForecastItemSaleForecastQty");
                }
            }
        }
        public decimal ARCancelSaleForecastItemTotalQty
        {
            get { return _aRCancelSaleForecastItemTotalQty; }
            set
            {
                if (value != this._aRCancelSaleForecastItemTotalQty)
                {
                    _aRCancelSaleForecastItemTotalQty = value;
                    NotifyChanged("ARCancelSaleForecastItemTotalQty");
                }
            }
        }
        public decimal ARCancelSaleForecastItemPrice
        {
            get { return _aRCancelSaleForecastItemPrice; }
            set
            {
                if (value != this._aRCancelSaleForecastItemPrice)
                {
                    _aRCancelSaleForecastItemPrice = value;
                    NotifyChanged("ARCancelSaleForecastItemPrice");
                }
            }
        }
        public decimal ARCancelSaleForecastItemTaxAmount
        {
            get { return _aRCancelSaleForecastItemTaxAmount; }
            set
            {
                if (value != this._aRCancelSaleForecastItemTaxAmount)
                {
                    _aRCancelSaleForecastItemTaxAmount = value;
                    NotifyChanged("ARCancelSaleForecastItemTaxAmount");
                }
            }
        }
        public decimal ARCancelSaleForecastItemDiscountAmount
        {
            get { return _aRCancelSaleForecastItemDiscountAmount; }
            set
            {
                if (value != this._aRCancelSaleForecastItemDiscountAmount)
                {
                    _aRCancelSaleForecastItemDiscountAmount = value;
                    NotifyChanged("ARCancelSaleForecastItemDiscountAmount");
                }
            }
        }
        public decimal ARCancelSaleForecastItemNetAmount
        {
            get { return _aRCancelSaleForecastItemNetAmount; }
            set
            {
                if (value != this._aRCancelSaleForecastItemNetAmount)
                {
                    _aRCancelSaleForecastItemNetAmount = value;
                    NotifyChanged("ARCancelSaleForecastItemNetAmount");
                }
            }
        }
        public decimal ARCancelSaleForecastItemTotalAmount
        {
            get { return _aRCancelSaleForecastItemTotalAmount; }
            set
            {
                if (value != this._aRCancelSaleForecastItemTotalAmount)
                {
                    _aRCancelSaleForecastItemTotalAmount = value;
                    NotifyChanged("ARCancelSaleForecastItemTotalAmount");
                }
            }
        }
        public decimal ARCancelSaleForecastItemTotalCost
        {
            get { return _aRCancelSaleForecastItemTotalCost; }
            set
            {
                if (value != this._aRCancelSaleForecastItemTotalCost)
                {
                    _aRCancelSaleForecastItemTotalCost = value;
                    NotifyChanged("ARCancelSaleForecastItemTotalCost");
                }
            }
        }
        public String ARCancelSaleForecastItemProductSupplierNo
        {
            get { return _aRCancelSaleForecastItemProductSupplierNo; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductSupplierNo)
                {
                    _aRCancelSaleForecastItemProductSupplierNo = value;
                    NotifyChanged("ARCancelSaleForecastItemProductSupplierNo");
                }
            }
        }
        public String ARCancelSaleForecastItemComment
        {
            get { return _aRCancelSaleForecastItemComment; }
            set
            {
                if (value != this._aRCancelSaleForecastItemComment)
                {
                    _aRCancelSaleForecastItemComment = value;
                    NotifyChanged("ARCancelSaleForecastItemComment");
                }
            }
        }
        public string ARCancelSaleForecastItemProductNoOfOldSys
        {
            get { return _aRCancelSaleForecastItemProductNoOfOldSys; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductNoOfOldSys)
                {
                    _aRCancelSaleForecastItemProductNoOfOldSys = value;
                    NotifyChanged("ARCancelSaleForecastItemProductNoOfOldSys");
                }
            }
        }
        public string ARCancelSaleForecastItemProductCustomerNumber
        {
            get { return _aRCancelSaleForecastItemProductCustomerNumber; }
            set
            {
                if (value != this._aRCancelSaleForecastItemProductCustomerNumber)
                {
                    _aRCancelSaleForecastItemProductCustomerNumber = value;
                    NotifyChanged("ARCancelSaleForecastItemProductCustomerNumber");
                }
            }
        }

        #endregion

        #region Extra Properties

        public byte[] ARCancelSaleForecastItemProductPicture { get; set; }

        #endregion
    }
    #endregion
}