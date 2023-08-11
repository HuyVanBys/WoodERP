using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;


namespace BOSERP.Modules.FeePayment
{
    public partial class ReceiptGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentReceiptList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((FeePaymentModule)Screen.Module).RemoveSelectedReceipt();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptNo;
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptDate;
            column.FieldName = "ICReceiptDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptPackNo;
            column.FieldName = "ICReceiptPackNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptInvoiceInNo;
            column.FieldName = "ICReceiptInvoiceInNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptTotalCost;
            column.FieldName = "ICReceiptTotalCost";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.APSupplierName;
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tiền phân bổ";
            column.FieldName = "APFeePaymentReceiptAllocationCost";
            column.DisplayFormat.FormatString = "{0:n2}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.RowStyle += GridView_RowStyle;
            return gridView;
        }
        private void GridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (e.RowHandle >= 0)
            {
                APFeePaymentReceiptsInfo item = (APFeePaymentReceiptsInfo)gridview.GetRow(e.RowHandle);
                if (item != null && item.IsExistShipment)
                {
                    e.Appearance.BackColor2 = Color.Red;
                    e.Appearance.BackColor = Color.Red;
                    e.HighPriority = true;
                }
            }
        }
    }
}
