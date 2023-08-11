﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APPurchaseOrderPaymentTimes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPurchaseOrderPaymentTimesInfo
    //Created Date:Monday, November 09, 2015
    //-----------------------------------------------------------

    public class APPurchaseOrderPaymentTimesInfo : BusinessObject
    {
        public APPurchaseOrderPaymentTimesInfo()
        {
        }
        #region Variables
        protected int _aPPurchaseOrderPaymentTimeID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPurchaseOrderID;
        protected String _aPPurchaseOrderPaymentTimeName = String.Empty;
        protected decimal _aPPurchaseOrderPaymentTimeAmount;
        protected DateTime _aPPurchaseOrderPaymentTimeDate = DateTime.MaxValue;
        protected String _aPPaymentMethodCombo = String.Empty;
        protected String _aPPurchaseOrderPaymentTimeRemark = String.Empty;
        protected String _aPPurchaseOrderPaymentTimeStatus = DefaultStatus;
        protected int _fK_GEPaymentTermID;
        protected decimal _aRSaleOrderPaymentTimeDepositBalance;
        protected decimal _aRSaleOrderPaymentTimeBalanceDue;
        protected DateTime _aRSaleOrderPaymentTimeDueDate = DateTime.MaxValue;
        protected String _aPPurchaseOrderPaymentTimePaymentType = String.Empty;
        protected DateTime _aPPurchaseOrderPaymentTimeReceiptDate = DateTime.MaxValue;
        protected decimal _aPPurchaseOrderPaymentTimeRealTotalAmount;
        protected String _aPPurchaseOrderPaymentTimePaymentTimepoint = String.Empty;
        protected int _aPPurchaseOrderPaymentTimePaymentTermItemDay;
        protected decimal _aPPurchaseOrderPaymentTimePaymentTermItemPercentPayment;
        protected String _aPPurchaseOrderPaymentTimePaymentTermItemPaymentType = String.Empty;
        protected String _aPPurchaseOrderPaymentTimePaymentTermItemType = String.Empty;
        protected int _fK_GEPaymentTermItemID;
        protected decimal _aPPurchaseOrderPaymentTimeCanceledAmount;
        #endregion

        #region Public properties
        public int APPurchaseOrderPaymentTimeID
        {
            get { return _aPPurchaseOrderPaymentTimeID; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeID)
                {
                    _aPPurchaseOrderPaymentTimeID = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeID");
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
        public String APPurchaseOrderPaymentTimeName
        {
            get { return _aPPurchaseOrderPaymentTimeName; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeName)
                {
                    _aPPurchaseOrderPaymentTimeName = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeName");
                }
            }
        }
        public decimal APPurchaseOrderPaymentTimeAmount
        {
            get { return _aPPurchaseOrderPaymentTimeAmount; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeAmount)
                {
                    _aPPurchaseOrderPaymentTimeAmount = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeAmount");
                }
            }
        }
        public DateTime APPurchaseOrderPaymentTimeDate
        {
            get { return _aPPurchaseOrderPaymentTimeDate; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeDate)
                {
                    _aPPurchaseOrderPaymentTimeDate = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeDate");
                }
            }
        }
        public String APPaymentMethodCombo
        {
            get { return _aPPaymentMethodCombo; }
            set
            {
                if (value != this._aPPaymentMethodCombo)
                {
                    _aPPaymentMethodCombo = value;
                    NotifyChanged("APPaymentMethodCombo");
                }
            }
        }
        public String APPurchaseOrderPaymentTimeRemark
        {
            get { return _aPPurchaseOrderPaymentTimeRemark; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeRemark)
                {
                    _aPPurchaseOrderPaymentTimeRemark = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeRemark");
                }
            }
        }
        public String APPurchaseOrderPaymentTimeStatus
        {
            get { return _aPPurchaseOrderPaymentTimeStatus; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeStatus)
                {
                    _aPPurchaseOrderPaymentTimeStatus = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeStatus");
                }
            }
        }
        public int FK_GEPaymentTermID
        {
            get { return _fK_GEPaymentTermID; }
            set
            {
                if (value != this._fK_GEPaymentTermID)
                {
                    _fK_GEPaymentTermID = value;
                    NotifyChanged("FK_GEPaymentTermID");
                }
            }
        }
        public decimal ARSaleOrderPaymentTimeDepositBalance
        {
            get { return _aRSaleOrderPaymentTimeDepositBalance; }
            set
            {
                if (value != this._aRSaleOrderPaymentTimeDepositBalance)
                {
                    _aRSaleOrderPaymentTimeDepositBalance = value;
                    NotifyChanged("ARSaleOrderPaymentTimeDepositBalance");
                }
            }
        }
        public decimal ARSaleOrderPaymentTimeBalanceDue
        {
            get { return _aRSaleOrderPaymentTimeBalanceDue; }
            set
            {
                if (value != this._aRSaleOrderPaymentTimeBalanceDue)
                {
                    _aRSaleOrderPaymentTimeBalanceDue = value;
                    NotifyChanged("ARSaleOrderPaymentTimeBalanceDue");
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
        public String APPurchaseOrderPaymentTimePaymentType
        {
            get { return _aPPurchaseOrderPaymentTimePaymentType; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimePaymentType)
                {
                    _aPPurchaseOrderPaymentTimePaymentType = value;
                    NotifyChanged("APPurchaseOrderPaymentTimePaymentType");
                }
            }
        }
        public DateTime APPurchaseOrderPaymentTimeReceiptDate
        {
            get { return _aPPurchaseOrderPaymentTimeReceiptDate; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeReceiptDate)
                {
                    _aPPurchaseOrderPaymentTimeReceiptDate = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeReceiptDate");
                }
            }
        }
        public decimal APPurchaseOrderPaymentTimeRealTotalAmount
        {
            get { return _aPPurchaseOrderPaymentTimeRealTotalAmount; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeRealTotalAmount)
                {
                    _aPPurchaseOrderPaymentTimeRealTotalAmount = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeRealTotalAmount");
                }
            }
        }
        public String APPurchaseOrderPaymentTimePaymentTimepoint
        {
            get { return _aPPurchaseOrderPaymentTimePaymentTimepoint; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimePaymentTimepoint)
                {
                    _aPPurchaseOrderPaymentTimePaymentTimepoint = value;
                    NotifyChanged("APPurchaseOrderPaymentTimePaymentTimepoint");
                }
            }
        }
        public int APPurchaseOrderPaymentTimePaymentTermItemDay
        {
            get { return _aPPurchaseOrderPaymentTimePaymentTermItemDay; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimePaymentTermItemDay)
                {
                    _aPPurchaseOrderPaymentTimePaymentTermItemDay = value;
                    NotifyChanged("APPurchaseOrderPaymentTimePaymentTermItemDay");
                }
            }
        }
        public decimal APPurchaseOrderPaymentTimePaymentTermItemPercentPayment
        {
            get { return _aPPurchaseOrderPaymentTimePaymentTermItemPercentPayment; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimePaymentTermItemPercentPayment)
                {
                    _aPPurchaseOrderPaymentTimePaymentTermItemPercentPayment = value;
                    NotifyChanged("APPurchaseOrderPaymentTimePaymentTermItemPercentPayment");
                }
            }
        }
        public String APPurchaseOrderPaymentTimePaymentTermItemPaymentType
        {
            get { return _aPPurchaseOrderPaymentTimePaymentTermItemPaymentType; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimePaymentTermItemPaymentType)
                {
                    _aPPurchaseOrderPaymentTimePaymentTermItemPaymentType = value;
                    NotifyChanged("APPurchaseOrderPaymentTimePaymentTermItemPaymentType");
                }
            }
        }
        public String APPurchaseOrderPaymentTimePaymentTermItemType
        {
            get { return _aPPurchaseOrderPaymentTimePaymentTermItemType; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimePaymentTermItemType)
                {
                    _aPPurchaseOrderPaymentTimePaymentTermItemType = value;
                    NotifyChanged("APPurchaseOrderPaymentTimePaymentTermItemType");
                }
            }
        }
        public int FK_GEPaymentTermItemID
        {
            get { return _fK_GEPaymentTermItemID; }
            set
            {
                if (value != this._fK_GEPaymentTermItemID)
                {
                    _fK_GEPaymentTermItemID = value;
                    NotifyChanged("FK_GEPaymentTermItemID");
                }
            }
        }
        public decimal APPurchaseOrderPaymentTimeCanceledAmount
        {
            get { return _aPPurchaseOrderPaymentTimeCanceledAmount; }
            set
            {
                if (value != this._aPPurchaseOrderPaymentTimeCanceledAmount)
                {
                    _aPPurchaseOrderPaymentTimeCanceledAmount = value;
                    NotifyChanged("APPurchaseOrderPaymentTimeCanceledAmount");
                }
            }
        }
        #endregion

        #region Extra Properties

        public decimal TongTienTraTruocHD { get; set; }
        public decimal TongTienTraSauHD { get; set; }
        #endregion

        #region Report 182
        public int APPurchaseOrderID { get; set; }
        public string APPurchaseOrderNo { get; set; }
        public string APSupplierNo { get; set; }
        public string APSupplierName { get; set; }
        public string APInvoiceInSupplierNo { get; set; }
        public string APInvoiceInVATDate { get; set; }
        public string APInvoiceInContractNo { get; set; }
        public string APInvoiceInContractDate { get; set; }
        public decimal APPurchaseOrderTotalCost { get; set; }
        public int PaymentTimeCount { get; set; }
        public decimal SupplierPaymentAmount { get; set; }
        public DateTime SupplierPaymentDate { get; set; }
        public DateTime APInvoiceInValidateDate { get; set; }
        public string APPurchaseOrderPaymentTermRequest { get; set; }

        public decimal PurchaseTotalCost { get; set; }
        public decimal APPurchaseOrderDeposit { get; set; }

        #endregion
    }
    #endregion
}