﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region ICMachineGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICMachineGroupsController
    //Created Date:Friday, January 18, 2019
    //-----------------------------------------------------------

    public class ICMachineGroupsController : BaseBusinessController
    {
        public ICMachineGroupsController()
        {
            dal = new DALBaseProvider("ICMachineGroups", typeof(ICMachineGroupsInfo));
        }
        public DataSet GetListByMachineID(int machineID, bool isAsset)
        {
            return dal.GetDataSet("ICMachineGroups_GetListByMachineID", machineID, isAsset);
        }
    }
    #endregion
}