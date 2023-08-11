﻿using BOSLib;
using System;
namespace BOSERP
{
    #region APPaymentProposals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPaymentProposalsInfo
    //Created Date:Monday, November 09, 2015
    //-----------------------------------------------------------

    public class GEPaymentProposalsInfo : BusinessObject
    {
        public GEPaymentProposalsInfo()
        {
        }
        #region Variables
        protected String _gEPaymentProposalNo = String.Empty;
        protected DateTime _gEPaymentProposalDate = DateTime.MaxValue;
        protected String _aCObjectName = String.Empty;
        protected String _gEPriority = String.Empty;
        protected String _gEPaymentProposalDesc = String.Empty;
        protected decimal _gEPaymentProposalTotalAmount;
        protected String _gEPaymentProposalStatusCombo = String.Empty;
        protected String _hREmployeeName = String.Empty;
        protected String _hRDepartmentRoomName = String.Empty;
        protected String _hRDepartmentName = String.Empty;
        #endregion

        #region Public properties

        public String GEPaymentProposalNo
        {
            get { return _gEPaymentProposalNo; }
            set
            {
                if (value != this._gEPaymentProposalNo)
                {
                    _gEPaymentProposalNo = value;
                    NotifyChanged("GEPaymentProposalNo");
                }
            }
        }
        public DateTime GEPaymentProposalDate
        {
            get { return _gEPaymentProposalDate; }
            set
            {
                if (value != this._gEPaymentProposalDate)
                {
                    _gEPaymentProposalDate = value;
                    NotifyChanged("GEPaymentProposalDate");
                }
            }
        }
        public String ACObjectName
        {
            get { return _aCObjectName; }
            set
            {
                if (value != this._aCObjectName)
                {
                    _aCObjectName = value;
                    NotifyChanged("ACObjectName");
                }
            }
        }
        public String GEPriority
        {
            get { return _gEPriority; }
            set
            {
                if (value != this._gEPriority)
                {
                    _gEPriority = value;
                    NotifyChanged("GEPriority");
                }
            }
        }
        public String GEPaymentProposalDesc
        {
            get { return _gEPaymentProposalDesc; }
            set
            {
                if (value != this._gEPaymentProposalDesc)
                {
                    _gEPaymentProposalDesc = value;
                    NotifyChanged("GEPaymentProposalDesc");
                }
            }
        }
        public decimal GEPaymentProposalTotalAmount
        {
            get { return _gEPaymentProposalTotalAmount; }
            set
            {
                if (value != this._gEPaymentProposalTotalAmount)
                {
                    _gEPaymentProposalTotalAmount = value;
                    NotifyChanged("GEPaymentProposalTotalAmount");
                }
            }
        }
        public String GEPaymentProposalStatusCombo
        {
            get { return _gEPaymentProposalStatusCombo; }
            set
            {
                if (value != this._gEPaymentProposalStatusCombo)
                {
                    _gEPaymentProposalStatusCombo = value;
                    NotifyChanged("GEPaymentProposalStatusCombo");
                }
            }
        }
        public String HREmployeeName
        {
            get { return _hREmployeeName; }
            set
            {
                if (value != this._hREmployeeName)
                {
                    _hREmployeeName = value;
                    NotifyChanged("HREmployeeName");
                }
            }
        }
        public String HRDepartmentRoomName
        {
            get { return _hRDepartmentRoomName; }
            set
            {
                if (value != this._hRDepartmentRoomName)
                {
                    _hRDepartmentRoomName = value;
                    NotifyChanged("HRDepartmentRoomName");
                }
            }
        }
        public String HRDepartmentName
        {
            get { return _hRDepartmentName; }
            set
            {
                if (value != this._hRDepartmentName)
                {
                    _hRDepartmentName = value;
                    NotifyChanged("HRDepartmentName");
                }
            }
        }
        #endregion

        #region Extra Properties
        public int GEPaymentProposalID { get; set; }
        public String GEPaymentProposalType { get; set; }
        #endregion
    }
    #endregion
}