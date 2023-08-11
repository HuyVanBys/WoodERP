using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public class RP123GridControls : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMProductIsReuse";
            column.Caption = "Chọn";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã vật tư";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName";
            column.Caption = "Tên vật tư";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = "Khách hàng";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemQuantity";
            column.Caption = "Số lượng ĐM";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLVuotDM";
            column.Caption = "Số lượng vượt ĐM";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemProductQty";
            column.Caption = "Số lượng thực tế";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLdu";
            column.Caption = "Số lượng dư";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemProductQtyRedundant";
            column.Caption = "SL trả lại kho";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemComment";
            column.Caption = "Ghi chú";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);


            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
            {
                if (e.Value != null)
                {
                    double qty = 0;
                    if (double.TryParse(e.Value.ToString(), out qty))
                    {
                        e.DisplayText = qty.ToString("N4");
                    }
                }
            }
        }
    }
}
