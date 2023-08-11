using BOSLib;
using System;
namespace BOSERP
{
    #region PMHistorys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:PMHistorysInfo
    //Created Date:Wednesday, April 4, 2018
    //-----------------------------------------------------------

    public class PMHistorysInfo : BusinessObject
    {
        public PMHistorysInfo()
        {
        }
        #region Variables
        protected int _pMHistoryID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _aDUserID;
        protected String _aDUserName = String.Empty;
        protected String _pMHistoryObjectName = String.Empty;
        protected int _pMHistoryObjectID;
        protected String _pMHistoryObjectNo = String.Empty;
        protected String _pMHistoryAction = String.Empty;
        protected DateTime _pMHistoryDate = DateTime.MaxValue;
        protected String _pMHistoryColumnName = String.Empty;
        protected String _pMHistoryOldValue = String.Empty;
        protected String _pMHistoryNewValue = String.Empty;
        #endregion

        #region Public properties
        public int PMHistoryID
        {
            get { return _pMHistoryID; }
            set
            {
                if (value != this._pMHistoryID)
                {
                    _pMHistoryID = value;
                    NotifyChanged("PMHistoryID");
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
        public String PMHistoryObjectName
        {
            get { return _pMHistoryObjectName; }
            set
            {
                if (value != this._pMHistoryObjectName)
                {
                    _pMHistoryObjectName = value;
                    NotifyChanged("PMHistoryObjectName");
                }
            }
        }
        public int PMHistoryObjectID
        {
            get { return _pMHistoryObjectID; }
            set
            {
                if (value != this._pMHistoryObjectID)
                {
                    _pMHistoryObjectID = value;
                    NotifyChanged("PMHistoryObjectID");
                }
            }
        }
        public String PMHistoryObjectNo
        {
            get { return _pMHistoryObjectNo; }
            set
            {
                if (value != this._pMHistoryObjectNo)
                {
                    _pMHistoryObjectNo = value;
                    NotifyChanged("PMHistoryObjectNo");
                }
            }
        }
        public String PMHistoryAction
        {
            get { return _pMHistoryAction; }
            set
            {
                if (value != this._pMHistoryAction)
                {
                    _pMHistoryAction = value;
                    NotifyChanged("PMHistoryAction");
                }
            }
        }
        public DateTime PMHistoryDate
        {
            get { return _pMHistoryDate; }
            set
            {
                if (value != this._pMHistoryDate)
                {
                    _pMHistoryDate = value;
                    NotifyChanged("PMHistoryDate");
                }
            }
        }
        public String PMHistoryColumnName
        {
            get { return _pMHistoryColumnName; }
            set
            {
                if (value != this._pMHistoryColumnName)
                {
                    _pMHistoryColumnName = value;
                    NotifyChanged("PMHistoryColumnName");
                }
            }
        }
        public String PMHistoryOldValue
        {
            get { return _pMHistoryOldValue; }
            set
            {
                if (value != this._pMHistoryOldValue)
                {
                    _pMHistoryOldValue = value;
                    NotifyChanged("PMHistoryOldValue");
                }
            }
        }
        public String PMHistoryNewValue
        {
            get { return _pMHistoryNewValue; }
            set
            {
                if (value != this._pMHistoryNewValue)
                {
                    _pMHistoryNewValue = value;
                    NotifyChanged("PMHistoryNewValue");
                }
            }
        }

        #endregion
    }
    #endregion
}