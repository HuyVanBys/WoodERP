using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPI.UI
{
	/// <summary>
	/// Summary description for DMUCC100
	/// </summary>
	partial class DMKPI100
	{
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtHRKPINo;
        private BOSComponent.BOSTextBox fld_txHRKPIName;


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
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPINo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txHRKPIName = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHRKPIStore = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRKPIGuide = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_ccbeHRDerpartment = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.fld_chkIsReverseTarget = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPITarget = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkHRKPIIsActive = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_medHRKPIMeasurementMethod = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPINo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txHRKPIName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRKPIGuide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeHRDerpartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsReverseTarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPITarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkHRKPIIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRKPIMeasurementMethod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Location = new System.Drawing.Point(19, 43);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel3.TabIndex = 4;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Text = "Mã KPI";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Location = new System.Drawing.Point(19, 69);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel4.TabIndex = 5;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Text = "Tên KPI";
            // 
            // fld_txtHRKPINo
            // 
            this.fld_txtHRKPINo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPINo.BOSDataMember = "HRKPINo";
            this.fld_txtHRKPINo.BOSDataSource = "HRKPIs";
            this.fld_txtHRKPINo.BOSDescription = null;
            this.fld_txtHRKPINo.BOSError = null;
            this.fld_txtHRKPINo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPINo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPINo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPINo.BOSPropertyName = "Text";
            this.fld_txtHRKPINo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPINo.Location = new System.Drawing.Point(119, 40);
            this.fld_txtHRKPINo.Name = "fld_txtHRKPINo";
            this.fld_txtHRKPINo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPINo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPINo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPINo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPINo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPINo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPINo.Screen = null;
            this.fld_txtHRKPINo.Size = new System.Drawing.Size(205, 20);
            this.fld_txtHRKPINo.TabIndex = 0;
            this.fld_txtHRKPINo.Tag = "DC";
            // 
            // fld_txHRKPIName
            // 
            this.fld_txHRKPIName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txHRKPIName.BOSDataMember = "HRKPIName";
            this.fld_txHRKPIName.BOSDataSource = "HRKPIs";
            this.fld_txHRKPIName.BOSDescription = null;
            this.fld_txHRKPIName.BOSError = null;
            this.fld_txHRKPIName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txHRKPIName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txHRKPIName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txHRKPIName.BOSPropertyName = "Text";
            this.fld_txHRKPIName.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txHRKPIName.Location = new System.Drawing.Point(119, 66);
            this.fld_txHRKPIName.Name = "fld_txHRKPIName";
            this.fld_txHRKPIName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txHRKPIName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txHRKPIName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txHRKPIName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txHRKPIName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txHRKPIName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txHRKPIName.Screen = null;
            this.fld_txHRKPIName.Size = new System.Drawing.Size(762, 20);
            this.fld_txHRKPIName.TabIndex = 1;
            this.fld_txHRKPIName.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_txtHRKPIStore);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_medHRKPIGuide);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_ccbeHRDerpartment);
            this.bosGroupControl1.Controls.Add(this.fld_chkIsReverseTarget);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRKPITarget);
            this.bosGroupControl1.Controls.Add(this.fld_chkHRKPIIsActive);
            this.bosGroupControl1.Controls.Add(this.fld_medHRKPIMeasurementMethod);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRKPINo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_txHRKPIName);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 4);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(888, 382);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_txtHRKPIStore
            // 
            this.fld_txtHRKPIStore.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPIStore.BOSDataMember = "HRKPIStore";
            this.fld_txtHRKPIStore.BOSDataSource = "HRKPIs";
            this.fld_txtHRKPIStore.BOSDescription = null;
            this.fld_txtHRKPIStore.BOSError = null;
            this.fld_txtHRKPIStore.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPIStore.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPIStore.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPIStore.BOSPropertyName = "Text";
            this.fld_txtHRKPIStore.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPIStore.Location = new System.Drawing.Point(119, 303);
            this.fld_txtHRKPIStore.Name = "fld_txtHRKPIStore";
            this.fld_txtHRKPIStore.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPIStore.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPIStore.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPIStore.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPIStore.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPIStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPIStore.Screen = null;
            this.fld_txtHRKPIStore.Size = new System.Drawing.Size(762, 20);
            this.fld_txtHRKPIStore.TabIndex = 6;
            this.fld_txtHRKPIStore.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Location = new System.Drawing.Point(19, 306);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(78, 13);
            this.bosLabel4.TabIndex = 21;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Text = "Store Procedure";
            // 
            // fld_medHRKPIGuide
            // 
            this.fld_medHRKPIGuide.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIGuide.BOSDataMember = "HRKPIGuide";
            this.fld_medHRKPIGuide.BOSDataSource = "HRKPIs";
            this.fld_medHRKPIGuide.BOSDescription = null;
            this.fld_medHRKPIGuide.BOSError = null;
            this.fld_medHRKPIGuide.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIGuide.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIGuide.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIGuide.BOSPropertyName = "Text";
            this.fld_medHRKPIGuide.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIGuide.Location = new System.Drawing.Point(119, 144);
            this.fld_medHRKPIGuide.Name = "fld_medHRKPIGuide";
            this.fld_medHRKPIGuide.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRKPIGuide.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRKPIGuide.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRKPIGuide.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRKPIGuide.Screen = null;
            this.fld_medHRKPIGuide.Size = new System.Drawing.Size(762, 42);
            this.fld_medHRKPIGuide.TabIndex = 4;
            this.fld_medHRKPIGuide.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Location = new System.Drawing.Point(19, 95);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(51, 13);
            this.bosLabel3.TabIndex = 19;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Phòng ban";
            // 
            // fld_ccbeHRDerpartment
            // 
            this.fld_ccbeHRDerpartment.Location = new System.Drawing.Point(119, 92);
            this.fld_ccbeHRDerpartment.MenuManager = this.screenToolbar;
            this.fld_ccbeHRDerpartment.Name = "fld_ccbeHRDerpartment";
            this.fld_ccbeHRDerpartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ccbeHRDerpartment.Size = new System.Drawing.Size(762, 20);
            this.fld_ccbeHRDerpartment.TabIndex = 2;
            this.fld_ccbeHRDerpartment.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_ccbeHRDerpartment_CloseUp);
            this.fld_ccbeHRDerpartment.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_ccbeHRDerpartment_QueryPopUp);
            // 
            // fld_chkIsReverseTarget
            // 
            this.fld_chkIsReverseTarget.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkIsReverseTarget.BOSDataMember = "IsReverseTarget";
            this.fld_chkIsReverseTarget.BOSDataSource = "HRKPIs";
            this.fld_chkIsReverseTarget.BOSDescription = null;
            this.fld_chkIsReverseTarget.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkIsReverseTarget.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkIsReverseTarget.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkIsReverseTarget.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkIsReverseTarget.BOSPropertyName = "EditValue";
            this.fld_chkIsReverseTarget.Location = new System.Drawing.Point(117, 354);
            this.fld_chkIsReverseTarget.Name = "fld_chkIsReverseTarget";
            this.fld_chkIsReverseTarget.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkIsReverseTarget.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkIsReverseTarget.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkIsReverseTarget.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkIsReverseTarget.Properties.Caption = "Chỉ tiêu ngược";
            this.fld_chkIsReverseTarget.Screen = null;
            this.fld_chkIsReverseTarget.Size = new System.Drawing.Size(142, 19);
            this.fld_chkIsReverseTarget.TabIndex = 8;
            this.fld_chkIsReverseTarget.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(19, 147);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(80, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "Hướng dẫn nhập";
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
            this.bosLabel1.Location = new System.Drawing.Point(19, 121);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(93, 13);
            this.bosLabel1.TabIndex = 15;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Mục tiêu tham khảo";
            // 
            // fld_txtHRKPITarget
            // 
            this.fld_txtHRKPITarget.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPITarget.BOSDataMember = "HRKPITarget";
            this.fld_txtHRKPITarget.BOSDataSource = "HRKPIs";
            this.fld_txtHRKPITarget.BOSDescription = null;
            this.fld_txtHRKPITarget.BOSError = null;
            this.fld_txtHRKPITarget.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPITarget.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPITarget.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPITarget.BOSPropertyName = "Text";
            this.fld_txtHRKPITarget.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRKPITarget.Location = new System.Drawing.Point(119, 118);
            this.fld_txtHRKPITarget.Name = "fld_txtHRKPITarget";
            this.fld_txtHRKPITarget.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPITarget.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPITarget.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPITarget.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPITarget.Properties.Mask.EditMask = "n";
            this.fld_txtHRKPITarget.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRKPITarget.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPITarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPITarget.Screen = null;
            this.fld_txtHRKPITarget.Size = new System.Drawing.Size(205, 20);
            this.fld_txtHRKPITarget.TabIndex = 3;
            this.fld_txtHRKPITarget.Tag = "DC";
            // 
            // fld_chkHRKPIIsActive
            // 
            this.fld_chkHRKPIIsActive.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkHRKPIIsActive.BOSDataMember = "HRKPIIsActive";
            this.fld_chkHRKPIIsActive.BOSDataSource = "HRKPIs";
            this.fld_chkHRKPIIsActive.BOSDescription = null;
            this.fld_chkHRKPIIsActive.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkHRKPIIsActive.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkHRKPIIsActive.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkHRKPIIsActive.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkHRKPIIsActive.BOSPropertyName = "EditValue";
            this.fld_chkHRKPIIsActive.Location = new System.Drawing.Point(117, 329);
            this.fld_chkHRKPIIsActive.Name = "fld_chkHRKPIIsActive";
            this.fld_chkHRKPIIsActive.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkHRKPIIsActive.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkHRKPIIsActive.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkHRKPIIsActive.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkHRKPIIsActive.Properties.Caption = "Hoạt động";
            this.fld_chkHRKPIIsActive.Screen = null;
            this.fld_chkHRKPIIsActive.Size = new System.Drawing.Size(81, 19);
            this.fld_chkHRKPIIsActive.TabIndex = 7;
            this.fld_chkHRKPIIsActive.Tag = "DC";
            // 
            // fld_medHRKPIMeasurementMethod
            // 
            this.fld_medHRKPIMeasurementMethod.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIMeasurementMethod.BOSDataMember = "HRKPIMeasurementMethod";
            this.fld_medHRKPIMeasurementMethod.BOSDataSource = "HRKPIs";
            this.fld_medHRKPIMeasurementMethod.BOSDescription = null;
            this.fld_medHRKPIMeasurementMethod.BOSError = null;
            this.fld_medHRKPIMeasurementMethod.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIMeasurementMethod.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIMeasurementMethod.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIMeasurementMethod.BOSPropertyName = "Text";
            this.fld_medHRKPIMeasurementMethod.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHRKPIMeasurementMethod.Location = new System.Drawing.Point(119, 192);
            this.fld_medHRKPIMeasurementMethod.Name = "fld_medHRKPIMeasurementMethod";
            this.fld_medHRKPIMeasurementMethod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRKPIMeasurementMethod.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRKPIMeasurementMethod.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRKPIMeasurementMethod.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRKPIMeasurementMethod.Screen = null;
            this.fld_medHRKPIMeasurementMethod.Size = new System.Drawing.Size(762, 105);
            this.fld_medHRKPIMeasurementMethod.TabIndex = 5;
            this.fld_medHRKPIMeasurementMethod.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.Location = new System.Drawing.Point(19, 195);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(79, 13);
            this.bosLabel12.TabIndex = 7;
            this.bosLabel12.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.Text = "Phương pháp đo";
            // 
            // DMKPI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(896, 388);
            this.Controls.Add(this.bosGroupControl1);
            this.Name = "DMKPI100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPINo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txHRKPIName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRKPIGuide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeHRDerpartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsReverseTarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPITarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkHRKPIIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRKPIMeasurementMethod.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSMemoEdit fld_medHRKPIMeasurementMethod;
        private BOSComponent.BOSCheckEdit fld_chkHRKPIIsActive;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHRKPITarget;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSCheckEdit fld_chkIsReverseTarget;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_ccbeHRDerpartment;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medHRKPIGuide;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHRKPIStore;
	}
}
