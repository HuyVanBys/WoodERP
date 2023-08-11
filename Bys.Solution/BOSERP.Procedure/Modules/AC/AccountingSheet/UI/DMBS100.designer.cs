using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AccountingSheet.UI
{
	/// <summary>
	/// Summary description for DMBS100
	/// </summary>
	partial class DMBS100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACAccountingSheetDetails = new BOSERP.Modules.AccountingSheet.ACAccountingSheetDetailsGridControl();
            this.fld_dgvHREmployeeAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACAccountingSheetFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACAccountingSheetToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_BRBranchCentralID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAccountingSheetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchCentralID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchCentralID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_btnAdd);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_dteACAccountingSheetFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteACAccountingSheetToDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 7;
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcACAccountingSheetDetails);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 64);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(855, 500);
            this.fld_grcGroupControl.TabIndex = 76;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Chi tiết bảng cân đối kế toán";
            // 
            // fld_dgcACAccountingSheetDetails
            // 
            this.fld_dgcACAccountingSheetDetails.AllowDrop = true;
            this.fld_dgcACAccountingSheetDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACAccountingSheetDetails.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheetDetails.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheetDetails.BOSDataSource = "ACAccountingSheetDetails";
            this.fld_dgcACAccountingSheetDetails.BOSDescription = null;
            this.fld_dgcACAccountingSheetDetails.BOSError = null;
            this.fld_dgcACAccountingSheetDetails.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheetDetails.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheetDetails.BOSGridType = null;
            this.fld_dgcACAccountingSheetDetails.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheetDetails.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheetDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACAccountingSheetDetails.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcACAccountingSheetDetails.MainView = this.fld_dgvHREmployeeAllowances;
            this.fld_dgcACAccountingSheetDetails.Name = "fld_dgcACAccountingSheetDetails";
            this.fld_dgcACAccountingSheetDetails.PrintReport = false;
            this.fld_dgcACAccountingSheetDetails.Screen = null;
            this.fld_dgcACAccountingSheetDetails.Size = new System.Drawing.Size(845, 470);
            this.fld_dgcACAccountingSheetDetails.TabIndex = 12;
            this.fld_dgcACAccountingSheetDetails.Tag = "DC";
            this.fld_dgcACAccountingSheetDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeAllowances});
            // 
            // fld_dgvHREmployeeAllowances
            // 
            this.fld_dgvHREmployeeAllowances.GridControl = this.fld_dgcACAccountingSheetDetails;
            this.fld_dgvHREmployeeAllowances.Name = "fld_dgvHREmployeeAllowances";
            this.fld_dgvHREmployeeAllowances.PaintStyleName = "Office2003";
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAdd.Appearance.Options.UseForeColor = true;
            this.fld_btnAdd.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.Location = new System.Drawing.Point(458, 34);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(72, 24);
            this.fld_btnAdd.TabIndex = 4;
            this.fld_btnAdd.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.Text = "Xem";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Location = new System.Drawing.Point(13, 15);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel5.TabIndex = 71;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Từ ngày";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Location = new System.Drawing.Point(248, 15);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel6.TabIndex = 72;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Đến ngày";
            // 
            // fld_dteACAccountingSheetFromDate
            // 
            this.fld_dteACAccountingSheetFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSDataMember = "ACAccountingSheetFromDate";
            this.fld_dteACAccountingSheetFromDate.BOSDataSource = "ACAccountingSheets";
            this.fld_dteACAccountingSheetFromDate.BOSDescription = null;
            this.fld_dteACAccountingSheetFromDate.BOSError = null;
            this.fld_dteACAccountingSheetFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACAccountingSheetFromDate.EditValue = null;
            this.fld_dteACAccountingSheetFromDate.Location = new System.Drawing.Point(74, 12);
            this.fld_dteACAccountingSheetFromDate.Name = "fld_dteACAccountingSheetFromDate";
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAccountingSheetFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAccountingSheetFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAccountingSheetFromDate.Screen = null;
            this.fld_dteACAccountingSheetFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACAccountingSheetFromDate.TabIndex = 0;
            this.fld_dteACAccountingSheetFromDate.Tag = "DC";
            // 
            // fld_dteACAccountingSheetToDate
            // 
            this.fld_dteACAccountingSheetToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSDataMember = "ACAccountingSheetToDate";
            this.fld_dteACAccountingSheetToDate.BOSDataSource = "ACAccountingSheets";
            this.fld_dteACAccountingSheetToDate.BOSDescription = null;
            this.fld_dteACAccountingSheetToDate.BOSError = null;
            this.fld_dteACAccountingSheetToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSPropertyName = "EditValue";
            this.fld_dteACAccountingSheetToDate.EditValue = null;
            this.fld_dteACAccountingSheetToDate.Location = new System.Drawing.Point(302, 12);
            this.fld_dteACAccountingSheetToDate.Name = "fld_dteACAccountingSheetToDate";
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAccountingSheetToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAccountingSheetToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAccountingSheetToDate.Screen = null;
            this.fld_dteACAccountingSheetToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACAccountingSheetToDate.TabIndex = 1;
            this.fld_dteACAccountingSheetToDate.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchCentralID
            // 
            this.fld_lkeFK_BRBranchCentralID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchCentralID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchCentralID.BOSComment = null;
            this.fld_lkeFK_BRBranchCentralID.BOSDataMember = "FK_BRBranchCentralID";
            this.fld_lkeFK_BRBranchCentralID.BOSDataSource = "ACAccountingSheets";
            this.fld_lkeFK_BRBranchCentralID.BOSDescription = null;
            this.fld_lkeFK_BRBranchCentralID.BOSError = null;
            this.fld_lkeFK_BRBranchCentralID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchCentralID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchCentralID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchCentralID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchCentralID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchCentralID.BOSSelectType = "BRBranchType";
            this.fld_lkeFK_BRBranchCentralID.BOSSelectTypeValue = "Central";
            this.fld_lkeFK_BRBranchCentralID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchCentralID.Location = new System.Drawing.Point(74, 38);
            this.fld_lkeFK_BRBranchCentralID.Name = "fld_lkeFK_BRBranchCentralID";
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchCentralID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchCentralID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchCentralID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchCentralID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchCentralID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchCentralID.Screen = null;
            this.fld_lkeFK_BRBranchCentralID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchCentralID.TabIndex = 2;
            this.fld_lkeFK_BRBranchCentralID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = "ARInvoices";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(13, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 601;
            this.bosLabel3.Text = "Trung tâm";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACAccountingSheets";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(302, 38);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = "ARInvoices";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(248, 41);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(48, 13);
            this.bosLabel18.TabIndex = 600;
            this.bosLabel18.Text = "Chi nhánh";
            // 
            // DMBS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAccountingSheetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchCentralID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private ACAccountingSheetDetailsGridControl fld_dgcACAccountingSheetDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeAllowances;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSDateEdit fld_dteACAccountingSheetFromDate;
        private BOSComponent.BOSDateEdit fld_dteACAccountingSheetToDate;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchCentralID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel18;
	}
}
