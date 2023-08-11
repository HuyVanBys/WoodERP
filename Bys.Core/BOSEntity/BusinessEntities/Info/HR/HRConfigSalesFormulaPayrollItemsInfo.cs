﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRConfigSalesFormulaPayrollItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRConfigSalesFormulaPayrollItemsInfo
    //Created Date:Tuesday, July 24, 2018
    //-----------------------------------------------------------

    public class HRConfigSalesFormulaPayrollItemsInfo : BusinessObject
    {
        public HRConfigSalesFormulaPayrollItemsInfo()
        {
        }
        #region Variables
        protected int _hRConfigSalesFormulaPayrollItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected decimal _hRConfigSalesFormulaPayrollItemRewardAmount;
        protected decimal _hRConfigSalesFormulaPayrollItemRewardPercent;
        protected decimal _hRConfigSalesFormulaPayrollItemSalesFrom;
        protected decimal _hRConfigSalesFormulaPayrollItemSalesTo;
        protected String _hRConfigSalesFormulaPayrollItemDependenceType = String.Empty;
        protected decimal _hRConfigSalesFormulaPayrollItemDependenceSalesFrom;
        protected decimal _hRConfigSalesFormulaPayrollItemDependenceSalesTo;
        protected String _hRCircumstancesRewardType = String.Empty;
        protected int _fK_HRConfigSalesFormulaPayrollID;
        #endregion

        #region Public properties
        public int HRConfigSalesFormulaPayrollItemID
        {
            get { return _hRConfigSalesFormulaPayrollItemID; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemID)
                {
                    _hRConfigSalesFormulaPayrollItemID = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemID");
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
        public decimal HRConfigSalesFormulaPayrollItemRewardAmount
        {
            get { return _hRConfigSalesFormulaPayrollItemRewardAmount; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemRewardAmount)
                {
                    _hRConfigSalesFormulaPayrollItemRewardAmount = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemRewardAmount");
                }
            }
        }
        public decimal HRConfigSalesFormulaPayrollItemRewardPercent
        {
            get { return _hRConfigSalesFormulaPayrollItemRewardPercent; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemRewardPercent)
                {
                    _hRConfigSalesFormulaPayrollItemRewardPercent = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemRewardPercent");
                }
            }
        }
        public decimal HRConfigSalesFormulaPayrollItemSalesFrom
        {
            get { return _hRConfigSalesFormulaPayrollItemSalesFrom; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemSalesFrom)
                {
                    _hRConfigSalesFormulaPayrollItemSalesFrom = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemSalesFrom");
                }
            }
        }
        public decimal HRConfigSalesFormulaPayrollItemSalesTo
        {
            get { return _hRConfigSalesFormulaPayrollItemSalesTo; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemSalesTo)
                {
                    _hRConfigSalesFormulaPayrollItemSalesTo = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemSalesTo");
                }
            }
        }
        public String HRConfigSalesFormulaPayrollItemDependenceType
        {
            get { return _hRConfigSalesFormulaPayrollItemDependenceType; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemDependenceType)
                {
                    _hRConfigSalesFormulaPayrollItemDependenceType = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemDependenceType");
                }
            }
        }
        public decimal HRConfigSalesFormulaPayrollItemDependenceSalesFrom
        {
            get { return _hRConfigSalesFormulaPayrollItemDependenceSalesFrom; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemDependenceSalesFrom)
                {
                    _hRConfigSalesFormulaPayrollItemDependenceSalesFrom = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemDependenceSalesFrom");
                }
            }
        }
        public decimal HRConfigSalesFormulaPayrollItemDependenceSalesTo
        {
            get { return _hRConfigSalesFormulaPayrollItemDependenceSalesTo; }
            set
            {
                if (value != this._hRConfigSalesFormulaPayrollItemDependenceSalesTo)
                {
                    _hRConfigSalesFormulaPayrollItemDependenceSalesTo = value;
                    NotifyChanged("HRConfigSalesFormulaPayrollItemDependenceSalesTo");
                }
            }
        }
        public String HRCircumstancesRewardType
        {
            get { return _hRCircumstancesRewardType; }
            set
            {
                if (value != this._hRCircumstancesRewardType)
                {
                    _hRCircumstancesRewardType = value;
                    NotifyChanged("HRCircumstancesRewardType");
                }
            }
        }
        public int FK_HRConfigSalesFormulaPayrollID
        {
            get { return _fK_HRConfigSalesFormulaPayrollID; }
            set
            {
                if (value != this._fK_HRConfigSalesFormulaPayrollID)
                {
                    _fK_HRConfigSalesFormulaPayrollID = value;
                    NotifyChanged("FK_HRConfigSalesFormulaPayrollID");
                }
            }
        }
        #endregion
    }
    #endregion
}