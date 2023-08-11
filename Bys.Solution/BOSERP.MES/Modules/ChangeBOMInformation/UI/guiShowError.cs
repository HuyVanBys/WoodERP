using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ChangeBOMInformation.UI
{
    public partial class guiShowError : BOSERPScreen
    {
        public List<MMAllocationPlanItemsInfo> ListError = new List<MMAllocationPlanItemsInfo>();
        public guiShowError(List<MMAllocationPlanItemsInfo> List)
        {
            InitializeComponent();
            fld_dgcAllocationPlanItems.DataSource = List;
            fld_dgcAllocationPlanItems?.RefreshDataSource();
        }
        public guiShowError()
        {
            InitializeComponent();
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
        private void guiChooseHistoryLog_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }



    }
}
