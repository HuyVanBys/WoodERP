﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APPurchaseOrderItemOutSourcings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPurchaseOrderItemOutSourcingsInfo
    //Created Date:Tuesday, October 29, 2019
    //-----------------------------------------------------------

    public class APPurchaseOrderItemOutSourcingsInfo : BusinessObject
    {
        public APPurchaseOrderItemOutSourcingsInfo()
        {
        }
        #region Variables
        protected int _aPPurchaseOrderItemOutSourcingID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_APPurchaseOrderID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected int _fK_ICProductForBatchID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _aPPurchaseOrderItemOutSourcingGroup = String.Empty;
        protected String _aPPurchaseOrderItemOutSourcingProductNo = String.Empty;
        protected String _aPPurchaseOrderItemOutSourcingProductName = String.Empty;
        protected String _aPPurchaseOrderItemOutSourcingProductDesc = String.Empty;
        protected decimal _aPPurchaseOrderItemOutSourcingProductQty;
        protected decimal _aPPurchaseOrderItemOutSourcingProductUnitPrice;
        protected decimal _aPPurchaseOrderItemOutSourcingTotalAmount;
        protected decimal _aPPurchaseOrderItemOutSourcingProductHeight;
        protected decimal _aPPurchaseOrderItemOutSourcingProductWidth;
        protected decimal _aPPurchaseOrderItemOutSourcingProductLength;
        protected int _fK_MMBPSemiProductID;
        protected decimal _aPPurchaseOrderItemOutSourcingBPQty;
        #endregion

        #region Public properties
        public int APPurchaseOrderItemOutSourcingID
        {
            get { return _aPPurchaseOrderItemOutSourcingID; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingID)
                {
                    _aPPurchaseOrderItemOutSourcingID = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingID");
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
        public int FK_APPurchaseOrderID
        {
            get { return _fK_APPurchaseOrderID; }
            set
            {
                if (value != this._fK_APPurchaseOrderID)
                {
                    _fK_APPurchaseOrderID = value;
                    NotifyChanged("FK_APPurchaseOrderID");
                }
            }
        }
        public int FK_MMBatchProductID
        {
            get { return _fK_MMBatchProductID; }
            set
            {
                if (value != this._fK_MMBatchProductID)
                {
                    _fK_MMBatchProductID = value;
                    NotifyChanged("FK_MMBatchProductID");
                }
            }
        }
        public int FK_MMBatchProductItemID
        {
            get { return _fK_MMBatchProductItemID; }
            set
            {
                if (value != this._fK_MMBatchProductItemID)
                {
                    _fK_MMBatchProductItemID = value;
                    NotifyChanged("FK_MMBatchProductItemID");
                }
            }
        }
        public int FK_MMBatchProductProductionNormItemID
        {
            get { return _fK_MMBatchProductProductionNormItemID; }
            set
            {
                if (value != this._fK_MMBatchProductProductionNormItemID)
                {
                    _fK_MMBatchProductProductionNormItemID = value;
                    NotifyChanged("FK_MMBatchProductProductionNormItemID");
                }
            }
        }
        public int FK_ICProductForBatchID
        {
            get { return _fK_ICProductForBatchID; }
            set
            {
                if (value != this._fK_ICProductForBatchID)
                {
                    _fK_ICProductForBatchID = value;
                    NotifyChanged("FK_ICProductForBatchID");
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
        public String APPurchaseOrderItemOutSourcingGroup
        {
            get { return _aPPurchaseOrderItemOutSourcingGroup; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingGroup)
                {
                    _aPPurchaseOrderItemOutSourcingGroup = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingGroup");
                }
            }
        }
        public String APPurchaseOrderItemOutSourcingProductNo
        {
            get { return _aPPurchaseOrderItemOutSourcingProductNo; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductNo)
                {
                    _aPPurchaseOrderItemOutSourcingProductNo = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductNo");
                }
            }
        }
        public String APPurchaseOrderItemOutSourcingProductName
        {
            get { return _aPPurchaseOrderItemOutSourcingProductName; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductName)
                {
                    _aPPurchaseOrderItemOutSourcingProductName = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductName");
                }
            }
        }
        public String APPurchaseOrderItemOutSourcingProductDesc
        {
            get { return _aPPurchaseOrderItemOutSourcingProductDesc; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductDesc)
                {
                    _aPPurchaseOrderItemOutSourcingProductDesc = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductDesc");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingProductQty
        {
            get { return _aPPurchaseOrderItemOutSourcingProductQty; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductQty)
                {
                    _aPPurchaseOrderItemOutSourcingProductQty = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductQty");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingProductUnitPrice
        {
            get { return _aPPurchaseOrderItemOutSourcingProductUnitPrice; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductUnitPrice)
                {
                    _aPPurchaseOrderItemOutSourcingProductUnitPrice = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductUnitPrice");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingTotalAmount
        {
            get { return _aPPurchaseOrderItemOutSourcingTotalAmount; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingTotalAmount)
                {
                    _aPPurchaseOrderItemOutSourcingTotalAmount = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingTotalAmount");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingProductHeight
        {
            get { return _aPPurchaseOrderItemOutSourcingProductHeight; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductHeight)
                {
                    _aPPurchaseOrderItemOutSourcingProductHeight = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductHeight");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingProductWidth
        {
            get { return _aPPurchaseOrderItemOutSourcingProductWidth; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductWidth)
                {
                    _aPPurchaseOrderItemOutSourcingProductWidth = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductWidth");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingProductLength
        {
            get { return _aPPurchaseOrderItemOutSourcingProductLength; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingProductLength)
                {
                    _aPPurchaseOrderItemOutSourcingProductLength = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingProductLength");
                }
            }
        }
        public int FK_MMBPSemiProductID
        {
            get { return _fK_MMBPSemiProductID; }
            set
            {
                if (value != this._fK_MMBPSemiProductID)
                {
                    _fK_MMBPSemiProductID = value;
                    NotifyChanged("FK_MMBPSemiProductID");
                }
            }
        }
        public decimal APPurchaseOrderItemOutSourcingBPQty
        {
            get { return _aPPurchaseOrderItemOutSourcingBPQty; }
            set
            {
                if (value != this._aPPurchaseOrderItemOutSourcingBPQty)
                {
                    _aPPurchaseOrderItemOutSourcingBPQty = value;
                    NotifyChanged("APPurchaseOrderItemOutSourcingBPQty");
                }
            }
        }
        #endregion
    }
    #endregion
}