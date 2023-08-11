using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingReceipt
{
    public partial class APPurchaseOrderItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<APPurchaseOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["Selected"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_APPurchaseOrderID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PurchaseOrderLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_APPurchaseOrderID")
            {
                if (e.Value != null)
                {
                    int purchaseOrderID = int.Parse(e.Value.ToString());
                    APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                    APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(purchaseOrderID);
                    if (objPurchaseOrdersInfo != null)
                    {
                        e.DisplayText = objPurchaseOrdersInfo.APPurchaseOrderNo;
                    }
                    else
                    {
                        e.DisplayText = "";
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }

            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int productID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductNo;
                    }
                    else
                    {
                        e.DisplayText = "";
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}
