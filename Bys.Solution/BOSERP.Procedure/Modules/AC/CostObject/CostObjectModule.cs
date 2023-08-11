using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CostObject
{
    public class CostObjectModule : BaseModuleERP
    {
        #region Constants
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion
        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion
        public CostObjectModule()
        {
            Name = ModuleName.CostObject;
            CurrentModuleEntity = new CostObjectEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CostObjectModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
            ACCostObjectsInfo searchObject = (ACCostObjectsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objCostObjectsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objCostObjectsController.GetCostObjectListByListOfBranchID(
                                                                                searchObject.ACCostObjectNo,
                                                                                searchObject.ACCostObjectName,
                                                                                BranchList);
                }
            }
            else
            {
                ds = objCostObjectsController.GetCostObjectList(
                                                                   searchObject.ACCostObjectNo,
                                                                   searchObject.ACCostObjectName,
                                                                   searchObject.FK_BRBranchID);
            }
            return ds;

        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        public void ResetAllocationMonthAmount()
        {
            CostObjectEntities entity = (CostObjectEntities)CurrentModuleEntity;
            ACCostObjectItemsInfo item = entity.CostObjectItemList[entity.CostObjectItemList.CurrentIndex];
            if (item.ACCostObjectItemAllocationMonths != 0)
                item.ACCostObjectItemAllocationMonthAmount = Math.Round(item.ACCostObjectItemTotalAmount / item.ACCostObjectItemAllocationMonths);
            else
                item.ACCostObjectItemAllocationMonthAmount = 0;
            entity.CostObjectItemList.GridControl.RefreshDataSource();
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            CostObjectEntities entity = (CostObjectEntities)CurrentModuleEntity;
            string CostObjectItemNoIsAllocated = "";
            entity.CostObjectItemList.ForEach(p =>
            {
                if (p.ACCostObjectItemIsAllocated)
                    CostObjectItemNoIsAllocated += p.ACCostObjectItemRefNo + "; ";
            });

            if (!String.IsNullOrEmpty(CostObjectItemNoIsAllocated))
            {
                MessageBox.Show("Các chứng từ " + CostObjectItemNoIsAllocated.Substring(0, CostObjectItemNoIsAllocated.Length - 2) + " đã được chạy phân bổ!",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
        public override void ActionDuplicate()
        {
            CostObjectEntities entity = (CostObjectEntities)CurrentModuleEntity;
            ACCostObjectsInfo mainObject = (ACCostObjectsInfo)entity.MainObject;
            base.ActionDuplicate();

            mainObject.AAUpdatedDate = DateTime.MaxValue;
            mainObject.AAUpdatedUser = String.Empty;
        }
    }
}
