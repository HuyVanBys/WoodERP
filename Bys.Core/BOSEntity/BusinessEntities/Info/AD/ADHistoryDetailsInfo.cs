﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ADHistoryDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADHistoryDetailsInfo
    //Created Date:Friday, April 01, 2016
    //-----------------------------------------------------------

    public class ADHistoryDetailsInfo : BusinessObject
    {
        public ADHistoryDetailsInfo()
        {
        }
        #region Variables
        protected int _aDHistoryDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ADHistoryID;
        protected String _aDHistoryDetailTableName = String.Empty;
        protected String _aDHistoryDetailColumnName = String.Empty;
        protected String _aDHistoryDetailOldValue = String.Empty;
        protected String _aDHistoryDetailNewValue = String.Empty;
        #endregion

        #region Public properties
        public int ADHistoryDetailID
        {
            get { return _aDHistoryDetailID; }
            set
            {
                if (value != this._aDHistoryDetailID)
                {
                    _aDHistoryDetailID = value;
                    NotifyChanged("ADHistoryDetailID");
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
        public int FK_ADHistoryID
        {
            get { return _fK_ADHistoryID; }
            set
            {
                if (value != this._fK_ADHistoryID)
                {
                    _fK_ADHistoryID = value;
                    NotifyChanged("FK_ADHistoryID");
                }
            }
        }
        public String ADHistoryDetailTableName
        {
            get { return _aDHistoryDetailTableName; }
            set
            {
                if (value != this._aDHistoryDetailTableName)
                {
                    _aDHistoryDetailTableName = value;
                    NotifyChanged("ADHistoryDetailTableName");
                }
            }
        }
        public String ADHistoryDetailColumnName
        {
            get { return _aDHistoryDetailColumnName; }
            set
            {
                if (value != this._aDHistoryDetailColumnName)
                {
                    _aDHistoryDetailColumnName = value;
                    NotifyChanged("ADHistoryDetailColumnName");
                }
            }
        }
        public String ADHistoryDetailOldValue
        {
            get { return _aDHistoryDetailOldValue; }
            set
            {
                if (value != this._aDHistoryDetailOldValue)
                {
                    _aDHistoryDetailOldValue = value;
                    NotifyChanged("ADHistoryDetailOldValue");
                }
            }
        }
        public String ADHistoryDetailNewValue
        {
            get { return _aDHistoryDetailNewValue; }
            set
            {
                if (value != this._aDHistoryDetailNewValue)
                {
                    _aDHistoryDetailNewValue = value;
                    NotifyChanged("ADHistoryDetailNewValue");
                }
            }
        }
        #endregion
    }
    #endregion
}