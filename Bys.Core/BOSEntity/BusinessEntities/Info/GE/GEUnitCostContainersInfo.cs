﻿using BOSLib;
using System;
namespace BOSERP
{
    #region GEUnitCostContainers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEUnitCostContainersInfo
    //Created Date:Friday, January 25, 2019
    //-----------------------------------------------------------

    public class GEUnitCostContainersInfo : BusinessObject
    {
        public GEUnitCostContainersInfo()
        {
        }
        #region Variables
        protected int _gEUnitCostContainerID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_GEUnitCostID;
        protected int _fK_GEContainerID;
        protected int _fk_GETerminalID;
        protected decimal _gEUnitCostContainerUnitCost;
        protected String _gEUnitCostContainerDesc = String.Empty;
        #endregion

        #region Public properties
        public int GEUnitCostContainerID
        {
            get { return _gEUnitCostContainerID; }
            set
            {
                if (value != this._gEUnitCostContainerID)
                {
                    _gEUnitCostContainerID = value;
                    NotifyChanged("GEUnitCostContainerID");
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
        public int FK_GEUnitCostID
        {
            get { return _fK_GEUnitCostID; }
            set
            {
                if (value != this._fK_GEUnitCostID)
                {
                    _fK_GEUnitCostID = value;
                    NotifyChanged("FK_GEUnitCostID");
                }
            }
        }
        public int FK_GEContainerID
        {
            get { return _fK_GEContainerID; }
            set
            {
                if (value != this._fK_GEContainerID)
                {
                    _fK_GEContainerID = value;
                    NotifyChanged("FK_GEContainerID");
                }
            }
        }
        public int fk_GETerminalID
        {
            get { return _fk_GETerminalID; }
            set
            {
                if (value != this._fk_GETerminalID)
                {
                    _fk_GETerminalID = value;
                    NotifyChanged("fk_GETerminalID");
                }
            }
        }
        public decimal GEUnitCostContainerUnitCost
        {
            get { return _gEUnitCostContainerUnitCost; }
            set
            {
                if (value != this._gEUnitCostContainerUnitCost)
                {
                    _gEUnitCostContainerUnitCost = value;
                    NotifyChanged("GEUnitCostContainerUnitCost");
                }
            }
        }
        public String GEUnitCostContainerDesc
        {
            get { return _gEUnitCostContainerDesc; }
            set
            {
                if (value != this._gEUnitCostContainerDesc)
                {
                    _gEUnitCostContainerDesc = value;
                    NotifyChanged("GEUnitCostContainerDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}