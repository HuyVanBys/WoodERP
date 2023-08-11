﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARPriceSheetItemWorks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARPriceSheetItemWorksInfo
    //Created Date:02 Tháng Mười 2018
    //-----------------------------------------------------------

    public class ARPriceSheetItemWorksInfo : BusinessObject
    {
        public ARPriceSheetItemWorksInfo()
        {
        }
        #region Variables
        protected int _aRPriceSheetItemWorkID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ARPriceSheetItemID;
        protected int _fK_ARPriceSheetID;
        protected String _aRPriceSheetItemWorkProductNo = String.Empty;
        protected String _aRPriceSheetItemWorkProductName = String.Empty;
        protected String _aRPriceSheetItemWorkProductDesc = String.Empty;
        protected decimal _aRPriceSheetItemWorkProductQty;
        protected String _aRPriceSheetItemWorkProductType = String.Empty;
        protected decimal _aRPriceSheetItemWorkProductUnitPrice;
        protected decimal _aRPriceSheetItemWorkTotalAmount;
        protected decimal _aRPriceSheetItemWorkSubTotalAmount;
        protected bool _aRPriceSheetItemWorkProductChargeCheck = true;
        protected String _aRPriceSheetItemWorkStatus = DefaultStatus;
        protected String _aRPriceSheetItemWorkType = String.Empty;
        protected int _aRPriceSheetItemWorkParentID;
        protected String _aRPriceSheetItemWorkComment = String.Empty;
        protected decimal _aRPriceSheetItemWorkDiscountAmount;
        protected decimal _aRPriceSheetItemWorkDiscountPerCent;
        #endregion

        #region Public properties
        public int ARPriceSheetItemWorkID
        {
            get { return _aRPriceSheetItemWorkID; }
            set
            {
                if (value != this._aRPriceSheetItemWorkID)
                {
                    _aRPriceSheetItemWorkID = value;
                    NotifyChanged("ARPriceSheetItemWorkID");
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
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                    NotifyChanged("FK_ICProductGroupID");
                }
            }
        }
        public int FK_ICDepartmentID
        {
            get { return _fK_ICDepartmentID; }
            set
            {
                if (value != this._fK_ICDepartmentID)
                {
                    _fK_ICDepartmentID = value;
                    NotifyChanged("FK_ICDepartmentID");
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
        public int FK_ARPriceSheetItemID
        {
            get { return _fK_ARPriceSheetItemID; }
            set
            {
                if (value != this._fK_ARPriceSheetItemID)
                {
                    _fK_ARPriceSheetItemID = value;
                    NotifyChanged("FK_ARPriceSheetItemID");
                }
            }
        }
        public int FK_ARPriceSheetID
        {
            get { return _fK_ARPriceSheetID; }
            set
            {
                if (value != this._fK_ARPriceSheetID)
                {
                    _fK_ARPriceSheetID = value;
                    NotifyChanged("FK_ARPriceSheetID");
                }
            }
        }
        public String ARPriceSheetItemWorkProductNo
        {
            get { return _aRPriceSheetItemWorkProductNo; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductNo)
                {
                    _aRPriceSheetItemWorkProductNo = value;
                    NotifyChanged("ARPriceSheetItemWorkProductNo");
                }
            }
        }
        public String ARPriceSheetItemWorkProductName
        {
            get { return _aRPriceSheetItemWorkProductName; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductName)
                {
                    _aRPriceSheetItemWorkProductName = value;
                    NotifyChanged("ARPriceSheetItemWorkProductName");
                }
            }
        }
        public String ARPriceSheetItemWorkProductDesc
        {
            get { return _aRPriceSheetItemWorkProductDesc; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductDesc)
                {
                    _aRPriceSheetItemWorkProductDesc = value;
                    NotifyChanged("ARPriceSheetItemWorkProductDesc");
                }
            }
        }
        public decimal ARPriceSheetItemWorkProductQty
        {
            get { return _aRPriceSheetItemWorkProductQty; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductQty)
                {
                    _aRPriceSheetItemWorkProductQty = value;
                    NotifyChanged("ARPriceSheetItemWorkProductQty");
                }
            }
        }
        public String ARPriceSheetItemWorkProductType
        {
            get { return _aRPriceSheetItemWorkProductType; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductType)
                {
                    _aRPriceSheetItemWorkProductType = value;
                    NotifyChanged("ARPriceSheetItemWorkProductType");
                }
            }
        }
        public decimal ARPriceSheetItemWorkProductUnitPrice
        {
            get { return _aRPriceSheetItemWorkProductUnitPrice; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductUnitPrice)
                {
                    _aRPriceSheetItemWorkProductUnitPrice = value;
                    NotifyChanged("ARPriceSheetItemWorkProductUnitPrice");
                }
            }
        }
        public decimal ARPriceSheetItemWorkTotalAmount
        {
            get { return _aRPriceSheetItemWorkTotalAmount; }
            set
            {
                if (value != this._aRPriceSheetItemWorkTotalAmount)
                {
                    _aRPriceSheetItemWorkTotalAmount = value;
                    NotifyChanged("ARPriceSheetItemWorkTotalAmount");
                }
            }
        }
        public decimal ARPriceSheetItemWorkSubTotalAmount
        {
            get { return _aRPriceSheetItemWorkSubTotalAmount; }
            set
            {
                if (value != this._aRPriceSheetItemWorkSubTotalAmount)
                {
                    _aRPriceSheetItemWorkSubTotalAmount = value;
                    NotifyChanged("ARPriceSheetItemWorkSubTotalAmount");
                }
            }
        }
        public bool ARPriceSheetItemWorkProductChargeCheck
        {
            get { return _aRPriceSheetItemWorkProductChargeCheck; }
            set
            {
                if (value != this._aRPriceSheetItemWorkProductChargeCheck)
                {
                    _aRPriceSheetItemWorkProductChargeCheck = value;
                    NotifyChanged("ARPriceSheetItemWorkProductChargeCheck");
                }
            }
        }
        public String ARPriceSheetItemWorkStatus
        {
            get { return _aRPriceSheetItemWorkStatus; }
            set
            {
                if (value != this._aRPriceSheetItemWorkStatus)
                {
                    _aRPriceSheetItemWorkStatus = value;
                    NotifyChanged("ARPriceSheetItemWorkStatus");
                }
            }
        }
        public String ARPriceSheetItemWorkType
        {
            get { return _aRPriceSheetItemWorkType; }
            set
            {
                if (value != this._aRPriceSheetItemWorkType)
                {
                    _aRPriceSheetItemWorkType = value;
                    NotifyChanged("ARPriceSheetItemWorkType");
                }
            }
        }
        public int ARPriceSheetItemWorkParentID
        {
            get { return _aRPriceSheetItemWorkParentID; }
            set
            {
                if (value != this._aRPriceSheetItemWorkParentID)
                {
                    _aRPriceSheetItemWorkParentID = value;
                    NotifyChanged("ARPriceSheetItemWorkParentID");
                }
            }
        }
        public String ARPriceSheetItemWorkComment
        {
            get { return _aRPriceSheetItemWorkComment; }
            set
            {
                if (value != this._aRPriceSheetItemWorkComment)
                {
                    _aRPriceSheetItemWorkComment = value;
                    NotifyChanged("ARPriceSheetItemWorkComment");
                }
            }
        }
        public decimal ARPriceSheetItemWorkDiscountAmount
        {
            get { return _aRPriceSheetItemWorkDiscountAmount; }
            set
            {
                if (value != this._aRPriceSheetItemWorkDiscountAmount)
                {
                    _aRPriceSheetItemWorkDiscountAmount = value;
                    NotifyChanged("ARPriceSheetItemWorkDiscountAmount");
                }
            }
        }
        public decimal ARPriceSheetItemWorkDiscountPerCent
        {
            get { return _aRPriceSheetItemWorkDiscountPerCent; }
            set
            {
                if (value != this._aRPriceSheetItemWorkDiscountPerCent)
                {
                    _aRPriceSheetItemWorkDiscountPerCent = value;
                    NotifyChanged("ARPriceSheetItemWorkDiscountPerCent");
                }
            }
        }
        #endregion
        #region extra properties
        public string ARRowNumber { get; set; }
        public String ICMeasureUnitName { get; set; }
        public String ICDepartmentName { get; set; }
        public int GroupIndex { get; set; }

        #endregion
    }
    #endregion
}