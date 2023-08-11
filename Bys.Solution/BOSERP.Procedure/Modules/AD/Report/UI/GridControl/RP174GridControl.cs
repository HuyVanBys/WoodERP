using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public class RP174GridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemProductWoodType";
            column.Caption = "Loại gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TongM3TinhTheoPG";
            column.Caption = "Khối lượng tinh(m3)";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "KLGoXe";
            column.Caption = "Khối lượng gỗ xẻ(m3)";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "TongM3TinhGoTron";
            column.Caption = "Khối lượng gỗ tròn(m3)";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);


        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            // gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);


            if (gridView.Columns["TongM3TinhTheoPG"] != null)
            {

                SetFormat("TongM3TinhTheoPG", "n4", gridView);
            }
            if (gridView.Columns["KLGoXe"] != null)
            {

                SetFormat("KLGoXe", "n4", gridView);
            }
            if (gridView.Columns["TongM3TinhGoTron"] != null)
            {

                SetFormat("TongM3TinhGoTron", "n4", gridView);
            }

            return gridView;
        }


    }
}
