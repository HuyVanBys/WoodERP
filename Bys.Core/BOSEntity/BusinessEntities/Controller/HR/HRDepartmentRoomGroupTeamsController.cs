﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRDepartmentRoomGroupTeams
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRDepartmentRoomGroupTeamsController
    //Created Date:Wednesday, June 19, 2019
    //-----------------------------------------------------------

    public class HRDepartmentRoomGroupTeamsController : BaseBusinessController
    {
        public HRDepartmentRoomGroupTeamsController()
        {
            dal = new DALBaseProvider("HRDepartmentRoomGroupTeams", typeof(HRDepartmentRoomGroupTeamsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRDepartmentRoomGroupTeamsInfo> lst = new List<HRDepartmentRoomGroupTeamsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRDepartmentRoomGroupTeamsInfo obj = (HRDepartmentRoomGroupTeamsInfo)GetObjectFromDataRow(row);
                    lst.Add(obj);
                }
            }
            return lst;
        }
    }
    #endregion
}