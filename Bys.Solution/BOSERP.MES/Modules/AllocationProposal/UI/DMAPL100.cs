using BOSCommon.Constants;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationProposal.UI
{
    /// <summary>
    /// Summary description for DMAPL100
    /// </summary>
    public partial class DMAPL100 : BOSERPScreen
    {

        public DMAPL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnUpdateInventoryStock_Click(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).ShowInventoryTotalQty();
        }

        private void Fld_btnApprove_Click(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).ApproveSelectedItems();
        }

        private void Fld_btnUpdateItemPlanDate_Click(object sender, EventArgs e)
        {
            DateTime planDate = fld_dteAllocationPlanDate.DateTime;
            ((AllocationProposalModule)Module).UpdateItemDate(planDate);
        }

        private void Fld_btnUpdateOtherInfo_Click(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).UpdateItemInfo();
        }

        private void Fld_btnPlanned_Click(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).PlannedSelectedItems();
        }

        private void Fld_btnUnPlannedClick(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).UnPlannedSelectedItems();
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

        private void Fld_btnItemWood_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemWoodsGridControl);
        }

        private void Fld_btnZoomOtherMaterial_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemSteelsGridControl);
        }

        private void Fld_btnZoomItemHardware_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemHardwaresGridControl);
        }

        private void Fld_btnZoomItemPaint_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemPaintsGridControl);
        }

        private void Fld_showZoomItemPackaging_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemPackagingGridControl);
        }

        private void Fld_btnZoomItemInstrument_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemInstrumentsGridControl);
        }

        private void Fld_btnZoomSemiProduct_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcAllocationPlanItemSemiGridControl);
        }

        private void Fld_btnUnApprove_Click(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).UnApproveSelectedItems();
        }

        private void fld_lkeFK_MMLineID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int workShopID = 0;
            if (fld_lkeFK_MMWorkShopID.EditValue != null)
                Int32.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID);

            MMLinesController objLinesController = new MMLinesController();
            List<MMLinesInfo> linesList = objLinesController.GetAllAliveAndActiveLineByWorkShopID(workShopID
                                                                , BOSApp.CurrentUsersInfo.ADUserID
                                                                , ModuleName.Line
                                                                , ADDataViewPermissionType.Module
                                                                , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            linesList.Insert(0, new MMLinesInfo());

            fld_lkeFK_MMLineID.Properties.DataSource = linesList;
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((AllocationProposalModule)Module).ChangeWorkShop(int.Parse(e.Value.ToString()));
            }
        }


        private void fld_lkeFK_MMWorkShopID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            lke.Properties.DataSource = ((AllocationProposalModule)Module).GetDataSourceForWorkShopByCurrentBranch();
        }

        private void fld_lkeHRDepartmentRoomGroupItemID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            lke.Properties.DataSource = ((AllocationProposalModule)Module).GetDataSourceForDepartmentRoomGroupItemByCurrentBranch();
        }

        private void fld_btnClosePlan_Click(object sender, EventArgs e)
        {
            ((AllocationProposalModule)Module).ClosePlanItem();
        }

        private void fld_tabProductionNorm_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            BaseModuleERP module = Module as AllocationProposalModule;
            if (module == null)
                return;

            ((AllocationProposalModule)Module).ChangeCurrentTabPage(e.Page.Name);
        }
    }
}
