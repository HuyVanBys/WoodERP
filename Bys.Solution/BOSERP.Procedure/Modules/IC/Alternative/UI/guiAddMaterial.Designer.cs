namespace BOSERP.Modules.Alternative
{
    partial class guiAddMaterial
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductsGridControl = new BOSERP.Modules.Alternative.ICProductsChooseGridControl();
            this.fld_btnFilter1 = new BOSComponent.BOSButton(this.components);
            this.fld_splTicket = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine8 = new BOSComponent.BOSLine(this.components);
            this.fld_bolListAlternative = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICProductAlternatives = new BOSERP.Modules.Alternative.ICAlternativeMaterialsGridControl();
            this.fld_lkeICProductAttributeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMaterialHeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMaterialLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMaterialWidth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMaterialGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMaterialNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMaterialName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).BeginInit();
            this.fld_splTicket.SuspendLayout();
            this.bosLine8.SuspendLayout();
            this.fld_bolListAlternative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAlternatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(1033, 600);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(944, 600);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Lưu";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProductsGridControl
            // 
            this.fld_dgcProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductsGridControl.BOSComment = null;
            this.fld_dgcProductsGridControl.BOSDataMember = null;
            this.fld_dgcProductsGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcProductsGridControl.BOSDescription = null;
            this.fld_dgcProductsGridControl.BOSError = null;
            this.fld_dgcProductsGridControl.BOSFieldGroup = null;
            this.fld_dgcProductsGridControl.BOSFieldRelation = null;
            this.fld_dgcProductsGridControl.BOSGridType = null;
            this.fld_dgcProductsGridControl.BOSPrivilege = null;
            this.fld_dgcProductsGridControl.BOSPropertyName = null;
            this.fld_dgcProductsGridControl.CommodityType = "";
            this.fld_dgcProductsGridControl.isMaterial = false;
            this.fld_dgcProductsGridControl.Location = new System.Drawing.Point(6, 16);
            this.fld_dgcProductsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductsGridControl.Name = "fld_dgcProductsGridControl";
            this.fld_dgcProductsGridControl.PrintReport = false;
            this.fld_dgcProductsGridControl.Screen = null;
            this.fld_dgcProductsGridControl.Size = new System.Drawing.Size(659, 475);
            this.fld_dgcProductsGridControl.TabIndex = 2;
            this.fld_dgcProductsGridControl.Tag = "";
            // 
            // fld_btnFilter1
            // 
            this.fld_btnFilter1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_btnFilter1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnFilter1.Appearance.Options.UseFont = true;
            this.fld_btnFilter1.Appearance.Options.UseForeColor = true;
            this.fld_btnFilter1.BOSComment = "";
            this.fld_btnFilter1.BOSDataMember = "";
            this.fld_btnFilter1.BOSDataSource = "";
            this.fld_btnFilter1.BOSDescription = null;
            this.fld_btnFilter1.BOSError = null;
            this.fld_btnFilter1.BOSFieldGroup = "";
            this.fld_btnFilter1.BOSFieldRelation = "";
            this.fld_btnFilter1.BOSPrivilege = "";
            this.fld_btnFilter1.BOSPropertyName = "";
            this.fld_btnFilter1.Location = new System.Drawing.Point(688, 57);
            this.fld_btnFilter1.Name = "fld_btnFilter1";
            this.fld_btnFilter1.Screen = null;
            this.fld_btnFilter1.Size = new System.Drawing.Size(75, 27);
            this.fld_btnFilter1.TabIndex = 44;
            this.fld_btnFilter1.Tag = "";
            this.fld_btnFilter1.Text = "Tìm kiếm";
            this.fld_btnFilter1.Click += new System.EventHandler(this.Fld_btnFilter1_Click);
            // 
            // fld_splTicket
            // 
            this.fld_splTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_splTicket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_splTicket.Location = new System.Drawing.Point(3, 89);
            this.fld_splTicket.Name = "fld_splTicket";
            this.fld_splTicket.Panel1.Controls.Add(this.bosLine8);
            this.fld_splTicket.Panel1.Text = "Panel1";
            this.fld_splTicket.Panel2.Controls.Add(this.fld_bolListAlternative);
            this.fld_splTicket.Panel2.Text = "Panel2";
            this.fld_splTicket.Size = new System.Drawing.Size(1120, 505);
            this.fld_splTicket.SplitterPosition = 672;
            this.fld_splTicket.TabIndex = 412;
            this.fld_splTicket.Text = "splitContainerControl2";
            // 
            // bosLine8
            // 
            this.bosLine8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine8.BOSComment = null;
            this.bosLine8.BOSDataMember = null;
            this.bosLine8.BOSDataSource = null;
            this.bosLine8.BOSDescription = null;
            this.bosLine8.BOSError = null;
            this.bosLine8.BOSFieldGroup = null;
            this.bosLine8.BOSFieldRelation = null;
            this.bosLine8.BOSPrivilege = null;
            this.bosLine8.BOSPropertyName = null;
            this.bosLine8.Controls.Add(this.fld_dgcProductsGridControl);
            this.bosLine8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine8.Location = new System.Drawing.Point(0, 3);
            this.bosLine8.Name = "bosLine8";
            this.bosLine8.Screen = null;
            this.bosLine8.Size = new System.Drawing.Size(671, 497);
            this.bosLine8.TabIndex = 407;
            this.bosLine8.TabStop = false;
            this.bosLine8.Text = "Danh sách vật tư";
            // 
            // fld_bolListAlternative
            // 
            this.fld_bolListAlternative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_bolListAlternative.BOSComment = null;
            this.fld_bolListAlternative.BOSDataMember = null;
            this.fld_bolListAlternative.BOSDataSource = null;
            this.fld_bolListAlternative.BOSDescription = null;
            this.fld_bolListAlternative.BOSError = null;
            this.fld_bolListAlternative.BOSFieldGroup = null;
            this.fld_bolListAlternative.BOSFieldRelation = null;
            this.fld_bolListAlternative.BOSPrivilege = null;
            this.fld_bolListAlternative.BOSPropertyName = null;
            this.fld_bolListAlternative.Controls.Add(this.fld_dgcICProductAlternatives);
            this.fld_bolListAlternative.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolListAlternative.Location = new System.Drawing.Point(0, 3);
            this.fld_bolListAlternative.Name = "fld_bolListAlternative";
            this.fld_bolListAlternative.Screen = null;
            this.fld_bolListAlternative.Size = new System.Drawing.Size(438, 497);
            this.fld_bolListAlternative.TabIndex = 405;
            this.fld_bolListAlternative.TabStop = false;
            this.fld_bolListAlternative.Text = "Chi tiết thay thế";
            // 
            // fld_dgcICProductAlternatives
            // 
            this.fld_dgcICProductAlternatives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductAlternatives.BOSComment = null;
            this.fld_dgcICProductAlternatives.BOSDataMember = null;
            this.fld_dgcICProductAlternatives.BOSDataSource = "ICProductAlternatives";
            this.fld_dgcICProductAlternatives.BOSDescription = null;
            this.fld_dgcICProductAlternatives.BOSError = null;
            this.fld_dgcICProductAlternatives.BOSFieldGroup = null;
            this.fld_dgcICProductAlternatives.BOSFieldRelation = null;
            this.fld_dgcICProductAlternatives.BOSGridType = null;
            this.fld_dgcICProductAlternatives.BOSPrivilege = null;
            this.fld_dgcICProductAlternatives.BOSPropertyName = null;
            this.fld_dgcICProductAlternatives.CommodityType = "";
            this.fld_dgcICProductAlternatives.Location = new System.Drawing.Point(6, 16);
            this.fld_dgcICProductAlternatives.MenuManager = this.screenToolbar;
            this.fld_dgcICProductAlternatives.Name = "fld_dgcICProductAlternatives";
            this.fld_dgcICProductAlternatives.PrintReport = false;
            this.fld_dgcICProductAlternatives.Screen = null;
            this.fld_dgcICProductAlternatives.Size = new System.Drawing.Size(430, 475);
            this.fld_dgcICProductAlternatives.TabIndex = 3;
            this.fld_dgcICProductAlternatives.TabStop = false;
            // 
            // fld_lkeICProductAttributeID
            // 
            this.fld_lkeICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeICProductAttributeID.BOSAllowDummy = true;
            this.fld_lkeICProductAttributeID.BOSComment = null;
            this.fld_lkeICProductAttributeID.BOSDataMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.BOSDataSource = "ICProductAttributes";
            this.fld_lkeICProductAttributeID.BOSDescription = null;
            this.fld_lkeICProductAttributeID.BOSError = null;
            this.fld_lkeICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductAttributeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductAttributeID.BOSSelectTypeValue = "WoodType;AddMaterial;COLOR;HTType";
            this.fld_lkeICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeICProductAttributeID.Location = new System.Drawing.Point(351, 38);
            this.fld_lkeICProductAttributeID.Name = "fld_lkeICProductAttributeID";
            this.fld_lkeICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã loại gỗ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên loại gỗ")});
            this.fld_lkeICProductAttributeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductAttributeID.Properties.NullText = "";
            this.fld_lkeICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductAttributeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductAttributeID, true);
            this.fld_lkeICProductAttributeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductAttributeID.TabIndex = 427;
            this.fld_lkeICProductAttributeID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(272, 41);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(34, 13);
            this.bosLabel13.TabIndex = 428;
            this.bosLabel13.Text = "Loại NL";
            // 
            // fld_lkeICProductType
            // 
            this.fld_lkeICProductType.BOSAllowAddNew = false;
            this.fld_lkeICProductType.BOSAllowDummy = true;
            this.fld_lkeICProductType.BOSComment = null;
            this.fld_lkeICProductType.BOSDataMember = "ICProductType";
            this.fld_lkeICProductType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductType.BOSDescription = null;
            this.fld_lkeICProductType.BOSError = null;
            this.fld_lkeICProductType.BOSFieldGroup = null;
            this.fld_lkeICProductType.BOSFieldParent = null;
            this.fld_lkeICProductType.BOSFieldRelation = null;
            this.fld_lkeICProductType.BOSPrivilege = null;
            this.fld_lkeICProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductType.BOSSelectType = null;
            this.fld_lkeICProductType.BOSSelectTypeValue = null;
            this.fld_lkeICProductType.CurrentDisplayText = null;
            this.fld_lkeICProductType.Location = new System.Drawing.Point(93, 38);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = "";
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.fld_lkeICProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductType.TabIndex = 425;
            this.fld_lkeICProductType.Tag = "DC";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.BOSComment = null;
            this.fld_lblLabel17.BOSDataMember = null;
            this.fld_lblLabel17.BOSDataSource = null;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = null;
            this.fld_lblLabel17.BOSFieldRelation = null;
            this.fld_lblLabel17.BOSPrivilege = null;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(14, 41);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel17.TabIndex = 426;
            this.fld_lblLabel17.Text = "Loại vật tư";
            // 
            // fld_txtMaterialHeight
            // 
            this.fld_txtMaterialHeight.BOSComment = "";
            this.fld_txtMaterialHeight.BOSDataMember = "";
            this.fld_txtMaterialHeight.BOSDataSource = "";
            this.fld_txtMaterialHeight.BOSDescription = null;
            this.fld_txtMaterialHeight.BOSError = null;
            this.fld_txtMaterialHeight.BOSFieldGroup = "";
            this.fld_txtMaterialHeight.BOSFieldRelation = "";
            this.fld_txtMaterialHeight.BOSPrivilege = "";
            this.fld_txtMaterialHeight.BOSPropertyName = "Text";
            this.fld_txtMaterialHeight.Location = new System.Drawing.Point(615, 64);
            this.fld_txtMaterialHeight.Name = "fld_txtMaterialHeight";
            this.fld_txtMaterialHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMaterialHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMaterialHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMaterialHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMaterialHeight.Properties.Mask.EditMask = "n";
            this.fld_txtMaterialHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMaterialHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMaterialHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMaterialHeight, true);
            this.fld_txtMaterialHeight.Size = new System.Drawing.Size(63, 20);
            this.fld_txtMaterialHeight.TabIndex = 421;
            this.fld_txtMaterialHeight.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(529, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(42, 13);
            this.bosLabel9.TabIndex = 422;
            this.bosLabel9.Text = "Dài (mm)";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(529, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 423;
            this.bosLabel10.Text = "Rộng (mm)";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(529, 67);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(74, 13);
            this.bosLabel11.TabIndex = 424;
            this.bosLabel11.Text = "Cao / dày (mm)";
            // 
            // fld_txtMaterialLength
            // 
            this.fld_txtMaterialLength.BOSComment = "";
            this.fld_txtMaterialLength.BOSDataMember = "";
            this.fld_txtMaterialLength.BOSDataSource = "";
            this.fld_txtMaterialLength.BOSDescription = null;
            this.fld_txtMaterialLength.BOSError = null;
            this.fld_txtMaterialLength.BOSFieldGroup = "";
            this.fld_txtMaterialLength.BOSFieldRelation = "";
            this.fld_txtMaterialLength.BOSPrivilege = "";
            this.fld_txtMaterialLength.BOSPropertyName = "Text";
            this.fld_txtMaterialLength.Location = new System.Drawing.Point(615, 38);
            this.fld_txtMaterialLength.Name = "fld_txtMaterialLength";
            this.fld_txtMaterialLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMaterialLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMaterialLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMaterialLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMaterialLength.Properties.Mask.EditMask = "n";
            this.fld_txtMaterialLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMaterialLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMaterialLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMaterialLength, true);
            this.fld_txtMaterialLength.Size = new System.Drawing.Size(63, 20);
            this.fld_txtMaterialLength.TabIndex = 419;
            this.fld_txtMaterialLength.Tag = "DC";
            // 
            // fld_txtMaterialWidth
            // 
            this.fld_txtMaterialWidth.BOSComment = "";
            this.fld_txtMaterialWidth.BOSDataMember = "ICProductWidth";
            this.fld_txtMaterialWidth.BOSDataSource = "ICProducts";
            this.fld_txtMaterialWidth.BOSDescription = null;
            this.fld_txtMaterialWidth.BOSError = null;
            this.fld_txtMaterialWidth.BOSFieldGroup = "";
            this.fld_txtMaterialWidth.BOSFieldRelation = "";
            this.fld_txtMaterialWidth.BOSPrivilege = "";
            this.fld_txtMaterialWidth.BOSPropertyName = "Text";
            this.fld_txtMaterialWidth.Location = new System.Drawing.Point(615, 12);
            this.fld_txtMaterialWidth.Name = "fld_txtMaterialWidth";
            this.fld_txtMaterialWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMaterialWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMaterialWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMaterialWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMaterialWidth.Properties.Mask.EditMask = null;
            this.fld_txtMaterialWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMaterialWidth, false);
            this.fld_txtMaterialWidth.Size = new System.Drawing.Size(63, 20);
            this.fld_txtMaterialWidth.TabIndex = 420;
            this.fld_txtMaterialWidth.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(14, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(54, 13);
            this.bosLabel12.TabIndex = 418;
            this.bosLabel12.Text = "Nhóm hàng";
            // 
            // fld_lkeMaterialGroup
            // 
            this.fld_lkeMaterialGroup.BOSAllowAddNew = false;
            this.fld_lkeMaterialGroup.BOSAllowDummy = true;
            this.fld_lkeMaterialGroup.BOSComment = null;
            this.fld_lkeMaterialGroup.BOSDataMember = "ICProductGroupID";
            this.fld_lkeMaterialGroup.BOSDataSource = "ICProductGroups";
            this.fld_lkeMaterialGroup.BOSDescription = null;
            this.fld_lkeMaterialGroup.BOSError = null;
            this.fld_lkeMaterialGroup.BOSFieldGroup = null;
            this.fld_lkeMaterialGroup.BOSFieldParent = null;
            this.fld_lkeMaterialGroup.BOSFieldRelation = null;
            this.fld_lkeMaterialGroup.BOSPrivilege = null;
            this.fld_lkeMaterialGroup.BOSPropertyName = null;
            this.fld_lkeMaterialGroup.BOSSelectType = "";
            this.fld_lkeMaterialGroup.BOSSelectTypeValue = "";
            this.fld_lkeMaterialGroup.CurrentDisplayText = null;
            this.fld_lkeMaterialGroup.Location = new System.Drawing.Point(93, 64);
            this.fld_lkeMaterialGroup.MenuManager = this.screenToolbar;
            this.fld_lkeMaterialGroup.Name = "fld_lkeMaterialGroup";
            this.fld_lkeMaterialGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMaterialGroup.Properties.ColumnName = null;
            this.fld_lkeMaterialGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Tên")});
            this.fld_lkeMaterialGroup.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeMaterialGroup.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeMaterialGroup.Screen = null;
            this.fld_lkeMaterialGroup.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMaterialGroup.TabIndex = 417;
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(14, 15);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(63, 13);
            this.bosLabel17.TabIndex = 415;
            this.bosLabel17.Text = "Mã sản phẩm";
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(272, 15);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(67, 13);
            this.bosLabel18.TabIndex = 416;
            this.bosLabel18.Text = "Tên sản phẩm";
            // 
            // fld_txtMaterialNo
            // 
            this.fld_txtMaterialNo.BOSComment = null;
            this.fld_txtMaterialNo.BOSDataMember = null;
            this.fld_txtMaterialNo.BOSDataSource = null;
            this.fld_txtMaterialNo.BOSDescription = null;
            this.fld_txtMaterialNo.BOSError = null;
            this.fld_txtMaterialNo.BOSFieldGroup = null;
            this.fld_txtMaterialNo.BOSFieldRelation = null;
            this.fld_txtMaterialNo.BOSPrivilege = null;
            this.fld_txtMaterialNo.BOSPropertyName = null;
            this.fld_txtMaterialNo.Location = new System.Drawing.Point(93, 12);
            this.fld_txtMaterialNo.MenuManager = this.screenToolbar;
            this.fld_txtMaterialNo.Name = "fld_txtMaterialNo";
            this.fld_txtMaterialNo.Screen = null;
            this.fld_txtMaterialNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMaterialNo.TabIndex = 413;
            // 
            // fld_txtMaterialName
            // 
            this.fld_txtMaterialName.BOSComment = null;
            this.fld_txtMaterialName.BOSDataMember = null;
            this.fld_txtMaterialName.BOSDataSource = null;
            this.fld_txtMaterialName.BOSDescription = null;
            this.fld_txtMaterialName.BOSError = null;
            this.fld_txtMaterialName.BOSFieldGroup = null;
            this.fld_txtMaterialName.BOSFieldRelation = null;
            this.fld_txtMaterialName.BOSPrivilege = null;
            this.fld_txtMaterialName.BOSPropertyName = null;
            this.fld_txtMaterialName.Location = new System.Drawing.Point(351, 12);
            this.fld_txtMaterialName.MenuManager = this.screenToolbar;
            this.fld_txtMaterialName.Name = "fld_txtMaterialName";
            this.fld_txtMaterialName.Screen = null;
            this.fld_txtMaterialName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMaterialName.TabIndex = 414;
            // 
            // guiAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(1128, 635);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeICProductAttributeID);
            this.Controls.Add(this.bosLabel13);
            this.Controls.Add(this.fld_lkeICProductType);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_txtMaterialHeight);
            this.Controls.Add(this.bosLabel9);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.fld_txtMaterialLength);
            this.Controls.Add(this.fld_txtMaterialWidth);
            this.Controls.Add(this.bosLabel12);
            this.Controls.Add(this.fld_lkeMaterialGroup);
            this.Controls.Add(this.bosLabel17);
            this.Controls.Add(this.bosLabel18);
            this.Controls.Add(this.fld_txtMaterialNo);
            this.Controls.Add(this.fld_txtMaterialName);
            this.Controls.Add(this.fld_splTicket);
            this.Controls.Add(this.fld_btnFilter1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAddMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiAddMaterial_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnFilter1, 0);
            this.Controls.SetChildIndex(this.fld_splTicket, 0);
            this.Controls.SetChildIndex(this.fld_txtMaterialName, 0);
            this.Controls.SetChildIndex(this.fld_txtMaterialNo, 0);
            this.Controls.SetChildIndex(this.bosLabel18, 0);
            this.Controls.SetChildIndex(this.bosLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lkeMaterialGroup, 0);
            this.Controls.SetChildIndex(this.bosLabel12, 0);
            this.Controls.SetChildIndex(this.fld_txtMaterialWidth, 0);
            this.Controls.SetChildIndex(this.fld_txtMaterialLength, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.bosLabel9, 0);
            this.Controls.SetChildIndex(this.fld_txtMaterialHeight, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductType, 0);
            this.Controls.SetChildIndex(this.bosLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductAttributeID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).EndInit();
            this.fld_splTicket.ResumeLayout(false);
            this.bosLine8.ResumeLayout(false);
            this.fld_bolListAlternative.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAlternatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSERP.Modules.Alternative.ICProductsChooseGridControl fld_dgcProductsGridControl;
        private BOSComponent.BOSButton fld_btnFilter1;
        private DevExpress.XtraEditors.SplitContainerControl fld_splTicket;
        private BOSComponent.BOSLine bosLine8;
        private BOSComponent.BOSLine fld_bolListAlternative;
        public ICAlternativeMaterialsGridControl fld_dgcICProductAlternatives;
        private BOSComponent.BOSLookupEdit fld_lkeICProductAttributeID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtMaterialHeight;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtMaterialLength;
        private BOSComponent.BOSTextBox fld_txtMaterialWidth;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeMaterialGroup;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtMaterialNo;
        private BOSComponent.BOSTextBox fld_txtMaterialName;
    }
}