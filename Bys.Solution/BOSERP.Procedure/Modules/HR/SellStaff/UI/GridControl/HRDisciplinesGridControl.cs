using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff
{
    public partial class HRDisciplinesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SellStaffEntities entity = (SellStaffEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DisciplineList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.Columns.Clear();

            GridColumn column = new GridColumn();
            column.Caption = "Mã chứng từ";
            column.FieldName = "HRDisciplineNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên chứng từ";
            column.FieldName = "HRDisciplineName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại chứng từ";
            column.FieldName = "HRDisciplineOptionName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị";
            column.FieldName = "HREmployeeDisciplineValueAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "HRDisciplineFromDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                HRDisciplinesController objRewardsController = new HRDisciplinesController();
                HRDisciplinesInfo objDisciplinesInfo = (HRDisciplinesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objDisciplinesInfo != null)
                {
                    BOSERP.Modules.HRDiscipline.HRDisciplineModule disciplineModule = (BOSERP.Modules.HRDiscipline.HRDisciplineModule)BOSApp.ShowModule(ModuleName.HRDiscipline);
                    if (disciplineModule != null)
                    {
                        disciplineModule.ActionInvalidate(objDisciplinesInfo.HRDisciplineID);
                    }
                }
            }
        }
    }
}
