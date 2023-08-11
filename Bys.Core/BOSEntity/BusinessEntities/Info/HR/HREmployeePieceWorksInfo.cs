﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeePieceWorks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeePieceWorksInfo
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HREmployeePieceWorksInfo : BusinessObject
    {
        public HREmployeePieceWorksInfo()
        {
        }
        #region Variables
        protected int _hREmployeePieceWorkID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected decimal _hREmployeePieceWorkAmount;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductID;
        protected int _fK_MMOperationID;
        protected DateTime _hREmployeePieceWorkFromDate = DateTime.MaxValue;
        protected DateTime _hREmployeePieceWorkToDate = DateTime.MaxValue;
        protected decimal _hREmployeePieceWorkQuantity;
        protected String _hREmployeePieceWorkRemark = String.Empty;
        protected String _hREmployeePieceWorkNo = String.Empty;
        protected int _fK_ADMatchCodeBatchComponent;
        #endregion

        #region Public properties
        public int HREmployeePieceWorkID
        {
            get { return _hREmployeePieceWorkID; }
            set
            {
                if (value != this._hREmployeePieceWorkID)
                {
                    _hREmployeePieceWorkID = value;
                    NotifyChanged("HREmployeePieceWorkID");
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
        public decimal HREmployeePieceWorkAmount
        {
            get { return _hREmployeePieceWorkAmount; }
            set
            {
                if (value != this._hREmployeePieceWorkAmount)
                {
                    _hREmployeePieceWorkAmount = value;
                    NotifyChanged("HREmployeePieceWorkAmount");
                }
            }
        }
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
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
        public DateTime HREmployeePieceWorkFromDate
        {
            get { return _hREmployeePieceWorkFromDate; }
            set
            {
                if (value != this._hREmployeePieceWorkFromDate)
                {
                    _hREmployeePieceWorkFromDate = value;
                    NotifyChanged("HREmployeePieceWorkFromDate");
                }
            }
        }
        public DateTime HREmployeePieceWorkToDate
        {
            get { return _hREmployeePieceWorkToDate; }
            set
            {
                if (value != this._hREmployeePieceWorkToDate)
                {
                    _hREmployeePieceWorkToDate = value;
                    NotifyChanged("HREmployeePieceWorkToDate");
                }
            }
        }
        public decimal HREmployeePieceWorkQuantity
        {
            get { return _hREmployeePieceWorkQuantity; }
            set
            {
                if (value != this._hREmployeePieceWorkQuantity)
                {
                    _hREmployeePieceWorkQuantity = value;
                    NotifyChanged("HREmployeePieceWorkQuantity");
                }
            }
        }
        public String HREmployeePieceWorkRemark
        {
            get { return _hREmployeePieceWorkRemark; }
            set
            {
                if (value != this._hREmployeePieceWorkRemark)
                {
                    _hREmployeePieceWorkRemark = value;
                    NotifyChanged("HREmployeePieceWorkRemark");
                }
            }
        }
        public String HREmployeePieceWorkNo
        {
            get { return _hREmployeePieceWorkNo; }
            set
            {
                if (value != this._hREmployeePieceWorkNo)
                {
                    _hREmployeePieceWorkNo = value;
                    NotifyChanged("HREmployeePieceWorkNo");
                }
            }
        }
        public int FK_ADMatchCodeBatchComponent
        {
            get { return _fK_ADMatchCodeBatchComponent; }
            set
            {
                if (value != this._fK_ADMatchCodeBatchComponent)
                {
                    _fK_ADMatchCodeBatchComponent = value;
                    NotifyChanged("FK_ADMatchCodeBatchComponent");
                }
            }
        }
        #endregion
    }
    #endregion
}