using BOSLib;
using System;
namespace BOSERP
{
    #region MMMergeBOMChangeItemProcessBOMLogs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMMergeBOMChangeItemProcessBOMLogsInfo
    //Created Date:Saturday, March 09, 2019
    //-----------------------------------------------------------

    public class MMMergeBOMChangeItemProcessBOMLogsInfo : BusinessObject
    {
        public MMMergeBOMChangeItemProcessBOMLogsInfo()
        {
        }
        #region Variables
        protected int _mMMergeBOMChangeItemProcessBOMLogID;
        protected int _fK_MMMergeBOMChangeID;
        protected int _iCProductItemProcessLogID;
        protected int _fK_MMProductionNormApproveLogID;
        protected int _fK_MMBatchProductID;
        protected int _iCProductItemProcessID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductCarcassID;
        protected int _fK_ICProductID;
        protected int _fK_MMOperationID;
        protected int _iCProductItemProcessPeriod;
        protected int _fK_MMProcessID;
        protected String _iCMachineGroup = String.Empty;
        protected String _mMMergeBOMChangeActionType = String.Empty;
        protected bool _iCProductItemProcessCapacity = true;
        protected bool _iCProductItemProcessInOutStockCheck = true;
        protected bool _iCProductItemProcessIsBeginOperation = true;
        protected bool _iCProductItemProcessIsPlan = true;
        protected bool _mMMergeBOMChangeItemProcessBOMLogSyncProductCheck = true;
        protected int _fK_MMOperationSynID;
        protected bool _mMMergeBOMChangeItemProcessBOMLogForParentSyncCheck = true;
        protected bool _mMMergeBOMChangeItemProcessBOMLogIsOutSourcing = true;
        #endregion

        #region Public properties
        public int MMMergeBOMChangeItemProcessBOMLogID
        {
            get { return _mMMergeBOMChangeItemProcessBOMLogID; }
            set
            {
                if (value != this._mMMergeBOMChangeItemProcessBOMLogID)
                {
                    _mMMergeBOMChangeItemProcessBOMLogID = value;
                    NotifyChanged("MMMergeBOMChangeItemProcessBOMLogID");
                }
            }
        }
        public int FK_MMMergeBOMChangeID
        {
            get { return _fK_MMMergeBOMChangeID; }
            set
            {
                if (value != this._fK_MMMergeBOMChangeID)
                {
                    _fK_MMMergeBOMChangeID = value;
                    NotifyChanged("FK_MMMergeBOMChangeID");
                }
            }
        }
        public int ICProductItemProcessLogID
        {
            get { return _iCProductItemProcessLogID; }
            set
            {
                if (value != this._iCProductItemProcessLogID)
                {
                    _iCProductItemProcessLogID = value;
                    NotifyChanged("ICProductItemProcessLogID");
                }
            }
        }
        public int FK_MMProductionNormApproveLogID
        {
            get { return _fK_MMProductionNormApproveLogID; }
            set
            {
                if (value != this._fK_MMProductionNormApproveLogID)
                {
                    _fK_MMProductionNormApproveLogID = value;
                    NotifyChanged("FK_MMProductionNormApproveLogID");
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
        public int ICProductItemProcessID
        {
            get { return _iCProductItemProcessID; }
            set
            {
                if (value != this._iCProductItemProcessID)
                {
                    _iCProductItemProcessID = value;
                    NotifyChanged("ICProductItemProcessID");
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
        public int FK_ICProductCarcassID
        {
            get { return _fK_ICProductCarcassID; }
            set
            {
                if (value != this._fK_ICProductCarcassID)
                {
                    _fK_ICProductCarcassID = value;
                    NotifyChanged("FK_ICProductCarcassID");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public int FK_MMOperationID
        {
            get { return _fK_MMOperationID; }
            set
            {
                if (value != this._fK_MMOperationID)
                {
                    _fK_MMOperationID = value;
                    NotifyChanged("FK_MMOperationID");
                }
            }
        }
        public int ICProductItemProcessPeriod
        {
            get { return _iCProductItemProcessPeriod; }
            set
            {
                if (value != this._iCProductItemProcessPeriod)
                {
                    _iCProductItemProcessPeriod = value;
                    NotifyChanged("ICProductItemProcessPeriod");
                }
            }
        }
        public int FK_MMProcessID
        {
            get { return _fK_MMProcessID; }
            set
            {
                if (value != this._fK_MMProcessID)
                {
                    _fK_MMProcessID = value;
                    NotifyChanged("FK_MMProcessID");
                }
            }
        }
        public String ICMachineGroup
        {
            get { return _iCMachineGroup; }
            set
            {
                if (value != this._iCMachineGroup)
                {
                    _iCMachineGroup = value;
                    NotifyChanged("ICMachineGroup");
                }
            }
        }
        public String MMMergeBOMChangeActionType
        {
            get { return _mMMergeBOMChangeActionType; }
            set
            {
                if (value != this._mMMergeBOMChangeActionType)
                {
                    _mMMergeBOMChangeActionType = value;
                    NotifyChanged("MMMergeBOMChangeActionType");
                }
            }
        }
        public bool ICProductItemProcessCapacity
        {
            get { return _iCProductItemProcessCapacity; }
            set
            {
                if (value != this._iCProductItemProcessCapacity)
                {
                    _iCProductItemProcessCapacity = value;
                    NotifyChanged("ICProductItemProcessCapacity");
                }
            }
        }
        public bool ICProductItemProcessInOutStockCheck
        {
            get { return _iCProductItemProcessInOutStockCheck; }
            set
            {
                if (value != this._iCProductItemProcessInOutStockCheck)
                {
                    _iCProductItemProcessInOutStockCheck = value;
                    NotifyChanged("ICProductItemProcessInOutStockCheck");
                }
            }
        }
        public bool ICProductItemProcessIsBeginOperation
        {
            get { return _iCProductItemProcessIsBeginOperation; }
            set
            {
                if (value != this._iCProductItemProcessIsBeginOperation)
                {
                    _iCProductItemProcessIsBeginOperation = value;
                    NotifyChanged("ICProductItemProcessIsBeginOperation");
                }
            }
        }
        public bool ICProductItemProcessIsPlan
        {
            get { return _iCProductItemProcessIsPlan; }
            set
            {
                if (value != this._iCProductItemProcessIsPlan)
                {
                    _iCProductItemProcessIsPlan = value;
                    NotifyChanged("ICProductItemProcessIsPlan");
                }
            }
        }
        public bool MMMergeBOMChangeItemProcessBOMLogSyncProductCheck
        {
            get { return _mMMergeBOMChangeItemProcessBOMLogSyncProductCheck; }
            set
            {
                if (value != this._mMMergeBOMChangeItemProcessBOMLogSyncProductCheck)
                {
                    _mMMergeBOMChangeItemProcessBOMLogSyncProductCheck = value;
                    NotifyChanged("MMMergeBOMChangeItemProcessBOMLogSyncProductCheck");
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
        public bool MMMergeBOMChangeItemProcessBOMLogForParentSyncCheck
        {
            get { return _mMMergeBOMChangeItemProcessBOMLogForParentSyncCheck; }
            set
            {
                if (value != this._mMMergeBOMChangeItemProcessBOMLogForParentSyncCheck)
                {
                    _mMMergeBOMChangeItemProcessBOMLogForParentSyncCheck = value;
                    NotifyChanged("MMMergeBOMChangeItemProcessBOMLogForParentSyncCheck");
                }
            }
        }
        public bool MMMergeBOMChangeItemProcessBOMLogIsOutSourcing
        {
            get { return _mMMergeBOMChangeItemProcessBOMLogIsOutSourcing; }
            set
            {
                if (value != this._mMMergeBOMChangeItemProcessBOMLogIsOutSourcing)
                {
                    _mMMergeBOMChangeItemProcessBOMLogIsOutSourcing = value;
                    NotifyChanged("MMMergeBOMChangeItemProcessBOMLogIsOutSourcing");
                }
            }
        }
        #endregion


    }
    #endregion
}