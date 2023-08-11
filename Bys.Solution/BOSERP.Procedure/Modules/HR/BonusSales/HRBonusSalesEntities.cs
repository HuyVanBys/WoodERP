using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.BonusSales
{
    public class BonusSalesEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the employee payroll list
        /// </summary>
        public BOSList<HRBonusSaleItemsInfo> EmployeeBonusSaleList { get; set; }
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        #endregion

        #region Constructor
        public BonusSalesEntities()
            : base()
        {
            EmployeeBonusSaleList = new BOSList<HRBonusSaleItemsInfo>();
            EmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRBonusSalesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRBonusSaleItemsTableName, new HRBonusSaleItemsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeBonusSaleList.InitBOSList(
                                            this,
                                            TableName.HRBonusSalesTableName,
                                            TableName.HRBonusSaleItemsTableName,
                                            BOSList<HRBonusSaleItemsInfo>.cstRelationForeign);
            EmployeeBonusSaleList.ItemTableForeignKey = "FK_HRBonusSaleID";
            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeBonusSaleList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)MainObject;
            objBonusSalesInfo.HRBonusSaleDate = BOSApp.GetCurrentServerDate();
            objBonusSalesInfo.HRBonusSaleFromDate = new DateTime(BOSApp.GetCurrentServerDate().Year, BOSApp.GetCurrentServerDate().Month, 1);
            objBonusSalesInfo.HRBonusSaleToDate = new DateTime(BOSApp.GetCurrentServerDate().Year, BOSApp.GetCurrentServerDate().Month, DateTime.DaysInMonth(objBonusSalesInfo.HRBonusSaleDate.Year, objBonusSalesInfo.HRBonusSaleDate.Month));
            objBonusSalesInfo.HRBonusSaleStatus = BonusSaleStatus.New.ToString();
            objBonusSalesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeBonusSaleList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            EmployeeBonusSaleList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            EmployeeBonusSaleList.SaveItemObjects();
        }
        #endregion        
    }
}
