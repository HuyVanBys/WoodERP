﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACClearingDebts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACClearingDebtsInfo
    //Created Date:Tuesday, May 09, 2017
    //-----------------------------------------------------------

    public class ACClearingDebtsInfo : BusinessObject
    {
        public ACClearingDebtsInfo()
        {
        }

        #region Variables
        protected int _aCClearingDebtID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_GECurrencyID;
        protected int _fK_BRBranchID;
        protected int _fK_HREmployeeID;
        protected String _aCClearingDebtStatus = DefaultStatus;
        protected String _aCClearingDebtNo = String.Empty;
        protected String _aCClearingDebtDesc = String.Empty;
        protected DateTime _aCClearingDebtDate = DateTime.MaxValue;
        protected String _aCClearingDebtTypeCombo = String.Empty;
        protected decimal _aCClearingDebtExchangeRate;
        protected String _aCClearingDebtComment = String.Empty;
        protected int _fK_ACObjectID;
        protected String _aCObjectType = String.Empty;
        protected int _fK_ACObjectID2;
        protected String _aCObjectType2 = String.Empty;
        protected String _sTToolbarActionName = String.Empty;
        protected String _aCClearingDebtPostedStatus = DefaultStatus;
        protected decimal _aCClearingDebtAmountClearing;
        #endregion

        #region Public properties
        public int ACClearingDebtID
        {
            get { return _aCClearingDebtID; }
            set
            {
                if (value != this._aCClearingDebtID)
                {
                    _aCClearingDebtID = value;
                    NotifyChanged("ACClearingDebtID");
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
        public String ACClearingDebtStatus
        {
            get { return _aCClearingDebtStatus; }
            set
            {
                if (value != this._aCClearingDebtStatus)
                {
                    _aCClearingDebtStatus = value;
                    NotifyChanged("ACClearingDebtStatus");
                }
            }
        }
        public String ACClearingDebtNo
        {
            get { return _aCClearingDebtNo; }
            set
            {
                if (value != this._aCClearingDebtNo)
                {
                    _aCClearingDebtNo = value;
                    NotifyChanged("ACClearingDebtNo");
                }
            }
        }
        public String ACClearingDebtDesc
        {
            get { return _aCClearingDebtDesc; }
            set
            {
                if (value != this._aCClearingDebtDesc)
                {
                    _aCClearingDebtDesc = value;
                    NotifyChanged("ACClearingDebtDesc");
                }
            }
        }
        public DateTime ACClearingDebtDate
        {
            get { return _aCClearingDebtDate; }
            set
            {
                if (value != this._aCClearingDebtDate)
                {
                    _aCClearingDebtDate = value;
                    NotifyChanged("ACClearingDebtDate");
                }
            }
        }
        public String ACClearingDebtTypeCombo
        {
            get { return _aCClearingDebtTypeCombo; }
            set
            {
                if (value != this._aCClearingDebtTypeCombo)
                {
                    _aCClearingDebtTypeCombo = value;
                    NotifyChanged("ACClearingDebtTypeCombo");
                }
            }
        }
        public decimal ACClearingDebtExchangeRate
        {
            get { return _aCClearingDebtExchangeRate; }
            set
            {
                if (value != this._aCClearingDebtExchangeRate)
                {
                    _aCClearingDebtExchangeRate = value;
                    NotifyChanged("ACClearingDebtExchangeRate");
                }
            }
        }
        public String ACClearingDebtComment
        {
            get { return _aCClearingDebtComment; }
            set
            {
                if (value != this._aCClearingDebtComment)
                {
                    _aCClearingDebtComment = value;
                    NotifyChanged("ACClearingDebtComment");
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
        public String ACObjectType
        {
            get { return _aCObjectType; }
            set
            {
                if (value != this._aCObjectType)
                {
                    _aCObjectType = value;
                    NotifyChanged("ACObjectType");
                }
            }
        }
        public int FK_ACObjectID2
        {
            get { return _fK_ACObjectID2; }
            set
            {
                if (value != this._fK_ACObjectID2)
                {
                    _fK_ACObjectID2 = value;
                    NotifyChanged("FK_ACObjectID2");
                }
            }
        }
        public String ACObjectType2
        {
            get { return _aCObjectType2; }
            set
            {
                if (value != this._aCObjectType2)
                {
                    _aCObjectType2 = value;
                    NotifyChanged("ACObjectType2");
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
        public String ACClearingDebtPostedStatus
        {
            get { return _aCClearingDebtPostedStatus; }
            set
            {
                if (value != this._aCClearingDebtPostedStatus)
                {
                    _aCClearingDebtPostedStatus = value;
                    NotifyChanged("ACClearingDebtPostedStatus");
                }
            }
        }
        public decimal ACClearingDebtAmountClearing
        {
            get { return _aCClearingDebtAmountClearing; }
            set
            {
                if (value != this._aCClearingDebtAmountClearing)
                {
                    _aCClearingDebtAmountClearing = value;
                    NotifyChanged("ACClearingDebtAmountClearing");
                }
            }
        }
        #endregion

        #region Extra properties
        public DateTime ClearingDebtDateTo { get; set; }
        public DateTime ClearingDebtDateFrom { get; set; }
        public byte[] ACClearingDebtEmployeePicture { get; set; }
        public string ACObjectAccessKey { get; set; }
        public string ACObjectAccessKey2 { get; set; }
        public string ACObjectName { get; set; }
        #endregion
    }
    #endregion
}