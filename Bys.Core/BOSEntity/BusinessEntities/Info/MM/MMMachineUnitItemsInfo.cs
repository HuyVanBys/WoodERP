﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMMachineUnitItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMMachineUnitItemsInfo
    //Created Date:Monday, September 09, 2019
    //-----------------------------------------------------------

    public class MMMachineUnitItemsInfo : BusinessObject
    {
        public MMMachineUnitItemsInfo()
        {
        }
        #region Variables
        protected int _mMMachineUnitItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMMachineUnitID;
        protected int _fK_ACAssetID;
        protected String _mMMachineUnitItemName = String.Empty;
        protected decimal _mMMachineUnitEmployeeQty;
        protected String _mMMachineUnitItemDesc = String.Empty;
        protected decimal _mMMachineUnitItemSetupTime;
        #endregion

        #region Public properties
        public int MMMachineUnitItemID
        {
            get { return _mMMachineUnitItemID; }
            set
            {
                if (value != this._mMMachineUnitItemID)
                {
                    _mMMachineUnitItemID = value;
                    NotifyChanged("MMMachineUnitItemID");
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
        public String MMMachineUnitItemName
        {
            get { return _mMMachineUnitItemName; }
            set
            {
                if (value != this._mMMachineUnitItemName)
                {
                    _mMMachineUnitItemName = value;
                    NotifyChanged("MMMachineUnitItemName");
                }
            }
        }
        public decimal MMMachineUnitEmployeeQty
        {
            get { return _mMMachineUnitEmployeeQty; }
            set
            {
                if (value != this._mMMachineUnitEmployeeQty)
                {
                    _mMMachineUnitEmployeeQty = value;
                    NotifyChanged("MMMachineUnitEmployeeQty");
                }
            }
        }
        public String MMMachineUnitItemDesc
        {
            get { return _mMMachineUnitItemDesc; }
            set
            {
                if (value != this._mMMachineUnitItemDesc)
                {
                    _mMMachineUnitItemDesc = value;
                    NotifyChanged("MMMachineUnitItemDesc");
                }
            }
        }
        public decimal MMMachineUnitItemSetupTime
        {
            get { return _mMMachineUnitItemSetupTime; }
            set
            {
                if (value != this._mMMachineUnitItemSetupTime)
                {
                    _mMMachineUnitItemSetupTime = value;
                    NotifyChanged("MMMachineUnitItemSetupTime");
                }
            }
        }
        #endregion

        #region Extra Property
        public string MMMachineUnitNo { get; set; }
        public decimal MMMachineUnitItemCapacity { get; set; }
        public string MMCapacityUnit { get; set; }
        public String FK_ADWorkingShiftID { get; set; }
        public string MMMachineUnitType { get; set; }
        public string MMMachineUnitName { get; set; }
        #endregion
    }
    #endregion
}