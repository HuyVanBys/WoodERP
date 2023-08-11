using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.HR.KPIRegistration.Localization;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIRegistration
{
    public class KPIRegistrationModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeSearchFK_BRBranchID";
        public const string DepartmentRoomLookupEditControlName = "fld_lkeFK_HRDepartmentRoomID";
        public const string DepartmentName = "fld_lkeFK_HRDepartmentID";
        public const string EmployeeName = "fld_lkeFK_HREmployeeID2";
        public const string HRKPIFormName = "fld_lkeFK_HRKPIFormID";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSLookupEdit DepartmentRoomLookupEditControl;
        public BOSLookupEdit DepartmentLookupEditControl;
        public BOSLookupEdit EmployeeLookupEditControl;
        public BOSLookupEdit HRKPIFormNameLookupEditControl;
        #endregion

        #region Constructor
        public KPIRegistrationModule()
        {
            Name = ModuleName.KPIRegistration;
            CurrentModuleEntity = new KPIRegistrationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[KPIRegistrationModule.SearchBranchLookupEditControlName];
            //SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            DepartmentRoomLookupEditControl = (BOSLookupEdit)Controls[DepartmentRoomLookupEditControlName];
            DepartmentLookupEditControl = (BOSLookupEdit)Controls[DepartmentName];
            EmployeeLookupEditControl = (BOSLookupEdit)Controls[EmployeeName];

            HRKPIFormNameLookupEditControl = (BOSLookupEdit)Controls[HRKPIFormName];
            HRKPIFormsController objKPIFormsController = new HRKPIFormsController();
            List<HRKPIFormsInfo> KPIFormsList = (List<HRKPIFormsInfo>)objKPIFormsController.GetKPIFormList();
            HRKPIFormNameLookupEditControl.Properties.DataSource = KPIFormsList;

            StartGettingInventoryThread();
        }
        #endregion

        #region GetDataSearch
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRKPIRegistrationsInfo searchObject = (HRKPIRegistrationsInfo)CurrentModuleEntity.SearchObject;
            HRKPIRegistrationsController objHRKPIRegistsController = new HRKPIRegistrationsController();

            DataSet ds = new DataSet();
            //if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            //{
            if (BranchList.Count == 0)
            {
                ds = objHRKPIRegistsController.GetDataSetByID(-1);
            }
            else
            {
                ds = objHRKPIRegistsController.GetKPIRegistListDatasetByListOfBranchID(
                                                            searchObject.HRKPIRegistrationNo,
                                                            searchObject.FK_HREmployeeID,
                                                            searchObject.FK_HRDepartmentID,
                                                            searchObject.FK_HRDepartmentRoomID,
                                                            searchObject.KPIRegistrationFromDate,
                                                            searchObject.KPIRegistrationToDate,
                                                            BranchList);
            }
            //}
            //else
            //{
            //    ds = objHRKPIRegistsController.GetKPIRegistListDataset(
            //                                                    searchObject.HRKPIRegistrationNo,
            //                                                    searchObject.FK_HREmployeeID,
            //                                                    searchObject.FK_HRDepartmentID,
            //                                                    searchObject.FK_HRDepartmentRoomID,
            //                                                    searchObject.KPIRegistrationFromDate,
            //                                                    searchObject.KPIRegistrationToDate,
            //                                                    searchObject.FK_BRBranchID);
            //}

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
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
            HRKPIEvaluationItemsController objKPIEvaluationItemsController = new HRKPIEvaluationItemsController();
            HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo = new HRKPIEvaluationItemsInfo();
            ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            if (objKPIRegistsInfo.HRKPIRegistrationID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                if (objKPIRegistsInfo.HRKPIRegistrationStatus == KPIRegistrationStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    objKPIEvaluationItemsInfo = (HRKPIEvaluationItemsInfo)objKPIEvaluationItemsController.GetFirstObjectByForeignColumn("FK_HRKPIRegistrationID", objKPIRegistsInfo.HRKPIRegistrationID);
                    if (objKPIEvaluationItemsInfo != null)
                    {
                        ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
                    }
                    else
                    {
                        ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", true);
                    }
                }
                if (objKPIRegistsInfo.HRKPIRegistrationStatus == KPIRegistrationStatus.Evaluated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
                }
            }
        }
        #endregion 

        #region ActionSave
        public override int ActionSave()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
            entity.KPIRegistrationItemsList.EndCurrentEdit();
            entity.EmployeeKPIRegistrationItemsList.EndCurrentEdit();
            if (String.IsNullOrEmpty(objKPIRegistsInfo.HRKPIRegistrationName))
            {
                MessageBox.Show("Vui lòng nhập tên chứng từ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objKPIRegistsInfo.HRKPIRegistrationTotalAmountBonus == 0)
            {
                MessageBox.Show(KPIRegistrationLocalizedResources.NotNullAmountBonus, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objKPIRegistsInfo.HRKPIRegistrationMonth == null || objKPIRegistsInfo.HRKPIRegistrationMonth == DateTime.MaxValue || objKPIRegistsInfo.HRKPIRegistrationMonth == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn Ngày bắt đầu cho áp dụng KPI!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objKPIRegistsInfo.HRKPIRegistrationEndMonth == null || objKPIRegistsInfo.HRKPIRegistrationEndMonth == DateTime.MaxValue || objKPIRegistsInfo.HRKPIRegistrationEndMonth == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn Ngày kết thúc cho áp dụng KPI!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objKPIRegistsInfo.HRKPIRegistrationFinishedDate == null || objKPIRegistsInfo.HRKPIRegistrationFinishedDate == DateTime.MaxValue || objKPIRegistsInfo.HRKPIRegistrationFinishedDate == DateTime.MinValue)
            {
                MessageBox.Show(KPIRegistrationLocalizedResources.NotNullFinishedDate, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (entity.EmployeeKPIRegistrationItemsList.Count() > 0)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                //foreach (HREmployeeKPIRegistrationItemsInfo item in entity.EmployeeKPIRegistrationItemsList)
                //{
                //    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                //    if (objEmployeesInfo != null && objEmployeesInfo.HREmployeeAllowanceKPI < item.HREmployeeKPIRegistrationItemTotalAmountBonus)
                //    {
                //        MessageBox.Show("Tiền Thưởng KPI của nhân viên " + objEmployeesInfo.HREmployeeName + " lớn hơn trong master data. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return 0;
                //    }
                //}
            }

            return base.ActionSave();
        }

        public void ApproveKPIRegistration()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            if (MessageBox.Show("Bạn có muốn duyệt chứng từ không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                entity.SetPropertyChangeEventLock(false);
                HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
                objKPIRegistsInfo.HRKPIRegistrationStatus = KPIRegistrationStatus.Approved.ToString();
                entity.UpdateMainObject();

                if (entity.EmployeeKPIRegistrationItemsList.Count() > 0)
                {
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //foreach (HREmployeeKPIRegistrationItemsInfo item in entity.EmployeeKPIRegistrationItemsList)
                    //{
                    //    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                    //    if (objEmployeesInfo != null && objEmployeesInfo.HREmployeeAllowanceKPI < item.HREmployeeKPIRegistrationItemTotalAmountBonus)
                    //    {
                    //        MessageBox.Show("Tiền Thưởng KPI của nhân viên " + objEmployeesInfo.HREmployeeName + " lớn hơn trong master data. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                    //}
                }

                InvalidateToolbar();
            }
            else
            {
                return;
            }
        }
        #endregion 

        #region Methods
        public void DeleteItemFromKPIRegistItemsList()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            entity.KPIRegistrationItemsList.RemoveSelectedRowObjectFromList();
            //ChangeItemWeightBouns();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;

            HRKPIFormsController objKPIFormsController = new HRKPIFormsController();
            List<HRKPIFormsInfo> KPIFormsList = (List<HRKPIFormsInfo>)objKPIFormsController.GetKPIFormList();
            HRKPIFormItemsController objKPIFormItemsController = new HRKPIFormItemsController();

            guiFind<HRKPIFormsInfo> guiAddItemToKPIRegists = new guiFind<HRKPIFormsInfo>("HRKPIForms", KPIFormsList, this, false);
            guiAddItemToKPIRegists.Module = this;
            guiAddItemToKPIRegists.ShowDialog();
            if (guiAddItemToKPIRegists.DialogResult != DialogResult.OK)
                return;

            IList<HRKPIFormsInfo> results = guiAddItemToKPIRegists.SelectedObjects;
            if (results.Count == 0)
                return;

            List<HRKPIFormItemsInfo> kPIFormItemsList = new List<HRKPIFormItemsInfo>();
            foreach (HRKPIFormsInfo item in results)
            {
                kPIFormItemsList = (List<HRKPIFormItemsInfo>)objKPIFormItemsController.GetKPIFormItemByFK_HRKPIFormID(item.HRKPIFormID);
                if (kPIFormItemsList.Count() > 0)
                {
                    kPIFormItemsList.ForEach(o =>
                    {
                        HRKPIRegistrationItemsInfo objKPIRegistItemsInfo = new HRKPIRegistrationItemsInfo();
                        objKPIRegistItemsInfo.FK_HRKPIID = o.FK_HRKPIID;
                        objKPIRegistItemsInfo.FK_HRKPIFormItemID = o.HRKPIFormItemID;
                        objKPIRegistItemsInfo.FK_HRKPIFormID = o.FK_HRKPIFormID;
                        objKPIRegistItemsInfo.HRKPIRegistrationItemMeasurementMethod = o.HRKPIFormItemMeasurementMethod;
                        objKPIRegistItemsInfo.HRKPIRegistrationItemWeight = o.HRKPIFormItemWeight;
                        objKPIRegistItemsInfo.HRKPIRegistrationItemName = o.HRKPIFormItemName;
                        objKPIRegistItemsInfo.HRKPIRegistrationItemGeneralTarget = o.HRKPIFormItemTarget;
                        objKPIRegistItemsInfo.IsReverseTarget = o.IsReverseTarget;
                        objKPIRegistItemsInfo.HRKPIRegistrationItemGuide = o.HRKPIFormItemGuide;
                        objKPIRegistsInfo.FK_HRKPIFormID = o.FK_HRKPIFormID;
                        entity.KPIRegistrationItemsList.Add(objKPIRegistItemsInfo);
                    });
                }
            }
            ChangeItemWeight();
            entity.UpdateMainObjectBindingSource();
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeItemWeightBouns()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
            objKPIRegistsInfo.HRKPIRegistrationTotalAmount = 0;
            foreach (HRKPIRegistrationItemsInfo item in entity.KPIRegistrationItemsList)
            {
                objKPIRegistsInfo.HRKPIRegistrationTotalAmount += item.HRKPIRegistrationItemWeightBouns;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeItemWeight()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
            List<HRKPIRegistrationItemsInfo> list = new List<HRKPIRegistrationItemsInfo>();
            if (entity.EmployeeKPIRegistrationItemsList.Count() > 0)
            {
                entity.EmployeeKPIRegistrationItemsList.ForEach(o =>
                {
                    o.HREmployeeKPIRegistrationItemTotalAmountBonus = objKPIRegistsInfo.HRKPIRegistrationTotalAmountBonus;
                    if (o.HRKPIRegistrationItemsList != null && o.HRKPIRegistrationItemsList.Count() > 0)
                    {
                        list = (List<HRKPIRegistrationItemsInfo>)o.HRKPIRegistrationItemsList.ToList();
                        list.ForEach(x =>
                        {
                            if (x.HRKPIRegistrationItemWeight > 0 && o.HREmployeeKPIRegistrationItemTotalAmountBonus > 0)
                            {
                                x.HRKPIRegistrationItemWeightBouns = o.HREmployeeKPIRegistrationItemTotalAmountBonus * x.HRKPIRegistrationItemWeight / 100;
                            }
                            else
                            {
                                x.HRKPIRegistrationItemWeightBouns = 0;
                            }
                        });
                        entity.KPIRegistrationItemsList.Invalidate(o.HRKPIRegistrationItemsList);
                    }
                });
            }
            else
            {
                entity.KPIRegistrationItemsList.ForEach(o =>
                    {
                        if (o.HRKPIRegistrationItemWeight > 0 && objKPIRegistsInfo.HRKPIRegistrationTotalAmountBonus > 0)
                        {
                            o.HRKPIRegistrationItemWeightBouns = objKPIRegistsInfo.HRKPIRegistrationTotalAmountBonus * o.HRKPIRegistrationItemWeight / 100;
                        }
                        else
                        {
                            o.HRKPIRegistrationItemWeightBouns = 0;
                        }
                    });
            }
            //ChangeItemWeightBouns();
            UpdateTotalWeightBonus();
            entity.EmployeeKPIRegistrationItemsList.GridControl.RefreshDataSource();
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
        }
        public void ChangeItemWeight(HRKPIRegistrationItemsInfo objKPIRegistrationItemsInfo)
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;

            HREmployeeKPIRegistrationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIRegistrationItemsTableName] as HREmployeeKPIRegistrationItemsInfo;
            if (employee != null && employee.HRKPIRegistrationItemsList != null)
            {
                employee.HRKPIRegistrationItemsList.Invalidate(entity.KPIRegistrationItemsList);
            }
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
            UpdateTotalWeightBonus();
        }
        #endregion

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistrationsInfo = (HRKPIRegistrationsInfo)entity.MainObject;
            HREmployeeKPIRegistrationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIRegistrationItemsTableName] as HREmployeeKPIRegistrationItemsInfo;
            if (employee != null)
            {
                List<HRKPIRegistrationItemsInfo> list = new List<HRKPIRegistrationItemsInfo>();
                list = entity.KPIRegistrationItemsList.Where(o => o.FK_HREmployeeKPIRegistrationItemID == employee.HREmployeeKPIRegistrationItemID).ToList();
                entity.KPIRegistrationItemsList.Invalidate(list);
            }
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
        }

        public void ActionEditAfterComplete()
        {
            ActionEdit();
            ParentScreen.SetEnableOfToolbarButton("EditAfterComplete", false);
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
            if (objKPIRegistsInfo.HRKPIRegistrationID > 0)
            {
                objKPIRegistsInfo.HRKPIRegistrationStatus = KPIRegistrationStatus.New.ToString();
                entity.UpdateMainObjectBindingSource();
            }
        }

        public void AddEmployeeToList()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)CurrentModuleEntity.MainObject;
            if (entity.KPIRegistrationItemsList.Count() > 0)
            {
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                DialogResult showResult = guiEmployee.ShowDialog();
                if (showResult == DialogResult.OK)
                {
                    foreach (HREmployeesInfo objEmployeesInfo in guiEmployee.SelectedEmployeeList)
                    {
                        if (objEmployeesInfo.Selected)
                        {
                            if (!entity.EmployeeKPIRegistrationItemsList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                            {
                                HREmployeeKPIRegistrationItemsInfo objEmployeeKPIRegistrationItemsInfo = new HREmployeeKPIRegistrationItemsInfo();
                                objEmployeeKPIRegistrationItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                objEmployeeKPIRegistrationItemsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                                objEmployeeKPIRegistrationItemsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                                objEmployeeKPIRegistrationItemsInfo.HREmployeeKPIRegistrationItemNo = objEmployeesInfo.HREmployeeNo;
                                objEmployeeKPIRegistrationItemsInfo.HREmployeeKPIRegistrationItemName = objEmployeesInfo.HREmployeeName;
                                objEmployeeKPIRegistrationItemsInfo.IsExcessReward = true;
                                objEmployeeKPIRegistrationItemsInfo.HREmployeeKPIRegistrationItemTotalAmountBonus = objKPIRegistsInfo.HRKPIRegistrationTotalAmountBonus;

                                objEmployeeKPIRegistrationItemsInfo.HRKPIRegistrationItemsList = new BOSList<HRKPIRegistrationItemsInfo>();
                                objEmployeeKPIRegistrationItemsInfo.HRKPIRegistrationItemsList.InitBOSList(entity,
                                            TableName.HRKPIRegistrationsTableName,
                                            TableName.HRKPIRegistrationItemsTableName,
                                            BOSList<HRKPIRegistrationItemsInfo>.cstRelationForeign);
                                entity.InvalidateKPIRegistrationItem(objEmployeeKPIRegistrationItemsInfo, entity.KPIRegistrationItemsList);
                                entity.EmployeeKPIRegistrationItemsList.Add(objEmployeeKPIRegistrationItemsInfo);
                            }
                        }
                    }
                    entity.EmployeeKPIRegistrationItemsList.GridControl.RefreshDataSource();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn KPI trước khi chọn nhân viên!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateTotalWeightBonus();
        }

        public void DeleteItemFromEmployeeItemsList()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            entity.EmployeeKPIRegistrationItemsList.RemoveSelectedRowObjectFromList();
            UpdateTotalWeightBonus();
        }

        public void InitDataViewScreen()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            HREmployeeKPIRegistrationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIRegistrationItemsTableName] as HREmployeeKPIRegistrationItemsInfo;
            if (employee != null && employee.HRKPIRegistrationItemsList != null)
            {
                entity.KPIRegistrationItemsList.Invalidate(employee.HRKPIRegistrationItemsList);
            }
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeItemKPIForm(int kPIFormID)
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            List<HRKPIFormItemsInfo> kPIFormItemsList = new List<HRKPIFormItemsInfo>();
            HRKPIFormItemsController objKPIFormItemsController = new HRKPIFormItemsController();
            kPIFormItemsList = (List<HRKPIFormItemsInfo>)objKPIFormItemsController.GetKPIFormItemByFK_HRKPIFormID(kPIFormID);
            entity.KPIRegistrationItemsList.Clear();
            if (kPIFormItemsList.Count() > 0)
            {
                kPIFormItemsList.ForEach(o =>
                {
                    HRKPIRegistrationItemsInfo objKPIRegistItemsInfo = new HRKPIRegistrationItemsInfo();
                    objKPIRegistItemsInfo.FK_HRKPIID = o.FK_HRKPIID;
                    objKPIRegistItemsInfo.FK_HRKPIFormItemID = o.HRKPIFormItemID;
                    objKPIRegistItemsInfo.FK_HRKPIFormID = o.FK_HRKPIFormID;
                    objKPIRegistItemsInfo.HRKPIRegistrationItemMeasurementMethod = o.HRKPIFormItemMeasurementMethod;
                    objKPIRegistItemsInfo.HRKPIRegistrationItemWeight = o.HRKPIFormItemWeight;
                    objKPIRegistItemsInfo.HRKPIRegistrationItemName = o.HRKPIFormItemName;
                    objKPIRegistItemsInfo.HRKPIRegistrationItemGeneralTarget = o.HRKPIFormItemTarget;
                    objKPIRegistItemsInfo.IsReverseTarget = o.IsReverseTarget;
                    objKPIRegistItemsInfo.HRKPIRegistrationItemGuide = o.HRKPIFormItemGuide;
                    entity.KPIRegistrationItemsList.Add(objKPIRegistItemsInfo);
                });
            }
            if (entity.EmployeeKPIRegistrationItemsList.Count() > 0)
            {
                entity.EmployeeKPIRegistrationItemsList.ForEach(o =>
                {
                    entity.InvalidateKPIRegistrationItem(o, entity.KPIRegistrationItemsList);
                });
            }
            ChangeItemWeight();
            InitDataViewScreen();
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
            UpdateTotalWeightBonus();
        }

        public void ChangeItemWeightEmployee(HREmployeeKPIRegistrationItemsInfo employee)
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            //HREmployeeKPIRegistrationItemsInfo employee = entity.ModuleObjects[TableName.HREmployeeKPIRegistrationItemsTableName] as HREmployeeKPIRegistrationItemsInfo;
            if (employee != null && employee.HRKPIRegistrationItemsList != null)
            {
                List<HRKPIRegistrationItemsInfo> list = (List<HRKPIRegistrationItemsInfo>)employee.HRKPIRegistrationItemsList.ToList();
                list.ForEach(x =>
                {
                    if (x.HRKPIRegistrationItemWeight > 0 && employee.HREmployeeKPIRegistrationItemTotalAmountBonus > 0)
                    {
                        x.HRKPIRegistrationItemWeightBouns = employee.HREmployeeKPIRegistrationItemTotalAmountBonus * x.HRKPIRegistrationItemWeight / 100;
                    }
                    else
                    {
                        x.HRKPIRegistrationItemWeightBouns = 0;
                    }
                });
                entity.KPIRegistrationItemsList.Invalidate(employee.HRKPIRegistrationItemsList);
            }
            entity.KPIRegistrationItemsList.GridControl.RefreshDataSource();
            UpdateTotalWeightBonus();
        }

        public void UpdateTotalWeightBonus()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)CurrentModuleEntity;
            if (entity.EmployeeKPIRegistrationItemsList.Count() > 0)
            {
                List<HRKPIRegistrationItemsInfo> list = new List<HRKPIRegistrationItemsInfo>();
                entity.EmployeeKPIRegistrationItemsList.ForEach(o =>
                    {
                        if (o.HRKPIRegistrationItemsList != null)
                        {
                            list = (List<HRKPIRegistrationItemsInfo>)o.HRKPIRegistrationItemsList.ToList();
                            list.ForEach(x =>
                            {
                                if (!entity.KPIRegistrationItemTargetsList.Exists("FK_HRKPIID", x.FK_HRKPIID))
                                {
                                    HRKPIRegistrationItemTargetsInfo objKPIRegistrationItemTargetsInfo = new HRKPIRegistrationItemTargetsInfo();
                                    objKPIRegistrationItemTargetsInfo.FK_HRKPIID = x.FK_HRKPIID;
                                    objKPIRegistrationItemTargetsInfo.HRKPIRegistrationItemTargetName = x.HRKPIRegistrationItemName;
                                    entity.KPIRegistrationItemTargetsList.Add(objKPIRegistrationItemTargetsInfo);
                                }
                            });
                        }
                    });
                entity.KPIRegistrationItemTargetsList.ForEach(o =>
                {
                    o.HRKPIRegistrationItemTargetToTalWeightBonus = 0;
                    o.HRKPIRegistrationItemTargetTotalTarget = 0;
                    entity.EmployeeKPIRegistrationItemsList.ForEach(y =>
                    {
                        if (y.HRKPIRegistrationItemsList != null)
                        {
                            list = (List<HRKPIRegistrationItemsInfo>)y.HRKPIRegistrationItemsList.ToList();
                            o.HRKPIRegistrationItemTargetToTalWeightBonus += (decimal)list.Where(x => x.FK_HRKPIID == o.FK_HRKPIID).Sum(x => x.HRKPIRegistrationItemWeightBouns);
                            o.HRKPIRegistrationItemTargetTotalTarget += (decimal)list.Where(x => x.FK_HRKPIID == o.FK_HRKPIID).Sum(x => x.HRKPIRegistrationItemTarget);
                        }
                    });
                });
            }
            entity.KPIRegistrationItemTargetsList.GridControl.RefreshDataSource();
        }
    }
}
