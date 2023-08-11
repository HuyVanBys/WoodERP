using DevExpress.XtraGrid.Columns;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefund
{
    public class HRAdvanceRefundTemplatesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundEntities entity = (AdvanceRefundEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AdvanceRefundTemplatesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên người tạo";
            column.FieldName = "UserCreatedFullname";
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            GridColumn column = gridView.Columns["UserCreatedFullname"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((AdvanceRefundModule)Screen.Module).RemoveAdvanceRefundTemplatesList();
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((AdvanceRefundModule)Screen.Module).DownloadDocument();
        }
    }
}
