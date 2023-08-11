using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.JobTicket
{
    public class JobTicketEntities : ERPModuleEntities
    {
        #region Public Properties
        public BOSList<MMJobTicketItemsInfo> JobTicketItem { get; set; }
        public BOSList<MMOperationDetailPlanItemChildsInfo> DetailPlanList { get; set; }
        public BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList { get; set; }
        public BOSList<MMOperationDetailPlanCapacityItemsInfo> OperationDetailPlanCapacityItemsList { get; set; }
        public BOSList<MMJobTicketItemEmployeesInfo> JobTicketItemEmployeeList { get; set; }
        #endregion

        #region Contructors
        public JobTicketEntities()
            : base()
        {
            JobTicketItem = new BOSList<MMJobTicketItemsInfo>();
            DetailPlanList = new BOSList<MMOperationDetailPlanItemChildsInfo>();
            OperationDetailPlanCapacityItemsList = new BOSList<MMOperationDetailPlanCapacityItemsInfo>();
            OperationDetailPlanItemChildsList = new BOSList<MMOperationDetailPlanItemChildsInfo>();
            JobTicketItemEmployeeList = new BOSList<MMJobTicketItemEmployeesInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMJobTicketsInfo();
            SearchObject = new MMJobTicketsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("MMJobTicketItems", new MMJobTicketItemsInfo());
            ModuleObjects.Add("MMOperationDetailPlanItemChilds", new MMOperationDetailPlanItemChildsInfo());
            ModuleObjects.Add(TableName.MMOperationDetailPlanItemsTableName, new MMOperationDetailPlanCapacityItemsInfo());
            ModuleObjects.Add(TableName.MMOperationDetailPlanCapacityItemsTableName, new MMOperationDetailPlanCapacityItemsInfo());
            ModuleObjects.Add("MMJobTicketItemEmployees", new MMJobTicketItemEmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            JobTicketItem.InitBOSList(this, "MMJobTickets", "MMJobTicketItems", BOSList<MMJobTicketItemsInfo>.cstRelationForeign);
            JobTicketItem.ItemTableForeignKey = "FK_MMJobTicketID";

            OperationDetailPlanCapacityItemsList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.MMOperationDetailPlanCapacityItemsTableName,
                                                    BOSList<MMOperationDetailPlanCapacityItemsInfo>.cstRelationNone);


            OperationDetailPlanItemChildsList.InitBOSList(
                                            this,
                                            null,
                                            TableName.MMOperationDetailPlanItemChildsTableName,
                                            BOSList<MMOperationDetailPlanItemChildsInfo>.cstRelationNone);
            JobTicketItemEmployeeList.InitBOSList(this, "MMJobTicketItems", "MMJobTicketItemEmployees", BOSList<MMJobTicketItemEmployeesInfo>.cstRelationForeign);
            JobTicketItemEmployeeList.ItemTableForeignKey = "FK_MMJobTicketItemID";
        }

        public override void InitGridControlInBOSList()
        {
            JobTicketItem.InitBOSListGridControl();
            DetailPlanList.InitBOSListGridControl();
            OperationDetailPlanCapacityItemsList.InitBOSListGridControl("fld_dgcMMOperationDetailPlanCapacityItems");
            OperationDetailPlanItemChildsList.InitBOSListGridControl("fld_dgcMMOperationDetailPlanItemChildsGridControl");
            JobTicketItemEmployeeList.InitBOSListGridControl("fld_dgcMMJobTicketItemEmployeesGridControl");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMJobTicketsInfo objJobTicketsInfo = (MMJobTicketsInfo)MainObject;
            objJobTicketsInfo.MMJobTicketDate = DateTime.Now;
            objJobTicketsInfo.MMJobTicketFromDate = DateTime.Now;
            objJobTicketsInfo.MMJobTicketToDate = DateTime.Now;
            objJobTicketsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objJobTicketsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objJobTicketsInfo.MMJobTicketStatus = Status.New.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                JobTicketItem.SetDefaultListAndRefreshGridControl();
                DetailPlanList.SetDefaultListAndRefreshGridControl();
                OperationDetailPlanCapacityItemsList.SetDefaultListAndRefreshGridControl();
                OperationDetailPlanItemChildsList.SetDefaultListAndRefreshGridControl();
                JobTicketItemEmployeeList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override Entities

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMJobTicketItemsController controller = new MMJobTicketItemsController();
            MMJobTicketItemEmployeesController jtiEcontroller = new MMJobTicketItemEmployeesController();

            DataSet ds = controller.InvalidateJobTicketItemByParent(iObjectID);
            JobTicketItem.Invalidate(ds);

            ds = jtiEcontroller.InvalidateEmployeeByJobTicket(iObjectID);
            JobTicketItemEmployeeList.Invalidate(ds);

        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            List<MMJobTicketItemsInfo> deleteItem = new List<MMJobTicketItemsInfo>();
            if (JobTicketItem.BackupList != null && JobTicketItem.BackupList.Count > 0)
            {
                List<MMJobTicketItemsInfo> checkList = JobTicketItem.Where(x => x.MMJobTicketItemID > 0).ToList();
                foreach (MMJobTicketItemsInfo item in JobTicketItem.BackupList.Where(x => x.MMJobTicketItemID > 0))
                {
                    int count = 0;
                    if (checkList != null)
                        count = checkList.Where(x => x.MMJobTicketItemID == item.MMJobTicketItemID).ToList().Count();
                    if (count == 0)
                        deleteItem.Add(item);
                }
            }
            MMJobTicketsInfo objJobTicketsInfo = (MMJobTicketsInfo)MainObject;

            SaveItemWithDataTableType.SaveItemWithoutDelete<MMJobTicketItemsInfo>(JobTicketItem, "MMJobTicketItemID", "MMJobTicketItems", objJobTicketsInfo.MMJobTicketID, BOSApp.CurrentUsersInfo.ADUserName);
            if (deleteItem != null && deleteItem.Count > 0)
                SaveItemWithDataTableType.DeleteItem<MMJobTicketItemsInfo>(deleteItem, "MMJobTicketItems", BOSApp.CurrentUsersInfo.ADUserName);

            List<MMJobTicketItemEmployeesInfo> deleteemployee = new List<MMJobTicketItemEmployeesInfo>();
            if (JobTicketItemEmployeeList.BackupList != null && JobTicketItemEmployeeList.BackupList.Count > 0)
            {
                List<MMJobTicketItemEmployeesInfo> checkList = JobTicketItemEmployeeList.Where(x => x.MMJobTicketItemEmployeeID > 0).ToList();
                foreach (MMJobTicketItemEmployeesInfo item in JobTicketItemEmployeeList.BackupList.Where(x => x.MMJobTicketItemEmployeeID > 0))
                {
                    int count = 0;
                    if (checkList != null)
                        count = checkList.Where(x => x.MMJobTicketItemEmployeeID == item.MMJobTicketItemEmployeeID).ToList().Count();
                    if (count == 0)
                        deleteemployee.Add(item);
                }
            }

            // only save -> use delete from parent
            if (JobTicketItemEmployeeList != null && JobTicketItemEmployeeList.Count > 0)
                SaveItemWithDataTableType.SaveItemWithoutDelete<MMJobTicketItemEmployeesInfo>(JobTicketItemEmployeeList, "MMJobTicketItemEmployeeID", "MMJobTicketItemEmployees", objJobTicketsInfo.MMJobTicketID, BOSApp.CurrentUsersInfo.ADUserName);
            if (deleteemployee != null && deleteemployee.Count > 0)
                SaveItemWithDataTableType.DeleteItem<MMJobTicketItemEmployeesInfo>(deleteemployee, "MMJobTicketItemEmployees", BOSApp.CurrentUsersInfo.ADUserName);
        }

        #endregion Override Entities

    }
}
