﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARContainerLoaderItemDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARContainerLoaderItemDetailsInfo
    //Created Date:Wednesday, November 02, 2016
    //-----------------------------------------------------------

    public class ARContainerLoaderItemDetailsInfo : BusinessObject
    {
        public ARContainerLoaderItemDetailsInfo()
        {
        }
        #region Variables
        protected int _aRContainerLoaderItemDetailID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARContainerLoaderID;
        protected int _fK_ARContainerLoaderItemID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _aRContainerLoaderItemDetailProductType = String.Empty;
        protected String _aRContainerLoaderItemDetailProductName = String.Empty;
        protected String _aRContainerLoaderItemDetailProductDesc = String.Empty;
        protected decimal _aRContainerLoaderItemDetailProductQty;
        protected decimal _aRContainerLoaderItemDetailCanceledQty;
        protected String _aRContainerLoaderItemDetailComment = String.Empty;
        protected int _fK_ARSaleForecastID;
        protected int _fK_ARSaleForecastItemID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected decimal _aRContainerLoaderItemDetailUnitVolume;
        protected decimal _aRContainerLoaderItemDetailLength;
        protected decimal _aRContainerLoaderItemDetailWidth;
        protected decimal _aRContainerLoaderItemDetailHeight;
        protected decimal _aRContainerLoaderItemDetailNetWeight;
        protected decimal _aRContainerLoaderItemDetailGrossWeight;
        protected decimal _aRContainerLoaderItemDetailTotalGrossWeight;
        protected decimal _aRContainerLoaderItemDetailTotalCMB;
        protected decimal _aRContainerLoaderItemDetailTotalBlock;
        protected int _fK_ICProductForBatchID;
        protected int _fK_MMBatchProductProductionNormItemID;
        #endregion

        #region Public properties
        public int ARContainerLoaderItemDetailID
        {
            get { return _aRContainerLoaderItemDetailID; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailID)
                {
                    _aRContainerLoaderItemDetailID = value;
                    NotifyChanged("ARContainerLoaderItemDetailID");
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
        public int FK_ARContainerLoaderID
        {
            get { return _fK_ARContainerLoaderID; }
            set
            {
                if (value != this._fK_ARContainerLoaderID)
                {
                    _fK_ARContainerLoaderID = value;
                    NotifyChanged("FK_ARContainerLoaderID");
                }
            }
        }
        public int FK_ARContainerLoaderItemID
        {
            get { return _fK_ARContainerLoaderItemID; }
            set
            {
                if (value != this._fK_ARContainerLoaderItemID)
                {
                    _fK_ARContainerLoaderItemID = value;
                    NotifyChanged("FK_ARContainerLoaderItemID");
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
        public String ARContainerLoaderItemDetailProductType
        {
            get { return _aRContainerLoaderItemDetailProductType; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailProductType)
                {
                    _aRContainerLoaderItemDetailProductType = value;
                    NotifyChanged("ARContainerLoaderItemDetailProductType");
                }
            }
        }
        public String ARContainerLoaderItemDetailProductName
        {
            get { return _aRContainerLoaderItemDetailProductName; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailProductName)
                {
                    _aRContainerLoaderItemDetailProductName = value;
                    NotifyChanged("ARContainerLoaderItemDetailProductName");
                }
            }
        }
        public String ARContainerLoaderItemDetailProductDesc
        {
            get { return _aRContainerLoaderItemDetailProductDesc; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailProductDesc)
                {
                    _aRContainerLoaderItemDetailProductDesc = value;
                    NotifyChanged("ARContainerLoaderItemDetailProductDesc");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailProductQty
        {
            get { return _aRContainerLoaderItemDetailProductQty; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailProductQty)
                {
                    _aRContainerLoaderItemDetailProductQty = value;
                    NotifyChanged("ARContainerLoaderItemDetailProductQty");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailCanceledQty
        {
            get { return _aRContainerLoaderItemDetailCanceledQty; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailCanceledQty)
                {
                    _aRContainerLoaderItemDetailCanceledQty = value;
                    NotifyChanged("ARContainerLoaderItemDetailCanceledQty");
                }
            }
        }
        public String ARContainerLoaderItemDetailComment
        {
            get { return _aRContainerLoaderItemDetailComment; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailComment)
                {
                    _aRContainerLoaderItemDetailComment = value;
                    NotifyChanged("ARContainerLoaderItemDetailComment");
                }
            }
        }
        public int FK_ARSaleForecastID
        {
            get { return _fK_ARSaleForecastID; }
            set
            {
                if (value != this._fK_ARSaleForecastID)
                {
                    _fK_ARSaleForecastID = value;
                    NotifyChanged("FK_ARSaleForecastID");
                }
            }
        }
        public int FK_ARSaleForecastItemID
        {
            get { return _fK_ARSaleForecastItemID; }
            set
            {
                if (value != this._fK_ARSaleForecastItemID)
                {
                    _fK_ARSaleForecastItemID = value;
                    NotifyChanged("FK_ARSaleForecastItemID");
                }
            }
        }
        public int FK_ARSaleOrderID
        {
            get { return _fK_ARSaleOrderID; }
            set
            {
                if (value != this._fK_ARSaleOrderID)
                {
                    _fK_ARSaleOrderID = value;
                    NotifyChanged("FK_ARSaleOrderID");
                }
            }
        }
        public int FK_ARSaleOrderItemID
        {
            get { return _fK_ARSaleOrderItemID; }
            set
            {
                if (value != this._fK_ARSaleOrderItemID)
                {
                    _fK_ARSaleOrderItemID = value;
                    NotifyChanged("FK_ARSaleOrderItemID");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailUnitVolume
        {
            get { return _aRContainerLoaderItemDetailUnitVolume; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailUnitVolume)
                {
                    _aRContainerLoaderItemDetailUnitVolume = value;
                    NotifyChanged("ARContainerLoaderItemDetailUnitVolume");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailLength
        {
            get { return _aRContainerLoaderItemDetailLength; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailLength)
                {
                    _aRContainerLoaderItemDetailLength = value;
                    NotifyChanged("ARContainerLoaderItemDetailLength");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailWidth
        {
            get { return _aRContainerLoaderItemDetailWidth; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailWidth)
                {
                    _aRContainerLoaderItemDetailWidth = value;
                    NotifyChanged("ARContainerLoaderItemDetailWidth");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailHeight
        {
            get { return _aRContainerLoaderItemDetailHeight; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailHeight)
                {
                    _aRContainerLoaderItemDetailHeight = value;
                    NotifyChanged("ARContainerLoaderItemDetailHeight");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailNetWeight
        {
            get { return _aRContainerLoaderItemDetailNetWeight; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailNetWeight)
                {
                    _aRContainerLoaderItemDetailNetWeight = value;
                    NotifyChanged("ARContainerLoaderItemDetailNetWeight");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailGrossWeight
        {
            get { return _aRContainerLoaderItemDetailGrossWeight; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailGrossWeight)
                {
                    _aRContainerLoaderItemDetailGrossWeight = value;
                    NotifyChanged("ARContainerLoaderItemDetailGrossWeight");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailTotalGrossWeight
        {
            get { return _aRContainerLoaderItemDetailTotalGrossWeight; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailTotalGrossWeight)
                {
                    _aRContainerLoaderItemDetailTotalGrossWeight = value;
                    NotifyChanged("ARContainerLoaderItemDetailTotalGrossWeight");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailTotalCMB
        {
            get { return _aRContainerLoaderItemDetailTotalCMB; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailTotalCMB)
                {
                    _aRContainerLoaderItemDetailTotalCMB = value;
                    NotifyChanged("ARContainerLoaderItemDetailTotalCMB");
                }
            }
        }
        public decimal ARContainerLoaderItemDetailTotalBlock
        {
            get { return _aRContainerLoaderItemDetailTotalBlock; }
            set
            {
                if (value != this._aRContainerLoaderItemDetailTotalBlock)
                {
                    _aRContainerLoaderItemDetailTotalBlock = value;
                    NotifyChanged("ARContainerLoaderItemDetailTotalBlock");
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
        #endregion

        #region Extra Properties
        //Print LoadCont
        public string GEContainerName { get; set; }
        public string ICProductNo { get; set; }
        public byte[] ICProductPicture { get; set; }
        public string ARSaleOrderNo { get; set; }
        public decimal ARSaleOrderItemProductQty { get; set; }
        public decimal ARSaleOrderItemTotalProductQty { get; set; }
        public int RecordNumber { get; set; }
        public decimal ARContainerLoaderItemTotalBlock { get; set; }
        public string ARContainerLoaderReference { get; set; }
        public string ARContainerLoaderName { get; set; }
        public DateTime ARContainerLoaderDate { get; set; }
        public DateTime ARContainerLoaderDelivery { get; set; }
        public string ARContainerLoaderSealNo { get; set; }
        public string ARContainerLoaderNo { get; set; }
        public int ARContainerLoaderContNo { get; set; }
        //Print LoadCont
        #endregion
    }
    #endregion
}