using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MachineTimeKeeper.UI
{
	/// <summary>
	/// Summary description for SMHR100
	/// </summary>
	partial class SMHR100
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
            this.fld_lblLabel102 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRMachineTimeKeeperNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcHRMachineTimeKeeper = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRMachineTimeKeeper = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRMachineTimeKeeperNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMachineTimeKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRMachineTimeKeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel102
            // 
            this.fld_lblLabel102.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel102.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel102.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel102.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel102.Appearance.Options.UseFont = true;
            this.fld_lblLabel102.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel102.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel102.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel102.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel102.BOSDescription = null;
            this.fld_lblLabel102.BOSError = null;
            this.fld_lblLabel102.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel102.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel102.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel102.BOSPropertyName = null;
            this.fld_lblLabel102.Location = new System.Drawing.Point(18, 77);
            this.fld_lblLabel102.Name = "fld_lblLabel102";
            this.fld_lblLabel102.Screen = null;
            this.fld_lblLabel102.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel102.TabIndex = 98;
            this.fld_lblLabel102.Tag = "SI";
            this.fld_lblLabel102.Text = "Loại kết nối";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.bosLabel1.Location = new System.Drawing.Point(32, 51);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(41, 13);
            this.bosLabel1.TabIndex = 97;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên máy";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseFont = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel16.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel16.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel16.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel16.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(36, 25);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel16.TabIndex = 96;
            this.fld_lblLabel16.Tag = "SI";
            this.fld_lblLabel16.Text = "Mã máy";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSDataMember = "HRMachineTimeKeeperPortID";
            this.bosTextBox3.BOSDataSource = "HRMachineTimeKeepers";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(351, 48);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox3.TabIndex = 95;
            this.bosTextBox3.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(297, 51);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 94;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Port";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSDataMember = "HRMachineTimeKeeperIP";
            this.bosTextBox2.BOSDataSource = "HRMachineTimeKeepers";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(351, 22);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox2.TabIndex = 93;
            this.bosTextBox2.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.bosLabel2.Location = new System.Drawing.Point(297, 25);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 92;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Địa chỉ IP";
            // 
            // fld_lkeARCustomerTypeCombo
            // 
            this.fld_lkeARCustomerTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeARCustomerTypeCombo.BOSAllowDummy = false;
            this.fld_lkeARCustomerTypeCombo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSDataMember = "HRMachineTimeKeeperPortType";
            this.fld_lkeARCustomerTypeCombo.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_lkeARCustomerTypeCombo.BOSDescription = null;
            this.fld_lkeARCustomerTypeCombo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerTypeCombo.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.Location = new System.Drawing.Point(79, 74);
            this.fld_lkeARCustomerTypeCombo.Name = "fld_lkeARCustomerTypeCombo";
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerTypeCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerTypeCombo.Screen = null;
            this.fld_lkeARCustomerTypeCombo.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeARCustomerTypeCombo.TabIndex = 91;
            this.fld_lkeARCustomerTypeCombo.Tag = "SC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "HRMachineTimeKeeperName";
            this.bosTextBox1.BOSDataSource = "HRMachineTimeKeepers";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(79, 48);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox1.TabIndex = 90;
            this.bosTextBox1.Tag = "SC";
            // 
            // fld_txtHRMachineTimeKeeperNo
            // 
            this.fld_txtHRMachineTimeKeeperNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRMachineTimeKeeperNo.BOSDataMember = "HRMachineTimeKeeperNo";
            this.fld_txtHRMachineTimeKeeperNo.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_txtHRMachineTimeKeeperNo.BOSDescription = null;
            this.fld_txtHRMachineTimeKeeperNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRMachineTimeKeeperNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRMachineTimeKeeperNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRMachineTimeKeeperNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRMachineTimeKeeperNo.BOSPropertyName = "Text";
            this.fld_txtHRMachineTimeKeeperNo.Location = new System.Drawing.Point(79, 22);
            this.fld_txtHRMachineTimeKeeperNo.Name = "fld_txtHRMachineTimeKeeperNo";
            this.fld_txtHRMachineTimeKeeperNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRMachineTimeKeeperNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRMachineTimeKeeperNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRMachineTimeKeeperNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRMachineTimeKeeperNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRMachineTimeKeeperNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRMachineTimeKeeperNo.Screen = null;
            this.fld_txtHRMachineTimeKeeperNo.Size = new System.Drawing.Size(141, 20);
            this.fld_txtHRMachineTimeKeeperNo.TabIndex = 89;
            this.fld_txtHRMachineTimeKeeperNo.Tag = "SC";
            // 
            // fld_dgcHRMachineTimeKeeper
            // 
            this.fld_dgcHRMachineTimeKeeper.AllowDrop = true;
            this.fld_dgcHRMachineTimeKeeper.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRMachineTimeKeeper.BOSDataMember = null;
            this.fld_dgcHRMachineTimeKeeper.BOSDataSource = "HRMachineTimeKeepers";
            this.fld_dgcHRMachineTimeKeeper.BOSDescription = null;
            this.fld_dgcHRMachineTimeKeeper.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRMachineTimeKeeper.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRMachineTimeKeeper.BOSFieldRelation = null;
            this.fld_dgcHRMachineTimeKeeper.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRMachineTimeKeeper.BOSPropertyName = null;
            this.fld_dgcHRMachineTimeKeeper.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcHRMachineTimeKeeper.Location = new System.Drawing.Point(18, 100);
            this.fld_dgcHRMachineTimeKeeper.MainView = this.fld_dgvHRMachineTimeKeeper;
            this.fld_dgcHRMachineTimeKeeper.Name = "fld_dgcHRMachineTimeKeeper";
            this.fld_dgcHRMachineTimeKeeper.Screen = null;
            this.fld_dgcHRMachineTimeKeeper.Size = new System.Drawing.Size(508, 367);
            this.fld_dgcHRMachineTimeKeeper.TabIndex = 99;
            this.fld_dgcHRMachineTimeKeeper.Tag = "SR";
            this.fld_dgcHRMachineTimeKeeper.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRMachineTimeKeeper});
            // 
            // fld_dgvHRMachineTimeKeeper
            // 
            this.fld_dgvHRMachineTimeKeeper.GridControl = this.fld_dgcHRMachineTimeKeeper;
            this.fld_dgvHRMachineTimeKeeper.Name = "fld_dgvHRMachineTimeKeeper";
            this.fld_dgvHRMachineTimeKeeper.PaintStyleName = "Office2003";
            // 
            // SMHR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRMachineTimeKeeper);
            this.Controls.Add(this.fld_lblLabel102);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel16);
            this.Controls.Add(this.bosTextBox3);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosTextBox2);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeARCustomerTypeCombo);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_txtHRMachineTimeKeeperNo);
            this.Name = "SMHR100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRMachineTimeKeeperNo, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.fld_lkeARCustomerTypeCombo, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosTextBox2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosTextBox3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel16, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel102, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRMachineTimeKeeper, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRMachineTimeKeeperNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMachineTimeKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRMachineTimeKeeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel102;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerTypeCombo;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox fld_txtHRMachineTimeKeeperNo;
        private BOSSearchResultsGridControl fld_dgcHRMachineTimeKeeper;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRMachineTimeKeeper;
	}
}
