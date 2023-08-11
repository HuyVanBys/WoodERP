﻿using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class guiZoom : BOSERPScreen
    {
        #region Public Properties
        string ProductNo = string.Empty;
        string ProductName = string.Empty;
        #endregion
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
        public guiZoom(string no, string name)
        {
            InitializeComponent();
            ProductNo = no;
            ProductName = name;
            fld_txtICProductNo.Text = ProductNo;
            fld_txtICProductName.Text = ProductName;
        }
        private void guiZoom_Load(object sender, EventArgs e)
        {
            //InitializeControls(Controls);
            //SetImage(ProductImage);
            this.Refresh();
        }

        public void AddCtrl(Control ctl)
        {
            ctl.Parent = panelMain;
        }

        private void guiZoom_ResizeBegin(object sender, EventArgs e)
        {

        }
    }
}