﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRBillingIntimates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRBillingIntimatesInfo
    //Created Date:Wednesday, November 13, 2019
    //-----------------------------------------------------------

    public class HRBillingIntimatesInfo : BusinessObject
    {
        public HRBillingIntimatesInfo()
        {
        }
        #region Variables
        protected int _hRBillingIntimateID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_HREmployeeID;
        protected String _hRBillingIntimateBankAccount1 = String.Empty;
        protected String _hRBillingIntimateBankNo = String.Empty;
        protected String _hRBillingIntimateTaxNumber = String.Empty;
        protected String _hRBillingIntimateBankName = String.Empty;
        #endregion

        #region Public properties
        public int HRBillingIntimateID
        {
            get { return _hRBillingIntimateID; }
            set
            {
                if (value != this._hRBillingIntimateID)
                {
                    _hRBillingIntimateID = value;
                    NotifyChanged("HRBillingIntimateID");
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
        public String HRBillingIntimateBankAccount1
        {
            get { return _hRBillingIntimateBankAccount1; }
            set
            {
                if (value != this._hRBillingIntimateBankAccount1)
                {
                    _hRBillingIntimateBankAccount1 = value;
                    NotifyChanged("HRBillingIntimateBankAccount1");
                }
            }
        }
        public String HRBillingIntimateBankNo
        {
            get { return _hRBillingIntimateBankNo; }
            set
            {
                if (value != this._hRBillingIntimateBankNo)
                {
                    _hRBillingIntimateBankNo = value;
                    NotifyChanged("HRBillingIntimateBankNo");
                }
            }
        }
        public String HRBillingIntimateTaxNumber
        {
            get { return _hRBillingIntimateTaxNumber; }
            set
            {
                if (value != this._hRBillingIntimateTaxNumber)
                {
                    _hRBillingIntimateTaxNumber = value;
                    NotifyChanged("HRBillingIntimateTaxNumber");
                }
            }
        }
        public String HRBillingIntimateBankName
        {
            get { return _hRBillingIntimateBankName; }
            set
            {
                if (value != this._hRBillingIntimateBankName)
                {
                    _hRBillingIntimateBankName = value;
                    NotifyChanged("HRBillingIntimateBankName");
                }
            }
        }
        #endregion
    }
    #endregion
}