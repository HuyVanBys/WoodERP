﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARPOSPaymentDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARPOSPaymentDetailsInfo
    //Created Date:Thứ Hai, Tháng Tư 8, 2019
    //-----------------------------------------------------------

    public class ARPOSPaymentDetailsInfo : BusinessObject
    {
        public ARPOSPaymentDetailsInfo()
        {
        }
        #region Variables
        protected int _aRPOSPaymentDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARCustomerPaymentID;
        protected int _fK_ACAccountID;
        protected int _fK_CSCompanyBankID;
        protected int _fK_CSCashFundID;
        protected String _aRPOSPaymentMethodCombo = String.Empty;
        protected decimal _aRPOSPaymentDetailAmount;
        protected String _aRPOSPaymentDetailInfo = String.Empty;
        protected decimal _aRPOSPaymentDetailSubAmount1;
        protected decimal _aRPOSPaymentDetailSubAmount2;
        protected decimal _aRPOSPaymentDetailSubAmount3;
        protected decimal _aRPOSPaymentDetailSubAmount4;
        protected decimal _aRPOSPaymentDetailSubAmount5;
        protected decimal _aRPOSPaymentDetailSubAmount6;
        protected decimal _aRPOSPaymentDetailSubAmount7;
        protected decimal _aRPOSPaymentDetailSubAmount8;
        protected decimal _aRPOSPaymentDetailSubAmount9;
        protected decimal _aRPOSPaymentDetailSubAmount10;
        protected decimal _aRPOSPaymentDetailSubAmount11;
        protected decimal _aRPOSPaymentDetailSubAmount12;
        protected decimal _aRPOSPaymentDetailSubAmount13;
        protected decimal _aRPOSPaymentDetailSubAmount14;
        protected decimal _aRPOSPaymentDetailSubAmount15;
        protected DateTime _aRPOSPaymentDetailDate;
        protected int _fK_ARInvoiceID;
        #endregion

        #region Public properties
        public int ARPOSPaymentDetailID
        {
            get { return _aRPOSPaymentDetailID; }
            set
            {
                if (value != this._aRPOSPaymentDetailID)
                {
                    _aRPOSPaymentDetailID = value;
                    NotifyChanged("ARPOSPaymentDetailID");
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
        public int FK_ARCustomerPaymentID
        {
            get { return _fK_ARCustomerPaymentID; }
            set
            {
                if (value != this._fK_ARCustomerPaymentID)
                {
                    _fK_ARCustomerPaymentID = value;
                    NotifyChanged("FK_ARCustomerPaymentID");
                }
            }
        }
        public int FK_ACAccountID
        {
            get { return _fK_ACAccountID; }
            set
            {
                if (value != this._fK_ACAccountID)
                {
                    _fK_ACAccountID = value;
                    NotifyChanged("FK_ACAccountID");
                }
            }
        }
        public int FK_CSCompanyBankID
        {
            get { return _fK_CSCompanyBankID; }
            set
            {
                if (value != this._fK_CSCompanyBankID)
                {
                    _fK_CSCompanyBankID = value;
                    NotifyChanged("FK_CSCompanyBankID");
                }
            }
        }
        public int FK_CSCashFundID
        {
            get { return _fK_CSCashFundID; }
            set
            {
                if (value != this._fK_CSCashFundID)
                {
                    _fK_CSCashFundID = value;
                    NotifyChanged("FK_CSCashFundID");
                }
            }
        }
        public String ARPOSPaymentMethodCombo
        {
            get { return _aRPOSPaymentMethodCombo; }
            set
            {
                if (value != this._aRPOSPaymentMethodCombo)
                {
                    _aRPOSPaymentMethodCombo = value;
                    NotifyChanged("ARPOSPaymentMethodCombo");
                }
            }
        }
        public decimal ARPOSPaymentDetailAmount
        {
            get { return _aRPOSPaymentDetailAmount; }
            set
            {
                if (value != this._aRPOSPaymentDetailAmount)
                {
                    _aRPOSPaymentDetailAmount = value;
                    NotifyChanged("ARPOSPaymentDetailAmount");
                }
            }
        }
        public String ARPOSPaymentDetailInfo
        {
            get { return _aRPOSPaymentDetailInfo; }
            set
            {
                if (value != this._aRPOSPaymentDetailInfo)
                {
                    _aRPOSPaymentDetailInfo = value;
                    NotifyChanged("ARPOSPaymentDetailInfo");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount1
        {
            get { return _aRPOSPaymentDetailSubAmount1; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount1)
                {
                    _aRPOSPaymentDetailSubAmount1 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount1");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount2
        {
            get { return _aRPOSPaymentDetailSubAmount2; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount2)
                {
                    _aRPOSPaymentDetailSubAmount2 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount2");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount3
        {
            get { return _aRPOSPaymentDetailSubAmount3; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount3)
                {
                    _aRPOSPaymentDetailSubAmount3 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount3");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount4
        {
            get { return _aRPOSPaymentDetailSubAmount4; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount4)
                {
                    _aRPOSPaymentDetailSubAmount4 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount4");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount5
        {
            get { return _aRPOSPaymentDetailSubAmount5; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount5)
                {
                    _aRPOSPaymentDetailSubAmount5 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount5");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount6
        {
            get { return _aRPOSPaymentDetailSubAmount6; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount6)
                {
                    _aRPOSPaymentDetailSubAmount6 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount6");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount7
        {
            get { return _aRPOSPaymentDetailSubAmount7; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount7)
                {
                    _aRPOSPaymentDetailSubAmount7 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount7");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount8
        {
            get { return _aRPOSPaymentDetailSubAmount8; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount8)
                {
                    _aRPOSPaymentDetailSubAmount8 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount8");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount9
        {
            get { return _aRPOSPaymentDetailSubAmount9; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount9)
                {
                    _aRPOSPaymentDetailSubAmount9 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount9");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount10
        {
            get { return _aRPOSPaymentDetailSubAmount10; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount10)
                {
                    _aRPOSPaymentDetailSubAmount10 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount10");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount11
        {
            get { return _aRPOSPaymentDetailSubAmount11; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount11)
                {
                    _aRPOSPaymentDetailSubAmount11 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount11");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount12
        {
            get { return _aRPOSPaymentDetailSubAmount12; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount12)
                {
                    _aRPOSPaymentDetailSubAmount12 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount12");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount13
        {
            get { return _aRPOSPaymentDetailSubAmount13; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount13)
                {
                    _aRPOSPaymentDetailSubAmount13 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount13");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount14
        {
            get { return _aRPOSPaymentDetailSubAmount14; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount14)
                {
                    _aRPOSPaymentDetailSubAmount14 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount14");
                }
            }
        }
        public decimal ARPOSPaymentDetailSubAmount15
        {
            get { return _aRPOSPaymentDetailSubAmount15; }
            set
            {
                if (value != this._aRPOSPaymentDetailSubAmount15)
                {
                    _aRPOSPaymentDetailSubAmount15 = value;
                    NotifyChanged("ARPOSPaymentDetailSubAmount15");
                }
            }
        }
        public int FK_ARInvoiceID
        {
            get { return _fK_ARInvoiceID; }
            set
            {
                if (value != this._fK_ARInvoiceID)
                {
                    _fK_ARInvoiceID = value;
                    NotifyChanged("FK_ARInvoiceID");
                }
            }
        }
        public DateTime ARPOSPaymentDetailDate
        {
            get { return _aRPOSPaymentDetailDate; }
            set
            {
                if (value != this._aRPOSPaymentDetailDate)
                {
                    _aRPOSPaymentDetailDate = value;
                    NotifyChanged("ARPOSPaymentDetailDate");
                }    
            }
        }
        #endregion

        #region Extra Properties
        public string ARPaymentMethodDisplayText { get; set; }
        public IBOSList<ARCustomerPaymentCurrencysInfo> PaymentCurrencys { get; set; }
        public string GECurrencyName { get; set; }
        public decimal ARPOSPaymentDetailExchangeRate { get; set; }
        #endregion
    }
    #endregion
}