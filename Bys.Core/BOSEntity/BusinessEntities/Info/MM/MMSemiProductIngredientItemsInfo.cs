﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMSemiProductIngredientItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMSemiProductIngredientItemsInfo
    //Created Date:Saturday, August 13, 2016
    //-----------------------------------------------------------

    public class MMSemiProductIngredientItemsInfo : BusinessObject
    {
        public MMSemiProductIngredientItemsInfo()
        {
        }
        #region Variables
        protected int _mMSemiProductIngredientItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMProductionCostID;
        protected int _fK_MMSemiProductIngredientID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMOperationID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductGroupID;
        protected int _fK_MMProductionCostIngredientCostID;
        protected String _mMSemiProductIngredientItemProductNo = String.Empty;
        protected String _mMSemiProductIngredientItemProductName = String.Empty;
        protected String _mMSemiProductIngredientItemProductDesc = String.Empty;
        protected String _mMSemiProductIngredientItemComment = String.Empty;
        protected decimal _mMSemiProductIngredientItemProductQty;
        protected decimal _mMSemiProductIngredientItemProductWoodQty;
        protected decimal _mMSemiProductIngredientItemProductUnitPrice;
        protected decimal _mMSemiProductIngredientItemProductTotalAmount;
        #endregion

        #region Public properties
        public int MMSemiProductIngredientItemID
        {
            get { return _mMSemiProductIngredientItemID; }
            set
            {
                if (value != this._mMSemiProductIngredientItemID)
                {
                    _mMSemiProductIngredientItemID = value;
                    NotifyChanged("MMSemiProductIngredientItemID");
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
        public int FK_MMProductionCostID
        {
            get { return _fK_MMProductionCostID; }
            set
            {
                if (value != this._fK_MMProductionCostID)
                {
                    _fK_MMProductionCostID = value;
                    NotifyChanged("FK_MMProductionCostID");
                }
            }
        }
        public int FK_MMSemiProductIngredientID
        {
            get { return _fK_MMSemiProductIngredientID; }
            set
            {
                if (value != this._fK_MMSemiProductIngredientID)
                {
                    _fK_MMSemiProductIngredientID = value;
                    NotifyChanged("FK_MMSemiProductIngredientID");
                }
            }
        }
        public int FK_MMBatchProductID
        {
            get { return _fK_MMBatchProductID; }
            set
            {
                if (value != this._fK_MMBatchProductID)
                {
                    _fK_MMBatchProductID = value;
                    NotifyChanged("FK_MMBatchProductID");
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
        public int FK_MMProductionCostIngredientCostID
        {
            get { return _fK_MMProductionCostIngredientCostID; }
            set
            {
                if (value != this._fK_MMProductionCostIngredientCostID)
                {
                    _fK_MMProductionCostIngredientCostID = value;
                    NotifyChanged("FK_MMProductionCostIngredientCostID");
                }
            }
        }
        public String MMSemiProductIngredientItemProductNo
        {
            get { return _mMSemiProductIngredientItemProductNo; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductNo)
                {
                    _mMSemiProductIngredientItemProductNo = value;
                    NotifyChanged("MMSemiProductIngredientItemProductNo");
                }
            }
        }
        public String MMSemiProductIngredientItemProductName
        {
            get { return _mMSemiProductIngredientItemProductName; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductName)
                {
                    _mMSemiProductIngredientItemProductName = value;
                    NotifyChanged("MMSemiProductIngredientItemProductName");
                }
            }
        }
        public String MMSemiProductIngredientItemProductDesc
        {
            get { return _mMSemiProductIngredientItemProductDesc; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductDesc)
                {
                    _mMSemiProductIngredientItemProductDesc = value;
                    NotifyChanged("MMSemiProductIngredientItemProductDesc");
                }
            }
        }
        public String MMSemiProductIngredientItemComment
        {
            get { return _mMSemiProductIngredientItemComment; }
            set
            {
                if (value != this._mMSemiProductIngredientItemComment)
                {
                    _mMSemiProductIngredientItemComment = value;
                    NotifyChanged("MMSemiProductIngredientItemComment");
                }
            }
        }
        public decimal MMSemiProductIngredientItemProductQty
        {
            get { return _mMSemiProductIngredientItemProductQty; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductQty)
                {
                    _mMSemiProductIngredientItemProductQty = value;
                    NotifyChanged("MMSemiProductIngredientItemProductQty");
                }
            }
        }
        public decimal MMSemiProductIngredientItemProductWoodQty
        {
            get { return _mMSemiProductIngredientItemProductWoodQty; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductWoodQty)
                {
                    _mMSemiProductIngredientItemProductWoodQty = value;
                    NotifyChanged("MMSemiProductIngredientItemProductWoodQty");
                }
            }
        }
        public decimal MMSemiProductIngredientItemProductUnitPrice
        {
            get { return _mMSemiProductIngredientItemProductUnitPrice; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductUnitPrice)
                {
                    _mMSemiProductIngredientItemProductUnitPrice = value;
                    NotifyChanged("MMSemiProductIngredientItemProductUnitPrice");
                }
            }
        }
        public decimal MMSemiProductIngredientItemProductTotalAmount
        {
            get { return _mMSemiProductIngredientItemProductTotalAmount; }
            set
            {
                if (value != this._mMSemiProductIngredientItemProductTotalAmount)
                {
                    _mMSemiProductIngredientItemProductTotalAmount = value;
                    NotifyChanged("MMSemiProductIngredientItemProductTotalAmount");
                }
            }
        }
        #endregion

        #region Extra Properties
        public string MMProductionCostIngredientCostReferenceNo { get; set; }
        public string MMProductionCostIngredientCostReferenceType { get; set; }
        public string MMProductionCostIngredientCostBatchProductNo { get; set; }
        public string MMProductionCostIngredientCostOperationName { get; set; }
        public string MMProductionCostIngredientCostMeasureUnitName { get; set; }
        public string MMProductionCostIngredientCostStockName { get; set; }
        public string MMProductionCostIngredientCostProductGroupName { get; set; }
        public string MMProductionCostIngredientCostProductNo { get; set; }
        public string MMProductionCostIngredientCostProductName { get; set; }
        public string MMProductionCostIngredientCostProductDesc { get; set; }
        public string MMProductionCostIngredientCostProductSerialNo { get; set; }
        public decimal MMProductionCostIngredientCostProductUnitCost { get; set; }
        public decimal MMProductionCostIngredientCostProductQty { get; set; }
        public decimal MMProductionCostIngredientCostTotalCost { get; set; }
        public decimal MMProductionCostIngredientCostProductWoodQty { get; set; }

        #endregion
    }
    #endregion
}