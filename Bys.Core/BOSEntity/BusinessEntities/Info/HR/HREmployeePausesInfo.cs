﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeePauses
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeePausesInfo
    //Created Date:Tuesday, September 10, 2019
    //-----------------------------------------------------------

    public class HREmployeePausesInfo : BusinessObject
    {
        public HREmployeePausesInfo()
        {
        }
        #region Variables
        protected int _hREmployeePauseID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _hREmployeePauseNo = String.Empty;
        protected String _hREmployeePauseName = String.Empty;
        protected String _hREmployeePauseDesc = String.Empty;
        protected DateTime _hREmployeePauseStartDate = DefaultDate;
        protected DateTime _hREmployeePauseEndDate = DateTime.MaxValue;
        protected int _fK_HRTimeSheetParamID;
        protected int _fK_HREmployeeID;
        protected DateTime _hREmployeePauseDate = DateTime.MaxValue;
        #endregion

        #region Public properties
        public int HREmployeePauseID
        {
            get { return _hREmployeePauseID; }
            set
            {
                if (value != this._hREmployeePauseID)
                {
                    _hREmployeePauseID = value;
                    NotifyChanged("HREmployeePauseID");
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
        public String HREmployeePauseNo
        {
            get { return _hREmployeePauseNo; }
            set
            {
                if (value != this._hREmployeePauseNo)
                {
                    _hREmployeePauseNo = value;
                    NotifyChanged("HREmployeePauseNo");
                }
            }
        }
        public String HREmployeePauseName
        {
            get { return _hREmployeePauseName; }
            set
            {
                if (value != this._hREmployeePauseName)
                {
                    _hREmployeePauseName = value;
                    NotifyChanged("HREmployeePauseName");
                }
            }
        }
        public String HREmployeePauseDesc
        {
            get { return _hREmployeePauseDesc; }
            set
            {
                if (value != this._hREmployeePauseDesc)
                {
                    _hREmployeePauseDesc = value;
                    NotifyChanged("HREmployeePauseDesc");
                }
            }
        }
        public DateTime HREmployeePauseStartDate
        {
            get { return _hREmployeePauseStartDate; }
            set
            {
                if (value != this._hREmployeePauseStartDate)
                {
                    _hREmployeePauseStartDate = value;
                    NotifyChanged("HREmployeePauseStartDate");
                }
            }
        }
        public DateTime HREmployeePauseEndDate
        {
            get { return _hREmployeePauseEndDate; }
            set
            {
                if (value != this._hREmployeePauseEndDate)
                {
                    _hREmployeePauseEndDate = value;
                    NotifyChanged("HREmployeePauseEndDate");
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
        public DateTime HREmployeePauseDate
        {
            get { return _hREmployeePauseDate; }
            set
            {
                if (value != this._hREmployeePauseDate)
                {
                    _hREmployeePauseDate = value;
                    NotifyChanged("HREmployeePauseDate");
                }
            }
        }
        #endregion
    }
    #endregion
}