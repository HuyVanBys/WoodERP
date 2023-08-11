using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RecruitmentNeed.UI
{
	/// <summary>
	/// Summary description for SMRN100
	/// </summary>
	partial class SMRN100
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
            this.fld_dgcHRRecruitmentNeeds = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchHRRecruitmentNeedFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchHRRecruitmentNeedToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRKPIFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSearchFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentNeeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedToDate.Properties)).BeginInit();
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
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 24;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
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
            // fld_dgcHRRecruitmentNeeds
            // 
            this.fld_dgcHRRecruitmentNeeds.AllowDrop = true;
            this.fld_dgcHRRecruitmentNeeds.BOSComment = string.Empty;
            this.fld_dgcHRRecruitmentNeeds.BOSDataMember = string.Empty;
            this.fld_dgcHRRecruitmentNeeds.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_dgcHRRecruitmentNeeds.BOSDescription = null;
            this.fld_dgcHRRecruitmentNeeds.BOSError = null;
            this.fld_dgcHRRecruitmentNeeds.BOSFieldGroup = string.Empty;
            this.fld_dgcHRRecruitmentNeeds.BOSFieldRelation = string.Empty;
            this.fld_dgcHRRecruitmentNeeds.BOSPrivilege = string.Empty;
            this.fld_dgcHRRecruitmentNeeds.BOSPropertyName = null;
            this.fld_dgcHRRecruitmentNeeds.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRRecruitmentNeeds.Location = new System.Drawing.Point(32, 216);
            this.fld_dgcHRRecruitmentNeeds.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRRecruitmentNeeds.Name = "fld_dgcHRRecruitmentNeeds";
            this.fld_dgcHRRecruitmentNeeds.Screen = null;
            this.fld_dgcHRRecruitmentNeeds.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRRecruitmentNeeds.TabIndex = 4;
            this.fld_dgcHRRecruitmentNeeds.Tag = "SR";
            this.fld_dgcHRRecruitmentNeeds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRRecruitmentNeeds;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchHRRecruitmentNeedFromDate
            // 
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSComment = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSDataMember = "HRRecruitmentNeedFromDate";
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSDescription = null;
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSError = null;
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchHRRecruitmentNeedFromDate.EditValue = null;
            this.fld_dteSearchHRRecruitmentNeedFromDate.Location = new System.Drawing.Point(144, 89);
            this.fld_dteSearchHRRecruitmentNeedFromDate.Name = "fld_dteSearchHRRecruitmentNeedFromDate";
            this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHRRecruitmentNeedFromDate.Screen = null;
            this.fld_dteSearchHRRecruitmentNeedFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchHRRecruitmentNeedFromDate.TabIndex = 2;
            this.fld_dteSearchHRRecruitmentNeedFromDate.Tag = "SC";
            // 
            // fld_dteSearchHRRecruitmentNeedToDate
            // 
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSComment = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSDataMember = "HRRecruitmentNeedToDate";
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSDescription = null;
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSError = null;
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchHRRecruitmentNeedToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchHRRecruitmentNeedToDate.EditValue = null;
            this.fld_dteSearchHRRecruitmentNeedToDate.Location = new System.Drawing.Point(351, 89);
            this.fld_dteSearchHRRecruitmentNeedToDate.Name = "fld_dteSearchHRRecruitmentNeedToDate";
            this.fld_dteSearchHRRecruitmentNeedToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHRRecruitmentNeedToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHRRecruitmentNeedToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHRRecruitmentNeedToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHRRecruitmentNeedToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHRRecruitmentNeedToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHRRecruitmentNeedToDate.Screen = null;
            this.fld_dteSearchHRRecruitmentNeedToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchHRRecruitmentNeedToDate.TabIndex = 3;
            this.fld_dteSearchHRRecruitmentNeedToDate.Tag = "SC";
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
            this.fld_lkeSearchFK_BRBranchID.BOSDataSource = "HRRecruitmentNeeds";
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
            this.fld_lkeSearchFK_BRBranchID.TabIndex = 1;
            this.fld_lkeSearchFK_BRBranchID.Tag = "SC";
            // 
            // SMRN100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeSearchFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHRRecruitmentNeeds);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtHRKPIFormNo);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dteSearchHRRecruitmentNeedFromDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchHRRecruitmentNeedToDate);
            this.Name = "SMRN100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchHRRecruitmentNeedToDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchHRRecruitmentNeedFromDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_txtHRKPIFormNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRRecruitmentNeeds, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentNeeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentNeedToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcHRRecruitmentNeeds;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchHRRecruitmentNeedFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchHRRecruitmentNeedToDate;
        private BOSComponent.BOSTextBox fld_txtHRKPIFormNo;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_BRBranchID;
	}
}
