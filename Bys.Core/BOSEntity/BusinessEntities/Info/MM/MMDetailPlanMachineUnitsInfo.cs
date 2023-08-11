﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMDetailPlanMachineUnits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMDetailPlanMachineUnitsInfo
    //Created Date:Monday, September 09, 2019
    //-----------------------------------------------------------

    public class MMDetailPlanMachineUnitsInfo : BusinessObject
    {
        public MMDetailPlanMachineUnitsInfo()
        {
        }
        #region Variables
        protected int _mMDetailPlanMachineUnitID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMMachineUnitID;
        protected int _fK_MMOperationDetailPlanItemChildID;
        protected int _fK_MMOperationID;
        protected int _fK_MMOperationDetailPlanID;
        protected int _fK_ACAssetID;
        protected decimal _hRDepartmentEmployeeQty;
        protected String _mMDetailPlanMachineUnitDesc = String.Empty;
        protected String _mMDetailPlanMachineUnitAbstract = String.Empty;
        protected int _fK_ADWorkingShiftID;
        protected decimal _mMDetailPlanMachineUnitCapacity;
        protected String _mMCapacityUnit = String.Empty;
        protected decimal _mMDetailPlanMachineUnitQty;
        protected String _mMDetailPlanMachineUnitType = String.Empty;
        protected decimal _mMDetailPlanMachineUnitSetupTime;
        #endregion

        #region Public properties
        public int MMDetailPlanMachineUnitID
        {
            get { return _mMDetailPlanMachineUnitID; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitID)
                {
                    _mMDetailPlanMachineUnitID = value;
                    NotifyChanged("MMDetailPlanMachineUnitID");
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
        public int FK_MMMachineUnitID
        {
            get { return _fK_MMMachineUnitID; }
            set
            {
                if (value != this._fK_MMMachineUnitID)
                {
                    _fK_MMMachineUnitID = value;
                    NotifyChanged("FK_MMMachineUnitID");
                }
            }
        }
        public int FK_MMOperationDetailPlanItemChildID
        {
            get { return _fK_MMOperationDetailPlanItemChildID; }
            set
            {
                if (value != this._fK_MMOperationDetailPlanItemChildID)
                {
                    _fK_MMOperationDetailPlanItemChildID = value;
                    NotifyChanged("FK_MMOperationDetailPlanItemChildID");
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
        public int FK_MMOperationDetailPlanID
        {
            get { return _fK_MMOperationDetailPlanID; }
            set
            {
                if (value != this._fK_MMOperationDetailPlanID)
                {
                    _fK_MMOperationDetailPlanID = value;
                    NotifyChanged("FK_MMOperationDetailPlanID");
                }
            }
        }
        public int FK_ACAssetID
        {
            get { return _fK_ACAssetID; }
            set
            {
                if (value != this._fK_ACAssetID)
                {
                    _fK_ACAssetID = value;
                    NotifyChanged("FK_ACAssetID");
                }
            }
        }
        public decimal HRDepartmentEmployeeQty
        {
            get { return _hRDepartmentEmployeeQty; }
            set
            {
                if (value != this._hRDepartmentEmployeeQty)
                {
                    _hRDepartmentEmployeeQty = value;
                    NotifyChanged("HRDepartmentEmployeeQty");
                }
            }
        }
        public String MMDetailPlanMachineUnitDesc
        {
            get { return _mMDetailPlanMachineUnitDesc; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitDesc)
                {
                    _mMDetailPlanMachineUnitDesc = value;
                    NotifyChanged("MMDetailPlanMachineUnitDesc");
                }
            }
        }
        public String MMDetailPlanMachineUnitAbstract
        {
            get { return _mMDetailPlanMachineUnitAbstract; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitAbstract)
                {
                    _mMDetailPlanMachineUnitAbstract = value;
                    NotifyChanged("MMDetailPlanMachineUnitAbstract");
                }
            }
        }
        public int FK_ADWorkingShiftID
        {
            get { return _fK_ADWorkingShiftID; }
            set
            {
                if (value != this._fK_ADWorkingShiftID)
                {
                    _fK_ADWorkingShiftID = value;
                    NotifyChanged("FK_ADWorkingShiftID");
                }
            }
        }
        public decimal MMDetailPlanMachineUnitCapacity
        {
            get { return _mMDetailPlanMachineUnitCapacity; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitCapacity)
                {
                    _mMDetailPlanMachineUnitCapacity = value;
                    NotifyChanged("MMDetailPlanMachineUnitCapacity");
                }
            }
        }
        public String MMCapacityUnit
        {
            get { return _mMCapacityUnit; }
            set
            {
                if (value != this._mMCapacityUnit)
                {
                    _mMCapacityUnit = value;
                    NotifyChanged("MMCapacityUnit");
                }
            }
        }
        public decimal MMDetailPlanMachineUnitQty
        {
            get { return _mMDetailPlanMachineUnitQty; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitQty)
                {
                    _mMDetailPlanMachineUnitQty = value;
                    NotifyChanged("MMDetailPlanMachineUnitQty");
                }
            }
        }
        public String MMDetailPlanMachineUnitType
        {
            get { return _mMDetailPlanMachineUnitType; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitType)
                {
                    _mMDetailPlanMachineUnitType = value;
                    NotifyChanged("MMDetailPlanMachineUnitType");
                }
            }
        }
        public decimal MMDetailPlanMachineUnitSetupTime
        {
            get { return _mMDetailPlanMachineUnitSetupTime; }
            set
            {
                if (value != this._mMDetailPlanMachineUnitSetupTime)
                {
                    _mMDetailPlanMachineUnitSetupTime = value;
                    NotifyChanged("MMDetailPlanMachineUnitSetupTime");
                }
            }
        }
        #endregion

        #region Public Extra
        public int FK_MMBatchProductProductionNormItemID { get; set; }
        public int FK_ICMachineProductID { get; set; }
        public string ACAssetNo { get; set; }
        public string MMMachineUnitName { get; set; }
        #endregion
    }
    #endregion
}