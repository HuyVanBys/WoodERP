using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.DeliveryPlan
{
    public class DeliveryPlanEntities : BaseTransactionEntities
    {
        #region Declare Constant

        public const string GoogleApiKey = "AIzaSyBEibktv7Y_NYCCijnajWX1Wj_E_73G9TQ";

        public const string GoogleApiUrl = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}";
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties

        public BOSList<ARDeliveryPlanItemsInfo> ARDeliveryPlanItemsList { get; set; }

        public BOSList<ARDeliveryPlanTrucksInfo> ARDeliveryPlanTrucksList { get; set; }

        public BOSList<ARDeliveryPlanWorksInfo> ARDeliveryPlanWorksList { get; set; }

        public BOSList<ARDeliveryPlanWorksInfo> ARDeliveryPlanWorkAssetsList { get; set; }

        public BOSList<ARDeliveryPlanWorksInfo> ARDeliveryPlanWorkMaterialsList { get; set; }

        public BOSList<ARDeliveryPlanTruckPointsInfo> DeliveryPlanTruckPointsList { get; set; }

        public List<ARDeliveryPlanTruckItemsInfo> DeliveryPlanTruckItemsList { get; set; }

        public BOSList<PMTasksInfo> PMTasksList { get; set; }
        #endregion

        #region Constructor
        public DeliveryPlanEntities()
            : base()
        {
            ARDeliveryPlanItemsList = new BOSList<ARDeliveryPlanItemsInfo>();
            ARDeliveryPlanTrucksList = new BOSList<ARDeliveryPlanTrucksInfo>();
            ARDeliveryPlanWorksList = new BOSList<ARDeliveryPlanWorksInfo>();
            DeliveryPlanTruckPointsList = new BOSList<ARDeliveryPlanTruckPointsInfo>();
            ARDeliveryPlanWorkAssetsList = new BOSList<ARDeliveryPlanWorksInfo>();
            ARDeliveryPlanWorkMaterialsList = new BOSList<ARDeliveryPlanWorksInfo>();
            PMTasksList = new BOSList<PMTasksInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARDeliveryPlansInfo();
            SearchObject = new ARDeliveryPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARDeliveryPlanItemsTableName, new ARDeliveryPlanItemsInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanTrucksTableName, new ARDeliveryPlanTrucksInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanWorksTableName, new ARDeliveryPlanWorksInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanTruckPointsTableName, new ARDeliveryPlanTruckPointsInfo());
            ModuleObjects.Add(TableName.PMTasksTableName, new PMTasksInfo());
        }

        public override void InitModuleObjectList()
        {
            ARDeliveryPlanItemsList.InitBOSList(this,
                                               TableName.ARDeliveryPlansTableName,
                                               TableName.ARDeliveryPlanItemsTableName,
                                               BOSList<ARDeliveryPlanItemsInfo>.cstRelationForeign);
            ARDeliveryPlanItemsList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            ARDeliveryPlanTrucksList.InitBOSList(this,
                                               TableName.ARDeliveryPlansTableName,
                                               TableName.ARDeliveryPlanTrucksTableName,
                                               BOSList<ARDeliveryPlanTrucksInfo>.cstRelationForeign);
            ARDeliveryPlanTrucksList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            ARDeliveryPlanWorksList.InitBOSList(this,
                                               TableName.ARDeliveryPlansTableName,
                                               TableName.ARDeliveryPlanWorksTableName,
                                               BOSList<ARDeliveryPlanWorksInfo>.cstRelationForeign);
            ARDeliveryPlanWorksList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            DeliveryPlanTruckPointsList.InitBOSList(this,
                                              TableName.ARDeliveryPlansTableName,
                                              TableName.ARDeliveryPlanTruckPointsTableName,
                                              BOSList<ARDeliveryPlanTruckPointsInfo>.cstRelationForeign);
            DeliveryPlanTruckPointsList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            PMTasksList.InitBOSList(this,
                                              TableName.ARDeliveryPlansTableName,
                                              TableName.PMTasksTableName,
                                              BOSList<PMTasksInfo>.cstRelationForeign);
            PMTasksList.ItemTableForeignKey = "FK_ObjectID";

            ARDeliveryPlanWorkAssetsList.InitBOSList(this,
                                              TableName.ARDeliveryPlansTableName,
                                              TableName.ARDeliveryPlanWorksTableName,
                                              BOSList<ARDeliveryPlanWorksInfo>.cstRelationForeign);
            ARDeliveryPlanWorkAssetsList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            ARDeliveryPlanWorkMaterialsList.InitBOSList(this,
                                              TableName.ARDeliveryPlansTableName,
                                              TableName.ARDeliveryPlanWorksTableName,
                                              BOSList<ARDeliveryPlanWorksInfo>.cstRelationForeign);
            ARDeliveryPlanWorkMaterialsList.ItemTableForeignKey = "FK_ARDeliveryPlanID";
        }

        public override void InitGridControlInBOSList()
        {
            ARDeliveryPlanItemsList.InitBOSListGridControl(DeliveryPlanModule.ARDeliveryPlanItemsGridControlName);
            ARDeliveryPlanTrucksList.InitBOSListGridControl(DeliveryPlanModule.ARDeliveryPlanTrucksGridControlName);
            ARDeliveryPlanWorksList.InitBOSListGridControl(DeliveryPlanModule.ARDeliveryPlanWorksGridControlName);
            DeliveryPlanTruckPointsList.InitBOSListGridControl(DeliveryPlanModule.ARDeliveryPlanTruckPointsGridControlName);
            PMTasksList.InitBOSListGridControl(DeliveryPlanModule.PMTaskSumarysGridControlName);
            ARDeliveryPlanWorkAssetsList.InitBOSListGridControl(DeliveryPlanModule.ARDeliveryPlanWorkAssetsGridControlName);
            ARDeliveryPlanWorkMaterialsList.InitBOSListGridControl(DeliveryPlanModule.ARDeliveryPlanWorkMaterialsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            ARDeliveryPlanItemsList.SetDefaultListAndRefreshGridControl();
            ARDeliveryPlanTrucksList.SetDefaultListAndRefreshGridControl();
            ARDeliveryPlanWorksList.SetDefaultListAndRefreshGridControl();
            DeliveryPlanTruckPointsList.SetDefaultListAndRefreshGridControl();
            PMTasksList.SetDefaultListAndRefreshGridControl();
            ARDeliveryPlanWorkAssetsList.SetDefaultListAndRefreshGridControl();
            ARDeliveryPlanWorkMaterialsList.SetDefaultListAndRefreshGridControl();
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            mainObject.ARDeliveryPlanDate = BOSApp.GetCurrentServerDate();
            mainObject.ARDeliveryPlanStatus = DeliveryPlanStatus.New.ToString();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.ARDeliveryPlanComment = new byte[0];
        }

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {

            ARDeliveryPlanTrucksList.Invalidate(iObjectID);

            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            ARDeliveryPlanItemsList.Invalidate(objDeliveryPlanItemsController.GetDeliveryPlanItemByDeliveryPlanID(iObjectID));

            ARDeliveryPlanWorksController objDeliveryPlanWorksController = new ARDeliveryPlanWorksController();
            List<ARDeliveryPlanWorksInfo> deliveryPlanWorks = objDeliveryPlanWorksController.GetDeliveryPlanWorksByDeliveryPlanID(iObjectID);

            ARDeliveryPlanWorksList.Invalidate(deliveryPlanWorks.Where(o => o.ARDeliveryPlanWorkProductType == SaleOrderItemWorkProductType.Work.ToString()).ToList());
            ARDeliveryPlanWorkAssetsList.Invalidate(deliveryPlanWorks.Where(o => o.ARDeliveryPlanWorkProductType == SaleOrderItemWorkProductType.Asset.ToString()).ToList());
            ARDeliveryPlanWorkMaterialsList.Invalidate(deliveryPlanWorks.Where(o => o.ARDeliveryPlanWorkProductType == SaleOrderItemWorkProductType.Material.ToString()).ToList());

            PMTasksController objPMTasksController = new PMTasksController();
            PMTasksList.Invalidate(objPMTasksController.GetTasksByDeliveryPlanID(iObjectID));

            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            DeliveryPlanTruckItemsList = new List<ARDeliveryPlanTruckItemsInfo>();
            DeliveryPlanTruckItemsList = objDeliveryPlanTruckItemsController.GetDeliveryPlanTruckItemsByDeliveryPlanID(iObjectID);

            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
            List<ARDeliveryPlanTruckPointsInfo> deliveryPlanTruckPointsList = objDeliveryPlanTruckPointsController.GetDeliveryPlanTruckPointsByDeliveryPlanID(iObjectID);
            deliveryPlanTruckPointsList.ForEach(o =>
            {
                ARDeliveryPlanTruckItemsInfo objDeliveryPlanTruckItemsInfo = DeliveryPlanTruckItemsList.FirstOrDefault(y => y.FK_ARDeliveryPlanTruckPointID == o.ARDeliveryPlanTruckPointID);
                if (objDeliveryPlanTruckItemsInfo != null)
                {
                    ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList
                    .FirstOrDefault(x => x.FK_ARSaleOrderItemID == objDeliveryPlanTruckItemsInfo.FK_ARSaleOrderItemID);
                    if (objDeliveryPlanItemsInfo != null)
                    {
                        o.ARDeliveryPlanTruckPointCustomerName = objDeliveryPlanItemsInfo.ACObjectName;
                    }
                }
            });
            DeliveryPlanTruckPointsList.Invalidate(deliveryPlanTruckPointsList);

            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                if (o.DeliveryPlanTruckItemsList == null)
                    o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                o.DeliveryPlanTruckItemsList.Invalidate(DeliveryPlanTruckItemsList.Where(x => x.FK_ARDeliveryPlanTruckID == o.ARDeliveryPlanTruckID).ToList());
                if (o.DeliveryPlanTruckPointsList == null)
                    o.DeliveryPlanTruckPointsList = new BOSList<ARDeliveryPlanTruckPointsInfo>(TableName.ARDeliveryPlanTruckPointsTableName);
                o.DeliveryPlanTruckPointsList.Invalidate(deliveryPlanTruckPointsList.Where(x => x.FK_ARDeliveryPlanTruckID == o.ARDeliveryPlanTruckID).ToList());
            });

            ARDeliveryPlanWorksList.ForEach(o =>
            {
                if (o.DeliveryPlanWorkAssetsList == null)
                    o.DeliveryPlanWorkAssetsList = new BOSList<ARDeliveryPlanWorksInfo>(TableName.ARDeliveryPlanWorksTableName);
                o.DeliveryPlanWorkAssetsList.Invalidate(ARDeliveryPlanWorkAssetsList.Where(x => x.ARDeliveryPlanWorkParentID == o.ARDeliveryPlanWorkID).ToList());
                if (o.DeliveryPlanWorkMaterialsList == null)
                    o.DeliveryPlanWorkMaterialsList = new BOSList<ARDeliveryPlanWorksInfo>(TableName.ARDeliveryPlanWorksTableName);
                o.DeliveryPlanWorkMaterialsList.Invalidate(ARDeliveryPlanWorkMaterialsList.Where(x => x.ARDeliveryPlanWorkParentID == o.ARDeliveryPlanWorkID).ToList());
                if (o.TasksList == null)
                    o.TasksList = new BOSList<PMTasksInfo>(TableName.PMTasksTableName);
                o.TasksList.Invalidate(PMTasksList.Where(x => x.FK_Object01ID == o.ARDeliveryPlanWorkID).ToList());
            });
        }

        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ARDeliveryPlanItemsList.ForEach(o =>
            {
                if (o.ARDeliveryPlanItemID == 0)
                    o.FK_ARDeliveryPlanID = 0;
            });
            ARDeliveryPlanItemsList.SaveItemObjects();
            ARDeliveryPlanWorksList.SaveItemObjects();
            ARDeliveryPlanWorksList.ForEach(o =>
            {
                if (o.TasksList != null && o.TasksList.Count > 0)
                {
                    o.TasksList.All(x =>
                    {
                        x.FK_ObjectID = o.FK_ARDeliveryPlanID;
                        x.FK_Object01ID = o.ARDeliveryPlanWorkID;
                        return true;
                    });
                    o.TasksList.SaveItemObjects();
                    o.TasksList.All(x =>
                    {
                        if (x.TaskAssignsList == null)
                        {
                            x.TaskAssignsList = new BOSList<PMTaskAssignsInfo>(TableName.PMTaskAssignsTableName);
                        }

                        PMTaskAssignsInfo objTaskAssignsInfo = new PMTaskAssignsInfo
                        {
                            FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                            FK_PMTaskID = x.PMTaskID,
                            FK_ICMeasureUnitID = x.FK_ICMeasureUnitID,
                            FK_HRDepartmentID = x.FK_HRDepartmentID,
                            FK_HRDepartmentRoomID = x.FK_HRDepartmentRoomID,
                            FK_HREmployeeID = x.FK_HREmployeeID,
                            PMTaskAssignStatus = x.PMTaskStatus,
                        };
                        x.TaskAssignsList.Add(objTaskAssignsInfo);
                        x.TaskAssignsList.SaveItemObjects();
                        return true;
                    });
                }

                if (o.DeliveryPlanWorkAssetsList != null && o.DeliveryPlanWorkAssetsList.Count > 0)
                {
                    o.DeliveryPlanWorkAssetsList.All(x =>
                    {
                        x.FK_ARDeliveryPlanID = o.FK_ARDeliveryPlanID;
                        x.ARDeliveryPlanWorkParentID = o.ARDeliveryPlanWorkID;
                        return true;
                    });
                    o.DeliveryPlanWorkAssetsList.SaveItemObjects();
                }

                if (o.DeliveryPlanWorkMaterialsList != null && o.DeliveryPlanWorkMaterialsList.Count > 0)
                {
                    o.DeliveryPlanWorkMaterialsList.All(x =>
                    {
                        x.FK_ARDeliveryPlanID = o.FK_ARDeliveryPlanID;
                        x.ARDeliveryPlanWorkParentID = o.ARDeliveryPlanWorkID;
                        return true;
                    });
                    o.DeliveryPlanWorkMaterialsList.SaveItemObjects();
                }
            });
            ARDeliveryPlanWorkAssetsList.All(o =>
            {
                if (o.ARDeliveryPlanWorkParentID == 0)
                    return true;
                else
                    return false;
            });
            ARDeliveryPlanWorkAssetsList.SaveItemObjects();

            ARDeliveryPlanWorkMaterialsList.All(o =>
            {
                if (o.ARDeliveryPlanWorkParentID == 0)
                    return true;
                else
                    return false;
            });
            ARDeliveryPlanWorkMaterialsList.SaveItemObjects();

            ARDeliveryPlanTrucksList.SaveItemObjects();
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                if (o.DeliveryPlanTruckPointsList != null && o.DeliveryPlanTruckPointsList.Count > 0)
                {
                    if (o.DeliveryPlanTruckPointsList.Any(x => x.ARDeliveryPlanTruckPointID == 0))
                        objDeliveryPlanTruckPointsController.DeleteDeliveryPlanTruckPointsByDeliveryPlanTruckID(o.ARDeliveryPlanTruckID);
                    o.DeliveryPlanTruckPointsList.All(p =>
                    {
                        p.FK_ARDeliveryPlanTruckID = o.ARDeliveryPlanTruckID;
                        p.FK_ARDeliveryPlanID = o.FK_ARDeliveryPlanID;

                        return true;
                    });
                    o.DeliveryPlanTruckPointsList.SaveItemObjects();
                }
                if (o.DeliveryPlanTruckItemsList != null && o.DeliveryPlanTruckItemsList.Count > 0)
                {
                    if (o.DeliveryPlanTruckItemsList.Any(x => x.ARDeliveryPlanTruckItemID == 0))
                        objDeliveryPlanTruckItemsController.DeleteDeliveryPlanTruckItemsByDeliveryPlanTruckID(o.ARDeliveryPlanTruckID);
                    o.DeliveryPlanTruckItemsList.All(s =>
                    {
                        ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList.FirstOrDefault(x => x.FK_ARSaleOrderItemID == s.FK_ARSaleOrderItemID);
                        s.FK_ARDeliveryPlanID = objDeliveryPlanItemsInfo.FK_ARDeliveryPlanID;
                        s.FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID;
                        s.FK_ARDeliveryPlanTruckID = o.ARDeliveryPlanTruckID;
                        s.FK_ARDeliveryPlanTruckPointID = o.DeliveryPlanTruckPointsList.Where(x => x.ARDeliveryPlanTruckPointAddress == objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress)
                                                                                        .FirstOrDefault().ARDeliveryPlanTruckPointID;
                        return true;
                    });
                    o.DeliveryPlanTruckItemsList.SaveItemObjects();
                }
            });
        }
        #endregion

        public void GenarateDeliveryPlanItems(List<ARSaleOrderItemsInfo> saleOrderItems)
        {
            saleOrderItems.ForEach(o =>
            {
                ARDeliveryPlanItemsList.Add(ToDeliveryPlanItemsInfo(o));
            });
        }

        public void GenarateDeliveryPlanWorks(List<ICProductsInfo> productsInfo)
        {
            productsInfo.ForEach(o =>
            {
                ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo = ToDeliveryPlanWorksInfo(o);
                ARDeliveryPlanWorksList.Add(objDeliveryPlanWorksInfo);
                GenarateTasks(objDeliveryPlanWorksInfo, o.ProductTasksList.ToList());
                GenarateDeliveryPlanWorkAssets(objDeliveryPlanWorksInfo, o.ProductWorkItemAssetsList.ToList());
                GenarateDeliveryPlanWorkMaterials(objDeliveryPlanWorksInfo, o.ProductWorkItemMaterialsList.ToList());
            });
        }

        private void GenarateTasks(ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo, List<ICProductTasksInfo> productTasks)
        {
            if (objDeliveryPlanWorksInfo.TasksList == null)
                objDeliveryPlanWorksInfo.TasksList = new BOSList<PMTasksInfo>(TableName.PMTasksTableName);
            productTasks.ForEach(o =>
            {
                PMTasksInfo objTasksInfo = ToTasksInfo(o);
                objDeliveryPlanWorksInfo.TasksList.Add(objTasksInfo);
                PMTasksList.Add(objTasksInfo);
            });
        }

        private void GenarateDeliveryPlanWorkAssets(ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo, List<ICProductWorkItemsInfo> productWorkItems)
        {
            if (objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList == null)
                objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList = new BOSList<ARDeliveryPlanWorksInfo>(TableName.ARDeliveryPlanWorksTableName);
            productWorkItems.ForEach(o =>
            {
                ARDeliveryPlanWorksInfo objDeliveryPlanWorkAssersInfo = ToDeliveryPlanWorkAssetsInfo(o);
                objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList.Add(objDeliveryPlanWorkAssersInfo);
                ARDeliveryPlanWorkAssetsList.Add(objDeliveryPlanWorkAssersInfo);
            });
        }

        private void GenarateDeliveryPlanWorkMaterials(ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo, List<ICProductWorkItemsInfo> productWorkItems)
        {
            if (objDeliveryPlanWorksInfo.DeliveryPlanWorkMaterialsList == null)
                objDeliveryPlanWorksInfo.DeliveryPlanWorkMaterialsList = new BOSList<ARDeliveryPlanWorksInfo>(TableName.ARDeliveryPlanWorksTableName);
            productWorkItems.ForEach(o =>
            {
                ARDeliveryPlanWorksInfo objDeliveryPlanWorkMaterialsInfo = ToDeliveryPlanWorkMaterialsInfo(o);
                objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList.Add(objDeliveryPlanWorkMaterialsInfo);
                ARDeliveryPlanWorkMaterialsList.Add(objDeliveryPlanWorkMaterialsInfo);
            });
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ARSaleOrderItemsInfo objSaleOrderItemsInfo)
        {
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetWoodQtyByStockIDAndProductIDAndSerieID(objSaleOrderItemsInfo.FK_ICStockID, objSaleOrderItemsInfo.FK_ICProductID, objSaleOrderItemsInfo.FK_ICProductSerieID);
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleOrderItemsInfo.FK_ICProductID);
            if (objProductsInfo == null) objProductsInfo = new ICProductsInfo();
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID,
                FK_ARCustomerID = objSaleOrderItemsInfo.FK_ARCustomerID,
                FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID,
                ARDeliveryPlanItemProductCustomerNumber = objSaleOrderItemsInfo.ARSaleOrderItemProductCustomerNumber,
                ARDeliveryPlanItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys,
                FK_ICProductSerieID = objSaleOrderItemsInfo.FK_ICProductSerieID,
                FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID,
                FK_ICStockID = objSaleOrderItemsInfo.FK_ICStockID,
                ARDeliveryPlanItemSaleOrderNo = objSaleOrderItemsInfo.ARSaleOrderNo,
                ARDeliveryPlanItemSaleOrderDate = objSaleOrderItemsInfo.ARSaleOrderDate,
                ARDeliveryPlanItemDeliveryDate = objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate,
                ARDeliveryPlanItemDeliveryActualDate = objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate,
                ARDeliveryPlanItemProductNo = objSaleOrderItemsInfo.ARSaleOrderItemProductNo,
                ARDeliveryPlanItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName,
                ARDeliveryPlanItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc,
                ARDeliveryPlanItemProductType = objSaleOrderItemsInfo.ARSaleOrderProductType,
                ARDeliveryPlanItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty,
                ARDeliveryPlanItemNetWeight = objSaleOrderItemsInfo.ICProductWidth * objSaleOrderItemsInfo.ICProductLength * objSaleOrderItemsInfo.ICProductHeight,
                ARDeliveryPlanItemAddress = objSaleOrderItemsInfo.ARSaleOrderDeliveryAddressLine3,
                //ARDeliveryPlanItemCommand = !string.IsNullOrEmpty(objSaleOrderItemsInfo.ARSaleOrderItemRemark)
                //                            ? objSaleOrderItemsInfo.ARSaleOrderItemRemark
                //                            : objSaleOrderItemsInfo.ARSaleOrderInternalComment,
                ARDeliveryPlanItemCommand = objSaleOrderItemsInfo.ARSaleOrderItemRemark,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                ARDeliveryPlanItemDeliveryAddressStreet = objSaleOrderItemsInfo.ARCustomerDeliveryAddressStreet,
                ARDeliveryPlanItemDeliveryAddressWard = objSaleOrderItemsInfo.ARCustomerDeliveryAddressWard,
                FK_GEDeliveryDistrictID = objSaleOrderItemsInfo.FK_GEDeliveryDistrictID,
                FK_GEDeliveryStateProvinceID = objSaleOrderItemsInfo.FK_GEDeliveryStateProvinceID,
                ARDeliveryPlanItemProductHeight = objSaleOrderItemsInfo.ICProductHeight,
                ARDeliveryPlanItemProductWidth = objSaleOrderItemsInfo.ICProductWidth,
                ARDeliveryPlanItemProductLength = objSaleOrderItemsInfo.ICProductLength,
                ARDeliveryPlanItemRemainedQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty,
                ACObjectName = objSaleOrderItemsInfo.ACObjectName,
                FK_ACObjectID = objSaleOrderItemsInfo.FK_ACObjectID,
                ARObjectType = objSaleOrderItemsInfo.ARObjectType,
                ACObjectAccessKey = objSaleOrderItemsInfo.FK_ACObjectID + ";" + objSaleOrderItemsInfo.ARObjectType,
                FK_ICSectionProductID = objSaleOrderItemsInfo.FK_ICSectionProductID,
                FK_ACCostCenterID = objSaleOrderItemsInfo.FK_ACCostCenterID,
                FK_PMTemplateItemID = objSaleOrderItemsInfo.FK_PMTemplateItemID,
                PMTemplateItemProductName = objSaleOrderItemsInfo.PMTemplateItemProductName,
                FK_ARProposalTemplateItemID = objSaleOrderItemsInfo.FK_ARProposalTemplateItemID,
                ARProposalTemplateItemProductName = objSaleOrderItemsInfo.ARProposalTemplateItemProductName,
                ARDeliveryPlanItemProductFactor = objSaleOrderItemsInfo.ARSaleOrderItemProductFactor,
                ARDeliveryPlanItemProductExchangeQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * objSaleOrderItemsInfo.ARSaleOrderItemProductFactor,
                ARDeliveryPlanItemExchangeUnitCost = objSaleOrderItemsInfo.ARSaleOrderItemExchangeUnitCost,
                ARDeliveryPlanItemExchangeTotalCost = objSaleOrderItemsInfo.ARSaleOrderItemExchangeTotalCost,
                FK_ICProductAttributeTTMTID = objSaleOrderItemsInfo.FK_ICProductAttributeTTMTID,
                FK_ICProductAttributeQualityID = objSaleOrderItemsInfo.FK_ICProductAttributeQualityID,
                ARDeliveryPlanItemProductSerialNo = objSaleOrderItemsInfo.ARSaleOrderItemProductSerialNo,
                ARDeliveryPlanItemLotNo = objSaleOrderItemsInfo.ARSaleOrderItemLotNo,
                ARDeliveryPlanItemWoodQty = objInventoryStocksInfo != null
                                            && !string.IsNullOrEmpty(objSaleOrderItemsInfo.ARSaleOrderItemProductSerialNo)
                                            ? objInventoryStocksInfo.ICInventoryStockWoodQuantity : objSaleOrderItemsInfo.ARSaleOrderItemWoodQty,
                ARDeliveryPlanItemPONo = objSaleOrderItemsInfo.ARSaleOrderItemPONo,
                FK_MMBatchProductID = objSaleOrderItemsInfo.FK_MMBatchProductID,
                ARProductionPlanningItemProductQty = objSaleOrderItemsInfo.ARProductionPlanningItemProductQty,
                ARDeliveryPlanItemQuantityOfBox = objSaleOrderItemsInfo.ARSaleOrderItemQuantityOfBox,
                ARSaleOrderName = objSaleOrderItemsInfo.ARSaleOrderName
            };
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ARSaleOrderItemWorkItemsInfo objSaleOrderItemWorkItemsInfo)
        {
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ARSaleOrderID = objSaleOrderItemWorkItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objSaleOrderItemWorkItemsInfo.FK_ARSaleOrderItemID,
                FK_ICProductID = objSaleOrderItemWorkItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objSaleOrderItemWorkItemsInfo.FK_ICMeasureUnitID,
                ARDeliveryPlanItemProductNo = objSaleOrderItemWorkItemsInfo.ARSaleOrderItemWorkItemProductNo,
                ARDeliveryPlanItemProductName = objSaleOrderItemWorkItemsInfo.ARSaleOrderItemWorkItemProductName,
                ARDeliveryPlanItemProductDesc = objSaleOrderItemWorkItemsInfo.ARSaleOrderItemWorkItemProductDesc,
                ARDeliveryPlanItemProductType = objSaleOrderItemWorkItemsInfo.ARSaleOrderItemWorkItemProductType,
                ARDeliveryPlanItemProductQty = objSaleOrderItemWorkItemsInfo.ARSaleOrderItemWorkItemProductQty,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                ARDeliveryPlanItemRemainedQty = objSaleOrderItemWorkItemsInfo.ARSaleOrderItemWorkItemProductQty,
            };
        }

        private ARDeliveryPlanWorksInfo ToDeliveryPlanWorksInfo(ICProductsInfo objProductsInfo)
        {
            return new ARDeliveryPlanWorksInfo()
            {
                //FK_ARSaleOrderID = objSaleOrderItemWorksInfo.FK_ARSaleOrderID,
                //FK_ARSaleOrderItemID = objSaleOrderItemWorksInfo.FK_ARSaleOrderItemID,
                FK_ICProductID = objProductsInfo.ICProductID,
                FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID,
                //FK_ARSaleOrderItemWorkID = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkID,
                ARDeliveryPlanWorkProductNo = objProductsInfo.ICProductNo,
                ARDeliveryPlanWorkProductName = objProductsInfo.ICProductName,
                ARDeliveryPlanWorkProductDesc = objProductsInfo.ICProductDesc,
                ARDeliveryPlanWorkProductQty = 1,
                ARDeliveryPlanWorkProductType = objProductsInfo.ICProductType,
                ARDeliveryPlanWorkProductUnitPrice = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkSubTotalAmount = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkTotalAmount = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkProductChargeCheck = objProductsInfo.ICProductChargeCheck,
                //ACObjectName = objSaleOrderItemWorksInfo.ACObjectName,
                ARDeliveryPlanWorkStatus = string.Empty,
            };
        }

        private ARDeliveryPlanWorksInfo ToDeliveryPlanWorkAssetsInfo(ICProductWorkItemsInfo objProductWorkItemsInfo)
        {
            return new ARDeliveryPlanWorksInfo()
            {
                //FK_ARSaleOrderID = objSaleOrderItemWorkAssetsInfo.FK_ARSaleOrderID,
                //FK_ARSaleOrderItemID = objSaleOrderItemWorkAssetsInfo.FK_ARSaleOrderItemID,
                FK_ICProductID = objProductWorkItemsInfo.FK_ICProductWorkItemChildID,
                FK_ICMeasureUnitID = objProductWorkItemsInfo.FK_ICProductBasicUnitID,
                ARDeliveryPlanWorkProductNo = objProductWorkItemsInfo.ICProductWorkItemProductNo,
                ARDeliveryPlanWorkProductName = objProductWorkItemsInfo.ICProductWorkItemProductName,
                ARDeliveryPlanWorkProductDesc = objProductWorkItemsInfo.ICProductWorkItemProductDesc,
                ARDeliveryPlanWorkProductQty = objProductWorkItemsInfo.ICProductWorkItemQty,
                ARDeliveryPlanWorkProductType = objProductWorkItemsInfo.ICProductWorkItemType,
                ARDeliveryPlanWorkProductUnitPrice = objProductWorkItemsInfo.ICProductPrice01,
                ARDeliveryPlanWorkTotalAmount = objProductWorkItemsInfo.ICProductPrice01 * objProductWorkItemsInfo.ICProductWorkItemQty,
                ARDeliveryPlanWorkSubTotalAmount = objProductWorkItemsInfo.ICProductPrice01 * objProductWorkItemsInfo.ICProductWorkItemQty,
                ARDeliveryPlanWorkProductChargeCheck = objProductWorkItemsInfo.ICProductWorkItemProductChargeCheck,
                ARDeliveryPlanWorkStatus = string.Empty,
            };
        }

        private ARDeliveryPlanWorksInfo ToDeliveryPlanWorkAssetsInfo(ICProductsInfo objProductsInfo)
        {
            return new ARDeliveryPlanWorksInfo()
            {
                //FK_ARSaleOrderID = objSaleOrderItemWorkAssetsInfo.FK_ARSaleOrderID,
                //FK_ARSaleOrderItemID = objSaleOrderItemWorkAssetsInfo.FK_ARSaleOrderItemID,
                FK_ICProductID = objProductsInfo.ICProductID,
                FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID,
                ARDeliveryPlanWorkProductNo = objProductsInfo.ICProductNo,
                ARDeliveryPlanWorkProductName = objProductsInfo.ICProductName,
                ARDeliveryPlanWorkProductDesc = objProductsInfo.ICProductDesc,
                ARDeliveryPlanWorkProductQty = 1,
                ARDeliveryPlanWorkProductType = ProductWorkType.Asset.ToString(),
                ARDeliveryPlanWorkProductUnitPrice = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkTotalAmount = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkSubTotalAmount = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkProductChargeCheck = objProductsInfo.ICProductChargeCheck,
                ARDeliveryPlanWorkStatus = string.Empty,
            };
        }

        private ARDeliveryPlanWorksInfo ToDeliveryPlanWorkMaterialsInfo(ICProductWorkItemsInfo objProductWorkItemsInfo)
        {
            return new ARDeliveryPlanWorksInfo()
            {
                //FK_ARSaleOrderID = objSaleOrderItemWorkMaterialsInfo.FK_ARSaleOrderID,
                //FK_ARSaleOrderItemID = objSaleOrderItemWorkMaterialsInfo.FK_ARSaleOrderItemID,
                FK_ICProductID = objProductWorkItemsInfo.FK_ICProductWorkItemChildID,
                FK_ICMeasureUnitID = objProductWorkItemsInfo.FK_ICProductBasicUnitID,
                ARDeliveryPlanWorkProductNo = objProductWorkItemsInfo.ICProductWorkItemProductNo,
                ARDeliveryPlanWorkProductName = objProductWorkItemsInfo.ICProductWorkItemProductName,
                ARDeliveryPlanWorkProductDesc = objProductWorkItemsInfo.ICProductWorkItemProductDesc,
                ARDeliveryPlanWorkProductQty = objProductWorkItemsInfo.ICProductWorkItemQty,
                ARDeliveryPlanWorkProductType = objProductWorkItemsInfo.ICProductWorkItemType,
                ARDeliveryPlanWorkProductUnitPrice = objProductWorkItemsInfo.ICProductPrice01,
                ARDeliveryPlanWorkTotalAmount = objProductWorkItemsInfo.ICProductPrice01 * objProductWorkItemsInfo.ICProductWorkItemQty,
                ARDeliveryPlanWorkSubTotalAmount = objProductWorkItemsInfo.ICProductPrice01 * objProductWorkItemsInfo.ICProductWorkItemQty,
                ARDeliveryPlanWorkProductChargeCheck = objProductWorkItemsInfo.ICProductWorkItemProductChargeCheck,
                ARDeliveryPlanWorkStatus = string.Empty,
            };
        }

        private ARDeliveryPlanWorksInfo ToDeliveryPlanWorkMaterialsInfo(ICProductsInfo objProductsInfo)
        {
            return new ARDeliveryPlanWorksInfo()
            {
                //FK_ARSaleOrderID = objSaleOrderItemWorkMaterialsInfo.FK_ARSaleOrderID,
                //FK_ARSaleOrderItemID = objSaleOrderItemWorkMaterialsInfo.FK_ARSaleOrderItemID,
                FK_ICProductID = objProductsInfo.ICProductID,
                FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID,
                ARDeliveryPlanWorkProductNo = objProductsInfo.ICProductNo,
                ARDeliveryPlanWorkProductName = objProductsInfo.ICProductName,
                ARDeliveryPlanWorkProductDesc = objProductsInfo.ICProductDesc,
                ARDeliveryPlanWorkProductQty = 1,
                ARDeliveryPlanWorkProductType = ProductWorkType.Material.ToString(),
                ARDeliveryPlanWorkProductUnitPrice = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkTotalAmount = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkSubTotalAmount = objProductsInfo.ICProductPrice01,
                ARDeliveryPlanWorkProductChargeCheck = objProductsInfo.ICProductChargeCheck,
                ARDeliveryPlanWorkStatus = string.Empty,
            };
        }

        private PMTasksInfo ToTasksInfo(ICProductTasksInfo objProductTasksInfo)
        {
            return new PMTasksInfo()
            {
                FK_ICMeasureUnitID = objProductTasksInfo.FK_ICMeasureUnitID,
                FK_HRDepartmentID = objProductTasksInfo.FK_HRDepartmentID,
                FK_HRDepartmentRoomID = objProductTasksInfo.FK_HRDepartmentRoomID,
                FK_HREmployeeID = objProductTasksInfo.FK_HREmployeeID,
                FK_HREmployeeOwnerID = objProductTasksInfo.FK_HREmployeeID,
                FK_ICTaskID = objProductTasksInfo.FK_ICTaskID,
                PMTaskNo = objProductTasksInfo.ICProductTaskNo,
                PMTaskName = objProductTasksInfo.ICProductTaskName,
                PMTaskInfo = objProductTasksInfo.ICProductTaskInfo,
                PMTaskTotalEstimatedDays = objProductTasksInfo.ICProductTaskTotalEstimatedDays,
                PMTaskTotalActualDays = objProductTasksInfo.ICProductTaskTotalActualDays,
                PMTaskTotalEstimatedHours = objProductTasksInfo.ICProductTaskTotalEstimatedHours,
                PMTaskTotalActualHours = objProductTasksInfo.ICProductTaskTotalActualHours,
                PMTaskEstimatedExtendDays = objProductTasksInfo.ICProductTaskEstimatedExtendDays,
                PMTaskActualExtendDays = objProductTasksInfo.ICProductTaskActualExtendDays,
                PMTaskEstimatedExtendHours = objProductTasksInfo.ICProductTaskEstimatedExtendHours,
                PMTaskActualExtendHours = objProductTasksInfo.ICProductTaskActualExtendHours,
                PMTaskQty = objProductTasksInfo.ICProductTaskQty,
                PMTaskEstimatedTotalCost = objProductTasksInfo.ICProductTaskEstimatedTotalCost,
                PMTaskActualTotalCost = objProductTasksInfo.ICProductTaskActualTotalCost,
                PMTaskExtendStartDate = DateTime.Now,
                PMTaskExtendEndDate = DateTime.Now,
                PMTaskType = string.Empty,
                PMTaskStatus = TaskStatus.New.ToString(),
                PMTaskIssueType = string.Empty,
                PMTaskIssueReason = string.Empty,
                ObjectType = ObjectType.Plan.ToString(),
                ObjectType01 = ObjectType01.WorkPlan.ToString()
            };
        }

        public ARDeliveryPlanTrucksInfo ToARDeliveryPlanTrucksInfo(VMVehiclesInfo objVehiclesInfo)
        {
            return new ARDeliveryPlanTrucksInfo()
            {
                ARDeliveryPlanTruckName = objVehiclesInfo.VMVehicleName,
                FK_VMVehicleID = objVehiclesInfo.VMVehicleID,
                ARDeliveryPlanTruckDeliveryPlanItem = DeliveryPlanLocalizedResources.TruckItemList,
                ARDeliveryPlanTruckNumber = objVehiclesInfo.VMVehicleNoPlate,
                ARDeliveryPlanTruckGrossTon = objVehiclesInfo.VMVehicleCargoTonnage,
                ARDeliveryPlanTruckCapacity = objVehiclesInfo.VMVehicleCapacity,
                ARDeliveryPlanTruckDriver = String.Empty,
                ARDeliveryPlanTruckSource = DeliveryPlanTruckSource.Company.ToString(),
                ARDeliverPlanTruckType = objVehiclesInfo.VMDeliveryPlanTruckType,
            };
        }

        //public ARDeliveryPlanTrucksInfo ToARDeliveryPlanTrucksInfo(ICProductsInfo objProductsInfo)
        //{
        //    return new ARDeliveryPlanTrucksInfo()
        //    {
        //        ARDeliveryPlanTruckName = objProductsInfo.ICProductName,
        //        FK_ICProductID = objProductsInfo.ICProductID,
        //        ARDeliveryPlanTruckDeliveryPlanItem = DeliveryPlanLocalizedResources.TruckItemList,
        //        ARDeliveryPlanTruckNumber = objProductsInfo.ICProductLicensePlate,
        //        ARDeliveryPlanTruckGrossTon = objProductsInfo.ICProductBulk,
        //        ARDeliveryPlanTruckCapacity = objProductsInfo.ICProductCapacity,
        //        FK_HREmployeeID = objProductsInfo.FK_HREmployeeID,
        //        ARDeliveryPlanTruckDriver = String.Empty,
        //        ARDeliveryPlanTruckSource = DeliveryPlanTruckSource.Company.ToString(),

        //    };
        //}

        public void GenarateDeliveryPlanTruckPoints(List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems, ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            deliveryPlanTruckItems.ForEach(o =>
            {
                if (objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList == null)
                    objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList = new BOSList<ARDeliveryPlanTruckPointsInfo>(TableName.ARDeliveryPlanTruckPointsTableName);
                ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = ToDeliveryPlanTruckPointsInfo(o, objDeliveryPlanTrucksInfo);

                if (!(objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList.Any(s => s.ARDeliveryPlanTruckPointAddress == objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress && s.FK_ICProductTruckID == objDeliveryPlanTruckPointsInfo.FK_ICProductTruckID)))
                    objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList.Add(objDeliveryPlanTruckPointsInfo);

                if (!(DeliveryPlanTruckPointsList.Any(s => s.ARDeliveryPlanTruckPointAddress == objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress && s.FK_ICProductTruckID == objDeliveryPlanTruckPointsInfo.FK_ICProductTruckID)))
                    DeliveryPlanTruckPointsList.Add(objDeliveryPlanTruckPointsInfo);
            });
        }

        public ARDeliveryPlanTruckPointsInfo ToDeliveryPlanTruckPointsInfo(ARDeliveryPlanTruckItemsInfo objDeliveryPlanTruckItemsInfo, ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList.Where(o => o.FK_ARSaleOrderItemID == objDeliveryPlanTruckItemsInfo.FK_ARSaleOrderItemID).FirstOrDefault();
            List<string> itemDesc = new List<string>();
            if (objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList != null)
            {
                List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems = objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList.Where(o => o.ARDeliveryPlanTruckItemAddress == objDeliveryPlanTruckItemsInfo.ARDeliveryPlanTruckItemAddress).ToList();
                deliveryPlanTruckItems.ForEach(o => itemDesc.Add(string.Format("{0} {1}", Convert.ToInt32(o.ARDeliveryPlanTruckItemDeliveryQty).ToString(), o.ARDeliveryPlanTruckItemProductDesc)));
            }

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objDeliveryPlanItemsInfo.FK_ACObjectID, objDeliveryPlanItemsInfo.ARObjectType);

            ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = new ARDeliveryPlanTruckPointsInfo()
            {
                FK_ARDeliveryPlanTruckID = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckID,
                FK_ARDeliveryPlanID = objDeliveryPlanTrucksInfo.FK_ARDeliveryPlanID,
                FK_ICProductTruckID = objDeliveryPlanTrucksInfo.FK_ICProductID,
                ARDeliveryPlanTruckPointEstimateDate = objDeliveryPlanItemsInfo != null ? objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryDate : BOSApp.GetCurrentServerDate(),
                ARDeliveryPlanTruckPointActualDate = objDeliveryPlanItemsInfo != null ? objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryActualDate : BOSApp.GetCurrentServerDate(),
                ARDeliveryPlanTruckPointNo = BOSApp.GetMainObjectNo(ModuleName.DeliveryPlanTruckPoint, new ARDeliveryPlanTruckPointsInfo()),
                ARDeliveryPlanTruckPointAddress = objDeliveryPlanItemsInfo != null ? objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress : string.Empty,
                ARDeliveryPlanTruckPointNote = objDeliveryPlanItemsInfo.ARDeliveryPlanItemCommand,
                ARDeliveryPlanTruckPointStreet = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryAddressStreet,
                ARDeliveryPlanTruckPointWard = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryAddressWard,
                FK_GEDeliveryDistrictID = objDeliveryPlanItemsInfo.FK_GEDeliveryDistrictID,
                FK_GEDeliveryStateProvinceID = objDeliveryPlanItemsInfo.FK_GEDeliveryStateProvinceID,
                ARDeliveryPlanTruckName = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckName,
                ARDeliveryPlanTruckNumber = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckNumber,
                ARDeliveryPlanTruckPointCustomerName = objObjectsInfo != null ? objObjectsInfo.ACObjectName : string.Empty,
                FK_ARSaleOrderID = objDeliveryPlanItemsInfo.FK_ARSaleOrderID,
                FK_ARCustomerID = objDeliveryPlanItemsInfo.FK_ARCustomerID,
                ARDeliveryPlanTruckPointDesc = string.Join("; ", itemDesc.ToArray()),
                ARDeliveryPlanTruckSource = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckSource,
            };
            BOSApp.UpdateObjectNumbering(ModuleName.DeliveryPlanTruckPoint);
            string addressEncode = System.Uri.EscapeUriString(objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress);
            string url = String.Format(GoogleApiUrl, addressEncode, GoogleApiKey);
            try
            {
                NetHttp net = new NetHttp(string.Empty);
                var headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/json"},
                };
                Geocoding result = net.Get<Geocoding>(url, headers);
                if (result != null && result.results.Count != 0)
                {
                    objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointLatitude = Convert.ToDecimal(result.results[0].geometry.location.lat);
                    objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointLongitude = Convert.ToDecimal(result.results[0].geometry.location.lng);
                }
            }
            catch
            {
            }
            return objDeliveryPlanTruckPointsInfo;
        }

        public override bool CompleteTransaction()
        {
            base.CompleteTransaction();
            return true;
        }

        public void UpdateSaleOrderItem(bool isPosted)
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<int> saleOrderIDs = ARDeliveryPlanItemsList.Select(o => o.FK_ARSaleOrderID).Distinct().ToList();
            List<ARSaleOrderItemsInfo> saleOrderItems = new List<ARSaleOrderItemsInfo>();
            saleOrderIDs.ForEach(o => saleOrderItems = saleOrderItems.Concat(objSaleOrderItemsController.GetSaleOrderItemBySaleOrderID(o)).ToList());

            saleOrderItems.ForEach(o =>
            {
                ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList.Where(s => s.FK_ARSaleOrderItemID == o.ARSaleOrderItemID).FirstOrDefault();
                if (objDeliveryPlanItemsInfo != null)
                {
                    //o.ARSaleOrderItemPlanQty += objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty;
                    decimal factor = GeneralHelper.CalculateProductMeasureUnitFactor(objDeliveryPlanItemsInfo.FK_ICProductID, objDeliveryPlanItemsInfo.FK_ICMeasureUnitID, o.FK_ICMeasureUnitID);
                    if (isPosted)
                        o.ARSaleOrderItemPlanQty += (objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty * factor);
                    else
                        o.ARSaleOrderItemPlanQty -= (objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty * factor);
                    objSaleOrderItemsController.UpdateObject(o);
                }
            });
        }

        public void GenarateDeliveryPlanItems(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)MainObject;
            ARDeliveryPlanTrucksController objDeliveryPlanTrucksController = new ARDeliveryPlanTrucksController();
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();

            string[] deliveryPlanItemIDs = deliveryPlanItems.Select(o => o.ARDeliveryPlanItemID.ToString()).ToArray();
            string deliveryPlanItemID = string.Join(",", deliveryPlanItemIDs);

            List<ARDeliveryPlanTrucksInfo> deliveryPlanTrucks = objDeliveryPlanTrucksController.GetDeliveryPlanTrucksByDeliveryPlanItemIDs(deliveryPlanItemID);

            string[] deliveryPlanTruckIDs = deliveryPlanTrucks.Select(o => o.ARDeliveryPlanTruckID.ToString()).Distinct().ToArray();
            string deliveryPlanTruckID = string.Join(",", deliveryPlanTruckIDs);

            List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems = objDeliveryPlanTruckItemsController.GetDeliveryPlanTruckItemsByDeliveryPlanTruckIDs(deliveryPlanTruckID);
            deliveryPlanTruckItems = deliveryPlanTruckItems.Where(o => deliveryPlanItems.Any(x => x.ARDeliveryPlanItemID == o.FK_ARDeliveryPlanItemID)).ToList();

            deliveryPlanItems.ForEach(o => ARDeliveryPlanItemsList.Add((ARDeliveryPlanItemsInfo)o.Clone()));

            deliveryPlanTrucks = deliveryPlanTrucks.GroupBy(o => o.FK_ICProductID).Select(x => x.First()).ToList();
            deliveryPlanTrucks.ForEach(o => ARDeliveryPlanTrucksList.Add((ARDeliveryPlanTrucksInfo)o.Clone()));

            deliveryPlanTruckItems.ForEach(o =>
            {
                o.ARDeliveryPlanTruckItemID = 0;
            });

            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                if (o.DeliveryPlanTruckItemsList == null)
                    o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                deliveryPlanTruckItems.Where(x => x.FK_ICProductTruckID == o.FK_ICProductID).All(x =>
                {
                    o.DeliveryPlanTruckItemsList.Add(x);
                    return true;
                });
            });
            ARDeliveryPlanItemsList.ForEach(o =>
            {
                o.ARDeliveryPlanItemReferenceID = o.ARDeliveryPlanItemID;
                o.ARDeliveryPlanItemID = 0;
                o.ARDeliveryPlanItemDeliveryActualDate = objDeliveryPlansInfo.ARDeliveryPlanBeginDate;
            });
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                o.ARDeliveryPlanTruckID = 0;
                o.FK_ARDeliveryPlanID = 0;
            });
            deliveryPlanTruckItems.ForEach(o =>
            {
                o.FK_ARDeliveryPlanItemID = 0;
                o.FK_ARDeliveryPlanTruckID = 0;
                o.FK_ARDeliveryPlanID = 0;
                o.FK_ARDeliveryPlanTruckPointID = 0;
            });
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                o.ARDeliveryPlanTruckTotalQty = o.DeliveryPlanTruckItemsList.Sum(x => x.ARDeliveryPlanTruckItemDeliveryQty);
                o.ARDeliveryPlanTruckTotalM3 = o.DeliveryPlanTruckItemsList.Sum(x => (x.ARDeliveryPlanTruckItemProductHeight * x.ARDeliveryPlanTruckItemProductWidth * x.ARDeliveryPlanTruckItemProductLength) * x.ARDeliveryPlanTruckItemDeliveryQty / 1000000000); // mm3 => m3
                GenarateDeliveryPlanTruckPoints(o.DeliveryPlanTruckItemsList.ToList(), o);
            });
            UpdateDeliveryPlanTruckPoint();
            objDeliveryPlansInfo.ARDeliveryPlanTotalTruck = ARDeliveryPlanTrucksList.Count();
            objDeliveryPlansInfo.ARDeliveryPlanTotalM3 = ARDeliveryPlanTrucksList.Sum(o => o.ARDeliveryPlanTruckTotalM3);
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo)
        {
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ARSaleOrderID = objDeliveryPlanItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID,
                FK_ARCustomerID = objDeliveryPlanItemsInfo.FK_ARCustomerID,
                FK_ICProductID = objDeliveryPlanItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objDeliveryPlanItemsInfo.FK_ICMeasureUnitID,
                ARDeliveryPlanItemSaleOrderNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemSaleOrderNo,
                ARDeliveryPlanItemSaleOrderDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemSaleOrderDate,
                ARDeliveryPlanItemDeliveryDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryDate,
                ARDeliveryPlanItemDeliveryActualDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryActualDate,
                ARDeliveryPlanItemProductNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductNo,
                ARDeliveryPlanItemProductName = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductName,
                ARDeliveryPlanItemProductDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductDesc,
                ARDeliveryPlanItemProductType = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductType,
                ARDeliveryPlanItemProductQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty,
                ARDeliveryPlanItemNetWeight = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty,
                ARDeliveryPlanItemAddress = objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress,
                ARDeliveryPlanItemCommand = objDeliveryPlanItemsInfo.ARDeliveryPlanItemCommand,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                ARDeliveryPlanItemReferenceID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID,
                FK_ACObjectID = objDeliveryPlanItemsInfo.FK_ACObjectID,
                ARObjectType = objDeliveryPlanItemsInfo.ARObjectType,
                ACObjectAccessKey = objDeliveryPlanItemsInfo.FK_ACObjectID + ";" + objDeliveryPlanItemsInfo.ARObjectType,
                FK_ACCostCenterID = objDeliveryPlanItemsInfo.FK_ACCostCenterID,
                FK_ICSectionProductID = objDeliveryPlanItemsInfo.FK_ICSectionProductID,
            };
        }

        public ARDeliveryPlanTrucksInfo ToARDeliveryPlanTrucksInfo(ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            return new ARDeliveryPlanTrucksInfo()
            {
                FK_ICMeasureUnitID = objDeliveryPlanTrucksInfo.FK_ICMeasureUnitID,
                ARDeliveryPlanTruckName = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckName,
                FK_ICProductID = objDeliveryPlanTrucksInfo.FK_ICProductID,
                ARDeliveryPlanTruckDeliveryPlanItem = DeliveryPlanLocalizedResources.TruckItemList,
                ARDeliveryPlanTruckNumber = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckNumber,
                ARDeliveryPlanTruckGrossTon = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckGrossTon,
                ARDeliveryPlanTruckCapacity = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckCapacity,
                ARDeliveryPlanTruckDriver = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckDriver,
                ARDeliveryPlanTruckSource = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckSource,
                ARDeliveryPlanTruckTotalQty = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckTotalQty,
            };
        }

        public override void DeleteObjectRelations(String strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            ARDeliveryPlanItemsList.DeleteItemObjects();
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            switch (strTableName)
            {
                case TableName.ARDeliveryPlanTrucksTableName:
                    objDeliveryPlanTruckItemsController.DeleteDeliveryPlanTruckItemsByDeliveryPlanTruckID(iObjectID);

                    ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
                    objDeliveryPlanTruckPointsController.DeleteDeliveryPlanTruckPointsByDeliveryPlanTruckID(iObjectID);
                    break;
                case TableName.ARDeliveryPlanWorksTableName:
                    ARDeliveryPlanWorksController objDeliveryPlanWorksController = new ARDeliveryPlanWorksController();
                    objDeliveryPlanWorksController.DeleteAllObjectsByObjectParentID(iObjectID);

                    PMTasksController objTasksController = new PMTasksController();
                    objTasksController.DeleteTasksByDeliveryPlanWorkID(iObjectID);

                    break;
                case TableName.ARDeliveryPlanItemsTableName:
                    objDeliveryPlanTruckItemsController.DeleteDeliveryPlanTruckItemsByDeliveryPlanItemID(iObjectID);
                    break;
            }
        }

        public void GenarateDeliveryPlanWorks(List<ARDeliveryPlanWorksInfo> deliveryPlanWorks)
        {
            deliveryPlanWorks.ForEach(o =>
            {
                ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo = (ARDeliveryPlanWorksInfo)o.Clone();
                objDeliveryPlanWorksInfo.ARDeliveryPlanWorkID = 0;
                objDeliveryPlanWorksInfo.FK_ARDeliveryPlanID = 0;
                objDeliveryPlanWorksInfo.TasksList.All(x =>
                {
                    x.PMTaskID = 0;
                    x.FK_ObjectID = 0;
                    x.FK_Object01ID = 0;
                    x.TaskAssignsList = new BOSList<PMTaskAssignsInfo>(TableName.PMTaskAssignsTableName);
                    PMTasksList.Add(x);
                    return true;
                });
                objDeliveryPlanWorksInfo.TasksList.BackupList.Clear();
                objDeliveryPlanWorksInfo.TasksList.OriginalList.Clear();

                objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList.All(x =>
                {
                    x.ARDeliveryPlanWorkID = 0;
                    x.ARDeliveryPlanWorkParentID = 0;
                    x.FK_ARDeliveryPlanID = 0;
                    ARDeliveryPlanWorkAssetsList.Add(x);
                    return true;
                });
                objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList.BackupList.Clear();
                objDeliveryPlanWorksInfo.DeliveryPlanWorkAssetsList.OriginalList.Clear();

                objDeliveryPlanWorksInfo.DeliveryPlanWorkMaterialsList.All(x =>
                {
                    x.ARDeliveryPlanWorkID = 0;
                    x.ARDeliveryPlanWorkParentID = 0;
                    x.FK_ARDeliveryPlanID = 0;
                    ARDeliveryPlanWorkMaterialsList.Add(x);
                    return true;
                });
                objDeliveryPlanWorksInfo.DeliveryPlanWorkMaterialsList.BackupList.Clear();
                objDeliveryPlanWorksInfo.DeliveryPlanWorkMaterialsList.OriginalList.Clear();

                ARDeliveryPlanWorksList.Add(objDeliveryPlanWorksInfo);
            });
        }

        public void GenarateDeliveryPlanWorkMaterials(List<ICProductsInfo> products)
        {
            products.ForEach(o => ARDeliveryPlanWorkMaterialsList.Add(ToDeliveryPlanWorkMaterialsInfo(o)));
        }

        public void GenarateDeliveryPlanWorkMaterials(List<ARDeliveryPlanWorksInfo> deliveryPlanWorkMaterials)
        {
            deliveryPlanWorkMaterials.ForEach(o =>
            {
                ARDeliveryPlanWorksInfo objDeliveryPlanWorkMatrialsInfo = (ARDeliveryPlanWorksInfo)o.Clone();
                objDeliveryPlanWorkMatrialsInfo.ARDeliveryPlanWorkID = 0;
                objDeliveryPlanWorkMatrialsInfo.FK_ARDeliveryPlanID = 0;
                o.ARDeliveryPlanWorkParentID = 0;
                o.FK_ARDeliveryPlanID = 0;
                ARDeliveryPlanWorkMaterialsList.Add(objDeliveryPlanWorkMatrialsInfo);
            });
        }

        public void GenarateDeliveryPlanWorkAssets(List<ICProductsInfo> products)
        {
            products.ForEach(o => ARDeliveryPlanWorkAssetsList.Add(ToDeliveryPlanWorkAssetsInfo(o)));
        }

        public void GenarateDeliveryPlanWorkAssets(List<ARDeliveryPlanWorksInfo> deliveryPlanWorkAssets)
        {
            deliveryPlanWorkAssets.ForEach(o =>
            {
                ARDeliveryPlanWorksInfo objDeliveryPlanWorkAssetsInfo = (ARDeliveryPlanWorksInfo)o.Clone();
                objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkID = 0;
                objDeliveryPlanWorkAssetsInfo.FK_ARDeliveryPlanID = 0;
                o.ARDeliveryPlanWorkParentID = 0;
                o.FK_ARDeliveryPlanID = 0;
                ARDeliveryPlanWorkAssetsList.Add(objDeliveryPlanWorkAssetsInfo);
            });
        }

        public void UpdateDeliveryPlanTruckPoint()
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                string employeeName = objEmployeesController.GetObjectNameByID(o.FK_HREmployeeID);
                if (String.IsNullOrEmpty(employeeName))
                    return;
                o.ARDeliveryPlanTruckDriver = employeeName;
                DeliveryPlanTruckPointsList.Where(x => x.ARDeliveryPlanTruckNumber == o.ARDeliveryPlanTruckNumber).All(i =>
                {
                    i.ARDeliveryPlanTruckPointEmployeeDeliveryName = employeeName;
                    return true;
                });
                DeliveryPlanTruckPointsList.GridControl.RefreshDataSource();
            });
        }

        public bool Validate()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
                mainObject.ARDeliveryPlanStatus = DeliveryPlanStatus.Verified.ToString();
                UpdateMainObject();
                UpdateSaleOrderItem(true);
                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ARContainerLoaderItemsInfo objContainerLoaderItemsInfo)
        {
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objContainerLoaderItemsInfo.FK_ICProductID);
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ARSaleOrderID = objContainerLoaderItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objContainerLoaderItemsInfo.FK_ARSaleOrderItemID,
                FK_ARContainerLoaderID = objContainerLoaderItemsInfo.FK_ARContainerLoaderID,
                FK_ARContainerLoaderItemID = objContainerLoaderItemsInfo.ARContainerLoaderItemID,
                FK_ARCustomerID = objContainerLoaderItemsInfo.FK_ARCustomerID,
                FK_ICProductID = objContainerLoaderItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objContainerLoaderItemsInfo.FK_ICMeasureUnitID,
                FK_ICStockID = objContainerLoaderItemsInfo.FK_ICStockID,
                ARDeliveryPlanItemSaleOrderNo = objContainerLoaderItemsInfo.ARSaleOrderNo,
                ARDeliveryPlanItemSaleOrderDate = objContainerLoaderItemsInfo.ARSaleOrderDate,
                ARDeliveryPlanItemDeliveryDate = objContainerLoaderItemsInfo.ARSaleOrderItemDeliveryDate,
                ARDeliveryPlanItemDeliveryActualDate = objContainerLoaderItemsInfo.ARSaleOrderItemDeliveryDate,
                ARDeliveryPlanItemProductNo = objContainerLoaderItemsInfo.ARSaleOrderItemProductNo,
                ARDeliveryPlanItemProductName = objContainerLoaderItemsInfo.ARContainerLoaderItemProductName,
                ARDeliveryPlanItemProductDesc = objContainerLoaderItemsInfo.ARContainerLoaderItemProductDesc,
                ARDeliveryPlanItemProductType = objContainerLoaderItemsInfo.ARSaleOrderProductType,
                ARDeliveryPlanItemProductQty = objContainerLoaderItemsInfo.ARContainerLoaderItemProductQty,
                ARDeliveryPlanItemNetWeight = objContainerLoaderItemsInfo.ARContainerLoaderItemWidth * objContainerLoaderItemsInfo.ARContainerLoaderItemLength * objContainerLoaderItemsInfo.ARContainerLoaderItemHeight,
                ARDeliveryPlanItemAddress = objContainerLoaderItemsInfo.ARSaleOrderDeliveryAddressLine3,
                ARDeliveryPlanItemCommand = objContainerLoaderItemsInfo.ARContainerLoaderDesc,
                ARDeliveryPlanItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber,
                ARDeliveryPlanItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                ARDeliveryPlanItemProductHeight = objContainerLoaderItemsInfo.ARContainerLoaderItemHeight,
                ARDeliveryPlanItemProductWidth = objContainerLoaderItemsInfo.ARContainerLoaderItemWidth,
                ARDeliveryPlanItemProductLength = objContainerLoaderItemsInfo.ARContainerLoaderItemLength,
                ARDeliveryPlanItemRemainedQty = objContainerLoaderItemsInfo.ARContainerLoaderItemProductQty,
                ACObjectName = objContainerLoaderItemsInfo.ARObjectType,
                FK_ACObjectID = objContainerLoaderItemsInfo.FK_ACObjectID,
                ARObjectType = objContainerLoaderItemsInfo.ARObjectType,
                ACObjectAccessKey = objContainerLoaderItemsInfo.FK_ACObjectID + ";" + objContainerLoaderItemsInfo.ARObjectType,
                FK_ICSectionProductID = objContainerLoaderItemsInfo.FK_ICSectionProductID,
                FK_ACCostCenterID = objContainerLoaderItemsInfo.FK_ACCostCenterID,
                FK_PMTemplateItemID = objContainerLoaderItemsInfo.FK_PMTemplateItemID,
                FK_ARProposalTemplateItemID = objContainerLoaderItemsInfo.FK_ARProposalTemplateItemID,
                ARProposalTemplateItemProductName = objContainerLoaderItemsInfo.ARProposalTemplateItemProductName,
                ARDeliveryPlanItemProductFactor = objContainerLoaderItemsInfo.ARContainerLoaderItemProductFactor,
                ARDeliveryPlanItemProductExchangeQty = objContainerLoaderItemsInfo.ARContainerLoaderItemProductQty * objContainerLoaderItemsInfo.ARContainerLoaderItemProductFactor,
                ARDeliveryPlanItemExchangeUnitCost = objContainerLoaderItemsInfo.ARContainerLoaderItemExchangeUnitCost,
                ARDeliveryPlanItemExchangeTotalCost = objContainerLoaderItemsInfo.ARContainerLoaderItemExchangeTotalCost,
                FK_ICProductAttributeQualityID = objContainerLoaderItemsInfo.FK_ICProductAttributeQualityID,
                FK_ICProductAttributeTTMTID = objContainerLoaderItemsInfo.FK_ICProductAttributeTTMTID,
                ARDeliveryPlanItemPONo = objContainerLoaderItemsInfo.ARContainerLoaderItemPONo,
                FK_MMBatchProductID = objContainerLoaderItemsInfo.FK_MMBatchProductID
            };
        }

        public void GenerateEntitiesFromContainerLoadItems(List<ARContainerLoaderItemsInfo> containerLoaderItemList)
        {
            containerLoaderItemList.ForEach(o =>
            {
                ARDeliveryPlanItemsList.Add(ToDeliveryPlanItemsInfo(o));
            });
        }
    }
}