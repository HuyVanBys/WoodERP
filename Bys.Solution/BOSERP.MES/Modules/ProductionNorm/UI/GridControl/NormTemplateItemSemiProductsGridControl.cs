using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSComponent;
using BOSLib;
using BOSCommon;
using BOSERP.Modules.ProductionNorm.UI;
using BOSERP.Modules.ProductionNorm;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class NormTemplateItemSemiProductsGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
             BindingSource bds = new BindingSource();
             bds.DataSource = entity.NormTemplateItemSemiProductList;
             this.DataSource = bds;
        }
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public void InvalidateDataSource(BOSList<MMNormTemplateItemsInfo> dtSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dtSource;
            DataSource = bds;
            RefreshDataSource();
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                if (columns.FieldName != "Selected")
                    columns.OptionsColumn.AllowEdit = false;
            }
            ((ProductionNormModule)Screen.Module).GeneralSourceSemiProductData(gridView);
            gridView.DoubleClick += new EventHandler(gridView_DoubleClick);
            gridView.GridControl.ProcessGridKey += new KeyEventHandler(GridControl_ProcessGridKey);
            return gridView;
        }
        private void GridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            ColumnView view = (sender as GridControl).FocusedView as ColumnView;
            if (view == null || !e.Control) return;
            if (e.KeyCode == Keys.N && e.Control && view.Editable && view.SelectedRowsCount > 0)
            {
                e.Handled = true;
                MMNormTemplateItemsInfo item = (MMNormTemplateItemsInfo)view.GetRow(view.FocusedRowHandle);
                if (item.MMNormTemplateItemProductName.Trim() != string.Empty)
                    ((ProductionNormModule)Screen.Module).AddSemiProductToNormTemplateItem(item);

            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }
        void gridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMNormTemplateItemsInfo item = (MMNormTemplateItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item.MMNormTemplateItemProductName.Trim() != string.Empty)
                    ((ProductionNormModule)Screen.Module).AddSemiProductToNormTemplateItem(item);
            }
        }
    }
}
