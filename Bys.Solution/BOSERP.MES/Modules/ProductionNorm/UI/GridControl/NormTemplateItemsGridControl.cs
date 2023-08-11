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
using System.Drawing;
using DevExpress.XtraGrid;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class NormTemplateItemsGridControl : BOSGridControl
    {
        public MMNormTemplateItemsInfo CopyTemplateItem { get; set; }
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
             BindingSource bds = new BindingSource();
             bds.DataSource = entity.NormTemplateItemList;
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
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.OptionsSelection.MultiSelect = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.GridControl.ProcessGridKey += new KeyEventHandler(GridControl_ProcessGridKey);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }
        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool value = (bool)view.GetRowCellValue(e.RowHandle, "MMNormTemplateItemIsComponent");
                if (value == true)
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }
        private void GridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            ColumnView view = (sender as GridControl).FocusedView as ColumnView;
            if (view == null || !e.Control) return;
            if (e.KeyCode == Keys.X && e.Control && view.Editable && view.SelectedRowsCount > 0)
            {
                MMNormTemplateItemsInfo item = (MMNormTemplateItemsInfo)view.GetRow(view.FocusedRowHandle);
                CopyTemplateItem = (MMNormTemplateItemsInfo)item.Clone();
               
            }
            else if (e.KeyCode == Keys.V && e.Control && view.Editable && view.SelectedRowsCount > 0)
            {
                gridView.ClearSelection();
                if (CopyTemplateItem != null)
                {
                    int index = view.FocusedRowHandle;
                   
                    MMNormTemplateItemsInfo newItem = new MMNormTemplateItemsInfo();
                    BOSUtil.CopyObject(CopyTemplateItem, newItem);
                    ((ProductionNormModule)Screen.Module).PasteNormTemplateItem(newItem, index);
                    
                    CopyTemplateItem = null;
                }
            }
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "MMNormTemplateItemProductQty")
                {
                    MMNormTemplateItemsInfo objNormTemplateItemsInfo = (MMNormTemplateItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objNormTemplateItemsInfo != null)
                    {
                        objNormTemplateItemsInfo.IsError = false;
                    }
                }
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMNormTemplateItemProductQty")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMNormTemplateItemsInfo objNormTemplateItemsInfo = (MMNormTemplateItemsInfo)gridView.GetRow(e.RowHandle);
                            if (objNormTemplateItemsInfo.IsError)
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "MMNormTemplateItemProductQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ghi chú mô tả";
            column.FieldName = "MMNormTemplateItemComment";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductionNormModule)Screen.Module).DeleteNormTemplateItemFromList();
                }
            }
        }


    }
}
