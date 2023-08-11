using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferProposal
{
    public class ARSaleOrderItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            int objecID = 0;
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    Int32.TryParse(e.Value.ToString(), out objecID);
                    ICProductsController objProductsController = new ICProductsController();
                    e.DisplayText = objProductsController.GetObjectNoByID(objecID);
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "FK_ARSaleOrderID")
            {
                if (e.Value != null)
                {
                    Int32.TryParse(e.Value.ToString(), out objecID);
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    e.DisplayText = objSaleOrdersController.GetObjectNoByID(objecID);
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "FK_ICProductAttributeColorID" || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    Int32.TryParse(e.Value.ToString(), out objecID);

                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    e.DisplayText = objProductAttributesController.GetObjectNoByID(objecID);
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "ICTransferProposalItemProductColorAttribute" || e.Column.FieldName == "ICTransferProposalItemProductWoodAttribute")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((TransferProposalModule)Screen.Module).GetAttributeText(e.Value.ToString());
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

    }
}
