using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ReturnSupplier
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ICReceiptItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["FK_ICReceiptID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["ICReceiptItemWoodQty"];
            if (column != null)
            {
                column.Caption = "Số thanh (tấm)";
            }
            column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.Caption = "Mã kiện (Mã đầu lóng)";
            }
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICReceiptID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    ICReceiptsController objReceiptsController = new ICReceiptsController();
                    e.DisplayText = objReceiptsController.GetObjectNoByID(objectID);
                }
                else
                {
                    e.DisplayText = string.Empty;
                }
            }
        }

    }
}
