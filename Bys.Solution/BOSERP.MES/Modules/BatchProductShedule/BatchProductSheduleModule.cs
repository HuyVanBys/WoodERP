using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Enums;
using BOSCommon.Extensions;
using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class BatchProductSheduleModule : BaseTransactionModule
    {
        #region Constants
        public const string ItemWoodsGridControlName = "fld_dgcBPProductionNormItemWoodsGridControl";
        public const string ItemHardwaresGridControlName = "fld_dgcBPProductionNormItemHardwaresGridControl";
        public const string ItemPaintsGridControlName = "fld_dgcBPProductionNormItemPaintsGridControl";
        public const string ItemPackagingsGridControlName = "fld_dgcBPProductionNormItemPackagingsGridControl";
        public const string ItemSteelsGridControlName = "fld_dgcBPProductionNormItemSteelsGridControl";
        public const string ItemInstrumentsGridControlName = "fld_dgcBPProductionNormItemInstrumentsGridControl";
        public const string ItemSemiProductsGridControlName = "fld_dgcMMBPNormItemSemiProductGridControl";

        public const string DepartmentRoomGroupItemControlName = "fld_lkeHRDepartmentRoomGroupItemID";
        public const string WorkShopControlName = "fld_lkeFK_MMWorkShopID";
        public const string LineControlName = "fld_lkeFK_MMLineID";

        public const string EmployeeReceiveControlName = "fld_lkeFK_HREmployeeIDReceive";
        public const string ProductionNormTabControlName = "fld_tabProductionNorm";
        public string CurrentTabSelected { get; set; }
        public List<string> SelectionSelectedTabs { get; set; }
        #endregion Constants

        #region Private Properties

        #endregion Private Properties


        #region Public Properties
        public MMBPNormItemWoodsGridControl ItemWoodsGridControl;
        public MMBPNormItemHardwaresGridControl ItemHardwaresGridControl;
        public MMBPNormItemPaintsGridControl ItemPaintsGridControl;
        public MMBPNormItemPackagingsGridControl ItemPackagingsGridControl;
        public MMBPNormItemSteelsGridControl ItemSteelsGridControl;
        public MMBPNormItemInstrumentsGridControl ItemInstrumentsGridControl;
        public BOSLookupEdit DepartmentRoomGroupItemControl;
        public BOSLookupEdit WorkShopControl;
        public BOSLookupEdit LineControl;
        public BOSLookupEdit EmployeeReceiveControl;
        public BOSTabControl ProductionNormTabControl;
        #endregion Public Properties

        #region Common methods

        public BatchProductSheduleModule()
        {
            Name = ModuleName.BatchProductShedule;
            CurrentModuleEntity = new BatchProductSheduleEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            ItemWoodsGridControl = (MMBPNormItemWoodsGridControl)Controls[ItemWoodsGridControlName];
            ItemHardwaresGridControl = (MMBPNormItemHardwaresGridControl)Controls[ItemHardwaresGridControlName];
            ItemPaintsGridControl = (MMBPNormItemPaintsGridControl)Controls[ItemPaintsGridControlName];
            ItemPackagingsGridControl = (MMBPNormItemPackagingsGridControl)Controls[ItemPackagingsGridControlName];
            ItemSteelsGridControl = (MMBPNormItemSteelsGridControl)Controls[ItemSteelsGridControlName];
            ItemInstrumentsGridControl = (MMBPNormItemInstrumentsGridControl)Controls[ItemInstrumentsGridControlName];
            DepartmentRoomGroupItemControl = (BOSLookupEdit)Controls[DepartmentRoomGroupItemControlName];
            WorkShopControl = (BOSLookupEdit)Controls[WorkShopControlName];
            LineControl = (BOSLookupEdit)Controls[LineControlName];
            EmployeeReceiveControl = (BOSLookupEdit)Controls[EmployeeReceiveControlName];
            ProductionNormTabControl = (BOSTabControl)Controls[ProductionNormTabControlName];
            LoadLookupDataSource();
            SelectionSelectedTabs = new List<string>();
            CurrentTabSelected = ProductionNormTabControl == null ? string.Empty : ProductionNormTabControl.SelectedTabPage?.Name;
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

        public void LoadLookupDataSource()
        {
            if (DepartmentRoomGroupItemControl != null)
            {
                HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
                List<HRDepartmentRoomGroupItemsInfo> datasource = objDepartmentRoomGroupItemsController.GetAllDepartmentRoomGroupItemList();
                datasource.Insert(0, new HRDepartmentRoomGroupItemsInfo());
                DepartmentRoomGroupItemControl.Properties.DataSource = datasource;
            }

            if (EmployeeReceiveControl != null)
            {
                List<HREmployeesInfo> employeeReceiveList = (List<HREmployeesInfo>)(new HREmployeesController())
                    .GetListFromDataSet(new HREmployeesController()
                    .GetAllEmployeesForLookupControl());
                if (employeeReceiveList != null)
                    employeeReceiveList.Insert(0, new HREmployeesInfo());
                EmployeeReceiveControl.Properties.DataSource = employeeReceiveList;
            }

            if (WorkShopControl != null)
            {
                WorkShopControl.Properties.DataSource = GetDataSourceForWorkShopByCurrentBranch();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            MMAllocationPlansController objAllocationPlansController = new MMAllocationPlansController();
            MMAllocationPlansInfo searchObject = CurrentModuleEntity.SearchObject as MMAllocationPlansInfo;
            DataSet ds;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objAllocationPlansController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objAllocationPlansController.GetAllocationPlanOfBranchList(searchObject.MMAllocationPlanNo
                                                                                   , searchObject.FK_HREmployeeID
                                                                                   , searchObject.FK_MMBatchProductID
                                                                                   , objObjectsInfo.ACObjectID
                                                                                   , objObjectsInfo.ACObjectType
                                                                                   , searchObject.AllocationPlanDateFrom
                                                                                   , searchObject.AllocationPlanDateTo
                                                                                   , AllocationPlanCreateFrom.BatchProduct.ToString()
                                                                                   , BranchList);
                }
            }
            else
            {
                ds = objAllocationPlansController.GetAllocationPlanOfBranch(searchObject.MMAllocationPlanNo
                                                                           , searchObject.FK_HREmployeeID
                                                                           , searchObject.FK_MMBatchProductID
                                                                           , objObjectsInfo.ACObjectID
                                                                           , objObjectsInfo.ACObjectType
                                                                           , searchObject.AllocationPlanDateFrom
                                                                           , searchObject.AllocationPlanDateTo
                                                                           , AllocationPlanCreateFrom.BatchProduct.ToString()
                                                                           , searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainObject = entity.MainObject as MMAllocationPlansInfo;
            mainObject.ACObjectAccessKey = string.Format("{0};{1}", mainObject.FK_ACObjectID, mainObject.MMObjectType);
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(mainObject.FK_MMBatchProductID);
            if (objBatchProductsInfo != null)
            {
                mainObject.MMAllocationPlanSOName = objBatchProductsInfo.MMBatchProductSOName;
            }    
            entity.UpdateMainObjectBindingSource();
            ClearGridControlSection();
            SelectionSelectedTabs.Clear();
            ChangeCurrentTabPage(CurrentTabSelected);
            bool isEnableFeature = true;
            if (mainObject.MMAllocationPlanStatus != AllocationPlanStatus.Close.ToString() && CheckValidChangeNorm(mainObject.FK_MMBatchProductID))
            {
                DialogResult rs = MessageBox.Show("Định mức nguyên liệu đã được thay đổi. Cập nhật định mức để tiếp tục.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                    UpdateAllocationPlanWithChangeBOM(false);
                else
                    isEnableFeature = false;
            }
            EnableControl(isEnableFeature);
        }

        public bool CheckValidChangeNorm(int batchProductID)
        {
            MMBatchProductAdjustLogsController objAdjustLogsController = new MMBatchProductAdjustLogsController();
            return objAdjustLogsController.CheckValidChangeNorm(batchProductID);
        }

        public void UpdateChangeNorm(int batchProductID)
        {
            MMBatchProductAdjustLogsController objAdjustLogsController = new MMBatchProductAdjustLogsController();
            objAdjustLogsController.UpdateMaterialChanged(batchProductID);
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            if (Toolbar.ModusAction == BaseToolbar.ModusEdit)
            {
                Toolbar.Invalidate();
            }
            base.ModuleAfterSaved(iObjectID);
        }

        public void EnableControl(bool isEnabled = true)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            GroupBox control = (GroupBox)Controls["fld_gcPlan"];
            if (control != null)
                control.Enabled = isEnabled;

            control = (GroupBox)Controls["fld_gcApprove"];
            if (control != null)
                control.Enabled = isEnabled;

            control = (GroupBox)Controls["fld_gcExtention"];
            if (control != null)
                control.Enabled = isEnabled;

            XtraTabControl tabControl = (XtraTabControl)Controls["fld_tabProductionNorm"];
            if (tabControl != null)
            {
                tabControl.Enabled = isEnabled;
            }
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, isEnabled);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            List<string> buttonNameList = new List<string>()
                {
                    "fld_btnPlanned",
                    "fld_btnUnPlanned",
                    "fld_btnApprove",
                    "fld_btnUnApprove",
                    "fld_btnClosePlan"
                };
            buttonNameList.ForEach(o =>
            {
                BOSButton button = (BOSButton)Controls[o];
                if (button == null)
                    return;

                button.Enabled = false;
                if (mainobject.MMAllocationPlanStatus != AllocationPlanStatus.Saved.ToString() || !Toolbar.IsNullOrNoneAction())
                    return;

                button.Enabled = true;
            });
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton("UpdateWithChangeBOM", false);
            ParentScreen.SetEnableOfToolbarButton("CloseAllocationPlan", false);
            if (mainobject.MMAllocationPlanStatus != AllocationPlanStatus.Close.ToString() && !Toolbar.IsEditAction())
            {
                ParentScreen.SetEnableOfToolbarButton("CloseAllocationPlan", true);
                ParentScreen.SetEnableOfToolbarButton("UpdateWithChangeBOM", true);
            }
            if (mainobject.MMAllocationPlanStatus == AllocationPlanStatus.Close.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("UpdateWithChangeBOM", false);
            }
        }

        public void ClearGridControlSection()
        {
            if (ItemWoodsGridControl != null && ItemWoodsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemWoodsGridControl.MainView;
                gridView.ClearSelection();
            }
            if (ItemHardwaresGridControl != null && ItemHardwaresGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemHardwaresGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemPaintsGridControl != null && ItemPaintsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemPaintsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemPackagingsGridControl != null && ItemPackagingsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemPackagingsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemSteelsGridControl != null && ItemSteelsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemSteelsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemInstrumentsGridControl != null && ItemInstrumentsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemInstrumentsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemSteelsGridControl != null && ItemSteelsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemSteelsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
        }
        public override int ActionSave()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)entity.MainObject;
            entity.BPProductionNormItemMaterialList.EndCurrentEdit();
            entity.BPProductionNormItemHardwareList.EndCurrentEdit();
            entity.BPProductionNormItemPaintList.EndCurrentEdit();
            entity.BPProductionNormItemPackagingList.EndCurrentEdit();
            entity.BPProductionNormItemOtherMaterialList.EndCurrentEdit();
            entity.BPProductionNormItemInstrumentList.EndCurrentEdit();
            entity.BPProductionNormItemSemiProductList.EndCurrentEdit();
            if (!CheckValidBPQty())
                return 0;

            return base.ActionSave();
        }

        public bool CheckValidBPQty()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage = CheckItemIsValidQty(entity.BPProductionNormItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += CheckItemIsValidQty(entity.BPProductionNormItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    errorMessage += CheckItemIsValidQty(entity.BPProductionNormItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += CheckItemIsValidQty(entity.BPProductionNormItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += CheckItemIsValidQty(entity.BPProductionNormItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += CheckItemIsValidQty(entity.BPProductionNormItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += CheckItemIsValidQty(entity.BPProductionNormItemSemiProductList);
                    break;
            }
            string configText = ConfigurationManager.AppSettings["AllowNormChange"];
            bool isWarning = false;
            if (string.IsNullOrEmpty(configText))
                isWarning = false;
            else
                Boolean.TryParse(configText, out isWarning);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                if (isWarning)
                {
                    DialogResult rs = MessageBox.Show(errorMessage + Environment.NewLine + "Bạn có muốn tiếp tục không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs != DialogResult.Yes)
                        return false;
                }
                else
                {
                    errorMessage += Environment.NewLine;
                    errorMessage += "Vui lòng kiểm tra lại!";
                    MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public string CheckItemIsValidQty(List<MMAllocationPlanItemsInfo> itemList)
        {
            List<string> errors = new List<string>();
            List<MMAllocationPlanItemsInfo> mergeList = MergeSameProduct(itemList);
            var validateList = mergeList.Where(o => o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.New.ToString()).ToList();
            decimal sameItemQty = 0;
            validateList.ForEach(o =>
            {
                if (o.FK_MMBatchProductProductionNormItemID == 0
                    && o.FK_MMBatchProductItemOutSourcingID == 0
                    && o.FK_MMBatchProductProductionNormItemMeterialID == 0)
                    return;

                sameItemQty = mergeList.Where(sio => sio.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString()
                                                    && o.FK_MMBatchProductProductionNormItemID == sio.FK_MMBatchProductProductionNormItemID
                                                    && o.FK_MMBatchProductItemOutSourcingID == sio.FK_MMBatchProductItemOutSourcingID
                                                    && o.FK_MMBatchProductProductionNormItemMeterialID == sio.FK_MMBatchProductProductionNormItemMeterialID)
                                       .Sum(sio => sio.MMAllocationPlanItemQty);
                if (o.MMAllocationPlanItemQty + sameItemQty <= o.MMAllocationPlanItemBPQty)
                    return;

                errors.Add(o.ICProductNo);
            });
            if (!errors.Any())
                return string.Empty;

            return string.Format("Mã vật tư {0} có số lượng vượt định mức.", string.Join(", ", errors.Distinct().ToArray()));
        }

        public List<MMAllocationPlanItemsInfo> MergeSameProduct(List<MMAllocationPlanItemsInfo> itemList)
        {
            itemList = itemList.Select(o => (MMAllocationPlanItemsInfo)o.Clone()).ToList();
            itemList.ForEach(o =>
            {
                if (o.FK_ICProductAlternativeID > 0 && o.FK_ICProductAlternativeID != o.FK_ICProductID)
                {
                    o.FK_ICProductID = o.FK_ICProductAlternativeID;
                }
                o.MMAllocationPlanItemQty = ChangeAlternativeQty(true, o.MMAllocationPlanItemAltFactor, o.MMAllocationPlanItemQty, o.MMAllocationPlanItemRate);
            });
            List<MMAllocationPlanItemsInfo> mergeList = new List<MMAllocationPlanItemsInfo>();
            mergeList = itemList.GroupBy(o => new
            {
                o.FK_MMBatchProductID,
                o.FK_MMBatchProductItemID,
                o.FK_MMBatchProductProductionNormItemID,
                o.FK_MMBatchProductProductionNormItemMeterialID,
                o.FK_MMBatchProductItemOutSourcingID,
                o.MMAllocationPlanItemGroup,
                o.ICProductNo,
                o.MMAllocationPlanItemProductName,
                o.MMAllocationPlanItemProductDesc,
                o.MMAllocationPlanItemStatus
            }).Select(o => new MMAllocationPlanItemsInfo()
            {
                FK_MMBatchProductID = o.Key.FK_MMBatchProductID,
                FK_MMBatchProductItemID = o.Key.FK_MMBatchProductItemID,
                FK_MMBatchProductProductionNormItemID = o.Key.FK_MMBatchProductProductionNormItemID,
                FK_MMBatchProductProductionNormItemMeterialID = o.Key.FK_MMBatchProductProductionNormItemMeterialID,
                FK_MMBatchProductItemOutSourcingID = o.Key.FK_MMBatchProductItemOutSourcingID,
                MMAllocationPlanItemGroup = o.Key.MMAllocationPlanItemGroup,
                ICProductNo = o.Key.ICProductNo,
                MMAllocationPlanItemProductName = o.Key.MMAllocationPlanItemProductName,
                MMAllocationPlanItemProductDesc = o.Key.MMAllocationPlanItemProductDesc,
                MMAllocationPlanItemStatus = o.Key.MMAllocationPlanItemStatus,
                MMAllocationPlanItemBPQty = o.Select(item => item.MMAllocationPlanItemBPQty).FirstOrDefault(),
                MMAllocationPlanItemQty = o.Sum(item => item.MMAllocationPlanItemQty)
            }).ToList();
            return mergeList;
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            ParentScreen.SetEnableOfToolbarButton(BatchProductSheduleConst.ApproveBatchProductShedule, false);
            ParentScreen.SetEnableOfToolbarButton(BatchProductSheduleConst.ValidateBatchProductShedule, false);
        }

        public void ShowInventoryTotalQty()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)entity.MainObject;

            BOSProgressBar.Start("Đang lấy dữ liệu tồn kho");
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    GetInventoryStockQty(entity.BPProductionNormItemMaterialList, true);
                    break;
                case "fld_tabOtherMaterial":
                    GetInventoryStockQty(entity.BPProductionNormItemOtherMaterialList, true);
                    break;
                case "fld_tabHardware":
                    GetInventoryStockQty(entity.BPProductionNormItemHardwareList, true);
                    break;
                case "fld_tabIngredientPaint":
                    GetInventoryStockQty(entity.BPProductionNormItemPaintList, true);
                    break;
                case "fld_tabIngredientPackaging":
                    GetInventoryStockQty(entity.BPProductionNormItemPackagingList, true);
                    break;
                case "fld_tabGeneralMaterial":
                    GetInventoryStockQty(entity.BPProductionNormItemInstrumentList, true);
                    break;
                case "fld_tabSemiProduct":
                    GetInventoryStockQty(entity.BPProductionNormItemSemiProductList, true);
                    break;
            }
            BOSProgressBar.Close();
        }

        //public void GetInventoryStockQty
        public void GetInventoryStockQty(BOSList<MMAllocationPlanItemsInfo> itemList, bool isGetAll = false)
        {
            if (itemList.Count() == 0)
                return;

            ICTransactionsController objTransactionsController = new ICTransactionsController();
            string productListRef = string.Empty;
            List<int> productIDs = new List<int>();
            if (isGetAll)
                productIDs = itemList.Select(o => o.FK_ICProductID).Distinct().ToList();
            else
                productIDs = GetSelectedRefProductID(itemList).Distinct().ToList();

            List<ICTransactionsInfo> inventoryStocks = objTransactionsController.GetInventoryStockListByProductRef(productIDs, null, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
            decimal unitFactor = 0;
            itemList.ForEach(o =>
            {
                if (!isGetAll)
                    return;

                if (o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                    || o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                    || o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                    return;

                objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == o.FK_ICProductID).FirstOrDefault();
                if (objTransactionsInfo == null)
                    objTransactionsInfo = new ICTransactionsInfo();

                availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICInventoryStockAllocationPlanQuantity;
                if (availableQty < 0)
                    availableQty = 0;
                unitFactor = 1m;
                unitFactor = o.ICProductMeasureUnitFactor > 0 ? o.ICProductMeasureUnitFactor : unitFactor;
                o.ICInventoryStockQty = Math.Round(availableQty / unitFactor, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += (o.MMAllocationPlanItemQty * unitFactor);
            });
            if (!isGetAll && itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                        continue;

                    objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == item.FK_ICProductID).FirstOrDefault();
                    if (objTransactionsInfo == null)
                        objTransactionsInfo = new ICTransactionsInfo();

                    availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICInventoryStockAllocationPlanQuantity;
                    if (availableQty < 0)
                        availableQty = 0;

                    unitFactor = 1m;
                    unitFactor = item.ICProductMeasureUnitFactor > 0 ? item.ICProductMeasureUnitFactor : unitFactor;
                    item.ICInventoryStockQty = Math.Round(availableQty / unitFactor, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += (item.MMAllocationPlanItemQty * unitFactor);
                }
            }
            itemList.GridControl?.RefreshDataSource();
        }

        public List<int> GetSelectedRefProductID(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            List<int> selectRefProductList = new List<int>();
            if (itemList == null)
                return selectRefProductList;

            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                        continue;
                    selectRefProductList.Add(item.FK_ICProductID);
                }
            }
            return selectRefProductList;
        }

        public void GetInventoryStockQty(List<MMAllocationPlanItemsInfo> itemList)
        {
            if (itemList.Count() == 0)
                return;

            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<int> productIds = itemList.Select(o => o.FK_ICProductID).Distinct().ToList();
            List<ICTransactionsInfo> inventoryStocks = objTransactionsController.GetInventoryStockListByProductRef(productIds, null, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
            decimal unitFactor = 0;
            itemList.ForEach(o =>
            {
                if (o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                    || o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                    || o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                    return;

                objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == o.FK_ICProductID).FirstOrDefault();
                if (objTransactionsInfo == null)
                    objTransactionsInfo = new ICTransactionsInfo();

                availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICInventoryStockAllocationPlanQuantity;
                if (availableQty < 0)
                    availableQty = 0;

                unitFactor = 1m;
                unitFactor = o.ICProductMeasureUnitFactor > 0 ? o.ICProductMeasureUnitFactor : unitFactor;
                o.ICInventoryStockQty = Math.Round(availableQty / unitFactor, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += (o.MMAllocationPlanItemQty * unitFactor);
            });
        }

        #endregion Public methods
        #region Action New
        public override void ActionNew()
        {
            base.ActionNew();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            objAllocationPlansInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objAllocationPlansInfo.MMAllocationPlanDate = BOSApp.GetCurrentServerDate();
            objAllocationPlansInfo.MMAllocationPlanStatus = AllocationPlanStatus.New.ToString();
            SelectionSelectedTabs.Clear();
        }

        #region Tạo mới theo LSX
        internal void ChangeObject(string objectAccessKey)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objAllocationPlansInfo.ACObjectAccessKey = string.Empty;
            objAllocationPlansInfo.FK_ACObjectID = 0;
            objAllocationPlansInfo.MMObjectType = string.Empty;
            if (objObjectsInfo != null)
            {
                objAllocationPlansInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objAllocationPlansInfo.MMObjectType = objObjectsInfo.ACObjectType;
                objAllocationPlansInfo.ACObjectAccessKey = objectAccessKey;
            }
            entity.UpdateMainObjectBindingSource();
        }
        #endregion
        public void PlannedSelectedItems()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            if (!CheckValidBPQty())
                return;

            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorMessage += Environment.NewLine;
                errorMessage += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    PlannedSelectedItems(entity.BPProductionNormItemMaterialList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    PlannedSelectedItems(entity.BPProductionNormItemOtherMaterialList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    PlannedSelectedItems(entity.BPProductionNormItemHardwareList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    PlannedSelectedItems(entity.BPProductionNormItemPaintList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    PlannedSelectedItems(entity.BPProductionNormItemPackagingList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    PlannedSelectedItems(entity.BPProductionNormItemInstrumentList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    PlannedSelectedItems(entity.BPProductionNormItemSemiProductList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
        }

        public void UnPlannedSelectedItems()
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn hủy kế hoạch các vật tư đã chọn?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.BPProductionNormItemSemiProductList);
                    break;
            }
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorMessage += Environment.NewLine;
                errorMessage += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    UnPlannedSelectedItems(entity.BPProductionNormItemMaterialList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    UnPlannedSelectedItems(entity.BPProductionNormItemOtherMaterialList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    UnPlannedSelectedItems(entity.BPProductionNormItemHardwareList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    UnPlannedSelectedItems(entity.BPProductionNormItemPaintList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    UnPlannedSelectedItems(entity.BPProductionNormItemPackagingList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    UnPlannedSelectedItems(entity.BPProductionNormItemInstrumentList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    UnPlannedSelectedItems(entity.BPProductionNormItemSemiProductList);
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
        }

        public string ValidateUnPlannedSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            string errorMessage = string.Empty;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Planed.ToString())
                        continue;

                    if (item.MMAllocationPlanItemPlanedQty > 0)
                    {
                        errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " đã cấp phát.";
                        errorMessage += Environment.NewLine;
                        continue;
                    }
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return errorMessage;
        }

        public string UnPlannedSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            string errorMessage = string.Empty;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Planed.ToString())
                        continue;

                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return errorMessage;
        }

        public string PlannedSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            string errorMessage = string.Empty;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.New.ToString() || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Canceled.ToString())
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                    else
                    continue;

                    
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return errorMessage;
        }

        public void ApproveSelectedItems()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            if (!CheckValidBPQty())
                return;

            BOSProgressBar.Start("Đang lấy dữ liệu tồn kho");
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    GetInventoryStockQty(entity.BPProductionNormItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    GetInventoryStockQty(entity.BPProductionNormItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    GetInventoryStockQty(entity.BPProductionNormItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    GetInventoryStockQty(entity.BPProductionNormItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    GetInventoryStockQty(entity.BPProductionNormItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    GetInventoryStockQty(entity.BPProductionNormItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    GetInventoryStockQty(entity.BPProductionNormItemSemiProductList);
                    break;
            }
            BOSProgressBar.Close();
            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString(), true);
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString(), true);
                    break;
                case "fld_tabHardware":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString(), true);
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString(), true);
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString(), true);
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString(), true);
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += ValidateSelectedItems(entity.BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString(), true);
                    break;
            }
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorMessage += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> refIDList = new List<int>();
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemMaterialList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemOtherMaterialList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemHardwareList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemPaintList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemPackagingList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemInstrumentList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    refIDList.AddRange(ApproveSelectedItems(entity.BPProductionNormItemSemiProductList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, refIDList);
        }

        public void UnApproveSelectedItems()
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn hủy cấp phát các vật tư đã chọn?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            if (!IsValidUnApproveSelectedItem())
                return;

            List<int> refIDList = new List<int>();
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemMaterialList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemOtherMaterialList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemHardwareList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemPaintList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemPackagingList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemInstrumentList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    refIDList.AddRange(UnApproveSelectedItems(entity.BPProductionNormItemSemiProductList));
                    entity.SaveAllocationPlanItems(entity.BPProductionNormItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, refIDList, false);
        }

        public bool IsValidUnApproveSelectedItem()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            string errorMessage = string.Empty;

            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += CheckValidQtyUnApprove(entity.BPProductionNormItemSemiProductList);
                    break;
            }
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorMessage += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public string CheckValidQtyUnApprove(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            string errorMessage = string.Empty;
            List<MMAllocationPlanItemsInfo> selectedList = new List<MMAllocationPlanItemsInfo>();
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Approved.ToString())
                        continue;

                    if (item.Id == 0)
                    {
                        errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " chưa lưu.";
                        errorMessage += Environment.NewLine;
                        continue;
                    }

                    selectedList.Add(item);
                }
                string allocationPlanItemRef = string.Join(",", selectedList.Select(o => o.Id).ToArray());
                MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
                List<MMAllocationPlanItemsInfo> checkedList = objAllocationPlanItemsController.GetListForCheckUnAllocationPlan(allocationPlanItemRef);
                MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
                selectedList.ForEach(o =>
                {
                    objAllocationPlanItemsInfo = checkedList.Where(item => item.Id == o.Id).FirstOrDefault();
                    if (objAllocationPlanItemsInfo == null)
                        return;

                    if (objAllocationPlanItemsInfo.MMAllocationProposalItemQty > 0)
                    {
                        errorMessage += "Sản phẩm " + o.MMAllocationPlanItemProductDesc + " đã có cấp phát.";
                        errorMessage += Environment.NewLine;
                    }
                });
            }
            return errorMessage;
        }

        public List<int> UnApproveSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            List<int> arrID = new List<int>();
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Approved.ToString() && item.MMAllocationProposalItemQty > 0)
                        continue;

                    arrID.Add(item.Id);
                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return arrID;
        }

        public void PlanGroupItems(BOSList<MMAllocationPlanItemsInfo> itemList, string group, List<MMAllocationPlanItemsInfo> selectedList)
        {
            if (!Toolbar.IsNullOrNoneAction())
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            if (!CheckValidBPQty() || selectedList.Count() == 0)
                return;

            string errorMessage = string.Empty;
            errorMessage += ValidateSelectedItems(selectedList, group);
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorMessage += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
            selectedList.ForEach(o =>
            {
                if (o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
                    return;

                objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)objAllocationPlanItemsController.GetObjectByID(o.Id);
                if (objAllocationPlanItemsInfo == null)
                    return;

                o.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                objAllocationPlanItemsInfo.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                objAllocationPlanItemsController.UpdateObject(objAllocationPlanItemsInfo);
            });
            itemList.GridControl?.RefreshDataSource();
        }

        public void ApproveGroupItems(BOSList<MMAllocationPlanItemsInfo> itemList, string group, List<MMAllocationPlanItemsInfo> selectedList)
        {
            if (!Toolbar.IsNullOrNoneAction())
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            if (!CheckValidBPQty() || selectedList.Count() == 0)
                return;

            BOSProgressBar.Start("Đang lấy dữ liệu tồn kho");
            GetInventoryStockQty(selectedList);
            BOSProgressBar.Close();
            string errorMessage = string.Empty;
            errorMessage += ValidateSelectedItems(selectedList, group, true);
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorMessage += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> refIDList = new List<int>();
            refIDList.AddRange(ApproveSelectedItems(selectedList));
            itemList.GridControl?.RefreshDataSource();
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, refIDList);
        }
        public void CancelAlternativeItems(BOSList<MMAllocationPlanItemsInfo> itemList, List<MMAllocationPlanItemsInfo> selectedList, bool isMaterial)
        {
            selectedList.ForEach(obj =>
            {
                if (obj.MMAllocationPlanItemStatus != Status.New.ToString())
                {
                    BOSApp.ShowMessage("Trạng thái chi tiết không phù hợp");
                    return;
                }
                if (obj.FK_ICProductAlternativeID > 0 || (obj.MMAllocationPlanItemRate > 0 && obj.MMAllocationPlanItemRate != 1m))
                {
                    obj.MMAllocationPlanItemQty = ChangeAlternativeQty(true, obj.MMAllocationPlanItemAltFactor, obj.MMAllocationPlanItemQty, obj.MMAllocationPlanItemRate);
                    ICProductsInfo found;
                    if (obj.FK_ICProductAlternativeID > 0)
                        found = BOSApp.GetProductFromCurrentProductList(obj.FK_ICProductAlternativeID);
                    else
                        found = BOSApp.GetProductFromCurrentProductList(obj.FK_ICProductID);

                    MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
                    MMAllocationPlanItemsInfo old = objAllocationPlanItemsController.GetRemainItemForAlternative(obj.Id, obj.FK_MMBatchProductProductionNormItemID, obj.FK_MMBatchProductProductionNormItemMeterialID, obj.FK_MMBatchProductItemOutSourcingID);
                    if (found != null)
                    {
                        obj.ICProductCode = found.ICProductCode;
                        obj.ICProductNo = found.ICProductNo;
                        obj.MMAllocationPlanItemProductName = found.ICProductName;
                        obj.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                        if (old != null)
                        {
                            obj.ICProductCode = old.ICProductCode;
                            obj.MMAllocationPlanItemProductName = old.MMAllocationPlanItemProductName;
                            obj.MMAllocationPlanItemProductDesc = old.MMAllocationPlanItemProductDesc;
                            obj.MMAllocationPlanItemHeight = old.MMAllocationPlanItemHeight;
                            obj.MMAllocationPlanItemWidth = old.MMAllocationPlanItemWidth;
                            obj.MMAllocationPlanItemLength = old.MMAllocationPlanItemLength;
                            obj.MMBatchProductProductionNormItemProductHeight = old.MMBatchProductProductionNormItemProductHeight;
                            obj.MMBatchProductProductionNormItemProductWidth = old.MMBatchProductProductionNormItemProductWidth;
                            obj.MMBatchProductProductionNormItemProductLength = old.MMBatchProductProductionNormItemProductLength;
                            obj.FK_ICProductAttributeQualityID = old.FK_ICProductAttributeQualityID;
                            obj.FK_ICMeasureUnitID = old.FK_ICMeasureUnitID;
                            obj.FK_ICProductAttributeWoodTypeID = old.FK_ICProductAttributeWoodTypeID;
                        }
                        else
                        {
                            obj.MMAllocationPlanItemHeight = found.ICProductHeight;
                            obj.MMAllocationPlanItemWidth = found.ICProductWidth;
                            obj.MMAllocationPlanItemLength = found.ICProductLength;
                            obj.MMBatchProductProductionNormItemProductHeight = found.ICProductHeight;
                            obj.MMBatchProductProductionNormItemProductWidth = found.ICProductWidth;
                            obj.MMBatchProductProductionNormItemProductLength = found.ICProductLength;
                            obj.FK_ICProductAttributeQualityID = found.FK_ICProductAttributeQualityID;
                            obj.FK_ICProductAttributeWoodTypeID = found.FK_ICProductAttributeWoodTypeID;
                            obj.MMAllocationPlanItemQty = 1;
                            obj.MMAllocationPlanItemWoodQty = 1;
                        }
                        obj.MMAllocationPlanItemAltFactor = 0;
                        obj.FK_ICProductID = obj.FK_ICProductAlternativeID > 0 ? obj.FK_ICProductAlternativeID : obj.FK_ICProductID;
                        obj.FK_ICProductAlternativeID = 0;
                        obj.MMAllocationPlanItemRate = 1m;
                        obj.MMAllocationPlanItemDepreciationRate = obj.MMBatchProductProductionNormItemTSHH;
                    }
                }
                //Update Qty by NORM qty
                List<MMAllocationPlanItemsInfo> itemSelectedList = itemList.Select(o => (MMAllocationPlanItemsInfo)o.Clone())
                                                                           .Where(o => o.FK_MMBatchProductProductionNormItemID == obj.FK_MMBatchProductProductionNormItemID
                                                                                       && o.FK_MMBatchProductProductionNormItemMeterialID == obj.FK_MMBatchProductProductionNormItemMeterialID
                                                                                       && o.FK_MMBatchProductItemOutSourcingID == obj.FK_MMBatchProductItemOutSourcingID
                                                                                       && o.FK_ICProductID == obj.FK_ICProductID
                                                                                       && o.FK_MMOperationID == obj.FK_MMOperationID).ToList();
                if (itemSelectedList.Count() > 0)
                {
                    decimal totalQty = itemSelectedList.Sum(o => o.MMAllocationPlanItemQty);
                    if (totalQty < obj.MMAllocationPlanItemBPQty)
                        obj.MMAllocationPlanItemQty += obj.MMAllocationPlanItemBPQty - totalQty;
                }
            });
            itemList.GridControl?.RefreshDataSource();
        }



        public void CancelAlternativeItems(BOSList<MMAllocationPlanItemsInfo> itemList, MMAllocationPlanItemsInfo obj, bool isMaterial)
        {
            if (obj.MMAllocationPlanItemStatus != Status.New.ToString())
            {
                BOSApp.ShowMessage("Trạng thái chi tiết không phù hợp");
                return;
            }
            if (obj.FK_ICProductAlternativeID > 0 || (obj.MMAllocationPlanItemRate > 0 && obj.MMAllocationPlanItemRate != 1m))
            {
                obj.MMAllocationPlanItemQty = ChangeAlternativeQty(true, obj.MMAllocationPlanItemAltFactor, obj.MMAllocationPlanItemQty, obj.MMAllocationPlanItemRate);
                ICProductsInfo found;
                if (obj.FK_ICProductAlternativeID > 0)
                    found = BOSApp.GetProductFromCurrentProductList(obj.FK_ICProductAlternativeID);
                else
                    found = BOSApp.GetProductFromCurrentProductList(obj.FK_ICProductID);

                MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
                MMAllocationPlanItemsInfo old = objAllocationPlanItemsController.GetRemainItemForAlternative(obj.Id, obj.FK_MMBatchProductProductionNormItemID, obj.FK_MMBatchProductProductionNormItemMeterialID, obj.FK_MMBatchProductItemOutSourcingID);
                if (found != null)
                {
                    obj.ICProductCode = found.ICProductCode;
                    obj.ICProductNo = found.ICProductNo;
                    obj.MMAllocationPlanItemProductName = found.ICProductName;
                    obj.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                    if (old != null)
                    {
                        obj.ICProductCode = old.ICProductCode;
                        obj.MMAllocationPlanItemProductName = old.MMAllocationPlanItemProductName;
                        obj.MMAllocationPlanItemProductDesc = old.MMAllocationPlanItemProductDesc;
                        obj.MMAllocationPlanItemHeight = old.MMAllocationPlanItemHeight;
                        obj.MMAllocationPlanItemWidth = old.MMAllocationPlanItemWidth;
                        obj.MMAllocationPlanItemLength = old.MMAllocationPlanItemLength;
                        obj.MMBatchProductProductionNormItemProductHeight = old.MMBatchProductProductionNormItemProductHeight;
                        obj.MMBatchProductProductionNormItemProductWidth = old.MMBatchProductProductionNormItemProductWidth;
                        obj.MMBatchProductProductionNormItemProductLength = old.MMBatchProductProductionNormItemProductLength;
                        obj.FK_ICProductAttributeQualityID = old.FK_ICProductAttributeQualityID;
                        obj.FK_ICMeasureUnitID = old.FK_ICMeasureUnitID;
                        obj.FK_ICProductAttributeWoodTypeID = old.FK_ICProductAttributeWoodTypeID;
                    }
                    else
                    {
                        obj.MMAllocationPlanItemHeight = found.ICProductHeight;
                        obj.MMAllocationPlanItemWidth = found.ICProductWidth;
                        obj.MMAllocationPlanItemLength = found.ICProductLength;
                        obj.MMBatchProductProductionNormItemProductHeight = found.ICProductHeight;
                        obj.MMBatchProductProductionNormItemProductWidth = found.ICProductWidth;
                        obj.MMBatchProductProductionNormItemProductLength = found.ICProductLength;
                        obj.FK_ICProductAttributeQualityID = found.FK_ICProductAttributeQualityID;
                        obj.FK_ICProductAttributeWoodTypeID = found.FK_ICProductAttributeWoodTypeID;
                        obj.MMAllocationPlanItemQty = 1;
                        obj.MMAllocationPlanItemWoodQty = 1;
                    }
                    obj.MMAllocationPlanItemAltFactor = 0;
                    obj.FK_ICProductID = obj.FK_ICProductAlternativeID > 0 ? obj.FK_ICProductAlternativeID : obj.FK_ICProductID;
                    obj.FK_ICProductAlternativeID = 0;
                    obj.MMAllocationPlanItemRate = 1m;
                    obj.MMAllocationPlanItemDepreciationRate = obj.MMBatchProductProductionNormItemTSHH;
                }
            }
            //Update Qty by NORM qty
            List<MMAllocationPlanItemsInfo> itemSelectedList = itemList.Select(o => (MMAllocationPlanItemsInfo)o.Clone())
                                                                       .Where(o => o.FK_MMBatchProductProductionNormItemID == obj.FK_MMBatchProductProductionNormItemID
                                                                                   && o.FK_MMBatchProductProductionNormItemMeterialID == obj.FK_MMBatchProductProductionNormItemMeterialID
                                                                                   && o.FK_MMBatchProductItemOutSourcingID == obj.FK_MMBatchProductItemOutSourcingID
                                                                                   && o.FK_ICProductID == obj.FK_ICProductID
                                                                                   && o.FK_MMOperationID == obj.FK_MMOperationID).ToList();
            if (itemSelectedList.Count() > 0)
            {
                decimal totalQty = itemSelectedList.Sum(o => o.MMAllocationPlanItemQty);
                if (totalQty < obj.MMAllocationPlanItemBPQty)
                    obj.MMAllocationPlanItemQty += obj.MMAllocationPlanItemBPQty - totalQty;
            }
            itemList.GridControl?.RefreshDataSource();
        }
        public bool CheckIsUseWoodPlan(int iProductID, List<MMMaterialDepartmentsInfo> MaterialDepartList)
        {
            bool result = false;

            ICProductsInfo iCProductsInfo = BOSApp.GetProductFromCurrentProductList(iProductID);
            if (iCProductsInfo != null && MaterialDepartList.Count() > 0)
            {
                MMMaterialDepartmentsInfo mMMaterialDepartmentsInfo = MaterialDepartList.Where(o => o.ICProducType == iCProductsInfo.ICProductType && o.MMMaterialIsUseWoodPlan).FirstOrDefault();
                if (mMMaterialDepartmentsInfo != null)
                {
                    result = true;
                }
            }
            return result;
        }
        public void AlternativeItems(BOSList<MMAllocationPlanItemsInfo> itemList, MMAllocationPlanItemsInfo obj, bool isMaterial, bool IsAlterOverConfigMaterial)
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();
            if (obj.MMAllocationPlanItemStatus != Status.New.ToString())
            {
                BOSApp.ShowMessage("Trạng thái chi tiết không phù hợp");
                return;
            }

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            List<ICProductAlternativesInfo> listAlter = new List<ICProductAlternativesInfo>();
            ICProductAlternativesController iCProductAlternativesController = new ICProductAlternativesController();

            DataSet ds = iCProductAlternativesController.GetAllDataByForeignColumn("FK_ICProductAlternativeParentID", obj.FK_ICProductID);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductAlternativesInfo item = (ICProductAlternativesInfo)iCProductAlternativesController.GetObjectFromDataRow(row);
                    ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductAlternativeChildID);
                    if (found != null)
                    {
                        item.ICProductAlternativeName = found.ICProductName;
                        item.ICProductHeight = found.ICProductHeight;
                        item.ICProductWidth = found.ICProductWidth;
                        item.ICProductLength = found.ICProductLength;
                        item.ICProductAlternativeNormQty = obj.MMAllocationPlanItemQty;
                        item.ICProductAlternativeProductQty = obj.MMAllocationPlanItemQty;
                        item.ICProductAlternativeCountProductQty = obj.MMBatchProductProductionNormItemQuantity;
                    }
                    listAlter.Add(item);
                }
            }
            List<MMMaterialDepartmentsInfo> MaterialDepartList = new List<MMMaterialDepartmentsInfo>();
            if (IsAlterOverConfigMaterial) MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
            guiAlternative guiFind = new guiAlternative(listAlter, (IsAlterOverConfigMaterial ? CheckIsUseWoodPlan(obj.FK_ICProductID, MaterialDepartList) : false));
            guiFind.Module = this;
            guiFind.MaterialDepartList = MaterialDepartList;
            guiFind.SourceAlternativeObj = obj;
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                if (guiFind.SelectedObjects.Count() > 0)
                {
                    ICProductAlternativesInfo select = guiFind.SelectedObjects.Where(o => o.Selected).FirstOrDefault();
                    if (select == null) return;
                    ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(select.FK_ICProductAlternativeChildID);
                    if (found != null)
                    {
                        obj.ICProductNo = found.ICProductNo;
                        obj.MMAllocationPlanItemProductName = found.ICProductName;
                        obj.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                        obj.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                        if (!IsAlterOverConfigMaterial)
                        {
                            obj.ICProductCode = found.ICProductCode;
                            obj.MMAllocationPlanItemHeight = found.ICProductHeight;
                            obj.MMAllocationPlanItemWidth = found.ICProductWidth;
                            obj.MMAllocationPlanItemLength = found.ICProductLength;
                        }
                        obj.FK_ICProductAttributeQualityID = found.FK_ICProductAttributeQualityID;
                        obj.FK_ICProductAttributeWoodTypeID = found.FK_ICProductAttributeWoodTypeID;
                        obj.FK_ICMeasureUnitID = select.FK_ICMeasureUnitID > 0 ? select.FK_ICMeasureUnitID : found.FK_ICProductBasicUnitID;
                    }
                    obj.FK_ICProductAlternativeID = obj.FK_ICProductID;
                    obj.FK_ICProductID = select.FK_ICProductAlternativeChildID;
                    obj.MMAllocationPlanItemAltFactor = select.ICProductAlternativeQty;
                    obj.MMAllocationPlanItemHeight = select.ICProductHeight;
                    obj.MMAllocationPlanItemWidth = select.ICProductWidth;
                    obj.MMAllocationPlanItemLength = select.ICProductLength;
                    if (IsAlterOverConfigMaterial)
                        obj.MMAllocationPlanItemWoodQty = select.ICProductAlternativeCountProductQty;
                    obj.MMAllocationPlanItemDepreciationRate = select.ICProductAlternativeDepreciationRate;
                    decimal oldQty = obj.MMAllocationPlanItemQty;
                    obj.MMAllocationPlanItemQty = IsAlterOverConfigMaterial ? select.ICProductAlternativeProductQty : select.ICProductAlternativeProductQty * select.ICProductAlternativeQty; // (ICProductAlternativeQty = factor)

                    if (isMaterial)
                        ChangeItemWoodQty(itemList, obj, obj.MMAllocationPlanItemQty);
                    else
                        ChangeItemQty(itemList, obj, obj.MMAllocationPlanItemQty);
                    itemList.GridControl?.RefreshDataSource();
                }
            }
        }

        public decimal ChangeAlternativeQty(bool changeToFrom, decimal factorOfFrom, decimal qty, decimal rate)
        {
            decimal result = qty;
            if (changeToFrom)
            {
                if (factorOfFrom > 0)
                    result = qty / factorOfFrom;
                if (rate > 0)
                    result = result / rate;
            }
            else
            {
                if (factorOfFrom > 0)
                    result = qty * factorOfFrom;
                if (rate > 0)
                    result = result * rate;
            }
            return Math.Round(result, 6, MidpointRounding.AwayFromZero);
        }

        public string ValidateSelectedItems(List<MMAllocationPlanItemsInfo> itemList, string group, bool isValidateInventoryStock = false)
        {
            MMAllocationPlansInfo mainobject = CurrentModuleEntity.MainObject as MMAllocationPlansInfo;
            string errorMessage = string.Empty;
            MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> remainList = pnisController.GetBPRemainQtyForAllocationPlan(mainobject.FK_MMBatchProductID, group);
            MMBatchProductProductionNormItemsInfo remainItemsInfo = new MMBatchProductProductionNormItemsInfo();
            itemList.ForEach(item =>
            {
                if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                    return;

                remainItemsInfo = remainList.Where(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                        && o.MMBatchProductProductionNormItemMeterialID == item.FK_MMBatchProductProductionNormItemMeterialID
                                                        && o.FK_MMBatchProductItemOutSourcingID == item.FK_MMBatchProductItemOutSourcingID).FirstOrDefault();
                if ((isValidateInventoryStock && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Planed.ToString()))
                {
                    errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " chưa duyệt kế hoạch.";
                    errorMessage += Environment.NewLine;
                    return;
                }
                if (remainItemsInfo != null && remainItemsInfo.MMBatchProductProductionNormItemRemainQty < item.MMAllocationPlanItemQty)
                {
                    errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " số lượng còn lại có thể kế hoạch là " + remainItemsInfo.MMBatchProductProductionNormItemRemainQty.ToString("n4");
                    errorMessage += Environment.NewLine;
                    return;
                }
                if (item.MMAllocationPlanItemQty > item.ICInventoryStockQty && isValidateInventoryStock)
                {
                    errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " không đủ tồn kho.";
                    errorMessage += Environment.NewLine;
                    return;
                }
            });
            return errorMessage;
        }

        public string ValidateSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList, string group, bool isValidateInventoryStock = false)
        {
            if (itemList.Count() == 0)
                return string.Empty;

            MMAllocationPlansInfo mainobject = CurrentModuleEntity.MainObject as MMAllocationPlansInfo;
            string errorMessage = string.Empty;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> remainList = pnisController.GetBPRemainQtyForAllocationPlan(mainobject.FK_MMBatchProductID, group);
                MMBatchProductProductionNormItemsInfo remainItemsInfo = new MMBatchProductProductionNormItemsInfo();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                        continue;

                    remainItemsInfo = remainList.Where(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                            && o.MMBatchProductProductionNormItemMeterialID == item.FK_MMBatchProductProductionNormItemMeterialID
                                                            && o.FK_MMBatchProductItemOutSourcingID == item.FK_MMBatchProductItemOutSourcingID).FirstOrDefault();

                    if ((isValidateInventoryStock && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Planed.ToString()))
                    {
                        errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " chưa duyệt kế hoạch.";
                        errorMessage += Environment.NewLine;
                    }
                    if (remainItemsInfo != null && remainItemsInfo.MMBatchProductProductionNormItemRemainQty < item.MMAllocationPlanItemQty && remainItemsInfo.MMBatchProductProductionNormItemRemainQty < ChangeAlternativeQty(true, item.MMAllocationPlanItemAltFactor, item.MMAllocationPlanItemQty, item.MMAllocationPlanItemRate))
                    {
                        errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " số lượng còn lại có thể kế hoạch là " + remainItemsInfo.MMBatchProductProductionNormItemRemainQty.ToString("n4");
                        errorMessage += Environment.NewLine;
                    }
                    if (item.MMAllocationPlanItemQty > item.ICInventoryStockQty && isValidateInventoryStock)
                    {
                        errorMessage += "Sản phẩm " + item.MMAllocationPlanItemProductDesc + " không đủ tồn kho.";
                        errorMessage += Environment.NewLine;
                    }
                }
            }
            return errorMessage;
        }


        public List<int> ApproveSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            string errorMessage = string.Empty;
            List<int> arrID = new List<int>();
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                        continue;

                    arrID.Add(item.Id);
                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Approved.ToString();
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return arrID;
        }

        public List<int> ApproveSelectedItems(List<MMAllocationPlanItemsInfo> itemList)
        {
            string errorMessage = string.Empty;
            List<int> arrID = new List<int>();
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
            itemList.ForEach(o =>
            {
                if (o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                    || o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                    || o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                    return;

                objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)objAllocationPlanItemsController.GetObjectByID(o.Id);
                if (objAllocationPlanItemsInfo == null)
                    return;

                arrID.Add(o.Id);
                o.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Approved.ToString();
                objAllocationPlanItemsInfo.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Approved.ToString();
                objAllocationPlanItemsController.UpdateObject(objAllocationPlanItemsInfo);
            });
            return arrID;
        }
        #endregion

        #region Print
        public override void ActionPrint()
        {
            base.ActionPrint();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            if (Toolbar.IsEditAction() || Toolbar.IsNewAction())
            {
                return;
            }
        }
        #endregion

        public void ChangeAllocationPlanDeliveryDate(DateTime deliveryDate)
        {
            BatchProductSheduleEntities entity = CurrentModuleEntity as BatchProductSheduleEntities;
            MMAllocationPlansInfo objAllocationPlansInfo = entity.MainObject as MMAllocationPlansInfo;

            if (deliveryDate.Date != objAllocationPlansInfo.MMAllocationPlanDeliveryDate.Date)
            {
                if (MessageBox.Show("Bạn có muốn thay đổi ngày cần cho những mặt hàng đã chọn không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                objAllocationPlansInfo.MMAllocationPlanDeliveryDate = deliveryDate;
            }
        }

        public void ChangeWorkShop(int workShopID)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            mainobject.FK_MMWorkShopID = workShopID;
            mainobject.FK_MMLineID = 0;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeLine(int lineID)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            mainobject.FK_MMLineID = lineID;
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionNewFromBatchProduct()
        {
            ActionNew();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetBatchProductForShedule(BOSApp.CurrentUsersInfo.ADUserID
                                                                                                             , ModuleName.BatchProduct
                                                                                                             , ADDataViewPermissionType.Module
                                                                                                             , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            guiChooseBatchProduct guiFind = new guiChooseBatchProduct(batchProductList);
            guiFind.IsMultiSelect = false;
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            MMBatchProductsInfo objBatchProductsInfo = guiFind.SelectedObjects.FirstOrDefault();
            if (objBatchProductsInfo == null)
                return;

            mainobject.FK_MMBatchProductID = objBatchProductsInfo.MMBatchProductID;
            mainobject.FK_ARSaleOrderID = objBatchProductsInfo.FK_ARSaleOrderID;
            mainobject.ACObjectAccessKey = objBatchProductsInfo.FK_ACObjectID + ";" + objBatchProductsInfo.MMObjectType;
            mainobject.FK_ACObjectID = objBatchProductsInfo.FK_ACObjectID;
            mainobject.MMObjectType = objBatchProductsInfo.MMObjectType;
            mainobject.FK_MMWorkShopID = objBatchProductsInfo.FK_MMWorkShopID;
            mainobject.MMAllocationPlanSOName = objBatchProductsInfo.MMBatchProductSOName;
            ChangeCurrentTabPage(CurrentTabSelected);
        }

        public void ChangeItemWoodQty(BOSList<MMAllocationPlanItemsInfo> itemList, MMAllocationPlanItemsInfo item, decimal oldItemQty)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            List<MMAllocationPlanItemsInfo> sameItemList = itemList.Select(o => (MMAllocationPlanItemsInfo)o.Clone())
                                                                               .Where(o => o.FK_MMBatchProductProductionNormItemMeterialID == item.FK_MMBatchProductProductionNormItemMeterialID).ToList();
            sameItemList.ForEach(f =>
            {
                f.MMAllocationPlanItemQty = Math.Round(ChangeAlternativeQty(true, f.MMAllocationPlanItemAltFactor, f.MMAllocationPlanItemQty, f.MMAllocationPlanItemRate), 6);
            });

            decimal sumPlanQty = sameItemList.Select(o => o.MMAllocationPlanItemQty).Sum();
            if (sumPlanQty == item.MMAllocationPlanItemBPQty
                || item.MMAllocationPlanItemQty == 0)
            {
                return;
            }
            else if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
            {
                MessageBox.Show("Sản phẩm đã kế hoạch hoặc đã duyệt! Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                item.MMAllocationPlanItemQty = oldItemQty;
                return;
            }
            else if (sumPlanQty > item.MMAllocationPlanItemBPQty)
            {
                MessageBox.Show("Số lượng kế hoạch không được lớn hơn số lượng định mức!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                item.MMAllocationPlanItemQty = oldItemQty;
                return;
            }
            MMAllocationPlanItemsInfo itemClone = (MMAllocationPlanItemsInfo)item.Clone();
            itemClone.MMAllocationPlanItemQty = item.MMAllocationPlanItemBPQty - sumPlanQty;
            if (itemClone.FK_ICProductAlternativeID > 0 && itemClone.FK_ICProductAlternativeID != itemClone.FK_ICProductID)
            {
                ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(itemClone.FK_ICProductAlternativeID);
                if (found != null)
                {
                    itemClone.ICProductCode = found.ICProductCode;
                    itemClone.ICProductNo = found.ICProductNo;
                    itemClone.MMAllocationPlanItemProductName = found.ICProductName;
                    itemClone.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                    //itemClone.MMBatchProductProductionNormItemProductName = found.ICProductName;
                    itemClone.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                    itemClone.MMAllocationPlanItemHeight = found.ICProductHeight;
                    itemClone.MMAllocationPlanItemWidth = found.ICProductWidth;
                    itemClone.MMAllocationPlanItemLength = found.ICProductLength;
                    itemClone.FK_ICProductAttributeQualityID = found.FK_ICProductAttributeQualityID;
                    itemClone.FK_ICProductAttributeWoodTypeID = found.FK_ICProductAttributeWoodTypeID;
                    itemClone.ICProductNoOfOldSys = found.ICProductNoOfOldSys;
                    itemClone.MMAllocationPlanItemAltFactor = 1;
                    itemClone.FK_ICProductID = itemClone.FK_ICProductAlternativeID;
                }
            }
            itemClone.MMAllocationPlanItemDeliveryDate = DateTime.MaxValue;
            itemClone.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
            itemClone.Id = 0;
            itemList.Add(itemClone);
            itemList.GridControl?.RefreshDataSource();
        }

        public void ChangeItemQty(BOSList<MMAllocationPlanItemsInfo> itemList, MMAllocationPlanItemsInfo item, decimal oldItemQty)
        {

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            List<MMAllocationPlanItemsInfo> sameItemList = itemList.Select(o => (MMAllocationPlanItemsInfo)o.Clone())
                                                                               .Where(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID).ToList();

            sameItemList.ForEach(f =>
            {
                f.MMAllocationPlanItemQty = ChangeAlternativeQty(true, f.MMAllocationPlanItemAltFactor, f.MMAllocationPlanItemQty, f.MMAllocationPlanItemRate);
            });

            decimal sumPlanQty = sameItemList.Select(o => o.MMAllocationPlanItemQty).Sum();
            if (sumPlanQty == item.MMAllocationPlanItemBPQty
                || item.MMAllocationPlanItemQty == 0)
            {
                return;
            }
            else if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
            {
                MessageBox.Show("Sản phẩm đã kế hoạch hoặc đã duyệt! Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                item.MMAllocationPlanItemQty = oldItemQty;
                return;
            }
            else if (sumPlanQty > item.MMAllocationPlanItemBPQty)
            {
                MessageBox.Show("Số lượng kế hoạch không được lớn hơn số lượng định mức!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                item.MMAllocationPlanItemQty = oldItemQty;
                return;
            }
            MMAllocationPlanItemsInfo itemClone = (MMAllocationPlanItemsInfo)item.Clone();
            itemClone.MMAllocationPlanItemQty = item.MMAllocationPlanItemBPQty - sumPlanQty;
            if (itemClone.FK_ICProductAlternativeID > 0 && itemClone.FK_ICProductAlternativeID != itemClone.FK_ICProductID)
            {
                ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(itemClone.FK_ICProductAlternativeID);
                if (found != null)
                {
                    itemClone.ICProductCode = found.ICProductCode;
                    itemClone.ICProductNo = found.ICProductNo;
                    itemClone.MMAllocationPlanItemProductName = found.ICProductName;
                    itemClone.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                    //itemClone.MMBatchProductProductionNormItemProductName = found.ICProductName;
                    itemClone.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                    itemClone.MMAllocationPlanItemHeight = found.ICProductHeight;
                    itemClone.MMAllocationPlanItemWidth = found.ICProductWidth;
                    itemClone.MMAllocationPlanItemLength = found.ICProductLength;
                    itemClone.FK_ICProductAttributeQualityID = found.FK_ICProductAttributeQualityID;
                    itemClone.FK_ICProductAttributeWoodTypeID = found.FK_ICProductAttributeWoodTypeID;
                    itemClone.MMAllocationPlanItemAltFactor = 1;
                    itemClone.FK_ICProductID = itemClone.FK_ICProductAlternativeID;
                }
            }
            itemClone.MMAllocationPlanItemDeliveryDate = DateTime.MaxValue;
            itemClone.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
            itemClone.Id = 0;
            itemList.Add(itemClone);
            itemList.GridControl?.RefreshDataSource();
        }

        public void UpdateItemDate(DateTime planDate)
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;

            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    UpdateItemDate(entity.BPProductionNormItemMaterialList, planDate);
                    break;
                case "fld_tabOtherMaterial":
                    UpdateItemDate(entity.BPProductionNormItemOtherMaterialList, planDate);
                    break;
                case "fld_tabHardware":
                    UpdateItemDate(entity.BPProductionNormItemHardwareList, planDate);
                    break;
                case "fld_tabIngredientPaint":
                    UpdateItemDate(entity.BPProductionNormItemPaintList, planDate);
                    break;
                case "fld_tabIngredientPackaging":
                    UpdateItemDate(entity.BPProductionNormItemPackagingList, planDate);
                    break;
                case "fld_tabGeneralMaterial":
                    UpdateItemDate(entity.BPProductionNormItemInstrumentList, planDate);
                    break;
                case "fld_tabSemiProduct":
                    UpdateItemDate(entity.BPProductionNormItemSemiProductList, planDate);
                    break;
            }
        }

        public void UpdateItemDate(BOSList<MMAllocationPlanItemsInfo> itemList, DateTime planDate)
        {
            if (itemList == null)
                return;

            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString()
                        && !string.IsNullOrEmpty(item.MMAllocationPlanItemStatus))
                        continue;

                    item.MMAllocationPlanItemDeliveryDate = planDate;
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
        }

        public void UpdateItemInfo()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    UpdateItemInfo(entity.BPProductionNormItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    UpdateItemInfo(entity.BPProductionNormItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    UpdateItemInfo(entity.BPProductionNormItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    UpdateItemInfo(entity.BPProductionNormItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    UpdateItemInfo(entity.BPProductionNormItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    UpdateItemInfo(entity.BPProductionNormItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    UpdateItemInfo(entity.BPProductionNormItemSemiProductList);
                    break;
            }
        }

        public void UpdateItemInfo(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            if (itemList == null)
                return;

            int lineID = LineControl == null ? 0 : LineControl.EditValue == null ? 0 : (int)LineControl.EditValue;
            int workShopID = WorkShopControl == null ? 0 : WorkShopControl.EditValue == null ? 0 : (int)WorkShopControl.EditValue;
            int departmentRoomGroupItemID = DepartmentRoomGroupItemControl == null ? 0 : DepartmentRoomGroupItemControl.EditValue == null ? 0 : (int)DepartmentRoomGroupItemControl.EditValue;
            int employeeReceiveID = EmployeeReceiveControl == null ? 0 : EmployeeReceiveControl.EditValue == null ? 0 : (int)EmployeeReceiveControl.EditValue;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString()
                        && !string.IsNullOrEmpty(item.MMAllocationPlanItemStatus))
                        continue;

                    item.FK_MMLineID = lineID;
                    item.FK_MMWorkShopID = workShopID;
                    item.FK_HRDepartmentRoomGroupItemID = departmentRoomGroupItemID;
                    item.FK_HREmployeeIDReceive = employeeReceiveID;
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
        }

        public void MergeSameGroupItems(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            List<MMAllocationPlanItemsInfo> itemSelectedList = new List<MMAllocationPlanItemsInfo>();
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    itemSelectedList.Add(item);
                }
                if (itemSelectedList.Count() < 2)
                    return;

                if (itemSelectedList.Select(o => new
                {
                    o.FK_MMBatchProductProductionNormItemID,
                    o.FK_MMBatchProductProductionNormItemMeterialID,
                    o.FK_MMBatchProductItemOutSourcingID,
                    o.FK_ICProductID,
                }).Distinct().Count() > 1)
                {
                    MessageBox.Show("Các sản phẩm đã chọn không cùng chi tiết. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (itemSelectedList.Select(o => o.MMAllocationPlanItemStatus).Distinct().Count() > 1)
                {
                    MessageBox.Show("Các sản phẩm đã chọn không cùng trạng thái kế hoạch. Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn gộp số lượng các vật tư đã chọn không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.Yes)
                    return;

                decimal sumPlanQty = itemSelectedList.Sum(o => o.MMAllocationPlanItemQty);
                MMAllocationPlanItemsInfo firstItem = itemSelectedList.FirstOrDefault();
                firstItem.MMAllocationPlanItemQty = sumPlanQty;
                itemSelectedList.Remove(firstItem);
                itemSelectedList.ForEach(o =>
                {
                    entity.MergeRemoveList.Add(o);
                    itemList.Remove(o);
                });
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
                itemList.GridView?.ClearSelection();
            }
        }

        public void ShowOperationDetailPlan()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(mainobject.FK_MMBatchProductID);
            if (objBatchProductsInfo == null)
                objBatchProductsInfo = new MMBatchProductsInfo();

            guiShowOperationDetailPlanMaterial guiFind = new guiShowOperationDetailPlanMaterial(mainobject.FK_MMBatchProductID, 0, 0, 0, objBatchProductsInfo.MMBatchProductDate);
            guiFind.Module = this;
            guiFind.ShowDialog();
        }

        public void ChangeDepartmentRoomGroupItem(int departmentRoomGroupItemID)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            mainobject.FK_HRDepartmentRoomGroupItemID = departmentRoomGroupItemID;
            entity.UpdateMainObjectBindingSource();
        }

        public void AddMaterialNotNorm()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;

            string productGroup = string.Empty;
            guiAddMaterialOverBOM guiFind = new guiAddMaterialOverBOM();
            guiFind.Module = this;
            guiFind.BatchProductID = mainobject.FK_MMBatchProductID;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            Invalidate(mainobject.MMAllocationPlanID);
        }

        public void RemoveItemFromList(BOSList<MMAllocationPlanItemsInfo> itemList, string group)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlanItemsInfo item = itemList[itemList.CurrentIndex];
            if (item == null || (item != null && item.MMBatchProductProductionNormItemType != "OverBOM"))
                return;

            if (group == AllocationPlanItemGroup.OtherMaterial.ToString()
                || group == AllocationPlanItemGroup.Material.ToString())
            {
                entity.BPProductionNormItemMaterialOutOfNorm.RemoveAll(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID && o.FK_ICProductID == o.FK_ICProductID);
            }
            else
            {
                entity.BPProductionNormItemOutOfNorm.RemoveAll(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                    && o.FK_ICProductID == o.FK_ICProductID
                                                                    && o.MMBatchProductProductionNormItemGroup == group);
            }
            entity.MergeRemoveList.Add(item);
            itemList.RemoveSelectedRowObjectFromList();
        }

        public List<MMWorkShopsInfo> GetDataSourceForWorkShopByCurrentBranch()
        {
            List<MMWorkShopsInfo> workShops = (new MMWorkShopsController()).GetDataSourceForWorkShopByCurrentBranch(BOSApp.CurrentUsersInfo.ADUserID
                                                                                        , ModuleName.WorkShop
                                                                                        , ADDataViewPermissionType.Module
                                                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (workShops != null)
                workShops.Insert(0, new MMWorkShopsInfo());
            return workShops;
        }

        public List<HRDepartmentRoomGroupItemsInfo> GetDataSourceForDepartmentRoomGroupItemByCurrentBranch()
        {
            List<HRDepartmentRoomGroupItemsInfo> departmentRoomGroupItems = (new HRDepartmentRoomGroupItemsController()).GetDataSourceForDepartmentRoomGroupItemByCurrentBranch(
                                                                                          BOSApp.CurrentUsersInfo.ADUserID
                                                                                        , ModuleName.WorkShop
                                                                                        , ADDataViewPermissionType.Module
                                                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (departmentRoomGroupItems != null)
                departmentRoomGroupItems.Insert(0, new HRDepartmentRoomGroupItemsInfo());
            return departmentRoomGroupItems;
        }

        public List<ICProductsInfo> GetWoodIngredient(List<MMMaterialDepartmentsInfo> MaterialDepartList)
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = new List<ICProductsInfo>();
            objProductsInfoList.Add(new ICProductsInfo());
            List<ICProductsInfo> dataList = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = new List<ICProductsForViewInfo>();
            if (MaterialDepartList != null)
            {
                productViewList = BOSApp.CurrentProductList.Where(o => MaterialDepartList.Any(dp => dp.FK_ICDepartmentID == o.FK_ICDepartmentID
                                                                    && (dp.ICProducType == string.Empty || (dp.ICProducType == o.ICProductType)
                                                                        || (dp.MMMaterialDepartmentOtherCol1.Contains(o.ICProductType)))
                )).ToList();
            }
            else
                productViewList = BOSApp.CurrentProductList.Where(o => o.FK_ICDepartmentID == DepartmentID.Wood).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                dataList.Add(newObj);
            });
            if (dataList != null)
                objProductsInfoList.AddRange(dataList);

            return objProductsInfoList;
        }

        public void ClosePlanItem()
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn đóng kế hoạch các vật tư đã chọn?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> remainList = objAllocationPlanItemsController.GetItemForCloseByAllocationPlanID(mainobject.MMAllocationPlanID);
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    CloseSelectedItems(entity.BPProductionNormItemMaterialList, remainList, AllocationPlanItemGroup.Material.ToString());
                    entity.BPProductionNormItemMaterialList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabOtherMaterial":
                    CloseSelectedItems(entity.BPProductionNormItemOtherMaterialList, remainList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    entity.BPProductionNormItemOtherMaterialList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabHardware":
                    CloseSelectedItems(entity.BPProductionNormItemHardwareList, remainList, AllocationPlanItemGroup.Hardware.ToString());
                    entity.BPProductionNormItemHardwareList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabIngredientPaint":
                    CloseSelectedItems(entity.BPProductionNormItemPaintList, remainList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    entity.BPProductionNormItemPaintList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabIngredientPackaging":
                    CloseSelectedItems(entity.BPProductionNormItemPackagingList, remainList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    entity.BPProductionNormItemPackagingList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabGeneralMaterial":
                    CloseSelectedItems(entity.BPProductionNormItemInstrumentList, remainList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    entity.BPProductionNormItemInstrumentList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabSemiProduct":
                    CloseSelectedItems(entity.BPProductionNormItemSemiProductList, remainList, AllocationPlanItemGroup.SemiProduct.ToString());
                    entity.BPProductionNormItemSemiProductList.GridControl?.RefreshDataSource();
                    break;
            }
            objAllocationPlanItemsController.AdjustPostedAllocationPlanItems(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID);
        }

        public void CloseSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList, List<MMAllocationPlanItemsInfo> remainList, string itemGroup)
        {
            if (itemList.Count() == 0)
                return;

            List<int> unPostedIds = new List<int>();
            List<int> rePostedIds = new List<int>();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();

                MMAllocationPlanItemsInfo remainItemsInfo = new MMAllocationPlanItemsInfo();
                MMAllocationPlanItemsInfo newItemsInfo = new MMAllocationPlanItemsInfo();
                List<MMAllocationPlanItemsInfo> canceledNewList = new List<MMAllocationPlanItemsInfo>();

                decimal bpProductQty = 0;
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Canceled.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString())
                        continue;

                    bpProductQty = item.MMAllocationPlanItemBPQty;
                    remainItemsInfo = remainList.Where(o => o.Id == item.Id).FirstOrDefault();
                    if (remainItemsInfo == null || (remainItemsInfo != null && remainItemsInfo.MMAllocationProposalItemShippedQty == 0))
                    {
                        item.MMAllocationPlanItemPostedAction = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? "ClosePlan" : string.Empty;
                        item.MMAllocationPlanItemReference = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? item.Id.ToString() : string.Empty;
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Canceled.ToString();
                        unPostedIds.Add(item.Id);
                    }
                    else
                    {
                        if (remainItemsInfo.MMAllocationProposalItemShippedQty < bpProductQty)
                        {
                            newItemsInfo = new MMAllocationPlanItemsInfo();
                            newItemsInfo = (MMAllocationPlanItemsInfo)item.Clone();
                            newItemsInfo.Id = 0;
                            newItemsInfo.MMAllocationPlanItemQty = item.MMAllocationPlanItemQty - remainItemsInfo.MMAllocationProposalItemShippedQty;
                            newItemsInfo.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Canceled.ToString();
                            newItemsInfo.MMAllocationPlanItemReference = item.Id.ToString();
                            newItemsInfo.MMAllocationPlanItemPostedAction = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? "ClosePlan" : string.Empty;
                            if (newItemsInfo.MMAllocationPlanItemQty > 0.00001m)
                                canceledNewList.Add(newItemsInfo);
                            item.MMAllocationPlanItemQty = remainItemsInfo.MMAllocationProposalItemShippedQty;
                            rePostedIds.Add(item.Id);
                        }
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Approved.ToString();
                    }
                }
                itemList.AddRange(canceledNewList);
                entity.SaveAllocationPlanItems(itemList, itemGroup);
            }
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, rePostedIds);
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, unPostedIds, false);
        }

        public void CloseAllocationPlan()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muón đóng kế hoạch này không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            entity.SetDefaultModuleObjectsList();

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();

            BOSProgressBar.Start("Đang cập khởi tạo dữ liệu định mức");
            List<MMAllocationPlanItemsInfo> remainList = objAllocationPlanItemsController.GetItemForCloseByAllocationPlanID(mainobject.MMAllocationPlanID);

            InvalidateItemMaterialData(entity.BPProductionNormItemMaterialList, "fld_tabMaterial", AllocationPlanItemGroup.Material.ToString(), true);
            BOSProgressBar.Start("Đang cập nhập định mức NL chính");
            CloseItems(entity.BPProductionNormItemMaterialList, remainList, AllocationPlanItemGroup.Material.ToString());

            InvalidateItemMaterialData(entity.BPProductionNormItemOtherMaterialList, "fld_tabOtherMaterial", AllocationPlanItemGroup.OtherMaterial.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức NL phụ");
            CloseItems(entity.BPProductionNormItemOtherMaterialList, remainList, AllocationPlanItemGroup.OtherMaterial.ToString());

            InvalidateItemData(entity.BPProductionNormItemHardwareList, "fld_tabHardware", AllocationPlanItemGroup.Hardware.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức Hardware");
            CloseItems(entity.BPProductionNormItemHardwareList, remainList, AllocationPlanItemGroup.Hardware.ToString());

            InvalidateItemData(entity.BPProductionNormItemPaintList, "fld_tabIngredientPaint", AllocationPlanItemGroup.IngredientPaint.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức Sơn");
            CloseItems(entity.BPProductionNormItemPaintList, remainList, AllocationPlanItemGroup.IngredientPaint.ToString());

            InvalidateItemData(entity.BPProductionNormItemPackagingList, "fld_tabIngredientPackaging", AllocationPlanItemGroup.IngredientPackaging.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức PLĐG");
            CloseItems(entity.BPProductionNormItemPackagingList, remainList, AllocationPlanItemGroup.IngredientPackaging.ToString());

            InvalidateItemData(entity.BPProductionNormItemInstrumentList, "fld_tabGeneralMaterial", AllocationPlanItemGroup.GeneralMaterial.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức Vật tư khác");
            CloseItems(entity.BPProductionNormItemInstrumentList, remainList, AllocationPlanItemGroup.GeneralMaterial.ToString());

            InvalidateItemSemiProductData(entity.BPProductionNormItemSemiProductList, "fld_tabSemiProduct", true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức BTP");
            CloseItems(entity.BPProductionNormItemSemiProductList, remainList, AllocationPlanItemGroup.SemiProduct.ToString());
            BOSProgressBar.Close();

            entity.SetPropertyChangeEventLock(false);
            mainobject.MMAllocationPlanStatus = AllocationPlanStatus.Close.ToString();
            entity.UpdateMainObjectBindingSource();
            entity.UpdateMainObject();
            UpdateBatchProductStatus();
            ClearGridControlSection();
            entity.SetPropertyChangeEventLock(true);
            Invalidate(mainobject.MMAllocationPlanID);
            InvalidateToolbar();
        }

        public void UpdateBatchProductStatus()
        {
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(mainobject.FK_MMBatchProductID);
            if (objBatchProductsInfo == null)
                return;

            objBatchProductsInfo.MMBatchProductHWStatus = BatchProductStatus.Closed.ToString();
            objBatchProductsInfo.MMBatchProductPackagingStatus = BatchProductStatus.Closed.ToString();
            objBatchProductsInfo.MMBatchProductPaintStatus = BatchProductStatus.Closed.ToString();
            objBatchProductsInfo.MMBatchProductGeneralMaterialStatus = BatchProductStatus.Closed.ToString();
            objBatchProductsController.UpdateObject(objBatchProductsInfo);
        }

        public void CloseItems(BOSList<MMAllocationPlanItemsInfo> itemList, List<MMAllocationPlanItemsInfo> remainList, string itemGroup)
        {
            if (itemList.Count() == 0)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;

            List<int> unPostedIds = new List<int>();
            List<int> rePostedIds = new List<int>();
            MMAllocationPlanItemsInfo remainItemsInfo = new MMAllocationPlanItemsInfo();
            MMAllocationPlanItemsInfo newItemsInfo = new MMAllocationPlanItemsInfo();
            List<MMAllocationPlanItemsInfo> canceledNewList = new List<MMAllocationPlanItemsInfo>();
            decimal bpProductQty = 0;
            itemList.ForEach(item =>
            {
                if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Canceled.ToString()
                    || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString())
                    return;

                bpProductQty = item.MMAllocationPlanItemBPQty;
                remainItemsInfo = remainList.Where(o => o.Id == item.Id).FirstOrDefault();
                if (remainItemsInfo == null || (remainItemsInfo != null && remainItemsInfo.MMAllocationProposalItemShippedQty == 0))
                {
                    item.MMAllocationPlanItemPostedAction = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? "ClosePlan" : string.Empty;
                    item.MMAllocationPlanItemReference = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? item.Id.ToString() : string.Empty;
                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Canceled.ToString();
                    unPostedIds.Add(item.Id);
                }
                else
                {
                    if (remainItemsInfo.MMAllocationProposalItemShippedQty < bpProductQty)
                    {
                        newItemsInfo = new MMAllocationPlanItemsInfo();
                        newItemsInfo = (MMAllocationPlanItemsInfo)item.Clone();
                        newItemsInfo.Id = 0;
                        newItemsInfo.MMAllocationPlanItemQty = item.MMAllocationPlanItemQty - remainItemsInfo.MMAllocationProposalItemShippedQty;
                        newItemsInfo.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Canceled.ToString();
                        newItemsInfo.MMAllocationPlanItemReference = item.Id.ToString();
                        newItemsInfo.MMAllocationPlanItemPostedAction = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? "ClosePlan" : string.Empty;
                        canceledNewList.Add(newItemsInfo);
                        item.MMAllocationPlanItemQty = remainItemsInfo.MMAllocationProposalItemShippedQty;
                        rePostedIds.Add(item.Id);
                    }
                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Allocated.ToString();
                }

            });
            itemList.AddRange(canceledNewList);
            entity.SaveAllocationPlanItems(itemList, itemGroup);
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, rePostedIds);
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, unPostedIds, false);
        }

        public void UpdateAllocationPlanWithChangeBOM()
        {
            UpdateAllocationPlanWithChangeBOM(true);
        }

        public void UpdateAllocationPlanWithChangeBOM(bool isShowWarning)
        {
            if (isShowWarning)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi định mức cho kế hoạch này không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.Yes)
                    return;
            }
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;

            BOSProgressBar.Start("Đang cập nhập định mức NL chính");
            InvalidateItemMaterialData(entity.BPProductionNormItemMaterialList, "fld_tabMaterial", AllocationPlanItemGroup.Material.ToString(), true);
            SynsAllocationPlanItem(entity.BPProductionNormItemMaterialList);
            entity.SaveAllocationPlanItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());

            InvalidateItemMaterialData(entity.BPProductionNormItemOtherMaterialList, "fld_tabOtherMaterial", AllocationPlanItemGroup.OtherMaterial.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức NL phụ");
            SynsAllocationPlanItem(entity.BPProductionNormItemOtherMaterialList);
            entity.SaveAllocationPlanItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());

            InvalidateItemData(entity.BPProductionNormItemHardwareList, "fld_tabHardware", AllocationPlanItemGroup.Hardware.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức Hardware");
            SynsAllocationPlanItem(entity.BPProductionNormItemHardwareList);
            entity.SaveAllocationPlanItems(entity.BPProductionNormItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());

            InvalidateItemData(entity.BPProductionNormItemPaintList, "fld_tabIngredientPaint", AllocationPlanItemGroup.IngredientPaint.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức Sơn");
            SynsAllocationPlanItem(entity.BPProductionNormItemPaintList);
            entity.SaveAllocationPlanItems(entity.BPProductionNormItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());

            InvalidateItemData(entity.BPProductionNormItemPackagingList, "fld_tabIngredientPackaging", AllocationPlanItemGroup.IngredientPackaging.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức PLĐG");
            SynsAllocationPlanItem(entity.BPProductionNormItemPackagingList);
            entity.SaveAllocationPlanItems(entity.BPProductionNormItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());

            InvalidateItemData(entity.BPProductionNormItemInstrumentList, "fld_tabGeneralMaterial", AllocationPlanItemGroup.GeneralMaterial.ToString(), true);
            BOSProgressBar.SetDescription("Đang cập nhập định mức Vật tư khác");
            SynsAllocationPlanItem(entity.BPProductionNormItemInstrumentList);
            entity.SaveAllocationPlanItems(entity.BPProductionNormItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
            UpdateChangeNorm(mainobject.FK_MMBatchProductID);
            Invalidate(mainobject.MMAllocationPlanID);
            BOSProgressBar.Close();
        }

        public void SynsAllocationPlanItem(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            if (itemList.Count() == 0)
                return;

            List<MMAllocationPlanItemsInfo> addNewList = new List<MMAllocationPlanItemsInfo>();
            decimal bpProductQty = 0;
            itemList.ForEach(item =>
            {
                bpProductQty = item.MMAllocationPlanItemBPQty;

                List<MMAllocationPlanItemsInfo> sameItemList = itemList.Select(o => (MMAllocationPlanItemsInfo)o.Clone())
                                                                       .Where(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                                    && o.FK_MMBatchProductProductionNormItemMeterialID == item.FK_MMBatchProductProductionNormItemMeterialID
                                                                                     && o.FK_MMBatchProductItemOutSourcingID == item.FK_MMBatchProductItemOutSourcingID).ToList();

                sameItemList.AddRange(addNewList.Select(o => (MMAllocationPlanItemsInfo)o.Clone())
                                                .Where(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                            && o.FK_MMBatchProductProductionNormItemMeterialID == item.FK_MMBatchProductProductionNormItemMeterialID
                                                            && o.FK_MMBatchProductItemOutSourcingID == item.FK_MMBatchProductItemOutSourcingID).ToList());

                decimal sumPlanQty = sameItemList.Select(o => o.MMAllocationPlanItemQty).Sum();
                sameItemList.ForEach(f =>
                {
                    f.MMAllocationPlanItemQty = Math.Round(ChangeAlternativeQty(true, f.MMAllocationPlanItemAltFactor, f.MMAllocationPlanItemQty, f.MMAllocationPlanItemRate), 6);
                });

                if (bpProductQty > sumPlanQty)
                {
                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.New.ToString() || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Canceled.ToString())
                    {
                        item.MMAllocationPlanItemQty += (bpProductQty - sumPlanQty);
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
                    }
                    else
                    {
                        MMAllocationPlanItemsInfo itemClone = (MMAllocationPlanItemsInfo)item.Clone();
                        itemClone.Id = 0;
                        itemClone.MMAllocationPlanItemQty = bpProductQty - sumPlanQty;
                        itemClone.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
                        itemClone.MMAllocationPlanItemDeliveryDate = DateTime.MaxValue;
                        if (itemClone.FK_ICProductAlternativeID > 0 && itemClone.FK_ICProductAlternativeID != itemClone.FK_ICProductID)
                        {
                            ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(itemClone.FK_ICProductAlternativeID);
                            if (found != null)
                            {
                                itemClone.ICProductCode = found.ICProductCode;
                                itemClone.ICProductNo = found.ICProductNo;
                                itemClone.MMAllocationPlanItemProductName = found.ICProductName;
                                itemClone.MMAllocationPlanItemProductDesc = found.ICProductDesc;
                                itemClone.MMAllocationPlanItemHeight = found.ICProductHeight;
                                itemClone.MMAllocationPlanItemWidth = found.ICProductWidth;
                                itemClone.MMAllocationPlanItemLength = found.ICProductLength;
                                itemClone.FK_ICProductAttributeQualityID = found.FK_ICProductAttributeQualityID;
                                itemClone.FK_ICProductAttributeWoodTypeID = found.FK_ICProductAttributeWoodTypeID;
                                itemClone.MMAllocationPlanItemAltFactor = 0;
                                itemClone.FK_ICProductID = itemClone.FK_ICProductAlternativeID;
                            }
                        }
                        addNewList.Add(itemClone);
                    }
                }
                else
                {

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.New.ToString() || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Canceled.ToString())
                    {
                        item.MMAllocationPlanItemQty -= (sumPlanQty - bpProductQty);
                        item.MMAllocationPlanItemQty = item.MMAllocationPlanItemQty < 0 ? 0 : item.MMAllocationPlanItemQty;
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
                    }
                    else
                    {
                        decimal subQty = sumPlanQty - bpProductQty;
                        List<MMAllocationPlanItemsInfo> updateList = itemList.Where(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                                             && o.FK_MMBatchProductProductionNormItemMeterialID == item.FK_MMBatchProductProductionNormItemMeterialID
                                                                                             && o.FK_MMBatchProductItemOutSourcingID == item.FK_MMBatchProductItemOutSourcingID
                                                                                             && o.MMAllocationPlanItemStatus == AllocationPlanItemStatus.New.ToString()).ToList();
                        updateList.ForEach(o =>
                        {
                            if (subQty == 0)
                                return;

                            item.MMAllocationPlanItemQty -= subQty;
                            item.MMAllocationPlanItemQty = item.MMAllocationPlanItemQty < 0 ? 0 : item.MMAllocationPlanItemQty;
                            subQty -= item.MMAllocationPlanItemQty;
                            item.MMAllocationPlanItemQty = ChangeAlternativeQty(true, o.MMAllocationPlanItemAltFactor, o.MMAllocationPlanItemQty, o.MMAllocationPlanItemRate);
                        });
                    }
                }
            });
            if (addNewList.Any())
            {
                itemList.AddRange(addNewList);
            }

            itemList.GridControl?.RefreshDataSource();
        }

        public void AllocationQty(BOSList<MMAllocationPlanItemsInfo> itemList, decimal totalQty, bool isRate, int roundNum)
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            decimal rateQty = 0;
            List<MMAllocationPlanItemsInfo> selectedList = new List<MMAllocationPlanItemsInfo>();
            if (itemList.GridControl == null || (itemList.GridControl != null && itemList.GridControl.MainView == null))
                return;

            GridView gridView = (GridView)itemList.GridControl.MainView;
            int[] rowSelected = gridView.GetSelectedRows();
            foreach (int i in rowSelected)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                if (item == null || i < 0)
                    continue;

                selectedList.Add(item);
            }

            int countItem = selectedList.Count();
            if (countItem == 0)
                return;

            List<MMAllocationPlanItemsInfo> newItemList = new List<MMAllocationPlanItemsInfo>();
            MMAllocationPlanItemsInfo itemClone = new MMAllocationPlanItemsInfo();
            decimal oldValue = 0;
            if (!isRate)
            {
                selectedList.ForEach(o =>
                {
                    if (totalQty == 0)
                        return;

                    oldValue = o.MMAllocationPlanItemQty;
                    o.MMAllocationPlanItemQty = totalQty;
                    o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty > oldValue ? oldValue : o.MMAllocationPlanItemQty;
                    o.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                    totalQty -= o.MMAllocationPlanItemQty;

                    if (oldValue - o.MMAllocationPlanItemQty > 0)
                    {
                        itemClone = new MMAllocationPlanItemsInfo();
                        itemClone = (MMAllocationPlanItemsInfo)o.Clone();
                        itemClone.Id = 0;
                        itemClone.MMAllocationPlanItemQty = oldValue - o.MMAllocationPlanItemQty;
                        itemClone.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
                        newItemList.Add(itemClone);
                    }

                });
                itemList.AddRange(newItemList);
                itemList.GridControl?.RefreshDataSource();
                return;
            }

            decimal sumNormQty = selectedList.Sum(o => o.MMAllocationPlanItemQty);
            int indexItem = 1;
            decimal allocatedQty = 0;
            selectedList.ForEach(o =>
            {
                oldValue = o.MMAllocationPlanItemQty;
                rateQty = oldValue / sumNormQty;
                o.MMAllocationPlanItemQty = Math.Round(totalQty * rateQty, roundNum, MidpointRounding.AwayFromZero);
                o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty > oldValue ? oldValue : o.MMAllocationPlanItemQty;
                allocatedQty += o.MMAllocationPlanItemQty;
                if (indexItem == countItem)
                {
                    o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty + (totalQty - allocatedQty);
                    o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty > oldValue ? oldValue : o.MMAllocationPlanItemQty;
                }
                o.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                if (oldValue - o.MMAllocationPlanItemQty > 0)
                {
                    itemClone = new MMAllocationPlanItemsInfo();
                    itemClone = (MMAllocationPlanItemsInfo)o.Clone();
                    itemClone.Id = 0;
                    itemClone.MMAllocationPlanItemQty = oldValue - o.MMAllocationPlanItemQty;
                    itemClone.MMAllocationPlanItemStatus = AllocationPlanItemStatus.New.ToString();
                    newItemList.Add(itemClone);
                }
                indexItem++;
            });
            itemList.AddRange(newItemList);
            itemList.GridControl?.RefreshDataSource();
        }

        public void AlternativeMulti(BOSList<MMAllocationPlanItemsInfo> itemList, List<MMAllocationPlanItemsInfo> selectedList, List<MMAllocationPlanItemsInfo> resultAlt, ICProductAlternativesInfo altProduct, bool isMaterial = false)
        {
            string[] arrPlanItemRef = resultAlt.Select(o => o.VirtualID).ToArray();
            MMAllocationPlanItemsInfo item = new MMAllocationPlanItemsInfo();
            selectedList.ForEach(o =>
            {
                if (!arrPlanItemRef.Contains(o.VirtualID))
                    return;

                if (altProduct.IsChangeAlternativeProduct)
                {
                    o.FK_ICProductAlternativeID = o.FK_ICProductID;
                    o.FK_ICProductID = altProduct.FK_ICProductAlternativeChildID;
                    o.MMAllocationPlanItemHeight = altProduct.ICProductHeight;
                    o.MMAllocationPlanItemWidth = altProduct.ICProductWidth;
                    o.MMAllocationPlanItemLength = altProduct.ICProductLength;
                    o.ICProductNo = altProduct.ICProductNo;
                    o.MMAllocationPlanItemProductName = altProduct.ICProductAlternativeName;
                    o.MMAllocationPlanItemProductDesc = altProduct.ICProductAlternativeDesc;
                }
                item = resultAlt.Where(pli => pli.VirtualID == o.VirtualID).FirstOrDefault();
                o.MMAllocationPlanItemAltFactor = item.MMAllocationPlanItemAltFactor;
                o.MMAllocationPlanItemDepreciationRate = item.MMAllocationPlanItemDepreciationRate;
                o.MMAllocationPlanItemRate = item.MMAllocationPlanItemRate;
                o.MMAllocationPlanItemQty = item.ICProductAlternativeProductQty;
                if (isMaterial)
                    ChangeItemWoodQty(itemList, o, o.MMAllocationPlanItemQty);
                else
                    ChangeItemQty(itemList, o, o.MMAllocationPlanItemQty);
            });
            itemList.GridControl?.RefreshDataSource();
        }

        public void ChangeCurrentTabPage(string tabName)
        {
            if (string.IsNullOrWhiteSpace(tabName) || SelectionSelectedTabs == null)
                return;

            CurrentTabSelected = tabName;
            BOSProgressBar.Start("Đang khởi tạo dữ liệu");
            LazyLoadAllocationPlanItem(tabName);
            BOSProgressBar.Close();
            if (!SelectionSelectedTabs.Contains(tabName))
                SelectionSelectedTabs.Add(tabName);
        }

        public void LazyLoadAllocationPlanItem(string tabName)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            string materialTypeName = tabName.Replace("fld_tab", "");
            switch (tabName)
            {
                case "fld_tabMaterial":
                    InvalidateItemMaterialData(entity.BPProductionNormItemMaterialList, tabName, materialTypeName);
                    break;
                case "fld_tabOtherMaterial":
                    InvalidateItemMaterialData(entity.BPProductionNormItemOtherMaterialList, tabName, materialTypeName);
                    break;
                case "fld_tabHardware":
                    InvalidateItemData(entity.BPProductionNormItemHardwareList, tabName, materialTypeName);
                    break;
                case "fld_tabIngredientPaint":
                    InvalidateItemData(entity.BPProductionNormItemPaintList, tabName, materialTypeName);
                    break;
                case "fld_tabIngredientPackaging":
                    InvalidateItemData(entity.BPProductionNormItemPackagingList, tabName, materialTypeName);
                    break;
                case "fld_tabGeneralMaterial":
                    InvalidateItemData(entity.BPProductionNormItemInstrumentList, tabName, materialTypeName);
                    break;
                case "fld_tabSemiProduct":
                    InvalidateItemSemiProductData(entity.BPProductionNormItemSemiProductList, tabName);
                    break;
            }
        }

        public void InvalidateItemMaterialData(BOSList<MMAllocationPlanItemsInfo> itemList, string tabName, string itemGroup, bool isRefresh = false)
        {
            if (SelectionSelectedTabs.Contains(tabName) && !isRefresh)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            MMAllocationPlanItemsController objPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> itemMaterialList = objPlanItemsController.GetInvalidateItemMaterialByBatchProductID(mainobject.FK_MMBatchProductID, itemGroup);
            itemList.Invalidate(itemMaterialList);
            itemList.GridControl?.RefreshDataSource();
        }

        public void InvalidateItemData(BOSList<MMAllocationPlanItemsInfo> itemList, string tabName, string itemGroup, bool isRefresh = false)
        {
            if (SelectionSelectedTabs.Contains(tabName) && !isRefresh)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            MMAllocationPlanItemsController objPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> itemMaterialList = objPlanItemsController.GetInvalidateItemByBatchProductID(mainobject.FK_MMBatchProductID, itemGroup);
            itemList.Invalidate(itemMaterialList);
            itemList.GridControl?.RefreshDataSource();
        }

        public void InvalidateItemSemiProductData(BOSList<MMAllocationPlanItemsInfo> itemList, string tabName, bool isRefresh = false)
        {
            if (SelectionSelectedTabs.Contains(tabName) && !isRefresh)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;

            MMAllocationPlanItemsController objPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> itemMaterialList = objPlanItemsController.GetInvalidateItemInventoryByBatchProductID(mainobject.FK_MMBatchProductID);
            itemList.Invalidate(itemMaterialList);
            itemList.GridControl?.RefreshDataSource();
        }
    }
}
