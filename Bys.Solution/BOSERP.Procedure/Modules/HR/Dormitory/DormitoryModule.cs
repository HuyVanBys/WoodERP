using BOSCommon.Constants;
using BOSComponent;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Dormitory
{
    public class DormitoryModule : BaseTransactionModule
    {
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        public DormitoryModule()
        {
            Name = "Dormitory";
            CurrentModuleEntity = new DormitoryEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[DormitoryModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
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

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRDormitorysController objDormitorysController = new HRDormitorysController();
            HRDormitorysInfo searchObject = (HRDormitorysInfo)CurrentModuleEntity.SearchObject;
            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDormitorysController.GetAllObjects();
                }
                else
                {
                    ds = objDormitorysController.GetDormitoryListDataSetByListOfBranchID(searchObject.HRDormitoryNo,
                                                                            searchObject.HRDormitoryName,
                                                                            searchObject.FK_BRBranchID,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.DormitoryFromDate,
                                                                            searchObject.DormitoryToDate,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objDormitorysController.GetDormitoryListDataSet(searchObject.HRDormitoryNo,
                                                              searchObject.HRDormitoryName,
                                                              searchObject.FK_BRBranchID,
                                                              searchObject.FK_HREmployeeID,
                                                              searchObject.DormitoryFromDate,
                                                               searchObject.DormitoryToDate);
            }
            return ds;
        }

        public override int ActionSave()
        {
            DormitoryEntities entity = (DormitoryEntities)CurrentModuleEntity;
            entity.DormitoryItemList.EndCurrentEdit();
            return base.ActionSave();
        }

        public void DeleteItemFromDormitoryItemsList()
        {
            DormitoryEntities entity = (DormitoryEntities)CurrentModuleEntity;
            entity.DormitoryItemList.RemoveSelectedRowObjectFromList();
        }
    }
}
