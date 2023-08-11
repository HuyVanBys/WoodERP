using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRProductPieceWage.UI
{
	/// <summary>
	/// Summary description for DMHRPPW100
	/// </summary>
	partial class DMHRPPW100
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSTextBox fld_txtHRProductPieceWageNo;
        private BOSComponent.BOSTextBox fld_txtHRProductPieceWageName;
		private BOSComponent.BOSMemoEdit fld_medHRProductPieceWageDesc;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel8;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHRProductPieceWageQuantity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRProductPieceWageUnitPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRProductPieceWageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRProductPieceWageName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRProductPieceWageDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRProductPieceWageDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRProductPieceWageQuantity);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRProductPieceWageUnitPrice);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRProductPieceWageNo);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRProductPieceWageName);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRProductPieceWageDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(712, 591);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Text = "Thông tin công việc";
            // 
            // fld_txtHRProductPieceWageQuantity
            // 
            this.fld_txtHRProductPieceWageQuantity.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageQuantity.BOSDataMember = "HRProductPieceWageQuantity";
            this.fld_txtHRProductPieceWageQuantity.BOSDataSource = "HRProductPieceWages";
            this.fld_txtHRProductPieceWageQuantity.BOSDescription = null;
            this.fld_txtHRProductPieceWageQuantity.BOSError = null;
            this.fld_txtHRProductPieceWageQuantity.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageQuantity.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageQuantity.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageQuantity.BOSPropertyName = "Text";
            this.fld_txtHRProductPieceWageQuantity.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageQuantity.Location = new System.Drawing.Point(376, 54);
            this.fld_txtHRProductPieceWageQuantity.Name = "fld_txtHRProductPieceWageQuantity";
            this.fld_txtHRProductPieceWageQuantity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRProductPieceWageQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRProductPieceWageQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRProductPieceWageQuantity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRProductPieceWageQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRProductPieceWageQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRProductPieceWageQuantity.Screen = null;
            this.fld_txtHRProductPieceWageQuantity.Size = new System.Drawing.Size(186, 20);
            this.fld_txtHRProductPieceWageQuantity.TabIndex = 7;
            this.fld_txtHRProductPieceWageQuantity.Tag = "DC";
            // 
            // fld_txtHRProductPieceWageUnitPrice
            // 
            this.fld_txtHRProductPieceWageUnitPrice.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageUnitPrice.BOSDataMember = "HRProductPieceWageUnitPrice";
            this.fld_txtHRProductPieceWageUnitPrice.BOSDataSource = "HRProductPieceWages";
            this.fld_txtHRProductPieceWageUnitPrice.BOSDescription = null;
            this.fld_txtHRProductPieceWageUnitPrice.BOSError = null;
            this.fld_txtHRProductPieceWageUnitPrice.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageUnitPrice.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageUnitPrice.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageUnitPrice.BOSPropertyName = "Text";
            this.fld_txtHRProductPieceWageUnitPrice.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageUnitPrice.Location = new System.Drawing.Point(84, 54);
            this.fld_txtHRProductPieceWageUnitPrice.Name = "fld_txtHRProductPieceWageUnitPrice";
            this.fld_txtHRProductPieceWageUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRProductPieceWageUnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRProductPieceWageUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRProductPieceWageUnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRProductPieceWageUnitPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRProductPieceWageUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRProductPieceWageUnitPrice.Screen = null;
            this.fld_txtHRProductPieceWageUnitPrice.Size = new System.Drawing.Size(186, 20);
            this.fld_txtHRProductPieceWageUnitPrice.TabIndex = 5;
            this.fld_txtHRProductPieceWageUnitPrice.Tag = "DC";
            // 
            // fld_txtHRProductPieceWageNo
            // 
            this.fld_txtHRProductPieceWageNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageNo.BOSDataMember = "HRProductPieceWageNo";
            this.fld_txtHRProductPieceWageNo.BOSDataSource = "HRProductPieceWages";
            this.fld_txtHRProductPieceWageNo.BOSDescription = null;
            this.fld_txtHRProductPieceWageNo.BOSError = null;
            this.fld_txtHRProductPieceWageNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageNo.BOSPropertyName = "Text";
            this.fld_txtHRProductPieceWageNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageNo.Location = new System.Drawing.Point(84, 28);
            this.fld_txtHRProductPieceWageNo.Name = "fld_txtHRProductPieceWageNo";
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRProductPieceWageNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRProductPieceWageNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRProductPieceWageNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRProductPieceWageNo.Screen = null;
            this.fld_txtHRProductPieceWageNo.Size = new System.Drawing.Size(186, 20);
            this.fld_txtHRProductPieceWageNo.TabIndex = 1;
            this.fld_txtHRProductPieceWageNo.Tag = "DC";
            // 
            // fld_txtHRProductPieceWageName
            // 
            this.fld_txtHRProductPieceWageName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageName.BOSDataMember = "HRProductPieceWageName";
            this.fld_txtHRProductPieceWageName.BOSDataSource = "HRProductPieceWages";
            this.fld_txtHRProductPieceWageName.BOSDescription = null;
            this.fld_txtHRProductPieceWageName.BOSError = null;
            this.fld_txtHRProductPieceWageName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageName.BOSPropertyName = "Text";
            this.fld_txtHRProductPieceWageName.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRProductPieceWageName.Location = new System.Drawing.Point(376, 28);
            this.fld_txtHRProductPieceWageName.Name = "fld_txtHRProductPieceWageName";
            this.fld_txtHRProductPieceWageName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRProductPieceWageName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRProductPieceWageName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRProductPieceWageName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRProductPieceWageName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRProductPieceWageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRProductPieceWageName.Screen = null;
            this.fld_txtHRProductPieceWageName.Size = new System.Drawing.Size(186, 20);
            this.fld_txtHRProductPieceWageName.TabIndex = 3;
            this.fld_txtHRProductPieceWageName.Tag = "DC";
            // 
            // fld_medHRProductPieceWageDesc
            // 
            this.fld_medHRProductPieceWageDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRProductPieceWageDesc.BOSDataMember = "HRProductPieceWageDesc";
            this.fld_medHRProductPieceWageDesc.BOSDataSource = "HRProductPieceWages";
            this.fld_medHRProductPieceWageDesc.BOSDescription = null;
            this.fld_medHRProductPieceWageDesc.BOSError = null;
            this.fld_medHRProductPieceWageDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRProductPieceWageDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRProductPieceWageDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRProductPieceWageDesc.BOSPropertyName = "Text";
            this.fld_medHRProductPieceWageDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRProductPieceWageDesc.Location = new System.Drawing.Point(84, 80);
            this.fld_medHRProductPieceWageDesc.Name = "fld_medHRProductPieceWageDesc";
            this.fld_medHRProductPieceWageDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRProductPieceWageDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRProductPieceWageDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRProductPieceWageDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRProductPieceWageDesc.Screen = null;
            this.fld_medHRProductPieceWageDesc.Size = new System.Drawing.Size(478, 41);
            this.fld_medHRProductPieceWageDesc.TabIndex = 9;
            this.fld_medHRProductPieceWageDesc.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 31);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel4.TabIndex = 0;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Text = "Mã công việc";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(316, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(18, 13);
            this.fld_lblLabel5.TabIndex = 2;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.Text = "Tên";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(316, 57);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(42, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Số lượng";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 57);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel6.TabIndex = 4;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.Text = "Đơn giá";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 83);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 8;
            this.fld_lblLabel8.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.Text = "Diễn giải";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(712, 376);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMHRPPW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(712, 376);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRPPW100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRProductPieceWageName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRProductPieceWageDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHRProductPieceWageQuantity;
        private BOSComponent.BOSTextBox fld_txtHRProductPieceWageUnitPrice;
	}
}
