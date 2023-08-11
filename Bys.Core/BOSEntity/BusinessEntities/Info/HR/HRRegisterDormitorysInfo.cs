using BOSLib;
using System;
namespace BOSERP
{
    #region HRRegisterDormitorys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRRegisterDormitorysInfo
    //Created Date:11 July 2018
    //-----------------------------------------------------------

    public class HRRegisterDormitorysInfo : BusinessObject
    {
        public HRRegisterDormitorysInfo()
        {
        }
        #region Variables
        protected int _hRRegisterDormitoryID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected int _fK_HRDormitoryID;
        protected String _hRRegisterDormitoryNo = String.Empty;
        protected DateTime _hRRegisterDormitoryFromDate = DateTime.MaxValue;
        protected DateTime _hRRegisterDormitoryToDate = DateTime.MaxValue;
        protected String _hRRegisterDormitoryDesc = String.Empty;
        protected decimal _hRRegisterDormitoryAcreage;
        protected int _hRRegisterDormitoryCapacity;
        protected int _fK_HREmployeeManager;
        #endregion

        #region Public properties
        public int HRRegisterDormitoryID
        {
            get { return _hRRegisterDormitoryID; }
            set
            {
                if (value != this._hRRegisterDormitoryID)
                {
                    _hRRegisterDormitoryID = value;
                    NotifyChanged("HRRegisterDormitoryID");
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
        public int FK_HRDormitoryID
        {
            get { return _fK_HRDormitoryID; }
            set
            {
                if (value != this._fK_HRDormitoryID)
                {
                    _fK_HRDormitoryID = value;
                    NotifyChanged("FK_HRDormitoryID");
                }
            }
        }
        public String HRRegisterDormitoryNo
        {
            get { return _hRRegisterDormitoryNo; }
            set
            {
                if (value != this._hRRegisterDormitoryNo)
                {
                    _hRRegisterDormitoryNo = value;
                    NotifyChanged("HRRegisterDormitoryNo");
                }
            }
        }
        public DateTime HRRegisterDormitoryFromDate
        {
            get { return _hRRegisterDormitoryFromDate; }
            set
            {
                if (value != this._hRRegisterDormitoryFromDate)
                {
                    _hRRegisterDormitoryFromDate = value;
                    NotifyChanged("HRRegisterDormitoryFromDate");
                }
            }
        }
        public DateTime HRRegisterDormitoryToDate
        {
            get { return _hRRegisterDormitoryToDate; }
            set
            {
                if (value != this._hRRegisterDormitoryToDate)
                {
                    _hRRegisterDormitoryToDate = value;
                    NotifyChanged("HRRegisterDormitoryToDate");
                }
            }
        }
        public String HRRegisterDormitoryDesc
        {
            get { return _hRRegisterDormitoryDesc; }
            set
            {
                if (value != this._hRRegisterDormitoryDesc)
                {
                    _hRRegisterDormitoryDesc = value;
                    NotifyChanged("HRRegisterDormitoryDesc");
                }
            }
        }
        public decimal HRRegisterDormitoryAcreage
        {
            get { return _hRRegisterDormitoryAcreage; }
            set
            {
                if (value != this._hRRegisterDormitoryAcreage)
                {
                    _hRRegisterDormitoryAcreage = value;
                    NotifyChanged("HRRegisterDormitoryAcreage");
                }
            }
        }
        public int HRRegisterDormitoryCapacity
        {
            get { return _hRRegisterDormitoryCapacity; }
            set
            {
                if (value != this._hRRegisterDormitoryCapacity)
                {
                    _hRRegisterDormitoryCapacity = value;
                    NotifyChanged("HRRegisterDormitoryCapacity");
                }
            }
        }
        public int FK_HREmployeeManager
        {
            get { return _fK_HREmployeeManager; }
            set
            {
                if (value != this._fK_HREmployeeManager)
                {
                    _fK_HREmployeeManager = value;
                    NotifyChanged("FK_HREmployeeManager");
                }
            }
        }
        #endregion

        public byte[] HRRegisterDormitoryEmployeePicture { get; set; }
    }
    #endregion
}