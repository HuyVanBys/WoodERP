using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductProfileGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductProfilesList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }
        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Ghi chú";
            column.FieldName = "ICProductProfileComment";
            column.Visible = true;
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Link";
            column.FieldName = "ICProductProfileLink";
            column.Visible = true;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Open";
            column.FieldName = "Open";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Open";
            rep1.Click += new EventHandler(open_Click);
            column.ColumnEdit = rep1;
            column.Visible = true;
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        public void open_Click(object sender, EventArgs e)
        {
            ((ProductModule)Screen.Module).ShowProfileLink();
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)MainView;
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).DeleteItemFromProductProfileList();
                if (gridView.FocusedRowHandle > 0)
                {
                    ICProductProfilesController objProductProfilesController = new ICProductProfilesController();
                    ICProductProfilesInfo item = (ICProductProfilesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item.ICProductProfileID > 0)
                    {
                        objProductProfilesController.DeleteObject(item.ICProductProfileID);
                    }
                }
            }
        }
    }
}
