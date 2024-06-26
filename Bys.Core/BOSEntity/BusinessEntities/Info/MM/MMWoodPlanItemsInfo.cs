﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMWoodPlanItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMWoodPlanItemsInfo
    //Created Date:Saturday, November 14, 2015
    //-----------------------------------------------------------

    public class MMWoodPlanItemsInfo : BusinessObject
    {
        public MMWoodPlanItemsInfo()
        {
        }
        #region Variables
        protected int _mMWoodPlanItemID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMWoodPlanID;
        protected int _fK_ICProductID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICMeasureUnitID;
        protected int _fK_ICProductAttributeWoodTypeID;
        protected int _fK_ICProductAttributeSpecialityID;
        protected String _mMWoodPlanItemProductNo = String.Empty;
        protected String _mMWoodPlanItemProductName = String.Empty;
        protected String _mMWoodPlanItemProductDesc = String.Empty;
        protected decimal _mMWoodPlanItemProductBlocks;
        protected decimal _mMWoodPlanItemProductHeight;
        protected decimal _mMWoodPlanItemProductWidth;
        protected decimal _mMWoodPlanItemProductLength;
        protected String _mMWoodPlanItemParentOrderName = String.Empty;
        protected decimal _mMWoodPlanItemDepreciationRate;
        protected decimal _mMWoodPlanItemActualDepreciationRate;
        protected String _mMWoodPlanItemParentNo = String.Empty;
        protected int _mMWoodPlanItemParentID;
        protected DateTime _mMWoodPlanItemNeededTime = DateTime.MaxValue;
        protected bool _mMWoodPlanItemIsReuse = true;
        protected String _mMWoodPlanItemSerialNo = String.Empty;
        protected String _mMPriority = String.Empty;
        protected int _fK_ICProductWoodIngredientID;
        protected String _mMWoodPlanItemAllocationType = String.Empty;
        protected int _fK_MMBatchProductItemID;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMBatchProductProductionNormItemID;
        protected String _mMWoodPlanItemComment = String.Empty;
        protected String _mMWoodPlanItemSpecialityComment = String.Empty;
        protected int _fK_ICProductAttributeQualityID;
        protected int _fK_ICProductForBatchID;
        #endregion

        #region Public properties
        public int MMWoodPlanItemID
        {
            get { return _mMWoodPlanItemID; }
            set
            {
                if (value != this._mMWoodPlanItemID)
                {
                    _mMWoodPlanItemID = value;
                    NotifyChanged("MMWoodPlanItemID");
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
        public int FK_MMWoodPlanID
        {
            get { return _fK_MMWoodPlanID; }
            set
            {
                if (value != this._fK_MMWoodPlanID)
                {
                    _fK_MMWoodPlanID = value;
                    NotifyChanged("FK_MMWoodPlanID");
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
        public int FK_ICProductAttributeWoodTypeID
        {
            get { return _fK_ICProductAttributeWoodTypeID; }
            set
            {
                if (value != this._fK_ICProductAttributeWoodTypeID)
                {
                    _fK_ICProductAttributeWoodTypeID = value;
                    NotifyChanged("FK_ICProductAttributeWoodTypeID");
                }
            }
        }
        public int FK_ICProductAttributeSpecialityID
        {
            get { return _fK_ICProductAttributeSpecialityID; }
            set
            {
                if (value != this._fK_ICProductAttributeSpecialityID)
                {
                    _fK_ICProductAttributeSpecialityID = value;
                    NotifyChanged("FK_ICProductAttributeSpecialityID");
                }
            }
        }
        public String MMWoodPlanItemProductNo
        {
            get { return _mMWoodPlanItemProductNo; }
            set
            {
                if (value != this._mMWoodPlanItemProductNo)
                {
                    _mMWoodPlanItemProductNo = value;
                    NotifyChanged("MMWoodPlanItemProductNo");
                }
            }
        }
        public String MMWoodPlanItemProductName
        {
            get { return _mMWoodPlanItemProductName; }
            set
            {
                if (value != this._mMWoodPlanItemProductName)
                {
                    _mMWoodPlanItemProductName = value;
                    NotifyChanged("MMWoodPlanItemProductName");
                }
            }
        }
        public String MMWoodPlanItemProductDesc
        {
            get { return _mMWoodPlanItemProductDesc; }
            set
            {
                if (value != this._mMWoodPlanItemProductDesc)
                {
                    _mMWoodPlanItemProductDesc = value;
                    NotifyChanged("MMWoodPlanItemProductDesc");
                }
            }
        }
        public decimal MMWoodPlanItemProductBlocks
        {
            get { return _mMWoodPlanItemProductBlocks; }
            set
            {
                if (value != this._mMWoodPlanItemProductBlocks)
                {
                    _mMWoodPlanItemProductBlocks = value;
                    NotifyChanged("MMWoodPlanItemProductBlocks");
                }
            }
        }
        public decimal MMWoodPlanItemProductHeight
        {
            get { return _mMWoodPlanItemProductHeight; }
            set
            {
                if (value != this._mMWoodPlanItemProductHeight)
                {
                    _mMWoodPlanItemProductHeight = value;
                    NotifyChanged("MMWoodPlanItemProductHeight");
                }
            }
        }
        public decimal MMWoodPlanItemProductWidth
        {
            get { return _mMWoodPlanItemProductWidth; }
            set
            {
                if (value != this._mMWoodPlanItemProductWidth)
                {
                    _mMWoodPlanItemProductWidth = value;
                    NotifyChanged("MMWoodPlanItemProductWidth");
                }
            }
        }
        public decimal MMWoodPlanItemProductLength
        {
            get { return _mMWoodPlanItemProductLength; }
            set
            {
                if (value != this._mMWoodPlanItemProductLength)
                {
                    _mMWoodPlanItemProductLength = value;
                    NotifyChanged("MMWoodPlanItemProductLength");
                }
            }
        }
        public String MMWoodPlanItemParentOrderName
        {
            get { return _mMWoodPlanItemParentOrderName; }
            set
            {
                if (value != this._mMWoodPlanItemParentOrderName)
                {
                    _mMWoodPlanItemParentOrderName = value;
                    NotifyChanged("MMWoodPlanItemParentOrderName");
                }
            }
        }
        public decimal MMWoodPlanItemDepreciationRate
        {
            get { return _mMWoodPlanItemDepreciationRate; }
            set
            {
                if (value != this._mMWoodPlanItemDepreciationRate)
                {
                    _mMWoodPlanItemDepreciationRate = value;
                    NotifyChanged("MMWoodPlanItemDepreciationRate");
                }
            }
        }
        public decimal MMWoodPlanItemActualDepreciationRate
        {
            get { return _mMWoodPlanItemActualDepreciationRate; }
            set
            {
                if (value != this._mMWoodPlanItemActualDepreciationRate)
                {
                    _mMWoodPlanItemActualDepreciationRate = value;
                    NotifyChanged("MMWoodPlanItemActualDepreciationRate");
                }
            }
        }
        public String MMWoodPlanItemParentNo
        {
            get { return _mMWoodPlanItemParentNo; }
            set
            {
                if (value != this._mMWoodPlanItemParentNo)
                {
                    _mMWoodPlanItemParentNo = value;
                    NotifyChanged("MMWoodPlanItemParentNo");
                }
            }
        }
        public int MMWoodPlanItemParentID
        {
            get { return _mMWoodPlanItemParentID; }
            set
            {
                if (value != this._mMWoodPlanItemParentID)
                {
                    _mMWoodPlanItemParentID = value;
                    NotifyChanged("MMWoodPlanItemParentID");
                }
            }
        }
        public DateTime MMWoodPlanItemNeededTime
        {
            get { return _mMWoodPlanItemNeededTime; }
            set
            {
                if (value != this._mMWoodPlanItemNeededTime)
                {
                    _mMWoodPlanItemNeededTime = value;
                    NotifyChanged("MMWoodPlanItemNeededTime");
                }
            }
        }
        public bool MMWoodPlanItemIsReuse
        {
            get { return _mMWoodPlanItemIsReuse; }
            set
            {
                if (value != this._mMWoodPlanItemIsReuse)
                {
                    _mMWoodPlanItemIsReuse = value;
                    NotifyChanged("MMWoodPlanItemIsReuse");
                }
            }
        }
        public String MMWoodPlanItemSerialNo
        {
            get { return _mMWoodPlanItemSerialNo; }
            set
            {
                if (value != this._mMWoodPlanItemSerialNo)
                {
                    _mMWoodPlanItemSerialNo = value;
                    NotifyChanged("MMWoodPlanItemSerialNo");
                }
            }
        }
        public String MMPriority
        {
            get { return _mMPriority; }
            set
            {
                if (value != this._mMPriority)
                {
                    _mMPriority = value;
                    NotifyChanged("MMPriority");
                }
            }
        }
        public int FK_ICProductWoodIngredientID
        {
            get { return _fK_ICProductWoodIngredientID; }
            set
            {
                if (value != this._fK_ICProductWoodIngredientID)
                {
                    _fK_ICProductWoodIngredientID = value;
                    NotifyChanged("FK_ICProductWoodIngredientID");
                }
            }
        }
        public String MMWoodPlanItemAllocationType
        {
            get { return _mMWoodPlanItemAllocationType; }
            set
            {
                if (value != this._mMWoodPlanItemAllocationType)
                {
                    _mMWoodPlanItemAllocationType = value;
                    NotifyChanged("MMWoodPlanItemAllocationType");
                }
            }
        }
        public int FK_MMBatchProductItemID
        {
            get { return _fK_MMBatchProductItemID; }
            set
            {
                if (value != this._fK_MMBatchProductItemID)
                {
                    _fK_MMBatchProductItemID = value;
                    NotifyChanged("FK_MMBatchProductItemID");
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
        public int FK_MMBatchProductProductionNormItemID
        {
            get { return _fK_MMBatchProductProductionNormItemID; }
            set
            {
                if (value != this._fK_MMBatchProductProductionNormItemID)
                {
                    _fK_MMBatchProductProductionNormItemID = value;
                    NotifyChanged("FK_MMBatchProductProductionNormItemID");
                }
            }
        }
        public String MMWoodPlanItemComment
        {
            get { return _mMWoodPlanItemComment; }
            set
            {
                if (value != this._mMWoodPlanItemComment)
                {
                    _mMWoodPlanItemComment = value;
                    NotifyChanged("MMWoodPlanItemComment");
                }
            }
        }
        public String MMWoodPlanItemSpecialityComment
        {
            get { return _mMWoodPlanItemSpecialityComment; }
            set
            {
                if (value != this._mMWoodPlanItemSpecialityComment)
                {
                    _mMWoodPlanItemSpecialityComment = value;
                    NotifyChanged("MMWoodPlanItemSpecialityComment");
                }
            }
        }
        public int FK_ICProductAttributeQualityID
        {
            get { return _fK_ICProductAttributeQualityID; }
            set
            {
                if (value != this._fK_ICProductAttributeQualityID)
                {
                    _fK_ICProductAttributeQualityID = value;
                    NotifyChanged("FK_ICProductAttributeQualityID");
                }
            }
        }
        public int FK_ICProductForBatchID
        {
            get { return _fK_ICProductForBatchID; }
            set
            {
                if (value != this._fK_ICProductForBatchID)
                {
                    _fK_ICProductForBatchID = value;
                    NotifyChanged("FK_ICProductForBatchID");
                }
            }
        }
        #endregion

        #region Extra properties
        public int AbstractID { get; set; }
        public int MMBatchProductItemProductID { get; set; }
        public string MMBatchProductItemProductDesc { get; set; }
        public bool HaveChanged { get; set; }
        public bool HaveChangedForUpdate { get; set; }
        public string StatusUpdate { get; set; }
        #endregion
    }
    #endregion
}