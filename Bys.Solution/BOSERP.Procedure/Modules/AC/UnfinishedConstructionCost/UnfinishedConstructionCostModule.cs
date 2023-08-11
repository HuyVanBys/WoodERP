﻿using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Modules.AC.UnfinishedConstructionCost.Localization;
using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.UnfinishedConstructionCost
{
    #region UnfinishedConstructionCostModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:UnfinishedConstructionCostModule
    //Created Date:Thursday, April 26, 2018
    //-----------------------------------------------------------

    public class UnfinishedConstructionCostModule : BaseModuleERP
    {
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        public UnfinishedConstructionCostModule()
        {
            Name = "UnfinishedConstructionCost";
            CurrentModuleEntity = new UnfinishedConstructionCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
        }

        public override int ActionSave()
        {
            UnfinishedConstructionCostEntities entity = (UnfinishedConstructionCostEntities)CurrentModuleEntity;
            ACUnfinishedConstructionCostsInfo mainObject = (ACUnfinishedConstructionCostsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(mainObject.ACUnfinishedConstructionCostName))
            {
                MessageBox.Show(UnfinishedConstructionCostLocalizedResources.ACUnfinishedConstructionCostNameRequired, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            if (mainObject.FK_ACAccountID == 0)
            {
                MessageBox.Show(UnfinishedConstructionCostLocalizedResources.ACAccountIDRequired, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            return base.ActionSave();
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            UnfinishedConstructionCostEntities entity = (UnfinishedConstructionCostEntities)CurrentModuleEntity;
            ACUnfinishedConstructionCostsInfo mainObject = (ACUnfinishedConstructionCostsInfo)entity.MainObject;
            if (mainObject.ACUnfinishedConstructionCostID > 0)
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            if (mainObject.ACUnfinishedConstructionCostStatus == UnfinishedConstructionCostStatus.Complete.ToString())
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
        }
    }
    #endregion
}