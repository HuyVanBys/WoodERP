﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACEquipmentStates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACEquipmentStatesInfo
    //Created Date:Friday, July 26, 2019
    //-----------------------------------------------------------

    public class ACEquipmentStatesInfo : BusinessObject
    {
        public ACEquipmentStatesInfo()
        {
        }
        #region Variables
        protected int _aCEquipmentStateID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aCEquipmentStateNo = String.Empty;
        protected String _aCEquipmentStateName = String.Empty;
        #endregion

        #region Public properties
        public int ACEquipmentStateID
        {
            get { return _aCEquipmentStateID; }
            set
            {
                if (value != this._aCEquipmentStateID)
                {
                    _aCEquipmentStateID = value;
                    NotifyChanged("ACEquipmentStateID");
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
        public String ACEquipmentStateNo
        {
            get { return _aCEquipmentStateNo; }
            set
            {
                if (value != this._aCEquipmentStateNo)
                {
                    _aCEquipmentStateNo = value;
                    NotifyChanged("ACEquipmentStateNo");
                }
            }
        }
        public String ACEquipmentStateName
        {
            get { return _aCEquipmentStateName; }
            set
            {
                if (value != this._aCEquipmentStateName)
                {
                    _aCEquipmentStateName = value;
                    NotifyChanged("ACEquipmentStateName");
                }
            }
        }
        #endregion
    }
    #endregion
}