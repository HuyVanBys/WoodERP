using BOSCommon.Constants;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Account
{
    public partial class guiAddNewAccount : BOSERPScreen
    {
        #region Public Properties

        #endregion

        public guiAddNewAccount()
        {
            InitializeComponent();

        }

        private void guiAddNewAccount_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            AccountEntities entity = (AccountEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)entity.ModuleObjects[TableName.ACAccountsTableName];
            entity.UpdateModuleObjectBindingSource(TableName.ACAccountsTableName);
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

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_chkACAccountCenterExpense_CheckChanged(object sender, EventArgs e)
        {

            if (fld_chkACAccountCenterExpense.CheckState == CheckState.Unchecked)
            {
                fld_lkeACAccountControlAccountCenterExpense.EditValue = string.Empty;
                fld_lkeACAccountControlAccountCenterExpense.Properties.ReadOnly = true;
            }
            else
            {
                fld_lkeACAccountControlAccountCenterExpense.Properties.ReadOnly = false;
            }
        }

        private void fld_chkACAccountItemExpense_CheckChanged(object sender, EventArgs e)
        {
            if (fld_chkACAccountItemExpense.CheckState == CheckState.Unchecked)
            {
                fld_lkeACAccountControlAccountItemExpense.EditValue = string.Empty;
                fld_lkeACAccountControlAccountItemExpense.Properties.ReadOnly = true;
            }
            else
            {
                fld_lkeACAccountControlAccountItemExpense.Properties.ReadOnly = false;
            }
        }

        private void fld_chkACAccountProject_CheckChanged(object sender, EventArgs e)
        {
            if (fld_chkACAccountProject.CheckState == CheckState.Unchecked)
            {
                fld_lkeACAccountControlAccountProject.EditValue = string.Empty;
                fld_lkeACAccountControlAccountProject.Properties.ReadOnly = true;
            }
            else
            {
                fld_lkeACAccountControlAccountProject.Properties.ReadOnly = false;
            }
        }


    }
}
