using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.ConfigSalesFormulaPayroll
{
    public class ConfigSalesFormulaPayrollEntities : BaseTransactionEntities
    {
        #region Declare all entities variables


        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSList<HRConfigSalesFormulaPayrollItemsInfo> ConfigSalesFormulaPayrollItemList { get; set; }

        #endregion

        #region Constructor
        public ConfigSalesFormulaPayrollEntities()
            : base()
        {
            ConfigSalesFormulaPayrollItemList = new BOSList<HRConfigSalesFormulaPayrollItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new HRConfigSalesFormulaPayrollsInfo();
            MainObject = new HRConfigSalesFormulaPayrollsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRConfigSalesFormulaPayrollItemsTableName, new HRConfigSalesFormulaPayrollItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ConfigSalesFormulaPayrollItemList.InitBOSList(this,
                                            TableName.HRConfigSalesFormulaPayrollsTableName,
                                            TableName.HRConfigSalesFormulaPayrollItemsTableName,
                                            BOSList<HRConfigSalesFormulaPayrollItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            ConfigSalesFormulaPayrollItemList.InitBOSListGridControl("fld_dgcConfigSalesFormulaPayrollItemsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ConfigSalesFormulaPayrollItemList.SetDefaultListAndRefreshGridControl();
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
            HRConfigSalesFormulaPayrollsInfo mainObject = (HRConfigSalesFormulaPayrollsInfo)MainObject;
            mainObject.HRConfigSalesFormulaPayrollDate = BOSApp.GetCurrentServerDate();
            mainObject.HRConfigSalesFormulaPayrollToDate = BOSApp.GetCurrentServerDate();
            mainObject.HRConfigSalesFormulaPayrollFromDate = BOSApp.GetCurrentServerDate();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ConfigSalesFormulaPayrollItemList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ConfigSalesFormulaPayrollItemList.SaveItemObjects();
        }
        #endregion
    }
}
