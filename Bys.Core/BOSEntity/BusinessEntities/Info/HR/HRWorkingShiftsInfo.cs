﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRWorkingShifts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRWorkingShiftsInfo
    //Created Date:Wednesday, May 04, 2011
    //-----------------------------------------------------------

    public class HRWorkingShiftsInfo : BusinessObject
    {
        public HRWorkingShiftsInfo()
        {
            HRWorkingShiftNight = false;
            HRWorkingShiftIsDefault = true;
        }
        #region Variables
        protected int _hRWorkingShiftID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hRWorkingShiftNo = String.Empty;
        protected String _hRWorkingShiftName = String.Empty;
        protected String _hRWorkingShiftDesc = String.Empty;
        protected DateTime _hRWorkingShiftFromTime = DateTime.MaxValue;
        protected DateTime _hRWorkingShiftToTime = DateTime.MaxValue;
        protected int _fK_HREmployeePayrollFormulaID;
        protected int _hRWorkingShiftTimeBreak;
        protected bool _hRWorkingShiftNight = true;
        protected String _hRWorkingShiftDayOffWeek = String.Empty;
        protected int _fK_HRTimeSheetParamID;
        protected decimal _hRWorkingShiftWorkingTime;
        protected bool _hRWorkingShiftIsDefault = true;
        protected int _fK_HRWorkingShiftID;
        protected DateTime _hRWorkingShiftBreakTimeBetweenShiftTo = DateTime.MaxValue;
        protected DateTime _hRWorkingShiftBreakTimeBetweenShiftFrom = DateTime.MaxValue;
        protected DateTime _hRWorkingShiftFrameTimeFrom = DateTime.MaxValue;
        protected DateTime _hRWorkingShiftFrameTimeTo = DateTime.MaxValue;
        protected int _hRWorkingShiftTimeSession1;
        protected int _hRWorkingShiftTimeSession2;
        #endregion

        #region Public properties
        public int HRWorkingShiftID
        {
            get { return _hRWorkingShiftID; }
            set
            {
                if (value != this._hRWorkingShiftID)
                {
                    _hRWorkingShiftID = value;
                    NotifyChanged("HRWorkingShiftID");
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
        public String HRWorkingShiftNo
        {
            get { return _hRWorkingShiftNo; }
            set
            {
                if (value != this._hRWorkingShiftNo)
                {
                    _hRWorkingShiftNo = value;
                    NotifyChanged("HRWorkingShiftNo");
                }
            }
        }
        public String HRWorkingShiftName
        {
            get { return _hRWorkingShiftName; }
            set
            {
                if (value != this._hRWorkingShiftName)
                {
                    _hRWorkingShiftName = value;
                    NotifyChanged("HRWorkingShiftName");
                }
            }
        }
        public String HRWorkingShiftDesc
        {
            get { return _hRWorkingShiftDesc; }
            set
            {
                if (value != this._hRWorkingShiftDesc)
                {
                    _hRWorkingShiftDesc = value;
                    NotifyChanged("HRWorkingShiftDesc");
                }
            }
        }
        public DateTime HRWorkingShiftFromTime
        {
            get { return _hRWorkingShiftFromTime; }
            set
            {
                if (value != this._hRWorkingShiftFromTime)
                {
                    _hRWorkingShiftFromTime = value;
                    NotifyChanged("HRWorkingShiftFromTime");
                }
            }
        }
        public DateTime HRWorkingShiftToTime
        {
            get { return _hRWorkingShiftToTime; }
            set
            {
                if (value != this._hRWorkingShiftToTime)
                {
                    _hRWorkingShiftToTime = value;
                    NotifyChanged("HRWorkingShiftToTime");
                }
            }
        }
        public int FK_HREmployeePayrollFormulaID
        {
            get { return _fK_HREmployeePayrollFormulaID; }
            set
            {
                if (value != this._fK_HREmployeePayrollFormulaID)
                {
                    _fK_HREmployeePayrollFormulaID = value;
                    NotifyChanged("FK_HREmployeePayrollFormulaID");
                }
            }
        }
        public int HRWorkingShiftTimeBreak
        {
            get { return _hRWorkingShiftTimeBreak; }
            set
            {
                if (value != this._hRWorkingShiftTimeBreak)
                {
                    _hRWorkingShiftTimeBreak = value;
                    NotifyChanged("HRWorkingShiftTimeBreak");
                }
            }
        }
        public bool HRWorkingShiftNight
        {
            get { return _hRWorkingShiftNight; }
            set
            {
                if (value != this._hRWorkingShiftNight)
                {
                    _hRWorkingShiftNight = value;
                    NotifyChanged("HRWorkingShiftNight");
                }
            }
        }
        public String HRWorkingShiftDayOffWeek
        {
            get { return _hRWorkingShiftDayOffWeek; }
            set
            {
                if (value != this._hRWorkingShiftDayOffWeek)
                {
                    _hRWorkingShiftDayOffWeek = value;
                    NotifyChanged("HRWorkingShiftDayOffWeek");
                }
            }
        }
        public int FK_HRTimeSheetParamID
        {
            get { return _fK_HRTimeSheetParamID; }
            set
            {
                if (value != this._fK_HRTimeSheetParamID)
                {
                    _fK_HRTimeSheetParamID = value;
                    NotifyChanged("FK_HRTimeSheetParamID");
                }
            }
        }
        public decimal HRWorkingShiftWorkingTime
        {
            get { return _hRWorkingShiftWorkingTime; }
            set
            {
                if (value != this._hRWorkingShiftWorkingTime)
                {
                    _hRWorkingShiftWorkingTime = value;
                    NotifyChanged("HRWorkingShiftWorkingTime");
                }
            }
        }
        public bool HRWorkingShiftIsDefault
        {
            get { return _hRWorkingShiftIsDefault; }
            set
            {
                if (value != this._hRWorkingShiftIsDefault)
                {
                    _hRWorkingShiftIsDefault = value;
                    NotifyChanged("HRWorkingShiftIsDefault");
                }
            }
        }
        public int FK_HRWorkingShiftID
        {
            get { return _fK_HRWorkingShiftID; }
            set
            {
                if (value != this._fK_HRWorkingShiftID)
                {
                    _fK_HRWorkingShiftID = value;
                    NotifyChanged("FK_HRWorkingShiftID");
                }
            }
        }
        public DateTime HRWorkingShiftBreakTimeBetweenShiftTo
        {
            get { return _hRWorkingShiftBreakTimeBetweenShiftTo; }
            set
            {
                if (value != this._hRWorkingShiftBreakTimeBetweenShiftTo)
                {
                    _hRWorkingShiftBreakTimeBetweenShiftTo = value;
                    NotifyChanged("HRWorkingShiftBreakTimeBetweenShiftTo");
                }
            }
        }
        public DateTime HRWorkingShiftBreakTimeBetweenShiftFrom
        {
            get { return _hRWorkingShiftBreakTimeBetweenShiftFrom; }
            set
            {
                if (value != this._hRWorkingShiftBreakTimeBetweenShiftFrom)
                {
                    _hRWorkingShiftBreakTimeBetweenShiftFrom = value;
                    NotifyChanged("HRWorkingShiftBreakTimeBetweenShiftFrom");
                }
            }
        }
        public DateTime HRWorkingShiftFrameTimeFrom
        {
            get { return _hRWorkingShiftFrameTimeFrom; }
            set
            {
                if (value != this._hRWorkingShiftFrameTimeFrom)
                {
                    _hRWorkingShiftFrameTimeFrom = value;
                    NotifyChanged("HRWorkingShiftFrameTimeFrom");
                }
            }
        }
        public DateTime HRWorkingShiftFrameTimeTo
        {
            get { return _hRWorkingShiftFrameTimeTo; }
            set
            {
                if (value != this._hRWorkingShiftFrameTimeTo)
                {
                    _hRWorkingShiftFrameTimeTo = value;
                    NotifyChanged("HRWorkingShiftFrameTimeTo");
                }
            }
        }
        public int HRWorkingShiftTimeSession1
        {
            get { return _hRWorkingShiftTimeSession1; }
            set
            {
                if (value != this._hRWorkingShiftTimeSession1)
                {
                    _hRWorkingShiftTimeSession1 = value;
                    NotifyChanged("HRWorkingShiftTimeSession1");
                }
            }
        }
        public int HRWorkingShiftTimeSession2
        {
            get { return _hRWorkingShiftTimeSession2; }
            set
            {
                if (value != this._hRWorkingShiftTimeSession2)
                {
                    _hRWorkingShiftTimeSession2 = value;
                    NotifyChanged("HRWorkingShiftTimeSession2");
                }
            }
        }
        #endregion

    }
    #endregion
}