﻿using BOSLib;
using System;
namespace BOSERP
{
    #region PMProjectNormHistorys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:PMProjectNormHistorysInfo
    //Created Date:Thursday, August 9, 2018
    //-----------------------------------------------------------

    public class PMProjectNormHistorysInfo : BusinessObject
    {
        public PMProjectNormHistorysInfo()
        {
        }
        #region Variables
        protected int _pMProjectNormHistoryID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _aDUserID;
        protected String _aDUserName = String.Empty;
        protected String _pMProjectNormHistoryAction = String.Empty;
        protected DateTime _pMProjectNormHistoryDate = DateTime.MaxValue;
        protected String _pMProjectNormHistoryTableName = String.Empty;
        protected String _pMProjectNormHistoryDetailColumnName = String.Empty;
        protected String _pMProjectNormHistoryDetailOldValue = String.Empty;
        protected String _pMProjectNormHistoryDetailNewValue = String.Empty;
        protected int _fK_HREmployeeID;
        protected int _fK_PMProjectNormID;
        protected int _fK_PMProjectID;
        #endregion

        #region Public properties
        public int PMProjectNormHistoryID
        {
            get { return _pMProjectNormHistoryID; }
            set
            {
                if (value != this._pMProjectNormHistoryID)
                {
                    _pMProjectNormHistoryID = value;
                    NotifyChanged("PMProjectNormHistoryID");
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
        public int ADUserID
        {
            get { return _aDUserID; }
            set
            {
                if (value != this._aDUserID)
                {
                    _aDUserID = value;
                    NotifyChanged("ADUserID");
                }
            }
        }
        public String ADUserName
        {
            get { return _aDUserName; }
            set
            {
                if (value != this._aDUserName)
                {
                    _aDUserName = value;
                    NotifyChanged("ADUserName");
                }
            }
        }
        public String PMProjectNormHistoryAction
        {
            get { return _pMProjectNormHistoryAction; }
            set
            {
                if (value != this._pMProjectNormHistoryAction)
                {
                    _pMProjectNormHistoryAction = value;
                    NotifyChanged("PMProjectNormHistoryAction");
                }
            }
        }
        public DateTime PMProjectNormHistoryDate
        {
            get { return _pMProjectNormHistoryDate; }
            set
            {
                if (value != this._pMProjectNormHistoryDate)
                {
                    _pMProjectNormHistoryDate = value;
                    NotifyChanged("PMProjectNormHistoryDate");
                }
            }
        }
        public String PMProjectNormHistoryTableName
        {
            get { return _pMProjectNormHistoryTableName; }
            set
            {
                if (value != this._pMProjectNormHistoryTableName)
                {
                    _pMProjectNormHistoryTableName = value;
                    NotifyChanged("PMProjectNormHistoryTableName");
                }
            }
        }
        public String PMProjectNormHistoryDetailColumnName
        {
            get { return _pMProjectNormHistoryDetailColumnName; }
            set
            {
                if (value != this._pMProjectNormHistoryDetailColumnName)
                {
                    _pMProjectNormHistoryDetailColumnName = value;
                    NotifyChanged("PMProjectNormHistoryDetailColumnName");
                }
            }
        }
        public String PMProjectNormHistoryDetailOldValue
        {
            get { return _pMProjectNormHistoryDetailOldValue; }
            set
            {
                if (value != this._pMProjectNormHistoryDetailOldValue)
                {
                    _pMProjectNormHistoryDetailOldValue = value;
                    NotifyChanged("PMProjectNormHistoryDetailOldValue");
                }
            }
        }
        public String PMProjectNormHistoryDetailNewValue
        {
            get { return _pMProjectNormHistoryDetailNewValue; }
            set
            {
                if (value != this._pMProjectNormHistoryDetailNewValue)
                {
                    _pMProjectNormHistoryDetailNewValue = value;
                    NotifyChanged("PMProjectNormHistoryDetailNewValue");
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
        public int FK_PMProjectNormID
        {
            get { return _fK_PMProjectNormID; }
            set
            {
                if (value != this._fK_PMProjectNormID)
                {
                    _fK_PMProjectNormID = value;
                    NotifyChanged("FK_PMProjectNormID");
                }
            }
        }
        public int FK_PMProjectID
        {
            get { return _fK_PMProjectID; }
            set
            {
                if (value != this._fK_PMProjectID)
                {
                    _fK_PMProjectID = value;
                    NotifyChanged("FK_PMProjectID");
                }
            }
        }
        #endregion
    }
    #endregion
}