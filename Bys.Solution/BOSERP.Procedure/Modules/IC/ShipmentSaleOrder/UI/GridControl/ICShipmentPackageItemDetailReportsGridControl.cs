using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ICShipmentPackageItemDetailReportsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentPackageItemDetailReportList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = "Số lượng MH";
            column.FieldName = "ICShipmentItemQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = false;
            gridView.Columns.Add(column);
            SetFormat("ICShipmentItemQty", "n2", gridView);

            column = new GridColumn();
            column.Caption = "Số lượng đã đóng kiện";
            column.FieldName = "ICShipmentItemPackagedQty1";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = false;
            gridView.Columns.Add(column);
            SetFormat("ICShipmentItemPackagedQty1", "n2", gridView);
        }

        public void InvalidateDataSource(List<ICShipmentPackageItemDetailsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int index = view.GetDataSourceRowIndex(view.FocusedRowHandle);
                    if (index >= 0)
                    {
                        entity.ShipmentPackageItemDetailList.RemoveAt(index);
                        this.DataSource = entity.ShipmentPackageItemDetailList;
                        RefreshDataSource();
                    }
                    e.Handled = true;
                }
            }
        }
    }
}
