using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ReceptionEquipment
{
    public class ReceptionEquipmentModule : BaseTransactionModule
    {
        #region Constants

        public const string ARReceptionItemsGridControlName = "fld_dgcARReceptionItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "ReceptionEquipment";

        #endregion

        #region Public properties

        #endregion 

        private bool IsEditAfterCompleting = false;
        #region Public properties

        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        #endregion
        public ReceptionEquipmentModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new ReceptionEquipmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
        }

        public override int ActionSave()
        {
            return base.ActionSave(); ;
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
            ARReceptionsController objReceptionsController = new ARReceptionsController();
            ARReceptionsInfo searchObject = (ARReceptionsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objReceptionsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objReceptionsController.GetReceptionListByListOfBranchID(
                                                                            searchObject.ARReceptionNo,
                                                                            searchObject.ARReceptionName,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.ARReceptionDateFrom,
                                                                            searchObject.ARReceptionDateTo,
                                                                            searchObject.FK_BRBranchID,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objReceptionsController.GetReceptionListByBranchID(
                                                                    searchObject.ARReceptionNo,
                                                                    searchObject.ARReceptionName,
                                                                    searchObject.FK_HREmployeeID,
                                                                    searchObject.ARReceptionDateFrom,
                                                                    searchObject.ARReceptionDateTo,
                                                                    searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public override void InvalidateToolbar()
        {
            ARReceptionsInfo ohjReceptionsInfo = (ARReceptionsInfo)CurrentModuleEntity.MainObject;
            if (ohjReceptionsInfo.ARReceptionID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (ohjReceptionsInfo.ARReceptionStatus == ReceptionStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void ActionNew()
        {
            base.ActionNew();

            ReceptionEquipmentEntities entity = (ReceptionEquipmentEntities)CurrentModuleEntity;
            ARAllocationItemsController objAllocationItemsController = new ARAllocationItemsController();
            List<ARAllocationItemsInfo> allocationItems = new List<ARAllocationItemsInfo>();
            allocationItems = (List<ARAllocationItemsInfo>)objAllocationItemsController.GetAllocationItemsForReceptionItems();
            guiFind<ARAllocationItemsInfo> guiAllocationItems = new guiFind<ARAllocationItemsInfo>(TableName.ARAllocationItemsTableName,
                                                                allocationItems, this, true, true, new string[] { "FK_ARAllocationID" });
            if (guiAllocationItems.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARAllocationItemsInfo> allocationItemsSelected = (List<ARAllocationItemsInfo>)guiAllocationItems.SelectedObjects;
            if (allocationItemsSelected.Count <= 0)
                return;
            entity.GenerateEntitiesFromAllocationItems(allocationItemsSelected);

            entity.ReceptionItemsList.GridControl.RefreshDataSource();
        }

        public override bool ActionComplete()
        {
            bool isComplete = base.ActionComplete();
            if (isComplete)
            {
                ReceptionEquipmentEntities entity = (ReceptionEquipmentEntities)CurrentModuleEntity;
                ARReceptionsInfo objReceptionsInfo = (ARReceptionsInfo)entity.MainObject;
                ARAllocationItemsController objAllocationItemsController = new ARAllocationItemsController();
                List<ARAllocationItemsInfo> allocationItems = new List<ARAllocationItemsInfo>();
                allocationItems = objAllocationItemsController.GetAllocationItemsByAllocationID(objReceptionsInfo.FK_ARAllocationID);
                entity.ReceptionItemsList.All(o =>
                    {
                        ARAllocationItemsInfo objAllocationItemsInfo = allocationItems.Where(x => x.ARAllocationItemID == o.FK_ARAllocationItemID).FirstOrDefault();
                        objAllocationItemsInfo.ARAllocationItemReceiptQty += o.ARReceptionItemQty;
                        objAllocationItemsController.UpdateObject(objAllocationItemsInfo);
                        return true;
                    });
            }
            return isComplete;
        }

        public void DeleteItemFromReceptionItemsList()
        {
            ReceptionEquipmentEntities entity = (ReceptionEquipmentEntities)CurrentModuleEntity;
            entity.ReceptionItemsList.RemoveSelectedRowObjectFromList();
        }

        public void ActionNewReturn()
        {
            ActionNew();
            ReceptionEquipmentEntities entity = (ReceptionEquipmentEntities)CurrentModuleEntity;
            ARReceptionsInfo objReceptionsInfo = (ARReceptionsInfo)entity.MainObject;
            objReceptionsInfo.ARReceptionType = ReceptionType.Return.ToString();
        }

        public void ActionNewLost()
        {
            ActionNew();
            ReceptionEquipmentEntities entity = (ReceptionEquipmentEntities)CurrentModuleEntity;
            ARReceptionsInfo objReceptionsInfo = (ARReceptionsInfo)entity.MainObject;
            objReceptionsInfo.ARReceptionType = ReceptionType.Lost.ToString();
        }
    }
}
