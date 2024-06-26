﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductOutsourcings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductOutsourcingsInfo
    //Created Date:15 Tháng Mười Một 2018
    //-----------------------------------------------------------

    public class ICProductOutsourcingsInfo : BusinessObject
    {
        public ICProductOutsourcingsInfo()
        {
        }
        #region Variables
        protected int _iCProductOutsourcingID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductOutsourcingChildID;
        protected int _fK_ICProductOutsourcingParentID;
        protected int _fK_ICMeasureUnitID;
        protected String _iCProductOutsourcingProductNo = String.Empty;
        protected String _iCProductOutsourcingProductName = String.Empty;
        protected String _iCProductOutsourcingProductDesc = String.Empty;
        protected String _iCProductOutsourcingRemark = String.Empty;
        protected decimal _iCProductOutsourcingProductQty;
        protected int _iCProductOutsourcingSortOrder;
        #endregion

        #region Public properties
        public int ICProductOutsourcingID
        {
            get { return _iCProductOutsourcingID; }
            set
            {
                if (value != this._iCProductOutsourcingID)
                {
                    _iCProductOutsourcingID = value;
                    NotifyChanged("ICProductOutsourcingID");
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
        public int FK_ICProductOutsourcingChildID
        {
            get { return _fK_ICProductOutsourcingChildID; }
            set
            {
                if (value != this._fK_ICProductOutsourcingChildID)
                {
                    _fK_ICProductOutsourcingChildID = value;
                    NotifyChanged("FK_ICProductOutsourcingChildID");
                }
            }
        }
        public int FK_ICProductOutsourcingParentID
        {
            get { return _fK_ICProductOutsourcingParentID; }
            set
            {
                if (value != this._fK_ICProductOutsourcingParentID)
                {
                    _fK_ICProductOutsourcingParentID = value;
                    NotifyChanged("FK_ICProductOutsourcingParentID");
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
        public String ICProductOutsourcingProductNo
        {
            get { return _iCProductOutsourcingProductNo; }
            set
            {
                if (value != this._iCProductOutsourcingProductNo)
                {
                    _iCProductOutsourcingProductNo = value;
                    NotifyChanged("ICProductOutsourcingProductNo");
                }
            }
        }
        public String ICProductOutsourcingProductName
        {
            get { return _iCProductOutsourcingProductName; }
            set
            {
                if (value != this._iCProductOutsourcingProductName)
                {
                    _iCProductOutsourcingProductName = value;
                    NotifyChanged("ICProductOutsourcingProductName");
                }
            }
        }
        public String ICProductOutsourcingProductDesc
        {
            get { return _iCProductOutsourcingProductDesc; }
            set
            {
                if (value != this._iCProductOutsourcingProductDesc)
                {
                    _iCProductOutsourcingProductDesc = value;
                    NotifyChanged("ICProductOutsourcingProductDesc");
                }
            }
        }
        public String ICProductOutsourcingRemark
        {
            get { return _iCProductOutsourcingRemark; }
            set
            {
                if (value != this._iCProductOutsourcingRemark)
                {
                    _iCProductOutsourcingRemark = value;
                    NotifyChanged("ICProductOutsourcingRemark");
                }
            }
        }
        public decimal ICProductOutsourcingProductQty
        {
            get { return _iCProductOutsourcingProductQty; }
            set
            {
                if (value != this._iCProductOutsourcingProductQty)
                {
                    _iCProductOutsourcingProductQty = value;
                    NotifyChanged("ICProductOutsourcingProductQty");
                }
            }
        }
        public int ICProductOutsourcingSortOrder
        {
            get { return _iCProductOutsourcingSortOrder; }
            set
            {
                if (value != this._iCProductOutsourcingSortOrder)
                {
                    _iCProductOutsourcingSortOrder = value;
                    NotifyChanged("ICProductOutsourcingSortOrder");
                }
            }
        }
        #endregion

        #region Extra Properties

        public int FK_ICDepartmentID { get; set; }

        public int FK_ICProductGroupID { get; set; }

        public string ICProductType { get; set; }

        public string ICProductNoOfOldSys { get; set; }
        #endregion
    }
    #endregion
}