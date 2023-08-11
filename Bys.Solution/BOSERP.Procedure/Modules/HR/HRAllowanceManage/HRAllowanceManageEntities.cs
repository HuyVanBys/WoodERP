using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using System;
using System.Data;

namespace BOSERP.Modules.HRAllowanceManage
{
    class HRAllowanceManageEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeeAllowancesInfo> HREmployeeAllowancesList { get; set; }
        public BOSList<HRAllowanceItemsInfo> HRAllowanceItemsList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        #endregion

        #region Constructor
        public HRAllowanceManageEntities()
            : base()
        {
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRAllowancesInfo();
            SearchObject = new HRAllowancesInfo();
            HREmployeeAllowancesList = new BOSList<HREmployeeAllowancesInfo>();
            HRAllowanceItemsList = new BOSList<HRAllowanceItemsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeAllowancesTableName, new HREmployeeAllowancesInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeAllowancesList.InitBOSList(
                                            this,
                                            TableName.HRAllowancesTableName,
                                            TableName.HREmployeeAllowancesTableName,
                                            BOSList<HREmployeeAllowancesInfo>.cstRelationForeign);
            HREmployeeAllowancesList.ItemTableForeignKey = "FK_HRAllowanceID";

            HRAllowanceItemsList.InitBOSList(
                                            this,
                                            TableName.HRAllowancesTableName,
                                            TableName.HRAllowanceItemsTableName,
                                            BOSList<HRAllowanceItemsInfo>.cstRelationForeign);
            HRAllowanceItemsList.ItemTableForeignKey = "FK_HRAllowanceID";

            HREmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeAllowancesList.InitBOSListGridControl();
            HRAllowanceItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeAllowancesList.SetDefaultListAndRefreshGridControl();
                HRAllowanceItemsList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeAllowancesList.Invalidate(iObjectID);
            HRAllowanceItemsList.Invalidate(iObjectID);
            InvalidateEmployeeAllowancesList(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeeAllowancesList.SaveItemObjects();
        }
        #endregion

        /// <summary>
        /// Set default values employee Allowance from employee
        /// </summary>
        /// <param name="objEmployeeAllowancesInfo">Info of table HREmployeeAllowances</param>
        /// <param name="objEmployeesInfo">Info of table HREmployees</param>
        public void SetDefaultValuesFromEmployee(HREmployeeAllowancesInfo objEmployeeAllowancesInfo, HREmployeesInfo objEmployeesInfo)
        {
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)MainObject;
            objEmployeeAllowancesInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeeAllowancesInfo.FK_HRAllowanceID = objAllowancesInfo.HRAllowanceID;
            objEmployeeAllowancesInfo.HREmployeeAllowanceValue = objAllowancesInfo.HRAllowanceValue;
            objEmployeeAllowancesInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeeAllowancesInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;

            // Set default config
            //objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = objEmployeesInfo.HREmployeeExtraSalary1;
            objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = objEmployeesInfo.HREmployeeJobPerformanceAmt;
            objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria = 100;
            objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria = 100;
            objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria = 100;
            objEmployeeAllowancesInfo.HREmployeeAllowanceExactlyCriteria = 100;
            ((HRAllowanceManageModule)Module).CalAllowanceAmount(objEmployeeAllowancesInfo);

            UpdateModuleObjectBindingSource(TableName.HREmployeeAllowancesTableName);
        }

        /// <summary>
        /// Invalidate employee Allowance list and its grid control
        /// </summary>
        /// <param name="AllowanceID">ID of Allowance</param>
        public void InvalidateEmployeeAllowancesList(int allowanceID)
        {
            HREmployeeAllowancesController objEmployeeAllowancesController = new HREmployeeAllowancesController();
            DataSet dsEmployeeAllowance = objEmployeeAllowancesController.GetEmployeeAllowanceListByAllowanceID(allowanceID);
            HREmployeeAllowancesList.Invalidate(dsEmployeeAllowance);
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var item in HREmployeeAllowancesList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                item.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("HRAllowance");
            if (objGENumberingInfo != null)
            {
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
                if (objMainObjectController != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    strMainObjectNo = String.Format("{0}{1}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = String.Format("{0}{1}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            return strMainObjectNo;
        }

    }
}
