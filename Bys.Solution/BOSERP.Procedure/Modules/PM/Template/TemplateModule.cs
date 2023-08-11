using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.Template
{
    public class TemplateModule : BaseTransactionModule
    {
        public const string ModuleName = "Template";

        public const string ICProductIDLookupEditControlName = "fld_lkeFK_ICProductID";

        public const string TemplateItemComponentMaterialsGridControlName = "fld_dgcTemplateItemComponentMaterialsGridControl";

        public const string TemplateItemComponentAssetsGridControlName = "fld_dgcTemplateItemComponentAssetsGridControl";

        public const string TemplateItemTasksGridControlName = "fld_dgcTemplateItemTasksGridControl";

        public const string PMTemplateItemsInfosTreeListControlName = "fld_trlTemplateItemsTreeListControl";

        public const string TemplateItemsInfosTabControlName = "fld_tabTemplateItem";

        public const string TemplateItemMaterialTabPageControlName = "fld_tabMaterial";

        public const string TemplateItemAssetTabPageControlName = "fld_tabAsset";

        public const string TemplateItemTaskTabPageControlName = "fld_tabTask";

        public const string AddPhaseTypeButtonName = "fld_btnAddPhaseType";

        public const string AddProductSectionButtonName = "fld_btnAddProductSection";

        public const string AddProductWorkButtonName = "fld_btnAddProductWork";

        public const string ApproveTemplateButtonTag = "ApproveTemplate";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string PrefixSection = "S-";

        public const string PrefixWork = "W-";

        public TemplateItemsTreeListControl TemplateItemsTreeListControl;

        public TemplateItemComponentsGridControl TemplateItemComponentMaterialsGridControl;

        public TemplateItemComponentsGridControl TemplateItemComponentAssetsGridControl;

        public TemplateItemTasksGridControl TemplateItemTasksGridControl;

        public BOSTabControl TemplateItemsInfosTabControl;

        public BOSButton AddPhaseTypeButton;

        public BOSButton AddProductSectionButton;

        public BOSButton AddProductWorkButton;

        public BOSLookupEdit SearchBranchLookupEditControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public List<BRBranchsInfo> BranchList;

        public TemplateModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new TemplateEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();

            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[TemplateModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            TemplateItemsTreeListControl = (TemplateItemsTreeListControl)Controls[TemplateModule.PMTemplateItemsInfosTreeListControlName];
            TemplateItemComponentMaterialsGridControl = (TemplateItemComponentsGridControl)Controls[TemplateModule.TemplateItemComponentMaterialsGridControlName];
            TemplateItemComponentAssetsGridControl = (TemplateItemComponentsGridControl)Controls[TemplateModule.TemplateItemComponentAssetsGridControlName];
            TemplateItemsInfosTabControl = (BOSTabControl)Controls[TemplateModule.TemplateItemsInfosTabControlName];
            AddPhaseTypeButton = (BOSButton)Controls[TemplateModule.AddPhaseTypeButtonName];
            AddProductSectionButton = (BOSButton)Controls[TemplateModule.AddProductSectionButtonName];
            AddProductWorkButton = (BOSButton)Controls[TemplateModule.AddProductWorkButtonName];
            TemplateItemTasksGridControl = (TemplateItemTasksGridControl)Controls[TemplateModule.TemplateItemTasksGridControlName];
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
            PMTemplatesController objTemplatesController = new PMTemplatesController();
            PMTemplatesInfo searchObject = (PMTemplatesInfo)CurrentModuleEntity.SearchObject;
            DataSet dsResult = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    dsResult = objTemplatesController.GetDataSetByID(-1);
                }
                else
                {
                    dsResult = objTemplatesController.GetTemplateListByListOfBranchID(searchObject.PMTemplateNo,
                                                                            searchObject.PMTemplateName,
                                                                            searchObject.FK_PMProjectTypeID,
                                                                            searchObject.PMTemplateFromDate,
                                                                            searchObject.PMTemplateToDate,
                                                                            BranchList);
                }
            }
            else
            {
                dsResult = objTemplatesController.GetTemplatesBySearchObject(searchObject.PMTemplateNo,
                                                                        searchObject.PMTemplateName,
                                                                        searchObject.FK_BRBranchID,
                                                                        searchObject.FK_PMProjectTypeID,
                                                                        searchObject.PMTemplateFromDate,
                                                                        searchObject.PMTemplateToDate);
            }
            return dsResult;
        }

        public void AddProductSectionToTemplateItemsList()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo mainObject = (PMTemplatesInfo)CurrentModuleEntity.MainObject;
            PMTemplateItemsInfo objTemplateItemsInfoCurrent = (PMTemplateItemsInfo)entity.TemplateItemList.CurrentObject;
            if (objTemplateItemsInfoCurrent.PMTemplateItemType == TemplateItemType.Work.ToString())
                return;

            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productSectionList = objProductsController.GetListProductByProductType(ProductType.Section.ToString());
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productSectionList, ProductType.Section.ToString());
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            List<ICProductsInfo> results = (List<ICProductsInfo>)guiAddProduct.SelectedObjects;
            if (results.Count == 0)
                return;

            entity.GenerateTemplateItemsSection(results, objTemplateItemsInfoCurrent);
            List<PMTemplateItemsInfo> templateItems = new List<PMTemplateItemsInfo>();
            entity.TemplateItemList.ConvertToList(templateItems);
            InvalidateTreeList(entity.TemplateItemList, templateItems, templateItems.Min(o => o.PMTemplateItemParentID));
            RefreshTreeView(entity.TemplateItemList);
        }

        public void AddWorkToTemplateItemsList()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo mainObject = (PMTemplatesInfo)CurrentModuleEntity.MainObject;
            PMTemplateItemsInfo objTemplateItemsInfoCurrent = (PMTemplateItemsInfo)entity.TemplateItemList.CurrentObject;
            if (objTemplateItemsInfoCurrent.PMTemplateItemType == TemplateItemType.Work.ToString())
                return;
            PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();

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

            entity.GenerateTemplateItemsWork(results, objTemplateItemsInfoCurrent);
            List<PMTemplateItemsInfo> templateItems = new List<PMTemplateItemsInfo>();
            entity.TemplateItemList.ConvertToList(templateItems);
            InvalidateTreeList(entity.TemplateItemList, templateItems, templateItems.Min(o => o.PMTemplateItemParentID));
            RefreshTreeView(entity.TemplateItemList);
        }

        public void ApproveTemplate()
        {
            base.ActionComplete();
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
                bool isApproved = entity.ApproveTemplate();
                if (isApproved)
                {
                    entity.TemplateItemList.TreeListControl.RefreshDataSource();
                    InvalidateToolbar();
                }
            }
        }

        public override void InvalidateToolbar()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo mainObject = (PMTemplatesInfo)entity.MainObject;
            string templateStatus = mainObject.PMTemplateStatus;

            if (mainObject.PMTemplateID > 0 && templateStatus == TemplateStatus.New.ToString())
                ParentScreen.SetEnableOfToolbarButton(TemplateModule.ApproveTemplateButtonTag, true);
            else
                ParentScreen.SetEnableOfToolbarButton(TemplateModule.ApproveTemplateButtonTag, false);
            AddProductSectionButton.Enabled = AddProductWorkButton.Enabled = mainObject.PMTemplateID > 0 ? (templateStatus == TemplateStatus.New.ToString()) : false;

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            base.Invalidate(iObjectID);
            if (entity.TemplateItemList == null)
                return;
            entity.TemplateItemList.Clear();
            RefreshTreeView(entity.TemplateItemList);
            InvalidateTemplateItem();
            TemplateItemsInfosTabControl.SelectedTabPageIndex = 0;
        }

        public void RefreshTreeView(BOSTreeList treeList)
        {
            if (treeList != null && treeList.TreeListControl != null)
            {
                treeList.TreeListControl.RefreshDataSource();
                treeList.TreeListControl.ExpandAll();
            }
        }

        private void InvalidateTemplateItem()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo mainObject = (PMTemplatesInfo)CurrentModuleEntity.MainObject;
            PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();
            List<PMTemplateItemsInfo> templateItems = new List<PMTemplateItemsInfo>();
            templateItems = objTemplateItemsController.GetTemplateItemsByTemplateID(mainObject.PMTemplateID);

            InvalidateTreeList(entity.TemplateItemList, templateItems, 0);
            RefreshTreeView(entity.TemplateItemList);
        }

        private void InvalidateTreeList(IBOSTreeList treeList, List<PMTemplateItemsInfo> collections, int parentID)
        {
            if (treeList != null && collections != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (PMTemplateItemsInfo item in collections)
                {
                    if (item.PMTemplateItemParentID == parentID)
                    {
                        PMTemplateItemsInfo objTemplateItemsInfo = (PMTemplateItemsInfo)item.Clone();
                        if (objTemplateItemsInfo.NumberOfChild == 0)
                            objTemplateItemsInfo.NumberOfChild = collections.Where(s => s.PMTemplateItemParentID == objTemplateItemsInfo.PMTemplateItemID).Count();
                        objTemplateItemsInfo.BackupObject = (PMTemplateItemsInfo)objTemplateItemsInfo.Clone();
                        treeList.Add(objTemplateItemsInfo);
                        if (objTemplateItemsInfo.NumberOfChild > 0)
                        {
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            objTemplateItemsInfo.SubList = (BOSTreeList)objType;
                            objTemplateItemsInfo.SubList.InitBOSList(this.CurrentModuleEntity, TableName.PMTemplateItemsTableName, TableName.PMTemplateItemsTableName);
                            this.InvalidateTreeList(objTemplateItemsInfo.SubList, collections, objTemplateItemsInfo.PMTemplateItemID);
                        }
                        objTemplateItemsInfo = (PMTemplateItemsInfo)item.Clone();
                        treeList.OriginalList.Add(objTemplateItemsInfo);
                        objTemplateItemsInfo = (PMTemplateItemsInfo)item.Clone();
                        treeList.BackupList.Add(objTemplateItemsInfo);
                    }
                }
            }
        }

        public void DeleteTemplateItemFromTreeList()
        {
            TemplateEntities entity = ((TemplateEntities)CurrentModuleEntity);
            PMTemplateItemsInfo objTemplateItemsInfoCurrent = (PMTemplateItemsInfo)entity.ModuleObjects[TableName.PMTemplateItemsTableName];
            if (objTemplateItemsInfoCurrent == null)
                return;

            DeleteTemplateItemComponentAndTask(objTemplateItemsInfoCurrent);

            DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = TemplateItemsTreeListControl.GetSelectedNode();
            if (currentNode != null)
            {
                if (TemplateItemsTreeListControl.BOSDisplayRoot)
                {
                    if (currentNode.Level > 0)
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                else
                {
                    if (currentNode.Level == 0)
                        TemplateItemsTreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                entity.TemplateItemList.SaveItemObjects();
            }
        }

        public void DeleteTemplateItemComponentAndTask(PMTemplateItemsInfo objTemplateItemsInfo)
        {
            TemplateEntities entity = ((TemplateEntities)CurrentModuleEntity);

            if (objTemplateItemsInfo.TemplateItemComponentsList == null)
            {
                objTemplateItemsInfo.TemplateItemComponentsList = new BOSList<PMTemplateItemComponentsInfo>();
                objTemplateItemsInfo.TemplateItemComponentsList.InitBOSList(entity,
                                                         TableName.PMTemplateItemsTableName,
                                                         TableName.PMTemplateItemComponentsTableName,
                                                         BOSList<PMTemplateItemComponentsInfo>.cstRelationForeign);
                objTemplateItemsInfo.TemplateItemComponentsList.ItemTableForeignKey = "FK_PMTemplateItemID";
                List<PMTemplateItemComponentsInfo> templateItemComponents = entity.TemplateItemComponentByTemplates.Where(s => s.FK_PMTemplateItemID == objTemplateItemsInfo.PMTemplateItemID).ToList();
                objTemplateItemsInfo.TemplateItemComponentsList.Invalidate(templateItemComponents);
            }

            if (objTemplateItemsInfo.TemplateItemTasksList == null)
            {
                objTemplateItemsInfo.TemplateItemTasksList = new BOSList<PMTemplateItemTasksInfo>();
                objTemplateItemsInfo.TemplateItemTasksList.InitBOSList(entity,
                                                         TableName.PMTemplateItemsTableName,
                                                         TableName.PMTemplateItemTasksTableName,
                                                         BOSList<PMTemplateItemTasksInfo>.cstRelationForeign);
                objTemplateItemsInfo.TemplateItemTasksList.ItemTableForeignKey = "FK_PMTemplateItemID";
                List<PMTemplateItemTasksInfo> templateItemTasks = entity.TemplateItemTaskByTemplates.Where(s => s.FK_PMTemplateItemID == objTemplateItemsInfo.PMTemplateItemID).ToList();
                objTemplateItemsInfo.TemplateItemTasksList.Invalidate(templateItemTasks);
            }

            if (objTemplateItemsInfo.NumberOfChild > 0)
            {
                List<PMTemplateItemsInfo> templateItems = new List<PMTemplateItemsInfo>();
                entity.TemplateItemList.ConvertToList(templateItems);
                templateItems.Where(o => o.PMTemplateItemParentID == objTemplateItemsInfo.PMTemplateItemID);
                foreach (PMTemplateItemsInfo item in templateItems)
                {
                    if (item.TemplateItemComponentsList == null)
                    {
                        item.TemplateItemComponentsList = new BOSList<PMTemplateItemComponentsInfo>();
                        item.TemplateItemComponentsList.InitBOSList(entity,
                                                             TableName.PMTemplateItemsTableName,
                                                             TableName.PMTemplateItemComponentsTableName,
                                                             BOSList<PMTemplateItemComponentsInfo>.cstRelationForeign);
                        item.TemplateItemComponentsList.ItemTableForeignKey = "FK_PMTemplateItemID";
                        List<PMTemplateItemComponentsInfo> templateItemComponents = entity.TemplateItemComponentByTemplates.Where(s => s.FK_PMTemplateItemID == item.PMTemplateItemID).ToList();
                        item.TemplateItemComponentsList.Invalidate(templateItemComponents);
                    }
                    entity.TemplateItemComponentByTemplates.RemoveAll(x => x.FK_PMTemplateItemID == item.PMTemplateItemID);
                    item.TemplateItemComponentsList.Clear();
                    item.TemplateItemComponentsList.SaveItemObjects();

                    if (item.TemplateItemTasksList == null)
                    {
                        item.TemplateItemTasksList = new BOSList<PMTemplateItemTasksInfo>();
                        item.TemplateItemTasksList.InitBOSList(entity,
                                                             TableName.PMTemplateItemsTableName,
                                                             TableName.PMTemplateItemTasksTableName,
                                                             BOSList<PMTemplateItemTasksInfo>.cstRelationForeign);
                        item.TemplateItemTasksList.ItemTableForeignKey = "FK_PMTemplateItemID";
                        List<PMTemplateItemTasksInfo> templateItemTasks = entity.TemplateItemTaskByTemplates.Where(s => s.FK_PMTemplateItemID == item.PMTemplateItemID).ToList();
                        item.TemplateItemTasksList.Invalidate(templateItemTasks);
                    }
                    entity.TemplateItemTaskByTemplates.RemoveAll(x => x.FK_PMTemplateItemID == item.PMTemplateItemID);
                    item.TemplateItemTasksList.Clear();
                    item.TemplateItemTasksList.SaveItemObjects();
                }
            }

            entity.TemplateItemComponentByTemplates.RemoveAll(x => x.FK_PMTemplateItemID == objTemplateItemsInfo.PMTemplateItemID);
            objTemplateItemsInfo.TemplateItemComponentsList.Clear();
            objTemplateItemsInfo.TemplateItemComponentsList.SaveItemObjects();

            entity.TemplateItemTaskByTemplates.RemoveAll(x => x.FK_PMTemplateItemID == objTemplateItemsInfo.PMTemplateItemID);
            objTemplateItemsInfo.TemplateItemTasksList.Clear();
            objTemplateItemsInfo.TemplateItemTasksList.SaveItemObjects();
        }

        public void ShowItemComponent()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo objTemplatesInfo = (PMTemplatesInfo)CurrentModuleEntity.MainObject;
            PMTemplateItemsInfo objTemplateItemsInfoCurrent = (PMTemplateItemsInfo)entity.TemplateItemList.CurrentObject;
            if (objTemplateItemsInfoCurrent == null || objTemplateItemsInfoCurrent.PMTemplateItemType != TemplateItemType.Work.ToString())
                return;

            if (objTemplateItemsInfoCurrent.TemplateItemComponentsList == null)
            {
                objTemplateItemsInfoCurrent.TemplateItemComponentsList = new BOSList<PMTemplateItemComponentsInfo>();
                objTemplateItemsInfoCurrent.TemplateItemComponentsList.InitBOSList(entity,
                                                             TableName.PMTemplateItemsTableName,
                                                             TableName.PMTemplateItemComponentsTableName,
                                                             BOSList<PMTemplateItemComponentsInfo>.cstRelationForeign);
                objTemplateItemsInfoCurrent.TemplateItemComponentsList.ItemTableForeignKey = "FK_PMTemplateItemID";
                objTemplateItemsInfoCurrent.TemplateItemComponentsList.Invalidate(entity.TemplateItemComponentByTemplates.Where(s => s.FK_PMTemplateItemID == objTemplateItemsInfoCurrent.PMTemplateItemID).ToList());
            }

            if (objTemplateItemsInfoCurrent.TemplateItemTasksList == null)
            {
                objTemplateItemsInfoCurrent.TemplateItemTasksList = new BOSList<PMTemplateItemTasksInfo>();
                objTemplateItemsInfoCurrent.TemplateItemTasksList.InitBOSList(entity,
                                                             TableName.PMTemplateItemsTableName,
                                                             TableName.PMTemplateItemTasksTableName,
                                                             BOSList<PMTemplateItemTasksInfo>.cstRelationForeign);
                objTemplateItemsInfoCurrent.TemplateItemTasksList.ItemTableForeignKey = "FK_PMTemplateItemID";
                objTemplateItemsInfoCurrent.TemplateItemTasksList.Invalidate(entity.TemplateItemTaskByTemplates.Where(s => s.FK_PMTemplateItemID == objTemplateItemsInfoCurrent.PMTemplateItemID).ToList());
            }

            guiTemplateItemComponent<PMTemplateItemComponentsInfo> guiTemplateItemComponent = new guiTemplateItemComponent<PMTemplateItemComponentsInfo>(objTemplateItemsInfoCurrent, (BOSList<PMTemplateItemComponentsInfo>)objTemplateItemsInfoCurrent.TemplateItemComponentsList, (BOSList<PMTemplateItemTasksInfo>)objTemplateItemsInfoCurrent.TemplateItemTasksList);
            guiTemplateItemComponent.Module = this;
            guiTemplateItemComponent.ShowDialog();
            if (guiTemplateItemComponent.DialogResult != DialogResult.OK)
                return;

            entity.TemplateItemComponentByTemplates.RemoveAll(x => x.FK_PMTemplateItemID == objTemplateItemsInfoCurrent.PMTemplateItemID);
            objTemplateItemsInfoCurrent.TemplateItemComponentsList.Clear();
            objTemplateItemsInfoCurrent.TemplateItemComponentsList.Invalidate(guiTemplateItemComponent.TemplateItemComponentList);

            objTemplateItemsInfoCurrent.TemplateItemComponentsList.SaveItemObjects();
            entity.TemplateItemComponentByTemplates = entity.TemplateItemComponentByTemplates
                                                            .Union(objTemplateItemsInfoCurrent.TemplateItemComponentsList)
                                                            .ToList();

            entity.TemplateItemTaskByTemplates.RemoveAll(x => x.FK_PMTemplateItemID == objTemplateItemsInfoCurrent.PMTemplateItemID);
            objTemplateItemsInfoCurrent.TemplateItemTasksList.Clear();
            objTemplateItemsInfoCurrent.TemplateItemTasksList.Invalidate(guiTemplateItemComponent.TemplateItemTaskList);

            objTemplateItemsInfoCurrent.TemplateItemTasksList.SaveItemObjects();
            entity.TemplateItemTaskByTemplates = entity.TemplateItemTaskByTemplates
                                                            .Union(objTemplateItemsInfoCurrent.TemplateItemTasksList)
                                                            .ToList();
        }

        public void InvalidateTemplateItemByType(string tabSelectedName)
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            if (entity.TemplateItemComponentByTemplates == null)
                return;
            List<PMTemplateItemComponentsInfo> templateItemComponents = new List<PMTemplateItemComponentsInfo>();
            switch (tabSelectedName)
            {
                case TemplateItemMaterialTabPageControlName:
                    templateItemComponents = entity.TemplateItemComponentByTemplates
                                                 .Where(i => i.PMTemplateItemComponentType == ProductWorkItemType.Material.ToString())
                                                 .GroupBy(l => l.PMTemplateItemComponentProductNo)
                                                 .Select(cl => new PMTemplateItemComponentsInfo
                                                 {
                                                     PMTemplateItemComponentProductNo = cl.First().PMTemplateItemComponentProductNo,
                                                     PMTemplateItemComponentProductName = cl.First().PMTemplateItemComponentProductName,
                                                     PMTemplateItemComponentProductDesc = cl.First().PMTemplateItemComponentProductDesc,
                                                     PMTemplateItemComponentWorkType = cl.First().PMTemplateItemComponentWorkType,
                                                     PMTemplateItemComponentQty = cl.Sum(c => c.PMTemplateItemComponentQty),
                                                 }).ToList();
                    TemplateItemComponentMaterialsGridControl.DataSource = templateItemComponents;
                    TemplateItemComponentMaterialsGridControl.RefreshDataSource();
                    break;

                case TemplateItemAssetTabPageControlName:
                    templateItemComponents = entity.TemplateItemComponentByTemplates
                                                 .Where(i => i.PMTemplateItemComponentType == ProductWorkItemType.Asset.ToString())
                                                 .GroupBy(l => l.PMTemplateItemComponentProductNo)
                                                 .Select(cl => new PMTemplateItemComponentsInfo
                                                 {
                                                     PMTemplateItemComponentProductNo = cl.First().PMTemplateItemComponentProductNo,
                                                     PMTemplateItemComponentProductName = cl.First().PMTemplateItemComponentProductName,
                                                     PMTemplateItemComponentProductDesc = cl.First().PMTemplateItemComponentProductDesc,
                                                     PMTemplateItemComponentWorkType = cl.First().PMTemplateItemComponentWorkType,
                                                     PMTemplateItemComponentQty = cl.Sum(c => c.PMTemplateItemComponentQty),
                                                 }).ToList();
                    TemplateItemComponentAssetsGridControl.DataSource = templateItemComponents;
                    TemplateItemComponentAssetsGridControl.RefreshDataSource();
                    break;

                case TemplateItemTaskTabPageControlName:
                    TemplateItemTasksGridControl.DataSource = entity.TemplateItemTaskByTemplates;
                    TemplateItemTasksGridControl.RefreshDataSource();
                    break;
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            entity.TemplateItemComponentByTemplates = new List<PMTemplateItemComponentsInfo>();
            entity.TemplateItemTaskByTemplates = new List<PMTemplateItemTasksInfo>();
        }

        public void ChangedTemplateItemQty()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplateItemsInfo objTemplateItemsInfo = (PMTemplateItemsInfo)entity.TemplateItemList.CurrentObject;
            if (objTemplateItemsInfo == null)
                return;

            PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();
            List<PMTemplateItemComponentsInfo> templateItemComponents = new List<PMTemplateItemComponentsInfo>();
            if (objTemplateItemsInfo.TemplateItemComponentsList == null)
            {
                objTemplateItemsInfo.TemplateItemComponentsList = new BOSList<PMTemplateItemComponentsInfo>();
                objTemplateItemsInfo.TemplateItemComponentsList.InitBOSList(entity,
                                                         TableName.PMTemplateItemsTableName,
                                                         TableName.PMTemplateItemComponentsTableName,
                                                         BOSList<PMTemplateItemComponentsInfo>.cstRelationForeign);
                objTemplateItemsInfo.TemplateItemComponentsList.ItemTableForeignKey = "FK_PMTemplateItemID";
                templateItemComponents = entity.TemplateItemComponentByTemplates.Where(o => o.FK_PMTemplateItemID == objTemplateItemsInfo.PMTemplateItemID).ToList();
                objTemplateItemsInfo.TemplateItemComponentsList.Invalidate(templateItemComponents);
            }
            templateItemComponents = objTemplateItemsInfo.TemplateItemComponentsList.Select(o => { o.PMTemplateItemComponentQty = o.PMTemplateItemComponentBasicQty * objTemplateItemsInfo.PMTemplateItemProductQty; return o; }).ToList();
            objTemplateItemsInfo.TemplateItemComponentsList.Invalidate(templateItemComponents);
            objTemplateItemsInfo.TemplateItemComponentsList.SaveItemObjects();
            objTemplateItemsController.UpdateObject(objTemplateItemsInfo);

            entity.TemplateItemComponentByTemplates.RemoveAll(o => o.FK_PMTemplateItemID == objTemplateItemsInfo.PMTemplateItemID);
            entity.TemplateItemComponentByTemplates = entity.TemplateItemComponentByTemplates
                                                                .Union(templateItemComponents)
                                                                .ToList();
        }

        public void ChangedTemplateItem()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplateItemsInfo objTemplateItemsInfo = (PMTemplateItemsInfo)entity.TemplateItemList.CurrentObject;
            if (objTemplateItemsInfo == null)
                return;

            PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();
            objTemplateItemsController.UpdateObject(objTemplateItemsInfo);
        }

        private bool CheckValidateMainObject()
        {
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo mainObject = (PMTemplatesInfo)entity.MainObject;
            if (mainObject.FK_PMProjectTypeID == 0)
            {
                MessageBox.Show(TemplateLocalizedResources.PMProjectTypeRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mainObject.FK_PMPhaseTypeID == 0)
            {
                MessageBox.Show(TemplateLocalizedResources.PMPhaseTypeRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override int ActionSave()
        {
            if (!CheckValidateMainObject())
                return 0;

            return base.ActionSave();
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
            TemplateEntities entity = (TemplateEntities)CurrentModuleEntity;
            PMTemplatesInfo mainobject = (PMTemplatesInfo)entity.MainObject;
            mainobject.PMTemplateStatus = TemplateStatus.New.ToString();
            mainobject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainobject.FK_HREmployeeApproveID = 0;
        }
    }
}
