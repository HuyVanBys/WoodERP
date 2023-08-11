using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class STFieldFormatsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FieldFormatList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column != null && column.FieldName == "STFieldFormatGroupID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = "STFieldFormatGroupName";
                    repositoryItemLookUpEdit.ValueMember = "STFieldFormatGroupID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STFieldFormatGroupName", "Nhóm"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STFieldFormatGroupMaskEdit", "String format"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STFieldFormatGroupMaskType", "Type"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("STFieldFormatGroupDecimalRound", "Round"));
                    System.Data.DataSet ds = new STFieldFormatGroupsController().GetAllObjects();
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                    }
                    //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditReportToolbar_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);

            return gridView;
        }
        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)entity.ModuleObjects[TableName.ADTemplatesTableName];
            GridView gv = sender as GridView;
            if (objADTemplatesInfo == null || objADTemplatesInfo.ADTemplateID == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tạo và lưu mẫu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BeginInvoke(new MethodInvoker(gv.CancelUpdateCurrentRow));
                return;
            }

            base.GridView_InitNewRow(sender, e);
            STFieldFormatsInfo objItem = (STFieldFormatsInfo)gv.GetRow(e.RowHandle);
            objItem.STFieldFormatModuleName = "Report";
            objItem.STFieldFormatTableName = objADTemplatesInfo.ADTemplateDataSource;
        }
        protected override void GridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            base.GridView_ValidateRow(sender, e);
            if (e.Valid)
            {
                GridView gv = sender as GridView;
                STFieldFormatsInfo objItem = (STFieldFormatsInfo)gv.GetRow(e.RowHandle);
                if (objItem.STFieldFormatID == 0 && objItem.STFieldFormatGroupID > 0 && objItem.STFieldFormatTableName != string.Empty && objItem.STFieldFormatColumnName != string.Empty)
                    new STFieldFormatsController().CreateObject(objItem);
                else if (objItem.STFieldFormatID > 0 && objItem.STFieldFormatGroupID > 0 && objItem.STFieldFormatTableName != string.Empty && objItem.STFieldFormatColumnName != string.Empty)
                    new STFieldFormatsController().UpdateObject(objItem);
            }
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gv = sender as GridView;
                STFieldFormatsInfo objItem = (STFieldFormatsInfo)gv.GetFocusedRow();
                if (objItem != null)
                    new STFieldFormatsController().DeleteObject(objItem.STFieldFormatID);
                ((CompanyConstantModule)Screen.Module).RemoveSelectedFieldFormat();
            }
        }
    }
}
