﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACStopAllocationEquipments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACStopAllocationEquipmentsInfo
    //Created Date:Wednesday, August 29, 2018
    //-----------------------------------------------------------

    public class ACStopAllocationEquipmentsInfo : BusinessObject
    {
        public ACStopAllocationEquipmentsInfo()
        {
            ACStopAllocationEquipmentStartDate = BOSUtil.GetYearBeginDate();
            ACStopAllocationEquipmentFinishedDate = BOSUtil.GetYearEndDate();
        }
        #region Variables
        protected int _aCStopAllocationEquipmentID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aCStopAllocationEquipmentNo = String.Empty;
        protected String _aCStopAllocationEquipmentName = String.Empty;
        protected String _aCStopAllocationEquipmentDesc = String.Empty;
        protected String _aCStopAllocationEquipmentReason = String.Empty;
        protected DateTime _aCStopAllocationEquipmentDate = DateTime.MaxValue;
        protected DateTime _aCStopAllocationEquipmentDateStop = DateTime.MaxValue;
        protected int _fK_ICProductID;
        protected int _fK_ICProductIdentifiedEquipmentID;
        protected int _fK_BRBranchID;
        protected String _aCStopAllocationEquipmentType = String.Empty;
        #endregion

        #region Public properties
        public int ACStopAllocationEquipmentID
        {
            get { return _aCStopAllocationEquipmentID; }
            set
            {
                if (value != this._aCStopAllocationEquipmentID)
                {
                    _aCStopAllocationEquipmentID = value;
                    NotifyChanged("ACStopAllocationEquipmentID");
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
        public String ACStopAllocationEquipmentNo
        {
            get { return _aCStopAllocationEquipmentNo; }
            set
            {
                if (value != this._aCStopAllocationEquipmentNo)
                {
                    _aCStopAllocationEquipmentNo = value;
                    NotifyChanged("ACStopAllocationEquipmentNo");
                }
            }
        }
        public String ACStopAllocationEquipmentName
        {
            get { return _aCStopAllocationEquipmentName; }
            set
            {
                if (value != this._aCStopAllocationEquipmentName)
                {
                    _aCStopAllocationEquipmentName = value;
                    NotifyChanged("ACStopAllocationEquipmentName");
                }
            }
        }
        public String ACStopAllocationEquipmentDesc
        {
            get { return _aCStopAllocationEquipmentDesc; }
            set
            {
                if (value != this._aCStopAllocationEquipmentDesc)
                {
                    _aCStopAllocationEquipmentDesc = value;
                    NotifyChanged("ACStopAllocationEquipmentDesc");
                }
            }
        }
        public String ACStopAllocationEquipmentReason
        {
            get { return _aCStopAllocationEquipmentReason; }
            set
            {
                if (value != this._aCStopAllocationEquipmentReason)
                {
                    _aCStopAllocationEquipmentReason = value;
                    NotifyChanged("ACStopAllocationEquipmentReason");
                }
            }
        }
        public DateTime ACStopAllocationEquipmentDate
        {
            get { return _aCStopAllocationEquipmentDate; }
            set
            {
                if (value != this._aCStopAllocationEquipmentDate)
                {
                    _aCStopAllocationEquipmentDate = value;
                    NotifyChanged("ACStopAllocationEquipmentDate");
                }
            }
        }
        public DateTime ACStopAllocationEquipmentDateStop
        {
            get { return _aCStopAllocationEquipmentDateStop; }
            set
            {
                if (value != this._aCStopAllocationEquipmentDateStop)
                {
                    _aCStopAllocationEquipmentDateStop = value;
                    NotifyChanged("ACStopAllocationEquipmentDateStop");
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
        public String ACStopAllocationEquipmentType
        {
            get { return _aCStopAllocationEquipmentType; }
            set
            {
                if (value != this._aCStopAllocationEquipmentType)
                {
                    _aCStopAllocationEquipmentType = value;
                    NotifyChanged("ACStopAllocationEquipmentType");
                }
            }
        }
        #endregion

        #region extra
        public DateTime ACStopAllocationEquipmentStartDate { get; set; }
        public DateTime ACStopAllocationEquipmentFinishedDate { get; set; }
        #endregion
    }
    #endregion
}