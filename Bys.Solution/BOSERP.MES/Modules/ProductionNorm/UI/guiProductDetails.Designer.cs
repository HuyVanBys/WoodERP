namespace BOSERP.Modules.ProductionNorm.UI
{
    partial class guiProductDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiProductDetails));
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_kleICProductIdentifyFinishing = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductHeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductWidth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductIdentifyWoodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_kleICProductIdentifyColor = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyFinishing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(12, 195);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 386;
            this.bosLabel4.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Text = "Hoàn thiện";
            this.bosLabel4.Visible = false;
            // 
            // fld_kleICProductIdentifyFinishing
            // 
            this.fld_kleICProductIdentifyFinishing.BOSAllowAddNew = false;
            this.fld_kleICProductIdentifyFinishing.BOSAllowDummy = false;
            this.fld_kleICProductIdentifyFinishing.BOSComment = null;
            this.fld_kleICProductIdentifyFinishing.BOSDataMember = "ICProductAttributeID";
            this.fld_kleICProductIdentifyFinishing.BOSDataSource = "ICProductAttributes";
            this.fld_kleICProductIdentifyFinishing.BOSDescription = null;
            this.fld_kleICProductIdentifyFinishing.BOSError = null;
            this.fld_kleICProductIdentifyFinishing.BOSFieldGroup = null;
            this.fld_kleICProductIdentifyFinishing.BOSFieldParent = null;
            this.fld_kleICProductIdentifyFinishing.BOSFieldRelation = null;
            this.fld_kleICProductIdentifyFinishing.BOSPrivilege = null;
            this.fld_kleICProductIdentifyFinishing.BOSPropertyName = "EditValue";
            this.fld_kleICProductIdentifyFinishing.BOSSelectType = "ICProductAttributeGroup";
            this.fld_kleICProductIdentifyFinishing.BOSSelectTypeValue = "HTType";
            this.fld_kleICProductIdentifyFinishing.CurrentDisplayText = null;
            this.fld_kleICProductIdentifyFinishing.Location = new System.Drawing.Point(110, 192);
            this.fld_kleICProductIdentifyFinishing.MenuManager = this.screenToolbar;
            this.fld_kleICProductIdentifyFinishing.Name = "fld_kleICProductIdentifyFinishing";
            this.fld_kleICProductIdentifyFinishing.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_kleICProductIdentifyFinishing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_kleICProductIdentifyFinishing.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên")});
            this.fld_kleICProductIdentifyFinishing.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_kleICProductIdentifyFinishing.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_kleICProductIdentifyFinishing.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_kleICProductIdentifyFinishing.Properties.ValueMember = "ICProductAttributeID";
            this.fld_kleICProductIdentifyFinishing.Screen = null;
            this.fld_kleICProductIdentifyFinishing.Size = new System.Drawing.Size(132, 20);
            this.fld_kleICProductIdentifyFinishing.TabIndex = 385;
            this.fld_kleICProductIdentifyFinishing.Tag = "DC";
            this.fld_kleICProductIdentifyFinishing.Visible = false;
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseFont = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel15.BOSDataMember = "ICProductNo";
            this.fld_lblLabel15.BOSDataSource = "ICProducts";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel15.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel15.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel15.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel15.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel15.TabIndex = 384;
            this.fld_lblLabel15.Tag =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel15.Text = "Mã sản phẩm";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductNo.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo.BOSDataSource = "ICProducts";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = null;
            this.fld_txtICProductNo.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductNo.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductNo.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.EditValue =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductNo.Location = new System.Drawing.Point(110, 9);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(192, 20);
            this.fld_txtICProductNo.TabIndex = 383;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_txtICProductHeight
            // 
            this.fld_txtICProductHeight.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductHeight.BOSDataMember = "ICProductHeight";
            this.fld_txtICProductHeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductHeight.BOSDescription = null;
            this.fld_txtICProductHeight.BOSError = null;
            this.fld_txtICProductHeight.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductHeight.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductHeight.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductHeight.BOSPropertyName = "Text";
            this.fld_txtICProductHeight.Location = new System.Drawing.Point(247, 161);
            this.fld_txtICProductHeight.Name = "fld_txtICProductHeight";
            this.fld_txtICProductHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductHeight.Properties.Mask.EditMask = "n";
            this.fld_txtICProductHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductHeight, true);
            this.fld_txtICProductHeight.Size = new System.Drawing.Size(63, 20);
            this.fld_txtICProductHeight.TabIndex = 381;
            this.fld_txtICProductHeight.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 164);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(72, 13);
            this.bosLabel8.TabIndex = 382;
            this.bosLabel8.Text = "W x D x H(mm)";
            // 
            // fld_txtICProductLength
            // 
            this.fld_txtICProductLength.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductLength.BOSDataMember = "ICProductLength";
            this.fld_txtICProductLength.BOSDataSource = "ICProducts";
            this.fld_txtICProductLength.BOSDescription = null;
            this.fld_txtICProductLength.BOSError = null;
            this.fld_txtICProductLength.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductLength.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductLength.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductLength.BOSPropertyName = "Text";
            this.fld_txtICProductLength.Location = new System.Drawing.Point(179, 161);
            this.fld_txtICProductLength.Name = "fld_txtICProductLength";
            this.fld_txtICProductLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLength.Properties.Mask.EditMask = "n";
            this.fld_txtICProductLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductLength, true);
            this.fld_txtICProductLength.Size = new System.Drawing.Size(63, 20);
            this.fld_txtICProductLength.TabIndex = 380;
            this.fld_txtICProductLength.Tag = "DC";
            // 
            // fld_txtICProductWidth
            // 
            this.fld_txtICProductWidth.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductWidth.BOSDataMember = "ICProductWidth";
            this.fld_txtICProductWidth.BOSDataSource = "ICProducts";
            this.fld_txtICProductWidth.BOSDescription = null;
            this.fld_txtICProductWidth.BOSError = null;
            this.fld_txtICProductWidth.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductWidth.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductWidth.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductWidth.BOSPropertyName = "Text";
            this.fld_txtICProductWidth.Location = new System.Drawing.Point(110, 161);
            this.fld_txtICProductWidth.Name = "fld_txtICProductWidth";
            this.fld_txtICProductWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWidth.Properties.Mask.EditMask = null;
            this.fld_txtICProductWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWidth, false);
            this.fld_txtICProductWidth.Size = new System.Drawing.Size(63, 20);
            this.fld_txtICProductWidth.TabIndex = 379;
            this.fld_txtICProductWidth.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(12, 135);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(41, 13);
            this.bosLabel3.TabIndex = 378;
            this.bosLabel3.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.Text = "Màu sơn";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(12, 109);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(35, 13);
            this.bosLabel1.TabIndex = 377;
            this.bosLabel1.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.Text = "Loại nguyên liệu";
            // 
            // fld_lkeICProductIdentifyWoodType
            // 
            this.fld_lkeICProductIdentifyWoodType.BOSAllowAddNew = false;
            this.fld_lkeICProductIdentifyWoodType.BOSAllowDummy = false;
            this.fld_lkeICProductIdentifyWoodType.BOSComment = null;
            this.fld_lkeICProductIdentifyWoodType.BOSDataMember = "ICProductAttributeID";
            this.fld_lkeICProductIdentifyWoodType.BOSDataSource = "ICProductAttributes";
            this.fld_lkeICProductIdentifyWoodType.BOSDescription = null;
            this.fld_lkeICProductIdentifyWoodType.BOSError = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldGroup = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldParent = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldRelation = null;
            this.fld_lkeICProductIdentifyWoodType.BOSPrivilege = null;
            this.fld_lkeICProductIdentifyWoodType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductIdentifyWoodType.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductIdentifyWoodType.BOSSelectTypeValue = "WoodType";
            this.fld_lkeICProductIdentifyWoodType.CurrentDisplayText = null;
            this.fld_lkeICProductIdentifyWoodType.Location = new System.Drawing.Point(110, 106);
            this.fld_lkeICProductIdentifyWoodType.Name = "fld_lkeICProductIdentifyWoodType";
            this.fld_lkeICProductIdentifyWoodType.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeICProductIdentifyWoodType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductIdentifyWoodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIdentifyWoodType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã loại NL"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên loại NL")});
            this.fld_lkeICProductIdentifyWoodType.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductIdentifyWoodType.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductIdentifyWoodType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductIdentifyWoodType.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductIdentifyWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductIdentifyWoodType, true);
            this.fld_lkeICProductIdentifyWoodType.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeICProductIdentifyWoodType.TabIndex = 375;
            this.fld_lkeICProductIdentifyWoodType.Tag = "DC";
            // 
            // fld_kleICProductIdentifyColor
            // 
            this.fld_kleICProductIdentifyColor.BOSAllowAddNew = false;
            this.fld_kleICProductIdentifyColor.BOSAllowDummy = false;
            this.fld_kleICProductIdentifyColor.BOSComment = null;
            this.fld_kleICProductIdentifyColor.BOSDataMember = "ICProductAttributeID";
            this.fld_kleICProductIdentifyColor.BOSDataSource = "ICProductAttributes";
            this.fld_kleICProductIdentifyColor.BOSDescription = null;
            this.fld_kleICProductIdentifyColor.BOSError = null;
            this.fld_kleICProductIdentifyColor.BOSFieldGroup = null;
            this.fld_kleICProductIdentifyColor.BOSFieldParent = null;
            this.fld_kleICProductIdentifyColor.BOSFieldRelation = null;
            this.fld_kleICProductIdentifyColor.BOSPrivilege = null;
            this.fld_kleICProductIdentifyColor.BOSPropertyName = "EditValue";
            this.fld_kleICProductIdentifyColor.BOSSelectType = "ICProductAttributeGroup";
            this.fld_kleICProductIdentifyColor.BOSSelectTypeValue = "COLOR";
            this.fld_kleICProductIdentifyColor.CurrentDisplayText = null;
            this.fld_kleICProductIdentifyColor.Location = new System.Drawing.Point(110, 132);
            this.fld_kleICProductIdentifyColor.MenuManager = this.screenToolbar;
            this.fld_kleICProductIdentifyColor.Name = "fld_kleICProductIdentifyColor";
            this.fld_kleICProductIdentifyColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_kleICProductIdentifyColor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeAbbreviation", "Tên viết tắt")});
            this.fld_kleICProductIdentifyColor.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_kleICProductIdentifyColor.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_kleICProductIdentifyColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_kleICProductIdentifyColor.Properties.ValueMember = "ICProductAttributeID";
            this.fld_kleICProductIdentifyColor.Screen = null;
            this.fld_kleICProductIdentifyColor.Size = new System.Drawing.Size(132, 20);
            this.fld_kleICProductIdentifyColor.TabIndex = 376;
            this.fld_kleICProductIdentifyColor.Tag = "DC";
            // 
            // fld_txtICProductName
            // 
            this.fld_txtICProductName.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductName.BOSDataMember = "ICProductName";
            this.fld_txtICProductName.BOSDataSource = "ICProducts";
            this.fld_txtICProductName.BOSDescription = null;
            this.fld_txtICProductName.BOSError = null;
            this.fld_txtICProductName.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductName.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductName.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductName.BOSPropertyName = "Text";
            this.fld_txtICProductName.EditValue =global::Localization.MESLocalizedResources.String1;
            this.fld_txtICProductName.Location = new System.Drawing.Point(110, 37);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.fld_txtICProductName.Size = new System.Drawing.Size(193, 20);
            this.fld_txtICProductName.TabIndex = 373;
            this.fld_txtICProductName.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(12, 40);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 374;
            this.bosLabel2.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Text = "Tên sản phẩm";
            // 
            // fld_lblLabel21
            // 
            this.fld_lblLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel21.Appearance.Options.UseFont = true;
            this.fld_lblLabel21.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel21.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.BOSDescription = null;
            this.fld_lblLabel21.BOSError = null;
            this.fld_lblLabel21.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.Location = new System.Drawing.Point(12, 66);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel21.TabIndex = 372;
            this.fld_lblLabel21.Tag =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel21.Text = "Mô tả";
            // 
            // fld_medICProductDesc
            // 
            this.fld_medICProductDesc.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_medICProductDesc.BOSDataMember = "ICProductDesc";
            this.fld_medICProductDesc.BOSDataSource = "ICProducts";
            this.fld_medICProductDesc.BOSDescription = null;
            this.fld_medICProductDesc.BOSError = null;
            this.fld_medICProductDesc.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_medICProductDesc.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_medICProductDesc.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_medICProductDesc.BOSPropertyName = "Text";
            this.fld_medICProductDesc.EditValue =global::Localization.MESLocalizedResources.String1;
            this.fld_medICProductDesc.Location = new System.Drawing.Point(110, 63);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Screen = null;
            this.fld_medICProductDesc.Size = new System.Drawing.Size(297, 37);
            this.fld_medICProductDesc.TabIndex = 371;
            this.fld_medICProductDesc.Tag = "DC";
            // 
            // guiProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 216);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_kleICProductIdentifyFinishing);
            this.Controls.Add(this.fld_lblLabel15);
            this.Controls.Add(this.fld_txtICProductNo);
            this.Controls.Add(this.fld_txtICProductHeight);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_txtICProductLength);
            this.Controls.Add(this.fld_txtICProductWidth);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeICProductIdentifyWoodType);
            this.Controls.Add(this.fld_kleICProductIdentifyColor);
            this.Controls.Add(this.fld_txtICProductName);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel21);
            this.Controls.Add(this.fld_medICProductDesc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.guiProductDetails_Load);
            this.Controls.SetChildIndex(this.fld_medICProductDesc, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel21, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductName, 0);
            this.Controls.SetChildIndex(this.fld_kleICProductIdentifyColor, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductIdentifyWoodType, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductWidth, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductLength, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductHeight, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel15, 0);
            this.Controls.SetChildIndex(this.fld_kleICProductIdentifyFinishing, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyFinishing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_kleICProductIdentifyFinishing;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSTextBox fld_txtICProductHeight;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICProductLength;
        private BOSComponent.BOSTextBox fld_txtICProductWidth;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIdentifyWoodType;
        private BOSComponent.BOSLookupEdit fld_kleICProductIdentifyColor;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSMemoEdit fld_medICProductDesc;

    }
}