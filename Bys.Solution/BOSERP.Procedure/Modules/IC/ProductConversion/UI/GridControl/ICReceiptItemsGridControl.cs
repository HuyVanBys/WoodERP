using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ICReceiptItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn gridColumn = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (gridColumn != null)
            {
                gridColumn.Caption = "Mã lô hàng (Mã kiện)";
            }
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == matchCodeID);
                    e.DisplayText = objProductsInfo != null ? objProductsInfo.ICProductNo : string.Empty;
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã chứng từ";
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
