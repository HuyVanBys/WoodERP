using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;

namespace BOSERP.Modules.Product
{
    public partial class guiProductItemWorkComponent : BOSERPScreen
    {
        #region Variables
        
        public BOSList<ICProductTasksInfo> ProductWorkItemTaskList { get; set; }
        
        public BOSList<ICProductWorkItemsInfo> ProductWorkItemComponentsList { get; set; }

        public IList<ICProductItemsInfo> SelectedObjects { get; set; }

        public ICProductItemsInfo ProductItemsInfoCurrent { get; set; }
        //public IList<PMTemplateItemComponentsInfo> SelectedObjects { get; set; }

        //public PMTemplateItemsInfo TemplateItemsInfoCurrent { get; set; }
        #endregion

        public guiProductItemWorkComponent(ICProductItemsInfo productItemsInfoCurrent,
                                        List<ICProductWorkItemsInfo> productWorkItemComponents,
                                        List<ICProductTasksInfo> productWorkTasks)
        {
            InitializeComponent();
            //TemplateItemsInfoCurrent = templateItemsInfoCurrent;
            ProductItemsInfoCurrent = productItemsInfoCurrent;

            ProductWorkItemTaskList = new BOSList<ICProductTasksInfo>(TableName.ICProductTasksTableName);
            ProductWorkItemTaskList.Invalidate(productWorkTasks);
            //TemplateItemComponentList = new BOSList<PMTemplateItemComponentsInfo>(TableName.PMTemplateItemComponentsTableName);
            //TemplateItemComponentList.Invalidate(templateItemComponents);

            //TemplateItemComponentMaterialList = new BOSList<PMTemplateItemComponentsInfo>(TableName.PMTemplateItemComponentsTableName);
            //TemplateItemComponentMaterialList.Invalidate(templateItemComponents.Where(o => o.PMTemplateItemComponentType == ProductWorkItemType.Material.ToString()).ToList());

            //TemplateItemComponentAssetList = new BOSList<PMTemplateItemComponentsInfo>(TableName.PMTemplateItemComponentsTableName);
            //TemplateItemComponentAssetList.Invalidate(templateItemComponents.Where(o => o.PMTemplateItemComponentType == ProductWorkItemType.Asset.ToString()).ToList());

            //TemplateItemTaskList = new BOSList<PMTemplateItemTasksInfo>(TableName.PMTemplateItemTasksTableName);
            //TemplateItemTaskList.Invalidate(templateItemTasks);
        }

        private void guiAddWork_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            //fld_dgcICProductTaskByProductItemWorkGridControl.Invalidate(ProductWorkItemTaskList);
            //fld_dgcTemplateItemComponentAssetsGridControl.InvalidateDataSource(TemplateItemComponentAssetList);
            //fld_dgcTemplateItemComponentMaterialsGridControl.InvalidateDataSource(TemplateItemComponentMaterialList);
            //fld_dgcTemplateItemTasksGridControl.InvalidateDataSource(TemplateItemTaskList);
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
            //TemplateItemComponentList.Clear();
            //List<PMTemplateItemComponentsInfo> templateItemComponents = TemplateItemComponentMaterialList.Union(TemplateItemComponentAssetList.ToList()).ToList();
            //TemplateItemComponentList.Invalidate(templateItemComponents);
            //this.DialogResult = DialogResult.OK;
            //this.Close();
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

            List<ICProductsInfo> productList = BOSApp.CurrentProductList.Where(p => productTypes.Contains(p.ICProductType)).ToList();
            //guiAddTemplateItemComponent<ICProductsInfo> guiAddTemplateItemComponent = new guiAddTemplateItemComponent<ICProductsInfo>(productList);
            //guiAddTemplateItemComponent.Module = this.Module;
            //guiAddTemplateItemComponent.ShowDialog();
            //if (guiAddTemplateItemComponent.DialogResult != DialogResult.OK)
            //    return;

            //IList<ICProductsInfo> results = guiAddTemplateItemComponent.SelectedObjects;
            //if (results.Count == 0)
            //    return;

            //PMTemplateItemComponentsInfo objTemplateItemComponentsInfo;
            //foreach (ICProductsInfo item in results)
            //{
            //    objTemplateItemComponentsInfo = new PMTemplateItemComponentsInfo();
            //    objTemplateItemComponentsInfo.FK_PMTemplateID = TemplateItemsInfoCurrent.FK_PMTemplateID;
            //    objTemplateItemComponentsInfo.FK_PMTemplateItemID = TemplateItemsInfoCurrent.PMTemplateItemID;
            //    objTemplateItemComponentsInfo.FK_ICProductWorkID = TemplateItemsInfoCurrent.FK_ICProductID;
            //    objTemplateItemComponentsInfo.FK_ICProductID = item.ICProductID;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentProductNo = item.ICProductNo;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentProductName = item.ICProductName;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentProductDesc = item.ICProductDesc;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentType = type;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentWorkType = string.IsNullOrEmpty(item.ICProductWorkType) ? TemplateItemWorkType.Purchase.ToString() : item.ICProductWorkType;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentQty = TemplateItemsInfoCurrent.PMTemplateItemProductNetWeight;
            //    objTemplateItemComponentsInfo.PMTemplateItemComponentBasicQty = 1;

            //    if (type == ProductWorkItemType.Material.ToString())
            //        TemplateItemComponentMaterialList.Add(objTemplateItemComponentsInfo);
            //    if (type == ProductWorkItemType.Asset.ToString())
            //        TemplateItemComponentAssetList.Add(objTemplateItemComponentsInfo);
            //}
            //if (type == ProductWorkItemType.Material.ToString())
            //    fld_dgcTemplateItemComponentMaterialsGridControl.InvalidateDataSource(TemplateItemComponentMaterialList);

            //if (type == ProductWorkItemType.Asset.ToString())
            //    fld_dgcTemplateItemComponentAssetsGridControl.InvalidateDataSource(TemplateItemComponentAssetList);
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

            ICProductTasksInfo objProductTasksInfo;
            foreach (ICTasksInfo item in results)
            {
                objProductTasksInfo = new ICProductTasksInfo();
                objProductTasksInfo.FK_ICTaskID = item.ICTaskID;
                objProductTasksInfo.FK_ICProductID = ProductItemsInfoCurrent.FK_ICProductItemChildID;
                objProductTasksInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                objProductTasksInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                objProductTasksInfo.FK_HREmployeeID = item.FK_HREmployeeID;
                objProductTasksInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
                objProductTasksInfo.ICProductTaskNo = item.ICTaskNo;
                objProductTasksInfo.ICProductTaskName = item.ICTaskName;
                objProductTasksInfo.ICProductTaskInfo = item.ICTaskInfo;
                objProductTasksInfo.ICProductTaskQty = item.ICTaskQty;
                objProductTasksInfo.ICProductTaskTotalActualDays = item.ICTaskTotalActualDays;
                objProductTasksInfo.ICProductTaskTotalActualHours = item.ICTaskTotalActualHours;
                objProductTasksInfo.ICProductTaskTotalEstimatedDays = item.ICTaskTotalEstimatedDays;
                objProductTasksInfo.ICProductTaskTotalEstimatedHours = item.ICTaskTotalEstimatedHours;
                objProductTasksInfo.ICProductTaskActualTotalCost = item.ICTaskActualTotalCost;
                objProductTasksInfo.ICProductTaskEstimatedTotalCost = item.ICTaskEstimatedTotalCost;
                objProductTasksInfo.ICProductTaskParentType = "Product";
                ProductWorkItemTaskList.Add(objProductTasksInfo);
            }

            ProductWorkItemTaskList.GridControl.RefreshDataSource();
            }

            //fld_dgcTemplateItemTasksGridControl.InvalidateDataSource(TemplateItemTaskList);
        }
    
}