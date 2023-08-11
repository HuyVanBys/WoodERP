using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CustomerPaymentProposal
{
    public partial class ARSaleOrderPaymentTimeTemplatesGridControl : BOSComponent.BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrderPaymentTimeTemplateList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn gridColumn = new GridColumn();
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
            ((CustomerPaymentProposalModule)Screen.Module).DownloadDocument();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }


        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((CustomerPaymentProposalModule)Screen.Module).DownloadDocument();
        }
    }
}
