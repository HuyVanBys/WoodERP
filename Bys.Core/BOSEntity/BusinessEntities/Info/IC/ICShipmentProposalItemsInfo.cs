﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICShipmentProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICShipmentProposalItemsInfo
    //Created Date:Thursday, November 05, 2015
    //-----------------------------------------------------------

    public class ICShipmentProposalItemsInfo : BusinessObject
    {
        public ICShipmentProposalItemsInfo()
        {
        }
        #region Variables
        protected int _iCShipmentProposalItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICShipmentProposalID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductAttributeID;
        protected int _fK_ICProductAttributeColor;
        protected int _fK_ICProductAttributePaintType;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected String _iCShipmentProposalItemProductName = String.Empty;
        protected String _iCShipmentProposalItemProductDesc = String.Empty;
        protected decimal _iCShipmentProposalItemProductQty;
        protected decimal _iCShipmentProposalItemProductShippedQty;
        protected decimal _iCShipmentProposalItemProductRemainQty;
        protected String _iCShipmentProposalItemComment = String.Empty;
        protected String _iCShipmentProposalItemStatus = DefaultStatus;
        protected String _iCPriority = String.Empty;
        protected decimal _iCShipmentProposalItemProductCanceledQty;
        protected int _fK_ICProductSerieID;
        protected int _fK_ICStockID;
        protected int _fK_ICProductAttributeTTMTID;
        protected int _fK_GECountryID;
        protected int _fK_ICProductAttributeQualityID;
        protected decimal _iCShipmentProposalItemWoodQty;
        protected decimal _iCShipmentProposalItemHeight;
        protected decimal _iCShipmentProposalItemWidth;
        protected decimal _iCShipmentProposalItemLength;
        protected decimal _iCShipmentProposalItemPerimeter;
        protected decimal _iCShipmentProposalItemHeightMin;
        protected decimal _iCShipmentProposalItemWidthMin;
        protected decimal _iCShipmentProposalItemLengthMin;
        protected decimal _iCShipmentProposalItemPerimeterMin;
        protected decimal _iCShipmentProposalItemHeightMax;
        protected decimal _iCShipmentProposalItemWidthMax;
        protected decimal _iCShipmentProposalItemLentghMax;
        protected decimal _iCShipmentProposalItemPerimeterMax;
        protected String _iCShipmentProposalItemLotNo = String.Empty;
        protected String _iCShipmentProposalItemProductSerialNo = String.Empty;
        protected int _fK_ICProductEquipmentID;
        protected int _fK_ACAssetID;
        protected int _fK_ICModelID;
        protected int _fK_ICModelDetailID;
        protected String _iCShipmentProposalItemColorText = String.Empty;
        protected String _iCShipmentProposalItemHTText = String.Empty;
        protected String _iCShipmentProposalItemPONo = String.Empty;
        protected int _fK_ARContainerLoaderID;
        protected int _fK_ARContainerLoaderItemID;
        protected int _fK_MMBatchProductID;
        protected int _fK_ARProductionPlanningItemID;
        #endregion

        #region Public properties
        public int ICShipmentProposalItemID
        {
            get { return _iCShipmentProposalItemID; }
            set
            {
                if (value != this._iCShipmentProposalItemID)
                {
                    _iCShipmentProposalItemID = value;
                    NotifyChanged("ICShipmentProposalItemID");
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
        public int FK_ICShipmentProposalID
        {
            get { return _fK_ICShipmentProposalID; }
            set
            {
                if (value != this._fK_ICShipmentProposalID)
                {
                    _fK_ICShipmentProposalID = value;
                    NotifyChanged("FK_ICShipmentProposalID");
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
        public int FK_ICProductAttributeColor
        {
            get { return _fK_ICProductAttributeColor; }
            set
            {
                if (value != this._fK_ICProductAttributeColor)
                {
                    _fK_ICProductAttributeColor = value;
                    NotifyChanged("FK_ICProductAttributeColor");
                }
            }
        }
        public int FK_ICProductAttributePaintType
        {
            get { return _fK_ICProductAttributePaintType; }
            set
            {
                if (value != this._fK_ICProductAttributePaintType)
                {
                    _fK_ICProductAttributePaintType = value;
                    NotifyChanged("FK_ICProductAttributePaintType");
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
        public String ICShipmentProposalItemProductName
        {
            get { return _iCShipmentProposalItemProductName; }
            set
            {
                if (value != this._iCShipmentProposalItemProductName)
                {
                    _iCShipmentProposalItemProductName = value;
                    NotifyChanged("ICShipmentProposalItemProductName");
                }
            }
        }
        public String ICShipmentProposalItemProductDesc
        {
            get { return _iCShipmentProposalItemProductDesc; }
            set
            {
                if (value != this._iCShipmentProposalItemProductDesc)
                {
                    _iCShipmentProposalItemProductDesc = value;
                    NotifyChanged("ICShipmentProposalItemProductDesc");
                }
            }
        }
        public decimal ICShipmentProposalItemProductQty
        {
            get { return _iCShipmentProposalItemProductQty; }
            set
            {
                if (value != this._iCShipmentProposalItemProductQty)
                {
                    _iCShipmentProposalItemProductQty = value;
                    NotifyChanged("ICShipmentProposalItemProductQty");
                }
            }
        }
        public decimal ICShipmentProposalItemProductShippedQty
        {
            get { return _iCShipmentProposalItemProductShippedQty; }
            set
            {
                if (value != this._iCShipmentProposalItemProductShippedQty)
                {
                    _iCShipmentProposalItemProductShippedQty = value;
                    NotifyChanged("ICShipmentProposalItemProductShippedQty");
                }
            }
        }
        public decimal ICShipmentProposalItemProductRemainQty
        {
            get { return _iCShipmentProposalItemProductRemainQty; }
            set
            {
                if (value != this._iCShipmentProposalItemProductRemainQty)
                {
                    _iCShipmentProposalItemProductRemainQty = value;
                    NotifyChanged("ICShipmentProposalItemProductRemainQty");
                }
            }
        }
        public String ICShipmentProposalItemComment
        {
            get { return _iCShipmentProposalItemComment; }
            set
            {
                if (value != this._iCShipmentProposalItemComment)
                {
                    _iCShipmentProposalItemComment = value;
                    NotifyChanged("ICShipmentProposalItemComment");
                }
            }
        }
        public String ICShipmentProposalItemStatus
        {
            get { return _iCShipmentProposalItemStatus; }
            set
            {
                if (value != this._iCShipmentProposalItemStatus)
                {
                    _iCShipmentProposalItemStatus = value;
                    NotifyChanged("ICShipmentProposalItemStatus");
                }
            }
        }
        public String ICPriority
        {
            get { return _iCPriority; }
            set
            {
                if (value != this._iCPriority)
                {
                    _iCPriority = value;
                    NotifyChanged("ICPriority");
                }
            }
        }
        public decimal ICShipmentProposalItemProductCanceledQty
        {
            get { return _iCShipmentProposalItemProductCanceledQty; }
            set
            {
                if (value != this._iCShipmentProposalItemProductCanceledQty)
                {
                    _iCShipmentProposalItemProductCanceledQty = value;
                    NotifyChanged("ICShipmentProposalItemProductCanceledQty");
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
        public decimal ICShipmentProposalItemWoodQty
        {
            get { return _iCShipmentProposalItemWoodQty; }
            set
            {
                if (value != this._iCShipmentProposalItemWoodQty)
                {
                    _iCShipmentProposalItemWoodQty = value;
                    NotifyChanged("ICShipmentProposalItemWoodQty");
                }
            }
        }
        public decimal ICShipmentProposalItemHeight
        {
            get { return _iCShipmentProposalItemHeight; }
            set
            {
                if (value != this._iCShipmentProposalItemHeight)
                {
                    _iCShipmentProposalItemHeight = value;
                    NotifyChanged("ICShipmentProposalItemHeight");
                }
            }
        }
        public decimal ICShipmentProposalItemWidth
        {
            get { return _iCShipmentProposalItemWidth; }
            set
            {
                if (value != this._iCShipmentProposalItemWidth)
                {
                    _iCShipmentProposalItemWidth = value;
                    NotifyChanged("ICShipmentProposalItemWidth");
                }
            }
        }
        public decimal ICShipmentProposalItemLength
        {
            get { return _iCShipmentProposalItemLength; }
            set
            {
                if (value != this._iCShipmentProposalItemLength)
                {
                    _iCShipmentProposalItemLength = value;
                    NotifyChanged("ICShipmentProposalItemLength");
                }
            }
        }
        public decimal ICShipmentProposalItemPerimeter
        {
            get { return _iCShipmentProposalItemPerimeter; }
            set
            {
                if (value != this._iCShipmentProposalItemPerimeter)
                {
                    _iCShipmentProposalItemPerimeter = value;
                    NotifyChanged("ICShipmentProposalItemPerimeter");
                }
            }
        }
        public decimal ICShipmentProposalItemHeightMin
        {
            get { return _iCShipmentProposalItemHeightMin; }
            set
            {
                if (value != this._iCShipmentProposalItemHeightMin)
                {
                    _iCShipmentProposalItemHeightMin = value;
                    NotifyChanged("ICShipmentProposalItemHeightMin");
                }
            }
        }
        public decimal ICShipmentProposalItemWidthMin
        {
            get { return _iCShipmentProposalItemWidthMin; }
            set
            {
                if (value != this._iCShipmentProposalItemWidthMin)
                {
                    _iCShipmentProposalItemWidthMin = value;
                    NotifyChanged("ICShipmentProposalItemWidthMin");
                }
            }
        }
        public decimal ICShipmentProposalItemLengthMin
        {
            get { return _iCShipmentProposalItemLengthMin; }
            set
            {
                if (value != this._iCShipmentProposalItemLengthMin)
                {
                    _iCShipmentProposalItemLengthMin = value;
                    NotifyChanged("ICShipmentProposalItemLengthMin");
                }
            }
        }
        public decimal ICShipmentProposalItemPerimeterMin
        {
            get { return _iCShipmentProposalItemPerimeterMin; }
            set
            {
                if (value != this._iCShipmentProposalItemPerimeterMin)
                {
                    _iCShipmentProposalItemPerimeterMin = value;
                    NotifyChanged("ICShipmentProposalItemPerimeterMin");
                }
            }
        }
        public decimal ICShipmentProposalItemHeightMax
        {
            get { return _iCShipmentProposalItemHeightMax; }
            set
            {
                if (value != this._iCShipmentProposalItemHeightMax)
                {
                    _iCShipmentProposalItemHeightMax = value;
                    NotifyChanged("ICShipmentProposalItemHeightMax");
                }
            }
        }
        public decimal ICShipmentProposalItemWidthMax
        {
            get { return _iCShipmentProposalItemWidthMax; }
            set
            {
                if (value != this._iCShipmentProposalItemWidthMax)
                {
                    _iCShipmentProposalItemWidthMax = value;
                    NotifyChanged("ICShipmentProposalItemWidthMax");
                }
            }
        }
        public decimal ICShipmentProposalItemLentghMax
        {
            get { return _iCShipmentProposalItemLentghMax; }
            set
            {
                if (value != this._iCShipmentProposalItemLentghMax)
                {
                    _iCShipmentProposalItemLentghMax = value;
                    NotifyChanged("ICShipmentProposalItemLentghMax");
                }
            }
        }
        public decimal ICShipmentProposalItemPerimeterMax
        {
            get { return _iCShipmentProposalItemPerimeterMax; }
            set
            {
                if (value != this._iCShipmentProposalItemPerimeterMax)
                {
                    _iCShipmentProposalItemPerimeterMax = value;
                    NotifyChanged("ICShipmentProposalItemPerimeterMax");
                }
            }
        }
        public String ICShipmentProposalItemLotNo
        {
            get { return _iCShipmentProposalItemLotNo; }
            set
            {
                if (value != this._iCShipmentProposalItemLotNo)
                {
                    _iCShipmentProposalItemLotNo = value;
                    NotifyChanged("ICShipmentProposalItemLotNo");
                }
            }
        }
        public String ICShipmentProposalItemProductSerialNo
        {
            get { return _iCShipmentProposalItemProductSerialNo; }
            set
            {
                if (value != this._iCShipmentProposalItemProductSerialNo)
                {
                    _iCShipmentProposalItemProductSerialNo = value;
                    NotifyChanged("ICShipmentProposalItemProductSerialNo");
                }
            }
        }
        public int FK_ICProductEquipmentID
        {
            get { return _fK_ICProductEquipmentID; }
            set
            {
                if (value != this._fK_ICProductEquipmentID)
                {
                    _fK_ICProductEquipmentID = value;
                    NotifyChanged("FK_ICProductEquipmentID");
                }
            }
        }
        public int FK_ACAssetID
        {
            get { return _fK_ACAssetID; }
            set
            {
                if (value != this._fK_ACAssetID)
                {
                    _fK_ACAssetID = value;
                    NotifyChanged("FK_ACAssetID");
                }
            }
        }
        public int FK_ICModelID
        {
            get { return _fK_ICModelID; }
            set
            {
                if (value != this._fK_ICModelID)
                {
                    _fK_ICModelID = value;
                    NotifyChanged("FK_ICModelID");
                }
            }
        }
        public int FK_ICModelDetailID
        {
            get { return _fK_ICModelDetailID; }
            set
            {
                if (value != this._fK_ICModelDetailID)
                {
                    _fK_ICModelDetailID = value;
                    NotifyChanged("FK_ICModelDetailID");
                }
            }
        }
        public String ICShipmentProposalItemColorText
        {
            get { return _iCShipmentProposalItemColorText; }
            set
            {
                if (value != this._iCShipmentProposalItemColorText)
                {
                    _iCShipmentProposalItemColorText = value;
                    NotifyChanged("ICShipmentProposalItemColorText");
                }
            }
        }
        public String ICShipmentProposalItemHTText
        {
            get { return _iCShipmentProposalItemHTText; }
            set
            {
                if (value != this._iCShipmentProposalItemHTText)
                {
                    _iCShipmentProposalItemHTText = value;
                    NotifyChanged("ICShipmentProposalItemHTText");
                }
            }
        }
        public String ICShipmentProposalItemPONo
        {
            get { return _iCShipmentProposalItemPONo; }
            set
            {
                if (value != this._iCShipmentProposalItemPONo)
                {
                    _iCShipmentProposalItemPONo = value;
                    NotifyChanged("ICShipmentProposalItemPONo");
                }
            }
        }
        public int FK_ARContainerLoaderID
        {
            get { return _fK_ARContainerLoaderID; }
            set
            {
                if (value != this._fK_ARContainerLoaderID)
                {
                    _fK_ARContainerLoaderID = value;
                    NotifyChanged("FK_ARContainerLoaderID");
                }
            }
        }
        public int FK_ARContainerLoaderItemID
        {
            get { return _fK_ARContainerLoaderItemID; }
            set
            {
                if (value != this._fK_ARContainerLoaderItemID)
                {
                    _fK_ARContainerLoaderItemID = value;
                    NotifyChanged("FK_ARContainerLoaderItemID");
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
        public int FK_ARProductionPlanningItemID
        {
            get { return _fK_ARProductionPlanningItemID; }
            set
            {
                if (value != this._fK_ARProductionPlanningItemID)
                {
                    _fK_ARProductionPlanningItemID = value;
                    NotifyChanged("FK_ARProductionPlanningItemID");
                }
            }
        }

        #endregion

        #region Extra Properties
        public String ICShipmentProposalNo { get; set; }
        public DateTime ICShipmentProposalDate { get; set; }
        public int FK_ARCustomerID { get; set; }
        public String ICMeasureUnitName { get; set; }
        public int STT { get; set; }
        public String ICShipmentProposalType { get; set; }
        public String ICProductNo { get; set; }
        public decimal ICShipmentProposalItemRemainQuantity { get; set; }
        public decimal ICShipmentProposalItemRemainQty { get; set; }

        public string ICProductAttributeValueLG { get; set; }

        public int FK_ACObjectID { get; set; }

        public string ICObjectType { get; set; }
        #endregion
    }
    #endregion
}