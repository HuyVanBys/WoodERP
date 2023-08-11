using BOSLib;
using System;
namespace BOSERP
{
    #region MMPurchasePlanItemTotals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMPurchasePlanItemTotalsInfo
    //Created Date:17 October 2018
    //-----------------------------------------------------------

    public class MMPurchasePlanItemTotalsInfo : BusinessObject
    {
        public MMPurchasePlanItemTotalsInfo()
        {
        }
        #region Variables
        protected int _mMPurchasePlanItemTotalID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMPurchasePlanID;
        protected int _fK_ICProductID;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProductAttributeTTMTID;
        protected String _mMPurchasePlanItemTotalPurchaseType = String.Empty;
        protected decimal _mMPurchasePlanItemTotalWoodPlanQuantity;
        protected decimal _mMPurchasePlanItemTotalQuantity;
        protected String _mMPurchasePlanItemTotalProductName = String.Empty;
        protected String _mMPurchasePlanItemTotalProductDesc = String.Empty;
        protected decimal _mMPurchasePlanItemTotalProductHeight;
        protected decimal _mMPurchasePlanItemTotalProductWidth;
        protected decimal _mMPurchasePlanItemTotalProductLength;
        protected DateTime _mMPurchasePlanItemTotalNeededTime = DateTime.MaxValue;
        protected decimal _mMPurchasePlanItemTotalFreshLumberBlock;
        protected decimal _mMPurchasePlanItemTotalFreshLumberHeight;
        protected decimal _mMPurchasePlanItemTotalDryLumberBlock;
        protected decimal _mMPurchasePlanItemTotalDryLumberHeight;
        protected decimal _mMPurchasePlanItemTotalPurchaseProposalQty;
        protected String _mMPriority = String.Empty;
        protected int _fK_MMBatchProductID;
        protected int _fK_ICMeasureUnitID;
        protected decimal _mMPurchasePlanItemTotalRoundWoodBlock;
        protected decimal _mMPurchasePlanItemTotalBPProductionNormItemQty;
        protected int _fK_MMWoodPlanID;
        protected int _fK_MMWoodPlanItemDetailID;
        protected int _fK_ICOriginalProductID;
        protected int _fK_ICOriginalProductAttributeWoodTypeID;
        protected String _mMPurchasePlanItemTotalOriginalProductName = String.Empty;
        protected String _mMPurchasePlanItemTotalOriginalProductDesc = String.Empty;
        protected decimal _mMPurchasePlanItemTotalOriginalProductHeight;
        protected decimal _mMPurchasePlanItemTotalOriginalProductWidth;
        protected decimal _mMPurchasePlanItemTotalOriginalProductLength;
        protected String _mMPurchasePlanItemTotalBPItemComment = String.Empty;
        protected String _mMPurchasePlanItemTotalProductJoinery = String.Empty;
        protected decimal _mMPurchasePlanItemTotalBlock;
        protected String _mMPurchasePlanItemTotalComment = String.Empty;
        protected int _fK_APSupplierID;
        protected decimal _mMPurchasePlanItemTotalBPQuantity;
        protected int _fK_ICBPMeasureUnitID;
        protected decimal _mMPurchasePlanItemTotalProductionNormItemBlocks;
        protected int _fK_ICProductAttributeQualityID;
        protected decimal _mMPurchasePlanItemTotalProductionNormItemPaint;
        protected int _fK_MMFromOperationID;
        protected int _fK_MMToOperationID;
        protected decimal _mMPurchasePlanItemTotalProductionNormItemTotalBlocks;
        protected decimal _mMPurchasePlanItemTotalProductionNormItemTotalPaint;
        protected String _mMPurchasePlanItemTotalProductSupplierNumber = String.Empty;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_ICProductForBatchID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected int _fK_MMOperationDetailPlanID;
        protected int _fK_MMOperationDetailPlanItemID;
        protected int _fK_MMOperationDetailPlanItemChildID;
        protected decimal _mMPurchasePlanItemTotalCanceledQuantity;
        protected int _fK_MMWorkShopID;
        protected int _fK_ARSaleOrderID;
        protected decimal _mMPurchasePlanItemTotalPurchaseOutsideQty;
        #endregion

        #region Public properties
        public int MMPurchasePlanItemTotalID
        {
            get { return _mMPurchasePlanItemTotalID; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalID)
                {
                    _mMPurchasePlanItemTotalID = value;
                    NotifyChanged("MMPurchasePlanItemTotalID");
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
        public int FK_MMPurchasePlanID
        {
            get { return _fK_MMPurchasePlanID; }
            set
            {
                if (value != this._fK_MMPurchasePlanID)
                {
                    _fK_MMPurchasePlanID = value;
                    NotifyChanged("FK_MMPurchasePlanID");
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
        public String MMPurchasePlanItemTotalPurchaseType
        {
            get { return _mMPurchasePlanItemTotalPurchaseType; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalPurchaseType)
                {
                    _mMPurchasePlanItemTotalPurchaseType = value;
                    NotifyChanged("MMPurchasePlanItemTotalPurchaseType");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalWoodPlanQuantity
        {
            get { return _mMPurchasePlanItemTotalWoodPlanQuantity; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalWoodPlanQuantity)
                {
                    _mMPurchasePlanItemTotalWoodPlanQuantity = value;
                    NotifyChanged("MMPurchasePlanItemTotalWoodPlanQuantity");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalQuantity
        {
            get { return _mMPurchasePlanItemTotalQuantity; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalQuantity)
                {
                    _mMPurchasePlanItemTotalQuantity = value;
                    NotifyChanged("MMPurchasePlanItemTotalQuantity");
                }
            }
        }
        public String MMPurchasePlanItemTotalProductName
        {
            get { return _mMPurchasePlanItemTotalProductName; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductName)
                {
                    _mMPurchasePlanItemTotalProductName = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductName");
                }
            }
        }
        public String MMPurchasePlanItemTotalProductDesc
        {
            get { return _mMPurchasePlanItemTotalProductDesc; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductDesc)
                {
                    _mMPurchasePlanItemTotalProductDesc = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductDesc");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalProductHeight
        {
            get { return _mMPurchasePlanItemTotalProductHeight; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductHeight)
                {
                    _mMPurchasePlanItemTotalProductHeight = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductHeight");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalProductWidth
        {
            get { return _mMPurchasePlanItemTotalProductWidth; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductWidth)
                {
                    _mMPurchasePlanItemTotalProductWidth = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductWidth");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalProductLength
        {
            get { return _mMPurchasePlanItemTotalProductLength; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductLength)
                {
                    _mMPurchasePlanItemTotalProductLength = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductLength");
                }
            }
        }
        public DateTime MMPurchasePlanItemTotalNeededTime
        {
            get { return _mMPurchasePlanItemTotalNeededTime; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalNeededTime)
                {
                    _mMPurchasePlanItemTotalNeededTime = value;
                    NotifyChanged("MMPurchasePlanItemTotalNeededTime");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalFreshLumberBlock
        {
            get { return _mMPurchasePlanItemTotalFreshLumberBlock; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalFreshLumberBlock)
                {
                    _mMPurchasePlanItemTotalFreshLumberBlock = value;
                    NotifyChanged("MMPurchasePlanItemTotalFreshLumberBlock");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalFreshLumberHeight
        {
            get { return _mMPurchasePlanItemTotalFreshLumberHeight; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalFreshLumberHeight)
                {
                    _mMPurchasePlanItemTotalFreshLumberHeight = value;
                    NotifyChanged("MMPurchasePlanItemTotalFreshLumberHeight");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalDryLumberBlock
        {
            get { return _mMPurchasePlanItemTotalDryLumberBlock; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalDryLumberBlock)
                {
                    _mMPurchasePlanItemTotalDryLumberBlock = value;
                    NotifyChanged("MMPurchasePlanItemTotalDryLumberBlock");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalDryLumberHeight
        {
            get { return _mMPurchasePlanItemTotalDryLumberHeight; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalDryLumberHeight)
                {
                    _mMPurchasePlanItemTotalDryLumberHeight = value;
                    NotifyChanged("MMPurchasePlanItemTotalDryLumberHeight");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalPurchaseProposalQty
        {
            get { return _mMPurchasePlanItemTotalPurchaseProposalQty; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalPurchaseProposalQty)
                {
                    _mMPurchasePlanItemTotalPurchaseProposalQty = value;
                    NotifyChanged("MMPurchasePlanItemTotalPurchaseProposalQty");
                }
            }
        }
        public String MMPriority
        {
            get { return _mMPriority; }
            set
            {
                if (value != this._mMPriority)
                {
                    _mMPriority = value;
                    NotifyChanged("MMPriority");
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
        public decimal MMPurchasePlanItemTotalRoundWoodBlock
        {
            get { return _mMPurchasePlanItemTotalRoundWoodBlock; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalRoundWoodBlock)
                {
                    _mMPurchasePlanItemTotalRoundWoodBlock = value;
                    NotifyChanged("MMPurchasePlanItemTotalRoundWoodBlock");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalBPProductionNormItemQty
        {
            get { return _mMPurchasePlanItemTotalBPProductionNormItemQty; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalBPProductionNormItemQty)
                {
                    _mMPurchasePlanItemTotalBPProductionNormItemQty = value;
                    NotifyChanged("MMPurchasePlanItemTotalBPProductionNormItemQty");
                }
            }
        }
        public int FK_MMWoodPlanID
        {
            get { return _fK_MMWoodPlanID; }
            set
            {
                if (value != this._fK_MMWoodPlanID)
                {
                    _fK_MMWoodPlanID = value;
                    NotifyChanged("FK_MMWoodPlanID");
                }
            }
        }
        public int FK_MMWoodPlanItemDetailID
        {
            get { return _fK_MMWoodPlanItemDetailID; }
            set
            {
                if (value != this._fK_MMWoodPlanItemDetailID)
                {
                    _fK_MMWoodPlanItemDetailID = value;
                    NotifyChanged("FK_MMWoodPlanItemDetailID");
                }
            }
        }
        public int FK_ICOriginalProductID
        {
            get { return _fK_ICOriginalProductID; }
            set
            {
                if (value != this._fK_ICOriginalProductID)
                {
                    _fK_ICOriginalProductID = value;
                    NotifyChanged("FK_ICOriginalProductID");
                }
            }
        }
        public int FK_ICOriginalProductAttributeWoodTypeID
        {
            get { return _fK_ICOriginalProductAttributeWoodTypeID; }
            set
            {
                if (value != this._fK_ICOriginalProductAttributeWoodTypeID)
                {
                    _fK_ICOriginalProductAttributeWoodTypeID = value;
                    NotifyChanged("FK_ICOriginalProductAttributeWoodTypeID");
                }
            }
        }
        public String MMPurchasePlanItemTotalOriginalProductName
        {
            get { return _mMPurchasePlanItemTotalOriginalProductName; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalOriginalProductName)
                {
                    _mMPurchasePlanItemTotalOriginalProductName = value;
                    NotifyChanged("MMPurchasePlanItemTotalOriginalProductName");
                }
            }
        }
        public String MMPurchasePlanItemTotalOriginalProductDesc
        {
            get { return _mMPurchasePlanItemTotalOriginalProductDesc; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalOriginalProductDesc)
                {
                    _mMPurchasePlanItemTotalOriginalProductDesc = value;
                    NotifyChanged("MMPurchasePlanItemTotalOriginalProductDesc");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalOriginalProductHeight
        {
            get { return _mMPurchasePlanItemTotalOriginalProductHeight; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalOriginalProductHeight)
                {
                    _mMPurchasePlanItemTotalOriginalProductHeight = value;
                    NotifyChanged("MMPurchasePlanItemTotalOriginalProductHeight");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalOriginalProductWidth
        {
            get { return _mMPurchasePlanItemTotalOriginalProductWidth; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalOriginalProductWidth)
                {
                    _mMPurchasePlanItemTotalOriginalProductWidth = value;
                    NotifyChanged("MMPurchasePlanItemTotalOriginalProductWidth");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalOriginalProductLength
        {
            get { return _mMPurchasePlanItemTotalOriginalProductLength; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalOriginalProductLength)
                {
                    _mMPurchasePlanItemTotalOriginalProductLength = value;
                    NotifyChanged("MMPurchasePlanItemTotalOriginalProductLength");
                }
            }
        }
        public String MMPurchasePlanItemTotalBPItemComment
        {
            get { return _mMPurchasePlanItemTotalBPItemComment; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalBPItemComment)
                {
                    _mMPurchasePlanItemTotalBPItemComment = value;
                    NotifyChanged("MMPurchasePlanItemTotalBPItemComment");
                }
            }
        }
        public String MMPurchasePlanItemTotalProductJoinery
        {
            get { return _mMPurchasePlanItemTotalProductJoinery; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductJoinery)
                {
                    _mMPurchasePlanItemTotalProductJoinery = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductJoinery");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalBlock
        {
            get { return _mMPurchasePlanItemTotalBlock; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalBlock)
                {
                    _mMPurchasePlanItemTotalBlock = value;
                    NotifyChanged("MMPurchasePlanItemTotalBlock");
                }
            }
        }
        public String MMPurchasePlanItemTotalComment
        {
            get { return _mMPurchasePlanItemTotalComment; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalComment)
                {
                    _mMPurchasePlanItemTotalComment = value;
                    NotifyChanged("MMPurchasePlanItemTotalComment");
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalBPQuantity
        {
            get { return _mMPurchasePlanItemTotalBPQuantity; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalBPQuantity)
                {
                    _mMPurchasePlanItemTotalBPQuantity = value;
                    NotifyChanged("MMPurchasePlanItemTotalBPQuantity");
                }
            }
        }
        public int FK_ICBPMeasureUnitID
        {
            get { return _fK_ICBPMeasureUnitID; }
            set
            {
                if (value != this._fK_ICBPMeasureUnitID)
                {
                    _fK_ICBPMeasureUnitID = value;
                    NotifyChanged("FK_ICBPMeasureUnitID");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalProductionNormItemBlocks
        {
            get { return _mMPurchasePlanItemTotalProductionNormItemBlocks; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductionNormItemBlocks)
                {
                    _mMPurchasePlanItemTotalProductionNormItemBlocks = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductionNormItemBlocks");
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
        public decimal MMPurchasePlanItemTotalProductionNormItemPaint
        {
            get { return _mMPurchasePlanItemTotalProductionNormItemPaint; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductionNormItemPaint)
                {
                    _mMPurchasePlanItemTotalProductionNormItemPaint = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductionNormItemPaint");
                }
            }
        }
        public int FK_MMFromOperationID
        {
            get { return _fK_MMFromOperationID; }
            set
            {
                if (value != this._fK_MMFromOperationID)
                {
                    _fK_MMFromOperationID = value;
                    NotifyChanged("FK_MMFromOperationID");
                }
            }
        }
        public int FK_MMToOperationID
        {
            get { return _fK_MMToOperationID; }
            set
            {
                if (value != this._fK_MMToOperationID)
                {
                    _fK_MMToOperationID = value;
                    NotifyChanged("FK_MMToOperationID");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalProductionNormItemTotalBlocks
        {
            get { return _mMPurchasePlanItemTotalProductionNormItemTotalBlocks; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductionNormItemTotalBlocks)
                {
                    _mMPurchasePlanItemTotalProductionNormItemTotalBlocks = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductionNormItemTotalBlocks");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalProductionNormItemTotalPaint
        {
            get { return _mMPurchasePlanItemTotalProductionNormItemTotalPaint; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductionNormItemTotalPaint)
                {
                    _mMPurchasePlanItemTotalProductionNormItemTotalPaint = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductionNormItemTotalPaint");
                }
            }
        }
        public String MMPurchasePlanItemTotalProductSupplierNumber
        {
            get { return _mMPurchasePlanItemTotalProductSupplierNumber; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalProductSupplierNumber)
                {
                    _mMPurchasePlanItemTotalProductSupplierNumber = value;
                    NotifyChanged("MMPurchasePlanItemTotalProductSupplierNumber");
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
        public int FK_MMOperationDetailPlanID
        {
            get { return _fK_MMOperationDetailPlanID; }
            set
            {
                if (value != this._fK_MMOperationDetailPlanID)
                {
                    _fK_MMOperationDetailPlanID = value;
                    NotifyChanged("FK_MMOperationDetailPlanID");
                }
            }
        }
        public int FK_MMOperationDetailPlanItemID
        {
            get { return _fK_MMOperationDetailPlanItemID; }
            set
            {
                if (value != this._fK_MMOperationDetailPlanItemID)
                {
                    _fK_MMOperationDetailPlanItemID = value;
                    NotifyChanged("FK_MMOperationDetailPlanItemID");
                }
            }
        }
        public int FK_MMOperationDetailPlanItemChildID
        {
            get { return _fK_MMOperationDetailPlanItemChildID; }
            set
            {
                if (value != this._fK_MMOperationDetailPlanItemChildID)
                {
                    _fK_MMOperationDetailPlanItemChildID = value;
                    NotifyChanged("FK_MMOperationDetailPlanItemChildID");
                }
            }
        }
        public decimal MMPurchasePlanItemTotalCanceledQuantity
        {
            get { return _mMPurchasePlanItemTotalCanceledQuantity; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalCanceledQuantity)
                {
                    _mMPurchasePlanItemTotalCanceledQuantity = value;
                    NotifyChanged("MMPurchasePlanItemTotalCanceledQuantity");
                }
            }
        }
        public int FK_MMWorkShopID
        {
            get { return _fK_MMWorkShopID; }
            set
            {
                if (value != this._fK_MMWorkShopID)
                {
                    _fK_MMWorkShopID = value;
                    NotifyChanged("FK_MMWorkShopID");
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
        public decimal MMPurchasePlanItemTotalPurchaseOutsideQty
        {
            get { return _mMPurchasePlanItemTotalPurchaseOutsideQty; }
            set
            {
                if (value != this._mMPurchasePlanItemTotalPurchaseOutsideQty)
                {
                    _mMPurchasePlanItemTotalPurchaseOutsideQty = value;
                    NotifyChanged("MMPurchasePlanItemTotalPurchaseOutsideQty");
                }
            }
        }
        #endregion

        #region Extra Properties
        public decimal MMAllocatedQty { get; set; }
        public decimal MMPurchasePlanItemTotalInventoryStock { get; set; }
        public string MMPurchasePlanNo { get; set; }

        public string MMBatchProductNo { get; set; }
        #endregion
    }
    #endregion
}