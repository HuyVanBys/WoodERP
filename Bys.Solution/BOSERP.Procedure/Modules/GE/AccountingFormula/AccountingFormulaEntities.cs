using BOSCommon.Constants;
using System;


namespace BOSERP.Modules.AccountingFormula
{
    public class AccountingFormulaEntities : BaseTransactionEntities
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
        public AccountingFormulaEntities()
            : base()
        {
            AccountingFormulaItemList = new BOSList<GEAccountingFormulaItemsInfo>();

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new GEAccountingFormulasInfo();
            SearchObject = new GEAccountingFormulasInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.GEAccountingFormulaItemsTableName, new GEAccountingFormulaItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AccountingFormulaItemList.InitBOSList(this,
                                                              TableName.GEAccountingFormulasTableName,
                                                              TableName.GEAccountingFormulaItemsTableName,
                                                              BOSList<GEAccountingFormulaItemsInfo>.cstRelationForeign);
            AccountingFormulaItemList.ItemTableForeignKey = "FK_GEAccountingFormulaID";


        }

        public override void InitGridControlInBOSList()
        {
            AccountingFormulaItemList.InitBOSListGridControl(AccountingFormulaModule.AccountingFormulaGridControlName);

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

            GEAccountingFormulasInfo AccountingFormulasInfo = (GEAccountingFormulasInfo)MainObject;
            AccountingFormulasInfo.GEAccountingFormulaDate = DateTime.Now;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            AccountingFormulaItemList.Invalidate(iObjectID);


        }
        #endregion

        #region Save Module Objects Functions        
        public override void SaveModuleObjects()
        {
            GEAccountingFormulasInfo mainObject = (GEAccountingFormulasInfo)MainObject;
            UpdateMainObject();
            foreach (GEAccountingFormulaItemsInfo item in AccountingFormulaItemList)
            {
                item.GEAccountingFormulaItemAccountNo = item.GEAccountingFormulaItemAccountNo.ToUpper();
                item.GEAccountingFormulaItemFormula = item.GEAccountingFormulaItemFormula.ToUpper();
                item.GEAccountingFormulaItemType = item.GEAccountingFormulaItemType.ToUpper();
                item.GEAccountingFormulaItemBold = item.GEAccountingFormulaItemBold.ToUpper();
            }
            AccountingFormulaItemList.SaveItemObjects();
        }


        #endregion
    }
}
