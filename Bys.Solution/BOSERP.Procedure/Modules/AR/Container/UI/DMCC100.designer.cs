using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Container.UI
{
	/// <summary>
	/// Summary description for DMPT100
	/// </summary>
	partial class DMCC100
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
            this.fld_txtGEContainerName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtGEContainerNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lbPaymentTermNo = new BOSComponent.BOSLabel(this.components);
            this.fld_lbPaymentTermName = new BOSComponent.BOSLabel(this.components);
            this.fld_lbLoai = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeGEContainerType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtGEContainerHeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtGEContainerWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtGEContainerLenght = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGEContainerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerLenght.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtGEContainerName
            // 
            this.fld_txtGEContainerName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerName.BOSDataMember = "GEContainerName";
            this.fld_txtGEContainerName.BOSDataSource = "GEContainers";
            this.fld_txtGEContainerName.BOSDescription = null;
            this.fld_txtGEContainerName.BOSError = null;
            this.fld_txtGEContainerName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerName.BOSPropertyName = "Text";
            this.fld_txtGEContainerName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerName.Location = new System.Drawing.Point(147, 41);
            this.fld_txtGEContainerName.Name = "fld_txtGEContainerName";
            this.fld_txtGEContainerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEContainerName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEContainerName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEContainerName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEContainerName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEContainerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEContainerName.Screen = null;
            this.fld_txtGEContainerName.Size = new System.Drawing.Size(412, 20);
            this.fld_txtGEContainerName.TabIndex = 1;
            this.fld_txtGEContainerName.Tag = "DC";
            // 
            // fld_txtGEContainerNo
            // 
            this.fld_txtGEContainerNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSDataMember = "GEContainerNo";
            this.fld_txtGEContainerNo.BOSDataSource = "GEContainers";
            this.fld_txtGEContainerNo.BOSDescription = null;
            this.fld_txtGEContainerNo.BOSError = null;
            this.fld_txtGEContainerNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSPropertyName = "Text";
            this.fld_txtGEContainerNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.Location = new System.Drawing.Point(147, 15);
            this.fld_txtGEContainerNo.Name = "fld_txtGEContainerNo";
            this.fld_txtGEContainerNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEContainerNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEContainerNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEContainerNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEContainerNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEContainerNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEContainerNo.Screen = null;
            this.fld_txtGEContainerNo.Size = new System.Drawing.Size(170, 20);
            this.fld_txtGEContainerNo.TabIndex = 0;
            this.fld_txtGEContainerNo.Tag = "DC";
            // 
            // fld_lbPaymentTermNo
            // 
            this.fld_lbPaymentTermNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermNo.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDescription = null;
            this.fld_lbPaymentTermNo.BOSError = null;
            this.fld_lbPaymentTermNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.Location = new System.Drawing.Point(36, 22);
            this.fld_lbPaymentTermNo.Name = "fld_lbPaymentTermNo";
            this.fld_lbPaymentTermNo.Screen = null;
            this.fld_lbPaymentTermNo.Size = new System.Drawing.Size(40, 13);
            this.fld_lbPaymentTermNo.TabIndex = 29;
            this.fld_lbPaymentTermNo.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.Text = "Mã Cont";
            // 
            // fld_lbPaymentTermName
            // 
            this.fld_lbPaymentTermName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTermName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbPaymentTermName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermName.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseFont = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDescription = null;
            this.fld_lbPaymentTermName.BOSError = null;
            this.fld_lbPaymentTermName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.Location = new System.Drawing.Point(36, 48);
            this.fld_lbPaymentTermName.Name = "fld_lbPaymentTermName";
            this.fld_lbPaymentTermName.Screen = null;
            this.fld_lbPaymentTermName.Size = new System.Drawing.Size(44, 13);
            this.fld_lbPaymentTermName.TabIndex = 25;
            this.fld_lbPaymentTermName.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.Text = "Tên Cont";
            // 
            // fld_lbLoai
            // 
            this.fld_lbLoai.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbLoai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbLoai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbLoai.Appearance.Options.UseBackColor = true;
            this.fld_lbLoai.Appearance.Options.UseFont = true;
            this.fld_lbLoai.Appearance.Options.UseForeColor = true;
            this.fld_lbLoai.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSDescription = null;
            this.fld_lbLoai.BOSError = null;
            this.fld_lbLoai.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.Location = new System.Drawing.Point(36, 70);
            this.fld_lbLoai.Name = "fld_lbLoai";
            this.fld_lbLoai.Screen = null;
            this.fld_lbLoai.Size = new System.Drawing.Size(20, 13);
            this.fld_lbLoai.TabIndex = 30;
            this.fld_lbLoai.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.Text = "Loại";
            // 
            // fld_lkeGEContainerType
            // 
            this.fld_lkeGEContainerType.BOSAllowAddNew = false;
            this.fld_lkeGEContainerType.BOSAllowDummy = false;
            this.fld_lkeGEContainerType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSDataMember = "GEContainerType";
            this.fld_lkeGEContainerType.BOSDataSource = "GEContainers";
            this.fld_lkeGEContainerType.BOSDescription = null;
            this.fld_lkeGEContainerType.BOSError = null;
            this.fld_lkeGEContainerType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSPropertyName = "EditValue";
            this.fld_lkeGEContainerType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.CurrentDisplayText = null;
            this.fld_lkeGEContainerType.Location = new System.Drawing.Point(147, 67);
            this.fld_lkeGEContainerType.Name = "fld_lkeGEContainerType";
            this.fld_lkeGEContainerType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeGEContainerType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeGEContainerType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeGEContainerType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeGEContainerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGEContainerType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Loại cont")});
            this.fld_lkeGEContainerType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeGEContainerType.Properties.DropDownRows = 4;
            this.fld_lkeGEContainerType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeGEContainerType.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeGEContainerType.Screen = null;
            this.fld_lkeGEContainerType.Size = new System.Drawing.Size(170, 20);
            this.fld_lkeGEContainerType.TabIndex = 2;
            this.fld_lkeGEContainerType.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(14, 32);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(60, 13);
            this.bosLabel8.TabIndex = 349;
            this.bosLabel8.Text = "Chiều dài(m)";
            // 
            // fld_txtGEContainerHeight
            // 
            this.fld_txtGEContainerHeight.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerHeight.BOSDataMember = "GEContainerHeight";
            this.fld_txtGEContainerHeight.BOSDataSource = "GEContainers";
            this.fld_txtGEContainerHeight.BOSDescription = null;
            this.fld_txtGEContainerHeight.BOSError = null;
            this.fld_txtGEContainerHeight.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerHeight.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerHeight.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerHeight.BOSPropertyName = "Text";
            this.fld_txtGEContainerHeight.EditValue = 0;
            this.fld_txtGEContainerHeight.Location = new System.Drawing.Point(432, 25);
            this.fld_txtGEContainerHeight.Name = "fld_txtGEContainerHeight";
            this.fld_txtGEContainerHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEContainerHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEContainerHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEContainerHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEContainerHeight.Properties.Mask.EditMask = "n";
            this.fld_txtGEContainerHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtGEContainerHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEContainerHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtGEContainerHeight, true);
            this.fld_txtGEContainerHeight.Size = new System.Drawing.Size(75, 20);
            this.fld_txtGEContainerHeight.TabIndex = 347;
            this.fld_txtGEContainerHeight.Tag = "DC";
            this.fld_txtGEContainerHeight.Validated += new System.EventHandler(this.fld_txtGEContainerHeight_Validated);
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtGEContainerWidth);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtGEContainerLenght);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl1.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtGEContainerHeight);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(36, 93);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(523, 89);
            this.fld_grcGroupControl1.TabIndex = 350;
            this.fld_grcGroupControl1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Text = "Kích thước Cont";
            // 
            // fld_txtGEContainerWidth
            // 
            this.fld_txtGEContainerWidth.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerWidth.BOSDataMember = "GEContainerWidth";
            this.fld_txtGEContainerWidth.BOSDataSource = "GEContainers";
            this.fld_txtGEContainerWidth.BOSDescription = null;
            this.fld_txtGEContainerWidth.BOSError = null;
            this.fld_txtGEContainerWidth.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerWidth.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerWidth.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerWidth.BOSPropertyName = "Text";
            this.fld_txtGEContainerWidth.EditValue = 0;
            this.fld_txtGEContainerWidth.Location = new System.Drawing.Point(259, 25);
            this.fld_txtGEContainerWidth.Name = "fld_txtGEContainerWidth";
            this.fld_txtGEContainerWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEContainerWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEContainerWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEContainerWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEContainerWidth.Properties.Mask.EditMask = "n";
            this.fld_txtGEContainerWidth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtGEContainerWidth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEContainerWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtGEContainerWidth, true);
            this.fld_txtGEContainerWidth.Size = new System.Drawing.Size(75, 20);
            this.fld_txtGEContainerWidth.TabIndex = 355;
            this.fld_txtGEContainerWidth.Tag = "DC";
            this.fld_txtGEContainerWidth.Validated += new System.EventHandler(this.fld_txtGEContainerWidth_Validated_1);
            // 
            // fld_txtGEContainerLenght
            // 
            this.fld_txtGEContainerLenght.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerLenght.BOSDataMember = "GEContainerLenght";
            this.fld_txtGEContainerLenght.BOSDataSource = "GEContainers";
            this.fld_txtGEContainerLenght.BOSDescription = null;
            this.fld_txtGEContainerLenght.BOSError = null;
            this.fld_txtGEContainerLenght.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerLenght.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerLenght.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerLenght.BOSPropertyName = "Text";
            this.fld_txtGEContainerLenght.EditValue = 0;
            this.fld_txtGEContainerLenght.Location = new System.Drawing.Point(88, 25);
            this.fld_txtGEContainerLenght.Name = "fld_txtGEContainerLenght";
            this.fld_txtGEContainerLenght.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEContainerLenght.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEContainerLenght.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEContainerLenght.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEContainerLenght.Properties.Mask.EditMask = "n";
            this.fld_txtGEContainerLenght.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtGEContainerLenght.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEContainerLenght.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtGEContainerLenght, true);
            this.fld_txtGEContainerLenght.Size = new System.Drawing.Size(82, 20);
            this.fld_txtGEContainerLenght.TabIndex = 354;
            this.fld_txtGEContainerLenght.Tag = "DC";
            this.fld_txtGEContainerLenght.Validated += new System.EventHandler(this.fld_txtGEContainerLenght_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(14, 58);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(60, 13);
            this.bosLabel3.TabIndex = 353;
            this.bosLabel3.Text = "Thể tích(m3)";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "GEContainerQuantity";
            this.bosTextBox1.BOSDataSource = "GEContainers";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = 0;
            this.bosTextBox1.Location = new System.Drawing.Point(88, 55);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.EditMask = "n";
            this.bosTextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(151, 20);
            this.bosTextBox1.TabIndex = 352;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(363, 32);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(63, 13);
            this.bosLabel2.TabIndex = 351;
            this.bosLabel2.Text = "Chiều cao(m)";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(185, 32);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(68, 13);
            this.bosLabel1.TabIndex = 350;
            this.bosLabel1.Text = "Chiều rộng(m)";
            // 
            // DMCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.fld_txtGEContainerName);
            this.Controls.Add(this.fld_txtGEContainerNo);
            this.Controls.Add(this.fld_lbPaymentTermNo);
            this.Controls.Add(this.fld_lbPaymentTermName);
            this.Controls.Add(this.fld_lbLoai);
            this.Controls.Add(this.fld_lkeGEContainerType);
            this.Name = "DMCC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lkeGEContainerType, 0);
            this.Controls.SetChildIndex(this.fld_lbLoai, 0);
            this.Controls.SetChildIndex(this.fld_lbPaymentTermName, 0);
            this.Controls.SetChildIndex(this.fld_lbPaymentTermNo, 0);
            this.Controls.SetChildIndex(this.fld_txtGEContainerNo, 0);
            this.Controls.SetChildIndex(this.fld_txtGEContainerName, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGEContainerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerLenght.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtGEContainerName;
        private BOSComponent.BOSTextBox fld_txtGEContainerNo;
        private BOSComponent.BOSLabel fld_lbPaymentTermNo;
        private BOSComponent.BOSLabel fld_lbPaymentTermName;
        private BOSComponent.BOSLabel fld_lbLoai;
        private BOSComponent.BOSLookupEdit fld_lkeGEContainerType;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtGEContainerHeight;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox fld_txtGEContainerLenght;
        private BOSComponent.BOSTextBox fld_txtGEContainerWidth;
	}
}
