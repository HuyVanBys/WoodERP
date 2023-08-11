using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentProposal
{
    class ShipmentProposalModule : BaseTransactionModule
    {
        #region Constant
        public const string ShipmentProposalItemsGridControlName = "fld_dgcICShipmentProposalItems";
        //public const string ProductItemLookUpEditName = "fld_lkeFK_ICProductID";
        public const string ToolbarButtonApprove = "Approve";
        public const string ToolbarButtonDiscard = "Discard";
        #endregion

        #region
        public BOSLookupEdit ProductItemLookUpEdit;
        public BOSButton ProposalItemButton;
        public ICShipmentProposalItemsGridControl ShipmentProposalItemsGridControl;
        private bool IsEditAfterBrowsing = false;
        #endregion

        #region Constructor
        public ShipmentProposalModule()
        {
            Name = "ShipmentProposal";
            CurrentModuleEntity = new ShipmentProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ShipmentProposalItemsGridControl = (ICShipmentProposalItemsGridControl)Controls[ShipmentProposalItemsGridControlName];
            //ProductItemLookUpEdit = (BOSLookupEdit)Controls[ProductItemLookUpEditName];

            //StartGettingInventoryThread();
        }
        #endregion
        public void AddItemShipmentProposalItemList()
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalItemsInfo objShipmentProposalItemsInfo = (ICShipmentProposalItemsInfo)entity.ModuleObjects[TableName.ICShipmentProposalItemsTableName];

            if (objShipmentProposalItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct((objShipmentProposalItemsInfo.FK_ICProductID));
                entity.ShipmentProposalItemList.AddObjectToList();
            }
        }
        //[NKVung] [Change Item Serie No] [START]
        public void ChangeItemSerieNo(ICShipmentProposalItemsInfo item)
        {
            InvalidateItemSerieNo(item, TableName.ICShipmentProposalItemsTableName, "ICShipmentProposalItemProductSerialNo");
            if (BOSApp.CurrentCompanyInfo.CSCostMethod == AccCostMethod.SpecificIdentification.ToString())
            {
                ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
                ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;

                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICShipmentProposalItemProductSerialNo);
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                int stockid = item.FK_ICStockID;
                if (objProductSeriesInfo != null)
                {
                    string desc = item.ICShipmentProposalItemProductDesc;
                    BOSUtil.CopyObject(objProductSeriesInfo, item);
                    item.FK_ICStockID = stockid;
                    item.ICShipmentProposalItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    item.ICShipmentProposalItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ICShipmentProposalItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    item.ICShipmentProposalItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                    item.ICShipmentProposalItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    item.ICShipmentProposalItemLentghMax = objProductSeriesInfo.ICProductSerieProductLengthMax;
                    item.ICShipmentProposalItemWidthMax = objProductSeriesInfo.ICProductSerieProductWidthMax;
                    item.ICShipmentProposalItemPerimeterMax = objProductSeriesInfo.ICProductSerieProductPerimeterMax;
                    item.ICShipmentProposalItemWoodQty = objProductSeriesInfo.ICProductSerieWoodQty;
                    item.ICShipmentProposalItemLotNo = objProductSeriesInfo.ICProductSerieLotNo;
                    item.ICShipmentProposalItemProductQty = objInventoryStocksController.GetICShipment_ICInventoryStockQuantity(objProductSeriesInfo.ICProductSerieID, item.FK_ICStockID, objProductSeriesInfo.FK_ICProductID);
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        if (objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                        {
                            item.ICShipmentProposalItemProductDesc = desc;
                        }
                        if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                               objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                        {
                            item.ICShipmentProposalItemProductQty = Math.Round(item.ICShipmentProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            item.ICShipmentProposalItemProductQty = Math.Round(item.ICShipmentProposalItemProductQty, 2, MidpointRounding.AwayFromZero);
                        }
                    }
                }
                entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
            }
        }
        //[NKVung]  [END]

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;

            }
        }
        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
                entity.ShipmentProposalItemList.RemoveSelectedRowObjectFromList();
            }
        }

        public List<ARSaleOrderItemsInfo> GetSaleOrderList(List<ARSaleOrderItemsInfo> saleOrderList)
        {
            ARSaleOrderItemsInfo item;
            for (int i = 0; i < saleOrderList.Count; i++)
            {
                item = (ARSaleOrderItemsInfo)saleOrderList[i];
                if (item != null)
                {
                    //if(item.ARSaleOrderProductType == SaleOrderProductType.Hardware.ToString()
                    //   || item.ARSaleOrderProductType == SaleOrderProductType.IngredientPaint.ToString()
                    //    || item.ARSaleOrderProductType == SaleOrderProductType.IngredientPackaging.ToString()
                    //    || item.ARSaleOrderProductType == SaleOrderProductType.SemiProduct.ToString()
                    //    || item.ARSaleOrderProductType == SaleOrderProductType.Other.ToString())
                    //{
                    if (!(item.ARSaleOrderItemRemainedQty > 0))
                    {
                        saleOrderList.RemoveAt(i--);
                    }

                    //}
                    //else
                    //{
                    //     if(!((item.ARSaleOrderItemRemainedQty + item.ARSaleOrderItemTenPercentQty) > 0))
                    //    {
                    //        saleOrderList.RemoveAt(i--);
                    //    }
                    //}

                }


            }

            return saleOrderList;
        }

        public void ActionNewFromSaleOrder()
        {

            ActionNew();
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();

            List<ARSaleOrderItemsInfo> saleOrderItemCheckList = new List<ARSaleOrderItemsInfo>();
            List<ARSaleOrderItemsInfo> saleOrderItemList = objSaleOrderItemsController.GetSaleOrder_ItemsForBatchProduct();
            GetSaleOrderList(saleOrderItemList);
            guiFind<ARSaleOrderItemsInfo> guiFind = new guiFind<ARSaleOrderItemsInfo>(TableName.ARSaleOrderItemsTableName, saleOrderItemList
                                                        , this, true, true
                                                        , new string[] { "ARSaleOrderType", "ARSaleOrderNo" });
            guiFind.ShowDialog();


            if (guiFind.SelectedObjects.Count > 0 || Convert.ToInt32(guiFind.Tag) > 0)
            {
                //Choose first sale order as a template
                List<ARSaleOrderItemsInfo> templateSaleOrderItemList = (List<ARSaleOrderItemsInfo>)guiFind.SelectedObjects;

                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    saleOrderItemCheckList = (List<ARSaleOrderItemsInfo>)templateSaleOrderItemList.Where(x => x.FK_ARSaleOrderID != guiFind.SelectedObjects[0].FK_ARSaleOrderID).ToList();
                }
                if (saleOrderItemCheckList != null && saleOrderItemCheckList.Count > 0)
                {
                    MessageBox.Show(string.Format(ShipmentProposalLocalizedResources.ChooseMulltiSaleOrderMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromSaleOrder();
                }
                else
                {
                    objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(guiFind.SelectedObjects[0].FK_ARSaleOrderID);
                    if (objSaleOrdersInfo != null)
                    {

                        SetDefaultValuesFromCustomer();

                        entity.GenerateEntitiesFromSaleOrder(objSaleOrdersInfo, templateSaleOrderItemList);
                        SetDefaultDesc();
                        DisplayLabelText(objShipmentProposalsInfo);

                        entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
                        if (entity.ShipmentProposalItemList.Count > 0)
                        {
                            entity.ShipmentProposalItemList.GridControl.InvalidateLookupEditColumns();
                            entity.ShipmentProposalItemList.GridViewFocusRow(0);
                        }
                    }
                }
            }
            else
                ActionCancel();
        }

        public void NewFromLoadCont()
        {
            ActionNew();
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ICShipmentProposalsInfo oldShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject.Clone();
            ARContainerLoadersInfo objContainerLoadersInfo = new ARContainerLoadersInfo();
            ARContainerLoadersController objContainerLoadersController = new ARContainerLoadersController();
            ARContainerLoaderItemsController objContainerLoaderItemsController = new ARContainerLoaderItemsController();
            ARContainerLoaderItemsInfo objContainerLoaderItemsInfo = new ARContainerLoaderItemsInfo();
            List<ARContainerLoaderItemsInfo> checkList = new List<ARContainerLoaderItemsInfo>();

            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            List<ARSaleOrderItemsInfo> listSaleOrderItems = new List<ARSaleOrderItemsInfo>();

            List<ARContainerLoaderItemsInfo> ContainerLoaderItemsList = objContainerLoaderItemsController.GetContainerLoaderItemForShipmentproposal();
            guiFind<ARContainerLoaderItemsInfo> guiFind = new guiFind<ARContainerLoaderItemsInfo>(TableName.ARContainerLoaderItemsTableName, ContainerLoaderItemsList
                                                        , this, true, true
                                                        , new string[] { "ARSaleOrderNo", "ARContainerLoaderNo" });
            guiFind.ShowDialog();
            if (guiFind.SelectedObjects.Count > 0 || Convert.ToInt32(guiFind.Tag) > 0)
            {
                List<ARContainerLoaderItemsInfo> List = (List<ARContainerLoaderItemsInfo>)guiFind.SelectedObjects;

                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    checkList = (List<ARContainerLoaderItemsInfo>)List.Where(x => x.FK_ARSaleOrderID != guiFind.SelectedObjects[0].FK_ARSaleOrderID).ToList();
                }
                if (checkList != null && checkList.Count > 0)
                {
                    MessageBox.Show(string.Format("Các container bạn chọn không cùng một SaleOrder(SO)."), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    NewFromLoadCont();
                }
                else
                {
                    objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(guiFind.SelectedObjects[0].FK_ARSaleOrderID);
                    if (objSaleOrdersInfo != null)
                    {

                        SetDefaultValuesFromCustomer();
                        //Set mainObject
                        BOSUtil.CopyObject(objSaleOrdersInfo, objShipmentProposalsInfo);
                        objShipmentProposalsInfo.ICShipmentProposalNo = "***NEW***";
                        objShipmentProposalsInfo.ICShipmentProposalStatus = ShipmentProposalStatus.New.ToString();
                        objShipmentProposalsInfo.FK_HREmployeeID = oldShipmentProposalsInfo.FK_HREmployeeID;
                        objShipmentProposalsInfo.ICShipmentProposalPONo = objSaleOrdersInfo.ARSaleOrderPONo;
                        objShipmentProposalsInfo.ICShipmentProposalReference = objSaleOrdersInfo.ARSaleOrderNo;
                        objShipmentProposalsInfo.FK_MMBatchProductID = objSaleOrdersInfo.FK_MMBatchProductID;

                        if (BOSApp.CurrentCompanyInfo != null)
                            objShipmentProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                    }
                    foreach (ARContainerLoaderItemsInfo item in List)
                    {
                        objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                        if (objSaleOrderItemsInfo != null)
                        {
                            ICProductsController objProductsController = new ICProductsController();
                            ICProductsInfo objProductsInfo = new ICProductsInfo();
                            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();

                            ICShipmentProposalItemsInfo ShipmentProposalItems = new ICShipmentProposalItemsInfo();
                            BOSUtil.CopyObject(objSaleOrderItemsInfo, ShipmentProposalItems);
                            ShipmentProposalItems.FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID;
                            ShipmentProposalItems.FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID;
                            //ShipmentProposalItems.ICShipmentProposalItemProductQty = SaleOrderItemsInfo.ARSaleOrderItemRemainedQty;
                            ShipmentProposalItems.ICShipmentProposalItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName;
                            ShipmentProposalItems.ICShipmentProposalItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc;
                            ShipmentProposalItems.FK_ICProductAttributeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID;
                            ShipmentProposalItems.ICShipmentProposalItemPONo = objSaleOrderItemsInfo.ARSaleOrderItemPONo;

                            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(ShipmentProposalItems.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                ShipmentProposalItems.FK_ICProductAttributeColor = objProductsInfo.FK_ICProductAttributeColorID;
                                ShipmentProposalItems.FK_ICProductAttributePaintType = objProductsInfo.FK_ICProductAttributeFinishingID;
                            }
                            //ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = ShipmentProposalItems.ICShipmentProposalItemProductQty;
                            ShipmentProposalItems.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;
                            ShipmentProposalItems.FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID;
                            ShipmentProposalItems.FK_MMBatchProductID = objSaleOrdersInfo.FK_MMBatchProductID; ;

                            ShipmentProposalItems.ICShipmentProposalItemColorText = objSaleOrderItemsInfo.ARSaleOrderItemColorText;
                            ShipmentProposalItems.ICShipmentProposalItemHTText = objSaleOrderItemsInfo.ARSaleOrderItemHTText;

                            objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetbySaleorderID(objSaleOrderItemsInfo.ARSaleOrderItemID).FirstOrDefault();
                            if (objBatchProductItemsInfo != null)
                            {
                                ShipmentProposalItems.FK_ICProductAttributeID = objBatchProductItemsInfo.FK_ICProductAttributeWoodTypeID;
                                ShipmentProposalItems.ICShipmentProposalItemProductSerialNo = objBatchProductItemsInfo.MMBatchProductItemProductSerial;
                            }
                            if (objProductsInfo != null)
                            {
                                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                                {
                                    ShipmentProposalItems.ICShipmentProposalItemProductQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                                    ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductRemainQty, 4, MidpointRounding.AwayFromZero);
                                }
                                else
                                {
                                    ShipmentProposalItems.ICShipmentProposalItemProductQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductQty, 2, MidpointRounding.AwayFromZero);
                                    ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = Math.Round(ShipmentProposalItems.ICShipmentProposalItemProductRemainQty, 2, MidpointRounding.AwayFromZero);
                                }
                            }

                            ShipmentProposalItems.FK_ARContainerLoaderID = item.FK_ARContainerLoaderID;
                            ShipmentProposalItems.FK_ARContainerLoaderItemID = item.ARContainerLoaderItemID;
                            ShipmentProposalItems.ICShipmentProposalItemProductQty = item.ARContainerLoaderItemRemainQty;
                            ShipmentProposalItems.ICShipmentProposalItemProductRemainQty = ShipmentProposalItems.ICShipmentProposalItemProductQty;

                            entity.ShipmentProposalItemList.Add(ShipmentProposalItems);
                        }

                    }
                    SetDefaultDesc();
                    DisplayLabelText(objShipmentProposalsInfo);

                    entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
                    if (entity.ShipmentProposalItemList.Count > 0)
                    {
                        entity.ShipmentProposalItemList.GridControl.InvalidateLookupEditColumns();
                        entity.ShipmentProposalItemList.GridViewFocusRow(0);
                    }
                }
            }
            else
                ActionCancel();

        }

        public void ShipmentProposalItem(ICShipmentProposalItemsInfo item)
        {
            if (BOSApp.CurrentCompanyInfo.CSCostMethod == AccCostMethod.SpecificIdentification.ToString())
            {
                item.ICShipmentProposalItemProductRemainQty = item.ICShipmentProposalItemProductQty;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                           objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                           objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                    {
                        item.ICShipmentProposalItemProductRemainQty = Math.Round(item.ICShipmentProposalItemProductRemainQty, 4, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        item.ICShipmentProposalItemProductRemainQty = Math.Round(item.ICShipmentProposalItemProductRemainQty, 2, MidpointRounding.AwayFromZero);
                    }
                }
            }
        }
        private void SetDefaultDesc()
        {
            ICShipmentProposalsInfo ShipmentProposals = (ICShipmentProposalsInfo)CurrentModuleEntity.MainObject;
            ICShipmentProposalsController objShipmentProposalsController = new ICShipmentProposalsController();
            //ICShipmentProposalsInfo ShipmentProposal = (ICShipmentProposalsInfo)objShipmentProposalsController.GetObjectByID(saleOrder.FK_ARCustomerID);
            if (ShipmentProposals != null)
            {
                //ShipmentProposals.ICShipmentProposalDesc = ShipmentProposal.ICShipmentProposalName;
            }



        }
        #region ToolBarFunction



        public void ApproveShipmentProposal()
        {

            if (!CheckShipmentProposalValidQty())
            {
                return;
            }

            ActionComplete();



        }

        public bool CheckShipmentProposalValidQty()
        {
            bool isValid = true;
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (objShipmentProposalsInfo.ICShipmentProposalReference != String.Empty)
            {
                if (objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.Hardware.ToString()
                    || objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.IngredientPaint.ToString()
                    || objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.IngredientPackaging.ToString()
                    || objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.SemiProduct.ToString()
                    || objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.Other.ToString()
                    || objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.Product.ToString())
                {
                    foreach (ICShipmentProposalItemsInfo item in entity.ShipmentProposalItemList)
                    {
                        decimal qty = 0;
                        decimal proposalQty = 0;
                        decimal sameDocQty = 0;
                        if (item.ICShipmentProposalItemID == 0)
                        {
                            List<ICShipmentProposalItemsInfo> matchList = entity.ShipmentProposalItemList.Where(t => t.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID && t.ICShipmentProposalItemID == 0).ToList();
                            if (matchList != null && matchList.Count > 0)
                            {
                                proposalQty = matchList.Sum(t => t.ICShipmentProposalItemProductQty);
                            }

                            List<ICShipmentProposalItemsInfo> matchListSameDoc = entity.ShipmentProposalItemList.Where(t => t.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID && t.ICShipmentProposalItemID > 0).ToList();
                            if (matchListSameDoc != null && matchListSameDoc.Count > 0)
                            {
                                sameDocQty = matchListSameDoc.Sum(t => t.ICShipmentProposalItemProductQty);
                            }

                        }
                        else
                        {
                            proposalQty = item.ICShipmentProposalItemProductQty;
                        }

                        ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                        objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetItemForCheckingShipmentProposalValidQty(item.FK_ARSaleOrderItemID, item.ICShipmentProposalItemID);
                        if (objSaleOrderItemsInfo != null)
                        {
                            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                                {
                                    qty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty, 4, MidpointRounding.AwayFromZero);
                                }
                                else
                                {
                                    qty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty, 2, MidpointRounding.AwayFromZero);
                                }
                            }
                        }

                        if (proposalQty > qty)
                        {
                            MessageBox.Show(item.ICShipmentProposalItemProductDesc + " có số lượng không hợp lệ. Số lượng có thể đề nghị: " + (qty + sameDocQty), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    foreach (ICShipmentProposalItemsInfo item in entity.ShipmentProposalItemList)
                    {
                        decimal qty = 0;
                        decimal proposalQty = 0;
                        decimal sameDocQty = 0;
                        if (item.ICShipmentProposalItemID == 0)
                        {
                            List<ICShipmentProposalItemsInfo> matchList = entity.ShipmentProposalItemList.Where(t => t.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID && t.ICShipmentProposalItemID == 0).ToList();
                            if (matchList != null && matchList.Count > 0)
                            {
                                proposalQty = matchList.Sum(t => t.ICShipmentProposalItemProductQty);
                            }
                            List<ICShipmentProposalItemsInfo> matchListSameDoc = entity.ShipmentProposalItemList.Where(t => t.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID && t.ICShipmentProposalItemID > 0).ToList();
                            if (matchListSameDoc != null && matchListSameDoc.Count > 0)
                            {
                                sameDocQty = matchListSameDoc.Sum(t => t.ICShipmentProposalItemProductQty);
                            }
                        }
                        else
                        {
                            proposalQty = item.ICShipmentProposalItemProductQty;
                        }


                        ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                        objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetItemForCheckingShipmentProposalValidQty(item.FK_ARSaleOrderItemID, item.ICShipmentProposalItemID);
                        if (objSaleOrderItemsInfo != null)
                        {
                            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                       objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                                {
                                    qty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty + objSaleOrderItemsInfo.ARSaleOrderItemTenPercentQty, 4, MidpointRounding.AwayFromZero);
                                }
                                else
                                {
                                    qty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty + objSaleOrderItemsInfo.ARSaleOrderItemTenPercentQty, 2, MidpointRounding.AwayFromZero);
                                }
                            }
                        }

                        if (proposalQty > qty)
                        {
                            MessageBox.Show(item.ICShipmentProposalItemProductDesc + " có số lượng không hợp lệ. Số lượng có thể đề nghị: " + (qty + sameDocQty) + Environment.NewLine + ShipmentProposalLocalizedResources.CheckSaleOrderWoodItemQty, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

            }
            return isValid;
        }

        public bool CheckShipmentProposalQtyWithLoadCont()
        {
            bool flag = true;
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ICShipmentProposalItemsInfo objShipmentProposalItemsInfo = new ICShipmentProposalItemsInfo();
            ICShipmentProposalItemsController objShipmentProposalItemsController = new ICShipmentProposalItemsController();
            ARContainerLoaderItemsController objContainerLoaderItemsController = new ARContainerLoaderItemsController();
            ARContainerLoaderItemsInfo objContainerLoaderItemsInfo = new ARContainerLoaderItemsInfo();
            if (objShipmentProposalsInfo.ICShipmentProposalReference != String.Empty)
            {
                if (objShipmentProposalsInfo.ICShipmentProposalProductType == ShipmentProposalProductType.Product.ToString())
                {
                    foreach (ICShipmentProposalItemsInfo item in entity.ShipmentProposalItemList)
                    {
                        if (item.FK_ARContainerLoaderItemID > 0)
                        {
                            objContainerLoaderItemsInfo = (ARContainerLoaderItemsInfo)objContainerLoaderItemsController.GetObjectByID(item.FK_ARContainerLoaderItemID);
                            if (objContainerLoaderItemsInfo != null)
                            {
                                decimal qty = 0;
                                decimal qtyProposal = 0;
                                objShipmentProposalItemsInfo = (ICShipmentProposalItemsInfo)objShipmentProposalItemsController.GetQtyByContainerItemID(item.FK_ARContainerLoaderItemID, objShipmentProposalsInfo.ICShipmentProposalID);
                                if (objShipmentProposalItemsInfo != null)
                                {
                                    qtyProposal = objShipmentProposalItemsInfo.ICShipmentProposalItemProductQty;
                                }
                                qty = entity.ShipmentProposalItemList.Where(x => x.FK_ARContainerLoaderItemID == item.FK_ARContainerLoaderItemID).Sum(y => y.ICShipmentProposalItemProductQty);
                                if (qty + qtyProposal > objContainerLoaderItemsInfo.ARContainerLoaderItemProductQty)
                                {
                                    flag = false;
                                    MessageBox.Show(item.ICShipmentProposalItemProductDesc + " có số lượng không hợp lệ. Số lượng có thể đề nghị: " + (objContainerLoaderItemsInfo.ARContainerLoaderItemProductQty - (qtyProposal))
                                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                        }


                    }

                }

            }
            return flag;
        }


        public override int ActionSave()
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            entity.ShipmentProposalItemList.EndCurrentEdit();
            if (!CheckShipmentProposalQtyWithLoadCont())
            {
                return 0;
            }
            if (!CheckShipmentProposalValidQty())
            {
                return 0;
            }

            if (IsEditAfterBrowsing)
            {
                ApproveShipmentProposal();
                IsEditAfterBrowsing = false;
            }
            int save = base.ActionSave();

            if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, true);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, true);

            }
            if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Canceled.ToString() ||
                objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Finish.ToString() ||
                objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Shipping.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, false);
            }
            if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, true);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, false);
                ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, false);

            }

            return save;


        }
        public void EditAfterBrowsing()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                IsEditAfterBrowsing = true;

                base.ActionEdit();

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
                ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                List<ARInvoiceItemsInfo> invoiceList = objInvoiceItemsController.GetItemsByShipmentProposalID(objShipmentProposalsInfo.ICShipmentProposalID);
                if (invoiceList.Count > 0)
                {
                    MessageBox.Show(ShipmentProposalLocalizedResources.ARInvoiceNotNull, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActionCancel();
                }
                ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                if (objShipmentProposalsInfo.ICShipmentProposalReference != String.Empty)
                {
                    foreach (ICShipmentProposalItemsInfo item in entity.ShipmentProposalItemList)
                    {
                        ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                        if (objSaleOrderItemsInfo != null)
                        {

                            objSaleOrderItemsInfo.ARSaleOrderItemProposedQty -= item.ICShipmentProposalItemProductQty;
                            objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                        }
                    }
                }
            }
        }
        public void DiscardShipmentProposal()
        {
            //ActionEdit();
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARContainerLoaderItemsController objContainerLoaderItemsController = new ARContainerLoaderItemsController();
            if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalStatus.Approved.ToString() ||
                objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalStatus.New.ToString())
            {
                objShipmentProposalsInfo.ICShipmentProposalStatus = ShipmentProposalStatus.Canceled.ToString();
                objShipmentProposalsInfo.FK_HRDiscardEmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objShipmentProposalsInfo.ICShipmentProposalDiscardDate = DateTime.Now;
                entity.UpdateALLProposalItemStatus(ShipmentProposalItemStatus.Canceled.ToString());
                //if (objShipmentProposalsInfo.FK_ARInvoiceID > 0)
                //entity.UpdateInvoiceReferrenceShipmentStatus(objShipmentProposalsInfo.FK_ARInvoiceID);
                //EnableToolbar();
                InvalidateToolbar();
                entity.UpdateMainObject();


                ICShipmentProposalItemsController shipmentProposalItemsController = new ICShipmentProposalItemsController();
                ICShipmentProposalItemsInfo shipmentProposalItem;
                foreach (ICShipmentProposalItemsInfo item in entity.ShipmentProposalItemList)
                {
                    shipmentProposalItem = shipmentProposalItemsController.GetItemForCheckingShipmentProposalValidQty(item.ICShipmentProposalItemID);
                    if (shipmentProposalItem != null && shipmentProposalItem.ICShipmentProposalItemRemainQuantity > 0)
                    {
                        ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                        if (objSaleOrderItemsInfo != null)
                        {
                            objSaleOrderItemsInfo.ARSaleOrderItemProposedQty -= shipmentProposalItem.ICShipmentProposalItemRemainQuantity;
                            objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);

                        }

                        ARContainerLoaderItemsInfo objContainerLoaderItemsInfo = (ARContainerLoaderItemsInfo)objContainerLoaderItemsController.GetObjectByID(item.FK_ARContainerLoaderItemID);
                        if (objContainerLoaderItemsInfo != null)
                        {
                            objContainerLoaderItemsInfo.ARContainerLoaderItemProposedQty -= shipmentProposalItem.ICShipmentProposalItemRemainQuantity;
                            objContainerLoaderItemsController.UpdateObject(objContainerLoaderItemsInfo);
                        }


                        item.ICShipmentProposalItemProductCanceledQty = shipmentProposalItem.ICShipmentProposalItemRemainQuantity;
                        shipmentProposalItemsController.UpdateObject(item);
                    }
                }
            }
            else
            {
                string message = string.Empty;
                if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalStatus.Canceled.ToString())
                    message = ShipmentProposalLocalizedResources.CanceledMessage;
                else if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalStatus.Finish.ToString())
                    message = ShipmentProposalLocalizedResources.FinishMessage;
                else if (objShipmentProposalsInfo.ICShipmentProposalStatus == ShipmentProposalStatus.Shipping.ToString())
                    message = ShipmentProposalLocalizedResources.ShippingMessage;

                MessageBox.Show(string.Format(ShipmentProposalLocalizedResources.ChangeStatusMessage, message), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        //public void EnableToolbar()
        //{
        //    ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
        //    ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
        //    string status = objShipmentProposalsInfo.ICShipmentProposalStatus;
        //    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, true);
        //    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, true);
        //    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
        //    //New
        //    if (status == ShipmentProposalItemStatus.New.ToString())
        //    {
        //        ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, true);
        //        ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, true);

        //    }
        //    //Approved
        //    if (status == ShipmentProposalItemStatus.Approved.ToString())
        //    {
        //        ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
        //        ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, true);
        //        ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
        //    }
        //    //
        //    if (status == ShipmentProposalItemStatus.Canceled.ToString() ||
        //        status == ShipmentProposalItemStatus.Finish.ToString() ||
        //        status == ShipmentProposalItemStatus.Shipping.ToString())
        //    {
        //        ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
        //        ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, false);
        //        ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
        //    }
        //}
        #endregion


        //public override void InvalidateToolbar()
        //{
        //    base.InvalidateToolbar();
        //}
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            InvalidateToolbar();
        }
        public override void InvalidateToolbar()
        {
            //base.Invalidate(iObjectID);
            ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.Print, true);

            base.InvalidateToolbar();
            ICShipmentProposalsInfo objShipmentsInfo = (ICShipmentProposalsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
            ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, false);
            ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, false);
            if (objShipmentsInfo.ICShipmentProposalID > 0 && Toolbar.IsNullOrNoneAction())
            {
                if (objShipmentsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, true);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, true);

                }
                if (objShipmentsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Canceled.ToString() ||
                    objShipmentsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Finish.ToString() ||
                    objShipmentsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.Shipping.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, false);
                }
                if (objShipmentsInfo.ICShipmentProposalStatus == ShipmentProposalItemStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.ApproveShipmentProposal, true);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.DiscardShipmentProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(ShipmentProposalConst.EditAfterBrowsing, false);

                }


                else
                {
                    //ParentScreen.SetEnableOfToolbarButton("ApproveShipmentProposal", true);
                }
            }
            //EnableToolbar();
        }
        public void ActionPrint()
        {

            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ADReportsController objReportsController = new ADReportsController();
                RPICShipmentProposal report = new RPICShipmentProposal();
                // report.LoadLayout(BOSCommon.Constants.Report.DevRPICShipmentProposalPath);
                InitInvoiceReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPICShipmentProposalPath, false);
                reviewer.Show();
            }
        }
        private void InitInvoiceReport(XtraReport report)
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
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel36"];
                if (label != null)
                {
                    label.Text = "Điện thoại: " + objBranchsInfo.BRBranchWarrantyPhone;
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
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            if (objShipmentProposalsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel7"];
                if (label != null)
                {
                    label.Text = objShipmentProposalsInfo.ICShipmentProposalNo;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel10"];
                if (label != null)
                {
                    label.Text = objShipmentProposalsInfo.ICShipmentProposalDate.ToString("dd/MM/yyyy");
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel11"];
                if (label != null)
                {
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objShipmentProposalsInfo.FK_ACObjectID, objShipmentProposalsInfo.ICObjectType);
                    if (objObjectsInfo != null)
                    {
                        label.Text = string.IsNullOrEmpty(objObjectsInfo.ACObjectContactName) ? objObjectsInfo.ACObjectName : objObjectsInfo.ACObjectContactName;
                    }
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel12"];
                if (label != null)
                {
                    MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(objShipmentProposalsInfo.FK_MMBatchProductID);
                    if (objBatchProductsInfo != null)
                    {
                        label.Text = objBatchProductsInfo.MMBatchProductNo;
                    }
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel4"];
                if (label != null)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objShipmentProposalsInfo.FK_ICProductAttributeTTMTID);
                    if (objProductAttributesInfo != null)
                    {
                        label.Text = objProductAttributesInfo.ICProductAttributeValue;
                    }
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel14"];
                if (label != null)
                {
                    label.Text = objShipmentProposalsInfo.ICShipmentProposalActualDeliveryDate.ToString();
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel19"];
                if (label != null)
                {
                    label.Text = objShipmentProposalsInfo.ICShipmentProposalPONo;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel23"];
                if (label != null)
                {
                    label.Text = objShipmentProposalsInfo.ICShipmentProposalDesc;
                }


            }

            ADReportsController objReportsController = new ADReportsController();
            //ARInvoicesController objInvoicesController = new ARInvoicesController();
            List<ICShipmentProposalItemsInfo> list = new List<ICShipmentProposalItemsInfo>();
            list = objReportsController.GetICShipmentProposalItemsByID(Toolbar.CurrentObjectID);

            report.DataSource = list;
            //report.DataMember = BOSCommon.Constants.Report.DevRPICShipmentProposalPath;            
        }
        public void SelectSeriesNoDefault()
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            // DataGenerator.SelectSeriesNoDefault1(entity.ShipmentProposalItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
        }

        //[NKVung] [Load GridView By Product Type] [START]
        public void ChangedInputType(string inputType)
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            ICProductsController objICProductsController = new ICProductsController();
            //List<ICProductsInfo> productList = new List<ICProductsInfo>();
            if (inputType == ProductType.Roundwood.ToString())
            {
                //productList = objICProductsController.GetProductByProductType(ProductType.Roundwood.ToString());
                ShipmentProposalItemsGridControl.LoadGridViewByProductType(inputType);
            }
            else if (inputType == ProductType.Lumber.ToString() || inputType == ProductType.Verneer.ToString()
                || inputType == ProductType.ArtificialBoard.ToString())
            {
                //productList = objICProductsController.GetProductByProductWoodType();
                ShipmentProposalItemsGridControl.LoadGridViewByProductType(ProductType.Lumber.ToString());
            }
            else
            {
                ShipmentProposalItemsGridControl.LoadGridViewByProductType(inputType);
                //productList = objICProductsController.GetDataProductForSale();
            }
            //ProductItemLookUpEdit.Properties.DataSource = productList;
        }
        //[NKVung]  [Load GridView By Product Type] [END]

        public void ChangeStock(int stockID)
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)entity.MainObject;
            objShipmentProposalsInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ShipmentProposalItemList.Count > 0)
                {
                    if (MessageBox.Show(ReceiptLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICShipmentProposalItemsInfo item in entity.ShipmentProposalItemList)
                        {
                            item.FK_ICStockID = stockID;
                        }
                        entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }


        public void CopyLine()
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;

            int index = entity.ShipmentProposalItemList.CurrentIndex;
            if (index >= 0)
            {
                ICShipmentProposalItemsInfo item = (ICShipmentProposalItemsInfo)entity.ShipmentProposalItemList[index];
                if (item != null)
                {
                    ICShipmentProposalItemsInfo newItem = new ICShipmentProposalItemsInfo();
                    BOSUtil.CopyObject(item, newItem);
                    entity.ShipmentProposalItemList.Add(newItem);
                    entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
                }
            }
        }

        public override void ActionCancel()
        {
            base.ActionCancel();
            IsEditAfterBrowsing = false;
        }

        public void ResetModelDetail(ICShipmentProposalItemsInfo item)
        {
            ShipmentProposalEntities entity = (ShipmentProposalEntities)CurrentModuleEntity;
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
            entity.ShipmentProposalItemList.GridControl.RefreshDataSource();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICShipmentProposalsController objShipmentProposalsController = new ICShipmentProposalsController();
            ICShipmentProposalsInfo searchObject = (ICShipmentProposalsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = objShipmentProposalsController.GetShipmentProposalListDataSet(searchObject.ICShipmentProposalNo,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.ICShipmentProposalReference,
                                                                            searchObject.ICShipmentProposalFromDate,
                                                                            searchObject.ICShipmentProposalToDate);
            return ds;
        }

    }
}