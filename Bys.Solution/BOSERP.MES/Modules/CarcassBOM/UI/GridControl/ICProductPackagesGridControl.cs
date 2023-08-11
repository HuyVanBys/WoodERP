using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public class ICProductPackagesGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<ICProductPackagesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Thêm kiện";
            column.FieldName = "AddPackage";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpItemBarcode = new RepositoryItemHyperLinkEdit();
            rpItemBarcode.NullText = "Thêm kiện";
            rpItemBarcode.Click += new EventHandler(RpItemAdd_Click);
            column.ColumnEdit = rpItemBarcode;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Lưu";
            column.FieldName = "SavePackage";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpItemSave = new RepositoryItemHyperLinkEdit();
            rpItemSave.NullText = "Lưu";
            rpItemSave.Click += new EventHandler(RpItemSave_Click);
            column.ColumnEdit = rpItemSave;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Xóa";
            column.FieldName = "Delete";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpItemDelete = new RepositoryItemHyperLinkEdit();
            rpItemDelete.NullText = "Xóa";
            rpItemDelete.Click += new EventHandler(RpItemDelete_Click);
            column.ColumnEdit = rpItemDelete;
            gridView.Columns.Add(column);
        }
        private void RpItemAdd_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            ICProductPackagesInfo item = (ICProductPackagesInfo)gridView.GetFocusedRow();
            ICProductPackagesInfo itemAdd = new ICProductPackagesInfo();
            if (item != null)
            {
                BOSUtil.CopyObject(item, itemAdd);
                itemAdd.ICProductPackageID = 0;
                itemAdd.ICProductPackageBarcodeNo = string.Empty;
                itemAdd.ICProductPackageNo = string.Empty;
            }
            ((CarcassBOMModule)Screen.Module).AddNewPackageItem(itemAdd, ((CarcassBOMModule)Screen.Module).PackageList);

            if (((CarcassBOMModule)Screen.Module).PackageList == null) ((CarcassBOMModule)Screen.Module).PackageList = new List<ICProductPackagesInfo>();
            ((CarcassBOMModule)Screen.Module).PackageList.Add(itemAdd);
            this.RefreshDataSource();
        }
        private void RpItemDelete_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj.ICProductPackageID > 0)
                {
                    obj = (ICProductPackagesInfo)(new ICProductPackagesController()).GetObjectByID(obj.ICProductPackageID);
                }
                if (obj != null && obj.ICProductPackageStatus == "Approved")
                {
                    BOSApp.ShowMessage("Kiện đã sử dụng, bạn không thể xóa!");
                    return;
                }
                if (obj != null && obj.ICProductPackageID > 0)
                    if (BOSApp.ShowMessageYesNo("Bạn chắc chắn xóa kiện này không?") == DialogResult.No)
                        return;
                if (obj != null)
                    ((CarcassBOMModule)Screen.Module).DeleteProductPackge(obj);
                ((CarcassBOMModule)Screen.Module).ShowPackageNo(false);

            }
        }
        private void RpItemSave_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    obj.ICProductPackageQty = 1;
                    ((CarcassBOMModule)Screen.Module).SavePackage(obj);
                }

            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                if (col.FieldName == "ICProductPackageStatus" ||
                    col.FieldName == "ICProductPackageQty" ||
                    col.FieldName == "FK_MMBatchProductID" ||
                    col.FieldName == "ICProductPackageQty" ||
                    col.FieldName == "FK_ICProductID")
                    col.OptionsColumn.AllowEdit = false;

            }
            if (gridView.Columns["ICProductPackageQty"] != null)
            {
                SetFormat("ICProductPackageQty", "n2", gridView);
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
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "ICProductPackageNo" && obj != null && obj.IsError)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                }
            }
        }
        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductPackagesInfo item = (ICProductPackagesInfo)gridView.GetFocusedRow();

            if (e.Column.FieldName == "Selected" && item != null)
            {
                bool value = false;
                if (e.Value != null)
                    bool.TryParse(e.Value.ToString(), out value);
                if (item != null && item.ICProductPackageID == 0 && value)
                {
                    if (BOSApp.ShowMessageYesNo("Kiện chưa lưu, bạn không thể thêm chi tiết! Bạn có muốn lưu không?") == DialogResult.Yes)
                    {
                        ((CarcassBOMModule)Screen.Module).SavePackage(item);
                    }

                }
                if (item != null)
                {
                    if (((CarcassBOMModule)Screen.Module).PackageList != null && ((CarcassBOMModule)Screen.Module).PackageList.Count > 0)
                    {
                        ((CarcassBOMModule)Screen.Module).PackageList.ForEach(o => o.Selected = false);
                    }
                    item.Selected = value;
                    ((CarcassBOMModule)Screen.Module).ReFreshPackNormItemDetail(item, value);
                    ((CarcassBOMModule)Screen.Module).CalculateVolumnSelectedItem(null);
                    this.RefreshDataSource();
                }

            }
            else if (item == null)
            {
                item = ((CarcassBOMModule)Screen.Module).AddNewPackageItem(item, null);
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetFocusedRow();
            if (e.Column.FieldName == "ICProductPackageNo" && obj != null)
            {
                obj.IsError = false;
                string mess = string.Empty;

                List<ICProductPackagesInfo> multiExits = ((CarcassBOMModule)Screen.Module).PackageList.Where(o => o.ICProductPackageNo == obj.ICProductPackageNo).ToList();
                if (multiExits != null && multiExits.Count > 1)
                {
                    ((CarcassBOMModule)Screen.Module).PackageList.ForEach(o =>
                    {
                        if (o.ICProductPackageNo == obj.ICProductPackageNo) o.IsError = true;
                        else o.IsError = false;
                    });
                    mess = "Mã kiện Đã tồn tại trong danh sách!";
                    BOSApp.ShowMessage(mess);
                    return;
                }

                ICProductPackagesInfo exitPackage = (ICProductPackagesInfo)(new ICProductPackagesController()).GetObjectByNo(obj.ICProductPackageNo);
                if (exitPackage != null && exitPackage.ICProductPackageID != obj.ICProductPackageID)
                {
                    ICProductsInfo product = BOSApp.GetProductFromCurrentProductList(exitPackage.FK_ICProductID);
                    mess = "Đã tồn tại mã kiện trong hệ thống!"
                        + Environment.NewLine + "Mã kiện:" + exitPackage.ICProductPackageNo
                        + (product != null ? (Environment.NewLine + "Sản phẩm:" + product.ICProductNo) : "");
                    BOSApp.ShowMessage(mess);
                    return;
                }

            }
            else if (obj != null && e.Column.FieldName == "FK_ICProductAttributeID" && obj.ICProductPackageID == 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn muốn phát sinh lại mã kiện không?") == DialogResult.Yes)
                {
                    ((CarcassBOMModule)Screen.Module).GenaralPackageNo(obj);
                    obj.ICProductPackageBarcodeNo = obj.ICProductPackageNo;
                }
            }
        }
    }
}
