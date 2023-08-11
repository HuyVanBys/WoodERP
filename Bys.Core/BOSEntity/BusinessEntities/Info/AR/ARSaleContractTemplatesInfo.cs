﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ARSaleContractTemplates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSaleContractTemplatesInfo
    //Created Date:03 Tháng Sáu 2019
    //-----------------------------------------------------------

    public class ARSaleContractTemplatesInfo : BusinessObject
    {
        public ARSaleContractTemplatesInfo()
        {
        }
        #region Variables
        protected int _aRSaleContractTemplateID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARSaleContractID;
        protected String _aRSaleContractTemplateName = String.Empty;
        protected String _aRSaleContractTemplateStatus = DefaultStatus;
        protected String _aRSaleContractTemplateFileGUID = String.Empty;
        #endregion

        #region Public properties
        public int ARSaleContractTemplateID
        {
            get { return _aRSaleContractTemplateID; }
            set
            {
                if (value != this._aRSaleContractTemplateID)
                {
                    _aRSaleContractTemplateID = value;
                    NotifyChanged("ARSaleContractTemplateID");
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
        public int FK_ARSaleContractID
        {
            get { return _fK_ARSaleContractID; }
            set
            {
                if (value != this._fK_ARSaleContractID)
                {
                    _fK_ARSaleContractID = value;
                    NotifyChanged("FK_ARSaleContractID");
                }
            }
        }
        public String ARSaleContractTemplateName
        {
            get { return _aRSaleContractTemplateName; }
            set
            {
                if (value != this._aRSaleContractTemplateName)
                {
                    _aRSaleContractTemplateName = value;
                    NotifyChanged("ARSaleContractTemplateName");
                }
            }
        }
        public String ARSaleContractTemplateStatus
        {
            get { return _aRSaleContractTemplateStatus; }
            set
            {
                if (value != this._aRSaleContractTemplateStatus)
                {
                    _aRSaleContractTemplateStatus = value;
                    NotifyChanged("ARSaleContractTemplateStatus");
                }
            }
        }
        public String ARSaleContractTemplateFileGUID
        {
            get { return _aRSaleContractTemplateFileGUID; }
            set
            {
                if (value != this._aRSaleContractTemplateFileGUID)
                {
                    _aRSaleContractTemplateFileGUID = value;
                    NotifyChanged("ARSaleContractTemplateFileGUID");
                }
            }
        }
        #endregion

        #region extra properties
        public string UserCreatedFullname { get; set; }

        public string FullPathFile { get; set; }
        #endregion
    }
    #endregion
}