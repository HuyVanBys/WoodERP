using BOSCommon;
using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Template
{
    public class TemplateEntities : BaseTransactionEntities
    {

        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        public BOSTreeList TemplateItemList { get; set; }

        public List<PMTemplateItemComponentsInfo> TemplateItemComponentByTemplates { get; set; }

        public List<PMTemplateItemTasksInfo> TemplateItemTaskByTemplates { get; set; }
        #endregion

        #region Constructor
        public TemplateEntities()
            : base()
        {
            TemplateItemList = new BOSTreeList();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new PMTemplatesInfo();
            SearchObject = new PMTemplatesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.PMTemplateItemsTableName, new PMTemplateItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            TemplateItemList.InitBOSList(this,
                                               TableName.PMTemplatesTableName,
                                               TableName.PMTemplateItemsTableName,
                                               BOSList<PMTemplateItemsInfo>.cstRelationForeign);
            TemplateItemList.ItemTableForeignKey = "FK_PMTemplateID";
        }

        public override void InitGridControlInBOSList()
        {
            TemplateItemList.InitBOSTreeListControl(TemplateModule.PMTemplateItemsInfosTreeListControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            TemplateItemList.SetDefaultListAndRefreshTreeListControl();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            PMTemplateItemComponentsController objTemplateItemComponentsController = new PMTemplateItemComponentsController();
            TemplateItemComponentByTemplates = new List<PMTemplateItemComponentsInfo>();
            TemplateItemComponentByTemplates = objTemplateItemComponentsController.GetTemplateItemComponentsByTemplateID(iObjectID);

            PMTemplateItemTasksController objTemplateItemTasksController = new PMTemplateItemTasksController();
            TemplateItemTaskByTemplates = new List<PMTemplateItemTasksInfo>();
            TemplateItemTaskByTemplates = objTemplateItemTasksController.GetTemplateItemTasksByTemplateID(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            TemplateItemList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            PMTemplatesInfo objTemplatesInfo = (PMTemplatesInfo)MainObject;
            objTemplatesInfo.PMTemplateDate = BOSApp.GetCurrentServerDate();
            objTemplatesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        #endregion

        public bool ApproveTemplate()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                //TemplateItemList.SaveItemObjects();

                PMTemplatesInfo objTemplatesInfo = (PMTemplatesInfo)MainObject;
                objTemplatesInfo.PMTemplateStatus = TemplateStatus.Approved.ToString();
                objTemplatesInfo.FK_HREmployeeApproveID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objTemplatesInfo.PMTemplateApproveDate = BOSApp.GetCurrentServerDate();
                UpdateMainObject();

                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void GenerateTemplateItemsSection(List<ICProductsInfo> products, PMTemplateItemsInfo objTemplateItemsInfoParent)
        {
            PMTemplatesInfo mainObject = (PMTemplatesInfo)MainObject;
            PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();
            products.ForEach(o =>
                {
                    PMTemplateItemsInfo objTemplateItemsInfo = ToTemplateItemsInfoSection(o, objTemplateItemsInfoParent);
                    int templateItemID = objTemplateItemsController.CreateObject(objTemplateItemsInfo);
                    if (templateItemID > 0)
                        TemplateItemList.Add(objTemplateItemsInfo);
                });
        }

        public PMTemplateItemsInfo ToTemplateItemsInfoSection(ICProductsInfo objProductsInfo, PMTemplateItemsInfo objTemplateItemsInfoParent)
        {
            PMTemplatesInfo mainObject = (PMTemplatesInfo)MainObject;
            PMTemplateItemsInfo objTemplateItemsInfo = new PMTemplateItemsInfo();
            objTemplateItemsInfo.FK_PMTemplateID = mainObject.PMTemplateID;
            objTemplateItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objTemplateItemsInfo.PMTemplateItemProductNo = string.Join(string.Empty, new string[] { TemplateModule.PrefixSection, objProductsInfo.ICProductNo });
            objTemplateItemsInfo.PMTemplateItemProductName = objProductsInfo.ICProductName;
            objTemplateItemsInfo.PMTemplateItemProductDesc = objProductsInfo.ICProductDesc;
            objTemplateItemsInfo.PMTemplateItemProductQty = 1;
            objTemplateItemsInfo.PMTemplateItemProductNetWeight = 1;
            objTemplateItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objTemplateItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objTemplateItemsInfo.FK_ICProductWorkGroupID = objProductsInfo.FK_ICProductWorkGroupID;
            objTemplateItemsInfo.FK_ICProductWorkGroupParentID = 0;
            objTemplateItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objTemplateItemsInfo.PMTemplateItemType = TemplateItemType.Section.ToString();
            objTemplateItemsInfo.PMTemplateItemWorkType = string.IsNullOrEmpty(objProductsInfo.ICProductWorkType) ? TemplateItemWorkType.Work.ToString() : objProductsInfo.ICProductWorkType;
            objTemplateItemsInfo.PMTemplateItemParentID = objTemplateItemsInfoParent == null ? 0 : objTemplateItemsInfoParent.PMTemplateItemID;
            objTemplateItemsInfo.PMTemplateItemComponent = string.Empty;
            if (objTemplateItemsInfo.SubList == null)
                objTemplateItemsInfo.SubList = new BOSTreeList();

            return objTemplateItemsInfo;
        }

        public void GenerateTemplateItemsWork(List<ICProductsInfo> products, PMTemplateItemsInfo objTemplateItemsInfoParent)
        {
            PMTemplatesInfo mainObject = (PMTemplatesInfo)MainObject;
            PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();
            products.ForEach(o =>
            {
                PMTemplateItemsInfo objTemplateItemsInfo = ToTemplateItemsInfoWork(o, objTemplateItemsInfoParent);
                int templateItemID = objTemplateItemsController.CreateObject(objTemplateItemsInfo);
                if (templateItemID > 0)
                {
                    TemplateItemList.Add(objTemplateItemsInfo);
                    objTemplateItemsInfo.TemplateItemComponentsList = new BOSList<PMTemplateItemComponentsInfo>();
                    objTemplateItemsInfo.TemplateItemComponentsList.InitBOSList(this,
                                                             TableName.PMTemplateItemsTableName,
                                                             TableName.PMTemplateItemComponentsTableName,
                                                             BOSList<PMTemplateItemComponentsInfo>.cstRelationForeign);
                    ICProductWorkItemsController objProductWorkItemsController = new ICProductWorkItemsController();

                    List<ICProductWorkItemsInfo> productWorkItems = objProductWorkItemsController.GetProductWorkItemsByProductWorkItemParentID(objTemplateItemsInfo.FK_ICProductID);
                    productWorkItems.ForEach(x => objTemplateItemsInfo.TemplateItemComponentsList.Add(ToTemplateItemComponentsInfo(x, objTemplateItemsInfo)));

                    objTemplateItemsInfo.TemplateItemComponentsList.SaveItemObjects();

                    TemplateItemComponentByTemplates = TemplateItemComponentByTemplates
                                                                .Union(objTemplateItemsInfo.TemplateItemComponentsList)
                                                                .ToList();

                    objTemplateItemsInfo.TemplateItemTasksList = new BOSList<PMTemplateItemTasksInfo>();
                    objTemplateItemsInfo.TemplateItemTasksList.InitBOSList(this,
                                                         TableName.PMTemplateItemsTableName,
                                                         TableName.PMTemplateItemTasksTableName,
                                                         BOSList<PMTemplateItemTasksInfo>.cstRelationForeign);
                    ICProductTasksController objProductTasksController = new ICProductTasksController();

                    List<ICProductTasksInfo> productTasks = objProductTasksController.GetProductTasksByProductID(objTemplateItemsInfo.FK_ICProductID);
                    productTasks.ForEach(x => objTemplateItemsInfo.TemplateItemTasksList.Add(ToTemplateItemTasksInfo(x, objTemplateItemsInfo)));

                    objTemplateItemsInfo.TemplateItemTasksList.SaveItemObjects();

                    TemplateItemTaskByTemplates = TemplateItemTaskByTemplates
                                                               .Union(objTemplateItemsInfo.TemplateItemTasksList)
                                                               .ToList();
                }
            });
        }

        public PMTemplateItemsInfo ToTemplateItemsInfoWork(ICProductsInfo objProductsInfo, PMTemplateItemsInfo objTemplateItemsInfoParent)
        {
            PMTemplatesInfo mainObject = (PMTemplatesInfo)MainObject;
            PMTemplateItemsInfo objTemplateItemsInfo = new PMTemplateItemsInfo();
            objTemplateItemsInfo = new PMTemplateItemsInfo();
            objTemplateItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objTemplateItemsInfo.FK_PMTemplateID = mainObject.PMTemplateID;
            objTemplateItemsInfo.PMTemplateItemProductNo = string.Join(string.Empty, new string[] { TemplateModule.PrefixWork, objProductsInfo.ICProductNo });
            objTemplateItemsInfo.PMTemplateItemProductName = objProductsInfo.ICProductName;
            objTemplateItemsInfo.PMTemplateItemProductDesc = objProductsInfo.ICProductDesc;
            objTemplateItemsInfo.PMTemplateItemProductQty = 1;
            objTemplateItemsInfo.PMTemplateItemProductNetWeight = 1;
            objTemplateItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objTemplateItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objTemplateItemsInfo.FK_ICProductWorkGroupID = objProductsInfo.FK_ICProductWorkGroupID;
            objTemplateItemsInfo.FK_ICProductWorkGroupParentID = 0;
            objTemplateItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objTemplateItemsInfo.PMTemplateItemType = TemplateItemType.Work.ToString();
            objTemplateItemsInfo.PMTemplateItemWorkType = string.IsNullOrEmpty(objProductsInfo.ICProductWorkType) ? TemplateItemWorkType.Work.ToString() : objProductsInfo.ICProductWorkType;
            objTemplateItemsInfo.PMTemplateItemParentID = objTemplateItemsInfoParent == null ? 0 : objTemplateItemsInfoParent.PMTemplateItemID;
            objTemplateItemsInfo.PMTemplateItemComponent = TemplateLocalizedResources.PMTemplateItemComponentCaption;
            if (objTemplateItemsInfo.SubList == null)
                objTemplateItemsInfo.SubList = new BOSTreeList();

            return objTemplateItemsInfo;
        }

        public PMTemplateItemComponentsInfo ToTemplateItemComponentsInfo(ICProductWorkItemsInfo objProductWorkItemsInfo, PMTemplateItemsInfo objTemplateItemsInfo)
        {
            PMTemplatesInfo mainObject = (PMTemplatesInfo)MainObject;
            PMTemplateItemComponentsInfo objTemplateItemComponentsInfo = new PMTemplateItemComponentsInfo();
            objTemplateItemComponentsInfo.FK_PMTemplateID = mainObject.PMTemplateID;
            objTemplateItemComponentsInfo.FK_PMTemplateItemID = objTemplateItemsInfo.PMTemplateItemID;
            objTemplateItemComponentsInfo.FK_ICProductWorkID = objTemplateItemsInfo.FK_ICProductID;
            objTemplateItemComponentsInfo.FK_ICProductWorkItemID = objProductWorkItemsInfo.ICProductWorkItemID;
            objTemplateItemComponentsInfo.FK_ICProductID = objProductWorkItemsInfo.FK_ICProductWorkItemChildID;
            objTemplateItemComponentsInfo.PMTemplateItemComponentType = objProductWorkItemsInfo.ICProductWorkItemType;
            objTemplateItemComponentsInfo.PMTemplateItemComponentProductNo = objProductWorkItemsInfo.ICProductWorkItemProductNo;
            objTemplateItemComponentsInfo.PMTemplateItemComponentProductName = objProductWorkItemsInfo.ICProductWorkItemProductName;
            objTemplateItemComponentsInfo.PMTemplateItemComponentProductDesc = objProductWorkItemsInfo.ICProductWorkItemProductDesc;
            objTemplateItemComponentsInfo.PMTemplateItemComponentWorkType = string.IsNullOrEmpty(objProductWorkItemsInfo.ICProductWorkType) ? TemplateItemWorkType.Purchase.ToString() : objProductWorkItemsInfo.ICProductWorkType;
            objTemplateItemComponentsInfo.PMTemplateItemComponentQty = objProductWorkItemsInfo.ICProductWorkItemQty;
            objTemplateItemComponentsInfo.PMTemplateItemComponentBasicQty = objProductWorkItemsInfo.ICProductWorkItemQty;

            return objTemplateItemComponentsInfo;
        }

        public PMTemplateItemTasksInfo ToTemplateItemTasksInfo(ICProductTasksInfo objProductTasksInfo, PMTemplateItemsInfo objTemplateItemsInfo)
        {
            PMTemplatesInfo mainObject = (PMTemplatesInfo)MainObject;
            PMTemplateItemTasksInfo objTemplateItemTasksInfo = new PMTemplateItemTasksInfo();
            objTemplateItemTasksInfo.FK_HRDepartmentRoomID = objProductTasksInfo.FK_HRDepartmentRoomID;
            objTemplateItemTasksInfo.FK_HRDepartmentID = objProductTasksInfo.FK_HRDepartmentID;
            objTemplateItemTasksInfo.FK_HREmployeeID = objProductTasksInfo.FK_ICMeasureUnitID;
            objTemplateItemTasksInfo.FK_ICProductTaskID = objProductTasksInfo.ICProductTaskID;
            objTemplateItemTasksInfo.FK_ICTaskID = objProductTasksInfo.FK_ICTaskID;
            objTemplateItemTasksInfo.FK_PMProjectTypeID = mainObject.FK_PMProjectTypeID;
            objTemplateItemTasksInfo.FK_PMTemplateItemID = objTemplateItemsInfo.PMTemplateItemID;
            objTemplateItemTasksInfo.FK_PMTemplateID = mainObject.PMTemplateID;
            objTemplateItemTasksInfo.PMTemplateItemTaskNo = objProductTasksInfo.ICProductTaskNo;
            objTemplateItemTasksInfo.PMTemplateItemTaskName = objProductTasksInfo.ICProductTaskName;
            objTemplateItemTasksInfo.PMTemplateItemTaskInfo = objProductTasksInfo.ICProductTaskInfo;
            objTemplateItemTasksInfo.PMTemplateItemTaskQty = objProductTasksInfo.ICProductTaskQty;
            objTemplateItemTasksInfo.PMTemplateItemTaskTotalEstimatedDays = objProductTasksInfo.ICProductTaskTotalEstimatedDays;
            objTemplateItemTasksInfo.PMTemplateItemTaskTotalEstimatedHours = objProductTasksInfo.ICProductTaskTotalEstimatedHours;
            objTemplateItemTasksInfo.PMTemplateItemTaskTotalActualDays = objProductTasksInfo.ICProductTaskTotalActualDays;
            objTemplateItemTasksInfo.PMTemplateItemTaskTotalActualHours = objProductTasksInfo.ICProductTaskTotalActualHours;
            objTemplateItemTasksInfo.PMTemplateItemTaskTaskActualTotalCost = objProductTasksInfo.ICProductTaskEstimatedTotalCost;
            objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedExtendDays = objProductTasksInfo.ICProductTaskEstimatedExtendDays;
            objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedExtendHours = objProductTasksInfo.ICProductTaskEstimatedExtendHours;
            objTemplateItemTasksInfo.PMTemplateItemTaskActualExtendDays = objProductTasksInfo.ICProductTaskActualExtendDays;
            objTemplateItemTasksInfo.PMTemplateItemTaskActualExtendHours = objProductTasksInfo.ICProductTaskActualExtendHours;
            objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedStartDate = BOSApp.GetCurrentServerDate();
            objTemplateItemTasksInfo.PMTemplateItemTaskActualStartDate = BOSApp.GetCurrentServerDate();
            objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedEndDate = objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedStartDate
                                                                                                      .AddDays(Convert.ToDouble(objTemplateItemTasksInfo.PMTemplateItemTaskTotalEstimatedDays))
                                                                                                      .AddHours(Convert.ToDouble(objTemplateItemTasksInfo.PMTemplateItemTaskTotalEstimatedHours));
            objTemplateItemTasksInfo.PMTemplateItemTaskActualEndDate = objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedEndDate;
            return objTemplateItemTasksInfo;
        }

        public override void DuplicateModuleObjectList()
        {
            TemplateItemList.Duplicate();
        }
    }
}