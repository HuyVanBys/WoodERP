using BOSCommon;
using BOSCommon.Constants;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.SaleWork
{
    public class SaleWorkEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties

        public BOSList<PMSaleWorkItemsInfo> SaleWorkItemsList { get; set; }
        #endregion

        #region Constructor
        public SaleWorkEntities()
            : base()
        {
            SaleWorkItemsList = new BOSList<PMSaleWorkItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new PMSaleWorksInfo();
            SearchObject = new PMSaleWorksInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.PMSaleWorkItemsTableName, new PMSaleWorkItemsInfo());
            ModuleObjects.Add(TableName.PMTasksTableName, new PMTasksInfo());
        }

        public override void InitModuleObjectList()
        {
            SaleWorkItemsList.InitBOSList(this,
                                     TableName.PMSaleWorkTableName,
                                     TableName.PMSaleWorkItemsTableName,
                                     BOSList<PMSaleWorkItemsInfo>.cstRelationForeign);
            SaleWorkItemsList.ItemTableForeignKey = "FK_PMSaleWorkID";
        }

        public override void InitGridControlInBOSList()
        {
            SaleWorkItemsList.InitBOSListGridControl(SaleWorkModule.PMSaleWorksItemsGridControl);
        }

        public override void SetDefaultModuleObjectsList()
        {
            SaleWorkItemsList.SetDefaultListAndRefreshGridControl();
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            PMSaleWorksInfo mainObject = (PMSaleWorksInfo)MainObject;
            mainObject.PMSaleWorkDate = BOSApp.GetCurrentServerDate();
            mainObject.PMSaleWorkBeginDate = BOSApp.GetCurrentServerDate();
            mainObject.PMSaleWorkEndDate = BOSApp.GetCurrentServerDate();
            mainObject.PMSaleWorkStatus = SaleWorkStatus.New.ToString();
        }

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {
            PMSaleWorksInfo mainObject = (PMSaleWorksInfo)MainObject;
            SaleWorkItemsList.Invalidate(iObjectID);
            PMTasksController objTasksController = new PMTasksController();
            ACObjectsController objObjectsController = new ACObjectsController();
            List<PMTasksInfo> taskList = objTasksController.GetTasksByObjectIDAndType(mainObject.PMSaleWorkID, ObjectType.Sale.ToString());
            if (taskList == null)
                return;

            SaleWorkItemsList.ForEach(o =>
            {
                if (o.TasksList == null)
                {
                    o.TasksList = new BOSList<PMTasksInfo>();
                    o.TasksList.InitBOSList(this,
                        TableName.PMSaleWorkItemsTableName,
                        TableName.PMTasksTableName,
                        BOSList<PMTasksInfo>.cstRelationNone);
                }
                if (o.FK_ACObjectID > 0)
                {
                    o.ACObjectAccessKey = o.FK_ACObjectID + ";" + o.PMObjectType;
                    o.ACObjectName = objObjectsController.GetObjectByIDAndType(o.FK_ACObjectID, o.PMObjectType).ACObjectName;
                }
                o.TasksList.Invalidate(taskList.Where(s => s.FK_Object01ID == o.PMSaleWorkItemID).ToList());
            });
        }

        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            PMSaleWorksInfo objSaleWorksInfo = (PMSaleWorksInfo)MainObject;
            SaleWorkItemsList.SaveItemObjects();
            SaleWorkItemsList.ForEach(o =>
            {
                if (o.TasksList != null)
                {
                    o.TasksList.All(s =>
                    {
                        s.FK_ObjectID = objSaleWorksInfo.PMSaleWorkID;
                        s.FK_Object01ID = o.PMSaleWorkItemID;
                        return true;
                    });
                    o.TasksList.SaveItemObjects();

                    o.TasksList.All(s =>
                    {
                        if (s.TaskAssignsList == null)
                        {
                            s.TaskAssignsList = new BOSList<PMTaskAssignsInfo>(TableName.PMTaskAssignsTableName);
                        }

                        PMTaskAssignsInfo objTaskAssignsInfo = new PMTaskAssignsInfo
                        {
                            FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                            FK_PMTaskID = s.PMTaskID,
                            FK_ICMeasureUnitID = s.FK_ICMeasureUnitID,
                            FK_HRDepartmentID = s.FK_HRDepartmentID,
                            FK_HRDepartmentRoomID = s.FK_HRDepartmentRoomID,
                            FK_HREmployeeID = s.FK_HREmployeeID,
                            PMTaskAssignStatus = s.PMTaskStatus,
                        };
                        s.TaskAssignsList.Add(objTaskAssignsInfo);
                        s.TaskAssignsList.SaveItemObjects();
                        return true;
                    });
                }
            });
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            switch (strTableName)
            {
                case TableName.PMSaleWorkItemsTableName:
                    PMTasksController objTasksController = new PMTasksController();
                    List<PMTasksInfo> deleteTasks = objTasksController.GetTasksByObject01IDAndObject01Type(iObjectID, ObjectType01.WorkSale.ToString());
                    deleteTasks.ForEach(o => objTasksController.DeleteObject(o.PMTaskID));
                    break;
            }
        }
        #endregion
    }
}