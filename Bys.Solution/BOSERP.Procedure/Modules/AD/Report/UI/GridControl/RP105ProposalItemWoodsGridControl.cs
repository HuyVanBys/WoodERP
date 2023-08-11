using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP105ProposalItemWoodsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Rộng (min)";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "APProposalItemProductMinWidth";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (min)";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "APProposalItemProductMinLenght";
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "APProposalItemProductQty")
                {
                    column.Caption = PurchaseProposalLocalizedResources.BlockQuanlity;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.Visible = true;
                }
                if (column.FieldName == "APProposalItemPurchaseOrderQty")
                {
                    column.Caption = PurchaseProposalLocalizedResources.APProposalItemPurchaseOrderQty;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.Visible = true;
                }
                if (column.FieldName == "APProposalItemProductHeight")
                {
                    column.Group();
                    column.GroupIndex = 0;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
                if (column.FieldName == "APProposalItemProductName")
                {
                    column.Group();
                    column.GroupIndex = 1;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
            }

            gridView.ExpandAllGroups();
            return gridView;
        }
    }
}
