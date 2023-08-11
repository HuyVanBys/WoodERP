using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationEmployee.UI
{
	/// <summary>
	/// Summary description for DMHREE100
	/// </summary>
	partial class DMHREE100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSTextBox fld_txtHREvaluationNo1;
		private BOSComponent.BOSTextBox fld_txtHREvaluationName1;
		private BOSComponent.BOSMemoEdit fld_medHREvaluationDesc;
		private BOSComponent.BOSDateEdit fld_dteHREvaluationFromDate1;
		private BOSComponent.BOSDateEdit fld_dteHREvaluationToDate1;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLabel fld_lblLabel10;
		private BOSComponent.BOSLookupEdit fld_lkeHREvaluations1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private HREmployeeEvaluatingGridControl fld_dgcHREmployeeEvaluations;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeEvaluations;
        private HREmployeeEvaluatedGridControl fld_dgcHREmployeeEvaluations1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeEvaluations1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREvaluationTemplateID;
        private BOSComponent.BOSLabel fld_lblLabel13;


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
            this.fld_txtHREvaluationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREvaluationName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHREvaluationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHREvaluationFromDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHREvaluationToDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREvaluations1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREvaluationTemplateID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeEvaluations = new BOSERP.Modules.HREvaluationEmployee.HREmployeeEvaluatingGridControl();
            this.fld_dgvHREmployeeEvaluations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeEvaluations1 = new BOSERP.Modules.HREvaluationEmployee.HREmployeeEvaluatedGridControl();
            this.fld_dgvHREmployeeEvaluations1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREvaluationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREvaluations1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREvaluationTemplateID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeEvaluations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeEvaluations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeEvaluations1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeEvaluations1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREvaluationNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREvaluationName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHREvaluationDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREvaluationFromDate1);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREvaluationToDate1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel9);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel10);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHREvaluations1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREvaluationTemplateID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(1, 1);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(990, 129);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_txtHREvaluationNo1
            // 
            this.fld_txtHREvaluationNo1.BOSComment = "";
            this.fld_txtHREvaluationNo1.BOSDataMember = "HREvaluationNo";
            this.fld_txtHREvaluationNo1.BOSDataSource = "HREvaluations";
            this.fld_txtHREvaluationNo1.BOSDescription = null;
            this.fld_txtHREvaluationNo1.BOSError = null;
            this.fld_txtHREvaluationNo1.BOSFieldGroup = "";
            this.fld_txtHREvaluationNo1.BOSFieldRelation = "";
            this.fld_txtHREvaluationNo1.BOSPrivilege = "";
            this.fld_txtHREvaluationNo1.BOSPropertyName = "Text";
            this.fld_txtHREvaluationNo1.EditValue = "";
            this.fld_txtHREvaluationNo1.Location = new System.Drawing.Point(79, 28);
            this.fld_txtHREvaluationNo1.Name = "fld_txtHREvaluationNo1";
            this.fld_txtHREvaluationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationNo1.Screen = null;
            this.fld_txtHREvaluationNo1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREvaluationNo1.TabIndex = 5;
            this.fld_txtHREvaluationNo1.Tag = "DC";
            // 
            // fld_txtHREvaluationName1
            // 
            this.fld_txtHREvaluationName1.BOSComment = "";
            this.fld_txtHREvaluationName1.BOSDataMember = "HREvaluationName";
            this.fld_txtHREvaluationName1.BOSDataSource = "HREvaluations";
            this.fld_txtHREvaluationName1.BOSDescription = null;
            this.fld_txtHREvaluationName1.BOSError = null;
            this.fld_txtHREvaluationName1.BOSFieldGroup = "";
            this.fld_txtHREvaluationName1.BOSFieldRelation = "";
            this.fld_txtHREvaluationName1.BOSPrivilege = "";
            this.fld_txtHREvaluationName1.BOSPropertyName = "Text";
            this.fld_txtHREvaluationName1.EditValue = "";
            this.fld_txtHREvaluationName1.Location = new System.Drawing.Point(378, 28);
            this.fld_txtHREvaluationName1.Name = "fld_txtHREvaluationName1";
            this.fld_txtHREvaluationName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationName1.Screen = null;
            this.fld_txtHREvaluationName1.Size = new System.Drawing.Size(250, 20);
            this.fld_txtHREvaluationName1.TabIndex = 6;
            this.fld_txtHREvaluationName1.Tag = "DC";
            // 
            // fld_medHREvaluationDesc
            // 
            this.fld_medHREvaluationDesc.BOSComment = "";
            this.fld_medHREvaluationDesc.BOSDataMember = "HREvaluationDesc";
            this.fld_medHREvaluationDesc.BOSDataSource = "HREvaluations";
            this.fld_medHREvaluationDesc.BOSDescription = null;
            this.fld_medHREvaluationDesc.BOSError = null;
            this.fld_medHREvaluationDesc.BOSFieldGroup = "";
            this.fld_medHREvaluationDesc.BOSFieldRelation = "";
            this.fld_medHREvaluationDesc.BOSPrivilege = "";
            this.fld_medHREvaluationDesc.BOSPropertyName = "Text";
            this.fld_medHREvaluationDesc.EditValue = "";
            this.fld_medHREvaluationDesc.Location = new System.Drawing.Point(79, 76);
            this.fld_medHREvaluationDesc.Name = "fld_medHREvaluationDesc";
            this.fld_medHREvaluationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREvaluationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREvaluationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREvaluationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREvaluationDesc.Screen = null;
            this.fld_medHREvaluationDesc.Size = new System.Drawing.Size(824, 50);
            this.fld_medHREvaluationDesc.TabIndex = 7;
            this.fld_medHREvaluationDesc.Tag = "DC";
            // 
            // fld_dteHREvaluationFromDate1
            // 
            this.fld_dteHREvaluationFromDate1.BOSComment = "";
            this.fld_dteHREvaluationFromDate1.BOSDataMember = "HREvaluationFromDate";
            this.fld_dteHREvaluationFromDate1.BOSDataSource = "HREvaluations";
            this.fld_dteHREvaluationFromDate1.BOSDescription = null;
            this.fld_dteHREvaluationFromDate1.BOSError = null;
            this.fld_dteHREvaluationFromDate1.BOSFieldGroup = "";
            this.fld_dteHREvaluationFromDate1.BOSFieldRelation = "";
            this.fld_dteHREvaluationFromDate1.BOSPrivilege = "";
            this.fld_dteHREvaluationFromDate1.BOSPropertyName = "EditValue";
            this.fld_dteHREvaluationFromDate1.EditValue = null;
            this.fld_dteHREvaluationFromDate1.Location = new System.Drawing.Point(778, 28);
            this.fld_dteHREvaluationFromDate1.Name = "fld_dteHREvaluationFromDate1";
            this.fld_dteHREvaluationFromDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREvaluationFromDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREvaluationFromDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREvaluationFromDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREvaluationFromDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREvaluationFromDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREvaluationFromDate1.Screen = null;
            this.fld_dteHREvaluationFromDate1.Size = new System.Drawing.Size(125, 20);
            this.fld_dteHREvaluationFromDate1.TabIndex = 8;
            this.fld_dteHREvaluationFromDate1.Tag = "DC";
            // 
            // fld_dteHREvaluationToDate1
            // 
            this.fld_dteHREvaluationToDate1.BOSComment = "";
            this.fld_dteHREvaluationToDate1.BOSDataMember = "HREvaluationToDate";
            this.fld_dteHREvaluationToDate1.BOSDataSource = "HREvaluations";
            this.fld_dteHREvaluationToDate1.BOSDescription = null;
            this.fld_dteHREvaluationToDate1.BOSError = null;
            this.fld_dteHREvaluationToDate1.BOSFieldGroup = "";
            this.fld_dteHREvaluationToDate1.BOSFieldRelation = "";
            this.fld_dteHREvaluationToDate1.BOSPrivilege = "";
            this.fld_dteHREvaluationToDate1.BOSPropertyName = "EditValue";
            this.fld_dteHREvaluationToDate1.EditValue = null;
            this.fld_dteHREvaluationToDate1.Location = new System.Drawing.Point(778, 52);
            this.fld_dteHREvaluationToDate1.Name = "fld_dteHREvaluationToDate1";
            this.fld_dteHREvaluationToDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREvaluationToDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREvaluationToDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREvaluationToDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREvaluationToDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREvaluationToDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREvaluationToDate1.Screen = null;
            this.fld_dteHREvaluationToDate1.Size = new System.Drawing.Size(125, 20);
            this.fld_dteHREvaluationToDate1.TabIndex = 9;
            this.fld_dteHREvaluationToDate1.Tag = "DC";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(11, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel5.TabIndex = 12;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Mã đánh giá";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(281, 31);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel6.TabIndex = 13;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Tên đánh giá";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(690, 31);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel7.TabIndex = 14;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Từ ngày";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(690, 55);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel8.TabIndex = 15;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Đến ngày";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = "";
            this.fld_lblLabel9.Location = new System.Drawing.Point(11, 55);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel9.TabIndex = 16;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Trạng thái";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = "";
            this.fld_lblLabel10.Location = new System.Drawing.Point(11, 94);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(35, 13);
            this.fld_lblLabel10.TabIndex = 17;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Diễn giải";
            // 
            // fld_lkeHREvaluations1
            // 
            this.fld_lkeHREvaluations1.BOSAllowAddNew = false;
            this.fld_lkeHREvaluations1.BOSAllowDummy = false;
            this.fld_lkeHREvaluations1.BOSComment = "";
            this.fld_lkeHREvaluations1.BOSDataMember = "HREvaluationStatus";
            this.fld_lkeHREvaluations1.BOSDataSource = "HREvaluations";
            this.fld_lkeHREvaluations1.BOSDescription = null;
            this.fld_lkeHREvaluations1.BOSError = null;
            this.fld_lkeHREvaluations1.BOSFieldGroup = "";
            this.fld_lkeHREvaluations1.BOSFieldParent = "";
            this.fld_lkeHREvaluations1.BOSFieldRelation = "";
            this.fld_lkeHREvaluations1.BOSPrivilege = "";
            this.fld_lkeHREvaluations1.BOSPropertyName = "EditValue";
            this.fld_lkeHREvaluations1.BOSSelectType = "";
            this.fld_lkeHREvaluations1.BOSSelectTypeValue = "";
            this.fld_lkeHREvaluations1.CurrentDisplayText = null;
            this.fld_lkeHREvaluations1.Location = new System.Drawing.Point(79, 52);
            this.fld_lkeHREvaluations1.Name = "fld_lkeHREvaluations1";
            this.fld_lkeHREvaluations1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREvaluations1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREvaluations1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREvaluations1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREvaluations1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREvaluations1.Properties.NullText = "";
            this.fld_lkeHREvaluations1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREvaluations1.Screen = null;
            this.fld_lkeHREvaluations1.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeHREvaluations1.TabIndex = 11;
            this.fld_lkeHREvaluations1.Tag = "DC";
            // 
            // fld_lkeFK_HREvaluationTemplateID
            // 
            this.fld_lkeFK_HREvaluationTemplateID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREvaluationTemplateID.BOSAllowDummy = false;
            this.fld_lkeFK_HREvaluationTemplateID.BOSComment = "";
            this.fld_lkeFK_HREvaluationTemplateID.BOSDataMember = "FK_HREvaluationTemplateID";
            this.fld_lkeFK_HREvaluationTemplateID.BOSDataSource = "HREvaluations";
            this.fld_lkeFK_HREvaluationTemplateID.BOSDescription = null;
            this.fld_lkeFK_HREvaluationTemplateID.BOSError = null;
            this.fld_lkeFK_HREvaluationTemplateID.BOSFieldGroup = "";
            this.fld_lkeFK_HREvaluationTemplateID.BOSFieldParent = "";
            this.fld_lkeFK_HREvaluationTemplateID.BOSFieldRelation = "";
            this.fld_lkeFK_HREvaluationTemplateID.BOSPrivilege = "";
            this.fld_lkeFK_HREvaluationTemplateID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREvaluationTemplateID.BOSSelectType = "";
            this.fld_lkeFK_HREvaluationTemplateID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREvaluationTemplateID.CurrentDisplayText = null;
            this.fld_lkeFK_HREvaluationTemplateID.Location = new System.Drawing.Point(378, 52);
            this.fld_lkeFK_HREvaluationTemplateID.Name = "fld_lkeFK_HREvaluationTemplateID";
            this.fld_lkeFK_HREvaluationTemplateID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREvaluationTemplateID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREvaluationTemplateID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREvaluationTemplateID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREvaluationTemplateID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREvaluationTemplateID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREvaluationTemplateNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREvaluationTemplateName", "Name")});
            this.fld_lkeFK_HREvaluationTemplateID.Properties.DisplayMember = "HREvaluationTemplateNo";
            this.fld_lkeFK_HREvaluationTemplateID.Properties.NullText = "";
            this.fld_lkeFK_HREvaluationTemplateID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREvaluationTemplateID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREvaluationTemplateID.Properties.ValueMember = "HREvaluationTemplateID";
            this.fld_lkeFK_HREvaluationTemplateID.Screen = null;
            this.fld_lkeFK_HREvaluationTemplateID.Size = new System.Drawing.Size(250, 20);
            this.fld_lkeFK_HREvaluationTemplateID.TabIndex = 26;
            this.fld_lkeFK_HREvaluationTemplateID.Tag = "DC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "";
            this.fld_lblLabel13.BOSDataSource = "";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = "";
            this.fld_lblLabel13.Location = new System.Drawing.Point(281, 55);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(87, 13);
            this.fld_lblLabel13.TabIndex = 27;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "Biểu mẫu đánh giá";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeeEvaluations);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(1, 131);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(400, 450);
            this.fld_grcGroupControl1.TabIndex = 18;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Người tham gia đánh giá";
            // 
            // fld_dgcHREmployeeEvaluations
            // 
            this.fld_dgcHREmployeeEvaluations.AllowDrop = true;
            this.fld_dgcHREmployeeEvaluations.BOSComment = "";
            this.fld_dgcHREmployeeEvaluations.BOSDataMember = "";
            this.fld_dgcHREmployeeEvaluations.BOSDataSource = "HREmployeeEvaluations";
            this.fld_dgcHREmployeeEvaluations.BOSDescription = null;
            this.fld_dgcHREmployeeEvaluations.BOSError = null;
            this.fld_dgcHREmployeeEvaluations.BOSFieldGroup = "";
            this.fld_dgcHREmployeeEvaluations.BOSFieldRelation = "";
            this.fld_dgcHREmployeeEvaluations.BOSGridType = null;
            this.fld_dgcHREmployeeEvaluations.BOSPrivilege = "";
            this.fld_dgcHREmployeeEvaluations.BOSPropertyName = "";
            this.fld_dgcHREmployeeEvaluations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeEvaluations.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHREmployeeEvaluations.MainView = this.fld_dgvHREmployeeEvaluations;
            this.fld_dgcHREmployeeEvaluations.Name = "fld_dgcHREmployeeEvaluations";
            this.fld_dgcHREmployeeEvaluations.Screen = null;
            this.fld_dgcHREmployeeEvaluations.Size = new System.Drawing.Size(396, 426);
            this.fld_dgcHREmployeeEvaluations.TabIndex = 20;
            this.fld_dgcHREmployeeEvaluations.Tag = "DC";
            this.fld_dgcHREmployeeEvaluations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeEvaluations});
            // 
            // fld_dgvHREmployeeEvaluations
            // 
            this.fld_dgvHREmployeeEvaluations.GridControl = this.fld_dgcHREmployeeEvaluations;
            this.fld_dgvHREmployeeEvaluations.Name = "fld_dgvHREmployeeEvaluations";
            this.fld_dgvHREmployeeEvaluations.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = "";
            this.fld_grcGroupControl2.BOSDataSource = "";
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = "";
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = "";
            this.fld_grcGroupControl2.Controls.Add(this.fld_dgcHREmployeeEvaluations1);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(402, 131);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(590, 450);
            this.fld_grcGroupControl2.TabIndex = 19;
            this.fld_grcGroupControl2.Tag = "";
            this.fld_grcGroupControl2.Text = "Người được đánh giá";
            // 
            // fld_dgcHREmployeeEvaluations1
            // 
            this.fld_dgcHREmployeeEvaluations1.AllowDrop = true;
            this.fld_dgcHREmployeeEvaluations1.BOSComment = "";
            this.fld_dgcHREmployeeEvaluations1.BOSDataMember = "";
            this.fld_dgcHREmployeeEvaluations1.BOSDataSource = "HREmployeeEvaluations";
            this.fld_dgcHREmployeeEvaluations1.BOSDescription = null;
            this.fld_dgcHREmployeeEvaluations1.BOSError = null;
            this.fld_dgcHREmployeeEvaluations1.BOSFieldGroup = "";
            this.fld_dgcHREmployeeEvaluations1.BOSFieldRelation = "";
            this.fld_dgcHREmployeeEvaluations1.BOSGridType = null;
            this.fld_dgcHREmployeeEvaluations1.BOSPrivilege = "";
            this.fld_dgcHREmployeeEvaluations1.BOSPropertyName = "";
            this.fld_dgcHREmployeeEvaluations1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeEvaluations1.IsAllowEidt = false;
            this.fld_dgcHREmployeeEvaluations1.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHREmployeeEvaluations1.MainView = this.fld_dgvHREmployeeEvaluations1;
            this.fld_dgcHREmployeeEvaluations1.Name = "fld_dgcHREmployeeEvaluations1";
            this.fld_dgcHREmployeeEvaluations1.Screen = null;
            this.fld_dgcHREmployeeEvaluations1.Size = new System.Drawing.Size(586, 426);
            this.fld_dgcHREmployeeEvaluations1.TabIndex = 21;
            this.fld_dgcHREmployeeEvaluations1.Tag = "DC";
            this.fld_dgcHREmployeeEvaluations1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeEvaluations1});
            // 
            // fld_dgvHREmployeeEvaluations1
            // 
            this.fld_dgvHREmployeeEvaluations1.GridControl = this.fld_dgcHREmployeeEvaluations1;
            this.fld_dgvHREmployeeEvaluations1.Name = "fld_dgvHREmployeeEvaluations1";
            this.fld_dgvHREmployeeEvaluations1.PaintStyleName = "Office2003";
            // 
            // DMHREE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(993, 583);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl2);
            this.Name = "DMHREE100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_grcGroupControl2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREvaluationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREvaluations1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREvaluationTemplateID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeEvaluations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeEvaluations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeEvaluations1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeEvaluations1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
	}
}
