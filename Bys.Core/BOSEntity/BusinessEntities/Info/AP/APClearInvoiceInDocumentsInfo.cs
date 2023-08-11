﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APClearInvoiceInDocuments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APClearInvoiceInDocumentsInfo
    //Created Date:Monday, July 30, 2018
    //-----------------------------------------------------------

    public class APClearInvoiceInDocumentsInfo : BusinessObject
    {
        public APClearInvoiceInDocumentsInfo()
        {
        }
        #region Variables
        protected int _aPClearInvoiceInDocumentID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aPClearInvoiceInDocumentNo = String.Empty;
        protected int _fK_APClearInvoiceInID;
        protected int _fK_GECurrencyID;
        protected decimal _aPClearInvoiceInDocumentExchangeRate;
        protected decimal _aPClearInvoiceInDocumentAmount;
        protected decimal _aPClearInvoiceInDocumentExchangeAmount;
        protected decimal _aPClearInvoiceInDocumentAllocatedAmount;
        protected decimal _aPClearInvoiceInDocumentExchangeAllocatedAmount;
        protected decimal _aPClearInvoiceInDocumentRemainAmount;
        protected decimal _aPClearInvoiceInDocumentAllocationAmount;
        protected int _aPClearInvoiceInDocumentReferenceID;
        protected String _aPClearInvoiceInDocumentReferenceModuleName = String.Empty;
        #endregion

        #region Public properties
        public int APClearInvoiceInDocumentID
        {
            get { return _aPClearInvoiceInDocumentID; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentID)
                {
                    _aPClearInvoiceInDocumentID = value;
                    NotifyChanged("APClearInvoiceInDocumentID");
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
        public String APClearInvoiceInDocumentNo
        {
            get { return _aPClearInvoiceInDocumentNo; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentNo)
                {
                    _aPClearInvoiceInDocumentNo = value;
                    NotifyChanged("APClearInvoiceInDocumentNo");
                }
            }
        }
        public int FK_APClearInvoiceInID
        {
            get { return _fK_APClearInvoiceInID; }
            set
            {
                if (value != this._fK_APClearInvoiceInID)
                {
                    _fK_APClearInvoiceInID = value;
                    NotifyChanged("FK_APClearInvoiceInID");
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
        public decimal APClearInvoiceInDocumentExchangeRate
        {
            get { return _aPClearInvoiceInDocumentExchangeRate; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentExchangeRate)
                {
                    _aPClearInvoiceInDocumentExchangeRate = value;
                    NotifyChanged("APClearInvoiceInDocumentExchangeRate");
                }
            }
        }
        public decimal APClearInvoiceInDocumentAmount
        {
            get { return _aPClearInvoiceInDocumentAmount; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentAmount)
                {
                    _aPClearInvoiceInDocumentAmount = value;
                    NotifyChanged("APClearInvoiceInDocumentAmount");
                }
            }
        }
        public decimal APClearInvoiceInDocumentExchangeAmount
        {
            get { return _aPClearInvoiceInDocumentExchangeAmount; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentExchangeAmount)
                {
                    _aPClearInvoiceInDocumentExchangeAmount = value;
                    NotifyChanged("APClearInvoiceInDocumentExchangeAmount");
                }
            }
        }
        public decimal APClearInvoiceInDocumentAllocatedAmount
        {
            get { return _aPClearInvoiceInDocumentAllocatedAmount; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentAllocatedAmount)
                {
                    _aPClearInvoiceInDocumentAllocatedAmount = value;
                    NotifyChanged("APClearInvoiceInDocumentAllocatedAmount");
                }
            }
        }
        public decimal APClearInvoiceInDocumentExchangeAllocatedAmount
        {
            get { return _aPClearInvoiceInDocumentExchangeAllocatedAmount; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentExchangeAllocatedAmount)
                {
                    _aPClearInvoiceInDocumentExchangeAllocatedAmount = value;
                    NotifyChanged("APClearInvoiceInDocumentExchangeAllocatedAmount");
                }
            }
        }
        public decimal APClearInvoiceInDocumentRemainAmount
        {
            get { return _aPClearInvoiceInDocumentRemainAmount; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentRemainAmount)
                {
                    _aPClearInvoiceInDocumentRemainAmount = value;
                    NotifyChanged("APClearInvoiceInDocumentRemainAmount");
                }
            }
        }
        public decimal APClearInvoiceInDocumentAllocationAmount
        {
            get { return _aPClearInvoiceInDocumentAllocationAmount; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentAllocationAmount)
                {
                    _aPClearInvoiceInDocumentAllocationAmount = value;
                    NotifyChanged("APClearInvoiceInDocumentAllocationAmount");
                }
            }
        }
        public int APClearInvoiceInDocumentReferenceID
        {
            get { return _aPClearInvoiceInDocumentReferenceID; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentReferenceID)
                {
                    _aPClearInvoiceInDocumentReferenceID = value;
                    NotifyChanged("APClearInvoiceInDocumentReferenceID");
                }
            }
        }
        public String APClearInvoiceInDocumentReferenceModuleName
        {
            get { return _aPClearInvoiceInDocumentReferenceModuleName; }
            set
            {
                if (value != this._aPClearInvoiceInDocumentReferenceModuleName)
                {
                    _aPClearInvoiceInDocumentReferenceModuleName = value;
                    NotifyChanged("APClearInvoiceInDocumentReferenceModuleName");
                }
            }
        }
        #endregion
    }
    #endregion
}