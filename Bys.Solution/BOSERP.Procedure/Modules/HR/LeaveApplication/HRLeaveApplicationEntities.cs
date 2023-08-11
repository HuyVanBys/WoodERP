using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.LeaveApplication
{
    public class LeaveApplicationEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRRequestLeaveDaysInfo> LeaveApplicationList { get; set; }
        #endregion

        #region Constructor
        public LeaveApplicationEntities()
            : base()
        {
            LeaveApplicationList = new BOSList<HRRequestLeaveDaysInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRRequestLeaveDaysInfo();
            SearchObject = new HRRequestLeaveDaysInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRRequestLeaveDaysTableName, new HRRequestLeaveDaysInfo());
        }

        public override void InitModuleObjectList()
        {
            LeaveApplicationList.InitBOSList(
                                            this,
                                            TableName.HRRequestLeaveDaysTableName,
                                            TableName.HRRequestLeaveDaysTableName,
                                            BOSList<HRRequestLeaveDaysInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            LeaveApplicationList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRRequestLeaveDaysInfo objLeaveApplicationsInfo = (HRRequestLeaveDaysInfo)MainObject;
            objLeaveApplicationsInfo.HRLeaveApplicationDate = BOSApp.GetCurrentServerDate();
            objLeaveApplicationsInfo.HRRequestLeaveDayFromDate = BOSApp.GetCurrentServerDate();
            objLeaveApplicationsInfo.HRRequestLeaveDayToDate = BOSApp.GetCurrentServerDate();
            objLeaveApplicationsInfo.HRRequestLeaveDayStatus = LeaveApplicationStatus.New.ToString();
            objLeaveApplicationsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            ADUsersInfo objUsersInfo = BOSApp.CurrentUsersInfo;
            if (objUsersInfo != null)
            {
                objLeaveApplicationsInfo.FK_HREmployeeLeaveID = objUsersInfo.FK_HREmployeeID;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                LeaveApplicationList.SetDefaultListAndRefreshGridControl();
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
            base.InvalidateModuleObjects(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            HRRequestLeaveDaysInfo objLeaveApplicationsInfo = (HRRequestLeaveDaysInfo)MainObject;
            objLeaveApplicationsInfo.HRLeaveApplicationDate = objLeaveApplicationsInfo.HRLeaveApplicationDate.Date;
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {

        }
        #endregion

        public void GenerateLeaveDay(HRRequestLeaveDaysInfo objHRRequestLeaveDaysInfo)
        {
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            HRLeaveDaysInfo objLeaveDaysInfo;
            DateTime dayofMonth;
            int numDays = (int)(objHRRequestLeaveDaysInfo.HRRequestLeaveDayToDate.Date - objHRRequestLeaveDaysInfo.HRRequestLeaveDayFromDate.Date).TotalDays + 1;
            if (numDays > 0)
            {
                for (int i = 1; i <= numDays; i++)
                {
                    dayofMonth = objHRRequestLeaveDaysInfo.HRRequestLeaveDayFromDate.AddDays(i - 1);
                    objLeaveDaysInfo = new HRLeaveDaysInfo();
                    objLeaveDaysInfo.FK_HREmployeeID = objHRRequestLeaveDaysInfo.FK_HREmployeeLeaveID;
                    objLeaveDaysInfo.FK_HRTimeSheetParamID = objHRRequestLeaveDaysInfo.FK_HRTimeSheetParamID;
                    objLeaveDaysInfo.HRLeaveDayDate = dayofMonth.Date;
                    objLeaveDaysController.CreateObject(objLeaveDaysInfo);
                }
            }
        }
    }
}
