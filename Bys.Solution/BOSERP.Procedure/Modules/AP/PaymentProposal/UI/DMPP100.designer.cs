using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentProposal.UI
{
	/// <summary>
	/// Summary description for DMPP100
	/// </summary>
	partial class DMPP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPP100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_txtAPPaymentProposalProject = new BOSComponent.BOSTextBox(this.components);
            this.fld_medAPPaymentProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPaymentProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_linkViewApproval = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.fld_lkeAPPaymentProposalDocAttachCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPaymentProposalApproveDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeAPPaymentProposalPriorityCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_txtAPPaymentProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPaymentProposalPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPaymentProposalPayDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPaymentProposalStatusCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_ACListAccountBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentProposalReceiverBankName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPaymentProposalObjectReceiptName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPaymentProposalReceiverAccount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentProposalReceiverBankCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPPaymentProposalReceiptAddress = new BOSComponent.BOSMemoEdit(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentProposalTotalAmount1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPaymentProposalDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentProposalDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPaymentProposalTotalPaymentAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_cmbAllocationType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentProposalTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnAllocation = new BOSComponent.BOSButton(this.components);
            this.fld_btnSelectPaymentTerm = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPPaymentProposalItems = new BOSERP.Modules.PaymentProposal.PaymentProposalItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPaymentProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalDocAttachCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalApproveDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalApproveDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalPriorityCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalPayDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalPayDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalStatusCombo.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACListAccountBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalReceiverBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalObjectReceiptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalReceiverAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalReceiverBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPaymentProposalReceiptAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalTotalAmount1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbAllocationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(1399, 786);
            this.bosPanel1.TabIndex = 116;
            // 
            // bosLine1
            // 
            this.bosLine1.BackColor = System.Drawing.Color.Transparent;
            this.bosLine1.BOSComment = "";
            this.bosLine1.BOSDataMember = "";
            this.bosLine1.BOSDataSource = "";
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = "";
            this.bosLine1.BOSFieldRelation = "";
            this.bosLine1.BOSPrivilege = "";
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_txtAPPaymentProposalProject);
            this.bosLine1.Controls.Add(this.fld_medAPPaymentProposalDesc);
            this.bosLine1.Controls.Add(this.bosLabel8);
            this.bosLine1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine1.Controls.Add(this.fld_lblLabel11);
            this.bosLine1.Controls.Add(this.bosLabel13);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.fld_dteAPPaymentProposalDate);
            this.bosLine1.Controls.Add(this.bosLabel18);
            this.bosLine1.Controls.Add(this.fld_linkViewApproval);
            this.bosLine1.Controls.Add(this.fld_lkeAPPaymentProposalDocAttachCombo);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.bosLabel10);
            this.bosLine1.Controls.Add(this.bosLabel6);
            this.bosLine1.Controls.Add(this.fld_dteAPPaymentProposalApproveDate);
            this.bosLine1.Controls.Add(this.fld_lkeAPPaymentProposalPriorityCombo);
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine1.Controls.Add(this.fld_txtAPPaymentProposalNo);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.fld_lkeAPPaymentProposalPaymentMethodCombo);
            this.bosLine1.Controls.Add(this.fld_lblLabel1);
            this.bosLine1.Controls.Add(this.fld_lblLabel3);
            this.bosLine1.Controls.Add(this.fld_dteAPPaymentProposalPayDate);
            this.bosLine1.Controls.Add(this.bosLabel5);
            this.bosLine1.Controls.Add(this.bosLabel4);
            this.bosLine1.Controls.Add(this.fld_lkeAPPaymentProposalStatusCombo);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(5, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(777, 199);
            this.bosLine1.TabIndex = 726;
            this.bosLine1.TabStop = false;
            this.bosLine1.Tag = "";
            this.bosLine1.Text = "Thông tin chung";
            // 
            // fld_txtAPPaymentProposalProject
            // 
            this.fld_txtAPPaymentProposalProject.BOSComment = "";
            this.fld_txtAPPaymentProposalProject.BOSDataMember = "APPaymentProposalProject";
            this.fld_txtAPPaymentProposalProject.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalProject.BOSDescription = null;
            this.fld_txtAPPaymentProposalProject.BOSError = null;
            this.fld_txtAPPaymentProposalProject.BOSFieldGroup = "";
            this.fld_txtAPPaymentProposalProject.BOSFieldRelation = "";
            this.fld_txtAPPaymentProposalProject.BOSPrivilege = "";
            this.fld_txtAPPaymentProposalProject.BOSPropertyName = "EditValue";
            this.fld_txtAPPaymentProposalProject.EditValue = "";
            this.fld_txtAPPaymentProposalProject.Location = new System.Drawing.Point(84, 97);
            this.fld_txtAPPaymentProposalProject.Name = "fld_txtAPPaymentProposalProject";
            this.fld_txtAPPaymentProposalProject.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentProposalProject.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalProject.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalProject.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalProject.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalProject.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPPaymentProposalProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalProject.Screen = null;
            this.fld_txtAPPaymentProposalProject.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentProposalProject.TabIndex = 725;
            this.fld_txtAPPaymentProposalProject.Tag = "DC";
            // 
            // fld_medAPPaymentProposalDesc
            // 
            this.fld_medAPPaymentProposalDesc.BOSComment = "";
            this.fld_medAPPaymentProposalDesc.BOSDataMember = "APPaymentProposalDesc";
            this.fld_medAPPaymentProposalDesc.BOSDataSource = "APPaymentProposals";
            this.fld_medAPPaymentProposalDesc.BOSDescription = null;
            this.fld_medAPPaymentProposalDesc.BOSError = null;
            this.fld_medAPPaymentProposalDesc.BOSFieldGroup = "";
            this.fld_medAPPaymentProposalDesc.BOSFieldRelation = "";
            this.fld_medAPPaymentProposalDesc.BOSPrivilege = "";
            this.fld_medAPPaymentProposalDesc.BOSPropertyName = "Text";
            this.fld_medAPPaymentProposalDesc.EditValue = "";
            this.fld_medAPPaymentProposalDesc.Location = new System.Drawing.Point(84, 123);
            this.fld_medAPPaymentProposalDesc.Name = "fld_medAPPaymentProposalDesc";
            this.fld_medAPPaymentProposalDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPPaymentProposalDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPPaymentProposalDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPPaymentProposalDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPPaymentProposalDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medAPPaymentProposalDesc, true);
            this.fld_medAPPaymentProposalDesc.Size = new System.Drawing.Size(414, 65);
            this.fld_medAPPaymentProposalDesc.TabIndex = 12;
            this.fld_medAPPaymentProposalDesc.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 48);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(66, 13);
            this.bosLabel8.TabIndex = 102;
            this.bosLabel8.Text = "Người đề nghị";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(611, 45);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.ReadOnly = true;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 724;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = null;
            this.fld_lblLabel11.BOSDataMember = null;
            this.fld_lblLabel11.BOSDataSource = null;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = null;
            this.fld_lblLabel11.BOSFieldRelation = null;
            this.fld_lblLabel11.BOSPrivilege = null;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(526, 126);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel11.TabIndex = 105;
            this.fld_lblLabel11.Text = "Phòng ban";
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
            this.bosLabel13.Location = new System.Drawing.Point(526, 48);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(53, 13);
            this.bosLabel13.TabIndex = 723;
            this.bosLabel13.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(611, 123);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 11;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(84, 45);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã NV", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên NV")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(526, 100);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(39, 13);
            this.bosLabel9.TabIndex = 106;
            this.bosLabel9.Text = "Bộ phận";
            // 
            // fld_dteAPPaymentProposalDate
            // 
            this.fld_dteAPPaymentProposalDate.BOSComment = "";
            this.fld_dteAPPaymentProposalDate.BOSDataMember = "APPaymentProposalDate";
            this.fld_dteAPPaymentProposalDate.BOSDataSource = "APPaymentProposals";
            this.fld_dteAPPaymentProposalDate.BOSDescription = null;
            this.fld_dteAPPaymentProposalDate.BOSError = null;
            this.fld_dteAPPaymentProposalDate.BOSFieldGroup = "";
            this.fld_dteAPPaymentProposalDate.BOSFieldRelation = "";
            this.fld_dteAPPaymentProposalDate.BOSPrivilege = "";
            this.fld_dteAPPaymentProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPaymentProposalDate.EditValue = null;
            this.fld_dteAPPaymentProposalDate.Location = new System.Drawing.Point(348, 19);
            this.fld_dteAPPaymentProposalDate.Name = "fld_dteAPPaymentProposalDate";
            this.fld_dteAPPaymentProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPaymentProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPaymentProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPaymentProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPaymentProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPaymentProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPaymentProposalDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPPaymentProposalDate, true);
            this.fld_dteAPPaymentProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPaymentProposalDate.TabIndex = 1;
            this.fld_dteAPPaymentProposalDate.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(526, 152);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(79, 13);
            this.bosLabel18.TabIndex = 107;
            this.bosLabel18.Text = "Chứng từ đi kèm";
            // 
            // fld_linkViewApproval
            // 
            this.fld_linkViewApproval.Location = new System.Drawing.Point(624, 175);
            this.fld_linkViewApproval.Name = "fld_linkViewApproval";
            this.fld_linkViewApproval.Size = new System.Drawing.Size(118, 13);
            this.fld_linkViewApproval.TabIndex = 722;
            this.fld_linkViewApproval.Text = "Xem thông tin phê duyệt";
            this.fld_linkViewApproval.Click += new System.EventHandler(this.fld_linkViewApproval_Click);
            // 
            // fld_lkeAPPaymentProposalDocAttachCombo
            // 
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSAllowDummy = true;
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSComment = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSDataMember = "APPaymentProposalDocAttachCombo";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSDescription = null;
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSError = null;
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSFieldGroup = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSFieldParent = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSFieldRelation = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSPrivilege = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSSelectType = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.CurrentDisplayText = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.Location = new System.Drawing.Point(611, 149);
            this.fld_lkeAPPaymentProposalDocAttachCombo.Name = "fld_lkeAPPaymentProposalDocAttachCombo";
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.ColumnName = null;
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.NullText = "";
            this.fld_lkeAPPaymentProposalDocAttachCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentProposalDocAttachCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentProposalDocAttachCombo, true);
            this.fld_lkeAPPaymentProposalDocAttachCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentProposalDocAttachCombo.TabIndex = 9;
            this.fld_lkeAPPaymentProposalDocAttachCombo.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(611, 97);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Tên phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 10;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(262, 22);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(63, 13);
            this.bosLabel7.TabIndex = 101;
            this.bosLabel7.Text = "Ngày đề nghị";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(262, 100);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(71, 13);
            this.bosLabel10.TabIndex = 109;
            this.bosLabel10.Text = "Ngày duyệt TT";
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
            this.bosLabel6.Location = new System.Drawing.Point(262, 48);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(51, 13);
            this.bosLabel6.TabIndex = 104;
            this.bosLabel6.Text = "Độ ưu tiên";
            // 
            // fld_dteAPPaymentProposalApproveDate
            // 
            this.fld_dteAPPaymentProposalApproveDate.BOSComment = "";
            this.fld_dteAPPaymentProposalApproveDate.BOSDataMember = "APPaymentProposalApproveDate";
            this.fld_dteAPPaymentProposalApproveDate.BOSDataSource = "APPaymentProposals";
            this.fld_dteAPPaymentProposalApproveDate.BOSDescription = null;
            this.fld_dteAPPaymentProposalApproveDate.BOSError = null;
            this.fld_dteAPPaymentProposalApproveDate.BOSFieldGroup = "";
            this.fld_dteAPPaymentProposalApproveDate.BOSFieldRelation = "";
            this.fld_dteAPPaymentProposalApproveDate.BOSPrivilege = "";
            this.fld_dteAPPaymentProposalApproveDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPaymentProposalApproveDate.EditValue = null;
            this.fld_dteAPPaymentProposalApproveDate.Enabled = false;
            this.fld_dteAPPaymentProposalApproveDate.Location = new System.Drawing.Point(348, 97);
            this.fld_dteAPPaymentProposalApproveDate.Name = "fld_dteAPPaymentProposalApproveDate";
            this.fld_dteAPPaymentProposalApproveDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPaymentProposalApproveDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPaymentProposalApproveDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPaymentProposalApproveDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPaymentProposalApproveDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPaymentProposalApproveDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPaymentProposalApproveDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPPaymentProposalApproveDate, true);
            this.fld_dteAPPaymentProposalApproveDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPaymentProposalApproveDate.TabIndex = 108;
            this.fld_dteAPPaymentProposalApproveDate.Tag = "DC";
            // 
            // fld_lkeAPPaymentProposalPriorityCombo
            // 
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSAllowDummy = true;
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSComment = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSDataMember = "APPriority";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSDescription = null;
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSError = null;
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSFieldGroup = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSFieldParent = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSFieldRelation = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSPrivilege = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSSelectType = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.CurrentDisplayText = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.Location = new System.Drawing.Point(348, 45);
            this.fld_lkeAPPaymentProposalPriorityCombo.Name = "fld_lkeAPPaymentProposalPriorityCombo";
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.ColumnName = null;
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.NullText = "";
            this.fld_lkeAPPaymentProposalPriorityCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentProposalPriorityCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentProposalPriorityCombo, true);
            this.fld_lkeAPPaymentProposalPriorityCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentProposalPriorityCombo.TabIndex = 4;
            this.fld_lkeAPPaymentProposalPriorityCombo.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 126);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(42, 13);
            this.bosLabel3.TabIndex = 97;
            this.bosLabel3.Text = "Nội dung";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPaymentProposals";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(84, 71);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 6;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_txtAPPaymentProposalNo
            // 
            this.fld_txtAPPaymentProposalNo.BOSComment = "";
            this.fld_txtAPPaymentProposalNo.BOSDataMember = "APPaymentProposalNo";
            this.fld_txtAPPaymentProposalNo.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalNo.BOSDescription = null;
            this.fld_txtAPPaymentProposalNo.BOSError = null;
            this.fld_txtAPPaymentProposalNo.BOSFieldGroup = "";
            this.fld_txtAPPaymentProposalNo.BOSFieldRelation = "";
            this.fld_txtAPPaymentProposalNo.BOSPrivilege = "";
            this.fld_txtAPPaymentProposalNo.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalNo.EditValue = "";
            this.fld_txtAPPaymentProposalNo.Location = new System.Drawing.Point(84, 19);
            this.fld_txtAPPaymentProposalNo.Name = "fld_txtAPPaymentProposalNo";
            this.fld_txtAPPaymentProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalNo.Properties.ReadOnly = true;
            this.fld_txtAPPaymentProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPPaymentProposalNo, true);
            this.fld_txtAPPaymentProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentProposalNo.TabIndex = 0;
            this.fld_txtAPPaymentProposalNo.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 22);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 98;
            this.bosLabel1.Text = "Mã đề nghị";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 100);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(45, 13);
            this.bosLabel2.TabIndex = 99;
            this.bosLabel2.Text = "Mã dự án";
            // 
            // fld_lkeAPPaymentProposalPaymentMethodCombo
            // 
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSAllowDummy = true;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSComment = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSDataMember = "APPaymentProposalPaymentMethodCombo";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSDescription = null;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSError = null;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSFieldGroup = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSFieldParent = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSFieldRelation = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSPrivilege = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSSelectType = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.CurrentDisplayText = null;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Location = new System.Drawing.Point(348, 71);
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Name = "fld_lkeAPPaymentProposalPaymentMethodCombo";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.ColumnName = null;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.NullText = "";
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentProposalPaymentMethodCombo, true);
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.TabIndex = 7;
            this.fld_lkeAPPaymentProposalPaymentMethodCombo.Tag = "DC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(12, 74);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel1, true);
            this.fld_lblLabel1.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel1.TabIndex = 80;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Đối tượng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(262, 74);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel3, true);
            this.fld_lblLabel3.Size = new System.Drawing.Size(77, 13);
            this.fld_lblLabel3.TabIndex = 78;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Phương thức TT";
            // 
            // fld_dteAPPaymentProposalPayDate
            // 
            this.fld_dteAPPaymentProposalPayDate.BOSComment = "";
            this.fld_dteAPPaymentProposalPayDate.BOSDataMember = "APPaymentProposalPayDate";
            this.fld_dteAPPaymentProposalPayDate.BOSDataSource = "APPaymentProposals";
            this.fld_dteAPPaymentProposalPayDate.BOSDescription = null;
            this.fld_dteAPPaymentProposalPayDate.BOSError = null;
            this.fld_dteAPPaymentProposalPayDate.BOSFieldGroup = "";
            this.fld_dteAPPaymentProposalPayDate.BOSFieldRelation = "";
            this.fld_dteAPPaymentProposalPayDate.BOSPrivilege = "";
            this.fld_dteAPPaymentProposalPayDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPaymentProposalPayDate.EditValue = null;
            this.fld_dteAPPaymentProposalPayDate.Location = new System.Drawing.Point(611, 71);
            this.fld_dteAPPaymentProposalPayDate.Name = "fld_dteAPPaymentProposalPayDate";
            this.fld_dteAPPaymentProposalPayDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPaymentProposalPayDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPaymentProposalPayDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPaymentProposalPayDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPaymentProposalPayDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPaymentProposalPayDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPaymentProposalPayDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPPaymentProposalPayDate, true);
            this.fld_dteAPPaymentProposalPayDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPaymentProposalPayDate.TabIndex = 8;
            this.fld_dteAPPaymentProposalPayDate.Tag = "DC";
            this.fld_dteAPPaymentProposalPayDate.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.fld_dteAPPaymentProposalPayDate_CustomDisplayText);
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
            this.bosLabel5.Location = new System.Drawing.Point(526, 74);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 103;
            this.bosLabel5.Text = "Thời hạn TT";
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
            this.bosLabel4.Location = new System.Drawing.Point(526, 22);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 100;
            this.bosLabel4.Text = "Tình trạng";
            // 
            // fld_lkeAPPaymentProposalStatusCombo
            // 
            this.fld_lkeAPPaymentProposalStatusCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentProposalStatusCombo.BOSAllowDummy = true;
            this.fld_lkeAPPaymentProposalStatusCombo.BOSComment = "";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSDataMember = "APPaymentProposalStatusCombo";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSDescription = null;
            this.fld_lkeAPPaymentProposalStatusCombo.BOSError = null;
            this.fld_lkeAPPaymentProposalStatusCombo.BOSFieldGroup = "";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSFieldParent = "";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSFieldRelation = "";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSPrivilege = "";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSSelectType = "";
            this.fld_lkeAPPaymentProposalStatusCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentProposalStatusCombo.CurrentDisplayText = "";
            this.fld_lkeAPPaymentProposalStatusCombo.Location = new System.Drawing.Point(611, 19);
            this.fld_lkeAPPaymentProposalStatusCombo.Name = "fld_lkeAPPaymentProposalStatusCombo";
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.ColumnName = null;
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.NullText = "";
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.ReadOnly = true;
            this.fld_lkeAPPaymentProposalStatusCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentProposalStatusCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentProposalStatusCombo, true);
            this.fld_lkeAPPaymentProposalStatusCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentProposalStatusCombo.TabIndex = 2;
            this.fld_lkeAPPaymentProposalStatusCombo.Tag = "DC";
            // 
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = "";
            this.bosLine3.BOSDataMember = "";
            this.bosLine3.BOSDataSource = "";
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = "";
            this.bosLine3.BOSFieldRelation = "";
            this.bosLine3.BOSPrivilege = "";
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACListAccountBankID);
            this.bosLine3.Controls.Add(this.bosLabel24);
            this.bosLine3.Controls.Add(this.fld_txtAPPaymentProposalReceiverBankName);
            this.bosLine3.Controls.Add(this.fld_txtAPPaymentProposalObjectReceiptName);
            this.bosLine3.Controls.Add(this.fld_txtAPPaymentProposalReceiverAccount);
            this.bosLine3.Controls.Add(this.bosLabel14);
            this.bosLine3.Controls.Add(this.bosLabel15);
            this.bosLine3.Controls.Add(this.fld_txtAPPaymentProposalReceiverBankCode);
            this.bosLine3.Controls.Add(this.bosLabel16);
            this.bosLine3.Controls.Add(this.bosLabel21);
            this.bosLine3.Controls.Add(this.bosLabel17);
            this.bosLine3.Controls.Add(this.fld_medAPPaymentProposalReceiptAddress);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(788, 3);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(479, 199);
            this.bosLine3.TabIndex = 725;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin người nhận";
            // 
            // fld_lkeFK_ACListAccountBankID
            // 
            this.fld_lkeFK_ACListAccountBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACListAccountBankID.BOSAllowDummy = false;
            this.fld_lkeFK_ACListAccountBankID.BOSComment = "";
            this.fld_lkeFK_ACListAccountBankID.BOSDataMember = "FK_ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_ACListAccountBankID.BOSDescription = null;
            this.fld_lkeFK_ACListAccountBankID.BOSError = null;
            this.fld_lkeFK_ACListAccountBankID.BOSFieldGroup = "";
            this.fld_lkeFK_ACListAccountBankID.BOSFieldParent = "";
            this.fld_lkeFK_ACListAccountBankID.BOSFieldRelation = "";
            this.fld_lkeFK_ACListAccountBankID.BOSPrivilege = "";
            this.fld_lkeFK_ACListAccountBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACListAccountBankID.BOSSelectType = "";
            this.fld_lkeFK_ACListAccountBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACListAccountBankID.CurrentDisplayText = null;
            this.fld_lkeFK_ACListAccountBankID.Location = new System.Drawing.Point(96, 19);
            this.fld_lkeFK_ACListAccountBankID.Name = "fld_lkeFK_ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACListAccountBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACListAccountBankID.Properties.ColumnName = null;
            this.fld_lkeFK_ACListAccountBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACListAccountBankNo", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACListAccountBankName", "Tên ngân hàng")});
            this.fld_lkeFK_ACListAccountBankID.Properties.DisplayMember = "ACListAccountBankName";
            this.fld_lkeFK_ACListAccountBankID.Properties.NullText = "";
            this.fld_lkeFK_ACListAccountBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACListAccountBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACListAccountBankID.Properties.ValueMember = "ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.Screen = null;
            this.fld_lkeFK_ACListAccountBankID.Size = new System.Drawing.Size(370, 20);
            this.fld_lkeFK_ACListAccountBankID.TabIndex = 10;
            this.fld_lkeFK_ACListAccountBankID.Tag = "DC";
            this.fld_lkeFK_ACListAccountBankID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ACListAccountBankID_QueryPopUp);
            this.fld_lkeFK_ACListAccountBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACListAccountBankID_CloseUp);
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = "";
            this.bosLabel24.Location = new System.Drawing.Point(12, 22);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(52, 13);
            this.bosLabel24.TabIndex = 21;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Ngân hàng";
            // 
            // fld_txtAPPaymentProposalReceiverBankName
            // 
            this.fld_txtAPPaymentProposalReceiverBankName.BOSComment = null;
            this.fld_txtAPPaymentProposalReceiverBankName.BOSDataMember = "APPaymentProposalReceiverBankName";
            this.fld_txtAPPaymentProposalReceiverBankName.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalReceiverBankName.BOSDescription = null;
            this.fld_txtAPPaymentProposalReceiverBankName.BOSError = null;
            this.fld_txtAPPaymentProposalReceiverBankName.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalReceiverBankName.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalReceiverBankName.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalReceiverBankName.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalReceiverBankName.Location = new System.Drawing.Point(96, 45);
            this.fld_txtAPPaymentProposalReceiverBankName.Name = "fld_txtAPPaymentProposalReceiverBankName";
            this.fld_txtAPPaymentProposalReceiverBankName.Screen = null;
            this.fld_txtAPPaymentProposalReceiverBankName.Size = new System.Drawing.Size(370, 20);
            this.fld_txtAPPaymentProposalReceiverBankName.TabIndex = 11;
            this.fld_txtAPPaymentProposalReceiverBankName.Tag = "DC";
            // 
            // fld_txtAPPaymentProposalObjectReceiptName
            // 
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSComment = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSDataMember = "APPaymentProposalObjectReceiptName";
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSDescription = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSError = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalObjectReceiptName.Location = new System.Drawing.Point(96, 97);
            this.fld_txtAPPaymentProposalObjectReceiptName.Name = "fld_txtAPPaymentProposalObjectReceiptName";
            this.fld_txtAPPaymentProposalObjectReceiptName.Screen = null;
            this.fld_txtAPPaymentProposalObjectReceiptName.Size = new System.Drawing.Size(370, 20);
            this.fld_txtAPPaymentProposalObjectReceiptName.TabIndex = 13;
            this.fld_txtAPPaymentProposalObjectReceiptName.Tag = "DC";
            // 
            // fld_txtAPPaymentProposalReceiverAccount
            // 
            this.fld_txtAPPaymentProposalReceiverAccount.BOSComment = null;
            this.fld_txtAPPaymentProposalReceiverAccount.BOSDataMember = "APPaymentProposalReceiverAccount";
            this.fld_txtAPPaymentProposalReceiverAccount.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalReceiverAccount.BOSDescription = null;
            this.fld_txtAPPaymentProposalReceiverAccount.BOSError = null;
            this.fld_txtAPPaymentProposalReceiverAccount.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalReceiverAccount.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalReceiverAccount.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalReceiverAccount.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalReceiverAccount.Location = new System.Drawing.Point(96, 71);
            this.fld_txtAPPaymentProposalReceiverAccount.Name = "fld_txtAPPaymentProposalReceiverAccount";
            this.fld_txtAPPaymentProposalReceiverAccount.Screen = null;
            this.fld_txtAPPaymentProposalReceiverAccount.Size = new System.Drawing.Size(149, 20);
            this.fld_txtAPPaymentProposalReceiverAccount.TabIndex = 14;
            this.fld_txtAPPaymentProposalReceiverAccount.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(12, 74);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(46, 13);
            this.bosLabel14.TabIndex = 18;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tài khoản";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = "";
            this.bosLabel15.Location = new System.Drawing.Point(12, 126);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(32, 13);
            this.bosLabel15.TabIndex = 15;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Địa chỉ";
            // 
            // fld_txtAPPaymentProposalReceiverBankCode
            // 
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSComment = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSDataMember = "APPaymentProposalReceiverBankCode";
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSDescription = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSError = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalReceiverBankCode.Location = new System.Drawing.Point(317, 71);
            this.fld_txtAPPaymentProposalReceiverBankCode.Name = "fld_txtAPPaymentProposalReceiverBankCode";
            this.fld_txtAPPaymentProposalReceiverBankCode.Screen = null;
            this.fld_txtAPPaymentProposalReceiverBankCode.Size = new System.Drawing.Size(149, 20);
            this.fld_txtAPPaymentProposalReceiverBankCode.TabIndex = 12;
            this.fld_txtAPPaymentProposalReceiverBankCode.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(12, 48);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(48, 13);
            this.bosLabel16.TabIndex = 16;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Chi nhánh";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(270, 74);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(31, 13);
            this.bosLabel21.TabIndex = 19;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Mã NH";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = "";
            this.bosLabel17.Location = new System.Drawing.Point(12, 100);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(75, 13);
            this.bosLabel17.TabIndex = 17;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Tên người nhận";
            // 
            // fld_medAPPaymentProposalReceiptAddress
            // 
            this.fld_medAPPaymentProposalReceiptAddress.BOSComment = null;
            this.fld_medAPPaymentProposalReceiptAddress.BOSDataMember = "APPaymentProposalReceiptAddress";
            this.fld_medAPPaymentProposalReceiptAddress.BOSDataSource = "APPaymentProposals";
            this.fld_medAPPaymentProposalReceiptAddress.BOSDescription = null;
            this.fld_medAPPaymentProposalReceiptAddress.BOSError = null;
            this.fld_medAPPaymentProposalReceiptAddress.BOSFieldGroup = null;
            this.fld_medAPPaymentProposalReceiptAddress.BOSFieldRelation = null;
            this.fld_medAPPaymentProposalReceiptAddress.BOSPrivilege = null;
            this.fld_medAPPaymentProposalReceiptAddress.BOSPropertyName = "EditValue";
            this.fld_medAPPaymentProposalReceiptAddress.Location = new System.Drawing.Point(96, 123);
            this.fld_medAPPaymentProposalReceiptAddress.Name = "fld_medAPPaymentProposalReceiptAddress";
            this.fld_medAPPaymentProposalReceiptAddress.Screen = null;
            this.fld_medAPPaymentProposalReceiptAddress.Size = new System.Drawing.Size(370, 65);
            this.fld_medAPPaymentProposalReceiptAddress.TabIndex = 20;
            this.fld_medAPPaymentProposalReceiptAddress.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel44);
            this.bosGroupControl2.Controls.Add(this.fld_txtAPPaymentProposalTotalAmount1);
            this.bosGroupControl2.Controls.Add(this.fld_txtAPPaymentProposalDiscountFix);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel46);
            this.bosGroupControl2.Controls.Add(this.fld_txtAPPaymentProposalDiscountPerCent);
            this.bosGroupControl2.Controls.Add(this.fld_txtAPPaymentProposalTotalPaymentAmount);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel47);
            this.bosGroupControl2.Controls.Add(this.fld_cmbAllocationType);
            this.bosGroupControl2.Controls.Add(this.bosLabel11);
            this.bosGroupControl2.Controls.Add(this.bosLabel12);
            this.bosGroupControl2.Controls.Add(this.fld_txtAPPaymentProposalTotalAmount);
            this.bosGroupControl2.Controls.Add(this.fld_btnAllocation);
            this.bosGroupControl2.Controls.Add(this.fld_btnSelectPaymentTerm);
            this.bosGroupControl2.Controls.Add(this.fld_dgcAPPaymentProposalItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 208);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, true);
            this.bosGroupControl2.Size = new System.Drawing.Size(1392, 573);
            this.bosGroupControl2.TabIndex = 13;
            this.bosGroupControl2.Text = "Danh sách thanh toán";
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = null;
            this.fld_lblLabel44.BOSDataMember = null;
            this.fld_lblLabel44.BOSDataSource = null;
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = null;
            this.fld_lblLabel44.BOSFieldRelation = null;
            this.fld_lblLabel44.BOSPrivilege = null;
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(1140, 492);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 126;
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_txtAPPaymentProposalTotalAmount1
            // 
            this.fld_txtAPPaymentProposalTotalAmount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPaymentProposalTotalAmount1.BOSComment = null;
            this.fld_txtAPPaymentProposalTotalAmount1.BOSDataMember = "APPaymentProposalTotalAmount";
            this.fld_txtAPPaymentProposalTotalAmount1.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalTotalAmount1.BOSDescription = null;
            this.fld_txtAPPaymentProposalTotalAmount1.BOSError = null;
            this.fld_txtAPPaymentProposalTotalAmount1.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalTotalAmount1.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalTotalAmount1.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalTotalAmount1.BOSPropertyName = "EditValue";
            this.fld_txtAPPaymentProposalTotalAmount1.EditValue = "0.00";
            this.fld_txtAPPaymentProposalTotalAmount1.Location = new System.Drawing.Point(1207, 489);
            this.fld_txtAPPaymentProposalTotalAmount1.Name = "fld_txtAPPaymentProposalTotalAmount1";
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPPaymentProposalTotalAmount1.Properties.ReadOnly = true;
            this.fld_txtAPPaymentProposalTotalAmount1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalTotalAmount1.Screen = null;
            this.fld_txtAPPaymentProposalTotalAmount1.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAPPaymentProposalTotalAmount1.TabIndex = 122;
            this.fld_txtAPPaymentProposalTotalAmount1.Tag = "DC";
            // 
            // fld_txtAPPaymentProposalDiscountFix
            // 
            this.fld_txtAPPaymentProposalDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPaymentProposalDiscountFix.BOSComment = null;
            this.fld_txtAPPaymentProposalDiscountFix.BOSDataMember = "APPaymentProposalDiscountFix";
            this.fld_txtAPPaymentProposalDiscountFix.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalDiscountFix.BOSDescription = null;
            this.fld_txtAPPaymentProposalDiscountFix.BOSError = null;
            this.fld_txtAPPaymentProposalDiscountFix.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalDiscountFix.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalDiscountFix.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtAPPaymentProposalDiscountFix.EditValue = "0.00";
            this.fld_txtAPPaymentProposalDiscountFix.Location = new System.Drawing.Point(1283, 515);
            this.fld_txtAPPaymentProposalDiscountFix.Name = "fld_txtAPPaymentProposalDiscountFix";
            this.fld_txtAPPaymentProposalDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentProposalDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalDiscountFix.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtAPPaymentProposalDiscountFix.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPPaymentProposalDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalDiscountFix.Screen = null;
            this.fld_txtAPPaymentProposalDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtAPPaymentProposalDiscountFix.TabIndex = 124;
            this.fld_txtAPPaymentProposalDiscountFix.Tag = "DC";
            this.fld_txtAPPaymentProposalDiscountFix.Validated += new System.EventHandler(this.fld_txtAPPaymentProposalDiscountFix_Validated);
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = null;
            this.fld_lblLabel46.BOSDataMember = null;
            this.fld_lblLabel46.BOSDataSource = null;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = null;
            this.fld_lblLabel46.BOSFieldRelation = null;
            this.fld_lblLabel46.BOSPrivilege = null;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(1083, 518);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(107, 13);
            this.fld_lblLabel46.TabIndex = 127;
            this.fld_lblLabel46.Text = "Chiết khấu thanh toán";
            // 
            // fld_txtAPPaymentProposalDiscountPerCent
            // 
            this.fld_txtAPPaymentProposalDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSComment = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSDataMember = "APPaymentProposalDiscountPerCent";
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSDescription = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSError = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtAPPaymentProposalDiscountPerCent.EditValue = "0.00";
            this.fld_txtAPPaymentProposalDiscountPerCent.Location = new System.Drawing.Point(1205, 515);
            this.fld_txtAPPaymentProposalDiscountPerCent.Name = "fld_txtAPPaymentProposalDiscountPerCent";
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtAPPaymentProposalDiscountPerCent.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPPaymentProposalDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalDiscountPerCent.Screen = null;
            this.fld_txtAPPaymentProposalDiscountPerCent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtAPPaymentProposalDiscountPerCent.TabIndex = 123;
            this.fld_txtAPPaymentProposalDiscountPerCent.Tag = "DC";
            this.fld_txtAPPaymentProposalDiscountPerCent.Validated += new System.EventHandler(this.fld_txtAPPaymentProposalDiscountPerCent_Validated);
            // 
            // fld_txtAPPaymentProposalTotalPaymentAmount
            // 
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSComment = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSDataMember = "APPaymentProposalTotalPaymentAmount";
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSDescription = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSError = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.BOSPropertyName = "EditValue";
            this.fld_txtAPPaymentProposalTotalPaymentAmount.EditValue = "0.00";
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Location = new System.Drawing.Point(1205, 541);
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Name = "fld_txtAPPaymentProposalTotalPaymentAmount";
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties.ReadOnly = true;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Screen = null;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Size = new System.Drawing.Size(178, 20);
            this.fld_txtAPPaymentProposalTotalPaymentAmount.TabIndex = 125;
            this.fld_txtAPPaymentProposalTotalPaymentAmount.Tag = "DC";
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseFont = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = null;
            this.fld_lblLabel47.BOSDataMember = null;
            this.fld_lblLabel47.BOSDataSource = null;
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = null;
            this.fld_lblLabel47.BOSFieldRelation = null;
            this.fld_lblLabel47.BOSPrivilege = null;
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(1097, 544);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(93, 13);
            this.fld_lblLabel47.TabIndex = 128;
            this.fld_lblLabel47.Text = "Tổng thanh toán";
            // 
            // fld_cmbAllocationType
            // 
            this.fld_cmbAllocationType.Location = new System.Drawing.Point(545, 29);
            this.fld_cmbAllocationType.MenuManager = this.screenToolbar;
            this.fld_cmbAllocationType.Name = "fld_cmbAllocationType";
            this.fld_cmbAllocationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbAllocationType.Properties.Items.AddRange(new object[] {
            "Ngày đến hạn",
            "% giá trị /Tổng tiền",
            "Phân bổ đều"});
            this.fld_cmbAllocationType.Size = new System.Drawing.Size(150, 20);
            this.fld_cmbAllocationType.TabIndex = 120;
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
            this.bosLabel11.Location = new System.Drawing.Point(464, 32);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(64, 13);
            this.bosLabel11.TabIndex = 119;
            this.bosLabel11.Text = "Phân bổ theo";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(199, 32);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(58, 13);
            this.bosLabel12.TabIndex = 117;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Tiền đề nghị";
            // 
            // fld_txtAPPaymentProposalTotalAmount
            // 
            this.fld_txtAPPaymentProposalTotalAmount.BOSComment = null;
            this.fld_txtAPPaymentProposalTotalAmount.BOSDataMember = "APPaymentProposalTotalAmount";
            this.fld_txtAPPaymentProposalTotalAmount.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalTotalAmount.BOSDescription = null;
            this.fld_txtAPPaymentProposalTotalAmount.BOSError = null;
            this.fld_txtAPPaymentProposalTotalAmount.BOSFieldGroup = null;
            this.fld_txtAPPaymentProposalTotalAmount.BOSFieldRelation = null;
            this.fld_txtAPPaymentProposalTotalAmount.BOSPrivilege = null;
            this.fld_txtAPPaymentProposalTotalAmount.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalTotalAmount.Location = new System.Drawing.Point(284, 29);
            this.fld_txtAPPaymentProposalTotalAmount.Name = "fld_txtAPPaymentProposalTotalAmount";
            this.fld_txtAPPaymentProposalTotalAmount.Screen = null;
            this.fld_txtAPPaymentProposalTotalAmount.Size = new System.Drawing.Size(160, 20);
            this.fld_txtAPPaymentProposalTotalAmount.TabIndex = 118;
            this.fld_txtAPPaymentProposalTotalAmount.Tag = "DC";
            // 
            // fld_btnAllocation
            // 
            this.fld_btnAllocation.BOSComment = null;
            this.fld_btnAllocation.BOSDataMember = null;
            this.fld_btnAllocation.BOSDataSource = null;
            this.fld_btnAllocation.BOSDescription = null;
            this.fld_btnAllocation.BOSError = null;
            this.fld_btnAllocation.BOSFieldGroup = null;
            this.fld_btnAllocation.BOSFieldRelation = null;
            this.fld_btnAllocation.BOSPrivilege = null;
            this.fld_btnAllocation.BOSPropertyName = null;
            this.fld_btnAllocation.Location = new System.Drawing.Point(733, 25);
            this.fld_btnAllocation.Name = "fld_btnAllocation";
            this.fld_btnAllocation.Screen = null;
            this.fld_btnAllocation.Size = new System.Drawing.Size(106, 27);
            this.fld_btnAllocation.TabIndex = 121;
            this.fld_btnAllocation.Text = "Phân bổ";
            this.fld_btnAllocation.Click += new System.EventHandler(this.fld_btnAllocation_Click);
            // 
            // fld_btnSelectPaymentTerm
            // 
            this.fld_btnSelectPaymentTerm.BOSComment = null;
            this.fld_btnSelectPaymentTerm.BOSDataMember = null;
            this.fld_btnSelectPaymentTerm.BOSDataSource = null;
            this.fld_btnSelectPaymentTerm.BOSDescription = null;
            this.fld_btnSelectPaymentTerm.BOSError = null;
            this.fld_btnSelectPaymentTerm.BOSFieldGroup = null;
            this.fld_btnSelectPaymentTerm.BOSFieldRelation = null;
            this.fld_btnSelectPaymentTerm.BOSPrivilege = null;
            this.fld_btnSelectPaymentTerm.BOSPropertyName = null;
            this.fld_btnSelectPaymentTerm.Location = new System.Drawing.Point(9, 25);
            this.fld_btnSelectPaymentTerm.Name = "fld_btnSelectPaymentTerm";
            this.fld_btnSelectPaymentTerm.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSelectPaymentTerm, true);
            this.fld_btnSelectPaymentTerm.Size = new System.Drawing.Size(142, 27);
            this.fld_btnSelectPaymentTerm.TabIndex = 116;
            this.fld_btnSelectPaymentTerm.Text = "Chọn đợt thanh toán";
            this.fld_btnSelectPaymentTerm.Click += new System.EventHandler(this.fld_btnSelectPaymentTerm_Click);
            // 
            // fld_dgcAPPaymentProposalItems
            // 
            this.fld_dgcAPPaymentProposalItems.AllowDrop = true;
            this.fld_dgcAPPaymentProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPaymentProposalItems.BOSComment = "";
            this.fld_dgcAPPaymentProposalItems.BOSDataMember = "";
            this.fld_dgcAPPaymentProposalItems.BOSDataSource = "APPaymentProposalItems";
            this.fld_dgcAPPaymentProposalItems.BOSDescription = null;
            this.fld_dgcAPPaymentProposalItems.BOSError = null;
            this.fld_dgcAPPaymentProposalItems.BOSFieldGroup = "";
            this.fld_dgcAPPaymentProposalItems.BOSFieldRelation = "";
            this.fld_dgcAPPaymentProposalItems.BOSGridType = null;
            this.fld_dgcAPPaymentProposalItems.BOSPrivilege = "";
            this.fld_dgcAPPaymentProposalItems.BOSPropertyName = "";
            this.fld_dgcAPPaymentProposalItems.CommodityType = "";
            this.fld_dgcAPPaymentProposalItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPaymentProposalItems.Location = new System.Drawing.Point(2, 57);
            this.fld_dgcAPPaymentProposalItems.MainView = this.gridView2;
            this.fld_dgcAPPaymentProposalItems.Name = "fld_dgcAPPaymentProposalItems";
            this.fld_dgcAPPaymentProposalItems.PrintReport = false;
            this.fld_dgcAPPaymentProposalItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcAPPaymentProposalItems, true);
            this.fld_dgcAPPaymentProposalItems.Size = new System.Drawing.Size(1388, 417);
            this.fld_dgcAPPaymentProposalItems.TabIndex = 115;
            this.fld_dgcAPPaymentProposalItems.Tag = "DC";
            this.fld_dgcAPPaymentProposalItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcAPPaymentProposalItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // DMPP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1399, 786);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPP100.IconOptions.Icon")));
            this.Name = "DMPP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPaymentProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalDocAttachCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalApproveDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalApproveDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalPriorityCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalPayDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentProposalPayDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalStatusCombo.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACListAccountBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalReceiverBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalObjectReceiptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalReceiverAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalReceiverBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPaymentProposalReceiptAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalTotalAmount1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalTotalPaymentAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbAllocationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButton fld_btnSelectPaymentTerm;
        private PaymentProposalItemsGridControl fld_dgcAPPaymentProposalItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentProposalPaymentMethodCombo;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalNo;
        private BOSComponent.BOSMemoEdit fld_medAPPaymentProposalDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentProposalPriorityCombo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentProposalDocAttachCombo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentProposalStatusCombo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteAPPaymentProposalDate;
        private BOSComponent.BOSDateEdit fld_dteAPPaymentProposalPayDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel8;
        private IContainer components;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteAPPaymentProposalApproveDate;
        private DevExpress.XtraEditors.ComboBoxEdit fld_cmbAllocationType;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalTotalAmount;
        private BOSComponent.BOSButton fld_btnAllocation;
        private DevExpress.XtraEditors.HyperlinkLabelControl fld_linkViewApproval;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACListAccountBankID;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalReceiverBankName;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalObjectReceiptName;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalReceiverAccount;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalReceiverBankCode;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSMemoEdit fld_medAPPaymentProposalReceiptAddress;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalProject;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalTotalAmount1;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalDiscountFix;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalDiscountPerCent;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalTotalPaymentAmount;
        private BOSComponent.BOSLabel fld_lblLabel47;
    }
}
