﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACAccountDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAccountDetailsInfo
    //Created Date:28 May 2012
    //-----------------------------------------------------------

    public class ACAccountDetailsInfo : BusinessObject
    {
        public ACAccountDetailsInfo()
        {
        }
        #region Variables
        protected int _aCAccountDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACAccountID;
        protected int _fK_ACObjectID;
        protected int _fK_CSCompanyBankID;
        protected int _fK_GECurrencyID;
        protected String _aCObjectType = String.Empty;
        protected decimal _aCAccountDetailExchangeRate;
        protected decimal _aCAccountDetailInitialBalanceByCurrency;
        protected decimal _aCAccountDetailInitialBalance;
        protected DateTime _aCAccountDetailDate = DateTime.MaxValue;
        protected int _fK_BRBranchID;
        protected decimal _aCDocumentDebitAmount;
        protected decimal _aCDocumentDebitExchangeAmount;
        protected decimal _aCDocumentCreditAmount;
        protected decimal _aCDocumentCreditExchangeAmount;
        protected int _fK_ICProductID;
        protected int _iCReceiptItemLotNo;
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
        #endregion

        #region Public properties
        public int ACAccountDetailID
        {
            get { return _aCAccountDetailID; }
            set
            {
                if (value != this._aCAccountDetailID)
                {
                    _aCAccountDetailID = value;
                    NotifyChanged("ACAccountDetailID");
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
        public int FK_CSCompanyBankID
        {
            get { return _fK_CSCompanyBankID; }
            set
            {
                if (value != this._fK_CSCompanyBankID)
                {
                    _fK_CSCompanyBankID = value;
                    NotifyChanged("FK_CSCompanyBankID");
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
        public decimal ACAccountDetailExchangeRate
        {
            get { return _aCAccountDetailExchangeRate; }
            set
            {
                if (value != this._aCAccountDetailExchangeRate)
                {
                    _aCAccountDetailExchangeRate = value;
                    NotifyChanged("ACAccountDetailExchangeRate");
                }
            }
        }
        public decimal ACAccountDetailInitialBalanceByCurrency
        {
            get { return _aCAccountDetailInitialBalanceByCurrency; }
            set
            {
                if (value != this._aCAccountDetailInitialBalanceByCurrency)
                {
                    _aCAccountDetailInitialBalanceByCurrency = value;
                    NotifyChanged("ACAccountDetailInitialBalanceByCurrency");
                }
            }
        }
        public decimal ACAccountDetailInitialBalance
        {
            get { return _aCAccountDetailInitialBalance; }
            set
            {
                if (value != this._aCAccountDetailInitialBalance)
                {
                    _aCAccountDetailInitialBalance = value;
                    NotifyChanged("ACAccountDetailInitialBalance");
                }
            }
        }
        public DateTime ACAccountDetailDate
        {
            get { return _aCAccountDetailDate; }
            set
            {
                if (value != this._aCAccountDetailDate)
                {
                    _aCAccountDetailDate = value;
                    NotifyChanged("ACAccountDetailDate");
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
        public decimal ACDocumentDebitAmount
        {
            get { return _aCDocumentDebitAmount; }
            set
            {
                if (value != this._aCDocumentDebitAmount)
                {
                    _aCDocumentDebitAmount = value;
                    NotifyChanged("ACDocumentDebitAmount");
                }
            }
        }
        public decimal ACDocumentDebitExchangeAmount
        {
            get { return _aCDocumentDebitExchangeAmount; }
            set
            {
                if (value != this._aCDocumentDebitExchangeAmount)
                {
                    _aCDocumentDebitExchangeAmount = value;
                    NotifyChanged("ACDocumentDebitExchangeAmount");
                }
            }
        }
        public decimal ACDocumentCreditAmount
        {
            get { return _aCDocumentCreditAmount; }
            set
            {
                if (value != this._aCDocumentCreditAmount)
                {
                    _aCDocumentCreditAmount = value;
                    NotifyChanged("ACDocumentCreditAmount");
                }
            }
        }
        public decimal ACDocumentCreditExchangeAmount
        {
            get { return _aCDocumentCreditExchangeAmount; }
            set
            {
                if (value != this._aCDocumentCreditExchangeAmount)
                {
                    _aCDocumentCreditExchangeAmount = value;
                    NotifyChanged("ACDocumentCreditExchangeAmount");
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
        public int ICReceiptItemLotNo
        {
            get { return _iCReceiptItemLotNo; }
            set
            {
                if (value != this._iCReceiptItemLotNo)
                {
                    _iCReceiptItemLotNo = value;
                    NotifyChanged("ICReceiptItemLotNo");
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
        #endregion


        #region Extra Properties
        public string ACObjectName { get; set; }

        public string ACAccountNo { get; set; }

        public string ACAccountName { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal AccountDebitBalance { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal AccountDebitBalanceByCurrency { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal AccountCreditBalance { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal AccountCreditBalanceByCurrency { get; set; }

        public string ACObjectNo { get; set; }

        public string ACAccountPostingRule { get; set; }

        #endregion
    }
    #endregion
}