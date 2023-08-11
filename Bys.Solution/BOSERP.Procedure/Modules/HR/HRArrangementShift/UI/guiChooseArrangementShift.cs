using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRArrangementShift
{
    public partial class guiChooseArrangementShift : BOSERPScreen
    {
        #region Variables
        public List<HREmployeeArrangementShiftsInfo> SelectedObjects { get; set; }
        public List<HREmployeeArrangementShiftsInfo> EmployeeArrangementShiftslist { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int paramID { get; set; }
        #endregion

        public guiChooseArrangementShift(List<HREmployeeArrangementShiftsInfo> employeeArrangementShifts)
        {
            InitializeComponent();
            EmployeeArrangementShiftslist = employeeArrangementShifts;
        }

        private void guiChooseArrangementShift_Load_1(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Đang tải ...");
            InitializeControls(Controls);
            InitBindingDatasource();
            SelectedObjects = new List<HREmployeeArrangementShiftsInfo>();
            fld_dteFromDate.DateTime = Fromdate;
            fld_dteToDate.DateTime = Todate;
            BOSProgressBar.Close();
        }

        private void InitBindingDatasource()
        {


            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            DataSet workingShifts = objWorkingShiftsController.GetWorkingShiftByFK_WorkingShiftID(0);
            fld_lkeHRWorkingShiftID.Properties.DataSource = workingShifts.Tables[0];

            List<HREmployeeArrangementShiftsInfo> list = new List<HREmployeeArrangementShiftsInfo>();
            EmployeeArrangementShiftslist.ForEach(o =>
            {
                o.Selected = false;
                list.Add(o);
            });
            fld_dgcHREmployeeArrangementShiftsGridControl2.InvalidateDataSource(list);
            GridView gridView = (GridView)fld_dgcHREmployeeArrangementShiftsGridControl2.MainView;
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
            SelectedObjects = EmployeeArrangementShiftslist.Where(o => o.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            paramID = Convert.ToInt32(fld_lkeHRWorkingShiftID.EditValue);
            Fromdate = fld_dteFromDate.DateTime;
            Todate = fld_dteToDate.DateTime;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcHREmployeeArrangementShiftsGridControl2.MainView;
            List<HREmployeeArrangementShiftsInfo> listView = new List<HREmployeeArrangementShiftsInfo>();
            BindingSource bds = (BindingSource)fld_dgcHREmployeeArrangementShiftsGridControl2.DataSource;

            List<HREmployeeArrangementShiftsInfo> objects = (List<HREmployeeArrangementShiftsInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                HREmployeeArrangementShiftsInfo objDataViewPermissionsInfo = (HREmployeeArrangementShiftsInfo)gridView.GetRow(j);
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
            fld_dgcHREmployeeArrangementShiftsGridControl2.RefreshDataSource();
        }

        private void fld_lkeHRWorkingShiftID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            List<HRWorkingShiftsInfo> lstWorkingShifts = null;
            lstWorkingShifts = (List<HRWorkingShiftsInfo>)objWorkingShiftsController.GetListFromDataSet(objWorkingShiftsController.GetAllAliveObjects());
            fld_lkeHRWorkingShiftID.Properties.DataSource = lstWorkingShifts.Where(o => o.FK_HRWorkingShiftID == 0).ToList();
            //fld_lkeHRWorkingShiftID.EditValue = 0;
        }
    }
}