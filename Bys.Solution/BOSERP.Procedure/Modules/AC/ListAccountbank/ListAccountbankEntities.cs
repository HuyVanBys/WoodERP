using BOSCommon;

namespace BOSERP.Modules.ListAccountBank
{
    public class ListAccountBankEntities : BaseTransactionEntities
    {
        public ListAccountBankEntities()
            : base()
        {

        }

        public override void InitMainObject()
        {
            MainObject = new ACListAccountBanksInfo();
            SearchObject = new ACListAccountBanksInfo();
        }

        public override void SetDefaultMainObject()
        {
            ACListAccountBanksInfo objACListAccountBanksInfo = (ACListAccountBanksInfo)MainObject;
            objACListAccountBanksInfo.ACListAccountBankStatus = ListAccountBankStatus.New.ToString();
            UpdateMainObjectBindingSource();
            base.SetDefaultMainObject();
        }

        public override bool CompleteTransaction()
        {
            ACListAccountBanksInfo objACListAccountBanksInfo = (ACListAccountBanksInfo)MainObject;
            objACListAccountBanksInfo.ACListAccountBankStatus = ListAccountBankStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }
    }
}
