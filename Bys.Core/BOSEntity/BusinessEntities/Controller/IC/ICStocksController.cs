using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICStocks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICStocksController
    //Created Date:Sunday, March 23, 2008
    //-----------------------------------------------------------


    public class ICStocksController : BaseBusinessController
    {
        public ICStocksController()
        {
            dal = new DALBaseProvider("ICStocks", typeof(ICStocksInfo));
        }

        public ICStocksInfo GetStockByType(String type)
        {
            String query = String.Format("SELECT * FROM ICStocks WHERE AAStatus <> 'Delete' AND ICStockType = '{0}'", type);
            DataSet ds = GetDataSet(query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ICStocksInfo objStocksInfo = (ICStocksInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                ds.Dispose();
                return objStocksInfo;
            }
            ds.Dispose();
            return null;
        }

        public ICStocksInfo GetStockByTypeAndBranchID(String type, int branchID)
        {
            String query = String.Format("SELECT * FROM ICStocks WHERE AAStatus <> 'Delete' AND ICStockType = '{0}' AND FK_BRBranchID = {1}", type, branchID);
            DataSet ds = GetDataSet(query);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                query = String.Format("SELECT * FROM ICStocks WHERE AAStatus = 'Alive' AND ICStockType = '{0}'", type);
                ds = GetDataSet(query);
            }

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ICStocksInfo objStocksInfo = (ICStocksInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                ds.Dispose();
                return objStocksInfo;
            }
            ds.Dispose();
            return null;
        }

        /// <summary>
        /// Get stocks that their inventory can be seen by an user group
        /// </summary>
        /// <param name="userGroupID">User group id</param>
        /// <returns>List of stocks</returns>
        public List<ICStocksInfo> GetStocksByUserGroupID(int userGroupID)
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetStocksByUserGroupID", userGroupID);
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }
        public List<ICStocksInfo> GetStocksByUserGroupIDAndType(int userGroupID)
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetStocksByUserGroupIDAndType", userGroupID);
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }

        public List<ICStocksInfo> GetStockPermissionByUserGroupID(int userGroupID)
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetStockPermissionByUserGroupID", userGroupID, null);
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }

        public List<ICStocksInfo> GetStockPermissionByUserGroupID(int userGroupID, string stockTypeRef)
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetStockPermissionByUserGroupID", userGroupID, stockTypeRef);
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }
        /// <summary>
        /// Get all stocks
        /// </summary>
        /// <returns>List of all stocks</returns>
        public List<ICStocksInfo> GetAllStocks()
        {
            DataSet ds = GetAllObjects();
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICStocksInfo> stocks = new List<ICStocksInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICStocksInfo objStocksInfo = (ICStocksInfo)GetObjectFromDataRow(row);
                    stocks.Add(objStocksInfo);
                }
            }
            ds.Dispose();
            return stocks;
        }

        //[NUThao] [Improve Speed] [2014-09-09]
        public DataSet GetAllStocksForLookupControl(int userGroupID)
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetAllStocksForLookupControl", userGroupID);
            return ds;
        }
        //[NUThao] [Improve Speed] [2014-09-09]

        public DataSet GetAllParentOjects()
        {
            return dal.GetDataSet("ICStocks_GetStockList");
        }
        public List<ICStocksInfo> GetListStockForAcceptance()
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetListStockForAcceptance");
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }
        public List<ICStocksInfo> GetListRealStock()
        {
            DataSet ds = dal.GetDataSet("ICStocks_GetListRealStock");
            return (List<ICStocksInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}