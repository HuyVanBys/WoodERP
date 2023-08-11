﻿using BOSLib;
using System;
namespace BOSERP
{
    #region HRSocialInsuranceDeclarationItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRSocialInsuranceDeclarationItemsInfo
    //Created Date:Tuesday, December 24, 2019
    //-----------------------------------------------------------

    public class HRSocialInsuranceDeclarationItemsInfo : BusinessObject
    {
        public HRSocialInsuranceDeclarationItemsInfo()
        {
        }
        #region Variables
        protected int _hRSocialInsuranceDeclarationItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HREmployeeID;
        protected int _fK_HRLevelID;
        protected int _fK_ADInsurrancePlanID;
        protected int _fK_HRSocialInsuranceDeclarationID;
        protected String _hRSocialInsuranceDeclarationItemBHXHNumber = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemBHXHNo = String.Empty;
        protected DateTime _hRSocialInsuranceDeclarationItemEmployeeBirthday = DateTime.MaxValue;
        protected bool _hRSocialInsuranceDeclarationItemIsFemale = true;
        protected decimal _hRSocialInsuranceDeclarationItemMucLuongBHXH;
        protected decimal _hRSocialInsuranceDeclarationItemHeso;
        protected decimal _hRSocialInsuranceDeclarationItemPhucapCV;
        protected decimal _hRSocialInsuranceDeclarationItemThamNienVK;
        protected decimal _hRSocialInsuranceDeclarationItemThamnienNghe;
        protected decimal _hRSocialInsuranceDeclarationItemPhucapLuong;
        protected decimal _hRSocialInsuranceDeclarationItemCacKhoanBoSung;
        protected DateTime _hRSocialInsuranceDeclarationItemDate = DateTime.MaxValue;
        protected DateTime _hRSocialInsuranceDeclarationItemDateTo = DateTime.MaxValue;
        protected String _hRSocialInsuranceDeclarationItemEmployeeContractNo = String.Empty;
        protected String _hREmployeeContractType = String.Empty;
        protected DateTime _hRSocialInsuranceDeclarationItemContractSignDate = DateTime.MaxValue;
        protected decimal _hRSocialInsuranceDeclarationItemTyLeDong;
        protected int _fK_ADInsurranceConditionID;
        protected bool _hRSocialInsuranceDeclarationItemHasDecreased = true;
        protected String _hRSocialInsuranceDeclarationItemTHGiam = String.Empty;
        protected bool _hRSocialInsuranceDeclarationItemNotReturnBHYT = true;
        protected String _hRSocialInsuranceDeclarationItemBHYTNo = String.Empty;
        protected DateTime _hRSocialInsuranceDeclarationItemBHYTReturnDate = DateTime.MaxValue;
        protected bool _hRSocialInsuranceDeclarationItemProposalPayBHAllMonth = true;
        protected int _fK_GEDistrictID;
        protected int _fK_HRDepartmentID;
        protected String _hRSocialInsuranceDeclarationItemContentChange = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemFileRefer = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemBankAccount = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemBankNo = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemBankName = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemBankBranch = String.Empty;
        protected int _fK_GENationalityID;
        protected String _hRSocialInsuranceDeclarationItemEmployeeIDNumber = String.Empty;
        protected DateTime _hRSocialInsuranceDeclarationItemEmployeeIDCardDate = DateTime.MaxValue;
        protected int _fK_GEIDCardStateProvinceID;
        protected String _hRSocialInsuranceDeclarationItemEmployeeTel1 = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemGuardians = String.Empty;
        protected int _fK_GEIDCardStateProvinceID2;
        protected String _hRSocialInsuranceDeclarationItemHospitalNo = String.Empty;
        protected int _fK_GEWardIDKhaiSinh;
        protected int _fK_GEWardIDThuongTru;
        protected String _hRSocialInsuranceDeclarationItemContactAddressThuongTru = String.Empty;
        protected int _fK_GEWardIDLienHe;
        protected String _hRSocialInsuranceDeclarationItemContactAddressLienHe = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemContactPersonCode = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemContactPersonName = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemContactPersonPhone = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemContactPersonNumberBook = String.Empty;
        protected int _fK_ADInsurrancePaperID;
        protected int _fK_GEWardIDChuHo;
        protected String _hRSocialInsuranceDeclarationItemContactAddressChuHo = String.Empty;
        protected decimal _hRSocialInsuranceDeclarationItemMucLuongBHXHOld;
        protected decimal _hRSocialInsuranceDeclarationItemHesoOld;
        protected decimal _hRSocialInsuranceDeclarationItemPhucapCVOld;
        protected decimal _hRSocialInsuranceDeclarationItemThamNienVKOld;
        protected decimal _hRSocialInsuranceDeclarationItemThamnienNgheOld;
        protected decimal _hRSocialInsuranceDeclarationItemPhucapLuongOld;
        protected decimal _hRSocialInsuranceDeclarationItemCacKhoanBoSungOld;
        protected decimal _hRSocialInsuranceDeclarationItemPCChenhLechOld;
        protected String _hRSocialInsuranceDeclarationItemEmail = String.Empty;
        protected String _hRSocialInsuranceDeclarationItemGuardiansOther = String.Empty;
        protected int _fK_GECountryID;
        protected String _hRSocialInsuranceDeclarationItemObject = String.Empty;
        protected DateTime _hRSocialInsuranceDeclarationItemLostDay = DateTime.MaxValue;

        #endregion

        #region Public properties
        public int HRSocialInsuranceDeclarationItemID
        {
            get { return _hRSocialInsuranceDeclarationItemID; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemID)
                {
                    _hRSocialInsuranceDeclarationItemID = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemID");
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
        public int FK_HRLevelID
        {
            get { return _fK_HRLevelID; }
            set
            {
                if (value != this._fK_HRLevelID)
                {
                    _fK_HRLevelID = value;
                    NotifyChanged("FK_HRLevelID");
                }
            }
        }
        public int FK_ADInsurrancePlanID
        {
            get { return _fK_ADInsurrancePlanID; }
            set
            {
                if (value != this._fK_ADInsurrancePlanID)
                {
                    _fK_ADInsurrancePlanID = value;
                    NotifyChanged("FK_ADInsurrancePlanID");
                }
            }
        }
        public int FK_HRSocialInsuranceDeclarationID
        {
            get { return _fK_HRSocialInsuranceDeclarationID; }
            set
            {
                if (value != this._fK_HRSocialInsuranceDeclarationID)
                {
                    _fK_HRSocialInsuranceDeclarationID = value;
                    NotifyChanged("FK_HRSocialInsuranceDeclarationID");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBHXHNumber
        {
            get { return _hRSocialInsuranceDeclarationItemBHXHNumber; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBHXHNumber)
                {
                    _hRSocialInsuranceDeclarationItemBHXHNumber = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBHXHNumber");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBHXHNo
        {
            get { return _hRSocialInsuranceDeclarationItemBHXHNo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBHXHNo)
                {
                    _hRSocialInsuranceDeclarationItemBHXHNo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBHXHNo");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemEmployeeBirthday
        {
            get { return _hRSocialInsuranceDeclarationItemEmployeeBirthday; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemEmployeeBirthday)
                {
                    _hRSocialInsuranceDeclarationItemEmployeeBirthday = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemEmployeeBirthday");
                }
            }
        }
        public bool HRSocialInsuranceDeclarationItemIsFemale
        {
            get { return _hRSocialInsuranceDeclarationItemIsFemale; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemIsFemale)
                {
                    _hRSocialInsuranceDeclarationItemIsFemale = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemIsFemale");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemMucLuongBHXH
        {
            get { return _hRSocialInsuranceDeclarationItemMucLuongBHXH; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemMucLuongBHXH)
                {
                    _hRSocialInsuranceDeclarationItemMucLuongBHXH = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemMucLuongBHXH");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemHeso
        {
            get { return _hRSocialInsuranceDeclarationItemHeso; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemHeso)
                {
                    _hRSocialInsuranceDeclarationItemHeso = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemHeso");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemPhucapCV
        {
            get { return _hRSocialInsuranceDeclarationItemPhucapCV; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemPhucapCV)
                {
                    _hRSocialInsuranceDeclarationItemPhucapCV = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemPhucapCV");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemThamNienVK
        {
            get { return _hRSocialInsuranceDeclarationItemThamNienVK; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemThamNienVK)
                {
                    _hRSocialInsuranceDeclarationItemThamNienVK = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemThamNienVK");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemThamnienNghe
        {
            get { return _hRSocialInsuranceDeclarationItemThamnienNghe; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemThamnienNghe)
                {
                    _hRSocialInsuranceDeclarationItemThamnienNghe = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemThamnienNghe");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemPhucapLuong
        {
            get { return _hRSocialInsuranceDeclarationItemPhucapLuong; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemPhucapLuong)
                {
                    _hRSocialInsuranceDeclarationItemPhucapLuong = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemPhucapLuong");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemCacKhoanBoSung
        {
            get { return _hRSocialInsuranceDeclarationItemCacKhoanBoSung; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemCacKhoanBoSung)
                {
                    _hRSocialInsuranceDeclarationItemCacKhoanBoSung = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemCacKhoanBoSung");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemDate
        {
            get { return _hRSocialInsuranceDeclarationItemDate; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemDate)
                {
                    _hRSocialInsuranceDeclarationItemDate = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemDate");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemDateTo
        {
            get { return _hRSocialInsuranceDeclarationItemDateTo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemDateTo)
                {
                    _hRSocialInsuranceDeclarationItemDateTo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemDateTo");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemEmployeeContractNo
        {
            get { return _hRSocialInsuranceDeclarationItemEmployeeContractNo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemEmployeeContractNo)
                {
                    _hRSocialInsuranceDeclarationItemEmployeeContractNo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemEmployeeContractNo");
                }
            }
        }
        public String HREmployeeContractType
        {
            get { return _hREmployeeContractType; }
            set
            {
                if (value != this._hREmployeeContractType)
                {
                    _hREmployeeContractType = value;
                    NotifyChanged("HREmployeeContractType");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemContractSignDate
        {
            get { return _hRSocialInsuranceDeclarationItemContractSignDate; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContractSignDate)
                {
                    _hRSocialInsuranceDeclarationItemContractSignDate = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContractSignDate");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemTyLeDong
        {
            get { return _hRSocialInsuranceDeclarationItemTyLeDong; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemTyLeDong)
                {
                    _hRSocialInsuranceDeclarationItemTyLeDong = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemTyLeDong");
                }
            }
        }
        public int FK_ADInsurranceConditionID
        {
            get { return _fK_ADInsurranceConditionID; }
            set
            {
                if (value != this._fK_ADInsurranceConditionID)
                {
                    _fK_ADInsurranceConditionID = value;
                    NotifyChanged("FK_ADInsurranceConditionID");
                }
            }
        }
        public bool HRSocialInsuranceDeclarationItemHasDecreased
        {
            get { return _hRSocialInsuranceDeclarationItemHasDecreased; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemHasDecreased)
                {
                    _hRSocialInsuranceDeclarationItemHasDecreased = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemHasDecreased");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemTHGiam
        {
            get { return _hRSocialInsuranceDeclarationItemTHGiam; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemTHGiam)
                {
                    _hRSocialInsuranceDeclarationItemTHGiam = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemTHGiam");
                }
            }
        }
        public bool HRSocialInsuranceDeclarationItemNotReturnBHYT
        {
            get { return _hRSocialInsuranceDeclarationItemNotReturnBHYT; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemNotReturnBHYT)
                {
                    _hRSocialInsuranceDeclarationItemNotReturnBHYT = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemNotReturnBHYT");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBHYTNo
        {
            get { return _hRSocialInsuranceDeclarationItemBHYTNo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBHYTNo)
                {
                    _hRSocialInsuranceDeclarationItemBHYTNo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBHYTNo");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemBHYTReturnDate
        {
            get { return _hRSocialInsuranceDeclarationItemBHYTReturnDate; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBHYTReturnDate)
                {
                    _hRSocialInsuranceDeclarationItemBHYTReturnDate = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBHYTReturnDate");
                }
            }
        }
        public bool HRSocialInsuranceDeclarationItemProposalPayBHAllMonth
        {
            get { return _hRSocialInsuranceDeclarationItemProposalPayBHAllMonth; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemProposalPayBHAllMonth)
                {
                    _hRSocialInsuranceDeclarationItemProposalPayBHAllMonth = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemProposalPayBHAllMonth");
                }
            }
        }
        public int FK_GEDistrictID
        {
            get { return _fK_GEDistrictID; }
            set
            {
                if (value != this._fK_GEDistrictID)
                {
                    _fK_GEDistrictID = value;
                    NotifyChanged("FK_GEDistrictID");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContentChange
        {
            get { return _hRSocialInsuranceDeclarationItemContentChange; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContentChange)
                {
                    _hRSocialInsuranceDeclarationItemContentChange = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContentChange");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemFileRefer
        {
            get { return _hRSocialInsuranceDeclarationItemFileRefer; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemFileRefer)
                {
                    _hRSocialInsuranceDeclarationItemFileRefer = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemFileRefer");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBankAccount
        {
            get { return _hRSocialInsuranceDeclarationItemBankAccount; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBankAccount)
                {
                    _hRSocialInsuranceDeclarationItemBankAccount = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBankAccount");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBankNo
        {
            get { return _hRSocialInsuranceDeclarationItemBankNo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBankNo)
                {
                    _hRSocialInsuranceDeclarationItemBankNo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBankNo");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBankName
        {
            get { return _hRSocialInsuranceDeclarationItemBankName; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBankName)
                {
                    _hRSocialInsuranceDeclarationItemBankName = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBankName");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemBankBranch
        {
            get { return _hRSocialInsuranceDeclarationItemBankBranch; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemBankBranch)
                {
                    _hRSocialInsuranceDeclarationItemBankBranch = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemBankBranch");
                }
            }
        }
        public int FK_GENationalityID
        {
            get { return _fK_GENationalityID; }
            set
            {
                if (value != this._fK_GENationalityID)
                {
                    _fK_GENationalityID = value;
                    NotifyChanged("FK_GENationalityID");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemEmployeeIDNumber
        {
            get { return _hRSocialInsuranceDeclarationItemEmployeeIDNumber; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemEmployeeIDNumber)
                {
                    _hRSocialInsuranceDeclarationItemEmployeeIDNumber = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemEmployeeIDNumber");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemEmployeeIDCardDate
        {
            get { return _hRSocialInsuranceDeclarationItemEmployeeIDCardDate; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemEmployeeIDCardDate)
                {
                    _hRSocialInsuranceDeclarationItemEmployeeIDCardDate = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemEmployeeIDCardDate");
                }
            }
        }
        public int FK_GEIDCardStateProvinceID
        {
            get { return _fK_GEIDCardStateProvinceID; }
            set
            {
                if (value != this._fK_GEIDCardStateProvinceID)
                {
                    _fK_GEIDCardStateProvinceID = value;
                    NotifyChanged("FK_GEIDCardStateProvinceID");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemEmployeeTel1
        {
            get { return _hRSocialInsuranceDeclarationItemEmployeeTel1; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemEmployeeTel1)
                {
                    _hRSocialInsuranceDeclarationItemEmployeeTel1 = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemEmployeeTel1");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemGuardians
        {
            get { return _hRSocialInsuranceDeclarationItemGuardians; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemGuardians)
                {
                    _hRSocialInsuranceDeclarationItemGuardians = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemGuardians");
                }
            }
        }
        public int FK_GEIDCardStateProvinceID2
        {
            get { return _fK_GEIDCardStateProvinceID2; }
            set
            {
                if (value != this._fK_GEIDCardStateProvinceID2)
                {
                    _fK_GEIDCardStateProvinceID2 = value;
                    NotifyChanged("FK_GEIDCardStateProvinceID2");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemHospitalNo
        {
            get { return _hRSocialInsuranceDeclarationItemHospitalNo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemHospitalNo)
                {
                    _hRSocialInsuranceDeclarationItemHospitalNo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemHospitalNo");
                }
            }
        }
        public int FK_GEWardIDKhaiSinh
        {
            get { return _fK_GEWardIDKhaiSinh; }
            set
            {
                if (value != this._fK_GEWardIDKhaiSinh)
                {
                    _fK_GEWardIDKhaiSinh = value;
                    NotifyChanged("FK_GEWardIDKhaiSinh");
                }
            }
        }
        public int FK_GEWardIDThuongTru
        {
            get { return _fK_GEWardIDThuongTru; }
            set
            {
                if (value != this._fK_GEWardIDThuongTru)
                {
                    _fK_GEWardIDThuongTru = value;
                    NotifyChanged("FK_GEWardIDThuongTru");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactAddressThuongTru
        {
            get { return _hRSocialInsuranceDeclarationItemContactAddressThuongTru; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactAddressThuongTru)
                {
                    _hRSocialInsuranceDeclarationItemContactAddressThuongTru = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactAddressThuongTru");
                }
            }
        }
        public int FK_GEWardIDLienHe
        {
            get { return _fK_GEWardIDLienHe; }
            set
            {
                if (value != this._fK_GEWardIDLienHe)
                {
                    _fK_GEWardIDLienHe = value;
                    NotifyChanged("FK_GEWardIDLienHe");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactAddressLienHe
        {
            get { return _hRSocialInsuranceDeclarationItemContactAddressLienHe; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactAddressLienHe)
                {
                    _hRSocialInsuranceDeclarationItemContactAddressLienHe = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactAddressLienHe");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactPersonCode
        {
            get { return _hRSocialInsuranceDeclarationItemContactPersonCode; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactPersonCode)
                {
                    _hRSocialInsuranceDeclarationItemContactPersonCode = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactPersonCode");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactPersonName
        {
            get { return _hRSocialInsuranceDeclarationItemContactPersonName; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactPersonName)
                {
                    _hRSocialInsuranceDeclarationItemContactPersonName = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactPersonName");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactPersonPhone
        {
            get { return _hRSocialInsuranceDeclarationItemContactPersonPhone; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactPersonPhone)
                {
                    _hRSocialInsuranceDeclarationItemContactPersonPhone = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactPersonPhone");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactPersonNumberBook
        {
            get { return _hRSocialInsuranceDeclarationItemContactPersonNumberBook; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactPersonNumberBook)
                {
                    _hRSocialInsuranceDeclarationItemContactPersonNumberBook = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactPersonNumberBook");
                }
            }
        }
        public int FK_ADInsurrancePaperID
        {
            get { return _fK_ADInsurrancePaperID; }
            set
            {
                if (value != this._fK_ADInsurrancePaperID)
                {
                    _fK_ADInsurrancePaperID = value;
                    NotifyChanged("FK_ADInsurrancePaperID");
                }
            }
        }
        public int FK_GEWardIDChuHo
        {
            get { return _fK_GEWardIDChuHo; }
            set
            {
                if (value != this._fK_GEWardIDChuHo)
                {
                    _fK_GEWardIDChuHo = value;
                    NotifyChanged("FK_GEWardIDChuHo");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemContactAddressChuHo
        {
            get { return _hRSocialInsuranceDeclarationItemContactAddressChuHo; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemContactAddressChuHo)
                {
                    _hRSocialInsuranceDeclarationItemContactAddressChuHo = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemContactAddressChuHo");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemMucLuongBHXHOld
        {
            get { return _hRSocialInsuranceDeclarationItemMucLuongBHXHOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemMucLuongBHXHOld)
                {
                    _hRSocialInsuranceDeclarationItemMucLuongBHXHOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemMucLuongBHXHOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemHesoOld
        {
            get { return _hRSocialInsuranceDeclarationItemHesoOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemHesoOld)
                {
                    _hRSocialInsuranceDeclarationItemHesoOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemHesoOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemPhucapCVOld
        {
            get { return _hRSocialInsuranceDeclarationItemPhucapCVOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemPhucapCVOld)
                {
                    _hRSocialInsuranceDeclarationItemPhucapCVOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemPhucapCVOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemThamNienVKOld
        {
            get { return _hRSocialInsuranceDeclarationItemThamNienVKOld; }
            set
            {
                if (value != this.HRSocialInsuranceDeclarationItemThamNienVKOld)
                {
                    _hRSocialInsuranceDeclarationItemThamNienVKOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemThamNienVKOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemThamnienNgheOld
        {
            get { return _hRSocialInsuranceDeclarationItemThamnienNgheOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemThamnienNgheOld)
                {
                    _hRSocialInsuranceDeclarationItemThamnienNgheOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemThamnienNgheOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemPhucapLuongOld
        {
            get { return _hRSocialInsuranceDeclarationItemPhucapLuongOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemPhucapLuongOld)
                {
                    _hRSocialInsuranceDeclarationItemPhucapLuongOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemPhucapLuongOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemCacKhoanBoSungOld
        {
            get { return _hRSocialInsuranceDeclarationItemCacKhoanBoSungOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemCacKhoanBoSungOld)
                {
                    _hRSocialInsuranceDeclarationItemCacKhoanBoSungOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemCacKhoanBoSungOld");
                }
            }
        }
        public decimal HRSocialInsuranceDeclarationItemPCChenhLechOld
        {
            get { return _hRSocialInsuranceDeclarationItemPCChenhLechOld; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemPCChenhLechOld)
                {
                    _hRSocialInsuranceDeclarationItemPCChenhLechOld = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemPCChenhLechOld");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemEmail
        {
            get { return _hRSocialInsuranceDeclarationItemEmail; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemEmail)
                {
                    _hRSocialInsuranceDeclarationItemEmail = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemEmail");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemGuardiansOther
        {
            get { return _hRSocialInsuranceDeclarationItemGuardiansOther; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemGuardiansOther)
                {
                    _hRSocialInsuranceDeclarationItemGuardiansOther = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemGuardiansOther");
                }
            }
        }
        public int FK_GECountryID
        {
            get { return _fK_GECountryID; }
            set
            {
                if (value != this._fK_GECountryID)
                {
                    _fK_GECountryID = value;
                    NotifyChanged("FK_GECountryID");
                }
            }
        }
        public String HRSocialInsuranceDeclarationItemObject
        {
            get { return _hRSocialInsuranceDeclarationItemObject; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemObject)
                {
                    _hRSocialInsuranceDeclarationItemObject = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemObject");
                }
            }
        }
        public DateTime HRSocialInsuranceDeclarationItemLostDay
        {
            get { return _hRSocialInsuranceDeclarationItemLostDay; }
            set
            {
                if (value != this._hRSocialInsuranceDeclarationItemLostDay)
                {
                    _hRSocialInsuranceDeclarationItemLostDay = value;
                    NotifyChanged("HRSocialInsuranceDeclarationItemLostDay");
                }
            }
        }

        #endregion
    }
    #endregion
}