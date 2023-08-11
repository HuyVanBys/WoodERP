using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP107MMAllocationProposalItemsGridControl : BOSGridControl
    {
        public void LoadGridViewByProductType(string productType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 0;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemHeight"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemWidth"];
            if (column != null)
            {
                if (
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
            column = gridView.Columns["MMAllocationProposalItemLength"];
            if (column != null)
            {
                if (
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
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                if (
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
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                if (
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
            column = gridView.Columns["MMAllocationProposalItemQty"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Caption = ReportLocalizedResources.ProductQty1;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                else
                {
                    column.Caption = ReportLocalizedResources.ProductQty;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemCanceledQty"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 11;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemShippedQty"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 12;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalProductQtyRemain"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 13;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemComment"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString())
                {
                    column.Visible = false;
                }
                else
                {
                    column.Visible = true;
                    column.VisibleIndex = 14;
                }
            }
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 15;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 16;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemProductSerialNo"];
            if (column != null)
            {
                if (
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 17;
                }
                else if (productType == AllocationProposalProductType.RoundWood.ToString())
                {
                    column.Caption = ReportLocalizedResources.ProductSerialNo;
                    column.Visible = true;
                    column.VisibleIndex = 17;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 16;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemLotNo"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 18;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemHWQtySource"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = false;
                }
                else
                {
                    column.Visible = true;
                    column.VisibleIndex = 16;
                }
            }
            column = gridView.Columns["MMAllocationProposalItemBPProductionNormItemQty"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString() ||
                    productType == AllocationProposalProductType.FreshLumber.ToString())
                {
                    column.Visible = false;
                }
                else
                {
                    column.Visible = true;
                    column.VisibleIndex = 17;
                }
            }
        }
    }
}
