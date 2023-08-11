using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public partial class ARSaleOrdersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProjectEntities entity = (ProjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrdersList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Đối tượng";
            column.FieldName = "ACObjectAccessKey";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            ACObjectsController objObjectsController = new ACObjectsController();

            if (gridView.Columns["ACObjectAccessKey"] != null)
            {
                GridColumn column = gridView.Columns["ACObjectAccessKey"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            return gridView;
        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((ProjectModule)Screen.Module).RemoveSelectedItemFromProjectContactList();
            }
        }
    }
}
