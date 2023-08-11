using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.StopAllocationEquipment.UI
{
	/// <summary>
	/// Summary description for DMNPB100
	/// </summary>
	partial class DMNPB100
	{
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtACStopAllocationEquipmentNo;
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
            this.fld_txtACStopAllocationEquipmentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACStopAllocationEquipmentDateStop = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACStopAllocationEquipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACStopAllocationEquipmentType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACStopAllocationEquipmentReason = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACStopAllocationEquipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ICProductIdentifiedEquipmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopAllocationEquipmentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACStopAllocationEquipmentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopAllocationEquipmentReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACStopAllocationEquipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(19, 43);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel3.TabIndex = 4;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Mã chứng từ";
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
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(19, 147);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 5;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Diễn giải";
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
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(307, 95);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel5.TabIndex = 6;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày thực hiện";
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
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(19, 95);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 7;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Ngày chứng từ";
            // 
            // fld_txtACStopAllocationEquipmentNo
            // 
            this.fld_txtACStopAllocationEquipmentNo.BOSComment = "";
            this.fld_txtACStopAllocationEquipmentNo.BOSDataMember = "ACStopAllocationEquipmentNo";
            this.fld_txtACStopAllocationEquipmentNo.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_txtACStopAllocationEquipmentNo.BOSDescription = null;
            this.fld_txtACStopAllocationEquipmentNo.BOSError = null;
            this.fld_txtACStopAllocationEquipmentNo.BOSFieldGroup = "";
            this.fld_txtACStopAllocationEquipmentNo.BOSFieldRelation = "";
            this.fld_txtACStopAllocationEquipmentNo.BOSPrivilege = "";
            this.fld_txtACStopAllocationEquipmentNo.BOSPropertyName = "Text";
            this.fld_txtACStopAllocationEquipmentNo.EditValue = "";
            this.fld_txtACStopAllocationEquipmentNo.Location = new System.Drawing.Point(118, 40);
            this.fld_txtACStopAllocationEquipmentNo.Name = "fld_txtACStopAllocationEquipmentNo";
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACStopAllocationEquipmentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACStopAllocationEquipmentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACStopAllocationEquipmentNo.Screen = null;
            this.fld_txtACStopAllocationEquipmentNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACStopAllocationEquipmentNo.TabIndex = 0;
            this.fld_txtACStopAllocationEquipmentNo.Tag = "DC";
            // 
            // fld_dteACStopAllocationEquipmentDateStop
            // 
            this.fld_dteACStopAllocationEquipmentDateStop.BOSComment = "";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSDataMember = "ACStopAllocationEquipmentDateStop";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSDescription = null;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSError = null;
            this.fld_dteACStopAllocationEquipmentDateStop.BOSFieldGroup = "";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSFieldRelation = "";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSPrivilege = "";
            this.fld_dteACStopAllocationEquipmentDateStop.BOSPropertyName = "EditValue";
            this.fld_dteACStopAllocationEquipmentDateStop.EditValue = null;
            this.fld_dteACStopAllocationEquipmentDateStop.Location = new System.Drawing.Point(437, 92);
            this.fld_dteACStopAllocationEquipmentDateStop.Name = "fld_dteACStopAllocationEquipmentDateStop";
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopAllocationEquipmentDateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopAllocationEquipmentDateStop.Screen = null;
            this.fld_dteACStopAllocationEquipmentDateStop.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACStopAllocationEquipmentDateStop.TabIndex = 5;
            this.fld_dteACStopAllocationEquipmentDateStop.Tag = "DC";
            // 
            // fld_dteACStopAllocationEquipmentDate
            // 
            this.fld_dteACStopAllocationEquipmentDate.BOSComment = "";
            this.fld_dteACStopAllocationEquipmentDate.BOSDataMember = "ACStopAllocationEquipmentDate";
            this.fld_dteACStopAllocationEquipmentDate.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_dteACStopAllocationEquipmentDate.BOSDescription = null;
            this.fld_dteACStopAllocationEquipmentDate.BOSError = null;
            this.fld_dteACStopAllocationEquipmentDate.BOSFieldGroup = "";
            this.fld_dteACStopAllocationEquipmentDate.BOSFieldRelation = "";
            this.fld_dteACStopAllocationEquipmentDate.BOSPrivilege = "";
            this.fld_dteACStopAllocationEquipmentDate.BOSPropertyName = "EditValue";
            this.fld_dteACStopAllocationEquipmentDate.EditValue = null;
            this.fld_dteACStopAllocationEquipmentDate.Location = new System.Drawing.Point(118, 92);
            this.fld_dteACStopAllocationEquipmentDate.Name = "fld_dteACStopAllocationEquipmentDate";
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopAllocationEquipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopAllocationEquipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopAllocationEquipmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopAllocationEquipmentDate.Screen = null;
            this.fld_dteACStopAllocationEquipmentDate.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACStopAllocationEquipmentDate.TabIndex = 4;
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeACStopAllocationEquipmentType);
            this.bosGroupControl1.Controls.Add(this.fld_txtACStopAllocationEquipmentReason);
            this.bosGroupControl1.Controls.Add(this.fld_medACStopAllocationEquipmentDesc);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductIdentifiedEquipmentID);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtACStopAllocationEquipmentNo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_dteACStopAllocationEquipmentDate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_dteACStopAllocationEquipmentDateStop);
            this.bosGroupControl1.Location = new System.Drawing.Point(4, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(669, 231);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(307, 43);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 22;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại";
            // 
            // fld_lkeACStopAllocationEquipmentType
            // 
            this.fld_lkeACStopAllocationEquipmentType.BOSAllowAddNew = false;
            this.fld_lkeACStopAllocationEquipmentType.BOSAllowDummy = false;
            this.fld_lkeACStopAllocationEquipmentType.BOSComment = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSDataMember = "ACStopAllocationEquipmentType";
            this.fld_lkeACStopAllocationEquipmentType.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_lkeACStopAllocationEquipmentType.BOSDescription = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSError = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSFieldGroup = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSFieldParent = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSFieldRelation = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSPrivilege = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSPropertyName = "EditValue";
            this.fld_lkeACStopAllocationEquipmentType.BOSSelectType = null;
            this.fld_lkeACStopAllocationEquipmentType.BOSSelectTypeValue = null;
            this.fld_lkeACStopAllocationEquipmentType.CurrentDisplayText = null;
            this.fld_lkeACStopAllocationEquipmentType.Location = new System.Drawing.Point(437, 40);
            this.fld_lkeACStopAllocationEquipmentType.Name = "fld_lkeACStopAllocationEquipmentType";
            this.fld_lkeACStopAllocationEquipmentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACStopAllocationEquipmentType.Properties.ColumnName = null;
            this.fld_lkeACStopAllocationEquipmentType.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            this.fld_lkeACStopAllocationEquipmentType.Properties.NullText = "";
            this.fld_lkeACStopAllocationEquipmentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACStopAllocationEquipmentType.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
            this.fld_lkeACStopAllocationEquipmentType.Screen = null;
            this.fld_lkeACStopAllocationEquipmentType.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeACStopAllocationEquipmentType.TabIndex = 1;
            this.fld_lkeACStopAllocationEquipmentType.Tag = "DC";
            // 
            // fld_txtACStopAllocationEquipmentReason
            // 
            this.fld_txtACStopAllocationEquipmentReason.BOSComment = "";
            this.fld_txtACStopAllocationEquipmentReason.BOSDataMember = "ACStopAllocationEquipmentReason";
            this.fld_txtACStopAllocationEquipmentReason.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_txtACStopAllocationEquipmentReason.BOSDescription = null;
            this.fld_txtACStopAllocationEquipmentReason.BOSError = null;
            this.fld_txtACStopAllocationEquipmentReason.BOSFieldGroup = "";
            this.fld_txtACStopAllocationEquipmentReason.BOSFieldRelation = "";
            this.fld_txtACStopAllocationEquipmentReason.BOSPrivilege = "";
            this.fld_txtACStopAllocationEquipmentReason.BOSPropertyName = "Text";
            this.fld_txtACStopAllocationEquipmentReason.EditValue = "";
            this.fld_txtACStopAllocationEquipmentReason.Location = new System.Drawing.Point(118, 118);
            this.fld_txtACStopAllocationEquipmentReason.Name = "fld_txtACStopAllocationEquipmentReason";
            this.fld_txtACStopAllocationEquipmentReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACStopAllocationEquipmentReason.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACStopAllocationEquipmentReason.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACStopAllocationEquipmentReason.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACStopAllocationEquipmentReason.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACStopAllocationEquipmentReason.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACStopAllocationEquipmentReason.Screen = null;
            this.fld_txtACStopAllocationEquipmentReason.Size = new System.Drawing.Size(480, 20);
            this.fld_txtACStopAllocationEquipmentReason.TabIndex = 6;
            this.fld_txtACStopAllocationEquipmentReason.Tag = "DC";
            // 
            // fld_medACStopAllocationEquipmentDesc
            // 
            this.fld_medACStopAllocationEquipmentDesc.BOSComment = "";
            this.fld_medACStopAllocationEquipmentDesc.BOSDataMember = "ACStopAllocationEquipmentDesc";
            this.fld_medACStopAllocationEquipmentDesc.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_medACStopAllocationEquipmentDesc.BOSDescription = null;
            this.fld_medACStopAllocationEquipmentDesc.BOSError = null;
            this.fld_medACStopAllocationEquipmentDesc.BOSFieldGroup = "";
            this.fld_medACStopAllocationEquipmentDesc.BOSFieldRelation = "";
            this.fld_medACStopAllocationEquipmentDesc.BOSPrivilege = "";
            this.fld_medACStopAllocationEquipmentDesc.BOSPropertyName = "Text";
            this.fld_medACStopAllocationEquipmentDesc.EditValue = "";
            this.fld_medACStopAllocationEquipmentDesc.Location = new System.Drawing.Point(118, 144);
            this.fld_medACStopAllocationEquipmentDesc.Name = "fld_medACStopAllocationEquipmentDesc";
            this.fld_medACStopAllocationEquipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACStopAllocationEquipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACStopAllocationEquipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACStopAllocationEquipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACStopAllocationEquipmentDesc.Screen = null;
            this.fld_medACStopAllocationEquipmentDesc.Size = new System.Drawing.Size(480, 57);
            this.fld_medACStopAllocationEquipmentDesc.TabIndex = 7;
            this.fld_medACStopAllocationEquipmentDesc.Tag = "DC";
            // 
            // fld_lkeFK_ICProductIdentifiedEquipmentID
            // 
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSComment = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSDataMember = "FK_ICProductIdentifiedEquipmentID";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSDescription = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSError = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSSelectType = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Location = new System.Drawing.Point(437, 66);
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Name = "fld_lkeFK_ICProductIdentifiedEquipmentID";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh")});
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.NullText = "";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Screen = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.TabIndex = 3;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Tag = "DC";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductIdentifiedEquipmentID_QueryPopUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(307, 69);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(64, 13);
            this.bosLabel2.TabIndex = 20;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã định danh";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(19, 121);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(26, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Lý do";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = null;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(118, 66);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã CCDC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên CCDC")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 2;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryPopUp);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(19, 69);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(45, 13);
            this.bosLabel12.TabIndex = 7;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Mã CCDC";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.bosGroupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 253);
            this.panel1.TabIndex = 6;
            // 
            // DMNPB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(684, 253);
            this.Controls.Add(this.panel1);
            this.Name = "DMNPB100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopAllocationEquipmentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDateStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACStopAllocationEquipmentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopAllocationEquipmentReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACStopAllocationEquipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductIdentifiedEquipmentID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSMemoEdit fld_medACStopAllocationEquipmentDesc;
        private BOSComponent.BOSTextBox fld_txtACStopAllocationEquipmentReason;
        private Panel panel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeACStopAllocationEquipmentType;
	}
}
