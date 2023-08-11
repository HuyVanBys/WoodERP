using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OperationDetailPlan.UI
{
	/// <summary>
	/// Summary description for DMODPS100
	/// </summary>
	partial class DMODPS100
    {


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMODPS100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_bolEquipment = new BOSComponent.BOSLine(this.components);
            this.fld_btnCancelEquipment = new BOSComponent.BOSButton(this.components);
            this.fld_btnRegisEquipment = new BOSComponent.BOSButton(this.components);
            this.fld_bolTicket = new BOSComponent.BOSLine(this.components);
            this.fld_btnJobClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancelTicket = new BOSComponent.BOSButton(this.components);
            this.fld_btnOpenTicket = new BOSComponent.BOSButton(this.components);
            this.fld_bolJob = new BOSComponent.BOSLine(this.components);
            this.fld_btnAddDetail = new BOSComponent.BOSButton(this.components);
            this.fld_btnJobCreate = new BOSComponent.BOSButton(this.components);
            this.fld_btnJobCancel = new BOSComponent.BOSButton(this.components);
            this.fld_bolWorkCenter = new BOSComponent.BOSLine(this.components);
            this.fld_btnUpdatePosition = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_bolDate = new BOSComponent.BOSLine(this.components);
            this.fld_btnUpdatePlanDate = new BOSComponent.BOSButton(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnODPCloseBatch = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_cmbOperationsSearch = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblBatchWoodStatus = new BOSComponent.BOSLabel(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bedMMOperationDetailPlanWeek = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_dteMMOperationDetailPlanToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMOperationDetailPlanFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabOperationPlanList = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabDetailPlan = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnEditMachine = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditHuman = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMachine = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHuman = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblStatusLate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnStatusLate = new System.Windows.Forms.Button();
            this.fld_chkStatusClosed = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkStatusCanceled = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkStatusNew = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkStatusApproved = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkSelectAllPlan = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dgcMMOperationDetailPlanItemChilds = new BOSERP.Modules.OperationDetailPlan.MMOperationDetailPlanItemChildsGridControl();
            this.fld_tabHumanUnit = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomHuman = new BOSComponent.BOSButton(this.components);
            this.fld_spcHuman = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_btnCancelHuman = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddHuman = new BOSComponent.BOSButton(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_bteHumanOperation = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHumanHRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkHumanNotTicket = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_trlHumanUnits = new BOSERP.Modules.OperationDetailPlan.ChooseHumanUnitTreeControl();
            this.fld_Detail = new BOSComponent.BOSLine(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTotalBlock = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTotalQty = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_ckeSelectAllHumanticket = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeDetailPlanHumanAllowcation = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeHumanPlanByOperation = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkAllHumanDetailPlanItem = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dgcHumanDetailPlanItems = new BOSERP.Modules.OperationDetailPlan.MMHumanPlanItemsGridControl();
            this.fld_tabMachineUnit = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomMachine = new BOSComponent.BOSButton(this.components);
            this.fld_spcMachine = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_btnCancelMachine = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddMachine = new BOSComponent.BOSButton(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_bteMachineOperation = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeMMWorshopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_ckeMachineNotTicket = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_trlMachineUnits = new BOSERP.Modules.OperationDetailPlan.ChooseMachineUnitTreeControl();
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblMachineTotalBlock = new BOSComponent.BOSLabel(this.components);
            this.fld_lblMachineTotalQty = new BOSComponent.BOSLabel(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_ckeAllMachineTicket = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeTicketNothaveMachine = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeTicketByOperation = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_TicketHaveMachine = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dgcMachineDetailPlanItems = new BOSERP.Modules.OperationDetailPlan.MMMachinePlanItemsGridControl();
            this.fld_xtabEquipment = new DevExpress.XtraTab.XtraTabPage();
            this.fld_chkAllEquipment = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnEquipmentRefesh = new BOSComponent.BOSButton(this.components);
            this.fld_btnEquipmentZoom = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMDetailPlanEquipments = new BOSERP.Modules.OperationDetailPlan.MMEquipmentPlanItemsGridControl();
            this.fld_tabJobTicket = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnTicketZoom = new BOSComponent.BOSButton(this.components);
            this.fld_splTicket = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine8 = new BOSComponent.BOSLine(this.components);
            this.fld_btnTicketHumanEdit = new BOSComponent.BOSButton(this.components);
            this.fld_bteTicketOperation = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_bteTicketHuman = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkAllTicket = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnCapacityReceipt = new BOSComponent.BOSButton(this.components);
            this.fld_chkTicketRemain = new BOSComponent.BOSCheckEdit(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblAllticket = new BOSComponent.BOSLabel(this.components);
            this.fld_btnStatusAlittleReceipt = new System.Windows.Forms.Button();
            this.fld_lblStatusAlittleReceipt = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMTicketPlanItems = new BOSERP.Modules.OperationDetailPlan.MMTicketPlanItemsGridControl();
            this.bosLine9 = new BOSComponent.BOSLine(this.components);
            this.fld_btnUpdateCapacity = new BOSComponent.BOSButton(this.components);
            this.fld_btnSaveCapacity = new BOSComponent.BOSButton(this.components);
            this.fld_dgcCapacityItemsGridControl = new BOSERP.Modules.OperationDetailPlan.MMCapacityItemsGridControl();
            this.fld_lkeHREmployeeQCID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkAllCapacity = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblFrom = new BOSComponent.BOSLabel(this.components);
            this.fld_dteCapacityToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteCapacityFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeTakeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeGiveID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvMMOperationDetailPlanItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            this.fld_bolEquipment.SuspendLayout();
            this.fld_bolTicket.SuspendLayout();
            this.fld_bolJob.SuspendLayout();
            this.fld_bolWorkCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            this.fld_bolDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbOperationsSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedMMOperationDetailPlanWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabOperationPlanList)).BeginInit();
            this.fld_tabOperationPlanList.SuspendLayout();
            this.fld_tabDetailPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHuman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusClosed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusCanceled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusApproved.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAllPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanItemChilds)).BeginInit();
            this.fld_tabHumanUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcHuman)).BeginInit();
            this.fld_spcHuman.SuspendLayout();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteHumanOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHumanHRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkHumanNotTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHumanUnits)).BeginInit();
            this.fld_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeSelectAllHumanticket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeDetailPlanHumanAllowcation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeHumanPlanByOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllHumanDetailPlanItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHumanDetailPlanItems)).BeginInit();
            this.fld_tabMachineUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcMachine)).BeginInit();
            this.fld_spcMachine.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteMachineOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWorshopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMachineNotTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMachineUnits)).BeginInit();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeAllMachineTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeTicketNothaveMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeTicketByOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_TicketHaveMachine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineDetailPlanItems)).BeginInit();
            this.fld_xtabEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllEquipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDetailPlanEquipments)).BeginInit();
            this.fld_tabJobTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).BeginInit();
            this.fld_splTicket.SuspendLayout();
            this.bosLine8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteTicketOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteTicketHuman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkTicketRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMTicketPlanItems)).BeginInit();
            this.bosLine9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCapacityItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeQCID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTakeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGiveID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMOperationDetailPlanItems)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_bolEquipment);
            this.bosPanel1.Controls.Add(this.fld_bolTicket);
            this.bosPanel1.Controls.Add(this.fld_bolJob);
            this.bosPanel1.Controls.Add(this.fld_bolWorkCenter);
            this.bosPanel1.Controls.Add(this.fld_bolDate);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_tabOperationPlanList);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1757, 852);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_bolEquipment
            // 
            this.fld_bolEquipment.BOSComment = null;
            this.fld_bolEquipment.BOSDataMember = null;
            this.fld_bolEquipment.BOSDataSource = null;
            this.fld_bolEquipment.BOSDescription = null;
            this.fld_bolEquipment.BOSError = null;
            this.fld_bolEquipment.BOSFieldGroup = null;
            this.fld_bolEquipment.BOSFieldRelation = null;
            this.fld_bolEquipment.BOSPrivilege = null;
            this.fld_bolEquipment.BOSPropertyName = null;
            this.fld_bolEquipment.Controls.Add(this.fld_btnCancelEquipment);
            this.fld_bolEquipment.Controls.Add(this.fld_btnRegisEquipment);
            this.fld_bolEquipment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolEquipment.Location = new System.Drawing.Point(1538, 3);
            this.fld_bolEquipment.Name = "fld_bolEquipment";
            this.fld_bolEquipment.Screen = null;
            this.fld_bolEquipment.Size = new System.Drawing.Size(108, 95);
            this.fld_bolEquipment.TabIndex = 123;
            this.fld_bolEquipment.TabStop = false;
            this.fld_bolEquipment.Text = "Quản lý khuôn";
            // 
            // fld_btnCancelEquipment
            // 
            this.fld_btnCancelEquipment.BOSComment = null;
            this.fld_btnCancelEquipment.BOSDataMember = null;
            this.fld_btnCancelEquipment.BOSDataSource = null;
            this.fld_btnCancelEquipment.BOSDescription = null;
            this.fld_btnCancelEquipment.BOSError = null;
            this.fld_btnCancelEquipment.BOSFieldGroup = null;
            this.fld_btnCancelEquipment.BOSFieldRelation = null;
            this.fld_btnCancelEquipment.BOSPrivilege = null;
            this.fld_btnCancelEquipment.BOSPropertyName = null;
            this.fld_btnCancelEquipment.Location = new System.Drawing.Point(6, 44);
            this.fld_btnCancelEquipment.Name = "fld_btnCancelEquipment";
            this.fld_btnCancelEquipment.Screen = null;
            this.fld_btnCancelEquipment.Size = new System.Drawing.Size(96, 22);
            this.fld_btnCancelEquipment.TabIndex = 11;
            this.fld_btnCancelEquipment.Text = "Hủy đăng ký";
            this.fld_btnCancelEquipment.Click += new System.EventHandler(this.Fld_btnCancelEquipment_Click);
            // 
            // fld_btnRegisEquipment
            // 
            this.fld_btnRegisEquipment.BOSComment = null;
            this.fld_btnRegisEquipment.BOSDataMember = null;
            this.fld_btnRegisEquipment.BOSDataSource = null;
            this.fld_btnRegisEquipment.BOSDescription = null;
            this.fld_btnRegisEquipment.BOSError = null;
            this.fld_btnRegisEquipment.BOSFieldGroup = null;
            this.fld_btnRegisEquipment.BOSFieldRelation = null;
            this.fld_btnRegisEquipment.BOSPrivilege = null;
            this.fld_btnRegisEquipment.BOSPropertyName = null;
            this.fld_btnRegisEquipment.Location = new System.Drawing.Point(6, 19);
            this.fld_btnRegisEquipment.Name = "fld_btnRegisEquipment";
            this.fld_btnRegisEquipment.Screen = null;
            this.fld_btnRegisEquipment.Size = new System.Drawing.Size(96, 22);
            this.fld_btnRegisEquipment.TabIndex = 10;
            this.fld_btnRegisEquipment.Text = "Đăng ký";
            this.fld_btnRegisEquipment.Click += new System.EventHandler(this.Fld_btnRegisEquipment_Click);
            // 
            // fld_bolTicket
            // 
            this.fld_bolTicket.BOSComment = null;
            this.fld_bolTicket.BOSDataMember = null;
            this.fld_bolTicket.BOSDataSource = null;
            this.fld_bolTicket.BOSDescription = null;
            this.fld_bolTicket.BOSError = null;
            this.fld_bolTicket.BOSFieldGroup = null;
            this.fld_bolTicket.BOSFieldRelation = null;
            this.fld_bolTicket.BOSPrivilege = null;
            this.fld_bolTicket.BOSPropertyName = null;
            this.fld_bolTicket.Controls.Add(this.fld_btnJobClose);
            this.fld_bolTicket.Controls.Add(this.fld_btnCancelTicket);
            this.fld_bolTicket.Controls.Add(this.fld_btnOpenTicket);
            this.fld_bolTicket.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolTicket.Location = new System.Drawing.Point(1424, 3);
            this.fld_bolTicket.Name = "fld_bolTicket";
            this.fld_bolTicket.Screen = null;
            this.fld_bolTicket.Size = new System.Drawing.Size(108, 95);
            this.fld_bolTicket.TabIndex = 123;
            this.fld_bolTicket.TabStop = false;
            this.fld_bolTicket.Text = "Quản lý thẻ";
            // 
            // fld_btnJobClose
            // 
            this.fld_btnJobClose.BOSComment = null;
            this.fld_btnJobClose.BOSDataMember = null;
            this.fld_btnJobClose.BOSDataSource = null;
            this.fld_btnJobClose.BOSDescription = null;
            this.fld_btnJobClose.BOSError = null;
            this.fld_btnJobClose.BOSFieldGroup = null;
            this.fld_btnJobClose.BOSFieldRelation = null;
            this.fld_btnJobClose.BOSPrivilege = null;
            this.fld_btnJobClose.BOSPropertyName = null;
            this.fld_btnJobClose.Location = new System.Drawing.Point(6, 19);
            this.fld_btnJobClose.Name = "fld_btnJobClose";
            this.fld_btnJobClose.Screen = null;
            this.fld_btnJobClose.Size = new System.Drawing.Size(96, 22);
            this.fld_btnJobClose.TabIndex = 10;
            this.fld_btnJobClose.Text = "Đóng thẻ";
            this.fld_btnJobClose.Click += new System.EventHandler(this.Fld_btnJobClose_Click);
            // 
            // fld_btnCancelTicket
            // 
            this.fld_btnCancelTicket.BOSComment = null;
            this.fld_btnCancelTicket.BOSDataMember = null;
            this.fld_btnCancelTicket.BOSDataSource = null;
            this.fld_btnCancelTicket.BOSDescription = null;
            this.fld_btnCancelTicket.BOSError = null;
            this.fld_btnCancelTicket.BOSFieldGroup = null;
            this.fld_btnCancelTicket.BOSFieldRelation = null;
            this.fld_btnCancelTicket.BOSPrivilege = null;
            this.fld_btnCancelTicket.BOSPropertyName = null;
            this.fld_btnCancelTicket.Location = new System.Drawing.Point(6, 43);
            this.fld_btnCancelTicket.Name = "fld_btnCancelTicket";
            this.fld_btnCancelTicket.Screen = null;
            this.fld_btnCancelTicket.Size = new System.Drawing.Size(96, 22);
            this.fld_btnCancelTicket.TabIndex = 10;
            this.fld_btnCancelTicket.Text = "Hủy thẻ";
            this.fld_btnCancelTicket.Click += new System.EventHandler(this.Fld_btnCancelTicket_Click);
            // 
            // fld_btnOpenTicket
            // 
            this.fld_btnOpenTicket.BOSComment = null;
            this.fld_btnOpenTicket.BOSDataMember = null;
            this.fld_btnOpenTicket.BOSDataSource = null;
            this.fld_btnOpenTicket.BOSDescription = null;
            this.fld_btnOpenTicket.BOSError = null;
            this.fld_btnOpenTicket.BOSFieldGroup = null;
            this.fld_btnOpenTicket.BOSFieldRelation = null;
            this.fld_btnOpenTicket.BOSPrivilege = null;
            this.fld_btnOpenTicket.BOSPropertyName = null;
            this.fld_btnOpenTicket.Location = new System.Drawing.Point(6, 69);
            this.fld_btnOpenTicket.Name = "fld_btnOpenTicket";
            this.fld_btnOpenTicket.Screen = null;
            this.fld_btnOpenTicket.Size = new System.Drawing.Size(96, 22);
            this.fld_btnOpenTicket.TabIndex = 123;
            this.fld_btnOpenTicket.Text = "Mở thẻ";
            this.fld_btnOpenTicket.Click += new System.EventHandler(this.Fld_btnOpenTicket_Click);
            // 
            // fld_bolJob
            // 
            this.fld_bolJob.BOSComment = null;
            this.fld_bolJob.BOSDataMember = null;
            this.fld_bolJob.BOSDataSource = null;
            this.fld_bolJob.BOSDescription = null;
            this.fld_bolJob.BOSError = null;
            this.fld_bolJob.BOSFieldGroup = null;
            this.fld_bolJob.BOSFieldRelation = null;
            this.fld_bolJob.BOSPrivilege = null;
            this.fld_bolJob.BOSPropertyName = null;
            this.fld_bolJob.Controls.Add(this.fld_btnAddDetail);
            this.fld_bolJob.Controls.Add(this.fld_btnJobCreate);
            this.fld_bolJob.Controls.Add(this.fld_btnJobCancel);
            this.fld_bolJob.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolJob.Location = new System.Drawing.Point(1311, 3);
            this.fld_bolJob.Name = "fld_bolJob";
            this.fld_bolJob.Screen = null;
            this.fld_bolJob.Size = new System.Drawing.Size(107, 95);
            this.fld_bolJob.TabIndex = 122;
            this.fld_bolJob.TabStop = false;
            this.fld_bolJob.Text = "Quản lý chi tiết";
            // 
            // fld_btnAddDetail
            // 
            this.fld_btnAddDetail.BOSComment = null;
            this.fld_btnAddDetail.BOSDataMember = null;
            this.fld_btnAddDetail.BOSDataSource = null;
            this.fld_btnAddDetail.BOSDescription = null;
            this.fld_btnAddDetail.BOSError = null;
            this.fld_btnAddDetail.BOSFieldGroup = null;
            this.fld_btnAddDetail.BOSFieldRelation = null;
            this.fld_btnAddDetail.BOSPrivilege = null;
            this.fld_btnAddDetail.BOSPropertyName = null;
            this.fld_btnAddDetail.Location = new System.Drawing.Point(6, 19);
            this.fld_btnAddDetail.Name = "fld_btnAddDetail";
            this.fld_btnAddDetail.Screen = null;
            this.fld_btnAddDetail.Size = new System.Drawing.Size(96, 22);
            this.fld_btnAddDetail.TabIndex = 10;
            this.fld_btnAddDetail.Text = "Thêm chi tiết";
            this.fld_btnAddDetail.Click += new System.EventHandler(this.fld_btnAddDetail_Click);
            // 
            // fld_btnJobCreate
            // 
            this.fld_btnJobCreate.BOSComment = null;
            this.fld_btnJobCreate.BOSDataMember = null;
            this.fld_btnJobCreate.BOSDataSource = null;
            this.fld_btnJobCreate.BOSDescription = null;
            this.fld_btnJobCreate.BOSError = null;
            this.fld_btnJobCreate.BOSFieldGroup = null;
            this.fld_btnJobCreate.BOSFieldRelation = null;
            this.fld_btnJobCreate.BOSPrivilege = null;
            this.fld_btnJobCreate.BOSPropertyName = null;
            this.fld_btnJobCreate.Location = new System.Drawing.Point(6, 43);
            this.fld_btnJobCreate.Name = "fld_btnJobCreate";
            this.fld_btnJobCreate.Screen = null;
            this.fld_btnJobCreate.Size = new System.Drawing.Size(96, 22);
            this.fld_btnJobCreate.TabIndex = 10;
            this.fld_btnJobCreate.Text = "Sinh thẻ";
            this.fld_btnJobCreate.Click += new System.EventHandler(this.Fld_btnJobCreate_Click);
            // 
            // fld_btnJobCancel
            // 
            this.fld_btnJobCancel.BOSComment = null;
            this.fld_btnJobCancel.BOSDataMember = null;
            this.fld_btnJobCancel.BOSDataSource = null;
            this.fld_btnJobCancel.BOSDescription = null;
            this.fld_btnJobCancel.BOSError = null;
            this.fld_btnJobCancel.BOSFieldGroup = null;
            this.fld_btnJobCancel.BOSFieldRelation = null;
            this.fld_btnJobCancel.BOSPrivilege = null;
            this.fld_btnJobCancel.BOSPropertyName = null;
            this.fld_btnJobCancel.Location = new System.Drawing.Point(6, 69);
            this.fld_btnJobCancel.Name = "fld_btnJobCancel";
            this.fld_btnJobCancel.Screen = null;
            this.fld_btnJobCancel.Size = new System.Drawing.Size(96, 22);
            this.fld_btnJobCancel.TabIndex = 10;
            this.fld_btnJobCancel.Text = "Hủy chi tiết";
            this.fld_btnJobCancel.Click += new System.EventHandler(this.Fld_btnJobCancel_Click);
            // 
            // fld_bolWorkCenter
            // 
            this.fld_bolWorkCenter.BOSComment = null;
            this.fld_bolWorkCenter.BOSDataMember = null;
            this.fld_bolWorkCenter.BOSDataSource = null;
            this.fld_bolWorkCenter.BOSDescription = null;
            this.fld_bolWorkCenter.BOSError = null;
            this.fld_bolWorkCenter.BOSFieldGroup = null;
            this.fld_bolWorkCenter.BOSFieldRelation = null;
            this.fld_bolWorkCenter.BOSPrivilege = null;
            this.fld_bolWorkCenter.BOSPropertyName = null;
            this.fld_bolWorkCenter.Controls.Add(this.fld_btnUpdatePosition);
            this.fld_bolWorkCenter.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.fld_bolWorkCenter.Controls.Add(this.fld_lkeFK_MMLineID);
            this.fld_bolWorkCenter.Controls.Add(this.bosLabel9);
            this.fld_bolWorkCenter.Controls.Add(this.bosLabel8);
            this.fld_bolWorkCenter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolWorkCenter.Location = new System.Drawing.Point(1130, 3);
            this.fld_bolWorkCenter.Name = "fld_bolWorkCenter";
            this.fld_bolWorkCenter.Screen = null;
            this.fld_bolWorkCenter.Size = new System.Drawing.Size(175, 95);
            this.fld_bolWorkCenter.TabIndex = 121;
            this.fld_bolWorkCenter.TabStop = false;
            this.fld_bolWorkCenter.Text = "Cập nhật xưởng chuyền tổ ";
            // 
            // fld_btnUpdatePosition
            // 
            this.fld_btnUpdatePosition.BOSComment = null;
            this.fld_btnUpdatePosition.BOSDataMember = null;
            this.fld_btnUpdatePosition.BOSDataSource = null;
            this.fld_btnUpdatePosition.BOSDescription = null;
            this.fld_btnUpdatePosition.BOSError = null;
            this.fld_btnUpdatePosition.BOSFieldGroup = null;
            this.fld_btnUpdatePosition.BOSFieldRelation = null;
            this.fld_btnUpdatePosition.BOSPrivilege = null;
            this.fld_btnUpdatePosition.BOSPropertyName = null;
            this.fld_btnUpdatePosition.Location = new System.Drawing.Point(73, 69);
            this.fld_btnUpdatePosition.Name = "fld_btnUpdatePosition";
            this.fld_btnUpdatePosition.Screen = null;
            this.fld_btnUpdatePosition.Size = new System.Drawing.Size(96, 22);
            this.fld_btnUpdatePosition.TabIndex = 118;
            this.fld_btnUpdatePosition.Text = "Cập nhật";
            this.fld_btnUpdatePosition.Click += new System.EventHandler(this.Fld_btnUpdatePosition_Click);
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMOperationDetailPlans";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(51, 21);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 4;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = true;
            this.fld_lkeFK_MMLineID.BOSComment = "";
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMOperationDetailPlans";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = "";
            this.fld_lkeFK_MMLineID.BOSFieldParent = "";
            this.fld_lkeFK_MMLineID.BOSFieldRelation = "";
            this.fld_lkeFK_MMLineID.BOSPrivilege = "";
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = "";
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMLineID.CurrentDisplayText = "";
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(51, 45);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.ColumnName = null;
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = "";
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 5;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            this.fld_lkeFK_MMLineID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeFK_MMLineID_QueryPopUp);
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(6, 23);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(31, 13);
            this.bosLabel9.TabIndex = 20;
            this.bosLabel9.Text = "Xưởng";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(6, 48);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(37, 13);
            this.bosLabel8.TabIndex = 21;
            this.bosLabel8.Text = "Chuyền";
            // 
            // fld_bolDate
            // 
            this.fld_bolDate.BOSComment = null;
            this.fld_bolDate.BOSDataMember = null;
            this.fld_bolDate.BOSDataSource = null;
            this.fld_bolDate.BOSDescription = null;
            this.fld_bolDate.BOSError = null;
            this.fld_bolDate.BOSFieldGroup = null;
            this.fld_bolDate.BOSFieldRelation = null;
            this.fld_bolDate.BOSPrivilege = null;
            this.fld_bolDate.BOSPropertyName = null;
            this.fld_bolDate.Controls.Add(this.fld_btnUpdatePlanDate);
            this.fld_bolDate.Controls.Add(this.fld_dteFromDate);
            this.fld_bolDate.Controls.Add(this.bosLabel4);
            this.fld_bolDate.Controls.Add(this.fld_dteToDate);
            this.fld_bolDate.Controls.Add(this.bosLabel13);
            this.fld_bolDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolDate.Location = new System.Drawing.Point(899, 3);
            this.fld_bolDate.Name = "fld_bolDate";
            this.fld_bolDate.Screen = null;
            this.fld_bolDate.Size = new System.Drawing.Size(225, 95);
            this.fld_bolDate.TabIndex = 120;
            this.fld_bolDate.TabStop = false;
            this.fld_bolDate.Text = "Cập nhật ngày kế hoạch chi tiết";
            // 
            // fld_btnUpdatePlanDate
            // 
            this.fld_btnUpdatePlanDate.BOSComment = null;
            this.fld_btnUpdatePlanDate.BOSDataMember = null;
            this.fld_btnUpdatePlanDate.BOSDataSource = null;
            this.fld_btnUpdatePlanDate.BOSDescription = null;
            this.fld_btnUpdatePlanDate.BOSError = null;
            this.fld_btnUpdatePlanDate.BOSFieldGroup = null;
            this.fld_btnUpdatePlanDate.BOSFieldRelation = null;
            this.fld_btnUpdatePlanDate.BOSPrivilege = null;
            this.fld_btnUpdatePlanDate.BOSPropertyName = null;
            this.fld_btnUpdatePlanDate.Location = new System.Drawing.Point(121, 68);
            this.fld_btnUpdatePlanDate.Name = "fld_btnUpdatePlanDate";
            this.fld_btnUpdatePlanDate.Screen = null;
            this.fld_btnUpdatePlanDate.Size = new System.Drawing.Size(96, 22);
            this.fld_btnUpdatePlanDate.TabIndex = 118;
            this.fld_btnUpdatePlanDate.Text = "Cập nhật";
            this.fld_btnUpdatePlanDate.Click += new System.EventHandler(this.Fld_btnUpdatePlanDate_Click);
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = "";
            this.fld_dteFromDate.BOSDataMember = "";
            this.fld_dteFromDate.BOSDataSource = "";
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = "";
            this.fld_dteFromDate.BOSFieldRelation = "";
            this.fld_dteFromDate.BOSPrivilege = "";
            this.fld_dteFromDate.BOSPropertyName = "";
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(85, 20);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.fld_dteFromDate.Properties.Mask.EditMask = "g";
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(132, 20);
            this.fld_dteFromDate.TabIndex = 92;
            this.fld_dteFromDate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(8, 24);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(61, 13);
            this.bosLabel4.TabIndex = 97;
            this.bosLabel4.Text = "Thực hiện từ";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = "";
            this.fld_dteToDate.BOSDataMember = "";
            this.fld_dteToDate.BOSDataSource = "";
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = "";
            this.fld_dteToDate.BOSFieldRelation = "";
            this.fld_dteToDate.BOSPrivilege = "";
            this.fld_dteToDate.BOSPropertyName = "EditValue";
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(85, 44);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToDate.Properties.Mask.EditMask = "g";
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(132, 20);
            this.fld_dteToDate.TabIndex = 92;
            this.fld_dteToDate.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(8, 47);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 114;
            this.bosLabel13.Text = "Đến ngày";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_btnODPCloseBatch);
            this.bosLine1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosLine1.Controls.Add(this.bosLabel30);
            this.bosLine1.Controls.Add(this.fld_cmbOperationsSearch);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_txtProductName);
            this.bosLine1.Controls.Add(this.bosLabel5);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.fld_txtProductNo);
            this.bosLine1.Controls.Add(this.fld_btnFind);
            this.bosLine1.Controls.Add(this.bosLabel29);
            this.bosLine1.Controls.Add(this.fld_lblBatchWoodStatus);
            this.bosLine1.Controls.Add(this.bosLabel32);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.fld_lkeSaleOrderID);
            this.bosLine1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.bosLine1.Controls.Add(this.fld_bedMMOperationDetailPlanWeek);
            this.bosLine1.Controls.Add(this.fld_dteMMOperationDetailPlanToDate);
            this.bosLine1.Controls.Add(this.bosLabel14);
            this.bosLine1.Controls.Add(this.fld_dteMMOperationDetailPlanFromDate);
            this.bosLine1.Controls.Add(this.bosLabel6);
            this.bosLine1.Controls.Add(this.bosLabel10);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(4, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(889, 95);
            this.bosLine1.TabIndex = 116;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin chung";
            // 
            // fld_btnODPCloseBatch
            // 
            this.fld_btnODPCloseBatch.BOSComment = null;
            this.fld_btnODPCloseBatch.BOSDataMember = null;
            this.fld_btnODPCloseBatch.BOSDataSource = null;
            this.fld_btnODPCloseBatch.BOSDescription = null;
            this.fld_btnODPCloseBatch.BOSError = null;
            this.fld_btnODPCloseBatch.BOSFieldGroup = null;
            this.fld_btnODPCloseBatch.BOSFieldRelation = null;
            this.fld_btnODPCloseBatch.BOSPrivilege = null;
            this.fld_btnODPCloseBatch.BOSPropertyName = null;
            this.fld_btnODPCloseBatch.Enabled = false;
            this.fld_btnODPCloseBatch.Location = new System.Drawing.Point(787, 68);
            this.fld_btnODPCloseBatch.Name = "fld_btnODPCloseBatch";
            this.fld_btnODPCloseBatch.Screen = null;
            this.fld_btnODPCloseBatch.Size = new System.Drawing.Size(96, 22);
            this.fld_btnODPCloseBatch.TabIndex = 10;
            this.fld_btnODPCloseBatch.Text = "Đóng theo lệnh";
            this.fld_btnODPCloseBatch.Click += new System.EventHandler(this.fld_btnODPCloseBatch_Click);
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = "";
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(728, 22);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 177;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            this.fld_lkeFK_BRBranchID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_BRBranchID_QueryPopUp);
            // 
            // bosLabel30
            // 
            this.bosLabel30.BOSComment = null;
            this.bosLabel30.BOSDataMember = null;
            this.bosLabel30.BOSDataSource = null;
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = null;
            this.bosLabel30.BOSFieldRelation = null;
            this.bosLabel30.BOSPrivilege = null;
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(694, 24);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(14, 13);
            this.bosLabel30.TabIndex = 178;
            this.bosLabel30.Text = "CN";
            // 
            // fld_cmbOperationsSearch
            // 
            this.fld_cmbOperationsSearch.Location = new System.Drawing.Point(532, 71);
            this.fld_cmbOperationsSearch.MenuManager = this.screenToolbar;
            this.fld_cmbOperationsSearch.Name = "fld_cmbOperationsSearch";
            this.fld_cmbOperationsSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbOperationsSearch.Properties.DisplayMember = "MMOperationName";
            this.fld_cmbOperationsSearch.Properties.ValueMember = "MMOperationID";
            this.fld_cmbOperationsSearch.Size = new System.Drawing.Size(143, 20);
            this.fld_cmbOperationsSearch.TabIndex = 176;
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(453, 72);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 175;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(287, 22);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 173;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(210, 24);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 174;
            this.bosLabel3.Text = "Đối tượng";
            // 
            // fld_txtProductName
            // 
            this.fld_txtProductName.BOSComment = null;
            this.fld_txtProductName.BOSDataMember = null;
            this.fld_txtProductName.BOSDataSource = null;
            this.fld_txtProductName.BOSDescription = null;
            this.fld_txtProductName.BOSError = null;
            this.fld_txtProductName.BOSFieldGroup = null;
            this.fld_txtProductName.BOSFieldRelation = null;
            this.fld_txtProductName.BOSPrivilege = null;
            this.fld_txtProductName.BOSPropertyName = null;
            this.fld_txtProductName.Location = new System.Drawing.Point(532, 46);
            this.fld_txtProductName.MenuManager = this.screenToolbar;
            this.fld_txtProductName.Name = "fld_txtProductName";
            this.fld_txtProductName.Screen = null;
            this.fld_txtProductName.Size = new System.Drawing.Size(143, 20);
            this.fld_txtProductName.TabIndex = 134;
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(453, 49);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(67, 13);
            this.bosLabel5.TabIndex = 133;
            this.bosLabel5.Text = "Tên sản phẩm";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(453, 25);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(63, 13);
            this.bosLabel2.TabIndex = 131;
            this.bosLabel2.Text = "Mã sản phẩm";
            // 
            // fld_txtProductNo
            // 
            this.fld_txtProductNo.BOSComment = null;
            this.fld_txtProductNo.BOSDataMember = null;
            this.fld_txtProductNo.BOSDataSource = null;
            this.fld_txtProductNo.BOSDescription = null;
            this.fld_txtProductNo.BOSError = null;
            this.fld_txtProductNo.BOSFieldGroup = null;
            this.fld_txtProductNo.BOSFieldRelation = null;
            this.fld_txtProductNo.BOSPrivilege = null;
            this.fld_txtProductNo.BOSPropertyName = null;
            this.fld_txtProductNo.Location = new System.Drawing.Point(532, 22);
            this.fld_txtProductNo.MenuManager = this.screenToolbar;
            this.fld_txtProductNo.Name = "fld_txtProductNo";
            this.fld_txtProductNo.Screen = null;
            this.fld_txtProductNo.Size = new System.Drawing.Size(143, 20);
            this.fld_txtProductNo.TabIndex = 132;
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnFind.ImageOptions.Image")));
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(694, 68);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(86, 22);
            this.fld_btnFind.TabIndex = 130;
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = "";
            this.bosLabel29.BOSDataSource = "";
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = "";
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(210, 72);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(68, 13);
            this.bosLabel29.TabIndex = 126;
            this.bosLabel29.Text = "Đơn bán hàng";
            // 
            // fld_lblBatchWoodStatus
            // 
            this.fld_lblBatchWoodStatus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblBatchWoodStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblBatchWoodStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblBatchWoodStatus.Appearance.Options.UseBackColor = true;
            this.fld_lblBatchWoodStatus.Appearance.Options.UseFont = true;
            this.fld_lblBatchWoodStatus.Appearance.Options.UseForeColor = true;
            this.fld_lblBatchWoodStatus.BOSComment = null;
            this.fld_lblBatchWoodStatus.BOSDataMember = "";
            this.fld_lblBatchWoodStatus.BOSDataSource = "";
            this.fld_lblBatchWoodStatus.BOSDescription = null;
            this.fld_lblBatchWoodStatus.BOSError = null;
            this.fld_lblBatchWoodStatus.BOSFieldGroup = "";
            this.fld_lblBatchWoodStatus.BOSFieldRelation = null;
            this.fld_lblBatchWoodStatus.BOSPrivilege = null;
            this.fld_lblBatchWoodStatus.BOSPropertyName = null;
            this.fld_lblBatchWoodStatus.Location = new System.Drawing.Point(794, 49);
            this.fld_lblBatchWoodStatus.Name = "fld_lblBatchWoodStatus";
            this.fld_lblBatchWoodStatus.Screen = null;
            this.fld_lblBatchWoodStatus.Size = new System.Drawing.Size(22, 13);
            this.fld_lblBatchWoodStatus.TabIndex = 126;
            this.fld_lblBatchWoodStatus.Text = "N/A";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(694, 49);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(94, 13);
            this.bosLabel32.TabIndex = 126;
            this.bosLabel32.Text = "Trạng thái KHSXCT:";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(210, 49);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(38, 13);
            this.bosLabel1.TabIndex = 126;
            this.bosLabel1.Text = "Lệnh SX";
            // 
            // fld_lkeSaleOrderID
            // 
            this.fld_lkeSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeSaleOrderID.BOSComment = null;
            this.fld_lkeSaleOrderID.BOSDataMember = "";
            this.fld_lkeSaleOrderID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeSaleOrderID.BOSDescription = null;
            this.fld_lkeSaleOrderID.BOSError = "";
            this.fld_lkeSaleOrderID.BOSFieldGroup = null;
            this.fld_lkeSaleOrderID.BOSFieldParent = null;
            this.fld_lkeSaleOrderID.BOSFieldRelation = null;
            this.fld_lkeSaleOrderID.BOSPrivilege = null;
            this.fld_lkeSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeSaleOrderID.BOSSelectType = "";
            this.fld_lkeSaleOrderID.BOSSelectTypeValue = "";
            this.fld_lkeSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeSaleOrderID.Location = new System.Drawing.Point(287, 69);
            this.fld_lkeSaleOrderID.Name = "fld_lkeSaleOrderID";
            this.fld_lkeSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSaleOrderID.Properties.ColumnName = null;
            this.fld_lkeSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã")});
            this.fld_lkeSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeSaleOrderID.Properties.NullText = "";
            this.fld_lkeSaleOrderID.Properties.PopupWidth = 40;
            this.fld_lkeSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeSaleOrderID.Screen = null;
            this.fld_lkeSaleOrderID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeSaleOrderID.TabIndex = 127;
            this.fld_lkeSaleOrderID.Tag = "DC";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = "";
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = "MMBatchProductWoodStatus";
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = "Approved;Closed";
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(287, 45);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã lệnh "),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductMultiCustomer", "Khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductFromDate", "Từ ngày"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductToDate", "Đến ngày"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductDesc", "Mô tả")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = "";
            this.fld_lkeMMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 127;
            this.fld_lkeMMBatchProductID.Tag = "DC";
            this.fld_lkeMMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMBatchProductID_CloseUp);
            // 
            // fld_bedMMOperationDetailPlanWeek
            // 
            this.fld_bedMMOperationDetailPlanWeek.BOSComment = null;
            this.fld_bedMMOperationDetailPlanWeek.BOSDataMember = "";
            this.fld_bedMMOperationDetailPlanWeek.BOSDataSource = "";
            this.fld_bedMMOperationDetailPlanWeek.BOSDescription = null;
            this.fld_bedMMOperationDetailPlanWeek.BOSError = null;
            this.fld_bedMMOperationDetailPlanWeek.BOSFieldGroup = null;
            this.fld_bedMMOperationDetailPlanWeek.BOSFieldRelation = null;
            this.fld_bedMMOperationDetailPlanWeek.BOSPrivilege = null;
            this.fld_bedMMOperationDetailPlanWeek.BOSPropertyName = "Text";
            this.fld_bedMMOperationDetailPlanWeek.Location = new System.Drawing.Point(80, 21);
            this.fld_bedMMOperationDetailPlanWeek.MenuManager = this.screenToolbar;
            this.fld_bedMMOperationDetailPlanWeek.Name = "fld_bedMMOperationDetailPlanWeek";
            this.fld_bedMMOperationDetailPlanWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedMMOperationDetailPlanWeek.Properties.EditFormat.FormatString = "N";
            this.fld_bedMMOperationDetailPlanWeek.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_bedMMOperationDetailPlanWeek.Screen = null;
            this.fld_bedMMOperationDetailPlanWeek.Size = new System.Drawing.Size(118, 20);
            this.fld_bedMMOperationDetailPlanWeek.TabIndex = 123;
            this.fld_bedMMOperationDetailPlanWeek.Tag = "DC";
            this.fld_bedMMOperationDetailPlanWeek.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bedMMOperationDetailPlanWeek_ButtonClick);
            this.fld_bedMMOperationDetailPlanWeek.EditValueChanged += new System.EventHandler(this.Fld_bedMMOperationDetailPlanWeek_EditValueChanged);
            // 
            // fld_dteMMOperationDetailPlanToDate
            // 
            this.fld_dteMMOperationDetailPlanToDate.BOSComment = "";
            this.fld_dteMMOperationDetailPlanToDate.BOSDataMember = "";
            this.fld_dteMMOperationDetailPlanToDate.BOSDataSource = "";
            this.fld_dteMMOperationDetailPlanToDate.BOSDescription = null;
            this.fld_dteMMOperationDetailPlanToDate.BOSError = null;
            this.fld_dteMMOperationDetailPlanToDate.BOSFieldGroup = "";
            this.fld_dteMMOperationDetailPlanToDate.BOSFieldRelation = "";
            this.fld_dteMMOperationDetailPlanToDate.BOSPrivilege = "";
            this.fld_dteMMOperationDetailPlanToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMOperationDetailPlanToDate.EditValue = null;
            this.fld_dteMMOperationDetailPlanToDate.Location = new System.Drawing.Point(80, 69);
            this.fld_dteMMOperationDetailPlanToDate.Name = "fld_dteMMOperationDetailPlanToDate";
            this.fld_dteMMOperationDetailPlanToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMOperationDetailPlanToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMOperationDetailPlanToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMOperationDetailPlanToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMOperationDetailPlanToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMOperationDetailPlanToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMOperationDetailPlanToDate.Screen = null;
            this.fld_dteMMOperationDetailPlanToDate.Size = new System.Drawing.Size(118, 20);
            this.fld_dteMMOperationDetailPlanToDate.TabIndex = 2;
            this.fld_dteMMOperationDetailPlanToDate.Tag = "DC";
            this.fld_dteMMOperationDetailPlanToDate.Validated += new System.EventHandler(this.Fld_dteMMOperationDetailPlanToDate_Validated);
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(15, 74);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(47, 13);
            this.bosLabel14.TabIndex = 18;
            this.bosLabel14.Text = "Đến ngày";
            // 
            // fld_dteMMOperationDetailPlanFromDate
            // 
            this.fld_dteMMOperationDetailPlanFromDate.BOSComment = "";
            this.fld_dteMMOperationDetailPlanFromDate.BOSDataMember = "";
            this.fld_dteMMOperationDetailPlanFromDate.BOSDataSource = "";
            this.fld_dteMMOperationDetailPlanFromDate.BOSDescription = null;
            this.fld_dteMMOperationDetailPlanFromDate.BOSError = null;
            this.fld_dteMMOperationDetailPlanFromDate.BOSFieldGroup = "";
            this.fld_dteMMOperationDetailPlanFromDate.BOSFieldRelation = "";
            this.fld_dteMMOperationDetailPlanFromDate.BOSPrivilege = "";
            this.fld_dteMMOperationDetailPlanFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMOperationDetailPlanFromDate.EditValue = null;
            this.fld_dteMMOperationDetailPlanFromDate.Location = new System.Drawing.Point(80, 45);
            this.fld_dteMMOperationDetailPlanFromDate.Name = "fld_dteMMOperationDetailPlanFromDate";
            this.fld_dteMMOperationDetailPlanFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMOperationDetailPlanFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMOperationDetailPlanFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMOperationDetailPlanFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMOperationDetailPlanFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMOperationDetailPlanFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMOperationDetailPlanFromDate.Screen = null;
            this.fld_dteMMOperationDetailPlanFromDate.Size = new System.Drawing.Size(118, 20);
            this.fld_dteMMOperationDetailPlanFromDate.TabIndex = 2;
            this.fld_dteMMOperationDetailPlanFromDate.Tag = "DC";
            this.fld_dteMMOperationDetailPlanFromDate.Validated += new System.EventHandler(this.Fld_dteMMOperationDetailPlanFromDate_Validated);
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(15, 49);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 18;
            this.bosLabel6.Text = "Từ ngày";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = "";
            this.bosLabel10.Location = new System.Drawing.Point(15, 25);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(25, 13);
            this.bosLabel10.TabIndex = 27;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Tuần";
            // 
            // fld_tabOperationPlanList
            // 
            this.fld_tabOperationPlanList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabOperationPlanList.BOSComment = null;
            this.fld_tabOperationPlanList.BOSDataMember = null;
            this.fld_tabOperationPlanList.BOSDataSource = "MMDetailPlanEquipments";
            this.fld_tabOperationPlanList.BOSDescription = null;
            this.fld_tabOperationPlanList.BOSError = null;
            this.fld_tabOperationPlanList.BOSFieldGroup = null;
            this.fld_tabOperationPlanList.BOSFieldRelation = null;
            this.fld_tabOperationPlanList.BOSPrivilege = null;
            this.fld_tabOperationPlanList.BOSPropertyName = null;
            this.fld_tabOperationPlanList.Location = new System.Drawing.Point(3, 104);
            this.fld_tabOperationPlanList.Name = "fld_tabOperationPlanList";
            this.fld_tabOperationPlanList.Screen = null;
            this.fld_tabOperationPlanList.SelectedTabPage = this.fld_tabDetailPlan;
            this.ScreenHelper.SetShowHelp(this.fld_tabOperationPlanList, true);
            this.fld_tabOperationPlanList.Size = new System.Drawing.Size(1751, 748);
            this.fld_tabOperationPlanList.TabIndex = 30;
            this.fld_tabOperationPlanList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabDetailPlan,
            this.fld_tabHumanUnit,
            this.fld_tabMachineUnit,
            this.fld_xtabEquipment,
            this.fld_tabJobTicket});
            this.fld_tabOperationPlanList.Tag = "DC";
            this.fld_tabOperationPlanList.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.Fld_tabOperationPlanList_SelectedPageChanged);
            // 
            // fld_tabDetailPlan
            // 
            this.fld_tabDetailPlan.Controls.Add(this.fld_btnEditMachine);
            this.fld_tabDetailPlan.Controls.Add(this.fld_btnEditHuman);
            this.fld_tabDetailPlan.Controls.Add(this.fld_lkeMachine);
            this.fld_tabDetailPlan.Controls.Add(this.bosLabel27);
            this.fld_tabDetailPlan.Controls.Add(this.fld_lkeHuman);
            this.fld_tabDetailPlan.Controls.Add(this.bosLabel26);
            this.fld_tabDetailPlan.Controls.Add(this.fld_lblStatusLate);
            this.fld_tabDetailPlan.Controls.Add(this.fld_btnStatusLate);
            this.fld_tabDetailPlan.Controls.Add(this.fld_chkStatusClosed);
            this.fld_tabDetailPlan.Controls.Add(this.fld_chkStatusCanceled);
            this.fld_tabDetailPlan.Controls.Add(this.fld_chkStatusNew);
            this.fld_tabDetailPlan.Controls.Add(this.fld_chkStatusApproved);
            this.fld_tabDetailPlan.Controls.Add(this.fld_chkSelectAllPlan);
            this.fld_tabDetailPlan.Controls.Add(this.fld_dgcMMOperationDetailPlanItemChilds);
            this.fld_tabDetailPlan.Name = "fld_tabDetailPlan";
            this.ScreenHelper.SetShowHelp(this.fld_tabDetailPlan, true);
            this.fld_tabDetailPlan.Size = new System.Drawing.Size(1745, 720);
            this.fld_tabDetailPlan.Text = "DS kế hoạch chi tiết";
            // 
            // fld_btnEditMachine
            // 
            this.fld_btnEditMachine.BOSComment = null;
            this.fld_btnEditMachine.BOSDataMember = null;
            this.fld_btnEditMachine.BOSDataSource = null;
            this.fld_btnEditMachine.BOSDescription = null;
            this.fld_btnEditMachine.BOSError = null;
            this.fld_btnEditMachine.BOSFieldGroup = null;
            this.fld_btnEditMachine.BOSFieldRelation = null;
            this.fld_btnEditMachine.BOSPrivilege = null;
            this.fld_btnEditMachine.BOSPropertyName = null;
            this.fld_btnEditMachine.Location = new System.Drawing.Point(1090, 9);
            this.fld_btnEditMachine.Name = "fld_btnEditMachine";
            this.fld_btnEditMachine.Screen = null;
            this.fld_btnEditMachine.Size = new System.Drawing.Size(171, 22);
            this.fld_btnEditMachine.TabIndex = 10;
            this.fld_btnEditMachine.Text = "Thêm hoặc sửa nguồn lực";
            this.fld_btnEditMachine.Click += new System.EventHandler(this.fld_btnEditMachine_Click);
            // 
            // fld_btnEditHuman
            // 
            this.fld_btnEditHuman.BOSComment = null;
            this.fld_btnEditHuman.BOSDataMember = null;
            this.fld_btnEditHuman.BOSDataSource = null;
            this.fld_btnEditHuman.BOSDescription = null;
            this.fld_btnEditHuman.BOSError = null;
            this.fld_btnEditHuman.BOSFieldGroup = null;
            this.fld_btnEditHuman.BOSFieldRelation = null;
            this.fld_btnEditHuman.BOSPrivilege = null;
            this.fld_btnEditHuman.BOSPropertyName = null;
            this.fld_btnEditHuman.Location = new System.Drawing.Point(913, 9);
            this.fld_btnEditHuman.Name = "fld_btnEditHuman";
            this.fld_btnEditHuman.Screen = null;
            this.fld_btnEditHuman.Size = new System.Drawing.Size(171, 22);
            this.fld_btnEditHuman.TabIndex = 10;
            this.fld_btnEditHuman.Text = "Thêm hoặc sửa nhân công";
            this.fld_btnEditHuman.Click += new System.EventHandler(this.fld_btnEditHuman_Click);
            // 
            // fld_lkeMachine
            // 
            this.fld_lkeMachine.BOSAllowAddNew = false;
            this.fld_lkeMachine.BOSAllowDummy = false;
            this.fld_lkeMachine.BOSComment = "";
            this.fld_lkeMachine.BOSDataMember = "";
            this.fld_lkeMachine.BOSDataSource = "";
            this.fld_lkeMachine.BOSDescription = null;
            this.fld_lkeMachine.BOSError = null;
            this.fld_lkeMachine.BOSFieldGroup = "";
            this.fld_lkeMachine.BOSFieldParent = "";
            this.fld_lkeMachine.BOSFieldRelation = "";
            this.fld_lkeMachine.BOSPrivilege = "";
            this.fld_lkeMachine.BOSPropertyName = "EditValue";
            this.fld_lkeMachine.BOSSelectType = "";
            this.fld_lkeMachine.BOSSelectTypeValue = "";
            this.fld_lkeMachine.CurrentDisplayText = "";
            this.fld_lkeMachine.Location = new System.Drawing.Point(640, 12);
            this.fld_lkeMachine.Name = "fld_lkeMachine";
            this.fld_lkeMachine.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMachine.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMachine.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMachine.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMachine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMachine.Properties.ColumnName = null;
            this.fld_lkeMachine.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Loại")});
            this.fld_lkeMachine.Properties.DisplayMember = "Name";
            this.fld_lkeMachine.Properties.NullText = "";
            this.fld_lkeMachine.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMachine.Properties.ValueMember = "Code";
            this.fld_lkeMachine.Screen = null;
            this.fld_lkeMachine.Size = new System.Drawing.Size(95, 20);
            this.fld_lkeMachine.TabIndex = 135;
            this.fld_lkeMachine.Tag = "DC";
            this.fld_lkeMachine.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeMachine_CloseUp);
            this.fld_lkeMachine.Validated += new System.EventHandler(this.Fld_lkeMachine_Validated);
            // 
            // bosLabel27
            // 
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(579, 15);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(46, 13);
            this.bosLabel27.TabIndex = 134;
            this.bosLabel27.Text = "Máy móc:";
            // 
            // fld_lkeHuman
            // 
            this.fld_lkeHuman.BOSAllowAddNew = false;
            this.fld_lkeHuman.BOSAllowDummy = false;
            this.fld_lkeHuman.BOSComment = "";
            this.fld_lkeHuman.BOSDataMember = "";
            this.fld_lkeHuman.BOSDataSource = "";
            this.fld_lkeHuman.BOSDescription = null;
            this.fld_lkeHuman.BOSError = null;
            this.fld_lkeHuman.BOSFieldGroup = "";
            this.fld_lkeHuman.BOSFieldParent = "";
            this.fld_lkeHuman.BOSFieldRelation = "";
            this.fld_lkeHuman.BOSPrivilege = "";
            this.fld_lkeHuman.BOSPropertyName = "EditValue";
            this.fld_lkeHuman.BOSSelectType = "";
            this.fld_lkeHuman.BOSSelectTypeValue = "";
            this.fld_lkeHuman.CurrentDisplayText = "";
            this.fld_lkeHuman.Location = new System.Drawing.Point(464, 12);
            this.fld_lkeHuman.Name = "fld_lkeHuman";
            this.fld_lkeHuman.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHuman.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHuman.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHuman.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHuman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHuman.Properties.ColumnName = null;
            this.fld_lkeHuman.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Loại")});
            this.fld_lkeHuman.Properties.DisplayMember = "Name";
            this.fld_lkeHuman.Properties.NullText = "";
            this.fld_lkeHuman.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHuman.Properties.ValueMember = "Code";
            this.fld_lkeHuman.Screen = null;
            this.fld_lkeHuman.Size = new System.Drawing.Size(95, 20);
            this.fld_lkeHuman.TabIndex = 133;
            this.fld_lkeHuman.Tag = "DC";
            this.fld_lkeHuman.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeHuman_CloseUp);
            // 
            // bosLabel26
            // 
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = null;
            this.bosLabel26.BOSDataSource = null;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(403, 15);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(55, 13);
            this.bosLabel26.TabIndex = 132;
            this.bosLabel26.Text = "Nhân công:";
            // 
            // fld_lblStatusLate
            // 
            this.fld_lblStatusLate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_lblStatusLate.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.fld_lblStatusLate.Appearance.Options.UseFont = true;
            this.fld_lblStatusLate.BOSComment = null;
            this.fld_lblStatusLate.BOSDataMember = null;
            this.fld_lblStatusLate.BOSDataSource = null;
            this.fld_lblStatusLate.BOSDescription = null;
            this.fld_lblStatusLate.BOSError = null;
            this.fld_lblStatusLate.BOSFieldGroup = null;
            this.fld_lblStatusLate.BOSFieldRelation = null;
            this.fld_lblStatusLate.BOSPrivilege = null;
            this.fld_lblStatusLate.BOSPropertyName = null;
            this.fld_lblStatusLate.Location = new System.Drawing.Point(47, 703);
            this.fld_lblStatusLate.Name = "fld_lblStatusLate";
            this.fld_lblStatusLate.Screen = null;
            this.fld_lblStatusLate.Size = new System.Drawing.Size(55, 12);
            this.fld_lblStatusLate.TabIndex = 131;
            this.fld_lblStatusLate.Text = "Trễ tiến độ";
            // 
            // fld_btnStatusLate
            // 
            this.fld_btnStatusLate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnStatusLate.BackColor = System.Drawing.Color.Red;
            this.fld_btnStatusLate.Enabled = false;
            this.fld_btnStatusLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fld_btnStatusLate.Font = new System.Drawing.Font("Tahoma", 7F);
            this.fld_btnStatusLate.Location = new System.Drawing.Point(18, 701);
            this.fld_btnStatusLate.Name = "fld_btnStatusLate";
            this.fld_btnStatusLate.Size = new System.Drawing.Size(20, 15);
            this.fld_btnStatusLate.TabIndex = 129;
            this.fld_btnStatusLate.UseVisualStyleBackColor = false;
            // 
            // fld_chkStatusClosed
            // 
            this.fld_chkStatusClosed.BOSComment = null;
            this.fld_chkStatusClosed.BOSDataMember = null;
            this.fld_chkStatusClosed.BOSDataSource = null;
            this.fld_chkStatusClosed.BOSDescription = null;
            this.fld_chkStatusClosed.BOSError = null;
            this.fld_chkStatusClosed.BOSFieldGroup = null;
            this.fld_chkStatusClosed.BOSFieldRelation = null;
            this.fld_chkStatusClosed.BOSPrivilege = null;
            this.fld_chkStatusClosed.BOSPropertyName = null;
            this.fld_chkStatusClosed.Location = new System.Drawing.Point(210, 12);
            this.fld_chkStatusClosed.Name = "fld_chkStatusClosed";
            this.fld_chkStatusClosed.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fld_chkStatusClosed.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusClosed.Properties.Caption = "Đã đóng";
            this.fld_chkStatusClosed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkStatusClosed.Screen = null;
            this.fld_chkStatusClosed.Size = new System.Drawing.Size(70, 19);
            this.fld_chkStatusClosed.TabIndex = 126;
            this.fld_chkStatusClosed.CheckedChanged += new System.EventHandler(this.Fld_chkStatusClosed_CheckedChanged);
            // 
            // fld_chkStatusCanceled
            // 
            this.fld_chkStatusCanceled.BOSComment = null;
            this.fld_chkStatusCanceled.BOSDataMember = null;
            this.fld_chkStatusCanceled.BOSDataSource = null;
            this.fld_chkStatusCanceled.BOSDescription = null;
            this.fld_chkStatusCanceled.BOSError = null;
            this.fld_chkStatusCanceled.BOSFieldGroup = null;
            this.fld_chkStatusCanceled.BOSFieldRelation = null;
            this.fld_chkStatusCanceled.BOSPrivilege = null;
            this.fld_chkStatusCanceled.BOSPropertyName = null;
            this.fld_chkStatusCanceled.Location = new System.Drawing.Point(306, 12);
            this.fld_chkStatusCanceled.Name = "fld_chkStatusCanceled";
            this.fld_chkStatusCanceled.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.fld_chkStatusCanceled.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusCanceled.Properties.Caption = "Đã hủy";
            this.fld_chkStatusCanceled.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkStatusCanceled.Screen = null;
            this.fld_chkStatusCanceled.Size = new System.Drawing.Size(70, 19);
            this.fld_chkStatusCanceled.TabIndex = 127;
            this.fld_chkStatusCanceled.Tag = "DC";
            this.fld_chkStatusCanceled.CheckedChanged += new System.EventHandler(this.Fld_chkStatusCanceled_CheckedChanged);
            // 
            // fld_chkStatusNew
            // 
            this.fld_chkStatusNew.BOSComment = null;
            this.fld_chkStatusNew.BOSDataMember = null;
            this.fld_chkStatusNew.BOSDataSource = null;
            this.fld_chkStatusNew.BOSDescription = null;
            this.fld_chkStatusNew.BOSError = null;
            this.fld_chkStatusNew.BOSFieldGroup = null;
            this.fld_chkStatusNew.BOSFieldRelation = null;
            this.fld_chkStatusNew.BOSPrivilege = null;
            this.fld_chkStatusNew.BOSPropertyName = null;
            this.fld_chkStatusNew.EditValue = true;
            this.fld_chkStatusNew.Location = new System.Drawing.Point(26, 12);
            this.fld_chkStatusNew.MenuManager = this.screenToolbar;
            this.fld_chkStatusNew.Name = "fld_chkStatusNew";
            this.fld_chkStatusNew.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_chkStatusNew.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusNew.Properties.Caption = "Tạo mới";
            this.fld_chkStatusNew.Screen = null;
            this.fld_chkStatusNew.Size = new System.Drawing.Size(76, 19);
            this.fld_chkStatusNew.TabIndex = 124;
            this.fld_chkStatusNew.Tag = "DC";
            this.fld_chkStatusNew.CheckedChanged += new System.EventHandler(this.Fld_chkStatusNew_CheckedChanged);
            // 
            // fld_chkStatusApproved
            // 
            this.fld_chkStatusApproved.BOSComment = null;
            this.fld_chkStatusApproved.BOSDataMember = null;
            this.fld_chkStatusApproved.BOSDataSource = null;
            this.fld_chkStatusApproved.BOSDescription = null;
            this.fld_chkStatusApproved.BOSError = null;
            this.fld_chkStatusApproved.BOSFieldGroup = null;
            this.fld_chkStatusApproved.BOSFieldRelation = null;
            this.fld_chkStatusApproved.BOSPrivilege = null;
            this.fld_chkStatusApproved.BOSPropertyName = null;
            this.fld_chkStatusApproved.EditValue = true;
            this.fld_chkStatusApproved.Location = new System.Drawing.Point(108, 12);
            this.fld_chkStatusApproved.MenuManager = this.screenToolbar;
            this.fld_chkStatusApproved.Name = "fld_chkStatusApproved";
            this.fld_chkStatusApproved.Properties.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.fld_chkStatusApproved.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusApproved.Properties.Caption = "Đã tạo thẻ";
            this.fld_chkStatusApproved.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkStatusApproved.Screen = null;
            this.fld_chkStatusApproved.Size = new System.Drawing.Size(76, 19);
            this.fld_chkStatusApproved.TabIndex = 125;
            this.fld_chkStatusApproved.Tag = "DC";
            this.fld_chkStatusApproved.CheckedChanged += new System.EventHandler(this.Fld_chkStatusApproved_CheckedChanged);
            // 
            // fld_chkSelectAllPlan
            // 
            this.fld_chkSelectAllPlan.BOSComment = null;
            this.fld_chkSelectAllPlan.BOSDataMember = null;
            this.fld_chkSelectAllPlan.BOSDataSource = null;
            this.fld_chkSelectAllPlan.BOSDescription = null;
            this.fld_chkSelectAllPlan.BOSError = null;
            this.fld_chkSelectAllPlan.BOSFieldGroup = null;
            this.fld_chkSelectAllPlan.BOSFieldRelation = null;
            this.fld_chkSelectAllPlan.BOSPrivilege = null;
            this.fld_chkSelectAllPlan.BOSPropertyName = null;
            this.fld_chkSelectAllPlan.Location = new System.Drawing.Point(762, 12);
            this.fld_chkSelectAllPlan.MenuManager = this.screenToolbar;
            this.fld_chkSelectAllPlan.Name = "fld_chkSelectAllPlan";
            this.fld_chkSelectAllPlan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_chkSelectAllPlan.Properties.Appearance.Options.UseFont = true;
            this.fld_chkSelectAllPlan.Properties.Caption = "Chọn tất cả chi tiết";
            this.fld_chkSelectAllPlan.Screen = null;
            this.fld_chkSelectAllPlan.Size = new System.Drawing.Size(145, 19);
            this.fld_chkSelectAllPlan.TabIndex = 123;
            this.fld_chkSelectAllPlan.CheckedChanged += new System.EventHandler(this.Fld_chkSelectAll_CheckedChanged);
            // 
            // fld_dgcMMOperationDetailPlanItemChilds
            // 
            this.fld_dgcMMOperationDetailPlanItemChilds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSComment = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSDataMember = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSDataSource = "MMOperationDetailPlanItemChilds";
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSDescription = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSError = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSFieldGroup = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSFieldRelation = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSGridType = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSPrivilege = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.BOSPropertyName = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.CommodityType = "";
            this.fld_dgcMMOperationDetailPlanItemChilds.Location = new System.Drawing.Point(0, 37);
            this.fld_dgcMMOperationDetailPlanItemChilds.MenuManager = this.screenToolbar;
            this.fld_dgcMMOperationDetailPlanItemChilds.Name = "fld_dgcMMOperationDetailPlanItemChilds";
            this.fld_dgcMMOperationDetailPlanItemChilds.PrintReport = false;
            this.fld_dgcMMOperationDetailPlanItemChilds.Screen = null;
            this.fld_dgcMMOperationDetailPlanItemChilds.Size = new System.Drawing.Size(1741, 660);
            this.fld_dgcMMOperationDetailPlanItemChilds.TabIndex = 1;
            // 
            // fld_tabHumanUnit
            // 
            this.fld_tabHumanUnit.Controls.Add(this.fld_btnZoomHuman);
            this.fld_tabHumanUnit.Controls.Add(this.fld_spcHuman);
            this.fld_tabHumanUnit.Name = "fld_tabHumanUnit";
            this.fld_tabHumanUnit.Size = new System.Drawing.Size(1739, 713);
            this.fld_tabHumanUnit.Text = "Danh sách nhân công";
            // 
            // fld_btnZoomHuman
            // 
            this.fld_btnZoomHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomHuman.BOSComment = null;
            this.fld_btnZoomHuman.BOSDataMember = null;
            this.fld_btnZoomHuman.BOSDataSource = null;
            this.fld_btnZoomHuman.BOSDescription = null;
            this.fld_btnZoomHuman.BOSError = null;
            this.fld_btnZoomHuman.BOSFieldGroup = null;
            this.fld_btnZoomHuman.BOSFieldRelation = null;
            this.fld_btnZoomHuman.BOSPrivilege = null;
            this.fld_btnZoomHuman.BOSPropertyName = null;
            this.fld_btnZoomHuman.Location = new System.Drawing.Point(1717, 0);
            this.fld_btnZoomHuman.Name = "fld_btnZoomHuman";
            this.fld_btnZoomHuman.Screen = null;
            this.fld_btnZoomHuman.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomHuman.TabIndex = 406;
            this.fld_btnZoomHuman.Text = "❐";
            this.fld_btnZoomHuman.ToolTip = "Phóng to";
            this.fld_btnZoomHuman.Click += new System.EventHandler(this.Fld_btnZoomHuman_Click);
            // 
            // fld_spcHuman
            // 
            this.fld_spcHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_spcHuman.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_spcHuman.Location = new System.Drawing.Point(0, 26);
            this.fld_spcHuman.Name = "fld_spcHuman";
            this.fld_spcHuman.Panel1.Controls.Add(this.fld_btnCancelHuman);
            this.fld_spcHuman.Panel1.Controls.Add(this.fld_btnAddHuman);
            this.fld_spcHuman.Panel1.Controls.Add(this.bosLine4);
            this.fld_spcHuman.Panel1.Text = "Panel1";
            this.fld_spcHuman.Panel2.Controls.Add(this.fld_Detail);
            this.fld_spcHuman.Panel2.Text = "Panel2";
            this.fld_spcHuman.Size = new System.Drawing.Size(1736, 681);
            this.fld_spcHuman.SplitterPosition = 566;
            this.fld_spcHuman.TabIndex = 415;
            this.fld_spcHuman.Text = "splitContainerControl1";
            // 
            // fld_btnCancelHuman
            // 
            this.fld_btnCancelHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancelHuman.BOSComment = null;
            this.fld_btnCancelHuman.BOSDataMember = null;
            this.fld_btnCancelHuman.BOSDataSource = null;
            this.fld_btnCancelHuman.BOSDescription = null;
            this.fld_btnCancelHuman.BOSError = null;
            this.fld_btnCancelHuman.BOSFieldGroup = null;
            this.fld_btnCancelHuman.BOSFieldRelation = null;
            this.fld_btnCancelHuman.BOSPrivilege = null;
            this.fld_btnCancelHuman.BOSPropertyName = null;
            this.fld_btnCancelHuman.Location = new System.Drawing.Point(514, 317);
            this.fld_btnCancelHuman.Name = "fld_btnCancelHuman";
            this.fld_btnCancelHuman.Screen = null;
            this.fld_btnCancelHuman.Size = new System.Drawing.Size(48, 27);
            this.fld_btnCancelHuman.TabIndex = 408;
            this.fld_btnCancelHuman.Text = "Hủy";
            this.fld_btnCancelHuman.Click += new System.EventHandler(this.Fld_btnCancelHuman_Click);
            // 
            // fld_btnAddHuman
            // 
            this.fld_btnAddHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddHuman.BOSComment = null;
            this.fld_btnAddHuman.BOSDataMember = null;
            this.fld_btnAddHuman.BOSDataSource = null;
            this.fld_btnAddHuman.BOSDescription = null;
            this.fld_btnAddHuman.BOSError = null;
            this.fld_btnAddHuman.BOSFieldGroup = null;
            this.fld_btnAddHuman.BOSFieldRelation = null;
            this.fld_btnAddHuman.BOSPrivilege = null;
            this.fld_btnAddHuman.BOSPropertyName = null;
            this.fld_btnAddHuman.Location = new System.Drawing.Point(514, 284);
            this.fld_btnAddHuman.Name = "fld_btnAddHuman";
            this.fld_btnAddHuman.Screen = null;
            this.fld_btnAddHuman.Size = new System.Drawing.Size(48, 27);
            this.fld_btnAddHuman.TabIndex = 408;
            this.fld_btnAddHuman.Text = "<Gán>";
            this.fld_btnAddHuman.Click += new System.EventHandler(this.Fld_btnAddHuman_Click);
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_bteHumanOperation);
            this.bosLine4.Controls.Add(this.bosLabel12);
            this.bosLine4.Controls.Add(this.fld_lkeHumanHRDepartmentID);
            this.bosLine4.Controls.Add(this.bosLabel15);
            this.bosLine4.Controls.Add(this.fld_chkHumanNotTicket);
            this.bosLine4.Controls.Add(this.fld_trlHumanUnits);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(0, 0);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(508, 677);
            this.bosLine4.TabIndex = 407;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Danh sách nhân công";
            // 
            // fld_bteHumanOperation
            // 
            this.fld_bteHumanOperation.BOSComment = null;
            this.fld_bteHumanOperation.BOSDataMember = "";
            this.fld_bteHumanOperation.BOSDataSource = "";
            this.fld_bteHumanOperation.BOSDescription = null;
            this.fld_bteHumanOperation.BOSError = null;
            this.fld_bteHumanOperation.BOSFieldGroup = null;
            this.fld_bteHumanOperation.BOSFieldRelation = null;
            this.fld_bteHumanOperation.BOSPrivilege = null;
            this.fld_bteHumanOperation.BOSPropertyName = "Text";
            this.fld_bteHumanOperation.Location = new System.Drawing.Point(99, 20);
            this.fld_bteHumanOperation.Name = "fld_bteHumanOperation";
            this.fld_bteHumanOperation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteHumanOperation.Properties.EditFormat.FormatString = "N";
            this.fld_bteHumanOperation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_bteHumanOperation.Screen = null;
            this.fld_bteHumanOperation.Size = new System.Drawing.Size(148, 20);
            this.fld_bteHumanOperation.TabIndex = 127;
            this.fld_bteHumanOperation.Tag = "DC";
            this.fld_bteHumanOperation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bteHumanOperation_ButtonClick);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(24, 23);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(52, 13);
            this.bosLabel12.TabIndex = 125;
            this.bosLabel12.Text = "Công đoạn";
            // 
            // fld_lkeHumanHRDepartmentID
            // 
            this.fld_lkeHumanHRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeHumanHRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeHumanHRDepartmentID.BOSComment = null;
            this.fld_lkeHumanHRDepartmentID.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHumanHRDepartmentID.BOSDataSource = "HRDepartments";
            this.fld_lkeHumanHRDepartmentID.BOSDescription = null;
            this.fld_lkeHumanHRDepartmentID.BOSError = null;
            this.fld_lkeHumanHRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeHumanHRDepartmentID.BOSFieldParent = "";
            this.fld_lkeHumanHRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeHumanHRDepartmentID.BOSPrivilege = null;
            this.fld_lkeHumanHRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeHumanHRDepartmentID.BOSSelectType = "HRDepartmentIsBatch";
            this.fld_lkeHumanHRDepartmentID.BOSSelectTypeValue = "True";
            this.fld_lkeHumanHRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeHumanHRDepartmentID.Location = new System.Drawing.Point(345, 20);
            this.fld_lkeHumanHRDepartmentID.Name = "fld_lkeHumanHRDepartmentID";
            this.fld_lkeHumanHRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHumanHRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHumanHRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHumanHRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHumanHRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHumanHRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeHumanHRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeHumanHRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHumanHRDepartmentID.Properties.NullText = "";
            this.fld_lkeHumanHRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeHumanHRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHumanHRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHumanHRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHumanHRDepartmentID, true);
            this.fld_lkeHumanHRDepartmentID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeHumanHRDepartmentID.TabIndex = 123;
            this.fld_lkeHumanHRDepartmentID.Tag = "DC";
            this.fld_lkeHumanHRDepartmentID.EditValueChanged += new System.EventHandler(this.Fld_lkeHumanHRDepartmentID_EditValueChanged);
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(270, 23);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(51, 13);
            this.bosLabel15.TabIndex = 124;
            this.bosLabel15.Tag = "DC";
            this.bosLabel15.Text = "Phòng ban";
            // 
            // fld_chkHumanNotTicket
            // 
            this.fld_chkHumanNotTicket.BOSComment = null;
            this.fld_chkHumanNotTicket.BOSDataMember = null;
            this.fld_chkHumanNotTicket.BOSDataSource = null;
            this.fld_chkHumanNotTicket.BOSDescription = null;
            this.fld_chkHumanNotTicket.BOSError = null;
            this.fld_chkHumanNotTicket.BOSFieldGroup = null;
            this.fld_chkHumanNotTicket.BOSFieldRelation = null;
            this.fld_chkHumanNotTicket.BOSPrivilege = null;
            this.fld_chkHumanNotTicket.BOSPropertyName = null;
            this.fld_chkHumanNotTicket.Location = new System.Drawing.Point(24, 46);
            this.fld_chkHumanNotTicket.MenuManager = this.screenToolbar;
            this.fld_chkHumanNotTicket.Name = "fld_chkHumanNotTicket";
            this.fld_chkHumanNotTicket.Properties.Caption = "Chỉ hiển thị nhân công chưa giao việc";
            this.fld_chkHumanNotTicket.Screen = null;
            this.fld_chkHumanNotTicket.Size = new System.Drawing.Size(220, 19);
            this.fld_chkHumanNotTicket.TabIndex = 122;
            this.fld_chkHumanNotTicket.CheckedChanged += new System.EventHandler(this.Fld_chkAllHuman_CheckedChanged);
            // 
            // fld_trlHumanUnits
            // 
            this.fld_trlHumanUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlHumanUnits.bindingListSource = null;
            this.fld_trlHumanUnits.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_trlHumanUnits.KeyFieldName = "HRDepartmentRoomGroupItemID";
            this.fld_trlHumanUnits.Location = new System.Drawing.Point(3, 71);
            this.fld_trlHumanUnits.Module = null;
            this.fld_trlHumanUnits.Name = "fld_trlHumanUnits";
            this.fld_trlHumanUnits.ParentFieldName = "HRDepartmentRoomGroupItemParentID";
            this.fld_trlHumanUnits.ResultList = null;
            this.fld_trlHumanUnits.RoomGroupItemDataList = null;
            this.fld_trlHumanUnits.Size = new System.Drawing.Size(499, 606);
            this.fld_trlHumanUnits.TabIndex = 101;
            // 
            // fld_Detail
            // 
            this.fld_Detail.BOSComment = null;
            this.fld_Detail.BOSDataMember = null;
            this.fld_Detail.BOSDataSource = null;
            this.fld_Detail.BOSDescription = null;
            this.fld_Detail.BOSError = null;
            this.fld_Detail.BOSFieldGroup = null;
            this.fld_Detail.BOSFieldRelation = null;
            this.fld_Detail.BOSPrivilege = null;
            this.fld_Detail.BOSPropertyName = null;
            this.fld_Detail.Controls.Add(this.bosLabel24);
            this.fld_Detail.Controls.Add(this.fld_lblTotalBlock);
            this.fld_Detail.Controls.Add(this.fld_lblTotalQty);
            this.fld_Detail.Controls.Add(this.bosLabel11);
            this.fld_Detail.Controls.Add(this.fld_ckeSelectAllHumanticket);
            this.fld_Detail.Controls.Add(this.fld_ckeDetailPlanHumanAllowcation);
            this.fld_Detail.Controls.Add(this.fld_ckeHumanPlanByOperation);
            this.fld_Detail.Controls.Add(this.fld_chkAllHumanDetailPlanItem);
            this.fld_Detail.Controls.Add(this.fld_dgcHumanDetailPlanItems);
            this.fld_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_Detail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_Detail.Location = new System.Drawing.Point(0, 0);
            this.fld_Detail.Name = "fld_Detail";
            this.fld_Detail.Screen = null;
            this.fld_Detail.Size = new System.Drawing.Size(1161, 677);
            this.fld_Detail.TabIndex = 405;
            this.fld_Detail.TabStop = false;
            this.fld_Detail.Text = "Chi tiết công việc theo từng nhân công";
            // 
            // bosLabel24
            // 
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(559, 48);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(45, 13);
            this.bosLabel24.TabIndex = 125;
            this.bosLabel24.Text = "Tổng M3:";
            // 
            // fld_lblTotalBlock
            // 
            this.fld_lblTotalBlock.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblTotalBlock.Appearance.Options.UseFont = true;
            this.fld_lblTotalBlock.BOSComment = null;
            this.fld_lblTotalBlock.BOSDataMember = null;
            this.fld_lblTotalBlock.BOSDataSource = null;
            this.fld_lblTotalBlock.BOSDescription = null;
            this.fld_lblTotalBlock.BOSError = null;
            this.fld_lblTotalBlock.BOSFieldGroup = null;
            this.fld_lblTotalBlock.BOSFieldRelation = null;
            this.fld_lblTotalBlock.BOSPrivilege = null;
            this.fld_lblTotalBlock.BOSPropertyName = null;
            this.fld_lblTotalBlock.Location = new System.Drawing.Point(617, 48);
            this.fld_lblTotalBlock.Name = "fld_lblTotalBlock";
            this.fld_lblTotalBlock.Screen = null;
            this.fld_lblTotalBlock.Size = new System.Drawing.Size(7, 13);
            this.fld_lblTotalBlock.TabIndex = 125;
            this.fld_lblTotalBlock.Text = "0";
            // 
            // fld_lblTotalQty
            // 
            this.fld_lblTotalQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblTotalQty.Appearance.Options.UseFont = true;
            this.fld_lblTotalQty.BOSComment = null;
            this.fld_lblTotalQty.BOSDataMember = null;
            this.fld_lblTotalQty.BOSDataSource = null;
            this.fld_lblTotalQty.BOSDescription = null;
            this.fld_lblTotalQty.BOSError = null;
            this.fld_lblTotalQty.BOSFieldGroup = null;
            this.fld_lblTotalQty.BOSFieldRelation = null;
            this.fld_lblTotalQty.BOSPrivilege = null;
            this.fld_lblTotalQty.BOSPropertyName = null;
            this.fld_lblTotalQty.Location = new System.Drawing.Point(617, 24);
            this.fld_lblTotalQty.Name = "fld_lblTotalQty";
            this.fld_lblTotalQty.Screen = null;
            this.fld_lblTotalQty.Size = new System.Drawing.Size(7, 13);
            this.fld_lblTotalQty.TabIndex = 125;
            this.fld_lblTotalQty.Text = "0";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(559, 23);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(42, 13);
            this.bosLabel11.TabIndex = 125;
            this.bosLabel11.Text = "Tổng SL:";
            // 
            // fld_ckeSelectAllHumanticket
            // 
            this.fld_ckeSelectAllHumanticket.BOSComment = null;
            this.fld_ckeSelectAllHumanticket.BOSDataMember = null;
            this.fld_ckeSelectAllHumanticket.BOSDataSource = null;
            this.fld_ckeSelectAllHumanticket.BOSDescription = null;
            this.fld_ckeSelectAllHumanticket.BOSError = null;
            this.fld_ckeSelectAllHumanticket.BOSFieldGroup = null;
            this.fld_ckeSelectAllHumanticket.BOSFieldRelation = null;
            this.fld_ckeSelectAllHumanticket.BOSPrivilege = null;
            this.fld_ckeSelectAllHumanticket.BOSPropertyName = null;
            this.fld_ckeSelectAllHumanticket.Location = new System.Drawing.Point(282, 46);
            this.fld_ckeSelectAllHumanticket.MenuManager = this.screenToolbar;
            this.fld_ckeSelectAllHumanticket.Name = "fld_ckeSelectAllHumanticket";
            this.fld_ckeSelectAllHumanticket.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_ckeSelectAllHumanticket.Properties.Appearance.Options.UseFont = true;
            this.fld_ckeSelectAllHumanticket.Properties.Caption = "Chọn tất cả công việc";
            this.fld_ckeSelectAllHumanticket.Screen = null;
            this.fld_ckeSelectAllHumanticket.Size = new System.Drawing.Size(145, 19);
            this.fld_ckeSelectAllHumanticket.TabIndex = 124;
            this.fld_ckeSelectAllHumanticket.CheckedChanged += new System.EventHandler(this.Fld_ckeSelectAllHumanticket_CheckedChanged);
            // 
            // fld_ckeDetailPlanHumanAllowcation
            // 
            this.fld_ckeDetailPlanHumanAllowcation.BOSComment = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSDataMember = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSDataSource = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSDescription = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSError = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSFieldGroup = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSFieldRelation = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSPrivilege = null;
            this.fld_ckeDetailPlanHumanAllowcation.BOSPropertyName = null;
            this.fld_ckeDetailPlanHumanAllowcation.Location = new System.Drawing.Point(17, 20);
            this.fld_ckeDetailPlanHumanAllowcation.Name = "fld_ckeDetailPlanHumanAllowcation";
            this.fld_ckeDetailPlanHumanAllowcation.Properties.Caption = "Chỉ hiển thị công việc chưa gán cho nhân viên";
            this.fld_ckeDetailPlanHumanAllowcation.Screen = null;
            this.fld_ckeDetailPlanHumanAllowcation.Size = new System.Drawing.Size(245, 19);
            this.fld_ckeDetailPlanHumanAllowcation.TabIndex = 122;
            this.fld_ckeDetailPlanHumanAllowcation.CheckedChanged += new System.EventHandler(this.Fld_ckeDetailPlanHumanAllowcation_CheckedChanged);
            // 
            // fld_ckeHumanPlanByOperation
            // 
            this.fld_ckeHumanPlanByOperation.BOSComment = null;
            this.fld_ckeHumanPlanByOperation.BOSDataMember = null;
            this.fld_ckeHumanPlanByOperation.BOSDataSource = null;
            this.fld_ckeHumanPlanByOperation.BOSDescription = null;
            this.fld_ckeHumanPlanByOperation.BOSError = null;
            this.fld_ckeHumanPlanByOperation.BOSFieldGroup = null;
            this.fld_ckeHumanPlanByOperation.BOSFieldRelation = null;
            this.fld_ckeHumanPlanByOperation.BOSPrivilege = null;
            this.fld_ckeHumanPlanByOperation.BOSPropertyName = null;
            this.fld_ckeHumanPlanByOperation.Location = new System.Drawing.Point(282, 21);
            this.fld_ckeHumanPlanByOperation.Name = "fld_ckeHumanPlanByOperation";
            this.fld_ckeHumanPlanByOperation.Properties.Caption = "Chỉ hiển thị công việc theo sở trường nhân viên";
            this.fld_ckeHumanPlanByOperation.Screen = null;
            this.fld_ckeHumanPlanByOperation.Size = new System.Drawing.Size(271, 19);
            this.fld_ckeHumanPlanByOperation.TabIndex = 122;
            this.fld_ckeHumanPlanByOperation.CheckedChanged += new System.EventHandler(this.Fld_ckeHumanPlanByOperation_CheckedChanged);
            // 
            // fld_chkAllHumanDetailPlanItem
            // 
            this.fld_chkAllHumanDetailPlanItem.BOSComment = null;
            this.fld_chkAllHumanDetailPlanItem.BOSDataMember = null;
            this.fld_chkAllHumanDetailPlanItem.BOSDataSource = null;
            this.fld_chkAllHumanDetailPlanItem.BOSDescription = null;
            this.fld_chkAllHumanDetailPlanItem.BOSError = null;
            this.fld_chkAllHumanDetailPlanItem.BOSFieldGroup = null;
            this.fld_chkAllHumanDetailPlanItem.BOSFieldRelation = null;
            this.fld_chkAllHumanDetailPlanItem.BOSPrivilege = null;
            this.fld_chkAllHumanDetailPlanItem.BOSPropertyName = null;
            this.fld_chkAllHumanDetailPlanItem.EditValue = true;
            this.fld_chkAllHumanDetailPlanItem.Location = new System.Drawing.Point(17, 45);
            this.fld_chkAllHumanDetailPlanItem.Name = "fld_chkAllHumanDetailPlanItem";
            this.fld_chkAllHumanDetailPlanItem.Properties.Caption = "Chỉ hiển thị công việc đã gán cho nhân viên";
            this.fld_chkAllHumanDetailPlanItem.Screen = null;
            this.fld_chkAllHumanDetailPlanItem.Size = new System.Drawing.Size(262, 19);
            this.fld_chkAllHumanDetailPlanItem.TabIndex = 122;
            this.fld_chkAllHumanDetailPlanItem.CheckedChanged += new System.EventHandler(this.Fld_chkAllHumanDetailPlanItem_CheckedChanged);
            // 
            // fld_dgcHumanDetailPlanItems
            // 
            this.fld_dgcHumanDetailPlanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHumanDetailPlanItems.BOSComment = null;
            this.fld_dgcHumanDetailPlanItems.BOSDataMember = null;
            this.fld_dgcHumanDetailPlanItems.BOSDataSource = "MMOperationDetailPlanItemChilds";
            this.fld_dgcHumanDetailPlanItems.BOSDescription = null;
            this.fld_dgcHumanDetailPlanItems.BOSError = null;
            this.fld_dgcHumanDetailPlanItems.BOSFieldGroup = null;
            this.fld_dgcHumanDetailPlanItems.BOSFieldRelation = null;
            this.fld_dgcHumanDetailPlanItems.BOSGridType = null;
            this.fld_dgcHumanDetailPlanItems.BOSPrivilege = null;
            this.fld_dgcHumanDetailPlanItems.BOSPropertyName = null;
            this.fld_dgcHumanDetailPlanItems.CommodityType = "";
            this.fld_dgcHumanDetailPlanItems.IsEdit = false;
            this.fld_dgcHumanDetailPlanItems.Location = new System.Drawing.Point(3, 70);
            this.fld_dgcHumanDetailPlanItems.MenuManager = this.screenToolbar;
            this.fld_dgcHumanDetailPlanItems.Name = "fld_dgcHumanDetailPlanItems";
            this.fld_dgcHumanDetailPlanItems.PrintReport = false;
            this.fld_dgcHumanDetailPlanItems.Screen = null;
            this.fld_dgcHumanDetailPlanItems.Size = new System.Drawing.Size(1158, 604);
            this.fld_dgcHumanDetailPlanItems.TabIndex = 2;
            // 
            // fld_tabMachineUnit
            // 
            this.fld_tabMachineUnit.Controls.Add(this.fld_btnZoomMachine);
            this.fld_tabMachineUnit.Controls.Add(this.fld_spcMachine);
            this.fld_tabMachineUnit.Name = "fld_tabMachineUnit";
            this.fld_tabMachineUnit.Size = new System.Drawing.Size(1739, 713);
            this.fld_tabMachineUnit.Text = "Danh sách máy móc";
            // 
            // fld_btnZoomMachine
            // 
            this.fld_btnZoomMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomMachine.BOSComment = null;
            this.fld_btnZoomMachine.BOSDataMember = null;
            this.fld_btnZoomMachine.BOSDataSource = null;
            this.fld_btnZoomMachine.BOSDescription = null;
            this.fld_btnZoomMachine.BOSError = null;
            this.fld_btnZoomMachine.BOSFieldGroup = null;
            this.fld_btnZoomMachine.BOSFieldRelation = null;
            this.fld_btnZoomMachine.BOSPrivilege = null;
            this.fld_btnZoomMachine.BOSPropertyName = null;
            this.fld_btnZoomMachine.Location = new System.Drawing.Point(1709, 2);
            this.fld_btnZoomMachine.Name = "fld_btnZoomMachine";
            this.fld_btnZoomMachine.Screen = null;
            this.fld_btnZoomMachine.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomMachine.TabIndex = 407;
            this.fld_btnZoomMachine.Text = "❐";
            this.fld_btnZoomMachine.ToolTip = "Phóng to";
            this.fld_btnZoomMachine.Click += new System.EventHandler(this.Fld_btnZoomMachine_Click);
            // 
            // fld_spcMachine
            // 
            this.fld_spcMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_spcMachine.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_spcMachine.Location = new System.Drawing.Point(0, 25);
            this.fld_spcMachine.Name = "fld_spcMachine";
            this.fld_spcMachine.Panel1.Controls.Add(this.fld_btnCancelMachine);
            this.fld_spcMachine.Panel1.Controls.Add(this.fld_btnAddMachine);
            this.fld_spcMachine.Panel1.Controls.Add(this.bosLine5);
            this.fld_spcMachine.Panel1.Text = "Panel1";
            this.fld_spcMachine.Panel2.Controls.Add(this.bosLine6);
            this.fld_spcMachine.Panel2.Text = "Panel2";
            this.fld_spcMachine.Size = new System.Drawing.Size(1739, 688);
            this.fld_spcMachine.SplitterPosition = 623;
            this.fld_spcMachine.TabIndex = 408;
            this.fld_spcMachine.Text = "splitContainerControl2";
            // 
            // fld_btnCancelMachine
            // 
            this.fld_btnCancelMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancelMachine.BOSComment = null;
            this.fld_btnCancelMachine.BOSDataMember = null;
            this.fld_btnCancelMachine.BOSDataSource = null;
            this.fld_btnCancelMachine.BOSDescription = null;
            this.fld_btnCancelMachine.BOSError = null;
            this.fld_btnCancelMachine.BOSFieldGroup = null;
            this.fld_btnCancelMachine.BOSFieldRelation = null;
            this.fld_btnCancelMachine.BOSPrivilege = null;
            this.fld_btnCancelMachine.BOSPropertyName = null;
            this.fld_btnCancelMachine.Location = new System.Drawing.Point(572, 321);
            this.fld_btnCancelMachine.Name = "fld_btnCancelMachine";
            this.fld_btnCancelMachine.Screen = null;
            this.fld_btnCancelMachine.Size = new System.Drawing.Size(48, 27);
            this.fld_btnCancelMachine.TabIndex = 409;
            this.fld_btnCancelMachine.Text = "Hủy";
            this.fld_btnCancelMachine.Click += new System.EventHandler(this.Fld_btnCancelMachine_Click);
            // 
            // fld_btnAddMachine
            // 
            this.fld_btnAddMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddMachine.BOSComment = null;
            this.fld_btnAddMachine.BOSDataMember = null;
            this.fld_btnAddMachine.BOSDataSource = null;
            this.fld_btnAddMachine.BOSDescription = null;
            this.fld_btnAddMachine.BOSError = null;
            this.fld_btnAddMachine.BOSFieldGroup = null;
            this.fld_btnAddMachine.BOSFieldRelation = null;
            this.fld_btnAddMachine.BOSPrivilege = null;
            this.fld_btnAddMachine.BOSPropertyName = null;
            this.fld_btnAddMachine.Location = new System.Drawing.Point(572, 288);
            this.fld_btnAddMachine.Name = "fld_btnAddMachine";
            this.fld_btnAddMachine.Screen = null;
            this.fld_btnAddMachine.Size = new System.Drawing.Size(48, 27);
            this.fld_btnAddMachine.TabIndex = 410;
            this.fld_btnAddMachine.Text = "<Gán>";
            this.fld_btnAddMachine.Click += new System.EventHandler(this.Fld_btnAddMachine_Click);
            // 
            // bosLine5
            // 
            this.bosLine5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_bteMachineOperation);
            this.bosLine5.Controls.Add(this.fld_lkeMMWorshopID);
            this.bosLine5.Controls.Add(this.bosLabel16);
            this.bosLine5.Controls.Add(this.bosLabel17);
            this.bosLine5.Controls.Add(this.fld_ckeMachineNotTicket);
            this.bosLine5.Controls.Add(this.fld_trlMachineUnits);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(0, 3);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(569, 678);
            this.bosLine5.TabIndex = 407;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Danh sách máy móc";
            // 
            // fld_bteMachineOperation
            // 
            this.fld_bteMachineOperation.BOSComment = null;
            this.fld_bteMachineOperation.BOSDataMember = "";
            this.fld_bteMachineOperation.BOSDataSource = "";
            this.fld_bteMachineOperation.BOSDescription = null;
            this.fld_bteMachineOperation.BOSError = null;
            this.fld_bteMachineOperation.BOSFieldGroup = null;
            this.fld_bteMachineOperation.BOSFieldRelation = null;
            this.fld_bteMachineOperation.BOSPrivilege = null;
            this.fld_bteMachineOperation.BOSPropertyName = "Text";
            this.fld_bteMachineOperation.Location = new System.Drawing.Point(99, 20);
            this.fld_bteMachineOperation.Name = "fld_bteMachineOperation";
            this.fld_bteMachineOperation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteMachineOperation.Properties.EditFormat.FormatString = "N";
            this.fld_bteMachineOperation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_bteMachineOperation.Screen = null;
            this.fld_bteMachineOperation.Size = new System.Drawing.Size(145, 20);
            this.fld_bteMachineOperation.TabIndex = 132;
            this.fld_bteMachineOperation.Tag = "DC";
            this.fld_bteMachineOperation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bteMachineOperation_ButtonClick);
            // 
            // fld_lkeMMWorshopID
            // 
            this.fld_lkeMMWorshopID.BOSAllowAddNew = false;
            this.fld_lkeMMWorshopID.BOSAllowDummy = false;
            this.fld_lkeMMWorshopID.BOSComment = "";
            this.fld_lkeMMWorshopID.BOSDataMember = "MMWorkShopID";
            this.fld_lkeMMWorshopID.BOSDataSource = "MMWorkShops";
            this.fld_lkeMMWorshopID.BOSDescription = null;
            this.fld_lkeMMWorshopID.BOSError = null;
            this.fld_lkeMMWorshopID.BOSFieldGroup = "";
            this.fld_lkeMMWorshopID.BOSFieldParent = "";
            this.fld_lkeMMWorshopID.BOSFieldRelation = "";
            this.fld_lkeMMWorshopID.BOSPrivilege = "";
            this.fld_lkeMMWorshopID.BOSPropertyName = "EditValue";
            this.fld_lkeMMWorshopID.BOSSelectType = "";
            this.fld_lkeMMWorshopID.BOSSelectTypeValue = "";
            this.fld_lkeMMWorshopID.CurrentDisplayText = "";
            this.fld_lkeMMWorshopID.Location = new System.Drawing.Point(345, 20);
            this.fld_lkeMMWorshopID.Name = "fld_lkeMMWorshopID";
            this.fld_lkeMMWorshopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMWorshopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMWorshopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMWorshopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMWorshopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMWorshopID.Properties.ColumnName = null;
            this.fld_lkeMMWorshopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeMMWorshopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeMMWorshopID.Properties.NullText = "";
            this.fld_lkeMMWorshopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMWorshopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeMMWorshopID.Screen = null;
            this.fld_lkeMMWorshopID.Size = new System.Drawing.Size(145, 20);
            this.fld_lkeMMWorshopID.TabIndex = 131;
            this.fld_lkeMMWorshopID.Tag = "DC";
            this.fld_lkeMMWorshopID.EditValueChanged += new System.EventHandler(this.Fld_lkeMMWorshopID_EditValueChanged);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(24, 25);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(52, 13);
            this.bosLabel16.TabIndex = 129;
            this.bosLabel16.Text = "Công đoạn";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(270, 25);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(31, 13);
            this.bosLabel17.TabIndex = 128;
            this.bosLabel17.Tag = "DC";
            this.bosLabel17.Text = "Xưởng";
            // 
            // fld_ckeMachineNotTicket
            // 
            this.fld_ckeMachineNotTicket.BOSComment = null;
            this.fld_ckeMachineNotTicket.BOSDataMember = null;
            this.fld_ckeMachineNotTicket.BOSDataSource = null;
            this.fld_ckeMachineNotTicket.BOSDescription = null;
            this.fld_ckeMachineNotTicket.BOSError = null;
            this.fld_ckeMachineNotTicket.BOSFieldGroup = null;
            this.fld_ckeMachineNotTicket.BOSFieldRelation = null;
            this.fld_ckeMachineNotTicket.BOSPrivilege = null;
            this.fld_ckeMachineNotTicket.BOSPropertyName = null;
            this.fld_ckeMachineNotTicket.Location = new System.Drawing.Point(24, 45);
            this.fld_ckeMachineNotTicket.Name = "fld_ckeMachineNotTicket";
            this.fld_ckeMachineNotTicket.Properties.Caption = "Chỉ hiển thị máy móc chưa gán việc";
            this.fld_ckeMachineNotTicket.Screen = null;
            this.fld_ckeMachineNotTicket.Size = new System.Drawing.Size(311, 19);
            this.fld_ckeMachineNotTicket.TabIndex = 123;
            this.fld_ckeMachineNotTicket.CheckedChanged += new System.EventHandler(this.Fld_ckeMachineNotTicket_CheckedChanged);
            // 
            // fld_trlMachineUnits
            // 
            this.fld_trlMachineUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMachineUnits.bindingListSource = null;
            this.fld_trlMachineUnits.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_trlMachineUnits.KeyFieldName = "HRDepartmentRoomGroupItemID";
            this.fld_trlMachineUnits.Location = new System.Drawing.Point(3, 69);
            this.fld_trlMachineUnits.MachineGroupItemDataList = null;
            this.fld_trlMachineUnits.Module = null;
            this.fld_trlMachineUnits.Name = "fld_trlMachineUnits";
            this.fld_trlMachineUnits.ParentFieldName = "HRDepartmentRoomGroupItemParentID";
            this.fld_trlMachineUnits.ResultList = null;
            this.fld_trlMachineUnits.Size = new System.Drawing.Size(563, 603);
            this.fld_trlMachineUnits.TabIndex = 101;
            // 
            // bosLine6
            // 
            this.bosLine6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.bosLabel25);
            this.bosLine6.Controls.Add(this.fld_lblMachineTotalBlock);
            this.bosLine6.Controls.Add(this.fld_lblMachineTotalQty);
            this.bosLine6.Controls.Add(this.bosLabel28);
            this.bosLine6.Controls.Add(this.fld_ckeAllMachineTicket);
            this.bosLine6.Controls.Add(this.fld_ckeTicketNothaveMachine);
            this.bosLine6.Controls.Add(this.fld_ckeTicketByOperation);
            this.bosLine6.Controls.Add(this.fld_TicketHaveMachine);
            this.bosLine6.Controls.Add(this.fld_dgcMachineDetailPlanItems);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine6.Location = new System.Drawing.Point(0, 3);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(1106, 678);
            this.bosLine6.TabIndex = 405;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Chi tiết công việc từng theo máy";
            // 
            // bosLabel25
            // 
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = null;
            this.bosLabel25.BOSDataSource = null;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(512, 48);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(45, 13);
            this.bosLabel25.TabIndex = 127;
            this.bosLabel25.Text = "Tổng M3:";
            // 
            // fld_lblMachineTotalBlock
            // 
            this.fld_lblMachineTotalBlock.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblMachineTotalBlock.Appearance.Options.UseFont = true;
            this.fld_lblMachineTotalBlock.BOSComment = null;
            this.fld_lblMachineTotalBlock.BOSDataMember = null;
            this.fld_lblMachineTotalBlock.BOSDataSource = null;
            this.fld_lblMachineTotalBlock.BOSDescription = null;
            this.fld_lblMachineTotalBlock.BOSError = null;
            this.fld_lblMachineTotalBlock.BOSFieldGroup = null;
            this.fld_lblMachineTotalBlock.BOSFieldRelation = null;
            this.fld_lblMachineTotalBlock.BOSPrivilege = null;
            this.fld_lblMachineTotalBlock.BOSPropertyName = null;
            this.fld_lblMachineTotalBlock.Location = new System.Drawing.Point(570, 48);
            this.fld_lblMachineTotalBlock.Name = "fld_lblMachineTotalBlock";
            this.fld_lblMachineTotalBlock.Screen = null;
            this.fld_lblMachineTotalBlock.Size = new System.Drawing.Size(7, 13);
            this.fld_lblMachineTotalBlock.TabIndex = 128;
            this.fld_lblMachineTotalBlock.Text = "0";
            // 
            // fld_lblMachineTotalQty
            // 
            this.fld_lblMachineTotalQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblMachineTotalQty.Appearance.Options.UseFont = true;
            this.fld_lblMachineTotalQty.BOSComment = null;
            this.fld_lblMachineTotalQty.BOSDataMember = null;
            this.fld_lblMachineTotalQty.BOSDataSource = null;
            this.fld_lblMachineTotalQty.BOSDescription = null;
            this.fld_lblMachineTotalQty.BOSError = null;
            this.fld_lblMachineTotalQty.BOSFieldGroup = null;
            this.fld_lblMachineTotalQty.BOSFieldRelation = null;
            this.fld_lblMachineTotalQty.BOSPrivilege = null;
            this.fld_lblMachineTotalQty.BOSPropertyName = null;
            this.fld_lblMachineTotalQty.Location = new System.Drawing.Point(570, 24);
            this.fld_lblMachineTotalQty.Name = "fld_lblMachineTotalQty";
            this.fld_lblMachineTotalQty.Screen = null;
            this.fld_lblMachineTotalQty.Size = new System.Drawing.Size(7, 13);
            this.fld_lblMachineTotalQty.TabIndex = 129;
            this.fld_lblMachineTotalQty.Text = "0";
            // 
            // bosLabel28
            // 
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(512, 23);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(42, 13);
            this.bosLabel28.TabIndex = 130;
            this.bosLabel28.Text = "Tổng SL:";
            // 
            // fld_ckeAllMachineTicket
            // 
            this.fld_ckeAllMachineTicket.BOSComment = null;
            this.fld_ckeAllMachineTicket.BOSDataMember = null;
            this.fld_ckeAllMachineTicket.BOSDataSource = null;
            this.fld_ckeAllMachineTicket.BOSDescription = null;
            this.fld_ckeAllMachineTicket.BOSError = null;
            this.fld_ckeAllMachineTicket.BOSFieldGroup = null;
            this.fld_ckeAllMachineTicket.BOSFieldRelation = null;
            this.fld_ckeAllMachineTicket.BOSPrivilege = null;
            this.fld_ckeAllMachineTicket.BOSPropertyName = null;
            this.fld_ckeAllMachineTicket.Location = new System.Drawing.Point(254, 42);
            this.fld_ckeAllMachineTicket.MenuManager = this.screenToolbar;
            this.fld_ckeAllMachineTicket.Name = "fld_ckeAllMachineTicket";
            this.fld_ckeAllMachineTicket.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_ckeAllMachineTicket.Properties.Appearance.Options.UseFont = true;
            this.fld_ckeAllMachineTicket.Properties.Caption = "Chọn tất cả công việc";
            this.fld_ckeAllMachineTicket.Screen = null;
            this.fld_ckeAllMachineTicket.Size = new System.Drawing.Size(145, 19);
            this.fld_ckeAllMachineTicket.TabIndex = 126;
            this.fld_ckeAllMachineTicket.CheckedChanged += new System.EventHandler(this.Fld_ckeAllMachineTicket_CheckedChanged);
            // 
            // fld_ckeTicketNothaveMachine
            // 
            this.fld_ckeTicketNothaveMachine.BOSComment = null;
            this.fld_ckeTicketNothaveMachine.BOSDataMember = null;
            this.fld_ckeTicketNothaveMachine.BOSDataSource = null;
            this.fld_ckeTicketNothaveMachine.BOSDescription = null;
            this.fld_ckeTicketNothaveMachine.BOSError = null;
            this.fld_ckeTicketNothaveMachine.BOSFieldGroup = null;
            this.fld_ckeTicketNothaveMachine.BOSFieldRelation = null;
            this.fld_ckeTicketNothaveMachine.BOSPrivilege = null;
            this.fld_ckeTicketNothaveMachine.BOSPropertyName = null;
            this.fld_ckeTicketNothaveMachine.Location = new System.Drawing.Point(16, 20);
            this.fld_ckeTicketNothaveMachine.Name = "fld_ckeTicketNothaveMachine";
            this.fld_ckeTicketNothaveMachine.Properties.Caption = "Chỉ hiển thị công việc chưa có máy móc";
            this.fld_ckeTicketNothaveMachine.Screen = null;
            this.fld_ckeTicketNothaveMachine.Size = new System.Drawing.Size(223, 19);
            this.fld_ckeTicketNothaveMachine.TabIndex = 123;
            this.fld_ckeTicketNothaveMachine.CheckedChanged += new System.EventHandler(this.Fld_ckeTicketNothaveMachine_CheckedChanged);
            // 
            // fld_ckeTicketByOperation
            // 
            this.fld_ckeTicketByOperation.BOSComment = null;
            this.fld_ckeTicketByOperation.BOSDataMember = null;
            this.fld_ckeTicketByOperation.BOSDataSource = null;
            this.fld_ckeTicketByOperation.BOSDescription = null;
            this.fld_ckeTicketByOperation.BOSError = null;
            this.fld_ckeTicketByOperation.BOSFieldGroup = null;
            this.fld_ckeTicketByOperation.BOSFieldRelation = null;
            this.fld_ckeTicketByOperation.BOSPrivilege = null;
            this.fld_ckeTicketByOperation.BOSPropertyName = null;
            this.fld_ckeTicketByOperation.EditValue = true;
            this.fld_ckeTicketByOperation.Location = new System.Drawing.Point(254, 20);
            this.fld_ckeTicketByOperation.Name = "fld_ckeTicketByOperation";
            this.fld_ckeTicketByOperation.Properties.Caption = "Chỉ hiển thị công việc theo sở trường của máy";
            this.fld_ckeTicketByOperation.Screen = null;
            this.fld_ckeTicketByOperation.Size = new System.Drawing.Size(242, 19);
            this.fld_ckeTicketByOperation.TabIndex = 124;
            this.fld_ckeTicketByOperation.CheckedChanged += new System.EventHandler(this.Fld_ckeTicketByOperation_CheckedChanged);
            // 
            // fld_TicketHaveMachine
            // 
            this.fld_TicketHaveMachine.BOSComment = null;
            this.fld_TicketHaveMachine.BOSDataMember = null;
            this.fld_TicketHaveMachine.BOSDataSource = null;
            this.fld_TicketHaveMachine.BOSDescription = null;
            this.fld_TicketHaveMachine.BOSError = null;
            this.fld_TicketHaveMachine.BOSFieldGroup = null;
            this.fld_TicketHaveMachine.BOSFieldRelation = null;
            this.fld_TicketHaveMachine.BOSPrivilege = null;
            this.fld_TicketHaveMachine.BOSPropertyName = null;
            this.fld_TicketHaveMachine.EditValue = true;
            this.fld_TicketHaveMachine.Location = new System.Drawing.Point(16, 45);
            this.fld_TicketHaveMachine.Name = "fld_TicketHaveMachine";
            this.fld_TicketHaveMachine.Properties.Caption = "Chỉ hiển thị công việc đã gán cho máy móc";
            this.fld_TicketHaveMachine.Screen = null;
            this.fld_TicketHaveMachine.Size = new System.Drawing.Size(233, 19);
            this.fld_TicketHaveMachine.TabIndex = 125;
            this.fld_TicketHaveMachine.CheckedChanged += new System.EventHandler(this.Fld_TicketHaveMachine_CheckedChanged);
            // 
            // fld_dgcMachineDetailPlanItems
            // 
            this.fld_dgcMachineDetailPlanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMachineDetailPlanItems.BOSComment = null;
            this.fld_dgcMachineDetailPlanItems.BOSDataMember = null;
            this.fld_dgcMachineDetailPlanItems.BOSDataSource = "MMOperationDetailPlanItemChilds";
            this.fld_dgcMachineDetailPlanItems.BOSDescription = null;
            this.fld_dgcMachineDetailPlanItems.BOSError = null;
            this.fld_dgcMachineDetailPlanItems.BOSFieldGroup = null;
            this.fld_dgcMachineDetailPlanItems.BOSFieldRelation = null;
            this.fld_dgcMachineDetailPlanItems.BOSGridType = null;
            this.fld_dgcMachineDetailPlanItems.BOSPrivilege = null;
            this.fld_dgcMachineDetailPlanItems.BOSPropertyName = null;
            this.fld_dgcMachineDetailPlanItems.CommodityType = "";
            this.fld_dgcMachineDetailPlanItems.IsEdit = false;
            this.fld_dgcMachineDetailPlanItems.Location = new System.Drawing.Point(3, 69);
            this.fld_dgcMachineDetailPlanItems.MenuManager = this.screenToolbar;
            this.fld_dgcMachineDetailPlanItems.Name = "fld_dgcMachineDetailPlanItems";
            this.fld_dgcMachineDetailPlanItems.PrintReport = false;
            this.fld_dgcMachineDetailPlanItems.Screen = null;
            this.fld_dgcMachineDetailPlanItems.Size = new System.Drawing.Size(1102, 603);
            this.fld_dgcMachineDetailPlanItems.TabIndex = 2;
            // 
            // fld_xtabEquipment
            // 
            this.fld_xtabEquipment.Controls.Add(this.fld_chkAllEquipment);
            this.fld_xtabEquipment.Controls.Add(this.fld_btnEquipmentRefesh);
            this.fld_xtabEquipment.Controls.Add(this.fld_btnEquipmentZoom);
            this.fld_xtabEquipment.Controls.Add(this.fld_dgcMMDetailPlanEquipments);
            this.fld_xtabEquipment.Name = "fld_xtabEquipment";
            this.fld_xtabEquipment.Size = new System.Drawing.Size(1739, 713);
            this.fld_xtabEquipment.Text = "Dụng cụ sản xuất (khuôn)";
            // 
            // fld_chkAllEquipment
            // 
            this.fld_chkAllEquipment.BOSComment = null;
            this.fld_chkAllEquipment.BOSDataMember = null;
            this.fld_chkAllEquipment.BOSDataSource = null;
            this.fld_chkAllEquipment.BOSDescription = null;
            this.fld_chkAllEquipment.BOSError = null;
            this.fld_chkAllEquipment.BOSFieldGroup = null;
            this.fld_chkAllEquipment.BOSFieldRelation = null;
            this.fld_chkAllEquipment.BOSPrivilege = null;
            this.fld_chkAllEquipment.BOSPropertyName = null;
            this.fld_chkAllEquipment.Location = new System.Drawing.Point(194, 6);
            this.fld_chkAllEquipment.MenuManager = this.screenToolbar;
            this.fld_chkAllEquipment.Name = "fld_chkAllEquipment";
            this.fld_chkAllEquipment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_chkAllEquipment.Properties.Appearance.Options.UseFont = true;
            this.fld_chkAllEquipment.Properties.Caption = "Chọn tất cả chi tiết";
            this.fld_chkAllEquipment.Screen = null;
            this.fld_chkAllEquipment.Size = new System.Drawing.Size(145, 19);
            this.fld_chkAllEquipment.TabIndex = 412;
            this.fld_chkAllEquipment.CheckedChanged += new System.EventHandler(this.Fld_chkAllEquipment_CheckedChanged);
            // 
            // fld_btnEquipmentRefesh
            // 
            this.fld_btnEquipmentRefesh.BOSComment = null;
            this.fld_btnEquipmentRefesh.BOSDataMember = null;
            this.fld_btnEquipmentRefesh.BOSDataSource = null;
            this.fld_btnEquipmentRefesh.BOSDescription = null;
            this.fld_btnEquipmentRefesh.BOSError = null;
            this.fld_btnEquipmentRefesh.BOSFieldGroup = null;
            this.fld_btnEquipmentRefesh.BOSFieldRelation = null;
            this.fld_btnEquipmentRefesh.BOSPrivilege = null;
            this.fld_btnEquipmentRefesh.BOSPropertyName = null;
            this.fld_btnEquipmentRefesh.Location = new System.Drawing.Point(3, 3);
            this.fld_btnEquipmentRefesh.Name = "fld_btnEquipmentRefesh";
            this.fld_btnEquipmentRefesh.Screen = null;
            this.fld_btnEquipmentRefesh.Size = new System.Drawing.Size(159, 25);
            this.fld_btnEquipmentRefesh.TabIndex = 411;
            this.fld_btnEquipmentRefesh.Text = "Tải danh sách mặc định";
            this.fld_btnEquipmentRefesh.Click += new System.EventHandler(this.Fld_btnEquipmentRefesh_Click);
            // 
            // fld_btnEquipmentZoom
            // 
            this.fld_btnEquipmentZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEquipmentZoom.BOSComment = null;
            this.fld_btnEquipmentZoom.BOSDataMember = null;
            this.fld_btnEquipmentZoom.BOSDataSource = null;
            this.fld_btnEquipmentZoom.BOSDescription = null;
            this.fld_btnEquipmentZoom.BOSError = null;
            this.fld_btnEquipmentZoom.BOSFieldGroup = null;
            this.fld_btnEquipmentZoom.BOSFieldRelation = null;
            this.fld_btnEquipmentZoom.BOSPrivilege = null;
            this.fld_btnEquipmentZoom.BOSPropertyName = null;
            this.fld_btnEquipmentZoom.Location = new System.Drawing.Point(1713, 3);
            this.fld_btnEquipmentZoom.Name = "fld_btnEquipmentZoom";
            this.fld_btnEquipmentZoom.Screen = null;
            this.fld_btnEquipmentZoom.Size = new System.Drawing.Size(22, 22);
            this.fld_btnEquipmentZoom.TabIndex = 410;
            this.fld_btnEquipmentZoom.Text = "❐";
            this.fld_btnEquipmentZoom.ToolTip = "Phóng to";
            this.fld_btnEquipmentZoom.Click += new System.EventHandler(this.Fld_btnEquipmentZoom_Click);
            // 
            // fld_dgcMMDetailPlanEquipments
            // 
            this.fld_dgcMMDetailPlanEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMDetailPlanEquipments.BOSComment = null;
            this.fld_dgcMMDetailPlanEquipments.BOSDataMember = null;
            this.fld_dgcMMDetailPlanEquipments.BOSDataSource = "MMDetailPlanEquipments";
            this.fld_dgcMMDetailPlanEquipments.BOSDescription = null;
            this.fld_dgcMMDetailPlanEquipments.BOSError = null;
            this.fld_dgcMMDetailPlanEquipments.BOSFieldGroup = null;
            this.fld_dgcMMDetailPlanEquipments.BOSFieldRelation = null;
            this.fld_dgcMMDetailPlanEquipments.BOSGridType = null;
            this.fld_dgcMMDetailPlanEquipments.BOSPrivilege = null;
            this.fld_dgcMMDetailPlanEquipments.BOSPropertyName = null;
            this.fld_dgcMMDetailPlanEquipments.CommodityType = "";
            this.fld_dgcMMDetailPlanEquipments.Location = new System.Drawing.Point(3, 34);
            this.fld_dgcMMDetailPlanEquipments.MenuManager = this.screenToolbar;
            this.fld_dgcMMDetailPlanEquipments.Name = "fld_dgcMMDetailPlanEquipments";
            this.fld_dgcMMDetailPlanEquipments.PrintReport = false;
            this.fld_dgcMMDetailPlanEquipments.Screen = null;
            this.fld_dgcMMDetailPlanEquipments.Size = new System.Drawing.Size(1732, 676);
            this.fld_dgcMMDetailPlanEquipments.TabIndex = 3;
            // 
            // fld_tabJobTicket
            // 
            this.fld_tabJobTicket.Controls.Add(this.fld_btnTicketZoom);
            this.fld_tabJobTicket.Controls.Add(this.fld_splTicket);
            this.fld_tabJobTicket.Name = "fld_tabJobTicket";
            this.fld_tabJobTicket.Size = new System.Drawing.Size(1745, 720);
            this.fld_tabJobTicket.Text = "Danh sách thẻ giao việc";
            // 
            // fld_btnTicketZoom
            // 
            this.fld_btnTicketZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnTicketZoom.BOSComment = null;
            this.fld_btnTicketZoom.BOSDataMember = null;
            this.fld_btnTicketZoom.BOSDataSource = null;
            this.fld_btnTicketZoom.BOSDescription = null;
            this.fld_btnTicketZoom.BOSError = null;
            this.fld_btnTicketZoom.BOSFieldGroup = null;
            this.fld_btnTicketZoom.BOSFieldRelation = null;
            this.fld_btnTicketZoom.BOSPrivilege = null;
            this.fld_btnTicketZoom.BOSPropertyName = null;
            this.fld_btnTicketZoom.Location = new System.Drawing.Point(1723, 0);
            this.fld_btnTicketZoom.Name = "fld_btnTicketZoom";
            this.fld_btnTicketZoom.Screen = null;
            this.fld_btnTicketZoom.Size = new System.Drawing.Size(22, 22);
            this.fld_btnTicketZoom.TabIndex = 409;
            this.fld_btnTicketZoom.Text = "❐";
            this.fld_btnTicketZoom.ToolTip = "Phóng to";
            this.fld_btnTicketZoom.Click += new System.EventHandler(this.Fld_btnTicketZoom_Click);
            // 
            // fld_splTicket
            // 
            this.fld_splTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_splTicket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_splTicket.Location = new System.Drawing.Point(0, 28);
            this.fld_splTicket.Name = "fld_splTicket";
            this.fld_splTicket.Panel1.Controls.Add(this.bosLine8);
            this.fld_splTicket.Panel1.Text = "Panel1";
            this.fld_splTicket.Panel2.Controls.Add(this.bosLine9);
            this.fld_splTicket.Panel2.Text = "Panel2";
            this.fld_splTicket.Size = new System.Drawing.Size(1745, 692);
            this.fld_splTicket.SplitterPosition = 672;
            this.fld_splTicket.TabIndex = 410;
            this.fld_splTicket.Text = "splitContainerControl2";
            // 
            // bosLine8
            // 
            this.bosLine8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine8.BOSComment = null;
            this.bosLine8.BOSDataMember = null;
            this.bosLine8.BOSDataSource = null;
            this.bosLine8.BOSDescription = null;
            this.bosLine8.BOSError = null;
            this.bosLine8.BOSFieldGroup = null;
            this.bosLine8.BOSFieldRelation = null;
            this.bosLine8.BOSPrivilege = null;
            this.bosLine8.BOSPropertyName = null;
            this.bosLine8.Controls.Add(this.fld_btnTicketHumanEdit);
            this.bosLine8.Controls.Add(this.fld_bteTicketOperation);
            this.bosLine8.Controls.Add(this.bosLabel23);
            this.bosLine8.Controls.Add(this.fld_bteTicketHuman);
            this.bosLine8.Controls.Add(this.bosLabel22);
            this.bosLine8.Controls.Add(this.fld_chkAllTicket);
            this.bosLine8.Controls.Add(this.fld_btnCapacityReceipt);
            this.bosLine8.Controls.Add(this.fld_chkTicketRemain);
            this.bosLine8.Controls.Add(this.button1);
            this.bosLine8.Controls.Add(this.bosLabel18);
            this.bosLine8.Controls.Add(this.fld_lblAllticket);
            this.bosLine8.Controls.Add(this.fld_btnStatusAlittleReceipt);
            this.bosLine8.Controls.Add(this.fld_lblStatusAlittleReceipt);
            this.bosLine8.Controls.Add(this.fld_dgcMMTicketPlanItems);
            this.bosLine8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine8.Location = new System.Drawing.Point(0, 3);
            this.bosLine8.Name = "bosLine8";
            this.bosLine8.Screen = null;
            this.bosLine8.Size = new System.Drawing.Size(671, 684);
            this.bosLine8.TabIndex = 407;
            this.bosLine8.TabStop = false;
            this.bosLine8.Text = "Danh sách công việc";
            // 
            // fld_btnTicketHumanEdit
            // 
            this.fld_btnTicketHumanEdit.BOSComment = null;
            this.fld_btnTicketHumanEdit.BOSDataMember = null;
            this.fld_btnTicketHumanEdit.BOSDataSource = null;
            this.fld_btnTicketHumanEdit.BOSDescription = null;
            this.fld_btnTicketHumanEdit.BOSError = null;
            this.fld_btnTicketHumanEdit.BOSFieldGroup = null;
            this.fld_btnTicketHumanEdit.BOSFieldRelation = null;
            this.fld_btnTicketHumanEdit.BOSPrivilege = null;
            this.fld_btnTicketHumanEdit.BOSPropertyName = null;
            this.fld_btnTicketHumanEdit.Location = new System.Drawing.Point(358, 45);
            this.fld_btnTicketHumanEdit.Name = "fld_btnTicketHumanEdit";
            this.fld_btnTicketHumanEdit.Screen = null;
            this.fld_btnTicketHumanEdit.Size = new System.Drawing.Size(171, 22);
            this.fld_btnTicketHumanEdit.TabIndex = 166;
            this.fld_btnTicketHumanEdit.Text = "Thêm hoặc sửa nhân công";
            this.fld_btnTicketHumanEdit.Click += new System.EventHandler(this.fld_btnTicketHumanEdit_Click);
            // 
            // fld_bteTicketOperation
            // 
            this.fld_bteTicketOperation.BOSComment = null;
            this.fld_bteTicketOperation.BOSDataMember = "";
            this.fld_bteTicketOperation.BOSDataSource = "";
            this.fld_bteTicketOperation.BOSDescription = null;
            this.fld_bteTicketOperation.BOSError = null;
            this.fld_bteTicketOperation.BOSFieldGroup = null;
            this.fld_bteTicketOperation.BOSFieldRelation = null;
            this.fld_bteTicketOperation.BOSPrivilege = null;
            this.fld_bteTicketOperation.BOSPropertyName = "Text";
            this.fld_bteTicketOperation.Location = new System.Drawing.Point(90, 47);
            this.fld_bteTicketOperation.Name = "fld_bteTicketOperation";
            this.fld_bteTicketOperation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteTicketOperation.Properties.EditFormat.FormatString = "N";
            this.fld_bteTicketOperation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_bteTicketOperation.Screen = null;
            this.fld_bteTicketOperation.Size = new System.Drawing.Size(133, 20);
            this.fld_bteTicketOperation.TabIndex = 136;
            this.fld_bteTicketOperation.Tag = "DC";
            this.fld_bteTicketOperation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bteTicketOperation_ButtonClick);
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(16, 50);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(52, 13);
            this.bosLabel23.TabIndex = 135;
            this.bosLabel23.Text = "Công đoạn";
            // 
            // fld_bteTicketHuman
            // 
            this.fld_bteTicketHuman.BOSComment = null;
            this.fld_bteTicketHuman.BOSDataMember = "";
            this.fld_bteTicketHuman.BOSDataSource = "";
            this.fld_bteTicketHuman.BOSDescription = null;
            this.fld_bteTicketHuman.BOSError = null;
            this.fld_bteTicketHuman.BOSFieldGroup = null;
            this.fld_bteTicketHuman.BOSFieldRelation = null;
            this.fld_bteTicketHuman.BOSPrivilege = null;
            this.fld_bteTicketHuman.BOSPropertyName = "Text";
            this.fld_bteTicketHuman.Location = new System.Drawing.Point(90, 21);
            this.fld_bteTicketHuman.Name = "fld_bteTicketHuman";
            this.fld_bteTicketHuman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bteTicketHuman.Properties.EditFormat.FormatString = "N";
            this.fld_bteTicketHuman.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_bteTicketHuman.Screen = null;
            this.fld_bteTicketHuman.Size = new System.Drawing.Size(133, 20);
            this.fld_bteTicketHuman.TabIndex = 134;
            this.fld_bteTicketHuman.Tag = "DC";
            this.fld_bteTicketHuman.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bteHRDepartmentRoomGroupItemID_ButtonClick);
            // 
            // bosLabel22
            // 
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(16, 24);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(51, 13);
            this.bosLabel22.TabIndex = 132;
            this.bosLabel22.Text = "Nhân công";
            // 
            // fld_chkAllTicket
            // 
            this.fld_chkAllTicket.BOSComment = null;
            this.fld_chkAllTicket.BOSDataMember = null;
            this.fld_chkAllTicket.BOSDataSource = null;
            this.fld_chkAllTicket.BOSDescription = null;
            this.fld_chkAllTicket.BOSError = null;
            this.fld_chkAllTicket.BOSFieldGroup = null;
            this.fld_chkAllTicket.BOSFieldRelation = null;
            this.fld_chkAllTicket.BOSPrivilege = null;
            this.fld_chkAllTicket.BOSPropertyName = null;
            this.fld_chkAllTicket.Location = new System.Drawing.Point(545, 21);
            this.fld_chkAllTicket.MenuManager = this.screenToolbar;
            this.fld_chkAllTicket.Name = "fld_chkAllTicket";
            this.fld_chkAllTicket.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_chkAllTicket.Properties.Appearance.Options.UseFont = true;
            this.fld_chkAllTicket.Properties.Caption = "Chọn tất cả";
            this.fld_chkAllTicket.Screen = null;
            this.fld_chkAllTicket.Size = new System.Drawing.Size(88, 19);
            this.fld_chkAllTicket.TabIndex = 131;
            this.fld_chkAllTicket.CheckedChanged += new System.EventHandler(this.Fld_chkAllTicket_CheckedChanged);
            // 
            // fld_btnCapacityReceipt
            // 
            this.fld_btnCapacityReceipt.BOSComment = null;
            this.fld_btnCapacityReceipt.BOSDataMember = null;
            this.fld_btnCapacityReceipt.BOSDataSource = null;
            this.fld_btnCapacityReceipt.BOSDescription = null;
            this.fld_btnCapacityReceipt.BOSError = null;
            this.fld_btnCapacityReceipt.BOSFieldGroup = null;
            this.fld_btnCapacityReceipt.BOSFieldRelation = null;
            this.fld_btnCapacityReceipt.BOSPrivilege = null;
            this.fld_btnCapacityReceipt.BOSPropertyName = null;
            this.fld_btnCapacityReceipt.Location = new System.Drawing.Point(545, 45);
            this.fld_btnCapacityReceipt.Name = "fld_btnCapacityReceipt";
            this.fld_btnCapacityReceipt.Screen = null;
            this.fld_btnCapacityReceipt.Size = new System.Drawing.Size(96, 22);
            this.fld_btnCapacityReceipt.TabIndex = 130;
            this.fld_btnCapacityReceipt.Text = "Nhập sản lượng";
            this.fld_btnCapacityReceipt.Click += new System.EventHandler(this.Fld_btnCapacityReceipt_Click);
            // 
            // fld_chkTicketRemain
            // 
            this.fld_chkTicketRemain.BOSComment = null;
            this.fld_chkTicketRemain.BOSDataMember = null;
            this.fld_chkTicketRemain.BOSDataSource = null;
            this.fld_chkTicketRemain.BOSDescription = null;
            this.fld_chkTicketRemain.BOSError = null;
            this.fld_chkTicketRemain.BOSFieldGroup = null;
            this.fld_chkTicketRemain.BOSFieldRelation = null;
            this.fld_chkTicketRemain.BOSPrivilege = null;
            this.fld_chkTicketRemain.BOSPropertyName = null;
            this.fld_chkTicketRemain.EditValue = true;
            this.fld_chkTicketRemain.Location = new System.Drawing.Point(250, 22);
            this.fld_chkTicketRemain.MenuManager = this.screenToolbar;
            this.fld_chkTicketRemain.Name = "fld_chkTicketRemain";
            this.fld_chkTicketRemain.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_chkTicketRemain.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkTicketRemain.Properties.Caption = "Chưa nhập đủ";
            this.fld_chkTicketRemain.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkTicketRemain.Screen = null;
            this.fld_chkTicketRemain.Size = new System.Drawing.Size(99, 19);
            this.fld_chkTicketRemain.TabIndex = 129;
            this.fld_chkTicketRemain.CheckedChanged += new System.EventHandler(this.Fld_chkTicketRemain_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button1.Location = new System.Drawing.Point(6, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 15);
            this.button1.TabIndex = 123;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bosLabel18
            // 
            this.bosLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(34, 658);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(55, 12);
            this.bosLabel18.TabIndex = 125;
            this.bosLabel18.Text = "Trễ tiến độ";
            // 
            // fld_lblAllticket
            // 
            this.fld_lblAllticket.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.fld_lblAllticket.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.fld_lblAllticket.Appearance.Options.UseFont = true;
            this.fld_lblAllticket.Appearance.Options.UseForeColor = true;
            this.fld_lblAllticket.BOSComment = null;
            this.fld_lblAllticket.BOSDataMember = null;
            this.fld_lblAllticket.BOSDataSource = null;
            this.fld_lblAllticket.BOSDescription = null;
            this.fld_lblAllticket.BOSError = null;
            this.fld_lblAllticket.BOSFieldGroup = null;
            this.fld_lblAllticket.BOSFieldRelation = null;
            this.fld_lblAllticket.BOSPrivilege = null;
            this.fld_lblAllticket.BOSPropertyName = null;
            this.fld_lblAllticket.Location = new System.Drawing.Point(250, 51);
            this.fld_lblAllticket.Name = "fld_lblAllticket";
            this.fld_lblAllticket.Screen = null;
            this.fld_lblAllticket.Size = new System.Drawing.Size(35, 13);
            this.fld_lblAllticket.TabIndex = 126;
            this.fld_lblAllticket.Text = "Hủy lọc";
            this.fld_lblAllticket.Click += new System.EventHandler(this.Fld_lblAllticket_Click);
            // 
            // fld_btnStatusAlittleReceipt
            // 
            this.fld_btnStatusAlittleReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnStatusAlittleReceipt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.fld_btnStatusAlittleReceipt.Enabled = false;
            this.fld_btnStatusAlittleReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fld_btnStatusAlittleReceipt.Font = new System.Drawing.Font("Tahoma", 7F);
            this.fld_btnStatusAlittleReceipt.Location = new System.Drawing.Point(99, 656);
            this.fld_btnStatusAlittleReceipt.Name = "fld_btnStatusAlittleReceipt";
            this.fld_btnStatusAlittleReceipt.Size = new System.Drawing.Size(20, 15);
            this.fld_btnStatusAlittleReceipt.TabIndex = 122;
            this.fld_btnStatusAlittleReceipt.UseVisualStyleBackColor = false;
            // 
            // fld_lblStatusAlittleReceipt
            // 
            this.fld_lblStatusAlittleReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_lblStatusAlittleReceipt.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.fld_lblStatusAlittleReceipt.Appearance.Options.UseFont = true;
            this.fld_lblStatusAlittleReceipt.BOSComment = null;
            this.fld_lblStatusAlittleReceipt.BOSDataMember = null;
            this.fld_lblStatusAlittleReceipt.BOSDataSource = null;
            this.fld_lblStatusAlittleReceipt.BOSDescription = null;
            this.fld_lblStatusAlittleReceipt.BOSError = null;
            this.fld_lblStatusAlittleReceipt.BOSFieldGroup = null;
            this.fld_lblStatusAlittleReceipt.BOSFieldRelation = null;
            this.fld_lblStatusAlittleReceipt.BOSPrivilege = null;
            this.fld_lblStatusAlittleReceipt.BOSPropertyName = null;
            this.fld_lblStatusAlittleReceipt.Location = new System.Drawing.Point(130, 658);
            this.fld_lblStatusAlittleReceipt.Name = "fld_lblStatusAlittleReceipt";
            this.fld_lblStatusAlittleReceipt.Screen = null;
            this.fld_lblStatusAlittleReceipt.Size = new System.Drawing.Size(41, 12);
            this.fld_lblStatusAlittleReceipt.TabIndex = 124;
            this.fld_lblStatusAlittleReceipt.Text = "Đã nhập";
            // 
            // fld_dgcMMTicketPlanItems
            // 
            this.fld_dgcMMTicketPlanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMTicketPlanItems.BOSComment = null;
            this.fld_dgcMMTicketPlanItems.BOSDataMember = null;
            this.fld_dgcMMTicketPlanItems.BOSDataSource = "MMOperationDetailPlanItemChilds";
            this.fld_dgcMMTicketPlanItems.BOSDescription = null;
            this.fld_dgcMMTicketPlanItems.BOSError = null;
            this.fld_dgcMMTicketPlanItems.BOSFieldGroup = null;
            this.fld_dgcMMTicketPlanItems.BOSFieldRelation = null;
            this.fld_dgcMMTicketPlanItems.BOSGridType = null;
            this.fld_dgcMMTicketPlanItems.BOSPrivilege = null;
            this.fld_dgcMMTicketPlanItems.BOSPropertyName = null;
            this.fld_dgcMMTicketPlanItems.CommodityType = "";
            this.fld_dgcMMTicketPlanItems.IsEdit = false;
            this.fld_dgcMMTicketPlanItems.Location = new System.Drawing.Point(3, 81);
            this.fld_dgcMMTicketPlanItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMTicketPlanItems.Name = "fld_dgcMMTicketPlanItems";
            this.fld_dgcMMTicketPlanItems.PrintReport = false;
            this.fld_dgcMMTicketPlanItems.Screen = null;
            this.fld_dgcMMTicketPlanItems.Size = new System.Drawing.Size(662, 564);
            this.fld_dgcMMTicketPlanItems.TabIndex = 2;
            // 
            // bosLine9
            // 
            this.bosLine9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine9.BOSComment = null;
            this.bosLine9.BOSDataMember = null;
            this.bosLine9.BOSDataSource = null;
            this.bosLine9.BOSDescription = null;
            this.bosLine9.BOSError = null;
            this.bosLine9.BOSFieldGroup = null;
            this.bosLine9.BOSFieldRelation = null;
            this.bosLine9.BOSPrivilege = null;
            this.bosLine9.BOSPropertyName = null;
            this.bosLine9.Controls.Add(this.fld_btnUpdateCapacity);
            this.bosLine9.Controls.Add(this.fld_btnSaveCapacity);
            this.bosLine9.Controls.Add(this.fld_dgcCapacityItemsGridControl);
            this.bosLine9.Controls.Add(this.fld_lkeHREmployeeQCID);
            this.bosLine9.Controls.Add(this.fld_chkAllCapacity);
            this.bosLine9.Controls.Add(this.bosLabel31);
            this.bosLine9.Controls.Add(this.fld_lblFrom);
            this.bosLine9.Controls.Add(this.fld_dteCapacityToDate);
            this.bosLine9.Controls.Add(this.fld_dteCapacityFromDate);
            this.bosLine9.Controls.Add(this.bosLabel19);
            this.bosLine9.Controls.Add(this.fld_lkeHREmployeeTakeID);
            this.bosLine9.Controls.Add(this.fld_lkeHREmployeeGiveID);
            this.bosLine9.Controls.Add(this.bosLabel20);
            this.bosLine9.Controls.Add(this.bosLabel21);
            this.bosLine9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine9.Location = new System.Drawing.Point(0, 3);
            this.bosLine9.Name = "bosLine9";
            this.bosLine9.Screen = null;
            this.bosLine9.Size = new System.Drawing.Size(1063, 684);
            this.bosLine9.TabIndex = 405;
            this.bosLine9.TabStop = false;
            this.bosLine9.Text = "Chi tiết sản lượng theo công việc";
            // 
            // fld_btnUpdateCapacity
            // 
            this.fld_btnUpdateCapacity.BOSComment = null;
            this.fld_btnUpdateCapacity.BOSDataMember = null;
            this.fld_btnUpdateCapacity.BOSDataSource = null;
            this.fld_btnUpdateCapacity.BOSDescription = null;
            this.fld_btnUpdateCapacity.BOSError = null;
            this.fld_btnUpdateCapacity.BOSFieldGroup = null;
            this.fld_btnUpdateCapacity.BOSFieldRelation = null;
            this.fld_btnUpdateCapacity.BOSPrivilege = null;
            this.fld_btnUpdateCapacity.BOSPropertyName = null;
            this.fld_btnUpdateCapacity.Location = new System.Drawing.Point(651, 45);
            this.fld_btnUpdateCapacity.Name = "fld_btnUpdateCapacity";
            this.fld_btnUpdateCapacity.Screen = null;
            this.fld_btnUpdateCapacity.Size = new System.Drawing.Size(96, 22);
            this.fld_btnUpdateCapacity.TabIndex = 118;
            this.fld_btnUpdateCapacity.Text = "Cập nhật";
            this.fld_btnUpdateCapacity.Click += new System.EventHandler(this.Fld_btnUpdateCapacity_Click);
            // 
            // fld_btnSaveCapacity
            // 
            this.fld_btnSaveCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveCapacity.BOSComment = null;
            this.fld_btnSaveCapacity.BOSDataMember = null;
            this.fld_btnSaveCapacity.BOSDataSource = null;
            this.fld_btnSaveCapacity.BOSDescription = null;
            this.fld_btnSaveCapacity.BOSError = null;
            this.fld_btnSaveCapacity.BOSFieldGroup = null;
            this.fld_btnSaveCapacity.BOSFieldRelation = null;
            this.fld_btnSaveCapacity.BOSPrivilege = null;
            this.fld_btnSaveCapacity.BOSPropertyName = null;
            this.fld_btnSaveCapacity.Location = new System.Drawing.Point(969, 651);
            this.fld_btnSaveCapacity.Name = "fld_btnSaveCapacity";
            this.fld_btnSaveCapacity.Screen = null;
            this.fld_btnSaveCapacity.Size = new System.Drawing.Size(92, 27);
            this.fld_btnSaveCapacity.TabIndex = 165;
            this.fld_btnSaveCapacity.Text = "Lưu";
            this.fld_btnSaveCapacity.Click += new System.EventHandler(this.Fld_btnSaveCapacity_Click);
            // 
            // fld_dgcCapacityItemsGridControl
            // 
            this.fld_dgcCapacityItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCapacityItemsGridControl.BOSComment = null;
            this.fld_dgcCapacityItemsGridControl.BOSDataMember = null;
            this.fld_dgcCapacityItemsGridControl.BOSDataSource = "MMOperationDetailPlanCapacityItems";
            this.fld_dgcCapacityItemsGridControl.BOSDescription = null;
            this.fld_dgcCapacityItemsGridControl.BOSError = null;
            this.fld_dgcCapacityItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcCapacityItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcCapacityItemsGridControl.BOSGridType = null;
            this.fld_dgcCapacityItemsGridControl.BOSPrivilege = null;
            this.fld_dgcCapacityItemsGridControl.BOSPropertyName = null;
            this.fld_dgcCapacityItemsGridControl.CommodityType = "";
            this.fld_dgcCapacityItemsGridControl.Location = new System.Drawing.Point(6, 81);
            this.fld_dgcCapacityItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcCapacityItemsGridControl.Name = "fld_dgcCapacityItemsGridControl";
            this.fld_dgcCapacityItemsGridControl.PrintReport = false;
            this.fld_dgcCapacityItemsGridControl.Screen = null;
            this.fld_dgcCapacityItemsGridControl.Size = new System.Drawing.Size(1055, 564);
            this.fld_dgcCapacityItemsGridControl.TabIndex = 164;
            this.fld_dgcCapacityItemsGridControl.Tag = "DC";
            // 
            // fld_lkeHREmployeeQCID
            // 
            this.fld_lkeHREmployeeQCID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeQCID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeQCID.BOSComment = "";
            this.fld_lkeHREmployeeQCID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeQCID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeQCID.BOSDescription = null;
            this.fld_lkeHREmployeeQCID.BOSError = null;
            this.fld_lkeHREmployeeQCID.BOSFieldGroup = "";
            this.fld_lkeHREmployeeQCID.BOSFieldParent = "";
            this.fld_lkeHREmployeeQCID.BOSFieldRelation = "";
            this.fld_lkeHREmployeeQCID.BOSPrivilege = "";
            this.fld_lkeHREmployeeQCID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeQCID.BOSSelectType = "";
            this.fld_lkeHREmployeeQCID.BOSSelectTypeValue = "";
            this.fld_lkeHREmployeeQCID.CurrentDisplayText = "";
            this.fld_lkeHREmployeeQCID.Location = new System.Drawing.Point(489, 20);
            this.fld_lkeHREmployeeQCID.Name = "fld_lkeHREmployeeQCID";
            this.fld_lkeHREmployeeQCID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeQCID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeQCID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeQCID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeQCID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeQCID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeQCID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeQCID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeQCID.Properties.NullText = "";
            this.fld_lkeHREmployeeQCID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeQCID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeQCID.Screen = null;
            this.fld_lkeHREmployeeQCID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeHREmployeeQCID.TabIndex = 157;
            this.fld_lkeHREmployeeQCID.Tag = "DC";
            // 
            // fld_chkAllCapacity
            // 
            this.fld_chkAllCapacity.BOSComment = null;
            this.fld_chkAllCapacity.BOSDataMember = null;
            this.fld_chkAllCapacity.BOSDataSource = null;
            this.fld_chkAllCapacity.BOSDescription = null;
            this.fld_chkAllCapacity.BOSError = null;
            this.fld_chkAllCapacity.BOSFieldGroup = null;
            this.fld_chkAllCapacity.BOSFieldRelation = null;
            this.fld_chkAllCapacity.BOSPrivilege = null;
            this.fld_chkAllCapacity.BOSPropertyName = null;
            this.fld_chkAllCapacity.Location = new System.Drawing.Point(489, 47);
            this.fld_chkAllCapacity.Name = "fld_chkAllCapacity";
            this.fld_chkAllCapacity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_chkAllCapacity.Properties.Appearance.Options.UseFont = true;
            this.fld_chkAllCapacity.Properties.Caption = "Chọn tất cả";
            this.fld_chkAllCapacity.Screen = null;
            this.fld_chkAllCapacity.Size = new System.Drawing.Size(88, 19);
            this.fld_chkAllCapacity.TabIndex = 131;
            this.fld_chkAllCapacity.CheckedChanged += new System.EventHandler(this.Fld_chkAllCapacity_CheckedChanged);
            // 
            // bosLabel31
            // 
            this.bosLabel31.BOSComment = null;
            this.bosLabel31.BOSDataMember = null;
            this.bosLabel31.BOSDataSource = null;
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = null;
            this.bosLabel31.BOSFieldRelation = null;
            this.bosLabel31.BOSPrivilege = null;
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(11, 49);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(47, 13);
            this.bosLabel31.TabIndex = 160;
            this.bosLabel31.Text = "Đến ngày";
            // 
            // fld_lblFrom
            // 
            this.fld_lblFrom.BOSComment = null;
            this.fld_lblFrom.BOSDataMember = null;
            this.fld_lblFrom.BOSDataSource = null;
            this.fld_lblFrom.BOSDescription = null;
            this.fld_lblFrom.BOSError = null;
            this.fld_lblFrom.BOSFieldGroup = null;
            this.fld_lblFrom.BOSFieldRelation = null;
            this.fld_lblFrom.BOSPrivilege = null;
            this.fld_lblFrom.BOSPropertyName = null;
            this.fld_lblFrom.Location = new System.Drawing.Point(11, 23);
            this.fld_lblFrom.Name = "fld_lblFrom";
            this.fld_lblFrom.Screen = null;
            this.fld_lblFrom.Size = new System.Drawing.Size(40, 13);
            this.fld_lblFrom.TabIndex = 160;
            this.fld_lblFrom.Text = "Từ ngày";
            // 
            // fld_dteCapacityToDate
            // 
            this.fld_dteCapacityToDate.BOSComment = null;
            this.fld_dteCapacityToDate.BOSDataMember = "";
            this.fld_dteCapacityToDate.BOSDataSource = "";
            this.fld_dteCapacityToDate.BOSDescription = null;
            this.fld_dteCapacityToDate.BOSError = null;
            this.fld_dteCapacityToDate.BOSFieldGroup = null;
            this.fld_dteCapacityToDate.BOSFieldRelation = null;
            this.fld_dteCapacityToDate.BOSPrivilege = null;
            this.fld_dteCapacityToDate.BOSPropertyName = null;
            this.fld_dteCapacityToDate.EditValue = null;
            this.fld_dteCapacityToDate.Location = new System.Drawing.Point(76, 46);
            this.fld_dteCapacityToDate.Name = "fld_dteCapacityToDate";
            this.fld_dteCapacityToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCapacityToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCapacityToDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteCapacityToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteCapacityToDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteCapacityToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteCapacityToDate.Properties.Mask.EditMask = "g";
            this.fld_dteCapacityToDate.Screen = null;
            this.fld_dteCapacityToDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteCapacityToDate.TabIndex = 156;
            this.fld_dteCapacityToDate.Tag = "DC";
            // 
            // fld_dteCapacityFromDate
            // 
            this.fld_dteCapacityFromDate.BOSComment = null;
            this.fld_dteCapacityFromDate.BOSDataMember = "";
            this.fld_dteCapacityFromDate.BOSDataSource = "";
            this.fld_dteCapacityFromDate.BOSDescription = null;
            this.fld_dteCapacityFromDate.BOSError = null;
            this.fld_dteCapacityFromDate.BOSFieldGroup = null;
            this.fld_dteCapacityFromDate.BOSFieldRelation = null;
            this.fld_dteCapacityFromDate.BOSPrivilege = null;
            this.fld_dteCapacityFromDate.BOSPropertyName = null;
            this.fld_dteCapacityFromDate.EditValue = null;
            this.fld_dteCapacityFromDate.Location = new System.Drawing.Point(76, 20);
            this.fld_dteCapacityFromDate.Name = "fld_dteCapacityFromDate";
            this.fld_dteCapacityFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCapacityFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCapacityFromDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteCapacityFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteCapacityFromDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteCapacityFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteCapacityFromDate.Properties.Mask.EditMask = "g";
            this.fld_dteCapacityFromDate.Screen = null;
            this.fld_dteCapacityFromDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteCapacityFromDate.TabIndex = 156;
            this.fld_dteCapacityFromDate.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(236, 24);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(51, 13);
            this.bosLabel19.TabIndex = 161;
            this.bosLabel19.Text = "Người giao";
            // 
            // fld_lkeHREmployeeTakeID
            // 
            this.fld_lkeHREmployeeTakeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeTakeID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeTakeID.BOSComment = "";
            this.fld_lkeHREmployeeTakeID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeTakeID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeTakeID.BOSDescription = null;
            this.fld_lkeHREmployeeTakeID.BOSError = null;
            this.fld_lkeHREmployeeTakeID.BOSFieldGroup = "";
            this.fld_lkeHREmployeeTakeID.BOSFieldParent = "";
            this.fld_lkeHREmployeeTakeID.BOSFieldRelation = "";
            this.fld_lkeHREmployeeTakeID.BOSPrivilege = "";
            this.fld_lkeHREmployeeTakeID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeTakeID.BOSSelectType = "";
            this.fld_lkeHREmployeeTakeID.BOSSelectTypeValue = "";
            this.fld_lkeHREmployeeTakeID.CurrentDisplayText = "";
            this.fld_lkeHREmployeeTakeID.Location = new System.Drawing.Point(301, 46);
            this.fld_lkeHREmployeeTakeID.Name = "fld_lkeHREmployeeTakeID";
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeTakeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeTakeID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeTakeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeHREmployeeTakeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeTakeID.Properties.NullText = "";
            this.fld_lkeHREmployeeTakeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeTakeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeTakeID.Screen = null;
            this.fld_lkeHREmployeeTakeID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeHREmployeeTakeID.TabIndex = 159;
            this.fld_lkeHREmployeeTakeID.Tag = "DC";
            // 
            // fld_lkeHREmployeeGiveID
            // 
            this.fld_lkeHREmployeeGiveID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeGiveID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeGiveID.BOSComment = "";
            this.fld_lkeHREmployeeGiveID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeGiveID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeGiveID.BOSDescription = null;
            this.fld_lkeHREmployeeGiveID.BOSError = null;
            this.fld_lkeHREmployeeGiveID.BOSFieldGroup = "";
            this.fld_lkeHREmployeeGiveID.BOSFieldParent = "";
            this.fld_lkeHREmployeeGiveID.BOSFieldRelation = "";
            this.fld_lkeHREmployeeGiveID.BOSPrivilege = "";
            this.fld_lkeHREmployeeGiveID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeGiveID.BOSSelectType = "";
            this.fld_lkeHREmployeeGiveID.BOSSelectTypeValue = "";
            this.fld_lkeHREmployeeGiveID.CurrentDisplayText = "";
            this.fld_lkeHREmployeeGiveID.Location = new System.Drawing.Point(301, 20);
            this.fld_lkeHREmployeeGiveID.Name = "fld_lkeHREmployeeGiveID";
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeGiveID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeGiveID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeGiveID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeHREmployeeGiveID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeGiveID.Properties.NullText = "";
            this.fld_lkeHREmployeeGiveID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeGiveID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeGiveID.Screen = null;
            this.fld_lkeHREmployeeGiveID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeHREmployeeGiveID.TabIndex = 158;
            this.fld_lkeHREmployeeGiveID.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(237, 49);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(55, 13);
            this.bosLabel20.TabIndex = 162;
            this.bosLabel20.Text = "Người nhận";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(460, 22);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(15, 13);
            this.bosLabel21.TabIndex = 163;
            this.bosLabel21.Text = "QC";
            // 
            // fld_dgvMMOperationDetailPlanItems
            // 
            this.fld_dgvMMOperationDetailPlanItems.Name = "fld_dgvMMOperationDetailPlanItems";
            this.fld_dgvMMOperationDetailPlanItems.PaintStyleName = "Office2003";
            // 
            // DMODPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1757, 852);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMODPS100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMODPS100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.fld_bolEquipment.ResumeLayout(false);
            this.fld_bolTicket.ResumeLayout(false);
            this.fld_bolJob.ResumeLayout(false);
            this.fld_bolWorkCenter.ResumeLayout(false);
            this.fld_bolWorkCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            this.fld_bolDate.ResumeLayout(false);
            this.fld_bolDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbOperationsSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedMMOperationDetailPlanWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabOperationPlanList)).EndInit();
            this.fld_tabOperationPlanList.ResumeLayout(false);
            this.fld_tabDetailPlan.ResumeLayout(false);
            this.fld_tabDetailPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHuman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusClosed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusCanceled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusApproved.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAllPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanItemChilds)).EndInit();
            this.fld_tabHumanUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcHuman)).EndInit();
            this.fld_spcHuman.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteHumanOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHumanHRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkHumanNotTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHumanUnits)).EndInit();
            this.fld_Detail.ResumeLayout(false);
            this.fld_Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeSelectAllHumanticket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeDetailPlanHumanAllowcation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeHumanPlanByOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllHumanDetailPlanItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHumanDetailPlanItems)).EndInit();
            this.fld_tabMachineUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcMachine)).EndInit();
            this.fld_spcMachine.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteMachineOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWorshopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMachineNotTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMachineUnits)).EndInit();
            this.bosLine6.ResumeLayout(false);
            this.bosLine6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeAllMachineTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeTicketNothaveMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeTicketByOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_TicketHaveMachine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineDetailPlanItems)).EndInit();
            this.fld_xtabEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllEquipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDetailPlanEquipments)).EndInit();
            this.fld_tabJobTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).EndInit();
            this.fld_splTicket.ResumeLayout(false);
            this.bosLine8.ResumeLayout(false);
            this.bosLine8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteTicketOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bteTicketHuman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkTicketRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMTicketPlanItems)).EndInit();
            this.bosLine9.ResumeLayout(false);
            this.bosLine9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCapacityItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeQCID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAllCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCapacityFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTakeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGiveID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMOperationDetailPlanItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMOperationDetailPlanItems;
        private BOSComponent.BOSTabControl fld_tabOperationPlanList;
        private DevExpress.XtraTab.XtraTabPage fld_tabDetailPlan;
        private MMOperationDetailPlanItemChildsGridControl fld_dgcMMOperationDetailPlanItemChilds;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnAddDetail;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLine fld_bolWorkCenter;
        private BOSComponent.BOSButton fld_btnUpdatePosition;
        private BOSComponent.BOSLine fld_bolDate;
        private BOSComponent.BOSButton fld_btnUpdatePlanDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSCheckEdit fld_chkHumanNotTicket;
        private BOSComponent.BOSDateEdit fld_dteMMOperationDetailPlanToDate;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSDateEdit fld_dteMMOperationDetailPlanFromDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButtonEdit fld_bedMMOperationDetailPlanWeek;
        private DevExpress.XtraTab.XtraTabPage fld_tabHumanUnit;
        private DevExpress.XtraTab.XtraTabPage fld_tabMachineUnit;
        private BOSComponent.BOSLine bosLine4;
        private ChooseHumanUnitTreeControl fld_trlHumanUnits;
        private BOSComponent.BOSLine fld_Detail;
        private BOSComponent.BOSLine bosLine5;
        private ChooseMachineUnitTreeControl fld_trlMachineUnits;
        private BOSComponent.BOSLine bosLine6;
        private MMHumanPlanItemsGridControl fld_dgcHumanDetailPlanItems;
        private MMMachinePlanItemsGridControl fld_dgcMachineDetailPlanItems;
        private DevExpress.XtraEditors.SplitContainerControl fld_spcHuman;
        private DevExpress.XtraEditors.SplitContainerControl fld_spcMachine;
        private BOSComponent.BOSCheckEdit fld_ckeDetailPlanHumanAllowcation;
        private BOSComponent.BOSCheckEdit fld_chkAllHumanDetailPlanItem;
        private BOSComponent.BOSCheckEdit fld_ckeMachineNotTicket;
        private BOSComponent.BOSCheckEdit fld_chkSelectAllPlan;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeHumanHRDepartmentID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSCheckEdit fld_ckeHumanPlanByOperation;
        private BOSComponent.BOSButton fld_btnZoomHuman;
        private BOSComponent.BOSLookupEdit fld_lkeMMWorshopID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSCheckEdit fld_ckeTicketNothaveMachine;
        private BOSComponent.BOSCheckEdit fld_ckeTicketByOperation;
        private BOSComponent.BOSCheckEdit fld_TicketHaveMachine;
        private BOSComponent.BOSButton fld_btnZoomMachine;
        private BOSComponent.BOSButton fld_btnCancelHuman;
        private BOSComponent.BOSButton fld_btnAddHuman;
        private BOSComponent.BOSButton fld_btnCancelMachine;
        private BOSComponent.BOSButton fld_btnAddMachine;
        private BOSComponent.BOSCheckEdit fld_ckeSelectAllHumanticket;
        private BOSComponent.BOSCheckEdit fld_ckeAllMachineTicket;
        private BOSComponent.BOSButtonEdit fld_bteHumanOperation;
        private BOSComponent.BOSButtonEdit fld_bteMachineOperation;
        private DevExpress.XtraTab.XtraTabPage fld_tabJobTicket;
        private BOSComponent.BOSButton fld_btnJobClose;
        private BOSComponent.BOSButton fld_btnJobCancel;
        private BOSComponent.BOSButton fld_btnJobCreate;
        private MMTicketPlanItemsGridControl fld_dgcMMTicketPlanItems;
        private BOSComponent.BOSCheckEdit fld_chkStatusClosed;
        private BOSComponent.BOSCheckEdit fld_chkStatusCanceled;
        private BOSComponent.BOSCheckEdit fld_chkStatusNew;
        private BOSComponent.BOSCheckEdit fld_chkStatusApproved;
        private BOSComponent.BOSLabel fld_lblStatusLate;
        private Button fld_btnStatusLate;
        private BOSComponent.BOSButton fld_btnTicketZoom;
        private DevExpress.XtraEditors.SplitContainerControl fld_splTicket;
        private BOSComponent.BOSLine bosLine8;
        private BOSComponent.BOSLine bosLine9;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel fld_lblStatusAlittleReceipt;
        private Button fld_btnStatusAlittleReceipt;
        private Button button1;
        private BOSComponent.BOSCheckEdit fld_chkTicketRemain;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeQCID;
        private BOSComponent.BOSLabel fld_lblFrom;
        private BOSComponent.BOSDateEdit fld_dteCapacityFromDate;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeTakeID;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeGiveID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel21;
        private MMCapacityItemsGridControl fld_dgcCapacityItemsGridControl;
        private BOSComponent.BOSButton fld_btnSaveCapacity;
        private BOSComponent.BOSLabel fld_lblAllticket;
        private BOSComponent.BOSButton fld_btnCapacityReceipt;
        private BOSComponent.BOSCheckEdit fld_chkAllTicket;
        private BOSComponent.BOSButtonEdit fld_bteTicketHuman;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSButtonEdit fld_bteTicketOperation;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLine fld_bolJob;
        private BOSComponent.BOSButton fld_btnUpdateCapacity;
        private BOSComponent.BOSCheckEdit fld_chkAllCapacity;
        private BOSComponent.BOSButton fld_btnOpenTicket;
        private BOSComponent.BOSLine fld_bolTicket;
        private BOSComponent.BOSButton fld_btnCancelTicket;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel fld_lblTotalBlock;
        private BOSComponent.BOSLabel fld_lblTotalQty;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel fld_lblMachineTotalBlock;
        private BOSComponent.BOSLabel fld_lblMachineTotalQty;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeHuman;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLookupEdit fld_lkeMachine;
        private BOSComponent.BOSLabel bosLabel27;
        private DevExpress.XtraTab.XtraTabPage fld_xtabEquipment;
        private BOSComponent.BOSButton fld_btnEquipmentZoom;
        private MMEquipmentPlanItemsGridControl fld_dgcMMDetailPlanEquipments;
        private BOSComponent.BOSButton fld_btnEquipmentRefesh;
        private BOSComponent.BOSLine fld_bolEquipment;
        private BOSComponent.BOSButton fld_btnRegisEquipment;
        private BOSComponent.BOSButton fld_btnCancelEquipment;
        private BOSComponent.BOSCheckEdit fld_chkAllEquipment;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtProductNo;
        private BOSComponent.BOSTextBox fld_txtProductName;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLookupEdit fld_lkeSaleOrderID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel3;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_cmbOperationsSearch;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnEditHuman;
        private BOSComponent.BOSButton fld_btnEditMachine;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSButton fld_btnTicketHumanEdit;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSDateEdit fld_dteCapacityToDate;
        private BOSComponent.BOSLabel fld_lblBatchWoodStatus;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSButton fld_btnODPCloseBatch;
    }
}
