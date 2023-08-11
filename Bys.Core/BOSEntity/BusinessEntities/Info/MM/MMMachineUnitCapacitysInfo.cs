﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMMachineUnitCapacitys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMMachineUnitCapacitysInfo
    //Created Date:Monday, September 09, 2019
    //-----------------------------------------------------------

    public class MMMachineUnitCapacitysInfo : BusinessObject
    {
        public MMMachineUnitCapacitysInfo()
        {
        }
        #region Variables
        protected int _mMMachineUnitCapacityID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMMachineUnitID;
        protected int _fK_MMMeasureUnitID;
        protected decimal _mMMachineUnitCapacity;
        protected String _hRDepartmentProductType = String.Empty;
        protected String _mMMachineUnitCapacityDesc = String.Empty;
        #endregion

        #region Public properties
        public int MMMachineUnitCapacityID
        {
            get { return _mMMachineUnitCapacityID; }
            set
            {
                if (value != this._mMMachineUnitCapacityID)
                {
                    _mMMachineUnitCapacityID = value;
                    NotifyChanged("MMMachineUnitCapacityID");
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
        public int FK_MMMeasureUnitID
        {
            get { return _fK_MMMeasureUnitID; }
            set
            {
                if (value != this._fK_MMMeasureUnitID)
                {
                    _fK_MMMeasureUnitID = value;
                    NotifyChanged("FK_MMMeasureUnitID");
                }
            }
        }
        public decimal MMMachineUnitCapacity
        {
            get { return _mMMachineUnitCapacity; }
            set
            {
                if (value != this._mMMachineUnitCapacity)
                {
                    _mMMachineUnitCapacity = value;
                    NotifyChanged("MMMachineUnitCapacity");
                }
            }
        }
        public String HRDepartmentProductType
        {
            get { return _hRDepartmentProductType; }
            set
            {
                if (value != this._hRDepartmentProductType)
                {
                    _hRDepartmentProductType = value;
                    NotifyChanged("HRDepartmentProductType");
                }
            }
        }
        public String MMMachineUnitCapacityDesc
        {
            get { return _mMMachineUnitCapacityDesc; }
            set
            {
                if (value != this._mMMachineUnitCapacityDesc)
                {
                    _mMMachineUnitCapacityDesc = value;
                    NotifyChanged("MMMachineUnitCapacityDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}