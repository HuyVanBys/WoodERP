﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICTransactions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICTransactionsInfo
    //Created Date:21 Tháng Mười Hai 2018
    //-----------------------------------------------------------

    public class ICTransactionsInfo : BusinessObject
    {
        public ICTransactionsInfo()
        {
        }
        #region Variables
        protected int _iCTransactionID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _iCTransactionReferenceID;
        protected String _iCTransactionReferenceNo = String.Empty;
        protected String _iCTransactionModuleName = String.Empty;
        protected String _iCTransactionModuleType = String.Empty;
        protected DateTime _iCTransactionDate = DateTime.MaxValue;
        protected int _iCTransactionRefItemID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected int _fK_ACObjectID;
        protected String _aCObjectType = String.Empty;
        protected String _aCObjectRepName = String.Empty;
        protected String _iCTransactionDesc = String.Empty;
        protected String _iCTransactionDetailDesc = String.Empty;
        protected int _fK_GECurrencyID;
        protected decimal _iCTransactionExchangeRate;
        protected int _fK_ICStockID;
        protected String _iCTransactionType = String.Empty;
        protected int _fK_ICImportAndExportReasonID;
        protected bool _iCTransactionIsSpecificCalculation = true;
        protected bool _iCTransactionIsAverageCalculation = true;
        protected int _fK_ICProductID;
        protected String _iCTransactionReceiptLotNo = String.Empty;
        protected String _iCTransactionReceiptSerialNo = String.Empty;
        protected int _fK_ICMeasureUnitID;
        protected decimal _iCTransactionQty;
        protected decimal _iCTransactionFactor;
        protected decimal _iCTransactionExchangeQty;
        protected decimal _iCTransactionQty1;
        protected decimal _iCTransactionQty2;
        protected decimal _iCTransactionQty3;
        protected String _iCTransactionFeePaymentType = String.Empty;
        protected decimal _iCTransactionUnitCost;
        protected decimal _iCTransactionTotalCost;
        protected decimal _iCTransactionExchangeUnitCost;
        protected decimal _iCTransactionExchangeTotalCost;
        protected int _fK_ACAccountID;
        protected int _fK_ACOffsetAccountID;
        protected int _fK_ACTransitInAccountID;
        protected int _fK_ACCostCenterID;
        protected int _fK_ACSegmentID;
        protected int _fK_MMBatchProductID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_MMWorkShopID;
        protected int _fK_MMOperationID;
        protected int _fK_MMLineID;
        protected int _fK_HRDepartmentRoomGroupItemID;
        protected int _fK_PMProjectID;
        protected int _fK_ACAssetID;
        protected int _fK_ICProductEquipmentID;
        protected int _fK_ACCostObjectID;
        protected int _fK_ACUnfinishedConstructionCostID;
        protected int _fK_ACLoanReceiptID;
        protected String _iCTransactionCode01Combo = String.Empty;
        protected String _iCTransactionCode02Combo = String.Empty;
        protected String _iCTransactionCode03Combo = String.Empty;
        protected String _iCTransactionCode04Combo = String.Empty;
        protected String _iCTransactionCode05Combo = String.Empty;
        protected String _iCTransactionCode06Combo = String.Empty;
        protected String _iCTransactionCode07Combo = String.Empty;
        protected String _iCTransactionCode08Combo = String.Empty;
        protected String _iCTransactionCode09Combo = String.Empty;
        protected String _iCTransactionCode10Combo = String.Empty;
        protected int _fK_ICPerimeterGroupID;
        protected int _fK_ICLengthGroupID;
        protected decimal _iCTransactionLength;
        protected decimal _iCTransactionWidth;
        protected decimal _iCTransactionHeight;
        protected String _iCTransactionPurposeType = String.Empty;
        protected int _fK_ICProductAttributeQualityID;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_ICProductForBatchID;
        protected DateTime _iCTransactionExpiryDate = DateTime.MaxValue;
        protected decimal _iCTransactionLengthMin;
        protected decimal _iCTransactionWidthMin;
        protected decimal _iCTransactionHeightMin;
        protected decimal _iCTransactionLengthMax;
        protected decimal _iCTransactionWidthMax;
        protected decimal _iCTransactionHeightMax;
        protected decimal _iCTransactionPerimeter;
        #endregion

        #region Public properties
        public int ICTransactionID
        {
            get { return _iCTransactionID; }
            set
            {
                if (value != this._iCTransactionID)
                {
                    _iCTransactionID = value;
                    NotifyChanged("ICTransactionID");
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
        public int ICTransactionReferenceID
        {
            get { return _iCTransactionReferenceID; }
            set
            {
                if (value != this._iCTransactionReferenceID)
                {
                    _iCTransactionReferenceID = value;
                    NotifyChanged("ICTransactionReferenceID");
                }
            }
        }
        public String ICTransactionReferenceNo
        {
            get { return _iCTransactionReferenceNo; }
            set
            {
                if (value != this._iCTransactionReferenceNo)
                {
                    _iCTransactionReferenceNo = value;
                    NotifyChanged("ICTransactionReferenceNo");
                }
            }
        }
        public String ICTransactionModuleName
        {
            get { return _iCTransactionModuleName; }
            set
            {
                if (value != this._iCTransactionModuleName)
                {
                    _iCTransactionModuleName = value;
                    NotifyChanged("ICTransactionModuleName");
                }
            }
        }
        public String ICTransactionModuleType
        {
            get { return _iCTransactionModuleType; }
            set
            {
                if (value != this._iCTransactionModuleType)
                {
                    _iCTransactionModuleType = value;
                    NotifyChanged("ICTransactionModuleType");
                }
            }
        }
        public DateTime ICTransactionDate
        {
            get { return _iCTransactionDate; }
            set
            {
                if (value != this._iCTransactionDate)
                {
                    _iCTransactionDate = value;
                    NotifyChanged("ICTransactionDate");
                }
            }
        }
        public int ICTransactionRefItemID
        {
            get { return _iCTransactionRefItemID; }
            set
            {
                if (value != this._iCTransactionRefItemID)
                {
                    _iCTransactionRefItemID = value;
                    NotifyChanged("ICTransactionRefItemID");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
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
        public String ACObjectType
        {
            get { return _aCObjectType; }
            set
            {
                if (value != this._aCObjectType)
                {
                    _aCObjectType = value;
                    NotifyChanged("ACObjectType");
                }
            }
        }
        public String ACObjectRepName
        {
            get { return _aCObjectRepName; }
            set
            {
                if (value != this._aCObjectRepName)
                {
                    _aCObjectRepName = value;
                    NotifyChanged("ACObjectRepName");
                }
            }
        }
        public String ICTransactionDesc
        {
            get { return _iCTransactionDesc; }
            set
            {
                if (value != this._iCTransactionDesc)
                {
                    _iCTransactionDesc = value;
                    NotifyChanged("ICTransactionDesc");
                }
            }
        }
        public String ICTransactionDetailDesc
        {
            get { return _iCTransactionDetailDesc; }
            set
            {
                if (value != this._iCTransactionDetailDesc)
                {
                    _iCTransactionDetailDesc = value;
                    NotifyChanged("ICTransactionDetailDesc");
                }
            }
        }
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public decimal ICTransactionExchangeRate
        {
            get { return _iCTransactionExchangeRate; }
            set
            {
                if (value != this._iCTransactionExchangeRate)
                {
                    _iCTransactionExchangeRate = value;
                    NotifyChanged("ICTransactionExchangeRate");
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
        public String ICTransactionType
        {
            get { return _iCTransactionType; }
            set
            {
                if (value != this._iCTransactionType)
                {
                    _iCTransactionType = value;
                    NotifyChanged("ICTransactionType");
                }
            }
        }
        public int FK_ICImportAndExportReasonID
        {
            get { return _fK_ICImportAndExportReasonID; }
            set
            {
                if (value != this._fK_ICImportAndExportReasonID)
                {
                    _fK_ICImportAndExportReasonID = value;
                    NotifyChanged("FK_ICImportAndExportReasonID");
                }
            }
        }
        public bool ICTransactionIsSpecificCalculation
        {
            get { return _iCTransactionIsSpecificCalculation; }
            set
            {
                if (value != this._iCTransactionIsSpecificCalculation)
                {
                    _iCTransactionIsSpecificCalculation = value;
                    NotifyChanged("ICTransactionIsSpecificCalculation");
                }
            }
        }
        public bool ICTransactionIsAverageCalculation
        {
            get { return _iCTransactionIsAverageCalculation; }
            set
            {
                if (value != this._iCTransactionIsAverageCalculation)
                {
                    _iCTransactionIsAverageCalculation = value;
                    NotifyChanged("ICTransactionIsAverageCalculation");
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
        public String ICTransactionReceiptLotNo
        {
            get { return _iCTransactionReceiptLotNo; }
            set
            {
                if (value != this._iCTransactionReceiptLotNo)
                {
                    _iCTransactionReceiptLotNo = value;
                    NotifyChanged("ICTransactionReceiptLotNo");
                }
            }
        }
        public String ICTransactionReceiptSerialNo
        {
            get { return _iCTransactionReceiptSerialNo; }
            set
            {
                if (value != this._iCTransactionReceiptSerialNo)
                {
                    _iCTransactionReceiptSerialNo = value;
                    NotifyChanged("ICTransactionReceiptSerialNo");
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
        public decimal ICTransactionQty
        {
            get { return _iCTransactionQty; }
            set
            {
                if (value != this._iCTransactionQty)
                {
                    _iCTransactionQty = value;
                    NotifyChanged("ICTransactionQty");
                }
            }
        }
        public decimal ICTransactionFactor
        {
            get { return _iCTransactionFactor; }
            set
            {
                if (value != this._iCTransactionFactor)
                {
                    _iCTransactionFactor = value;
                    NotifyChanged("ICTransactionFactor");
                }
            }
        }
        public decimal ICTransactionExchangeQty
        {
            get { return _iCTransactionExchangeQty; }
            set
            {
                if (value != this._iCTransactionExchangeQty)
                {
                    _iCTransactionExchangeQty = value;
                    NotifyChanged("ICTransactionExchangeQty");
                }
            }
        }
        public decimal ICTransactionQty1
        {
            get { return _iCTransactionQty1; }
            set
            {
                if (value != this._iCTransactionQty1)
                {
                    _iCTransactionQty1 = value;
                    NotifyChanged("ICTransactionQty1");
                }
            }
        }
        public decimal ICTransactionQty2
        {
            get { return _iCTransactionQty2; }
            set
            {
                if (value != this._iCTransactionQty2)
                {
                    _iCTransactionQty2 = value;
                    NotifyChanged("ICTransactionQty2");
                }
            }
        }
        public decimal ICTransactionQty3
        {
            get { return _iCTransactionQty3; }
            set
            {
                if (value != this._iCTransactionQty3)
                {
                    _iCTransactionQty3 = value;
                    NotifyChanged("ICTransactionQty3");
                }
            }
        }
        public String ICTransactionFeePaymentType
        {
            get { return _iCTransactionFeePaymentType; }
            set
            {
                if (value != this._iCTransactionFeePaymentType)
                {
                    _iCTransactionFeePaymentType = value;
                    NotifyChanged("ICTransactionFeePaymentType");
                }
            }
        }
        public decimal ICTransactionUnitCost
        {
            get { return _iCTransactionUnitCost; }
            set
            {
                if (value != this._iCTransactionUnitCost)
                {
                    _iCTransactionUnitCost = value;
                    NotifyChanged("ICTransactionUnitCost");
                }
            }
        }
        public decimal ICTransactionTotalCost
        {
            get { return _iCTransactionTotalCost; }
            set
            {
                if (value != this._iCTransactionTotalCost)
                {
                    _iCTransactionTotalCost = value;
                    NotifyChanged("ICTransactionTotalCost");
                }
            }
        }
        public decimal ICTransactionExchangeUnitCost
        {
            get { return _iCTransactionExchangeUnitCost; }
            set
            {
                if (value != this._iCTransactionExchangeUnitCost)
                {
                    _iCTransactionExchangeUnitCost = value;
                    NotifyChanged("ICTransactionExchangeUnitCost");
                }
            }
        }
        public decimal ICTransactionExchangeTotalCost
        {
            get { return _iCTransactionExchangeTotalCost; }
            set
            {
                if (value != this._iCTransactionExchangeTotalCost)
                {
                    _iCTransactionExchangeTotalCost = value;
                    NotifyChanged("ICTransactionExchangeTotalCost");
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
        public int FK_ACOffsetAccountID
        {
            get { return _fK_ACOffsetAccountID; }
            set
            {
                if (value != this._fK_ACOffsetAccountID)
                {
                    _fK_ACOffsetAccountID = value;
                    NotifyChanged("FK_ACOffsetAccountID");
                }
            }
        }
        public int FK_ACTransitInAccountID
        {
            get { return _fK_ACTransitInAccountID; }
            set
            {
                if (value != this._fK_ACTransitInAccountID)
                {
                    _fK_ACTransitInAccountID = value;
                    NotifyChanged("FK_ACTransitInAccountID");
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
        public int FK_ACSegmentID
        {
            get { return _fK_ACSegmentID; }
            set
            {
                if (value != this._fK_ACSegmentID)
                {
                    _fK_ACSegmentID = value;
                    NotifyChanged("FK_ACSegmentID");
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
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public int FK_HRDepartmentRoomID
        {
            get { return _fK_HRDepartmentRoomID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomID)
                {
                    _fK_HRDepartmentRoomID = value;
                    NotifyChanged("FK_HRDepartmentRoomID");
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
        public int FK_MMLineID
        {
            get { return _fK_MMLineID; }
            set
            {
                if (value != this._fK_MMLineID)
                {
                    _fK_MMLineID = value;
                    NotifyChanged("FK_MMLineID");
                }
            }
        }
        public int FK_HRDepartmentRoomGroupItemID
        {
            get { return _fK_HRDepartmentRoomGroupItemID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomGroupItemID)
                {
                    _fK_HRDepartmentRoomGroupItemID = value;
                    NotifyChanged("FK_HRDepartmentRoomGroupItemID");
                }
            }
        }
        public int FK_PMProjectID
        {
            get { return _fK_PMProjectID; }
            set
            {
                if (value != this._fK_PMProjectID)
                {
                    _fK_PMProjectID = value;
                    NotifyChanged("FK_PMProjectID");
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
        public int FK_ACCostObjectID
        {
            get { return _fK_ACCostObjectID; }
            set
            {
                if (value != this._fK_ACCostObjectID)
                {
                    _fK_ACCostObjectID = value;
                    NotifyChanged("FK_ACCostObjectID");
                }
            }
        }
        public int FK_ACUnfinishedConstructionCostID
        {
            get { return _fK_ACUnfinishedConstructionCostID; }
            set
            {
                if (value != this._fK_ACUnfinishedConstructionCostID)
                {
                    _fK_ACUnfinishedConstructionCostID = value;
                    NotifyChanged("FK_ACUnfinishedConstructionCostID");
                }
            }
        }
        public int FK_ACLoanReceiptID
        {
            get { return _fK_ACLoanReceiptID; }
            set
            {
                if (value != this._fK_ACLoanReceiptID)
                {
                    _fK_ACLoanReceiptID = value;
                    NotifyChanged("FK_ACLoanReceiptID");
                }
            }
        }
        public String ICTransactionCode01Combo
        {
            get { return _iCTransactionCode01Combo; }
            set
            {
                if (value != this._iCTransactionCode01Combo)
                {
                    _iCTransactionCode01Combo = value;
                    NotifyChanged("ICTransactionCode01Combo");
                }
            }
        }
        public String ICTransactionCode02Combo
        {
            get { return _iCTransactionCode02Combo; }
            set
            {
                if (value != this._iCTransactionCode02Combo)
                {
                    _iCTransactionCode02Combo = value;
                    NotifyChanged("ICTransactionCode02Combo");
                }
            }
        }
        public String ICTransactionCode03Combo
        {
            get { return _iCTransactionCode03Combo; }
            set
            {
                if (value != this._iCTransactionCode03Combo)
                {
                    _iCTransactionCode03Combo = value;
                    NotifyChanged("ICTransactionCode03Combo");
                }
            }
        }
        public String ICTransactionCode04Combo
        {
            get { return _iCTransactionCode04Combo; }
            set
            {
                if (value != this._iCTransactionCode04Combo)
                {
                    _iCTransactionCode04Combo = value;
                    NotifyChanged("ICTransactionCode04Combo");
                }
            }
        }
        public String ICTransactionCode05Combo
        {
            get { return _iCTransactionCode05Combo; }
            set
            {
                if (value != this._iCTransactionCode05Combo)
                {
                    _iCTransactionCode05Combo = value;
                    NotifyChanged("ICTransactionCode05Combo");
                }
            }
        }
        public String ICTransactionCode06Combo
        {
            get { return _iCTransactionCode06Combo; }
            set
            {
                if (value != this._iCTransactionCode06Combo)
                {
                    _iCTransactionCode06Combo = value;
                    NotifyChanged("ICTransactionCode06Combo");
                }
            }
        }
        public String ICTransactionCode07Combo
        {
            get { return _iCTransactionCode07Combo; }
            set
            {
                if (value != this._iCTransactionCode07Combo)
                {
                    _iCTransactionCode07Combo = value;
                    NotifyChanged("ICTransactionCode07Combo");
                }
            }
        }
        public String ICTransactionCode08Combo
        {
            get { return _iCTransactionCode08Combo; }
            set
            {
                if (value != this._iCTransactionCode08Combo)
                {
                    _iCTransactionCode08Combo = value;
                    NotifyChanged("ICTransactionCode08Combo");
                }
            }
        }
        public String ICTransactionCode09Combo
        {
            get { return _iCTransactionCode09Combo; }
            set
            {
                if (value != this._iCTransactionCode09Combo)
                {
                    _iCTransactionCode09Combo = value;
                    NotifyChanged("ICTransactionCode09Combo");
                }
            }
        }
        public String ICTransactionCode10Combo
        {
            get { return _iCTransactionCode10Combo; }
            set
            {
                if (value != this._iCTransactionCode10Combo)
                {
                    _iCTransactionCode10Combo = value;
                    NotifyChanged("ICTransactionCode10Combo");
                }
            }
        }
        public int FK_ICPerimeterGroupID
        {
            get { return _fK_ICPerimeterGroupID; }
            set
            {
                if (value != this._fK_ICPerimeterGroupID)
                {
                    _fK_ICPerimeterGroupID = value;
                    NotifyChanged("FK_ICPerimeterGroupID");
                }
            }
        }
        public int FK_ICLengthGroupID
        {
            get { return _fK_ICLengthGroupID; }
            set
            {
                if (value != this._fK_ICLengthGroupID)
                {
                    _fK_ICLengthGroupID = value;
                    NotifyChanged("FK_ICLengthGroupID");
                }
            }
        }
        public decimal ICTransactionLength
        {
            get { return _iCTransactionLength; }
            set
            {
                if (value != this._iCTransactionLength)
                {
                    _iCTransactionLength = value;
                    NotifyChanged("ICTransactionLength");
                }
            }
        }
        public decimal ICTransactionWidth
        {
            get { return _iCTransactionWidth; }
            set
            {
                if (value != this._iCTransactionWidth)
                {
                    _iCTransactionWidth = value;
                    NotifyChanged("ICTransactionWidth");
                }
            }
        }
        public decimal ICTransactionHeight
        {
            get { return _iCTransactionHeight; }
            set
            {
                if (value != this._iCTransactionHeight)
                {
                    _iCTransactionHeight = value;
                    NotifyChanged("ICTransactionHeight");
                }
            }
        }
        public String ICTransactionPurposeType
        {
            get { return _iCTransactionPurposeType; }
            set
            {
                if (value != this._iCTransactionPurposeType)
                {
                    _iCTransactionPurposeType = value;
                    NotifyChanged("ICTransactionPurposeType");
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
        public DateTime ICTransactionExpiryDate
        {
            get { return _iCTransactionExpiryDate; }
            set
            {
                if (value != this._iCTransactionExpiryDate)
                {
                    _iCTransactionExpiryDate = value;
                    NotifyChanged("ICTransactionExpiryDate");
                }
            }
        }
        public decimal ICTransactionLengthMin
        {
            get { return _iCTransactionLengthMin; }
            set
            {
                if (value != this._iCTransactionLengthMin)
                {
                    _iCTransactionLengthMin = value;
                    NotifyChanged("ICTransactionLengthMin");
                }
            }
        }
        public decimal ICTransactionWidthMin
        {
            get { return _iCTransactionWidthMin; }
            set
            {
                if (value != this._iCTransactionWidthMin)
                {
                    _iCTransactionWidthMin = value;
                    NotifyChanged("ICTransactionWidthMin");
                }
            }
        }
        public decimal ICTransactionHeightMin
        {
            get { return _iCTransactionHeightMin; }
            set
            {
                if (value != this._iCTransactionHeightMin)
                {
                    _iCTransactionHeightMin = value;
                    NotifyChanged("ICTransactionHeightMin");
                }
            }
        }
        public decimal ICTransactionLengthMax
        {
            get { return _iCTransactionLengthMax; }
            set
            {
                if (value != this._iCTransactionLengthMax)
                {
                    _iCTransactionLengthMax = value;
                    NotifyChanged("ICTransactionLengthMax");
                }
            }
        }
        public decimal ICTransactionWidthMax
        {
            get { return _iCTransactionWidthMax; }
            set
            {
                if (value != this._iCTransactionWidthMax)
                {
                    _iCTransactionWidthMax = value;
                    NotifyChanged("ICTransactionWidthMax");
                }
            }
        }
        public decimal ICTransactionHeightMax
        {
            get { return _iCTransactionHeightMax; }
            set
            {
                if (value != this._iCTransactionHeightMax)
                {
                    _iCTransactionHeightMax = value;
                    NotifyChanged("ICTransactionHeightMax");
                }
            }
        }
        public decimal ICTransactionPerimeter
        {
            get { return _iCTransactionPerimeter; }
            set
            {
                if (value != this._iCTransactionPerimeter)
                {
                    _iCTransactionPerimeter = value;
                    NotifyChanged("ICTransactionPerimeter");
                }
            }
        }
        #endregion

        #region Extra property

        public decimal ICTransactionReceiptQty { get; set; }

        public decimal ICTransactionReceiptBalance { get; set; }

        public decimal ICTransactionShipmentQty { get; set; }

        public decimal ICTransactionShipmentBalance { get; set; }

        public string ICStockNo { get; set; }

        public string ICStockName { get; set; }

        public string ICProductNo { get; set; }

        public string ICProductNoOfOldSys { get; set; }

        public string ACAccountNo { get; set; }

        public string ICProductDesc { get; set; }

        public string ICProductName { get; set; }

        public decimal ICTransactionOpeningQty { get; set; }

        public decimal ICTransactionOpeningBalance { get; set; }

        public decimal ICTransactionEndQty { get; set; }

        public decimal ICTransactionEndBalance { get; set; }

        public decimal ICInventoryStockQuantity { get; set; }

        public decimal ICInventoryStockAllocationPlanQuantity { get; set; }
        public decimal ICInventoryStockSaleOrderQuantity { get; set; }
        public string GroupType { get; set; }
        public string ICProductName2 { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public int FK_ICDepartmentID { get; set; }
        public decimal ProductDepreciationRate { get; set; }
        public int ParentProductID { get; set; }
        public string ICMeasureUnitName { get; set; }
        public decimal ICTransactionNormQty { get; set; }
        public int FK_ICProductSerieID { get; set; }
        #endregion
    }
    #endregion
}