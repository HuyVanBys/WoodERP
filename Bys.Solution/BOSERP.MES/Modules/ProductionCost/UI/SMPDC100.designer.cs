using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for SMPDC100
	/// </summary>
	partial class SMPDC100
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
            this.fld_dgcMMProductionCosts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lkeMMProductionCostStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMProductionCostToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMProductionCostName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMProductionCosts
            // 
            this.fld_dgcMMProductionCosts.AllowDrop = true;
            this.fld_dgcMMProductionCosts.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMProductionCosts.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMProductionCosts.BOSDataSource = "MMProductionCosts";
            this.fld_dgcMMProductionCosts.BOSDescription = null;
            this.fld_dgcMMProductionCosts.BOSError = null;
            this.fld_dgcMMProductionCosts.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMProductionCosts.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMProductionCosts.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMProductionCosts.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMProductionCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCosts.Location = new System.Drawing.Point(21, 195);
            this.fld_dgcMMProductionCosts.Name = "fld_dgcMMProductionCosts";
            this.fld_dgcMMProductionCosts.Screen = null;
            this.fld_dgcMMProductionCosts.Size = new System.Drawing.Size(561, 272);
            this.fld_dgcMMProductionCosts.TabIndex = 381;
            this.fld_dgcMMProductionCosts.Tag = "SR";
            // 
            // fld_lkeMMProductionCostStatus
            // 
            this.fld_lkeMMProductionCostStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionCostStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionCostStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSDataMember = "MMProductionCostStatus";
            this.fld_lkeMMProductionCostStatus.BOSDataSource = "MMProductionCosts";
            this.fld_lkeMMProductionCostStatus.BOSDescription = null;
            this.fld_lkeMMProductionCostStatus.BOSError = null;
            this.fld_lkeMMProductionCostStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionCostStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionCostStatus.Location = new System.Drawing.Point(100, 64);
            this.fld_lkeMMProductionCostStatus.Name = "fld_lkeMMProductionCostStatus";
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionCostStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionCostStatus.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeMMProductionCostStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionCostStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionCostStatus.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeMMProductionCostStatus.Screen = null;
            this.fld_lkeMMProductionCostStatus.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeMMProductionCostStatus.TabIndex = 371;
            this.fld_lkeMMProductionCostStatus.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(21, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 378;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Trạng thái";
            // 
            // fld_dteMMProductionCostFromDate
            // 
            this.fld_dteMMProductionCostFromDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostFromDate.BOSDataMember = "MMProductionCostFromDate";
            this.fld_dteMMProductionCostFromDate.BOSDataSource = "MMProductionCosts";
            this.fld_dteMMProductionCostFromDate.BOSDescription = null;
            this.fld_dteMMProductionCostFromDate.BOSError = null;
            this.fld_dteMMProductionCostFromDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostFromDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostFromDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostFromDate.EditValue = null;
            this.fld_dteMMProductionCostFromDate.Location = new System.Drawing.Point(100, 90);
            this.fld_dteMMProductionCostFromDate.Name = "fld_dteMMProductionCostFromDate";
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionCostFromDate, true);
            this.fld_dteMMProductionCostFromDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteMMProductionCostFromDate.TabIndex = 372;
            this.fld_dteMMProductionCostFromDate.Tag = "SC";
            // 
            // fld_dteMMProductionCostToDate
            // 
            this.fld_dteMMProductionCostToDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostToDate.BOSDataMember = "MMProductionCostToDate";
            this.fld_dteMMProductionCostToDate.BOSDataSource = "MMProductionCosts";
            this.fld_dteMMProductionCostToDate.BOSDescription = null;
            this.fld_dteMMProductionCostToDate.BOSError = null;
            this.fld_dteMMProductionCostToDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostToDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostToDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionCostToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostToDate.EditValue = null;
            this.fld_dteMMProductionCostToDate.Location = new System.Drawing.Point(360, 90);
            this.fld_dteMMProductionCostToDate.Name = "fld_dteMMProductionCostToDate";
            this.fld_dteMMProductionCostToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionCostToDate, true);
            this.fld_dteMMProductionCostToDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteMMProductionCostToDate.TabIndex = 373;
            this.fld_dteMMProductionCostToDate.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(21, 93);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 376;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Từ ngày";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(21, 15);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 377;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(294, 93);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 375;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(21, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 374;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_txtMMProductionCostNo
            // 
            this.fld_txtMMProductionCostNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostNo.BOSDataMember = "MMProductionCostNo";
            this.fld_txtMMProductionCostNo.BOSDataSource = "MMProductionCosts";
            this.fld_txtMMProductionCostNo.BOSDescription = null;
            this.fld_txtMMProductionCostNo.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostNo.Location = new System.Drawing.Point(100, 12);
            this.fld_txtMMProductionCostNo.Name = "fld_txtMMProductionCostNo";
            this.fld_txtMMProductionCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionCostNo, true);
            this.fld_txtMMProductionCostNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMProductionCostNo.TabIndex = 367;
            this.fld_txtMMProductionCostNo.Tag = "SC";
            // 
            // fld_txtMMProductionCostName
            // 
            this.fld_txtMMProductionCostName.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostName.BOSDataMember = "MMProductionCostName";
            this.fld_txtMMProductionCostName.BOSDataSource = "MMProductionCosts";
            this.fld_txtMMProductionCostName.BOSDescription = null;
            this.fld_txtMMProductionCostName.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostName.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostName.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostName.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostName.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostName.Location = new System.Drawing.Point(100, 38);
            this.fld_txtMMProductionCostName.Name = "fld_txtMMProductionCostName";
            this.fld_txtMMProductionCostName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionCostName, true);
            this.fld_txtMMProductionCostName.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMProductionCostName.TabIndex = 368;
            this.fld_txtMMProductionCostName.Tag = "SC";
            // 
            // SMPDC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeMMProductionCostStatus);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dgcMMProductionCosts);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_dteMMProductionCostFromDate);
            this.Controls.Add(this.fld_dteMMProductionCostToDate);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_txtMMProductionCostNo);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_txtMMProductionCostName);
            this.Name = "SMPDC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMProductionCostName, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProductionCostNo, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProductionCostToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProductionCostFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMProductionCosts, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMProductionCostStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcMMProductionCosts;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionCostStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostFromDate;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostToDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostNo;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostName;
        private IContainer components;
	}
}
