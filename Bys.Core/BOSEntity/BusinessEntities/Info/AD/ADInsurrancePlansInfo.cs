﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ADInsurrancePlans
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADInsurrancePlansInfo
    //Created Date:Thursday, December 12, 2019
    //-----------------------------------------------------------

    public class ADInsurrancePlansInfo : BusinessObject
    {
        public ADInsurrancePlansInfo()
        {
            ADInsurrancePlanIsUnCheckBHXH = false;
        }
        #region Variables
        protected int _aDInsurrancePlanID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aDInsurrancePlanNo = String.Empty;
        protected String _aDInsurrancePlanName = String.Empty;
        protected String _aDInsurrancePlanSocialID = String.Empty;
        protected bool _aDInsurrancePlanIsUnCheckBHXH = true;

        #endregion

        #region Public properties
        public int ADInsurrancePlanID
        {
            get { return _aDInsurrancePlanID; }
            set
            {
                if (value != this._aDInsurrancePlanID)
                {
                    _aDInsurrancePlanID = value;
                    NotifyChanged("ADInsurrancePlanID");
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
        public String ADInsurrancePlanNo
        {
            get { return _aDInsurrancePlanNo; }
            set
            {
                if (value != this._aDInsurrancePlanNo)
                {
                    _aDInsurrancePlanNo = value;
                    NotifyChanged("ADInsurrancePlanNo");
                }
            }
        }
        public String ADInsurrancePlanName
        {
            get { return _aDInsurrancePlanName; }
            set
            {
                if (value != this._aDInsurrancePlanName)
                {
                    _aDInsurrancePlanName = value;
                    NotifyChanged("ADInsurrancePlanName");
                }
            }
        }
        public String ADInsurrancePlanSocialID
        {
            get { return _aDInsurrancePlanSocialID; }
            set
            {
                if (value != this._aDInsurrancePlanSocialID)
                {
                    _aDInsurrancePlanSocialID = value;
                    NotifyChanged("ADInsurrancePlanSocialID");
                }
            }
        }
        public bool ADInsurrancePlanIsUnCheckBHXH
        {
            get { return _aDInsurrancePlanIsUnCheckBHXH; }
            set
            {
                if (value != this._aDInsurrancePlanIsUnCheckBHXH)
                {
                    _aDInsurrancePlanIsUnCheckBHXH = value;
                    NotifyChanged("ADInsurrancePlanIsUnCheckBHXH");
                }
            }
        }

        #endregion
    }
    #endregion
}