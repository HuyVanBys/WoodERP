using BOSCommon;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Template
{
    public partial class guiTemplateItemComponent<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public List<PMTemplateItemComponentsInfo> TemplateItemComponentList { get; set; }

        public List<PMTemplateItemComponentsInfo> TemplateItemComponentMaterialList { get; set; }

        public List<PMTemplateItemComponentsInfo> TemplateItemComponentAssetList { get; set; }

        public List<PMTemplateItemTasksInfo> TemplateItemTaskList { get; set; }

        public PMTemplateItemsInfo TemplateItemsInfoCurrent { get; set; }
        #endregion

        public guiTemplateItemComponent(PMTemplateItemsInfo templateItemsInfoCurrent,
                                        List<PMTemplateItemComponentsInfo> templateItemComponents,
                                        List<PMTemplateItemTasksInfo> templateItemTasks)
        {
            InitializeComponent();
            TemplateItemsInfoCurrent = templateItemsInfoCurrent;

            TemplateItemComponentMaterialList = new List<PMTemplateItemComponentsInfo>();
            TemplateItemComponentMaterialList = templateItemComponents.Where(o => o.PMTemplateItemComponentType == ProductWorkItemType.Material.ToString()).ToList();

            TemplateItemComponentAssetList = new List<PMTemplateItemComponentsInfo>();
            TemplateItemComponentAssetList = templateItemComponents.Where(o => o.PMTemplateItemComponentType == ProductWorkItemType.Asset.ToString()).ToList();

            TemplateItemTaskList = new List<PMTemplateItemTasksInfo>();
            TemplateItemTaskList = templateItemTasks;
        }

        private void guiAddWork_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcTemplateItemComponentAssetsGridControl.InvalidateDataSource(TemplateItemComponentAssetList);
            fld_dgcTemplateItemComponentMaterialsGridControl.InvalidateDataSource(TemplateItemComponentMaterialList);
            fld_dgcTemplateItemTasksGridControl.InvalidateDataSource(TemplateItemTaskList);
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
            TemplateItemComponentList = new List<PMTemplateItemComponentsInfo>();
            TemplateItemComponentList.AddRange(TemplateItemComponentMaterialList);
            TemplateItemComponentList.AddRange(TemplateItemComponentAssetList);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnAddProductWorkItem_Click(object sender, EventArgs e)
        {
            AddItemToTemplateItemComponentList(ProductWorkItemType.Material.ToString());
        }

        private void fld_btnAddProductWorkItem1_Click(object sender, EventArgs e)
        {
            AddItemToTemplateItemComponentList(ProductWorkItemType.Asset.ToString());
        }

        public void AddItemToTemplateItemComponentList(string type)
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
            guiAddTemplateItemComponent<ICProductsInfo> guiAddTemplateItemComponent = new guiAddTemplateItemComponent<ICProductsInfo>(productList);
            guiAddTemplateItemComponent.Module = this.Module;
            guiAddTemplateItemComponent.ShowDialog();
            if (guiAddTemplateItemComponent.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddTemplateItemComponent.SelectedObjects;
            if (results.Count == 0)
                return;

            PMTemplateItemComponentsInfo objTemplateItemComponentsInfo;
            foreach (ICProductsInfo item in results)
            {
                objTemplateItemComponentsInfo = new PMTemplateItemComponentsInfo();
                objTemplateItemComponentsInfo.FK_PMTemplateID = TemplateItemsInfoCurrent.FK_PMTemplateID;
                objTemplateItemComponentsInfo.FK_PMTemplateItemID = TemplateItemsInfoCurrent.PMTemplateItemID;
                objTemplateItemComponentsInfo.FK_ICProductWorkID = TemplateItemsInfoCurrent.FK_ICProductID;
                objTemplateItemComponentsInfo.FK_ICProductID = item.ICProductID;
                objTemplateItemComponentsInfo.PMTemplateItemComponentProductNo = item.ICProductNo;
                objTemplateItemComponentsInfo.PMTemplateItemComponentProductName = item.ICProductName;
                objTemplateItemComponentsInfo.PMTemplateItemComponentProductDesc = item.ICProductDesc;
                objTemplateItemComponentsInfo.PMTemplateItemComponentType = type;
                objTemplateItemComponentsInfo.PMTemplateItemComponentWorkType = string.IsNullOrEmpty(item.ICProductWorkType) ? TemplateItemWorkType.Purchase.ToString() : item.ICProductWorkType;
                objTemplateItemComponentsInfo.PMTemplateItemComponentQty = TemplateItemsInfoCurrent.PMTemplateItemProductNetWeight;
                objTemplateItemComponentsInfo.PMTemplateItemComponentBasicQty = 1;

                if (type == ProductWorkItemType.Material.ToString())
                    TemplateItemComponentMaterialList.Add(objTemplateItemComponentsInfo);
                if (type == ProductWorkItemType.Asset.ToString())
                    TemplateItemComponentAssetList.Add(objTemplateItemComponentsInfo);
            }
            if (type == ProductWorkItemType.Material.ToString())
                fld_dgcTemplateItemComponentMaterialsGridControl.InvalidateDataSource(TemplateItemComponentMaterialList);

            if (type == ProductWorkItemType.Asset.ToString())
                fld_dgcTemplateItemComponentAssetsGridControl.InvalidateDataSource(TemplateItemComponentAssetList);
        }

        public void AddTaskToProductTaskList()
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

            PMTemplateItemTasksInfo objTemplateItemTasksInfo;
            foreach (ICTasksInfo item in results)
            {
                objTemplateItemTasksInfo = new PMTemplateItemTasksInfo
                {
                    FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID,
                    FK_HRDepartmentID = item.FK_HRDepartmentID,
                    FK_ICMeasureUnitID = item.FK_ICMeasureUnitID,
                    FK_HREmployeeID = item.FK_HREmployeeID,
                    FK_ICProductTaskID = 0,
                    FK_ICTaskID = item.ICTaskID,
                    FK_PMProjectTypeID = 0,
                    FK_PMTemplateID = TemplateItemsInfoCurrent.FK_PMTemplateID,
                    FK_PMTemplateItemID = TemplateItemsInfoCurrent.PMTemplateItemID,
                    PMTemplateItemTaskNo = item.ICTaskNo,
                    PMTemplateItemTaskName = item.ICTaskName,
                    PMTemplateItemTaskInfo = item.ICTaskInfo,
                    PMTemplateItemTaskQty = item.ICTaskQty,
                    PMTemplateItemTaskTotalEstimatedDays = item.ICTaskTotalEstimatedDays,
                    PMTemplateItemTaskTotalEstimatedHours = item.ICTaskTotalEstimatedHours,
                    PMTemplateItemTaskTotalActualDays = item.ICTaskTotalActualDays,
                    PMTemplateItemTaskTotalActualHours = item.ICTaskTotalActualHours,
                    PMTemplateItemTaskTaskActualTotalCost = item.ICTaskEstimatedTotalCost,
                    PMTemplateItemTaskEstimatedExtendDays = item.ICTaskEstimatedExtendDays,
                    PMTemplateItemTaskEstimatedExtendHours = item.ICTaskEstimatedExtendHours,
                    PMTemplateItemTaskActualExtendDays = item.ICTaskActualExtendDays,
                    PMTemplateItemTaskActualExtendHours = item.ICTaskActualExtendHours,
                    PMTemplateItemTaskEstimatedStartDate = BOSApp.GetCurrentServerDate(),
                    PMTemplateItemTaskActualStartDate = BOSApp.GetCurrentServerDate(),
                };
                objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedEndDate = objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedStartDate
                                                                                                      .AddDays(Convert.ToDouble(objTemplateItemTasksInfo.PMTemplateItemTaskTotalEstimatedDays))
                                                                                                      .AddHours(Convert.ToDouble(objTemplateItemTasksInfo.PMTemplateItemTaskTotalEstimatedHours));
                objTemplateItemTasksInfo.PMTemplateItemTaskActualEndDate = objTemplateItemTasksInfo.PMTemplateItemTaskEstimatedEndDate;
                TemplateItemTaskList.Add(objTemplateItemTasksInfo);
            }

            fld_dgcTemplateItemTasksGridControl.InvalidateDataSource(TemplateItemTaskList);
        }

        private void fld_dgcTemplateItemComponentAssetsGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcTemplateItemComponentAssetsGridControl.MainView;
                int index = gridView.FocusedRowHandle;
                if (index < 0)
                    return;

                if (MessageBox.Show(TemplateLocalizedResources.TemplateItemConfrimDeleteMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
                PMTemplateItemComponentsInfo objTemplateItemComponentsInfo = TemplateItemComponentAssetList[index];
                TemplateItemComponentAssetList.RemoveAt(index);
                PMTemplateItemComponentsController objTemplateItemComponentsController = new PMTemplateItemComponentsController();
                objTemplateItemComponentsController.DeleteObject(objTemplateItemComponentsInfo.PMTemplateItemComponentID);
                fld_dgcTemplateItemComponentAssetsGridControl.DataSource = TemplateItemComponentAssetList;
            }
        }

        private void fld_btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskToProductTaskList();
        }

        private void fld_dgcTemplateItemComponentMaterialsGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcTemplateItemComponentMaterialsGridControl.MainView;
                int index = gridView.FocusedRowHandle;
                if (index < 0)
                    return;

                if (MessageBox.Show(TemplateLocalizedResources.TemplateItemConfrimDeleteMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;

                PMTemplateItemComponentsInfo objTemplateItemComponentsInfo = TemplateItemComponentMaterialList[index];
                TemplateItemComponentMaterialList.RemoveAt(index);

                PMTemplateItemComponentsController objTemplateItemComponentsController = new PMTemplateItemComponentsController();
                objTemplateItemComponentsController.DeleteObject(objTemplateItemComponentsInfo.PMTemplateItemComponentID);
                fld_dgcTemplateItemComponentMaterialsGridControl.InvalidateDataSource(TemplateItemComponentMaterialList);
            }
        }

        private void fld_dgcTemplateItemTasksGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcTemplateItemTasksGridControl.MainView;
                int index = gridView.FocusedRowHandle;
                if (index < 0)
                    return;

                if (MessageBox.Show(TemplateLocalizedResources.TemplateItemConfrimDeleteMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;

                PMTemplateItemTasksInfo objTemplateItemTasksInfo = TemplateItemTaskList[index];
                TemplateItemTaskList.RemoveAt(index);

                PMTemplateItemTasksController objTemplateItemTasksController = new PMTemplateItemTasksController();
                objTemplateItemTasksController.DeleteObject(objTemplateItemTasksInfo.PMTemplateItemTaskID);
                fld_dgcTemplateItemTasksGridControl.InvalidateDataSource(TemplateItemTaskList);
            }
        }
    }
}