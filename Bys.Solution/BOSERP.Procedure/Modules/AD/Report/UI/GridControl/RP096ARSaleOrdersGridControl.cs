using BOSCommon;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Drawing;

namespace BOSERP.Modules.Report
{
    public class RP096ARSaleOrdersGridControl : BOSGridControl
    {


        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();


            if (gridView.Columns["ARSaleOrderNo"] != null)
            {
                gridView.Columns["ARSaleOrderNo"].Group();
            }

            if (gridView.Columns["ReportDocumentType"] != null)
            {
                gridView.Columns["ReportDocumentType"].Group();
            }

            //if (gridView.Columns["ReportObjectSubType"] != null)
            //{
            //    gridView.Columns["ReportObjectSubType"].Group();
            //}
            gridView.OptionsView.ShowFooter = true;

            gridView.OptionsView.RowAutoHeight = true;
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.GroupLevelStyle += new GroupLevelStyleEventHandler(gridView_GroupLevelStyle);
            InitStyles();
            return gridView;
        }

        private void InitStyles()
        {
            GridView View = this.MainView as GridView;
            // Customize the column headers' appearances. 
            AppearanceObject appCountry = View.Columns["ARSaleOrderNo"].AppearanceHeader;
            View.Columns["ARSaleOrderNo"].AppearanceHeader.Font = new Font(FontFamily.GenericSerif, 10, FontStyle.Bold);
            View.Columns["ARSaleOrderNo"].AppearanceHeader.ForeColor = Color.Black;
            appCountry.BackColor = Color.SkyBlue;
            appCountry.BackColor2 = Color.SkyBlue;
            View.Columns["ReportDocumentType"].AppearanceHeader.BackColor = Color.White;
            View.Columns["ReportDocumentType"].AppearanceHeader.Font = new Font(FontFamily.GenericSerif, 10, FontStyle.Bold);
            View.Columns["ReportDocumentType"].AppearanceHeader.ForeColor = Color.Black;
            // Set the View's painting syle. 
            //View.PaintStyleName = "UltraFlat";
        }


        void gridView_GroupLevelStyle(object sender, GroupLevelStyleEventArgs e)
        {
            GridView View = sender as GridView;
            GridColumn column = View.GroupedColumns[e.Level];
            if (column == null) return;
            else
            {
                e.LevelAppearance.Combine(column.AppearanceHeader);
            }
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ReportReferencesNo";
            column.Caption = ReportLocalizedResources.ReportReferencesNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportTotalAmount";
            column.Caption = ReportLocalizedResources.ReportTotalAmount;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportPaidAmount";
            column.Caption = ReportLocalizedResources.ReportPaidAmount;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportBalanceDueAmount";
            column.Caption = ReportLocalizedResources.ReportBalanceDueAmount;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportContractFromDate";
            column.Caption = ReportLocalizedResources.ReportContractFromDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportContractToDate";
            column.Caption = ReportLocalizedResources.ReportContractToDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportDocumentType";
            column.Caption = ReportLocalizedResources.ReportDocumentType;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportObjectSubType";
            column.Caption = ReportLocalizedResources.ReportDocumentType;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);



        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "ReportContractFromDate" || e.Column.FieldName == "ReportContractToDate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleOrdersInfo objPOsInfo = (ARSaleOrdersInfo)gridView.GetRow(gridView.FocusedRowHandle);

                //if (objPOsInfo.ReportObjectType == ReportRP096ObjectType.PurchaseOrder.ToString())
                //{
                //    APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                //    BOSERP.Modules.PurchaseOrder.PurchaseOrderModule purchaseOrderModule =
                //        (BOSERP.Modules.PurchaseOrder.PurchaseOrderModule)BOSApp.ShowModule("PurchaseOrder");
                //    if (purchaseOrderModule != null)
                //    { 
                //        APPurchaseOrdersInfo objOriginalsInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(objPOsInfo.ARSaleOrderNo);
                //        purchaseOrderModule.ActionInvalidate(objOriginalsInfo.APPurchaseOrderID);
                //    }
                //}
                //else if (objPOsInfo.ReportObjectType == ReportRP096ObjectType.InvoiceIn.ToString())
                //{
                //    APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                //    BOSERP.Modules.InvoiceIn.InvoiceInModule invoiceInModule =
                //        (BOSERP.Modules.InvoiceIn.InvoiceInModule)BOSApp.ShowModule("InvoiceIn");
                //    if (invoiceInModule != null)
                //    {
                //        APInvoiceInsInfo objOriginalsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByNo(objPOsInfo.ReportReferencesNo);
                //        invoiceInModule.ActionInvalidate(objOriginalsInfo.APInvoiceInID);
                //    }
                //}
                //else if (objPOsInfo.ReportObjectType == ReportRP096ObjectType.SupplierPayment.ToString())
                //{

                //    BOSERP.Modules.SupplierPayment.SupplierPaymentModule invoiceInModule =
                //        (BOSERP.Modules.SupplierPayment.SupplierPaymentModule)BOSApp.ShowModule("SupplierPayment");
                //    if (invoiceInModule != null)
                //    {
                //        invoiceInModule.ActionInvalidate(objPOsInfo.ARSaleOrderID);
                //    }
                //}
                if (objPOsInfo.ReportObjectType == ReportRP096ObjectType.SaleOrder.ToString())
                {
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    BOSERP.Modules.SaleOrder.SaleOrderModule saleOrderModule =
                        (BOSERP.Modules.SaleOrder.SaleOrderModule)BOSApp.ShowModule("SaleOrder");
                    if (saleOrderModule != null)
                    {
                        ARSaleOrdersInfo objOriginalsInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objPOsInfo.ARSaleOrderNo);
                        saleOrderModule.ActionInvalidate(objOriginalsInfo.ARSaleOrderID);
                    }
                }
                else if (objPOsInfo.ReportObjectType == ReportRP096ObjectType.Invoice.ToString())
                {
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    BOSERP.Modules.Invoice.InvoiceModule invoiceModule =
                        (BOSERP.Modules.Invoice.InvoiceModule)BOSApp.ShowModule("Invoice");
                    if (invoiceModule != null)
                    {
                        ARInvoicesInfo objOriginalsInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objPOsInfo.ReportReferencesNo);
                        invoiceModule.ActionInvalidate(objOriginalsInfo.ARInvoiceID);
                    }
                }
                else if (objPOsInfo.ReportObjectType == ReportRP096ObjectType.CustomerPayment.ToString())
                {

                    BOSERP.Modules.CustomerPayment.CustomerPaymentModule invoiceInModule =
                        (BOSERP.Modules.CustomerPayment.CustomerPaymentModule)BOSApp.ShowModule("CustomerPayment");
                    if (invoiceInModule != null)
                    {
                        invoiceInModule.ActionInvalidate(objPOsInfo.ARSaleOrderID);
                    }
                }

            }
        }

    }
}
