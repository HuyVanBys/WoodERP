﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMReuseSpecificateConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMReuseSpecificateConfigsInfo
    //Created Date:Wednesday, October 21, 2015
    //-----------------------------------------------------------

    public class MMReuseSpecificateConfigsInfo : BusinessObject
    {
        public MMReuseSpecificateConfigsInfo()
        {
        }
        #region Variables
        protected int _mMReuseSpecificateConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProductAttributeSpecialityID;
        protected decimal _mMReuseSpecificateConfigThickMin;
        protected decimal _mMReuseSpecificateConfigThickMax;
        protected decimal _mMReuseSpecificateConfigWidthMin;
        protected decimal _mMReuseSpecificateConfigWidthMax;
        protected decimal _mMReuseSpecificateConfigHeightMin;
        protected decimal _mMReuseSpecificateConfigHeightMax;
        protected String _mMReuseSpecificateConfigAttributeNo = String.Empty;
        protected String _mMReuseSpecificateConfigAttributeValue = String.Empty;
        #endregion

        #region Public properties
        public int MMReuseSpecificateConfigID
        {
            get { return _mMReuseSpecificateConfigID; }
            set
            {
                if (value != this._mMReuseSpecificateConfigID)
                {
                    _mMReuseSpecificateConfigID = value;
                    NotifyChanged("MMReuseSpecificateConfigID");
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
        public int FK_ICProductAttributeSpecialityID
        {
            get { return _fK_ICProductAttributeSpecialityID; }
            set
            {
                if (value != this._fK_ICProductAttributeSpecialityID)
                {
                    _fK_ICProductAttributeSpecialityID = value;
                    NotifyChanged("FK_ICProductAttributeSpecialityID");
                }
            }
        }
        public decimal MMReuseSpecificateConfigThickMin
        {
            get { return _mMReuseSpecificateConfigThickMin; }
            set
            {
                if (value != this._mMReuseSpecificateConfigThickMin)
                {
                    _mMReuseSpecificateConfigThickMin = value;
                    NotifyChanged("MMReuseSpecificateConfigThickMin");
                }
            }
        }
        public decimal MMReuseSpecificateConfigThickMax
        {
            get { return _mMReuseSpecificateConfigThickMax; }
            set
            {
                if (value != this._mMReuseSpecificateConfigThickMax)
                {
                    _mMReuseSpecificateConfigThickMax = value;
                    NotifyChanged("MMReuseSpecificateConfigThickMax");
                }
            }
        }
        public decimal MMReuseSpecificateConfigWidthMin
        {
            get { return _mMReuseSpecificateConfigWidthMin; }
            set
            {
                if (value != this._mMReuseSpecificateConfigWidthMin)
                {
                    _mMReuseSpecificateConfigWidthMin = value;
                    NotifyChanged("MMReuseSpecificateConfigWidthMin");
                }
            }
        }
        public decimal MMReuseSpecificateConfigWidthMax
        {
            get { return _mMReuseSpecificateConfigWidthMax; }
            set
            {
                if (value != this._mMReuseSpecificateConfigWidthMax)
                {
                    _mMReuseSpecificateConfigWidthMax = value;
                    NotifyChanged("MMReuseSpecificateConfigWidthMax");
                }
            }
        }
        public decimal MMReuseSpecificateConfigHeightMin
        {
            get { return _mMReuseSpecificateConfigHeightMin; }
            set
            {
                if (value != this._mMReuseSpecificateConfigHeightMin)
                {
                    _mMReuseSpecificateConfigHeightMin = value;
                    NotifyChanged("MMReuseSpecificateConfigHeightMin");
                }
            }
        }
        public decimal MMReuseSpecificateConfigHeightMax
        {
            get { return _mMReuseSpecificateConfigHeightMax; }
            set
            {
                if (value != this._mMReuseSpecificateConfigHeightMax)
                {
                    _mMReuseSpecificateConfigHeightMax = value;
                    NotifyChanged("MMReuseSpecificateConfigHeightMax");
                }
            }
        }
        public String MMReuseSpecificateConfigAttributeNo
        {
            get { return _mMReuseSpecificateConfigAttributeNo; }
            set
            {
                if (value != this._mMReuseSpecificateConfigAttributeNo)
                {
                    _mMReuseSpecificateConfigAttributeNo = value;
                    NotifyChanged("MMReuseSpecificateConfigAttributeNo");
                }
            }
        }
        public String MMReuseSpecificateConfigAttributeValue
        {
            get { return _mMReuseSpecificateConfigAttributeValue; }
            set
            {
                if (value != this._mMReuseSpecificateConfigAttributeValue)
                {
                    _mMReuseSpecificateConfigAttributeValue = value;
                    NotifyChanged("MMReuseSpecificateConfigAttributeValue");
                }
            }
        }
        #endregion
    }
    #endregion
}