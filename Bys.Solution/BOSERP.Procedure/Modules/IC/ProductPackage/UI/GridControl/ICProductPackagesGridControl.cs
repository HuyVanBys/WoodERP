using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductPackage
{
    public class ICProductPackagesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductPackageEntities entity = (ProductPackageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductPackageList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Xem chi tiết";
            column.FieldName = "ICProductPackageItemComponent";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Xem chi tiết";
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "In QR Code";
            column.FieldName = "BarcodeNo";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemBarcode = new RepositoryItemHyperLinkEdit();
            rpItemBarcode.NullText = "In QR Code";
            rpItemBarcode.Click += new EventHandler(RpItemBarcode_Click);
            column.ColumnEdit = rpItemBarcode;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductPackageItemDetailQty"] != null)
            {
                SetFormat("ICProductPackageItemDetailQty", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageLength"] != null)
            {
                SetFormat("ICProductPackageLength", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageWidth"] != null)
            {
                SetFormat("ICProductPackageWidth", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageHeight"] != null)
            {
                SetFormat("ICProductPackageHeight", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageVolumn"] != null)
            {
                SetFormat("ICProductPackageVolumn", "n4", gridView);
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

            if (e.KeyCode == Keys.Delete)
            {
                //((ProductPackageModule)Screen.Module).DeleteItemProductPackageItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            //if (e.Column.FieldName == "ICProductPackageItemName")
            //    ((ProductPackageModule)Screen.Module).SetDefaultProductPackageItemList();
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.ICProductPackageID > 0)
                    ((ProductPackageModule)Screen.Module).ViewPackageItem(obj);
            }
        }

        private void RpItemBarcode_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                string mess = string.Empty;
                if (obj != null && obj.ICProductPackageID > 0 && !string.IsNullOrEmpty(obj.ICProductPackageBarcodeNo))
                {
                    if (obj.ICProductPackageProductQty == 0) obj.ICProductPackageProductQty = 1;
                    ((ProductPackageModule)Screen.Module).PrintBarcode(obj);
                }
                else if (obj != null && obj.ICProductPackageID == 0)
                {
                    mess = "Vui lòng lưu kiện!";
                }
                else if (obj != null && string.IsNullOrEmpty(obj.ICProductPackageBarcodeNo))
                {
                    mess = "Không thể in mã vạch có giá trị rỗng!";
                }
                if (!string.IsNullOrEmpty(mess))
                    BOSApp.ShowMessage(mess);
            }

        }
    }
}
