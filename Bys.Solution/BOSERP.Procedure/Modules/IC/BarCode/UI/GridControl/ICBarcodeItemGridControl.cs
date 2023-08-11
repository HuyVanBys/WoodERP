using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Barcode
{
    public partial class ICBarcodeItemGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            BarcodeEntities entity = (BarcodeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BarcodeItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ICBarCodeItemBarcodeQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;

            gridView.OptionsView.ShowAutoFilterRow = true;

            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((BarcodeModule)Screen.Module).RemoveSelectedItemFromBarcodeList();
            }
        }
    }
}
