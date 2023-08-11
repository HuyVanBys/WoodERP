﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMOperationDetailPlanItemChildDateDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMOperationDetailPlanItemChildDateDetailsInfo
    //Created Date:Monday, August 15, 2016
    //-----------------------------------------------------------

    public class MMOperationDetailPlanItemChildDateDetailsInfo : BusinessObject
    {
        public MMOperationDetailPlanItemChildDateDetailsInfo()
        {
        }
        #region Variables
        protected int _mMOperationDetailPlanItemChildDateDetailID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMOperationDetailPlanItemChildID;
        protected decimal _mMOperationDetailPlanItemChildDateDetailPlanProductQty;
        protected decimal _mMOperationDetailPlanItemChildDateDetailPlanBlock;
        protected DateTime _mMOperationDetailPlanItemChildDateDetailPlanDate = DateTime.MaxValue;
        #endregion

        #region Public properties
        public int MMOperationDetailPlanItemChildDateDetailID
        {
            get { return _mMOperationDetailPlanItemChildDateDetailID; }
            set
            {
                if (value != this._mMOperationDetailPlanItemChildDateDetailID)
                {
                    _mMOperationDetailPlanItemChildDateDetailID = value;
                    NotifyChanged("MMOperationDetailPlanItemChildDateDetailID");
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
        public int FK_MMOperationDetailPlanItemChildID
        {
            get { return _fK_MMOperationDetailPlanItemChildID; }
            set
            {
                if (value != this._fK_MMOperationDetailPlanItemChildID)
                {
                    _fK_MMOperationDetailPlanItemChildID = value;
                    NotifyChanged("FK_MMOperationDetailPlanItemChildID");
                }
            }
        }
        public decimal MMOperationDetailPlanItemChildDateDetailPlanProductQty
        {
            get { return _mMOperationDetailPlanItemChildDateDetailPlanProductQty; }
            set
            {
                if (value != this._mMOperationDetailPlanItemChildDateDetailPlanProductQty)
                {
                    _mMOperationDetailPlanItemChildDateDetailPlanProductQty = value;
                    NotifyChanged("MMOperationDetailPlanItemChildDateDetailPlanProductQty");
                }
            }
        }
        public decimal MMOperationDetailPlanItemChildDateDetailPlanBlock
        {
            get { return _mMOperationDetailPlanItemChildDateDetailPlanBlock; }
            set
            {
                if (value != this._mMOperationDetailPlanItemChildDateDetailPlanBlock)
                {
                    _mMOperationDetailPlanItemChildDateDetailPlanBlock = value;
                    NotifyChanged("MMOperationDetailPlanItemChildDateDetailPlanBlock");
                }
            }
        }
        public DateTime MMOperationDetailPlanItemChildDateDetailPlanDate
        {
            get { return _mMOperationDetailPlanItemChildDateDetailPlanDate; }
            set
            {
                if (value != this._mMOperationDetailPlanItemChildDateDetailPlanDate)
                {
                    _mMOperationDetailPlanItemChildDateDetailPlanDate = value;
                    NotifyChanged("MMOperationDetailPlanItemChildDateDetailPlanDate");
                }
            }
        }
        #endregion
    }
    #endregion
}