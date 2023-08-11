using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationProposal
{
    public class AllocationProposalModule : BaseTransactionModule
    {
        public static string AllocationPlanItemMaterialList = "fld_dgcAllocationPlanItemWoodsGridControl";
        public static string AllocationPlanItemOtherMaterialList = "fld_dgcAllocationPlanItemSteelsGridControl";
        public static string AllocationPlanItemHardwareList = "fld_dgcAllocationPlanItemHardwaresGridControl";
        public static string AllocationPlanItemPaintList = "fld_dgcAllocationPlanItemPaintsGridControl";
        public static string AllocationPlanItemPackagingList = "fld_dgcAllocationPlanItemPackagingGridControl";
        public static string AllocationPlanItemInstrumentList = "fld_dgcAllocationPlanItemInstrumentsGridControl";
        public static string AllocationPlanItemSemiProductList = "fld_dgcAllocationPlanItemSemiGridControl";

        public const string DepartmentRoomGroupItemControlName = "fld_lkeHRDepartmentRoomGroupItemID";
        public const string WorkShopControlName = "fld_lkeFK_MMWorkShopID";
        public const string LineControlName = "fld_lkeFK_MMLineID";
        public const string EmployeeReceiveControlName = "fld_lkeFK_HREmployeeIDReceive";

        public BOSLookupEdit DepartmentRoomGroupItemControl;
        public BOSLookupEdit WorkShopControl;
        public BOSLookupEdit LineControl;
        public BOSLookupEdit EmployeeReceiveControl;

        public MMAllocationPlanItemWoodsGridControl ItemMaterialsGridControl;
        public MMAllocationPlanItemSteelsGridControl ItemOtherMaterialsGridControl;
        public MMAllocationPlanItemHardwaresGridControl ItemHardwaresGridControl;
        public MMAllocationPlanItemPaintsGridControl ItemPaintsGridControl;
        public MMAllocationPlanItemPackagingsGridControl ItemPackagingsGridControl;
        public MMAllocationPlanItemInstrumentsGridControl ItemInstrumentsGridControl;
        public MMAllocationPlanItemSemiProductGridControl ItemSemiProductGridControl;
        public XtraTabControl ProductionNormTabControl;
        public const string ProductionNormTabControlName = "fld_tabProductionNorm";
        public string CurrentTabSelected { get; set; }
        public List<string> SelectionSelectedTabs { get; set; }

        public AllocationProposalModule()
        {
            Name = ModuleName.AllocationProposal;
            CurrentModuleEntity = new AllocationProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ItemMaterialsGridControl = (MMAllocationPlanItemWoodsGridControl)Controls[AllocationPlanItemMaterialList];
            ItemOtherMaterialsGridControl = (MMAllocationPlanItemSteelsGridControl)Controls[AllocationPlanItemOtherMaterialList];
            ItemHardwaresGridControl = (MMAllocationPlanItemHardwaresGridControl)Controls[AllocationPlanItemHardwareList];
            ItemPaintsGridControl = (MMAllocationPlanItemPaintsGridControl)Controls[AllocationPlanItemPaintList];
            ItemPackagingsGridControl = (MMAllocationPlanItemPackagingsGridControl)Controls[AllocationPlanItemPackagingList];
            ItemInstrumentsGridControl = (MMAllocationPlanItemInstrumentsGridControl)Controls[AllocationPlanItemInstrumentList];
            ItemSemiProductGridControl = (MMAllocationPlanItemSemiProductGridControl)Controls[AllocationPlanItemSemiProductList];

            DepartmentRoomGroupItemControl = (BOSLookupEdit)Controls[DepartmentRoomGroupItemControlName];
            WorkShopControl = (BOSLookupEdit)Controls[WorkShopControlName];
            LineControl = (BOSLookupEdit)Controls[LineControlName];
            EmployeeReceiveControl = (BOSLookupEdit)Controls[EmployeeReceiveControlName];
            ProductionNormTabControl = (XtraTabControl)Controls[ProductionNormTabControlName];
            LoadLookupDataSource();
            SelectionSelectedTabs = new List<string>();
            CurrentTabSelected = ProductionNormTabControl == null ? string.Empty : ProductionNormTabControl.SelectedTabPage?.Name;
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

        public void UpdateItemInfo()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    UpdateItemInfo(entity.AllocationPlanItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    UpdateItemInfo(entity.AllocationPlanItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    UpdateItemInfo(entity.AllocationPlanItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    UpdateItemInfo(entity.AllocationPlanItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    UpdateItemInfo(entity.AllocationPlanItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    UpdateItemInfo(entity.AllocationPlanItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    UpdateItemInfo(entity.AllocationPlanItemSemiProductList);
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

        public void UpdateItemDate(DateTime planDate)
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            UpdateItemDate(entity.AllocationPlanItemMaterialList, planDate);
            UpdateItemDate(entity.AllocationPlanItemOtherMaterialList, planDate);
            UpdateItemDate(entity.AllocationPlanItemHardwareList, planDate);
            UpdateItemDate(entity.AllocationPlanItemPaintList, planDate);
            UpdateItemDate(entity.AllocationPlanItemPackagingList, planDate);
            UpdateItemDate(entity.AllocationPlanItemInstrumentList, planDate);
            UpdateItemDate(entity.AllocationPlanItemSemiProductList, planDate);
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

        public void ShowInventoryTotalQty()
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)entity.MainObject;

            BOSProgressBar.Start("Đang lấy dữ liệu tồn kho");
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    GetInventoryStockQty(entity.AllocationPlanItemMaterialList, true);
                    break;
                case "fld_tabOtherMaterial":
                    GetInventoryStockQty(entity.AllocationPlanItemOtherMaterialList, true);
                    break;
                case "fld_tabHardware":
                    GetInventoryStockQty(entity.AllocationPlanItemHardwareList, true);
                    break;
                case "fld_tabIngredientPaint":
                    GetInventoryStockQty(entity.AllocationPlanItemPaintList, true);
                    break;
                case "fld_tabIngredientPackaging":
                    GetInventoryStockQty(entity.AllocationPlanItemPackagingList, true);
                    break;
                case "fld_tabGeneralMaterial":
                    GetInventoryStockQty(entity.AllocationPlanItemInstrumentList, true);
                    break;
                case "fld_tabSemiProduct":
                    GetInventoryStockQty(entity.AllocationPlanItemSemiProductList, true);
                    break;
            }
            BOSProgressBar.Close();
        }

        public void GetInventoryStockQty(BOSList<MMAllocationPlanItemsInfo> itemList, bool isGetAll = false)
        {
            if (itemList.Count() == 0)
                return;

            ICTransactionsController objTransactionsController = new ICTransactionsController();
            string productListRef = string.Empty;
            List<int> productIds = new List<int>();
            if (isGetAll)
                productIds = itemList.Select(o => o.FK_ICProductID).ToList();
            else
                productIds = GetSelectedRefProductID(itemList);

            List<ICTransactionsInfo> inventoryStocks = objTransactionsController.GetInventoryStockListByProductRef(productIds);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
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

                o.ICInventoryStockQty = availableQty;
                objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += o.MMAllocationPlanItemQty;
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

                    item.ICInventoryStockQty = availableQty;
                    objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += item.MMAllocationPlanItemQty;
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

        public void PlannedSelectedItems()
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            //if (!CheckValidBPQty())
            //    return;

            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
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
                    PlannedSelectedItems(entity.AllocationPlanItemMaterialList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    PlannedSelectedItems(entity.AllocationPlanItemOtherMaterialList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    PlannedSelectedItems(entity.AllocationPlanItemHardwareList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    PlannedSelectedItems(entity.AllocationPlanItemPaintList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    PlannedSelectedItems(entity.AllocationPlanItemPackagingList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    PlannedSelectedItems(entity.AllocationPlanItemInstrumentList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    PlannedSelectedItems(entity.AllocationPlanItemSemiProductList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
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
                foreach (int i in rowSelected)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Close.ToString())
                        continue;

                    if ((isValidateInventoryStock && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Planed.ToString()))
                    {
                        errorMessage += "Sản phẩm [" + item.MMAllocationPlanItemProductDesc + "] chưa duyệt kế hoạch.";
                        errorMessage += Environment.NewLine;
                    }
                    if (item.MMAllocationPlanItemQty > item.ICInventoryStockQty && isValidateInventoryStock)
                    {
                        errorMessage += "Sản phẩm [" + item.MMAllocationPlanItemProductDesc + "] không đủ tồn kho.";
                        errorMessage += Environment.NewLine;
                    }
                }
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

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
                        continue;

                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return errorMessage;
        }

        public void UnPlannedSelectedItems()
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn hủy kế hoạch các vật tư đã chọn?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += ValidateUnPlannedSelectedItems(entity.AllocationPlanItemSemiProductList);
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
                    UnPlannedSelectedItems(entity.AllocationPlanItemMaterialList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    UnPlannedSelectedItems(entity.AllocationPlanItemOtherMaterialList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    UnPlannedSelectedItems(entity.AllocationPlanItemHardwareList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    UnPlannedSelectedItems(entity.AllocationPlanItemPaintList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    UnPlannedSelectedItems(entity.AllocationPlanItemPackagingList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    UnPlannedSelectedItems(entity.AllocationPlanItemInstrumentList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    UnPlannedSelectedItems(entity.AllocationPlanItemSemiProductList);
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
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
                        errorMessage += "Sản phẩm [" + item.MMAllocationPlanItemProductDesc + "] đã cấp phát.";
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

        public void RemoveItemFromList(BOSList<MMAllocationPlanItemsInfo> itemList)
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            if (itemList.CurrentIndex < 0)
                return;

            MMAllocationPlanItemsInfo item = itemList[itemList.CurrentIndex];

            if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
            {
                MessageBox.Show("Vật tư đang ở trạng thái không thế xóa. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (item.Id != 0)
                entity.DeletedItemsList.Add(item);

            entity.CurrentItemList.RemoveAll(o => o.VirtualID == item.VirtualID);
            itemList.RemoveAll(o => o.VirtualID == item.VirtualID);
            itemList.GridControl?.RefreshDataSource();
        }

        public void ApproveSelectedItems()
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;

            BOSProgressBar.Start("Đang lấy dữ liệu tồn kho");
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    GetInventoryStockQty(entity.AllocationPlanItemMaterialList);
                    break;
                case "fld_tabOtherMaterial":
                    GetInventoryStockQty(entity.AllocationPlanItemOtherMaterialList);
                    break;
                case "fld_tabHardware":
                    GetInventoryStockQty(entity.AllocationPlanItemHardwareList);
                    break;
                case "fld_tabIngredientPaint":
                    GetInventoryStockQty(entity.AllocationPlanItemPaintList);
                    break;
                case "fld_tabIngredientPackaging":
                    GetInventoryStockQty(entity.AllocationPlanItemPackagingList);
                    break;
                case "fld_tabGeneralMaterial":
                    GetInventoryStockQty(entity.AllocationPlanItemInstrumentList);
                    break;
                case "fld_tabSemiProduct":
                    GetInventoryStockQty(entity.AllocationPlanItemSemiProductList);
                    break;
            }
            BOSProgressBar.Close();
            string errorMessage = string.Empty;
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString(), true);
                    break;
                case "fld_tabOtherMaterial":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString(), true);
                    break;
                case "fld_tabHardware":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString(), true);
                    break;
                case "fld_tabIngredientPaint":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString(), true);
                    break;
                case "fld_tabIngredientPackaging":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString(), true);
                    break;
                case "fld_tabGeneralMaterial":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString(), true);
                    break;
                case "fld_tabSemiProduct":
                    errorMessage += ValidateSelectedItems(entity.AllocationPlanItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString(), true);
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
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemMaterialList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemOtherMaterialList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemHardwareList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemPaintList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemPackagingList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemInstrumentList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    refIDList.AddRange(ApproveSelectedItems(entity.AllocationPlanItemSemiProductList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, refIDList);
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

        public void UnApproveSelectedItems()
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn hủy cấp phát các vật tư đã chọn?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = entity.MainObject as MMAllocationPlansInfo;
            if (!IsValidUnApproveSelectedItem())
                return;

            List<int> refIDList = new List<int>();
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemMaterialList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemMaterialList, AllocationPlanItemGroup.Material.ToString());
                    break;
                case "fld_tabOtherMaterial":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemOtherMaterialList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    break;
                case "fld_tabHardware":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemHardwareList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemHardwareList, AllocationPlanItemGroup.Hardware.ToString());
                    break;
                case "fld_tabIngredientPaint":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemPaintList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPaintList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    break;
                case "fld_tabIngredientPackaging":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemPackagingList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemPackagingList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    break;
                case "fld_tabGeneralMaterial":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemInstrumentList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemInstrumentList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    break;
                case "fld_tabSemiProduct":
                    refIDList.AddRange(UnApproveSelectedItems(entity.AllocationPlanItemSemiProductList));
                    entity.SaveAllocationPlanItems(entity.AllocationPlanItemSemiProductList, AllocationPlanItemGroup.SemiProduct.ToString());
                    break;
            }
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, refIDList, false);
        }

        public bool IsValidUnApproveSelectedItem()
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            string errorMessage = string.Empty;
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemMaterialList);
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemOtherMaterialList);
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemHardwareList);
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemPaintList);
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemPackagingList);
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemInstrumentList);
            errorMessage += CheckValidQtyUnApprove(entity.AllocationPlanItemSemiProductList);
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
                        errorMessage += "Sản phẩm [" + item.MMAllocationPlanItemProductDesc + "] chưa lưu.";
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
                        errorMessage += "Sản phẩm [" + objAllocationPlanItemsInfo.MMAllocationPlanItemProductDesc + "] đã có cấp phát.";
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

                    if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Approved.ToString())
                        continue;

                    arrID.Add(item.Id);
                    item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Planed.ToString();
                }
                itemList.GridControl?.RefreshDataSource();
                itemList.GridControl?.Refresh();
            }
            return arrID;
        }


        public void ClosePlanItem()
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn đóng kế hoạch các vật tư đã chọn?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> remainList = objAllocationPlanItemsController.GetItemForCloseByAllocationPlanID(mainobject.MMAllocationPlanID);
            switch (CurrentTabSelected)
            {
                case "fld_tabMaterial":
                    CloseSelectedItems(entity.AllocationPlanItemMaterialList, remainList, AllocationPlanItemGroup.Material.ToString());
                    entity.AllocationPlanItemMaterialList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabOtherMaterial":
                    CloseSelectedItems(entity.AllocationPlanItemOtherMaterialList, remainList, AllocationPlanItemGroup.OtherMaterial.ToString());
                    entity.AllocationPlanItemOtherMaterialList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabHardware":
                    CloseSelectedItems(entity.AllocationPlanItemHardwareList, remainList, AllocationPlanItemGroup.Hardware.ToString());
                    entity.AllocationPlanItemHardwareList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabIngredientPaint":
                    CloseSelectedItems(entity.AllocationPlanItemPaintList, remainList, AllocationPlanItemGroup.IngredientPaint.ToString());
                    entity.AllocationPlanItemPaintList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabIngredientPackaging":
                    CloseSelectedItems(entity.AllocationPlanItemPackagingList, remainList, AllocationPlanItemGroup.IngredientPackaging.ToString());
                    entity.AllocationPlanItemPackagingList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabGeneralMaterial":
                    CloseSelectedItems(entity.AllocationPlanItemInstrumentList, remainList, AllocationPlanItemGroup.GeneralMaterial.ToString());
                    entity.AllocationPlanItemInstrumentList.GridControl?.RefreshDataSource();
                    break;
                case "fld_tabSemiProduct":
                    CloseSelectedItems(entity.AllocationPlanItemSemiProductList, remainList, AllocationPlanItemGroup.SemiProduct.ToString());
                    entity.AllocationPlanItemSemiProductList.GridControl?.RefreshDataSource();
                    break;
            }
            objAllocationPlanItemsController.AdjustPostedAllocationPlanItems(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID);
        }

        public void CloseSelectedItems(BOSList<MMBatchProductProductionNormItemsInfo> itemList, List<MMAllocationPlanItemsInfo> remainList)
        {
            if (itemList.Count() == 0)
                return;

            MMAllocationPlansInfo mainobject = CurrentModuleEntity.MainObject as MMAllocationPlansInfo;
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)itemList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();

                MMAllocationPlanItemsInfo remainItemsInfo = new MMAllocationPlanItemsInfo();
                MMBatchProductProductionNormItemsInfo newItemsInfo = new MMBatchProductProductionNormItemsInfo();
                List<MMBatchProductProductionNormItemsInfo> canceledNewList = new List<MMBatchProductProductionNormItemsInfo>();

                decimal bpProductQty = 0;
                foreach (int i in rowSelected)
                {
                    MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Canceled.ToString()
                        || item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Allocated.ToString())
                        return;

                    bpProductQty = item.MMBatchProductProductionNormItemQuantity;
                    if (item.MMBatchProductProductionNormItemGroup == ProductType.SemiProduct.ToString() && item.FK_ICProductMaterialID > 0)
                        bpProductQty = item.MMBatchProductProductionNormItemMeterialDepreciationQty;

                    remainItemsInfo = remainList.Where(o => o.Id == item.MMAllocationPlanItemID).FirstOrDefault();
                    if (remainItemsInfo == null || (remainItemsInfo != null && remainItemsInfo.MMAllocationProposalItemShippedQty == 0))
                    {
                        item.MMAllocationPlanItemPostedAction = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? "ClosePlan" : string.Empty;
                        item.MMAllocationPlanItemReference = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? item.MMAllocationPlanItemID.ToString() : string.Empty;
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Canceled.ToString();
                    }
                    else
                    {
                        if (remainItemsInfo.MMAllocationProposalItemShippedQty < bpProductQty)
                        {
                            newItemsInfo = new MMBatchProductProductionNormItemsInfo();
                            newItemsInfo = (MMBatchProductProductionNormItemsInfo)item.Clone();
                            newItemsInfo.MMAllocationPlanItemID = 0;
                            newItemsInfo.MMAllocationPlanItemQty = item.MMAllocationPlanItemQty - remainItemsInfo.MMAllocationProposalItemShippedQty;
                            newItemsInfo.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Canceled.ToString();
                            newItemsInfo.MMAllocationPlanItemReference = item.MMAllocationPlanItemID.ToString();
                            newItemsInfo.MMAllocationPlanItemPostedAction = item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString() ? "ClosePlan" : string.Empty;
                            canceledNewList.Add(newItemsInfo);
                            item.MMAllocationPlanItemQty = remainItemsInfo.MMAllocationProposalItemShippedQty;
                        }
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Approved.ToString();
                    }
                }
                itemList.AddRange(canceledNewList);
            }
        }

        public void CloseSelectedItems(BOSList<MMAllocationPlanItemsInfo> itemList, List<MMAllocationPlanItemsInfo> remainList, string itemGroup)
        {
            if (itemList.Count() == 0)
                return;

            List<int> unPostedIds = new List<int>();
            List<int> rePostedIds = new List<int>();
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
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

                    bpProductQty = item.MMAllocationPlanItemQty;
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
                        item.MMAllocationPlanItemStatus = AllocationPlanItemStatus.Approved.ToString();
                    }
                }
                itemList.AddRange(canceledNewList);
                entity.SaveAllocationPlanItems(itemList, itemGroup);
            }
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, rePostedIds);
            (new MMAllocationPlansController()).PostedItemTransactions(ModuleName.BatchProductShedule, mainobject.MMAllocationPlanID, unPostedIds, false);
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

        public void ChangeWorkShop(int workShopID)
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            mainobject.FK_MMWorkShopID = workShopID;
            mainobject.FK_MMLineID = 0;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeProduct(BOSList<MMAllocationPlanItemsInfo> itemList, MMAllocationPlanItemsInfo item, string group)
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainObject = (MMAllocationPlansInfo)entity.MainObject;
            string oldVirtualID = item.VirtualID;
            if (!string.IsNullOrWhiteSpace(oldVirtualID))
            {
                MMAllocationPlanItemsInfo removeItem = entity.CurrentItemList.Where(o => o.VirtualID == oldVirtualID).FirstOrDefault();
                if (removeItem != null)
                {
                    entity.DeletedItemsList.Add(removeItem);
                    entity.CurrentItemList.RemoveAll(o => o.VirtualID == removeItem.VirtualID);
                }
            }
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsInfo();

            ToAllocationPlanItem(item, objProductsInfo, group);
            item.VirtualID = Guid.NewGuid().ToString();
            entity.CurrentItemList.Add(item);
        }

        public void ToAllocationPlanItem(MMAllocationPlanItemsInfo item, ICProductsInfo objProductsInfo, string group)
        {
            item.FK_ICProductID = objProductsInfo.ICProductID;
            item.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            item.MMAllocationPlanItemProductName = objProductsInfo.ICProductName;
            item.MMAllocationPlanItemProductDesc = objProductsInfo.ICProductDesc;
            item.MMAllocationPlanItemQty = item.MMAllocationPlanItemQty == 0 ? 1 : item.MMAllocationPlanItemQty;
            item.MMAllocationPlanItemRemainQty = item.MMAllocationPlanItemQty;
            item.MMAllocationPlanItemHeight = objProductsInfo.ICProductHeight;
            item.MMAllocationPlanItemWidth = objProductsInfo.ICProductWidth;
            item.MMAllocationPlanItemLength = objProductsInfo.ICProductLength;
            item.MMAllocationPlanItemGroup = group;
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
                productViewList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Roundwood.ToString()
                                                                      || (MaterialDepartList.Any(dp => dp.FK_ICDepartmentID == o.FK_ICDepartmentID
                                                                             && (dp.ICProducType == string.Empty || (dp.ICProducType == o.ICProductType))))).ToList();
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
                                                                                   , AllocationPlanCreateFrom.Normal.ToString()
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
                                                                           , AllocationPlanCreateFrom.Normal.ToString()
                                                                           , searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            entity.UpdateMainObjectBindingSource();
            ClearGridControlSection();
            SelectionSelectedTabs.Clear();
            ChangeCurrentTabPage(CurrentTabSelected);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
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
            ParentScreen.SetEnableOfToolbarButton("UpdateWithChangeBOM", true);
            ParentScreen.SetEnableOfToolbarButton("CloseAllocationPlan", false);
            if (mainobject.MMAllocationPlanStatus != AllocationPlanStatus.Close.ToString() && !Toolbar.IsEditAction())
                ParentScreen.SetEnableOfToolbarButton("CloseAllocationPlan", true);

            if (mainobject.MMAllocationPlanStatus == AllocationPlanStatus.Close.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("UpdateWithChangeBOM", false);
            }
        }

        public void ClearGridControlSection()
        {
            if (ItemMaterialsGridControl != null && ItemMaterialsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemMaterialsGridControl.MainView;
                gridView.ClearSelection();
            }
            if (ItemOtherMaterialsGridControl != null && ItemOtherMaterialsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemOtherMaterialsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
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
            if (ItemInstrumentsGridControl != null && ItemInstrumentsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemInstrumentsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemInstrumentsGridControl != null && ItemInstrumentsGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemInstrumentsGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
            if (ItemSemiProductGridControl != null && ItemSemiProductGridControl.MainView != null)
            {
                GridView gridView = (GridView)ItemSemiProductGridControl.MainView;
                gridView.FocusedRowHandle = -1;
                gridView.ClearSelection();
            }
        }

        public override int ActionSave()
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            entity.AllocationPlanItemMaterialList.EndCurrentEdit();
            entity.AllocationPlanItemOtherMaterialList.EndCurrentEdit();
            entity.AllocationPlanItemHardwareList.EndCurrentEdit();
            entity.AllocationPlanItemPaintList.EndCurrentEdit();
            entity.AllocationPlanItemPackagingList.EndCurrentEdit();
            entity.AllocationPlanItemInstrumentList.EndCurrentEdit();
            entity.AllocationPlanItemSemiProductList.EndCurrentEdit();
            return base.ActionSave();
        }

        public void CloseAllocationPlan()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muón đóng kế hoạch này không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)CurrentModuleEntity.MainObject;

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> remainList = objAllocationPlanItemsController.GetItemForCloseByAllocationPlanID(mainobject.MMAllocationPlanID);

            CloseItems(entity.AllocationPlanItemMaterialList, remainList, AllocationPlanItemGroup.Material.ToString());
            CloseItems(entity.AllocationPlanItemOtherMaterialList, remainList, AllocationPlanItemGroup.OtherMaterial.ToString());
            CloseItems(entity.AllocationPlanItemHardwareList, remainList, AllocationPlanItemGroup.Hardware.ToString());
            CloseItems(entity.AllocationPlanItemPaintList, remainList, AllocationPlanItemGroup.IngredientPaint.ToString());
            CloseItems(entity.AllocationPlanItemPackagingList, remainList, AllocationPlanItemGroup.IngredientPackaging.ToString());
            CloseItems(entity.AllocationPlanItemInstrumentList, remainList, AllocationPlanItemGroup.GeneralMaterial.ToString());
            CloseItems(entity.AllocationPlanItemSemiProductList, remainList, AllocationPlanItemGroup.Material.ToString());

            entity.SetPropertyChangeEventLock(false);
            entity.SaveModuleObjects();
            mainobject.MMAllocationPlanStatus = AllocationPlanStatus.Close.ToString();
            entity.UpdateMainObjectBindingSource();
            entity.UpdateMainObject();
            ClearGridControlSection();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void CloseItems(BOSList<MMAllocationPlanItemsInfo> itemList, List<MMAllocationPlanItemsInfo> remainList, string itemGroup)
        {
            if (itemList.Count() == 0)
                return;

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
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
            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            string materialTypeName = tabName.Replace("fld_tab", "");
            switch (tabName)
            {
                case "fld_tabMaterial":
                    InvalidateItemData(entity.AllocationPlanItemMaterialList, tabName, materialTypeName);
                    break;
                case "fld_tabOtherMaterial":
                    InvalidateItemData(entity.AllocationPlanItemOtherMaterialList, tabName, materialTypeName);
                    break;
                case "fld_tabHardware":
                    InvalidateItemData(entity.AllocationPlanItemHardwareList, tabName, materialTypeName);
                    break;
                case "fld_tabIngredientPaint":
                    InvalidateItemData(entity.AllocationPlanItemPaintList, tabName, materialTypeName);
                    break;
                case "fld_tabIngredientPackaging":
                    InvalidateItemData(entity.AllocationPlanItemPackagingList, tabName, materialTypeName);
                    break;
                case "fld_tabGeneralMaterial":
                    InvalidateItemData(entity.AllocationPlanItemInstrumentList, tabName, materialTypeName);
                    break;
            }
        }

        public void InvalidateItemData(BOSList<MMAllocationPlanItemsInfo> itemList, string tabName, string itemGroup, bool isRefresh = false)
        {
            if (SelectionSelectedTabs.Contains(tabName) && !isRefresh)
                return;

            AllocationProposalEntities entity = (AllocationProposalEntities)CurrentModuleEntity;
            MMAllocationPlansInfo mainobject = (MMAllocationPlansInfo)entity.MainObject;
            MMAllocationPlanItemsController objPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> planItemList = objPlanItemsController.GetItemsByAllocationPlanID(mainobject.MMAllocationPlanID, itemGroup);
            planItemList.ForEach(o => o.VirtualID = Guid.NewGuid().ToString());
            itemList.Invalidate(planItemList);
            itemList.GridControl?.RefreshDataSource();
        }
    }
}