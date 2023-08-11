using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using BOSCommon;
using BOSLib;
using System.Data;
using System.Windows.Forms;
using Localization;
using BOSReport;
using DevExpress.XtraReports.UI;
using BOSERP.Modules.IC.BatchReceiptRoundWood.Localization;

namespace BOSERP.Modules.BatchShipmentRoundWood
{

    #region BatchShipmentRoundWood
    public class BatchShipmentRoundWoodModule : BaseTransactionModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItem1s";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string ButtonShowInventoryStock = "fld_btnShowInventoryStock";
        #endregion
        #region Private Properties
        BOSComponent.BOSButton InventoryStock;
        #endregion
        public BatchShipmentRoundWoodModule()
        {
            Name = "BatchShipmentRoundWood";
            CurrentModuleEntity = new BatchShipmentRoundWoodEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            InventoryStock = (BOSComponent.BOSButton)Controls[BatchShipmentRoundWoodModule.ButtonShowInventoryStock];

        }
        public override void ActionEdit()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                InventoryStock.Visible = true;
                base.ActionEdit();
            }
        }
        public void AddItemToShipmentItemsList()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            if (objShipmentItemsInfo.FK_ICProductID > 0)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                if (objShipmentsInfo != null)
                {
                    objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                    objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                }
                objShipmentItemsInfo.ICShipmentItemWoodQty = 1;
                entity.ShipmentItemList.AddObjectToList();
                //entity.ShipmentItemList.Add(objShipmentItemsInfo);
                entity.ShipmentItemList.GridControl.RefreshDataSource();

            }
        }
        //// change ICproductSeries
        //public void ChangeItemlist(ICShipmentItemsInfo item)
        //{
        //    BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
        //    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
        //    ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
        //    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
        //    if (objProductSeriesInfo != null)
        //    {
        //       // UpdateProductQty();
        //        BOSUtil.CopyObject(objProductSeriesInfo,item);
        //        item.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
        //        item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
        //        item.ICShipmentItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
        //        item.ICShipmentItemProductQty = item.ICShipmentItemWoodQty * item.ICShipmentItemLength * item.ICShipmentItemPerimeter;
        //       // ShipmentItemList.ChangeObjectFromList();
        //        entity.ShipmentItemList.GridControl.RefreshDataSource();
        //        //UpdateProductQty();           
        //    }
        //    if (objShipmentsInfo != null)
        //    {
        //        item.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
        //        item.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
        //    }
        //   // entity.ShipmentItemList.ChangeObjectFromList();
        //   // UpdateProductQty();

        //}
        // change item
        public void ChangeItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;

                entity.SetProductPriceByProductUnitPrice();
                // UpdateProductQty();
                entity.ShipmentItemList.ChangeObjectFromList();

                UpdateTotalAmount();
                // UpdateProductQty();
            }
        }
        public void SelectSeriesNoDefault()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void UpdateProductQty()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                entity.UpdateProductQty();
            }
        }

        public void ActionNewFromWoodPurchaseReceipt()
        {
            ActionNew();
            ShowWoodPurchaseReceipt();
        }
        public void ActionNewFromAllocationProposal()
        {
            ActionNew();
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            MMAllocationProposalsController objAllocationProposalsController = new MMAllocationProposalsController();
            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsCheck = new List<MMAllocationProposalItemsInfo>();
            List<MMAllocationProposalItemsInfo> allocationProposalItemsList = objAllocationProposalItemsController.GetNewProposalFromRoundwood(AllocationProposalProductType.RoundWood.ToString());
            guiFind<MMAllocationProposalItemsInfo> guiFind = new guiFind<MMAllocationProposalItemsInfo>(TableName.MMAllocationProposalItemsTableName
                                                                                                        , allocationProposalItemsList
                                                                                                        , this
                                                                                                        , true
                                                                                                        , true
                                                                                                        , new string[] { "MMBatchProductNo", "MMAllocationProposalNo" });
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                //ChangeAllocationProposalProductType(MMAllocationProposalType);
                List<MMAllocationProposalItemsInfo> AllocationProposalItemsList = (List<MMAllocationProposalItemsInfo>)guiFind.SelectedObjects;

                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    objAllocationProposalItemsCheck = (List<MMAllocationProposalItemsInfo>)AllocationProposalItemsList.Where(x => x.FK_MMAllocationProposalID != guiFind.SelectedObjects[0].FK_MMAllocationProposalID).ToList();
                }
                if (objAllocationProposalItemsCheck != null && objAllocationProposalItemsCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(BatchShipmentRoundWoodLocalizedResources.ChooseMultiAllocationProposal), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromAllocationProposal();
                }
                else
                {
                    //MMAllocationProposalsInfo objAllocationProposalsInfo = (MMAllocationProposalsInfo)objAllocationProposalsController.GetObjectByID(guiFind.SelectedObjects[0].FK_MMAllocationProposalID);
                    //if (objAllocationProposalsInfo != null)
                    //{
                    //    objShipmentInfo.FK_MMBatchProductID = objAllocationProposalsInfo.FK_MMBatchProductID;
                    //    objShipmentInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;
                    //    objShipmentInfo.FK_ICProductAttributeTTMTID = objAllocationProposalsInfo.FK_ICProductAttributeTTMTID;
                    //    entity.UpdateMainObjectBindingSource();
                    //}
                    if (AllocationProposalItemsList != null && AllocationProposalItemsList.Count != 0)
                    {
                        MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = AllocationProposalItemsList[0];
                        if (objAllocationProposalItemsInfo != null)
                        {
                            objShipmentInfo.FK_MMBatchProductID = objAllocationProposalItemsInfo.FK_MMBatchProductIDInAllocation;
                            objShipmentInfo.FK_MMOperationID = objAllocationProposalItemsInfo.FK_MMOperationIDInAllocation;
                            objShipmentInfo.FK_ICProductAttributeTTMTID = objAllocationProposalItemsInfo.FK_ICProductAttributeTTMTIDInAllocation;
                            //TKChinh Add PO No
                            MMAllocationProposalsInfo objAllocationProposalsInfo = (MMAllocationProposalsInfo)objAllocationProposalsController.GetObjectByID(objAllocationProposalItemsInfo.FK_MMAllocationProposalID);
                            if (objAllocationProposalsInfo != null)
                            {
                                objShipmentInfo.ICShipmentPONo = objAllocationProposalsInfo.MMAllocationProposalPONo;
                            }
                            entity.UpdateMainObjectBindingSource();
                        }


                        foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            //if (objProductsInfo != null)
                            //    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            //objShipmentItemsInfo.ICShipmentItemProductUnitPrice = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.FK_ICProductSerieID);
                            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICInventoryStockUnitCost;
                            objShipmentItemsInfo.ICShipmentItemProductQty = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty - item.MMAllocationProposalItemCanceledQty;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(objShipmentItemsInfo.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
                            objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                            //objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationProposalItemWoodQty;
                            objShipmentItemsInfo.ICShipmentItemWoodQty = 1;
                            objShipmentItemsInfo.ICShipmentItemPerimeter = item.MMAllocationProposalItemProductPerimeter;
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
                            objShipmentItemsInfo.ICShipmentItemLength = item.MMAllocationProposalItemLength;

                            entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
                    UpdateTotalAmount();
                }
            }
            else
                ActionCancel();
        }
        public void ActionNewFromReceipRoundWood()
        {
            ActionNew();
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICProductsController objProductsController = new ICProductsController();
            List<ICReceiptItemsInfo> objReceiptItemsInfoCheck = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> receiptItemsList = objReceiptItemsController.GetNewICReceiptItems(ReceiptReceiptType.Roundwood.ToString(), ReceiptType.SubRoundWood.ToString());
            guiFind<ICReceiptItemsInfo> guiFind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName
                                                                                  , receiptItemsList
                                                                                  , this
                                                                                  , true
                                                                                  , true
                                                                                  , new string[] { "MMBatchProductNo", "ICReceiptNo" });
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<ICReceiptItemsInfo> ReceiptItemsList = (List<ICReceiptItemsInfo>)guiFind.SelectedObjects;

                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    objReceiptItemsInfoCheck = (List<ICReceiptItemsInfo>)ReceiptItemsList.Where(x => x.FK_MMBatchProductID != guiFind.SelectedObjects[0].FK_MMBatchProductID).ToList();
                }
                if (objReceiptItemsInfoCheck != null && objReceiptItemsInfoCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(BatchShipmentRoundWoodLocalizedResources.ChooseMultiBatchProducts), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromReceipRoundWood();
                }
                else
                {
                    if (ReceiptItemsList != null && ReceiptItemsList.Count != 0)
                    {
                        ICReceiptItemsInfo objReceiptItemsInfo = ReceiptItemsList[0];
                        //if (objReceiptsInfo != null)
                        //{
                        //    //objShipmentInfo.ACObjectAccessKey = objReceiptsInfo.FK_ACObjectID.ToString()+";"+objReceiptsInfo.ICObjectType;
                        //    objShipmentInfo.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
                        //    objShipmentInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
                        //    objShipmentInfo.FK_ICProductAttributeTTMTID = objReceiptsInfo.FK_ICProductAttributeTTMTID;
                        //    objShipmentInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
                        //    objShipmentInfo.FK_ACSegmentID = objReceiptsInfo.FK_ACSegmentID;
                        //}
                        //objShipmentInfo.ACObjectAccessKey = objReceiptsInfo.FK_ACObjectID.ToString()+";"+objReceiptsInfo.ICObjectType;
                        objShipmentInfo.FK_MMBatchProductID = objReceiptItemsInfo.FK_MMBatchProductIDInReceipt;
                        objShipmentInfo.FK_MMOperationID = objReceiptItemsInfo.FK_MMOperationIDInReceipt;
                        objShipmentInfo.FK_ICProductAttributeTTMTID = objReceiptItemsInfo.FK_ICProductAttributeTTMTIDInReceipt;
                        objShipmentInfo.FK_ICStockID = objReceiptItemsInfo.FK_ICStockIDInReceipt;
                        objShipmentInfo.FK_ACSegmentID = objReceiptItemsInfo.FK_ACSegmentID;
                        foreach (ICReceiptItemsInfo item in ReceiptItemsList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (item.FK_ACAccountID == 0)
                            {
                                objShipmentItemsInfo.FK_ACAccountID = item.FK_ACAccountIDInProduct;
                            }
                            objShipmentItemsInfo.ICShipmentItemPerimeter = item.ICReceiptItemProductPerimeter;
                            //objShipmentItemsInfo.ICShipmentItemWoodQty = item.ICReceiptItemWoodQty;
                            objShipmentItemsInfo.ICShipmentItemWoodQty = 1;
                            //TNDLoc [ADD][09/03/2016][Save references ID],START
                            objShipmentItemsInfo.FK_ICReceiptItemID = item.ICReceiptItemID;
                            //TNDLoc [ADD][09/03/2016][Save references ID],END   
                            objShipmentItemsInfo.ICShipmentItemWidth = item.ICReceiptItemProductWidth;
                            objShipmentItemsInfo.ICShipmentItemHeight = item.ICReceiptItemProductHeight;
                            objShipmentItemsInfo.ICShipmentItemLength = item.ICReceiptItemProductLength;
                            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICReceiptItemProductUnitCost;
                            objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICReceiptItemTotalCost;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(objShipmentItemsInfo.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
                            entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
                    UpdateTotalAmount();
                }
            }
            else
                ActionCancel();
        }
        public void ShowWoodPurchaseReceipt()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            DateTime fromdate = DateTime.MinValue;
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult == DialogResult.OK)
            {
                fromdate = chooseDate.FromDate;


                receiptItemList = objReceiptItemsController.GetWoodReceiptItemForShipment(fromdate);

                if (receiptItemList != null)
                {
                    guiFind<ICReceiptItemsInfo> guiFind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName,
                                                                                                    receiptItemList,
                                                                                                    this,
                                                                                                    true,
                                                                                                    true,
                                                                                                    new string[] { "ICReceiptNo", "ICReceiptItemContainerNo" },
                                                                                                    new string[] { "ICReceiptItemProductPerimeter" },
                                                                                                    true);
                    guiFind.ShowDialog();
                    if (guiFind.DialogResult == DialogResult.OK)
                    {
                        //Choose first sale order as a template
                        ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(guiFind.SelectedObjects[0].FK_ICReceiptID);
                        if (objReceiptsInfo != null)
                        {
                            objShipmentInfo.FK_ICProductAttributeTTMTID = objReceiptsInfo.FK_ICProductAttributeTTMTID;
                            entity.UpdateMainObjectBindingSource();
                        }
                        List<ICReceiptItemsInfo> selectedReceiptItems = guiFind.SelectedObjects as List<ICReceiptItemsInfo>;
                        if (selectedReceiptItems != null && selectedReceiptItems.Count > 0)
                        {
                            foreach (ICReceiptItemsInfo item in selectedReceiptItems)
                            {
                                GetSelectedItemFromWoodPurchaseReceipt(item);
                            }
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                        //can test lai start
                        //foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                        //{
                        //    UpdateItemCost(item, false);
                        //}

                        UpdateTotalAmount();
                        //can test lai end
                    }
                    else
                        ActionCancel();
                }
            }
            else
                ActionCancel();
        }

        /// <summary>
        /// Get selected batch lumber input from batch lumber
        /// </summary>
        /// <param name="objBatchLumbersInfo"></param>
        public void GetSelectedItemFromWoodPurchaseReceipt(ICReceiptItemsInfo item)
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            if (item != null)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                BOSUtil.CopyObject(item, objShipmentItemsInfo);
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null && item.FK_ACAccountID == 0)
                {
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                objShipmentInfo.ICShipmentContainerNo = item.ICReceiptItemContainerNo;
                objShipmentItemsInfo.ICShipmentItemPerimeter = item.ICReceiptItemProductPerimeter;
                objShipmentItemsInfo.ICShipmentItemLength = item.ICReceiptItemProductLength;
                objShipmentItemsInfo.ICShipmentItemWidth = item.ICReceiptItemProductWidth;
                objShipmentItemsInfo.ICShipmentItemHeight = item.ICReceiptItemProductHeight;
                objShipmentItemsInfo.FK_ICReceiptItemID = item.ICReceiptItemID;
                //objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICReceiptItemProductUnitCost;
                //objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICReceiptItemTotalCost;

                //set product unit price same unit cost of inventory stock
                objShipmentItemsInfo.ICShipmentItemProductUnitCost = item.ICInventoryStockUnitCost;
                objShipmentItemsInfo.ICShipmentItemTotalCost = item.ICInventoryStockUnitCost * item.ICReceiptItemProductQty;
                objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICInventoryStockUnitCost;
                objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICInventoryStockUnitCost * item.ICReceiptItemProductQty;

                objShipmentItemsInfo.ICShipmentItemWoodQty = 1;
                if (item.FK_ICProductSerieID == 0 && item.ICReceiptItemProductSerialNo != string.Empty && item.ICReceiptItemLotNo != string.Empty)
                {
                    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndLotNoAndSerieNo(
                        objShipmentItemsInfo.FK_ICProductID, item.ICReceiptItemLotNo, item.ICReceiptItemProductSerialNo);
                    if (objProductSeriesInfo != null)
                    {
                        objShipmentItemsInfo.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        objShipmentItemsInfo.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                        objShipmentItemsInfo.ICProductSerieNo = objProductSeriesInfo.ICProductSerieNo;
                    }
                }
                objShipmentItemsInfo.ICShipmentItemLoglist = item.ICReceiptItemLogListNo;
                objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(objShipmentItemsInfo.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
                entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                entity.ShipmentItemList.Add(objShipmentItemsInfo);
            }
        }

        ///// <summary>
        ///// Called when the user change the serie no of an item
        ///// </summary>
        ///// <param name="item">Changed item</param>
        //public void UpdateItemCost(ICShipmentItemsInfo item, bool isUppdateBlock)
        //{
        //    item.ICShipmentItemProductUnitPrice = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.FK_ICProductSerieID);
        //    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();

        //    //can test lai start
        //    //ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetProductSerieByStockIDAndProductIDAndSerieID(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo);
        //    ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICShipmentItemProductSerialNo);
        //    //can test lai end

        //    BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
        //    entity.SetProductPriceByProductUnitPrice(item);
        //    if (objProductSeriesInfo != null)
        //    {
        //        item.ICShipmentItemLotNo = objProductSeriesInfo.ICProductSerieLotNo;
        //        if (isUppdateBlock)
        //        {
        //            item.ICShipmentItemProductQty = objProductSeriesInfo.ICProduc;
        //            item.ICShipmentItemProductActualQty = objProductSeriesInfo.ICProductSerieQty;
        //        }
        //    }
        //    UpdateTotalAmount();
        //}

        /// <summary>
        /// Update the total amount of the shipment
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        //delete shipmentitem list
        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateTotalAmount();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            //return base.GetSearchData(ref searchQuery);
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
                                                                   ShipmentType.RoundwoodShipment.ToString(),
                                                                   null,
                                                                   searchObject.ShipmentDateFrom,
                                                                   searchObject.ShipmentDateTo);

            return ds;
        }
        public override int ActionSave()
        {
            //NNGiang ADD - 13-04-2016 Start [Check QTY With RECEIPT QTY]
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            entity.ShipmentItemList.EndCurrentEdit();
            if (string.IsNullOrEmpty(objShipmentsInfo.ICShipmentAcceptanceType))
            {
                MessageBox.Show(BatchReceiptRoundWoodLocalizedResources2.AcceptanceIsRequiredMessage1, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (!CheckQtyInReceiptItem(entity.ShipmentItemList))
            {
                return 0;
            }
            //NNGiang ADD - 13-04-2016 End [Check QTY With RECEIPT QTY]
            return base.ActionSave();

        }
        public override void ActionNew()
        {
            base.ActionNew();
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            if (entity.DocumentEntryList != null)
            {
                entity.DocumentEntryList.OriginalList.Clear();
                entity.DocumentEntryList.Clear();
            }
            InventoryStock.Visible = true;
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            InvalidateToolbar();
        }
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentRoundWood", false);
                InventoryStock.Visible = false;
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentRoundWood", true);
                //InventoryStock.Visible = true;
            }
        }
        public void ApproveBatchShipmentRoundWood()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                // BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                // ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                // objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();

                // entity.UpdateMainObject();
                // //entity.ShipmentItemList.SaveItemObjects();
                // entity.UpdateMainObjectBindingSource();
                // //entity.ShipmentItemList.GridControl.RefreshDataSource();
                // ModuleAfterCompleted();
                //// EnableControl(false);
                // //Toolbar.Cancel();
                // //InvalidateToolbar();         
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                entity.ShipmentItemList.EndCurrentEdit();
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                ICProductSeriesController productSerieController = new ICProductSeriesController();
                ICProductSeriesInfo productSerie = null;
                foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
                {

                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                    if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                    {
                        if (!objShipmentItemsInfo.HasComponent && objShipmentItemsInfo.FK_ICProductSerieID == 0 && objShipmentItemsInfo.ICShipmentItemProductSerialNo != string.Empty)
                        {
                            productSerie = productSerieController.GetSerieByProductIDAndLotNoAndSerieNo(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo.ICShipmentItemLotNo, objShipmentItemsInfo.ICShipmentItemProductSerialNo);
                            if (productSerie != null)
                                objShipmentItemsInfo.FK_ICProductSerieID = productSerie.ICProductSerieID;
                        }
                        if (!objShipmentItemsInfo.HasComponent && objShipmentItemsInfo.FK_ICProductSerieID == 0 && objShipmentItemsInfo.ICShipmentItemProductSerialNo == string.Empty)
                        {
                            MessageBox.Show(string.Format(BatchShipmentRoundWoodLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (entity.ShipmentItemList.IsInvalidInventoryBlock(TransactionUtil.cstInventoryShipment, "ICShipmentItemProductQty"))
                {
                    return;
                }
                if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                {
                    return;
                }

                ActionComplete();

                //entity.ApprovedBatchShipmentRoundwood();
                //ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                //UpdateReceiptItemReference(objShipmentsInfo.ICShipmentID);
                ////Update Reference Allocation Proposal
                ////UpdateAllocationProposalItemReference(objShipmentsInfo.ICShipmentID);

                //ModuleAfterCompleted();
            }
        }

        public void UpdateReceiptItemReference(int shipmentID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            Invalidate(shipmentID);
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                if (item.FK_ICReceiptItemID > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectByID(item.FK_ICReceiptItemID);
                    if (objReceiptItemsInfo != null)
                    {
                        objReceiptItemsInfo.ICReceiptItemIsSplitted = true;
                        objReceiptItemsController.UpdateObject(objReceiptItemsInfo);
                    }
                }
            }
        }

        public void UpdateAllocationProposalItemReference(int shipmentID)
        {
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            Invalidate(shipmentID);
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                if (item.FK_MMAllocationProposalItemID > 0)
                {
                    MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = (MMAllocationProposalItemsInfo)objAllocationProposalItemsController.GetObjectByID(item.FK_MMAllocationProposalItemID);
                    if (objAllocationProposalItemsInfo != null)
                    {
                        //objAllocationProposalItemsInfo.MMAllocationProposalItemShippedQty += item.ICShipmentItemProductQty;
                        //objAllocationProposalItemsInfo.MMAllocationProposalItemShippedWoodQty += item.ICShipmentItemWoodQty;
                        objAllocationProposalItemsController.UpdateObject(objAllocationProposalItemsInfo);
                    }
                }
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
        public void UpdateDocument()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ShipmentItemList.Count > 0)
                {
                    // if (MessageBox.Show(SemiProductShipmentLocalizedResources.ConfirmChangeItemOperationMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                        {
                            item.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                            if (objOperationsInfo != null)
                            {
                                if (objOperationsInfo.MMOperationNo == OperationNo.Cuaxe.ToString() && !objShipmentsInfo.ICShipmentAcceptanceType.Equals(ShipmentAcceptanceType.RoundWoodSplit.ToString()))
                                {
                                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1521);
                                    if (objAccountsInfo != null)
                                    {
                                        item.FK_ACAccountID = objAccountsInfo.ACAccountID;
                                    }
                                }
                            }
                        }
                        entity.ShipmentItemList.GridControl.RefreshDataSource();
                    }
                }
            }
            GenerateAccountingData();
            UpdateDocumentEntries();
        }
        #region Accounting
        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoGoTron.ToString());
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            if (objShipmentsInfo.ICShipmentAcceptanceType == ShipmentAcceptanceType.Acceptance.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoGoTron.ToString());
            }
            else if (objShipmentsInfo.ICShipmentAcceptanceType == ShipmentAcceptanceType.RoundWoodSplit.ToString())
            {
                //Nothing todo
            }
            else
            {
                if (objOperationsInfo != null)
                {
                    if (objOperationsInfo.MMOperationNo == OperationNo.Cuaxe.ToString())
                    {
                        documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoDiCuaXe.ToString());
                    }
                    else
                    {
                        documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoGoTron.ToString());
                    }
                }
            }
            return documentTypeID;
        }

        public override void GenerateAccountingData()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            if (objShipmentsInfo.ICShipmentAcceptanceType == ShipmentAcceptanceType.RoundWoodSplit.ToString())
            {
                //GenerateAccountingData(new string[] { AccDocumentType.XuatKhoGoTron.ToString() });
                //Nothing todo
            }
            else if (objShipmentsInfo.ICShipmentAcceptanceType == ShipmentAcceptanceType.Acceptance.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.XuatKhoGoTron.ToString() });
            }
            else
            {
                if (objOperationsInfo != null)
                {
                    if (objOperationsInfo.MMOperationNo == OperationNo.Cuaxe.ToString())
                    {
                        GenerateAccountingData(new string[] { AccDocumentType.XuatKhoDiCuaXe.ToString() });
                    }
                    else
                    {
                        GenerateAccountingData(new string[] { AccDocumentType.XuatKhoGoTron.ToString() });
                    }
                }
            }



        }

        protected override void UpdateDocumentEntries()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            if (objShipmentsInfo.ICShipmentAcceptanceType.Equals(ShipmentAcceptanceType.Production.ToString()) || string.IsNullOrEmpty(objShipmentsInfo.ICShipmentAcceptanceType))
            {
                if (objShipmentsInfo.FK_MMOperationID > 0)
                {
                    ICProductsController productController = new ICProductsController();
                    ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                    MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                    MMOperationsController objOperationsController = new MMOperationsController();
                    string CD = string.Empty;
                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
                    if (objOperationsInfo != null)
                    {
                        CD = objOperationsInfo.MMOperationNo;
                    }
                    string documentType = AccDocumentType.XuatKhoGoTron.ToString();
                    string entryType = AccEntryType.XuatKhoGoTron.ToString();

                    if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.RoundwoodShipment.ToString())
                    {
                        if (CD == OperationNo.Cuaxe.ToString())
                        {
                            documentType = AccDocumentType.XuatKhoDiCuaXe.ToString();
                            entryType = AccEntryType.XuatKhoDiCuaXe.ToString();
                        }
                        else
                        {
                            documentType = AccDocumentType.XuatKhoGoTron.ToString();
                            entryType = AccEntryType.XuatKhoGoTron.ToString();
                        }
                    }
                    ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                documentType,
                                                                                entryType);
                    Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>>();
                    List<int> productAccountID = new List<int>();

                    if (entity.ShipmentItemList != null)
                    {
                        foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
                        {
                            ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                            entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                            && e.FK_ACCreditAccountID == shipmentItem.FK_ACAccountID);
                            if (entry == null && defaultEntry != null)
                            {
                                entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                                entry.FK_ACCreditAccountID = shipmentItem.FK_ACAccountID;
                            }
                            if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                            {
                                documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                                productAccountID.Add(entry.FK_ACCreditAccountID);
                            }
                            if (entry != null)
                                documentEntryAccounts[entry].Add(shipmentItem);
                        }
                    }

                    //update document entry amount
                    if (documentEntryAccounts.Count != 0)
                    {
                        ACDocumentEntrysInfo item = null;
                        foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                        {
                            entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICShipmentItemProductUnitCost * i.ICShipmentItemProductQty);
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

                    //remove the redundance document entries 
                    List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType
                                                                                      && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
                    if (removedItems != null)
                    {
                        foreach (ACDocumentEntrysInfo item in removedItems)
                            entity.DocumentEntryList.Remove(item);
                    }

                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                }
                else
                {
                    if (!Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                    {
                        entity.DocumentEntryList.Clear();
                        entity.DocumentList.Clear();
                        entity.DocumentEntryList.GridControl.RefreshDataSource();
                    }
                }


            }
            else if (objShipmentsInfo.ICShipmentAcceptanceType == ShipmentAcceptanceType.Acceptance.ToString())
            {

                ICProductsController productController = new ICProductsController();
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                int accountDebit = 0;
                ACAccountsInfo objACAccountsInfo = new ACAccountsInfo();
                ACAccountsController objAccountsController = new ACAccountsController();
                objACAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1384);
                if (objACAccountsInfo != null)
                {
                    accountDebit = objACAccountsInfo.ACAccountID;
                }

                string documentType = AccDocumentType.XuatKhoGoTron.ToString();
                string entryType = AccEntryType.XuatKhoGoTron.ToString();

                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                            documentType,
                                                                            entryType);
                Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>>();
                List<int> productAccountID = new List<int>();

                if (entity.ShipmentItemList != null)
                {
                    foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
                    {
                        ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                        entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACCreditAccountID == shipmentItem.FK_ACAccountID);
                        if (entry != null)
                        {
                            entry.FK_ACDebitAccountID = accountDebit;
                            entry.FK_ACCreditAccountID = shipmentItem.FK_ACAccountID;

                        }
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACDebitAccountID = accountDebit;
                            entry.FK_ACCreditAccountID = shipmentItem.FK_ACAccountID;
                        }
                        if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                        {
                            documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                            productAccountID.Add(entry.FK_ACCreditAccountID);
                        }
                        if (entry != null)
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
                        BOSApp.RoundByCurrency(entry, objShipmentsInfo.FK_GECurrencyID);
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
                                                                                  && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
                if (removedItems != null)
                {
                    foreach (ACDocumentEntrysInfo item in removedItems)
                        entity.DocumentEntryList.Remove(item);
                }

                entity.DocumentEntryList.GridControl.RefreshDataSource();

            }
            else if (objShipmentsInfo.ICShipmentAcceptanceType == ShipmentAcceptanceType.RoundWoodSplit.ToString())
            {
                if (!Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                {
                    entity.DocumentEntryList.Clear();
                    entity.DocumentList.Clear();
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                }
            }
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
        //protected override void UpdateDocumentEntries()
        //{
        //    BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
        //    ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

        //    foreach (var item in entity.DocumentEntryList)
        //    {
        //        item.ACDocumentEntryAmount = 0;
        //        item.ACDocumentEntryExchangeAmount = 0;
        //    }
        //    foreach (var item in entity.ShipmentItemList)
        //    {
        //        ICProductsController obj = new ICProductsController();
        //        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);

        //        //[NNThinh] [ADD] [16/04/2014] [ACAccountID of product for batch shipment, will change soon ], START
        //        ACAccountsController objAccountsController = new ACAccountsController();
        //        ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc152);

        //        if (objAccountsInfo != null)
        //            UpdateDocumentEntryList(objAccountsInfo.ACAccountID, item.ICShipmentItemPrice, entity, 0);
        //        //[NNThinh] [ADD] [16/04/2014] [ACAccountID of product for batch shipment, will change soon ], END
        //    }

        //    entity.DocumentEntryList.GridControl.RefreshDataSource();
        //}
        #endregion


        /// <summary>
        /// Called when the user change the serie no of an item
        /// </summary>
        /// <param name="item">Changed item</param>
        public void ChangeItemSerieNo(ICShipmentItemsInfo item)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {

                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                item.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
                DataGenerator.ChangeValuesShipmentItemsGridFromProductSeries(item);
                BOSApp.RoundByCurrency(item, objShipmentsInfo.FK_GECurrencyID);
                entity.ShipmentItemList.GridControl.RefreshDataSource();

                if (objShipmentsInfo != null)
                {
                    item.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    item.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                }

                UpdateTotalAmount();
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
        }
        public void ChangeItemProductQty(ICShipmentItemsInfo item)
        {
            //item.ICShipmentItemProductQty=item.ICShipmentItemPerimeter*item.ICShipmentItemLength
        }
        public void ChangeItemStorck(int ICStockID)
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                item.FK_ICStockID = ICStockID;
            }
            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            //DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        public void ShownInventoryStocks()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

                ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                //List<ICInventoryStocksInfo> InventoryStocksList = new List<ICInventoryStocksInfo>();
                guiShowInventoryStock guiShowInventoryStock = new guiShowInventoryStock(objShipmentsInfo.ICShipmentTypeCombo);
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
            decimal qty = 0;
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            //ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(SeriesList[0].FK_ICProductID);
            foreach (ICProductSeriesInfo item in SeriesList)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                BOSUtil.CopyObject(item, objShipmentItemsInfo);
                // DataGenerator.SetShipmentItemsfromProductSeries(objShipmentItemsInfo);

                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objShipmentItemsInfo.ICShipmentItemProductDesc = objProductsInfo.ICProductDesc;
                    objShipmentItemsInfo.ICShipmentItemProductName = objProductsInfo.ICProductGroupName;
                    objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                               objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                               objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                    {
                        qty = Math.Round(item.ICInventoryStockQuantity, 4, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        qty = Math.Round(item.ICInventoryStockQuantity, 2, MidpointRounding.AwayFromZero);
                    }
                }
                objShipmentItemsInfo.ICShipmentItemProductSerialNo = item.ICProductSerieNo;
                objShipmentItemsInfo.ICShipmentItemLotNo = item.ICProductSerieLotNo;
                objShipmentItemsInfo.ICShipmentItemProductQty = item.ICInventoryStockQuantity;
                //objShipmentItemsInfo.ICShipmentItemWoodQty = item.ICInventoryStockWoodQuantity;
                objShipmentItemsInfo.ICShipmentItemWoodQty = 1;
                objShipmentItemsInfo.ICShipmentItemPerimeter = item.ICProductSerieProductPerimeter;
                objShipmentItemsInfo.ICShipmentItemPerimeterMax = item.ICProductSerieProductPerimeterMax;
                objShipmentItemsInfo.ICShipmentItemLength = item.ICProductSerieProductLength;
                objShipmentItemsInfo.ICShipmentItemLengthMax = item.ICProductSerieProductLengthMax;
                objShipmentItemsInfo.ICShipmentItemWidth = item.ICProductSerieProductWidth;
                objShipmentItemsInfo.ICShipmentItemWidthMax = item.ICProductSerieProductWidthMax;
                objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICInventoryStockUnitCost;
                objShipmentItemsInfo.ICShipmentItemProductQty = qty;
                objShipmentItemsInfo.ICShipmentItemTotalAmount = (qty * item.ICInventoryStockUnitCost);
                objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                //TNDLoc [ADD][21/01/2016][Copy ProductSerieID],START
                objShipmentItemsInfo.FK_ICProductSerieID = item.ICProductSerieID;
                //TNDLoc [ADD][21/01/2016][Copy ProductSerieID],END
                entity.ShipmentItemList.Add(objShipmentItemsInfo);


            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();

        }
        public void UpdateTTMT(int TTMTID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_ICProductAttributeTTMTID = TTMTID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateOperation(int OperationID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_MMOperationID = OperationID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateBatchProductID(int batchProductID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_MMBatchProductID = batchProductID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchShipmentRoundWood.BatchShipmentRoundWoodModule.PrintShipment(Toolbar.CurrentObjectID);
            }
        }
        public static void PrintShipment(int ShipmentID)
        {
            RP_ShipmentRoundWood report = new RP_ShipmentRoundWood();
            //report.LoadLayout(BOSCommon.Report.DevReceiptItemReportPath);
            InitReceiptReport(report, ShipmentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
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
                if (shipment.ICShipmentTypeCombo == ShipmentType.RoundwoodShipment.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKhoGoTron.ToString(), shipment.ICShipmentNo);
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
            report.DataSource = objReportsController.GetListShipmentItemByShipmentID(ShipmentID);
            //report.DataMember = BOSCommon.Report.DevReceiptItemReportName;
        }
        public void ChangeAcceptanceType(string AcceptanceType)
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentAcceptanceType = AcceptanceType;
            UpdateDocument();
        }


    }
    #endregion
}
