using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleContract
{
    public partial class ARSaleContractTemplatesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleContractEntities entity = (SaleContractEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleContractTemplatesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn gridColumn = new GridColumn();
            //gridColumn = new GridColumn();
            //gridColumn.Caption = "Tên đợt thanh toán";
            //gridColumn.FieldName = "ARSaleOrderPaymentTimeName";
            //gridColumn.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(gridColumn);

            //gridColumn = new GridColumn();
            gridColumn.Caption = SaleOrderLocalizedResources.DowloadTemplateCaption;
            gridColumn.FieldName = "DowloadFile";
            gridColumn.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(gridColumn);

            RepositoryItemHyperLinkEdit rpItemFile = new RepositoryItemHyperLinkEdit();
            rpItemFile.NullText = SaleOrderLocalizedResources.DowloadTemplateCaption;
            rpItemFile.Click += new EventHandler(RrpItemFile_Click);
            gridColumn.ColumnEdit = rpItemFile;
            gridColumn.Visible = true;
            gridView.Columns.Add(gridColumn);
        }

        private void RrpItemFile_Click(object sender, EventArgs e)
        {
            ((SaleContractModule)Screen.Module).DownloadDocument();
        }


        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((SaleContractModule)Screen.Module).RemoveSaleContractTemplateList();
            }
        }

        //private void GridView_DoubleClick(object sender, EventArgs e)
        //{
        //    ((SaleContractModule)Screen.Module).DownloadDocument();
        //}

    }
}
