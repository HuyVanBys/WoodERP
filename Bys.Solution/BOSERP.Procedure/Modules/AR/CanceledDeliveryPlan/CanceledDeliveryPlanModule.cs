using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CanceledDeliveryPlan
{
    public class CanceledDeliveryPlanModule : BaseTransactionModule
    {
        #region Constants

        public const string ARCanceledDeliveryPlanItemsGridControlName = "fld_dgcARCanceledDeliveryPlanItemsGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "CanceledDeliveryPlan";

        #endregion

        #region Public properties

        #endregion

        #region Public properties

        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        #endregion
        public CanceledDeliveryPlanModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new CanceledDeliveryPlanEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CanceledDeliveryPlanModule.SearchBranchLookupEditControlName];
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
            ARCanceledDeliveryPlansController objCanceledDeliveryPlansController = new ARCanceledDeliveryPlansController();
            ARCanceledDeliveryPlansInfo searchObject = (ARCanceledDeliveryPlansInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objCanceledDeliveryPlansController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objCanceledDeliveryPlansController.GetCanceledDeliveryPlanListByListOfBranchID(
                                                                            searchObject.ARCanceledDeliveryPlanNo,
                                                                            searchObject.ARCanceledDeliveryPlanName,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.ARCanceledDeliveryPlanDateFrom,
                                                                            searchObject.ARCanceledDeliveryPlanDateTo,
                                                                            searchObject.FK_BRBranchID,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objCanceledDeliveryPlansController.GetCanceledDeliveryPlanListByBranchID(
                                                                    searchObject.ARCanceledDeliveryPlanNo,
                                                                    searchObject.ARCanceledDeliveryPlanName,
                                                                    searchObject.FK_HREmployeeID,
                                                                    searchObject.ARCanceledDeliveryPlanDateFrom,
                                                                    searchObject.ARCanceledDeliveryPlanDateTo,
                                                                    searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public override void InvalidateToolbar()
        {
            ARCanceledDeliveryPlansInfo mainObject = (ARCanceledDeliveryPlansInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ARCanceledDeliveryPlanID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (mainObject.ARCanceledDeliveryPlanStatus == CanceledDeliveryPlanStatus.Complete.ToString())
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
            CanceledDeliveryPlanEntities entity = (CanceledDeliveryPlanEntities)CurrentModuleEntity;
            ARCanceledDeliveryPlansInfo objCanceledDeliveryPlansInfo = (ARCanceledDeliveryPlansInfo)entity.MainObject;
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            List<ARDeliveryPlanItemsInfo> deliveryPlanItemsList = objDeliveryPlanItemsController.GetSaleOrderItemsForCancelingByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                                    BOSCommon.Constants.ModuleName.DeliveryPlan,
                                                                                                                    ADDataViewPermissionType.Module);

            guiChooseDeliveryPlanItems guiFind = new guiChooseDeliveryPlanItems(deliveryPlanItemsList);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARDeliveryPlanItemsInfo> deliveryPlanItems = (List<ARDeliveryPlanItemsInfo>)guiFind.SelectedObjects;
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = deliveryPlanItems.FirstOrDefault();
            if (objDeliveryPlanItemsInfo == null)
            {
                objDeliveryPlanItemsInfo = new ARDeliveryPlanItemsInfo();
            }

            ARDeliveryPlansController controller = new ARDeliveryPlansController();
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)controller.GetObjectByID(objDeliveryPlanItemsInfo.FK_ARDeliveryPlanID);

            objCanceledDeliveryPlansInfo.FK_ARDeliveryPlanID = objDeliveryPlanItemsInfo.FK_ARDeliveryPlanID;
            objCanceledDeliveryPlansInfo.ARCanceledDeliveryPlanType = objDeliveryPlanItemsInfo.ARDeliveryPlanType;
            if (objDeliveryPlansInfo != null)
            {
                objCanceledDeliveryPlansInfo.FK_PMProjectID = objDeliveryPlansInfo.FK_PMTemplateID;
                objCanceledDeliveryPlansInfo.FK_ARSaleContractID = objDeliveryPlansInfo.FK_ARSaleContractID;
                objCanceledDeliveryPlansInfo.FK_ACCostCenterID = objDeliveryPlansInfo.FK_ACCostCenterID;
            }

            entity.GenerateCanceledDeliveryPlanItems(deliveryPlanItems);
            entity.CanceledDeliveryPlanItemsList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public override bool ActionComplete()
        {
            bool isComplete = base.ActionComplete();
            return isComplete;
        }

        public void DeleteItemFromCanceledDeliveryPlanItemsList()
        {
            CanceledDeliveryPlanEntities entity = (CanceledDeliveryPlanEntities)CurrentModuleEntity;
            entity.CanceledDeliveryPlanItemsList.RemoveSelectedRowObjectFromList();
        }
    }
}
