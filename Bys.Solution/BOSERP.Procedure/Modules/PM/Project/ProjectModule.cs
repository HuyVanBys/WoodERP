using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public class ProjectModule : BaseTransactionModule
    {

        public const string ProjectContactsGridControlName = "fld_dgcPMProjectContactsGridControl";

        public const string ProjectNormsTreeListControlName = "fld_trlProjectNormsTreeListControl";

        public const string ProjectNormsInfosTabControlName = "fld_tabProjectNorm";

        public const string ProjectNormMaterialTabPageControlName = "fld_tabMaterial";

        public const string ProjectNormAssetTabPageControlName = "fld_tabAsset";

        public const string TaskTabPageControlName = "fld_tabTask";

        public const string ProjectNormItemsMaterialsGridControlName = "fld_dgcProjectNormItemMaterialsGridControl";

        public const string ProjectNormItemsAssetsGridControlName = "fld_dgcProjectNormItemAssetsGridControl";

        public const string PMTasksGridControlName = "fld_dgcPMTasksGridControl";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ProjectLocationsGridControlName = "fld_dgcProjectLocationsGridControl";

        public const string ProjectTemplateRelationshipsGridControlName = "fld_dgcProjectTemplateRelationshipsGridControl";

        public const string ARSaleOrdersGridControlName = "fld_dgcARSaleOrdersGridControl";

        public const string PMProjectNormHistorysGridControlName = "fld_dgcPMProjectNormHistorysGridControl";

        public const string PrefixSection = "S-";

        public const string PrefixWork = "W-";

        public ProjectNormItemsGridControl ProjectNormItemsMaterialsGridControl;

        public ProjectNormItemsGridControl ProjectNormItemsAssetsGridControl;

        public ProjectNormsTreeListControl ProjectNormsTreeListControl;

        public PMTasksGridControl PMTasksGridControl;

        public ProjectTemplateRelationshipsGridControl ProjectTemplateRelationshipsGridControl;

        public BOSLookupEdit SearchBranchLookupEditControl;

        public BOSTabControl ProjectNormsInfosTabControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public List<BRBranchsInfo> BranchList;

        public ARSaleContractsGridControl ARSaleContractsGridControl;

        public ProjectModule()
        {
            Name = ModuleName.Project;
            CurrentModuleEntity = new ProjectEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();

            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[ProjectModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            ProjectNormsTreeListControl = (ProjectNormsTreeListControl)Controls[ProjectModule.ProjectNormsTreeListControlName];
            ProjectNormItemsMaterialsGridControl = (ProjectNormItemsGridControl)Controls[ProjectModule.ProjectNormItemsMaterialsGridControlName];
            ProjectNormItemsAssetsGridControl = (ProjectNormItemsGridControl)Controls[ProjectModule.ProjectNormItemsAssetsGridControlName];
            PMTasksGridControl = (PMTasksGridControl)Controls[ProjectModule.PMTasksGridControlName];
            ProjectNormsInfosTabControl = (BOSTabControl)Controls[ProjectModule.ProjectNormsInfosTabControlName];
            ProjectTemplateRelationshipsGridControl = (ProjectTemplateRelationshipsGridControl)Controls[ProjectModule.ProjectTemplateRelationshipsGridControlName];
            ARSaleContractsGridControl = (ARSaleContractsGridControl)Controls["fld_dgcARSaleContractsGridControl"];
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            PMProjectsController objProjectsController = new PMProjectsController();
            PMProjectsInfo searchObject = (PMProjectsInfo)CurrentModuleEntity.SearchObject;
            DataSet dsResult = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    dsResult = objProjectsController.GetDataSetByID(-1);
                }
                else
                {
                    dsResult = objProjectsController.GetProjectListByListOfBranchID(searchObject.PMProjectNo,
                                                                            searchObject.PMProjectName,
                                                                            searchObject.FK_PMProjectTypeID,
                                                                            searchObject.FK_HRProjectOwnerEmployeeID,
                                                                            searchObject.PMProjectFromDate,
                                                                            searchObject.PMProjectToDate,
                                                                            BranchList);
                }
            }
            else
            {
                dsResult = objProjectsController.GetProjectListBySomeCriteria(searchObject.PMProjectNo,
                                                                        searchObject.PMProjectName,
                                                                        searchObject.FK_BRBranchID,
                                                                        searchObject.FK_PMProjectTypeID,
                                                                        searchObject.FK_HRProjectOwnerEmployeeID,
                                                                        searchObject.PMProjectFromDate,
                                                                        searchObject.PMProjectToDate);
            }
            return dsResult;
        }

        public void ChooseLocation()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectLocationsInfo objProjectLocationsInfo = (PMProjectLocationsInfo)entity.ModuleObjects[TableName.PMProjectLocationsTableName];
            guiChooseLocation locationForm = new guiChooseLocation(objProjectLocationsInfo.FK_GELocationID);
            locationForm.Module = this;
            if (locationForm.ShowDialog() == DialogResult.OK)
            {
                GELocationsController objLocationsController = new GELocationsController();
                GELocationsInfo objLocationsInfo = (GELocationsInfo)locationForm.LocationTreeList.GetSelectedObject();
                if (objLocationsInfo != null && objLocationsInfo.Selected)
                {
                    objProjectLocationsInfo.FK_GELocationID = objLocationsInfo.GELocationID;
                    objProjectLocationsInfo.PMProjectLocationName = objLocationsController.GetFullLocationNameByID(objLocationsInfo.GELocationID);
                }
                else
                {
                    objProjectLocationsInfo.FK_GELocationID = 0;
                    objProjectLocationsInfo.PMProjectLocationName = string.Empty;
                }
            }
        }

        public void AddItemToProjectContactList()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectContactsInfo objProjectContactsInfo = (PMProjectContactsInfo)entity.ModuleObjects[TableName.PMProjectContactsTableName];
            if (string.IsNullOrEmpty(objProjectContactsInfo.PMProjectContactName))
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectContactNameIsNullErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //int countDefaultAddress = entity.ProjectContactsList.Where(s => s.PMProjectContactDefaultAddress).Count();
            //if (objProjectContactsInfo.PMProjectContactDefaultAddress)
            //    countDefaultAddress++;
            //if (countDefaultAddress > 1)
            //{
            //    MessageBox.Show(ProjectLocalizedResources.ProjectContactDefaultAddressErrorMessate, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            entity.ProjectContactsList.AddObjectToList();
        }

        public void RemoveSelectedItemFromProjectContactList()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            entity.ProjectContactsList.RemoveSelectedRowObjectFromList();
        }

        public void ChangeSelectedItemFromProjectContactList()
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            entity.ProjectContactsList.ChangeObjectFromList();
            int countDefaultAddress = entity.ProjectContactsList.Where(s => s.PMProjectContactDefaultAddress).Count();
            if (countDefaultAddress > 1)
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectContactDefaultAddressErrorMessate, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActionCancel();
            }
        }

        public void ShowTemplateList()
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            if (entity.ProjectNormByProject == null)
                entity.ProjectNormByProject = new List<PMProjectNormsInfo>();

            PMTemplatesController objTemplatesController = new PMTemplatesController();
            List<PMTemplatesInfo> templates = objTemplatesController.GetTemplatesByProjectTypeID(mainObject.FK_PMProjectTypeID);
            guiFind<PMTemplatesInfo> guiFind = new guiFind<PMTemplatesInfo>(TableName.PMTemplatesTableName, templates, this, true, true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;

            IList<PMTemplatesInfo> results = guiFind.SelectedObjects;

            BOSProgressBar.Start(ProjectLocalizedResources.InitProjectNormMessage);

            PMProjectTemplateRelationshipsController objPTRelationshipsController = new PMProjectTemplateRelationshipsController();
            foreach (PMTemplatesInfo item in results)
            {
                bool result = entity.GenarateProjectNormFromTemplate(item);
                if (result)
                {

                    PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = new PMProjectTemplateRelationshipsInfo
                    {
                        FK_PMProjectID = mainObject.PMProjectID,
                        FK_PMTemplateID = item.PMTemplateID,
                        FK_PMPhaseTypeID = item.FK_PMPhaseTypeID,
                        PMPhaseTypeName = item.PMPhaseTypeName,
                    };
                    entity.ProjectTemplateRelationships.Add(objPTRelationshipsInfo);
                    objPTRelationshipsController.CreateObject(objPTRelationshipsInfo);
                }
            }
            ProjectTemplateRelationshipsGridControl.RefreshDataSource();
            //RefreshTreeView(entity.ProjectNormList);

            BOSProgressBar.Close();
        }

        public override void Invalidate(int iObjectID)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            base.Invalidate(iObjectID);
            if (entity.ProjectNormList == null)
                return;
            entity.ProjectNormByProject = new List<PMProjectNormsInfo>();
            entity.ProjectNormList.Clear();
            //RefreshTreeView(entity.ProjectNormList);
            InvalidateProjectNorm();

            PMProjectTemplateRelationshipsController objPTRelationshipsController = new PMProjectTemplateRelationshipsController();
            List<PMProjectTemplateRelationshipsInfo> relationships = objPTRelationshipsController.GetProjectTemplateRelationshipsByProjectID(iObjectID);
            entity.ProjectTemplateRelationships.Invalidate(relationships);
            ShowAllContractBelongProjectID(iObjectID);
        }

        public void RefreshTreeView(BOSTreeList treeList)
        {
            if (treeList != null && treeList.TreeListControl != null)
            {
                treeList.TreeListControl.RefreshDataSource();
                treeList.TreeListControl.ExpandAll();
            }
        }

        private void InvalidateProjectNorm()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;
            List<PMProjectNormsInfo> projectNormsList = new List<PMProjectNormsInfo>();
            PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = null;
            if (entity.ProjectTemplateRelationships.CurrentIndex >= 0)
                objPTRelationshipsInfo = (PMProjectTemplateRelationshipsInfo)entity.ProjectTemplateRelationships[entity.ProjectTemplateRelationships.CurrentIndex];
            if (entity.ProjectNormByProject == null
                || entity.ProjectNormByProject.Count == 0)
            {
                PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
                entity.ProjectNormByProject = new List<PMProjectNormsInfo>();
                entity.ProjectNormByProject = objProjectNormsController.GetProjectNormsByProjectID(mainObject.PMProjectID);
                projectNormsList = entity.ProjectNormByProject;
                PMTasksGridControl.DataSource = entity.TaskByProject;
            }
            else
            {
                projectNormsList = entity.ProjectNormByProject.Where(o => o.FK_PMPhaseTypeID == objPTRelationshipsInfo.FK_PMPhaseTypeID).ToList();
                List<PMTasksInfo> tasks = new List<PMTasksInfo>();
                projectNormsList.ForEach(o =>
                {
                    tasks.AddRange(entity.TaskByProject.Where(x => x.FK_Object01ID == o.PMProjectNormID));
                });
                PMTasksGridControl.DataSource = tasks;
            }
            PMTasksGridControl.RefreshDataSource();
            InvalidateTreeList(entity.ProjectNormList, projectNormsList, projectNormsList.Count > 0 ? projectNormsList.Min(o => o.PMProjectNormParentID) : 0);
            RefreshTreeView(entity.ProjectNormList);
        }

        private void InvalidateTreeList(IBOSTreeList treeList, List<PMProjectNormsInfo> collections, int parentID)
        {
            if (treeList != null && collections != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (PMProjectNormsInfo item in collections)
                {
                    if (item.PMProjectNormParentID == parentID)
                    {
                        PMProjectNormsInfo objProjectNormsInfo = (PMProjectNormsInfo)item.Clone();
                        if (objProjectNormsInfo.NumberOfChild == 0)
                            objProjectNormsInfo.NumberOfChild = collections.Where(o => o.PMProjectNormParentID == objProjectNormsInfo.PMProjectNormID).Count();

                        objProjectNormsInfo.BackupObject = (PMProjectNormsInfo)objProjectNormsInfo.Clone();
                        treeList.Add(objProjectNormsInfo);
                        if (objProjectNormsInfo.NumberOfChild > 0)
                        {
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            objProjectNormsInfo.SubList = (BOSTreeList)objType;
                            objProjectNormsInfo.SubList.InitBOSList(this.CurrentModuleEntity, TableName.PMProjectNormsTableName, TableName.PMProjectNormsTableName);
                            this.InvalidateTreeList(objProjectNormsInfo.SubList, collections, objProjectNormsInfo.PMProjectNormID);
                        }
                        objProjectNormsInfo = (PMProjectNormsInfo)item.Clone();
                        treeList.OriginalList.Add(objProjectNormsInfo);
                        objProjectNormsInfo = (PMProjectNormsInfo)item.Clone();
                        treeList.BackupList.Add(objProjectNormsInfo);
                    }
                }
            }
        }

        public void DeleteProjectNormFromTreeList()
        {
            ProjectEntities entity = ((ProjectEntities)CurrentModuleEntity);
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ModuleObjects[TableName.PMProjectNormsTableName];

            if (objProjectNormsInfoCurrent == null || objProjectNormsInfoCurrent.PMProjectNormID == 0)
                return;

            DeleteProjectNormItemAndTask(objProjectNormsInfoCurrent);

            DeleteProjectNorm(objProjectNormsInfoCurrent);

            InvalidateProjectNorm();
        }

        private void DeleteProjectNorm(PMProjectNormsInfo objProjectNormsInfo)
        {
            ProjectEntities entity = ((ProjectEntities)CurrentModuleEntity);
            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            List<PMProjectNormsInfo> prjectNorms = new List<PMProjectNormsInfo>();
            prjectNorms = entity.ProjectNormByProject.Where(o => o.PMProjectNormParentID == objProjectNormsInfo.PMProjectNormID).ToList();
            entity.ProjectNormByProject = entity.ProjectNormByProject.Where(o => o.PMProjectNormID != objProjectNormsInfo.PMProjectNormID && o.PMProjectNormParentID != objProjectNormsInfo.PMProjectNormID).ToList();
            objProjectNormsController.DeleteAllObjectsByObjectParentID(objProjectNormsInfo.PMProjectNormID);
            objProjectNormsController.DeleteObject(objProjectNormsInfo.PMProjectNormID);
            foreach (PMProjectNormsInfo item in prjectNorms)
            {
                if (item.NumberOfChild > 0)
                    DeleteProjectNorm(item);
            }
        }

        public void DeleteProjectNormItemAndTask(PMProjectNormsInfo objProjectNormsInfo)
        {
            ProjectEntities entity = ((ProjectEntities)CurrentModuleEntity);
            if (objProjectNormsInfo.ProjectNormItemsList == null)
            {
                objProjectNormsInfo.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                objProjectNormsInfo.ProjectNormItemsList.InitBOSList(entity,
                                                         TableName.PMProjectNormsTableName,
                                                         TableName.PMProjectNormItemsTableName,
                                                         BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                objProjectNormsInfo.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                List<PMProjectNormItemsInfo> projectNormItems = entity.ProjectNormItemsByProject.Where(o => o.FK_PMProjectNormID == objProjectNormsInfo.PMProjectNormID).ToList();
                objProjectNormsInfo.ProjectNormItemsList.Invalidate(projectNormItems);
            }

            if (objProjectNormsInfo.TasksList == null)
            {
                objProjectNormsInfo.TasksList = new BOSList<PMTasksInfo>();
                objProjectNormsInfo.TasksList.InitBOSList(entity,
                                                         TableName.PMProjectNormsTableName,
                                                         TableName.PMTasksTableName,
                                                         BOSList<PMTasksInfo>.cstRelationForeign);
                objProjectNormsInfo.TasksList.ItemTableForeignKey = "FK_Object01ID";
                List<PMTasksInfo> tasks = entity.TaskByProject.Where(o => o.FK_Object01ID == objProjectNormsInfo.PMProjectNormID).ToList();
                objProjectNormsInfo.TasksList.Invalidate(tasks);
            }

            if (objProjectNormsInfo.ProjectNormItemsList.Count > 0)
            {
                entity.ProjectNormItemsByProject.RemoveAll(o => o.FK_PMProjectNormID == objProjectNormsInfo.PMProjectNormID);
                objProjectNormsInfo.ProjectNormItemsList.Clear();
                objProjectNormsInfo.ProjectNormItemsList.SaveItemObjects();
            }

            if (objProjectNormsInfo.TasksList.Count > 0)
            {
                entity.TaskByProject.RemoveAll(o => o.FK_Object01ID == objProjectNormsInfo.PMProjectNormID);
                objProjectNormsInfo.TasksList.Clear();
                objProjectNormsInfo.TasksList.SaveItemObjects();
            }

            if (objProjectNormsInfo.NumberOfChild > 0)
            {
                List<PMProjectNormsInfo> prjectNorms = new List<PMProjectNormsInfo>();
                entity.ProjectNormList.ConvertToList(prjectNorms);
                prjectNorms = prjectNorms.Where(o => o.PMProjectNormParentID == objProjectNormsInfo.PMProjectNormID).ToList();
                foreach (PMProjectNormsInfo item in prjectNorms)
                {
                    if (item.ProjectNormItemsList == null)
                    {
                        item.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                        item.ProjectNormItemsList.InitBOSList(entity,
                                                             TableName.PMProjectNormsTableName,
                                                             TableName.PMProjectNormItemsTableName,
                                                             BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                        item.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                        List<PMProjectNormItemsInfo> projectNormItems = entity.ProjectNormItemsByProject.Where(o => o.FK_PMProjectNormID == item.PMProjectNormID).ToList();
                        item.ProjectNormItemsList.Invalidate(projectNormItems);
                    }

                    if (item.ProjectNormItemsList.Count > 0)
                    {
                        entity.ProjectNormItemsByProject.RemoveAll(o => o.FK_PMProjectNormID == item.PMProjectNormID);
                        item.ProjectNormItemsList.Clear();
                        item.ProjectNormItemsList.SaveItemObjects();
                    }

                    if (item.TasksList == null)
                    {
                        item.TasksList = new BOSList<PMTasksInfo>();
                        item.TasksList.InitBOSList(entity,
                                                    TableName.PMProjectNormsTableName,
                                                    TableName.PMTasksTableName,
                                                    BOSList<PMTasksInfo>.cstRelationForeign);
                        item.TasksList.ItemTableForeignKey = "FK_Object01ID";
                        List<PMTasksInfo> tasks = entity.TaskByProject.Where(o => o.FK_Object01ID == item.PMProjectNormID).ToList();
                        item.TasksList.Invalidate(tasks);
                    }

                    if (item.TasksList.Count > 0)
                    {
                        entity.TaskByProject.RemoveAll(o => o.FK_Object01ID == item.PMProjectNormID);
                        item.TasksList.Clear();
                        item.TasksList.SaveItemObjects();
                    }

                    if (item.NumberOfChild > 0)
                        DeleteProjectNormItemAndTask(item);
                }
            }
        }

        public void ShowProjectNormItem()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ProjectNormList.CurrentObject;
            if (objProjectNormsInfoCurrent == null)
                return;

            if (objProjectNormsInfoCurrent.PMProjectNormType != TemplateItemType.Work.ToString())
                return;

            if (objProjectNormsInfoCurrent.ProjectNormItemsList == null)
            {
                objProjectNormsInfoCurrent.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                objProjectNormsInfoCurrent.ProjectNormItemsList.InitBOSList(entity,
                                                         TableName.PMProjectNormsTableName,
                                                         TableName.PMProjectNormItemsTableName,
                                                         BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                objProjectNormsInfoCurrent.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                List<PMProjectNormItemsInfo> projectNormItems = entity.ProjectNormItemsByProject.Where(s => s.FK_PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID).ToList();
                objProjectNormsInfoCurrent.ProjectNormItemsList.Invalidate(projectNormItems);
            }

            if (objProjectNormsInfoCurrent.TasksList == null)
            {
                objProjectNormsInfoCurrent.TasksList = new BOSList<PMTasksInfo>();
                objProjectNormsInfoCurrent.TasksList.InitBOSList(entity,
                                                         TableName.PMProjectNormsTableName,
                                                         TableName.PMTasksTableName,
                                                         BOSList<PMTemplateItemTasksInfo>.cstRelationForeign);
                objProjectNormsInfoCurrent.TasksList.ItemTableForeignKey = "FK_Object01ID";
                List<PMTasksInfo> tasks = entity.TaskByProject.Where(s => s.FK_Object01ID == objProjectNormsInfoCurrent.PMProjectNormID).ToList();
                objProjectNormsInfoCurrent.TasksList.Invalidate(tasks);
            }

            guiProjectNormItem<PMProjectNormItemsInfo> guiProjectNormItem = new guiProjectNormItem<PMProjectNormItemsInfo>(objProjectNormsInfoCurrent, (BOSList<PMProjectNormItemsInfo>)objProjectNormsInfoCurrent.ProjectNormItemsList, (BOSList<PMTasksInfo>)objProjectNormsInfoCurrent.TasksList);
            guiProjectNormItem.Module = this;
            guiProjectNormItem.ShowDialog();
            if (guiProjectNormItem.DialogResult != DialogResult.OK)
                return;

            if (objProjectNormsInfoCurrent.ProjectNormItemsList != guiProjectNormItem.ProjectNormItemsList)
            {
                entity.ProjectNormItemsByProject.RemoveAll(x => x.FK_PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID);
                objProjectNormsInfoCurrent.ProjectNormItemsList.Clear();
                objProjectNormsInfoCurrent.ProjectNormItemsList = guiProjectNormItem.ProjectNormItemsList;
                entity.ProjectNormItemsByProject = entity.ProjectNormItemsByProject
                                                                .Union(objProjectNormsInfoCurrent.ProjectNormItemsList.ToList())
                                                                .ToList();
                objProjectNormsInfoCurrent.ProjectNormItemsList.SaveItemObjects();
            }

            if (objProjectNormsInfoCurrent.TasksList != guiProjectNormItem.TaskList)
            {
                entity.TaskByProject.RemoveAll(x => x.FK_Object01ID == objProjectNormsInfoCurrent.PMProjectNormID);
                objProjectNormsInfoCurrent.TasksList.Clear();
                foreach (PMTasksInfo item in guiProjectNormItem.TaskList)
                    objProjectNormsInfoCurrent.TasksList.Add(item);
                objProjectNormsInfoCurrent.TasksList.All(o =>
                    {
                        o.FK_Object02ID = mainObject.FK_PMProjectTypeID;
                        o.ObjectType02 = ObjectType.ProjectType.ToString();
                        return true;
                    });
                entity.TaskByProject = entity.TaskByProject
                                                    .Union(objProjectNormsInfoCurrent.TasksList.ToList())
                                                    .ToList();
                objProjectNormsInfoCurrent.TasksList.SaveItemObjects();
                if (objProjectNormsInfoCurrent.TasksList.Count > 0)
                {
                    objProjectNormsInfoCurrent.PMProjectNormStartDate = objProjectNormsInfoCurrent.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                    objProjectNormsInfoCurrent.PMProjectNormEndDate = objProjectNormsInfoCurrent.TasksList.Max(x => x.PMTaskEstimatedEndDate);
                    PMProjectNormsInfo objProjectNormsInfo = entity.ProjectNormByProject.FirstOrDefault(o => o.PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID);

                    objProjectNormsInfo.PMProjectNormStartDate = objProjectNormsInfoCurrent.TasksList.Min(x => x.PMTaskEstimatedStartDate);
                    objProjectNormsInfo.PMProjectNormEndDate = objProjectNormsInfoCurrent.TasksList.Max(x => x.PMTaskEstimatedEndDate);
                }
            }
            entity.ProjectNormList.SaveItemObjects();
            InvalidateProjectNorm();
        }

        public void SelectedTabPageProjectNorm(string tabSelectedName)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            List<PMProjectNormItemsInfo> projectNormItems = new List<PMProjectNormItemsInfo>();
            string type = tabSelectedName == ProjectNormMaterialTabPageControlName
                ? ProductWorkItemType.Material.ToString()
                : tabSelectedName == ProjectNormAssetTabPageControlName ? ProductWorkItemType.Asset.ToString() : string.Empty;
            projectNormItems = entity.ProjectNormItemsByProject
                                                 .Where(i => i.PMProjectNormItemProductType == type)
                                                 .GroupBy(l => l.PMProjectNormItemProductNo)
                                                 .Select(cl => new PMProjectNormItemsInfo
                                                 {
                                                     PMProjectNormItemProductNo = cl.First().PMProjectNormItemProductNo,
                                                     PMProjectNormItemProductName = cl.First().PMProjectNormItemProductName,
                                                     PMProjectNormItemProductDesc = cl.First().PMProjectNormItemProductDesc,
                                                     PMProjectNormItemQty = cl.Sum(c => c.PMProjectNormItemQty),
                                                 }).ToList();
            switch (tabSelectedName)
            {
                case ProjectNormMaterialTabPageControlName:

                    ProjectNormItemsMaterialsGridControl.DataSource = projectNormItems;
                    ProjectNormItemsMaterialsGridControl.RefreshDataSource();
                    break;

                case ProjectNormAssetTabPageControlName:
                    ProjectNormItemsAssetsGridControl.DataSource = projectNormItems;
                    ProjectNormItemsAssetsGridControl.RefreshDataSource();
                    break;

                    //case TaskTabPageControlName:
                    //    PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo;
                    //    if (entity.ProjectTemplateRelationships.CurrentIndex >= 0)
                    //        objPTRelationshipsInfo = (PMProjectTemplateRelationshipsInfo)entity.ProjectTemplateRelationships[entity.ProjectTemplateRelationships.CurrentIndex];
                    //    if (objPTRelationshipsInfo == null)
                    //        PMTasksGridControl.DataSource = entity.TaskByProject;
                    //    else
                    //    {
                    //        List<PMProjectNormsInfo> projectNormsList = new List<PMProjectNormsInfo>();
                    //        projectNormsList = entity.ProjectNormByProject.Where(o => o.FK_PMPhaseTypeID == objPTRelationshipsInfo.FK_PMPhaseTypeID).ToList();
                    //        if (projectNormsList.Count > 0)
                    //        {
                    //            List<PMTasksInfo> tasks = new List<PMTasksInfo>();
                    //            projectNormsList.ForEach(o =>
                    //                {
                    //                    tasks.AddRange(entity.TaskByProject.Where(x => x.FK_Object01ID == o.PMProjectNormID));
                    //                });
                    //            PMTasksGridControl.DataSource = tasks;
                    //        }
                    //    }
                    //    PMTasksGridControl.RefreshDataSource();
                    //    break;
            }
        }

        public void AddProductSectionToProjectNormsList()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ProjectNormList.CurrentObject;
            if (entity.ProjectTemplateRelationships.CurrentIndex < 0)
                return;

            PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = (PMProjectTemplateRelationshipsInfo)entity.ProjectTemplateRelationships[entity.ProjectTemplateRelationships.CurrentIndex];
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productWorkList = objProductsController.GetListProductByProductType(ProductType.Section.ToString());
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productWorkList, ProductType.Section.ToString());
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            List<ICProductsInfo> results = (List<ICProductsInfo>)guiAddProduct.SelectedObjects;
            if (results.Count == 0)
                return;

            entity.GenarateProjectNormFromSections(results, objPTRelationshipsInfo, objProjectNormsInfoCurrent);
            InvalidateProjectNorm();
        }

        public void AddWorkToProjectNormsList()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ProjectNormList.CurrentObject;
            if (entity.ProjectTemplateRelationships.CurrentIndex < 0)
                return;
            PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = (PMProjectTemplateRelationshipsInfo)entity.ProjectTemplateRelationships[entity.ProjectTemplateRelationships.CurrentIndex];

            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productWorkList = objProductsController.GetListProductByProductType(ProductType.Work.ToString());
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productWorkList, ProductType.Work.ToString());
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            List<ICProductsInfo> results = (List<ICProductsInfo>)guiAddProduct.SelectedObjects;
            if (results.Count == 0)
                return;

            entity.GenarateProjectNormFromWorks(results, objPTRelationshipsInfo, objProjectNormsInfoCurrent);
            InvalidateProjectNorm();
        }

        public void ShowProjectList()
        {
            PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            entity.ProjectNormByProject = new List<PMProjectNormsInfo>();

            PMProjectsController objProjectsController = new PMProjectsController();
            List<PMProjectsInfo> projects = objProjectsController.GetAllProjects();
            guiFind<PMProjectsInfo> guiFind = new guiFind<PMProjectsInfo>(TableName.PMProjectsTableName
                                                                            , projects
                                                                            , this
                                                                            , false
                                                                            , true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;

            PMProjectsInfo result = guiFind.SelectedObjects[0];
            entity.GenarateProjectNormFromProjectOld(result);
            ProjectTemplateRelationshipsGridControl.RefreshDataSource();
            RefreshTreeView(entity.ProjectNormList);
        }

        public void AddProjectLocation()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectLocationsInfo objProjectLocationsInfo = (PMProjectLocationsInfo)entity.ModuleObjects[TableName.PMProjectLocationsTableName];
            //Check valid input
            if (String.IsNullOrEmpty(objProjectLocationsInfo.PMProjectLocationName))
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectLocationNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(objProjectLocationsInfo.PMProjectLocationAddress))
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectLocationAddressRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isExisting = entity.ProjectLocations.Where(s => s.PMProjectLocationName == objProjectLocationsInfo.PMProjectLocationName
                                                                 && s.PMProjectLocationAddress == objProjectLocationsInfo.PMProjectLocationAddress).Count() > 0;
            if (isExisting)
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectLocationNameExistsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            objProjectLocationsInfo.FK_PMProjectID = 0;
            entity.ProjectLocations.AddObjectToList();
        }

        public void EditProjectLocation()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectLocationsInfo objProjectLocationsInfo = (PMProjectLocationsInfo)entity.ModuleObjects[TableName.PMProjectLocationsTableName];

            //Check valid edit
            if (String.IsNullOrEmpty(objProjectLocationsInfo.PMProjectLocationName))
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectLocationNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(objProjectLocationsInfo.PMProjectLocationAddress))
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectLocationAddressRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isExisting = entity.ProjectLocations.Where(s => s.PMProjectLocationName == objProjectLocationsInfo.PMProjectLocationName
                                                                 && s.PMProjectLocationAddress == objProjectLocationsInfo.PMProjectLocationAddress).Count() > 0;
            if (isExisting)
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectLocationNameExistsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((ProjectEntities)CurrentModuleEntity).ProjectLocations.ChangeObjectFromList();
        }

        public void DeleteProjectLocation()
        {
            ((ProjectEntities)CurrentModuleEntity).ProjectLocations.RemoveSelectedRowObjectFromList();
        }

        public void UpdateCustomerInfo(string objectAccessKey)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo == null)
                return;
            mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
            mainObject.PMObjectType = objObjectsInfo.ACObjectType;
            mainObject.ACObjectAccessKey = objectAccessKey;
            mainObject.ARCustomerContactAddressLine1 = objObjectsInfo.ACObjectDeliveryAddressLine1;
            mainObject.ARCustomerContactEmail1 = objObjectsInfo.ACObjectContactEmail;
            mainObject.ARCustomerContactPhone = objObjectsInfo.ACObjectContactPhone;
            if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                mainObject.FK_ARCustomerID = objObjectsInfo.ACObjectID;

            GELocationsController objLocationsController = new GELocationsController();
            mainObject.ARCustomerContactLocationName = objLocationsController.GetFullLocationNameByID(objObjectsInfo.GELocationID);
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangedProjectNorm()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ProjectNormList.CurrentObject;
            if (objProjectNormsInfoCurrent == null)
                return;

            if (objProjectNormsInfoCurrent.PMProjectNormType != TemplateItemType.Work.ToString())
                return;

            PMProjectNormsInfo objProjectNormsInfo = entity.ProjectNormByProject.FirstOrDefault(o => o.PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID);
            if (objProjectNormsInfo != null)
            {
                entity.SaveHistory(objProjectNormsInfo, objProjectNormsInfoCurrent);
                objProjectNormsInfo.PMProjectNormProductType = objProjectNormsInfoCurrent.PMProjectNormProductType;
                objProjectNormsInfo.PMProjectNormSortOrder = objProjectNormsInfoCurrent.PMProjectNormSortOrder;
                objProjectNormsInfo.FK_ICMeasureUnitID = objProjectNormsInfoCurrent.FK_ICMeasureUnitID;
                objProjectNormsInfo.PMProjectNormStatus = objProjectNormsInfoCurrent.PMProjectNormStatus;
                objProjectNormsInfo.PMProjectNormIsApproved = objProjectNormsInfoCurrent.PMProjectNormIsApproved;
            }
            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            objProjectNormsController.UpdateObject(objProjectNormsInfoCurrent);
        }

        public void ChangedProjectNormQty()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ProjectNormList.CurrentObject;
            if (objProjectNormsInfoCurrent == null)
                return;

            if (objProjectNormsInfoCurrent.PMProjectNormType != TemplateItemType.Work.ToString())
                return;

            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            List<PMProjectNormItemsInfo> projectNormItems = new List<PMProjectNormItemsInfo>();
            if (objProjectNormsInfoCurrent.ProjectNormItemsList == null)
            {
                objProjectNormsInfoCurrent.ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>();
                objProjectNormsInfoCurrent.ProjectNormItemsList.InitBOSList(entity,
                                                         TableName.PMProjectNormsTableName,
                                                         TableName.PMProjectNormItemsTableName,
                                                         BOSList<PMProjectNormItemsInfo>.cstRelationForeign);
                objProjectNormsInfoCurrent.ProjectNormItemsList.ItemTableForeignKey = "FK_PMProjectNormID";
                projectNormItems = entity.ProjectNormItemsByProject.Where(o => o.FK_PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID).ToList();
                objProjectNormsInfoCurrent.ProjectNormItemsList.Invalidate(projectNormItems);
            }
            projectNormItems = objProjectNormsInfoCurrent.ProjectNormItemsList.Select(o => { o.PMProjectNormItemQty = o.PMProjectNormItemBasicQty * objProjectNormsInfoCurrent.PMProjectNormProductQty; return o; }).ToList();
            objProjectNormsInfoCurrent.ProjectNormItemsList.Invalidate(projectNormItems);
            objProjectNormsInfoCurrent.ProjectNormItemsList.SaveItemObjects();
            objProjectNormsController.UpdateObject(objProjectNormsInfoCurrent);

            entity.ProjectNormItemsByProject.RemoveAll(o => o.FK_PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID);
            entity.ProjectNormItemsByProject = entity.ProjectNormItemsByProject
                                                     .Union(projectNormItems)
                                                     .ToList();
            PMProjectNormsInfo objProjectNormsInfo = entity.ProjectNormByProject.FirstOrDefault(o => o.PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID);
            entity.SaveHistory(objProjectNormsInfo, objProjectNormsInfoCurrent);
        }

        public void EstimateProject()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
                PMProjectsInfo mainObject = (PMProjectsInfo)CurrentModuleEntity.MainObject;
                if (mainObject.PMProjectStatus == "Estimated")
                {
                    MessageBox.Show(ProjectLocalizedResources.ProjectExistsEstimateMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Estimate.EstimateModule estimateModule = (Estimate.EstimateModule)BOSApp.ShowModule("Estimate");
                if (estimateModule == null)
                    return;

                Estimate.EstimateEntities estimateEntities = (Estimate.EstimateEntities)estimateModule.CurrentModuleEntity;

                AREstimatesInfo objEstimatesInfo = (AREstimatesInfo)estimateEntities.MainObject;
                objEstimatesInfo.FK_ARCustomerID = mainObject.FK_ARCustomerID;

                estimateModule.ActionNew(mainObject);
            }
        }

        public void ShowProjectNormByPhaseType()
        {
            InvalidateProjectNorm();
        }

        public override void ActionNew()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            entity.ProjectNormByProject = new List<PMProjectNormsInfo>();
            entity.ProjectNormItemsByProject = new List<PMProjectNormItemsInfo>();
            entity.TaskByProject = new List<PMTasksInfo>();
            ProjectNormsInfosTabControl.SelectedTabPageIndex = 0;
            base.ActionNew();
        }

        public void RemoveSelectedItemFromProjectTemplateRelationshipsList()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            if (entity.ProjectTemplateRelationships.CurrentIndex < 0)
                return;
            PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = (PMProjectTemplateRelationshipsInfo)entity.ProjectTemplateRelationships[entity.ProjectTemplateRelationships.CurrentIndex];
            bool isExitProjectNorm = entity.ProjectNormByProject.Where(o => o.FK_PMPhaseTypeID == objPTRelationshipsInfo.FK_PMPhaseTypeID).Count() > 0;
            if (isExitProjectNorm)
            {
                MessageBox.Show(ProjectLocalizedResources.ProjectNormDeletePhaseMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PMProjectTemplateRelationshipsController objPTRController = new PMProjectTemplateRelationshipsController();
            objPTRController.DeleteObject(objPTRelationshipsInfo.PMProjectTemplateRelationshipID);
            entity.ProjectTemplateRelationships.Remove(objPTRelationshipsInfo);
            ProjectTemplateRelationshipsGridControl.RefreshDataSource();
        }

        public void ActionNewFromProspectCustomer()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            ActionNew();
            ARProspectCustomersController objProspectCustomersController = new ARProspectCustomersController();
            List<ARProspectCustomersInfo> prospectCustomersList = (List<ARProspectCustomersInfo>)objProspectCustomersController.GetListFromDataSet(objProspectCustomersController.GetAllObjects());

            guiFind<ARProspectCustomersInfo> guiFind = new guiFind<ARProspectCustomersInfo>(TableName.ARProspectCustomersTableName
                                                                                            , prospectCustomersList
                                                                                            , this
                                                                                            , false);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;

            ARProspectCustomersInfo objProspectCustomersInfo = guiFind.SelectedObjects[0];
            entity.GenerateProjectEntities(objProspectCustomersInfo);
        }

        public void ShowAllTask()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMTasksGridControl.DataSource = entity.TaskByProject;
            PMTasksGridControl.RefreshDataSource();
        }

        public void ApprovedProjectTemplateRelationship()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            if (entity.ProjectTemplateRelationships.CurrentIndex < 0)
                return;
            PMProjectTemplateRelationshipsInfo objPTRelationshipsInfo = (PMProjectTemplateRelationshipsInfo)entity.ProjectTemplateRelationships[entity.ProjectTemplateRelationships.CurrentIndex];
            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            PMProjectTemplateRelationshipsController objProjectTemplateRelationshipsController = new PMProjectTemplateRelationshipsController();
            entity.ProjectNormByProject.Where(o => o.FK_PMPhaseTypeID == objPTRelationshipsInfo.FK_PMPhaseTypeID).All(o =>
                {
                    o.PMProjectNormIsApproved = objPTRelationshipsInfo.PMProjectTemplateRelationshipIsApproved;
                    objProjectNormsController.UpdateObject(o);
                    return true;
                });
            objProjectTemplateRelationshipsController.UpdateObject(objPTRelationshipsInfo);
            entity.SetPropertyChangeEventLock(true);
            InvalidateProjectNorm();
        }

        public void ChangeProjectEstimatedEndDate(DateTime projectEstimatedEndDate)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo objProjectsInfo = (PMProjectsInfo)entity.MainObject;
            objProjectsInfo.PMProjectEstimatedEndDate = projectEstimatedEndDate;
            TimeSpan difference = objProjectsInfo.PMProjectEstimatedEndDate - objProjectsInfo.PMProjectEstimatedStartDate;
            objProjectsInfo.PMProjectEstimatedTotalDays = difference.Days;
            //if (DateTime.Compare(objProjectsInfo.PMProjectActualEndDate.Date, DateTime.MaxValue.Date) == 0)
            //{
            objProjectsInfo.PMProjectActualEndDate = projectEstimatedEndDate;
            difference = objProjectsInfo.PMProjectActualEndDate - objProjectsInfo.PMProjectActualStartDate;
            objProjectsInfo.PMProjectActualTotalDays = difference.Days;
            //}
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeProjectActualEndDate(DateTime projectActualEndDate)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo objProjectsInfo = (PMProjectsInfo)entity.MainObject;
            objProjectsInfo.PMProjectActualEndDate = projectActualEndDate;
            TimeSpan difference = objProjectsInfo.PMProjectActualEndDate - objProjectsInfo.PMProjectActualStartDate;
            objProjectsInfo.PMProjectActualTotalDays = difference.Days;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeProjectActualStartDate(DateTime projectActualStartDate)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo objProjectsInfo = (PMProjectsInfo)entity.MainObject;
            objProjectsInfo.PMProjectActualStartDate = projectActualStartDate;
            TimeSpan difference = objProjectsInfo.PMProjectActualEndDate - objProjectsInfo.PMProjectActualStartDate;
            objProjectsInfo.PMProjectActualTotalDays = difference.Days;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeProjectEstimatedStartDate(DateTime projectEstimatedStartDate)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo objProjectsInfo = (PMProjectsInfo)entity.MainObject;
            objProjectsInfo.PMProjectEstimatedStartDate = projectEstimatedStartDate;
            TimeSpan difference = objProjectsInfo.PMProjectActualEndDate - objProjectsInfo.PMProjectActualStartDate;
            objProjectsInfo.PMProjectEstimatedTotalDays = difference.Days;
            entity.UpdateMainObjectBindingSource();
        }

        internal void UpdateStartDay()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectNormsInfo objProjectNormsInfoCurrent = (PMProjectNormsInfo)entity.ProjectNormList.CurrentObject;
            if (objProjectNormsInfoCurrent != null) UpdateStartDay(objProjectNormsInfoCurrent);
            entity.SetPropertyChangeEventLock(true);
            InvalidateProjectNorm();
        }

        private void UpdateStartDay(PMProjectNormsInfo objProjectNormsInfoCurrent)
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            PMProjectNormsInfo objProjectNormsInfo = entity.ProjectNormByProject.Where(p => p.PMProjectNormID == objProjectNormsInfoCurrent.PMProjectNormID).FirstOrDefault();
            if (objProjectNormsInfo != null)
            {
                objProjectNormsInfo.PMProjectNormStartDate = objProjectNormsInfoCurrent.PMProjectNormStartDate;
                objProjectNormsController.UpdateObject(objProjectNormsInfo);
            }
            entity.ProjectNormByProject.Where(p => p.PMProjectNormParentID == objProjectNormsInfoCurrent.PMProjectNormID).ToList().ForEach(o =>
            {
                o.PMProjectNormStartDate = objProjectNormsInfoCurrent.PMProjectNormStartDate;
                objProjectNormsController.UpdateObject(o);
                UpdateStartDay(o);
            });
        }

        public void ShowAllContractBelongProjectID(int projectID)
        {
            try
            {
                ARSaleContractsController objSaleContractsController = new ARSaleContractsController();
                List<ARSaleContractsInfo> saleContractList = objSaleContractsController.GetAllSaleContractByProjectID(projectID);
                ARSaleContractsGridControl.InvalidateDataSource(saleContractList);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public override int ActionSave()
        {
            ProjectEntities entity = (ProjectEntities)CurrentModuleEntity;
            PMProjectsInfo objProjectsInfo = (PMProjectsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(objProjectsInfo.ACObjectAccessKey))
            {
                MessageBox.Show(ProjectLocalizedResources.IsvalidateObject, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return base.ActionSave();
        }

        public void AddNewCustomer()
        {
            Customer.CustomerModule customerModule = (Customer.CustomerModule)BOSApp.ShowModule(ModuleName.Customer);
            if (customerModule == null)
                return;

            Customer.CustomerEntities customerEntities = (Customer.CustomerEntities)customerModule.CurrentModuleEntity;
            customerModule.ActionNew();
        }
    }
}
