using BOSLib;
namespace BOSERP
{
    #region ADTemplates
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.98)
    //Class: ADTemplatesInfo
    //Created Date: Friday, 12 Oct 2018
    //-----------------------------------------------------------

    public class ADTemplatesInfo : BusinessObject
    {
        public ADTemplatesInfo()
        {
        }
        #region Variables
        protected int _aDTemplateID;
        protected string _aDTemplateNo = string.Empty;
        protected string _aDTemplateName = string.Empty;
        protected string _aDTemplateDesc = string.Empty;
        protected string _aDTemplateStoreProc = string.Empty;
        protected string _aAStatus = DefaultAAStatus;
        protected string _aDTemplateDataSource = string.Empty;
        protected bool _aDTemplateAutoLoad = true;
        #endregion

        #region Public properties
        public int ADTemplateID
        {
            get { return _aDTemplateID; }
            set
            {
                if (value != this._aDTemplateID)
                {
                    _aDTemplateID = value;
                    NotifyChanged("ADTemplateID");
                }
            }
        }
        public string ADTemplateNo
        {
            get { return _aDTemplateNo; }
            set
            {
                if (value != this._aDTemplateNo)
                {
                    _aDTemplateNo = value;
                    NotifyChanged("ADTemplateNo");
                }
            }
        }
        public string ADTemplateName
        {
            get { return _aDTemplateName; }
            set
            {
                if (value != this._aDTemplateName)
                {
                    _aDTemplateName = value;
                    NotifyChanged("ADTemplateName");
                }
            }
        }
        public string ADTemplateDesc
        {
            get { return _aDTemplateDesc; }
            set
            {
                if (value != this._aDTemplateDesc)
                {
                    _aDTemplateDesc = value;
                    NotifyChanged("ADTemplateDesc");
                }
            }
        }
        public string ADTemplateStoreProc
        {
            get { return _aDTemplateStoreProc; }
            set
            {
                if (value != this._aDTemplateStoreProc)
                {
                    _aDTemplateStoreProc = value;
                    NotifyChanged("ADTemplateStoreProc");
                }
            }
        }
        public string AAStatus
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
        public string ADTemplateDataSource
        {
            get { return _aDTemplateDataSource; }
            set
            {
                if (value != this._aDTemplateDataSource)
                {
                    _aDTemplateDataSource = value;
                    NotifyChanged("ADTemplateDataSource");
                }
            }
        }
        public bool ADTemplateAutoLoad
        {
            get { return _aDTemplateAutoLoad; }
            set
            {
                if (value != this._aDTemplateAutoLoad)
                {
                    _aDTemplateAutoLoad = value;
                    NotifyChanged("ADTemplateAutoLoad");
                }
            }
        }
        #endregion


    }
    #endregion
}