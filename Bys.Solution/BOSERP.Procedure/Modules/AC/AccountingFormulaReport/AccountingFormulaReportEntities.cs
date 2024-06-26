using BOSCommon.Constants;
using System;


namespace BOSERP.Modules.AccountingFormulaReport
{
    public class AccountingFormulaReportEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSList<GEAccountingFormulaItemsInfo> AccountingFormulaItemList { get; set; }

        #endregion

        #region Constructor
        public AccountingFormulaReportEntities()
            : base()
        {
            AccountingFormulaItemList = new BOSList<GEAccountingFormulaItemsInfo>();

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            //MainObject = new GEAccountingFormulasInfo();
            //SearchObject = new GEAccountingFormulasInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.GEAccountingFormulaItemsTableName, new GEAccountingFormulaItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AccountingFormulaItemList.InitBOSList(this,
                                                              string.Empty,
                                                              TableName.GEAccountingFormulaItemsTableName,
                                                              BOSList<GEAccountingFormulaItemsInfo>.cstRelationNone);



        }

        public override void InitGridControlInBOSList()
        {
            AccountingFormulaItemList.InitBOSListGridControl(AccountingFormulaReportModule.AccountingFormulaGridControlName);

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AccountingFormulaItemList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
        }
        #region Save Module Objects Functions        
        #endregion
    }
}
