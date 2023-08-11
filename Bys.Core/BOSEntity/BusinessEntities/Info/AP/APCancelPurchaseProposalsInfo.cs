﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APCancelPurchaseProposals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APCancelPurchaseProposalsInfo
    //Created Date:Friday, July 15, 2016
    //-----------------------------------------------------------

    public class APCancelPurchaseProposalsInfo : BusinessObject
    {
        public APCancelPurchaseProposalsInfo()
        {
        }
        #region Variables
        protected int _aPCancelPurchaseProposalID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMPurchasePlanID;
        protected int _fK_APProposalID;
        protected String _aPCancelPurchaseProposalNo = String.Empty;
        protected String _aPCancelPurchaseProposalName = String.Empty;
        protected String _aPCancelPurchaseProposalDesc = String.Empty;
        protected String _aPCancelPurchaseProposalComment = String.Empty;
        protected DateTime _aPCancelPurchaseProposalDate = DateTime.MaxValue;
        protected String _aPCancelPurchaseProposalType = String.Empty;
        protected String _aPCancelPurchaseProposalStatus = DefaultStatus;
        protected decimal _aPCancelPurchaseProposalTaxPercent;
        protected decimal _aPCancelPurchaseProposalTaxAmount;
        protected decimal _aPCancelPurchaseProposalSubTotalCost;
        protected decimal _aPCancelPurchaseProposalTotalCost;
        protected String _aPCancelPurchaseProposalAPTypeCombo = String.Empty;
        protected String _aPCancelPurchaseProposalReference = String.Empty;
        protected String _aPCancelPurchaseProposalPONo = String.Empty;
        protected String _aPCancelPurchaseProposalPurchasePlanType = String.Empty;
        protected bool _isTransferred = true;
        protected DateTime _aPCancelPurchaseProposalTransferredDate = DateTime.MaxValue;
        protected string _aPCancelPurchaseProposalReasonType = string.Empty;
        #endregion

        #region Public properties
        public int APCancelPurchaseProposalID
        {
            get { return _aPCancelPurchaseProposalID; }
            set
            {
                if (value != this._aPCancelPurchaseProposalID)
                {
                    _aPCancelPurchaseProposalID = value;
                    NotifyChanged("APCancelPurchaseProposalID");
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
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public int FK_HRDepartmentRoomID
        {
            get { return _fK_HRDepartmentRoomID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomID)
                {
                    _fK_HRDepartmentRoomID = value;
                    NotifyChanged("FK_HRDepartmentRoomID");
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
        public int FK_MMPurchasePlanID
        {
            get { return _fK_MMPurchasePlanID; }
            set
            {
                if (value != this._fK_MMPurchasePlanID)
                {
                    _fK_MMPurchasePlanID = value;
                    NotifyChanged("FK_MMPurchasePlanID");
                }
            }
        }
        public int FK_APProposalID
        {
            get { return _fK_APProposalID; }
            set
            {
                if (value != this._fK_APProposalID)
                {
                    _fK_APProposalID = value;
                    NotifyChanged("FK_APProposalID");
                }
            }
        }
        public String APCancelPurchaseProposalNo
        {
            get { return _aPCancelPurchaseProposalNo; }
            set
            {
                if (value != this._aPCancelPurchaseProposalNo)
                {
                    _aPCancelPurchaseProposalNo = value;
                    NotifyChanged("APCancelPurchaseProposalNo");
                }
            }
        }
        public String APCancelPurchaseProposalName
        {
            get { return _aPCancelPurchaseProposalName; }
            set
            {
                if (value != this._aPCancelPurchaseProposalName)
                {
                    _aPCancelPurchaseProposalName = value;
                    NotifyChanged("APCancelPurchaseProposalName");
                }
            }
        }
        public String APCancelPurchaseProposalDesc
        {
            get { return _aPCancelPurchaseProposalDesc; }
            set
            {
                if (value != this._aPCancelPurchaseProposalDesc)
                {
                    _aPCancelPurchaseProposalDesc = value;
                    NotifyChanged("APCancelPurchaseProposalDesc");
                }
            }
        }
        public String APCancelPurchaseProposalComment
        {
            get { return _aPCancelPurchaseProposalComment; }
            set
            {
                if (value != this._aPCancelPurchaseProposalComment)
                {
                    _aPCancelPurchaseProposalComment = value;
                    NotifyChanged("APCancelPurchaseProposalComment");
                }
            }
        }
        public DateTime APCancelPurchaseProposalDate
        {
            get { return _aPCancelPurchaseProposalDate; }
            set
            {
                if (value != this._aPCancelPurchaseProposalDate)
                {
                    _aPCancelPurchaseProposalDate = value;
                    NotifyChanged("APCancelPurchaseProposalDate");
                }
            }
        }
        public String APCancelPurchaseProposalType
        {
            get { return _aPCancelPurchaseProposalType; }
            set
            {
                if (value != this._aPCancelPurchaseProposalType)
                {
                    _aPCancelPurchaseProposalType = value;
                    NotifyChanged("APCancelPurchaseProposalType");
                }
            }
        }
        public String APCancelPurchaseProposalStatus
        {
            get { return _aPCancelPurchaseProposalStatus; }
            set
            {
                if (value != this._aPCancelPurchaseProposalStatus)
                {
                    _aPCancelPurchaseProposalStatus = value;
                    NotifyChanged("APCancelPurchaseProposalStatus");
                }
            }
        }
        public decimal APCancelPurchaseProposalTaxPercent
        {
            get { return _aPCancelPurchaseProposalTaxPercent; }
            set
            {
                if (value != this._aPCancelPurchaseProposalTaxPercent)
                {
                    _aPCancelPurchaseProposalTaxPercent = value;
                    NotifyChanged("APCancelPurchaseProposalTaxPercent");
                }
            }
        }
        public decimal APCancelPurchaseProposalTaxAmount
        {
            get { return _aPCancelPurchaseProposalTaxAmount; }
            set
            {
                if (value != this._aPCancelPurchaseProposalTaxAmount)
                {
                    _aPCancelPurchaseProposalTaxAmount = value;
                    NotifyChanged("APCancelPurchaseProposalTaxAmount");
                }
            }
        }
        public decimal APCancelPurchaseProposalSubTotalCost
        {
            get { return _aPCancelPurchaseProposalSubTotalCost; }
            set
            {
                if (value != this._aPCancelPurchaseProposalSubTotalCost)
                {
                    _aPCancelPurchaseProposalSubTotalCost = value;
                    NotifyChanged("APCancelPurchaseProposalSubTotalCost");
                }
            }
        }
        public decimal APCancelPurchaseProposalTotalCost
        {
            get { return _aPCancelPurchaseProposalTotalCost; }
            set
            {
                if (value != this._aPCancelPurchaseProposalTotalCost)
                {
                    _aPCancelPurchaseProposalTotalCost = value;
                    NotifyChanged("APCancelPurchaseProposalTotalCost");
                }
            }
        }
        public String APCancelPurchaseProposalAPTypeCombo
        {
            get { return _aPCancelPurchaseProposalAPTypeCombo; }
            set
            {
                if (value != this._aPCancelPurchaseProposalAPTypeCombo)
                {
                    _aPCancelPurchaseProposalAPTypeCombo = value;
                    NotifyChanged("APCancelPurchaseProposalAPTypeCombo");
                }
            }
        }
        public String APCancelPurchaseProposalReference
        {
            get { return _aPCancelPurchaseProposalReference; }
            set
            {
                if (value != this._aPCancelPurchaseProposalReference)
                {
                    _aPCancelPurchaseProposalReference = value;
                    NotifyChanged("APCancelPurchaseProposalReference");
                }
            }
        }
        public String APCancelPurchaseProposalPONo
        {
            get { return _aPCancelPurchaseProposalPONo; }
            set
            {
                if (value != this._aPCancelPurchaseProposalPONo)
                {
                    _aPCancelPurchaseProposalPONo = value;
                    NotifyChanged("APCancelPurchaseProposalPONo");
                }
            }
        }
        public String APCancelPurchaseProposalPurchasePlanType
        {
            get { return _aPCancelPurchaseProposalPurchasePlanType; }
            set
            {
                if (value != this._aPCancelPurchaseProposalPurchasePlanType)
                {
                    _aPCancelPurchaseProposalPurchasePlanType = value;
                    NotifyChanged("APCancelPurchaseProposalPurchasePlanType");
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
        public DateTime APCancelPurchaseProposalTransferredDate
        {
            get { return _aPCancelPurchaseProposalTransferredDate; }
            set
            {
                if (value != this._aPCancelPurchaseProposalTransferredDate)
                {
                    _aPCancelPurchaseProposalTransferredDate = value;
                    NotifyChanged("APCancelPurchaseProposalTransferredDate");
                }
            }
        }
        public string APCancelPurchaseProposalReasonType
        {
            get { return _aPCancelPurchaseProposalReasonType; }
            set
            {
                if (value != this._aPCancelPurchaseProposalReasonType)
                {
                    _aPCancelPurchaseProposalReasonType = value;
                    NotifyChanged("APCancelPurchaseProposalReasonType");
                }
            }
        }
        #endregion

        #region Extra Properties
        public byte[] APCancelPurchaseProposalEmployeePicture { get; set; }

        public DateTime CancelPurchaseProposalDateFrom { get; set; }

        public DateTime CancelPurchaseProposalDateTo { get; set; }
        public string MMBatchProductSOName { get; set; }
        #endregion
    }
    #endregion
}