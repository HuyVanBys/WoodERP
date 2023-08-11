﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARDeliveryPlanItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDeliveryPlanItemsInfo
    //Created Date:Thursday, March 22, 2018
    //-----------------------------------------------------------

    public class ARDeliveryPlanItemsInfo : BusinessObject
    {
        public ARDeliveryPlanItemsInfo()
        {
        }
        #region Variables
        protected int _aRDeliveryPlanItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARDeliveryPlanID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected int _fK_ARCustomerID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _aRDeliveryPlanItemSaleOrderNo = String.Empty;
        protected DateTime _aRDeliveryPlanItemSaleOrderDate = DateTime.MaxValue;
        protected DateTime _aRDeliveryPlanItemDeliveryDate = DateTime.MaxValue;
        protected String _aRDeliveryPlanItemProductNo = String.Empty;
        protected String _aRDeliveryPlanItemProductName = String.Empty;
        protected String _aRDeliveryPlanItemProductDesc = String.Empty;
        protected String _aRDeliveryPlanItemProductType = String.Empty;
        protected decimal _aRDeliveryPlanItemProductQty;
        protected decimal _aRDeliveryPlanItemNetWeight;
        protected String _aRDeliveryPlanItemAddress = String.Empty;
        protected String _aRDeliveryPlanItemCommand = String.Empty;
        protected String _aRDeliveryPlanItemSource = String.Empty;
        protected String _aRDeliveryPlanItemStatus = DefaultStatus;
        protected DateTime _aRDeliveryPlanItemDeliveryActualDate = DateTime.MaxValue;
        protected String _aRDeliveryPlanItemCancelReason = String.Empty;
        protected decimal _aRDeliveryPlanItemCancelQty;
        protected decimal _aRDeliveryPlanItemPlanQty;
        protected decimal _aRDeliveryPlanItemShipmentQty;
        protected decimal _aRDeliveryPlanItemDeliveryQty;
        protected String _aRDeliveryPlanItemDeliveryAddressStreet = String.Empty;
        protected String _aRDeliveryPlanItemDeliveryAddressWard = String.Empty;
        protected int _fK_GEDeliveryDistrictID;
        protected int _fK_GEDeliveryStateProvinceID;
        protected decimal _aRDeliveryPlanItemProductHeight;
        protected decimal _aRDeliveryPlanItemProductWidth;
        protected decimal _aRDeliveryPlanItemProductLength;
        protected int _aRDeliveryPlanItemReferenceID;
        protected int _fK_ICStockID;
        protected String _aRDeliveryPlanItemProductTemplateType = String.Empty;
        protected int _fK_ACObjectID;
        protected String _aRObjectType = String.Empty;
        protected int _fK_ICTransferItemID;
        protected int _fK_ARSaleReturnItemID;
        protected int _fK_ARSaleReturnID;
        protected int _fK_ICTransferID;
        protected int _fK_ICSectionProductID;
        protected int _fK_ACCostCenterID;
        protected int _fK_PMTemplateItemID;
        protected int _fK_ARProposalTemplateItemID;
        protected int _fK_ICMeasureUnitBeforeChangeID;
        protected int _fK_ICProductAttributeTTMTID;
        protected int _fK_ICProductSerieID;
        protected String _aRDeliveryPlanItemProductSerialNo = String.Empty;
        protected int _fK_ARContainerLoaderItemID;
        protected int _fK_ARContainerLoaderID;
        protected decimal _aRDeliveryPlanItemProductFactor;
        protected decimal _aRDeliveryPlanItemProductExchangeQty;
        protected decimal _aRDeliveryPlanItemExchangeUnitCost;
        protected decimal _aRDeliveryPlanItemExchangeTotalCost;
        protected int _fK_ICProductAttributeQualityID;
        protected String _aRDeliveryPlanItemLotNo = String.Empty;
        protected decimal _aRDeliveryPlanItemWoodQty;
        protected String _aRDeliveryPlanItemPONo = String.Empty;
        protected int _fK_MMBatchProductID;
        protected string _aRDeliveryPlanItemProductNoOfOldSys = string.Empty;
        protected string _aRDeliveryPlanItemProductCustomerNumber = string.Empty;
        protected decimal _aRDeliveryPlanItemQuantityOfBox;
        #endregion

        #region Public properties
        public int ARDeliveryPlanItemID
        {
            get { return _aRDeliveryPlanItemID; }
            set
            {
                if (value != this._aRDeliveryPlanItemID)
                {
                    _aRDeliveryPlanItemID = value;
                    NotifyChanged("ARDeliveryPlanItemID");
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
        public int FK_ARDeliveryPlanID
        {
            get { return _fK_ARDeliveryPlanID; }
            set
            {
                if (value != this._fK_ARDeliveryPlanID)
                {
                    _fK_ARDeliveryPlanID = value;
                    NotifyChanged("FK_ARDeliveryPlanID");
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
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
        public String ARDeliveryPlanItemSaleOrderNo
        {
            get { return _aRDeliveryPlanItemSaleOrderNo; }
            set
            {
                if (value != this._aRDeliveryPlanItemSaleOrderNo)
                {
                    _aRDeliveryPlanItemSaleOrderNo = value;
                    NotifyChanged("ARDeliveryPlanItemSaleOrderNo");
                }
            }
        }
        public DateTime ARDeliveryPlanItemSaleOrderDate
        {
            get { return _aRDeliveryPlanItemSaleOrderDate; }
            set
            {
                if (value != this._aRDeliveryPlanItemSaleOrderDate)
                {
                    _aRDeliveryPlanItemSaleOrderDate = value;
                    NotifyChanged("ARDeliveryPlanItemSaleOrderDate");
                }
            }
        }
        public DateTime ARDeliveryPlanItemDeliveryDate
        {
            get { return _aRDeliveryPlanItemDeliveryDate; }
            set
            {
                if (value != this._aRDeliveryPlanItemDeliveryDate)
                {
                    _aRDeliveryPlanItemDeliveryDate = value;
                    NotifyChanged("ARDeliveryPlanItemDeliveryDate");
                }
            }
        }
        public String ARDeliveryPlanItemProductNo
        {
            get { return _aRDeliveryPlanItemProductNo; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductNo)
                {
                    _aRDeliveryPlanItemProductNo = value;
                    NotifyChanged("ARDeliveryPlanItemProductNo");
                }
            }
        }
        public String ARDeliveryPlanItemProductName
        {
            get { return _aRDeliveryPlanItemProductName; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductName)
                {
                    _aRDeliveryPlanItemProductName = value;
                    NotifyChanged("ARDeliveryPlanItemProductName");
                }
            }
        }
        public String ARDeliveryPlanItemProductDesc
        {
            get { return _aRDeliveryPlanItemProductDesc; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductDesc)
                {
                    _aRDeliveryPlanItemProductDesc = value;
                    NotifyChanged("ARDeliveryPlanItemProductDesc");
                }
            }
        }
        public String ARDeliveryPlanItemProductType
        {
            get { return _aRDeliveryPlanItemProductType; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductType)
                {
                    _aRDeliveryPlanItemProductType = value;
                    NotifyChanged("ARDeliveryPlanItemProductType");
                }
            }
        }
        public decimal ARDeliveryPlanItemProductQty
        {
            get { return _aRDeliveryPlanItemProductQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductQty)
                {
                    _aRDeliveryPlanItemProductQty = value;
                    NotifyChanged("ARDeliveryPlanItemProductQty");
                }
            }
        }
        public decimal ARDeliveryPlanItemNetWeight
        {
            get { return _aRDeliveryPlanItemNetWeight; }
            set
            {
                if (value != this._aRDeliveryPlanItemNetWeight)
                {
                    _aRDeliveryPlanItemNetWeight = value;
                    NotifyChanged("ARDeliveryPlanItemNetWeight");
                }
            }
        }
        public String ARDeliveryPlanItemAddress
        {
            get { return _aRDeliveryPlanItemAddress; }
            set
            {
                if (value != this._aRDeliveryPlanItemAddress)
                {
                    _aRDeliveryPlanItemAddress = value;
                    NotifyChanged("ARDeliveryPlanItemAddress");
                }
            }
        }
        public String ARDeliveryPlanItemCommand
        {
            get { return _aRDeliveryPlanItemCommand; }
            set
            {
                if (value != this._aRDeliveryPlanItemCommand)
                {
                    _aRDeliveryPlanItemCommand = value;
                    NotifyChanged("ARDeliveryPlanItemCommand");
                }
            }
        }
        public String ARDeliveryPlanItemSource
        {
            get { return _aRDeliveryPlanItemSource; }
            set
            {
                if (value != this._aRDeliveryPlanItemSource)
                {
                    _aRDeliveryPlanItemSource = value;
                    NotifyChanged("ARDeliveryPlanItemSource");
                }
            }
        }
        public String ARDeliveryPlanItemStatus
        {
            get { return _aRDeliveryPlanItemStatus; }
            set
            {
                if (value != this._aRDeliveryPlanItemStatus)
                {
                    _aRDeliveryPlanItemStatus = value;
                    NotifyChanged("ARDeliveryPlanItemStatus");
                }
            }
        }
        public DateTime ARDeliveryPlanItemDeliveryActualDate
        {
            get { return _aRDeliveryPlanItemDeliveryActualDate; }
            set
            {
                if (value != this._aRDeliveryPlanItemDeliveryActualDate)
                {
                    _aRDeliveryPlanItemDeliveryActualDate = value;
                    NotifyChanged("ARDeliveryPlanItemDeliveryActualDate");
                }
            }
        }
        public String ARDeliveryPlanItemCancelReason
        {
            get { return _aRDeliveryPlanItemCancelReason; }
            set
            {
                if (value != this._aRDeliveryPlanItemCancelReason)
                {
                    _aRDeliveryPlanItemCancelReason = value;
                    NotifyChanged("ARDeliveryPlanItemCancelReason");
                }
            }
        }
        public decimal ARDeliveryPlanItemCancelQty
        {
            get { return _aRDeliveryPlanItemCancelQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemCancelQty)
                {
                    _aRDeliveryPlanItemCancelQty = value;
                    NotifyChanged("ARDeliveryPlanItemCancelQty");
                }
            }
        }
        public decimal ARDeliveryPlanItemPlanQty
        {
            get { return _aRDeliveryPlanItemPlanQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemPlanQty)
                {
                    _aRDeliveryPlanItemPlanQty = value;
                    NotifyChanged("ARDeliveryPlanItemPlanQty");
                }
            }
        }
        public decimal ARDeliveryPlanItemShipmentQty
        {
            get { return _aRDeliveryPlanItemShipmentQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemShipmentQty)
                {
                    _aRDeliveryPlanItemShipmentQty = value;
                    NotifyChanged("ARDeliveryPlanItemShipmentQty");
                }
            }
        }
        public decimal ARDeliveryPlanItemDeliveryQty
        {
            get { return _aRDeliveryPlanItemDeliveryQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemDeliveryQty)
                {
                    _aRDeliveryPlanItemDeliveryQty = value;
                    NotifyChanged("ARDeliveryPlanItemDeliveryQty");
                }
            }
        }
        public String ARDeliveryPlanItemDeliveryAddressStreet
        {
            get { return _aRDeliveryPlanItemDeliveryAddressStreet; }
            set
            {
                if (value != this._aRDeliveryPlanItemDeliveryAddressStreet)
                {
                    _aRDeliveryPlanItemDeliveryAddressStreet = value;
                    NotifyChanged("ARDeliveryPlanItemDeliveryAddressStreet");
                }
            }
        }
        public String ARDeliveryPlanItemDeliveryAddressWard
        {
            get { return _aRDeliveryPlanItemDeliveryAddressWard; }
            set
            {
                if (value != this._aRDeliveryPlanItemDeliveryAddressWard)
                {
                    _aRDeliveryPlanItemDeliveryAddressWard = value;
                    NotifyChanged("ARDeliveryPlanItemDeliveryAddressWard");
                }
            }
        }
        public int FK_GEDeliveryDistrictID
        {
            get { return _fK_GEDeliveryDistrictID; }
            set
            {
                if (value != this._fK_GEDeliveryDistrictID)
                {
                    _fK_GEDeliveryDistrictID = value;
                    NotifyChanged("FK_GEDeliveryDistrictID");
                }
            }
        }
        public int FK_GEDeliveryStateProvinceID
        {
            get { return _fK_GEDeliveryStateProvinceID; }
            set
            {
                if (value != this._fK_GEDeliveryStateProvinceID)
                {
                    _fK_GEDeliveryStateProvinceID = value;
                    NotifyChanged("FK_GEDeliveryStateProvinceID");
                }
            }
        }
        public decimal ARDeliveryPlanItemProductHeight
        {
            get { return _aRDeliveryPlanItemProductHeight; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductHeight)
                {
                    _aRDeliveryPlanItemProductHeight = value;
                    NotifyChanged("ARDeliveryPlanItemProductHeight");
                }
            }
        }
        public decimal ARDeliveryPlanItemProductWidth
        {
            get { return _aRDeliveryPlanItemProductWidth; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductWidth)
                {
                    _aRDeliveryPlanItemProductWidth = value;
                    NotifyChanged("ARDeliveryPlanItemProductWidth");
                }
            }
        }
        public decimal ARDeliveryPlanItemProductLength
        {
            get { return _aRDeliveryPlanItemProductLength; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductLength)
                {
                    _aRDeliveryPlanItemProductLength = value;
                    NotifyChanged("ARDeliveryPlanItemProductLength");
                }
            }
        }
        public int ARDeliveryPlanItemReferenceID
        {
            get { return _aRDeliveryPlanItemReferenceID; }
            set
            {
                if (value != this._aRDeliveryPlanItemReferenceID)
                {
                    _aRDeliveryPlanItemReferenceID = value;
                    NotifyChanged("ARDeliveryPlanItemReferenceID");
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
        public String ARDeliveryPlanItemProductTemplateType
        {
            get { return _aRDeliveryPlanItemProductTemplateType; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductTemplateType)
                {
                    _aRDeliveryPlanItemProductTemplateType = value;
                    NotifyChanged("ARDeliveryPlanItemProductTemplateType");
                }
            }
        }
        public int FK_ACObjectID
        {
            get { return _fK_ACObjectID; }
            set
            {
                if (value != this._fK_ACObjectID)
                {
                    _fK_ACObjectID = value;
                    NotifyChanged("FK_ACObjectID");
                }
            }
        }
        public String ARObjectType
        {
            get { return _aRObjectType; }
            set
            {
                if (value != this._aRObjectType)
                {
                    _aRObjectType = value;
                    NotifyChanged("ARObjectType");
                }
            }
        }
        public int FK_ICTransferItemID
        {
            get { return _fK_ICTransferItemID; }
            set
            {
                if (value != this._fK_ICTransferItemID)
                {
                    _fK_ICTransferItemID = value;
                    NotifyChanged("FK_ICTransferItemID");
                }
            }
        }
        public int FK_ARSaleReturnItemID
        {
            get { return _fK_ARSaleReturnItemID; }
            set
            {
                if (value != this._fK_ARSaleReturnItemID)
                {
                    _fK_ARSaleReturnItemID = value;
                    NotifyChanged("FK_ARSaleReturnItemID");
                }
            }
        }
        public int FK_ARSaleReturnID
        {
            get { return _fK_ARSaleReturnID; }
            set
            {
                if (value != this._fK_ARSaleReturnID)
                {
                    _fK_ARSaleReturnID = value;
                    NotifyChanged("FK_ARSaleReturnID");
                }
            }
        }
        public int FK_ICTransferID
        {
            get { return _fK_ICTransferID; }
            set
            {
                if (value != this._fK_ICTransferID)
                {
                    _fK_ICTransferID = value;
                    NotifyChanged("FK_ICTransferID");
                }
            }
        }
        public int FK_ICSectionProductID
        {
            get { return _fK_ICSectionProductID; }
            set
            {
                if (value != this._fK_ICSectionProductID)
                {
                    _fK_ICSectionProductID = value;
                    NotifyChanged("FK_ICSectionProductID");
                }
            }
        }
        public int FK_ACCostCenterID
        {
            get { return _fK_ACCostCenterID; }
            set
            {
                if (value != this._fK_ACCostCenterID)
                {
                    _fK_ACCostCenterID = value;
                    NotifyChanged("FK_ACCostCenterID");
                }
            }
        }
        public int FK_PMTemplateItemID
        {
            get { return _fK_PMTemplateItemID; }
            set
            {
                if (value != this._fK_PMTemplateItemID)
                {
                    _fK_PMTemplateItemID = value;
                    NotifyChanged("FK_PMTemplateItemID");
                }
            }
        }
        public int FK_ARProposalTemplateItemID
        {
            get { return _fK_ARProposalTemplateItemID; }
            set
            {
                if (value != this._fK_ARProposalTemplateItemID)
                {
                    _fK_ARProposalTemplateItemID = value;
                    NotifyChanged("FK_ARProposalTemplateItemID");
                }
            }
        }
        public int FK_ICMeasureUnitBeforeChangeID
        {
            get { return _fK_ICMeasureUnitBeforeChangeID; }
            set
            {
                if (value != this._fK_ICMeasureUnitBeforeChangeID)
                {
                    _fK_ICMeasureUnitBeforeChangeID = value;
                    NotifyChanged("FK_ICMeasureUnitBeforeChangeID");
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
        public String ARDeliveryPlanItemProductSerialNo
        {
            get { return _aRDeliveryPlanItemProductSerialNo; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductSerialNo)
                {
                    _aRDeliveryPlanItemProductSerialNo = value;
                    NotifyChanged("ARDeliveryPlanItemProductSerialNo");
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
        public decimal ARDeliveryPlanItemProductFactor
        {
            get { return _aRDeliveryPlanItemProductFactor; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductFactor)
                {
                    _aRDeliveryPlanItemProductFactor = value;
                    NotifyChanged("ARDeliveryPlanItemProductFactor");
                }
            }
        }
        public decimal ARDeliveryPlanItemProductExchangeQty
        {
            get { return _aRDeliveryPlanItemProductExchangeQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductExchangeQty)
                {
                    _aRDeliveryPlanItemProductExchangeQty = value;
                    NotifyChanged("ARDeliveryPlanItemProductExchangeQty");
                }
            }
        }
        public decimal ARDeliveryPlanItemExchangeUnitCost
        {
            get { return _aRDeliveryPlanItemExchangeUnitCost; }
            set
            {
                if (value != this._aRDeliveryPlanItemExchangeUnitCost)
                {
                    _aRDeliveryPlanItemExchangeUnitCost = value;
                    NotifyChanged("ARDeliveryPlanItemProductExchangeQty");
                }
            }
        }
        public decimal ARDeliveryPlanItemExchangeTotalCost
        {
            get { return _aRDeliveryPlanItemExchangeTotalCost; }
            set
            {
                if (value != this._aRDeliveryPlanItemExchangeTotalCost)
                {
                    _aRDeliveryPlanItemExchangeTotalCost = value;
                    NotifyChanged("ARDeliveryPlanItemProductExchangeQty");
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
        public String ARDeliveryPlanItemLotNo
        {
            get { return _aRDeliveryPlanItemLotNo; }
            set
            {
                if (value != this._aRDeliveryPlanItemLotNo)
                {
                    _aRDeliveryPlanItemLotNo = value;
                    NotifyChanged("ARDeliveryPlanItemLotNo");
                }
            }
        }
        public decimal ARDeliveryPlanItemWoodQty
        {
            get { return _aRDeliveryPlanItemWoodQty; }
            set
            {
                if (value != this._aRDeliveryPlanItemWoodQty)
                {
                    _aRDeliveryPlanItemWoodQty = value;
                    NotifyChanged("ARDeliveryPlanItemWoodQty");
                }
            }
        }
        public String ARDeliveryPlanItemPONo
        {
            get { return _aRDeliveryPlanItemPONo; }
            set
            {
                if (value != this._aRDeliveryPlanItemPONo)
                {
                    _aRDeliveryPlanItemPONo = value;
                    NotifyChanged("ARDeliveryPlanItemPONo");
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
        public string ARDeliveryPlanItemProductNoOfOldSys
        {
            get { return _aRDeliveryPlanItemProductNoOfOldSys; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductNoOfOldSys)
                {
                    _aRDeliveryPlanItemProductNoOfOldSys = value;
                    NotifyChanged("ARDeliveryPlanItemProductNoOfOldSys");
                }
            }
        }
        public string ARDeliveryPlanItemProductCustomerNumber
        {
            get { return _aRDeliveryPlanItemProductCustomerNumber; }
            set
            {
                if (value != this._aRDeliveryPlanItemProductCustomerNumber)
                {
                    _aRDeliveryPlanItemProductCustomerNumber = value;
                    NotifyChanged("ARDeliveryPlanItemProductCustomerNumber");
                }
            }
        }
        public decimal ARDeliveryPlanItemQuantityOfBox
        {
            get { return _aRDeliveryPlanItemQuantityOfBox; }
            set
            {
                if (value != this._aRDeliveryPlanItemQuantityOfBox)
                {
                    _aRDeliveryPlanItemQuantityOfBox = value;
                    NotifyChanged("ARDeliveryPlanItemQuantityOfBox");
                }    
            } 
        }

        #endregion

        #region Extra

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARSaleOrderItemProductUnitPrice { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARSaleOrderItemProductUnitCost { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARSaleOrderItemPrice { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARSaleOrderItemTotalAmount { get; set; }

        //public int FK_ICProductSerieID { get; set; }

        //public int FK_ICStockID { get; set; }

        public int FK_ICDepartmentID { get; set; }

        public String ARSaleOrderItemProductSerialNo { get; set; }

        public String ARSaleOrderItemProductAttribute { get; set; }

        public String ARSaleOrderSaleAgreement { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal ARDeliveryPlanItemRemainedQty { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal ARDeliveryPlanItemAttributionQty { get; set; }

        public int FK_ACAccountID { get; set; }
        public String ARDeliveryPlanNo { get; set; }
        public String ARDeliveryPlanName { get; set; }
        public DateTime ARDeliveryPlanDate { get; set; }
        public decimal TotalM3 { get; set; }
        public string ACObjectAccessKey { get; set; }
        public string ACObjectName { get; set; }
        public string BRBranchName { get; set; }
        public string ICMeasureUnitName { get; set; }
        public long ARDeliveryPlanItemRowNumber { get; set; }
        public string CustomerName { get; set; }
        public string ICProductName { get; set; }
        public string ARDeliveryPlanTruckName { get; set; }
        public string ARDeliveryPlanTruckDriver { get; set; }
        public string ARDeliveryPlanTruckDeliveryEmployee { get; set; }
        public string ARDeliveryPlanDesc { get; set; }
        public string ARSaleOrderNo { get; set; }
        public string HREmployeeName { get; set; }

        public string HRProductSummaryCaptionReport { get; set; }
        public int FK_ARProposalID { get; set; }

        public string ARDeliveryPlanType { get; set; }

        public string ARDeliveryPlanStatus { get; set; }

        public string ARDeliveryPlanReferenceNo { get; set; }

        [FormatGroup(FormatGroupAttribute.csFormatGroupN3)]
        public decimal ARDeliveryPlanItemSaleOrderQty { get; set; }
        public string ItemOrder { get; set; }
        public string GroupOrder { get; set; }

        public String ARDeliveryPlanItemOneLevelArea { get; set; }
        public String ARDeliveryPlanItemTwoLevelArea { get; set; }
        public String ARDeliveryPlanItemThreeLevelArea { get; set; }
        public int FK_PMTemplateID { get; set; }
        public int FK_PMProjectID { get; set; }
        public int FK_ARSaleContractID { get; set; }

        public string PMTemplateItemProductName { get; set; }
        public String ARProposalTemplateItemProductName { get; set; }
        public String ARSaleOrderProductType { get; set; }
        public decimal ARDeliveryPlanItemInvoiceQty { get; set; }
        public int STT { get; set; }
        public String TTMT { get; set; }
        public String MMBatchProductNo { get; set; }
        public decimal ARProductionPlanningItemProductQty { get; set; }
        public String ARSaleOrderSaleType { get; set; }
        public String ARSaleOrderName { get; set; }
        public String ARListOfSalesChannelType { get; set; }
        public String ICProductName2 { get; set; }
        public String ARDeliveryPlanContainersNumber { get; set; }
        public String ARDeliveryPlanSeal { get; set; }
        public String ARDeliveryPlanInternalSeal { get; set; }
        #endregion
    }

    #endregion ARDeliveryPlanItems
}