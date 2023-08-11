using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIRegistration
{
    public partial class guiFindKPIFrom : BOSERPScreen
    {
        #region Variables
        public List<HRKPIFormItemsInfo> SelectedObjects { get; set; }

        public List<HRKPIRegistrationItemsInfo> KPIRegistrationItemslist { get; set; }

        public List<HRKPIFormItemsInfo> KPIFormItemsLists { get; set; }
        #endregion

        public guiFindKPIFrom(List<HRKPIRegistrationItemsInfo> kPIRegistrations)
        {
            InitializeComponent();
            KPIRegistrationItemslist = kPIRegistrations;
        }

        private void guiFindKPIFrom_Load_1(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitBindingDatasource();
            SelectedObjects = new List<HRKPIFormItemsInfo>();
        }

        private void InitBindingDatasource()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
            fld_lkeFK_BRBranchID.Properties.DataSource = branchs;

            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            DataSet departments = objDepartmentsController.GetAllObjects();
            fld_lkeFK_HRDepartmentID.Properties.DataSource = departments.Tables[0];

            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            DataSet departmentRooms = objDepartmentRoomsController.GetAllObjects();
            fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = departmentRooms.Tables[0];
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
            SelectedObjects = SelectedObjects.Concat(KPIFormItemsLists.Where(o => o.Selected == true)).GroupBy(o => o.HRKPIFormItemID).Select(o => o.FirstOrDefault()).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            if (KPIFormItemsLists != null)
                SelectedObjects = SelectedObjects.Concat(KPIFormItemsLists.Where(o => o.Selected == true)).GroupBy(o => o.HRKPIFormItemID).Select(o => o.FirstOrDefault()).ToList();
            KPIFormItemsLists = new List<HRKPIFormItemsInfo>();
            HRKPIFormItemsController objKPIFormItemsController = new HRKPIFormItemsController();
            KPIFormItemsLists = objKPIFormItemsController.GetKPIFormItemByBranchDepartmentAndDepartmentRoom(
                                                                                        (int?)(fld_lkeFK_BRBranchID.EditValue ?? 0),
                                                                                        (int?)(fld_lkeFK_HRDepartmentID.EditValue ?? 0),
                                                                                        (int?)(fld_lkeFK_HRDepartmentRoomID.EditValue ?? 0),
                                                                                        (fld_txtHRKPIFormNo.EditValue ?? string.Empty).ToString());
            KPIRegistrationItemslist.ForEach(o =>
                {
                    HRKPIFormItemsInfo objKPIFormItemsInfo = KPIFormItemsLists.FirstOrDefault(x => x.HRKPIFormItemID == o.FK_HRKPIFormItemID);
                    if (objKPIFormItemsInfo != null)
                        KPIFormItemsLists.Remove(objKPIFormItemsInfo);
                });
            KPIFormItemsLists.ForEach(o =>
                {
                    if (SelectedObjects.Any(x => x.HRKPIFormItemID == o.HRKPIFormItemID))
                        o.Selected = true;
                });
            fld_dgcKPIFormItemsGridControl.InvalidateDataSource(KPIFormItemsLists);
            GridView gridView = (GridView)fld_dgcKPIFormItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcKPIFormItemsGridControl.MainView;
            List<HRKPIFormItemsInfo> listView = new List<HRKPIFormItemsInfo>();
            BindingSource bds = (BindingSource)fld_dgcKPIFormItemsGridControl.DataSource;

            List<HRKPIFormItemsInfo> objects = (List<HRKPIFormItemsInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                HRKPIFormItemsInfo objDataViewPermissionsInfo = (HRKPIFormItemsInfo)gridView.GetRow(j);
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
            fld_dgcKPIFormItemsGridControl.RefreshDataSource();
        }
    }
}