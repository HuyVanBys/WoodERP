using BOSComponent;
using System;

namespace BOSERP.Modules.ATMCardManage.UI
{
    /// <summary>
    /// Summary description for DMATMCM100
    /// </summary>
    public partial class DMATMCM100 : BOSERPScreen
    {

        public DMATMCM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((ATMCardManageModule)this.Module).AddEmployeeToOTList();
        }

        private void Fld_lkeHREmployeeATMCardManageStatus_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                string status = e.Value.ToString();
                ((ATMCardManageModule)this.Module).ChangeEmloyeeCardStatus(status);
            }
        }
    }
}
