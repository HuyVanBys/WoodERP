﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRKPIRegistrations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRKPIRegistrationsInfo
    //Created Date:Tuesday, July 3, 2018
    //-----------------------------------------------------------

    public class HRKPIRegistrationsInfo : BusinessObject
    {
        public HRKPIRegistrationsInfo()
        {
        }
        #region Variables
        protected int _hRKPIRegistrationID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _hRKPIRegistrationNo = String.Empty;
        protected DateTime _hRKPIRegistrationDate = DateTime.MaxValue;
        protected DateTime _hRKPIRegistrationStartDate = DefaultDate;
        protected DateTime _hRKPIRegistrationFinishedDate = DateTime.MaxValue;
        protected int _fK_HREmployeeID;
        protected int _fK_HREmployeeID2;
        protected decimal _hRKPIRegistrationTotalAmountBonus;
        protected decimal _hRKPIRegistrationTotalAmount;
        protected int _fK_BRBranchID;
        protected String _hRKPIRegistrationStatus = DefaultStatus;
        protected int _fK_BRBranchID2;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected String _hRKPIRegistrationType = String.Empty;
        protected String _hRKPIRegistrationName = String.Empty;
        protected int _fK_HRKPIFormID;
        protected DateTime _hRKPIRegistrationMonth = DateTime.MaxValue;
        protected DateTime _hRKPIRegistrationEndMonth = DateTime.MaxValue;

        #endregion

        #region Public properties
        public int HRKPIRegistrationID
        {
            get { return _hRKPIRegistrationID; }
            set
            {
                if (value != this._hRKPIRegistrationID)
                {
                    _hRKPIRegistrationID = value;
                    NotifyChanged("HRKPIRegistrationID");
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
        public String HRKPIRegistrationNo
        {
            get { return _hRKPIRegistrationNo; }
            set
            {
                if (value != this._hRKPIRegistrationNo)
                {
                    _hRKPIRegistrationNo = value;
                    NotifyChanged("HRKPIRegistrationNo");
                }
            }
        }
        public DateTime HRKPIRegistrationDate
        {
            get { return _hRKPIRegistrationDate; }
            set
            {
                if (value != this._hRKPIRegistrationDate)
                {
                    _hRKPIRegistrationDate = value;
                    NotifyChanged("HRKPIRegistrationDate");
                }
            }
        }
        public DateTime HRKPIRegistrationStartDate
        {
            get { return _hRKPIRegistrationStartDate; }
            set
            {
                if (value != this._hRKPIRegistrationStartDate)
                {
                    _hRKPIRegistrationStartDate = value;
                    NotifyChanged("HRKPIRegistrationStartDate");
                }
            }
        }
        public DateTime HRKPIRegistrationFinishedDate
        {
            get { return _hRKPIRegistrationFinishedDate; }
            set
            {
                if (value != this._hRKPIRegistrationFinishedDate)
                {
                    _hRKPIRegistrationFinishedDate = value;
                    NotifyChanged("HRKPIRegistrationFinishedDate");
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
        public int FK_HREmployeeID2
        {
            get { return _fK_HREmployeeID2; }
            set
            {
                if (value != this._fK_HREmployeeID2)
                {
                    _fK_HREmployeeID2 = value;
                    NotifyChanged("FK_HREmployeeID2");
                }
            }
        }
        public decimal HRKPIRegistrationTotalAmountBonus
        {
            get { return _hRKPIRegistrationTotalAmountBonus; }
            set
            {
                if (value != this._hRKPIRegistrationTotalAmountBonus)
                {
                    _hRKPIRegistrationTotalAmountBonus = value;
                    NotifyChanged("HRKPIRegistrationTotalAmountBonus");
                }
            }
        }
        public decimal HRKPIRegistrationTotalAmount
        {
            get { return _hRKPIRegistrationTotalAmount; }
            set
            {
                if (value != this._hRKPIRegistrationTotalAmount)
                {
                    _hRKPIRegistrationTotalAmount = value;
                    NotifyChanged("HRKPIRegistrationTotalAmount");
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
        public String HRKPIRegistrationStatus
        {
            get { return _hRKPIRegistrationStatus; }
            set
            {
                if (value != this._hRKPIRegistrationStatus)
                {
                    _hRKPIRegistrationStatus = value;
                    NotifyChanged("HRKPIRegistrationStatus");
                }
            }
        }
        public int FK_BRBranchID2
        {
            get { return _fK_BRBranchID2; }
            set
            {
                if (value != this._fK_BRBranchID2)
                {
                    _fK_BRBranchID2 = value;
                    NotifyChanged("FK_BRBranchID2");
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
        public String HRKPIRegistrationType
        {
            get { return _hRKPIRegistrationType; }
            set
            {
                if (value != this._hRKPIRegistrationType)
                {
                    _hRKPIRegistrationType = value;
                    NotifyChanged("HRKPIRegistrationType");
                }
            }
        }
        public String HRKPIRegistrationName
        {
            get { return _hRKPIRegistrationName; }
            set
            {
                if (value != this._hRKPIRegistrationName)
                {
                    _hRKPIRegistrationName = value;
                    NotifyChanged("HRKPIRegistrationName");
                }
            }
        }
        public int FK_HRKPIFormID
        {
            get { return _fK_HRKPIFormID; }
            set
            {
                if (value != this._fK_HRKPIFormID)
                {
                    _fK_HRKPIFormID = value;
                    NotifyChanged("FK_HRKPIFormID");
                }
            }
        }
        public DateTime HRKPIRegistrationMonth
        {
            get { return _hRKPIRegistrationMonth; }
            set
            {
                if (value != this._hRKPIRegistrationMonth)
                {
                    _hRKPIRegistrationMonth = value;
                    NotifyChanged("HRKPIRegistrationMonth");
                }
            }
        }
        public DateTime HRKPIRegistrationEndMonth
        {
            get { return _hRKPIRegistrationEndMonth; }
            set
            {
                if (value != this._hRKPIRegistrationEndMonth)
                {
                    _hRKPIRegistrationEndMonth = value;
                    NotifyChanged("HRKPIRegistrationEndMonth");
                }
            }
        }

        #endregion
        #region Extra
        public byte[] HRKPIRegistrationEmployeePicture { get; set; }
        public DateTime KPIRegistrationFromDate { get; set; }
        public DateTime KPIRegistrationToDate { get; set; }
        #endregion
    }
    #endregion
}