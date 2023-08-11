using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationEmployee.UI
{
	/// <summary>
	/// Summary description for SMHREE100
	/// </summary>
	partial class SMHREE100
	{
		private BOSComponent.BOSTextBox fld_txtHREvaluationNo;
		private BOSComponent.BOSTextBox fld_txtHREvaluationName;
		private BOSComponent.BOSDateEdit fld_dteHREvaluationFromDate;
		private BOSComponent.BOSDateEdit fld_dteHREvaluationToDate;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLookupEdit fld_lkeHREvaluationStatus;
		private BOSSearchResultsGridControl fld_dgcHREvaluation;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREvaluation;


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
            this.fld_txtHREvaluationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREvaluationName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHREvaluationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHREvaluationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREvaluationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcHREvaluation = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHREvaluation = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREvaluationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHREvaluationNo
            // 
            this.fld_txtHREvaluationNo.BOSComment = "";
            this.fld_txtHREvaluationNo.BOSDataMember = "HREvaluationNo";
            this.fld_txtHREvaluationNo.BOSDataSource = "HREvaluations";
            this.fld_txtHREvaluationNo.BOSDescription = null;
            this.fld_txtHREvaluationNo.BOSError = null;
            this.fld_txtHREvaluationNo.BOSFieldGroup = "";
            this.fld_txtHREvaluationNo.BOSFieldRelation = "";
            this.fld_txtHREvaluationNo.BOSPrivilege = "";
            this.fld_txtHREvaluationNo.BOSPropertyName = "Text";
            this.fld_txtHREvaluationNo.EditValue = "";
            this.fld_txtHREvaluationNo.Location = new System.Drawing.Point(126, 34);
            this.fld_txtHREvaluationNo.Name = "fld_txtHREvaluationNo";
            this.fld_txtHREvaluationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationNo.Screen = null;
            this.fld_txtHREvaluationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREvaluationNo.TabIndex = 4;
            this.fld_txtHREvaluationNo.Tag = "SC";
            // 
            // fld_txtHREvaluationName
            // 
            this.fld_txtHREvaluationName.BOSComment = "";
            this.fld_txtHREvaluationName.BOSDataMember = "HREvaluationName";
            this.fld_txtHREvaluationName.BOSDataSource = "HREvaluations";
            this.fld_txtHREvaluationName.BOSDescription = null;
            this.fld_txtHREvaluationName.BOSError = null;
            this.fld_txtHREvaluationName.BOSFieldGroup = "";
            this.fld_txtHREvaluationName.BOSFieldRelation = "";
            this.fld_txtHREvaluationName.BOSPrivilege = "";
            this.fld_txtHREvaluationName.BOSPropertyName = "Text";
            this.fld_txtHREvaluationName.EditValue = "";
            this.fld_txtHREvaluationName.Location = new System.Drawing.Point(126, 60);
            this.fld_txtHREvaluationName.Name = "fld_txtHREvaluationName";
            this.fld_txtHREvaluationName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationName.Screen = null;
            this.fld_txtHREvaluationName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREvaluationName.TabIndex = 5;
            this.fld_txtHREvaluationName.Tag = "SC";
            // 
            // fld_dteHREvaluationFromDate
            // 
            this.fld_dteHREvaluationFromDate.BOSComment = "";
            this.fld_dteHREvaluationFromDate.BOSDataMember = "HREvaluationFromDate";
            this.fld_dteHREvaluationFromDate.BOSDataSource = "HREvaluations";
            this.fld_dteHREvaluationFromDate.BOSDescription = null;
            this.fld_dteHREvaluationFromDate.BOSError = null;
            this.fld_dteHREvaluationFromDate.BOSFieldGroup = "";
            this.fld_dteHREvaluationFromDate.BOSFieldRelation = "";
            this.fld_dteHREvaluationFromDate.BOSPrivilege = "";
            this.fld_dteHREvaluationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHREvaluationFromDate.EditValue = null;
            this.fld_dteHREvaluationFromDate.Location = new System.Drawing.Point(126, 86);
            this.fld_dteHREvaluationFromDate.Name = "fld_dteHREvaluationFromDate";
            this.fld_dteHREvaluationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREvaluationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREvaluationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREvaluationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREvaluationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREvaluationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREvaluationFromDate.Screen = null;
            this.fld_dteHREvaluationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREvaluationFromDate.TabIndex = 6;
            this.fld_dteHREvaluationFromDate.Tag = "SC";
            // 
            // fld_dteHREvaluationToDate
            // 
            this.fld_dteHREvaluationToDate.BOSComment = "";
            this.fld_dteHREvaluationToDate.BOSDataMember = "HREvaluationToDate";
            this.fld_dteHREvaluationToDate.BOSDataSource = "HREvaluations";
            this.fld_dteHREvaluationToDate.BOSDescription = null;
            this.fld_dteHREvaluationToDate.BOSError = null;
            this.fld_dteHREvaluationToDate.BOSFieldGroup = "";
            this.fld_dteHREvaluationToDate.BOSFieldRelation = "";
            this.fld_dteHREvaluationToDate.BOSPrivilege = "";
            this.fld_dteHREvaluationToDate.BOSPropertyName = "EditValue";
            this.fld_dteHREvaluationToDate.EditValue = null;
            this.fld_dteHREvaluationToDate.Location = new System.Drawing.Point(126, 112);
            this.fld_dteHREvaluationToDate.Name = "fld_dteHREvaluationToDate";
            this.fld_dteHREvaluationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREvaluationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREvaluationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREvaluationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREvaluationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREvaluationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREvaluationToDate.Screen = null;
            this.fld_dteHREvaluationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREvaluationToDate.TabIndex = 7;
            this.fld_dteHREvaluationToDate.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(39, 37);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel.TabIndex = 11;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã đánh giá";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(39, 63);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel1.TabIndex = 12;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên đánh giá";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(39, 89);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 13;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(39, 115);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 14;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(39, 141);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel4.TabIndex = 15;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Trạng thái";
            // 
            // fld_lkeHREvaluationStatus
            // 
            this.fld_lkeHREvaluationStatus.BOSAllowAddNew = false;
            this.fld_lkeHREvaluationStatus.BOSAllowDummy = true;
            this.fld_lkeHREvaluationStatus.BOSComment = "";
            this.fld_lkeHREvaluationStatus.BOSDataMember = "HREvaluationStatus";
            this.fld_lkeHREvaluationStatus.BOSDataSource = "HREvaluations";
            this.fld_lkeHREvaluationStatus.BOSDescription = null;
            this.fld_lkeHREvaluationStatus.BOSError = null;
            this.fld_lkeHREvaluationStatus.BOSFieldGroup = "";
            this.fld_lkeHREvaluationStatus.BOSFieldParent = "";
            this.fld_lkeHREvaluationStatus.BOSFieldRelation = "";
            this.fld_lkeHREvaluationStatus.BOSPrivilege = "";
            this.fld_lkeHREvaluationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHREvaluationStatus.BOSSelectType = "";
            this.fld_lkeHREvaluationStatus.BOSSelectTypeValue = "";
            this.fld_lkeHREvaluationStatus.CurrentDisplayText = null;
            this.fld_lkeHREvaluationStatus.Location = new System.Drawing.Point(126, 138);
            this.fld_lkeHREvaluationStatus.Name = "fld_lkeHREvaluationStatus";
            this.fld_lkeHREvaluationStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREvaluationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREvaluationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREvaluationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREvaluationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREvaluationStatus.Properties.NullText = "";
            this.fld_lkeHREvaluationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREvaluationStatus.Screen = null;
            this.fld_lkeHREvaluationStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREvaluationStatus.TabIndex = 10;
            this.fld_lkeHREvaluationStatus.Tag = "SC";
            // 
            // fld_dgcHREvaluation
            // 
            this.fld_dgcHREvaluation.AllowDrop = true;
            this.fld_dgcHREvaluation.BOSComment = "";
            this.fld_dgcHREvaluation.BOSDataMember = "";
            this.fld_dgcHREvaluation.BOSDataSource = "HREvaluations";
            this.fld_dgcHREvaluation.BOSDescription = null;
            this.fld_dgcHREvaluation.BOSError = null;
            this.fld_dgcHREvaluation.BOSFieldGroup = "";
            this.fld_dgcHREvaluation.BOSFieldRelation = "";
            this.fld_dgcHREvaluation.BOSPrivilege = "";
            this.fld_dgcHREvaluation.BOSPropertyName = "";
            this.fld_dgcHREvaluation.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREvaluation.Location = new System.Drawing.Point(18, 177);
            this.fld_dgcHREvaluation.MainView = this.fld_dgvHREvaluation;
            this.fld_dgcHREvaluation.Name = "fld_dgcHREvaluation";
            this.fld_dgcHREvaluation.Screen = null;
            this.fld_dgcHREvaluation.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHREvaluation.TabIndex = 9;
            this.fld_dgcHREvaluation.Tag = "SR";
            this.fld_dgcHREvaluation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREvaluation});
            // 
            // fld_dgvHREvaluation
            // 
            this.fld_dgvHREvaluation.GridControl = this.fld_dgcHREvaluation;
            this.fld_dgvHREvaluation.Name = "fld_dgvHREvaluation";
            this.fld_dgvHREvaluation.PaintStyleName = "Office2003";
            // 
            // SMHREE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_txtHREvaluationNo);
            this.Controls.Add(this.fld_txtHREvaluationName);
            this.Controls.Add(this.fld_dteHREvaluationFromDate);
            this.Controls.Add(this.fld_dteHREvaluationToDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lkeHREvaluationStatus);
            this.Controls.Add(this.fld_dgcHREvaluation);
            this.Name = "SMHREE100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHREvaluation, 0);
            this.Controls.SetChildIndex(this.fld_lkeHREvaluationStatus, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteHREvaluationToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteHREvaluationFromDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHREvaluationName, 0);
            this.Controls.SetChildIndex(this.fld_txtHREvaluationNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREvaluationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREvaluationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREvaluation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
