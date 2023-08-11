﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARPaymentProposals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARPaymentProposalsInfo
    //Created Date:Monday, November 09, 2015
    //-----------------------------------------------------------

    public class ARPaymentProposalsInfo : BusinessObject
    {
        public ARPaymentProposalsInfo()
        {
        }
        #region Variables
        protected int _aRPaymentProposalID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HREmployeeID;
        protected int _fK_HRDepartmentID;
        protected int _fK_HRDepartmentRoomID;
        protected int _fK_ARCustomerID;
        protected int _fK_ARSaleOrderID;
        protected int _fK_ICReceiptID;
        protected int _fK_ARInvoiceID;
        protected String _aRPaymentProposalNo = String.Empty;
        protected String _aRPaymentProposalName = String.Empty;
        protected String _aRPaymentProposalDesc = String.Empty;
        protected DateTime _aRPaymentProposalDate = DateTime.MaxValue;
        protected DateTime _aRPaymentProposalPayDate = DateTime.MaxValue;
        protected String _aRPaymentProposalTypeCombo = String.Empty;
        protected String _aRPaymentProposalStatusCombo = DefaultStatus;
        protected String _aRPriority = String.Empty;
        protected String _aRPaymentProposalPaymentMethodCombo = String.Empty;
        protected String _aRPaymentProposalInvoiceNo = String.Empty;
        protected String _aRPaymentProposalReceiptNo = String.Empty;
        protected String _aRPaymentProposalBookNo = String.Empty;
        protected decimal _aRPaymentProposalRemainAmount;
        protected decimal _aRPaymentProposalPaidAmount;
        protected decimal _aRPaymentProposalTotalAmount;
        protected String _aRPaymentProposalRemark = String.Empty;
        protected String _aRPaymentProposalDocAttachCombo = String.Empty;
        protected int _fK_HREmployeeAccountantID;
        protected int _fK_HREmployeeManagerID;
        protected int _fK_HREmployeeHeadDepartmentID;
        protected DateTime _aRPaymentProposalCheckDate = DateTime.MaxValue;
        protected DateTime _aRPaymentProposalApproveDate = DateTime.MaxValue;
        protected DateTime _aRPaymentProposalConfirmDate = DateTime.MaxValue;
        protected DateTime _aRPaymentProposalApprovePaymentDate = DateTime.MaxValue;
        protected int _fK_HREmployeeHeadAccountantID;
        protected int _fK_ACSegmentID;
        protected String _aRPaymentProposalApproveStatus = DefaultStatus;
        protected int _fK_ACAssObjectID;
        protected String _aRAssObjectType = String.Empty;
        protected int _fK_HREmployeeReceipt;
        protected int _fK_BRBranchID;
        protected int _fK_PMProjectID;
        protected int _fK_AROpportunityID;
        #endregion

        #region Public properties
        public int ARPaymentProposalID
        {
            get { return _aRPaymentProposalID; }
            set
            {
                if (value != this._aRPaymentProposalID)
                {
                    _aRPaymentProposalID = value;
                    NotifyChanged("ARPaymentProposalID");
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
        public int FK_PMProjectID
        {
            get { return _fK_PMProjectID; }
            set
            {
                if (value != this._fK_PMProjectID)
                {
                    _fK_PMProjectID = value;
                    NotifyChanged("FK_PMProjectID");
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
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                    NotifyChanged("FK_ICReceiptID");
                }
            }
        }
        public int FK_ARInvoiceID
        {
            get { return _fK_ARInvoiceID; }
            set
            {
                if (value != this._fK_ARInvoiceID)
                {
                    _fK_ARInvoiceID = value;
                    NotifyChanged("FK_ARInvoiceID");
                }
            }
        }
        public String ARPaymentProposalNo
        {
            get { return _aRPaymentProposalNo; }
            set
            {
                if (value != this._aRPaymentProposalNo)
                {
                    _aRPaymentProposalNo = value;
                    NotifyChanged("ARPaymentProposalNo");
                }
            }
        }
        public String ARPaymentProposalName
        {
            get { return _aRPaymentProposalName; }
            set
            {
                if (value != this._aRPaymentProposalName)
                {
                    _aRPaymentProposalName = value;
                    NotifyChanged("ARPaymentProposalName");
                }
            }
        }
        public String ARPaymentProposalDesc
        {
            get { return _aRPaymentProposalDesc; }
            set
            {
                if (value != this._aRPaymentProposalDesc)
                {
                    _aRPaymentProposalDesc = value;
                    NotifyChanged("ARPaymentProposalDesc");
                }
            }
        }
        public DateTime ARPaymentProposalDate
        {
            get { return _aRPaymentProposalDate; }
            set
            {
                if (value != this._aRPaymentProposalDate)
                {
                    _aRPaymentProposalDate = value;
                    NotifyChanged("ARPaymentProposalDate");
                }
            }
        }
        public DateTime ARPaymentProposalPayDate
        {
            get { return _aRPaymentProposalPayDate; }
            set
            {
                if (value != this._aRPaymentProposalPayDate)
                {
                    _aRPaymentProposalPayDate = value;
                    NotifyChanged("ARPaymentProposalPayDate");
                }
            }
        }
        public String ARPaymentProposalTypeCombo
        {
            get { return _aRPaymentProposalTypeCombo; }
            set
            {
                if (value != this._aRPaymentProposalTypeCombo)
                {
                    _aRPaymentProposalTypeCombo = value;
                    NotifyChanged("ARPaymentProposalTypeCombo");
                }
            }
        }
        public String ARPaymentProposalStatusCombo
        {
            get { return _aRPaymentProposalStatusCombo; }
            set
            {
                if (value != this._aRPaymentProposalStatusCombo)
                {
                    _aRPaymentProposalStatusCombo = value;
                    NotifyChanged("ARPaymentProposalStatusCombo");
                }
            }
        }
        public String ARPriority
        {
            get { return _aRPriority; }
            set
            {
                if (value != this._aRPriority)
                {
                    _aRPriority = value;
                    NotifyChanged("ARPriority");
                }
            }
        }
        public String ARPaymentProposalPaymentMethodCombo
        {
            get { return _aRPaymentProposalPaymentMethodCombo; }
            set
            {
                if (value != this._aRPaymentProposalPaymentMethodCombo)
                {
                    _aRPaymentProposalPaymentMethodCombo = value;
                    NotifyChanged("ARPaymentProposalPaymentMethodCombo");
                }
            }
        }
        public String ARPaymentProposalInvoiceNo
        {
            get { return _aRPaymentProposalInvoiceNo; }
            set
            {
                if (value != this._aRPaymentProposalInvoiceNo)
                {
                    _aRPaymentProposalInvoiceNo = value;
                    NotifyChanged("ARPaymentProposalInvoiceNo");
                }
            }
        }
        public String ARPaymentProposalReceiptNo
        {
            get { return _aRPaymentProposalReceiptNo; }
            set
            {
                if (value != this._aRPaymentProposalReceiptNo)
                {
                    _aRPaymentProposalReceiptNo = value;
                    NotifyChanged("ARPaymentProposalReceiptNo");
                }
            }
        }
        public String ARPaymentProposalBookNo
        {
            get { return _aRPaymentProposalBookNo; }
            set
            {
                if (value != this._aRPaymentProposalBookNo)
                {
                    _aRPaymentProposalBookNo = value;
                    NotifyChanged("ARPaymentProposalBookNo");
                }
            }
        }
        public decimal ARPaymentProposalRemainAmount
        {
            get { return _aRPaymentProposalRemainAmount; }
            set
            {
                if (value != this._aRPaymentProposalRemainAmount)
                {
                    _aRPaymentProposalRemainAmount = value;
                    NotifyChanged("ARPaymentProposalRemainAmount");
                }
            }
        }
        public decimal ARPaymentProposalPaidAmount
        {
            get { return _aRPaymentProposalPaidAmount; }
            set
            {
                if (value != this._aRPaymentProposalPaidAmount)
                {
                    _aRPaymentProposalPaidAmount = value;
                    NotifyChanged("ARPaymentProposalPaidAmount");
                }
            }
        }
        public decimal ARPaymentProposalTotalAmount
        {
            get { return _aRPaymentProposalTotalAmount; }
            set
            {
                if (value != this._aRPaymentProposalTotalAmount)
                {
                    _aRPaymentProposalTotalAmount = value;
                    NotifyChanged("ARPaymentProposalTotalAmount");
                }
            }
        }
        public String ARPaymentProposalRemark
        {
            get { return _aRPaymentProposalRemark; }
            set
            {
                if (value != this._aRPaymentProposalRemark)
                {
                    _aRPaymentProposalRemark = value;
                    NotifyChanged("ARPaymentProposalRemark");
                }
            }
        }
        public String ARPaymentProposalDocAttachCombo
        {
            get { return _aRPaymentProposalDocAttachCombo; }
            set
            {
                if (value != this._aRPaymentProposalDocAttachCombo)
                {
                    _aRPaymentProposalDocAttachCombo = value;
                    NotifyChanged("ARPaymentProposalDocAttachCombo");
                }
            }
        }
        public int FK_HREmployeeAccountantID
        {
            get { return _fK_HREmployeeAccountantID; }
            set
            {
                if (value != this._fK_HREmployeeAccountantID)
                {
                    _fK_HREmployeeAccountantID = value;
                    NotifyChanged("FK_HREmployeeAccountantID");
                }
            }
        }
        public int FK_HREmployeeManagerID
        {
            get { return _fK_HREmployeeManagerID; }
            set
            {
                if (value != this._fK_HREmployeeManagerID)
                {
                    _fK_HREmployeeManagerID = value;
                    NotifyChanged("FK_HREmployeeManagerID");
                }
            }
        }
        public int FK_HREmployeeHeadDepartmentID
        {
            get { return _fK_HREmployeeHeadDepartmentID; }
            set
            {
                if (value != this._fK_HREmployeeHeadDepartmentID)
                {
                    _fK_HREmployeeHeadDepartmentID = value;
                    NotifyChanged("FK_HREmployeeHeadDepartmentID");
                }
            }
        }
        public DateTime ARPaymentProposalCheckDate
        {
            get { return _aRPaymentProposalCheckDate; }
            set
            {
                if (value != this._aRPaymentProposalCheckDate)
                {
                    _aRPaymentProposalCheckDate = value;
                    NotifyChanged("ARPaymentProposalCheckDate");
                }
            }
        }
        public DateTime ARPaymentProposalApproveDate
        {
            get { return _aRPaymentProposalApproveDate; }
            set
            {
                if (value != this._aRPaymentProposalApproveDate)
                {
                    _aRPaymentProposalApproveDate = value;
                    NotifyChanged("ARPaymentProposalApproveDate");
                }
            }
        }
        public DateTime ARPaymentProposalConfirmDate
        {
            get { return _aRPaymentProposalConfirmDate; }
            set
            {
                if (value != this._aRPaymentProposalConfirmDate)
                {
                    _aRPaymentProposalConfirmDate = value;
                    NotifyChanged("ARPaymentProposalConfirmDate");
                }
            }
        }
        public DateTime ARPaymentProposalApprovePaymentDate
        {
            get { return _aRPaymentProposalApprovePaymentDate; }
            set
            {
                if (value != this._aRPaymentProposalApprovePaymentDate)
                {
                    _aRPaymentProposalApprovePaymentDate = value;
                    NotifyChanged("ARPaymentProposalApprovePaymentDate");
                }
            }
        }
        public int FK_HREmployeeHeadAccountantID
        {
            get { return _fK_HREmployeeHeadAccountantID; }
            set
            {
                if (value != this._fK_HREmployeeHeadAccountantID)
                {
                    _fK_HREmployeeHeadAccountantID = value;
                    NotifyChanged("FK_HREmployeeHeadAccountantID");
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
        public String ARPaymentProposalApproveStatus
        {
            get { return _aRPaymentProposalApproveStatus; }
            set
            {
                if (value != this._aRPaymentProposalApproveStatus)
                {
                    _aRPaymentProposalApproveStatus = value;
                    NotifyChanged("ARPaymentProposalApproveStatus");
                }
            }
        }
        public int FK_ACAssObjectID
        {
            get { return _fK_ACAssObjectID; }
            set
            {
                if (value != this._fK_ACAssObjectID)
                {
                    _fK_ACAssObjectID = value;
                    NotifyChanged("FK_ACAssObjectID");
                }
            }
        }
        public String ARAssObjectType
        {
            get { return _aRAssObjectType; }
            set
            {
                if (value != this._aRAssObjectType)
                {
                    _aRAssObjectType = value;
                    NotifyChanged("ARAssObjectType");
                }
            }
        }
        public int FK_HREmployeeReceipt
        {
            get { return _fK_HREmployeeReceipt; }
            set
            {
                if (value != this._fK_HREmployeeReceipt)
                {
                    _fK_HREmployeeReceipt = value;
                    NotifyChanged("FK_HREmployeeReceipt");
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
        public int FK_AROpportunityID
        {
            get { return _fK_AROpportunityID; }
            set
            {
                if (value != this._fK_AROpportunityID)
                {
                    _fK_AROpportunityID = value;
                    NotifyChanged("FK_AROpportunityID");
                }
            }
        }
        #endregion

        #region Extra Properties
        public DateTime PaymentProposalDateFrom { get; set; }
        public DateTime PaymentProposalDateTo { get; set; }
        public string ACAssObjectAccessKey { get; set; }
        public string ACObjectName { get; set; }
        public string ARCustomerPaymentNo { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal ARPaymentProposalItemProposalAmount { get; set; }
        public string ARPaymentProposalProspectCustomer { get; set; }
        public ARCustomersInfo CustomersInfo { get; set; }
        public string ARInvoiceNo { get; set; }
        public string ARSaleOrderNo { get; set; }
        #endregion Extra Properties
    }
    #endregion
}