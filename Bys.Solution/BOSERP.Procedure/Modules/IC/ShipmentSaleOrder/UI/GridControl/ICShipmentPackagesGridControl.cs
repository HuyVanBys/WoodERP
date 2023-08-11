using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ICShipmentPackagesGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentPackageList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column1 = new DevExpress.XtraGrid.Columns.GridColumn();
            column1.Caption = "Xem chi tiết";
            column1.FieldName = "Detail";
            column1.OptionsColumn.AllowEdit = true;


            gridView.Columns.Add(column1);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
                if (col.FieldName == "ICShipmentPackageQty")
                    col.OptionsColumn.AllowEdit = true;
                else if (col.FieldName == "Detail")
                {
                    col.VisibleIndex = 2;
                    col.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Chi tiết";
                    rep1.Click += new EventHandler(RpItemComponent_Click);
                    col.ColumnEdit = rep1;
                }
            }
            if (gridView.Columns["ICShipmentPackageQty"] != null)
            {
                SetFormat("ICShipmentPackageQty", "n", gridView);
            }
            if (gridView.Columns["ICShipmentPackageLength"] != null)
            {
                SetFormat("ICShipmentPackageLength", "n2", gridView);
            }
            if (gridView.Columns["ICShipmentPackageWidth"] != null)
            {
                SetFormat("ICShipmentPackageWidth", "n2", gridView);
            }
            if (gridView.Columns["ICShipmentPackageHeight"] != null)
            {
                SetFormat("ICShipmentPackageHeight", "n2", gridView);
            }
            if (gridView.Columns["ICShipmentPackageVolumn"] != null)
            {
                SetFormat("ICShipmentPackageVolumn", "n4", gridView);
            }
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ICShipmentPackagesInfo obj = (ICShipmentPackagesInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "ICShipmentPackageQty" && obj != null && obj.IsError)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                }
            }
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ShipmentSaleOrderModule)Screen.Module).DeleteItemShipmentPackagesList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICShipmentPackagesInfo obj = (ICShipmentPackagesInfo)gridView.GetRow(e.RowHandle);
                if (obj != null)
                {
                    obj.IsError = false;
                }
            }
        }
        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentPackagesInfo obj = (ICShipmentPackagesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                string mess = string.Empty;
                if (obj != null)
                {
                    ((ShipmentSaleOrderModule)Screen.Module).ShowGuiPackage(obj, null);
                }
            }

        }
    }
}
