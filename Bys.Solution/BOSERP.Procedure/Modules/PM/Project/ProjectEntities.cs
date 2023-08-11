using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BOSERP.Modules.Project
{
    public class ProjectEntities : BaseTransactionEntities
    {
        #region Public Properties

        public BOSList<PMProjectContactsInfo> ProjectContactsList { get; set; }

        public BOSTreeList ProjectNormList { get; set; }

        public List<PMProjectNormItemsInfo> ProjectNormItemsByProject { get; set; }

        public List<PMTasksInfo> TaskByProject { get; set; }

        public List<PMProjectNormsInfo> ProjectNormByProject { get; set; }

        public BOSList<PMProjectLocationsInfo> ProjectLocations { get; set; }

        public BOSList<PMProjectTemplateRelationshipsInfo> ProjectTemplateRelationships { get; set; }

        public BOSList<ARSaleOrdersInfo> SaleOrdersList { get; set; }

        public BOSList<PMProjectNormHistorysInfo> ProjectNormHistorysList { get; set; }

        #endregion

        #region Constructor
        public ProjectEntities()
            : base()
        {
            ProjectContactsList = new BOSList<PMProjectContactsInfo>();
            ProjectNormList = new BOSTreeList();
            ProjectLocations = new BOSList<PMProjectLocationsInfo>();
            ProjectTemplateRelationships = new BOSList<PMProjectTemplateRelationshipsInfo>();
            SaleOrdersList = new BOSList<ARSaleOrdersInfo>();
            ProjectNormHistorysList = new BOSList<PMProjectNormHistorysInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new PMProjectsInfo();
            SearchObject = new PMProjectsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.PMProjectContactsTableName, new PMProjectContactsInfo());
            ModuleObjects.Add(TableName.PMProjectNormsTableName, new PMProjectNormsInfo());
            ModuleObjects.Add(TableName.PMProjectLocationsTableName, new PMProjectLocationsInfo());
            ModuleObjects.Add(TableName.PMProjectTemplateRelationshipsTableName, new PMProjectTemplateRelationshipsInfo());
            ModuleObjects.Add(TableName.ARSaleOrdersTableName, new ARSaleOrdersInfo());
        }

        public override void InitModuleObjectList()
        {
            ProjectContactsList.InitBOSList(this,
                                               TableName.PMProjectsTableName,
                                               TableName.PMProjectContactsTableName,
                                               BOSList<PMProjectContactsInfo>.cstRelationForeign);
            ProjectContactsList.ItemTableForeignKey = "FK_PMProjectID";

            ProjectNormList.InitBOSList(this,
                                               TableName.PMProjectsTableName,
                                               TableName.PMProjectNormsTableName,
                                               BOSList<PMProjectNormsInfo>.cstRelationForeign);
            ProjectNormList.ItemTableForeignKey = "FK_PMProjectID";

            ProjectLocations.InitBOSList(this,
                                               TableName.PMProjectsTableName,
                                               TableName.PMProjectLocationsTableName,
                                               BOSList<PMProjectLocationsInfo>.cstRelationForeign);
            ProjectLocations.ItemTableForeignKey = "FK_PMProjectID";

            ProjectTemplateRelationships.InitBOSList(this,
                                               TableName.PMProjectsTableName,
                                               TableName.PMProjectTemplateRelationshipsTableName,
                                               BOSList<PMProjectTemplateRelationshipsInfo>.cstRelationForeign);
            ProjectTemplateRelationships.ItemTableForeignKey = "FK_PMProjectID";

            SaleOrdersList.InitBOSList(this,
                                               TableName.PMProjectsTableName,
                                               TableName.ARSaleOrdersTableName,
                                               BOSList<ARSaleOrdersInfo>.cstRelationForeign);
            SaleOrdersList.ItemTableForeignKey = "FK_PMProjectID";

            ProjectNormHistorysList.InitBOSList(this,
                                               string.Empty,
                                               TableName.PMProjectNormHistoryDetailsTableName,
                                               BOSList<PMProjectNormHistorysInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ProjectContactsList.InitBOSListGridControl(ProjectModule.ProjectContactsGridControlName);
            ProjectNormList.InitBOSTreeListControl(ProjectModule.ProjectNormsTreeListControlName);
            ProjectLocations.InitBOSListGridControl(ProjectModule.ProjectLocationsGridControlName);
            ProjectTemplateRelationships.InitBOSListGridControl(ProjectModule.ProjectTemplateRelationshipsGridControlName);
            SaleOrdersList.InitBOSListGridControl(ProjectModule.ARSaleOrdersGridControlName);
            ProjectNormHistorysList.InitBOSListGridControl(ProjectModule.PMProjectNormHistorysGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            ProjectContactsList.SetDefaultListAndRefreshGridControl();
            ProjectNormList.SetDefaultListAndRefreshTreeListControl();
            ProjectLocations.SetDefaultListAndRefreshGridControl();
            ProjectTemplateRelationships.SetDefaultListAndRefreshGridControl();
            SaleOrdersList.SetDefaultListAndRefreshGridControl();
            ProjectNormHistorysList.SetDefaultListAndRefreshGridControl();
        }
        #endregion

        #region Invalidate Module Objects functions

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            if (mainObject.FK_ACObjectID > 0)
            {
                SetPropertyChangeEventLock(false);

                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.PMObjectType);
                if (objObjectsInfo == null)
                    return;
                mainObject.ARCustomerContactAddressLine1 = objObjectsInfo.ACObjectDeliveryAddressLine1;
                mainObject.ARCustomerContactEmail1 = objObjectsInfo.ACObjectContactEmail;
                mainObject.ARCustomerContactPhone = objObjectsInfo.ACObjectContactPhone;

                GELocationsController objLocationsController = new GELocationsController();
                mainObject.ARCustomerContactLocationName = objLocationsController.GetFullLocationNameByID(objObjectsInfo.GELocationID);

                SetPropertyChangeEventLock(true);
            }
            ARProspectCustomersController objProspectCustomersController = new ARProspectCustomersController();
            ARProspectCustomersInfo objProspectCustomersInfo = (ARProspectCustomersInfo)objProspectCustomersController.GetObjectByID(mainObject.FK_ARProspectCustomerID);
            if (objProspectCustomersInfo != null)
            {
                if (string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerName))
                {
                    mainObject.ARProspectCustomerName = string.Format(string.Empty, objProspectCustomersInfo.ARProspectCustomerLastName + " " + objProspectCustomersInfo.ARProspectCustomerFirstName);
                }
                else
                    mainObject.ARProspectCustomerName = objProspectCustomersInfo.ARProspectCustomerName;
                string[] contactAddress = new string[]
                    {
                        objProspectCustomersInfo.ARProspectCustomerAddress,
                        objProspectCustomersInfo.ARProspectCustomerAddressDistrict,
                        objProspectCustomersInfo.ARProspectCustomerAddressCity,
                        objProspectCustomersInfo.ARProspectCustomerAddressCountry,
                    };
                mainObject.ARProspectCustomerContactAddress = string.Join(", ", contactAddress);
                mainObject.ARProspectCustomerCompany = objProspectCustomersInfo.ARProspectCustomerCompany;
                mainObject.ARProspectCustomerTel = objProspectCustomersInfo.ARProspectCustomerTel;
                mainObject.ARProspectCustomerEmail = objProspectCustomersInfo.ARProspectCustomerEmail;
                mainObject.ARProspectCustomerBusiness = objProspectCustomersInfo.ARProspectCustomerBusiness;
            }
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ProjectContactsList.Invalidate(iObjectID);

            ProjectLocations.Invalidate(iObjectID);

            SaleOrdersList.Invalidate(iObjectID);
            List<ARSaleOrdersInfo> saleOrders = new List<ARSaleOrdersInfo>();
            SaleOrdersList.ForEach(o =>
                {
                    o.ACObjectAccessKey = o.FK_ACObjectID + ";" + o.ARObjectType;
                    saleOrders.Add(o);
                });
            SaleOrdersList.Invalidate(saleOrders);

            PMProjectNormItemsController objProjectNormItemsController = new PMProjectNormItemsController();
            ProjectNormItemsByProject = new List<PMProjectNormItemsInfo>();
            ProjectNormItemsByProject = objProjectNormItemsController.GetProjectNormItemsByProjectID(iObjectID);

            PMTasksController objTasksController = new PMTasksController();
            TaskByProject = new List<PMTasksInfo>();
            TaskByProject = objTasksController.GetTasksByObjectIDAndType(iObjectID, ObjectType.Project.ToString());
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ProjectContactsList.SaveItemObjects();
            ProjectLocations.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            mainObject.PMProjectDate = BOSApp.GetCurrentServerDate();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        #endregion

        public void GenerateProjectEntities(ARProspectCustomersInfo objProspectCustomersInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            mainObject.FK_ARProspectCustomerID = objProspectCustomersInfo.ARProspectCustomerID;
            if (string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerName))
            {
                mainObject.ARProspectCustomerName = string.Format("{0} {1}", objProspectCustomersInfo.ARProspectCustomerLastName, objProspectCustomersInfo.ARProspectCustomerFirstName);
            }
            else
                mainObject.ARProspectCustomerName = objProspectCustomersInfo.ARProspectCustomerName;
            string[] contactAddress = new string[]
            {
                objProspectCustomersInfo.ARProspectCustomerAddress,
                String.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerAddressDistrict) ? String.Empty : "," + objProspectCustomersInfo.ARProspectCustomerAddressDistrict,
                String.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerAddressCity) ? String.Empty : "," + objProspectCustomersInfo.ARProspectCustomerAddressCity,
                String.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerAddressCountry) ? String.Empty : "," + objProspectCustomersInfo.ARProspectCustomerAddressCountry
            };
            mainObject.ARProspectCustomerContactAddress = string.Join(" ", contactAddress);
            mainObject.ARProspectCustomerCompany = objProspectCustomersInfo.ARProspectCustomerCompany;
            mainObject.ARProspectCustomerTel = objProspectCustomersInfo.ARProspectCustomerTel;
            mainObject.ARProspectCustomerEmail = objProspectCustomersInfo.ARProspectCustomerEmail;
            mainObject.ARProspectCustomerBusiness = objProspectCustomersInfo.ARProspectCustomerBusiness;

            UpdateMainObjectBindingSource();
        }

        public bool GenarateProjectNormFromTemplate(PMTemplatesInfo objTemplatesInfo)
        {
            PMTemplateItemsController objPMTemplateItemsController = new PMTemplateItemsController();
            List<PMTemplateItemsInfo> templateItems = objPMTemplateItemsController.GetTemplateItemsByTemplateID(objTemplatesInfo.PMTemplateID);
            if (templateItems.Count <= 0)
                return false;

            PMTemplateItemComponentsController objTemplateItemComponentsController = new PMTemplateItemComponentsController();
            List<PMTemplateItemComponentsInfo> templateItemComponents = objTemplateItemComponentsController.GetTemplateItemComponentsByTemplateID(objTemplatesInfo.PMTemplateID);

            PMTemplateItemTasksController objTemplateItemTasksController = new PMTemplateItemTasksController();
            List<PMTemplateItemTasksInfo> templateItemTasks = objTemplateItemTasksController.GetTemplateItemTasksByTemplateID(objTemplatesInfo.PMTemplateID);

            AddTemplateItemToProjectNormList(ProjectNormList, objTemplatesInfo, templateItems, 0);

            List<PMProjectNormsInfo> projectNormList = new List<PMProjectNormsInfo>();
            ProjectNormList.ConvertToList(projectNormList);
            foreach (PMProjectNormsInfo item in projectNormList)
            {
                if (item.PMProjectNormType == TemplateItemType.Work.ToString())
                {
                    List<PMProjectNormItemsInfo> projectNormItems = templateItemComponents
                                                                        .Where(o => o.FK_PMTemplateItemID == item.FK_PMTemplateItemID)
                                                                        .Select(s => ToPMProjectNormItemsInfo(s))
                                                                        .ToList();
                    if (projectNormItems.Count > 0)
                    {
                        item.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                        item.ProjectNormItemsList.InitBOSList(this,
                                                                 TableName.PMProjectNormsTableName,
                                                                 TableName.PMProjectNormItemsTableName,
                                                                 BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                        item.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                        projectNormItems = projectNormItems.Select(o => { o.FK_PMProjectNormID = item.PMProjectNormID; return o; }).ToList();
                        item.ProjectNormItemsList.Invalidate(projectNormItems);
                        item.ProjectNormItemsList.SaveItemObjects();

                        ProjectNormItemsByProject = ProjectNormItemsByProject.Union(item.ProjectNormItemsList.ToList()).ToList();
                    }

                    List<PMTasksInfo> tasks = templateItemTasks
                                                        .Where(o => o.FK_PMTemplateItemID == item.FK_PMTemplateItemID)
                                                        .Select(s => ToTasksInfo(s))
                                                        .ToList();
                    if (tasks.Count > 0)
                    {
                        item.TasksList = new BOSList<PMTasksInfo>();
                        item.TasksList.InitBOSList(this,
                                                    TableName.PMProjectNormsTableName,
                                                    TableName.PMTasksTableName,
                                                    BOSList<PMTasksInfo>.cstRelationForeign);
                        item.TasksList.ItemTableForeignKey = "FK_Object01ID";
                        tasks.ForEach(o =>
                        {
                            o.FK_Object01ID = item.PMProjectNormID;
                            o.ObjectType01 = ObjectType.ProjectNorm.ToString();
                        });
                        item.TasksList.Invalidate(tasks);
                        item.TasksList.SaveItemObjects();

                        TaskByProject = TaskByProject.Union(item.TasksList.ToList()).ToList();

                        item.PMProjectNormStartDate = item.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                        item.PMProjectNormEndDate = item.TasksList.Max(x => x.PMTaskEstimatedEndDate);

                        PMProjectNormsInfo objProjectNormsInfo = ProjectNormByProject.FirstOrDefault(o => o.PMProjectNormID == item.PMProjectNormID);

                        objProjectNormsInfo.PMProjectNormStartDate = item.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                        objProjectNormsInfo.PMProjectNormEndDate = item.TasksList.Max(x => x.PMTaskEstimatedEndDate);
                    }
                }
            }
            ProjectNormList.SaveItemObjects();
            return true;
        }

        private void AddTemplateItemToProjectNormList(IBOSTreeList treeList, PMTemplatesInfo objTemplatesInfo, List<PMTemplateItemsInfo> templateItems, int parentID)
        {
            if (treeList != null && templateItems != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (PMTemplateItemsInfo item in templateItems)
                {
                    if (item.PMTemplateItemParentID == parentID)
                    {
                        PMProjectNormsInfo objProjectNormsInfo = ToPMProjectNormsInfo(item, objTemplatesInfo);
                        treeList.Add(objProjectNormsInfo);
                        ProjectNormByProject.Add(objProjectNormsInfo);
                        if (item.NumberOfChild > 0)
                        {
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            objProjectNormsInfo.SubList = (BOSTreeList)objType;
                            objProjectNormsInfo.SubList.InitBOSList(this, TableName.PMProjectNormsTableName, TableName.PMProjectNormsTableName);
                            this.AddTemplateItemToProjectNormList(objProjectNormsInfo.SubList, objTemplatesInfo, templateItems, item.PMTemplateItemID);
                        }
                    }
                }
                treeList.SaveItemObjects();
            }
        }

        private PMProjectNormItemsInfo ToPMProjectNormItemsInfo(PMTemplateItemComponentsInfo templateItemComponentsInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            return new PMProjectNormItemsInfo
            {
                FK_PMProjectID = mainObject.PMProjectID,
                FK_PMTemplateItemComponentID = templateItemComponentsInfo.PMTemplateItemComponentID,
                FK_PMTemplateItemID = templateItemComponentsInfo.FK_PMTemplateItemID,
                FK_ICProductID = templateItemComponentsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = templateItemComponentsInfo.FK_ICMeasureUnitID,
                PMProjectNormItemProductNo = templateItemComponentsInfo.PMTemplateItemComponentProductNo,
                PMProjectNormItemProductName = templateItemComponentsInfo.PMTemplateItemComponentProductName,
                PMProjectNormItemProductDesc = templateItemComponentsInfo.PMTemplateItemComponentProductDesc,
                PMProjectNormItemType = templateItemComponentsInfo.PMTemplateItemComponentWorkType,
                PMProjectNormItemQty = templateItemComponentsInfo.PMTemplateItemComponentQty,
                PMProjectNormItemProductType = templateItemComponentsInfo.PMTemplateItemComponentType,
            };
        }

        private PMTasksInfo ToTasksInfo(PMTemplateItemTasksInfo templateItemTasksInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            PMTasksInfo objTasksInfo = new PMTasksInfo
            {
                FK_HRDepartmentRoomID = templateItemTasksInfo.FK_HRDepartmentRoomID,
                FK_HRDepartmentID = templateItemTasksInfo.FK_HRDepartmentID,
                FK_HREmployeeID = templateItemTasksInfo.FK_HREmployeeID,
                FK_ICMeasureUnitID = templateItemTasksInfo.FK_ICMeasureUnitID,
                FK_ICTaskID = templateItemTasksInfo.FK_ICTaskID,
                FK_Object02ID = mainObject.FK_PMProjectTypeID,
                ObjectType02 = ObjectType.ProjectType.ToString(),
                FK_ObjectID = mainObject.PMProjectID,
                ObjectType = ObjectType.Project.ToString(),
                PMTaskNo = templateItemTasksInfo.PMTemplateItemTaskNo,
                PMTaskName = templateItemTasksInfo.PMTemplateItemTaskName,
                PMTaskInfo = templateItemTasksInfo.PMTemplateItemTaskInfo,
                PMTaskQty = templateItemTasksInfo.PMTemplateItemTaskQty,
                PMTaskTotalEstimatedDays = templateItemTasksInfo.PMTemplateItemTaskTotalEstimatedDays,
                PMTaskTotalEstimatedHours = templateItemTasksInfo.PMTemplateItemTaskTotalEstimatedHours,
                PMTaskTotalActualDays = templateItemTasksInfo.PMTemplateItemTaskTotalActualDays,
                PMTaskTotalActualHours = templateItemTasksInfo.PMTemplateItemTaskTotalActualHours,
                PMTaskActualTotalCost = templateItemTasksInfo.PMTemplateItemTaskEstimatedTotalCost,
                PMTaskEstimatedExtendDays = templateItemTasksInfo.PMTemplateItemTaskEstimatedExtendDays,
                PMTaskEstimatedExtendHours = templateItemTasksInfo.PMTemplateItemTaskEstimatedExtendHours,
                PMTaskActualExtendDays = templateItemTasksInfo.PMTemplateItemTaskActualExtendDays,
                PMTaskActualExtendHours = templateItemTasksInfo.PMTemplateItemTaskActualExtendHours,
                PMTaskEstimatedStartDate = BOSApp.GetCurrentServerDate(),
                PMTaskActualStartDate = BOSApp.GetCurrentServerDate(),
            };
            objTasksInfo.PMTaskEstimatedEndDate = objTasksInfo.PMTaskEstimatedStartDate
                                                                        .AddDays(Convert.ToDouble(objTasksInfo.PMTaskTotalEstimatedDays))
                                                                        .AddHours(Convert.ToDouble(objTasksInfo.PMTaskTotalEstimatedHours));
            objTasksInfo.PMTaskActualEndDate = objTasksInfo.PMTaskEstimatedEndDate;
            return objTasksInfo;
        }

        private PMProjectNormsInfo ToPMProjectNormsInfo(PMTemplateItemsInfo templateItemsInfo, PMTemplatesInfo templatesInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            return new PMProjectNormsInfo
            {
                FK_PMTemplateItemID = templateItemsInfo.PMTemplateItemID,
                FK_ICProductID = templateItemsInfo.FK_ICProductID,
                FK_PMPhaseTypeID = templatesInfo.FK_PMPhaseTypeID,
                FK_PMProjectID = mainObject.PMProjectID,
                PMProjectNormProductType = templateItemsInfo.PMTemplateItemType,
                PMProjectNormProductDesc = templateItemsInfo.PMTemplateItemProductDesc,
                PMProjectNormProductQty = templateItemsInfo.PMTemplateItemProductQty,
                PMProjectNormProductNetWeight = templateItemsInfo.PMTemplateItemProductQty,
                FK_PMTemplateID = templateItemsInfo.FK_PMTemplateID,
                FK_ICProductGroupID = templateItemsInfo.FK_ICProductGroupID,
                FK_ICDepartmentID = templateItemsInfo.FK_ICDepartmentID,
                FK_ICProductWorkGroupID = templateItemsInfo.FK_ICProductWorkGroupID,
                FK_ICProductWorkGroupParentID = templateItemsInfo.FK_ICProductWorkGroupParentID,
                FK_ICMeasureUnitID = templateItemsInfo.FK_ICMeasureUnitID,
                PMProjectNormProductNo = templateItemsInfo.PMTemplateItemProductNo,
                PMProjectNormProductName = templateItemsInfo.PMTemplateItemProductName,
                PMProjectNormType = templateItemsInfo.PMTemplateItemType,
                PMProjectNormItem = templateItemsInfo.PMTemplateItemType == TemplateItemType.Work.ToString() ? ProjectLocalizedResources.PMProjectNormItemCaption : string.Empty,
                SubList = new BOSTreeList(),
            };
        }

        public void AddProjectNormToProjectNormList(IBOSTreeList treeList, List<PMProjectNormsInfo> projectNorm, int parentID)
        {
            if (treeList != null && projectNorm != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (PMProjectNormsInfo item in projectNorm)
                {
                    if (item.PMProjectNormParentID == parentID)
                    {
                        PMProjectNormsInfo objProjectNormsInfo = ToPMProjectNormsInfo(item);
                        treeList.Add(objProjectNormsInfo);
                        ProjectNormByProject.Add(objProjectNormsInfo);
                        if (item.NumberOfChild > 0)
                        {
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            objProjectNormsInfo.SubList = (BOSTreeList)objType;
                            objProjectNormsInfo.SubList.InitBOSList(this, TableName.PMProjectNormsTableName, TableName.PMProjectNormsTableName);
                            this.AddProjectNormToProjectNormList(objProjectNormsInfo.SubList, projectNorm, item.PMProjectNormID);
                        }
                    }
                }
                treeList.SaveItemObjects();
            }
        }

        private PMProjectNormsInfo ToPMProjectNormsInfo(PMProjectNormsInfo objProjectNormsInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            return new PMProjectNormsInfo
            {
                FK_PMTemplateItemID = 0,
                FK_ICProductID = objProjectNormsInfo.FK_ICProductID,
                FK_PMPhaseTypeID = objProjectNormsInfo.FK_PMPhaseTypeID,
                FK_PMProjectID = mainObject.PMProjectID,
                PMProjectNormProductType = objProjectNormsInfo.PMProjectNormProductType,
                PMProjectNormProductDesc = objProjectNormsInfo.PMProjectNormProductDesc,
                PMProjectNormProductQty = objProjectNormsInfo.PMProjectNormProductQty,
                PMProjectNormProductNetWeight = objProjectNormsInfo.PMProjectNormProductQty,
                FK_PMTemplateID = 0,
                FK_ICProductGroupID = objProjectNormsInfo.FK_ICProductGroupID,
                FK_ICDepartmentID = objProjectNormsInfo.FK_ICDepartmentID,
                FK_ICProductWorkGroupID = objProjectNormsInfo.FK_ICProductWorkGroupID,
                FK_ICProductWorkGroupParentID = objProjectNormsInfo.FK_ICProductWorkGroupParentID,
                FK_ICMeasureUnitID = objProjectNormsInfo.FK_ICMeasureUnitID,
                PMProjectNormProductNo = objProjectNormsInfo.PMProjectNormProductNo,
                PMProjectNormProductName = objProjectNormsInfo.PMProjectNormProductName,
                PMProjectNormType = objProjectNormsInfo.PMProjectNormType,
                PMProjectNormStartDate = objProjectNormsInfo.PMProjectNormStartDate,
                PMProjectNormEndDate = objProjectNormsInfo.PMProjectNormEndDate,
                PMProjectNormReferenceID = objProjectNormsInfo.PMProjectNormID,
                PMProjectNormItem = objProjectNormsInfo.PMProjectNormType == TemplateItemType.Work.ToString() ? ProjectLocalizedResources.PMProjectNormItemCaption : string.Empty,
                SubList = new BOSTreeList(),
            };
        }

        public void GenarateProjectNormFromProjectOld(PMProjectsInfo objProjectsInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            List<PMProjectNormsInfo> projectNorms = objProjectNormsController.GetProjectNormsByProjectID(objProjectsInfo.PMProjectID);
            if (projectNorms.Count <= 0)
                return;

            PMProjectNormItemsController objProjectNormItemsController = new PMProjectNormItemsController();
            List<PMProjectNormItemsInfo> projectNormItemList = objProjectNormItemsController.GetProjectNormItemsByProjectID(objProjectsInfo.PMProjectID);

            PMTasksController objTasksController = new PMTasksController();
            List<PMTasksInfo> taskList = objTasksController.GetTasksByObjectIDAndType(objProjectsInfo.PMProjectID, ObjectType.Project.ToString());

            AddProjectNormToProjectNormList(ProjectNormList, projectNorms, 0);

            List<PMProjectNormsInfo> projectNormList = new List<PMProjectNormsInfo>();
            ProjectNormList.ConvertToList(projectNormList);
            foreach (PMProjectNormsInfo item in projectNormList)
            {
                if (item.PMProjectNormType == TemplateItemType.Work.ToString())
                {
                    List<PMProjectNormItemsInfo> projectNormItems = projectNormItemList
                                                                        .Where(o => o.FK_PMProjectNormID == item.PMProjectNormReferenceID)
                                                                        .Select(s => ToPMProjectNormItemsInfo(s))
                                                                        .ToList();
                    if (projectNormItems.Count > 0)
                    {
                        item.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                        item.ProjectNormItemsList.InitBOSList(this,
                                                                 TableName.PMProjectNormsTableName,
                                                                 TableName.PMProjectNormItemsTableName,
                                                                 BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                        item.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                        projectNormItems = projectNormItems.Select(o => { o.FK_PMProjectNormID = item.PMProjectNormID; return o; }).ToList();
                        item.ProjectNormItemsList.Invalidate(projectNormItems);
                        item.ProjectNormItemsList.SaveItemObjects();

                        ProjectNormItemsByProject = ProjectNormItemsByProject.Union(item.ProjectNormItemsList.ToList()).ToList();
                    }

                    List<PMTasksInfo> tasks = taskList
                                                    .Where(o => o.FK_Object01ID == item.PMProjectNormReferenceID)
                                                    .Select(s => ToTasksInfo(s))
                                                    .ToList();
                    if (tasks.Count > 0)
                    {
                        item.TasksList = new BOSList<PMTasksInfo>();
                        item.TasksList.InitBOSList(this,
                                                    TableName.PMProjectNormsTableName,
                                                    TableName.PMTasksTableName,
                                                    BOSList<PMTasksInfo>.cstRelationForeign);
                        item.TasksList.ItemTableForeignKey = "FK_Object01ID";
                        tasks.ForEach(o =>
                        {
                            o.FK_Object01ID = item.PMProjectNormID;
                            o.ObjectType01 = ObjectType.ProjectNorm.ToString();
                        });
                        item.TasksList.Invalidate(tasks);
                        item.TasksList.SaveItemObjects();

                        TaskByProject = TaskByProject.Union(item.TasksList.ToList()).ToList();

                        item.PMProjectNormStartDate = item.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                        item.PMProjectNormEndDate = item.TasksList.Max(x => x.PMTaskEstimatedEndDate);

                        PMProjectNormsInfo objProjectNormsInfo = ProjectNormByProject.FirstOrDefault(o => o.PMProjectNormID == item.PMProjectNormID);

                        objProjectNormsInfo.PMProjectNormStartDate = item.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                        objProjectNormsInfo.PMProjectNormEndDate = item.TasksList.Max(x => x.PMTaskEstimatedEndDate);
                    }
                }
            }
            PMProjectTemplateRelationshipsController objPTRelationshipsController = new PMProjectTemplateRelationshipsController();
            List<PMProjectTemplateRelationshipsInfo> relationships = objPTRelationshipsController.GetProjectTemplateRelationshipsByProjectID(objProjectsInfo.PMProjectID);
            foreach (PMProjectTemplateRelationshipsInfo item in relationships)
            {
                PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = new PMProjectTemplateRelationshipsInfo
                {
                    FK_PMProjectID = mainObject.PMProjectID,
                    FK_PMTemplateID = item.FK_PMTemplateID,
                    FK_PMPhaseTypeID = item.FK_PMPhaseTypeID,
                    PMPhaseTypeName = item.PMPhaseTypeName,
                };
                objPTRelationshipsController.CreateObject(objPTRelationshipsInfo);
                ProjectTemplateRelationships.Add(objPTRelationshipsInfo);
            }
        }

        private PMTasksInfo ToTasksInfo(PMTasksInfo objTasksInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            return new PMTasksInfo
            {
                FK_HRDepartmentRoomID = objTasksInfo.FK_HRDepartmentRoomID,
                FK_HRDepartmentID = objTasksInfo.FK_HRDepartmentID,
                FK_HREmployeeID = objTasksInfo.FK_HREmployeeID,
                FK_ICMeasureUnitID = objTasksInfo.FK_ICMeasureUnitID,
                FK_ICTaskID = objTasksInfo.FK_ICTaskID,
                FK_Object02ID = mainObject.FK_PMProjectTypeID,
                ObjectType02 = ObjectType.ProjectType.ToString(),
                FK_ObjectID = mainObject.PMProjectID,
                ObjectType = ObjectType.Project.ToString(),
                PMTaskNo = objTasksInfo.PMTaskNo,
                PMTaskName = objTasksInfo.PMTaskName,
                PMTaskInfo = objTasksInfo.PMTaskInfo,
                PMTaskQty = objTasksInfo.PMTaskQty,
                PMTaskTotalEstimatedDays = objTasksInfo.PMTaskTotalEstimatedDays,
                PMTaskTotalEstimatedHours = objTasksInfo.PMTaskTotalEstimatedHours,
                PMTaskTotalActualDays = objTasksInfo.PMTaskTotalActualDays,
                PMTaskTotalActualHours = objTasksInfo.PMTaskTotalActualHours,
                PMTaskActualTotalCost = objTasksInfo.PMTaskEstimatedTotalCost,
                PMTaskEstimatedExtendDays = objTasksInfo.PMTaskEstimatedExtendDays,
                PMTaskEstimatedExtendHours = objTasksInfo.PMTaskEstimatedExtendHours,
                PMTaskActualExtendDays = objTasksInfo.PMTaskActualExtendDays,
                PMTaskActualExtendHours = objTasksInfo.PMTaskActualExtendHours,
                PMTaskEstimatedStartDate = objTasksInfo.PMTaskEstimatedStartDate,
                PMTaskActualStartDate = objTasksInfo.PMTaskActualStartDate,
                PMTaskEstimatedEndDate = objTasksInfo.PMTaskEstimatedEndDate,
                PMTaskActualEndDate = objTasksInfo.PMTaskActualEndDate,
            };
        }

        private PMProjectNormItemsInfo ToPMProjectNormItemsInfo(PMProjectNormItemsInfo projectNormItemsInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            return new PMProjectNormItemsInfo
            {
                FK_PMProjectID = mainObject.PMProjectID,
                FK_PMTemplateItemComponentID = 0,
                FK_PMTemplateItemID = 0,
                FK_ICProductID = projectNormItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = projectNormItemsInfo.FK_ICMeasureUnitID,
                PMProjectNormItemProductNo = projectNormItemsInfo.PMProjectNormItemProductNo,
                PMProjectNormItemProductName = projectNormItemsInfo.PMProjectNormItemProductName,
                PMProjectNormItemProductDesc = projectNormItemsInfo.PMProjectNormItemProductDesc,
                PMProjectNormItemType = projectNormItemsInfo.PMProjectNormItemType,
                PMProjectNormItemQty = projectNormItemsInfo.PMProjectNormItemQty,
                PMProjectNormItemProductType = projectNormItemsInfo.PMProjectNormItemProductType,
            };
        }

        public void GenarateProjectNormFromWorks(List<ICProductsInfo> products, PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo, PMProjectNormsInfo objProjectNormsInfoCurrent)
        {

            products.ForEach(o =>
                {
                    PMProjectNormsInfo objProjectNormsInfo = ToPMProjectNormsInfoWork(o, objPTRelationshipsInfo, objProjectNormsInfoCurrent);
                    ProjectNormList.Add(objProjectNormsInfo);
                    ProjectNormByProject.Add(objProjectNormsInfo);

                    objProjectNormsInfo.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                    objProjectNormsInfo.ProjectNormItemsList.InitBOSList(this,
                                                             TableName.PMProjectNormsTableName,
                                                             TableName.PMProjectNormItemsTableName,
                                                             BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                    objProjectNormsInfo.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                    ICProductWorkItemsController objProductWorkItemsController = new ICProductWorkItemsController();
                    List<ICProductWorkItemsInfo> components = objProductWorkItemsController.GetProductWorkItemsByProductWorkItemParentID(objProjectNormsInfo.FK_ICProductID);
                    List<PMProjectNormItemsInfo> projectNormItems = components.Select(s => ToPMProjectNormItemsInfo(s)).ToList();
                    objProjectNormsInfo.ProjectNormItemsList.Invalidate(projectNormItems);

                    objProjectNormsInfo.TasksList = new BOSList<PMTasksInfo>();
                    objProjectNormsInfo.TasksList.InitBOSList(this,
                                                             TableName.PMProjectNormsTableName,
                                                             TableName.PMTasksTableName,
                                                             BOSList<PMTasksInfo>.cstRelationForeign);
                    objProjectNormsInfo.TasksList.ItemTableForeignKey = "FK_Object01ID";
                    ICProductTasksController objProductTasksController = new ICProductTasksController();
                    List<ICProductTasksInfo> productTasks = objProductTasksController.GetProductTasksByProductID(objProjectNormsInfo.FK_ICProductID);
                    List<PMTasksInfo> tasks = productTasks.Select(x => ToTasksInfo(x)).ToList();
                    objProjectNormsInfo.TasksList.Invalidate(tasks);
                    if (objProjectNormsInfo.TasksList.Count > 0)
                    {
                        objProjectNormsInfo.PMProjectNormStartDate = objProjectNormsInfo.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                        objProjectNormsInfo.PMProjectNormEndDate = objProjectNormsInfo.TasksList.Max(x => x.PMTaskEstimatedEndDate);
                    }
                });
            ProjectNormList.SaveItemObjects();
            foreach (PMProjectNormsInfo item in ProjectNormList)
            {
                if (item.ProjectNormItemsList != null && item.ProjectNormItemsList.Count > 0)
                {
                    foreach (PMProjectNormItemsInfo obj in item.ProjectNormItemsList)
                    {
                        obj.FK_PMProjectNormID = item.PMProjectNormID;
                    }
                    item.ProjectNormItemsList.SaveItemObjects();
                    ProjectNormItemsByProject = ProjectNormItemsByProject
                                                                .Union(item.ProjectNormItemsList.ToList())
                                                                .ToList();
                }

                if (item.TasksList != null && item.TasksList.Count > 0)
                {
                    foreach (PMTasksInfo obj in item.TasksList)
                    {
                        obj.FK_Object01ID = item.PMProjectNormID;
                        obj.ObjectType01 = ObjectType.ProjectNorm.ToString();

                    }
                    item.TasksList.SaveItemObjects();
                    TaskByProject = TaskByProject
                                            .Union(item.TasksList.ToList())
                                            .ToList();
                }
            }
        }

        public void GenarateProjectNormFromSections(List<ICProductsInfo> products, PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo, PMProjectNormsInfo objProjectNormsInfoCurrent)
        {
            products.ForEach(o =>
                {
                    PMProjectNormsInfo objProjectNormsInfo = ToPMProjectNormsInfoSection(o, objPTRelationshipsInfo, objProjectNormsInfoCurrent);
                    ProjectNormList.Add(objProjectNormsInfo);
                    ProjectNormByProject.Add(objProjectNormsInfo);
                });
            ProjectNormList.SaveItemObjects();
        }

        public PMTasksInfo ToTasksInfo(ICProductTasksInfo objProductTasksInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            PMTasksInfo objTasksInfo = new PMTasksInfo();
            objTasksInfo.FK_HRDepartmentRoomID = objProductTasksInfo.FK_HRDepartmentRoomID;
            objTasksInfo.FK_HRDepartmentID = objProductTasksInfo.FK_HRDepartmentID;
            objTasksInfo.FK_HREmployeeID = objProductTasksInfo.FK_HREmployeeID;
            objTasksInfo.FK_ICMeasureUnitID = objProductTasksInfo.FK_ICMeasureUnitID;
            objTasksInfo.FK_ICTaskID = objProductTasksInfo.FK_ICTaskID;
            objTasksInfo.FK_Object02ID = mainObject.FK_PMProjectTypeID;
            objTasksInfo.ObjectType02 = ObjectType.ProjectType.ToString();
            objTasksInfo.FK_ObjectID = mainObject.PMProjectID;
            objTasksInfo.ObjectType = ObjectType.Project.ToString();
            objTasksInfo.PMTaskNo = objProductTasksInfo.ICProductTaskNo;
            objTasksInfo.PMTaskName = objProductTasksInfo.ICProductTaskName;
            objTasksInfo.PMTaskInfo = objProductTasksInfo.ICProductTaskInfo;
            objTasksInfo.PMTaskQty = objProductTasksInfo.ICProductTaskQty;
            objTasksInfo.PMTaskTotalEstimatedDays = objProductTasksInfo.ICProductTaskTotalEstimatedDays;
            objTasksInfo.PMTaskTotalEstimatedHours = objProductTasksInfo.ICProductTaskTotalEstimatedHours;
            objTasksInfo.PMTaskTotalActualDays = objProductTasksInfo.ICProductTaskTotalActualDays;
            objTasksInfo.PMTaskTotalActualHours = objProductTasksInfo.ICProductTaskTotalActualHours;
            objTasksInfo.PMTaskActualTotalCost = objProductTasksInfo.ICProductTaskEstimatedTotalCost;
            objTasksInfo.PMTaskEstimatedExtendDays = objProductTasksInfo.ICProductTaskEstimatedExtendDays;
            objTasksInfo.PMTaskEstimatedExtendHours = objProductTasksInfo.ICProductTaskEstimatedExtendHours;
            objTasksInfo.PMTaskActualExtendDays = objProductTasksInfo.ICProductTaskActualExtendDays;
            objTasksInfo.PMTaskActualExtendHours = objProductTasksInfo.ICProductTaskActualExtendHours;
            objTasksInfo.PMTaskEstimatedStartDate = BOSApp.GetCurrentServerDate();
            objTasksInfo.PMTaskActualStartDate = BOSApp.GetCurrentServerDate();
            objTasksInfo.PMTaskEstimatedEndDate = objTasksInfo.PMTaskEstimatedStartDate
                                                                                .AddDays(Convert.ToDouble(objTasksInfo.PMTaskTotalEstimatedDays))
                                                                                .AddHours(Convert.ToDouble(objTasksInfo.PMTaskTotalEstimatedHours));
            objTasksInfo.PMTaskActualEndDate = objTasksInfo.PMTaskEstimatedEndDate;
            return objTasksInfo;
        }

        private PMProjectNormItemsInfo ToPMProjectNormItemsInfo(ICProductWorkItemsInfo objProductWorkItemsInfo)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            return new PMProjectNormItemsInfo
            {
                FK_PMProjectID = mainObject.PMProjectID,
                FK_PMTemplateItemComponentID = 0,
                FK_PMTemplateItemID = 0,
                FK_ICProductID = objProductWorkItemsInfo.FK_ICProductWorkItemChildID,
                FK_ICMeasureUnitID = 0,
                PMProjectNormItemProductNo = objProductWorkItemsInfo.ICProductWorkItemProductNo,
                PMProjectNormItemProductName = objProductWorkItemsInfo.ICProductWorkItemProductName,
                PMProjectNormItemProductDesc = objProductWorkItemsInfo.ICProductWorkItemProductDesc,
                PMProjectNormItemType = string.IsNullOrEmpty(objProductWorkItemsInfo.ICProductWorkType) ? TemplateItemWorkType.Purchase.ToString() : objProductWorkItemsInfo.ICProductWorkType,
                PMProjectNormItemQty = objProductWorkItemsInfo.ICProductWorkItemQty,
                PMProjectNormItemProductType = objProductWorkItemsInfo.ICProductWorkItemType,
            };
        }

        private PMProjectNormsInfo ToPMProjectNormsInfoWork(ICProductsInfo objProductsInfo, PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo, PMProjectNormsInfo objProjectNormsInfoCurrent)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            PMProjectNormsInfo objProjectNormsInfo = new PMProjectNormsInfo();
            objProjectNormsInfo.FK_PMTemplateItemID = 0;
            objProjectNormsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProjectNormsInfo.FK_PMPhaseTypeID = objPTRelationshipsInfo.FK_PMPhaseTypeID;
            objProjectNormsInfo.FK_PMProjectID = mainObject.PMProjectID;
            objProjectNormsInfo.PMProjectNormProductType = TemplateItemType.Work.ToString();
            objProjectNormsInfo.PMProjectNormProductDesc = objProductsInfo.ICProductDesc;
            objProjectNormsInfo.PMProjectNormProductQty = 1;
            objProjectNormsInfo.PMProjectNormProductNetWeight = 1;
            objProjectNormsInfo.FK_PMTemplateID = 0;
            objProjectNormsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProjectNormsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProjectNormsInfo.FK_ICProductWorkGroupID = objProductsInfo.FK_ICProductWorkGroupID;
            objProjectNormsInfo.FK_ICProductWorkGroupParentID = 0;
            objProjectNormsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProjectNormsInfo.PMProjectNormProductNo = string.Join(string.Empty, new string[] { ProjectModule.PrefixWork, objProductsInfo.ICProductNo });
            objProjectNormsInfo.PMProjectNormProductName = objProductsInfo.ICProductName;
            objProjectNormsInfo.PMProjectNormType = TemplateItemType.Work.ToString();
            objProjectNormsInfo.PMProjectNormParentID = objProjectNormsInfoCurrent.PMProjectNormID;
            objProjectNormsInfo.PMProjectNormItem = ProjectLocalizedResources.PMProjectNormItemCaption;
            objProjectNormsInfo.SubList = new BOSTreeList();

            return objProjectNormsInfo;
        }

        private PMProjectNormsInfo ToPMProjectNormsInfoSection(ICProductsInfo objProductsInfo, PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo, PMProjectNormsInfo objProjectNormsInfoCurrent)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            PMProjectNormsInfo objProjectNormsInfo = new PMProjectNormsInfo();
            objProjectNormsInfo.FK_PMTemplateItemID = 0;
            objProjectNormsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProjectNormsInfo.FK_PMPhaseTypeID = objPTRelationshipsInfo.FK_PMPhaseTypeID;
            objProjectNormsInfo.FK_PMProjectID = mainObject.PMProjectID;
            objProjectNormsInfo.PMProjectNormProductType = TemplateItemType.Section.ToString();
            objProjectNormsInfo.PMProjectNormProductDesc = objProductsInfo.ICProductDesc;
            objProjectNormsInfo.PMProjectNormProductQty = 1;
            objProjectNormsInfo.PMProjectNormProductNetWeight = 1;
            objProjectNormsInfo.FK_PMTemplateID = 0;
            objProjectNormsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProjectNormsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProjectNormsInfo.FK_ICProductWorkGroupID = objProductsInfo.FK_ICProductWorkGroupID;
            objProjectNormsInfo.FK_ICProductWorkGroupParentID = 0;
            objProjectNormsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProjectNormsInfo.PMProjectNormProductNo = string.Join(string.Empty, new string[] { ProjectModule.PrefixSection, objProductsInfo.ICProductNo });
            objProjectNormsInfo.PMProjectNormProductName = objProductsInfo.ICProductName;
            objProjectNormsInfo.PMProjectNormType = TemplateItemType.Section.ToString();
            objProjectNormsInfo.PMProjectNormParentID = objProjectNormsInfoCurrent.PMProjectNormID;
            objProjectNormsInfo.PMProjectNormItem = string.Empty;
            objProjectNormsInfo.SubList = new BOSTreeList();

            return objProjectNormsInfo;
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo == null)
                return base.GetMainObjectNo(ref numberingStart);
            if (objGENumberingInfo != null)
            {
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
                if (objMainObjectController != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    DateTime currentDate = BOSApp.GetCurrentServerDate();
                    if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                    }

                    strMainObjectNo = String.Format("{0}-{1}.{2}",
                                                    objBranchsInfo.BRBranchNo,
                                                    currentDate.Year.ToString().Substring(2, 2),
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = String.Format("{0}-{1}.{2}",
                                                        objBranchsInfo.BRBranchNo,
                                                        currentDate.Year.ToString().Substring(2, 2),
                                                        objGENumberingInfo.GENumberingStart);
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            return strMainObjectNo;
        }

        public void SaveHistory(PMProjectNormsInfo oldObject, PMProjectNormsInfo newObject)
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)MainObject;
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> columnAliasList = new List<AAColumnAliasInfo>();
            DataSet ds = objColumnAliasController.GetAAColumnAliasByTableName(TableName.PMProjectNormsTableName);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objColumnAliasController.GetObjectFromDataRow(row);
                    columnAliasList.Add(objColumnAliasInfo);
                }
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            PMProjectNormHistorysController objProjectNormHistorysController = new PMProjectNormHistorysController();
            PMProjectNormHistorysInfo objProjectNormHistorysInfo;
            foreach (AAColumnAliasInfo alias in columnAliasList)
            {
                string oldValue = "";
                string newValue = "";
                if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                {
                    oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                }

                if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                {
                    newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                }

                if (oldValue != newValue)
                {
                    objProjectNormHistorysInfo = new PMProjectNormHistorysInfo();
                    objProjectNormHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objProjectNormHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objProjectNormHistorysInfo.PMProjectNormHistoryAction = "Change";
                    objProjectNormHistorysInfo.PMProjectNormHistoryDate = dbUtil.GetCurrentServerDate();
                    objProjectNormHistorysInfo.PMProjectNormHistoryTableName = TableName.PMProjectNormsTableName;
                    objProjectNormHistorysInfo.PMProjectNormHistoryDetailColumnName = alias.AAColumnAliasName;
                    objProjectNormHistorysInfo.PMProjectNormHistoryDetailOldValue = oldValue;
                    objProjectNormHistorysInfo.FK_PMProjectNormID = newObject.PMProjectNormID;
                    objProjectNormHistorysInfo.PMProjectNormHistoryDetailNewValue = newValue;
                    objProjectNormHistorysInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProjectNormHistorysInfo.FK_PMProjectID = mainObject.PMProjectID;
                    objProjectNormHistorysController.CreateObject(objProjectNormHistorysInfo);
                }
            }
        }
    }
}