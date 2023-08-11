using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRAllowanceManage.UI
{
	/// <summary>
	/// Summary description for SMHRAL100
	/// </summary>
	partial class SMHRALM100
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
            this.fld_dgcHRAllowances = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRAllowanceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAllowanceName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAllowanceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRAllowances
            // 
            this.fld_dgcHRAllowances.AllowDrop = true;
            this.fld_dgcHRAllowances.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRAllowances.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRAllowances.BOSDataSource = "HRAllowances";
            this.fld_dgcHRAllowances.BOSDescription = null;
            this.fld_dgcHRAllowances.BOSError = null;
            this.fld_dgcHRAllowances.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRAllowances.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRAllowances.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRAllowances.BOSPropertyName = "Search Result";
            this.fld_dgcHRAllowances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRAllowances.Location = new System.Drawing.Point(12, 300);
            this.fld_dgcHRAllowances.MainView = this.fld_dgvHRAllowances;
            this.fld_dgcHRAllowances.Name = "fld_dgcHRAllowances";
            this.fld_dgcHRAllowances.Screen = null;
            this.fld_dgcHRAllowances.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRAllowances.TabIndex = 3;
            this.fld_dgcHRAllowances.Tag = "SR";
            this.fld_dgcHRAllowances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRAllowances});
            // 
            // fld_dgvHRAllowances
            // 
            this.fld_dgvHRAllowances.GridControl = this.fld_dgcHRAllowances;
            this.fld_dgvHRAllowances.Name = "fld_dgvHRAllowances";
            this.fld_dgvHRAllowances.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.Location = new System.Drawing.Point(42, 28);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel2.TabIndex = 46;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Mã phụ cấp";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.Location = new System.Drawing.Point(42, 54);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(59, 13);
            this.fld_lblLabel3.TabIndex = 47;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Tên phụ cấp";
            // 
            // fld_txtHRAllowanceNo
            // 
            this.fld_txtHRAllowanceNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSDataMember = "HRAllowanceNo";
            this.fld_txtHRAllowanceNo.BOSDataSource = "HRAllowances";
            this.fld_txtHRAllowanceNo.BOSDescription = null;
            this.fld_txtHRAllowanceNo.BOSError = null;
            this.fld_txtHRAllowanceNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.BOSPropertyName = "Text";
            this.fld_txtHRAllowanceNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAllowanceNo.Location = new System.Drawing.Point(122, 25);
            this.fld_txtHRAllowanceNo.Name = "fld_txtHRAllowanceNo";
            this.fld_txtHRAllowanceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAllowanceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAllowanceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAllowanceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAllowanceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAllowanceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAllowanceNo.Screen = null;
            this.fld_txtHRAllowanceNo.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRAllowanceNo.TabIndex = 0;
            this.fld_txtHRAllowanceNo.Tag = "SC";
            // 
            // fld_txtAllowanceName
            // 
            this.fld_txtAllowanceName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSDataMember = "HRAllowanceName";
            this.fld_txtAllowanceName.BOSDataSource = "HRAllowances";
            this.fld_txtAllowanceName.BOSDescription = null;
            this.fld_txtAllowanceName.BOSError = null;
            this.fld_txtAllowanceName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.BOSPropertyName = "Text";
            this.fld_txtAllowanceName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtAllowanceName.Location = new System.Drawing.Point(122, 51);
            this.fld_txtAllowanceName.Name = "fld_txtAllowanceName";
            this.fld_txtAllowanceName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAllowanceName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAllowanceName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAllowanceName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAllowanceName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAllowanceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAllowanceName.Screen = null;
            this.fld_txtAllowanceName.Size = new System.Drawing.Size(113, 20);
            this.fld_txtAllowanceName.TabIndex = 1;
            this.fld_txtAllowanceName.Tag = "SC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRAllowances";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(122, 77);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(182, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(42, 80);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 51;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // SMHRAL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtHRAllowanceNo);
            this.Controls.Add(this.fld_txtAllowanceName);
            this.Controls.Add(this.fld_dgcHRAllowances);
            this.Name = "SMHRAL100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHRAllowances, 0);
            this.Controls.SetChildIndex(this.fld_txtAllowanceName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRAllowanceNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAllowanceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcHRAllowances;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRAllowances;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtHRAllowanceNo;
        private BOSComponent.BOSTextBox fld_txtAllowanceName;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel2;
	}
}
