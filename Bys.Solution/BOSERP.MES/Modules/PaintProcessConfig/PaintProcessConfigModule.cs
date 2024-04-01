using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.PaintProcessConfig.UI;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.PaintProcessConfig
{
    class PaintProcessConfigModule : BaseTransactionModule
    {
        #region Constants
        #endregion Constants

        #region Private Properties
        BOSButton ButtonAddOperation;
        BOSButton ButtonSave;

        #endregion Private Properties
        #region Public methods

        public PaintProcessConfigModule()
        {
            Name = "PaintProcessConfig";
            CurrentModuleEntity = new PaintProcessConfigEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            InvalidateToolbar();
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
            MMPaintProcessConfigsInfo searchObject = (MMPaintProcessConfigsInfo)CurrentModuleEntity.SearchObject;
            MMPaintProcessConfigsController objProcesssController = new MMPaintProcessConfigsController();
            DataSet ds = new DataSet();
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objProcesssController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objProcesssController.GetDataSetOfBranchList(searchObject.MMPaintProcessConfigNo
                                                                     , searchObject.FK_HREmployeeID
                                                                     , searchObject.MMPaintProcessConfigStatus
                                                                     , searchObject.MMPaintProcessConfigDateFrom
                                                                     , searchObject.MMPaintProcessConfigDateTo
                                                                     , BranchList);
                }
            }
            else
            {
                ds = objProcesssController.GetDataSetOfBranch(searchObject.MMPaintProcessConfigNo
                                                             , searchObject.FK_HREmployeeID
                                                             , searchObject.MMPaintProcessConfigStatus
                                                             , searchObject.MMPaintProcessConfigDateFrom
                                                             , searchObject.MMPaintProcessConfigDateTo
                                                             , searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override int ActionSave()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            entity.PaintProcessConfigItemsList.EndCurrentEdit();
            int result = base.ActionSave();
            return result;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }
        #endregion Public methods       

        public override void ActionNew()
        {
            base.ActionNew();
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            MMPaintProcessConfigsInfo objProcesssInfo = (MMPaintProcessConfigsInfo)CurrentModuleEntity.MainObject;
            objProcesssInfo.MMPaintProcessConfigStatus = BatchProductPlanStatus.New.ToString();
            objProcesssInfo.MMPaintProcessConfigDate = DateTime.Now;
            objProcesssInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
        }

        public void DeleteItemFromList()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            entity.PaintProcessConfigItemsList.RemoveSelectedRowObjectFromList();

        }
        /// <summary>
        /// Approve all items of the BatchProductPlan
        /// </summary>
        public void ApprovePaintProcessConfig()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            entity.ApproveProcess();


            InvalidateToolbar();
        }
        public void ChangeItemFromProcessItemList()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            entity.PaintProcessConfigItemsList.ChangeObjectFromList();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            MMPaintProcessConfigsInfo mainObject = (MMPaintProcessConfigsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (mainObject.MMPaintProcessConfigID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (mainObject.MMPaintProcessConfigStatus == MMProposalItemStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
            if (!Toolbar.IsNullOrNoneAction())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            }
        }
        #region Mở chứng từ
        public override bool ActionCancelComplete()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            MMPaintProcessConfigsInfo mainObject = (MMPaintProcessConfigsInfo)entity.MainObject;
            if (mainObject.MMPaintProcessConfigID > 0)
            {
                mainObject.MMPaintProcessConfigStatus = BatchProductPlanStatus.New.ToString();
                entity.SaveMainObject();
                base.ActionCancelComplete();
                InvalidateToolbar();
            }
            return true;
        }
        #endregion

        #region Xóa chứng từ
        public override void ActionDelete()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)CurrentModuleEntity;
            MMPaintProcessConfigsInfo mainObject = (MMPaintProcessConfigsInfo)entity.MainObject;
            if (mainObject.MMPaintProcessConfigID > 0)
            {
                base.ActionDelete();
            }
        }
        #endregion
        public string ShowSelectPaintProcessesData()
        {
            string rerult = string.Empty;
            List<MMPaintProcessessInfo> paintList = GetPaintProcessessDatasource(string.Empty);
            guiChooseColor<MMPaintProcessessInfo> gui = new guiChooseColor<MMPaintProcessessInfo>("MMPaintProcessess", paintList, this);
            gui.ColumnArr = new string[] { "MMPaintProcessesNo", "MMPaintProcessesPaintName" };
            gui.Module = this;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                List<MMPaintProcessessInfo> selectedList = (List<MMPaintProcessessInfo>)gui.SelectedObjects;
                rerult = string.Join(",", selectedList.Select(o => o.MMPaintProcessesID.ToString()));
            }
            return rerult;
        }
        public string ShowSelectColorData()
        {
            string rerult = string.Empty;
            List<ICProductsForViewInfo> paintList = GetProductCorlorDatasource(ProductType.IngredientPaint.ToString());
            guiChooseColor<ICProductsForViewInfo> gui = new guiChooseColor<ICProductsForViewInfo>("ICProducts", paintList, this);
            gui.ColumnArr = new string[] { "ICProductNo", "ICProductName", "ICProductNoOfOldSys", "ICProductDesc" };
            gui.Module = this;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                List<ICProductsForViewInfo> selectedList = (List<ICProductsForViewInfo>)gui.SelectedObjects;
                rerult = string.Join(",", selectedList.Select(o => o.ICProductID.ToString()));
            }
            return rerult;
        }
        public List<MMPaintProcessessInfo> GetPaintProcessessDatasource(string type)
        {
            List<MMPaintProcessessInfo> paintList = new List<MMPaintProcessessInfo>();
            MMPaintProcessessController objMMPaintProcessessController = new MMPaintProcessessController();
            paintList = objMMPaintProcessessController.GetPaintProcessesByType(string.Empty);
            return paintList;
        }
        public List<ICProductsForViewInfo> GetProductCorlorDatasource(string type)
        {
            List<ICProductsForViewInfo> paintList = new List<ICProductsForViewInfo>();
            ICProductsController objICProductsController = new ICProductsController();
            paintList = BOSApp.CurrentProductList.Where(p => p.ICProductType == type).ToList();
            return paintList;
        }
    }
}
