using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class ChooseWeekGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ListWeek;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.Columns.Clear();
            AddColumnsToGridView(gridView);
            gridView.OptionsBehavior.KeepFocusedRowOnUpdate = true;
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.RowCellStyle += gridView_RowCellStyle;
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                BOSERP.Modules.OperationDetailPlan.guiChooseWeek form = (BOSERP.Modules.OperationDetailPlan.guiChooseWeek)this.Screen;
                MMOperationDetailPlansInfo item = (MMOperationDetailPlansInfo)gridView.GetRow(e.RowHandle);
                if (item != null)
                {
                    if (item.MMOperationDetailPlanWeek == form.PlanWeek)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }
                }
            }
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GetRowHandle();
        }
        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void GetRowHandle()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlansInfo item = (MMOperationDetailPlansInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    BOSERP.Modules.OperationDetailPlan.guiChooseWeek form = (BOSERP.Modules.OperationDetailPlan.guiChooseWeek)this.Screen;
                    form.ChooseWeek(item);
                }
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Enter)
            {
                MMOperationDetailPlansInfo item = (MMOperationDetailPlansInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    BOSERP.Modules.OperationDetailPlan.guiChooseWeek form = (BOSERP.Modules.OperationDetailPlan.guiChooseWeek)this.Screen;
                    form.ChooseWeek(item);
                }
            }
        }
        public void AddColumnsToGridView(GridView gridView)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tuần";
            column.FieldName = "MMOperationDetailPlanWeek";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);


            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Từ ngày";
            column.FieldName = "MMOperationDetailPlanFromDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Đến ngày";
            column.FieldName = "MMOperationDetailPlanToDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

        }
    }
}
