using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Alternative.UI
{
    /// <summary>
    /// Summary description for DMAL100
    /// </summary>
    partial class DMAL100
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
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtICProductHeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductWidth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSemiNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtSemiName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCarcassNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCarcassName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFilter1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductSemi = new BOSERP.Modules.Alternative.ICSemiProductsGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel5 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabProductList = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICProductMaterial = new BOSERP.Modules.Alternative.ICMaterialProductsGridControl();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcMaterialAlternatives = new BOSERP.Modules.Alternative.ICAlternativeMaterialsGridControl();
            this.fld_btnSaveMaterial = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
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
            this.fld_btnFilterMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_tabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_splTicket = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine8 = new BOSComponent.BOSLine(this.components);
            this.bosLine9 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICProductAlternatives = new BOSERP.Modules.Alternative.ICAlternativeProductsGridControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCarcassNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCarcassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSemi)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            this.bosPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductList)).BeginInit();
            this.fld_tabProductList.SuspendLayout();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMaterial)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialAlternatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialName.Properties)).BeginInit();
            this.fld_tabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).BeginInit();
            this.fld_splTicket.SuspendLayout();
            this.bosLine8.SuspendLayout();
            this.bosLine9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAlternatives)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "";
            this.fld_grcGroupControl5.BOSDataMember = "";
            this.fld_grcGroupControl5.BOSDataSource = "";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "";
            this.fld_grcGroupControl5.BOSFieldRelation = "";
            this.fld_grcGroupControl5.BOSPrivilege = "";
            this.fld_grcGroupControl5.BOSPropertyName = "";
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductHeight);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductLength);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductWidth);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel35);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductGroup);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtSemiNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtSemiName);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtCarcassNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtCarcassName);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnFilter1);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(1096, 103);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin tìm kiếm";
            // 
            // fld_txtICProductHeight
            // 
            this.fld_txtICProductHeight.BOSComment = "";
            this.fld_txtICProductHeight.BOSDataMember = "ICProductHeight";
            this.fld_txtICProductHeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductHeight.BOSDescription = null;
            this.fld_txtICProductHeight.BOSError = null;
            this.fld_txtICProductHeight.BOSFieldGroup = "";
            this.fld_txtICProductHeight.BOSFieldRelation = "";
            this.fld_txtICProductHeight.BOSPrivilege = "";
            this.fld_txtICProductHeight.BOSPropertyName = "Text";
            this.fld_txtICProductHeight.Location = new System.Drawing.Point(587, 23);
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
            this.fld_txtICProductHeight.TabIndex = 42;
            this.fld_txtICProductHeight.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(529, 78);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(42, 13);
            this.bosLabel7.TabIndex = 43;
            this.bosLabel7.Text = "Dài (mm)";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(529, 52);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 43;
            this.bosLabel5.Text = "Rộng (mm)";
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
            this.bosLabel8.Location = new System.Drawing.Point(529, 26);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 43;
            this.bosLabel8.Text = "Dày (mm)";
            // 
            // fld_txtICProductLength
            // 
            this.fld_txtICProductLength.BOSComment = "";
            this.fld_txtICProductLength.BOSDataMember = "ICProductLength";
            this.fld_txtICProductLength.BOSDataSource = "ICProducts";
            this.fld_txtICProductLength.BOSDescription = null;
            this.fld_txtICProductLength.BOSError = null;
            this.fld_txtICProductLength.BOSFieldGroup = "";
            this.fld_txtICProductLength.BOSFieldRelation = "";
            this.fld_txtICProductLength.BOSPrivilege = "";
            this.fld_txtICProductLength.BOSPropertyName = "Text";
            this.fld_txtICProductLength.Location = new System.Drawing.Point(587, 75);
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
            this.fld_txtICProductLength.TabIndex = 40;
            this.fld_txtICProductLength.Tag = "DC";
            // 
            // fld_txtICProductWidth
            // 
            this.fld_txtICProductWidth.BOSComment = "";
            this.fld_txtICProductWidth.BOSDataMember = "ICProductWidth";
            this.fld_txtICProductWidth.BOSDataSource = "ICProducts";
            this.fld_txtICProductWidth.BOSDescription = null;
            this.fld_txtICProductWidth.BOSError = null;
            this.fld_txtICProductWidth.BOSFieldGroup = "";
            this.fld_txtICProductWidth.BOSFieldRelation = "";
            this.fld_txtICProductWidth.BOSPrivilege = "";
            this.fld_txtICProductWidth.BOSPropertyName = "Text";
            this.fld_txtICProductWidth.Location = new System.Drawing.Point(587, 49);
            this.fld_txtICProductWidth.Name = "fld_txtICProductWidth";
            this.fld_txtICProductWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWidth.Properties.Mask.EditMask = null;
            this.fld_txtICProductWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWidth, false);
            this.fld_txtICProductWidth.Size = new System.Drawing.Size(63, 20);
            this.fld_txtICProductWidth.TabIndex = 41;
            this.fld_txtICProductWidth.Tag = "DC";
            // 
            // bosLabel35
            // 
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(9, 78);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(54, 13);
            this.bosLabel35.TabIndex = 38;
            this.bosLabel35.Text = "Nhóm hàng";
            // 
            // fld_lkeICProductGroup
            // 
            this.fld_lkeICProductGroup.BOSAllowAddNew = false;
            this.fld_lkeICProductGroup.BOSAllowDummy = true;
            this.fld_lkeICProductGroup.BOSComment = null;
            this.fld_lkeICProductGroup.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroup.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroup.BOSDescription = null;
            this.fld_lkeICProductGroup.BOSError = null;
            this.fld_lkeICProductGroup.BOSFieldGroup = null;
            this.fld_lkeICProductGroup.BOSFieldParent = null;
            this.fld_lkeICProductGroup.BOSFieldRelation = null;
            this.fld_lkeICProductGroup.BOSPrivilege = null;
            this.fld_lkeICProductGroup.BOSPropertyName = null;
            this.fld_lkeICProductGroup.BOSSelectType = "FK_ICDepartmentID";
            this.fld_lkeICProductGroup.BOSSelectTypeValue = "1";
            this.fld_lkeICProductGroup.CurrentDisplayText = null;
            this.fld_lkeICProductGroup.Location = new System.Drawing.Point(88, 75);
            this.fld_lkeICProductGroup.MenuManager = this.screenToolbar;
            this.fld_lkeICProductGroup.Name = "fld_lkeICProductGroup";
            this.fld_lkeICProductGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroup.Properties.ColumnName = null;
            this.fld_lkeICProductGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Tên")});
            this.fld_lkeICProductGroup.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroup.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroup.Screen = null;
            this.fld_lkeICProductGroup.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductGroup.TabIndex = 37;
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
            this.bosLabel2.Location = new System.Drawing.Point(9, 26);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(63, 13);
            this.bosLabel2.TabIndex = 24;
            this.bosLabel2.Text = "Mã sản phẩm";
            // 
            // fld_txtSemiNo
            // 
            this.fld_txtSemiNo.BOSComment = null;
            this.fld_txtSemiNo.BOSDataMember = null;
            this.fld_txtSemiNo.BOSDataSource = null;
            this.fld_txtSemiNo.BOSDescription = null;
            this.fld_txtSemiNo.BOSError = null;
            this.fld_txtSemiNo.BOSFieldGroup = null;
            this.fld_txtSemiNo.BOSFieldRelation = null;
            this.fld_txtSemiNo.BOSPrivilege = null;
            this.fld_txtSemiNo.BOSPropertyName = null;
            this.fld_txtSemiNo.Location = new System.Drawing.Point(88, 49);
            this.fld_txtSemiNo.MenuManager = this.screenToolbar;
            this.fld_txtSemiNo.Name = "fld_txtSemiNo";
            this.fld_txtSemiNo.Screen = null;
            this.fld_txtSemiNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtSemiNo.TabIndex = 25;
            // 
            // fld_txtSemiName
            // 
            this.fld_txtSemiName.BOSComment = null;
            this.fld_txtSemiName.BOSDataMember = null;
            this.fld_txtSemiName.BOSDataSource = null;
            this.fld_txtSemiName.BOSDescription = null;
            this.fld_txtSemiName.BOSError = null;
            this.fld_txtSemiName.BOSFieldGroup = null;
            this.fld_txtSemiName.BOSFieldRelation = null;
            this.fld_txtSemiName.BOSPrivilege = null;
            this.fld_txtSemiName.BOSPropertyName = null;
            this.fld_txtSemiName.Location = new System.Drawing.Point(346, 49);
            this.fld_txtSemiName.MenuManager = this.screenToolbar;
            this.fld_txtSemiName.Name = "fld_txtSemiName";
            this.fld_txtSemiName.Screen = null;
            this.fld_txtSemiName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtSemiName.TabIndex = 27;
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(267, 26);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(67, 13);
            this.bosLabel4.TabIndex = 26;
            this.bosLabel4.Text = "Tên sản phẩm";
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
            this.bosLabel1.Location = new System.Drawing.Point(9, 52);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(35, 13);
            this.bosLabel1.TabIndex = 20;
            this.bosLabel1.Text = "Mã BTP";
            // 
            // fld_txtCarcassNo
            // 
            this.fld_txtCarcassNo.BOSComment = null;
            this.fld_txtCarcassNo.BOSDataMember = null;
            this.fld_txtCarcassNo.BOSDataSource = null;
            this.fld_txtCarcassNo.BOSDescription = null;
            this.fld_txtCarcassNo.BOSError = null;
            this.fld_txtCarcassNo.BOSFieldGroup = null;
            this.fld_txtCarcassNo.BOSFieldRelation = null;
            this.fld_txtCarcassNo.BOSPrivilege = null;
            this.fld_txtCarcassNo.BOSPropertyName = null;
            this.fld_txtCarcassNo.Location = new System.Drawing.Point(88, 23);
            this.fld_txtCarcassNo.MenuManager = this.screenToolbar;
            this.fld_txtCarcassNo.Name = "fld_txtCarcassNo";
            this.fld_txtCarcassNo.Screen = null;
            this.fld_txtCarcassNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCarcassNo.TabIndex = 21;
            // 
            // fld_txtCarcassName
            // 
            this.fld_txtCarcassName.BOSComment = null;
            this.fld_txtCarcassName.BOSDataMember = null;
            this.fld_txtCarcassName.BOSDataSource = null;
            this.fld_txtCarcassName.BOSDescription = null;
            this.fld_txtCarcassName.BOSError = null;
            this.fld_txtCarcassName.BOSFieldGroup = null;
            this.fld_txtCarcassName.BOSFieldRelation = null;
            this.fld_txtCarcassName.BOSPrivilege = null;
            this.fld_txtCarcassName.BOSPropertyName = null;
            this.fld_txtCarcassName.Location = new System.Drawing.Point(346, 23);
            this.fld_txtCarcassName.MenuManager = this.screenToolbar;
            this.fld_txtCarcassName.Name = "fld_txtCarcassName";
            this.fld_txtCarcassName.Screen = null;
            this.fld_txtCarcassName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCarcassName.TabIndex = 23;
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
            this.bosLabel3.Location = new System.Drawing.Point(267, 52);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 22;
            this.bosLabel3.Text = "Tên BTP";
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
            this.fld_btnFilter1.Location = new System.Drawing.Point(679, 71);
            this.fld_btnFilter1.Name = "fld_btnFilter1";
            this.fld_btnFilter1.Screen = null;
            this.fld_btnFilter1.Size = new System.Drawing.Size(75, 27);
            this.fld_btnFilter1.TabIndex = 8;
            this.fld_btnFilter1.Tag = "";
            this.fld_btnFilter1.Text = "Tìm kiếm";
            this.fld_btnFilter1.Click += new System.EventHandler(this.fld_btnFilter1_Click);
            // 
            // fld_dgcICProductSemi
            // 
            this.fld_dgcICProductSemi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductSemi.BOSComment = null;
            this.fld_dgcICProductSemi.BOSDataMember = null;
            this.fld_dgcICProductSemi.BOSDataSource = "ICProductAlternatives";
            this.fld_dgcICProductSemi.BOSDescription = null;
            this.fld_dgcICProductSemi.BOSError = null;
            this.fld_dgcICProductSemi.BOSFieldGroup = null;
            this.fld_dgcICProductSemi.BOSFieldRelation = null;
            this.fld_dgcICProductSemi.BOSGridType = null;
            this.fld_dgcICProductSemi.BOSPrivilege = null;
            this.fld_dgcICProductSemi.BOSPropertyName = null;
            this.fld_dgcICProductSemi.CommodityType = "";
            this.fld_dgcICProductSemi.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcICProductSemi.MenuManager = this.screenToolbar;
            this.fld_dgcICProductSemi.Name = "fld_dgcICProductSemi";
            this.fld_dgcICProductSemi.PrintReport = false;
            this.fld_dgcICProductSemi.Screen = null;
            this.fld_dgcICProductSemi.Size = new System.Drawing.Size(659, 463);
            this.fld_dgcICProductSemi.TabIndex = 1;
            this.fld_dgcICProductSemi.TabStop = false;
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
            this.bosPanel1.Controls.Add(this.bosPanel3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1111, 673);
            this.bosPanel1.TabIndex = 9;
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.bosPanel5);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(1111, 673);
            this.bosPanel3.TabIndex = 7;
            // 
            // bosPanel5
            // 
            this.bosPanel5.BOSComment = null;
            this.bosPanel5.BOSDataMember = null;
            this.bosPanel5.BOSDataSource = null;
            this.bosPanel5.BOSDescription = null;
            this.bosPanel5.BOSError = null;
            this.bosPanel5.BOSFieldGroup = null;
            this.bosPanel5.BOSFieldRelation = null;
            this.bosPanel5.BOSPrivilege = null;
            this.bosPanel5.BOSPropertyName = null;
            this.bosPanel5.Controls.Add(this.fld_tabProductList);
            this.bosPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel5.Location = new System.Drawing.Point(0, 0);
            this.bosPanel5.Name = "bosPanel5";
            this.bosPanel5.Screen = null;
            this.bosPanel5.Size = new System.Drawing.Size(1111, 673);
            this.bosPanel5.TabIndex = 0;
            // 
            // fld_tabProductList
            // 
            this.fld_tabProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductList.BOSComment = null;
            this.fld_tabProductList.BOSDataMember = null;
            this.fld_tabProductList.BOSDataSource = null;
            this.fld_tabProductList.BOSDescription = null;
            this.fld_tabProductList.BOSError = null;
            this.fld_tabProductList.BOSFieldGroup = null;
            this.fld_tabProductList.BOSFieldRelation = null;
            this.fld_tabProductList.BOSPrivilege = null;
            this.fld_tabProductList.BOSPropertyName = null;
            this.fld_tabProductList.Location = new System.Drawing.Point(3, 3);
            this.fld_tabProductList.Name = "fld_tabProductList";
            this.fld_tabProductList.Screen = null;
            this.fld_tabProductList.SelectedTabPage = this.fld_tabMaterial;
            this.fld_tabProductList.Size = new System.Drawing.Size(1108, 667);
            this.fld_tabProductList.TabIndex = 20;
            this.fld_tabProductList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabMaterial,
            this.fld_tabSemiProduct});
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.splitContainerControl1);
            this.fld_tabMaterial.Controls.Add(this.bosGroupControl1);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(1102, 639);
            this.fld_tabMaterial.Text = "Vật tư";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 104);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosLine1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.bosLine2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1102, 535);
            this.splitContainerControl1.SplitterPosition = 672;
            this.splitContainerControl1.TabIndex = 412;
            this.splitContainerControl1.Text = "splitContainerControl2";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcICProductMaterial);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(0, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(671, 527);
            this.bosLine1.TabIndex = 407;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Danh sách vật tư";
            // 
            // fld_dgcICProductMaterial
            // 
            this.fld_dgcICProductMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductMaterial.BOSComment = null;
            this.fld_dgcICProductMaterial.BOSDataMember = null;
            this.fld_dgcICProductMaterial.BOSDataSource = "ICProductAlternatives";
            this.fld_dgcICProductMaterial.BOSDescription = null;
            this.fld_dgcICProductMaterial.BOSError = null;
            this.fld_dgcICProductMaterial.BOSFieldGroup = null;
            this.fld_dgcICProductMaterial.BOSFieldRelation = null;
            this.fld_dgcICProductMaterial.BOSGridType = null;
            this.fld_dgcICProductMaterial.BOSPrivilege = null;
            this.fld_dgcICProductMaterial.BOSPropertyName = null;
            this.fld_dgcICProductMaterial.CommodityType = "";
            this.fld_dgcICProductMaterial.Location = new System.Drawing.Point(6, 16);
            this.fld_dgcICProductMaterial.MenuManager = this.screenToolbar;
            this.fld_dgcICProductMaterial.Name = "fld_dgcICProductMaterial";
            this.fld_dgcICProductMaterial.PrintReport = false;
            this.fld_dgcICProductMaterial.Screen = null;
            this.fld_dgcICProductMaterial.Size = new System.Drawing.Size(659, 479);
            this.fld_dgcICProductMaterial.TabIndex = 1;
            this.fld_dgcICProductMaterial.TabStop = false;
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcMaterialAlternatives);
            this.bosLine2.Controls.Add(this.fld_btnSaveMaterial);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(0, 3);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(420, 527);
            this.bosLine2.TabIndex = 405;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Chi tiết vật tư thay thế";
            // 
            // fld_dgcMaterialAlternatives
            // 
            this.fld_dgcMaterialAlternatives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMaterialAlternatives.BOSComment = null;
            this.fld_dgcMaterialAlternatives.BOSDataMember = null;
            this.fld_dgcMaterialAlternatives.BOSDataSource = "ICProductAlternatives";
            this.fld_dgcMaterialAlternatives.BOSDescription = null;
            this.fld_dgcMaterialAlternatives.BOSError = null;
            this.fld_dgcMaterialAlternatives.BOSFieldGroup = null;
            this.fld_dgcMaterialAlternatives.BOSFieldRelation = null;
            this.fld_dgcMaterialAlternatives.BOSGridType = null;
            this.fld_dgcMaterialAlternatives.BOSPrivilege = null;
            this.fld_dgcMaterialAlternatives.BOSPropertyName = null;
            this.fld_dgcMaterialAlternatives.CommodityType = "";
            this.fld_dgcMaterialAlternatives.Location = new System.Drawing.Point(6, 16);
            this.fld_dgcMaterialAlternatives.MenuManager = this.screenToolbar;
            this.fld_dgcMaterialAlternatives.Name = "fld_dgcMaterialAlternatives";
            this.fld_dgcMaterialAlternatives.PrintReport = false;
            this.fld_dgcMaterialAlternatives.Screen = null;
            this.fld_dgcMaterialAlternatives.Size = new System.Drawing.Size(408, 479);
            this.fld_dgcMaterialAlternatives.TabIndex = 2;
            this.fld_dgcMaterialAlternatives.TabStop = false;
            // 
            // fld_btnSaveMaterial
            // 
            this.fld_btnSaveMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveMaterial.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_btnSaveMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnSaveMaterial.Appearance.Options.UseFont = true;
            this.fld_btnSaveMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnSaveMaterial.BOSComment = "";
            this.fld_btnSaveMaterial.BOSDataMember = "";
            this.fld_btnSaveMaterial.BOSDataSource = "";
            this.fld_btnSaveMaterial.BOSDescription = null;
            this.fld_btnSaveMaterial.BOSError = null;
            this.fld_btnSaveMaterial.BOSFieldGroup = "";
            this.fld_btnSaveMaterial.BOSFieldRelation = "";
            this.fld_btnSaveMaterial.BOSPrivilege = "";
            this.fld_btnSaveMaterial.BOSPropertyName = "";
            this.fld_btnSaveMaterial.Location = new System.Drawing.Point(339, 498);
            this.fld_btnSaveMaterial.Name = "fld_btnSaveMaterial";
            this.fld_btnSaveMaterial.Screen = null;
            this.fld_btnSaveMaterial.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSaveMaterial.TabIndex = 8;
            this.fld_btnSaveMaterial.Tag = "";
            this.fld_btnSaveMaterial.Text = "Lưu";
            this.fld_btnSaveMaterial.Click += new System.EventHandler(this.fld_btnSaveMaterial_Click);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = "";
            this.bosGroupControl1.BOSDataSource = "";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = "";
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = "";
            this.bosGroupControl1.Controls.Add(this.fld_lkeICProductAttributeID);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.fld_lkeICProductType);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_txtMaterialHeight);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.fld_txtMaterialLength);
            this.bosGroupControl1.Controls.Add(this.fld_txtMaterialWidth);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_lkeMaterialGroup);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.fld_txtMaterialNo);
            this.bosGroupControl1.Controls.Add(this.fld_txtMaterialName);
            this.bosGroupControl1.Controls.Add(this.fld_btnFilterMaterial);
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1102, 103);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "Thông tin tìm kiếm";
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
            this.fld_lkeICProductAttributeID.Location = new System.Drawing.Point(346, 49);
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
            this.fld_lkeICProductAttributeID.TabIndex = 342;
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
            this.bosLabel13.Location = new System.Drawing.Point(267, 52);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(34, 13);
            this.bosLabel13.TabIndex = 343;
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
            this.fld_lkeICProductType.Location = new System.Drawing.Point(88, 49);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = "";
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.fld_lkeICProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductType.TabIndex = 335;
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(9, 52);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel17.TabIndex = 336;
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
            this.fld_txtMaterialHeight.Location = new System.Drawing.Point(610, 75);
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
            this.fld_txtMaterialHeight.TabIndex = 42;
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
            this.bosLabel9.Location = new System.Drawing.Point(524, 52);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(42, 13);
            this.bosLabel9.TabIndex = 43;
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
            this.bosLabel10.Location = new System.Drawing.Point(524, 26);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 43;
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
            this.bosLabel11.Location = new System.Drawing.Point(524, 78);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(74, 13);
            this.bosLabel11.TabIndex = 43;
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
            this.fld_txtMaterialLength.Location = new System.Drawing.Point(610, 49);
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
            this.fld_txtMaterialLength.TabIndex = 40;
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
            this.fld_txtMaterialWidth.Location = new System.Drawing.Point(610, 23);
            this.fld_txtMaterialWidth.Name = "fld_txtMaterialWidth";
            this.fld_txtMaterialWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMaterialWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMaterialWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMaterialWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMaterialWidth.Properties.Mask.EditMask = null;
            this.fld_txtMaterialWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMaterialWidth, false);
            this.fld_txtMaterialWidth.Size = new System.Drawing.Size(63, 20);
            this.fld_txtMaterialWidth.TabIndex = 41;
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
            this.bosLabel12.Location = new System.Drawing.Point(9, 78);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(54, 13);
            this.bosLabel12.TabIndex = 38;
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
            this.fld_lkeMaterialGroup.Location = new System.Drawing.Point(88, 75);
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
            this.fld_lkeMaterialGroup.TabIndex = 37;
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
            this.bosLabel17.Location = new System.Drawing.Point(9, 26);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(63, 13);
            this.bosLabel17.TabIndex = 24;
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
            this.bosLabel18.Location = new System.Drawing.Point(267, 26);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(67, 13);
            this.bosLabel18.TabIndex = 26;
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
            this.fld_txtMaterialNo.Location = new System.Drawing.Point(88, 23);
            this.fld_txtMaterialNo.MenuManager = this.screenToolbar;
            this.fld_txtMaterialNo.Name = "fld_txtMaterialNo";
            this.fld_txtMaterialNo.Screen = null;
            this.fld_txtMaterialNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMaterialNo.TabIndex = 21;
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
            this.fld_txtMaterialName.Location = new System.Drawing.Point(346, 23);
            this.fld_txtMaterialName.MenuManager = this.screenToolbar;
            this.fld_txtMaterialName.Name = "fld_txtMaterialName";
            this.fld_txtMaterialName.Screen = null;
            this.fld_txtMaterialName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMaterialName.TabIndex = 23;
            // 
            // fld_btnFilterMaterial
            // 
            this.fld_btnFilterMaterial.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_btnFilterMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnFilterMaterial.Appearance.Options.UseFont = true;
            this.fld_btnFilterMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnFilterMaterial.BOSComment = "";
            this.fld_btnFilterMaterial.BOSDataMember = "";
            this.fld_btnFilterMaterial.BOSDataSource = "";
            this.fld_btnFilterMaterial.BOSDescription = null;
            this.fld_btnFilterMaterial.BOSError = null;
            this.fld_btnFilterMaterial.BOSFieldGroup = "";
            this.fld_btnFilterMaterial.BOSFieldRelation = "";
            this.fld_btnFilterMaterial.BOSPrivilege = "";
            this.fld_btnFilterMaterial.BOSPropertyName = "";
            this.fld_btnFilterMaterial.Location = new System.Drawing.Point(685, 68);
            this.fld_btnFilterMaterial.Name = "fld_btnFilterMaterial";
            this.fld_btnFilterMaterial.Screen = null;
            this.fld_btnFilterMaterial.Size = new System.Drawing.Size(75, 27);
            this.fld_btnFilterMaterial.TabIndex = 8;
            this.fld_btnFilterMaterial.Tag = "";
            this.fld_btnFilterMaterial.Text = "Tìm kiếm";
            this.fld_btnFilterMaterial.Click += new System.EventHandler(this.fld_btnFilterMaterial_Click);
            // 
            // fld_tabSemiProduct
            // 
            this.fld_tabSemiProduct.Controls.Add(this.fld_splTicket);
            this.fld_tabSemiProduct.Controls.Add(this.fld_grcGroupControl5);
            this.fld_tabSemiProduct.Name = "fld_tabSemiProduct";
            this.fld_tabSemiProduct.Size = new System.Drawing.Size(1102, 639);
            this.fld_tabSemiProduct.Text = "Bán thành phẩm";
            // 
            // fld_splTicket
            // 
            this.fld_splTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_splTicket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_splTicket.Location = new System.Drawing.Point(3, 112);
            this.fld_splTicket.Name = "fld_splTicket";
            this.fld_splTicket.Panel1.Controls.Add(this.bosLine8);
            this.fld_splTicket.Panel1.Text = "Panel1";
            this.fld_splTicket.Panel2.Controls.Add(this.bosLine9);
            this.fld_splTicket.Panel2.Text = "Panel2";
            this.fld_splTicket.Size = new System.Drawing.Size(1096, 523);
            this.fld_splTicket.SplitterPosition = 672;
            this.fld_splTicket.TabIndex = 411;
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
            this.bosLine8.Controls.Add(this.fld_dgcICProductSemi);
            this.bosLine8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine8.Location = new System.Drawing.Point(0, 3);
            this.bosLine8.Name = "bosLine8";
            this.bosLine8.Screen = null;
            this.bosLine8.Size = new System.Drawing.Size(671, 515);
            this.bosLine8.TabIndex = 407;
            this.bosLine8.TabStop = false;
            this.bosLine8.Text = "Danh sách bán thành phẩm";
            // 
            // bosLine9
            // 
            this.bosLine9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine9.BOSComment = null;
            this.bosLine9.BOSDataMember = null;
            this.bosLine9.BOSDataSource = null;
            this.bosLine9.BOSDescription = null;
            this.bosLine9.BOSError = null;
            this.bosLine9.BOSFieldGroup = null;
            this.bosLine9.BOSFieldRelation = null;
            this.bosLine9.BOSPrivilege = null;
            this.bosLine9.BOSPropertyName = null;
            this.bosLine9.Controls.Add(this.fld_dgcICProductAlternatives);
            this.bosLine9.Controls.Add(this.fld_btnSave);
            this.bosLine9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine9.Location = new System.Drawing.Point(0, 3);
            this.bosLine9.Name = "bosLine9";
            this.bosLine9.Screen = null;
            this.bosLine9.Size = new System.Drawing.Size(414, 515);
            this.bosLine9.TabIndex = 405;
            this.bosLine9.TabStop = false;
            this.bosLine9.Text = "Chi tiết bán thành phẩm thay thế";
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
            this.fld_dgcICProductAlternatives.Size = new System.Drawing.Size(402, 467);
            this.fld_dgcICProductAlternatives.TabIndex = 2;
            this.fld_dgcICProductAlternatives.TabStop = false;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_btnSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnSave.Appearance.Options.UseFont = true;
            this.fld_btnSave.Appearance.Options.UseForeColor = true;
            this.fld_btnSave.BOSComment = "";
            this.fld_btnSave.BOSDataMember = "";
            this.fld_btnSave.BOSDataSource = "";
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = "";
            this.fld_btnSave.BOSFieldRelation = "";
            this.fld_btnSave.BOSPrivilege = "";
            this.fld_btnSave.BOSPropertyName = "";
            this.fld_btnSave.Location = new System.Drawing.Point(333, 486);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 8;
            this.fld_btnSave.Tag = "";
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.Fld_btnSave_Click);
            // 
            // DMAL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1111, 673);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAL100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSemiName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCarcassNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCarcassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSemi)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel3.ResumeLayout(false);
            this.bosPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductList)).EndInit();
            this.fld_tabProductList.ResumeLayout(false);
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMaterial)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialAlternatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaterialName.Properties)).EndInit();
            this.fld_tabSemiProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_splTicket)).EndInit();
            this.fld_splTicket.ResumeLayout(false);
            this.bosLine8.ResumeLayout(false);
            this.bosLine9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAlternatives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private IContainer components;
        private BOSComponent.BOSButton fld_btnFilter1;
        private ICSemiProductsGridControl fld_dgcICProductSemi;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSPanel bosPanel5;
        private BOSComponent.BOSTabControl fld_tabProductList;
        private DevExpress.XtraTab.XtraTabPage fld_tabSemiProduct;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtCarcassNo;
        private BOSComponent.BOSTextBox fld_txtCarcassName;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroup;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtSemiNo;
        private BOSComponent.BOSTextBox fld_txtSemiName;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductHeight;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICProductLength;
        private BOSComponent.BOSTextBox fld_txtICProductWidth;
        private DevExpress.XtraEditors.SplitContainerControl fld_splTicket;
        private BOSComponent.BOSLine bosLine8;
        private BOSComponent.BOSLine bosLine9;
        private ICAlternativeProductsGridControl fld_dgcICProductAlternatives;
        private BOSComponent.BOSButton fld_btnSave;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSLine bosLine1;
        private ICMaterialProductsGridControl fld_dgcICProductMaterial;
        private BOSComponent.BOSLine bosLine2;
        private ICAlternativeMaterialsGridControl fld_dgcMaterialAlternatives;
        private BOSComponent.BOSButton fld_btnSaveMaterial;
        private BOSComponent.BOSGroupControl bosGroupControl1;
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
        private BOSComponent.BOSButton fld_btnFilterMaterial;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeICProductAttributeID;
        private BOSComponent.BOSLabel bosLabel13;
    }
}
