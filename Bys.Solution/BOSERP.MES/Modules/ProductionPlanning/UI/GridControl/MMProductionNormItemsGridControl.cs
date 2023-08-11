using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace BOSERP.Modules.ProductionPlanning
{
    public class MMProductionNormItemsGridControl : BOSGridControl
    {

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn collumn = new GridColumn();
            collumn = new GridColumn();
            collumn.FieldName = "Selected";
            collumn.Caption = "Chọn";
            gridView.Columns.Add(collumn);

            collumn = new GridColumn();
            collumn = new GridColumn();
            collumn.FieldName = "NgayETD";
            collumn.Caption = "Ngày ETD";
            gridView.Columns.Add(collumn);

            collumn = new GridColumn();
            collumn = new GridColumn();
            collumn.FieldName = "NgayChatCont";
            collumn.Caption = "Ngày chất cont";
            gridView.Columns.Add(collumn);

            collumn = new GridColumn();
            collumn = new GridColumn();
            collumn.FieldName = "NgayHangVe";
            collumn.Caption = "Thời gian hàng về";
            gridView.Columns.Add(collumn);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            foreach (GridColumn column in gridView.Columns)
                column.Visible = false;
            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].Group();
            }
            if (gridView.Columns["FK_MMProductionNormID"] != null)
            {
                gridView.Columns["FK_MMProductionNormID"].Group();
            }
            if (gridView.Columns["Selected"] != null)
            {
                gridView.Columns["Selected"].OptionsColumn.AllowEdit = true;
                gridView.Columns["Selected"].Visible = true;
                gridView.Columns["Selected"].VisibleIndex = 1;
            }
            if (gridView.Columns["MMProductionNormItemNo"] != null)
            {
                gridView.Columns["MMProductionNormItemNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["MMProductionNormItemNo"].Visible = true;
                gridView.Columns["MMProductionNormItemNo"].VisibleIndex = 2;
            }
            if (gridView.Columns["MMProductionNormItemProductDesc"] != null)
            {
                gridView.Columns["MMProductionNormItemProductDesc"].OptionsColumn.AllowEdit = false;
                gridView.Columns["MMProductionNormItemProductDesc"].Visible = true;
                gridView.Columns["MMProductionNormItemProductDesc"].VisibleIndex = 3;
            }
            if (gridView.Columns["MMProductionNormItemQuantity"] != null)
            {
                gridView.Columns["MMProductionNormItemQuantity"].OptionsColumn.AllowEdit = true;
                gridView.Columns["MMProductionNormItemQuantity"].Visible = true;
                gridView.Columns["MMProductionNormItemQuantity"].VisibleIndex = 4;
            }
            if (gridView.Columns["NgayETD"] != null)
            {
                gridView.Columns["NgayETD"].OptionsColumn.AllowEdit = true;
                gridView.Columns["NgayETD"].Visible = true;
                gridView.Columns["NgayETD"].VisibleIndex = 5;
            }
            if (gridView.Columns["NgayChatCont"] != null)
            {
                gridView.Columns["NgayChatCont"].OptionsColumn.AllowEdit = true;
                gridView.Columns["NgayChatCont"].Visible = true;
                gridView.Columns["NgayChatCont"].VisibleIndex = 6;
            }
            if (gridView.Columns["NgayHangVe"] != null)
            {
                gridView.Columns["NgayHangVe"].OptionsColumn.AllowEdit = true;
                gridView.Columns["NgayHangVe"].Visible = true;
                gridView.Columns["NgayHangVe"].VisibleIndex = 7;
            }
            if (gridView.Columns["MMProductionNormItemDesc"] != null)
            {
                gridView.Columns["MMProductionNormItemDesc"].OptionsColumn.AllowEdit = true;
                gridView.Columns["MMProductionNormItemDesc"].Visible = true;
                gridView.Columns["MMProductionNormItemDesc"].VisibleIndex = 8;
            }
            gridView.BestFitColumns();
            return gridView;
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                MMProductionNormItemsInfo objWoodPlanItemsInfo = (MMProductionNormItemsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "NgayHangVe" && (objWoodPlanItemsInfo.LeadTime == null || objWoodPlanItemsInfo.LeadTime == 0))
                {
                    e.Appearance.BackColor2 = Color.Yellow;
                }
                if (objWoodPlanItemsInfo.NgayHangVe > objWoodPlanItemsInfo.NgayChatCont)
                {
                    if (e.Column.FieldName == "NgayHangVe")
                        e.Appearance.BackColor2 = Color.Red;
                }
                //else
                //{
                //    if (e.Column.FieldName == "NgayHangVe")
                //        e.Appearance.BackColor2 = Color.White;
                //}
            }
        }

    }
}
