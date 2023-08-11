using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP107ReceiptItemWoodsGridControl : BOSGridControl
    {
        public void LoadGridViewByProductType(string productType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Caption = ReportLocalizedResources.ProductQty1;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                else
                {
                    column.Caption = ReportLocalizedResources.ProductQty;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
            }
        }
    }
}
