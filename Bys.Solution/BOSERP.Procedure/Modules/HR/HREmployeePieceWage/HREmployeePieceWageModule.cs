using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HREmployeePieceWage
{
    public class HREmployeePieceWageModule : BaseModuleERP
    {
        public HREmployeePieceWageModule()
        {
            Name = "HREmployeePieceWage";
            CurrentModuleEntity = new HREmployeePieceWageEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        public override int ActionSave()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo obj = (HREmployeePieceWagesInfo)entity.MainObject;
            DateTime d = obj.HREmployeePieceWageDate;
            DateTime dto = obj.HREmployeePieceWageDateEnd;
            obj.HREmployeePieceWageFromDate = new DateTime(d.Year, d.Month, d.Day, obj.HREmployeePieceWageFromDate.Hour, obj.HREmployeePieceWageFromDate.Minute, 0);
            obj.HREmployeePieceWageToDate = new DateTime(dto.Year, dto.Month, dto.Day, obj.HREmployeePieceWageToDate.Hour, obj.HREmployeePieceWageToDate.Minute, 0);
            return base.ActionSave();
        }
        /// <summary>
        /// Add employee to the current overtime list
        /// </summary>
        public void AddEmployeeToEmployeePieceWageItemList()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
            guiSearchEmployee guiEmployee = new guiSearchEmployee();
            guiEmployee.Module = this;
            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                entity.HREmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeePieceWageItemList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeePieceWageItemsInfo objEmployeePieceWageItemsInfo = new HREmployeePieceWageItemsInfo();
                            objEmployeePieceWageItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            objEmployeePieceWageItemsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objEmployeePieceWageItemsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                            objEmployeePieceWageItemsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                            objEmployeePieceWageItemsInfo.FK_HRDepartmentRoomGroupItemID = objEmployeesInfo.FK_HRDepartmentRoomGroupItemID;
                            objEmployeePieceWageItemsInfo.HREmployeePieceWageItemCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            objEmployeePieceWagesInfo.HREmployeeCardNumber += objEmployeesInfo.HREmployeeCardNumber;
                            objEmployeePieceWagesInfo.HREmployeeName += objEmployeesInfo.HREmployeeName;
                            if (entity.HREmployeeList.Count > 1)
                            {
                                objEmployeePieceWagesInfo.HREmployeeCardNumber = objEmployeePieceWagesInfo.HREmployeeCardNumber + ";";
                                objEmployeePieceWagesInfo.HREmployeeName = objEmployeePieceWagesInfo.HREmployeeName + ";";
                            }
                            entity.HREmployeePieceWageItemList.Add(objEmployeePieceWageItemsInfo);
                        }
                    }
                }
                entity.HREmployeePieceWageItemList.GridControl.RefreshDataSource();
            }
        }
        public override void ActionEdit()
        {
            if (!isInvalidate)
            {
                base.ActionEdit();
            }
        }

        public bool isInvalidate = false;
        public override void Invalidate(int iObjectID)
        {
            isInvalidate = true;
            base.Invalidate(iObjectID);
            BOSTextBox t1 = (BOSTextBox)this.Controls["fld_txtHREmployeePieceWageFromDate"];
            BOSTextBox t2 = (BOSTextBox)this.Controls["fld_txtHREmployeePieceWageToDate"];
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
            t1.Text = objEmployeePieceWagesInfo.HREmployeePieceWageFromDate.ToString("HH:mm");
            //t2.Text = objEmployeePieceWagesInfo.HREmployeePieceWageToDate.ToString("HH:mm");
            isInvalidate = false;
        }

        public void ApproveHREmployeePieceWage()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
            HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();

            entity.SetPropertyChangeEventLock(false);

            if (!CheckExistTimeSheetComplete())
                return;

            objEmployeePieceWagesInfo.HREmployeePieceWageStatus = "Approved";

            try
            {
                objEmployeePieceWageItemsController.UpdateEmployeePieceWageCompleteTimeSheet(objEmployeePieceWagesInfo.HREmployeePieceWageID, objEmployeePieceWagesInfo.HREmployeePieceWageFromDate);

                int total = entity.HREmployeePieceWageItemList.Where(x => x.HREmployeePieceWageItemIsAction).ToList().Count;
                if (total > 0)
                {
                    decimal percent = 100 / total;
                    foreach (HREmployeePieceWageItemsInfo item in entity.HREmployeePieceWageItemList)
                    {
                        if (item.HREmployeePieceWageItemIsAction)
                            item.HREmployeePieceWageItemAmount = percent * objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalAmount / 100;
                    }
                    entity.HREmployeePieceWageItemList.SaveItemObjects();
                }
                entity.UpdateMainObject();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lổi xãy ra trong quá trình cập nhật công, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();

        }
        public bool CheckExistTimeSheetComplete()
        {
            bool result = true;
            string mess = string.Empty;
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
            HREmployeePieceWageItemsController objEmployeePieceWageItemsController = new HREmployeePieceWageItemsController();

            List<HREmployeePieceWageItemsInfo> listHREmployeePieceWageItems = objEmployeePieceWageItemsController.GetEmployeePieceWageCompleteTimeSheet(objEmployeePieceWagesInfo.HREmployeePieceWageID);
            if (listHREmployeePieceWageItems != null)
            {
                foreach (HREmployeePieceWageItemsInfo item in entity.HREmployeePieceWageItemList)
                {
                    if (item.HREmployeePieceWageItemIsAction)
                    {
                        HREmployeePieceWageItemsInfo itemExist = listHREmployeePieceWageItems.Where(x => x.HREmployeePieceWageItemID == item.HREmployeePieceWageItemID).FirstOrDefault();
                        if (itemExist == null || itemExist.HREmployeePieceWageItemID == 0)
                        {
                            result = false;
                            mess += Environment.NewLine + item.HREmployeePieceWageItemCardNumber + ": " + item.HREmployeeName;
                        }
                    }
                }
            }
            else
            {
                result = false;
                mess = "NONE";

            }
            if (mess != string.Empty)
            {
                if (mess == "NONE")
                    mess = "Không tìm thấy bảng chấm công cho danh sách tính lương khoáng!";
                else
                    mess = "Không tìm thấy bảng chấm công cho danh sách tính lương khoáng:" + mess;

                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
        public override void InvalidateToolbar()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
            if (objEmployeePieceWagesInfo.HREmployeePieceWageID > 0)
            {

                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                if (objEmployeePieceWagesInfo.HREmployeePieceWageStatus == "Approved")
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                }
            }

            base.InvalidateToolbar();
        }
        /// <summary>
        /// Remove the selected employee from the current overtime list
        /// </summary>
        public void RemoveEmployeeFromEmployeePieceWageItemList()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            entity.HREmployeePieceWageItemList.RemoveSelectedRowObjectFromList();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ((BOSTextBox)this.Controls["fld_txtHREmployeePieceWageFromDate"]).Text = "00:00";
            //((BOSTextBox)this.Controls["fld_txtHREmployeePieceWageToDate"]).Text = "00:00";
        }

        /// <summary>
        /// Search employee from query
        /// </summary>
        /// <param name="searchQuery"></param>
        public void SearchEmployee(string searchQuery)
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet ds = objEmployeesController.GetDataSet(searchQuery);
            entity.HREmployeeList.Invalidate(ds);
            entity.HREmployeeList.GridView.RefreshData();
        }

        /// <summary>
        /// Select all employee when checked
        /// </summary>
        /// <param name="check"></param>
        public void SelectAllEmployee(bool check)
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
            {
                objEmployeesInfo.Selected = check;
            }
            entity.HREmployeeList.GridView.RefreshData();
        }

        public void UpdateDateEnd()
        {
            HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
            objEmployeePieceWagesInfo.HREmployeePieceWageDateEnd = objEmployeePieceWagesInfo.HREmployeePieceWageDate;
        }
        public void ChangeProductPieceWage(int ProductPieceWageID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
                HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
                HRProductPieceWagesController objProductPieceWagesController = new HRProductPieceWagesController();
                HRProductPieceWagesInfo objProductPieceWagesInfo = (HRProductPieceWagesInfo)objProductPieceWagesController.GetObjectByID(ProductPieceWageID);
                if (objProductPieceWagesInfo != null)
                {
                    objEmployeePieceWagesInfo.HREmployeePieceWageProductUnitPrice = objProductPieceWagesInfo.HRProductPieceWageUnitPrice;
                    if (objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalQty > 0)
                        objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalAmount = objProductPieceWagesInfo.HRProductPieceWageUnitPrice
                                                                                * objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalQty;
                }
            }
        }
        public void ChangeProductPieceWageRealProductTotalQty()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HREmployeePieceWageEntities entity = (HREmployeePieceWageEntities)CurrentModuleEntity;
                HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)entity.MainObject;
                if (objEmployeePieceWagesInfo != null)
                {
                    if (objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalQty > 0)
                        objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalAmount = objEmployeePieceWagesInfo.HREmployeePieceWageProductUnitPrice
                                                                                * objEmployeePieceWagesInfo.HREmployeePieceWageRealProductTotalQty;
                }
            }
        }
    }
}
