﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostDirectLaborCosts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostDirectLaborCostsInfo
    //Created Date:Tuesday, December 01, 2015
    //-----------------------------------------------------------

    public class MMProductionCostDirectLaborCostsInfo : BusinessObject
    {
        public MMProductionCostDirectLaborCostsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostDirectLaborCostID;
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
        protected int _fK_MMProductionNormID;
        protected int _fK_ICProductIDForBatch;
        protected int _fK_ARSaleOrderID;
        protected int _fK_MMProposalID;
        protected int _fK_HREmployeeID;
        protected String _mMProductionCostDirectLaborCostReferenceNo = String.Empty;
        protected String _mMProductionCostDirectLaborCostReferenceType = String.Empty;
        protected String _mMProductionCostDirectLaborCostProductNo = String.Empty;
        protected String _mMProductionCostDirectLaborCostProductName = String.Empty;
        protected String _mMProductionCostDirectLaborCostProductDesc = String.Empty;
        protected String _mMProductionCostDirectLaborCostProductSerialNo = String.Empty;
        protected String _mMProductionCostDirectLaborCostProductAttribute = String.Empty;
        protected decimal _mMProductionCostDirectLaborCostProductUnitCost;
        protected decimal _mMProductionCostDirectLaborCostProductQty;
        protected decimal _mMProductionCostDirectLaborCostTotalCost;
        protected int _mMProductionCostDirectLaborCostBatchComponent;
        protected int _fK_ARSaleOrderItemID;
        #endregion

        #region Public properties
        public int MMProductionCostDirectLaborCostID
        {
            get { return _mMProductionCostDirectLaborCostID; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostID)
                {
                    _mMProductionCostDirectLaborCostID = value;
                    NotifyChanged("MMProductionCostDirectLaborCostID");
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
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public String MMProductionCostDirectLaborCostReferenceNo
        {
            get { return _mMProductionCostDirectLaborCostReferenceNo; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostReferenceNo)
                {
                    _mMProductionCostDirectLaborCostReferenceNo = value;
                    NotifyChanged("MMProductionCostDirectLaborCostReferenceNo");
                }
            }
        }
        public String MMProductionCostDirectLaborCostReferenceType
        {
            get { return _mMProductionCostDirectLaborCostReferenceType; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostReferenceType)
                {
                    _mMProductionCostDirectLaborCostReferenceType = value;
                    NotifyChanged("MMProductionCostDirectLaborCostReferenceType");
                }
            }
        }
        public String MMProductionCostDirectLaborCostProductNo
        {
            get { return _mMProductionCostDirectLaborCostProductNo; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductNo)
                {
                    _mMProductionCostDirectLaborCostProductNo = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductNo");
                }
            }
        }
        public String MMProductionCostDirectLaborCostProductName
        {
            get { return _mMProductionCostDirectLaborCostProductName; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductName)
                {
                    _mMProductionCostDirectLaborCostProductName = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductName");
                }
            }
        }
        public String MMProductionCostDirectLaborCostProductDesc
        {
            get { return _mMProductionCostDirectLaborCostProductDesc; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductDesc)
                {
                    _mMProductionCostDirectLaborCostProductDesc = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductDesc");
                }
            }
        }
        public String MMProductionCostDirectLaborCostProductSerialNo
        {
            get { return _mMProductionCostDirectLaborCostProductSerialNo; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductSerialNo)
                {
                    _mMProductionCostDirectLaborCostProductSerialNo = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductSerialNo");
                }
            }
        }
        public String MMProductionCostDirectLaborCostProductAttribute
        {
            get { return _mMProductionCostDirectLaborCostProductAttribute; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductAttribute)
                {
                    _mMProductionCostDirectLaborCostProductAttribute = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductAttribute");
                }
            }
        }
        public decimal MMProductionCostDirectLaborCostProductUnitCost
        {
            get { return _mMProductionCostDirectLaborCostProductUnitCost; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductUnitCost)
                {
                    _mMProductionCostDirectLaborCostProductUnitCost = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductUnitCost");
                }
            }
        }
        public decimal MMProductionCostDirectLaborCostProductQty
        {
            get { return _mMProductionCostDirectLaborCostProductQty; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostProductQty)
                {
                    _mMProductionCostDirectLaborCostProductQty = value;
                    NotifyChanged("MMProductionCostDirectLaborCostProductQty");
                }
            }
        }
        public decimal MMProductionCostDirectLaborCostTotalCost
        {
            get { return _mMProductionCostDirectLaborCostTotalCost; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostTotalCost)
                {
                    _mMProductionCostDirectLaborCostTotalCost = value;
                    NotifyChanged("MMProductionCostDirectLaborCostTotalCost");
                }
            }
        }
        public int MMProductionCostDirectLaborCostBatchComponent
        {
            get { return _mMProductionCostDirectLaborCostBatchComponent; }
            set
            {
                if (value != this._mMProductionCostDirectLaborCostBatchComponent)
                {
                    _mMProductionCostDirectLaborCostBatchComponent = value;
                    NotifyChanged("MMProductionCostDirectLaborCostBatchComponent");
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
        #endregion
    }
    #endregion
}