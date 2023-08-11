using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public partial class guiProjectNormItem<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<PMProjectNormItemsInfo> ProjectNormItemsList { get; set; }

        public BOSList<PMProjectNormItemsInfo> ProjectNormItemMaterialList { get; set; }

        public BOSList<PMProjectNormItemsInfo> ProjectNormItemAssetList { get; set; }

        public BOSList<PMTasksInfo> TaskList { get; set; }

        public IList<PMProjectNormItemsInfo> SelectedObjects { get; set; }

        public PMProjectNormsInfo ProjectNormsInfoCurrent { get; set; }


        #endregion

        public guiProjectNormItem(PMProjectNormsInfo projectNormsInfoCurrent, List<PMProjectNormItemsInfo> projectNormItems, List<PMTasksInfo> tasks)
        {
            InitializeComponent();
            ProjectNormItemsList = new BOSList<PMProjectNormItemsInfo>(TableName.PMProjectNormItemsTableName);
            ProjectNormItemsList.Invalidate(projectNormItems);
            ProjectNormsInfoCurrent = projectNormsInfoCurrent;

            ProjectNormItemMaterialList = new BOSList<PMProjectNormItemsInfo>(TableName.PMProjectNormItemsTableName);
            ProjectNormItemMaterialList.Invalidate(projectNormItems.Where(s => s.PMProjectNormItemProductType == ProductWorkItemType.Material.ToString()).ToList());

            ProjectNormItemAssetList = new BOSList<PMProjectNormItemsInfo>(TableName.PMTemplateItemComponentsTableName);
            ProjectNormItemAssetList.Invalidate(projectNormItems.Where(s => s.PMProjectNormItemProductType == ProductWorkItemType.Asset.ToString()).ToList());

            TaskList = new BOSList<PMTasksInfo>(TableName.PMTasksTableName);
            TaskList.Invalidate(tasks);
        }

        private void guiProjectNormItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcProjectNormItemMaterialsGridControl.InvalidateDataSource(ProjectNormItemMaterialList);
            fld_dgcProjectNormItemAssetsGridControl.InvalidateDataSource(ProjectNormItemAssetList);
            fld_dgcPMTasksGridControl.InvalidateDataSource(TaskList);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ProjectNormItemsList.Clear();
            List<PMProjectNormItemsInfo> projectNormItems = ProjectNormItemMaterialList.Union(ProjectNormItemAssetList.ToList()).ToList();
            ProjectNormItemsList.Invalidate(projectNormItems);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnAddProjectNormItemMaterial_Click(object sender, EventArgs e)
        {
            AddItemToProjectNormItemList(ProductWorkItemType.Material.ToString());
        }

        private void fld_btnAddProjectNormItemAsset_Click(object sender, EventArgs e)
        {
            AddItemToProjectNormItemList(ProductWorkItemType.Asset.ToString());
        }

        public void AddItemToProjectNormItemList(string type)
        {
            List<string> productTypes = new List<string>();
            if (type == ProductWorkItemType.Material.ToString())
            {
                productTypes = Enum.GetNames(typeof(ProductType)).Where(s => s != ProductType.Work.ToString()
                                                                                  && s != ProductType.SemiProduct.ToString()
                                                                                  && s != ProductType.Equipment.ToString()
                                                                                  && s != ProductType.VVP.ToString()
                                                                                  && s != ProductType.MMTB.ToString()
                                                                                  && s != ProductType.Car.ToString()).ToList();
            }
            if (type == ProductWorkItemType.Asset.ToString())
            {
                productTypes = Enum.GetNames(typeof(ProductType)).Where(s => s == ProductType.Equipment.ToString()
                                                                                  || s == ProductType.VVP.ToString()
                                                                                  || s == ProductType.MMTB.ToString()
                                                                                  || s == ProductType.Car.ToString()
                                                                                  || s == ProductType.Service.ToString()
                                                                                  ).ToList();
            }

            List<ICProductsInfo> productList = new List<ICProductsInfo>();

            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(p => productTypes.Contains(p.ICProductType)).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                productList.Add(newObj);
            });
            guiAddProjectNormItem<ICProductsInfo> guiAddProjectNormItem = new guiAddProjectNormItem<ICProductsInfo>(productList);
            guiAddProjectNormItem.Module = this.Module;
            guiAddProjectNormItem.ShowDialog();
            if (guiAddProjectNormItem.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddProjectNormItem.SelectedObjects;
            if (results.Count == 0)
                return;

            PMProjectNormItemsInfo projectNormItemsInfo;
            foreach (ICProductsInfo item in results)
            {
                projectNormItemsInfo = new PMProjectNormItemsInfo
                {
                    FK_PMProjectID = ProjectNormsInfoCurrent.FK_PMProjectID,
                    FK_PMProjectNormID = ProjectNormsInfoCurrent.PMProjectNormID,
                    FK_PMTemplateItemComponentID = 0,
                    FK_PMTemplateItemID = 0,
                    FK_ICProductID = item.ICProductID,
                    FK_ICMeasureUnitID = 0,
                    PMProjectNormItemProductNo = item.ICProductNo,
                    PMProjectNormItemProductName = item.ICProductName,
                    PMProjectNormItemProductDesc = item.ICProductDesc,
                    PMProjectNormItemProductType = type,
                    PMProjectNormItemType = TemplateItemWorkType.Purchase.ToString(),
                    PMProjectNormItemQty = 1,
                };
                if (type == ProductWorkItemType.Material.ToString())
                    ProjectNormItemMaterialList.Add(projectNormItemsInfo);
                if (type == ProductWorkItemType.Asset.ToString())
                    ProjectNormItemAssetList.Add(projectNormItemsInfo);
            }

            if (type == ProductWorkItemType.Material.ToString())
                fld_dgcProjectNormItemMaterialsGridControl.InvalidateDataSource(ProjectNormItemMaterialList);
            if (type == ProductWorkItemType.Asset.ToString())
                fld_dgcProjectNormItemAssetsGridControl.InvalidateDataSource(ProjectNormItemAssetList);
        }

        private void fld_dgcProjectNormItemsGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcProjectNormItemMaterialsGridControl.MainView;
                int index = gridView.FocusedRowHandle;
                ProjectNormItemMaterialList.RemoveAt(index);
                fld_dgcProjectNormItemMaterialsGridControl.DataSource = ProjectNormItemMaterialList;
                fld_dgcProjectNormItemMaterialsGridControl.RefreshDataSource();
            }
        }

        private void fld_btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskToTaskList();
        }

        public void AddTaskToTaskList()
        {
            ICTasksController objTasksController = new ICTasksController();
            List<ICTasksInfo> taskList = objTasksController.GetAllTaskList();
            guiAddTask<ICTasksInfo> guiAddTask = new guiAddTask<ICTasksInfo>(taskList, 0);
            guiAddTask.Module = this.Module;
            guiAddTask.ShowDialog();
            if (guiAddTask.DialogResult != DialogResult.OK)
                return;

            IList<ICTasksInfo> results = guiAddTask.SelectedObjects;
            if (results.Count == 0)
                return;

            PMTasksInfo objTasksInfo;
            foreach (ICTasksInfo item in results)
            {
                objTasksInfo = new PMTasksInfo
                {
                    FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID,
                    FK_HRDepartmentID = item.FK_HRDepartmentID,
                    FK_HREmployeeID = item.FK_ICMeasureUnitID,
                    FK_ICTaskID = item.ICTaskID,
                    FK_Object01ID = ProjectNormsInfoCurrent.PMProjectNormID,
                    ObjectType01 = ObjectType.ProjectNorm.ToString(),
                    FK_ObjectID = ProjectNormsInfoCurrent.FK_PMProjectID,
                    ObjectType = ObjectType.Project.ToString(),
                    PMTaskNo = item.ICTaskNo,
                    PMTaskName = item.ICTaskName,
                    PMTaskInfo = item.ICTaskInfo,
                    PMTaskQty = item.ICTaskQty,
                    PMTaskTotalEstimatedDays = item.ICTaskTotalEstimatedDays,
                    PMTaskTotalEstimatedHours = item.ICTaskTotalEstimatedHours,
                    PMTaskTotalActualDays = item.ICTaskTotalActualDays,
                    PMTaskTotalActualHours = item.ICTaskTotalActualHours,
                    PMTaskActualTotalCost = item.ICTaskEstimatedTotalCost,
                    PMTaskEstimatedExtendDays = item.ICTaskEstimatedExtendDays,
                    PMTaskEstimatedExtendHours = item.ICTaskEstimatedExtendHours,
                    PMTaskActualExtendDays = item.ICTaskActualExtendDays,
                    PMTaskActualExtendHours = item.ICTaskActualExtendHours,
                    PMTaskEstimatedStartDate = BOSApp.GetCurrentServerDate(),
                    PMTaskActualStartDate = BOSApp.GetCurrentServerDate(),
                };
                objTasksInfo.PMTaskEstimatedEndDate = objTasksInfo.PMTaskEstimatedStartDate
                                                                        .AddDays(Convert.ToDouble(objTasksInfo.PMTaskTotalEstimatedDays))
                                                                        .AddHours(Convert.ToDouble(objTasksInfo.PMTaskTotalEstimatedHours));
                objTasksInfo.PMTaskActualEndDate = objTasksInfo.PMTaskEstimatedEndDate;
                TaskList.Add(objTasksInfo);
            }

            fld_dgcPMTasksGridControl.InvalidateDataSource(TaskList);
        }

        private void fld_dgcPMTasksGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcPMTasksGridControl.MainView;
                int index = gridView.FocusedRowHandle;
                TaskList.RemoveAt(index);
                fld_dgcPMTasksGridControl.InvalidateDataSource(TaskList);
            }
        }

        private void fld_dgcProjectNormItemAssetsGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcProjectNormItemAssetsGridControl.MainView;
                int index = gridView.FocusedRowHandle;
                ProjectNormItemAssetList.RemoveAt(index);
                fld_dgcProjectNormItemAssetsGridControl.DataSource = ProjectNormItemAssetList;
                fld_dgcProjectNormItemAssetsGridControl.RefreshDataSource();
            }
        }
    }
}