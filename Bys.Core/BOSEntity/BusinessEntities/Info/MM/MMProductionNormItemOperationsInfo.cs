﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionNormItemOperations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionNormItemOperationsInfo
    //Created Date:Tuesday, November 10, 2015
    //-----------------------------------------------------------

    public class MMProductionNormItemOperationsInfo : BusinessObject
    {
        public MMProductionNormItemOperationsInfo()
        {
        }
        #region Variables
        protected int _mMProductionNormItemOperationID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMProductionNormID;
        protected int _fK_MMProductionNormItemID;
        protected int _fK_ICProductID;
        protected int _fK_MMOperationID;
        #endregion

        #region Public properties
        public int MMProductionNormItemOperationID
        {
            get { return _mMProductionNormItemOperationID; }
            set
            {
                if (value != this._mMProductionNormItemOperationID)
                {
                    _mMProductionNormItemOperationID = value;
                    NotifyChanged("MMProductionNormItemOperationID");
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
        public int FK_MMProductionNormID
        {
            get { return _fK_MMProductionNormID; }
            set
            {
                if (value != this._fK_MMProductionNormID)
                {
                    _fK_MMProductionNormID = value;
                    NotifyChanged("FK_MMProductionNormID");
                }
            }
        }
        public int FK_MMProductionNormItemID
        {
            get { return _fK_MMProductionNormItemID; }
            set
            {
                if (value != this._fK_MMProductionNormItemID)
                {
                    _fK_MMProductionNormItemID = value;
                    NotifyChanged("FK_MMProductionNormItemID");
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
        #endregion
        #region Extra Property
        public int FK_ICProductAttributeSpecialityID { get; set; }
        #endregion
    }
    #endregion
}