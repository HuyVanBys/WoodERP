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

namespace BOSERP.Modules.KPIEvaluation
{
    public class KPIEvaluationModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeSearchFK_BRBranchID";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        #endregion

        #region Constructor
        public KPIEvaluationModule()
        {
            Name = ModuleName.KPIEvaluation;
            CurrentModuleEntity = new KPIEvaluationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[KPIEvaluationModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            StartGettingInventoryThread();
        }
        #endregion

        #region GetSearchData
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRKPIEvaluationsInfo searchObject = (HRKPIEvaluationsInfo)CurrentModuleEntity.SearchObject;
            HRKPIEvaluationsController objKPIEvaluationsController = new HRKPIEvaluationsController();

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objKPIEvaluationsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objKPIEvaluationsController.GetKPIEvaluationListDatasetByListOfBranchID(
                                                                searchObject.HRKPIEvaluationNo,
                                                                searchObject.FK_HREmployeeID2,
                                                                searchObject.FK_HRDepartmentID,
                                                                searchObject.FK_HRDepartmentRoomID,
                                                                searchObject.KPIEvaluationFromDate,
                                                                searchObject.KPIEvaluationToDate,
                                                                BranchList);
                }
            }
            else
            {
                ds = objKPIEvaluationsController.GetKPIEvaluationListDataset(
                                                                searchObject.HRKPIEvaluationNo,
                                                                searchObject.FK_HREmployeeID2,
                                                                searchObject.FK_HRDepartmentID,
                                                                searchObject.FK_HRDepartmentRoomID,
                                                                searchObject.KPIEvaluationFromDate,
                                                                searchObject.KPIEvaluationToDate,
                                                                searchObject.FK_BRBranchID);
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

        #region ActionNew, ActionSave
        public override void ActionNew()
        {
            base.ActionNew();
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)CurrentModuleEntity.MainObject;

            HRKPIRegistrationsController objKPIRegistsController = new HRKPIRegistrationsController();
            List<HRKPIRegistrationsInfo> KPIRegistsList = (List<HRKPIRegistrationsInfo>)objKPIRegistsController.GetKPIRegistrationListNotExistKPIEvaluations();

            guiFind<HRKPIRegistrationsInfo> guiAddItemToKPIRegists = new guiFind<HRKPIRegistrationsInfo>(TableName.HRKPIRegistrationsTableName, KPIRegistsList, this, false);
            guiAddItemToKPIRegists.Module = this;
            guiAddItemToKPIRegists.ShowDialog();
            if (guiAddItemToKPIRegists.DialogResult != DialogResult.OK)
            {
                base.ActionCancel();
            }

            IList<HRKPIRegistrationsInfo> results = guiAddItemToKPIRegists.SelectedObjects;
            if (results.Count == 0)
                return;

            foreach (HRKPIRegistrationsInfo item in results)
            {
                objKPIEvaluationsInfo.FK_HRKPIRegistrationID = item.HRKPIRegistrationID;
                objKPIEvaluationsInfo.HRKPIEvaluationTotalAmountBonus = item.HRKPIRegistrationTotalAmountBonus;
                objKPIEvaluationsInfo.HRKPIEvaluationStartDate = item.HRKPIRegistrationStartDate;
                objKPIEvaluationsInfo.HRKPIEvaluationFinishedDate = item.HRKPIRegistrationFinishedDate;
                objKPIEvaluationsInfo.HRKPIEvaluationName = item.HRKPIRegistrationName;
                if (objKPIEvaluationsInfo.HRKPIEvaluationFinishedDate.Date > BOSApp.GetCurrentServerDate().Date)
                {
                    MessageBox.Show("Hiện tại chưa thể đánh giá cho Áp dụng KPI: " + item.HRKPIRegistrationNo, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    base.ActionCancel();
                }
                entity.GenerateEntityFromKPIRegistration(item);
            }
            entity.UpdateMainObjectBindingSource();
            entity.EmployeeKPIEvaluationItemsList.ForEach(o =>
                {
                    ChangeItemResultAuto(o);
                });
            UpdateTotalWeightBonus();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)CurrentModuleEntity.MainObject;
            HREmployeeKPIEvaluationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIEvaluationItemsTableName] as HREmployeeKPIEvaluationItemsInfo;
            if (employee != null)
            {
                List<HRKPIEvaluationItemsInfo> list = new List<HRKPIEvaluationItemsInfo>();
                list = entity.KPIEvaluationItemsList.Where(o => o.FK_HREmployeeKPIEvaluationItemID == employee.HREmployeeKPIEvaluationItemID).ToList();
                if (employee.HRKPIEvaluationItemsList == null)
                {
                    employee.HRKPIEvaluationItemsList = new BOSList<HRKPIEvaluationItemsInfo>();
                    employee.HRKPIEvaluationItemsList.InitBOSList(entity,
                                        TableName.HRKPIEvaluationsTableName,
                                        TableName.HRKPIEvaluationItemsTableName,
                                        BOSList<HRKPIEvaluationItemsInfo>.cstRelationForeign);
                    employee.HRKPIEvaluationItemsList.Invalidate(list);
                    entity.KPIEvaluationItemsList.Invalidate(employee.HRKPIEvaluationItemsList);
                }
            }
            entity.KPIEvaluationItemsList.GridControl.RefreshDataSource();
            entity.EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
        }

        public override int ActionSave()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)CurrentModuleEntity.MainObject;
            entity.KPIEvaluationItemsList.EndCurrentEdit();
            if (objKPIEvaluationsInfo.HRKPIEvaluationFinishedDate == null || objKPIEvaluationsInfo.HRKPIEvaluationFinishedDate == DateTime.MaxValue || objKPIEvaluationsInfo.HRKPIEvaluationFinishedDate == DateTime.MinValue)
            {
                MessageBox.Show(KPIEvaluationLocalizedResources.NotNullFinishedDate, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (objKPIEvaluationsInfo.HRKPIEvaluationID > 0)
            {
                HRPayRollsController objPayRollsController = new HRPayRollsController();
                bool check = objPayRollsController.IsApprovedExistKPIEvaliation(objKPIEvaluationsInfo.HRKPIEvaluationID);
                if (check)
                {
                    MessageBox.Show("Bảng lương đã hoàn tất, không thể cập nhật chứng từ. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InvalidateToolbar();
                    return 0;
                }
            }

            int result = base.ActionSave();

            if (objKPIEvaluationsInfo.FK_HRKPIRegistrationID > 0)
            {
                HRKPIRegistrationsController objKPIRegistrationsController = new HRKPIRegistrationsController();
                HRKPIRegistrationsInfo objKPIRegistrationsInfo = new HRKPIRegistrationsInfo();
                objKPIRegistrationsInfo = (HRKPIRegistrationsInfo)objKPIRegistrationsController.GetObjectByID(objKPIEvaluationsInfo.FK_HRKPIRegistrationID);
                if (objKPIRegistrationsInfo != null)
                {
                    objKPIRegistrationsInfo.HRKPIRegistrationStatus = KPIRegistrationStatus.Evaluated.ToString();
                }
                objKPIRegistrationsController.UpdateObject(objKPIRegistrationsInfo);
            }

            return result;
        }

        public void ApproveKPIEvaluation()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            if (MessageBox.Show("Bạn có muốn duyệt chứng từ không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                entity.SetPropertyChangeEventLock(false);
                HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)CurrentModuleEntity.MainObject;
                objKPIEvaluationsInfo.HRKPIEvaluationStatus = KPIEvaluationStatus.Approved.ToString();
                entity.UpdateMainObject();

                InvalidateToolbar();
            }
            else
            {
                return;
            }
        }
        #endregion 

        #region Invalidate Toolbar
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            if (objKPIEvaluationsInfo.HRKPIEvaluationID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                if (objKPIEvaluationsInfo.HRKPIEvaluationStatus == KPIEvaluationStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    HRPayRollsController objPayRollsController = new HRPayRollsController();
                    bool result = objPayRollsController.IsApprovedExistKPIEvaliation(objKPIEvaluationsInfo.HRKPIEvaluationID);
                    if (result)
                    {
                        ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
                    }
                    else
                    {
                        ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", true);
                    }
                }
            }
        }
        #endregion 

        #region Methods
        public void DeleteItemFromKPIEvaluationItemsList()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            entity.KPIEvaluationItemsList.RemoveSelectedRowObjectFromList();
        }
        #endregion

        #region Change
        public void ChangeItemWeightBouns()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            //entity.UpdateTotalAmountKPI();
            ChangeItemPercentComplete();
        }

        public void ChangeItemPercentComplete()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            if (entity.KPIEvaluationItemsList.CurrentIndex < 0)
                return;
            HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo = entity.KPIEvaluationItemsList[entity.KPIEvaluationItemsList.CurrentIndex];
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemAmount = objKPIEvaluationItemsInfo.HRKPIEvaluationItemWeightBouns * objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete / 100;
            //entity.UpdateTotalAmountKPI();
            //HREmployeeKPIEvaluationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIEvaluationItemsTableName] as HREmployeeKPIEvaluationItemsInfo;
            HREmployeeKPIEvaluationItemsInfo employee = (HREmployeeKPIEvaluationItemsInfo)entity.EmployeeKPIEvaluationItemsList[entity.EmployeeKPIEvaluationItemsList.CurrentIndex];
            if (employee != null && employee.HRKPIEvaluationItemsList != null)
            {
                employee.HRKPIEvaluationItemsList.Invalidate(entity.KPIEvaluationItemsList);
            }
            UpdateTotalAmount();
            entity.KPIEvaluationItemsList.GridControl.RefreshDataSource();
            entity.EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeItemResult()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            if (entity.KPIEvaluationItemsList.CurrentIndex < 0)
                return;
            HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo = entity.KPIEvaluationItemsList[entity.KPIEvaluationItemsList.CurrentIndex];
            HREmployeeKPIEvaluationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIEvaluationItemsTableName] as HREmployeeKPIEvaluationItemsInfo;
            if (objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget > 0)
            {
                if (objKPIEvaluationItemsInfo.IsReverseTarget)
                {
                    if (objKPIEvaluationItemsInfo.HRKPIEvaluationItemResult > objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget)
                    {
                        objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = 0;
                    }
                    else
                    {
                        objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = (objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget - objKPIEvaluationItemsInfo.HRKPIEvaluationItemResult) / objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget * 100;
                    }
                }
                else
                {
                    objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = objKPIEvaluationItemsInfo.HRKPIEvaluationItemResult / objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget * 100;
                    if (objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete > 100)
                    {
                        if (employee != null && !employee.IsExcessReward)
                        {
                            objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = 100;
                        }
                    }
                }
            }
            else
            {
                objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = 0;
            }
            ChangeItemPercentComplete();
        }

        public void ChangeItemResultAuto(HREmployeeKPIEvaluationItemsInfo employee)
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            if (employee != null && employee.HRKPIEvaluationItemsList != null)
            {
                foreach (HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo in employee.HRKPIEvaluationItemsList)
                {
                    if (objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget > 0)
                    {
                        if (objKPIEvaluationItemsInfo.IsReverseTarget)
                        {
                            if (objKPIEvaluationItemsInfo.HRKPIEvaluationItemResult > objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget)
                            {
                                objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = 0;
                            }
                            else
                            {
                                objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = (objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget - objKPIEvaluationItemsInfo.HRKPIEvaluationItemResult) / objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget * 100;
                            }
                        }
                        else
                        {
                            objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = objKPIEvaluationItemsInfo.HRKPIEvaluationItemResult / objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget * 100;
                            if (objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete > 100)
                            {
                                if (employee != null && !employee.IsExcessReward)
                                {
                                    objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = 100;
                                }
                            }
                        }
                    }
                    else
                    {
                        objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete = 0;
                    }
                    objKPIEvaluationItemsInfo.HRKPIEvaluationItemAmount = objKPIEvaluationItemsInfo.HRKPIEvaluationItemWeightBouns * objKPIEvaluationItemsInfo.HRKPIEvaluationItemPercentComplete / 100;
                }
            }
            UpdateTotalAmount();
            entity.KPIEvaluationItemsList.GridControl.RefreshDataSource();
            entity.EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
        }

        public void InitDataViewScreen()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            HREmployeeKPIEvaluationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIEvaluationItemsTableName] as HREmployeeKPIEvaluationItemsInfo;
            if (employee != null && employee.HRKPIEvaluationItemsList != null)
            {
                entity.KPIEvaluationItemsList.Invalidate(employee.HRKPIEvaluationItemsList);
            }
            entity.KPIEvaluationItemsList.GridControl.RefreshDataSource();
        }

        public void UpdateTotalAmount()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            if (entity.EmployeeKPIEvaluationItemsList.Count() > 0)
            {
                List<HRKPIEvaluationItemsInfo> list = new List<HRKPIEvaluationItemsInfo>();
                entity.EmployeeKPIEvaluationItemsList.ForEach(o =>
                {
                    if (o.HRKPIEvaluationItemsList != null && o.HRKPIEvaluationItemsList.Count() > 0)
                    {
                        list = (List<HRKPIEvaluationItemsInfo>)o.HRKPIEvaluationItemsList.ToList();
                        o.HREmployeeKPIEvaluationItemTotalAmount = (decimal)list.Sum(x => x.HRKPIEvaluationItemAmount);
                    }
                });
            }

            //CurrentModuleEntity.UpdateModuleObjectBindingSource(TableName.HREmployeeKPIEvaluationItemsTableName);
            UpdateTotalWeightBonus();
            entity.EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
        }

        public void UpdateTotalWeightBonus()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            if (entity.EmployeeKPIEvaluationItemsList.Count() > 0)
            {
                List<HRKPIEvaluationItemsInfo> list = new List<HRKPIEvaluationItemsInfo>();
                entity.EmployeeKPIEvaluationItemsList.ForEach(o =>
                {
                    if (o.HRKPIEvaluationItemsList != null)
                    {
                        list = (List<HRKPIEvaluationItemsInfo>)o.HRKPIEvaluationItemsList.ToList();
                        list.ForEach(x =>
                        {
                            if (!entity.KPIEvaluationItemTargetsList.Exists("FK_HRKPIID", x.FK_HRKPIID))
                            {
                                HRKPIEvaluationItemTargetsInfo KPIEvaluationItemTargetsInfo = new HRKPIEvaluationItemTargetsInfo();
                                KPIEvaluationItemTargetsInfo.FK_HRKPIID = x.FK_HRKPIID;
                                KPIEvaluationItemTargetsInfo.HRKPIEvaluationItemTargetName = x.HRKPIEvaluationItemName;
                                entity.KPIEvaluationItemTargetsList.Add(KPIEvaluationItemTargetsInfo);
                            }
                        });
                    }
                });
                entity.KPIEvaluationItemTargetsList.ForEach(o =>
                {
                    o.HRKPIEvaluationItemTargetTotalAmount = 0;
                    o.HRKPIEvaluationItemTargetToTalWeightBonus = 0;
                    o.HRKPIEvaluationItemTargetTotalResult = 0;
                    o.HRKPIEvaluationItemTargetTotalTarget = 0;
                    entity.EmployeeKPIEvaluationItemsList.ForEach(y =>
                    {
                        if (y.HRKPIEvaluationItemsList != null)
                        {
                            list = (List<HRKPIEvaluationItemsInfo>)y.HRKPIEvaluationItemsList.ToList();
                            o.HRKPIEvaluationItemTargetToTalWeightBonus += (decimal)list.Where(x => x.FK_HRKPIID == o.FK_HRKPIID).Sum(x => x.HRKPIEvaluationItemWeightBouns);
                            o.HRKPIEvaluationItemTargetTotalAmount += (decimal)list.Where(x => x.FK_HRKPIID == o.FK_HRKPIID).Sum(x => x.HRKPIEvaluationItemAmount);
                            o.HRKPIEvaluationItemTargetTotalTarget += (decimal)list.Where(x => x.FK_HRKPIID == o.FK_HRKPIID).Sum(x => x.HRKPIEvaluationItemTarget);
                            o.HRKPIEvaluationItemTargetTotalResult += (decimal)list.Where(x => x.FK_HRKPIID == o.FK_HRKPIID).Sum(x => x.HRKPIEvaluationItemResult);
                        }
                    });
                });
            }
            entity.KPIEvaluationItemTargetsList.GridControl.RefreshDataSource();
        }

        public void ActionEditAfterComplete()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)CurrentModuleEntity;
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)CurrentModuleEntity.MainObject;
            if (objKPIEvaluationsInfo.HRKPIEvaluationID > 0)
            {
                HRPayRollsController objPayRollsController = new HRPayRollsController();
                bool result = objPayRollsController.IsApprovedExistKPIEvaliation(objKPIEvaluationsInfo.HRKPIEvaluationID);
                if (result)
                {
                    MessageBox.Show("Chứng từ không thể sửa sau hoàn tất. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InvalidateToolbar();
                    return;
                }
                else
                {
                    ActionEdit();
                    ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
                    objKPIEvaluationsInfo.HRKPIEvaluationStatus = KPIEvaluationStatus.New.ToString();
                    entity.UpdateMainObjectBindingSource();
                }
            }
        }
        #endregion
    }
}
