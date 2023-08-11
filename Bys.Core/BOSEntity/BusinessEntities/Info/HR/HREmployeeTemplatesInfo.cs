using BOSLib;
using System;
namespace BOSERP
{
    #region HREmployeeTemplates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeTemplatesInfo
    //Created Date:Monday, September 16, 2013
    //-----------------------------------------------------------

    public class HREmployeeTemplatesInfo : BusinessObject
    {
        public HREmployeeTemplatesInfo()
        {
        }
        #region Variables
        protected int _hREmployeeTemplateID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HREmployeeID;
        protected int _fK_GETemplateID;
        protected String _hREmployeeTemplateName = String.Empty;
        protected String _hREmployeeTemplateStatus = DefaultStatus;
        #endregion

        #region Public properties
        public int HREmployeeTemplateID
        {
            get { return _hREmployeeTemplateID; }
            set
            {
                if (value != this._hREmployeeTemplateID)
                {
                    _hREmployeeTemplateID = value;
                    NotifyChanged("HREmployeeTemplateID");
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
        public int FK_GETemplateID
        {
            get { return _fK_GETemplateID; }
            set
            {
                if (value != this._fK_GETemplateID)
                {
                    _fK_GETemplateID = value;
                    NotifyChanged("FK_GETemplateID");
                }
            }
        }
        public String HREmployeeTemplateName
        {
            get { return _hREmployeeTemplateName; }
            set
            {
                if (value != this._hREmployeeTemplateName)
                {
                    _hREmployeeTemplateName = value;
                    NotifyChanged("HREmployeeTemplateName");
                }
            }
        }
        public String HREmployeeTemplateStatus
        {
            get { return _hREmployeeTemplateStatus; }
            set
            {
                if (value != this._hREmployeeTemplateStatus)
                {
                    _hREmployeeTemplateStatus = value;
                    NotifyChanged("HREmployeeTemplateStatus");
                }
            }
        }
        #endregion
    }
    #endregion
}