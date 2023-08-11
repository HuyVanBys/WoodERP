using System;

namespace BOSERP.Modules.HROverTime.UI
{
    /// <summary>
    /// Summary description for DMHROT100
    /// </summary>
    public partial class DMHROT100 : BOSERPScreen
    {

        public DMHROT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HROverTimeModule)Module).AddEmployeeToOTList();
        }

        private void fld_dteHROverTimeFromDate1_Validated(object sender, EventArgs e)
        {
            ((HROverTimeModule)Module).UpdateDateEnd();
        }
        private void fld_txtHROverTimeDateEnd_Validated(object sender, EventArgs e)
        {
            ((HROverTimeModule)Module).UpdateDateTo();
        }
        private void fld_btnAddEmployeeByListCard_Click(object sender, EventArgs e)
        {
            ((HROverTimeModule)Module).AddEmployeeToOTListByCard();
        }

        private void fld_txtHROverTimeFromDate_Validated(object sender, EventArgs e)
        {
            if (fld_txtHROverTimeFromDate.EditValue != fld_txtHROverTimeFromDate.OldEditValue)
                if (!((HROverTimeModule)Module).ChangeFromTimeOT())
                {
                    fld_txtHROverTimeFromDate.EditValue = fld_txtHROverTimeFromDate.OldEditValue;
                }
        }

        private void fld_txtHROverTimeToDate_Validated(object sender, EventArgs e)
        {
            if (fld_txtHROverTimeToDate.EditValue != fld_txtHROverTimeToDate.OldEditValue)
                if (!((HROverTimeModule)Module).ChangeToTimeOT())
                {
                    fld_txtHROverTimeToDate.EditValue = fld_txtHROverTimeToDate.OldEditValue;
                }
        }

        private void fld_txtHROverTimeFactor_Validated(object sender, EventArgs e)
        {
            ((HROverTimeModule)Module).UpdateHREmployeeOTByOTFactor();
        }


    }
}
