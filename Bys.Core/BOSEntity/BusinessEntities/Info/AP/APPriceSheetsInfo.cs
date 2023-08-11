﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APPriceSheets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPriceSheetsInfo
    //Created Date:Friday, May 10, 2019
    //-----------------------------------------------------------

    public class APPriceSheetsInfo : BusinessObject
    {
        public APPriceSheetsInfo()
        {
        }
        #region Variables
        protected int _aPPriceSheetID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_BRBranchID;
        protected int _fK_HREmployeeID;
        protected String _aPPriceSheetNo = String.Empty;
        protected String _aPPriceSheetName = String.Empty;
        protected String _aPPriceSheetDesc = String.Empty;
        protected String _aPPriceSheetStatus = DefaultStatus;
        protected DateTime _aPPriceSheetDate = DateTime.MaxValue;
        protected DateTime _aPPriceSheetBeginDate = DateTime.MaxValue;
        protected DateTime _aPPriceSheetEndDate = DateTime.MaxValue;
        protected String _aPPriceSheetType = String.Empty;
        protected int _fK_HRApprovedEmployeeID;
        protected int _fK_GECurrencyID;
        protected int _fK_ACObjectID;
        protected String _aPObjectType = String.Empty;
        #endregion

        #region Public properties
        public int APPriceSheetID
        {
            get { return _aPPriceSheetID; }
            set
            {
                if (value != this._aPPriceSheetID)
                {
                    _aPPriceSheetID = value;
                    NotifyChanged("APPriceSheetID");
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
        public String APPriceSheetNo
        {
            get { return _aPPriceSheetNo; }
            set
            {
                if (value != this._aPPriceSheetNo)
                {
                    _aPPriceSheetNo = value;
                    NotifyChanged("APPriceSheetNo");
                }
            }
        }
        public String APPriceSheetName
        {
            get { return _aPPriceSheetName; }
            set
            {
                if (value != this._aPPriceSheetName)
                {
                    _aPPriceSheetName = value;
                    NotifyChanged("APPriceSheetName");
                }
            }
        }
        public String APPriceSheetDesc
        {
            get { return _aPPriceSheetDesc; }
            set
            {
                if (value != this._aPPriceSheetDesc)
                {
                    _aPPriceSheetDesc = value;
                    NotifyChanged("APPriceSheetDesc");
                }
            }
        }
        public String APPriceSheetStatus
        {
            get { return _aPPriceSheetStatus; }
            set
            {
                if (value != this._aPPriceSheetStatus)
                {
                    _aPPriceSheetStatus = value;
                    NotifyChanged("APPriceSheetStatus");
                }
            }
        }
        public DateTime APPriceSheetDate
        {
            get { return _aPPriceSheetDate; }
            set
            {
                if (value != this._aPPriceSheetDate)
                {
                    _aPPriceSheetDate = value;
                    NotifyChanged("APPriceSheetDate");
                }
            }
        }
        public DateTime APPriceSheetBeginDate
        {
            get { return _aPPriceSheetBeginDate; }
            set
            {
                if (value != this._aPPriceSheetBeginDate)
                {
                    _aPPriceSheetBeginDate = value;
                    NotifyChanged("APPriceSheetBeginDate");
                }
            }
        }
        public DateTime APPriceSheetEndDate
        {
            get { return _aPPriceSheetEndDate; }
            set
            {
                if (value != this._aPPriceSheetEndDate)
                {
                    _aPPriceSheetEndDate = value;
                    NotifyChanged("APPriceSheetEndDate");
                }
            }
        }
        public String APPriceSheetType
        {
            get { return _aPPriceSheetType; }
            set
            {
                if (value != this._aPPriceSheetType)
                {
                    _aPPriceSheetType = value;
                    NotifyChanged("APPriceSheetType");
                }
            }
        }
        public int FK_HRApprovedEmployeeID
        {
            get { return _fK_HRApprovedEmployeeID; }
            set
            {
                if (value != this._fK_HRApprovedEmployeeID)
                {
                    _fK_HRApprovedEmployeeID = value;
                    NotifyChanged("FK_HRApprovedEmployeeID");
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
        public int FK_ACObjectID
        {
            get { return _fK_ACObjectID; }
            set
            {
                if (value != this._fK_ACObjectID)
                {
                    _fK_ACObjectID = value;
                    NotifyChanged("FK_ACObjectID");
                }
            }
        }
        public String APObjectType
        {
            get { return _aPObjectType; }
            set
            {
                if (value != this._aPObjectType)
                {
                    _aPObjectType = value;
                    NotifyChanged("APObjectType");
                }
            }
        }

        #endregion
        #region Extra Properties
        public byte[] APPriceSheetEmployeePicture { get; set; }

        public String ACObjectAccessKey { get; set; }
        public DateTime APPriceSheetDateFrom { get; set; }
        public DateTime APPriceSheetDateTo { get; set; }
        #endregion
    }
    #endregion
}