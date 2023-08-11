﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMExecuteTimeConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMExecuteTimeConfigsInfo
    //Created Date:Tuesday, April 02, 2019
    //-----------------------------------------------------------

    public class MMExecuteTimeConfigsInfo : BusinessObject
    {
        public MMExecuteTimeConfigsInfo()
        {
        }
        #region Variables
        protected int _mMExecuteTimeConfigID;
        protected string _aAStatus = DefaultAAStatus;
        protected string _aACreatedUser = string.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected string _aAUpdatedUser = string.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_MMOperationID;
        protected string _mMProductGroupType = string.Empty;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductID;
        protected decimal _mMExecuteTimeConfigExecuteTime;
        protected int _fK_ICProductGroupID;
        #endregion

        #region Public properties
        public int MMExecuteTimeConfigID
        {
            get { return _mMExecuteTimeConfigID; }
            set
            {
                if (value != this._mMExecuteTimeConfigID)
                {
                    _mMExecuteTimeConfigID = value;
                    NotifyChanged("MMExecuteTimeConfigID");
                }
            }
        }
        public string AAStatus
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
        public string AACreatedUser
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
        public string AAUpdatedUser
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
        public int FK_MMOperationID
        {
            get { return _fK_MMOperationID; }
            set
            {
                if (value != this._fK_MMOperationID)
                {
                    _fK_MMOperationID = value;
                    NotifyChanged("FK_MMOperationID");
                }
            }
        }
        public string MMProductGroupType
        {
            get { return _mMProductGroupType; }
            set
            {
                if (value != this._mMProductGroupType)
                {
                    _mMProductGroupType = value;
                    NotifyChanged("MMProductGroupType");
                }
            }
        }
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public decimal MMExecuteTimeConfigExecuteTime
        {
            get { return _mMExecuteTimeConfigExecuteTime; }
            set
            {
                if (value != this._mMExecuteTimeConfigExecuteTime)
                {
                    _mMExecuteTimeConfigExecuteTime = value;
                    NotifyChanged("MMExecuteTimeConfigExecuteTime");
                }
            }
        }
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                    NotifyChanged("FK_ICProductGroupID");
                }
            }
        }
        #endregion


    }
    #endregion
}