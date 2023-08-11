﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARInvoiceTransactions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARInvoiceTransactionsInfo
    //Created Date:Wednesday, May 29, 2019
    //-----------------------------------------------------------

    public class ARInvoiceTransactionsInfo : BusinessObject
    {
        public ARInvoiceTransactionsInfo()
        {
        }
        #region Variables
        protected int _aRInvoiceTransactionID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_BRBRanchID;
        protected int _aRInvoiceTransactionReferenceID;
        protected String _aRInvoiceTransactionReferenceNo = String.Empty;
        protected DateTime _aRInvoiceTransactionReferenceDate = DateTime.MaxValue;
        protected String _aRInvoiceTransactionDesc = String.Empty;
        protected String _aRInvoiceTransactionModuleName = String.Empty;
        protected String _aRInvoiceTransactionType = String.Empty;
        protected String _aRInvoiceTransactionOrigin = String.Empty;
        protected int _fK_ACObjectID;
        protected String _aRObjectType = String.Empty;
        protected int _fK_ARSaleOrderID;
        protected String _aRSaleOrderNo = String.Empty;
        protected int _fK_ARSaleOrderPaymentTimeID;
        protected int _fK_ARInvoiceID;
        protected String _aRInvoiceNo = String.Empty;
        protected String _aRInvoiceSymbol = String.Empty;
        protected DateTime _aRInvoiceDate = DateTime.MaxValue;
        protected int _fK_ACAccountID;
        protected int _fK_ACOffsetAccountID;
        protected DateTime _aRInvoiceTransactionEndDate = DateTime.MaxValue;
        protected int _fK_GECurrencyID;
        protected decimal _aRInvoiceTransactionExchangeRate;
        protected decimal _aRSaleOrderAmount;
        protected decimal _aRSaleOrderAmountExchange;
        protected decimal _aRInvoiceAmount;
        protected decimal _aRInvoiceAmountExchange;
        protected decimal _aRSaleOrderPaymentAmount;
        protected decimal _aRSaleOrderPaymentAmountExchange;
        protected decimal _aRInvoicePaymentAmount;
        protected decimal _aRInvoicePaymentAmountExchange;
        protected String _aRInvoiceTransactionMethod = String.Empty;
        protected String _aRInvoiceTransactionStatus = DefaultStatus;
        protected String _aRInvoiceTransactionPaymentType = String.Empty;
        protected String _aRInvoiceVatNo = String.Empty;
        protected int _fK_ARSaleContractID;
        protected int _aRInvoiceTransactionPaymentID;
        protected String _aRInvoiceTransactionPaymentNo = String.Empty;
        protected String _aRInvoiceTransactionPaymentModuleName = String.Empty;
        protected String _aRInvoiceTransactionSalesChannel = string.Empty;
        #endregion

        #region Public properties
        public int ARInvoiceTransactionID
        {
            get { return _aRInvoiceTransactionID; }
            set
            {
                if (value != this._aRInvoiceTransactionID)
                {
                    _aRInvoiceTransactionID = value;
                    NotifyChanged("ARInvoiceTransactionID");
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
        public int FK_BRBRanchID
        {
            get { return _fK_BRBRanchID; }
            set
            {
                if (value != this._fK_BRBRanchID)
                {
                    _fK_BRBRanchID = value;
                    NotifyChanged("FK_BRBRanchID");
                }
            }
        }
        public int ARInvoiceTransactionReferenceID
        {
            get { return _aRInvoiceTransactionReferenceID; }
            set
            {
                if (value != this._aRInvoiceTransactionReferenceID)
                {
                    _aRInvoiceTransactionReferenceID = value;
                    NotifyChanged("ARInvoiceTransactionReferenceID");
                }
            }
        }
        public String ARInvoiceTransactionReferenceNo
        {
            get { return _aRInvoiceTransactionReferenceNo; }
            set
            {
                if (value != this._aRInvoiceTransactionReferenceNo)
                {
                    _aRInvoiceTransactionReferenceNo = value;
                    NotifyChanged("ARInvoiceTransactionReferenceNo");
                }
            }
        }
        public DateTime ARInvoiceTransactionReferenceDate
        {
            get { return _aRInvoiceTransactionReferenceDate; }
            set
            {
                if (value != this._aRInvoiceTransactionReferenceDate)
                {
                    _aRInvoiceTransactionReferenceDate = value;
                    NotifyChanged("ARInvoiceTransactionReferenceDate");
                }
            }
        }
        public String ARInvoiceTransactionDesc
        {
            get { return _aRInvoiceTransactionDesc; }
            set
            {
                if (value != this._aRInvoiceTransactionDesc)
                {
                    _aRInvoiceTransactionDesc = value;
                    NotifyChanged("ARInvoiceTransactionDesc");
                }
            }
        }
        public String ARInvoiceTransactionModuleName
        {
            get { return _aRInvoiceTransactionModuleName; }
            set
            {
                if (value != this._aRInvoiceTransactionModuleName)
                {
                    _aRInvoiceTransactionModuleName = value;
                    NotifyChanged("ARInvoiceTransactionModuleName");
                }
            }
        }
        public String ARInvoiceTransactionType
        {
            get { return _aRInvoiceTransactionType; }
            set
            {
                if (value != this._aRInvoiceTransactionType)
                {
                    _aRInvoiceTransactionType = value;
                    NotifyChanged("ARInvoiceTransactionType");
                }
            }
        }
        public String ARInvoiceTransactionOrigin
        {
            get { return _aRInvoiceTransactionOrigin; }
            set
            {
                if (value != this._aRInvoiceTransactionOrigin)
                {
                    _aRInvoiceTransactionOrigin = value;
                    NotifyChanged("ARInvoiceTransactionOrigin");
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
        public String ARSaleOrderNo
        {
            get { return _aRSaleOrderNo; }
            set
            {
                if (value != this._aRSaleOrderNo)
                {
                    _aRSaleOrderNo = value;
                    NotifyChanged("ARSaleOrderNo");
                }
            }
        }
        public int FK_ARSaleOrderPaymentTimeID
        {
            get { return _fK_ARSaleOrderPaymentTimeID; }
            set
            {
                if (value != this._fK_ARSaleOrderPaymentTimeID)
                {
                    _fK_ARSaleOrderPaymentTimeID = value;
                    NotifyChanged("FK_ARSaleOrderPaymentTimeID");
                }
            }
        }
        public int FK_ARInvoiceID
        {
            get { return _fK_ARInvoiceID; }
            set
            {
                if (value != this._fK_ARInvoiceID)
                {
                    _fK_ARInvoiceID = value;
                    NotifyChanged("FK_ARInvoiceID");
                }
            }
        }
        public String ARInvoiceNo
        {
            get { return _aRInvoiceNo; }
            set
            {
                if (value != this._aRInvoiceNo)
                {
                    _aRInvoiceNo = value;
                    NotifyChanged("ARInvoiceNo");
                }
            }
        }
        public String ARInvoiceSymbol
        {
            get { return _aRInvoiceSymbol; }
            set
            {
                if (value != this._aRInvoiceSymbol)
                {
                    _aRInvoiceSymbol = value;
                    NotifyChanged("ARInvoiceSymbol");
                }
            }
        }
        public DateTime ARInvoiceDate
        {
            get { return _aRInvoiceDate; }
            set
            {
                if (value != this._aRInvoiceDate)
                {
                    _aRInvoiceDate = value;
                    NotifyChanged("ARInvoiceDate");
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
        public DateTime ARInvoiceTransactionEndDate
        {
            get { return _aRInvoiceTransactionEndDate; }
            set
            {
                if (value != this._aRInvoiceTransactionEndDate)
                {
                    _aRInvoiceTransactionEndDate = value;
                    NotifyChanged("ARInvoiceTransactionEndDate");
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
        public decimal ARInvoiceTransactionExchangeRate
        {
            get { return _aRInvoiceTransactionExchangeRate; }
            set
            {
                if (value != this._aRInvoiceTransactionExchangeRate)
                {
                    _aRInvoiceTransactionExchangeRate = value;
                    NotifyChanged("ARInvoiceTransactionExchangeRate");
                }
            }
        }
        public decimal ARSaleOrderAmount
        {
            get { return _aRSaleOrderAmount; }
            set
            {
                if (value != this._aRSaleOrderAmount)
                {
                    _aRSaleOrderAmount = value;
                    NotifyChanged("ARSaleOrderAmount");
                }
            }
        }
        public decimal ARSaleOrderAmountExchange
        {
            get { return _aRSaleOrderAmountExchange; }
            set
            {
                if (value != this._aRSaleOrderAmountExchange)
                {
                    _aRSaleOrderAmountExchange = value;
                    NotifyChanged("ARSaleOrderAmountExchange");
                }
            }
        }
        public decimal ARInvoiceAmount
        {
            get { return _aRInvoiceAmount; }
            set
            {
                if (value != this._aRInvoiceAmount)
                {
                    _aRInvoiceAmount = value;
                    NotifyChanged("ARInvoiceAmount");
                }
            }
        }
        public decimal ARInvoiceAmountExchange
        {
            get { return _aRInvoiceAmountExchange; }
            set
            {
                if (value != this._aRInvoiceAmountExchange)
                {
                    _aRInvoiceAmountExchange = value;
                    NotifyChanged("ARInvoiceAmountExchange");
                }
            }
        }
        public decimal ARSaleOrderPaymentAmount
        {
            get { return _aRSaleOrderPaymentAmount; }
            set
            {
                if (value != this._aRSaleOrderPaymentAmount)
                {
                    _aRSaleOrderPaymentAmount = value;
                    NotifyChanged("ARSaleOrderPaymentAmount");
                }
            }
        }
        public decimal ARSaleOrderPaymentAmountExchange
        {
            get { return _aRSaleOrderPaymentAmountExchange; }
            set
            {
                if (value != this._aRSaleOrderPaymentAmountExchange)
                {
                    _aRSaleOrderPaymentAmountExchange = value;
                    NotifyChanged("ARSaleOrderPaymentAmountExchange");
                }
            }
        }
        public decimal ARInvoicePaymentAmount
        {
            get { return _aRInvoicePaymentAmount; }
            set
            {
                if (value != this._aRInvoicePaymentAmount)
                {
                    _aRInvoicePaymentAmount = value;
                    NotifyChanged("ARInvoicePaymentAmount");
                }
            }
        }
        public decimal ARInvoicePaymentAmountExchange
        {
            get { return _aRInvoicePaymentAmountExchange; }
            set
            {
                if (value != this._aRInvoicePaymentAmountExchange)
                {
                    _aRInvoicePaymentAmountExchange = value;
                    NotifyChanged("ARInvoicePaymentAmountExchange");
                }
            }
        }
        public String ARInvoiceTransactionMethod
        {
            get { return _aRInvoiceTransactionMethod; }
            set
            {
                if (value != this._aRInvoiceTransactionMethod)
                {
                    _aRInvoiceTransactionMethod = value;
                    NotifyChanged("ARInvoiceTransactionMethod");
                }
            }
        }
        public String ARInvoiceTransactionStatus
        {
            get { return _aRInvoiceTransactionStatus; }
            set
            {
                if (value != this._aRInvoiceTransactionStatus)
                {
                    _aRInvoiceTransactionStatus = value;
                    NotifyChanged("ARInvoiceTransactionStatus");
                }
            }
        }
        public String ARInvoiceTransactionPaymentType
        {
            get { return _aRInvoiceTransactionPaymentType; }
            set
            {
                if (value != this._aRInvoiceTransactionPaymentType)
                {
                    _aRInvoiceTransactionPaymentType = value;
                    NotifyChanged("ARInvoiceTransactionPaymentType");
                }
            }
        }
        public String ARInvoiceVatNo
        {
            get { return _aRInvoiceVatNo; }
            set
            {
                if (value != this._aRInvoiceVatNo)
                {
                    _aRInvoiceVatNo = value;
                    NotifyChanged("ARInvoiceVatNo");
                }
            }
        }
        public int FK_ARSaleContractID
        {
            get { return _fK_ARSaleContractID; }
            set
            {
                if (value != this._fK_ARSaleContractID)
                {
                    _fK_ARSaleContractID = value;
                    NotifyChanged("FK_ARSaleContractID");
                }
            }
        }
        public int ARInvoiceTransactionPaymentID
        {
            get { return _aRInvoiceTransactionPaymentID; }
            set
            {
                if (value != this._aRInvoiceTransactionPaymentID)
                {
                    _aRInvoiceTransactionPaymentID = value;
                    NotifyChanged("ARInvoiceTransactionPaymentID");
                }
            }
        }
        public String ARInvoiceTransactionPaymentNo
        {
            get { return _aRInvoiceTransactionPaymentNo; }
            set
            {
                if (value != this._aRInvoiceTransactionPaymentNo)
                {
                    _aRInvoiceTransactionPaymentNo = value;
                    NotifyChanged("ARInvoiceTransactionPaymentNo");
                }
            }
        }
        public String ARInvoiceTransactionPaymentModuleName
        {
            get { return _aRInvoiceTransactionPaymentModuleName; }
            set
            {
                if (value != this._aRInvoiceTransactionPaymentModuleName)
                {
                    _aRInvoiceTransactionPaymentModuleName = value;
                    NotifyChanged("ARInvoiceTransactionPaymentModuleName");
                }
            }
        }
        public String ARInvoiceTransactionSalesChannel
        {
            get { return _aRInvoiceTransactionSalesChannel; }
            set
            {
                if (value != this._aRInvoiceTransactionSalesChannel)
                {
                    _aRInvoiceTransactionSalesChannel = value;
                    NotifyChanged("ARInvoiceTransactionSalesChannel");
                }
            }
        }
        #endregion

        #region Extra Properties
        public string ARObjectNo { get; set; }
        public string ARObjectName { get; set; }
        public string ACObjectAccessKey { get; set; }
        public string DocumentType { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal PaymentDueAmount { get; set; }
        public string ShipmentProposalNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        #endregion
    }
    #endregion
}