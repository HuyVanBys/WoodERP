using DevExpress.XtraEditors.Repository;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public class ARAcceptanceItemCostGridControl : ItemGridControl
    {
        private string[] EditColumns = new string[]
        {
            "ARAcceptanceItemWorkProductQty"
            , "ARAcceptanceItemWorkProductUnitPrice"
            , "ARAcceptanceItemWorkDiscountAmount"
            , "ARAcceptanceItemWorkDiscountPercent"
            , "ARAcceptanceItemWorkComment"
            , "ARAcceptanceItemWorkTaxAmount"
            , "ARAcceptanceItemWorkTaxPercent"
        };

        private string[] FormatNumberColumns = new string[]
        {
            "ARAcceptanceItemWorkProductQty"
            , "ARAcceptanceItemWorkProductUnitPrice"
            , "ARAcceptanceItemWorkDiscountAmount"
            , "ARAcceptanceItemWorkDiscountPercent"
            , "ARAcceptanceItemWorkTaxAmount"
            , "ARAcceptanceItemWorkTaxPercent"
        };

        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            AcceptanceEntities entity = (AcceptanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AcceptanceItemCostsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            EditColumns.ToList().ForEach(o => gridView.Columns[o].OptionsColumn.AllowEdit = true);
            FormatNumberColumns.ToList().ForEach(o => InitColumnRepositoryText(gridView.Columns[o], "n3"));

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AcceptanceModule)Screen.Module).DeleteItemAcceptanceItemCostsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            AcceptanceEntities entity = (AcceptanceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex >= 0)
            {
                if (e.Column.FieldName == "ARAcceptanceItemWorkProductQty"
                    || e.Column.FieldName == "ARAcceptanceItemWorkProductUnitPrice")
                {
                    ((AcceptanceModule)Screen.Module).ChangeCostQty();
                }
                if (e.Column.FieldName == "ARAcceptanceItemWorkDiscountAmount")
                    ((AcceptanceModule)Screen.Module).ChangeCostDiscountAmount();
                if (e.Column.FieldName == "ARAcceptanceItemWorkDiscountPercent")
                    ((AcceptanceModule)Screen.Module).ChangeCostDiscountPercent();
                if (e.Column.FieldName == "ARAcceptanceItemWorkTaxAmount")
                    ((AcceptanceModule)Screen.Module).ChangeCostTaxAmount();
                if (e.Column.FieldName == "ARAcceptanceItemWorkTaxPercent")
                    ((AcceptanceModule)Screen.Module).ChangeCostTaxPercent();
            }
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
