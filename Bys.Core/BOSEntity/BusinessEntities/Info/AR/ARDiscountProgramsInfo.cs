﻿using BOSLib;
using System;
using System.ComponentModel;

namespace BOSERP
{
    #region ARDiscountPrograms
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDiscountProgramsInfo
    //Created Date:Friday, July 19, 2019
    //-----------------------------------------------------------

    public class ARDiscountProgramsInfo : BusinessObject
    {
        public ARDiscountProgramsInfo()
        {
        }
        #region Variables
        protected int _aRDiscountProgramID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aRDiscountProgramNo = String.Empty;
        protected String _aRDiscountProgramName = String.Empty;
        protected String _aRDiscountProgramDesc = String.Empty;
        protected DateTime _aRDiscountProgramDate = DateTime.MaxValue;
        protected DateTime _aRDiscountProgramBeginDate = DateTime.MaxValue;
        protected DateTime _aRDiscountProgramEndDate = DateTime.MaxValue;
        protected String _aRDiscountProgramType = String.Empty;
        protected String _aRDiscountProgramMethodType = String.Empty;
        protected String _aRDiscountProgramApplyType = String.Empty;
        protected String _aRDiscountProgramCalMethod = String.Empty;
        protected decimal _aRDiscountProgramValue;
        protected String _aRDiscountProgramApplyOn = String.Empty;
        protected String _aRDiscountProgramStatus = DefaultStatus;
        protected int _fK_HREmployeeID;
        protected int _fK_ARCustomerDistributionChannelID;
        protected bool _aRDiscountProgramIsExhibit = false;
        protected bool _aRDiscountProgramIsSales = false;
        protected decimal _aRDiscountProgramSaleTarget;
        protected int _fK_ACObjectID;
        protected String _aRObjectType = String.Empty;
        protected int _fK_BRBranchID;
        protected string _aRDiscountProgramCode = string.Empty;
        protected bool _aRDiscountProgramTogether = true;
        protected int _aRDiscountProgramQuantityApplied;
        protected int _aRDiscountProgramRemainQuantityApplied;
        protected bool _aRDiscountProgramIsVoucher = true;
        #endregion

        #region Public properties
        public int ARDiscountProgramID
        {
            get { return _aRDiscountProgramID; }
            set
            {
                if (value != this._aRDiscountProgramID)
                {
                    _aRDiscountProgramID = value;
                    NotifyChanged("ARDiscountProgramID");
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
        public String ARDiscountProgramNo
        {
            get { return _aRDiscountProgramNo; }
            set
            {
                if (value != this._aRDiscountProgramNo)
                {
                    _aRDiscountProgramNo = value;
                    NotifyChanged("ARDiscountProgramNo");
                }
            }
        }
        public String ARDiscountProgramName
        {
            get { return _aRDiscountProgramName; }
            set
            {
                if (value != this._aRDiscountProgramName)
                {
                    _aRDiscountProgramName = value;
                    NotifyChanged("ARDiscountProgramName");
                }
            }
        }
        public String ARDiscountProgramDesc
        {
            get { return _aRDiscountProgramDesc; }
            set
            {
                if (value != this._aRDiscountProgramDesc)
                {
                    _aRDiscountProgramDesc = value;
                    NotifyChanged("ARDiscountProgramDesc");
                }
            }
        }
        public DateTime ARDiscountProgramDate
        {
            get { return _aRDiscountProgramDate; }
            set
            {
                if (value != this._aRDiscountProgramDate)
                {
                    _aRDiscountProgramDate = value;
                    NotifyChanged("ARDiscountProgramDate");
                }
            }
        }
        public DateTime ARDiscountProgramBeginDate
        {
            get { return _aRDiscountProgramBeginDate; }
            set
            {
                if (value != this._aRDiscountProgramBeginDate)
                {
                    _aRDiscountProgramBeginDate = value;
                    NotifyChanged("ARDiscountProgramBeginDate");
                }
            }
        }
        public DateTime ARDiscountProgramEndDate
        {
            get { return _aRDiscountProgramEndDate; }
            set
            {
                if (value != this._aRDiscountProgramEndDate)
                {
                    _aRDiscountProgramEndDate = value;
                    NotifyChanged("ARDiscountProgramEndDate");
                }
            }
        }
        public String ARDiscountProgramType
        {
            get { return _aRDiscountProgramType; }
            set
            {
                if (value != this._aRDiscountProgramType)
                {
                    _aRDiscountProgramType = value;
                    NotifyChanged("ARDiscountProgramType");
                }
            }
        }
        public String ARDiscountProgramMethodType
        {
            get { return _aRDiscountProgramMethodType; }
            set
            {
                if (value != this._aRDiscountProgramMethodType)
                {
                    _aRDiscountProgramMethodType = value;
                    NotifyChanged("ARDiscountProgramMethodType");
                }
            }
        }
        public String ARDiscountProgramApplyType
        {
            get { return _aRDiscountProgramApplyType; }
            set
            {
                if (value != this._aRDiscountProgramApplyType)
                {
                    _aRDiscountProgramApplyType = value;
                    NotifyChanged("ARDiscountProgramApplyType");
                }
            }
        }
        public String ARDiscountProgramCalMethod
        {
            get { return _aRDiscountProgramCalMethod; }
            set
            {
                if (value != this._aRDiscountProgramCalMethod)
                {
                    _aRDiscountProgramCalMethod = value;
                    NotifyChanged("ARDiscountProgramCalMethod");
                }
            }
        }
        public decimal ARDiscountProgramValue
        {
            get { return _aRDiscountProgramValue; }
            set
            {
                if (value != this._aRDiscountProgramValue)
                {
                    _aRDiscountProgramValue = value;
                    NotifyChanged("ARDiscountProgramValue");
                }
            }
        }
        public String ARDiscountProgramApplyOn
        {
            get { return _aRDiscountProgramApplyOn; }
            set
            {
                if (value != this._aRDiscountProgramApplyOn)
                {
                    _aRDiscountProgramApplyOn = value;
                    NotifyChanged("ARDiscountProgramApplyOn");
                }
            }
        }

        public String ARDiscountProgramStatus
        {
            get { return _aRDiscountProgramStatus; }
            set
            {
                if (value != this._aRDiscountProgramStatus)
                {
                    _aRDiscountProgramStatus = value;
                    NotifyChanged("ARDiscountProgramStatus");
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
        public int FK_ARCustomerDistributionChannelID
        {
            get { return _fK_ARCustomerDistributionChannelID; }
            set
            {
                if (value != this._fK_ARCustomerDistributionChannelID)
                {
                    _fK_ARCustomerDistributionChannelID = value;
                    NotifyChanged("FK_ARCustomerDistributionChannelID");
                }
            }
        }
        public bool ARDiscountProgramIsExhibit
        {
            get { return _aRDiscountProgramIsExhibit; }
            set
            {
                if (value != this._aRDiscountProgramIsExhibit)
                {
                    _aRDiscountProgramIsExhibit = value;
                    NotifyChanged("ARDiscountProgramIsExhibit");
                }
            }
        }
        public bool ARDiscountProgramIsSales
        {
            get { return _aRDiscountProgramIsSales; }
            set
            {
                if (value != this._aRDiscountProgramIsSales)
                {
                    _aRDiscountProgramIsSales = value;
                    NotifyChanged("ARDiscountProgramIsSales");
                }
            }
        }
        public decimal ARDiscountProgramSaleTarget
        {
            get { return _aRDiscountProgramSaleTarget; }
            set
            {
                if (value != this._aRDiscountProgramSaleTarget)
                {
                    _aRDiscountProgramSaleTarget = value;
                    NotifyChanged("ARDiscountProgramSaleTarget");
                }
            }
        }
        public int FK_ACObjectID
        {
            get { return _fK_ACObjectID; }
            set
            {
                if (value != this._fK_ACObjectID)
                {
                    _fK_ACObjectID = value;
                    NotifyChanged("FK_ACObjectID");
                }
            }
        }
        public String ARObjectType
        {
            get { return _aRObjectType; }
            set
            {
                if (value != this._aRObjectType)
                {
                    _aRObjectType = value;
                    NotifyChanged("ARObjectType");
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
        public string ARDiscountProgramCode
        {
            get { return _aRDiscountProgramCode; }
            set
            {
                if (value != this._aRDiscountProgramCode)
                {
                    _aRDiscountProgramCode = value;
                    NotifyChanged("ARDiscountProgramCode");
                }
            }
        }
        public bool ARDiscountProgramTogether
        {
            get { return _aRDiscountProgramTogether; }
            set
            {
                if (value != this._aRDiscountProgramTogether)
                {
                    _aRDiscountProgramTogether = value;
                    NotifyChanged("ARDiscountProgramTogether");
                }
            }
        }
        public int ARDiscountProgramQuantityApplied
        {
            get { return _aRDiscountProgramQuantityApplied; }
            set
            {
                if (value != this._aRDiscountProgramQuantityApplied)
                {
                    _aRDiscountProgramQuantityApplied = value;
                    NotifyChanged("ARDiscountProgramQuantityApplied");
                }
            }
        }
        public int ARDiscountProgramRemainQuantityApplied
        {
            get { return _aRDiscountProgramRemainQuantityApplied; }
            set
            {
                if (value != this._aRDiscountProgramRemainQuantityApplied)
                {
                    _aRDiscountProgramRemainQuantityApplied = value;
                    NotifyChanged("ARDiscountProgramRemainQuantityApplied");
                }
            }
        }
        public bool ARDiscountProgramIsVoucher
        {
            get { return _aRDiscountProgramIsVoucher; }
            set
            {
                if (value != this._aRDiscountProgramIsVoucher)
                {
                    _aRDiscountProgramIsVoucher = value;
                    NotifyChanged("ARDiscountProgramIsVoucher");
                }
            }
        }
        #endregion

        #region Extra Properties
        public byte[] ARDiscountProgramEmployeePicture { get; set; }

        public string ACObjectAccessKey { get; set; }

        public string ARCalculateDiscountType { get; set; }

        public string ARSaleOrderNo { get; set; }

        public BindingList<ARDiscountProgramItemsInfo> DiscountProgramItemList { get; set; }

        public BindingList<ARDiscountProgramItemTargetsInfo> DiscountProgramItemTargetList { get; set; }

        public DateTime DiscountProgramFromDate { get; set; }

        public DateTime DiscountProgramToDate { get; set; }
        #endregion
    }
    #endregion
}