using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;


namespace BOSERP.Modules.FeePayment
{
    public partial class APFeePaymentTransfersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentTransferList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((FeePaymentModule)Screen.Module).RemoveSelectedTransfer();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã nhập chuyển kho";
            column.FieldName = "ICTransferNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "ICTransferDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


        }
    }
}
