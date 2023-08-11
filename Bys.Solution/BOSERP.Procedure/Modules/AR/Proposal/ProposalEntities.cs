using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BOSERP.Modules.Proposal
{
    public class ProposalEntities : BaseTransactionEntities
    {
        #region Declare Constant
        public readonly static String strARProposalItemsObjectName = "ARProposalItems";

        #endregion

        #region Declare all entities variables
        public BOSList<ARProposalItemsInfo> ARProposalItemsList;

        public BOSList<ARProposalItemWorksInfo> ARProposalItemWorkList { get; set; }

        public BOSList<ARProposalItemWorksInfo> ARProposalItemWorkMaterialList { get; set; }

        public BOSList<ARProposalItemWorksInfo> ARProposalItemWorkAssetList { get; set; }

        public BOSList<ARProposalItemWorksInfo> ARProposalItemCostList { get; set; }

        public BOSList<ARProposalItemWorkTasksInfo> ARProposalItemWorkTasksList { get; set; }

        public BOSList<ARProposalItemWorksInfo> ARProposalItemWorkExternalList { get; set; }

        public BOSList<ARProposalItemWorksInfo> ARProposalItemCostExternalList { get; set; }

        public ARPriceLevelsInfo ARPriceLevelsInfo { get; set; }

        public BOSList<ARProposalPaymentTimesInfo> ARProposalPaymentTimesList { get; set; }

        public BOSTreeList TemplateItemList { get; set; }

        public BOSList<ARProposalAreasInfo> ProposalAreasList { get; set; }

        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public ProposalEntities()
            : base()
        {
            ARProposalItemsList = new BOSList<ARProposalItemsInfo>();
            ARProposalItemWorkList = new BOSList<ARProposalItemWorksInfo>();
            ARProposalItemWorkMaterialList = new BOSList<ARProposalItemWorksInfo>();
            ARProposalItemWorkAssetList = new BOSList<ARProposalItemWorksInfo>();
            ARProposalItemCostList = new BOSList<ARProposalItemWorksInfo>();
            ARProposalItemWorkExternalList = new BOSList<ARProposalItemWorksInfo>();
            ARProposalItemWorkTasksList = new BOSList<ARProposalItemWorkTasksInfo>();
            ARPriceLevelsInfo = new ARPriceLevelsInfo();
            ARProposalItemCostExternalList = new BOSList<ARProposalItemWorksInfo>();
            ARProposalPaymentTimesList = new BOSList<ARProposalPaymentTimesInfo>();
            TemplateItemList = new BOSTreeList();
            ProposalAreasList = new BOSList<ARProposalAreasInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARProposalsInfo();
            SearchObject = new ARProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARProposalItemsTableName, new ARProposalItemsInfo());
            ModuleObjects.Add(TableName.ARProposalTemplateItemsTableName, new ARProposalTemplateItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ARProposalItemsList.InitBOSList(this, TableName.ARProposalsTableName, TableName.ARProposalItemsTableName);

            ARProposalItemWorkList.InitBOSList(this,
                                              TableName.ARProposalsTableName,
                                              TableName.ARProposalItemWorksTableName,
                                              BOSList<ARProposalItemWorksInfo>.cstRelationForeign);
            ARProposalItemWorkList.ItemTableForeignKey = "FK_ARProposalID";

            ARProposalItemWorkMaterialList.InitBOSList(this,
                                              TableName.ARProposalsTableName,
                                              TableName.ARProposalItemWorksTableName,
                                              BOSList<ARProposalItemWorksInfo>.cstRelationForeign);
            ARProposalItemWorkMaterialList.ItemTableForeignKey = "FK_ARProposalID";

            ARProposalItemWorkAssetList.InitBOSList(this,
                                              TableName.ARProposalsTableName,
                                              TableName.ARProposalItemWorksTableName,
                                              BOSList<ARProposalItemWorksInfo>.cstRelationForeign);
            ARProposalItemWorkAssetList.ItemTableForeignKey = "FK_ARProposalID";

            ARProposalItemCostList.InitBOSList(this,
                                              TableName.ARProposalsTableName,
                                              TableName.ARProposalItemWorksTableName,
                                              BOSList<ARProposalItemWorksInfo>.cstRelationForeign);
            ARProposalItemCostList.ItemTableForeignKey = "FK_ARProposalID";

            ARProposalItemWorkExternalList.InitBOSList(this,
                                              TableName.ARProposalsTableName,
                                              TableName.ARProposalItemWorksTableName,
                                              BOSList<ARProposalItemWorksInfo>.cstRelationForeign);
            ARProposalItemWorkExternalList.ItemTableForeignKey = "FK_ARProposalID";
            ARProposalItemWorkTasksList.InitBOSList(this,
                                                    TableName.ARProposalsTableName,
                                                    TableName.ARProposalItemWorkTasksTableName,
                                                     BOSList<ARProposalItemWorkTasksInfo>.cstRelationForeign);
            ARProposalItemWorkTasksList.ItemTableForeignKey = "FK_ARProposalID";
            ARProposalPaymentTimesList.InitBOSList(
                                              this,
                                              TableName.ARProposalsTableName,
                                              TableName.ARProposalPaymentTimesTableName,
                                              BOSList<ARSaleOrderPaymentTimesInfo>.cstRelationForeign);
            ARProposalPaymentTimesList.ItemTableForeignKey = "FK_ARProposalID";

            TemplateItemList.InitBOSList(this,
                                            TableName.ARProposalsTableName,
                                            TableName.ARProposalTemplateItemsTableName,
                                            BOSList<PMTemplateItemsInfo>.cstRelationForeign);
            TemplateItemList.ItemTableForeignKey = "FK_ARProposalID";

            ProposalAreasList.InitBOSList(this,
                                            TableName.ARProposalsTableName,
                                            "ARProposalAreas",
                                            BOSList<ARProposalAreasInfo>.cstRelationForeign);
            ProposalAreasList.ItemTableForeignKey = "FK_ARProposalID";
        }

        public override void InitGridControlInBOSList()
        {
            ARProposalItemsList.InitBOSListGridControl(ProposalModule.ARProposalItemsGridControlName);

            ARProposalItemWorkList.InitBOSListGridControl(ProposalModule.ARProposalItemWorksGridControlName);

            ARProposalItemWorkMaterialList.InitBOSListGridControl(ProposalModule.ARProposalItemWorkMaterialsGridControlName);

            ARProposalItemWorkAssetList.InitBOSListGridControl(ProposalModule.ARProposalItemWorkAssetsGridControlName);

            ARProposalItemCostList.InitBOSListGridControl(ProposalModule.ARProposalItemCostsGridControlName);

            ARProposalItemWorkTasksList.InitBOSListGridControl(ProposalModule.ARProposalItemWorkTasksGridControlName);

            ARProposalPaymentTimesList.InitBOSListGridControl(ProposalModule.ARProposalPaymentTimesGridControlName);

            TemplateItemList.InitBOSTreeListControl(ProposalModule.ARProposalTemplateItemsInfosTreeListControlName);

            ProposalAreasList.InitBOSListGridControl("fld_dgcARProposalAreasGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            ARProposalItemsList.SetDefaultListAndRefreshGridControl();
            ARProposalItemWorkList.SetDefaultListAndRefreshGridControl();
            ARProposalItemWorkMaterialList.SetDefaultListAndRefreshGridControl();
            ARProposalItemWorkAssetList.SetDefaultListAndRefreshGridControl();
            ARProposalItemCostList.SetDefaultListAndRefreshGridControl();
            ARProposalItemWorkExternalList.SetDefaultListAndRefreshGridControl();
            ARProposalItemWorkTasksList.SetDefaultListAndRefreshGridControl();
            ARProposalPaymentTimesList.SetDefaultListAndRefreshGridControl();
            TemplateItemList.SetDefaultListAndRefreshTreeListControl();
            ProposalAreasList.SetDefaultListAndRefreshGridControl();
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)MainObject;
            objProposalsInfo.ARProposalDate = BOSApp.GetCurrentServerDate();
            objProposalsInfo.ARProposalDeliveryDate = BOSApp.GetCurrentServerDate();
            objProposalsInfo.ARProposalValidateDate = BOSApp.GetCurrentServerDate().AddDays(30);
            objProposalsInfo.ARProposalStatus = ProposalStatus.New.ToString();
            objProposalsInfo.FK_ARPriceLevelID = 1;
            objProposalsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objProposalsInfo.ARProposalQuotationType = ProposalQuotationType.Official.ToString();
            objProposalsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objProposalsInfo.FK_GECurrencyID = GECurrencyID.VND;
            objProposalsInfo.ARProposalExchangeRate = 1;
            objProposalsInfo.FK_GECurrencyID2 = GECurrencyID.USD;
            objProposalsInfo.ARProposalExchangeRate2 = BOSApp.RealTimeExchageRateByCurrencyAndDate(objProposalsInfo.FK_GECurrencyID2, BOSApp.GetCurrentServerDate());
            objProposalsInfo.ARProposalSourceSellingPriceMethod = SourceSellingPriceMethod.Config.ToString();
            objProposalsInfo.ARProposalDesc = new byte[0];
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            List<ARProposalItemsInfo> proposalItemsList = objProposalItemsController.InvalidateModuleObject(iObjectID);
            ARProposalItemsList.Invalidate(proposalItemsList);
            foreach (ARProposalItemsInfo entItem in ARProposalItemsList)
                entItem.ARProposalItemProductQtyRemained = entItem.ARProposalItemProductQty - entItem.ARProposalItemProductQtyOld;
            ARProposalPaymentTimesList.Invalidate(iObjectID);

            ARProposalItemWorksController objProposalItemWorksController = new ARProposalItemWorksController();
            List<ARProposalItemWorksInfo> proposalItemWorks = objProposalItemWorksController.GetItemWorksByProposalID(iObjectID);
            ARProposalItemWorkList.Invalidate(proposalItemWorks.Where(o => o.ARProposalItemWorkProductType != ProductItemType.Material.ToString()
                                                                        && o.ARProposalItemWorkProductType != ProductItemType.Asset.ToString()
                                                                        && o.ARProposalItemWorkProductType != ProductItemType.Service.ToString()).ToList());
            ARProposalItemWorkMaterialList.Invalidate(proposalItemWorks.Where(o => o.ARProposalItemWorkProductType == ProductItemType.Material.ToString()).ToList());
            ARProposalItemWorkList.ForEach(o =>
            {
                if (o.ARProposalItemWorkMaterialList == null)
                {
                    o.ARProposalItemWorkMaterialList = new BOSList<ARProposalItemWorksInfo>();
                    o.ARProposalItemWorkMaterialList.InitBOSList(this,
                                                  TableName.ARProposalItemWorksTableName,
                                                  TableName.ARProposalItemWorksTableName,
                                                  BOSList<ARProposalItemWorksInfo>.cstRelationParent);
                }

                foreach (ARProposalItemWorksInfo work in ARProposalItemWorkMaterialList)
                {
                    if (work.ARProposalItemWorkParentID == o.ARProposalItemWorkID)
                    {
                        o.ARProposalItemWorkMaterialList.Add(work);
                    }
                }
                //o.ARProposalItemWorkMaterialList.Invalidate(ARProposalItemWorkMaterialList.Where(s => s.ARProposalItemWorkParentID == o.ARProposalItemWorkID).ToList());
            });

            ARProposalItemWorkAssetList.Invalidate(proposalItemWorks.Where(o => o.ARProposalItemWorkProductType == ProductItemType.Asset.ToString()).ToList());
            ARProposalItemWorkList.ForEach(o =>
            {
                if (o.ARProposalItemWorkAssetList == null)
                {
                    o.ARProposalItemWorkAssetList = new BOSList<ARProposalItemWorksInfo>();
                    o.ARProposalItemWorkAssetList.InitBOSList(this,
                                                  TableName.ARProposalItemWorksTableName,
                                                  TableName.ARProposalItemWorksTableName,
                                                  BOSList<ARProposalItemWorksInfo>.cstRelationParent);
                }
                //o.ARProposalItemWorkAssetList.Invalidate(ARProposalItemWorkAssetList.Where(s => s.ARProposalItemWorkParentID == o.ARProposalItemWorkID).ToList());
                foreach (ARProposalItemWorksInfo work in ARProposalItemWorkAssetList)
                {
                    if (work.ARProposalItemWorkParentID == o.ARProposalItemWorkID)
                    {
                        o.ARProposalItemWorkAssetList.Add(work);
                    }
                }
            });

            List<ARProposalItemWorksInfo> blankList = new List<ARProposalItemWorksInfo>();
            ARProposalItemCostList.Invalidate(proposalItemWorks.Where(o => o.ARProposalItemWorkProductType == ProductItemType.Service.ToString()).ToList());
            //ARProposalItemCostList.Invalidate(blankList);
            ARProposalItemCostList.AddRange(ARProposalItemWorkList.Where(o => o.ARProposalItemWorkProductChargeCheck).ToList());
            ARProposalItemCostList.AddRange(ARProposalItemWorkMaterialList.Where(o => o.ARProposalItemWorkProductChargeCheck).ToList());
            ARProposalItemCostList.AddRange(ARProposalItemWorkAssetList.Where(o => o.ARProposalItemWorkProductChargeCheck).ToList());
            ARProposalItemCostList.GridControl?.RefreshDataSource();
            ARProposalItemWorkTasksList.Invalidate(iObjectID);

            InvalidProposalAreas();
        }
        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ARProposalsInfo proposal = (ARProposalsInfo)MainObject;
            ARProposalItemsList.SaveItemObjects();

            ARProposalItemWorkList.SaveItemObjects();
            ARProposalItemWorkList.ForEach(t =>
            {

                if (t.ARProposalItemWorkMaterialList != null)
                {
                    t.ARProposalItemWorkMaterialList.All(
                        item =>
                        {
                            item.FK_ARProposalID = t.FK_ARProposalID;
                            item.ARProposalItemWorkParentID = t.ARProposalItemWorkID;
                            return true;
                        }

                        );

                }

                if (t.ARProposalItemWorkAssetList != null)
                {
                    t.ARProposalItemWorkAssetList.All(
                        item =>
                        {
                            item.FK_ARProposalID = t.FK_ARProposalID;
                            item.ARProposalItemWorkParentID = t.ARProposalItemWorkID;
                            return true;
                        }
                        );
                }
            });

            ARProposalItemWorkMaterialList.SaveItemObjects();
            ARProposalItemWorkAssetList.SaveItemObjects();

            ARProposalItemWorkExternalList.ForEach(o => o.FK_ARProposalID = ((ARProposalsInfo)MainObject).ARProposalID);
            ARProposalItemWorkExternalList.SaveItemObjects();
            ARProposalItemCostList.ForEach(o =>
            {
                o.FK_ARProposalID = ((ARProposalsInfo)MainObject).ARProposalID;
            });

            ARProposalItemCostList.SaveItemObjects();
            ARProposalItemWorkTasksList.ForEach(o => o.FK_ARProposalID = ((ARProposalsInfo)MainObject).ARProposalID);
            ARProposalItemWorkTasksList.SaveItemObjects();
            ARProposalPaymentTimesList.SaveItemObjects();
            TemplateItemList.SaveItemObjects();

            ProposalAreasList.ForEach(o =>
            {
                o.FK_ARProposalID = proposal.ARProposalID;
                if (o.FK_ARProposalItemID == 0)
                    o.FK_ARProposalItemID = ARProposalItemsList.Where(i => i.ARProposalItemTempID == o.ARProposalItemTempID).Select(i => i.ARProposalItemID).FirstOrDefault();
            });
            ProposalAreasList.SaveItemObjects();
            ARProposalAreaItemsController pimController = new ARProposalAreaItemsController();
            List<ARProposalAreaItemsInfo> pimList = pimController.GetProposalAreaItemByProposalID(proposal.ARProposalID);
            List<int> existIdList = new List<int>();
            ProposalAreasList.ForEach(o =>
            {
                if (o.ItemList != null && o.ItemList.Count() > 0)
                {
                    foreach (ARProposalAreaItemsInfo m in o.ItemList)
                    {
                        m.FK_ARProposalAreaID = o.ARProposalAreaID;
                        if (m.ARProposalAreaItemID == 0)
                        {
                            pimController.CreateObject(m);
                        }
                        else
                        {
                            pimController.UpdateObject(m);
                        }
                        existIdList.Add(m.ARProposalAreaItemID);
                    }
                    foreach (ARProposalAreaItemsInfo pim in pimList)
                    {
                        if (!existIdList.Contains(pim.ARProposalAreaItemID))
                        {
                            pimController.DeleteObject(pim.ARProposalAreaItemID);
                        }
                    }
                }
            });
        }

        public override int SaveMainObject()
        {
            ARProposalItemsList.EndCurrentEdit();
            UpdateTotalAmount();
            return base.SaveMainObject();
        }
        #endregion

        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of proposal
            ((ARProposalsInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price basing on price level
            foreach (ARProposalItemsInfo entItem in ARProposalItemsList)
                SetProductPrice(entItem, TableName.ARProposalItemsTableName);
            ARProposalItemsList.GridControl?.RefreshDataSource();
            ARProposalItemWorkList.GridControl?.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
            {
                ARProposalsInfo objProposalsInfo = (ARProposalsInfo)MainObject;
                ARProposalItemsList.GridControl?.RefreshDataSource();
                objProposalsInfo.ARProposalNetAmount = 0;
                objProposalsInfo.ARProposalTaxAmount = 0;
                objProposalsInfo.ARProposalSubTotalAmount = 0;
                objProposalsInfo.ARProposalTotalCost = ARProposalItemCostList.Where(o => o.ARProposalItemWorkProductChargeCheck)
                                                                                  .Sum(o => o.ARProposalItemWorkTotalAmount);
                ARProposalItemsList.ForEach(o =>
                {
                    objProposalsInfo.ARProposalNetAmount += o.ARProposalItemNetAmount;
                    objProposalsInfo.ARProposalSubTotalAmount += o.ARProposalItemTotalAmount;
                });

                objProposalsInfo.ARProposalSOCommissionAmount = (objProposalsInfo.ARProposalSubTotalAmount - objProposalsInfo.ARProposalDiscountFix) * objProposalsInfo.ARProposalSOCommissionPercent / 100;
                BOSApp.RoundByCurrency(objProposalsInfo, "ARProposalSOCommissionAmount", objProposalsInfo.FK_GECurrencyID);
                objProposalsInfo.ARProposalDiscountFix = objProposalsInfo.ARProposalSubTotalAmount * objProposalsInfo.ARProposalDiscountPerCent / 100;
                BOSApp.RoundByCurrency(objProposalsInfo, "ARProposalDiscountFix", objProposalsInfo.FK_GECurrencyID);
                objProposalsInfo.ARProposalTaxAmount = (objProposalsInfo.ARProposalSubTotalAmount + objProposalsInfo.ARProposalTotalCost - objProposalsInfo.ARProposalDiscountFix) * objProposalsInfo.ARProposalTaxPercent / 100;
                BOSApp.RoundByCurrency(objProposalsInfo, "ARProposalTaxAmount", objProposalsInfo.FK_GECurrencyID);
                objProposalsInfo.ARProposalTotalAmount = objProposalsInfo.ARProposalSubTotalAmount + objProposalsInfo.ARProposalTotalCost + objProposalsInfo.ARProposalTaxAmount - objProposalsInfo.ARProposalDiscountFix;
                BOSApp.RoundByCurrency(objProposalsInfo, "ARProposalTotalAmount", objProposalsInfo.FK_GECurrencyID);
                ARProposalPaymentTimesList.ForEach(p =>
                    {
                        p.ARProposalPaymentTimeAmount = objProposalsInfo.ARProposalTotalAmount * p.ARProposalPaymentTimePaymentTermItemPercentPayment / 100;
                    });
                foreach (ARProposalItemsInfo objProposalItemsInfo in ARProposalItemsList)
                {
                    objProposalItemsInfo.ARProposalItemTotalAmount2 = objProposalItemsInfo.ARProposalItemProductUnitPrice2 * objProposalItemsInfo.ARProposalItemProductQty;
                    BOSApp.RoundByCurrency(objProposalItemsInfo, "ARProposalItemTotalAmount2", objProposalsInfo.FK_GECurrencyID2);
                }
                ARProposalPaymentTimesList.GridControl?.RefreshDataSource();
                UpdateMainObjectBindingSource();
            }
        }

        public bool ApproveProposal()
        {
            SetPropertyChangeEventLock(false);
            SaveModuleObjects();
            ARProposalsInfo objARProposalsInfo = (ARProposalsInfo)MainObject;
            objARProposalsInfo.ARProposalStatus = ProposalStatus.Approved.ToString();
            UpdateMainObject();
            return true;
        }
        public override bool CancelCompleteTransaction()
        {
            ARProposalsInfo objARProposalsInfo = (ARProposalsInfo)MainObject;
            objARProposalsInfo.ARProposalStatus = InvoiceStatus.New.ToString();
            UpdateMainObject();
            return true;
        }
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ARProposalsInfo objARProposalsInfo = (ARProposalsInfo)MainObject;
                ARProposalsController objProposalsController = new ARProposalsController();
                objProposalsController.DeleteObject(iObjectID);
                ARProposalItemsList.DeleteItemObjects();
                ARProposalPaymentTimesList.DeleteItemObjects();
                ARProposalItemWorksController objProposalItemWorksController = new ARProposalItemWorksController();
                objProposalItemWorksController.DeleteProposalItemWorksByParentID(iObjectID);
                ARProposalItemWorkMaterialList.DeleteItemObjects();
                ARProposalItemWorkAssetList.DeleteItemObjects();
                ARProposalItemCostList.DeleteItemObjects();
                ARProposalItemWorkTasksList.Invalidate(iObjectID);
            }
        }
        public override void SetProductPrice(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));

            String columnName = mainTableName.Substring(0, mainTableName.Length - 1) + "Date";
            DateTime date = Convert.ToDateTime(dbUtil.GetPropertyValue(MainObject, columnName));

            //Get Item Qty
            columnName = itemTablePrefix + "FormulaPriceConfigQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            if (qty == 0)
            {
                qty = 1;
                dbUtil.SetPropertyValue(item, columnName, (decimal)1);
            }

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Unit Price
            columnName = itemTablePrefix + "ProductUnitPrice";
            int measureUnitID = dbUtil.GetPropertyIntValue(item, "FK_ICMeasureUnitID");
            decimal unitPrice = CalculateProductPrice(productID, measureUnitID);
            dbUtil.SetPropertyValue(item, columnName, unitPrice);

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Set Item Discount Amount                
            decimal discountAmount = CalculateItemDiscountAmount(item, productID, unitPrice, date, qty);
            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(item, columnName, discountAmount);

            //Set item discount percent
            decimal discountPercent = 0;
            if (extPrice != 0)
            {
                discountPercent = discountAmount / extPrice * 100;
            }
            columnName = itemTablePrefix + "DiscountFix";
            dbUtil.SetPropertyValue(item, columnName, discountPercent);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
            dbUtil.SetPropertyValue(item, columnName, taxAmount);

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //Set Item Total Amount2
            string unitPrice2ColumnName = itemTablePrefix + "ProductUnitPrice2";
            decimal unitPrice2 = Convert.ToDecimal(dbUtil.GetPropertyValue(item, unitPrice2ColumnName));

            columnName = itemTablePrefix + "TotalAmount2";
            dbUtil.SetPropertyValue(item, columnName, unitPrice2 * qty);
        }

        public override void SetDefaultValuesFromObject(ACObjectsInfo obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentMethodCombo", mainTableName.Substring(0, 2)), obj.ACObjectPaymentMethodCombo);
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentTerm", mainTablePrefix), obj.ACObjectPaymentTerm);
            if (obj.GECurrencyID != null && obj.GECurrencyID > 0)
                dbUtil.SetPropertyValue(MainObject, "FK_GECurrencyID", obj.GECurrencyID);
            else
                dbUtil.SetPropertyValue(MainObject, "FK_GECurrencyID", GECurrencyID.VND);

            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                //Copy addresses
                if (prop.Name.Contains("Address"))
                {
                    dbUtil.SetPropertyValue(MainObject, String.Format("{0}{1}", mainTablePrefix, prop.Name.Substring(10)), prop.GetValue(obj, null));
                }

                //Copy sale order contact
                if (prop.Name.Contains("Contact"))
                {
                    dbUtil.SetPropertyValue(MainObject, string.Format("{0}SO{1}", mainTablePrefix, prop.Name.Substring(10)), prop.GetValue(obj, null));
                }
            }
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)MainObject;
            ICProductsController objProductAttributesController = new ICProductsController();
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(a => a.ICProductID == iICProductID);
            if (objProductsInfo != null)
            {
                ARProposalItemsInfo objProposalItemsInfo = (ARProposalItemsInfo)ModuleObjects[ProposalEntities.strARProposalItemsObjectName];
                objProposalItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objProposalItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                objProposalItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                objProposalItemsInfo.FK_ICStockID = objProposalsInfo.FK_ICStockID;
                objProposalItemsInfo.ARProposalItemProductAttribute = objProductsInfo.ICProductAttribute;
                objProposalItemsInfo.ARProposalItemProductSerialNo = objProductsInfo.ICProductBarCode;
                objProposalItemsInfo.ARProposalItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                //objProposalItemsInfo.ARProposalItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                if (objProposalItemsInfo.ARProposalItemProductUnitPrice > 0 && objProposalItemsInfo.ICProductUnitPrice == 0)
                    objProposalItemsInfo.ICProductUnitPrice = objProposalItemsInfo.ARProposalItemProductUnitPrice;
                if (objProposalsInfo.ARProposalSaleType == SaleType.International.ToString())
                {
                    objProposalItemsInfo.ARProposalItemTotalAmount2 = objProposalItemsInfo.ARProposalItemPrice * objProposalsInfo.ARProposalExchangeRate / objProposalsInfo.ARProposalExchangeRate2;
                }
                objProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                UpdateModuleObjectBindingSource(ProposalEntities.strARProposalItemsObjectName);
            }
        }

        public override void SetProductPriceByProductUnitPrice(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);
            //Math Round Start
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            unitPrice = Math.Round(unitPrice, decimalNumber);
            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Math Round Qty
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                {
                    qty = Math.Round(qty, 4, MidpointRounding.AwayFromZero);
                }
                else
                {
                    qty = Math.Round(qty, 3, MidpointRounding.AwayFromZero);
                }
            }
            //End

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            unitCost = Math.Round(unitCost, decimalNumber);

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
            string discountPercentColumnName = itemTablePrefix + "DiscountFix";
            string discountAmountColumnName = itemTablePrefix + "DiscountAmount";

            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountPercentColumnName));

            decimal discountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountAmountColumnName));
            discountAmount = Math.Round(discountAmount, decimalNumber);

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

            //Set Item Total Amount2
            string unitPrice2ColumnName = itemTablePrefix + "ProductUnitPrice2";
            decimal unitPrice2 = Convert.ToDecimal(dbUtil.GetPropertyValue(item, unitPrice2ColumnName));

            columnName = itemTablePrefix + "TotalAmount2";
            dbUtil.SetPropertyValue(item, columnName, unitPrice2 * qty);

            RoundByCurrency(item as ARProposalItemsInfo);

            item.OldObject = (BusinessObject)item.Clone();
        }

        public override void DuplicateModuleObjectList()
        {
            ARProposalItemsList.Duplicate();
            foreach (ARProposalItemsInfo item in ARProposalItemsList)
            {
                item.ARProposalItemProductQtyRemained = item.ARProposalItemProductQty;
                item.ARProposalItemProductQtyOld = 0;
                //Update all item price basing on price level
                //SetProductPrice(item, ProposalEntities.strARProposalItemsObjectName);
                //item.ICProductUnitPrice = item.ARProposalItemProductUnitPrice;
                //item.ARProposalItemProductInternalUnitPrice = item.ARProposalItemProductUnitPrice; 
                //item.ICProductUnitPrice = item.ARProposalItemProductUnitPrice; 
            }
            ARProposalItemCostList.Duplicate();
            foreach (ARProposalItemsInfo item in ARProposalItemsList)
            {
                item.ARProposalItemProductQtyRemained = item.ARProposalItemProductQty;
                item.ARProposalItemProductQtyOld = 0;
            }
            ARProposalItemCostList.ForEach(p =>
                {
                    p.ARProposalItemWorkID = 0;
                    p.FK_ARProposalID = 0;
                });
        }

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
            objCustomersInfo.ARCustomerCRMType = CustomerCRMType.Prospect.ToString();
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

            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)MainObject;
            objProposalsInfo.CustomersInfo = objCustomersInfo;
        }

        public void GenerateProposaleItemsFromPriceSheetItems(List<ARPriceSheetItemsInfo> result)
        {
            result.ForEach(o =>
                {
                    ARProposalItemsList.Add(ToProposalItems(o));
                });
        }

        private ARProposalItemsInfo ToProposalItems(ARPriceSheetItemsInfo objPriceSheetItemsInfo)
        {
            ARProposalItemsInfo objProposalItemsInfo = new ARProposalItemsInfo();
            objProposalItemsInfo.FK_ICProductID = objPriceSheetItemsInfo.FK_ICProductID;
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(objProposalItemsInfo.FK_ICProductID);
            objProposalItemsInfo.ARProposalItemProductName = objPriceSheetItemsInfo.ARPriceSheetItemProductName;
            objProposalItemsInfo.ARProposalItemProductNo = objPriceSheetItemsInfo.ARPriceSheetItemProductNo;
            objProposalItemsInfo.ARProposalItemProductDesc = objPriceSheetItemsInfo.ARPriceSheetItemProductDesc;
            objProposalItemsInfo.ARProposalItemDesc = objPriceSheetItemsInfo.ARPriceSheetItemCommand;
            objProposalItemsInfo.ARProposalItemProductCustomerNumber = objPriceSheetItemsInfo.ARPriceSheetItemProductCustomerNumber;

            objProposalItemsInfo.ARProposalItemHeight = objPriceSheetItemsInfo.ARPriceSheetItemProductHeight;
            objProposalItemsInfo.ARProposalItemLength = objPriceSheetItemsInfo.ARPriceSheetItemProductLength;
            objProposalItemsInfo.ARProposalItemWidth = objPriceSheetItemsInfo.ARPriceSheetItemProductWidth;

            objProposalItemsInfo.ARProposalItemTotalAmount = objPriceSheetItemsInfo.ARPriceSheetItemTotalAmount;
            objProposalItemsInfo.ARProposalItemProductUnitPrice = objPriceSheetItemsInfo.ARPriceSheetItemPrice;
            objProposalItemsInfo.FK_ICMeasureUnitID = objPriceSheetItemsInfo.FK_ICMeasureUnitID;
            objProposalItemsInfo.ARProposalItemInternalPrice = objPriceSheetItemsInfo.ARPriceSheetItemPrice;
            objProposalItemsInfo.ARProposalItemProductQty = objPriceSheetItemsInfo.ARPriceSheetItemQty;

            objProposalItemsInfo.FK_ARPriceSheetItemID = objPriceSheetItemsInfo.ARPriceSheetItemID;
            objProposalItemsInfo.FK_ARPriceSheetID = objPriceSheetItemsInfo.FK_ARPriceSheetID;

            objProposalItemsInfo.ARProposalItemPrice = objProposalItemsInfo.ARProposalItemProductUnitPrice * objProposalItemsInfo.ARProposalItemProductQty;
            objProposalItemsInfo.ARProposalItemDiscountFix = objPriceSheetItemsInfo.ARPriceSheetItemDiscountPercent;
            objProposalItemsInfo.ARProposalItemDiscountAmount = objPriceSheetItemsInfo.ARPriceSheetItemDiscountAmount;
            objProposalItemsInfo.ARProposalItemProductTaxPercent = objPriceSheetItemsInfo.ARPriceSheetItemTaxPercent;
            objProposalItemsInfo.ARProposalItemTaxAmount = objPriceSheetItemsInfo.ARPriceSheetItemTaxAmount;

            ICProductsController objProductsController = new ICProductsController();
            objProposalItemsInfo.FK_ICProductGroupID = objProductsController.GetProductGroupByProductID(objPriceSheetItemsInfo.FK_ICProductID);
            objProposalItemsInfo.ARPriceSheetNo = objPriceSheetItemsInfo.ARPriceSheetNo;

            objProposalItemsInfo.FK_ICDepartmentID = objPriceSheetItemsInfo.ICDepartmentID;
            if (objProductsInfo != null)
            {
                objProposalItemsInfo.ARProposalItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
            }    

            return objProposalItemsInfo;
        }

        public void GenerateProposaleItemWorksFromPriceSheetItemWorks(List<ARPriceSheetItemWorksInfo> result)
        {
            result.ForEach(o =>
            {
                ARProposalItemCostList.Add(ToProposalItemWorks(o));
            });
        }

        private ARProposalItemWorksInfo ToProposalItemWorks(ARPriceSheetItemWorksInfo objPriceSheetItemWorksInfo)
        {
            ARProposalItemWorksInfo objProposalItemWorksInfo = new ARProposalItemWorksInfo();
            objProposalItemWorksInfo.FK_ICProductID = objPriceSheetItemWorksInfo.FK_ICProductID;
            objProposalItemWorksInfo.FK_ICProductGroupID = objPriceSheetItemWorksInfo.FK_ICProductGroupID;
            objProposalItemWorksInfo.FK_ICDepartmentID = objPriceSheetItemWorksInfo.FK_ICDepartmentID;
            objProposalItemWorksInfo.FK_ICMeasureUnitID = objPriceSheetItemWorksInfo.FK_ICMeasureUnitID;
            objProposalItemWorksInfo.ARProposalItemWorkProductNo = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductNo;
            objProposalItemWorksInfo.ARProposalItemWorkProductName = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductName;
            objProposalItemWorksInfo.ARProposalItemWorkProductDesc = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductDesc;
            objProposalItemWorksInfo.ARProposalItemWorkProductQty = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductQty;
            objProposalItemWorksInfo.ARProposalItemWorkProductUnitPrice = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductUnitPrice;
            objProposalItemWorksInfo.ARProposalItemWorkTotalAmount = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkTotalAmount;
            objProposalItemWorksInfo.ARProposalItemWorkProductChargeCheck = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductChargeCheck;
            objProposalItemWorksInfo.ARProposalItemWorkStatus = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkStatus;
            objProposalItemWorksInfo.ARProposalItemWorkType = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkType;
            objProposalItemWorksInfo.ARProposalItemWorkProductType = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkProductType;
            objProposalItemWorksInfo.ARProposalItemWorkComment = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkComment;
            objProposalItemWorksInfo.ARProposalItemWorkDiscountAmount = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkDiscountAmount;
            objProposalItemWorksInfo.ARProposalItemWorkDiscountPerCent = objPriceSheetItemWorksInfo.ARPriceSheetItemWorkDiscountPerCent;

            return objProposalItemWorksInfo;
        }

        public void GenerateTemplateItemsSection(List<ICProductsInfo> products, ARProposalTemplateItemsInfo objTemplateItemsInfoParent, string productType)
        {
            ARProposalsInfo mainObject = (ARProposalsInfo)MainObject;
            ARProposalTemplateItemsController objTemplateItemsController = new ARProposalTemplateItemsController();
            products.ForEach(o =>
            {
                ARProposalTemplateItemsInfo objTemplateItemsInfo = ToTemplateItemsInfoSection(o, objTemplateItemsInfoParent, productType);
                int templateItemID = objTemplateItemsController.CreateObject(objTemplateItemsInfo);
                if (templateItemID > 0)
                    TemplateItemList.Add(objTemplateItemsInfo);
            });
        }

        public ARProposalTemplateItemsInfo ToTemplateItemsInfoSection(ICProductsInfo objProductsInfo, ARProposalTemplateItemsInfo objTemplateItemsInfoParent, string productType)
        {
            ARProposalsInfo mainObject = (ARProposalsInfo)MainObject;
            ARProposalTemplateItemsInfo objTemplateItemsInfo = new ARProposalTemplateItemsInfo();
            objTemplateItemsInfo.FK_PMTemplateID = mainObject.FK_PMTemplateID;
            objTemplateItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objTemplateItemsInfo.FK_ARProposalID = mainObject.ARProposalID;
            objTemplateItemsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
            objTemplateItemsInfo.ARProposalTemplateItemProductNo = objProductsInfo.ICProductNo;
            //objTemplateItemsInfo.ARProposalTemplateItemProductNo =
            //    productType == TemplateItemType.Section.ToString() ?
            //    string.Join(string.Empty, new string[] { ProposalModule.PrefixSection, objProductsInfo.ICProductNo }) :
            //    string.Join(string.Empty, new string[] { ProposalModule.PrefixWork, objProductsInfo.ICProductNo });
            objTemplateItemsInfo.ARProposalTemplateItemProductName = objProductsInfo.ICProductName;
            objTemplateItemsInfo.ARProposalTemplateItemProductDesc = objProductsInfo.ICProductDesc;
            objTemplateItemsInfo.ARProposalTemplateItemProductQty = 1;
            objTemplateItemsInfo.ARProposalTemplateItemProductNetWeight = 1;
            objTemplateItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objTemplateItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objTemplateItemsInfo.FK_ICProductWorkGroupID = objProductsInfo.FK_ICProductWorkGroupID;
            objTemplateItemsInfo.FK_ICProductWorkGroupParentID = 0;
            objTemplateItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objTemplateItemsInfo.ARProposalTemplateItemType = productType == TemplateItemType.Section.ToString() ? TemplateItemType.Section.ToString() : TemplateItemType.Work.ToString();
            objTemplateItemsInfo.ARProposalTemplateItemWorkType = string.IsNullOrEmpty(objProductsInfo.ICProductWorkType) ? TemplateItemWorkType.Work.ToString() : objProductsInfo.ICProductWorkType;
            objTemplateItemsInfo.ARProposalTemplateItemParentID = objTemplateItemsInfoParent == null ? 0 : objTemplateItemsInfoParent.ARProposalTemplateItemID;
            if (objTemplateItemsInfo.SubList == null)
                objTemplateItemsInfo.SubList = new BOSTreeList();

            return objTemplateItemsInfo;
        }

        private void InvalidProposalAreas()
        {
            ARProposalsInfo mainObject = (ARProposalsInfo)MainObject;

            ARProposalAreasController controller = new ARProposalAreasController();
            List<ARProposalAreasInfo> areas = controller.GetProposalAreasByProposalID(mainObject.ARProposalID);

            ARProposalAreaItemsController itemCtrl = new ARProposalAreaItemsController();
            List<ARProposalAreaItemsInfo> itemList = itemCtrl.GetProposalAreaItemByProposalID(mainObject.ARProposalID);

            areas.ForEach(btp =>
            {
                btp.ItemList = new BindingList<ARProposalAreaItemsInfo>();
                itemList.ForEach(m =>
                {
                    if (m.FK_ARProposalAreaID == btp.ARProposalAreaID)
                    {
                        btp.ItemList.Add(m);
                    }
                });
            });

            ProposalAreasList.Invalidate(areas);
            //ProposalAreasList.GridControl?.RefreshDataSource();
        }
        public void RoundByCurrency(BusinessObject obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)MainObject;
            GECurrenciesController currencyController = new GECurrenciesController();
            GETablesController tableController = new GETablesController();
            List<GECurrenciesInfo> listCrr = new List<GECurrenciesInfo>();
            DataSet ds;
            GECurrenciesInfo currency1 = new GECurrenciesInfo();
            GECurrenciesInfo currency2 = new GECurrenciesInfo();
            if (BOSApp.LookupTables.ContainsKey("GECurrencies"))
            {
                ds = (DataSet)BOSApp.LookupTables["GECurrencies"];
                if (ds != null && ds.Tables.Count > 0)
                {
                    listCrr = currencyController.GetListDataSet(ds);
                    if (listCrr != null)
                    {
                        currency1 = listCrr.Where(x => x.GECurrencyID == objProposalsInfo.FK_GECurrencyID).FirstOrDefault();
                        currency2 = listCrr.Where(x => x.GECurrencyID == objProposalsInfo.FK_GECurrencyID2).FirstOrDefault();
                    }
                    ds.Dispose();
                }

            }
            if (obj != null)
            {
                string tableName = BOSUtil.GetTableNameFromBusinessObject(obj);
                List<GETablesInfo> tables = tableController.GetColumnNamesByTableName(tableName);

                if (tables != null)
                {
                    foreach (GETablesInfo table in tables)
                    {
                        if (table.ColumnName != "ICProductUnitPrice" && table.ColumnName != "ARProposalItemDiscountFix")
                        {
                            if (table.ColumnName == "ARProposalItemProductUnitPrice2" || table.ColumnName == "ARProposalItemTotalAmount2")
                            {

                                if (currency2 != null && currency2.GECurrencyID > 0)
                                {
                                    object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                    decimal amount = 0;
                                    if (value != null)
                                    {
                                        amount = Convert.ToDecimal(value);
                                        amount = Math.Round(amount, currency2.GECurrencyDecimalNumber);
                                        dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                    }
                                }
                            }
                            else
                            {
                                if (table.ColumnName != "ARProposalItemProductUnitPrice")
                                {
                                    if (currency1 != null && currency1.GECurrencyID > 0)
                                    {
                                        object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                        decimal amount = 0;
                                        if (value != null)
                                        {
                                            amount = Convert.ToDecimal(value);
                                            amount = Math.Round(amount, currency1.GECurrencyDecimalNumber);
                                            dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        public decimal CalculateProductPriceBaseOnProductPriceLevelForProposal(ICProductsInfo objICProductsInfo)
        {
            return CalculateProductPriceBaseOnProductPriceLevel(objICProductsInfo);
        }

        protected override decimal CalculateProductPriceBaseOnProductPriceLevel(ICProductsInfo objICProductsInfo)
        {
            return base.CalculateProductPriceBaseOnProductPriceLevel(objICProductsInfo);
        }

        public override void SetProductPriceByProductUnitPrice()
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            if (ModuleObjects[strItemTableName] != null)
            {
                SetProductPriceByProductUnitPrice(ModuleObjects[strItemTableName]);

                //round by currency
                BOSDbUtil dbUtil = new BOSDbUtil();
                int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
                RoundByCurrency(ModuleObjects[strItemTableName]);

                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }
    }
}
