using BOSLib;
using System;
namespace BOSERP
{
    #region ICTransferLogs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICTransferLogsInfo
    //Created Date:Friday, July 11, 2008
    //-----------------------------------------------------------

    public class ICTransferLogsInfo : BusinessObject
    {
        public ICTransferLogsInfo()
        {
        }
        #region Variables
        protected int _iCTransferLogID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _iCTransferLogDate = DateTime.MaxValue;
        protected String _iCTransferReceiptNo = String.Empty;
        protected String _iCReferenceTransferNo = String.Empty;
        protected int _fK_ICFromStockID;
        protected int _fK_ICToStockID;
        protected int _fK_ICTransitStockID;
        protected int _fK_BRBranchID;
        #endregion

        #region Public properties
        public int ICTransferLogID
        {
            get { return _iCTransferLogID; }
            set
            {
                if (value != this._iCTransferLogID)
                {
                    _iCTransferLogID = value;
                    NotifyChanged("ICTransferLogID");
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
        public DateTime ICTransferLogDate
        {
            get { return _iCTransferLogDate; }
            set
            {
                if (value != this._iCTransferLogDate)
                {
                    _iCTransferLogDate = value;
                    NotifyChanged("ICTransferLogDate");
                }
            }
        }
        public String ICTransferReceiptNo
        {
            get { return _iCTransferReceiptNo; }
            set
            {
                if (value != this._iCTransferReceiptNo)
                {
                    _iCTransferReceiptNo = value;
                    NotifyChanged("ICTransferReceiptNo");
                }
            }
        }
        public String ICReferenceTransferNo
        {
            get { return _iCReferenceTransferNo; }
            set
            {
                if (value != this._iCReferenceTransferNo)
                {
                    _iCReferenceTransferNo = value;
                    NotifyChanged("ICReferenceTransferNo");
                }
            }
        }
        public int FK_ICFromStockID
        {
            get { return _fK_ICFromStockID; }
            set
            {
                if (value != this._fK_ICFromStockID)
                {
                    _fK_ICFromStockID = value;
                    NotifyChanged("FK_ICFromStockID");
                }
            }
        }
        public int FK_ICToStockID
        {
            get { return _fK_ICToStockID; }
            set
            {
                if (value != this._fK_ICToStockID)
                {
                    _fK_ICToStockID = value;
                    NotifyChanged("FK_ICToStockID");
                }
            }
        }
        public int FK_ICTransitStockID
        {
            get { return _fK_ICTransitStockID; }
            set
            {
                if (value != this._fK_ICTransitStockID)
                {
                    _fK_ICTransitStockID = value;
                    NotifyChanged("FK_ICTransitStockID");
                }
            }
        }
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        #endregion
    }
    #endregion
}