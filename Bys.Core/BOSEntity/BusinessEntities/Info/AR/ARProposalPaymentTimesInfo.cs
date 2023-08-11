﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARProposalPaymentTimes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProposalPaymentTimesInfo
    //Created Date:Thursday, July 5, 2018
    //-----------------------------------------------------------

    public class ARProposalPaymentTimesInfo : BusinessObject
    {
        public ARProposalPaymentTimesInfo()
        {
        }
        #region Variables
        protected int _aRProposalPaymentTimeID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARProposalID;
        protected String _aRProposalPaymentTimeName = String.Empty;
        protected decimal _aRProposalPaymentTimeAmount;
        protected DateTime _aRProposalPaymentTimeDate = DateTime.MaxValue;
        protected String _aRPaymentMethodCombo = String.Empty;
        protected String _aRProposalPaymentTimeRemark = String.Empty;
        protected String _aRProposalPaymentTimeStatus = DefaultStatus;
        protected int _fK_GEPaymentTermID;
        protected DateTime _aRProposalPaymentTimeDueDate = DateTime.MaxValue;
        protected decimal _aRProposalPaymentTimeDepositBalance;
        protected decimal _aRProposalPaymentTimeBalanceDue;
        protected String _aRProposalPaymentTimePaymentType = String.Empty;
        protected String _aRProposalPaymentTimePaymentTimepoint = String.Empty;
        protected int _aRProposalPaymentTimePaymentTermItemDay;
        protected decimal _aRProposalPaymentTimePaymentTermItemPercentPayment;
        protected String _aRProposalPaymentTimePaymentTermItemPaymentType = String.Empty;
        protected String _aRProposalPaymentTimePaymentTermItemType = String.Empty;
        protected int _fK_ARCustomerPaymentID;
        protected decimal _aRProposalPaymentTimeDepositBalanceFromCustomerPayment;
        protected decimal _aRProposalPaymentTimeDepositBalanceFromExtraCustomerPayment;
        protected int _fK_ARExtraCustomerPaymentID;
        protected int _fK_GEPaymentTermItemID;
        #endregion

        #region Public properties
        public int ARProposalPaymentTimeID
        {
            get { return _aRProposalPaymentTimeID; }
            set
            {
                if (value != this._aRProposalPaymentTimeID)
                {
                    _aRProposalPaymentTimeID = value;
                    NotifyChanged("ARProposalPaymentTimeID");
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
        public String ARProposalPaymentTimeName
        {
            get { return _aRProposalPaymentTimeName; }
            set
            {
                if (value != this._aRProposalPaymentTimeName)
                {
                    _aRProposalPaymentTimeName = value;
                    NotifyChanged("ARProposalPaymentTimeName");
                }
            }
        }
        public decimal ARProposalPaymentTimeAmount
        {
            get { return _aRProposalPaymentTimeAmount; }
            set
            {
                if (value != this._aRProposalPaymentTimeAmount)
                {
                    _aRProposalPaymentTimeAmount = value;
                    NotifyChanged("ARProposalPaymentTimeAmount");
                }
            }
        }
        public DateTime ARProposalPaymentTimeDate
        {
            get { return _aRProposalPaymentTimeDate; }
            set
            {
                if (value != this._aRProposalPaymentTimeDate)
                {
                    _aRProposalPaymentTimeDate = value;
                    NotifyChanged("ARProposalPaymentTimeDate");
                }
            }
        }
        public String ARPaymentMethodCombo
        {
            get { return _aRPaymentMethodCombo; }
            set
            {
                if (value != this._aRPaymentMethodCombo)
                {
                    _aRPaymentMethodCombo = value;
                    NotifyChanged("ARPaymentMethodCombo");
                }
            }
        }
        public String ARProposalPaymentTimeRemark
        {
            get { return _aRProposalPaymentTimeRemark; }
            set
            {
                if (value != this._aRProposalPaymentTimeRemark)
                {
                    _aRProposalPaymentTimeRemark = value;
                    NotifyChanged("ARProposalPaymentTimeRemark");
                }
            }
        }
        public String ARProposalPaymentTimeStatus
        {
            get { return _aRProposalPaymentTimeStatus; }
            set
            {
                if (value != this._aRProposalPaymentTimeStatus)
                {
                    _aRProposalPaymentTimeStatus = value;
                    NotifyChanged("ARProposalPaymentTimeStatus");
                }
            }
        }
        public int FK_GEPaymentTermID
        {
            get { return _fK_GEPaymentTermID; }
            set
            {
                if (value != this._fK_GEPaymentTermID)
                {
                    _fK_GEPaymentTermID = value;
                    NotifyChanged("FK_GEPaymentTermID");
                }
            }
        }
        public DateTime ARProposalPaymentTimeDueDate
        {
            get { return _aRProposalPaymentTimeDueDate; }
            set
            {
                if (value != this._aRProposalPaymentTimeDueDate)
                {
                    _aRProposalPaymentTimeDueDate = value;
                    NotifyChanged("ARProposalPaymentTimeDueDate");
                }
            }
        }
        public decimal ARProposalPaymentTimeDepositBalance
        {
            get { return _aRProposalPaymentTimeDepositBalance; }
            set
            {
                if (value != this._aRProposalPaymentTimeDepositBalance)
                {
                    _aRProposalPaymentTimeDepositBalance = value;
                    NotifyChanged("ARProposalPaymentTimeDepositBalance");
                }
            }
        }
        public decimal ARProposalPaymentTimeBalanceDue
        {
            get { return _aRProposalPaymentTimeBalanceDue; }
            set
            {
                if (value != this._aRProposalPaymentTimeBalanceDue)
                {
                    _aRProposalPaymentTimeBalanceDue = value;
                    NotifyChanged("ARProposalPaymentTimeBalanceDue");
                }
            }
        }
        public String ARProposalPaymentTimePaymentType
        {
            get { return _aRProposalPaymentTimePaymentType; }
            set
            {
                if (value != this._aRProposalPaymentTimePaymentType)
                {
                    _aRProposalPaymentTimePaymentType = value;
                    NotifyChanged("ARProposalPaymentTimePaymentType");
                }
            }
        }
        public String ARProposalPaymentTimePaymentTimepoint
        {
            get { return _aRProposalPaymentTimePaymentTimepoint; }
            set
            {
                if (value != this._aRProposalPaymentTimePaymentTimepoint)
                {
                    _aRProposalPaymentTimePaymentTimepoint = value;
                    NotifyChanged("ARProposalPaymentTimePaymentTimepoint");
                }
            }
        }
        public int ARProposalPaymentTimePaymentTermItemDay
        {
            get { return _aRProposalPaymentTimePaymentTermItemDay; }
            set
            {
                if (value != this._aRProposalPaymentTimePaymentTermItemDay)
                {
                    _aRProposalPaymentTimePaymentTermItemDay = value;
                    NotifyChanged("ARProposalPaymentTimePaymentTermItemDay");
                }
            }
        }
        public decimal ARProposalPaymentTimePaymentTermItemPercentPayment
        {
            get { return _aRProposalPaymentTimePaymentTermItemPercentPayment; }
            set
            {
                if (value != this._aRProposalPaymentTimePaymentTermItemPercentPayment)
                {
                    _aRProposalPaymentTimePaymentTermItemPercentPayment = value;
                    NotifyChanged("ARProposalPaymentTimePaymentTermItemPercentPayment");
                }
            }
        }
        public String ARProposalPaymentTimePaymentTermItemPaymentType
        {
            get { return _aRProposalPaymentTimePaymentTermItemPaymentType; }
            set
            {
                if (value != this._aRProposalPaymentTimePaymentTermItemPaymentType)
                {
                    _aRProposalPaymentTimePaymentTermItemPaymentType = value;
                    NotifyChanged("ARProposalPaymentTimePaymentTermItemPaymentType");
                }
            }
        }
        public String ARProposalPaymentTimePaymentTermItemType
        {
            get { return _aRProposalPaymentTimePaymentTermItemType; }
            set
            {
                if (value != this._aRProposalPaymentTimePaymentTermItemType)
                {
                    _aRProposalPaymentTimePaymentTermItemType = value;
                    NotifyChanged("ARProposalPaymentTimePaymentTermItemType");
                }
            }
        }
        public int FK_ARCustomerPaymentID
        {
            get { return _fK_ARCustomerPaymentID; }
            set
            {
                if (value != this._fK_ARCustomerPaymentID)
                {
                    _fK_ARCustomerPaymentID = value;
                    NotifyChanged("FK_ARCustomerPaymentID");
                }
            }
        }
        public decimal ARProposalPaymentTimeDepositBalanceFromCustomerPayment
        {
            get { return _aRProposalPaymentTimeDepositBalanceFromCustomerPayment; }
            set
            {
                if (value != this._aRProposalPaymentTimeDepositBalanceFromCustomerPayment)
                {
                    _aRProposalPaymentTimeDepositBalanceFromCustomerPayment = value;
                    NotifyChanged("ARProposalPaymentTimeDepositBalanceFromCustomerPayment");
                }
            }
        }
        public decimal ARProposalPaymentTimeDepositBalanceFromExtraCustomerPayment
        {
            get { return _aRProposalPaymentTimeDepositBalanceFromExtraCustomerPayment; }
            set
            {
                if (value != this._aRProposalPaymentTimeDepositBalanceFromExtraCustomerPayment)
                {
                    _aRProposalPaymentTimeDepositBalanceFromExtraCustomerPayment = value;
                    NotifyChanged("ARProposalPaymentTimeDepositBalanceFromExtraCustomerPayment");
                }
            }
        }
        public int FK_ARExtraCustomerPaymentID
        {
            get { return _fK_ARExtraCustomerPaymentID; }
            set
            {
                if (value != this._fK_ARExtraCustomerPaymentID)
                {
                    _fK_ARExtraCustomerPaymentID = value;
                    NotifyChanged("FK_ARExtraCustomerPaymentID");
                }
            }
        }
        public int FK_GEPaymentTermItemID
        {
            get { return _fK_GEPaymentTermItemID; }
            set
            {
                if (value != this._fK_GEPaymentTermItemID)
                {
                    _fK_GEPaymentTermItemID = value;
                    NotifyChanged("FK_GEPaymentTermItemID");
                }
            }
        }
        #endregion
    }
    #endregion
}