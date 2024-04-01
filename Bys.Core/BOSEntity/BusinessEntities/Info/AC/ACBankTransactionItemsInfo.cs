﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACBankTransactionItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACBankTransactionItemsInfo
    //Created Date:Tuesday, March 13, 2012
    //-----------------------------------------------------------

    public class ACBankTransactionItemsInfo : BusinessObject
    {
        public ACBankTransactionItemsInfo()
        {
        }
        #region Variables
        protected int _aCBankTransactionItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACBankTransactionID;
        protected int _fK_ACEntryTypeID;
        protected int _fK_ACDebitAccountID;
        protected int _fK_ACCreditAccountID;
        protected int _fK_ACCostObjectID;
        protected String _aCBankTransactionItemDesc = String.Empty;
        protected decimal _aCBankTransactionItemAmount;
        protected decimal _aCBankTransactionItemExchangeAmount;
        protected int _fK_ACUnfinishedConstructionCostID;
        protected int _fK_HRAdvanceRefundID;
        protected int _fK_ACCostCenterID;
        protected int _fK_ACSegmentID;
        protected int _fK_HRAdvanceRequestItemID;
        protected int _fK_VMVehicleID;
        protected String _ACBankTransactionItemReference;
        protected String _aCBankTransactionItemVATDocumentType = String.Empty;
        protected String _aCBankTransactionItemVATFormNo = String.Empty;
        protected String _aCBankTransactionItemVoucherNo = String.Empty;
        protected DateTime _aCBankTransactionItemInvoiceDate = DateTime.MaxValue;
        protected String _aCBankTransactionItemVATInvoiceNo = String.Empty;
        protected String _aCBankTransactionItemVATSymbol = String.Empty;
        protected String _aCBankTransactionItemTaxNumber = String.Empty;
        protected decimal _aCBankTransactionItemTaxPercent;
        protected decimal _aCBankTransactionItemTaxAmount;
        protected decimal _aCBankTransactionItemTotalAmount;
        protected decimal _aCBankTransactionItemTotalExchangeAmount;
        protected int _fK_PMProjectID;
        protected int _fK_ACObjectID;
        protected String _aCObjectType = String.Empty;
        protected String _aCObjectName = String.Empty;
        protected int _fK_ACEInvoiceTypeID;
        protected int _fK_HRAdvanceRefundItemInvoiceID;
        protected decimal _aCBankTransactionItemFeeAmount;
        #endregion

        #region Public properties
        public int ACBankTransactionItemID
        {
            get { return _aCBankTransactionItemID; }
            set
            {
                if (value != this._aCBankTransactionItemID)
                {
                    _aCBankTransactionItemID = value;
                    NotifyChanged("ACBankTransactionItemID");
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
        public int FK_ACBankTransactionID
        {
            get { return _fK_ACBankTransactionID; }
            set
            {
                if (value != this._fK_ACBankTransactionID)
                {
                    _fK_ACBankTransactionID = value;
                    NotifyChanged("FK_ACBankTransactionID");
                }
            }
        }
        public int FK_ACEntryTypeID
        {
            get { return _fK_ACEntryTypeID; }
            set
            {
                if (value != this._fK_ACEntryTypeID)
                {
                    _fK_ACEntryTypeID = value;
                    NotifyChanged("FK_ACEntryTypeID");
                }
            }
        }
        public int FK_ACDebitAccountID
        {
            get { return _fK_ACDebitAccountID; }
            set
            {
                if (value != this._fK_ACDebitAccountID)
                {
                    _fK_ACDebitAccountID = value;
                    NotifyChanged("FK_ACDebitAccountID");
                }
            }
        }
        public int FK_ACCreditAccountID
        {
            get { return _fK_ACCreditAccountID; }
            set
            {
                if (value != this._fK_ACCreditAccountID)
                {
                    _fK_ACCreditAccountID = value;
                    NotifyChanged("FK_ACCreditAccountID");
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
        public String ACBankTransactionItemDesc
        {
            get { return _aCBankTransactionItemDesc; }
            set
            {
                if (value != this._aCBankTransactionItemDesc)
                {
                    _aCBankTransactionItemDesc = value;
                    NotifyChanged("ACBankTransactionItemDesc");
                }
            }
        }
        public decimal ACBankTransactionItemAmount
        {
            get { return _aCBankTransactionItemAmount; }
            set
            {
                if (value != this._aCBankTransactionItemAmount)
                {
                    _aCBankTransactionItemAmount = value;
                    NotifyChanged("ACBankTransactionItemAmount");
                }
            }
        }
        public decimal ACBankTransactionItemExchangeAmount
        {
            get { return _aCBankTransactionItemExchangeAmount; }
            set
            {
                if (value != this._aCBankTransactionItemExchangeAmount)
                {
                    _aCBankTransactionItemExchangeAmount = value;
                    NotifyChanged("ACBankTransactionItemExchangeAmount");
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
        public int FK_HRAdvanceRefundID
        {
            get { return _fK_HRAdvanceRefundID; }
            set
            {
                if (value != this._fK_HRAdvanceRefundID)
                {
                    _fK_HRAdvanceRefundID = value;
                    NotifyChanged("FK_HRAdvanceRefundID");
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
        public int FK_HRAdvanceRequestItemID
        {
            get { return _fK_HRAdvanceRequestItemID; }
            set
            {
                if (value != this._fK_HRAdvanceRequestItemID)
                {
                    _fK_HRAdvanceRequestItemID = value;
                    NotifyChanged("FK_HRAdvanceRequestItemID");
                }
            }
        }
        public int FK_VMVehicleID
        {
            get { return _fK_VMVehicleID; }
            set
            {
                if (value != this._fK_VMVehicleID)
                {
                    _fK_VMVehicleID = value;
                    NotifyChanged("FK_VMVehicleID");
                }
            }
        }

        public String ACBankTransactionItemReference
        {
            get { return _ACBankTransactionItemReference; }
            set
            {
                if (value != this._ACBankTransactionItemReference)
                {
                    _ACBankTransactionItemReference = value;
                    NotifyChanged("ACBankTransactionItemReference");
                }
            }
        }
        public String ACBankTransactionItemVATDocumentType
        {
            get { return _aCBankTransactionItemVATDocumentType; }
            set
            {
                if (value != this._aCBankTransactionItemVATDocumentType)
                {
                    _aCBankTransactionItemVATDocumentType = value;
                    NotifyChanged("ACBankTransactionItemVATDocumentType");
                }
            }
        }
        public String ACBankTransactionItemVATFormNo
        {
            get { return _aCBankTransactionItemVATFormNo; }
            set
            {
                if (value != this._aCBankTransactionItemVATFormNo)
                {
                    _aCBankTransactionItemVATFormNo = value;
                    NotifyChanged("ACBankTransactionItemVATFormNo");
                }
            }
        }
        public String ACBankTransactionItemVoucherNo
        {
            get { return _aCBankTransactionItemVoucherNo; }
            set
            {
                if (value != this._aCBankTransactionItemVoucherNo)
                {
                    _aCBankTransactionItemVoucherNo = value;
                    NotifyChanged("ACBankTransactionItemVoucherNo");
                }
            }
        }
        public DateTime ACBankTransactionItemInvoiceDate
        {
            get { return _aCBankTransactionItemInvoiceDate; }
            set
            {
                if (value != this._aCBankTransactionItemInvoiceDate)
                {
                    _aCBankTransactionItemInvoiceDate = value;
                    NotifyChanged("ACBankTransactionItemInvoiceDate");
                }
            }
        }
        public String ACBankTransactionItemVATInvoiceNo
        {
            get { return _aCBankTransactionItemVATInvoiceNo; }
            set
            {
                if (value != this._aCBankTransactionItemVATInvoiceNo)
                {
                    _aCBankTransactionItemVATInvoiceNo = value;
                    NotifyChanged("ACBankTransactionItemVATInvoiceNo");
                }
            }
        }
        public String ACBankTransactionItemVATSymbol
        {
            get { return _aCBankTransactionItemVATSymbol; }
            set
            {
                if (value != this._aCBankTransactionItemVATSymbol)
                {
                    _aCBankTransactionItemVATSymbol = value;
                    NotifyChanged("ACBankTransactionItemVATSymbol");
                }
            }
        }
        public String ACBankTransactionItemTaxNumber
        {
            get { return _aCBankTransactionItemTaxNumber; }
            set
            {
                if (value != this._aCBankTransactionItemTaxNumber)
                {
                    _aCBankTransactionItemTaxNumber = value;
                    NotifyChanged("ACBankTransactionItemTaxNumber");
                }
            }
        }
        public decimal ACBankTransactionItemTaxPercent
        {
            get { return _aCBankTransactionItemTaxPercent; }
            set
            {
                if (value != this._aCBankTransactionItemTaxPercent)
                {
                    _aCBankTransactionItemTaxPercent = value;
                    NotifyChanged("ACBankTransactionItemTaxPercent");
                }
            }
        }
        public decimal ACBankTransactionItemTaxAmount
        {
            get { return _aCBankTransactionItemTaxAmount; }
            set
            {
                if (value != this._aCBankTransactionItemTaxAmount)
                {
                    _aCBankTransactionItemTaxAmount = value;
                    NotifyChanged("ACBankTransactionItemTaxAmount");
                }
            }
        }
        public decimal ACBankTransactionItemTotalAmount
        {
            get { return _aCBankTransactionItemTotalAmount; }
            set
            {
                if (value != this._aCBankTransactionItemTotalAmount)
                {
                    _aCBankTransactionItemTotalAmount = value;
                    NotifyChanged("ACBankTransactionItemTotalAmount");
                }
            }
        }
        public decimal ACBankTransactionItemTotalExchangeAmount
        {
            get { return _aCBankTransactionItemTotalExchangeAmount; }
            set
            {
                if (value != this._aCBankTransactionItemTotalExchangeAmount)
                {
                    _aCBankTransactionItemTotalExchangeAmount = value;
                    NotifyChanged("ACBankTransactionItemTotalExchangeAmount");
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
        public String ACObjectName
        {
            get { return _aCObjectName; }
            set
            {
                if (value != this._aCObjectName)
                {
                    _aCObjectName = value;
                    NotifyChanged("ACObjectName");
                }
            }
        }
        public int FK_ACEInvoiceTypeID
        {
            get { return _fK_ACEInvoiceTypeID; }
            set
            {
                if (value != this._fK_ACEInvoiceTypeID)
                {
                    _fK_ACEInvoiceTypeID = value;
                    NotifyChanged("FK_ACEInvoiceTypeID");
                }
            }
        }
        public int FK_HRAdvanceRefundItemInvoiceID
        {
            get { return _fK_HRAdvanceRefundItemInvoiceID; }
            set
            {
                if (value != this._fK_HRAdvanceRefundItemInvoiceID)
                {
                    _fK_HRAdvanceRefundItemInvoiceID = value;
                    NotifyChanged("FK_HRAdvanceRefundItemInvoiceID");
                }
            }
        }
        public decimal ACBankTransactionItemFeeAmount
        {
            get { return _aCBankTransactionItemFeeAmount; }
            set
            {
                if (value != this._aCBankTransactionItemFeeAmount)
                {
                    _aCBankTransactionItemFeeAmount = value;
                    NotifyChanged("ACBankTransactionItemFeeAmount");
                }
            }
        }
        #endregion

        #region Extra Properties
        public string CreditAccountNo { get; set; }
        public string DebitAccountNo { get; set; }
        public string GECurrencyName { get; set; }
        public string ACObjectContactAddress { get; set; }
        public string ACBankTransactionAccount { get; set; }
        public string ACBankTransactionNo { get; set; }
        public string ACBankTransactionDesc { get; set; }
        public DateTime ACBankTransactionDate { get; set; }
        public string ACBankTransactionSenderName { get; set; }
        public string ACBankTransactionSenderBankName { get; set; }
        public string ACBankTransactionSenderAccount { get; set; }
        public string ACBankTransactionReceiverName { get; set; }
        public string ACBankTransactionReceiverIDNumber { get; set; }
        public DateTime ACBankTransactionReceiverIDDate { get; set; }
        public string ACBankTransactionReceiverIDPlace { get; set; }
        public string ACBankTransactionReceiverContactAddress { get; set; }
        public string ACBankTransactionReceiverBankName { get; set; }
        public string ACBankTransactionReceiverAccount { get; set; }
        public string ACBankTransactionReceiverBankCode { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal ACBankTransactionTotalAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal ACBankTransactionExchangeAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupExchangeRate)]
        public decimal ACBankTransactionExchangeRate { get; set; }

        public string CSCompanyBankName { get; set; }

        public string ACEntryTypeName { get; set; }

        public string ACCostObjectNo { get; set; }

        public string CSCompanyBankAccount { get; set; }

        public string ACBankTransactionVoucherNo { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APPaymentProposalPaymentTotalAmount { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPriceByCurrency)]
        public decimal APPaymentProposalPaymentAmount { get; set; }
        public string APSupplierName { get; set; }
        public string APInvoiceInSupplierNo { get; set; }
        public string APInvoiceInNo { get; set; }
        public DateTime ARSaleOrderPaymentTimeDueDate { get; set; }
        public string APSupplierSWIFTCode { get; set; }
        public string ACDocumentNo { get; set; }
        public string ACLoanReceiptNo { get; set; }
        public string ACObjectAccessKey { get; set; }
        public string GECurrencyNo { get; set; }
        public decimal APPaymentProposalPaymentEAmount { get; set; }
        #endregion
    }
    #endregion
}