﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductConversions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductConversionsInfo
    //Created Date:Monday, May 27, 2019
    //-----------------------------------------------------------

    public class ICProductConversionsInfo : BusinessObject
    {
        public ICProductConversionsInfo()
        {
        }
        #region Variables
        protected int _iCProductConversionID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_BRBranchID;
        protected int _fK_HREmployeeID;
        protected String _iCProductConversionNo = String.Empty;
        protected String _iCProductConversionName = String.Empty;
        protected String _iCProductConversionDesc = String.Empty;
        protected DateTime _iCProductConversionDate = DateTime.MaxValue;
        protected int _fK_ICFromStockID;
        protected int _fK_ICToStockID;
        protected String _iCProductConversionStatus = DefaultStatus;
        protected String _iCProductConversionPostedStatus = DefaultStatus;
        protected String _sTToolbarActionName = String.Empty;
        protected int _fK_HREmployeeCompletedID;
        protected DateTime _iCProductConversionCompletedDate = DateTime.MaxValue;
        protected int _fK_HREmployeeConfirmedID;
        protected DateTime _iCProductConversionConfirmedDate = DateTime.MaxValue;
        protected String _iCProductConversionType = String.Empty;
        protected String _iCProductConversionProductType = String.Empty;
        protected String _iCProductConversionRuleOfAllocationFactorGeneration = String.Empty;
        #endregion

        #region Public properties
        public int ICProductConversionID
        {
            get { return _iCProductConversionID; }
            set
            {
                if (value != this._iCProductConversionID)
                {
                    _iCProductConversionID = value;
                    NotifyChanged("ICProductConversionID");
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
        public String ICProductConversionNo
        {
            get { return _iCProductConversionNo; }
            set
            {
                if (value != this._iCProductConversionNo)
                {
                    _iCProductConversionNo = value;
                    NotifyChanged("ICProductConversionNo");
                }
            }
        }
        public String ICProductConversionName
        {
            get { return _iCProductConversionName; }
            set
            {
                if (value != this._iCProductConversionName)
                {
                    _iCProductConversionName = value;
                    NotifyChanged("ICProductConversionName");
                }
            }
        }
        public String ICProductConversionDesc
        {
            get { return _iCProductConversionDesc; }
            set
            {
                if (value != this._iCProductConversionDesc)
                {
                    _iCProductConversionDesc = value;
                    NotifyChanged("ICProductConversionDesc");
                }
            }
        }
        public DateTime ICProductConversionDate
        {
            get { return _iCProductConversionDate; }
            set
            {
                if (value != this._iCProductConversionDate)
                {
                    _iCProductConversionDate = value;
                    NotifyChanged("ICProductConversionDate");
                }
            }
        }
        public int FK_ICFromStockID
        {
            get { return _fK_ICFromStockID; }
            set
            {
                if (value != this._fK_ICFromStockID)
                {
                    _fK_ICFromStockID = value;
                    NotifyChanged("FK_ICFromStockID");
                }
            }
        }
        public int FK_ICToStockID
        {
            get { return _fK_ICToStockID; }
            set
            {
                if (value != this._fK_ICToStockID)
                {
                    _fK_ICToStockID = value;
                    NotifyChanged("FK_ICToStockID");
                }
            }
        }
        public String ICProductConversionStatus
        {
            get { return _iCProductConversionStatus; }
            set
            {
                if (value != this._iCProductConversionStatus)
                {
                    _iCProductConversionStatus = value;
                    NotifyChanged("ICProductConversionStatus");
                }
            }
        }
        public String ICProductConversionPostedStatus
        {
            get { return _iCProductConversionPostedStatus; }
            set
            {
                if (value != this._iCProductConversionPostedStatus)
                {
                    _iCProductConversionPostedStatus = value;
                    NotifyChanged("ICProductConversionPostedStatus");
                }
            }
        }
        public String STToolbarActionName
        {
            get { return _sTToolbarActionName; }
            set
            {
                if (value != this._sTToolbarActionName)
                {
                    _sTToolbarActionName = value;
                    NotifyChanged("STToolbarActionName");
                }
            }
        }
        public int FK_HREmployeeCompletedID
        {
            get { return _fK_HREmployeeCompletedID; }
            set
            {
                if (value != this._fK_HREmployeeCompletedID)
                {
                    _fK_HREmployeeCompletedID = value;
                    NotifyChanged("FK_HREmployeeApprovedID");
                }
            }
        }
        public DateTime ICProductConversionCompletedDate
        {
            get { return _iCProductConversionCompletedDate; }
            set
            {
                if (value != this._iCProductConversionCompletedDate)
                {
                    _iCProductConversionCompletedDate = value;
                    NotifyChanged("ICProductConversionCompletedDate");
                }
            }
        }
        public int FK_HREmployeeConfirmedID
        {
            get { return _fK_HREmployeeConfirmedID; }
            set
            {
                if (value != this._fK_HREmployeeConfirmedID)
                {
                    _fK_HREmployeeConfirmedID = value;
                    NotifyChanged("FK_HREmployeeConfirmedID");
                }
            }
        }
        public DateTime ICProductConversionConfirmedDate
        {
            get { return _iCProductConversionConfirmedDate; }
            set
            {
                if (value != this._iCProductConversionConfirmedDate)
                {
                    _iCProductConversionConfirmedDate = value;
                    NotifyChanged("ICProductConversionConfirmedDate");
                }
            }
        }
        public String ICProductConversionType
        {
            get { return _iCProductConversionType; }
            set
            {
                if (value != this._iCProductConversionType)
                {
                    _iCProductConversionType = value;
                    NotifyChanged("ICProductConversionType");
                }
            }
        }
        public String ICProductConversionProductType
        {
            get { return _iCProductConversionProductType; }
            set
            {
                if (value != this._iCProductConversionProductType)
                {
                    _iCProductConversionProductType = value;
                    NotifyChanged("ICProductConversionProductType");
                }
            }
        }
        public String ICProductConversionRuleOfAllocationFactorGeneration
        {
            get { return _iCProductConversionRuleOfAllocationFactorGeneration; }
            set
            {
                if (value != this._iCProductConversionRuleOfAllocationFactorGeneration)
                {
                    _iCProductConversionRuleOfAllocationFactorGeneration = value;
                    NotifyChanged("ICProductConversionRuleOfAllocationFactorGeneration");
                }
            }
        }
        #endregion

        #region Extra property

        public byte[] ICProductConversionEmployeePicture { get; set; }

        public DateTime ICProductConversionFromDate { get; set; }

        public DateTime ICProductConversionToDate { get; set; }
        #endregion

    }
    #endregion
}