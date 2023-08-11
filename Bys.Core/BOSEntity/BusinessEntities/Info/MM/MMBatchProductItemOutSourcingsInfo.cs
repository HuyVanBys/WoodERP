﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductItemOutSourcings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductItemOutSourcingsInfo
    //Created Date:Wednesday, December 4, 2019
    //-----------------------------------------------------------

    public class MMBatchProductItemOutSourcingsInfo : BusinessObject
    {
        public MMBatchProductItemOutSourcingsInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductItemOutSourcingID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_ICProductID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected String _mMBatchProductItemOutSourcingProductNo = String.Empty;
        protected String _mMBatchProductItemOutSourcingProductName = String.Empty;
        protected String _mMBatchProductItemOutSourcingProductDesc = String.Empty;
        protected decimal _mMBatchProductItemOutSourcingProductQty;
        protected String _mMBatchProductItemOutSourcingOperation = String.Empty;
        protected String _mMBatchProductItemOutSourcingGroup = String.Empty;
        protected DateTime _mMBatchProductItemOutSourcingNeedDate = DateTime.MaxValue;
        protected String _mMBatchProductItemOutSourcingStatus = DefaultStatus;
        protected String _mMBatchProductItemOutSourcingResourceType = String.Empty;

        #endregion

        #region Public properties
        public int MMBatchProductItemOutSourcingID
        {
            get { return _mMBatchProductItemOutSourcingID; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingID)
                {
                    _mMBatchProductItemOutSourcingID = value;
                    NotifyChanged("MMBatchProductItemOutSourcingID");
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
        public String MMBatchProductItemOutSourcingProductNo
        {
            get { return _mMBatchProductItemOutSourcingProductNo; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingProductNo)
                {
                    _mMBatchProductItemOutSourcingProductNo = value;
                    NotifyChanged("MMBatchProductItemOutSourcingProductNo");
                }
            }
        }
        public String MMBatchProductItemOutSourcingProductName
        {
            get { return _mMBatchProductItemOutSourcingProductName; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingProductName)
                {
                    _mMBatchProductItemOutSourcingProductName = value;
                    NotifyChanged("MMBatchProductItemOutSourcingProductName");
                }
            }
        }
        public String MMBatchProductItemOutSourcingProductDesc
        {
            get { return _mMBatchProductItemOutSourcingProductDesc; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingProductDesc)
                {
                    _mMBatchProductItemOutSourcingProductDesc = value;
                    NotifyChanged("MMBatchProductItemOutSourcingProductDesc");
                }
            }
        }
        public decimal MMBatchProductItemOutSourcingProductQty
        {
            get { return _mMBatchProductItemOutSourcingProductQty; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingProductQty)
                {
                    _mMBatchProductItemOutSourcingProductQty = value;
                    NotifyChanged("MMBatchProductItemOutSourcingProductQty");
                }
            }
        }
        public String MMBatchProductItemOutSourcingOperation
        {
            get { return _mMBatchProductItemOutSourcingOperation; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingOperation)
                {
                    _mMBatchProductItemOutSourcingOperation = value;
                    NotifyChanged("MMBatchProductItemOutSourcingOperation");
                }
            }
        }
        public String MMBatchProductItemOutSourcingGroup
        {
            get { return _mMBatchProductItemOutSourcingGroup; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingGroup)
                {
                    _mMBatchProductItemOutSourcingGroup = value;
                    NotifyChanged("MMBatchProductItemOutSourcingGroup");
                }
            }
        }
        public DateTime MMBatchProductItemOutSourcingNeedDate
        {
            get { return _mMBatchProductItemOutSourcingNeedDate; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingNeedDate)
                {
                    _mMBatchProductItemOutSourcingNeedDate = value;
                    NotifyChanged("MMBatchProductItemOutSourcingNeedDate");
                }
            }
        }
        public String MMBatchProductItemOutSourcingStatus
        {
            get { return _mMBatchProductItemOutSourcingStatus; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingStatus)
                {
                    _mMBatchProductItemOutSourcingStatus = value;
                    NotifyChanged("MMBatchProductItemOutSourcingStatus");
                }
            }
        }
        public String MMBatchProductItemOutSourcingResourceType
        {
            get { return _mMBatchProductItemOutSourcingResourceType; }
            set
            {
                if (value != this._mMBatchProductItemOutSourcingResourceType)
                {
                    _mMBatchProductItemOutSourcingResourceType = value;
                    NotifyChanged("MMBatchProductItemOutSourcingResourceType");
                }
            }
        }

        #endregion

        public int FK_ICMeasureUnitID { get; set; }
        public int FK_ICProductForBatchID { get; set; }
        public int FK_ARSaleOrderID { get; set; }
        public decimal MMBatchProductItemOutSourcingProductHeight { get; set; }
        public decimal MMBatchProductItemOutSourcingProductWidth { get; set; }
        public decimal MMBatchProductItemOutSourcingProductLength { get; set; }
        public decimal APProposalItemProductExchangeQty { get; set; }
        public string APProposalItemOperation { get; set; }
        public decimal MMBatchProductItemOutSourcingRemainQty { get; set; }
        public decimal ICInventoryStockQty { get; set; }
        public int FK_MMOperationID { get; set; }
        public Guid VirtualId { get; set; }
        public string MMBatchProductSOName { get; set; }
        public string ICProductName2 { get; set; }
        public string ICProductNoOfOldSys { get; set; }
    }
    #endregion
}