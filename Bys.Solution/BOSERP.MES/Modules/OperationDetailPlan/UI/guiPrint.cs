using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiPrint : BOSERPScreen
    {
        public string PrintType;
        public guiPrint()
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

        private void guiPrintFilter_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_lkePrintJobTicketType.QueryPopUp += new CancelEventHandler(fld_lkePrintJobTicketType_QueryPopUp);
        }

        void fld_lkePrintJobTicketType_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> printJobTicketType = new List<ADConfigValuesInfo>();
            printJobTicketType = objConfigValuesController.GetADConfigValuesByKeyGroup("PrintJobTicketType");
            lookup.Properties.DataSource = printJobTicketType;

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
            PrintType = string.Empty;
            if (fld_lkePrintJobTicketType.EditValue != null)
                PrintType = fld_lkePrintJobTicketType.EditValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
