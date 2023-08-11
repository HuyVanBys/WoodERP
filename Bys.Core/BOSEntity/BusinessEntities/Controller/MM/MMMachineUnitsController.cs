﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMMachineUnits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMMachineUnitsController
    //Created Date:Monday, September 09, 2019
    //-----------------------------------------------------------

    public class MMMachineUnitsController : BaseBusinessController
    {
        public MMMachineUnitsController()
        {
            dal = new DALBaseProvider("MMMachineUnits", typeof(MMMachineUnitsInfo));
        }
        public List<MMMachineUnitsInfo> GetMachineUnitDataBySomeConditions(int? worShopID
            , int? lineID
            , string operationListID)
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetMachineUnitDataBySomeConditions", worShopID, lineID, operationListID);
            List<MMMachineUnitsInfo> UnitList = new List<MMMachineUnitsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMMachineUnitsInfo item = (MMMachineUnitsInfo)GetObjectFromDataRow(row);
                    UnitList.Add(item);
                }
            }
            return UnitList;
        }
        public List<MMMachineUnitsInfo> GetMachineUnitDataByOperationAndSomeConditions(int? worShopID
            , int? lineID
            , string operationListID)
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetMachineUnitDataByOperationAndSomeConditions", worShopID, lineID, operationListID);
            List<MMMachineUnitsInfo> UnitList = new List<MMMachineUnitsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMMachineUnitsInfo item = (MMMachineUnitsInfo)GetObjectFromDataRow(row);
                    UnitList.Add(item);
                }
            }
            return UnitList;
        }
        public List<MMMachineUnitsInfo> GetMachineUnitBySomeCriteria(string UnitNo, string UnitName)
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetMachineUnitBySomeCriteria", UnitNo, UnitName);
            return (List<MMMachineUnitsInfo>)GetListFromDataSet(ds);
        }
        public List<MMMachineUnitsInfo> GetMachineUnitAndDeparmentRoomUnitBySomeCriteria(string listBPNID, string operationList)
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetMachineUnitAndDeparmentRoomUnitBySomeCriteria", listBPNID, operationList);
            return (List<MMMachineUnitsInfo>)GetListFromDataSet(ds);
        }
        public List<MMMachineUnitsInfo> GetAllMachineUnitAndDeparmentRoomUnit()
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetAllMachineUnitAndDeparmentRoomUnit");
            return (List<MMMachineUnitsInfo>)GetListFromDataSet(ds);
        }
        public List<MMMachineUnitsInfo> GetFilterMachineUnitDataBySomeCriteria(int? worShopID
             , int? lineID
             , string operationListID
             , string semiProductList)
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetFilterMachineUnitDataBySomeCriteria", worShopID, lineID, operationListID, semiProductList);
            return (List<MMMachineUnitsInfo>)GetListFromDataSet(ds);
        }
        public List<MMMachineUnitsInfo> GetUnLoadAnCapacityByMachineList(string listID)
        {
            DataSet ds = dal.GetDataSet("MMMachineUnits_GetUnLoadAndCapacityByMachineList", listID);
            return (List<MMMachineUnitsInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMMachineUnitsInfo> list = new List<MMMachineUnitsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMMachineUnitsInfo item = (MMMachineUnitsInfo)GetObjectFromDataRow(row);
                    list.Add(item);
                }
            }
            ds.Dispose();
            return list;
        }
    }
    #endregion
}