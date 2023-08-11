using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseProposal
{
    public partial class APProductsOfProposalItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReferredProposalItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = CancelPurchaseProposalLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = CancelPurchaseProposalLocalizedResources.APProposalNoMessage;
            column.FieldName = "APProposalNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loại";
            column.FieldName = "APPurchaseProposalTypeVN";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "MMBatchProductSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["APPurchaseProposalTypeVN"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 0;
            }

            column = gridView.Columns["APProposalNo"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 1;
            }

            column = gridView.Columns["APCancelPurchaseProposalItemProductDesc"];
            if (column != null)
            {
                column.Visible = true;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductQtyOld"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n5}";
                column.Visible = true;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemProductQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n5}";
                column.Visible = true;
            }
            column = gridView.Columns["APCancelPurchaseProposalItemPurchaseOrderQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n5}";
                column.Visible = true;
            }
            column = gridView.Columns["APPurchaseProposalItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseProposalType + "Search"]);
                column.ColumnEdit = rep;
            }
            return gridView;
        }
    }
}
