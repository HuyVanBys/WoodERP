using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseProposal.UI
{
	/// <summary>
	/// Summary description for SMPCPS100
	/// </summary>
	partial class SMPCPS100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtAPProposalNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
		private BOSSearchResultsGridControl fld_dgcAPProposal;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPProposalItem;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAPProposal = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPProposalItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromAPProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToAPProposalDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPProposalItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPProposalDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(35, 35);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(35, 61);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(35, 85);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Chi nhánh";
            // 
            // fld_txtAPProposalNo
            // 
            this.fld_txtAPProposalNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPProposalNo.BOSDataMember = "APProposalNo";
            this.fld_txtAPProposalNo.BOSDataSource = "APProposals";
            this.fld_txtAPProposalNo.BOSDescription = null;
            this.fld_txtAPProposalNo.BOSError = null;
            this.fld_txtAPProposalNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPProposalNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPProposalNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPProposalNo.BOSPropertyName = "Text";
            this.fld_txtAPProposalNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPProposalNo.Location = new System.Drawing.Point(148, 32);
            this.fld_txtAPProposalNo.Name = "fld_txtAPProposalNo";
            this.fld_txtAPProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPProposalNo.Screen = null;
            this.fld_txtAPProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPProposalNo.TabIndex = 0;
            this.fld_txtAPProposalNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APProposals";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(148, 58);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "APProposals";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(148, 82);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Name")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 2;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // fld_dgcAPProposal
            // 
            this.fld_dgcAPProposal.AllowDrop = true;
            this.fld_dgcAPProposal.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPProposal.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPProposal.BOSDataSource = "APProposals";
            this.fld_dgcAPProposal.BOSDescription = null;
            this.fld_dgcAPProposal.BOSError = null;
            this.fld_dgcAPProposal.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPProposal.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPProposal.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPProposal.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPProposal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPProposal.Location = new System.Drawing.Point(223, 182);
            this.fld_dgcAPProposal.MainView = this.fld_dgvAPProposalItem;
            this.fld_dgcAPProposal.Name = "fld_dgcAPProposal";
            this.fld_dgcAPProposal.Screen = null;
            this.fld_dgcAPProposal.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPProposal.TabIndex = 8;
            this.fld_dgcAPProposal.Tag = "SR";
            this.fld_dgcAPProposal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPProposalItem});
            // 
            // fld_dgvAPProposalItem
            // 
            this.fld_dgvAPProposalItem.GridControl = this.fld_dgcAPProposal;
            this.fld_dgvAPProposalItem.Name = "fld_dgvAPProposalItem";
            this.fld_dgvAPProposalItem.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(35, 111);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(86, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Ngày chứng từ từ";
            // 
            // fld_dteSearchFromAPProposalDate
            // 
            this.fld_dteSearchFromAPProposalDate.BOSComment = null;
            this.fld_dteSearchFromAPProposalDate.BOSDataMember = "ProposalDateFrom";
            this.fld_dteSearchFromAPProposalDate.BOSDataSource = "APProposals";
            this.fld_dteSearchFromAPProposalDate.BOSDescription = null;
            this.fld_dteSearchFromAPProposalDate.BOSError = null;
            this.fld_dteSearchFromAPProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPProposalDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPProposalDate.EditValue = null;
            this.fld_dteSearchFromAPProposalDate.Location = new System.Drawing.Point(148, 108);
            this.fld_dteSearchFromAPProposalDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromAPProposalDate.Name = "fld_dteSearchFromAPProposalDate";
            this.fld_dteSearchFromAPProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPProposalDate.Screen = null;
            this.fld_dteSearchFromAPProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPProposalDate.TabIndex = 3;
            this.fld_dteSearchFromAPProposalDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(320, 111);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
            // 
            // fld_dteSearchToAPProposalDate
            // 
            this.fld_dteSearchToAPProposalDate.BOSComment = null;
            this.fld_dteSearchToAPProposalDate.BOSDataMember = "ProposalDateTo";
            this.fld_dteSearchToAPProposalDate.BOSDataSource = "APProposals";
            this.fld_dteSearchToAPProposalDate.BOSDescription = null;
            this.fld_dteSearchToAPProposalDate.BOSError = null;
            this.fld_dteSearchToAPProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPProposalDate.BOSPrivilege = null;
            this.fld_dteSearchToAPProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPProposalDate.EditValue = null;
            this.fld_dteSearchToAPProposalDate.Location = new System.Drawing.Point(363, 108);
            this.fld_dteSearchToAPProposalDate.Name = "fld_dteSearchToAPProposalDate";
            this.fld_dteSearchToAPProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPProposalDate.Screen = null;
            this.fld_dteSearchToAPProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPProposalDate.TabIndex = 4;
            this.fld_dteSearchToAPProposalDate.Tag = "SC";
            // 
            // SMPCPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dteSearchToAPProposalDate);
            this.Controls.Add(this.fld_dteSearchFromAPProposalDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtAPProposalNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_dgcAPProposal);
            this.Name = "SMPCPS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcAPProposal, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtAPProposalNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPProposalDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPProposalItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPProposalDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPProposalDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPProposalDate;
	}
}
