﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostFormulaOperationItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostFormulaOperationItemsInfo
    //Created Date:Friday, September 6, 2019
    //-----------------------------------------------------------

    public class MMProductionCostFormulaOperationItemsInfo : BusinessObject
    {
        public MMProductionCostFormulaOperationItemsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostFormulaOperationItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMProductionCostFormulaID;
        protected int _fK_MMOperationID;
        #endregion

        #region Public properties
        public int MMProductionCostFormulaOperationItemID
        {
            get { return _mMProductionCostFormulaOperationItemID; }
            set
            {
                if (value != this._mMProductionCostFormulaOperationItemID)
                {
                    _mMProductionCostFormulaOperationItemID = value;
                    NotifyChanged("MMProductionCostFormulaOperationItemID");
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
    }
    #endregion
}