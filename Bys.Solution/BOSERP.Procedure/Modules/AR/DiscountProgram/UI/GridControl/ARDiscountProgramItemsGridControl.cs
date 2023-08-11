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
    public class ARDiscountProgramItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DiscountProgramEntities entity = (DiscountProgramEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DiscountProgramItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ARDiscountProgramItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARDiscountProgramItemValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARDiscountProgramItemApplyOn"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARDiscountProgramItemIsExhibit"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARDiscountProgramItemPriorityQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARDiscountProgramItemPriorityPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARDiscountProgramItemBonusAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARDiscountProgramItemsInfo item = (ARDiscountProgramItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                DiscountProgramEntities entity = (DiscountProgramEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                if (e.Column.FieldName == "ARDiscountProgramItemProductUnitPrice")
                {
                    ((DiscountProgramModule)Screen.Module).ChangeItemProductUnitPrice();
                }
                else
                {
                    ((DiscountProgramModule)Screen.Module).ChangeDiscountProgramItem();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((DiscountProgramModule)Screen.Module).DeleteDiscountProgramItem();
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
            column = gridview.Columns["ARDiscountProgramItemBonusAmount"];
            if (column != null)
            {
                column.Visible = programIsExhibit;
            }
        }
    }
}
