using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public class RP198MMProposalItemsGridControl : BOSGridControl
    {
        Dictionary<string, string> RP198Columns = new Dictionary<string, string>()
        {
            {"MMProposalItemRowNumber","STT"}
            , {"MMProposalNo","Mã đề nghị"}
            , {"MMProposalDate","Ngày đề nghị"}
            , {"MMProposalFromType","Loại đề nghi"}
            , {"ACObjectName","Đối tượng"}
            , {"HREmployeeName","Tên người lập"}
            , {"BRBranchName","Chi nhánh"}
            , {"MMProposalItemProductNo","Mã sản phẩm"}
            , {"MMProposalItemProductName","Tên sản phẩm"}
            , {"MMProposalItemProductDesc","Mô tả"}
            , {"MMProposalItemProductUnitPrice","Đơn giá"}
            , {"MMProposalItemTotalAmount","SThành tiền"}
            , {"ARSaleOrderNo","Mã đơn bán hàng"}
            , {"ARSaleOrderSaleAgreement","Số hợp đồng"}
            , {"MMProposalItemDeliveryDate","Ngày giao hàng"}
        };

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            RP198Columns.All(o =>
            {
                GridColumn column = new GridColumn();
                column.FieldName = o.Key;
                column.Caption = o.Value;
                column.OptionsColumn.AllowEdit = false;
                if (o.Key == "MMProposalItemProductUnitPrice" || o.Key == "MMProposalItemTotalAmount")
                    FormatNumbericColumn(column, false, "N3");
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

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            column.OptionsColumn.AllowEdit = allowEdit;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + formatType + "}"; ;
        }
    }
}
