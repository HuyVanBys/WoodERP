using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace BOSERP.Modules.ManagerTimeKeeper
{
    public class ManagerTimeKeeperEntities : ERPModuleEntities
    {

        #region Public Properties
        /// <summary>
        /// Gets or sets the leave day list corresponding with the currrent
        /// search criteria
        /// </summary>
        public BOSList<HRMachineTimeKeepersInfo> MachineTimeKeeperList { get; set; }

        public BOSList<HRTimeKeepersInfo> TimeKeeperList { get; set; }
        public BOSList<HRTimeKeeperCompletesInfo> TimeKeeperCompleteListView { get; set; }

        public List<HRTimeKeeperCompletesInfo> TimeKeeperCompleteBackupList { get; set; }
        public List<HRTimeKeeperCompletesInfo> TimeKeeperCompleteBackupList2 { get; set; }
        public List<HRTimeKeeperCompletesInfo> CompareList { get; set; }
        public BOSList<HRTimeKeeperHistoryDetailsInfo> HRTimeKeeperHistoryDetailList { get; set; }
        #endregion

        #region Constructor
        public ManagerTimeKeeperEntities()
            : base()
        {
            MachineTimeKeeperList = new BOSList<HRMachineTimeKeepersInfo>(this, string.Empty, TableName.HRMachineTimeKeepersTableName);
            TimeKeeperList = new BOSList<HRTimeKeepersInfo>(this, string.Empty, TableName.HRTimeKeepersTableName);
            HRTimeKeeperHistoryDetailList = new BOSList<HRTimeKeeperHistoryDetailsInfo>();
            TimeKeeperCompleteBackupList = new BOSList<HRTimeKeeperCompletesInfo>();
            TimeKeeperCompleteBackupList2 = new BOSList<HRTimeKeeperCompletesInfo>();
            CompareList = new BOSList<HRTimeKeeperCompletesInfo>();
            TimeKeeperCompleteListView = new BOSList<HRTimeKeeperCompletesInfo>(this, string.Empty, TableName.HRTimeKeeperCompletesTableName);
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRMachineTimeKeepersInfo();
        }

        public override void InitModuleObjects()
        {
            base.InitModuleObjects();
            ModuleObjects.Add(TableName.HRMachineTimeKeepersTableName, new HRMachineTimeKeepersInfo());
            ModuleObjects.Add(TableName.HRTimeKeeperHistoryDetailsTableName, new HRTimeKeeperHistoryDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            base.InitModuleObjectList();
            MachineTimeKeeperList.InitBOSList(this, string.Empty, TableName.HRMachineTimeKeepersTableName, BOSList<HRMachineTimeKeepersInfo>.cstRelationNone);
            HRTimeKeeperHistoryDetailList.InitBOSList(this, string.Empty, TableName.HRMachineTimeKeepersTableName, BOSList<HRMachineTimeKeepersInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            TimeKeeperCompleteListView.InitBOSListGridControl("fld_dgcHRTimeKeeperCompletesView");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            base.InvalidateModuleObjects(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
        }
        #endregion

        public void SaveData(List<HRTimeKeepersInfo> timeKeeperList)
        {
            TimeKeeperList = new BOSList<HRTimeKeepersInfo>(this, string.Empty, TableName.HRTimeKeepersTableName);
            TimeKeeperList.AddRange(timeKeeperList);
            //TimeKeeperList.SaveItemObjects();
            HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
            int percent = 0;
            string mess = "Đang lưu dữ liệu: ";
            foreach (HRTimeKeepersInfo item in TimeKeeperList)
            {
                percent++;
                item.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                double pct = (percent * 100) / TimeKeeperList.Count;
                BOSProgressBar.Start(mess + ": " + Math.Round(pct) + " % ");
                objTimeKeepersController.CreateObject(item);
            }
            BOSProgressBar.Close();
        }
        public void SaveDataComplete(List<HRTimeKeeperCompletesInfo> timeKeepeCompleterList)
        {
            BOSList<HRTimeKeeperCompletesInfo> TimeKeeperCompleteList = new BOSList<HRTimeKeeperCompletesInfo>(this, string.Empty, TableName.HRTimeKeeperCompletesTableName);
            TimeKeeperCompleteList.AddRange(timeKeepeCompleterList);
            //TimeKeeperCompleteList.SaveItemObjects();
            HRTimeKeeperCompletesController objTimeKeeperCompletesController = new HRTimeKeeperCompletesController();
            int percent = 0;
            string mess = "Đang lưu dữ liệu: ";
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> columnAliasList = new List<AAColumnAliasInfo>();
            DataSet ds = objColumnAliasController.GetAAColumnAliasByTableName(TableName.HRTimeKeeperCompletesTableName);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objColumnAliasController.GetObjectFromDataRow(row);
                    columnAliasList.Add(objColumnAliasInfo);
                }
            }
            foreach (HRTimeKeeperCompletesInfo item in TimeKeeperCompleteList)
            {
                percent++;
                item.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                double pct = (percent * 100) / TimeKeeperCompleteList.Count;
                BOSProgressBar.Start(mess + ": " + Math.Round(pct) + " % ");
                objTimeKeeperCompletesController.CreateObject(item);
                if (TimeKeeperCompleteBackupList2.Where(o => o.HRTimeKeeperCompleteDate == item.HRTimeKeeperCompleteDate
                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == item.HRTimeKeeperCompletesEmployeeCardNo
                                                                && o.FK_HRTimeKeeperID == item.FK_HRTimeKeeperID).Count() > 0
                    && TimeKeeperCompleteBackupList.Where(o => o.HRTimeKeeperCompleteDate == item.HRTimeKeeperCompleteDate
                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == item.HRTimeKeeperCompletesEmployeeCardNo
                                                                && o.FK_HRTimeKeeperID == item.FK_HRTimeKeeperID).Count() > 0)
                {
                    HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = TimeKeeperCompleteBackupList2.Where(o => o.HRTimeKeeperCompleteDate == item.HRTimeKeeperCompleteDate
                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == item.HRTimeKeeperCompletesEmployeeCardNo
                                                                && o.FK_HRTimeKeeperID == item.FK_HRTimeKeeperID).FirstOrDefault();

                    HRTimeKeeperCompletesInfo objTimeKeeperCompleteOldsInfo = TimeKeeperCompleteBackupList.Where(o => o.HRTimeKeeperCompleteDate == item.HRTimeKeeperCompleteDate
                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == item.HRTimeKeeperCompletesEmployeeCardNo
                                                                && o.FK_HRTimeKeeperID == item.FK_HRTimeKeeperID).FirstOrDefault();
                }
            }
            BOSProgressBar.Close();
        }

        public List<HRTimeKeeperHistoryDetailsInfo> GetDataForTimeKeeperHistoryDetailsGridControl(int departmentIDHistoryView, int departmentRoomIDHistoryView, int employeeIDHistoryView, int employeePayrollFormulaID, DateTime searchHistoryFromDateView, DateTime searchHistoryToDateView)
        {
            HRTimeKeeperHistoryDetailsController objTimeKeeperHistoryDetailsController = new HRTimeKeeperHistoryDetailsController();
            HRTimeKeeperHistoryDetailList.InitBOSList(
                                            this,
                                            TableName.HRTimeKeeperHistorysTableName,
                                            TableName.HRTimeKeeperHistoryDetailsTableName,
                                            BOSList<HRTimeKeeperHistoryDetailsInfo>.cstRelationForeign);

            List<HRTimeKeeperHistoryDetailsInfo> timeKeeperHistoryDetails = objTimeKeeperHistoryDetailsController.GetDataForTimeKeeperHistoryDetailsBySomeCriteria(departmentIDHistoryView, departmentRoomIDHistoryView, employeeIDHistoryView, employeePayrollFormulaID, searchHistoryFromDateView, searchHistoryToDateView);
            List<HRTimeKeeperHistoryDetailsInfo> dataGridViewList = new List<HRTimeKeeperHistoryDetailsInfo>();
            timeKeeperHistoryDetails.ForEach(o =>
            {
                if (o.FK_HRMachineTimeKeeperID == 0 && o.HRTimeKeeperHistoryAction == "New")
                {
                    HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo2 = (HRTimeKeeperHistoryDetailsInfo)o.Clone();
                    objTimeKeeperHistoryDetailsInfo2.HRTimeKeeperHistoryDetailOldValue = DateTime.MinValue.ToString();
                    objTimeKeeperHistoryDetailsInfo2.HRTimeKeeperHistoryDetailNewValue = objTimeKeeperHistoryDetailsInfo2.HRTimeKeeperTimeOut.ToString();
                    objTimeKeeperHistoryDetailsInfo2.HRTimeKeeperHistoryDetailColumnName = "Ngày Vào/Ra";

                    dataGridViewList.Add(objTimeKeeperHistoryDetailsInfo2);

                    HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo = (HRTimeKeeperHistoryDetailsInfo)o.Clone();
                    objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailOldValue = DateTime.MinValue.ToString();
                    objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailNewValue = objTimeKeeperHistoryDetailsInfo.HRTimeKeeperTimeOut.ToString();
                    objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailColumnName = "Thời gian";

                    dataGridViewList.Add(objTimeKeeperHistoryDetailsInfo);
                }
                else if (o.FK_HRMachineTimeKeeperID == 0 && o.HRTimeKeeperHistoryAction == "Change")
                {
                    if (o.HRTimeKeeperTimeOut.Day != o.HRTimeKeeperCompleteDateCheck.Day)
                    {
                        o.HRTimeKeeperHistoryDetailOldValue = o.HRTimeKeeperTimeOut.ToString();
                        o.HRTimeKeeperHistoryDetailNewValue = o.HRTimeKeeperCompleteDateCheck.ToString();
                        o.HRTimeKeeperHistoryDetailColumnName = "Ngày Vào/Ra";
                        dataGridViewList.Add(o);
                    }
                    if (o.HRTimeKeeperCompleteTimeCheck != o.HRTimeKeeperTimeOut)
                    {
                        HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo = (HRTimeKeeperHistoryDetailsInfo)o.Clone();
                        objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailOldValue = objTimeKeeperHistoryDetailsInfo.HRTimeKeeperTimeOut.ToString();
                        objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailNewValue = objTimeKeeperHistoryDetailsInfo.HRTimeKeeperCompleteTimeCheck.ToString();
                        objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailColumnName = "Thời gian";
                        if (o.HRTimeKeeperCompleteComment != null)
                            objTimeKeeperHistoryDetailsInfo.HRTimeKeeperCompleteComment = o.HRTimeKeeperCompleteComment;
                        dataGridViewList.Add(objTimeKeeperHistoryDetailsInfo);
                    }
                }
            });
            return dataGridViewList.OrderBy(o => o.HRTimeKeeperHistoryDate).ToList();
        }
    }
}
