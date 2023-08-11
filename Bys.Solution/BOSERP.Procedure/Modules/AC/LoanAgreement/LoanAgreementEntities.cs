using System;

namespace BOSERP.Modules.LoanAgreement
{
    public class LoanAgreementEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the account list
        /// </summary>
        #endregion

        #region Constructor
        public LoanAgreementEntities()
            : base()
        {
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACLoanAgreementsInfo();
            SearchObject = new ACLoanAgreementsInfo();
        }
        #endregion
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACLoanAgreementsInfo objLoanAgreementsInfo = (ACLoanAgreementsInfo)MainObject;
            objLoanAgreementsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objLoanAgreementsInfo.ACLoanAgreementDate = DateTime.Now;
            objLoanAgreementsInfo.ACLoanAgreementDeadline = DateTime.Now;
            objLoanAgreementsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
        }
    }
}
