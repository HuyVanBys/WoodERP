﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARCancelVoucherItemCosts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCancelVoucherItemCostsInfo
    //Created Date:11 Tháng Mười Hai 2018
    //-----------------------------------------------------------

    public class ARCancelVoucherItemCostsInfo : BusinessObject
    {
        public ARCancelVoucherItemCostsInfo()
        {
        }
        #region Variables
        protected int _aRCancelVoucherItemCostID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected int _fK_ARCancelVoucherID;
        protected int _fK_ARSaleOrderItemWorkID;
        protected String _aRCancelVoucherItemCostProductNo = String.Empty;
        protected String _aRCancelVoucherItemCostProductName = String.Empty;
        protected String _aRCancelVoucherItemCostProductDesc = String.Empty;
        protected decimal _aRCancelVoucherItemCostProductQty;
        protected decimal _aRCancelVoucherItemCostProductCancelQty;
        protected decimal _aRCancelVoucherItemCostProductCanceledQty;
        protected String _aRCancelVoucherItemCostProductType = String.Empty;
        protected decimal _aRCancelVoucherItemCostProductUnitPrice;
        protected decimal _aRCancelVoucherItemCostTotalAmount;
        protected decimal _aRCancelVoucherItemCostSubTotalAmount;
        protected String _aRCancelVoucherItemCostComment = String.Empty;
        protected decimal _aRCancelVoucherItemCostDiscountAmount;
        protected decimal _aRCancelVoucherItemCostDiscountPercent;
        protected String _aRCancelVoucherItemCostStatus = DefaultStatus;
        protected bool _aRCancelVoucherItemCostIsCharge = true;
        #endregion

        #region Public properties
        public int ARCancelVoucherItemCostID
        {
            get { return _aRCancelVoucherItemCostID; }
            set
            {
                if (value != this._aRCancelVoucherItemCostID)
                {
                    _aRCancelVoucherItemCostID = value;
                    NotifyChanged("ARCancelVoucherItemCostID");
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
        public int FK_ARSaleOrderID
        {
            get { return _fK_ARSaleOrderID; }
            set
            {
                if (value != this._fK_ARSaleOrderID)
                {
                    _fK_ARSaleOrderID = value;
                    NotifyChanged("FK_ARSaleOrderID");
                }
            }
        }
        public int FK_ARSaleOrderItemID
        {
            get { return _fK_ARSaleOrderItemID; }
            set
            {
                if (value != this._fK_ARSaleOrderItemID)
                {
                    _fK_ARSaleOrderItemID = value;
                    NotifyChanged("FK_ARSaleOrderItemID");
                }
            }
        }
        public int FK_ARCancelVoucherID
        {
            get { return _fK_ARCancelVoucherID; }
            set
            {
                if (value != this._fK_ARCancelVoucherID)
                {
                    _fK_ARCancelVoucherID = value;
                    NotifyChanged("FK_ARCancelVoucherID");
                }
            }
        }
        public int FK_ARSaleOrderItemWorkID
        {
            get { return _fK_ARSaleOrderItemWorkID; }
            set
            {
                if (value != this._fK_ARSaleOrderItemWorkID)
                {
                    _fK_ARSaleOrderItemWorkID = value;
                    NotifyChanged("FK_ARSaleOrderItemWorkID");
                }
            }
        }
        public String ARCancelVoucherItemCostProductNo
        {
            get { return _aRCancelVoucherItemCostProductNo; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductNo)
                {
                    _aRCancelVoucherItemCostProductNo = value;
                    NotifyChanged("ARCancelVoucherItemCostProductNo");
                }
            }
        }
        public String ARCancelVoucherItemCostProductName
        {
            get { return _aRCancelVoucherItemCostProductName; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductName)
                {
                    _aRCancelVoucherItemCostProductName = value;
                    NotifyChanged("ARCancelVoucherItemCostProductName");
                }
            }
        }
        public String ARCancelVoucherItemCostProductDesc
        {
            get { return _aRCancelVoucherItemCostProductDesc; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductDesc)
                {
                    _aRCancelVoucherItemCostProductDesc = value;
                    NotifyChanged("ARCancelVoucherItemCostProductDesc");
                }
            }
        }
        public decimal ARCancelVoucherItemCostProductQty
        {
            get { return _aRCancelVoucherItemCostProductQty; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductQty)
                {
                    _aRCancelVoucherItemCostProductQty = value;
                    NotifyChanged("ARCancelVoucherItemCostProductQty");
                }
            }
        }
        public decimal ARCancelVoucherItemCostProductCancelQty
        {
            get { return _aRCancelVoucherItemCostProductCancelQty; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductCancelQty)
                {
                    _aRCancelVoucherItemCostProductCancelQty = value;
                    NotifyChanged("ARCancelVoucherItemCostProductCancelQty");
                }
            }
        }
        public decimal ARCancelVoucherItemCostProductCanceledQty
        {
            get { return _aRCancelVoucherItemCostProductCanceledQty; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductCanceledQty)
                {
                    _aRCancelVoucherItemCostProductCanceledQty = value;
                    NotifyChanged("ARCancelVoucherItemCostProductCanceledQty");
                }
            }
        }
        public String ARCancelVoucherItemCostProductType
        {
            get { return _aRCancelVoucherItemCostProductType; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductType)
                {
                    _aRCancelVoucherItemCostProductType = value;
                    NotifyChanged("ARCancelVoucherItemCostProductType");
                }
            }
        }
        public decimal ARCancelVoucherItemCostProductUnitPrice
        {
            get { return _aRCancelVoucherItemCostProductUnitPrice; }
            set
            {
                if (value != this._aRCancelVoucherItemCostProductUnitPrice)
                {
                    _aRCancelVoucherItemCostProductUnitPrice = value;
                    NotifyChanged("ARCancelVoucherItemCostProductUnitPrice");
                }
            }
        }
        public decimal ARCancelVoucherItemCostTotalAmount
        {
            get { return _aRCancelVoucherItemCostTotalAmount; }
            set
            {
                if (value != this._aRCancelVoucherItemCostTotalAmount)
                {
                    _aRCancelVoucherItemCostTotalAmount = value;
                    NotifyChanged("ARCancelVoucherItemCostTotalAmount");
                }
            }
        }
        public decimal ARCancelVoucherItemCostSubTotalAmount
        {
            get { return _aRCancelVoucherItemCostSubTotalAmount; }
            set
            {
                if (value != this._aRCancelVoucherItemCostSubTotalAmount)
                {
                    _aRCancelVoucherItemCostSubTotalAmount = value;
                    NotifyChanged("ARCancelVoucherItemCostSubTotalAmount");
                }
            }
        }
        public String ARCancelVoucherItemCostComment
        {
            get { return _aRCancelVoucherItemCostComment; }
            set
            {
                if (value != this._aRCancelVoucherItemCostComment)
                {
                    _aRCancelVoucherItemCostComment = value;
                    NotifyChanged("ARCancelVoucherItemCostComment");
                }
            }
        }
        public decimal ARCancelVoucherItemCostDiscountAmount
        {
            get { return _aRCancelVoucherItemCostDiscountAmount; }
            set
            {
                if (value != this._aRCancelVoucherItemCostDiscountAmount)
                {
                    _aRCancelVoucherItemCostDiscountAmount = value;
                    NotifyChanged("ARCancelVoucherItemCostDiscountAmount");
                }
            }
        }
        public decimal ARCancelVoucherItemCostDiscountPercent
        {
            get { return _aRCancelVoucherItemCostDiscountPercent; }
            set
            {
                if (value != this._aRCancelVoucherItemCostDiscountPercent)
                {
                    _aRCancelVoucherItemCostDiscountPercent = value;
                    NotifyChanged("ARCancelVoucherItemCostDiscountPercent");
                }
            }
        }
        public String ARCancelVoucherItemCostStatus
        {
            get { return _aRCancelVoucherItemCostStatus; }
            set
            {
                if (value != this._aRCancelVoucherItemCostStatus)
                {
                    _aRCancelVoucherItemCostStatus = value;
                    NotifyChanged("ARCancelVoucherItemCostStatus");
                }
            }
        }
        public bool ARCancelVoucherItemCostIsCharge
        {
            get { return _aRCancelVoucherItemCostIsCharge; }
            set
            {
                if (value != this._aRCancelVoucherItemCostIsCharge)
                {
                    _aRCancelVoucherItemCostIsCharge = value;
                    NotifyChanged("ARCancelVoucherItemCostIsCharge");
                }
            }
        }
        #endregion
    }
    #endregion
}