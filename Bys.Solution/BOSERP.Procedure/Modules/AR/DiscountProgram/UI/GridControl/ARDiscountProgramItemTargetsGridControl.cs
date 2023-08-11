using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSCommon;
using BOSLib;
using BOSComponent;

namespace BOSERP.Modules.DiscountProgram
{
    public class ARDiscountProgramItemTargetsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DiscountProgramItemTargetList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.ItemCopyNewRow;
            column.FieldName = "ARSOItemCopyItem";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemAddNewRow = new RepositoryItemHyperLinkEdit();
            rpItemAddNewRow.NullText = "Thêm dòng"; // DiscountProgramResources.ItemNewRow;
            rpItemAddNewRow.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemAddNewRow;
            gridView.Columns.Add(column);
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((DiscountProgramModule)Screen.Module).CopyDiscountProgramItemTargetNewRow();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                //ARDiscountProgramItemsInfo item = (ARDiscountProgramItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                //DiscountProgramEntities entity = (DiscountProgramEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                //if (e.Column.FieldName == "ARDiscountProgramItemProductUnitPrice")
                //{
                //    ((DiscountProgramModule)Screen.Module).ChangeItemProductUnitPrice();
                //}
                //else if (e.Column.FieldName == "ARDiscountProgramItemProductUnitPrice")
                //{
                //    ((DiscountProgramModule)Screen.Module).ChangeItemProductUnitPrice();
                //}
                //((DiscountProgramModule)Screen.Module).ChangeDiscountProgramItem();
            }
            else
            {
                ARDiscountProgramItemTargetsInfo item = (ARDiscountProgramItemTargetsInfo)gridView.GetRow(e.RowHandle);
                if (item == null)
                    return;

                ((DiscountProgramModule)Screen.Module).SetDefaultDiscountProgramItemTarget(item);
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((DiscountProgramModule)Screen.Module).DeleteDiscountProgramItemTarget();
            }
        }

        public void LoadGridColumnByType(string programType, bool programIsExhibit)
        {
            GridView gridview = (GridView)MainView;
            if (gridview == null)
                return;

            GridColumn column = gridview.Columns["ARDiscountProgramItemIsExhibit"];
            if (column != null)
            {
                column.Visible = programIsExhibit;
            }
        }
    }
}
