﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRTimeKeepers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTimeKeepersController
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HRTimeKeepersController : BaseBusinessController
    {
        public HRTimeKeepersController()
        {
            dal = new DALBaseProvider("HRTimeKeepers", typeof(HRTimeKeepersInfo));
        }
        /// <summary>
        /// Check data of machine of datecheck is exist in database
        /// </summary>
        /// <param name="machineID">ID of machine</param>
        /// <param name="dateCheck">Date check</param>
        /// <returns></returns>
        public int CheckExistData(int machineID, DateTime dateCheck)
        {
            return Convert.ToInt32(dal.GetSingleValue("HRTimeKeepers_CheckExistData", machineID, dateCheck));
        }
        public int DeleteData(int machineID, DateTime dateCheck)
        {
            return Convert.ToInt32(dal.GetSingleValue("HRTimeKeepers_DeleteData", machineID, dateCheck));
        }

        public List<HRTimeKeepersInfo> GetTimeKeeperByDate(string employeeCardNo, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperByDate", employeeCardNo, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<HRTimeKeepersInfo> GetTimeKeeperByMachineAndByDate(int? machineID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperByMachineAndByDate", machineID, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<HRTimeKeepersInfo> GetTimeKeeperByConditions(int? departmentID, int? departmentRoomID, int? departmentRoomGroupItemID, int? departmentRoomGroupTeamItemID, int? employeeID, int? employeePayrollFormulaID, int? machineID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperByConditions", departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupTeamItemID, employeeID, employeePayrollFormulaID, machineID, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    obj.HRTimeKeeperTimeInOutModeName = row["HRTimeKeeperTimeInOutModeName"].ToString();
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<HRTimeKeepersInfo> GetTimeKeeperByConditions2(int? departmentID, int? departmentRoomID, int? employeeID, int? machineID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperByConditions2", departmentID, departmentRoomID, employeeID, machineID, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public int DeleteDataByMachineAndByDate(int? machineID, DateTime? dateFrom, DateTime? dateTo)
        {
            return Convert.ToInt32(dal.GetSingleValue("HRTimeKeepers_DeleteDataByMachineAndByDate", machineID, dateFrom, dateTo));
        }

        public List<HRTimeKeepersInfo> GetTimeKeeperDistinctByDate(int? machineID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperDistinctByDate", machineID, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<HRTimeKeepersInfo> GetTimeKeeperDistinctByDateAndWorkShopID(int? WorkShopID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperDistinctByDateAndWorkShopID", WorkShopID, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }

        public List<HRTimeKeepersInfo> GetTimeKeeperByMachineAndDate(int? machineID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRTimeKeepers_GetTimeKeeperByMachineAndDate", machineID, dateFrom, dateTo);
            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeepersInfo obj = (HRTimeKeepersInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
    }
    #endregion
}