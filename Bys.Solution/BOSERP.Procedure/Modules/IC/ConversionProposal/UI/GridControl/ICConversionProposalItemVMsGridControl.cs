using BOSCommon.Constants;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ConversionProposal
{
    public class ICConversionProposalItemVMsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ConversionProposalEntities entity = (ConversionProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TotalConversionProposalItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.RowAutoHeight = true;
            GridColumn column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICConversionProposalItemProductLotNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICConversionProposalItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICConversionProposalItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICConversionProposalItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICConversionProposalItemComment"];
            if (column != null)
            {
                RepositoryItemMemoEdit repRichTextReason = new RepositoryItemMemoEdit();
                column.ColumnEdit = repRichTextReason;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICConversionProposalItemLocation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ConversionProposalModule)Screen.Module).DeleteTotalItemFromConversionProposalItemList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ConversionProposalEntities entity = (ConversionProposalEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ICConversionProposalItemVMsInfo item = entity.TotalConversionProposalItemList[entity.TotalConversionProposalItemList.CurrentIndex];

                if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((ConversionProposalModule)Screen.Module).SelectTotalSeriesNoDefault(item);
                }
                else if (e.Column.FieldName == "ICConversionProposalItemProductSerialNo" || e.Column.FieldName == "ICConversionProposalItemProductLotNo")
                {
                    ((ConversionProposalModule)Screen.Module).ChangeTotalItemSerieNo(item);
                    ((ConversionProposalModule)Screen.Module).CalculatedTotalProductQtyByPackageVolumnConfig();
                }
                else if (e.Column.FieldName == "ICConversionProposalItemProductHeight"
                  || e.Column.FieldName == "ICConversionProposalItemProductWidth"
                  || e.Column.FieldName == "ICConversionProposalItemProductLength"
                  || e.Column.FieldName == "ICConversionProposalItemWoodQty")
                {
                    ((ConversionProposalModule)Screen.Module).CalculatedTotalProductQtyByPackageVolumnConfig();
                }
                ((ConversionProposalModule)Screen.Module).ChangeItemVM(item);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", int.Parse(e.Value.ToString()), "ICMeasureUnitName");
                }
            }
            else if (e.Column.FieldName == "FK_ICStockID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICStocks", "ICStockID", int.Parse(e.Value.ToString()), "ICStockName");
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            ConversionProposalEntities entity = (ConversionProposalEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICConversionProposalItemsInfo item = entity.ConversionProposalItemList[entity.ConversionProposalItemList.CurrentIndex];
        }
    }
}
