﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACEInvoicePaymentMethods
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACEInvoicePaymentMethodsInfo
    //Created Date:Monday, May 06, 2019
    //-----------------------------------------------------------

    public class ACEInvoicePaymentMethodsInfo : BusinessObject
    {
        public ACEInvoicePaymentMethodsInfo()
        {
        }
        #region Variables
        protected int _aCEInvoicePaymentMethodID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aCEInvoicePaymentMethodNo = String.Empty;
        protected String _aCEInvoicePaymentMethodName = String.Empty;
        protected String _aCEInvoiceSytemPaymentMethodName = String.Empty;
        #endregion

        #region Public properties
        public int ACEInvoicePaymentMethodID
        {
            get { return _aCEInvoicePaymentMethodID; }
            set
            {
                if (value != this._aCEInvoicePaymentMethodID)
                {
                    _aCEInvoicePaymentMethodID = value;
                    NotifyChanged("ACEInvoicePaymentMethodID");
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
        public String ACEInvoicePaymentMethodNo
        {
            get { return _aCEInvoicePaymentMethodNo; }
            set
            {
                if (value != this._aCEInvoicePaymentMethodNo)
                {
                    _aCEInvoicePaymentMethodNo = value;
                    NotifyChanged("ACEInvoicePaymentMethodNo");
                }
            }
        }
        public String ACEInvoicePaymentMethodName
        {
            get { return _aCEInvoicePaymentMethodName; }
            set
            {
                if (value != this._aCEInvoicePaymentMethodName)
                {
                    _aCEInvoicePaymentMethodName = value;
                    NotifyChanged("ACEInvoicePaymentMethodName");
                }
            }
        }
        public String ACEInvoiceSytemPaymentMethodName
        {
            get { return _aCEInvoiceSytemPaymentMethodName; }
            set
            {
                if (value != this._aCEInvoiceSytemPaymentMethodName)
                {
                    _aCEInvoiceSytemPaymentMethodName = value;
                    NotifyChanged("ACEInvoiceSytemPaymentMethodName");
                }
            }
        }
        #endregion
    }
    #endregion
}