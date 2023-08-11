using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing
{
    public partial class MMBatchProductProductionNormItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMBatchProductProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            GridColumn column = gridView.Columns["Selected"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["MMBatchProductProductionNormItemGroup"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductDesc;
                    }
                }
            }
            if (e.Column.FieldName == "FK_MMBatchProductID")
            {
                if (e.Value != null)
                {
                    MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objBatchProductsInfo != null)
                    {
                        e.DisplayText = objBatchProductsInfo.MMBatchProductNo;
                    }
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemGroup")
            {
                if (e.Value != null)
                {
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("BatchProductProductionNormItemGroup", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                else
                {
                    e.DisplayText = string.Empty;
                }
            }
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
    }
}
