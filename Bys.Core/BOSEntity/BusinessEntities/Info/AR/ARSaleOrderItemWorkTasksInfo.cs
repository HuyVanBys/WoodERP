using BOSLib;
using System;
namespace BOSERP
{
    #region ARSaleOrderItemWorkTasks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSaleOrderItemWorkTasksInfo
    //Created Date:Thursday, March 15, 2018
    //-----------------------------------------------------------

    public class ARSaleOrderItemWorkTasksInfo : BusinessObject
    {
        public ARSaleOrderItemWorkTasksInfo()
        {
        }
        #region Variables
        protected int _aRSaleOrderItemWorkTaskID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_HREmployeeID;
        protected int _fK_PMProjectTypeID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICTaskID;
        protected int _fK_ICProductID;
        protected int _fK_ARSaleOrderItemWorkID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected String _aRSaleOrderItemWorkTaskNo = String.Empty;
        protected String _aRSaleOrderItemWorkTaskName = String.Empty;
        protected String _aRSaleOrderItemWorkTaskInfo = String.Empty;
        protected decimal _aRSaleOrderItemWorkTaskTotalEstimatedDays;
        protected decimal _aRSaleOrderItemWorkTaskTotalActualDays;
        protected decimal _aRSaleOrderItemWorkTaskTotalEstimatedHours;
        protected decimal _aRSaleOrderItemWorkTaskTotalActualHours;
        protected decimal _aRSaleOrderItemWorkTaskEstimatedExtendDays;
        protected decimal _aRSaleOrderItemWorkTaskActualExtendDays;
        protected decimal _aRSaleOrderItemWorkTaskEstimatedExtendHours;
        protected decimal _aRSaleOrderItemWorkTaskActualExtendHours;
        protected decimal _aRSaleOrderItemWorkTaskQty;
        protected decimal _aRSaleOrderItemWorkTaskEstimatedTotalCost;
        protected decimal _aRSaleOrderItemWorkTaskActualTotalCost;
        #endregion

        #region Public properties
        public int ARSaleOrderItemWorkTaskID
        {
            get { return _aRSaleOrderItemWorkTaskID; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskID)
                {
                    _aRSaleOrderItemWorkTaskID = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskID");
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
        public int FK_PMProjectTypeID
        {
            get { return _fK_PMProjectTypeID; }
            set
            {
                if (value != this._fK_PMProjectTypeID)
                {
                    _fK_PMProjectTypeID = value;
                    NotifyChanged("FK_PMProjectTypeID");
                }
            }
        }
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
                }
            }
        }
        public int FK_ICTaskID
        {
            get { return _fK_ICTaskID; }
            set
            {
                if (value != this._fK_ICTaskID)
                {
                    _fK_ICTaskID = value;
                    NotifyChanged("FK_ICTaskID");
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
        public int FK_ARSaleOrderItemWorkID
        {
            get { return _fK_ARSaleOrderItemWorkID; }
            set
            {
                if (value != this._fK_ARSaleOrderItemWorkID)
                {
                    _fK_ARSaleOrderItemWorkID = value;
                    NotifyChanged("FK_ARSaleOrderItemWorkID");
                }
            }
        }
        public int FK_ARSaleOrderID
        {
            get { return _fK_ARSaleOrderID; }
            set
            {
                if (value != this._fK_ARSaleOrderID)
                {
                    _fK_ARSaleOrderID = value;
                    NotifyChanged("FK_ARSaleOrderID");
                }
            }
        }
        public int FK_ARSaleOrderItemID
        {
            get { return _fK_ARSaleOrderItemID; }
            set
            {
                if (value != this._fK_ARSaleOrderItemID)
                {
                    _fK_ARSaleOrderItemID = value;
                    NotifyChanged("FK_ARSaleOrderItemID");
                }
            }
        }
        public String ARSaleOrderItemWorkTaskNo
        {
            get { return _aRSaleOrderItemWorkTaskNo; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskNo)
                {
                    _aRSaleOrderItemWorkTaskNo = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskNo");
                }
            }
        }
        public String ARSaleOrderItemWorkTaskName
        {
            get { return _aRSaleOrderItemWorkTaskName; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskName)
                {
                    _aRSaleOrderItemWorkTaskName = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskName");
                }
            }
        }
        public String ARSaleOrderItemWorkTaskInfo
        {
            get { return _aRSaleOrderItemWorkTaskInfo; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskInfo)
                {
                    _aRSaleOrderItemWorkTaskInfo = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskInfo");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskTotalEstimatedDays
        {
            get { return _aRSaleOrderItemWorkTaskTotalEstimatedDays; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskTotalEstimatedDays)
                {
                    _aRSaleOrderItemWorkTaskTotalEstimatedDays = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskTotalEstimatedDays");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskTotalActualDays
        {
            get { return _aRSaleOrderItemWorkTaskTotalActualDays; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskTotalActualDays)
                {
                    _aRSaleOrderItemWorkTaskTotalActualDays = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskTotalActualDays");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskTotalEstimatedHours
        {
            get { return _aRSaleOrderItemWorkTaskTotalEstimatedHours; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskTotalEstimatedHours)
                {
                    _aRSaleOrderItemWorkTaskTotalEstimatedHours = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskTotalEstimatedHours");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskTotalActualHours
        {
            get { return _aRSaleOrderItemWorkTaskTotalActualHours; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskTotalActualHours)
                {
                    _aRSaleOrderItemWorkTaskTotalActualHours = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskTotalActualHours");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskEstimatedExtendDays
        {
            get { return _aRSaleOrderItemWorkTaskEstimatedExtendDays; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskEstimatedExtendDays)
                {
                    _aRSaleOrderItemWorkTaskEstimatedExtendDays = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskEstimatedExtendDays");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskActualExtendDays
        {
            get { return _aRSaleOrderItemWorkTaskActualExtendDays; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskActualExtendDays)
                {
                    _aRSaleOrderItemWorkTaskActualExtendDays = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskActualExtendDays");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskEstimatedExtendHours
        {
            get { return _aRSaleOrderItemWorkTaskEstimatedExtendHours; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskEstimatedExtendHours)
                {
                    _aRSaleOrderItemWorkTaskEstimatedExtendHours = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskEstimatedExtendHours");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskActualExtendHours
        {
            get { return _aRSaleOrderItemWorkTaskActualExtendHours; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskActualExtendHours)
                {
                    _aRSaleOrderItemWorkTaskActualExtendHours = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskActualExtendHours");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskQty
        {
            get { return _aRSaleOrderItemWorkTaskQty; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskQty)
                {
                    _aRSaleOrderItemWorkTaskQty = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskQty");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskEstimatedTotalCost
        {
            get { return _aRSaleOrderItemWorkTaskEstimatedTotalCost; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskEstimatedTotalCost)
                {
                    _aRSaleOrderItemWorkTaskEstimatedTotalCost = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskEstimatedTotalCost");
                }
            }
        }
        public decimal ARSaleOrderItemWorkTaskActualTotalCost
        {
            get { return _aRSaleOrderItemWorkTaskActualTotalCost; }
            set
            {
                if (value != this._aRSaleOrderItemWorkTaskActualTotalCost)
                {
                    _aRSaleOrderItemWorkTaskActualTotalCost = value;
                    NotifyChanged("ARSaleOrderItemWorkTaskActualTotalCost");
                }
            }
        }
        #endregion
    }
    #endregion
}