﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ADOTFactors
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADOTFactorsInfo
    //Created Date:Monday, December 10, 2018
    //-----------------------------------------------------------

    public class ADOTFactorsInfo : BusinessObject
    {
        public ADOTFactorsInfo()
        {
        }
        #region Variables
        protected int _aDOTFactorID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aDOTFactorName = String.Empty;
        protected String _aDOTFactorType = String.Empty;
        protected DateTime _aDOTFactorFromTime = DateTime.MaxValue;
        protected DateTime _aDOTFactorToTime = DateTime.MaxValue;
        protected decimal _aDOTFactorValue;
        #endregion

        #region Public properties
        public int ADOTFactorID
        {
            get { return _aDOTFactorID; }
            set
            {
                if (value != this._aDOTFactorID)
                {
                    _aDOTFactorID = value;
                    NotifyChanged("ADOTFactorID");
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
        public String ADOTFactorName
        {
            get { return _aDOTFactorName; }
            set
            {
                if (value != this._aDOTFactorName)
                {
                    _aDOTFactorName = value;
                    NotifyChanged("ADOTFactorName");
                }
            }
        }
        public String ADOTFactorType
        {
            get { return _aDOTFactorType; }
            set
            {
                if (value != this._aDOTFactorType)
                {
                    _aDOTFactorType = value;
                    NotifyChanged("ADOTFactorType");
                }
            }
        }
        public DateTime ADOTFactorFromTime
        {
            get { return _aDOTFactorFromTime; }
            set
            {
                if (value != this._aDOTFactorFromTime)
                {
                    _aDOTFactorFromTime = value;
                    NotifyChanged("ADOTFactorFromTime");
                }
            }
        }
        public DateTime ADOTFactorToTime
        {
            get { return _aDOTFactorToTime; }
            set
            {
                if (value != this._aDOTFactorToTime)
                {
                    _aDOTFactorToTime = value;
                    NotifyChanged("ADOTFactorToTime");
                }
            }
        }
        public decimal ADOTFactorValue
        {
            get { return _aDOTFactorValue; }
            set
            {
                if (value != this._aDOTFactorValue)
                {
                    _aDOTFactorValue = value;
                    NotifyChanged("ADOTFactorValue");
                }
            }
        }
        #endregion
    }
    #endregion
}