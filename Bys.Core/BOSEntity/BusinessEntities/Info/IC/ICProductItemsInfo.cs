﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductItemsInfo
    //Created Date:Tuesday, October 20, 2015
    //-----------------------------------------------------------

    public class ICProductItemsInfo : BOSTreeListObject
    {
        public ICProductItemsInfo()
        {
        }
        #region Variables
        protected int _iCProductItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductItemParentID;
        protected int _fK_ICProductItemChildID;
        protected decimal _iCProductItemQty;
        protected int _iCProductItemSortOrder;
        protected String _iCProductItemDesc = String.Empty;
        protected String _iCProductItemType = String.Empty;
        protected int _fK_ICProductCarcassID;
        protected int _iCProductItemParentID;
        protected int _fK_MMProductionNormID;
        protected int _fK_ICProductDetailID;
        protected String _iCProductItemCode = String.Empty;
        protected String _iCProductionItemParentCode = String.Empty;
        protected string _aACreatedUser = string.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected string _aAUpdatedUser = string.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;

        #endregion

        #region Public properties
        public int ICProductItemID
        {
            get { return _iCProductItemID; }
            set
            {
                if (value != this._iCProductItemID)
                {
                    _iCProductItemID = value;
                    NotifyChanged("ICProductItemID");
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
        public int FK_ICProductItemParentID
        {
            get { return _fK_ICProductItemParentID; }
            set
            {
                if (value != this._fK_ICProductItemParentID)
                {
                    _fK_ICProductItemParentID = value;
                    NotifyChanged("FK_ICProductItemParentID");
                }
            }
        }
        public int FK_ICProductItemChildID
        {
            get { return _fK_ICProductItemChildID; }
            set
            {
                if (value != this._fK_ICProductItemChildID)
                {
                    _fK_ICProductItemChildID = value;
                    NotifyChanged("FK_ICProductItemChildID");
                }
            }
        }
        public decimal ICProductItemQty
        {
            get { return _iCProductItemQty; }
            set
            {
                if (value != this._iCProductItemQty)
                {
                    _iCProductItemQty = value;
                    NotifyChanged("ICProductItemQty");
                }
            }
        }
        public int ICProductItemSortOrder
        {
            get { return _iCProductItemSortOrder; }
            set
            {
                if (value != this._iCProductItemSortOrder)
                {
                    _iCProductItemSortOrder = value;
                    NotifyChanged("ICProductItemSortOrder");
                }
            }
        }
        public String ICProductItemDesc
        {
            get { return _iCProductItemDesc; }
            set
            {
                if (value != this._iCProductItemDesc)
                {
                    _iCProductItemDesc = value;
                    NotifyChanged("ICProductItemDesc");
                }
            }
        }
        public String ICProductItemType
        {
            get { return _iCProductItemType; }
            set
            {
                if (value != this._iCProductItemType)
                {
                    _iCProductItemType = value;
                    NotifyChanged("ICProductItemType");
                }
            }
        }
        public int FK_ICProductCarcassID
        {
            get { return _fK_ICProductCarcassID; }
            set
            {
                if (value != this._fK_ICProductCarcassID)
                {
                    _fK_ICProductCarcassID = value;
                    NotifyChanged("FK_ICProductCarcassID");
                }
            }
        }
        public int ICProductItemParentID
        {
            get { return _iCProductItemParentID; }
            set
            {
                if (value != this._iCProductItemParentID)
                {
                    _iCProductItemParentID = value;
                    NotifyChanged("ICProductItemParentID");
                }
            }
        }
        public int FK_MMProductionNormID
        {
            get { return _fK_MMProductionNormID; }
            set
            {
                if (value != this._fK_MMProductionNormID)
                {
                    _fK_MMProductionNormID = value;
                    NotifyChanged("FK_MMProductionNormID");
                }
            }
        }
        public int FK_ICProductDetailID
        {
            get { return _fK_ICProductDetailID; }
            set
            {
                if (value != this._fK_ICProductDetailID)
                {
                    _fK_ICProductDetailID = value;
                    NotifyChanged("FK_ICProductDetailID");
                }
            }
        }
        public String ICProductItemCode
        {
            get { return _iCProductItemCode; }
            set
            {
                if (value != this._iCProductItemCode)
                {
                    _iCProductItemCode = value;
                    NotifyChanged("ICProductItemCode");
                }
            }
        }
        public String ICProductionItemParentCode
        {
            get { return _iCProductionItemParentCode; }
            set
            {
                if (value != this._iCProductionItemParentCode)
                {
                    _iCProductionItemParentCode = value;
                    NotifyChanged("ICProductionItemParentCode");
                }
            }
        }
        public string AACreatedUser
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
        public string AAUpdatedUser
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
        #endregion

        #region Extra properties
        public string ICProductAbstract { get; set; }
        public string ICProductParentAbstract { get; set; }
        public string ICProductItemProductNo { get; set; }

        public string ICProductItemProductName { get; set; }

        public string ICProductItemProductDesc { get; set; }

        public string ICProductType { get; set; }
        public string ICProductSupplierNo { get; set; }
        public string ICProductDesc { get; set; }
        public string ICProductGroupName { get; set; }
        public string ICDepartmentName { get; set; }
        public string ICProductAttribute { get; set; }
        public String ICProductName { get; set; }
        public String ICProductCode { get; set; }
        public string APSupplierName { get; set; }


        public int FK_ICStockID { get; set; }

        public int FK_ICProductSerieID { get; set; }

        public string ICProductSerialNo { get; set; }

        public int FK_ICProductID { get; set; }

        public int ItemComponentID { get; set; }

        public int ICMeasureUnitID { get; set; }

        public bool ICProductHasComponent { get; set; }
        public decimal ICProductItemTotalQty { get; set; }
        public int FK_ICProductForBatchID { get; set; }
        public string IPProductionItemCode { get; set; }
        public string IPProductItemParentCode { get; set; }
        public decimal ICProductItemChildBlock { get; set; }
        public bool IsError { get; set; }
        #endregion
    }
    #endregion
}