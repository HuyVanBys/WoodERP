﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMFormulas
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMFormulasInfo
    //Created Date:Wednesday, October 28, 2015
    //-----------------------------------------------------------

    public class MMFormulasInfo : BusinessObject
    {
        public MMFormulasInfo()
        {
        }
        #region Variables
        protected int _mMFormulaID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HREmployeeID;
        protected String _mMFormulaNo = String.Empty;
        protected String _mMFormulaName = String.Empty;
        protected String _mMFormulaDesc = String.Empty;
        protected String _mMFormulaType = String.Empty;
        #endregion

        #region Public properties
        public int MMFormulaID
        {
            get { return _mMFormulaID; }
            set
            {
                if (value != this._mMFormulaID)
                {
                    _mMFormulaID = value;
                    NotifyChanged("MMFormulaID");
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
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public String MMFormulaNo
        {
            get { return _mMFormulaNo; }
            set
            {
                if (value != this._mMFormulaNo)
                {
                    _mMFormulaNo = value;
                    NotifyChanged("MMFormulaNo");
                }
            }
        }
        public String MMFormulaName
        {
            get { return _mMFormulaName; }
            set
            {
                if (value != this._mMFormulaName)
                {
                    _mMFormulaName = value;
                    NotifyChanged("MMFormulaName");
                }
            }
        }
        public String MMFormulaDesc
        {
            get { return _mMFormulaDesc; }
            set
            {
                if (value != this._mMFormulaDesc)
                {
                    _mMFormulaDesc = value;
                    NotifyChanged("MMFormulaDesc");
                }
            }
        }
        public String MMFormulaType
        {
            get { return _mMFormulaType; }
            set
            {
                if (value != this._mMFormulaType)
                {
                    _mMFormulaType = value;
                    NotifyChanged("MMFormulaType");
                }
            }
        }
        #endregion

    }
    #endregion
}