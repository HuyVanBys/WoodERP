using BOSComponent;
using BOSERP.Modules.ProductConstant.UI;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class ProductAttributeItemsGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<ICProductAttributeItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    int index = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
                    ((guiProductAttributeItems)Screen).RemoveProductAttributeItem(index);
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã công đoạn";
            column.FieldName = "MMOperationNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên công đoạn";
            column.FieldName = "MMOperationName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }

            column = new GridColumn();
            column.Caption = ProductConstantLocalizedResources.AddProcessInfo;
            column.FieldName = "AddProcessInfo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 3;

            RepositoryItemHyperLinkEdit AddProcessInfo = new RepositoryItemHyperLinkEdit();
            AddProcessInfo.NullText = ProductConstantLocalizedResources.AddProcessInfo;
            AddProcessInfo.Click += new EventHandler(AddProcessInfo_Click);
            column.ColumnEdit = AddProcessInfo;
            gridView.Columns.Add(column);

        }

        private void AddProcessInfo_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductAttributeItemsInfo objProductAttributeItemsInfo = (ICProductAttributeItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objProductAttributeItemsInfo != null)
                    ((ProductConstantModule)Screen.Module).ShowProcessInfo(objProductAttributeItemsInfo);
            }
        }

    }
}
