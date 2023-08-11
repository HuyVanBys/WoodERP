using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using DevExpress.XtraGrid.Views.Base;

namespace BOSERP.Modules.ClearInvoice
{
    public partial class ACDocumentsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ACDocumentTypeID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentVATFormNo"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentVoucherNo"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentVATSymbol"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentVATDocumentType"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentVATInvoiceNo"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentObjectTaxNumber"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentStatus"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ACDocumentAllotment"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_GECurrencyID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("GECurrencies", "GECurrencyID", int.Parse(e.Value.ToString()), "GECurrencyNo");
                }
            }
            else if (e.Column.FieldName == "FK_BRBranchID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("BRBranchs", "BRBranchID", int.Parse(e.Value.ToString()), "BRBranchName");
                }
            }
        }
    }
}

