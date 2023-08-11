using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.WoodPlan
{
    public class WoodPlanEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<MMWoodPlanItemsInfo> WoodPlanItemList { get; set; }
        public BOSList<MMWoodPlanItemDetailsInfo> WoodPlanItemDetailList { get; set; }
        public BOSList<MMWoodPlanItemDetailsInfo> WoodPlanItemDetailMainList { get; set; }
        public BOSTreeList BatchProductProductionNormItemList { get; set; }
        public const string ItemTypeGroup = "Group";
        public const string ItemTypeProduct = "Product";
        public decimal SumBatchProductProductionNormItemBlock { get; set; }
        public decimal SumProductDryBlock { get; set; }
        public decimal SumProductTotalQty { get; set; }
        #endregion

        #region Contructors
        public WoodPlanEntities()
            : base()
        {
            WoodPlanItemList = new BOSList<MMWoodPlanItemsInfo>();
            WoodPlanItemDetailList = new BOSList<MMWoodPlanItemDetailsInfo>();
            WoodPlanItemDetailMainList = new BOSList<MMWoodPlanItemDetailsInfo>();
            BatchProductProductionNormItemList = new BOSTreeList();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMWoodPlansInfo();
            SearchObject = new MMWoodPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMWoodPlanItemsTableName, new MMWoodPlanItemsInfo());
            ModuleObjects.Add(TableName.MMWoodPlanItemDetailsTableName, new MMWoodPlanItemDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            WoodPlanItemList.InitBOSList(
                                        this,
                                        TableName.MMWoodPlansTableName,
                                        TableName.MMWoodPlanItemsTableName,
                                        BOSList<MMWoodPlanItemsInfo>.cstRelationForeign);
            WoodPlanItemList.ItemTableForeignKey = "FK_MMWoodPlanID";

            WoodPlanItemDetailList.InitBOSList(
                                        this,
                                        TableName.MMWoodPlansTableName,
                                        TableName.MMWoodPlanItemDetailsTableName,
                                        BOSList<MMWoodPlanItemDetailsInfo>.cstRelationForeign);
            WoodPlanItemDetailList.ItemTableForeignKey = "FK_MMWoodPlanID";

            WoodPlanItemDetailMainList.InitBOSList(
                                        this,
                                        TableName.MMWoodPlansTableName,
                                        TableName.MMWoodPlanItemDetailsTableName,
                                        BOSList<MMWoodPlanItemDetailsInfo>.cstRelationForeign);
            WoodPlanItemDetailMainList.ItemTableForeignKey = "FK_MMWoodPlanID";
            BatchProductProductionNormItemList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMBatchProductProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            WoodPlanItemList.InitBOSListGridControl("fld_dgcWoodPlans");
            WoodPlanItemDetailList.InitBOSListGridControl("fld_dgcMMWoodPlanItemDetails");
            WoodPlanItemDetailMainList.InitBOSListGridControl("fld_dgcWoodPlanItemDetail");

        }

        public void InvalidateBatchProductProductionNorm()
        {
            //BatchProductProductionNormItemList.InitBOSTreeListControl("fld_trlMMBatchProductProductionNormItems");
            BatchProductProductionNormItemList.Clear();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo;
            List<MMBatchProductProductionNormItemsInfo> itemList = new List<MMBatchProductProductionNormItemsInfo>();
            List<MMBatchProductProductionNormItemsInfo> itemFilterList = new List<MMBatchProductProductionNormItemsInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

            foreach (MMWoodPlanItemsInfo item in WoodPlanItemList)
            {
                objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.FK_MMBatchProductProductionNormItemID);
                if (objBatchProductProductionNormItemsInfo != null)
                {
                    List<MMWoodPlanItemDetailsInfo> itemDetails = WoodPlanItemDetailMainList.Where(e => e.AbstractRefID == item.AbstractID).ToList();
                    foreach (MMWoodPlanItemDetailsInfo subitem in itemDetails)
                    {
                        if (string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMProductDryHeight))
                        {
                            objBatchProductProductionNormItemsInfo.MMProductDryHeight += subitem.MMWoodPlanItemDetailProductDryHeight;
                        }
                        else
                        {
                            objBatchProductProductionNormItemsInfo.MMProductDryHeight += "/" + subitem.MMWoodPlanItemDetailProductDryHeight;
                        }
                        if (!item.MMWoodPlanItemIsReuse)
                        {
                            objBatchProductProductionNormItemsInfo.MMProductDryBlocks += subitem.MMWoodPlanItemDetailProductDryBlocks;
                        }
                        objBatchProductProductionNormItemsInfo.MMProductIsReuse = item.MMWoodPlanItemIsReuse;
                        ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objBatchProductProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
                        if (objProductAttributesInfo != null)
                        {
                            objBatchProductProductionNormItemsInfo.DepartmentValue = objProductAttributesInfo.ICProductAttributeValue;
                        }
                        SumBatchProductProductionNormItemBlock += objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks;
                        SumProductDryBlock += objBatchProductProductionNormItemsInfo.MMProductDryBlocks;

                    }
                    itemList.Add(objBatchProductProductionNormItemsInfo);
                }
            }
            List<int> parentIDs = new List<int>();
            List<MMBatchProductProductionNormItemsInfo> ListCumCTR = new List<MMBatchProductProductionNormItemsInfo>();

            foreach (MMBatchProductProductionNormItemsInfo item in itemList)
            {
                if (!parentIDs.Contains(item.MMBatchProductProductionNormItemParentID))
                {
                    parentIDs.Add(item.MMBatchProductProductionNormItemParentID);
                    List<MMBatchProductProductionNormItemsInfo> bPPNIList
                        = objBatchProductProductionNormItemsController.GetItemTreeListByBatchProductProductionNormID(item.MMBatchProductProductionNormItemParentID);
                    if (bPPNIList != null && bPPNIList.Count > 0)
                    {
                        MMBatchProductProductionNormItemsInfo objParentsInfo = bPPNIList.FirstOrDefault(p => p.ItemType == ItemTypeGroup);
                        MMBatchProductProductionNormItemsInfo objProductsInfo = bPPNIList.FirstOrDefault(p => p.ItemType == ItemTypeProduct);
                        if (objProductsInfo == null)
                        {
                            objProductsInfo = new MMBatchProductProductionNormItemsInfo();

                        }
                        objProductsInfo.SubList = new BOSTreeList();
                        objProductsInfo.ItemType = ItemTypeProduct;
                        objProductsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                        if (objParentsInfo != null)
                        {
                            objParentsInfo.ItemType = ItemTypeGroup;
                            objParentsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                            objParentsInfo.MMBatchProductProductionNormItemID = item.MMBatchProductProductionNormItemParentID;
                            objParentsInfo.SubList = new BOSTreeList();
                            itemFilterList = itemList.Where(i => i.MMBatchProductProductionNormItemParentID == item.MMBatchProductProductionNormItemParentID).ToList();

                            foreach (MMBatchProductProductionNormItemsInfo subItem in itemFilterList)
                            {
                                subItem.MMProductQty = objProductsInfo.MMBatchProductProductionNormItemQuantity;
                                subItem.MMProductTotalQty = subItem.MMBatchProductProductionNormItemQuantity;
                                subItem.MMBatchProductProductionNormItemQuantity = subItem.MMProductTotalQty / subItem.MMProductQty;
                                objParentsInfo.SubList.Add(subItem);
                                SumProductTotalQty += subItem.MMProductTotalQty;
                            }

                            objProductsInfo.SubList.Add(objParentsInfo);
                        }
                        BatchProductProductionNormItemList.Add(objProductsInfo);
                    }
                }
                if (item.MMBatchProductProductionNormItemParentID == 0)
                {
                    int count = 0;
                    count = objBatchProductProductionNormItemsController.GetCountBatchProductProductionNormItemChildByItemID(item.MMBatchProductProductionNormItemID);
                    if (count == 0)
                    {
                        ListCumCTR.Add(item);
                    }
                }
            }
        Stamp:
            int item1Index = 0;

            foreach (MMBatchProductProductionNormItemsInfo item1 in BatchProductProductionNormItemList)
            {
                int item2Index = 0;
                foreach (MMBatchProductProductionNormItemsInfo item2 in BatchProductProductionNormItemList)
                {
                    if (item1Index != item2Index)
                    {
                        if (item2.FK_ICProductForBatchID == item1.FK_ICProductForBatchID)
                        {
                            if (item2.SubList != null && item2.SubList.Count > 0)
                            {

                                foreach (MMBatchProductProductionNormItemsInfo item in item2.SubList)
                                {
                                    if (item1.SubList != null && item1.SubList.Count > 0)
                                    {
                                        item1.SubList.Add(item);
                                    }
                                }
                                BatchProductProductionNormItemList.RemoveAt(item2Index);
                                goto Stamp;
                            }
                        }
                    }
                    item2Index++;
                }
                item1Index++;
            }
            if (ListCumCTR != null && ListCumCTR.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in ListCumCTR)
                {
                    foreach (MMBatchProductProductionNormItemsInfo products in BatchProductProductionNormItemList)
                    {
                        MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                        MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(item.FK_MMBatchProductItemID);
                        if (objBatchProductItemsInfo.FK_ICProductID == products.FK_ICProductForBatchID)
                        {
                            products.SubList.Add(item);
                        }
                    }

                }
            }

            BatchProductProductionNormItemList.TreeListControl.RefreshDataSource();
            BatchProductProductionNormItemList.TreeListControl.ExpandAll();
            BatchProductProductionNormItemList.TreeListControl.BestFitColumns();

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMWoodPlansInfo objWoodPlansInfo = (MMWoodPlansInfo)MainObject;
            objWoodPlansInfo.MMWoodPlanDate = DateTime.Now;
            objWoodPlansInfo.MMWoodPlanStatus = WoodPlanStatus.New.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                WoodPlanItemList.SetDefaultListAndRefreshGridControl();
                WoodPlanItemDetailList.SetDefaultListAndRefreshGridControl();
                WoodPlanItemDetailMainList.SetDefaultListAndRefreshGridControl();
                BatchProductProductionNormItemList.InitBOSTreeListControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities

        public override void InvalidateModuleObjects(int iObjectID)
        {
            //WoodPlanItemList.Invalidate(iObjectID);
            MMWoodPlanItemsController woodPlanItemCtrl = new MMWoodPlanItemsController();
            List<MMWoodPlanItemsInfo> list = woodPlanItemCtrl.GetWoodPlanItemByWoodPlanID(iObjectID);
            WoodPlanItemList.Invalidate(list);
            WoodPlanItemDetailMainList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            MMWoodPlansInfo mainObject = (MMWoodPlansInfo)MainObject;
            WoodPlanItemList.ForEach(o => o.FK_MMWoodPlanID = mainObject.MMWoodPlanID);
            WoodPlanItemList.SaveItemCDObjects();
            foreach (MMWoodPlanItemsInfo item in WoodPlanItemList)
            {
                foreach (MMWoodPlanItemDetailsInfo itemDetail in WoodPlanItemDetailMainList)
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
            WoodPlanItemDetailMainList.SaveItemCDObjects();

            //Update reference BatchPoductNo
            MMBatchProductsController objBPCOn = new MMBatchProductsController();
            objBPCOn.UpdateBatchProductNo(mainObject.MMWoodPlanID);
            UpdateMainObjectBindingSource();
        }

        #endregion Override BaseTransactionEntities


    }
}
