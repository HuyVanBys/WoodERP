using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.WoodPlan.UI;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan
{
    public class WoodPlanModule : BaseTransactionModule
    {
        #region Constants
        public const string ApproveToolBar = "Approved";
        public const string CheckWoodPlanToolBar = "CheckWoodPlan";
        public const string UpdateInventoryStockBOSButtonEditName = "fld_btnUpdateInventoryStock";
        public const string MMWoodPlanItemDetailsGridControlName = "fld_dgcMMWoodPlanItemDetails";
        public const string WoodPlanItemDetailMainsGridControlName = "fld_dgcWoodPlanItemDetail";
        public const string EditAfterComplete = "EditAfterComplete";
        #endregion Constants

        #region Private Properties
        BOSButton UpdateInventoryStockBOSButtonEdit;
        public MMWoodPlanItemDetailsGridControl WoodPlanItemDetailsGridControl;
        public MMWoodPlanItemDetailMainsGridControl WoodPlanItemDetailMainsGridControl;
        public bool Flag = false;
        public BOSLookupEdit LookupMaterial;
        public BOSLookupEdit LookupMaterialChange;
        public BOSTextBox TextboxTotalMaterialQty;
        public BOSTextBox TextboxTotalMaterialQtyChange;
        #endregion Private Properties
        #region Public methods

        public WoodPlanModule()
        {
            Name = "WoodPlan";
            CurrentModuleEntity = new WoodPlanEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            InvalidateToolbar();
            WoodPlanItemDetailsGridControl = (MMWoodPlanItemDetailsGridControl)Controls[WoodPlanModule.MMWoodPlanItemDetailsGridControlName];
            WoodPlanItemDetailMainsGridControl = (MMWoodPlanItemDetailMainsGridControl)Controls[WoodPlanModule.WoodPlanItemDetailMainsGridControlName];
            UpdateInventoryStockBOSButtonEdit = (BOSButton)Controls[UpdateInventoryStockBOSButtonEditName];
            LookupMaterial = (BOSLookupEdit)Controls["fld_lkeMaterials"];
            LookupMaterialChange = (BOSLookupEdit)Controls["fld_lkeMaterialsChange"];
            TextboxTotalMaterialQty = (BOSTextBox)Controls["fld_txtTotalMaterialQty"];
            TextboxTotalMaterialQtyChange = (BOSTextBox)Controls["fld_txtTotalMaterialQtyChange"];
        }

        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            MMWoodPlansController woodPlanController = new MMWoodPlansController();
            MMWoodPlansInfo searchObject = (MMWoodPlansInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = woodPlanController.GetWoodPlansBySomeCriteria(
                                                            searchObject.MMWoodPlanNo,
                                                            searchObject.MMWoodPlanStatus,
                                                            searchObject.FK_ARCustomerID,
                                                            searchObject.FK_MMBatchProductID,
                                                            searchObject.FK_ARSaleOrderID,
                                                            searchObject.FK_HREmployeeID,
                                                            searchObject.MMWoodPlanDateFrom,
                                                            searchObject.MMWoodPlanDateTo);


            return ds;
        }
        public override void ActionNew()
        {
            base.ActionNew();

        }
        public void UpdateTotalMaterialQty()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo mainObject = (MMWoodPlansInfo)entity.MainObject;
            int materialID = Convert.ToInt32(LookupMaterial.EditValue);
            List<MMWoodPlanItemDetailsInfo> filterList = new List<MMWoodPlanItemDetailsInfo>();
            //List<MMWoodPlanItemsInfo> objWoodplanItem = (List<MMWoodPlanItemsInfo>)entity.WoodPlanItemList.Clone();
            foreach (MMWoodPlanItemsInfo item in entity.WoodPlanItemList.Where(i => i.Selected).ToList())
            {
                filterList.AddRange(entity.WoodPlanItemDetailMainList.Where(i => i.FK_MMWoodPlanItemID == item.MMWoodPlanItemID && i.AbstractRefID == item.AbstractID).ToList());
            }
            TextboxTotalMaterialQty.Text = filterList.Where(t => t.FK_ICProductID == materialID).Sum(i => i.MMWoodPlanItemDetailProductDryBlocks).ToString();
        }
        public void ChangeMaterials()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo mainObject = (MMWoodPlansInfo)entity.MainObject;
            int materialID = Convert.ToInt32(LookupMaterial.EditValue);
            int materialChangeID = Convert.ToInt32(LookupMaterialChange.EditValue);
            decimal TotalMaterialQty = 0;
            decimal TotalMaterialQtyChange = 0;
            decimal.TryParse(TextboxTotalMaterialQty.EditValue.ToString(), out TotalMaterialQty);
            decimal.TryParse(TextboxTotalMaterialQtyChange.EditValue.ToString(), out TotalMaterialQtyChange);
            ICProductsController objPDCOntroller = new ICProductsController();

            if (TotalMaterialQtyChange == 0)
            {
                MessageBox.Show("Vui lòng nhập khối lượng thay đổi!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<MMWoodPlanItemDetailsInfo> filterList = new List<MMWoodPlanItemDetailsInfo>();
            foreach (MMWoodPlanItemsInfo item in entity.WoodPlanItemList.Where(i => i.Selected).ToList())
            {
                filterList.AddRange(entity.WoodPlanItemDetailMainList.Where(i => i.FK_MMWoodPlanItemID == item.MMWoodPlanItemID && i.AbstractRefID == item.AbstractID && i.FK_ICProductID == materialID).ToList());
            }
            //List<MMWoodPlanItemDetailsInfo> filterList = entity.WoodPlanItemDetailMainList.Where(i => i.FK_ICProductID == materialID).ToList();
            if (filterList != null && filterList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nguyên liệu thay đổi!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (MMWoodPlanItemDetailsInfo item in filterList)
            {
                if (TotalMaterialQtyChange >= item.MMWoodPlanItemDetailProductDryBlocks)
                {
                    ICProductsInfo objPDInfo = (ICProductsInfo)objPDCOntroller.GetObjectByID(materialChangeID);
                    if (objPDInfo != null)
                    {
                        item.FK_ICProductID = objPDInfo.ICProductID;
                        item.MMWoodPlanItemDetailProductNo = objPDInfo.ICProductNo;
                        item.MMWoodPlanItemDetailProductName = objPDInfo.ICProductName;
                        item.MMWoodPlanItemDetailProductDesc = objPDInfo.ICProductDesc;
                        item.MMWoodPlanItemDetailProductDryHeight = objPDInfo.ICProductHeight;
                        TotalMaterialQtyChange -= item.MMWoodPlanItemDetailProductDryBlocks;
                    }
                }
            }
            MessageBox.Show("Thay đổi nguyên liệu thành công!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TextboxTotalMaterialQtyChange.EditValue = TotalMaterialQtyChange.ToString();
            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
        }
        public void AddListItemFromBatchProduct(List<MMBatchProductProductionNormItemsInfo> batchProductItemsList)
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo mainObject = (MMWoodPlansInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemMeterialsController objBPIMController = new MMBatchProductProductionNormItemMeterialsController();

            int abstractID = entity.WoodPlanItemList.Count + 1;
            decimal productQty = 0;
            if (batchProductItemsList != null && batchProductItemsList.Count > 0 && mainObject.FK_ARCustomerID == 0)
            {
                MMBatchProductsController objPCon = new MMBatchProductsController();
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objPCon.GetObjectByID(batchProductItemsList[0].FK_MMBatchProductID);
                if (objBatchProductsInfo != null)
                {
                    mainObject.FK_ARSaleOrderID = objBatchProductsInfo.FK_ARSaleOrderID;
                    mainObject.FK_ARCustomerID = objBatchProductsInfo.FK_ARCustomerID;
                    mainObject.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
                    mainObject.MMWoodPlanPONo = objBatchProductsInfo.MMBatchProductPONo;
                    mainObject.FK_MMWorkShopID = objBatchProductsInfo.FK_MMWorkShopID;
                }
            }
            foreach (MMBatchProductProductionNormItemsInfo batchProductItem in batchProductItemsList)
            {
                if (entity.WoodPlanItemList.Select(i => i.FK_MMBatchProductProductionNormItemID).ToList().Contains(batchProductItem.MMBatchProductProductionNormItemID))
                    continue;
                //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(batchProductItem.FK_ICProductID);
                ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == batchProductItem.FK_ICProductID);
                if (objProductsInfo != null && !objProductsInfo.HasComponent)//&& batchProductItem.MMBatchProductProductionNormItemResourceType == BatchProductProductionNormItemResourceType.Manafacturing.ToString())
                {
                    int productionNormID = 0;
                    if (batchProductItem.FK_MMProductionNormID == 0)
                    {
                        //MMBatchProductProductionNormItemsInfo objBatchProductItem2sInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(batchProductItem.MMBatchProductProductionNormItemParentID);
                        //if (objBatchProductItem2sInfo != null)
                        //{
                        //    productionNormID = objBatchProductItem2sInfo.FK_MMProductionNormID;
                        //}

                        productionNormID = batchProductItem.FK_MMParentProductionNormID;
                    }
                    else
                    {
                        productionNormID = batchProductItem.FK_MMProductionNormID;
                    }
                    //Số lượng TP
                    //MMBatchProductItemsInfo objBatchProductItemsInfo = objBatchProductItemsController.GetBatchProductItemByProductionNormIDAndBatchProductID(productionNormID,batchProductID).FirstOrDefault();
                    //decimal productQty = 0;
                    //if (objBatchProductItemsInfo != null)
                    //{
                    //    productQty = objBatchProductItemsInfo.MMBatchProductItemProductQty;
                    //}
                    productQty += batchProductItem.MMBatchProductItemProductQty;
                    #region Item
                    MMWoodPlanItemsInfo objWoodPlanItemsInfo = new MMWoodPlanItemsInfo();
                    //Loại gỗ
                    //ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    //ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                    //objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttibuteValue(batchProductItem.MMBatchProductProductionNormItemProductWoodType);
                    //if (objProductAttributesInfo != null)
                    //{
                    //    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo.ICProductAttributeID;
                    //}
                    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = batchProductItem.FK_ICProductAttributeID;
                    //Đặc tính
                    objWoodPlanItemsInfo.FK_MMBatchProductID = batchProductItem.FK_MMBatchProductID;
                    objWoodPlanItemsInfo.FK_MMBatchProductProductionNormItemID = batchProductItem.MMBatchProductProductionNormItemID;
                    //Mã chi tiết
                    objWoodPlanItemsInfo.MMWoodPlanItemProductNo = batchProductItem.MMBatchProductProductionNormItemNo;
                    //Tên chi tiết
                    objWoodPlanItemsInfo.MMWoodPlanItemProductName = batchProductItem.MMBatchProductProductionNormItemProductName;
                    //Mô tả
                    objWoodPlanItemsInfo.MMWoodPlanItemProductDesc = batchProductItem.MMBatchProductProductionNormItemComment;
                    //Ghi chú đặc tính
                    objWoodPlanItemsInfo.MMWoodPlanItemSpecialityComment = batchProductItem.MMBatchProductProductionNormItemComment;
                    //Dày DM
                    objWoodPlanItemsInfo.MMWoodPlanItemProductHeight = batchProductItem.MMBatchProductProductionNormItemProductHeight;
                    //Rộng DM
                    objWoodPlanItemsInfo.MMWoodPlanItemProductWidth = batchProductItem.MMBatchProductProductionNormItemProductWidth;
                    //Dài DM
                    objWoodPlanItemsInfo.MMWoodPlanItemProductLength = batchProductItem.MMBatchProductProductionNormItemProductLength;
                    //Khối tinh DM (Gỗ m3)
                    objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = (
                                batchProductItem.MMBatchProductProductionNormItemProductHeight *
                                batchProductItem.MMBatchProductProductionNormItemProductWidth *
                                batchProductItem.MMBatchProductProductionNormItemProductLength / (decimal)(Math.Pow(10, 9))) * batchProductItem.MMBatchProductProductionNormItemQuantity;

                    //TNDLoc [ADD][19/05/2016][Round Wood 4],START
                    objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = Math.Round(objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks, 5, MidpointRounding.AwayFromZero);
                    //TNDLoc [ADD][19/05/2016][Round Wood 4],END
                    //TS tiêu hao
                    objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate = batchProductItem.MMBatchProductProductionNormItemDepreciationRate;
                    //Cụm
                    objWoodPlanItemsInfo.MMWoodPlanItemParentNo = batchProductItem.MMBatchProductProductionNormItemParentNo;
                    objWoodPlanItemsInfo.MMWoodPlanItemParentID = batchProductItem.MMBatchProductProductionNormItemParentID;
                    objWoodPlanItemsInfo.FK_MMBatchProductItemID = batchProductItem.FK_MMBatchProductItemID;
                    objWoodPlanItemsInfo.FK_ICProductForBatchID = batchProductItem.FK_ICProductForBatchID;
                    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = batchProductItem.FK_ICProductAttributeWoodTypeID;

                    //Nguyên liệu gỗ
                    objWoodPlanItemsInfo.FK_ICProductWoodIngredientID = batchProductItem.FK_ICProductWoodIngredientID;

                    //Gỗ tận dụng
                    objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = batchProductItem.MMBatchProductProductionNormItemIsReuse;
                    objWoodPlanItemsInfo.MMWoodPlanItemAllocationType = "MaterialStock";
                    //objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = IsReUseItem(objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID,
                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductLength,
                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductHeight,
                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductWidth,
                    //                                                         objWoodPlanItemsInfo.FK_ICProductAttributeSpecialityID);

                    //ID ảo
                    objWoodPlanItemsInfo.AbstractID = abstractID++;
                    //Thông tin khác
                    objWoodPlanItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;

                    objWoodPlanItemsInfo.MMBatchProductItemProductID = batchProductItem.FK_ICProductForBatchID;
                    objWoodPlanItemsInfo.MMBatchProductItemProductDesc = batchProductItem.MMBatchProductItemProductDesc;

                    entity.WoodPlanItemList.Add(objWoodPlanItemsInfo);
                    #endregion

                    #region Item Detail

                    List<MMBatchProductProductionNormItemMeterialsInfo> objBPIMList = objBPIMController.GetListByBatchProductProductionNormItemID(batchProductItem.MMBatchProductProductionNormItemID);

                    foreach (MMBatchProductProductionNormItemMeterialsInfo item in objBPIMList)
                    {
                        MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = new MMWoodPlanItemDetailsInfo();
                        //Nguyên liệu gỗ
                        objWoodPlanItemDetailsInfo.FK_ICProductID = item.FK_ICProductID;

                        //Mã nguyên liệu
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductNo = item.ICProductNo;
                        //Tên nguyên liệu
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductName = item.ICProductName;
                        //Mô tả
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDesc = item.ICProductDesc;
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryWidth = item.MMBatchProductProductionNormItemMeterialWidth;
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryHeight = item.MMBatchProductProductionNormItemMeterialHeigth;
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryLength = item.MMBatchProductProductionNormItemMeterialLength;
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailMaterialQty = item.MMBatchProductProductionNormItemMeterialQty;
                        //Số lượng
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity = batchProductItem.MMBatchProductProductionNormItemQuantity;
                        //Dày thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = objWoodPlanItemsInfo.MMWoodPlanItemProductHeight;
                        //Rộng thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = objWoodPlanItemsInfo.MMWoodPlanItemProductWidth;
                        //Dài thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = objWoodPlanItemsInfo.MMWoodPlanItemProductLength;
                        //Khối tinh thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks;
                        //TNDLoc [ADD][19/05/2016][Round Wood 4],START

                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = Math.Round(objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks, 5, MidpointRounding.AwayFromZero);
                        //TNDLoc [ADD][19/05/2016][Round Wood 4],END
                        //TS tiêu hao
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate = item.MMBatchProductProductionNormItemMeterialDepreciationRate;
                        //ID ref ảo
                        objWoodPlanItemDetailsInfo.AbstractRefID = objWoodPlanItemsInfo.AbstractID;
                        //Thông tin khác
                        objWoodPlanItemDetailsInfo.FK_ICSemiProductID = objProductsInfo.ICProductID;
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailAllocationType = "MaterialStock";
                        objWoodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID = objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID;
                        objWoodPlanItemDetailsInfo.FK_MMBatchProductItemID = objWoodPlanItemsInfo.FK_MMBatchProductItemID;
                        objWoodPlanItemDetailsInfo.FK_MMBatchProductID = objWoodPlanItemsInfo.FK_MMBatchProductID;
                        objWoodPlanItemDetailsInfo.FK_ICProductForBatchID = objWoodPlanItemsInfo.FK_ICProductForBatchID;
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = item.MMBatchProductProductionNormItemMeterialDepreciationQty;
                        CalculateDetailInfo(objWoodPlanItemDetailsInfo, true, batchProductItem);
                        entity.WoodPlanItemDetailMainList.Add(objWoodPlanItemDetailsInfo);
                    }
                    #endregion
                }
            }
            mainObject.MMWoodPlanProductQty += productQty;
            entity.WoodPlanItemList.GridControl?.RefreshDataSource();
            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
            SetAbstractIDForItemList();
            FocusWoodPlanItemChange();
            //SetExtraProductProperties();
            SetExtraItemStatus();
        }
        public void ActionNewFromBatchProduct()
        {
            ActionNew();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ARCustomersController objCustomersController = new ARCustomersController();
            MMWorkShopsController objWorkShopsController = new MMWorkShopsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetBatchProductForWoodPlan();
            if (batchProductList != null)
            {
                guiFind<MMBatchProductsInfo> guiChooseBatchProduct = new guiFind<MMBatchProductsInfo>(TableName.MMBatchProductsTableName, batchProductList, this, false);
                guiChooseBatchProduct.Module = this;
                if (guiChooseBatchProduct.ShowDialog() == DialogResult.OK)
                {
                    int batchProductID = 0;
                    if (int.TryParse(guiChooseBatchProduct.Tag.ToString(), out batchProductID))
                    {

                        WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
                        entity.WoodPlanItemDetailMainList.Clear();
                        //Main Object
                        MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
                        objWoodPlansInfo.FK_MMBatchProductID = batchProductID;
                        MMBatchProductsInfo objBatchProductsInfo = batchProductList.FirstOrDefault(t => t.MMBatchProductID == batchProductID);
                        if (objBatchProductsInfo != null)
                        {
                            objWoodPlansInfo.FK_ARSaleOrderID = objBatchProductsInfo.FK_ARSaleOrderID;
                            objWoodPlansInfo.MMWoodPlanPONo = objBatchProductsInfo.MMBatchProductPONo;
                            if (objBatchProductsInfo.FK_ARSaleOrderID > 0)
                            {
                                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objBatchProductsInfo.FK_ARSaleOrderID);
                                if (objSaleOrdersInfo != null)
                                    objWoodPlansInfo.MMWoodPlanPONo = objSaleOrdersInfo.ARSaleOrderNo;
                            }
                            objWoodPlansInfo.FK_ARCustomerID = objBatchProductsInfo.FK_ARCustomerID;
                            if (objBatchProductsInfo.MMObjectType == ObjectType.Customer.ToString() && objBatchProductsInfo.FK_ACObjectID > 0)
                            {
                                ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objBatchProductsInfo.FK_ACObjectID, ObjectType.Customer.ToString());
                                if (objObjectsInfo != null)
                                {
                                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByNo(objObjectsInfo.ACObjectNo);
                                    if (objCustomersInfo != null)
                                        objWoodPlansInfo.FK_ARCustomerID = objCustomersInfo.ARCustomerID;
                                }
                            }
                            objWoodPlansInfo.FK_MMWorkShopID = objBatchProductsInfo.FK_MMWorkShopID;
                            objWoodPlansInfo.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
                            objWoodPlansInfo.MMWoodPlanPONo = objBatchProductsInfo.MMBatchProductPONo;
                            objWoodPlansInfo.MMWoodPlanBatchProductNo = objBatchProductsInfo.MMBatchProductNo;
                        }
                        MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                        List<MMBatchProductItemsInfo> objbatchProductItemsList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(batchProductID);
                        if (objbatchProductItemsList != null && objbatchProductItemsList.Count > 0)
                        {
                            //Số lượng
                            objWoodPlansInfo.MMWoodPlanProductQty = objbatchProductItemsList.Sum(b => b.MMBatchProductItemProductQty);
                        }

                        //Module Object

                        MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                        List<MMBatchProductProductionNormItemsInfo> batchProductItemsList = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemByBatchProductID(batchProductID);

                        if (batchProductItemsList != null && batchProductItemsList.Count > 0)
                        {
                            //ICProductsController objProductsController = new ICProductsController();
                            int abstractID = 1;
                            foreach (MMBatchProductProductionNormItemsInfo batchProductItem in batchProductItemsList)
                            {
                                //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(batchProductItem.FK_ICProductID);
                                ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == batchProductItem.FK_ICProductID);
                                if (objProductsInfo != null && !objProductsInfo.HasComponent)//&& batchProductItem.MMBatchProductProductionNormItemResourceType == BatchProductProductionNormItemResourceType.Manafacturing.ToString())
                                {
                                    int productionNormID = 0;
                                    if (batchProductItem.FK_MMProductionNormID == 0)
                                    {
                                        //MMBatchProductProductionNormItemsInfo objBatchProductItem2sInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(batchProductItem.MMBatchProductProductionNormItemParentID);
                                        //if (objBatchProductItem2sInfo != null)
                                        //{
                                        //    productionNormID = objBatchProductItem2sInfo.FK_MMProductionNormID;
                                        //}
                                        productionNormID = batchProductItem.FK_MMParentProductionNormID;
                                    }
                                    else
                                    {
                                        productionNormID = batchProductItem.FK_MMProductionNormID;
                                    }
                                    //Số lượng TP
                                    //MMBatchProductItemsInfo objBatchProductItemsInfo = objBatchProductItemsController.GetBatchProductItemByProductionNormIDAndBatchProductID(productionNormID,batchProductID).FirstOrDefault();
                                    //decimal productQty = 0;
                                    //if (objBatchProductItemsInfo != null)
                                    //{
                                    //    productQty = objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    //}
                                    #region Item
                                    MMWoodPlanItemsInfo objWoodPlanItemsInfo = new MMWoodPlanItemsInfo();
                                    //Loại gỗ                                 
                                    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = batchProductItem.FK_ICProductAttributeID;
                                    if (objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID == 0 && !string.IsNullOrEmpty(batchProductItem.MMBatchProductProductionNormItemProductWoodType))
                                    {
                                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesByGroupAndValue(ProductAttributeGroup.WoodType.ToString(), batchProductItem.MMBatchProductProductionNormItemProductWoodType);
                                        if (objProductAttributesInfo != null)
                                        {
                                            objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo.ICProductAttributeID;
                                        }
                                    }
                                    //Đặc tính
                                    objWoodPlanItemsInfo.FK_MMBatchProductID = batchProductID;
                                    objWoodPlanItemsInfo.FK_MMBatchProductProductionNormItemID = batchProductItem.MMBatchProductProductionNormItemID;
                                    //Mã chi tiết
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductNo = batchProductItem.MMBatchProductProductionNormItemNo;
                                    //Tên chi tiết
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductName = batchProductItem.MMBatchProductProductionNormItemProductName;
                                    //Mô tả
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductDesc = batchProductItem.MMBatchProductProductionNormItemComment;
                                    //Ghi chú đặc tính
                                    objWoodPlanItemsInfo.MMWoodPlanItemSpecialityComment = batchProductItem.MMBatchProductProductionNormItemComment;
                                    //Dày DM
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductHeight = batchProductItem.MMBatchProductProductionNormItemProductHeight;
                                    //Rộng DM
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductWidth = batchProductItem.MMBatchProductProductionNormItemProductWidth;
                                    //Dài DM
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductLength = batchProductItem.MMBatchProductProductionNormItemProductLength;
                                    //Khối tinh DM (Gỗ m3)
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = batchProductItem.MMBatchProductProductionNormItemWoodBlocks;
                                    //TNDLoc [ADD][19/05/2016][Round Wood 4],START
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = Math.Round(objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks, 5, MidpointRounding.AwayFromZero);
                                    //TNDLoc [ADD][19/05/2016][Round Wood 4],END
                                    //TS tiêu hao
                                    objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate = batchProductItem.MMBatchProductProductionNormItemDepreciationRate;
                                    //Cụm
                                    objWoodPlanItemsInfo.MMWoodPlanItemParentNo = batchProductItem.MMBatchProductProductionNormItemParentNo;
                                    objWoodPlanItemsInfo.MMWoodPlanItemParentID = batchProductItem.MMBatchProductProductionNormItemParentID;
                                    objWoodPlanItemsInfo.FK_MMBatchProductItemID = batchProductItem.FK_MMBatchProductItemID;
                                    objWoodPlanItemsInfo.FK_ICProductForBatchID = batchProductItem.FK_ICProductForBatchID;
                                    if (batchProductItem.FK_MMProductionNormID > 0)
                                    {
                                        foreach (MMBatchProductItemsInfo objItem in objbatchProductItemsList)
                                        {
                                            if (objItem.FK_MMProductionNormID == batchProductItem.FK_MMProductionNormID)
                                            {
                                                objWoodPlanItemsInfo.FK_MMBatchProductItemID = objItem.MMBatchProductItemID;
                                                objWoodPlanItemsInfo.FK_ICProductForBatchID = objItem.FK_ICProductID;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (batchProductItem.MMBatchProductProductionNormItemParentID > 0)
                                        {
                                            //MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo
                                            //    = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(batchProductItem.MMBatchProductProductionNormItemParentID);
                                            //if (objBatchProductProductionNormItemsInfo != null && objBatchProductProductionNormItemsInfo.FK_MMProductionNormID > 0)
                                            if (batchProductItem.FK_MMParentProductionNormID > 0)
                                            {
                                                foreach (MMBatchProductItemsInfo objItem in objbatchProductItemsList)
                                                {
                                                    if (objItem.FK_MMProductionNormID == batchProductItem.FK_MMParentProductionNormID)
                                                    {
                                                        objWoodPlanItemsInfo.FK_MMBatchProductItemID = objItem.MMBatchProductItemID;
                                                        objWoodPlanItemsInfo.FK_ICProductForBatchID = objItem.FK_ICProductID;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    //Nguyên liệu gỗ
                                    objWoodPlanItemsInfo.FK_ICProductWoodIngredientID = batchProductItem.FK_ICProductWoodIngredientID;

                                    //Gỗ tận dụng
                                    objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = batchProductItem.MMBatchProductProductionNormItemIsReuse;
                                    objWoodPlanItemsInfo.MMWoodPlanItemAllocationType = "Purchase";
                                    //objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = IsReUseItem(objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID,
                                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductLength,
                                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductHeight,
                                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductWidth,
                                    //                                                         objWoodPlanItemsInfo.FK_ICProductAttributeSpecialityID);

                                    //ID ảo
                                    objWoodPlanItemsInfo.AbstractID = abstractID++;
                                    //Thông tin khác
                                    objWoodPlanItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                                    objWoodPlanItemsInfo.MMBatchProductItemProductID = batchProductItem.FK_ICProductForBatchID;
                                    objWoodPlanItemsInfo.MMBatchProductItemProductDesc = batchProductItem.MMBatchProductItemProductDesc;

                                    entity.WoodPlanItemList.Add(objWoodPlanItemsInfo);
                                    #endregion

                                    #region Item Detail
                                    MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = new MMWoodPlanItemDetailsInfo();
                                    //Nguyên liệu gỗ
                                    objWoodPlanItemDetailsInfo.FK_ICProductID = batchProductItem.FK_ICProductWoodIngredientID;
                                    //ICProductsInfo objIngredientsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objWoodPlanItemDetailsInfo.FK_ICProductID);
                                    ICProductsForViewInfo objIngredientsInfo = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == objWoodPlanItemDetailsInfo.FK_ICProductID);
                                    if (objIngredientsInfo != null)
                                    {
                                        //Mã nguyên liệu
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductNo = objIngredientsInfo.ICProductNo;
                                        //Tên nguyên liệu
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductName = objIngredientsInfo.ICProductName;
                                        //Mô tả
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDesc = objIngredientsInfo.ICProductDesc;
                                    }
                                    //Số lượng
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity = batchProductItem.MMBatchProductProductionNormItemQuantity;
                                    //Dày thực tế
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = objWoodPlanItemsInfo.MMWoodPlanItemProductHeight;
                                    //Rộng thực tế
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = objWoodPlanItemsInfo.MMWoodPlanItemProductWidth;
                                    //Dài thực tế
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = objWoodPlanItemsInfo.MMWoodPlanItemProductLength;
                                    //Khối tinh thực tế
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks;
                                    //TNDLoc [ADD][19/05/2016][Round Wood 4],START

                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = Math.Round(objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks, 5, MidpointRounding.AwayFromZero);
                                    //TNDLoc [ADD][19/05/2016][Round Wood 4],END
                                    //TS tiêu hao
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate = batchProductItem.MMBatchProductProductionNormItemDepreciationRate;
                                    //ID ref ảo
                                    objWoodPlanItemDetailsInfo.AbstractRefID = objWoodPlanItemsInfo.AbstractID;
                                    //Thông tin khác
                                    objWoodPlanItemDetailsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                                    objWoodPlanItemDetailsInfo.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                                    objWoodPlanItemDetailsInfo.MMBatchProductItemProductName = objProductsInfo.ICProductName;
                                    objWoodPlanItemDetailsInfo.FK_ICSemiProductID = objProductsInfo.ICProductID;
                                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailAllocationType = "Purchase";
                                    objWoodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID = objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID;
                                    objWoodPlanItemDetailsInfo.FK_MMBatchProductItemID = objWoodPlanItemsInfo.FK_MMBatchProductItemID;
                                    objWoodPlanItemDetailsInfo.FK_MMBatchProductID = objWoodPlanItemsInfo.FK_MMBatchProductID;
                                    objWoodPlanItemDetailsInfo.FK_ICProductForBatchID = objWoodPlanItemsInfo.FK_ICProductForBatchID;
                                    CalculateDetailInfo(objWoodPlanItemDetailsInfo, true, batchProductItem);
                                    entity.WoodPlanItemDetailMainList.Add(objWoodPlanItemDetailsInfo);
                                    #endregion

                                }
                            }
                            entity.WoodPlanItemList.GridControl?.RefreshDataSource();

                            SetAbstractIDForItemList();
                            FocusWoodPlanItemChange();
                            //SetExtraProductProperties();
                            SetExtraItemStatus();
                            if (objWoodPlansInfo.FK_MMWorkShopID > 0)
                            {
                                MMWorkShopsInfo objWorkShopsInfo = (MMWorkShopsInfo)objWorkShopsController.GetObjectByID(objWoodPlansInfo.FK_MMWorkShopID);
                                if (objWorkShopsInfo != null)
                                {
                                    entity.WoodPlanItemDetailList.ForEach(o => { o.FK_MMWorkShopID = objWorkShopsInfo.MMWorkShopID; o.MMWorkShopName = objWorkShopsInfo.MMWorkShopName; });
                                    entity.WoodPlanItemDetailMainList.ForEach(o => { o.FK_MMWorkShopID = objWorkShopsInfo.MMWorkShopID; o.MMWorkShopName = objWorkShopsInfo.MMWorkShopName; });
                                    entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
                                    entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
                                }
                            }
                        }
                        //else
                        //{
                        //    base.ActionCancel();
                        //}
                    }
                }
                else
                {
                    base.ActionCancel();
                }
            }
        }

        public void LineValueChanged(int iLineID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show("Bạn có muốn thay đổi Chuyền cho thông tin chi tiết?",
                    MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
                    MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
                    MMLinesController objLinesController = new MMLinesController();
                    if (iLineID > 0)
                    {
                        MMLinesInfo objLinesInfo = (MMLinesInfo)objLinesController.GetObjectByID(iLineID);
                        if (objLinesInfo != null)
                        {
                            entity.WoodPlanItemDetailList.ForEach(o => { o.FK_MMLineID = objLinesInfo.MMLineID; o.MMLineName = objLinesInfo.MMLineName; });
                            entity.WoodPlanItemDetailMainList.ForEach(o => { o.FK_MMLineID = objLinesInfo.MMLineID; o.MMLineName = objLinesInfo.MMLineName; });
                            entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
                            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
                        }
                    }
                    else
                    {
                        entity.WoodPlanItemDetailList.ForEach(o => o.MMLineName = string.Empty);
                        entity.WoodPlanItemDetailMainList.ForEach(o => o.MMLineName = string.Empty);
                        entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
                        entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
                    }
                }
            }
        }

        public void WorkShopValueChanged(int iWorkShopID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show("Bạn có muốn thay đổi Xưởng cho thông tin chi tiết?",
                    MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
                    MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
                    MMWorkShopsController objWorkShopsController = new MMWorkShopsController();
                    if (iWorkShopID > 0)
                    {
                        MMWorkShopsInfo objWorkShopsInfo = (MMWorkShopsInfo)objWorkShopsController.GetObjectByID(iWorkShopID);
                        if (objWorkShopsInfo != null)
                        {
                            entity.WoodPlanItemDetailList.ForEach(o => { o.FK_MMWorkShopID = objWorkShopsInfo.MMWorkShopID; o.MMWorkShopName = objWorkShopsInfo.MMWorkShopName; });
                            entity.WoodPlanItemDetailMainList.ForEach(o => { o.FK_MMWorkShopID = objWorkShopsInfo.MMWorkShopID; o.MMWorkShopName = objWorkShopsInfo.MMWorkShopName; });
                            entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
                            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
                        }
                    }
                    else
                    {
                        entity.WoodPlanItemDetailList.ForEach(o => o.MMWorkShopName = string.Empty);
                        entity.WoodPlanItemDetailMainList.ForEach(o => o.MMWorkShopName = string.Empty);
                        entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
                        entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
                    }
                }
            }
        }

        public void ActionNewFromDetailPlan()
        {
            ActionNew();
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            int operation = 1;
            List<MMOperationDetailPlansInfo> OperationDetailPlanList = objOperationDetailPlansController.GetOperationDetailPlanForWoodPlan(operation);
            if (OperationDetailPlanList != null)
            {
                guiFind<MMOperationDetailPlansInfo> guiChooseOperationDetailPlan = new guiFind<MMOperationDetailPlansInfo>(TableName.MMOperationDetailPlansTableName, OperationDetailPlanList, this, false);
                guiChooseOperationDetailPlan.Module = this;
                if (guiChooseOperationDetailPlan.ShowDialog() == DialogResult.OK)
                {
                    int OperationDetailPlanID = 0;
                    if (int.TryParse(guiChooseOperationDetailPlan.Tag.ToString(), out OperationDetailPlanID))
                    {
                        WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
                        entity.WoodPlanItemDetailMainList.Clear();
                        //Main Object
                        MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
                        objWoodPlansInfo.FK_MMOperationDetailPlanID = OperationDetailPlanID;
                        MMOperationDetailPlansInfo objOperationDetailPlansInfo = OperationDetailPlanList.FirstOrDefault(t => t.MMOperationDetailPlanID == OperationDetailPlanID);
                        if (objOperationDetailPlansInfo != null)
                        {

                            objWoodPlansInfo.FK_MMWorkShopID = objOperationDetailPlansInfo.FK_MMWorkShopID;
                            objWoodPlansInfo.FK_MMLineID = objOperationDetailPlansInfo.FK_MMLineID;
                            //objWoodPlansInfo.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
                            //objWoodPlansInfo.MMWoodPlanPONo = objBatchProductsInfo.MMBatchProductPONo;
                        }
                        MMOperationDetailPlanItemsController objOperationDetailPlanItemsController = new MMOperationDetailPlanItemsController();
                        List<MMOperationDetailPlanItemsInfo> objOperationDetailPlanItemsList = objOperationDetailPlanItemsController.GetOperationDetailPlanItemByOperationDetailPlan(OperationDetailPlanID);
                        if (objOperationDetailPlanItemsList != null && objOperationDetailPlanItemsList.Count > 0)
                        {
                            //Số lượng
                            objWoodPlansInfo.MMWoodPlanProductQty = objOperationDetailPlanItemsList.Sum(b => b.MMOperationDetailPlanItemPlanProductQty);


                            //Module Object

                            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                            List<MMBatchProductProductionNormItemsInfo> batchProductItemsList = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemByOperationDetailPlanID(OperationDetailPlanID);

                            if (batchProductItemsList != null && batchProductItemsList.Count > 0)
                            {
                                //ICProductsController objProductsController = new ICProductsController();
                                int abstractID = 1;
                                foreach (MMBatchProductProductionNormItemsInfo batchProductItem in batchProductItemsList)
                                {
                                    //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(batchProductItem.FK_ICProductID);
                                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == batchProductItem.FK_ICProductID);
                                    if (objProductsInfo != null && !objProductsInfo.HasComponent)
                                    {
                                        int productionNormID = 0;
                                        if (batchProductItem.FK_MMProductionNormID == 0)
                                        {
                                            //MMBatchProductProductionNormItemsInfo objBatchProductItem2sInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(batchProductItem.MMBatchProductProductionNormItemParentID);
                                            //if (objBatchProductItem2sInfo != null)
                                            //{
                                            //    productionNormID = objBatchProductItem2sInfo.FK_MMProductionNormID;
                                            //}
                                            productionNormID = batchProductItem.FK_MMParentProductionNormID;
                                        }
                                        else
                                        {
                                            productionNormID = batchProductItem.FK_MMProductionNormID;
                                        }

                                        #region Item
                                        MMWoodPlanItemsInfo objWoodPlanItemsInfo = new MMWoodPlanItemsInfo();
                                        //Loại gỗ
                                        //ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                                        //ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                                        //objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(batchProductItem.MMBatchProductProductionNormItemProductWoodType);
                                        //if (objProductAttributesInfo != null)
                                        //{
                                        //    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo.ICProductAttributeID;
                                        //}
                                        objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = batchProductItem.FK_ICProductAttributeID;
                                        objWoodPlanItemsInfo.FK_MMBatchProductID = batchProductItem.FK_MMBatchProductID;
                                        objWoodPlanItemsInfo.FK_MMBatchProductProductionNormItemID = batchProductItem.MMBatchProductProductionNormItemID;
                                        //Mã chi tiết
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductNo = batchProductItem.MMBatchProductProductionNormItemNo;
                                        //Tên chi tiết
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductName = batchProductItem.MMBatchProductProductionNormItemProductName;
                                        //Mô tả
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductDesc = batchProductItem.MMBatchProductProductionNormItemComment;
                                        //Ghi chú đặc tính
                                        objWoodPlanItemsInfo.MMWoodPlanItemSpecialityComment = batchProductItem.MMBatchProductProductionNormItemComment;
                                        //Dày DM
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductHeight = batchProductItem.MMBatchProductProductionNormItemProductHeight;
                                        //Rộng DM
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductWidth = batchProductItem.MMBatchProductProductionNormItemProductWidth;
                                        //Dài DM
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductLength = batchProductItem.MMBatchProductProductionNormItemProductLength;

                                        //Khối tinh DM (Gỗ m3)
                                        objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = batchProductItem.MMBatchProductProductionNormItemBlockPerOne *
                                                                                            batchProductItem.MMBatchProductProductionNormItemQuantity
                                                                                            ;

                                        //TS tiêu hao
                                        objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate = batchProductItem.MMBatchProductProductionNormItemDepreciationRate;
                                        //Cụm
                                        objWoodPlanItemsInfo.MMWoodPlanItemParentNo = batchProductItem.MMBatchProductProductionNormItemParentNo;
                                        objWoodPlanItemsInfo.MMWoodPlanItemParentID = batchProductItem.MMBatchProductProductionNormItemParentID;
                                        //objWoodPlanItemsInfo.FK_MMBatchProductItemID = 
                                        objWoodPlanItemsInfo.FK_MMBatchProductItemID = batchProductItem.FK_MMBatchProductItemID;
                                        objWoodPlanItemsInfo.FK_MMBatchProductID = batchProductItem.FK_MMBatchProductID;
                                        objWoodPlansInfo.FK_MMBatchProductID = batchProductItem.FK_MMBatchProductID;
                                        objWoodPlanItemsInfo.FK_ICProductForBatchID = batchProductItem.FK_ICProductForBatchID;
                                        //Nguyên liệu gỗ
                                        objWoodPlanItemsInfo.FK_ICProductWoodIngredientID = batchProductItem.FK_ICProductWoodIngredientID;
                                        //Nguyên liệu gỗ
                                        objWoodPlanItemsInfo.FK_ICProductAttributeQualityID = batchProductItem.FK_ICProductAttributeQualityID;
                                        //trừ MDF ko cấp tho CL

                                        //Gỗ tận dụng
                                        objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = batchProductItem.MMBatchProductProductionNormItemIsReuse;

                                        objWoodPlanItemsInfo.MMWoodPlanItemAllocationType = "MaterialStock";
                                        //ID ảo
                                        objWoodPlanItemsInfo.AbstractID = abstractID++;
                                        //Thông tin khác
                                        objWoodPlanItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                                        objWoodPlanItemsInfo.MMBatchProductItemProductID = batchProductItem.FK_ICProductForBatchID;
                                        objWoodPlanItemsInfo.MMBatchProductItemProductDesc = batchProductItem.MMBatchProductItemProductDesc;

                                        entity.WoodPlanItemList.Add(objWoodPlanItemsInfo);
                                        #endregion

                                        #region Item Detail
                                        MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = new MMWoodPlanItemDetailsInfo();
                                        //Nguyên liệu gỗ
                                        objWoodPlanItemDetailsInfo.FK_ICProductID = batchProductItem.FK_ICProductWoodIngredientID;
                                        //ICProductsInfo objIngredientsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objWoodPlanItemDetailsInfo.FK_ICProductID);
                                        ICProductsForViewInfo objIngredientsInfo = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == objWoodPlanItemDetailsInfo.FK_ICProductID);
                                        if (objIngredientsInfo != null)
                                        {
                                            //Mã nguyên liệu
                                            objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductNo = objIngredientsInfo.ICProductNo;
                                            //Tên nguyên liệu
                                            objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductName = objIngredientsInfo.ICProductName;
                                            //Mô tả
                                            objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDesc = objIngredientsInfo.ICProductDesc;
                                        }
                                        //Số lượng
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity = batchProductItem.MMBatchProductProductionNormItemQuantity * batchProductItem.MMBatchProductProductionNormItemQuantityPerOne;
                                        //Dày thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = objWoodPlanItemsInfo.MMWoodPlanItemProductHeight;
                                        //Rộng thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = objWoodPlanItemsInfo.MMWoodPlanItemProductWidth;
                                        //Dài thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = objWoodPlanItemsInfo.MMWoodPlanItemProductLength;
                                        //Khối tinh thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks;

                                        //TS tiêu hao
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate = batchProductItem.MMBatchProductProductionNormItemDepreciationRate;
                                        //ID ref ảo
                                        objWoodPlanItemDetailsInfo.AbstractRefID = objWoodPlanItemsInfo.AbstractID;
                                        //Thông tin khác
                                        objWoodPlanItemDetailsInfo.FK_ICSemiProductID = objProductsInfo.ICProductID;
                                        objWoodPlanItemDetailsInfo.FK_MMBatchProductItemID = objWoodPlanItemsInfo.FK_MMBatchProductItemID;
                                        objWoodPlanItemDetailsInfo.FK_MMBatchProductID = objWoodPlanItemsInfo.FK_MMBatchProductID;
                                        objWoodPlanItemDetailsInfo.FK_ICProductForBatchID = objWoodPlanItemsInfo.FK_ICProductForBatchID;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailAllocationType = "MaterialStock";
                                        objWoodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID = objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID;
                                        objWoodPlanItemDetailsInfo.FK_ICProductAttributeQualityID = objWoodPlanItemsInfo.FK_ICProductAttributeQualityID;

                                        CalculateDetailInfo(objWoodPlanItemDetailsInfo, false, batchProductItem);

                                        entity.WoodPlanItemDetailMainList.Add(objWoodPlanItemDetailsInfo);
                                        #endregion
                                    }
                                }
                                entity.WoodPlanItemList.GridControl?.RefreshDataSource();
                                SetAbstractIDForItemList();
                                FocusWoodPlanItemChange();
                                //SetExtraProductProperties();
                                SetExtraItemStatus();
                            }
                        }
                    }
                }
                else
                {
                    base.ActionCancel();
                }
            }
        }
        public void UpdateFromBatchProduct()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ActionEdit();
                string status = string.Empty;
                int abstractID = 0;
                WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
                MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
                MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                List<MMBatchProductProductionNormItemsInfo> ListProductionNormItems = new List<MMBatchProductProductionNormItemsInfo>();
                MMBatchProductProductionNormItemMeterialsController objBPIMController = new MMBatchProductProductionNormItemMeterialsController();
                List<int> ListBatchProductID = entity.WoodPlanItemList.Select(i => i.FK_MMBatchProductID).Distinct().ToList();
                foreach (int id in ListBatchProductID)
                    ListProductionNormItems.AddRange(objBatchProductProductionNormItemsController.GetListObjectByBatchProductID(id));

                //ListProductionNormItems = objBatchProductProductionNormItemsController.GetListObjectByBatchProductID(objWoodPlansInfo.FK_MMBatchProductID);
                //if (objWoodPlansInfo.FK_MMOperationDetailPlanID > 0)
                //    ListProductionNormItems = objBatchProductProductionNormItemsController.GetAllBatchProductProductionNormItemByOperationDetailPlanID(objWoodPlansInfo.FK_MMOperationDetailPlanID);
                //else
                //    ListProductionNormItems = objBatchProductProductionNormItemsController.GetListObjectByBatchProductID(objWoodPlansInfo.FK_MMBatchProductID);
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                //ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();


                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                List<MMBatchProductItemsInfo> objbatchProductItemsList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objWoodPlansInfo.FK_MMBatchProductID);
                if (objbatchProductItemsList != null && objbatchProductItemsList.Count > 0)
                {
                    //Số lượng
                    objWoodPlansInfo.MMWoodPlanProductQty = objbatchProductItemsList.Sum(b => b.MMBatchProductItemProductQty);
                }
                if (entity.WoodPlanItemList != null && entity.WoodPlanItemList.Count >= 1)
                {
                    abstractID = entity.WoodPlanItemList.Max(x => x.AbstractID) + 1;
                }
                else
                {
                    abstractID = 1;
                }
                foreach (MMBatchProductProductionNormItemsInfo item in ListProductionNormItems)
                {
                    //ICProductsController objProductsController = new ICProductsController();
                    MMWoodPlanItemsInfo objWoodPlanItemsInfo = entity.WoodPlanItemList.Where(x => x.FK_MMBatchProductProductionNormItemID == item.MMBatchProductProductionNormItemID
                        || (x.FK_ICProductID == item.FK_ICProductID && x.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)).FirstOrDefault();
                    bool isChangeID = false;
                    if ((objWoodPlanItemsInfo != null && item.MMBatchProductProductionNormItemID != objWoodPlanItemsInfo.FK_MMBatchProductProductionNormItemID))
                        isChangeID = true;

                    if (objWoodPlanItemsInfo == null || isChangeID)
                    {

                        if (isChangeID)
                        {
                            DeleteForUpdate(objWoodPlanItemsInfo);
                        }
                        //Hoạch định chi tiết chưa có chi tiết này.
                        if (item.MMBatchProductProductionNormItemModifiedStatus == "Delete")
                        {
                            continue;
                        }
                        else
                        {
                            if (item.MMBatchProductProductionNormItemResourceType == "OutSourcing")
                            {
                                continue;
                            }
                            else
                            {
                                #region Tạo Item và ItemDetails
                                objWoodPlanItemsInfo = new MMWoodPlanItemsInfo();
                                //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                                ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(item1 => item1.ICProductID == item.FK_ICProductID);
                                if (objProductsInfo != null && !objProductsInfo.HasComponent)
                                {
                                    int productionNormID = 0;
                                    if (item.FK_MMProductionNormID == 0)
                                    {
                                        MMBatchProductProductionNormItemsInfo objBatchProductItem2sInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.MMBatchProductProductionNormItemParentID);
                                        if (objBatchProductItem2sInfo != null)
                                        {
                                            productionNormID = objBatchProductItem2sInfo.FK_MMProductionNormID;
                                        }
                                    }
                                    else
                                    {
                                        productionNormID = item.FK_MMProductionNormID;
                                    }
                                    #region Item

                                    //Loại gỗ
                                    //ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                                    // ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                                    //objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(item.MMBatchProductProductionNormItemProductWoodType);
                                    //if (objProductAttributesInfo != null)
                                    //{
                                    //    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo.ICProductAttributeID;
                                    //}
                                    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeID;
                                    //Đặc tính
                                    objWoodPlanItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                                    objWoodPlanItemsInfo.FK_MMBatchProductProductionNormItemID = item.MMBatchProductProductionNormItemID;
                                    objWoodPlanItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
                                    objWoodPlanItemsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                                    //Mã chi tiết
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductNo = item.MMBatchProductProductionNormItemNo;
                                    //Tên chi tiết
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductName = item.MMBatchProductProductionNormItemProductName;
                                    //Mô tả
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductDesc = item.MMBatchProductProductionNormItemComment;
                                    //Ghi chú đặc tính
                                    objWoodPlanItemsInfo.MMWoodPlanItemSpecialityComment = item.MMBatchProductProductionNormItemComment;
                                    //Dày DM
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductHeight = item.MMBatchProductProductionNormItemProductHeight;
                                    //Rộng DM
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductWidth = item.MMBatchProductProductionNormItemProductWidth;
                                    //Dài DM
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductLength = item.MMBatchProductProductionNormItemProductLength;
                                    //Khối tinh DM (Gỗ m3)
                                    objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = item.MMBatchProductProductionNormItemBlockPerOne *
                                                                                        item.MMBatchProductProductionNormItemQuantity;
                                    //TS tiêu hao
                                    objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate = item.MMBatchProductProductionNormItemDepreciationRate;
                                    //Cụm
                                    objWoodPlanItemsInfo.MMWoodPlanItemParentNo = item.MMBatchProductProductionNormItemParentNo;
                                    objWoodPlanItemsInfo.MMWoodPlanItemParentID = item.MMBatchProductProductionNormItemParentID;
                                    objWoodPlanItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;

                                    //Gỗ tận dụng
                                    objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = item.MMBatchProductProductionNormItemIsReuse;

                                    objWoodPlanItemsInfo.MMWoodPlanItemAllocationType = "MaterialStock";

                                    //Nguyên liệu gỗ
                                    objWoodPlanItemsInfo.FK_ICProductWoodIngredientID = item.FK_ICProductWoodIngredientID;

                                    //Gỗ tận dụng
                                    objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = item.MMBatchProductProductionNormItemIsReuse;
                                    //objWoodPlanItemsInfo.MMWoodPlanItemIsReuse = IsReUseItem(objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID,
                                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductLength,
                                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductHeight,
                                    //                                                         objWoodPlanItemsInfo.MMWoodPlanItemProductWidth,
                                    //                                                         objWoodPlanItemsInfo.FK_ICProductAttributeSpecialityID);

                                    //ID ảo
                                    objWoodPlanItemsInfo.AbstractID = abstractID++;
                                    //Thông tin khác
                                    objWoodPlanItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                                    objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                    if (string.IsNullOrEmpty(status))
                                    {
                                        status = WoodPlanLocalizedResources.AddNew;
                                    }
                                    else
                                    {
                                        status += "," + WoodPlanLocalizedResources.AddNew;
                                    }
                                    objWoodPlanItemsInfo.StatusUpdate = status;

                                    objWoodPlanItemsInfo.MMBatchProductItemProductID = item.FK_ICProductForBatchID;
                                    objWoodPlanItemsInfo.MMBatchProductItemProductDesc = item.MMBatchProductItemProductDesc;

                                    entity.WoodPlanItemList.Add(objWoodPlanItemsInfo);

                                    #region Item Detail

                                    List<MMBatchProductProductionNormItemMeterialsInfo> objBPIMList = objBPIMController.GetListByBatchProductProductionNormItemID(item.MMBatchProductProductionNormItemID);

                                    foreach (MMBatchProductProductionNormItemMeterialsInfo materialItem in objBPIMList)
                                    {
                                        MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = new MMWoodPlanItemDetailsInfo();
                                        //Nguyên liệu gỗ
                                        objWoodPlanItemDetailsInfo.FK_ICProductID = materialItem.FK_ICProductID;

                                        //Mã nguyên liệu
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductNo = materialItem.ICProductNo;
                                        //Tên nguyên liệu
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductName = materialItem.ICProductName;
                                        //Mô tả
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDesc = materialItem.ICProductDesc;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryWidth = materialItem.MMBatchProductProductionNormItemMeterialWidth;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryHeight = materialItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryLength = materialItem.MMBatchProductProductionNormItemMeterialLength;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailMaterialQty = materialItem.MMBatchProductProductionNormItemMeterialQty;
                                        //Số lượng
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity = item.MMBatchProductProductionNormItemQuantity;
                                        //Dày thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = objWoodPlanItemsInfo.MMWoodPlanItemProductHeight;
                                        //Rộng thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = objWoodPlanItemsInfo.MMWoodPlanItemProductWidth;
                                        //Dài thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = objWoodPlanItemsInfo.MMWoodPlanItemProductLength;
                                        //Khối tinh thực tế
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks;
                                        //TNDLoc [ADD][19/05/2016][Round Wood 4],START

                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = Math.Round(objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks, 5, MidpointRounding.AwayFromZero);
                                        //TNDLoc [ADD][19/05/2016][Round Wood 4],END
                                        //TS tiêu hao
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate = materialItem.MMBatchProductProductionNormItemMeterialDepreciationRate;
                                        //ID ref ảo
                                        objWoodPlanItemDetailsInfo.AbstractRefID = objWoodPlanItemsInfo.AbstractID;
                                        //Thông tin khác
                                        objWoodPlanItemDetailsInfo.FK_ICSemiProductID = objProductsInfo.ICProductID;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailAllocationType = "Purchase";
                                        objWoodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID = objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID;
                                        objWoodPlanItemDetailsInfo.FK_MMBatchProductItemID = objWoodPlanItemsInfo.FK_MMBatchProductItemID;
                                        objWoodPlanItemDetailsInfo.FK_MMBatchProductID = objWoodPlanItemsInfo.FK_MMBatchProductID;
                                        objWoodPlanItemDetailsInfo.FK_ICProductForBatchID = objWoodPlanItemsInfo.FK_ICProductForBatchID;
                                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = materialItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                        CalculateDetailInfo(objWoodPlanItemDetailsInfo, true, item);
                                        entity.WoodPlanItemDetailMainList.Add(objWoodPlanItemDetailsInfo);
                                        //SetExtraProductProperties();
                                    }
                                    #endregion

                                    #endregion
                                }
                                #endregion
                            }
                        }
                    }
                    else
                    {
                        //Đã có chi tiết này - kiểm tra có thay đổi hay không
                        //+Xóa
                        if (item.MMBatchProductProductionNormItemModifiedStatus == "Delete")
                        {
                            DeleteForUpdate(objWoodPlanItemsInfo);
                            continue;
                        }
                        else
                        {
                            decimal qty = 0;
                            MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = entity.WoodPlanItemDetailMainList.Where(x => x.FK_MMWoodPlanItemID == objWoodPlanItemsInfo.MMWoodPlanItemID).FirstOrDefault();
                            if (objWoodPlanItemDetailsInfo == null)
                            {
                                DeleteForUpdate(objWoodPlanItemsInfo);
                                continue;
                            }
                            qty = objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity;
                            if (item.MMBatchProductProductionNormItemResourceType == "OutSourcing")
                            {
                                //objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                //if (string.IsNullOrEmpty(status))
                                //{
                                //    status = WoodPlanLocalizedResources.ChangeResource;
                                //}
                                //else
                                //{
                                //    status += "," + WoodPlanLocalizedResources.ChangeResource;
                                //}
                                //objWoodPlanItemsInfo.StatusUpdate = status;
                                DeleteForUpdate(objWoodPlanItemsInfo);
                                continue;

                                //continue;
                            }
                            if (item.MMBatchProductProductionNormItemProductLength != objWoodPlanItemsInfo.MMWoodPlanItemProductLength)
                            {
                                objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                objWoodPlanItemsInfo.MMWoodPlanItemProductLength = item.MMBatchProductProductionNormItemProductLength;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = item.MMBatchProductProductionNormItemProductLength;
                                if (string.IsNullOrEmpty(status))
                                {
                                    status = WoodPlanLocalizedResources.ChangeSpecification;
                                }
                                else
                                {
                                    if (!status.Contains(WoodPlanLocalizedResources.ChangeSpecification))
                                        status += "," + WoodPlanLocalizedResources.ChangeSpecification;
                                }
                                objWoodPlanItemsInfo.StatusUpdate = status;
                                // continue;
                            }
                            if (item.MMBatchProductProductionNormItemProductHeight != objWoodPlanItemsInfo.MMWoodPlanItemProductHeight)
                            {
                                objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                objWoodPlanItemsInfo.MMWoodPlanItemProductHeight = item.MMBatchProductProductionNormItemProductHeight;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = item.MMBatchProductProductionNormItemProductHeight;
                                if (string.IsNullOrEmpty(status))
                                {
                                    status = WoodPlanLocalizedResources.ChangeSpecification;
                                }
                                else
                                {
                                    if (!status.Contains(WoodPlanLocalizedResources.ChangeSpecification))
                                        status += "," + WoodPlanLocalizedResources.ChangeSpecification;
                                }
                                objWoodPlanItemsInfo.StatusUpdate = status;

                                //continue;
                            }
                            if (item.MMBatchProductProductionNormItemProductWidth != objWoodPlanItemsInfo.MMWoodPlanItemProductWidth)
                            {
                                objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                objWoodPlanItemsInfo.MMWoodPlanItemProductWidth = item.MMBatchProductProductionNormItemProductWidth;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = item.MMBatchProductProductionNormItemProductWidth;
                                if (string.IsNullOrEmpty(status))
                                {
                                    status = WoodPlanLocalizedResources.ChangeSpecification;
                                }
                                else
                                {
                                    if (!status.Contains(WoodPlanLocalizedResources.ChangeSpecification))
                                        status += "," + WoodPlanLocalizedResources.ChangeSpecification;
                                }
                                objWoodPlanItemsInfo.StatusUpdate = status;

                                //continue;
                            }


                            //objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(item.MMBatchProductProductionNormItemProductWoodType);

                            //if (objProductAttributesInfo != null)
                            {
                                if (objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID != item.FK_ICProductAttributeID)
                                {
                                    objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                    objWoodPlanItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeID;
                                    objWoodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeID;
                                    objWoodPlanItemDetailsInfo.FK_ICProductID = item.FK_ICProductWoodIngredientID;

                                    if (string.IsNullOrEmpty(status))
                                    {
                                        status = WoodPlanLocalizedResources.ChangeAttributeWoodType;
                                    }
                                    else
                                    {
                                        status += "," + WoodPlanLocalizedResources.ChangeAttributeWoodType;
                                    }
                                    objWoodPlanItemsInfo.StatusUpdate = status;

                                    //continue;
                                }
                            }

                            //ICProductsInfo objIngredientsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objWoodPlanItemDetailsInfo.FK_ICProductID);
                            ICProductsForViewInfo objIngredientsInfo = BOSApp.CurrentProductList.FirstOrDefault(item1 => item1.ICProductID == objWoodPlanItemDetailsInfo.FK_ICProductID);
                            if (objIngredientsInfo != null)
                            {
                                //Mã nguyên liệu
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductNo = objIngredientsInfo.ICProductNo;
                                //Tên nguyên liệu
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductName = objIngredientsInfo.ICProductName;
                                //Mô tả
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDesc = objIngredientsInfo.ICProductDesc;
                            }

                            //Thay doi chât luong ??
                            int WooDQuality = item.FK_ICProductAttributeQualityID;
                            if (WooDQuality != objWoodPlanItemsInfo.FK_ICProductAttributeQualityID)
                            {
                                objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                objWoodPlanItemsInfo.FK_ICProductAttributeQualityID = WooDQuality;
                                objWoodPlanItemDetailsInfo.FK_ICProductAttributeQualityID = WooDQuality;
                                if (string.IsNullOrEmpty(status))
                                {
                                    status = WoodPlanLocalizedResources.ChangeQuality;
                                }
                                else
                                {
                                    if (!status.Contains(WoodPlanLocalizedResources.ChangeQuality))
                                        status += "," + WoodPlanLocalizedResources.ChangeQuality;
                                }
                                objWoodPlanItemsInfo.StatusUpdate = status;

                                //continue;
                            }
                            if (item.MMBatchProductProductionNormItemDepreciationRate != objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate)
                            {
                                objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate = item.MMBatchProductProductionNormItemDepreciationRate;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate = item.MMBatchProductProductionNormItemDepreciationRate;
                                objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = item.MMBatchProductProductionNormItemBlockPerOne *
                                                                                      item.MMBatchProductProductionNormItemQuantity;
                                CalculateDetailInfo(objWoodPlanItemDetailsInfo, false, item);
                                if (string.IsNullOrEmpty(status))
                                {
                                    status = WoodPlanLocalizedResources.ChangeDepreciationRate;
                                }
                                else
                                {
                                    if (!status.Contains(WoodPlanLocalizedResources.ChangeDepreciationRate))
                                        status += "," + WoodPlanLocalizedResources.ChangeDepreciationRate;
                                }
                                objWoodPlanItemsInfo.StatusUpdate = status;
                                // continue;
                            }
                            if (item.MMBatchProductProductionNormItemQuantity != qty ||
                                objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks != item.MMBatchProductProductionNormItemBlockPerOne *
                                                                                       item.MMBatchProductProductionNormItemQuantity ||
                               objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks != objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks *
                               objWoodPlanItemsInfo.MMWoodPlanItemDepreciationRate)
                            {
                                objWoodPlanItemsInfo.HaveChangedForUpdate = true;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity = item.MMBatchProductProductionNormItemQuantity;
                                objWoodPlanItemsInfo.MMWoodPlanItemProductBlocks = item.MMBatchProductProductionNormItemBlockPerOne *
                                                                                       item.MMBatchProductProductionNormItemQuantity;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = item.MMBatchProductProductionNormItemBlockPerOne *
                                                                                       item.MMBatchProductProductionNormItemQuantity;
                                objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = Math.Round(objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks, 5, MidpointRounding.AwayFromZero);
                                CalculateDetailInfo(objWoodPlanItemDetailsInfo, false, item);

                                if (string.IsNullOrEmpty(status))
                                {
                                    status = WoodPlanLocalizedResources.ChangeQty;
                                }
                                else
                                {
                                    status += "," + WoodPlanLocalizedResources.ChangeQty;
                                }
                                objWoodPlanItemsInfo.StatusUpdate = status;

                                //continue;
                            }

                        }
                    }
                }
                //SetAbstractIDForItemList();
                //FocusWoodPlanItemChange();
                //SetExtraProductProperties();
                //SetExtraItemStatus();
                entity.WoodPlanItemList.GridControl?.RefreshDataSource();
                entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
                entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
            }
        }
        public void DeleteForUpdate(MMWoodPlanItemsInfo objWoodPlanItems)
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            //Remove WoodPlanItem
            for (int i = 0; i < entity.WoodPlanItemList.Count; i++)
            {
                if (entity.WoodPlanItemList[i].MMWoodPlanItemID == objWoodPlanItems.MMWoodPlanItemID)
                {

                    for (int j = 0; j <= entity.WoodPlanItemDetailMainList.Count - 1; j++)
                    {

                        if (entity.WoodPlanItemDetailMainList[j].FK_MMWoodPlanItemID == objWoodPlanItems.MMWoodPlanItemID)
                        {
                            entity.WoodPlanItemDetailMainList.RemoveAt(j);
                        }
                    }
                    entity.WoodPlanItemList.RemoveAt(i);
                    break;
                }
            }
            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
            entity.WoodPlanItemList.GridControl?.RefreshDataSource();


            //entity.WoodPlanItemDetailList.RemoveSelectedRowObjectFromList();
            SetAbstractIDForItemList();
            FocusWoodPlanItemChange();
            SetExtraItemStatus();
        }
        //public int GetWooDQuality(int qualityID)
        //{
        //    int result = 0;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> listProductAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup("Quality");
        //    if (listProductAttribute != null)
        //    {

        //        switch (qualityID)
        //        {
        //            case 305://A
        //                result = 162;
        //                break;
        //            case 306://B
        //                result = 162;
        //                break;
        //            case 307://C
        //                result = 163;
        //                break;

        //            case 180://A/A
        //                result = 162;
        //                break;
        //            case 217://B/C
        //                result = 162;
        //                break;
        //            case 218://A/C
        //                result = 162;
        //                break;
        //            case 220://A/B/C
        //                result = 162;
        //                break;
        //            case 219://C/C
        //                result = 163;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    return result;
        //}
        public void ShowInventoryTotalQty()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailList)
            {
                //ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetICProductSeries_ByProductIDAnddryLumberHeight(item.FK_ICProductID, item.MMWoodPlanItemDetailProductDryHeight);
                //if (objProductSeriesInfo != null)
                //{
                //    item.MMWoodPlanItemDetailInventoryStock = ShowInventoryTotalQty(objProductSeriesInfo.FK_ICProductID);
                //}
                item.MMWoodPlanItemDetailInventoryStock = ShowInventoryTotalQty(item.FK_ICProductID);
            }
            entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
            GridView gridView = (GridView)WoodPlanItemDetailsGridControl.MainView;
            LoadGrid(gridView);

            foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailMainList)
            {
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetICProductSeries_ByProductIDAnddryLumberHeight(item.FK_ICProductID, item.MMWoodPlanItemDetailProductDryHeight);
                if (objProductSeriesInfo != null)
                {
                    item.MMWoodPlanItemDetailMainInventoryStock = ShowInventoryTotalQty(objProductSeriesInfo.FK_ICProductID);
                }
            }
            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
            GridView gridView1 = (GridView)WoodPlanItemDetailMainsGridControl.MainView;
            LoadGrid1(gridView1);

        }
        private static void LoadGrid(GridView gridView)
        {
            GridColumn gridColumn = gridView.Columns["MMWoodPlanItemDetailInventoryStock"];
            if (gridColumn != null)
            {
                gridColumn.Visible = true;
            }
        }
        private static void LoadGrid1(GridView gridView1)
        {
            GridColumn gridColumn = gridView1.Columns["MMWoodPlanItemDetailMainInventoryStock"];
            if (gridColumn != null)
            {
                gridColumn.Visible = true;
            }
        }
        private static void InvisibleGrid(GridView gridView)
        {
            GridColumn gridColumn = gridView.Columns["MMWoodPlanItemDetailInventoryStock"];
            if (gridColumn != null)
            {
                gridColumn.Visible = false;
            }
        }
        private static void InvisibleGrid1(GridView gridView1)
        {
            GridColumn gridColumn = gridView1.Columns["MMWoodPlanItemDetailMainInventoryStock"];
            if (gridColumn != null)
            {
                gridColumn.Visible = false;
            }
        }
        //public decimal ShowInventoryTotalQty(int productID)
        //{
        //    decimal qty = 0;
        //    ICProductsController objProductsController = new ICProductsController();
        //    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
        //    if (objProductsInfo != null)
        //    {
        //        int userGroupID = BOSApp.CurrentUserGroupInfo.ADUserGroupID;

        //        List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //        ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
        //        inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndGroupByStockID(productID, userGroupID);

        //        //Collect inventory from the centre                
        //        List<ICInventoryStocksInfo> centralInventoryStocks = CentralInventoryStocks.Where(i => i.FK_ICProductID == productID).ToList();
        //        foreach (ICInventoryStocksInfo centralInventoryStock in centralInventoryStocks)
        //        {
        //            if (centralInventoryStock.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID &&
        //                centralInventoryStock.BRBranchParentID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
        //            {
        //                ICInventoryStocksInfo objInventoryStocksInfo = inventoryStocks.Where(i => i.FK_ICStockID == centralInventoryStock.FK_ICStockID &&
        //                                                                                            i.FK_ICProductID == centralInventoryStock.FK_ICProductID).FirstOrDefault();
        //                if (objInventoryStocksInfo != null)
        //                {
        //                    objInventoryStocksInfo.ICInventoryStockQuantity = centralInventoryStock.ICInventoryStockQuantity;
        //                }
        //                else
        //                {
        //                    inventoryStocks.Add(centralInventoryStock);
        //                }
        //            }
        //        }

        //        if (objProductsInfo.HasComponent)
        //        {
        //            ICStocksController objStocksController = new ICStocksController();
        //            List<ICStocksInfo> stocks = objStocksController.GetStocksByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
        //            foreach (ICStocksInfo objStocksInfo in stocks)
        //            {
        //                ICInventoryStocksInfo existingInventoryStock = inventoryStocks.Where(inv => inv.FK_ICStockID == objStocksInfo.ICStockID &&
        //                                                                                    inv.FK_ICProductID == productID).FirstOrDefault();
        //                if (existingInventoryStock == null)
        //                {
        //                    existingInventoryStock = new ICInventoryStocksInfo();
        //                    existingInventoryStock.FK_BRBranchID = objStocksInfo.FK_BRBranchID;
        //                    existingInventoryStock.BRBranchName = objStocksInfo.BRBranchName;
        //                    existingInventoryStock.FK_ICStockID = objStocksInfo.ICStockID;
        //                    existingInventoryStock.ICStockType = objStocksInfo.ICStockType;
        //                    existingInventoryStock.FK_ICProductID = productID;
        //                    inventoryStocks.Add(existingInventoryStock);
        //                }
        //            }

        //            foreach (ICInventoryStocksInfo objInventoryStocksInfo in inventoryStocks)
        //            {
        //                if (objInventoryStocksInfo.FK_ICProductID == productID)
        //                {
        //                    objInventoryStocksInfo.ICInventoryStockQuantity = CalculateProductQtyByComponent(inventoryStocks, productID, objInventoryStocksInfo.FK_ICStockID);
        //                }
        //            }
        //        }

        //        inventoryStocks = inventoryStocks.Where(inv => inv.FK_ICProductID == productID).ToList();
        //        //inventoryStocks.Where(i => i.ICStockType == StockType.Sale.ToString() || i.ICStockType == StockType.Central.ToString())
        //        //                .ToList()
        //        //                .ForEach(i => i.InventoryType = InventoryType.OnHand.ToString());

        //        //inventoryStocks.Where(i => i.ICStockType == StockType.SaleOrder.ToString())
        //        //                .ToList()
        //        //                .ForEach(i => i.InventoryType = InventoryType.SaleOrder.ToString());

        //        //inventoryStocks.Where(i => i.ICStockType == StockType.Purchase.ToString())
        //        //               .ToList()
        //        //               .ForEach(i => i.InventoryType = InventoryType.PurchaseOrder.ToString());

        //        //inventoryStocks.Where(i => i.ICStockType == StockType.TransitIn.ToString())
        //        //                .ToList()
        //        //                .ForEach(i => i.InventoryType = InventoryType.TransitIn.ToString());

        //        //inventoryStocks.Where(i => i.ICStockType == StockType.TransitOut.ToString())
        //        //                .ToList()
        //        //                .ForEach(i => i.InventoryType = InventoryType.TransitOut.ToString());

        //        //inventoryStocks = inventoryStocks.Where(i => i.ICInventoryStockQuantity > 0).ToList();
        //        //if (inventoryStocks != null)
        //        //    qty = inventoryStocks.Where(i => i.InventoryType == InventoryType.OnHand.ToString())
        //        //                                .Sum(i => i.ICInventoryStockQuantity);


        //        foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
        //        {
        //            if (inventoryStock.ICStockType == StockType.Sale.ToString() ||
        //                inventoryStock.ICStockType == StockType.Central.ToString())
        //            {
        //                qty += inventoryStock.ICInventoryStockQuantity;
        //            }
        //            if (inventoryStock.ICStockType == InventoryType.SaleOrder.ToString() ||
        //                inventoryStock.ICStockType == InventoryType.AllocationPlan.ToString())
        //                qty -= inventoryStock.ICInventoryStockQuantity; ;
        //        }

        //    }
        //    return qty;
        //}
        private decimal CalculateProductQtyByComponent(List<ICInventoryStocksInfo> inventoryStocks, int productID, int stockID)
        {
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(productID);
            decimal productQty = Int32.MaxValue;
            foreach (ICProductComponentsInfo component in components)
            {
                decimal inventoryStockQty = inventoryStocks.Where(inv => inv.FK_ICProductID == component.FK_ICProductComponentChildID && inv.FK_ICStockID == stockID).Sum(inv => inv.ICInventoryStockQuantity);
                if (component.ICProductComponentQty > 0)
                {
                    decimal qty = Math.Floor(inventoryStockQty / component.ICProductComponentQty);
                    if (qty < productQty)
                    {
                        productQty = qty;
                    }
                }
            }
            if (productQty == Int32.MaxValue)
            {
                productQty = 0;
            }
            return productQty;
        }
        //public void SetExtraProductProperties()
        //{
        //    WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
        //    MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
        //    foreach (MMWoodPlanItemsInfo item in entity.WoodPlanItemList)
        //    {
        //        MMBatchProductItemsInfo objBatchProductItems = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(item.FK_MMBatchProductItemID);
        //        if (objBatchProductItems != null)
        //        {
        //            item.MMBatchProductItemProductID = objBatchProductItems.FK_ICProductID;
        //            item.MMBatchProductItemProductDesc = objBatchProductItems.MMBatchProductItemProductDesc;
        //        }
        //    }
        //    entity.WoodPlanItemList.GridControl.RefreshDataSource();
        //}

        public void SetAbstractIDForItemList()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            int id = 1;
            foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailMainList)
            {
                item.AbstractID = id++;
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            int abstractID = 1;
            foreach (MMWoodPlanItemsInfo item in entity.WoodPlanItemList)
            {
                item.AbstractID = abstractID++;
                foreach (MMWoodPlanItemDetailsInfo itemDetail in entity.WoodPlanItemDetailMainList)
                {
                    if (itemDetail.FK_MMWoodPlanItemID == item.MMWoodPlanItemID)
                    {
                        itemDetail.AbstractRefID = item.AbstractID;
                    }
                }
            }
            Flag = false;
            SetAbstractIDForItemList();
            FocusWoodPlanItemChange();
            //SetExtraProductProperties();
            SetExtraItemStatus();
        }

        public void FocusWoodPlanItemChange()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            entity.WoodPlanItemDetailList.Clear();
            if (entity.WoodPlanItemList.CurrentIndex >= 0)
            {
                if (entity.WoodPlanItemList.Count > entity.WoodPlanItemList.CurrentIndex && entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex] != null)
                {

                    int parentID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].AbstractID;
                    int woodPlanItemID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].MMWoodPlanItemID;
                    foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailMainList)
                    {
                        if (item.AbstractRefID == parentID)
                        {
                            ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetICProductSeries_ByProductIDAnddryLumberHeight(item.FK_ICProductID, item.MMWoodPlanItemDetailProductDryHeight);
                            if (objProductSeriesInfo != null)
                            {
                                item.MMWoodPlanItemDetailMainInventoryStock = ShowInventoryTotalQty(item.FK_ICProductID);
                            }
                            entity.WoodPlanItemDetailList.Add(item);

                        }
                    }
                }
            }

            entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
            entity.WoodPlanItemDetailMainList.GridControl?.RefreshDataSource();
        }

        public void CalculateDetailInfo(MMWoodPlanItemDetailsInfo woodPlanItemDetailsInfo, bool isCalBlock, MMBatchProductProductionNormItemsInfo bppni)
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            if (bppni == null)
            {
                int bpnID = woodPlanItemDetailsInfo.FK_MMBatchProductProductionNormItemID;
                if (bpnID == 0)
                {
                    MMWoodPlanItemsInfo parent = entity.WoodPlanItemList.Where(p => p.MMWoodPlanItemID == woodPlanItemDetailsInfo.FK_MMWoodPlanItemID
                        && p.AbstractID == woodPlanItemDetailsInfo.AbstractRefID).FirstOrDefault();
                    if (parent != null)
                        bpnID = parent.FK_MMBatchProductProductionNormItemID;
                }
                bppni = (MMBatchProductProductionNormItemsInfo)(new MMBatchProductProductionNormItemsController()).GetObjectByID(bpnID);
            }

            MMProductionNormItemConfigsController objProductionNormItemConfigsController = new MMProductionNormItemConfigsController();
            MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = objProductionNormItemConfigsController.GetProductionNormItemConfigByWoodTypeID(woodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
            #region Khối tinh
            if (isCalBlock)
            {
                woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = 0;

                if (objProductionNormItemConfigsInfo != null)
                {
                    decimal length = bppni.MMBatchProductProductionNormItemProductLength;
                    decimal width = bppni.MMBatchProductProductionNormItemProductWidth;
                    decimal height = bppni.MMBatchProductProductionNormItemProductHeight;
                    decimal qty = bppni.MMBatchProductProductionNormItemQuantity;

                    if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks)
                    {
                        //woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (woodPlanItemDetailsInfo.MMWoodPlanItemDetailLength * woodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth * woodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight * woodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity) / 1000000000;
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (length *
                                                                              width *
                                                                              height *
                                                                              qty) / 1000000000;

                    }
                    else if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                    {
                        //woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (woodPlanItemDetailsInfo.MMWoodPlanItemDetailLength * woodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth * woodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight * woodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity) / 1000000000;
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (length *
                                                                               width *
                                                                               height *
                                                                               qty) / 1000000000;

                    }
                    else if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood)
                    {
                        //woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (woodPlanItemDetailsInfo.MMWoodPlanItemDetailLength * woodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth * woodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity) / 1000000;
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (length *
                                                                              width *
                                                                              qty) / 1000000000;

                    }
                    else if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                    {
                        // woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (woodPlanItemDetailsInfo.MMWoodPlanItemDetailLength * woodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth * woodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity) / 1000000;
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = (length *
                                                                              width *
                                                                              qty) / 1000000000;

                    }
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = Math.Round(woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks, 5, MidpointRounding.AwayFromZero);
                }
            }
            #endregion
            #region Phách
            MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
            int productGroupID = 0;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            List<ICProductGroupsInfo> productGroupList = objProductGroupsController.GetProductGroupListByNameAndParent("Gỗ", 0);
            if (productGroupList != null && productGroupList.Count > 0)
            {
                productGroupID = productGroupList[0].ICProductGroupID;
            }

            decimal productDryThick = woodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight;
            decimal productBlocks = woodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks;


            MMExchangeRateConfigsInfo objExchangeRateConfigsInfo = objExchangeRateConfigsController.GetExchangeRateConfigSomeCriteria(productGroupID, woodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID, ExchangeRateConfigLumberType.Dry.ToString());
            //Dry
            if (objExchangeRateConfigsInfo != null)
            {
                if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Plus.ToString())
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = productBlocks + objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Minus.ToString())
                {
                    if (productBlocks > objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue)
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = productBlocks - objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                    else
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = 0;
                }
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Multi.ToString())
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = productBlocks * objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Split.ToString())
                {
                    if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue > 0)
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = productBlocks / objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                }
            }

            woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshBlocks = productBlocks * woodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate;
            woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshBlocks = Math.Round(woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshBlocks, 5, MidpointRounding.AwayFromZero);
            woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks = Math.Round(woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks, 5, MidpointRounding.AwayFromZero);

            //Fresh
            objExchangeRateConfigsInfo = objExchangeRateConfigsController.GetExchangeRateConfigSomeCriteria(productGroupID, woodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID, ExchangeRateConfigLumberType.Fresh.ToString());
            if (objExchangeRateConfigsInfo != null)
            {
                //Thick
                if (objExchangeRateConfigsInfo.MMExchangeRateConfigThickOperationTypeCombo == ExchangeRateConfigOperationType.Plus.ToString())
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshHeight = productDryThick + objExchangeRateConfigsInfo.MMExchangeRateConfigThickValue;
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigThickOperationTypeCombo == ExchangeRateConfigOperationType.Minus.ToString())
                {
                    if (productDryThick > objExchangeRateConfigsInfo.MMExchangeRateConfigThickValue)
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshHeight = productDryThick - objExchangeRateConfigsInfo.MMExchangeRateConfigThickValue;
                    else
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshHeight = 0;
                }
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigThickOperationTypeCombo == ExchangeRateConfigOperationType.Multi.ToString())
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshHeight = productDryThick * objExchangeRateConfigsInfo.MMExchangeRateConfigThickValue;
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigThickOperationTypeCombo == ExchangeRateConfigOperationType.Split.ToString())
                {
                    if (objExchangeRateConfigsInfo.MMExchangeRateConfigThickValue > 0)
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailProductFreshHeight = productDryThick / objExchangeRateConfigsInfo.MMExchangeRateConfigThickValue;
                }
            }

            //Round Wood
            int roundWoodProductGroup = 7;
            objExchangeRateConfigsInfo = objExchangeRateConfigsController.GetExchangeRateConfigSomeCriteria(roundWoodProductGroup, woodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID, string.Empty);
            if (objExchangeRateConfigsInfo != null)
            {

                //Block
                if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Plus.ToString())
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks = productBlocks + objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Minus.ToString())
                {
                    if (productBlocks > objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue)
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks = productBlocks - objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                    else
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks = 0;
                }
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Multi.ToString())
                    woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks = productBlocks * objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                else if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockOperationTypeCombo == ExchangeRateConfigOperationType.Split.ToString())
                {
                    if (objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue > 0)
                        woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks = productBlocks / objExchangeRateConfigsInfo.MMExchangeRateConfigBlockValue;
                }
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks = Math.Round(woodPlanItemDetailsInfo.MMWoodPlanItemDetailRoundWoodBlocks, 5, MidpointRounding.AwayFromZero);
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
            }
            #endregion

        }

        public bool IsReUseItem(int woodTypeID, decimal productLength, decimal productHeight, decimal productWidth, int specialityID)
        {
            MMReuseSpecificateConfigsController objReuseSpecificateConfigsController = new MMReuseSpecificateConfigsController();
            List<MMReuseSpecificateConfigsInfo> ReuseSpecificateConfigList =
                         objReuseSpecificateConfigsController.GetReuseSpecificateConfigSomeCriteria(woodTypeID, productHeight, specialityID);
            if (ReuseSpecificateConfigList != null)
            {
                ReuseSpecificateConfigList = ReuseSpecificateConfigList.Where(x => x.FK_ICProductAttributeWoodTypeID == woodTypeID).ToList();
                if (ReuseSpecificateConfigList != null && ReuseSpecificateConfigList.Count > 0)
                {
                    ReuseSpecificateConfigList = ReuseSpecificateConfigList.Where(x =>                                       //dài
                                                                                             (x.MMReuseSpecificateConfigHeightMax == 0 ?
                                                                                                            x.MMReuseSpecificateConfigHeightMin <= productLength :
                                                                                                             x.MMReuseSpecificateConfigHeightMin <= productLength
                                                                                                             && x.MMReuseSpecificateConfigHeightMax >= productLength)
                                                                                            //Rộng
                                                                                            && (x.MMReuseSpecificateConfigWidthMax == 0 ?
                                                                                                            x.MMReuseSpecificateConfigWidthMin <= productWidth :
                                                                                                             x.MMReuseSpecificateConfigWidthMin <= productWidth
                                                                                                             && x.MMReuseSpecificateConfigWidthMax >= productWidth)
                                                                                     ).ToList();
                }
                if (ReuseSpecificateConfigList != null && ReuseSpecificateConfigList.Count > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void DeleteItemFromList()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;

            if (entity.WoodPlanItemDetailList.CurrentIndex >= 0)
            {
                MMWoodPlanItemDetailsInfo objWoodPlanItemDetail = entity.WoodPlanItemDetailList[entity.WoodPlanItemDetailList.CurrentIndex];
                if (objWoodPlanItemDetail != null)
                {

                    for (int i = 0; i < entity.WoodPlanItemDetailMainList.Count; i++)
                    {
                        if (entity.WoodPlanItemDetailMainList[i].AbstractID == objWoodPlanItemDetail.AbstractID)
                        {
                            entity.WoodPlanItemDetailMainList.RemoveAt(i);
                            break;
                        }
                    }

                }
                entity.WoodPlanItemDetailList.RemoveSelectedRowObjectFromList();
                SetAbstractIDForItemList();
                FocusWoodPlanItemChange();
                SetExtraItemStatus();
            }
        }

        public void AddNewItem(int productID)
        {
            if (productID > 0)
            {
                WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
                int parentID = 0;
                if (entity.WoodPlanItemList.CurrentIndex >= 0)
                {
                    if (entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex] != null)
                    {
                        parentID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].AbstractID;
                    }
                }

                bool isMatchProduct = false;
                foreach (MMWoodPlanItemDetailsInfo objWoodPlanItemDetails in entity.WoodPlanItemDetailMainList)
                {
                    if (objWoodPlanItemDetails.AbstractRefID == parentID && objWoodPlanItemDetails.FK_ICProductID == productID)
                    {
                        MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = new MMWoodPlanItemDetailsInfo();
                        BOSUtil.CopyObject(objWoodPlanItemDetails, objWoodPlanItemDetailsInfo);
                        entity.WoodPlanItemDetailMainList.Add(objWoodPlanItemDetailsInfo);
                        isMatchProduct = true;
                        break;
                    }
                }
                if (!isMatchProduct)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                    if (objProductsInfo != null)
                    {
                        MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = new MMWoodPlanItemDetailsInfo();
                        //Mã chi tiết
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductNo = objProductsInfo.ICProductNo;
                        //Tên chi tiết
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductName = objProductsInfo.ICProductName;
                        //Mô tả
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDesc = objProductsInfo.ICProductDesc;

                        //Dày thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = objProductsInfo.ICProductHeight;
                        //Rộng thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = objProductsInfo.ICProductWidth;
                        //Dài thực tế
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = objProductsInfo.ICProductLength;

                        //ID ref ảo
                        objWoodPlanItemDetailsInfo.AbstractRefID = parentID;
                        objWoodPlanItemDetailsInfo.FK_ICSemiProductID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].FK_ICProductID;
                        objWoodPlanItemDetailsInfo.FK_ICProductForBatchID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].FK_ICProductForBatchID;
                        objWoodPlanItemDetailsInfo.FK_MMBatchProductID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].FK_MMBatchProductID;
                        objWoodPlanItemDetailsInfo.FK_MMBatchProductItemID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].FK_MMBatchProductItemID;
                        objWoodPlanItemDetailsInfo.FK_ICProductAttributeQualityID = entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].FK_ICProductAttributeQualityID;


                        //Thông tin khác
                        objWoodPlanItemDetailsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                        objWoodPlanItemDetailsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                        GetInfoFromOperationDetailPlan(objWoodPlanItemDetailsInfo);
                        MMBatchProductProductionNormItemsController bppniCtrl = new MMBatchProductProductionNormItemsController();
                        MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)bppniCtrl.GetObjectByID(entity.WoodPlanItemList[entity.WoodPlanItemList.CurrentIndex].FK_MMBatchProductProductionNormItemID);
                        if (item == null)
                        {
                            item = new MMBatchProductProductionNormItemsInfo();
                        }
                        CalculateDetailInfo(objWoodPlanItemDetailsInfo, true, item);

                        entity.WoodPlanItemDetailMainList.Add(objWoodPlanItemDetailsInfo);

                    }
                }
                SetAbstractIDForItemList();
                FocusWoodPlanItemChange();
                SetExtraItemStatus();
            }
        }
        public void GetInfoFromOperationDetailPlan(MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo)
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
            if (objWoodPlansInfo.FK_MMOperationDetailPlanID > 0)
            {
                MMOperationDetailPlanItemChildsController objOperationDetailPlanItemChildsController = new MMOperationDetailPlanItemChildsController();
                MMOperationDetailPlanItemChildsInfo objOperationDetailPlanItemChildsInfo = objOperationDetailPlanItemChildsController.GetOperationDetailPlanItemChildBySomeCriteria(objWoodPlansInfo.FK_MMOperationDetailPlanID
                    , objWoodPlanItemDetailsInfo.FK_MMBatchProductID
                    , objWoodPlanItemDetailsInfo.FK_MMBatchProductItemID
                    , objWoodPlanItemDetailsInfo.FK_ICSemiProductID);
                if (objOperationDetailPlanItemChildsInfo != null)
                {
                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailHeight = objOperationDetailPlanItemChildsInfo.MMOperationDetailPlanItemChildProductHeight;
                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailWidth = objOperationDetailPlanItemChildsInfo.MMOperationDetailPlanItemChildProductWidth;
                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailLength = objOperationDetailPlanItemChildsInfo.MMOperationDetailPlanItemChildProductLength;
                    objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailQuantity = objOperationDetailPlanItemChildsInfo.MMOperationDetailPlanItemChildPlanProductQty;

                    if (objOperationDetailPlanItemChildsInfo.FK_MMBatchProductProductionNormItemID > 0)
                    {
                        MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                        MMBatchProductProductionNormItemsInfo BatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(objOperationDetailPlanItemChildsInfo.FK_MMBatchProductProductionNormItemID);
                        if (BatchProductProductionNormItemsInfo != null)
                        {
                            objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailDepreciationRate = BatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemDepreciationRate;
                            objWoodPlanItemDetailsInfo.FK_ICProductAttributeQualityID = BatchProductProductionNormItemsInfo.FK_ICProductAttributeQualityID;
                        }
                        objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailBlocks = objOperationDetailPlanItemChildsInfo.MMOperationDetailPlanItemChildPlanBlock;
                    }
                }
            }
        }

        public void CheckWoodPlan()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
            objWoodPlansInfo.MMWoodPlanStatus = WoodPlanStatus.Validated.ToString();
            entity.UpdateMainObject();
            this.ActionCancel();
        }

        public void ApproveWoodPlan()
        {

            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
            if (objWoodPlansInfo.MMWoodPlanStatus == WoodPlanStatus.Validated.ToString())
            {
                objWoodPlansInfo.MMWoodPlanStatus = WoodPlanStatus.Approved.ToString();
                entity.UpdateMainObject();
                this.ActionCancel();
                return;
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng kiểm tra trước khi duyệt!");
                return;
            }
            List<int> listBatchProductProductionNormItemID = entity.WoodPlanItemList.Select(i => i.FK_MMBatchProductProductionNormItemID).Distinct().ToList();
            string listID = string.Empty;
            listBatchProductProductionNormItemID.ForEach(i => listID += i + ",");
            MMBatchProductProductionNormItemMeterialsController objBPPNICOntroller = new MMBatchProductProductionNormItemMeterialsController();
            List<MMBatchProductProductionNormItemMeterialsInfo> materialList = objBPPNICOntroller.GetListByListBatchProductProductionNormItemID(listID);
            foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailMainList)
            {
                MMBatchProductProductionNormItemMeterialsInfo objmaterialFilter = materialList.Where(i => i.FK_ICProductID == item.FK_ICProductID
                                                                                                     && i.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                                                                     && i.MMBatchProductProductionNormItemMeterialWidth == item.MMWoodPlanItemDetailProductDryWidth
                                                                                                     && i.MMBatchProductProductionNormItemMeterialHeigth == item.MMWoodPlanItemDetailProductDryHeight
                                                                                                     && i.MMBatchProductProductionNormItemMeterialLength == item.MMWoodPlanItemDetailProductDryLength
                                                                                                     && i.MMBatchProductProductionNormItemMeterialQty == item.MMWoodPlanItemDetailMaterialQty).FirstOrDefault();
                if (objmaterialFilter == null)
                {
                    MessageBox.Show("Chi tiết nguyên liệu khác với nguyên liệu trong LSX, vui lòng kiểm tra trước khi duyệt!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ParentScreen.SetEnableOfToolbarButton(CheckWoodPlanToolBar, true);
                    return;
                }
            }
            objWoodPlansInfo.MMWoodPlanStatus = WoodPlanStatus.Approved.ToString();
            entity.UpdateMainObject();
            this.ActionCancel();

        }
        public override void InvalidateToolbar()
        {
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)CurrentModuleEntity.MainObject;

            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton(ApproveToolBar, false);
            ParentScreen.SetEnableOfToolbarButton(CheckWoodPlanToolBar, false);
            ParentScreen.SetEnableOfToolbarButton("Update", false);
            ParentScreen.SetEnableOfToolbarButton(EditAfterComplete, false);
            if (UpdateInventoryStockBOSButtonEdit != null)
                UpdateInventoryStockBOSButtonEdit.Enabled = false;
            if (objWoodPlansInfo.MMWoodPlanID > 0)
            {
                GridView gridView = (GridView)WoodPlanItemDetailsGridControl.MainView;
                InvisibleGrid(gridView);
                GridView gridView1 = (GridView)WoodPlanItemDetailMainsGridControl.MainView;
                InvisibleGrid1(gridView1);
                if (objWoodPlansInfo.MMWoodPlanStatus == WoodPlanStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(ApproveToolBar, true);
                    ParentScreen.SetEnableOfToolbarButton(CheckWoodPlanToolBar, true);
                    ParentScreen.SetEnableOfToolbarButton(EditAfterComplete, false);
                    ParentScreen.SetEnableOfToolbarButton("Update", true);
                }
                else if (objWoodPlansInfo.MMWoodPlanStatus == WoodPlanStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ApproveToolBar, false);
                    //UpdateInventoryStockBOSButtonEdit.Enabled = false;
                    ParentScreen.SetEnableOfToolbarButton(EditAfterComplete, true);

                }
                else if (objWoodPlansInfo.MMWoodPlanStatus == WoodPlanStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ApproveToolBar, true);
                    ParentScreen.SetEnableOfToolbarButton("Update", true);
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ApproveToolBar, false);
                    ParentScreen.SetEnableOfToolbarButton(EditAfterComplete, true);
                }
            }

            base.InvalidateToolbar();
        }
        #endregion
        public void PrintWoodPlan()
        {
            PrintWoodPlan guiPrint = new PrintWoodPlan();
            guiPrint.Module = this;
            guiPrint.ShowDialog();


        }

        private string GetBPPNItemIDString(BOSList<MMWoodPlanItemsInfo> collection)
        {
            string IDs = string.Empty;

            if (collection != null && collection.Count != 0)
            {
                foreach (MMWoodPlanItemsInfo item in collection)
                {
                    if (!string.IsNullOrEmpty(IDs))
                        IDs += ";";
                    IDs += item.FK_MMBatchProductProductionNormItemID;
                }
            }
            return IDs;
        }

        public void SetExtraItemStatus()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            string ids = GetBPPNItemIDString(entity.WoodPlanItemList);
            MMBatchProductProductionNormItemMeterialsController controller = new MMBatchProductProductionNormItemMeterialsController();
            List<MMBatchProductProductionNormItemMeterialsInfo> collection = controller.GetMeterialsByBPPNItemIDs(ids, ";");
            if (collection == null)
                collection = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            foreach (MMWoodPlanItemsInfo item in entity.WoodPlanItemList)
            {

                bool isChanged = false;
                //if (item.MMWoodPlanItemProductNo == "A3S2F3")
                //{

                //    isChanged = true;
                //}
                List<MMWoodPlanItemDetailsInfo> childList = entity.WoodPlanItemDetailMainList.Where(i => i.AbstractRefID == item.AbstractID).ToList();
                var subCollection = collection.Where(c => c.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID);

                MMWoodPlanItemDetailsInfo foundItem = childList.FirstOrDefault(i =>
                                                                    !subCollection.Any(ii => ii.FK_ICProductID == i.FK_ICProductID
                                                                                    && ii.MMBatchProductProductionNormItemMeterialHeigth == i.MMWoodPlanItemDetailProductDryHeight
                                                                                    && ii.MMBatchProductProductionNormItemMeterialWidth == i.MMWoodPlanItemDetailProductDryWidth
                                                                                    && ii.MMBatchProductProductionNormItemMeterialLength == i.MMWoodPlanItemDetailProductDryLength
                                                                                    ));

                MMBatchProductProductionNormItemMeterialsInfo foundItem1 = subCollection.FirstOrDefault(ii =>
                                                                   !childList.Any(i => ii.FK_ICProductID == i.FK_ICProductID
                                                                                   && ii.MMBatchProductProductionNormItemMeterialHeigth == i.MMWoodPlanItemDetailProductDryHeight
                                                                                   && ii.MMBatchProductProductionNormItemMeterialWidth == i.MMWoodPlanItemDetailProductDryWidth
                                                                                   && ii.MMBatchProductProductionNormItemMeterialLength == i.MMWoodPlanItemDetailProductDryLength
                                                                                   ));

                //if (childList != null && childList.Count > 0)
                //{

                //    foreach (MMWoodPlanItemDetailsInfo itemDetail in childList)
                //    {
                //        if (item.FK_ICProductWoodIngredientID != itemDetail.FK_ICProductID)
                //        {
                //            isChanged = true;
                //            break;
                //        }
                //    }
                //}
                //else
                //{
                //    isChanged = true;
                //}
                if (foundItem != null || foundItem1 != null)
                    isChanged = true;

                item.HaveChanged = isChanged;
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

        public void ActionEditAfterComplete()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
            if (Toolbar.IsNullOrNoneAction())
            {
                if (objWoodPlansInfo.MMWoodPlanStatus == WoodPlanStatus.Approved.ToString())
                {
                    decimal Height = 0;
                    guiFilter Filter = new guiFilter();
                    Filter.Module = this;
                    Filter.ShowDialog();
                    if (Filter.DialogResult == DialogResult.OK)
                    {
                        Height = Filter.Height;
                        ActionEdit();

                        MMAllocationPlansController objAllocationPlansController = new MMAllocationPlansController();
                        MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
                        MMWoodPlanItemsController objWoodPlanItemsController = new MMWoodPlanItemsController();
                        List<MMWoodPlanItemsInfo> ListTemp = objWoodPlanItemsController.GetListItemNotInAllocationPlanItems(objWoodPlansInfo.MMWoodPlanID);
                        ListTemp = ListTemp.Where(x => x.MMWoodPlanItemProductHeight == Height).ToList();
                        if (ListTemp == null || ListTemp.Count == 0)
                        {
                            BOSApp.ShowMessage("Không tồn tại dữ liệu cần sửa! Vui lòng kiểm tra lại!");
                            ActionCancel();
                            return;
                        }
                        List<int> abstractIDs = new List<int>();
                        foreach (MMWoodPlanItemsInfo item in ListTemp)
                        {
                            if (entity.WoodPlanItemList.FirstOrDefault(x => x.MMWoodPlanItemID == item.MMWoodPlanItemID) != null)
                            {
                                item.AbstractID = entity.WoodPlanItemList.FirstOrDefault(x => x.MMWoodPlanItemID == item.MMWoodPlanItemID).AbstractID;

                                abstractIDs.Add(item.AbstractID);
                            }
                        }
                        entity.WoodPlanItemList.Clear();
                        entity.WoodPlanItemList.AddRange(ListTemp);

                        List<MMWoodPlanItemDetailsInfo> WoodPlanItemDetailMainListTemp = new List<MMWoodPlanItemDetailsInfo>();
                        foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailMainList)
                        {
                            if (abstractIDs.Contains(item.AbstractRefID))
                            {
                                WoodPlanItemDetailMainListTemp.Add(item);
                            }
                        }
                        entity.WoodPlanItemDetailMainList.Clear();
                        entity.WoodPlanItemDetailMainList.Invalidate(WoodPlanItemDetailMainListTemp);
                        FocusWoodPlanItemChange();
                        //SetExtraProductProperties();
                        SetExtraItemStatus();
                        entity.WoodPlanItemDetailList.GridControl?.RefreshDataSource();
                        entity.WoodPlanItemList.GridControl?.RefreshDataSource();
                        Flag = true;
                    }
                }
            }
        }
        public override int ActionSave()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
            MMWoodPlanItemsController objWoodPlanItemsController = new MMWoodPlanItemsController();
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMWoodPlanItemDetailsInfo> ListPlanItemDetails = new List<MMWoodPlanItemDetailsInfo>();
            MMWoodPlanItemDetailsController objWoodPlanItemDetailsController = new MMWoodPlanItemDetailsController();
            if (objWoodPlansInfo.MMWoodPlanID > 0)
            {
                if (Flag)
                {
                    foreach (MMWoodPlanItemsInfo item in entity.WoodPlanItemList)
                    {
                        foreach (MMWoodPlanItemDetailsInfo itemDetail in entity.WoodPlanItemDetailMainList)
                        {
                            if (itemDetail.MMWoodPlanItemDetailID == 0)
                            {
                                if (itemDetail.AbstractRefID == item.AbstractID)
                                {
                                    itemDetail.FK_MMWoodPlanItemID = item.MMWoodPlanItemID;
                                }
                            }
                        }
                    }
                    //Lấy dữ liệu trước khi sửa
                    ListPlanItemDetails = objWoodPlanItemDetailsController.GetListItemNotInAllocationPlanItems(objWoodPlansInfo.MMWoodPlanID);

                    //Gáng lại Khối tin
                    foreach (MMWoodPlanItemDetailsInfo item in ListPlanItemDetails)
                    {
                        decimal DetailBlocks = 0;
                        if (entity.WoodPlanItemDetailMainList.FirstOrDefault(x => x.MMWoodPlanItemDetailID == item.MMWoodPlanItemDetailID) != null)
                            DetailBlocks = entity.WoodPlanItemDetailMainList.FirstOrDefault(x => x.MMWoodPlanItemDetailID == item.MMWoodPlanItemDetailID).MMWoodPlanItemDetailProductDryBlocks;
                        if (DetailBlocks > 0)
                        {
                            item.MMWoodPlanItemDetailBlocks = DetailBlocks;
                        }

                    }

                    foreach (MMWoodPlanItemDetailsInfo item in entity.WoodPlanItemDetailMainList)
                    {
                        if (ListPlanItemDetails.FirstOrDefault(x => x.MMWoodPlanItemDetailID == item.MMWoodPlanItemDetailID) != null)
                        {
                            item.MMWoodPlanItemDetailProductDryHeightOld = ListPlanItemDetails.FirstOrDefault(x => x.MMWoodPlanItemDetailID == item.MMWoodPlanItemDetailID).MMWoodPlanItemDetailProductDryHeight;
                        }
                        //Lấy khối lượng bên KHSD
                        decimal QtyInAllocationPlanItem = objAllocationPlanItemsController.GetQtyForWoodPlan(item.FK_MMWoodPlanID, item.FK_ICProductID, item.FK_ICProductAttributeWoodTypeID, item.MMWoodPlanItemDetailProductDryHeightOld);
                        decimal DetailBlocksNotEdit = ListPlanItemDetails.Where(x => x.FK_ICProductID == item.FK_ICProductID && x.FK_ICProductAttributeWoodTypeID == item.FK_ICProductAttributeWoodTypeID && x.MMWoodPlanItemDetailProductDryHeight == item.MMWoodPlanItemDetailProductDryHeight).Sum(y => y.MMWoodPlanItemDetailProductDryBlocks);

                        if (DetailBlocksNotEdit < QtyInAllocationPlanItem)
                        {
                            MessageBox.Show("Khối lượng của " + item.MMWoodPlanItemDetailProductNo + " - " + item.MMWoodPlanItemDetailProductName + " không được nhỏ hơn " + QtyInAllocationPlanItem, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }

                    }
                    //entity.WoodPlanItemDetailMainList.SaveItemObjects();
                    entity.WoodPlanItemDetailMainList.SaveItemCDObjects();
                    ActionCancel();
                }
            }
            return base.ActionSave();
        }
        public void ShowBathProduct()
        {
            WoodPlanEntities entity = (WoodPlanEntities)CurrentModuleEntity;
            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)entity.MainObject;
            if (objWoodPlansInfo.MMWoodPlanStatus == WoodPlanStatus.Approved.ToString())
                return;

            guiFilterBatchProduct gui = new guiFilterBatchProduct();
            gui.Module = this;
            gui.ShowDialog();

        }

    }
}
