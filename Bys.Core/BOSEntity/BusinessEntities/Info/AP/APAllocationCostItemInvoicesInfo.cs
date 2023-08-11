﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APAllocationCostItemInvoices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APAllocationCostItemInvoicesInfo
    //Created Date:Tuesday, July 31, 2018
    //-----------------------------------------------------------

    public class APAllocationCostItemInvoicesInfo : BusinessObject
    {
        public APAllocationCostItemInvoicesInfo()
        {
        }
        #region Variables
        protected int _aPAllocationCostItemInvoiceID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_APAllocationCostID;
        protected int _fK_APInvoiceInID;
        protected decimal _aPAllocationCostItemInvoiceProductQty;
        protected decimal _aPAllocationCostItemInvoiceTotalCost;
        protected decimal _aPAllocationCostItemInvoiceReceiptedQty;
        protected decimal _aPAllocationCostItemInvoiceReceiptedCost;
        protected int _fK_ACDocumentID;
        protected decimal _aPAllocationCostItemInvoiceDocumentAmount;
        protected decimal _aPAllocationCostItemInvoiceDocumentTotalInvoiceQty;
        protected decimal _aPAllocationCostItemInvoiceDocumentTotalInvoiceCost;
        protected decimal _aPAllocationCostItemInvoiceFeeAmount;
        #endregion

        #region Public properties
        public int APAllocationCostItemInvoiceID
        {
            get { return _aPAllocationCostItemInvoiceID; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceID)
                {
                    _aPAllocationCostItemInvoiceID = value;
                    NotifyChanged("APAllocationCostItemInvoiceID");
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
        public int FK_APAllocationCostID
        {
            get { return _fK_APAllocationCostID; }
            set
            {
                if (value != this._fK_APAllocationCostID)
                {
                    _fK_APAllocationCostID = value;
                    NotifyChanged("FK_APAllocationCostID");
                }
            }
        }
        public int FK_APInvoiceInID
        {
            get { return _fK_APInvoiceInID; }
            set
            {
                if (value != this._fK_APInvoiceInID)
                {
                    _fK_APInvoiceInID = value;
                    NotifyChanged("FK_APInvoiceInID");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceProductQty
        {
            get { return _aPAllocationCostItemInvoiceProductQty; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceProductQty)
                {
                    _aPAllocationCostItemInvoiceProductQty = value;
                    NotifyChanged("APAllocationCostItemInvoiceProductQty");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceTotalCost
        {
            get { return _aPAllocationCostItemInvoiceTotalCost; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceTotalCost)
                {
                    _aPAllocationCostItemInvoiceTotalCost = value;
                    NotifyChanged("APAllocationCostItemInvoiceTotalCost");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceReceiptedQty
        {
            get { return _aPAllocationCostItemInvoiceReceiptedQty; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceReceiptedQty)
                {
                    _aPAllocationCostItemInvoiceReceiptedQty = value;
                    NotifyChanged("APAllocationCostItemInvoiceReceiptedQty");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceReceiptedCost
        {
            get { return _aPAllocationCostItemInvoiceReceiptedCost; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceReceiptedCost)
                {
                    _aPAllocationCostItemInvoiceReceiptedCost = value;
                    NotifyChanged("APAllocationCostItemInvoiceReceiptedCost");
                }
            }
        }
        public int FK_ACDocumentID
        {
            get { return _fK_ACDocumentID; }
            set
            {
                if (value != this._fK_ACDocumentID)
                {
                    _fK_ACDocumentID = value;
                    NotifyChanged("FK_ACDocumentID");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceDocumentAmount
        {
            get { return _aPAllocationCostItemInvoiceDocumentAmount; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceDocumentAmount)
                {
                    _aPAllocationCostItemInvoiceDocumentAmount = value;
                    NotifyChanged("APAllocationCostItemInvoiceDocumentAmount");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceDocumentTotalInvoiceQty
        {
            get { return _aPAllocationCostItemInvoiceDocumentTotalInvoiceQty; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceDocumentTotalInvoiceQty)
                {
                    _aPAllocationCostItemInvoiceDocumentTotalInvoiceQty = value;
                    NotifyChanged("APAllocationCostItemInvoiceDocumentTotalInvoiceQty");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceDocumentTotalInvoiceCost
        {
            get { return _aPAllocationCostItemInvoiceDocumentTotalInvoiceCost; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceDocumentTotalInvoiceCost)
                {
                    _aPAllocationCostItemInvoiceDocumentTotalInvoiceCost = value;
                    NotifyChanged("APAllocationCostItemInvoiceDocumentTotalInvoiceCost");
                }
            }
        }
        public decimal APAllocationCostItemInvoiceFeeAmount
        {
            get { return _aPAllocationCostItemInvoiceFeeAmount; }
            set
            {
                if (value != this._aPAllocationCostItemInvoiceFeeAmount)
                {
                    _aPAllocationCostItemInvoiceFeeAmount = value;
                    NotifyChanged("APAllocationCostItemInvoiceFeeAmount");
                }
            }
        }
        #endregion
    }
    #endregion
}