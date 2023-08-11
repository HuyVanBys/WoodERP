﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRAllowanceManageConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRAllowanceManageConfigsInfo
    //Created Date:Saturday, July 21, 2018
    //-----------------------------------------------------------

    public class HRAllowanceManageConfigsInfo : BusinessObject
    {
        public HRAllowanceManageConfigsInfo()
        {
        }
        #region Variables
        protected int _hRAllowanceManageConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hRAllowanceManageConfigName = String.Empty;
        protected decimal _hRAllowanceManageConfigAmount;
        protected bool _hRAllowanceManageConfigCalculatedOnCont = true;
        protected bool _hRAllowanceManageConfigPlusHoliday = true;
        protected decimal _hRAllowanceManageConfigContdifferenceWithReality;
        protected decimal _hRAllowanceManageConfigQualityCriteria;
        protected decimal _hRAllowanceManageConfigProductivityCriteria;
        protected decimal _hRAllowanceManageConfigManageCriteria;
        protected String _hRAllowanceManageConfigNo = String.Empty;
        protected DateTime _hRAllowanceManageConfigFromDate = DateTime.MaxValue;
        protected DateTime _hRAllowanceManageConfigToDate = DateTime.MaxValue;
        protected decimal _hRAllowanceManageConfigExactlyCriteria;
        protected decimal _hRAllowanceManageConfigPercentBasicSalary;
        #endregion

        #region Public properties
        public int HRAllowanceManageConfigID
        {
            get { return _hRAllowanceManageConfigID; }
            set
            {
                if (value != this._hRAllowanceManageConfigID)
                {
                    _hRAllowanceManageConfigID = value;
                    NotifyChanged("HRAllowanceManageConfigID");
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
        public String HRAllowanceManageConfigName
        {
            get { return _hRAllowanceManageConfigName; }
            set
            {
                if (value != this._hRAllowanceManageConfigName)
                {
                    _hRAllowanceManageConfigName = value;
                    NotifyChanged("HRAllowanceManageConfigName");
                }
            }
        }
        public decimal HRAllowanceManageConfigAmount
        {
            get { return _hRAllowanceManageConfigAmount; }
            set
            {
                if (value != this._hRAllowanceManageConfigAmount)
                {
                    _hRAllowanceManageConfigAmount = value;
                    NotifyChanged("HRAllowanceManageConfigAmount");
                }
            }
        }
        public bool HRAllowanceManageConfigCalculatedOnCont
        {
            get { return _hRAllowanceManageConfigCalculatedOnCont; }
            set
            {
                if (value != this._hRAllowanceManageConfigCalculatedOnCont)
                {
                    _hRAllowanceManageConfigCalculatedOnCont = value;
                    NotifyChanged("HRAllowanceManageConfigCalculatedOnCont");
                }
            }
        }
        public bool HRAllowanceManageConfigPlusHoliday
        {
            get { return _hRAllowanceManageConfigPlusHoliday; }
            set
            {
                if (value != this._hRAllowanceManageConfigPlusHoliday)
                {
                    _hRAllowanceManageConfigPlusHoliday = value;
                    NotifyChanged("HRAllowanceManageConfigPlusHoliday");
                }
            }
        }
        public decimal HRAllowanceManageConfigContdifferenceWithReality
        {
            get { return _hRAllowanceManageConfigContdifferenceWithReality; }
            set
            {
                if (value != this._hRAllowanceManageConfigContdifferenceWithReality)
                {
                    _hRAllowanceManageConfigContdifferenceWithReality = value;
                    NotifyChanged("HRAllowanceManageConfigContdifferenceWithReality");
                }
            }
        }
        public decimal HRAllowanceManageConfigQualityCriteria
        {
            get { return _hRAllowanceManageConfigQualityCriteria; }
            set
            {
                if (value != this._hRAllowanceManageConfigQualityCriteria)
                {
                    _hRAllowanceManageConfigQualityCriteria = value;
                    NotifyChanged("HRAllowanceManageConfigQualityCriteria");
                }
            }
        }
        public decimal HRAllowanceManageConfigProductivityCriteria
        {
            get { return _hRAllowanceManageConfigProductivityCriteria; }
            set
            {
                if (value != this._hRAllowanceManageConfigProductivityCriteria)
                {
                    _hRAllowanceManageConfigProductivityCriteria = value;
                    NotifyChanged("HRAllowanceManageConfigProductivityCriteria");
                }
            }
        }
        public decimal HRAllowanceManageConfigManageCriteria
        {
            get { return _hRAllowanceManageConfigManageCriteria; }
            set
            {
                if (value != this._hRAllowanceManageConfigManageCriteria)
                {
                    _hRAllowanceManageConfigManageCriteria = value;
                    NotifyChanged("HRAllowanceManageConfigManageCriteria");
                }
            }
        }
        public String HRAllowanceManageConfigNo
        {
            get { return _hRAllowanceManageConfigNo; }
            set
            {
                if (value != this._hRAllowanceManageConfigNo)
                {
                    _hRAllowanceManageConfigNo = value;
                    NotifyChanged("HRAllowanceManageConfigNo");
                }
            }
        }
        public DateTime HRAllowanceManageConfigFromDate
        {
            get { return _hRAllowanceManageConfigFromDate; }
            set
            {
                if (value != this._hRAllowanceManageConfigFromDate)
                {
                    _hRAllowanceManageConfigFromDate = value;
                    NotifyChanged("HRAllowanceManageConfigFromDate");
                }
            }
        }
        public DateTime HRAllowanceManageConfigToDate
        {
            get { return _hRAllowanceManageConfigToDate; }
            set
            {
                if (value != this._hRAllowanceManageConfigToDate)
                {
                    _hRAllowanceManageConfigToDate = value;
                    NotifyChanged("HRAllowanceManageConfigToDate");
                }
            }
        }
        public decimal HRAllowanceManageConfigExactlyCriteria
        {
            get { return _hRAllowanceManageConfigExactlyCriteria; }
            set
            {
                if (value != this._hRAllowanceManageConfigExactlyCriteria)
                {
                    _hRAllowanceManageConfigExactlyCriteria = value;
                    NotifyChanged("HRAllowanceManageConfigExactlyCriteria");
                }
            }
        }
        public decimal HRAllowanceManageConfigPercentBasicSalary
        {
            get { return _hRAllowanceManageConfigPercentBasicSalary; }
            set
            {
                if (value != this._hRAllowanceManageConfigPercentBasicSalary)
                {
                    _hRAllowanceManageConfigPercentBasicSalary = value;
                    NotifyChanged("HRAllowanceManageConfigPercentBasicSalary");
                }
            }
        }
        #endregion

        #region Extra properties
        public decimal HREmployeeExtraSalary1 { get; set; }
        public int FK_HREmployeePayrollFormulaID { get; set; }
        #endregion
    }
    #endregion
}