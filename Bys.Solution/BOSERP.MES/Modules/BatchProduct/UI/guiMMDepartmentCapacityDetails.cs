using System;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.BatchProduct
{
    public partial class guiMMDepartmentCapacityDetails : BOSERPScreen
    {
        #region Public Properties
        public BOSList<MMDepartmentCapacityDetailsInfo> DepartmentCapacityDetailList { get; set; }
        #endregion

        public guiMMDepartmentCapacityDetails()
        {
            InitializeComponent();
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Module).CurrentModuleEntity;
            DepartmentCapacityDetailList = new BOSList<MMDepartmentCapacityDetailsInfo>();

            DepartmentCapacityDetailList.InitBOSList(entity,
                                           String.Empty,
                                           "MMDepartmentCapacityDetails",
                                           BOSList<MMDepartmentCapacityDetailsInfo>.cstRelationNone);

            MMDepartmentCapacityDetailsController ctrl = new MMDepartmentCapacityDetailsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                DepartmentCapacityDetailList.Invalidate(ds);
                DepartmentCapacityDetailList.InitBOSListGridControl(fld_dgcMMDepartmentCapacityDetails);
                BindingSource bs = new BindingSource();
                bs.DataSource = DepartmentCapacityDetailList;
                fld_dgcMMDepartmentCapacityDetails.DataSource = bs;
            }
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

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            DepartmentCapacityDetailList.SaveItemObjects();
            BOSApp.ShowMessage("Lưu thành công!");
        }

    }
}
