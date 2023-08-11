using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.AllocationEquipment
{
    public class AllocationEquipmentEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ARAllocationItemsInfo> AllocationItemsList { get; set; }

        #endregion

        #region Constructor
        public AllocationEquipmentEntities()
            : base()
        {
            AllocationItemsList = new BOSList<ARAllocationItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARAllocationsInfo();
            SearchObject = new ARAllocationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARAllocationItemsTableName, new ARAllocationItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AllocationItemsList.InitBOSList(this,
                                            TableName.ARAllocationsTableName,
                                            TableName.ARAllocationItemsTableName,
                                            BOSList<ARAllocationItemsInfo>.cstRelationForeign);
            AllocationItemsList.ItemTableForeignKey = "FK_ARAllocationID";
        }

        public override void InitGridControlInBOSList()
        {
            AllocationItemsList.InitBOSListGridControl(AllocationEquipmentModule.ARAllocationItemsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AllocationItemsList.SetDefaultListAndRefreshGridControl();
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

            ARAllocationsInfo objAllocationsInfo = (ARAllocationsInfo)MainObject;
            objAllocationsInfo.ARAllocationDate = BOSApp.GetCurrentServerDate();
            objAllocationsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            AllocationItemsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            AllocationItemsList.SaveItemObjects();
        }

        public void GenerateEntitiesFromDeliveryPlanWorkAssets(List<ARDeliveryPlanWorksInfo> deliveryPlanWorkAssets)
        {
            ARAllocationsInfo objAllocationsInfo = (ARAllocationsInfo)MainObject;
            objAllocationsInfo.FK_ARDeliveryPlanID = deliveryPlanWorkAssets[0].FK_ARDeliveryPlanID;
            objAllocationsInfo.FK_PMProjectID = deliveryPlanWorkAssets[0].FK_PMProjectID;
            UpdateMainObjectBindingSource();
            deliveryPlanWorkAssets.ForEach(o =>
            {
                for (int i = 0; i < o.ARDeliveryPlanWorkProductQty; i++)
                    AllocationItemsList.Add(ToAllocationItem(o));
            });
        }

        public ARAllocationItemsInfo ToAllocationItem(ARDeliveryPlanWorksInfo objDeliveryPlanWorkAssetsInfo)
        {
            return new ARAllocationItemsInfo()
            {
                ARAllocationItemNo = objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkProductNo,
                ARAllocationItemName = objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkProductName,
                ARAllocationItemDesc = objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkProductDesc,
                ARAllocationItemQty = objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkProductQty >= 1 ? 1 : 0,
                FK_ARSaleOrderID = objDeliveryPlanWorkAssetsInfo.FK_ARSaleOrderID,
                FK_ICProductID = objDeliveryPlanWorkAssetsInfo.FK_ICProductID,
                FK_ARDeliveryPlanWorkID = objDeliveryPlanWorkAssetsInfo.ARDeliveryPlanWorkID
            };
        }

        public override bool CompleteTransaction()
        {
            ARAllocationsInfo objAllocationsInfo = (ARAllocationsInfo)MainObject;
            objAllocationsInfo.ARAllocationStatus = AllocationStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ARAllocationsInfo objAllocationsInfo = (ARAllocationsInfo)MainObject;
                ARAllocationItemsInfo objAllocationItemsInfo = (ARAllocationItemsInfo)ModuleObjects[TableName.ARAllocationItemsTableName];
                objAllocationItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID);
                //objAllocationItemsInfo.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                //objAllocationItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objAllocationItemsInfo.ARAllocationItemNo = objProductsInfo.ICProductNo;
                objAllocationItemsInfo.ARAllocationItemName = objProductsInfo.ICProductName;
                objAllocationItemsInfo.ARAllocationItemDesc = objProductsInfo.ICProductDesc;
                UpdateModuleObjectBindingSource(TableName.ARAllocationItemsTableName);
            }
        }
    }
}
