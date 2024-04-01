using BOSCommon;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.OperationDetailPlan.UI
{
    /// <summary>
    /// Summary description for DMODPS100
    /// </summary>
    public partial class DMODPS100 : BOSERPScreen
    {

        public DMODPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMODPS100_Load(object sender, EventArgs e)
        {
            //fld_dteMMOperationDetailPlanFromDate.DateTime = DateTime.Now;
            //fld_dteMMOperationDetailPlanToDate.DateTime = DateTime.Now;
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OperationDetailPlanModule)Module).ChangeWorkShopToItem(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMLineID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OperationDetailPlanModule)Module).ChangeLineToItem(Convert.ToInt32(e.Value));
            }
        }
        private void fld_btnAddDetail_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowBatchProductProducttionItem();
        }

        private void Fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).CheckedAllByFilterItem(fld_chkSelectAllPlan.Checked);
        }

        private void Fld_btnUpdatePosition_Click(object sender, EventArgs e)
        {
            int workShopID = fld_lkeFK_MMWorkShopID.EditValue != null ? int.Parse(fld_lkeFK_MMWorkShopID.EditValue.ToString()) : 0;
            int lineID = fld_lkeFK_MMLineID.EditValue != null ? int.Parse(fld_lkeFK_MMLineID.EditValue.ToString()) : 0;
            int groupID = 0;
            if (workShopID == 0)
            {
                MessageBox.Show("Vui lòng chọn xưởng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lineID > 0)
            {
                DataRow row = BOSApp.GetObjectFromCatche("MMLines", "MMLineID", lineID);
                MMLinesInfo lineInfo = new MMLinesInfo();
                if (row != null)
                    lineInfo = (MMLinesInfo)(new MMLinesController()).GetObjectFromDataRow(row);
                if (lineInfo != null && lineInfo.MMLineID > 0 && lineInfo.FK_MMWorkShopID != workShopID)
                {
                    MessageBox.Show("Chuyền không thuộc xưởng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            ((OperationDetailPlanModule)Module).UpdateBatchPosition(workShopID, lineID, groupID);
        }

        private void Fld_btnUpdatePlanDate_Click(object sender, EventArgs e)
        {
            //if (fld_dteFromDate.DateTime.Date < fld_dteMMOperationDetailPlanFromDate.DateTime.Date || fld_dteToDate.DateTime.Date < fld_dteMMOperationDetailPlanFromDate.DateTime.Date)
            //{
            //    MessageBox.Show("Giá trị bạn chọn nhỏ hơn \"từ ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (fld_dteToDate.DateTime.Date > fld_dteMMOperationDetailPlanToDate.DateTime.Date || fld_dteFromDate.DateTime.Date > fld_dteMMOperationDetailPlanToDate.DateTime.Date)
            //{
            //    MessageBox.Show("Giá trị bạn chọn lớn hơn \"đến ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            ((OperationDetailPlanModule)Module).UpdatePlanDate(fld_dteFromDate.DateTime, fld_dteToDate.DateTime);
        }

        private void Fld_bedMMOperationDetailPlanWeek_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowChooseWeek();
        }
        private void Fld_bedMMOperationDetailPlanWeek_EditValueChanged(object sender, EventArgs e)
        {
            //((OperationDetailPlanModule)Module).GetPlanDateByWeek(fld_bedMMOperationDetailPlanWeek.Text);
        }

        private void Fld_dteMMOperationDetailPlanFromDate_Validated(object sender, EventArgs e)
        {
            if (fld_dteFromDate.OldEditValue != fld_dteFromDate.EditValue)
            {
                fld_dteFromDate.DateTime = new DateTime(fld_dteMMOperationDetailPlanFromDate.DateTime.Year
                                                        , fld_dteMMOperationDetailPlanFromDate.DateTime.Month
                                                        , fld_dteMMOperationDetailPlanFromDate.DateTime.Day, 7, 30, 0);
                //DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                //Calendar cal = dfi.Calendar;
                //string weekOfFrom = cal.GetWeekOfYear(fld_dteMMOperationDetailPlanFromDate.DateTime, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
                //string weekOfTo = cal.GetWeekOfYear(fld_dteMMOperationDetailPlanToDate.DateTime, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
                //int weekFrom = 0;
                //int weekTo = 0;
                //int.TryParse(weekOfFrom, out weekFrom);
                //int.TryParse(weekOfTo, out weekTo);
                //if (weekFrom > weekTo)
                //    fld_bedMMOperationDetailPlanWeek.Text = weekOfFrom;
                //else if(weekTo > weekFrom)
                //    fld_bedMMOperationDetailPlanWeek.Text = weekOfTo;
                //else
                //    fld_bedMMOperationDetailPlanWeek.Text = weekOfFrom;
            }
        }

        private void Fld_dteMMOperationDetailPlanToDate_Validated(object sender, EventArgs e)
        {
            if (fld_dteToDate.OldEditValue != fld_dteToDate.EditValue)
            {
                fld_dteToDate.DateTime = new DateTime(fld_dteMMOperationDetailPlanToDate.DateTime.Year
                                                        , fld_dteMMOperationDetailPlanToDate.DateTime.Month
                                                        , fld_dteMMOperationDetailPlanToDate.DateTime.Day, 7, 30, 0);
                //DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                //Calendar cal = dfi.Calendar;
                //string weekOfFrom = cal.GetWeekOfYear(fld_dteMMOperationDetailPlanFromDate.DateTime, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
                //string weekOfTo = cal.GetWeekOfYear(fld_dteMMOperationDetailPlanToDate.DateTime, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
                //int weekFrom = 0;
                //int weekTo = 0;
                //int.TryParse(weekOfFrom, out weekFrom);
                //int.TryParse(weekOfTo, out weekTo);
                //if (weekFrom > weekTo)
                //    fld_bedMMOperationDetailPlanWeek.Text = weekOfFrom;
                //else if (weekTo > weekFrom)
                //    fld_bedMMOperationDetailPlanWeek.Text = weekOfTo;
                //else
                //    fld_bedMMOperationDetailPlanWeek.Text = weekOfFrom;
            }
        }
        private void Fld_btnZoomHuman_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_spcHuman);
        }
        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom();
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
        #region Get TreeHumanData
        private void Fld_lkeHumanHRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            bool check = fld_chkHumanNotTicket.Checked;
            int departmentID = 0;
            if (fld_lkeHumanHRDepartmentID.EditValue != null)
                int.TryParse(fld_lkeHumanHRDepartmentID.EditValue.ToString(), out departmentID);
            if (((OperationDetailPlanModule)Module).OperationHumanSelect == null) ((OperationDetailPlanModule)Module).OperationHumanSelect = new System.Collections.Generic.List<MMOperationsInfo>();
            string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            ((OperationDetailPlanModule)Module).GetTreeHumanDataSource(check, operationID, departmentID);
        }
        private void Fld_chkAllHuman_CheckedChanged(object sender, EventArgs e)
        {
            bool check = fld_chkHumanNotTicket.Checked;
            int departmentID = 0;
            if (fld_lkeHumanHRDepartmentID.EditValue != null)
                int.TryParse(fld_lkeHumanHRDepartmentID.EditValue.ToString(), out departmentID);
            if (((OperationDetailPlanModule)Module).OperationHumanSelect == null) ((OperationDetailPlanModule)Module).OperationHumanSelect = new System.Collections.Generic.List<MMOperationsInfo>();
            string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            ((OperationDetailPlanModule)Module).GetTreeHumanDataSource(check, operationID, departmentID);
        }
        #endregion
        #region FilterDetailPlanHumanGrid
        private void Fld_ckeDetailPlanHumanAllowcation_CheckedChanged(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanModule)Module).IsFocusHumanChange)
            {
                bool checkDetailPlanHumanAllowcation = fld_ckeDetailPlanHumanAllowcation.Checked;
                fld_chkAllHumanDetailPlanItem.Checked = !checkDetailPlanHumanAllowcation;
                bool checkAllHumanDetailPlanItem = fld_chkAllHumanDetailPlanItem.Checked;
                bool checkHumanPlanByOperation = fld_ckeHumanPlanByOperation.Checked;
                if (((OperationDetailPlanModule)Module).OperationHumanSelect == null) ((OperationDetailPlanModule)Module).OperationHumanSelect = new System.Collections.Generic.List<MMOperationsInfo>();
                string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                ((OperationDetailPlanModule)Module).FilterDetailPlanHumanGrid(checkDetailPlanHumanAllowcation, checkAllHumanDetailPlanItem, checkHumanPlanByOperation, operationID, null);
            }
        }

        private void Fld_chkAllHumanDetailPlanItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanModule)Module).IsFocusHumanChange)
            {

                bool checkAllHumanDetailPlanItem = fld_chkAllHumanDetailPlanItem.Checked;
                fld_ckeDetailPlanHumanAllowcation.Checked = !checkAllHumanDetailPlanItem;
                bool checkDetailPlanHumanAllowcation = fld_ckeDetailPlanHumanAllowcation.Checked;
                bool checkHumanPlanByOperation = fld_ckeHumanPlanByOperation.Checked;
                if (((OperationDetailPlanModule)Module).OperationHumanSelect == null) ((OperationDetailPlanModule)Module).OperationHumanSelect = new System.Collections.Generic.List<MMOperationsInfo>();
                string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                ((OperationDetailPlanModule)Module).FilterDetailPlanHumanGrid(checkDetailPlanHumanAllowcation, checkAllHumanDetailPlanItem, checkHumanPlanByOperation, operationID, null);
            }
        }

        private void Fld_ckeHumanPlanByOperation_CheckedChanged(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanModule)Module).IsFocusHumanChange)
            {
                bool checkDetailPlanHumanAllowcation = fld_ckeDetailPlanHumanAllowcation.Checked;
                bool checkAllHumanDetailPlanItem = fld_chkAllHumanDetailPlanItem.Checked;
                bool checkHumanPlanByOperation = fld_ckeHumanPlanByOperation.Checked;
                if (((OperationDetailPlanModule)Module).OperationHumanSelect == null) ((OperationDetailPlanModule)Module).OperationHumanSelect = new System.Collections.Generic.List<MMOperationsInfo>();
                string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                ((OperationDetailPlanModule)Module).FilterDetailPlanHumanGrid(checkDetailPlanHumanAllowcation, checkAllHumanDetailPlanItem, checkHumanPlanByOperation, operationID, null);
            }
        }
        #endregion
        #region Get TreeMachineData

        private void Fld_lkeMMWorshopID_EditValueChanged(object sender, EventArgs e)
        {
            bool check = fld_ckeMachineNotTicket.Checked;
            int workShopID = 0;
            if (fld_lkeMMWorshopID.EditValue != null)
                int.TryParse(fld_lkeMMWorshopID.EditValue.ToString(), out workShopID);
            if (((OperationDetailPlanModule)Module).OperationMachineSelect == null) ((OperationDetailPlanModule)Module).OperationMachineSelect = new System.Collections.Generic.List<MMOperationsInfo>();
            string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());

            ((OperationDetailPlanModule)Module).GetTreeMachineDataSource(check, operationID, workShopID);
        }
        private void Fld_ckeMachineNotTicket_CheckedChanged(object sender, EventArgs e)
        {
            bool check = fld_ckeMachineNotTicket.Checked;
            int workShopID = 0;
            if (fld_lkeMMWorshopID.EditValue != null)
                int.TryParse(fld_lkeMMWorshopID.EditValue.ToString(), out workShopID);
            if (((OperationDetailPlanModule)Module).OperationMachineSelect == null) ((OperationDetailPlanModule)Module).OperationMachineSelect = new System.Collections.Generic.List<MMOperationsInfo>();
            string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());

            ((OperationDetailPlanModule)Module).GetTreeMachineDataSource(check, operationID, workShopID);
        }
        #endregion
        #region FilterDetailPlanMachineGrid
        private void Fld_ckeTicketNothaveMachine_CheckedChanged(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanModule)Module).IsFocusMachineChange)
            {
                bool checkNothaveMachine = fld_ckeTicketNothaveMachine.Checked;
                fld_TicketHaveMachine.Checked = !checkNothaveMachine;
                bool checkTicketHaveMachine = fld_TicketHaveMachine.Checked;
                bool checkMachinePlanByOperation = fld_ckeTicketByOperation.Checked;
                int workShopID = 0;
                if (fld_lkeMMWorshopID.EditValue != null)
                    int.TryParse(fld_lkeMMWorshopID.EditValue.ToString(), out workShopID);
                if (((OperationDetailPlanModule)Module).OperationMachineSelect == null) ((OperationDetailPlanModule)Module).OperationMachineSelect = new System.Collections.Generic.List<MMOperationsInfo>();
                string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                ((OperationDetailPlanModule)Module).FilterDetailPlanMachineGrid(checkNothaveMachine, checkTicketHaveMachine, checkMachinePlanByOperation, operationID, workShopID, null);
            }
        }

        private void Fld_TicketHaveMachine_CheckedChanged(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanModule)Module).IsFocusMachineChange)
            {
                bool checkTicketHaveMachine = fld_TicketHaveMachine.Checked;
                fld_ckeTicketNothaveMachine.Checked = !checkTicketHaveMachine;
                bool checkNothaveMachine = fld_ckeTicketNothaveMachine.Checked;
                bool checkMachinePlanByOperation = fld_ckeTicketByOperation.Checked;
                int workShopID = 0;
                if (fld_lkeMMWorshopID.EditValue != null)
                    int.TryParse(fld_lkeMMWorshopID.EditValue.ToString(), out workShopID);
                if (((OperationDetailPlanModule)Module).OperationMachineSelect == null) ((OperationDetailPlanModule)Module).OperationMachineSelect = new System.Collections.Generic.List<MMOperationsInfo>();
                string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                ((OperationDetailPlanModule)Module).FilterDetailPlanMachineGrid(checkNothaveMachine, checkTicketHaveMachine, checkMachinePlanByOperation, operationID, workShopID, null);
            }
        }

        private void Fld_ckeTicketByOperation_CheckedChanged(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanModule)Module).IsFocusMachineChange)
            {
                bool checkNothaveMachine = fld_ckeTicketNothaveMachine.Checked;
                bool checkTicketHaveMachine = fld_TicketHaveMachine.Checked;
                bool checkMachinePlanByOperation = fld_ckeTicketByOperation.Checked;
                int workShopID = 0;
                if (fld_lkeMMWorshopID.EditValue != null)
                    int.TryParse(fld_lkeMMWorshopID.EditValue.ToString(), out workShopID);
                if (((OperationDetailPlanModule)Module).OperationMachineSelect == null) ((OperationDetailPlanModule)Module).OperationMachineSelect = new System.Collections.Generic.List<MMOperationsInfo>();
                string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                ((OperationDetailPlanModule)Module).FilterDetailPlanMachineGrid(checkNothaveMachine, checkTicketHaveMachine, checkMachinePlanByOperation, operationID, workShopID, null);
            }
        }
        #endregion
        private void Fld_btnZoomMachine_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_spcMachine);
        }

        private void Fld_btnAddHuman_Click(object sender, EventArgs e)
        {
            bool complete = ((OperationDetailPlanModule)Module).AddHumanToTicket();
            if (!complete) { fld_ckeSelectAllHumanticket.Checked = false; fld_ckeSelectAllHumanticket.Focus(); }
            //fld_ckeSelectAllHumanticket.Checked = false;
            //if (complete)
            //{
            //    fld_btnCancelHuman.Visible = true;
            //    //fld_ckeSelectAllHumanticket.Checked = false;

            //    bool checkDetailPlanHumanAllowcation = fld_ckeDetailPlanHumanAllowcation.Checked;
            //    bool checkAllHumanDetailPlanItem = fld_chkAllHumanDetailPlanItem.Checked;
            //    bool checkHumanPlanByOperation = fld_ckeHumanPlanByOperation.Checked;
            //    string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            //    ((OperationDetailPlanModule)Module).FilterDetailPlanHumanGrid(checkDetailPlanHumanAllowcation, checkAllHumanDetailPlanItem, checkHumanPlanByOperation, operationID, null);
            //}
        }

        private void Fld_btnAddMachine_Click(object sender, EventArgs e)
        {
            bool complete = ((OperationDetailPlanModule)Module).AddMachineToTicket();
            if (!complete) { fld_ckeAllMachineTicket.Checked = false; fld_ckeAllMachineTicket.Focus(); }
        }

        private void Fld_btnCancelMachine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn hủy chi tiết đã gán máy móc không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((OperationDetailPlanModule)Module).RefreshMachineToTicket();
                fld_dgcMachineDetailPlanItems.IsEdit = false;
                fld_ckeAllMachineTicket.Checked = false;
                fld_btnCancelMachine.Visible = false;
            }
        }

        private void Fld_btnCancelHuman_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn hủy chi tiết đã gán nhân viên không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((OperationDetailPlanModule)Module).RefreshHumanToTicket();
                fld_dgcHumanDetailPlanItems.IsEdit = false;
                fld_ckeSelectAllHumanticket.Checked = false;
                fld_btnCancelHuman.Visible = false;
            }
        }

        private void Fld_ckeSelectAllHumanticket_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).CheckAllHumanTicket(fld_ckeSelectAllHumanticket.Checked);
            ((OperationDetailPlanModule)Module).SetHumanTotalQty();
        }

        private void Fld_ckeAllMachineTicket_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).CheckAllMachineTicket(fld_ckeAllMachineTicket.Checked);
            ((OperationDetailPlanModule)Module).SetMachineTotalQty();
        }
        private void Fld_bteHumanOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowOperation(true, false);
            bool check = fld_chkHumanNotTicket.Checked;
            int departmentID = 0;
            if (fld_lkeHumanHRDepartmentID.EditValue != null)
                int.TryParse(fld_lkeHumanHRDepartmentID.EditValue.ToString(), out departmentID);
            if (((OperationDetailPlanModule)Module).OperationHumanSelect == null) ((OperationDetailPlanModule)Module).OperationHumanSelect = new System.Collections.Generic.List<MMOperationsInfo>();
            string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            ((OperationDetailPlanModule)Module).GetTreeHumanDataSource(check, operationID, departmentID);
        }

        private void Fld_bteMachineOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowOperation(false, false);
            bool check = fld_ckeMachineNotTicket.Checked;
            int workShopID = 0;
            if (fld_lkeMMWorshopID.EditValue != null)
                int.TryParse(fld_lkeMMWorshopID.EditValue.ToString(), out workShopID);
            if (((OperationDetailPlanModule)Module).OperationMachineSelect == null) ((OperationDetailPlanModule)Module).OperationMachineSelect = new System.Collections.Generic.List<MMOperationsInfo>();
            string operationID = string.Join(",", ((OperationDetailPlanModule)Module).OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            ((OperationDetailPlanModule)Module).GetTreeMachineDataSource(check, operationID, workShopID);
        }

        private void Fld_btnJobCreate_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).CreateJobTicket();
            fld_chkSelectAllPlan.Checked = false;
        }

        private void Fld_btnJobCancel_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            ((OperationDetailPlanModule)Module).CancelJobTicket(null, entity.OperationDetailPlanItemChildsList, true);
            fld_chkSelectAllPlan.Checked = false;
        }

        private void Fld_btnJobClose_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            ((OperationDetailPlanModule)Module).CloseJobTicket(entity.TicketDetailPlanItemsList);
            fld_chkSelectAllPlan.Checked = false;
        }
        private void Fld_chkStatusNew_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
               , fld_chkStatusCanceled.Checked
               , fld_chkStatusApproved.Checked
               , fld_chkStatusClosed.Checked
               , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
                , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
               );
        }
        private void Fld_btnTicketZoom_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_splTicket);
        }

        //private void Fld_lblFilterMachine_Click(object sender, EventArgs e)
        //{
        //    ((OperationDetailPlanModule)Module).ShowMachineUnit();
        //}

        private void Fld_lblAllticket_Click(object sender, EventArgs e)
        {
            fld_chkTicketRemain.Checked = false;
            fld_bteTicketHuman.Text = string.Empty;
            fld_bteTicketOperation.Text = string.Empty;
            ((OperationDetailPlanModule)Module).ShowAllTicket();

        }

        private void Fld_btnCapacityReceipt_Click(object sender, EventArgs e)
        {
            fld_dteCapacityFromDate.DateTime = DateTime.Now;
            fld_dteCapacityToDate.DateTime = DateTime.Now;
            ((OperationDetailPlanModule)Module).GetData(fld_dteCapacityFromDate.DateTime, fld_dteCapacityToDate.DateTime);
        }

        private void Fld_chkAllTicket_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).CheckAllTicket(fld_chkAllTicket.Checked);
        }

        private void Fld_btnSaveCapacity_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            List<MMOperationDetailPlanCapacityItemsInfo> CheckList = entity.CapacityDataList.Where(i => i.Selected).ToList();
            if (CheckList != null && CheckList.Count > 0)
            {
                if (((OperationDetailPlanModule)Module).SyncTicketItem(null, entity.CapacityDataList))
                {
                    ((OperationDetailPlanModule)Module).SaveTicketCapapcity();
                    fld_chkAllTicket.Checked = false;
                    ((OperationDetailPlanModule)Module).CheckAllTicket(fld_chkAllTicket.Checked);
                    fld_chkAllCapacity.Checked = false;
                }
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }

        private void Fld_bteHRDepartmentRoomGroupItemID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowHumanUnit();
            string emPloyee = ((OperationDetailPlanModule)Module).SelectedTicketHuman != null && ((OperationDetailPlanModule)Module).SelectedTicketHuman.Count() > 0
                ? ((OperationDetailPlanModule)Module).SelectedTicketHuman[0].HREmployeeName + ",..." : string.Empty;
            fld_bteTicketHuman.Text = emPloyee;

        }

        private void Fld_bteTicketOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowOperation(false, true);
            string operationName = ((OperationDetailPlanModule)Module).OperationTicketSelect != null && ((OperationDetailPlanModule)Module).OperationTicketSelect.Count() > 0
                    ? ((OperationDetailPlanModule)Module).OperationTicketSelect[0].MMOperationName + ",..." : string.Empty;
            fld_bteTicketOperation.Text = operationName;
        }

        private void Fld_tabOperationPlanList_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                ((OperationDetailPlanModule)Module).EnableControlPage(e.Page);
            }
            catch (Exception)
            {

                return;
            }

        }

        private void Fld_chkAllCapacity_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).CheckAllCapacity(fld_chkAllCapacity.Checked);
        }

        private void Fld_btnOpenTicket_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            ((OperationDetailPlanModule)Module).OpenJobTicket(null, entity.TicketDetailPlanItemsList);
        }

        private void Fld_btnCancelTicket_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            ((OperationDetailPlanModule)Module).CancelJobTicket(null, entity.TicketDetailPlanItemsList, false);
        }

        private void Fld_btnUpdateCapacity_Click(object sender, EventArgs e)
        {
            int EmployeeQCID = 0;
            if (fld_lkeHREmployeeQCID.EditValue != null)
                int.TryParse(fld_lkeHREmployeeQCID.EditValue.ToString(), out EmployeeQCID);

            int EmployeeGiveID = 0;
            if (fld_lkeHREmployeeGiveID.EditValue != null)
                int.TryParse(fld_lkeHREmployeeGiveID.EditValue.ToString(), out EmployeeGiveID);

            int EmployeeReceiptID = 0;
            if (fld_lkeHREmployeeTakeID.EditValue != null)
                int.TryParse(fld_lkeHREmployeeTakeID.EditValue.ToString(), out EmployeeReceiptID);

            ((OperationDetailPlanModule)Module).UpdateCapacityItem(fld_dteCapacityFromDate.DateTime, fld_dteCapacityToDate.DateTime, EmployeeQCID, EmployeeGiveID, EmployeeReceiptID);
        }

        private void Fld_chkTicketRemain_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterTicketGrid(fld_chkTicketRemain.Checked, ((OperationDetailPlanModule)Module).SelectedTicketHuman
                , ((OperationDetailPlanModule)Module).SelectedTicketMachine
                , false, ((OperationDetailPlanModule)Module).OperationTicketSelect);
        }

        private void Fld_chkMachine_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
                , fld_chkStatusCanceled.Checked
                , fld_chkStatusApproved.Checked
                , fld_chkStatusClosed.Checked
                , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
                , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
                );
        }

        private void Fld_chkStatusApproved_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
                , fld_chkStatusCanceled.Checked
                , fld_chkStatusApproved.Checked
                , fld_chkStatusClosed.Checked
                , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
                , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
                );
        }

        private void Fld_chkStatusClosed_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
                , fld_chkStatusCanceled.Checked
                , fld_chkStatusApproved.Checked
                , fld_chkStatusClosed.Checked
                , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
                , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
                );
        }

        private void Fld_chkStatusCanceled_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
                , fld_chkStatusCanceled.Checked
                , fld_chkStatusApproved.Checked
                , fld_chkStatusClosed.Checked
                , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
                , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
                );
        }

        private void Fld_lkeHuman_Validated(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
               , fld_chkStatusCanceled.Checked
               , fld_chkStatusApproved.Checked
               , fld_chkStatusClosed.Checked
               , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
               , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
               );
        }

        private void Fld_lkeMachine_Validated(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
               , fld_chkStatusCanceled.Checked
               , fld_chkStatusApproved.Checked
               , fld_chkStatusClosed.Checked
               , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
               , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
               );
        }

        private void Fld_btnEquipmentZoom_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcMMDetailPlanEquipments);
        }

        private void Fld_btnEquipmentRefesh_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).RefreshEquipmentDetailPlan();
        }

        private void Fld_btnRegisEquipment_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            ((OperationDetailPlanModule)Module).RegistrationEquipment(entity.EquipmentDetailPlansList, null);
            fld_chkAllEquipment.Checked = false;
        }

        private void Fld_btnCancelEquipment_Click(object sender, EventArgs e)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((OperationDetailPlanModule)Module).CurrentModuleEntity;
            ((OperationDetailPlanModule)Module).CancelRegistrationEquipment(entity.EquipmentDetailPlansList, null);
            fld_chkAllEquipment.Checked = false;
        }
        private void Fld_lkeHuman_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null)
            {
                ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
              , fld_chkStatusCanceled.Checked
              , fld_chkStatusApproved.Checked
              , fld_chkStatusClosed.Checked
              , e.Value != null ? e.Value.ToString() : "All"
              , fld_lkeMachine.EditValue != null ? fld_lkeMachine.EditValue.ToString() : "All"
              );
            }
        }

        private void Fld_lkeMachine_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null)
            {
                ((OperationDetailPlanModule)Module).FilterPlanData(fld_dgcMMOperationDetailPlanItemChilds, fld_chkStatusNew.Checked
                , fld_chkStatusCanceled.Checked
                , fld_chkStatusApproved.Checked
                , fld_chkStatusClosed.Checked
                , fld_lkeHuman.EditValue != null ? fld_lkeHuman.EditValue.ToString() : "All"
                , e.Value != null ? e.Value.ToString() : "All"
                );
            }
        }

        private void Fld_lkeFK_MMLineID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int workShopID = 0;
            if (fld_lkeFK_MMWorkShopID.EditValue != null) int.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID);
            DataSet ds = new DataSet();
            if (BOSApp.LookupTables.ContainsKey("MMLines"))
                ds = (DataSet)BOSApp.LookupTables["MMLines"];
            if (workShopID > 0)
            {
                if (BOSApp.LookupTables.ContainsKey("MMLines"))
                {
                    if (ds != null && ds.Tables[0] != null)
                    {
                        List<MMLinesInfo> line = (List<MMLinesInfo>)(new MMLinesController()).GetListFromDataSet(ds);
                        if (line != null)
                        {
                            line = line.Where(o => o.FK_MMWorkShopID == workShopID).ToList();
                            if (line != null)
                            {
                                line.Insert(0, new MMLinesInfo());
                                fld_lkeFK_MMLineID.Properties.DataSource = line;
                            }
                        }
                    }
                }
            }
            else
            {
                if (ds != null)
                    fld_lkeFK_MMLineID.Properties.DataSource = ds.Tables[0];
            }
        }

        private void Fld_chkAllEquipment_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).ChecAllEquipment(fld_chkAllEquipment.Checked);
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteMMOperationDetailPlanFromDate.DateTime;
            DateTime toDate = fld_dteMMOperationDetailPlanToDate.DateTime;

            string objectAccessKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);

            string ListOperationID = fld_cmbOperationsSearch.EditValue != null ? fld_cmbOperationsSearch.EditValue.ToString() : null;
            int SaleOrderID = 0;
            if (fld_lkeSaleOrderID.EditValue != null) int.TryParse(fld_lkeSaleOrderID.EditValue.ToString(), out SaleOrderID);
            int batchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null) int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            string productNo = string.IsNullOrEmpty(fld_txtProductNo.Text) ? string.Empty : fld_txtProductNo.Text.Trim();
            string productName = string.IsNullOrEmpty(fld_txtProductName.Text) ? string.Empty : fld_txtProductName.Text.Trim();
            if (batchProductID == 0 && !((OperationDetailPlanModule)Module).ODPMultiBatch)
            {
                BOSApp.ShowMessage("Vui lòng chọn LSX.");
                fld_lkeMMBatchProductID.Focus();
                return;
            }
            int branchID = 0;
            if (fld_lkeFK_BRBranchID.EditValue != null) int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);
            ((OperationDetailPlanModule)Module).ActionInvalidate(1);
            ((OperationDetailPlanModule)Module).SearchDetailPlan(fromDate, toDate, objObjectsInfo != null ? objObjectsInfo.ACObjectID : 0, objObjectsInfo != null ? objObjectsInfo.ACObjectType : string.Empty
                                                                , SaleOrderID, batchProductID, ListOperationID, productNo, productName, branchID);
        }

        private void fld_btnEditHuman_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowEditHuman(true, null);
        }

        private void fld_btnEditMachine_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowEditMachine(true);
        }

        private void fld_lkeFK_BRBranchID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            List<BRBranchsInfo> BranchList = ((OperationDetailPlanModule)Module).GetDataBranch();
            if (BranchList != null)
            {
                BranchList.Insert(0, new BRBranchsInfo());
            }
            fld_lkeFK_BRBranchID.Properties.DataSource = BranchList;
        }

        private void fld_btnTicketHumanEdit_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).ShowTicketEditHuman(false, null);
        }

        private void fld_lkeMMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            fld_lblBatchWoodStatus.Text = string.Empty;
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            fld_btnODPCloseBatch.Enabled = false;
            if (e.Value != null)
            {
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectByID(int.Parse(e.Value.ToString()));
                if (objBatchProductsInfo != null)
                {
                    fld_lblBatchWoodStatus.Text = BOSApp.GetDisplayTextFromConfigValue("BatchProductWoodStatus", objBatchProductsInfo.MMBatchProductWoodStatus);
                    if (objBatchProductsInfo.MMBatchProductWoodStatus == Status.Approved.ToString())
                        fld_btnODPCloseBatch.Enabled = true;
                    else fld_btnODPCloseBatch.Enabled = false;
                }
            }
        }

        private void fld_btnODPCloseBatch_Click(object sender, EventArgs e)
        {
            if (fld_lkeMMBatchProductID.EditValue == null) return;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectByID(int.Parse(fld_lkeMMBatchProductID.EditValue.ToString()));
            if (objBatchProductsInfo != null && objBatchProductsInfo.MMBatchProductID > 0 && objBatchProductsInfo.MMBatchProductWoodStatus == Status.Approved.ToString())
            {
                if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn đóng tất cả các thẻ của lệnh này?") == DialogResult.No) return;
                if (((OperationDetailPlanModule)Module).CloseJobTicketByBatch(objBatchProductsInfo.MMBatchProductID))
                {
                    fld_btnODPCloseBatch.Enabled = false;
                    fld_lblBatchWoodStatus.Text = BOSApp.GetDisplayTextFromConfigValue("BatchProductWoodStatus", Status.Closed.ToString());
                }
            }
            else BOSApp.ShowMessage("Trạng thái lệnh không phù hợp.");
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanModule)Module).PrintJobTicket();
        }
    }
}
