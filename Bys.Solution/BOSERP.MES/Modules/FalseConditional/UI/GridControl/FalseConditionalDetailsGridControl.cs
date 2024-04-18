using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.FalseConditional
{
    public partial class FalseConditionalDetailsGridControl : ItemGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<MMFalseConditionalDetailsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMFalseConditionalDetailQty" 
                    || column.FieldName == "MMFalseConditionalDetailComment")
                    column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Tên lỗi";
            column.FieldName = "MMFalseConditionalDetailName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giới hạn % tối đa cho phép";
            column.FieldName = "MMFalseConditionalDetailLimit";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "% Lỗi";
            column.FieldName = "MMFalseConditionalDetailPercent";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "MMFalseConditionalDetailQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n0}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ghi chú";
            column.FieldName = "MMFalseConditionalDetailComment";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            MMFalseConditionalDetailsInfo item = (MMFalseConditionalDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Column.FieldName == "MMFalseConditionalDetailQty")
            {
                item.MMFalseConditionalDetailPercent = item.MMFalseConditionalDetailQty / item.MMFalseConditionalItemInventoryQty * 100;
            } 
                
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                MessageBox.Show("Không thể xoá những mục lỗi mặc định",
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }
        }
    }
}
