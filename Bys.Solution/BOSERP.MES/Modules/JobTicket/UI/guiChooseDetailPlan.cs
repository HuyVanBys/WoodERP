using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public partial class guiChooseDetailPlan : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        public DateTime MMJobTicketFromDate { get; set; }
        public DateTime MMJobTicketToDate { get; set; }
        public int HRDepartmentRoomGroupItemID { get; set; }
        public int MMLineID { get; set; }
        public int MMWorkShopID { get; set; }
        public int MMOperationID { get; set; }
        public BOSList<MMJobTicketItemsInfo> SelectList { get; set; }
        public List<MMOperationDetailPlanItemChildsInfo> FromList { get; set; }
        public List<HREmployeesInfo> EmployeeList { get; set; }
        public guiChooseDetailPlan()
        {
            InitializeComponent();
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

        private void guiChooseDetailPlan_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            FromList = new List<MMOperationDetailPlanItemChildsInfo>();
            SelectList = new BOSList<MMJobTicketItemsInfo>();
            EmployeeList = new List<HREmployeesInfo>();
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.DetailPlanList.InitBOSListGridControl(fld_dgcMMOperationDetailPlanItemChildsGridControl);
            entity.DetailPlanList.ItemTableName = "MMOperationDetailPlanItemChilds";
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;

            SelectList.InitBOSListGridControl(fld_dgcMMJobTicketItemSelecteds);
            SelectList.ItemTableName = "MMJobTicketItems";
            GridView selectView = (GridView)fld_dgcMMJobTicketItemSelecteds.MainView;
            selectView.OptionsView.ShowAutoFilterRow = true;
            fld_dgcMMJobTicketItemSelecteds.DataSource = SelectList;
            try
            {
                fld_dteMMJobTicketFromDate.DateTime =
                DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy") + " " +
                                                DateTime.Now.ToString("07:30"), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                fld_dteMMJobTicketToDate.DateTime = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy") + " " +
                                                DateTime.Now.ToString("17:00"), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            }
            catch
            {
                fld_dteMMJobTicketFromDate.DateTime = DateTime.Now;
                fld_dteMMJobTicketToDate.DateTime = DateTime.Now;
            }
            if (MMWorkShopID > 0)
                fld_lkeMMWorkShopID.EditValue = MMWorkShopID;
            if (MMLineID > 0)
                fld_lkeFK_MMLineID.EditValue = MMLineID;
            if (MMOperationID > 0)
                fld_lkeFK_MMOperationID.EditValue = MMOperationID;
            if (HRDepartmentRoomGroupItemID > 0)
                fld_lkeHRDepartmentRoomGroupItemID.EditValue = HRDepartmentRoomGroupItemID;

            fld_dteMMDate.DateTime = DateTime.Now;

            //GridView employeeView = (GridView)fld_dgcHREmployees.MainView;
            //employeeView.OptionsView.ShowAutoFilterRow = true;


        }

        private void fld_chkSelectAllJobTicketItemChildOperation_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSelectAllJobTicketItemChildOperation.Checked);
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            String keyWord = String.Empty;
            HRDepartmentRoomGroupItemID = fld_lkeHRDepartmentRoomGroupItemID.EditValue != null ? int.Parse(fld_lkeHRDepartmentRoomGroupItemID.EditValue.ToString()) : 0;
            MMLineID = fld_lkeFK_MMLineID.EditValue != null ? int.Parse(fld_lkeFK_MMLineID.EditValue.ToString()) : 0;
            MMWorkShopID = fld_lkeMMWorkShopID.EditValue != null ? int.Parse(fld_lkeMMWorkShopID.EditValue.ToString()) : 0;
            MMOperationID = fld_lkeFK_MMOperationID.EditValue != null ? int.Parse(fld_lkeFK_MMOperationID.EditValue.ToString()) : 0;
            int batchID = fld_lkeMMBatchProductID.EditValue != null ? int.Parse(fld_lkeMMBatchProductID.EditValue.ToString()) : 0;
            int productForbatchID = fld_lkeICProductForBatchID.EditValue != null ? int.Parse(fld_lkeICProductForBatchID.EditValue.ToString()) : 0;
            int semiProductID = fld_lkeICProductID.EditValue != null ? int.Parse(fld_lkeICProductID.EditValue.ToString()) : 0;
            DateTime date = fld_dteMMDate.DateTime;
            string planNo = fld_txtMMOperationDetailPlanNo.EditValue != null ? fld_txtMMOperationDetailPlanNo.EditValue.ToString().TrimEnd() : string.Empty;

            FromList = ((JobTicketModule)Module).GetPlanDetailRemain(batchID
                                                                        , planNo
                                                                        , date
                                                                        , MMWorkShopID
                                                                        , MMLineID
                                                                        , HRDepartmentRoomGroupItemID
                                                                        , MMOperationID
                                                                        , productForbatchID
                                                                        , semiProductID
                                                                        );

            entity.DetailPlanList.Clear();
            entity.DetailPlanList.AddRange(FromList);
            fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = FromList;
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();


        }

        public void GetDataEmployee(MMJobTicketItemsInfo selected)
        {
            JobTicketEntities entity = (JobTicketEntities)(this.Module as BaseModuleERP).CurrentModuleEntity;
            List<string> roomIDList = new List<string>();
            roomIDList.Add(selected.FK_HRDepartmentRoomGroupItemID.ToString());
            if (roomIDList != null && roomIDList.Count > 0)
            {
                guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
                guiSearchEmployee.Module = Module;
                guiSearchEmployee.roomIDList = roomIDList;
                guiSearchEmployee.TicketEmployeeSelectedList =
                    entity.JobTicketItemEmployeeList.Where(ep => ep.MMJobTicketItemEmployeeAbstract == selected.MMJobTicketItemAbstractID
                                                        && ep.FK_MMOperationDetailPlanItemChildID == selected.FK_MMOperationDetailPlanItemChildID).ToList();
                if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
                {

                    List<MMJobTicketItemEmployeesInfo> unSelected =
                        entity.JobTicketItemEmployeeList.Where(ep => ep.MMJobTicketItemEmployeeAbstract == selected.MMJobTicketItemAbstractID
                                        && ep.FK_MMOperationDetailPlanItemChildID == selected.FK_MMOperationDetailPlanItemChildID).ToList();
                    if (unSelected != null && unSelected.Count > 0)
                    {
                        unSelected.ForEach(u =>
                        {
                            HREmployeesInfo selectEmployee = guiSearchEmployee.SelectedEmployeeList.Where(s => s.HREmployeeID == u.FK_HREmployeeID).FirstOrDefault();
                            if (selectEmployee == null)
                            {
                                int iIndex = entity.JobTicketItemEmployeeList.IndexOf(u);
                                if (iIndex >= 0)
                                    entity.JobTicketItemEmployeeList.RemoveAt(iIndex);
                            }
                        });
                    }

                    foreach (HREmployeesInfo objEmployeesInfo in guiSearchEmployee.SelectedEmployeeList)
                    {
                        // Nhân công chỉ phân bổ vào thẻ có cùng tổ
                        if (selected.MMJobTicketItemAbstractID > 0)
                        {
                            if (entity.JobTicketItemEmployeeList.Where(ep => ep.FK_HREmployeeID == objEmployeesInfo.HREmployeeID
                                                                        && ep.MMJobTicketItemEmployeeAbstract == selected.MMJobTicketItemAbstractID
                                                                        && ep.FK_MMOperationDetailPlanItemChildID == selected.FK_MMOperationDetailPlanItemChildID).FirstOrDefault() == null)
                            {
                                MMJobTicketItemEmployeesInfo epl = new MMJobTicketItemEmployeesInfo();
                                epl.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                epl.MMJobTicketItemEmployeeAbstract = selected.MMJobTicketItemAbstractID;
                                epl.FK_MMOperationDetailPlanItemChildID = selected.FK_MMOperationDetailPlanItemChildID;
                                epl.FK_MMJobTicketItemID = selected.MMJobTicketItemID;
                                entity.JobTicketItemEmployeeList.Add(epl);
                            }
                        }
                    }
                }
            }

        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
            List<MMOperationDetailPlanItemChildsInfo> listView = new List<MMOperationDetailPlanItemChildsInfo>();

            List<MMOperationDetailPlanItemChildsInfo> objects = new List<MMOperationDetailPlanItemChildsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMOperationDetailPlanItemChildsInfo objDataViewPermissionsInfo = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo objDataViewPermissionsInfo = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
        }
        public void CheckedAllJobTicket(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcMMJobTicketItemSelecteds.MainView;
            List<MMJobTicketItemsInfo> listView = new List<MMJobTicketItemsInfo>();

            List<MMJobTicketItemsInfo> objects = new List<MMJobTicketItemsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(j);
                if (obj != null)
                {
                    objects.Add(obj);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(j);
                    if (obj != null)
                    {
                        listView.Add(obj);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
            fld_dgcMMJobTicketItemSelecteds.RefreshDataSource();
        }
        private void fld_btnForward_Click(object sender, EventArgs e)
        {
            JobTicketEntities entity = (JobTicketEntities)(this.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
            int iRowHandle = gridView.FocusedRowHandle;
            List<MMJobTicketItemsInfo> tempSelectList = new List<MMJobTicketItemsInfo>();
            if (iRowHandle >= 0 && FromList.Where(o => o.Selected).FirstOrDefault() == null)
            {
                MMOperationDetailPlanItemChildsInfo fromItem = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(iRowHandle);
                if (fromItem != null)
                {
                    if (!SelectList.Exists("FK_MMOperationDetailPlanItemChildID", fromItem.MMOperationDetailPlanItemChildID))
                    {
                        MMJobTicketItemsInfo item = new MMJobTicketItemsInfo();
                        BOSUtil.CopyObject(fromItem, item);
                        item.FK_MMOperationDetailPlanItemChildID = fromItem.MMOperationDetailPlanItemChildID;
                        item.MMJobTicketItemPlanQty = fromItem.MMOperationDetailPlanItemChildPlanProductQty;
                        item.MMJobTicketItemPlanReceiptQty = fromItem.MMJobTicketItemPlanReceiptQty;
                        item.MMJobTicketItemDeliveryQty = fromItem.MMJobTicketItemDeliveryQty;
                        item.MMJobTicketItemExecutionMaxDate = fromItem.MMJobTicketItemExecutionMaxDate;
                        item.MMJobTicketItemStatus = Status.New.ToString();
                        item.MMJobTicketItemExecutionFromDate = fld_dteMMJobTicketFromDate.DateTime;
                        item.MMJobTicketItemExecutionToDate = fld_dteMMJobTicketToDate.DateTime;
                        item.Selected = false;
                        int rand = ((JobTicketModule)(this.Module)).RandomNumber(1, 1000, item, tempSelectList);
                        item.MMJobTicketItemAbstractID = rand;
                        tempSelectList.Add(item);
                        //
                        int iIndex = FromList.IndexOf(fromItem);
                        if (iIndex >= 0)
                            FromList.RemoveAt(iIndex);

                    }
                }
            }
            else
            {
                FromList.ForEach(o =>
                {
                    if (o.Selected)
                    {
                        MMJobTicketItemsInfo item = new MMJobTicketItemsInfo();
                        BOSUtil.CopyObject(o, item);
                        item.FK_MMOperationDetailPlanItemChildID = o.MMOperationDetailPlanItemChildID;
                        item.MMJobTicketItemPlanQty = o.MMOperationDetailPlanItemChildPlanProductQty;
                        item.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                        item.MMJobTicketItemDeliveryQty = o.MMJobTicketItemDeliveryQty;
                        item.MMJobTicketItemExecutionMaxDate = o.MMJobTicketItemExecutionMaxDate;
                        item.MMJobTicketItemStatus = Status.New.ToString();
                        item.MMJobTicketItemExecutionFromDate = fld_dteMMJobTicketFromDate.DateTime;
                        item.MMJobTicketItemExecutionToDate = fld_dteMMJobTicketToDate.DateTime;
                        item.Selected = false;
                        int rand = ((JobTicketModule)(this.Module)).RandomNumber(1, 1000, item, tempSelectList);
                        item.MMJobTicketItemAbstractID = rand;
                        tempSelectList.Add(item);
                    }
                });
                FromList = FromList.Where(o => o.Selected == false).ToList();
            }

            List<string> roomIDList = tempSelectList.Select(i => i.FK_HRDepartmentRoomGroupItemID.ToString()).Distinct().ToList();
            if (roomIDList != null && roomIDList.Count > 0)
            {
                guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
                guiSearchEmployee.Module = Module;
                guiSearchEmployee.roomIDList = roomIDList;
                if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
                {
                    if (tempSelectList.Count > 0)
                    {
                        foreach (HREmployeesInfo objEmployeesInfo in guiSearchEmployee.SelectedEmployeeList)
                        {
                            // Nhân công chỉ phân bổ vào thẻ có cùng tổ
                            //List<MMJobTicketItemsInfo> jobItemList = tempSelectList.Where(o => o.FK_HRDepartmentRoomGroupItemID == objEmployeesInfo.FK_HRDepartmentRoomGroupItemID).ToList();
                            //=> cho phép chọn khác tổ
                            List<MMJobTicketItemsInfo> jobItemList = tempSelectList.ToList();
                            if (jobItemList != null && jobItemList.Count > 0)
                            {
                                jobItemList.ForEach(o =>
                                {
                                    if (o.MMJobTicketItemAbstractID > 0)
                                    {
                                        if (entity.JobTicketItemEmployeeList.Where(ep => ep.FK_HREmployeeID == objEmployeesInfo.HREmployeeID
                                                                                    && ep.MMJobTicketItemEmployeeAbstract == o.MMJobTicketItemAbstractID
                                                                                    && ep.FK_MMOperationDetailPlanItemChildID == o.FK_MMOperationDetailPlanItemChildID).FirstOrDefault() == null)
                                        {
                                            MMJobTicketItemEmployeesInfo epl = new MMJobTicketItemEmployeesInfo();
                                            epl.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                            epl.MMJobTicketItemEmployeeAbstract = o.MMJobTicketItemAbstractID;
                                            epl.FK_MMOperationDetailPlanItemChildID = o.FK_MMOperationDetailPlanItemChildID;
                                            epl.FK_MMJobTicketItemID = o.MMJobTicketItemID;
                                            entity.JobTicketItemEmployeeList.Add(epl);
                                        }
                                    }
                                });
                            }

                        }

                    }

                }
            }

            if (tempSelectList != null && tempSelectList.Count > 0)
                SelectList.AddRange(tempSelectList);

            fld_dgcMMJobTicketItemSelecteds.RefreshDataSource();
            fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = FromList;
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
        }
        private void fld_btnBackward_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcMMJobTicketItemSelecteds.MainView;
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int iRowHandle = gridView.FocusedRowHandle;
            if (iRowHandle >= 0 && SelectList.Where(x => x.Selected).Count() == 0)
            {
                MMJobTicketItemsInfo item = (MMJobTicketItemsInfo)gridView.GetRow(iRowHandle);
                if (item != null)
                {
                    int iIndex = SelectList.IndexOf(item);
                    if (iIndex >= 0)
                    {
                        SelectList.RemoveAt(iIndex);
                        RemoveEmployeeFromListByTicket(item);

                    }
                    MMOperationDetailPlanItemChildsInfo fromItem = entity.DetailPlanList.Where(o => o.MMOperationDetailPlanItemChildID == item.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if (fromItem != null)
                    {
                        int iEIndex = FromList.IndexOf(fromItem);
                        fromItem.Selected = false;
                        if (iEIndex < 0)
                            FromList.Add(fromItem);
                    }
                }
            }
            else if (SelectList.Where(x => x.Selected).Count() > 0)
            {
                SelectList.ForEach(s =>
                {
                    if (s.Selected)
                    {
                        MMOperationDetailPlanItemChildsInfo fromItem = entity.DetailPlanList.Where(o => o.MMOperationDetailPlanItemChildID == s.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                        if (fromItem != null)
                        {
                            int iEIndex = FromList.IndexOf(fromItem);
                            fromItem.Selected = false;
                            if (iEIndex < 0)
                                FromList.Add(fromItem);
                        }
                        RemoveEmployeeFromListByTicket(s);
                    }
                });
                SelectList.Invalidate(SelectList.Where(x => !x.Selected).ToList());
            }

            fld_dgcMMJobTicketItemSelecteds.RefreshDataSource();
            fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = FromList;
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
        }
        public void RemoveEmployeeFromListByTicket(MMJobTicketItemsInfo item)
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            if (item != null && item.MMJobTicketItemAbstractID > 0)
            {
                List<MMJobTicketItemEmployeesInfo> exitList = entity.JobTicketItemEmployeeList.Where(ep => ep.MMJobTicketItemEmployeeAbstract == item.MMJobTicketItemAbstractID
                                                                                       && ep.FK_MMOperationDetailPlanItemChildID == item.FK_MMOperationDetailPlanItemChildID).ToList();
                exitList.ForEach(ex =>
                {
                    int iIdex = entity.JobTicketItemEmployeeList.IndexOf(ex);
                    if (iIdex >= 0)
                    {
                        entity.JobTicketItemEmployeeList.RemoveAt(iIdex);
                    }
                });
            }
        }
        private void fld_btnJobQty_Click(object sender, EventArgs e)
        {
            if (fld_txtQty.Text == null) return;
            decimal sL = 0;
            decimal.TryParse(fld_txtQty.Text.TrimEnd(), out sL);

            bool isError = false;
            if (SelectList.Where(o => o.Selected).Count() > 0)
            {
                if (sL > 0 && BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                {
                    SelectList.ForEach(o => { if (o.Selected && o.MMJobTicketItemPlanQty - o.MMJobTicketItemDeliveryQty < sL) { o.IsError = true; isError = true; } });
                    if (isError)
                    {
                        BOSApp.ShowMessage("SL cập nhật thẻ vượt SL min có thể giao");
                        return;
                    }
                    SelectList.ForEach(o => { if (o.Selected) { o.MMJobTicketItemTodoQty = sL; } });
                    fld_dgcMMJobTicketItemSelecteds.RefreshDataSource();
                }
            }
            else
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
        }

        private void fld_txtQty_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            SelectList.ForEach(o => o.IsError = false);
            fld_dgcMMJobTicketItemSelecteds.RefreshDataSource();
        }

        private void fld_btnNotJetticket_Click(object sender, EventArgs e)
        {
            SearchData("NotJetticket");
        }
        private void fld_lblNotJetticket_Click(object sender, EventArgs e)
        {
            SearchData("NotJetticket");
        }


        private void fld_btnALittleDeliveryTicket_Click(object sender, EventArgs e)
        {
            SearchData("ALittleDeliveryTicket");
        }

        private void fld_lblALittleDeliveryTicket_Click(object sender, EventArgs e)
        {
            SearchData("ALittleDeliveryTicket");
        }

        private void fld_btnComplete_Click(object sender, EventArgs e)
        {
            SearchData("Complete");
        }
        private void fld_lblComplete_Click(object sender, EventArgs e)
        {
            SearchData("Complete");
        }

        private void fld_btnLateJobTicket_Click(object sender, EventArgs e)
        {
            SearchData("LateJobTicket");
        }
        private void fld_lblLateJobTicket_Click(object sender, EventArgs e)
        {
            SearchData("LateJobTicket");
        }

        private void fld_btnAll_Click(object sender, EventArgs e)
        {
            SearchData("All");
        }

        private void fld_lblAll_Click(object sender, EventArgs e)
        {
            SearchData("All");
        }

        public void FilterData()
        {
            JobTicketEntities entity = (JobTicketEntities)(this.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;

            List<GridColumn> lstColVisible = new List<GridColumn>();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                {
                    lstColVisible.Add(gridView.Columns[i]);
                }
            }
            List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();

            //Bind object list to grid for searching
            fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = FromList;
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();

            for (int i = 0; i < FromList.Count; i++)
            {
                MMOperationDetailPlanItemChildsInfo obj = FromList[i];
                if (obj.MMJobTicketItemTodoQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                    if (fld_chkNotJetticket.Checked && bindingList.IndexOf(obj) <= 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                else if (obj.MMJobTicketItemTodoQty < obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty
                        && obj.MMJobTicketItemTodoQty > 0)
                    if (fld_chkALittleDeliveryTicket.Checked && bindingList.IndexOf(obj) <= 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                else if (obj.MMJobTicketItemPlanReceiptQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                    if (fld_chkComplete.Checked && bindingList.IndexOf(obj) <= 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }

            }
            fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = bindingList;
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();

        }

        public void SearchData(String keyWord)
        {

            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();

                //Bind object list to grid for searching
                fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = FromList;
                fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();

                for (int i = 0; i < FromList.Count; i++)
                {
                    MMOperationDetailPlanItemChildsInfo obj = FromList[i];
                    bool isExist = IsTypeFilter(keyWord, obj);
                    if (isExist)
                    {
                        bindingList.Add(obj);
                    }
                }
                fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = bindingList;
                fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = FromList;
                fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
            }
        }
        public bool IsExistKeyWord(String value, String keyWord)
        {
            value = value.ToLower();
            keyWord = keyWord.ToLower();
            String[] arrElement = keyWord.Split(new char[] { ' ' });
            bool isExist = false;
            foreach (String element in arrElement)
            {
                if (value.Contains(element))
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                value = BOSUtil.ConvertUnicodeStringToUnSign(value);
                foreach (String element in arrElement)
                {
                    if (value.Contains(element))
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }
        public bool IsTypeFilter(string type, MMOperationDetailPlanItemChildsInfo obj)
        {
            bool result = false;
            switch (type)
            {
                case "NotJetticket":
                    if (obj.MMJobTicketItemTodoQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                        result = true;
                    break;
                case "ALittleDeliveryTicket":
                    if (obj.MMJobTicketItemTodoQty < obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty
                        && obj.MMJobTicketItemTodoQty > 0)
                        result = true;
                    break;
                case "Complete":
                    if (obj.MMJobTicketItemPlanReceiptQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                        result = true;
                    break;
                case "LateJobTicket":
                    DateTime serverDate = BOSApp.GetCurrentServerDate();
                    if (obj.MMOperationDetailPlanItemChildExecutionToDate.Date <= serverDate.Date
                       //tạm thời sài  SL da nhap theo KH
                       && obj.MMJobTicketItemPlanReceiptQty <= obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                        result = true;
                    break;
                case "All":
                    result = true;
                    if (!fld_chkALittleDeliveryTicket.Checked)
                    {
                        if (obj.MMJobTicketItemTodoQty < obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty
                        && obj.MMJobTicketItemTodoQty > 0)
                            result = false;
                    }
                    if (!fld_chkNotJetticket.Checked)
                    {
                        if (obj.MMJobTicketItemTodoQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                            result = false;
                    }
                    if (!fld_chkComplete.Checked)
                    {
                        if (obj.MMJobTicketItemPlanReceiptQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                            result = false;
                    }

                    break;
                default:
                    break;
            }
            return result;
        }

        private void fld_btnUpdateJobTicketDate_Click(object sender, EventArgs e)
        {

            if (SelectList.Where(o => o.Selected).Count() > 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                {
                    SelectList.ForEach(o =>
                    {
                        if (o.Selected)
                        {
                            o.MMJobTicketItemExecutionFromDate = fld_dteMMJobTicketFromDate.DateTime;
                            o.MMJobTicketItemExecutionToDate = fld_dteMMJobTicketToDate.DateTime;
                        }
                    });
                    fld_dgcMMJobTicketItemSelecteds.RefreshDataSource();
                }
            }
            else
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
        }
        private void fld_chkJobSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllJobTicket(fld_chkJobSelectAll.Checked);
        }
        private void fld_chkNotJetticket_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        private void fld_chkALittleDeliveryTicket_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        private void fld_chkComplete_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        private void fld_lblSelectAll_Click(object sender, EventArgs e)
        {
            fld_chkNotJetticket.Checked = true;
            fld_chkALittleDeliveryTicket.Checked = true;
            fld_chkComplete.Checked = true;
            FilterData();
        }
        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom();
            //host.FormBorderStyle = FormBorderStyle.Fixed3D;
            //host.WindowState = FormWindowState.Maximized;
            //host.ShowInTaskbar = true;
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            var anchor = ctl.Anchor;
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }

        private void fld_btnZOPDP_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcMMOperationDetailPlanItemChildsGridControl);
        }
        private void fld_btnZJobticket_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcMMJobTicketItemSelecteds);
        }

        private void fld_btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (SelectList.Where(o => o.Selected).Count() > 0)
                ((JobTicketModule)this.Module).UpdateEmployee(SelectList, false);
            else
                BOSApp.ShowMessage("Vui lòng chọn thẻ ");
        }


    }
}
