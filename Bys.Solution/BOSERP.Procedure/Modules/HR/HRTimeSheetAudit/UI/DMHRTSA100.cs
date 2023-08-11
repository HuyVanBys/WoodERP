using BOSComponent;
using BOSLib;
using System;

namespace BOSERP.Modules.HRTimeSheetAudit.UI
{
    /// <summary>
    /// Summary description for DMHRTSA100
    /// </summary>
    public partial class DMHRTSA100 : BOSERPScreen
    {

        public DMHRTSA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRTimeSheetAuditModule)Module).AddEmployeeToTimeSheetAudit();
        }

        private void fld_dteHRTimeSheetAuditDate_Validated(object sender, EventArgs e)
        {
            int n1 = fld_dteHRTimeSheetAuditDate.DateTime.Year;
            int n2 = fld_dteHRTimeSheetAuditDate.DateTime.Month;
            DateTime date = new DateTime(n1, n2, 1);
            DateTime dateEndMonth = BOSUtil.GetMonthEndDate(date);

            fld_dteHRTimeSheetAuditToDate.DateTime = dateEndMonth;
            fld_dteHRTimeSheetAuditFromDate.DateTime = date;
            RefreshTimeSheetTimeAudit();
        }

        private void fld_lkeHRTimeSheetAuditType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((HRTimeSheetAuditModule)Module).ChangeTimeSheetAuditType(e.Value.ToString());
            }
        }

        private void fld_dteHRTimeSheetAuditFromDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime dt = (DateTime)e.NewValue;
            int n1 = fld_dteHRTimeSheetAuditFromDate.DateTime.Year;
            int n2 = fld_dteHRTimeSheetAuditFromDate.DateTime.Month;
            if (dt.Date > ((DateTime)fld_dteHRTimeSheetAuditFromDate.EditValue).Date) fld_dteHRTimeSheetAuditToDate.DateTime = dt.Date;
            RefreshTimeSheetTimeAudit();
        }

        private void fld_dteHRTimeSheetAuditToDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime dt = (DateTime)e.NewValue;
            if (dt.Date < ((DateTime)fld_dteHRTimeSheetAuditFromDate.EditValue).Date) fld_dteHRTimeSheetAuditFromDate.DateTime = dt.Date;
            RefreshTimeSheetTimeAudit();
        }

        private void fld_btnAddFromFile_Click(object sender, EventArgs e)
        {
            ((HRTimeSheetAuditModule)Module).AddEmployeesFromTimeKeeper();
        }

        private void RefreshTimeSheetTimeAudit()
        {
            ((HRTimeSheetAuditModule)Module).isCustomDrawCell = false;
            ((HRTimeSheetAuditModule)Module).ChangeTimeSheetTimeAudit();
        }
    }
}
