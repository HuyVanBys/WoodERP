using BOSLib;
using System;
namespace BOSERP
{
    #region ICProductUnits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductUnitsInfo
    //Created Date:Tuesday, November 23, 2010
    //-----------------------------------------------------------

    public class ICProductUnitsInfo : BusinessObject
    {
        public ICProductUnitsInfo()
        {
            ICProductUnitIsBasic = false;
        }

        #region Variables
        protected int _iCProductUnitID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICProductID;
        protected int _fK_ICMeasureUnitID;
        protected decimal _iCProductUnitFactor;
        protected decimal _iCProductUnitPrice;
        protected bool _iCProductUnitIsBasic = true;
        protected String _iCProductUnitBarCode = String.Empty;
        #endregion

        #region Public properties
        public int ICProductUnitID
        {
            get { return _iCProductUnitID; }
            set
            {
                if (value != this._iCProductUnitID)
                {
                    _iCProductUnitID = value;
                    NotifyChanged("ICProductUnitID");
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
        public int FK_ICMeasureUnitID
        {
            get { return _fK_ICMeasureUnitID; }
            set
            {
                if (value != this._fK_ICMeasureUnitID)
                {
                    _fK_ICMeasureUnitID = value;
                    NotifyChanged("FK_ICMeasureUnitID");
                }
            }
        }
        public decimal ICProductUnitFactor
        {
            get { return _iCProductUnitFactor; }
            set
            {
                if (value != this._iCProductUnitFactor)
                {
                    _iCProductUnitFactor = value;
                    NotifyChanged("ICProductUnitFactor");
                }
            }
        }
        public decimal ICProductUnitPrice
        {
            get { return _iCProductUnitPrice; }
            set
            {
                if (value != this._iCProductUnitPrice)
                {
                    _iCProductUnitPrice = value;
                    NotifyChanged("ICProductUnitPrice");
                }
            }
        }
        public bool ICProductUnitIsBasic
        {
            get { return _iCProductUnitIsBasic; }
            set
            {
                if (value != this._iCProductUnitIsBasic)
                {
                    _iCProductUnitIsBasic = value;
                    NotifyChanged("ICProductUnitIsBasic");
                }
            }
        }
        public String ICProductUnitBarCode
        {
            get { return _iCProductUnitBarCode; }
            set
            {
                if (value != this._iCProductUnitBarCode)
                {
                    _iCProductUnitBarCode = value;
                    NotifyChanged("ICProductUnitBarCode");
                }
            }
        }
        #endregion
    }
    #endregion
}