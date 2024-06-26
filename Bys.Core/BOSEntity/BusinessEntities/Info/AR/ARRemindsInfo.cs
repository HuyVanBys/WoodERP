﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARReminds
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARRemindsInfo
    //Created Date:Thursday, April 5, 2018
    //-----------------------------------------------------------

    public class ARRemindsInfo : BusinessObject
    {
        public ARRemindsInfo()
        {
        }
        #region Variables
        protected int _aRRemindID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARCustomerID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARProposalID;
        protected String _aRRemindNo = String.Empty;
        protected String _aRRemindName = String.Empty;
        protected String _aRRemindDesc = String.Empty;
        protected DateTime _aRRemindDate = DateTime.MaxValue;
        protected String _aRRemindType = String.Empty;
        protected String _aRRemindStatus = DefaultStatus;
        protected int _fK_HREmployeeID;
        #endregion

        #region Public properties
        public int ARRemindID
        {
            get { return _aRRemindID; }
            set
            {
                if (value != this._aRRemindID)
                {
                    _aRRemindID = value;
                    NotifyChanged("ARRemindID");
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public int FK_ARSaleOrderID
        {
            get { return _fK_ARSaleOrderID; }
            set
            {
                if (value != this._fK_ARSaleOrderID)
                {
                    _fK_ARSaleOrderID = value;
                    NotifyChanged("FK_ARSaleOrderID");
                }
            }
        }
        public int FK_ARProposalID
        {
            get { return _fK_ARProposalID; }
            set
            {
                if (value != this._fK_ARProposalID)
                {
                    _fK_ARProposalID = value;
                    NotifyChanged("FK_ARProposalID");
                }
            }
        }
        public String ARRemindNo
        {
            get { return _aRRemindNo; }
            set
            {
                if (value != this._aRRemindNo)
                {
                    _aRRemindNo = value;
                    NotifyChanged("ARRemindNo");
                }
            }
        }
        public String ARRemindName
        {
            get { return _aRRemindName; }
            set
            {
                if (value != this._aRRemindName)
                {
                    _aRRemindName = value;
                    NotifyChanged("ARRemindName");
                }
            }
        }
        public String ARRemindDesc
        {
            get { return _aRRemindDesc; }
            set
            {
                if (value != this._aRRemindDesc)
                {
                    _aRRemindDesc = value;
                    NotifyChanged("ARRemindDesc");
                }
            }
        }
        public DateTime ARRemindDate
        {
            get { return _aRRemindDate; }
            set
            {
                if (value != this._aRRemindDate)
                {
                    _aRRemindDate = value;
                    NotifyChanged("ARRemindDate");
                }
            }
        }
        public String ARRemindType
        {
            get { return _aRRemindType; }
            set
            {
                if (value != this._aRRemindType)
                {
                    _aRRemindType = value;
                    NotifyChanged("ARRemindType");
                }
            }
        }
        public String ARRemindStatus
        {
            get { return _aRRemindStatus; }
            set
            {
                if (value != this._aRRemindStatus)
                {
                    _aRRemindStatus = value;
                    NotifyChanged("ARRemindStatus");
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
        #endregion
    }
    #endregion
}