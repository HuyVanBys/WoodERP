﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HREvaluationTemplates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREvaluationTemplatesInfo
    //Created Date:Tuesday, May 17, 2011
    //-----------------------------------------------------------

    public class HREvaluationTemplatesInfo : BusinessObject
    {
        public HREvaluationTemplatesInfo()
        {
        }
        #region Variables
        protected int _hREvaluationTemplateID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hREvaluationTemplateNo = String.Empty;
        protected String _hREvaluationTemplateName = String.Empty;
        protected String _hREvaluationTemplateDesc = String.Empty;
        #endregion

        #region Public properties
        public int HREvaluationTemplateID
        {
            get { return _hREvaluationTemplateID; }
            set
            {
                if (value != this._hREvaluationTemplateID)
                {
                    _hREvaluationTemplateID = value;
                    NotifyChanged("HREvaluationTemplateID");
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
        public String HREvaluationTemplateNo
        {
            get { return _hREvaluationTemplateNo; }
            set
            {
                if (value != this._hREvaluationTemplateNo)
                {
                    _hREvaluationTemplateNo = value;
                    NotifyChanged("HREvaluationTemplateNo");
                }
            }
        }
        public String HREvaluationTemplateName
        {
            get { return _hREvaluationTemplateName; }
            set
            {
                if (value != this._hREvaluationTemplateName)
                {
                    _hREvaluationTemplateName = value;
                    NotifyChanged("HREvaluationTemplateName");
                }
            }
        }
        public String HREvaluationTemplateDesc
        {
            get { return _hREvaluationTemplateDesc; }
            set
            {
                if (value != this._hREvaluationTemplateDesc)
                {
                    _hREvaluationTemplateDesc = value;
                    NotifyChanged("HREvaluationTemplateDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}