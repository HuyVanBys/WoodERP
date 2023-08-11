﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRQuarterRewards
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRQuarterRewardsInfo
    //Created Date:Friday, July 26, 2019
    //-----------------------------------------------------------

    public class HRQuarterRewardsInfo : BusinessObject
    {
        public HRQuarterRewardsInfo()
        {
        }
        #region Variables
        protected int _hRQuarterRewardID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _hRQuarterRewardNo = String.Empty;
        protected String _hRQuarterRewardName = String.Empty;
        protected String _hRQuarterRewardDesc = String.Empty;
        protected decimal _hRQuarterRewardAmount;
        protected String _hRQuarterRewardType = String.Empty;
        protected DateTime _hRQuarterRewardDateFrom = DateTime.MaxValue;
        protected DateTime _hRQuarterRewardateTo = DateTime.MaxValue;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected DateTime _hRQuarterRewardDate = DateTime.MaxValue;
        protected DateTime _hRQuarterRewardEffectiveDate = DateTime.MaxValue;
        protected DateTime _hRQuarterRewardExpiryDate = DateTime.MaxValue;
        protected String _hRQuarterRewardStatus = DefaultStatus;
        protected int _hRQuarterRewardMonth;
        #endregion

        #region Public properties
        public int HRQuarterRewardID
        {
            get { return _hRQuarterRewardID; }
            set
            {
                if (value != this._hRQuarterRewardID)
                {
                    _hRQuarterRewardID = value;
                    NotifyChanged("HRQuarterRewardID");
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
        public String HRQuarterRewardNo
        {
            get { return _hRQuarterRewardNo; }
            set
            {
                if (value != this._hRQuarterRewardNo)
                {
                    _hRQuarterRewardNo = value;
                    NotifyChanged("HRQuarterRewardNo");
                }
            }
        }
        public String HRQuarterRewardName
        {
            get { return _hRQuarterRewardName; }
            set
            {
                if (value != this._hRQuarterRewardName)
                {
                    _hRQuarterRewardName = value;
                    NotifyChanged("HRQuarterRewardName");
                }
            }
        }
        public String HRQuarterRewardDesc
        {
            get { return _hRQuarterRewardDesc; }
            set
            {
                if (value != this._hRQuarterRewardDesc)
                {
                    _hRQuarterRewardDesc = value;
                    NotifyChanged("HRQuarterRewardDesc");
                }
            }
        }
        public decimal HRQuarterRewardAmount
        {
            get { return _hRQuarterRewardAmount; }
            set
            {
                if (value != this._hRQuarterRewardAmount)
                {
                    _hRQuarterRewardAmount = value;
                    NotifyChanged("HRQuarterRewardAmount");
                }
            }
        }
        public String HRQuarterRewardType
        {
            get { return _hRQuarterRewardType; }
            set
            {
                if (value != this._hRQuarterRewardType)
                {
                    _hRQuarterRewardType = value;
                    NotifyChanged("HRQuarterRewardType");
                }
            }
        }
        public DateTime HRQuarterRewardDateFrom
        {
            get { return _hRQuarterRewardDateFrom; }
            set
            {
                if (value != this._hRQuarterRewardDateFrom)
                {
                    _hRQuarterRewardDateFrom = value;
                    NotifyChanged("HRQuarterRewardDateFrom");
                }
            }
        }
        public DateTime HRQuarterRewardateTo
        {
            get { return _hRQuarterRewardateTo; }
            set
            {
                if (value != this._hRQuarterRewardateTo)
                {
                    _hRQuarterRewardateTo = value;
                    NotifyChanged("HRQuarterRewardateTo");
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
        public DateTime HRQuarterRewardDate
        {
            get { return _hRQuarterRewardDate; }
            set
            {
                if (value != this._hRQuarterRewardDate)
                {
                    _hRQuarterRewardDate = value;
                    NotifyChanged("HRQuarterRewardDate");
                }
            }
        }
        public DateTime HRQuarterRewardEffectiveDate
        {
            get { return _hRQuarterRewardEffectiveDate; }
            set
            {
                if (value != this._hRQuarterRewardEffectiveDate)
                {
                    _hRQuarterRewardEffectiveDate = value;
                    NotifyChanged("HRQuarterRewardEffectiveDate");
                }
            }
        }
        public DateTime HRQuarterRewardExpiryDate
        {
            get { return _hRQuarterRewardExpiryDate; }
            set
            {
                if (value != this._hRQuarterRewardExpiryDate)
                {
                    _hRQuarterRewardExpiryDate = value;
                    NotifyChanged("HRQuarterRewardExpiryDate");
                }
            }
        }
        public String HRQuarterRewardStatus
        {
            get { return _hRQuarterRewardStatus; }
            set
            {
                if (value != this._hRQuarterRewardStatus)
                {
                    _hRQuarterRewardStatus = value;
                    NotifyChanged("HRQuarterRewardStatus");
                }
            }
        }
        public int HRQuarterRewardMonth
        {
            get { return _hRQuarterRewardMonth; }
            set
            {
                if (value != this._hRQuarterRewardMonth)
                {
                    _hRQuarterRewardMonth = value;
                    NotifyChanged("HRQuarterRewardMonth");
                }
            }
        }

        #endregion
    }
    #endregion
}