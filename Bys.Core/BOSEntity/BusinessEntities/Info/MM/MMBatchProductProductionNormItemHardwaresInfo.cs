﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductProductionNormItemHardwares
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductProductionNormItemHardwaresInfo
    //Created Date:Thursday, May 24, 2018
    //-----------------------------------------------------------

    public class MMBatchProductProductionNormItemHardwaresInfo : BusinessObject
    {
        public MMBatchProductProductionNormItemHardwaresInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductProductionNormItemHardwareID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductAlternativeID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_MMOperationID;
        protected int _fK_MMProductionNormItemID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected String _mMBatchProductProductionNormItemHardwareProductName = String.Empty;
        protected String _mMBatchProductProductionNormItemHardwareProductDesc = String.Empty;
        protected String _mMBatchProductProductionNormItemHardwareDesc = String.Empty;
        protected decimal _mMBatchProductProductionNormItemHardwareQty;
        #endregion

        #region Public properties
        public int MMBatchProductProductionNormItemHardwareID
        {
            get { return _mMBatchProductProductionNormItemHardwareID; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemHardwareID)
                {
                    _mMBatchProductProductionNormItemHardwareID = value;
                    NotifyChanged("MMBatchProductProductionNormItemHardwareID");
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
        public int FK_ICProductAlternativeID
        {
            get { return _fK_ICProductAlternativeID; }
            set
            {
                if (value != this._fK_ICProductAlternativeID)
                {
                    _fK_ICProductAlternativeID = value;
                    NotifyChanged("FK_ICProductAlternativeID");
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
        public int FK_MMProductionNormItemID
        {
            get { return _fK_MMProductionNormItemID; }
            set
            {
                if (value != this._fK_MMProductionNormItemID)
                {
                    _fK_MMProductionNormItemID = value;
                    NotifyChanged("FK_MMProductionNormItemID");
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
        public String MMBatchProductProductionNormItemHardwareProductName
        {
            get { return _mMBatchProductProductionNormItemHardwareProductName; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemHardwareProductName)
                {
                    _mMBatchProductProductionNormItemHardwareProductName = value;
                    NotifyChanged("MMBatchProductProductionNormItemHardwareProductName");
                }
            }
        }
        public String MMBatchProductProductionNormItemHardwareProductDesc
        {
            get { return _mMBatchProductProductionNormItemHardwareProductDesc; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemHardwareProductDesc)
                {
                    _mMBatchProductProductionNormItemHardwareProductDesc = value;
                    NotifyChanged("MMBatchProductProductionNormItemHardwareProductDesc");
                }
            }
        }
        public String MMBatchProductProductionNormItemHardwareDesc
        {
            get { return _mMBatchProductProductionNormItemHardwareDesc; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemHardwareDesc)
                {
                    _mMBatchProductProductionNormItemHardwareDesc = value;
                    NotifyChanged("MMBatchProductProductionNormItemHardwareDesc");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemHardwareQty
        {
            get { return _mMBatchProductProductionNormItemHardwareQty; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemHardwareQty)
                {
                    _mMBatchProductProductionNormItemHardwareQty = value;
                    NotifyChanged("MMBatchProductProductionNormItemHardwareQty");
                }
            }
        }
        #endregion
    }
    #endregion
}