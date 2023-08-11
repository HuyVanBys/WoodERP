﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRAdvanceRequestItemLoanDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRAdvanceRequestItemLoanDetailsInfo
    //Created Date:Wednesday, March 13, 2019
    //-----------------------------------------------------------

    public class HRAdvanceRequestItemLoanDetailsInfo : BusinessObject
    {
        public HRAdvanceRequestItemLoanDetailsInfo()
        {
        }
        #region Variables
        protected int _hRAdvanceRequestItemLoanDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRAdvanceRequestItemID;
        protected DateTime _hRAdvanceRequestItemLoanDetailDate = DateTime.MaxValue;
        protected decimal _hRAdvanceRequestItemLoanDetailTotalAmount;
        protected String _hRAdvanceRequestItemLoanDetailStatus = DefaultStatus;
        #endregion

        #region Public properties
        public int HRAdvanceRequestItemLoanDetailID
        {
            get { return _hRAdvanceRequestItemLoanDetailID; }
            set
            {
                if (value != this._hRAdvanceRequestItemLoanDetailID)
                {
                    _hRAdvanceRequestItemLoanDetailID = value;
                    NotifyChanged("HRAdvanceRequestItemLoanDetailID");
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
        public int FK_HRAdvanceRequestItemID
        {
            get { return _fK_HRAdvanceRequestItemID; }
            set
            {
                if (value != this._fK_HRAdvanceRequestItemID)
                {
                    _fK_HRAdvanceRequestItemID = value;
                    NotifyChanged("FK_HRAdvanceRequestItemID");
                }
            }
        }
        public DateTime HRAdvanceRequestItemLoanDetailDate
        {
            get { return _hRAdvanceRequestItemLoanDetailDate; }
            set
            {
                if (value != this._hRAdvanceRequestItemLoanDetailDate)
                {
                    _hRAdvanceRequestItemLoanDetailDate = value;
                    NotifyChanged("HRAdvanceRequestItemLoanDetailDate");
                }
            }
        }
        public decimal HRAdvanceRequestItemLoanDetailTotalAmount
        {
            get { return _hRAdvanceRequestItemLoanDetailTotalAmount; }
            set
            {
                if (value != this._hRAdvanceRequestItemLoanDetailTotalAmount)
                {
                    _hRAdvanceRequestItemLoanDetailTotalAmount = value;
                    NotifyChanged("HRAdvanceRequestItemLoanDetailTotalAmount");
                }
            }
        }
        public String HRAdvanceRequestItemLoanDetailStatus
        {
            get { return _hRAdvanceRequestItemLoanDetailStatus; }
            set
            {
                if (value != this._hRAdvanceRequestItemLoanDetailStatus)
                {
                    _hRAdvanceRequestItemLoanDetailStatus = value;
                    NotifyChanged("HRAdvanceRequestItemLoanDetailStatus");
                }
            }
        }
        #endregion
    }
    #endregion
}