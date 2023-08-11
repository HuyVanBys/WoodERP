﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMWorkShops
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMWorkShopsInfo
    //Created Date:Tuesday, October 20, 2015
    //-----------------------------------------------------------

    public class MMWorkShopsInfo : BusinessObject
    {
        public MMWorkShopsInfo()
        {
        }
        #region Variables
        protected int _mMWorkShopID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_GELocationID;
        protected int _fK_BRBranchID;
        protected String _mMWorkShopNo = String.Empty;
        protected String _mMWorkShopName = String.Empty;
        protected String _mMWorkShopDesc = String.Empty;
        protected decimal _mMWorkShopLength;
        protected decimal _mMWorkShopWidth;
        protected String _mMWorkShopContactName = String.Empty;
        protected DateTime _mMWorkShopContactBirthday = DateTime.MaxValue;
        protected String _mMWorkShopContactFirstName = String.Empty;
        protected String _mMWorkShopContactLastName = String.Empty;
        protected String _mMWorkShopContactTitle = String.Empty;
        protected String _mMWorkShopContactPhone = String.Empty;
        protected String _mMWorkShopContactCellPhone = String.Empty;
        protected String _mMWorkShopContactEmail = String.Empty;
        protected String _mMWorkShopContactFax = String.Empty;
        protected String _mMWorkShopContactDepartment = String.Empty;
        protected String _mMWorkShopContactRoom = String.Empty;
        protected bool _mMWorkShopActiveCheck = true;
        protected String _mMWorkShopGELocationName = String.Empty;
        #endregion

        #region Public properties
        public int MMWorkShopID
        {
            get { return _mMWorkShopID; }
            set
            {
                if (value != this._mMWorkShopID)
                {
                    _mMWorkShopID = value;
                    NotifyChanged("MMWorkShopID");
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
        public int FK_GELocationID
        {
            get { return _fK_GELocationID; }
            set
            {
                if (value != this._fK_GELocationID)
                {
                    _fK_GELocationID = value;
                    NotifyChanged("FK_GELocationID");
                }
            }
        }
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        public String MMWorkShopNo
        {
            get { return _mMWorkShopNo; }
            set
            {
                if (value != this._mMWorkShopNo)
                {
                    _mMWorkShopNo = value;
                    NotifyChanged("MMWorkShopNo");
                }
            }
        }
        public String MMWorkShopName
        {
            get { return _mMWorkShopName; }
            set
            {
                if (value != this._mMWorkShopName)
                {
                    _mMWorkShopName = value;
                    NotifyChanged("MMWorkShopName");
                }
            }
        }
        public String MMWorkShopDesc
        {
            get { return _mMWorkShopDesc; }
            set
            {
                if (value != this._mMWorkShopDesc)
                {
                    _mMWorkShopDesc = value;
                    NotifyChanged("MMWorkShopDesc");
                }
            }
        }
        public decimal MMWorkShopLength
        {
            get { return _mMWorkShopLength; }
            set
            {
                if (value != this._mMWorkShopLength)
                {
                    _mMWorkShopLength = value;
                    NotifyChanged("MMWorkShopLength");
                }
            }
        }
        public decimal MMWorkShopWidth
        {
            get { return _mMWorkShopWidth; }
            set
            {
                if (value != this._mMWorkShopWidth)
                {
                    _mMWorkShopWidth = value;
                    NotifyChanged("MMWorkShopWidth");
                }
            }
        }
        public String MMWorkShopContactName
        {
            get { return _mMWorkShopContactName; }
            set
            {
                if (value != this._mMWorkShopContactName)
                {
                    _mMWorkShopContactName = value;
                    NotifyChanged("MMWorkShopContactName");
                }
            }
        }
        public DateTime MMWorkShopContactBirthday
        {
            get { return _mMWorkShopContactBirthday; }
            set
            {
                if (value != this._mMWorkShopContactBirthday)
                {
                    _mMWorkShopContactBirthday = value;
                    NotifyChanged("MMWorkShopContactBirthday");
                }
            }
        }
        public String MMWorkShopContactFirstName
        {
            get { return _mMWorkShopContactFirstName; }
            set
            {
                if (value != this._mMWorkShopContactFirstName)
                {
                    _mMWorkShopContactFirstName = value;
                    NotifyChanged("MMWorkShopContactFirstName");
                }
            }
        }
        public String MMWorkShopContactLastName
        {
            get { return _mMWorkShopContactLastName; }
            set
            {
                if (value != this._mMWorkShopContactLastName)
                {
                    _mMWorkShopContactLastName = value;
                    NotifyChanged("MMWorkShopContactLastName");
                }
            }
        }
        public String MMWorkShopContactTitle
        {
            get { return _mMWorkShopContactTitle; }
            set
            {
                if (value != this._mMWorkShopContactTitle)
                {
                    _mMWorkShopContactTitle = value;
                    NotifyChanged("MMWorkShopContactTitle");
                }
            }
        }
        public String MMWorkShopContactPhone
        {
            get { return _mMWorkShopContactPhone; }
            set
            {
                if (value != this._mMWorkShopContactPhone)
                {
                    _mMWorkShopContactPhone = value;
                    NotifyChanged("MMWorkShopContactPhone");
                }
            }
        }
        public String MMWorkShopContactCellPhone
        {
            get { return _mMWorkShopContactCellPhone; }
            set
            {
                if (value != this._mMWorkShopContactCellPhone)
                {
                    _mMWorkShopContactCellPhone = value;
                    NotifyChanged("MMWorkShopContactCellPhone");
                }
            }
        }
        public String MMWorkShopContactEmail
        {
            get { return _mMWorkShopContactEmail; }
            set
            {
                if (value != this._mMWorkShopContactEmail)
                {
                    _mMWorkShopContactEmail = value;
                    NotifyChanged("MMWorkShopContactEmail");
                }
            }
        }
        public String MMWorkShopContactFax
        {
            get { return _mMWorkShopContactFax; }
            set
            {
                if (value != this._mMWorkShopContactFax)
                {
                    _mMWorkShopContactFax = value;
                    NotifyChanged("MMWorkShopContactFax");
                }
            }
        }
        public String MMWorkShopContactDepartment
        {
            get { return _mMWorkShopContactDepartment; }
            set
            {
                if (value != this._mMWorkShopContactDepartment)
                {
                    _mMWorkShopContactDepartment = value;
                    NotifyChanged("MMWorkShopContactDepartment");
                }
            }
        }
        public String MMWorkShopContactRoom
        {
            get { return _mMWorkShopContactRoom; }
            set
            {
                if (value != this._mMWorkShopContactRoom)
                {
                    _mMWorkShopContactRoom = value;
                    NotifyChanged("MMWorkShopContactRoom");
                }
            }
        }
        public bool MMWorkShopActiveCheck
        {
            get { return _mMWorkShopActiveCheck; }
            set
            {
                if (value != this._mMWorkShopActiveCheck)
                {
                    _mMWorkShopActiveCheck = value;
                    NotifyChanged("MMWorkShopActiveCheck");
                }
            }
        }
        public String MMWorkShopGELocationName
        {
            get { return _mMWorkShopGELocationName; }
            set
            {
                if (value != this._mMWorkShopGELocationName)
                {
                    _mMWorkShopGELocationName = value;
                    NotifyChanged("MMWorkShopGELocationName");
                }
            }
        }
        #endregion
    }
    #endregion
}