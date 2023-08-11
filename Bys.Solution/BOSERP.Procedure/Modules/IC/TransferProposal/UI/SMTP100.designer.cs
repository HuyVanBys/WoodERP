using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.TransferProposal.UI
{
	/// <summary>
	/// Summary description for SMTP100
	/// </summary>
	partial class SMTP100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtICTransferProposalNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
		private BOSSearchResultsGridControl fld_dgcAPCancelPurchaseProposals;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPCancelPurchaseProposals;


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
            this.fld_txtICTransferProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAPCancelPurchaseProposals = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPCancelPurchaseProposals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromAPCancelPurchaseProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToAPCancelPurchaseProposalDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPCancelPurchaseProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPCancelPurchaseProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPCancelPurchaseProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPCancelPurchaseProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPCancelPurchaseProposalDate.Properties)).BeginInit();
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
            // fld_txtICTransferProposalNo
            // 
            this.fld_txtICTransferProposalNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferProposalNo.BOSDataMember = "ICTransferProposalNo";
            this.fld_txtICTransferProposalNo.BOSDataSource = "ICTransferProposals";
            this.fld_txtICTransferProposalNo.BOSDescription = null;
            this.fld_txtICTransferProposalNo.BOSError = null;
            this.fld_txtICTransferProposalNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferProposalNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferProposalNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferProposalNo.BOSPropertyName = "Text";
            this.fld_txtICTransferProposalNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferProposalNo.Location = new System.Drawing.Point(108, 32);
            this.fld_txtICTransferProposalNo.Name = "fld_txtICTransferProposalNo";
            this.fld_txtICTransferProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTransferProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTransferProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTransferProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTransferProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTransferProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTransferProposalNo.Screen = null;
            this.fld_txtICTransferProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferProposalNo.TabIndex = 0;
            this.fld_txtICTransferProposalNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICTransferProposals";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(108, 58);
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
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "ICTransferProposals";
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
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(108, 82);
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
            // fld_dgcAPCancelPurchaseProposals
            // 
            this.fld_dgcAPCancelPurchaseProposals.AllowDrop = true;
            this.fld_dgcAPCancelPurchaseProposals.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPCancelPurchaseProposals.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPCancelPurchaseProposals.BOSDataSource = "ICTransferProposals";
            this.fld_dgcAPCancelPurchaseProposals.BOSDescription = null;
            this.fld_dgcAPCancelPurchaseProposals.BOSError = null;
            this.fld_dgcAPCancelPurchaseProposals.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPCancelPurchaseProposals.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPCancelPurchaseProposals.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPCancelPurchaseProposals.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPCancelPurchaseProposals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPCancelPurchaseProposals.Location = new System.Drawing.Point(5, 157);
            this.fld_dgcAPCancelPurchaseProposals.MainView = this.fld_dgvAPCancelPurchaseProposals;
            this.fld_dgcAPCancelPurchaseProposals.Name = "fld_dgcAPCancelPurchaseProposals";
            this.fld_dgcAPCancelPurchaseProposals.Screen = null;
            this.fld_dgcAPCancelPurchaseProposals.Size = new System.Drawing.Size(853, 407);
            this.fld_dgcAPCancelPurchaseProposals.TabIndex = 8;
            this.fld_dgcAPCancelPurchaseProposals.Tag = "SR";
            this.fld_dgcAPCancelPurchaseProposals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPCancelPurchaseProposals});
            // 
            // fld_dgvAPCancelPurchaseProposals
            // 
            this.fld_dgvAPCancelPurchaseProposals.GridControl = this.fld_dgcAPCancelPurchaseProposals;
            this.fld_dgvAPCancelPurchaseProposals.Name = "fld_dgvAPCancelPurchaseProposals";
            this.fld_dgvAPCancelPurchaseProposals.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Location = new System.Drawing.Point(35, 111);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_dteSearchFromAPCancelPurchaseProposalDate
            // 
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSComment = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSDataMember = "ICTransferProposalDateFrom";
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSDataSource = "ICTransferProposals";
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSDescription = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSError = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.EditValue = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Location = new System.Drawing.Point(108, 108);
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Name = "fld_dteSearchFromAPCancelPurchaseProposalDate";
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Screen = null;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.TabIndex = 3;
            this.fld_dteSearchFromAPCancelPurchaseProposalDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(284, 111);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteSearchToAPCancelPurchaseProposalDate
            // 
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSComment = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSDataMember = "ICTransferProposalDateTo";
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSDataSource = "ICTransferProposals";
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSDescription = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSError = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSPrivilege = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPCancelPurchaseProposalDate.EditValue = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Location = new System.Drawing.Point(337, 108);
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Name = "fld_dteSearchToAPCancelPurchaseProposalDate";
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Screen = null;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPCancelPurchaseProposalDate.TabIndex = 4;
            this.fld_dteSearchToAPCancelPurchaseProposalDate.Tag = "SC";
            // 
            // SMTP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dteSearchToAPCancelPurchaseProposalDate);
            this.Controls.Add(this.fld_dteSearchFromAPCancelPurchaseProposalDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtICTransferProposalNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_dgcAPCancelPurchaseProposals);
            this.Name = "SMTP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcAPCancelPurchaseProposals, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtICTransferProposalNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPCancelPurchaseProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPCancelPurchaseProposalDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPCancelPurchaseProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPCancelPurchaseProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPCancelPurchaseProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPCancelPurchaseProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPCancelPurchaseProposalDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPCancelPurchaseProposalDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPCancelPurchaseProposalDate;
	}
}
