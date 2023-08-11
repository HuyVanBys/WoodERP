using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductPackingDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductPackingDetailsInfo
    //Created Date:Wednesday, April 17, 2019
    //-----------------------------------------------------------

    public class ICProductPackingDetailsInfo : BusinessObject
    {
        public ICProductPackingDetailsInfo()
        {
        }
        #region Variables
        protected int _iCProductPackingDetailID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductID;
        protected int _fK_ICProductAttributeSpecialityID;
        protected decimal _iCProductPackingDetailLength;
        protected decimal _iCProductPackingDetailWidth;
        protected decimal _iCProductPackingDetailHeight;
        protected decimal _iCProductPackingDetailQty;
        protected decimal _iCProductPackingDetailVolume;
        protected int _fK_ICProdAttPackingMaterialWeightPerVolumeID;
        #endregion

        #region Public properties
        public int ICProductPackingDetailID
        {
            get { return _iCProductPackingDetailID; }
            set
            {
                if (value != this._iCProductPackingDetailID)
                {
                    _iCProductPackingDetailID = value;
                    NotifyChanged("ICProductPackingDetailID");
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
        public int FK_ICProductAttributeSpecialityID
        {
            get { return _fK_ICProductAttributeSpecialityID; }
            set
            {
                if (value != this._fK_ICProductAttributeSpecialityID)
                {
                    _fK_ICProductAttributeSpecialityID = value;
                    NotifyChanged("FK_ICProductAttributeSpecialityID");
                }
            }
        }
        public decimal ICProductPackingDetailLength
        {
            get { return _iCProductPackingDetailLength; }
            set
            {
                if (value != this._iCProductPackingDetailLength)
                {
                    _iCProductPackingDetailLength = value;
                    NotifyChanged("ICProductPackingDetailLength");
                }
            }
        }
        public decimal ICProductPackingDetailWidth
        {
            get { return _iCProductPackingDetailWidth; }
            set
            {
                if (value != this._iCProductPackingDetailWidth)
                {
                    _iCProductPackingDetailWidth = value;
                    NotifyChanged("ICProductPackingDetailWidth");
                }
            }
        }
        public decimal ICProductPackingDetailHeight
        {
            get { return _iCProductPackingDetailHeight; }
            set
            {
                if (value != this._iCProductPackingDetailHeight)
                {
                    _iCProductPackingDetailHeight = value;
                    NotifyChanged("ICProductPackingDetailHeight");
                }
            }
        }
        public decimal ICProductPackingDetailQty
        {
            get { return _iCProductPackingDetailQty; }
            set
            {
                if (value != this._iCProductPackingDetailQty)
                {
                    _iCProductPackingDetailQty = value;
                    NotifyChanged("ICProductPackingDetailQty");
                }
            }
        }
        public decimal ICProductPackingDetailVolume
        {
            get { return _iCProductPackingDetailVolume; }
            set
            {
                if (value != this._iCProductPackingDetailVolume)
                {
                    _iCProductPackingDetailVolume = value;
                    NotifyChanged("ICProductPackingDetailVolume");
                }
            }
        }
        public int FK_ICProdAttPackingMaterialWeightPerVolumeID
        {
            get { return _fK_ICProdAttPackingMaterialWeightPerVolumeID; }
            set
            {
                if (value != this._fK_ICProdAttPackingMaterialWeightPerVolumeID)
                {
                    _fK_ICProdAttPackingMaterialWeightPerVolumeID = value;
                    NotifyChanged("FK_ICProdAttPackingMaterialWeightPerVolumeID");
                }
            }
        }
        #endregion
    }
    #endregion
}