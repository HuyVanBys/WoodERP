using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductPricesInfo
    //Created Date:Wednesday, March 17, 2010
    //-----------------------------------------------------------

    public class ICProductPricesInfo : BusinessObject
    {
        public ICProductPricesInfo()
        {
        }
        #region Variables
        protected int _iCProductPriceID;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductID;
        protected int _fK_ARPriceLevelID;
        protected decimal _iCProductPriceMarkDown;
        #endregion

        #region Public properties
        public int ICProductPriceID
        {
            get { return _iCProductPriceID; }
            set
            {
                if (value != this._iCProductPriceID)
                {
                    _iCProductPriceID = value;
                    NotifyChanged("ICProductPriceID");
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
        public int FK_ARPriceLevelID
        {
            get { return _fK_ARPriceLevelID; }
            set
            {
                if (value != this._fK_ARPriceLevelID)
                {
                    _fK_ARPriceLevelID = value;
                    NotifyChanged("FK_ARPriceLevelID");
                }
            }
        }
        public decimal ICProductPriceMarkDown
        {
            get { return _iCProductPriceMarkDown; }
            set
            {
                if (value != this._iCProductPriceMarkDown)
                {
                    _iCProductPriceMarkDown = value;
                    NotifyChanged("ICProductPriceMarkDown");
                }
            }
        }
        #endregion
    }
    #endregion
}