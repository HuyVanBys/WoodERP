﻿using BOSLib;
using System;
namespace BOSERP
{
    #region GEReligions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEReligionsInfo
    //Created Date:Monday, June 13, 2016
    //-----------------------------------------------------------

    public class GEReligionsInfo : BusinessObject
    {
        public GEReligionsInfo()
        {
        }
        #region Variables
        protected int _gEReligionID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _gEReligionName = String.Empty;
        #endregion

        #region Public properties
        public int GEReligionID
        {
            get { return _gEReligionID; }
            set
            {
                if (value != this._gEReligionID)
                {
                    _gEReligionID = value;
                    NotifyChanged("GEReligionID");
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
        public String GEReligionName
        {
            get { return _gEReligionName; }
            set
            {
                if (value != this._gEReligionName)
                {
                    _gEReligionName = value;
                    NotifyChanged("GEReligionName");
                }
            }
        }
        #endregion
    }
    #endregion
}