using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing
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
            GridColumn column = gridView.Columns["FK_APPurchaseOrderID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_APPurchaseOrderID")
            {
                if (e.Value != null)
                {
                    int purchaseOrderID = int.Parse(e.Value.ToString());
                    APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                    e.DisplayText = objPurchaseOrdersController.GetObjectNoByID(purchaseOrderID);
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
                    e.DisplayText = objProductsController.GetObjectNoByID(productID);
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}
