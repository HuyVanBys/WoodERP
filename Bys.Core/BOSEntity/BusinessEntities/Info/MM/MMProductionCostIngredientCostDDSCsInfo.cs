﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostIngredientCostDDSCs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostIngredientCostDDSCsInfo
    //Created Date:Wednesday, August 03, 2016
    //-----------------------------------------------------------

    public class MMProductionCostIngredientCostDDSCsInfo : BusinessObject
    {
        public MMProductionCostIngredientCostDDSCsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostIngredientCostDDSCID;
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
        protected String _mMProductionCostIngredientCostDDSCReferenceNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCReferenceType = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCBatchProductNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCOperationName = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCMeasureUnitName = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCStockName = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCProductGroupName = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCProductNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCProductName = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCProductDesc = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCProductSerialNo = String.Empty;
        protected String _mMProductionCostIngredientCostDDSCProductAttribute = String.Empty;
        protected decimal _mMProductionCostIngredientCostDDSCProductUnitCost;
        protected decimal _mMProductionCostIngredientCostDDSCProductQty;
        protected decimal _mMProductionCostIngredientCostDDSCTotalCost;
        protected int _mMProductionCostIngredientCostDDSCBatchComponent;
        protected decimal _mMProductionCostIngredientCostDDSCProductWoodQty;
        protected decimal _mMProductionCostIngredientCostDDSCWoodFee;
        protected decimal _mMProductionCostIngredientCostDDSCGeneralFee;
        protected decimal _mMProductionCostIngredientCostDDSCDirectSalaryFee;
        protected decimal _mMProductionCostIngredientCostDDSCHardwareFee;
        protected decimal _mMProductionCostIngredientCostDDSCPaintFee;
        protected decimal _mMProductionCostIngredientCostDDSCMaintainFee;
        protected decimal _mMProductionCostIngredientCostDDSCElecFee;
        protected decimal _mMProductionCostIngredientCostDDSCDepreciationFee;
        protected decimal _mMProductionCostIngredientCostDDSCOtherFee;
        protected int _fK_ICReferenceID;
        protected int _fK_ICReferenceItemID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_ICProductSerieID;
        protected String _mMProductionCostIngredientCostDDSCReferenceVoucherType = String.Empty;
        protected decimal _mMProductionCostIngredientCostDDSCReceiptQty;
        protected int _mMProductionCostIngredientCostDDSCIndex;
        #endregion

        #region Public properties
        public int MMProductionCostIngredientCostDDSCID
        {
            get { return _mMProductionCostIngredientCostDDSCID; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCID)
                {
                    _mMProductionCostIngredientCostDDSCID = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCID");
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
        public String MMProductionCostIngredientCostDDSCReferenceNo
        {
            get { return _mMProductionCostIngredientCostDDSCReferenceNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCReferenceNo)
                {
                    _mMProductionCostIngredientCostDDSCReferenceNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCReferenceNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCReferenceType
        {
            get { return _mMProductionCostIngredientCostDDSCReferenceType; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCReferenceType)
                {
                    _mMProductionCostIngredientCostDDSCReferenceType = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCReferenceType");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCBatchProductNo
        {
            get { return _mMProductionCostIngredientCostDDSCBatchProductNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCBatchProductNo)
                {
                    _mMProductionCostIngredientCostDDSCBatchProductNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCBatchProductNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCOperationName
        {
            get { return _mMProductionCostIngredientCostDDSCOperationName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCOperationName)
                {
                    _mMProductionCostIngredientCostDDSCOperationName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCOperationName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCMeasureUnitName
        {
            get { return _mMProductionCostIngredientCostDDSCMeasureUnitName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCMeasureUnitName)
                {
                    _mMProductionCostIngredientCostDDSCMeasureUnitName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCMeasureUnitName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCStockName
        {
            get { return _mMProductionCostIngredientCostDDSCStockName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCStockName)
                {
                    _mMProductionCostIngredientCostDDSCStockName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCStockName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCProductGroupName
        {
            get { return _mMProductionCostIngredientCostDDSCProductGroupName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductGroupName)
                {
                    _mMProductionCostIngredientCostDDSCProductGroupName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductGroupName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCProductNo
        {
            get { return _mMProductionCostIngredientCostDDSCProductNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductNo)
                {
                    _mMProductionCostIngredientCostDDSCProductNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCProductName
        {
            get { return _mMProductionCostIngredientCostDDSCProductName; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductName)
                {
                    _mMProductionCostIngredientCostDDSCProductName = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductName");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCProductDesc
        {
            get { return _mMProductionCostIngredientCostDDSCProductDesc; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductDesc)
                {
                    _mMProductionCostIngredientCostDDSCProductDesc = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductDesc");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCProductSerialNo
        {
            get { return _mMProductionCostIngredientCostDDSCProductSerialNo; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductSerialNo)
                {
                    _mMProductionCostIngredientCostDDSCProductSerialNo = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductSerialNo");
                }
            }
        }
        public String MMProductionCostIngredientCostDDSCProductAttribute
        {
            get { return _mMProductionCostIngredientCostDDSCProductAttribute; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductAttribute)
                {
                    _mMProductionCostIngredientCostDDSCProductAttribute = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductAttribute");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCProductUnitCost
        {
            get { return _mMProductionCostIngredientCostDDSCProductUnitCost; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductUnitCost)
                {
                    _mMProductionCostIngredientCostDDSCProductUnitCost = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductUnitCost");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCProductQty
        {
            get { return _mMProductionCostIngredientCostDDSCProductQty; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductQty)
                {
                    _mMProductionCostIngredientCostDDSCProductQty = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductQty");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCTotalCost
        {
            get { return _mMProductionCostIngredientCostDDSCTotalCost; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCTotalCost)
                {
                    _mMProductionCostIngredientCostDDSCTotalCost = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCTotalCost");
                }
            }
        }
        public int MMProductionCostIngredientCostDDSCBatchComponent
        {
            get { return _mMProductionCostIngredientCostDDSCBatchComponent; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCBatchComponent)
                {
                    _mMProductionCostIngredientCostDDSCBatchComponent = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCBatchComponent");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCProductWoodQty
        {
            get { return _mMProductionCostIngredientCostDDSCProductWoodQty; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCProductWoodQty)
                {
                    _mMProductionCostIngredientCostDDSCProductWoodQty = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCProductWoodQty");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCWoodFee
        {
            get { return _mMProductionCostIngredientCostDDSCWoodFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCWoodFee)
                {
                    _mMProductionCostIngredientCostDDSCWoodFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCWoodFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCGeneralFee
        {
            get { return _mMProductionCostIngredientCostDDSCGeneralFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCGeneralFee)
                {
                    _mMProductionCostIngredientCostDDSCGeneralFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCGeneralFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCDirectSalaryFee
        {
            get { return _mMProductionCostIngredientCostDDSCDirectSalaryFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCDirectSalaryFee)
                {
                    _mMProductionCostIngredientCostDDSCDirectSalaryFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCDirectSalaryFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCHardwareFee
        {
            get { return _mMProductionCostIngredientCostDDSCHardwareFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCHardwareFee)
                {
                    _mMProductionCostIngredientCostDDSCHardwareFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCHardwareFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCPaintFee
        {
            get { return _mMProductionCostIngredientCostDDSCPaintFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCPaintFee)
                {
                    _mMProductionCostIngredientCostDDSCPaintFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCPaintFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCMaintainFee
        {
            get { return _mMProductionCostIngredientCostDDSCMaintainFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCMaintainFee)
                {
                    _mMProductionCostIngredientCostDDSCMaintainFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCMaintainFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCElecFee
        {
            get { return _mMProductionCostIngredientCostDDSCElecFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCElecFee)
                {
                    _mMProductionCostIngredientCostDDSCElecFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCElecFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCDepreciationFee
        {
            get { return _mMProductionCostIngredientCostDDSCDepreciationFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCDepreciationFee)
                {
                    _mMProductionCostIngredientCostDDSCDepreciationFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCDepreciationFee");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCOtherFee
        {
            get { return _mMProductionCostIngredientCostDDSCOtherFee; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCOtherFee)
                {
                    _mMProductionCostIngredientCostDDSCOtherFee = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCOtherFee");
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
        public String MMProductionCostIngredientCostDDSCReferenceVoucherType
        {
            get { return _mMProductionCostIngredientCostDDSCReferenceVoucherType; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCReferenceVoucherType)
                {
                    _mMProductionCostIngredientCostDDSCReferenceVoucherType = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCReferenceVoucherType");
                }
            }
        }
        public decimal MMProductionCostIngredientCostDDSCReceiptQty
        {
            get { return _mMProductionCostIngredientCostDDSCReceiptQty; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCReceiptQty)
                {
                    _mMProductionCostIngredientCostDDSCReceiptQty = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCReceiptQty");
                }
            }
        }
        public int MMProductionCostIngredientCostDDSCIndex
        {
            get { return _mMProductionCostIngredientCostDDSCIndex; }
            set
            {
                if (value != this._mMProductionCostIngredientCostDDSCIndex)
                {
                    _mMProductionCostIngredientCostDDSCIndex = value;
                    NotifyChanged("MMProductionCostIngredientCostDDSCIndex");
                }
            }
        }
        #endregion

    }
    #endregion
}