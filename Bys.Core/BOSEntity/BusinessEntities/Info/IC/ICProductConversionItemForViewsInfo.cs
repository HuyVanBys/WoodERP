﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductConversionItemForViewsInfo
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductConversionItemForViewsInfo
    //Created Date:Monday, May 27, 2019
    //-----------------------------------------------------------

    public class ICProductConversionItemForViewsInfo : ERPModuleItemsEntity
    {
        public ICProductConversionItemForViewsInfo()
        {
            ICProductConversionItemProductFactor = 1;
        }
        #region Variables
        protected int _iCProductConversionItemID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductConversionID;
        protected int _fK_ICProductID;
        protected int _fK_ICFromProductID;
        protected String _iCProductConversionItemProductName = String.Empty;
        protected String _iCProductConversionItemProductDesc = String.Empty;
        protected decimal _iCProductConversionItemProductQty;
        protected decimal _iCProductConversionItemRate;
        protected String _iCProductConversionItemType = String.Empty;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICStockID;
        protected int _fK_ICProductSerieID;
        protected String _iCProductConversionItemProductSerialNo = String.Empty;
        protected decimal _iCProductConversionItemProductFactor;
        protected decimal _iCProductConversionItemProductExchangeQty;
        protected decimal _iCProductConversionItemUnitCost;
        protected decimal _iCProductConversionItemTotalCost;
        protected bool _iCProductConversionItemIsAverageCalculation = false;
        protected bool _iCProductConversionItemIsSpecificCalculation = false;
        protected int _fK_ACAccountID;
        protected decimal _iCProductConversionItemProductUnitPrice;
        protected String _iCProductConversionItemConfigType = String.Empty;
        protected decimal _iCProductConversionItemConfigValue;
        protected decimal _iCProductConversionItemCost;
        protected int _iCProductConversionItemParentID;
        protected decimal _iCProductConversionItemWoodQty;
        protected decimal _iCProductConversionItemLengthMin;
        protected decimal _iCProductConversionItemWidthMin;
        protected decimal _iCProductConversionItemHeightMin;
        protected decimal _iCProductConversionItemLengthMax;
        protected decimal _iCProductConversionItemWidthMax;
        protected decimal _iCProductConversionItemHeightMax;
        protected decimal _iCProductConversionItemPerimeter;
        protected String _iCProductConversionItemLotNo = String.Empty;
        protected decimal _iCProductConversionItemProductLength;
        protected decimal _iCProductConversionItemProductWidth;
        protected decimal _iCProductConversionItemProductHeight;
        protected int _fK_ICProductAttributeQualityID;

        #endregion

        #region Public properties
        public int ICProductConversionItemID
        {
            get { return _iCProductConversionItemID; }
            set
            {
                if (value != this._iCProductConversionItemID)
                {
                    _iCProductConversionItemID = value;
                    NotifyChanged("ICProductConversionItemID");
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
        public int FK_ICProductConversionID
        {
            get { return _fK_ICProductConversionID; }
            set
            {
                if (value != this._fK_ICProductConversionID)
                {
                    _fK_ICProductConversionID = value;
                    NotifyChanged("FK_ICProductConversionID");
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
        public int FK_ICFromProductID
        {
            get { return _fK_ICFromProductID; }
            set
            {
                if (value != this._fK_ICFromProductID)
                {
                    _fK_ICFromProductID = value;
                    NotifyChanged("FK_ICFromProductID");
                }
            }
        }
        public String ICProductConversionItemProductName
        {
            get { return _iCProductConversionItemProductName; }
            set
            {
                if (value != this._iCProductConversionItemProductName)
                {
                    _iCProductConversionItemProductName = value;
                    NotifyChanged("ICProductConversionItemProductName");
                }
            }
        }
        public String ICProductConversionItemProductDesc
        {
            get { return _iCProductConversionItemProductDesc; }
            set
            {
                if (value != this._iCProductConversionItemProductDesc)
                {
                    _iCProductConversionItemProductDesc = value;
                    NotifyChanged("ICProductConversionItemProductDesc");
                }
            }
        }
        public decimal ICProductConversionItemProductQty
        {
            get { return _iCProductConversionItemProductQty; }
            set
            {
                if (value != this._iCProductConversionItemProductQty)
                {
                    _iCProductConversionItemProductQty = value;
                    NotifyChanged("ICProductConversionItemProductQty");
                }
            }
        }
        public decimal ICProductConversionItemRate
        {
            get { return _iCProductConversionItemRate; }
            set
            {
                if (value != this._iCProductConversionItemRate)
                {
                    _iCProductConversionItemRate = value;
                    NotifyChanged("ICProductConversionItemRate");
                }
            }
        }
        public String ICProductConversionItemType
        {
            get { return _iCProductConversionItemType; }
            set
            {
                if (value != this._iCProductConversionItemType)
                {
                    _iCProductConversionItemType = value;
                    NotifyChanged("ICProductConversionItemType");
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
        public String ICProductConversionItemProductSerialNo
        {
            get { return _iCProductConversionItemProductSerialNo; }
            set
            {
                if (value != this._iCProductConversionItemProductSerialNo)
                {
                    _iCProductConversionItemProductSerialNo = value;
                    NotifyChanged("ICProductConversionItemProductSerialNo");
                }
            }
        }
        public decimal ICProductConversionItemProductFactor
        {
            get { return _iCProductConversionItemProductFactor; }
            set
            {
                if (value != this._iCProductConversionItemProductFactor)
                {
                    _iCProductConversionItemProductFactor = value;
                    NotifyChanged("ICProductConversionItemProductFactor");
                }
            }
        }
        public decimal ICProductConversionItemProductExchangeQty
        {
            get { return _iCProductConversionItemProductExchangeQty; }
            set
            {
                if (value != this._iCProductConversionItemProductExchangeQty)
                {
                    _iCProductConversionItemProductExchangeQty = value;
                    NotifyChanged("ICProductConversionItemProductExchangeQty");
                }
            }
        }
        public decimal ICProductConversionItemUnitCost
        {
            get { return _iCProductConversionItemUnitCost; }
            set
            {
                if (value != this._iCProductConversionItemUnitCost)
                {
                    _iCProductConversionItemUnitCost = value;
                    NotifyChanged("ICProductConversionItemUnitCost");
                }
            }
        }
        public decimal ICProductConversionItemTotalCost
        {
            get { return _iCProductConversionItemTotalCost; }
            set
            {
                if (value != this._iCProductConversionItemTotalCost)
                {
                    _iCProductConversionItemTotalCost = value;
                    NotifyChanged("ICProductConversionItemTotalCost");
                }
            }
        }
        public bool ICProductConversionItemIsAverageCalculation
        {
            get { return _iCProductConversionItemIsAverageCalculation; }
            set
            {
                if (value != this._iCProductConversionItemIsAverageCalculation)
                {
                    _iCProductConversionItemIsAverageCalculation = value;
                    NotifyChanged("ICProductConversionItemIsAverageCalculation");
                }
            }
        }
        public bool ICProductConversionItemIsSpecificCalculation
        {
            get { return _iCProductConversionItemIsSpecificCalculation; }
            set
            {
                if (value != this._iCProductConversionItemIsSpecificCalculation)
                {
                    _iCProductConversionItemIsSpecificCalculation = value;
                    NotifyChanged("ICProductConversionItemIsSpecificCalculation");
                }
            }
        }
        public int FK_ACAccountID
        {
            get { return _fK_ACAccountID; }
            set
            {
                if (value != this._fK_ACAccountID)
                {
                    _fK_ACAccountID = value;
                    NotifyChanged("FK_ACAccountID");
                }
            }
        }
        public decimal ICProductConversionItemProductUnitPrice
        {
            get { return _iCProductConversionItemProductUnitPrice; }
            set
            {
                if (value != this._iCProductConversionItemProductUnitPrice)
                {
                    _iCProductConversionItemProductUnitPrice = value;
                    NotifyChanged("ICProductConversionItemProductUnitPrice");
                }
            }
        }
        public String ICProductConversionItemConfigType
        {
            get { return _iCProductConversionItemConfigType; }
            set
            {
                if (value != this._iCProductConversionItemConfigType)
                {
                    _iCProductConversionItemConfigType = value;
                    NotifyChanged("ICProductConversionItemConfigType");
                }
            }
        }
        public decimal ICProductConversionItemConfigValue
        {
            get { return _iCProductConversionItemConfigValue; }
            set
            {
                if (value != this._iCProductConversionItemConfigValue)
                {
                    _iCProductConversionItemConfigValue = value;
                    NotifyChanged("ICProductConversionItemConfigValue");
                }
            }
        }
        public decimal ICProductConversionItemCost
        {
            get { return _iCProductConversionItemCost; }
            set
            {
                if (value != this._iCProductConversionItemCost)
                {
                    _iCProductConversionItemCost = value;
                    NotifyChanged("ICProductConversionItemCost");
                }
            }
        }

        public int ICProductConversionItemParentID
        {
            get { return _iCProductConversionItemParentID; }
            set
            {
                if (value != this._iCProductConversionItemParentID)
                {
                    _iCProductConversionItemParentID = value;
                    NotifyChanged("ICProductConversionItemParentID");
                }
            }
        }
        public decimal ICProductConversionItemWoodQty
        {
            get { return _iCProductConversionItemWoodQty; }
            set
            {
                if (value != this._iCProductConversionItemWoodQty)
                {
                    _iCProductConversionItemWoodQty = value;
                    NotifyChanged("ICProductConversionItemWoodQty");
                }
            }
        }
        public decimal ICProductConversionItemLengthMin
        {
            get { return _iCProductConversionItemLengthMin; }
            set
            {
                if (value != this._iCProductConversionItemLengthMin)
                {
                    _iCProductConversionItemLengthMin = value;
                    NotifyChanged("ICProductConversionItemLengthMin");
                }
            }
        }
        public decimal ICProductConversionItemWidthMin
        {
            get { return _iCProductConversionItemWidthMin; }
            set
            {
                if (value != this._iCProductConversionItemWidthMin)
                {
                    _iCProductConversionItemWidthMin = value;
                    NotifyChanged("ICProductConversionItemWidthMin");
                }
            }
        }
        public decimal ICProductConversionItemHeightMin
        {
            get { return _iCProductConversionItemHeightMin; }
            set
            {
                if (value != this._iCProductConversionItemHeightMin)
                {
                    _iCProductConversionItemHeightMin = value;
                    NotifyChanged("ICProductConversionItemHeightMin");
                }
            }
        }
        public decimal ICProductConversionItemLengthMax
        {
            get { return _iCProductConversionItemLengthMax; }
            set
            {
                if (value != this._iCProductConversionItemLengthMax)
                {
                    _iCProductConversionItemLengthMax = value;
                    NotifyChanged("ICProductConversionItemLengthMax");
                }
            }
        }
        public decimal ICProductConversionItemWidthMax
        {
            get { return _iCProductConversionItemWidthMax; }
            set
            {
                if (value != this._iCProductConversionItemWidthMax)
                {
                    _iCProductConversionItemWidthMax = value;
                    NotifyChanged("ICProductConversionItemWidthMax");
                }
            }
        }
        public decimal ICProductConversionItemHeightMax
        {
            get { return _iCProductConversionItemHeightMax; }
            set
            {
                if (value != this._iCProductConversionItemHeightMax)
                {
                    _iCProductConversionItemHeightMax = value;
                    NotifyChanged("ICProductConversionItemHeightMax");
                }
            }
        }
        public decimal ICProductConversionItemPerimeter
        {
            get { return _iCProductConversionItemPerimeter; }
            set
            {
                if (value != this._iCProductConversionItemPerimeter)
                {
                    _iCProductConversionItemPerimeter = value;
                    NotifyChanged("ICProductConversionItemPerimeter");
                }
            }
        }
        public String ICProductConversionItemLotNo
        {
            get { return _iCProductConversionItemLotNo; }
            set
            {
                if (value != this._iCProductConversionItemLotNo)
                {
                    _iCProductConversionItemLotNo = value;
                    NotifyChanged("ICProductConversionItemLotNo");
                }
            }
        }
        public decimal ICProductConversionItemProductLength
        {
            get { return _iCProductConversionItemProductLength; }
            set
            {
                if (value != this._iCProductConversionItemProductLength)
                {
                    _iCProductConversionItemProductLength = value;
                    NotifyChanged("ICProductConversionItemProductLength");
                }
            }
        }
        public decimal ICProductConversionItemProductWidth
        {
            get { return _iCProductConversionItemProductWidth; }
            set
            {
                if (value != this._iCProductConversionItemProductWidth)
                {
                    _iCProductConversionItemProductWidth = value;
                    NotifyChanged("ICProductConversionItemProductWidth");
                }
            }
        }
        public decimal ICProductConversionItemProductHeight
        {
            get { return _iCProductConversionItemProductHeight; }
            set
            {
                if (value != this._iCProductConversionItemProductHeight)
                {
                    _iCProductConversionItemProductHeight = value;
                    NotifyChanged("ICProductConversionItemProductHeight");
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

        #endregion

        #region Extra properties
        public decimal ICProductConversionItemTotalFeeCost { get; set; }

        public string VirtualID { get; set; }

        public string VirtualParentID { get; set; }

        public string ICProductConversionItemIDRef { get; set; }

        public string DebitAccountNo { get; set; }
        public string CreditAccountNo { get; set; }
        public int STT { get; set; }
        public string ICProductConversionDesc { get; set; }
        public string ICProductConversionNo { get; set; }
        public string QualifyString { get; set; }
        public string ĐVT { get; set; }
        public string Kho { get; set; }
        public string FromStock { get; set; }
        public string ToStock { get; set; }
        public string ICProductConversionItemProductParentDesc { get; set; }
        public string ICProductConversionItemProductParentSerialNo { get; set; }
        public string ParentQualifyString { get; set; }
        public string ICProductConversionItemParentLotNo { get; set; }
        public string ParentĐVT { get; set; }
        public string ParentKho { get; set; }
        public decimal ICProductConversionItemParentProductHeight { get; set; }
        public decimal ICProductConversionItemParentProductWidth { get; set; }
        public decimal ICProductConversionItemParentProductLength { get; set; }
        public decimal ICProductConversionItemParentWidthMax { get; set; }
        public decimal ICProductConversionItemParentLengthMax { get; set; }
        public decimal ICProductConversionItemParentWoodQty { get; set; }
        public decimal ICProductConversionItemParentProductQty { get; set; }
        public decimal ICProductConversionItemParentLengthMin { get; set; }
        public decimal ICProductConversionItemParentWidthMin { get; set; }

        #endregion
    }
    #endregion
}