using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class ARSaleOrderPaymentTimeTemplatesGridControl : BOSComponent.BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleOrderPaymentTimeTemplatesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn gridColumn = new GridColumn();
            gridColumn.Caption = SaleOrderLocalizedResources.DowloadTemplateCaption;
            gridColumn.FieldName = "AttachFileCaption";
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
            GridView gridView = MainView as GridView;
            if (gridView == null)
                return;

            ARSaleOrderPaymentTimeTemplatesInfo objSaleOrderPaymentTimeTemplatesInfo = (ARSaleOrderPaymentTimeTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objSaleOrderPaymentTimeTemplatesInfo == null)
                return;

            ((guiAttachFile)Screen).DownloadPaymentTimeTemplates(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateID);
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
            if (e.KeyCode != Keys.Delete)
                return;
            GridView gridView = MainView as GridView;
            if (gridView == null)
                return;

            ARSaleOrderPaymentTimeTemplatesInfo objSaleOrderPaymentTimeTemplatesInfo = (ARSaleOrderPaymentTimeTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ((guiAttachFile)Screen).RemovePaymentTimeTemplatesList(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateID);

        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = MainView as GridView;
            if (gridView == null)
                return;

            ARSaleOrderPaymentTimeTemplatesInfo objSaleOrderPaymentTimeTemplatesInfo = (ARSaleOrderPaymentTimeTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objSaleOrderPaymentTimeTemplatesInfo == null)
                return;

            ((guiAttachFile)Screen).DownloadPaymentTimeTemplates(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateID);
        }

    }
}
