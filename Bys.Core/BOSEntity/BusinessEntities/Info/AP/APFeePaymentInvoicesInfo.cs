﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APFeePaymentInvoices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APFeePaymentInvoicesInfo
    //Created Date:Sunday, August 19, 2018
    //-----------------------------------------------------------

    public class APFeePaymentInvoicesInfo : BusinessObject
    {
        public APFeePaymentInvoicesInfo()
        {
        }
        #region Variables
        protected int _aPFeePaymentInvoiceID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACDocumentID;
        protected int _fK_ARInvoiceID;
        #endregion

        #region Public properties
        public int APFeePaymentInvoiceID
        {
            get { return _aPFeePaymentInvoiceID; }
            set
            {
                if (value != this._aPFeePaymentInvoiceID)
                {
                    _aPFeePaymentInvoiceID = value;
                    NotifyChanged("APFeePaymentInvoiceID");
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
        #endregion

        #region extra properties
        public string ARInvoiceNo { get; set; }
        public DateTime ARInvoiceDate { get; set; }
        public string ARInvoiceVATInvoiceNo { get; set; }
        public string ARInvoiceVATFormNo { get; set; }
        public string ARInvoiceVATSymbol { get; set; }
        public string ARObjectName { get; set; }
        public decimal ARInvoiceTotalAmount { get; set; }
        public string ARSaleOrderNo { get; set; }
        #endregion
    }
    #endregion
}