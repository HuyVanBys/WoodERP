using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentRoundWood

{
    public partial class guiChooseDate : BOSERPScreen
    {
        public DateTime FromDate =DateTime.Now;
        public guiChooseDate()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FromDate = DateTime.Now;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FromDate = fld_dteICShipmentDate.DateTime;
            Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                InitializeFieldFormat(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChooseDate_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            FromDate = DateTime.Now;
            fld_dteICShipmentDate.DateTime = DateTime.Now;
        }
    }
}
