using BOSLib;
using System;
namespace BOSERP
{
    #region ICReceiptItemErrors
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICReceiptItemErrorsInfo
    //Created Date:Tuesday, February 19, 2019
    //-----------------------------------------------------------

    public class ICReceiptItemErrorsInfo : BusinessObject
    {
        public ICReceiptItemErrorsInfo()
        {
        }
        #region Variables
        protected int _iCReceiptItemErrorID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected String _iCReceiptItemErrorReceiptNo = String.Empty;
        protected int _fK_MMBatchProductID;
        protected int _fK_MMOperationID;
        protected int _fK_ICProductID;
        protected decimal _iCReceiptItemErrorProductQty;
        protected decimal _iCReceiptItemErrorProductBlock;
        protected int _fK_ICProductForBatchID;
        protected int _iCReceiptItemErrorReferenceID;

        #endregion

        #region Public properties
        public int ICReceiptItemErrorID
        {
            get { return _iCReceiptItemErrorID; }
            set
            {
                if (value != this._iCReceiptItemErrorID)
                {
                    _iCReceiptItemErrorID = value;
                    NotifyChanged("ICReceiptItemErrorID");
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
        public String ICReceiptItemErrorReceiptNo
        {
            get { return _iCReceiptItemErrorReceiptNo; }
            set
            {
                if (value != this._iCReceiptItemErrorReceiptNo)
                {
                    _iCReceiptItemErrorReceiptNo = value;
                    NotifyChanged("ICReceiptItemErrorReceiptNo");
                }
            }
        }
        public int FK_MMBatchProductID
        {
            get { return _fK_MMBatchProductID; }
            set
            {
                if (value != this._fK_MMBatchProductID)
                {
                    _fK_MMBatchProductID = value;
                    NotifyChanged("FK_MMBatchProductID");
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
        public decimal ICReceiptItemErrorProductQty
        {
            get { return _iCReceiptItemErrorProductQty; }
            set
            {
                if (value != this._iCReceiptItemErrorProductQty)
                {
                    _iCReceiptItemErrorProductQty = value;
                    NotifyChanged("ICReceiptItemErrorProductQty");
                }
            }
        }
        public decimal ICReceiptItemErrorProductBlock
        {
            get { return _iCReceiptItemErrorProductBlock; }
            set
            {
                if (value != this._iCReceiptItemErrorProductBlock)
                {
                    _iCReceiptItemErrorProductBlock = value;
                    NotifyChanged("ICReceiptItemErrorProductBlock");
                }
            }
        }
        public int FK_ICProductForBatchID
        {
            get { return _fK_ICProductForBatchID; }
            set
            {
                if (value != this._fK_ICProductForBatchID)
                {
                    _fK_ICProductForBatchID = value;
                    NotifyChanged("FK_ICProductForBatchID");
                }
            }
        }
        public int ICReceiptItemErrorReferenceID
        {
            get { return _iCReceiptItemErrorReferenceID; }
            set
            {
                if (value != this._iCReceiptItemErrorReferenceID)
                {
                    _iCReceiptItemErrorReferenceID = value;
                    NotifyChanged("ICReceiptItemErrorReferenceID");
                }
            }
        }

        #endregion
    }
    #endregion
}