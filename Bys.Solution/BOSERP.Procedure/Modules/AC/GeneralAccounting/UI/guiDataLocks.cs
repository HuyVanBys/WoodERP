using BOSLib;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class guiDataLocks : BOSERPScreen
    {
        public guiDataLocks()
        {
            InitializeComponent();
        }

        private void fld_btnAddLock_Click(object sender, EventArgs e)
        {
            ((GeneralAccountingModule)Module).AddDataLock();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void guiDataLocks_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetYearEndDate();
            (((GeneralAccountingEntities)((BaseModuleERP)Module).CurrentModuleEntity).LockList).InitBOSListGridControl(fld_dgcLocks);
            ((GeneralAccountingModule)Module).ViewDataLocks(fld_dteFromDate.DateTime, fld_dteToDate.DateTime);
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            ((GeneralAccountingModule)Module).ViewDataLocks(fld_dteFromDate.DateTime, fld_dteToDate.DateTime);
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
    }
}
