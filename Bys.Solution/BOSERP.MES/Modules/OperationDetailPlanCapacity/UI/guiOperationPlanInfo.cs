using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public partial class guiOperationPlanInfo : BOSERPScreen
    {
        public DateTime OperationDetailPlanCapacityFromdate;
        public int OperationDetailPlanCapacityOperationID;
        public guiOperationPlanInfo()
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

        private void guiOperationPlanInfo_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            Accept();
        }
        public void Accept()
        {
            int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out OperationDetailPlanCapacityOperationID);
            if (fld_lkeMMOperationID.EditValue != null && OperationDetailPlanCapacityOperationID > 0)
                int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out OperationDetailPlanCapacityOperationID);

            DialogResult = DialogResult.OK;
            Close();
        }
        private void fld_btnOK_Enter(object sender, EventArgs e)
        {
            Accept();
        }

        private void fld_lkeMMOperationID_QueryPopUp(object sender, CancelEventArgs e)
        {
            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationOnCapacity();
            if (operationList != null && operationList.Count > 0)
                fld_lkeMMOperationID.Properties.DataSource = operationList;
        }
    }
}
