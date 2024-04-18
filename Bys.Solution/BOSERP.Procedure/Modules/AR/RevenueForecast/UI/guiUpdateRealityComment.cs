using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;

namespace BOSERP.Modules.RevenueForecast
{
    public partial class guiUpdateRealityComment : BOSERPScreen
    {
        #region Variables
        public string RealityComment { get; set; }

        #endregion

        public guiUpdateRealityComment(string realityComment)
        {
            InitializeComponent();
            RealityComment = realityComment;
        }

        private void guiAddPhase_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_medARRevenueForecastItemRealComment.Text = RealityComment;
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
            RealityComment = fld_medARRevenueForecastItemRealComment.EditValue.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}