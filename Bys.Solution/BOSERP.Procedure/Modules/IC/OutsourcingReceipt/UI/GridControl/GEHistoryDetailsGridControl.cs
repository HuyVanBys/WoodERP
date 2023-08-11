using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt
{
    public class GEHistoryDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OutsourcingReceiptEntities entity = (OutsourcingReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HistoryDetailList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.AAColumnAliasCaption;
            column.FieldName = "AAColumnAliasCaption";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.ADUserName;
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
            column.Caption = PurchaseReceiptLocalizedResources.GEObjectHistoryDate;
            column.FieldName = "GEObjectHistoryDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
