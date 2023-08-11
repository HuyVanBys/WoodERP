﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRSchedules
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRSchedulesInfo
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HRSchedulesInfo : BusinessObject
    {
        public HRSchedulesInfo()
        {
        }
        #region Variables
        protected int _hRScheduleID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hRScheduleNo = String.Empty;
        protected String _hRScheduleName = String.Empty;
        protected String _hRScheduleDesc = String.Empty;
        protected DateTime _hRScheduleDate = DateTime.MaxValue;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected DateTime _hRScheduleFromDate = DateTime.MaxValue;
        protected DateTime _hRScheduleToDate = DateTime.MaxValue;
        #endregion

        #region Public properties
        public int HRScheduleID
        {
            get { return _hRScheduleID; }
            set
            {
                if (value != this._hRScheduleID)
                {
                    _hRScheduleID = value;
                    NotifyChanged("HRScheduleID");
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
        public String HRScheduleNo
        {
            get { return _hRScheduleNo; }
            set
            {
                if (value != this._hRScheduleNo)
                {
                    _hRScheduleNo = value;
                    NotifyChanged("HRScheduleNo");
                }
            }
        }
        public String HRScheduleName
        {
            get { return _hRScheduleName; }
            set
            {
                if (value != this._hRScheduleName)
                {
                    _hRScheduleName = value;
                    NotifyChanged("HRScheduleName");
                }
            }
        }
        public String HRScheduleDesc
        {
            get { return _hRScheduleDesc; }
            set
            {
                if (value != this._hRScheduleDesc)
                {
                    _hRScheduleDesc = value;
                    NotifyChanged("HRScheduleDesc");
                }
            }
        }
        public DateTime HRScheduleDate
        {
            get { return _hRScheduleDate; }
            set
            {
                if (value != this._hRScheduleDate)
                {
                    _hRScheduleDate = value;
                    NotifyChanged("HRScheduleDate");
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
        public DateTime HRScheduleFromDate
        {
            get { return _hRScheduleFromDate; }
            set
            {
                if (value != this._hRScheduleFromDate)
                {
                    _hRScheduleFromDate = value;
                    NotifyChanged("HRScheduleFromDate");
                }
            }
        }
        public DateTime HRScheduleToDate
        {
            get { return _hRScheduleToDate; }
            set
            {
                if (value != this._hRScheduleToDate)
                {
                    _hRScheduleToDate = value;
                    NotifyChanged("HRScheduleToDate");
                }
            }
        }
        #endregion
    }
    #endregion
}