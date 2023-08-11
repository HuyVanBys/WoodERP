using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP107APProposalItemsGridControl : BOSGridControl
    {
        public void LoadGridViewByProductType(string productType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemProductHeight"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemProductWidth"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemProductLenght"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemProductWidthMax"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 9;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemProductLenghtMax"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["APProposalItemProductQty"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Caption = ReportLocalizedResources.ProductQty1;
                    column.Visible = true;
                    column.VisibleIndex = 13;
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
