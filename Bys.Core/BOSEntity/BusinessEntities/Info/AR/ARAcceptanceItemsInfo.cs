﻿using BOSLib;
using System;
using System.Collections.Generic;
namespace BOSERP
{
    #region ARAcceptanceItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARAcceptanceItemsInfo
    //Created Date:Wednesday, September 26, 2018
    //-----------------------------------------------------------

    public class ARAcceptanceItemsInfo : BusinessObject
    {
        public ARAcceptanceItemsInfo()
        {
        }
        #region Variables
        protected int _aRAcceptanceItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARAcceptanceID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _aRAcceptanceItemProductType = String.Empty;
        protected String _aRAcceptanceItemProductName = String.Empty;
        protected String _aRAcceptanceItemProductDesc = String.Empty;
        protected decimal _aRAcceptanceItemProductQty;
        protected String _aRAcceptanceItemDesc = String.Empty;
        protected String _aRAcceptanceItemSaleOrderType = String.Empty;
        protected decimal _aRAcceptanceItemSaleOrderQty;
        protected decimal _aRAcceptanceItemShippedQty;
        protected decimal _aRAcceptanceItemLength;
        protected decimal _aRAcceptanceItemWidth;
        protected decimal _aRAcceptanceItemHeight;
        protected decimal _aRAcceptanceItemProductUnitPrice;
        protected decimal _aRAcceptanceItemPrice;
        protected decimal _aRAcceptanceItemProductDiscount;
        protected decimal _aRAcceptanceItemDiscountAmount;
        protected decimal _aRAcceptanceItemTotalAmount;
        protected decimal _aRAcceptanceItemProductTaxPercent;
        protected decimal _aRAcceptanceItemTaxAmount;
        protected int _fK_ICShipmentItemID;
        protected int _fK_ICShipmentID;
        protected int _fK_ICStockID;
        protected String _aRAcceptanceItemOneLevelArea = String.Empty;
        protected String _aRAcceptanceItemTwoLevelArea = String.Empty;
        protected String _aRAcceptanceItemThreeLevelArea = String.Empty;
        protected int _fK_ICSectionProductID;
        protected int _fK_ACCostCenterID;
        protected int _fK_PMTemplateItemID;
        protected decimal _aRAcceptanceItemSOLength;
        protected decimal _aRAcceptanceItemSOWidth;
        protected decimal _aRAcceptanceItemSOHeight;
        protected int _fK_ARProposalTemplateItemID;
        #endregion

        #region Public properties
        public int ARAcceptanceItemID
        {
            get { return _aRAcceptanceItemID; }
            set
            {
                if (value != this._aRAcceptanceItemID)
                {
                    _aRAcceptanceItemID = value;
                    NotifyChanged("ARAcceptanceItemID");
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
        public int FK_ARAcceptanceID
        {
            get { return _fK_ARAcceptanceID; }
            set
            {
                if (value != this._fK_ARAcceptanceID)
                {
                    _fK_ARAcceptanceID = value;
                    NotifyChanged("FK_ARAcceptanceID");
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
        public String ARAcceptanceItemProductType
        {
            get { return _aRAcceptanceItemProductType; }
            set
            {
                if (value != this._aRAcceptanceItemProductType)
                {
                    _aRAcceptanceItemProductType = value;
                    NotifyChanged("ARAcceptanceItemProductType");
                }
            }
        }
        public String ARAcceptanceItemProductName
        {
            get { return _aRAcceptanceItemProductName; }
            set
            {
                if (value != this._aRAcceptanceItemProductName)
                {
                    _aRAcceptanceItemProductName = value;
                    NotifyChanged("ARAcceptanceItemProductName");
                }
            }
        }
        public String ARAcceptanceItemProductDesc
        {
            get { return _aRAcceptanceItemProductDesc; }
            set
            {
                if (value != this._aRAcceptanceItemProductDesc)
                {
                    _aRAcceptanceItemProductDesc = value;
                    NotifyChanged("ARAcceptanceItemProductDesc");
                }
            }
        }
        public decimal ARAcceptanceItemProductQty
        {
            get { return _aRAcceptanceItemProductQty; }
            set
            {
                if (value != this._aRAcceptanceItemProductQty)
                {
                    _aRAcceptanceItemProductQty = value;
                    NotifyChanged("ARAcceptanceItemProductQty");
                }
            }
        }
        public String ARAcceptanceItemDesc
        {
            get { return _aRAcceptanceItemDesc; }
            set
            {
                if (value != this._aRAcceptanceItemDesc)
                {
                    _aRAcceptanceItemDesc = value;
                    NotifyChanged("ARAcceptanceItemDesc");
                }
            }
        }
        public String ARAcceptanceItemSaleOrderType
        {
            get { return _aRAcceptanceItemSaleOrderType; }
            set
            {
                if (value != this._aRAcceptanceItemSaleOrderType)
                {
                    _aRAcceptanceItemSaleOrderType = value;
                    NotifyChanged("ARAcceptanceItemSaleOrderType");
                }
            }
        }
        public decimal ARAcceptanceItemSaleOrderQty
        {
            get { return _aRAcceptanceItemSaleOrderQty; }
            set
            {
                if (value != this._aRAcceptanceItemSaleOrderQty)
                {
                    _aRAcceptanceItemSaleOrderQty = value;
                    NotifyChanged("ARAcceptanceItemSaleOrderQty");
                }
            }
        }
        public decimal ARAcceptanceItemShippedQty
        {
            get { return _aRAcceptanceItemShippedQty; }
            set
            {
                if (value != this._aRAcceptanceItemShippedQty)
                {
                    _aRAcceptanceItemShippedQty = value;
                    NotifyChanged("ARAcceptanceItemShippedQty");
                }
            }
        }
        public decimal ARAcceptanceItemLength
        {
            get { return _aRAcceptanceItemLength; }
            set
            {
                if (value != this._aRAcceptanceItemLength)
                {
                    _aRAcceptanceItemLength = value;
                    NotifyChanged("ARAcceptanceItemLength");
                }
            }
        }
        public decimal ARAcceptanceItemWidth
        {
            get { return _aRAcceptanceItemWidth; }
            set
            {
                if (value != this._aRAcceptanceItemWidth)
                {
                    _aRAcceptanceItemWidth = value;
                    NotifyChanged("ARAcceptanceItemWidth");
                }
            }
        }
        public decimal ARAcceptanceItemHeight
        {
            get { return _aRAcceptanceItemHeight; }
            set
            {
                if (value != this._aRAcceptanceItemHeight)
                {
                    _aRAcceptanceItemHeight = value;
                    NotifyChanged("ARAcceptanceItemHeight");
                }
            }
        }
        public decimal ARAcceptanceItemProductUnitPrice
        {
            get { return _aRAcceptanceItemProductUnitPrice; }
            set
            {
                if (value != this._aRAcceptanceItemProductUnitPrice)
                {
                    _aRAcceptanceItemProductUnitPrice = value;
                    NotifyChanged("ARAcceptanceItemProductUnitPrice");
                }
            }
        }
        public decimal ARAcceptanceItemPrice
        {
            get { return _aRAcceptanceItemPrice; }
            set
            {
                if (value != this._aRAcceptanceItemPrice)
                {
                    _aRAcceptanceItemPrice = value;
                    NotifyChanged("ARAcceptanceItemPrice");
                }
            }
        }
        public decimal ARAcceptanceItemProductDiscount
        {
            get { return _aRAcceptanceItemProductDiscount; }
            set
            {
                if (value != this._aRAcceptanceItemProductDiscount)
                {
                    _aRAcceptanceItemProductDiscount = value;
                    NotifyChanged("ARAcceptanceItemProductDiscount");
                }
            }
        }
        public decimal ARAcceptanceItemDiscountAmount
        {
            get { return _aRAcceptanceItemDiscountAmount; }
            set
            {
                if (value != this._aRAcceptanceItemDiscountAmount)
                {
                    _aRAcceptanceItemDiscountAmount = value;
                    NotifyChanged("ARAcceptanceItemDiscountAmount");
                }
            }
        }
        public decimal ARAcceptanceItemTotalAmount
        {
            get { return _aRAcceptanceItemTotalAmount; }
            set
            {
                if (value != this._aRAcceptanceItemTotalAmount)
                {
                    _aRAcceptanceItemTotalAmount = value;
                    NotifyChanged("ARAcceptanceItemTotalAmount");
                }
            }
        }
        public decimal ARAcceptanceItemProductTaxPercent
        {
            get { return _aRAcceptanceItemProductTaxPercent; }
            set
            {
                if (value != this._aRAcceptanceItemProductTaxPercent)
                {
                    _aRAcceptanceItemProductTaxPercent = value;
                    NotifyChanged("ARAcceptanceItemProductTaxPercent");
                }
            }
        }
        public decimal ARAcceptanceItemTaxAmount
        {
            get { return _aRAcceptanceItemTaxAmount; }
            set
            {
                if (value != this._aRAcceptanceItemTaxAmount)
                {
                    _aRAcceptanceItemTaxAmount = value;
                    NotifyChanged("ARAcceptanceItemTaxAmount");
                }
            }
        }
        public int FK_ICShipmentItemID
        {
            get { return _fK_ICShipmentItemID; }
            set
            {
                if (value != this._fK_ICShipmentItemID)
                {
                    _fK_ICShipmentItemID = value;
                    NotifyChanged("FK_ICShipmentItemID");
                }
            }
        }
        public int FK_ICShipmentID
        {
            get { return _fK_ICShipmentID; }
            set
            {
                if (value != this._fK_ICShipmentID)
                {
                    _fK_ICShipmentID = value;
                    NotifyChanged("FK_ICShipmentID");
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
        public String ARAcceptanceItemOneLevelArea
        {
            get { return _aRAcceptanceItemOneLevelArea; }
            set
            {
                if (value != this._aRAcceptanceItemOneLevelArea)
                {
                    _aRAcceptanceItemOneLevelArea = value;
                    NotifyChanged("ARAcceptanceItemOneLevelArea");
                }
            }
        }
        public String ARAcceptanceItemTwoLevelArea
        {
            get { return _aRAcceptanceItemTwoLevelArea; }
            set
            {
                if (value != this._aRAcceptanceItemTwoLevelArea)
                {
                    _aRAcceptanceItemTwoLevelArea = value;
                    NotifyChanged("ARAcceptanceItemTwoLevelArea");
                }
            }
        }
        public String ARAcceptanceItemThreeLevelArea
        {
            get { return _aRAcceptanceItemThreeLevelArea; }
            set
            {
                if (value != this._aRAcceptanceItemThreeLevelArea)
                {
                    _aRAcceptanceItemThreeLevelArea = value;
                    NotifyChanged("ARAcceptanceItemThreeLevelArea");
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
        public decimal ARAcceptanceItemSOLength
        {
            get { return _aRAcceptanceItemSOLength; }
            set
            {
                if (value != this._aRAcceptanceItemSOLength)
                {
                    _aRAcceptanceItemSOLength = value;
                    NotifyChanged("ARAcceptanceItemSOLength");
                }
            }
        }
        public decimal ARAcceptanceItemSOWidth
        {
            get { return _aRAcceptanceItemSOWidth; }
            set
            {
                if (value != this._aRAcceptanceItemSOWidth)
                {
                    _aRAcceptanceItemSOWidth = value;
                    NotifyChanged("ARAcceptanceItemSOWidth");
                }
            }
        }
        public decimal ARAcceptanceItemSOHeight
        {
            get { return _aRAcceptanceItemSOHeight; }
            set
            {
                if (value != this._aRAcceptanceItemSOHeight)
                {
                    _aRAcceptanceItemSOHeight = value;
                    NotifyChanged("ARAcceptanceItemSOHeight");
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
        #endregion

        #region Extra property

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARAcceptanceItemRemainedQty { get; set; }

        public string ICMeasureUnitName { get; set; }

        public string ICDepartmentName { get; set; }

        public string DepartmentRowNumber { get; set; }

        public string RowNumber { get; set; }

        public string ICProductSize { get; set; }

        public string ARProposalName { get; set; }

        //public decimal  ARAcceptanceItemProductUnitPrice {get;set;}

        //public decimal ARAcceptanceItemPrice { get; set; }

        public string ARAcceptanceItemProductQtyText { get; set; }

        public string CSCompanyName { get; set; }
        public string CSCompanyAddress { get; set; }
        public string CSCompanyContact { get; set; }

        public string PMTemplateItemProductName { get; set; }

        public string ARAcceptanceItemColumnChangedName { get; set; }

        public List<String> ARAcceptanceItemColumnChangedNames = new List<String>();

        public String ARProposalTemplateItemProductName { get; set; }

        #endregion
    }
    #endregion
}