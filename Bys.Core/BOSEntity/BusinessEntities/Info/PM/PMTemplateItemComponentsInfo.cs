using BOSLib;
using System;
namespace BOSERP
{
    #region PMTemplateItemComponents
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:PMTemplateItemComponentsInfo
    //Created Date:26 Tháng Mười Hai 2017
    //-----------------------------------------------------------

    public class PMTemplateItemComponentsInfo : BusinessObject
    {
        public PMTemplateItemComponentsInfo()
        {
        }
        #region Variables
        protected int _pMTemplateItemComponentID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_PMTemplateID;
        protected int _fK_PMTemplateItemID;
        protected int _fK_ICProductWorkID;
        protected int _fK_ICProductWorkItemID;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected String _pMTemplateItemComponentProductNo = String.Empty;
        protected String _pMTemplateItemComponentProductName = String.Empty;
        protected String _pMTemplateItemComponentProductDesc = String.Empty;
        protected String _pMTemplateItemComponentWorkType = String.Empty;
        protected decimal _pMTemplateItemComponentQty;
        protected decimal _pMTemplateItemComponentBasicQty;
        protected String _pMTemplateItemComponentType = String.Empty;
        #endregion

        #region Public properties
        public int PMTemplateItemComponentID
        {
            get { return _pMTemplateItemComponentID; }
            set
            {
                if (value != this._pMTemplateItemComponentID)
                {
                    _pMTemplateItemComponentID = value;
                    NotifyChanged("PMTemplateItemComponentID");
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
        public int FK_PMTemplateID
        {
            get { return _fK_PMTemplateID; }
            set
            {
                if (value != this._fK_PMTemplateID)
                {
                    _fK_PMTemplateID = value;
                    NotifyChanged("FK_PMTemplateID");
                }
            }
        }
        public int FK_PMTemplateItemID
        {
            get { return _fK_PMTemplateItemID; }
            set
            {
                if (value != this._fK_PMTemplateItemID)
                {
                    _fK_PMTemplateItemID = value;
                    NotifyChanged("FK_PMTemplateItemID");
                }
            }
        }
        public int FK_ICProductWorkID
        {
            get { return _fK_ICProductWorkID; }
            set
            {
                if (value != this._fK_ICProductWorkID)
                {
                    _fK_ICProductWorkID = value;
                    NotifyChanged("FK_ICProductWorkID");
                }
            }
        }
        public int FK_ICProductWorkItemID
        {
            get { return _fK_ICProductWorkItemID; }
            set
            {
                if (value != this._fK_ICProductWorkItemID)
                {
                    _fK_ICProductWorkItemID = value;
                    NotifyChanged("FK_ICProductWorkItemID");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
                }
            }
        }
        public String PMTemplateItemComponentProductNo
        {
            get { return _pMTemplateItemComponentProductNo; }
            set
            {
                if (value != this._pMTemplateItemComponentProductNo)
                {
                    _pMTemplateItemComponentProductNo = value;
                    NotifyChanged("PMTemplateItemComponentProductNo");
                }
            }
        }
        public String PMTemplateItemComponentProductName
        {
            get { return _pMTemplateItemComponentProductName; }
            set
            {
                if (value != this._pMTemplateItemComponentProductName)
                {
                    _pMTemplateItemComponentProductName = value;
                    NotifyChanged("PMTemplateItemComponentProductName");
                }
            }
        }
        public String PMTemplateItemComponentProductDesc
        {
            get { return _pMTemplateItemComponentProductDesc; }
            set
            {
                if (value != this._pMTemplateItemComponentProductDesc)
                {
                    _pMTemplateItemComponentProductDesc = value;
                    NotifyChanged("PMTemplateItemComponentProductDesc");
                }
            }
        }
        public String PMTemplateItemComponentWorkType
        {
            get { return _pMTemplateItemComponentWorkType; }
            set
            {
                if (value != this._pMTemplateItemComponentWorkType)
                {
                    _pMTemplateItemComponentWorkType = value;
                    NotifyChanged("PMTemplateItemComponentWorkType");
                }
            }
        }
        public decimal PMTemplateItemComponentQty
        {
            get { return _pMTemplateItemComponentQty; }
            set
            {
                if (value != this._pMTemplateItemComponentQty)
                {
                    _pMTemplateItemComponentQty = value;
                    NotifyChanged("PMTemplateItemComponentQty");
                }
            }
        }
        public decimal PMTemplateItemComponentBasicQty
        {
            get { return _pMTemplateItemComponentBasicQty; }
            set
            {
                if (value != this._pMTemplateItemComponentBasicQty)
                {
                    _pMTemplateItemComponentBasicQty = value;
                    NotifyChanged("PMTemplateItemComponentBasicQty");
                }
            }
        }
        public String PMTemplateItemComponentType
        {
            get { return _pMTemplateItemComponentType; }
            set
            {
                if (value != this._pMTemplateItemComponentType)
                {
                    _pMTemplateItemComponentType = value;
                    NotifyChanged("PMTemplateItemComponentType");
                }
            }
        }

        #endregion
    }
    #endregion
}