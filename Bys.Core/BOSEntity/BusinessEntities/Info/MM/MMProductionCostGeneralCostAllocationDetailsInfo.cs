﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductionCostGeneralCostAllocationDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostGeneralCostAllocationDetailsInfo
    //Created Date:Tuesday, September 25, 2018
    //-----------------------------------------------------------

    public class MMProductionCostGeneralCostAllocationDetailsInfo : BusinessObject
    {
        public MMProductionCostGeneralCostAllocationDetailsInfo()
        {
        }
        #region Variables
        protected int _mMProductionCostGeneralCostAllocationDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_MMProductionCostGeneralCostAllocationID;
        protected int _fK_HRDepartmentID;
        protected int _fK_MMOperationID;
        protected decimal _mMProductionCostGeneralCostAllocationDetailRateValue;
        protected decimal _mMProductionCostGeneralCostAllocationDetailAmount;
        #endregion

        #region Public properties
        public int MMProductionCostGeneralCostAllocationDetailID
        {
            get { return _mMProductionCostGeneralCostAllocationDetailID; }
            set
            {
                if (value != this._mMProductionCostGeneralCostAllocationDetailID)
                {
                    _mMProductionCostGeneralCostAllocationDetailID = value;
                    NotifyChanged("MMProductionCostGeneralCostAllocationDetailID");
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
        public int FK_MMProductionCostGeneralCostAllocationID
        {
            get { return _fK_MMProductionCostGeneralCostAllocationID; }
            set
            {
                if (value != this._fK_MMProductionCostGeneralCostAllocationID)
                {
                    _fK_MMProductionCostGeneralCostAllocationID = value;
                    NotifyChanged("FK_MMProductionCostGeneralCostAllocationID");
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
        public decimal MMProductionCostGeneralCostAllocationDetailRateValue
        {
            get { return _mMProductionCostGeneralCostAllocationDetailRateValue; }
            set
            {
                if (value != this._mMProductionCostGeneralCostAllocationDetailRateValue)
                {
                    _mMProductionCostGeneralCostAllocationDetailRateValue = value;
                    NotifyChanged("MMProductionCostGeneralCostAllocationDetailRateValue");
                }
            }
        }
        public decimal MMProductionCostGeneralCostAllocationDetailAmount
        {
            get { return _mMProductionCostGeneralCostAllocationDetailAmount; }
            set
            {
                if (value != this._mMProductionCostGeneralCostAllocationDetailAmount)
                {
                    _mMProductionCostGeneralCostAllocationDetailAmount = value;
                    NotifyChanged("MMProductionCostGeneralCostAllocationDetailAmount");
                }
            }
        }
        #endregion
    }
    #endregion
}