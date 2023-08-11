﻿using BOSLib;
using System;
namespace BOSERP
{
    #region MMExchangeMeasureUnitConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMExchangeMeasureUnitConfigsInfo
    //Created Date:Wednesday, January 06, 2016
    //-----------------------------------------------------------

    public class MMExchangeMeasureUnitConfigsInfo : BusinessObject
    {
        public MMExchangeMeasureUnitConfigsInfo()
        {
        }
        #region Variables
        protected int _mMExchangeMeasureUnitConfigID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_ICProductID;
        protected int _fK_ICFromMeasureUnitID;
        protected int _fK_ICToMeasureUnitID;
        protected String _mMExchangeMeasureUnitConfigHeightOperation = String.Empty;
        protected String _mMExchangeMeasureUnitConfigWidthOperation = String.Empty;
        protected String _mMExchangeMeasureUnitConfigLengthOperation = String.Empty;
        protected decimal _mMExchangeMeasureUnitConfigRatio;
        protected String _mMExchangeMeasureUnitConfigSpecifiCation = String.Empty;
        protected decimal _mMExchangeMeasureUnitConfigSize;
        protected String _mMExchangeMeasureUnitConfigQuantity = String.Empty;
        #endregion

        #region Public properties
        public int MMExchangeMeasureUnitConfigID
        {
            get { return _mMExchangeMeasureUnitConfigID; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigID)
                {
                    _mMExchangeMeasureUnitConfigID = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigID");
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
        public int FK_ICFromMeasureUnitID
        {
            get { return _fK_ICFromMeasureUnitID; }
            set
            {
                if (value != this._fK_ICFromMeasureUnitID)
                {
                    _fK_ICFromMeasureUnitID = value;
                    NotifyChanged("FK_ICFromMeasureUnitID");
                }
            }
        }
        public int FK_ICToMeasureUnitID
        {
            get { return _fK_ICToMeasureUnitID; }
            set
            {
                if (value != this._fK_ICToMeasureUnitID)
                {
                    _fK_ICToMeasureUnitID = value;
                    NotifyChanged("FK_ICToMeasureUnitID");
                }
            }
        }
        public String MMExchangeMeasureUnitConfigHeightOperation
        {
            get { return _mMExchangeMeasureUnitConfigHeightOperation; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigHeightOperation)
                {
                    _mMExchangeMeasureUnitConfigHeightOperation = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigHeightOperation");
                }
            }
        }
        public String MMExchangeMeasureUnitConfigWidthOperation
        {
            get { return _mMExchangeMeasureUnitConfigWidthOperation; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigWidthOperation)
                {
                    _mMExchangeMeasureUnitConfigWidthOperation = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigWidthOperation");
                }
            }
        }
        public String MMExchangeMeasureUnitConfigLengthOperation
        {
            get { return _mMExchangeMeasureUnitConfigLengthOperation; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigLengthOperation)
                {
                    _mMExchangeMeasureUnitConfigLengthOperation = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigLengthOperation");
                }
            }
        }
        public decimal MMExchangeMeasureUnitConfigRatio
        {
            get { return _mMExchangeMeasureUnitConfigRatio; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigRatio)
                {
                    _mMExchangeMeasureUnitConfigRatio = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigRatio");
                }
            }
        }
        public String MMExchangeMeasureUnitConfigSpecifiCation
        {
            get { return _mMExchangeMeasureUnitConfigSpecifiCation; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigSpecifiCation)
                {
                    _mMExchangeMeasureUnitConfigSpecifiCation = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigSpecifiCation");
                }
            }
        }
        public decimal MMExchangeMeasureUnitConfigSize
        {
            get { return _mMExchangeMeasureUnitConfigSize; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigSize)
                {
                    _mMExchangeMeasureUnitConfigSize = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigSize");
                }
            }
        }
        public String MMExchangeMeasureUnitConfigQuantity
        {
            get { return _mMExchangeMeasureUnitConfigQuantity; }
            set
            {
                if (value != this._mMExchangeMeasureUnitConfigQuantity)
                {
                    _mMExchangeMeasureUnitConfigQuantity = value;
                    NotifyChanged("MMExchangeMeasureUnitConfigQuantity");
                }
            }
        }

        #endregion
    }
    #endregion
}