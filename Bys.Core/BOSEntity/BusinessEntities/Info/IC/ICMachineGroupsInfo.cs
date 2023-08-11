﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICMachineGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICMachineGroupsInfo
    //Created Date:Thursday, March 14, 2019
    //-----------------------------------------------------------

    public class ICMachineGroupsInfo : BusinessObject
    {
        public ICMachineGroupsInfo()
        {
        }
        #region Variables
        protected int _iCMachineGroupID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _iCMachineGroupName = String.Empty;
        protected String _iCMachineGroupType = String.Empty;
        protected int _fK_ACAssetID;
        protected int _fK_ICProductIdentifiedEquipmentID;
        protected int _fK_ICProductID;
        protected String _iCMachineGroupStatus = DefaultStatus;
        protected decimal _iCMachineGroupTime;
        protected decimal _iCMachineGroupTimeCapacity;
        protected String _iCMachineGroupUnit = String.Empty;
        protected int _iCMachineGroupNumberPerson;
        protected int _fK_ICMachineID;
        #endregion

        #region Public properties
        public int ICMachineGroupID
        {
            get { return _iCMachineGroupID; }
            set
            {
                if (value != this._iCMachineGroupID)
                {
                    _iCMachineGroupID = value;
                    NotifyChanged("ICMachineGroupID");
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
        public String ICMachineGroupName
        {
            get { return _iCMachineGroupName; }
            set
            {
                if (value != this._iCMachineGroupName)
                {
                    _iCMachineGroupName = value;
                    NotifyChanged("ICMachineGroupName");
                }
            }
        }
        public String ICMachineGroupType
        {
            get { return _iCMachineGroupType; }
            set
            {
                if (value != this._iCMachineGroupType)
                {
                    _iCMachineGroupType = value;
                    NotifyChanged("ICMachineGroupType");
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
        public int FK_ICProductIdentifiedEquipmentID
        {
            get { return _fK_ICProductIdentifiedEquipmentID; }
            set
            {
                if (value != this._fK_ICProductIdentifiedEquipmentID)
                {
                    _fK_ICProductIdentifiedEquipmentID = value;
                    NotifyChanged("FK_ICProductIdentifiedEquipmentID");
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
        public String ICMachineGroupStatus
        {
            get { return _iCMachineGroupStatus; }
            set
            {
                if (value != this._iCMachineGroupStatus)
                {
                    _iCMachineGroupStatus = value;
                    NotifyChanged("ICMachineGroupStatus");
                }
            }
        }
        public decimal ICMachineGroupTime
        {
            get { return _iCMachineGroupTime; }
            set
            {
                if (value != this._iCMachineGroupTime)
                {
                    _iCMachineGroupTime = value;
                    NotifyChanged("ICMachineGroupTime");
                }
            }
        }
        public decimal ICMachineGroupTimeCapacity
        {
            get { return _iCMachineGroupTimeCapacity; }
            set
            {
                if (value != this._iCMachineGroupTimeCapacity)
                {
                    _iCMachineGroupTimeCapacity = value;
                    NotifyChanged("ICMachineGroupTimeCapacity");
                }
            }
        }
        public String ICMachineGroupUnit
        {
            get { return _iCMachineGroupUnit; }
            set
            {
                if (value != this._iCMachineGroupUnit)
                {
                    _iCMachineGroupUnit = value;
                    NotifyChanged("ICMachineGroupUnit");
                }
            }
        }
        public int ICMachineGroupNumberPerson
        {
            get { return _iCMachineGroupNumberPerson; }
            set
            {
                if (value != this._iCMachineGroupNumberPerson)
                {
                    _iCMachineGroupNumberPerson = value;
                    NotifyChanged("ICMachineGroupNumberPerson");
                }
            }
        }
        public int FK_ICMachineID
        {
            get { return _fK_ICMachineID; }
            set
            {
                if (value != this._fK_ICMachineID)
                {
                    _fK_ICMachineID = value;
                    NotifyChanged("FK_ICMachineID");
                }
            }
        }
        #endregion

        public int CurrentID { get; set; }
    }
    #endregion
}