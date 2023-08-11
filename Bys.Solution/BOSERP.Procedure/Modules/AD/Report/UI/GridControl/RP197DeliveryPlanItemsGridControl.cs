using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public class RP197DeliveryPlanItemsGridControl : BOSGridControl
    {
        Dictionary<string, string> RP197Columns = new Dictionary<string, string>()
        {
            {"ARDeliveryPlanItemRowNumber",ReportLocalizedResources.ARSaleOrderItemRowNumber}
            , {"ARDeliveryPlanNo","Mã ĐNXK"}
            , {"ARDeliveryPlanItemSaleOrderNo","Mã đơn bán hàng"}
            , {"ACObjectName","Khách hàng"}
            , {"ARDeliveryPlanType","Loại kế hoạch (tuần/ngày)"}
            , {"ARDeliveryPlanItemProductNo","Mã sản phẩm"}
            , {"ARDeliveryPlanItemProductName","Tên sản phẩm"}
            , {"ARDeliveryPlanItemProductDesc","Mô tả"}
            , {"ARDeliveryPlanItemSaleOrderQty","SL đơn hàng"}
            , {"ARDeliveryPlanItemProductQty","SL kế hoạch"}
            , {"ARDeliveryPlanItemDeliveryQty","SL giao"}
            , {"ARDeliveryPlanItemShipmentQty","SL xuất kho"}
            , {"ARDeliveryPlanStatus","Trạng thái"}
            , {"ARDeliveryPlanItemDeliveryDate","Ngày giao hợp đồng"}
            , {"ARDeliveryPlanItemDeliveryActualDate","Ngày giao dự kiến"}
            , {"HREmployeeName","Người lập"}
            , {"ARDeliveryPlanDate","Ngày chứng từ"}
            , {"ARDeliveryPlanItemAddress","Địa chỉ giao hàng"}
            , {"ARSaleOrderName", "Mã đơn hàng nội bộ"}
        };

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            RP197Columns.All(o =>
            {
                GridColumn column = new GridColumn();
                column.FieldName = o.Key;
                column.Caption = o.Value;
                column.OptionsColumn.AllowEdit = false;
                gridView.Columns.Add(column);
                return true;
            });
        }

        protected override void InitGridViewColumns(GridView gridView)
        {
            base.InitGridViewColumns(gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            return gridView;
        }
    }
}
