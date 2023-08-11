using BOSLib;
using System;

namespace BOSERP.Modules.EndingAllocation
{
    public class EndingAllocationEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACEndingAllocationItemsInfo> ACEndingAllocationItemsList { get; set; }
        #endregion

        #region Constructor
        public EndingAllocationEntities()
            : base()
        {
            ACEndingAllocationItemsList = new BOSList<ACEndingAllocationItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACEndingAllocationsInfo();
            SearchObject = new ACEndingAllocationsInfo();
        }

        public override void InitModuleObjectList()
        {
            ACEndingAllocationItemsList.InitBOSList(
                                              this,
                                              "ACEndingAllocations",
                                              "ACEndingAllocationItems",
                                              BOSList<ACEndingAllocationItemsInfo>.cstRelationForeign);
            ACEndingAllocationItemsList.ItemTableForeignKey = "FK_ACEndingAllocationID";




        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ACEndingAllocationItemsList.InitBOSListGridControl();


        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACEndingAllocationItemsList.SetDefaultListAndRefreshGridControl();


            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACEndingAllocationItemsList.Invalidate(iObjectID);

        }

        public override void SaveModuleObjects()
        {
            ACEndingAllocationItemsList.SaveItemObjects();

            ACEndingAllocationsInfo EndingAllocationsInfo = (ACEndingAllocationsInfo)MainObject;

            ACActualCostBudgetDetailsController detailController = new ACActualCostBudgetDetailsController();
            detailController.InsertByEndingAllocation(EndingAllocationsInfo.ACEndingAllocationNo, this.Module.Name, BOSApp.CurrentUsersInfo.ADUserName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACEndingAllocationsInfo EndingAllocationsInfo = (ACEndingAllocationsInfo)MainObject;

            EndingAllocationsInfo.ACEndingAllocationFromDate = BOSUtil.GetMonthBeginDate();
            EndingAllocationsInfo.ACEndingAllocationToDate = BOSUtil.GetMonthEndDate();
            EndingAllocationsInfo.ACEndingAllocationDate = EndingAllocationsInfo.ACEndingAllocationToDate;

            GECurrenciesController currencyController = new GECurrenciesController();
            GECurrenciesInfo currency = (GECurrenciesInfo)currencyController.GetObjectByNo("VND");

            if (currency != null)
            {
                EndingAllocationsInfo.FK_GECurrencyID = currency.GECurrencyID;
                EndingAllocationsInfo.ACEndingAllocationExchangeRate = 1;
            }

            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACEndingAllocationItems", new ACEndingAllocationItemsInfo());

        }
    }
}
