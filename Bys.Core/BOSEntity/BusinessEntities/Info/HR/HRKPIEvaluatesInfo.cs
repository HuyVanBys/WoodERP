﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRKPIEvaluations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRKPIEvaluationsInfo
    //Created Date:Tuesday, July 3, 2018
    //-----------------------------------------------------------

    public class HRKPIEvaluationsInfo : BusinessObject
    {
        public HRKPIEvaluationsInfo()
        {
        }
        #region Variables
        protected int _hRKPIEvaluationID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _hRKPIEvaluationNo = String.Empty;
        protected DateTime _hRKPIEvaluationDate = DateTime.MaxValue;
        protected DateTime _hRKPIEvaluationStartDate = DefaultDate;
        protected DateTime _hRKPIEvaluationFinishedDate = DateTime.MaxValue;
        protected int _fK_HREmployeeID;
        protected int _fK_HREmployeeID2;
        protected decimal _hRKPIEvaluationTotalAmountBonus;
        protected decimal _hRKPIEvaluationTotalAmount;
        protected int _fK_BRBranchID;
        protected int _fK_HRKPIRegistrationID;
        protected int _fK_BRBranchID2;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected String _hRKPIEvaluationType = String.Empty;
        protected String _hRKPIEvaluationStatus = DefaultStatus;
        protected String _hRKPIEvaluationName = String.Empty;

        #endregion

        #region Public properties
        public int HRKPIEvaluationID
        {
            get { return _hRKPIEvaluationID; }
            set
            {
                if (value != this._hRKPIEvaluationID)
                {
                    _hRKPIEvaluationID = value;
                    NotifyChanged("HRKPIEvaluationID");
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
        public String HRKPIEvaluationNo
        {
            get { return _hRKPIEvaluationNo; }
            set
            {
                if (value != this._hRKPIEvaluationNo)
                {
                    _hRKPIEvaluationNo = value;
                    NotifyChanged("HRKPIEvaluationNo");
                }
            }
        }
        public DateTime HRKPIEvaluationDate
        {
            get { return _hRKPIEvaluationDate; }
            set
            {
                if (value != this._hRKPIEvaluationDate)
                {
                    _hRKPIEvaluationDate = value;
                    NotifyChanged("HRKPIEvaluationDate");
                }
            }
        }
        public DateTime HRKPIEvaluationStartDate
        {
            get { return _hRKPIEvaluationStartDate; }
            set
            {
                if (value != this._hRKPIEvaluationStartDate)
                {
                    _hRKPIEvaluationStartDate = value;
                    NotifyChanged("HRKPIEvaluationStartDate");
                }
            }
        }
        public DateTime HRKPIEvaluationFinishedDate
        {
            get { return _hRKPIEvaluationFinishedDate; }
            set
            {
                if (value != this._hRKPIEvaluationFinishedDate)
                {
                    _hRKPIEvaluationFinishedDate = value;
                    NotifyChanged("HRKPIEvaluationFinishedDate");
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
        public decimal HRKPIEvaluationTotalAmountBonus
        {
            get { return _hRKPIEvaluationTotalAmountBonus; }
            set
            {
                if (value != this._hRKPIEvaluationTotalAmountBonus)
                {
                    _hRKPIEvaluationTotalAmountBonus = value;
                    NotifyChanged("HRKPIEvaluationTotalAmountBonus");
                }
            }
        }
        public decimal HRKPIEvaluationTotalAmount
        {
            get { return _hRKPIEvaluationTotalAmount; }
            set
            {
                if (value != this._hRKPIEvaluationTotalAmount)
                {
                    _hRKPIEvaluationTotalAmount = value;
                    NotifyChanged("HRKPIEvaluationTotalAmount");
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
        public int FK_HRKPIRegistrationID
        {
            get { return _fK_HRKPIRegistrationID; }
            set
            {
                if (value != this._fK_HRKPIRegistrationID)
                {
                    _fK_HRKPIRegistrationID = value;
                    NotifyChanged("FK_HRKPIRegistrationID");
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
        public String HRKPIEvaluationType
        {
            get { return _hRKPIEvaluationType; }
            set
            {
                if (value != this._hRKPIEvaluationType)
                {
                    _hRKPIEvaluationType = value;
                    NotifyChanged("HRKPIEvaluationType");
                }
            }
        }
        public String HRKPIEvaluationStatus
        {
            get { return _hRKPIEvaluationStatus; }
            set
            {
                if (value != this._hRKPIEvaluationStatus)
                {
                    _hRKPIEvaluationStatus = value;
                    NotifyChanged("HRKPIEvaluationStatus");
                }
            }
        }
        public String HRKPIEvaluationName
        {
            get { return _hRKPIEvaluationName; }
            set
            {
                if (value != this._hRKPIEvaluationName)
                {
                    _hRKPIEvaluationName = value;
                    NotifyChanged("HRKPIEvaluationName");
                }
            }
        }

        #endregion

        #region Extra
        public byte[] HRKPIEvaluationEmployeePicture { get; set; }
        public DateTime KPIEvaluationFromDate { get; set; }
        public DateTime KPIEvaluationToDate { get; set; }
        #endregion
    }
    #endregion
}