using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class BatchProductItemHardwareDetailsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMBatchProductProductionNormItemHardwaresInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = false;

            if (gridView.Columns["MMBatchProductProductionNormItemHardwareQty"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemHardwareQty"].OptionsColumn.AllowEdit = true;
                InitColumnSummary("MMBatchProductProductionNormItemHardwareQty", DevExpress.Data.SummaryItemType.Sum);
            }
            if (gridView.Columns["MMBatchProductProductionNormItemHardwareDesc"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemHardwareDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
            }
            if (e.Column.FieldName == "FK_ICProductAlternativeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
            }
        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
