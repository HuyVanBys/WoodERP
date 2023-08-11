﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARProductionPlannings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProductionPlanningsInfo
    //Created Date:28 December 2018
    //-----------------------------------------------------------

    public class ARProductionPlanningsInfo : BusinessObject
    {
        public ARProductionPlanningsInfo()
        {
            ARProductionPlanningDesc = new byte[0];
        }
        #region Variables
        protected int _aRProductionPlanningID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARCustomerID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _aRProductionPlanningNo = String.Empty;
        protected String _aRProductionPlanningName = String.Empty;
        protected String _aRProductionPlanningStatus = DefaultStatus;
        protected DateTime _aRProductionPlanningDate = DateTime.MaxValue;
        protected DateTime _aRProductionPlanningFromDate = DateTime.MaxValue;
        protected DateTime _aRProductionPlanningToDate = DateTime.MaxValue;
        protected String _aRProductionPlanningWeek = String.Empty;
        protected String _aRProductionPlanningTypeCombo = String.Empty;
        protected decimal _aRProductionPlanningCBM;
        protected decimal _aRProductionPlanningContQty;
        protected decimal _aRProductionPlanningTotalAmount;
        protected decimal _aRProductionPlanningDepositBalance;
        protected decimal _aRProductionPlanningBalanceDue;
        protected decimal _aRProductionPlanningDiscountPerCent;
        protected decimal _aRProductionPlanningDiscountFix;
        protected decimal _aRProductionPlanningTaxPerCent;
        protected decimal _aRProductionPlanningTaxAmount;
        protected int _fK_MMWorkShopID;
        protected decimal _aRProductionPlanningTotalBlock;
        protected String _aRProductionPlanningSources = String.Empty;
        protected DateTime _aRProductionPlanningApprovedDate = DateTime.MaxValue;
        protected int _fK_HREmployeeApprovedID;
        protected String _aRProductionPlanningType = String.Empty;
        protected int _fK_ICProductAttributeTTMTID;
        protected String _aRProductionPlanningSaleType = String.Empty;
        protected string _aRProductionPlanningComment = string.Empty;
        protected byte[] _aRProductionPlanningDesc;
        protected string _aRProductionPlanningSaleOrderName = string.Empty;
        #endregion

        #region Public properties
        public int ARProductionPlanningID
        {
            get { return _aRProductionPlanningID; }
            set
            {
                if (value != this._aRProductionPlanningID)
                {
                    _aRProductionPlanningID = value;
                    NotifyChanged("ARProductionPlanningID");
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
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
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        public String ARProductionPlanningNo
        {
            get { return _aRProductionPlanningNo; }
            set
            {
                if (value != this._aRProductionPlanningNo)
                {
                    _aRProductionPlanningNo = value;
                    NotifyChanged("ARProductionPlanningNo");
                }
            }
        }
        public String ARProductionPlanningName
        {
            get { return _aRProductionPlanningName; }
            set
            {
                if (value != this._aRProductionPlanningName)
                {
                    _aRProductionPlanningName = value;
                    NotifyChanged("ARProductionPlanningName");
                }
            }
        }
        public String ARProductionPlanningStatus
        {
            get { return _aRProductionPlanningStatus; }
            set
            {
                if (value != this._aRProductionPlanningStatus)
                {
                    _aRProductionPlanningStatus = value;
                    NotifyChanged("ARProductionPlanningStatus");
                }
            }
        }
        public DateTime ARProductionPlanningDate
        {
            get { return _aRProductionPlanningDate; }
            set
            {
                if (value != this._aRProductionPlanningDate)
                {
                    _aRProductionPlanningDate = value;
                    NotifyChanged("ARProductionPlanningDate");
                }
            }
        }
        public DateTime ARProductionPlanningFromDate
        {
            get { return _aRProductionPlanningFromDate; }
            set
            {
                if (value != this._aRProductionPlanningFromDate)
                {
                    _aRProductionPlanningFromDate = value;
                    NotifyChanged("ARProductionPlanningFromDate");
                }
            }
        }
        public DateTime ARProductionPlanningToDate
        {
            get { return _aRProductionPlanningToDate; }
            set
            {
                if (value != this._aRProductionPlanningToDate)
                {
                    _aRProductionPlanningToDate = value;
                    NotifyChanged("ARProductionPlanningToDate");
                }
            }
        }
        public String ARProductionPlanningWeek
        {
            get { return _aRProductionPlanningWeek; }
            set
            {
                if (value != this._aRProductionPlanningWeek)
                {
                    _aRProductionPlanningWeek = value;
                    NotifyChanged("ARProductionPlanningWeek");
                }
            }
        }
        public String ARProductionPlanningTypeCombo
        {
            get { return _aRProductionPlanningTypeCombo; }
            set
            {
                if (value != this._aRProductionPlanningTypeCombo)
                {
                    _aRProductionPlanningTypeCombo = value;
                    NotifyChanged("ARProductionPlanningTypeCombo");
                }
            }
        }
        public decimal ARProductionPlanningCBM
        {
            get { return _aRProductionPlanningCBM; }
            set
            {
                if (value != this._aRProductionPlanningCBM)
                {
                    _aRProductionPlanningCBM = value;
                    NotifyChanged("ARProductionPlanningCBM");
                }
            }
        }
        public decimal ARProductionPlanningContQty
        {
            get { return _aRProductionPlanningContQty; }
            set
            {
                if (value != this._aRProductionPlanningContQty)
                {
                    _aRProductionPlanningContQty = value;
                    NotifyChanged("ARProductionPlanningContQty");
                }
            }
        }
        public decimal ARProductionPlanningTotalAmount
        {
            get { return _aRProductionPlanningTotalAmount; }
            set
            {
                if (value != this._aRProductionPlanningTotalAmount)
                {
                    _aRProductionPlanningTotalAmount = value;
                    NotifyChanged("ARProductionPlanningTotalAmount");
                }
            }
        }
        public decimal ARProductionPlanningDepositBalance
        {
            get { return _aRProductionPlanningDepositBalance; }
            set
            {
                if (value != this._aRProductionPlanningDepositBalance)
                {
                    _aRProductionPlanningDepositBalance = value;
                    NotifyChanged("ARProductionPlanningDepositBalance");
                }
            }
        }
        public decimal ARProductionPlanningBalanceDue
        {
            get { return _aRProductionPlanningBalanceDue; }
            set
            {
                if (value != this._aRProductionPlanningBalanceDue)
                {
                    _aRProductionPlanningBalanceDue = value;
                    NotifyChanged("ARProductionPlanningBalanceDue");
                }
            }
        }
        public decimal ARProductionPlanningDiscountPerCent
        {
            get { return _aRProductionPlanningDiscountPerCent; }
            set
            {
                if (value != this._aRProductionPlanningDiscountPerCent)
                {
                    _aRProductionPlanningDiscountPerCent = value;
                    NotifyChanged("ARProductionPlanningDiscountPerCent");
                }
            }
        }
        public decimal ARProductionPlanningDiscountFix
        {
            get { return _aRProductionPlanningDiscountFix; }
            set
            {
                if (value != this._aRProductionPlanningDiscountFix)
                {
                    _aRProductionPlanningDiscountFix = value;
                    NotifyChanged("ARProductionPlanningDiscountFix");
                }
            }
        }
        public decimal ARProductionPlanningTaxPerCent
        {
            get { return _aRProductionPlanningTaxPerCent; }
            set
            {
                if (value != this._aRProductionPlanningTaxPerCent)
                {
                    _aRProductionPlanningTaxPerCent = value;
                    NotifyChanged("ARProductionPlanningTaxPerCent");
                }
            }
        }
        public decimal ARProductionPlanningTaxAmount
        {
            get { return _aRProductionPlanningTaxAmount; }
            set
            {
                if (value != this._aRProductionPlanningTaxAmount)
                {
                    _aRProductionPlanningTaxAmount = value;
                    NotifyChanged("ARProductionPlanningTaxAmount");
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
        public decimal ARProductionPlanningTotalBlock
        {
            get { return _aRProductionPlanningTotalBlock; }
            set
            {
                if (value != this._aRProductionPlanningTotalBlock)
                {
                    _aRProductionPlanningTotalBlock = value;
                    NotifyChanged("ARProductionPlanningTotalBlock");
                }
            }
        }
        public String ARProductionPlanningSources
        {
            get { return _aRProductionPlanningSources; }
            set
            {
                if (value != this._aRProductionPlanningSources)
                {
                    _aRProductionPlanningSources = value;
                    NotifyChanged("ARProductionPlanningSources");
                }
            }
        }
        public DateTime ARProductionPlanningApprovedDate
        {
            get { return _aRProductionPlanningApprovedDate; }
            set
            {
                if (value != this._aRProductionPlanningApprovedDate)
                {
                    _aRProductionPlanningApprovedDate = value;
                    NotifyChanged("ARProductionPlanningApprovedDate");
                }
            }
        }
        public int FK_HREmployeeApprovedID
        {
            get { return _fK_HREmployeeApprovedID; }
            set
            {
                if (value != this._fK_HREmployeeApprovedID)
                {
                    _fK_HREmployeeApprovedID = value;
                    NotifyChanged("FK_HREmployeeApprovedID");
                }
            }
        }
        public String ARProductionPlanningType
        {
            get { return _aRProductionPlanningType; }
            set
            {
                if (value != this._aRProductionPlanningType)
                {
                    _aRProductionPlanningType = value;
                    NotifyChanged("ARProductionPlanningType");
                }
            }
        }
        public int FK_ICProductAttributeTTMTID
        {
            get { return _fK_ICProductAttributeTTMTID; }
            set
            {
                if (value != this._fK_ICProductAttributeTTMTID)
                {
                    _fK_ICProductAttributeTTMTID = value;
                    NotifyChanged("FK_ICProductAttributeTTMTID");
                }
            }
        }
        public String ARProductionPlanningSaleType
        {
            get { return _aRProductionPlanningSaleType; }
            set
            {
                if (value != this._aRProductionPlanningSaleType)
                {
                    _aRProductionPlanningSaleType = value;
                    NotifyChanged("ARProductionPlanningSaleType");
                }    
            }    
        }
        public string ARProductionPlanningComment
        {
            get { return _aRProductionPlanningComment; }
            set
            {
                if (value != this._aRProductionPlanningComment)
                {
                    _aRProductionPlanningComment = value;
                    NotifyChanged("ARProductionPlanningComment");
                }
            }
        }
        public byte[] ARProductionPlanningDesc
        {
            get { return _aRProductionPlanningDesc; }
            set
            {
                if (value != this._aRProductionPlanningDesc)
                {
                    _aRProductionPlanningDesc = value;
                    NotifyChanged("ARProductionPlanningDesc");
                }
            }
        }
        public string ARProductionPlanningSaleOrderName
        {
            get { return _aRProductionPlanningSaleOrderName; }
            set
            {
                if (value != this._aRProductionPlanningSaleOrderName)
                {
                    _aRProductionPlanningSaleOrderName = value;
                    NotifyChanged("ARProductionPlanningSaleOrderName");
                }
            }
        }
        #endregion

        #region Extra Properties
        public DateTime ProductionPlanningFromDate { get; set; }
        public DateTime ProductionPlanningToDate { get; set; }
        public DateTime ARSaleOrderItemDeliveryDate { get; set; }
        public byte[] ARProductionPlanningEmployeePicture { get; set; }
        public string ARSaleOrderNo { get; set; }
        public string ARSaleForecastNo { get; set; }
        public int FK_ICProductID { get; set; }
        public string ARCustomerName { get; set; }
        public string ReferenceNo { get; set; }

        public string ACObjectName { get; set; }

        public string ARSaleOrderRef { get; set; }

        public string ARProductionPlanningObjectNames { get; set; }

        public string ARSaleOrderNos { get; set; }
        public string ACObjectAccessKey { get; set; }
        public int FK_ACObjectID { get; set; }
        public string ACObjectType { get; set; }
        #endregion
    }
    #endregion
}