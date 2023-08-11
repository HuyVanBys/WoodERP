﻿using BOSLib;
using System;
using System.Collections.Generic;
namespace BOSERP
{
    #region ACAssetReceipts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAssetReceiptsInfo
    //Created Date:04 May 2012
    //-----------------------------------------------------------

    public class ACAssetReceiptsInfo : BusinessObject
    {
        public ACAssetReceiptsInfo()
        {
            IsTransferred = false;
        }

        #region Variables
        protected int _aCAssetReceiptID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_APSupplierID;
        protected int _fK_GECurrencyID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _aCAssetReceiptNo = String.Empty;
        protected String _aCAssetReceiptDesc = String.Empty;
        protected DateTime _aCAssetReceiptDate = DateTime.MaxValue;
        protected String _aCAssetReceiptType = String.Empty;
        protected String _aCAssetReceiptStatus = DefaultStatus;
        protected decimal _aCAssetReceiptExchangeRate;
        protected decimal _aCAssetReceiptDiscountPercent;
        protected decimal _aCAssetReceiptDiscountAmount;
        protected decimal _aCAssetReceiptTaxPercent;
        protected decimal _aCAssetReceiptTaxAmount;
        protected decimal _aCAssetReceiptShippingFee;
        protected decimal _aCAssetReceiptExtraFee;
        protected decimal _aCAssetReceiptSubTotalCost;
        protected decimal _aCAssetReceiptTotalCost;
        protected String _aCAssetReceiptInvoiceNo = String.Empty;
        protected DateTime _aCAssetReceiptInvoiceDate = DateTime.MaxValue;
        protected bool _isTransferred = true;
        protected DateTime _aCAssetReceiptTransferredDate = DateTime.MaxValue;
        protected String _aPInputVATInvoiceNoCombo = String.Empty;
        protected String _aPInputVATDocumentType = String.Empty;
        protected String _aCAssetReceiptFormNo = String.Empty;
        protected String _aCAssetReceiptSymbol = String.Empty;
        protected String _aCAssetReceiptObjectTaxNumber = String.Empty;
        protected String _aCAssetReceiptSupplierTaxNumber = String.Empty;
        protected String _aCAssetReceiptSupplierContactAddress = String.Empty;
        protected DateTime _aCAssetReceiptPaymentTermDate = DateTime.MaxValue;
        protected String _sTToolbarActionName = String.Empty;
        protected int _fK_ACAccountPurchaseID;
        protected String _aCAssetReceiptPostedStatus = DefaultStatus;
        protected int _fK_APPurchaseContractID;
        protected String _aCAssetReceiptVATFormNo = String.Empty;
        protected String _aCAssetReceiptVATInvoiceNo = String.Empty;
        protected int _fK_ACEInvoiceTypeID;
        #endregion

        #region Public properties
        public int ACAssetReceiptID
        {
            get { return _aCAssetReceiptID; }
            set
            {
                if (value != this._aCAssetReceiptID)
                {
                    _aCAssetReceiptID = value;
                    NotifyChanged("ACAssetReceiptID");
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
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
                }
            }
        }
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
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
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        public String ACAssetReceiptNo
        {
            get { return _aCAssetReceiptNo; }
            set
            {
                if (value != this._aCAssetReceiptNo)
                {
                    _aCAssetReceiptNo = value;
                    NotifyChanged("ACAssetReceiptNo");
                }
            }
        }
        public String ACAssetReceiptDesc
        {
            get { return _aCAssetReceiptDesc; }
            set
            {
                if (value != this._aCAssetReceiptDesc)
                {
                    _aCAssetReceiptDesc = value;
                    NotifyChanged("ACAssetReceiptDesc");
                }
            }
        }
        public DateTime ACAssetReceiptDate
        {
            get { return _aCAssetReceiptDate; }
            set
            {
                if (value != this._aCAssetReceiptDate)
                {
                    _aCAssetReceiptDate = value;
                    NotifyChanged("ACAssetReceiptDate");
                }
            }
        }
        public String ACAssetReceiptType
        {
            get { return _aCAssetReceiptType; }
            set
            {
                if (value != this._aCAssetReceiptType)
                {
                    _aCAssetReceiptType = value;
                    NotifyChanged("ACAssetReceiptType");
                }
            }
        }
        public String ACAssetReceiptStatus
        {
            get { return _aCAssetReceiptStatus; }
            set
            {
                if (value != this._aCAssetReceiptStatus)
                {
                    _aCAssetReceiptStatus = value;
                    NotifyChanged("ACAssetReceiptStatus");
                }
            }
        }
        public decimal ACAssetReceiptExchangeRate
        {
            get { return _aCAssetReceiptExchangeRate; }
            set
            {
                if (value != this._aCAssetReceiptExchangeRate)
                {
                    _aCAssetReceiptExchangeRate = value;
                    NotifyChanged("ACAssetReceiptExchangeRate");
                }
            }
        }
        public decimal ACAssetReceiptDiscountPercent
        {
            get { return _aCAssetReceiptDiscountPercent; }
            set
            {
                if (value != this._aCAssetReceiptDiscountPercent)
                {
                    _aCAssetReceiptDiscountPercent = value;
                    NotifyChanged("ACAssetReceiptDiscountPercent");
                }
            }
        }
        public decimal ACAssetReceiptDiscountAmount
        {
            get { return _aCAssetReceiptDiscountAmount; }
            set
            {
                if (value != this._aCAssetReceiptDiscountAmount)
                {
                    _aCAssetReceiptDiscountAmount = value;
                    NotifyChanged("ACAssetReceiptDiscountAmount");
                }
            }
        }
        public decimal ACAssetReceiptTaxPercent
        {
            get { return _aCAssetReceiptTaxPercent; }
            set
            {
                if (value != this._aCAssetReceiptTaxPercent)
                {
                    _aCAssetReceiptTaxPercent = value;
                    NotifyChanged("ACAssetReceiptTaxPercent");
                }
            }
        }
        public decimal ACAssetReceiptTaxAmount
        {
            get { return _aCAssetReceiptTaxAmount; }
            set
            {
                if (value != this._aCAssetReceiptTaxAmount)
                {
                    _aCAssetReceiptTaxAmount = value;
                    NotifyChanged("ACAssetReceiptTaxAmount");
                }
            }
        }
        public decimal ACAssetReceiptShippingFee
        {
            get { return _aCAssetReceiptShippingFee; }
            set
            {
                if (value != this._aCAssetReceiptShippingFee)
                {
                    _aCAssetReceiptShippingFee = value;
                    NotifyChanged("ACAssetReceiptShippingFee");
                }
            }
        }
        public decimal ACAssetReceiptExtraFee
        {
            get { return _aCAssetReceiptExtraFee; }
            set
            {
                if (value != this._aCAssetReceiptExtraFee)
                {
                    _aCAssetReceiptExtraFee = value;
                    NotifyChanged("ACAssetReceiptExtraFee");
                }
            }
        }
        public decimal ACAssetReceiptSubTotalCost
        {
            get { return _aCAssetReceiptSubTotalCost; }
            set
            {
                if (value != this._aCAssetReceiptSubTotalCost)
                {
                    _aCAssetReceiptSubTotalCost = value;
                    NotifyChanged("ACAssetReceiptSubTotalCost");
                }
            }
        }
        public decimal ACAssetReceiptTotalCost
        {
            get { return _aCAssetReceiptTotalCost; }
            set
            {
                if (value != this._aCAssetReceiptTotalCost)
                {
                    _aCAssetReceiptTotalCost = value;
                    NotifyChanged("ACAssetReceiptTotalCost");
                }
            }
        }
        public String ACAssetReceiptInvoiceNo
        {
            get { return _aCAssetReceiptInvoiceNo; }
            set
            {
                if (value != this._aCAssetReceiptInvoiceNo)
                {
                    _aCAssetReceiptInvoiceNo = value;
                    NotifyChanged("ACAssetReceiptInvoiceNo");
                }
            }
        }
        public DateTime ACAssetReceiptInvoiceDate
        {
            get { return _aCAssetReceiptInvoiceDate; }
            set
            {
                if (value != this._aCAssetReceiptInvoiceDate)
                {
                    _aCAssetReceiptInvoiceDate = value;
                    NotifyChanged("ACAssetReceiptInvoiceDate");
                }
            }
        }
        public bool IsTransferred
        {
            get { return _isTransferred; }
            set
            {
                if (value != this._isTransferred)
                {
                    _isTransferred = value;
                    NotifyChanged("IsTransferred");
                }
            }
        }
        public DateTime ACAssetReceiptTransferredDate
        {
            get { return _aCAssetReceiptTransferredDate; }
            set
            {
                if (value != this._aCAssetReceiptTransferredDate)
                {
                    _aCAssetReceiptTransferredDate = value;
                    NotifyChanged("ACAssetReceiptTransferredDate");
                }
            }
        }
        public String APInputVATInvoiceNoCombo
        {
            get { return _aPInputVATInvoiceNoCombo; }
            set
            {
                if (value != this._aPInputVATInvoiceNoCombo)
                {
                    _aPInputVATInvoiceNoCombo = value;
                    NotifyChanged("APInputVATInvoiceNoCombo");
                }
            }
        }
        public String APInputVATDocumentType
        {
            get { return _aPInputVATDocumentType; }
            set
            {
                if (value != this._aPInputVATDocumentType)
                {
                    _aPInputVATDocumentType = value;
                    NotifyChanged("APInputVATDocumentType");
                }
            }
        }
        public String ACAssetReceiptFormNo
        {
            get { return _aCAssetReceiptFormNo; }
            set
            {
                if (value != this._aCAssetReceiptFormNo)
                {
                    _aCAssetReceiptFormNo = value;
                    NotifyChanged("ACAssetReceiptFormNo");
                }
            }
        }
        public String ACAssetReceiptSymbol
        {
            get { return _aCAssetReceiptSymbol; }
            set
            {
                if (value != this._aCAssetReceiptSymbol)
                {
                    _aCAssetReceiptSymbol = value;
                    NotifyChanged("ACAssetReceiptSymbol");
                }
            }
        }
        public String ACAssetReceiptObjectTaxNumber
        {
            get { return _aCAssetReceiptObjectTaxNumber; }
            set
            {
                if (value != this._aCAssetReceiptObjectTaxNumber)
                {
                    _aCAssetReceiptObjectTaxNumber = value;
                    NotifyChanged("ACAssetReceiptObjectTaxNumber");
                }
            }
        }
        public String ACAssetReceiptSupplierTaxNumber
        {
            get { return _aCAssetReceiptSupplierTaxNumber; }
            set
            {
                if (value != this._aCAssetReceiptSupplierTaxNumber)
                {
                    _aCAssetReceiptSupplierTaxNumber = value;
                    NotifyChanged("ACAssetReceiptSupplierTaxNumber");
                }
            }
        }
        public String ACAssetReceiptSupplierContactAddress
        {
            get { return _aCAssetReceiptSupplierContactAddress; }
            set
            {
                if (value != this._aCAssetReceiptSupplierContactAddress)
                {
                    _aCAssetReceiptSupplierContactAddress = value;
                    NotifyChanged("ACAssetReceiptSupplierContactAddress");
                }
            }
        }
        public DateTime ACAssetReceiptPaymentTermDate
        {
            get { return _aCAssetReceiptPaymentTermDate; }
            set
            {
                if (value != this._aCAssetReceiptPaymentTermDate)
                {
                    _aCAssetReceiptPaymentTermDate = value;
                    NotifyChanged("ACAssetReceiptPaymentTermDate");
                }
            }
        }
        public String STToolbarActionName
        {
            get { return _sTToolbarActionName; }
            set
            {
                if (value != this._sTToolbarActionName)
                {
                    _sTToolbarActionName = value;
                    NotifyChanged("STToolbarActionName");
                }
            }
        }
        public int FK_ACAccountPurchaseID
        {
            get { return _fK_ACAccountPurchaseID; }
            set
            {
                if (value != this._fK_ACAccountPurchaseID)
                {
                    _fK_ACAccountPurchaseID = value;
                    NotifyChanged("FK_ACAccountPurchaseID");
                }
            }
        }
        public String ACAssetReceiptPostedStatus
        {
            get { return _aCAssetReceiptPostedStatus; }
            set
            {
                if (value != this._aCAssetReceiptPostedStatus)
                {
                    _aCAssetReceiptPostedStatus = value;
                    NotifyChanged("ACAssetReceiptPostedStatus");
                }
            }
        }
        public int FK_APPurchaseContractID
        {
            get { return _fK_APPurchaseContractID; }
            set
            {
                if (value != this._fK_APPurchaseContractID)
                {
                    _fK_APPurchaseContractID = value;
                    NotifyChanged("FK_APPurchaseContractID");
                }
            }
        }
        public String ACAssetReceiptVATFormNo
        {
            get { return _aCAssetReceiptVATFormNo; }
            set
            {
                if (value != this._aCAssetReceiptVATFormNo)
                {
                    _aCAssetReceiptVATFormNo = value;
                    NotifyChanged("ACAssetReceiptVATFormNo");
                }
            }
        }
        public String ACAssetReceiptVATInvoiceNo
        {
            get { return _aCAssetReceiptVATInvoiceNo; }
            set
            {
                if (value != this._aCAssetReceiptVATInvoiceNo)
                {
                    _aCAssetReceiptVATInvoiceNo = value;
                    NotifyChanged("ACAssetReceiptVATInvoiceNo");
                }
            }
        }
        public int FK_ACEInvoiceTypeID
        {
            get { return _fK_ACEInvoiceTypeID; }
            set
            {
                if (value != this._fK_ACEInvoiceTypeID)
                {
                    _fK_ACEInvoiceTypeID = value;
                    NotifyChanged("FK_ACEInvoiceTypeID");
                }
            }
        }

        #endregion


        #region Extra Properties
        public byte[] ACAssetReceiptEmployeePicture { get; set; }

        /// <summary>
        /// Gets or sets the item list of the asset receipt
        /// </summary>
        public List<ACAssetReceiptItemsInfo> AssetReceiptItems { get; set; }

        public DateTime AssetReceiptDateFrom { get; set; }
        public DateTime AssetReceiptDateTo { get; set; }

        #endregion
    }
    #endregion
}