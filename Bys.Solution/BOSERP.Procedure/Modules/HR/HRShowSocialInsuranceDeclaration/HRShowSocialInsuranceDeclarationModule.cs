using BOSCommon;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.HRShowSocialInsuranceDeclaration
{
    public class HRShowSocialInsuranceDeclarationModule : BaseModuleERP
    {
        #region Constants
        public const string LeaveDayGridControlName = "fld_dgcLeaveDays";
        public const string BranchLookupEditName = "fld_lkeBRBranchID";
        public const string MonthBHXHEditName = "fld_dteMonthBHXH";
        public const string SocialInsuranceDeclarationStatusLookupEditName = "fld_lkeHRSocialInsuranceDeclarationStatus";
        #endregion

        public HRShowSocialInsuranceDeclarationModule()
        {
            Name = "HRShowSocialInsuranceDeclaration";
            CurrentModuleEntity = new HRShowSocialInsuranceDeclarationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            BOSLookupEdit lke = (BOSLookupEdit)Controls[HRShowSocialInsuranceDeclarationModule.BranchLookupEditName];
            lke.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            lke = (BOSLookupEdit)Controls[HRShowSocialInsuranceDeclarationModule.SocialInsuranceDeclarationStatusLookupEditName];
            if (lke != null)
            {
                lke.EditValue = SocialInsuranceDeclarationStatus.New;
            }

            BOSDateEdit dateEdit = (BOSDateEdit)Controls[HRShowSocialInsuranceDeclarationModule.MonthBHXHEditName];
            if (dateEdit != null)
            {
                dateEdit.EditValue = BOSApp.GetCurrentServerDate();
            }
        }

        public void ViewSocialInsuranceDeclarations(string status, DateTime month)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> list = objEmployeesController.GetEmployeeListBySocialInsuranceDeclaration(month, status);
            HRShowSocialInsuranceDeclarationEntities entity = (HRShowSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            entity.EmployeeList.Invalidate(list);
        }

        public void ViewSocialInsuranceDeclarations(int employeeID, string status)
        {
            HRSocialInsuranceDeclarationsController objSocialInsuranceDeclarationsController = new HRSocialInsuranceDeclarationsController();
            List<HRSocialInsuranceDeclarationsInfo> list = objSocialInsuranceDeclarationsController.GetSocialInsuranceDeclarationListForShow(employeeID, status);
            HRShowSocialInsuranceDeclarationEntities entity = (HRShowSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            entity.SocialInsuranceDeclarationList.Invalidate(list);
            entity.SocialInsuranceDeclarationList.GridControl.RefreshDataSource();
        }

        public void NewSocialInsuranceDeclarations(string status)
        {
            HRShowSocialInsuranceDeclarationEntities entity = (HRShowSocialInsuranceDeclarationEntities)CurrentModuleEntity;

            List<HREmployeesInfo> list = entity.EmployeeList.Where(o => o.Selected).ToList();
            if (list.Count() > 0)
            {
                if (status == ShowSocialInsuranceDeclarationType.Eligible.ToString()
                    || status == ShowSocialInsuranceDeclarationType.New.ToString())
                {
                    BaseModuleERP socialInsuranceDeclarationModule = BaseModuleFactory.GetModule("HRSocialInsuranceDeclaration");
                    if (socialInsuranceDeclarationModule != null)
                    {
                        socialInsuranceDeclarationModule = BOSApp.ShowModule("HRSocialInsuranceDeclaration");
                        socialInsuranceDeclarationModule.CallFunctionFromAnotherProject(list, SocialInsuranceDeclarationType.Increase.ToString());
                    }
                }
                else if (status == ShowSocialInsuranceDeclarationType.Unqualified.ToString())
                {
                    BaseModuleERP socialInsuranceDeclarationModule = BaseModuleFactory.GetModule("HRSocialInsuranceDeclaration");
                    if (socialInsuranceDeclarationModule != null)
                    {
                        socialInsuranceDeclarationModule = BOSApp.ShowModule("HRSocialInsuranceDeclaration");
                        socialInsuranceDeclarationModule.CallFunctionFromAnotherProject(list, SocialInsuranceDeclarationType.Reduction.ToString());
                    }
                }
            }
        }
    }
}
