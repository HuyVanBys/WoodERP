﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMNormTemplateProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMNormTemplateProductsInfo
    //Created Date:Tuesday, November 06, 2018
    //-----------------------------------------------------------

    public class MMNormTemplateProductsInfo : BusinessObject
    {
        public MMNormTemplateProductsInfo()
        {
        }
        #region Variables
        protected int _mMNormTemplateProductID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected String _mMNormTemplateProductDesc = String.Empty;
        protected int _fK_MMNormTemplateID;
        protected int _fK_ICProductID;
        protected int _fK_ICProductGroupID;
        #endregion

        #region Public properties
        public int MMNormTemplateProductID
        {
            get { return _mMNormTemplateProductID; }
            set
            {
                if (value != this._mMNormTemplateProductID)
                {
                    _mMNormTemplateProductID = value;
                    NotifyChanged("MMNormTemplateProductID");
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
        public String MMNormTemplateProductDesc
        {
            get { return _mMNormTemplateProductDesc; }
            set
            {
                if (value != this._mMNormTemplateProductDesc)
                {
                    _mMNormTemplateProductDesc = value;
                    NotifyChanged("MMNormTemplateProductDesc");
                }
            }
        }
        public int FK_MMNormTemplateID
        {
            get { return _fK_MMNormTemplateID; }
            set
            {
                if (value != this._fK_MMNormTemplateID)
                {
                    _fK_MMNormTemplateID = value;
                    NotifyChanged("FK_MMNormTemplateID");
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