using BOSCommon.Constants;
using System.Collections.Generic;


namespace BOSERP.Modules.RemindWorking
{
    public class RemindWorkingEntities : ERPModuleEntities
    {
        #region Public Properties

        public BOSList<ADRemindWorkingsInfo> RemindWorkingNewMessagesList { get; set; }

        public BOSList<ADRemindWorkingsInfo> RemindWorkingSentMessagesList { get; set; }
        #endregion

        #region Constructor
        public RemindWorkingEntities()
            : base()
        {
            RemindWorkingNewMessagesList = new BOSList<ADRemindWorkingsInfo>();
            RemindWorkingSentMessagesList = new BOSList<ADRemindWorkingsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ADRemindWorkingsInfo();
        }

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();
            InitDataToModuleObjectList();
        }

        public void InitDataToModuleObjectList()
        {
            int employeeID = BOSApp.CurrentUsersInfo == null ? 0 : BOSApp.CurrentUsersInfo.FK_HREmployeeID;

            if (employeeID == 0)
                return;

            ADRemindWorkingConfigsController objRemindWorkingConfigsController = new ADRemindWorkingConfigsController();
            ADRemindWorkingConfigsInfo objRemindWorkingConfigsInfo = objRemindWorkingConfigsController.GetRemindWorkingConfigByEmployeeID(employeeID);
            if (objRemindWorkingConfigsInfo == null)
            {
                objRemindWorkingConfigsInfo = new ADRemindWorkingConfigsInfo()
                {
                    ADRemindWorkingConfigDate = 10,
                    ADRemindWorkingConfigTime = 15,
                    FK_HREmployeeID = employeeID,
                    ADRemindWorkingConfigType = "Second"
                };
                objRemindWorkingConfigsController.CreateObject(objRemindWorkingConfigsInfo);
            }
            ADRemindWorkingsController objRemindWorkingsController = new ADRemindWorkingsController();
            List<ADRemindWorkingsInfo> remindNewList = objRemindWorkingsController.GetRemindWorkingNewByEmployeeID(employeeID, objRemindWorkingConfigsInfo.ADRemindWorkingConfigDate);
            RemindWorkingNewMessagesList.Invalidate(remindNewList);
            List<ADRemindWorkingsInfo> remindSentList = objRemindWorkingsController.GetRemindWorkingSentByEmployeeID(employeeID, objRemindWorkingConfigsInfo.ADRemindWorkingConfigDate);
            RemindWorkingSentMessagesList.Invalidate(remindSentList);
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ADRemindWorkingsTable, new ADRemindWorkingsInfo());
        }

        public override void InitGridControlInBOSList()
        {
            RemindWorkingNewMessagesList.InitBOSListGridControl(RemindWorkingModule.RemindWorkingNewMessagesGridControl);
            RemindWorkingSentMessagesList.InitBOSListGridControl(RemindWorkingModule.RemindWorkingSentMessagesGridControl);
        }
        #endregion
    }
}
