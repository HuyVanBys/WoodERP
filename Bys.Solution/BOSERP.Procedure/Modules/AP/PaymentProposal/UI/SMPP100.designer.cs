using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentProposal.UI
{
	/// <summary>
	/// Summary description for SMPP100
	/// </summary>
	partial class SMPP100
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
            this.fld_dgcAPPaymentProposals = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToPaymentProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromPaymentProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPPaymentProposalPriorityCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPAdvanceProposalStatsusCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPPaymentProposalTypeCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPPaymentProposalNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToPaymentProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToPaymentProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromPaymentProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromPaymentProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalPriorityCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalTypeCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAPPaymentProposals
            // 
            this.fld_dgcAPPaymentProposals.BOSComment = null;
            this.fld_dgcAPPaymentProposals.BOSDataMember = null;
            this.fld_dgcAPPaymentProposals.BOSDataSource = "APPaymentProposals";
            this.fld_dgcAPPaymentProposals.BOSDescription = null;
            this.fld_dgcAPPaymentProposals.BOSError = null;
            this.fld_dgcAPPaymentProposals.BOSFieldGroup = null;
            this.fld_dgcAPPaymentProposals.BOSFieldRelation = null;
            this.fld_dgcAPPaymentProposals.BOSPrivilege = null;
            this.fld_dgcAPPaymentProposals.BOSPropertyName = null;
            this.fld_dgcAPPaymentProposals.Location = new System.Drawing.Point(129, 252);
            this.fld_dgcAPPaymentProposals.MenuManager = this.screenToolbar;
            this.fld_dgcAPPaymentProposals.Name = "fld_dgcAPPaymentProposals";
            this.fld_dgcAPPaymentProposals.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcAPPaymentProposals, true);
            this.fld_dgcAPPaymentProposals.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPPaymentProposals.TabIndex = 177;
            this.fld_dgcAPPaymentProposals.Tag = "SR";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 139);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(48, 13);
            this.bosLabel7.TabIndex = 176;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Đối tượng";
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
            this.bosLabel5.Location = new System.Drawing.Point(310, 217);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(47, 13);
            this.bosLabel5.TabIndex = 174;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Đến ngày";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 217);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 173;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Từ ngày";
            // 
            // fld_dteSearchToPaymentProposalDate
            // 
            this.fld_dteSearchToPaymentProposalDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToPaymentProposalDate.BOSDataMember = "PaymentProposalDateTo";
            this.fld_dteSearchToPaymentProposalDate.BOSDataSource = "APPaymentProposals";
            this.fld_dteSearchToPaymentProposalDate.BOSDescription = null;
            this.fld_dteSearchToPaymentProposalDate.BOSError = null;
            this.fld_dteSearchToPaymentProposalDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToPaymentProposalDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToPaymentProposalDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchToPaymentProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToPaymentProposalDate.EditValue = null;
            this.fld_dteSearchToPaymentProposalDate.Location = new System.Drawing.Point(379, 214);
            this.fld_dteSearchToPaymentProposalDate.Name = "fld_dteSearchToPaymentProposalDate";
            this.fld_dteSearchToPaymentProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToPaymentProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToPaymentProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToPaymentProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToPaymentProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToPaymentProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToPaymentProposalDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToPaymentProposalDate, true);
            this.fld_dteSearchToPaymentProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToPaymentProposalDate.TabIndex = 9;
            this.fld_dteSearchToPaymentProposalDate.Tag = "SC";
            // 
            // fld_dteSearchFromPaymentProposalDate
            // 
            this.fld_dteSearchFromPaymentProposalDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromPaymentProposalDate.BOSDataMember = "PaymentProposalDateFrom";
            this.fld_dteSearchFromPaymentProposalDate.BOSDataSource = "APPaymentProposals";
            this.fld_dteSearchFromPaymentProposalDate.BOSDescription = null;
            this.fld_dteSearchFromPaymentProposalDate.BOSError = null;
            this.fld_dteSearchFromPaymentProposalDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromPaymentProposalDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromPaymentProposalDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteSearchFromPaymentProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromPaymentProposalDate.EditValue = null;
            this.fld_dteSearchFromPaymentProposalDate.Location = new System.Drawing.Point(138, 214);
            this.fld_dteSearchFromPaymentProposalDate.Name = "fld_dteSearchFromPaymentProposalDate";
            this.fld_dteSearchFromPaymentProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromPaymentProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromPaymentProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromPaymentProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromPaymentProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromPaymentProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromPaymentProposalDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromPaymentProposalDate, true);
            this.fld_dteSearchFromPaymentProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromPaymentProposalDate.TabIndex = 8;
            this.fld_dteSearchFromPaymentProposalDate.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(138, 33);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID1, true);
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // fld_lkeAPPaymentProposalPriorityCombo1
            // 
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSAllowDummy = false;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSDataMember = "APPriority";
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSDescription = null;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSError = null;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.CurrentDisplayText = null;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Location = new System.Drawing.Point(138, 188);
            this.fld_lkeAPPaymentProposalPriorityCombo1.Name = "fld_lkeAPPaymentProposalPriorityCombo1";
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.PopupWidth = 40;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentProposalPriorityCombo1, true);
            this.fld_lkeAPPaymentProposalPriorityCombo1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentProposalPriorityCombo1.TabIndex = 7;
            this.fld_lkeAPPaymentProposalPriorityCombo1.Tag = "SC";
            // 
            // fld_lkeAPAdvanceProposalStatsusCombo1
            // 
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSAllowAddNew = false;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSAllowDummy = false;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSDataMember = "APPaymentProposalStatusCombo";
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSDescription = null;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSError = null;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.CurrentDisplayText = null;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Location = new System.Drawing.Point(138, 163);
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Name = "fld_lkeAPAdvanceProposalStatsusCombo1";
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.PopupWidth = 40;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPAdvanceProposalStatsusCombo1, true);
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPAdvanceProposalStatsusCombo1.TabIndex = 6;
            this.fld_lkeAPAdvanceProposalStatsusCombo1.Tag = "SC";
            // 
            // fld_lkeFK_HRDepartmentID1
            // 
            this.fld_lkeFK_HRDepartmentID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID1.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentID1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID1.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_HRDepartmentID1.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID1.BOSError = null;
            this.fld_lkeFK_HRDepartmentID1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID1.Location = new System.Drawing.Point(138, 84);
            this.fld_lkeFK_HRDepartmentID1.Name = "fld_lkeFK_HRDepartmentID1";
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Name")});
            this.fld_lkeFK_HRDepartmentID1.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HRDepartmentID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID1.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID1, true);
            this.fld_lkeFK_HRDepartmentID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID1.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentID1.Tag = "SC";
            // 
            // fld_lkeAPPaymentProposalTypeCombo1
            // 
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSAllowDummy = false;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSDataMember = "APPaymentProposalTypeCombo";
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSDataSource = "APPaymentProposals";
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSDescription = null;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSError = null;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.CurrentDisplayText = null;
            this.fld_lkeAPPaymentProposalTypeCombo1.Location = new System.Drawing.Point(138, 59);
            this.fld_lkeAPPaymentProposalTypeCombo1.Name = "fld_lkeAPPaymentProposalTypeCombo1";
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.PopupWidth = 40;
            this.fld_lkeAPPaymentProposalTypeCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentProposalTypeCombo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentProposalTypeCombo1, true);
            this.fld_lkeAPPaymentProposalTypeCombo1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentProposalTypeCombo1.TabIndex = 2;
            this.fld_lkeAPPaymentProposalTypeCombo1.Tag = "SC";
            // 
            // fld_txtAPPaymentProposalNo1
            // 
            this.fld_txtAPPaymentProposalNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPPaymentProposalNo1.BOSDataMember = "APPaymentProposalNo";
            this.fld_txtAPPaymentProposalNo1.BOSDataSource = "APPaymentProposals";
            this.fld_txtAPPaymentProposalNo1.BOSDescription = null;
            this.fld_txtAPPaymentProposalNo1.BOSError = null;
            this.fld_txtAPPaymentProposalNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPPaymentProposalNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPPaymentProposalNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPPaymentProposalNo1.BOSPropertyName = "Text";
            this.fld_txtAPPaymentProposalNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtAPPaymentProposalNo1.Location = new System.Drawing.Point(138, 9);
            this.fld_txtAPPaymentProposalNo1.Name = "fld_txtAPPaymentProposalNo1";
            this.fld_txtAPPaymentProposalNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentProposalNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentProposalNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentProposalNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentProposalNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentProposalNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentProposalNo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPPaymentProposalNo1, true);
            this.fld_txtAPPaymentProposalNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentProposalNo1.TabIndex = 0;
            this.fld_txtAPPaymentProposalNo1.Tag = "SC";
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
            this.bosLabel9.Location = new System.Drawing.Point(12, 87);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(39, 13);
            this.bosLabel9.TabIndex = 164;
            this.bosLabel9.Tag = "SI";
            this.bosLabel9.Text = "Bộ phận";
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 191);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(51, 13);
            this.bosLabel6.TabIndex = 163;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Độ ưu tiên";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 37);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 162;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Người ĐN";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 166);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 161;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Tình trạng";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 62);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(37, 13);
            this.bosLabel2.TabIndex = 160;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Loại ĐN";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 159;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã đề nghị";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(138, 136);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 5;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APPaymentProposals";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(138, 110);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.Location = new System.Drawing.Point(12, 113);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(48, 13);
            this.bosLabel10.TabIndex = 178;
            this.bosLabel10.Tag = "SI";
            this.bosLabel10.Text = "Chi nhánh";
            // 
            // SMPP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_dgcAPPaymentProposals);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteSearchToPaymentProposalDate);
            this.Controls.Add(this.fld_dteSearchFromPaymentProposalDate);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lkeAPPaymentProposalPriorityCombo1);
            this.Controls.Add(this.fld_lkeAPAdvanceProposalStatsusCombo1);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentID1);
            this.Controls.Add(this.fld_lkeAPPaymentProposalTypeCombo1);
            this.Controls.Add(this.fld_txtAPPaymentProposalNo1);
            this.Controls.Add(this.bosLabel9);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Name = "SMPP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel9, 0);
            this.Controls.SetChildIndex(this.fld_txtAPPaymentProposalNo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeAPPaymentProposalTypeCombo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeAPAdvanceProposalStatsusCombo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeAPPaymentProposalPriorityCombo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromPaymentProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToPaymentProposalDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPPaymentProposals, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToPaymentProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToPaymentProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromPaymentProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromPaymentProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalPriorityCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPAdvanceProposalStatsusCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentProposalTypeCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentProposalNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcAPPaymentProposals;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteSearchToPaymentProposalDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromPaymentProposalDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentProposalPriorityCombo1;
        private BOSComponent.BOSLookupEdit fld_lkeAPAdvanceProposalStatsusCombo1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID1;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentProposalTypeCombo1;
        private BOSComponent.BOSTextBox fld_txtAPPaymentProposalNo1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel10;
	}
}
