using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public class MMBatchProductItemsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(BOSList<MMBatchProductItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICReceiptItemProductNoOfOldSys";
            column.Caption = SemiProductReceiptLocalizedResources.ICReceiptItemProductNoOfOldSys;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new GridColumn();
            column.Caption = SemiProductReceiptLocalizedResources.SaleOrderNo;
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SemiProductReceiptLocalizedResources.CustomerName;
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = SemiProductReceiptLocalizedResources.SaleOrderAgreement;
            column.FieldName = "MMBatchProductPONo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeColorID"
                 || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objectID);
                    e.DisplayText = objProductAttributesInfo == null ? string.Empty : objProductAttributesInfo.ICProductAttributeNo;
                }
                else
                {
                    e.DisplayText = string.Empty;
                }
            }
        }
    }
}
