using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRLabouringConfig.UI
{
	/// <summary>
	/// Summary description for DMHRLC100
	/// </summary>
	partial class DMHRLC100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private HRLabouringConfigItemsGridControl fld_dgcHRLabouringConfigItems;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRLabouringConfigItems;
        private BOSComponent.BOSTextBox fld_txtHRLabouringConfigNo;
        private BOSComponent.BOSDateEdit fld_dteHRLabouringConfigFromDate;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;


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
            this.fld_medHRLabouringConfigDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRLabouringConfigDateType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRLabouringConfigNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRLabouringConfigFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRLabouringConfigItems = new BOSERP.Modules.HRLabouringConfig.HRLabouringConfigItemsGridControl();
            this.fld_dgvHRLabouringConfigItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLabouringConfigDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLabouringConfigDateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLabouringConfigNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLabouringConfigFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLabouringConfigFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRLabouringConfigItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRLabouringConfigItems)).BeginInit();
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
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRLabouringConfigDesc);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHRLabouringConfigDateType);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRLabouringConfigNo);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHRLabouringConfigFromDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(899, 100);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_medHRLabouringConfigDesc
            // 
            this.fld_medHRLabouringConfigDesc.BOSComment = null;
            this.fld_medHRLabouringConfigDesc.BOSDataMember = "HRLabouringConfigDesc";
            this.fld_medHRLabouringConfigDesc.BOSDataSource = "HRLabouringConfigs";
            this.fld_medHRLabouringConfigDesc.BOSDescription = null;
            this.fld_medHRLabouringConfigDesc.BOSError = null;
            this.fld_medHRLabouringConfigDesc.BOSFieldGroup = null;
            this.fld_medHRLabouringConfigDesc.BOSFieldRelation = null;
            this.fld_medHRLabouringConfigDesc.BOSPrivilege = null;
            this.fld_medHRLabouringConfigDesc.BOSPropertyName = "EditValue";
            this.fld_medHRLabouringConfigDesc.Location = new System.Drawing.Point(84, 54);
            this.fld_medHRLabouringConfigDesc.MenuManager = this.screenToolbar;
            this.fld_medHRLabouringConfigDesc.Name = "fld_medHRLabouringConfigDesc";
            this.fld_medHRLabouringConfigDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRLabouringConfigDesc, true);
            this.fld_medHRLabouringConfigDesc.Size = new System.Drawing.Size(675, 35);
            this.fld_medHRLabouringConfigDesc.TabIndex = 565;
            this.fld_medHRLabouringConfigDesc.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(12, 56);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 566;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_lkeHRLabouringConfigDateType
            // 
            this.fld_lkeHRLabouringConfigDateType.BOSAllowAddNew = false;
            this.fld_lkeHRLabouringConfigDateType.BOSAllowDummy = false;
            this.fld_lkeHRLabouringConfigDateType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.BOSDataMember = "HRLabouringConfigDateType";
            this.fld_lkeHRLabouringConfigDateType.BOSDataSource = "HRLabouringConfigs";
            this.fld_lkeHRLabouringConfigDateType.BOSDescription = null;
            this.fld_lkeHRLabouringConfigDateType.BOSError = null;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.BOSPropertyName = "EditValue";
            this.fld_lkeHRLabouringConfigDateType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.CurrentDisplayText = null;
            this.fld_lkeHRLabouringConfigDateType.Location = new System.Drawing.Point(322, 28);
            this.fld_lkeHRLabouringConfigDateType.Name = "fld_lkeHRLabouringConfigDateType";
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRLabouringConfigDateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRLabouringConfigDateType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRLabouringConfigDateType.Properties.PopupWidth = 40;
            this.fld_lkeHRLabouringConfigDateType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRLabouringConfigDateType.Screen = null;
            this.fld_lkeHRLabouringConfigDateType.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeHRLabouringConfigDateType.TabIndex = 563;
            this.fld_lkeHRLabouringConfigDateType.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(280, 31);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(20, 13);
            this.bosLabel13.TabIndex = 564;
            this.bosLabel13.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.Text = "Loại";
            // 
            // fld_txtHRLabouringConfigNo
            // 
            this.fld_txtHRLabouringConfigNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRLabouringConfigNo.BOSDataMember = "HRLabouringConfigNo";
            this.fld_txtHRLabouringConfigNo.BOSDataSource = "HRLabouringConfigs";
            this.fld_txtHRLabouringConfigNo.BOSDescription = null;
            this.fld_txtHRLabouringConfigNo.BOSError = null;
            this.fld_txtHRLabouringConfigNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRLabouringConfigNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRLabouringConfigNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRLabouringConfigNo.BOSPropertyName = "Text";
            this.fld_txtHRLabouringConfigNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRLabouringConfigNo.Location = new System.Drawing.Point(84, 28);
            this.fld_txtHRLabouringConfigNo.Name = "fld_txtHRLabouringConfigNo";
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLabouringConfigNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLabouringConfigNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLabouringConfigNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLabouringConfigNo.Screen = null;
            this.fld_txtHRLabouringConfigNo.Size = new System.Drawing.Size(158, 20);
            this.fld_txtHRLabouringConfigNo.TabIndex = 0;
            this.fld_txtHRLabouringConfigNo.Tag = "DC";
            // 
            // fld_dteHRLabouringConfigFromDate
            // 
            this.fld_dteHRLabouringConfigFromDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRLabouringConfigFromDate.BOSDataMember = "HRLabouringConfigDate";
            this.fld_dteHRLabouringConfigFromDate.BOSDataSource = "HRLabouringConfigs";
            this.fld_dteHRLabouringConfigFromDate.BOSDescription = null;
            this.fld_dteHRLabouringConfigFromDate.BOSError = null;
            this.fld_dteHRLabouringConfigFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRLabouringConfigFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRLabouringConfigFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRLabouringConfigFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRLabouringConfigFromDate.EditValue = null;
            this.fld_dteHRLabouringConfigFromDate.Location = new System.Drawing.Point(573, 28);
            this.fld_dteHRLabouringConfigFromDate.Name = "fld_dteHRLabouringConfigFromDate";
            this.fld_dteHRLabouringConfigFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRLabouringConfigFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRLabouringConfigFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRLabouringConfigFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRLabouringConfigFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRLabouringConfigFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRLabouringConfigFromDate.Screen = null;
            this.fld_dteHRLabouringConfigFromDate.Size = new System.Drawing.Size(186, 20);
            this.fld_dteHRLabouringConfigFromDate.TabIndex = 2;
            this.fld_dteHRLabouringConfigFromDate.Tag = "DC";
            this.fld_dteHRLabouringConfigFromDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_dteHRLabouringConfigFromDate_EditValueChanging);
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
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 31);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 13;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Location = new System.Drawing.Point(533, 31);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel6.TabIndex = 15;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Ngày";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRLabouringConfigItems);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 106);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(899, 488);
            this.fld_grcGroupControl1.TabIndex = 5;
            this.fld_grcGroupControl1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHRLabouringConfigItems
            // 
            this.fld_dgcHRLabouringConfigItems.AllowDrop = true;
            this.fld_dgcHRLabouringConfigItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRLabouringConfigItems.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRLabouringConfigItems.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRLabouringConfigItems.BOSDataSource = "HRLabouringConfigItems";
            this.fld_dgcHRLabouringConfigItems.BOSDescription = null;
            this.fld_dgcHRLabouringConfigItems.BOSError = null;
            this.fld_dgcHRLabouringConfigItems.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRLabouringConfigItems.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRLabouringConfigItems.BOSGridType = null;
            this.fld_dgcHRLabouringConfigItems.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRLabouringConfigItems.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRLabouringConfigItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRLabouringConfigItems.Location = new System.Drawing.Point(5, 22);
            this.fld_dgcHRLabouringConfigItems.MainView = this.fld_dgvHRLabouringConfigItems;
            this.fld_dgcHRLabouringConfigItems.Name = "fld_dgcHRLabouringConfigItems";
            this.fld_dgcHRLabouringConfigItems.PrintReport = false;
            this.fld_dgcHRLabouringConfigItems.Screen = null;
            this.fld_dgcHRLabouringConfigItems.Size = new System.Drawing.Size(897, 461);
            this.fld_dgcHRLabouringConfigItems.TabIndex = 0;
            this.fld_dgcHRLabouringConfigItems.Tag = "DC";
            this.fld_dgcHRLabouringConfigItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRLabouringConfigItems});
            // 
            // fld_dgvHRLabouringConfigItems
            // 
            this.fld_dgvHRLabouringConfigItems.GridControl = this.fld_dgcHRLabouringConfigItems;
            this.fld_dgvHRLabouringConfigItems.Name = "fld_dgvHRLabouringConfigItems";
            this.fld_dgvHRLabouringConfigItems.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(899, 594);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMHRLC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(899, 594);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRLC100";
            this.Text = "Thông tin tăng ca";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLabouringConfigDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLabouringConfigDateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLabouringConfigNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLabouringConfigFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLabouringConfigFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRLabouringConfigItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRLabouringConfigItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeHRLabouringConfigDateType;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSMemoEdit fld_medHRLabouringConfigDesc;
        private BOSComponent.BOSLabel bosLabel5;
	}
}
