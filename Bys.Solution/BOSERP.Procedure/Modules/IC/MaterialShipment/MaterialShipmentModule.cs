using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Enums;
using BOSCommon.Extensions;
using BOSERP.GenaralLeadger;
using BOSLib;
using BOSReport;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;

namespace BOSERP.Modules.MaterialShipment
{
    #region MaterialShipment
    public class MaterialShipmentModule : GLShipmentModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItem1s";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string TabControlName = "fld_tabShiptmentItems";
        public const string ShipmentItemGridControlName1 = "fld_dgcICShipmentItem2s";
        public const string ICShipmentShipmentTypeLookupEditControlName = "fld_lkeICShipmentShipmentType";
        public const string ICProductLookupEditControlName = "fld_lkeFK_ICProductID";
        public const string MMOperationLookupEditControlName = "fld_lkeFK_MMOperationID";
        public const string ButtonShowInventoryStock = "fld_btnShowInventoryStock";
        public const string ButtonShowAllocationPlan = "fld_btnShowAllocationPlan";
        public const string WorkShopLookUpEditControlName = "fld_lkeFK_MMWorkShopID";
        public const string BatchProductLookupEditControlName = "fld_lkeFK_MMBatchProductID";
        public const string LineLookupEditControlName = "fld_lkeFK_LineID";
        public const string EmployeeReceverLookupEditControlName = "fld_lkeFK_HREmployeeReceverID";

        #endregion
        #region Properties
        BOSComponent.BOSLookupEdit IShipmentShipmentType;
        BOSComponent.BOSLookupEdit ProductLookupEditControl;
        BOSComponent.BOSLookupEdit MMOperationLookupEditControl;
        BOSComponent.BOSButton InventoryStock;
        BOSComponent.BOSButton AllocationPlanButton;
        public List<BRBranchsInfo> BranchList;
        private string defaultBosSelectedTypeValue;
        BOSComponent.BOSLookupEdit WorkShopLookUpEditControl;
        BOSComponent.BOSLookupEdit BatchProductLookupEditControl;
        BOSComponent.BOSLookupEdit LineLookupEditControl;
        BOSComponent.BOSLookupEdit EmployeeReceverLookupEditControl;
        #endregion
        public MaterialShipmentModule()
        {
            Name = ModuleName.MaterialShipment;
            CurrentModuleEntity = new MaterialShipmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            IShipmentShipmentType = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.ICShipmentShipmentTypeLookupEditControlName];
            ProductLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.ICProductLookupEditControlName];
            MMOperationLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.MMOperationLookupEditControlName];
            InventoryStock = (BOSComponent.BOSButton)Controls[MaterialShipmentModule.ButtonShowInventoryStock];
            AllocationPlanButton = (BOSComponent.BOSButton)Controls[MaterialShipmentModule.ButtonShowAllocationPlan];
            WorkShopLookUpEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.WorkShopLookUpEditControlName];
            BatchProductLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.BatchProductLookupEditControlName];
            LineLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.LineLookupEditControlName];
            EmployeeReceverLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentModule.EmployeeReceverLookupEditControlName];
            defaultBosSelectedTypeValue = ProductLookupEditControl.BOSSelectTypeValue;
            InitializeOperationlookupDataSource();
            InitializeShipmentTypelookupDataSource();
            DisableControl();
        }

        public void DisableControl()
        {
            if (WorkShopLookUpEditControl != null)
                WorkShopLookUpEditControl.Enabled = false;
            if (BatchProductLookupEditControl != null)
                BatchProductLookupEditControl.Enabled = false;
            if (LineLookupEditControl != null)
                LineLookupEditControl.Enabled = false;
            if (EmployeeReceverLookupEditControl != null)
                EmployeeReceverLookupEditControl.Enabled = false;
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
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds;
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objShipmentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objShipmentsController.GetMaterialShipmentListByBranchList(searchObject.ICShipmentNo,
                                                                                   objObjectsInfo.ACObjectID,
                                                                                   objObjectsInfo.ACObjectType,
                                                                                   searchObject.FK_ICStockID,
                                                                                   searchObject.FK_HREmployeeID,
                                                                                   ShipmentType.MaterialShipment.ToString(),
                                                                                   null,
                                                                                   searchObject.ShipmentDateFrom,
                                                                                   searchObject.ShipmentDateTo,
                                                                                   BranchList);
                }
            }
            else
            {
                ds = objShipmentsController.GetMaterialShipmentList(searchObject.ICShipmentNo,
                                                                   searchObject.FK_BRBranchID,
                                                                   objObjectsInfo.ACObjectID,
                                                                   objObjectsInfo.ACObjectType,
                                                                   searchObject.FK_ICStockID,
                                                                   searchObject.FK_HREmployeeID,
                                                                   ShipmentType.MaterialShipment.ToString(),
                                                                   null,
                                                                   searchObject.ShipmentDateFrom,
                                                                   searchObject.ShipmentDateTo);
            }
            return ds;
        }

        private void InitializeOperationlookupDataSource()
        {
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> objOperationsList = new List<MMOperationsInfo>();
            if (BOSApp.LookupTables.ContainsKey(TableName.MMOperationsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null)
                {
                    MMAllocationOperationConfigsInfo DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
                    objOperationsList = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
                    if (objOperationsList != null) objOperationsList = objOperationsList.Where(o =>
                        (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlan.ToString() && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsStock.ToString() && o.MMOperationInOutStockCheck)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanAndStock.ToString() && o.MMOperationInOutStockCheck && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanOrStock.ToString() && (o.MMOperationInOutStockCheck || o.MMOperationIsPlan))
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.AllOperation.ToString())
                        || (DefualtAOConfigs == null)
                        ).ToList();
                }
            }
            MMOperationsInfo item = new MMOperationsInfo();
            objOperationsList.Insert(0, item);
            MMOperationLookupEditControl.Properties.DataSource = objOperationsList;
        }

        private void InitializeShipmentTypelookupDataSource()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ShipmentShipmentType.ToString());
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    if (objConfigValuesInfo.ADConfigKeyValue == ShipmentShipmentType.Hardware.ToString()
                        || objConfigValuesInfo.ADConfigKeyValue == ShipmentShipmentType.IngredientPaint.ToString()
                        || objConfigValuesInfo.ADConfigKeyValue == ShipmentShipmentType.IngredientPackaging.ToString()
                        || objConfigValuesInfo.ADConfigKeyValue == ShipmentShipmentType.OtherMaterial.ToString()
                        || objConfigValuesInfo.ADConfigKeyValue == ShipmentShipmentType.Other.ToString())
                        ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            IShipmentShipmentType.Properties.Columns.Clear();
            IShipmentShipmentType.Properties.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));

            if (ConfigValuesList != null)
            {
                IShipmentShipmentType.BOSDataSource = "";
                IShipmentShipmentType.BOSDataMember = "";
                IShipmentShipmentType.Properties.DataSource = ConfigValuesList;
                IShipmentShipmentType.Properties.DisplayMember = "ADConfigText";
                IShipmentShipmentType.Properties.ValueMember = "ADConfigKeyValue";
            }
        }

        public override void ActionEdit()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionEdit();
                MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                if (objShipmentsInfo.FK_MMAllocationPlanID > 0)
                {
                    AllocationPlanButton.Visible = true;
                }
                else
                {
                    AllocationPlanButton.Visible = false;
                }
                ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", false);
            }
        }

        public override void ActionCancel()
        {
            ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", true);
            base.ActionCancel();
        }

        public void ChangeItemFromShipmentItemsList()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (entity.ShipmentItemList.CurrentIndex < 0)
                return;

            ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            if (objShipmentItemsInfo != null)
            {
                objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                //BOSApp.RoundByCurrency(objShipmentItemsInfo, objShipmentsInfo.FK_GECurrencyID);
            }
            entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            //UpdateDocumentEntries();

        }
        public List<ICProductsForViewInfo> GetBatchProductItemSerialDataSource()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            List<ICProductsForViewInfo> ProductList = new List<ICProductsForViewInfo>();
            ProductList.Add(new ICProductsForViewInfo());
            if (objShipmentsInfo.FK_MMBatchProductID > 0)
            {
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                List<MMBatchProductItemsInfo> BatchProductItemList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objShipmentsInfo.FK_MMBatchProductID);
                if (BatchProductItemList.Count() > 0)
                {
                    BatchProductItemList.ForEach(b =>
                    {
                        ICProductsForViewInfo obj = new ICProductsForViewInfo();
                        obj.FK_MMBatchProductItemID = b.MMBatchProductItemID;
                        obj.ICProductID = b.FK_ICProductID;
                        obj.ICProductNo = b.MMBatchProductItemProductNo;
                        obj.ICProductName = b.MMBatchProductItemProductName;
                        obj.ICProductDesc = b.MMBatchProductItemProductDesc;
                        obj.ICShipmentItemBatchProductItemProductSerial = b.MMBatchProductItemProductSerial;
                        ProductList.Add(obj);
                    });
                }
            }
            return ProductList;
        }

        public void SelectSeriesNoDefault()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void AdditemtoShipmentItemList()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (!(objShipmentsInfo.FK_MMBatchProductID > 0))
            {
                MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.MMBatchProductID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
            else if (!(objShipmentsInfo.FK_ICProductID > 0))
            {
                MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.ICProductID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
            else
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                List<ICReceiptItemsInfo> receiptItemsList = objReceiptItemsController.GetReceiptItemBottonClick(objShipmentsInfo.FK_MMBatchProductID, objShipmentsInfo.FK_ICProductID);
                guiFind<ICReceiptItemsInfo> guifild = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName, receiptItemsList, this, false);
                guifild.ShowDialog();
                if (guifild.DialogResult == DialogResult.OK)
                {
                    int receiptItemID = Convert.ToInt32(guifild.Tag.ToString());
                    if (receiptItemID > 0)
                    {
                        ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectByID(receiptItemID);
                        if (objReceiptItemsInfo != null)
                        {
                            BOSUtil.CopyObject(objReceiptItemsInfo, objShipmentItemsInfo);
                        }
                    }
                }
            }
        }

        public void ChangeObjectItemList(int objMMBatchProductID)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(objMMBatchProductID);
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMBatchProductID = objMMBatchProductID;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            if (objShipmentItemsInfo != null)
            {
                foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                {
                    if (item.FK_MMBatchProductProductionNormItemID > 0) continue;
                    item.FK_MMBatchProductID = objMMBatchProductID;
                }
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                UpdateDocumentEntries();
            }
        }
        public void ChangeBatchItemList(ICProductsForViewInfo obj)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (entity.ShipmentItemList.Count() == 0) return;
            if (MessageBox.Show("Bạn chắc chắn muốn thay đổi cho tất cả các chi tiết?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                {
                    if (item.FK_MMBatchProductProductionNormItemID > 0) continue;
                    item.FK_MMBatchProductID = obj.FK_MMBatchProductID;
                    item.FK_MMBatchProductItemID = obj.FK_MMBatchProductItemID;
                    item.FK_ICProductForBatchID = obj.ICProductID;
                }
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                UpdateDocumentEntries();
            }
        }

        public void AddItemToShipmentItemsList()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemVMsInfo item = (ICShipmentItemVMsInfo)entity.ModuleObjects[TableName.ICShipmentItemVMsTableName];
            if (item.FK_ICProductID == 0)
                return;

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
            if (objProductsInfo == null)
                return;

            item = new ICShipmentItemVMsInfo();
            BOSUtil.CopyObject(objProductsInfo, item);
            item.FK_ICProductID = objProductsInfo.ICProductID;
            item.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            item.ICShipmentItemProductName = objProductsInfo.ICProductName;
            item.ICShipmentItemProductDesc = objProductsInfo.ICProductDesc;
            item.ICShipmentItemLength = objProductsInfo.ICProductLength;
            item.ICShipmentItemWidth = objProductsInfo.ICProductWidth;
            item.ICShipmentItemHeight = objProductsInfo.ICProductHeight;
            item.ICShipmentItemProductQty = 1;
            item.ICShipmentItemProductFactor = 1;
            item.ICShipmentItemProductExchangeQty = 1;
            item.FK_ICStockID = mainobject.FK_ICStockID;
            item.FK_MMBatchProductID = mainobject.FK_MMBatchProductID;
            entity.SetProductPriceByProductUnitPrice(item);

            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            BOSUtil.CopyObject(objProductsInfo, objShipmentItemsInfo);
            objShipmentItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objShipmentItemsInfo.ICShipmentItemProductName = objProductsInfo.ICProductName;
            objShipmentItemsInfo.ICShipmentItemProductDesc = objProductsInfo.ICProductDesc;
            objShipmentItemsInfo.ICShipmentItemLength = objProductsInfo.ICProductLength;
            objShipmentItemsInfo.ICShipmentItemWidth = objProductsInfo.ICProductWidth;
            objShipmentItemsInfo.ICShipmentItemHeight = objProductsInfo.ICProductHeight;
            objShipmentItemsInfo.ICShipmentItemProductQty = 1;
            objShipmentItemsInfo.ICShipmentItemProductFactor = 1;
            objShipmentItemsInfo.ICShipmentItemProductExchangeQty = 1;
            entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
            objShipmentItemsInfo.VirtualID = Guid.NewGuid();

            item.ICShipmentItemRef = objShipmentItemsInfo.VirtualID.ToString();
            if (mainobject != null)
            {
                objShipmentItemsInfo.FK_MMBatchProductID = mainobject.FK_MMBatchProductID;
                objShipmentItemsInfo.FK_MMOperationID = mainobject.FK_MMOperationID;
                objShipmentItemsInfo.FK_ICImportAndExportReasonID = mainobject.FK_ICImportAndExportReasonID;
            }
            if (objProductsInfo != null)
            {
                entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                objShipmentItemsInfo.FK_ACAccountID = GetAccountByStock(objShipmentItemsInfo.FK_ICStockID, objShipmentItemsInfo.FK_ACAccountID);
                objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                objShipmentItemsInfo.ICShipmentItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
            }
            objShipmentItemsInfo.FK_ICStockID = mainobject.FK_ICStockID;
            objShipmentItemsInfo.FK_MMBatchProductID = mainobject.FK_MMBatchProductID;
            entity.ShipmentItemList.Add(objShipmentItemsInfo);
            if (entity.ShipmentItemList.GridControl != null)
                entity.ShipmentItemList.GridControl.RefreshDataSource();

            entity.TotalShipmentItemsList.Add(item);
            if (entity.TotalShipmentItemsList.GridControl != null)
                entity.TotalShipmentItemsList.GridControl.RefreshDataSource();

            UpdateDocumentEntries();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            AllocationPlanButton.Visible = false;

            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", false);
            ParentScreen.SetEnableOfToolbarButton("DiscardMaterialShipment", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
            if (Toolbar.IsNullOrNoneAction() && objShipmentsInfo.ICShipmentStatus == ShipmentStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", true);
                ParentScreen.SetEnableOfToolbarButton("DiscardMaterialShipment", true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
            }
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString()
                || objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Canceled.ToString())
            {
                if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);
                }
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", false);
                ParentScreen.SetEnableOfToolbarButton("DiscardMaterialShipment", false);
            }
        }

        public override int ActionSave()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            List<string> errorMessages = new List<string>();
            entity.TotalShipmentItemsList.EndCurrentEdit();
            entity.ShipmentItemList.EndCurrentEdit();

            if (String.IsNullOrEmpty(objShipmentsInfo.ICShipmentShipmentType))
            {
                MessageBox.Show("Vui lòng chọn loại hàng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objShipmentsInfo.FK_ICImportAndExportReasonID == 0)
            {
                MessageBox.Show("Vui lòng chọn Lý do nhập xuất!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (entity.ShipmentItemList.Exists(o => o.FK_MMOperationID == 0 || o.FK_MMWorkShopID == 0) && objShipmentsInfo.FK_ICImportAndExportReasonID == 0)
            {
                MessageBox.Show(MaterialShipmentLocalizedResources.ImportAndExportReasonIsRequier, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            ReadOnlyControl(true);
            int countOperation = entity.ShipmentItemList.Where(o => o.FK_MMOperationID == 0).Count();
            int countBatch = entity.ShipmentItemList.Where(o => o.FK_MMBatchProductID == 0).Count();
            int countBatchItem = entity.ShipmentItemList.Where(o => o.FK_MMBatchProductItemID == 0).Count();
            if (countOperation > 0 || countBatch > 0)
            {
                if (BOSApp.ShowMessageYesNo("Công đoạn cấp phát hoặc Lệnh sản xuất đang để trống, bạn có chắc không?") == DialogResult.No)
                    return 0;
            }
            if (countBatchItem > 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chưa chọn lô của lệnh sản xuất."
                    + Environment.NewLine + " Giá thành cho sản phẩm này sẽ không lấy được chi phí vật tư tương ứng."
                    + Environment.NewLine + " Bạn có chắc không?") == DialogResult.No)
                    return 0;
            }

            if (!IsValidShipmentQtyForList())
            {
                return 0;
            }
            return base.ActionSave();
        }
        public bool CheckOperationReceive(BOSItemsEntityList<ICShipmentItemsInfo> ListObject)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            bool flag = true;
            ICShipmentItemsController objsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> listshipmentItem = objsController.ValidateMaterialOperationReceive(objShipmentsInfo.ICShipmentID);
            string mess = string.Empty;
            foreach (ICShipmentItemsInfo item in ListObject)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = listshipmentItem.Where(r => r.Id == item.Id).FirstOrDefault();
                if (objShipmentItemsInfo != null)
                {
                    if (objShipmentItemsInfo.FK_MMOperationID > 0 && objShipmentItemsInfo.FK_MMReceiveOperationID == 0)
                    { flag = false; item.IsError = true; }
                }
            }
            if (!flag)
                mess = Environment.NewLine + "Công đoạn cấp phát không thuộc QTSX của sản phẩm.";
            if (!flag)
            {
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }
        public bool CheckItemOperationReceive(ICShipmentItemsInfo item)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            bool flag = true;
            ICShipmentItemsController objsController = new ICShipmentItemsController();
            ICShipmentItemsInfo shipmentItem = objsController.ValidateMaterialOperationReceive(item.FK_MMBatchProductID, item.FK_MMBatchProductItemID
                                                            , item.FK_MMBatchProductProductionNormItemID, item.FK_MMOperationID);
            string mess = string.Empty;
            if (shipmentItem != null)
            {
                if (shipmentItem.FK_MMOperationID == 0)
                { flag = false; item.IsError = true; }
            }
            else
            {
                flag = false; item.IsError = true;
            }
            if (!flag)
                mess = Environment.NewLine + "Công đoạn cấp phát không thuộc QTSX của sản phẩm.";

            if (!flag)
            {
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateDocumentEntries();
            }
        }

        public List<ICProductAttributesInfo> GetProductItemAttributeQuality()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;
        }
        public List<ICProductAttributesInfo> GetProductItemAttributeWoodType()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;
        }
        public List<MMBatchProductItemsInfo> GetBatchProductItemSerialDataSource(ICShipmentItemsInfo objShipmentItemsInfo)
        {
            List<MMBatchProductItemsInfo> BatchProductItemsList = new List<MMBatchProductItemsInfo>();
            BatchProductItemsList.Add(new MMBatchProductItemsInfo());
            if (objShipmentItemsInfo.FK_MMBatchProductID > 0)
            {
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                BatchProductItemsList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objShipmentItemsInfo.FK_MMBatchProductID);
            }
            return BatchProductItemsList;
        }

        public List<MMBatchProductItemsInfo> GetBatchProductItemSerialDataSource(ICShipmentItemVMsInfo objShipmentItemsInfo)
        {
            List<MMBatchProductItemsInfo> BatchProductItemsList = new List<MMBatchProductItemsInfo>();
            BatchProductItemsList.Add(new MMBatchProductItemsInfo());
            if (objShipmentItemsInfo.FK_MMBatchProductID > 0)
            {
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                BatchProductItemsList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objShipmentItemsInfo.FK_MMBatchProductID);
            }
            return BatchProductItemsList;
        }

        public List<ICProductAttributesInfo> GetProductItemAttributeTTMT()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.TTMT.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;

        }

        public void ApproveMaterialShipment()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ActionComplete();
            }
        }

        public override bool ActionComplete()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            entity.ShipmentItemList.EndCurrentEdit();
            UpdateTotalAmount();
            if (!CheckOperationReceive(entity.ShipmentItemList))
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                return false;
            }
            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
            {
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                    && !objProductsInfo.IsAsset
                    && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString())
                {
                    if (objShipmentItemsInfo.FK_ICProductSerieID == 0)
                    {
                        MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            if (entity.ShipmentItemList.BackupList != null && entity.ShipmentItemList.BackupList.Count > 0)
            {
                entity.ShipmentItemList.BackupList.Clear();
            }
            if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
            {
                return false;
            }
            if (InvalidProductUnitCost())
            {
                return false;
            }
            return base.ActionComplete();
        }

        public bool InvalidProductUnitCost()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)entity.MainObject;
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("ParentID", typeof(int)));
            dt.Columns.Add(new DataColumn("RefID", typeof(int)));
            entity.ShipmentItemList.ForEach(o =>
            {
                DataRow r = dt.NewRow();
                r["ID"] = o.Id;
                r["ParentID"] = o.FK_ICShipmentID;
                r["RefID"] = o.FK_ICProductSerieID;
                dt.Rows.Add(r);
            });
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> validateList = objShipmentItemsController.GetItemForInvalidProductUnitCost(dt);
            ICShipmentItemsInfo objValidate = new ICShipmentItemsInfo();
            string messageError = string.Empty;
            List<string> zeroCostError = new List<string>();
            List<string> diffCostError = new List<string>();
            entity.ShipmentItemList.ForEach(item =>
            {
                objValidate = validateList.Where(o => o.Id == item.Id).FirstOrDefault();
                if (objValidate == null)
                    return;

                //if (item.ICShipmentItemProductUnitCost == 0)
                //{
                //    messageError = string.Format("Sản phẩm [{0}]- {1} - Lô [{2}] không có giá vốn.", objValidate.ICProductNo, objValidate.ICProductName, item.ICShipmentItemProductSerialNo);
                //    zeroCostError.Add(messageError);
                //}
                if (Math.Abs(item.ICShipmentItemProductUnitCost - (objValidate.ICTransactionUnitCost * item.ICShipmentItemProductFactor)) > 1 && item.ICShipmentItemProductUnitCost != 0)
                {
                    messageError = string.Format("Sản phẩm [{0}]- {1} - Lô [{2}] có giá vốn {3} khác với giá vốn nhập kho {4}.", objValidate.ICProductNo, objValidate.ICProductName, item.ICShipmentItemProductSerialNo, item.ICShipmentItemProductUnitCost, objValidate.ICTransactionUnitCost);
                    diffCostError.Add(messageError);
                }
            });
            if (!zeroCostError.Any() && !diffCostError.Any())
                return false;

            string value = ConfigurationManager.AppSettings["ValidateUnitCostWarning"];
            bool isWarning = false;
            if (string.IsNullOrEmpty(value))
                isWarning = false;
            else
                Boolean.TryParse(value, out isWarning);

            messageError = string.Join(Environment.NewLine, zeroCostError.Distinct().ToArray());
            messageError += string.Join(Environment.NewLine, diffCostError.Distinct().ToArray());
            messageError += Environment.NewLine;
            if (zeroCostError.Any() && !diffCostError.Any() && isWarning)
            {
                messageError += "Bạn có muốn tiếp tục [Duyệt chứng từ] không?";
                DialogResult rs = MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return rs != DialogResult.Yes;
            }
            messageError += "Vui lòng liên hệ quản trị viên phần mềm!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        #region newFrom
        public override void ActionNew()
        {
            ChangeAllocationProposalProductType(string.Empty);
            UpdateProductLookupEditControlDataSource(defaultBosSelectedTypeValue, string.Empty);
            base.ActionNew();
            ReadOnlyControl(false);
            //InventoryStock.Visible = true;
            AllocationPlanButton.Visible = false;
            ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", false);
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
                ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", false);
            else
                ParentScreen.SetEnableOfToolbarButton("ApproveMaterialShipment", true);
            UpdateProductLookupEditControlDataSource(string.Empty, objShipmentsInfo.ICShipmentShipmentType);
            objShipmentsInfo.ICShipmentSOName = string.Join(", ", entity.ShipmentItemList.Where(o => !string.IsNullOrWhiteSpace(o.ICShipmentItemSOName)).Select(o => o.ICShipmentItemSOName).Distinct().ToArray());
            entity.UpdateMainObjectBindingSource();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                //UpdateDocumentEntries();
            }
        }
        #endregion

        public void ChangeAllocationProposalProductType(string type)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            UpdateProductLookupEditControlDataSource(string.Empty, type);
        }

        public void ReadOnlyControl(bool check)
        {
            IShipmentShipmentType.Properties.ReadOnly = check;
        }

        public void UpdateProductLookupEditControlDataSource(string selectedTypeValue, string type)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objICProductsController = new ICProductsController();
            List<ICProductsForViewInfo> productList = new List<ICProductsForViewInfo>();

            if (type == ProductType.Roundwood.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Roundwood.ToString()).ToList();
            }
            else if (type == ProductType.Lumber.ToString()
                || type == ProductType.Verneer.ToString()
                || type == ProductType.ArtificialBoard.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Lumber.ToString() ||
                 o.ICProductType == ProductType.Verneer.ToString() ||
                  o.ICProductType == ProductType.ArtificialBoard.ToString()
                 ).ToList();
            }
            else if (type == ProductType.Hardware.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Hardware.ToString()
                                                                    || o.ICProductType == ProductType.ElecWater.ToString()
                                                                    || o.ICProductType == ProductType.Electric.ToString()).ToList();
            }
            else if (type == ProductType.IngredientPaint.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.IngredientPaint.ToString()).ToList();
            }
            else if (type == ProductType.IngredientPackaging.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.IngredientPackaging.ToString()).ToList();
            }
            else if (type == ProductType.Equipment.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Equipment.ToString()).ToList();
            }
            else if (type == "OtherMaterial" || type == ProductType.Material.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Material.ToString()).ToList();
            }
            else if (type == string.Empty)
            {
                //'BuildingMaterial','MMTB','VVP','Equipment'
                //productList = objICProductsController.GetProductForUnfinishedCost();
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.BuildingMaterial.ToString()
                                                                   || o.ICProductType == ProductType.MMTB.ToString()
                                                                   || o.ICProductType == ProductType.VVP.ToString()
                                                                   || o.ICProductType == ProductType.Equipment.ToString()).ToList();
            }
            else
            {
                //'Hardware','IngredientPackaging','IngredientPaint','Equipment','Electric','ElecWater'
                productList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Hardware.ToString()
                                                                    || o.ICProductType == ProductType.IngredientPackaging.ToString()
                                                                    || o.ICProductType == ProductType.IngredientPaint.ToString()
                                                                    || o.ICProductType == ProductType.Equipment.ToString()
                                                                    || o.ICProductType == ProductType.Electric.ToString()
                                                                    || o.ICProductType == ProductType.ElecWater.ToString()
                                                                    ).ToList();
            }

            productList = productList.Where(o => string.IsNullOrWhiteSpace(o.ICProductUsingMethod)
                                                || o.ICProductUsingMethod == ProductUsingMethod.NoneSpecific.ToString()).ToList();

            ProductLookupEditControl.Properties.DataSource = productList;
        }
        public void ChangeOperation(int operation)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMOperationID = operation;
            int countNorm = entity.ShipmentItemList.Where(o => o.FK_MMBatchProductProductionNormItemID > 0).Count();
            if (countNorm > 0) return;
            int countOpExist = entity.ShipmentItemList.Where(o => o.FK_MMOperationID > 0).Count();
            if (countOpExist > 0 && BOSApp.ShowMessageYesNo("Bạn chắc chắn thay đổi công đoạn cho tất cả chi tiết?") == DialogResult.No) return;
            entity.ShipmentItemList.ForEach(o =>
            {
                //if (o.FK_MMBatchProductProductionNormItemID > 0) return;
                o.FK_MMOperationID = operation;
            });
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateDocumentEntries();
        }

        public void ChangeDepartment(int department)
        {

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_HRDepartmentID = department;
            UpdateDocumentEntries();
        }
        #region Accounting


        #endregion


        public void ChangeStock(int stockID)
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentInfo.FK_ICStockID = stockID;
            entity.TotalShipmentItemsList.ForEach(o =>
            {
                o.FK_ICStockID = stockID;
                o.ICShipmentItemProductSerialNo = string.Empty;
            });
            entity.ShipmentItemList.ForEach(o =>
            {
                o.FK_ICStockID = stockID;
                o.ICShipmentItemProductSerialNo = string.Empty;
                o.ICShipmentItemLotNo = string.Empty;
                GeneralAccountInShipmentItemByStock(o);
            });
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            if (entity.TotalShipmentItemsList.GridControl != null)
            {
                entity.TotalShipmentItemsList.GridControl.RefreshDataSource();
            }
        }

        public void PrintGroupMaterialA4()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
                if (objShipmentInfo.ICShipmentShipmentType == ShipmentShipmentType.Other.ToString())
                {
                    RP_MaterialShipmentCCDCGroup report = new RP_MaterialShipmentCCDCGroup();
                    InitReceiptReport(report, objShipmentInfo.ICShipmentID, true);
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                }
                else
                {
                    RP_MaterialShipmentGroup report = new RP_MaterialShipmentGroup();
                    InitReceiptReport(report, objShipmentInfo.ICShipmentID, true);
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                }
            }
        }

        public void PrintGroupMaterialA5()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
                if (objShipmentInfo.ICShipmentShipmentType == ShipmentShipmentType.Other.ToString())
                {
                    RP_MaterialShipmentA5CCDCGroup report = new RP_MaterialShipmentA5CCDCGroup();
                    InitReceiptReport(report, objShipmentInfo.ICShipmentID, true);
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                }
                else
                {
                    RP_MaterialShipmentA5Group report = new RP_MaterialShipmentA5Group();
                    InitReceiptReport(report, objShipmentInfo.ICShipmentID, true);
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                }
            }
        }

        public void ShownInventoryStocks()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
                ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                if (!objShipmentInfo.ICShipmentShipmentType.Equals(String.Empty))
                {

                    guiShowInventoryStock guiShowInventoryStock = new guiShowInventoryStock(objShipmentInfo.ICShipmentShipmentType);
                    guiShowInventoryStock.Module = this;
                    guiShowInventoryStock.ShowDialog();
                    List<ICProductSeriesInfo> SeriesList = new List<ICProductSeriesInfo>();
                    SeriesList = guiShowInventoryStock.ProductSeriesInfoList;
                    if (SeriesList.Count > 0)
                    {
                        GetSelectedSeriesList(SeriesList);
                    }
                }
            }
        }

        public void GetSelectedSeriesList(List<ICProductSeriesInfo> SeriesList)
        {
            string type = string.Empty;
            decimal qty = 0;
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(SeriesList[0].FK_ICProductID);
            foreach (ICProductSeriesInfo item in SeriesList)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                BOSUtil.CopyObject(item, objShipmentItemsInfo);
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objShipmentItemsInfo.ICShipmentItemProductDesc = objProductsInfo.ICProductDesc;
                    objShipmentItemsInfo.ICShipmentItemProductName = objProductsInfo.ICProductGroupName;
                    objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    objShipmentItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                    objShipmentItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;

                    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                    {
                        qty = Math.Round(item.ICInventoryStockQuantity, 6, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        qty = Math.Round(item.ICInventoryStockQuantity, 6, MidpointRounding.AwayFromZero);
                    }
                }
                objShipmentItemsInfo.FK_ICProductSerieID = item.ICProductSerieID;
                objShipmentItemsInfo.ICShipmentItemProductSerialNo = item.ICProductSerieNo;
                objShipmentItemsInfo.ICShipmentItemLotNo = item.ICProductSerieLotNo;
                objShipmentItemsInfo.ICShipmentItemProductQty = qty;
                objShipmentItemsInfo.ICShipmentItemWoodQty = item.ICInventoryStockWoodQuantity;
                objShipmentItemsInfo.FK_MMBatchProductID = objShipmentInfo.FK_MMBatchProductID;
                objShipmentItemsInfo.FK_MMOperationID = objShipmentInfo.FK_MMOperationID;
                objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objShipmentInfo.FK_ICProductAttributeTTMTID;
                objShipmentItemsInfo.ICShipmentItemProductType = objShipmentInfo.ICShipmentShipmentType;
                if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                {
                    objShipmentItemsInfo.ICShipmentItemProductDesc = item.ICProductSerieProductDesc;
                }
                objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICInventoryStockUnitCost;
                entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                GeneralAccountInShipmentItemByStock(objShipmentItemsInfo);
                entity.UpdateTotalAmount();
                entity.ShipmentItemList.Add(objShipmentItemsInfo);
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        private void InitReceiptReport(XtraReport report, int ShipmentID, bool groupMaterial)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactFax;
                }
            }
            if (BOSApp.CurrentCompanyInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyName"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyAddressLine3"];
                if (label != null)
                {
                    label.Text = "Địa chỉ: " + BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyInfo"];
                if (label != null)
                {
                    label.Text = string.Format("ĐT: {0} | Email: {1} | Website: {2}", BOSApp.CurrentCompanyInfo.CSCompanyPhone
                    , BOSApp.CurrentCompanyInfo.CSCompanyEmail, BOSApp.CurrentCompanyInfo.CSCompanyWebsite);
                    
                }
            }

            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo shipment = (ICShipmentsInfo)objShipmentsController.GetObjectByID(ShipmentID);
            #region Hạch toán

            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACDocumentEntrysInfo> documentEntryList = entity.DocumentEntryList;
            documentEntryList.ForEach(o =>
            {
                o.DebitAccountNo = objAccountsController.GetObjectNoByID(o.FK_ACDebitAccountID);
                o.CreditAccountNo = objAccountsController.GetObjectNoByID(o.FK_ACCreditAccountID);
            });
            String debitNo = String.Join(",", documentEntryList.Where(o => o.ACDocumentEntryDebitExchangeAmount > 0).Select(p => p.DebitAccountNo).Distinct().ToArray());
            String creditNo = String.Join(",", documentEntryList.Where(o => o.ACDocumentEntryDebitExchangeAmount > 0).Select(p => p.CreditAccountNo).Distinct().ToArray());
            XRLabel accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDebitAccountNo"];
            if (accLabel != null && String.IsNullOrEmpty(accLabel.Text))
            {
                accLabel.Text = debitNo;
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCreditAccountNo"];
            if (accLabel != null && String.IsNullOrEmpty(accLabel.Text))
            {
                accLabel.Text = creditNo;
            }
            #endregion

            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel28"];
            if (accLabel != null)
            {
                accLabel.Text = "Ngày: " + shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel29"];
            if (accLabel != null)
            {
                accLabel.Text = "Ngày: " + shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }

            ADReportsController objReportsController = new ADReportsController();
            decimal sumProductQty = 0;
            List<ICShipmentItemsInfo> materialShipmentItemList = new List<ICShipmentItemsInfo>();
            if (groupMaterial == false)
            {
                materialShipmentItemList = (List<ICShipmentItemsInfo>)objReportsController.GetListShipmentItemByShipmentID(ShipmentID);
            }
            else
            {
                materialShipmentItemList = (List<ICShipmentItemsInfo>)objReportsController.GetListGroupedShipmentItemByShipmentID(ShipmentID);

            }
            materialShipmentItemList.ForEach(p =>
                {
                    sumProductQty += p.ICShipmentItemProductQty;
                });
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblSumProductQty"];
            if (accLabel != null)
            {
                accLabel.Text = sumProductQty.ToString();
            }
            report.DataSource = materialShipmentItemList;
            //report.DataMember = BOSCommon.Constants.Report.DevReceiptItemReportName;
        }

        public bool CheckDump(int id, BOSItemsEntityList<ICShipmentItemsInfo> ListObject)
        {
            bool flag = true;
            foreach (ICShipmentItemsInfo item in ListObject)
            {
                if (item.FK_MMAllocationProposalItemID == id)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        public void ResetModelDetail(ICShipmentItemsInfo item)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList.Count > 0)
            {
                item.FK_ICModelDetailID = ModelDetailsList.FirstOrDefault().ICModelDetailID;
            }
            else
            {
                item.FK_ICModelDetailID = 0;
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void GeneralAccountInShipmentItemByStock(ICShipmentItemsInfo item)
        {
            if (item.FK_ICStockID > 0)
            {
                item.FK_ACAccountID = GetAccountByStock(item.FK_ICStockID, item.FK_ACAccountID);
            }
        }

        public void ChangeImportAndExportReason(int importAndExportReasonID)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_ICImportAndExportReasonID = importAndExportReasonID;
            if (Toolbar.IsNullOrNoneAction())
                return;

            if (entity.ShipmentItemList.Count > 0)
            {
                entity.ShipmentItemList.ForEach(o => o.FK_ICImportAndExportReasonID = importAndExportReasonID);
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateTotalAmount();
        }

        public void PrintMulti()
        {
            if (!Toolbar.IsNullOrNoneAction() && !(Toolbar.CurrentObjectID > 0))
                return;
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            guiPrintMulti guiPrintMulti = new guiPrintMulti();
            guiPrintMulti.Module = this;
            DialogResult rs = guiPrintMulti.ShowDialog();
            if (rs != DialogResult.OK)
                return;
            List<ICShipmentsInfo> shipmentsList = (List<ICShipmentsInfo>)guiPrintMulti.SelectedObjects;
            RP_MultiMaterialShipment report = new RP_MultiMaterialShipment();
            InitMultiReceiptReport(report, shipmentsList);
            guiReportPreview reviewer = new guiReportPreview(report, null, true);
            reviewer.Show();
        }

        public void InitMultiReceiptReport(RP_MultiMaterialShipment report, List<ICShipmentsInfo> shipmentsList)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactFax;
                }
            }

            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo shipment = shipmentsList.Where(o => !string.IsNullOrEmpty(o.ICShipmentDeliveryContactName)).FirstOrDefault();
            if (shipment == null)
                shipment = shipmentsList.FirstOrDefault();
            if (shipment == null)
                shipment = new ICShipmentsInfo();
            #region Hạch toán
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACDocumentEntrysInfo> documentEntryList = entity.DocumentEntryList;
            documentEntryList.ForEach(o =>
            {
                o.DebitAccountNo = objAccountsController.GetObjectNoByID(o.FK_ACDebitAccountID);
                o.CreditAccountNo = objAccountsController.GetObjectNoByID(o.FK_ACCreditAccountID);
            });
            String debitNo = String.Join(",", documentEntryList.Select(p => p.DebitAccountNo).Distinct().ToArray());
            String creditNo = String.Join(",", documentEntryList.Select(p => p.CreditAccountNo).Distinct().ToArray());
            XRLabel accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDebitAccountNo"];
            if (accLabel != null && String.IsNullOrEmpty(accLabel.Text))
            {
                accLabel.Text = debitNo;
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCreditAccountNo"];
            if (accLabel != null && String.IsNullOrEmpty(accLabel.Text))
            {
                accLabel.Text = creditNo;
            }
            #endregion
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblICShipmentNo"];
            if (accLabel != null)
            {
                accLabel.Text = string.Join(";", shipmentsList.Select(o => o.ICShipmentNo).ToArray());
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblICShipmentDeliveryContactName"];
            if (accLabel != null)
            {
                accLabel.Text = shipment.ICShipmentDeliveryContactName;
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblICShipmentDesc"];
            if (accLabel != null)
            {
                accLabel.Text = string.Join(";", shipmentsList.Select(o => o.ICShipmentDesc).ToArray());
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblICImportAndExportReasonName"];
            if (accLabel != null)
            {
                accLabel.Text = string.Join(";", shipmentsList.Select(o => o.ICImportAndExportReasonName).ToArray());
            }
            string shipmentRef = string.Join(",", shipmentsList.Select(o => o.ICShipmentID.ToString()).ToArray());
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentitemsList = objShipmentItemsController.GetAllShipmentItemsBylistID(shipmentRef);
            decimal sumProductQty = 0;
            shipmentitemsList.ForEach(p =>
            {
                sumProductQty += p.ICShipmentItemProductQty;
            });
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblSumProductQty"];
            if (accLabel != null)
            {
                accLabel.Text = sumProductQty.ToString();
            }

            report.DataSource = shipmentitemsList;
        }

        public void PrintMaterialShipmentTV()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            object[] arParam = new object[1];
            arParam[0] = objShipmentsInfo.ICShipmentID;
            ViewReportByTemplate("RPShipmentTV", "GetDataSourceForRPShipmentTV", arParam);
        }

        public void NewFromAllocationPlanOtherMaterial()
        {
            ActionNew();
            ShowAllocationPlan(AllocationPlanItemGroup.OtherMaterial.ToString());
        }

        public void NewFromAllocationPlanHardware()
        {
            ActionNew();
            ShowAllocationPlan(AllocationPlanItemGroup.Hardware.ToString());
        }

        public void NewFromAllocationPlanIngredientPaint()
        {
            ActionNew();
            ShowAllocationPlan(AllocationPlanItemGroup.IngredientPaint.ToString());
        }

        public void NewFromAllocationPlanIngredientPackaging()
        {
            ActionNew();
            ShowAllocationPlan(AllocationPlanItemGroup.IngredientPackaging.ToString());
        }

        public void NewFromAllocationPlanGeneralMaterial()
        {
            ActionNew();
            ShowAllocationPlan(AllocationPlanItemGroup.GeneralMaterial.ToString());
        }

        public void ShowAllocationPlan(string allocationGroup)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            guiAllocationPlanItems guiFind = new guiAllocationPlanItems();
            guiFind.Module = this;
            guiFind.AllocationPlanItemGroup = allocationGroup;
            guiFind.MMAllocationPlanID = mainobject.FK_MMAllocationPlanID;
            guiFind.MMBatchProductID = mainobject.FK_MMBatchProductID;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            List<MMAllocationPlanItemsInfo> selectedList = guiFind.SelectedObjects;
            if (selectedList.Count() == 0)
                return;

            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = guiFind.SelectedObjects.FirstOrDefault();
            mainobject.FK_MMBatchProductID = objAllocationPlanItemsInfo.FK_MMBatchProductID;
            mainobject.ICShipmentShipmentType = allocationGroup;
            mainobject.FK_MMAllocationPlanID = objAllocationPlanItemsInfo.FK_MMAllocationPlanID;
            mainobject.FK_ACObjectID = objAllocationPlanItemsInfo.FK_ACObjectID;
            mainobject.ICObjectType = objAllocationPlanItemsInfo.MMObjectType;
            mainobject.ACObjectAccessKey = mainobject.FK_ACObjectID + ";" + mainobject.ICObjectType;
            mainobject.FK_ARSaleOrderID = objAllocationPlanItemsInfo.FK_ARSaleOrderID;
            mainobject.ICShipmentDesc = objAllocationPlanItemsInfo.MMAllocationPlanDesc;
            mainobject.FK_HREmployeeReceverID
                = selectedList.FirstOrDefault(p => p.FK_HREmployeeIDReceive != 0) != null
                ? selectedList.FirstOrDefault(p => p.FK_HREmployeeIDReceive != 0).FK_HREmployeeIDReceive
                : 0;
            mainobject.FK_MMWorkShopID
                = selectedList.FirstOrDefault(p => p.FK_MMWorkShopID != 0) != null
                ? selectedList.FirstOrDefault(p => p.FK_MMWorkShopID != 0).FK_MMWorkShopID
                : 0;
            mainobject.FK_MMLineID
                = selectedList.FirstOrDefault(p => p.FK_MMLineID != 0) != null
                ? selectedList.FirstOrDefault(p => p.FK_MMLineID != 0).FK_MMLineID
                : 0;
            mainobject.ICShipmentSOName = string.Join(", ", selectedList.Where(o => !string.IsNullOrWhiteSpace(o.MMAllocationPlanItemSOName)).Select(o => o.MMAllocationPlanItemSOName).Distinct().ToArray());
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            selectedList.ForEach(o =>
            {
                objShipmentItemsInfo = ToShipmentItems(o);
                entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
                shipmentItemList.Add(objShipmentItemsInfo);
            });
            entity.ShipmentItemList.AddRange(shipmentItemList);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            List<ICShipmentItemVMsInfo> totalList = entity.GenerateTotalShipmentItemsList(shipmentItemList);
            entity.TotalShipmentItemsList.AddRange(totalList);
            if (entity.TotalShipmentItemsList.GridControl != null)
            {
                entity.TotalShipmentItemsList.GridControl.RefreshDataSource();
            }
            entity.UpdateMainObjectBindingSource();
            AllocationPlanButton.Visible = true;
        }

        public void ShowAllocationPlanItem()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            guiAllocationPlanItems guiFind = new guiAllocationPlanItems();
            guiFind.Module = this;
            guiFind.AllocationPlanItemGroup = mainobject.ICShipmentShipmentType;
            guiFind.MMAllocationPlanID = mainobject.FK_MMAllocationPlanID;
            guiFind.MMBatchProductID = mainobject.FK_MMBatchProductID;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            List<MMAllocationPlanItemsInfo> selectedList = guiFind.SelectedObjects;
            if (selectedList.Count() == 0)
                return;

            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            selectedList.ForEach(o =>
            {
                objShipmentItemsInfo = ToShipmentItems(o);
                entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
                shipmentItemList.Add(objShipmentItemsInfo);
            });
            entity.ShipmentItemList.AddRange(shipmentItemList);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            List<ICShipmentItemVMsInfo> totalList = entity.GenerateTotalShipmentItemsList(shipmentItemList);
            entity.TotalShipmentItemsList.AddRange(totalList);
            if (entity.TotalShipmentItemsList.GridControl != null)
            {
                entity.TotalShipmentItemsList.GridControl.RefreshDataSource();
            }
        }

        public ICShipmentItemsInfo ToShipmentItems(MMAllocationPlanItemsInfo item)
        {
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == item.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsForViewInfo();

            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            BOSUtil.CopyObject(objProductsInfo, objShipmentItemsInfo);
            objShipmentItemsInfo.FK_ICProductID = item.FK_ICProductID;
            objShipmentItemsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
            objShipmentItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
            objShipmentItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
            objShipmentItemsInfo.FK_MMAllocationPlanID = item.FK_MMAllocationPlanID;
            objShipmentItemsInfo.FK_MMAllocationPlanItemID = item.Id;
            objShipmentItemsInfo.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
            objShipmentItemsInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
            objShipmentItemsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
            objShipmentItemsInfo.FK_MMLineID = item.FK_MMLineID;
            objShipmentItemsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
            objShipmentItemsInfo.FK_ICStockID = mainobject.FK_ICStockID;
            objShipmentItemsInfo.FK_MMOperationID = item.FK_MMOperationID == 0 ? mainobject.FK_MMOperationID : item.FK_MMOperationID;
            objShipmentItemsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
            objShipmentItemsInfo.FK_HREmployeeReceverID = item.FK_HREmployeeIDReceive;
            objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID;
            objShipmentItemsInfo.ICShipmentItemProductName = item.MMAllocationPlanItemProductName;
            objShipmentItemsInfo.ICShipmentItemProductDesc = item.MMAllocationPlanItemProductDesc;
            objShipmentItemsInfo.ICShipmentItemProductQty = item.MMAllocationPlanItemQty;
            objShipmentItemsInfo.ICShipmentItemLength = item.MMAllocationPlanItemLength;
            objShipmentItemsInfo.ICShipmentItemWidth = item.MMAllocationPlanItemWidth;
            objShipmentItemsInfo.ICShipmentItemHeight = item.MMAllocationPlanItemHeight;
            objShipmentItemsInfo.ICShipmentItemComment = item.MMAllocationPlanItemComment;
            objShipmentItemsInfo.ICShipmentItemProductExchangeQty = item.MMAllocationPlanItemQty;
            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
            objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.MMAllocationPlanItemBatchProductItemProductSerial;
            objShipmentItemsInfo.ICShipmentItemQty6 = item.MMAllocationPlanItemNormQty;
            objShipmentItemsInfo.ICShipmentItemProductName2 = item.ICProductName2;
            objShipmentItemsInfo.VirtualID = Guid.NewGuid();
            objShipmentItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
            objShipmentItemsInfo.ICShipmentItemSOName = item.MMAllocationPlanItemSOName;
            return objShipmentItemsInfo;
        }

        public void ChangeWorkShop(int workshopID)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            mainobject.FK_MMWorkShopID = workshopID;
            entity.ShipmentItemList.ForEach(o =>
            {
                o.FK_MMWorkShopID = workshopID;
            });
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeLine(int lineID)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            mainobject.FK_MMLineID = lineID;
            entity.ShipmentItemList.ForEach(o =>
            {
                o.FK_MMLineID = lineID;
            });
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            entity.UpdateMainObjectBindingSource();
        }

        public bool IsValidShipmentQty(ICShipmentItemsInfo item, string columnName)
        {
            decimal oldProductFactor = item.ICShipmentItemProductFactor;
            if (columnName == "FK_ICMeasureUnitID")
            {
                ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                item.ICShipmentItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0) ? measureUnit.ICProductMeasureUnitFactor : 1;
            }
            bool isValid = true;
            isValid = IsValidAllocationProposalQty(item);
            if (!isValid)
            {
                item.ICShipmentItemProductFactor = oldProductFactor;
                return false;
            }
            return isValid;
        }

        public bool IsValidAllocationProposalQty(ICShipmentItemsInfo item)
        {
            if (item.FK_MMAllocationPlanItemID == 0)
                return true;

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = objAllocationPlanItemsController.GetRemainQtyForShipmentByID(item.FK_MMAllocationPlanItemID, item.Id);
            if (objAllocationPlanItemsInfo == null)
                return true;

            if (item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor <= objAllocationPlanItemsInfo.MMAllocationPlanItemRemainQty + objAllocationPlanItemsInfo.MMAllocationPlanItemTolenrancePlus)
                return true;

            string errorMessage = string.Format("Sản phẩm {0} có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể cấp phát là: {1}", item.ICShipmentItemProductName
                    , (objAllocationPlanItemsInfo.MMAllocationPlanItemRemainQty + +objAllocationPlanItemsInfo.MMAllocationPlanItemTolenrancePlus).ToString("n3"));
            MessageBox.Show(errorMessage, BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool IsValidShipmentQtyForList()
        {
            bool isValid = true;
            isValid = IsValidAllocationProposalForList();
            if (!isValid)
                return false;

            return isValid;
        }

        public bool IsValidAllocationProposalForList()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            List<ICShipmentItemsInfo> checkShipmentList = entity.ShipmentItemList.Where(o => o.FK_MMAllocationPlanItemID > 0).ToList();
            if (checkShipmentList.Count() == 0)
                return true;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();

            var planItemIds = checkShipmentList.Select(o => o.FK_MMAllocationPlanItemID).Distinct().ToList();
            var shipmentItemIds = checkShipmentList.Select(o => o.Id).Distinct().ToList();
            string productIdRef = string.Join(",", checkShipmentList.Select(o => o.FK_ICProductID.ToString()).Distinct().ToArray());
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> remainPlanList = objAllocationPlanItemsController.GetRemainQtyForShipment(planItemIds, shipmentItemIds);
            if (remainPlanList.Any(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Approved.ToString() && o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Allocated.ToString()))
            {
                MessageBox.Show("Trạng thái KHSD không phù hợp. Vui lòng kiểm tra lại!", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string messageError = string.Empty;
            decimal sumShipmentQty = 0;
            decimal tolenrancePlus = 0;
            decimal remainPlanQty = 0;
            List<ICProductTolenrancesInfo> configList = (new ICProductTolenrancesController()).GetProductTolenranceByIDAndType(productIdRef, ProductTolenranceType.Manufacturing.ToString());
            ICProductTolenrancesInfo config = new ICProductTolenrancesInfo();
            foreach (ICShipmentItemVMsInfo item in entity.TotalShipmentItemsList)
            {
                if (item.MMAllocationPlanItemRef.IsNullOrWhiteSpace())
                    continue;

                string[] planIDs = item.MMAllocationPlanItemRef.Split(',');
                if (planIDs.Length == 0)
                    continue;

                config = configList.Where(o => o.FK_ICProductID == item.FK_ICProductID).FirstOrDefault();
                if (config == null)
                    config = new ICProductTolenrancesInfo();

                sumShipmentQty = checkShipmentList.Where(s => planIDs.Any(p => int.Parse(p) == s.FK_MMAllocationPlanItemID)).Sum(s => s.ICShipmentItemProductExchangeQty);
                remainPlanQty = remainPlanList.Where(s => planIDs.Any(p => int.Parse(p) == s.Id)).Sum(s => s.MMAllocationPlanItemRemainQty);

                int roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == item.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum) != null ?
                measureUnitList.Where(u => u.ICMeasureUnitID == item.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault() : 6;

                remainPlanQty = BOSApp.RoundUp(remainPlanQty, roundNum);
                if (config.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Percent.ToString())
                    tolenrancePlus = remainPlanQty * config.ICProductTolenrancePlus / 100;
                else if (config.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Quantity.ToString())
                    tolenrancePlus = config.ICProductTolenrancePlus;

                if (remainPlanQty + tolenrancePlus - sumShipmentQty < 0)
                {
                    messageError += string.Format("Sản phẩm: [{0}], lô SX: {2} có số lượng lớn hơn số lượng KH còn lại. Số lượng có thể cấp phát là: {1}",
                        item.ICShipmentItemProductName, (remainPlanQty + tolenrancePlus).ToString("n6"), item.ICShipmentItemBatchProductItemProductSerial);
                    messageError += Environment.NewLine;
                }
            }
            //remainPlanList.ForEach(o =>
            //{
            //    sumShipmentQty = checkShipmentList.Where(s => s.FK_MMAllocationPlanItemID == o.MMAllocationPlanItemID).Sum(s => s.ICShipmentItemProductExchangeQty);

            //    if (o.MMAllocationPlanItemRemainQty - sumShipmentQty >= 0)
            //        return;

            //    messageError += string.Format("Sản phẩm [{0}] có số lượng lớn hơn số lượng đề nghị. Số lượng có thể cấp phát là: {1}", o.MMAllocationPlanItemProductName, o.MMAllocationPlanItemRemainQty.ToString("n3"));
            //    messageError += Environment.NewLine;
            //});
            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui lòng kiểm tra lại!";
            MessageBox.Show(messageError, BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void DiscardShipment()
        {
            if (!Toolbar.IsNullOrNoneAction())
                return;

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn hủy chứng từ này?", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (rs != DialogResult.Yes)
                return;

            entity.SetPropertyChangeEventLock(false);
            mainobject.ICShipmentStatus = ShipmentStatus.Canceled.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
        }

        public override void ActionDelete()
        {
            base.ActionDelete();
        }

        public void ChangeItemVM(ICShipmentItemVMsInfo item)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            List<ICShipmentItemsInfo> shipmentItemList = entity.ShipmentItemList.Where(o => itemRef.Contains(o.VirtualID)).ToList();
            SynItemData(item, shipmentItemList);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            //UpdateDocumentEntries();
        }

        public void ChangeItemVMProductUnitCost(ICShipmentItemVMsInfo item)
        {
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            decimal inventoryQty = objTransactionsController.GetInventoryStockQty(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, mainobject.ICShipmentDate);
            decimal oldQty = item.ICShipmentItemProductQty;
            if (item.ICShipmentItemProductQty > inventoryQty)
            {
                item.ICShipmentItemProductQty = inventoryQty;
                ChangeShipmentItemVMQty(item, string.Empty, out bool isSuccess);
                if (!isSuccess)
                {
                    item.ICShipmentItemProductQty = oldQty;
                }
                item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
            }
            decimal unitcost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, mainobject.ICShipmentDate);
            item.ICShipmentItemProductUnitCost = unitcost * item.ICShipmentItemProductFactor;
            item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductQty;
        }

        public void DeleteItemVM()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentItemVMsInfo item = entity.TotalShipmentItemsList[entity.TotalShipmentItemsList.CurrentIndex];
            if (string.IsNullOrWhiteSpace(item.ICShipmentItemRef))
                return;

            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            itemRef.ForEach(o =>
            {
                entity.ShipmentItemList.RemoveAll(s => s.VirtualID == o);
            });
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            entity.TotalShipmentItemsList.RemoveSelectedRowObjectFromList();
            //UpdateDocumentEntries();
        }

        public void CopyNewItemVM()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentItemVMsInfo item = entity.TotalShipmentItemsList[entity.TotalShipmentItemsList.CurrentIndex];
            ICShipmentItemVMsInfo itemVMClone = (ICShipmentItemVMsInfo)item.Clone();
            itemVMClone.ICShipmentItemProductQty = 0;
            itemVMClone.ICShipmentItemProductExchangeQty = 0;
            if (string.IsNullOrWhiteSpace(item.ICShipmentItemRef))
                return;

            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICShipmentItemsInfo itemClone = new ICShipmentItemsInfo();
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            itemRef.ForEach(o =>
            {
                itemClone = new ICShipmentItemsInfo();
                itemClone = entity.ShipmentItemList.Where(si => si.VirtualID == o).Select(si => (ICShipmentItemsInfo)si.Clone()).FirstOrDefault();
                itemClone.Id = 0;
                itemClone.ICShipmentItemProductQty = 0;
                itemClone.VirtualID = Guid.NewGuid();
                entity.SetProductPriceByProductUnitPrice(itemClone);
                ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)(new ICProductSeriesController()).GetObjectByID(itemClone.FK_ICProductSerieID);
                if (objProductSeriesInfo != null)
                {
                    itemClone.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    itemClone.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                    itemClone.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                }
                if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(p => p.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == itemClone.FK_ICProductID);
                if (product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && itemClone.ICShipmentItemLength * itemClone.ICShipmentItemHeight * itemClone.ICShipmentItemWidth * itemClone.ICShipmentItemWoodQty != 0M)
                {
                    itemClone.ICShipmentItemProductQty = itemClone.ICShipmentItemLength * itemClone.ICShipmentItemHeight * itemClone.ICShipmentItemWidth * itemClone.ICShipmentItemWoodQty / 1000000000;
                    itemClone.ICShipmentItemProductExchangeQty = itemClone.ICShipmentItemProductQty * itemClone.ICShipmentItemProductFactor;
                    itemClone.ICShipmentItemProductQty = Math.Round(itemClone.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    itemClone.ICShipmentItemProductExchangeQty = Math.Round(itemClone.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                }
                shipmentItemList.Add(itemClone);
            });
            entity.ShipmentItemList.AddRange(shipmentItemList);
            itemVMClone.ICShipmentItemRef = string.Join(",", shipmentItemList.Select(o => o.VirtualID.ToString()).ToArray());
            entity.TotalShipmentItemsList.Add(itemVMClone);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            if (entity.TotalShipmentItemsList.GridControl != null)
            {
                entity.TotalShipmentItemsList.GridControl.RefreshDataSource();
            }
            //UpdateDocumentEntries();
        }

        public void SynItemQty(ICShipmentItemVMsInfo item, IList<ICShipmentItemsInfo> shipmentItemList, List<ICMeasureUnitsInfo> measureUnitList, List<MMAllocationPlanItemsInfo> listRemainQty, decimal totalAllocationQty, decimal totalPlus = 0)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            decimal remainPlanQty = 0;
            decimal sameItemQty = 0;

            decimal rateWithTotalQty = 0;
            decimal totalNormQty = listRemainQty.Sum(o => o.MMAllocationPlanItemRemainQty);
            decimal tolenrancePlus = 0;
            int roundNum = 0;
            decimal allocationQty = 0;
            shipmentItemList.OrderByDescending(o => o.ICShipmentItemProductQty).ForEach(o =>
            {
                if (o.FK_MMAllocationPlanItemID == 0)
                {
                    o.ICShipmentItemProductQty = totalAllocationQty;
                    entity.SetProductPriceByProductUnitPrice(o);
                    allocationQty = o.ICShipmentItemProductQty;
                    return;
                }
                remainPlanQty = listRemainQty.Where(p => p.Id == o.FK_MMAllocationPlanItemID).Select(p => p.MMAllocationPlanItemRemainQty).FirstOrDefault();
                sameItemQty = entity.ShipmentItemList.Where(si => si.FK_MMAllocationPlanItemID == o.FK_MMAllocationPlanItemID && o.VirtualID != si.VirtualID).Sum(si => si.ICShipmentItemProductExchangeQty);
                sameItemQty = o.ICShipmentItemProductFactor == 0 ? sameItemQty : sameItemQty / o.ICShipmentItemProductFactor;
                rateWithTotalQty = totalNormQty == 0 ? 0 : (remainPlanQty - sameItemQty) / totalNormQty;
                o.ICShipmentItemProductQty = (rateWithTotalQty * totalAllocationQty);
                roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == o.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault();
                o.ICShipmentItemProductQty = Math.Round(o.ICShipmentItemProductQty, roundNum, MidpointRounding.ToEven);
                o.ICShipmentItemProductQty = o.ICShipmentItemProductQty < 0 ? 0 : o.ICShipmentItemProductQty;
                allocationQty += o.ICShipmentItemProductQty;
                o.ICShipmentItemProductExchangeQty = o.ICShipmentItemProductQty * o.ICShipmentItemProductFactor;
            });

            if (allocationQty == totalAllocationQty)
            {
                item.ICShipmentItemProductQty = shipmentItemList.Sum(o => o.ICShipmentItemProductQty);
                item.ICShipmentItemWoodQty = shipmentItemList.Sum(o => o.ICShipmentItemWoodQty);
                item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                return;
            }
            decimal calOperation = totalAllocationQty - allocationQty > 0 ? 1 : -1;
            totalAllocationQty = Math.Abs(totalAllocationQty - allocationQty);
            allocationQty = 0;
            decimal oldQty = 0;
            shipmentItemList.ForEach(o =>
            {
                if (totalAllocationQty == 0)
                    return;

                remainPlanQty = listRemainQty.Where(p => p.Id == o.FK_MMAllocationPlanItemID).Select(p => p.MMAllocationPlanItemRemainQty).FirstOrDefault();
                sameItemQty = entity.ShipmentItemList.Where(si => si.FK_MMAllocationPlanItemID == o.FK_MMAllocationPlanItemID && o.VirtualID != si.VirtualID).Sum(si => si.ICShipmentItemProductExchangeQty);
                sameItemQty = o.ICShipmentItemProductFactor == 0 ? sameItemQty : sameItemQty / o.ICShipmentItemProductFactor;
                rateWithTotalQty = totalNormQty == 0 ? 0 : (remainPlanQty - sameItemQty) / totalNormQty;
                tolenrancePlus = rateWithTotalQty * totalPlus;
                oldQty = o.ICShipmentItemProductQty;
                roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == o.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault();
                o.ICShipmentItemProductQty = o.ICShipmentItemProductQty + calOperation * totalAllocationQty;
                o.ICShipmentItemProductQty = o.ICShipmentItemProductQty > (BOSApp.RoundUp(remainPlanQty,roundNum) - sameItemQty + tolenrancePlus)
                                                    ? (BOSApp.RoundUp(remainPlanQty, roundNum) - sameItemQty + tolenrancePlus) : o.ICShipmentItemProductQty;
                o.ICShipmentItemProductQty = o.ICShipmentItemProductQty < 0 ? 0 : o.ICShipmentItemProductQty;
                o.ICShipmentItemProductQty = Math.Round(o.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                o.ICShipmentItemProductExchangeQty = o.ICShipmentItemProductQty * o.ICShipmentItemProductFactor;

                totalAllocationQty = totalAllocationQty - Math.Abs((o.ICShipmentItemProductQty - oldQty));
            });
            item.ICShipmentItemProductQty = shipmentItemList.Sum(o => o.ICShipmentItemProductQty);
            item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
        }

        public void SynItemData(ICShipmentItemVMsInfo item, IList<ICShipmentItemsInfo> shipmentItemList)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductExchangeQty;
            shipmentItemList.ForEach(o =>
            {
                o.FK_MMWorkShopID = item.FK_MMWorkShopID;
                o.FK_MMLineID = item.FK_MMLineID;
                o.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                o.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
                o.ICShipmentItemProductFactor = item.ICShipmentItemProductFactor;
                o.FK_ICProductSerieID = item.FK_ICProductSerieID;
                o.ICShipmentItemProductSerialNo = item.ICShipmentItemProductSerialNo;
                o.FK_ICStockID = item.FK_ICStockID;
                o.ICShipmentItemComment = item.ICShipmentItemComment;
                o.ICShipmentItemProductUnitCost = item.ICShipmentItemProductUnitCost;
                o.ICShipmentItemIsSpecificCalculation = item.ICShipmentItemIsSpecificCalculation;
                if (o.FK_MMBatchProductProductionNormItemID == 0)
                {
                    o.FK_MMBatchProductID = item.FK_MMBatchProductID;
                    o.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
                    o.ICShipmentItemBatchProductItemProductSerial = item.ICShipmentItemBatchProductItemProductSerial;
                    o.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                    o.FK_MMOperationID = item.FK_MMOperationID;
                }
                entity.SetProductPriceByProductUnitPrice(o);
            });
        }

        private List<MMAllocationPlanItemsInfo> GetRemainQtyForShipment(int productID, string planItemRef, string shipmentItemRefID, out decimal remainPlanQty, out decimal tolenrancePlus, bool hasTolenrance = true)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            tolenrancePlus = 0;
            var planItemIds = new List<int>();
            var shipmentItemIds = new List<int>();

            if (!planItemRef.IsNullOrWhiteSpace())
                planItemIds = planItemRef.Split(',').AsEnumerable().Select(o => Int32.Parse(o)).ToList();
            if (!shipmentItemRefID.IsNullOrWhiteSpace())
                shipmentItemIds = entity.ShipmentItemList.Where(o => planItemIds.Contains(o.FK_MMAllocationPlanItemID) && o.Id > 0).Select(o => o.Id).ToList();

            List<MMAllocationPlanItemsInfo> listRemainQty = (new MMAllocationPlanItemsController()).GetRemainQtyForShipment(planItemIds, shipmentItemIds);
            remainPlanQty = listRemainQty.Sum(o => o.MMAllocationPlanItemRemainQty);
            if (hasTolenrance)
            {
                ICProductTolenrancesInfo config = (new ICProductTolenrancesController()).GetProductTolenranceByIDAndType(productID, ProductTolenranceType.Manufacturing.ToString());
                if (config == null)
                    config = new ICProductTolenrancesInfo();

                if (config.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Percent.ToString())
                    tolenrancePlus = remainPlanQty * config.ICProductTolenrancePlus / 100;
                else if (config.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Quantity.ToString())
                    tolenrancePlus = config.ICProductTolenrancePlus;
            }
            return listRemainQty;
        }

        public void ChangeShipmentItemVMQty(ICShipmentItemVMsInfo item, string columnName, out bool isSuccess)
        {
            isSuccess = true;
            if (Toolbar.IsNullOrNoneAction())
                return;

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            decimal oldProductFactor = item.ICShipmentItemProductFactor;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();
            if (columnName == "FK_ICMeasureUnitID")
            {
                ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                item.ICShipmentItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0) ? measureUnit.ICProductMeasureUnitFactor : 1;
                if (oldProductFactor > 0 && oldProductFactor != item.ICShipmentItemProductFactor && item.ICShipmentItemProductQty > 0)
                {
                    item.ICShipmentItemProductQty = (item.ICShipmentItemProductQty * oldProductFactor) / item.ICShipmentItemProductFactor;

                }
                if (oldProductFactor > 0 && oldProductFactor != item.ICShipmentItemProductFactor && item.ICShipmentItemProductUnitCost > 0)
                {
                    decimal unitCost = (item.ICShipmentItemProductUnitCost / oldProductFactor) * item.ICShipmentItemProductFactor;
                    decimal qty = item.ICShipmentItemProductQty / item.ICShipmentItemProductFactor;
                    item.ICShipmentItemProductUnitCost = unitCost;
                    item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductQty;

                }
                
            }
            decimal tolenrancePlus = 0;
            decimal remainPlanQty = 0;
            decimal remainComparePlanQty = 0;
            decimal maxAllocationQty = 0;

            List<MMAllocationPlanItemsInfo> listRemainQty = GetRemainQtyForShipment(item.FK_ICProductID, item.MMAllocationPlanItemRef, item.ICShipmentItemRefID, out remainPlanQty, out tolenrancePlus);
            decimal sameItemQty = entity.TotalShipmentItemsList.Where(o => o.MMAllocationPlanItemRef == item.MMAllocationPlanItemRef && item.ICShipmentItemRef != o.ICShipmentItemRef).Sum(o => o.ICShipmentItemProductExchangeQty);
            
            sameItemQty = sameItemQty / (item.ICShipmentItemProductFactor > 0 ? item.ICShipmentItemProductFactor : 1);
            if (mainobject.STToolbarActionName == "Manual") sameItemQty = 0;
            remainPlanQty = remainPlanQty + tolenrancePlus - sameItemQty;

            int roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == item.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum) != null ?
                measureUnitList.Where(u => u.ICMeasureUnitID == item.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault() : 6;

            remainPlanQty = Math.Round(remainPlanQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            remainComparePlanQty = BOSApp.RoundUp(remainPlanQty, roundNum);

            if (mainobject.STToolbarActionName == "Manual") remainPlanQty = item.ICShipmentItemProductQty;
            maxAllocationQty = Math.Min(item.ICShipmentItemProductQty, remainComparePlanQty);

            maxAllocationQty = Math.Round(maxAllocationQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            if (!string.IsNullOrEmpty(item.MMAllocationPlanItemRef) && Math.Round( item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor,6, MidpointRounding.AwayFromZero) > BOSApp.RoundUp(remainPlanQty, roundNum) && columnName != "FK_ICMeasureUnitID")
            {
                MessageBox.Show(string.Format("Sản phẩm [{0}] có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể xuất kho là: {1}", item.ICShipmentItemProductName, remainPlanQty.ToString("n6")),
                                BaseLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                item.ICShipmentItemProductFactor = oldProductFactor;
                isSuccess = false;
                return;
            }
            item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            List<ICShipmentItemsInfo> shipmentItemList = entity.ShipmentItemList.Where(o => itemRef.Contains(o.VirtualID)).ToList();

            
            SynItemQty(item, shipmentItemList, measureUnitList, listRemainQty, maxAllocationQty, tolenrancePlus);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            if (entity.TotalShipmentItemsList.GridControl != null)
            {
                entity.TotalShipmentItemsList.GridControl.RefreshDataSource();
            }
            //UpdateDocumentEntries();
        }

        public List<APPurchaseOrdersInfo> GetPurcharseOrderOfBatchProduct()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;

            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            List<APPurchaseOrdersInfo> purchareOrderList = objPurchaseOrdersController.GetPurchaseOrderOutSourcingByBatchProductID(mainobject.FK_MMBatchProductID);
            purchareOrderList.Insert(0, new APPurchaseOrdersInfo());
            return purchareOrderList;
        }

        public void DisableWorkShopLookUpEdit(bool isDisable, int batchProductID)
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            if (WorkShopLookUpEditControl == null)
                return;

            WorkShopLookUpEditControl.Enabled = isDisable;
            UpdateWorkShopFollowUpBatchProduct(batchProductID);
        }

        public void UpdateWorkShopFollowUpBatchProduct(int batchProductID)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;

            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectByID(batchProductID);
            if (objBatchProductsInfo != null)
            {
                mainobject.FK_MMWorkShopID = objBatchProductsInfo.FK_MMWorkShopID;
            }
            else
            {
                mainobject.FK_MMWorkShopID = 0;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public override bool ActionCancelComplete()
        {
            if (!CheckLock()) return false;
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn mở chứng từ này không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return false;

            ICShipmentsController objShipmentsController = new ICShipmentsController();
            string receiptRef = objShipmentsController.IsAllowCancelComplete(mainobject.ICShipmentID);
            if (!string.IsNullOrWhiteSpace(receiptRef))
            {
                MessageBox.Show(string.Format("Chứng từ đã tồn tại phiếu nhập {0}. Vui lòng kiểm tra lại!", receiptRef), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ICShipmentItemsInfo itemValidate = entity.ShipmentItemList.FirstOrDefault(o => o.FK_ACUnfinishedConstructionCostID > 0);
            if (itemValidate != null)
            {
                ACUnfinishedConstructionCostsController unfinishedCostController = new ACUnfinishedConstructionCostsController();
                ACUnfinishedConstructionCostsInfo unfinishedCost = new ACUnfinishedConstructionCostsInfo();

                foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                {
                    unfinishedCost = unfinishedCostController.GetObjectByID(item.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                    if (unfinishedCost != null
                            && (unfinishedCost.ACUnfinishedConstructionCostStatus == UnfinishedConstructionCostStatus.Complete.ToString()
                                || unfinishedCost.ACUnfinishedConstructionCostStatus == UnfinishedConstructionCostStatus.ChuyenTSCD.ToString()))
                    {
                        MessageBox.Show(string.Format("Chi phí XDCB dở dang {0} ({1}) đã Hoàn tất hoặc Ghi tăng tài sản"
                                                        + Environment.NewLine + "Bạn không thể thực hiện thao tác này!", unfinishedCost.ACUnfinishedConstructionCostNo, unfinishedCost.ACUnfinishedConstructionCostName)
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return base.ActionCancelComplete();
        }

        public override void ActionPosted()
        {
            if (!CheckLock()) return;
            base.ActionPosted();
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            entity.UpdateUnifinishedCost(true);
        }

        public override void ActionUnPosted()
        {
            if (!CheckLock()) return;
            base.ActionUnPosted();
            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            entity.UpdateUnifinishedCost(false);
        }

        public void CalculatedProductQtyVMByPackageVolumnConfig(ICShipmentItemVMsInfo item)
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            if (item != null)
            {
                ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)(new ICProductSeriesController()).GetObjectByID(item.FK_ICProductSerieID);
                if (objProductSeriesInfo != null)
                {
                    item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                    item.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                }
                if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if (product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemWoodQty != 0M)
                {
                    item.ICShipmentItemProductQty = item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemWoodQty / 1000000000;
                    item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                    item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    item.ICShipmentItemProductExchangeQty = Math.Round(item.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    entity.ShipmentItemList.GridControl?.RefreshDataSource();
                }
            }
        }

        public void AutoSelectProductSerialNo()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }

            MaterialShipmentEntities entity = (MaterialShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            if (entity.ShipmentItemList.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm xuất kho để gắn mã lô!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            entity.ShipmentItemList.ForEach(o => o.ICShipmentDate = mainObject.ICShipmentDate);
            List<ICShipmentItemsInfo> listShipmentItems = new List<ICShipmentItemsInfo>();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            foreach (ICShipmentItemVMsInfo itemVM in entity.TotalShipmentItemsList)
            {
                objShipmentItemsInfo = new ICShipmentItemsInfo();
                objShipmentItemsInfo.FK_ICProductID = itemVM.FK_ICProductID;
                objShipmentItemsInfo.FK_ICStockID = itemVM.FK_ICStockID;
                objShipmentItemsInfo.ICShipmentItemProductExchangeQty = itemVM.ICShipmentItemProductExchangeQty;
                objShipmentItemsInfo.ICShipmentDate = mainObject.ICShipmentDate;
                listShipmentItems.Add(objShipmentItemsInfo);
            }    
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            listShipmentItems = objShipmentItemsController.GetListInventoryStockSerialNoForShipment(listShipmentItems);
            listShipmentItems = listShipmentItems.OrderBy(o => o.ICProductSerieReceiptDate).ToList();
            ICShipmentItemsInfo shipmentItemQty = new ICShipmentItemsInfo();
            foreach (ICShipmentItemVMsInfo itemVM in entity.TotalShipmentItemsList)
            {
                shipmentItemQty = listShipmentItems.FirstOrDefault(o => o.FK_ICProductID == itemVM.FK_ICProductID && o.ICShipmentItemProductExchangeQty >= itemVM.ICShipmentItemProductExchangeQty);
                if (shipmentItemQty != null)
                {
                    itemVM.FK_ICStockID = shipmentItemQty.FK_ICStockID;
                    itemVM.FK_ICProductSerieID = shipmentItemQty.FK_ICProductSerieID;
                    itemVM.ICShipmentItemProductSerialNo = shipmentItemQty.ICShipmentItemProductSerialNo;
                    itemVM.ICShipmentItemLotNo = shipmentItemQty.ICShipmentItemLotNo;
                    shipmentItemQty.ICShipmentItemProductExchangeQty -= itemVM.ICShipmentItemProductExchangeQty;
                    ChangeItemVMProductUnitCost(itemVM);
                    CalculatedProductQtyVMByPackageVolumnConfig(itemVM);
                    ChangeItemVM(itemVM);
                }
            }
            entity.TotalShipmentItemsList.GridControl?.RefreshDataSource();
        }
    }
    #endregion

}
