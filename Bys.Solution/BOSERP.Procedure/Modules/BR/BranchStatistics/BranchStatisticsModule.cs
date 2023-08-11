using BOSLib;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using System;
using System.Data;
using System.Text;

namespace BOSERP.Modules.BranchStatistics
{
    public class BranchStatisticsModule : BaseModuleERP
    {
        #region Constants
        public const string AROwingInvoicesGridControlName = "fld_dgcAROwingInvoices";
        public const string APOwingInvoiceInsGridControlName = "fld_dgcAPOwingInvoiceIns";
        #endregion

        #region Variables for sale statistics
        private ChartControl DepartmentChart;
        #endregion

        public BranchStatisticsModule()
        {
            Name = "BranchStatistics";
            CurrentModuleEntity = new BranchStatisticsEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            //Init controls of sale statistics
            DepartmentChart = (ChartControl)Controls["fld_chcDepartmentSale"];
            DepartmentChart.BorderOptions.Visible = false;

            SaleSearch();
            RemindSaleOrder();
            ShowOwingInvoices();
        }

        #region Functions of sale statistics
        public void SaleSearch()
        {
            //Show product transaction info
            DateTime from = DateTime.MinValue;
            DateTime to = DateTime.Now;
            String query = GenerateInvoiceItemSearchQuery(from, to, 0, 0, 0, "ii.FK_ICProductID");
            BOSList<ARInvoiceItemsInfo> lstInvoiceItems = new BOSList<ARInvoiceItemsInfo>();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            DataSet ds = objInvoiceItemsController.GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                ICProductsController objProductControllers = new ICProductsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductControllers.GetObjectByID(Convert.ToInt32(row["FK_ICProductID"]));
                    ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectFromDataRow(row);
                    objInvoiceItemsInfo.ARInvoiceItemProductName = objProductsInfo.ICProductName;
                    objInvoiceItemsInfo.ARInvoiceItemProductName2 = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
                    objInvoiceItemsInfo.ARInvoiceItemProductDesc = objProductsInfo.ICProductDesc;
                    objInvoiceItemsInfo.ARInvoiceItemProductQty = Convert.ToDecimal(row["Qty"]);
                    objInvoiceItemsInfo.ARInvoiceItemNetAmount = Convert.ToDecimal(row["ExtPrice"]);
                    objInvoiceItemsInfo.ARInvoiceItemTotalCost = Convert.ToDecimal(row["ExtCost"]);
                    lstInvoiceItems.Add(objInvoiceItemsInfo);
                }
            }
            (Controls["fld_dgcARInvoiceItems"] as BOSComponent.BOSGridControl).DataSource = lstInvoiceItems;

            //Init department chart series
            DepartmentChart.Series.Clear();
            Series series = new Series(String.Empty, ViewType.Pie);
            (series.Label as PieSeriesLabel).LineVisible = true;
            (series.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Inside;
            (series.PointOptions as PiePointOptions).PointView = PointView.ArgumentAndValues;
            (series.PointOptions as PiePointOptions).PercentOptions.ValueAsPercent = true;
            (series.PointOptions as PiePointOptions).PercentOptions.PercentageAccuracy = 2;
            PieSeriesView seriesView = new PieSeriesView();
            seriesView.RuntimeExploding = false;
            series.View = seriesView;

            //Init series points
            ICDepartmentsController objDeparmentsController = new ICDepartmentsController();
            ds = objDeparmentsController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //Calculate total amount of department
                    ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDeparmentsController.GetObjectFromDataRow(row);
                    query = GenerateInvoiceItemSearchQuery(from, to, objDepartmentsInfo.ICDepartmentID, 0, 0, "d.ICDepartmentID");
                    DataSet ds1 = objInvoiceItemsController.GetDataSet(query);
                    if (ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
                    {
                        object objExtPrice = ds1.Tables[0].Rows[0]["ExtPrice"];
                        if (objExtPrice != DBNull.Value && Convert.ToDecimal(objExtPrice) > 0)
                        {
                            SeriesPoint seriesPoint = new SeriesPoint(objDepartmentsInfo.ICDepartmentName, new object[] { objExtPrice });
                            series.Points.Add(seriesPoint);
                        }
                    }
                }
            }
            DepartmentChart.Series.Add(series);

            //Show best customers
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("SELECT i.FK_ARCustomerID, SUM(i.ARInvoiceTotalAmount) AS TotalAmount FROM ARInvoices i");
            queryBuilder.Append(BOSUtil.NewLine + "INNER JOIN ARCustomers c ON c.ARCustomerID = i.FK_ARCustomerID");
            queryBuilder.Append(BOSUtil.NewLine + String.Format("WHERE i.AAStatus = 'Alive' AND c.AAStatus = 'Alive' AND i.FK_ARCustomerID > 0"));
            queryBuilder.Append(String.Format(" AND CONVERT(VARCHAR(10), '{0}', 112) <= CONVERT(VARCHAR(10), i.ARInvoiceDate, 112) AND CONVERT(VARCHAR(10), i.ARInvoiceDate, 112) <= CONVERT(VARCHAR(10), '{1}', 112)", from.ToString("yyyyMMdd"), to.ToString("yyyyMMdd")));
            queryBuilder.Append(BOSUtil.NewLine + "GROUP BY i.FK_ARCustomerID");
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ds = objInvoicesController.GetDataSet(queryBuilder.ToString());
            if (ds.Tables.Count > 0)
            {
                BOSList<ARInvoicesInfo> lstInvoices = new BOSList<ARInvoicesInfo>();
                decimal totalAmount = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectFromDataRow(row);
                    objInvoicesInfo.ARInvoiceTotalAmount = Convert.ToDecimal(row["TotalAmount"]);
                    totalAmount += objInvoicesInfo.ARInvoiceTotalAmount;
                    lstInvoices.Add(objInvoicesInfo);
                }
                for (int i = 0; i < lstInvoices.Count; i++)
                    if (lstInvoices[i].ARInvoiceTotalAmount < totalAmount / lstInvoices.Count)
                    {
                        lstInvoices.RemoveAt(i);
                        i--;
                    }
                (Controls["fld_dgcARInvoices"] as GridControl).DataSource = lstInvoices;
            }
        }

        public String GenerateInvoiceItemSearchQuery(DateTime from, DateTime to, int departmentID, int productGroupID, int supplierID, String groupBy)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(String.Format("SELECT {0}, SUM(ii.ARInvoiceItemProductQty) AS Qty, SUM(ii.ARInvoiceItemNetAmount) AS ExtPrice, SUM(ii.ARInvoiceItemTotalCost) AS ExtCost", groupBy));
            queryBuilder.Append(BOSUtil.NewLine + "FROM ARInvoiceItems ii");
            queryBuilder.Append(BOSUtil.NewLine + "INNER JOIN ARInvoices i ON ii.FK_ARInvoiceID = i.ARInvoiceID");
            queryBuilder.Append(BOSUtil.NewLine + "INNER JOIN ICProducts p ON ii.FK_ICProductID = p.ICProductID");
            queryBuilder.Append(BOSUtil.NewLine + "LEFT JOIN APSuppliers s ON p.FK_APSupplierID = s.APSupplierID");
            queryBuilder.Append(BOSUtil.NewLine + "INNER JOIN ICProductGroups pg ON p.FK_ICProductGroupID = pg.ICProductGroupID");
            queryBuilder.Append(BOSUtil.NewLine + "INNER JOIN ICDepartments d ON p.FK_ICDepartmentID = d.ICDepartmentID");
            queryBuilder.Append(BOSUtil.NewLine + String.Format("WHERE i.AAStatus = 'Alive' AND ii.AAStatus = 'Alive' AND p.AAStatus = 'Alive'"));

            queryBuilder.Append(String.Format(" AND CONVERT(VARCHAR(10), '{0}', 112) <= CONVERT(VARCHAR(10), i.ARInvoiceDate, 112) AND CONVERT(VARCHAR(10), i.ARInvoiceDate, 112) <= CONVERT(VARCHAR(10), '{1}', 112)", from.ToString("yyyyMMdd"), to.ToString("yyyyMMdd")));

            if (departmentID > 0)
                queryBuilder.Append(String.Format(" AND d.AAStatus = 'Alive' AND d.ICDepartmentID = {0}", departmentID));

            if (productGroupID > 0)
                queryBuilder.Append(String.Format(" AND pg.AAStatus = 'Alive' AND pg.ICProductGroupID = {0}", productGroupID));

            if (supplierID > 0)
                queryBuilder.Append(String.Format(" AND s.AAStatus = 'Alive' AND s.APSupplierID = {0}", supplierID));

            queryBuilder.Append(BOSUtil.NewLine + String.Format("GROUP BY {0}", groupBy));
            return queryBuilder.ToString();
        }
        #endregion

        #region Reminder
        public void RemindSaleOrder()
        {
            BranchStatisticsEntities entity = (BranchStatisticsEntities)CurrentModuleEntity;
            DataSet ds = new ARSaleOrdersController().GetSaleOrdersByTypeAndStatus(ADConfigValueUtility.cstOpenDocumentTypeLayBy, ADConfigValueUtility.cstOpenDocumentStatusNew);
            entity.ARSaleOrdersList.Invalidate(ds);
            entity.ARSaleOrdersList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Owing
        /// <summary>
        /// Show owing invoices
        /// </summary>
        public void ShowOwingInvoices()
        {
            BranchStatisticsEntities entity = (BranchStatisticsEntities)CurrentModuleEntity;

            //Show receivable owing invoices of customer
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            DataSet ds = objInvoicesController.GetTotalOwingOfAllCustomers();
            entity.AROwingInvoiceList.Invalidate(ds);
            entity.AROwingInvoiceList.GridControl.RefreshDataSource();

            //Show payable owing invoices to supplier
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            ds = objInvoiceInsController.GetTotalOwingOfAllSuppliers();
            entity.APOwingInvoiceInList.Invalidate(ds);
            entity.APOwingInvoiceInList.GridControl.RefreshDataSource();
        }
        #endregion
    }
}
