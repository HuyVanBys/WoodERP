using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public class ICReceiptItemPrintQRCodesGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<ICReceiptItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            GridColumn columnSelect = new GridColumn();
            columnSelect.Caption = BaseLocalizedResources.Select;
            columnSelect.FieldName = "Selected";
            columnSelect.OptionsColumn.AllowEdit = true;
            columnSelect.VisibleIndex = 0;
            gridView.Columns.Insert(0, columnSelect);
            return gridView;
        }
    }
}
