﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeATMCardPayrolls
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeATMCardPayrollsInfo
    //Created Date:Friday, June 12, 2020
    //-----------------------------------------------------------

    public class HREmployeeATMCardPayrollsInfo : BusinessObject
    {
        public HREmployeeATMCardPayrollsInfo()
        {
        }
        #region Variables
        protected int _hREmployeeATMCardPayrollID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRATMCardPayrollID;
        protected int _fK_HREmployeeID;
        protected decimal _hREmployeeATMCardPayrollAmount;
        protected String _hREmployeeATMCardPayrollBankAccount = String.Empty;
        protected String _hREmployeeATMCardPayrollCompanyAccount = String.Empty;
        protected String _hREmployeeATMCardPayrollCompanyAccountHolder = String.Empty;
        protected int _fK_BRBranch1;
        protected int _fK_BRBranch2;
        protected String _hREmployeeATMCardPayrollDesc = String.Empty;
        protected String _hREmployeeATMCardPayrollBankCN1 = String.Empty;
        protected String _hREmployeeATMCardPayrollBankCN2 = String.Empty;

        #endregion

        #region Public properties
        public int HREmployeeATMCardPayrollID
        {
            get { return _hREmployeeATMCardPayrollID; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollID)
                {
                    _hREmployeeATMCardPayrollID = value;
                    NotifyChanged("HREmployeeATMCardPayrollID");
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
        public int FK_HRATMCardPayrollID
        {
            get { return _fK_HRATMCardPayrollID; }
            set
            {
                if (value != this._fK_HRATMCardPayrollID)
                {
                    _fK_HRATMCardPayrollID = value;
                    NotifyChanged("FK_HRATMCardPayrollID");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public decimal HREmployeeATMCardPayrollAmount
        {
            get { return _hREmployeeATMCardPayrollAmount; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollAmount)
                {
                    _hREmployeeATMCardPayrollAmount = value;
                    NotifyChanged("HREmployeeATMCardPayrollAmount");
                }
            }
        }
        public String HREmployeeATMCardPayrollBankAccount
        {
            get { return _hREmployeeATMCardPayrollBankAccount; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollBankAccount)
                {
                    _hREmployeeATMCardPayrollBankAccount = value;
                    NotifyChanged("HREmployeeATMCardPayrollBankAccount");
                }
            }
        }
        public String HREmployeeATMCardPayrollCompanyAccount
        {
            get { return _hREmployeeATMCardPayrollCompanyAccount; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollCompanyAccount)
                {
                    _hREmployeeATMCardPayrollCompanyAccount = value;
                    NotifyChanged("HREmployeeATMCardPayrollCompanyAccount");
                }
            }
        }
        public String HREmployeeATMCardPayrollCompanyAccountHolder
        {
            get { return _hREmployeeATMCardPayrollCompanyAccountHolder; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollCompanyAccountHolder)
                {
                    _hREmployeeATMCardPayrollCompanyAccountHolder = value;
                    NotifyChanged("HREmployeeATMCardPayrollCompanyAccountHolder");
                }
            }
        }
        public int FK_BRBranch1
        {
            get { return _fK_BRBranch1; }
            set
            {
                if (value != this._fK_BRBranch1)
                {
                    _fK_BRBranch1 = value;
                    NotifyChanged("FK_BRBranch1");
                }
            }
        }
        public int FK_BRBranch2
        {
            get { return _fK_BRBranch2; }
            set
            {
                if (value != this._fK_BRBranch2)
                {
                    _fK_BRBranch2 = value;
                    NotifyChanged("FK_BRBranch2");
                }
            }
        }
        public String HREmployeeATMCardPayrollDesc
        {
            get { return _hREmployeeATMCardPayrollDesc; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollDesc)
                {
                    _hREmployeeATMCardPayrollDesc = value;
                    NotifyChanged("HREmployeeATMCardPayrollDesc");
                }
            }
        }
        public String HREmployeeATMCardPayrollBankCN1
        {
            get { return _hREmployeeATMCardPayrollBankCN1; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollBankCN1)
                {
                    _hREmployeeATMCardPayrollBankCN1 = value;
                    NotifyChanged("HREmployeeATMCardPayrollBankCN1");
                }
            }
        }
        public String HREmployeeATMCardPayrollBankCN2
        {
            get { return _hREmployeeATMCardPayrollBankCN2; }
            set
            {
                if (value != this._hREmployeeATMCardPayrollBankCN2)
                {
                    _hREmployeeATMCardPayrollBankCN2 = value;
                    NotifyChanged("HREmployeeATMCardPayrollBankCN2");
                }
            }
        }

        #endregion

        #region Extra Properties
        public string HREmployeeName { get; set; }
        public string BRBranchNo1 { get; set; }
        public string BRBranchNo2 { get; set; }

        public decimal TongTien { get; set; }
        #endregion
    }
    #endregion
}