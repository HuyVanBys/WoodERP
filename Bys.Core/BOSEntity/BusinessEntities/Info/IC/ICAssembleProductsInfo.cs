﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICAssembleProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICAssembleProductsInfo
    //Created Date:Monday, May 28, 2018
    //-----------------------------------------------------------

    public class ICAssembleProductsInfo : BusinessObject
    {
        public ICAssembleProductsInfo()
        {
            _iCAssembleProductIsAverageCalculation = false;
            _iCAssembleProductIsSpecificCalculation = false;
        }
        #region Variables
        protected int _iCAssembleProductID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCAssembleProductNo = String.Empty;
        protected DateTime _iCAssembleProductDate = DateTime.MaxValue;
        protected String _iCAssembleProductLotNo = String.Empty;
        protected int _fK_ICProductID;
        protected String _iCAssembleProductName = String.Empty;
        protected String _iCAssembleProductDesc = String.Empty;
        protected decimal _iCAssembleProductQty;
        protected int _fK_ICStockID;
        protected int _fK_ICProductSerieID;
        protected String _iCAssembleProductStatus = DefaultStatus;
        protected String _iCAssembleProductPostedStatus = DefaultStatus;
        protected String _sTToolbarActionName = String.Empty;
        protected bool _iCAssembleProductIsAverageCalculation = true;
        protected bool _iCAssembleProductIsSpecificCalculation = true;

        #endregion

        #region Public properties
        public int ICAssembleProductID
        {
            get { return _iCAssembleProductID; }
            set
            {
                if (value != this._iCAssembleProductID)
                {
                    _iCAssembleProductID = value;
                    NotifyChanged("ICAssembleProductID");
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
        public String ICAssembleProductNo
        {
            get { return _iCAssembleProductNo; }
            set
            {
                if (value != this._iCAssembleProductNo)
                {
                    _iCAssembleProductNo = value;
                    NotifyChanged("ICAssembleProductNo");
                }
            }
        }
        public DateTime ICAssembleProductDate
        {
            get { return _iCAssembleProductDate; }
            set
            {
                if (value != this._iCAssembleProductDate)
                {
                    _iCAssembleProductDate = value;
                    NotifyChanged("ICAssembleProductDate");
                }
            }
        }
        public String ICAssembleProductLotNo
        {
            get { return _iCAssembleProductLotNo; }
            set
            {
                if (value != this._iCAssembleProductLotNo)
                {
                    _iCAssembleProductLotNo = value;
                    NotifyChanged("ICAssembleProductLotNo");
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
        public String ICAssembleProductName
        {
            get { return _iCAssembleProductName; }
            set
            {
                if (value != this._iCAssembleProductName)
                {
                    _iCAssembleProductName = value;
                    NotifyChanged("ICAssembleProductName");
                }
            }
        }
        public String ICAssembleProductDesc
        {
            get { return _iCAssembleProductDesc; }
            set
            {
                if (value != this._iCAssembleProductDesc)
                {
                    _iCAssembleProductDesc = value;
                    NotifyChanged("ICAssembleProductDesc");
                }
            }
        }
        public decimal ICAssembleProductQty
        {
            get { return _iCAssembleProductQty; }
            set
            {
                if (value != this._iCAssembleProductQty)
                {
                    _iCAssembleProductQty = value;
                    NotifyChanged("ICAssembleProductQty");
                }
            }
        }
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
                }
            }
        }
        public int FK_ICProductSerieID
        {
            get { return _fK_ICProductSerieID; }
            set
            {
                if (value != this._fK_ICProductSerieID)
                {
                    _fK_ICProductSerieID = value;
                    NotifyChanged("FK_ICProductSerieID");
                }
            }
        }
        public String ICAssembleProductStatus
        {
            get { return _iCAssembleProductStatus; }
            set
            {
                if (value != this._iCAssembleProductStatus)
                {
                    _iCAssembleProductStatus = value;
                    NotifyChanged("ICAssembleProductStatus");
                }
            }
        }
        public String ICAssembleProductPostedStatus
        {
            get { return _iCAssembleProductPostedStatus; }
            set
            {
                if (value != this._iCAssembleProductPostedStatus)
                {
                    _iCAssembleProductPostedStatus = value;
                    NotifyChanged("ICAssembleProductPostedStatus");
                }
            }
        }
        public String STToolbarActionName
        {
            get { return _sTToolbarActionName; }
            set
            {
                if (value != this._sTToolbarActionName)
                {
                    _sTToolbarActionName = value;
                    NotifyChanged("STToolbarActionName");
                }
            }
        }
        public bool ICAssembleProductIsAverageCalculation
        {
            get { return _iCAssembleProductIsAverageCalculation; }
            set
            {
                if (value != this._iCAssembleProductIsAverageCalculation)
                {
                    _iCAssembleProductIsAverageCalculation = value;
                    NotifyChanged("ICAssembleProductIsAverageCalculation");
                }
            }
        }
        public bool ICAssembleProductIsSpecificCalculation
        {
            get { return _iCAssembleProductIsSpecificCalculation; }
            set
            {
                if (value != this._iCAssembleProductIsSpecificCalculation)
                {
                    _iCAssembleProductIsSpecificCalculation = value;
                    NotifyChanged("ICAssembleProductIsSpecificCalculation");
                }
            }
        }
        #endregion

    }
    #endregion
}