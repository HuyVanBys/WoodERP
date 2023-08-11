using BOSComponent;
using System;

namespace BOSERP.Modules.ATMCardPayroll.UI
{
    /// <summary>
    /// Summary description for DMATMCM100
    /// </summary>
    public partial class DMATMCP100 : BOSERPScreen
    {

        public DMATMCP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((ATMCardPayrollModule)this.Module).AddEmployeeToList();
        }

        private void Fld_lkeHREmployeeATMCardManageStatus_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if(e.Value != null && e.Value != lke.OldEditValue)
            //{
            //    string status = e.Value.ToString();
            //    ((ATMCardManageModule)this.Module).ChangeEmloyeeCardStatus(status);
            //}
        }

        private void Fld_lkeFK_CSCompanyBankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int companyBankID = Convert.ToInt32(e.Value.ToString());
                ((ATMCardPayrollModule)this.Module).ChangeCompanyBank(companyBankID);

            }
        }

        private void Fld_lkeFK_BRBranchID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int branchID = Convert.ToInt32(e.Value.ToString());
                //((ATMCardPayrollModule)this.Module).ChangeBranch(branchID);

            }
        }

        private void Fld_medHRATMCardPayrollDesc_Validated(object sender, EventArgs e)
        {
            ((ATMCardPayrollModule)this.Module).ChangeDesc();
        }

        private void fld_txtHRATMCardPayrollBankCN_Validated(object sender, EventArgs e)
        {
            ((ATMCardPayrollModule)this.Module).ChangeBranch();
        }
    }
}
