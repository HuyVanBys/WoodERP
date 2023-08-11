using BOSLib;
using System;
namespace BOSERP
{
    #region ICMeasureUnits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICMeasureUnitsInfo
    //Created Date:Tuesday, November 23, 2010
    //-----------------------------------------------------------

    public class ICMeasureUnitsInfo : BusinessObject
    {
        public ICMeasureUnitsInfo()
        {
        }
        #region Variables
        protected int _iCMeasureUnitID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _iCMeasureUnitNo = String.Empty;
        protected String _iCMeasureUnitName = String.Empty;
        protected String _iCMeasureUnitDesc = String.Empty;
        protected int _iCMeasureUnitRoundNum;
        protected int _iCMeasureUnitRoundNumInBatchProduct;
        #endregion

        #region Public properties
        public int ICMeasureUnitID
        {
            get { return _iCMeasureUnitID; }
            set
            {
                if (value != this._iCMeasureUnitID)
                {
                    _iCMeasureUnitID = value;
                    NotifyChanged("ICMeasureUnitID");
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
        public String ICMeasureUnitNo
        {
            get { return _iCMeasureUnitNo; }
            set
            {
                if (value != this._iCMeasureUnitNo)
                {
                    _iCMeasureUnitNo = value;
                    NotifyChanged("ICMeasureUnitNo");
                }
            }
        }
        public String ICMeasureUnitName
        {
            get { return _iCMeasureUnitName; }
            set
            {
                if (value != this._iCMeasureUnitName)
                {
                    _iCMeasureUnitName = value;
                    NotifyChanged("ICMeasureUnitName");
                }
            }
        }
        public String ICMeasureUnitDesc
        {
            get { return _iCMeasureUnitDesc; }
            set
            {
                if (value != this._iCMeasureUnitDesc)
                {
                    _iCMeasureUnitDesc = value;
                    NotifyChanged("ICMeasureUnitDesc");
                }
            }
        }
        public int ICMeasureUnitRoundNum
        {
            get { return _iCMeasureUnitRoundNum; }
            set
            {
                if (value != this._iCMeasureUnitRoundNum)
                {
                    _iCMeasureUnitRoundNum = value;
                    NotifyChanged("ICMeasureUnitRoundNum");
                }
            }
        }
        public int ICMeasureUnitRoundNumInBatchProduct
        {
            get { return _iCMeasureUnitRoundNumInBatchProduct; }
            set
            {
                if (value != this._iCMeasureUnitRoundNumInBatchProduct)
                {
                    _iCMeasureUnitRoundNumInBatchProduct = value;
                    NotifyChanged("ICMeasureUnitRoundNumInBatchProduct");
                }
            }
        }
        #endregion
    }
    #endregion
}