﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostIngredientCostDDDGs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostIngredientCostDDDGsInfo
    //Created Date:Wednesday, August 03, 2016
    //-----------------------------------------------------------

    public class MMProductionCostIngredientCostDDDGsInfo : BusinessObject
    {
        public MMProductionCostIngredientCostDDDGsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostIngredientCostDDDGID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_MMProductionCostID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMOperationID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICStockID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductIDForBatch;
        protected String _mMProductionCostIngredientCostDDDGReferenceNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGReferenceType = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGBatchProductNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGOperationName = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGMeasureUnitName = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGStockName = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGProductGroupName = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGProductNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGProductName = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGProductDesc = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGProductSerialNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDDGProductAttribute = String.Empty;
        protected decimal _mMProductionCostIngredientCostDDDGProductUnitCost;
        protected decimal _mMProductionCostIngredientCostDDDGProductQty;
        protected decimal _mMProductionCostIngredientCostDDDGTotalCost;
        protected int _mMProductionCostIngredientCostDDDGBatchComponent;
        protected decimal _mMProductionCostIngredientCostDDDGProductWoodQty;
        protected decimal _mMProductionCostIngredientCostDDDGWoodFee;
        protected decimal _mMProductionCostIngredientCostDDDGGeneralFee;
        protected decimal _mMProductionCostIngredientCostDDDGDirectSalaryFee;
        protected decimal _mMProductionCostIngredientCostDDDGHardwareFee;
        protected decimal _mMProductionCostIngredientCostDDDGPaintFee;
        protected decimal _mMProductionCostIngredientCostDDDGMaintainFee;
        protected decimal _mMProductionCostIngredientCostDDDGElecFee;
        protected decimal _mMProductionCostIngredientCostDDDGDepreciationFee;
        protected decimal _mMProductionCostIngredientCostDDDGOtherFee;
        protected int _fK_ICReferenceID;
        protected int _fK_ICReferenceItemID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_ICProductSerieID;
        protected String _mMProductionCostIngredientCostDDDGReferenceVoucherType = String.Empty;
        protected decimal _mMProductionCostIngredientCostDDDGReceiptQty;
        protected int _mMProductionCostIngredientCostDDDGIndex;
        #endregion

        #region Public properties
        public int MMProductionCostIngredientCostDDDGID
        {
            get { return _mMProductionCostIngredientCostDDDGID; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGID)
                {
                    _mMProductionCostIngredientCostDDDGID = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGID");
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
        public int FK_ICProductIDForBatch
        {
            get { return _fK_ICProductIDForBatch; }
            set
            {
                if (value != this._fK_ICProductIDForBatch)
                {
                    _fK_ICProductIDForBatch = value;
                    NotifyChanged("FK_ICProductIDForBatch");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGReferenceNo
        {
            get { return _mMProductionCostIngredientCostDDDGReferenceNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGReferenceNo)
                {
                    _mMProductionCostIngredientCostDDDGReferenceNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGReferenceNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGReferenceType
        {
            get { return _mMProductionCostIngredientCostDDDGReferenceType; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGReferenceType)
                {
                    _mMProductionCostIngredientCostDDDGReferenceType = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGReferenceType");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGBatchProductNo
        {
            get { return _mMProductionCostIngredientCostDDDGBatchProductNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGBatchProductNo)
                {
                    _mMProductionCostIngredientCostDDDGBatchProductNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGBatchProductNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGOperationName
        {
            get { return _mMProductionCostIngredientCostDDDGOperationName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGOperationName)
                {
                    _mMProductionCostIngredientCostDDDGOperationName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGOperationName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGMeasureUnitName
        {
            get { return _mMProductionCostIngredientCostDDDGMeasureUnitName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGMeasureUnitName)
                {
                    _mMProductionCostIngredientCostDDDGMeasureUnitName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGMeasureUnitName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGStockName
        {
            get { return _mMProductionCostIngredientCostDDDGStockName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGStockName)
                {
                    _mMProductionCostIngredientCostDDDGStockName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGStockName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGProductGroupName
        {
            get { return _mMProductionCostIngredientCostDDDGProductGroupName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductGroupName)
                {
                    _mMProductionCostIngredientCostDDDGProductGroupName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductGroupName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGProductNo
        {
            get { return _mMProductionCostIngredientCostDDDGProductNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductNo)
                {
                    _mMProductionCostIngredientCostDDDGProductNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGProductName
        {
            get { return _mMProductionCostIngredientCostDDDGProductName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductName)
                {
                    _mMProductionCostIngredientCostDDDGProductName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGProductDesc
        {
            get { return _mMProductionCostIngredientCostDDDGProductDesc; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductDesc)
                {
                    _mMProductionCostIngredientCostDDDGProductDesc = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductDesc");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGProductSerialNo
        {
            get { return _mMProductionCostIngredientCostDDDGProductSerialNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductSerialNo)
                {
                    _mMProductionCostIngredientCostDDDGProductSerialNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductSerialNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDDGProductAttribute
        {
            get { return _mMProductionCostIngredientCostDDDGProductAttribute; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductAttribute)
                {
                    _mMProductionCostIngredientCostDDDGProductAttribute = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductAttribute");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGProductUnitCost
        {
            get { return _mMProductionCostIngredientCostDDDGProductUnitCost; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductUnitCost)
                {
                    _mMProductionCostIngredientCostDDDGProductUnitCost = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductUnitCost");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGProductQty
        {
            get { return _mMProductionCostIngredientCostDDDGProductQty; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductQty)
                {
                    _mMProductionCostIngredientCostDDDGProductQty = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductQty");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGTotalCost
        {
            get { return _mMProductionCostIngredientCostDDDGTotalCost; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGTotalCost)
                {
                    _mMProductionCostIngredientCostDDDGTotalCost = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGTotalCost");
                }
            }
        }
        public int MMProductionCostIngredientCostDDDGBatchComponent
        {
            get { return _mMProductionCostIngredientCostDDDGBatchComponent; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGBatchComponent)
                {
                    _mMProductionCostIngredientCostDDDGBatchComponent = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGBatchComponent");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGProductWoodQty
        {
            get { return _mMProductionCostIngredientCostDDDGProductWoodQty; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGProductWoodQty)
                {
                    _mMProductionCostIngredientCostDDDGProductWoodQty = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGProductWoodQty");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGWoodFee
        {
            get { return _mMProductionCostIngredientCostDDDGWoodFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGWoodFee)
                {
                    _mMProductionCostIngredientCostDDDGWoodFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGWoodFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGGeneralFee
        {
            get { return _mMProductionCostIngredientCostDDDGGeneralFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGGeneralFee)
                {
                    _mMProductionCostIngredientCostDDDGGeneralFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGGeneralFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGDirectSalaryFee
        {
            get { return _mMProductionCostIngredientCostDDDGDirectSalaryFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGDirectSalaryFee)
                {
                    _mMProductionCostIngredientCostDDDGDirectSalaryFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGDirectSalaryFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGHardwareFee
        {
            get { return _mMProductionCostIngredientCostDDDGHardwareFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGHardwareFee)
                {
                    _mMProductionCostIngredientCostDDDGHardwareFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGHardwareFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGPaintFee
        {
            get { return _mMProductionCostIngredientCostDDDGPaintFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGPaintFee)
                {
                    _mMProductionCostIngredientCostDDDGPaintFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGPaintFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGMaintainFee
        {
            get { return _mMProductionCostIngredientCostDDDGMaintainFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGMaintainFee)
                {
                    _mMProductionCostIngredientCostDDDGMaintainFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGMaintainFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGElecFee
        {
            get { return _mMProductionCostIngredientCostDDDGElecFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGElecFee)
                {
                    _mMProductionCostIngredientCostDDDGElecFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGElecFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGDepreciationFee
        {
            get { return _mMProductionCostIngredientCostDDDGDepreciationFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGDepreciationFee)
                {
                    _mMProductionCostIngredientCostDDDGDepreciationFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGDepreciationFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGOtherFee
        {
            get { return _mMProductionCostIngredientCostDDDGOtherFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGOtherFee)
                {
                    _mMProductionCostIngredientCostDDDGOtherFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGOtherFee");
                }
            }
        }
        public int FK_ICReferenceID
        {
            get { return _fK_ICReferenceID; }
            set
            {
                if (value != this._fK_ICReferenceID)
                {
                    _fK_ICReferenceID = value;
                    NotifyChanged("FK_ICReferenceID");
                }
            }
        }
        public int FK_ICReferenceItemID
        {
            get { return _fK_ICReferenceItemID; }
            set
            {
                if (value != this._fK_ICReferenceItemID)
                {
                    _fK_ICReferenceItemID = value;
                    NotifyChanged("FK_ICReferenceItemID");
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
        public String MMProductionCostIngredientCostDDDGReferenceVoucherType
        {
            get { return _mMProductionCostIngredientCostDDDGReferenceVoucherType; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGReferenceVoucherType)
                {
                    _mMProductionCostIngredientCostDDDGReferenceVoucherType = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGReferenceVoucherType");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDDGReceiptQty
        {
            get { return _mMProductionCostIngredientCostDDDGReceiptQty; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGReceiptQty)
                {
                    _mMProductionCostIngredientCostDDDGReceiptQty = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGReceiptQty");
                }
            }
        }
        public int MMProductionCostIngredientCostDDDGIndex
        {
            get { return _mMProductionCostIngredientCostDDDGIndex; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDDGIndex)
                {
                    _mMProductionCostIngredientCostDDDGIndex = value;
                    NotifyChanged("MMProductionCostIngredientCostDDDGIndex");
                }
            }
        }
        #endregion

    }
    #endregion
}