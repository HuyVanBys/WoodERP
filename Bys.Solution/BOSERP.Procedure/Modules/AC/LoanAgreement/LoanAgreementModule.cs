using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.LoanAgreement
{
    public class LoanAgreementModule : BaseModuleERP
    {
        #region Constants
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public LoanAgreementModule()
        {
            Name = "LoanAgreement";
            CurrentModuleEntity = new LoanAgreementEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

        }
        public override void ActionNew()
        {
            base.ActionNew();
        }
        public override void ActionEdit()
        {
            LoanAgreementEntities entity = (LoanAgreementEntities)CurrentModuleEntity;
            ACLoanAgreementsInfo mainobject = (ACLoanAgreementsInfo)entity.MainObject;
            ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
            List<ACLoanReceiptsInfo> list = objLoanReceiptsController.GetDateByLoanAgreementID(mainobject.ACLoanAgreementID);
            if (list != null && list.Count > 0)
            {
                BOSApp.ShowMessage("Hợp đồng vay này đã tạo những khế ước vay sau nên không thể sửa!" + Environment.NewLine + " * " +
                                  string.Join(Environment.NewLine + " * ", list.Select(x => Convert.ToString(x.ACLoanReceiptNo)).Distinct().ToList().ToArray()));

                return;
            }
            base.ActionEdit();
        }
        public override int ActionSave()
        {
            LoanAgreementEntities entity = (LoanAgreementEntities)CurrentModuleEntity;
            ACLoanAgreementsInfo mainobject = (ACLoanAgreementsInfo)entity.MainObject;
            if (mainobject.ACLoanAgreementDeadline.Date < mainobject.ACLoanAgreementDate.Date)
            {
                BOSApp.ShowMessage("Ngày kết thúc hợp đồng không được nhỏ hơn ngày hợp đồng!");
                return 0;
            }
            mainobject.ACLoanAgreementRemainAmount = mainobject.ACLoanAgreementAmount - mainobject.ACLoanAgreementReceiptAmount;
            BOSApp.RoundByCurrency(mainobject, mainobject.FK_GECurrencyID);

            return base.ActionSave();
        }

        public void ChangeCurrency(int currencyID)
        {
            LoanAgreementEntities entity = (LoanAgreementEntities)CurrentModuleEntity;
            ACLoanAgreementsInfo main = (ACLoanAgreementsInfo)entity.MainObject;

            main.FK_GECurrencyID = currencyID;
            BOSApp.RoundByCurrency(main, main.FK_GECurrencyID);
        }

        public void UpdateLoanAgreementAmount()
        {
            ACLoanAgreementsInfo mainObject = (ACLoanAgreementsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACLoanAgreementAmount = mainObject.ACLoanAgreementTotalLimit - mainObject.ACLoanAgreementLCLimit;
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ACLoanAgreementsInfo mainObject = (ACLoanAgreementsInfo)CurrentModuleEntity.MainObject;
            ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
            DataSet ds = objLoanReceiptsController.GetDataSetLoanReceiptListByBranchID(null, mainObject.ACLoanAgreementID, null, null, null, null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            }
        }
        #endregion
    }
}
