using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.FalseConditional
{
    public partial class FalseConditionalItemsGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public override void InitGridControlDataSource()
        {
            FalseConditionalEntities entity = (FalseConditionalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FalseConditionalItemList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMFalseConditionalItemFaultPercent" ||
                    column.FieldName == "MMFalseConditionalItemGoodPercent" ||
                    column.FieldName == "MMFalseConditionalItemResult")
                {
                    column.OptionsColumn.AllowEdit = false;
                }    
            }
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((FalseConditionalModule)Screen.Module).DeleteItemFromList();
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chi tiết lỗi";
            column.FieldName = "Detail";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 8;

            RepositoryItemHyperLinkEdit AddProcessInfo = new RepositoryItemHyperLinkEdit();
            AddProcessInfo.NullText = "Chi tiết lỗi";
            AddProcessInfo.Click += new EventHandler(DetailFault_Click);
            column.ColumnEdit = AddProcessInfo;
            gridView.Columns.Add(column);

        }
        void DetailFault_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMFalseConditionalItemsInfo item = (MMFalseConditionalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item != null)
                ((FalseConditionalModule)Screen.Module).LoadingDetailFault(item);
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
        }
        
    }
}
