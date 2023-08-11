﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProposalItemsInfo
    //Created Date:Tuesday, November 03, 2015
    //-----------------------------------------------------------

    public class MMProposalItemsInfo : BusinessObject
    {
        public MMProposalItemsInfo()
        {
        }
        #region Variables
        protected int _mMProposalItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMProposalID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProductAttributeHTTypeID;
        protected int _fK_ICProductAttributeColorID;
        protected int _fK_ICProductAttributeTTMTID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected int _fK_BRBranchID;
        protected String _mMProposalItemProductType = String.Empty;
        protected int _mMProposalItemSortOrder;
        protected String _mMProposalItemProductNo = String.Empty;
        protected String _mMProposalItemProductName = String.Empty;
        protected String _mMProposalItemProductDesc = String.Empty;
        protected decimal _mMProposalItemProductQty;
        protected decimal _mMProposalItemProductUnitPrice;
        protected decimal _mMProposalItemTotalAmount;
        protected String _mMProposalItemComment = String.Empty;
        protected String _mMProposalItemStatus = DefaultStatus;
        protected DateTime _mMProposalItemDeliveryDate = DateTime.MaxValue;
        protected bool _mMProposalItemIsNewProduct = true;
        protected bool _mMProposalItemIsJoinComponent = true;
        protected String _mMProposalItemHardwareRemark = String.Empty;
        protected String _mMProposalItemPackagingRequimentType = String.Empty;
        protected bool _mMProposalItemLabelCorlor = true;
        protected bool _mMProposalItemProductCard = true;
        protected bool _mMProposalItemProductFSCCard = true;
        protected bool _mMProposalItemProductLabel = true;
        protected bool _mMProposalItemProductHDLR = true;
        protected bool _mMProposalItemProductHDSD = true;
        protected bool _mMProposalItemProductBarcode = true;
        protected bool _mMProposalItemProductWarranty = true;
        protected decimal _mMProposalItemProductPerimeter;
        protected decimal _mMProposalItemProductHeight;
        protected decimal _mMProposalItemProductWidth;
        protected decimal _mMProposalItemProductLength;
        protected decimal _mMProposalItemProductMinHeight;
        protected decimal _mMProposalItemProductMinWidth;
        protected decimal _mMProposalItemProductMinLength;
        protected decimal _mMProposalItemProductMaxHeight;
        protected decimal _mMProposalItemProductMaxWidth;
        protected decimal _mMProposalItemProductMaxLength;
        protected int _fK_ICProductAttributeQualityID;
        protected String _mMProposalItemProductAttributeColor = String.Empty;
        protected String _mMProposalItemProductAttributeHTType = String.Empty;
        protected String _mMProposalItemWoodTypeID = String.Empty;
        protected String _mMProposalItemWoodTypeText = String.Empty;
        protected String _mMProposalItemColorID = String.Empty;
        protected String _mMProposalItemHTID = String.Empty;
        protected String _mMProposalItemPONo = String.Empty;
        protected decimal _mMProposalItemProductCanceledQty;
        #endregion

        #region Public properties
        public int MMProposalItemID
        {
            get { return _mMProposalItemID; }
            set
            {
                if (value != this._mMProposalItemID)
                {
                    _mMProposalItemID = value;
                    NotifyChanged("MMProposalItemID");
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
        public int FK_ICProductAttributeHTTypeID
        {
            get { return _fK_ICProductAttributeHTTypeID; }
            set
            {
                if (value != this._fK_ICProductAttributeHTTypeID)
                {
                    _fK_ICProductAttributeHTTypeID = value;
                    NotifyChanged("FK_ICProductAttributeHTTypeID");
                }
            }
        }
        public int FK_ICProductAttributeColorID
        {
            get { return _fK_ICProductAttributeColorID; }
            set
            {
                if (value != this._fK_ICProductAttributeColorID)
                {
                    _fK_ICProductAttributeColorID = value;
                    NotifyChanged("FK_ICProductAttributeColorID");
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
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        public String MMProposalItemProductType
        {
            get { return _mMProposalItemProductType; }
            set
            {
                if (value != this._mMProposalItemProductType)
                {
                    _mMProposalItemProductType = value;
                    NotifyChanged("MMProposalItemProductType");
                }
            }
        }
        public int MMProposalItemSortOrder
        {
            get { return _mMProposalItemSortOrder; }
            set
            {
                if (value != this._mMProposalItemSortOrder)
                {
                    _mMProposalItemSortOrder = value;
                    NotifyChanged("MMProposalItemSortOrder");
                }
            }
        }
        public String MMProposalItemProductNo
        {
            get { return _mMProposalItemProductNo; }
            set
            {
                if (value != this._mMProposalItemProductNo)
                {
                    _mMProposalItemProductNo = value;
                    NotifyChanged("MMProposalItemProductNo");
                }
            }
        }
        public String MMProposalItemProductName
        {
            get { return _mMProposalItemProductName; }
            set
            {
                if (value != this._mMProposalItemProductName)
                {
                    _mMProposalItemProductName = value;
                    NotifyChanged("MMProposalItemProductName");
                }
            }
        }
        public String MMProposalItemProductDesc
        {
            get { return _mMProposalItemProductDesc; }
            set
            {
                if (value != this._mMProposalItemProductDesc)
                {
                    _mMProposalItemProductDesc = value;
                    NotifyChanged("MMProposalItemProductDesc");
                }
            }
        }
        public decimal MMProposalItemProductQty
        {
            get { return _mMProposalItemProductQty; }
            set
            {
                if (value != this._mMProposalItemProductQty)
                {
                    _mMProposalItemProductQty = value;
                    NotifyChanged("MMProposalItemProductQty");
                }
            }
        }
        public String MMProposalItemComment
        {
            get { return _mMProposalItemComment; }
            set
            {
                if (value != this._mMProposalItemComment)
                {
                    _mMProposalItemComment = value;
                    NotifyChanged("MMProposalItemComment");
                }
            }
        }
        public String MMProposalItemStatus
        {
            get { return _mMProposalItemStatus; }
            set
            {
                if (value != this._mMProposalItemStatus)
                {
                    _mMProposalItemStatus = value;
                    NotifyChanged("MMProposalItemStatus");
                }
            }
        }
        public DateTime MMProposalItemDeliveryDate
        {
            get { return _mMProposalItemDeliveryDate; }
            set
            {
                if (value != this._mMProposalItemDeliveryDate)
                {
                    _mMProposalItemDeliveryDate = value;
                    NotifyChanged("MMProposalItemDeliveryDate");
                }
            }
        }
        public bool MMProposalItemIsNewProduct
        {
            get { return _mMProposalItemIsNewProduct; }
            set
            {
                if (value != this._mMProposalItemIsNewProduct)
                {
                    _mMProposalItemIsNewProduct = value;
                    NotifyChanged("MMProposalItemIsNewProduct");
                }
            }
        }
        public bool MMProposalItemIsJoinComponent
        {
            get { return _mMProposalItemIsJoinComponent; }
            set
            {
                if (value != this._mMProposalItemIsJoinComponent)
                {
                    _mMProposalItemIsJoinComponent = value;
                    NotifyChanged("MMProposalItemIsJoinComponent");
                }
            }
        }
        public String MMProposalItemHardwareRemark
        {
            get { return _mMProposalItemHardwareRemark; }
            set
            {
                if (value != this._mMProposalItemHardwareRemark)
                {
                    _mMProposalItemHardwareRemark = value;
                    NotifyChanged("MMProposalItemHardwareRemark");
                }
            }
        }
        public String MMProposalItemPackagingRequimentType
        {
            get { return _mMProposalItemPackagingRequimentType; }
            set
            {
                if (value != this._mMProposalItemPackagingRequimentType)
                {
                    _mMProposalItemPackagingRequimentType = value;
                    NotifyChanged("MMProposalItemPackagingRequimentType");
                }
            }
        }
        public bool MMProposalItemLabelCorlor
        {
            get { return _mMProposalItemLabelCorlor; }
            set
            {
                if (value != this._mMProposalItemLabelCorlor)
                {
                    _mMProposalItemLabelCorlor = value;
                    NotifyChanged("MMProposalItemLabelCorlor");
                }
            }
        }
        public bool MMProposalItemProductCard
        {
            get { return _mMProposalItemProductCard; }
            set
            {
                if (value != this._mMProposalItemProductCard)
                {
                    _mMProposalItemProductCard = value;
                    NotifyChanged("MMProposalItemProductCard");
                }
            }
        }
        public bool MMProposalItemProductFSCCard
        {
            get { return _mMProposalItemProductFSCCard; }
            set
            {
                if (value != this._mMProposalItemProductFSCCard)
                {
                    _mMProposalItemProductFSCCard = value;
                    NotifyChanged("MMProposalItemProductFSCCard");
                }
            }
        }
        public bool MMProposalItemProductLabel
        {
            get { return _mMProposalItemProductLabel; }
            set
            {
                if (value != this._mMProposalItemProductLabel)
                {
                    _mMProposalItemProductLabel = value;
                    NotifyChanged("MMProposalItemProductLabel");
                }
            }
        }
        public bool MMProposalItemProductHDLR
        {
            get { return _mMProposalItemProductHDLR; }
            set
            {
                if (value != this._mMProposalItemProductHDLR)
                {
                    _mMProposalItemProductHDLR = value;
                    NotifyChanged("MMProposalItemProductHDLR");
                }
            }
        }
        public bool MMProposalItemProductHDSD
        {
            get { return _mMProposalItemProductHDSD; }
            set
            {
                if (value != this._mMProposalItemProductHDSD)
                {
                    _mMProposalItemProductHDSD = value;
                    NotifyChanged("MMProposalItemProductHDSD");
                }
            }
        }
        public bool MMProposalItemProductBarcode
        {
            get { return _mMProposalItemProductBarcode; }
            set
            {
                if (value != this._mMProposalItemProductBarcode)
                {
                    _mMProposalItemProductBarcode = value;
                    NotifyChanged("MMProposalItemProductBarcode");
                }
            }
        }
        public bool MMProposalItemProductWarranty
        {
            get { return _mMProposalItemProductWarranty; }
            set
            {
                if (value != this._mMProposalItemProductWarranty)
                {
                    _mMProposalItemProductWarranty = value;
                    NotifyChanged("MMProposalItemProductWarranty");
                }
            }
        }
        public decimal MMProposalItemProductPerimeter
        {
            get { return _mMProposalItemProductPerimeter; }
            set
            {
                if (value != this._mMProposalItemProductPerimeter)
                {
                    _mMProposalItemProductPerimeter = value;
                    NotifyChanged("MMProposalItemProductPerimeter");
                }
            }
        }
        public decimal MMProposalItemProductHeight
        {
            get { return _mMProposalItemProductHeight; }
            set
            {
                if (value != this._mMProposalItemProductHeight)
                {
                    _mMProposalItemProductHeight = value;
                    NotifyChanged("MMProposalItemProductHeight");
                }
            }
        }
        public decimal MMProposalItemProductWidth
        {
            get { return _mMProposalItemProductWidth; }
            set
            {
                if (value != this._mMProposalItemProductWidth)
                {
                    _mMProposalItemProductWidth = value;
                    NotifyChanged("MMProposalItemProductWidth");
                }
            }
        }
        public decimal MMProposalItemProductLength
        {
            get { return _mMProposalItemProductLength; }
            set
            {
                if (value != this._mMProposalItemProductLength)
                {
                    _mMProposalItemProductLength = value;
                    NotifyChanged("MMProposalItemProductLength");
                }
            }
        }
        public decimal MMProposalItemProductMinHeight
        {
            get { return _mMProposalItemProductMinHeight; }
            set
            {
                if (value != this._mMProposalItemProductMinHeight)
                {
                    _mMProposalItemProductMinHeight = value;
                    NotifyChanged("MMProposalItemProductMinHeight");
                }
            }
        }
        public decimal MMProposalItemProductMinWidth
        {
            get { return _mMProposalItemProductMinWidth; }
            set
            {
                if (value != this._mMProposalItemProductMinWidth)
                {
                    _mMProposalItemProductMinWidth = value;
                    NotifyChanged("MMProposalItemProductMinWidth");
                }
            }
        }
        public decimal MMProposalItemProductMinLength
        {
            get { return _mMProposalItemProductMinLength; }
            set
            {
                if (value != this._mMProposalItemProductMinLength)
                {
                    _mMProposalItemProductMinLength = value;
                    NotifyChanged("MMProposalItemProductMinLength");
                }
            }
        }
        public decimal MMProposalItemProductMaxHeight
        {
            get { return _mMProposalItemProductMaxHeight; }
            set
            {
                if (value != this._mMProposalItemProductMaxHeight)
                {
                    _mMProposalItemProductMaxHeight = value;
                    NotifyChanged("MMProposalItemProductMaxHeight");
                }
            }
        }
        public decimal MMProposalItemProductMaxWidth
        {
            get { return _mMProposalItemProductMaxWidth; }
            set
            {
                if (value != this._mMProposalItemProductMaxWidth)
                {
                    _mMProposalItemProductMaxWidth = value;
                    NotifyChanged("MMProposalItemProductMaxWidth");
                }
            }
        }
        public decimal MMProposalItemProductMaxLength
        {
            get { return _mMProposalItemProductMaxLength; }
            set
            {
                if (value != this._mMProposalItemProductMaxLength)
                {
                    _mMProposalItemProductMaxLength = value;
                    NotifyChanged("MMProposalItemProductMaxLength");
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
        public String MMProposalItemProductAttributeColor
        {
            get { return _mMProposalItemProductAttributeColor; }
            set
            {
                if (value != this._mMProposalItemProductAttributeColor)
                {
                    _mMProposalItemProductAttributeColor = value;
                    NotifyChanged("MMProposalItemProductAttributeColor");
                }
            }
        }
        public String MMProposalItemProductAttributeHTType
        {
            get { return _mMProposalItemProductAttributeHTType; }
            set
            {
                if (value != this._mMProposalItemProductAttributeHTType)
                {
                    _mMProposalItemProductAttributeHTType = value;
                    NotifyChanged("MMProposalItemProductAttributeHTType");
                }
            }
        }
        public String MMProposalItemWoodTypeID
        {
            get { return _mMProposalItemWoodTypeID; }
            set
            {
                if (value != this._mMProposalItemWoodTypeID)
                {
                    _mMProposalItemWoodTypeID = value;
                    NotifyChanged("MMProposalItemWoodTypeID");
                }
            }
        }
        public String MMProposalItemWoodTypeText
        {
            get { return _mMProposalItemWoodTypeText; }
            set
            {
                if (value != this._mMProposalItemWoodTypeText)
                {
                    _mMProposalItemWoodTypeText = value;
                    NotifyChanged("MMProposalItemWoodTypeText");
                }
            }
        }
        public String MMProposalItemColorID
        {
            get { return _mMProposalItemColorID; }
            set
            {
                if (value != this._mMProposalItemColorID)
                {
                    _mMProposalItemColorID = value;
                    NotifyChanged("MMProposalItemColorID");
                }
            }
        }
        public String MMProposalItemHTID
        {
            get { return _mMProposalItemHTID; }
            set
            {
                if (value != this._mMProposalItemHTID)
                {
                    _mMProposalItemHTID = value;
                    NotifyChanged("MMProposalItemHTID");
                }
            }
        }
        public String MMProposalItemPONo
        {
            get { return _mMProposalItemPONo; }
            set
            {
                if (value != this._mMProposalItemPONo)
                {
                    _mMProposalItemPONo = value;
                    NotifyChanged("MMProposalItemPONo");
                }
            }
        }
        public decimal MMProposalItemProductCanceledQty
        {
            get { return _mMProposalItemProductCanceledQty; }
            set
            {
                if (value != this._mMProposalItemProductCanceledQty)
                {
                    _mMProposalItemProductCanceledQty = value;
                    NotifyChanged("MMProposalItemProductCanceledQty");
                }
            }
        }
        public decimal MMProposalItemProductUnitPrice
        {
            get { return _mMProposalItemProductUnitPrice; }
            set
            {
                if (value != this._mMProposalItemProductUnitPrice)
                {
                    _mMProposalItemProductUnitPrice = value;
                    NotifyChanged("MMProposalItemProductUnitPrice");
                }
            }
        }
        public decimal MMProposalItemTotalAmount
        {
            get { return _mMProposalItemTotalAmount; }
            set
            {
                if (value != this._mMProposalItemTotalAmount)
                {
                    _mMProposalItemTotalAmount = value;
                    NotifyChanged("MMProposalItemTotalAmount");
                }
            }
        }

        #endregion

        #region Extra Propoerty
        public string ARSaleOrderNo { get; set; }

        public string ACObjectName { get; set; }

        public string MMProposalPONo { get; set; }

        public string ARInvoiceNo { get; set; }

        public string MMProposalNo { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public float MMProposalItemHeight { get; set; }

        public string MMProposalItemBOMStatus { get; set; }

        public string MMProposalDesc { get; set; }

        public long MMProposalItemRowNumber { get; set; }

        public DateTime MMProposalDate { get; set; }

        public string MMProposalFromType { get; set; }

        public string HREmployeeName { get; set; }

        public string BRBranchName { get; set; }

        public string ARSaleOrderSaleAgreement { get; set; }

        public decimal ARSaleOrderItemProductQty { get; set; }

        public decimal ARSaleOrderItemCanceledQty { get; set; }

        public string ICProductType { get; set; }
        public int FK_MMProductionNormID { get; set; }
        #endregion
    }
    #endregion
}