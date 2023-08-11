﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARReceptions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARReceptionsInfo
    //Created Date:Friday, May 18, 2018
    //-----------------------------------------------------------

    public class ARReceptionsInfo : BusinessObject
    {
        public ARReceptionsInfo()
        {
        }
        #region Variables
        protected int _aRReceptionID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HREmployeeID;
        protected int _fK_HRDriverEmployeeID;
        protected int _fK_HRReturnEmployeeID;
        protected int _fK_ARDeliveryPlanID;
        protected String _aRReceptionNo = String.Empty;
        protected String _aRReceptionName = String.Empty;
        protected String _aRReceptionDesc = String.Empty;
        protected String _aRReceptionComment = String.Empty;
        protected DateTime _aRReceptionDate = DateTime.MaxValue;
        protected String _aRReceptionStatus = DefaultStatus;
        protected decimal _aRReceptionExpediencyQty;
        protected int _fK_BRBranchID;
        protected int _fK_ARAllocationID;
        protected String _aRReceptionType = String.Empty;
        protected int _fK_ACEquipmentStateID;
        #endregion

        #region Public properties
        public int ARReceptionID
        {
            get { return _aRReceptionID; }
            set
            {
                if (value != this._aRReceptionID)
                {
                    _aRReceptionID = value;
                    NotifyChanged("ARReceptionID");
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
        public int FK_HRReturnEmployeeID
        {
            get { return _fK_HRReturnEmployeeID; }
            set
            {
                if (value != this._fK_HRReturnEmployeeID)
                {
                    _fK_HRReturnEmployeeID = value;
                    NotifyChanged("FK_HRReturnEmployeeID");
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
        public String ARReceptionNo
        {
            get { return _aRReceptionNo; }
            set
            {
                if (value != this._aRReceptionNo)
                {
                    _aRReceptionNo = value;
                    NotifyChanged("ARReceptionNo");
                }
            }
        }
        public String ARReceptionName
        {
            get { return _aRReceptionName; }
            set
            {
                if (value != this._aRReceptionName)
                {
                    _aRReceptionName = value;
                    NotifyChanged("ARReceptionName");
                }
            }
        }
        public String ARReceptionDesc
        {
            get { return _aRReceptionDesc; }
            set
            {
                if (value != this._aRReceptionDesc)
                {
                    _aRReceptionDesc = value;
                    NotifyChanged("ARReceptionDesc");
                }
            }
        }
        public String ARReceptionComment
        {
            get { return _aRReceptionComment; }
            set
            {
                if (value != this._aRReceptionComment)
                {
                    _aRReceptionComment = value;
                    NotifyChanged("ARReceptionComment");
                }
            }
        }
        public DateTime ARReceptionDate
        {
            get { return _aRReceptionDate; }
            set
            {
                if (value != this._aRReceptionDate)
                {
                    _aRReceptionDate = value;
                    NotifyChanged("ARReceptionDate");
                }
            }
        }
        public String ARReceptionStatus
        {
            get { return _aRReceptionStatus; }
            set
            {
                if (value != this._aRReceptionStatus)
                {
                    _aRReceptionStatus = value;
                    NotifyChanged("ARReceptionStatus");
                }
            }
        }
        public decimal ARReceptionExpediencyQty
        {
            get { return _aRReceptionExpediencyQty; }
            set
            {
                if (value != this._aRReceptionExpediencyQty)
                {
                    _aRReceptionExpediencyQty = value;
                    NotifyChanged("ARReceptionExpediencyQty");
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
        public int FK_ARAllocationID
        {
            get { return _fK_ARAllocationID; }
            set
            {
                if (value != this._fK_ARAllocationID)
                {
                    _fK_ARAllocationID = value;
                    NotifyChanged("FK_ARAllocationID");
                }
            }
        }
        public String ARReceptionType
        {
            get { return _aRReceptionType; }
            set
            {
                if (value != this._aRReceptionType)
                {
                    _aRReceptionType = value;
                    NotifyChanged("ARReceptionType");
                }
            }
        }
        public int FK_ACEquipmentStateID
        {
            get { return _fK_ACEquipmentStateID; }
            set
            {
                if (value != this._fK_ACEquipmentStateID)
                {
                    _fK_ACEquipmentStateID = value;
                    NotifyChanged("FK_ACEquipmentStateID");
                }
            }
        }
        #endregion

        #region Extra Properties

        public byte[] ARReceptionEmployeePicture { get; set; }

        public DateTime ARReceptionDateFrom { get; set; }

        public DateTime ARReceptionDateTo { get; set; }

        #endregion
    }
    #endregion
}