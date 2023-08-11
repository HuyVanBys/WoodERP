﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostFormulaProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostFormulaProductsInfo
    //Created Date:Thursday, September 20, 2018
    //-----------------------------------------------------------

    public class MMProductionCostFormulaProductsInfo : BusinessObject
    {
        public MMProductionCostFormulaProductsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostFormulaProductID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMProductionCostFormulaID;
        protected int _fK_ICProductID;
        protected String _mMProductionCostFormulaProductName = String.Empty;
        protected String _mMProductionCostFormulaProductDesc = String.Empty;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICDepartmentID;
        #endregion

        #region Public properties
        public int MMProductionCostFormulaProductID
        {
            get { return _mMProductionCostFormulaProductID; }
            set
            {
                if (value != this._mMProductionCostFormulaProductID)
                {
                    _mMProductionCostFormulaProductID = value;
                    NotifyChanged("MMProductionCostFormulaProductID");
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
        public int FK_MMProductionCostFormulaID
        {
            get { return _fK_MMProductionCostFormulaID; }
            set
            {
                if (value != this._fK_MMProductionCostFormulaID)
                {
                    _fK_MMProductionCostFormulaID = value;
                    NotifyChanged("FK_MMProductionCostFormulaID");
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
        public String MMProductionCostFormulaProductName
        {
            get { return _mMProductionCostFormulaProductName; }
            set
            {
                if (value != this._mMProductionCostFormulaProductName)
                {
                    _mMProductionCostFormulaProductName = value;
                    NotifyChanged("MMProductionCostFormulaProductName");
                }
            }
        }
        public String MMProductionCostFormulaProductDesc
        {
            get { return _mMProductionCostFormulaProductDesc; }
            set
            {
                if (value != this._mMProductionCostFormulaProductDesc)
                {
                    _mMProductionCostFormulaProductDesc = value;
                    NotifyChanged("MMProductionCostFormulaProductDesc");
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
        public int FK_ICDepartmentID
        {
            get { return _fK_ICDepartmentID; }
            set
            {
                if (value != this._fK_ICDepartmentID)
                {
                    _fK_ICDepartmentID = value;
                    NotifyChanged("FK_ICDepartmentID");
                }
            }
        }
        #endregion

    }
    #endregion
}