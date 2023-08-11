﻿using BOSLib;
using System;
namespace BOSERP
{
    #region ICDisassembleProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICDisassembleProductsInfo
    //Created Date:Wednesday, May 30, 2018
    //-----------------------------------------------------------

    public class ICDisassembleProductsInfo : BusinessObject
    {
        public ICDisassembleProductsInfo()
        {
            _iCDisassembleProductIsAverageCalculation = false;
            _iCDisassembleProductIsSpecificCalculation = false;
        }
        #region Variables
        protected int _iCDisassembleProductID;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCDisassembleProductNo = String.Empty;
        protected DateTime _iCDisassembleProductDate = DateTime.MaxValue;
        protected String _iCDisassembleProductLotNo = String.Empty;
        protected int _fK_ICProductID;
        protected String _iCDisassembleProductName = String.Empty;
        protected String _iCDisassembleProductDesc = String.Empty;
        protected decimal _iCDisassembleProductQty;
        protected int _fK_ICStockID;
        protected int _fK_ICProductSerieID;
        protected String _iCDisassembleProductStatus = DefaultStatus;
        protected String _iCDisassembleProductPostedStatus = DefaultStatus;
        protected String _sTToolbarActionName = String.Empty;
        protected bool _iCDisassembleProductIsAverageCalculation = true;
        protected bool _iCDisassembleProductIsSpecificCalculation = true;
        #endregion

        #region Public properties
        public int ICDisassembleProductID
        {
            get { return _iCDisassembleProductID; }
            set
            {
                if (value != this._iCDisassembleProductID)
                {
                    _iCDisassembleProductID = value;
                    NotifyChanged("ICDisassembleProductID");
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
        public String ICDisassembleProductNo
        {
            get { return _iCDisassembleProductNo; }
            set
            {
                if (value != this._iCDisassembleProductNo)
                {
                    _iCDisassembleProductNo = value;
                    NotifyChanged("ICDisassembleProductNo");
                }
            }
        }
        public DateTime ICDisassembleProductDate
        {
            get { return _iCDisassembleProductDate; }
            set
            {
                if (value != this._iCDisassembleProductDate)
                {
                    _iCDisassembleProductDate = value;
                    NotifyChanged("ICDisassembleProductDate");
                }
            }
        }
        public String ICDisassembleProductLotNo
        {
            get { return _iCDisassembleProductLotNo; }
            set
            {
                if (value != this._iCDisassembleProductLotNo)
                {
                    _iCDisassembleProductLotNo = value;
                    NotifyChanged("ICDisassembleProductLotNo");
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
        public String ICDisassembleProductName
        {
            get { return _iCDisassembleProductName; }
            set
            {
                if (value != this._iCDisassembleProductName)
                {
                    _iCDisassembleProductName = value;
                    NotifyChanged("ICDisassembleProductName");
                }
            }
        }
        public String ICDisassembleProductDesc
        {
            get { return _iCDisassembleProductDesc; }
            set
            {
                if (value != this._iCDisassembleProductDesc)
                {
                    _iCDisassembleProductDesc = value;
                    NotifyChanged("ICDisassembleProductDesc");
                }
            }
        }
        public decimal ICDisassembleProductQty
        {
            get { return _iCDisassembleProductQty; }
            set
            {
                if (value != this._iCDisassembleProductQty)
                {
                    _iCDisassembleProductQty = value;
                    NotifyChanged("ICDisassembleProductQty");
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
        public String ICDisassembleProductStatus
        {
            get { return _iCDisassembleProductStatus; }
            set
            {
                if (value != this._iCDisassembleProductStatus)
                {
                    _iCDisassembleProductStatus = value;
                    NotifyChanged("ICDisassembleProductStatus");
                }
            }
        }
        public String ICDisassembleProductPostedStatus
        {
            get { return _iCDisassembleProductPostedStatus; }
            set
            {
                if (value != this._iCDisassembleProductPostedStatus)
                {
                    _iCDisassembleProductPostedStatus = value;
                    NotifyChanged("ICDisassembleProductPostedStatus");
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
        public bool ICDisassembleProductIsAverageCalculation
        {
            get { return _iCDisassembleProductIsAverageCalculation; }
            set
            {
                if (value != this._iCDisassembleProductIsAverageCalculation)
                {
                    _iCDisassembleProductIsAverageCalculation = value;
                    NotifyChanged("ICDisassembleProductIsAverageCalculation");
                }
            }
        }
        public bool ICDisassembleProductIsSpecificCalculation
        {
            get { return _iCDisassembleProductIsSpecificCalculation; }
            set
            {
                if (value != this._iCDisassembleProductIsSpecificCalculation)
                {
                    _iCDisassembleProductIsSpecificCalculation = value;
                    NotifyChanged("ICDisassembleProductIsSpecificCalculation");
                }
            }
        }
        #endregion

    }
    #endregion
}