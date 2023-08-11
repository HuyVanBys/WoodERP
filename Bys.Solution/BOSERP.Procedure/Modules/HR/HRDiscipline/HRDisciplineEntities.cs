using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.HRDiscipline
{
    class HRDisciplineEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeeDisciplinesInfo> HREmployeeDisciplinesList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        #endregion

        #region Constructor
        public HRDisciplineEntities()
            : base()
        {
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRDisciplinesInfo();
            SearchObject = new HRDisciplinesInfo();
            HREmployeeDisciplinesList = new BOSList<HREmployeeDisciplinesInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeDisciplinesTableName, new HREmployeeDisciplinesInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeDisciplinesList.InitBOSList(
                                            this,
                                            TableName.HRDisciplinesTableName,
                                            TableName.HREmployeeDisciplinesTableName,
                                            BOSList<HREmployeeDisciplinesInfo>.cstRelationForeign);
            HREmployeeDisciplinesList.ItemTableForeignKey = "FK_HRDisciplineID";

            HREmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeDisciplinesList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRDisciplinesInfo objDisciplinesInfo = (HRDisciplinesInfo)MainObject;
            objDisciplinesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDisciplinesInfo.HRDisciplineToDate = objDisciplinesInfo.HRDisciplineFromDate;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeDisciplinesList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeDisciplinesList.Invalidate(iObjectID);
            InvalidateEmployeeDisciplineList(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeeDisciplinesList.SaveItemObjects();
        }
        #endregion


        #region Local

        /// <summary>
        /// Set default values employee discipline from employee
        /// </summary>
        /// <param name="objEmployeeDisciplinesInfo">Info of table HREmployeeDisciplines</param>
        /// <param name="objEmployeesInfo">Info of table HREmployees</param>
        public void SetDefaultValuesFromEmployee(HREmployeeDisciplinesInfo objEmployeeDisciplinesInfo, HREmployeesInfo objEmployeesInfo)
        {
            float result = 0;
            HRDisciplinesInfo objDisciplinesInfo = (HRDisciplinesInfo)MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            objEmployeeDisciplinesInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeeDisciplinesInfo.FK_HRDisciplineID = objDisciplinesInfo.HRDisciplineID;
            objEmployeeDisciplinesInfo.HREmployeeDisciplineValue = objDisciplinesInfo.HRDisciplineValue;
            objEmployeeDisciplinesInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeeDisciplinesInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            objEmployeeDisciplinesInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
            objEmployeeDisciplinesInfo.FK_HREmployeeID2 = objDisciplinesInfo.FK_HREmployeeRequest;
            objEmployeeDisciplinesInfo.HREmployeeDisciplineType = objDisciplinesInfo.HRDisciplineType;
            objEmployeeDisciplinesInfo.HREmployeeDisciplineGroup = objDisciplinesInfo.HRDisciplineName;
            objEmployeeDisciplinesInfo.FK_HRLevelID = objEmployeesInfo.FK_HRLevelID;
            HREmployeesInfo employeeRequest = (HREmployeesInfo)objEmployeesController.GetObjectByID(objDisciplinesInfo.FK_HREmployeeRequest);
            objDisciplinesInfo.HRDisciplineEmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            objDisciplinesInfo.HRDisciplineEmployeeName = objEmployeesInfo.HREmployeeName;
            if (employeeRequest != null)
            {
                objEmployeeDisciplinesInfo.FK_HRLevelID2 = employeeRequest.FK_HRLevelID;
            }
            objEmployeeDisciplinesInfo.HREmployeeDisciplineNo = objDisciplinesInfo.HRDisciplineNumber;
            objEmployeeDisciplinesInfo.HREmployeeDisciplineExplain = objDisciplinesInfo.HRDisciplineExplain;
            objEmployeeDisciplinesInfo.HREmployeeDisciplineDate = objDisciplinesInfo.HRDisciplineFromDate;
            if (objDisciplinesInfo.HRDisciplineType.Contains("Amount"))
            {
                if (!objDisciplinesInfo.HRDisciplineValue.Equals(String.Empty) && Single.TryParse(objDisciplinesInfo.HRDisciplineValue, out result))
                {
                    objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = Convert.ToDecimal(objDisciplinesInfo.HRDisciplineValue);
                }
                else
                {
                    objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = 0;
                }
            }
            if (objDisciplinesInfo.HRDisciplineType.Contains("WorkDay"))
            {
                if (!objDisciplinesInfo.HRDisciplineValue.Equals(String.Empty) && Single.TryParse(objEmployeeDisciplinesInfo.HREmployeeDisciplineValue, out result))
                {
                    if (objEmployeesInfo.HRPayRollCalculatedSalaryType.Equals("Working"))
                    {
                        decimal workDayAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt / objEmployeesInfo.HREmployeeDaysPerMonth;
                        objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = workDayAmount * Convert.ToDecimal(objEmployeeDisciplinesInfo.HREmployeeDisciplineValue);
                        //objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = BOSApp.RoundingAmount(objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount, 1000);
                    }
                    else
                    {
                        decimal workDayAmount = objEmployeesInfo.HREmployeeContractSlrAmt * objEmployeesInfo.HREmployeeSalaryFactor / objEmployeesInfo.HREmployeeDaysPerMonth;
                        objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = workDayAmount * Convert.ToDecimal(objEmployeeDisciplinesInfo.HREmployeeDisciplineValue);
                        //objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = BOSApp.RoundingAmount(objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount, 1000);
                    }
                }
                else
                {
                    objEmployeeDisciplinesInfo.HREmployeeDisciplineValueAmount = 0;
                }
            }
            UpdateModuleObjectBindingSource(TableName.HREmployeeDisciplinesTableName);
        }

        /// <summary>
        /// Invalidate employee discipline list and its grid control
        /// </summary>
        /// <param name="disciplineID">ID of discipline</param>
        public void InvalidateEmployeeDisciplineList(int disciplineID)
        {
            HREmployeeDisciplinesController objEmployeeDisciplinesController = new HREmployeeDisciplinesController();
            DataSet dsEmployeeDiscipline = objEmployeeDisciplinesController.GetEmployeeDisciplineListByDisciplineID(disciplineID);
            HREmployeeDisciplinesList.Invalidate(dsEmployeeDiscipline);
        }
        #endregion


    }
}
