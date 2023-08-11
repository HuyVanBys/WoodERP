﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductMachines
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductMachinesInfo
    //Created Date:Friday, October 04, 2019
    //-----------------------------------------------------------

    public class ICProductMachinesInfo : BusinessObject
    {
        public ICProductMachinesInfo()
        {
        }
        #region Variables
        protected int _iCProductMachineID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_ICProductID;
        protected int _fK_ICMachineProductID;
        protected String _iCProductNo = String.Empty;
        protected String _iCProductName = String.Empty;
        protected String _iCProductMachineDesc = String.Empty;
        #endregion

        #region Public properties
        public int ICProductMachineID
        {
            get { return _iCProductMachineID; }
            set
            {
                if (value != this._iCProductMachineID)
                {
                    _iCProductMachineID = value;
                    NotifyChanged("ICProductMachineID");
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
        public int FK_ICMachineProductID
        {
            get { return _fK_ICMachineProductID; }
            set
            {
                if (value != this._fK_ICMachineProductID)
                {
                    _fK_ICMachineProductID = value;
                    NotifyChanged("FK_ICMachineProductID");
                }
            }
        }
        public String ICProductNo
        {
            get { return _iCProductNo; }
            set
            {
                if (value != this._iCProductNo)
                {
                    _iCProductNo = value;
                    NotifyChanged("ICProductNo");
                }
            }
        }
        public String ICProductName
        {
            get { return _iCProductName; }
            set
            {
                if (value != this._iCProductName)
                {
                    _iCProductName = value;
                    NotifyChanged("ICProductName");
                }
            }
        }
        public String ICProductMachineDesc
        {
            get { return _iCProductMachineDesc; }
            set
            {
                if (value != this._iCProductMachineDesc)
                {
                    _iCProductMachineDesc = value;
                    NotifyChanged("ICProductMachineDesc");
                }
            }
        }
        #endregion

    }
    #endregion
}