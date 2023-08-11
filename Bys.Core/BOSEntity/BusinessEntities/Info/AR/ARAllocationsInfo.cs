﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARAllocations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARAllocationsInfo
    //Created Date:Wednesday, May 16, 2018
    //-----------------------------------------------------------

    public class ARAllocationsInfo : BusinessObject
    {
        public ARAllocationsInfo()
        {
        }
        #region Variables
        protected int _aRAllocationID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HREmployeeID;
        protected int _fK_HRDriverEmployeeID;
        protected int _fK_HRProposedEmployeeID;
        protected int _fK_ARDeliveryPlanID;
        protected String _aRAllocationNo = String.Empty;
        protected String _aRAllocationName = String.Empty;
        protected String _aRAllocationDesc = String.Empty;
        protected String _aRAllocationComment = String.Empty;
        protected DateTime _aRAllocationDate = DateTime.MaxValue;
        protected String _aRAllocationStatus = DefaultStatus;
        protected decimal _aRAllocationExpediencyQty;
        protected int _fK_BRBranchID;
        protected int _fK_PMProjectID;
        #endregion

        #region Public properties
        public int ARAllocationID
        {
            get { return _aRAllocationID; }
            set
            {
                if (value != this._aRAllocationID)
                {
                    _aRAllocationID = value;
                    NotifyChanged("ARAllocationID");
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
        public int FK_HRDriverEmployeeID
        {
            get { return _fK_HRDriverEmployeeID; }
            set
            {
                if (value != this._fK_HRDriverEmployeeID)
                {
                    _fK_HRDriverEmployeeID = value;
                    NotifyChanged("FK_HRDriverEmployeeID");
                }
            }
        }
        public int FK_HRProposedEmployeeID
        {
            get { return _fK_HRProposedEmployeeID; }
            set
            {
                if (value != this._fK_HRProposedEmployeeID)
                {
                    _fK_HRProposedEmployeeID = value;
                    NotifyChanged("FK_HRProposedEmployeeID");
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
        public String ARAllocationNo
        {
            get { return _aRAllocationNo; }
            set
            {
                if (value != this._aRAllocationNo)
                {
                    _aRAllocationNo = value;
                    NotifyChanged("ARAllocationNo");
                }
            }
        }
        public String ARAllocationName
        {
            get { return _aRAllocationName; }
            set
            {
                if (value != this._aRAllocationName)
                {
                    _aRAllocationName = value;
                    NotifyChanged("ARAllocationName");
                }
            }
        }
        public String ARAllocationDesc
        {
            get { return _aRAllocationDesc; }
            set
            {
                if (value != this._aRAllocationDesc)
                {
                    _aRAllocationDesc = value;
                    NotifyChanged("ARAllocationDesc");
                }
            }
        }
        public String ARAllocationComment
        {
            get { return _aRAllocationComment; }
            set
            {
                if (value != this._aRAllocationComment)
                {
                    _aRAllocationComment = value;
                    NotifyChanged("ARAllocationComment");
                }
            }
        }
        public DateTime ARAllocationDate
        {
            get { return _aRAllocationDate; }
            set
            {
                if (value != this._aRAllocationDate)
                {
                    _aRAllocationDate = value;
                    NotifyChanged("ARAllocationDate");
                }
            }
        }
        public String ARAllocationStatus
        {
            get { return _aRAllocationStatus; }
            set
            {
                if (value != this._aRAllocationStatus)
                {
                    _aRAllocationStatus = value;
                    NotifyChanged("ARAllocationStatus");
                }
            }
        }
        public decimal ARAllocationExpediencyQty
        {
            get { return _aRAllocationExpediencyQty; }
            set
            {
                if (value != this._aRAllocationExpediencyQty)
                {
                    _aRAllocationExpediencyQty = value;
                    NotifyChanged("ARAllocationExpediencyQty");
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
        #endregion

        #region Extra Properties

        public byte[] ARAllocationEmployeePicture { get; set; }

        public DateTime ARAllocationDateFrom { get; set; }

        public DateTime ARAllocationDateTo { get; set; }

        #endregion
    }
    #endregion
}