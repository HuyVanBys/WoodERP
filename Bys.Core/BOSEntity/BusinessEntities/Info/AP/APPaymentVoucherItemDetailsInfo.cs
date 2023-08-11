﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APPaymentVoucherItemDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPaymentVoucherItemDetailsInfo
    //Created Date:Monday, August 13, 2018
    //-----------------------------------------------------------

    public class APPaymentVoucherItemDetailsInfo : BusinessObject
    {
        public APPaymentVoucherItemDetailsInfo()
        {
        }
        #region Variables
        protected int _aPPaymentVoucherItemDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPaymentVoucherID;
        protected int _fK_APBillOfLadingID;
        #endregion

        #region Public properties
        public int APPaymentVoucherItemDetailID
        {
            get { return _aPPaymentVoucherItemDetailID; }
            set
            {
                if (value != this._aPPaymentVoucherItemDetailID)
                {
                    _aPPaymentVoucherItemDetailID = value;
                    NotifyChanged("APPaymentVoucherItemDetailID");
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
        public int FK_APPaymentVoucherID
        {
            get { return _fK_APPaymentVoucherID; }
            set
            {
                if (value != this._fK_APPaymentVoucherID)
                {
                    _fK_APPaymentVoucherID = value;
                    NotifyChanged("FK_APPaymentVoucherID");
                }
            }
        }
        public int FK_APBillOfLadingID
        {
            get { return _fK_APBillOfLadingID; }
            set
            {
                if (value != this._fK_APBillOfLadingID)
                {
                    _fK_APBillOfLadingID = value;
                    NotifyChanged("FK_APBillOfLadingID");
                }
            }
        }
        #endregion
    }
    #endregion
}