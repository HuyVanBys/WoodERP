using BOSLib;
using System;
namespace BOSERP
{
    #region MMProductGroupTypeSwitchingConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductGroupTypeSwitchingConfigsInfo
    //Created Date:Monday, April 08, 2019
    //-----------------------------------------------------------

    public class MMProductGroupTypeSwitchingConfigsInfo : BusinessObject
    {
        public MMProductGroupTypeSwitchingConfigsInfo()
        {
        }
        #region Variables
        protected int _mMProductGroupTypeSwitchingConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_MMOperationID;
        protected String _mMProductGroupType = String.Empty;
        protected String _mMProductGroupTypeSwitching = String.Empty;
        protected decimal _mMProductGroupTypeSwitchingConfigPercent;
        #endregion

        #region Public properties
        public int MMProductGroupTypeSwitchingConfigID
        {
            get { return _mMProductGroupTypeSwitchingConfigID; }
            set
            {
                if (value != this._mMProductGroupTypeSwitchingConfigID)
                {
                    _mMProductGroupTypeSwitchingConfigID = value;
                    NotifyChanged("MMProductGroupTypeSwitchingConfigID");
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
        public int FK_MMOperationID
        {
            get { return _fK_MMOperationID; }
            set
            {
                if (value != this._fK_MMOperationID)
                {
                    _fK_MMOperationID = value;
                    NotifyChanged("FK_MMOperationID");
                }
            }
        }
        public String MMProductGroupType
        {
            get { return _mMProductGroupType; }
            set
            {
                if (value != this._mMProductGroupType)
                {
                    _mMProductGroupType = value;
                    NotifyChanged("MMProductGroupType");
                }
            }
        }
        public String MMProductGroupTypeSwitching
        {
            get { return _mMProductGroupTypeSwitching; }
            set
            {
                if (value != this._mMProductGroupTypeSwitching)
                {
                    _mMProductGroupTypeSwitching = value;
                    NotifyChanged("MMProductGroupTypeSwitching");
                }
            }
        }
        public decimal MMProductGroupTypeSwitchingConfigPercent
        {
            get { return _mMProductGroupTypeSwitchingConfigPercent; }
            set
            {
                if (value != this._mMProductGroupTypeSwitchingConfigPercent)
                {
                    _mMProductGroupTypeSwitchingConfigPercent = value;
                    NotifyChanged("MMProductGroupTypeSwitchingConfigPercent");
                }
            }
        }
        #endregion
    }
    #endregion
}