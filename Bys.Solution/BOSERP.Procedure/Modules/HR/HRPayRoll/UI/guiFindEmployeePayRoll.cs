using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll
{
    public partial class guiFindEmployeePayRoll : BOSERPScreen
    {
        #region Variables
        public List<HREmployeePayRollsInfo> SelectedObjects { get; set; }

        public List<HREmployeePayRollsInfo> EmployeePayRollslist { get; set; }
        #endregion

        public guiFindEmployeePayRoll(List<HREmployeePayRollsInfo> employeePayRolls)
        {
            InitializeComponent();
            EmployeePayRollslist = employeePayRolls;
        }

        private void guiFindEmployeePayRoll_Load_1(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Đang tải ...");
            InitializeControls(Controls);
            InitBindingDatasource();
            SelectedObjects = new List<HREmployeePayRollsInfo>();
            BOSProgressBar.Close();
        }

        private void InitBindingDatasource()
        {
            //BRBranchsController objBranchsController = new BRBranchsController();
            //BRBranchsInfo objBranchsInfo = new BRBranchsInfo();
            //List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
            //branchs.Insert(0, objBranchsInfo);
            //fld_lkeFK_BRBranchID.Properties.DataSource = branchs;
            //fld_lkeFK_BRBranchID.EditValue = 0;

            //HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            //DataSet departments = objDepartmentsController.GetAllObjects();
            //fld_lkeFK_HRDepartmentID.Properties.DataSource = departments.Tables[0];

            //HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            //DataSet departmentRooms = objDepartmentRoomsController.GetAllObjects();
            //fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = departmentRooms.Tables[0];
            List<HREmployeePayRollsInfo> list = new List<HREmployeePayRollsInfo>();
            EmployeePayRollslist.ForEach(o =>
            {
                o.Selected = false;
                list.Add(o);
            });
            fld_dgcHREmployeePayRollsGridControl2.InvalidateDataSource(list);
            GridView gridView = (GridView)fld_dgcHREmployeePayRollsGridControl2.MainView;
            gridView.ExpandAllGroups();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = EmployeePayRollslist.Where(o => o.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcHREmployeePayRollsGridControl2.MainView;
            List<HREmployeePayRollsInfo> listView = new List<HREmployeePayRollsInfo>();
            BindingSource bds = (BindingSource)fld_dgcHREmployeePayRollsGridControl2.DataSource;

            List<HREmployeePayRollsInfo> objects = (List<HREmployeePayRollsInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                HREmployeePayRollsInfo objDataViewPermissionsInfo = (HREmployeePayRollsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    listView.Add(objDataViewPermissionsInfo);
                }
            }
            for (int i = 0; i < objects.Count; i++)
            {
                foreach (var dataViewItem in listView)
                {
                    if (objects[i] == dataViewItem)
                    {
                        objects[i].Selected = fld_chkSelectedAll.Checked;
                    }
                }
            }
            fld_dgcHREmployeePayRollsGridControl2.RefreshDataSource();
        }
    }
}