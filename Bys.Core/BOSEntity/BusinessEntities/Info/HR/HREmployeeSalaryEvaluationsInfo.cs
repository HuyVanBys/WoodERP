﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeSalaryEvaluations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeSalaryEvaluationsInfo
    //Created Date:Friday, December 13, 2019
    //-----------------------------------------------------------

    public class HREmployeeSalaryEvaluationsInfo : BusinessObject
    {
        public HREmployeeSalaryEvaluationsInfo()
        {
        }
        #region Variables
        protected int _hREmployeeSalaryEvaluationID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HRSalaryEvaluationID;
        protected DateTime _hREmployeeSalaryEvaluationIncurredDate = DateTime.MaxValue;
        protected decimal _hREmployeeSalaryEvaluationSlrAmtBefore;
        protected decimal _hREmployeeSalaryEvaluationWorkingSlrAmtBefore;
        protected decimal _hREmployeeSalaryEvaluationSlrAmtAfter;
        protected decimal _hREmployeeSalaryEvaluationWorkingSlrAmtAfter;
        protected decimal _hREmployeeSalaryEvaluationSlrAmtIncrease;
        protected decimal _hREmployeeSalaryEvaluationWorkingSlrAmtIncrease;
        protected decimal _hREmployeeSalaryEvaluationSlrAmtPercent;
        protected decimal _hREmployeeSalaryEvaluationWorkingSlrAmtPercent;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HREmployeeID;
        protected decimal _hREmployeeSeniorityYear;

        #endregion

        #region Public properties
        public int HREmployeeSalaryEvaluationID
        {
            get { return _hREmployeeSalaryEvaluationID; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationID)
                {
                    _hREmployeeSalaryEvaluationID = value;
                    NotifyChanged("HREmployeeSalaryEvaluationID");
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
        public int FK_HRSalaryEvaluationID
        {
            get { return _fK_HRSalaryEvaluationID; }
            set
            {
                if (value != this._fK_HRSalaryEvaluationID)
                {
                    _fK_HRSalaryEvaluationID = value;
                    NotifyChanged("FK_HRSalaryEvaluationID");
                }
            }
        }
        public DateTime HREmployeeSalaryEvaluationIncurredDate
        {
            get { return _hREmployeeSalaryEvaluationIncurredDate; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationIncurredDate)
                {
                    _hREmployeeSalaryEvaluationIncurredDate = value;
                    NotifyChanged("HREmployeeSalaryEvaluationIncurredDate");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationSlrAmtBefore
        {
            get { return _hREmployeeSalaryEvaluationSlrAmtBefore; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationSlrAmtBefore)
                {
                    _hREmployeeSalaryEvaluationSlrAmtBefore = value;
                    NotifyChanged("HREmployeeSalaryEvaluationSlrAmtBefore");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationWorkingSlrAmtBefore
        {
            get { return _hREmployeeSalaryEvaluationWorkingSlrAmtBefore; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationWorkingSlrAmtBefore)
                {
                    _hREmployeeSalaryEvaluationWorkingSlrAmtBefore = value;
                    NotifyChanged("HREmployeeSalaryEvaluationWorkingSlrAmtBefore");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationSlrAmtAfter
        {
            get { return _hREmployeeSalaryEvaluationSlrAmtAfter; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationSlrAmtAfter)
                {
                    _hREmployeeSalaryEvaluationSlrAmtAfter = value;
                    NotifyChanged("HREmployeeSalaryEvaluationSlrAmtAfter");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationWorkingSlrAmtAfter
        {
            get { return _hREmployeeSalaryEvaluationWorkingSlrAmtAfter; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationWorkingSlrAmtAfter)
                {
                    _hREmployeeSalaryEvaluationWorkingSlrAmtAfter = value;
                    NotifyChanged("HREmployeeSalaryEvaluationWorkingSlrAmtAfter");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationSlrAmtIncrease
        {
            get { return _hREmployeeSalaryEvaluationSlrAmtIncrease; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationSlrAmtIncrease)
                {
                    _hREmployeeSalaryEvaluationSlrAmtIncrease = value;
                    NotifyChanged("HREmployeeSalaryEvaluationSlrAmtIncrease");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationWorkingSlrAmtIncrease
        {
            get { return _hREmployeeSalaryEvaluationWorkingSlrAmtIncrease; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationWorkingSlrAmtIncrease)
                {
                    _hREmployeeSalaryEvaluationWorkingSlrAmtIncrease = value;
                    NotifyChanged("HREmployeeSalaryEvaluationWorkingSlrAmtIncrease");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationSlrAmtPercent
        {
            get { return _hREmployeeSalaryEvaluationSlrAmtPercent; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationSlrAmtPercent)
                {
                    _hREmployeeSalaryEvaluationSlrAmtPercent = value;
                    NotifyChanged("HREmployeeSalaryEvaluationSlrAmtPercent");
                }
            }
        }
        public decimal HREmployeeSalaryEvaluationWorkingSlrAmtPercent
        {
            get { return _hREmployeeSalaryEvaluationWorkingSlrAmtPercent; }
            set
            {
                if (value != this._hREmployeeSalaryEvaluationWorkingSlrAmtPercent)
                {
                    _hREmployeeSalaryEvaluationWorkingSlrAmtPercent = value;
                    NotifyChanged("HREmployeeSalaryEvaluationWorkingSlrAmtPercent");
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
        public decimal HREmployeeSeniorityYear
        {
            get { return _hREmployeeSeniorityYear; }
            set
            {
                if (value != this._hREmployeeSeniorityYear)
                {
                    _hREmployeeSeniorityYear = value;
                    NotifyChanged("HREmployeeSeniorityYear");
                }
            }
        }

        #endregion

        #region Extra properties
        public string HREmployeeNo { get; set; }
        public string HREmployeeName { get; set; }
        public DateTime HREmployeeStartWorkingDate { get; set; }
        #endregion
    }
    #endregion
}