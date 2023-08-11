using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class ChooseOperationProcessInfosGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<MMBatchProductItemOperationInfosInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                // columns.VisibleIndex = 100;
                columns.Visible = false;
            }
            if (gridView.Columns["MMBatchProductProductionNormItemSerialNo"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemSerialNo"].Visible = true;
                gridView.Columns["MMBatchProductProductionNormItemSerialNo"].VisibleIndex = 0;
                gridView.Columns["MMBatchProductProductionNormItemSerialNo"].Group();
            }
            if (gridView.Columns["Selected"] != null)
            {
                gridView.Columns["Selected"].Visible = true;
                gridView.Columns["Selected"].VisibleIndex = 1;
            }

            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 2;
            }

            if (gridView.Columns["ICProductName"] != null)
            {
                gridView.Columns["ICProductName"].Visible = true;
                gridView.Columns["ICProductName"].VisibleIndex = 3;
            }

            if (gridView.Columns["MMBatchProductProductionNormItemNo"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemNo"].Visible = true;
                gridView.Columns["MMBatchProductProductionNormItemNo"].VisibleIndex = 4;
            }

            if (gridView.Columns["MMBatchProductProductionNormItemProductName"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemProductName"].Visible = true;
                gridView.Columns["MMBatchProductProductionNormItemProductName"].VisibleIndex = 5;
            }

            if (gridView.Columns["MMBatchProductProductionNormItemQuantity"] != null)
            {
                gridView.Columns["MMBatchProductProductionNormItemQuantity"].Visible = true;
                gridView.Columns["MMBatchProductProductionNormItemQuantity"].VisibleIndex = 6;
            }
            gridView.ExpandAllGroups();
            return gridView;
        }


        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã lô SX";
            column.FieldName = "MMBatchProductProductionNormItemSerialNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã hàng";
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên hàng";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã BTP";
            column.FieldName = "MMBatchProductProductionNormItemNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL SX";
            column.FieldName = "MMBatchProductProductionNormItemQuantity";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
