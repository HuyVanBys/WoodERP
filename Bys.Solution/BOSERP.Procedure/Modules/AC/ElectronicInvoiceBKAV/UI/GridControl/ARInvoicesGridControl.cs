using System;
using System.Linq;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using BOSLib;

namespace BOSERP.Modules.ElectronicInvoiceBKAV
{
    public class ARInvoicesGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARInvoicesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        public enum InvoiceColumnName
        {
            FK_HREmployeeID,
            FK_BRBranchID,
            ARInvoiceStatus,
            ARInvoiceDepositBalance,
            ARInvoiceBalanceDue,
            ARInvoiceValidateDate,
            ARInvoiceDesc,
            ARInvoiceDeliveryDate,
            ARInvoicePaymentAmount,
            FK_ARSellerID,
            MMBatchProductNosList,
            ARInvoiceReference,
            ARSaleOrderSaleAgreement,
            FK_ACCostCenterID,
            ARInvoicePostedStatus,
            FK_ARCustomerContactPaymentID,
            FK_ICStockID,
            FK_ARCustomerID
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            new InvoiceColumnName[]
            {
                InvoiceColumnName.FK_HREmployeeID,
                InvoiceColumnName.FK_BRBranchID,
                InvoiceColumnName.ARInvoiceStatus,
                InvoiceColumnName.ARInvoiceDepositBalance,
                InvoiceColumnName.ARInvoiceBalanceDue,
                InvoiceColumnName.ARInvoiceValidateDate,
                InvoiceColumnName.ARInvoiceDesc,
                InvoiceColumnName.ARInvoiceDeliveryDate,
                InvoiceColumnName.ARInvoicePaymentAmount,
                InvoiceColumnName.FK_ARSellerID,
                InvoiceColumnName.MMBatchProductNosList,
                InvoiceColumnName.ARInvoiceReference,
                InvoiceColumnName.ARSaleOrderSaleAgreement,
                InvoiceColumnName.FK_ACCostCenterID,
                InvoiceColumnName.ARInvoicePostedStatus,
                InvoiceColumnName.FK_ARCustomerContactPaymentID,
                InvoiceColumnName.FK_ICStockID,
                InvoiceColumnName.FK_ARCustomerID
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => gridView.Columns.Remove(o));
            GridColumn column = gridView.Columns["ACObjectName"];
            if (column != null)
            {
                column.Caption = "Tên khách hàng";                
            }
            gridView.ExpandAllGroups();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ARDeliveryPlanNosList"; //Mượn tạm biến
            column.Caption = "Mã đơn bán hàng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerNo";
            column.Caption = "Mã khách hàng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerPaymentDetailDesc"; //Mượn tạm biến -> AROutputVATDocumentType
            column.Caption = "Loại hóa đơn";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ACEInvoiceTypeID";
            column.Caption = "Mã hóa đơn GTGT";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ACEInvoiceTypes", "ACEInvoiceTypeID", Int32.Parse(e.Value.ToString()), "ACEInvoiceTypeNo");
                }
                else
                {
                    e.DisplayText = string.Empty;
                }    
            }
        }
    }
}
