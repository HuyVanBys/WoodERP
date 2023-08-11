﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMAllocationProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMAllocationProposalItemsInfo
    //Created Date:26 November 2018
    //-----------------------------------------------------------

    public class MMAllocationProposalItemsInfo : BusinessObject
    {
        public MMAllocationProposalItemsInfo()
        {
        }
        #region Variables
        protected int _mMAllocationProposalItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMAllocationProposalID;
        protected int _fK_ICProductID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMOperationID;
        protected int _fK_MMAllocationPlanID;
        protected int _fK_MMAllocationPlanItemID;
        protected int _fK_ICProductForBatchID;
        protected String _mMAllocationProposalItemProductName = String.Empty;
        protected String _mMAllocationProposalItemProductDesc = String.Empty;
        protected decimal _mMAllocationProposalItemHeight;
        protected decimal _mMAllocationProposalItemWidth;
        protected decimal _mMAllocationProposalItemLength;
        protected decimal _mMAllocationProposalItemHeightMin;
        protected decimal _mMAllocationProposalItemWidthMin;
        protected decimal _mMAllocationProposalItemLengthMin;
        protected decimal _mMAllocationProposalItemHeightMax;
        protected decimal _mMAllocationProposalItemWidthMax;
        protected decimal _mMAllocationProposalItemLengthMax;
        protected decimal _mMAllocationProposalItemQty;
        protected decimal _mMAllocationProposalItemWoodQty;
        protected decimal _mMAllocationProposalItemShippedQty;
        protected String _mMAllocationProposalItemComment = String.Empty;
        protected decimal _mMAllocationProposalItemShippedWoodQty;
        protected int _fK_ICProductAttributeTTMTID;
        protected decimal _mMAllocationProposalItemProductPerimeter;
        protected decimal _mMAllocationProposalItemCanceledQty;
        protected int _fK_ICStockID;
        protected int _fK_ICProductSerieID;
        protected int _fK_GECountryID;
        protected String _mMAllocationProposalItemProductSerialNo = String.Empty;
        protected String _mMAllocationProposalItemLotNo = String.Empty;
        protected String _mMAllocationProposalItemHWQtySource = String.Empty;
        protected decimal _mMAllocationProposalItemBPProductionNormItemQty;
        protected int _fK_MMBatchProductItemID;
        protected String _mMAllocationProposalItemBatchProductItemProductSerial = String.Empty;
        protected int _fK_ICProductAttributeQualityID;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected String _mMAllocationProposalItemProductSupplierNumber = String.Empty;
        protected String _mMAllocationProposalItemStatus = DefaultStatus;
        protected int _fK_ICModelID;
        protected int _fK_ICModelDetailID;
        protected bool _mMAllocationProposalItemIsReuse = true;
        protected decimal _mMAllocationProposalItemWaste;
        protected decimal _mMAllocationProposalItemCanceledWoodQty;
        protected int _fK_ACMaintainProposalItemNeedID;
        protected int _fK_ACDeviceItemPlanID;
        #endregion

        #region Public properties
        public int MMAllocationProposalItemID
        {
            get { return _mMAllocationProposalItemID; }
            set
            {
                if (value != this._mMAllocationProposalItemID)
                {
                    _mMAllocationProposalItemID = value;
                    NotifyChanged("MMAllocationProposalItemID");
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
        public int FK_MMAllocationProposalID
        {
            get { return _fK_MMAllocationProposalID; }
            set
            {
                if (value != this._fK_MMAllocationProposalID)
                {
                    _fK_MMAllocationProposalID = value;
                    NotifyChanged("FK_MMAllocationProposalID");
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
        public int FK_MMAllocationPlanID
        {
            get { return _fK_MMAllocationPlanID; }
            set
            {
                if (value != this._fK_MMAllocationPlanID)
                {
                    _fK_MMAllocationPlanID = value;
                    NotifyChanged("FK_MMAllocationPlanID");
                }
            }
        }
        public int FK_MMAllocationPlanItemID
        {
            get { return _fK_MMAllocationPlanItemID; }
            set
            {
                if (value != this._fK_MMAllocationPlanItemID)
                {
                    _fK_MMAllocationPlanItemID = value;
                    NotifyChanged("FK_MMAllocationPlanItemID");
                }
            }
        }
        public int FK_ICProductForBatchID
        {
            get { return _fK_ICProductForBatchID; }
            set
            {
                if (value != this._fK_ICProductForBatchID)
                {
                    _fK_ICProductForBatchID = value;
                    NotifyChanged("FK_ICProductForBatchID");
                }
            }
        }
        public String MMAllocationProposalItemProductName
        {
            get { return _mMAllocationProposalItemProductName; }
            set
            {
                if (value != this._mMAllocationProposalItemProductName)
                {
                    _mMAllocationProposalItemProductName = value;
                    NotifyChanged("MMAllocationProposalItemProductName");
                }
            }
        }
        public String MMAllocationProposalItemProductDesc
        {
            get { return _mMAllocationProposalItemProductDesc; }
            set
            {
                if (value != this._mMAllocationProposalItemProductDesc)
                {
                    _mMAllocationProposalItemProductDesc = value;
                    NotifyChanged("MMAllocationProposalItemProductDesc");
                }
            }
        }
        public decimal MMAllocationProposalItemHeight
        {
            get { return _mMAllocationProposalItemHeight; }
            set
            {
                if (value != this._mMAllocationProposalItemHeight)
                {
                    _mMAllocationProposalItemHeight = value;
                    NotifyChanged("MMAllocationProposalItemHeight");
                }
            }
        }
        public decimal MMAllocationProposalItemWidth
        {
            get { return _mMAllocationProposalItemWidth; }
            set
            {
                if (value != this._mMAllocationProposalItemWidth)
                {
                    _mMAllocationProposalItemWidth = value;
                    NotifyChanged("MMAllocationProposalItemWidth");
                }
            }
        }
        public decimal MMAllocationProposalItemLength
        {
            get { return _mMAllocationProposalItemLength; }
            set
            {
                if (value != this._mMAllocationProposalItemLength)
                {
                    _mMAllocationProposalItemLength = value;
                    NotifyChanged("MMAllocationProposalItemLength");
                }
            }
        }
        public decimal MMAllocationProposalItemHeightMin
        {
            get { return _mMAllocationProposalItemHeightMin; }
            set
            {
                if (value != this._mMAllocationProposalItemHeightMin)
                {
                    _mMAllocationProposalItemHeightMin = value;
                    NotifyChanged("MMAllocationProposalItemHeightMin");
                }
            }
        }
        public decimal MMAllocationProposalItemWidthMin
        {
            get { return _mMAllocationProposalItemWidthMin; }
            set
            {
                if (value != this._mMAllocationProposalItemWidthMin)
                {
                    _mMAllocationProposalItemWidthMin = value;
                    NotifyChanged("MMAllocationProposalItemWidthMin");
                }
            }
        }
        public decimal MMAllocationProposalItemLengthMin
        {
            get { return _mMAllocationProposalItemLengthMin; }
            set
            {
                if (value != this._mMAllocationProposalItemLengthMin)
                {
                    _mMAllocationProposalItemLengthMin = value;
                    NotifyChanged("MMAllocationProposalItemLengthMin");
                }
            }
        }
        public decimal MMAllocationProposalItemHeightMax
        {
            get { return _mMAllocationProposalItemHeightMax; }
            set
            {
                if (value != this._mMAllocationProposalItemHeightMax)
                {
                    _mMAllocationProposalItemHeightMax = value;
                    NotifyChanged("MMAllocationProposalItemHeightMax");
                }
            }
        }
        public decimal MMAllocationProposalItemWidthMax
        {
            get { return _mMAllocationProposalItemWidthMax; }
            set
            {
                if (value != this._mMAllocationProposalItemWidthMax)
                {
                    _mMAllocationProposalItemWidthMax = value;
                    NotifyChanged("MMAllocationProposalItemWidthMax");
                }
            }
        }
        public decimal MMAllocationProposalItemLengthMax
        {
            get { return _mMAllocationProposalItemLengthMax; }
            set
            {
                if (value != this._mMAllocationProposalItemLengthMax)
                {
                    _mMAllocationProposalItemLengthMax = value;
                    NotifyChanged("MMAllocationProposalItemLengthMax");
                }
            }
        }
        public decimal MMAllocationProposalItemQty
        {
            get { return _mMAllocationProposalItemQty; }
            set
            {
                if (value != this._mMAllocationProposalItemQty)
                {
                    _mMAllocationProposalItemQty = value;
                    NotifyChanged("MMAllocationProposalItemQty");
                }
            }
        }
        public decimal MMAllocationProposalItemWoodQty
        {
            get { return _mMAllocationProposalItemWoodQty; }
            set
            {
                if (value != this._mMAllocationProposalItemWoodQty)
                {
                    _mMAllocationProposalItemWoodQty = value;
                    NotifyChanged("MMAllocationProposalItemWoodQty");
                }
            }
        }
        public decimal MMAllocationProposalItemShippedQty
        {
            get { return _mMAllocationProposalItemShippedQty; }
            set
            {
                if (value != this._mMAllocationProposalItemShippedQty)
                {
                    _mMAllocationProposalItemShippedQty = value;
                    NotifyChanged("MMAllocationProposalItemShippedQty");
                }
            }
        }
        public String MMAllocationProposalItemComment
        {
            get { return _mMAllocationProposalItemComment; }
            set
            {
                if (value != this._mMAllocationProposalItemComment)
                {
                    _mMAllocationProposalItemComment = value;
                    NotifyChanged("MMAllocationProposalItemComment");
                }
            }
        }
        public decimal MMAllocationProposalItemShippedWoodQty
        {
            get { return _mMAllocationProposalItemShippedWoodQty; }
            set
            {
                if (value != this._mMAllocationProposalItemShippedWoodQty)
                {
                    _mMAllocationProposalItemShippedWoodQty = value;
                    NotifyChanged("MMAllocationProposalItemShippedWoodQty");
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
        public decimal MMAllocationProposalItemProductPerimeter
        {
            get { return _mMAllocationProposalItemProductPerimeter; }
            set
            {
                if (value != this._mMAllocationProposalItemProductPerimeter)
                {
                    _mMAllocationProposalItemProductPerimeter = value;
                    NotifyChanged("MMAllocationProposalItemProductPerimeter");
                }
            }
        }
        public decimal MMAllocationProposalItemCanceledQty
        {
            get { return _mMAllocationProposalItemCanceledQty; }
            set
            {
                if (value != this._mMAllocationProposalItemCanceledQty)
                {
                    _mMAllocationProposalItemCanceledQty = value;
                    NotifyChanged("MMAllocationProposalItemCanceledQty");
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
        public String MMAllocationProposalItemProductSerialNo
        {
            get { return _mMAllocationProposalItemProductSerialNo; }
            set
            {
                if (value != this._mMAllocationProposalItemProductSerialNo)
                {
                    _mMAllocationProposalItemProductSerialNo = value;
                    NotifyChanged("MMAllocationProposalItemProductSerialNo");
                }
            }
        }
        public String MMAllocationProposalItemLotNo
        {
            get { return _mMAllocationProposalItemLotNo; }
            set
            {
                if (value != this._mMAllocationProposalItemLotNo)
                {
                    _mMAllocationProposalItemLotNo = value;
                    NotifyChanged("MMAllocationProposalItemLotNo");
                }
            }
        }
        public String MMAllocationProposalItemHWQtySource
        {
            get { return _mMAllocationProposalItemHWQtySource; }
            set
            {
                if (value != this._mMAllocationProposalItemHWQtySource)
                {
                    _mMAllocationProposalItemHWQtySource = value;
                    NotifyChanged("MMAllocationProposalItemHWQtySource");
                }
            }
        }
        public decimal MMAllocationProposalItemBPProductionNormItemQty
        {
            get { return _mMAllocationProposalItemBPProductionNormItemQty; }
            set
            {
                if (value != this._mMAllocationProposalItemBPProductionNormItemQty)
                {
                    _mMAllocationProposalItemBPProductionNormItemQty = value;
                    NotifyChanged("MMAllocationProposalItemBPProductionNormItemQty");
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
        public String MMAllocationProposalItemBatchProductItemProductSerial
        {
            get { return _mMAllocationProposalItemBatchProductItemProductSerial; }
            set
            {
                if (value != this._mMAllocationProposalItemBatchProductItemProductSerial)
                {
                    _mMAllocationProposalItemBatchProductItemProductSerial = value;
                    NotifyChanged("MMAllocationProposalItemBatchProductItemProductSerial");
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
        public String MMAllocationProposalItemProductSupplierNumber
        {
            get { return _mMAllocationProposalItemProductSupplierNumber; }
            set
            {
                if (value != this._mMAllocationProposalItemProductSupplierNumber)
                {
                    _mMAllocationProposalItemProductSupplierNumber = value;
                    NotifyChanged("MMAllocationProposalItemProductSupplierNumber");
                }
            }
        }
        public String MMAllocationProposalItemStatus
        {
            get { return _mMAllocationProposalItemStatus; }
            set
            {
                if (value != this._mMAllocationProposalItemStatus)
                {
                    _mMAllocationProposalItemStatus = value;
                    NotifyChanged("MMAllocationProposalItemStatus");
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
        public bool MMAllocationProposalItemIsReuse
        {
            get { return _mMAllocationProposalItemIsReuse; }
            set
            {
                if (value != this._mMAllocationProposalItemIsReuse)
                {
                    _mMAllocationProposalItemIsReuse = value;
                    NotifyChanged("MMAllocationProposalItemIsReuse");
                }
            }
        }
        public decimal MMAllocationProposalItemWaste
        {
            get { return _mMAllocationProposalItemWaste; }
            set
            {
                if (value != this._mMAllocationProposalItemWaste)
                {
                    _mMAllocationProposalItemWaste = value;
                    NotifyChanged("MMAllocationProposalItemWaste");
                }
            }
        }
        public decimal MMAllocationProposalItemCanceledWoodQty
        {
            get { return _mMAllocationProposalItemCanceledWoodQty; }
            set
            {
                if (value != this._mMAllocationProposalItemCanceledWoodQty)
                {
                    _mMAllocationProposalItemCanceledWoodQty = value;
                    NotifyChanged("MMAllocationProposalItemCanceledWoodQty");
                }
            }
        }
        public int FK_ACMaintainProposalItemNeedID
        {
            get { return _fK_ACMaintainProposalItemNeedID; }
            set
            {
                if (value != this._fK_ACMaintainProposalItemNeedID)
                {
                    _fK_ACMaintainProposalItemNeedID = value;
                    NotifyChanged("FK_ACMaintainProposalItemNeedID");
                }
            }
        }
        public int FK_ACDeviceItemPlanID
        {
            get { return _fK_ACDeviceItemPlanID; }
            set
            {
                if (value != this._fK_ACDeviceItemPlanID)
                {
                    _fK_ACDeviceItemPlanID = value;
                    NotifyChanged("FK_ACDeviceItemPlanID");
                }
            }
        }
        #endregion

        #region Extra properties
        public string MMAllocationProposalNo { get; set; }
        public string MMAllocationProposalProductType { get; set; }
        public string MMBatchProductNo { get; set; }
        public decimal MMAllocationProposalProductQtyRemain { get; set; }
        public string MMAllocationProposalProposedEmployeeName { get; set; }
        public decimal MMAllocationProposalItemRemainQty { get; set; }
        public int FK_MMBatchProductIDInAllocation { get; set; }
        public int FK_MMOperationIDInAllocation { get; set; }
        public int FK_ICProductAttributeTTMTIDInAllocation { get; set; }
        public int FK_ACAccountID { get; set; }
        public decimal ICInventoryStockUnitCost { get; set; }
        public string HREmployeeName { get; set; } //nhân viên
        public string HREmployeeName1 { get; set; } // người nhận
        public string HRDepartmentName { get; set; } // phòng ban
        public string HRDepartmentRoomName { get; set; } //bộ phận
        public string ADConfigText { get; set; } // loại đề nghị
        public DateTime MMAllocationProposalDate { get; set; }
        public string ARSaleOrderNo { get; set; }
        public string MMAllocationProposalItemProductNo { get; set; }
        public string MMAllocationProposalItemProductForBatchNo { get; set; }
        public string MMAllocationProposalItemAttributeQualityValue { get; set; }
        public string MMAllocationProposalItemAttributeWoodTypeValue { get; set; }
        public decimal MMAllocationProposalItemDepreciationRate { get; set; }
        public decimal MMAllocationProposalItemBatchProductItemBlock { get; set; }
        public decimal MMAllocationProposalItemBatchProductItemQty { get; set; }
        public decimal MMAllocationProposalItemBOMBlock { get; set; }
        public string ICMeasureUnitName { get; set; }
        public string ICProductType { get; set; }
        #endregion

        public decimal MMAllocationPlanItemQty { get; set; }
        public decimal MMWoodPlanItemDetailQuantity { get; set; }
        public DateTime MMAllocationProposalProposedDate { get; set; }

        //MaintainProposal
        public string ACDeviceNo { get; set; }
        public string ACDeviceItemNo { get; set; }
        public string ACErrorName { get; set; }
        public string ACMaintainTypeConfigName { get; set; }
        public string ACDeviceName { get; set; }
        public string ACDeviceItemName { get; set; }
        public string ACMaintainProposalNo { get; set; }
        public string MMAllocationProposalPONo { get; set; }
        public int FK_ARCustomerID { get; set; }
        public decimal MMAllocationProposalItemProductFactor { get; set; }

    }
    #endregion
}