using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.KPIRegistration.UI
{
    /// <summary>
    /// Summary description for DMKPIR100
    /// </summary>
    public partial class DMKPIR100 : BOSERPScreen
    {

        public DMKPIR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtHRKPIRegistrationTotalAmountBonus_Validated(object sender, EventArgs e)
        {
            if (fld_txtHRKPIRegistrationTotalAmountBonus.EditValue != null)
            {
                ((KPIRegistrationModule)Module).ChangeItemWeight();
            }
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((KPIRegistrationModule)Module).AddEmployeeToList();
        }

        private void fld_lkeFK_HRKPIFormID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRKPIFormsController objKPIFormsController = new HRKPIFormsController();
            List<HRKPIFormsInfo> KPIFormsList = (List<HRKPIFormsInfo>)objKPIFormsController.GetKPIFormList();
            fld_lkeFK_HRKPIFormID.Properties.DataSource = KPIFormsList;
            fld_lkeFK_HRKPIFormID.Properties.DisplayMember = "HRKPIFormName";
            fld_lkeFK_HRKPIFormID.Properties.ValueMember = "HRKPIFormID";
        }

        private void fld_btnChangeKPIForm_Click(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRKPIFormID.EditValue != null)
            {
                int kPIFormID = Convert.ToInt32(fld_lkeFK_HRKPIFormID.EditValue);
                ((KPIRegistrationModule)Module).ChangeItemKPIForm(kPIFormID);
            }
        }

        private void bosDateEdit1_Validated(object sender, EventArgs e)
        {
            int n1 = fld_dteHRKPIRegistrationMonth.DateTime.Year;
            int n2 = fld_dteHRKPIRegistrationMonth.DateTime.Month;
            DateTime date = new DateTime(n1, n2, 1);
            DateTime dateEndMonth = BOSUtil.GetMonthEndDate(date);

            fld_dteHRKPIRegistrationFinishedDate.DateTime = dateEndMonth;
            fld_dteHRKPIRegistrationStartDate.DateTime = date;
        }

        private void fld_dteHRKPIRegistrationMonth_Validated(object sender, EventArgs e)
        {
            int n1 = fld_dteHRKPIRegistrationMonth.DateTime.Year;
            int n2 = fld_dteHRKPIRegistrationMonth.DateTime.Month;
            DateTime date = new DateTime(n1, n2, 1);

            fld_dteHRKPIRegistrationStartDate.DateTime = date;
        }

        private void fld_dteHRKPIRegistrationEndMonth_Validated(object sender, EventArgs e)
        {
            int n1 = fld_dteHRKPIRegistrationEndMonth.DateTime.Year;
            int n2 = fld_dteHRKPIRegistrationEndMonth.DateTime.Month;
            DateTime date = new DateTime(n1, n2, 1);
            DateTime dateEndMonth = BOSUtil.GetMonthEndDate(date);

            fld_dteHRKPIRegistrationFinishedDate.DateTime = dateEndMonth;
        }
    }
}
