using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPIForm.UI
{
	/// <summary>
	/// Summary description for SMKPIF100
	/// </summary>
	partial class SMKPIF100
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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRKPIForm = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchKPIFormFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchKPIFormToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRKPIFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSearchFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = string.Empty;
            this.fld_lblLabel11.BOSDataMember = string.Empty;
            this.fld_lblLabel11.BOSDataSource = string.Empty;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = string.Empty;
            this.fld_lblLabel11.BOSFieldRelation = string.Empty;
            this.fld_lblLabel11.BOSPrivilege = string.Empty;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(33, 40);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel11.TabIndex = 24;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã biểu mẫu";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = string.Empty;
            this.fld_lblLabel14.BOSDataMember = string.Empty;
            this.fld_lblLabel14.BOSDataSource = string.Empty;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = string.Empty;
            this.fld_lblLabel14.BOSFieldRelation = string.Empty;
            this.fld_lblLabel14.BOSPrivilege = string.Empty;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(33, 92);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 27;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = string.Empty;
            this.fld_lblLabel17.BOSDataMember = string.Empty;
            this.fld_lblLabel17.BOSDataSource = string.Empty;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = string.Empty;
            this.fld_lblLabel17.BOSFieldRelation = string.Empty;
            this.fld_lblLabel17.BOSPrivilege = string.Empty;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(317, 92);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 30;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dgcHRKPIForm
            // 
            this.fld_dgcHRKPIForm.AllowDrop = true;
            this.fld_dgcHRKPIForm.BOSComment = string.Empty;
            this.fld_dgcHRKPIForm.BOSDataMember = string.Empty;
            this.fld_dgcHRKPIForm.BOSDataSource = "HRKPIForms";
            this.fld_dgcHRKPIForm.BOSDescription = null;
            this.fld_dgcHRKPIForm.BOSError = null;
            this.fld_dgcHRKPIForm.BOSFieldGroup = string.Empty;
            this.fld_dgcHRKPIForm.BOSFieldRelation = string.Empty;
            this.fld_dgcHRKPIForm.BOSPrivilege = string.Empty;
            this.fld_dgcHRKPIForm.BOSPropertyName = null;
            this.fld_dgcHRKPIForm.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIForm.Location = new System.Drawing.Point(32, 216);
            this.fld_dgcHRKPIForm.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRKPIForm.Name = "fld_dgcHRKPIForm";
            this.fld_dgcHRKPIForm.Screen = null;
            this.fld_dgcHRKPIForm.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRKPIForm.TabIndex = 33;
            this.fld_dgcHRKPIForm.Tag = "SR";
            this.fld_dgcHRKPIForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRKPIForm;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchKPIFormFromDate
            // 
            this.fld_dteSearchKPIFormFromDate.BOSComment = string.Empty;
            this.fld_dteSearchKPIFormFromDate.BOSDataMember = "KPIFormFromDate";
            this.fld_dteSearchKPIFormFromDate.BOSDataSource = "HRKPIForms";
            this.fld_dteSearchKPIFormFromDate.BOSDescription = null;
            this.fld_dteSearchKPIFormFromDate.BOSError = null;
            this.fld_dteSearchKPIFormFromDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchKPIFormFromDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchKPIFormFromDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchKPIFormFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchKPIFormFromDate.EditValue = null;
            this.fld_dteSearchKPIFormFromDate.Location = new System.Drawing.Point(144, 89);
            this.fld_dteSearchKPIFormFromDate.Name = "fld_dteSearchKPIFormFromDate";
            this.fld_dteSearchKPIFormFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchKPIFormFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchKPIFormFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchKPIFormFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchKPIFormFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchKPIFormFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchKPIFormFromDate.Screen = null;
            this.fld_dteSearchKPIFormFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchKPIFormFromDate.TabIndex = 3;
            this.fld_dteSearchKPIFormFromDate.Tag = "SC";
            // 
            // fld_dteSearchKPIFormToDate
            // 
            this.fld_dteSearchKPIFormToDate.BOSComment = string.Empty;
            this.fld_dteSearchKPIFormToDate.BOSDataMember = "KPIFormToDate";
            this.fld_dteSearchKPIFormToDate.BOSDataSource = "HRKPIForms";
            this.fld_dteSearchKPIFormToDate.BOSDescription = null;
            this.fld_dteSearchKPIFormToDate.BOSError = null;
            this.fld_dteSearchKPIFormToDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchKPIFormToDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchKPIFormToDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchKPIFormToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchKPIFormToDate.EditValue = null;
            this.fld_dteSearchKPIFormToDate.Location = new System.Drawing.Point(351, 89);
            this.fld_dteSearchKPIFormToDate.Name = "fld_dteSearchKPIFormToDate";
            this.fld_dteSearchKPIFormToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchKPIFormToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchKPIFormToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchKPIFormToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchKPIFormToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchKPIFormToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchKPIFormToDate.Screen = null;
            this.fld_dteSearchKPIFormToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchKPIFormToDate.TabIndex = 4;
            this.fld_dteSearchKPIFormToDate.Tag = "SC";
            // 
            // fld_txtHRKPIFormNo
            // 
            this.fld_txtHRKPIFormNo.BOSComment = string.Empty;
            this.fld_txtHRKPIFormNo.BOSDataMember = "HRKPIFormNo";
            this.fld_txtHRKPIFormNo.BOSDataSource = "HRKPIForms";
            this.fld_txtHRKPIFormNo.BOSDescription = null;
            this.fld_txtHRKPIFormNo.BOSError = null;
            this.fld_txtHRKPIFormNo.BOSFieldGroup = string.Empty;
            this.fld_txtHRKPIFormNo.BOSFieldRelation = string.Empty;
            this.fld_txtHRKPIFormNo.BOSPrivilege = string.Empty;
            this.fld_txtHRKPIFormNo.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIFormNo.EditValue = string.Empty;
            this.fld_txtHRKPIFormNo.Location = new System.Drawing.Point(144, 37);
            this.fld_txtHRKPIFormNo.Name = "fld_txtHRKPIFormNo";
            this.fld_txtHRKPIFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPIFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPIFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPIFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPIFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPIFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPIFormNo.Screen = null;
            this.fld_txtHRKPIFormNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRKPIFormNo.TabIndex = 0;
            this.fld_txtHRKPIFormNo.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = string.Empty;
            this.bosLabel2.Location = new System.Drawing.Point(32, 66);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 39;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeSearchFK_BRBranchID
            // 
            this.fld_lkeSearchFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeSearchFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeSearchFK_BRBranchID.BOSComment = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.BOSDataSource = "HRKPIForms";
            this.fld_lkeSearchFK_BRBranchID.BOSDescription = null;
            this.fld_lkeSearchFK_BRBranchID.BOSError = null;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldGroup = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldParent = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldRelation = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.BOSPrivilege = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeSearchFK_BRBranchID.BOSSelectType = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeSearchFK_BRBranchID.Location = new System.Drawing.Point(144, 63);
            this.fld_lkeSearchFK_BRBranchID.Name = "fld_lkeSearchFK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSearchFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSearchFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeSearchFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeSearchFK_BRBranchID.Properties.NullText = string.Empty;
            this.fld_lkeSearchFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeSearchFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSearchFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.Screen = null;
            this.fld_lkeSearchFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeSearchFK_BRBranchID.TabIndex = 2;
            this.fld_lkeSearchFK_BRBranchID.Tag = "SC";
            // 
            // SMKPIF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeSearchFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHRKPIForm);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtHRKPIFormNo);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dteSearchKPIFormFromDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchKPIFormToDate);
            this.Name = "SMKPIF100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchKPIFormToDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchKPIFormFromDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_txtHRKPIFormNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRKPIForm, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIFormToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcHRKPIForm;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchKPIFormFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchKPIFormToDate;
        private BOSComponent.BOSTextBox fld_txtHRKPIFormNo;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_BRBranchID;
	}
}
