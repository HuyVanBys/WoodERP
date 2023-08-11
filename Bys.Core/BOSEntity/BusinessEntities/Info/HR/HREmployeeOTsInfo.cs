﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeOTs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeOTsInfo
    //Created Date:Monday, April 25, 2011
    //-----------------------------------------------------------

    public class HREmployeeOTsInfo : BusinessObject
    {
        public HREmployeeOTsInfo()
        {
        }
        #region Variables
        protected int _hREmployeeOTID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HROverTimeID;
        protected int _fK_HREmployeeID;
        protected String _hREmployeeOTDesc = String.Empty;
        protected int _fK_HREmployeeID2;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_HRDepartmentRoomGroupItemID;
        protected DateTime _hREmployeeOTFromDate = DateTime.MaxValue;
        protected DateTime _hREmployeeOTToDate = DateTime.MaxValue;
        protected DateTime _hREmployeeOTDate = DateTime.MaxValue;
        protected DateTime _hREmployeeOTDateEnd = DateTime.MaxValue;
        protected decimal _hREmployeeOTFactor;
        protected bool _hREmployeeOTChecked = true;
        #endregion

        #region Public properties
        public int HREmployeeOTID
        {
            get { return _hREmployeeOTID; }
            set
            {
                if (value != this._hREmployeeOTID)
                {
                    _hREmployeeOTID = value;
                    NotifyChanged("HREmployeeOTID");
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
        public int FK_HROverTimeID
        {
            get { return _fK_HROverTimeID; }
            set
            {
                if (value != this._fK_HROverTimeID)
                {
                    _fK_HROverTimeID = value;
                    NotifyChanged("FK_HROverTimeID");
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
        public String HREmployeeOTDesc
        {
            get { return _hREmployeeOTDesc; }
            set
            {
                if (value != this._hREmployeeOTDesc)
                {
                    _hREmployeeOTDesc = value;
                    NotifyChanged("HREmployeeOTDesc");
                }
            }
        }
        public int FK_HREmployeeID2
        {
            get { return _fK_HREmployeeID2; }
            set
            {
                if (value != this._fK_HREmployeeID2)
                {
                    _fK_HREmployeeID2 = value;
                    NotifyChanged("FK_HREmployeeID2");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public int FK_HRDepartmentRoomID
        {
            get { return _fK_HRDepartmentRoomID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomID)
                {
                    _fK_HRDepartmentRoomID = value;
                    NotifyChanged("FK_HRDepartmentRoomID");
                }
            }
        }
        public int FK_HRDepartmentRoomGroupItemID
        {
            get { return _fK_HRDepartmentRoomGroupItemID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomGroupItemID)
                {
                    _fK_HRDepartmentRoomGroupItemID = value;
                    NotifyChanged("FK_HRDepartmentRoomGroupItemID");
                }
            }
        }
        public DateTime HREmployeeOTFromDate
        {
            get { return _hREmployeeOTFromDate; }
            set
            {
                if (value != this._hREmployeeOTFromDate)
                {
                    _hREmployeeOTFromDate = value;
                    NotifyChanged("HREmployeeOTFromDate");
                }
            }
        }
        public DateTime HREmployeeOTToDate
        {
            get { return _hREmployeeOTToDate; }
            set
            {
                if (value != this._hREmployeeOTToDate)
                {
                    _hREmployeeOTToDate = value;
                    NotifyChanged("HREmployeeOTToDate");
                }
            }
        }
        public DateTime HREmployeeOTDate
        {
            get { return _hREmployeeOTDate; }
            set
            {
                if (value != this._hREmployeeOTDate)
                {
                    _hREmployeeOTDate = value;
                    NotifyChanged("HREmployeeOTDate");
                }
            }
        }
        public DateTime HREmployeeOTDateEnd
        {
            get { return _hREmployeeOTDateEnd; }
            set
            {
                if (value != this._hREmployeeOTDateEnd)
                {
                    _hREmployeeOTDateEnd = value;
                    NotifyChanged("HREmployeeOTDateEnd");
                }
            }
        }
        public decimal HREmployeeOTFactor
        {
            get { return _hREmployeeOTFactor; }
            set
            {
                if (value != this._hREmployeeOTFactor)
                {
                    _hREmployeeOTFactor = value;
                    NotifyChanged("HREmployeeOTFactor");
                }
            }
        }
        public bool HREmployeeOTChecked
        {
            get { return _hREmployeeOTChecked; }
            set
            {
                if (value != this._hREmployeeOTChecked)
                {
                    _hREmployeeOTChecked = value;
                    NotifyChanged("HREmployeeOTChecked");
                }
            }
        }
        #endregion


        #region ExtraProperty
        public String HREmployeeName { get; set; }
        public String HREmployeeNo { get; set; }
        public String HRDepartmentName { get; set; }
        public String HRDepartmentRoomName { get; set; }
        public String HRDepartmentRoomGroupItemName { get; set; }
        public String HRLevelName { get; set; }
        public string CountTime { get; set; }
        public string HREmployeeCardNumber { get; set; }
        public DateTime HROverTimeDateEnd { get; set; }
        public DateTime HROverTimeDate { get; set; }
        public DateTime HROverTimeFromDate { get; set; }
        public DateTime HROverTimeToDate { get; set; }
        public DateTime HRWorkingShiftToTime { get; set; }
        public bool HROverTimeHaveMeal { get; set; }
        public bool HROverTimeDefaultOT { get; set; }
        public decimal HREmployeeOTPermissionOTDaysOff { get; set; }

        #endregion
    }
    #endregion
}