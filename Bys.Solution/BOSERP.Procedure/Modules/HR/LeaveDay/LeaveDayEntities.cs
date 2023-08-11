using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.LeaveDay
{
    public class LeaveDayEntities : ERPModuleEntities
    {
        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the leave day list corresponding with the currrent
        /// search criteria
        /// </summary>
        public BOSList<HRLeaveDaysInfo> LeaveDayList { get; set; }
        public List<HRLeaveDaysInfo> LeaveDayListBackup { get; set; }
        #endregion

        #region Constructor
        public LeaveDayEntities()
            : base()
        {
            LeaveDayList = new BOSList<HRLeaveDaysInfo>(this, string.Empty, TableName.HRLeaveDaysTableName);
            LeaveDayListBackup = new List<HRLeaveDaysInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
        }

        public override void InitModuleObjects()
        {
        }

        public override void InitModuleObjectList()
        {

        }

        public override void InitGridControlInBOSList()
        {
            LeaveDayList.InitBOSListGridControl(LeaveDayModule.LeaveDayGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {

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
            LeaveDayList.Invalidate(iObjectID);
            LeaveDayListBackup.Clear();
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var item in LeaveDayList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    item.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                LeaveDayListBackup.Add(item);
            }
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {

        }
        #endregion                
    }
}
