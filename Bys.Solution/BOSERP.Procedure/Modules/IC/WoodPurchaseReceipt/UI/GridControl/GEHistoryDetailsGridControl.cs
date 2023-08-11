using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPurchaseReceipt
{
    public class GEHistoryDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HistoryDetailList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.AAColumnAliasCaption;
            column.FieldName = "AAColumnAliasCaption";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.ADUserName;
            column.FieldName = "ADUserName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.OldValueDisplayedText;
            column.FieldName = "OldValueDisplayedText";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.NewValueDisplayedText;
            column.FieldName = "NewValueDisplayedText";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.GEObjectHistoryDate;
            column.FieldName = "GEObjectHistoryDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
