using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BOSCommon;

namespace BOSERP.Modules.PriceSheet
{
    public partial class guiUpdatePriceSheetEndDate : BOSERPScreen
    {
        #region Variables
        public ARPriceSheetsInfo CurrentPriceSheet { get; set; }
        #endregion

        public guiUpdatePriceSheetEndDate(ARPriceSheetsInfo priceSheet)
        {
            InitializeComponent();
            CurrentPriceSheet = priceSheet;
        }

        private void guiUpdateDelivery_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}