﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACAccountTranferCosts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAccountTranferCostsInfo
    //Created Date:Monday, March 04, 2019
    //-----------------------------------------------------------

    public class ACAccountTranferCostsInfo : BusinessObject
    {
        public ACAccountTranferCostsInfo()
        {
        }
        #region Variables
        protected int _aCAccountTranferCostID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACDocumentTypeID;
        protected int _fK_ACEntryTypeID;
        protected int _fK_ACFromAccountID;
        protected int _fK_ACToAccountID;
        protected String _aCAccountTranferCostType = String.Empty;
        protected bool _aCAccountTranferCostByCustomer = true;
        protected bool _aCAccountTranferCostByBalance = true;
        protected bool _aCAccountTranferCostByProject = true;
        protected bool _aCAccountTranferCostBySaleOrder = true;
        protected bool _aCAccountTranferCostByProduct = true;
        protected bool _aCAccountTranferCostByCurrency = true;
        protected bool _aCAccountTranferCostByDepartment = true;
        protected bool _aCAccountTranferCostByCostCenter = true;
        protected bool _aCAccountTranferCostBySegment = true;
        protected bool _aCAccountTranferCostByBatch = true;
        protected bool _aCAccountTranferCostFromProductionCost = true;
        #endregion

        #region Public properties
        public int ACAccountTranferCostID
        {
            get { return _aCAccountTranferCostID; }
            set
            {
                if (value != this._aCAccountTranferCostID)
                {
                    _aCAccountTranferCostID = value;
                    NotifyChanged("ACAccountTranferCostID");
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
        public int FK_ACDocumentTypeID
        {
            get { return _fK_ACDocumentTypeID; }
            set
            {
                if (value != this._fK_ACDocumentTypeID)
                {
                    _fK_ACDocumentTypeID = value;
                    NotifyChanged("FK_ACDocumentTypeID");
                }
            }
        }
        public int FK_ACEntryTypeID
        {
            get { return _fK_ACEntryTypeID; }
            set
            {
                if (value != this._fK_ACEntryTypeID)
                {
                    _fK_ACEntryTypeID = value;
                    NotifyChanged("FK_ACEntryTypeID");
                }
            }
        }
        public int FK_ACFromAccountID
        {
            get { return _fK_ACFromAccountID; }
            set
            {
                if (value != this._fK_ACFromAccountID)
                {
                    _fK_ACFromAccountID = value;
                    NotifyChanged("FK_ACFromAccountID");
                }
            }
        }
        public int FK_ACToAccountID
        {
            get { return _fK_ACToAccountID; }
            set
            {
                if (value != this._fK_ACToAccountID)
                {
                    _fK_ACToAccountID = value;
                    NotifyChanged("FK_ACToAccountID");
                }
            }
        }
        public String ACAccountTranferCostType
        {
            get { return _aCAccountTranferCostType; }
            set
            {
                if (value != this._aCAccountTranferCostType)
                {
                    _aCAccountTranferCostType = value;
                    NotifyChanged("ACAccountTranferCostType");
                }
            }
        }
        public bool ACAccountTranferCostByCustomer
        {
            get { return _aCAccountTranferCostByCustomer; }
            set
            {
                if (value != this._aCAccountTranferCostByCustomer)
                {
                    _aCAccountTranferCostByCustomer = value;
                    NotifyChanged("ACAccountTranferCostByCustomer");
                }
            }
        }
        public bool ACAccountTranferCostByBalance
        {
            get { return _aCAccountTranferCostByBalance; }
            set
            {
                if (value != this._aCAccountTranferCostByBalance)
                {
                    _aCAccountTranferCostByBalance = value;
                    NotifyChanged("ACAccountTranferCostByBalance");
                }
            }
        }
        public bool ACAccountTranferCostByProject
        {
            get { return _aCAccountTranferCostByProject; }
            set
            {
                if (value != this._aCAccountTranferCostByProject)
                {
                    _aCAccountTranferCostByProject = value;
                    NotifyChanged("ACAccountTranferCostByProject");
                }
            }
        }
        public bool ACAccountTranferCostBySaleOrder
        {
            get { return _aCAccountTranferCostBySaleOrder; }
            set
            {
                if (value != this._aCAccountTranferCostBySaleOrder)
                {
                    _aCAccountTranferCostBySaleOrder = value;
                    NotifyChanged("ACAccountTranferCostBySaleOrder");
                }
            }
        }
        public bool ACAccountTranferCostByProduct
        {
            get { return _aCAccountTranferCostByProduct; }
            set
            {
                if (value != this._aCAccountTranferCostByProduct)
                {
                    _aCAccountTranferCostByProduct = value;
                    NotifyChanged("ACAccountTranferCostByProduct");
                }
            }
        }
        public bool ACAccountTranferCostByCurrency
        {
            get { return _aCAccountTranferCostByCurrency; }
            set
            {
                if (value != this._aCAccountTranferCostByCurrency)
                {
                    _aCAccountTranferCostByCurrency = value;
                    NotifyChanged("ACAccountTranferCostByCurrency");
                }
            }
        }
        public bool ACAccountTranferCostByDepartment
        {
            get { return _aCAccountTranferCostByDepartment; }
            set
            {
                if (value != this._aCAccountTranferCostByDepartment)
                {
                    _aCAccountTranferCostByDepartment = value;
                    NotifyChanged("ACAccountTranferCostByDepartment");
                }
            }
        }
        public bool ACAccountTranferCostByCostCenter
        {
            get { return _aCAccountTranferCostByCostCenter; }
            set
            {
                if (value != this._aCAccountTranferCostByCostCenter)
                {
                    _aCAccountTranferCostByCostCenter = value;
                    NotifyChanged("ACAccountTranferCostByCostCenter");
                }
            }
        }
        public bool ACAccountTranferCostBySegment
        {
            get { return _aCAccountTranferCostBySegment; }
            set
            {
                if (value != this._aCAccountTranferCostBySegment)
                {
                    _aCAccountTranferCostBySegment = value;
                    NotifyChanged("ACAccountTranferCostBySegment");
                }
            }
        }
        public bool ACAccountTranferCostByBatch
        {
            get { return _aCAccountTranferCostByBatch; }
            set
            {
                if (value != this._aCAccountTranferCostByBatch)
                {
                    _aCAccountTranferCostByBatch = value;
                    NotifyChanged("ACAccountTranferCostByBatch");
                }
            }
        }
        public bool ACAccountTranferCostFromProductionCost
        {
            get { return _aCAccountTranferCostFromProductionCost; }
            set
            {
                if (value != this._aCAccountTranferCostFromProductionCost)
                {
                    _aCAccountTranferCostFromProductionCost = value;
                    NotifyChanged("ACAccountTranferCostFromProductionCost");
                }
            }
        }
        #endregion
    }
    #endregion
}