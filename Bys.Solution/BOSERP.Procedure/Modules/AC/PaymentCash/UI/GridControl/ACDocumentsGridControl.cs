using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentCash
{
    public partial class ACDocumentsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ACDocumentsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ACDocumentTotalAmount"];
            if (column != null)
            {
                column.Caption = PaymentCashLocalizedResources.ACDocumentTotalAmount.ToString();
            }

            column = gridView.Columns["ACDocumentExchangeAmount"];
            if (column != null)
            {
                column.Caption = PaymentCashLocalizedResources.ACDocumentExchangeAmount.ToString();
            }

            column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                column.Caption = PaymentCashLocalizedResources.FK_BRBranchID.ToString();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PaymentCashLocalizedResources.BankFee.ToString();
            column.FieldName = "ACDocumentBankFee";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PaymentCashLocalizedResources.BankExchangeFee.ToString();
            column.FieldName = "ACDocumentBankExchangeFee";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PaymentCashLocalizedResources.DocumentCashToAmount.ToString();
            column.FieldName = "ACDocumentCashToAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PaymentCashLocalizedResources.ACObjectName.ToString();
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)gridView.GetRow(e.RowHandle);
            if (objDocumentsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ACDocumentBankFee")
                {
                    objDocumentsInfo.ACDocumentBankExchangeFee = objDocumentsInfo.ACDocumentBankFee / objDocumentsInfo.ACDocumentExchangeRate;
                    objDocumentsInfo.ACDocumentCashToAmount = objDocumentsInfo.ACDocumentExchangeAmount - objDocumentsInfo.ACDocumentBankExchangeFee;
                }
            }
        }
    }
}
