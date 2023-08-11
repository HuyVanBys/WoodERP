﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICPriceAdjustmentItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICPriceAdjustmentItemsInfo
    //Created Date:Friday, September 16, 2016
    //-----------------------------------------------------------

    public class ICPriceAdjustmentItemsInfo : ERPModuleItemsEntity
    {
        public ICPriceAdjustmentItemsInfo()
        {
        }
        #region Variables
        protected int _iCPriceAdjustmentItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_ICPriceAdjustmentID;
        protected int _fK_ICReceiptID;
        protected int _fK_ICReceiptItemID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _iCPriceAdjustmentItemProductType = String.Empty;
        protected String _iCPriceAdjustmentItemProductName = String.Empty;
        protected String _iCPriceAdjustmentItemProductDesc = String.Empty;
        protected decimal _iCPriceAdjustmentItemProductUnitCost;
        protected decimal _iCPriceAdjustmentItemProductQty;
        protected String _iCPriceAdjustmentItemComment = String.Empty;
        protected decimal _iCPriceAdjustmentItemTotalCost;
        protected int _fK_ICStockID;
        protected int _fK_ICProductSerieID;
        protected int _fK_ICInventoryStockID;
        protected decimal _iCPriceAdjustmentItemInventoryCostOld;
        protected decimal _iCPriceAdjustmentItemInventoryCostNew;
        #endregion

        #region Public properties
        public int ICPriceAdjustmentItemID
        {
            get { return _iCPriceAdjustmentItemID; }
            set
            {
                if (value != this._iCPriceAdjustmentItemID)
                {
                    _iCPriceAdjustmentItemID = value;
                    NotifyChanged("ICPriceAdjustmentItemID");
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
        public int FK_ICPriceAdjustmentID
        {
            get { return _fK_ICPriceAdjustmentID; }
            set
            {
                if (value != this._fK_ICPriceAdjustmentID)
                {
                    _fK_ICPriceAdjustmentID = value;
                    NotifyChanged("FK_ICPriceAdjustmentID");
                }
            }
        }
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                    NotifyChanged("FK_ICReceiptID");
                }
            }
        }
        public int FK_ICReceiptItemID
        {
            get { return _fK_ICReceiptItemID; }
            set
            {
                if (value != this._fK_ICReceiptItemID)
                {
                    _fK_ICReceiptItemID = value;
                    NotifyChanged("FK_ICReceiptItemID");
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
        public String ICPriceAdjustmentItemProductType
        {
            get { return _iCPriceAdjustmentItemProductType; }
            set
            {
                if (value != this._iCPriceAdjustmentItemProductType)
                {
                    _iCPriceAdjustmentItemProductType = value;
                    NotifyChanged("ICPriceAdjustmentItemProductType");
                }
            }
        }
        public String ICPriceAdjustmentItemProductName
        {
            get { return _iCPriceAdjustmentItemProductName; }
            set
            {
                if (value != this._iCPriceAdjustmentItemProductName)
                {
                    _iCPriceAdjustmentItemProductName = value;
                    NotifyChanged("ICPriceAdjustmentItemProductName");
                }
            }
        }
        public String ICPriceAdjustmentItemProductDesc
        {
            get { return _iCPriceAdjustmentItemProductDesc; }
            set
            {
                if (value != this._iCPriceAdjustmentItemProductDesc)
                {
                    _iCPriceAdjustmentItemProductDesc = value;
                    NotifyChanged("ICPriceAdjustmentItemProductDesc");
                }
            }
        }
        public decimal ICPriceAdjustmentItemProductUnitCost
        {
            get { return _iCPriceAdjustmentItemProductUnitCost; }
            set
            {
                if (value != this._iCPriceAdjustmentItemProductUnitCost)
                {
                    _iCPriceAdjustmentItemProductUnitCost = value;
                    NotifyChanged("ICPriceAdjustmentItemProductUnitCost");
                }
            }
        }
        public decimal ICPriceAdjustmentItemProductQty
        {
            get { return _iCPriceAdjustmentItemProductQty; }
            set
            {
                if (value != this._iCPriceAdjustmentItemProductQty)
                {
                    _iCPriceAdjustmentItemProductQty = value;
                    NotifyChanged("ICPriceAdjustmentItemProductQty");
                }
            }
        }
        public String ICPriceAdjustmentItemComment
        {
            get { return _iCPriceAdjustmentItemComment; }
            set
            {
                if (value != this._iCPriceAdjustmentItemComment)
                {
                    _iCPriceAdjustmentItemComment = value;
                    NotifyChanged("ICPriceAdjustmentItemComment");
                }
            }
        }
        public decimal ICPriceAdjustmentItemTotalCost
        {
            get { return _iCPriceAdjustmentItemTotalCost; }
            set
            {
                if (value != this._iCPriceAdjustmentItemTotalCost)
                {
                    _iCPriceAdjustmentItemTotalCost = value;
                    NotifyChanged("ICPriceAdjustmentItemTotalCost");
                }
            }
        }
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
                }
            }
        }
        public int FK_ICProductSerieID
        {
            get { return _fK_ICProductSerieID; }
            set
            {
                if (value != this._fK_ICProductSerieID)
                {
                    _fK_ICProductSerieID = value;
                    NotifyChanged("FK_ICProductSerieID");
                }
            }
        }
        public int FK_ICInventoryStockID
        {
            get { return _fK_ICInventoryStockID; }
            set
            {
                if (value != this._fK_ICInventoryStockID)
                {
                    _fK_ICInventoryStockID = value;
                    NotifyChanged("FK_ICInventoryStockID");
                }
            }
        }
        public decimal ICPriceAdjustmentItemInventoryCostOld
        {
            get { return _iCPriceAdjustmentItemInventoryCostOld; }
            set
            {
                if (value != this._iCPriceAdjustmentItemInventoryCostOld)
                {
                    _iCPriceAdjustmentItemInventoryCostOld = value;
                    NotifyChanged("ICPriceAdjustmentItemInventoryCostOld");
                }
            }
        }
        public decimal ICPriceAdjustmentItemInventoryCostNew
        {
            get { return _iCPriceAdjustmentItemInventoryCostNew; }
            set
            {
                if (value != this._iCPriceAdjustmentItemInventoryCostNew)
                {
                    _iCPriceAdjustmentItemInventoryCostNew = value;
                    NotifyChanged("ICPriceAdjustmentItemInventoryCostNew");
                }
            }
        }
        #endregion
    }
    #endregion
}