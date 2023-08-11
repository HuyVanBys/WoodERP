﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeArrearSocialInsurances
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeArrearSocialInsurancesInfo
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HREmployeeArrearSocialInsurancesInfo : BusinessObject
    {
        public HREmployeeArrearSocialInsurancesInfo()
        {
        }
        #region Variables
        protected int _hREmployeeArrearSocialInsuranceID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRAdjustSocialInsuranceID;
        protected int _fK_HREmployeeID;
        protected String _hREmployeeArrearSocialInsuranceNo = String.Empty;
        protected decimal _hREmployeeArrearSocialInsuranceSalary;
        protected DateTime _hREmployeeArrearSocialInsuranceFromDate = DateTime.MaxValue;
        protected DateTime _hREmployeeArrearSocialInsuranceToDate = DateTime.MaxValue;
        protected decimal _hREmployeeArrearSocialInsuranceTotalMonth;
        protected decimal _hREmployeeArrearSocialInsuranceBHXHRate;
        protected decimal _hREmployeeArrearSocialInsuranceBHTNRate;
        protected decimal _hREmployeeArrearSocialInsuranceBHYTRate;
        protected decimal _hREmployeeArrearSocialInsuranceNi;
        protected decimal _hREmployeeArrearSocialInsuranceBHXHInterest;
        protected decimal _hREmployeeArrearSocialInsuranceBHTNInterest;
        protected decimal _hREmployeeArrearSocialInsuranceBHYTInterest;
        protected decimal _hREmployeeArrearSocialInsuranceInterestTotal;
        protected String _hREmployeeArrearSocialInsuranceDesc = String.Empty;
        #endregion

        #region Public properties
        public int HREmployeeArrearSocialInsuranceID
        {
            get { return _hREmployeeArrearSocialInsuranceID; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceID)
                {
                    _hREmployeeArrearSocialInsuranceID = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceID");
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
        public int FK_HRAdjustSocialInsuranceID
        {
            get { return _fK_HRAdjustSocialInsuranceID; }
            set
            {
                if (value != this._fK_HRAdjustSocialInsuranceID)
                {
                    _fK_HRAdjustSocialInsuranceID = value;
                    NotifyChanged("FK_HRAdjustSocialInsuranceID");
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
        public String HREmployeeArrearSocialInsuranceNo
        {
            get { return _hREmployeeArrearSocialInsuranceNo; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceNo)
                {
                    _hREmployeeArrearSocialInsuranceNo = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceNo");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceSalary
        {
            get { return _hREmployeeArrearSocialInsuranceSalary; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceSalary)
                {
                    _hREmployeeArrearSocialInsuranceSalary = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceSalary");
                }
            }
        }
        public DateTime HREmployeeArrearSocialInsuranceFromDate
        {
            get { return _hREmployeeArrearSocialInsuranceFromDate; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceFromDate)
                {
                    _hREmployeeArrearSocialInsuranceFromDate = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceFromDate");
                }
            }
        }
        public DateTime HREmployeeArrearSocialInsuranceToDate
        {
            get { return _hREmployeeArrearSocialInsuranceToDate; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceToDate)
                {
                    _hREmployeeArrearSocialInsuranceToDate = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceToDate");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceTotalMonth
        {
            get { return _hREmployeeArrearSocialInsuranceTotalMonth; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceTotalMonth)
                {
                    _hREmployeeArrearSocialInsuranceTotalMonth = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceTotalMonth");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceBHXHRate
        {
            get { return _hREmployeeArrearSocialInsuranceBHXHRate; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceBHXHRate)
                {
                    _hREmployeeArrearSocialInsuranceBHXHRate = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceBHXHRate");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceBHTNRate
        {
            get { return _hREmployeeArrearSocialInsuranceBHTNRate; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceBHTNRate)
                {
                    _hREmployeeArrearSocialInsuranceBHTNRate = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceBHTNRate");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceBHYTRate
        {
            get { return _hREmployeeArrearSocialInsuranceBHYTRate; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceBHYTRate)
                {
                    _hREmployeeArrearSocialInsuranceBHYTRate = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceBHYTRate");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceNi
        {
            get { return _hREmployeeArrearSocialInsuranceNi; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceNi)
                {
                    _hREmployeeArrearSocialInsuranceNi = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceNi");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceBHXHInterest
        {
            get { return _hREmployeeArrearSocialInsuranceBHXHInterest; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceBHXHInterest)
                {
                    _hREmployeeArrearSocialInsuranceBHXHInterest = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceBHXHInterest");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceBHTNInterest
        {
            get { return _hREmployeeArrearSocialInsuranceBHTNInterest; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceBHTNInterest)
                {
                    _hREmployeeArrearSocialInsuranceBHTNInterest = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceBHTNInterest");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceBHYTInterest
        {
            get { return _hREmployeeArrearSocialInsuranceBHYTInterest; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceBHYTInterest)
                {
                    _hREmployeeArrearSocialInsuranceBHYTInterest = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceBHYTInterest");
                }
            }
        }
        public decimal HREmployeeArrearSocialInsuranceInterestTotal
        {
            get { return _hREmployeeArrearSocialInsuranceInterestTotal; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceInterestTotal)
                {
                    _hREmployeeArrearSocialInsuranceInterestTotal = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceInterestTotal");
                }
            }
        }
        public String HREmployeeArrearSocialInsuranceDesc
        {
            get { return _hREmployeeArrearSocialInsuranceDesc; }
            set
            {
                if (value != this._hREmployeeArrearSocialInsuranceDesc)
                {
                    _hREmployeeArrearSocialInsuranceDesc = value;
                    NotifyChanged("HREmployeeArrearSocialInsuranceDesc");
                }
            }
        }
        public string HREmployeeName { get; set; }
        public string HREmployeeGender { get; set; }
        public string STT { get; set; }
        public decimal HRAdjustSocialInsuranceBHXHRate { get; set; }
        public decimal HRAdjustSocialInsuranceBHYTRate { get; set; }
        #endregion
    }
    #endregion
}