using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Enums;
using BOSCommon.Extensions;
using BOSComponent;
using BOSERP.GenaralLeadger;
using BOSERP.Modules.IC.BatchShipmentDryLumber.Localization;
using BOSLib;
using BOSReport;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentDryLumber
{
    #region BatchShipmentDryLumber
    public class BatchShipmentDryLumberModule : GLShipmentModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItem1s";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string ButtonShowInventoryStock = "fld_btnShowInventoryStock";
        public const string ProductItemLookupEditControlName = "fld_lkeFK_ICProductID";
        public const string MMOperationLookupEditControlName = "fld_lkeFK_MMOperationID";
        public const string WorkShopLookUpEditControlName = "fld_lkeFK_MMWorkShopID";
        public const string BatchProductLookupEditControlName = "fld_lkeFK_MMBatchProductID";
        public const string LineLookupEditControlName = "fld_lkeFK_LineID";
        public const string EmployeeReceverLookupEditControlName = "fld_lkeFK_HREmployeeReceverID";
        #endregion
        #region Private Properties

        BOSComponent.BOSButton InventoryStock;

        public ItemLookupEdit ProductItemLookupEdit;
        BOSLookupEdit fld_lkeICShipmentTypeCombo;
        ICShipmentItemVMsGridControl fld_dgcShipmentItemVMsGridControl;
        BOSComponent.BOSLookupEdit MMOperationLookupEditControl;
        BOSComponent.BOSLookupEdit WorkShopLookUpEditControl;
        BOSComponent.BOSLookupEdit BatchProductLookupEditControl;
        BOSComponent.BOSLookupEdit LineLookupEditControl;
        BOSComponent.BOSLookupEdit EmployeeReceverLookupEditControl;
        #endregion
        public BatchShipmentDryLumberModule()
        {
            Name = "BatchShipmentDryLumber";
            CurrentModuleEntity = new BatchShipmentDryLumberEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            InventoryStock = (BOSComponent.BOSButton)Controls[BatchShipmentDryLumberModule.ButtonShowInventoryStock];
            ProductItemLookupEdit = (ItemLookupEdit)Controls[ProductItemLookupEditControlName];
            fld_lkeICShipmentTypeCombo = (BOSLookupEdit)Controls["fld_lkeICShipmentTypeCombo"];
            fld_dgcShipmentItemVMsGridControl = (ICShipmentItemVMsGridControl)Controls["fld_dgcShipmentItemVMsGridControl"];
            MMOperationLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MMOperationLookupEditControlName];
            WorkShopLookUpEditControl = (BOSComponent.BOSLookupEdit)Controls[BatchShipmentDryLumberModule.WorkShopLookUpEditControlName];
            BatchProductLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[BatchShipmentDryLumberModule.BatchProductLookupEditControlName];
            LineLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[BatchShipmentDryLumberModule.LineLookupEditControlName];
            EmployeeReceverLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[BatchShipmentDryLumberModule.EmployeeReceverLookupEditControlName];
            UpdateDataSourceForAnyLookUp();
            InitializeOperationlookupDataSource();
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
        public void UpdateDataSourceForAnyLookUp()
        {
            List<MMMaterialDepartmentsInfo> MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
            if (ProductItemLookupEdit == null)
                return;
            if (MaterialDepartList != null)
                ProductItemLookupEdit.Properties.DataSource = BOSApp.CurrentProductList.Where(o => MaterialDepartList.Any(dp => dp.FK_ICDepartmentID == o.FK_ICDepartmentID
                                                                    && (dp.ICProducType == string.Empty || (dp.ICProducType == o.ICProductType)))).ToList();
            else
                ProductItemLookupEdit.Properties.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Lumber.ToString()
                                                                                                   || o.ICProductType == ProductType.Roundwood.ToString())
                                                                                       .ToList();
        }

        public override void ActionEdit()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                InventoryStock.Visible = true;
                base.ActionEdit();
            }
        }

        public override void ActionNew()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.None.ToString();
            InventoryStock.Visible = true;
            base.ActionNew();
            if (WorkShopLookUpEditControl != null)
                WorkShopLookUpEditControl.Enabled = true;
            if (BatchProductLookupEditControl != null)
                BatchProductLookupEditControl.Enabled = true;
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            //return base.GetSearchData(ref searchQuery);
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = objShipmentsController.GetShipmentDryLumberModuleListBySomeCriteria(searchObject.ICShipmentNo,
                                                                    searchObject.FK_BRBranchID,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_ICStockID,
                                                                    searchObject.FK_HREmployeeID,
                                                                    //ShipmentType.DryLumber.ToString(),
                                                                    null,
                                                                    searchObject.ShipmentDateFrom,
                                                                    searchObject.ShipmentDateTo);

            return ds;
        }

        public void AddItemToShipmentItemsList()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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

            //UpdateDocumentEntries();
        }
        //delete item list
        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                ChangeItemFromShipmentItemsList();
            }
        }
        public void ChangeItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
                entity.SetProductPriceByProductUnitPrice();
                UpdateTotalAmount();
                entity.ShipmentItemList.ChangeObjectFromList();
            }

            // UpdateProductQty();
        }
        public override void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                //UpdateDocumentEntries();
            }
        }

        public void UpdateDocument()
        {
            //UpdateDocumentEntries();
        }

        public void ChangeItemlist(ICShipmentItemsInfo item)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ChangeValuesShipmentItemsGridFromProductSeries(item);
                BOSApp.RoundByCurrency(item, objShipmentsInfo.FK_GECurrencyID);
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                //if (objShipmentsInfo != null)
                //{
                //    item.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                //    item.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                //}
                UpdateTotalAmount();
            }

        }
        public void ChangeShipmentType(string type)
        {
            if (fld_dgcShipmentItemVMsGridControl != null)
                fld_dgcShipmentItemVMsGridControl.LoadGridViewByType(type);
        }
        public void UpdateProductQty()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
                entity.UpdateProductQty();
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            entity.MainObject = (ICShipmentsInfo)(new ICShipmentsController()).GetCusObjectByID(iObjectID);
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (fld_dgcShipmentItemVMsGridControl != null)
                fld_dgcShipmentItemVMsGridControl.LoadGridViewByType(objShipmentsInfo.ICShipmentTypeCombo);
            objShipmentsInfo.ICShipmentSOName = string.Join(", ", entity.ShipmentItemList.Where(o => !string.IsNullOrWhiteSpace(o.ICShipmentItemSOName)).Select(o => o.ICShipmentItemSOName).Distinct().ToArray());
            entity.UpdateMainObjectBindingSource();
        }
        public void NewAcceptance()
        {
            ActionNew();

            if (WorkShopLookUpEditControl != null)
                WorkShopLookUpEditControl.Enabled = false;
            if (BatchProductLookupEditControl != null)
                BatchProductLookupEditControl.Enabled = false;

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICProductsController objProductsController = new ICProductsController();
            List<ICReceiptItemsInfo> objreceiptItemCheck = new List<ICReceiptItemsInfo>();
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetReceiptItemByTypeLumber(ReceiptType.PurchaseReceipt.ToString(), ReceiptReceiptType.Lumber.ToString());
            guiFind<ICReceiptItemsInfo> guifind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName
                                                                                  , receiptItemList
                                                                                  , this
                                                                                  , true
                                                                                  , true
                                                                                  , new string[] { "ICReceiptNo" });
            guifind.ShowDialog();
            if (guifind.DialogResult == DialogResult.OK)
            {
                //ChangeAllocationProposalProductType(MMAllocationProposalType);
                List<ICReceiptItemsInfo> itemList = (List<ICReceiptItemsInfo>)guifind.SelectedObjects;

                if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                {
                    objreceiptItemCheck = (List<ICReceiptItemsInfo>)itemList.Where(x => x.FK_ICReceiptID != guifind.SelectedObjects[0].FK_ICReceiptID).ToList();
                }
                if (objreceiptItemCheck != null && objreceiptItemCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(BatchShipmentDryLumberLocalizedResources.ChooseMulltiReceiptMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    NewAcceptance();
                }
                else
                {

                    ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(guifind.SelectedObjects[0].FK_ICReceiptID);
                    if (objReceiptsInfo != null)
                    {
                        objShipmentsInfo.FK_ICProductID = objReceiptsInfo.FK_ICProductID;
                        objShipmentsInfo.FK_GECountryID = objReceiptsInfo.FK_GECountryID;
                        objShipmentsInfo.FK_ICProductAttributeWoodTypeID = objReceiptsInfo.FK_ICProductAttributeWoodTypeID;
                        objShipmentsInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
                        objShipmentsInfo.ICShipmentExchangeRate = objReceiptsInfo.ICReceiptExchangeRate;
                        objShipmentsInfo.FK_ICProductAttributeTTMTID = objReceiptsInfo.FK_ICProductAttributeTTMTID;
                        objShipmentsInfo.ICShipmentContainerNo = objReceiptsInfo.ICReceiptContainerNo;
                        objShipmentsInfo.ICShipmentReference = objReceiptsInfo.ICReceiptNo;
                        objShipmentsInfo.ICShipmentShipmentType = ShipmentShipmentType.DryLumber.ToString();
                        objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.Acceptance.ToString();
                        objShipmentsInfo.ICShipmentExchangeRate = 1;
                        entity.UpdateMainObjectBindingSource();
                    }
                    if (itemList != null)
                    {
                        foreach (ICReceiptItemsInfo item in itemList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            //if (objProductsInfo != null && item.FK_ACAccountID == 0)
                            //{
                            //    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            //}
                            objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15223);
                            if (objAccountsInfo != null)
                            {
                                objShipmentItemsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                            }
                            objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.ICReceiptItemProductSerialNo;
                            objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID;
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
                            //objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICReceiptItemProductUnitCost * objReceiptsInfo.ICReceiptExchangeRate;
                            //objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICReceiptItemTotalCost * objReceiptsInfo.ICReceiptExchangeRate;
                            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICInventoryStockUnitCost;
                            objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICInventoryStockUnitCost * item.ICReceiptItemProductQty;

                            objShipmentItemsInfo.FK_ICReceiptItemID = item.Id;
                            objShipmentItemsInfo.ICShipmentItemLength = item.ICReceiptItemProductLength;
                            objShipmentItemsInfo.ICShipmentItemLengthMax = item.ICReceiptItemLenghtMax;
                            objShipmentItemsInfo.ICShipmentItemLengthMin = item.ICReceiptItemLenghtMin;
                            objShipmentItemsInfo.ICShipmentItemHeight = item.ICReceiptItemProductHeight;
                            objShipmentItemsInfo.ICShipmentItemWidth = item.ICReceiptItemProductWidth;
                            objShipmentItemsInfo.ICShipmentItemWidthMin = item.ICReceiptItemWidthMin;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(item.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);

                            entity.ShipmentItemList.Add(objShipmentItemsInfo);

                        }
                        entity.ShipmentItemList.GridControl.RefreshDataSource();
                    }
                    UpdateTotalAmount();
                }
            }
            else
                ActionCancel();
        }

        public void ChangeObject(string objectAccessKey)
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            objShipmentsInfo.ACObjectAccessKey = objectAccessKey;
            objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == objObjectsInfo.ACObjectID && o.ACObjectType == objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objShipmentsInfo.ICShipmentDeliveryContactName = objObjectsInfo.ACObjectName;
                objShipmentsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objShipmentsInfo.ICObjectType = objObjectsInfo.ACObjectType;
                objShipmentsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objShipmentsInfo.ICShipmentID > 0)
            {
                if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentDryLumber", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);                    
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentDryLumber", true);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            }

            if (objShipmentsInfo.STToolbarActionName == "Manual")
            {
                if (WorkShopLookUpEditControl != null)
                    WorkShopLookUpEditControl.Enabled = true;
                if (BatchProductLookupEditControl != null)
                    BatchProductLookupEditControl.Enabled = true;
            }
        }

        public void ApproveBatchShipmentDryLumber()
        {
            if (!Toolbar.IsNullOrNoneAction())
                return;

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            entity.ShipmentItemList.EndCurrentEdit();
            UpdateTotalAmount();

            if (objShipmentsInfo.STToolbarActionName != "Manual" && !CheckOperationReceive(entity.ShipmentItemList)) return;
            if (!CheckReceiptCompleted()) return;

            ICProductsInfo objProductsInfo = new ICProductsInfo();
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
                        return;
                    }
                }
            }
            entity.ShipmentItemList.BackupList.Clear();
            if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
            {
                return;
            }
            //if (entity.ShipmentItemList.IsInvalidWoodQty())
            //{
            //    return;
            //}
            if (InvalidProductUnitCost())
            {
                return;
            }
            ActionComplete();
        }

        public bool InvalidProductUnitCost()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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
                if (Math.Abs(item.ICShipmentItemExchangeUnitCost - objValidate.ICTransactionUnitCost) > 1 && item.ICShipmentItemExchangeUnitCost != 0)
                {
                    messageError = string.Format("Sản phẩm [{0}]- {1} - Lô [{2}] có giá vốn {3} khác với giá vốn nhập kho {4}.", objValidate.ICProductNo, objValidate.ICProductName, item.ICShipmentItemProductSerialNo, item.ICShipmentItemExchangeUnitCost, objValidate.ICTransactionUnitCost);
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
                messageError += "Bạn có muốn tiếp tục duyệt chứng từ không?";
                DialogResult rs = MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return rs != DialogResult.Yes;
            }
            messageError += "Vui lòng liên hệ quản trị viên phần mềm!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        public override int ActionSave()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            entity.TotalShipmentItemsList.EndCurrentEdit();
            entity.ShipmentItemList.EndCurrentEdit();
            UpdateTotalAmount();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int countOperation = entity.ShipmentItemList.Where(o => o.FK_MMOperationID == 0).Count();
            int countBatch = entity.ShipmentItemList.Where(o => o.FK_MMBatchProductID == 0).Count();
            if (countOperation > 0 || countBatch > 0)
            {
                if (BOSApp.ShowMessageYesNo("Công đoạn cấp phát hoặc Lệnh sản xuất đang để trống, bạn có chắc không?") == DialogResult.No)
                    return 0;
            }

            //if (objShipmentsInfo.FK_MMBatchProductID > 0)
            //{
            //    ICReceiptsController objReceiptsController = new ICReceiptsController();
            //    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            //    MMOperationsController objOperationsController = new MMOperationsController();
            //    MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            //    DateTime dtResult = new DateTime(objShipmentsInfo.ICShipmentDate.Year, objShipmentsInfo.ICShipmentDate.Month, 1);
            //    dtResult = dtResult.AddDays(-1);
            //    if (objOperationsInfo != null)
            //    {
            //        if (objOperationsInfo.MMOperationType == OperationReceiptType.ChiTiet.ToString()
            //            || objOperationsInfo.MMOperationType == OperationReceiptType.ChiTietTuPhach.ToString())
            //        {
            //            decimal ReceiptQty = objReceiptsController.GetQtySemiproductByBatchProductIDAndOperationID(objShipmentsInfo.FK_MMBatchProductID, objOperationsInfo.MMOperationID, dtResult.Date);
            //            decimal batchProductQty = objBatchProductProductionNormItemsController.GetQuantitySemiProductDetailTypeByBatch(objShipmentsInfo.FK_MMBatchProductID, objShipmentsInfo.FK_ICProductID);
            //            if (ReceiptQty >= batchProductQty)
            //            {
            //                BOSApp.ShowMessage("LSX đã đủ vui lòng chọn LSX khác!");
            //                return 0;
            //            }
            //        }
            //        else if (objOperationsInfo.MMOperationType == OperationReceiptType.RapChiTiet.ToString() ||
            //            objOperationsInfo.MMOperationType == OperationReceiptType.Cum.ToString())
            //        {
            //            decimal ReceiptQty = objReceiptsController.GetQtySemiproductByBatchProductIDAndOperationID(objShipmentsInfo.FK_MMBatchProductID, objOperationsInfo.MMOperationID, dtResult.Date);
            //            decimal batchProductQty = objBatchProductProductionNormItemsController.GetQuantitySemiProductComponentTypeByBatch(objShipmentsInfo.FK_MMBatchProductID, objShipmentsInfo.FK_ICProductID);
            //            if (ReceiptQty >= batchProductQty)
            //            {
            //                BOSApp.ShowMessage("LSX đã đủ vui lòng chọn LSX khác!");
            //                return 0;
            //            }
            //        }
            //        else if (objOperationsInfo.MMOperationType == OperationReceiptType.RapTPTuChiTiet.ToString() ||
            //            objOperationsInfo.MMOperationType == OperationReceiptType.RapCum.ToString() ||
            //            objOperationsInfo.MMOperationType == OperationReceiptType.ThanhPham.ToString())
            //        {
            //            decimal ReceiptQty = objReceiptsController.GetQtySemiproductByBatchProductIDAndOperationID(objShipmentsInfo.FK_MMBatchProductID, objOperationsInfo.MMOperationID, dtResult.Date);
            //            decimal batchProductQty = objBatchProductProductionNormItemsController.GetQuantityProductGroupTypeByBatch(objShipmentsInfo.FK_MMBatchProductID, objShipmentsInfo.FK_ICProductID);
            //            if (ReceiptQty >= batchProductQty)
            //            {
            //                BOSApp.ShowMessage("LSX đã đủ vui lòng chọn LSX khác!");
            //                return 0;
            //            }
            //        }
            //    }
            //}
            if (!IsValidShipmentQtyForList())
            {
                return 0;
            }
            return base.ActionSave();
        }
        public bool CheckReceiptCompleted()
        {
            bool result = true;
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsController objController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> listComplete = objController.GetCompleteSemiReceipt(objShipmentsInfo.ICShipmentID);
            string mess = string.Empty;
            if (listComplete.Count() > 0)
            {
                mess = string.Join(Environment.NewLine, listComplete.Select(s => "Ngày nhập gần nhất: " + s.ICProductSerieReceiptDate + " SP: " + s.ICProductName + " Tổng DM: " + s.MMBatchProductItemProductQty + " Tổng đã nhập: " + s.ReceiptQty).ToArray().Distinct());
            }
            if (!string.IsNullOrEmpty(mess))
            {
                if (BOSApp.ShowMessageYesNo("Chi tiết BTP tương ứng công đoạn này đã nhập đủ." + Environment.NewLine + mess + "Vui lòng điều chỉnh [ngày xuất kho], hoặc [ngày nhập kho] BTP phù hợp. " + Environment.NewLine
                    + "Nhấn [Yes] nếu bạn muốn điều chỉnh ngày xuất kho. Nhấn [No] hệ thống sẽ bỏ qua thông báo này."
                    ) == DialogResult.Yes)
                {
                    result = false;
                }
            }
            return result;
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
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            List<ICShipmentItemsInfo> checkShipmentList = entity.ShipmentItemList.Where(o => o.FK_MMAllocationPlanItemID > 0).ToList();
            if (checkShipmentList.Count() == 0)
                return true;

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

                if (config.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Percent.ToString())
                    tolenrancePlus = remainPlanQty * config.ICProductTolenrancePlus / 100;
                else if (config.ICProductTolenranceCalculateType == ProductTolenranceCalculateType.Quantity.ToString())
                    tolenrancePlus = config.ICProductTolenrancePlus;

                if (remainPlanQty + tolenrancePlus - sumShipmentQty < 0)
                {
                    messageError += string.Format("Sản phẩm: [{0}], lô SX: {2} có số lượng lớn hơn số lượng đề nghị. Số lượng có thể cấp phát là: {1}",
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

        public bool CheckOperationReceive(BOSItemsEntityList<ICShipmentItemsInfo> ListObject)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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
                MessageBox.Show(mess
                        , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }
        public bool CheckItemOperationReceive(ICShipmentItemsInfo item)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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
                MessageBox.Show(mess
                        , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }
        public List<ICProductsForViewInfo> GetBatchProductItemSerialDataSource()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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

        public void ShownInventoryStocks()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                //List<ICInventoryStocksInfo> InventoryStocksList = new List<ICInventoryStocksInfo>();
                guiShowInventoryStock guiShowInventoryStock = new guiShowInventoryStock(objShipmentsInfo.ICShipmentShipmentType);
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

        public void GetSelectedSeriesList(List<ICProductSeriesInfo> SeriesList)
        {
            string type = string.Empty;
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ACAccountsInfo objACAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(SeriesList[0].FK_ICProductID);
            foreach (ICProductSeriesInfo item in SeriesList)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                DataGenerator.SetShipmentItemsfromProductSeries(objShipmentItemsInfo, item);
                //if (objProductsInfo != null)
                //{
                //    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                //}
                objACAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15223);
                if (objACAccountsInfo != null)
                {
                    objShipmentItemsInfo.FK_ACAccountID = objACAccountsInfo.ACAccountID;
                }
                objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objShipmentsInfo.FK_ICProductAttributeWoodTypeID;
                objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                objShipmentItemsInfo.FK_GECountryID = objShipmentsInfo.FK_GECountryID;
                //TNDLoc [ADD][21/01/2016][Copy ProductSerieID],START
                objShipmentItemsInfo.FK_ICProductSerieID = item.ICProductSerieID;
                //TNDLoc [ADD][21/01/2016][Copy ProductSerieID],END
                entity.ShipmentItemList.Add(objShipmentItemsInfo);

            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();

        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            entity.DocumentEntryList.Clear();
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();

            string documentType = AccDocumentType.XuatKhoPhachKhoCongDoanPhoi.ToString();
            string entryType = AccEntryType.XuatKhoPhachKhoCongDoanPhoi.ToString();

            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>>();
            //List<int> productAccountID = new List<int>();
            List<ICImportAndExportReasonsInfo> importAndExportReasonList = new List<ICImportAndExportReasonsInfo>();
            List<ICStocksInfo> stockList = new List<ICStocksInfo>();
            if (entity.ShipmentItemList != null)
            {
                foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
                {
                    ICImportAndExportReasonsController objICImportAndExportReasonsController = new ICImportAndExportReasonsController();
                    int debitAccountID = 0;
                    ICImportAndExportReasonsInfo objICImportAndExportReasonsInfo = importAndExportReasonList.FirstOrDefault(o => o.ICImportAndExportReasonID == shipmentItem.FK_ICImportAndExportReasonID);
                    if (objICImportAndExportReasonsInfo != null && objICImportAndExportReasonsInfo.FK_ACAcountID > 0)
                        debitAccountID = objICImportAndExportReasonsInfo.FK_ACAcountID;
                    else
                    {
                        objICImportAndExportReasonsInfo = (ICImportAndExportReasonsInfo)objICImportAndExportReasonsController.GetObjectByID(shipmentItem.FK_ICImportAndExportReasonID);
                        if (objICImportAndExportReasonsInfo != null && objICImportAndExportReasonsInfo.FK_ACAcountID > 0)
                        {
                            debitAccountID = objICImportAndExportReasonsInfo.FK_ACAcountID;
                            importAndExportReasonList.Add(objICImportAndExportReasonsInfo);
                        }
                    }
                    ICStocksController objICStocksController = new ICStocksController();
                    int creditAccountID = 0;
                    ICStocksInfo objICStocksInfo = stockList.FirstOrDefault(o => o.ICStockID == shipmentItem.FK_ICStockID);
                    if (objICStocksInfo != null && objICStocksInfo.FK_ACAccountID > 0)
                        creditAccountID = objICStocksInfo.FK_ACAccountID;
                    else
                    {
                        objICStocksInfo = (ICStocksInfo)objICStocksController.GetObjectByID(shipmentItem.FK_ICStockID);
                        if (objICStocksInfo != null && objICStocksInfo.FK_ACAccountID > 0)
                        {
                            creditAccountID = objICStocksInfo.FK_ACAccountID;
                            stockList.Add(objICStocksInfo);
                        }
                        if (creditAccountID == 0)
                        {
                            ICProductsController objICProductsController = new ICProductsController();
                            ICProductsInfo objICProductsInfo = (ICProductsInfo)objICProductsController.GetObjectByID(shipmentItem.FK_ICProductID);
                            if (objICProductsInfo != null && objICProductsInfo.FK_ACAccountID > 0)
                                creditAccountID = objICProductsInfo.FK_ACAccountID;
                        }
                    }
                    //ICProductsInfo product = productController.GetObjectByID(shipmentItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACCreditAccountID == creditAccountID);
                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                        if (debitAccountID > 0)
                            entry.FK_ACDebitAccountID = debitAccountID;
                        entry.FK_ACCreditAccountID = creditAccountID;
                    }
                    if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                    {
                        documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                        //productAccountID.Add(entry.FK_ACCreditAccountID);
                    }
                    documentEntryAccounts[entry].Add(shipmentItem);
                }
            }

            //update document entry amount
            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICShipmentItemProductUnitPrice * i.ICShipmentItemProductQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objShipmentsInfo.FK_GECurrencyID);
                    item = entry;
                }


                ACDocumentsInfo objDocumentsInfo = entity.DocumentList.FirstOrDefault(d => d.ACDocumentTypeName == documentType);
                if (objDocumentsInfo == null)
                {
                    objDocumentsInfo = new ACDocumentsInfo();
                    objDocumentsInfo.FK_ACDocumentTypeID = item.FK_ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = item.ACDocumentTypeName;
                    entity.DocumentList.Add(objDocumentsInfo);
                }
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public void GetDefaultProductAccount(ICProductsInfo objProductsInfo)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(DefaultAccountNo);
            if (objAccountsInfo != null)
            {
                objProductsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
            }
        }
        public const string DefaultAccountNo = "155";
        #endregion
        public void ChangeStock(int stockID)
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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

        public void GeneralAccountInShipmentItemByStock(ICShipmentItemsInfo item)
        {
            if (item.FK_ICStockID > 0)
            {
                item.FK_ACAccountID = GetAccountByStock(item.FK_ICStockID, item.FK_ACAccountID);
            }
        }


        public void ChangeBatchProduct(int Batchproduct)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMBatchProductID = Batchproduct;
            //UpdateDocumentEntries();
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchShipmentDryLumber.BatchShipmentDryLumberModule.PrintShipment(Toolbar.CurrentObjectID);
            }
        }

        public static void PrintShipment(int ShipmentID)
        {
            RP_ShipmentLumber report = new RP_ShipmentLumber();
            //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
            InitReceiptReport(report, ShipmentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        public void PrintBatchShipmentDryLumber()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RP_ShipmentDryLumber report = new RP_ShipmentDryLumber();
                InitShipmentDryLumberReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        private void InitShipmentDryLumberReport(XtraReport report, int ShipmentID)
        {
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
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
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

            XRLabel accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel28"];
            if (accLabel != null)
            {
                accLabel.Text = "Ngày: " + shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel29"];
            if (accLabel != null)
            {
                accLabel.Text = shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }

            ADReportsController objReportsController = new ADReportsController();
            decimal Tongsoluong = 0;

            List<ICShipmentItemsInfo> shipmentDryLumberList = objReportsController.GetListShipmentDryLumberItemByShipmentID(ShipmentID);
            //foreach (ICShipmentItemsInfo item in shipmentDryLumberList)
            //{
            //    if (item != null)
            //    {
            //        item.ICShipmentItemWoodQty = Math.Round(item.ICShipmentItemWoodQty, 0);
            //        Tongsoluong += item.ICShipmentItemWoodQty;
            //    }
            //}
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel17"];
            if (accLabel != null)
            {
                accLabel.Text = Tongsoluong.ToString();
            }
            report.DataSource = shipmentDryLumberList;
        }

        private static void InitReceiptReport(XtraReport report, int ShipmentID)
        {
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
            ICShipmentsInfo shipment = (ICShipmentsInfo)objShipmentsController.GetObjectByID(ShipmentID);
            #region Hạch toán
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (shipment != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentsInfo document = null;
                if (shipment.ICShipmentTypeCombo == ShipmentType.DryLumber.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKhoPhachKhoCongDoanPhoi.ToString(), shipment.ICShipmentNo);
                }
                //else if (receipt.ICReceiptTypeCombo == ShipmentType..ToString())
                //{
                //    if (!string.IsNullOrEmpty(receipt.ICReceiptReference))
                //    {
                //        document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapKhoMuaHangHoaDon.ToString(), receipt.ICReceiptNo);
                //    }
                //    else
                //    {
                //        document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapKhoMuaHang.ToString(), receipt.ICReceiptNo);
                //    }
                //}
                //else if (receipt.ICReceiptTypeCombo == ReceiptType.EquipmentReceipt.ToString())
                //{
                //    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapCCDC.ToString(), receipt.ICReceiptNo);
                //}
                if (document != null)
                {
                    entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);
                }
            }
            XRLabel accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDebitAccountNo"];
            if (accLabel != null)
            {
                string debitAccountNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.ACDocumentDebitAccount != null)
                    {
                        if (!debitAccountNo.Contains(entry.ACDocumentDebitAccount))
                        {
                            debitAccountNo += string.Format(" {0},", entry.ACDocumentDebitAccount);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(debitAccountNo))
                {
                    debitAccountNo = debitAccountNo.Substring(0, debitAccountNo.Length - 1);
                }
                accLabel.Text = debitAccountNo;
            }

            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCreditAccountNo"];
            if (accLabel != null)
            {
                string creditAccountNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.ACDocumentCreditAccount != null)
                    {
                        if (!creditAccountNo.Contains(entry.ACDocumentCreditAccount))
                        {
                            creditAccountNo += string.Format(" {0},", entry.ACDocumentCreditAccount);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(creditAccountNo))
                {
                    creditAccountNo = creditAccountNo.Substring(0, creditAccountNo.Length - 1);
                }
                accLabel.Text = creditAccountNo;
            }
            #endregion

            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel28"];
            if (accLabel != null)
            {
                accLabel.Text = shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel29"];
            if (accLabel != null)
            {
                accLabel.Text = shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }

            //GECurrenciesController objCurrenciesController = new GECurrenciesController();
            //GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(receipt.FK_GECurrencyID);
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel27"];
            //if (accLabel != null)
            //{
            //    accLabel.Text = ConvertAmountToWord.ReadAmount(receipt.ICReceiptTotalCost.ToString(), currency.GECurrencyID);
            //}



            ADReportsController objReportsController = new ADReportsController();
            decimal Tongsoluong = 0;
            foreach (ICShipmentItemsInfo item in objReportsController.GetListShipmentItemByShipmentID(ShipmentID))
            {
                if (item != null)
                {
                    item.ICShipmentItemWoodQty = Math.Round(item.ICShipmentItemWoodQty, 0);
                    Tongsoluong += item.ICShipmentItemWoodQty;
                }
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel17"];
            if (accLabel != null)
            {
                accLabel.Text = Tongsoluong.ToString();
            }
            List<ICShipmentItemsInfo> shipmentItemList = objReportsController.GetListShipmentItemByShipmentID(ShipmentID);
            decimal totalShipmentItemQty = 0;
            shipmentItemList.ForEach(p =>
            {
                p.ICShipmentItemProductQtyText = p.ICShipmentItemProductQty.ToString();
                p.ICShipmentItemWoodQtyText = p.ICShipmentItemWoodQty.ToString();
                totalShipmentItemQty += Math.Round(p.ICShipmentItemProductQty, RoundingNumber.FormatN5, MidpointRounding.AwayFromZero);
            });
            report.DataSource = shipmentItemList;
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblTotalProductQty"];
            if (accLabel != null)
            {
                accLabel.Text = totalShipmentItemQty.ToString();
            }
        }

        public void SetDepartmentRoom(int departmentRoomID)
        {

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                item.FK_HRDepartmentRoomID = departmentRoomID;
            }

            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void ChangeImportAndExportReason(int importAndExportReasonID)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_ICImportAndExportReasonID = importAndExportReasonID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ShipmentItemList.Count > 0)
                {
                    entity.ShipmentItemList.ForEach(o => o.FK_ICImportAndExportReasonID = importAndExportReasonID);
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
            UpdateTotalAmount();
        }

        public void SetCreditAccountID(int stockID)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
            if (objStocksInfo != null)
            {
                if ((objStocksInfo.FK_ACAccountID != null) && (objStocksInfo.FK_ACAccountID != 0))
                {
                    foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                    {
                        entry.FK_ACCreditAccountID = objStocksInfo.FK_ACAccountID;
                    }
                }
                else
                {
                    ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList.FirstOrDefault();
                    if (objShipmentItemsInfo != null)
                    {
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                        if (objProductsInfo.FK_ACAccountID != null)
                        {
                            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                            {
                                entry.FK_ACCreditAccountID = objProductsInfo.FK_ACAccountID;
                            }
                        }
                    }
                }
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public void SetDebitAccountID(int importAndExportReasonID)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
            int fK_ACDebitAccountID = ((ICImportAndExportReasonsInfo)objImportAndExportReasonsController.GetObjectByID(objShipmentsInfo.FK_ICImportAndExportReasonID)).FK_ACAcountID;
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                entry.FK_ACDebitAccountID = fK_ACDebitAccountID;
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public static void ChangeValuesShipmentItemsGridFromProductSeries(ICShipmentItemsInfo item)
        {
            if (item != null)
            {
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICShipmentItemProductSerialNo);
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                ICProductsController objProductsController = new ICProductsController();
                ICShipmentItemsInfo objShipmentItemsInfoOld = (ICShipmentItemsInfo)item.Clone();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductSeriesInfo != null)
                {
                    int stockID = item.FK_ICStockID;
                    string desc = item.ICShipmentItemProductDesc;
                    BOSUtil.CopyObject(objProductSeriesInfo, item);
                    item.FK_MMOperationID = objShipmentItemsInfoOld.FK_MMOperationID;
                    item.FK_MMBatchProductID = objShipmentItemsInfoOld.FK_MMBatchProductID;
                    item.ICShipmentItemHeight = objShipmentItemsInfoOld.ICShipmentItemHeight;
                    item.ICShipmentItemWidth = objShipmentItemsInfoOld.ICShipmentItemWidth;
                    item.ICShipmentItemHeight = objShipmentItemsInfoOld.ICShipmentItemHeight;
                    item.FK_ICStockID = stockID;
                    item.ICShipmentItemProductDesc = desc;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //item.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    //item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ICShipmentItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    //item.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;

                    item.ICShipmentItemWidthMax = objProductSeriesInfo.ICProductSerieProductWidthMax;
                    item.ICShipmentItemLengthMax = objProductSeriesInfo.ICProductSerieProductLengthMax;
                    item.ICShipmentItemPerimeterMax = objProductSeriesInfo.ICProductSerieProductPerimeterMax;

                    item.ICShipmentItemHeightMin = 0;
                    item.ICShipmentItemWidthMin = objProductSeriesInfo.ICProductSerieProductWidth;
                    item.ICShipmentItemLengthMin = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ICShipmentItemPerimeterMin = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    item.ICShipmentItemHeightMax = 0;

                    item.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    item.FK_ICProductAttributeTTMTID = objProductSeriesInfo.FK_ICProductAttributeTTMTID;
                    item.FK_ICProductAttributeQualityID = objProductSeriesInfo.FK_ICProductAttributeQualityID;
                    item.FK_GECountryID = objProductSeriesInfo.FK_GECountryID;
                    item.ICShipmentItemContainerNo = objProductSeriesInfo.ICProductSerieContainerNo;
                }
            }
        }

        public void PrintBatchShipmentDryLumberTV()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            object[] arParam = new object[1];
            arParam[0] = objShipmentsInfo.ICShipmentID;
            ViewReportByTemplate("RPShipmentTV", "GetDataSourceForRPShipmentTV", arParam);
        }

        public void NewFromAllocationPlanMaterial()
        {
            ActionNew();

            if (WorkShopLookUpEditControl != null)
                WorkShopLookUpEditControl.Enabled = false;
            if (BatchProductLookupEditControl != null)
                BatchProductLookupEditControl.Enabled = false;

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            guiAllocationPlanItems guiFind = new guiAllocationPlanItems();
            guiFind.Module = this;
            guiFind.AllocationPlanItemGroup = AllocationPlanItemGroup.Material.ToString();
            guiFind.MMAllocationPlanID = mainobject.FK_MMAllocationPlanID;
            guiFind.MMBatchProductID = mainobject.FK_MMBatchProductID;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
            {
                ActionCancel();
                return;
            }

            List<MMAllocationPlanItemsInfo> selectedList = guiFind.SelectedObjects;
            if (selectedList.Count() == 0)
            {
                ActionCancel();
                return;
            }

            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = guiFind.SelectedObjects.FirstOrDefault();
            //mainobject.FK_MMBatchProductID = objAllocationPlanItemsInfo.FK_MMBatchProductID;
            mainobject.ICShipmentShipmentType = AllocationPlanItemGroup.Material.ToString();
            //mainobject.FK_MMAllocationPlanID = objAllocationPlanItemsInfo.FK_MMAllocationPlanID;
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
            objShipmentItemsInfo.FK_ICStockID = item.FK_ICStockID;
            objShipmentItemsInfo.FK_MMOperationID = item.FK_MMOperationID == 0 ? mainobject.FK_MMOperationID : item.FK_MMOperationID;
            objShipmentItemsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
            objShipmentItemsInfo.FK_HREmployeeReceverID = item.FK_HREmployeeIDReceive;
            objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID;
            objShipmentItemsInfo.ICShipmentItemProductName = item.MMAllocationPlanItemProductName;
            objShipmentItemsInfo.ICShipmentItemProductDesc = item.MMAllocationPlanItemProductDesc;
            objShipmentItemsInfo.ICShipmentItemProductQty = item.MMAllocationPlanItemQty;
            objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationPlanItemWoodQty;
            objShipmentItemsInfo.ICShipmentItemLength = item.MMAllocationPlanItemLength;
            objShipmentItemsInfo.ICShipmentItemWidth = item.MMAllocationPlanItemWidth;
            objShipmentItemsInfo.ICShipmentItemHeight = item.MMAllocationPlanItemHeight;
            objShipmentItemsInfo.ICShipmentItemComment = item.MMAllocationPlanItemComment;
            objShipmentItemsInfo.ICShipmentItemProductExchangeQty = item.MMAllocationPlanItemQty * item.ICProductMeasureUnitFactor;
            objShipmentItemsInfo.ICShipmentItemProductFactor = item.ICProductMeasureUnitFactor;
            objShipmentItemsInfo.ICShipmentItemExchangeUnitCost = item.MMAllocationPlanItemUnitCost;
            objShipmentItemsInfo.ICShipmentItemExchangeTotalCost = item.MMAllocationPlanItemUnitCost * item.MMAllocationPlanItemQty;
            objShipmentItemsInfo.ICShipmentItemProductUnitCost = item.MMAllocationPlanItemUnitCost;
            objShipmentItemsInfo.ICShipmentItemTotalCost = item.MMAllocationPlanItemUnitCost * item.MMAllocationPlanItemQty; ;
            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
            objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.MMAllocationPlanItemBatchProductItemProductSerial;
            objShipmentItemsInfo.ICShipmentItemQty6 = item.MMAllocationPlanItemNormQty;
            objShipmentItemsInfo.ICShipmentItemComment = item.MMAllocationPlanItemComment;
            objShipmentItemsInfo.ICShipmentItemProductName2 = item.ICProductName2;
            objShipmentItemsInfo.MMBatchProductProductionNormItemProductLength = item.MMBatchProductProductionNormItemProductLength;
            objShipmentItemsInfo.MMBatchProductProductionNormItemProductHeight = item.MMBatchProductProductionNormItemProductHeight;
            objShipmentItemsInfo.MMBatchProductProductionNormItemProductWidth = item.MMBatchProductProductionNormItemProductWidth;
            objShipmentItemsInfo.VirtualID = Guid.NewGuid();
            objShipmentItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
            objShipmentItemsInfo.ICShipmentItemSOName = item.MMAllocationPlanItemSOName;
            objShipmentItemsInfo.FK_ICImportAndExportReasonID = mainobject.FK_ICImportAndExportReasonID;
            return objShipmentItemsInfo;
        }

        public void ChangeItemVM(ICShipmentItemVMsInfo item)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            List<ICShipmentItemsInfo> shipmentItemList = entity.ShipmentItemList.Where(o => itemRef.Contains(o.VirtualID)).ToList();
            SynsItemData(item, shipmentItemList);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            //UpdateDocumentEntries();
        }

        public void DeleteItemVM()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentItemVMsInfo item = entity.TotalShipmentItemsList[entity.TotalShipmentItemsList.CurrentIndex];
            ICShipmentItemVMsInfo itemVMClone = (ICShipmentItemVMsInfo)item.Clone();
            itemVMClone.ICShipmentItemProductQty = 0;
            itemVMClone.ICShipmentItemProductExchangeQty = 0;
            if (string.IsNullOrWhiteSpace(item.ICShipmentItemRef))
                return;

            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICShipmentItemsInfo itemClone = new ICShipmentItemsInfo();
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(p => p.STModuleName == this.Name);
            ICProductsForViewInfo product;
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
                product = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == itemClone.FK_ICProductID);
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
            if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
            {
                CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
            }
            product = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == itemVMClone.FK_ICProductID);
            if (product.ICProductType == ProductType.Lumber.ToString()
                && objCalculatedPackageVolumnConfigsInfo != null
                && objCalculatedPackageVolumnConfigsInfo.IsActive
                && itemVMClone.ICShipmentItemLength * itemVMClone.ICShipmentItemHeight * itemVMClone.ICShipmentItemWidth * itemVMClone.ICShipmentItemWoodQty != 0M)
            {
                itemVMClone.ICShipmentItemProductQty = itemVMClone.ICShipmentItemLength * itemVMClone.ICShipmentItemHeight * itemVMClone.ICShipmentItemWidth * itemVMClone.ICShipmentItemWoodQty / 1000000000;
                itemVMClone.ICShipmentItemProductExchangeQty = itemVMClone.ICShipmentItemProductQty * itemVMClone.ICShipmentItemProductFactor;
                itemVMClone.ICShipmentItemProductQty = Math.Round(itemVMClone.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                itemVMClone.ICShipmentItemProductExchangeQty = Math.Round(itemVMClone.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            }
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

        private List<MMAllocationPlanItemsInfo> GetRemainQtyForShipment(int productID, string planItemRef, string shipmentItemRefID, out decimal remainPlanQty, out decimal tolenrancePlus, bool hasTolenrance = true)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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

        public void SynItemQty(ICShipmentItemVMsInfo item, IList<ICShipmentItemsInfo> shipmentItemList, List<ICMeasureUnitsInfo> measureUnitList, List<MMAllocationPlanItemsInfo> listRemainQty, decimal totalAllocationQty, decimal totalAllocationWoodQty, decimal totalPlus = 0)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;

            decimal remainPlanQty = 0;
            decimal sameItemQty = 0;
            decimal rateWithTotalQty = 0;
            decimal totalNormQty = listRemainQty.Sum(o => o.MMAllocationPlanItemRemainQty);

            int roundNum = 0;
            decimal allocationQty = 0;
            decimal allocationWoodQty = 0;
            decimal tolenrancePlus = 0;

            shipmentItemList.ForEach(o =>
            {
                if (o.FK_MMAllocationPlanItemID == 0)
                {
                    o.ICShipmentItemProductQty = totalAllocationQty;
                    o.ICShipmentItemWoodQty = totalAllocationWoodQty;
                    entity.SetProductPriceByProductUnitPrice(o);
                    allocationQty = o.ICShipmentItemProductQty;
                    allocationWoodQty = o.ICShipmentItemWoodQty;
                    return;
                }
                remainPlanQty = listRemainQty.Where(p => p.Id == o.FK_MMAllocationPlanItemID).Select(p => p.MMAllocationPlanItemRemainQty).FirstOrDefault();
                sameItemQty = entity.ShipmentItemList.Where(si => !shipmentItemList.Contains(si) && si.FK_MMAllocationPlanItemID == o.FK_MMAllocationPlanItemID && o.VirtualID != si.VirtualID).Sum(si => si.ICShipmentItemProductExchangeQty);
                sameItemQty = o.ICShipmentItemProductFactor == 0 ? sameItemQty : sameItemQty / o.ICShipmentItemProductFactor;
                rateWithTotalQty = totalNormQty == 0 ? 0 : (remainPlanQty - sameItemQty) / totalNormQty;
                o.ICShipmentItemProductQty = (rateWithTotalQty * totalAllocationQty);
                o.ICShipmentItemWoodQty = rateWithTotalQty * totalAllocationWoodQty;
                o.ICShipmentItemWoodQty = o.ICShipmentItemWoodQty < 0 ? 0 : o.ICShipmentItemWoodQty;
                o.ICShipmentItemWoodQty = Math.Round(o.ICShipmentItemWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                //roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == o.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault();
                //o.ICShipmentItemProductQty = Math.Round(o.ICShipmentItemProductQty, roundNum, MidpointRounding.AwayFromZero);
                o.ICShipmentItemProductQty = o.ICShipmentItemProductQty < 0 ? 0 : o.ICShipmentItemProductQty;
                o.ICShipmentItemProductQty = Math.Round(o.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                o.ICShipmentItemProductExchangeQty = o.ICShipmentItemProductQty * o.ICShipmentItemProductFactor;
                allocationQty += o.ICShipmentItemProductQty;
                allocationWoodQty += o.ICShipmentItemWoodQty;
            });

            allocationQty = Math.Round(allocationQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            allocationWoodQty = Math.Round(allocationWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            if (allocationQty == totalAllocationQty && allocationWoodQty == totalAllocationWoodQty)
            {
                item.ICShipmentItemProductQty = shipmentItemList.Sum(o => o.ICShipmentItemProductQty);
                item.ICShipmentItemWoodQty = shipmentItemList.Sum(o => o.ICShipmentItemWoodQty);
                item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                return;
            }
            decimal calOperation = totalAllocationQty - allocationQty >= 0 ? 1 : -1;
            decimal calWoodOperation = totalAllocationWoodQty - allocationWoodQty >= 0 ? 1 : -1;
            totalAllocationQty = Math.Abs(totalAllocationQty - allocationQty);
            totalAllocationWoodQty = Math.Abs(totalAllocationWoodQty - allocationWoodQty);
            allocationQty = 0;
            allocationWoodQty = 0;
            decimal oldQty = 0;
            decimal oldWoodQty = 0;
            shipmentItemList.ForEach(o =>
            {
                if (totalAllocationQty == 0 && totalAllocationWoodQty == 0)
                    return;

                if (totalAllocationQty > 0)
                {
                    remainPlanQty = listRemainQty.Where(p => p.Id == o.FK_MMAllocationPlanItemID).Select(p => p.MMAllocationPlanItemRemainQty).FirstOrDefault();
                    sameItemQty = entity.ShipmentItemList.Where(si => si.FK_MMAllocationPlanItemID == o.FK_MMAllocationPlanItemID && o.VirtualID != si.VirtualID).Sum(si => si.ICShipmentItemProductExchangeQty);
                    sameItemQty = o.ICShipmentItemProductFactor == 0 ? sameItemQty : sameItemQty / o.ICShipmentItemProductFactor;
                    rateWithTotalQty = totalNormQty == 0 ? 0 : (remainPlanQty - sameItemQty) / totalNormQty;
                    tolenrancePlus = rateWithTotalQty * totalPlus;
                    oldQty = o.ICShipmentItemProductQty;
                    roundNum = measureUnitList.Where(u => u.ICMeasureUnitID == o.FK_ICMeasureUnitID).Select(u => u.ICMeasureUnitRoundNum).FirstOrDefault();
                    o.ICShipmentItemProductQty = o.ICShipmentItemProductQty + calOperation * totalAllocationQty;
                    o.ICShipmentItemProductQty = o.ICShipmentItemProductQty * o.ICShipmentItemProductFactor > (remainPlanQty - sameItemQty + tolenrancePlus)
                                                    ? (remainPlanQty - sameItemQty + tolenrancePlus)/ o.ICShipmentItemProductFactor : o.ICShipmentItemProductQty;
                    o.ICShipmentItemProductQty = o.ICShipmentItemProductQty < 0 ? 0 : o.ICShipmentItemProductQty;
                    o.ICShipmentItemProductQty = Math.Round(o.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    o.ICShipmentItemProductExchangeQty = o.ICShipmentItemProductQty * o.ICShipmentItemProductFactor;
                    totalAllocationQty = totalAllocationQty - Math.Abs((o.ICShipmentItemProductQty - oldQty));
                }
                if (totalAllocationWoodQty > 0 && o.ICShipmentItemProductExchangeQty > 0)
                {
                    oldWoodQty = o.ICShipmentItemWoodQty;
                    o.ICShipmentItemWoodQty = o.ICShipmentItemWoodQty + calWoodOperation * totalAllocationWoodQty;
                    o.ICShipmentItemWoodQty = o.ICShipmentItemWoodQty < 0 ? 0 : o.ICShipmentItemWoodQty;
                    o.ICShipmentItemWoodQty = Math.Round(o.ICShipmentItemWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    totalAllocationWoodQty = totalAllocationWoodQty - Math.Abs((o.ICShipmentItemWoodQty - oldWoodQty));
                }
            });
            item.ICShipmentItemProductQty = shipmentItemList.Sum(o => o.ICShipmentItemProductQty);
            item.ICShipmentItemWoodQty = shipmentItemList.Sum(o => o.ICShipmentItemWoodQty);
            item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
        }

        public void ChangeItemVMProductUnitCost(ICShipmentItemVMsInfo item)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            decimal unitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, mainobject.ICShipmentDate);
            item.ICShipmentItemProductUnitCost = unitCost * item.ICShipmentItemProductFactor;
            item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductQty;

            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(item.FK_ICStockID, item.FK_ICProductID, item.FK_ICProductSerieID);
            if (objInventoryStocksInfo != null && !string.IsNullOrEmpty(item.ICShipmentItemProductSerialNo))
            {
                item.ICShipmentItemProductQty = objInventoryStocksInfo.ICInventoryStockQuantity;
                item.ICShipmentItemProductSerialNo = objInventoryStocksInfo.ICProductSerieNo;
                item.ICShipmentItemLotNo = objInventoryStocksInfo.ICProductSerieLotNo;
                item.ICShipmentItemProductFactor = 1;
                item.ICShipmentItemProductExchangeQty = objInventoryStocksInfo.ICInventoryStockQuantity;

                item.ICShipmentItemLength = objInventoryStocksInfo.ICProductSerieProductLength;
                item.ICShipmentItemWidth = objInventoryStocksInfo.ICProductSerieProductWidth;
                item.ICShipmentItemLengthMax = objInventoryStocksInfo.ICProductSerieProductLengthMax;
                item.ICShipmentItemWidthMax = objInventoryStocksInfo.ICProductSerieProductWidthMax;

                item.ICShipmentItemPerimeter = objInventoryStocksInfo.ICProductSerieProductPerimeter;
                item.FK_ICProductAttributeQualityID = objInventoryStocksInfo.FK_ICProductAttributeQualityID;
                item.ICShipmentItemWoodQty = objInventoryStocksInfo.ICInventoryStockWoodQuantity;
                item.FK_ICProductAttributeQualityID = objInventoryStocksInfo.FK_ICProductAttributeQualityID;
                item.FK_ICProductAttributeTTMTID = objInventoryStocksInfo.FK_ICProductAttributeTTMTID;
                item.FK_GECountryID = objInventoryStocksInfo.FK_GECountryID;
            }
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            List<ICShipmentItemsInfo> shipmentItemList = entity.ShipmentItemList.Where(o => itemRef.Contains(o.VirtualID)).ToList();

            decimal tolenrancePlus = 0;
            decimal remainPlanQty = 0;
            decimal maxAllocationQty = 0;

            List<MMAllocationPlanItemsInfo> listRemainQty = GetRemainQtyForShipment(item.FK_ICProductID, item.MMAllocationPlanItemRef, item.ICShipmentItemRefID, out remainPlanQty, out tolenrancePlus, false);
            decimal sameItemQty = entity.TotalShipmentItemsList.Where(o => o.MMAllocationPlanItemRef == item.MMAllocationPlanItemRef && item.ICShipmentItemRef != o.ICShipmentItemRef).Sum(o => o.ICShipmentItemProductExchangeQty);
            sameItemQty = sameItemQty / (item.ICShipmentItemProductFactor > 0 ? item.ICShipmentItemProductFactor : 1);
            remainPlanQty = remainPlanQty + tolenrancePlus - sameItemQty;
            maxAllocationQty = Math.Min(item.ICShipmentItemProductQty, remainPlanQty);
            maxAllocationQty = Math.Round(maxAllocationQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);

            decimal totalAllocationWoodQty = item.ICShipmentItemWoodQty;
            decimal rateQty = item.ICShipmentItemProductQty == 0 ? 0 : maxAllocationQty / item.ICShipmentItemProductQty;
            if (rateQty > 1)
                rateQty = 1;

            item.ICShipmentItemWoodQty = item.ICShipmentItemWoodQty * rateQty;
            item.ICShipmentItemWoodQty = Math.Round(item.ICShipmentItemWoodQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            totalAllocationWoodQty = item.ICShipmentItemWoodQty;
            SynItemQty(item, shipmentItemList, measureUnitList, listRemainQty, maxAllocationQty, totalAllocationWoodQty, tolenrancePlus);

            SynsItemData(item, shipmentItemList, objInventoryStocksInfo);
            if (entity.ShipmentItemList.GridControl != null)
            {
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
        }

        public void SynsItemData(ICShipmentItemVMsInfo item, IList<ICShipmentItemsInfo> shipmentItemList, ICInventoryStocksInfo objInventoryStocksInfo = null)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductExchangeQty;
            shipmentItemList.ForEach(o =>
            {
                //o.FK_MMWorkShopID = item.FK_MMWorkShopID;
                //o.FK_MMLineID = item.FK_MMLineID;
                //o.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                o.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
                o.ICShipmentItemProductFactor = item.ICShipmentItemProductFactor;
                o.FK_ICProductSerieID = item.FK_ICProductSerieID;
                o.ICShipmentItemProductSerialNo = item.ICShipmentItemProductSerialNo;
                o.ICShipmentItemLotNo = item.ICShipmentItemLotNo;
                o.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
                if (objInventoryStocksInfo != null && !string.IsNullOrEmpty(o.ICShipmentItemProductSerialNo))
                {
                    o.ICShipmentItemProductSerialNo = objInventoryStocksInfo.ICProductSerieNo;
                    o.ICShipmentItemLotNo = objInventoryStocksInfo.ICProductSerieLotNo;
                    o.ICShipmentItemPerimeter = objInventoryStocksInfo.ICProductSerieProductPerimeter;

                    o.ICShipmentItemLength = objInventoryStocksInfo.ICProductSerieProductLength;
                    o.ICShipmentItemWidth = objInventoryStocksInfo.ICProductSerieProductWidth;
                    o.ICShipmentItemHeight = objInventoryStocksInfo.ICProductSerieProductHeight;

                    o.ICShipmentItemWidthMin = objInventoryStocksInfo.ICProductSerieProductWidthMin;
                    o.ICShipmentItemLengthMin = objInventoryStocksInfo.ICProductSerieProductLengthMin;

                    o.ICShipmentItemLengthMax = objInventoryStocksInfo.ICProductSerieProductLengthMax;
                    o.ICShipmentItemWidthMax = objInventoryStocksInfo.ICProductSerieProductWidthMax;

                    o.FK_ICProductAttributeQualityID = objInventoryStocksInfo.FK_ICProductAttributeQualityID;
                    o.FK_ICProductAttributeTTMTID = objInventoryStocksInfo.FK_ICProductAttributeTTMTID;
                    o.FK_GECountryID = objInventoryStocksInfo.FK_GECountryID;
                }
                if (mainobject.ICShipmentTypeCombo == ShipmentType.RoundwoodShipment.ToString())
                {
                    o.ICShipmentItemPerimeter = item.ICShipmentItemPerimeter;
                    o.ICShipmentItemLength = item.ICShipmentItemLength;
                    o.ICShipmentItemWidth = item.ICShipmentItemWidth;
                }
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
                    o.ICShipmentItemWidth = item.ICShipmentItemWidth;
                    o.ICShipmentItemHeight = item.ICShipmentItemHeight;
                }
                entity.SetProductPriceByProductUnitPrice(o);
                o.ICShipmentItemProductExchangeQty = o.ICShipmentItemProductQty * o.ICShipmentItemProductFactor;
            });
        }

        public void ChangeShipmentItemVMQty(ICShipmentItemVMsInfo item, string columnName, out bool isSuccess)
        {
            isSuccess = true;
            if (Toolbar.IsNullOrNoneAction())
                return;

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            decimal oldProductFactor = item.ICShipmentItemProductFactor;
            decimal oldWoodQty = item.ICShipmentItemWoodQty;
            decimal oldExchangeQty = item.ICShipmentItemProductExchangeQty;
            if (columnName == "FK_ICMeasureUnitID")
            {
                ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                item.ICShipmentItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0) ? measureUnit.ICProductMeasureUnitFactor : 1;
                item.ICShipmentItemProductQty = oldExchangeQty / (item.ICShipmentItemProductFactor > 0 ? item.ICShipmentItemProductFactor : 1);
                if (oldProductFactor > 0 && oldProductFactor != item.ICShipmentItemProductFactor && item.ICShipmentItemProductUnitCost > 0)
                {
                    decimal unitCost = (item.ICShipmentItemProductUnitCost / oldProductFactor) * item.ICShipmentItemProductFactor;
                    item.ICShipmentItemProductUnitCost = unitCost;
                    item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductQty;

                }
            }
            if (columnName == "ICShipmentItemProductQty")
            {
                CalculatedTotalWoodQtyByPackageVolumnConfig();
            }
            decimal tolenrancePlus = 0;
            decimal remainPlanQty = 0;
            decimal maxAllocationQty = 0;

            List<MMAllocationPlanItemsInfo> listRemainQty = GetRemainQtyForShipment(item.FK_ICProductID, item.MMAllocationPlanItemRef, item.ICShipmentItemRefID, out remainPlanQty, out tolenrancePlus, true);
            decimal sameItemQty = entity.TotalShipmentItemsList.Where(o => o.MMAllocationPlanItemRef == item.MMAllocationPlanItemRef && item.ICShipmentItemRef != o.ICShipmentItemRef).Sum(o => o.ICShipmentItemProductExchangeQty);
            //sameItemQty = sameItemQty / (item.ICShipmentItemProductFactor > 0 ? item.ICShipmentItemProductFactor : 1);
            remainPlanQty = remainPlanQty + tolenrancePlus - sameItemQty;
            remainPlanQty = remainPlanQty / (item.ICShipmentItemProductFactor > 0 ? item.ICShipmentItemProductFactor : 1);
            remainPlanQty = Math.Round(remainPlanQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            maxAllocationQty = Math.Min(item.ICShipmentItemProductQty, remainPlanQty);
            maxAllocationQty = Math.Round(maxAllocationQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);

            if (!string.IsNullOrEmpty(item.MMAllocationPlanItemRef) && item.ICShipmentItemProductQty  > remainPlanQty && columnName != "FK_ICMeasureUnitID")
            {
                MessageBox.Show(string.Format("Sản phẩm [{0}] có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể xuất kho là: {1} {2}", item.ICShipmentItemProductName, remainPlanQty.ToString("n6"), 
                                BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", item.FK_ICMeasureUnitID, "ICMeasureUnitName")),
                                BaseLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                item.ICShipmentItemProductFactor = oldProductFactor;
                item.ICShipmentItemWoodQty = oldWoodQty;
                item.ICShipmentItemProductExchangeQty = oldExchangeQty;
                isSuccess = false;
                return;
            }
            
            item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
            List<Guid> itemRef = item.ICShipmentItemRef.Split(',').Select(o => Guid.Parse(o)).ToList();
            List<ICShipmentItemsInfo> shipmentItemList = entity.ShipmentItemList.Where(o => itemRef.Contains(o.VirtualID)).ToList();

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetAllAliveMeasureUnit();
            SynItemQty(item, shipmentItemList, measureUnitList, listRemainQty, maxAllocationQty, item.ICShipmentItemWoodQty, tolenrancePlus);
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
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;

            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            List<APPurchaseOrdersInfo> purchareOrderList = objPurchaseOrdersController.GetPurchaseOrderOutSourcingByBatchProductID(mainobject.FK_MMBatchProductID);
            purchareOrderList.Insert(0, new APPurchaseOrdersInfo());
            return purchareOrderList;
        }

        public void UpdateLotNoItem(ICShipmentItemVMsInfo objShipmentItemsInfo)
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(objShipmentItemsInfo.FK_ICProductSerieID);
            if (objProductSeriesInfo != null)
            {
                objShipmentItemsInfo.ICShipmentItemLotNo = objProductSeriesInfo.ICProductSerieLotNo;
            }
            else
            {
                objShipmentItemsInfo.ICShipmentItemLotNo = string.Empty;
            }
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
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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

        public void ChangeWorkShop(int workshopID)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            mainobject.FK_MMLineID = lineID;
            entity.ShipmentItemList.ForEach(o =>
            {
                o.FK_MMLineID = lineID;
            });

            entity.ShipmentItemList.GridControl?.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeOperation(int operationID)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMOperationID = operationID;
            int countNorm = entity.ShipmentItemList.Where(o => o.FK_MMBatchProductProductionNormItemID > 0).Count();
            if (countNorm > 0) return;
            int countOpExist = entity.ShipmentItemList.Where(o => o.FK_MMOperationID > 0).Count();
            if (countOpExist > 0 && BOSApp.ShowMessageYesNo("Bạn chắc chắn thay đổi công đoạn cho tất cả chi tiết?") == DialogResult.No) return;
            entity.ShipmentItemList.ForEach(o =>
            {
                //if (o.FK_MMBatchProductProductionNormItemID > 0)
                //    return;

                o.FK_MMOperationID = operationID;
            });
            entity.ShipmentItemList.GridControl?.RefreshDataSource();
        }

        public override void CheckValidateSerieNo(BusinessObject item, string itemTableName, string serieColumnName, bool isCheckInventory = true)
        {
            isCheckInventory = false;
            base.CheckValidateSerieNo(item, itemTableName, serieColumnName, isCheckInventory);
        }

        public override bool ActionCancelComplete()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
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
            if (!base.ActionCancelComplete()) return false;
            return true;
        }

        public void CalculatedTotalProductQtyByPackageVolumnConfig()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentItemVMsInfo item = entity.TotalShipmentItemsList[entity.TotalShipmentItemsList.CurrentIndex];
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
                    entity.TotalShipmentItemsList.GridControl?.RefreshDataSource();
                }
            }
        }
        public void CalculatedTotalWoodQtyByPackageVolumnConfig()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentItemVMsInfo item = entity.TotalShipmentItemsList[entity.TotalShipmentItemsList.CurrentIndex];
            if (item != null)
            {
                if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if (product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemProductQty != 0M
                    )
                {
                    decimal woodqty = item.ICShipmentItemProductQty / (item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth / 1000000000);
                    if (woodqty != item.ICShipmentItemWoodQty)
                    {
                        item.ICShipmentItemWoodQty = Math.Round(woodqty, RoundingNumber.FormatN0, MidpointRounding.AwayFromZero);
                    }
                    item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                    item.ICShipmentItemProductExchangeQty = Math.Round(item.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    entity.TotalShipmentItemsList.GridControl?.RefreshDataSource();
                }
            }
        }

        public void AutoSelectProductSerialNo()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }

            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            if (entity.TotalShipmentItemsList.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm xuất kho để gắn mã lô!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                    CalculatedTotalProductQtyByPackageVolumnConfig();
                    ChangeItemVM(itemVM);
                }
            }
            entity.TotalShipmentItemsList.GridControl?.RefreshDataSource();
        }
        public void AddItemFromProductConversionToList( List<MMAllocationPlanItemsInfo> ListAllocationPlanItems)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            mainObject.ICShipmentShipmentType = AllocationPlanItemGroup.Material.ToString();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            ListAllocationPlanItems.ForEach(o =>
            {
                objShipmentItemsInfo = ToShipmentItems(o);
                objShipmentItemsInfo.FK_ICProductSerieID = o.FK_ICProductSerieID;
                objShipmentItemsInfo.ICShipmentItemProductSerialNo = o.MMAllocationPlanItemProductSerialNo;
                objShipmentItemsInfo.ICShipmentItemLotNo = o.MMAllocationPlanItemProductLotNo;
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
            mainObject.FK_MMAllocationPlanID = shipmentItemList.FirstOrDefault().FK_MMAllocationPlanID;
            mainObject.FK_MMBatchProductID = shipmentItemList.FirstOrDefault().FK_MMBatchProductID;
            mainObject.FK_MMWorkShopID = shipmentItemList.FirstOrDefault().FK_MMWorkShopID;
            mainObject.FK_MMLineID = shipmentItemList.FirstOrDefault().FK_MMLineID;
            mainObject.FK_MMOperationID = shipmentItemList.FirstOrDefault().FK_MMOperationID;
            mainObject.FK_HREmployeeReceverID = shipmentItemList.FirstOrDefault().FK_HREmployeeReceverID;
            mainObject.ICShipmentSOName = shipmentItemList.FirstOrDefault().ICShipmentItemSOName;
            mainObject.FK_ICStockID = shipmentItemList.FirstOrDefault().FK_ICStockID;
            mainObject.STToolbarActionName = "NewFromAllocationPlanMaterial";
            base.Toolbar.ModusAction = "New";
            this.ToolbarNewActionName = "NewFromAllocationPlanMaterial";
            entity.UpdateMainObjectBindingSource();
        }
        public ICShipmentItemsInfo ToShipmentItems(ICProductConversionItemsInfo item)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == item.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsForViewInfo();

            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            BOSUtil.CopyObject(objProductsInfo, objShipmentItemsInfo);
            objShipmentItemsInfo.FK_ICStockID = item.FK_ICStockID;
            if (objProductsInfo != null)
            {
                entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                objShipmentItemsInfo.FK_ACAccountID = GetAccountByStock(objShipmentItemsInfo.FK_ICStockID, objShipmentItemsInfo.FK_ACAccountID);
                objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                objShipmentItemsInfo.ICShipmentItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
            }
            objShipmentItemsInfo.VirtualID = Guid.NewGuid();
            objShipmentItemsInfo.FK_ICProductID = item.FK_ICProductID;
            objShipmentItemsInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
            objShipmentItemsInfo.FK_ICStockID = item.FK_ICStockID;
            objShipmentItemsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
            objShipmentItemsInfo.ICShipmentItemProductSerialNo = item.ICProductConversionItemProductSerialNo;
            objShipmentItemsInfo.ICShipmentItemLotNo = item.ICProductConversionItemLotNo;
            objShipmentItemsInfo.ICShipmentItemProductName = item.ICProductConversionItemProductName;
            objShipmentItemsInfo.ICShipmentItemProductDesc = item.ICProductConversionItemProductDesc;
            objShipmentItemsInfo.ICShipmentItemProductQty = item.ICProductConversionItemProductQty;
            objShipmentItemsInfo.ICShipmentItemLength = item.ICProductConversionItemProductLength;
            objShipmentItemsInfo.ICShipmentItemWidth = item.ICProductConversionItemProductWidth;
            objShipmentItemsInfo.ICShipmentItemHeight = item.ICProductConversionItemProductHeight;
            objShipmentItemsInfo.ICShipmentItemProductExchangeQty = item.ICProductConversionItemProductQty;
            objShipmentItemsInfo.ICShipmentItemWoodQty = item.ICProductConversionItemWoodQty;
            objShipmentItemsInfo.ICShipmentItemProductUnitCost = item.ICProductConversionItemUnitCost;
            objShipmentItemsInfo.ICShipmentItemExchangeUnitCost = item.ICProductConversionItemUnitCost;
            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
            objShipmentItemsInfo.VirtualID = Guid.NewGuid();
            objShipmentItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
            objShipmentItemsInfo.FK_ICImportAndExportReasonID = mainobject.FK_ICImportAndExportReasonID;

            objShipmentItemsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
            objShipmentItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
            objShipmentItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
            objShipmentItemsInfo.FK_MMAllocationPlanID = item.FK_MMAllocationPlanID;
            objShipmentItemsInfo.FK_MMAllocationPlanItemID = item.MMAllocationPlanItemID;
            objShipmentItemsInfo.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
            objShipmentItemsInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
            objShipmentItemsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
            objShipmentItemsInfo.FK_MMLineID = item.FK_MMLineID;
            objShipmentItemsInfo.FK_ICStockID = item.FK_ICStockID;
            objShipmentItemsInfo.FK_MMOperationID = item.FK_MMOperationID == 0 ? mainobject.FK_MMOperationID : item.FK_MMOperationID;
            objShipmentItemsInfo.FK_HREmployeeReceverID = item.FK_HREmployeeIDReceive;
            objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID;
       
            objShipmentItemsInfo.ICShipmentItemComment = item.MMAllocationPlanItemComment;
            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
            objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.MMAllocationPlanItemBatchProductItemProductSerial;
            objShipmentItemsInfo.ICShipmentItemQty6 = item.MMAllocationPlanItemNormQty;
            objShipmentItemsInfo.ICShipmentItemProductName2 = item.ICProductName2;
            objShipmentItemsInfo.MMBatchProductProductionNormItemProductLength = item.MMBatchProductProductionNormItemProductLength;
            objShipmentItemsInfo.MMBatchProductProductionNormItemProductHeight = item.MMBatchProductProductionNormItemProductHeight;
            objShipmentItemsInfo.MMBatchProductProductionNormItemProductWidth = item.MMBatchProductProductionNormItemProductWidth;
            objShipmentItemsInfo.VirtualID = Guid.NewGuid();
            objShipmentItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
            objShipmentItemsInfo.ICShipmentItemSOName = item.MMBatchProductItemSOName;
            objShipmentItemsInfo.FK_ICImportAndExportReasonID = mainobject.FK_ICImportAndExportReasonID;

            return objShipmentItemsInfo;
        }
        public void UpdatePositionItem(ICShipmentItemsInfo item)
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objICShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            MMUpdatePositionItemsController objUpdatePositionItemsController = new MMUpdatePositionItemsController();
            MMUpdatePositionItemsInfo objUpdatePositionItemsInfo = (MMUpdatePositionItemsInfo)objUpdatePositionItemsController.GetItemByLocationName(string.Empty, item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID);
            if (objUpdatePositionItemsInfo != null)
            {
                item.FK_MMUpdatePositionItemID = objUpdatePositionItemsInfo.MMUpdatePositionItemID;
            }
        }
    }
    #endregion
}
