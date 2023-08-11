using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.Project
{
    public class PMProjectNormHistorysGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProjectEntities entity = (ProjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProjectNormHistorysList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();



            GridColumn column = gridView.Columns["PMProjectNormHistoryDate"];
            if (column != null)
            {
                RepositoryItemDateEdit repositoryItemDateEdit = new RepositoryItemDateEdit();

                repositoryItemDateEdit.AutoHeight = false;
                repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
                repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                repositoryItemDateEdit.EditFormat.FormatString = "HH:mm:ss";
                repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
                repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                repositoryItemDateEdit.Name = "repositoryItemDateEdit";
                column.ColumnEdit = repositoryItemDateEdit;
            }

            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "PMProjectNormHistoryDetailColumnName")
            {
                if (e.Value != null)
                {
                    AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
                    AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objColumnAliasController.GetAAColumnAliasByColumnNameAndTableName(e.Value.ToString(), TableName.PMProjectNormsTableName);
                    if (objColumnAliasInfo != null)
                        e.DisplayText = objColumnAliasInfo.AAColumnAliasCaption;
                    else
                        e.DisplayText = e.Value.ToString();
                }
            }
        }
    }
}
