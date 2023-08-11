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
    public partial class ADReportTemplatesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReportTemplatesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = gridView.Columns["FK_ADReportID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADReportNo";
                repositoryItemLookUpEdit.ValueMember = "ADReportID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADReportNo", "Mã báo cáo"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADReportName", "Tên báo cáo"));
                System.Data.DataSet ds = new ADReportsController().GetReportsForTemplate();
                if (ds != null && ds.Tables.Count > 0)
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditReportTemplate_QueryPopUp);
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

        private void repositoryItemLookUpEditReportTemplate_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            System.Data.DataSet ds = new ADReportsController().GetReportsForTemplate();
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
                ((CompanyConstantModule)Screen.Module).RemoveSelectedReportTemplates();
            }
        }
    }
}
