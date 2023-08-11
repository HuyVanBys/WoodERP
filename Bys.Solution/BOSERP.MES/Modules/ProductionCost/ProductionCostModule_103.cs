using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCost
{
    public partial class ProductionCostModule
    {
        #region Constants
        public const string OverallProductionCostFor622GridControlName = "fld_dgcMMProductionCostOveralls622";
        public const string OverallProductionCostFor627GridControlName = "fld_dgcMMProductionCostOveralls627";
        public const string OverallProductionCostFor627AGridControlName = "fld_dgcMMProductionCostOveralls627A";
        public const string OverallProductionCostFor6279GridControlName = "fld_dgcMMProductionCostOveralls6279";
        //public const string OverallProductionCostFor6273GridControlName = "fld_dgcMMProductionCostOveralls6273";
        //public const string OverallProductionCostFor6274GridControlName = "fld_dgcMMProductionCostOveralls6274";
        //public const string OverallProductionCostFor6277GridControlName = "fld_dgcMMProductionCostOveralls6277";
        //public const string OverallProductionCostFor6278GridControlName = "fld_dgcMMProductionCostOveralls6278";
        #endregion Constants

        #region Variables

        MMProductionCostOverallsGridControl OverallProductionCostFor622GridControl;
        MMProductionCostOverallsGridControl OverallProductionCostFor627GridControl;
        MMProductionCostOverallsGridControl OverallProductionCostFor627AGridControl;
        MMProductionCostOverallsGridControl OverallProductionCostFor6279GridControl;
        //MMProductionCostOverallsGridControl OverallProductionCostFor6273GridControl;
        //MMProductionCostOverallsGridControl OverallProductionCostFor6274GridControl;
        //MMProductionCostOverallsGridControl OverallProductionCostFor6277GridControl;
        //MMProductionCostOverallsGridControl OverallProductionCostFor6278GridControl;

        #endregion Variables

        #region Overall production cost
        /// <summary>
        /// Get sale order by batchID and accountNo
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public DataTable GetSaleOderByBatchID(string accountNo)
        {
            MMProductionCostsInfo mainObject = CurrentModuleEntity.MainObject as MMProductionCostsInfo;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            MMProductionCostOverallsInfo currentObject = GetCurrentObject(accountNo);
            DataTable dt = new DataTable();
            if (currentObject != null && currentObject.FK_MMBatchProductID != 0)
            {
                DataSet ds = objSaleOrdersController.GetSaleOrderByBatch(currentObject.FK_MMBatchProductID);
                if (ds != null && ds.Tables.Count != 0)
                    dt = ds.Tables[0];
            }
            return dt;
        }

        /// <summary>
        /// Get proposal by batchID and AccountNo
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public DataTable GetProposalByBatchID(string accountNo)
        {
            MMProductionCostsInfo mainObject = CurrentModuleEntity.MainObject as MMProductionCostsInfo;
            MMProposalsController objProposalsController = new MMProposalsController();
            MMProductionCostOverallsInfo overallProductionCost = GetCurrentObject(accountNo);
            DataTable dt = new DataTable();
            if (overallProductionCost != null && overallProductionCost.FK_MMBatchProductID != 0)
            {
                DataSet ds = objProposalsController.GetProposalByBatch(overallProductionCost.FK_MMBatchProductID);
                if (ds != null && ds.Tables.Count != 0)
                    dt = ds.Tables[0];
            }
            return dt;
        }

        /// <summary>
        /// Get operation by batchID and AccountNo
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public DataTable GetOperationByBatchID(string accountNo)
        {
            MMProductionCostsInfo mainObject = CurrentModuleEntity.MainObject as MMProductionCostsInfo;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMProductionCostOverallsInfo overallProductionCost = GetCurrentObject(accountNo);
            DataTable dt = new DataTable();
            if (overallProductionCost != null && overallProductionCost.FK_MMBatchProductID != 0)
            {
                DataSet ds = objOperationsController.GetOperationByBatch(overallProductionCost.FK_MMBatchProductID);
                if (ds != null && ds.Tables.Count != 0)
                    dt = ds.Tables[0];
            }
            return dt;
        }

        /// <summary>
        /// Get product by batchID and accaountNo 
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public DataTable GetProductByBatchID(string accountNo)
        {
            MMProductionCostsInfo mainObject = CurrentModuleEntity.MainObject as MMProductionCostsInfo;
            ICProductsController objProductsController = new ICProductsController();
            MMProductionCostOverallsInfo overallProductionCost = GetCurrentObject(accountNo);
            DataTable dt = new DataTable();
            if (overallProductionCost != null && overallProductionCost.FK_MMBatchProductID != 0)
            {
                DataSet ds = objProductsController.GetProductByBatch(overallProductionCost.FK_MMBatchProductID);
                if (ds != null && ds.Tables.Count != 0)
                    dt = ds.Tables[0];
            }
            return dt;
        }

        /// <summary>
        /// Get product by productID
        /// </summary>
        /// <param name="productID">ProductID</param>
        /// <returns></returns>
        private ICProductsInfo GetProductByProductID(int productID)
        {
            ICProductsController productController = new ICProductsController();
            ICProductsInfo product = productController.GetObjectByID(productID) as ICProductsInfo;
            return product;
        }

        /// <summary>
        /// Update product name and product description by productid
        /// </summary>
        /// <param name="productID"></param>
        public void UpdateProductInfo(int productID, string accountNo)
        {
            MMProductionCostOverallsInfo overallProductionCost = GetCurrentObject(accountNo);
            if (overallProductionCost != null)
            {
                ICProductsInfo product = GetProductByProductID(productID);
                if (product != null)
                {
                    overallProductionCost.MMProductionCostOverallProductNo = product.ICProductNo;
                    overallProductionCost.MMProductionCostOverallProductName = product.ICProductName;
                    overallProductionCost.MMProductionCostOverallProductDesc = product.ICProductDesc;
                    overallProductionCost.FK_ICProductID = productID;
                }
            }
        }

        /// <summary>
        /// Update overall production cost type
        /// </summary>
        public void UpdateOverallProductionCostCostType(string accountNo)
        {
            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            MMProductionCostOverallsInfo currentObject = GetCurrentObject(accountNo);
            if (currentObject != null && string.IsNullOrEmpty(currentObject.MMProductionCostOverallCostTypeCombo))
            {
                MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;
                currentObject.MMProductionCostOverallCostTypeCombo = accountNo;
            }
        }

        /// <summary>
        /// Delete the selected item from the item list
        /// </summary>
        public void DeleteItemFromOverallProductionCostItemList(string accountNo)
        {
            //ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            //if (accountNo == ProductionCostAccounts.ChiPhiNhanVienXuong)
            //    entity.OverallProductionCostListFor6271.RemoveSelectedRowObjectFromList();
            //else if (accountNo == ProductionCostAccounts.ChiPhiVatLieu)
            //    entity.OverallProductionCostListFor6272.RemoveSelectedRowObjectFromList();
            //else if (accountNo == ProductionCostAccounts.ChiPhiDungCuSX)
            //    entity.OverallProductionCostListFor6273.RemoveSelectedRowObjectFromList();
            //else if (accountNo == ProductionCostAccounts.ChiPhiKhauHaoMay)
            //    entity.OverallProductionCostListFor6274.RemoveSelectedRowObjectFromList();
            //else if (accountNo == ProductionCostAccounts.ChiPhiDichVuMuaNgoai)
            //    entity.OverallProductionCostListFor6277.RemoveSelectedRowObjectFromList();
            //else if (accountNo == ProductionCostAccounts.ChiPhiChungNhaMay)
            //    entity.OverallProductionCostListFor6278.RemoveSelectedRowObjectFromList();
        }
        /// <summary>
        /// Get document entry amount by account no
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        private decimal GetDocumentEntryAmountByAccountNo(string accountNo)
        {
            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
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

        private decimal GetDocumentEntryCreditAmountByAccountNo(string accountNo)
        {
            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();
            MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;
            DateTime? fromDate = null;
            if (mainObject.MMProductionCostFromDate != DateTime.MaxValue)
                fromDate = mainObject.MMProductionCostFromDate;
            DateTime? dateTo = null;
            if (mainObject.MMProductionCostToDate != DateTime.MaxValue)
                dateTo = mainObject.MMProductionCostToDate;
            decimal amount = 0;
            amount = documentEntryController.GetDocumentEntryCreditAmountByAccountNo(accountNo, fromDate, dateTo);

            return amount;
        }

        /// <summary>
        /// Get overall production cost amounts
        /// </summary>
        private void GetOverallProductionCostAmounts()
        {

            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;

            //mainObject.DirectLaborCostFor622TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiNhanCongTrucTiep);
            mainObject.OverallProductionCostFor627ATotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay627A);
            mainObject.OverallProductionCostFor627AAppropriationAmount = mainObject.OverallProductionCostFor627ATotalAmount;
            //mainObject.OverallProductionCostFor6279TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            mainObject.OverallProductionCostFor6279TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279)
                - GetDocumentEntryCreditAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            mainObject.OverallProductionCostFor6279AppropriationAmount = mainObject.OverallProductionCostFor6279TotalAmount;

            //mainObject.OverallProductionCostFor6273TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiDungCuSX);
            //mainObject.OverallProductionCostFor6274TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiKhauHaoMay);
            //mainObject.OverallProductionCostFor6277TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiDichVuMuaNgoai);
            //mainObject.OverallProductionCostFor6278TotalAmount = GetDocumentEntryAmountByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay);

            entity.UpdateMainObjectBindingSource();

            //Get Overall production cost 6272

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
            List<MMOperationsInfo> operationsList = objOperationsController.GetOperationListForProductionCost2();

            //string[] ChiPhiNhanCongTrucTiepList = new string[] { "6223", "6224", "6225", "6226", "6227", "6228" };
            //string[] ChiPhiChungList = new string[] { "6272", "6273", "6274", "6275", "6276", "6277" };

            string[] ChiPhiNhanCongTrucTiepList = new string[] { "6224", "6225", "6226", "6227", "6228", "6229" };
            string[] ChiPhiChungList = new string[] { "6273", "6274", "6275", "6276", "6277", "6278" };

            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo;
            MMProductionCostOverallsInfo objProductionCostOverallsInfo;

            entity.OverallProductionCostListFor622.Clear();
            entity.OverallProductionCostListFor627.Clear();
            entity.OverallProductionCostListFor627A.Clear();
            entity.OverallProductionCostListFor6279.Clear();
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
                    operation.chiPhiNhanCongTT = GetDocumentEntryAmountByAccountNo(ChiPhiNhanCongTrucTiepList[account])
                        - GetDocumentEntryCreditAmountByAccountNo(ChiPhiNhanCongTrucTiepList[account]);
                    objProductionCostOverallsInfo.MMProductionCostOverallProductName = objAccountsInfo.ACAccountName;
                    objProductionCostOverallsInfo.MMProductionCostOverallTotalCost = operation.chiPhiNhanCongTT;
                    objProductionCostOverallsInfo.MMProductionCostOverallCostTypeCombo = objAccountsInfo.ACAccountNo;
                    entity.OverallProductionCostListFor622.Add(objProductionCostOverallsInfo);
                    mainObject.DirectLaborCostFor622TotalAmount += operation.chiPhiNhanCongTT;
                }
                account++;
            }
            mainObject.DirectLaborCostFor622AppropriationAmount = mainObject.DirectLaborCostFor622TotalAmount;
            account = 0;
            foreach (MMOperationsInfo operation in operationsList)
            {
                // Chi phí chung từng CĐ
                objProductionCostOverallsInfo = new MMProductionCostOverallsInfo();
                objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(ChiPhiChungList[account]);
                if (objAccountsInfo != null)
                {
                    operation.chiPhiNhanCongChung = GetDocumentEntryAmountByAccountNo(ChiPhiChungList[account])
                        - GetDocumentEntryCreditAmountByAccountNo(ChiPhiChungList[account]);
                    objProductionCostOverallsInfo.MMProductionCostOverallProductName = objAccountsInfo.ACAccountName;
                    objProductionCostOverallsInfo.MMProductionCostOverallTotalCost = operation.chiPhiNhanCongChung;
                    objProductionCostOverallsInfo.MMProductionCostOverallCostTypeCombo = objAccountsInfo.ACAccountNo;
                    entity.OverallProductionCostListFor627.Add(objProductionCostOverallsInfo);
                    mainObject.OverallProductionCostFor627TotalAmount += operation.chiPhiNhanCongChung;
                }
                account++;
            }
            mainObject.OverallProductionCostFor627AppropriationAmount = mainObject.OverallProductionCostFor627TotalAmount;

            // 6279
            List<ACAccountsInfo> acc6279List = objAccountsController.GetSubAccountsByAccountNo(ProductionCostAccounts.ChiPhiChungNhaMay6279);
            foreach (ACAccountsInfo accountItem in acc6279List)
            {
                if (!accountItem.ACAccountNo.Equals(ProductionCostAccounts.ChiPhiChungNhaMay6279))
                {
                    objProductionCostOverallsInfo = new MMProductionCostOverallsInfo();
                    objProductionCostOverallsInfo.MMProductionCostOverallProductName = accountItem.ACAccountName;
                    objProductionCostOverallsInfo.MMProductionCostOverallTotalCost = GetDocumentEntryAmountByAccountNo(accountItem.ACAccountNo)
                            - GetDocumentEntryCreditAmountByAccountNo(accountItem.ACAccountNo);
                    objProductionCostOverallsInfo.MMProductionCostOverallCostTypeCombo = accountItem.ACAccountNo;
                    entity.OverallProductionCostListFor6279.Add(objProductionCostOverallsInfo);
                }
            }

            // 627A
            objProductionCostOverallsInfo = new MMProductionCostOverallsInfo();
            objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(ProductionCostAccounts.ChiPhiChungNhaMay627A);
            if (objAccountsInfo != null)
            {
                objProductionCostOverallsInfo.MMProductionCostOverallProductName = objAccountsInfo.ACAccountName;
                objProductionCostOverallsInfo.MMProductionCostOverallTotalCost = mainObject.OverallProductionCostFor627ATotalAmount;
                objProductionCostOverallsInfo.MMProductionCostOverallCostTypeCombo = objAccountsInfo.ACAccountNo;
                entity.OverallProductionCostListFor627A.Add(objProductionCostOverallsInfo);
            }

            InitializeOverallProductionCostGridControls();

        }

        public void UpdateOverallProductionCostAppropriationAmountByAccountNo(string accountNo)
        {
            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            MMProductionCostsInfo mainObject = entity.MainObject as MMProductionCostsInfo;

            if (accountNo == ProductionCostAccounts.ChiPhiNhanCongTrucTiep)
                mainObject.DirectLaborCostFor622AppropriationAmount = entity.OverallProductionCostListFor622.Sum(item => item.MMProductionCostOverallTotalCost);
            else if (accountNo == ProductionCostAccounts.ChiPhiSanXuatChung)
                mainObject.OverallProductionCostFor627AppropriationAmount = entity.OverallProductionCostListFor627.Sum(item => item.MMProductionCostOverallTotalCost);
            else if (accountNo == ProductionCostAccounts.ChiPhiChungNhaMay627A)
                mainObject.OverallProductionCostFor6273AppropriationAmount = entity.OverallProductionCostListFor627A.Sum(item => item.MMProductionCostOverallTotalCost);
            else if (accountNo == ProductionCostAccounts.ChiPhiChungNhaMay6279)
                mainObject.OverallProductionCostFor6274AppropriationAmount = entity.OverallProductionCostListFor6279.Sum(item => item.MMProductionCostOverallTotalCost);
        }

        private void BindingDataSource()
        {
            ProductionCostEntities entity = (ProductionCostEntities)CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OverallProductionCostListFor622;
            OverallProductionCostFor622GridControl.DataSource = entity.OverallProductionCostListFor622;

            bds = new BindingSource();
            bds.DataSource = entity.OverallProductionCostListFor627;
            OverallProductionCostFor627GridControl.DataSource = bds;

            bds = new BindingSource();
            bds.DataSource = entity.OverallProductionCostListFor6279;
            OverallProductionCostFor6279GridControl.DataSource = bds;

            bds = new BindingSource();
            bds.DataSource = entity.OverallProductionCostListFor627A;
            OverallProductionCostFor627AGridControl.DataSource = bds;
        }

        private void InitializeOverallProductionCostGridControls()
        {
            OverallProductionCostFor622GridControl = (MMProductionCostOverallsGridControl)Controls[OverallProductionCostFor622GridControlName];
            OverallProductionCostFor627GridControl = (MMProductionCostOverallsGridControl)Controls[OverallProductionCostFor627GridControlName];
            OverallProductionCostFor627AGridControl = (MMProductionCostOverallsGridControl)Controls[OverallProductionCostFor627AGridControlName];
            OverallProductionCostFor6279GridControl = (MMProductionCostOverallsGridControl)Controls[OverallProductionCostFor6279GridControlName];
            BindingDataSource();
        }

        /// <summary>
        /// Get current selected item by accountno
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        private MMProductionCostOverallsInfo GetCurrentObject(string accountNo)
        {
            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            int currentIndex = -1;
            MMProductionCostOverallsInfo overallProductionCost = null;

            if (accountNo == ProductionCostAccounts.ChiPhiNhanCongTrucTiep)
            {
                currentIndex = entity.OverallProductionCostListFor622.CurrentIndex;
                if (currentIndex >= 0)
                    overallProductionCost = entity.OverallProductionCostListFor622[currentIndex];
            }
            else if (accountNo == ProductionCostAccounts.ChiPhiSanXuatChung)
            {
                currentIndex = entity.OverallProductionCostListFor627.CurrentIndex;
                if (currentIndex >= 0)
                    overallProductionCost = entity.OverallProductionCostListFor627[currentIndex];
            }
            else if (accountNo == ProductionCostAccounts.ChiPhiChungNhaMay627A)
            {
                currentIndex = entity.OverallProductionCostListFor627A.CurrentIndex;
                if (currentIndex >= 0)
                    overallProductionCost = entity.OverallProductionCostListFor627A[currentIndex];
            }
            else if (accountNo == ProductionCostAccounts.ChiPhiChungNhaMay6279)
            {
                currentIndex = entity.OverallProductionCostListFor6279.CurrentIndex;
                if (currentIndex >= 0)
                    overallProductionCost = entity.OverallProductionCostListFor6279[currentIndex];
            }
            //else if (accountNo == ProductionCostAccounts.ChiPhiDichVuMuaNgoai)
            //{
            //    currentIndex = entity.OverallProductionCostListFor6277.CurrentIndex;
            //    if (currentIndex >= 0)
            //        overallProductionCost = entity.OverallProductionCostListFor6277[currentIndex];
            //}
            //else if (accountNo == ProductionCostAccounts.ChiPhiChungNhaMay)
            //{
            //    currentIndex = entity.OverallProductionCostListFor6278.CurrentIndex;
            //    if (currentIndex >= 0)
            //        overallProductionCost = entity.OverallProductionCostListFor6278[currentIndex];
            //}

            return overallProductionCost;
        }

        public DataTable GetBatchs()
        {
            ProductionCostEntities entity = CurrentModuleEntity as ProductionCostEntities;
            MMBatchProductsController batchController = new MMBatchProductsController();
            DataTable dt = new DataTable();
            DataColumn column = new DataColumn();
            column.ColumnName = "MMBatchProductID";
            column.DataType = typeof(int);
            dt.Columns.Add(column);
            column = new DataColumn();
            column.ColumnName = "MMBatchProductNo";
            column.DataType = typeof(string);
            dt.Columns.Add(column);
            DataRow newRow;
            List<MMBatchProductsInfo> list = new List<MMBatchProductsInfo>();
            foreach (MMProductionCostItemsInfo productionCostItem in entity.ProductionCostItemList)
            {
                MMBatchProductsInfo batch = batchController.GetObjectByID(productionCostItem.FK_MMBatchProductID) as MMBatchProductsInfo;
                if (batch != null)
                {
                    bool hasExist = list.Any(item => item.MMBatchProductID == batch.MMBatchProductID);
                    if (!hasExist)
                    {
                        list.Add(batch);
                        newRow = dt.NewRow();
                        batchController.GetDataRowFromBusinessObject(newRow, batch);
                        dt.Rows.Add(newRow);
                    }
                }
            }
            return dt;
        }

        #endregion Overall production cost
    }
}
