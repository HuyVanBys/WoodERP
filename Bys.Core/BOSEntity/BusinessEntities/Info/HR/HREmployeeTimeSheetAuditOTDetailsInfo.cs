using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeTimeSheetAuditOTDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeTimeSheetAuditOTDetailsInfo
    //Created Date:Monday, November 27, 2017
    //-----------------------------------------------------------

    public class HREmployeeTimeSheetAuditOTDetailsInfo : BusinessObject
    {
        public HREmployeeTimeSheetAuditOTDetailsInfo()
        {
        }
        #region Variables
        protected int _hREmployeeTimeSheetAuditOTDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HREmployeeTimeSheetAuditID;
        protected int _fK_HRTimeSheetParamID;
        protected String _hREmployeeTimeSheetAuditOTDetailName = String.Empty;
        protected decimal _hREmployeeTimeSheetAuditOTDetailFactor;
        protected decimal _hREmployeeTimeSheetAuditOTDetailHours;
        #endregion

        #region Public properties
        public int HREmployeeTimeSheetAuditOTDetailID
        {
            get { return _hREmployeeTimeSheetAuditOTDetailID; }
            set
            {
                if (value != this._hREmployeeTimeSheetAuditOTDetailID)
                {
                    _hREmployeeTimeSheetAuditOTDetailID = value;
                    NotifyChanged("HREmployeeTimeSheetAuditOTDetailID");
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
        public int FK_HREmployeeTimeSheetAuditID
        {
            get { return _fK_HREmployeeTimeSheetAuditID; }
            set
            {
                if (value != this._fK_HREmployeeTimeSheetAuditID)
                {
                    _fK_HREmployeeTimeSheetAuditID = value;
                    NotifyChanged("FK_HREmployeeTimeSheetAuditID");
                }
            }
        }
        public int FK_HRTimeSheetParamID
        {
            get { return _fK_HRTimeSheetParamID; }
            set
            {
                if (value != this._fK_HRTimeSheetParamID)
                {
                    _fK_HRTimeSheetParamID = value;
                    NotifyChanged("FK_HRTimeSheetParamID");
                }
            }
        }
        public String HREmployeeTimeSheetAuditOTDetailName
        {
            get { return _hREmployeeTimeSheetAuditOTDetailName; }
            set
            {
                if (value != this._hREmployeeTimeSheetAuditOTDetailName)
                {
                    _hREmployeeTimeSheetAuditOTDetailName = value;
                    NotifyChanged("HREmployeeTimeSheetAuditOTDetailName");
                }
            }
        }
        public decimal HREmployeeTimeSheetAuditOTDetailFactor
        {
            get { return _hREmployeeTimeSheetAuditOTDetailFactor; }
            set
            {
                if (value != this._hREmployeeTimeSheetAuditOTDetailFactor)
                {
                    _hREmployeeTimeSheetAuditOTDetailFactor = value;
                    NotifyChanged("HREmployeeTimeSheetAuditOTDetailFactor");
                }
            }
        }
        public decimal HREmployeeTimeSheetAuditOTDetailHours
        {
            get { return _hREmployeeTimeSheetAuditOTDetailHours; }
            set
            {
                if (value != this._hREmployeeTimeSheetAuditOTDetailHours)
                {
                    _hREmployeeTimeSheetAuditOTDetailHours = value;
                    NotifyChanged("HREmployeeTimeSheetAuditOTDetailHours");
                }
            }
        }
        #endregion
    }
    #endregion
}