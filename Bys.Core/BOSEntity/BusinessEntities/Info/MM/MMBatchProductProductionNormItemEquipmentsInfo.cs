﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductProductionNormItemEquipments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductProductionNormItemEquipmentsInfo
    //Created Date:Tuesday, July 31, 2018
    //-----------------------------------------------------------

    public class MMBatchProductProductionNormItemEquipmentsInfo : BusinessObject
    {
        public MMBatchProductProductionNormItemEquipmentsInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductProductionNormItemEquipmentID;
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
        protected String _mMBatchProductProductionNormItemEquipmentProductName = String.Empty;
        protected String _mMBatchProductProductionNormItemEquipmentProductDesc = String.Empty;
        protected String _mMBatchProductProductionNormItemEquipmentDesc = String.Empty;
        protected decimal _mMBatchProductProductionNormItemEquipmentQty;
        #endregion

        #region Public properties
        public int MMBatchProductProductionNormItemEquipmentID
        {
            get { return _mMBatchProductProductionNormItemEquipmentID; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemEquipmentID)
                {
                    _mMBatchProductProductionNormItemEquipmentID = value;
                    NotifyChanged("MMBatchProductProductionNormItemEquipmentID");
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
        public String MMBatchProductProductionNormItemEquipmentProductName
        {
            get { return _mMBatchProductProductionNormItemEquipmentProductName; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemEquipmentProductName)
                {
                    _mMBatchProductProductionNormItemEquipmentProductName = value;
                    NotifyChanged("MMBatchProductProductionNormItemEquipmentProductName");
                }
            }
        }
        public String MMBatchProductProductionNormItemEquipmentProductDesc
        {
            get { return _mMBatchProductProductionNormItemEquipmentProductDesc; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemEquipmentProductDesc)
                {
                    _mMBatchProductProductionNormItemEquipmentProductDesc = value;
                    NotifyChanged("MMBatchProductProductionNormItemEquipmentProductDesc");
                }
            }
        }
        public String MMBatchProductProductionNormItemEquipmentDesc
        {
            get { return _mMBatchProductProductionNormItemEquipmentDesc; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemEquipmentDesc)
                {
                    _mMBatchProductProductionNormItemEquipmentDesc = value;
                    NotifyChanged("MMBatchProductProductionNormItemEquipmentDesc");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemEquipmentQty
        {
            get { return _mMBatchProductProductionNormItemEquipmentQty; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemEquipmentQty)
                {
                    _mMBatchProductProductionNormItemEquipmentQty = value;
                    NotifyChanged("MMBatchProductProductionNormItemEquipmentQty");
                }
            }
        }
        #endregion
    }
    #endregion
}