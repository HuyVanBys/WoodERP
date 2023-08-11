using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff
{
    public partial class HRAllowancesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SellStaffEntities entity = (SellStaffEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AllowanceList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.Columns.Clear();

            GridColumn column = new GridColumn();
            column.Caption = "Mã chứng từ";
            column.FieldName = "HRAllowanceNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên chứng từ";
            column.FieldName = "HRAllowanceName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại chứng từ";
            column.FieldName = "HRAllowanceOptionName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị";
            column.FieldName = "HRAllowanceConfigValue";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "HRAllowanceFromDate";
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
                HRAllowancesController objAllowancesController = new HRAllowancesController();
                HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objAllowancesInfo != null)
                {
                    BOSERP.Modules.HRAllowance.HRAllowanceModule allowanceModule = (BOSERP.Modules.HRAllowance.HRAllowanceModule)BOSApp.ShowModule(ModuleName.HRAllowance);
                    if (allowanceModule != null)
                    {
                        allowanceModule.ActionInvalidate(objAllowancesInfo.HRAllowanceID);
                    }
                }
            }
        }
    }
}
