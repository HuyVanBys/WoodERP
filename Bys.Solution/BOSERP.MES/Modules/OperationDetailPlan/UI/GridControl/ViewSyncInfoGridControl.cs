using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class ViewSyncInfoGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = new BOSList<MMOperationDetailPlanCapacityItemsInfo>();
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.Columns.Clear();
            AddColumnsToGridView(gridView);
            gridView.OptionsBehavior.KeepFocusedRowOnUpdate = true;
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0 && e.Column.FieldName == "MMOperationDetailPlanCapacityItemCanSync")
            {
                MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(e.RowHandle);
                if (item != null)
                {
                    if (item.MMOperationDetailPlanCapacityItemCanSync < item.MMOperationDetailPlanCapacityItemTotalProductQty && !string.IsNullOrEmpty(item.MMOperationName))
                    {
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                }
            }
        }


        public void AddColumnsToGridView(GridView gridView)
        {
            GridColumn column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemProductNo";
            column.Caption = "Mã chi tiết";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemProductName";
            column.Caption = "Tên chi tiết";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationName";
            column.Caption = "CĐ kiểm tra đồng bộ";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemTotalProductQty";
            column.Caption = "SL định mức";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemCanReceipt";
            column.Caption = "Tổng SL đã nhập";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemSynchedQty";
            column.Caption = "SL đã sử dụng";
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 6;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemCanSync";
            column.Caption = "SL còn lại có thể đồng bộ";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SyncProductType";
            column.Caption = "Loại đồng bộ";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

        }
    }
}
