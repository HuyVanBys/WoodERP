using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.HRReward
{
    public class HRRewardEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeeRewardsInfo> HREmployeeRewardsList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        public BOSList<HRRewardsInfo> HRRewardsList { get; set; }
        #endregion

        #region Constructor
        public HRRewardEntities()
            : base()
        {
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRRewardsInfo();
            SearchObject = new HRRewardsInfo();
            HREmployeeRewardsList = new BOSList<HREmployeeRewardsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeRewardsTableName, new HREmployeeRewardsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeRewardsList.InitBOSList(
                                            this,
                                            TableName.HRRewardsTableName,
                                            TableName.HREmployeeRewardsTableName,
                                            BOSList<HREmployeeRewardsInfo>.cstRelationForeign);
            HREmployeeRewardsList.ItemTableForeignKey = "FK_HRRewardID";
            HREmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeRewardsList.InitBOSListGridControl();
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)MainObject;
            objRewardsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeRewardsList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeRewardsList.Invalidate(iObjectID);
            InvalidateEmployeeRewardList(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeeRewardsList.SaveItemObjects();
        }
        #endregion

        /// <summary>
        /// Set default values employee reward from employee
        /// </summary>
        /// <param name="objEmployeeRewardsInfo">Info of Table HREmployeeRewards </param>
        /// <param name="objEmployeesInfo">Info of Table HREmployees</param>
        public void SetDefaultValuesFromEmployee(HREmployeeRewardsInfo objEmployeeRewardsInfo, HREmployeesInfo objEmployeesInfo)
        {
            float result = 0;
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)MainObject;
            objEmployeeRewardsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeeRewardsInfo.FK_HRRewardID = objRewardsInfo.HRRewardID;
            objEmployeeRewardsInfo.HREmployeeRewardValue = objRewardsInfo.HRRewardValue;
            objEmployeeRewardsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeeRewardsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            if (objRewardsInfo.HRRewardType.Contains("Amount"))
            {
                if (!objRewardsInfo.HRRewardValue.Equals(String.Empty) && Single.TryParse(objRewardsInfo.HRRewardValue, out result))
                {
                    objEmployeeRewardsInfo.HREmployeeRewardValueAmount = Convert.ToDecimal(objRewardsInfo.HRRewardValue);
                }
                else
                {
                    objEmployeeRewardsInfo.HREmployeeRewardValueAmount = 0;
                }
            }
            if (objRewardsInfo.HRRewardType.Contains("WorkDay"))
            {
                if (!objRewardsInfo.HRRewardValue.Equals(String.Empty) && Single.TryParse(objEmployeeRewardsInfo.HREmployeeRewardValue, out result))
                {
                    if (objEmployeesInfo.HRPayRollCalculatedSalaryType.Equals("Working"))
                    {
                        decimal workDayAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt / objEmployeesInfo.HREmployeeDaysPerMonth;
                        objEmployeeRewardsInfo.HREmployeeRewardValueAmount = workDayAmount * Convert.ToDecimal(objEmployeeRewardsInfo.HREmployeeRewardValue);
                        objEmployeeRewardsInfo.HREmployeeRewardValueAmount = BOSApp.RoundingAmount(objEmployeeRewardsInfo.HREmployeeRewardValueAmount, 1000);
                    }
                    else
                    {
                        decimal workDayAmount = objEmployeesInfo.HREmployeeContractSlrAmt * objEmployeesInfo.HREmployeeSalaryFactor / objEmployeesInfo.HREmployeeDaysPerMonth;
                        objEmployeeRewardsInfo.HREmployeeRewardValueAmount = workDayAmount * Convert.ToDecimal(objEmployeeRewardsInfo.HREmployeeRewardValue);
                        objEmployeeRewardsInfo.HREmployeeRewardValueAmount = BOSApp.RoundingAmount(objEmployeeRewardsInfo.HREmployeeRewardValueAmount, 1000);
                    }
                }
                else
                {
                    objEmployeeRewardsInfo.HREmployeeRewardValueAmount = 0;
                }
            }
            UpdateModuleObjectBindingSource(TableName.HREmployeeRewardsTableName);
        }

        /// <summary>
        /// Invalidate employee reward list and its grid control 
        /// </summary>
        /// <param name="rewardID">ID of reward</param>
        public void InvalidateEmployeeRewardList(int rewardID)
        {
            HREmployeeRewardsController objEmployeeRewardsController = new HREmployeeRewardsController();
            DataSet ds = objEmployeeRewardsController.GetRewardListByRewardID(rewardID);
            HREmployeeRewardsList.Invalidate(ds);
        }
    }
}
