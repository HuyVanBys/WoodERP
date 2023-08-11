﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeAllowances
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeAllowancesController
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HREmployeeAllowancesController : BaseBusinessController
    {
        public HREmployeeAllowancesController()
        {
            dal = new DALBaseProvider("HREmployeeAllowances", typeof(HREmployeeAllowancesInfo));
        }
        /// <summary>
        /// Get employee discipline by discipline id
        /// </summary>
        /// <param name="disciplineID">The Id of discipline</param>
        /// <returns>Employee discipline list </returns>
        public DataSet GetEmployeeAllowanceListByAllowanceID(int allowanceID)
        {
            return dal.GetDataSet("HREmployeeAllowances_GetEmployeeAllowanceListByAllowanceID", allowanceID);
        }

        public HREmployeeAllowancesInfo GetEmployeeAllowancesInfoByEmployeeIDAndAllowanceID(int employeeID, int allowanceID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeAllowances_GetEmployeeRewardsInfoByEmployeeIDAndAllowanceID", employeeID, allowanceID);
            if (ds.Tables.Count > 0)
            {
                ds.Dispose();
                return (HREmployeeAllowancesInfo)dal.GetSingleObject(ds.Tables[0]);
            }
            ds.Dispose();
            return null;
        }

        public List<HREmployeeAllowancesInfo> GetEmployeeAllowanceListByAllowanceID2(int allowanceID)
        {
            List<HREmployeeAllowancesInfo> itemList = new List<HREmployeeAllowancesInfo>();
            DataSet ds = dal.GetDataSet("HREmployeeAllowances_GetEmployeeAllowanceListByAllowanceID", allowanceID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeAllowancesInfo objAllowanceItemsInfo = (HREmployeeAllowancesInfo)GetObjectFromDataRow(row);
                    itemList.Add(objAllowanceItemsInfo);
                }
            }
            ds.Dispose();
            return itemList;
        }
        public List<HREmployeeAllowancesInfo> GetDataByMonth(DateTime month)
        {
            List<HREmployeeAllowancesInfo> itemList = new List<HREmployeeAllowancesInfo>();
            DataSet ds = dal.GetDataSet("HREmployeeAllowances_GetDataByMonth", month);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeAllowancesInfo objAllowanceItemsInfo = (HREmployeeAllowancesInfo)GetObjectFromDataRow(row);
                    itemList.Add(objAllowanceItemsInfo);
                }
            }
            ds.Dispose();
            return itemList;
        }
        public List<HREmployeeAllowancesInfo> GetEmployeeAllowanceListByDate(DateTime dateFrom, DateTime dateTo)
        {
            List<HREmployeeAllowancesInfo> itemList = new List<HREmployeeAllowancesInfo>();
            DataSet ds = dal.GetDataSet("HREmployeeAllowances_GetAllowanceListByEmployeeIDAndAllowanceFromDate", dateFrom, dateTo);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeAllowancesInfo objAllowanceItemsInfo = (HREmployeeAllowancesInfo)GetObjectFromDataRow(row);
                    itemList.Add(objAllowanceItemsInfo);
                }
            }
            ds.Dispose();
            return itemList;
        }

        public List<HREmployeeAllowancesInfo> GetAllowanceListByEmployeeIDAndAllowanceFromDateAndCategory(int employeeID, DateTime fromDate, DateTime toDate, string category)
        {
            List<HREmployeeAllowancesInfo> itemList = new List<HREmployeeAllowancesInfo>();
            DataSet ds = dal.GetDataSet("HREmployeeAllowances_GetAllowanceListByEmployeeIDAndAllowanceFromDateAndCategory", employeeID, fromDate, toDate, category);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeAllowancesInfo objAllowanceItemsInfo = (HREmployeeAllowancesInfo)GetObjectFromDataRow(row);
                    itemList.Add(objAllowanceItemsInfo);
                }
            }
            return itemList;
        }
    }
    #endregion
}