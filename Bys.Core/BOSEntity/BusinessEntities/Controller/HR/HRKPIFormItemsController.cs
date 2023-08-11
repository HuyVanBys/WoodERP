﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRKPIFormItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRKPIFormItemsController
    //Created Date:Friday, June 29, 2018
    //-----------------------------------------------------------

    public class HRKPIFormItemsController : BaseBusinessController
    {
        public HRKPIFormItemsController()
        {
            dal = new DALBaseProvider("HRKPIFormItems", typeof(HRKPIFormItemsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRKPIFormItemsInfo> KPIFormItems = new List<HRKPIFormItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRKPIFormItemsInfo objKPIFormItemsInfo = (HRKPIFormItemsInfo)GetObjectFromDataRow(row);
                    KPIFormItems.Add(objKPIFormItemsInfo);
                }
            }
            return KPIFormItems;
        }

        public List<HRKPIFormItemsInfo> GetKPIFormItemByBranchDepartmentAndDepartmentRoom(int? branchID
                                                                                            , int? departmentID
                                                                                            , int? departmentRoomID
                                                                                            , string kPIFormNo)
        {
            DataSet ds = dal.GetDataSet("HRKPIFormItems_GetKPIFormItemByBranchDepartmentAndDepartmentRoom", branchID
                                                                                                           , departmentID
                                                                                                           , departmentRoomID
                                                                                                           , kPIFormNo);
            List<HRKPIFormItemsInfo> kPIFormItemsList = new List<HRKPIFormItemsInfo>();
            HRKPIFormItemsController objKPIFormItemsController = new HRKPIFormItemsController();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    HRKPIFormItemsInfo objKPIFormItemsInfo = (HRKPIFormItemsInfo)objKPIFormItemsController.GetObjectFromDataRow(dr);
                    kPIFormItemsList.Add(objKPIFormItemsInfo);
                }
            }
            return kPIFormItemsList;
        }

        public List<HRKPIFormItemsInfo> GetKPIFormItemByFK_HRKPIFormID(int kPIFormID)
        {
            return (List<HRKPIFormItemsInfo>)GetListFromDataSet(dal.GetDataSet("HRKPIFormItems_GetKPIFormItemByFK_HRKPIFormID", kPIFormID));
        }

        public List<HRKPIFormItemsInfo> GetKPIFormItemByKPIFormList(string kPIFormID)
        {
            return (List<HRKPIFormItemsInfo>)GetListFromDataSet(dal.GetDataSet("HRKPIFormItems_GetKPIFormItemByKPIFormList", kPIFormID));
        }
    }
    #endregion
}