using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductInProcesssGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductInProcessList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.ViewCollection[0];
            gridView.Name = "fld_dgv" + this.Name.Substring(7);
            gridView.OptionsBehavior.Editable = true;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.ShowDetailButtons = false;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsNavigation.EnterMoveNextColumn = true;
            gridView.OptionsNavigation.UseTabKey = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsCustomization.AllowFilter = true;
            gridView.OptionsCustomization.AllowQuickHideColumns = true;
            gridView.OptionsCustomization.AllowColumnResizing = true;
            gridView.GridControl = this;

            AddColumnGridView("ICProductNo", "Mã sản phẩm", false, 1, gridView);
            AddColumnGridView("ICProductName", "Tên sản phẩm", false, 2, gridView);
            AddColumnGridView("ICProductCode", "Mã code", false, 3, gridView);
            AddColumnGridView("ICProductLength", "Dài", false, 4, gridView);
            AddColumnGridView("ICProductWidth", "Rộng", false, 5, gridView);
            AddColumnGridView("ICProductHeight", "Dày", false, 6, gridView);
            AddColumnGridView("ICConfigProductionComplexityType", "Độ phức tạp sản xuất", false, 7, gridView);

            return gridView;
        }
        public void AddColumnGridView(string FieldName, string caption, bool allowEdit, int visibleIndex, GridView view)
        {
            GridColumn column = new GridColumn();
            if (FieldName == "ICConfigProductionComplexityType")
            {
                column.OptionsColumn.AllowEdit = allowEdit;
                column.Caption = caption;
                column.FieldName = FieldName;
                column.VisibleIndex = visibleIndex;
                RepositoryItemLookUpEdit rpConfigProductionComplexityType = new RepositoryItemLookUpEdit();
                rpConfigProductionComplexityType.DisplayMember = "ADConfigText";
                rpConfigProductionComplexityType.ValueMember = "ADConfigKeyValue";
                rpConfigProductionComplexityType.NullText = string.Empty;
                rpConfigProductionComplexityType.Columns.Add(new LookUpColumnInfo("ADConfigText", "Độ phức tạp"));
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ConfigProductionComplexityType.ToString());
                List<ADConfigValuesInfo> listConfigValues = new List<ADConfigValuesInfo>();
                if (ds != null && ds.Tables.Count > 0)
                {
                    listConfigValues = (List<ADConfigValuesInfo>)objConfigValuesController.GetListFromDataSet(ds);
                }
                rpConfigProductionComplexityType.DataSource = listConfigValues;
                column.ColumnEdit = rpConfigProductionComplexityType;
                view.Columns.Add(column);
            }
            else
            {
                column.OptionsColumn.AllowEdit = allowEdit;
                column.Caption = caption;
                column.FieldName = FieldName;
                column.VisibleIndex = visibleIndex;
                view.Columns.Add(column);
            }
        }
    }
}
