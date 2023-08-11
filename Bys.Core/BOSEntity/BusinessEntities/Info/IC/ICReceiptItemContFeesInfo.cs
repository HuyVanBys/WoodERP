﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICReceiptItemContFees
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICReceiptItemContFeesInfo
    //Created Date:Monday, March 18, 2019
    //-----------------------------------------------------------

    public class ICReceiptItemContFeesInfo : BusinessObject
    {
        public ICReceiptItemContFeesInfo()
        {
        }
        #region Variables
        protected int _iCReceiptItemContFeeID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICReceiptID;
        protected int _fK_GEContainerID;
        protected int _fK_GEUnitCostID;
        protected decimal _iCReceiptItemContFeeUnitCost;
        protected decimal _iCReceiptItemContFeeTotalCost;
        protected decimal _iCReceiptItemContFeeContQty;
        #endregion

        #region Public properties
        public int ICReceiptItemContFeeID
        {
            get { return _iCReceiptItemContFeeID; }
            set
            {
                if (value != this._iCReceiptItemContFeeID)
                {
                    _iCReceiptItemContFeeID = value;
                    NotifyChanged("ICReceiptItemContFeeID");
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
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                    NotifyChanged("FK_ICReceiptID");
                }
            }
        }
        public int FK_GEContainerID
        {
            get { return _fK_GEContainerID; }
            set
            {
                if (value != this._fK_GEContainerID)
                {
                    _fK_GEContainerID = value;
                    NotifyChanged("FK_GEContainerID");
                }
            }
        }
        public int FK_GEUnitCostID
        {
            get { return _fK_GEUnitCostID; }
            set
            {
                if (value != this._fK_GEUnitCostID)
                {
                    _fK_GEUnitCostID = value;
                    NotifyChanged("FK_GEUnitCostID");
                }
            }
        }
        public decimal ICReceiptItemContFeeUnitCost
        {
            get { return _iCReceiptItemContFeeUnitCost; }
            set
            {
                if (value != this._iCReceiptItemContFeeUnitCost)
                {
                    _iCReceiptItemContFeeUnitCost = value;
                    NotifyChanged("ICReceiptItemContFeeUnitCost");
                }
            }
        }
        public decimal ICReceiptItemContFeeTotalCost
        {
            get { return _iCReceiptItemContFeeTotalCost; }
            set
            {
                if (value != this._iCReceiptItemContFeeTotalCost)
                {
                    _iCReceiptItemContFeeTotalCost = value;
                    NotifyChanged("ICReceiptItemContFeeTotalCost");
                }
            }
        }
        public decimal ICReceiptItemContFeeContQty
        {
            get { return _iCReceiptItemContFeeContQty; }
            set
            {
                if (value != this._iCReceiptItemContFeeContQty)
                {
                    _iCReceiptItemContFeeContQty = value;
                    NotifyChanged("ICReceiptItemContFeeContQty");
                }
            }
        }
        #endregion
    }
    #endregion
}