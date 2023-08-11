using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Proposal.UI
{
	/// <summary>
	/// Summary description for SMPS100
	/// </summary>
	partial class SMPS100
	{
		private BOSComponent.BOSTextBox fld_txtARProposalNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSSearchResultsGridControl fld_dgcARProposal;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARProposal;
		private BOSComponent.BOSLabel BOSLabel5;
		private BOSComponent.BOSLabel BOSLabel7;
		private BOSComponent.BOSLabel fld_lblLabel114;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARProposalDate;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARProposalDeliveryDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToARProposalDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToARProposalDeliveryDate;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARProposalValidateDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToARProposalValidateDate;
		private BOSComponent.BOSLabel BOSLabel6;
		private BOSComponent.BOSLabel fld_lblLabel94;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMPS100));
            this.fld_txtARProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcARProposal = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARProposal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARProposalDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARProposalDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARProposalValidateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARProposalValidateDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel94 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProposal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalValidateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalValidateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtARProposalNo
            // 
            this.fld_txtARProposalNo.BOSComment = "";
            this.fld_txtARProposalNo.BOSDataMember = "ARProposalNo";
            this.fld_txtARProposalNo.BOSDataSource = "ARProposals";
            this.fld_txtARProposalNo.BOSDescription = null;
            this.fld_txtARProposalNo.BOSError = null;
            this.fld_txtARProposalNo.BOSFieldGroup = "";
            this.fld_txtARProposalNo.BOSFieldRelation = "";
            this.fld_txtARProposalNo.BOSPrivilege = "";
            this.fld_txtARProposalNo.BOSPropertyName = null;
            this.fld_txtARProposalNo.EditValue = "";
            this.fld_txtARProposalNo.Location = new System.Drawing.Point(171, 6);
            this.fld_txtARProposalNo.Name = "fld_txtARProposalNo";
            this.fld_txtARProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProposalNo.Screen = null;
            this.fld_txtARProposalNo.Size = new System.Drawing.Size(126, 20);
            this.fld_txtARProposalNo.TabIndex = 88;
            this.fld_txtARProposalNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARProposals";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(171, 64);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 94;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // fld_dgcARProposal
            // 
            this.fld_dgcARProposal.AllowDrop = true;
            this.fld_dgcARProposal.BOSComment = "";
            this.fld_dgcARProposal.BOSDataMember = "";
            this.fld_dgcARProposal.BOSDataSource = "ARProposals";
            this.fld_dgcARProposal.BOSDescription = null;
            this.fld_dgcARProposal.BOSError = null;
            this.fld_dgcARProposal.BOSFieldGroup = "";
            this.fld_dgcARProposal.BOSFieldRelation = "";
            this.fld_dgcARProposal.BOSGridType = null;
            this.fld_dgcARProposal.BOSPrivilege = "";
            this.fld_dgcARProposal.BOSPropertyName = null;
            this.fld_dgcARProposal.CommodityType = "";
            this.fld_dgcARProposal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARProposal.Location = new System.Drawing.Point(43, 246);
            this.fld_dgcARProposal.MainView = this.fld_dgvARProposal;
            this.fld_dgcARProposal.Name = "fld_dgcARProposal";
            this.fld_dgcARProposal.PrintReport = false;
            this.fld_dgcARProposal.Screen = null;
            this.fld_dgcARProposal.Size = new System.Drawing.Size(423, 266);
            this.fld_dgcARProposal.TabIndex = 79;
            this.fld_dgcARProposal.Tag = "SR";
            this.fld_dgcARProposal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARProposal});
            // 
            // fld_dgvARProposal
            // 
            this.fld_dgvARProposal.GridControl = this.fld_dgcARProposal;
            this.fld_dgvARProposal.Name = "fld_dgvARProposal";
            this.fld_dgvARProposal.PaintStyleName = "Office2003";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel5.Appearance.Options.UseBackColor = true;
            this.BOSLabel5.Appearance.Options.UseForeColor = true;
            this.BOSLabel5.BOSComment = "";
            this.BOSLabel5.BOSDataMember = "";
            this.BOSLabel5.BOSDataSource = "";
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = "";
            this.BOSLabel5.BOSFieldRelation = "";
            this.BOSLabel5.BOSPrivilege = "";
            this.BOSLabel5.BOSPropertyName = null;
            this.BOSLabel5.Location = new System.Drawing.Point(329, 171);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel5.TabIndex = 102;
            this.BOSLabel5.Tag = "SI";
            this.BOSLabel5.Text = "Đến";
            // 
            // BOSLabel7
            // 
            this.BOSLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel7.Appearance.Options.UseBackColor = true;
            this.BOSLabel7.Appearance.Options.UseForeColor = true;
            this.BOSLabel7.BOSComment = "";
            this.BOSLabel7.BOSDataMember = "";
            this.BOSLabel7.BOSDataSource = "";
            this.BOSLabel7.BOSDescription = null;
            this.BOSLabel7.BOSError = null;
            this.BOSLabel7.BOSFieldGroup = "";
            this.BOSLabel7.BOSFieldRelation = "";
            this.BOSLabel7.BOSPrivilege = "";
            this.BOSLabel7.BOSPropertyName = null;
            this.BOSLabel7.Location = new System.Drawing.Point(329, 119);
            this.BOSLabel7.Name = "BOSLabel7";
            this.BOSLabel7.Screen = null;
            this.BOSLabel7.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel7.TabIndex = 100;
            this.BOSLabel7.Tag = "SI";
            this.BOSLabel7.Text = "Đến";
            // 
            // fld_lblLabel114
            // 
            this.fld_lblLabel114.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel114.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel114.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel114.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel114.BOSComment = "";
            this.fld_lblLabel114.BOSDataMember = "";
            this.fld_lblLabel114.BOSDataSource = "";
            this.fld_lblLabel114.BOSDescription = null;
            this.fld_lblLabel114.BOSError = null;
            this.fld_lblLabel114.BOSFieldGroup = "";
            this.fld_lblLabel114.BOSFieldRelation = "";
            this.fld_lblLabel114.BOSPrivilege = "";
            this.fld_lblLabel114.BOSPropertyName = null;
            this.fld_lblLabel114.Location = new System.Drawing.Point(329, 145);
            this.fld_lblLabel114.Name = "fld_lblLabel114";
            this.fld_lblLabel114.Screen = null;
            this.fld_lblLabel114.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel114.TabIndex = 100;
            this.fld_lblLabel114.Tag = "SI";
            this.fld_lblLabel114.Text = "Đến";
            // 
            // fld_dteSearchFromARProposalDate
            // 
            this.fld_dteSearchFromARProposalDate.BOSComment = "";
            this.fld_dteSearchFromARProposalDate.BOSDataMember = "ARProposalFromDate";
            this.fld_dteSearchFromARProposalDate.BOSDataSource = "ARProposals";
            this.fld_dteSearchFromARProposalDate.BOSDescription = null;
            this.fld_dteSearchFromARProposalDate.BOSError = null;
            this.fld_dteSearchFromARProposalDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARProposalDate.BOSFieldRelation = "";
            this.fld_dteSearchFromARProposalDate.BOSPrivilege = "";
            this.fld_dteSearchFromARProposalDate.BOSPropertyName = null;
            this.fld_dteSearchFromARProposalDate.EditValue = null;
            this.fld_dteSearchFromARProposalDate.Location = new System.Drawing.Point(170, 116);
            this.fld_dteSearchFromARProposalDate.Name = "fld_dteSearchFromARProposalDate";
            this.fld_dteSearchFromARProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARProposalDate.Screen = null;
            this.fld_dteSearchFromARProposalDate.Size = new System.Drawing.Size(126, 20);
            this.fld_dteSearchFromARProposalDate.TabIndex = 90;
            this.fld_dteSearchFromARProposalDate.Tag = "SC";
            // 
            // fld_dteSearchFromARProposalDeliveryDate
            // 
            this.fld_dteSearchFromARProposalDeliveryDate.BOSComment = "";
            this.fld_dteSearchFromARProposalDeliveryDate.BOSDataMember = "ARProposalDeliveryFromDate";
            this.fld_dteSearchFromARProposalDeliveryDate.BOSDataSource = "ARProposals";
            this.fld_dteSearchFromARProposalDeliveryDate.BOSDescription = null;
            this.fld_dteSearchFromARProposalDeliveryDate.BOSError = null;
            this.fld_dteSearchFromARProposalDeliveryDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARProposalDeliveryDate.BOSFieldRelation = "";
            this.fld_dteSearchFromARProposalDeliveryDate.BOSPrivilege = "";
            this.fld_dteSearchFromARProposalDeliveryDate.BOSPropertyName = null;
            this.fld_dteSearchFromARProposalDeliveryDate.EditValue = null;
            this.fld_dteSearchFromARProposalDeliveryDate.Location = new System.Drawing.Point(171, 142);
            this.fld_dteSearchFromARProposalDeliveryDate.Name = "fld_dteSearchFromARProposalDeliveryDate";
            this.fld_dteSearchFromARProposalDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARProposalDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARProposalDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARProposalDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARProposalDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARProposalDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARProposalDeliveryDate.Screen = null;
            this.fld_dteSearchFromARProposalDeliveryDate.Size = new System.Drawing.Size(126, 20);
            this.fld_dteSearchFromARProposalDeliveryDate.TabIndex = 90;
            this.fld_dteSearchFromARProposalDeliveryDate.Tag = "SC";
            // 
            // fld_dteSearchToARProposalDate
            // 
            this.fld_dteSearchToARProposalDate.BOSComment = "";
            this.fld_dteSearchToARProposalDate.BOSDataMember = "ARProposalToDate";
            this.fld_dteSearchToARProposalDate.BOSDataSource = "ARProposals";
            this.fld_dteSearchToARProposalDate.BOSDescription = null;
            this.fld_dteSearchToARProposalDate.BOSError = null;
            this.fld_dteSearchToARProposalDate.BOSFieldGroup = "";
            this.fld_dteSearchToARProposalDate.BOSFieldRelation = "";
            this.fld_dteSearchToARProposalDate.BOSPrivilege = "";
            this.fld_dteSearchToARProposalDate.BOSPropertyName = null;
            this.fld_dteSearchToARProposalDate.EditValue = null;
            this.fld_dteSearchToARProposalDate.Location = new System.Drawing.Point(365, 116);
            this.fld_dteSearchToARProposalDate.Name = "fld_dteSearchToARProposalDate";
            this.fld_dteSearchToARProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARProposalDate.Screen = null;
            this.fld_dteSearchToARProposalDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToARProposalDate.TabIndex = 91;
            this.fld_dteSearchToARProposalDate.Tag = "SC";
            // 
            // fld_dteSearchToARProposalDeliveryDate
            // 
            this.fld_dteSearchToARProposalDeliveryDate.BOSComment = "";
            this.fld_dteSearchToARProposalDeliveryDate.BOSDataMember = "ARProposalDeliveryToDate";
            this.fld_dteSearchToARProposalDeliveryDate.BOSDataSource = "ARProposals";
            this.fld_dteSearchToARProposalDeliveryDate.BOSDescription = null;
            this.fld_dteSearchToARProposalDeliveryDate.BOSError = null;
            this.fld_dteSearchToARProposalDeliveryDate.BOSFieldGroup = "";
            this.fld_dteSearchToARProposalDeliveryDate.BOSFieldRelation = "";
            this.fld_dteSearchToARProposalDeliveryDate.BOSPrivilege = "";
            this.fld_dteSearchToARProposalDeliveryDate.BOSPropertyName = null;
            this.fld_dteSearchToARProposalDeliveryDate.EditValue = null;
            this.fld_dteSearchToARProposalDeliveryDate.Location = new System.Drawing.Point(365, 142);
            this.fld_dteSearchToARProposalDeliveryDate.Name = "fld_dteSearchToARProposalDeliveryDate";
            this.fld_dteSearchToARProposalDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARProposalDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARProposalDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARProposalDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARProposalDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARProposalDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARProposalDeliveryDate.Screen = null;
            this.fld_dteSearchToARProposalDeliveryDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToARProposalDeliveryDate.TabIndex = 91;
            this.fld_dteSearchToARProposalDeliveryDate.Tag = "SC";
            // 
            // fld_dteSearchFromARProposalValidateDate
            // 
            this.fld_dteSearchFromARProposalValidateDate.BOSComment = "";
            this.fld_dteSearchFromARProposalValidateDate.BOSDataMember = "ARProposalValidateFromDate";
            this.fld_dteSearchFromARProposalValidateDate.BOSDataSource = "ARProposals";
            this.fld_dteSearchFromARProposalValidateDate.BOSDescription = null;
            this.fld_dteSearchFromARProposalValidateDate.BOSError = null;
            this.fld_dteSearchFromARProposalValidateDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARProposalValidateDate.BOSFieldRelation = "";
            this.fld_dteSearchFromARProposalValidateDate.BOSPrivilege = "";
            this.fld_dteSearchFromARProposalValidateDate.BOSPropertyName = null;
            this.fld_dteSearchFromARProposalValidateDate.EditValue = null;
            this.fld_dteSearchFromARProposalValidateDate.Location = new System.Drawing.Point(170, 168);
            this.fld_dteSearchFromARProposalValidateDate.Name = "fld_dteSearchFromARProposalValidateDate";
            this.fld_dteSearchFromARProposalValidateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARProposalValidateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARProposalValidateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARProposalValidateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARProposalValidateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARProposalValidateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARProposalValidateDate.Screen = null;
            this.fld_dteSearchFromARProposalValidateDate.Size = new System.Drawing.Size(126, 20);
            this.fld_dteSearchFromARProposalValidateDate.TabIndex = 92;
            this.fld_dteSearchFromARProposalValidateDate.Tag = "SC";
            // 
            // fld_dteSearchToARProposalValidateDate
            // 
            this.fld_dteSearchToARProposalValidateDate.BOSComment = "";
            this.fld_dteSearchToARProposalValidateDate.BOSDataMember = "ARProposalValidateToDate";
            this.fld_dteSearchToARProposalValidateDate.BOSDataSource = "ARProposals";
            this.fld_dteSearchToARProposalValidateDate.BOSDescription = null;
            this.fld_dteSearchToARProposalValidateDate.BOSError = null;
            this.fld_dteSearchToARProposalValidateDate.BOSFieldGroup = "";
            this.fld_dteSearchToARProposalValidateDate.BOSFieldRelation = "";
            this.fld_dteSearchToARProposalValidateDate.BOSPrivilege = "";
            this.fld_dteSearchToARProposalValidateDate.BOSPropertyName = null;
            this.fld_dteSearchToARProposalValidateDate.EditValue = null;
            this.fld_dteSearchToARProposalValidateDate.Location = new System.Drawing.Point(365, 168);
            this.fld_dteSearchToARProposalValidateDate.Name = "fld_dteSearchToARProposalValidateDate";
            this.fld_dteSearchToARProposalValidateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARProposalValidateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARProposalValidateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARProposalValidateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARProposalValidateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARProposalValidateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARProposalValidateDate.Screen = null;
            this.fld_dteSearchToARProposalValidateDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToARProposalValidateDate.TabIndex = 93;
            this.fld_dteSearchToARProposalValidateDate.Tag = "SC";
            // 
            // BOSLabel6
            // 
            this.BOSLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel6.Appearance.Options.UseBackColor = true;
            this.BOSLabel6.Appearance.Options.UseForeColor = true;
            this.BOSLabel6.BOSComment = "";
            this.BOSLabel6.BOSDataMember = "";
            this.BOSLabel6.BOSDataSource = "";
            this.BOSLabel6.BOSDescription = null;
            this.BOSLabel6.BOSError = null;
            this.BOSLabel6.BOSFieldGroup = "";
            this.BOSLabel6.BOSFieldRelation = "";
            this.BOSLabel6.BOSPrivilege = "";
            this.BOSLabel6.BOSPropertyName = null;
            this.BOSLabel6.Location = new System.Drawing.Point(40, 119);
            this.BOSLabel6.Name = "BOSLabel6";
            this.BOSLabel6.Screen = null;
            this.BOSLabel6.Size = new System.Drawing.Size(58, 13);
            this.BOSLabel6.TabIndex = 97;
            this.BOSLabel6.Tag = "SI";
            this.BOSLabel6.Text = "Ngày tạo từ";
            // 
            // fld_lblLabel94
            // 
            this.fld_lblLabel94.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel94.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel94.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel94.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel94.BOSComment = "";
            this.fld_lblLabel94.BOSDataMember = "";
            this.fld_lblLabel94.BOSDataSource = "";
            this.fld_lblLabel94.BOSDescription = null;
            this.fld_lblLabel94.BOSError = null;
            this.fld_lblLabel94.BOSFieldGroup = "";
            this.fld_lblLabel94.BOSFieldRelation = "";
            this.fld_lblLabel94.BOSPrivilege = "";
            this.fld_lblLabel94.BOSPropertyName = null;
            this.fld_lblLabel94.Location = new System.Drawing.Point(41, 145);
            this.fld_lblLabel94.Name = "fld_lblLabel94";
            this.fld_lblLabel94.Screen = null;
            this.fld_lblLabel94.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel94.TabIndex = 97;
            this.fld_lblLabel94.Tag = "SI";
            this.fld_lblLabel94.Text = "Ngày giao";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(41, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel.TabIndex = 103;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã báo giá";
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
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(41, 40);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel1.TabIndex = 104;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Đối tượng";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(41, 68);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 105;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(40, 171);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(79, 13);
            this.fld_lblLabel3.TabIndex = 106;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Ngày hết hạn từ";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARProposals";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(171, 33);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 107;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARProposals";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(171, 90);
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
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(126, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 109;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(41, 93);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 108;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARProposalItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = "";
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "EditValue";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(170, 194);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(320, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 437;
            this.fld_lkeFK_ICProductID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 197);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 436;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Sản phẩm";
            // 
            // SMPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(876, 574);
            this.Controls.Add(this.fld_lkeFK_ICProductID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_txtARProposalNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_dgcARProposal);
            this.Controls.Add(this.BOSLabel5);
            this.Controls.Add(this.BOSLabel7);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_dteSearchFromARProposalDate);
            this.Controls.Add(this.fld_dteSearchFromARProposalDeliveryDate);
            this.Controls.Add(this.fld_dteSearchToARProposalDate);
            this.Controls.Add(this.fld_dteSearchToARProposalDeliveryDate);
            this.Controls.Add(this.fld_dteSearchFromARProposalValidateDate);
            this.Controls.Add(this.fld_dteSearchToARProposalValidateDate);
            this.Controls.Add(this.BOSLabel6);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMPS100.IconOptions.Icon")));
            this.Name = "SMPS100";
            this.Text = "Search";
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel94, 0);
            this.Controls.SetChildIndex(this.BOSLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARProposalValidateDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARProposalValidateDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARProposalDeliveryDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARProposalDeliveryDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel114, 0);
            this.Controls.SetChildIndex(this.BOSLabel7, 0);
            this.Controls.SetChildIndex(this.BOSLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dgcARProposal, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_txtARProposalNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProposal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalValidateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProposalValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalValidateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProposalValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel1;
    }
}
