using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountInitialBalance
{
    public partial class guiAccountDetails : BOSERPScreen
    {
        public guiAccountDetails()
        {
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

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((AccountInitialBalanceModule)Module).SaveAccountDetails();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void guiAccountDetails_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.AccountDetailList.InitBOSListGridControl(fld_dgcAccountDetails);

            fld_lkeGECurrencyID.EditValue = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            InvalidateAccountDetails();
        }

        private void fld_lkeACObjectID_EditValueChanged(object sender, EventArgs e)
        {
            InvalidateAccountDetails();
        }

        private void fld_lkeGECurrencyID_EditValueChanged(object sender, EventArgs e)
        {
            InvalidateAccountDetails();
        }

        /// <summary>
        /// Invalidate the details of the account
        /// </summary>
        private void InvalidateAccountDetails()
        {
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo obj = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            ((AccountInitialBalanceModule)Module).InvalidateAccountDetails(obj.ACObjectID, obj.ACObjectType, currencyID);
        }
    }
}
