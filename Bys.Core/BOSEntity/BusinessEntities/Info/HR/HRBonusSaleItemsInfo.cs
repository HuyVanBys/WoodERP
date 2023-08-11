﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRBonusSaleItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRBonusSaleItemsInfo
    //Created Date:Thursday, February 14, 2019
    //-----------------------------------------------------------

    public class HRBonusSaleItemsInfo : BusinessObject
    {
        public HRBonusSaleItemsInfo()
        {
        }
        #region Variables
        protected int _hRBonusSaleItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRBonusSaleID;
        protected int _fK_HREmployeeID;
        protected int _fK_HREmployeeID2;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected String _hRBonusSaleItemCardNumber = String.Empty;
        protected String _hRBonusSaleItemDesc = String.Empty;
        protected decimal _hRBonusSaleItemAmount;
        protected decimal _hRBonusSaleItemWorkingQty;
        protected decimal _hRBonusSaleItemDSBHNoVAT;
        protected decimal _hRBonusSaleItemVAT;
        protected decimal _hRBonusSaleItemAllowanceTT;
        protected decimal _hRBonusSaleItemAllowanceCN;
        protected decimal _hRBonusSaleItemTotalAmount;
        protected decimal _hRBonusSaleItemLevelAllowance;
        protected decimal _hRBonusSaleItemAmountBonusSale;
        protected decimal _hRBonusSaleItemAmountBonusSaleTT;
        protected decimal _hRBonusSaleItemAmountBonusSaleCN;
        protected decimal _hRBonusSaleItemPercentageRetained;
        protected String _hRBonusSaleItemPercentageRetainedType = String.Empty;
        protected decimal _hRBonusSaleItemBonusReachTarget;
        protected decimal _hRBonusSaleItemBonusBeyondTarget;
        protected decimal _hRBonusSaleItemMonthlyBonus;
        protected decimal _hRBonusSaleItemTarget;
        protected decimal _hRBonusSaleItemManagementSalesAmount;
        protected decimal _hRBonusSaleItemRetainedAmount;
        #endregion

        #region Public properties
        public int HRBonusSaleItemID
        {
            get { return _hRBonusSaleItemID; }
            set
            {
                if (value != this._hRBonusSaleItemID)
                {
                    _hRBonusSaleItemID = value;
                    NotifyChanged("HRBonusSaleItemID");
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
        public int FK_HRBonusSaleID
        {
            get { return _fK_HRBonusSaleID; }
            set
            {
                if (value != this._fK_HRBonusSaleID)
                {
                    _fK_HRBonusSaleID = value;
                    NotifyChanged("FK_HRBonusSaleID");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public int FK_HREmployeeID2
        {
            get { return _fK_HREmployeeID2; }
            set
            {
                if (value != this._fK_HREmployeeID2)
                {
                    _fK_HREmployeeID2 = value;
                    NotifyChanged("FK_HREmployeeID2");
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
        public String HRBonusSaleItemCardNumber
        {
            get { return _hRBonusSaleItemCardNumber; }
            set
            {
                if (value != this._hRBonusSaleItemCardNumber)
                {
                    _hRBonusSaleItemCardNumber = value;
                    NotifyChanged("HRBonusSaleItemCardNumber");
                }
            }
        }
        public String HRBonusSaleItemDesc
        {
            get { return _hRBonusSaleItemDesc; }
            set
            {
                if (value != this._hRBonusSaleItemDesc)
                {
                    _hRBonusSaleItemDesc = value;
                    NotifyChanged("HRBonusSaleItemDesc");
                }
            }
        }
        public decimal HRBonusSaleItemAmount
        {
            get { return _hRBonusSaleItemAmount; }
            set
            {
                if (value != this._hRBonusSaleItemAmount)
                {
                    _hRBonusSaleItemAmount = value;
                    NotifyChanged("HRBonusSaleItemAmount");
                }
            }
        }
        public decimal HRBonusSaleItemWorkingQty
        {
            get { return _hRBonusSaleItemWorkingQty; }
            set
            {
                if (value != this._hRBonusSaleItemWorkingQty)
                {
                    _hRBonusSaleItemWorkingQty = value;
                    NotifyChanged("HRBonusSaleItemWorkingQty");
                }
            }
        }
        public decimal HRBonusSaleItemDSBHNoVAT
        {
            get { return _hRBonusSaleItemDSBHNoVAT; }
            set
            {
                if (value != this._hRBonusSaleItemDSBHNoVAT)
                {
                    _hRBonusSaleItemDSBHNoVAT = value;
                    NotifyChanged("HRBonusSaleItemDSBHNoVAT");
                }
            }
        }
        public decimal HRBonusSaleItemVAT
        {
            get { return _hRBonusSaleItemVAT; }
            set
            {
                if (value != this._hRBonusSaleItemVAT)
                {
                    _hRBonusSaleItemVAT = value;
                    NotifyChanged("HRBonusSaleItemVAT");
                }
            }
        }
        public decimal HRBonusSaleItemAllowanceTT
        {
            get { return _hRBonusSaleItemAllowanceTT; }
            set
            {
                if (value != this._hRBonusSaleItemAllowanceTT)
                {
                    _hRBonusSaleItemAllowanceTT = value;
                    NotifyChanged("HRBonusSaleItemAllowanceTT");
                }
            }
        }
        public decimal HRBonusSaleItemAllowanceCN
        {
            get { return _hRBonusSaleItemAllowanceCN; }
            set
            {
                if (value != this._hRBonusSaleItemAllowanceCN)
                {
                    _hRBonusSaleItemAllowanceCN = value;
                    NotifyChanged("HRBonusSaleItemAllowanceCN");
                }
            }
        }
        public decimal HRBonusSaleItemTotalAmount
        {
            get { return _hRBonusSaleItemTotalAmount; }
            set
            {
                if (value != this._hRBonusSaleItemTotalAmount)
                {
                    _hRBonusSaleItemTotalAmount = value;
                    NotifyChanged("HRBonusSaleItemTotalAmount");
                }
            }
        }
        public decimal HRBonusSaleItemLevelAllowance
        {
            get { return _hRBonusSaleItemLevelAllowance; }
            set
            {
                if (value != this._hRBonusSaleItemLevelAllowance)
                {
                    _hRBonusSaleItemLevelAllowance = value;
                    NotifyChanged("HRBonusSaleItemLevelAllowance");
                }
            }
        }
        public decimal HRBonusSaleItemAmountBonusSale
        {
            get { return _hRBonusSaleItemAmountBonusSale; }
            set
            {
                if (value != this._hRBonusSaleItemAmountBonusSale)
                {
                    _hRBonusSaleItemAmountBonusSale = value;
                    NotifyChanged("HRBonusSaleItemAmountBonusSale");
                }
            }
        }
        public decimal HRBonusSaleItemAmountBonusSaleTT
        {
            get { return _hRBonusSaleItemAmountBonusSaleTT; }
            set
            {
                if (value != this._hRBonusSaleItemAmountBonusSaleTT)
                {
                    _hRBonusSaleItemAmountBonusSaleTT = value;
                    NotifyChanged("HRBonusSaleItemAmountBonusSaleTT");
                }
            }
        }
        public decimal HRBonusSaleItemAmountBonusSaleCN
        {
            get { return _hRBonusSaleItemAmountBonusSaleCN; }
            set
            {
                if (value != this._hRBonusSaleItemAmountBonusSaleCN)
                {
                    _hRBonusSaleItemAmountBonusSaleCN = value;
                    NotifyChanged("HRBonusSaleItemAmountBonusSaleCN");
                }
            }
        }
        public decimal HRBonusSaleItemPercentageRetained
        {
            get { return _hRBonusSaleItemPercentageRetained; }
            set
            {
                if (value != this._hRBonusSaleItemPercentageRetained)
                {
                    _hRBonusSaleItemPercentageRetained = value;
                    NotifyChanged("HRBonusSaleItemPercentageRetained");
                }
            }
        }
        public String HRBonusSaleItemPercentageRetainedType
        {
            get { return _hRBonusSaleItemPercentageRetainedType; }
            set
            {
                if (value != this._hRBonusSaleItemPercentageRetainedType)
                {
                    _hRBonusSaleItemPercentageRetainedType = value;
                    NotifyChanged("HRBonusSaleItemPercentageRetainedType");
                }
            }
        }
        public decimal HRBonusSaleItemBonusReachTarget
        {
            get { return _hRBonusSaleItemBonusReachTarget; }
            set
            {
                if (value != this._hRBonusSaleItemBonusReachTarget)
                {
                    _hRBonusSaleItemBonusReachTarget = value;
                    NotifyChanged("HRBonusSaleItemBonusReachTarget");
                }
            }
        }
        public decimal HRBonusSaleItemBonusBeyondTarget
        {
            get { return _hRBonusSaleItemBonusBeyondTarget; }
            set
            {
                if (value != this._hRBonusSaleItemBonusBeyondTarget)
                {
                    _hRBonusSaleItemBonusBeyondTarget = value;
                    NotifyChanged("HRBonusSaleItemBonusBeyondTarget");
                }
            }
        }
        public decimal HRBonusSaleItemMonthlyBonus
        {
            get { return _hRBonusSaleItemMonthlyBonus; }
            set
            {
                if (value != this._hRBonusSaleItemMonthlyBonus)
                {
                    _hRBonusSaleItemMonthlyBonus = value;
                    NotifyChanged("HRBonusSaleItemMonthlyBonus");
                }
            }
        }
        public decimal HRBonusSaleItemTarget
        {
            get { return _hRBonusSaleItemTarget; }
            set
            {
                if (value != this._hRBonusSaleItemTarget)
                {
                    _hRBonusSaleItemTarget = value;
                    NotifyChanged("HRBonusSaleItemTarget");
                }
            }
        }
        public decimal HRBonusSaleItemManagementSalesAmount
        {
            get { return _hRBonusSaleItemManagementSalesAmount; }
            set
            {
                if (value != this._hRBonusSaleItemManagementSalesAmount)
                {
                    _hRBonusSaleItemManagementSalesAmount = value;
                    NotifyChanged("HRBonusSaleItemManagementSalesAmount");
                }
            }
        }
        public decimal HRBonusSaleItemRetainedAmount
        {
            get { return _hRBonusSaleItemRetainedAmount; }
            set
            {
                if (value != this._hRBonusSaleItemRetainedAmount)
                {
                    _hRBonusSaleItemRetainedAmount = value;
                    NotifyChanged("HRBonusSaleItemRetainedAmount");
                }
            }
        }
        #endregion

        #region extra
        public String HREmployeeNo { get; set; }
        public String HREmployeeName { get; set; }
        #endregion
    }
    #endregion
}