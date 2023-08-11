using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ImportData.UI
{
	/// <summary>
	/// Summary description for DMID101
	/// </summary>
	partial class DMID101
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dteCheckToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteCheckFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeCheckDataType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCheckData = new BOSComponent.BOSButton(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_medResultData = new BOSComponent.BOSMemoEdit(this.components);
            this.panel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCheckDataType.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medResultData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bosLine1);
            this.panel1.Controls.Add(this.bosLine4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 589);
            this.panel1.TabIndex = 0;
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.bosLine1.Controls.Add(this.fld_dteCheckToDate);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.bosLabel10);
            this.bosLine1.Controls.Add(this.fld_dteCheckFromDate);
            this.bosLine1.Controls.Add(this.fld_lkeCheckDataType);
            this.bosLine1.Controls.Add(this.bosLabel4);
            this.bosLine1.Controls.Add(this.fld_btnCheckData);
            this.bosLine1.Location = new System.Drawing.Point(3, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(902, 55);
            this.bosLine1.TabIndex = 0;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin tiềm kiếm";
            // 
            // fld_dteCheckToDate
            // 
            this.fld_dteCheckToDate.BOSComment = null;
            this.fld_dteCheckToDate.BOSDataMember = "";
            this.fld_dteCheckToDate.BOSDataSource = "";
            this.fld_dteCheckToDate.BOSDescription = null;
            this.fld_dteCheckToDate.BOSError = null;
            this.fld_dteCheckToDate.BOSFieldGroup = null;
            this.fld_dteCheckToDate.BOSFieldRelation = null;
            this.fld_dteCheckToDate.BOSPrivilege = null;
            this.fld_dteCheckToDate.BOSPropertyName = null;
            this.fld_dteCheckToDate.EditValue = null;
            this.fld_dteCheckToDate.Location = new System.Drawing.Point(580, 20);
            this.fld_dteCheckToDate.Name = "fld_dteCheckToDate";
            this.fld_dteCheckToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCheckToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCheckToDate.Screen = null;
            this.fld_dteCheckToDate.Size = new System.Drawing.Size(167, 20);
            this.fld_dteCheckToDate.TabIndex = 5;
            this.fld_dteCheckToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(517, 23);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 4;
            this.bosLabel9.Text = "Đến ngày";
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
            this.bosLabel10.Location = new System.Drawing.Point(278, 23);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 2;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteCheckFromDate
            // 
            this.fld_dteCheckFromDate.BOSComment = null;
            this.fld_dteCheckFromDate.BOSDataMember = "";
            this.fld_dteCheckFromDate.BOSDataSource = "";
            this.fld_dteCheckFromDate.BOSDescription = null;
            this.fld_dteCheckFromDate.BOSError = null;
            this.fld_dteCheckFromDate.BOSFieldGroup = null;
            this.fld_dteCheckFromDate.BOSFieldRelation = null;
            this.fld_dteCheckFromDate.BOSPrivilege = null;
            this.fld_dteCheckFromDate.BOSPropertyName = null;
            this.fld_dteCheckFromDate.EditValue = null;
            this.fld_dteCheckFromDate.Location = new System.Drawing.Point(333, 20);
            this.fld_dteCheckFromDate.Name = "fld_dteCheckFromDate";
            this.fld_dteCheckFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCheckFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCheckFromDate.Screen = null;
            this.fld_dteCheckFromDate.Size = new System.Drawing.Size(167, 20);
            this.fld_dteCheckFromDate.TabIndex = 3;
            this.fld_dteCheckFromDate.Tag = "DC";
            // 
            // fld_lkeCheckDataType
            // 
            this.fld_lkeCheckDataType.BOSAllowAddNew = false;
            this.fld_lkeCheckDataType.BOSAllowDummy = false;
            this.fld_lkeCheckDataType.BOSComment = null;
            this.fld_lkeCheckDataType.BOSDataMember = "CheckDataType";
            this.fld_lkeCheckDataType.BOSDataSource = "ADConfigValues";
            this.fld_lkeCheckDataType.BOSDescription = null;
            this.fld_lkeCheckDataType.BOSError = null;
            this.fld_lkeCheckDataType.BOSFieldGroup = null;
            this.fld_lkeCheckDataType.BOSFieldParent = null;
            this.fld_lkeCheckDataType.BOSFieldRelation = null;
            this.fld_lkeCheckDataType.BOSPrivilege = null;
            this.fld_lkeCheckDataType.BOSPropertyName = null;
            this.fld_lkeCheckDataType.BOSSelectType = "";
            this.fld_lkeCheckDataType.BOSSelectTypeValue = "";
            this.fld_lkeCheckDataType.CurrentDisplayText = null;
            this.fld_lkeCheckDataType.Location = new System.Drawing.Point(50, 20);
            this.fld_lkeCheckDataType.MenuManager = this.screenToolbar;
            this.fld_lkeCheckDataType.Name = "fld_lkeCheckDataType";
            this.fld_lkeCheckDataType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCheckDataType.Properties.ColumnName = null;
            this.fld_lkeCheckDataType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICReceiptNo", "Mã chứng từ")});
            this.fld_lkeCheckDataType.Properties.DisplayMember = "ICReceiptNo";
            this.fld_lkeCheckDataType.Properties.ValueMember = "ICReceiptID";
            this.fld_lkeCheckDataType.Screen = null;
            this.fld_lkeCheckDataType.Size = new System.Drawing.Size(167, 20);
            this.fld_lkeCheckDataType.TabIndex = 1;
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
            this.bosLabel4.Location = new System.Drawing.Point(16, 23);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(19, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Loại";
            // 
            // fld_btnCheckData
            // 
            this.fld_btnCheckData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCheckData.Appearance.Options.UseForeColor = true;
            this.fld_btnCheckData.BOSComment = "";
            this.fld_btnCheckData.BOSDataMember = "";
            this.fld_btnCheckData.BOSDataSource = "";
            this.fld_btnCheckData.BOSDescription = null;
            this.fld_btnCheckData.BOSError = null;
            this.fld_btnCheckData.BOSFieldGroup = "";
            this.fld_btnCheckData.BOSFieldRelation = "";
            this.fld_btnCheckData.BOSPrivilege = "";
            this.fld_btnCheckData.BOSPropertyName = "";
            this.fld_btnCheckData.Location = new System.Drawing.Point(805, 13);
            this.fld_btnCheckData.Name = "fld_btnCheckData";
            this.fld_btnCheckData.Screen = null;
            this.fld_btnCheckData.Size = new System.Drawing.Size(76, 34);
            this.fld_btnCheckData.TabIndex = 6;
            this.fld_btnCheckData.Tag = "";
            this.fld_btnCheckData.Text = "Kiểm tra";
            this.fld_btnCheckData.Click += new System.EventHandler(this.fld_btnCheckData_Click);
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_medResultData);
            this.bosLine4.Location = new System.Drawing.Point(3, 64);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(905, 515);
            this.bosLine4.TabIndex = 1;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Danh sách chứng từ sai";
            // 
            // fld_medResultData
            // 
            this.fld_medResultData.BOSComment = "";
            this.fld_medResultData.BOSDataMember = "";
            this.fld_medResultData.BOSDataSource = "";
            this.fld_medResultData.BOSDescription = null;
            this.fld_medResultData.BOSError = null;
            this.fld_medResultData.BOSFieldGroup = "";
            this.fld_medResultData.BOSFieldRelation = "";
            this.fld_medResultData.BOSPrivilege = "";
            this.fld_medResultData.BOSPropertyName = "Text";
            this.fld_medResultData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medResultData.EditValue = "";
            this.fld_medResultData.Location = new System.Drawing.Point(3, 17);
            this.fld_medResultData.Name = "fld_medResultData";
            this.fld_medResultData.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medResultData.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medResultData.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medResultData.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medResultData.Screen = null;
            this.fld_medResultData.Size = new System.Drawing.Size(899, 495);
            this.fld_medResultData.TabIndex = 0;
            this.fld_medResultData.Tag = "DC";
            // 
            // DMID101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(908, 589);
            this.Controls.Add(this.panel1);
            this.Name = "DMID101";
            this.Text = "Kiểm tra dữ liệu";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCheckDataType.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medResultData.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private Panel panel1;
        private BOSComponent.BOSMemoEdit fld_medResultData;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSButton fld_btnCheckData;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeCheckDataType;
        private BOSComponent.BOSDateEdit fld_dteCheckToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteCheckFromDate;
    }
}
