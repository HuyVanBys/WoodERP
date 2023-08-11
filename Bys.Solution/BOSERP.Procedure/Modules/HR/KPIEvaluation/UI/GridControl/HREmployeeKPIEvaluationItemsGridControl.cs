using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIEvaluation
{
    public class HREmployeeKPIEvaluationItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeKPIEvaluationItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HREmployeeKPIEvaluationItemNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["HREmployeeKPIEvaluationItemName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["HREmployeeKPIEvaluationItemTotalAmount"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
            }

            column = gridView.Columns["HREmployeeKPIEvaluationItemTotalAmountBonus"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
            }

            gridView.Click += new EventHandler(GridView_Click);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((KPIEvaluationModule)Screen.Module).DeleteItemFromEmployeeItemsList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        void GridView_Click(object sender, EventArgs e)
        {
            KPIEvaluationModule module = (KPIEvaluationModule)Screen.Module;
            module.InitDataViewScreen();
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HREmployeeKPIEvaluationItemTotalAmount")
            {
                e.Appearance.BackColor2 = Color.Green;
                e.Appearance.BackColor = Color.Green;
            }
        }
    }
}
