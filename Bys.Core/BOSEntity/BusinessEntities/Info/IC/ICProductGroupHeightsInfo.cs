using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductGroupHeights
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductGroupHeightsInfo
    //Created Date:Thursday, April 5, 2018
    //-----------------------------------------------------------

    public class ICProductGroupHeightsInfo : BusinessObject
    {
        public ICProductGroupHeightsInfo()
        {
        }
        #region Variables
        protected int _iCProductGroupHeightID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCProductGroupHeightName = String.Empty;
        protected String _iCProductGroupHeightDesc = String.Empty;
        protected decimal _iCProductGroupHeightMinValue;
        protected decimal _iCProductGroupHeightMaxValue;
        #endregion

        #region Public properties
        public int ICProductGroupHeightID
        {
            get { return _iCProductGroupHeightID; }
            set
            {
                if (value != this._iCProductGroupHeightID)
                {
                    _iCProductGroupHeightID = value;
                    NotifyChanged("ICProductGroupHeightID");
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
        public String ICProductGroupHeightName
        {
            get { return _iCProductGroupHeightName; }
            set
            {
                if (value != this._iCProductGroupHeightName)
                {
                    _iCProductGroupHeightName = value;
                    NotifyChanged("ICProductGroupHeightName");
                }
            }
        }
        public String ICProductGroupHeightDesc
        {
            get { return _iCProductGroupHeightDesc; }
            set
            {
                if (value != this._iCProductGroupHeightDesc)
                {
                    _iCProductGroupHeightDesc = value;
                    NotifyChanged("ICProductGroupHeightDesc");
                }
            }
        }
        public decimal ICProductGroupHeightMinValue
        {
            get { return _iCProductGroupHeightMinValue; }
            set
            {
                if (value != this._iCProductGroupHeightMinValue)
                {
                    _iCProductGroupHeightMinValue = value;
                    NotifyChanged("ICProductGroupHeightMinValue");
                }
            }
        }
        public decimal ICProductGroupHeightMaxValue
        {
            get { return _iCProductGroupHeightMaxValue; }
            set
            {
                if (value != this._iCProductGroupHeightMaxValue)
                {
                    _iCProductGroupHeightMaxValue = value;
                    NotifyChanged("ICProductGroupHeightMaxValue");
                }
            }
        }
        #endregion
    }
    #endregion
}