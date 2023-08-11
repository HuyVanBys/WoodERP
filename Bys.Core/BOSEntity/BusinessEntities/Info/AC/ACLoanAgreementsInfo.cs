﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACLoanAgreements
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACLoanAgreementsInfo
    //Created Date:Thursday, March 10, 2016
    //-----------------------------------------------------------

    public class ACLoanAgreementsInfo : BusinessObject
    {
        public ACLoanAgreementsInfo()
        {
        }

        #region Variables
        protected int _aCLoanAgreementID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_BRBranchID;
        protected int _fK_CSCompanyBankID;
        protected String _aCLoanAgreementNo = String.Empty;
        protected String _aCLoanAgreementDesc = String.Empty;
        protected DateTime _aCLoanAgreementDate = DateTime.MaxValue;
        protected DateTime _aCLoanAgreementDeadline = DateTime.MaxValue;
        protected decimal _aCLoanAgreementAmount;
        protected decimal _aCLoanAgreementReceiptAmount;
        protected decimal _aCLoanAgreementRemainAmount;
        protected int _fK_GECurrencyID;
        protected int _fK_PMProjectID;
        protected decimal _aCLoanAgreementTotalLimit;
        protected decimal _aCLoanAgreementLCLimit;
        #endregion

        #region Public properties
        public int ACLoanAgreementID
        {
            get { return _aCLoanAgreementID; }
            set
            {
                if (value != this._aCLoanAgreementID)
                {
                    _aCLoanAgreementID = value;
                    NotifyChanged("ACLoanAgreementID");
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
        public String ACLoanAgreementNo
        {
            get { return _aCLoanAgreementNo; }
            set
            {
                if (value != this._aCLoanAgreementNo)
                {
                    _aCLoanAgreementNo = value;
                    NotifyChanged("ACLoanAgreementNo");
                }
            }
        }
        public String ACLoanAgreementDesc
        {
            get { return _aCLoanAgreementDesc; }
            set
            {
                if (value != this._aCLoanAgreementDesc)
                {
                    _aCLoanAgreementDesc = value;
                    NotifyChanged("ACLoanAgreementDesc");
                }
            }
        }
        public DateTime ACLoanAgreementDate
        {
            get { return _aCLoanAgreementDate; }
            set
            {
                if (value != this._aCLoanAgreementDate)
                {
                    _aCLoanAgreementDate = value;
                    NotifyChanged("ACLoanAgreementDate");
                }
            }
        }
        public DateTime ACLoanAgreementDeadline
        {
            get { return _aCLoanAgreementDeadline; }
            set
            {
                if (value != this._aCLoanAgreementDeadline)
                {
                    _aCLoanAgreementDeadline = value;
                    NotifyChanged("ACLoanAgreementDeadline");
                }
            }
        }
        public decimal ACLoanAgreementAmount
        {
            get { return _aCLoanAgreementAmount; }
            set
            {
                if (value != this._aCLoanAgreementAmount)
                {
                    _aCLoanAgreementAmount = value;
                    NotifyChanged("ACLoanAgreementAmount");
                }
            }
        }
        public decimal ACLoanAgreementReceiptAmount
        {
            get { return _aCLoanAgreementReceiptAmount; }
            set
            {
                if (value != this._aCLoanAgreementReceiptAmount)
                {
                    _aCLoanAgreementReceiptAmount = value;
                    NotifyChanged("ACLoanAgreementReceiptAmount");
                }
            }
        }
        public decimal ACLoanAgreementRemainAmount
        {
            get { return _aCLoanAgreementRemainAmount; }
            set
            {
                if (value != this._aCLoanAgreementRemainAmount)
                {
                    _aCLoanAgreementRemainAmount = value;
                    NotifyChanged("ACLoanAgreementRemainAmount");
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
        public decimal ACLoanAgreementTotalLimit
        {
            get { return _aCLoanAgreementTotalLimit; }
            set
            {
                if (value != this._aCLoanAgreementTotalLimit)
                {
                    _aCLoanAgreementTotalLimit = value;
                    NotifyChanged("ACLoanAgreementTotalLimit");
                }
            }
        }
        public decimal ACLoanAgreementLCLimit
        {
            get { return _aCLoanAgreementLCLimit; }
            set
            {
                if (value != this._aCLoanAgreementLCLimit)
                {
                    _aCLoanAgreementLCLimit = value;
                    NotifyChanged("ACLoanAgreementLCLimit");
                }
            }
        }

        #endregion
    }
    #endregion
}