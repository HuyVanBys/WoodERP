using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.RegisterDormitory
{
    public class RegisterDormitoryModule : BaseTransactionModule
    {
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;

        public RegisterDormitoryModule()
        {
            Name = "RegisterDormitory";
            CurrentModuleEntity = new RegisterDormitoryEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[RegisterDormitoryModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
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

        //protected override DataSet GetSearchData(ref string searchQuery)
        //{
        //    HRRegisterDormitorysController objRegisterDormitorysController = new HRRegisterDormitorysController();
        //    HRRegisterDormitorysInfo searchObject = (HRRegisterDormitorysInfo)CurrentModuleEntity.SearchObject;
        //    DataSet ds;
        //    if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
        //    {
        //        if (BranchList.Count == 0)
        //        {
        //            ds = objRegisterDormitorysController.GetDataSetByID(1);
        //        }
        //        else
        //        {
        //            ds = objRegisterDormitorysController.GetRegisterDormitoryListDataSetByListOfBranchID(searchObject.HRRegisterDormitoryNo,
        //                                                                    searchObject.FK_BRBranchID,
        //                                                                    searchObject.FK_HREmployeeID,
        //                                                                    searchObject.FK_HRDormitoryID,
        //                                                                    BranchList);
        //        }
        //    }
        //    else
        //    {
        //        ds = objRegisterDormitorysController.GetRegisterDormitoryListDataSet(searchObject.HRRegisterDormitoryNo,
        //                                                    searchObject.FK_BRBranchID,
        //                                                    searchObject.FK_HREmployeeID,
        //                                                    searchObject.FK_HRDormitoryID);
        //    }
        //    return ds;
        //}

        public void ChangeDormitory(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                RegisterDormitoryEntities entity = (RegisterDormitoryEntities)CurrentModuleEntity;
                HRRegisterDormitorysInfo objRegisterDormitorysInfo = (HRRegisterDormitorysInfo)CurrentModuleEntity.MainObject;
                objRegisterDormitorysInfo.FK_HRDormitoryID = int.Parse(e.Value.ToString());
                HRDormitorysController objDormitorysController = new HRDormitorysController();
                HRDormitorysInfo objDormitorysInfo = (HRDormitorysInfo)objDormitorysController.GetObjectByID(objRegisterDormitorysInfo.FK_HRDormitoryID);
                if (objDormitorysInfo != null)
                {
                    objRegisterDormitorysInfo.HRRegisterDormitoryAcreage = objDormitorysInfo.HRDormitoryAcreage;
                    objRegisterDormitorysInfo.HRRegisterDormitoryCapacity = objDormitorysInfo.HRDormitoryCapacity;
                    entity.UpdateMainObjectBindingSource();
                }
            }
        }
        public void AddEmployeeToRegisterDormitoryItem()
        {
            try
            {
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    RegisterDormitoryEntities entity = (RegisterDormitoryEntities)CurrentModuleEntity;
                    HRRegisterDormitorysInfo objRegisterDormitorysInfo = (HRRegisterDormitorysInfo)entity.MainObject;
                    if (guiEmployee.SelectedEmployeeList.Count > objRegisterDormitorysInfo.HRRegisterDormitoryCapacity - entity.RegisterDormitoryItemList.Count)
                    {
                        MessageBox.Show("Số lượng người đăng kí vượt quá số lượng cho phép. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (guiEmployee.SelectedEmployeeList != null && guiEmployee.SelectedEmployeeList.Count > 0)
                    {
                        foreach (HREmployeesInfo objEmployeesInfo in guiEmployee.SelectedEmployeeList)
                        {
                            if (entity.RegisterDormitoryItemList.Where(x => x.FK_HREmployeeID == objEmployeesInfo.HREmployeeID).ToList().Count == 0)
                            {
                                HRRegisterDormitoryItemsInfo objRegisterDormitoryItemsInfo = (HRRegisterDormitoryItemsInfo)entity.ModuleObjects[TableName.HRRegisterDormitoryItemsTableName];
                                objRegisterDormitoryItemsInfo.FK_HRRegisterDormitoryID = objRegisterDormitorysInfo.HRRegisterDormitoryID;
                                objRegisterDormitoryItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeeName = objEmployeesInfo.HREmployeeName;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeeTypeCombo = objEmployeesInfo.HREmployeeTypeCombo;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeeLevelID = objEmployeesInfo.FK_HRLevelID;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeePicture = objEmployeesInfo.HREmployeePicture;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemPersonName = objEmployeesInfo.HREmployeeName;
                                objRegisterDormitoryItemsInfo.FK_HREmployeeContactPersonID = 0;
                                objRegisterDormitoryItemsInfo.FK_HRRelationshipID = 0;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemGenderCombo = objEmployeesInfo.HREmployeeGenderCombo;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemBirthday = objEmployeesInfo.HREmployeeDob;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemPhone = objEmployeesInfo.HREmployeeTel1;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemAddressStreet = objEmployeesInfo.HREmployeeContactAddressLine3;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemFromDate = objRegisterDormitorysInfo.HRRegisterDormitoryFromDate;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemToDate = objRegisterDormitorysInfo.HRRegisterDormitoryToDate;

                                entity.RegisterDormitoryItemList.AddObjectToList();
                            }
                        }
                    }
                    entity.RegisterDormitoryItemList.GridControl.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddContactPersonToRegisterDormitoryItem()
        {
            try
            {
                HREmployeeContactPersonsController objHREmployeeContactPersons = new HREmployeeContactPersonsController();
                List<HREmployeeContactPersonsInfo> employeeContactPersonsList = objHREmployeeContactPersons.GetDataForRegisterDormitory();
                guiFind<HREmployeeContactPersonsInfo> guifind = new guiFind<HREmployeeContactPersonsInfo>("HREmployeeContactPersons",
                                                                                                       employeeContactPersonsList
                                                                                                       , this, true, true);
                guifind.Module = this;
                if (guifind.ShowDialog() == DialogResult.OK)
                {
                    RegisterDormitoryEntities entity = (RegisterDormitoryEntities)CurrentModuleEntity;
                    HRRegisterDormitorysInfo objRegisterDormitorysInfo = (HRRegisterDormitorysInfo)entity.MainObject;
                    if (guifind.SelectedObjects.Count > objRegisterDormitorysInfo.HRRegisterDormitoryCapacity - entity.RegisterDormitoryItemList.Count)
                    {
                        MessageBox.Show("Số lượng người đăng kí vượt quá số lượng cho phép. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                    {
                        foreach (HREmployeeContactPersonsInfo objEmployeesInfo in guifind.SelectedObjects)
                        {
                            if (entity.RegisterDormitoryItemList.Where(x => x.FK_HREmployeeContactPersonID == objEmployeesInfo.HREmployeeContactPersonID).ToList().Count == 0)
                            {
                                HRRegisterDormitoryItemsInfo objRegisterDormitoryItemsInfo = (HRRegisterDormitoryItemsInfo)entity.ModuleObjects[TableName.HRRegisterDormitoryItemsTableName];
                                objRegisterDormitoryItemsInfo.FK_HRRegisterDormitoryID = objRegisterDormitorysInfo.HRRegisterDormitoryID;
                                objRegisterDormitoryItemsInfo.FK_HREmployeeID = objEmployeesInfo.FK_HREmployeeID;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeeName = objEmployeesInfo.HREmployeeName;
                                objRegisterDormitoryItemsInfo.FK_HREmployeeContactPersonID = objEmployeesInfo.HREmployeeContactPersonID;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeeTypeCombo = objEmployeesInfo.HREmployeeTypeCombo;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeeLevelID = objEmployeesInfo.FK_HRLevelID;
                                //objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemEmployeePicture = objEmployeesInfo.HREmployeePicture;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemPersonName = objEmployeesInfo.HREmployeeContactPersonName;
                                objRegisterDormitoryItemsInfo.FK_HRRelationshipID = objEmployeesInfo.FK_HRRelationshipID;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemGenderCombo = objEmployeesInfo.HREmployeeContactPersonGenderCombo;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemBirthday = objEmployeesInfo.HREmployeeContactPersonBirthday;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemPhone = objEmployeesInfo.HREmployeeContactPersonPhone;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemAddressStreet = objEmployeesInfo.HREmployeeContactPersonAddressStreet;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemFromDate = objRegisterDormitorysInfo.HRRegisterDormitoryFromDate;
                                objRegisterDormitoryItemsInfo.HRRegisterDormitoryItemToDate = objRegisterDormitorysInfo.HRRegisterDormitoryToDate;
                                entity.RegisterDormitoryItemList.AddObjectToList();
                            }
                        }
                    }
                    entity.RegisterDormitoryItemList.GridControl.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override int ActionSave()
        {
            RegisterDormitoryEntities entity = (RegisterDormitoryEntities)CurrentModuleEntity;
            HRRegisterDormitorysInfo objRegisterDormitorysInfo = (HRRegisterDormitorysInfo)entity.MainObject;
            HRRegisterDormitorysController objHRRegisterDormitorysController = new HRRegisterDormitorysController();
            entity.RegisterDormitoryItemList.EndCurrentEdit();

            List<HRRegisterDormitorysInfo> listHRRegisterDormitorys = objHRRegisterDormitorysController.GetHRRegisterDormitorysByDate(objRegisterDormitorysInfo.FK_HRDormitoryID
                                                                                                                                        , objRegisterDormitorysInfo.HRRegisterDormitoryFromDate
                                                                                                                                        , objRegisterDormitorysInfo.HRRegisterDormitoryToDate);
            listHRRegisterDormitorys = listHRRegisterDormitorys.Where(i => i.HRRegisterDormitoryID != objRegisterDormitorysInfo.HRRegisterDormitoryID).ToList();
            if (listHRRegisterDormitorys != null && listHRRegisterDormitorys.Count > 0)
            {
                DateTime fromDate = listHRRegisterDormitorys[0].HRRegisterDormitoryFromDate;
                DateTime toDate = listHRRegisterDormitorys[0].HRRegisterDormitoryToDate;
                MessageBox.Show("Phòng này đã được đăng kí từ ngày: " + fromDate.ToString("dd/MM/yyyy") + " đến ngày: " + toDate.ToString("dd/MM/yyyy"), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            List<int> listEmployeeID = entity.RegisterDormitoryItemList.Select(i => i.FK_HREmployeeID).ToList();
            if (listEmployeeID.Contains(objRegisterDormitorysInfo.FK_HREmployeeManager) == false)
            {
                MessageBox.Show("Trưởng phòng không có trong lưới chi tiết, vui lòng chọn lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objRegisterDormitorysInfo.HRRegisterDormitoryCapacity < entity.RegisterDormitoryItemList.Count)
            {
                MessageBox.Show("Số lượng nhân viên vượt quá sức chứa của phòng trọ. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return base.ActionSave();
        }

        public void DeleteItemFromRegisterDormitoryItemsList()
        {
            RegisterDormitoryEntities entity = (RegisterDormitoryEntities)CurrentModuleEntity;
            entity.RegisterDormitoryItemList.RemoveSelectedRowObjectFromList();
        }
    }
}
