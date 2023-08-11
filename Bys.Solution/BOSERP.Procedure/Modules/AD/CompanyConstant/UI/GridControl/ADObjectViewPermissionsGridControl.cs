using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADObjectViewPermissionsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ObjectViewPermissionList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
            {
                SendKeys.Send("{TAB}");
                return;
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;

            GridColumn gridColumn = gridView.Columns["FK_STModuleID"];
            if (gridColumn != null)
            {
                STModulesController objModulesController = new STModulesController();
                List<STModulesInfo> moduleList = objModulesController.GetAllModulesByUserNameAndLanguageName(BOSApp.CurrentUser, BOSApp.CurrentLang);
                gridColumn.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit ModuleLookUpEdit = new RepositoryItemLookUpEdit();
                ModuleLookUpEdit.DisplayMember = "STModuleDescription";
                ModuleLookUpEdit.ValueMember = "STModuleID";
                ModuleLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                ModuleLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                ModuleLookUpEdit.NullText = string.Empty;
                ModuleLookUpEdit.Columns.Add(new LookUpColumnInfo("STModuleDescription", "Tên Module"));
                ModuleLookUpEdit.DataSource = moduleList;
                gridColumn.ColumnEdit = ModuleLookUpEdit;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveObjectViewPermissionList();
            }
        }
    }
}
