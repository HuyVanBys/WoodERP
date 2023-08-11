using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ShipmentSaleOrderEntities : GLShipmentEntities
    {
        public BOSItemsEntityList<ICShipmentItemsInfo> ShipmentItemWorkItemList { get; set; }

        public BOSItemsEntityList<ICShipmentItemsInfo> ComponentShipmentItemList { get; set; }

        public int CountItemsInShipmentPackageItemList = 0;

        public BOSList<ICShipmentPackagesInfo> ShipmentPackageList { get; set; }

        //public BOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailShowList { get; set; }

        //public BOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailList { get; set; }

        //public BOSList<ICShipmentPackageItemDetailsInfo> DeleteShipmentPackageItemDetailList { get; set; }

        //public BOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailReportList { get; set; }

        #region Constructor
        public ShipmentSaleOrderEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ShipmentItemWorkItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ComponentShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ShipmentPackageList = new BOSList<ICShipmentPackagesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentsInfo();
            SearchObject = new ICShipmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentItemsTableName, new ICShipmentItemsInfo());
            ModuleObjects.Add(TableName.ICShipmentPackagesTableName, new ICShipmentPackageItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ShipmentItemWorkItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemWorkItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ComponentShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ComponentShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ShipmentPackageList.InitBOSList(this,
                                               TableName.ICShipmentsTableName,
                                               TableName.ICShipmentPackagesTableName,
                                               BOSList<ICShipmentPackageItemsInfo>.cstRelationForeign);
            ShipmentPackageList.ItemTableForeignKey = "FK_ICShipmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(ShipmentSaleOrderModule.ShipmentItemGridControlName);
            ShipmentItemWorkItemList.InitBOSListGridControl(ShipmentSaleOrderModule.ShipmentItemWorkItemGridControlName);

            DocumentEntryList.InitBOSListGridControl(ShipmentSaleOrderModule.DocumentEntryGridControlName);
            ShipmentPackageList.InitBOSListGridControl("fld_dgcICShipmentPackages");

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                ShipmentItemWorkItemList.SetDefaultListAndRefreshGridControl();

                ComponentShipmentItemList.SetDefaultListAndRefreshGridControl();
                ShipmentPackageList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.SaleShipment.ToString();
            objShipmentsInfo.ICShipmentShipmentType = ShipmentType.SaleShipment.ToString();
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objShipmentsInfo.ICShipmentETDDate = DateTime.Now;
            UpdateMainObjectBindingSource();
            CountItemsInShipmentPackageItemList = 0;
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICShipmentItemsController shipmentItemController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = shipmentItemController.GetListObjectByFKICShipmentID(iObjectID);
            ShipmentItemList.Invalidate(shipmentItemList.Where(o => o.ICShipmentItemProductType != "Material").ToList());
            ShipmentItemWorkItemList.Invalidate(shipmentItemList.Where(o => o.ICShipmentItemProductType == "Material").ToList());
            ShipmentPackageList.Invalidate(iObjectID);
            InvalidateItemComponents();

            ComponentShipmentItemList.BackupList.Clear();
            if (mainObject.ICShipmentStatus == ShipmentStatus.Complete.ToString())
            {
                foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
                {
                    ComponentShipmentItemList.BackupList.Add((ICShipmentItemsInfo)item.Clone());
                }
            }
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                item.ICShipmentItemComponentList = new BOSList<ICShipmentItemComponentsInfo>();
                item.ICShipmentItemComponentList.InitBOSList(this,
                                                               TableName.ICShipmentItemsTableName,
                                                               TableName.ICShipmentItemComponentsTableName,
                                                               BOSList<ICShipmentItemComponentsInfo>.cstRelationForeign);
                item.ICShipmentItemComponentList.ItemTableForeignKey = "FK_ICShipmentItemID";

                ICShipmentItemComponentsController objShipmentItemsComponentsController = new ICShipmentItemComponentsController();
                List<ICShipmentItemComponentsInfo> listComponents = objShipmentItemsComponentsController.GetShipmentItemComponentListByShipmentItemID(item.Id);
                item.ICShipmentItemComponentList.Invalidate(listComponents);
            }
        }

        public void InvalidateItemComponents()
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            //List<ICShipmentItemsInfo> items = objShipmentItemsController.GetComponentItemsByShipmentID(objShipmentsInfo.ICShipmentID);
            ComponentShipmentItemList.Clear();
            ComponentShipmentItemList.OriginalList.Clear();
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                ComponentShipmentItemList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.OriginalList.Add((ICShipmentItemsInfo)item.Clone());
            }
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            if (objShipmentsInfo.ICShipmentStatus != ShipmentStatus.EditAfterComplete.ToString())
            {
                ShipmentItemList.SaveItemObjects();
                SaveShipmentItemComponentList(ShipmentItemList);
                ShipmentItemWorkItemList.SaveItemObjects();
                SaveAccountingData();

                ShipmentPackageList.ForEach(o =>
                {
                    o.FK_ICShipmentID = objShipmentsInfo.ICShipmentID;
                });
                ShipmentPackageList.SaveItemObjects();
            }
            else
            {
                objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
                UpdateMainObject();
            }
        }
        #endregion
        public void SaveShipmentItemComponentList(BOSList<ICShipmentItemsInfo> shipmentItemsList)
        {
            foreach (ICShipmentItemsInfo item in shipmentItemsList)
            {
                if (item.ICShipmentItemComponentList != null)
                {
                    foreach (ICShipmentItemComponentsInfo componentItem in item.ICShipmentItemComponentList)
                    {
                        componentItem.FK_ICShipmentItemID = item.Id;
                    }
                    item.ICShipmentItemComponentList.SaveItemObjects();
                }
            }
        }
        public void GenarateShipmentSaleOrder(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            deliveryPlanItems.ForEach(o =>
            {
                SetProductCostByProductUnitCost(o);
                ShipmentItemList.Add(ToShipmentItemInfo(o));
            });
            deliveryPlanItems.GroupBy(t => t.FK_ARDeliveryPlanID).Select(g => g.First()).ToList().ForEach(s =>
            {
                ToShipmentItemInfo(s.FK_ARDeliveryPlanID, "Material");
            });
        }

        private ICShipmentItemsInfo ToShipmentItemInfo(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo)
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objDeliveryPlanItemsInfo.FK_ICProductID);
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID);
            if (objSaleOrderItemsInfo == null)
                objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();

            ICShipmentItemsInfo objShipmentItemInfo = new ICShipmentItemsInfo()
            {
                FK_ICProductID = objDeliveryPlanItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objDeliveryPlanItemsInfo.FK_ICMeasureUnitID,
                ICShipmentItemProductName = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductName,
                ICShipmentItemProductDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductDesc,
                ICShipmentItemProductType = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductType,
                ICShipmentItemProductQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemShipmentQty,
                ICShipmentItemProductBasicQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemShipmentQty,
                ICShipmentItemProductSerialNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductSerialNo,
                ICShipmentItemLotNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemLotNo,
                ICShipmentItemProductAttribute = objDeliveryPlanItemsInfo.ARSaleOrderItemProductAttribute,
                FK_ICDepartmentID = objDeliveryPlanItemsInfo.FK_ICDepartmentID,
                FK_ICStockID = objDeliveryPlanItemsInfo.FK_ICStockID,
                FK_ICProductSerieID = objDeliveryPlanItemsInfo.FK_ICProductSerieID,
                ICShipmentItemTotalAmount = objDeliveryPlanItemsInfo.ARSaleOrderItemTotalAmount,
                ICShipmentItemPrice = objDeliveryPlanItemsInfo.ARSaleOrderItemPrice,
                ICShipmentItemProductUnitPrice = objDeliveryPlanItemsInfo.ARSaleOrderItemProductUnitPrice,
                FK_ARDeliveryPlanID = objDeliveryPlanItemsInfo.FK_ARDeliveryPlanID,
                FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID,
                FK_ARSaleOrderID = objDeliveryPlanItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID,
                FK_ACAccountID = objDeliveryPlanItemsInfo.FK_ACAccountID,
                ICShipmentItemHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight,
                ICShipmentItemWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth,
                ICShipmentItemLength = objSaleOrderItemsInfo.ARSaleOrderItemLength,
                ICShipmentItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber,
                ICShipmentItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys,
                ICShipmentItemOneLevelArea = objDeliveryPlanItemsInfo.ARDeliveryPlanItemOneLevelArea,
                ICShipmentItemTwoLevelArea = objDeliveryPlanItemsInfo.ARDeliveryPlanItemTwoLevelArea,
                ICShipmentItemThreeLevelArea = objDeliveryPlanItemsInfo.ARDeliveryPlanItemThreeLevelArea,
                FK_ICSectionProductID = objDeliveryPlanItemsInfo.FK_ICSectionProductID,
                FK_ACCostCenterID = objDeliveryPlanItemsInfo.FK_ACCostCenterID,
                FK_ICProductAttributeWoodTypeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID,
                FK_GECountryID = objSaleOrderItemsInfo.FK_GECountryID,
                FK_ICProductGroupID = objSaleOrderItemsInfo.FK_ICProductGroupID,
                FK_ICModelID = objSaleOrderItemsInfo.FK_ICModelID,
                FK_PMTemplateItemID = objDeliveryPlanItemsInfo.FK_PMTemplateItemID,
                PMTemplateItemProductName = objDeliveryPlanItemsInfo.PMTemplateItemProductName,
                FK_ARProposalTemplateItemID = objDeliveryPlanItemsInfo.FK_ARProposalTemplateItemID,
                ARProposalTemplateItemProductName = objDeliveryPlanItemsInfo.ARProposalTemplateItemProductName,
                ICShipmentItemWoodQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemWoodQty,
                ICShipmentItemProductFactor = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductFactor,
                ICShipmentItemProductExchangeQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductExchangeQty,
                FK_ICProductAttributeTTMTID = objDeliveryPlanItemsInfo.FK_ICProductAttributeTTMTID,
                ICShipmentItemQuantityOfBox = objDeliveryPlanItemsInfo.ARDeliveryPlanItemQuantityOfBox,
                ICShipmentItemSOName = objDeliveryPlanItemsInfo.ARSaleOrderName,
                ICShipmentItemCode10Combo = objDeliveryPlanItemsInfo.MMBatchProductNo,
                ICShipmentItemContainerSealNumber = objDeliveryPlanItemsInfo.ARDeliveryPlanSeal,
                ICShipmentItemContainerNumber = objDeliveryPlanItemsInfo.ARDeliveryPlanContainersNumber,
                ICShipmentItemComment = objDeliveryPlanItemsInfo.ARDeliveryPlanItemCommand

            };
            objShipmentItemInfo.ICShipmentItemProductUnitCost = AccountHelper.GetProductUnitCost(objShipmentItemInfo.FK_ICStockID, objShipmentItemInfo.FK_ICProductID, objShipmentItemInfo.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
            SetProductCostByProductUnitCost(objShipmentItemInfo);
            return objShipmentItemInfo;
        }

        private void ToShipmentItemInfo(int ARDeliveryPlanID, string DeliveryPlanWorkProductType)
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ARDeliveryPlanWorksController objDeliveryPlanWorksController = new ARDeliveryPlanWorksController();
            List<ARDeliveryPlanWorksInfo> listMaterial = objDeliveryPlanWorksController.GetDeliveryPlanWorksByDeliveryPlanIDAndDeliveryPlanWorkTypeNotInICShipmentItems(ARDeliveryPlanID, DeliveryPlanWorkProductType);
            if (listMaterial.Count > 0)
            {
                foreach (ARDeliveryPlanWorksInfo itemMaterial in listMaterial)
                {
                    if (itemMaterial.ARDeliveryPlanWorkProductType.Equals("Material"))
                    {
                        ICShipmentItemsInfo objShipmentItemInfo = new ICShipmentItemsInfo();
                        objShipmentItemInfo.FK_ICProductID = itemMaterial.FK_ICProductID;
                        objShipmentItemInfo.FK_ICMeasureUnitID = itemMaterial.FK_ICMeasureUnitID;
                        objShipmentItemInfo.ICShipmentItemProductName = itemMaterial.ARDeliveryPlanWorkProductName;
                        objShipmentItemInfo.ICShipmentItemProductDesc = itemMaterial.ARDeliveryPlanWorkProductDesc;
                        objShipmentItemInfo.ICShipmentItemProductType = itemMaterial.ARDeliveryPlanWorkProductType;
                        objShipmentItemInfo.ICShipmentItemProductQty = itemMaterial.ARDeliveryPlanWorkProductQty;
                        objShipmentItemInfo.ICShipmentItemProductBasicQty = itemMaterial.ARDeliveryPlanWorkProductQty;
                        objShipmentItemInfo.ICShipmentItemTotalAmount = itemMaterial.ARDeliveryPlanWorkTotalAmount;
                        objShipmentItemInfo.ICShipmentItemPrice = itemMaterial.ARDeliveryPlanWorkSubTotalAmount;
                        objShipmentItemInfo.ICShipmentItemProductUnitCost = AccountHelper.GetProductUnitCost(objShipmentItemInfo.FK_ICStockID, objShipmentItemInfo.FK_ICProductID, objShipmentItemInfo.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
                        objShipmentItemInfo.ICShipmentItemProductUnitPrice = itemMaterial.ARDeliveryPlanWorkProductUnitPrice;
                        objShipmentItemInfo.FK_ARDeliveryPlanID = itemMaterial.FK_ARDeliveryPlanID;
                        objShipmentItemInfo.FK_ARDeliveryPlanWorkID = itemMaterial.ARDeliveryPlanWorkID;
                        SetProductCostByProductUnitCost(objShipmentItemInfo);
                        ShipmentItemWorkItemList.Add(objShipmentItemInfo);
                    }
                }
            }
        }

        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                entItem.ICShipmentItemTotalAmount = entItem.ICShipmentItemProductQty * entItem.ICShipmentItemProductUnitPrice;
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                //BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
                if (ShipmentItemList.Count() > 0 && ShipmentItemList.FirstOrDefault()?.FK_ARSaleOrderID > 0)
                {
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(ShipmentItemList[0].FK_ARSaleOrderID);
                    if (objSaleOrdersInfo != null)
                    {
                        BOSApp.RoundByCurrency(entItem, objSaleOrdersInfo.FK_GECurrencyID);
                    }
                }
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            //BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICShipmentItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICShipmentItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo shipmentItem = (ICShipmentItemsInfo)item;
                shipmentItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID, shipmentItem);
                shipmentItem.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                shipmentItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                shipmentItem.ICShipmentItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                shipmentItem.ICShipmentItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                shipmentItem.ICShipmentItemProductUnitPrice = objProductsInfo.ICProductPrice01;
                shipmentItem.ICShipmentItemHeight = objProductsInfo.ICProductHeight;
                shipmentItem.ICShipmentItemWidth = objProductsInfo.ICProductWidth;
                shipmentItem.ICShipmentItemLength = objProductsInfo.ICProductLength;
            }
        }

        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
            }
            return base.SaveAccountingData();
        }

        public override bool CancelCompleteTransaction()
        {
            ICShipmentsInfo shipment = (ICShipmentsInfo)MainObject;
            if (shipment.ICShipmentStatus == SaleOrderStatus.Complete.ToString())
            {
                shipment.ICShipmentStatus = SaleOrderStatus.New.ToString();
                shipment.ICShipmentPostedStatus = SaleOrderStatus.New.ToString();
                UpdateMainObject();
            }
            return base.CancelCompleteTransaction();
        }

        public override bool CompleteTransaction()
        {
            ICShipmentsInfo shipment = (ICShipmentsInfo)MainObject;
            shipment.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }

        public void UpdateShipedQtySaleOrderAndDeliveryPlan()
        {
            ICShipmentsInfo shipment = (ICShipmentsInfo)MainObject;
            (new ICShipmentsController()).UpdateShipedQtySaleOrderAndDeliveryPlan(shipment.ICShipmentID, BOSApp.CurrentUsersInfo.ADUserName);
        }
        public void UpdateSaleOrderStatus()
        {
            List<int> saleOrderIDRef = ShipmentItemList.Select(o => o.FK_ARSaleOrderID).ToList();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrderStatusList = objSaleOrdersController.GetStatusSaleOrderByRef(string.Join(",", saleOrderIDRef.Select(o => o.ToString()).ToArray()));
            saleOrderStatusList.ForEach(o =>
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(o.ARSaleOrderID);
                if (objSaleOrdersInfo == null)
                    return;

                objSaleOrdersInfo.ARSaleOrderStatus = o.ARSaleOrderStatus;
                objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
            });
        }

        public void UpdateDeliveryPlanStatus(bool isComplete)
        {
            List<int> deliveryPlanIDRef = ShipmentItemList.Select(o => o.FK_ARDeliveryPlanID).ToList();
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            List<ARDeliveryPlansInfo> deliveryPlanStatusList = objDeliveryPlansController.GetStatusDeliveryPlanByRef(string.Join(",", deliveryPlanIDRef.Select(o => o.ToString()).ToArray()));
            deliveryPlanStatusList.ForEach(o =>
            {
                ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)objDeliveryPlansController.GetObjectByID(o.ARDeliveryPlanID);
                if (objDeliveryPlansInfo == null)
                    return;

                objDeliveryPlansInfo.ARDeliveryPlanStatus = isComplete? DeliveryPlanStatus.Shipmented.ToString() : DeliveryPlanStatus.Completed.ToString();
                objDeliveryPlansController.UpdateObject(objDeliveryPlansInfo);
            });
        }
        public void GenarateShipmentSaleOrder(List<ARSaleOrderItemsInfo> saleOrderItems)
        {
            saleOrderItems.ForEach(o =>
            {
                SetProductCostByProductUnitCost(o);
                ShipmentItemList.Add(ToShipmentItemInfo(o));
            });
        }

        private ICShipmentItemsInfo ToShipmentItemInfo(ARSaleOrderItemsInfo objSaleOrderItemsInfo)
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleOrderItemsInfo.FK_ICProductID);

            ICShipmentItemsInfo objShipmentItemInfo = new ICShipmentItemsInfo()
            {
                FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID,
                ICShipmentItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName,
                ICShipmentItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc,
                ICShipmentItemProductType = objSaleOrderItemsInfo.ARSaleOrderItemProductType,
                ICShipmentItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemShipmentQty,
                ICShipmentItemProductBasicQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemShipmentQty,
                ICShipmentItemProductSerialNo = objSaleOrderItemsInfo.ARSaleOrderItemProductSerialNo,
                ICShipmentItemLotNo = objSaleOrderItemsInfo.ARSaleOrderItemLotNo,
                ICShipmentItemProductAttribute = objSaleOrderItemsInfo.ARSaleOrderItemProductAttribute,
                FK_ICDepartmentID = objSaleOrderItemsInfo.FK_ICDepartmentID,
                FK_ICStockID = objSaleOrderItemsInfo.FK_ICStockID,
                FK_ICProductSerieID = objSaleOrderItemsInfo.FK_ICProductSerieID,
                ICShipmentItemTotalAmount = objSaleOrderItemsInfo.ARSaleOrderItemTotalAmount,
                ICShipmentItemPrice = objSaleOrderItemsInfo.ARSaleOrderItemPrice,
                ICShipmentItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice,
                FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID,
                FK_ACAccountID = objProductsInfo.FK_ACAccountID,
                ICShipmentItemHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight,
                ICShipmentItemWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth,
                ICShipmentItemLength = objSaleOrderItemsInfo.ARSaleOrderItemLength,
                ICShipmentItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber,
                ICShipmentItemOneLevelArea = objSaleOrderItemsInfo.ARSaleOrderItemOneLevelArea,
                ICShipmentItemTwoLevelArea = objSaleOrderItemsInfo.ARSaleOrderItemTwoLevelArea,
                ICShipmentItemThreeLevelArea = objSaleOrderItemsInfo.ARSaleOrderItemThreeLevelArea,
                FK_ICSectionProductID = objSaleOrderItemsInfo.FK_ICSectionProductID,
                FK_ACCostCenterID = objSaleOrderItemsInfo.FK_ACCostCenterID,
                FK_ICProductAttributeWoodTypeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID,
                FK_GECountryID = objSaleOrderItemsInfo.FK_GECountryID,
                FK_ICProductGroupID = objSaleOrderItemsInfo.FK_ICProductGroupID,
                FK_ICModelID = objSaleOrderItemsInfo.FK_ICModelID,
                FK_PMTemplateItemID = objSaleOrderItemsInfo.FK_PMTemplateItemID,
                PMTemplateItemProductName = objSaleOrderItemsInfo.PMTemplateItemProductName,
                FK_ARProposalTemplateItemID = objSaleOrderItemsInfo.FK_ARProposalTemplateItemID,
                ARProposalTemplateItemProductName = objSaleOrderItemsInfo.ARProposalTemplateItemProductName,
                ICShipmentItemQuantityOfBox = objSaleOrderItemsInfo.ARSaleOrderItemQuantityOfBox
            };
            //Add components
            objShipmentItemInfo.ICShipmentItemComponentList = new BOSList<ICShipmentItemComponentsInfo>();
            objShipmentItemInfo.ICShipmentItemComponentList.InitBOSList(this,
                                                                          TableName.ICShipmentItemsTableName,
                                                                          TableName.ICShipmentItemComponentsTableName,
                                                                          BOSList<ICShipmentItemComponentsInfo>.cstRelationForeign);
            objShipmentItemInfo.ICShipmentItemComponentList.ItemTableForeignKey = "FK_ICShipmentItemID";
            ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
            List<ARSOItemComponentsInfo> listSOComponents = objSOItemComponentsController.GetSOItemComponentListBySOItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
            if (listSOComponents != null && listSOComponents.Count > 0)
            {
                objShipmentItemInfo.ICShipmentItemComponentList = new BOSList<ICShipmentItemComponentsInfo>();
                objShipmentItemInfo.ICShipmentItemComponentList.InitBOSList(this,
                                                                              TableName.ICShipmentItemsTableName,
                                                                              TableName.ICShipmentItemComponentsTableName,
                                                                              BOSList<ICShipmentItemComponentsInfo>.cstRelationForeign);
                objShipmentItemInfo.ICShipmentItemComponentList.ItemTableForeignKey = "FK_ICShipmentItemID";
                foreach (ARSOItemComponentsInfo objSOItemComponentsInfo in listSOComponents)
                {
                    ICShipmentItemComponentsInfo objShipmentItemComponentsInfo = new ICShipmentItemComponentsInfo();
                    BOSUtil.CopyObject(objSOItemComponentsInfo, objShipmentItemComponentsInfo);
                    objShipmentItemComponentsInfo.ICShipmentItemComponentQty = objSOItemComponentsInfo.ARSOItemComponentQty - objSOItemComponentsInfo.ARSOItemComponentShippedQty;
                    objShipmentItemInfo.ICShipmentItemComponentList.Add(objShipmentItemComponentsInfo);
                }
            }


            objShipmentItemInfo.ICShipmentItemProductUnitCost = AccountHelper.GetProductUnitCost(objShipmentItemInfo.FK_ICStockID, objShipmentItemInfo.FK_ICProductID, objShipmentItemInfo.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
            SetProductCostByProductUnitCost(objShipmentItemInfo);
            return objShipmentItemInfo;
        }

        public override void CreateMainObjectRule()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);

            DataSet dsColumns = dbUtil.GetNotAllowNullTableColumns(strMainObjectTableName);

            if (dsColumns.Tables.Count > 0)
            {
                AAColumnAliasController objColumnAlliasController = new AAColumnAliasController();
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    String strColumnName = rowColumn["COLUMN_NAME"].ToString();
                    String strBrokenRuleDescription = String.Empty;
                    //Add rule if column is not primary key and FK_ICStockID
                    if (!dbUtil.IsPrimaryKey(strMainObjectTableName, strColumnName) && !strColumnName.Equals("FK_ICStockID"))
                    {
                        //If column does not allow null
                        if (!dbUtil.ColumnIsAllowNull(strMainObjectTableName, strColumnName))
                        {
                            AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(a => a.AATableName == strMainObjectTableName
                            && a.AAColumnAliasName == strColumnName).FirstOrDefault();
                            if (objColumnAliasInfo != null)
                            {
                                strBrokenRuleDescription = String.Format(string.Format(BaseLocalizedResources.ColumnRequiredMessage, objColumnAliasInfo.AAColumnAliasCaption));
                            }
                            else
                            {
                                strBrokenRuleDescription = String.Format(string.Format(BaseLocalizedResources.ColumnRequiredMessage, strColumnName));
                            }

                            if (((IBaseModuleERP)Module).IsForeignKey(strMainObjectTableName, strColumnName))
                            {
                                BusinessRule foreignKeyRule = new BusinessRule(
                                                                    strColumnName,
                                                                    strBrokenRuleDescription,
                                                                    IsValidForeignKeyProperty);
                                MainObject.BusinessRuleCollections.Add(foreignKeyRule);
                            }
                            else
                            {
                                BusinessRule nonForeignKeyRule = new BusinessRule(strColumnName, strBrokenRuleDescription, IsValidNonForeignKeyPropety);
                                MainObject.BusinessRuleCollections.Add(nonForeignKeyRule);
                            }
                        }
                    }
                }
            }
            dsColumns.Dispose();
        }
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ShipmentItemList.DeleteItemObjects();
                ShipmentItemWorkItemList.DeleteItemObjects();
                ComponentShipmentItemList.DeleteItemObjects();
                ShipmentPackageList.DeleteItemObjects();
            }
        }

        public override void SetProductPriceByProductUnitPrice(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1M;

            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            int saleorderID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ARSaleOrderID"));
            //round by currency
            int currencyID = 0;
            int decimalNumber = 0;
            if (saleorderID > 0)
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(saleorderID);
                if (objSaleOrdersInfo != null)
                {
                    currencyID = objSaleOrdersInfo.FK_GECurrencyID;
                    decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);
                }
            }
            else
            {
                currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
                decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);
            }    
                
            //Math Round Start
            //ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            unitPrice = Math.Round(unitPrice, decimalNumber);

            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Math Round Qty
            //if (objProductsInfo != null)
            //{
            //    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
            //    {
            //        qty = Math.Round(qty, 4, MidpointRounding.AwayFromZero);
            //    }
            //    else
            //    {
            //        qty = Math.Round(qty, 3, MidpointRounding.AwayFromZero);
            //    }
            //}
            //End

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            extPrice = Math.Round(extPrice, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Get or set item discount percent and amount
            string discountPercentColumnName = itemTablePrefix + "ProductDiscount";
            string discountAmountColumnName = itemTablePrefix + "DiscountAmount";

            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountPercentColumnName));

            decimal discountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountAmountColumnName));
            discountAmount = Math.Round(discountAmount, decimalNumber);

            //decimal oldDiscountAmount = 0;
            //if (item.OldObject == null)
            //{
            //    item.OldObject = (BusinessObject)item.Clone();
            //}
            //if (item.OldObject != null)
            //{
            //    oldDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, discountAmountColumnName));
            //}
            //if (discountAmount != oldDiscountAmount)
            //{
            //    if (extPrice > 0)
            //    {
            //        discountPercent = discountAmount / extPrice * 100;
            //        dbUtil.SetPropertyValue(item, discountPercentColumnName, discountPercent);
            //    }
            //    discountAmount = extPrice * discountPercent / 100;
            //    discountAmount = Math.Round(discountAmount, decimalNumber);

            //    dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            //}
            //else
            //{
            //    discountAmount = extPrice * discountPercent / 100;
            //    discountAmount = Math.Round(discountAmount, decimalNumber);

            //    dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            //}

            discountAmount = extPrice * discountPercent / 100;
            discountAmount = Math.Round(discountAmount, decimalNumber);
            dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);

            //Get or set tax percent and amount
            string taxPercentColumnName = itemTablePrefix + "ProductTaxPercent";
            string taxAmountColumnName = itemTablePrefix + "TaxAmount";

            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxPercentColumnName));
            decimal taxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxAmountColumnName));

            taxAmount = Math.Round(taxAmount, decimalNumber);

            decimal oldTaxAmount = 0;
            if (item.OldObject != null)
            {
                oldTaxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, taxAmountColumnName));
            }
            if (taxAmount != oldTaxAmount)
            {
                //if (netAmount - discountAmount > 0)
                //{
                //    taxPercent = taxAmount / (netAmount - discountAmount) * 100;
                //    dbUtil.SetPropertyValue(item, taxPercentColumnName, taxPercent);
                //}            
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                taxAmount = Math.Round(taxAmount, decimalNumber);

                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }
            else
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                taxAmount = Math.Round(taxAmount, decimalNumber);

                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(item, columnName, (qty * unitCost) * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(item, columnName, unitCost / (factor != 0 ? factor : 1) * exchangeRate);

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, qty * factor);

            BOSApp.RoundByCurrency(item, currencyID);

            item.OldObject = (BusinessObject)item.Clone();
        }
    }
}

