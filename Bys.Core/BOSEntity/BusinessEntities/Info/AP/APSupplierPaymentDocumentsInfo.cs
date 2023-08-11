﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APSupplierPaymentDocuments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APSupplierPaymentDocumentsInfo
    //Created Date:07 Tháng Mười Một 2018
    //-----------------------------------------------------------

    public class APSupplierPaymentDocumentsInfo : BusinessObject
    {
        public APSupplierPaymentDocumentsInfo()
        {
        }
        #region Variables
        protected int _aPSupplierPaymentDocumentID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APSupplierPaymentID;
        protected int _fK_ACEntryTypeID;
        protected int _fK_ACDebitAccountID;
        protected int _fK_ACCreditAccountID;
        protected int _fK_ACCostObjectID;
        protected String _aPSupplierPaymentDocumentDesc = String.Empty;
        protected decimal _aPSupplierPaymentDocumentAmount;
        protected decimal _aPSupplierPaymentDocumentExchangeAmount;
        protected int _fK_ACUnfinishedConstructionCostID;
        protected int _fK_HRAdvanceRefundID;
        protected String _aCEntryTypeName = String.Empty;
        #endregion

        #region Public properties
        public int APSupplierPaymentDocumentID
        {
            get { return _aPSupplierPaymentDocumentID; }
            set
            {
                if (value != this._aPSupplierPaymentDocumentID)
                {
                    _aPSupplierPaymentDocumentID = value;
                    NotifyChanged("APSupplierPaymentDocumentID");
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
        public int FK_APSupplierPaymentID
        {
            get { return _fK_APSupplierPaymentID; }
            set
            {
                if (value != this._fK_APSupplierPaymentID)
                {
                    _fK_APSupplierPaymentID = value;
                    NotifyChanged("FK_APSupplierPaymentID");
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
        public String APSupplierPaymentDocumentDesc
        {
            get { return _aPSupplierPaymentDocumentDesc; }
            set
            {
                if (value != this._aPSupplierPaymentDocumentDesc)
                {
                    _aPSupplierPaymentDocumentDesc = value;
                    NotifyChanged("APSupplierPaymentDocumentDesc");
                }
            }
        }
        public decimal APSupplierPaymentDocumentAmount
        {
            get { return _aPSupplierPaymentDocumentAmount; }
            set
            {
                if (value != this._aPSupplierPaymentDocumentAmount)
                {
                    _aPSupplierPaymentDocumentAmount = value;
                    NotifyChanged("APSupplierPaymentDocumentAmount");
                }
            }
        }
        public decimal APSupplierPaymentDocumentExchangeAmount
        {
            get { return _aPSupplierPaymentDocumentExchangeAmount; }
            set
            {
                if (value != this._aPSupplierPaymentDocumentExchangeAmount)
                {
                    _aPSupplierPaymentDocumentExchangeAmount = value;
                    NotifyChanged("APSupplierPaymentDocumentExchangeAmount");
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
        public String ACEntryTypeName
        {
            get { return _aCEntryTypeName; }
            set
            {
                if (value != this._aCEntryTypeName)
                {
                    _aCEntryTypeName = value;
                    NotifyChanged("ACEntryTypeName");
                }
            }
        }
        #endregion
    }
    #endregion
}