using BOSLib;
using System;
namespace BOSERP
{
    #region ARCustomerContacts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCustomerContactsInfo
    //Created Date:27/10/2020 10:42:23
    //-----------------------------------------------------------

    public class ARCustomerContactsInfo : BusinessObject
    {
        public ARCustomerContactsInfo()
        {
        }
        #region Variables
        protected int _aRCustomerContactID;
        protected string _aAStatus = DefaultAAStatus;
        protected string _aRCustomerContactName = string.Empty;
        protected int _fK_ARCustomerID;
        protected DateTime _aRCustomerContactBirthday = DateTime.MaxValue;
        protected string _aRCustomerContactFirstName = string.Empty;
        protected string _aRCustomerContactLastName = string.Empty;
        protected string _aRCustomerContactTitle = string.Empty;
        protected string _aRCustomerContactHeaderLetter = string.Empty;
        protected string _aRCustomerContactHeaderMessage = string.Empty;
        protected string _aRCustomerContactEmail1 = string.Empty;
        protected string _aRCustomerContactEmail2 = string.Empty;
        protected string _aRCustomerContactWebsite = string.Empty;
        protected string _aRCustomerContactPhonePrivate = string.Empty;
        protected string _aRCustomerContactPhone = string.Empty;
        protected string _aRCustomerContactPhone1 = string.Empty;
        protected string _aRCustomerContactCellPhone1 = string.Empty;
        protected string _aRCustomerContactCellPhone = string.Empty;
        protected string _aRCustomerContactCellPhonePrivate = string.Empty;
        protected string _aRCustomerContactFax = string.Empty;
        protected string _aRContactType = string.Empty;
        protected string _aRCustomerContactTypeDisplay = string.Empty;
        protected string _aRCustomerContactInformation = string.Empty;
        protected string _aRCustomerContactDepartment = string.Empty;
        protected string _aRCustomerContactRoom = string.Empty;
        protected string _aRCustomerContactAddressLine1 = string.Empty;
        protected string _aRCustomerContactAddressLine2 = string.Empty;
        protected string _aRCustomerContactAddressLine3 = string.Empty;
        protected string _aRCustomerContactAddressStreet = string.Empty;
        protected string _aRCustomerContactAddressCity = string.Empty;
        protected string _aRCustomerContactAddressPostalCode = string.Empty;
        protected string _aRCustomerContactAddressStateProvince = string.Empty;
        protected string _aRCustomerContactAddressZipCode = string.Empty;
        protected string _aRCustomerContactAddressCountry = string.Empty;
        protected string _aRCustomerContactTaxCode = string.Empty;
        protected bool _aRCustomerContactDefaultAddress = true;
        protected string _aRCustomerContactComment = string.Empty;
        protected bool _aRCustomerContactTransactionContactInfo = true;
        protected string _aRCustomerContactAddress = string.Empty;
        protected string _aRCustomerContactAddress2 = string.Empty;
        protected string _aRCustomerContactAssignedTo = string.Empty;
        protected string _aRCustomerContactAssistant = string.Empty;
        protected string _aRCustomerContactAssistantPhone = string.Empty;
        protected string _aRCustomerContactCellularPhone = string.Empty;
        protected string _aRCustomerContactAddressCity2 = string.Empty;
        protected string _aRCustomerContactAddressCountry2 = string.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected string _aACreatedUser = string.Empty;
        protected int _createdUserID;
        protected string _aRCustomerContactAddressDistrict = string.Empty;
        protected string _aRCustomerContactAddressDistrict2 = string.Empty;
        protected int _fK_HRGroupID;
        protected int _fK_HREmployeeID;
        protected string _aRCustomerContactHomePhone = string.Empty;
        protected byte[] _aRCustomerContactImage;
        protected string _aRCustomerContactJobTitle = string.Empty;
        protected string _aRCustomerContactPotentialSource = string.Empty;
        protected long _rEV;
        protected long _rEVTYPE;
        protected string _aRCustomerContactSecondaryPhone = string.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected string _aAUpdatedUser = string.Empty;
        protected int _updatedUserID;
        protected int _fK_BRBranchID;
        protected int _fK_GELocationID;
        protected int _fK_ARProspectCustomerID;
        protected int _fK_ARCustomerResourceID;
        protected int _fK_ADUserGroupID;
        #endregion

        #region Public properties
        public int ARCustomerContactID
        {
            get { return _aRCustomerContactID; }
            set
            {
                if (value != this._aRCustomerContactID)
                {
                    _aRCustomerContactID = value;
                    NotifyChanged("ARCustomerContactID");
                }
            }
        }
        public string AAStatus
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
        public string ARCustomerContactName
        {
            get { return _aRCustomerContactName; }
            set
            {
                if (value != this._aRCustomerContactName)
                {
                    _aRCustomerContactName = value;
                    NotifyChanged("ARCustomerContactName");
                }
            }
        }
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public DateTime ARCustomerContactBirthday
        {
            get { return _aRCustomerContactBirthday; }
            set
            {
                if (value != this._aRCustomerContactBirthday)
                {
                    _aRCustomerContactBirthday = value;
                    NotifyChanged("ARCustomerContactBirthday");
                }
            }
        }
        public string ARCustomerContactFirstName
        {
            get { return _aRCustomerContactFirstName; }
            set
            {
                if (value != this._aRCustomerContactFirstName)
                {
                    _aRCustomerContactFirstName = value;
                    NotifyChanged("ARCustomerContactFirstName");
                }
            }
        }
        public string ARCustomerContactLastName
        {
            get { return _aRCustomerContactLastName; }
            set
            {
                if (value != this._aRCustomerContactLastName)
                {
                    _aRCustomerContactLastName = value;
                    NotifyChanged("ARCustomerContactLastName");
                }
            }
        }
        public string ARCustomerContactTitle
        {
            get { return _aRCustomerContactTitle; }
            set
            {
                if (value != this._aRCustomerContactTitle)
                {
                    _aRCustomerContactTitle = value;
                    NotifyChanged("ARCustomerContactTitle");
                }
            }
        }
        public string ARCustomerContactHeaderLetter
        {
            get { return _aRCustomerContactHeaderLetter; }
            set
            {
                if (value != this._aRCustomerContactHeaderLetter)
                {
                    _aRCustomerContactHeaderLetter = value;
                    NotifyChanged("ARCustomerContactHeaderLetter");
                }
            }
        }
        public string ARCustomerContactHeaderMessage
        {
            get { return _aRCustomerContactHeaderMessage; }
            set
            {
                if (value != this._aRCustomerContactHeaderMessage)
                {
                    _aRCustomerContactHeaderMessage = value;
                    NotifyChanged("ARCustomerContactHeaderMessage");
                }
            }
        }
        public string ARCustomerContactEmail1
        {
            get { return _aRCustomerContactEmail1; }
            set
            {
                if (value != this._aRCustomerContactEmail1)
                {
                    _aRCustomerContactEmail1 = value;
                    NotifyChanged("ARCustomerContactEmail1");
                }
            }
        }
        public string ARCustomerContactEmail2
        {
            get { return _aRCustomerContactEmail2; }
            set
            {
                if (value != this._aRCustomerContactEmail2)
                {
                    _aRCustomerContactEmail2 = value;
                    NotifyChanged("ARCustomerContactEmail2");
                }
            }
        }
        public string ARCustomerContactWebsite
        {
            get { return _aRCustomerContactWebsite; }
            set
            {
                if (value != this._aRCustomerContactWebsite)
                {
                    _aRCustomerContactWebsite = value;
                    NotifyChanged("ARCustomerContactWebsite");
                }
            }
        }
        public string ARCustomerContactPhonePrivate
        {
            get { return _aRCustomerContactPhonePrivate; }
            set
            {
                if (value != this._aRCustomerContactPhonePrivate)
                {
                    _aRCustomerContactPhonePrivate = value;
                    NotifyChanged("ARCustomerContactPhonePrivate");
                }
            }
        }
        public string ARCustomerContactPhone
        {
            get { return _aRCustomerContactPhone; }
            set
            {
                if (value != this._aRCustomerContactPhone)
                {
                    _aRCustomerContactPhone = value;
                    NotifyChanged("ARCustomerContactPhone");
                }
            }
        }
        public string ARCustomerContactPhone1
        {
            get { return _aRCustomerContactPhone1; }
            set
            {
                if (value != this._aRCustomerContactPhone1)
                {
                    _aRCustomerContactPhone1 = value;
                    NotifyChanged("ARCustomerContactPhone1");
                }
            }
        }
        public string ARCustomerContactCellPhone1
        {
            get { return _aRCustomerContactCellPhone1; }
            set
            {
                if (value != this._aRCustomerContactCellPhone1)
                {
                    _aRCustomerContactCellPhone1 = value;
                    NotifyChanged("ARCustomerContactCellPhone1");
                }
            }
        }
        public string ARCustomerContactCellPhone
        {
            get { return _aRCustomerContactCellPhone; }
            set
            {
                if (value != this._aRCustomerContactCellPhone)
                {
                    _aRCustomerContactCellPhone = value;
                    NotifyChanged("ARCustomerContactCellPhone");
                }
            }
        }
        public string ARCustomerContactCellPhonePrivate
        {
            get { return _aRCustomerContactCellPhonePrivate; }
            set
            {
                if (value != this._aRCustomerContactCellPhonePrivate)
                {
                    _aRCustomerContactCellPhonePrivate = value;
                    NotifyChanged("ARCustomerContactCellPhonePrivate");
                }
            }
        }
        public string ARCustomerContactFax
        {
            get { return _aRCustomerContactFax; }
            set
            {
                if (value != this._aRCustomerContactFax)
                {
                    _aRCustomerContactFax = value;
                    NotifyChanged("ARCustomerContactFax");
                }
            }
        }
        public string ARContactType
        {
            get { return _aRContactType; }
            set
            {
                if (value != this._aRContactType)
                {
                    _aRContactType = value;
                    NotifyChanged("ARContactType");
                }
            }
        }
        public string ARCustomerContactTypeDisplay
        {
            get { return _aRCustomerContactTypeDisplay; }
            set
            {
                if (value != this._aRCustomerContactTypeDisplay)
                {
                    _aRCustomerContactTypeDisplay = value;
                    NotifyChanged("ARCustomerContactTypeDisplay");
                }
            }
        }
        public string ARCustomerContactInformation
        {
            get { return _aRCustomerContactInformation; }
            set
            {
                if (value != this._aRCustomerContactInformation)
                {
                    _aRCustomerContactInformation = value;
                    NotifyChanged("ARCustomerContactInformation");
                }
            }
        }
        public string ARCustomerContactDepartment
        {
            get { return _aRCustomerContactDepartment; }
            set
            {
                if (value != this._aRCustomerContactDepartment)
                {
                    _aRCustomerContactDepartment = value;
                    NotifyChanged("ARCustomerContactDepartment");
                }
            }
        }
        public string ARCustomerContactRoom
        {
            get { return _aRCustomerContactRoom; }
            set
            {
                if (value != this._aRCustomerContactRoom)
                {
                    _aRCustomerContactRoom = value;
                    NotifyChanged("ARCustomerContactRoom");
                }
            }
        }
        public string ARCustomerContactAddressLine1
        {
            get { return _aRCustomerContactAddressLine1; }
            set
            {
                if (value != this._aRCustomerContactAddressLine1)
                {
                    _aRCustomerContactAddressLine1 = value;
                    NotifyChanged("ARCustomerContactAddressLine1");
                }
            }
        }
        public string ARCustomerContactAddressLine2
        {
            get { return _aRCustomerContactAddressLine2; }
            set
            {
                if (value != this._aRCustomerContactAddressLine2)
                {
                    _aRCustomerContactAddressLine2 = value;
                    NotifyChanged("ARCustomerContactAddressLine2");
                }
            }
        }
        public string ARCustomerContactAddressLine3
        {
            get { return _aRCustomerContactAddressLine3; }
            set
            {
                if (value != this._aRCustomerContactAddressLine3)
                {
                    _aRCustomerContactAddressLine3 = value;
                    NotifyChanged("ARCustomerContactAddressLine3");
                }
            }
        }
        public string ARCustomerContactAddressStreet
        {
            get { return _aRCustomerContactAddressStreet; }
            set
            {
                if (value != this._aRCustomerContactAddressStreet)
                {
                    _aRCustomerContactAddressStreet = value;
                    NotifyChanged("ARCustomerContactAddressStreet");
                }
            }
        }
        public string ARCustomerContactAddressCity
        {
            get { return _aRCustomerContactAddressCity; }
            set
            {
                if (value != this._aRCustomerContactAddressCity)
                {
                    _aRCustomerContactAddressCity = value;
                    NotifyChanged("ARCustomerContactAddressCity");
                }
            }
        }
        public string ARCustomerContactAddressPostalCode
        {
            get { return _aRCustomerContactAddressPostalCode; }
            set
            {
                if (value != this._aRCustomerContactAddressPostalCode)
                {
                    _aRCustomerContactAddressPostalCode = value;
                    NotifyChanged("ARCustomerContactAddressPostalCode");
                }
            }
        }
        public string ARCustomerContactAddressStateProvince
        {
            get { return _aRCustomerContactAddressStateProvince; }
            set
            {
                if (value != this._aRCustomerContactAddressStateProvince)
                {
                    _aRCustomerContactAddressStateProvince = value;
                    NotifyChanged("ARCustomerContactAddressStateProvince");
                }
            }
        }
        public string ARCustomerContactAddressZipCode
        {
            get { return _aRCustomerContactAddressZipCode; }
            set
            {
                if (value != this._aRCustomerContactAddressZipCode)
                {
                    _aRCustomerContactAddressZipCode = value;
                    NotifyChanged("ARCustomerContactAddressZipCode");
                }
            }
        }
        public string ARCustomerContactAddressCountry
        {
            get { return _aRCustomerContactAddressCountry; }
            set
            {
                if (value != this._aRCustomerContactAddressCountry)
                {
                    _aRCustomerContactAddressCountry = value;
                    NotifyChanged("ARCustomerContactAddressCountry");
                }
            }
        }
        public string ARCustomerContactTaxCode
        {
            get { return _aRCustomerContactTaxCode; }
            set
            {
                if (value != this._aRCustomerContactTaxCode)
                {
                    _aRCustomerContactTaxCode = value;
                    NotifyChanged("ARCustomerContactTaxCode");
                }
            }
        }
        public bool ARCustomerContactDefaultAddress
        {
            get { return _aRCustomerContactDefaultAddress; }
            set
            {
                if (value != this._aRCustomerContactDefaultAddress)
                {
                    _aRCustomerContactDefaultAddress = value;
                    NotifyChanged("ARCustomerContactDefaultAddress");
                }
            }
        }
        public string ARCustomerContactComment
        {
            get { return _aRCustomerContactComment; }
            set
            {
                if (value != this._aRCustomerContactComment)
                {
                    _aRCustomerContactComment = value;
                    NotifyChanged("ARCustomerContactComment");
                }
            }
        }
        public bool ARCustomerContactTransactionContactInfo
        {
            get { return _aRCustomerContactTransactionContactInfo; }
            set
            {
                if (value != this._aRCustomerContactTransactionContactInfo)
                {
                    _aRCustomerContactTransactionContactInfo = value;
                    NotifyChanged("ARCustomerContactTransactionContactInfo");
                }
            }
        }
        public string ARCustomerContactAddress
        {
            get { return _aRCustomerContactAddress; }
            set
            {
                if (value != this._aRCustomerContactAddress)
                {
                    _aRCustomerContactAddress = value;
                    NotifyChanged("ARCustomerContactAddress");
                }
            }
        }
        public string ARCustomerContactAddress2
        {
            get { return _aRCustomerContactAddress2; }
            set
            {
                if (value != this._aRCustomerContactAddress2)
                {
                    _aRCustomerContactAddress2 = value;
                    NotifyChanged("ARCustomerContactAddress2");
                }
            }
        }
        public string ARCustomerContactAssignedTo
        {
            get { return _aRCustomerContactAssignedTo; }
            set
            {
                if (value != this._aRCustomerContactAssignedTo)
                {
                    _aRCustomerContactAssignedTo = value;
                    NotifyChanged("ARCustomerContactAssignedTo");
                }
            }
        }
        public string ARCustomerContactAssistant
        {
            get { return _aRCustomerContactAssistant; }
            set
            {
                if (value != this._aRCustomerContactAssistant)
                {
                    _aRCustomerContactAssistant = value;
                    NotifyChanged("ARCustomerContactAssistant");
                }
            }
        }
        public string ARCustomerContactAssistantPhone
        {
            get { return _aRCustomerContactAssistantPhone; }
            set
            {
                if (value != this._aRCustomerContactAssistantPhone)
                {
                    _aRCustomerContactAssistantPhone = value;
                    NotifyChanged("ARCustomerContactAssistantPhone");
                }
            }
        }
        public string ARCustomerContactCellularPhone
        {
            get { return _aRCustomerContactCellularPhone; }
            set
            {
                if (value != this._aRCustomerContactCellularPhone)
                {
                    _aRCustomerContactCellularPhone = value;
                    NotifyChanged("ARCustomerContactCellularPhone");
                }
            }
        }
        public string ARCustomerContactAddressCity2
        {
            get { return _aRCustomerContactAddressCity2; }
            set
            {
                if (value != this._aRCustomerContactAddressCity2)
                {
                    _aRCustomerContactAddressCity2 = value;
                    NotifyChanged("ARCustomerContactAddressCity2");
                }
            }
        }
        public string ARCustomerContactAddressCountry2
        {
            get { return _aRCustomerContactAddressCountry2; }
            set
            {
                if (value != this._aRCustomerContactAddressCountry2)
                {
                    _aRCustomerContactAddressCountry2 = value;
                    NotifyChanged("ARCustomerContactAddressCountry2");
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
        public string AACreatedUser
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
        public int CreatedUserID
        {
            get { return _createdUserID; }
            set
            {
                if (value != this._createdUserID)
                {
                    _createdUserID = value;
                    NotifyChanged("CreatedUserID");
                }
            }
        }
        public string ARCustomerContactAddressDistrict
        {
            get { return _aRCustomerContactAddressDistrict; }
            set
            {
                if (value != this._aRCustomerContactAddressDistrict)
                {
                    _aRCustomerContactAddressDistrict = value;
                    NotifyChanged("ARCustomerContactAddressDistrict");
                }
            }
        }
        public string ARCustomerContactAddressDistrict2
        {
            get { return _aRCustomerContactAddressDistrict2; }
            set
            {
                if (value != this._aRCustomerContactAddressDistrict2)
                {
                    _aRCustomerContactAddressDistrict2 = value;
                    NotifyChanged("ARCustomerContactAddressDistrict2");
                }
            }
        }
        public int FK_HRGroupID
        {
            get { return _fK_HRGroupID; }
            set
            {
                if (value != this._fK_HRGroupID)
                {
                    _fK_HRGroupID = value;
                    NotifyChanged("FK_HRGroupID");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public string ARCustomerContactHomePhone
        {
            get { return _aRCustomerContactHomePhone; }
            set
            {
                if (value != this._aRCustomerContactHomePhone)
                {
                    _aRCustomerContactHomePhone = value;
                    NotifyChanged("ARCustomerContactHomePhone");
                }
            }
        }
        public byte[] ARCustomerContactImage
        {
            get { return _aRCustomerContactImage; }
            set
            {
                if (value != this._aRCustomerContactImage)
                {
                    _aRCustomerContactImage = value;
                    NotifyChanged("ARCustomerContactImage");
                }
            }
        }
        public string ARCustomerContactJobTitle
        {
            get { return _aRCustomerContactJobTitle; }
            set
            {
                if (value != this._aRCustomerContactJobTitle)
                {
                    _aRCustomerContactJobTitle = value;
                    NotifyChanged("ARCustomerContactJobTitle");
                }
            }
        }
        public string ARCustomerContactPotentialSource
        {
            get { return _aRCustomerContactPotentialSource; }
            set
            {
                if (value != this._aRCustomerContactPotentialSource)
                {
                    _aRCustomerContactPotentialSource = value;
                    NotifyChanged("ARCustomerContactPotentialSource");
                }
            }
        }
        public long REV
        {
            get { return _rEV; }
            set
            {
                if (value != this._rEV)
                {
                    _rEV = value;
                    NotifyChanged("REV");
                }
            }
        }
        public long REVTYPE
        {
            get { return _rEVTYPE; }
            set
            {
                if (value != this._rEVTYPE)
                {
                    _rEVTYPE = value;
                    NotifyChanged("REVTYPE");
                }
            }
        }
        public string ARCustomerContactSecondaryPhone
        {
            get { return _aRCustomerContactSecondaryPhone; }
            set
            {
                if (value != this._aRCustomerContactSecondaryPhone)
                {
                    _aRCustomerContactSecondaryPhone = value;
                    NotifyChanged("ARCustomerContactSecondaryPhone");
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
        public string AAUpdatedUser
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
        public int UpdatedUserID
        {
            get { return _updatedUserID; }
            set
            {
                if (value != this._updatedUserID)
                {
                    _updatedUserID = value;
                    NotifyChanged("UpdatedUserID");
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
        public int FK_GELocationID
        {
            get { return _fK_GELocationID; }
            set
            {
                if (value != this._fK_GELocationID)
                {
                    _fK_GELocationID = value;
                    NotifyChanged("FK_GELocationID");
                }
            }
        }
        public int FK_ARProspectCustomerID
        {
            get { return _fK_ARProspectCustomerID; }
            set
            {
                if (value != this._fK_ARProspectCustomerID)
                {
                    _fK_ARProspectCustomerID = value;
                    NotifyChanged("FK_ARProspectCustomerID");
                }
            }
        }
        public int FK_ARCustomerResourceID
        {
            get { return _fK_ARCustomerResourceID; }
            set
            {
                if (value != this._fK_ARCustomerResourceID)
                {
                    _fK_ARCustomerResourceID = value;
                    NotifyChanged("FK_ARCustomerResourceID");
                }
            }
        }
        public int FK_ADUserGroupID
        {
            get { return _fK_ADUserGroupID; }
            set
            {
                if (value != this._fK_ADUserGroupID)
                {
                    _fK_ADUserGroupID = value;
                    NotifyChanged("FK_ADUserGroupID");
                }
            }
        }
        #endregion
    }
    #endregion
}