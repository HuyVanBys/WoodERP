﻿using BOSLib;
using System;
namespace BOSERP
{
    #region VMHistoryDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:VMHistoryDetailsInfo
    //Created Date:Friday, April 01, 2016
    //-----------------------------------------------------------

    public class VMHistoryDetailsInfo : BusinessObject
    {
        public VMHistoryDetailsInfo()
        {
        }
        #region Variables
        protected int _vMHistoryDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_VMHistoryID;
        protected String _vMHistoryDetailTableName = String.Empty;
        protected String _vMHistoryDetailColumnName = String.Empty;
        protected String _vMHistoryDetailOldValue = String.Empty;
        protected String _vMHistoryDetailNewValue = String.Empty;
        #endregion

        #region Public properties
        public int VMHistoryDetailID
        {
            get { return _vMHistoryDetailID; }
            set
            {
                if (value != this._vMHistoryDetailID)
                {
                    _vMHistoryDetailID = value;
                    NotifyChanged("VMHistoryDetailID");
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
        public int FK_VMHistoryID
        {
            get { return _fK_VMHistoryID; }
            set
            {
                if (value != this._fK_VMHistoryID)
                {
                    _fK_VMHistoryID = value;
                    NotifyChanged("FK_VMHistoryID");
                }
            }
        }
        public String VMHistoryDetailTableName
        {
            get { return _vMHistoryDetailTableName; }
            set
            {
                if (value != this._vMHistoryDetailTableName)
                {
                    _vMHistoryDetailTableName = value;
                    NotifyChanged("VMHistoryDetailTableName");
                }
            }
        }
        public String VMHistoryDetailColumnName
        {
            get { return _vMHistoryDetailColumnName; }
            set
            {
                if (value != this._vMHistoryDetailColumnName)
                {
                    _vMHistoryDetailColumnName = value;
                    NotifyChanged("VMHistoryDetailColumnName");
                }
            }
        }
        public String VMHistoryDetailOldValue
        {
            get { return _vMHistoryDetailOldValue; }
            set
            {
                if (value != this._vMHistoryDetailOldValue)
                {
                    _vMHistoryDetailOldValue = value;
                    NotifyChanged("VMHistoryDetailOldValue");
                }
            }
        }
        public String VMHistoryDetailNewValue
        {
            get { return _vMHistoryDetailNewValue; }
            set
            {
                if (value != this._vMHistoryDetailNewValue)
                {
                    _vMHistoryDetailNewValue = value;
                    NotifyChanged("VMHistoryDetailNewValue");
                }
            }
        }
        #endregion
    }
    #endregion
}