﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeLRegs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeLRegsInfo
    //Created Date:Thursday, May 23, 2019
    //-----------------------------------------------------------

    public class HREmployeeLRegsInfo : BusinessObject
    {
        public HREmployeeLRegsInfo()
        {
        }
        #region Variables
        protected int _hREmployeeLRegID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_HREmployeeID;
        protected decimal _hREmployeeLRegDftDays;
        protected decimal _hREmployeeLRegPreviousDays;
        protected decimal _hREmployeeLRegExpDays;
        protected decimal _hREmployeeLRegTotDays;
        protected decimal _hREmployeeLRegLeaveDays;
        protected decimal _hREmployeeLRegRemainDays;
        protected String _hREmployeeLRegDesc = String.Empty;
        protected decimal _hREmployeeLRegAnnualLeaveTot;
        protected decimal _hREmployeeLRegNoxiouDays;
        protected decimal _hREmployeeLRegAnnualLeaveOtherDays;
        protected int _hREmployeeLRegYear;
        protected DateTime _hREmployeeLRegDateCal = DateTime.MaxValue;
        protected decimal _hREmployeeLRegPreviousDayUsed;
        #endregion

        #region Public properties
        public int HREmployeeLRegID
        {
            get { return _hREmployeeLRegID; }
            set
            {
                if (value != this._hREmployeeLRegID)
                {
                    _hREmployeeLRegID = value;
                    NotifyChanged("HREmployeeLRegID");
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
        public decimal HREmployeeLRegDftDays
        {
            get { return _hREmployeeLRegDftDays; }
            set
            {
                if (value != this._hREmployeeLRegDftDays)
                {
                    _hREmployeeLRegDftDays = value;
                    NotifyChanged("HREmployeeLRegDftDays");
                }
            }
        }
        public decimal HREmployeeLRegPreviousDays
        {
            get { return _hREmployeeLRegPreviousDays; }
            set
            {
                if (value != this._hREmployeeLRegPreviousDays)
                {
                    _hREmployeeLRegPreviousDays = value;
                    NotifyChanged("HREmployeeLRegPreviousDays");
                }
            }
        }
        public decimal HREmployeeLRegExpDays
        {
            get { return _hREmployeeLRegExpDays; }
            set
            {
                if (value != this._hREmployeeLRegExpDays)
                {
                    _hREmployeeLRegExpDays = value;
                    NotifyChanged("HREmployeeLRegExpDays");
                }
            }
        }
        public decimal HREmployeeLRegTotDays
        {
            get { return _hREmployeeLRegTotDays; }
            set
            {
                if (value != this._hREmployeeLRegTotDays)
                {
                    _hREmployeeLRegTotDays = value;
                    NotifyChanged("HREmployeeLRegTotDays");
                }
            }
        }
        public decimal HREmployeeLRegLeaveDays
        {
            get { return _hREmployeeLRegLeaveDays; }
            set
            {
                if (value != this._hREmployeeLRegLeaveDays)
                {
                    _hREmployeeLRegLeaveDays = value;
                    NotifyChanged("HREmployeeLRegLeaveDays");
                }
            }
        }
        public decimal HREmployeeLRegRemainDays
        {
            get { return _hREmployeeLRegRemainDays; }
            set
            {
                if (value != this._hREmployeeLRegRemainDays)
                {
                    _hREmployeeLRegRemainDays = value;
                    NotifyChanged("HREmployeeLRegRemainDays");
                }
            }
        }
        public String HREmployeeLRegDesc
        {
            get { return _hREmployeeLRegDesc; }
            set
            {
                if (value != this._hREmployeeLRegDesc)
                {
                    _hREmployeeLRegDesc = value;
                    NotifyChanged("HREmployeeLRegDesc");
                }
            }
        }
        public decimal HREmployeeLRegAnnualLeaveTot
        {
            get { return _hREmployeeLRegAnnualLeaveTot; }
            set
            {
                if (value != this._hREmployeeLRegAnnualLeaveTot)
                {
                    _hREmployeeLRegAnnualLeaveTot = value;
                    NotifyChanged("HREmployeeLRegAnnualLeaveTot");
                }
            }
        }
        public decimal HREmployeeLRegNoxiouDays
        {
            get { return _hREmployeeLRegNoxiouDays; }
            set
            {
                if (value != this._hREmployeeLRegNoxiouDays)
                {
                    _hREmployeeLRegNoxiouDays = value;
                    NotifyChanged("HREmployeeLRegNoxiouDays");
                }
            }
        }
        public decimal HREmployeeLRegAnnualLeaveOtherDays
        {
            get { return _hREmployeeLRegAnnualLeaveOtherDays; }
            set
            {
                if (value != this._hREmployeeLRegAnnualLeaveOtherDays)
                {
                    _hREmployeeLRegAnnualLeaveOtherDays = value;
                    NotifyChanged("HREmployeeLRegAnnualLeaveOtherDays");
                }
            }
        }
        public int HREmployeeLRegYear
        {
            get { return _hREmployeeLRegYear; }
            set
            {
                if (value != this._hREmployeeLRegYear)
                {
                    _hREmployeeLRegYear = value;
                    NotifyChanged("HREmployeeLRegYear");
                }
            }
        }
        public DateTime HREmployeeLRegDateCal
        {
            get { return _hREmployeeLRegDateCal; }
            set
            {
                if (value != this._hREmployeeLRegDateCal)
                {
                    _hREmployeeLRegDateCal = value;
                    NotifyChanged("HREmployeeLRegDateCal");
                }
            }
        }
        public decimal HREmployeeLRegPreviousDayUsed
        {
            get { return _hREmployeeLRegPreviousDayUsed; }
            set
            {
                if (value != this._hREmployeeLRegPreviousDayUsed)
                {
                    _hREmployeeLRegPreviousDayUsed = value;
                    NotifyChanged("HREmployeeLRegPreviousDayUsed");
                }
            }
        }
        #endregion

        public String HREmployeeName { get; set; }
        public DateTime HREmployeeStartWorkingDate { get; set; }

    }
    #endregion
}