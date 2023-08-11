﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMWorkShops
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMWorkShopsController
    //Created Date:Tuesday, October 20, 2015
    //-----------------------------------------------------------

    public class MMWorkShopsController : BaseBusinessController
    {
        public MMWorkShopsController()
        {
            dal = new DALBaseProvider("MMWorkShops", typeof(MMWorkShopsInfo));
        }

        public List<MMWorkShopsInfo> GetAllWorkShops()
        {
            DataSet ds = dal.GetDataSet("MMWorkShops_GetAllWorkShops");
            return (List<MMWorkShopsInfo>)GetListFromDataSet(ds);
        }

        public DataSet GetCatcheData(int branchID)
        {
            return dal.GetDataSet("MMWorkShops_GetCatcheData", branchID);
        }
        public DataSet GetCatcheDataByPermission(int? branchID, int? userID)
        {
            return dal.GetDataSet("MMWorkShops_GetCatcheDataByPermission", branchID, userID);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMWorkShopsInfo> workShopList = new List<MMWorkShopsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWorkShopsInfo objWorkShopsInfo = (MMWorkShopsInfo)GetObjectFromDataRow(row);
                    workShopList.Add(objWorkShopsInfo);
                }
            }
            ds.Dispose();
            return workShopList;
        }

        public DataSet GetDataSetOfBranch(string workShopNo
                                        , string workShopContactDepartment
                                        , string workShopContactRoom
                                        , string workShopName
                                        , string workShopContactTitle
                                        , string workShopContactFirstName
                                        , string workShopContactPhone
                                        , string workShopContactEmail
                                        , int branchID)
        {
            return dal.GetDataSet("MMWorkShops_GetDataSetOfBranch", workShopNo
                                                                  , workShopContactDepartment
                                                                  , workShopContactRoom
                                                                  , workShopName
                                                                  , workShopContactTitle
                                                                  , workShopContactFirstName
                                                                  , workShopContactPhone
                                                                  , workShopContactEmail
                                                                  , branchID);
        }

        public DataSet GetDataSetOfBranchList(string workShopNo
                                            , string workShopContactDepartment
                                            , string workShopContactRoom
                                            , string workShopName
                                            , string workShopContactTitle
                                            , string workShopContactFirstName
                                            , string workShopContactPhone
                                            , string workShopContactEmail
                                            , List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetDataSetOfBranch(workShopNo
                                               , workShopContactDepartment
                                               , workShopContactRoom
                                               , workShopName
                                               , workShopContactTitle
                                               , workShopContactFirstName
                                               , workShopContactPhone
                                               , workShopContactEmail
                                               , ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }
            return rtn;
        }

        public List<MMWorkShopsInfo> GetDataSourceForWorkShopByCurrentBranch(int userID
                                                                            , string moduleName
                                                                            , string dataViewPermissionType
                                                                            , int branchID)
        {
            DataSet ds = dal.GetDataSet("MMWorkShops_GetDataSourceForWorkShopByCurrentBranch"
                            , userID
                            , moduleName
                            , dataViewPermissionType
                            , branchID);
            return (List<MMWorkShopsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}