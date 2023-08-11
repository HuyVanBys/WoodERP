using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SlimDatabase.UI
{
	/// <summary>
	/// Summary description for DMSDB100
	/// </summary>
	partial class DMSDB100
	{
        private BOSComponent.BOSLabel fld_lblLabel;


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
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnDeleteInventoryControlData = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteAccountPayableData = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteAccountingData = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteHumanResourcesData = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteAccountReceivableData = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
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
            this.fld_lblLabel.Location = new System.Drawing.Point(27, 40);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Text = "Từ ngày";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteToDate);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteFromDate);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel);
            this.fld_grcGroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(862, 84);
            this.fld_grcGroupControl1.TabIndex = 6;
            this.fld_grcGroupControl1.Text = "Chọn khoảng thời gian cắt dữ liệu";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteToDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = "EditValue";
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(345, 37);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 1;
            this.fld_dteToDate.Tag = "DC";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = "EditValue";
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(89, 37);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 0;
            this.fld_dteFromDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(286, 40);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 4;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDeleteInventoryControlData);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDeleteAccountPayableData);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDeleteAccountingData);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDeleteHumanResourcesData);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDeleteAccountReceivableData);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 84);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 328);
            this.fld_grcGroupControl.TabIndex = 7;
            this.fld_grcGroupControl.Text = "Cắt dữ liệu theo các phân hệ";
            // 
            // fld_btnDeleteInventoryControlData
            // 
            this.fld_btnDeleteInventoryControlData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeleteInventoryControlData.Appearance.Options.UseForeColor = true;
            this.fld_btnDeleteInventoryControlData.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteInventoryControlData.BOSDataMember = null;
            this.fld_btnDeleteInventoryControlData.BOSDataSource = null;
            this.fld_btnDeleteInventoryControlData.BOSDescription = null;
            this.fld_btnDeleteInventoryControlData.BOSError = null;
            this.fld_btnDeleteInventoryControlData.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteInventoryControlData.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteInventoryControlData.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteInventoryControlData.BOSPropertyName = null;
            this.fld_btnDeleteInventoryControlData.Location = new System.Drawing.Point(28, 158);
            this.fld_btnDeleteInventoryControlData.Name = "fld_btnDeleteInventoryControlData";
            this.fld_btnDeleteInventoryControlData.Screen = null;
            this.fld_btnDeleteInventoryControlData.Size = new System.Drawing.Size(125, 25);
            this.fld_btnDeleteInventoryControlData.TabIndex = 2;
            this.fld_btnDeleteInventoryControlData.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteInventoryControlData.Text = "Kho";
            this.fld_btnDeleteInventoryControlData.Click += new System.EventHandler(this.fld_btnDeleteInventoryControlData_Click);
            // 
            // fld_btnDeleteAccountPayableData
            // 
            this.fld_btnDeleteAccountPayableData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeleteAccountPayableData.Appearance.Options.UseForeColor = true;
            this.fld_btnDeleteAccountPayableData.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountPayableData.BOSDataMember = null;
            this.fld_btnDeleteAccountPayableData.BOSDataSource = null;
            this.fld_btnDeleteAccountPayableData.BOSDescription = null;
            this.fld_btnDeleteAccountPayableData.BOSError = null;
            this.fld_btnDeleteAccountPayableData.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountPayableData.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountPayableData.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountPayableData.BOSPropertyName = null;
            this.fld_btnDeleteAccountPayableData.Location = new System.Drawing.Point(28, 72);
            this.fld_btnDeleteAccountPayableData.Name = "fld_btnDeleteAccountPayableData";
            this.fld_btnDeleteAccountPayableData.Screen = null;
            this.fld_btnDeleteAccountPayableData.Size = new System.Drawing.Size(125, 25);
            this.fld_btnDeleteAccountPayableData.TabIndex = 0;
            this.fld_btnDeleteAccountPayableData.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountPayableData.Text = "Mua hàng";
            this.fld_btnDeleteAccountPayableData.Click += new System.EventHandler(this.fld_btnDeleteAccountPayableData_Click);
            // 
            // fld_btnDeleteAccountingData
            // 
            this.fld_btnDeleteAccountingData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeleteAccountingData.Appearance.Options.UseForeColor = true;
            this.fld_btnDeleteAccountingData.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountingData.BOSDataMember = null;
            this.fld_btnDeleteAccountingData.BOSDataSource = null;
            this.fld_btnDeleteAccountingData.BOSDescription = null;
            this.fld_btnDeleteAccountingData.BOSError = null;
            this.fld_btnDeleteAccountingData.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountingData.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountingData.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountingData.BOSPropertyName = null;
            this.fld_btnDeleteAccountingData.Location = new System.Drawing.Point(28, 246);
            this.fld_btnDeleteAccountingData.Name = "fld_btnDeleteAccountingData";
            this.fld_btnDeleteAccountingData.Screen = null;
            this.fld_btnDeleteAccountingData.Size = new System.Drawing.Size(125, 25);
            this.fld_btnDeleteAccountingData.TabIndex = 4;
            this.fld_btnDeleteAccountingData.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountingData.Text = "Kế toán";
            this.fld_btnDeleteAccountingData.Click += new System.EventHandler(this.fld_btnDeleteAccountingData_Click);
            // 
            // fld_btnDeleteHumanResourcesData
            // 
            this.fld_btnDeleteHumanResourcesData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeleteHumanResourcesData.Appearance.Options.UseForeColor = true;
            this.fld_btnDeleteHumanResourcesData.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteHumanResourcesData.BOSDataMember = null;
            this.fld_btnDeleteHumanResourcesData.BOSDataSource = null;
            this.fld_btnDeleteHumanResourcesData.BOSDescription = null;
            this.fld_btnDeleteHumanResourcesData.BOSError = null;
            this.fld_btnDeleteHumanResourcesData.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteHumanResourcesData.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteHumanResourcesData.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteHumanResourcesData.BOSPropertyName = null;
            this.fld_btnDeleteHumanResourcesData.Location = new System.Drawing.Point(28, 203);
            this.fld_btnDeleteHumanResourcesData.Name = "fld_btnDeleteHumanResourcesData";
            this.fld_btnDeleteHumanResourcesData.Screen = null;
            this.fld_btnDeleteHumanResourcesData.Size = new System.Drawing.Size(125, 25);
            this.fld_btnDeleteHumanResourcesData.TabIndex = 3;
            this.fld_btnDeleteHumanResourcesData.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteHumanResourcesData.Text = "Nhân sự";
            this.fld_btnDeleteHumanResourcesData.Click += new System.EventHandler(this.fld_btnDeleteHumanResourcesData_Click);
            // 
            // fld_btnDeleteAccountReceivableData
            // 
            this.fld_btnDeleteAccountReceivableData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeleteAccountReceivableData.Appearance.Options.UseForeColor = true;
            this.fld_btnDeleteAccountReceivableData.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountReceivableData.BOSDataMember = null;
            this.fld_btnDeleteAccountReceivableData.BOSDataSource = null;
            this.fld_btnDeleteAccountReceivableData.BOSDescription = null;
            this.fld_btnDeleteAccountReceivableData.BOSError = null;
            this.fld_btnDeleteAccountReceivableData.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountReceivableData.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountReceivableData.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountReceivableData.BOSPropertyName = null;
            this.fld_btnDeleteAccountReceivableData.Location = new System.Drawing.Point(28, 115);
            this.fld_btnDeleteAccountReceivableData.Name = "fld_btnDeleteAccountReceivableData";
            this.fld_btnDeleteAccountReceivableData.Screen = null;
            this.fld_btnDeleteAccountReceivableData.Size = new System.Drawing.Size(125, 25);
            this.fld_btnDeleteAccountReceivableData.TabIndex = 1;
            this.fld_btnDeleteAccountReceivableData.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeleteAccountReceivableData.Text = "Bán hàng";
            this.fld_btnDeleteAccountReceivableData.Click += new System.EventHandler(this.fld_btnDeleteAccountReceivableData_Click);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(168, 164);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(300, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Bao gồm những chứng từ: nhập kho, xuất kho, chuyển kho,...";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(18, 36);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(140, 13);
            this.fld_lblLabel1.TabIndex = 11;
            this.fld_lblLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Text = "Chọn phân hệ cần cắt dữ liệu";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(168, 79);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(379, 13);
            this.fld_lblLabel3.TabIndex = 13;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Bao gồm những chứng từ mua hàng: đề nghị mua hàng, hóa đơn mua hàng,... ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(168, 252);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(378, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Bao gồm những chứng từ kế toán: phiếu thu, phiếu chi, tiền gửi ngân hàng, ...";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(168, 210);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(251, 13);
            this.fld_lblLabel4.TabIndex = 14;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Bao gồm những chứng từ: chấm công, tính lương,...";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(168, 121);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(400, 13);
            this.fld_lblLabel5.TabIndex = 15;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Bao gồm những chứng từ bán hàng: đơn bán hàng, phiếu giao, hàng  bán trả lại,...";
            // 
            // DMSDB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 412);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Name = "DMSDB100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSButton fld_btnDeleteInventoryControlData;
        private BOSComponent.BOSButton fld_btnDeleteAccountPayableData;
        private BOSComponent.BOSButton fld_btnDeleteAccountingData;
        private BOSComponent.BOSButton fld_btnDeleteHumanResourcesData;
        private BOSComponent.BOSButton fld_btnDeleteAccountReceivableData;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
	}
}
