using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class HRTimeSheetParam2GridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTimeSheetParam2List;
            this.DataSource = bds;

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gridView.Columns.Remove(gridView.Columns["HRTimeSheetParamNight"]);
            gridView.Columns.Remove(gridView.Columns["IsAllowedLeave"]);

            GridColumn column = gridView.Columns["HRTimeSheetParamNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamValue1"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamValue2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRTimeSheetParamBonusTimeConfig"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsOTCalculated"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = "% tính lương";
            //column.FieldName = "HRTimeSheetParamValue2";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedTimeSheetParam2();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "HRTimeSheetParamNo")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyTimeSheetParamNoMessage;
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "HRTimeSheetParamName")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyTimeSheetParamNameMessage;
                        e.Valid = false;
                    }
                }
            }

        }
    }
}
