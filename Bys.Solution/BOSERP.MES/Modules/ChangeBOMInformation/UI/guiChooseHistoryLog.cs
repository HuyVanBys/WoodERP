using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ChangeBOMInformation.UI
{
    public partial class guiChooseHistoryLog : BOSERPScreen
    {


        public guiChooseHistoryLog()
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

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            ((ChangeBOMInformationModule)Module).HistoryCheckedChange(selectAllCheckEdit.Checked);
            fld_dgcGEObjectHistorys?.RefreshDataSource();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
