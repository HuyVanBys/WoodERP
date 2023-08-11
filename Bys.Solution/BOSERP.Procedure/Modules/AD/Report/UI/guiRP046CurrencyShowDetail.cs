﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class guiRP046CurrencyShowDetail : BOSERPScreen
    {
        public List<ACDocumentEntrysInfo> DocumentEntryList { get; set; }
        public guiRP046CurrencyShowDetail(List<ACDocumentEntrysInfo> documentEntrys)
        {
            DocumentEntryList = documentEntrys;
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
        private void guiRP046IShowDetail_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitializeDataSource();
        }
        private void InitializeDataSource()
        {
            fld_dgcRP046CurrencyACDocumentEntrys.DataSource = DocumentEntryList;
            fld_dgcRP046CurrencyACDocumentEntrys.RefreshDataSource();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}