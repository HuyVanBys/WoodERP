﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostItemsInfo
    //Created Date:Tuesday, December 01, 2015
    //-----------------------------------------------------------

    public class MMProductionCostItemsInfo : BusinessObject
    {
        public MMProductionCostItemsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_MMProductionCostID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMOperationID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICDepartmentID;
        protected int _fK_MMProductionNormID;
        protected int _fK_ICProductIDForBatch;
        protected int _fK_ARSaleOrderID;
        protected int _fK_MMProposalID;
        protected String _mMProductionCostItemProductDesc = String.Empty;
        protected int _mMProductionCostItemBatchComponent;
        protected decimal _mMProductionCostItemProductQty;
        protected decimal _mMProductionCostItemCompletedProductQty;
        protected int _fK_ARSaleOrderItemID;
        #endregion

        #region Public properties
        public int MMProductionCostItemID
        {
            get { return _mMProductionCostItemID; }
            set
            {
                if (value != this._mMProductionCostItemID)
                {
                    _mMProductionCostItemID = value;
                    NotifyChanged("MMProductionCostItemID");
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
        public String MMProductionCostItemProductDesc
        {
            get { return _mMProductionCostItemProductDesc; }
            set
            {
                if (value != this._mMProductionCostItemProductDesc)
                {
                    _mMProductionCostItemProductDesc = value;
                    NotifyChanged("MMProductionCostItemProductDesc");
                }
            }
        }
        public int MMProductionCostItemBatchComponent
        {
            get { return _mMProductionCostItemBatchComponent; }
            set
            {
                if (value != this._mMProductionCostItemBatchComponent)
                {
                    _mMProductionCostItemBatchComponent = value;
                    NotifyChanged("MMProductionCostItemBatchComponent");
                }
            }
        }
        public decimal MMProductionCostItemProductQty
        {
            get { return _mMProductionCostItemProductQty; }
            set
            {
                if (value != this._mMProductionCostItemProductQty)
                {
                    _mMProductionCostItemProductQty = value;
                    NotifyChanged("MMProductionCostItemProductQty");
                }
            }
        }
        public decimal MMProductionCostItemCompletedProductQty
        {
            get { return _mMProductionCostItemCompletedProductQty; }
            set
            {
                if (value != this._mMProductionCostItemCompletedProductQty)
                {
                    _mMProductionCostItemCompletedProductQty = value;
                    NotifyChanged("MMProductionCostItemCompletedProductQty");
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

        #region Extra Properties
        public string MMProductionCostItemProductSeriesNo { get; set; }
        public string MMBatchProductNo { get; set; }
        public string ICProductNo { get; set; }
        #endregion
    }
    #endregion
}