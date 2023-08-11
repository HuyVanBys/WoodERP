using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.MachineTimeKeeper
{
    public class MachineTimeKeeperEntities : ERPModuleEntities
    {

        #region Public Properties
        /// <summary>
        /// Gets or sets the leave day list corresponding with the currrent
        /// search criteria
        /// </summary>
        public BOSList<HRMachineTimeKeepersInfo> MachineTimeKeeperList { get; set; }

        public BOSList<HRTimeKeepersInfo> TimeKeeperList { get; set; }
        #endregion

        #region Constructor
        public MachineTimeKeeperEntities()
            : base()
        {
            MachineTimeKeeperList = new BOSList<HRMachineTimeKeepersInfo>(this, string.Empty, TableName.HRMachineTimeKeepersTableName);
            TimeKeeperList = new BOSList<HRTimeKeepersInfo>(this, string.Empty, TableName.HRTimeKeepersTableName);
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRMachineTimeKeepersInfo();
        }

        public override void InitModuleObjects()
        {
            base.InitModuleObjects();
        }

        public override void InitModuleObjectList()
        {
            base.InitModuleObjectList();
        }

        //public override void InitGridControlInBOSList()
        //{
        //    //LeaveDayList.InitBOSListGridControl(MachineTimeKeeperModule.LeaveDayGridControlName);
        //}

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
            base.InvalidateModuleObjects(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
        }
        #endregion

        public void SaveData(List<HRTimeKeepersInfo> timeKeeperList)
        {
            TimeKeeperList = new BOSList<HRTimeKeepersInfo>(this, string.Empty, TableName.HRTimeKeepersTableName);
            TimeKeeperList.AddRange(timeKeeperList);
            TimeKeeperList.SaveItemObjects();

        }
    }
}
