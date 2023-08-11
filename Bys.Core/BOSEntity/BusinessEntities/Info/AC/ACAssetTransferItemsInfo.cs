﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ACAssetTransferItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAssetTransferItemsInfo
    //Created Date:06 May 2012
    //-----------------------------------------------------------

    public class ACAssetTransferItemsInfo : BusinessObject
    {
        public ACAssetTransferItemsInfo()
        {
            this._aCAssetTransferItemQty = 1;
        }
        #region Variables
        protected int _aCAssetTransferItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ACDocumentID;
        protected int _fK_ACAssetID;
        protected int _fK_HRFromRoomID;
        protected int _fK_HRToRoomID;
        protected int _fK_ACDepreciationCostAccountID;
        protected decimal _aCAssetTransferItemQty;
        protected decimal _aCAssetTransferItemDepreciatedAmount;
        protected int _fK_HRDepartmentRoomGroupItemID;
        protected int _fK_HRDepartmentRoomGroupID;
        protected int _fK_MMLineID;
        protected int _fK_MMWorkShopID;
        protected int _fK_HRToDepartmentRoomGroupItemID;
        protected int _fK_MMToLineID;
        protected int _fK_MMToWorkShopID;
        protected int _fK_HREmployeeUserID;
        protected int _fK_HRDepartmentID;
        protected int _fk_HRToDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_ACCostCenterID;
        protected int _fK_ACSegmentID;
        #endregion

        #region Public properties
        public int ACAssetTransferItemID
        {
            get { return _aCAssetTransferItemID; }
            set
            {
                if (value != this._aCAssetTransferItemID)
                {
                    _aCAssetTransferItemID = value;
                    NotifyChanged("ACAssetTransferItemID");
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
        public int FK_HRFromRoomID
        {
            get { return _fK_HRFromRoomID; }
            set
            {
                if (value != this._fK_HRFromRoomID)
                {
                    _fK_HRFromRoomID = value;
                    NotifyChanged("FK_HRFromRoomID");
                }
            }
        }
        public int FK_HRToRoomID
        {
            get { return _fK_HRToRoomID; }
            set
            {
                if (value != this._fK_HRToRoomID)
                {
                    _fK_HRToRoomID = value;
                    NotifyChanged("FK_HRToRoomID");
                }
            }
        }
        public int FK_ACDepreciationCostAccountID
        {
            get { return _fK_ACDepreciationCostAccountID; }
            set
            {
                if (value != this._fK_ACDepreciationCostAccountID)
                {
                    _fK_ACDepreciationCostAccountID = value;
                    NotifyChanged("FK_ACDepreciationCostAccountID");
                }
            }
        }
        public decimal ACAssetTransferItemQty
        {
            get { return _aCAssetTransferItemQty; }
            set
            {
                if (value != this._aCAssetTransferItemQty)
                {
                    _aCAssetTransferItemQty = value;
                    NotifyChanged("ACAssetTransferItemQty");
                }
            }
        }
        public decimal ACAssetTransferItemDepreciatedAmount
        {
            get { return _aCAssetTransferItemDepreciatedAmount; }
            set
            {
                if (value != this._aCAssetTransferItemDepreciatedAmount)
                {
                    _aCAssetTransferItemDepreciatedAmount = value;
                    NotifyChanged("ACAssetTransferItemDepreciatedAmount");
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
        public int FK_HRToDepartmentRoomGroupItemID
        {
            get { return _fK_HRToDepartmentRoomGroupItemID; }
            set
            {
                if (value != this._fK_HRToDepartmentRoomGroupItemID)
                {
                    _fK_HRToDepartmentRoomGroupItemID = value;
                    NotifyChanged("FK_HRToDepartmentRoomGroupItemID");
                }
            }
        }
        public int FK_MMToLineID
        {
            get { return _fK_MMToLineID; }
            set
            {
                if (value != this._fK_MMToLineID)
                {
                    _fK_MMToLineID = value;
                    NotifyChanged("FK_MMToLineID");
                }
            }
        }
        public int FK_MMToWorkShopID
        {
            get { return _fK_MMToWorkShopID; }
            set
            {
                if (value != this._fK_MMToWorkShopID)
                {
                    _fK_MMToWorkShopID = value;
                    NotifyChanged("FK_MMToWorkShopID");
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
        public int FK_HRToDepartmentID
        {
            get { return _fk_HRToDepartmentID; }
            set
            {
                if (value != _fk_HRToDepartmentID)
                {
                    _fk_HRToDepartmentID = value;
                    NotifyChanged("Fk_HRToDepartmentID");
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
        #endregion


        #region Extra Properties
        public string ACAssetNo { get; set; }

        public string ACAssetName { get; set; }

        public string ICMeasureUnitName { get; set; }

        public decimal AssetReceiptedQty { get; set; }

        public decimal AssetShippedQty { get; set; }

        public decimal ACAssetInitQty { get; set; }

        //public int FK_HRDepartmentRoomID { get; set; }

        public string ACDocumentNo { get; set; }

        public DateTime ACDocumentDate { get; set; }

        public string ACDocumentDesc { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ACAssetOriginalAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ACAssetRemainedAmount { get; set; }

        public string FromRoomName { get; set; }

        public string ToRoomName { get; set; }
        #endregion
    }
    #endregion
}