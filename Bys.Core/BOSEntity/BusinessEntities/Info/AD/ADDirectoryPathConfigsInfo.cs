﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ADDirectoryPathConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADDirectoryPathConfigsInfo
    //Created Date:Tuesday, April 09, 2019
    //-----------------------------------------------------------

    public class ADDirectoryPathConfigsInfo : BusinessObject
    {
        public ADDirectoryPathConfigsInfo()
        {
        }
        #region Variables
        protected int _aDDirectoryPathConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aDDirectoryPathConfigAddress = String.Empty;
        protected String _aDImageFolderType = String.Empty;
        protected String _aDDirectoryPathConfigUserName = String.Empty;
        protected String _aDDirectoryPathConfigPassword = String.Empty;

        #endregion

        #region Public properties
        public int ADDirectoryPathConfigID
        {
            get { return _aDDirectoryPathConfigID; }
            set
            {
                if (value != this._aDDirectoryPathConfigID)
                {
                    _aDDirectoryPathConfigID = value;
                    NotifyChanged("ADDirectoryPathConfigID");
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
        public String ADDirectoryPathConfigAddress
        {
            get { return _aDDirectoryPathConfigAddress; }
            set
            {
                if (value != this._aDDirectoryPathConfigAddress)
                {
                    _aDDirectoryPathConfigAddress = value;
                    NotifyChanged("ADDirectoryPathConfigAddress");
                }
            }
        }
        public String ADImageFolderType
        {
            get { return _aDImageFolderType; }
            set
            {
                if (value != this._aDImageFolderType)
                {
                    _aDImageFolderType = value;
                    NotifyChanged("ADImageFolderType");
                }
            }
        }
        public String ADDirectoryPathConfigUserName
        {
            get { return _aDDirectoryPathConfigUserName; }
            set
            {
                if (value != this._aDDirectoryPathConfigUserName)
                {
                    _aDDirectoryPathConfigUserName = value;
                    NotifyChanged("ADDirectoryPathConfigUserName");
                }
            }
        }
        public String ADDirectoryPathConfigPassword
        {
            get { return _aDDirectoryPathConfigPassword; }
            set
            {
                if (value != this._aDDirectoryPathConfigPassword)
                {
                    _aDDirectoryPathConfigPassword = value;
                    NotifyChanged("ADDirectoryPathConfigPassword");
                }
            }
        }

        #endregion
    }
    #endregion
}