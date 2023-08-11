using BOSLib;
using System;
namespace BOSERP
{
    #region ICStocks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICStocksInfo
    //Created Date:Friday, September 23, 2011
    //-----------------------------------------------------------

    public class ICStocksInfo : BOSTreeListObject
    {
        public ICStocksInfo()
        {
        }

        public ICStocksInfo(string stockNo, string stockName)
        {
            this.ICStockName = stockName;
            this.ICStockNo = stockNo;
        }

        public ICStocksInfo(int stockID, string stockName)
        {
            ICStockID = stockID;
            ICStockName = stockName;
        }

        #region Variables
        protected int _iCStockID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected int _fK_GELanguageID;
        protected int _fK_GECurrencyID;
        protected int _iCStockParentID;
        protected int _fK_BRBranchID;
        protected String _iCStockNo = String.Empty;
        protected String _iCStockName = String.Empty;
        protected String _iCStockDesc = String.Empty;
        protected String _iCStockType = String.Empty;
        protected String _iCStockMatchCode01Combo = String.Empty;
        protected String _iCStockMatchCode02Combo = String.Empty;
        protected String _iCStockMatchCode03Combo = String.Empty;
        protected String _iCStockMatchCode04Combo = String.Empty;
        protected String _iCStockMatchCode05Combo = String.Empty;
        protected String _iCStockMatchCode06Combo = String.Empty;
        protected String _iCStockMatchCode07Combo = String.Empty;
        protected String _iCStockMatchCode08Combo = String.Empty;
        protected String _iCStockMatchCode09Combo = String.Empty;
        protected String _iCStockMatchCode10Combo = String.Empty;
        protected bool _iCStockActiveCheck = true;
        protected String _iCStockInfo = String.Empty;
        protected String _iCStockContactName = String.Empty;
        protected DateTime _iCStockContactBirthday = DateTime.MaxValue;
        protected String _iCStockContactFirstName = String.Empty;
        protected String _iCStockContactLastName = String.Empty;
        protected String _iCStockContactTitle = String.Empty;
        protected String _iCStockContactHeaderLetter = String.Empty;
        protected String _iCStockContactHeaderMessage = String.Empty;
        protected String _iCStockContactEmail1 = String.Empty;
        protected String _iCStockContactEmail2 = String.Empty;
        protected String _iCStockContactWebsite = String.Empty;
        protected String _iCStockContactPhonePrivate = String.Empty;
        protected String _iCStockContactPhone = String.Empty;
        protected String _iCStockContactPhone1 = String.Empty;
        protected String _iCStockContactCellPhone = String.Empty;
        protected String _iCStockContactCellPhone1 = String.Empty;
        protected String _iCStockContactFax = String.Empty;
        protected String _iCStockContactInformation = String.Empty;
        protected String _iCStockContactDepartment = String.Empty;
        protected String _iCStockContactRoom = String.Empty;
        protected String _iCStockContactAddressStreet = String.Empty;
        protected String _iCStockContactAddressLine1 = String.Empty;
        protected String _iCStockContactAddressLine2 = String.Empty;
        protected String _iCStockContactAddressLine3 = String.Empty;
        protected String _iCStockContactAddressCity = String.Empty;
        protected String _iCStockContactAddressPostalCode = String.Empty;
        protected String _iCStockContactAddressStateProvince = String.Empty;
        protected String _iCStockContactAddressZipCode = String.Empty;
        protected String _iCStockContactAddressCountry = String.Empty;
        protected int _fK_ACAccountID;
        protected String _iCStockPrefix = String.Empty;
        protected bool _iCStockIsSemiProduct = false;
        #endregion

        #region Public properties
        public int ICStockID
        {
            get { return _iCStockID; }
            set
            {
                if (value != this._iCStockID)
                {
                    _iCStockID = value;
                    NotifyChanged("ICStockID");
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
        public int FK_GELanguageID
        {
            get { return _fK_GELanguageID; }
            set
            {
                if (value != this._fK_GELanguageID)
                {
                    _fK_GELanguageID = value;
                    NotifyChanged("FK_GELanguageID");
                }
            }
        }
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public int ICStockParentID
        {
            get { return _iCStockParentID; }
            set
            {
                if (value != this._iCStockParentID)
                {
                    _iCStockParentID = value;
                    NotifyChanged("ICStockParentID");
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
        public String ICStockNo
        {
            get { return _iCStockNo; }
            set
            {
                if (value != this._iCStockNo)
                {
                    _iCStockNo = value;
                    NotifyChanged("ICStockNo");
                }
            }
        }
        public String ICStockName
        {
            get { return _iCStockName; }
            set
            {
                if (value != this._iCStockName)
                {
                    _iCStockName = value;
                    NotifyChanged("ICStockName");
                }
            }
        }
        public String ICStockDesc
        {
            get { return _iCStockDesc; }
            set
            {
                if (value != this._iCStockDesc)
                {
                    _iCStockDesc = value;
                    NotifyChanged("ICStockDesc");
                }
            }
        }
        public String ICStockType
        {
            get { return _iCStockType; }
            set
            {
                if (value != this._iCStockType)
                {
                    _iCStockType = value;
                    NotifyChanged("ICStockType");
                }
            }
        }
        public String ICStockMatchCode01Combo
        {
            get { return _iCStockMatchCode01Combo; }
            set
            {
                if (value != this._iCStockMatchCode01Combo)
                {
                    _iCStockMatchCode01Combo = value;
                    NotifyChanged("ICStockMatchCode01Combo");
                }
            }
        }
        public String ICStockMatchCode02Combo
        {
            get { return _iCStockMatchCode02Combo; }
            set
            {
                if (value != this._iCStockMatchCode02Combo)
                {
                    _iCStockMatchCode02Combo = value;
                    NotifyChanged("ICStockMatchCode02Combo");
                }
            }
        }
        public String ICStockMatchCode03Combo
        {
            get { return _iCStockMatchCode03Combo; }
            set
            {
                if (value != this._iCStockMatchCode03Combo)
                {
                    _iCStockMatchCode03Combo = value;
                    NotifyChanged("ICStockMatchCode03Combo");
                }
            }
        }
        public String ICStockMatchCode04Combo
        {
            get { return _iCStockMatchCode04Combo; }
            set
            {
                if (value != this._iCStockMatchCode04Combo)
                {
                    _iCStockMatchCode04Combo = value;
                    NotifyChanged("ICStockMatchCode04Combo");
                }
            }
        }
        public String ICStockMatchCode05Combo
        {
            get { return _iCStockMatchCode05Combo; }
            set
            {
                if (value != this._iCStockMatchCode05Combo)
                {
                    _iCStockMatchCode05Combo = value;
                    NotifyChanged("ICStockMatchCode05Combo");
                }
            }
        }
        public String ICStockMatchCode06Combo
        {
            get { return _iCStockMatchCode06Combo; }
            set
            {
                if (value != this._iCStockMatchCode06Combo)
                {
                    _iCStockMatchCode06Combo = value;
                    NotifyChanged("ICStockMatchCode06Combo");
                }
            }
        }
        public String ICStockMatchCode07Combo
        {
            get { return _iCStockMatchCode07Combo; }
            set
            {
                if (value != this._iCStockMatchCode07Combo)
                {
                    _iCStockMatchCode07Combo = value;
                    NotifyChanged("ICStockMatchCode07Combo");
                }
            }
        }
        public String ICStockMatchCode08Combo
        {
            get { return _iCStockMatchCode08Combo; }
            set
            {
                if (value != this._iCStockMatchCode08Combo)
                {
                    _iCStockMatchCode08Combo = value;
                    NotifyChanged("ICStockMatchCode08Combo");
                }
            }
        }
        public String ICStockMatchCode09Combo
        {
            get { return _iCStockMatchCode09Combo; }
            set
            {
                if (value != this._iCStockMatchCode09Combo)
                {
                    _iCStockMatchCode09Combo = value;
                    NotifyChanged("ICStockMatchCode09Combo");
                }
            }
        }
        public String ICStockMatchCode10Combo
        {
            get { return _iCStockMatchCode10Combo; }
            set
            {
                if (value != this._iCStockMatchCode10Combo)
                {
                    _iCStockMatchCode10Combo = value;
                    NotifyChanged("ICStockMatchCode10Combo");
                }
            }
        }
        public bool ICStockActiveCheck
        {
            get { return _iCStockActiveCheck; }
            set
            {
                if (value != this._iCStockActiveCheck)
                {
                    _iCStockActiveCheck = value;
                    NotifyChanged("ICStockActiveCheck");
                }
            }
        }
        public String ICStockInfo
        {
            get { return _iCStockInfo; }
            set
            {
                if (value != this._iCStockInfo)
                {
                    _iCStockInfo = value;
                    NotifyChanged("ICStockInfo");
                }
            }
        }
        public String ICStockContactName
        {
            get { return _iCStockContactName; }
            set
            {
                if (value != this._iCStockContactName)
                {
                    _iCStockContactName = value;
                    NotifyChanged("ICStockContactName");
                }
            }
        }
        public DateTime ICStockContactBirthday
        {
            get { return _iCStockContactBirthday; }
            set
            {
                if (value != this._iCStockContactBirthday)
                {
                    _iCStockContactBirthday = value;
                    NotifyChanged("ICStockContactBirthday");
                }
            }
        }
        public String ICStockContactFirstName
        {
            get { return _iCStockContactFirstName; }
            set
            {
                if (value != this._iCStockContactFirstName)
                {
                    _iCStockContactFirstName = value;
                    NotifyChanged("ICStockContactFirstName");
                }
            }
        }
        public String ICStockContactLastName
        {
            get { return _iCStockContactLastName; }
            set
            {
                if (value != this._iCStockContactLastName)
                {
                    _iCStockContactLastName = value;
                    NotifyChanged("ICStockContactLastName");
                }
            }
        }
        public String ICStockContactTitle
        {
            get { return _iCStockContactTitle; }
            set
            {
                if (value != this._iCStockContactTitle)
                {
                    _iCStockContactTitle = value;
                    NotifyChanged("ICStockContactTitle");
                }
            }
        }
        public String ICStockContactHeaderLetter
        {
            get { return _iCStockContactHeaderLetter; }
            set
            {
                if (value != this._iCStockContactHeaderLetter)
                {
                    _iCStockContactHeaderLetter = value;
                    NotifyChanged("ICStockContactHeaderLetter");
                }
            }
        }
        public String ICStockContactHeaderMessage
        {
            get { return _iCStockContactHeaderMessage; }
            set
            {
                if (value != this._iCStockContactHeaderMessage)
                {
                    _iCStockContactHeaderMessage = value;
                    NotifyChanged("ICStockContactHeaderMessage");
                }
            }
        }
        public String ICStockContactEmail1
        {
            get { return _iCStockContactEmail1; }
            set
            {
                if (value != this._iCStockContactEmail1)
                {
                    _iCStockContactEmail1 = value;
                    NotifyChanged("ICStockContactEmail1");
                }
            }
        }
        public String ICStockContactEmail2
        {
            get { return _iCStockContactEmail2; }
            set
            {
                if (value != this._iCStockContactEmail2)
                {
                    _iCStockContactEmail2 = value;
                    NotifyChanged("ICStockContactEmail2");
                }
            }
        }
        public String ICStockContactWebsite
        {
            get { return _iCStockContactWebsite; }
            set
            {
                if (value != this._iCStockContactWebsite)
                {
                    _iCStockContactWebsite = value;
                    NotifyChanged("ICStockContactWebsite");
                }
            }
        }
        public String ICStockContactPhonePrivate
        {
            get { return _iCStockContactPhonePrivate; }
            set
            {
                if (value != this._iCStockContactPhonePrivate)
                {
                    _iCStockContactPhonePrivate = value;
                    NotifyChanged("ICStockContactPhonePrivate");
                }
            }
        }
        public String ICStockContactPhone
        {
            get { return _iCStockContactPhone; }
            set
            {
                if (value != this._iCStockContactPhone)
                {
                    _iCStockContactPhone = value;
                    NotifyChanged("ICStockContactPhone");
                }
            }
        }
        public String ICStockContactPhone1
        {
            get { return _iCStockContactPhone1; }
            set
            {
                if (value != this._iCStockContactPhone1)
                {
                    _iCStockContactPhone1 = value;
                    NotifyChanged("ICStockContactPhone1");
                }
            }
        }
        public String ICStockContactCellPhone
        {
            get { return _iCStockContactCellPhone; }
            set
            {
                if (value != this._iCStockContactCellPhone)
                {
                    _iCStockContactCellPhone = value;
                    NotifyChanged("ICStockContactCellPhone");
                }
            }
        }
        public String ICStockContactCellPhone1
        {
            get { return _iCStockContactCellPhone1; }
            set
            {
                if (value != this._iCStockContactCellPhone1)
                {
                    _iCStockContactCellPhone1 = value;
                    NotifyChanged("ICStockContactCellPhone1");
                }
            }
        }
        public String ICStockContactFax
        {
            get { return _iCStockContactFax; }
            set
            {
                if (value != this._iCStockContactFax)
                {
                    _iCStockContactFax = value;
                    NotifyChanged("ICStockContactFax");
                }
            }
        }
        public String ICStockContactInformation
        {
            get { return _iCStockContactInformation; }
            set
            {
                if (value != this._iCStockContactInformation)
                {
                    _iCStockContactInformation = value;
                    NotifyChanged("ICStockContactInformation");
                }
            }
        }
        public String ICStockContactDepartment
        {
            get { return _iCStockContactDepartment; }
            set
            {
                if (value != this._iCStockContactDepartment)
                {
                    _iCStockContactDepartment = value;
                    NotifyChanged("ICStockContactDepartment");
                }
            }
        }
        public String ICStockContactRoom
        {
            get { return _iCStockContactRoom; }
            set
            {
                if (value != this._iCStockContactRoom)
                {
                    _iCStockContactRoom = value;
                    NotifyChanged("ICStockContactRoom");
                }
            }
        }
        public String ICStockContactAddressStreet
        {
            get { return _iCStockContactAddressStreet; }
            set
            {
                if (value != this._iCStockContactAddressStreet)
                {
                    _iCStockContactAddressStreet = value;
                    NotifyChanged("ICStockContactAddressStreet");
                }
            }
        }
        public String ICStockContactAddressLine1
        {
            get { return _iCStockContactAddressLine1; }
            set
            {
                if (value != this._iCStockContactAddressLine1)
                {
                    _iCStockContactAddressLine1 = value;
                    NotifyChanged("ICStockContactAddressLine1");
                }
            }
        }
        public String ICStockContactAddressLine2
        {
            get { return _iCStockContactAddressLine2; }
            set
            {
                if (value != this._iCStockContactAddressLine2)
                {
                    _iCStockContactAddressLine2 = value;
                    NotifyChanged("ICStockContactAddressLine2");
                }
            }
        }
        public String ICStockContactAddressLine3
        {
            get { return _iCStockContactAddressLine3; }
            set
            {
                if (value != this._iCStockContactAddressLine3)
                {
                    _iCStockContactAddressLine3 = value;
                    NotifyChanged("ICStockContactAddressLine3");
                }
            }
        }
        public String ICStockContactAddressCity
        {
            get { return _iCStockContactAddressCity; }
            set
            {
                if (value != this._iCStockContactAddressCity)
                {
                    _iCStockContactAddressCity = value;
                    NotifyChanged("ICStockContactAddressCity");
                }
            }
        }
        public String ICStockContactAddressPostalCode
        {
            get { return _iCStockContactAddressPostalCode; }
            set
            {
                if (value != this._iCStockContactAddressPostalCode)
                {
                    _iCStockContactAddressPostalCode = value;
                    NotifyChanged("ICStockContactAddressPostalCode");
                }
            }
        }
        public String ICStockContactAddressStateProvince
        {
            get { return _iCStockContactAddressStateProvince; }
            set
            {
                if (value != this._iCStockContactAddressStateProvince)
                {
                    _iCStockContactAddressStateProvince = value;
                    NotifyChanged("ICStockContactAddressStateProvince");
                }
            }
        }
        public String ICStockContactAddressZipCode
        {
            get { return _iCStockContactAddressZipCode; }
            set
            {
                if (value != this._iCStockContactAddressZipCode)
                {
                    _iCStockContactAddressZipCode = value;
                    NotifyChanged("ICStockContactAddressZipCode");
                }
            }
        }
        public String ICStockContactAddressCountry
        {
            get { return _iCStockContactAddressCountry; }
            set
            {
                if (value != this._iCStockContactAddressCountry)
                {
                    _iCStockContactAddressCountry = value;
                    NotifyChanged("ICStockContactAddressCountry");
                }
            }
        }
        public int FK_ACAccountID
        {
            get { return _fK_ACAccountID; }
            set
            {
                if (value != this._fK_ACAccountID)
                {
                    _fK_ACAccountID = value;
                    NotifyChanged("FK_ACAccountID");
                }
            }
        }
        public String ICStockPrefix
        {
            get { return _iCStockPrefix; }
            set
            {
                if (value != this._iCStockPrefix)
                {
                    _iCStockPrefix = value;
                    NotifyChanged("ICStockPrefix");
                }
            }
        }
        public bool ICStockIsSemiProduct
        {
            get { return _iCStockIsSemiProduct; }
            set
            {
                if (value != this._iCStockIsSemiProduct)
                {
                    _iCStockIsSemiProduct = value;
                    NotifyChanged("ICStockIsSemiProduct");
                }
            }
        }

        #endregion

        #region Extra Properties
        public string BRBranchName { get; set; }

        public int BRBranchParentID { get; set; }
        #endregion
    }
    #endregion
}