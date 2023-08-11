﻿using BOSLib;
using System;
using System.Drawing;
namespace BOSERP
{
    #region MMOperations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMOperationsInfo
    //Created Date:Tuesday, November 03, 2015
    //-----------------------------------------------------------

    public class MMOperationsInfo : BOSTreeListObject
    {
        public MMOperationsInfo()
        {
        }

        public MMOperationsInfo(string operationNo, string operationName)
        {
            this.MMOperationName = operationName;
            this.MMOperationNo = operationNo;
        }

        public MMOperationsInfo(int operationID, string operationName)
        {
            MMOperationID = operationID;
            MMOperationName = operationName;
        }
        #region Variables
        protected int _mMOperationID;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _mMOperationParentID;
        protected String _mMOperationNo = String.Empty;
        protected String _mMOperationName = String.Empty;
        protected String _mMOperationDesc = String.Empty;
        protected bool _mMOperationActiveCheck = true;
        protected int _mMOperationOrder;
        protected bool _mMOperationCostCalculationCheck = false;
        protected bool _mMOperationInOutStockCheck = false;
        protected String _mMOperationGroup = String.Empty;
        protected int _fK_ACAccountID;
        protected int _fK_ACIngrogressAccountID;
        protected int _fK_ACCostAccountID;
        protected String _mMOperationType = String.Empty;
        protected bool _mMOperationCapacity = false;
        protected String _mMOperationAcronym = String.Empty;
        protected bool _mMOperationNeedQC = false;
        protected bool _mMOperationIsBeginOperation = false;
        protected bool _mMOperationSyncProductCheck = false;
        protected bool _mMOperationIsPlan = false;
        protected int _fK_MMOperationSynID;
        protected bool _mMOperationForParentSyncCheck = false;
        protected bool _mMOperationIsOutSourcing = false;
        protected int _fK_BRBranchID;
        protected bool _mMOperationIsEndProcess = false;
        #endregion

        #region Public properties
        public int MMOperationID
        {
            get { return _mMOperationID; }
            set
            {
                if (value != this._mMOperationID)
                {
                    _mMOperationID = value;
                    NotifyChanged("MMOperationID");
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
        public int MMOperationParentID
        {
            get { return _mMOperationParentID; }
            set
            {
                if (value != this._mMOperationParentID)
                {
                    _mMOperationParentID = value;
                    NotifyChanged("MMOperationParentID");
                }
            }
        }
        public String MMOperationNo
        {
            get { return _mMOperationNo; }
            set
            {
                if (value != this._mMOperationNo)
                {
                    _mMOperationNo = value;
                    NotifyChanged("MMOperationNo");
                }
            }
        }
        public String MMOperationName
        {
            get { return _mMOperationName; }
            set
            {
                if (value != this._mMOperationName)
                {
                    _mMOperationName = value;
                    NotifyChanged("MMOperationName");
                }
            }
        }
        public String MMOperationDesc
        {
            get { return _mMOperationDesc; }
            set
            {
                if (value != this._mMOperationDesc)
                {
                    _mMOperationDesc = value;
                    NotifyChanged("MMOperationDesc");
                }
            }
        }
        public bool MMOperationActiveCheck
        {
            get { return _mMOperationActiveCheck; }
            set
            {
                if (value != this._mMOperationActiveCheck)
                {
                    _mMOperationActiveCheck = value;
                    NotifyChanged("MMOperationActiveCheck");
                }
            }
        }
        public int MMOperationOrder
        {
            get { return _mMOperationOrder; }
            set
            {
                if (value != this._mMOperationOrder)
                {
                    _mMOperationOrder = value;
                    NotifyChanged("MMOperationOrder");
                }
            }
        }
        public bool MMOperationCostCalculationCheck
        {
            get { return _mMOperationCostCalculationCheck; }
            set
            {
                if (value != this._mMOperationCostCalculationCheck)
                {
                    _mMOperationCostCalculationCheck = value;
                    NotifyChanged("MMOperationCostCalculationCheck");
                }
            }
        }
        public bool MMOperationInOutStockCheck
        {
            get { return _mMOperationInOutStockCheck; }
            set
            {
                if (value != this._mMOperationInOutStockCheck)
                {
                    _mMOperationInOutStockCheck = value;
                    NotifyChanged("MMOperationInOutStockCheck");
                }
            }
        }
        public String MMOperationGroup
        {
            get { return _mMOperationGroup; }
            set
            {
                if (value != this._mMOperationGroup)
                {
                    _mMOperationGroup = value;
                    NotifyChanged("MMOperationGroup");
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
        public int FK_ACIngrogressAccountID
        {
            get { return _fK_ACIngrogressAccountID; }
            set
            {
                if (value != this._fK_ACIngrogressAccountID)
                {
                    _fK_ACIngrogressAccountID = value;
                    NotifyChanged("FK_ACIngrogressAccountID");
                }
            }
        }
        public int FK_ACCostAccountID
        {
            get { return _fK_ACCostAccountID; }
            set
            {
                if (value != this._fK_ACCostAccountID)
                {
                    _fK_ACCostAccountID = value;
                    NotifyChanged("FK_ACCostAccountID");
                }
            }
        }
        public String MMOperationType
        {
            get { return _mMOperationType; }
            set
            {
                if (value != this._mMOperationType)
                {
                    _mMOperationType = value;
                    NotifyChanged("MMOperationType");
                }
            }
        }
        public bool MMOperationCapacity
        {
            get { return _mMOperationCapacity; }
            set
            {
                if (value != this._mMOperationCapacity)
                {
                    _mMOperationCapacity = value;
                    NotifyChanged("MMOperationCapacity");
                }
            }
        }
        public String MMOperationAcronym
        {
            get { return _mMOperationAcronym; }
            set
            {
                if (value != this._mMOperationAcronym)
                {
                    _mMOperationAcronym = value;
                    NotifyChanged("MMOperationAcronym");
                }
            }
        }
        public bool MMOperationNeedQC
        {
            get { return _mMOperationNeedQC; }
            set
            {
                if (value != this._mMOperationNeedQC)
                {
                    _mMOperationNeedQC = value;
                    NotifyChanged("MMOperationNeedQC");
                }
            }
        }
        public bool MMOperationIsBeginOperation
        {
            get { return _mMOperationIsBeginOperation; }
            set
            {
                if (value != this._mMOperationIsBeginOperation)
                {
                    _mMOperationIsBeginOperation = value;
                    NotifyChanged("MMOperationIsBeginOperation");
                }
            }
        }
        public bool MMOperationSyncProductCheck
        {
            get { return _mMOperationSyncProductCheck; }
            set
            {
                if (value != this._mMOperationSyncProductCheck)
                {
                    _mMOperationSyncProductCheck = value;
                    NotifyChanged("MMOperationSyncProductCheck");
                }
            }
        }
        public bool MMOperationIsPlan
        {
            get { return _mMOperationIsPlan; }
            set
            {
                if (value != this._mMOperationIsPlan)
                {
                    _mMOperationIsPlan = value;
                    NotifyChanged("MMOperationIsPlan");
                }
            }
        }
        public int FK_MMOperationSynID
        {
            get { return _fK_MMOperationSynID; }
            set
            {
                if (value != this._fK_MMOperationSynID)
                {
                    _fK_MMOperationSynID = value;
                    NotifyChanged("FK_MMOperationSynID");
                }
            }
        }
        public bool MMOperationForParentSyncCheck
        {
            get { return _mMOperationForParentSyncCheck; }
            set
            {
                if (value != this._mMOperationForParentSyncCheck)
                {
                    _mMOperationForParentSyncCheck = value;
                    NotifyChanged("MMOperationForParentSyncCheck");
                }
            }
        }
        public bool MMOperationIsOutSourcing
        {
            get { return _mMOperationIsOutSourcing; }
            set
            {
                if (value != this._mMOperationIsOutSourcing)
                {
                    _mMOperationIsOutSourcing = value;
                    NotifyChanged("MMOperationIsOutSourcing");
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
        public bool MMOperationIsEndProcess
        {
            get { return _mMOperationIsEndProcess; }
            set
            {
                if (value != this._mMOperationIsEndProcess)
                {
                    _mMOperationIsEndProcess = value;
                    NotifyChanged("MMOperationIsEndProcess");
                }
            }
        }
        #endregion

        #region exstra properties
        public decimal chiPhiNhanCongTT { get; set; }
        public decimal chiPhiNhanCongChung { get; set; }
        public Image MMOperationBarCodeImage { get; set; }
        public string MMOperationBarCode { get; set; }
        public int MMOperationPeriodOrder { get; set; }
        public string MMMachineGroupValue { get; set; }
        public string MMMachineGroup { get; set; }
        public int MMOperationReferenceMark { get; set; }
        #endregion
    }
    #endregion
}