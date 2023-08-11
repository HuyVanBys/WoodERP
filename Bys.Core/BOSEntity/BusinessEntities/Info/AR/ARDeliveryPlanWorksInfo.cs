﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARDeliveryPlanWorks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDeliveryPlanWorksInfo
    //Created Date:19 Tháng Ba 2018
    //-----------------------------------------------------------

    public class ARDeliveryPlanWorksInfo : BusinessObject
    {
        public ARDeliveryPlanWorksInfo()
        {
        }
        #region Variables
        protected int _aRDeliveryPlanWorkID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARDeliveryPlanID;
        protected int _fK_ARDeliveryPlanItemID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ARSaleOrderItemID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _aRDeliveryPlanWorkProductNo = String.Empty;
        protected String _aRDeliveryPlanWorkProductName = String.Empty;
        protected String _aRDeliveryPlanWorkProductDesc = String.Empty;
        protected decimal _aRDeliveryPlanWorkProductQty;
        protected String _aRDeliveryPlanWorkProductType = String.Empty;
        protected decimal _aRDeliveryPlanWorkProductUnitPrice;
        protected decimal _aRDeliveryPlanWorkTotalAmount;
        protected decimal _aRDeliveryPlanWorkSubTotalAmount;
        protected bool _aRDeliveryPlanWorkProductChargeCheck = true;
        protected String _aRDeliveryPlanWorkStatus = DefaultStatus;
        protected int _aRDeliveryPlanWorkParentID;
        protected decimal _aRDeliveryPlanWorkAllocationQty;
        protected int _fK_ARSaleOrderItemWorkID;
        #endregion

        #region Public properties
        public int ARDeliveryPlanWorkID
        {
            get { return _aRDeliveryPlanWorkID; }
            set
            {
                if (value != this._aRDeliveryPlanWorkID)
                {
                    _aRDeliveryPlanWorkID = value;
                    NotifyChanged("ARDeliveryPlanWorkID");
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
        public int FK_ARDeliveryPlanID
        {
            get { return _fK_ARDeliveryPlanID; }
            set
            {
                if (value != this._fK_ARDeliveryPlanID)
                {
                    _fK_ARDeliveryPlanID = value;
                    NotifyChanged("FK_ARDeliveryPlanID");
                }
            }
        }
        public int FK_ARDeliveryPlanItemID
        {
            get { return _fK_ARDeliveryPlanItemID; }
            set
            {
                if (value != this._fK_ARDeliveryPlanItemID)
                {
                    _fK_ARDeliveryPlanItemID = value;
                    NotifyChanged("FK_ARDeliveryPlanItemID");
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
        public String ARDeliveryPlanWorkProductNo
        {
            get { return _aRDeliveryPlanWorkProductNo; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductNo)
                {
                    _aRDeliveryPlanWorkProductNo = value;
                    NotifyChanged("ARDeliveryPlanWorkProductNo");
                }
            }
        }
        public String ARDeliveryPlanWorkProductName
        {
            get { return _aRDeliveryPlanWorkProductName; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductName)
                {
                    _aRDeliveryPlanWorkProductName = value;
                    NotifyChanged("ARDeliveryPlanWorkProductName");
                }
            }
        }
        public String ARDeliveryPlanWorkProductDesc
        {
            get { return _aRDeliveryPlanWorkProductDesc; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductDesc)
                {
                    _aRDeliveryPlanWorkProductDesc = value;
                    NotifyChanged("ARDeliveryPlanWorkProductDesc");
                }
            }
        }
        public decimal ARDeliveryPlanWorkProductQty
        {
            get { return _aRDeliveryPlanWorkProductQty; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductQty)
                {
                    _aRDeliveryPlanWorkProductQty = value;
                    NotifyChanged("ARDeliveryPlanWorkProductQty");
                }
            }
        }
        public String ARDeliveryPlanWorkProductType
        {
            get { return _aRDeliveryPlanWorkProductType; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductType)
                {
                    _aRDeliveryPlanWorkProductType = value;
                    NotifyChanged("ARDeliveryPlanWorkProductType");
                }
            }
        }
        public decimal ARDeliveryPlanWorkProductUnitPrice
        {
            get { return _aRDeliveryPlanWorkProductUnitPrice; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductUnitPrice)
                {
                    _aRDeliveryPlanWorkProductUnitPrice = value;
                    NotifyChanged("ARDeliveryPlanWorkProductUnitPrice");
                }
            }
        }
        public decimal ARDeliveryPlanWorkTotalAmount
        {
            get { return _aRDeliveryPlanWorkTotalAmount; }
            set
            {
                if (value != this._aRDeliveryPlanWorkTotalAmount)
                {
                    _aRDeliveryPlanWorkTotalAmount = value;
                    NotifyChanged("ARDeliveryPlanWorkTotalAmount");
                }
            }
        }
        public decimal ARDeliveryPlanWorkSubTotalAmount
        {
            get { return _aRDeliveryPlanWorkSubTotalAmount; }
            set
            {
                if (value != this._aRDeliveryPlanWorkSubTotalAmount)
                {
                    _aRDeliveryPlanWorkSubTotalAmount = value;
                    NotifyChanged("ARDeliveryPlanWorkSubTotalAmount");
                }
            }
        }
        public bool ARDeliveryPlanWorkProductChargeCheck
        {
            get { return _aRDeliveryPlanWorkProductChargeCheck; }
            set
            {
                if (value != this._aRDeliveryPlanWorkProductChargeCheck)
                {
                    _aRDeliveryPlanWorkProductChargeCheck = value;
                    NotifyChanged("ARDeliveryPlanWorkProductChargeCheck");
                }
            }
        }
        public String ARDeliveryPlanWorkStatus
        {
            get { return _aRDeliveryPlanWorkStatus; }
            set
            {
                if (value != this._aRDeliveryPlanWorkStatus)
                {
                    _aRDeliveryPlanWorkStatus = value;
                    NotifyChanged("ARDeliveryPlanWorkStatus");
                }
            }
        }

        public int ARDeliveryPlanWorkParentID
        {
            get { return _aRDeliveryPlanWorkParentID; }
            set
            {
                if (value != this._aRDeliveryPlanWorkParentID)
                {
                    _aRDeliveryPlanWorkParentID = value;
                    NotifyChanged("ARDeliveryPlanWorkParentID");
                }
            }
        }
        public decimal ARDeliveryPlanWorkAllocationQty
        {
            get { return _aRDeliveryPlanWorkAllocationQty; }
            set
            {
                if (value != this._aRDeliveryPlanWorkAllocationQty)
                {
                    _aRDeliveryPlanWorkAllocationQty = value;
                    NotifyChanged("ARDeliveryPlanWorkAllocationQty");
                }
            }
        }
        public int FK_ARSaleOrderItemWorkID
        {
            get { return _fK_ARSaleOrderItemWorkID; }
            set
            {
                if (value != this._fK_ARSaleOrderItemWorkID)
                {
                    _fK_ARSaleOrderItemWorkID = value;
                    NotifyChanged("FK_ARSaleOrderItemWorkID");
                }
            }
        }
        #endregion

        #region Extra property

        public IBOSList<PMTasksInfo> TasksList { get; set; }

        public IBOSList<ARDeliveryPlanWorksInfo> DeliveryPlanWorkAssetsList { get; set; }

        public IBOSList<ARDeliveryPlanWorksInfo> DeliveryPlanWorkMaterialsList { get; set; }

        public string ACObjectName { get; set; }

        public string ARDeliveryPlanNo { get; set; }

        public int FK_PMProjectID { get; set; }
        #endregion
    }
    #endregion
}