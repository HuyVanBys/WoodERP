using System;

namespace BOSERP.Modules.ACVAT
{
    public class ACVATEntities : BaseTransactionEntities
    {
        public ACVATEntities()
            : base()
        {

        }

        public override void InitMainObject()
        {
            MainObject = new ACVATsInfo();
            SearchObject = new ACVATsInfo();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACVATsInfo objVATsInfo = (ACVATsInfo)MainObject;
            objVATsInfo.ACVATDate = DateTime.Now;
        }

        public void UpdateTotalAmount()
        {
            ACVATsInfo objVATsInfo = (ACVATsInfo)MainObject;
            objVATsInfo.ACVATTaxAmount = objVATsInfo.ACVATAmount * objVATsInfo.ACVATTaxPercent / 100;
            objVATsInfo.ACVATTotalAmount = objVATsInfo.ACVATAmount + objVATsInfo.ACVATTaxAmount;
            UpdateMainObjectBindingSource();
        }
    }
}
