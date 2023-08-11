using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public class CarcassBOMEntities : ERPModuleEntities
    {

        public BOSList<ICProductsForViewIMES> CarrcassList { get; set; }
        public BOSList<ICProductsInfo> ProductList { get; set; }
        public BOSTreeList ProductItemTreeList { get; set; }
        public BOSTreeList ProductionNormItemList { get; set; }
        public BOSTreeList ProductionNormItemHardwareList { get; set; }
        public BOSList<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwareDetailList { get; set; }
        public BOSList<MMProductionNormItemsInfo> GeneralMaterialList { get; set; }
        public BOSList<ICProductPackingDetailsInfo> ICProductPackingDetailsList { get; set; }
        public BOSList<ICProductsInfo> ProductItemList { get; set; }
        public BOSList<ICProductsInfo> ProductInProcessList { get; set; }
        public BOSList<ICProductItemProcesssInfo> PIProcessList { get; set; }
        public BOSList<MMProductionNormItemPackingsInfo> ProductionNormItemPackingList { get; set; }
        public BOSList<MMProductionNormItemsInfo> PackagingNormItemList { get; set; }
        public BOSTreeList ProductionNormItemPaintList { get; set; }
        public BOSTreeList ProductionNormItemPaintPopUpList { get; set; }
        public BOSTreeList ProductionNormItemPackagingList { get; set; }
        public BOSList<MMProductionNormItemsInfo> ProductionNormItemHavePaintList { get; set; }
        public BOSList<MMProfileManagementItemsInfo> ProfileManagementItemList { get; set; }
        #region Constructor
        public CarcassBOMEntities()
            : base()
        {
            CarrcassList = new BOSList<ICProductsForViewIMES>();
            ProductList = new BOSList<ICProductsInfo>();
            ProductItemTreeList = new BOSTreeList();
            ProductionNormItemList = new BOSTreeList();
            ProductionNormItemHardwareList = new BOSTreeList();
            ProductionNormItemHardwareDetailList = new BOSList<MMProductionNormItemHardwaresInfo>();
            GeneralMaterialList = new BOSList<MMProductionNormItemsInfo>();
            ICProductPackingDetailsList = new BOSList<ICProductPackingDetailsInfo>();
            ProductItemList = new BOSList<ICProductsInfo>();
            ProductInProcessList = new BOSList<ICProductsInfo>();
            PIProcessList = new BOSList<ICProductItemProcesssInfo>();
            ProductionNormItemPaintList = new BOSTreeList();
            ProductionNormItemPaintPopUpList = new BOSTreeList();
            ProductionNormItemPackagingList = new BOSTreeList();
            ProductionNormItemHavePaintList = new BOSList<MMProductionNormItemsInfo>();
            ProductionNormItemPackingList = new BOSList<MMProductionNormItemPackingsInfo>();
            PackagingNormItemList = new BOSList<MMProductionNormItemsInfo>();
            ProfileManagementItemList = new BOSList<MMProfileManagementItemsInfo>();
        }

        #endregion
        public override void InitMainObject()
        {
            MainObject = new MMProductionNormsInfo();

        }

        public override void InitModuleObjectList()
        {
            CarrcassList.InitBOSList(this,
                                    string.Empty,
                                    TableName.ICProductsTableName,
                                    BOSList<ICProductsForViewIMES>.cstRelationNone);

            ProductList.InitBOSList(this,
                                        string.Empty,
                                        TableName.ICProductsTableName,
                                        BOSList<ICProductsInfo>.cstRelationNone);

            ProductItemTreeList.InitBOSList(this,
                                                string.Empty,
                                                TableName.ICProductItemsTableName,
                                                BOSTreeList.cstRelationNone);

            ProductionNormItemList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);

            ProductionNormItemHardwareList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);

            ProductionNormItemHardwareDetailList.InitBOSList(this,
                                              TableName.MMProductionNormItemsTableName,
                                              TableName.MMProductionNormItemHardwaresTableName,
                                              BOSList<MMProductionNormItemHardwaresInfo>.cstRelationForeign);
            ProductionNormItemHardwareDetailList.ItemTableForeignKey = "FK_MMProductionNormItemID";

            GeneralMaterialList.InitBOSList(this,
                                              string.Empty,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSList<MMProductionNormItemsInfo>.cstRelationNone);

            ProductionNormItemHavePaintList.InitBOSList(this,
                                              string.Empty,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSList<MMProductionNormItemsInfo>.cstRelationNone);

            ICProductPackingDetailsList.InitBOSList(this,
                                               string.Empty,
                                                TableName.ICProductPackingDetailsTableName,
                                                BOSList<ICProductPackingDetailsInfo>.cstRelationNone);
            ProductItemList.InitBOSList(this,
                                        string.Empty,
                                        TableName.ICProductsTableName,
                                        BOSList<ICProductsInfo>.cstRelationNone);

            ProductInProcessList.InitBOSList(this,
                                        string.Empty,
                                        TableName.ICProductsTableName,
                                        BOSList<ICProductsInfo>.cstRelationNone);
            PIProcessList.InitBOSList(this,
                                        string.Empty,
                                        "ICProductItemProcesss",
                                        BOSList<ICProductItemProcesssInfo>.cstRelationNone);

            ProductionNormItemPaintList.InitBOSList(this,
                                              TableName.MMProductionNormsTableName,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSTreeList.cstRelationForeign);
            ProductionNormItemPaintList.ItemTableForeignKey = "FK_MMProductionNormID";

            ProductionNormItemPaintPopUpList.InitBOSList(this,
                                              string.Empty,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSTreeList.cstRelationNone);

            ProductionNormItemPackagingList.InitBOSList(this,
                                             TableName.MMProductionNormsTableName,
                                             TableName.MMProductionNormItemsTableName,
                                             BOSList<MMProductionNormItemsInfo>.cstRelationNone);
            ProductionNormItemPackagingList.ItemTableForeignKey = "FK_MMProductionNormID";

            ProductionNormItemPackingList.InitBOSList(this,
                                        string.Empty,
                                        "MMProductionNormItemPackings",
                                        BOSList<MMProductionNormItemPackingsInfo>.cstRelationNone);

            PackagingNormItemList.InitBOSList(this,
                                        string.Empty,
                                        "MMProductionNormItems",
                                        BOSList<MMProductionNormItemsInfo>.cstRelationNone);
            ProfileManagementItemList.InitBOSList(this,
                                        string.Empty,
                                        "MMProfileManagementItems",
                                        BOSList<MMProfileManagementItemsInfo>.cstRelationNone);


        }

        public override void InitGridControlInBOSList()
        {
            CarrcassList.InitBOSListGridControl("fld_dgcICProductCarcass");
            ProductList.InitBOSListGridControl("fld_dgcICProducts");
            ProductItemTreeList.InitBOSTreeListControl("fld_trlICProductItems");
            ProductionNormItemList.InitBOSTreeListControl("fld_trlProductionNormItemTreeList");
            ProductionNormItemHardwareList.InitBOSTreeListControl("fld_trlMMProductionNormItemsHardware");
            GeneralMaterialList.InitBOSListGridControl("fld_dgcMMProductionNormItems");
            ICProductPackingDetailsList.InitBOSListGridControl("fld_dgcICProductPackingDetails");
            ProductionNormItemPaintList.InitBOSTreeListControl("fld_trlMMProductionNormItemsPaint");
            ProductionNormItemPackagingList.InitBOSTreeListControl("fld_tlcProctionNormItemPackings");
            ProductionNormItemHavePaintList.InitBOSListGridControl("fld_dgcMMProductionNormItemHavePaint");
            ProfileManagementItemList.InitBOSListGridControl("fld_dgcMMProfileManagementItems");
        }

        public void InvalidateProductItemTreeList()
        {
            ICProductsInfo mainObject = ((CarcassBOMModule)Module).CurrentCarcass;
            ICProductItemsController productItemController = new ICProductItemsController();
            List<ICProductItemsInfo> collection = productItemController.GetProductItemByProductionNormID(mainObject.MMProductionNormID);

            ProductItemTreeList.SetDefaultListAndRefreshTreeListControl();
            ICProductItemsInfo item = new ICProductItemsInfo();

            ProductItemTreeList.Add(item);
            item.SubList = new BOSTreeList();
            object objType = ProductItemTreeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            item.SubList = (BOSTreeList)objType;
            item.SubList.InitBOSList(this, "ICProductItems", "ICProductItems");
            int index = 0;
            if (collection != null && collection.Any())
            {
                InvalidateTreeList(item.SubList, collection, 0, true, ref index, false);
            }
            RefreshProductItemTreeListView(ProductItemTreeList);
        }

        public void InvalidateTreeList(IBOSTreeList treeList, List<ICProductItemsInfo> collection, int parentID, bool sortOrder, ref int startIndex, bool alphaOrder)
        {
            if (treeList != null && collection != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();
                string orderNo = string.Empty;
                foreach (ICProductItemsInfo productItem in collection)
                {
                    if (productItem.ICProductItemParentID == parentID)
                    {

                        ICProductItemsInfo productItem1 = productItem.Clone() as ICProductItemsInfo;
                        productItem1.ICProductItemSortOrder = productItem1.ICProductItemSortOrder;
                        productItem1.BackupObject = productItem1.Clone() as MMProductionNormItemsInfo;
                        treeList.Add(productItem1);
                        if (productItem1.TheNumberOfChild != 0)
                        {
                            //Make the type of sub list same as its parent
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            productItem1.SubList = (BOSTreeList)objType;
                            productItem1.SubList.InitBOSList(this, TableName.ICProductItemsTableName, TableName.ICProductItemsTableName);
                            this.InvalidateTreeList(productItem1.SubList, collection, productItem1.ICProductItemID, true, ref startIndex, false);
                        }
                        productItem1 = productItem.Clone() as ICProductItemsInfo;
                        treeList.OriginalList.Add(productItem1);
                        productItem1 = productItem.Clone() as ICProductItemsInfo;
                        treeList.BackupList.Add(productItem1);
                    }
                }
                startIndex++;
            }

        }

        public void AddChildNode(List<ICProductItemsInfo> collection, ICProductItemsInfo parent)
        {
            //Chi tiết
            ICProductItemsInfo childNode;
            List<ICProductItemsInfo> childList = collection.Where(t => t.ICProductItemParentID == parent.ICProductItemID).ToList();
            if (childList != null && childList.Any())
            {
                parent.SubList = new BOSTreeList();
                object objType = ProductItemTreeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                parent.SubList = (BOSTreeList)objType;
                parent.SubList.InitBOSList(this, "ICProductItems", "ICProductItems");

                childList.ForEach(child =>
                {
                    childNode = child.Clone() as ICProductItemsInfo;
                    parent.SubList.Add(childNode);
                    AddChildNode(collection, childNode);
                });
            }

        }

        public void RefreshProductItemTreeListView(BOSTreeList treelist)
        {
            if (treelist != null && treelist.TreeListControl != null)
            {
                treelist.TreeListControl.RefreshDataSource();
                treelist.TreeListControl.ExpandAll();
                treelist.TreeListControl.BestFitColumns();
            }
        }

        public void InvalidateBOM()
        {
            ICProductsInfo mainObject = ((CarcassBOMModule)Module).CurrentCarcass;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = productItemController.GetItemForGroupByID(mainObject.MMProductionNormID, ProductionNormItemGroup.SemiProduct.ToString());

            ProductionNormItemList.Invalidate(collection, 0);
            RefreshProductItemTreeListView(ProductionNormItemList);
            InvalidateHavePaintList(ProductionNormItemList, true);
        }


        public void InvalidateHavePaintList(IBOSTreeList treeList, bool clear)
        {
            if (clear)
            {
                ProductionNormItemHavePaintList.Clear();
            }

            if (treeList != null)
            {
                foreach (MMProductionNormItemsInfo item in treeList)
                {
                    if (item.MMProductionNormItemHavePaint)
                    {
                        ProductionNormItemHavePaintList.Add(item);
                    }

                    if (item.SubList != null && item.SubList.Any())
                    {
                        InvalidateHavePaintList(item.SubList, false);
                    }
                }
            }

            if (clear)
            {
                ProductionNormItemHavePaintList.GridControl?.RefreshDataSource();
            }
        }



        public void InvalidateBOMHardware()
        {
            ICProductsInfo mainObject = ((CarcassBOMModule)Module).CurrentCarcass;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = productItemController.GetItemForGroupByID(mainObject.MMProductionNormID, ProductionNormItemGroup.Hardware.ToString());
            ProductionNormItemHardwareList.Invalidate(collection, 0);
            RefreshProductItemTreeListView(ProductionNormItemHardwareList);
        }

        public void InvalidateBOMGeneralMaterial()
        {
            ICProductsInfo mainObject = ((CarcassBOMModule)Module).CurrentCarcass;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = productItemController.GetItemForGroupByID(mainObject.MMProductionNormID, ProductionNormItemGroup.GeneralMaterial.ToString());
            GeneralMaterialList.Invalidate(collection);
            GeneralMaterialList.GridControl?.RefreshDataSource();
        }

        public void InvalidatePaint()
        {
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)MainObject;
            MMProductionNormItemsController pniController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> paintList = pniController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.IngredientPaint.ToString(), objProductionNormsInfo.MMProductionNormID);
            int index = 0;
            this.InvalidateTreeList(ProductionNormItemPaintList, paintList, 0, true, ref index, false);
            ReDrawPaintTreeList();
            ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
            ProductionNormItemPaintList.TreeListControl.ExpandAll();
            ProductionNormItemPaintList.TreeListControl.BestFitColumns();
        }
        public void ReDrawPaintTreeList()
        {
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)MainObject;
            List<string> keys = new List<string>();

            List<int> productionNormIDList = new List<int>();

            foreach (MMProductionNormItemsInfo item in ProductionNormItemPaintList)
            {
                if (!productionNormIDList.Contains(item.FK_MMProductionNormItemRefID))
                {
                    productionNormIDList.Add(item.FK_MMProductionNormItemRefID);
                }
            }

            MMProductionNormItemsInfo pnItem;
            MMProductionNormItemsController pnCtrl = new MMProductionNormItemsController();
            foreach (int refID in productionNormIDList)
            {
                pnItem = (MMProductionNormItemsInfo)pnCtrl.GetObjectByID(refID);

                MMProductionNormItemsInfo parent = new MMProductionNormItemsInfo();
                if (refID > 0 && pnItem != null)
                {
                    parent.MMProductionNormItemProductName = pnItem.MMProductionNormItemNo + " - " + pnItem.MMProductionNormItemProductName;
                }
                else
                {
                    parent.MMProductionNormItemProductName = objProductionNormsInfo.MMProductionNormName;
                }
                parent.FK_MMProductionNormItemRefID = refID;
                parent.SubList = new BOSTreeList();

                keys = new List<string>();

                foreach (MMProductionNormItemsInfo item in ProductionNormItemPaintList)
                {
                    if (!keys.Contains(item.MMProductionNormItemProductDesc) && item.FK_MMProductionNormItemRefID == refID)
                    {
                        keys.Add(item.MMProductionNormItemProductDesc);
                    }
                }
                foreach (string key in keys)
                {
                    RebuildTreeListTotal(ProductionNormItemPaintList, key, parent.SubList, refID);
                }

                ProductionNormItemPaintList.Add(parent);
            }
            if (ProductionNormItemPaintList.TreeListControl.Columns["MMProductionNormItemProductName"] != null)
            {
                ProductionNormItemPaintList.TreeListControl.Columns["MMProductionNormItemProductName"].SortOrder = SortOrder.Ascending;
            }
        }

        //public void RebuildTreeList(BOSTreeList treeList, string key)
        //{
        //    if (treeList != null)
        //    {
        //        MMProductionNormItemsInfo parent = new MMProductionNormItemsInfo();
        //        parent.MMProductionNormItemProductName = key;
        //        parent.SubList = new BOSTreeList();
        //        int count = treeList.Count;
        //        for (int index = count - 1; index >= 0; index--)
        //        {
        //            MMProductionNormItemsInfo subItem = treeList[index] as MMProductionNormItemsInfo;
        //            if (subItem.MMProductionNormItemProductDesc == key)
        //            {
        //                parent.MMProductionNormItemPaint = subItem.MMProductionNormItemPaint;
        //                parent.SubList.Add(subItem);
        //                treeList.RemoveAt(index);
        //            }
        //        }
        //        treeList.Add(parent);

        //    }
        //}

        public void RebuildTreeListTotal(BOSTreeList treeList, string key, IBOSTreeList finalTreeList, int refID)
        {
            if (treeList != null)
            {
                MMProductionNormItemsInfo parent = new MMProductionNormItemsInfo();
                parent.MMProductionNormItemProductName = key;
                parent.SubList = new BOSTreeList();
                int count = treeList.Count;
                for (int index = count - 1; index >= 0; index--)
                {
                    MMProductionNormItemsInfo subItem = treeList[index] as MMProductionNormItemsInfo;
                    if (subItem.MMProductionNormItemProductDesc == key
                        && subItem.FK_MMProductionNormItemRefID == refID)
                    {
                        parent.MMProductionNormItemPaint = subItem.MMProductionNormItemPaint;
                        parent.MMProductionNormItemQuantity = subItem.MMProductionNormItemQuantity;
                        parent.MMProductionNormItemTotalQuantity += subItem.MMProductionNormItemQuantity;
                        parent.SubList.Add(subItem);
                        treeList.RemoveAt(index);
                    }
                }
                finalTreeList.Add(parent);

            }
        }

        public void InvalidateTreeList(IBOSTreeList treeList, List<MMProductionNormItemsInfo> collection, int parentID, bool sortOrder, ref int startIndex, bool alphaOrder)
        {
            if (treeList != null && collection != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();
                //int index_orderNo = 1;
                string orderNo = string.Empty;

                foreach (MMProductionNormItemsInfo productionNormItem in collection)
                {
                    if (productionNormItem.MMProductionNormItemParentID == parentID)
                    {

                        MMProductionNormItemsInfo productionNormItem1 = productionNormItem.Clone() as MMProductionNormItemsInfo;
                        productionNormItem1.MMProductionNormItemSortOrderString = productionNormItem1.MMProductionNormItemParentOrderName;
                        productionNormItem1.BackupObject = productionNormItem1.Clone() as MMProductionNormItemsInfo;
                        treeList.Add(productionNormItem1);
                        if (productionNormItem1.TheNumberOfChild != 0)
                        {
                            //Make the type of sub list same as its parent
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            productionNormItem1.SubList = (BOSTreeList)objType;
                            productionNormItem1.SubList.InitBOSList(this, TableName.MMProductionNormItemsTableName, TableName.MMProductionNormItemsTableName);
                            this.InvalidateTreeList(productionNormItem1.SubList, collection, productionNormItem1.MMProductionNormItemID, true, ref startIndex, false);
                        }

                        productionNormItem1 = productionNormItem.Clone() as MMProductionNormItemsInfo;
                        treeList.OriginalList.Add(productionNormItem1);
                        productionNormItem1 = productionNormItem.Clone() as MMProductionNormItemsInfo;
                        treeList.BackupList.Add(productionNormItem1);
                    }
                }
                startIndex++;
            }
        }

        public void InvalidatePackaging()
        {

            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)MainObject;
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.IngredientPackaging.ToString(), objProductionNormsInfo.MMProductionNormID);
            MMProductionNormItemsInfo packaging = new MMProductionNormItemsInfo();
            collection.ForEach(o =>
            {
                o.AbstractID = o.MMProductionNormItemID;
                o.MMProductionNormItemSortOrderString = o.MMProductionNormItemSortOrder.ToString();
                packaging = collection.FirstOrDefault(t => t.MMProductionNormItemID == o.MMProductionNormItemParentID);
                if (packaging != null)
                {
                    o.AbstractParentID = packaging.MMProductionNormItemID;
                    o.MMProductionNormItemSortOrderString = string.Format("{0}.{1}", packaging.MMProductionNormItemSortOrder, o.MMProductionNormItemSortOrder);
                }
            });

            ProductionNormItemPackagingList.Invalidate(collection, 0);
            RefreshProductItemTreeListView(ProductionNormItemPackagingList);
        }
    }
}
