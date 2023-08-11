using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public class CalculatorProductionNormCostEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset receipt items
        /// </summary>
        public BOSList<MMCalculatorProductionNormCostItemsInfo> CalculatorProductionNormCostItemList { get; set; }
        public BOSList<MMCalculatorProductionNormItemMaterialsInfo> CalculatorProductionNormItemMaterialList { get; set; }
        public BOSTreeList ProductionNormItemList { get; set; }
        public BOSTreeList HardwareList { get; set; }
        public BOSList<MMCalculatorProductionNormItemsInfo> GeneralMaterialList { get; set; }
        public BOSTreeList IngredientPackagingList { get; set; }
        public BOSTreeList PaintList { get; set; }
        #endregion

        #region Constructor
        public CalculatorProductionNormCostEntities()
            : base()
        {
            CalculatorProductionNormCostItemList = new BOSList<MMCalculatorProductionNormCostItemsInfo>();
            ProductionNormItemList = new BOSTreeList();
            CalculatorProductionNormItemMaterialList = new BOSList<MMCalculatorProductionNormItemMaterialsInfo>();
            HardwareList = new BOSTreeList();
            GeneralMaterialList = new BOSList<MMCalculatorProductionNormItemsInfo>();
            IngredientPackagingList = new BOSTreeList();
            PaintList = new BOSTreeList();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMCalculatorProductionNormCostsInfo();
            SearchObject = new MMCalculatorProductionNormCostsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMCalculatorProductionNormCostItemsTableName, new MMCalculatorProductionNormCostItemsInfo());
            ModuleObjects.Add(TableName.MMCalculatorProductionNormItemMaterialsTableName, new MMCalculatorProductionNormItemMaterialsInfo());

        }

        public override void InitModuleObjectList()
        {
            CalculatorProductionNormCostItemList.InitBOSList(this,
                                            TableName.MMCalculatorProductionNormCostsTableName,
                                            TableName.MMCalculatorProductionNormCostItemsTableName,
                                            BOSList<MMCalculatorProductionNormCostItemsInfo>.cstRelationForeign);
            CalculatorProductionNormCostItemList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";

            ProductionNormItemList.InitBOSList(this,
                                                TableName.MMCalculatorProductionNormCostsTableName,
                                                "MMCalculatorProductionNormItems",
                                                BOSTreeList.cstRelationForeign);
            ProductionNormItemList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";

            CalculatorProductionNormItemMaterialList.InitBOSList(this,
                                            TableName.MMCalculatorProductionNormCostsTableName,
                                            TableName.MMCalculatorProductionNormItemMaterialsTableName,
                                            BOSList<MMCalculatorProductionNormItemMaterialsInfo>.cstRelationForeign);
            CalculatorProductionNormItemMaterialList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";

            HardwareList.InitBOSList(this,
                                                TableName.MMCalculatorProductionNormCostsTableName,
                                                "MMCalculatorProductionNormItems",
                                                BOSTreeList.cstRelationForeign);
            HardwareList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";


            GeneralMaterialList.InitBOSList(this,
                                            TableName.MMCalculatorProductionNormCostsTableName,
                                            "MMCalculatorProductionNormItems",
                                            BOSList<MMCalculatorProductionNormItemsInfo>.cstRelationForeign);
            GeneralMaterialList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";

            IngredientPackagingList.InitBOSList(this,
                                                TableName.MMCalculatorProductionNormCostsTableName,
                                                "MMCalculatorProductionNormItems",
                                                BOSTreeList.cstRelationForeign);
            IngredientPackagingList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";

            PaintList.InitBOSList(this,
                                                TableName.MMCalculatorProductionNormCostsTableName,
                                                "MMCalculatorProductionNormItems",
                                                BOSTreeList.cstRelationForeign);
            PaintList.ItemTableForeignKey = "FK_MMCalculatorProductionNormCostID";
        }

        public override void InitGridControlInBOSList()
        {
            CalculatorProductionNormCostItemList.InitBOSListGridControl(CalculatorProductionNormCostModule.CalculatorProductionNormCostItemGridControlName);
            ProductionNormItemList.InitBOSTreeListControl("fld_trlProductionNormItemTreeList");
            CalculatorProductionNormItemMaterialList.InitBOSListGridControl("fld_dgcMMCalculatorProductionNormItemMaterials");
            HardwareList.InitBOSTreeListControl("fld_trlHardwareList");
            GeneralMaterialList.InitBOSListGridControl("fld_dgcGeneralMaterial");
            IngredientPackagingList.InitBOSTreeListControl("fld_trlIngredientPackaging");
            PaintList.InitBOSTreeListControl("fld_trlPaint");

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CalculatorProductionNormCostItemList.SetDefaultListAndRefreshGridControl();
                ProductionNormItemList.SetDefaultListAndRefreshTreeListControl();
                CalculatorProductionNormItemMaterialList.SetDefaultListAndRefreshGridControl();
                HardwareList.SetDefaultListAndRefreshTreeListControl();
                GeneralMaterialList.SetDefaultListAndRefreshGridControl();
                IngredientPackagingList.SetDefaultListAndRefreshTreeListControl();
                PaintList.SetDefaultListAndRefreshTreeListControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {
            CalculatorProductionNormCostItemList.Invalidate(iObjectID);
            InvalidateBOM();
            CalculatorProductionNormItemMaterialList.Invalidate(iObjectID);
            InvalidateHardware();
            InvalidateGeneralMaterial();
            InvalidateIngredientPackaging();
            InvalidatePaint();
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)MainObject;
            // MMCalculatorProductionNormCostItemsController objCalculatorProductionNormCostItemsController = new MMCalculatorProductionNormCostItemsController();
            //if (mainObject.MMCalculatorProductionNormCostID > 0)
            //{
            //    objCalculatorProductionNormCostItemsController.DeleteByForeignColumn("FK_MMCalculatorProductionNormCostID", mainObject.MMCalculatorProductionNormCostID);
            //}
            CalculatorProductionNormCostItemList.SaveItemObjects();

            ProductionNormItemList.SaveItemObjects();

            CalculatorProductionNormItemMaterialList.SaveItemObjects();

            HardwareList.SaveItemObjects();
            GeneralMaterialList.SaveItemObjects();
            IngredientPackagingList.SaveItemObjects();
            RemoveAbstractNote(PaintList);
            PaintList.SaveItemObjects();

            MMCalculatorProductionNormItemsController pniCtrl = new MMCalculatorProductionNormItemsController();
            pniCtrl.UpdateDeleteItemHasParentDelete(mainObject.MMCalculatorProductionNormCostID);
        }

        public void RemoveAbstractNote(BOSTreeList treeList)
        {
            int count = treeList.Count;
            for (int index = count - 1; index >= 0; index--)
            {
                MMCalculatorProductionNormItemsInfo item = treeList[index] as MMCalculatorProductionNormItemsInfo;
                if (item != null && item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMCalculatorProductionNormItemsInfo subItem in item.SubList)
                    {
                        treeList.Add(subItem);
                    }
                    treeList.RemoveAt(index);
                }

            }
        }

        public void ApproveCalculatorProductionNormCost()
        {
            SetPropertyChangeEventLock(false);
            //Update the this's status
            MMCalculatorProductionNormCostsInfo objCalculatorProductionNormCostsInfo = (MMCalculatorProductionNormCostsInfo)MainObject;
            objCalculatorProductionNormCostsInfo.MMCalculatorProductionNormCostStatus = BatchProductPlanStatus.Approved.ToString();
            UpdateMainObject();
        }

        #endregion

        public void InvalidateBOM()
        {
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)MainObject;
            MMCalculatorProductionNormItemsController productItemController = new MMCalculatorProductionNormItemsController();
            List<MMCalculatorProductionNormItemsInfo> collection = productItemController.GetItemByCalculatorProductionNormCostIDandGroup(mainObject.MMCalculatorProductionNormCostID, BatchProductGroup.SemiProduct.ToString());

            ProductionNormItemList.Clear();

            if (collection != null && collection.Any())
            {
                ProductionNormItemList.Invalidate(collection, 0);
            }
            ((CalculatorProductionNormCostModule)Module).RefreshProductItemTreeListView(ProductionNormItemList);
        }


        public void InvalidateHardware()
        {
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)MainObject;
            MMCalculatorProductionNormItemsController productItemController = new MMCalculatorProductionNormItemsController();
            List<MMCalculatorProductionNormItemsInfo> collection = productItemController.GetItemByCalculatorProductionNormCostID(mainObject.MMCalculatorProductionNormCostID, BatchProductGroup.Hardware.ToString());

            HardwareList.Clear();

            if (collection != null && collection.Any())
            {
                HardwareList.Invalidate(collection, 0);
            }
            ((CalculatorProductionNormCostModule)Module).RefreshProductItemTreeListView(HardwareList);
        }

        public void InvalidateIngredientPackaging()
        {
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)MainObject;
            MMCalculatorProductionNormItemsController productItemController = new MMCalculatorProductionNormItemsController();
            List<MMCalculatorProductionNormItemsInfo> collection = productItemController.GetItemByCalculatorProductionNormCostID(mainObject.MMCalculatorProductionNormCostID, ProductType.IngredientPackaging.ToString());

            IngredientPackagingList.Clear();

            if (collection != null && collection.Any())
            {
                IngredientPackagingList.Invalidate(collection, 0);
            }
            ((CalculatorProductionNormCostModule)Module).RefreshProductItemTreeListView(IngredientPackagingList);
        }
        public void InvalidatePaint()
        {
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)MainObject;
            MMCalculatorProductionNormItemsController productItemController = new MMCalculatorProductionNormItemsController();
            List<MMCalculatorProductionNormItemsInfo> collection = productItemController.GetItemByCalculatorProductionNormCostID(mainObject.MMCalculatorProductionNormCostID, ProductType.IngredientPaint.ToString());

            PaintList.Clear();

            if (collection != null && collection.Any())
            {
                PaintList.Invalidate(collection, 0);
            }

            ReDrawPaintTreeList();

            ((CalculatorProductionNormCostModule)Module).RefreshProductItemTreeListView(PaintList);
        }

        public void ReDrawPaintTreeList()
        {
            List<string> keys = new List<string>();

            foreach (MMCalculatorProductionNormItemsInfo item in PaintList)
            {
                if (!keys.Contains(item.MMCalculatorProductionNormItemProductDesc))
                {
                    keys.Add(item.MMCalculatorProductionNormItemProductDesc);
                }
            }

            foreach (string key in keys)
            {
                RebuildTreeList(PaintList, key);
            }
            if (PaintList.TreeListControl.Columns["MMCalculatorProductionNormItemProductName"] != null)
            {
                PaintList.TreeListControl.Columns["MMCalculatorProductionNormItemProductName"].SortOrder = SortOrder.Ascending;
            }
        }

        public void RebuildTreeList(BOSTreeList treeList, string key)
        {
            if (treeList != null)
            {
                MMCalculatorProductionNormItemsInfo parent = new MMCalculatorProductionNormItemsInfo();

                parent.MMCalculatorProductionNormItemProductName = key;
                parent.SubList = new BOSTreeList();
                int count = treeList.Count;
                for (int index = count - 1; index >= 0; index--)
                {
                    MMCalculatorProductionNormItemsInfo subItem = treeList[index] as MMCalculatorProductionNormItemsInfo;
                    if (subItem.MMCalculatorProductionNormItemProductDesc == key)
                    {
                        parent.MMCalculatorProductionNormItemPaint = subItem.MMCalculatorProductionNormItemPaint;
                        parent.SubList.Add(subItem);
                        treeList.RemoveAt(index);
                    }
                }
                treeList.Add(parent);

            }
        }
        public void InvalidateGeneralMaterial()
        {
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)MainObject;
            MMCalculatorProductionNormItemsController productItemController = new MMCalculatorProductionNormItemsController();
            List<MMCalculatorProductionNormItemsInfo> collection = productItemController.GetItemByCalculatorProductionNormCostID(mainObject.MMCalculatorProductionNormCostID, ProductType.GeneralMaterial.ToString());

            GeneralMaterialList.Invalidate(collection);
        }
    }
}
