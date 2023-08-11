﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APPaymentProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPaymentProposalItemsInfo
    //Created Date:Monday, November 09, 2015
    //-----------------------------------------------------------

    public class APPaymentProposalItemsInfo : BusinessObject
    {
        public APPaymentProposalItemsInfo()
        {
        }
        #region Variables
        protected int _aPPaymentProposalItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_APPurchaseOrderID;
        protected int _fK_ICReceiptID;
        protected int _fK_APInvoiceInID;
        protected String _aPPaymentProposalItemDesc = String.Empty;
        protected DateTime _aPPaymentProposalItemDate = DateTime.MaxValue;
        protected decimal _aPPaymentProposalItemRemainAmount;
        protected decimal _aPPaymentProposalItemPaidAmount;
        protected decimal _aPPaymentProposalItemTotalAmount;
        protected String _aPPaymentProposalItemBookNo = String.Empty;
        protected int _fK_APPaymentProposalID;
        protected int _fK_APPurchaseOrderPaymentTimeID;
        protected String _aPPaymentProposalItemType = String.Empty;
        protected String _aPPaymentProposalItemApproveStatus = DefaultStatus;
        protected String _aPPaymentProposalItemPaymentTimeName = String.Empty;
        protected decimal _aPPaymentProposalItemProposalAmount;
        protected int _fK_ACDocumentID;
        protected decimal _aPPaymentProposalItemDepositAmount;
        protected int _fK_GECurrencyID;
        protected String _aPPaymentProposalItemPurchaseOrderNo = String.Empty;
        protected String _aPPaymentProposalItemInvoiceInNo = String.Empty;
        protected DateTime _aRSaleOrderPaymentTimeDueDate = DateTime.MaxValue;
        protected int _fK_ACObjectID;
        protected String _aPObjectType = String.Empty;
        protected String _aPPaymentProposalItemRemark = String.Empty;
        protected DateTime _aRSaleOrderPaymentTimeDueEndDate = DateTime.MaxValue;
        protected decimal _aPPaymentProposalItemTaxPercent;
        protected decimal _aPPaymentProposalItemTaxAmount;
        protected decimal _aPPaymentProposalItemDiscountFix;
        #endregion

        #region Public properties
        public int APPaymentProposalItemID
        {
            get { return _aPPaymentProposalItemID; }
            set
            {
                if (value != this._aPPaymentProposalItemID)
                {
                    _aPPaymentProposalItemID = value;
                    NotifyChanged("APPaymentProposalItemID");
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
        public int FK_APPurchaseOrderID
        {
            get { return _fK_APPurchaseOrderID; }
            set
            {
                if (value != this._fK_APPurchaseOrderID)
                {
                    _fK_APPurchaseOrderID = value;
                    NotifyChanged("FK_APPurchaseOrderID");
                }
            }
        }
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                    NotifyChanged("FK_ICReceiptID");
                }
            }
        }
        public int FK_APInvoiceInID
        {
            get { return _fK_APInvoiceInID; }
            set
            {
                if (value != this._fK_APInvoiceInID)
                {
                    _fK_APInvoiceInID = value;
                    NotifyChanged("FK_APInvoiceInID");
                }
            }
        }
        public String APPaymentProposalItemDesc
        {
            get { return _aPPaymentProposalItemDesc; }
            set
            {
                if (value != this._aPPaymentProposalItemDesc)
                {
                    _aPPaymentProposalItemDesc = value;
                    NotifyChanged("APPaymentProposalItemDesc");
                }
            }
        }
        public DateTime APPaymentProposalItemDate
        {
            get { return _aPPaymentProposalItemDate; }
            set
            {
                if (value != this._aPPaymentProposalItemDate)
                {
                    _aPPaymentProposalItemDate = value;
                    NotifyChanged("APPaymentProposalItemDate");
                }
            }
        }
        public decimal APPaymentProposalItemRemainAmount
        {
            get { return _aPPaymentProposalItemRemainAmount; }
            set
            {
                if (value != this._aPPaymentProposalItemRemainAmount)
                {
                    _aPPaymentProposalItemRemainAmount = value;
                    NotifyChanged("APPaymentProposalItemRemainAmount");
                }
            }
        }
        public decimal APPaymentProposalItemPaidAmount
        {
            get { return _aPPaymentProposalItemPaidAmount; }
            set
            {
                if (value != this._aPPaymentProposalItemPaidAmount)
                {
                    _aPPaymentProposalItemPaidAmount = value;
                    NotifyChanged("APPaymentProposalItemPaidAmount");
                }
            }
        }
        public decimal APPaymentProposalItemTotalAmount
        {
            get { return _aPPaymentProposalItemTotalAmount; }
            set
            {
                if (value != this._aPPaymentProposalItemTotalAmount)
                {
                    _aPPaymentProposalItemTotalAmount = value;
                    NotifyChanged("APPaymentProposalItemTotalAmount");
                }
            }
        }
        public String APPaymentProposalItemBookNo
        {
            get { return _aPPaymentProposalItemBookNo; }
            set
            {
                if (value != this._aPPaymentProposalItemBookNo)
                {
                    _aPPaymentProposalItemBookNo = value;
                    NotifyChanged("APPaymentProposalItemBookNo");
                }
            }
        }
        public int FK_APPaymentProposalID
        {
            get { return _fK_APPaymentProposalID; }
            set
            {
                if (value != this._fK_APPaymentProposalID)
                {
                    _fK_APPaymentProposalID = value;
                    NotifyChanged("FK_APPaymentProposalID");
                }
            }
        }
        public int FK_APPurchaseOrderPaymentTimeID
        {
            get { return _fK_APPurchaseOrderPaymentTimeID; }
            set
            {
                if (value != this._fK_APPurchaseOrderPaymentTimeID)
                {
                    _fK_APPurchaseOrderPaymentTimeID = value;
                    NotifyChanged("FK_APPurchaseOrderPaymentTimeID");
                }
            }
        }
        public String APPaymentProposalItemType
        {
            get { return _aPPaymentProposalItemType; }
            set
            {
                if (value != this._aPPaymentProposalItemType)
                {
                    _aPPaymentProposalItemType = value;
                    NotifyChanged("APPaymentProposalItemType");
                }
            }
        }
        public String APPaymentProposalItemApproveStatus
        {
            get { return _aPPaymentProposalItemApproveStatus; }
            set
            {
                if (value != this._aPPaymentProposalItemApproveStatus)
                {
                    _aPPaymentProposalItemApproveStatus = value;
                    NotifyChanged("APPaymentProposalItemApproveStatus");
                }
            }
        }
        public String APPaymentProposalItemPaymentTimeName
        {
            get { return _aPPaymentProposalItemPaymentTimeName; }
            set
            {
                if (value != this._aPPaymentProposalItemPaymentTimeName)
                {
                    _aPPaymentProposalItemPaymentTimeName = value;
                    NotifyChanged("APPaymentProposalItemPaymentTimeName");
                }
            }
        }
        public decimal APPaymentProposalItemProposalAmount
        {
            get { return _aPPaymentProposalItemProposalAmount; }
            set
            {
                if (value != this._aPPaymentProposalItemProposalAmount)
                {
                    _aPPaymentProposalItemProposalAmount = value;
                    NotifyChanged("APPaymentProposalItemProposalAmount");
                }
            }
        }
        public int FK_ACDocumentID
        {
            get { return _fK_ACDocumentID; }
            set
            {
                if (value != this._fK_ACDocumentID)
                {
                    _fK_ACDocumentID = value;
                    NotifyChanged("FK_ACDocumentID");
                }
            }
        }
        public decimal APPaymentProposalItemDepositAmount
        {
            get { return _aPPaymentProposalItemDepositAmount; }
            set
            {
                if (value != this._aPPaymentProposalItemDepositAmount)
                {
                    _aPPaymentProposalItemDepositAmount = value;
                    NotifyChanged("APPaymentProposalItemDepositAmount");
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
        public String APPaymentProposalItemPurchaseOrderNo
        {
            get { return _aPPaymentProposalItemPurchaseOrderNo; }
            set
            {
                if (value != this._aPPaymentProposalItemPurchaseOrderNo)
                {
                    _aPPaymentProposalItemPurchaseOrderNo = value;
                    NotifyChanged("APPaymentProposalItemPurchaseOrderNo");
                }
            }
        }
        public String APPaymentProposalItemInvoiceInNo
        {
            get { return _aPPaymentProposalItemInvoiceInNo; }
            set
            {
                if (value != this._aPPaymentProposalItemInvoiceInNo)
                {
                    _aPPaymentProposalItemInvoiceInNo = value;
                    NotifyChanged("APPaymentProposalItemInvoiceInNo");
                }
            }
        }
        public DateTime ARSaleOrderPaymentTimeDueDate
        {
            get { return _aRSaleOrderPaymentTimeDueDate; }
            set
            {
                if (value != this._aRSaleOrderPaymentTimeDueDate)
                {
                    _aRSaleOrderPaymentTimeDueDate = value;
                    NotifyChanged("ARSaleOrderPaymentTimeDueDate");
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
        public String APObjectType
        {
            get { return _aPObjectType; }
            set
            {
                if (value != this._aPObjectType)
                {
                    _aPObjectType = value;
                    NotifyChanged("APObjectType");
                }
            }
        }
        public String APPaymentProposalItemRemark
        {
            get { return _aPPaymentProposalItemRemark; }
            set
            {
                if (value != this._aPPaymentProposalItemRemark)
                {
                    _aPPaymentProposalItemRemark = value;
                    NotifyChanged("APPaymentProposalItemRemark");
                }
            }
        }
        public DateTime ARSaleOrderPaymentTimeDueEndDate
        {
            get { return _aRSaleOrderPaymentTimeDueEndDate; }
            set
            {
                if (value != this._aRSaleOrderPaymentTimeDueEndDate)
                {
                    _aRSaleOrderPaymentTimeDueEndDate = value;
                    NotifyChanged("ARSaleOrderPaymentTimeDueEndDate");
                }
            }
        }
        public decimal APPaymentProposalItemTaxPercent
        {
            get { return _aPPaymentProposalItemTaxPercent; }
            set
            {
                if (value != this._aPPaymentProposalItemTaxPercent)
                {
                    _aPPaymentProposalItemTaxPercent = value;
                    NotifyChanged("APPaymentProposalItemTaxPercent");
                }
            }
        }
        public decimal APPaymentProposalItemTaxAmount
        {
            get { return _aPPaymentProposalItemTaxAmount; }
            set
            {
                if (value != this._aPPaymentProposalItemTaxAmount)
                {
                    _aPPaymentProposalItemTaxAmount = value;
                    NotifyChanged("APPaymentProposalItemTaxAmount");
                }
            }
        }
        public decimal APPaymentProposalItemDiscountFix
        {
            get { return _aPPaymentProposalItemDiscountFix; }
            set
            {
                if (value != this._aPPaymentProposalItemDiscountFix)
                {
                    _aPPaymentProposalItemDiscountFix = value;
                    NotifyChanged("APPaymentProposalItemDiscountFix");
                }
            }
        }
        #endregion

        #region Extra
        public string APPaymentProposalInvoiceString { get; set; }
        public string APPaymentProposalReceiptString { get; set; }
        public string APPaymentProposalPurchaseOrderString { get; set; }
        public string APPaymentProposalNo { get; set; }
        public int APSupplierID { set; get; }
        public string APInvoiceInSupplierNo { get; set; }
        public decimal APPaymentProposalItemExchangeRate { get; set; }
        public string APSupplierName { get; set; }
        public string ACObjectAccessKey { get; set; }
        public string ACObjectName { get; set; }
        public int FK_ACAssObjectID { get; set; }
        public string APAssObjectType { get; set; }
        public int FK_ACAccountID { get; set; }
        public DateTime APPaymentProposalInvoiceInDate { get; set; }
        public string APPurchaseOrderNo { get; set; }
        public DateTime APPurchaseOrderDate { get; set; }
        public string PaymentItemProposalAmountShowReport { get; set; }
        public string ICReceiptNo { get; set; }
        public int ACObjectID { get; set; }
        public string ACObjectType { get; set; }
        public decimal APPaymentProposalItemWaitingPayment { get; set; }
        public string APPaymentProposalProject { get; set; }
        public string APPaymentProposalDesc { get; set; }
        #endregion
    }
    #endregion
}