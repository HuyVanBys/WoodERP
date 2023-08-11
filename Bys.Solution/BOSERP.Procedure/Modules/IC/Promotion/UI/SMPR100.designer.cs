using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Promotion.UI
{
	/// <summary>
	/// Summary description for SMPR100
	/// </summary>
	partial class SMPR100
	{
		private BOSComponent.BOSTextBox fld_txtICPromotionNo;
		private BOSComponent.BOSTextBox fld_txtICPromotionName;
		private BOSComponent.BOSLookupEdit fld_lkeICPromotionTypeCombo1;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICPromotionStartDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToICPromotionStartDate2;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICPromotionEndDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToICPromotionEndDate2;
		private BOSSearchResultsGridControl fld_dgcICPromotion;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICPromotion;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLabel fld_lblLabel18;


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
            this.fld_txtICPromotionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPromotionName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICPromotionTypeCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromICPromotionStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICPromotionStartDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromICPromotionEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICPromotionEndDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcICPromotion = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICPromotion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICPromotionTypeCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionStartDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionStartDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionEndDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionEndDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtICPromotionNo
            // 
            this.fld_txtICPromotionNo.BOSComment = "";
            this.fld_txtICPromotionNo.BOSDataMember = "ICPromotionNo";
            this.fld_txtICPromotionNo.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionNo.BOSDescription = null;
            this.fld_txtICPromotionNo.BOSError = "";
            this.fld_txtICPromotionNo.BOSFieldGroup = "";
            this.fld_txtICPromotionNo.BOSFieldRelation = "";
            this.fld_txtICPromotionNo.BOSPrivilege = "";
            this.fld_txtICPromotionNo.BOSPropertyName = "Text";
            this.fld_txtICPromotionNo.Location = new System.Drawing.Point(142, 9);
            this.fld_txtICPromotionNo.Name = "fld_txtICPromotionNo";
            this.fld_txtICPromotionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionNo.Screen = null;
            this.fld_txtICPromotionNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPromotionNo.TabIndex = 1;
            this.fld_txtICPromotionNo.Tag = "SC";
            // 
            // fld_txtICPromotionName
            // 
            this.fld_txtICPromotionName.BOSComment = "";
            this.fld_txtICPromotionName.BOSDataMember = "ICPromotionName";
            this.fld_txtICPromotionName.BOSDataSource = "ICPromotions";
            this.fld_txtICPromotionName.BOSDescription = null;
            this.fld_txtICPromotionName.BOSError = "";
            this.fld_txtICPromotionName.BOSFieldGroup = "";
            this.fld_txtICPromotionName.BOSFieldRelation = "";
            this.fld_txtICPromotionName.BOSPrivilege = "";
            this.fld_txtICPromotionName.BOSPropertyName = "Text";
            this.fld_txtICPromotionName.Location = new System.Drawing.Point(142, 35);
            this.fld_txtICPromotionName.Name = "fld_txtICPromotionName";
            this.fld_txtICPromotionName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPromotionName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPromotionName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPromotionName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPromotionName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPromotionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPromotionName.Screen = null;
            this.fld_txtICPromotionName.Size = new System.Drawing.Size(362, 20);
            this.fld_txtICPromotionName.TabIndex = 2;
            this.fld_txtICPromotionName.Tag = "SC";
            // 
            // fld_lkeICPromotionTypeCombo1
            // 
            this.fld_lkeICPromotionTypeCombo1.BOSAllowAddNew = false;
            this.fld_lkeICPromotionTypeCombo1.BOSAllowDummy = true;
            this.fld_lkeICPromotionTypeCombo1.BOSComment = "";
            this.fld_lkeICPromotionTypeCombo1.BOSDataMember = "ICPromotionTypeCombo";
            this.fld_lkeICPromotionTypeCombo1.BOSDataSource = "ICPromotions";
            this.fld_lkeICPromotionTypeCombo1.BOSDescription = null;
            this.fld_lkeICPromotionTypeCombo1.BOSError = "";
            this.fld_lkeICPromotionTypeCombo1.BOSFieldGroup = "";
            this.fld_lkeICPromotionTypeCombo1.BOSFieldParent = "";
            this.fld_lkeICPromotionTypeCombo1.BOSFieldRelation = "";
            this.fld_lkeICPromotionTypeCombo1.BOSPrivilege = "";
            this.fld_lkeICPromotionTypeCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeICPromotionTypeCombo1.BOSSelectType = "";
            this.fld_lkeICPromotionTypeCombo1.BOSSelectTypeValue = "";
            this.fld_lkeICPromotionTypeCombo1.CurrentDisplayText = "";
            this.fld_lkeICPromotionTypeCombo1.Location = new System.Drawing.Point(142, 61);
            this.fld_lkeICPromotionTypeCombo1.Name = "fld_lkeICPromotionTypeCombo1";
            this.fld_lkeICPromotionTypeCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICPromotionTypeCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICPromotionTypeCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICPromotionTypeCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICPromotionTypeCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICPromotionTypeCombo1.Properties.NullText = "";
            this.fld_lkeICPromotionTypeCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICPromotionTypeCombo1.Screen = null;
            this.fld_lkeICPromotionTypeCombo1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICPromotionTypeCombo1.TabIndex = 3;
            this.fld_lkeICPromotionTypeCombo1.Tag = "SC";
            // 
            // fld_dteSearchFromICPromotionStartDate
            // 
            this.fld_dteSearchFromICPromotionStartDate.BOSComment = "";
            this.fld_dteSearchFromICPromotionStartDate.BOSDataMember = "ICPromotionStartDate";
            this.fld_dteSearchFromICPromotionStartDate.BOSDataSource = "ICPromotions";
            this.fld_dteSearchFromICPromotionStartDate.BOSDescription = null;
            this.fld_dteSearchFromICPromotionStartDate.BOSError = "";
            this.fld_dteSearchFromICPromotionStartDate.BOSFieldGroup = "";
            this.fld_dteSearchFromICPromotionStartDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICPromotionStartDate.BOSPrivilege = "";
            this.fld_dteSearchFromICPromotionStartDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICPromotionStartDate.EditValue = null;
            this.fld_dteSearchFromICPromotionStartDate.Location = new System.Drawing.Point(142, 87);
            this.fld_dteSearchFromICPromotionStartDate.Name = "fld_dteSearchFromICPromotionStartDate";
            this.fld_dteSearchFromICPromotionStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICPromotionStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICPromotionStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICPromotionStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICPromotionStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICPromotionStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICPromotionStartDate.Screen = null;
            this.fld_dteSearchFromICPromotionStartDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromICPromotionStartDate.TabIndex = 4;
            this.fld_dteSearchFromICPromotionStartDate.Tag = "SC";
            // 
            // fld_dteSearchToICPromotionStartDate2
            // 
            this.fld_dteSearchToICPromotionStartDate2.BOSComment = "";
            this.fld_dteSearchToICPromotionStartDate2.BOSDataMember = "ICPromotionStartDate";
            this.fld_dteSearchToICPromotionStartDate2.BOSDataSource = "ICPromotions";
            this.fld_dteSearchToICPromotionStartDate2.BOSDescription = null;
            this.fld_dteSearchToICPromotionStartDate2.BOSError = "";
            this.fld_dteSearchToICPromotionStartDate2.BOSFieldGroup = "";
            this.fld_dteSearchToICPromotionStartDate2.BOSFieldRelation = null;
            this.fld_dteSearchToICPromotionStartDate2.BOSPrivilege = "";
            this.fld_dteSearchToICPromotionStartDate2.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICPromotionStartDate2.EditValue = null;
            this.fld_dteSearchToICPromotionStartDate2.Location = new System.Drawing.Point(354, 87);
            this.fld_dteSearchToICPromotionStartDate2.Name = "fld_dteSearchToICPromotionStartDate2";
            this.fld_dteSearchToICPromotionStartDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICPromotionStartDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICPromotionStartDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICPromotionStartDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICPromotionStartDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICPromotionStartDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICPromotionStartDate2.Screen = null;
            this.fld_dteSearchToICPromotionStartDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToICPromotionStartDate2.TabIndex = 5;
            this.fld_dteSearchToICPromotionStartDate2.Tag = "SC";
            // 
            // fld_dteSearchFromICPromotionEndDate
            // 
            this.fld_dteSearchFromICPromotionEndDate.BOSComment = "";
            this.fld_dteSearchFromICPromotionEndDate.BOSDataMember = "ICPromotionEndDate";
            this.fld_dteSearchFromICPromotionEndDate.BOSDataSource = "ICPromotions";
            this.fld_dteSearchFromICPromotionEndDate.BOSDescription = null;
            this.fld_dteSearchFromICPromotionEndDate.BOSError = "";
            this.fld_dteSearchFromICPromotionEndDate.BOSFieldGroup = "";
            this.fld_dteSearchFromICPromotionEndDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICPromotionEndDate.BOSPrivilege = "";
            this.fld_dteSearchFromICPromotionEndDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICPromotionEndDate.EditValue = null;
            this.fld_dteSearchFromICPromotionEndDate.Location = new System.Drawing.Point(142, 113);
            this.fld_dteSearchFromICPromotionEndDate.Name = "fld_dteSearchFromICPromotionEndDate";
            this.fld_dteSearchFromICPromotionEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICPromotionEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICPromotionEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICPromotionEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICPromotionEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICPromotionEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICPromotionEndDate.Screen = null;
            this.fld_dteSearchFromICPromotionEndDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromICPromotionEndDate.TabIndex = 6;
            this.fld_dteSearchFromICPromotionEndDate.Tag = "SC";
            // 
            // fld_dteSearchToICPromotionEndDate2
            // 
            this.fld_dteSearchToICPromotionEndDate2.BOSComment = "";
            this.fld_dteSearchToICPromotionEndDate2.BOSDataMember = "ICPromotionEndDate";
            this.fld_dteSearchToICPromotionEndDate2.BOSDataSource = "ICPromotions";
            this.fld_dteSearchToICPromotionEndDate2.BOSDescription = null;
            this.fld_dteSearchToICPromotionEndDate2.BOSError = "";
            this.fld_dteSearchToICPromotionEndDate2.BOSFieldGroup = "";
            this.fld_dteSearchToICPromotionEndDate2.BOSFieldRelation = null;
            this.fld_dteSearchToICPromotionEndDate2.BOSPrivilege = "";
            this.fld_dteSearchToICPromotionEndDate2.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICPromotionEndDate2.EditValue = null;
            this.fld_dteSearchToICPromotionEndDate2.Location = new System.Drawing.Point(354, 113);
            this.fld_dteSearchToICPromotionEndDate2.Name = "fld_dteSearchToICPromotionEndDate2";
            this.fld_dteSearchToICPromotionEndDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICPromotionEndDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICPromotionEndDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICPromotionEndDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICPromotionEndDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICPromotionEndDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICPromotionEndDate2.Screen = null;
            this.fld_dteSearchToICPromotionEndDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToICPromotionEndDate2.TabIndex = 7;
            this.fld_dteSearchToICPromotionEndDate2.Tag = "SC";
            // 
            // fld_dgcICPromotion
            // 
            this.fld_dgcICPromotion.AllowDrop = true;
            this.fld_dgcICPromotion.BOSComment = "";
            this.fld_dgcICPromotion.BOSDataMember = null;
            this.fld_dgcICPromotion.BOSDataSource = "ICPromotions";
            this.fld_dgcICPromotion.BOSDescription = null;
            this.fld_dgcICPromotion.BOSError = "";
            this.fld_dgcICPromotion.BOSFieldGroup = "";
            this.fld_dgcICPromotion.BOSFieldRelation = null;
            this.fld_dgcICPromotion.BOSPrivilege = "";
            this.fld_dgcICPromotion.BOSPropertyName = null;
            this.fld_dgcICPromotion.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICPromotion.Location = new System.Drawing.Point(36, 209);
            this.fld_dgcICPromotion.MainView = this.fld_dgvICPromotion;
            this.fld_dgcICPromotion.Name = "fld_dgcICPromotion";
            this.fld_dgcICPromotion.Screen = null;
            this.fld_dgcICPromotion.Size = new System.Drawing.Size(610, 308);
            this.fld_dgcICPromotion.TabIndex = 15;
            this.fld_dgcICPromotion.Tag = "SR";
            this.fld_dgcICPromotion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICPromotion});
            // 
            // fld_dgvICPromotion
            // 
            this.fld_dgvICPromotion.GridControl = this.fld_dgcICPromotion;
            this.fld_dgvICPromotion.Name = "fld_dgvICPromotion";
            this.fld_dgvICPromotion.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(37, 64);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel.TabIndex = 13;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Loại khuyến mãi";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(320, 116);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel2.TabIndex = 15;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Đến";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(36, 116);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(81, 13);
            this.fld_lblLabel4.TabIndex = 16;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Kết thúc từ ngày";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(37, 38);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(82, 13);
            this.fld_lblLabel5.TabIndex = 17;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Tên chương trình";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(36, 12);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel8.TabIndex = 18;
            this.fld_lblLabel8.Tag = "SI";
            this.fld_lblLabel8.Text = "Mã chương trình";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(37, 90);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel17.TabIndex = 24;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Bắt đầu từ ngày";
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = "";
            this.fld_lblLabel18.BOSDataMember = "";
            this.fld_lblLabel18.BOSDataSource = "";
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = "";
            this.fld_lblLabel18.BOSFieldRelation = "";
            this.fld_lblLabel18.BOSPrivilege = "";
            this.fld_lblLabel18.BOSPropertyName = null;
            this.fld_lblLabel18.Location = new System.Drawing.Point(320, 90);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel18.TabIndex = 25;
            this.fld_lblLabel18.Tag = "SI";
            this.fld_lblLabel18.Text = "Đến";
            // 
            // SMPR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(710, 567);
            this.Controls.Add(this.fld_txtICPromotionNo);
            this.Controls.Add(this.fld_dgcICPromotion);
            this.Controls.Add(this.fld_txtICPromotionName);
            this.Controls.Add(this.fld_lkeICPromotionTypeCombo1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dteSearchFromICPromotionStartDate);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dteSearchToICPromotionStartDate2);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.fld_dteSearchToICPromotionEndDate2);
            this.Controls.Add(this.fld_dteSearchFromICPromotionEndDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel18);
            this.Name = "SMPR100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel18, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICPromotionEndDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICPromotionEndDate2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICPromotionStartDate2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICPromotionStartDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeICPromotionTypeCombo1, 0);
            this.Controls.SetChildIndex(this.fld_txtICPromotionName, 0);
            this.Controls.SetChildIndex(this.fld_dgcICPromotion, 0);
            this.Controls.SetChildIndex(this.fld_txtICPromotionNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPromotionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICPromotionTypeCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionStartDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionStartDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICPromotionEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionEndDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICPromotionEndDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICPromotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
