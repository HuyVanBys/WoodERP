using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductItemsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductItemList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.ViewCollection[0];
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
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
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;

            //AddColumnGridView("Selected", "Chọn", true, 1, gridView);
            AddColumnGridView("ICProductItemQty", "Số lượng", true, 2, gridView);
            if (gridView.Columns["ICProductItemQty"] != null)
            {
                RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
                rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                rep.Mask.EditMask = "n6";
                rep.Mask.UseMaskAsDisplayFormat = true;
                gridView.Columns["ICProductItemQty"].ColumnEdit = rep;
            }
            AddColumnGridView("ICProductNo", "Mã sản phẩm", false, 3, gridView);
            AddColumnGridView("ICProductName", "Tên sản phẩm", false, 4, gridView);
            AddColumnGridView("ICProductCode", "Mã code", false, 5, gridView);
            AddColumnGridView("ICProductLength", "Dài", false, 6, gridView);
            AddColumnGridView("ICProductWidth", "Rộng", false, 7, gridView);
            AddColumnGridView("ICProductHeight", "Dày", false, 8, gridView);

            return gridView;
        }
        public void AddColumnGridView(string FieldName, string caption, bool allowEdit, int visibleIndex, GridView view)
        {
            GridColumn column = new GridColumn();
            column.OptionsColumn.AllowEdit = allowEdit;
            column.Caption = caption;
            column.FieldName = FieldName;
            column.VisibleIndex = visibleIndex;
            view.Columns.Add(column);
        }

        void gridview_DoubleClick(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
                if (product != null)
                    ((CarcassBOMModule)Screen.Module).ShowProductStructureForm(product);
            }
        }
    }
}
