using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ChangeBOMInformation
{
    public class ChangeBOMInformationEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<MMChangeBOMInformationItemsInfo> ChangeBOMInformationItemList { get; set; }

        public BOSList<GEObjectHistoryInfo> ProfileManagementHistoryList { get; set; }

        #region Batch Product Item List
        public BOSList<MMBatchProductProductionNormItemsInfo> BatchProductProductionNormItemList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> ProductionNormItemHardwareList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> ProductionNormItemPackagingList { get; set; }
        public BOSList<MMBatchProductProductionNormItemsInfo> ProductionNormItemPaintList { get; set; }
        #endregion
        #endregion

        #region Contructors
        public ChangeBOMInformationEntities()
            : base()
        {
            ChangeBOMInformationItemList = new BOSList<MMChangeBOMInformationItemsInfo>();

            ProfileManagementHistoryList = new BOSList<GEObjectHistoryInfo>();

            BatchProductProductionNormItemList = new BOSList<MMBatchProductProductionNormItemsInfo>();
            ProductionNormItemHardwareList = new BOSList<MMBatchProductProductionNormItemsInfo>();
            ProductionNormItemPackagingList = new BOSList<MMBatchProductProductionNormItemsInfo>();
            ProductionNormItemPaintList = new BOSList<MMBatchProductProductionNormItemsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMChangeBOMInformationsInfo();
            SearchObject = new MMChangeBOMInformationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMChangeBOMInformationItemsTableName, new MMChangeBOMInformationItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ChangeBOMInformationItemList.InitBOSList(
                                        this,
                                        TableName.MMChangeBOMInformationsTableName,
                                        TableName.MMChangeBOMInformationItemsTableName,
                                        BOSList<MMChangeBOMInformationItemsInfo>.cstRelationForeign);
            ChangeBOMInformationItemList.ItemTableForeignKey = "FK_MMChangeBOMInformationID";

            ProfileManagementHistoryList.InitBOSList(this,
                                           string.Empty,
                                           TableName.GEObjectHistoryTableName,
                                           BOSList<GEObjectHistoryInfo>.cstRelationNone);

            BatchProductProductionNormItemList.InitBOSList(this,
                                               string.Empty,
                                               TableName.MMBatchProductProductionNormItemsTableName,
                                               BOSTreeList.cstRelationNone);


            ProductionNormItemHardwareList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMBatchProductProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);

            ProductionNormItemPackagingList.InitBOSList(this,
                                               string.Empty,
                                               TableName.MMBatchProductProductionNormItemsTableName,
                                               BOSTreeList.cstRelationNone);

            ProductionNormItemPaintList.InitBOSList(this,
                                              string.Empty,
                                              TableName.MMBatchProductProductionNormItemsTableName,
                                              BOSTreeList.cstRelationNone);

        }

        public override void InitGridControlInBOSList()
        {
            ChangeBOMInformationItemList.InitBOSListGridControl();

            ProfileManagementHistoryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)MainObject;
            objChangeBOMInformationsInfo.MMChangeBOMInformationDate = DateTime.Now;
            objChangeBOMInformationsInfo.MMChangeBOMInformationStatus = ChangeBOMInformationStatus.New.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ChangeBOMInformationItemList.SetDefaultListAndRefreshGridControl();

                ProfileManagementHistoryList.SetDefaultListAndRefreshGridControl();
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
            ChangeBOMInformationItemList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();

            ChangeBOMInformationItemList.SaveItemObjects();
        }

        #endregion Override BaseTransactionEntities
        public void InvalidateBatchProductItemList(int batchProductID)
        {
            MMBatchProductProductionNormItemsController obj = new MMBatchProductProductionNormItemsController();

            List<MMBatchProductProductionNormItemsInfo> list = obj.GetAllProductionNormItemsByGroupTypeAndBatchProductID(ProductType.SemiProduct.ToString(), batchProductID);
            BatchProductProductionNormItemList.Invalidate(list);

            list = obj.GetAllProductionNormItemsByGroupTypeAndBatchProductID(ProductType.Hardware.ToString(), batchProductID);
            ProductionNormItemHardwareList.Invalidate(list);

            list = obj.GetAllProductionNormItemsByGroupTypeAndBatchProductID(ProductType.IngredientPackaging.ToString(), batchProductID);
            ProductionNormItemPackagingList.Invalidate(list);

            list = obj.GetAllProductionNormItemsByGroupTypeAndBatchProductID(ProductType.IngredientPaint.ToString(), batchProductID);
            ProductionNormItemPaintList.Invalidate(list);

        }

    }
}
