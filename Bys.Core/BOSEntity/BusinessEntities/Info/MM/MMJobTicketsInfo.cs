﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMJobTickets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMJobTicketsInfo
    //Created Date:Saturday, June 08, 2019
    //-----------------------------------------------------------

    public class MMJobTicketsInfo : BusinessObject
    {
        public MMJobTicketsInfo()
        {
        }
        #region Variables
        protected int _mMJobTicketID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMOperationID;
        protected int _fK_MMWorkShopID;
        protected int _fK_MMLineID;
        protected int _fK_HRDepartmentRoomGroupItemID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _mMJobTicketNo = String.Empty;
        protected String _mMJobTicketName = String.Empty;
        protected String _mMJobTicketDesc = String.Empty;
        protected String _mMJobTicketStatus = DefaultStatus;
        protected DateTime _mMJobTicketDate = DateTime.MaxValue;
        protected DateTime _mMJobTicketFromDate = DateTime.MaxValue;
        protected DateTime _mMJobTicketToDate = DateTime.MaxValue;
        #endregion

        #region Public properties
        public int MMJobTicketID
        {
            get { return _mMJobTicketID; }
            set
            {
                if (value != this._mMJobTicketID)
                {
                    _mMJobTicketID = value;
                    NotifyChanged("MMJobTicketID");
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
        public int FK_MMWorkShopID
        {
            get { return _fK_MMWorkShopID; }
            set
            {
                if (value != this._fK_MMWorkShopID)
                {
                    _fK_MMWorkShopID = value;
                    NotifyChanged("FK_MMWorkShopID");
                }
            }
        }
        public int FK_MMLineID
        {
            get { return _fK_MMLineID; }
            set
            {
                if (value != this._fK_MMLineID)
                {
                    _fK_MMLineID = value;
                    NotifyChanged("FK_MMLineID");
                }
            }
        }
        public int FK_HRDepartmentRoomGroupItemID
        {
            get { return _fK_HRDepartmentRoomGroupItemID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomGroupItemID)
                {
                    _fK_HRDepartmentRoomGroupItemID = value;
                    NotifyChanged("FK_HRDepartmentRoomGroupItemID");
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
        public String MMJobTicketNo
        {
            get { return _mMJobTicketNo; }
            set
            {
                if (value != this._mMJobTicketNo)
                {
                    _mMJobTicketNo = value;
                    NotifyChanged("MMJobTicketNo");
                }
            }
        }
        public String MMJobTicketName
        {
            get { return _mMJobTicketName; }
            set
            {
                if (value != this._mMJobTicketName)
                {
                    _mMJobTicketName = value;
                    NotifyChanged("MMJobTicketName");
                }
            }
        }
        public String MMJobTicketDesc
        {
            get { return _mMJobTicketDesc; }
            set
            {
                if (value != this._mMJobTicketDesc)
                {
                    _mMJobTicketDesc = value;
                    NotifyChanged("MMJobTicketDesc");
                }
            }
        }
        public String MMJobTicketStatus
        {
            get { return _mMJobTicketStatus; }
            set
            {
                if (value != this._mMJobTicketStatus)
                {
                    _mMJobTicketStatus = value;
                    NotifyChanged("MMJobTicketStatus");
                }
            }
        }
        public DateTime MMJobTicketDate
        {
            get { return _mMJobTicketDate; }
            set
            {
                if (value != this._mMJobTicketDate)
                {
                    _mMJobTicketDate = value;
                    NotifyChanged("MMJobTicketDate");
                }
            }
        }
        public DateTime MMJobTicketFromDate
        {
            get { return _mMJobTicketFromDate; }
            set
            {
                if (value != this._mMJobTicketFromDate)
                {
                    _mMJobTicketFromDate = value;
                    NotifyChanged("MMJobTicketFromDate");
                }
            }
        }
        public DateTime MMJobTicketToDate
        {
            get { return _mMJobTicketToDate; }
            set
            {
                if (value != this._mMJobTicketToDate)
                {
                    _mMJobTicketToDate = value;
                    NotifyChanged("MMJobTicketToDate");
                }
            }
        }
        #endregion
        #region Extra Property
        public int BacklogInMonth { get; set; }
        #endregion
    }
    #endregion
}