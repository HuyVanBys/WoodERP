using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductProductionNormItemMeterials
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductProductionNormItemMeterialsInfo
    //Created Date:Thursday, May 17, 2018
    //-----------------------------------------------------------

    public class MMBatchProductProductionNormItemMeterialsInfo : BusinessObject
    {
        public MMBatchProductProductionNormItemMeterialsInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductProductionNormItemMeterialID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductAlternativeID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_MMFormulaID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected decimal _mMBatchProductProductionNormItemMeterialLength;
        protected decimal _mMBatchProductProductionNormItemMeterialWidth;
        protected decimal _mMBatchProductProductionNormItemMeterialHeigth;
        protected String _mMBatchProductProductionNormItemMeterialDesc = String.Empty;
        protected decimal _mMBatchProductProductionNormItemMeterialWoodBlocks;
        protected decimal _mMBatchProductProductionNormItemMeterialConsumable;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMBatchProductItemID;
        protected decimal _mMBatchProductProductionNormItemMeterialWaste;
        protected int _fK_ICProductItemMaterialID;
        protected decimal _mMBatchProductProductionNormItemMeterialDepreciationRate;
        protected decimal _mMBatchProductProductionNormItemMeterialDepreciationQty;
        protected decimal _mMBatchProductProductionNormItemMeterialQty;
        protected int _fK_MMProductionNormApproveLogID;
        protected int _fK_MMOperationID;
        protected bool _mMBatchProductProductionNormItemMeterialIsGrain = true;
        protected String _mMBatchProductProductionNormItemMeterialType = String.Empty;
        protected decimal _mMBatchProductProductionNormItemMeterialQtyPerOne;
        #endregion

        #region Public properties
        public int MMBatchProductProductionNormItemMeterialID
        {
            get { return _mMBatchProductProductionNormItemMeterialID; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialID)
                {
                    _mMBatchProductProductionNormItemMeterialID = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialID");
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
        public int FK_MMFormulaID
        {
            get { return _fK_MMFormulaID; }
            set
            {
                if (value != this._fK_MMFormulaID)
                {
                    _fK_MMFormulaID = value;
                    NotifyChanged("FK_MMFormulaID");
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
        public decimal MMBatchProductProductionNormItemMeterialLength
        {
            get { return _mMBatchProductProductionNormItemMeterialLength; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialLength)
                {
                    _mMBatchProductProductionNormItemMeterialLength = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialLength");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialWidth
        {
            get { return _mMBatchProductProductionNormItemMeterialWidth; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialWidth)
                {
                    _mMBatchProductProductionNormItemMeterialWidth = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialWidth");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialHeigth
        {
            get { return _mMBatchProductProductionNormItemMeterialHeigth; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialHeigth)
                {
                    _mMBatchProductProductionNormItemMeterialHeigth = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialHeigth");
                }
            }
        }
        public String MMBatchProductProductionNormItemMeterialDesc
        {
            get { return _mMBatchProductProductionNormItemMeterialDesc; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialDesc)
                {
                    _mMBatchProductProductionNormItemMeterialDesc = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialDesc");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialWoodBlocks
        {
            get { return _mMBatchProductProductionNormItemMeterialWoodBlocks; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialWoodBlocks)
                {
                    _mMBatchProductProductionNormItemMeterialWoodBlocks = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialWoodBlocks");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialConsumable
        {
            get { return _mMBatchProductProductionNormItemMeterialConsumable; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialConsumable)
                {
                    _mMBatchProductProductionNormItemMeterialConsumable = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialConsumable");
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
        public decimal MMBatchProductProductionNormItemMeterialWaste
        {
            get { return _mMBatchProductProductionNormItemMeterialWaste; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialWaste)
                {
                    _mMBatchProductProductionNormItemMeterialWaste = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialWaste");
                }
            }
        }
        public int FK_ICProductItemMaterialID
        {
            get { return _fK_ICProductItemMaterialID; }
            set
            {
                if (value != this._fK_ICProductItemMaterialID)
                {
                    _fK_ICProductItemMaterialID = value;
                    NotifyChanged("FK_ICProductItemMaterialID");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialDepreciationRate
        {
            get { return _mMBatchProductProductionNormItemMeterialDepreciationRate; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialDepreciationRate)
                {
                    _mMBatchProductProductionNormItemMeterialDepreciationRate = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialDepreciationRate");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialDepreciationQty
        {
            get { return _mMBatchProductProductionNormItemMeterialDepreciationQty; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialDepreciationQty)
                {
                    _mMBatchProductProductionNormItemMeterialDepreciationQty = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialDepreciationQty");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialQty
        {
            get { return _mMBatchProductProductionNormItemMeterialQty; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialQty)
                {
                    _mMBatchProductProductionNormItemMeterialQty = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialQty");
                }
            }
        }
        public int FK_MMProductionNormApproveLogID
        {
            get { return _fK_MMProductionNormApproveLogID; }
            set
            {
                if (value != this._fK_MMProductionNormApproveLogID)
                {
                    _fK_MMProductionNormApproveLogID = value;
                    NotifyChanged("FK_MMProductionNormApproveLogID");
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
        public bool MMBatchProductProductionNormItemMeterialIsGrain
        {
            get { return _mMBatchProductProductionNormItemMeterialIsGrain; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialIsGrain)
                {
                    _mMBatchProductProductionNormItemMeterialIsGrain = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialIsGrain");
                }
            }
        }
        public String MMBatchProductProductionNormItemMeterialType
        {
            get { return _mMBatchProductProductionNormItemMeterialType; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialType)
                {
                    _mMBatchProductProductionNormItemMeterialType = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialType");
                }
            }
        }
        public decimal MMBatchProductProductionNormItemMeterialQtyPerOne
        {
            get { return _mMBatchProductProductionNormItemMeterialQtyPerOne; }
            set
            {
                if (value != this._mMBatchProductProductionNormItemMeterialQtyPerOne)
                {
                    _mMBatchProductProductionNormItemMeterialQtyPerOne = value;
                    NotifyChanged("MMBatchProductProductionNormItemMeterialQtyPerOne");
                }
            }
        }
        #endregion

        public string ICProductName { get; set; }
        public string ICProductCode { get; set; }
        public string ICMeasureUnitName { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductDesc { get; set; }
        public string ICProductAttributeColorNo { get; set; }
        public string ICMeasureUnitColorName { get; set; }
        public decimal MMBatchProductProductionNormItemPaintTotalQty { get; set; }

        public decimal MMBatchProductItemProductQty { get; set; }
        public string MMBatchProductProductionNormItemNo { get; set; }
        public string MMBatchProductProductionNormItemProductName { get; set; }
        public string MMBatchProductProductionNormItemParentOrderName { get; set; }
        public string MMBatchProductProductionNormItemParentNo { get; set; }
        public string MMBatchProductProductionNormItemType { get; set; }
        public decimal MMBatchProductProductionNormItemMeterialNewDepreciationQty { get; set; }
        public decimal MMBatchProductProductionNormItemMeterialAllocationQty { get; set; }
        public decimal MMBatchProductProductionNormItemMeterialAllocatedQty { get; set; }
        public decimal MMBatchProductProductionNormItemMeterialProposalQty { get; set; }
        public decimal MMBatchProductProductionNormItemMeterialCanApplyQty { get; set; }
        public decimal MMBatchProductProductionNormItemMeterialApplyQty { get; set; }

        public string MMBatchProductProductionNormItemComment { get; set; }
        public string MMBatchProductProductionNormItemProductSupplierNumber { get; set; }
        public string MMBatchProductProductionNormItemPaintMixRatio { get; set; }
        public decimal MMBatchProductProductionNormItemProductInsideDimensionHeight { get; set; }
        public decimal MMBatchProductProductionNormItemProductInsideDimensionWidth { get; set; }
        public decimal MMBatchProductProductionNormItemProductInsideDimensionLength { get; set; }
        public decimal MMBatchProductProductionNormItemProductOverallDimensionHeight { get; set; }
        public decimal MMBatchProductProductionNormItemProductOverallDimensionWidth { get; set; }
        public decimal MMBatchProductProductionNormItemProductOverallDimensionLength { get; set; }
        public string MMBatchProductProductionNormItemProductSizeAndPacking { get; set; }
        public string MMBatchProductProductionNormItemProductWeightPerVolume { get; set; }
        public decimal MMBatchProductProductionNormItemPackagingGW { get; set; }
        public decimal MMBatchProductProductionNormItemPackagingNW { get; set; }
        public string MMBatchProductProductionNormItemGroup { get; set; }
        public int FK_MMProductionNormItemID { get; set; }
        public int FK_MMProductionNormID { get; set; }
        public int FK_MMBPSemiProductID { get; set; }
        public bool IsError { get; set; }
        public Guid VirtualId { get; set; }
        public string AllocationTypeText { get; set; }
        public string MMBatchProductProductionNormItemMaterialType { get; set; }
    }
    #endregion
}