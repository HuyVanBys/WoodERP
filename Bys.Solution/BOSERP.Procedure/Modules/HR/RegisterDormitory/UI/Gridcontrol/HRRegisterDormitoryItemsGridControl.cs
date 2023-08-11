using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace BOSERP.Modules.RegisterDormitory
{
    public class HRRegisterDormitoryItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            RegisterDormitoryEntities entity = (RegisterDormitoryEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RegisterDormitoryItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["HRRegisterDormitoryItemFromDate"] != null)
                gridView.Columns["HRRegisterDormitoryItemFromDate"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["HRRegisterDormitoryItemToDate"] != null)
                gridView.Columns["HRRegisterDormitoryItemToDate"].OptionsColumn.AllowEdit = true;

            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);



            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((RegisterDormitoryModule)Screen.Module).DeleteItemFromRegisterDormitoryItemsList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    int employeeID = int.Parse(e.Value.ToString());
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    string employeeNo = objEmployeesController.GetObjectNoByID(employeeID);
                    if (employeeNo != null)
                    {
                        e.DisplayText = employeeNo;
                    }
                }
            }
            if (e.Column.FieldName == "HRRegisterDormitoryItemEmployeeLevelID")
            {
                if (e.Value != null)
                {
                    int levelID = int.Parse(e.Value.ToString());
                    HRLevelsController objLevelsController = new HRLevelsController();
                    string levelName = objLevelsController.GetObjectNameByID(levelID);
                    if (levelName != null)
                    {
                        e.DisplayText = levelName;
                    }
                }
            }
        }
    }
}
