﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICDepartments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICDepartmentsInfo
    //Created Date:Wednesday, June 22, 2011
    //-----------------------------------------------------------

    public class ICDepartmentsInfo : BusinessObject
    {
        public ICDepartmentsInfo()
        {
        }
        #region Variables
        protected int _iCDepartmentID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCDepartmentNo = String.Empty;
        protected String _iCDepartmentName = String.Empty;
        protected String _iCDepartmentDesc = String.Empty;
        protected bool _iCDepartmentActiveCheck = true;
        protected String _iCDepartmentMatchCode01Combo = String.Empty;
        protected String _iCDepartmentMatchCode02Combo = String.Empty;
        protected String _iCDepartmentMatchCode03Combo = String.Empty;
        protected String _iCDepartmentMatchCode04Combo = String.Empty;
        protected String _iCDepartmentMatchCode05Combo = String.Empty;
        protected String _iCDepartmentMatchCode06Combo = String.Empty;
        protected String _iCDepartmentMatchCode07Combo = String.Empty;
        protected String _iCDepartmentMatchCode08Combo = String.Empty;
        protected String _iCDepartmentMatchCode09Combo = String.Empty;
        protected String _iCDepartmentMatchCode10Combo = String.Empty;
        protected String _iCDepartmentMatchCode11Combo = String.Empty;
        protected String _iCDepartmentMatchCode12Combo = String.Empty;
        #endregion

        #region Public properties
        public int ICDepartmentID
        {
            get { return _iCDepartmentID; }
            set
            {
                if (value != this._iCDepartmentID)
                {
                    _iCDepartmentID = value;
                    NotifyChanged("ICDepartmentID");
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
        public String ICDepartmentNo
        {
            get { return _iCDepartmentNo; }
            set
            {
                if (value != this._iCDepartmentNo)
                {
                    _iCDepartmentNo = value;
                    NotifyChanged("ICDepartmentNo");
                }
            }
        }
        public String ICDepartmentName
        {
            get { return _iCDepartmentName; }
            set
            {
                if (value != this._iCDepartmentName)
                {
                    _iCDepartmentName = value;
                    NotifyChanged("ICDepartmentName");
                }
            }
        }
        public String ICDepartmentDesc
        {
            get { return _iCDepartmentDesc; }
            set
            {
                if (value != this._iCDepartmentDesc)
                {
                    _iCDepartmentDesc = value;
                    NotifyChanged("ICDepartmentDesc");
                }
            }
        }
        public bool ICDepartmentActiveCheck
        {
            get { return _iCDepartmentActiveCheck; }
            set
            {
                if (value != this._iCDepartmentActiveCheck)
                {
                    _iCDepartmentActiveCheck = value;
                    NotifyChanged("ICDepartmentActiveCheck");
                }
            }
        }
        public String ICDepartmentMatchCode01Combo
        {
            get { return _iCDepartmentMatchCode01Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode01Combo)
                {
                    _iCDepartmentMatchCode01Combo = value;
                    NotifyChanged("ICDepartmentMatchCode01Combo");
                }
            }
        }
        public String ICDepartmentMatchCode02Combo
        {
            get { return _iCDepartmentMatchCode02Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode02Combo)
                {
                    _iCDepartmentMatchCode02Combo = value;
                    NotifyChanged("ICDepartmentMatchCode02Combo");
                }
            }
        }
        public String ICDepartmentMatchCode03Combo
        {
            get { return _iCDepartmentMatchCode03Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode03Combo)
                {
                    _iCDepartmentMatchCode03Combo = value;
                    NotifyChanged("ICDepartmentMatchCode03Combo");
                }
            }
        }
        public String ICDepartmentMatchCode04Combo
        {
            get { return _iCDepartmentMatchCode04Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode04Combo)
                {
                    _iCDepartmentMatchCode04Combo = value;
                    NotifyChanged("ICDepartmentMatchCode04Combo");
                }
            }
        }
        public String ICDepartmentMatchCode05Combo
        {
            get { return _iCDepartmentMatchCode05Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode05Combo)
                {
                    _iCDepartmentMatchCode05Combo = value;
                    NotifyChanged("ICDepartmentMatchCode05Combo");
                }
            }
        }
        public String ICDepartmentMatchCode06Combo
        {
            get { return _iCDepartmentMatchCode06Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode06Combo)
                {
                    _iCDepartmentMatchCode06Combo = value;
                    NotifyChanged("ICDepartmentMatchCode06Combo");
                }
            }
        }
        public String ICDepartmentMatchCode07Combo
        {
            get { return _iCDepartmentMatchCode07Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode07Combo)
                {
                    _iCDepartmentMatchCode07Combo = value;
                    NotifyChanged("ICDepartmentMatchCode07Combo");
                }
            }
        }
        public String ICDepartmentMatchCode08Combo
        {
            get { return _iCDepartmentMatchCode08Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode08Combo)
                {
                    _iCDepartmentMatchCode08Combo = value;
                    NotifyChanged("ICDepartmentMatchCode08Combo");
                }
            }
        }
        public String ICDepartmentMatchCode09Combo
        {
            get { return _iCDepartmentMatchCode09Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode09Combo)
                {
                    _iCDepartmentMatchCode09Combo = value;
                    NotifyChanged("ICDepartmentMatchCode09Combo");
                }
            }
        }
        public String ICDepartmentMatchCode10Combo
        {
            get { return _iCDepartmentMatchCode10Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode10Combo)
                {
                    _iCDepartmentMatchCode10Combo = value;
                    NotifyChanged("ICDepartmentMatchCode10Combo");
                }
            }
        }
        public String ICDepartmentMatchCode11Combo
        {
            get { return _iCDepartmentMatchCode11Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode11Combo)
                {
                    _iCDepartmentMatchCode11Combo = value;
                    NotifyChanged("ICDepartmentMatchCode11Combo");
                }
            }
        }
        public String ICDepartmentMatchCode12Combo
        {
            get { return _iCDepartmentMatchCode12Combo; }
            set
            {
                if (value != this._iCDepartmentMatchCode12Combo)
                {
                    _iCDepartmentMatchCode12Combo = value;
                    NotifyChanged("ICDepartmentMatchCode12Combo");
                }
            }
        }
        #endregion
    }
    #endregion
}