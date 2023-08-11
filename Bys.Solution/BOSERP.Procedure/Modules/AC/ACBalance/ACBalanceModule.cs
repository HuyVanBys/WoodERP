using BOSCommon;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.ACBalance
{
    public class ACBalanceModule : BaseModuleERP
    {
        public ACBalanceModule()
        {
            Name = "ACBalance";
            CurrentModuleEntity = new ACBalanceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void SaveItem()
        {
            ACBalanceEntities entity = (ACBalanceEntities)CurrentModuleEntity;
            if (entity.ACBalanceList.CurrentIndex < 0)
                return;

            ACBalancesInfo objBalancesInfo = entity.ACBalanceList[entity.ACBalanceList.CurrentIndex];

            if (objBalancesInfo.FK_ACAccountID == 0 || objBalancesInfo.FK_BRBranchID == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin tải khoản và chi nhánh !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ACAccountsController accountController = new ACAccountsController();
            ACAccountsInfo account = (ACAccountsInfo)accountController.GetAccountByID(objBalancesInfo.FK_ACAccountID);
            if (account.ACAccountType == AccountType.DebitCreditBalance.ToString() && objBalancesInfo.FK_ACObjectID == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cho tài khoản lưỡng tính !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ACBalancesController controller = new ACBalancesController();
            if (objBalancesInfo.ACBalanceID > 0)
            {
                controller.UpdateObject(objBalancesInfo);
                return;
            }
            controller.CreateObject(objBalancesInfo);
        }

        public void DeleteItem()
        {
            ACBalanceEntities entity = (ACBalanceEntities)CurrentModuleEntity;
            if (entity.ACBalanceList.CurrentIndex < 0)
                return;
            ACBalancesInfo objBalancesInfo = entity.ACBalanceList[entity.ACBalanceList.CurrentIndex];
            ACBalancesController controller = new ACBalancesController();
            controller.DeleteObject(objBalancesInfo.ACBalanceID);

            entity.ACBalanceList.RemoveSelectedRowObjectFromList();
        }

        public void ChangedItem()
        {
            ACBalanceEntities entity = (ACBalanceEntities)CurrentModuleEntity;
            if (entity.ACBalanceList.CurrentIndex < 0)
                return;
            ACBalancesInfo objBalancesInfo = entity.ACBalanceList[entity.ACBalanceList.CurrentIndex];
            UpdateAmount(objBalancesInfo);
        }

        private void UpdateAmount(ACBalancesInfo item)
        {
            item.ACBalanceDebitExchangeAmount = item.ACBalanceDebitAmount * item.ACBalanceExchangeRate;
            item.ACBalanceCreditExchangeAmount = item.ACBalanceCreditAmount * item.ACBalanceExchangeRate;
        }
    }
}
