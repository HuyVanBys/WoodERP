﻿using BOSLib;


namespace BOSERP
{
    #region MMOperationMachineGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMOperationMachineGroupsController
    //Created Date:Thursday, January 17, 2019
    //-----------------------------------------------------------

    public class MMOperationMachineGroupsController : BaseBusinessController
    {
        public MMOperationMachineGroupsController()
        {
            dal = new DALBaseProvider("MMOperationMachineGroups", typeof(MMOperationMachineGroupsInfo));
        }
    }
    #endregion
}