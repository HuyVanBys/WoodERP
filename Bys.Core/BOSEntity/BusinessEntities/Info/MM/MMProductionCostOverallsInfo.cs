﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostOveralls
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostOverallsInfo
    //Created Date:Tuesday, December 01, 2015
    //-----------------------------------------------------------

    public class MMProductionCostOverallsInfo : BusinessObject
    {
        public MMProductionCostOverallsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostOverallID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMProductionCostID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMOperationID;
        protected int _fK_ICProductID;
        protected int _fK_MMProductionNormID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_MMProposalID;
        protected String _mMProductionCostOverallProductNo = String.Empty;
        protected String _mMProductionCostOverallProductName = String.Empty;
        protected String _mMProductionCostOverallProductDesc = String.Empty;
        protected int _mMProductionCostOverallBatchComponent;
        protected String _mMProductionCostOverallCostTypeCombo = String.Empty;
        protected decimal _mMProductionCostOverallTotalCost;
        protected int _fK_ARSaleOrderItemID;
        protected String _mMProductionCostOverallShipmentNo = String.Empty;
        protected String _mMProductionCostOverallShipmentDesc = String.Empty;
        protected DateTime _mMProductionCostOverallShipmentDate = DateTime.MaxValue;
        protected int _mMProductionCostOverallShipmentItemID;
        protected int _fK_ICProductSerieID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICStockID;
        protected String _mMProductionCostOverallProductSerialNo = String.Empty;
        protected decimal _mMProductionCostOverallProductUnitPrice;
        protected decimal _mMProductionCostOverallProductUnitCost;
        protected String _mMProductionCostOverallShipmentItemComment = String.Empty;
        protected decimal _mMProductionCostOverallProductQty;
        protected decimal _mMProductionCostOverallShipmentItemNetAmount;
        protected decimal _mMProductionCostOverallShipmentItemTotalAmount;
        protected decimal _mMProductionCostOverallShipmentItemTotalCost;
        protected String _mMProductionCostOverallProductSupplierNo = String.Empty;
        protected decimal _mMProductionCostOverallProductBatchQty;
        #endregion

        #region Public properties
        public int MMProductionCostOverallID
        {
            get { return _mMProductionCostOverallID; }
            set
            {
                if (value != this._mMProductionCostOverallID)
                {
                    _mMProductionCostOverallID = value;
                    NotifyChanged("MMProductionCostOverallID");
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
        public int FK_MMProductionCostID
        {
            get { return _fK_MMProductionCostID; }
            set
            {
                if (value != this._fK_MMProductionCostID)
                {
                    _fK_MMProductionCostID = value;
                    NotifyChanged("FK_MMProductionCostID");
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
        public int FK_MMOperationID
        {
            get { return _fK_MMOperationID; }
            set
            {
                if (value != this._fK_MMOperationID)
                {
                    _fK_MMOperationID = value;
                    NotifyChanged("FK_MMOperationID");
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
        public int FK_MMProductionNormID
        {
            get { return _fK_MMProductionNormID; }
            set
            {
                if (value != this._fK_MMProductionNormID)
                {
                    _fK_MMProductionNormID = value;
                    NotifyChanged("FK_MMProductionNormID");
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
        public int FK_MMProposalID
        {
            get { return _fK_MMProposalID; }
            set
            {
                if (value != this._fK_MMProposalID)
                {
                    _fK_MMProposalID = value;
                    NotifyChanged("FK_MMProposalID");
                }
            }
        }
        public String MMProductionCostOverallProductNo
        {
            get { return _mMProductionCostOverallProductNo; }
            set
            {
                if (value != this._mMProductionCostOverallProductNo)
                {
                    _mMProductionCostOverallProductNo = value;
                    NotifyChanged("MMProductionCostOverallProductNo");
                }
            }
        }
        public String MMProductionCostOverallProductName
        {
            get { return _mMProductionCostOverallProductName; }
            set
            {
                if (value != this._mMProductionCostOverallProductName)
                {
                    _mMProductionCostOverallProductName = value;
                    NotifyChanged("MMProductionCostOverallProductName");
                }
            }
        }
        public String MMProductionCostOverallProductDesc
        {
            get { return _mMProductionCostOverallProductDesc; }
            set
            {
                if (value != this._mMProductionCostOverallProductDesc)
                {
                    _mMProductionCostOverallProductDesc = value;
                    NotifyChanged("MMProductionCostOverallProductDesc");
                }
            }
        }
        public int MMProductionCostOverallBatchComponent
        {
            get { return _mMProductionCostOverallBatchComponent; }
            set
            {
                if (value != this._mMProductionCostOverallBatchComponent)
                {
                    _mMProductionCostOverallBatchComponent = value;
                    NotifyChanged("MMProductionCostOverallBatchComponent");
                }
            }
        }
        public String MMProductionCostOverallCostTypeCombo
        {
            get { return _mMProductionCostOverallCostTypeCombo; }
            set
            {
                if (value != this._mMProductionCostOverallCostTypeCombo)
                {
                    _mMProductionCostOverallCostTypeCombo = value;
                    NotifyChanged("MMProductionCostOverallCostTypeCombo");
                }
            }
        }
        public decimal MMProductionCostOverallTotalCost
        {
            get { return _mMProductionCostOverallTotalCost; }
            set
            {
                if (value != this._mMProductionCostOverallTotalCost)
                {
                    _mMProductionCostOverallTotalCost = value;
                    NotifyChanged("MMProductionCostOverallTotalCost");
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
        public String MMProductionCostOverallShipmentNo
        {
            get { return _mMProductionCostOverallShipmentNo; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentNo)
                {
                    _mMProductionCostOverallShipmentNo = value;
                    NotifyChanged("MMProductionCostOverallShipmentNo");
                }
            }
        }
        public String MMProductionCostOverallShipmentDesc
        {
            get { return _mMProductionCostOverallShipmentDesc; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentDesc)
                {
                    _mMProductionCostOverallShipmentDesc = value;
                    NotifyChanged("MMProductionCostOverallShipmentDesc");
                }
            }
        }
        public DateTime MMProductionCostOverallShipmentDate
        {
            get { return _mMProductionCostOverallShipmentDate; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentDate)
                {
                    _mMProductionCostOverallShipmentDate = value;
                    NotifyChanged("MMProductionCostOverallShipmentDate");
                }
            }
        }
        public int MMProductionCostOverallShipmentItemID
        {
            get { return _mMProductionCostOverallShipmentItemID; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentItemID)
                {
                    _mMProductionCostOverallShipmentItemID = value;
                    NotifyChanged("MMProductionCostOverallShipmentItemID");
                }
            }
        }
        public int FK_ICProductSerieID
        {
            get { return _fK_ICProductSerieID; }
            set
            {
                if (value != this._fK_ICProductSerieID)
                {
                    _fK_ICProductSerieID = value;
                    NotifyChanged("FK_ICProductSerieID");
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
        public String MMProductionCostOverallProductSerialNo
        {
            get { return _mMProductionCostOverallProductSerialNo; }
            set
            {
                if (value != this._mMProductionCostOverallProductSerialNo)
                {
                    _mMProductionCostOverallProductSerialNo = value;
                    NotifyChanged("MMProductionCostOverallProductSerialNo");
                }
            }
        }
        public decimal MMProductionCostOverallProductUnitPrice
        {
            get { return _mMProductionCostOverallProductUnitPrice; }
            set
            {
                if (value != this._mMProductionCostOverallProductUnitPrice)
                {
                    _mMProductionCostOverallProductUnitPrice = value;
                    NotifyChanged("MMProductionCostOverallProductUnitPrice");
                }
            }
        }
        public decimal MMProductionCostOverallProductUnitCost
        {
            get { return _mMProductionCostOverallProductUnitCost; }
            set
            {
                if (value != this._mMProductionCostOverallProductUnitCost)
                {
                    _mMProductionCostOverallProductUnitCost = value;
                    NotifyChanged("MMProductionCostOverallProductUnitCost");
                }
            }
        }
        public String MMProductionCostOverallShipmentItemComment
        {
            get { return _mMProductionCostOverallShipmentItemComment; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentItemComment)
                {
                    _mMProductionCostOverallShipmentItemComment = value;
                    NotifyChanged("MMProductionCostOverallShipmentItemComment");
                }
            }
        }
        public decimal MMProductionCostOverallProductQty
        {
            get { return _mMProductionCostOverallProductQty; }
            set
            {
                if (value != this._mMProductionCostOverallProductQty)
                {
                    _mMProductionCostOverallProductQty = value;
                    NotifyChanged("MMProductionCostOverallProductQty");
                }
            }
        }
        public decimal MMProductionCostOverallShipmentItemNetAmount
        {
            get { return _mMProductionCostOverallShipmentItemNetAmount; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentItemNetAmount)
                {
                    _mMProductionCostOverallShipmentItemNetAmount = value;
                    NotifyChanged("MMProductionCostOverallShipmentItemNetAmount");
                }
            }
        }
        public decimal MMProductionCostOverallShipmentItemTotalAmount
        {
            get { return _mMProductionCostOverallShipmentItemTotalAmount; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentItemTotalAmount)
                {
                    _mMProductionCostOverallShipmentItemTotalAmount = value;
                    NotifyChanged("MMProductionCostOverallShipmentItemTotalAmount");
                }
            }
        }
        public decimal MMProductionCostOverallShipmentItemTotalCost
        {
            get { return _mMProductionCostOverallShipmentItemTotalCost; }
            set
            {
                if (value != this._mMProductionCostOverallShipmentItemTotalCost)
                {
                    _mMProductionCostOverallShipmentItemTotalCost = value;
                    NotifyChanged("MMProductionCostOverallShipmentItemTotalCost");
                }
            }
        }
        public String MMProductionCostOverallProductSupplierNo
        {
            get { return _mMProductionCostOverallProductSupplierNo; }
            set
            {
                if (value != this._mMProductionCostOverallProductSupplierNo)
                {
                    _mMProductionCostOverallProductSupplierNo = value;
                    NotifyChanged("MMProductionCostOverallProductSupplierNo");
                }
            }
        }
        public decimal MMProductionCostOverallProductBatchQty
        {
            get { return _mMProductionCostOverallProductBatchQty; }
            set
            {
                if (value != this._mMProductionCostOverallProductBatchQty)
                {
                    _mMProductionCostOverallProductBatchQty = value;
                    NotifyChanged("MMProductionCostOverallProductBatchQty");
                }
            }
        }
        #endregion
    }
    #endregion
}