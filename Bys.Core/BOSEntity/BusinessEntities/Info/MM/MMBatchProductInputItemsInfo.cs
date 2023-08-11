﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductInputItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductInputItemsInfo
    //Created Date:Thursday, January 10, 2019
    //-----------------------------------------------------------

    public class MMBatchProductInputItemsInfo : BusinessObject
    {
        public MMBatchProductInputItemsInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductInputItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_MMBatchProductID;
        protected int _fK_ICProductAttributeTTMTID;
        protected int _fK_ICStockID;
        protected int _fK_ICProductSerieID;
        protected int _fK_GECountryID;
        protected int _fK_ICProductAttributeQualityID;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected String _mMBatchProductInputItemProductName = String.Empty;
        protected String _mMBatchProductInputItemProductDesc = String.Empty;
        protected decimal _mMBatchProductInputItemHeight;
        protected decimal _mMBatchProductInputItemWidth;
        protected decimal _mMBatchProductInputItemLength;
        protected decimal _mMBatchProductInputItemHeightMin;
        protected decimal _mMBatchProductInputItemWidthMin;
        protected decimal _mMBatchProductInputItemLengthMin;
        protected decimal _mMBatchProductInputItemHeightMax;
        protected decimal _mMBatchProductInputItemWidthMax;
        protected decimal _mMBatchProductInputItemLengthMax;
        protected decimal _mMBatchProductInputItemQty;
        protected decimal _mMBatchProductInputItemWoodQty;
        protected String _mMBatchProductInputItemComment = String.Empty;
        protected decimal _mMBatchProductInputItemProductPerimeter;
        protected decimal _mMBatchProductInputItemCanceledQty;
        protected String _mMBatchProductInputItemProductSerialNo = String.Empty;
        protected String _mMBatchProductInputItemLotNo = String.Empty;

        #endregion

        #region Public properties
        public int MMBatchProductInputItemID
        {
            get { return _mMBatchProductInputItemID; }
            set
            {
                if (value != this._mMBatchProductInputItemID)
                {
                    _mMBatchProductInputItemID = value;
                    NotifyChanged("MMBatchProductInputItemID");
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
        public int FK_ICProductAttributeTTMTID
        {
            get { return _fK_ICProductAttributeTTMTID; }
            set
            {
                if (value != this._fK_ICProductAttributeTTMTID)
                {
                    _fK_ICProductAttributeTTMTID = value;
                    NotifyChanged("FK_ICProductAttributeTTMTID");
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
        public int FK_GECountryID
        {
            get { return _fK_GECountryID; }
            set
            {
                if (value != this._fK_GECountryID)
                {
                    _fK_GECountryID = value;
                    NotifyChanged("FK_GECountryID");
                }
            }
        }
        public int FK_ICProductAttributeQualityID
        {
            get { return _fK_ICProductAttributeQualityID; }
            set
            {
                if (value != this._fK_ICProductAttributeQualityID)
                {
                    _fK_ICProductAttributeQualityID = value;
                    NotifyChanged("FK_ICProductAttributeQualityID");
                }
            }
        }
        public int FK_ICProductAttributeWoodTypeID
        {
            get { return _fK_ICProductAttributeWoodTypeID; }
            set
            {
                if (value != this._fK_ICProductAttributeWoodTypeID)
                {
                    _fK_ICProductAttributeWoodTypeID = value;
                    NotifyChanged("FK_ICProductAttributeWoodTypeID");
                }
            }
        }
        public String MMBatchProductInputItemProductName
        {
            get { return _mMBatchProductInputItemProductName; }
            set
            {
                if (value != this._mMBatchProductInputItemProductName)
                {
                    _mMBatchProductInputItemProductName = value;
                    NotifyChanged("MMBatchProductInputItemProductName");
                }
            }
        }
        public String MMBatchProductInputItemProductDesc
        {
            get { return _mMBatchProductInputItemProductDesc; }
            set
            {
                if (value != this._mMBatchProductInputItemProductDesc)
                {
                    _mMBatchProductInputItemProductDesc = value;
                    NotifyChanged("MMBatchProductInputItemProductDesc");
                }
            }
        }
        public decimal MMBatchProductInputItemHeight
        {
            get { return _mMBatchProductInputItemHeight; }
            set
            {
                if (value != this._mMBatchProductInputItemHeight)
                {
                    _mMBatchProductInputItemHeight = value;
                    NotifyChanged("MMBatchProductInputItemHeight");
                }
            }
        }
        public decimal MMBatchProductInputItemWidth
        {
            get { return _mMBatchProductInputItemWidth; }
            set
            {
                if (value != this._mMBatchProductInputItemWidth)
                {
                    _mMBatchProductInputItemWidth = value;
                    NotifyChanged("MMBatchProductInputItemWidth");
                }
            }
        }
        public decimal MMBatchProductInputItemLength
        {
            get { return _mMBatchProductInputItemLength; }
            set
            {
                if (value != this._mMBatchProductInputItemLength)
                {
                    _mMBatchProductInputItemLength = value;
                    NotifyChanged("MMBatchProductInputItemLength");
                }
            }
        }
        public decimal MMBatchProductInputItemHeightMin
        {
            get { return _mMBatchProductInputItemHeightMin; }
            set
            {
                if (value != this._mMBatchProductInputItemHeightMin)
                {
                    _mMBatchProductInputItemHeightMin = value;
                    NotifyChanged("MMBatchProductInputItemHeightMin");
                }
            }
        }
        public decimal MMBatchProductInputItemWidthMin
        {
            get { return _mMBatchProductInputItemWidthMin; }
            set
            {
                if (value != this._mMBatchProductInputItemWidthMin)
                {
                    _mMBatchProductInputItemWidthMin = value;
                    NotifyChanged("MMBatchProductInputItemWidthMin");
                }
            }
        }
        public decimal MMBatchProductInputItemLengthMin
        {
            get { return _mMBatchProductInputItemLengthMin; }
            set
            {
                if (value != this._mMBatchProductInputItemLengthMin)
                {
                    _mMBatchProductInputItemLengthMin = value;
                    NotifyChanged("MMBatchProductInputItemLengthMin");
                }
            }
        }
        public decimal MMBatchProductInputItemHeightMax
        {
            get { return _mMBatchProductInputItemHeightMax; }
            set
            {
                if (value != this._mMBatchProductInputItemHeightMax)
                {
                    _mMBatchProductInputItemHeightMax = value;
                    NotifyChanged("MMBatchProductInputItemHeightMax");
                }
            }
        }
        public decimal MMBatchProductInputItemWidthMax
        {
            get { return _mMBatchProductInputItemWidthMax; }
            set
            {
                if (value != this._mMBatchProductInputItemWidthMax)
                {
                    _mMBatchProductInputItemWidthMax = value;
                    NotifyChanged("MMBatchProductInputItemWidthMax");
                }
            }
        }
        public decimal MMBatchProductInputItemLengthMax
        {
            get { return _mMBatchProductInputItemLengthMax; }
            set
            {
                if (value != this._mMBatchProductInputItemLengthMax)
                {
                    _mMBatchProductInputItemLengthMax = value;
                    NotifyChanged("MMBatchProductInputItemLengthMax");
                }
            }
        }
        public decimal MMBatchProductInputItemQty
        {
            get { return _mMBatchProductInputItemQty; }
            set
            {
                if (value != this._mMBatchProductInputItemQty)
                {
                    _mMBatchProductInputItemQty = value;
                    NotifyChanged("MMBatchProductInputItemQty");
                }
            }
        }
        public decimal MMBatchProductInputItemWoodQty
        {
            get { return _mMBatchProductInputItemWoodQty; }
            set
            {
                if (value != this._mMBatchProductInputItemWoodQty)
                {
                    _mMBatchProductInputItemWoodQty = value;
                    NotifyChanged("MMBatchProductInputItemWoodQty");
                }
            }
        }
        public String MMBatchProductInputItemComment
        {
            get { return _mMBatchProductInputItemComment; }
            set
            {
                if (value != this._mMBatchProductInputItemComment)
                {
                    _mMBatchProductInputItemComment = value;
                    NotifyChanged("MMBatchProductInputItemComment");
                }
            }
        }
        public decimal MMBatchProductInputItemProductPerimeter
        {
            get { return _mMBatchProductInputItemProductPerimeter; }
            set
            {
                if (value != this._mMBatchProductInputItemProductPerimeter)
                {
                    _mMBatchProductInputItemProductPerimeter = value;
                    NotifyChanged("MMBatchProductInputItemProductPerimeter");
                }
            }
        }
        public decimal MMBatchProductInputItemCanceledQty
        {
            get { return _mMBatchProductInputItemCanceledQty; }
            set
            {
                if (value != this._mMBatchProductInputItemCanceledQty)
                {
                    _mMBatchProductInputItemCanceledQty = value;
                    NotifyChanged("MMBatchProductInputItemCanceledQty");
                }
            }
        }
        public String MMBatchProductInputItemProductSerialNo
        {
            get { return _mMBatchProductInputItemProductSerialNo; }
            set
            {
                if (value != this._mMBatchProductInputItemProductSerialNo)
                {
                    _mMBatchProductInputItemProductSerialNo = value;
                    NotifyChanged("MMBatchProductInputItemProductSerialNo");
                }
            }
        }
        public String MMBatchProductInputItemLotNo
        {
            get { return _mMBatchProductInputItemLotNo; }
            set
            {
                if (value != this._mMBatchProductInputItemLotNo)
                {
                    _mMBatchProductInputItemLotNo = value;
                    NotifyChanged("MMBatchProductInputItemLotNo");
                }
            }
        }
        #endregion

        #region Extra Properties
        public string MMBatchProductNo { get; set; }
        public decimal RemainQty { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_MMOperationID { get; set; }
        public int APPurchaseOrderID { get; set; }
        public string APPurchaseOrderNo { get; set; }
        public int FK_APSupplierID { get; set; }
        public string ICProductType { get; set; }
        public string MMOperationNo { get; set; }

        #endregion
    }
    #endregion
}