using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ElectronicInvoice
{
    public partial class EInvoiceTemplatesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ElectronicInvoiceEntities entity = (ElectronicInvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EInvoiceTemplateList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn gridColumn = new GridColumn();

            gridColumn = new GridColumn();
            gridColumn.Caption = SaleOrderLocalizedResources.DowloadTemplateCaption;
            gridColumn.FieldName = "DowloadFile";
            gridColumn.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemFile = new RepositoryItemHyperLinkEdit();
            rpItemFile.NullText = SaleOrderLocalizedResources.DowloadTemplateCaption;
            rpItemFile.Click += new EventHandler(RrpItemFile_Click);
            gridColumn.ColumnEdit = rpItemFile;
            gridColumn.Visible = true;
            gridView.Columns.Add(gridColumn);
        }

        private void RrpItemFile_Click(object sender, EventArgs e)
        {
            ((ElectronicInvoiceModule)Screen.Module).DownloadDocument();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ElectronicInvoiceModule)Screen.Module).RemoveEInvoiceTemplateList();
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((ElectronicInvoiceModule)Screen.Module).DownloadDocument();
        }

    }
}
