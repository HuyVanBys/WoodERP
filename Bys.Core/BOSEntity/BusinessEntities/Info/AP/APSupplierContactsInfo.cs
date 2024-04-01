using BOSLib;
using System;
namespace BOSERP
{
    #region APSupplierContacts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APSupplierContactsInfo
    //Created Date:Friday, March 14, 2008
    //-----------------------------------------------------------

    public class APSupplierContactsInfo : BusinessObject
    {
        public APSupplierContactsInfo()
        {
        }
        #region Variables
        protected int _aPSupplierContactID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aPSupplierContactName = String.Empty;
        protected int _fK_APSupplierID;
        protected DateTime _aPSupplierContactBirthday = DateTime.MaxValue;
        protected String _aPSupplierContactFirstName = String.Empty;
        protected String _aPSupplierContactLastName = String.Empty;
        protected String _aPSupplierContactTitle = String.Empty;
        protected String _aPSupplierContactHeaderLetter = String.Empty;
        protected String _aPSupplierContactHeaderMessage = String.Empty;
        protected String _aPSupplierContactEmail1 = String.Empty;
        protected String _aPSupplierContactEmail2 = String.Empty;
        protected String _aPSupplierContactWebsite = String.Empty;
        protected String _aPSupplierContactPhonePrivate = String.Empty;
        protected String _aPSupplierContactPhone = String.Empty;
        protected String _aPSupplierContactPhone1 = String.Empty;
        protected String _aPSupplierContactCellPhone1 = String.Empty;
        protected String _aPSupplierContactCellPhone = String.Empty;
        protected String _aPSupplierContactCellPhonePrivate = String.Empty;
        protected String _aPSupplierContactFax = String.Empty;
        protected String _aPContactType = String.Empty;
        protected String _aPSupplierContactTypeDisplay = String.Empty;
        protected String _aPSupplierContactInformation = String.Empty;
        protected String _aPSupplierContactDepartment = String.Empty;
        protected String _aPSupplierContactRoom = String.Empty;
        protected String _aPSupplierContactAddressLine1 = String.Empty;
        protected String _aPSupplierContactAddressLine2 = String.Empty;
        protected String _aPSupplierContactAddressLine3 = String.Empty;
        protected String _aPSupplierContactAddressStreet = String.Empty;
        protected String _aPSupplierContactAddressCity = String.Empty;
        protected String _aPSupplierContactAddressPostalCode = String.Empty;
        protected String _aPSupplierContactAddressStateProvince = String.Empty;
        protected String _aPSupplierContactAddressZipCode = String.Empty;
        protected String _aPSupplierContactAddressCountry = String.Empty;
        protected bool _aPSupplierContactDealCheck = false;
        protected bool _aPSupplierContactPODefaultCheck = false;
        protected string _aPSupplierContactLevel = string.Empty;
        protected string _aPSupplierContactCCCDNo = string.Empty;
        protected DateTime _aPSupplierContactCCCDDate = DateTime.MaxValue;
        protected string _aPSupplierContactCCCDAddressLine1 = string.Empty;
        #endregion

        #region Public properties
        public int APSupplierContactID
        {
            get { return _aPSupplierContactID; }
            set
            {
                if (value != this._aPSupplierContactID)
                {
                    _aPSupplierContactID = value;
                    NotifyChanged("APSupplierContactID");
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
        public String APSupplierContactName
        {
            get { return _aPSupplierContactName; }
            set
            {
                if (value != this._aPSupplierContactName)
                {
                    _aPSupplierContactName = value;
                    NotifyChanged("APSupplierContactName");
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
                }
            }
        }
        public DateTime APSupplierContactBirthday
        {
            get { return _aPSupplierContactBirthday; }
            set
            {
                if (value != this._aPSupplierContactBirthday)
                {
                    _aPSupplierContactBirthday = value;
                    NotifyChanged("APSupplierContactBirthday");
                }
            }
        }
        public String APSupplierContactFirstName
        {
            get { return _aPSupplierContactFirstName; }
            set
            {
                if (value != this._aPSupplierContactFirstName)
                {
                    _aPSupplierContactFirstName = value;
                    NotifyChanged("APSupplierContactFirstName");
                }
            }
        }
        public String APSupplierContactLastName
        {
            get { return _aPSupplierContactLastName; }
            set
            {
                if (value != this._aPSupplierContactLastName)
                {
                    _aPSupplierContactLastName = value;
                    NotifyChanged("APSupplierContactLastName");
                }
            }
        }
        public String APSupplierContactTitle
        {
            get { return _aPSupplierContactTitle; }
            set
            {
                if (value != this._aPSupplierContactTitle)
                {
                    _aPSupplierContactTitle = value;
                    NotifyChanged("APSupplierContactTitle");
                }
            }
        }
        public String APSupplierContactHeaderLetter
        {
            get { return _aPSupplierContactHeaderLetter; }
            set
            {
                if (value != this._aPSupplierContactHeaderLetter)
                {
                    _aPSupplierContactHeaderLetter = value;
                    NotifyChanged("APSupplierContactHeaderLetter");
                }
            }
        }
        public String APSupplierContactHeaderMessage
        {
            get { return _aPSupplierContactHeaderMessage; }
            set
            {
                if (value != this._aPSupplierContactHeaderMessage)
                {
                    _aPSupplierContactHeaderMessage = value;
                    NotifyChanged("APSupplierContactHeaderMessage");
                }
            }
        }
        public String APSupplierContactEmail1
        {
            get { return _aPSupplierContactEmail1; }
            set
            {
                if (value != this._aPSupplierContactEmail1)
                {
                    _aPSupplierContactEmail1 = value;
                    NotifyChanged("APSupplierContactEmail1");
                }
            }
        }
        public String APSupplierContactEmail2
        {
            get { return _aPSupplierContactEmail2; }
            set
            {
                if (value != this._aPSupplierContactEmail2)
                {
                    _aPSupplierContactEmail2 = value;
                    NotifyChanged("APSupplierContactEmail2");
                }
            }
        }
        public String APSupplierContactWebsite
        {
            get { return _aPSupplierContactWebsite; }
            set
            {
                if (value != this._aPSupplierContactWebsite)
                {
                    _aPSupplierContactWebsite = value;
                    NotifyChanged("APSupplierContactWebsite");
                }
            }
        }
        public String APSupplierContactPhonePrivate
        {
            get { return _aPSupplierContactPhonePrivate; }
            set
            {
                if (value != this._aPSupplierContactPhonePrivate)
                {
                    _aPSupplierContactPhonePrivate = value;
                    NotifyChanged("APSupplierContactPhonePrivate");
                }
            }
        }
        public String APSupplierContactPhone
        {
            get { return _aPSupplierContactPhone; }
            set
            {
                if (value != this._aPSupplierContactPhone)
                {
                    _aPSupplierContactPhone = value;
                    NotifyChanged("APSupplierContactPhone");
                }
            }
        }
        public String APSupplierContactPhone1
        {
            get { return _aPSupplierContactPhone1; }
            set
            {
                if (value != this._aPSupplierContactPhone1)
                {
                    _aPSupplierContactPhone1 = value;
                    NotifyChanged("APSupplierContactPhone1");
                }
            }
        }
        public String APSupplierContactCellPhone1
        {
            get { return _aPSupplierContactCellPhone1; }
            set
            {
                if (value != this._aPSupplierContactCellPhone1)
                {
                    _aPSupplierContactCellPhone1 = value;
                    NotifyChanged("APSupplierContactCellPhone1");
                }
            }
        }
        public String APSupplierContactCellPhone
        {
            get { return _aPSupplierContactCellPhone; }
            set
            {
                if (value != this._aPSupplierContactCellPhone)
                {
                    _aPSupplierContactCellPhone = value;
                    NotifyChanged("APSupplierContactCellPhone");
                }
            }
        }
        public String APSupplierContactCellPhonePrivate
        {
            get { return _aPSupplierContactCellPhonePrivate; }
            set
            {
                if (value != this._aPSupplierContactCellPhonePrivate)
                {
                    _aPSupplierContactCellPhonePrivate = value;
                    NotifyChanged("APSupplierContactCellPhonePrivate");
                }
            }
        }
        public String APSupplierContactFax
        {
            get { return _aPSupplierContactFax; }
            set
            {
                if (value != this._aPSupplierContactFax)
                {
                    _aPSupplierContactFax = value;
                    NotifyChanged("APSupplierContactFax");
                }
            }
        }
        public String APContactType
        {
            get { return _aPContactType; }
            set
            {
                if (value != this._aPContactType)
                {
                    _aPContactType = value;
                    NotifyChanged("APContactType");
                }
            }
        }
        public String APSupplierContactTypeDisplay
        {
            get { return _aPSupplierContactTypeDisplay; }
            set
            {
                if (value != this._aPSupplierContactTypeDisplay)
                {
                    _aPSupplierContactTypeDisplay = value;
                    NotifyChanged("APSupplierContactTypeDisplay");
                }
            }
        }
        public String APSupplierContactInformation
        {
            get { return _aPSupplierContactInformation; }
            set
            {
                if (value != this._aPSupplierContactInformation)
                {
                    _aPSupplierContactInformation = value;
                    NotifyChanged("APSupplierContactInformation");
                }
            }
        }
        public String APSupplierContactDepartment
        {
            get { return _aPSupplierContactDepartment; }
            set
            {
                if (value != this._aPSupplierContactDepartment)
                {
                    _aPSupplierContactDepartment = value;
                    NotifyChanged("APSupplierContactDepartment");
                }
            }
        }
        public String APSupplierContactRoom
        {
            get { return _aPSupplierContactRoom; }
            set
            {
                if (value != this._aPSupplierContactRoom)
                {
                    _aPSupplierContactRoom = value;
                    NotifyChanged("APSupplierContactRoom");
                }
            }
        }
        public String APSupplierContactAddressLine1
        {
            get { return _aPSupplierContactAddressLine1; }
            set
            {
                if (value != this._aPSupplierContactAddressLine1)
                {
                    _aPSupplierContactAddressLine1 = value;
                    NotifyChanged("APSupplierContactAddressLine1");
                }
            }
        }
        public String APSupplierContactAddressLine2
        {
            get { return _aPSupplierContactAddressLine2; }
            set
            {
                if (value != this._aPSupplierContactAddressLine2)
                {
                    _aPSupplierContactAddressLine2 = value;
                    NotifyChanged("APSupplierContactAddressLine2");
                }
            }
        }
        public String APSupplierContactAddressLine3
        {
            get { return _aPSupplierContactAddressLine3; }
            set
            {
                if (value != this._aPSupplierContactAddressLine3)
                {
                    _aPSupplierContactAddressLine3 = value;
                    NotifyChanged("APSupplierContactAddressLine3");
                }
            }
        }
        public String APSupplierContactAddressStreet
        {
            get { return _aPSupplierContactAddressStreet; }
            set
            {
                if (value != this._aPSupplierContactAddressStreet)
                {
                    _aPSupplierContactAddressStreet = value;
                    NotifyChanged("APSupplierContactAddressStreet");
                }
            }
        }
        public String APSupplierContactAddressCity
        {
            get { return _aPSupplierContactAddressCity; }
            set
            {
                if (value != this._aPSupplierContactAddressCity)
                {
                    _aPSupplierContactAddressCity = value;
                    NotifyChanged("APSupplierContactAddressCity");
                }
            }
        }
        public String APSupplierContactAddressPostalCode
        {
            get { return _aPSupplierContactAddressPostalCode; }
            set
            {
                if (value != this._aPSupplierContactAddressPostalCode)
                {
                    _aPSupplierContactAddressPostalCode = value;
                    NotifyChanged("APSupplierContactAddressPostalCode");
                }
            }
        }
        public String APSupplierContactAddressStateProvince
        {
            get { return _aPSupplierContactAddressStateProvince; }
            set
            {
                if (value != this._aPSupplierContactAddressStateProvince)
                {
                    _aPSupplierContactAddressStateProvince = value;
                    NotifyChanged("APSupplierContactAddressStateProvince");
                }
            }
        }
        public String APSupplierContactAddressZipCode
        {
            get { return _aPSupplierContactAddressZipCode; }
            set
            {
                if (value != this._aPSupplierContactAddressZipCode)
                {
                    _aPSupplierContactAddressZipCode = value;
                    NotifyChanged("APSupplierContactAddressZipCode");
                }
            }
        }
        public String APSupplierContactAddressCountry
        {
            get { return _aPSupplierContactAddressCountry; }
            set
            {
                if (value != this._aPSupplierContactAddressCountry)
                {
                    _aPSupplierContactAddressCountry = value;
                    NotifyChanged("APSupplierContactAddressCountry");
                }
            }
        }
        public bool APSupplierContactDealCheck
        {
            get { return _aPSupplierContactDealCheck; }
            set
            {
                if (value != this._aPSupplierContactDealCheck)
                {
                    _aPSupplierContactDealCheck = value;
                    NotifyChanged("APSupplierContactDealCheck");
                }
            }
        }
        public bool APSupplierContactPODefaultCheck
        {
            get { return _aPSupplierContactPODefaultCheck; }
            set
            {
                if (value != this._aPSupplierContactPODefaultCheck)
                {
                    _aPSupplierContactPODefaultCheck = value;
                    NotifyChanged("APSupplierContactPODefaultCheck");
                }
            }
        }
        public string APSupplierContactLevel
        {
            get { return _aPSupplierContactLevel; }
            set
            {
                if (value != this._aPSupplierContactLevel)
                {
                    _aPSupplierContactLevel = value;
                    NotifyChanged("APSupplierContactLevel");
                }
            }
        }
        public string APSupplierContactCCCDNo
        {
            get { return _aPSupplierContactCCCDNo; }
            set
            {
                if (value != this._aPSupplierContactCCCDNo)
                {
                    _aPSupplierContactCCCDNo = value;
                    NotifyChanged("APSupplierContactCCCDNo");
                }
            }
        }
        public DateTime APSupplierContactCCCDDate
        {
            get { return _aPSupplierContactCCCDDate; }
            set
            {
                if (value != this._aPSupplierContactCCCDDate)
                {
                    _aPSupplierContactCCCDDate = value;
                    NotifyChanged("APSupplierContactCCCDDate");
                }
            }
        }
        public string APSupplierContactCCCDAddressLine1
        {
            get { return _aPSupplierContactCCCDAddressLine1; }
            set
            {
                if (value != this._aPSupplierContactCCCDAddressLine1)
                {
                    _aPSupplierContactCCCDAddressLine1 = value;
                    NotifyChanged("APSupplierContactCCCDAddressLine1");
                }
            }
        }
        #endregion
    }
    #endregion
}