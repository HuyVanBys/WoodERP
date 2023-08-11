using DevExpress.XtraEditors.Repository;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public class ARInvoiceItemCostGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            InvoiceEntities entity = (InvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARInvoiceItemCostList;
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

            if (gridView.Columns["ARInvoiceItemWorkProductQty"] != null)
            {
                gridView.Columns["ARInvoiceItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARInvoiceItemWorkProductUnitPrice"] != null)
            {
                gridView.Columns["ARInvoiceItemWorkProductUnitPrice"].OptionsColumn.AllowEdit = true;
                InitColumnRepositoryText(gridView.Columns["ARInvoiceItemWorkProductUnitPrice"], "n3");
            }
            if (gridView.Columns["ARInvoiceItemWorkComment"] != null)
            {
                gridView.Columns["ARInvoiceItemWorkComment"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARInvoiceItemWorkProductNo"] != null)
            {
                gridView.Columns["ARInvoiceItemWorkProductNo"].Caption = InvoiceLocalizedResources.ARInvoiceItemWorkProductNo;
            }
            if (gridView.Columns["ARInvoiceItemWorkProductName"] != null)
            {
                gridView.Columns["ARInvoiceItemWorkProductName"].Caption = InvoiceLocalizedResources.ARInvoiceItemWorkProductName;
            }
            if (gridView.Columns["ARInvoiceItemWorkTotalAmount"] != null)
            {
                InitColumnRepositoryText(gridView.Columns["ARInvoiceItemWorkTotalAmount"], "n3");
            }

            return gridView;
        }


        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            InvoiceEntities entity = (InvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARInvoiceItemCostList.CurrentIndex >= 0)
            {
                ARInvoiceItemWorksInfo item = entity.ARInvoiceItemCostList[entity.ARInvoiceItemCostList.CurrentIndex];
                if (e.Column.FieldName == "ARInvoiceItemWorkProductQty")
                {
                    ((InvoiceModule)Screen.Module).ChangeQty(item);
                }
                if (e.Column.FieldName == "ARInvoiceItemWorkProductUnitPrice")
                {
                    ((InvoiceModule)Screen.Module).ChangeQty(item);
                }
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceModule)Screen.Module).DeleteItemFromInvoiceItemCostsList();
            }
        }
    }
}
