﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARDiscountProgramItemTargets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDiscountProgramItemTargetsInfo
    //Created Date:Tuesday, July 23, 2019
    //-----------------------------------------------------------

    public class ARDiscountProgramItemTargetsInfo : BusinessObject
    {
        public ARDiscountProgramItemTargetsInfo()
        {
        }
        #region Variables
        protected int _aRDiscountProgramItemTargetID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ARDiscountProgramID;
        protected String _aRDiscountProgramItemTargetType = String.Empty;
        protected DateTime _aRDiscountProgramItemTargetFromDate = DateTime.MaxValue;
        protected DateTime _aRDiscountProgramItemTargetToDate = DateTime.MaxValue;
        protected decimal _aRDiscountProgramItemTargetValue;
        protected decimal _aRDiscountProgramItemTargetBonus01;
        protected decimal _aRDiscountProgramItemTargetBonus02;
        protected decimal _aRDiscountProgramItemTargetRate;
        protected String _aRDiscountProgramItemTargetRemark = String.Empty;
        #endregion

        #region Public properties
        public int ARDiscountProgramItemTargetID
        {
            get { return _aRDiscountProgramItemTargetID; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetID)
                {
                    _aRDiscountProgramItemTargetID = value;
                    NotifyChanged("ARDiscountProgramItemTargetID");
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
        public int FK_ARDiscountProgramID
        {
            get { return _fK_ARDiscountProgramID; }
            set
            {
                if (value != this._fK_ARDiscountProgramID)
                {
                    _fK_ARDiscountProgramID = value;
                    NotifyChanged("FK_ARDiscountProgramID");
                }
            }
        }
        public String ARDiscountProgramItemTargetType
        {
            get { return _aRDiscountProgramItemTargetType; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetType)
                {
                    _aRDiscountProgramItemTargetType = value;
                    NotifyChanged("ARDiscountProgramItemTargetType");
                }
            }
        }
        public DateTime ARDiscountProgramItemTargetFromDate
        {
            get { return _aRDiscountProgramItemTargetFromDate; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetFromDate)
                {
                    _aRDiscountProgramItemTargetFromDate = value;
                    NotifyChanged("ARDiscountProgramItemTargetFromDate");
                }
            }
        }
        public DateTime ARDiscountProgramItemTargetToDate
        {
            get { return _aRDiscountProgramItemTargetToDate; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetToDate)
                {
                    _aRDiscountProgramItemTargetToDate = value;
                    NotifyChanged("ARDiscountProgramItemTargetToDate");
                }
            }
        }
        public decimal ARDiscountProgramItemTargetValue
        {
            get { return _aRDiscountProgramItemTargetValue; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetValue)
                {
                    _aRDiscountProgramItemTargetValue = value;
                    NotifyChanged("ARDiscountProgramItemTargetValue");
                }
            }
        }
        public decimal ARDiscountProgramItemTargetBonus01
        {
            get { return _aRDiscountProgramItemTargetBonus01; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetBonus01)
                {
                    _aRDiscountProgramItemTargetBonus01 = value;
                    NotifyChanged("ARDiscountProgramItemTargetBonus01");
                }
            }
        }
        public decimal ARDiscountProgramItemTargetBonus02
        {
            get { return _aRDiscountProgramItemTargetBonus02; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetBonus02)
                {
                    _aRDiscountProgramItemTargetBonus02 = value;
                    NotifyChanged("ARDiscountProgramItemTargetBonus02");
                }
            }
        }
        public decimal ARDiscountProgramItemTargetRate
        {
            get { return _aRDiscountProgramItemTargetRate; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetRate)
                {
                    _aRDiscountProgramItemTargetRate = value;
                    NotifyChanged("ARDiscountProgramItemTargetRate");
                }
            }
        }
        public String ARDiscountProgramItemTargetRemark
        {
            get { return _aRDiscountProgramItemTargetRemark; }
            set
            {
                if (value != this._aRDiscountProgramItemTargetRemark)
                {
                    _aRDiscountProgramItemTargetRemark = value;
                    NotifyChanged("ARDiscountProgramItemTargetRemark");
                }
            }
        }
        #endregion
    }
    #endregion
}