﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMBatchProductPlanPaints
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductPlanPaintsInfo
    //Created Date:Thursday, November 05, 2015
    //-----------------------------------------------------------

    public class MMBatchProductPlanPaintsInfo : BusinessObject
    {
        public MMBatchProductPlanPaintsInfo()
        {
        }
        #region Variables
        protected int _mMBatchProductPlanPaintID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_MMBatchProductPlanID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _mMBatchProductPlanPaintName = String.Empty;
        protected String _mMBatchProductPlanPaintNo = String.Empty;
        protected double _mMBatchProductPlanPaintQuantity;
        protected String _mMBatchProductPlanPaintUnit = String.Empty;
        protected double _mMBatchProductPlanPaintTotalQuantity;
        protected DateTime _mMBatchProductPlanPaintNeededTime = DateTime.MaxValue;
        protected String _mMBatchProductPlanPaintNote = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute1 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute2 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute3 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute4 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute5 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute6 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute7 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute8 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute9 = String.Empty;
        protected String _mMBatchProductPlanPaintICDepartmentAttribute10 = String.Empty;
        protected String _mMBatchProductPlanPaintDesc = String.Empty;
        protected String _mMBatchProductPlanPaintPriority = String.Empty;
        protected double _mMBatchProductPlanPaintBuyTotalQuantity;
        protected double _mMBatchProductPlanPaintInventoryStockQuantity;
        protected double _mMBatchProductPlanPaintBoughtQuantity;
        protected String _mMBatchProductPlanPaintProposalStatus = DefaultStatus;
        protected double _mMBatchProductPlanPurchaseOrderQty;
        protected double _mMBatchProductPlanReceiptQty;
        protected String _mMBatchProductPlanPaintActionType = String.Empty;
        protected String _mMBatchProductPlanPaintOldValue = String.Empty;
        protected String _mMBatchProductPlanPaintNewValue = String.Empty;
        protected bool _mMBatchProductPlanPaintIsChangeBOM = true;
        #endregion

        #region Public properties
        public int MMBatchProductPlanPaintID
        {
            get { return _mMBatchProductPlanPaintID; }
            set
            {
                if (value != this._mMBatchProductPlanPaintID)
                {
                    _mMBatchProductPlanPaintID = value;
                    NotifyChanged("MMBatchProductPlanPaintID");
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
        public int FK_MMBatchProductPlanID
        {
            get { return _fK_MMBatchProductPlanID; }
            set
            {
                if (value != this._fK_MMBatchProductPlanID)
                {
                    _fK_MMBatchProductPlanID = value;
                    NotifyChanged("FK_MMBatchProductPlanID");
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
        public String MMBatchProductPlanPaintName
        {
            get { return _mMBatchProductPlanPaintName; }
            set
            {
                if (value != this._mMBatchProductPlanPaintName)
                {
                    _mMBatchProductPlanPaintName = value;
                    NotifyChanged("MMBatchProductPlanPaintName");
                }
            }
        }
        public String MMBatchProductPlanPaintNo
        {
            get { return _mMBatchProductPlanPaintNo; }
            set
            {
                if (value != this._mMBatchProductPlanPaintNo)
                {
                    _mMBatchProductPlanPaintNo = value;
                    NotifyChanged("MMBatchProductPlanPaintNo");
                }
            }
        }
        public double MMBatchProductPlanPaintQuantity
        {
            get { return _mMBatchProductPlanPaintQuantity; }
            set
            {
                if (value != this._mMBatchProductPlanPaintQuantity)
                {
                    _mMBatchProductPlanPaintQuantity = value;
                    NotifyChanged("MMBatchProductPlanPaintQuantity");
                }
            }
        }
        public String MMBatchProductPlanPaintUnit
        {
            get { return _mMBatchProductPlanPaintUnit; }
            set
            {
                if (value != this._mMBatchProductPlanPaintUnit)
                {
                    _mMBatchProductPlanPaintUnit = value;
                    NotifyChanged("MMBatchProductPlanPaintUnit");
                }
            }
        }
        public double MMBatchProductPlanPaintTotalQuantity
        {
            get { return _mMBatchProductPlanPaintTotalQuantity; }
            set
            {
                if (value != this._mMBatchProductPlanPaintTotalQuantity)
                {
                    _mMBatchProductPlanPaintTotalQuantity = value;
                    NotifyChanged("MMBatchProductPlanPaintTotalQuantity");
                }
            }
        }
        public DateTime MMBatchProductPlanPaintNeededTime
        {
            get { return _mMBatchProductPlanPaintNeededTime; }
            set
            {
                if (value != this._mMBatchProductPlanPaintNeededTime)
                {
                    _mMBatchProductPlanPaintNeededTime = value;
                    NotifyChanged("MMBatchProductPlanPaintNeededTime");
                }
            }
        }
        public String MMBatchProductPlanPaintNote
        {
            get { return _mMBatchProductPlanPaintNote; }
            set
            {
                if (value != this._mMBatchProductPlanPaintNote)
                {
                    _mMBatchProductPlanPaintNote = value;
                    NotifyChanged("MMBatchProductPlanPaintNote");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute1
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute1; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute1)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute1 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute1");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute2
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute2; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute2)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute2 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute2");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute3
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute3; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute3)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute3 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute3");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute4
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute4; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute4)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute4 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute4");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute5
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute5; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute5)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute5 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute5");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute6
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute6; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute6)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute6 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute6");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute7
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute7; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute7)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute7 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute7");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute8
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute8; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute8)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute8 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute8");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute9
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute9; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute9)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute9 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute9");
                }
            }
        }
        public String MMBatchProductPlanPaintICDepartmentAttribute10
        {
            get { return _mMBatchProductPlanPaintICDepartmentAttribute10; }
            set
            {
                if (value != this._mMBatchProductPlanPaintICDepartmentAttribute10)
                {
                    _mMBatchProductPlanPaintICDepartmentAttribute10 = value;
                    NotifyChanged("MMBatchProductPlanPaintICDepartmentAttribute10");
                }
            }
        }
        public String MMBatchProductPlanPaintDesc
        {
            get { return _mMBatchProductPlanPaintDesc; }
            set
            {
                if (value != this._mMBatchProductPlanPaintDesc)
                {
                    _mMBatchProductPlanPaintDesc = value;
                    NotifyChanged("MMBatchProductPlanPaintDesc");
                }
            }
        }
        public String MMBatchProductPlanPaintPriority
        {
            get { return _mMBatchProductPlanPaintPriority; }
            set
            {
                if (value != this._mMBatchProductPlanPaintPriority)
                {
                    _mMBatchProductPlanPaintPriority = value;
                    NotifyChanged("MMBatchProductPlanPaintPriority");
                }
            }
        }
        public double MMBatchProductPlanPaintBuyTotalQuantity
        {
            get { return _mMBatchProductPlanPaintBuyTotalQuantity; }
            set
            {
                if (value != this._mMBatchProductPlanPaintBuyTotalQuantity)
                {
                    _mMBatchProductPlanPaintBuyTotalQuantity = value;
                    NotifyChanged("MMBatchProductPlanPaintBuyTotalQuantity");
                }
            }
        }
        public double MMBatchProductPlanPaintInventoryStockQuantity
        {
            get { return _mMBatchProductPlanPaintInventoryStockQuantity; }
            set
            {
                if (value != this._mMBatchProductPlanPaintInventoryStockQuantity)
                {
                    _mMBatchProductPlanPaintInventoryStockQuantity = value;
                    NotifyChanged("MMBatchProductPlanPaintInventoryStockQuantity");
                }
            }
        }
        public double MMBatchProductPlanPaintBoughtQuantity
        {
            get { return _mMBatchProductPlanPaintBoughtQuantity; }
            set
            {
                if (value != this._mMBatchProductPlanPaintBoughtQuantity)
                {
                    _mMBatchProductPlanPaintBoughtQuantity = value;
                    NotifyChanged("MMBatchProductPlanPaintBoughtQuantity");
                }
            }
        }
        public String MMBatchProductPlanPaintProposalStatus
        {
            get { return _mMBatchProductPlanPaintProposalStatus; }
            set
            {
                if (value != this._mMBatchProductPlanPaintProposalStatus)
                {
                    _mMBatchProductPlanPaintProposalStatus = value;
                    NotifyChanged("MMBatchProductPlanPaintProposalStatus");
                }
            }
        }
        public double MMBatchProductPlanPurchaseOrderQty
        {
            get { return _mMBatchProductPlanPurchaseOrderQty; }
            set
            {
                if (value != this._mMBatchProductPlanPurchaseOrderQty)
                {
                    _mMBatchProductPlanPurchaseOrderQty = value;
                    NotifyChanged("MMBatchProductPlanPurchaseOrderQty");
                }
            }
        }
        public double MMBatchProductPlanReceiptQty
        {
            get { return _mMBatchProductPlanReceiptQty; }
            set
            {
                if (value != this._mMBatchProductPlanReceiptQty)
                {
                    _mMBatchProductPlanReceiptQty = value;
                    NotifyChanged("MMBatchProductPlanReceiptQty");
                }
            }
        }
        public String MMBatchProductPlanPaintActionType
        {
            get { return _mMBatchProductPlanPaintActionType; }
            set
            {
                if (value != this._mMBatchProductPlanPaintActionType)
                {
                    _mMBatchProductPlanPaintActionType = value;
                    NotifyChanged("MMBatchProductPlanPaintActionType");
                }
            }
        }
        public String MMBatchProductPlanPaintOldValue
        {
            get { return _mMBatchProductPlanPaintOldValue; }
            set
            {
                if (value != this._mMBatchProductPlanPaintOldValue)
                {
                    _mMBatchProductPlanPaintOldValue = value;
                    NotifyChanged("MMBatchProductPlanPaintOldValue");
                }
            }
        }
        public String MMBatchProductPlanPaintNewValue
        {
            get { return _mMBatchProductPlanPaintNewValue; }
            set
            {
                if (value != this._mMBatchProductPlanPaintNewValue)
                {
                    _mMBatchProductPlanPaintNewValue = value;
                    NotifyChanged("MMBatchProductPlanPaintNewValue");
                }
            }
        }
        public bool MMBatchProductPlanPaintIsChangeBOM
        {
            get { return _mMBatchProductPlanPaintIsChangeBOM; }
            set
            {
                if (value != this._mMBatchProductPlanPaintIsChangeBOM)
                {
                    _mMBatchProductPlanPaintIsChangeBOM = value;
                    NotifyChanged("MMBatchProductPlanPaintIsChangeBOM");
                }
            }
        }
        #endregion
    }
    #endregion
}