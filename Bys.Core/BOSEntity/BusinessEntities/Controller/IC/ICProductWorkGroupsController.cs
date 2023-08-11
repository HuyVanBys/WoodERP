﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductWorkGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductWorkGroupsController
    //Created Date:12 Tháng Mười Hai 2017
    //-----------------------------------------------------------

    public class ICProductWorkGroupsController : BaseBusinessController
    {
        public ICProductWorkGroupsController()
        {
            dal = new DALBaseProvider("ICProductWorkGroups", typeof(ICProductWorkGroupsInfo));
        }

        public List<ICProductWorkGroupsInfo> GetAllProductWorkGroupList()
        {
            DataSet ds = dal.GetAllObject();
            List<ICProductWorkGroupsInfo> productWorkGroupList = new List<ICProductWorkGroupsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductWorkGroupsInfo objProductWorkGroupsInfo = (ICProductWorkGroupsInfo)GetObjectFromDataRow(row);
                    productWorkGroupList.Add(objProductWorkGroupsInfo);
                }
            }
            return productWorkGroupList;
        }

        public DataSet GetProductWorkGroupListBySomeCriteria(string productWorkGroupNo,
                                                string productWorkGroupName,
                                                int? projectTypeID,
                                                int? phaseTypeID)
        {
            DataSet ds = dal.GetDataSet("ICProductWorkGroups_GetProductWorkGroupListBySomeCriteria", productWorkGroupNo,
                                productWorkGroupName,
                                projectTypeID,
                                phaseTypeID);
            return ds;
        }
    }
    #endregion
}