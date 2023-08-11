using BOSCommon;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostWood
{


    class ProductionCostWoodModule : BaseModuleERP
    {

        #region Constant
        public const string ApplyPriceButtonEditName = "fld_btnApplyPrice";
        public const string OverallProductionCostFor622GridControlName = "fld_dgcMMProductionCostOveralls622";
        public const string OverallProductionCostFor627GridControlName = "fld_dgcMMProductionCostOveralls627";
        #endregion

        #region Property
        MMProductionCostOverallsGridControl OverallProductionCostFor622GridControl;
        MMProductionCostOverallsGridControl OverallProductionCostFor627GridControl;
        BOSButton ApplyPriceButtonEdit;
        #endregion

        public const string TotalAmount622ControlName = "fld_txt622TotalAmount";
        public const string TotalAmount627ControlName = "fld_txt627TotalAmount";

        public BOSTextBox TotalAmount622Control = null;
        public BOSTextBox TotalAmount627Control = null;

        public ProductionCostWoodModule()
        {
            Name = "ProductionCostWood";
            CurrentModuleEntity = new ProductionCostWoodEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ApplyPriceButtonEdit = (BOSButton)Controls[ApplyPriceButtonEditName];
            ApplyPriceButtonEdit.Enabled = false;
            InitializeOverallProductionCostGridControls();
            TotalAmount622Control = (BOSTextBox)Controls[TotalAmount622ControlName];
            TotalAmount627Control = (BOSTextBox)Controls[TotalAmount627ControlName];
        }

        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            MMProductionCostsController objProductionCostsController = new MMProductionCostsController();
            MMProductionCostsInfo searchObject = (MMProductionCostsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = objProductionCostsController.GetProductionCostDataSearch(
                                                                        searchObject.MMProductionCostNo,
                                                                        ProductionCostType.ProductionCostWood.ToString(),
                                                                        searchObject.MMProductionCostFromDate,
                                                                        searchObject.MMProductionCostToDate);


            return ds;
        }

        public override void ActionNew()
        {
            base.ActionNew();

            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            objProductionCostsInfo.MMProductionCostFromDate = BOSUtil.GetMonthBeginDate();
            objProductionCostsInfo.MMProductionCostToDate = BOSUtil.GetMonthEndDate();
            objProductionCostsInfo.MMProductionCostStatus = MMProductionCostStatus.New.ToString();
            ApplyPriceButtonEdit.Enabled = true;
        }

        public override int ActionSave()
        {
            int id = base.ActionSave();
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostItemsController objProductionCostItemsController = new MMProductionCostItemsController();
            MMProductionCostIngredientCostsController objPCICC = new MMProductionCostIngredientCostsController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            dbUtil.ExecuteNonQuery("ResetAllDataByProductionCostID", id);

            BOSProgressBar.Start("Đang lưu dữ liệu");
            foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostItemID > 0)
                {
                    objProductionCostItemsController.UpdateObject(item);
                }
                else
                {
                    objProductionCostItemsController.CreateObject(item);
                }
            }

            foreach (MMProductionCostIngredientCostsInfo item in entity.ProductionCostIngredientCostList)
            {
                item.FK_MMProductionCostID = id;
                if (item.MMProductionCostIngredientCostID > 0)
                {
                    objPCICC.UpdateObject(item);
                }
                else
                {
                    objPCICC.CreateObject(item);
                }
            }
            BOSProgressBar.Close();
            return id;
        }

        private void InitializeOverallProductionCostGridControls()
        {
            OverallProductionCostFor622GridControl = (MMProductionCostOverallsGridControl)Controls[OverallProductionCostFor622GridControlName];
            OverallProductionCostFor627GridControl = (MMProductionCostOverallsGridControl)Controls[OverallProductionCostFor627GridControlName];

            BindingDataSource();
        }

        private void BindingDataSource()
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OverallProductionCostListFor622;
            OverallProductionCostFor622GridControl.DataSource = entity.OverallProductionCostListFor622;

            bds = new BindingSource();
            bds.DataSource = entity.OverallProductionCostListFor627;
            OverallProductionCostFor627GridControl.DataSource = bds;
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;
            foreach (MMProductionCostOverallsInfo item in entity.OverallProductionCostListFor622)
            {
                mainObject.DirectLaborCostFor622TotalAmount += item.MMProductionCostOverallTotalCost;
            }

            foreach (MMProductionCostOverallsInfo item in entity.OverallProductionCostListFor627)
            {
                mainObject.OverallProductionCostFor627TotalAmount += item.MMProductionCostOverallTotalCost;
            }
            TotalAmount622Control.Text = mainObject.DirectLaborCostFor622TotalAmount.ToString("N0");
            TotalAmount627Control.Text = mainObject.OverallProductionCostFor627TotalAmount.ToString("N0");
        }
        public string GetReferenceTypeText(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public void ValidateProductionCostByDate(bool isDateChange)
        {
            BOSProgressBar.Start(MESLocalizedResources.LoadingData);
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            objProductionCostsInfo.MMProductionCostStatus = MMProductionCostStatus.New.ToString();
            UpdateGiaXKGT();
            ValidateProductionCostItems(isDateChange);
            GetOverallProductionCostAmounts();
            if (isDateChange)
                ApplyPriceButtonEdit.Enabled = true;
            BOSProgressBar.Close();
        }

        public void ValidateProductionCostItems(bool isDateChange)
        {

            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            if (objProductionCostsInfo != null)
            {
                GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, isDateChange);
            }

        }



        public void UpdateGiaXKGT()
        {
            //BOSDbUtil dbUtil = new BOSDbUtil();
            //ICReceiptsController objReceiptsController = new ICReceiptsController();
            //List<ICReceiptsInfo> receiptList = objReceiptsController.GetReceiptsListForUpdate();
            //ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            //foreach (ICReceiptsInfo mainObject in receiptList)
            //{
            //    receiptItemList = objReceiptItemsController.GetItemsByReceiptID(mainObject.ICReceiptID);
            //    foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            //    {
            //        dbUtil.ExecuteNonQuery("UpdateInventoryCost", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
            //    }
            //}
        }


        public void GetProductionCostItemByDate(DateTime fromDate, DateTime toDate, bool isDateChange)
        {

            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            MMProductionCostItemsController objProductionCostItemsController = new MMProductionCostItemsController();
            List<MMProductionCostItemsInfo> productionCostItemList = new List<MMProductionCostItemsInfo>();
            productionCostItemList = objProductionCostItemsController.GetProductionCostWoodItemByDate(fromDate, toDate);
            List<MMProductionCostItemsInfo> productionCostItemListToAdd = new List<MMProductionCostItemsInfo>();
            foreach (MMProductionCostItemsInfo item in productionCostItemList)
            {
                productionCostItemListToAdd.Add(item);
            }
            if (isDateChange)
            {
                entity.ProductionCostItemList.Clear();
                entity.ProductionCostIngredientCostList.Clear();
                entity.ProductionCostItemList.AddRange(productionCostItemListToAdd);
            }
            else
            {
                entity.ProductionCostItemList.Invalidate(productionCostItemListToAdd);
            }
            entity.ProductionCostItemList.GridControl.InitGridControlDataSource();
            entity.ProductionCostItemList.GridControl?.RefreshDataSource();

            List<int> batchProductIDList = new List<int>();
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationsList = objOperationsController.GetOperationListForProductionCostWood();
            MMOperationsInfo operationCS = operationsList.FirstOrDefault(i => i.MMOperationNo == CuaXeNo);//Công đoạn cưa xẻ
            MMOperationsInfo operationS = operationsList.FirstOrDefault(i => i.MMOperationNo == SayNo);//Công đoạn sấy
            List<MMProductionCostIngredientCostsInfo> ingredientCostList = new List<MMProductionCostIngredientCostsInfo>();
            foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            {
                if (!batchProductIDList.Contains(item.FK_MMBatchProductID))
                {

                    batchProductIDList.Add(item.FK_MMBatchProductID);
                    ingredientCostList = GetIngredientCostByDateAndBatchID(fromDate, toDate, item.FK_MMBatchProductID, operationCS.MMOperationID);
                    if (ingredientCostList != null)
                    {

                        List<MMProductionCostIngredientCostsInfo> CXList = ingredientCostList.Where(t => t.FK_MMOperationID == operationCS.MMOperationID).ToList();
                        //List<MMProductionCostIngredientCostsInfo> SList = ingredientCostList.Where(t => t.FK_MMOperationID == operationS.MMOperationID).ToList();
                        if (CXList != null && CXList.Count > 0)
                        {
                            if (CXList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
                            {
                                ingredientCostList = ingredientCostList.Where(t => t.FK_MMOperationID != operationCS.MMOperationID).ToList();

                            }
                        }

                        //if (SList != null && SList.Count > 0)
                        //{
                        //    if (SList.Where(p => p.MMProductionCostIngredientCostReferenceType.Equals("2. Nhập kho")).ToList().Count == 0)
                        //    {
                        //        ingredientCostList = ingredientCostList.Where(t => t.FK_MMOperationID != operationS.MMOperationID).ToList();

                        //    }
                        //}

                        entity.ProductionCostIngredientCostList.AddRange(ingredientCostList);
                    }
                }
            }

            // Sấy
            MMProductionCostIngredientCostsController objIngredientCostsController = new MMProductionCostIngredientCostsController();
            ingredientCostList = objIngredientCostsController.GetProductionCostIngredientCostBySomeConditionsCDSay(fromDate, toDate, operationS.MMOperationID);
            entity.ProductionCostIngredientCostList.AddRange(ingredientCostList);

            entity.ProductionCostIngredientCostList.GridControl.InitGridControlDataSource();
            entity.ProductionCostIngredientCostList.GridControl?.RefreshDataSource();

            ValidateProductPriceCost(isDateChange);
        }

        public List<MMProductionCostIngredientCostsInfo> GetIngredientCostByDateAndBatchID(DateTime fromDate, DateTime toDate, int batchID, int operationID)
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostIngredientCostsController objIngredientCostsController = new MMProductionCostIngredientCostsController();
            List<MMProductionCostIngredientCostsInfo> ingredientCostList = new List<MMProductionCostIngredientCostsInfo>();

            ingredientCostList = objIngredientCostsController.GetProductionCostIngredientCostBySomeConditions(fromDate, toDate, batchID, operationID);
            return ingredientCostList;
        }

        public void ValidateProductPriceCost(bool isDateChange)
        {
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            if (objProductionCostsInfo != null)
            {
                GetProductPriceByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, isDateChange);
                GetProductPriceIncompletesByDate(objProductionCostsInfo.MMProductionCostFromDate,
                                                  objProductionCostsInfo.MMProductionCostToDate, isDateChange);
            }
        }

        public void GetProductPriceByDate(DateTime fromDate, DateTime toDate, bool isDateChange)
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            MMProductionCostsController objProductionCostsController = new MMProductionCostsController();
            MMProductPricesController objProductPricesController = new MMProductPricesController();
            List<MMProductPricesInfo> productPriceList = new List<MMProductPricesInfo>();
            MMProductPricesInfo objProductPricesInfo;
            foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            {
                objProductPricesInfo = new MMProductPricesInfo();
                objProductPricesInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                objProductPricesInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
                objProductPricesInfo.FK_ARSaleOrderItemID = item.FK_ARSaleOrderItemID;
                objProductPricesInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
                objProductPricesInfo.FK_ICProductIDForBatch = item.FK_ICProductIDForBatch;
                objProductPricesInfo.FK_MMProposalID = item.FK_MMProposalID;
                objProductPricesInfo.FK_MMProductionNormID = item.FK_MMProductionNormID;
                objProductPricesInfo.FK_ICDepartmentID = item.FK_ICDepartmentID;
                objProductPricesInfo.MMProductPriceProductSeriesNo = item.MMProductionCostItemProductSeriesNo;
                objProductPricesInfo.MMProductPriceProductQty = item.MMProductionCostItemProductQty;
                objProductPricesInfo.MMProductPriceProductCompletedQty = item.MMProductionCostItemCompletedProductQty;
                objProductPricesInfo.MMProductPriceProductDesc = item.MMProductionCostItemProductDesc;
                productPriceList.Add(objProductPricesInfo);
            }
            if (isDateChange)
            {
                entity.ProductPriceList.Clear();
                entity.ProductPriceList.AddRange(productPriceList);
            }
            else
                entity.ProductPriceList.Invalidate(productPriceList);

            entity.ProductPriceList.GridControl?.RefreshDataSource();
        }

        public void GetProductPriceIncompletesByDate(DateTime fromDate, DateTime toDate, bool isDateChange)
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;
            MMProductionCostsController objProductionCostsController = new MMProductionCostsController();
            MMProductPriceIncompletesController objProductPriceIncompletesController = new MMProductPriceIncompletesController();
            List<MMProductPriceIncompletesInfo> productPriceIncompelesList = new List<MMProductPriceIncompletesInfo>();
            MMProductPriceIncompletesInfo objProductPriceIncompletesInfo;
            foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            {
                objProductPriceIncompletesInfo = new MMProductPriceIncompletesInfo();
                objProductPriceIncompletesInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                objProductPriceIncompletesInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
                objProductPriceIncompletesInfo.FK_ARSaleOrderItemID = item.FK_ARSaleOrderItemID;
                objProductPriceIncompletesInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
                objProductPriceIncompletesInfo.FK_ICProductIDForBatch = item.FK_ICProductIDForBatch;
                objProductPriceIncompletesInfo.FK_MMProposalID = item.FK_MMProposalID;
                objProductPriceIncompletesInfo.FK_MMProductionNormID = item.FK_MMProductionNormID;
                objProductPriceIncompletesInfo.FK_ICDepartmentID = item.FK_ICDepartmentID;
                objProductPriceIncompletesInfo.MMProductPriceIncompleteProductQty = item.MMProductionCostItemProductQty - item.MMProductionCostItemCompletedProductQty;
                objProductPriceIncompletesInfo.MMProductPriceIncompleteProductDesc = item.MMProductionCostItemProductDesc;
                productPriceIncompelesList.Add(objProductPriceIncompletesInfo);
            }
            if (isDateChange)
            {
                entity.ProductPriceIncompletesList.Clear();
                entity.ProductPriceIncompletesList.AddRange(productPriceIncompelesList);
            }
            else
                entity.ProductPriceIncompletesList.Invalidate(productPriceIncompelesList);

            entity.ProductPriceIncompletesList.GridControl?.RefreshDataSource();
        }

        private decimal GetDocumentEntryAmountByAccountNo(string accountNo)
        {
            ProductionCostWoodEntities entity = CurrentModuleEntity as ProductionCostWoodEntities;
            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();
            MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;
            DateTime? fromDate = null;
            if (mainObject.MMProductionCostFromDate != DateTime.MaxValue)
                fromDate = mainObject.MMProductionCostFromDate;
            DateTime? dateTo = null;
            if (mainObject.MMProductionCostToDate != DateTime.MaxValue)
                dateTo = mainObject.MMProductionCostToDate;
            decimal amount = 0;
            amount = documentEntryController.GetDocumentEntryAmountByAccountNo(accountNo, fromDate, dateTo);

            return amount;
        }

        private void GetOverallProductionCostAmounts()
        {

            ProductionCostWoodEntities entity = CurrentModuleEntity as ProductionCostWoodEntities;
            MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;

            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();
            DateTime? fromDate = null;
            if (mainObject.MMProductionCostFromDate != DateTime.MaxValue)
                fromDate = mainObject.MMProductionCostFromDate;
            DateTime? dateTo = null;
            if (mainObject.MMProductionCostToDate != DateTime.MaxValue)
                dateTo = mainObject.MMProductionCostToDate;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();

            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationsList = objOperationsController.GetOperationListForProductionCostWood();

            string[] ChiPhiNhanCongTrucTiepList = new string[] { "6222", "6223" };
            string[] ChiPhiChungList = new string[] { "6271", "6272" };

            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo;
            MMProductionCostOverallsInfo objProductionCostOverallsInfo;

            entity.OverallProductionCostListFor622.Clear();
            entity.OverallProductionCostListFor627.Clear();
            int account = 0;
            mainObject.DirectLaborCostFor622TotalAmount = 0;
            mainObject.OverallProductionCostFor627TotalAmount = 0;
            foreach (MMOperationsInfo operation in operationsList)
            {
                // Chi phí nhân công TT từng CĐ
                objProductionCostOverallsInfo = new MMProductionCostOverallsInfo();
                objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(ChiPhiNhanCongTrucTiepList[account]);
                if (objAccountsInfo != null)
                {
                    operation.chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(ChiPhiNhanCongTrucTiepList[account]);
                    objProductionCostOverallsInfo.MMProductionCostOverallProductName = objAccountsInfo.ACAccountName;
                    objProductionCostOverallsInfo.MMProductionCostOverallTotalCost = operation.chiPhiNhanCongTT;
                    objProductionCostOverallsInfo.MMProductionCostOverallCostTypeCombo = objAccountsInfo.ACAccountNo;
                    entity.OverallProductionCostListFor622.Add(objProductionCostOverallsInfo);
                    mainObject.DirectLaborCostFor622TotalAmount += operation.chiPhiNhanCongTT;
                }
                account++;
            }
            account = 0;
            foreach (MMOperationsInfo operation in operationsList)
            {
                // Chi phí chung từng CĐ
                objProductionCostOverallsInfo = new MMProductionCostOverallsInfo();
                objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(ChiPhiChungList[account]);
                if (objAccountsInfo != null)
                {
                    operation.chiPhiNhanCongChung = GetDocumentEntryAmountByAccountNo(ChiPhiChungList[account]);
                    objProductionCostOverallsInfo.MMProductionCostOverallProductName = objAccountsInfo.ACAccountName;
                    objProductionCostOverallsInfo.MMProductionCostOverallTotalCost = operation.chiPhiNhanCongChung;
                    objProductionCostOverallsInfo.MMProductionCostOverallCostTypeCombo = objAccountsInfo.ACAccountNo;
                    entity.OverallProductionCostListFor627.Add(objProductionCostOverallsInfo);
                    mainObject.OverallProductionCostFor627TotalAmount += operation.chiPhiNhanCongChung;
                }
                account++;
            }

            InitializeOverallProductionCostGridControls();
            TotalAmount622Control.Text = mainObject.DirectLaborCostFor622TotalAmount.ToString("N0");
            TotalAmount627Control.Text = mainObject.OverallProductionCostFor627TotalAmount.ToString("N0");
        }

        public void AdjustCostOfGoodsSold()
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (var item in entity.ProductPriceList)
            {
                //dbUtil.ExecuteNonQuery("UpdateInventoryCost", item.FK_ICProductIDForBatch, item.MMProductPriceProductSeriesNo, item.MMProductPriceProductPrice);
                dbUtil.ExecuteNonQuery("UpdateInventoryCost", item.FK_ICProductIDForBatch, item.FK_ICProductSerieID, item.MMProductPriceProductPrice);

            }
            BOSProgressBar.Close();
        }

        private const string CuaXeNo = "CD-001";
        private const string SayNo = "CD-002";

        public void ApplyProductPriceNew()
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)CurrentModuleEntity.MainObject;

            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationsList = objOperationsController.GetOperationListForProductionCostWood();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            List<ICShipmentItemsInfo> shipmentItemOtherList = new List<ICShipmentItemsInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            decimal chiPhiBanDau = 0;
            BOSDbUtil dbUtil = new BOSDbUtil();

            foreach (MMOperationsInfo operation in operationsList)
            {
                if (operation.MMOperationNo == CuaXeNo)//Công đoạn cưa xẻ
                {
                    // Chi phí nhân công TT CĐ Cưa xẻ
                    operation.chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo("6222");
                    // Chi phí SX chung CĐ Cưa xẻ
                    operation.chiPhiNhanCongChung = GetDocumentEntryAmountByAccountNo("6271");
                }
                if (operation.MMOperationNo == SayNo)// Công đoạn Sấy
                {
                    // Chi phí nhân công TT CĐ Sấy
                    operation.chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo("6223");
                    // Chi  SX phí chung CĐ Sấy
                    operation.chiPhiNhanCongChung = GetDocumentEntryAmountByAccountNo("6272");
                }

            }

            ICShipmentItemsInfo objShipmentItemsInfo;
            List<int> batchLumberIDList = new List<int>();
            //  decimal totalBPQty = entity.ProductPriceList.Sum(i => i.MMProductPriceProductQty);
            Dictionary<int, decimal> chiPhiBanDauList = new Dictionary<int, decimal>();
            Dictionary<int, decimal> chiPhiList = new Dictionary<int, decimal>();
            List<int> matchID = new List<int>();
            MMOperationsInfo operationInfo;

            foreach (MMProductPricesInfo productPrice in entity.ProductPriceList)
            {

                decimal chiPhiBanDauDD = 0;
                decimal chiPhi = 0;
                if (!batchLumberIDList.Contains(productPrice.FK_MMBatchProductID))
                {
                    // decimal bPQty = entity.ProductPriceList.Where(i => i.FK_MMBatchProductID == productPrice.FK_MMBatchProductID).Sum(i => i.MMProductPriceProductQty);


                    #region Cưa xẻ
                    operationInfo = operationsList.FirstOrDefault(i => i.MMOperationNo == CuaXeNo);//Công đoạn cưa xẻ

                    //List<ICShipmentItemsInfo> objShipmentItemList = new List<ICShipmentItemsInfo>();
                    //foreach (MMProductPricesInfo productPrice1 in entity.ProductPriceList)
                    //{
                    //    if (!matchID.Contains(productPrice1.FK_MMBatchProductID))
                    //    {
                    //       objShipmentItemList.AddRange(objShipmentItemsController.GetRoundwoodShipmentFromAllocationProposalByBatchProductIDOperationIDAndDate(productPrice1.FK_MMBatchProductID, operation.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate));
                    //       matchID.Add(productPrice1.FK_MMBatchProductID);
                    //    }
                    //}
                    //matchID.Clear();  
                    // decimal totalBPQty = objShipmentItemList.Sum(t => t.ICShipmentItemProductQty);

                    decimal phanTramChiPhi = 0; // Tổng nhập PT LSX / Tổng nhập PT các LSX
                    decimal AUnitPrice = 0;
                    decimal BUnitPrice = 0;
                    decimal CUnitPrice = 0;
                    #region XKGT - NKLC
                    // Chi phí ban đầu ( XKGT từ LCP )
                    chiPhiBanDau = 0;


                    shipmentItemList = objShipmentItemsController.GetRoundwoodShipmentFromAllocationProposalByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    {
                        chiPhiBanDau += shipmentItem.ICShipmentItemTotalAmount;
                    }
                    // decimal bpQty = shipmentItemList.Sum(t => t.ICShipmentItemProductQty);
                    //if (totalBPQty > 0)
                    //    phanTramChiPhi = bpQty / totalBPQty;
                    chiPhiBanDauDD = chiPhiBanDau;
                    // Tính NKLC từ chi phí ban đầu
                    receiptItemList = objReceiptItemsController.GetSubRoundWoodReceiptByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    {
                        ICShipmentItemsInfo objMatchShipment = shipmentItemList.FirstOrDefault(i => i.Id == receiptItem.FK_ICShipmentItemID);
                        if (objMatchShipment != null)
                        {
                            receiptItem.ICReceiptItemProductUnitCost = objMatchShipment.ICShipmentItemProductUnitPrice;
                            receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemProductUnitCost * receiptItem.ICReceiptItemProductQty;

                            if (receiptItem.ICReceiptItemProductUnitCost > 0)
                            {
                                objReceiptItemsController.UpdateObject(receiptItem);

                            CHAYLAI1:
                                try
                                {
                                    dbUtil.ExecuteNonQuery("UpdateInventoryCost", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                                }
                                catch (Exception ex)
                                {
                                    goto CHAYLAI1;
                                }

                                // Cập nhật giá xuất kho gỗ tròn tạo từ NKLC
                                objShipmentItemsInfo = objShipmentItemsController.GetRoundwoodShipmentFromSubRoundWoodByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate, receiptItem.Id);
                                if (objShipmentItemsInfo != null)
                                {

                                    // objShipmentItemsInfo.ICShipmentItemTotalCost = receiptItem.ICReceiptItemTotalCost;
                                    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                                    objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductUnitPrice * objShipmentItemsInfo.ICShipmentItemProductQty;
                                    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                                }
                            }
                        }
                    }

                    #endregion

                    #region XKGT - NKPT
                    // Chi phí ban đầu ( XKGT từ NKLC )
                    //chiPhiBanDau = 0;


                    //shipmentItemList = objShipmentItemsController.GetAllRoundwoodShipmentFromSubRoundWoodByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operation.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
                    //foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    //{
                    //    chiPhiBanDau += shipmentItem.ICShipmentItemTotalAmount;
                    //}

                    // Tính NKPT từ chi phí ban đầu
                    receiptItemList = objReceiptItemsController.GetAllFreshLumberReceiptItemByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);



                    List<ICReceiptItemsInfo> receiptItemBList = new List<ICReceiptItemsInfo>();
                    List<ICReceiptItemsInfo> receiptItemCList = new List<ICReceiptItemsInfo>();
                    List<ICReceiptItemsInfo> receiptItemAList = new List<ICReceiptItemsInfo>();
                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    {
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(receiptItem.FK_ICProductAttributeQualityID);
                        if (objProductAttributesInfo != null)
                        {
                            receiptItem.QualifyString = objProductAttributesInfo.ICProductAttributeValue;
                            if (objProductAttributesInfo.ICProductAttributeValue == "A")
                            {
                                receiptItemAList.Add(receiptItem);
                            }
                            else if (objProductAttributesInfo.ICProductAttributeValue == "B")
                            {
                                receiptItemBList.Add(receiptItem);
                            }
                            else if (objProductAttributesInfo.ICProductAttributeValue == "C")
                            {
                                receiptItemCList.Add(receiptItem);
                            }
                        }
                    }

                    decimal totalQtyB = receiptItemBList.Sum(i => i.ICReceiptItemProductQty);
                    decimal totalQtyC = receiptItemCList.Sum(i => i.ICReceiptItemProductQty);
                    decimal totalQtyA = receiptItemAList.Sum(i => i.ICReceiptItemProductQty);
                    decimal totalQty = totalQtyB + totalQtyA + totalQtyC;
                    decimal costOfOne = chiPhiBanDau / totalQty;


                    #region Phần trăm chi phí

                    List<ICReceiptItemsInfo> ReceiptItemPTCP = new List<ICReceiptItemsInfo>();
                    foreach (MMProductPricesInfo productPrice1 in entity.ProductPriceList)
                    {
                        if (!matchID.Contains(productPrice1.FK_MMBatchProductID))
                        {
                            ReceiptItemPTCP.AddRange(objReceiptItemsController.GetAllFreshLumberReceiptItemByBatchProductIDOperationIDAndDate(productPrice1.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate));
                            matchID.Add(productPrice1.FK_MMBatchProductID);
                        }
                    }
                    matchID.Clear();

                    decimal allQty = ReceiptItemPTCP.Sum(t => t.ICReceiptItemProductQty);
                    decimal bpQty = totalQty;

                    phanTramChiPhi = 0;
                    if (allQty > 0)
                    {
                        phanTramChiPhi = bpQty / allQty;
                    }

                    #endregion

                    decimal TongChiPhiBanDau = 0;
                    TongChiPhiBanDau = (chiPhiBanDau + (phanTramChiPhi * operationInfo.chiPhiNhanCongTT) + (phanTramChiPhi * operationInfo.chiPhiNhanCongChung));
                    foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    {
                        decimal totalQtyPercent = 0;
                        totalQtyPercent = receiptItem.ICReceiptItemProductQty / totalQty;

                        if (receiptItem.FK_ICReceiptID == 51992)
                        {
                            String a = String.Empty;
                        }
                        decimal BValue = TongChiPhiBanDau / totalQty;

                        // Tổng giá NL
                        chiPhi += ((phanTramChiPhi * operationInfo.chiPhiNhanCongTT * totalQtyPercent) + (phanTramChiPhi * operationInfo.chiPhiNhanCongChung * totalQtyPercent));
                        // Giá từng NL
                        decimal CValue = (BValue / 100) * 40;
                        if (receiptItem.QualifyString == "A") // Chất lượng A •	Đơn giá của A =Tổng giá trị (GT xuất kho gỗ tròn +CP) - ( giá trị của B+ giá trị của C)/Số lượng của A .
                        {
                            receiptItem.ICReceiptItemProductUnitCost = ((TongChiPhiBanDau - (BValue * totalQtyB + CValue * totalQtyC)) / totalQtyA);
                            AUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                            /* CP tính theo tỉ lệ A/B */
                            decimal tileAB = receiptItem.ICReceiptItemProductUnitCost / BValue;
                            receiptItem.ICReceiptItemWoodFee = (chiPhiBanDau / totalQty) * tileAB;
                            receiptItem.ICReceiptItemDirectSalaryFee = ((phanTramChiPhi * operationInfo.chiPhiNhanCongTT) / totalQty) * tileAB;
                            receiptItem.ICReceiptItemGeneralFee = ((phanTramChiPhi * operationInfo.chiPhiNhanCongChung) / totalQty) * tileAB;
                        }
                        else if (receiptItem.QualifyString == "B") // Chất lượng B •	Đơn giá của B = Tổng giá trị (GT xuất kho gỗ tròn +CP) / Tổng số lương( KL gỗ xẻ nhận được).
                        {
                            receiptItem.ICReceiptItemProductUnitCost = BValue;
                            BUnitPrice = receiptItem.ICReceiptItemProductUnitCost;

                            receiptItem.ICReceiptItemWoodFee = chiPhiBanDau / totalQty;
                            receiptItem.ICReceiptItemDirectSalaryFee = (phanTramChiPhi * operationInfo.chiPhiNhanCongTT) / totalQty;
                            receiptItem.ICReceiptItemGeneralFee = (phanTramChiPhi * operationInfo.chiPhiNhanCongChung) / totalQty;
                        }
                        else if (receiptItem.QualifyString == "C" && totalQtyA > 0) // Chất lượng C •	Đơn giá của C = 40% đơn  giá của B
                        {
                            receiptItem.ICReceiptItemProductUnitCost = CValue;
                            CUnitPrice = receiptItem.ICReceiptItemProductUnitCost;

                            receiptItem.ICReceiptItemWoodFee = (chiPhiBanDau / totalQty) / 100 * 40;
                            receiptItem.ICReceiptItemDirectSalaryFee = ((phanTramChiPhi * operationInfo.chiPhiNhanCongTT) / totalQty) / 100 * 40;
                            receiptItem.ICReceiptItemGeneralFee = ((phanTramChiPhi * operationInfo.chiPhiNhanCongChung) / totalQty) / 100 * 40;
                        }
                        else if (receiptItem.QualifyString == "C")
                        {
                            CValue = (TongChiPhiBanDau - (BValue * totalQtyB)) / totalQtyC;
                            receiptItem.ICReceiptItemProductUnitCost = CValue;
                            CUnitPrice = receiptItem.ICReceiptItemProductUnitCost;

                            receiptItem.ICReceiptItemWoodFee = chiPhiBanDau / totalQty;
                            receiptItem.ICReceiptItemDirectSalaryFee = (phanTramChiPhi * operationInfo.chiPhiNhanCongTT) / totalQty;
                            receiptItem.ICReceiptItemGeneralFee = (phanTramChiPhi * operationInfo.chiPhiNhanCongChung) / totalQty;
                        }

                        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemProductUnitCost * receiptItem.ICReceiptItemProductQty;
                        if (receiptItem.ICReceiptItemProductUnitCost > 0)
                        {
                            //BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                            objReceiptItemsController.UpdateObject(receiptItem);
                        CHAYLAI2:
                            try
                            {
                                dbUtil.ExecuteNonQuery("UpdateInventoryCost_CDCua", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                            }
                            catch (Exception ex)
                            {
                                goto CHAYLAI2;
                            }
                            // Cập nhật giá xuất kho phách tươi tạo từ NKPT
                            MMOperationsInfo sayOperation = operationsList.FirstOrDefault(i => i.MMOperationNo == SayNo);
                            if (sayOperation != null)
                            {
                                objShipmentItemsInfo = objShipmentItemsController.GetFreshLumberShipmentFromFreshLumberReceiptByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, sayOperation.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate, receiptItem.Id).FirstOrDefault();
                                if (objShipmentItemsInfo != null)
                                {
                                    objShipmentItemsInfo.ICShipmentItemWoodFee = receiptItem.ICReceiptItemWoodFee;
                                    objShipmentItemsInfo.ICShipmentItemDirectSalaryFee = receiptItem.ICReceiptItemDirectSalaryFee;
                                    objShipmentItemsInfo.ICShipmentItemGeneralFee = receiptItem.ICReceiptItemGeneralFee;
                                    objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                                    objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductUnitPrice * objShipmentItemsInfo.ICShipmentItemProductQty;
                                    BOSApp.RoundByCurrency(objShipmentItemsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                                    objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                                }
                            }
                        }
                    }

                    #endregion

                    #endregion

                    //#region Sấy

                    //operationInfo = operationsList.FirstOrDefault(i => i.MMOperationNo == SayNo);//Công đoạn sấy
                    //#region XKPT - NKLS


                    //shipmentItemList = objShipmentItemsController.GetFreshLumberShipmentFromFreshLumberReceiptByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate, 0);
                    //chiPhiBanDauDD = chiPhiBanDau;
                    //// Tính NKLS từ chi phí ban đầu
                    //receiptItemList = objReceiptItemsController.GetReceiptHeatItemByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

                    //receiptItemBList = new List<ICReceiptItemsInfo>();
                    //receiptItemCList = new List<ICReceiptItemsInfo>();
                    //receiptItemAList = new List<ICReceiptItemsInfo>();
                    //foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    //{
                    //    objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(receiptItem.FK_ICProductAttributeQualityID);
                    //    if (objProductAttributesInfo != null)
                    //    {
                    //        receiptItem.QualifyString = objProductAttributesInfo.ICProductAttributeValue;
                    //        if (objProductAttributesInfo.ICProductAttributeValue == "A")
                    //        {
                    //            receiptItemAList.Add(receiptItem);
                    //        }
                    //        else if (objProductAttributesInfo.ICProductAttributeValue == "B")
                    //        {
                    //            receiptItemBList.Add(receiptItem);
                    //        }
                    //        else if (objProductAttributesInfo.ICProductAttributeValue == "C")
                    //        {
                    //            receiptItemCList.Add(receiptItem);
                    //        }
                    //    }
                    //}
                    //chiPhiBanDau = shipmentItemList.Sum(i => i.ICShipmentItemTotalAmount);
                    //totalQtyB = receiptItemBList.Sum(i => i.ICReceiptItemProductQty);
                    //totalQtyC = receiptItemCList.Sum(i => i.ICReceiptItemProductQty);
                    //totalQtyA = receiptItemAList.Sum(i => i.ICReceiptItemProductQty);
                    //decimal soLuongTong = totalQtyB + totalQtyA + totalQtyC;

                    //#region Phần trăm chi phí

                    //ReceiptItemPTCP = new List<ICReceiptItemsInfo>();
                    //foreach (MMProductPricesInfo productPrice1 in entity.ProductPriceList)
                    //{
                    //    if (!matchID.Contains(productPrice1.FK_MMBatchProductID))
                    //    {
                    //        ReceiptItemPTCP.AddRange(objReceiptItemsController.GetReceiptHeatItemByBatchProductIDOperationIDAndDate(productPrice1.FK_MMBatchProductID, operation.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate));
                    //        matchID.Add(productPrice1.FK_MMBatchProductID);
                    //    }
                    //}
                    //matchID.Clear();

                    // allQty = ReceiptItemPTCP.Sum(t => t.ICReceiptItemProductQty);
                    // bpQty = soLuongTong;

                    //phanTramChiPhi = 0;
                    //if (allQty > 0)
                    //{
                    //    phanTramChiPhi = bpQty / allQty;
                    //}

                    //#endregion

                    //foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    //{

                    //    decimal totalQtyPercent = 0;
                    //    totalQtyPercent = receiptItem.ICReceiptItemProductQty / soLuongTong;
                    //    if (receiptItem.FK_ICReceiptID == 118)
                    //    {
                    //    }

                    //    // Tổng giá NL
                    //    chiPhi += ((phanTramChiPhi * operationInfo.chiPhiNhanCongTT * totalQtyPercent)
                    //        + (phanTramChiPhi * operationInfo.chiPhiNhanCongChung * totalQtyPercent));

                    //    ICShipmentItemsInfo shipmentItemsInfo = shipmentItemList.Where(k => k.FK_ICProductID == receiptItem.FK_ICProductID
                    //            && k.FK_ICProductSerieID == receiptItem.FK_ICProductSerieID).FirstOrDefault();
                    //    if (shipmentItemsInfo != null)
                    //    {
                    //        receiptItem.ICReceiptItemProductUnitCost = shipmentItemsInfo.ICShipmentItemProductUnitPrice + (((phanTramChiPhi * operationInfo.chiPhiNhanCongTT) + (phanTramChiPhi * operationInfo.chiPhiNhanCongChung)) / soLuongTong);
                    //    }
                    //    else
                    //    {
                    //        receiptItem.ICReceiptItemProductUnitCost = (((phanTramChiPhi * operationInfo.chiPhiNhanCongTT) + (phanTramChiPhi * operationInfo.chiPhiNhanCongChung)) / soLuongTong);
                    //    }
                    //    receiptItem.ICReceiptItemWoodFee = receiptItem.ICReceiptItemProductUnitCost;
                    //    receiptItem.ICReceiptItemDirectSalaryFee = (phanTramChiPhi * operationInfo.chiPhiNhanCongTT) / soLuongTong;
                    //    receiptItem.ICReceiptItemGeneralFee = (phanTramChiPhi * operationInfo.chiPhiNhanCongChung) / soLuongTong;
                    //    receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemProductUnitCost * receiptItem.ICReceiptItemProductQty;
                    //    objReceiptItemsController.UpdateObject(receiptItem);
                    //    if (receiptItem.ICReceiptItemProductUnitCost > 0)
                    //    {
                    //        CHAYLAI3:
                    //        try
                    //        {
                    //            dbUtil.ExecuteNonQuery("UpdateInventoryCost_CDSay", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            goto CHAYLAI3;
                    //        }
                    //        // Cập nhật giá xuất kho phách tươi tạo từ NKPT

                    //        objShipmentItemsInfo = objShipmentItemsController.GetShipmentHeatFromReceiptHeatByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate, receiptItem.Id).FirstOrDefault();
                    //        if (objShipmentItemsInfo != null)
                    //        {
                    //            objShipmentItemsInfo.ICShipmentItemWoodFee = receiptItem.ICReceiptItemWoodFee;
                    //            objShipmentItemsInfo.ICShipmentItemDirectSalaryFee = receiptItem.ICReceiptItemDirectSalaryFee;
                    //            objShipmentItemsInfo.ICShipmentItemGeneralFee = receiptItem.ICReceiptItemGeneralFee;
                    //            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
                    //            objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductUnitPrice * objShipmentItemsInfo.ICShipmentItemProductQty;
                    //            objShipmentItemsController.UpdateObject(objShipmentItemsInfo);
                    //        }
                    //    }
                    //}

                    //#endregion

                    //#region XKLS - NKPK

                    //// Tính NKPK từ chi phí ban đầu
                    //receiptItemList = objReceiptItemsController.GetDryLumberReceiptItemByBatchProductIDOperationIDAndDate(productPrice.FK_MMBatchProductID, operation.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);


                    //foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
                    //{
                    //    ICShipmentItemsInfo objMatchShipment = (ICShipmentItemsInfo)objShipmentItemsController.GetObjectByID(receiptItem.FK_ICShipmentItemID);
                    //    if (objMatchShipment != null)
                    //    {
                    //        receiptItem.ICReceiptItemProductUnitCost = objMatchShipment.ICShipmentItemProductUnitPrice;
                    //        receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemProductUnitCost * receiptItem.ICReceiptItemProductQty;
                    //        //Cập nhật InventoryStock Unit Cost
                    //        ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(receiptItem.FK_ICStockID, receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID);
                    //        if (objInventoryStocksInfo != null)
                    //        {
                    //            objInventoryStocksInfo.ICInventoryStockUnitCost = receiptItem.ICReceiptItemProductUnitCost;
                    //            objInventoryStocksController.UpdateObject(objInventoryStocksInfo);
                    //        }
                    //    }


                    //}
                    //#endregion

                    //#endregion

                    batchLumberIDList.Add(productPrice.FK_MMBatchProductID);
                    chiPhiBanDauList.Add(productPrice.FK_MMBatchProductID, chiPhiBanDauDD);
                    chiPhiList.Add(productPrice.FK_MMBatchProductID, chiPhi);
                }

                //List<ICReceiptItemsInfo> receiptItemsInfoList = objReceiptItemsController.GetDryLumberReceiptItemByBatchProductIDAndProductID(productPrice.FK_MMBatchProductID, productPrice.FK_ICProductIDForBatch);
                //ICReceiptItemsInfo objReceiptItemsInfo = receiptItemsInfoList.FirstOrDefault();
                //if (objReceiptItemsInfo != null)
                //{
                //    productPrice.MMProductPriceProductPrice = objReceiptItemsInfo.ICReceiptItemProductUnitCost;
                //    productPrice.FK_ICProductSerieID = objReceiptItemsInfo.FK_ICProductSerieID;
                //    productPrice.MMProductPriceProductSeriesNo = objReceiptItemsInfo.ICReceiptItemProductSerialNo;

                //    decimal soLuongNhap = receiptItemsInfoList.Sum(i => i.ICReceiptItemProductQty);
                //    if (soLuongNhap < productPrice.MMProductPriceProductQty)
                //    {
                //        decimal chiPhiCuoi = receiptItemsInfoList.Sum(i => i.ICReceiptItemTotalCost);
                //        foreach (int key in chiPhiBanDauList.Keys)
                //        {
                //            if (key == productPrice.FK_MMBatchProductID)
                //            {
                //                chiPhiBanDauDD = chiPhiBanDauList[key];
                //            }
                //        }
                //        foreach (int key in chiPhiList.Keys)
                //        {
                //            if (key == productPrice.FK_MMBatchProductID)
                //            {
                //                chiPhi = chiPhiList[key];
                //            }
                //        }
                //        decimal chiPhiChenhLech = (chiPhiBanDauDD + chiPhi) - chiPhiCuoi;
                //        decimal soLuongChenhLech = productPrice.MMProductPriceProductQty - soLuongNhap;
                //        productPrice.MMProductPriceProductCompletedQty = objReceiptItemsInfo.ICReceiptItemProductQty;
                //        MMProductPriceIncompletesInfo objProductPriceIncompletesInfo = entity.ProductPriceIncompletesList.Where(p => p.FK_MMBatchProductID == productPrice.FK_MMBatchProductID
                //           && p.FK_ICProductIDForBatch == productPrice.FK_ICProductIDForBatch
                //           && p.FK_ARSaleOrderID == productPrice.FK_ARSaleOrderID
                //           && p.FK_ARSaleOrderItemID == productPrice.FK_ARSaleOrderItemID).FirstOrDefault();
                //        if (objProductPriceIncompletesInfo != null)
                //        {
                //            objProductPriceIncompletesInfo.MMProductPriceIncompleteProductQty = soLuongChenhLech;
                //            productPrice.MMProductPriceProductCompletedQty = soLuongNhap;
                //            objProductPriceIncompletesInfo.MMProductPriceIncompleteProductPrice = chiPhiChenhLech / objProductPriceIncompletesInfo.MMProductPriceIncompleteProductQty;
                //            entity.ProductPriceIncompletesList.GridControl.RefreshDataSource();
                //        }
                //    }


                //}
            }

            #region Sấy
            //Công đoạn sấy
            operationInfo = operationsList.FirstOrDefault(i => i.MMOperationNo == SayNo);
            shipmentItemList = objShipmentItemsController.GetFreshLumberShipmentFromFreshLumberReceiptByOperationIDAndDate(operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);
            // Tính NKLS
            receiptItemList = objReceiptItemsController.GetReceiptHeatItemByBatchProductIDOperationIDAndDate(0, operationInfo.MMOperationID, objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate);

            decimal soLuongTong = receiptItemList.Sum(p => p.ICReceiptItemProductQty);
            decimal woodFee;

            foreach (ICReceiptItemsInfo receiptItem in receiptItemList)
            {

                decimal totalQtyPercent = 0;
                totalQtyPercent = receiptItem.ICReceiptItemProductQty / soLuongTong;
                if (receiptItem.FK_ICReceiptID == 118)
                {

                }

                //ICShipmentItemsInfo shipmentItemsInfo = shipmentItemList.Where(k => k.FK_ICProductID == receiptItem.FK_ICProductID
                //        && k.FK_ICProductSerieID == receiptItem.FK_ICProductSerieID).FirstOrDefault();

                ICShipmentItemsInfo shipmentItemsInfo = shipmentItemList.Where(k => k.Id == receiptItem.FK_ICShipmentItemID).FirstOrDefault();


                if (shipmentItemsInfo != null)
                {
                    //receiptItem.ICReceiptItemProductUnitCost = shipmentItemsInfo.ICShipmentItemProductUnitPrice + ((totalQtyPercent * operationInfo.chiPhiNhanCongTT) + (totalQtyPercent * operationInfo.chiPhiNhanCongChung));
                    woodFee = shipmentItemsInfo.ICShipmentItemTotalAmount;
                    receiptItem.ICReceiptItemTotalCost = shipmentItemsInfo.ICShipmentItemTotalAmount + ((totalQtyPercent * operationInfo.chiPhiNhanCongTT) + (totalQtyPercent * operationInfo.chiPhiNhanCongChung));
                }
                else
                {
                    woodFee = 0;
                    receiptItem.ICReceiptItemTotalCost = ((totalQtyPercent * operationInfo.chiPhiNhanCongTT) + (totalQtyPercent * operationInfo.chiPhiNhanCongChung));
                }
                receiptItem.ICReceiptItemWoodFee = woodFee;
                receiptItem.ICReceiptItemDirectSalaryFee = totalQtyPercent * operationInfo.chiPhiNhanCongTT;
                receiptItem.ICReceiptItemGeneralFee = totalQtyPercent * operationInfo.chiPhiNhanCongChung;
                receiptItem.ICReceiptItemProductUnitCost = receiptItem.ICReceiptItemTotalCost / receiptItem.ICReceiptItemProductQty;
                if (receiptItem.ICReceiptItemProductUnitCost > 0)
                {
                    //BOSApp.RoundByCurrency(receiptItem, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objReceiptItemsController.UpdateObject(receiptItem);
                CHAYLAI3:
                    try
                    {
                        dbUtil.ExecuteNonQuery("UpdateInventoryCost_CDSay", receiptItem.FK_ICProductID, receiptItem.FK_ICProductSerieID, receiptItem.ICReceiptItemProductUnitCost);
                    }
                    catch (Exception ex)
                    {
                        goto CHAYLAI3;
                    }
                }
            }

            #endregion

            #region refresh NK XK
            List<int> batchProductIDList = new List<int>();
            entity.ProductionCostIngredientCostList.Clear();
            //foreach (MMProductionCostItemsInfo item in entity.ProductionCostItemList)
            //{
            //    if (!batchProductIDList.Contains(item.FK_MMBatchProductID))
            //    {
            //        batchProductIDList.Add(item.FK_MMBatchProductID);

            //        List<MMProductionCostIngredientCostsInfo> ingredientCostList = new List<MMProductionCostIngredientCostsInfo>();
            //        ingredientCostList = GetIngredientCostByDateAndBatchID(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate, item.FK_MMBatchProductID);
            //        if (ingredientCostList != null)
            //        {
            //            entity.ProductionCostIngredientCostList.AddRange(ingredientCostList);
            //        }
            //    }
            //}

            GetProductionCostItemByDate(objProductionCostsInfo.MMProductionCostFromDate, objProductionCostsInfo.MMProductionCostToDate, true);
            //entity.ProductionCostIngredientCostList.GridControl.InitGridControlDataSource();
            //entity.ProductionCostIngredientCostList.GridControl.RefreshDataSource();
            #endregion

            BOSProgressBar.Close();
        }

        public void SetIncompletePrice(MMProductPricesInfo objProductPricesInfo, decimal totalAmount)
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)CurrentModuleEntity;
            MMProductPriceIncompletesInfo objProductPriceIncompletesInfo = entity.ProductPriceIncompletesList.Where(p => p.FK_MMBatchProductID == objProductPricesInfo.FK_MMBatchProductID
                        && p.FK_ICProductIDForBatch == objProductPricesInfo.FK_ICProductIDForBatch
                        && p.FK_ARSaleOrderID == objProductPricesInfo.FK_ARSaleOrderID
                        && p.FK_ARSaleOrderItemID == objProductPricesInfo.FK_ARSaleOrderItemID
                        && p.FK_MMProductionNormID == objProductPricesInfo.FK_MMProductionNormID).FirstOrDefault();
            if (objProductPriceIncompletesInfo != null)
            {
                objProductPriceIncompletesInfo.MMProductPriceIncompleteProductPrice = (totalAmount - (objProductPricesInfo.MMProductPriceProductPrice * objProductPricesInfo.MMProductPriceProductCompletedQty)) / objProductPriceIncompletesInfo.MMProductPriceIncompleteProductQty;
                entity.ProductPriceIncompletesList.GridControl?.RefreshDataSource();
            }
        }
    }
}
