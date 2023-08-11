using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Customer.UI
{
	/// <summary>
	/// Summary description for SMCU100
	/// </summary>
	partial class SMCU100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtARCustomerName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcARCustomer;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomer;
		private BOSComponent.BOSLookupEdit fld_lkeARCustomerTypeCombo1;
        private BOSComponent.BOSLabel fld_lblLabel31;
		private BOSComponent.BOSTextBox fld_txtARCustomerNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID1;
        private BOSComponent.BOSLabel fld_lblLabel1;


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
            this.fld_lblLabel53 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel57 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARCustomer = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeARCustomerTypeCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARPriceLevelID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerContactPhone1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerContactAddressLine3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerTypeCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel53
            // 
            this.fld_lblLabel53.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel53.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_lblLabel53.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel53.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel53.Appearance.Options.UseFont = true;
            this.fld_lblLabel53.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel53.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSPropertyName = null;
            this.fld_lblLabel53.Location = new System.Drawing.Point(40, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(73, 14);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã khách hàng";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSPropertyName = null;
            this.fld_lblLabel57.Location = new System.Drawing.Point(40, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(77, 14);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên khách hàng";
            // 
            // fld_txtARCustomerName
            // 
            this.fld_txtARCustomerName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerName.BOSDataMember = "ARCustomerName";
            this.fld_txtARCustomerName.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerName.BOSDescription = null;
            this.fld_txtARCustomerName.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerName.BOSPropertyName = "Text";
            this.fld_txtARCustomerName.Location = new System.Drawing.Point(146, 35);
            this.fld_txtARCustomerName.Name = "fld_txtARCustomerName";
            this.fld_txtARCustomerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerName.Screen = null;
            this.fld_txtARCustomerName.Size = new System.Drawing.Size(165, 20);
            this.fld_txtARCustomerName.TabIndex = 1;
            this.fld_txtARCustomerName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSPropertyName = null;
            this.fld_lblLabel51.Location = new System.Drawing.Point(70, 85);
            this.fld_lblLabel51.Name = "fld_lblLabel51";
            this.fld_lblLabel51.Screen = null;
            this.fld_lblLabel51.Size = new System.Drawing.Size(0, 14);
            this.fld_lblLabel51.TabIndex = 65;
            this.fld_lblLabel51.Tag = "SI";
            // 
            // fld_lblLabel58
            // 
            this.fld_lblLabel58.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel58.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_lblLabel58.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel58.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel58.Appearance.Options.UseFont = true;
            this.fld_lblLabel58.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel58.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSPropertyName = null;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 14);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_dgcARCustomer
            // 
            this.fld_dgcARCustomer.AllowDrop = true;
            this.fld_dgcARCustomer.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARCustomer.BOSDataMember = null;
            this.fld_dgcARCustomer.BOSDataSource = "ARCustomers";
            this.fld_dgcARCustomer.BOSDescription = null;
            this.fld_dgcARCustomer.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARCustomer.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARCustomer.BOSFieldRelation = null;
            this.fld_dgcARCustomer.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARCustomer.BOSPropertyName = null;
            this.fld_dgcARCustomer.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcARCustomer.Location = new System.Drawing.Point(10, 216);
            this.fld_dgcARCustomer.MainView = this.fld_dgvARCustomer;
            this.fld_dgcARCustomer.Name = "fld_dgcARCustomer";
            this.fld_dgcARCustomer.Screen = null;
            this.fld_dgcARCustomer.Size = new System.Drawing.Size(508, 339);
            this.fld_dgcARCustomer.TabIndex = 67;
            this.fld_dgcARCustomer.Tag = "SR";
            this.fld_dgcARCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomer});
            // 
            // fld_dgvARCustomer
            // 
            this.fld_dgvARCustomer.GridControl = this.fld_dgcARCustomer;
            this.fld_dgvARCustomer.Name = "fld_dgvARCustomer";
            this.fld_dgvARCustomer.PaintStyleName = "Office2003";
            // 
            // fld_lkeARCustomerTypeCombo1
            // 
            this.fld_lkeARCustomerTypeCombo1.BOSAllowAddNew = false;
            this.fld_lkeARCustomerTypeCombo1.BOSAllowDummy = false;
            this.fld_lkeARCustomerTypeCombo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSDataMember = "ARCustomerTypeCombo";
            this.fld_lkeARCustomerTypeCombo1.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerTypeCombo1.BOSDescription = null;
            this.fld_lkeARCustomerTypeCombo1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerTypeCombo1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.Location = new System.Drawing.Point(146, 61);
            this.fld_lkeARCustomerTypeCombo1.Name = "fld_lkeARCustomerTypeCombo1";
            this.fld_lkeARCustomerTypeCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerTypeCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerTypeCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerTypeCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerTypeCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerTypeCombo1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerTypeCombo1.Screen = null;
            this.fld_lkeARCustomerTypeCombo1.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeARCustomerTypeCombo1.TabIndex = 2;
            this.fld_lkeARCustomerTypeCombo1.Tag = "SC";
            // 
            // fld_lblLabel31
            // 
            this.fld_lblLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel31.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_lblLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel31.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel31.Appearance.Options.UseFont = true;
            this.fld_lblLabel31.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel31.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSDescription = null;
            this.fld_lblLabel31.BOSError = null;
            this.fld_lblLabel31.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel31.BOSPropertyName = null;
            this.fld_lblLabel31.Location = new System.Drawing.Point(40, 64);
            this.fld_lblLabel31.Name = "fld_lblLabel31";
            this.fld_lblLabel31.Screen = null;
            this.fld_lblLabel31.Size = new System.Drawing.Size(79, 14);
            this.fld_lblLabel31.TabIndex = 78;
            this.fld_lblLabel31.Tag = "SI";
            this.fld_lblLabel31.Text = "Loại khách hàng";
            // 
            // fld_txtARCustomerNo
            // 
            this.fld_txtARCustomerNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerNo.BOSDataMember = "ARCustomerNo";
            this.fld_txtARCustomerNo.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerNo.BOSDescription = null;
            this.fld_txtARCustomerNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerNo.BOSPropertyName = "Text";
            this.fld_txtARCustomerNo.Location = new System.Drawing.Point(146, 9);
            this.fld_txtARCustomerNo.Name = "fld_txtARCustomerNo";
            this.fld_txtARCustomerNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerNo.Screen = null;
            this.fld_txtARCustomerNo.Size = new System.Drawing.Size(165, 20);
            this.fld_txtARCustomerNo.TabIndex = 0;
            this.fld_txtARCustomerNo.Tag = "SC";
            // 
            // fld_lkeFK_ARPriceLevelID1
            // 
            this.fld_lkeFK_ARPriceLevelID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID1.BOSAllowDummy = true;
            this.fld_lkeFK_ARPriceLevelID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID1.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARPriceLevelID1.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.Location = new System.Drawing.Point(146, 87);
            this.fld_lkeFK_ARPriceLevelID1.Name = "fld_lkeFK_ARPriceLevelID1";
            this.fld_lkeFK_ARPriceLevelID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Name")});
            this.fld_lkeFK_ARPriceLevelID1.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARPriceLevelID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARPriceLevelID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID1.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID1.Screen = null;
            this.fld_lkeFK_ARPriceLevelID1.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_ARPriceLevelID1.TabIndex = 3;
            this.fld_lkeFK_ARPriceLevelID1.Tag = "SC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseFont = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(40, 90);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(38, 14);
            this.fld_lblLabel1.TabIndex = 80;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Mức giá";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 116);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 14);
            this.bosLabel1.TabIndex = 80;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Điện thoại";
            // 
            // fld_txtARCustomerContactPhone1
            // 
            this.fld_txtARCustomerContactPhone1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactPhone1.BOSDataMember = "ARCustomerContactPhone";
            this.fld_txtARCustomerContactPhone1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactPhone1.BOSDescription = null;
            this.fld_txtARCustomerContactPhone1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactPhone1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactPhone1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactPhone1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactPhone1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactPhone1.Location = new System.Drawing.Point(146, 113);
            this.fld_txtARCustomerContactPhone1.Name = "fld_txtARCustomerContactPhone1";
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactPhone1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactPhone1.Screen = null;
            this.fld_txtARCustomerContactPhone1.Size = new System.Drawing.Size(165, 20);
            this.fld_txtARCustomerContactPhone1.TabIndex = 4;
            this.fld_txtARCustomerContactPhone1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(40, 142);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(33, 14);
            this.bosLabel2.TabIndex = 80;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Địa chỉ";
            // 
            // fld_txtARCustomerContactAddressLine3
            // 
            this.fld_txtARCustomerContactAddressLine3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactAddressLine3.BOSDataMember = "ARCustomerContactAddressLine3";
            this.fld_txtARCustomerContactAddressLine3.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactAddressLine3.BOSDescription = null;
            this.fld_txtARCustomerContactAddressLine3.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactAddressLine3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactAddressLine3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactAddressLine3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCustomerContactAddressLine3.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactAddressLine3.Location = new System.Drawing.Point(146, 139);
            this.fld_txtARCustomerContactAddressLine3.Name = "fld_txtARCustomerContactAddressLine3";
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactAddressLine3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactAddressLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactAddressLine3.Screen = null;
            this.fld_txtARCustomerContactAddressLine3.Size = new System.Drawing.Size(311, 20);
            this.fld_txtARCustomerContactAddressLine3.TabIndex = 5;
            this.fld_txtARCustomerContactAddressLine3.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(40, 168);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 84;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(146, 165);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 6;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMCU100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(540, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_txtARCustomerName);
            this.Controls.Add(this.fld_dgcARCustomer);
            this.Controls.Add(this.fld_txtARCustomerContactAddressLine3);
            this.Controls.Add(this.fld_txtARCustomerContactPhone1);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtARCustomerNo);
            this.Controls.Add(this.fld_lkeARCustomerTypeCombo1);
            this.Controls.Add(this.fld_lblLabel31);
            this.Controls.Add(this.fld_lkeFK_ARPriceLevelID1);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel2);
            this.Name = "SMCU100";
            this.Tag = global::Localization.ReportLocalizedResources.String1;
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARPriceLevelID1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel31, 0);
            this.Controls.SetChildIndex(this.fld_lkeARCustomerTypeCombo1, 0);
            this.Controls.SetChildIndex(this.fld_txtARCustomerNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_txtARCustomerContactPhone1, 0);
            this.Controls.SetChildIndex(this.fld_txtARCustomerContactAddressLine3, 0);
            this.Controls.SetChildIndex(this.fld_dgcARCustomer, 0);
            this.Controls.SetChildIndex(this.fld_txtARCustomerName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerTypeCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactPhone1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactAddressLine3;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
