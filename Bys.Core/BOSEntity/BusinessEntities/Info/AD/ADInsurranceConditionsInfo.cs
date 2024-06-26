﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ADInsurranceConditions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADInsurranceConditionsInfo
    //Created Date:Thursday, December 12, 2019
    //-----------------------------------------------------------

    public class ADInsurranceConditionsInfo : BusinessObject
    {
        public ADInsurranceConditionsInfo()
        {
        }
        #region Variables
        protected int _aDInsurranceConditionID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aDInsurranceConditionNo = String.Empty;
        protected String _aDInsurranceConditionName = String.Empty;
        protected String _aDInsurranceConditionSocialID = String.Empty;
        #endregion

        #region Public properties
        public int ADInsurranceConditionID
        {
            get { return _aDInsurranceConditionID; }
            set
            {
                if (value != this._aDInsurranceConditionID)
                {
                    _aDInsurranceConditionID = value;
                    NotifyChanged("ADInsurranceConditionID");
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
        public String ADInsurranceConditionNo
        {
            get { return _aDInsurranceConditionNo; }
            set
            {
                if (value != this._aDInsurranceConditionNo)
                {
                    _aDInsurranceConditionNo = value;
                    NotifyChanged("ADInsurranceConditionNo");
                }
            }
        }
        public String ADInsurranceConditionName
        {
            get { return _aDInsurranceConditionName; }
            set
            {
                if (value != this._aDInsurranceConditionName)
                {
                    _aDInsurranceConditionName = value;
                    NotifyChanged("ADInsurranceConditionName");
                }
            }
        }
        public String ADInsurranceConditionSocialID
        {
            get { return _aDInsurranceConditionSocialID; }
            set
            {
                if (value != this._aDInsurranceConditionSocialID)
                {
                    _aDInsurranceConditionSocialID = value;
                    NotifyChanged("ADInsurranceConditionSocialID");
                }
            }
        }
        #endregion
    }
    #endregion
}