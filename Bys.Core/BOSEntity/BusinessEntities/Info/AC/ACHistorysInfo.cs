﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACHistorys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACHistorysInfo
    //Created Date:Thursday, March 31, 2016
    //-----------------------------------------------------------

    public class ACHistorysInfo : BusinessObject
    {
        public ACHistorysInfo()
        {
        }
        #region Variables
        protected int _aCHistoryID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _aDUserID;
        protected String _aDUserName = String.Empty;
        protected String _aCHistoryObjectName = String.Empty;
        protected int _aCHistoryObjectID;
        protected String _aCHistoryObjectNo = String.Empty;
        protected String _aCHistoryAction = String.Empty;
        protected DateTime _aCHistoryDate = DateTime.MaxValue;
        protected String _aCHistoryColumnName = String.Empty;
        protected String _aCHistoryOldValue = String.Empty;
        protected String _aCHistoryNewValue = String.Empty;
        #endregion

        #region Public properties
        public int ACHistoryID
        {
            get { return _aCHistoryID; }
            set
            {
                if (value != this._aCHistoryID)
                {
                    _aCHistoryID = value;
                    NotifyChanged("ACHistoryID");
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
        public String ACHistoryObjectName
        {
            get { return _aCHistoryObjectName; }
            set
            {
                if (value != this._aCHistoryObjectName)
                {
                    _aCHistoryObjectName = value;
                    NotifyChanged("ACHistoryObjectName");
                }
            }
        }
        public int ACHistoryObjectID
        {
            get { return _aCHistoryObjectID; }
            set
            {
                if (value != this._aCHistoryObjectID)
                {
                    _aCHistoryObjectID = value;
                    NotifyChanged("ACHistoryObjectID");
                }
            }
        }
        public String ACHistoryObjectNo
        {
            get { return _aCHistoryObjectNo; }
            set
            {
                if (value != this._aCHistoryObjectNo)
                {
                    _aCHistoryObjectNo = value;
                    NotifyChanged("ACHistoryObjectNo");
                }
            }
        }
        public String ACHistoryAction
        {
            get { return _aCHistoryAction; }
            set
            {
                if (value != this._aCHistoryAction)
                {
                    _aCHistoryAction = value;
                    NotifyChanged("ACHistoryAction");
                }
            }
        }
        public DateTime ACHistoryDate
        {
            get { return _aCHistoryDate; }
            set
            {
                if (value != this._aCHistoryDate)
                {
                    _aCHistoryDate = value;
                    NotifyChanged("ACHistoryDate");
                }
            }
        }
        public String ACHistoryColumnName
        {
            get { return _aCHistoryColumnName; }
            set
            {
                if (value != this._aCHistoryColumnName)
                {
                    _aCHistoryColumnName = value;
                    NotifyChanged("ACHistoryColumnName");
                }
            }
        }
        public String ACHistoryOldValue
        {
            get { return _aCHistoryOldValue; }
            set
            {
                if (value != this._aCHistoryOldValue)
                {
                    _aCHistoryOldValue = value;
                    NotifyChanged("ACHistoryOldValue");
                }
            }
        }
        public String ACHistoryNewValue
        {
            get { return _aCHistoryNewValue; }
            set
            {
                if (value != this._aCHistoryNewValue)
                {
                    _aCHistoryNewValue = value;
                    NotifyChanged("ACHistoryNewValue");
                }
            }
        }

        #endregion
    }
    #endregion
}