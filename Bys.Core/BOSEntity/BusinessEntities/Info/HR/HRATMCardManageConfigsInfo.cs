﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRATMCardManageConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRATMCardManageConfigsInfo
    //Created Date:Friday, March 13, 2020
    //-----------------------------------------------------------

    public class HRATMCardManageConfigsInfo : BusinessObject
    {
        public HRATMCardManageConfigsInfo()
        {
        }
        #region Variables
        protected int _hRATMCardManageConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hREmployeeATMCardManageStatus = DefaultStatus;
        protected decimal _hRATMCardManageConfigAmount;
        #endregion

        #region Public properties
        public int HRATMCardManageConfigID
        {
            get { return _hRATMCardManageConfigID; }
            set
            {
                if (value != this._hRATMCardManageConfigID)
                {
                    _hRATMCardManageConfigID = value;
                    NotifyChanged("HRATMCardManageConfigID");
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
        public String HREmployeeATMCardManageStatus
        {
            get { return _hREmployeeATMCardManageStatus; }
            set
            {
                if (value != this._hREmployeeATMCardManageStatus)
                {
                    _hREmployeeATMCardManageStatus = value;
                    NotifyChanged("HREmployeeATMCardManageStatus");
                }
            }
        }
        public decimal HRATMCardManageConfigAmount
        {
            get { return _hRATMCardManageConfigAmount; }
            set
            {
                if (value != this._hRATMCardManageConfigAmount)
                {
                    _hRATMCardManageConfigAmount = value;
                    NotifyChanged("HRATMCardManageConfigAmount");
                }
            }
        }
        #endregion
    }
    #endregion
}