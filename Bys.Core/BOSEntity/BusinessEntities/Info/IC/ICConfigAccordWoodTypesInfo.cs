﻿using BOSLib;
using System;
using System.Text;
using System.Collections.Generic;
namespace BOSERP
{
    #region ICConfigAccordWoodTypes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICConfigAccordWoodTypesInfo
    //Created Date:Tuesday, March 26, 2019
    //-----------------------------------------------------------

    public class ICConfigAccordWoodTypesInfo : BusinessObject
    {
        public ICConfigAccordWoodTypesInfo()
        {
        }
        #region Variables
        protected int _iCConfigAccordWoodTypeID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProductAttributeID;
        protected String _iCConfigAccordWoodTypeAttributeType = String.Empty;
        #endregion

        #region Public properties
        public int ICConfigAccordWoodTypeID
        {
            get { return _iCConfigAccordWoodTypeID; }
            set
            {
                if (value != this._iCConfigAccordWoodTypeID)
                {
                    _iCConfigAccordWoodTypeID = value;
                    NotifyChanged("ICConfigAccordWoodTypeID");
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
        public int FK_ICProductAttributeWoodTypeID
        {
            get { return _fK_ICProductAttributeWoodTypeID; }
            set
            {
                if (value != this._fK_ICProductAttributeWoodTypeID)
                {
                    _fK_ICProductAttributeWoodTypeID = value;
                    NotifyChanged("FK_ICProductAttributeWoodTypeID");
                }
            }
        }
        public int FK_ICProductAttributeID
        {
            get { return _fK_ICProductAttributeID; }
            set
            {
                if (value != this._fK_ICProductAttributeID)
                {
                    _fK_ICProductAttributeID = value;
                    NotifyChanged("FK_ICProductAttributeID");
                }
            }
        }
        public String ICConfigAccordWoodTypeAttributeType
        {
            get { return _iCConfigAccordWoodTypeAttributeType; }
            set
            {
                if (value != this._iCConfigAccordWoodTypeAttributeType)
                {
                    _iCConfigAccordWoodTypeAttributeType = value;
                    NotifyChanged("ICConfigAccordWoodTypeAttributeType");
                }
            }
        }
        #endregion
    }
    #endregion
}