using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADTemplateToolbarsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TemplateToolbarsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = gridView.Columns["FK_STToolbarID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "STToolbarDesc";
                repositoryItemLookUpEdit.ValueMember = "STToolbarID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STModuleName", "Mã Module"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STModuleDescriptionDescription", "Tên Module"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STToolbarDesc", "Toolbar"));
                System.Data.DataSet ds = new ADTemplateToolbarsController().GetToolBarForAssignTemplate();
                if (ds != null && ds.Tables.Count > 0)
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditReportToolbar_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ADTemplateID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADTemplateNo";
                repositoryItemLookUpEdit.ValueMember = "ADTemplateID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADTemplateNo", "Mã mẫu in"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADTemplateName", "Tên mẫu in"));
                System.Data.DataSet ds = new ADTemplatesController().GetAllObjects();
                if (ds != null && ds.Tables.Count > 0)
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
        }

        private void repositoryItemLookUpEditReportToolbar_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            System.Data.DataSet ds = new ADReportsController().GetReportsForToolbar();
            if (ds != null && ds.Tables.Count > 0)
            {
                lookUpEdit.Properties.DataSource = ds.Tables[0];
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);

            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedTemplateToolbars();
            }
        }
    }
}
