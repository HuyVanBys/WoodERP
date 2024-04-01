using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;

namespace BOSERP.Modules.SaleOrder
{
    public class SaleOrderEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets history detail list
        /// </summary>
        public BOSList<ARHistoryDetailsInfo> SaleOrderProfilesList { get; set; }

        public BOSList<ARHistoryDetailsInfo> SOItemProfilesList { get; set; }

        public BOSItemsEntityList<ARSaleOrderItemsInfo> ARSaleOrderItemsList { get; set; }

        public BOSList<ARCustomerPaymentDetailsInfo> ARCustomerPaymentDetailsList { get; set; }

        public SortedList<int, ARProposalItemsInfo> ARReferenceProposalItems { get; set; }

        public BOSList<ARSaleOrderTemplatesInfo> SaleOrderTemplatesList { get; set; }

        public Dictionary<int, string> SaleOrderTemplateURLDic { get; set; }

        public BOSList<ARDocumentPaymentsInfo> DocumentPaymentList { get; set; }

        public BOSItemsEntityList<ARSaleOrderItemsInfo> ComponentSaleOrderItemList { get; set; }

        public BOSList<ARSaleOrderPaymentTimesInfo> ARSaleOrderPaymentTimesList { get; set; }

        public BOSList<ARSaleOrderItemContainersInfo> SaleOrderItemContainerList { get; set; }

        public BOSList<ARSaleOrderItemWorksInfo> ARSaleOrderItemWorkList { get; set; }

        public BOSList<ARSaleOrderItemWorkTasksInfo> ARSaleOrderItemWorkTaskList { get; set; }

        public BOSList<ARSaleOrderItemWorksInfo> ARSaleOrderItemWorkMaterialList { get; set; }

        public BOSList<ARSaleOrderItemWorksInfo> ARSaleOrderItemWorkAssetList { get; set; }

        public BOSList<ARSaleOrderItemWorksInfo> ARSaleOrderItemCostList { get; set; }

        public BOSList<ARSaleOrderItemWorksInfo> ARSaleOrderItemCostExternalList { get; set; }

        public List<ARSaleOrderPaymentTimeTemplatesInfo> PaymentTimeTemplateList { get; set; }

        public BOSList<ARCommissionsInfo> SaleCommissionsList { get; set; }

        public BOSList<ARSaleOrderItemsInfo> SaleOrderItemFollowList { get; set; }

        public BOSList<ARSalesmansInfo> ARSalesmansList { get; set; }

        public BOSList<ARSaleOrderItemOtherFeesInfo> SaleOrderItemOtherFeeList { get; set; }

        public BOSList<ARSaleOrderItemAllocationFeesInfo> SaleOrderItemAllocationFeeList { get; set; }
        #endregion

        #region Constructor
        public SaleOrderEntities()
            : base()
        {
            ARSaleOrderItemsList = new BOSItemsEntityList<ARSaleOrderItemsInfo>();

            ARReferenceProposalItems = new SortedList<int, ARProposalItemsInfo>();

            SaleOrderTemplatesList = new BOSList<ARSaleOrderTemplatesInfo>();

            DocumentPaymentList = new BOSList<ARDocumentPaymentsInfo>();

            ComponentSaleOrderItemList = new BOSItemsEntityList<ARSaleOrderItemsInfo>();

            ARSaleOrderPaymentTimesList = new BOSList<ARSaleOrderPaymentTimesInfo>();

            SaleOrderItemContainerList = new BOSList<ARSaleOrderItemContainersInfo>();

            ARSaleOrderItemWorkList = new BOSList<ARSaleOrderItemWorksInfo>();

            ARSaleOrderItemWorkTaskList = new BOSList<ARSaleOrderItemWorkTasksInfo>();

            ARSaleOrderItemWorkMaterialList = new BOSList<ARSaleOrderItemWorksInfo>();

            ARSaleOrderItemWorkAssetList = new BOSList<ARSaleOrderItemWorksInfo>();

            ARSaleOrderItemCostList = new BOSList<ARSaleOrderItemWorksInfo>();

            ARSaleOrderItemCostExternalList = new BOSList<ARSaleOrderItemWorksInfo>();

            PaymentTimeTemplateList = new List<ARSaleOrderPaymentTimeTemplatesInfo>();

            SaleCommissionsList = new BOSList<ARCommissionsInfo>();

            SaleOrderProfilesList = new BOSList<ARHistoryDetailsInfo>();

            SOItemProfilesList = new BOSList<ARHistoryDetailsInfo>();

            SaleOrderItemFollowList = new BOSList<ARSaleOrderItemsInfo>();

            ARSalesmansList = new BOSList<ARSalesmansInfo>();

            SaleOrderItemOtherFeeList = new BOSList<ARSaleOrderItemOtherFeesInfo>();

            SaleOrderItemAllocationFeeList = new BOSList<ARSaleOrderItemAllocationFeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARSaleOrdersInfo();
            SearchObject = new ARSaleOrdersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARSaleOrderItemsTableName, new ARSaleOrderItemsInfo());
            ModuleObjects.Add(TableName.ARDocumentPaymentsTableName, new ARDocumentPaymentsInfo());
            ModuleObjects.Add(TableName.ARSaleOrderTemplatesTableName, new ARSaleOrderTemplatesInfo());
            ModuleObjects.Add(TableName.ARSaleOrderItemContainersTableName, new ARSaleOrderItemContainersInfo());
            ModuleObjects.Add(TableName.ICProductWorkItemsTableName, new ICProductWorkItemsInfo());
            ModuleObjects.Add(TableName.ARSaleOrderItemWorksTableName, new ARSaleOrderItemWorksInfo());
            ModuleObjects.Add(TableName.ARSaleOrderItemWorkTasksTableName, new ARSaleOrderItemWorkTasksInfo());
            ModuleObjects.Add(TableName.ARSaleOrderHistorysTableName, new ARSaleOrderHistorysInfo());
            ModuleObjects.Add(TableName.ARCommissionsTableName, new ARCommissionsInfo());
            ModuleObjects.Add(TableName.ARSaleOrderItemOtherFeesTableName, new ARSaleOrderItemOtherFeesInfo());
            ModuleObjects.Add(TableName.ARSaleOrderItemAllocationFeesTableName, new ARSaleOrderItemAllocationFeesInfo());
        }

        public override void InitModuleObjectList()
        {
            ARSaleOrderItemsList = new BOSItemsEntityList<ARSaleOrderItemsInfo>();
            ARSaleOrderItemsList.InitBOSList(this, TableName.ARSaleOrdersTableName, TableName.ARSaleOrderItemsTableName);

            DocumentPaymentList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.ARDocumentPaymentsTableName,
                                          BOSList<ARInvoicesInfo>.cstRelationNone);
            ComponentSaleOrderItemList.InitBOSList(
                                                this,
                                                TableName.ARSaleOrdersTableName,
                                                TableName.ARSaleOrderItemsTableName,
                                                BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            ComponentSaleOrderItemList.ItemTableForeignKey = "FK_ARSaleOrderID";

            SaleOrderTemplatesList.InitBOSList(this,
                                                TableName.ARSaleOrdersTableName,
                                                TableName.ARSaleOrderTemplatesTableName,
                                                BOSList<ARSaleOrderTemplatesInfo>.cstRelationForeign);
            SaleOrderTemplatesList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSaleOrderPaymentTimesList.InitBOSList(
                                              this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderPaymentTimesTableName,
                                              BOSList<ARSaleOrderPaymentTimesInfo>.cstRelationForeign);
            ARSaleOrderPaymentTimesList.ItemTableForeignKey = "FK_ARSaleOrderID";

            SaleOrderItemContainerList.InitBOSList(this,
                                                    TableName.ARSaleOrdersTableName,
                                                    TableName.ARSaleOrderItemContainersTableName,
                                                    BOSList<ARSaleOrderItemContainersInfo>.cstRelationForeign);
            SaleOrderItemContainerList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSaleOrderItemWorkList.InitBOSList(this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderItemWorksTableName,
                                              BOSList<ARSaleOrderItemWorksInfo>.cstRelationForeign);
            ARSaleOrderItemWorkList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSaleOrderItemWorkTaskList.InitBOSList(this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderItemWorkTasksTableName,
                                              BOSList<ARSaleOrderItemWorkTasksInfo>.cstRelationForeign);
            ARSaleOrderItemWorkTaskList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSaleOrderItemWorkMaterialList.InitBOSList(this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderItemWorksTableName,
                                              BOSList<ARSaleOrderItemWorksInfo>.cstRelationForeign);
            ARSaleOrderItemWorkMaterialList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSaleOrderItemWorkAssetList.InitBOSList(this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderItemWorksTableName,
                                              BOSList<ARSaleOrderItemWorksInfo>.cstRelationForeign);
            ARSaleOrderItemWorkAssetList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSaleOrderItemCostList.InitBOSList(this,
                                                TableName.ARSaleOrdersTableName,
                                                TableName.ARSaleOrderItemWorksTableName,
                                                BOSList<ARSaleOrderItemWorksInfo>.cstRelationForeign);
            ARSaleOrderItemCostList.ItemTableForeignKey = "FK_ARSaleOrderID";

            SaleCommissionsList.InitBOSList(this,
                                             TableName.ARSaleOrdersTableName,
                                             TableName.ARCommissionsTableName,
                                             BOSList<ARCommissionsInfo>.cstRelationForeign);
            SaleCommissionsList.ItemTableForeignKey = "FK_ARSaleOrderID";

            SaleOrderProfilesList.InitBOSList(this,
                                          null,
                                          TableName.ARHistoryDetailsTable,
                                          BOSList<ARHistoryDetailsInfo>.cstRelationNone);

            SOItemProfilesList.InitBOSList(this,
                                          null,
                                          TableName.ARHistoryDetailsTable,
                                          BOSList<ARHistoryDetailsInfo>.cstRelationNone);

            SaleOrderItemFollowList.InitBOSList(this
                                                , TableName.ARSaleOrdersTableName
                                                , TableName.ARSaleOrderItemsTableName
                                                , BOSList<ARHistoryDetailsInfo>.cstRelationForeign);
            SaleOrderItemFollowList.ItemTableForeignKey = "FK_ARSaleOrderID";

            ARSalesmansList.InitBOSList(this
                                    , TableName.ARSaleOrdersTableName
                                    , TableName.ARSalesmansTableName
                                    , BOSList<ARHistoryDetailsInfo>.cstRelationForeign);
            ARSalesmansList.ItemTableForeignKey = "FK_ARSaleOrderID";


            SaleOrderItemAllocationFeeList.InitBOSList(this,
                                                        TableName.ARSaleOrdersTableName,
                                                        TableName.ARSaleOrderItemAllocationFeesTableName,
                                                        BOSList<ARSaleOrderItemAllocationFeesInfo>.cstRelationForeign);
            SaleOrderItemAllocationFeeList.ItemTableForeignKey = "FK_ARSaleOrderID";

            SaleOrderItemOtherFeeList.InitBOSList(this,
                                                    TableName.ARSaleOrdersTableName,
                                                    TableName.ARSaleOrderItemOtherFeesTableName,
                                                    BOSList<ARSaleOrderItemOtherFeesInfo>.cstRelationForeign);
            SaleOrderItemOtherFeeList.ItemTableForeignKey = "FK_ARSaleOrderID";
        }

        public override void InitGridControlInBOSList()
        {
            ARSaleOrderItemsList.InitBOSListGridControl();

            DocumentPaymentList.InitBOSListGridControl();

            SaleOrderTemplatesList.InitBOSListGridControl("fld_dgcARSaleOrderTemplatesGridControl");

            ARSaleOrderPaymentTimesList.InitBOSListGridControl();

            SaleOrderItemContainerList.InitBOSListGridControl();

            ARSaleOrderItemWorkList.InitBOSListGridControl(SaleOrderModule.ARSaleOrderItemWorksGridControlName);

            ARSaleOrderItemWorkMaterialList.InitBOSListGridControl(SaleOrderModule.ARSaleOrderItemWorkMaterialsGridControlName);

            ARSaleOrderItemWorkAssetList.InitBOSListGridControl(SaleOrderModule.ARSaleOrderItemWorkAssetsGridControlName);

            ARSaleOrderItemWorkTaskList.InitBOSListGridControl(SaleOrderModule.ARSaleOrderItemWorkTasksGridControlName);

            ARSaleOrderItemCostList.InitBOSListGridControl(SaleOrderModule.ARSaleOrderItemCostGridControlName);

            SaleCommissionsList.InitBOSListGridControl("fld_dgcCommissionsGridControl");

            SOItemProfilesList.InitBOSListGridControl("fld_dgcSOItemProfilesGridControl");

            SaleOrderProfilesList.InitBOSListGridControl("fld_dgcSaleOrderProfilesGridControl");

            SaleOrderItemFollowList.InitBOSListGridControl("fld_dgcSaleOrderItemFollowsGridControl");

            SaleOrderItemAllocationFeeList.InitBOSListGridControl(SaleOrderModule.SaleOrderItemAllocationFeesGridControlName);

            SaleOrderItemOtherFeeList.InitBOSListGridControl(SaleOrderModule.SaleOrderItemOtherFeesGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ARSaleOrderItemsList.SetDefaultListAndRefreshGridControl();

                DocumentPaymentList.SetDefaultListAndRefreshGridControl();

                ComponentSaleOrderItemList.SetDefaultListAndRefreshGridControl();

                SaleOrderTemplatesList.SetDefaultListAndRefreshGridControl();

                ARSaleOrderPaymentTimesList.SetDefaultListAndRefreshGridControl();

                SaleOrderItemContainerList.SetDefaultListAndRefreshGridControl();

                ARSaleOrderItemWorkList.SetDefaultListAndRefreshGridControl();

                ARSaleOrderItemWorkTaskList.SetDefaultListAndRefreshGridControl();

                ARSaleOrderItemWorkMaterialList.SetDefaultListAndRefreshGridControl();

                ARSaleOrderItemWorkAssetList.SetDefaultListAndRefreshGridControl();

                ARSaleOrderItemCostList.SetDefaultListAndRefreshGridControl();

                SaleCommissionsList.SetDefaultListAndRefreshGridControl();

                SOItemProfilesList.SetDefaultListAndRefreshGridControl();

                SaleOrderProfilesList.SetDefaultListAndRefreshGridControl();

                SaleOrderItemFollowList.SetDefaultListAndRefreshGridControl();

                SaleOrderItemAllocationFeeList.SetDefaultListAndRefreshGridControl();

                SaleOrderItemOtherFeeList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region SetDefault
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.ARSaleOrderTypeCombo = SaleOrderType.SaleOrder.ToString();
            objSaleOrdersInfo.ARSaleOrderBatchStatus = string.Empty;
            objSaleOrdersInfo.ARSaleOrderDate = BOSApp.GetCurrentServerDate();
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = BOSApp.GetCurrentServerDate();
            objSaleOrdersInfo.ARSaleOrderDeliveryActualDate = BOSApp.GetCurrentServerDate();
            objSaleOrdersInfo.ARSaleOrderValidateDate = BOSApp.GetCurrentServerDate();
            objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.New.ToString();
            objSaleOrdersInfo.FK_ARPriceLevelID = 0;
            objSaleOrdersInfo.FK_ARSellerID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objSaleOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSaleOrdersInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objSaleOrdersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objSaleOrdersInfo.ARSaleOrderExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objSaleOrdersInfo.ARSaleOrderMainSellerCommissionPercent = 100;
            objSaleOrdersInfo.ARSaleOrderType = SaleOrderType.MassProduction.ToString();
            objSaleOrdersInfo.ARSaleOrderDocumentType = SaleOrderDocumentType.SaleOrder.ToString();
            objSaleOrdersInfo.ARSaleOrderItemGrantedFrom = SaleOrderItemGrantedFrom.Inventory.ToString();
            // string a = objSaleOrdersInfo.ARSaleOrderProductType;
            objSaleOrdersInfo.FK_GEPaymentTermID = 1;
            objSaleOrdersInfo.FK_GECurrencyID2 = 100001;
            objSaleOrdersInfo.ARSaleOrderExchangeRate2 = (GetCurrencyExchangeRate(objSaleOrdersInfo.FK_GECurrencyID2, BOSApp.GetCurrentServerDate()) != null)
                ? GetCurrencyExchangeRate(objSaleOrdersInfo.FK_GECurrencyID2, BOSApp.GetCurrentServerDate()).GECurrencyExchangeRateTransferExchangeRate
                : 1;
            UpdateMainObjectBindingSource();
        }
        #endregion

        #region Invalidate Main And Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARSaleOrderItemsController objPurchaseOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            DataSet ds = objPurchaseOrderItemsController.GetAllDataBySaleOrderID(iObjectID);
            ARSaleOrderItemsList.Invalidate(ds);            
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in ARSaleOrderItemsList)
            {
                if (objSaleOrderItemsInfo.ComponentCount > 0)
                {
                    objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                    objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(
                                                                        this,
                                                                        TableName.ARSaleOrderItemsTableName,
                                                                        TableName.ARSOItemComponentsTableName,
                                                                        BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                    objSaleOrderItemsInfo.ARSOItemComponentList.ItemTableForeignKey = "FK_ARSaleOrderItemID";

                    ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
                    List<ARSOItemComponentsInfo> components = objSOItemComponentsController.GetSOItemComponentListBySOItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
                    objSaleOrderItemsInfo.ARSOItemComponentList.Invalidate(components);
                }
            }

            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                entItem.ARSaleOrderItemRemainedQty = entItem.ARSaleOrderItemProductQty - entItem.ARSaleOrderItemCanceledQty - entItem.ARSaleOrderItemShippedQty;
            }
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            List<ARDocumentPaymentsInfo> payments = objDocumentPaymentsController.GetDocumentPaymentsBySaleOrderNo(objSaleOrdersInfo.ARSaleOrderNo);
            DocumentPaymentList.Invalidate(payments);
            ARSaleOrderItemsInfo objCheckComponentsInfo = ARSaleOrderItemsList.Where(s => s.ComponentCount > 0).FirstOrDefault();
            if (objCheckComponentsInfo != null)
                InvalidateItemComponents();
            else
            {
                ComponentSaleOrderItemList.OriginalList.Clear();
                foreach (ARSaleOrderItemsInfo item in ARSaleOrderItemsList)
                {
                    ComponentSaleOrderItemList.Add((ARSaleOrderItemsInfo)item.Clone());
                }

                foreach (ARSaleOrderItemsInfo item in ComponentSaleOrderItemList)
                {
                    ComponentSaleOrderItemList.OriginalList.Add((ARSaleOrderItemsInfo)item.Clone());
                }
            }
            ComponentSaleOrderItemList.BackupList.Clear();
            if (objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString() ||
                objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Incomplete.ToString())
            {
                foreach (ARSaleOrderItemsInfo item in ComponentSaleOrderItemList)
                {
                    ComponentSaleOrderItemList.BackupList.Add((ARSaleOrderItemsInfo)item.Clone());
                }
            }

            ARSaleOrderTemplatesController objSaleOrderTemplatesController = new ARSaleOrderTemplatesController();
            List<ARSaleOrderTemplatesInfo> teamplateList = objSaleOrderTemplatesController.GetSOTemplateBySaleOrderID(iObjectID);
            SaleOrderTemplatesList.Invalidate(teamplateList);

            ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
            List<ARSaleOrderPaymentTimesInfo> listPaymentTime = (List<ARSaleOrderPaymentTimesInfo>)objSaleOrderPaymentTimesController.GetListPaymentTimeBySaleOrderID(iObjectID);
            ARSaleOrderPaymentTimesList.Invalidate(listPaymentTime);
            if (((SaleOrderModule)this.Module).TabModuleList.Contains("fld_tabSOItemContainers"))
                SaleOrderItemContainerList.Invalidate(iObjectID);
            SaleOrderModule.Printed = false;
            if (((SaleOrderModule)this.Module).TabModuleList.Contains("xtraTabPage4"))
            {
                ARSaleOrderItemWorksController objSaleOrderItemWorksController = new ARSaleOrderItemWorksController();
                List<ARSaleOrderItemWorksInfo> saleOrderItemWorks = objSaleOrderItemWorksController.GetItemWorksBySaleOrderID(iObjectID);

                List<ARSaleOrderItemWorksInfo> saleOrderItemWorksForSaleOrderItemWorkList
                                    = saleOrderItemWorks.Where(o => o.ARSaleOrderItemWorkProductType != ProductItemType.Asset.ToString()
                                                              && o.ARSaleOrderItemWorkProductType != ProductItemType.Material.ToString()
                                                              && o.ARSaleOrderItemWorkProductType != ProductItemType.Service.ToString()).ToList();

                ARSaleOrderItemWorkList.Invalidate(saleOrderItemWorksForSaleOrderItemWorkList);
                List<ARSaleOrderItemWorksInfo> materialList = saleOrderItemWorks.Where(t => t.ARSaleOrderItemWorkProductType == ProductItemType.Material.ToString()).ToList();
                ARSaleOrderItemWorkMaterialList.Invalidate(materialList);

                ARSaleOrderItemWorkList.ForEach(o =>
                {
                    if (o.ARSaleOrderItemWorkMaterialList == null)
                    {
                        o.ARSaleOrderItemWorkMaterialList = new BOSList<ARSaleOrderItemWorksInfo>();
                        o.ARSaleOrderItemWorkMaterialList.InitBOSList(this,
                                                      TableName.ARSaleOrderItemWorksTableName,
                                                      TableName.ARSaleOrderItemWorksTableName,
                                                      BOSList<ARProposalItemWorksInfo>.cstRelationParent);
                    }

                    foreach (ARSaleOrderItemWorksInfo work in ARSaleOrderItemWorkMaterialList)
                    {
                        if (work.ARSaleOrderItemWorkParentID == o.ARSaleOrderItemWorkID)
                        {
                            o.ARSaleOrderItemWorkMaterialList.Add(work);
                        }
                    }

                });

                List<ARSaleOrderItemWorksInfo> assetList = saleOrderItemWorks.Where(t => t.ARSaleOrderItemWorkProductType == ProductItemType.Asset.ToString()).ToList();
                ARSaleOrderItemWorkAssetList.Invalidate(assetList);
                ARSaleOrderItemWorkList.ForEach(o =>
                {
                    if (o.ARSaleOrderItemWorkAssetList == null)
                    {
                        o.ARSaleOrderItemWorkAssetList = new BOSList<ARSaleOrderItemWorksInfo>();
                        o.ARSaleOrderItemWorkAssetList.InitBOSList(this,
                                                      TableName.ARSaleOrderItemWorksTableName,
                                                      TableName.ARSaleOrderItemWorksTableName,
                                                      BOSList<ARProposalItemWorksInfo>.cstRelationParent);
                    }

                    foreach (ARSaleOrderItemWorksInfo work in ARSaleOrderItemWorkAssetList)
                    {
                        if (work.ARSaleOrderItemWorkParentID == o.ARSaleOrderItemWorkID)
                        {
                            o.ARSaleOrderItemWorkAssetList.Add(work);
                        }
                    }

                });

                ARSaleOrderItemWorkTasksController objSaleOrderItemWorkTasksController = new ARSaleOrderItemWorkTasksController();
                List<ARSaleOrderItemWorkTasksInfo> saleOrderItemWorkTasks = objSaleOrderItemWorkTasksController.GetItemWorkTasksBySaleOrderID(iObjectID);
                ARSaleOrderItemWorkTaskList.Invalidate(saleOrderItemWorkTasks);

                ARSaleOrderItemWorkList.ForEach(o =>
                {
                    if (o.ARSaleOrderItemWorkTaskList == null)
                    {
                        o.ARSaleOrderItemWorkTaskList = new BOSList<ARSaleOrderItemWorkTasksInfo>();
                        o.ARSaleOrderItemWorkTaskList.InitBOSList(this,
                                                     TableName.ARSaleOrderItemWorksTableName,
                                                     TableName.ARSaleOrderItemWorkTasksTableName,
                                                     BOSList<ARSaleOrderItemWorkTasksInfo>.cstRelationForeign);

                        foreach (ARSaleOrderItemWorkTasksInfo task in ARSaleOrderItemWorkTaskList)
                        {
                            if (task.FK_ARSaleOrderItemWorkID == o.ARSaleOrderItemWorkID)
                            {
                                o.ARSaleOrderItemWorkTaskList.Add(task);
                            }
                        }
                    };
                });
                if (((SaleOrderModule)this.Module).TabModuleList.Contains("xtraTabCostList"))
                {
                    ARSaleOrderItemCostList.Invalidate(saleOrderItemWorks.Where(o => o.ARSaleOrderItemWorkProductType == ProductItemType.Service.ToString()).ToList());
                    ARSaleOrderItemCostList.AddRange(ARSaleOrderItemWorkList.Where(o => o.ARSaleOrderItemWorkProductChargeCheck).ToList());
                    ARSaleOrderItemCostList.AddRange(ARSaleOrderItemWorkAssetList.Where(o => o.ARSaleOrderItemWorkProductChargeCheck).ToList());
                    ARSaleOrderItemCostList.AddRange(ARSaleOrderItemWorkMaterialList.Where(o => o.ARSaleOrderItemWorkProductChargeCheck).ToList());
                    ARSaleOrderItemCostList.GridControl.RefreshDataSource();
                }
            }

            if (((SaleOrderModule)this.Module).TabModuleList.Contains("xtraTabPage5"))
                SaleCommissionsList.Invalidate(iObjectID);
            SaleOrderProfilesList.Invalidate(new List<ARHistoryDetailsInfo>());
            SOItemProfilesList.Invalidate(new List<ARHistoryDetailsInfo>());
            SaleOrderItemFollowList.Invalidate(new List<ARSaleOrderItemsInfo>());

            ARSalesmansList.Invalidate(iObjectID);
            SaleOrderItemOtherFeeList.Invalidate(iObjectID);

            ARSaleOrderItemAllocationFeesController objSaleOrderItemAllocationFeesController = new ARSaleOrderItemAllocationFeesController();
            List<ARSaleOrderItemAllocationFeesInfo> listAllocationFees = objSaleOrderItemAllocationFeesController.GetItemAllocationFeesBySaleOrderID(iObjectID);
            SaleOrderItemAllocationFeeList.Invalidate(listAllocationFees);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ARSaleOrderItemsList.SaveItemObjects();
            SaveSOItemComponentList(ARSaleOrderItemsList);
            SaleOrderTemplatesList.RemoveAll(o => o.ARSaleOrderTemplateType == "SOPaymentTemplate");
            SaleOrderTemplatesList.SaveItemObjects();
            SaleOrderTemplateURLDic = SaleOrderTemplatesList.ToDictionary(o => o.ARSaleOrderTemplateID, o => o.FullPathFile);
            foreach (var item in ARSaleOrderPaymentTimesList)
            {
                item.ARSaleOrderPaymentTimeDueDate = DateTime.Parse(item.ARSaleOrderPaymentTimeDueDate.ToShortDateString());
                item.ARSaleOrderPaymentTimeDate = DateTime.Parse(item.ARSaleOrderPaymentTimeDate.ToShortDateString());
            }
            ARSaleOrderPaymentTimesList.SaveItemObjects();

            ARSaleOrderPaymentTimesList.Where(i => i.ClearingDetailList != null).All(o =>
            {
                o.ClearingDetailList.All(x =>
                {
                    x.FK_ARSaleOrderPaymentTimeID = o.ARSaleOrderPaymentTimeID;
                    x.FK_ARSaleOrderID = o.FK_ARSaleOrderID;
                    return true;
                });
                o.ClearingDetailList.SaveItemObjects();
                return true;
            });

            ARSaleOrderPaymentTimesList.All(o =>
            {
                if (o.PaymentTimeTemplateList == null || (o.PaymentTimeTemplateList != null && o.PaymentTimeTemplateList.Count == 0))
                    return true;

                o.PaymentTimeTemplateList.All(o1 =>
                {
                    o1.FK_ARSaleOrderPaymentTimeID = o.ARSaleOrderPaymentTimeID;
                    o1.FK_ARSaleOrderID = o.FK_ARSaleOrderID;
                    return true;
                });
                o.PaymentTimeTemplateList.SaveItemObjects();
                PaymentTimeTemplateList.AddRange(o.PaymentTimeTemplateList);
                return true;
            });

            SaleOrderItemContainerList.SaveItemObjects();

            ARSaleOrderItemWorkList.SaveItemObjects();

            ARSaleOrderItemWorkList.ForEach(t =>
            {
                if (t.ARSaleOrderItemWorkMaterialList != null)
                {
                    t.ARSaleOrderItemWorkMaterialList.All(item =>
                    {
                        item.FK_ARSaleOrderID = t.FK_ARSaleOrderID;
                        item.ARSaleOrderItemWorkParentID = t.ARSaleOrderItemWorkID;
                        return true;
                    });
                }

                if (t.ARSaleOrderItemWorkAssetList != null)
                {
                    t.ARSaleOrderItemWorkAssetList.All(item =>
                    {
                        item.FK_ARSaleOrderID = t.FK_ARSaleOrderID;
                        item.ARSaleOrderItemWorkParentID = t.ARSaleOrderItemWorkID;
                        return true;
                    });
                }

                if (t.ARSaleOrderItemWorkTaskList != null)
                {
                    t.ARSaleOrderItemWorkTaskList.All(item =>
                    {
                        item.FK_ARSaleOrderID = t.FK_ARSaleOrderID;
                        item.FK_ARSaleOrderItemWorkID = t.ARSaleOrderItemWorkID;
                        return true;
                    });
                }
            });
            ARSaleOrderItemWorkTaskList.SaveItemObjects();
            ARSaleOrderItemWorkMaterialList.SaveItemObjects();
            ARSaleOrderItemWorkAssetList.SaveItemObjects();
            ARSaleOrderItemCostList.ForEach(o =>
            {
                o.FK_ARSaleOrderID = ((ARSaleOrdersInfo)MainObject).ARSaleOrderID;
            });
            ARSaleOrderItemCostList.SaveItemObjects();
            SaleCommissionsList.SaveItemObjects();
            ARSalesmansList.SaveItemCDObjects();

            SaleOrderItemOtherFeeList.SaveItemObjects();

            ARSaleOrderItemsInfo objSaleOrderItemsInfo;
            SaleOrderItemAllocationFeeList.ForEach(o =>
            {
                o.FK_ARSaleOrderID = ((ARSaleOrdersInfo)MainObject).ARSaleOrderID;
                objSaleOrderItemsInfo = ARSaleOrderItemsList.FirstOrDefault(i => i.ARSaleOrderItemVirtualID == o.ARSaleOrderItemVirtualID);
                o.FK_ARSaleOrderItemID = objSaleOrderItemsInfo != null ? objSaleOrderItemsInfo.ARSaleOrderItemID : 0;
            });
            SaleOrderItemAllocationFeeList.SaveItemObjects();
        }

        public void InvalidateProfileManagement()
        {
            ARSaleOrdersInfo mainobject = (ARSaleOrdersInfo)MainObject;
            ARHistoryDetailsController objHistoryDetailsController = new ARHistoryDetailsController();
            List<ARHistoryDetailsInfo> saleHistoryList = objHistoryDetailsController.GetSaleOrderHistory(mainobject.ARSaleOrderID);
            SaleOrderProfilesList.Invalidate(saleHistoryList);
            List<ARHistoryDetailsInfo> saleHistoryItemList = objHistoryDetailsController.GetSaleOrderItemHistory(mainobject.ARSaleOrderID);
            SOItemProfilesList.Invalidate(saleHistoryItemList);
        }

        /// <summary>
        /// Save sale order item component list
        /// </summary>
        /// <param name="saleOrderItems">List of sale order item component</param>
        public void SaveSOItemComponentList(BOSItemsEntityList<ARSaleOrderItemsInfo> saleOrderItems)
        {
            foreach (ARSaleOrderItemsInfo itemEntity in saleOrderItems)
            {
                if (itemEntity.ARSOItemComponentList != null)
                {
                    foreach (ARSOItemComponentsInfo objSOItemComponentsInfo in itemEntity.ARSOItemComponentList)
                    {
                        objSOItemComponentsInfo.FK_ARSaleOrderItemID = itemEntity.ARSaleOrderItemID;
                    }
                    itemEntity.ARSOItemComponentList.SaveItemObjects();
                }
            }
        }

        public void UpdateReferenceProposal()
        {
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                if (ARReferenceProposalItems.ContainsKey(entItem.FK_ARProposalItemID))
                {
                    ARProposalItemsInfo objProposalItemsInfo = ARReferenceProposalItems[entItem.FK_ARProposalItemID];
                    objProposalItemsInfo.ARProposalItemProductQtyOld += Math.Min(entItem.ARSaleOrderItemProductQty, objProposalItemsInfo.ARProposalItemProductQtyRemained);
                    objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
                    objProposalItemsController.UpdateObject(objProposalItemsInfo);
                }
            }

            //Update the proposal's status
            bool isRemained = false;
            foreach (ARProposalItemsInfo objProposalItemsInfo in ARReferenceProposalItems.Values)
            {
                if (objProposalItemsInfo.ARProposalItemProductQtyRemained > 0)
                {
                    isRemained = true;
                    break;
                }
            }

            if (!isRemained)
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                if (!String.IsNullOrEmpty(objSaleOrdersInfo.ARSaleOrderReference))
                {
                    ARProposalsController objProposalsController = new ARProposalsController();
                    ARProposalsInfo objProposalsInfo = (ARProposalsInfo)objProposalsController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderReference);
                    if (objProposalsInfo != null)
                    {
                        objProposalsInfo.ARProposalStatus = "Ordered";
                        objProposalsController.UpdateObject(objProposalsInfo);
                    }
                }
            }
        }
        #endregion

        #region SetValuesAfterValidateProduct
        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ARSaleOrderItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ARSaleOrderItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)item;
                objSaleOrderItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                //SetDefaultValuesFromProduct(objProductsInfo.ICProductID, objSaleOrderItemsInfo);
                SetDefaultValuesFromProduct(objSaleOrderItemsInfo.FK_ICProductID, objSaleOrderItemsInfo);
                SetProductCost(objSaleOrderItemsInfo);
                ICProductCustomersInfo objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(objProductsInfo.ICProductID, objSaleOrdersInfo.FK_ARCustomerID);
                objSaleOrderItemsInfo.ARSaleOrderItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty;
                objSaleOrderItemsInfo.FK_ICStockID = objSaleOrdersInfo.FK_ICStockID;
                objSaleOrderItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate = objSaleOrdersInfo.ARSaleOrderDeliveryDate;
                objSaleOrderItemsInfo.ARSaleOrderItemDeliveryTime = objSaleOrdersInfo.ARSaleOrderDeliveryTime;
                objSaleOrderItemsInfo.ICProductUnitPrice = objProductsInfo.ICProductPrice01;
                objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice = objSaleOrderItemsInfo.ICProductUnitPrice;
                objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 = (objSaleOrdersInfo.ARSaleOrderExchangeRate2 > 0 ? objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * objSaleOrdersInfo.ARSaleOrderExchangeRate / objSaleOrdersInfo.ARSaleOrderExchangeRate2 : 0);
                objSaleOrderItemsInfo.ARSaleOrderItemProductAttribute = objProductsInfo.ICProductAttributeKey;
                objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty = 0;
                objSaleOrderItemsInfo.ARSaleOrderItemShippedQty = 0;
                objSaleOrderItemsInfo.ARSaleOrderItemOriginOfProduct = objProductsInfo.ICProductOriginOfProduct;
                if (objProductsInfo.ICProductOriginOfProduct == ProductOrigin.Import.ToString() || objProductsInfo.ICProductOriginOfProduct == ProductOrigin.DomesticPurchase.ToString())
                {
                    objSaleOrderItemsInfo.ARSaleOrderItemGrantedFrom = SaleOrderItemGrantedFrom.Purchase.ToString();
                }
                else if (objProductsInfo.ICProductOriginOfProduct == ProductOrigin.Production.ToString())
                {
                    objSaleOrderItemsInfo.ARSaleOrderItemGrantedFrom = SaleOrderItemGrantedFrom.Production.ToString();
                }
                else
                {
                    objSaleOrderItemsInfo.ARSaleOrderItemGrantedFrom = "";
                }
                objSaleOrderItemsInfo.ARSaleOrderItemHTID = objProductsInfo.ICProductAttributeFinishing;
                objSaleOrderItemsInfo.ARSaleOrderItemHTText = objProductsInfo.ICProductAttributeFinishingText;

                objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                objSaleOrderItemsInfo.FK_ICProductAttributeColorID = objProductsInfo.FK_ICProductAttributeColorID;

                objSaleOrderItemsInfo.ARSaleOrderItemColorID = objProductsInfo.ICProductColorAttribute;
                objSaleOrderItemsInfo.ARSaleOrderItemColorText = GetAttributeText(objProductsInfo.ICProductColorAttribute);

                objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID = objProductsInfo.ICProductWoodTypeAttribute;
                objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeText = GetAttributeText(objProductsInfo.ICProductWoodTypeAttribute);

                objSaleOrderItemsInfo.ARSaleOrderItemProductDesc = objProductsInfo.ICProductDesc;

                objSaleOrderItemsInfo.ARSaleOrderItemHeight = objProductsInfo.ICProductHeight;
                objSaleOrderItemsInfo.ARSaleOrderItemLength = objProductsInfo.ICProductLength;
                objSaleOrderItemsInfo.ARSaleOrderItemWidth = objProductsInfo.ICProductWidth;

                decimal unitVolumn = objProductsInfo.ICProductVolume > 0 ? objProductsInfo.ICProductVolume : Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemHeight * objSaleOrderItemsInfo.ARSaleOrderItemWidth * objSaleOrderItemsInfo.ARSaleOrderItemLength)
                                           / (decimal)Math.Pow(10, 9), 4);
                objSaleOrderItemsInfo.ARSaleOrderItemProductCBM = unitVolumn * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                objSaleOrderItemsInfo.ARSaleOrderItemBlock = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * (Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemHeight * objSaleOrderItemsInfo.ARSaleOrderItemWidth * objSaleOrderItemsInfo.ARSaleOrderItemLength)
                                                   / (decimal)Math.Pow(10, 9), 4));
                objSaleOrderItemsInfo.FK_ICProductAttributeColorID = objProductsInfo.FK_ICProductAttributeColorID;
                objSaleOrderItemsInfo.ARSaleOrderItemProductColorAttribute = objProductsInfo.ICProductColorAttribute;
                objSaleOrderItemsInfo.ARSaleOrderItemProductNo = objProductsInfo.ICProductNo;
            }
        }
        #endregion

        public string GetAttributeText(string productAttributeRefence)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributeByProductAttributeReferenceByCharater(productAttributeRefence, ",");
            if (productAttributeList == null)
                productAttributeList = new List<ICProductAttributesInfo>();
            return string.Join(", ", productAttributeList.Select(o => o.ICProductAttributeNo).ToArray());
        }

        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of proposal
            ((ARSaleOrdersInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price based on price level
            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                SetProductPrice(entItem, TableName.ARSaleOrderItemsTableName);
                RoundByCurrency(entItem);
            }
            ARSaleOrderItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount(ARSaleOrderItemsList);
        }

        public void UpdateTotalAmount(List<ARSaleOrderItemsInfo> list)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.ARSaleOrderNetAmount = 0;
            objSaleOrdersInfo.ARSaleOrderSubTotalAmount = 0;
            objSaleOrdersInfo.ARSaleOrderTotalCost = 0;
            objSaleOrdersInfo.ARSaleOrderTotalDiscountFix = 0;
            objSaleOrdersInfo.ARSaleOrderPriceCostTotalAmount = 0;
            foreach (ARSaleOrderItemsInfo entItem in list)
            {
                RoundByCurrency(entItem);
                entItem.ARSaleOrderItemPrice = entItem.ARSaleOrderItemProductQty * entItem.ARSaleOrderItemProductUnitPrice;
                entItem.ARSaleOrderItemDiscountAmount = entItem.ARSaleOrderItemProductDiscount * entItem.ARSaleOrderItemPrice / 100;
                entItem.ARSaleOrderItemTaxAmount = entItem.ARSaleOrderItemProductTaxPercent * (entItem.ARSaleOrderItemPrice - entItem.ARSaleOrderItemDiscountAmount) / 100;
                entItem.ARSaleOrderItemTotalAmount = (entItem.ARSaleOrderItemPrice - entItem.ARSaleOrderItemDiscountAmount + entItem.ARSaleOrderItemTaxAmount);

                objSaleOrdersInfo.ARSaleOrderNetAmount += entItem.ARSaleOrderItemNetAmount;
                objSaleOrdersInfo.ARSaleOrderSubTotalAmount += entItem.ARSaleOrderItemTotalAmount;
                objSaleOrdersInfo.ARSaleOrderTotalDiscountFix += entItem.ARSaleOrderItemDiscountAmount;
                objSaleOrdersInfo.ARSaleOrderPriceCostTotalAmount += entItem.ARSaleOrderItemProductQty * entItem.ARSaleOrderItemProductUnitPrice;
            }
            foreach (ARSaleOrderItemWorksInfo item in ARSaleOrderItemCostList)
            {
                objSaleOrdersInfo.ARSaleOrderTotalCost += item.ARSaleOrderItemWorkTotalAmount;
                objSaleOrdersInfo.ARSaleOrderPriceCostTotalAmount += item.ARSaleOrderItemWorkProductQty * item.ARSaleOrderItemWorkProductUnitPrice;
            }
            //objSaleOrdersInfo.ARSaleOrderSubTotalAmount += objSaleOrdersInfo.ARSaleOrderTotalCost;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderDiscountFix = objSaleOrdersInfo.ARSaleOrderSubTotalAmount * objSaleOrdersInfo.ARSaleOrderDiscountPerCent / 100;
            objSaleOrdersInfo.ARSaleOrderTotalDiscountFix += objSaleOrdersInfo.ARSaleOrderDiscountFix;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderDiscountFix", objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderTaxAmount = (objSaleOrdersInfo.ARSaleOrderSubTotalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix + objSaleOrdersInfo.ARSaleOrderTotalCost) * objSaleOrdersInfo.ARSaleOrderTaxPercent / 100;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTaxAmount", objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderTotalAmount = objSaleOrdersInfo.ARSaleOrderSubTotalAmount -
                                                        objSaleOrdersInfo.ARSaleOrderDiscountFix +
                                                        objSaleOrdersInfo.ARSaleOrderTaxAmount +
                                                        objSaleOrdersInfo.ARSaleOrderTotalCost;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTotalAmount", objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderBalanceDue = objSaleOrdersInfo.ARSaleOrderTotalAmount - objSaleOrdersInfo.ARSaleOrderDepositBalance;
            objSaleOrdersInfo.ARSaleOrderBalanceDue -= objSaleOrdersInfo.ReportTotalCancelVoucher;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderBalanceDue", objSaleOrdersInfo.FK_GECurrencyID);

            //Calculate customer comission
            decimal subTotalAmount = 0;
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in list)
            {
                subTotalAmount += objSaleOrderItemsInfo.ARSaleOrderItemPrice - objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount;
            }
            decimal totalAmount = subTotalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix;
            objSaleOrdersInfo.ARSaleOrderSOCommissionPercent = objSaleOrdersInfo.ARSaleOrderSOCommissionAmount * 100 / (totalAmount == 0 ? 1 : totalAmount);
            objSaleOrdersInfo.ARSaleOrderSOCommissionAmount = totalAmount * objSaleOrdersInfo.ARSaleOrderSOCommissionPercent / 100;
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in list)
            {
                RoundByCurrency(objSaleOrderItemsInfo);
                objSaleOrderItemsInfo.ARSaleOrderItemTotalAmount2 = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                RoundByCurrency(objSaleOrderItemsInfo);
            }
            BOSApp.RoundByCurrency(objSaleOrdersInfo, objSaleOrdersInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public void RoundByCurrency(ARSaleOrderItemsInfo obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            GECurrenciesController currencyController = new GECurrenciesController();
            //GECurrenciesInfo currency = currencyController.GetObjectByID(currencyID) as GECurrenciesInfo;
            GETablesController tableController = new GETablesController();
            if (obj != null)
            {
                string tableName = BOSUtil.GetTableNameFromBusinessObject(obj);
                List<GETablesInfo> tables = new List<GETablesInfo>();
                if (!BOSApp.RoundColTable.ContainsKey(tableName))
                {
                    DataSet ds = tableController.GetTableColumnNamesByTableName(tableName);
                    tables = (List<GETablesInfo>)tableController.GetListFromDataSet(ds);
                    BOSApp.RoundColTable.Add(tableName, ds);
                    //tables = tableController.GetColumnNamesByTableName(tableName);
                }
                else
                {
                    DataSet ds = (DataSet)BOSApp.RoundColTable[tableName];
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            GETablesInfo objTablesInfo = new GETablesInfo();
                            objTablesInfo = (GETablesInfo)SqlDatabaseHelper.GetObjectFromDataRow(dr, typeof(GETablesInfo));
                            tables.Add(objTablesInfo);
                        }
                    }
                    ds.Dispose();
                }
                if (tables != null)
                {
                    foreach (GETablesInfo table in tables)
                    {
                        if (table.ColumnName != "ICProductUnitPrice" && table.ColumnName != "ARSaleOrderItemProductUnitPrice")
                        {
                            if (table.ColumnName == "ARSaleOrderItemProductUnitPrice2" || table.ColumnName == "ARSaleOrderItemTotalAmount2")
                            {
                                object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                decimal amount = 0;
                                if (value != null)
                                {
                                    amount = Convert.ToDecimal(value);
                                    amount = Math.Round(amount, BOSApp.GetDecimalNumberByCurrencyID(objSaleOrdersInfo.FK_GECurrencyID2));
                                    dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                }
                            }
                            else
                            {
                                object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                decimal amount = 0;
                                if (value != null)
                                {
                                    amount = Convert.ToDecimal(value);
                                    amount = Math.Round(amount, BOSApp.GetDecimalNumberByCurrencyID(objSaleOrdersInfo.FK_GECurrencyID));
                                    dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                }
                            }
                        }
                    }
                }

            }
        }

        public void SetProductPriceByProductUnitPrice(ARSaleOrderItemsInfo item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            //Math Round Start
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTableName + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Qty
            //columnName = itemTablePrefix + "FormulaPriceConfigQty";
            //decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            //if (qty == 0)
            //{
            //    columnName = itemTablePrefix + "ProductQty";
            //    qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            //}

            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
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
            decimal oldDiscountAmount = 0;
            if (item.OldObject == null)
            {
                item.OldObject = (BusinessObject)item.Clone();
            }
            if (item.OldObject != null)
            {
                oldDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, discountAmountColumnName));
            }
            if (discountAmount != oldDiscountAmount)
            {
                if (extPrice > 0)
                {
                    discountAmount = extPrice * discountPercent / 100;
                    dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
                }
            }
            else
            {
                discountAmount = extPrice * discountPercent / 100;
                dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            }
            //Get or set item group discount
            string groupDiscountColumnName = itemTablePrefix + "ProductGroupDiscount";
            decimal groupDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, groupDiscountColumnName));
            decimal oldGroupDiscountAmount = 0;
            if (item.OldObject == null)
            {
                item.OldObject = (BusinessObject)item.Clone();
            }
            if (item.OldObject != null)
            {
                oldGroupDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, groupDiscountColumnName));
            }
            if (groupDiscountAmount != oldGroupDiscountAmount)
            {
                if (unitPrice > 0)
                {
                    groupDiscountAmount = unitPrice * discountPercent / 100;
                    dbUtil.SetPropertyValue(item, groupDiscountColumnName, unitPrice - groupDiscountAmount);
                }
            }
            else
            {
                groupDiscountAmount = unitPrice * discountPercent / 100;
                dbUtil.SetPropertyValue(item, groupDiscountColumnName, unitPrice - groupDiscountAmount);
            }
            string totalGroupDiscountColumnName = itemTablePrefix + "TotalGroupDiscount";
            dbUtil.SetPropertyValue(item, totalGroupDiscountColumnName, (unitPrice - groupDiscountAmount) * qty);

            //Get or set tax percent and amount
            string taxPercentColumnName = itemTablePrefix + "ProductTaxPercent";
            string taxAmountColumnName = itemTablePrefix + "TaxAmount";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxPercentColumnName));
            decimal taxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxAmountColumnName));
            decimal oldTaxAmount = 0;
            if (item.OldObject != null)
            {
                oldTaxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, taxAmountColumnName));
            }
            if (taxAmount != oldTaxAmount)
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }
            else
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(item, columnName, unitCost * exchangeRate);

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost * exchangeRate);

            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            RoundByCurrency(item);

            //Get Item Factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, qty * factor);
            //item.OldObject = (BusinessObject)item.Clone();
        }

        public int TakePayment(DateTime paymentDate, string paymentDesc, int bankID, string bankAccount, decimal paymentAmount)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //Generate open document if it's the first payment
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    AROpenDocumentsInfo objOpenDocumentsInfo = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderNo);
                    if (objOpenDocumentsInfo == null)
                    {
                        objOpenDocumentsInfo = DataGenerator.GenerateOpenDocumentFromSaleOrder((ARSaleOrdersInfo)MainObject);
                        objOpenDocumentsController.CreateObject(objOpenDocumentsInfo);
                    }
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentsInfo objCustomerPaymentsInfo = CustomerPayment.CustomerPaymentModule.TakePayment(objOpenDocumentsInfo, paymentAmount, ARCustomerPaymentDetailsList);
                    objCustomerPaymentsInfo.ARCustomerPaymentNo = BOSApp.GetMainObjectNo(ModuleName.Deposit, objCustomerPaymentsInfo);
                    objCustomerPaymentsInfo.ARCustomerPaymentType = CustomerPaymentType.Deposit.ToString();
                    objCustomerPaymentsInfo.ARCustomerPaymentDate = paymentDate;
                    objCustomerPaymentsInfo.ARCustomerPaymentDesc = paymentDesc;
                    objCustomerPaymentsInfo.FK_CSCompanyBankID = bankID;
                    objCustomerPaymentsInfo.ARCustomerPaymentBankAccount = bankAccount;
                    objCustomerPaymentsController.UpdateObject(objCustomerPaymentsInfo);
                    BOSApp.UpdateObjectNumbering(ModuleName.Deposit);

                    //Update sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    objSaleOrdersInfo.ARSaleOrderDepositBalance += Math.Min(paymentAmount, objSaleOrdersInfo.ARSaleOrderBalanceDue);
                    objSaleOrdersInfo.ARSaleOrderBalanceDue -= Math.Min(paymentAmount, objSaleOrdersInfo.ARSaleOrderBalanceDue);
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);

                    SavePaymentEntries(objCustomerPaymentsInfo);

                    scope.Complete();
                    return objCustomerPaymentsInfo.ARCustomerPaymentID;
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    return 0;
                }
            }
        }

        /// <summary>
        /// Save a template to database
        /// </summary>
        /// <param name="objVisitTemplatesInfo">Visit template object needs to be saved</param>
        public void SaveTemplate(ARSaleOrderTemplatesInfo objSaleSaleOrderTemplatesInfo)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ARSaleOrderTemplatesController objSaleOrderTemplatesController = new ARSaleOrderTemplatesController();
            if (objSaleSaleOrderTemplatesInfo.ARSaleOrderTemplateID == 0)
            {
                objSaleSaleOrderTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
                objSaleSaleOrderTemplatesInfo.AACreatedDate = DateTime.Now;
                objSaleSaleOrderTemplatesInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                objSaleOrderTemplatesController.CreateObject(objSaleSaleOrderTemplatesInfo);
            }
            else
            {
                objSaleSaleOrderTemplatesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objSaleSaleOrderTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objSaleOrderTemplatesController.UpdateObject(objSaleSaleOrderTemplatesInfo);
            }

        }

        /// <summary>
        /// Update a deposit
        /// </summary>
        /// <param name="customerPayment">Deposit object</param>
        /// <param name="objDocumentPaymentsInfo">Payment document of the deposit</param>
        public void UpdatePayment(ARCustomerPaymentsInfo customerPayment, ARDocumentPaymentsInfo objDocumentPaymentsInfo)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();

                    //Update document payment
                    objDocumentPaymentsInfo.ARDocumentPaymentAmount = customerPayment.ARCustomerPaymentTotalAmount;
                    objDocumentPaymentsController.UpdateObject(objDocumentPaymentsInfo);

                    //Update open document
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    ARSaleOrdersInfo saleOrder = (ARSaleOrdersInfo)MainObject;
                    AROpenDocumentsInfo openDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(saleOrder.ARSaleOrderNo);
                    if (openDocument != null)
                    {
                        int openDocumentID = openDocument.AROpenDocumentID;
                        openDocument = DataGenerator.GenerateOpenDocumentFromSaleOrder(saleOrder);
                        openDocument.AROpenDocumentID = openDocumentID;
                        objOpenDocumentsController.UpdateObject(openDocument);
                    }

                    //Update customer payment                    
                    customerPayment.FK_ARCustomerID = saleOrder.FK_ARCustomerID;
                    customerPayment.FK_GECurrencyID = saleOrder.FK_GECurrencyID;
                    objCustomerPaymentsController.UpdateObject(customerPayment);

                    //Update customer payment detail
                    CustomerPayment.CustomerPaymentModule.UpdateCustomerPaymentDetails(customerPayment, ARCustomerPaymentDetailsList);

                    //Update the deposit and balance due of the current sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    saleOrder.ARSaleOrderDepositBalance += Math.Min(customerPayment.ARCustomerPaymentTotalAmount, saleOrder.ARSaleOrderBalanceDue);
                    saleOrder.ARSaleOrderBalanceDue -= Math.Min(customerPayment.ARCustomerPaymentTotalAmount, saleOrder.ARSaleOrderBalanceDue);
                    objSaleOrdersController.UpdateObject(saleOrder);

                    SavePaymentEntries(customerPayment);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }
        }

        public void UpdateContQty()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            decimal contQty = 0;
            //foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            //{
            //    ICProductsController objProductsController = new ICProductsController();
            //    ICProductsInfo products = objProductsController.GetProductByID(entItem.FK_ICProductID);

            //    contQty += (entItem.ARSaleOrderItemProductQty * products.ICProductLength * products.ICProductWidth * products.ICProductHeight) * Convert.ToDecimal((Math.Pow(10, -9)));
            //}
            //if (contQty != 0)
            //{
            //    contQty = (contQty) / 60;
            //}

            SaleOrderItemContainerList.Where(o => o.FK_GEContainerID > 0).ToList().ForEach(p => contQty += p.ARSaleOrderItemContainerProductQty);
            objSaleOrdersInfo.ARSaleOrderContQty = Math.Round(contQty, 4, MidpointRounding.AwayFromZero);
            UpdateMainObjectBindingSource();
        }

        public void DeletePayment(ARDocumentPaymentsInfo objDocumentPaymentsInfo)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
                    ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByID(objDocumentPaymentsInfo.FK_ARCustomerPaymentID);
                    if (objCustomerPaymentsInfo != null)
                    {
                        List<ARCustomerPaymentDetailsInfo> oldPaymentDetails = objCustomerPaymentDetailsController.GetDetailsByPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        foreach (ARCustomerPaymentDetailsInfo oldPaymentDetail in oldPaymentDetails)
                        {
                            CustomerPayment.CustomerPaymentModule.RollbackRelativeDataOfPaymentDetail((ARCustomerPaymentDetailsInfo)oldPaymentDetail);
                        }
                        objCustomerPaymentsController.DeleteByID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsController.DeletePaymentEntriesByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
                    }

                    //Update the deposit and balance due of the current sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                    objSaleOrdersInfo.ARSaleOrderDepositBalance -= objDocumentPaymentsInfo.ARDocumentPaymentAmount;
                    objSaleOrdersInfo.ARSaleOrderBalanceDue += objDocumentPaymentsInfo.ARDocumentPaymentAmount;
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);

                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }

        #region Generate List From Proposal
        public void GenerateEntityFromProposal(ARProposalsInfo objProposalsInfo)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.ARSaleOrderDiscountPerCent = objProposalsInfo.ARProposalDiscountPerCent;
            objSaleOrdersInfo.ARSaleOrderTaxPercent = objProposalsInfo.ARProposalTaxPercent;
            objSaleOrdersInfo.ARSaleOrderTotalCost = objProposalsInfo.ARProposalTotalCost;
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = objProposalsInfo.ARProposalDeliveryDate;
            objSaleOrdersInfo.ARSaleOrderProductType = objProposalsInfo.ARProposalTypeCombo;
            //objSaleOrdersInfo.ARSaleOrderComment = Encoding.ASCII.GetBytes(objProposalsInfo.ARProposalDesc);
            objSaleOrdersInfo.ARSaleOrderComment = objProposalsInfo.ARProposalDesc;
            objSaleOrdersInfo.FK_PMProjectID = objProposalsInfo.FK_PMProjectID;
            objSaleOrdersInfo.ARSaleOrderProject = objProposalsInfo.ARProposalProject;
            if (string.IsNullOrEmpty(objSaleOrdersInfo.ARSaleOrderSaleAgreement) && (objSaleOrdersInfo.FK_PMProjectID > 0))
            {
                PMProjectsController objProjectsController = new PMProjectsController();
                PMProjectsInfo objProjectsInfo = (PMProjectsInfo)objProjectsController.GetObjectByID(objProposalsInfo.FK_PMProjectID);
                if (objProjectsInfo != null)
                {
                    objSaleOrdersInfo.ARSaleOrderSaleAgreement = objProjectsInfo.PMProjectNo;
                }
            }
            objSaleOrdersInfo = GenerateSaleOrderFromProposalAndSaleOrderOld(objProposalsInfo, (ARSaleOrdersInfo)objSaleOrdersInfo.Clone());
            //((SaleOrderModule)Module).ChangeObject(objSaleOrdersInfo.ACObjectAccessKey);
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            List<ARProposalItemsInfo> proposalItemList = objProposalItemsController.GetProposalItemsByProposalID(objProposalsInfo.ARProposalID);
            if (proposalItemList != null && proposalItemList.Count > 0)
            {
                foreach (ARProposalItemsInfo objProposalItemsInfo in proposalItemList)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = GenerateSaleOrderItemFromProposalItem(objProposalItemsInfo);
                    ARSaleOrderItemsList.Add(objSaleOrderItemsInfo);
                    ARReferenceProposalItems.Add(objProposalItemsInfo.ARProposalItemID, objProposalItemsInfo);
                    //((SaleOrderModule)Module).AddItemWorkToSaleOrderItemWorkList(objSaleOrderItemsInfo);
                }
            }
            UpdateTotalAmount(ARSaleOrderItemsList.ToList());
        }

        public ARSaleOrdersInfo GenerateSaleOrderFromProposalAndSaleOrderOld(ARProposalsInfo objProposalsInfo, ARSaleOrdersInfo objOldSaleOrdersInfo)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            objSaleOrdersInfo.ARSaleOrderNo = objOldSaleOrdersInfo.ARSaleOrderNo;
            objSaleOrdersInfo.ARSaleOrderName = objOldSaleOrdersInfo.ARSaleOrderName;
            objSaleOrdersInfo.ARSaleOrderTypeCombo = objOldSaleOrdersInfo.ARSaleOrderTypeCombo;
            objSaleOrdersInfo.ARSaleOrderStatus = objOldSaleOrdersInfo.ARSaleOrderStatus;
            objSaleOrdersInfo.ARSaleOrderDate = objOldSaleOrdersInfo.ARSaleOrderDate;
            objSaleOrdersInfo.ARSaleOrderValidateDate = objOldSaleOrdersInfo.ARSaleOrderValidateDate;
            objSaleOrdersInfo.ARSaleOrderDesc = objOldSaleOrdersInfo.ARSaleOrderDesc;
            objSaleOrdersInfo.ARSaleOrderReference = objProposalsInfo.ARProposalNo;
            objSaleOrdersInfo.FK_HREmployeeID = objOldSaleOrdersInfo.FK_HREmployeeID;
            objSaleOrdersInfo.ARSaleOrderEmployeePicture = objOldSaleOrdersInfo.ARSaleOrderEmployeePicture;
            objSaleOrdersInfo.FK_ACObjectID = objOldSaleOrdersInfo.FK_ACObjectID;
            objSaleOrdersInfo.ARObjectType = objOldSaleOrdersInfo.ARObjectType;
            objSaleOrdersInfo.FK_ARCustomerID = objOldSaleOrdersInfo.FK_ARCustomerID;
            objSaleOrdersInfo.ACObjectAccessKey = objOldSaleOrdersInfo.FK_ACObjectID + ";" + objOldSaleOrdersInfo.ARObjectType;
            objSaleOrdersInfo.ARSaleOrderBalanceDue = objSaleOrdersInfo.ARSaleOrderTotalAmount - objSaleOrdersInfo.ARSaleOrderDepositBalance;

            return objSaleOrdersInfo;
        }

        public ARSaleOrderItemsInfo GenerateSaleOrderItemFromProposalItem(ARProposalItemsInfo objProposalItemsInfo)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            BOSUtil.CopyObject(objProposalItemsInfo, objSaleOrderItemsInfo);
            objSaleOrderItemsInfo.ARSaleOrderItemVirtualID = Guid.NewGuid().ToString();
            objSaleOrderItemsInfo.FK_ARProposalID = objProposalItemsInfo.FK_ARProposalID;
            objSaleOrderItemsInfo.FK_ARProposalItemID = objProposalItemsInfo.ARProposalItemID;
            objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
            objSaleOrderItemsInfo.ARSaleOrderItemProductQty = objProposalItemsInfo.ARProposalItemProductQtyOld > 0 ? objProposalItemsInfo.ARProposalItemProductQtyOld : 0;
            objSaleOrderItemsInfo.ARSaleOrderItemProductFactor = objProposalItemsInfo.ARProposalItemProductSellFactor;
            objSaleOrderItemsInfo.ARSaleOrderItemProductExchangeQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * objSaleOrderItemsInfo.ARSaleOrderItemProductFactor;
            objSaleOrderItemsInfo.FK_ICProductAttributeColorID = objProposalItemsInfo.FK_ICProductAttributeColorID;
            objSaleOrderItemsInfo.FK_ICProductFormulaPriceConfigID = objProposalItemsInfo.FK_ICProductFormulaPriceConfigID;
            objSaleOrderItemsInfo.ARSaleOrderItemFormulaPriceConfigQty = objProposalItemsInfo.ARProposalItemFormulaPriceConfigQty;
            objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount = objProposalItemsInfo.ARProposalItemDiscountAmount;
            objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount = objProposalItemsInfo.ARProposalItemDiscountFix;
            objSaleOrderItemsInfo.ARSaleOrderItemHeight = objProposalItemsInfo.ARProposalItemHeight;
            objSaleOrderItemsInfo.ARSaleOrderItemWidth = objProposalItemsInfo.ARProposalItemWidth;
            objSaleOrderItemsInfo.ARSaleOrderItemLength = objProposalItemsInfo.ARProposalItemLength;
            objSaleOrderItemsInfo.ARSaleOrderItemProductDesc = objProposalItemsInfo.ARProposalItemProductDesc;
            objSaleOrderItemsInfo.ARSaleOrderItemRemark = objProposalItemsInfo.ARProposalItemDesc;
            objSaleOrderItemsInfo.ARSaleOrderItemOneLevelArea = objProposalItemsInfo.ARProposalItemOneLevelArea;
            objSaleOrderItemsInfo.ARSaleOrderItemTwoLevelArea = objProposalItemsInfo.ARProposalItemTwoLevelArea;
            objSaleOrderItemsInfo.ARSaleOrderItemThreeLevelArea = objProposalItemsInfo.ARProposalItemThreeLevelArea;
            objSaleOrderItemsInfo.FK_ICSectionProductID = objProposalItemsInfo.FK_ICSectionProductID;
            objSaleOrderItemsInfo.FK_ACCostCenterID = objProposalItemsInfo.FK_ACCostCenterID;
            objSaleOrderItemsInfo.FK_ARProposalTemplateItemID = objProposalItemsInfo.FK_ARProposalTemplateItemID;
            objSaleOrderItemsInfo.ARProposalTemplateItemProductName = objProposalItemsInfo.ARProposalTemplateItemProductName;
            objSaleOrderItemsInfo.ARSaleOrderItemIsDeliveryPlan = objSaleOrdersInfo.ARSaleOrderIsDeliveryPlan;
            objSaleOrderItemsInfo.ARSaleOrderItemIsSaleOrderShipment = objSaleOrdersInfo.ARSaleOrderIsSaleOrderShipment;
            objSaleOrderItemsInfo.ARSaleOrderItemIsInvoiceAndShipment = objSaleOrdersInfo.ARSaleOrderIsInvoiceAndShipment;
            objSaleOrderItemsInfo.ARSaleOrderItemIsVehicleAllocation = objSaleOrdersInfo.ARSaleOrderIsVehicleAllocation;
            objSaleOrderItemsInfo.ARSaleOrderItemIsAcceptance = objSaleOrdersInfo.ARSaleOrderIsAcceptance;
            objSaleOrderItemsInfo.ARSaleOrderItemIsContainerLoader = objSaleOrdersInfo.ARSaleOrderIsContainerLoader;
            objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice = objProposalItemsInfo.ARProposalItemProductUnitPrice;
            objSaleOrderItemsInfo.ICProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
            objSaleOrderItemsInfo.FK_ICMeasureUnitID = objProposalItemsInfo.FK_ICMeasureUnitID;
            ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(objSaleOrderItemsInfo.FK_ICProductID, objSaleOrderItemsInfo.FK_ICMeasureUnitID);
            objSaleOrderItemsInfo.ARSaleOrderItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0)
                                                ? measureUnit.ICProductMeasureUnitFactor
                                                : 1;
            
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProposalItemsInfo.FK_ICProductID);
            if (objProductsInfo != null)
            {
                //ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
                //if (objMeasureUnitsInfo != null)
                //{
                //    objSaleOrderItemsInfo.FK_ICMeasureUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
                //}
                objSaleOrderItemsInfo.ARSaleOrderItemColorID = objProductsInfo.ICProductColorAttribute;
                objSaleOrderItemsInfo.ARSaleOrderItemColorText = GetAttributeText(objProductsInfo.ICProductColorAttribute);
                objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID = objProductsInfo.ICProductWoodTypeAttribute;
                objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeText = GetAttributeText(objProductsInfo.ICProductWoodTypeAttribute);
                objSaleOrderItemsInfo.ARSaleOrderItemProductCustomerNumber = objProposalItemsInfo.ARProposalItemProductCustomerNumber;
                objSaleOrderItemsInfo.ARSaleOrderItemHTID = objProductsInfo.ICProductAttributeFinishing;
                objSaleOrderItemsInfo.ARSaleOrderItemHTText = objProductsInfo.ICProductAttributeFinishingText;
                objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate = objSaleOrdersInfo.ARSaleOrderDeliveryDate;
                objSaleOrderItemsInfo.ARSaleOrderItemProductNo = objProductsInfo.ICProductNo;
                objSaleOrderItemsInfo.ARSaleOrderItemOriginOfProduct = objProductsInfo.ICProductOriginOfProduct;
                objSaleOrderItemsInfo.ARSaleOrderItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                if (!string.IsNullOrEmpty(objSaleOrderItemsInfo.ARSaleOrderItemOriginOfProduct))
                    objSaleOrderItemsInfo.ARSaleOrderItemGrantedFrom = GenerateDefaultGrantedFrom(objSaleOrderItemsInfo.ARSaleOrderItemOriginOfProduct);
                objSaleOrderItemsInfo.ARSaleOrderItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                decimal unitVolumn = objProductsInfo.ICProductVolume > 0 ? objProductsInfo.ICProductVolume : Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemHeight * objSaleOrderItemsInfo.ARSaleOrderItemWidth * objSaleOrderItemsInfo.ARSaleOrderItemLength)
                                           / (decimal)Math.Pow(10, 9), 4);
                objSaleOrderItemsInfo.ARSaleOrderItemProductCBM = unitVolumn * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                objSaleOrderItemsInfo.ARSaleOrderItemBlock = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * (Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemHeight * objSaleOrderItemsInfo.ARSaleOrderItemWidth * objSaleOrderItemsInfo.ARSaleOrderItemLength)
                                                   / (decimal)Math.Pow(10, 9), 4));
                // GetComponent
                objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                BOSList<ARSOItemComponentsInfo> itemComponentsList = new BOSList<ARSOItemComponentsInfo>();
                itemComponentsList.InitBOSList(
                                            this,
                                            TableName.ARSaleOrderItemsTableName,
                                            TableName.ARSOItemComponentsTableName,
                                            BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                itemComponentsList.ItemTableForeignKey = "FK_ARSaleOrderItemID";
                List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(objSaleOrderItemsInfo.FK_ICProductID);
                foreach (ICProductComponentsInfo objProductComponentsInfo in components)
                {
                    ARSOItemComponentsInfo objSOItemComponentsInfo = new ARSOItemComponentsInfo();
                    objSOItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                    objSOItemComponentsInfo.ARSOItemComponentQty = objProductComponentsInfo.ICProductComponentQty * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                    objSOItemComponentsInfo.ICProductComponentQty = objProductComponentsInfo.ICProductComponentQty;
                    objSOItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                    objSOItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                    objSOItemComponentsInfo.FK_ICStockID = objSaleOrderItemsInfo.FK_ICStockID;
                    objSOItemComponentsInfo.FK_ICProductSerieID = objSaleOrderItemsInfo.FK_ICProductSerieID;
                    itemComponentsList.Add(objSOItemComponentsInfo);
                }
                objSaleOrderItemsInfo.ARSOItemComponentList = itemComponentsList;
            }
            //if (objSaleOrdersInfo.ARSaleOrderSaleType == SaleType.National.ToString())
            //{
            //    objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 = objProposalItemsInfo.ARProposalItemProductUnitPrice2;
            //    if (objSaleOrdersInfo.ARSaleOrderExchangeRate > 0)
            //        objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 * objSaleOrdersInfo.ARSaleOrderExchangeRate2 / objSaleOrdersInfo.ARSaleOrderExchangeRate;
            //}
            //else if (objSaleOrdersInfo.ARSaleOrderSaleType == SaleType.International.ToString())
            //{
            //    objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * objSaleOrdersInfo.ARSaleOrderExchangeRate / objSaleOrdersInfo.ARSaleOrderExchangeRate2;
            //}
            RoundByCurrency(objSaleOrderItemsInfo);
            SetProductPriceByProductUnitPrice(objSaleOrderItemsInfo);
            return objSaleOrderItemsInfo;
        }

        #endregion
        public string GenerateDefaultGrantedFrom(string saleOrderItemOriginOfProduct)
        {
            string strGrantedFrom = string.Empty;
            if (string.IsNullOrEmpty(saleOrderItemOriginOfProduct))
                return strGrantedFrom;
            try
            {
                switch ((ProductOrigin)Enum.Parse(typeof(ProductOrigin), saleOrderItemOriginOfProduct))
                {
                    case ProductOrigin.DomesticPurchase:
                        strGrantedFrom = SaleOrderItemGrantedFrom.Purchase.ToString();
                        break;
                    case ProductOrigin.Import:
                        strGrantedFrom = SaleOrderItemGrantedFrom.Purchase.ToString();
                        break;
                    case ProductOrigin.Outsourcing:
                        strGrantedFrom = SaleOrderItemGrantedFrom.Production.ToString();
                        break;
                    case ProductOrigin.Production:
                        strGrantedFrom = SaleOrderItemGrantedFrom.Production.ToString();
                        break;
                    default:
                        strGrantedFrom = string.Empty;
                        break;
                }
            }
            catch (Exception ex)
            {
                strGrantedFrom = string.Empty;
            }

            return strGrantedFrom;
        }
        public ARInvoicesInfo GenerateInvoiceFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            ARInvoicesInfo objInvoicesInfo = new ARInvoicesInfo();
            BOSUtil.CopyObject(objSaleOrdersInfo, objInvoicesInfo);

            //Set own properties of invoice
            objInvoicesInfo.AACreatedUser = BOSApp.CurrentUser;
            objInvoicesInfo.AACreatedDate = DateTime.Now;
            objInvoicesInfo.ARInvoiceReference = objSaleOrdersInfo.ARSaleOrderNo;
            objInvoicesInfo.ARInvoiceStatus = BOSCommon.InvoiceStatus.Complete.ToString();
            if (BOSApp.CurrentCompanyInfo != null)
                objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            return objInvoicesInfo;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
        }

        public override bool CompleteTransaction()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            if (objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.New.ToString() || objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.EditAfterComplete.ToString())
            {
                objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.Confirmed.ToString();
                SaveMainObject();
            }

            return true;
        }
        public override bool CancelCompleteTransaction()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            if (objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString() || objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Incomplete.ToString())
            {
                objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }
        public void UpdateARProposalItemsBySaleOrderItem()
        {
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            if (ARSaleOrderItemsList != null && ARSaleOrderItemsList.Count > 0 && ARSaleOrderItemsList[0].FK_ARProposalID != 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<ARProposalItemsInfo> proposalItemList = objProposalItemsController.GetProposalItemsByProposalID(ARSaleOrderItemsList[0].FK_ARProposalID);
                if (proposalItemList != null && proposalItemList.Count > 0)
                {
                    foreach (ARSaleOrderItemsInfo item in ARSaleOrderItemsList)
                    {
                        ARProposalItemsInfo objProposalItemsInfo = proposalItemList.Where(x => x.ARProposalItemID == item.FK_ARProposalItemID).FirstOrDefault();
                        if (objProposalItemsInfo != null)
                        {
                            objProposalItemsInfo.ARProposalItemProductQtyOld += item.ARSaleOrderItemProductQty;
                            objProposalItemsController.UpdateObject(objProposalItemsInfo);
                            dbUtil.SetPropertyValue(item, "ARProposalItemProductQtyOld", objProposalItemsInfo.ARProposalItemProductQtyOld);
                        }
                    }
                }
                List<ARProposalItemsInfo> proposalItem = proposalItemList.Where(x => (Convert.ToDecimal(x.ARProposalItemProductQty - x.ARProposalItemProductQtyOld)) > 0).ToList();
                if (proposalItem == null || proposalItem.Count == 0)
                {
                    ARProposalsController objProposalsController = new ARProposalsController();
                    ARProposalsInfo objProposalsInfo = (ARProposalsInfo)objProposalsController.GetObjectByID(ARSaleOrderItemsList[0].FK_ARProposalID);
                    if (objProposalsInfo != null)
                    {
                        objProposalsInfo.ARProposalStatus = ProposalStatus.Ordered.ToString();
                        objProposalsController.UpdateObject(objProposalsInfo);
                    }
                }

            }
        }

        public void UpdateReferenceSaleForecastItems()
        {
            ICStocksController objStocksController = new ICStocksController();
            ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            ARSFItemComponentsController objSFItemComponentsController = new ARSFItemComponentsController();
            List<ARSaleForecastsInfo> saleForecasts = new List<ARSaleForecastsInfo>();
            List<ARSaleForecastItemsInfo> allSaleForecastItems = new List<ARSaleForecastItemsInfo>();
            ARSaleOrdersInfo SaleOrder = (ARSaleOrdersInfo)MainObject;
            string[] saleForecastNos = SaleOrder.ARSaleOrderReference.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < saleForecastNos.Length; i++)
            {
                string saleForecastNo = saleForecastNos[i].Trim();
                ARSaleForecastsInfo saleForecast = saleForecasts.Where(so => so.ARSaleForecastNo == saleForecastNo).FirstOrDefault();
                if (saleForecast == null)
                {
                    saleForecast = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByNo(saleForecastNo);
                    if (saleForecast != null)
                    {
                        List<ARSaleForecastItemsInfo> saleForecastItems = objSaleForecastItemsController.GetComponentItemsBySaleForecastID(saleForecast.ARSaleForecastID);
                        //Set remained quantity for items
                        foreach (ARSaleForecastItemsInfo saleForecastItem in saleForecastItems)
                        {
                            saleForecastItem.ARSaleForecastItemRemainedQty = saleForecastItem.ARSaleForecastItemProductQty - saleForecastItem.ARSaleForecastItemCanceledQty - saleForecastItem.ARSaleForecastItemProductSOQty;
                        }
                        allSaleForecastItems.AddRange(saleForecastItems);
                        saleForecasts.Add(saleForecast);
                    }
                }
            }


            //Rollback ordered quantity of the reference sale order
            foreach (ARSaleOrderItemsInfo SaleOrderItem in ComponentSaleOrderItemList.BackupList)
            {
                ARSaleForecastsInfo objSOInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByNo(saleForecastNos[0]);
                decimal SaleOrderItemQty = SaleOrderItem.ARSaleOrderItemProductQty;
                while (SaleOrderItemQty > 0)
                {
                    List<ARSaleForecastItemsInfo> lst = new List<ARSaleForecastItemsInfo>();
                    if (objSOInfo != null)
                    {
                        lst = objSaleForecastItemsController.GetItemsBySaleForecastID(objSOInfo.ARSaleForecastID);
                    }

                    ARSaleForecastItemsInfo SaleForecastItem = lst.Where(i => i.FK_ICProductID == SaleOrderItem.FK_ICProductID &&
                                                                                      i.ARSaleForecastItemProductSOQty > 0).FirstOrDefault();
                    decimal shippedQty = 0;
                    if (SaleForecastItem != null)
                    {
                        shippedQty = Math.Min(SaleOrderItemQty, SaleForecastItem.ARSaleForecastItemProductSOQty);
                    }
                    else
                    {
                        SaleForecastItem = allSaleForecastItems.Where(i => i.FK_ICProductID == SaleOrderItem.FK_ICProductID).FirstOrDefault();
                        shippedQty = SaleOrderItemQty;
                    }

                    if (SaleForecastItem != null)
                    {
                        //Rollback shipped quantity
                        SaleForecastItem.ARSaleForecastItemProductSOQty -= shippedQty;
                        SaleForecastItem.ARSaleForecastItemRemainedQty = SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemCanceledQty - SaleForecastItem.ARSaleForecastItemProductSOQty;
                        //In case user removes an SaleOrder item, the shipped quantity of the reference sale order one needs to be updated as well
                        if (ComponentSaleOrderItemList.Exists(i => i.ARSaleOrderItemID == SaleOrderItem.ARSaleOrderItemID))
                        {
                            if (!SaleForecastItem.IsSubItem)
                            {
                                objSaleForecastItemsController.UpdateSOQty(SaleForecastItem.ARSaleForecastItemID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                            }
                            else
                            {
                                objSFItemComponentsController.UpdateSOQty(SaleForecastItem.ARSFItemComponentID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                            }
                        }

                        ARSaleForecastsInfo SaleForecast = saleForecasts.Where(so => so.ARSaleForecastID == SaleForecastItem.FK_ARSaleForecastID).FirstOrDefault();

                        SaleOrderItemQty -= shippedQty;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Update new ordered quantity
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            foreach (ARSaleOrderItemsInfo SaleOrderItem in ComponentSaleOrderItemList)
            {
                ARSaleForecastsInfo objSOInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByNo(saleForecastNos[0]);
                decimal SaleOrderItemQty = SaleOrderItem.ARSaleOrderItemProductQty;
                while (SaleOrderItemQty > 0)
                {

                    List<ARSaleForecastItemsInfo> lst = new List<ARSaleForecastItemsInfo>();
                    if (objSOInfo != null)
                    {
                        lst = objSaleForecastItemsController.GetItemsBySaleForecastID(objSOInfo.ARSaleForecastID);
                    }
                    ARSaleForecastItemsInfo SaleForecastItem = new ARSaleForecastItemsInfo();
                    foreach (ARSaleForecastItemsInfo i in allSaleForecastItems.OrderBy(a => a.ARSaleForecastItemID).ToList())
                    {
                        ARSaleForecastItemsInfo SaleForecastItems = new ARSaleForecastItemsInfo();
                        ARSaleForecastItemsInfo objSFIInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(i.ARSaleForecastItemID);
                        if (objSFIInfo != null)
                        {
                            SaleForecastItems = objSFIInfo;
                        }
                        if ((SaleForecastItems.FK_ICProductID == SaleOrderItem.FK_ICProductID) && (SaleForecastItems.ARSaleForecastItemProductQty - SaleForecastItems.ARSaleForecastItemProductSOQty > 0))
                        {
                            SaleForecastItem = SaleForecastItems;
                            break;
                        }
                    }

                    decimal shippedQty = 0;
                    if (SaleForecastItem != null)
                    {
                        if (SaleForecastItem.ARSaleForecastItemProductQty > 0)
                            shippedQty = Math.Min(SaleOrderItemQty, SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemProductSOQty);
                        else
                            shippedQty = SaleOrderItemQty;
                    }
                    else
                    {
                        SaleForecastItem = lst.Where(i => i.FK_ICProductID == SaleOrderItem.FK_ICProductID).FirstOrDefault();
                        if (SaleForecastItem != null && SaleForecastItem.ARSaleForecastItemProductQty > 0)
                            shippedQty = Math.Min(SaleOrderItemQty, SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemProductSOQty);
                        else
                            shippedQty = SaleOrderItemQty;
                    }

                    if (SaleForecastItem != null)
                    {
                        //Update new shipped quantity
                        ARSaleForecastItemsInfo objSFIInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(SaleForecastItem.ARSaleForecastItemID);
                        if (objSFIInfo != null)
                        {
                            SaleForecastItem = objSFIInfo;
                        }
                        SaleForecastItem.ARSaleForecastItemProductSOQty += shippedQty;
                        foreach (ARSaleForecastItemsInfo asoi in allSaleForecastItems.OrderBy(a => a.ARSaleForecastItemID))
                        {
                            if (asoi.ARSaleForecastItemID == SaleForecastItem.ARSaleForecastItemID)
                            {
                                asoi.ARSaleForecastItemProductSOQty += shippedQty;
                                break;
                            }
                        }

                        SaleForecastItem.ARSaleForecastItemRemainedQty = SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemCanceledQty - SaleForecastItem.ARSaleForecastItemProductSOQty;

                        if (!SaleForecastItem.IsSubItem)
                        {
                            if (SaleForecastItem.ARSaleForecastItemProductSOQty > 0)
                            {

                                objSaleForecastItemsController.UpdateSOQty(SaleForecastItem.ARSaleForecastItemID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                            }
                        }
                        else
                        {
                            objSFItemComponentsController.UpdateSOQty(SaleForecastItem.ARSFItemComponentID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                        }

                        ARSaleForecastsInfo SaleForecast = saleForecasts.Where(so => so.ARSaleForecastID == SaleForecastItem.FK_ARSaleForecastID).FirstOrDefault();
                        SaleOrderItemQty -= shippedQty;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Update the sale order's status
            foreach (ARSaleForecastsInfo SaleForecast in saleForecasts)
            {
                bool isRemained = true;
                foreach (ARSaleForecastItemsInfo SaleForecastItem in allSaleForecastItems)
                {
                    ARSaleForecastItemsInfo SaleForecastItems = new ARSaleForecastItemsInfo();
                    ARSaleForecastItemsInfo objSFIInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(SaleForecastItem.ARSaleForecastItemID);
                    if (objSFIInfo != null)
                    {
                        SaleForecastItems = objSFIInfo;
                    }
                    if (SaleForecastItems.FK_ARSaleForecastID == SaleForecast.ARSaleForecastID &&
                        SaleForecastItems.FK_ICProductID > 0 &&
                        (SaleForecastItems.ARSaleForecastItemProductSOQty + SaleForecastItems.ARSaleForecastItemCanceledQty) < SaleForecastItems.ARSaleForecastItemProductQty)
                    {
                        isRemained = false;
                        break;
                    }
                }

                if (isRemained)
                {
                    SaleForecast.ARSaleForecastStatus = SaleForecastStatus.Complete.ToString();
                    SaleForecast.AAUpdatedUser = BOSApp.CurrentUser;
                    SaleForecast.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(SaleForecast);
                }
                else
                {
                    SaleForecast.ARSaleForecastStatus = SaleForecastStatus.Incomplete.ToString();
                    SaleForecast.AAUpdatedUser = BOSApp.CurrentUser;
                    SaleForecast.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(SaleForecast);
                }
            }
        }

        public void InvalidateItemComponents()
        {
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            List<ARSaleOrderItemsInfo> items = objSaleOrderItemsController.GetComponentItemsBySaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
            ComponentSaleOrderItemList.Clear();
            ComponentSaleOrderItemList.OriginalList.Clear();
            foreach (ARSaleOrderItemsInfo item in items)
            {
                ComponentSaleOrderItemList.Add((ARSaleOrderItemsInfo)item.Clone());
            }

            foreach (ARSaleOrderItemsInfo item in ComponentSaleOrderItemList)
            {
                ComponentSaleOrderItemList.OriginalList.Add((ARSaleOrderItemsInfo)item.Clone());
            }
        }

        #region Accounting
        private void SavePaymentEntries(ARCustomerPaymentsInfo customerPayment)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)MainObject;
            string oldReceiptVoucherNo = string.Empty;
            string oldBankTransferNo = string.Empty;
            //Delete all payment data first
            if (!string.IsNullOrEmpty(customerPayment.ARCustomerPaymentNo))
            {
                ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                ARReceiptVouchersInfo receiptVoucher = objReceiptVouchersController.GetReceiptVoucherByReference(customerPayment.ARCustomerPaymentNo);
                if (receiptVoucher != null)
                {
                    oldReceiptVoucherNo = receiptVoucher.ARReceiptVoucherNo;
                }

                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo bankTransfer = objBankTransactionsController.GetBankTransactionByReference(customerPayment.ARCustomerPaymentNo);
                if (bankTransfer != null)
                {
                    oldBankTransferNo = bankTransfer.ACBankTransactionNo;
                }
                objCustomerPaymentsController.DeletePaymentEntriesByNo(customerPayment.ARCustomerPaymentNo);
            }
        }

        private ARReceiptVouchersInfo CreateReceiptVoucher(ARCustomerPaymentsInfo customerPayment, string oldReceiptVoucherNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();

            ARReceiptVouchersInfo receiptVoucher = new ARReceiptVouchersInfo();
            BOSUtil.CopyObject(customerPayment, receiptVoucher);
            if (string.IsNullOrEmpty(oldReceiptVoucherNo))
            {
                receiptVoucher.ARReceiptVoucherNo = BOSApp.GetMainObjectNo(ModuleName.ReceiptVoucher, receiptVoucher);
                BOSApp.UpdateObjectNumbering(ModuleName.ReceiptVoucher);
            }
            else
            {
                receiptVoucher.ARReceiptVoucherNo = oldReceiptVoucherNo;
            }
            receiptVoucher.FK_ACObjectID = customerPayment.FK_ARCustomerID;
            receiptVoucher.ARObjectType = ObjectType.Customer.ToString();
            receiptVoucher.ARReceiptVoucherType = ReceiptVoucherType.Deposit.ToString();
            receiptVoucher.ARReceiptVoucherReference = customerPayment.ARCustomerPaymentNo;
            receiptVoucher.FK_GECurrencyID = currencyID;
            receiptVoucher.ARReceiptVoucherExchangeRate = exchangeRate;
            receiptVoucher.ARReceiptVoucherTotalAmount = amount;
            receiptVoucher.ARReceiptVoucherExchangeAmount = receiptVoucher.ARReceiptVoucherTotalAmount * receiptVoucher.ARReceiptVoucherExchangeRate;
            int receiptVoucherID = objReceiptVouchersController.CreateObject(receiptVoucher);

            objReceiptVoucherItemsController.DeleteByForeignColumn("FK_ARReceiptVoucherID", receiptVoucher.ARReceiptVoucherID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.PhieuThu.ToString())
                {
                    ARReceiptVoucherItemsInfo item = new ARReceiptVoucherItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ARReceiptVoucherID = receiptVoucher.ARReceiptVoucherID;
                    objReceiptVoucherItemsController.CreateObject(item);
                }
            }
            return receiptVoucher;
        }

        private ACBankTransactionsInfo CreateBankTransfer(ARCustomerPaymentsInfo customerPayment, string oldBankTransferNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(customerPayment.FK_CSCompanyBankID);

            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            ACBankTransactionsInfo bankTransfer = new ACBankTransactionsInfo();
            BOSUtil.CopyObject(customerPayment, bankTransfer);
            if (string.IsNullOrEmpty(oldBankTransferNo))
            {
                bankTransfer.ACBankTransactionNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, bankTransfer);
                BOSApp.UpdateObjectNumbering(ModuleName.BankTransaction);
            }
            else
            {
                bankTransfer.ACBankTransactionNo = oldBankTransferNo;
            }
            bankTransfer.FK_ACObjectID = customerPayment.FK_ARCustomerID;
            bankTransfer.ACObjectType = ObjectType.Customer.ToString();
            bankTransfer.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
            bankTransfer.ACBankTransactionReference = customerPayment.ARCustomerPaymentNo;
            bankTransfer.ACBankTransactionReceiverBankName = bankName;
            bankTransfer.ACBankTransactionReceiverAccount = customerPayment.ARCustomerPaymentBankAccount;
            bankTransfer.FK_GECurrencyID = currencyID;
            bankTransfer.ACBankTransactionExchangeRate = exchangeRate;
            bankTransfer.ACBankTransactionTotalAmount = amount;
            bankTransfer.ACBankTransactionExchangeAmount = bankTransfer.ACBankTransactionTotalAmount * bankTransfer.ACBankTransactionExchangeRate;
            int bankTransferID = objBankTransactionsController.CreateObject(bankTransfer);

            objBankTransactionItemsController.DeleteByForeignColumn("FK_ACBankTransactionID", bankTransfer.ACBankTransactionID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.NopTienVaoTaiKhoan.ToString())
                {
                    ACBankTransactionItemsInfo item = new ACBankTransactionItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ACBankTransactionID = bankTransfer.ACBankTransactionID;
                    objBankTransactionItemsController.CreateObject(item);
                }
            }
            return bankTransfer;
        }
        #endregion

        public void GenerateCustomerFromProspectCustomer(ARProspectCustomersInfo objProspectCustomersInfo)
        {
            ARCustomersInfo objCustomersInfo = new ARCustomersInfo();
            List<string> item = new List<string>();
            objCustomersInfo.ARCustomerContactFirstName = objProspectCustomersInfo.ARProspectCustomerFirstName;
            objCustomersInfo.ARCustomerContactLastName = objProspectCustomersInfo.ARProspectCustomerLastName;
            objCustomersInfo.ARCustomerActiveCheck = true;
            objCustomersInfo.IsBuyingLocked = false;
            objCustomersInfo.ARCustomerContactCellPhone = objProspectCustomersInfo.ARProspectCustomerCellPhone;
            objCustomersInfo.ARCustomerWebsite = objProspectCustomersInfo.ARProspectCustomerWebsite;
            objCustomersInfo.ARCustomerCRMType = CustomerCRMType.Customer.ToString();
            objCustomersInfo.ARCustomerContactPhone = objProspectCustomersInfo.ARProspectCustomerTel;
            if (!string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerLastName) && !string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerFirstName))
            {
                objCustomersInfo.ARCustomerName = string.Format("{0}{1}{2}", objProspectCustomersInfo.ARProspectCustomerLastName, " ",
                                                                                    objProspectCustomersInfo.ARProspectCustomerFirstName);
            }
            else if (!string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerCompany))
            {
                objCustomersInfo.ARCustomerName = objProspectCustomersInfo.ARProspectCustomerCompany;
            }
            objCustomersInfo.FK_BRBranchID = objProspectCustomersInfo.FK_BRBranchID;
            if (objProspectCustomersInfo.ARProspectCustomerAddress != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddress);
            }
            if (objProspectCustomersInfo.ARProspectCustomerAddressDistrict != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddressDistrict);
            }
            if (objProspectCustomersInfo.ARProspectCustomerAddressCity != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddressCity);
            }
            if (objProspectCustomersInfo.ARProspectCustomerAddressCountry != null)
            {
                item.Add(objProspectCustomersInfo.ARProspectCustomerAddressCountry);
            }
            objCustomersInfo.ARCustomerPaymentAddressLine1 = string.Join(", ", item.Where(o => !string.IsNullOrEmpty(o)).ToArray());
            objCustomersInfo.ARCustomerInvoiceAddressLine1 = objCustomersInfo.ARCustomerPaymentAddressLine1;
            objCustomersInfo.ARCustomerDeliveryAddressLine1 = objCustomersInfo.ARCustomerPaymentAddressLine1;
            objCustomersInfo.ARCustomerContactAddressLine1 = objCustomersInfo.ARCustomerPaymentAddressLine1;
            objCustomersInfo.ARCustomerBusiness = objProspectCustomersInfo.ARProspectCustomerBusiness;
            objCustomersInfo.FK_ARProspectCustomerID = objProspectCustomersInfo.ARProspectCustomerID;
            objCustomersInfo.ARCustomerLunarBirthday = objProspectCustomersInfo.ARProspectCustomerLunarBirthday;
            objCustomersInfo.ARCustomerContactBirthday = objProspectCustomersInfo.ARProspectCustomerBirthday;
            objCustomersInfo.ARCustomerContactEmail1 = objProspectCustomersInfo.ARProspectCustomerEmail;
            objCustomersInfo.ARCustomerSex = objProspectCustomersInfo.ARProspectCustomerGender;
            objCustomersInfo.ARCustomerContactAddressDistrict = objProspectCustomersInfo.ARProspectCustomerAddressDistrict;
            objCustomersInfo.ARCustomerContactAddressCity = objProspectCustomersInfo.ARProspectCustomerAddressCity;
            objCustomersInfo.ARCustomerContactAddressCountry = objProspectCustomersInfo.ARProspectCustomerAddressCountry;
            objCustomersInfo.ARGender = objProspectCustomersInfo.ARProspectCustomerGender;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.CustomersInfo = objCustomersInfo;
        }

        public override void DuplicateModuleObjectList()
        {
            ARSaleOrderItemsList.Duplicate();
            ARSaleOrderItemsList.ForEach(p =>
            {
                p.FK_ARSaleOrderID = 0;
                p.FK_ARProposalID = 0;
                p.FK_ARProposalItemID = 0;
                p.ARSaleOrderItemCanceledQty = 0;
                p.ARSaleOrderItemPlanQty = 0;
                p.ARSaleOrderItemShippedQty = 0;
            });
            ARSaleOrderItemWorkList.Duplicate();
            ARSaleOrderItemWorkList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            ARSaleOrderItemCostList.Duplicate();
            ARSaleOrderItemCostList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            ARSaleOrderItemWorkTaskList.Duplicate();
            ARSaleOrderItemWorkTaskList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            ARSaleOrderItemWorkAssetList.Duplicate();
            ARSaleOrderItemWorkAssetList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            ARSaleOrderItemWorkMaterialList.Duplicate();
            ARSaleOrderItemWorkMaterialList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            ARSaleOrderItemWorkTaskList.Duplicate();
            ARSaleOrderItemWorkTaskList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            SaleOrderItemOtherFeeList.Duplicate();
            SaleOrderItemOtherFeeList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
            SaleOrderItemAllocationFeeList.Duplicate();
            SaleOrderItemAllocationFeeList.ForEach(p => { p.FK_ARSaleOrderID = 0; });
        }

        public void GenerateEntitiesFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo, List<ARSaleForecastItemsInfo> saleForecastItemList)
        {
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)MainObject;

            //Generate SaleOrder            
            GenerateSaleOrderFromSaleForecast(objSaleForecastsInfo);

            //Generate SaleOrder items
            GenerateSaleOrderItemsFromSaleForecast(saleForecastItemList);

            UpdateTotalAmount(ARSaleOrderItemsList);
        }

        /// <summary>
        /// Generate an SaleOrder from a given sale order and set to main object
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale forecast</param>
        private void GenerateSaleOrderFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo)
        {
            //Copy SaleOrder
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ARSaleOrdersInfo oldSaleOrder = (ARSaleOrdersInfo)MainObject.Clone();
            BOSUtil.CopyObject(objSaleForecastsInfo, objSaleOrdersInfo);

            //Recalculate deposit balance of the SaleOrder
            ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            decimal totalSaleOrderDeposit = objSaleForecastsController.GetTotalInvoiceDeposit(objSaleForecastsInfo.ARSaleForecastID);
            //decimal owingExchangeAmount = objSaleForecastsController.GetTotalDeposit(objSaleForecastsInfo.ARSaleForecastID, PaymentMethod.OwingExchange.ToString());
            //owingExchangeAmount = Math.Max(owingExchangeAmount - totalSaleOrderDeposit, 0);
            objSaleOrdersInfo.ARSaleOrderDepositBalance = objSaleForecastsInfo.ARSaleForecastDepositBalance - totalSaleOrderDeposit;
            // objSaleOrdersInfo.ARSaleOrderOwingExchangeAmount = Math.Min(objSaleOrdersInfo.ARSaleOrderDepositBalance - totalSaleOrderDeposit, owingExchangeAmount);
            objSaleOrdersInfo.FK_ICProductAttributeTTMTID = oldSaleOrder.FK_ICProductAttributeTTMTID;
            //Restore some its own properties
            objSaleOrdersInfo.ARSaleOrderBatchStatus = string.Empty;
            objSaleOrdersInfo.ARSaleOrderNo = oldSaleOrder.ARSaleOrderNo;
            objSaleOrdersInfo.ARSaleOrderName = oldSaleOrder.ARSaleOrderName;
            objSaleOrdersInfo.ARSaleOrderDesc = oldSaleOrder.ARSaleOrderDesc;
            if (objSaleOrdersInfo.FK_GECurrencyID2 == 0 || objSaleOrdersInfo.ARSaleOrderExchangeRate2 == 0)
            {
                objSaleOrdersInfo.FK_GECurrencyID2 = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
                objSaleOrdersInfo.ARSaleOrderExchangeRate2 = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            }
            objSaleOrdersInfo.ARSaleOrderStatus = oldSaleOrder.ARSaleOrderStatus;
            objSaleOrdersInfo.ARSaleOrderDate = oldSaleOrder.ARSaleOrderDate;
            objSaleOrdersInfo.ARSaleOrderValidateDate = oldSaleOrder.ARSaleOrderValidateDate;
            objSaleOrdersInfo.ARSaleOrderReference = objSaleForecastsInfo.ARSaleForecastNo;
            objSaleOrdersInfo.ARSaleOrderPONo = objSaleForecastsInfo.ARSaleForecastPONo;
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = objSaleForecastsInfo.ARSaleForecastDeliveryDate;
            objSaleOrdersInfo.FK_HREmployeeID = objSaleForecastsInfo.FK_HREmployeeID;
            objSaleOrdersInfo.ARSaleOrderEmployeePicture = oldSaleOrder.ARSaleOrderEmployeePicture;
            objSaleOrdersInfo.FK_ARAssociatedSellerID = objSaleForecastsInfo.FK_ARAssociatedSellerID;
            objSaleOrdersInfo.ARSaleOrderSOContactName = objSaleForecastsInfo.ARSaleForecastSFContactName;
            objSaleOrdersInfo.ARSaleOrderDeliveryContactName = objSaleForecastsInfo.ARSaleForecastDeliveryContactName;
            objSaleOrdersInfo.ARSaleOrderComment = objSaleForecastsInfo.ARSaleForecastComment;
            objSaleOrdersInfo.ARSaleOrderType = objSaleForecastsInfo.ARSaleForecastType;
            objSaleOrdersInfo.ARSaleOrderProductType = objSaleForecastsInfo.ARSaleForecastProductType;
            if (BOSApp.CurrentCompanyInfo != null)
            { objSaleOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID; }
            objSaleOrdersInfo.ARSaleOrderTotalProduct = 0;
            if (objSaleForecastsInfo.FK_ARAssociatedSellerID > 0)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objSaleForecastsInfo.FK_ARAssociatedSellerID);
                ARSalesmansInfo objSalesmansInfo = new ARSalesmansInfo();
                objSalesmansInfo.FK_HREmployeeID = objSaleForecastsInfo.FK_ARAssociatedSellerID;
                objSalesmansInfo.ARSalesmanName = objEmployeesInfo != null ? objEmployeesInfo.HREmployeeName : string.Empty;
                objSalesmansInfo.ARSalesmanType = SalesmanType.SubSeller.ToString();
                objSalesmansInfo.ARSalesmanCommissionPercent = 0;
                ARSalesmansList.Add(objSalesmansInfo);
            }
            objSaleOrdersInfo.ARSaleOrderSaleType = string.IsNullOrWhiteSpace(objSaleForecastsInfo.ARSaleForecastSaleType) ? oldSaleOrder.ARSaleOrderSaleType : objSaleForecastsInfo.ARSaleForecastSaleType;
            objSaleOrdersInfo.ARSaleOrderType = string.IsNullOrWhiteSpace(objSaleForecastsInfo.ARSaleForecastType) ? oldSaleOrder.ARSaleOrderType : objSaleForecastsInfo.ARSaleForecastType;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            List<CSCompanyBanksInfo> listCompanyBank = (List<CSCompanyBanksInfo>)objCompanyBanksController.GetListCompanyBanksBySaleType(objSaleOrdersInfo.ARSaleOrderSaleType);
            if (listCompanyBank != null && listCompanyBank.Count > 0)
            {
                objSaleOrdersInfo.FK_CSCompanyBankID = listCompanyBank.Select(o => o.CSCompanyBankID).FirstOrDefault();
            }
        }

        /// <summary>
        /// Generate invoice items from a given sale order and add them to the current invoice item list        
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        private void GenerateSaleOrderItemsFromSaleForecast(List<ARSaleForecastItemsInfo> saleForecastItemList)
        {
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)MainObject;
            //Copy item list

            ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo saleOrderItemsInfo;
            foreach (ARSaleForecastItemsInfo objSaleForecastItemsInfo in saleForecastItemList)
            {
                objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty;
                if (objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty > 0)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                    BOSUtil.CopyObject(objSaleForecastItemsInfo, objSaleOrderItemsInfo);
                    objSaleOrderItemsInfo.ARSaleOrderItemVirtualID = Guid.NewGuid().ToString();
                    objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty = 0;
                    objSaleOrderItemsInfo.FK_ARSaleForecastItemID = objSaleForecastItemsInfo.ARSaleForecastItemID;
                    objSaleOrderItemsInfo.FK_ICMeasureUnitID = objSaleForecastItemsInfo.FK_ICMeasureUnitID;
                    objSaleOrderItemsInfo.ARSaleOrderItemProductQty = objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty;
                    objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate = objSaleForecastItemsInfo.ARSaleForecastItemDeliveryDate;
                    objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice = objSaleForecastItemsInfo.ARSaleForecastItemProductUnitPrice;
                    objSaleOrderItemsInfo.FK_ICProductAttributeTTMTID = mainObject.FK_ICProductAttributeTTMTID;
                    objSaleOrderItemsInfo.ICProductUnitPrice = objSaleForecastItemsInfo.ICProductUnitPrice;
                    if (mainObject.ARSaleOrderSaleType == SaleType.International.ToString())
                    {
                        objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * mainObject.ARSaleOrderExchangeRate / mainObject.ARSaleOrderExchangeRate2;
                    }
                    RoundByCurrency(objSaleOrderItemsInfo);
                    SetProductPriceByProductUnitPrice(objSaleOrderItemsInfo);

                    objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                    objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(
                                                        this,
                                                        TableName.ARSaleOrderItemsTableName,
                                                        TableName.ARSOItemComponentsTableName,
                                                        BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                    objSaleOrderItemsInfo.ARSOItemComponentList.ItemTableForeignKey = "FK_ARSaleOrderItemID";

                    //Generate invoice item component from sale order item
                    objSaleForecastItemsInfo.ARSFItemComponentList = new BOSList<ARSFItemComponentsInfo>();
                    objSaleForecastItemsInfo.ARSFItemComponentList.InitBOSList(null,
                                                            TableName.ARSaleForecastItemsTableName,
                                                            TableName.ARSFItemComponentsTableName,
                                                            BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                    ARSFItemComponentsController objSFItemComponentsController = new ARSFItemComponentsController();

                    if (objSaleForecastItemsInfo.ARSFItemComponentList.Count > 0)
                    {
                        objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                        objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(this,
                                                            TableName.ARSaleOrderItemsTableName,
                                                            TableName.ARSOItemComponentsTableName,
                                                            BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                        objSaleOrderItemsInfo.ARSOItemComponentList.ItemTableForeignKey = "FK_ARSaleOrderItemID";
                        foreach (ARSFItemComponentsInfo objSFItemComponentsInfo in objSaleForecastItemsInfo.ARSFItemComponentList)
                        {
                            ARSOItemComponentsInfo objSOItemComponentsInfo = new ARSOItemComponentsInfo();
                            BOSUtil.CopyObject(objSFItemComponentsInfo, objSOItemComponentsInfo);
                            objSOItemComponentsInfo.ARSOItemComponentQty = objSFItemComponentsInfo.ARSFItemComponentQty - objSOItemComponentsInfo.ARSOItemComponentShippedQty;

                            objSaleOrderItemsInfo.ARSOItemComponentList.Add(objSOItemComponentsInfo);
                        }
                    }

                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleForecastItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        //Block
                        objSaleOrderItemsInfo.ARSaleOrderItemBlockPerOne = objProductsInfo.ICProductBlock;
                        objSaleOrderItemsInfo.ARSaleOrderItemBlock = objSaleOrderItemsInfo.ARSaleOrderItemBlockPerOne * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                        // Hoàn thi?n
                        objSaleOrderItemsInfo.ARSaleOrderItemHTID = objProductsInfo.ICProductAttributeFinishing;
                        objSaleOrderItemsInfo.ARSaleOrderItemHTText = objProductsInfo.ICProductAttributeFinishingText;
                        objSaleOrderItemsInfo.ARSaleOrderItemLength = objProductsInfo.ICProductLength;
                        objSaleOrderItemsInfo.ARSaleOrderItemHeight = objProductsInfo.ICProductHeight;
                        objSaleOrderItemsInfo.ARSaleOrderItemWidth = objProductsInfo.ICProductWidth;
                        objSaleOrderItemsInfo.ARSaleOrderItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                        objSaleOrderItemsInfo.ARSaleOrderItemOriginOfProduct = objProductsInfo.ICProductOriginOfProduct;
                        objSaleOrderItemsInfo.ARSaleOrderItemProductCustomerNumber = objSaleForecastItemsInfo.ARSaleForecastItemProductCustomerNumber;
                        objSaleOrderItemsInfo.ARSaleOrderItemGrantedFrom = GenerateDefaultGrantedFrom(objSaleOrderItemsInfo.ARSaleOrderItemOriginOfProduct);
                        decimal unitVolumn = objProductsInfo.ICProductVolume > 0 ? objProductsInfo.ICProductVolume : Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemHeight * objSaleOrderItemsInfo.ARSaleOrderItemWidth * objSaleOrderItemsInfo.ARSaleOrderItemLength)
                                            / (decimal)Math.Pow(10, 9), 4);
                        objSaleOrderItemsInfo.ARSaleOrderItemProductCBM = unitVolumn * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                        objSaleOrderItemsInfo.ARSaleOrderItemBlock = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * ( Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemHeight * objSaleOrderItemsInfo.ARSaleOrderItemWidth * objSaleOrderItemsInfo.ARSaleOrderItemLength)
                                                   / (decimal)Math.Pow(10, 9), 4));
                        //Màu son
                        objSaleOrderItemsInfo.ARSaleOrderItemColorID = objProductsInfo.ICProductColorAttribute;
                        //Lo?i g?
                        objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID = objProductsInfo.ICProductWoodTypeAttribute;
                        objSaleOrderItemsInfo.ARSaleOrderItemIsDeliveryPlan = mainObject.ARSaleOrderIsDeliveryPlan;
                        objSaleOrderItemsInfo.ARSaleOrderItemIsSaleOrderShipment = mainObject.ARSaleOrderIsSaleOrderShipment;
                        objSaleOrderItemsInfo.ARSaleOrderItemIsInvoiceAndShipment = mainObject.ARSaleOrderIsInvoiceAndShipment;
                        objSaleOrderItemsInfo.ARSaleOrderItemIsVehicleAllocation = mainObject.ARSaleOrderIsVehicleAllocation;
                        objSaleOrderItemsInfo.ARSaleOrderItemIsAcceptance = mainObject.ARSaleOrderIsAcceptance;
                        objSaleOrderItemsInfo.ARSaleOrderItemIsContainerLoader = mainObject.ARSaleOrderIsContainerLoader;
                        ARSaleOrderItemsList.Add(objSaleOrderItemsInfo);
                    }
                }
            }
        }

        public GECurrencyExchangeRatesInfo GetCurrencyExchangeRate(int currencyID, DateTime currentDate)
        {
            return (new GECurrencyExchangeRatesController()).GetCurrencyExchangeRateByCurrencyIDAnddate(currencyID, currentDate);
        }

        //public override string GetMainObjectNo(ref int numberingStart)
        //{

        //    String strMainObjectNo = String.Empty;
        //    GENumberingController objGENumberingController = new GENumberingController();

        //    GENumberingInfo objGENumberingInfo;
        //    objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

        //    if (objGENumberingInfo != null)
        //    {
        //        String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
        //        IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
        //        if (objMainObjectController != null)
        //        {
        //            BOSDbUtil dbUtil = new BOSDbUtil();
        //            DateTime currentDate = BOSApp.GetCurrentServerDate();

        //            if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
        //            {
        //                objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
        //            }

        //            strMainObjectNo = GenarateObjectNo(objGENumberingInfo);
        //            numberingStart = objGENumberingInfo.GENumberingStart;
        //            while (objMainObjectController.IsExist(strMainObjectNo))
        //            {
        //                objGENumberingInfo.GENumberingStart++;
        //                strMainObjectNo = GenarateObjectNo(objGENumberingInfo);
        //                numberingStart = objGENumberingInfo.GENumberingStart;
        //            }
        //        }
        //    }
        //    return strMainObjectNo;
        //}

        //private string GenarateObjectNo(GENumberingInfo objGENumberingInfo)
        //{
        //    string strMainObjectNo = string.Empty;
        //    BOSDbUtil dbUtil = new BOSDbUtil();
        //    DateTime currentDate = BOSApp.GetCurrentServerDate();
        //    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
        //    string prefix;
        //    switch (objSaleOrdersInfo.ARSaleOrderType)
        //    {
        //        case "MassProduction":
        //            prefix = "PI.M-";
        //            break;
        //        case "PaymentSample":
        //            prefix = "PI.S-";
        //            break;
        //        case "FOCSample":
        //            prefix = "PI.SF-";
        //            break;
        //        case "SpareFOCSample":
        //            prefix = "PI.SPF-";
        //            break;
        //        case "PaymentSpareSample":
        //            prefix = "PI.SP-";
        //            break;
        //        default:
        //            prefix = objGENumberingInfo.GENumberingPrefix;
        //            break;
        //    }
        //    if (objGENumberingInfo.GENumberingPrefixHaveYear)
        //    {
        //        strMainObjectNo = String.Format("{0}{1}.{2}",
        //                                        prefix,
        //                                        currentDate.Year.ToString().Substring(2, 2),
        //                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
        //    }
        //    else
        //    {
        //        strMainObjectNo = String.Format("{0}.{1}",
        //                                        prefix,
        //                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
        //    }
        //    return strMainObjectNo;
        //}
    }
}
