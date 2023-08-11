using BOSLib;
using System;
namespace BOSERP
{
    #region HRProductPieceWages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRProductPieceWagesInfo
    //Created Date:Monday, October 16, 2017
    //-----------------------------------------------------------

    public class HRProductPieceWagesInfo : BusinessObject
    {
        public HRProductPieceWagesInfo()
        {
        }
        #region Variables
        protected int _hRProductPieceWageID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _hRProductPieceWageNo = String.Empty;
        protected String _hRProductPieceWageName = String.Empty;
        protected String _hRProductPieceWageDesc = String.Empty;
        protected decimal _hRProductPieceWageQuantity;
        protected decimal _hRProductPieceWageUnitPrice;
        #endregion

        #region Public properties
        public int HRProductPieceWageID
        {
            get { return _hRProductPieceWageID; }
            set
            {
                if (value != this._hRProductPieceWageID)
                {
                    _hRProductPieceWageID = value;
                    NotifyChanged("HRProductPieceWageID");
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
        public String HRProductPieceWageNo
        {
            get { return _hRProductPieceWageNo; }
            set
            {
                if (value != this._hRProductPieceWageNo)
                {
                    _hRProductPieceWageNo = value;
                    NotifyChanged("HRProductPieceWageNo");
                }
            }
        }
        public String HRProductPieceWageName
        {
            get { return _hRProductPieceWageName; }
            set
            {
                if (value != this._hRProductPieceWageName)
                {
                    _hRProductPieceWageName = value;
                    NotifyChanged("HRProductPieceWageName");
                }
            }
        }
        public String HRProductPieceWageDesc
        {
            get { return _hRProductPieceWageDesc; }
            set
            {
                if (value != this._hRProductPieceWageDesc)
                {
                    _hRProductPieceWageDesc = value;
                    NotifyChanged("HRProductPieceWageDesc");
                }
            }
        }
        public decimal HRProductPieceWageQuantity
        {
            get { return _hRProductPieceWageQuantity; }
            set
            {
                if (value != this._hRProductPieceWageQuantity)
                {
                    _hRProductPieceWageQuantity = value;
                    NotifyChanged("HRProductPieceWageQuantity");
                }
            }
        }
        public decimal HRProductPieceWageUnitPrice
        {
            get { return _hRProductPieceWageUnitPrice; }
            set
            {
                if (value != this._hRProductPieceWageUnitPrice)
                {
                    _hRProductPieceWageUnitPrice = value;
                    NotifyChanged("HRProductPieceWageUnitPrice");
                }
            }
        }
        #endregion
    }
    #endregion
}