using BOSLib;
using System;
namespace BOSERP
{
    #region HRLevelDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRLevelDetailsInfo
    //Created Date:Wednesday, July 18, 2018
    //-----------------------------------------------------------

    public class HRLevelDetailsInfo : BusinessObject
    {
        public HRLevelDetailsInfo()
        {
        }
        #region Variables
        protected int _hRLevelDetailID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HRLevelID;
        protected String _hRLevelDetailName = String.Empty;
        protected int _fK_HRDepartmentID;
        protected String _hRLevelDetailNo = String.Empty;
        protected String _hRLevelDetailAdjustmentTime = String.Empty;
        protected DateTime _hRLevelDetailDate = DateTime.MaxValue;
        protected int _fK_HREmployeeEditerID;
        protected int _fK_HREmployeeConsiderID;
        protected int _fK_HREmployeeApproverID;
        #endregion

        #region Public properties
        public int HRLevelDetailID
        {
            get { return _hRLevelDetailID; }
            set
            {
                if (value != this._hRLevelDetailID)
                {
                    _hRLevelDetailID = value;
                    NotifyChanged("HRLevelDetailID");
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
        public int FK_HRLevelID
        {
            get { return _fK_HRLevelID; }
            set
            {
                if (value != this._fK_HRLevelID)
                {
                    _fK_HRLevelID = value;
                    NotifyChanged("FK_HRLevelID");
                }
            }
        }
        public String HRLevelDetailName
        {
            get { return _hRLevelDetailName; }
            set
            {
                if (value != this._hRLevelDetailName)
                {
                    _hRLevelDetailName = value;
                    NotifyChanged("HRLevelDetailName");
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
        public String HRLevelDetailNo
        {
            get { return _hRLevelDetailNo; }
            set
            {
                if (value != this._hRLevelDetailNo)
                {
                    _hRLevelDetailNo = value;
                    NotifyChanged("HRLevelDetailNo");
                }
            }
        }
        public String HRLevelDetailAdjustmentTime
        {
            get { return _hRLevelDetailAdjustmentTime; }
            set
            {
                if (value != this._hRLevelDetailAdjustmentTime)
                {
                    _hRLevelDetailAdjustmentTime = value;
                    NotifyChanged("HRLevelDetailAdjustmentTime");
                }
            }
        }
        public DateTime HRLevelDetailDate
        {
            get { return _hRLevelDetailDate; }
            set
            {
                if (value != this._hRLevelDetailDate)
                {
                    _hRLevelDetailDate = value;
                    NotifyChanged("HRLevelDetailDate");
                }
            }
        }
        public int FK_HREmployeeEditerID
        {
            get { return _fK_HREmployeeEditerID; }
            set
            {
                if (value != this._fK_HREmployeeEditerID)
                {
                    _fK_HREmployeeEditerID = value;
                    NotifyChanged("FK_HREmployeeEditerID");
                }
            }
        }
        public int FK_HREmployeeConsiderID
        {
            get { return _fK_HREmployeeConsiderID; }
            set
            {
                if (value != this._fK_HREmployeeConsiderID)
                {
                    _fK_HREmployeeConsiderID = value;
                    NotifyChanged("FK_HREmployeeConsiderID");
                }
            }
        }
        public int FK_HREmployeeApproverID
        {
            get { return _fK_HREmployeeApproverID; }
            set
            {
                if (value != this._fK_HREmployeeApproverID)
                {
                    _fK_HREmployeeApproverID = value;
                    NotifyChanged("FK_HREmployeeApproverID");
                }
            }
        }
        #endregion
        #region Extra Properties
        public IBOSList<HRLevelDetailsInfo> HRLevelDetailsList { get; set; }
        #endregion
    }
    #endregion
}