using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EmployeeTransmit
{
    public class EmployeeTransmitModule : BaseTransactionModule
    {
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<BRBranchsInfo> BranchList;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        List<HREmployeeSalaryConfigsInfo> EmployeeSalaryConfigsList;

        public EmployeeTransmitModule()
        {
            Name = "EmployeeTransmit";
            CurrentModuleEntity = new EmployeeTransmitEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            EmployeeSalaryConfigsList = new List<HREmployeeSalaryConfigsInfo>();
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
            bool reset = false;
            if (!string.IsNullOrEmpty(searchQuery)) reset = true;
            base.GetSearchData(ref searchQuery);
            if (reset || (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null &&
                (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")))
            {
                if (BranchList.Count == 0)
                {
                    searchQuery += string.Format(" and FK_BRBranchID = -1");
                }
                else
                {
                    string str = "";
                    foreach (var item in BranchList)
                    {
                        str += "," + item.BRBranchID.ToString();
                    }
                    searchQuery += string.Format(" and FK_BRBranchID in ({0})", str.Substring(1));
                }
            }
            else if (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null)
            {
                searchQuery += string.Format(" and FK_BRBranchID = {0}", SearchBranchLookupEditControl.EditValue.ToString());
            }
            string mainObjectControllerName = BOSUtil.GetBusinessControllerNameFromBusinessObject(CurrentModuleEntity.MainObject);
            IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(mainObjectControllerName);
            DataSet ds = objCurrentObjectController.GetDataSet(searchQuery);
            return ds;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo objWorkingShiftsInfo = workingShiftController.GetDefaultWorkingShiftByPayrollFormulaIDAndWorkingShiftDayOfWeek(null, null);
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            DateTime severDate = BOSApp.GetCurrentServerDate();
            objEmployeeTransmitsInfo.HREmployeeTransmitFromDate = severDate;
            objEmployeeTransmitsInfo.HREmployeeTransmitToDate = severDate;
            objEmployeeTransmitsInfo.HREmployeeTransmitDate = severDate;
            objEmployeeTransmitsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            if (objWorkingShiftsInfo != null)
            {
                objEmployeeTransmitsInfo.HREmployeeTransmitDateStart = objWorkingShiftsInfo.HRWorkingShiftFromTime;
                objEmployeeTransmitsInfo.HREmployeeTransmitDateEnd = objWorkingShiftsInfo.HRWorkingShiftToTime;
            }
        }

        public override int ActionSave()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            HREmployeeTransmitsController objEmployeeTransmitsController = new HREmployeeTransmitsController();
            entity.EmployeeTransmitItemList.EndCurrentEdit();
            bool notFoundAmount = false;
            entity.EmployeeTransmitItemList.ForEach(o =>
            {
                if (o.HREmployeeTransmitItemSalary == 0 && o.HREmployeeTransmitItemResponsibilitySalary == 0)
                {
                    notFoundAmount = true;
                }
            });
            if (notFoundAmount)
            {
                MessageBox.Show("Không tìm thấy cấu hình mức lương, theo thông tin bộ phận tiếp nhận!" +
                   Environment.NewLine + "Vui lòng kiểm tra lại bộ phận tiếp nhận.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return 0;
            }

            return base.ActionSave();
        }

        public void ApprovedEmployeeTransmit()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            bool notFoundAmount = false;
            entity.EmployeeTransmitItemList.ForEach(o =>
            {
                if (o.HREmployeeTransmitItemSalary == 0 && o.HREmployeeTransmitItemResponsibilitySalary == 0)
                {
                    notFoundAmount = true;
                }
            });
            if (notFoundAmount)
            {
                MessageBox.Show("Không tìm thấy cấu hình mức lương, theo thông tin bộ phận tiếp nhận!" +
                   Environment.NewLine + "Vui lòng kiểm tra lại bộ phận tiếp nhận hoặc cấu hình!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            objEmployeeTransmitsInfo.HREmployeeTransmitStatus = EmployeeTransmitStatus.Approved.ToString();
            entity.SaveMainObject();
        }

        public void AddEmployeeToTransmitList()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> EmployeesList = new List<HREmployeesInfo>();
            EmployeesList = objEmployeesController.GetEmployeeList(0, 0, 0, 0, "Working");
            entity.EmployeeTransmitItemList.ForEach(o =>
            {
                EmployeesList.ForEach(x =>
                {
                    if (x.HREmployeeID == o.FK_HREmployeeID)
                        entity.HREmployeeList.Add(x);
                });
            });

            HREmployeeSalaryConfigsController objEmployeeSalaryConfigsController = new HREmployeeSalaryConfigsController();
            EmployeeSalaryConfigsList = objEmployeeSalaryConfigsController.GetAllEmployeeSalaryConfigList();

            HREmployeeSalaryConfigsInfo objEmployeeSalaryConfigsInfo = EmployeeSalaryConfigsList.Where(x =>
                  (x.FK_BRBranchID == objEmployeeTransmitsInfo.FK_BRBranchID || x.FK_BRBranchID == 0)
                && (x.FK_HRDepartmentID == objEmployeeTransmitsInfo.FK_HRDepartmentID || x.FK_HRDepartmentID == 0)
                && (x.FK_HRDepartmentRoomGroupItemID == objEmployeeTransmitsInfo.FK_HRDepartmentRoomGroupItemID || x.FK_HRDepartmentRoomGroupItemID == 0)
                && (x.FK_HRDepartmentRoomID == objEmployeeTransmitsInfo.FK_HRDepartmentRoomID || x.FK_HRDepartmentRoomID == 0)
                && (x.FK_HRLevelID == objEmployeeTransmitsInfo.FK_HRLevelID || x.FK_HRLevelID == 0)
                && (x.FK_MMWorkShopID == objEmployeeTransmitsInfo.FK_MMWorkShopID || x.FK_MMWorkShopID == 0)).FirstOrDefault();

            if (objEmployeeSalaryConfigsInfo == null || objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigID == 0)
            {
                if (MessageBox.Show("Không tìm thấy cấu hình mức lương, theo thông tin bộ phận tiếp nhận!" +
                   Environment.NewLine + "Vui lòng kiểm tra lại bộ phận tiếp nhận hoặc cấu hình!" +
                    Environment.NewLine + "Nhấn No nếu tiếp tục.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
            guiSearchEmployee guiEmployee = new guiSearchEmployee(entity.HREmployeeList);
            guiEmployee.Module = this;
            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                entity.HREmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.EmployeeTransmitItemList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeTransmitItemsInfo objEmployeeTransmitItemsInfo = new HREmployeeTransmitItemsInfo();
                            objEmployeeTransmitItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            objEmployeeTransmitItemsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objEmployeeTransmitItemsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                            objEmployeeTransmitItemsInfo.HREmployeeTransmitItemDate = objEmployeeTransmitsInfo.HREmployeeTransmitDate;
                            objEmployeeTransmitItemsInfo.HREmployeeTransmitItemFromDate = objEmployeeTransmitsInfo.HREmployeeTransmitFromDate;
                            objEmployeeTransmitItemsInfo.HREmployeeTransmitItemToDate = objEmployeeTransmitsInfo.HREmployeeTransmitToDate;
                            objEmployeeTransmitItemsInfo.HREmployeeTransmitItemDateStart = objEmployeeTransmitsInfo.HREmployeeTransmitDateStart;
                            objEmployeeTransmitItemsInfo.HREmployeeTransmitItemDateEnd = objEmployeeTransmitsInfo.HREmployeeTransmitDateEnd;
                            objEmployeeTransmitItemsInfo.FK_HRLevelID = objEmployeeTransmitsInfo.FK_HRLevelID;
                            if (objEmployeeSalaryConfigsInfo != null && objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigID > 0)
                            {
                                objEmployeeTransmitItemsInfo.FK_HRDepartmentRoomID = objEmployeeSalaryConfigsInfo.FK_HRDepartmentRoomID;
                                objEmployeeTransmitItemsInfo.FK_HRDepartmentRoomGroupItemID = objEmployeeSalaryConfigsInfo.FK_HRDepartmentRoomGroupItemID;
                                objEmployeeTransmitItemsInfo.HREmployeeTransmitItemSalary = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigContractAmount;
                                objEmployeeTransmitItemsInfo.HREmployeeTransmitItemResponsibilitySalary = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigResponsibilityAmount;
                                objEmployeeTransmitItemsInfo.HREmployeeTransmitItemMeasureUnitType = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigMeasureUnitType;
                            }
                            entity.EmployeeTransmitItemList.Add(objEmployeeTransmitItemsInfo);
                        }
                    }
                }
                entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
            }
        }

        public void RemoveEmployeeFromEmployeeTransmitItemList()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            entity.EmployeeTransmitItemList.RemoveSelectedRowObjectFromList();
            entity.HREmployeeList.ForEach(o =>
            {
                if (entity.EmployeeTransmitItemList.Where(x => x.FK_HREmployeeID == o.HREmployeeID).ToList().Count() == 0)
                    entity.HREmployeeList.Remove(o);
            });
        }

        public void UpdateSalaryConfig()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            if (entity.EmployeeTransmitItemList != null && entity.EmployeeTransmitItemList.Count > 0)
            {
                if (MessageBox.Show("Thay đổi sẽ cập nhật Lương cơ bản và trách nhiệm cho từng chi tiết!"
                    + Environment.NewLine + "Bạn muốn thay đổi cho tất cả chi tiết không?"
                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;

            HREmployeeSalaryConfigsInfo objEmployeeSalaryConfigsInfo = EmployeeSalaryConfigsList.Where(x =>
                (x.FK_BRBranchID == objEmployeeTransmitsInfo.FK_BRBranchID || x.FK_BRBranchID == 0)
              && (x.FK_HRDepartmentID == objEmployeeTransmitsInfo.FK_HRDepartmentID || x.FK_HRDepartmentID == 0)
              && (x.FK_HRDepartmentRoomGroupItemID == objEmployeeTransmitsInfo.FK_HRDepartmentRoomGroupItemID || x.FK_HRDepartmentRoomGroupItemID == 0)
              && (x.FK_HRDepartmentRoomID == objEmployeeTransmitsInfo.FK_HRDepartmentRoomID || x.FK_HRDepartmentRoomID == 0)
              && (x.FK_HRLevelID == objEmployeeTransmitsInfo.FK_HRLevelID || x.FK_HRLevelID == 0)
              && (x.FK_MMWorkShopID == objEmployeeTransmitsInfo.FK_MMWorkShopID || x.FK_MMWorkShopID == 0)).FirstOrDefault();
            if (objEmployeeSalaryConfigsInfo == null || objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigID == 0)
            {
                return;
            }
            else
            {
                entity.EmployeeTransmitItemList.ForEach(e =>
                 {
                     e.FK_HRDepartmentRoomID = objEmployeeTransmitsInfo.FK_HRDepartmentRoomID;
                     e.FK_HRDepartmentRoomGroupItemID = objEmployeeTransmitsInfo.FK_HRDepartmentRoomGroupItemID;
                     e.FK_HRLevelID = objEmployeeTransmitsInfo.FK_HRLevelID;
                     if (objEmployeeSalaryConfigsInfo != null)
                     {
                         e.HREmployeeTransmitItemSalary = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigContractAmount;
                         e.HREmployeeTransmitItemResponsibilitySalary = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigResponsibilityAmount;
                         e.HREmployeeTransmitItemMeasureUnitType = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigMeasureUnitType;
                     }
                 });
                entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
            }
        }
        public void UpdateTransmitFromDateInfo()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            if (entity.EmployeeTransmitItemList != null && entity.EmployeeTransmitItemList.Count > 0)
            {
                if (MessageBox.Show("Thay đổi sẽ cập nhật cho từng chi tiết!"
                    + Environment.NewLine + "Bạn muốn thay đổi cho tất cả chi tiết không?"
                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            entity.EmployeeTransmitItemList.ForEach(e =>
            {
                e.HREmployeeTransmitItemFromDate = objEmployeeTransmitsInfo.HREmployeeTransmitFromDate;
            });
            entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
        }
        public void UpdateTransmitToDateInfo()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            if (entity.EmployeeTransmitItemList != null && entity.EmployeeTransmitItemList.Count > 0)
            {
                if (MessageBox.Show("Thay đổi sẽ cập nhật cho từng chi tiết!"
                    + Environment.NewLine + "Bạn muốn thay đổi cho tất cả chi tiết không?"
                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            entity.EmployeeTransmitItemList.ForEach(e =>
            {
                e.HREmployeeTransmitItemToDate = objEmployeeTransmitsInfo.HREmployeeTransmitToDate;
            });
            entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
        }
        public void UpdateTransmitDateStartInfo()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            if (entity.EmployeeTransmitItemList != null && entity.EmployeeTransmitItemList.Count > 0)
            {
                if (MessageBox.Show("Thay đổi sẽ cập nhật cho từng chi tiết!"
                    + Environment.NewLine + "Bạn muốn thay đổi cho tất cả chi tiết không?"
                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            entity.EmployeeTransmitItemList.ForEach(e =>
            {
                e.HREmployeeTransmitItemDateStart = objEmployeeTransmitsInfo.HREmployeeTransmitDateStart;
            });
            entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
        }
        public void UpdateTransmitDateEndInfo()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            if (entity.EmployeeTransmitItemList != null && entity.EmployeeTransmitItemList.Count > 0)
            {
                if (MessageBox.Show("Thay đổi sẽ cập nhật cho từng chi tiết!"
                    + Environment.NewLine + "Bạn muốn thay đổi cho tất cả chi tiết không?"
                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            entity.EmployeeTransmitItemList.ForEach(e =>
            {
                e.HREmployeeTransmitItemDateEnd = objEmployeeTransmitsInfo.HREmployeeTransmitDateEnd;
            });
            entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
        }
        public void UpdateSalaryConfig(HREmployeeTransmitItemsInfo item)
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;

            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            HREmployeeSalaryConfigsInfo objEmployeeSalaryConfigsInfo = EmployeeSalaryConfigsList.Where(x =>
                (x.FK_BRBranchID == objEmployeeTransmitsInfo.FK_BRBranchID || x.FK_BRBranchID == 0)
              && (x.FK_HRDepartmentID == objEmployeeTransmitsInfo.FK_HRDepartmentID || x.FK_HRDepartmentID == 0)
              && (x.FK_HRDepartmentRoomGroupItemID == item.FK_HRDepartmentRoomGroupItemID || x.FK_HRDepartmentRoomGroupItemID == 0)
              && (x.FK_HRDepartmentRoomID == item.FK_HRDepartmentRoomID || x.FK_HRDepartmentRoomID == 0)
              && (x.FK_HRLevelID == item.FK_HRLevelID || x.FK_HRLevelID == 0)
              && (x.FK_MMWorkShopID == objEmployeeTransmitsInfo.FK_MMWorkShopID || x.FK_MMWorkShopID == 0)).FirstOrDefault();
            if (objEmployeeSalaryConfigsInfo == null || objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigID == 0)
            {
                MessageBox.Show("Không tìm thấy cấu hình mức lương, theo thông tin bộ phận tiếp nhận!" +
                   Environment.NewLine + "Vui lòng kiểm tra lại chi tiết hoặc cấu hình!."
                   , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                item.HREmployeeTransmitItemSalary = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigContractAmount;
                item.HREmployeeTransmitItemResponsibilitySalary = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigResponsibilityAmount;
                item.HREmployeeTransmitItemMeasureUnitType = objEmployeeSalaryConfigsInfo.HREmployeeSalaryConfigMeasureUnitType;
                entity.EmployeeTransmitItemList.GridControl.RefreshDataSource();
            }
        }
        public override void InvalidateToolbar()
        {
            EmployeeTransmitEntities entity = (EmployeeTransmitEntities)CurrentModuleEntity;
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            if (objEmployeeTransmitsInfo.HREmployeeTransmitID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton("Edit", true);
                if (objEmployeeTransmitsInfo.HREmployeeTransmitStatus == "New")
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                else
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
            }
            if (objEmployeeTransmitsInfo.HREmployeeTransmitStatus == "Approved")
            {
                ParentScreen.SetEnableOfToolbarButton("Edit", false);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
            }

            base.InvalidateToolbar();
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            HREmployeeSalaryConfigsController objEmployeeSalaryConfigsController = new HREmployeeSalaryConfigsController();
            EmployeeSalaryConfigsList = objEmployeeSalaryConfigsController.GetAllEmployeeSalaryConfigList();
        }
    }
}
