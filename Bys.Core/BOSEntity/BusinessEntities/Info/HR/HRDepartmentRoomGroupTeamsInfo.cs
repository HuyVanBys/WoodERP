﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRDepartmentRoomGroupTeams
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRDepartmentRoomGroupTeamsInfo
    //Created Date:Wednesday, June 19, 2019
    //-----------------------------------------------------------

    public class HRDepartmentRoomGroupTeamsInfo : BusinessObject
    {
        public HRDepartmentRoomGroupTeamsInfo()
        {
        }
        #region Variables
        protected int _hRDepartmentRoomGroupTeamID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRDepartmentRoomGroupID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_HRDepartmentID;
        protected int _fK_BRBranchID;
        protected String _hRDepartmentRoomGroupTeamNo = String.Empty;
        protected String _hRDepartmentRoomGroupTeamName = String.Empty;
        protected String _hRDepartmentRoomGroupTeamDesc = String.Empty;
        protected int _fK_HRDepartmentRoomGroupItemID;
        #endregion

        #region Public properties
        public int HRDepartmentRoomGroupTeamID
        {
            get { return _hRDepartmentRoomGroupTeamID; }
            set
            {
                if (value != this._hRDepartmentRoomGroupTeamID)
                {
                    _hRDepartmentRoomGroupTeamID = value;
                    NotifyChanged("HRDepartmentRoomGroupTeamID");
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
        public int FK_HRDepartmentRoomGroupID
        {
            get { return _fK_HRDepartmentRoomGroupID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomGroupID)
                {
                    _fK_HRDepartmentRoomGroupID = value;
                    NotifyChanged("FK_HRDepartmentRoomGroupID");
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
        public String HRDepartmentRoomGroupTeamNo
        {
            get { return _hRDepartmentRoomGroupTeamNo; }
            set
            {
                if (value != this._hRDepartmentRoomGroupTeamNo)
                {
                    _hRDepartmentRoomGroupTeamNo = value;
                    NotifyChanged("HRDepartmentRoomGroupTeamNo");
                }
            }
        }
        public String HRDepartmentRoomGroupTeamName
        {
            get { return _hRDepartmentRoomGroupTeamName; }
            set
            {
                if (value != this._hRDepartmentRoomGroupTeamName)
                {
                    _hRDepartmentRoomGroupTeamName = value;
                    NotifyChanged("HRDepartmentRoomGroupTeamName");
                }
            }
        }
        public String HRDepartmentRoomGroupTeamDesc
        {
            get { return _hRDepartmentRoomGroupTeamDesc; }
            set
            {
                if (value != this._hRDepartmentRoomGroupTeamDesc)
                {
                    _hRDepartmentRoomGroupTeamDesc = value;
                    NotifyChanged("HRDepartmentRoomGroupTeamDesc");
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
        #endregion
    }
    #endregion
}