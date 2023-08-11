using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public class ICProductAttributesGridControl : BOSGridControl
    {
        private enum ProductAttributesColumn
        {
            ICProductAttributeNo,
            ICProductAttributeValue
        }

        public void InvalidateDataSource(BOSList<ICProductAttributesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            List<GridColumn> columnRemoveList = new List<GridColumn>();
            foreach (GridColumn columnItem in gridView.Columns)
            {
                if (columnItem.FieldName.ToString() != ProductAttributesColumn.ICProductAttributeNo.ToString()
                    && columnItem.FieldName.ToString() != ProductAttributesColumn.ICProductAttributeValue.ToString())
                    columnRemoveList.Add(columnItem);
            }
            columnRemoveList.ForEach(o =>
            {
                gridView.Columns.Remove(o);
            });
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;
            gridView.ExpandAllGroups();
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column = gridView.Columns["ICProductAttributeNo"];
            if (column != null)
            {
                column.Caption = "Mã thuộc tính";
            }
            column = gridView.Columns["ICProductAttributeValue"];
            if (column != null)
            {
                column.Caption = "Tên thuộc tính";
            }
        }
    }
}
