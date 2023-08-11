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

namespace BOSERP.Modules.Product
{
    public partial class guiAddProductImage : BOSERPScreen
    {
        private const string ModuleName = "Task";
        #region Variables
        public string ProductImageFile { get; set; }

        #endregion

        public guiAddProductImage()
        {
            InitializeComponent();
        }

        private void guiAddPhase_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_txtICProductImageFile.Text = "Link hình ảnh";
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
            ProductImageFile = fld_txtICProductImageFile.EditValue.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}