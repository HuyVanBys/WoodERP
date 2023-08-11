﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARContainerLoaders
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARContainerLoadersController
    //Created Date:Friday, September 23, 2016
    //-----------------------------------------------------------

    public class ARContainerLoadersController : BaseBusinessController
    {
        public ARContainerLoadersController()
        {
            dal = new DALBaseProvider("ARContainerLoaders", typeof(ARContainerLoadersInfo));
        }

        public DataSet GetContainerLoadersBySomeCriteria(string containerLoaderNo, int? employeeID, int brandID, DateTime? fromDate, DateTime? toDate)
        {
            return dal.GetDataSet("ARContainerLoaders_GetContainerLoadersBySomeCriteria", containerLoaderNo, employeeID, brandID, fromDate, toDate);
        }
        public List<ARContainerLoadersInfo> GetContainerLoadersForShipment()
        {
            DataSet ds = dal.GetDataSet("ARContainerLoaders_GetContainerLoadersForShipment");
            List<ARContainerLoadersInfo> ContainerLoaderList = new List<ARContainerLoadersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARContainerLoadersInfo objContainerLoadersInfo = (ARContainerLoadersInfo)GetObjectFromDataRow(row);
                    ContainerLoaderList.Add(objContainerLoadersInfo);
                }
            }
            ds.Dispose();
            return ContainerLoaderList;
        }
        public List<ARContainerLoadersInfo> GetContainerLoadersBySaleOrder(int SaleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARContainerLoaders_GetContainerLoadersBySaleOrder", SaleOrderID);
            List<ARContainerLoadersInfo> ContainerLoaderList = new List<ARContainerLoadersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARContainerLoadersInfo objContainerLoadersInfo = (ARContainerLoadersInfo)GetObjectFromDataRow(row);
                    ContainerLoaderList.Add(objContainerLoadersInfo);
                }
            }
            ds.Dispose();
            return ContainerLoaderList;
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARContainerLoadersInfo> ContainerLoaderList = new List<ARContainerLoadersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARContainerLoadersInfo objContainerLoadersInfo = (ARContainerLoadersInfo)GetObjectFromDataRow(row);
                    ContainerLoaderList.Add(objContainerLoadersInfo);
                }
            }
            ds.Dispose();
            return ContainerLoaderList;
        }

        public List<ARContainerLoadersInfo> GetContainerLoaderNosList(string containerLoaderIDs)
        {
            DataSet ds = dal.GetDataSet("ARContainerLoaders_GetContainerLoaderNosList", containerLoaderIDs);
            return (List<ARContainerLoadersInfo>)GetListFromDataSet(ds);
        }

    }
    #endregion
}