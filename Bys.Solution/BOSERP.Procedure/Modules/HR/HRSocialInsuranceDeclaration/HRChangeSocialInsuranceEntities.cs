using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.HRSocialInsuranceDeclaration
{
    public class HRSocialInsuranceDeclarationEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the time sheet entry list
        /// </summary>
        public BOSList<HRSocialInsuranceDeclarationItemsInfo> SocialInsuranceDeclarationItemList { get; set; }
        public BOSList<HRSocialInsuranceDeclarationItemsInfo> IncreaseSocialInsuranceDeclarationItemList { get; set; }
        public BOSList<HRSocialInsuranceDeclarationItemsInfo> ReductionSocialInsuranceDeclarationItemList { get; set; }
        public BOSList<HRSocialInsuranceDeclarationItemsInfo> ArrearsSocialInsuranceDeclarationItemList { get; set; }
        #endregion

        #region Constructor
        public HRSocialInsuranceDeclarationEntities()
            : base()
        {
            SocialInsuranceDeclarationItemList = new BOSList<HRSocialInsuranceDeclarationItemsInfo>();
            IncreaseSocialInsuranceDeclarationItemList = new BOSList<HRSocialInsuranceDeclarationItemsInfo>();
            ReductionSocialInsuranceDeclarationItemList = new BOSList<HRSocialInsuranceDeclarationItemsInfo>();
            ArrearsSocialInsuranceDeclarationItemList = new BOSList<HRSocialInsuranceDeclarationItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRSocialInsuranceDeclarationsInfo();
            SearchObject = new HRSocialInsuranceDeclarationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRSocialInsuranceDeclarationItemsTableName, new HRSocialInsuranceDeclarationItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            SocialInsuranceDeclarationItemList.InitBOSList(
                                             this,
                                             TableName.HRSocialInsuranceDeclarationsTableName,
                                             TableName.HRSocialInsuranceDeclarationItemsTableName,
                                             BOSList<HRSocialInsuranceDeclarationItemsInfo>.cstRelationForeign);
            SocialInsuranceDeclarationItemList.ItemTableForeignKey = "FK_HRSocialInsuranceDeclarationID";

            IncreaseSocialInsuranceDeclarationItemList.InitBOSList(
                                             this,
                                             TableName.HRSocialInsuranceDeclarationsTableName,
                                             TableName.HRSocialInsuranceDeclarationItemsTableName,
                                             BOSList<HRSocialInsuranceDeclarationItemsInfo>.cstRelationForeign);
            IncreaseSocialInsuranceDeclarationItemList.ItemTableForeignKey = "FK_HRSocialInsuranceDeclarationID";

            ReductionSocialInsuranceDeclarationItemList.InitBOSList(
                                             this,
                                             TableName.HRSocialInsuranceDeclarationsTableName,
                                             TableName.HRSocialInsuranceDeclarationItemsTableName,
                                             BOSList<HRSocialInsuranceDeclarationItemsInfo>.cstRelationForeign);
            ReductionSocialInsuranceDeclarationItemList.ItemTableForeignKey = "FK_HRSocialInsuranceDeclarationID";

            ArrearsSocialInsuranceDeclarationItemList.InitBOSList(
                                             this,
                                             TableName.HRSocialInsuranceDeclarationsTableName,
                                             TableName.HRSocialInsuranceDeclarationItemsTableName,
                                             BOSList<HRSocialInsuranceDeclarationItemsInfo>.cstRelationForeign);
            ArrearsSocialInsuranceDeclarationItemList.ItemTableForeignKey = "FK_HRSocialInsuranceDeclarationID";
        }

        public override void InitGridControlInBOSList()
        {
            //SocialInsuranceDeclarationItemList.InitBOSListGridControl();
            IncreaseSocialInsuranceDeclarationItemList.InitBOSListGridControl("fld_dgcHRSocialInsuranceDeclarationItemIncreases");
            ReductionSocialInsuranceDeclarationItemList.InitBOSListGridControl("fld_dgcHRSocialInsuranceDeclarationItemReductions");
            ArrearsSocialInsuranceDeclarationItemList.InitBOSListGridControl("fld_dgcHRSocialInsuranceDeclarationItemArrears");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo = (HRSocialInsuranceDeclarationsInfo)MainObject;
            objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationDate = BOSApp.GetCurrentServerDate();
            objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationStatus = SocialInsuranceDeclarationStatus.New.ToString();
            objSocialInsuranceDeclarationsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                IncreaseSocialInsuranceDeclarationItemList.SetDefaultListAndRefreshGridControl();
                ReductionSocialInsuranceDeclarationItemList.SetDefaultListAndRefreshGridControl();
                ArrearsSocialInsuranceDeclarationItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            SocialInsuranceDeclarationItemList.Invalidate(iObjectID);
            IncreaseSocialInsuranceDeclarationItemList.Invalidate(SocialInsuranceDeclarationItemList);
            ReductionSocialInsuranceDeclarationItemList.Invalidate(SocialInsuranceDeclarationItemList);
            ArrearsSocialInsuranceDeclarationItemList.Invalidate(SocialInsuranceDeclarationItemList);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo = (HRSocialInsuranceDeclarationsInfo)MainObject;
            if (objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Increase.ToString())
            {
                SocialInsuranceDeclarationItemList.Invalidate(IncreaseSocialInsuranceDeclarationItemList);
            }
            else if (objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Reduction.ToString())
            {
                SocialInsuranceDeclarationItemList.Invalidate(ReductionSocialInsuranceDeclarationItemList);
            }
            else if (objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Arrears.ToString())
            {
                SocialInsuranceDeclarationItemList.Invalidate(ArrearsSocialInsuranceDeclarationItemList);
            }

            SocialInsuranceDeclarationItemList.SaveItemObjects();
        }

        public HRSocialInsuranceDeclarationItemsInfo GenerateSocialInsuranceDeclarationItem(HREmployeesInfo objEmployeesInfo, HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo)
        {
            HREmployeeContractsController objEmployeeContractsController = new HREmployeeContractsController();
            HREmployeeContractsInfo objEmployeeContractsInfo = objEmployeeContractsController.GetEmployeeContractLastByEmployeeID(objEmployeesInfo.HREmployeeID);

            HREmployeeContactPersonsController objEmployeeContactPersonsController = new HREmployeeContactPersonsController();
            HREmployeeContactPersonsInfo objEmployeeContactPersonsInfo = new HREmployeeContactPersonsInfo();
            objEmployeeContactPersonsInfo = objEmployeeContactPersonsController.GetEmployeeHeadHouseholdByEmployeeID(objEmployeesInfo.HREmployeeID);

            HREmployeeContactsController objEmployeeContactsController = new HREmployeeContactsController();
            List<HREmployeeContactsInfo> list = objEmployeeContactsController.GetListAddressByEmployeeID(objEmployeesInfo.HREmployeeID);
            HREmployeeContactsInfo objEmployeeContactsInfo = new HREmployeeContactsInfo();

            HRSocialInsuranceDeclarationItemsInfo objSocialInsuranceDeclarationItemsInfo = new HRSocialInsuranceDeclarationItemsInfo();

            objSocialInsuranceDeclarationItemsInfo.FK_HRLevelID = objEmployeesInfo.FK_HRLevelID;
            objSocialInsuranceDeclarationItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemBHXHNumber = objEmployeesInfo.HREmployeeSocialInsNo;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemBHXHNo = objEmployeesInfo.HREmployeeSocialInsNo;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeBirthday = objEmployeesInfo.HREmployeeDob;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemIsFemale = false;
            if (objEmployeesInfo.HREmployeeGenderCombo == EmployeeGender.Female.ToString())
            {
                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemIsFemale = true;
            }

            if (list.Count() > 0)
            {
                objEmployeeContactsInfo = list.LastOrDefault(o => o.HREmployeeContactTypeCombo == EmployeeContactType.DiaChiThuongTru.ToString());
                if (objEmployeeContactsInfo != null)
                {
                    objSocialInsuranceDeclarationItemsInfo.FK_GEWardIDThuongTru = objEmployeeContactsInfo.FK_GEWardID;
                    objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactAddressThuongTru = objEmployeeContactsInfo.HREmployeeContactAddress;
                }

                objEmployeeContactsInfo = new HREmployeeContactsInfo();
                objEmployeeContactsInfo = list.LastOrDefault(o => o.HREmployeeContactTypeCombo == EmployeeContactType.DiaChiLienHe.ToString());
                if (objEmployeeContactsInfo != null)
                {
                    objSocialInsuranceDeclarationItemsInfo.FK_GEWardIDLienHe = objEmployeeContactsInfo.FK_GEWardID;
                    objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactAddressLienHe = objEmployeeContactsInfo.HREmployeeContactAddress;
                }
            }

            if (objEmployeeContactPersonsInfo != null && string.IsNullOrEmpty(objEmployeesInfo.HREmployeeSocialInsNo))
            {
                //objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactPersonNumberBook = objEmployeeContactPersonsInfo.HREmployeeContactPersonNumberBook;
                //objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactPersonCode = objEmployeeContactPersonsInfo.HREmployeeContactPersonCode;
                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactPersonName = objEmployeeContactPersonsInfo.HREmployeeContactPersonName;
                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactPersonPhone = objEmployeeContactPersonsInfo.HREmployeeContactPersonPhone;
                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContactAddressChuHo = objEmployeeContactPersonsInfo.HREmployeeContactPersonAddressStreet;
            }

            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemMucLuongBHXH = objEmployeesInfo.HREmployeeSalarySocialInsurance;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemMucLuongBHXHOld = objEmployeesInfo.HREmployeeSalarySocialInsurance;
            objSocialInsuranceDeclarationItemsInfo.FK_GENationalityID = objEmployeesInfo.FK_GENationalityID;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmail = objEmployeesInfo.HREmployeeEmail1;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeIDCardDate = objEmployeesInfo.HREmployeeIDCardDate;
            objSocialInsuranceDeclarationItemsInfo.FK_GEIDCardStateProvinceID = objEmployeesInfo.FK_GEIDCardStateProvinceID;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeIDNumber = objEmployeesInfo.HREmployeeIDNumber;
            //objSocialInsuranceDeclarationItemsInfo.FK_GECountryID = objEmployeesInfo.FK_GECountryID;
            objSocialInsuranceDeclarationItemsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;

            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeContractNo = objEmployeesInfo.HREmployeeNo;
            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeTel1 = objEmployeesInfo.HREmployeeTel2;

            if (objEmployeeContractsInfo != null)
            {
                //objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeContractNo = objEmployeeContractsInfo.HREmployeeContractNo;
                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContractSignDate = objEmployeeContractsInfo.HREmployeeContractSignDate;
                objSocialInsuranceDeclarationItemsInfo.HREmployeeContractType = objEmployeeContractsInfo.HREmployeeContractType;
            }

            if (objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Reduction.ToString())
            {
                //objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemEmployeeContractNo = string.Empty;
                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemContractSignDate = DateTime.MaxValue;
                objSocialInsuranceDeclarationItemsInfo.HREmployeeContractType = string.Empty;
            }

            return objSocialInsuranceDeclarationItemsInfo;
        }
        #endregion 
    }
}