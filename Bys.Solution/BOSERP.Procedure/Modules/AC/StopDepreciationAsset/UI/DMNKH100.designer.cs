using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.StopDepreciationAsset.UI
{
	/// <summary>
	/// Summary description for DMNKH100
	/// </summary>
	partial class DMNKH100
	{
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtACStopDepreciationAssetNo;
		private BOSComponent.BOSDateEdit fld_dteACStopAllocationEquipmentDateStop;
        private BOSComponent.BOSDateEdit fld_dteACStopAllocationEquipmentDate;


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
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACStopDepreciationAssetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACStopAllocationEquipmentDateStop = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACStopAllocationEquipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACStopDepreciationAssetType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACStopDepreciationAssetReason = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACStopDepreciationAssetDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAssetID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopDepreciationAssetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACStopDepreciationAssetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopDepreciationAssetReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACStopDepreciationAssetDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.fld_lblLabel3.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel3.TabIndex = 4;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Text = "Mã chứng từ";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(19, 147);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 5;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Text = "Diễn giải";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.Location = new System.Drawing.Point(306, 69);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel5.TabIndex = 6;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.Text = "Ngày thực hiện";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.Location = new System.Drawing.Point(306, 43);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 7;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel6.Text = "Ngày chứng từ";
            // 
            // fld_txtACStopDepreciationAssetNo
            // 
            this.fld_txtACStopDepreciationAssetNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetNo.BOSDataMember = "ACStopDepreciationAssetNo";
            this.fld_txtACStopDepreciationAssetNo.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_txtACStopDepreciationAssetNo.BOSDescription = null;
            this.fld_txtACStopDepreciationAssetNo.BOSError = null;
            this.fld_txtACStopDepreciationAssetNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetNo.BOSPropertyName = "Text";
            this.fld_txtACStopDepreciationAssetNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetNo.Location = new System.Drawing.Point(118, 40);
            this.fld_txtACStopDepreciationAssetNo.Name = "fld_txtACStopDepreciationAssetNo";
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACStopDepreciationAssetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACStopDepreciationAssetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACStopDepreciationAssetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACStopDepreciationAssetNo.Screen = null;
            this.fld_txtACStopDepreciationAssetNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACStopDepreciationAssetNo.TabIndex = 0;
            this.fld_txtACStopDepreciationAssetNo.Tag = "DC";
            // 
            // fld_dteACStopAllocationEquipmentDateStop
            // 
            this.fld_dteACStopAllocationEquipmentDateStop.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSDataMember = "ACStopDepreciationAssetDateStop";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSDescription = null;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSError = null;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSPropertyName = "EditValue";
            this.fld_dteACStopAllocationEquipmentDateStop.EditValue = null;
            this.fld_dteACStopAllocationEquipmentDateStop.Location = new System.Drawing.Point(436, 66);
            this.fld_dteACStopAllocationEquipmentDateStop.Name = "fld_dteACStopAllocationEquipmentDateStop";
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopAllocationEquipmentDateStop.Screen = null;
            this.fld_dteACStopAllocationEquipmentDateStop.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACStopAllocationEquipmentDateStop.TabIndex = 3;
            this.fld_dteACStopAllocationEquipmentDateStop.Tag = "DC";
            // 
            // fld_dteACStopAllocationEquipmentDate
            // 
            this.fld_dteACStopAllocationEquipmentDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDate.BOSDataMember = "ACStopDepreciationAssetDate";
            this.fld_dteACStopAllocationEquipmentDate.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_dteACStopAllocationEquipmentDate.BOSDescription = null;
            this.fld_dteACStopAllocationEquipmentDate.BOSError = null;
            this.fld_dteACStopAllocationEquipmentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACStopAllocationEquipmentDate.BOSPropertyName = "EditValue";
            this.fld_dteACStopAllocationEquipmentDate.EditValue = null;
            this.fld_dteACStopAllocationEquipmentDate.Location = new System.Drawing.Point(436, 40);
            this.fld_dteACStopAllocationEquipmentDate.Name = "fld_dteACStopAllocationEquipmentDate";
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopAllocationEquipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopAllocationEquipmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopAllocationEquipmentDate.Screen = null;
            this.fld_dteACStopAllocationEquipmentDate.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACStopAllocationEquipmentDate.TabIndex = 1;
            this.fld_dteACStopAllocationEquipmentDate.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACStopDepreciationAssetType);
            this.bosGroupControl1.Controls.Add(this.fld_txtACStopDepreciationAssetReason);
            this.bosGroupControl1.Controls.Add(this.fld_medACStopDepreciationAssetDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAssetID1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtACStopDepreciationAssetNo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_dteACStopAllocationEquipmentDate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_dteACStopAllocationEquipmentDateStop);
            this.bosGroupControl1.Location = new System.Drawing.Point(4, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(663, 213);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
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
            this.bosLabel3.Location = new System.Drawing.Point(19, 69);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 24;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Loại";
            // 
            // fld_lkeACStopDepreciationAssetType
            // 
            this.fld_lkeACStopDepreciationAssetType.BOSAllowAddNew = false;
            this.fld_lkeACStopDepreciationAssetType.BOSAllowDummy = false;
            this.fld_lkeACStopDepreciationAssetType.BOSComment = null;
            this.fld_lkeACStopDepreciationAssetType.BOSDataMember = "ACStopDepreciationAssetType";
            this.fld_lkeACStopDepreciationAssetType.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_lkeACStopDepreciationAssetType.BOSDescription = null;
            this.fld_lkeACStopDepreciationAssetType.BOSError = null;
            this.fld_lkeACStopDepreciationAssetType.BOSFieldGroup = null;
            this.fld_lkeACStopDepreciationAssetType.BOSFieldParent = null;
            this.fld_lkeACStopDepreciationAssetType.BOSFieldRelation = null;
            this.fld_lkeACStopDepreciationAssetType.BOSPrivilege = null;
            this.fld_lkeACStopDepreciationAssetType.BOSPropertyName = "EditValue";
            this.fld_lkeACStopDepreciationAssetType.BOSSelectType = null;
            this.fld_lkeACStopDepreciationAssetType.BOSSelectTypeValue = null;
            this.fld_lkeACStopDepreciationAssetType.CurrentDisplayText = null;
            this.fld_lkeACStopDepreciationAssetType.Location = new System.Drawing.Point(118, 66);
            this.fld_lkeACStopDepreciationAssetType.Name = "fld_lkeACStopDepreciationAssetType";
            this.fld_lkeACStopDepreciationAssetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACStopDepreciationAssetType.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            this.fld_lkeACStopDepreciationAssetType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACStopDepreciationAssetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACStopDepreciationAssetType.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
            this.fld_lkeACStopDepreciationAssetType.Screen = null;
            this.fld_lkeACStopDepreciationAssetType.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeACStopDepreciationAssetType.TabIndex = 2;
            this.fld_lkeACStopDepreciationAssetType.Tag = "DC";
            // 
            // fld_txtACStopDepreciationAssetReason
            // 
            this.fld_txtACStopDepreciationAssetReason.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetReason.BOSDataMember = "ACStopDepreciationAssetReason";
            this.fld_txtACStopDepreciationAssetReason.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_txtACStopDepreciationAssetReason.BOSDescription = null;
            this.fld_txtACStopDepreciationAssetReason.BOSError = null;
            this.fld_txtACStopDepreciationAssetReason.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetReason.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetReason.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetReason.BOSPropertyName = "Text";
            this.fld_txtACStopDepreciationAssetReason.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACStopDepreciationAssetReason.Location = new System.Drawing.Point(118, 118);
            this.fld_txtACStopDepreciationAssetReason.Name = "fld_txtACStopDepreciationAssetReason";
            this.fld_txtACStopDepreciationAssetReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACStopDepreciationAssetReason.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACStopDepreciationAssetReason.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACStopDepreciationAssetReason.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACStopDepreciationAssetReason.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACStopDepreciationAssetReason.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACStopDepreciationAssetReason.Screen = null;
            this.fld_txtACStopDepreciationAssetReason.Size = new System.Drawing.Size(480, 20);
            this.fld_txtACStopDepreciationAssetReason.TabIndex = 5;
            this.fld_txtACStopDepreciationAssetReason.Tag = "DC";
            // 
            // fld_medACStopDepreciationAssetDesc
            // 
            this.fld_medACStopDepreciationAssetDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACStopDepreciationAssetDesc.BOSDataMember = "ACStopDepreciationAssetDesc";
            this.fld_medACStopDepreciationAssetDesc.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_medACStopDepreciationAssetDesc.BOSDescription = null;
            this.fld_medACStopDepreciationAssetDesc.BOSError = null;
            this.fld_medACStopDepreciationAssetDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACStopDepreciationAssetDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACStopDepreciationAssetDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACStopDepreciationAssetDesc.BOSPropertyName = "Text";
            this.fld_medACStopDepreciationAssetDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACStopDepreciationAssetDesc.Location = new System.Drawing.Point(118, 144);
            this.fld_medACStopDepreciationAssetDesc.Name = "fld_medACStopDepreciationAssetDesc";
            this.fld_medACStopDepreciationAssetDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACStopDepreciationAssetDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACStopDepreciationAssetDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACStopDepreciationAssetDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACStopDepreciationAssetDesc.Screen = null;
            this.fld_medACStopDepreciationAssetDesc.Size = new System.Drawing.Size(480, 57);
            this.fld_medACStopDepreciationAssetDesc.TabIndex = 6;
            this.fld_medACStopDepreciationAssetDesc.Tag = "DC";
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
            this.bosLabel1.Size = new System.Drawing.Size(26, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Lý do";
            // 
            // fld_lkeFK_ACAssetID1
            // 
            this.fld_lkeFK_ACAssetID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssetID1.BOSAllowDummy = false;
            this.fld_lkeFK_ACAssetID1.BOSComment = null;
            this.fld_lkeFK_ACAssetID1.BOSDataMember = "FK_ACAssetID";
            this.fld_lkeFK_ACAssetID1.BOSDataSource = "ACStopDepreciationAssets";
            this.fld_lkeFK_ACAssetID1.BOSDescription = null;
            this.fld_lkeFK_ACAssetID1.BOSError = null;
            this.fld_lkeFK_ACAssetID1.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssetID1.BOSFieldParent = null;
            this.fld_lkeFK_ACAssetID1.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssetID1.BOSPrivilege = null;
            this.fld_lkeFK_ACAssetID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssetID1.BOSSelectType = null;
            this.fld_lkeFK_ACAssetID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAssetID1.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssetID1.Location = new System.Drawing.Point(118, 92);
            this.fld_lkeFK_ACAssetID1.Name = "fld_lkeFK_ACAssetID1";
            this.fld_lkeFK_ACAssetID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssetID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetNo", "Mã TSCĐ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetName", "Tên TSCĐ")});
            this.fld_lkeFK_ACAssetID1.Properties.DisplayMember = "ACAssetNo";
            this.fld_lkeFK_ACAssetID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACAssetID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAssetID1.Properties.ValueMember = "ACAssetID";
            this.fld_lkeFK_ACAssetID1.Screen = null;
            this.fld_lkeFK_ACAssetID1.Size = new System.Drawing.Size(479, 20);
            this.fld_lkeFK_ACAssetID1.TabIndex = 4;
            this.fld_lkeFK_ACAssetID1.Tag = "DC";
            this.fld_lkeFK_ACAssetID1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ACAssetID_QueryPopUp);
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
            this.bosLabel12.Location = new System.Drawing.Point(19, 95);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(61, 13);
            this.bosLabel12.TabIndex = 7;
            this.bosLabel12.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.Text = "Số thẻ TSCĐ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.bosGroupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 219);
            this.panel1.TabIndex = 6;
            // 
            // DMNKH100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(674, 219);
            this.Controls.Add(this.panel1);
            this.Name = "DMNKH100";
            this.Tag = "DM";
            this.Text = "`";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopDepreciationAssetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACStopDepreciationAssetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopDepreciationAssetReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACStopDepreciationAssetDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAssetID1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit fld_medACStopDepreciationAssetDesc;
        private BOSComponent.BOSTextBox fld_txtACStopDepreciationAssetReason;
        private Panel panel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeACStopDepreciationAssetType;
	}
}
