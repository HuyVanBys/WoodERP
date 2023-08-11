using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Promotion.UI
{
	/// <summary>
	/// Summary description for DMPR100
	/// </summary>
	partial class DMPR100
    {
		private BOSComponent.BOSMemoEdit fld_medICPromotionDesc1;
		private BOSComponent.BOSDateEdit fld_dteICPromotionStartDate1;
		private BOSComponent.BOSDateEdit fld_dteICPromotionEndDate1;
		private BOSComponent.BOSLabel fld_lblLabel37;
		private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel39;
		private BOSComponent.BOSTextBox fld_txtICPromotionNo1;
		private BOSComponent.BOSTextBox fld_txtICPromotionName1;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLookupEdit fld_lkeICPromotionTypeCombo;
		private BOSComponent.BOSLabel fld_lblFoward;
		private BOSComponent.BOSLabel fld_lblMiddle;
		private ICPromotionItemsGridControl fld_dgcICPromotionItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICPromotionItems;
		private BOSComponent.BOSTextBox fld_txtICPromotionDiscountPercent;
		private BOSComponent.BOSTextBox fld_txtICPromotionDiscountAmount;
		private BOSComponent.BOSTextBox fld_txtICPromotionBuyX;
		private BOSComponent.BOSTextBox fld_txtICPromotionTogetPctOff;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblPctOff;
		private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblAmtOff;
        private BOSComponent.BOSTextBox fld_txtICPromotionTogetAmtOff1;


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
            this.fld_medICPromotionDesc1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteICPromotionStartDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICPromotionEndDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel39 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICPromotionNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPromotionName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICPromotionTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblFoward = new BOSComponent.BOSLabel(this.components);
            this.fld_lblMiddle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICPromotionItems = new BOSERP.Modules.Promotion.ICPromotionItemsGridControl();
            this.fld_dgvICPromotionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtICPromotionDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPromotionDiscountAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPromotionBuyX = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPromotionTogetPctOff = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblPctOff = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblAmtOff = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICPromotionTogetAmtOff1 = new BOSComponent.BOSTextBox(this.components);
            this.BOSGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnChooseItems = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICPromotionDesc1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionStartDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionStartDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionEndDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionEndDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICPromotionTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPromotionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICPromotionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionBuyX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionTogetPctOff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionTogetAmtOff1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSGroupControl1)).BeginInit();
            this.BOSGroupControl1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_medICPromotionDesc1
            // 
            this.fld_medICPromotionDesc1.BOSComment = "";
            this.fld_medICPromotionDesc1.BOSDataMember = "ICPromotionDesc";
            this.fld_medICPromotionDesc1.BOSDataSource = "ICPromotions";
            this.fld_medICPromotionDesc1.BOSDescription = null;
            this.fld_medICPromotionDesc1.BOSError = "";
            this.fld_medICPromotionDesc1.BOSFieldGroup = "";
            this.fld_medICPromotionDesc1.BOSFieldRelation = "";
            this.fld_medICPromotionDesc1.BOSPrivilege = "";
            this.fld_medICPromotionDesc1.BOSPropertyName = "Text";
            this.fld_medICPromotionDesc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medICPromotionDesc1.Location = new System.Drawing.Point(3, 17);
            this.fld_medICPromotionDesc1.Name = "fld_medICPromotionDesc1";
            this.fld_medICPromotionDesc1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICPromotionDesc1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICPromotionDesc1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICPromotionDesc1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICPromotionDesc1.Screen = null;
            this.fld_medICPromotionDesc1.Size = new System.Drawing.Size(344, 109);
            this.fld_medICPromotionDesc1.TabIndex = 8;
            this.fld_medICPromotionDesc1.Tag = "DC";
            // 
            // fld_dteICPromotionStartDate1
            // 
            this.fld_dteICPromotionStartDate1.BOSComment = "";
            this.fld_dteICPromotionStartDate1.BOSDataMember = "ICPromotionStartDate";
            this.fld_dteICPromotionStartDate1.BOSDataSource = "ICPromotions";
            this.fld_dteICPromotionStartDate1.BOSDescription = null;
            this.fld_dteICPromotionStartDate1.BOSError = "";
            this.fld_dteICPromotionStartDate1.BOSFieldGroup = "";
            this.fld_dteICPromotionStartDate1.BOSFieldRelation = null;
            this.fld_dteICPromotionStartDate1.BOSPrivilege = "";
            this.fld_dteICPromotionStartDate1.BOSPropertyName = "EditValue";
            this.fld_dteICPromotionStartDate1.EditValue = null;
            this.fld_dteICPromotionStartDate1.Location = new System.Drawing.Point(105, 63);
            this.fld_dteICPromotionStartDate1.Name = "fld_dteICPromotionStartDate1";
            this.fld_dteICPromotionStartDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICPromotionStartDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICPromotionStartDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICPromotionStartDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICPromotionStartDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICPromotionStartDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICPromotionStartDate1.Screen = null;
            this.fld_dteICPromotionStartDate1.Size = new System.Drawing.Size(134, 20);
            this.fld_dteICPromotionStartDate1.TabIndex = 6;
            this.fld_dteICPromotionStartDate1.Tag = "DC";
            // 
            // fld_dteICPromotionEndDate1
            // 
            this.fld_dteICPromotionEndDate1.BOSComment = "";
            this.fld_dteICPromotionEndDate1.BOSDataMember = "ICPromotionEndDate";
            this.fld_dteICPromotionEndDate1.BOSDataSource = "ICPromotions";
            this.fld_dteICPromotionEndDate1.BOSDescription = null;
            this.fld_dteICPromotionEndDate1.BOSError = "";
            this.fld_dteICPromotionEndDate1.BOSFieldGroup = "";
            this.fld_dteICPromotionEndDate1.BOSFieldRelation = null;
            this.fld_dteICPromotionEndDate1.BOSPrivilege = "";
            this.fld_dteICPromotionEndDate1.BOSPropertyName = "EditValue";
            this.fld_dteICPromotionEndDate1.EditValue = null;
            this.fld_dteICPromotionEndDate1.Location = new System.Drawing.Point(372, 65);
            this.fld_dteICPromotionEndDate1.Name = "fld_dteICPromotionEndDate1";
            this.fld_dteICPromotionEndDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICPromotionEndDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICPromotionEndDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICPromotionEndDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICPromotionEndDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICPromotionEndDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICPromotionEndDate1.Screen = null;
            this.fld_dteICPromotionEndDate1.Size = new System.Drawing.Size(122, 20);
            this.fld_dteICPromotionEndDate1.TabIndex = 7;
            this.fld_dteICPromotionEndDate1.Tag = "DC";
            // 
            // fld_lblLabel37
            // 
            this.fld_lblLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel37.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel37.BOSComment = "";
            this.fld_lblLabel37.BOSDataMember = "";
            this.fld_lblLabel37.BOSDataSource = "";
            this.fld_lblLabel37.BOSDescription = null;
            this.fld_lblLabel37.BOSError = null;
            this.fld_lblLabel37.BOSFieldGroup = "";
            this.fld_lblLabel37.BOSFieldRelation = "";
            this.fld_lblLabel37.BOSPrivilege = "";
            this.fld_lblLabel37.BOSPropertyName = null;
            this.fld_lblLabel37.Location = new System.Drawing.Point(13, 41);
            this.fld_lblLabel37.Name = "fld_lblLabel37";
            this.fld_lblLabel37.Screen = null;
            this.fld_lblLabel37.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel37.TabIndex = 20;
            this.fld_lblLabel37.Tag = "";
            this.fld_lblLabel37.Text = "Loại";
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel38.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel38.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel38.BOSComment = "";
            this.fld_lblLabel38.BOSDataMember = "";
            this.fld_lblLabel38.BOSDataSource = "";
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = "";
            this.fld_lblLabel38.BOSFieldRelation = "";
            this.fld_lblLabel38.BOSPrivilege = "";
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(13, 66);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.fld_lblLabel38.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel38.TabIndex = 21;
            this.fld_lblLabel38.Tag = "";
            this.fld_lblLabel38.Text = "Từ ngày";
            // 
            // fld_lblLabel39
            // 
            this.fld_lblLabel39.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel39.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel39.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel39.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel39.BOSComment = "";
            this.fld_lblLabel39.BOSDataMember = "";
            this.fld_lblLabel39.BOSDataSource = "";
            this.fld_lblLabel39.BOSDescription = null;
            this.fld_lblLabel39.BOSError = null;
            this.fld_lblLabel39.BOSFieldGroup = "";
            this.fld_lblLabel39.BOSFieldRelation = "";
            this.fld_lblLabel39.BOSPrivilege = "";
            this.fld_lblLabel39.BOSPropertyName = null;
            this.fld_lblLabel39.Location = new System.Drawing.Point(275, 68);
            this.fld_lblLabel39.Name = "fld_lblLabel39";
            this.fld_lblLabel39.Screen = null;
            this.fld_lblLabel39.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel39.TabIndex = 22;
            this.fld_lblLabel39.Tag = "";
            this.fld_lblLabel39.Text = "Đến";
            // 
            // fld_txtICPromotionNo1
            // 
            this.fld_txtICPromotionNo1.BOSComment = "";
            this.fld_txtICPromotionNo1.BOSDataMember = "ICPromotionNo";
            this.fld_txtICPromotionNo1.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionNo1.BOSDescription = null;
            this.fld_txtICPromotionNo1.BOSError = "";
            this.fld_txtICPromotionNo1.BOSFieldGroup = "";
            this.fld_txtICPromotionNo1.BOSFieldRelation = "";
            this.fld_txtICPromotionNo1.BOSPrivilege = "";
            this.fld_txtICPromotionNo1.BOSPropertyName = "Text";
            this.fld_txtICPromotionNo1.Location = new System.Drawing.Point(105, 12);
            this.fld_txtICPromotionNo1.Name = "fld_txtICPromotionNo1";
            this.fld_txtICPromotionNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionNo1.Screen = null;
            this.fld_txtICPromotionNo1.Size = new System.Drawing.Size(134, 20);
            this.fld_txtICPromotionNo1.TabIndex = 1;
            this.fld_txtICPromotionNo1.Tag = "DC";
            // 
            // fld_txtICPromotionName1
            // 
            this.fld_txtICPromotionName1.BOSComment = "";
            this.fld_txtICPromotionName1.BOSDataMember = "ICPromotionName";
            this.fld_txtICPromotionName1.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionName1.BOSDescription = null;
            this.fld_txtICPromotionName1.BOSError = "Tên chương trình không thể rỗng";
            this.fld_txtICPromotionName1.BOSFieldGroup = "";
            this.fld_txtICPromotionName1.BOSFieldRelation = "";
            this.fld_txtICPromotionName1.BOSPrivilege = "";
            this.fld_txtICPromotionName1.BOSPropertyName = "Text";
            this.fld_txtICPromotionName1.Location = new System.Drawing.Point(372, 13);
            this.fld_txtICPromotionName1.Name = "fld_txtICPromotionName1";
            this.fld_txtICPromotionName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionName1.Screen = null;
            this.fld_txtICPromotionName1.Size = new System.Drawing.Size(298, 20);
            this.fld_txtICPromotionName1.TabIndex = 2;
            this.fld_txtICPromotionName1.Tag = "DC";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(275, 15);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(82, 13);
            this.fld_lblLabel3.TabIndex = 28;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên chương trình";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(13, 15);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel6.TabIndex = 29;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Mã chương trình";
            // 
            // fld_lkeICPromotionTypeCombo
            // 
            this.fld_lkeICPromotionTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeICPromotionTypeCombo.BOSAllowDummy = false;
            this.fld_lkeICPromotionTypeCombo.BOSComment = "";
            this.fld_lkeICPromotionTypeCombo.BOSDataMember = "ICPromotionTypeCombo";
            this.fld_lkeICPromotionTypeCombo.BOSDataSource = "ICPromotions";
            this.fld_lkeICPromotionTypeCombo.BOSDescription = null;
            this.fld_lkeICPromotionTypeCombo.BOSError = "Loại khuyến mãi không thể rỗng";
            this.fld_lkeICPromotionTypeCombo.BOSFieldGroup = "";
            this.fld_lkeICPromotionTypeCombo.BOSFieldParent = "";
            this.fld_lkeICPromotionTypeCombo.BOSFieldRelation = "";
            this.fld_lkeICPromotionTypeCombo.BOSPrivilege = "";
            this.fld_lkeICPromotionTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeICPromotionTypeCombo.BOSSelectType = "";
            this.fld_lkeICPromotionTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeICPromotionTypeCombo.CurrentDisplayText = "";
            this.fld_lkeICPromotionTypeCombo.Location = new System.Drawing.Point(105, 37);
            this.fld_lkeICPromotionTypeCombo.Name = "fld_lkeICPromotionTypeCombo";
            this.fld_lkeICPromotionTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICPromotionTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICPromotionTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICPromotionTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICPromotionTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICPromotionTypeCombo.Properties.DisplayMember = "ICPromotionTypeCombo";
            this.fld_lkeICPromotionTypeCombo.Properties.NullText = "";
            this.fld_lkeICPromotionTypeCombo.Properties.PopupWidth = 20;
            this.fld_lkeICPromotionTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICPromotionTypeCombo.Properties.ValueMember = "ICPromotionTypeCombo";
            this.fld_lkeICPromotionTypeCombo.Screen = null;
            this.fld_lkeICPromotionTypeCombo.Size = new System.Drawing.Size(134, 20);
            this.fld_lkeICPromotionTypeCombo.TabIndex = 3;
            this.fld_lkeICPromotionTypeCombo.Tag = "DC";
            this.fld_lkeICPromotionTypeCombo.Validated += new System.EventHandler(this.fld_lkeICPromotionTypeCombo_Validated);
            // 
            // fld_lblFoward
            // 
            this.fld_lblFoward.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblFoward.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblFoward.Appearance.Options.UseBackColor = true;
            this.fld_lblFoward.Appearance.Options.UseForeColor = true;
            this.fld_lblFoward.BOSComment = "";
            this.fld_lblFoward.BOSDataMember = "";
            this.fld_lblFoward.BOSDataSource = "";
            this.fld_lblFoward.BOSDescription = null;
            this.fld_lblFoward.BOSError = null;
            this.fld_lblFoward.BOSFieldGroup = "DiscPct";
            this.fld_lblFoward.BOSFieldRelation = "";
            this.fld_lblFoward.BOSPrivilege = "";
            this.fld_lblFoward.BOSPropertyName = null;
            this.fld_lblFoward.Location = new System.Drawing.Point(275, 44);
            this.fld_lblFoward.Name = "fld_lblFoward";
            this.fld_lblFoward.Screen = null;
            this.fld_lblFoward.Size = new System.Drawing.Size(62, 13);
            this.fld_lblFoward.TabIndex = 36;
            this.fld_lblFoward.Tag = "";
            this.fld_lblFoward.Text = "Giảm giá (%)";
            // 
            // fld_lblMiddle
            // 
            this.fld_lblMiddle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblMiddle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblMiddle.Appearance.Options.UseBackColor = true;
            this.fld_lblMiddle.Appearance.Options.UseForeColor = true;
            this.fld_lblMiddle.BOSComment = "";
            this.fld_lblMiddle.BOSDataMember = "";
            this.fld_lblMiddle.BOSDataSource = "";
            this.fld_lblMiddle.BOSDescription = null;
            this.fld_lblMiddle.BOSError = null;
            this.fld_lblMiddle.BOSFieldGroup = "BuyX";
            this.fld_lblMiddle.BOSFieldRelation = "";
            this.fld_lblMiddle.BOSPrivilege = "";
            this.fld_lblMiddle.BOSPropertyName = null;
            this.fld_lblMiddle.Location = new System.Drawing.Point(523, 44);
            this.fld_lblMiddle.Name = "fld_lblMiddle";
            this.fld_lblMiddle.Screen = null;
            this.fld_lblMiddle.Size = new System.Drawing.Size(23, 13);
            this.fld_lblMiddle.TabIndex = 37;
            this.fld_lblMiddle.Tag = "";
            this.fld_lblMiddle.Text = "Giảm";
            // 
            // fld_dgcICPromotionItems
            // 
            this.fld_dgcICPromotionItems.AllowDrop = true;
            this.fld_dgcICPromotionItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICPromotionItems.BOSComment = "";
            this.fld_dgcICPromotionItems.BOSDataMember = null;
            this.fld_dgcICPromotionItems.BOSDataSource = "ICPromotionItems";
            this.fld_dgcICPromotionItems.BOSDescription = null;
            this.fld_dgcICPromotionItems.BOSError = "";
            this.fld_dgcICPromotionItems.BOSFieldGroup = "";
            this.fld_dgcICPromotionItems.BOSFieldRelation = null;
            this.fld_dgcICPromotionItems.BOSGridType = null;
            this.fld_dgcICPromotionItems.BOSPrivilege = "";
            this.fld_dgcICPromotionItems.BOSPropertyName = null;
            this.fld_dgcICPromotionItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICPromotionItems.Location = new System.Drawing.Point(10, 54);
            this.fld_dgcICPromotionItems.MainView = this.fld_dgvICPromotionItems;
            this.fld_dgcICPromotionItems.Name = "fld_dgcICPromotionItems";
            this.fld_dgcICPromotionItems.Screen = null;
            this.fld_dgcICPromotionItems.Size = new System.Drawing.Size(999, 250);
            this.fld_dgcICPromotionItems.TabIndex = 23;
            this.fld_dgcICPromotionItems.Tag = "DC";
            this.fld_dgcICPromotionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICPromotionItems});
            // 
            // fld_dgvICPromotionItems
            // 
            this.fld_dgvICPromotionItems.GridControl = this.fld_dgcICPromotionItems;
            this.fld_dgvICPromotionItems.Name = "fld_dgvICPromotionItems";
            this.fld_dgvICPromotionItems.PaintStyleName = "Office2003";
            // 
            // fld_txtICPromotionDiscountPercent
            // 
            this.fld_txtICPromotionDiscountPercent.BOSComment = "";
            this.fld_txtICPromotionDiscountPercent.BOSDataMember = "ICPromotionDiscountPercent";
            this.fld_txtICPromotionDiscountPercent.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionDiscountPercent.BOSDescription = null;
            this.fld_txtICPromotionDiscountPercent.BOSError = "";
            this.fld_txtICPromotionDiscountPercent.BOSFieldGroup = "DiscPct";
            this.fld_txtICPromotionDiscountPercent.BOSFieldRelation = "";
            this.fld_txtICPromotionDiscountPercent.BOSPrivilege = "";
            this.fld_txtICPromotionDiscountPercent.BOSPropertyName = "Text";
            this.fld_txtICPromotionDiscountPercent.Location = new System.Drawing.Point(372, 39);
            this.fld_txtICPromotionDiscountPercent.Name = "fld_txtICPromotionDiscountPercent";
            this.fld_txtICPromotionDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionDiscountPercent.Properties.Mask.EditMask = "n";
            this.fld_txtICPromotionDiscountPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPromotionDiscountPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionDiscountPercent.Screen = null;
            this.fld_txtICPromotionDiscountPercent.Size = new System.Drawing.Size(122, 20);
            this.fld_txtICPromotionDiscountPercent.TabIndex = 4;
            this.fld_txtICPromotionDiscountPercent.Tag = "DC";
            this.fld_txtICPromotionDiscountPercent.Validated += new System.EventHandler(this.fld_txtICPromotionDiscountPercent_Validated);
            // 
            // fld_txtICPromotionDiscountAmount
            // 
            this.fld_txtICPromotionDiscountAmount.BOSComment = "";
            this.fld_txtICPromotionDiscountAmount.BOSDataMember = "ICPromotionDiscountAmount";
            this.fld_txtICPromotionDiscountAmount.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionDiscountAmount.BOSDescription = null;
            this.fld_txtICPromotionDiscountAmount.BOSError = "";
            this.fld_txtICPromotionDiscountAmount.BOSFieldGroup = "DiscAmt";
            this.fld_txtICPromotionDiscountAmount.BOSFieldRelation = "";
            this.fld_txtICPromotionDiscountAmount.BOSPrivilege = "";
            this.fld_txtICPromotionDiscountAmount.BOSPropertyName = "Text";
            this.fld_txtICPromotionDiscountAmount.Location = new System.Drawing.Point(372, 39);
            this.fld_txtICPromotionDiscountAmount.Name = "fld_txtICPromotionDiscountAmount";
            this.fld_txtICPromotionDiscountAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionDiscountAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionDiscountAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionDiscountAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionDiscountAmount.Properties.Mask.EditMask = "n";
            this.fld_txtICPromotionDiscountAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPromotionDiscountAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionDiscountAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionDiscountAmount.Screen = null;
            this.fld_txtICPromotionDiscountAmount.Size = new System.Drawing.Size(122, 20);
            this.fld_txtICPromotionDiscountAmount.TabIndex = 4;
            this.fld_txtICPromotionDiscountAmount.Tag = "DC";
            this.fld_txtICPromotionDiscountAmount.Validated += new System.EventHandler(this.fld_txtICPromotionDiscountAmount_Validated);
            // 
            // fld_txtICPromotionBuyX
            // 
            this.fld_txtICPromotionBuyX.BOSComment = "";
            this.fld_txtICPromotionBuyX.BOSDataMember = "ICPromotionBuyX";
            this.fld_txtICPromotionBuyX.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionBuyX.BOSDescription = null;
            this.fld_txtICPromotionBuyX.BOSError = "";
            this.fld_txtICPromotionBuyX.BOSFieldGroup = "BuyX";
            this.fld_txtICPromotionBuyX.BOSFieldRelation = "";
            this.fld_txtICPromotionBuyX.BOSPrivilege = "";
            this.fld_txtICPromotionBuyX.BOSPropertyName = "Text";
            this.fld_txtICPromotionBuyX.Location = new System.Drawing.Point(372, 39);
            this.fld_txtICPromotionBuyX.Name = "fld_txtICPromotionBuyX";
            this.fld_txtICPromotionBuyX.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionBuyX.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionBuyX.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionBuyX.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionBuyX.Properties.Mask.EditMask = "n";
            this.fld_txtICPromotionBuyX.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPromotionBuyX.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionBuyX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionBuyX.Screen = null;
            this.fld_txtICPromotionBuyX.Size = new System.Drawing.Size(122, 20);
            this.fld_txtICPromotionBuyX.TabIndex = 4;
            this.fld_txtICPromotionBuyX.Tag = "DC";
            this.fld_txtICPromotionBuyX.Validated += new System.EventHandler(this.fld_txtICPromotionBuyX_Validated);
            // 
            // fld_txtICPromotionTogetPctOff
            // 
            this.fld_txtICPromotionTogetPctOff.BOSComment = "";
            this.fld_txtICPromotionTogetPctOff.BOSDataMember = "ICPromotionTogetPctOff";
            this.fld_txtICPromotionTogetPctOff.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionTogetPctOff.BOSDescription = null;
            this.fld_txtICPromotionTogetPctOff.BOSError = "";
            this.fld_txtICPromotionTogetPctOff.BOSFieldGroup = "BuyX";
            this.fld_txtICPromotionTogetPctOff.BOSFieldRelation = "";
            this.fld_txtICPromotionTogetPctOff.BOSPrivilege = "";
            this.fld_txtICPromotionTogetPctOff.BOSPropertyName = "Text";
            this.fld_txtICPromotionTogetPctOff.Location = new System.Drawing.Point(561, 39);
            this.fld_txtICPromotionTogetPctOff.Name = "fld_txtICPromotionTogetPctOff";
            this.fld_txtICPromotionTogetPctOff.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionTogetPctOff.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionTogetPctOff.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionTogetPctOff.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionTogetPctOff.Properties.Mask.EditMask = "n";
            this.fld_txtICPromotionTogetPctOff.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPromotionTogetPctOff.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionTogetPctOff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionTogetPctOff.Screen = null;
            this.fld_txtICPromotionTogetPctOff.Size = new System.Drawing.Size(109, 20);
            this.fld_txtICPromotionTogetPctOff.TabIndex = 5;
            this.fld_txtICPromotionTogetPctOff.Tag = "DC";
            this.fld_txtICPromotionTogetPctOff.Validated += new System.EventHandler(this.fld_txtICPromotionTogetPctOff_Validated);
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "DiscAmt";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(275, 43);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(44, 13);
            this.fld_lblLabel7.TabIndex = 51;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Giảm tiền";
            // 
            // fld_lblPctOff
            // 
            this.fld_lblPctOff.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblPctOff.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblPctOff.Appearance.Options.UseBackColor = true;
            this.fld_lblPctOff.Appearance.Options.UseForeColor = true;
            this.fld_lblPctOff.BOSComment = "";
            this.fld_lblPctOff.BOSDataMember = "";
            this.fld_lblPctOff.BOSDataSource = "";
            this.fld_lblPctOff.BOSDescription = null;
            this.fld_lblPctOff.BOSError = null;
            this.fld_lblPctOff.BOSFieldGroup = "BuyX";
            this.fld_lblPctOff.BOSFieldRelation = "";
            this.fld_lblPctOff.BOSPrivilege = "";
            this.fld_lblPctOff.BOSPropertyName = null;
            this.fld_lblPctOff.Location = new System.Drawing.Point(676, 43);
            this.fld_lblPctOff.Name = "fld_lblPctOff";
            this.fld_lblPctOff.Screen = null;
            this.fld_lblPctOff.Size = new System.Drawing.Size(11, 13);
            this.fld_lblPctOff.TabIndex = 52;
            this.fld_lblPctOff.Tag = "";
            this.fld_lblPctOff.Text = "%";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "BuyX";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(275, 43);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel12.TabIndex = 53;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Mua";
            // 
            // fld_lblAmtOff
            // 
            this.fld_lblAmtOff.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblAmtOff.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblAmtOff.Appearance.Options.UseBackColor = true;
            this.fld_lblAmtOff.Appearance.Options.UseForeColor = true;
            this.fld_lblAmtOff.BOSComment = "";
            this.fld_lblAmtOff.BOSDataMember = "";
            this.fld_lblAmtOff.BOSDataSource = "";
            this.fld_lblAmtOff.BOSDescription = null;
            this.fld_lblAmtOff.BOSError = null;
            this.fld_lblAmtOff.BOSFieldGroup = "BuyX";
            this.fld_lblAmtOff.BOSFieldRelation = "";
            this.fld_lblAmtOff.BOSPrivilege = "";
            this.fld_lblAmtOff.BOSPropertyName = null;
            this.fld_lblAmtOff.Location = new System.Drawing.Point(676, 43);
            this.fld_lblAmtOff.Name = "fld_lblAmtOff";
            this.fld_lblAmtOff.Screen = null;
            this.fld_lblAmtOff.Size = new System.Drawing.Size(20, 13);
            this.fld_lblAmtOff.TabIndex = 54;
            this.fld_lblAmtOff.Tag = "";
            this.fld_lblAmtOff.Text = "Tiền";
            // 
            // fld_txtICPromotionTogetAmtOff1
            // 
            this.fld_txtICPromotionTogetAmtOff1.BOSComment = "";
            this.fld_txtICPromotionTogetAmtOff1.BOSDataMember = "ICPromotionTogetAmtOff";
            this.fld_txtICPromotionTogetAmtOff1.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionTogetAmtOff1.BOSDescription = null;
            this.fld_txtICPromotionTogetAmtOff1.BOSError = "";
            this.fld_txtICPromotionTogetAmtOff1.BOSFieldGroup = "BuyX";
            this.fld_txtICPromotionTogetAmtOff1.BOSFieldRelation = "";
            this.fld_txtICPromotionTogetAmtOff1.BOSPrivilege = "";
            this.fld_txtICPromotionTogetAmtOff1.BOSPropertyName = "Text";
            this.fld_txtICPromotionTogetAmtOff1.Location = new System.Drawing.Point(561, 39);
            this.fld_txtICPromotionTogetAmtOff1.Name = "fld_txtICPromotionTogetAmtOff1";
            this.fld_txtICPromotionTogetAmtOff1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionTogetAmtOff1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionTogetAmtOff1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionTogetAmtOff1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionTogetAmtOff1.Properties.Mask.EditMask = "n";
            this.fld_txtICPromotionTogetAmtOff1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPromotionTogetAmtOff1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionTogetAmtOff1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionTogetAmtOff1.Screen = null;
            this.fld_txtICPromotionTogetAmtOff1.Size = new System.Drawing.Size(109, 20);
            this.fld_txtICPromotionTogetAmtOff1.TabIndex = 5;
            this.fld_txtICPromotionTogetAmtOff1.Tag = "DC";
            this.fld_txtICPromotionTogetAmtOff1.Validated += new System.EventHandler(this.fld_txtICPromotionTogetAmtOff1_Validated);
            // 
            // BOSGroupControl1
            // 
            this.BOSGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSGroupControl1.BOSComment = null;
            this.BOSGroupControl1.BOSDataMember = null;
            this.BOSGroupControl1.BOSDataSource = null;
            this.BOSGroupControl1.BOSDescription = null;
            this.BOSGroupControl1.BOSError = null;
            this.BOSGroupControl1.BOSFieldGroup = null;
            this.BOSGroupControl1.BOSFieldRelation = null;
            this.BOSGroupControl1.BOSPrivilege = null;
            this.BOSGroupControl1.BOSPropertyName = null;
            this.BOSGroupControl1.Controls.Add(this.fld_btnChooseItems);
            this.BOSGroupControl1.Controls.Add(this.fld_dgcICPromotionItems);
            this.BOSGroupControl1.Location = new System.Drawing.Point(8, 111);
            this.BOSGroupControl1.Name = "BOSGroupControl1";
            this.BOSGroupControl1.Screen = null;
            this.BOSGroupControl1.Size = new System.Drawing.Size(1014, 309);
            this.BOSGroupControl1.TabIndex = 9;
            this.BOSGroupControl1.Text = "Danh sách sản phẩm";
            // 
            // fld_btnChooseItems
            // 
            this.fld_btnChooseItems.BOSComment = null;
            this.fld_btnChooseItems.BOSDataMember = null;
            this.fld_btnChooseItems.BOSDataSource = null;
            this.fld_btnChooseItems.BOSDescription = null;
            this.fld_btnChooseItems.BOSError = null;
            this.fld_btnChooseItems.BOSFieldGroup = null;
            this.fld_btnChooseItems.BOSFieldRelation = null;
            this.fld_btnChooseItems.BOSPrivilege = null;
            this.fld_btnChooseItems.BOSPropertyName = null;
            this.fld_btnChooseItems.Location = new System.Drawing.Point(10, 25);
            this.fld_btnChooseItems.Name = "fld_btnChooseItems";
            this.fld_btnChooseItems.Screen = null;
            this.fld_btnChooseItems.Size = new System.Drawing.Size(154, 23);
            this.fld_btnChooseItems.TabIndex = 1;
            this.fld_btnChooseItems.Text = "Chọn sản phẩm";
            this.fld_btnChooseItems.Click += new System.EventHandler(this.fld_btnChooseItems_Click);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medICPromotionDesc1);
            this.bosLine1.Location = new System.Drawing.Point(8, 426);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(350, 129);
            this.bosLine1.TabIndex = 55;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Mô tả";
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
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionNo1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel39);
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionBuyX);
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionDiscountAmount);
            this.bosPanel1.Controls.Add(this.BOSGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionTogetPctOff);
            this.bosPanel1.Controls.Add(this.fld_lkeICPromotionTypeCombo);
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionDiscountPercent);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblAmtOff);
            this.bosPanel1.Controls.Add(this.fld_dteICPromotionEndDate1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel38);
            this.bosPanel1.Controls.Add(this.fld_lblLabel37);
            this.bosPanel1.Controls.Add(this.fld_dteICPromotionStartDate1);
            this.bosPanel1.Controls.Add(this.fld_lblMiddle);
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionName1);
            this.bosPanel1.Controls.Add(this.fld_lblPctOff);
            this.bosPanel1.Controls.Add(this.fld_txtICPromotionTogetAmtOff1);
            this.bosPanel1.Controls.Add(this.fld_lblFoward);
            this.bosPanel1.Controls.Add(this.fld_lblLabel12);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1033, 562);
            this.bosPanel1.TabIndex = 56;
            // 
            // DMPR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1033, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPR100";
            this.Text = "Thông tin ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICPromotionDesc1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionStartDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionStartDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionEndDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPromotionEndDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICPromotionTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPromotionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICPromotionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionBuyX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionTogetPctOff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionTogetAmtOff1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSGroupControl1)).EndInit();
            this.BOSGroupControl1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl BOSGroupControl1;
        private BOSComponent.BOSButton fld_btnChooseItems;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
