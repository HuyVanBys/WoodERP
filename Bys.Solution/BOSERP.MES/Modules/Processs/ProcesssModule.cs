using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.Processs.UI;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.Processs
{
    class ProcesssModule : BaseTransactionModule
    {
        #region Constants
        #endregion Constants

        #region Private Properties
        BOSButton ButtonAddOperation;
        BOSButton ButtonSave;

        #endregion Private Properties
        #region Public methods

        public ProcesssModule()
        {
            Name = "Processs";
            CurrentModuleEntity = new ProcesssEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            ButtonAddOperation = (BOSButton)Controls["fld_btnAdd"];
            ButtonSave = (BOSButton)Controls["fld_btnSave"];
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
            MMProcesssInfo searchObject = (MMProcesssInfo)CurrentModuleEntity.SearchObject;
            MMProcesssController objProcesssController = new MMProcesssController();
            DataSet ds = new DataSet();
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objProcesssController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objProcesssController.GetDataSetOfBranchList(searchObject.MMProcessNo
                                                                     , searchObject.FK_HREmployeeID
                                                                     , searchObject.MMProcessTypeCombo
                                                                     , searchObject.MMProcessStatus
                                                                     , searchObject.ProcessDateFrom
                                                                     , searchObject.ProcessDateTo
                                                                     , BranchList);
                }
            }
            else
            {
                ds = objProcesssController.GetDataSetOfBranch(searchObject.MMProcessNo
                                                             , searchObject.FK_HREmployeeID
                                                             , searchObject.MMProcessTypeCombo
                                                             , searchObject.MMProcessStatus
                                                             , searchObject.ProcessDateFrom
                                                             , searchObject.ProcessDateTo
                                                             , searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override int ActionSave()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            entity.ProductAttributeItemList.EndCurrentEdit();
            if (InvalidIsEndProcessCheck())
            {
                MessageBox.Show(ProcesssLocalizedResources.PleaseChooseTheEndProcess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            int result = base.ActionSave();
            if (result > 0)
                EnableToolbar();
            return result;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            if (ButtonSave != null)
                ButtonSave.Enabled = false;
            EnableToolbar();

        }
        #endregion Public methods       

        public override void ActionNew()
        {
            base.ActionNew();
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)CurrentModuleEntity.MainObject;
            objProcesssInfo.MMProcessStatus = BatchProductPlanStatus.New.ToString();
            objProcesssInfo.MMProcessDate = DateTime.Now;
            objProcesssInfo.MMProcessTypeCombo = ProcessType.MassProduction.ToString();
            objProcesssInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ButtonAddOperation.Enabled = true;
            if (ButtonSave != null)
                ButtonSave.Enabled = false;
        }

        public void DeleteItemFromList()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            entity.ProductAttributeItemList.RemoveSelectedRowObjectFromList();

        }
        public void DeleteItemFromProcessProductList()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            entity.ProcessProductList.RemoveSelectedRowObjectFromList();

        }
        /// <summary>
        /// Approve all items of the BatchProductPlan
        /// </summary>
        public void ApproveProcess()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            entity.ApproveProcess();


            EnableToolbar();
        }
        public void EnableToolbar()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)entity.MainObject;
            string status = objProcesssInfo.MMProcessStatus;
            ButtonAddOperation.Enabled = true;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            if (ButtonSave != null)
                ButtonSave.Enabled = false;
            //New
            if (status == MMProposalItemStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            }
            //Approved
            if (status == MMProposalItemStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ButtonAddOperation.Enabled = false;
                if (ButtonSave != null)
                    ButtonSave.Enabled = true;
            }
            foreach (DevExpress.XtraTab.XtraTabPage tpScreen in this.ParentScreen.ScreenContainer.TabPages)
            {
                if (tpScreen.Name == "DMPCE101")
                {
                    if (objProcesssInfo.MMProcessTypeCombo == ProcessType.Proposal.ToString())
                        tpScreen.Visible = true;
                    else
                        tpScreen.Visible = false;
                }
            }
        }
        public void ChangeItemFromProcessItemList()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            entity.ProductAttributeItemList.ChangeObjectFromList();
        }

        public void ShowItemOperation()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo mainObject = (MMProcesssInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> listItem = objOperationsController.GetAliveOperationAndSortOrder();
            guiFind<MMOperationsInfo> guiOperation = new guiFind<MMOperationsInfo>(TableName.MMOperationsTableName, listItem, this, true, true);
            guiOperation.ShowDialog();
            if (guiOperation.DialogResult == DialogResult.OK)
            {
                List<MMOperationsInfo> listSelectedItem = guiOperation.SelectedObjects.Where(x => x.Selected).ToList();
                if (listSelectedItem != null && listSelectedItem.Count > 0)
                {
                    listSelectedItem.OrderBy(s => s.MMOperationPeriodOrder).ToList().ForEach(p =>
                     {
                         if (!entity.ProductAttributeItemList.Exists("FK_MMOperationID", p.MMOperationID))
                         {
                             ICProductAttributeItemsInfo obj = new ICProductAttributeItemsInfo();
                             obj.FK_MMOperationID = p.MMOperationID;
                             obj.MMOperationNo = p.MMOperationNo;
                             obj.MMOperationName = p.MMOperationName;
                             obj.ICProductAttributeItemIsPlan = p.MMOperationIsPlan;
                             obj.FK_MMOperationSynID = p.FK_MMOperationSynID;
                             obj.ICProductAttributeItemForParentSyncCheck = p.MMOperationForParentSyncCheck;
                             obj.ICProductAttributeItemIsOutSourcing = p.MMOperationIsOutSourcing;
                             obj.ICProductAttributeItemSyncProductCheck = p.MMOperationSyncProductCheck;
                             obj.ICProductAttributeItemInOutStockCheck = p.MMOperationInOutStockCheck;
                             obj.ICProductAttributeItemPeriod = entity.ProductAttributeItemList.Count + 1;
                             obj.FK_MMProcessID = mainObject.MMProcessID;
                             entity.ProductAttributeItemList.Add(obj);
                         }
                     });
                    entity.ProductAttributeItemList.GridControl?.RefreshDataSource();
                }
            }
        }
        public void ShowProcessInfo(ICProductAttributeItemsInfo objProductAttributeItemsInfo)
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)CurrentModuleEntity.MainObject;
            if (objProductAttributeItemsInfo.ICProductAttributeItemID > 0)
            {
                guiProcessInfos guiForm = new guiProcessInfos(objProductAttributeItemsInfo, objProcesssInfo.MMProcessStatus);
                guiForm.Text = "Danh sách chi tiết công việc";
                guiForm.Module = this;
                guiForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng lưu chi tiết trước!"
                    , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowProducts()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo mainObject = (MMProcesssInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> listItem = objProductsController.GetListProductByListProductType();
            using (guiFind<ICProductsInfo> guiProduct = new guiFind<ICProductsInfo>(TableName.ICProductsTableName, listItem, this, true, true))
            {
                guiProduct.ShowDialog();
                if (guiProduct.DialogResult == DialogResult.OK)
                {
                    List<ICProductsInfo> listSelectedItem = guiProduct.SelectedObjects.Where(x => x.Selected).ToList();
                    if (listSelectedItem != null && listSelectedItem.Count > 0)
                    {
                        listSelectedItem.ForEach(p =>
                        {
                            if (!entity.ProcessProductList.Exists("FK_ICProductID", p.ICProductID))
                            {
                                MMProcessProductsInfo obj = new MMProcessProductsInfo();
                                obj.FK_ICProductID = p.ICProductID;
                                obj.MMProcessProductDesc = p.ICProductDesc;
                                obj.FK_MMProcessID = mainObject.MMProcessID;
                                entity.ProcessProductList.Add(obj);
                            }
                        });
                        entity.ProcessProductList.GridControl?.RefreshDataSource();
                    }
                }
            }
        }

        public void SaveProcessProduct()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo mainObject = (MMProcesssInfo)entity.MainObject;
            if (mainObject.MMProcessID > 0)
            {
                entity.SaveProcessProduct();
                MessageBox.Show(MESLocalizedResources.SaveSuccessful, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ChangeProcessType(string type)
        {

            foreach (DevExpress.XtraTab.XtraTabPage tpScreen in this.ParentScreen.ScreenContainer.TabPages)
            {
                if (tpScreen.Name == "DMPCE101")
                {
                    if (type == ProcessType.Proposal.ToString())
                        tpScreen.Visible = true;
                    else
                        tpScreen.Visible = false;
                }
            }

        }

        public bool InvalidIsEndProcessCheck()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            int count = entity.ProductAttributeItemList.Count(p => p.ICProductAttributeItemIsEndProcess == true);
            if (count != 1)
                return true;
            return false;
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            MMProcesssInfo mainObject = (MMProcesssInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (mainObject.MMProcessID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (mainObject.MMProcessStatus == MMProposalItemStatus.Approved.ToString())
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
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo mainObject = (MMProcesssInfo)entity.MainObject;
            if (mainObject.MMProcessID > 0)
            {
                if (!CheckRelative())
                    return false;
                mainObject.MMProcessStatus = BatchProductPlanStatus.New.ToString();
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
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo mainObject = (MMProcesssInfo)entity.MainObject;
            if (mainObject.MMProcessID > 0)
            {
                if (!CheckRelative())
                    return;
                base.ActionDelete();
            }
        }
        #endregion
        public bool CheckRelative()
        {
            ProcesssEntities entity = (ProcesssEntities)CurrentModuleEntity;
            MMProcesssInfo mainObject = (MMProcesssInfo)entity.MainObject;
            MMProcesssController objProcesssController = new MMProcesssController();
            List<MMProcesssInfo> listRelativeProcess = objProcesssController.GetAllRelativeByProcessID(mainObject.MMProcessID);
            if (listRelativeProcess != null && listRelativeProcess.Count > 0)
            {
                BOSApp.ShowMessage(string.Format("Không thể thực hiện do đã tạo BOM và LSX từ QTSX này:"));
                return false;
            }
            return true;
        }
    }
}
