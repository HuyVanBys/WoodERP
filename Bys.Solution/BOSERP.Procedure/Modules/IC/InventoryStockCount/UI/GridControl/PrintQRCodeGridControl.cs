using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStockCount
{
    public partial class PrintQRCodeGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            InventoryStockCountEntities entity = (InventoryStockCountEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PrintQCodeItemsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICInventoryStockCountItemPrintQty"] != null)
                InitColumnRepositoryText(gridView.Columns["ICInventoryStockCountItemPrintQty"], "n0");
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column;

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
            column.VisibleIndex = 0;

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Số lượng in";
            column.FieldName = "ICInventoryStockCountItemPrintQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        public void InitColumnRepositoryText(DevExpress.XtraGrid.Columns.GridColumn column, string fomatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = fomatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + fomatType + "}";
            column.OptionsColumn.AllowEdit = true;
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
