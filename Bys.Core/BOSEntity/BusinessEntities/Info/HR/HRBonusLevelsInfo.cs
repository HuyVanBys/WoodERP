using BOSLib;
using System;
namespace BOSERP
{
    #region HRBonusLevels
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRBonusLevelsInfo
    //Created Date:Wednesday, July 25, 2018
    //-----------------------------------------------------------

    public class HRBonusLevelsInfo : BusinessObject
    {
        public HRBonusLevelsInfo()
        {
        }
        #region Variables
        protected int _hRBonusLevelID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected decimal _hRBonusLevelRewardPoint;
        protected decimal _hRBonusLevelPointFrom;
        protected decimal _hRBonusLevelPointTo;
        protected decimal _hRBonusLevelPointEqual;
        protected String _hRProductDepartmentGroup = String.Empty;
        protected String _hRBonusLevelCalculatedOn = String.Empty;
        #endregion

        #region Public properties
        public int HRBonusLevelID
        {
            get { return _hRBonusLevelID; }
            set
            {
                if (value != this._hRBonusLevelID)
                {
                    _hRBonusLevelID = value;
                    NotifyChanged("HRBonusLevelID");
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
        public decimal HRBonusLevelRewardPoint
        {
            get { return _hRBonusLevelRewardPoint; }
            set
            {
                if (value != this._hRBonusLevelRewardPoint)
                {
                    _hRBonusLevelRewardPoint = value;
                    NotifyChanged("HRBonusLevelRewardPoint");
                }
            }
        }
        public decimal HRBonusLevelPointFrom
        {
            get { return _hRBonusLevelPointFrom; }
            set
            {
                if (value != this._hRBonusLevelPointFrom)
                {
                    _hRBonusLevelPointFrom = value;
                    NotifyChanged("HRBonusLevelPointFrom");
                }
            }
        }
        public decimal HRBonusLevelPointTo
        {
            get { return _hRBonusLevelPointTo; }
            set
            {
                if (value != this._hRBonusLevelPointTo)
                {
                    _hRBonusLevelPointTo = value;
                    NotifyChanged("HRBonusLevelPointTo");
                }
            }
        }
        public decimal HRBonusLevelPointEqual
        {
            get { return _hRBonusLevelPointEqual; }
            set
            {
                if (value != this._hRBonusLevelPointEqual)
                {
                    _hRBonusLevelPointEqual = value;
                    NotifyChanged("HRBonusLevelPointEqual");
                }
            }
        }
        public String HRProductDepartmentGroup
        {
            get { return _hRProductDepartmentGroup; }
            set
            {
                if (value != this._hRProductDepartmentGroup)
                {
                    _hRProductDepartmentGroup = value;
                    NotifyChanged("HRProductDepartmentGroup");
                }
            }
        }
        public String HRBonusLevelCalculatedOn
        {
            get { return _hRBonusLevelCalculatedOn; }
            set
            {
                if (value != this._hRBonusLevelCalculatedOn)
                {
                    _hRBonusLevelCalculatedOn = value;
                    NotifyChanged("HRBonusLevelCalculatedOn");
                }
            }
        }
        #endregion
    }
    #endregion
}