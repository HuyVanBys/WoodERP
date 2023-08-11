﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMHistoryDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMHistoryDetailsInfo
    //Created Date:Monday, June 13, 2016
    //-----------------------------------------------------------

    public class MMHistoryDetailsInfo : BusinessObject
    {
        public MMHistoryDetailsInfo()
        {
        }
        #region Variables
        protected int _mMHistoryDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMHistoryID;
        protected String _mMHistoryDetailTableName = String.Empty;
        protected String _mMHistoryDetailColumnName = String.Empty;
        protected String _mMHistoryDetailOldValue = String.Empty;
        protected String _mMHistoryDetailNewValue = String.Empty;
        #endregion

        #region Public properties
        public int MMHistoryDetailID
        {
            get { return _mMHistoryDetailID; }
            set
            {
                if (value != this._mMHistoryDetailID)
                {
                    _mMHistoryDetailID = value;
                    NotifyChanged("MMHistoryDetailID");
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
        public int FK_MMHistoryID
        {
            get { return _fK_MMHistoryID; }
            set
            {
                if (value != this._fK_MMHistoryID)
                {
                    _fK_MMHistoryID = value;
                    NotifyChanged("FK_MMHistoryID");
                }
            }
        }
        public String MMHistoryDetailTableName
        {
            get { return _mMHistoryDetailTableName; }
            set
            {
                if (value != this._mMHistoryDetailTableName)
                {
                    _mMHistoryDetailTableName = value;
                    NotifyChanged("MMHistoryDetailTableName");
                }
            }
        }
        public String MMHistoryDetailColumnName
        {
            get { return _mMHistoryDetailColumnName; }
            set
            {
                if (value != this._mMHistoryDetailColumnName)
                {
                    _mMHistoryDetailColumnName = value;
                    NotifyChanged("MMHistoryDetailColumnName");
                }
            }
        }
        public String MMHistoryDetailOldValue
        {
            get { return _mMHistoryDetailOldValue; }
            set
            {
                if (value != this._mMHistoryDetailOldValue)
                {
                    _mMHistoryDetailOldValue = value;
                    NotifyChanged("MMHistoryDetailOldValue");
                }
            }
        }
        public String MMHistoryDetailNewValue
        {
            get { return _mMHistoryDetailNewValue; }
            set
            {
                if (value != this._mMHistoryDetailNewValue)
                {
                    _mMHistoryDetailNewValue = value;
                    NotifyChanged("MMHistoryDetailNewValue");
                }
            }
        }
        #endregion
    }
    #endregion
}