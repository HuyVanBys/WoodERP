﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACAssetShipmentItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAssetShipmentItemsInfo
    //Created Date:05 May 2012
    //-----------------------------------------------------------

    public class ACAssetShipmentItemsInfo : BusinessObject
    {
        public ACAssetShipmentItemsInfo()
        {
        }
        #region Variables
        protected int _aCAssetShipmentItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACDocumentID;
        protected int _fK_ACAssetID;
        protected int _fK_HRDepartmentRoomID;
        protected decimal _aCAssetShipmentItemQty;
        protected decimal _aCAssetShipmentItemDepreciatedAmount;
        protected int _fK_HRDepartmentRoomGroupItemID;
        protected int _fK_HRDepartmentRoomGroupID;
        protected int _fK_MMLineID;
        protected int _fK_MMWorkShopID;
        protected int _fK_HREmployeeUserID;
        protected int _fK_HRDepartmentID;
        protected int _fK_ACCostCenterID;
        protected int _fK_ACSegmentID;
        protected int _fK_ACAccountID;
        protected int _fK_ACDepreciationAccountID;
        #endregion

        #region Public properties
        public int ACAssetShipmentItemID
        {
            get { return _aCAssetShipmentItemID; }
            set
            {
                if (value != this._aCAssetShipmentItemID)
                {
                    _aCAssetShipmentItemID = value;
                    NotifyChanged("ACAssetShipmentItemID");
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
        public int FK_ACDocumentID
        {
            get { return _fK_ACDocumentID; }
            set
            {
                if (value != this._fK_ACDocumentID)
                {
                    _fK_ACDocumentID = value;
                    NotifyChanged("FK_ACDocumentID");
                }
            }
        }
        public int FK_ACAssetID
        {
            get { return _fK_ACAssetID; }
            set
            {
                if (value != this._fK_ACAssetID)
                {
                    _fK_ACAssetID = value;
                    NotifyChanged("FK_ACAssetID");
                }
            }
        }
        public int FK_HRDepartmentRoomID
        {
            get { return _fK_HRDepartmentRoomID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomID)
                {
                    _fK_HRDepartmentRoomID = value;
                    NotifyChanged("FK_HRDepartmentRoomID");
                }
            }
        }
        public decimal ACAssetShipmentItemQty
        {
            get { return _aCAssetShipmentItemQty; }
            set
            {
                if (value != this._aCAssetShipmentItemQty)
                {
                    _aCAssetShipmentItemQty = value;
                    NotifyChanged("ACAssetShipmentItemQty");
                }
            }
        }
        public decimal ACAssetShipmentItemDepreciatedAmount
        {
            get { return _aCAssetShipmentItemDepreciatedAmount; }
            set
            {
                if (value != this._aCAssetShipmentItemDepreciatedAmount)
                {
                    _aCAssetShipmentItemDepreciatedAmount = value;
                    NotifyChanged("ACAssetShipmentItemDepreciatedAmount");
                }
            }
        }
        public int FK_HRDepartmentRoomGroupItemID
        {
            get { return _fK_HRDepartmentRoomGroupItemID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomGroupItemID)
                {
                    _fK_HRDepartmentRoomGroupItemID = value;
                    NotifyChanged("FK_HRDepartmentRoomGroupItemID");
                }
            }
        }
        public int FK_HRDepartmentRoomGroupID
        {
            get { return _fK_HRDepartmentRoomGroupID; }
            set
            {
                if (value != this._fK_HRDepartmentRoomGroupID)
                {
                    _fK_HRDepartmentRoomGroupID = value;
                    NotifyChanged("FK_HRDepartmentRoomGroupID");
                }
            }
        }
        public int FK_MMLineID
        {
            get { return _fK_MMLineID; }
            set
            {
                if (value != this._fK_MMLineID)
                {
                    _fK_MMLineID = value;
                    NotifyChanged("FK_MMLineID");
                }
            }
        }
        public int FK_MMWorkShopID
        {
            get { return _fK_MMWorkShopID; }
            set
            {
                if (value != this._fK_MMWorkShopID)
                {
                    _fK_MMWorkShopID = value;
                    NotifyChanged("FK_MMWorkShopID");
                }
            }
        }
        public int FK_HREmployeeUserID
        {
            get { return _fK_HREmployeeUserID; }
            set
            {
                if (value != this._fK_HREmployeeUserID)
                {
                    _fK_HREmployeeUserID = value;
                    NotifyChanged("FK_HREmployeeUserID");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public int FK_ACCostCenterID
        {
            get { return _fK_ACCostCenterID; }
            set
            {
                if (value != this._fK_ACCostCenterID)
                {
                    _fK_ACCostCenterID = value;
                    NotifyChanged("FK_ACCostCenterID");
                }
            }
        }
        public int FK_ACSegmentID
        {
            get { return _fK_ACSegmentID; }
            set
            {
                if (value != this._fK_ACSegmentID)
                {
                    _fK_ACSegmentID = value;
                    NotifyChanged("FK_ACSegmentID");
                }
            }
        }
        public int FK_ACAccountID
        {
            get { return _fK_ACAccountID; }
            set
            {
                if (value != this._fK_ACAccountID)
                {
                    _fK_ACAccountID = value;
                    NotifyChanged("FK_ACAccountID");
                }
            }
        }
        public int FK_ACDepreciationAccountID
        {
            get { return _fK_ACDepreciationAccountID; }
            set
            {
                if (value != this._fK_ACDepreciationAccountID)
                {
                    _fK_ACDepreciationAccountID = value;
                    NotifyChanged("FK_ACDepreciationAccountID");
                }
            }
        }
        #endregion


        #region Extra Properties
        public string ACAssetNo { get; set; }

        public string ACAssetName { get; set; }

        public decimal AssetReceiptedQty { get; set; }

        public decimal AssetShippedQty { get; set; }

        public decimal ACAssetInitQty { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ACAssetOriginalAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ACAssetRemainedAmount { get; set; }

        public string ACDocumentNo { get; set; }

        public DateTime ACDocumentDate { get; set; }

        public string ACDocumentDesc { get; set; }

        public string ICMeasureUnitName { get; set; }

        public string HRDepartmentRoomName { get; set; }

        #endregion
    }
    #endregion
}