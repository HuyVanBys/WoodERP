﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACLoanReceipts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACLoanReceiptsInfo
    //Created Date:Tuesday, March 15, 2016
    //-----------------------------------------------------------

    public class ACLoanReceiptsInfo : BusinessObject
    {
        public ACLoanReceiptsInfo()
        {
        }

        #region Variables
        protected int _aCLoanReceiptID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_BRBranchID;
        protected int _fK_ACLoanAgreementID;
        protected int _fK_CSCompanyBankID;
        protected int _fK_GECurrencyID;
        protected String _aCLoanReceiptNo = String.Empty;
        protected String _aCLoanReceiptContent = String.Empty;
        protected DateTime _aCLoanReceiptDate = DateTime.MaxValue;
        protected DateTime _aCLoanReceiptDeadline = DateTime.MaxValue;
        protected decimal _aCLoanReceiptInterestRate;
        protected decimal _aCLoanReceiptOverdueInterestRate;
        protected decimal _aCLoanReceiptAmount;
        protected decimal _aCLoanReceiptPaidAmount;
        protected decimal _aCLoanReceiptRemainAmount;
        protected decimal _aCLoanReceiptExchangeRate;
        protected decimal _aCLoanReceiptExchangeAmount;
        protected int _fK_ACLoanReceiptTypeID;
        protected String _aCLoanReceiptProfitMethod = String.Empty;
        protected int _aCLoanReceiptLimit;
        protected decimal _aCLoanReceiptPaymentForMonth;
        protected int _fK_PMProjectID;
        protected decimal _aCLoanReceiptOpeningPaidAmount;
        protected decimal _aCLoanReceiptPaidExchangeAmount;
        protected string _aCLoanReceiptNoOfBank = string.Empty;
        #endregion

        #region Public properties
        public int ACLoanReceiptID
        {
            get { return _aCLoanReceiptID; }
            set
            {
                if (value != this._aCLoanReceiptID)
                {
                    _aCLoanReceiptID = value;
                    NotifyChanged("ACLoanReceiptID");
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
        public int FK_ACLoanAgreementID
        {
            get { return _fK_ACLoanAgreementID; }
            set
            {
                if (value != this._fK_ACLoanAgreementID)
                {
                    _fK_ACLoanAgreementID = value;
                    NotifyChanged("FK_ACLoanAgreementID");
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
        public String ACLoanReceiptNo
        {
            get { return _aCLoanReceiptNo; }
            set
            {
                if (value != this._aCLoanReceiptNo)
                {
                    _aCLoanReceiptNo = value;
                    NotifyChanged("ACLoanReceiptNo");
                }
            }
        }
        public String ACLoanReceiptContent
        {
            get { return _aCLoanReceiptContent; }
            set
            {
                if (value != this._aCLoanReceiptContent)
                {
                    _aCLoanReceiptContent = value;
                    NotifyChanged("ACLoanReceiptContent");
                }
            }
        }
        public DateTime ACLoanReceiptDate
        {
            get { return _aCLoanReceiptDate; }
            set
            {
                if (value != this._aCLoanReceiptDate)
                {
                    _aCLoanReceiptDate = value;
                    NotifyChanged("ACLoanReceiptDate");
                }
            }
        }
        public DateTime ACLoanReceiptDeadline
        {
            get { return _aCLoanReceiptDeadline; }
            set
            {
                if (value != this._aCLoanReceiptDeadline)
                {
                    _aCLoanReceiptDeadline = value;
                    NotifyChanged("ACLoanReceiptDeadline");
                }
            }
        }
        public decimal ACLoanReceiptInterestRate
        {
            get { return _aCLoanReceiptInterestRate; }
            set
            {
                if (value != this._aCLoanReceiptInterestRate)
                {
                    _aCLoanReceiptInterestRate = value;
                    NotifyChanged("ACLoanReceiptInterestRate");
                }
            }
        }
        public decimal ACLoanReceiptOverdueInterestRate
        {
            get { return _aCLoanReceiptOverdueInterestRate; }
            set
            {
                if (value != this._aCLoanReceiptOverdueInterestRate)
                {
                    _aCLoanReceiptOverdueInterestRate = value;
                    NotifyChanged("ACLoanReceiptOverdueInterestRate");
                }
            }
        }
        public decimal ACLoanReceiptAmount
        {
            get { return _aCLoanReceiptAmount; }
            set
            {
                if (value != this._aCLoanReceiptAmount)
                {
                    _aCLoanReceiptAmount = value;
                    NotifyChanged("ACLoanReceiptAmount");
                }
            }
        }
        public decimal ACLoanReceiptPaidAmount
        {
            get { return _aCLoanReceiptPaidAmount; }
            set
            {
                if (value != this._aCLoanReceiptPaidAmount)
                {
                    _aCLoanReceiptPaidAmount = value;
                    NotifyChanged("ACLoanReceiptPaidAmount");
                }
            }
        }
        public decimal ACLoanReceiptRemainAmount
        {
            get { return _aCLoanReceiptRemainAmount; }
            set
            {
                if (value != this._aCLoanReceiptRemainAmount)
                {
                    _aCLoanReceiptRemainAmount = value;
                    NotifyChanged("ACLoanReceiptRemainAmount");
                }
            }
        }
        public decimal ACLoanReceiptExchangeRate
        {
            get { return _aCLoanReceiptExchangeRate; }
            set
            {
                if (value != this._aCLoanReceiptExchangeRate)
                {
                    _aCLoanReceiptExchangeRate = value;
                    NotifyChanged("ACLoanReceiptExchangeRate");
                }
            }
        }
        public decimal ACLoanReceiptExchangeAmount
        {
            get { return _aCLoanReceiptExchangeAmount; }
            set
            {
                if (value != this._aCLoanReceiptExchangeAmount)
                {
                    _aCLoanReceiptExchangeAmount = value;
                    NotifyChanged("ACLoanReceiptExchangeAmount");
                }
            }
        }
        public int FK_ACLoanReceiptTypeID
        {
            get { return _fK_ACLoanReceiptTypeID; }
            set
            {
                if (value != this._fK_ACLoanReceiptTypeID)
                {
                    _fK_ACLoanReceiptTypeID = value;
                    NotifyChanged("FK_ACLoanReceiptTypeID");
                }
            }
        }
        public String ACLoanReceiptProfitMethod
        {
            get { return _aCLoanReceiptProfitMethod; }
            set
            {
                if (value != this._aCLoanReceiptProfitMethod)
                {
                    _aCLoanReceiptProfitMethod = value;
                    NotifyChanged("ACLoanReceiptProfitMethod");
                }
            }
        }
        public int ACLoanReceiptLimit
        {
            get { return _aCLoanReceiptLimit; }
            set
            {
                if (value != this._aCLoanReceiptLimit)
                {
                    _aCLoanReceiptLimit = value;
                    NotifyChanged("ACLoanReceiptLimit");
                }
            }
        }
        public decimal ACLoanReceiptPaymentForMonth
        {
            get { return _aCLoanReceiptPaymentForMonth; }
            set
            {
                if (value != this._aCLoanReceiptPaymentForMonth)
                {
                    _aCLoanReceiptPaymentForMonth = value;
                    NotifyChanged("ACLoanReceiptPaymentForMonth");
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
        public decimal ACLoanReceiptOpeningPaidAmount
        {
            get { return _aCLoanReceiptOpeningPaidAmount; }
            set
            {
                if (value != this._aCLoanReceiptOpeningPaidAmount)
                {
                    _aCLoanReceiptOpeningPaidAmount = value;
                    NotifyChanged("ACLoanReceiptOpeningPaidAmount");
                }
            }
        }
        public decimal ACLoanReceiptPaidExchangeAmount
        {
            get { return _aCLoanReceiptPaidExchangeAmount; }
            set
            {
                if (value != this._aCLoanReceiptPaidExchangeAmount)
                {
                    _aCLoanReceiptPaidExchangeAmount = value;
                    NotifyChanged("ACLoanReceiptPaidExchangeAmount");
                }
            }
        }
        public string ACLoanReceiptNoOfBank
        {
            get { return _aCLoanReceiptNoOfBank; }
            set
            {
                if (value != this._aCLoanReceiptNoOfBank)
                {
                    _aCLoanReceiptNoOfBank = value;
                    NotifyChanged("ACLoanReceiptNoOfBank");
                }
            }
        }
        #endregion

        #region Extra Properties
        public decimal ACLoanReceiptMonthRate { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal DuDauKy { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal DuCuoiKy { get; set; }
        public string AccountNo { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ACLoanReceiptAmountNT { get; set; }
        public string ACLoanAgreementNo { get; set; }
        public string GECurrencyName { get; set; }
        public string CSCompanyBankName { get; set; }
        public decimal TienDaTraDenDK { get; set; }
        public decimal TienDaTraDenDKExchange { get; set; }
        public decimal TienDaTraDenCK { get; set; }
        public decimal TienDaTraDenCKExchange { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal DuDauKyVND { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal DuCuoiKyVND { get; set; }

        public DateTime LoanReceiptFromDate { get; set; }
        public DateTime LoanReceiptToDate { get; set; }
        public int FK_ACAccountID { get; set; }     //TK vay
        public int FK_ACAccountCostID { get; set; }     //TK lãi vay
        public int FK_ACAccountCostExpiredID { get; set; }  //TK lãi phạt quá hạn
        #endregion
    }
    #endregion
}