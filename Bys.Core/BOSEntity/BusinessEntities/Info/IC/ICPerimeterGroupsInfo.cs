﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICPerimeterGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICPerimeterGroupsInfo
    //Created Date:21 December 2018
    //-----------------------------------------------------------

    public class ICPerimeterGroupsInfo : BusinessObject
    {
        public ICPerimeterGroupsInfo()
        {
        }
        #region Variables
        protected int _iCPerimeterGroupID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _iCPerimeterGroupName = String.Empty;
        protected decimal _iCPerimeterGroupMinValue;
        protected decimal _iCPerimeterGroupMaxValue;
        #endregion

        #region Public properties
        public int ICPerimeterGroupID
        {
            get { return _iCPerimeterGroupID; }
            set
            {
                if (value != this._iCPerimeterGroupID)
                {
                    _iCPerimeterGroupID = value;
                    NotifyChanged("ICPerimeterGroupID");
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
        public String ICPerimeterGroupName
        {
            get { return _iCPerimeterGroupName; }
            set
            {
                if (value != this._iCPerimeterGroupName)
                {
                    _iCPerimeterGroupName = value;
                    NotifyChanged("ICPerimeterGroupName");
                }
            }
        }
        public decimal ICPerimeterGroupMinValue
        {
            get { return _iCPerimeterGroupMinValue; }
            set
            {
                if (value != this._iCPerimeterGroupMinValue)
                {
                    _iCPerimeterGroupMinValue = value;
                    NotifyChanged("ICPerimeterGroupMinValue");
                }
            }
        }
        public decimal ICPerimeterGroupMaxValue
        {
            get { return _iCPerimeterGroupMaxValue; }
            set
            {
                if (value != this._iCPerimeterGroupMaxValue)
                {
                    _iCPerimeterGroupMaxValue = value;
                    NotifyChanged("ICPerimeterGroupMaxValue");
                }
            }
        }
        #endregion
    }
    #endregion
}