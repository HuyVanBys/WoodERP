﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRErrorTypes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRErrorTypesInfo
    //Created Date:Monday, October 01, 2018
    //-----------------------------------------------------------

    public class HRErrorTypesInfo : BusinessObject
    {
        public HRErrorTypesInfo()
        {
        }
        #region Variables
        protected int _hRErrorTypeID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _hRErrorTypeNo = String.Empty;
        protected String _hRErrorTypeName = String.Empty;
        protected String _hRBugManagementHandleType = String.Empty;
        #endregion

        #region Public properties
        public int HRErrorTypeID
        {
            get { return _hRErrorTypeID; }
            set
            {
                if (value != this._hRErrorTypeID)
                {
                    _hRErrorTypeID = value;
                    NotifyChanged("HRErrorTypeID");
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
        public String HRErrorTypeNo
        {
            get { return _hRErrorTypeNo; }
            set
            {
                if (value != this._hRErrorTypeNo)
                {
                    _hRErrorTypeNo = value;
                    NotifyChanged("HRErrorTypeNo");
                }
            }
        }
        public String HRErrorTypeName
        {
            get { return _hRErrorTypeName; }
            set
            {
                if (value != this._hRErrorTypeName)
                {
                    _hRErrorTypeName = value;
                    NotifyChanged("HRErrorTypeName");
                }
            }
        }
        public String HRBugManagementHandleType
        {
            get { return _hRBugManagementHandleType; }
            set
            {
                if (value != this._hRBugManagementHandleType)
                {
                    _hRBugManagementHandleType = value;
                    NotifyChanged("HRBugManagementHandleType");
                }
            }
        }
        #endregion
    }
    #endregion
}