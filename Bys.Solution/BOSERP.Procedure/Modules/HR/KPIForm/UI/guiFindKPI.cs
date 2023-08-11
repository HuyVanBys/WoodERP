using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIForm
{
    public partial class guiFindKPI : BOSERPScreen
    {
        #region Variables
        public List<HRKPIsInfo> SelectedObjects { get; set; }

        public List<HRKPIFormItemsInfo> KPIFormItemslist { get; set; }

        public List<HRKPIsInfo> KPIsLists { get; set; }
        #endregion

        public guiFindKPI(List<HRKPIFormItemsInfo> kPIRegistrations)
        {
            InitializeComponent();
            KPIFormItemslist = kPIRegistrations;
        }

        private void guiFindKPI_Load_1(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitBindingDatasource();
            SelectedObjects = new List<HRKPIsInfo>();
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
            SelectedObjects = SelectedObjects.Concat(KPIsLists.Where(o => o.Selected == true)).GroupBy(o => o.HRKPIID).Select(o => o.FirstOrDefault()).ToList();
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
            if (KPIsLists != null)
                SelectedObjects = SelectedObjects.Concat(KPIsLists.Where(o => o.Selected == true)).GroupBy(o => o.HRKPIID).Select(o => o.FirstOrDefault()).ToList();
            KPIsLists = new List<HRKPIsInfo>();
            HRKPIsController objKPIsController = new HRKPIsController();
            KPIsLists = objKPIsController.GetKPIByDepartment((int?)(fld_lkeFK_HRDepartmentID.EditValue ?? 0));
            KPIFormItemslist.ForEach(o =>
                {
                    HRKPIsInfo objKPIsInfo = KPIsLists.FirstOrDefault(x => x.HRKPIID == o.FK_HRKPIID);
                    if (objKPIsInfo != null)
                        KPIsLists.Remove(objKPIsInfo);
                });
            KPIsLists.ForEach(o =>
                {
                    if (SelectedObjects.Any(x => x.HRKPIID == o.HRKPIID))
                        o.Selected = true;
                });
            fld_dgcHRKPIs.InvalidateDataSource(KPIsLists);
            GridView gridView = (GridView)fld_dgcHRKPIs.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcHRKPIs.MainView;
            List<HRKPIsInfo> listView = new List<HRKPIsInfo>();
            BindingSource bds = (BindingSource)fld_dgcHRKPIs.DataSource;

            List<HRKPIsInfo> objects = (List<HRKPIsInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                HRKPIsInfo objDataViewPermissionsInfo = (HRKPIsInfo)gridView.GetRow(j);
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
            fld_dgcHRKPIs.RefreshDataSource();
        }
    }
}