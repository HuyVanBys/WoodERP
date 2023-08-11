﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICModelDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICModelDetailsInfo
    //Created Date:Friday, January 15, 2016
    //-----------------------------------------------------------

    public class ICModelDetailsInfo : BusinessObject
    {
        public ICModelDetailsInfo()
        {
        }
        #region Variables
        protected int _iCModelDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICModelID;
        protected String _iCModelDetailsName = String.Empty;
        protected String _iCModelDetailsDesc = String.Empty;
        #endregion

        #region Public properties
        public int ICModelDetailID
        {
            get { return _iCModelDetailID; }
            set
            {
                if (value != this._iCModelDetailID)
                {
                    _iCModelDetailID = value;
                    NotifyChanged("ICModelDetailID");
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
        public int FK_ICModelID
        {
            get { return _fK_ICModelID; }
            set
            {
                if (value != this._fK_ICModelID)
                {
                    _fK_ICModelID = value;
                    NotifyChanged("FK_ICModelID");
                }
            }
        }
        public String ICModelDetailsName
        {
            get { return _iCModelDetailsName; }
            set
            {
                if (value != this._iCModelDetailsName)
                {
                    _iCModelDetailsName = value;
                    NotifyChanged("ICModelDetailsName");
                }
            }
        }
        public String ICModelDetailsDesc
        {
            get { return _iCModelDetailsDesc; }
            set
            {
                if (value != this._iCModelDetailsDesc)
                {
                    _iCModelDetailsDesc = value;
                    NotifyChanged("ICModelDetailsDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}