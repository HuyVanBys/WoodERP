using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ShipmentProposal.UI
{
	/// <summary>
	/// Summary description for SMSP100
	/// </summary>
	partial class SMSP100
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
            this.fld_lkeFK_ARInvoiceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToICShipmentProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromICShipmentProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcICShipmentProposals = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICShipmentProposalItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARInvoiceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICShipmentProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICShipmentProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICShipmentProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICShipmentProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentProposalItem)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_ARInvoiceID
            // 
            this.fld_lkeFK_ARInvoiceID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARInvoiceID.BOSAllowDummy = false;
            this.fld_lkeFK_ARInvoiceID.BOSComment = null;
            this.fld_lkeFK_ARInvoiceID.BOSDataMember = "ICShipmentProposalReference";
            this.fld_lkeFK_ARInvoiceID.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeFK_ARInvoiceID.BOSDescription = null;
            this.fld_lkeFK_ARInvoiceID.BOSError = null;
            this.fld_lkeFK_ARInvoiceID.BOSFieldGroup = null;
            this.fld_lkeFK_ARInvoiceID.BOSFieldParent = null;
            this.fld_lkeFK_ARInvoiceID.BOSFieldRelation = null;
            this.fld_lkeFK_ARInvoiceID.BOSPrivilege = null;
            this.fld_lkeFK_ARInvoiceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARInvoiceID.BOSSelectType = null;
            this.fld_lkeFK_ARInvoiceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARInvoiceID.CurrentDisplayText = null;
            this.fld_lkeFK_ARInvoiceID.Location = new System.Drawing.Point(114, 74);
            this.fld_lkeFK_ARInvoiceID.Name = "fld_lkeFK_ARInvoiceID";
            this.fld_lkeFK_ARInvoiceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARInvoiceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductDesc", "Mô tả")});
            this.fld_lkeFK_ARInvoiceID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_ARInvoiceID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ARInvoiceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARInvoiceID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_ARInvoiceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARInvoiceID, true);
            this.fld_lkeFK_ARInvoiceID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARInvoiceID.TabIndex = 39;
            this.fld_lkeFK_ARInvoiceID.Tag = "SC";
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
            this.bosLabel8.Location = new System.Drawing.Point(38, 77);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(73, 13);
            this.bosLabel8.TabIndex = 40;
            this.bosLabel8.Text = "SO (SaleOrder)";
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
            this.bosLabel3.Location = new System.Drawing.Point(38, 23);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 36;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Mã chứng từ";
            // 
            // fld_dteSearchToICShipmentProposalDate
            // 
            this.fld_dteSearchToICShipmentProposalDate.BOSComment = null;
            this.fld_dteSearchToICShipmentProposalDate.BOSDataMember = "ICShipmentProposalToDate";
            this.fld_dteSearchToICShipmentProposalDate.BOSDataSource = "ICShipmentProposals";
            this.fld_dteSearchToICShipmentProposalDate.BOSDescription = null;
            this.fld_dteSearchToICShipmentProposalDate.BOSError = null;
            this.fld_dteSearchToICShipmentProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchToICShipmentProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchToICShipmentProposalDate.BOSPrivilege = null;
            this.fld_dteSearchToICShipmentProposalDate.BOSPropertyName = null;
            this.fld_dteSearchToICShipmentProposalDate.EditValue = null;
            this.fld_dteSearchToICShipmentProposalDate.Location = new System.Drawing.Point(330, 100);
            this.fld_dteSearchToICShipmentProposalDate.Name = "fld_dteSearchToICShipmentProposalDate";
            this.fld_dteSearchToICShipmentProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICShipmentProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICShipmentProposalDate.Screen = null;
            this.fld_dteSearchToICShipmentProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToICShipmentProposalDate.TabIndex = 31;
            this.fld_dteSearchToICShipmentProposalDate.Tag = "SC";
            // 
            // fld_dteSearchFromICShipmentProposalDate
            // 
            this.fld_dteSearchFromICShipmentProposalDate.BOSComment = null;
            this.fld_dteSearchFromICShipmentProposalDate.BOSDataMember = "ICShipmentProposalFromDate";
            this.fld_dteSearchFromICShipmentProposalDate.BOSDataSource = "ICShipmentProposals";
            this.fld_dteSearchFromICShipmentProposalDate.BOSDescription = null;
            this.fld_dteSearchFromICShipmentProposalDate.BOSError = null;
            this.fld_dteSearchFromICShipmentProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchFromICShipmentProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICShipmentProposalDate.BOSPrivilege = null;
            this.fld_dteSearchFromICShipmentProposalDate.BOSPropertyName = null;
            this.fld_dteSearchFromICShipmentProposalDate.EditValue = null;
            this.fld_dteSearchFromICShipmentProposalDate.Location = new System.Drawing.Point(114, 100);
            this.fld_dteSearchFromICShipmentProposalDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromICShipmentProposalDate.Name = "fld_dteSearchFromICShipmentProposalDate";
            this.fld_dteSearchFromICShipmentProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICShipmentProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICShipmentProposalDate.Screen = null;
            this.fld_dteSearchFromICShipmentProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromICShipmentProposalDate.TabIndex = 30;
            this.fld_dteSearchFromICShipmentProposalDate.Tag = "SC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.Location = new System.Drawing.Point(38, 49);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 32;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.Location = new System.Drawing.Point(287, 103);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 34;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.Location = new System.Drawing.Point(38, 103);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 33;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_txtICShipmentProposalNo
            // 
            this.fld_txtICShipmentProposalNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICShipmentProposalNo.BOSDataMember = "ICShipmentProposalNo";
            this.fld_txtICShipmentProposalNo.BOSDataSource = "ICShipmentProposals";
            this.fld_txtICShipmentProposalNo.BOSDescription = null;
            this.fld_txtICShipmentProposalNo.BOSError = null;
            this.fld_txtICShipmentProposalNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICShipmentProposalNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICShipmentProposalNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICShipmentProposalNo.BOSPropertyName = "Text";
            this.fld_txtICShipmentProposalNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICShipmentProposalNo.Location = new System.Drawing.Point(114, 20);
            this.fld_txtICShipmentProposalNo.Name = "fld_txtICShipmentProposalNo";
            this.fld_txtICShipmentProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentProposalNo.Screen = null;
            this.fld_txtICShipmentProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentProposalNo.TabIndex = 28;
            this.fld_txtICShipmentProposalNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(114, 46);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 29;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dgcICShipmentProposals
            // 
            this.fld_dgcICShipmentProposals.AllowDrop = true;
            this.fld_dgcICShipmentProposals.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICShipmentProposals.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICShipmentProposals.BOSDataSource = "ICShipmentProposals";
            this.fld_dgcICShipmentProposals.BOSDescription = null;
            this.fld_dgcICShipmentProposals.BOSError = null;
            this.fld_dgcICShipmentProposals.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICShipmentProposals.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICShipmentProposals.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICShipmentProposals.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICShipmentProposals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICShipmentProposals.Location = new System.Drawing.Point(24, 136);
            this.fld_dgcICShipmentProposals.MainView = this.fld_dgvICShipmentProposalItem;
            this.fld_dgcICShipmentProposals.Name = "fld_dgcICShipmentProposals";
            this.fld_dgcICShipmentProposals.Screen = null;
            this.fld_dgcICShipmentProposals.Size = new System.Drawing.Size(456, 303);
            this.fld_dgcICShipmentProposals.TabIndex = 35;
            this.fld_dgcICShipmentProposals.Tag = "SR";
            this.fld_dgcICShipmentProposals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentProposalItem});
            // 
            // fld_dgvICShipmentProposalItem
            // 
            this.fld_dgvICShipmentProposalItem.GridControl = this.fld_dgcICShipmentProposals;
            this.fld_dgvICShipmentProposalItem.Name = "fld_dgvICShipmentProposalItem";
            this.fld_dgvICShipmentProposalItem.PaintStyleName = "Office2003";
            // 
            // SMSP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(550, 466);
            this.Controls.Add(this.fld_lkeFK_ARInvoiceID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteSearchToICShipmentProposalDate);
            this.Controls.Add(this.fld_dteSearchFromICShipmentProposalDate);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtICShipmentProposalNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dgcICShipmentProposals);
            this.Name = "SMSP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcICShipmentProposals, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtICShipmentProposalNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICShipmentProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICShipmentProposalDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARInvoiceID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARInvoiceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICShipmentProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICShipmentProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICShipmentProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICShipmentProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentProposalItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLookupEdit fld_lkeFK_ARInvoiceID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteSearchToICShipmentProposalDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromICShipmentProposalDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICShipmentProposalNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSSearchResultsGridControl fld_dgcICShipmentProposals;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentProposalItem;
        private IContainer components;
	}
}
