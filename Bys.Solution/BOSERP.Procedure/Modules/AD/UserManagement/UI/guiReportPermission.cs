﻿using System;
namespace BOSERP.Modules.UserManagement
{
    public partial class guiReportPermission : BOSERPScreen
    {
        public guiReportPermission()
        {
            InitializeComponent();
        }

        public override void InitializeControls()
        {
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ReportPermissionsList.InitBOSListGridControl(fld_dgcADReportPermissions);
            fld_dgcADReportPermissions.Screen = this;
            fld_dgcADReportPermissions.InitializeControl();
            ((UserManagementModule)Module).InvalidateReportPermissionList();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).SaveReportPermission();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).ChooseAllReports(fld_chkChooseAll.Checked);
        }
    }
}
