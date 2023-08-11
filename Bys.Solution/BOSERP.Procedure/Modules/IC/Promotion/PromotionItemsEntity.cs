using System;
using System.Collections.Generic;
using System.Text;
using BOSLib;

namespace BOSERP.Modules.Promotion
{
    public class PromotionItemsEntity : ERPModuleItemsEntity
    {
        #region Variables
        protected int _iCPromotionItemID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICPromotionID;
        protected int _fK_ICDepartmentID;
        protected int _fK_ICProductGroupID;
        protected int _fK_ICProductID;
        protected String _iCPromotionItemProductSerialNo = String.Empty;
        protected String _iCPromotionItemProductAttribute = String.Empty;
        protected String _iCPromotionItemProductName = String.Empty;
        protected String _iCPromotionItemProductDesc = String.Empty;
        #endregion

        #region Public properties
        public int ICPromotionItemID
        {
            get { return _iCPromotionItemID; }
            set
            {
                if (value != this._iCPromotionItemID)
                {
                    _iCPromotionItemID = value;
                    NotifyChanged("ICPromotionItemID");
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
        public int FK_ICPromotionID
        {
            get { return _fK_ICPromotionID; }
            set
            {
                if (value != this._fK_ICPromotionID)
                {
                    _fK_ICPromotionID = value;
                    NotifyChanged("FK_ICPromotionID");
                }
            }
        }
        public int FK_ICDepartmentID
        {
            get { return _fK_ICDepartmentID; }
            set
            {
                if (value != this._fK_ICDepartmentID)
                {
                    _fK_ICDepartmentID = value;
                    NotifyChanged("FK_ICDepartmentID");
                }
            }
        }
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                    NotifyChanged("FK_ICProductGroupID");
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
        public String ICPromotionItemProductSerialNo
        {
            get { return _iCPromotionItemProductSerialNo; }
            set
            {
                if (value != this._iCPromotionItemProductSerialNo)
                {
                    _iCPromotionItemProductSerialNo = value;
                    NotifyChanged("ICPromotionItemProductSerialNo");
                }
            }
        }
        public String ICPromotionItemProductAttribute
        {
            get { return _iCPromotionItemProductAttribute; }
            set
            {
                if (value != this._iCPromotionItemProductAttribute)
                {
                    _iCPromotionItemProductAttribute = value;
                    NotifyChanged("ICPromotionItemProductAttribute");
                }
            }
        }
        public String ICPromotionItemProductName
        {
            get { return _iCPromotionItemProductName; }
            set
            {
                if (value != this._iCPromotionItemProductName)
                {
                    _iCPromotionItemProductName = value;
                    NotifyChanged("ICPromotionItemProductName");
                }
            }
        }
        public String ICPromotionItemProductDesc
        {
            get { return _iCPromotionItemProductDesc; }
            set
            {
                if (value != this._iCPromotionItemProductDesc)
                {
                    _iCPromotionItemProductDesc = value;
                    NotifyChanged("ICPromotionItemProductDesc");
                }
            }
        }
        #endregion

        #region Extra Properties
        public BOSList<ICPromotionItemDetailsInfo> ICPromotionItemDetailsList { get; set; }

        public double ICPromotionItemRegularePrice { get; set; }

        public double ICPromotionItemDiscountPrice { get; set; }

        public double ICPromotionItemQty { get; set; }

        public double ICPromotionItemUnitPrice { get; set; }
        #endregion
    }
}
