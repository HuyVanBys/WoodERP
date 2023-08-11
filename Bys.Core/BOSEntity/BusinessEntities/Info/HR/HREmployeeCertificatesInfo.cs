using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeCertificates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeCertificatesInfo
    //Created Date:22 October 2013
    //-----------------------------------------------------------

    public class HREmployeeCertificatesInfo : BusinessObject
    {
        public HREmployeeCertificatesInfo()
        {
        }
        #region Variables
        protected int _hREmployeeCertificateID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HREmployeeID;
        protected String _hREmployeeCertificateName = String.Empty;
        protected String _hREmployeeCertificateTypeCombo = String.Empty;
        protected DateTime _hREmployeeCertificateIssuedDate = DateTime.MaxValue;
        protected String _hREmployeeCertificateIssuedUser = String.Empty;
        protected DateTime _hREmployeeCertificateDurationDate = DateTime.MaxValue;
        #endregion

        #region Public properties
        public int HREmployeeCertificateID
        {
            get { return _hREmployeeCertificateID; }
            set
            {
                if (value != this._hREmployeeCertificateID)
                {
                    _hREmployeeCertificateID = value;
                    NotifyChanged("HREmployeeCertificateID");
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
        public String HREmployeeCertificateName
        {
            get { return _hREmployeeCertificateName; }
            set
            {
                if (value != this._hREmployeeCertificateName)
                {
                    _hREmployeeCertificateName = value;
                    NotifyChanged("HREmployeeCertificateName");
                }
            }
        }
        public String HREmployeeCertificateTypeCombo
        {
            get { return _hREmployeeCertificateTypeCombo; }
            set
            {
                if (value != this._hREmployeeCertificateTypeCombo)
                {
                    _hREmployeeCertificateTypeCombo = value;
                    NotifyChanged("HREmployeeCertificateTypeCombo");
                }
            }
        }
        public DateTime HREmployeeCertificateIssuedDate
        {
            get { return _hREmployeeCertificateIssuedDate; }
            set
            {
                if (value != this._hREmployeeCertificateIssuedDate)
                {
                    _hREmployeeCertificateIssuedDate = value;
                    NotifyChanged("HREmployeeCertificateIssuedDate");
                }
            }
        }
        public String HREmployeeCertificateIssuedUser
        {
            get { return _hREmployeeCertificateIssuedUser; }
            set
            {
                if (value != this._hREmployeeCertificateIssuedUser)
                {
                    _hREmployeeCertificateIssuedUser = value;
                    NotifyChanged("HREmployeeCertificateIssuedUser");
                }
            }
        }
        public DateTime HREmployeeCertificateDurationDate
        {
            get { return _hREmployeeCertificateDurationDate; }
            set
            {
                if (value != this._hREmployeeCertificateDurationDate)
                {
                    _hREmployeeCertificateDurationDate = value;
                    NotifyChanged("HREmployeeCertificateDurationDate");
                }
            }
        }
        #endregion

    }
    #endregion
}