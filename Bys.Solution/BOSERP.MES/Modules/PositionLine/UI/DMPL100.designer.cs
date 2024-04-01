using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PositionLine.UI
{
	/// <summary>
	/// Summary description for DMLM100
	/// </summary>
	partial class DMPL100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPL100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtMMPositionHeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMPositionWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMPositionLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_bedGELocationName = new BOSComponent.BOSButtonEdit(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMPositionSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMPositionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMPositionName = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionName.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(946, 596);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionHeight);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionWidth);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionLength);
            this.fld_grcGroupControl.Controls.Add(this.fld_bedGELocationName);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionSymbol);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionNo);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionName);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(943, 572);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_txtMMPositionHeight
            // 
            this.fld_txtMMPositionHeight.BOSComment = "";
            this.fld_txtMMPositionHeight.BOSDataMember = "MMPositionHeight";
            this.fld_txtMMPositionHeight.BOSDataSource = "MMPositions";
            this.fld_txtMMPositionHeight.BOSDescription = null;
            this.fld_txtMMPositionHeight.BOSError = null;
            this.fld_txtMMPositionHeight.BOSFieldGroup = "";
            this.fld_txtMMPositionHeight.BOSFieldRelation = "";
            this.fld_txtMMPositionHeight.BOSPrivilege = "";
            this.fld_txtMMPositionHeight.BOSPropertyName = "Text";
            this.fld_txtMMPositionHeight.Location = new System.Drawing.Point(675, 58);
            this.fld_txtMMPositionHeight.Name = "fld_txtMMPositionHeight";
            this.fld_txtMMPositionHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionHeight.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtMMPositionHeight.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtMMPositionHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionHeight, true);
            this.fld_txtMMPositionHeight.Size = new System.Drawing.Size(83, 20);
            this.fld_txtMMPositionHeight.TabIndex = 118;
            this.fld_txtMMPositionHeight.Tag = "DC";
            // 
            // fld_txtMMPositionWidth
            // 
            this.fld_txtMMPositionWidth.BOSComment = "";
            this.fld_txtMMPositionWidth.BOSDataMember = "MMPositionWidth";
            this.fld_txtMMPositionWidth.BOSDataSource = "MMPositions";
            this.fld_txtMMPositionWidth.BOSDescription = null;
            this.fld_txtMMPositionWidth.BOSError = null;
            this.fld_txtMMPositionWidth.BOSFieldGroup = "";
            this.fld_txtMMPositionWidth.BOSFieldRelation = "";
            this.fld_txtMMPositionWidth.BOSPrivilege = "";
            this.fld_txtMMPositionWidth.BOSPropertyName = "Text";
            this.fld_txtMMPositionWidth.Location = new System.Drawing.Point(586, 58);
            this.fld_txtMMPositionWidth.Name = "fld_txtMMPositionWidth";
            this.fld_txtMMPositionWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionWidth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionWidth.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtMMPositionWidth.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtMMPositionWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionWidth, true);
            this.fld_txtMMPositionWidth.Size = new System.Drawing.Size(83, 20);
            this.fld_txtMMPositionWidth.TabIndex = 117;
            this.fld_txtMMPositionWidth.Tag = "DC";
            // 
            // fld_txtMMPositionLength
            // 
            this.fld_txtMMPositionLength.BOSComment = "";
            this.fld_txtMMPositionLength.BOSDataMember = "MMPositionLength";
            this.fld_txtMMPositionLength.BOSDataSource = "MMPositions";
            this.fld_txtMMPositionLength.BOSDescription = null;
            this.fld_txtMMPositionLength.BOSError = null;
            this.fld_txtMMPositionLength.BOSFieldGroup = "";
            this.fld_txtMMPositionLength.BOSFieldRelation = "";
            this.fld_txtMMPositionLength.BOSPrivilege = "";
            this.fld_txtMMPositionLength.BOSPropertyName = "Text";
            this.fld_txtMMPositionLength.Location = new System.Drawing.Point(497, 58);
            this.fld_txtMMPositionLength.Name = "fld_txtMMPositionLength";
            this.fld_txtMMPositionLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionLength.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtMMPositionLength.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtMMPositionLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionLength, true);
            this.fld_txtMMPositionLength.Size = new System.Drawing.Size(83, 20);
            this.fld_txtMMPositionLength.TabIndex = 116;
            this.fld_txtMMPositionLength.Tag = "DC";
            // 
            // fld_bedGELocationName
            // 
            this.fld_bedGELocationName.BOSComment = null;
            this.fld_bedGELocationName.BOSDataMember = "MMPositionGELocationName";
            this.fld_bedGELocationName.BOSDataSource = "MMPositions";
            this.fld_bedGELocationName.BOSDescription = null;
            this.fld_bedGELocationName.BOSError = null;
            this.fld_bedGELocationName.BOSFieldGroup = null;
            this.fld_bedGELocationName.BOSFieldRelation = null;
            this.fld_bedGELocationName.BOSPrivilege = null;
            this.fld_bedGELocationName.BOSPropertyName = "Text";
            this.fld_bedGELocationName.Location = new System.Drawing.Point(497, 84);
            this.fld_bedGELocationName.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName.Name = "fld_bedGELocationName";
            this.fld_bedGELocationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName.Properties.ReadOnly = true;
            this.fld_bedGELocationName.Screen = null;
            this.fld_bedGELocationName.Size = new System.Drawing.Size(261, 20);
            this.fld_bedGELocationName.TabIndex = 111;
            this.fld_bedGELocationName.Tag = "DC";
            this.fld_bedGELocationName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName_ButtonClick);
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMPositionLevel";
            this.bosTextBox2.BOSDataSource = "MMPositions";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(497, 32);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(83, 20);
            this.bosTextBox2.TabIndex = 109;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(343, 35);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(26, 13);
            this.bosLabel5.TabIndex = 108;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Level";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(343, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(22, 13);
            this.bosLabel4.TabIndex = 107;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Vị trí";
            // 
            // fld_txtMMPositionSymbol
            // 
            this.fld_txtMMPositionSymbol.BOSComment = "";
            this.fld_txtMMPositionSymbol.BOSDataMember = "MMPositionSymbol";
            this.fld_txtMMPositionSymbol.BOSDataSource = "MMPositions";
            this.fld_txtMMPositionSymbol.BOSDescription = null;
            this.fld_txtMMPositionSymbol.BOSError = "";
            this.fld_txtMMPositionSymbol.BOSFieldGroup = "";
            this.fld_txtMMPositionSymbol.BOSFieldRelation = "";
            this.fld_txtMMPositionSymbol.BOSPrivilege = "";
            this.fld_txtMMPositionSymbol.BOSPropertyName = "Text";
            this.fld_txtMMPositionSymbol.Location = new System.Drawing.Point(90, 84);
            this.fld_txtMMPositionSymbol.Name = "fld_txtMMPositionSymbol";
            this.fld_txtMMPositionSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPositionSymbol.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionSymbol, true);
            this.fld_txtMMPositionSymbol.Size = new System.Drawing.Size(197, 20);
            this.fld_txtMMPositionSymbol.TabIndex = 106;
            this.fld_txtMMPositionSymbol.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(26, 87);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(35, 13);
            this.bosLabel3.TabIndex = 102;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Ký hiệu";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(26, 35);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 99;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã xưởng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(343, 61);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(145, 13);
            this.bosLabel2.TabIndex = 97;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Kích thước (Dài x Rộng x Cao)";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(26, 61);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(51, 13);
            this.bosLabel1.TabIndex = 97;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên xưởng";
            // 
            // fld_txtMMPositionNo
            // 
            this.fld_txtMMPositionNo.BOSComment = "";
            this.fld_txtMMPositionNo.BOSDataMember = "MMPositionNo";
            this.fld_txtMMPositionNo.BOSDataSource = "MMPositions";
            this.fld_txtMMPositionNo.BOSDescription = null;
            this.fld_txtMMPositionNo.BOSError = "";
            this.fld_txtMMPositionNo.BOSFieldGroup = "";
            this.fld_txtMMPositionNo.BOSFieldRelation = "";
            this.fld_txtMMPositionNo.BOSPrivilege = "";
            this.fld_txtMMPositionNo.BOSPropertyName = "Text";
            this.fld_txtMMPositionNo.Location = new System.Drawing.Point(90, 32);
            this.fld_txtMMPositionNo.Name = "fld_txtMMPositionNo";
            this.fld_txtMMPositionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPositionNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionNo, true);
            this.fld_txtMMPositionNo.Size = new System.Drawing.Size(197, 20);
            this.fld_txtMMPositionNo.TabIndex = 0;
            this.fld_txtMMPositionNo.Tag = "DC";
            // 
            // fld_txtMMPositionName
            // 
            this.fld_txtMMPositionName.BOSComment = "";
            this.fld_txtMMPositionName.BOSDataMember = "MMPositionName";
            this.fld_txtMMPositionName.BOSDataSource = "MMPositions";
            this.fld_txtMMPositionName.BOSDescription = null;
            this.fld_txtMMPositionName.BOSError = "";
            this.fld_txtMMPositionName.BOSFieldGroup = "";
            this.fld_txtMMPositionName.BOSFieldRelation = "";
            this.fld_txtMMPositionName.BOSPrivilege = "";
            this.fld_txtMMPositionName.BOSPropertyName = "Text";
            this.fld_txtMMPositionName.Location = new System.Drawing.Point(90, 58);
            this.fld_txtMMPositionName.Name = "fld_txtMMPositionName";
            this.fld_txtMMPositionName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPositionName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionName, true);
            this.fld_txtMMPositionName.Size = new System.Drawing.Size(197, 20);
            this.fld_txtMMPositionName.TabIndex = 1;
            this.fld_txtMMPositionName.Tag = "DC";
            // 
            // DMPL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(946, 596);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPL100.IconOptions.Icon")));
            this.Name = "DMPL100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMPositionNo;
        private BOSComponent.BOSTextBox fld_txtMMPositionName;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtMMPositionSymbol;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName;
        private BOSComponent.BOSTextBox fld_txtMMPositionHeight;
        private BOSComponent.BOSTextBox fld_txtMMPositionWidth;
        private BOSComponent.BOSTextBox fld_txtMMPositionLength;
    }
}
