using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIForm
{
    public class KPIFormModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeSearchFK_BRBranchID";
        public const string BranchName = "fld_lkeFK_BRBranchID2";
        public const string ShowKPIButtonName = "fld_btnShowKPI";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        BOSLookupEdit DepartmentRoomLookupEditControl;
        BOSLookupEdit DepartmentLookupEditControl;
        BOSLookupEdit BranchLookupEditControl;
        BOSButton ChooseKPIFormButton;
        BOSButton ShowKPIButton;
        #endregion

        #region Constructor
        public KPIFormModule()
        {
            Name = ModuleName.KPIForm;
            CurrentModuleEntity = new KPIFormEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[KPIFormModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            BranchLookupEditControl = (BOSLookupEdit)Controls[BranchName];
            ShowKPIButton = (BOSButton)Controls[ShowKPIButtonName];

            StartGettingInventoryThread();
        }
        #endregion

        #region GetSearchData
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRKPIFormsInfo searchObject = (HRKPIFormsInfo)CurrentModuleEntity.SearchObject;
            HRKPIFormsController objHRKPIFormsController = new HRKPIFormsController();

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objHRKPIFormsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objHRKPIFormsController.GetKPIFormListDatasetByListOfBranchID(
                                                                searchObject.HRKPIFormNo,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.KPIFormFromDate,
                                                                searchObject.KPIFormToDate,
                                                                BranchList,
                                                                searchObject.FK_BRBranchID2);
                }
            }
            else
            {
                ds = objHRKPIFormsController.GetKPIFormListDataset(
                                                                searchObject.HRKPIFormNo,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.KPIFormFromDate,
                                                                searchObject.KPIFormToDate,
                                                                searchObject.FK_BRBranchID,
                                                                searchObject.FK_BRBranchID2);
            }

            return ds;
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
        #endregion

        #region Invalidate Toolbar
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;
            HRKPIRegistrationItemsController objKPIRegistrationItemsController = new HRKPIRegistrationItemsController();
            HRKPIFormItemsController objKPIFormItemsController = new HRKPIFormItemsController();
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
            ParentScreen.SetEnableOfToolbarButton("CancelApply", false);
            if (objKPIFormsInfo.HRKPIFormID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                if (objKPIFormsInfo.HRKPIFormStatus == KPIFormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelApply", true);
                }
                HRKPIRegistrationItemsInfo objKPIRegistrationItemsInfo = (HRKPIRegistrationItemsInfo)objKPIRegistrationItemsController.GetFirstObjectByForeignColumn("FK_HRKPIFormID", objKPIFormsInfo.HRKPIFormID);
                if (objKPIRegistrationItemsInfo != null)
                {
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                }
                if (objKPIFormsInfo.HRKPIFormStatus == KPIFormStatus.CancelApply.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelApply", false);
                }
            }
        }
        #endregion 

        #region ActionSave, Approve
        public override int ActionSave()
        {
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;
            entity.KPIFormItemsList.EndCurrentEdit();

            if (String.IsNullOrEmpty(objKPIFormsInfo.HRKPIFormName))
            {
                MessageBox.Show("Vui lòng nhập tên chứng từ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            decimal totalWeight = entity.KPIFormItemsList.Sum(o => o.HRKPIFormItemWeight);
            if (totalWeight != 100)
            {
                MessageBox.Show(KPIFormLocalizedResources.WarningWeight, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return base.ActionSave();
        }

        public void ApproveKPIFrom()
        {
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;
            objKPIFormsInfo.HRKPIFormStatus = KPIFormStatus.Approved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public void UnApprove()
        {
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;
            objKPIFormsInfo.HRKPIFormStatus = KPIFormStatus.New.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        #endregion

        #region Methods
        public void DeleteItemFromKPIFormItemsList()
        {
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            entity.KPIFormItemsList.RemoveSelectedRowObjectFromList();
        }

        public void AddItemToKPIForms()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;

            HRKPIsController objKPIsController = new HRKPIsController();
            List<HRKPIsInfo> KPIsList = (List<HRKPIsInfo>)objKPIsController.GetListFromDataSet(objKPIsController.GetAllObjects());

            guiFindKPI guiAddItemToKPIItems = new guiFindKPI(entity.KPIFormItemsList);
            guiAddItemToKPIItems.Module = this;
            guiAddItemToKPIItems.ShowDialog();
            if (guiAddItemToKPIItems.DialogResult != DialogResult.OK)
                return;

            IList<HRKPIsInfo> results = guiAddItemToKPIItems.SelectedObjects;
            if (results.Count == 0)
                return;

            //guiFind<HRKPIsInfo> guiAddItemToKPIForms = new guiFind<HRKPIsInfo>("HRKPIs", KPIsList, this, true);
            //guiAddItemToKPIForms.Module = this;
            //guiAddItemToKPIForms.ShowDialog();
            //if (guiAddItemToKPIForms.DialogResult != DialogResult.OK)
            //    return;

            //IList<HRKPIsInfo> results = guiAddItemToKPIForms.SelectedObjects;
            //if (results.Count == 0)
            //    return;

            foreach (HRKPIsInfo item in results)
            {
                HRKPIFormItemsInfo objKPIFormItemsInfo = new HRKPIFormItemsInfo();
                objKPIFormItemsInfo.FK_HRKPIID = item.HRKPIID;
                objKPIFormItemsInfo.HRKPIFormItemName = item.HRKPIName;
                objKPIFormItemsInfo.HRKPIFormItemNo = item.HRKPINo;
                objKPIFormItemsInfo.HRKPIFormItemMeasurementMethod = item.HRKPIMeasurementMethod;
                objKPIFormItemsInfo.HRKPIFormItemTarget = item.HRKPITarget;
                objKPIFormItemsInfo.IsReverseTarget = item.IsReverseTarget;
                objKPIFormItemsInfo.HRKPIFormItemGuide = item.HRKPIGuide;
                entity.KPIFormItemsList.Add(objKPIFormItemsInfo);
            }
            entity.KPIFormItemsList.GridControl.RefreshDataSource();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }
        #endregion

        public void ChangeItemWeight()
        {
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;
            if (entity.KPIFormItemsList.Count() > 0)
            {
                objKPIFormsInfo.HRKPIFormTotalWeight = entity.KPIFormItemsList.Sum(o => o.HRKPIFormItemWeight);
                entity.UpdateMainObjectBindingSource();
            }
        }

        public void ActionCancelApply()
        {
            KPIFormEntities entity = (KPIFormEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            HRKPIFormsInfo objKPIFormsInfo = (HRKPIFormsInfo)CurrentModuleEntity.MainObject;
            objKPIFormsInfo.HRKPIFormStatus = KPIFormStatus.CancelApply.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
    }
}
