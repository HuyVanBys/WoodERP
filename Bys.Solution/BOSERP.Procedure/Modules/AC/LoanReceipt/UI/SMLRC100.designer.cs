using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LoanReceipt.UI
{
	/// <summary>
	/// Summary description for SMLRC100
	/// </summary>
	partial class SMLRC100
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
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPPurchaseOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPPurchaseOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACLoanReceiptNo2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACLoanAgreementID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARDiscountProgramDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARDiscountProgramDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptNo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanAgreementID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARDiscountProgramDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARDiscountProgramDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARDiscountProgramDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARDiscountProgramDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = "";
            this.fld_Lablel1.BOSDataMember = "";
            this.fld_Lablel1.BOSDataSource = "";
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = "";
            this.fld_Lablel1.BOSFieldRelation = "";
            this.fld_Lablel1.BOSPrivilege = "";
            this.fld_Lablel1.BOSPropertyName = "";
            this.fld_Lablel1.Location = new System.Drawing.Point(24, 20);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(55, 13);
            this.fld_Lablel1.TabIndex = 26;
            this.fld_Lablel1.Tag = "SI";
            this.fld_Lablel1.Text = "Mã khế ước";
            // 
            // fld_dgcAPPurchaseOrder
            // 
            this.fld_dgcAPPurchaseOrder.AllowDrop = true;
            this.fld_dgcAPPurchaseOrder.BOSComment = "";
            this.fld_dgcAPPurchaseOrder.BOSDataMember = "";
            this.fld_dgcAPPurchaseOrder.BOSDataSource = "ACLoanReceipts";
            this.fld_dgcAPPurchaseOrder.BOSDescription = null;
            this.fld_dgcAPPurchaseOrder.BOSError = null;
            this.fld_dgcAPPurchaseOrder.BOSFieldGroup = "";
            this.fld_dgcAPPurchaseOrder.BOSFieldRelation = "";
            this.fld_dgcAPPurchaseOrder.BOSGridType = null;
            this.fld_dgcAPPurchaseOrder.BOSPrivilege = "";
            this.fld_dgcAPPurchaseOrder.BOSPropertyName = "";
            this.fld_dgcAPPurchaseOrder.CommodityType = "";
            this.fld_dgcAPPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrder.Location = new System.Drawing.Point(26, 187);
            this.fld_dgcAPPurchaseOrder.MainView = this.fld_dgvAPPurchaseOrder;
            this.fld_dgcAPPurchaseOrder.Name = "fld_dgcAPPurchaseOrder";
            this.fld_dgcAPPurchaseOrder.PrintReport = false;
            this.fld_dgcAPPurchaseOrder.Screen = null;
            this.fld_dgcAPPurchaseOrder.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPPurchaseOrder.TabIndex = 27;
            this.fld_dgcAPPurchaseOrder.Tag = "SR";
            this.fld_dgcAPPurchaseOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrder});
            // 
            // fld_dgvAPPurchaseOrder
            // 
            this.fld_dgvAPPurchaseOrder.GridControl = this.fld_dgcAPPurchaseOrder;
            this.fld_dgvAPPurchaseOrder.Name = "fld_dgvAPPurchaseOrder";
            this.fld_dgvAPPurchaseOrder.PaintStyleName = "Office2003";
            // 
            // fld_txtACLoanReceiptNo2
            // 
            this.fld_txtACLoanReceiptNo2.BOSComment = "";
            this.fld_txtACLoanReceiptNo2.BOSDataMember = "ACLoanReceiptNo";
            this.fld_txtACLoanReceiptNo2.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptNo2.BOSDescription = null;
            this.fld_txtACLoanReceiptNo2.BOSError = null;
            this.fld_txtACLoanReceiptNo2.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptNo2.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptNo2.BOSPrivilege = "";
            this.fld_txtACLoanReceiptNo2.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptNo2.EditValue = "";
            this.fld_txtACLoanReceiptNo2.Location = new System.Drawing.Point(127, 17);
            this.fld_txtACLoanReceiptNo2.Name = "fld_txtACLoanReceiptNo2";
            this.fld_txtACLoanReceiptNo2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptNo2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptNo2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptNo2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptNo2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptNo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptNo2.Screen = null;
            this.fld_txtACLoanReceiptNo2.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptNo2.TabIndex = 28;
            this.fld_txtACLoanReceiptNo2.Tag = "SC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(24, 46);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel11.TabIndex = 30;
            this.fld_lblLabel11.Tag = "SC";
            this.fld_lblLabel11.Text = "Số hợp đồng";
            // 
            // fld_lkeFK_ACLoanAgreementID1
            // 
            this.fld_lkeFK_ACLoanAgreementID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ACLoanAgreementID1.BOSAllowDummy = false;
            this.fld_lkeFK_ACLoanAgreementID1.BOSComment = "";
            this.fld_lkeFK_ACLoanAgreementID1.BOSDataMember = "FK_ACLoanAgreementID";
            this.fld_lkeFK_ACLoanAgreementID1.BOSDataSource = "ACLoanReceipts";
            this.fld_lkeFK_ACLoanAgreementID1.BOSDescription = null;
            this.fld_lkeFK_ACLoanAgreementID1.BOSError = null;
            this.fld_lkeFK_ACLoanAgreementID1.BOSFieldGroup = "";
            this.fld_lkeFK_ACLoanAgreementID1.BOSFieldParent = "";
            this.fld_lkeFK_ACLoanAgreementID1.BOSFieldRelation = "";
            this.fld_lkeFK_ACLoanAgreementID1.BOSPrivilege = "";
            this.fld_lkeFK_ACLoanAgreementID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACLoanAgreementID1.BOSSelectType = "";
            this.fld_lkeFK_ACLoanAgreementID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACLoanAgreementID1.CurrentDisplayText = null;
            this.fld_lkeFK_ACLoanAgreementID1.Location = new System.Drawing.Point(127, 43);
            this.fld_lkeFK_ACLoanAgreementID1.Name = "fld_lkeFK_ACLoanAgreementID1";
            this.fld_lkeFK_ACLoanAgreementID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACLoanAgreementID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACLoanAgreementID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACLoanAgreementID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACLoanAgreementID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACLoanAgreementID1.Properties.ColumnName = null;
            this.fld_lkeFK_ACLoanAgreementID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACLoanAgreementNo", "Mã hợp đồng")});
            this.fld_lkeFK_ACLoanAgreementID1.Properties.DisplayMember = "ACLoanAgreementNo";
            this.fld_lkeFK_ACLoanAgreementID1.Properties.NullText = "";
            this.fld_lkeFK_ACLoanAgreementID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACLoanAgreementID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACLoanAgreementID1.Properties.ValueMember = "ACLoanAgreementID";
            this.fld_lkeFK_ACLoanAgreementID1.Screen = null;
            this.fld_lkeFK_ACLoanAgreementID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACLoanAgreementID1.TabIndex = 29;
            this.fld_lkeFK_ACLoanAgreementID1.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(24, 98);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 73;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = "";
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "ACLoanReceipts";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(127, 95);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 72;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // fld_lkeFK_GECurrencyID1
            // 
            this.fld_lkeFK_GECurrencyID1.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID1.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID1.BOSComment = "";
            this.fld_lkeFK_GECurrencyID1.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID1.BOSDataSource = "ACLoanReceipts";
            this.fld_lkeFK_GECurrencyID1.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID1.BOSError = null;
            this.fld_lkeFK_GECurrencyID1.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID1.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID1.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID1.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID1.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID1.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID1.Location = new System.Drawing.Point(127, 69);
            this.fld_lkeFK_GECurrencyID1.Name = "fld_lkeFK_GECurrencyID1";
            this.fld_lkeFK_GECurrencyID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID1.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID1.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID1.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID1.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID1.Screen = null;
            this.fld_lkeFK_GECurrencyID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID1.TabIndex = 70;
            this.fld_lkeFK_GECurrencyID1.Tag = "SC";
            // 
            // bosLabel51
            // 
            this.bosLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel51.Appearance.Options.UseBackColor = true;
            this.bosLabel51.Appearance.Options.UseForeColor = true;
            this.bosLabel51.BOSComment = "";
            this.bosLabel51.BOSDataMember = "";
            this.bosLabel51.BOSDataSource = "";
            this.bosLabel51.BOSDescription = null;
            this.bosLabel51.BOSError = null;
            this.bosLabel51.BOSFieldGroup = "";
            this.bosLabel51.BOSFieldRelation = "";
            this.bosLabel51.BOSPrivilege = "";
            this.bosLabel51.BOSPropertyName = "";
            this.bosLabel51.Location = new System.Drawing.Point(24, 72);
            this.bosLabel51.Name = "bosLabel51";
            this.bosLabel51.Screen = null;
            this.bosLabel51.Size = new System.Drawing.Size(53, 13);
            this.bosLabel51.TabIndex = 71;
            this.bosLabel51.Tag = "SC";
            this.bosLabel51.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(24, 124);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 76;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_dteSearchFromARDiscountProgramDate
            // 
            this.fld_dteSearchFromARDiscountProgramDate.BOSComment = "";
            this.fld_dteSearchFromARDiscountProgramDate.BOSDataMember = "LoanReceiptFromDate";
            this.fld_dteSearchFromARDiscountProgramDate.BOSDataSource = "ACLoanReceipts";
            this.fld_dteSearchFromARDiscountProgramDate.BOSDescription = null;
            this.fld_dteSearchFromARDiscountProgramDate.BOSError = null;
            this.fld_dteSearchFromARDiscountProgramDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARDiscountProgramDate.BOSFieldRelation = "";
            this.fld_dteSearchFromARDiscountProgramDate.BOSPrivilege = "";
            this.fld_dteSearchFromARDiscountProgramDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARDiscountProgramDate.EditValue = null;
            this.fld_dteSearchFromARDiscountProgramDate.Location = new System.Drawing.Point(127, 121);
            this.fld_dteSearchFromARDiscountProgramDate.Name = "fld_dteSearchFromARDiscountProgramDate";
            this.fld_dteSearchFromARDiscountProgramDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARDiscountProgramDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARDiscountProgramDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARDiscountProgramDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARDiscountProgramDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARDiscountProgramDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARDiscountProgramDate.Screen = null;
            this.fld_dteSearchFromARDiscountProgramDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARDiscountProgramDate.TabIndex = 74;
            this.fld_dteSearchFromARDiscountProgramDate.Tag = "SC";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(305, 124);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 77;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dteSearchToARDiscountProgramDate
            // 
            this.fld_dteSearchToARDiscountProgramDate.BOSComment = "";
            this.fld_dteSearchToARDiscountProgramDate.BOSDataMember = "LoanReceiptToDate";
            this.fld_dteSearchToARDiscountProgramDate.BOSDataSource = "ACLoanReceipts";
            this.fld_dteSearchToARDiscountProgramDate.BOSDescription = null;
            this.fld_dteSearchToARDiscountProgramDate.BOSError = null;
            this.fld_dteSearchToARDiscountProgramDate.BOSFieldGroup = "";
            this.fld_dteSearchToARDiscountProgramDate.BOSFieldRelation = "";
            this.fld_dteSearchToARDiscountProgramDate.BOSPrivilege = "";
            this.fld_dteSearchToARDiscountProgramDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARDiscountProgramDate.EditValue = null;
            this.fld_dteSearchToARDiscountProgramDate.Location = new System.Drawing.Point(339, 121);
            this.fld_dteSearchToARDiscountProgramDate.Name = "fld_dteSearchToARDiscountProgramDate";
            this.fld_dteSearchToARDiscountProgramDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARDiscountProgramDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARDiscountProgramDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARDiscountProgramDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARDiscountProgramDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARDiscountProgramDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARDiscountProgramDate.Screen = null;
            this.fld_dteSearchToARDiscountProgramDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARDiscountProgramDate.TabIndex = 75;
            this.fld_dteSearchToARDiscountProgramDate.Tag = "SC";
            // 
            // SMLRC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(874, 581);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dteSearchFromARDiscountProgramDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchToARDiscountProgramDate);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_lkeFK_GECurrencyID1);
            this.Controls.Add(this.bosLabel51);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lkeFK_ACLoanAgreementID1);
            this.Controls.Add(this.fld_txtACLoanReceiptNo2);
            this.Controls.Add(this.fld_Lablel1);
            this.Controls.Add(this.fld_dgcAPPurchaseOrder);
            this.Name = "SMLRC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcAPPurchaseOrder, 0);
            this.Controls.SetChildIndex(this.fld_Lablel1, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanReceiptNo2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACLoanAgreementID1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_GECurrencyID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARDiscountProgramDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARDiscountProgramDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptNo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanAgreementID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARDiscountProgramDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARDiscountProgramDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARDiscountProgramDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARDiscountProgramDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_Lablel1;
        private BOSSearchResultsGridControl fld_dgcAPPurchaseOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrder;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptNo2;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACLoanAgreementID1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID1;
        private BOSComponent.BOSLabel bosLabel51;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARDiscountProgramDate;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchToARDiscountProgramDate;
    }
}
