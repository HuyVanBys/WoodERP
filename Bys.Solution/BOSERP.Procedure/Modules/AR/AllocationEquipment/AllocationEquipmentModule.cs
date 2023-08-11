using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationEquipment
{
    public class AllocationEquipmentModule : BaseTransactionModule
    {
        #region Constants

        public const string ARAllocationItemsGridControlName = "fld_dgcARAllocationItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "AllocationEquipment";

        #endregion

        #region Public properties

        #endregion 

        private bool IsEditAfterCompleting = false;
        #region Public properties

        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        #endregion
        public AllocationEquipmentModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new AllocationEquipmentEntities();
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

        public void ActionNewFromPlanWorkAssets()
        {
            base.ActionNew();

            AllocationEquipmentEntities entity = (AllocationEquipmentEntities)CurrentModuleEntity;
            ARDeliveryPlanWorksController objDeliveryPlanWorksController = new ARDeliveryPlanWorksController();
            List<ARDeliveryPlanWorksInfo> deliveryPlanWorkAssets = (List<ARDeliveryPlanWorksInfo>)objDeliveryPlanWorksController.GetDeliveryPlanWorkAssetsForAllocationItems();
            guiFind<ARDeliveryPlanWorksInfo> guiDeliveryPlanWorkAssets = new guiFind<ARDeliveryPlanWorksInfo>(TableName.ARDeliveryPlanWorksTableName,
                                                                deliveryPlanWorkAssets, this, true, true, new string[] { "FK_ARDeliveryPlanID" });
            if (guiDeliveryPlanWorkAssets.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARDeliveryPlanWorksInfo> deliveryPlanWorkAssetsSelected = (List<ARDeliveryPlanWorksInfo>)guiDeliveryPlanWorkAssets.SelectedObjects;
            if (deliveryPlanWorkAssetsSelected.Count <= 0)
                return;
            entity.GenerateEntitiesFromDeliveryPlanWorkAssets(deliveryPlanWorkAssetsSelected);

            entity.AllocationItemsList.GridControl.RefreshDataSource();
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARAllocationsController objAllocationsController = new ARAllocationsController();
            ARAllocationsInfo searchObject = (ARAllocationsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objAllocationsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objAllocationsController.GetAllocationListByListOfBranchID(
                                                                            searchObject.ARAllocationNo,
                                                                            searchObject.ARAllocationName,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.ARAllocationDateFrom,
                                                                            searchObject.ARAllocationDateTo,
                                                                            searchObject.FK_BRBranchID,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objAllocationsController.GetAllocationListByBranchID(
                                                                    searchObject.ARAllocationNo,
                                                                    searchObject.ARAllocationName,
                                                                    searchObject.FK_HREmployeeID,
                                                                    searchObject.ARAllocationDateFrom,
                                                                    searchObject.ARAllocationDateTo,
                                                                    searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public override void InvalidateToolbar()
        {
            ARAllocationsInfo ohjAllocationsInfo = (ARAllocationsInfo)CurrentModuleEntity.MainObject;
            if (ohjAllocationsInfo.ARAllocationID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (ohjAllocationsInfo.ARAllocationStatus == AllocationStatus.Complete.ToString())
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
        }

        public override bool ActionComplete()
        {
            bool isComplete = base.ActionComplete();
            if (isComplete)
            {
                AllocationEquipmentEntities entity = (AllocationEquipmentEntities)CurrentModuleEntity;
                ARAllocationsInfo objAllocationsInfo = (ARAllocationsInfo)entity.MainObject;
                ARDeliveryPlanWorksController objDeliveryPlanWorksController = new ARDeliveryPlanWorksController();
                List<ARDeliveryPlanWorksInfo> deliveryPlanWorkAssets = new List<ARDeliveryPlanWorksInfo>();
                deliveryPlanWorkAssets = objDeliveryPlanWorksController.GetDeliveryPlanWorkAssetByDeliveryPlanID(objAllocationsInfo.FK_ARDeliveryPlanID);
                entity.AllocationItemsList.All(o =>
                {
                    ARDeliveryPlanWorksInfo objDeliveryPlanWorkAssetsInfo = deliveryPlanWorkAssets.Where(x => x.ARDeliveryPlanWorkID == o.FK_ARDeliveryPlanWorkID).FirstOrDefault();
                    if (objDeliveryPlanWorkAssetsInfo != null)
                    {
                        objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkAllocationQty += o.ARAllocationItemQty;
                        objDeliveryPlanWorksController.UpdateObject(objDeliveryPlanWorkAssetsInfo);
                    }
                    return true;
                });
            }
            return isComplete;
        }

        public void DeleteItemFromAllocationItemsList()
        {
            AllocationEquipmentEntities entity = (AllocationEquipmentEntities)CurrentModuleEntity;
            entity.AllocationItemsList.RemoveSelectedRowObjectFromList();
        }

        public void AddItemToShipmentItemsList()
        {
            AllocationEquipmentEntities entity = (AllocationEquipmentEntities)CurrentModuleEntity;
            ARAllocationItemsInfo item = (ARAllocationItemsInfo)entity.ModuleObjects[TableName.ARAllocationItemsTableName];
            //item.ARAllocationItemProductIdentifiedEquipmentNo = "";
            //item.ARAllocationItemDepriciationDate = BOSApp.GetCurrentServerDate();
            if (item.FK_ICProductID > 0)
            {
                //item.ICShipmentItemProductUnitPrice = 0;
                //item.ICShipmentItemTotalAmount = 0;
                //item.ICShipmentItemPrice = 0;
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                entity.AllocationItemsList.AddObjectToList();
                //UpdateTotalAmount();
            }
        }
    }
}
