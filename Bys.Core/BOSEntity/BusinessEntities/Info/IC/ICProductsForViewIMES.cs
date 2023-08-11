using BOSLib;
using System;

namespace BOSERP
{
    public class ICProductsForViewIMES : BusinessObject
    {
        public ICProductsForViewIMES()
        {

        }

        #region Variables
        protected int _iCProductID;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected decimal _iCProductPrice01;
        protected String _iCProductBarCode = String.Empty;
        protected String _iCProductNo = String.Empty;
        protected String _iCProductCode = String.Empty;
        protected String _iCProductName = String.Empty;
        protected String _iCProductDesc = String.Empty;
        protected String _iCProductSupplierNumber = String.Empty;
        protected String _iCProductType = String.Empty;
        protected decimal _iCProductWeight;
        protected String _iCProductJoinery = String.Empty;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProdAttPackingMaterialWeightPerVolumeID;
        protected int _fK_ICProdAttPackingMaterialSizeID;
        protected int _fK_ICProductAttributeSemiProductSpecialityID;
        protected decimal _iCProductInsideDimensionLength;
        protected decimal _iCProductInsideDimensionWidth;
        protected decimal _iCProductInsideDimensionHeight;
        protected decimal _iCProductOverallDimensionLength;
        protected decimal _iCProductOverallDimensionWidth;
        protected decimal _iCProductOverallDimensionHeight;
        protected int _fK_ICProductBasicUnitID;
        protected int _fK_ICProductSaleUnitID;
        protected int _fK_ICProductPurchaseUnitID;
        protected String _iCProductNoOfOldSys = String.Empty;
        protected bool _hasComponent = true;
        protected int _fK_ICProductCarcassID;
        //protected int _fK_ACAccountID;
        //protected int _fK_ACDepreciationCostAccountID;
        //protected int _fK_ACDepreciationAccountID;
        //protected int _fK_ACAccountRevenueInternalID;
        //protected int _fK_ACAccountCostPriceID;
        //protected int _fK_ACAccountRevenueID;
        //protected int _fK_ACAccountSaleReturnID;
        //protected int _fK_ACAccountDiscountID;
        //protected DateTime _iCProductStockMaxDateFrom = DateTime.MaxValue;
        //protected DateTime _iCProductStockMaxDateTo = DateTime.MaxValue;
        //protected decimal _iCProductStockMax;
        protected decimal _iCProductVolume;
        protected bool _iCProductActiveCheck = true;
        protected decimal _iCProductDepreciationRate;
        protected decimal _iCProductDepreciationQty;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected bool _iCProductCheckCarcass = false;
        protected decimal _iCProductLength;
        protected decimal _iCProductHeight;
        protected decimal _iCProductWidth;
        protected decimal _iCProductBlock;
        protected bool _iCProductIsFollowInventoryStock = true;
        protected int _fK_ICProductAttributeColorID;
        protected String _iCProductWorkType = String.Empty;
        protected String _iCProductAttribute = String.Empty;
        //protected int _fK_APSupplierID;
        //protected decimal _iCProductWorkUnitPrice;
        //protected decimal _iCProductMaterialUnitPrice;
        //protected decimal _iCProductEquipmentUnitPrice;
        protected String _iCProductSizeAndSpecifiCations = String.Empty;
        protected int _fK_ICProdAttPackingMaterialSpecialityID;
        protected decimal _iCProductNetWeight;
        protected decimal _iCProductGrossWeight;
        protected String _iCProductComment = String.Empty;
        protected bool _iCProductIsGrain = false;
        #region Not in use

        //protected int _fK_GEVATID;
        //protected String _iCProductAttributeKey = String.Empty;

        //protected String _iCProductAttributeNo = String.Empty;
        //protected decimal _iCProductSupplierPrice;
        //protected decimal _iCProductStockMin;
        //protected DateTime _iCProductStockMinDateFrom = DateTime.MaxValue;
        //protected DateTime _iCProductStockMinDateTo = DateTime.MaxValue;
        //protected byte[] _iCProductPicture;
        //protected String _iCProductModelNo = String.Empty;
        //protected String _iCProductGuaranteeTerm = String.Empty;
        //protected int _iCProductGuaranteeMonths;
        //protected String _iCProductDepreciationMethod = String.Empty;
        //protected int _iCProductDepreciationMonths;

        //protected String _iCProductPaintNoOfManufacture = String.Empty;
        //protected int _fK_ICProductAttributeFinishingID;

        //protected String _iCProductCustomerNumber = String.Empty;
        //protected int _fK_GECountryID;
        //protected int _fK_ICProductGroupParentID;
        protected String _iCProductName2 = String.Empty;
        //protected String _iCProductWoodTypeAttribute = String.Empty;
        //protected String _iCProductColorAttribute = String.Empty;

        //protected decimal _iCProductOriginalAmount;
        //protected decimal _iCProductDepreciatedAmount;
        //protected String _iCProductAttributeFinishing = String.Empty;
        //protected String _iCProductAttributeFinishingText = String.Empty;
        //protected String _iCProductWoodGroup = String.Empty;
        //protected int _fK_ICProductWorkGroupID;


        //protected String _iCProductOriginOfProduct = String.Empty;
        //protected bool _iCProductChargeCheck = false;
        //protected bool _iCProductLockedPurchaseOrder = false;
        //protected decimal _iCProductMinLength;
        //protected decimal _iCProductMaxHeight;
        //protected String _iCProductTargetType = String.Empty;
        //protected String _iCProductOrigin = String.Empty;
        //protected int _fK_ICModelID;
        //protected String _iCProductOtherSize = String.Empty;
        //protected String _iCProductImageFileName = String.Empty;
        //protected int _fK_ICProductParentID;
        //protected bool _iCProductFixedNorm = true;
        //protected int _fK_MMProductionNormItemID;
        //protected String _iCProductLicensePlate = String.Empty;
        //protected decimal _iCProductBulk;
        //protected decimal _iCProductCapacity;
        //protected decimal _iCProductDepth;
        //protected decimal _iCProductRadius;
        //protected decimal _iCProductDiameter;
        //protected decimal _iCProductThickness;
        //protected int _fK_ICProductGroupHeightID;
        //protected int _fK_ICProductFormulaPriceConfigID;
        //protected decimal _iCProductGuaranteeMonth;
        //protected int _fK_HREmployeeID;
        //protected String _iCProductTemplateType = String.Empty;
        //protected bool _iCProductPromotionCheck = true;
        //protected int _fK_ICProductTypeAccountConfigID;
        //protected String _iCProductUses = String.Empty;
        //protected bool _iCProductNonRetail = false;
        //protected bool _iCProductIsShowWeb = true;
        //protected String _iCProductTrademark = String.Empty;
        //protected String _iCProductDepartmentGroup = String.Empty;
        //protected int _fK_BRBranchID;
        //protected int _fK_ACCostCenterID;
        //protected int _fK_ACSegmentID;
        //protected int _fK_ACEquipmentTypeAccountConfigID;
        //protected bool _iCProductAlternativeCheck = false;
        //protected int _fK_ICPriceCalculationMethodID;
        protected String _iCProductImageFile = String.Empty;
        //protected String _iCProductImageName = String.Empty;
        //protected int _fK_MMFormulaIDPaintA;
        //protected int _fK_MMFormulaIDPaintB;
        //protected int _fK_ICProductAttributeQualityID;
        //protected int _fK_ARCustomerID;
        //protected int _fK_MMFormulaIDPaintC;
        //protected decimal _iCProductCartonBlock;
        //protected int _iCProductQtyInBox;

        //protected String _iCProductPurchaseType = String.Empty;
        //protected decimal _iCProductLeadTime;
        //protected decimal _iCProductBoxArea;
        //protected decimal _iCProductBoxUnitPrice;
        //protected int _fK_ICProductStockSaveID;
        //protected int _iCProductStockSaveDate;
        //protected int _fK_ICPerimeterGroupID;
        //protected int _fK_ICLengthGroupID;
        //protected int _fK_ICStockGroupID;
        //protected int _fK_ICProductWoodIngredientID;
        //protected int _fK_MMProcessID;
        //protected bool _iCProductHavePaint = true;
        //protected String _iCProductResourceType = String.Empty;
        //protected decimal _iCProductConsumable;

        //protected decimal _iCProductQuantitative;
        #endregion
        #endregion

        #region Public properties
        public int ICProductID
        {
            get { return _iCProductID; }
            set
            {
                if (value != this._iCProductID)
                {
                    _iCProductID = value;
                    NotifyChanged("ICProductID");
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
        //public int FK_APSupplierID
        //{
        //    get { return _fK_APSupplierID; }
        //    set
        //    {
        //        if (value != this._fK_APSupplierID)
        //        {
        //            _fK_APSupplierID = value;
        //            NotifyChanged("FK_APSupplierID");
        //        }
        //    }
        //}
        //public int FK_GEVATID
        //{
        //    get { return _fK_GEVATID; }
        //    set
        //    {
        //        if (value != this._fK_GEVATID)
        //        {
        //            _fK_GEVATID = value;
        //            NotifyChanged("FK_GEVATID");
        //        }
        //    }
        //}
        public int FK_ICProductBasicUnitID
        {
            get { return _fK_ICProductBasicUnitID; }
            set
            {
                if (value != this._fK_ICProductBasicUnitID)
                {
                    _fK_ICProductBasicUnitID = value;
                    NotifyChanged("FK_ICProductBasicUnitID");
                }
            }
        }
        public int FK_ICProductSaleUnitID
        {
            get { return _fK_ICProductSaleUnitID; }
            set
            {
                if (value != this._fK_ICProductSaleUnitID)
                {
                    _fK_ICProductSaleUnitID = value;
                    NotifyChanged("FK_ICProductSaleUnitID");
                }
            }
        }
        public int FK_ICProductPurchaseUnitID
        {
            get { return _fK_ICProductPurchaseUnitID; }
            set
            {
                if (value != this._fK_ICProductPurchaseUnitID)
                {
                    _fK_ICProductPurchaseUnitID = value;
                    NotifyChanged("FK_ICProductPurchaseUnitID");
                }
            }
        }
        //public String ICProductAttributeKey
        //{
        //    get { return _iCProductAttributeKey; }
        //    set
        //    {
        //        if (value != this._iCProductAttributeKey)
        //        {
        //            _iCProductAttributeKey = value;
        //            NotifyChanged("ICProductAttributeKey");
        //        }
        //    }
        //}
        public String ICProductAttribute
        {
            get { return _iCProductAttribute; }
            set
            {
                if (value != this._iCProductAttribute)
                {
                    _iCProductAttribute = value;
                    NotifyChanged("ICProductAttribute");
                }
            }
        }
        //public String ICProductAttributeNo
        //{
        //    get { return _iCProductAttributeNo; }
        //    set
        //    {
        //        if (value != this._iCProductAttributeNo)
        //        {
        //            _iCProductAttributeNo = value;
        //            NotifyChanged("ICProductAttributeNo");
        //        }
        //    }
        //}
        //public decimal ICProductSupplierPrice
        //{
        //    get { return _iCProductSupplierPrice; }
        //    set
        //    {
        //        if (value != this._iCProductSupplierPrice)
        //        {
        //            _iCProductSupplierPrice = value;
        //            NotifyChanged("ICProductSupplierPrice");
        //        }
        //    }
        //}
        public String ICProductSupplierNumber
        {
            get { return _iCProductSupplierNumber; }
            set
            {
                if (value != this._iCProductSupplierNumber)
                {
                    _iCProductSupplierNumber = value;
                    NotifyChanged("ICProductSupplierNumber");
                }
            }
        }
        public String ICProductNo
        {
            get { return _iCProductNo; }
            set
            {
                if (value != this._iCProductNo)
                {
                    _iCProductNo = value;
                    NotifyChanged("ICProductNo");
                }
            }
        }
        public String ICProductName
        {
            get { return _iCProductName; }
            set
            {
                if (value != this._iCProductName)
                {
                    _iCProductName = value;
                    NotifyChanged("ICProductName");
                }
            }
        }
        public String ICProductDesc
        {
            get { return _iCProductDesc; }
            set
            {
                if (value != this._iCProductDesc)
                {
                    _iCProductDesc = value;
                    NotifyChanged("ICProductDesc");
                }
            }
        }
        public bool ICProductActiveCheck
        {
            get { return _iCProductActiveCheck; }
            set
            {
                if (value != this._iCProductActiveCheck)
                {
                    _iCProductActiveCheck = value;
                    NotifyChanged("ICProductActiveCheck");
                }
            }
        }
        public decimal ICProductLength
        {
            get { return _iCProductLength; }
            set
            {
                if (value != this._iCProductLength)
                {
                    _iCProductLength = value;
                    NotifyChanged("ICProductLength");
                }
            }
        }
        public decimal ICProductHeight
        {
            get { return _iCProductHeight; }
            set
            {
                if (value != this._iCProductHeight)
                {
                    _iCProductHeight = value;
                    NotifyChanged("ICProductHeight");
                }
            }
        }
        public decimal ICProductWidth
        {
            get { return _iCProductWidth; }
            set
            {
                if (value != this._iCProductWidth)
                {
                    _iCProductWidth = value;
                    NotifyChanged("ICProductWidth");
                }
            }
        }
        public decimal ICProductWeight
        {
            get { return _iCProductWeight; }
            set
            {
                if (value != this._iCProductWeight)
                {
                    _iCProductWeight = value;
                    NotifyChanged("ICProductWeight");
                }
            }
        }
        public String ICProductBarCode
        {
            get { return _iCProductBarCode; }
            set
            {
                if (value != this._iCProductBarCode)
                {
                    _iCProductBarCode = value;
                    NotifyChanged("ICProductBarCode");
                }
            }
        }
        //public decimal ICProductStockMin
        //{
        //    get { return _iCProductStockMin; }
        //    set
        //    {
        //        if (value != this._iCProductStockMin)
        //        {
        //            _iCProductStockMin = value;
        //            NotifyChanged("ICProductStockMin");
        //        }
        //    }
        //}
        //public DateTime ICProductStockMinDateFrom
        //{
        //    get { return _iCProductStockMinDateFrom; }
        //    set
        //    {
        //        if (value != this._iCProductStockMinDateFrom)
        //        {
        //            _iCProductStockMinDateFrom = value;
        //            NotifyChanged("ICProductStockMinDateFrom");
        //        }
        //    }
        //}
        //public DateTime ICProductStockMinDateTo
        //{
        //    get { return _iCProductStockMinDateTo; }
        //    set
        //    {
        //        if (value != this._iCProductStockMinDateTo)
        //        {
        //            _iCProductStockMinDateTo = value;
        //            NotifyChanged("ICProductStockMinDateTo");
        //        }
        //    }
        //}
        //public decimal ICProductStockMax
        //{
        //    get { return _iCProductStockMax; }
        //    set
        //    {
        //        if (value != this._iCProductStockMax)
        //        {
        //            _iCProductStockMax = value;
        //            NotifyChanged("ICProductStockMax");
        //        }
        //    }
        //}
        //public DateTime ICProductStockMaxDateFrom
        //{
        //    get { return _iCProductStockMaxDateFrom; }
        //    set
        //    {
        //        if (value != this._iCProductStockMaxDateFrom)
        //        {
        //            _iCProductStockMaxDateFrom = value;
        //            NotifyChanged("ICProductStockMaxDateFrom");
        //        }
        //    }
        //}
        //public DateTime ICProductStockMaxDateTo
        //{
        //    get { return _iCProductStockMaxDateTo; }
        //    set
        //    {
        //        if (value != this._iCProductStockMaxDateTo)
        //        {
        //            _iCProductStockMaxDateTo = value;
        //            NotifyChanged("ICProductStockMaxDateTo");
        //        }
        //    }
        //}
        //public byte[] ICProductPicture
        //{
        //    get { return _iCProductPicture; }
        //    set
        //    {
        //        if (value != this._iCProductPicture)
        //        {
        //            _iCProductPicture = value;
        //            NotifyChanged("ICProductPicture");
        //        }
        //    }
        //}
        public decimal ICProductPrice01
        {
            get { return _iCProductPrice01; }
            set
            {
                if (value != this._iCProductPrice01)
                {
                    _iCProductPrice01 = value;
                    NotifyChanged("ICProductPrice01");
                }
            }
        }
        public String ICProductType
        {
            get { return _iCProductType; }
            set
            {
                if (value != this._iCProductType)
                {
                    _iCProductType = value;
                    NotifyChanged("ICProductType");
                }
            }
        }
        public bool HasComponent
        {
            get { return _hasComponent; }
            set
            {
                if (value != this._hasComponent)
                {
                    _hasComponent = value;
                    NotifyChanged("HasComponent");
                }
            }
        }
        //public String ICProductModelNo
        //{
        //    get { return _iCProductModelNo; }
        //    set
        //    {
        //        if (value != this._iCProductModelNo)
        //        {
        //            _iCProductModelNo = value;
        //            NotifyChanged("ICProductModelNo");
        //        }
        //    }
        //}
        //public String ICProductGuaranteeTerm
        //{
        //    get { return _iCProductGuaranteeTerm; }
        //    set
        //    {
        //        if (value != this._iCProductGuaranteeTerm)
        //        {
        //            _iCProductGuaranteeTerm = value;
        //            NotifyChanged("ICProductGuaranteeTerm");
        //        }
        //    }
        //}
        //public int ICProductGuaranteeMonths
        //{
        //    get { return _iCProductGuaranteeMonths; }
        //    set
        //    {
        //        if (value != this._iCProductGuaranteeMonths)
        //        {
        //            _iCProductGuaranteeMonths = value;
        //            NotifyChanged("ICProductGuaranteeMonths");
        //        }
        //    }
        //}
        //public String ICProductDepreciationMethod
        //{
        //    get { return _iCProductDepreciationMethod; }
        //    set
        //    {
        //        if (value != this._iCProductDepreciationMethod)
        //        {
        //            _iCProductDepreciationMethod = value;
        //            NotifyChanged("ICProductDepreciationMethod");
        //        }
        //    }
        //}
        //public int ICProductDepreciationMonths
        //{
        //    get { return _iCProductDepreciationMonths; }
        //    set
        //    {
        //        if (value != this._iCProductDepreciationMonths)
        //        {
        //            _iCProductDepreciationMonths = value;
        //            NotifyChanged("ICProductDepreciationMonths");
        //        }
        //    }
        //}
        public String ICProductComment
        {
            get { return _iCProductComment; }
            set
            {
                if (value != this._iCProductComment)
                {
                    _iCProductComment = value;
                    NotifyChanged("ICProductComment");
                }
            }
        }
        //public int FK_ACAccountID
        //{
        //    get { return _fK_ACAccountID; }
        //    set
        //    {
        //        if (value != this._fK_ACAccountID)
        //        {
        //            _fK_ACAccountID = value;
        //            NotifyChanged("FK_ACAccountID");
        //        }
        //    }
        //}
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
        //public String ICProductPaintNoOfManufacture
        //{
        //    get { return _iCProductPaintNoOfManufacture; }
        //    set
        //    {
        //        if (value != this._iCProductPaintNoOfManufacture)
        //        {
        //            _iCProductPaintNoOfManufacture = value;
        //            NotifyChanged("ICProductPaintNoOfManufacture");
        //        }
        //    }
        //}
        //public int FK_ICProductAttributeFinishingID
        //{
        //    get { return _fK_ICProductAttributeFinishingID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductAttributeFinishingID)
        //        {
        //            _fK_ICProductAttributeFinishingID = value;
        //            NotifyChanged("FK_ICProductAttributeFinishingID");
        //        }
        //    }
        //}
        public String ICProductJoinery
        {
            get { return _iCProductJoinery; }
            set
            {
                if (value != this._iCProductJoinery)
                {
                    _iCProductJoinery = value;
                    NotifyChanged("ICProductJoinery");
                }
            }
        }
        public String ICProductSizeAndSpecifiCations
        {
            get { return _iCProductSizeAndSpecifiCations; }
            set
            {
                if (value != this._iCProductSizeAndSpecifiCations)
                {
                    _iCProductSizeAndSpecifiCations = value;
                    NotifyChanged("ICProductSizeAndSpecifiCations");
                }
            }
        }
        public String ICProductNoOfOldSys
        {
            get { return _iCProductNoOfOldSys; }
            set
            {
                if (value != this._iCProductNoOfOldSys)
                {
                    _iCProductNoOfOldSys = value;
                    NotifyChanged("ICProductNoOfOldSys");
                }
            }
        }
        //public String ICProductCustomerNumber
        //{
        //    get { return _iCProductCustomerNumber; }
        //    set
        //    {
        //        if (value != this._iCProductCustomerNumber)
        //        {
        //            _iCProductCustomerNumber = value;
        //            NotifyChanged("ICProductCustomerNumber");
        //        }
        //    }
        //}
        //public int FK_GECountryID
        //{
        //    get { return _fK_GECountryID; }
        //    set
        //    {
        //        if (value != this._fK_GECountryID)
        //        {
        //            _fK_GECountryID = value;
        //            NotifyChanged("FK_GECountryID");
        //        }
        //    }
        //}
        //public int FK_ICProductGroupParentID
        //{
        //    get { return _fK_ICProductGroupParentID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductGroupParentID)
        //        {
        //            _fK_ICProductGroupParentID = value;
        //            NotifyChanged("FK_ICProductGroupParentID");
        //        }
        //    }
        //}
        public String ICProductName2
        {
            get { return _iCProductName2; }
            set
            {
                if (value != this._iCProductName2)
                {
                    _iCProductName2 = value;
                    NotifyChanged("ICProductName2");
                }
            }
        }
        //public String ICProductWoodTypeAttribute
        //{
        //    get { return _iCProductWoodTypeAttribute; }
        //    set
        //    {
        //        if (value != this._iCProductWoodTypeAttribute)
        //        {
        //            _iCProductWoodTypeAttribute = value;
        //            NotifyChanged("ICProductWoodTypeAttribute");
        //        }
        //    }
        //}
        //public String ICProductColorAttribute
        //{
        //    get { return _iCProductColorAttribute; }
        //    set
        //    {
        //        if (value != this._iCProductColorAttribute)
        //        {
        //            _iCProductColorAttribute = value;
        //            NotifyChanged("ICProductColorAttribute");
        //        }
        //    }
        //}
        public int FK_ICProdAttPackingMaterialSpecialityID
        {
            get { return _fK_ICProdAttPackingMaterialSpecialityID; }
            set
            {
                if (value != this._fK_ICProdAttPackingMaterialSpecialityID)
                {
                    _fK_ICProdAttPackingMaterialSpecialityID = value;
                    NotifyChanged("FK_ICProdAttPackingMaterialSpecialityID");
                }
            }
        }
        public int FK_ICProdAttPackingMaterialSizeID
        {
            get { return _fK_ICProdAttPackingMaterialSizeID; }
            set
            {
                if (value != this._fK_ICProdAttPackingMaterialSizeID)
                {
                    _fK_ICProdAttPackingMaterialSizeID = value;
                    NotifyChanged("FK_ICProdAttPackingMaterialSizeID");
                }
            }
        }
        public int FK_ICProdAttPackingMaterialWeightPerVolumeID
        {
            get { return _fK_ICProdAttPackingMaterialWeightPerVolumeID; }
            set
            {
                if (value != this._fK_ICProdAttPackingMaterialWeightPerVolumeID)
                {
                    _fK_ICProdAttPackingMaterialWeightPerVolumeID = value;
                    NotifyChanged("FK_ICProdAttPackingMaterialWeightPerVolumeID");
                }
            }
        }
        public int FK_ICProductAttributeSemiProductSpecialityID
        {
            get { return _fK_ICProductAttributeSemiProductSpecialityID; }
            set
            {
                if (value != this._fK_ICProductAttributeSemiProductSpecialityID)
                {
                    _fK_ICProductAttributeSemiProductSpecialityID = value;
                    NotifyChanged("FK_ICProductAttributeSemiProductSpecialityID");
                }
            }
        }
        //public int FK_ACDepreciationCostAccountID
        //{
        //    get { return _fK_ACDepreciationCostAccountID; }
        //    set
        //    {
        //        if (value != this._fK_ACDepreciationCostAccountID)
        //        {
        //            _fK_ACDepreciationCostAccountID = value;
        //            NotifyChanged("FK_ACDepreciationCostAccountID");
        //        }
        //    }
        //}
        //public decimal ICProductOriginalAmount
        //{
        //    get { return _iCProductOriginalAmount; }
        //    set
        //    {
        //        if (value != this._iCProductOriginalAmount)
        //        {
        //            _iCProductOriginalAmount = value;
        //            NotifyChanged("ICProductOriginalAmount");
        //        }
        //    }
        //}
        //public decimal ICProductDepreciatedAmount
        //{
        //    get { return _iCProductDepreciatedAmount; }
        //    set
        //    {
        //        if (value != this._iCProductDepreciatedAmount)
        //        {
        //            _iCProductDepreciatedAmount = value;
        //            NotifyChanged("ICProductDepreciatedAmount");
        //        }
        //    }
        //}
        //public int FK_ACDepreciationAccountID
        //{
        //    get { return _fK_ACDepreciationAccountID; }
        //    set
        //    {
        //        if (value != this._fK_ACDepreciationAccountID)
        //        {
        //            _fK_ACDepreciationAccountID = value;
        //            NotifyChanged("FK_ACDepreciationAccountID");
        //        }
        //    }
        //}
        //public String ICProductAttributeFinishing
        //{
        //    get { return _iCProductAttributeFinishing; }
        //    set
        //    {
        //        if (value != this._iCProductAttributeFinishing)
        //        {
        //            _iCProductAttributeFinishing = value;
        //            NotifyChanged("ICProductAttributeFinishing");
        //        }
        //    }
        //}
        //public String ICProductAttributeFinishingText
        //{
        //    get { return _iCProductAttributeFinishingText; }
        //    set
        //    {
        //        if (value != this._iCProductAttributeFinishingText)
        //        {
        //            _iCProductAttributeFinishingText = value;
        //            NotifyChanged("ICProductAttributeFinishingText");
        //        }
        //    }
        //}
        //public String ICProductWoodGroup
        //{
        //    get { return _iCProductWoodGroup; }
        //    set
        //    {
        //        if (value != this._iCProductWoodGroup)
        //        {
        //            _iCProductWoodGroup = value;
        //            NotifyChanged("ICProductWoodGroup");
        //        }
        //    }
        //}
        //public int FK_ICProductWorkGroupID
        //{
        //    get { return _fK_ICProductWorkGroupID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductWorkGroupID)
        //        {
        //            _fK_ICProductWorkGroupID = value;
        //            NotifyChanged("FK_ICProductWorkGroupID");
        //        }
        //    }
        //}
        public String ICProductWorkType
        {
            get { return _iCProductWorkType; }
            set
            {
                if (value != this._iCProductWorkType)
                {
                    _iCProductWorkType = value;
                    NotifyChanged("ICProductWorkType");
                }
            }
        }

        //public decimal ICProductWorkUnitPrice
        //{
        //    get { return _iCProductWorkUnitPrice; }
        //    set
        //    {
        //        if (value != this._iCProductWorkUnitPrice)
        //        {
        //            _iCProductWorkUnitPrice = value;
        //            NotifyChanged("ICProductWorkUnitPrice");
        //        }
        //    }
        //}
        //public decimal ICProductMaterialUnitPrice
        //{
        //    get { return _iCProductMaterialUnitPrice; }
        //    set
        //    {
        //        if (value != this._iCProductMaterialUnitPrice)
        //        {
        //            _iCProductMaterialUnitPrice = value;
        //            NotifyChanged("ICProductMaterialUnitPrice");
        //        }
        //    }
        //}
        //public decimal ICProductEquipmentUnitPrice
        //{
        //    get { return _iCProductEquipmentUnitPrice; }
        //    set
        //    {
        //        if (value != this._iCProductEquipmentUnitPrice)
        //        {
        //            _iCProductEquipmentUnitPrice = value;
        //            NotifyChanged("ICProductEquipmentUnitPrice");
        //        }
        //    }
        //}
        //public String ICProductOriginOfProduct
        //{
        //    get { return _iCProductOriginOfProduct; }
        //    set
        //    {
        //        if (value != this._iCProductOriginOfProduct)
        //        {
        //            _iCProductOriginOfProduct = value;
        //            NotifyChanged("ICProductOriginOfProduct");
        //        }
        //    }
        //}
        //public bool ICProductChargeCheck
        //{
        //    get { return _iCProductChargeCheck; }
        //    set
        //    {
        //        if (value != this._iCProductChargeCheck)
        //        {
        //            _iCProductChargeCheck = value;
        //            NotifyChanged("ICProductChargeCheck");
        //        }
        //    }
        //}
        //public bool ICProductLockedPurchaseOrder
        //{
        //    get { return _iCProductLockedPurchaseOrder; }
        //    set
        //    {
        //        if (value != this._iCProductLockedPurchaseOrder)
        //        {
        //            _iCProductLockedPurchaseOrder = value;
        //            NotifyChanged("ICProductLockedPurchaseOrder");
        //        }
        //    }
        //}
        //public decimal ICProductMinLength
        //{
        //    get { return _iCProductMinLength; }
        //    set
        //    {
        //        if (value != this._iCProductMinLength)
        //        {
        //            _iCProductMinLength = value;
        //            NotifyChanged("ICProductMinLength");
        //        }
        //    }
        //}
        //public decimal ICProductMaxHeight
        //{
        //    get { return _iCProductMaxHeight; }
        //    set
        //    {
        //        if (value != this._iCProductMaxHeight)
        //        {
        //            _iCProductMaxHeight = value;
        //            NotifyChanged("ICProductMaxHeight");
        //        }
        //    }
        //}
        //public String ICProductTargetType
        //{
        //    get { return _iCProductTargetType; }
        //    set
        //    {
        //        if (value != this._iCProductTargetType)
        //        {
        //            _iCProductTargetType = value;
        //            NotifyChanged("ICProductTargetType");
        //        }
        //    }
        //}
        //public String ICProductOrigin
        //{
        //    get { return _iCProductOrigin; }
        //    set
        //    {
        //        if (value != this._iCProductOrigin)
        //        {
        //            _iCProductOrigin = value;
        //            NotifyChanged("ICProductOrigin");
        //        }
        //    }
        //}
        //public int FK_ICModelID
        //{
        //    get { return _fK_ICModelID; }
        //    set
        //    {
        //        if (value != this._fK_ICModelID)
        //        {
        //            _fK_ICModelID = value;
        //            NotifyChanged("FK_ICModelID");
        //        }
        //    }
        //}
        //public String ICProductOtherSize
        //{
        //    get { return _iCProductOtherSize; }
        //    set
        //    {
        //        if (value != this._iCProductOtherSize)
        //        {
        //            _iCProductOtherSize = value;
        //            NotifyChanged("ICProductOtherSize");
        //        }
        //    }
        //}
        //public String ICProductImageFileName
        //{
        //    get { return _iCProductImageFileName; }
        //    set
        //    {
        //        if (value != this._iCProductImageFileName)
        //        {
        //            _iCProductImageFileName = value;
        //            NotifyChanged("ICProductImageFileName");
        //        }
        //    }
        //}
        //public int FK_ICProductParentID
        //{
        //    get { return _fK_ICProductParentID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductParentID)
        //        {
        //            _fK_ICProductParentID = value;
        //            NotifyChanged("FK_ICProductParentID");
        //        }
        //    }
        //}
        //public bool ICProductFixedNorm
        //{
        //    get { return _iCProductFixedNorm; }
        //    set
        //    {
        //        if (value != this._iCProductFixedNorm)
        //        {
        //            _iCProductFixedNorm = value;
        //            NotifyChanged("ICProductFixedNorm");
        //        }
        //    }
        //}
        //public int FK_MMProductionNormItemID
        //{
        //    get { return _fK_MMProductionNormItemID; }
        //    set
        //    {
        //        if (value != this._fK_MMProductionNormItemID)
        //        {
        //            _fK_MMProductionNormItemID = value;
        //            NotifyChanged("FK_MMProductionNormItemID");
        //        }
        //    }
        //}
        //public int FK_ACAccountRevenueInternalID
        //{
        //    get { return _fK_ACAccountRevenueInternalID; }
        //    set
        //    {
        //        if (value != this._fK_ACAccountRevenueInternalID)
        //        {
        //            _fK_ACAccountRevenueInternalID = value;
        //            NotifyChanged("FK_ACAccountRevenueInternalID");
        //        }
        //    }
        //}

        //public int FK_ACAccountCostPriceID
        //{
        //    get { return _fK_ACAccountCostPriceID; }
        //    set
        //    {
        //        if (value != this._fK_ACAccountCostPriceID)
        //        {
        //            _fK_ACAccountCostPriceID = value;
        //            NotifyChanged("FK_ACAccountCostPriceID");
        //        }
        //    }
        //}
        //public int FK_ACAccountRevenueID
        //{
        //    get { return _fK_ACAccountRevenueID; }
        //    set
        //    {
        //        if (value != this._fK_ACAccountRevenueID)
        //        {
        //            _fK_ACAccountRevenueID = value;
        //            NotifyChanged("FK_ACAccountRevenueID");
        //        }
        //    }
        //}
        //public int FK_ACAccountSaleReturnID
        //{
        //    get { return _fK_ACAccountSaleReturnID; }
        //    set
        //    {
        //        if (value != this._fK_ACAccountSaleReturnID)
        //        {
        //            _fK_ACAccountSaleReturnID = value;
        //            NotifyChanged("FK_ACAccountSaleReturnID");
        //        }
        //    }
        //}
        //public int FK_ACAccountDiscountID
        //{
        //    get { return _fK_ACAccountDiscountID; }
        //    set
        //    {
        //        if (value != this._fK_ACAccountDiscountID)
        //        {
        //            _fK_ACAccountDiscountID = value;
        //            NotifyChanged("FK_ACAccountDiscountID");
        //        }
        //    }
        //}
        //public String ICProductLicensePlate
        //{
        //    get { return _iCProductLicensePlate; }
        //    set
        //    {
        //        if (value != this._iCProductLicensePlate)
        //        {
        //            _iCProductLicensePlate = value;
        //            NotifyChanged("ICProductLicensePlate");
        //        }
        //    }
        //}
        //public decimal ICProductBulk
        //{
        //    get { return _iCProductBulk; }
        //    set
        //    {
        //        if (value != this._iCProductBulk)
        //        {
        //            _iCProductBulk = value;
        //            NotifyChanged("ICProductBulk");
        //        }
        //    }
        //}
        //public decimal ICProductCapacity
        //{
        //    get { return _iCProductCapacity; }
        //    set
        //    {
        //        if (value != this._iCProductCapacity)
        //        {
        //            _iCProductCapacity = value;
        //            NotifyChanged("ICProductCapacity");
        //        }
        //    }
        //}
        //public decimal ICProductDepth
        //{
        //    get { return _iCProductDepth; }
        //    set
        //    {
        //        if (value != this._iCProductDepth)
        //        {
        //            _iCProductDepth = value;
        //            NotifyChanged("ICProductDepth");
        //        }
        //    }
        //}
        //public decimal ICProductRadius
        //{
        //    get { return _iCProductRadius; }
        //    set
        //    {
        //        if (value != this._iCProductRadius)
        //        {
        //            _iCProductRadius = value;
        //            NotifyChanged("ICProductRadius");
        //        }
        //    }
        //}
        //public decimal ICProductDiameter
        //{
        //    get { return _iCProductDiameter; }
        //    set
        //    {
        //        if (value != this._iCProductDiameter)
        //        {
        //            _iCProductDiameter = value;
        //            NotifyChanged("ICProductDiameter");
        //        }
        //    }
        //}
        //public decimal ICProductThickness
        //{
        //    get { return _iCProductThickness; }
        //    set
        //    {
        //        if (value != this._iCProductThickness)
        //        {
        //            _iCProductThickness = value;
        //            NotifyChanged("ICProductThickness");
        //        }
        //    }
        //}
        //public int FK_ICProductGroupHeightID
        //{
        //    get { return _fK_ICProductGroupHeightID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductGroupHeightID)
        //        {
        //            _fK_ICProductGroupHeightID = value;
        //            NotifyChanged("FK_ICProductGroupHeightID");
        //        }
        //    }
        //}
        //public int FK_ICProductFormulaPriceConfigID
        //{
        //    get { return _fK_ICProductFormulaPriceConfigID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductFormulaPriceConfigID)
        //        {
        //            _fK_ICProductFormulaPriceConfigID = value;
        //            NotifyChanged("FK_ICProductFormulaPriceConfigID");
        //        }
        //    }
        //}
        //public decimal ICProductGuaranteeMonth
        //{
        //    get { return _iCProductGuaranteeMonth; }
        //    set
        //    {
        //        if (value != this._iCProductGuaranteeMonth)
        //        {
        //            _iCProductGuaranteeMonth = value;
        //            NotifyChanged("ICProductGuaranteeMonth");
        //        }
        //    }
        //}
        //public int FK_HREmployeeID
        //{
        //    get { return _fK_HREmployeeID; }
        //    set
        //    {
        //        if (value != this._fK_HREmployeeID)
        //        {
        //            _fK_HREmployeeID = value;
        //            NotifyChanged("FK_HREmployeeID");
        //        }
        //    }
        //}
        //public String ICProductTemplateType
        //{
        //    get { return _iCProductTemplateType; }
        //    set
        //    {
        //        if (value != this._iCProductTemplateType)
        //        {
        //            _iCProductTemplateType = value;
        //            NotifyChanged("ICProductTemplateType");
        //        }
        //    }
        //}
        //public bool ICProductPromotionCheck
        //{
        //    get { return _iCProductPromotionCheck; }
        //    set
        //    {
        //        if (value != this._iCProductPromotionCheck)
        //        {
        //            _iCProductPromotionCheck = value;
        //            NotifyChanged("ICProductPromotionCheck");
        //        }
        //    }
        //}
        //public int FK_ICProductTypeAccountConfigID
        //{
        //    get { return _fK_ICProductTypeAccountConfigID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductTypeAccountConfigID)
        //        {
        //            _fK_ICProductTypeAccountConfigID = value;
        //            NotifyChanged("FK_ICProductTypeAccountConfigID");
        //        }
        //    }
        //}
        //public String ICProductUses
        //{
        //    get { return _iCProductUses; }
        //    set
        //    {
        //        if (value != this._iCProductUses)
        //        {
        //            _iCProductUses = value;
        //            NotifyChanged("ICProductUses");
        //        }
        //    }
        //}
        //public bool ICProductNonRetail
        //{
        //    get { return _iCProductNonRetail; }
        //    set
        //    {
        //        if (value != this._iCProductNonRetail)
        //        {
        //            _iCProductNonRetail = value;
        //            NotifyChanged("ICProductNonRetail");
        //        }
        //    }
        //}
        //public bool ICProductIsShowWeb
        //{
        //    get { return _iCProductIsShowWeb; }
        //    set
        //    {
        //        if (value != this._iCProductIsShowWeb)
        //        {
        //            _iCProductIsShowWeb = value;
        //            NotifyChanged("ICProductIsShowWeb");
        //        }
        //    }
        //}
        //public String ICProductTrademark
        //{
        //    get { return _iCProductTrademark; }
        //    set
        //    {
        //        if (value != this._iCProductTrademark)
        //        {
        //            _iCProductTrademark = value;
        //            NotifyChanged("ICProductTrademark");
        //        }
        //    }
        //}
        //public String ICProductDepartmentGroup
        //{
        //    get { return _iCProductDepartmentGroup; }
        //    set
        //    {
        //        if (value != this._iCProductDepartmentGroup)
        //        {
        //            _iCProductDepartmentGroup = value;
        //            NotifyChanged("ICProductDepartmentGroup");
        //        }
        //    }
        //}
        //public int FK_BRBranchID
        //{
        //    get { return _fK_BRBranchID; }
        //    set
        //    {
        //        if (value != this._fK_BRBranchID)
        //        {
        //            _fK_BRBranchID = value;
        //            NotifyChanged("FK_BRBranchID");
        //        }
        //    }
        //}
        //public int FK_ACCostCenterID
        //{
        //    get { return _fK_ACCostCenterID; }
        //    set
        //    {
        //        if (value != this._fK_ACCostCenterID)
        //        {
        //            _fK_ACCostCenterID = value;
        //            NotifyChanged("FK_ACCostCenterID");
        //        }
        //    }
        //}
        //public int FK_ACSegmentID
        //{
        //    get { return _fK_ACSegmentID; }
        //    set
        //    {
        //        if (value != this._fK_ACSegmentID)
        //        {
        //            _fK_ACSegmentID = value;
        //            NotifyChanged("FK_ACSegmentID");
        //        }
        //    }
        //}
        //public int FK_ACEquipmentTypeAccountConfigID
        //{
        //    get { return _fK_ACEquipmentTypeAccountConfigID; }
        //    set
        //    {
        //        if (value != this._fK_ACEquipmentTypeAccountConfigID)
        //        {
        //            _fK_ACEquipmentTypeAccountConfigID = value;
        //            NotifyChanged("FK_ACEquipmentTypeAccountConfigID");
        //        }
        //    }
        //}
        //public bool ICProductAlternativeCheck
        //{
        //    get { return _iCProductAlternativeCheck; }
        //    set
        //    {
        //        if (value != this._iCProductAlternativeCheck)
        //        {
        //            _iCProductAlternativeCheck = value;
        //            NotifyChanged("ICProductAlternativeCheck");
        //        }
        //    }
        //}
        //public int FK_ICPriceCalculationMethodID
        //{
        //    get { return _fK_ICPriceCalculationMethodID; }
        //    set
        //    {
        //        if (value != this._fK_ICPriceCalculationMethodID)
        //        {
        //            _fK_ICPriceCalculationMethodID = value;
        //            NotifyChanged("FK_ICPriceCalculationMethodID");
        //        }
        //    }
        //}
        public String ICProductImageFile
        {
            get { return _iCProductImageFile; }
            set
            {
                if (value != this._iCProductImageFile)
                {
                    _iCProductImageFile = value;
                    NotifyChanged("ICProductImageFile");
                }
            }
        }
        public decimal ICProductBlock
        {
            get { return _iCProductBlock; }
            set
            {
                if (value != this._iCProductBlock)
                {
                    _iCProductBlock = value;
                    NotifyChanged("ICProductBlock");
                }
            }
        }
        public decimal ICProductVolume
        {
            get { return _iCProductVolume; }
            set
            {
                if (value != this._iCProductVolume)
                {
                    _iCProductVolume = value;
                    NotifyChanged("ICProductVolume");
                }
            }
        }
        //public String ICProductImageName
        //{
        //    get { return _iCProductImageName; }
        //    set
        //    {
        //        if (value != this._iCProductImageName)
        //        {
        //            _iCProductImageName = value;
        //            NotifyChanged("ICProductImageName");
        //        }
        //    }
        //}
        //public int FK_MMFormulaIDPaintA
        //{
        //    get { return _fK_MMFormulaIDPaintA; }
        //    set
        //    {
        //        if (value != this._fK_MMFormulaIDPaintA)
        //        {
        //            _fK_MMFormulaIDPaintA = value;
        //            NotifyChanged("FK_MMFormulaIDPaintA");
        //        }
        //    }
        //}
        //public int FK_MMFormulaIDPaintB
        //{
        //    get { return _fK_MMFormulaIDPaintB; }
        //    set
        //    {
        //        if (value != this._fK_MMFormulaIDPaintB)
        //        {
        //            _fK_MMFormulaIDPaintB = value;
        //            NotifyChanged("FK_MMFormulaIDPaintB");
        //        }
        //    }
        //}
        //public int FK_ICProductAttributeQualityID
        //{
        //    get { return _fK_ICProductAttributeQualityID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductAttributeQualityID)
        //        {
        //            _fK_ICProductAttributeQualityID = value;
        //            NotifyChanged("FK_ICProductAttributeQualityID");
        //        }
        //    }
        //}
        public decimal ICProductDepreciationRate
        {
            get { return _iCProductDepreciationRate; }
            set
            {
                if (value != this._iCProductDepreciationRate)
                {
                    _iCProductDepreciationRate = value;
                    NotifyChanged("ICProductDepreciationRate");
                }
            }
        }
        public decimal ICProductDepreciationQty
        {
            get { return _iCProductDepreciationQty; }
            set
            {
                if (value != this._iCProductDepreciationQty)
                {
                    _iCProductDepreciationQty = value;
                    NotifyChanged("ICProductDepreciationQty");
                }
            }
        }
        //public int FK_ARCustomerID
        //{
        //    get { return _fK_ARCustomerID; }
        //    set
        //    {
        //        if (value != this._fK_ARCustomerID)
        //        {
        //            _fK_ARCustomerID = value;
        //            NotifyChanged("FK_ARCustomerID");
        //        }
        //    }
        //}
        //public int FK_MMFormulaIDPaintC
        //{
        //    get { return _fK_MMFormulaIDPaintC; }
        //    set
        //    {
        //        if (value != this._fK_MMFormulaIDPaintC)
        //        {
        //            _fK_MMFormulaIDPaintC = value;
        //            NotifyChanged("FK_MMFormulaIDPaintC");
        //        }
        //    }
        //}
        //public decimal ICProductCartonBlock
        //{
        //    get { return _iCProductCartonBlock; }
        //    set
        //    {
        //        if (value != this._iCProductCartonBlock)
        //        {
        //            _iCProductCartonBlock = value;
        //            NotifyChanged("ICProductCartonBlock");
        //        }
        //    }
        //}
        public decimal ICProductInsideDimensionLength
        {
            get { return _iCProductInsideDimensionLength; }
            set
            {
                if (value != this._iCProductInsideDimensionLength)
                {
                    _iCProductInsideDimensionLength = value;
                    NotifyChanged("ICProductInsideDimensionLength");
                }
            }
        }
        public decimal ICProductInsideDimensionWidth
        {
            get { return _iCProductInsideDimensionWidth; }
            set
            {
                if (value != this._iCProductInsideDimensionWidth)
                {
                    _iCProductInsideDimensionWidth = value;
                    NotifyChanged("ICProductInsideDimensionWidth");
                }
            }
        }
        public decimal ICProductInsideDimensionHeight
        {
            get { return _iCProductInsideDimensionHeight; }
            set
            {
                if (value != this._iCProductInsideDimensionHeight)
                {
                    _iCProductInsideDimensionHeight = value;
                    NotifyChanged("ICProductInsideDimensionHeight");
                }
            }
        }
        public decimal ICProductOverallDimensionLength
        {
            get { return _iCProductOverallDimensionLength; }
            set
            {
                if (value != this._iCProductOverallDimensionLength)
                {
                    _iCProductOverallDimensionLength = value;
                    NotifyChanged("ICProductOverallDimensionLength");
                }
            }
        }
        public decimal ICProductOverallDimensionWidth
        {
            get { return _iCProductOverallDimensionWidth; }
            set
            {
                if (value != this._iCProductOverallDimensionWidth)
                {
                    _iCProductOverallDimensionWidth = value;
                    NotifyChanged("ICProductOverallDimensionWidth");
                }
            }
        }
        public decimal ICProductOverallDimensionHeight
        {
            get { return _iCProductOverallDimensionHeight; }
            set
            {
                if (value != this._iCProductOverallDimensionHeight)
                {
                    _iCProductOverallDimensionHeight = value;
                    NotifyChanged("ICProductOverallDimensionHeight");
                }
            }
        }
        //public int ICProductQtyInBox
        //{
        //    get { return _iCProductQtyInBox; }
        //    set
        //    {
        //        if (value != this._iCProductQtyInBox)
        //        {
        //            _iCProductQtyInBox = value;
        //            NotifyChanged("ICProductQtyInBox");
        //        }
        //    }
        //}
        public decimal ICProductNetWeight
        {
            get { return _iCProductNetWeight; }
            set
            {
                if (value != this._iCProductNetWeight)
                {
                    _iCProductNetWeight = value;
                    NotifyChanged("ICProductNetWeight");
                }
            }
        }
        public decimal ICProductGrossWeight
        {
            get { return _iCProductGrossWeight; }
            set
            {
                if (value != this._iCProductGrossWeight)
                {
                    _iCProductGrossWeight = value;
                    NotifyChanged("ICProductGrossWeight");
                }
            }
        }
        //public String ICProductPurchaseType
        //{
        //    get { return _iCProductPurchaseType; }
        //    set
        //    {
        //        if (value != this._iCProductPurchaseType)
        //        {
        //            _iCProductPurchaseType = value;
        //            NotifyChanged("ICProductPurchaseType");
        //        }
        //    }
        //}
        //public decimal ICProductLeadTime
        //{
        //    get { return _iCProductLeadTime; }
        //    set
        //    {
        //        if (value != this._iCProductLeadTime)
        //        {
        //            _iCProductLeadTime = value;
        //            NotifyChanged("ICProductLeadTime");
        //        }
        //    }
        //}
        //public decimal ICProductBoxArea
        //{
        //    get { return _iCProductBoxArea; }
        //    set
        //    {
        //        if (value != this._iCProductBoxArea)
        //        {
        //            _iCProductBoxArea = value;
        //            NotifyChanged("ICProductBoxArea");
        //        }
        //    }
        //}
        //public decimal ICProductBoxUnitPrice
        //{
        //    get { return _iCProductBoxUnitPrice; }
        //    set
        //    {
        //        if (value != this._iCProductBoxUnitPrice)
        //        {
        //            _iCProductBoxUnitPrice = value;
        //            NotifyChanged("ICProductBoxUnitPrice");
        //        }
        //    }
        //}
        public int FK_ICProductCarcassID
        {
            get { return _fK_ICProductCarcassID; }
            set
            {
                if (value != this._fK_ICProductCarcassID)
                {
                    _fK_ICProductCarcassID = value;
                    NotifyChanged("FK_ICProductCarcassID");
                }
            }
        }
        public String ICProductCode
        {
            get { return _iCProductCode; }
            set
            {
                if (value != this._iCProductCode)
                {
                    _iCProductCode = value;
                    NotifyChanged("ICProductCode");
                }
            }
        }
        //public int FK_ICProductStockSaveID
        //{
        //    get { return _fK_ICProductStockSaveID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductStockSaveID)
        //        {
        //            _fK_ICProductStockSaveID = value;
        //            NotifyChanged("FK_ICProductStockSaveID");
        //        }
        //    }
        //}
        //public int ICProductStockSaveDate
        //{
        //    get { return _iCProductStockSaveDate; }
        //    set
        //    {
        //        if (value != this._iCProductStockSaveDate)
        //        {
        //            _iCProductStockSaveDate = value;
        //            NotifyChanged("ICProductStockSaveDate");
        //        }
        //    }
        //}
        //public int FK_ICPerimeterGroupID
        //{
        //    get { return _fK_ICPerimeterGroupID; }
        //    set
        //    {
        //        if (value != this._fK_ICPerimeterGroupID)
        //        {
        //            _fK_ICPerimeterGroupID = value;
        //            NotifyChanged("FK_ICPerimeterGroupID");
        //        }
        //    }
        //}
        //public int FK_ICLengthGroupID
        //{
        //    get { return _fK_ICLengthGroupID; }
        //    set
        //    {
        //        if (value != this._fK_ICLengthGroupID)
        //        {
        //            _fK_ICLengthGroupID = value;
        //            NotifyChanged("FK_ICLengthGroupID");
        //        }
        //    }
        //}
        //public int FK_ICStockGroupID
        //{
        //    get { return _fK_ICStockGroupID; }
        //    set
        //    {
        //        if (value != this._fK_ICStockGroupID)
        //        {
        //            _fK_ICStockGroupID = value;
        //            NotifyChanged("FK_ICStockGroupID");
        //        }
        //    }
        //}
        public bool ICProductCheckCarcass
        {
            get { return _iCProductCheckCarcass; }
            set
            {
                if (value != this._iCProductCheckCarcass)
                {
                    _iCProductCheckCarcass = value;
                    NotifyChanged("ICProductCheckCarcass");
                }
            }
        }
        //public int FK_ICProductWoodIngredientID
        //{
        //    get { return _fK_ICProductWoodIngredientID; }
        //    set
        //    {
        //        if (value != this._fK_ICProductWoodIngredientID)
        //        {
        //            _fK_ICProductWoodIngredientID = value;
        //            NotifyChanged("FK_ICProductWoodIngredientID");
        //        }
        //    }
        //}
        //public int FK_MMProcessID
        //{
        //    get { return _fK_MMProcessID; }
        //    set
        //    {
        //        if (value != this._fK_MMProcessID)
        //        {
        //            _fK_MMProcessID = value;
        //            NotifyChanged("FK_MMProcessID");
        //        }
        //    }
        //}
        //public bool ICProductHavePaint
        //{
        //    get { return _iCProductHavePaint; }
        //    set
        //    {
        //        if (value != this._iCProductHavePaint)
        //        {
        //            _iCProductHavePaint = value;
        //            NotifyChanged("ICProductHavePaint");
        //        }
        //    }
        //}
        public bool ICProductIsFollowInventoryStock
        {
            get { return _iCProductIsFollowInventoryStock; }
            set
            {
                if (value != this._iCProductIsFollowInventoryStock)
                {
                    _iCProductIsFollowInventoryStock = value;
                    NotifyChanged("ICProductIsFollowInventoryStock");
                }
            }
        }
        //public String ICProductResourceType
        //{
        //    get { return _iCProductResourceType; }
        //    set
        //    {
        //        if (value != this._iCProductResourceType)
        //        {
        //            _iCProductResourceType = value;
        //            NotifyChanged("ICProductResourceType");
        //        }
        //    }
        //}
        //public decimal ICProductConsumable
        //{
        //    get { return _iCProductConsumable; }
        //    set
        //    {
        //        if (value != this._iCProductConsumable)
        //        {
        //            _iCProductConsumable = value;
        //            NotifyChanged("ICProductConsumable");
        //        }
        //    }
        //}
        public bool ICProductIsGrain
        {
            get { return _iCProductIsGrain; }
            set
            {
                if (value != this._iCProductIsGrain)
                {
                    _iCProductIsGrain = value;
                    NotifyChanged("ICProductIsGrain");
                }
            }
        }
        //public decimal ICProductQuantitative
        //{
        //    get { return _iCProductQuantitative; }
        //    set
        //    {
        //        if (value != this._iCProductQuantitative)
        //        {
        //            _iCProductQuantitative = value;
        //            NotifyChanged("ICProductQuantitative");
        //        }
        //    }
        //}
        #endregion
        #region Extra Property
        public string ICProductParentNo { get; set; }
        public string ICProductParentName { get; set; }
        public string ICPriceCalculationMethodMethod { get; set; }
        public decimal ICProductPrintQty { get; set; }
        public String ICMeasureUnitName { get; set; }
        public string IPProductionItemParentCode { get; set; }
        public string IPProductionItemCode { get; set; }
        public decimal ICProductItemQty { get; set; }
        public string ColorWoodStatus { get; set; }
        public string ColorHardwareStatus { get; set; }
        public string ColorPaintStatus { get; set; }
        public string ColorPackingMaterialStatus { get; set; }
        public string CarcassWoodStatus { get; set; }
        public string CarcassHardwareStatus { get; set; }
        public string CarcassPaintStatus { get; set; }
        public string CarcassPackingMaterialStatus { get; set; }
        public int FK_MMOperationID { get; set; }
        public int FK_MMProductionNormCarcassID { get; set; }
        public string MMProductionNormNo { get; set; }
        public string MMProductionNormDesc { get; set; }
        public string MMProductionNormStatus { get; set; }
        public string ProductionNormStatus { get; set; }
        public int MMProductionNormID { get; set; }
        public string MMBatchProductNo { get; set; }
        public string ICProductWoodType { get; set; }
        public decimal MMProductionNormBlock { get; set; }
        public decimal MMProductionNormTotalPaint { get; set; }
        public DateTime MMProductionNormCreatedDate { get; set; }
        public string HREmployeeName { get; set; }
        public string ACObjectName { get; set; }
        #endregion
    }
}
