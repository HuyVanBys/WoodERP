using System;

namespace BOSERP.Modules.MachineGroup
{
    public class MachineGroupEntities : ERPModuleEntities
    {

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset receipt items
        /// </summary>
        /// 
        public BOSList<ICMachinesInfo> MachineGroupList { get; set; }
        public BOSList<ICMachineGroupsInfo> MachineGroupTSCDList { get; set; }
        public BOSList<ICMachineGroupsInfo> MachineGroupCCDCList { get; set; }

        #endregion

        #region Constructor
        public MachineGroupEntities()
            : base()
        {
            MachineGroupList = new BOSList<ICMachinesInfo>();
            MachineGroupTSCDList = new BOSList<ICMachineGroupsInfo>();
            MachineGroupCCDCList = new BOSList<ICMachineGroupsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions

        public override void InitModuleObjectList()
        {
            MachineGroupTSCDList.InitBOSList(this,
                                            string.Empty,
                                            "ICMachineGroups",
                                            BOSList<ICMachineGroupsInfo>.cstRelationNone);

            MachineGroupCCDCList.InitBOSList(this,
                                           string.Empty,
                                           "ICMachineGroups",
                                           BOSList<ICMachineGroupsInfo>.cstRelationForeign);
            MachineGroupList.InitBOSList(this,
                                           string.Empty,
                                           "ICMachines",
                                           BOSList<ICMachineGroupsInfo>.cstRelationForeign);

        }

        public override void InitGridControlInBOSList()
        {
            MachineGroupTSCDList.InitBOSListGridControl("fld_dgcMachineGroupTSCD");
            MachineGroupCCDCList.InitBOSListGridControl("fld_dgcMachineGroupCCDC");
            MachineGroupList.InitBOSListGridControl("fld_dgcMachineGroups");
        }



        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MachineGroupTSCDList.SetDefaultListAndRefreshGridControl();
                MachineGroupCCDCList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

    }
}
