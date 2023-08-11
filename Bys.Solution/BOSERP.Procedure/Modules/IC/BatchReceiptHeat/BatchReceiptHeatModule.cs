using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Modules.IC.BatchReceiptDryLumber.Localization;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptHeat
{
    public class BatchReceiptHeatModule : BaseTransactionModule
    {
        #region Constants
        public const string ReceiptItemGridControlName = "fld_dgcReceiptItems";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string ProductEditControlName = "fld_lkeFK_ICProductID";
        #endregion

        #region Variable
        #endregion
        BOSComponent.BOSLookupEdit ProductEditControl;
        #region Public properties
        #endregion

        public BatchReceiptHeatModule()
        {
            Name = "BatchReceiptHeat";
            CurrentModuleEntity = new BatchReceiptHeatEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            StartGettingInventoryThread();
            ProductEditControl = (BOSComponent.BOSLookupEdit)Controls[ProductEditControlName];
        }

        public override void ActionNew()
        {
            base.ActionNew();

            SetDefaultEmployee();
            //SetDefaultStock();
            GenerateAccountingData();
            DisplayLabelText(CurrentModuleEntity.MainObject);
            EnableControl(true);
        }
        public void ActionNewFromBatchShipmentFreshLumber()
        {
            ActionNew();
            ShowBatchShipmentFreshLumber();
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            //return base.GetSearchData(ref searchQuery);
            ICReceiptsController objReceiptsController = new ICReceiptsController();

            ACObjectsController objObjectsController = new ACObjectsController();
            ICReceiptsInfo searchObject = (ICReceiptsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = objReceiptsController.GetReceiptList(searchObject.ICReceiptNo,
                                                                    //searchObject.FK_BRBranchID,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_ICStockID,
                                                                    searchObject.FK_HREmployeeID,
                                                                    ReceiptType.ReceiptHeat.ToString(),
                                                                    //null,
                                                                    searchObject.ReceiptDateFrom
,
                                                                    searchObject.ReceiptDateTo);

            return ds;
        }
        public void ShowBatchShipmentFreshLumber()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICReceiptsInfo oldReceipts = (ICReceiptsInfo)CurrentModuleEntity.MainObject.Clone();
            ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
            ICShipmentsController objShipmentController = new ICShipmentsController();
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> ShipmentItemList = new List<ICShipmentItemsInfo>();
            ShipmentItemList = objShipmentItemsController.GetBatchShipmentForReceipt(objReceiptsInfo.FK_MMBatchProductID, objReceiptsInfo.FK_ICProductID);
            List<ICShipmentItemsInfo> shipmentItemCheck = new List<ICShipmentItemsInfo>();
            MMBatchProductsInfo objBatchProductsInfo = new MMBatchProductsInfo();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMOperationsController objOperationsController = new MMOperationsController();

            DateTime fromdate = DateTime.MinValue;
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult == DialogResult.OK)
            {
                fromdate = chooseDate.FromDate;


                ShipmentItemList = objShipmentItemsController.GetBatchShipmentFreshLumberItemForReceipt(fromdate);

                if (ShipmentItemList != null)
                {
                    guiFind<ICShipmentItemsInfo> guiFind = new guiFind<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName,
                                                                                                    ShipmentItemList,
                                                                                                    this,
                                                                                                    true,
                                                                                                    true,
                                                                                                    new string[] { "ICShipmentNo" },
                                                                                                    null,
                                                                                                    true);
                    guiFind.ShowDialog();
                    if (guiFind.DialogResult == DialogResult.OK)
                    {
                        objShipmentsInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(guiFind.SelectedObjects[0].FK_ICShipmentID);
                        if (objShipmentsInfo != null)
                        {
                            objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(objShipmentsInfo.FK_MMBatchProductID);
                            int stockID = objReceiptsInfo.FK_ICStockID;
                            BOSUtil.CopyObject(objShipmentsInfo, objReceiptsInfo);
                            objReceiptsInfo.ICReceiptPackNo = App.DefaultPackNo;
                            objReceiptsInfo.ICReceiptNo = "***NEW***";
                            objReceiptsInfo.FK_ICStockID = stockID;
                            objReceiptsInfo.ICReceiptStatus = oldReceipts.ICReceiptStatus;
                            objReceiptsInfo.FK_ICProductAttributeWoodTypeID = objShipmentsInfo.FK_ICProductAttributeWoodTypeID;
                            objReceiptsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                            objReceiptsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                            objReceiptsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                            objReceiptsInfo.FK_GECountryID = objShipmentsInfo.FK_GECountryID;
                            objReceiptsInfo.ICReceiptContainerNo = objShipmentsInfo.ICShipmentContainerNo;
                            DisplayLabelText(objReceiptsInfo);
                            CurrentModuleEntity.UpdateMainObjectBindingSource();
                        }
                        //Choose first sale order as a template
                        List<ICShipmentItemsInfo> selectedShipmentItems = guiFind.SelectedObjects as List<ICShipmentItemsInfo>;
                        if (selectedShipmentItems != null && selectedShipmentItems.Count > 0)
                        {
                            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objReceiptsInfo.FK_MMOperationID);
                            foreach (ICShipmentItemsInfo item in selectedShipmentItems)
                            {
                                GetSelectedItemFromBatchShipmentFreshLumber(item, objOperationsInfo);
                            }
                            entity.ReceiptItemsList.GridControl.RefreshDataSource();
                        }
                        UpdateTotalCost();
                    }
                    else
                        ActionCancel();
                }
            }
            else
                ActionCancel();
        }

        public void ActionNewFromBatchLumber()
        {
            ActionNew();
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICReceiptsInfo oldReceipts = (ICReceiptsInfo)CurrentModuleEntity.MainObject.Clone();
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            ICShipmentsController objShipmentController = new ICShipmentsController();
            ICShipmentItemsInfo objShipmentItemInfo = new ICShipmentItemsInfo();
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            MMBatchProductsInfo objBatchProductsInfo = new MMBatchProductsInfo();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<ICShipmentItemsInfo> listShipmentItem = new List<ICShipmentItemsInfo>();
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMOperationsController objOperationsController = new MMOperationsController();
            listShipmentItem = objShipmentItemController.GetShipment_BatchLumber();
            guiFind<ICShipmentItemsInfo> guiShipmentItem = new guiFind<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName,
                                                                                            listShipmentItem,
                                                                                            this,
                                                                                            true,
                                                                                            true,
                                                                                            new string[] { "MMBatchProductNo", "ICShipmentNo" });
            guiShipmentItem.ShowDialog();
            if (guiShipmentItem.DialogResult == DialogResult.OK)
            {
                List<ICShipmentItemsInfo> templateListShipment = (List<ICShipmentItemsInfo>)guiShipmentItem.SelectedObjects;
                if (guiShipmentItem.SelectedObjects != null && guiShipmentItem.SelectedObjects.Count > 0)
                {
                    listShipmentItem = templateListShipment.Where(x => x.FK_MMBatchProductID != guiShipmentItem.SelectedObjects[0].FK_MMBatchProductID).ToList();
                }
                if (listShipmentItem != null && listShipmentItem.Count > 0)
                {
                    MessageBox.Show(BatchReceiptDryLumberLocalizedResources.ChooseMultiBatchProduct,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromBatchLumber();
                }
                else
                {
                    objShipmentsInfo = (ICShipmentsInfo)objShipmentController.GetObjectByID(guiShipmentItem.SelectedObjects[0].FK_ICShipmentID);
                    if (objShipmentsInfo != null)
                    {
                        objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(objShipmentsInfo.FK_MMBatchProductID);
                        int stockID = objReceiptsInfo.FK_ICStockID;
                        BOSUtil.CopyObject(objShipmentsInfo, objReceiptsInfo);
                        objReceiptsInfo.ICReceiptPackNo = BOSCommon.Constants.App.DefaultPackNo;
                        objReceiptsInfo.ICReceiptNo = "***NEW***";
                        objReceiptsInfo.FK_ICStockID = stockID;
                        objReceiptsInfo.ICReceiptStatus = oldReceipts.ICReceiptStatus;
                        objReceiptsInfo.FK_ICProductAttributeWoodTypeID = objShipmentsInfo.FK_ICProductAttributeWoodTypeID;
                        objReceiptsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                        objReceiptsInfo.FK_MMBatchProductID = objBatchProductsInfo.MMBatchProductID;
                        objReceiptsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                        objReceiptsInfo.FK_GECountryID = objShipmentsInfo.FK_GECountryID;
                        objReceiptsInfo.ICReceiptContainerNo = objShipmentsInfo.ICShipmentContainerNo;
                        DisplayLabelText(objReceiptsInfo);
                        CurrentModuleEntity.UpdateMainObjectBindingSource();
                    }
                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objReceiptsInfo.FK_MMOperationID);
                    foreach (ICShipmentItemsInfo item in guiShipmentItem.SelectedObjects)
                    {
                        GetSelectedItemFromBatchShipmentFreshLumber(item, objOperationsInfo);
                    }
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                }
            }
            else ActionCancel();

        }
        public void GetSelectedItemFromBatchShipmentFreshLumber(ICShipmentItemsInfo objShipmentItemsInfo, MMOperationsInfo objOperationsInfo)
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15222);
            //ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //ICProductSeriesInfo objProductSeriesInfo;
            if (objShipmentItemsInfo != null)
            {
                ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                objReceiptItemsInfo.FK_ICProductID = objShipmentItemsInfo.FK_ICProductID;
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objReceiptItemsInfo.ICReceiptItemProductDesc = objProductsInfo.ICProductDesc;
                    //hạt code
                    objReceiptItemsInfo.ICReceiptItemProductType = ReceiptProductType.DryLumber.ToString();
                }

                BOSUtil.CopyObject(objShipmentItemsInfo, objReceiptItemsInfo);
                //uthv phong truong hop cam nham du lieu
                objReceiptItemsInfo.FK_ICReceiptID = 0;
                if (objOperationsInfo != null)
                {
                    if (objOperationsInfo.MMOperationNo == OperationNo.Saygiacong)
                    {
                        objReceiptItemsInfo.ICReceiptItemProductUnitCost = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                    }
                }
                objReceiptItemsInfo.FK_ICStockID = objReceiptInfo.FK_ICStockID;
                objReceiptItemsInfo.ICReceiptItemProductName = objShipmentItemsInfo.ICShipmentItemProductName;
                objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID;
                objReceiptItemsInfo.FK_ICProductAttributeTTMTID = objShipmentItemsInfo.FK_ICProductAttributeTTMTID;
                objReceiptItemsInfo.FK_GECountryID = objShipmentItemsInfo.FK_GECountryID;
                objReceiptItemsInfo.FK_ICProductAttributeQualityID = objShipmentItemsInfo.FK_ICProductAttributeQualityID;
                objReceiptItemsInfo.ICReceiptItemProductLength = objShipmentItemsInfo.ICShipmentItemLength;
                objReceiptItemsInfo.ICReceiptItemProductPerimeter = objShipmentItemsInfo.ICShipmentItemPerimeter;
                objReceiptItemsInfo.ICReceiptItemLotNo = objShipmentItemsInfo.ICShipmentItemLotNo;
                objReceiptItemsInfo.ICReceiptItemWoodQty = objShipmentItemsInfo.ICShipmentItemWoodQty;
                objReceiptItemsInfo.ICReceiptItemLogListNo = objShipmentItemsInfo.ICShipmentItemLoglist;
                objReceiptItemsInfo.ICReceiptItemContainerNo = objShipmentItemsInfo.ICShipmentItemContainerNo;
                objReceiptItemsInfo.FK_MMBatchProductID = objShipmentItemsInfo.FK_MMBatchProductID;
                //tao serie moi
                //objReceiptItemsInfo.FK_ICProductSerieID = objShipmentItemsInfo.FK_ICProductSerieID;
                objReceiptItemsInfo.FK_ICProductSerieID = 0;
                objReceiptItemsInfo.FK_MMOperationID = objShipmentItemsInfo.FK_MMOperationID;
                objReceiptItemsInfo.FK_ICShipmentID = objShipmentItemsInfo.FK_ICShipmentID;
                objReceiptItemsInfo.FK_ICShipmentItemID = objShipmentItemsInfo.Id;
                //objReceiptItemsInfo.ICReceiptItemProductSerialNo = objShipmentItemsInfo.ICShipmentItemProductSerialNo;
                objReceiptItemsInfo.ICReceiptItemProductSerialNo = objShipmentItemsInfo.ICShipmentItemProductSerialNo + ".1.1";
                objReceiptItemsInfo.ICReceiptItemProductWidth = objShipmentItemsInfo.ICShipmentItemWidth;
                objReceiptItemsInfo.ICReceiptItemProductHeight = objShipmentItemsInfo.ICShipmentItemHeight;
                objReceiptItemsInfo.ICReceiptItemLenghtMax = objShipmentItemsInfo.ICShipmentItemLengthMax;
                objReceiptItemsInfo.ICReceiptItemWidthMin = objShipmentItemsInfo.ICShipmentItemWidthMin;
                objReceiptItemsInfo.ICReceiptItemLenghtMin = objShipmentItemsInfo.ICShipmentItemLengthMin;
                //NNGiang   Round Qty 19-05-2016 Start
                objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(objShipmentItemsInfo.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
                //NNGiang   Round Qty 19-05-2016 End
                //Hard ACCount
                //if (objReceiptItemsInfo.FK_ACAccountID == 0 && objProductsInfo != null)
                //{
                //    objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                //}
                if (objAccountsInfo != null)
                {
                    objReceiptItemsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                }
                entity.SetProductPriceByProductUnitPrice(objReceiptItemsInfo);

                entity.ReceiptItemsList.Add(objReceiptItemsInfo);
            }
        }

        public void AddItemToReceiptItemsList()
        {
            int idproduct = int.Parse(ProductEditControl.EditValue.ToString());
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;

            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ModuleObjects[TableName.ICReceiptItemsTableName];
            //if (objReceiptItemsInfo.FK_ICProductID > 0)
            //{
            //    ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            //    ICProductsController objProductsController = new ICProductsController();
            //    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
            //    if (objProductsInfo != null)
            //    {
            //        entity.SetValuesAfterValidateProduct(objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo);
            //        objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
            //        objReceiptItemsInfo.ICReceiptItemProductLength = objProductsInfo.ICProductLength;
            //        objReceiptItemsInfo.ICReceiptItemProductHeight = objProductsInfo.ICProductHeight;
            //        objReceiptItemsInfo.ICReceiptItemProductWidth = objProductsInfo.ICProductWidth;
            //        objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemProductLength * objReceiptItemsInfo.ICReceiptItemProductPerimeter *
            //                                                        objReceiptItemsInfo.ICReceiptItemWoodQty;
            //    }
            //    if (objReceiptsInfo != null)
            //    {
            //        objReceiptItemsInfo.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
            //        objReceiptItemsInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
            //        //objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
            //    }
            //    entity.ReceiptItemsList.AddObjectToList();
            //    entity.ReceiptItemsList.GridControl.RefreshDataSource();
            //}
            if (idproduct > 0)
            {
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(idproduct);
                ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
                ACAccountsController objAccountsController = new ACAccountsController();
                objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15222);
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(idproduct, objReceiptItemsInfo);
                    objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objReceiptItemsInfo.ICReceiptItemProductLength = objProductsInfo.ICProductLength;
                    objReceiptItemsInfo.ICReceiptItemProductHeight = objProductsInfo.ICProductHeight;
                    objReceiptItemsInfo.ICReceiptItemProductWidth = objProductsInfo.ICProductWidth;
                    objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemProductLength * objReceiptItemsInfo.ICReceiptItemProductPerimeter *
                                                                    objReceiptItemsInfo.ICReceiptItemWoodQty;
                    // objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;

                }
                if (objAccountsInfo != null)
                    objReceiptItemsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                if (objReceiptsInfo != null)
                {
                    objReceiptItemsInfo.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
                    objReceiptItemsInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
                    //objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                }
                entity.ReceiptItemsList.AddObjectToList();
                UpdateDocumentEntries();
                entity.ReceiptItemsList.GridControl.RefreshDataSource();
            }
        }
        public void UpdateTotalCost()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
                entity.UpdateTotalCost();
                UpdateInventoryCost();
                UpdateDocumentEntries();
            }
        }
        private void UpdateInventoryCost()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            decimal extCost = entity.ReceiptItemsList.Sum(i => i.ICReceiptItemExtCost);
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
            {
                item.ICReceiptItemInventoryCost = item.ICReceiptItemProductUnitCost;
            }
        }
        public void DeleteItemFromReceiptItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
                entity.ReceiptItemsList.RemoveSelectedRowObjectFromList();
                UpdateTotalCost();
            }
        }
        public string GetConfigTextByGroupAndValue(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public override int ActionSave()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            entity.ReceiptItemsList.EndCurrentEdit();
            UpdateTotalCost();
            ICReceiptsInfo receipt = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            receipt.ICReceiptTypeCombo = ReceiptType.ReceiptHeat.ToString();
            CheckPackNo(receipt);
            //NN Giang ADD -[CHECK QTY IN SHIPMENT ITEM] - Start-14-04-2016
            if (!CheckQtyInShipmentItem(entity.ReceiptItemsList))
            {
                return 0;
            }
            //NN Giang ADD -[CHECK QTY IN SHIPMENT ITEM] - End-14-04-2016
            int receiptID = base.ActionSave();
            return receiptID;
        }


        public void ApproveBatchReceiptHeat()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
                //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                //objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                foreach (ICReceiptItemsInfo objReceiptItemsInfo in entity.ReceiptItemsList)
                {
                    if (string.IsNullOrEmpty(objReceiptItemsInfo.ICReceiptItemProductSerialNo))
                    {
                        MessageBox.Show(string.Format(BatchReceiptDryLumberLocalizedResources.ItemSerieNoIsRequiredMessage, objReceiptItemsInfo.ICReceiptItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrEmpty(objReceiptItemsInfo.FK_ICProductSerieID.ToString()))
                    {
                        MessageBox.Show(string.Format(BatchReceiptDryLumberLocalizedResources.ItemPackNoIsRequiredMessage, objReceiptItemsInfo.ICReceiptItemProductName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Check unitcost receiptItem and InventoryStock, Start
                    /*Kiểm tra đơn giá nhập và đơn giá tồn kho*/
                    decimal unitcost = objInventoryStocksController.GetInventoryStockUnitCost(objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo.ICReceiptItemProductSerialNo);
                    if (unitcost >= 0)//unitCost < 0 là chưa có đơn gía tồn kho
                    {
                        if (Math.Round(unitcost, 0) != objReceiptItemsInfo.ICReceiptItemProductUnitCost)
                        {
                            MessageBox.Show(string.Format(BatchReceiptDryLumberLocalizedResources.UnitCostInventoryStock, objReceiptItemsInfo.ICReceiptItemProductName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //Check unitcost receiptItem and InventoryStock, End
                }
                //if (!CheckExistSerialNo())
                //{
                //    return;
                //}

                //TNDLoc [ADD][10/08/2016][Tồn kho tối đa, tối thiểu],START
                /* Nếu nhiều hơn tồn kho tối đa thì không cho nhập kho */
                if (entity.ReceiptItemsList.IsInvalidInventoryStockMax(TransactionUtil.cstInventoryReceipt))
                {
                    return;
                }
                //TNDLoc [ADD][10/08/2016][Tồn kho tối đa, tối thiểu],END

                ActionComplete();
                //entity.UpdateMainObject();
                //entity.ApprovedReceipt();
                //entity.UpdateMainObjectBindingSource();
                //ModuleAfterCompleted();
                //EnableControl(false);
            }
        }
        public void EnableControl(bool visible)
        {
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, visible);
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchReceiptHeat", visible);
        }
        public void ChangeItemSerieNo(ICReceiptItemsInfo item)
        {
            InvalidateItemSerieNo(item, TableName.ICReceiptItemsTableName, "ICReceiptItemProductSerialNo");
            if (BOSApp.CurrentCompanyInfo.CSCostMethod == AccCostMethod.SpecificIdentification.ToString())
            {

                item.ICReceiptItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICProductID, item.FK_ICProductSerieID);
                BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;

                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                int stockid = item.FK_ICStockID;
                if (objProductSeriesInfo != null)
                {
                    BOSUtil.CopyObject(objProductSeriesInfo, item);
                    item.FK_ICStockID = stockid;
                    item.ICProductSerieNo = objProductSeriesInfo.ICProductSerieNo;
                    item.ICReceiptItemProductLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ICReceiptItemProductPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    item.ICReceiptItemContainerNo = objProductSeriesInfo.ICProductSerieContainerNo;
                    item.ICReceiptItemProductHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                    item.ICReceiptItemProductWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    item.ICReceiptItemWidthMax = objProductSeriesInfo.ICProductSerieProductWidthMax;
                    item.ICReceiptItemWoodQty = objProductSeriesInfo.ICProductSerieWoodQty;
                    item.ICReceiptItemLotNo = objProductSeriesInfo.ICProductSerieLotNo;

                    //item.
                    item.ICReceiptItemProductQty = Math.Round(objInventoryStocksController.GetICShipment_ICInventoryStockQuantity(objProductSeriesInfo.ICProductSerieID, item.FK_ICStockID, objProductSeriesInfo.FK_ICProductID), 4, MidpointRounding.AwayFromZero);
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                }
                if (objReceiptsInfo != null)
                {
                    item.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
                    item.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
                }
                entity.SetProductCostByProductUnitCost(item);
                entity.ReceiptItemsList.GridControl.RefreshDataSource();
                UpdateTotalCost();
            }
        }
        public void ChangeItemFromReceiptItemsList()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            entity.SetProductCostByProductUnitCost();
            entity.ReceiptItemsList.ChangeObjectFromList();


            UpdateTotalCost();
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
        public void ChangeStock(int stockID)
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            objReceiptsInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ReceiptItemsList.Count > 0)
                {
                    if (MessageBox.Show(BatchReceiptDryLumberLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                        {
                            item.FK_ICStockID = stockID;
                        }


                        entity.ReceiptItemsList.GridControl.RefreshDataSource();
                    }
                }
            }
        }
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchReceiptHeat.BatchReceiptHeatModule.PrintReceipt(Toolbar.CurrentObjectID);
            }
        }
        public static void PrintReceipt(int receiptID)
        {
            RP_ReceiptForLumber report = new RP_ReceiptForLumber();
            //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
            InitReceiptReport(report, receiptID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }
        private static void InitReceiptReport(XtraReport report, int receiptID)
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

            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptsInfo receipt = (ICReceiptsInfo)objReceiptsController.GetObjectByID(receiptID);
            #region Hạch Toán
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (receipt != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentsInfo document = null;
                if (receipt.ICReceiptTypeCombo == ReceiptType.ReceiptHeat.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapKhoLoSay.ToString(), receipt.ICReceiptNo);
                }
                //else if (receipt.ICReceiptTypeCombo == ReceiptType.PurchaseReceipt.ToString())
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
                    if (!debitAccountNo.Contains(entry.ACDocumentDebitAccount))
                    {
                        debitAccountNo += string.Format(" {0},", entry.ACDocumentDebitAccount);
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
                accLabel.Text = receipt.ICReceiptDate.ToString("dd/MM/yyyy");
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel29"];
            if (accLabel != null)
            {
                accLabel.Text = receipt.ICReceiptDate.ToString("dd/MM/yyyy");
            }
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrPageInfo2"];
            //if (accLabel != null)
            //{
            //    string str = DateTime.Now.ToString().Trim();
            //    str = str.Substring(0, 2);
            //    accLabel.Text = str;
            //}
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrPageInfo3"];
            //if (accLabel != null)
            //{
            //    string str = DateTime.Now.ToString().Trim();
            //    str = str.Substring(3, 2);
            //    accLabel.Text = str;
            //}
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrPageInfo4"];
            //if (accLabel != null)
            //{
            //    string str = DateTime.Now.ToString().Trim();
            //    str = str.Substring(6, 4);
            //    accLabel.Text = str;
            //}
            //GECurrenciesController objCurrenciesController = new GECurrenciesController();
            //GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(receipt.FK_GECurrencyID);
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel27"];
            //if (accLabel != null)
            //{
            //    accLabel.Text = ConvertAmountToWord.ReadAmount(receipt.ICReceiptTotalCost.ToString(), currency.GECurrencyID);
            //}



            ADReportsController objReportsController = new ADReportsController();
            decimal Tongsoluong = 0;
            foreach (ICReceiptItemsInfo item in objReportsController.GetListReceiptItemByReceiptID(receiptID))
            {
                if (item != null)
                {
                    item.ICReceiptItemWoodQty = Math.Round(item.ICReceiptItemWoodQty, 0);
                    Tongsoluong += item.ICReceiptItemWoodQty;
                }
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel31"];
            if (accLabel != null)
            {
                accLabel.Text = Tongsoluong.ToString();
            }
            report.DataSource = objReportsController.GetListReceiptItemByReceiptID(receiptID);
            //report.DataMember = BOSCommon.Constants.Report.DevReceiptItemReportName;
        }
        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string documentType = AccDocumentType.NhapKhoLoSay.ToString();
            string entryType = AccEntryType.NhapKhoLoSay.ToString();

            if (objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.ReceiptHeat.ToString())
            {
                documentType = AccDocumentType.NhapKhoLoSay.ToString();
                entryType = AccEntryType.NhapKhoLoSay.ToString();
            }
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>>();
            List<int> productAccountID = new List<int>();

            if (entity.ReceiptItemsList != null)
            {
                foreach (ICReceiptItemsInfo receiptItem in entity.ReceiptItemsList)
                {
                    //ICProductsInfo product = productController.GetObjectByID(receiptItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACDebitAccountID == receiptItem.FK_ACAccountID);
                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                        entry.FK_ACDebitAccountID = receiptItem.FK_ACAccountID;
                    }
                    if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                    {
                        documentEntryAccounts.Add(entry, new List<ICReceiptItemsInfo>());
                        productAccountID.Add(entry.FK_ACDebitAccountID);
                    }
                    if (entry != null)
                        documentEntryAccounts[entry].Add(receiptItem);
                }
            }

            //update document entry amount
            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICReceiptItemInventoryCost * i.ICReceiptItemProductQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objReceiptsInfo.FK_GECurrencyID);
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

            //remove the redundance document entries 
            List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACDebitAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }

            //ReceiptEntities entity = (ReceiptEntities)CurrentModuleEntity;
            //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            //foreach (var item in entity.DocumentEntryList)
            //{
            //    item.ACDocumentEntryAmount = 0;
            //    item.ACDocumentEntryExchangeAmount = 0;
            //}
            //foreach (var item in entity.ReceiptItemsList)
            //{
            //    ICProductsController obj = new ICProductsController();
            //    ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
            //    if (objProductsInfo != null)
            //    UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty, entity, objReceiptsInfo.ICReceiptExchangeRate);
            //}

            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        //protected override void UpdateDocumentEntries()
        //{
        //    BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
        //    ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
        //    foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
        //    {
        //        if (entry.ACEntryTypeName == AccEntryType.NhapKhoDieuChinh.ToString() ||
        //            entry.ACEntryTypeName == AccEntryType.NhapKhoMuaHang.ToString() ||
        //            entry.ACEntryTypeName == AccEntryType.NhapKhoHangTra.ToString() ||
        //            entry.ACEntryTypeName == AccEntryType.NhapKhoNVL.ToString())
        //        {
        //            entry.ACDocumentEntryAmount = entity.ReceiptItemsList.Sum(i => i.ICReceiptItemInventoryCost * i.ICReceiptItemProductQty);
        //            entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
        //        }
        //    }
        //    entity.DocumentEntryList.GridControl.RefreshDataSource();
        //    foreach (var item in entity.ReceiptItemsList)
        //    {
        //        ICProductsController obj = new ICProductsController();
        //        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);

        //        //[NNThinh] [ADD] [16/04/2014] [ACAccountID of product for batch Receipt, will change soon ], START
        //        ACAccountsController objAccountsController = new ACAccountsController();
        //        ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc152);

        //        //if (objAccountsInfo != null)
        //        //    UpdateDocumentEntryList(objAccountsInfo.ACAccountID, item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty, entity, objReceiptsInfo.ICReceiptExchangeRate);
        //        //[NNThinh] [ADD] [16/04/2014] [ACAccountID of product for batch Receipt, will change soon ], END
        //    }

        //}
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();

            ICReceiptsInfo receipt = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchReceiptHeat", false);
            if (receipt.ICReceiptStatus == ReceiptStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchReceiptHeat", false);
                //ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                //EnableControl(true);
            }
            //else if (receipt.ICReceiptStatus == ReceiptStatus.New.ToString())
            //{

            //}
            //if (Toolbar.IsNullOrNoneAction() && receipt.ICReceiptStatus == ReceiptStatus.New.ToString())
            if (receipt.ICReceiptStatus == ReceiptStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchReceiptHeat", true);
            }
            //EnableControl(false);
        }
        public void ChangePackNo()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ReceiptItemsList.Count > 0)
                {
                    if (MessageBox.Show(WoodPurchaseReceiptLocalizedResources.ConfirmChangeItemLotNoMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                        {
                            item.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                        }
                        entity.ReceiptItemsList.GridControl.RefreshDataSource();
                    }
                }
            }
        }
        #endregion
    }


}


