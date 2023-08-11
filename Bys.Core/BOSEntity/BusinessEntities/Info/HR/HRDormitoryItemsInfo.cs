using BOSLib;
using System;
namespace BOSERP
{
    #region HRDormitoryItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRDormitoryItemsInfo
    //Created Date:Monday, May 21, 2018
    //-----------------------------------------------------------

    public class HRDormitoryItemsInfo : ERPModuleItemsEntity
    {
        public HRDormitoryItemsInfo()
        {
        }
        #region Variables
        protected int _hRDormitoryItemID;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_HRDormitoryID;
        protected int _fK_ICProductID;
        protected String _hRDormitoryItemProductName = String.Empty;
        protected int _hRDormitoryItemProductQty;
        protected String _hRDormitoryItemProductDesc = String.Empty;
        #endregion

        #region Public properties
        public int HRDormitoryItemID
        {
            get { return _hRDormitoryItemID; }
            set
            {
                if (value != this._hRDormitoryItemID)
                {
                    _hRDormitoryItemID = value;
                    NotifyChanged("HRDormitoryItemID");
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
        public String HRDormitoryItemProductName
        {
            get { return _hRDormitoryItemProductName; }
            set
            {
                if (value != this._hRDormitoryItemProductName)
                {
                    _hRDormitoryItemProductName = value;
                    NotifyChanged("HRDormitoryItemProductName");
                }
            }
        }
        public int HRDormitoryItemProductQty
        {
            get { return _hRDormitoryItemProductQty; }
            set
            {
                if (value != this._hRDormitoryItemProductQty)
                {
                    _hRDormitoryItemProductQty = value;
                    NotifyChanged("HRDormitoryItemProductQty");
                }
            }
        }
        public String HRDormitoryItemProductDesc
        {
            get { return _hRDormitoryItemProductDesc; }
            set
            {
                if (value != this._hRDormitoryItemProductDesc)
                {
                    _hRDormitoryItemProductDesc = value;
                    NotifyChanged("HRDormitoryItemProductDesc");
                }
            }
        }
        #endregion
        public byte[] HRDormitoryItemProductPicture { get; set; }
    }
    #endregion
}