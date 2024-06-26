using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP
{
    public class ICProductPackageItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
        }


        public void InvalidateDataSource(List<ICProductPackageItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "Selected";
            column.Caption = "Chọn";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemQuantity";
            column.Caption = "SL định mức";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductPackageQty";
            column.Caption = "SL kiện";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{N}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductSerial";
            column.Caption = "Mã lô ";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{N}";
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
                if (col.FieldName == "Selected")
                    col.OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductPackageNo"] != null)
            {
                gridView.Columns["ICProductPackageNo"].Group();

            }
            if (gridView.Columns["ICProductPackageItemQty"] != null)
            {
                SetFormat("ICProductPackageItemQty", "n2", gridView);
                gridView.Columns["ICProductPackageItemQty"].Caption = "SL chi tiết / Kiện";
            }
            if (gridView.Columns["ICProductPackageItemLength"] != null)
            {
                SetFormat("ICProductPackageItemLength", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageItemWidth"] != null)
            {
                SetFormat("ICProductPackageItemWidth", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageItemHeight"] != null)
            {
                SetFormat("ICProductPackageItemHeight", "n2", gridView);
            }
            gridView.RowCellStyle += gridView_RowCellStyle;
            gridView.CellValueChanging += GridView_CellValueChanging;
            return gridView;
        }

        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductPackageItemsInfo obj = (ICProductPackageItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "Selected")
                {
                    bool value = false;
                    if (e.Value != null)
                        bool.TryParse(e.Value.ToString(), out value);
                    ChangeSelectedGroup(obj, value);

                }
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ICProductPackageItemsInfo obj = (ICProductPackageItemsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "ICProductPackageQty" && obj != null && obj.IsError)
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
                //((ProductPackageModule)Screen.Module).DeleteItemProductPackageItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductPackageItemsInfo obj = (ICProductPackageItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null) obj.IsError = false;
            }
        }
        public void ChangeSelectedGroup(ICProductPackageItemsInfo obj, bool value)
        {
            List<object> filterList = new List<object>();
            List<ICProductPackageItemsInfo> selectedList = new List<ICProductPackageItemsInfo>();
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
                if (filterList != null)
                    foreach (object objFilter in filterList)
                    {
                        ICProductPackageItemsInfo item = (ICProductPackageItemsInfo)objFilter;
                        if (item != null && item.ICProductPackageNo == obj.ICProductPackageNo)
                            item.Selected = value;
                    }
                this.RefreshDataSource();
            }
        }
    }
}
