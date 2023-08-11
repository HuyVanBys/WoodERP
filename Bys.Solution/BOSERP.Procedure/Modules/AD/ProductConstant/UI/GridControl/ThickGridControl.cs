using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class ThickGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ThickList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            //column.Caption = "Mã";
            //column.FieldName = "ICProductAttributeNo";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 1;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Độ dày";
            column.FieldName = "ICProductAttributeValue";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            return gridView;
        }


        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                entity.ThickList.RemoveSelectedRowObjectFromList();
            }
        }
    }
}
