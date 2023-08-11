using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.BarCode
{
    public partial class ProductGridControl : BOSGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;

            gridView.OptionsView.ShowAutoFilterRow = true;

            return gridView;
        }
    }
}
