﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductProductionNormItemPaints
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductProductionNormItemPaintsInfo
    //Created Date:Thursday, May 24, 2018
    //-----------------------------------------------------------

    public class MMBatchProductProductionNormItemPaintsInfo : BusinessObject
    {
        public MMBatchProductProductionNormItemPaintsInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductProductionNormItemPaintID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductAttributeID;
        protected int _fK_MMProductionNormItemID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected decimal _mMBatchProductProductionNormItemPaintQty;
        protected String _mMBatchProductProductionNormItemPaintDesc = String.Empty;
        #endregion

        #region Public properties
        public int MMBatchProductProductionNormItemPaintID
        {
            get { return _mMBatchProductProductionNormItemPaintID; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemPaintID)
                {
                    _mMBatchProductProductionNormItemPaintID = value;
                    NotifyChanged("MMBatchProductProductionNormItemPaintID");
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
        public int FK_ICProductAttributeID
        {
            get { return _fK_ICProductAttributeID; }
            set
            {
                if (value != this._fK_ICProductAttributeID)
                {
                    _fK_ICProductAttributeID = value;
                    NotifyChanged("FK_ICProductAttributeID");
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
        public decimal MMBatchProductProductionNormItemPaintQty
        {
            get { return _mMBatchProductProductionNormItemPaintQty; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemPaintQty)
                {
                    _mMBatchProductProductionNormItemPaintQty = value;
                    NotifyChanged("MMBatchProductProductionNormItemPaintQty");
                }
            }
        }
        public String MMBatchProductProductionNormItemPaintDesc
        {
            get { return _mMBatchProductProductionNormItemPaintDesc; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemPaintDesc)
                {
                    _mMBatchProductProductionNormItemPaintDesc = value;
                    NotifyChanged("MMBatchProductProductionNormItemPaintDesc");
                }
            }
        }
        #endregion

        public string ICProductAttributeNo { get; set; }
        public string ICMeasureUnitName { get; set; }
        public decimal MMBatchProductProductionNormItemPaintTotalQty { get; set; }
    }
    #endregion
}