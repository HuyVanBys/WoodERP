using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP097SaleForecastsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            #region SaleForeCasts
            column = new GridColumn();
            column.FieldName = "ARSaleForecastNo";
            column.Caption = ReportLocalizedResources.ARSaleForecastNorRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACObjectName";
            column.Caption = "Khách hàng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleForecastDate";
            column.Caption = ReportLocalizedResources.ARSaleForecastDateRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleForecastTotalProduct";
            column.Caption = ReportLocalizedResources.ARSaleForecastTotalProductRP;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";

            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleForecastTotalAmount";
            column.Caption = ReportLocalizedResources.ARSaleForecastTotalAmountRP;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ARSaleForecastPONo";
            column.Caption = ReportLocalizedResources.ARSaleForecastPONoRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleForecastPODate";
            column.Caption = ReportLocalizedResources.ARSaleForecastPODateRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);




            #endregion
            #region SaleOrder
            column = new GridColumn();
            column.FieldName = "ARSaleOrderNo";
            column.Caption = ReportLocalizedResources.ARSaleOrderNoRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ARSaleOrderDate";
            column.Caption = ReportLocalizedResources.ARSaleOrderDateRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ARSaleOrderTotalProduct";
            column.Caption = ReportLocalizedResources.ARSaleOrderTotalProductRP;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n0}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderTotalAmount";
            column.Caption = ReportLocalizedResources.ARSaleOrderTotalAmountRP;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderDeliveryDate";
            column.Caption = ReportLocalizedResources.ARSaleOrderDeliveryDateRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
            #endregion
            #region BatchProduct
            column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = ReportLocalizedResources.MMBatchProductNoRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductQty";
            column.Caption = ReportLocalizedResources.MMBatchProductItemProductQtyRP;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductDate";
            column.Caption = ReportLocalizedResources.MMBatchProductDateRP;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
            #endregion
            #region Invoice
            column = new GridColumn();
            column.FieldName = "ARInvoiceItemProductQty";
            column.Caption = "Số lượng giao hàng";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceTotalAmount";
            column.Caption = "Doanh số cho số lượng đã giao";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);
            #endregion
            #region Orther
            column = new GridColumn();
            column.FieldName = "Notassigned";
            column.Caption = "Số lượng chưa giao";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SaleforquantityChristian";
            column.Caption = "Doanh số cho số lượng chưa giao";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderStatus";
            column.Caption = "Tình trạng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            #endregion
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ARSaleForecastDate")
            {
                if (e.Value != null)
                {
                    DateTime dateTime = DateTime.MaxValue;
                    if (DateTime.TryParse(e.Value.ToString(), out dateTime))
                    {
                        if (dateTime.Year == 9999)
                            e.DisplayText = string.Empty;
                    }
                }
                else
                    e.DisplayText = string.Empty;
            }

            if (e.Column.FieldName == "ARSaleForecastPODate")
            {
                if (e.Value != null)
                {
                    DateTime dateTime = DateTime.MaxValue;
                    if (DateTime.TryParse(e.Value.ToString(), out dateTime))
                    {
                        if (dateTime.Year == 9999)
                            e.DisplayText = string.Empty;
                    }
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            List<string> notRemoveColumns = new List<string>()
            {
                "FK_GEPaymentTermID",
                "ARPaymentMethodCombo",
                "ARShippingType",
                "ARSaleForecastSaleType",
                "ARSaleForecastTransshipment",
                "FK_ARSellerID",
                "FK_HREmployeeID"
            };
            lstColumnAlias = lstColumnAlias.Where(o1 => notRemoveColumns.Contains(o1.AAColumnAliasName)).ToList();
            base.AddColumnsFromColumnAlias(strTableName, gridView, lstColumnAlias);
        }
    }
}
