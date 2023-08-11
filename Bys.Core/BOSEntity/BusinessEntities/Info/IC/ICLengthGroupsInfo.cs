﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICLengthGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICLengthGroupsInfo
    //Created Date:21 December 2018
    //-----------------------------------------------------------

    public class ICLengthGroupsInfo : BusinessObject
    {
        public ICLengthGroupsInfo()
        {
        }
        #region Variables
        protected int _iCLengthGroupID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _iCLengthGroupName = String.Empty;
        protected decimal _iCLengthGroupMinValue;
        protected decimal _iCLengthGroupMaxValue;
        #endregion

        #region Public properties
        public int ICLengthGroupID
        {
            get { return _iCLengthGroupID; }
            set
            {
                if (value != this._iCLengthGroupID)
                {
                    _iCLengthGroupID = value;
                    NotifyChanged("ICLengthGroupID");
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
        public String ICLengthGroupName
        {
            get { return _iCLengthGroupName; }
            set
            {
                if (value != this._iCLengthGroupName)
                {
                    _iCLengthGroupName = value;
                    NotifyChanged("ICLengthGroupName");
                }
            }
        }
        public decimal ICLengthGroupMinValue
        {
            get { return _iCLengthGroupMinValue; }
            set
            {
                if (value != this._iCLengthGroupMinValue)
                {
                    _iCLengthGroupMinValue = value;
                    NotifyChanged("ICLengthGroupMinValue");
                }
            }
        }
        public decimal ICLengthGroupMaxValue
        {
            get { return _iCLengthGroupMaxValue; }
            set
            {
                if (value != this._iCLengthGroupMaxValue)
                {
                    _iCLengthGroupMaxValue = value;
                    NotifyChanged("ICLengthGroupMaxValue");
                }
            }
        }
        #endregion
    }
    #endregion
}