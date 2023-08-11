using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSCommon;
using System.Reflection;
using BOSLib;
//using BOSLib.BOSDbUtil;
using DevExpress.XtraTreeList.Nodes;

namespace BOSERP.Modules.ProductionNorm
{
    public class ProductionNormEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSTreeList ProductionNormItemList { get; set; }
        public BOSTreeList ProductionNormItemHardwareList { get; set; }
        public BOSTreeList ProductionNormItemPackagingList { get; set; }
        public BOSTreeList ProductionNormItemPaintList { get; set; }
        public BOSList<ICInventoryStocksInfo> InventoryStockList { get; set; }
        public BOSList<APSuppliersInfo> SupplierList { get; set; }
        public BOSList<ICProductsInfo> SemiProductList { get; set; }
        public BOSList<ICProductsInfo> SemiProductListParent { get; set; }
        public BOSList<ICProductsInfo> SemiProductListChild { get; set; }
        public BOSList<GEObjectHistoryInfo> ProfileManagementHistoryList { get; set; }
        public BOSList<GEObjectHistoryInfo> SemiProductProfileManagementHistoryList { get; set; }
        public BOSList<GEObjectHistoryInfo> HardwareProfileManagementHistoryList { get; set; }
        public BOSList<GEObjectHistoryInfo> PaintProfileManagementHistoryList { get; set; }
        public BOSList<GEObjectHistoryInfo> PackagingProfileManagementHistoryList { get; set; }
        public BOSList<MMProfileManagementItemsInfo> ProfileManagementItemList { get; set; }
        public BOSList<MMProductionNormItemOperationsInfo> ProductionNormItemOperationList { get; set; }
        public BOSList<MMProductionNormItemMeterialsInfo> ProductionNormItemMeterialList { get; set; }
        public BOSList<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwareDetailList { get; set; }
        public BOSList<MMNormTemplateItemsInfo> NormTemplateItemDataList { get; set; }
        public BOSList<MMNormTemplateItemsInfo> NormTemplateItemList { get; set; }
        public BOSList<MMNormTemplateItemsInfo> NormTemplateItemGroupList { get; set; }
        public BOSList<MMNormTemplateItemsInfo> NormTemplateItemSemiProductList { get; set; }
        public BOSList<ICProductsInfo> ProductList { get; set; }
        public BOSList<ICProductsInfo> ProductItemList { get; set; }
        public BOSList<MMProductionNormItemsInfo> GeneralMaterialList { get; set; }
        public BOSTreeList ProductionNormItemHardwareCarcassList { get; set; }
        public BOSList<MMProductionNormItemsInfo> GeneralMaterialCarcassList { get; set; }
        #endregion

        #region Constructor
        public ProductionNormEntities()
            : base()
        {
            ProductionNormItemList = new BOSTreeList();
            ProductionNormItemHardwareList = new BOSTreeList();
            ProductionNormItemPackagingList = new BOSTreeList();
            ProductionNormItemPaintList = new BOSTreeList();
            InventoryStockList = new BOSList<ICInventoryStocksInfo>();
            SupplierList = new BOSList<APSuppliersInfo>();
            SemiProductList = new BOSList<ICProductsInfo>();
            SemiProductListParent = new BOSList<ICProductsInfo>();
            SemiProductListChild = new BOSList<ICProductsInfo>();
            ProfileManagementHistoryList = new BOSList<GEObjectHistoryInfo>();
            SemiProductProfileManagementHistoryList = new BOSList<GEObjectHistoryInfo>();
            HardwareProfileManagementHistoryList = new BOSList<GEObjectHistoryInfo>();
            PaintProfileManagementHistoryList = new BOSList<GEObjectHistoryInfo>();
            PackagingProfileManagementHistoryList = new BOSList<GEObjectHistoryInfo>();
            ProfileManagementItemList = new BOSList<MMProfileManagementItemsInfo>();
            ProductionNormItemOperationList = new BOSList<MMProductionNormItemOperationsInfo>();
            ProductionNormItemMeterialList = new BOSList<MMProductionNormItemMeterialsInfo>();
            ProductionNormItemHardwareDetailList = new BOSList<MMProductionNormItemHardwaresInfo>();
            NormTemplateItemList = new BOSList<MMNormTemplateItemsInfo>();
            NormTemplateItemGroupList = new BOSList<MMNormTemplateItemsInfo>();
            NormTemplateItemSemiProductList = new BOSList<MMNormTemplateItemsInfo>();
            NormTemplateItemDataList = new BOSList<MMNormTemplateItemsInfo>();
            ProductList = new BOSList<ICProductsInfo>();
            ProductItemList = new BOSList<ICProductsInfo>();
            GeneralMaterialList = new BOSList<MMProductionNormItemsInfo>();
            ProductionNormItemHardwareCarcassList = new BOSTreeList();
            GeneralMaterialCarcassList = new BOSList<MMProductionNormItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)MainObject;
            objProductionNormsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
        }
        public override void DuplicateModuleObjectList()
        {
            ProductionNormItemList.Duplicate();
            ProductionNormItemHardwareList.Duplicate();
            ProductionNormItemPackagingList.Duplicate();
            ProductionNormItemPaintList.Duplicate();
            ProfileManagementItemList.Duplicate();
            GeneralMaterialList.Duplicate();
            NormTemplateItemList.Clear();
            NormTemplateItemGroupList.Clear();
            NormTemplateItemSemiProductList.Clear();
            NormTemplateItemDataList.Clear();

        }
        public override void InitMainObject()
        {
            MainObject = new MMProductionNormsInfo();
            SearchObject = new MMProductionNormsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMProductionNormItemsTableName, new MMProductionNormItemsInfo());
            ModuleObjects.Add(TableName.ICInventoryStocksTableName, new ICInventoryStocksInfo());
            ModuleObjects.Add(TableName.APSuppliersTableName, new APSuppliersInfo());
            ModuleObjects.Add(TableName.MMProfileManagementItemsTableName, new MMProfileManagementItemsInfo());
            ModuleObjects.Add(TableName.MMProductionNormItemOperationsTableName, new MMProductionNormItemOperationsInfo());
            ModuleObjects.Add(TableName.MMProductionNormItemMeterialsTableName, new MMProductionNormItemMeterialsInfo());
            ModuleObjects.Add(TableName.MMProductionNormItemHardwaresTableName, new MMProductionNormItemHardwaresInfo());
            ModuleObjects.Add(TableName.ICProductsTableName, new ICProductsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductionNormItemList.InitBOSList(this,
                                                TableName.MMProductionNormsTableName,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationForeign);
            ProductionNormItemList.ItemTableForeignKey = "FK_MMProductionNormID";
            ProductionNormItemHardwareList.InitBOSList(this,
                                                TableName.MMProductionNormsTableName,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationForeign);
            ProductionNormItemHardwareList.ItemTableForeignKey = "FK_MMProductionNormID";
            ProductionNormItemPackagingList.InitBOSList(this,
                                               TableName.MMProductionNormsTableName,
                                               TableName.MMProductionNormItemsTableName,
                                               BOSTreeList.cstRelationForeign);
            ProductionNormItemPackagingList.ItemTableForeignKey = "FK_MMProductionNormID";
            ProductionNormItemPaintList.InitBOSList(this,
                                              TableName.MMProductionNormsTableName,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSTreeList.cstRelationForeign);
            ProductionNormItemPaintList.ItemTableForeignKey = "FK_MMProductionNormID";

            GeneralMaterialList.InitBOSList(this,
                                              TableName.MMProductionNormsTableName,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSList<MMProductionNormItemsInfo>.cstRelationForeign);
            GeneralMaterialList.ItemTableForeignKey = "FK_MMProductionNormID";
            InventoryStockList.InitBOSList(this,
                                                string.Empty,
                                                TableName.ICInventoryStocksTableName,
                                                BOSList<ICInventoryStocksInfo>.cstRelationNone);
            SupplierList.InitBOSList(this,
                                               string.Empty,
                                               TableName.APSuppliersTableName,
                                               BOSList<APSuppliersInfo>.cstRelationNone);
            SemiProductList.InitBOSList(this,
                                        string.Empty,
                                        TableName.ICProductsTableName,
                                        BOSList<ICProductsInfo>.cstRelationNone);
            SemiProductListParent.InitBOSList(this,
                                       string.Empty,
                                       TableName.ICProductsTableName,
                                       BOSList<ICProductsInfo>.cstRelationNone);
            SemiProductListChild.InitBOSList(this,
                                       string.Empty,
                                       TableName.ICProductsTableName,
                                       BOSList<ICProductsInfo>.cstRelationNone);
            ProfileManagementHistoryList.InitBOSList(this,
                                            string.Empty,
                                            TableName.GEObjectHistoryTableName,
                                            BOSList<GEObjectHistoryInfo>.cstRelationNone);
            SemiProductProfileManagementHistoryList.InitBOSList(this,
                                   string.Empty,
                                   TableName.GEObjectHistoryTableName,
                                   BOSList<GEObjectHistoryInfo>.cstRelationNone);
            HardwareProfileManagementHistoryList.InitBOSList(this,
                                   string.Empty,
                                   TableName.GEObjectHistoryTableName,
                                   BOSList<GEObjectHistoryInfo>.cstRelationNone);
            PaintProfileManagementHistoryList.InitBOSList(this,
                                   string.Empty,
                                   TableName.GEObjectHistoryTableName,
                                   BOSList<GEObjectHistoryInfo>.cstRelationNone);
            PackagingProfileManagementHistoryList.InitBOSList(this,
                                   string.Empty,
                                   TableName.GEObjectHistoryTableName,
                                   BOSList<GEObjectHistoryInfo>.cstRelationNone);
            ProfileManagementItemList.InitBOSList(this,
                                                TableName.MMProductionNormsTableName,
                                                TableName.MMProfileManagementItemsTableName,
                                                BOSList<MMProfileManagementItemsInfo>.cstRelationForeign);
            ProfileManagementItemList.ItemTableForeignKey = "FK_MMProductionNormID";


            ProductionNormItemOperationList.InitBOSList(this,
                                                TableName.MMProductionNormsTableName,
                                                TableName.MMProductionNormItemOperationsTableName,
                                                BOSList<MMProductionNormItemOperationsInfo>.cstRelationForeign);
            ProductionNormItemOperationList.ItemTableForeignKey = "FK_MMProductionNormID";
            ProductionNormItemMeterialList.InitBOSList(this,
                                                TableName.MMProductionNormItemsTableName,
                                                TableName.MMProductionNormItemMeterialsTableName,
                                                BOSList<MMProductionNormItemMeterialsInfo>.cstRelationForeign);
            ProductionNormItemMeterialList.ItemTableForeignKey = "FK_MMProductionNormItemID";

            ProductionNormItemHardwareDetailList.InitBOSList(this,
                                               TableName.MMProductionNormItemsTableName,
                                               TableName.MMProductionNormItemHardwaresTableName,
                                               BOSList<MMProductionNormItemHardwaresInfo>.cstRelationForeign);
            ProductionNormItemHardwareDetailList.ItemTableForeignKey = "FK_MMProductionNormItemID";

            NormTemplateItemList.InitBOSList(this,
                                               string.Empty,
                                               TableName.MMNormTemplatesTableName,
                                               BOSList<MMNormTemplateItemsInfo>.cstRelationNone);
            NormTemplateItemGroupList.InitBOSList(this,
                                               string.Empty,
                                               TableName.MMNormTemplatesTableName,
                                               BOSList<MMNormTemplateItemsInfo>.cstRelationNone);
            NormTemplateItemSemiProductList.InitBOSList(this,
                                               string.Empty,
                                               TableName.MMNormTemplatesTableName,
                                               BOSList<MMNormTemplateItemsInfo>.cstRelationNone);
            NormTemplateItemDataList.InitBOSList(this,
                                               string.Empty,
                                               TableName.MMNormTemplatesTableName,
                                               BOSList<MMNormTemplateItemsInfo>.cstRelationNone);
            ProductList.InitBOSList(this,
                                               string.Empty,
                                               TableName.ICProductsTableName,
                                               BOSList<ICProductsInfo>.cstRelationNone);

            ProductItemList.InitBOSList(this,
                                              string.Empty,
                                              TableName.ICProductsTableName,
                                              BOSList<ICProductsInfo>.cstRelationNone);
            
            ProductionNormItemHardwareCarcassList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);

            GeneralMaterialCarcassList.InitBOSList(this,
                                            string.Empty,
                                            TableName.MMProductionNormItemsTableName,
                                            BOSList<MMProductionNormItemsInfo>.cstRelationNone);
          
        }

        public override void InitGridControlInBOSList()
        {
            ProductionNormItemList.InitBOSTreeListControl();
            ProductionNormItemHardwareList.InitBOSTreeListControl("fld_trlMMProductionNormItemsHardware");
            ProductionNormItemPackagingList.InitBOSTreeListControl("fld_trlMMProductionNormItemsPackaging");
            ProductionNormItemPaintList.InitBOSTreeListControl("fld_trlMMProductionNormItemsPaint");
            InventoryStockList.InitBOSListGridControl();
            SupplierList.InitBOSListGridControl();
            ProfileManagementHistoryList.InitBOSListGridControl("fld_dgcHistoryGeneral");
            SemiProductProfileManagementHistoryList.InitBOSListGridControl("fld_dgcHistorySemiProduct");
            HardwareProfileManagementHistoryList.InitBOSListGridControl("fld_dgcHistoryHardware");
            PaintProfileManagementHistoryList.InitBOSListGridControl("fld_dgcHistoryPaint");
            PackagingProfileManagementHistoryList.InitBOSListGridControl("fld_dgcHistoryPackaging");
            ProfileManagementItemList.InitBOSListGridControl();

            ProductionNormItemOperationList.InitBOSListGridControl("fld_dgcProductionNormItemOperations");
            NormTemplateItemList.InitBOSListGridControl("fld_dgcMMNormTemplateItems");
            NormTemplateItemGroupList.InitBOSListGridControl("fld_dgcMMNormTemplateItemGroups");
            NormTemplateItemSemiProductList.InitBOSListGridControl("fld_dgcMMNormTemplateItemSemiProducts");
            ProductList.InitBOSListGridControl();
            GeneralMaterialList.InitBOSListGridControl("fld_dgcMMProductionNormItems");
            ProductionNormItemHardwareCarcassList.InitBOSTreeListControl("fld_trlMMProductionNormItemsHardwareCarcass");
            GeneralMaterialCarcassList.InitBOSListGridControl("fld_dgcMMProductionNormItemCarcass");

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductionNormItemList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemHardwareList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemPackagingList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemPaintList.SetDefaultListAndRefreshTreeListControl();
                ProfileManagementHistoryList.SetDefaultListAndRefreshGridControl();
                SemiProductProfileManagementHistoryList.SetDefaultListAndRefreshGridControl();
                PaintProfileManagementHistoryList.SetDefaultListAndRefreshGridControl();
                HardwareProfileManagementHistoryList.SetDefaultListAndRefreshGridControl();
                PackagingProfileManagementHistoryList.SetDefaultListAndRefreshGridControl();
                ProfileManagementItemList.SetDefaultListAndRefreshGridControl();
                ProductionNormItemOperationList.SetDefaultListAndRefreshGridControl();
                NormTemplateItemList.SetDefaultListAndRefreshGridControl();
                NormTemplateItemGroupList.SetDefaultListAndRefreshGridControl();
                NormTemplateItemSemiProductList.SetDefaultListAndRefreshGridControl();
                ProductList.SetDefaultListAndRefreshGridControl();
                GeneralMaterialList.SetDefaultListAndRefreshGridControl();
                ProductionNormItemHardwareCarcassList.SetDefaultListAndRefreshTreeListControl();
                GeneralMaterialCarcassList.SetDefaultListAndRefreshGridControl();
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
            ProductionNormItemOperationList.Invalidate(iObjectID);
            MMProductionNormItemsController objItemsController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> gMaterialList = objItemsController.GetProductionNormItemsByGroupTypeAndProductionNormID(ProductType.GeneralMaterial.ToString(), iObjectID);
            GeneralMaterialList.Invalidate(gMaterialList);

            ((ProductionNormModule)Module).InvalidateBOMGeneralMaterial();

            NormTemplateItemList.Clear();
            NormTemplateItemGroupList.Clear();
            NormTemplateItemSemiProductList.Clear();
            NormTemplateItemDataList.Clear();
        }

        
        #endregion


        #region Save Module Objects functions
        public void RemoveAbstractNote(BOSTreeList treeList)
        {
            int count = treeList.Count;
            for (int index = count - 1; index >= 0; index--)
            {
                MMProductionNormItemsInfo item = treeList[index] as MMProductionNormItemsInfo;
                if (item != null && item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo subItem in item.SubList)
                    {
                        treeList.Add(subItem);
                    }
                    treeList.RemoveAt(index);
                }

            }
        }

        public override void SaveModuleObjects()
        {
            if (!((ProductionNormModule)Module).IsCoppyVersion && !((ProductionNormModule)Module).IsDupplicate)
            {
                //if (((ProductionNormModule)Module).HaveFocusWood)
                //{
                //    ProductionNormItemList.SaveItemObjects();
                //}
                if (((ProductionNormModule)Module).HaveFocusHardware)
                {
                    ProductionNormItemHardwareList.SaveItemObjects();
                }
                if (((ProductionNormModule)Module).HaveFocusPackaging)
                {
                    ProductionNormItemPackagingList.SaveItemObjects();
                }
                if (((ProductionNormModule)Module).HaveFocusPaint)
                {
                    RemoveAbstractNote(ProductionNormItemPaintList);
                    ProductionNormItemPaintList.SaveItemObjects();
                }
                if (((ProductionNormModule)Module).HaveFocusGeneralMaterial)
                {
                    GeneralMaterialList.SaveItemObjects();
                }
            }
            else
            {
                //ProductionNormItemList.SaveItemObjects();
                ProductionNormItemHardwareList.SaveItemObjects();
                ProductionNormItemPackagingList.SaveItemObjects();
                ProductionNormItemPaintList.SaveItemObjects();
                GeneralMaterialList.SaveItemObjects();
            }
            //ProfileManagementHistoryList.SaveItemObjects();
            ProfileManagementItemList.SaveItemObjects();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)MainObject;
            if (objProductionNormsInfo.MMProductionNormWoodStatus != MMProductionNormStatus.New.ToString())
                ((ProductionNormModule)Module).SaveProductionNormOperation();

            //Save history
            ((ProductionNormModule)Module).GetCreateHistory(ProductionNormItemList);
            ((ProductionNormModule)Module).GetCreateHistory(ProductionNormItemHardwareList);
            ((ProductionNormModule)Module).GetCreateHistory(ProductionNormItemPackagingList);
            ((ProductionNormModule)Module).GetCreateHistory(ProductionNormItemPaintList);
            ((ProductionNormModule)Module).SaveObjectHistory();

        }
        public void CheckDeleteAndUpdateRootNote(BOSTreeList ProductionNormItemList)
        {
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> listSave = new List<MMProductionNormItemsInfo>();
            List<MMProductionNormItemsInfo> listBackup = new List<MMProductionNormItemsInfo>();
            ProductionNormItemList.ConvertToList(listSave);
            foreach (MMProductionNormItemsInfo item in ProductionNormItemList.BackupList)
            {
                MMProductionNormItemsInfo checkItem = listSave.Where(x => x.MMProductionNormItemID == item.MMProductionNormItemID && x.MMProductionNormItemNo == item.MMProductionNormItemNo).FirstOrDefault();
                if (checkItem == null && item.MMProductionNormItemID > 0)
                {
                    objProductionNormItemsController.DeleteProductionNormItemByParentID(item.MMProductionNormItemID, BOSApp.CurrentUsersInfo.ADUserName);
                }
            }
        }
        #endregion

        public virtual void SaveChangeSemiProduct(MMProductionNormItemsInfo oldObject, MMProductionNormItemsInfo newObject)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductItemsController objProductItemsController = new ICProductItemsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(oldObject.FK_ICProductID);
            bool isChange = false;
            if (oldObject != null && newObject != null && objProductsInfo != null)
            {
                
                if (oldObject.MMProductionNormItemProductWoodType != newObject.MMProductionNormItemProductWoodType)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(oldObject.FK_ICProductID);
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)
                        objProductAttributesController.GetProductAttributesByGroupAndValue(MatchCodeConst.MatchCodeWoodTypeColumnName, newObject.MMProductionNormItemProductWoodType);
                    if (objProductAttributesInfo != null)
                    {
                        objProductsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo.ICProductAttributeID;
                        isChange = true;
                    }
                }
                if (oldObject.FK_ICProductAttributeSpecialityID != newObject.FK_ICProductAttributeSpecialityID)
                {
                    objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID = newObject.FK_ICProductAttributeSpecialityID;
                    isChange = true;
                }
                //if (oldObject.FK_ICProductAttributeQualityID != newObject.FK_ICProductAttributeQualityID)
                //{
                //    objProductsInfo.FK_ICProductAttributeQualityID = newObject.FK_ICProductAttributeQualityID;
                //    isChange = true;
                //}
                if (oldObject.MMProductionNormItemProductLength != newObject.MMProductionNormItemProductLength)
                {
                    objProductsInfo.ICProductLength = newObject.MMProductionNormItemProductLength;
                    isChange = true;
                }
                if (oldObject.MMProductionNormItemProductWidth != newObject.MMProductionNormItemProductWidth)
                {
                    objProductsInfo.ICProductWidth = newObject.MMProductionNormItemProductWidth;
                    isChange = true;
                }
                if (oldObject.MMProductionNormItemProductHeight != newObject.MMProductionNormItemProductHeight)
                {
                    objProductsInfo.ICProductHeight = newObject.MMProductionNormItemProductHeight;
                    isChange = true;
                }
                if (isChange)
                {
                    objProductsController.UpdateObject(objProductsInfo);
                }
                if (oldObject.MMProductionNormItemQuantity != newObject.MMProductionNormItemQuantity)
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemsInfo =  (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(oldObject.MMProductionNormItemParentID);
                    if (objProductionNormItemsInfo != null)
                    {
                        ICProductItemsInfo objProductItemsInfo = (ICProductItemsInfo)objProductItemsController.GetProductItemByParentIDAndChildID(objProductionNormItemsInfo.FK_ICProductID, oldObject.FK_ICProductID);
                        if (objProductItemsInfo != null)
                        {
                            objProductItemsInfo.ICProductItemQty = newObject.MMProductionNormItemQuantity;
                            objProductItemsController.UpdateObject(objProductItemsInfo);
                        }
                    }
                }
            }
        }

        

    }
}
