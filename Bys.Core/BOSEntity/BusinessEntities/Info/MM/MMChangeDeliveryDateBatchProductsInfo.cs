﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMChangeDeliveryDateBatchProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMChangeDeliveryDateBatchProductsInfo
    //Created Date:Friday, January 04, 2019
    //-----------------------------------------------------------

    public class MMChangeDeliveryDateBatchProductsInfo : BusinessObject
    {
        public MMChangeDeliveryDateBatchProductsInfo()
        {
        }
        #region Variables
        protected int _mMChangeDeliveryDateBatchProductID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _mMChangeDeliveryDateBatchProductNo = String.Empty;
        protected DateTime _mMChangeDeliveryDateBatchProductDate = DateTime.MaxValue;
        protected String _mMChangeDeliveryDateBatchProductStatus = DefaultStatus;
        protected int _fK_HREmployeeID;
        protected int _fK_MMBatchProductID;
        protected int _fK_BRBranchID;
        protected int _fK_ARCustomerID;
        protected String _mMChangeDeliveryDateBatchProductDesc = String.Empty;
        #endregion

        #region Public properties
        public int MMChangeDeliveryDateBatchProductID
        {
            get { return _mMChangeDeliveryDateBatchProductID; }
            set
            {
                if (value != this._mMChangeDeliveryDateBatchProductID)
                {
                    _mMChangeDeliveryDateBatchProductID = value;
                    NotifyChanged("MMChangeDeliveryDateBatchProductID");
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
        public String MMChangeDeliveryDateBatchProductNo
        {
            get { return _mMChangeDeliveryDateBatchProductNo; }
            set
            {
                if (value != this._mMChangeDeliveryDateBatchProductNo)
                {
                    _mMChangeDeliveryDateBatchProductNo = value;
                    NotifyChanged("MMChangeDeliveryDateBatchProductNo");
                }
            }
        }
        public DateTime MMChangeDeliveryDateBatchProductDate
        {
            get { return _mMChangeDeliveryDateBatchProductDate; }
            set
            {
                if (value != this._mMChangeDeliveryDateBatchProductDate)
                {
                    _mMChangeDeliveryDateBatchProductDate = value;
                    NotifyChanged("MMChangeDeliveryDateBatchProductDate");
                }
            }
        }
        public String MMChangeDeliveryDateBatchProductStatus
        {
            get { return _mMChangeDeliveryDateBatchProductStatus; }
            set
            {
                if (value != this._mMChangeDeliveryDateBatchProductStatus)
                {
                    _mMChangeDeliveryDateBatchProductStatus = value;
                    NotifyChanged("MMChangeDeliveryDateBatchProductStatus");
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
        public int FK_MMBatchProductID
        {
            get { return _fK_MMBatchProductID; }
            set
            {
                if (value != this._fK_MMBatchProductID)
                {
                    _fK_MMBatchProductID = value;
                    NotifyChanged("FK_MMBatchProductID");
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public String MMChangeDeliveryDateBatchProductDesc
        {
            get { return _mMChangeDeliveryDateBatchProductDesc; }
            set
            {
                if (value != this._mMChangeDeliveryDateBatchProductDesc)
                {
                    _mMChangeDeliveryDateBatchProductDesc = value;
                    NotifyChanged("MMChangeDeliveryDateBatchProductDesc");
                }
            }
        }
        #endregion

        #region Extra properties
        public DateTime MMChangeDeliveryDateBatchProductDateFrom { get; set; }
        public DateTime MMChangeDeliveryDateBatchProductDateTo { get; set; }
        #endregion
    }
    #endregion
}