using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;

namespace BOSERP.Modules.OutsourcingShipment
{
    #region OutsourcingShipment
    public class OutsourcingShipmentModule : GLShipmentModule
    {
        #region Constants
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";

        public const string TabControlName = "fld_tabShiptmentItems";


        public const string ICShipmentShipmentTypeLookupEditControlName = "fld_lkeICShipmentShipmentType";

        public const string ICProductLookupEditControlName = "fld_lkeFK_ICProductID";

        //public const string MMOperationLookupEditControlName = "fld_lkeFK_MMOperationID";
        //public const string ButtonShowAllocationProposal = "fld_btnShowAllocationProposal";
        //public const string ICShipmentItemGridControlName = "fld_dgcICShipmentItems";

        public const string ICMaterialProductLookupEditControlName = "fld_lkeFK_ICProductID2";

        #endregion

        #region Properties
        BOSComponent.BOSTabControl Tab;

        BOSComponent.BOSLookupEdit IShipmentShipmentType;

        BOSComponent.BOSLookupEdit ProductLookupEditControl;

        BOSComponent.BOSLookupEdit MMOperationLookupEditControl;

        BOSComponent.BOSButton ShowAllocationProposal;

        BOSComponent.BOSLookupEdit MaterialProductLookupEditControl;

        private bool EditAfterCompleting = false;

        #endregion

        public OutsourcingShipmentModule()
        {
            Name = ModuleName.OutsourcingShipment;
            CurrentModuleEntity = new OutsourcingShipmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            Tab = (BOSComponent.BOSTabControl)Controls[OutsourcingShipmentModule.TabControlName];
            IShipmentShipmentType = (BOSComponent.BOSLookupEdit)Controls[OutsourcingShipmentModule.ICShipmentShipmentTypeLookupEditControlName];
            ProductLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[OutsourcingShipmentModule.ICProductLookupEditControlName];
            //MMOperationLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[OutsourcingShipmentModule.MMOperationLookupEditControlName];
            //ShowAllocationProposal = (BOSComponent.BOSButton)Controls[OutsourcingShipmentModule.ButtonShowAllocationProposal];
            MaterialProductLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[OutsourcingShipmentModule.ICMaterialProductLookupEditControlName];
            MaterialProductLookupEditControl.Properties.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Hardware.ToString()
                                                                                                    || o.ICProductType == ProductType.SemiProduct.ToString()
                                                                                                    || o.ICProductType == ProductType.IngredientPaint.ToString()
                                                                                                    || o.ICProductType == ProductType.IngredientPackaging.ToString()).ToList();
            ProductLookupEditControl.Properties.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType != ProductType.Hardware.ToString()
                                                                                                    || o.ICProductType != ProductType.SemiProduct.ToString()
                                                                                                    || o.ICProductType != ProductType.IngredientPaint.ToString()
                                                                                                    || o.ICProductType != ProductType.IngredientPackaging.ToString()).ToList();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = objShipmentsController.GetShipmentListAllType(searchObject.ICShipmentNo,
                                                                    searchObject.FK_BRBranchID,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_ICStockID,
                                                                    searchObject.FK_HREmployeeID,
                                                                    ShipmentType.OutsourcingReceipt.ToString(),
                                                                    null,
                                                                    searchObject.ShipmentDateFrom,
                                                                    searchObject.ShipmentDateTo);

            return ds;
        }

        public void ChangeItemFromShipmentItemsList()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int index = entity.ShipmentItemList.CurrentIndex;
            if (index >= 0)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[index];
                if (objShipmentItemsInfo != null)
                {
                    objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                    entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
                    BOSApp.RoundByCurrency(objShipmentItemsInfo, objShipmentsInfo.FK_GECurrencyID);
                }
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateDocumentEntries();
        }

        public void ChangeItemFromMaterialShipmentItemsList()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int index = entity.MaterialShipmentItemList.CurrentIndex;
            if (index >= 0)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = entity.MaterialShipmentItemList[index];
                if (objShipmentItemsInfo != null)
                {
                    objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                    BOSApp.RoundByCurrency(objShipmentItemsInfo, objShipmentsInfo.FK_GECurrencyID);
                }
                entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateDocumentEntries();
        }

        public void ChangeItemProductQty()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int index = entity.ShipmentItemList.CurrentIndex;
            if (index < 0)
                return;
            ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[index];
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();

            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetObjectByID(objShipmentItemsInfo.FK_ICTransferItemID);
            if (objTransferItemsInfo == null)
                objTransferItemsInfo = new ICTransferItemsInfo();

            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetAllShipmentItemsByTransferItemID(objShipmentItemsInfo.FK_ARDeliveryPlanItemID);
            decimal totalQty = shipmentItems.Where(o => o.Id != objShipmentItemsInfo.Id
                                                    && o.FK_ICTransferItemID != 0).Select(o => o.ICShipmentItemProductQty).Sum();

            if ((objShipmentItemsInfo.ICShipmentItemProductQty > objTransferItemsInfo.ICTransferItemProductQty - totalQty) && objShipmentItemsInfo.FK_ICTransferItemID != 0)
            {
                MessageBox.Show(OutsourcingShipmentLocalizedResources.ShipmentItemMaxProductQtyErrorMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objShipmentItemsInfo.ICShipmentItemProductQty = objTransferItemsInfo.ICTransferItemProductQty - totalQty;
                return;
            }
            objShipmentItemsInfo.ICShipmentItemTaxAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
            entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void ChangeMaterialShipmentItemProductQty()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int index = entity.MaterialShipmentItemList.CurrentIndex;
            if (index < 0)
                return;
            ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[index];
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();

            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetObjectByID(objShipmentItemsInfo.FK_ICTransferItemID);
            if (objTransferItemsInfo == null)
                objTransferItemsInfo = new ICTransferItemsInfo();

            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetAllShipmentItemsByTransferItemID(objShipmentItemsInfo.FK_ARDeliveryPlanItemID);
            decimal totalQty = shipmentItems.Where(o => o.Id != objShipmentItemsInfo.Id
                                                    && o.FK_ICTransferItemID != 0).Select(o => o.ICShipmentItemProductQty).Sum();

            if ((objShipmentItemsInfo.ICShipmentItemProductQty > objTransferItemsInfo.ICTransferItemProductQty - totalQty) && objShipmentItemsInfo.FK_ICTransferItemID != 0)
            {
                MessageBox.Show(OutsourcingShipmentLocalizedResources.ShipmentItemMaxProductQtyErrorMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objShipmentItemsInfo.ICShipmentItemProductQty = objTransferItemsInfo.ICTransferItemProductQty - totalQty;
                return;
            }
            objShipmentItemsInfo.ICShipmentItemTaxAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
            entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void SelectSeriesNoDefault()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void SelectSeriesNoDefaultForMaterialList()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            DataGenerator.SelectSeriesNoDefault(entity.MaterialShipmentItemList);
            entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
        }

        public void AddItemToShipmentItemsList()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            objShipmentItemsInfo.FK_ICTransferID = 0;
            objShipmentItemsInfo.FK_ICTransferItemID = 0;
            if (objShipmentItemsInfo.FK_ICProductID > 0)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);

                if (objShipmentsInfo != null)
                {
                    objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                    objShipmentItemsInfo.FK_ICImportAndExportReasonID = objShipmentsInfo.FK_ICImportAndExportReasonID;
                }
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                    objShipmentItemsInfo.FK_ACAccountID = GetAccountByStock(objShipmentItemsInfo.FK_ICStockID, objShipmentItemsInfo.FK_ACAccountID);
                }
                entity.ShipmentItemList.AddObjectToList();
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateDocumentEntries();
        }

        public void AddItemToMaterialShipmentItemsList()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            objShipmentItemsInfo.FK_ICTransferID = 0;
            objShipmentItemsInfo.FK_ICTransferItemID = 0;
            if (objShipmentItemsInfo.FK_ICProductID > 0)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);

                if (objShipmentsInfo != null)
                {
                    objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                    objShipmentItemsInfo.FK_ICImportAndExportReasonID = objShipmentsInfo.FK_ICImportAndExportReasonID;
                }
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                    objShipmentItemsInfo.FK_ACAccountID = GetAccountByStock(objShipmentItemsInfo.FK_ICStockID, objShipmentItemsInfo.FK_ACAccountID);
                }
                entity.MaterialShipmentItemList.AddObjectToList();
                entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateDocumentEntries();
        }

        public override void InvalidateToolbar()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            }
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }
            base.InvalidateToolbar();
        }

        public override int ActionSave()
        {
            InvalidateToolbar();
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            int objectID = base.ActionSave();
            if (objectID > 0)
            {
                if (EditAfterCompleting)
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    EditAfterCompleting = false;
                }
                entity.InvalidateItemComponents();
            }
            return objectID;
        }

        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateDocumentEntries();
            }
        }

        public void DeleteItemFromMaterialShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
                entity.MaterialShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateDocumentEntries();
            }
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
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            entity.ShipmentItemList.EndCurrentEdit();
            entity.MaterialShipmentItemList.EndCurrentEdit();
            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                if (objShipmentItemsInfo.FK_ICProductSerieID == 0)
                {
                    MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.MaterialShipmentItemList)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                if (objShipmentItemsInfo.FK_ICProductSerieID == 0)
                {
                    MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
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

            if (entity.MaterialShipmentItemList.BackupList != null && entity.MaterialShipmentItemList.BackupList.Count > 0)
            {
                entity.MaterialShipmentItemList.BackupList.Clear();
            }

            if (entity.MaterialShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
            {
                return false;
            }
            return base.ActionComplete();
        }

        #region ActionNew
        public override void ActionNew()
        {
            base.ActionNew();
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentShipmentType = ShipmentShipmentType.Other.ToString();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            objShipmentItemsInfo.ICShipmentType = ShipmentType.OutsourcingReceipt.ToString();

            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            List<ICTransferItemsInfo> transferItemsList = objTransferItemsController.GetTransferItemsForOutsourcingShipment();

            guiAddTransferItem guiFind = new guiAddTransferItem(transferItemsList);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                base.ActionCancel();
                return;
            }
            if (transferItemsList.Count == 0)
                return;
            transferItemsList = (List<ICTransferItemsInfo>)guiFind.SelectedObjects;
            ICTransferItemsInfo objTransferItemsInfo = guiFind.SelectedObjects[0];

            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objTransferItemsInfo.FK_APPurchaseOrderID);
            if (objPurchaseOrdersInfo != null)
            {
                objShipmentsInfo.ICShipmentPONo = objPurchaseOrdersInfo.APPurchaseOrderNo;
                objShipmentsInfo.FK_ACObjectID = objPurchaseOrdersInfo.FK_ACObjectID;
                objShipmentsInfo.ICObjectType = objPurchaseOrdersInfo.APObjectType;
                objShipmentsInfo.ACObjectAccessKey = objShipmentsInfo.FK_ACObjectID + ";" + objShipmentsInfo.ICObjectType;
            }

            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            transferItemsList.ForEach(o =>
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    o.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    o.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                if (o.ICTransferItemType == TransferItemType.Product.ToString())
                {
                    objShipmentItemsInfo = ToShipmentItemInfo(o);
                    objShipmentItemsInfo.ICShipmentItemType = ShipmentItemType.Product.ToString();
                    entity.ShipmentItemList.Add(objShipmentItemsInfo);
                }
                else
                {
                    objShipmentItemsInfo = ToShipmentItemInfo(o);
                    objShipmentItemsInfo.ICShipmentItemType = ShipmentItemType.Material.ToString();
                    entity.MaterialShipmentItemList.Add(objShipmentItemsInfo);
                }
            });
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void ActionNewFromManual()
        {
            ActionNew();
        }

        private ICShipmentItemsInfo ToShipmentItemInfo(ICTransferItemsInfo objTransferItemsInfo)
        {
            return new ICShipmentItemsInfo()
            {
                FK_ARSaleOrderID = objTransferItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemWorkID = objTransferItemsInfo.FK_ARSaleOrderItemWorkID,
                FK_ICMeasureUnitID = objTransferItemsInfo.FK_ICMeasureUnitID,
                FK_ICDepartmentID = objTransferItemsInfo.FK_ICDepartmentID,
                FK_ICModelID = objTransferItemsInfo.FK_ICModelID,
                FK_ICProductID = objTransferItemsInfo.FK_ICProductID,
                FK_ICProductGroupID = objTransferItemsInfo.FK_ICProductGroupID,
                FK_ICProductSerieID = objTransferItemsInfo.FK_ICProductSerieID,
                ICShipmentItemProductName = objTransferItemsInfo.ICTransferItemProductName,
                ICShipmentItemProductDesc = objTransferItemsInfo.ICTransferItemProductDesc,
                ICShipmentItemProductQty = objTransferItemsInfo.ICTransferItemProductQty,
                ICShipmentItemProductUnitPrice = objTransferItemsInfo.ICTransferItemProductUnitPrice,
                ICShipmentItemProductUnitCost = objTransferItemsInfo.ICTransferItemProductUnitCost,
                FK_ICTransferID = objTransferItemsInfo.FK_ICTransferID,
                FK_ICTransferItemID = objTransferItemsInfo.ICTransferItemID,
                FK_ICStockID = objTransferItemsInfo.FK_ICToStockID,
                ICShipmentItemProductSerialNo = objTransferItemsInfo.ICTransferItemProductSerialNo,
                FK_ACAccountID = objTransferItemsInfo.FK_ACAccountID,
            };
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }
        #endregion
        public void ReadOnlyControl(bool check)
        {
            IShipmentShipmentType.Properties.ReadOnly = check;
        }

        public void ChangeOperation(int operation)
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMOperationID = operation;
            UpdateDocumentEntries();
        }

        public void ChangeDepartment(int department)
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_HRDepartmentID = department;
            UpdateDocumentEntries();
        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objACAccountsInfo = null;

            ICImportAndExportReasonsController objIAERController = new ICImportAndExportReasonsController();
            ICImportAndExportReasonsInfo objIAERInfo = null;
            int accountDebitID = 0;
            if (objShipmentsInfo.FK_ICImportAndExportReasonID > 0)
            {
                objIAERInfo = objIAERController.GetObjectByID(objShipmentsInfo.FK_ICImportAndExportReasonID) as ICImportAndExportReasonsInfo;
                if (objIAERInfo != null)
                    accountDebitID = objIAERInfo.FK_ACAcountID;
            }

            int accountStockID = 0;
            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStockInfo = null;
            if (objShipmentsInfo.FK_ICStockID > 0)
            {
                objStockInfo = (ICStocksInfo)objStockController.GetObjectByID(objShipmentsInfo.FK_ICStockID);
                if (objStockInfo != null)
                    accountStockID = objStockInfo.FK_ACAccountID;
            }

            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string documentType = AccDocumentType.XuatKhoVatTu.ToString();
            string entryType = AccEntryType.XuatKhoVatTu.ToString();

            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>>();
            List<int> productAccountID = new List<int>();
            ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
            List<ACDocumentEntrysInfo> removedDocuments = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType).ToList();
            if (removedDocuments != null)
            {
                foreach (ACDocumentEntrysInfo item in removedDocuments)
                    entity.DocumentEntryList.Remove(item);
            }
            int accountCompareID = 0;
            if (entity.ShipmentItemList != null)
            {
                foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
                {
                    ICProductsInfo objProductInfo = (ICProductsInfo)productController.GetObjectByID(shipmentItem.FK_ICProductID);
                    int accountProduct = 0;
                    accountProduct = objProductInfo.FK_ACAccountCostPriceID;

                    if (accountStockID > 0)
                    {
                        accountCompareID = accountStockID;
                    }
                    else
                    {
                        accountCompareID = shipmentItem.FK_ACAccountID;
                    }
                    entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACDebitAccountID == accountDebitID
                                                                       && e.FK_ACCreditAccountID == accountCompareID);
                    {
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACCreditAccountID = accountCompareID;
                            if (accountDebitID > 0)
                                entry.FK_ACDebitAccountID = objIAERInfo.FK_ACAcountID;
                        }
                        if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                        {
                            documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                            if (accountDebitID > 0)
                                entry.FK_ACDebitAccountID = objIAERInfo.FK_ACAcountID;
                            productAccountID.Add(entry.FK_ACCreditAccountID);
                        }
                        documentEntryAccounts[entry].Add(shipmentItem);
                    }
                }
            }
            if (entity.MaterialShipmentItemList != null)
            {
                foreach (ICShipmentItemsInfo shipmentItem in entity.MaterialShipmentItemList)
                {
                    ICProductsInfo objProductInfo = (ICProductsInfo)productController.GetObjectByID(shipmentItem.FK_ICProductID);
                    int accountProduct = 0;
                    accountProduct = objProductInfo.FK_ACAccountCostPriceID;

                    if (accountStockID > 0)
                    {
                        accountCompareID = accountStockID;
                    }
                    else
                    {
                        accountCompareID = shipmentItem.FK_ACAccountID;
                    }
                    entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACDebitAccountID == accountDebitID
                                                                       && e.FK_ACCreditAccountID == accountCompareID);
                    {
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACCreditAccountID = accountCompareID;
                            if (accountDebitID > 0)
                                entry.FK_ACDebitAccountID = objIAERInfo.FK_ACAcountID;
                        }
                        if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                        {
                            documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                            if (accountDebitID > 0)
                                entry.FK_ACDebitAccountID = objIAERInfo.FK_ACAcountID;
                            productAccountID.Add(entry.FK_ACCreditAccountID);
                        }
                        documentEntryAccounts[entry].Add(shipmentItem);
                    }
                }
            }

            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo docEntry in documentEntryAccounts.Keys)
                {
                    docEntry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICShipmentItemProductUnitCost * i.ICShipmentItemProductQty);
                    docEntry.ACDocumentEntryExchangeAmount = docEntry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
                    BOSApp.RoundByCurrency(docEntry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(docEntry, "ACDocumentEntryAmount", objShipmentsInfo.FK_GECurrencyID);
                    item = docEntry;
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

            List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ChangeItemSerieNo(ICShipmentItemsInfo item, int listIndex)
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            item.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate) * item.ICShipmentItemProductFactor;
            ICProductSeriesController productSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)productSeriesController.GetObjectByID(item.FK_ICProductSerieID);
            if (objProductSeriesInfo != null)
            {
                item.FK_ICModelID = objProductSeriesInfo.FK_ICModelID;
                item.FK_ICModelDetailID = objProductSeriesInfo.FK_ICModelDetailID;
            }
            GeneralAccountInShipmentItemByStock(item);
            entity.SetProductPriceByProductUnitPrice(item);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
            UpdateDocumentEntries();
        }

        public void ChangeStock(int stockID)
        {
            DialogResult rs = MessageBox.Show(string.Format(OutsourcingShipmentLocalizedResources.ChangeStockWarningMessages)
                                              , CommonLocalizedResources.MessageBoxDefaultCaption
                                              , MessageBoxButtons.YesNo
                                              , MessageBoxIcon.Warning);
            if (rs != DialogResult.Yes)
                return;
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_ICStockID = stockID;
                        item.FK_ICProductSerieID = 0;
                        item.ICShipmentItemProductSerialNo = string.Empty;
                        item.ICShipmentItemLotNo = string.Empty;
                        GeneralAccountInShipmentItemByStock(item);
                    }

                }
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.MaterialShipmentItemList)
                    {
                        item.FK_ICStockID = stockID;
                        item.FK_ICProductSerieID = 0;
                        item.ICShipmentItemProductSerialNo = string.Empty;
                        item.ICShipmentItemLotNo = string.Empty;
                        GeneralAccountInShipmentItemByStock(item);
                    }
                }
                UpdateDocumentEntries();
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                entity.MaterialShipmentItemList.GridControl.RefreshDataSource();
            }
        }

        public void GeneralAccountInShipmentItemByStock(ICShipmentItemsInfo item)
        {
            int accoutTemp = 0;
            if (item.FK_ICStockID > 0)
            {
                item.FK_ACAccountID = GetAccountByStock(item.FK_ICStockID, item.FK_ACAccountID);
            }
        }

        public void ResetProductSerialNo(ICShipmentItemsInfo item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
            {
                item.FK_ICProductSerieID = 0;
                item.ICShipmentItemProductSerialNo = string.Empty;
                item.ICShipmentItemLotNo = string.Empty;
            }
        }

        public void ChangeImportAndExportReason(int importAndExportReasonID)
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
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

        public void PrintOutsourcingShipmentTV()
        {
            OutsourcingShipmentEntities entity = (OutsourcingShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            object[] arParam = new object[1];
            arParam[0] = objShipmentsInfo.ICShipmentID;
            ViewReportByTemplate("RPShipmentTV", "GetDataSourceForRPShipmentTV", arParam);
        }

    }
    #endregion

}
