﻿using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleForecast
{
    public partial class guiDiffPrice : BOSERPScreen
    {
        public guiDiffPrice()
        {
            InitializeComponent();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void guiDiffPrice_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        private void fld_txtARSaleForecastSODiffPricePercent_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeDiffPricePercent();
        }

        private void fld_txtARSaleForecastSODiffPriceAmount_Validated(object sender, EventArgs e)
        {
            ((SaleForecastModule)Module).ChangeDiffPriceAmount();
        }
    }
}
