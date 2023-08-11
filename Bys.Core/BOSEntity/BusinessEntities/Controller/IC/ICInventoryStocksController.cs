using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP
{
    #region ICInventoryStocks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICInventoryStocksController
    //Created Date:Monday, March 24, 2008
    //-----------------------------------------------------------

    public class ICInventoryStocksController : BaseBusinessController
    {

        private readonly string spGetInventoryStockByProductAndStock =
                                "ICInventoryStocks_SelectByProductAndStock";

        private readonly string spGetTotalStockQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockQuantityByProduct";


        private readonly string spGetTotalStockProposalQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockProposalQuantityByProduct";

        private readonly string spGetTotalStockSaleOrderQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockSaleOrderQuantityByProduct";

        private readonly string spGetTotalStockPurchaseOrderQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockPurchaseOrderQuantityByProduct";

        public ICInventoryStocksController()
        {
            dal = new DALBaseProvider("ICInventoryStocks", typeof(ICInventoryStocksInfo));
        }

        public ICInventoryStocksInfo GetInventoryStockByProductAndStock(int iICProductID, int iICStockID)
        {
            return (ICInventoryStocksInfo)dal.GetDataObject(
                                                    "ICInventoryStocks_GetInventoryStockByStockIDAndProductID",
                                                    iICStockID,
                                                    iICProductID);
        }
        public ICInventoryStocksInfo GetInventoryStockByProductID(int productID)
        {
            return (ICInventoryStocksInfo)dal.GetDataObject(
                                                    "ICInventoryStocks_GetInventoryStockByProductID",
                                                    productID);
        }
        //public decimal GetStockQuantityByProductAndStock(int iICProductID, int iICStockID)
        //{
        //    decimal dbStockQuantity = 0;
        //    ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
        //    if (objICInventoryStockInfo != null)
        //        dbStockQuantity = objICInventoryStockInfo.ICInventoryStockQuantity;

        //    return dbStockQuantity;
        //}

        //public decimal GetStockProposalQuantityByProductAndStock(int iICProductID, int iICStockID)
        //{
        //    decimal dbStockProposalQuantity = 0;
        //    ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
        //    if (objICInventoryStockInfo != null)
        //        dbStockProposalQuantity = objICInventoryStockInfo.ICInventoryStockProposalQuantity;

        //    return dbStockProposalQuantity;
        //}

        //public decimal GetStockSaleOrderQuantityByProductAndStock(int iICProductID, int iICStockID)
        //{
        //    decimal dbStockSaleOrderQuantity = 0;
        //    ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
        //    if (objICInventoryStockInfo != null)
        //        dbStockSaleOrderQuantity = objICInventoryStockInfo.ICInventoryStockSaleOrderQuantity;

        //    return dbStockSaleOrderQuantity;
        //}

        //public decimal GetStockPurchaseOrderQuantityByProductAndStock(int iICProductID, int iICStockID)
        //{
        //    decimal dbStockPurchaseOrderQuantity = 0;
        //    ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
        //    if (objICInventoryStockInfo != null)
        //        dbStockPurchaseOrderQuantity = objICInventoryStockInfo.ICInventoryStockPurchaseOrderQuantity;

        //    return dbStockPurchaseOrderQuantity;
        //}

        ///// <summary>
        ///// Get all inventory of a branch
        ///// </summary>
        ///// <param name="branchID">Branch id</param>
        ///// <returns>List of inventory records</returns>
        //public List<ICInventoryStocksInfo> GetInventoryStocksByBranchID(int branchID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksByBranchID", branchID);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds.Tables.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objInventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryStocks;
        //}

        ///// <summary>
        ///// Get inventory stocks by product id and group by stock id
        ///// </summary>
        ///// <param name="productID">The product id</param>
        ///// <param name="productID">The user group id</param>
        ///// <returns>List of inventory stocks</returns>
        //public List<ICInventoryStocksInfo> GetInventoryStocksByProductIDAndGroupByStockID(int productID, int userGroupID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksByProductIDAndGroupByStockID", productID, userGroupID);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objinventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryStocks;
        //}
        ///// <summary>
        ///// Get inventory stocks by product id and group by stock id
        ///// </summary>
        ///// <param name="productID">The product id</param>
        ///// <param name="productID">The user group id</param>
        ///// <returns>List of inventory stocks</returns>
        //public List<ICInventoryStocksInfo> GetInventoryStocksByProductIDAndGroupByStockIAndDesc(int productID, int userGroupID, string desc)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksByProductIDAndGroupByStockIAndDesc", productID, userGroupID, desc);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objinventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryStocks;
        //}
        //public List<ICInventoryStocksInfo> GetInventoryStocksForEquipment(int productID, int userGroupID, int modelID, int modelDetailID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksForEquipment", productID, userGroupID, modelID, modelDetailID);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objinventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryStocks;
        //}


        ///// <summary>
        ///// Get all inventory that can be viewed by an user group
        ///// </summary>
        ///// <param name="userGroupID">User group id</param>
        ///// <returns>Inventory data</returns>
        //public List<ICInventoryStocksInfo> GetInventoryStocksByUserGroupID(int userGroupID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksByUserGroupID", userGroupID);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds.Tables.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objInventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryStocks;
        //}

        ///// <summary>
        ///// Get all inventories
        ///// </summary>
        ///// <returns>List of all inventories</returns>
        //public List<ICInventoryStocksInfo> GetAllInventory()
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetAllInventory");
        //    List<ICInventoryStocksInfo> inventoryList = new List<ICInventoryStocksInfo>();
        //    ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
        //            objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.GetObjectFromDataRow(dr);
        //            inventoryList.Add(objInventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryList;
        //}

        ///// <summary>
        ///// Get inventory of a product of a stock defined by its type and 
        ///// the branch it belongs to
        ///// </summary>
        ///// <param name="productID">Product id</param>
        ///// <param name="stockType">Stock type</param>
        ///// <param name="branchID">Branch id</param>
        ///// <returns>Inventory object</returns>
        //public ICInventoryStocksInfo GetInventoryStockByProductIDAndStockTypeAndBranchID(int productID, string stockType, int branchID)
        //{
        //    return (ICInventoryStocksInfo)dal.GetDataObject("ICInventoryStocks_GetInventoryStockByProductIDAndStockTypeAndBranchID",
        //                                                    productID,
        //                                                    stockType,
        //                                                    branchID);
        //}

        /// <summary>
        /// Get inventory of a product in a stock by serie id
        /// </summary>
        /// <param name="stockID">Stock id</param>
        /// <param name="productID">Product id</param>
        /// <param name="serieID">Serie id</param>
        /// <returns>Inventory object</returns>
        public ICInventoryStocksInfo GetInventoryStockByStockIDAndProductIDAndSerieID(int stockID, int productID, int serieID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStockByStockIDAndProductIDAndSerieID", stockID, productID, serieID);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objInventoryStocksInfo;
            }
            ds.Dispose();
            return null;
        }

        ///// <summary>
        ///// Get an inventory record of a product by serie id
        ///// </summary>
        ///// <param name="productID">Product id</param>
        ///// <param name="serieID">Serie id</param>
        ///// <returns>Inventory data</returns>
        //public ICInventoryStocksInfo GetInventoryStockByProductIDAndSerieID(int productID, int serieID)
        //{
        //    return (ICInventoryStocksInfo)dal.GetDataObject("ICInventoryStocks_GetInventoryStocksByProductIDAndSerieID", productID, serieID);
        //}

        //public ICInventoryStocksInfo GetInventoryStocksByProductIDAndSerieIDOfSaleAndCentral(int productID, int serieID)
        //{
        //    return (ICInventoryStocksInfo)dal.GetDataObject("ICInventoryStocks_GetInventoryStocksByProductIDAndSerieIDOfSaleAndCentral", productID, serieID);
        //}

        /// <summary>
        /// Get all inventory of a product
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="serieID">Serie id</param>
        /// <returns>List of inventory</returns>
        public List<ICInventoryStocksInfo> GetInventoryStocksByProductIDAndSerieID(int productID, int serieID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksByProductIDAndSerieID", productID, serieID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }


        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            List<ICInventoryStocksInfo> inventoryList = new List<ICInventoryStocksInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.GetObjectFromDataRow(dr);
                    inventoryList.Add(objInventoryStocksInfo);
                }
            }
            ds.Dispose();
            return inventoryList;
        }

        /// <summary>
        /// Get total inventory cost of a product by date
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Total inventory cost</returns>
        public decimal GetTotalInventoryCost(int productID, int? stockID, DateTime? fromDate, DateTime? toDate)
        {
            decimal totalCost = 0;
            ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)dal.GetDataObject("ICInventoryStocks_GetTotalInventoryCost",
                                                                                                    productID,
                                                                                                    stockID,
                                                                                                    fromDate,
                                                                                                    toDate);
            if (objInventoryStocksInfo != null)
            {
                totalCost = objInventoryStocksInfo.ICProductReceiptAmount - objInventoryStocksInfo.ICProductShipmentAmount;
            }
            return totalCost;
        }

        /// <summary>
        /// Get total inventory cost of a product by date
        /// </summary>
        /// <param name="productID">Product id</param>        
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Total inventory cost</returns>
        public decimal GetTotalInventoryCost(int productID, DateTime? fromDate, DateTime? toDate)
        {
            return GetTotalInventoryCost(productID, null, fromDate, toDate);
        }

        /// <summary>
        /// Get total inventory quantity of a product by date
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Total inventory quantity</returns>
        public decimal GetTotalInventoryQty(int productID, int? stockID, DateTime? fromDate, DateTime? toDate)
        {
            decimal totalQty = 0;
            ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)dal.GetDataObject("ICInventoryStocks_GetTotalInventoryCost",
                                                                                                    productID,
                                                                                                    stockID,
                                                                                                    fromDate,
                                                                                                    toDate);
            if (objInventoryStocksInfo != null)
            {
                totalQty = objInventoryStocksInfo.ICProductReceiptQty - objInventoryStocksInfo.ICProductShipmentQty;
            }
            return totalQty;
        }

        /// <summary>
        /// Get total inventory quantity of a product by date
        /// </summary>
        /// <param name="productID">Product id</param>        
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Total inventory quantity</returns>
        public decimal GetTotalInventoryQty(int productID, DateTime? fromDate, DateTime? toDate)
        {
            return GetTotalInventoryQty(productID, null, fromDate, toDate);
        }

        ///// <summary>
        ///// Get inventory stocks that have initial quantity based on some criteria
        ///// </summary>
        ///// <param name="stockID">Stock id</param>
        ///// <param name="productID">Product id</param>
        ///// <returns>List of inventory stocks</returns>
        //public List<ICInventoryStocksInfo> GetInitInventoryStocks(int? stockID, int? productID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInitInventoryStocks", stockID, productID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}

        /// <summary>
        /// Get inventory stocks that have initial quantity based on some criteria
        /// </summary>
        /// <param name="stockID">Stock id</param>
        /// <param name="productID">Product id</param>
        /// <returns>List of inventory stocks</returns>
        public List<ICInventoryStocksInfo> GetInitInventoryStocksByStockNoList(int? productID, string stockNoList, int? accountID, int? supplierID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInitInventoryStocksByListOfStockNos", productID, stockNoList, accountID, supplierID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get inventory stocks that have initial quantity based on some criteria
        /// </summary>
        /// <param name="stockID">Stock id</param>
        /// <param name="productID">Product id</param>
        /// <returns>List of inventory stocks</returns>
        public List<ICInventoryStocksInfo> GetInitInventoryStocksByStockNoListAndBatchProductID(int? productID, string stockNoList, int? accountID, int? supplierID, int? batchProductID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInitInventoryStocksByStockNoListAndBatchProductID", productID, stockNoList, accountID, supplierID, batchProductID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }

        //public List<ICInventoryStocksInfo> GetInitInventoryStocksByListOfStockNosGroupByDesc(int? productID, string stockNoList, int? accountID, int? supplierID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInitInventoryStocksByListOfStockNosGroupByDesc", productID, stockNoList, accountID, supplierID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}

        public List<ICInventoryStocksInfo> GetInitInventoryStocksByListOfStockNosGroupByModel(int? productID, string stockNoList, int? accountID, int? supplierID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInitInventoryStocksByListOfStockNosGroupByModel", productID, stockNoList, accountID, supplierID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }

        ///// <summary>
        ///// Update the inventory cost of products specified by a number
        ///// </summary>
        ///// <param name="productNo">Product no</param>
        ///// <param name="cost">Updated inventory cost</param>
        //public void UpdateInventoryCostByProductNo(string productNo, decimal cost)
        //{
        //    dal.ExecuteStoredProcedure("ICInventoryStocks_UpdateInventoryCostByProductNo", productNo, cost);
        //}

        /// <summary>
        /// Update the inventory cost of a product
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="cost">Updated cost</param>
        public void UpdateInventoryCostByProductID(int productID, decimal cost)
        {
            dal.ExecuteStoredProcedure("ICInventoryStocks_UpdateInventoryCostByProductID", productID, cost);
        }

        /// <summary>
        /// Get inventory for transferring
        /// </summary>
        /// <returns>List of transferred inventory</returns>
        public List<ICInventoryStocksInfo> GetInventoryStocksForTransferring(int companyID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksForTransferring", companyID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }
        public decimal GetICShipment_ICInventoryStockQuantity(int FK_ICProductSerieID, int FK_ICStockID, int FK_ICProductID)
        {
            Object obj = dal.GetSingleValue("ICShipment_ICInventoryStockQuantity", FK_ICProductSerieID, FK_ICStockID, FK_ICProductID);
            decimal Debt = 0;
            if (obj != null)
                decimal.TryParse(obj.ToString(), out Debt);

            return Debt;
        }
        public ICInventoryStocksInfo ICShipment_ICInventoryStockQuantity_WoodQty_UnitCost(int FK_ICProductSerieID, int FK_ICStockID, int FK_ICProductID)
        {
            return (ICInventoryStocksInfo)dal.GetDataObject("ICShipment_ICInventoryStockQuantity_WoodQty_UnitCost", FK_ICProductSerieID, FK_ICStockID, FK_ICProductID);
        }
        //public List<ICInventoryStocksInfo> GetInventoryStocksForAllocationPlan(int FK_ICProductID, string MMAllocationPlanItemProductDesc, int FK_ADUserGroupID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForAllocationPlan", FK_ICProductID, MMAllocationPlanItemProductDesc, FK_ADUserGroupID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetInventoryStocksForAllocationPlanForEquipment(int FK_ICProductID, int FK_ADUserGroupID, int FK_ICModelID, int FK_ICModelDetailID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForAllocationPlanForEquipment", FK_ICProductID, FK_ADUserGroupID, FK_ICModelID, FK_ICModelDetailID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetInventoryStocksForSaleOrder(int FK_ICProductID, string MMAllocationPlanItemProductDesc, int FK_ADUserGroupID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForSaleOrder", FK_ICProductID, MMAllocationPlanItemProductDesc, FK_ADUserGroupID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetInventoryStocksForSaleOrderForEquipment(int FK_ICProductID, int FK_ADUserGroupID, int modelID, int modelDetailID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForSaleOrderForEquipment", FK_ICProductID, FK_ADUserGroupID, modelID, modelDetailID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetInventoryStocksForPurchase(int FK_ICProductID, string MMAllocationPlanItemProductDesc, int FK_ADUserGroupID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForPurchase", FK_ICProductID, MMAllocationPlanItemProductDesc, FK_ADUserGroupID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetInventoryStocksForPurchaseEquipment(int FK_ICProductID, int FK_ADUserGroupID, int modelID, int modelDetailID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForPurchaseForEquipment", FK_ICProductID, FK_ADUserGroupID, modelID, modelDetailID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetEquipmentPurchaseOrderInventoryStock(int FK_ICProductID, int FK_ADUserGroupID, int modelID, int modelDetailID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetEquipmentPurchaseOrderInventoryStock", FK_ICProductID, FK_ADUserGroupID, modelID, modelDetailID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}

        //public List<ICInventoryStocksInfo> GetInventoryStocksForTransitOut(int FK_ICProductID, string MMAllocationPlanItemProductDesc, int FK_ADUserGroupID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetItemForTransitOut", FK_ICProductID, MMAllocationPlanItemProductDesc, FK_ADUserGroupID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}
        //public List<ICInventoryStocksInfo> GetEquipmentTransitOut(int FK_ICProductID, int FK_ADUserGroupID, int modelID, int modelDetailID)
        //{
        //    DataSet ds = dal.GetDataSet("ICInventoryStocks_GetEquipmentTransitOut", FK_ICProductID, FK_ADUserGroupID, modelID, modelDetailID);
        //    return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        //}

        public List<ICInventoryStocksInfo> GetInitInventoryStocksByStockNoListAndBatchProductIDAndProductType(int? productID, string stockNoList, int? accountID, int? supplierID, int? batchProductID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInitInventoryStocksByStockNoListAndBatchProductIDAndProductType", productID, stockNoList, accountID, supplierID, batchProductID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }
        public decimal GetInventoryStockUnitCost(int FK_ICProductID, string productSerieNo)
        {
            Object obj = dal.GetSingleValue("ICInventoryStocks_GetInventoryStockUnitCost", FK_ICProductID, productSerieNo);
            decimal Debt = -1;
            if (obj != null)
                decimal.TryParse(obj.ToString(), out Debt);

            return Debt;//Debt = -1 là chưa có đơn giá tồn kho
        }

        public List<ICInventoryStocksInfo> GetInventoryStocksForPurchaseProposal(int departmentID, int productGroupID, int productID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksForPurchaseProposal", departmentID, productGroupID, productID);
            List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
                    inventoryStocks.Add(objInventoryStocksInfo);
                }
            }
            return inventoryStocks;
        }

        public void UpdateCostAndReferenceDocsByAllocationCostID(int allocationCostID)
        {
            dal.ExecuteStoredProcedure("ICInventoryStocks_UpdateCostAndReferenceDocsByAllocationCostID", allocationCostID);
        }

        public void UpdateCostAndReferenceDocsByAllocationCostIDToOri(int allocationCostID)
        {
            dal.ExecuteStoredProcedure("ICInventoryStocks_UpdateCostAndReferenceDocsByAllocationCostIDToOri", allocationCostID);
        }

        public List<ICInventoryStocksInfo> GetInventoryStocksByProductIDAndStockID(int productID, int? stockID, int? serieID, int? userGroupID)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetInventoryStocksByProductIDAndStockID", productID, stockID, serieID, userGroupID);
            List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
                    inventoryStocks.Add(objinventoryStocksInfo);
                }
                ds.Dispose();
            }
            return inventoryStocks;
        }
        //public List<ICInventoryStocksInfo> GetInventoryStocksByListProductIDAndStockID(string productListID, int? stockID, int? serieID)
        //{
        //    DataSet ds = dal.GetDataSet("ICTransactions_GetInventoryStocksByListProductIDAndStockID", productListID, stockID, serieID);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objinventoryStocksInfo);
        //        }
        //        ds.Dispose();
        //    }
        //    return inventoryStocks;
        //}

        public ICInventoryStocksInfo GetSingleInventoryStockByStockIDAndProductIDAndSerieID(int? stockID, int productID, int? serieID, int? userGroupID)
        {
            List<ICInventoryStocksInfo> inventoryStocks = GetInventoryStocksByProductIDAndStockID(productID, stockID, serieID, userGroupID);
            if (inventoryStocks.Count() > 0)
            {
                ICInventoryStocksInfo objInventoryStocksInfo = inventoryStocks.First();
                return objInventoryStocksInfo;
            }
            return null;
        }

        //public ICInventoryStocksInfo GetAvailableInventoryStockQty(int productID, int userGroupID)
        //{
        //    return (ICInventoryStocksInfo)dal.GetDataObject("ICInventoryStocks_GetAvailableInventoryStockQty", productID, userGroupID);
        //}

        public List<ICInventoryStocksInfo> GetInventoryStocksByProductIDAndStockID(int productID, int? stockID)
        {
            DataSet ds = dal.GetDataSet("ICVitualTransactions_GetInventoryStocksByProductIDAndStockID", productID, stockID);
            List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
                    inventoryStocks.Add(objinventoryStocksInfo);
                }
            }
            ds.Dispose();
            return inventoryStocks;
        }

        //public List<ICInventoryStocksInfo> GetInventoryStocksByListProductIDAndStockID(string productID, int? stockID)
        //{
        //    DataSet ds = dal.GetDataSet("ICVitualTransactions_GetInventoryStocksByListProductIDAndStockID", productID, stockID);
        //    List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
        //    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ICInventoryStocksInfo objinventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(row);
        //            inventoryStocks.Add(objinventoryStocksInfo);
        //        }
        //    }
        //    ds.Dispose();
        //    return inventoryStocks;
        //}
        //public ICInventoryStocksInfo GetInventoryStockByProductID(int stockID, int productID, string productSerieNo, DateTime toDate)
        //{
        //    return (ICInventoryStocksInfo)dal.GetDataObject("ICTransactions_GetProductQty_WoodQty_UnitCost", stockID, productID, productSerieNo, toDate);
        //}

        public List<ICInventoryStocksInfo> GetInventoryStocksByProductIDAndSerieNoAndStockID(int productID, string serieNo, int StockID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetInventoryStocksByProductIDAndSerieNoAndStockID", productID, serieNo, StockID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }

        public List<ICInventoryStocksInfo> GetListAvailableInventoryStockQty(string strproductID)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetAvailableInventoryStockQty", strproductID);
            return (List<ICInventoryStocksInfo>)GetListFromDataSet(ds);
        }

        public ICInventoryStocksInfo GetWoodQtyByStockIDAndProductIDAndSerieID(int stockID, int productID, int serieID)
        {
            DataSet ds = dal.GetDataSet("ICInventoryStocks_GetWoodQtyByStockIDAndProductIDAndSerieID", stockID, productID, serieID);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objInventoryStocksInfo;
            }
            ds.Dispose();
            return null;
        }
    }
    #endregion
}