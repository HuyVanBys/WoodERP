using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentTerm.UI
{
	/// <summary>
	/// Summary description for SMPT100
	/// </summary>
	partial class SMPT100
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
            this.fld_medGEPaymentTermName = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeGEPaymentTermCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtGEPaymentTermNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcGEPaymentTerm = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGEPaymentTerm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lbLoai = new BOSComponent.BOSLabel(this.components);
            this.fld_lbPaymentTermNo = new BOSComponent.BOSLabel(this.components);
            this.fld_lbPaymentTermName = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGEPaymentTermName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGEPaymentTermCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEPaymentTermNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEPaymentTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEPaymentTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_medGEPaymentTermName
            // 
            this.fld_medGEPaymentTermName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEPaymentTermName.BOSDataMember = "GEPaymentTermName";
            this.fld_medGEPaymentTermName.BOSDataSource = "GEPaymentTerms";
            this.fld_medGEPaymentTermName.BOSDescription = null;
            this.fld_medGEPaymentTermName.BOSError = null;
            this.fld_medGEPaymentTermName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEPaymentTermName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEPaymentTermName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEPaymentTermName.BOSPropertyName = "Text";
            this.fld_medGEPaymentTermName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEPaymentTermName.Location = new System.Drawing.Point(146, 36);
            this.fld_medGEPaymentTermName.Name = "fld_medGEPaymentTermName";
            this.fld_medGEPaymentTermName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medGEPaymentTermName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medGEPaymentTermName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medGEPaymentTermName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medGEPaymentTermName.Screen = null;
            this.fld_medGEPaymentTermName.Size = new System.Drawing.Size(315, 42);
            this.fld_medGEPaymentTermName.TabIndex = 22;
            this.fld_medGEPaymentTermName.Tag = "SC";
            // 
            // fld_lkeGEPaymentTermCombo
            // 
            this.fld_lkeGEPaymentTermCombo.BOSAllowAddNew = false;
            this.fld_lkeGEPaymentTermCombo.BOSAllowDummy = false;
            this.fld_lkeGEPaymentTermCombo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.BOSDataMember = "GEPaymentTermType";
            this.fld_lkeGEPaymentTermCombo.BOSDataSource = "GEPaymentTerms";
            this.fld_lkeGEPaymentTermCombo.BOSDescription = null;
            this.fld_lkeGEPaymentTermCombo.BOSError = null;
            this.fld_lkeGEPaymentTermCombo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.BOSPropertyName = "EditValue";
            this.fld_lkeGEPaymentTermCombo.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.CurrentDisplayText = null;
            this.fld_lkeGEPaymentTermCombo.Location = new System.Drawing.Point(146, 85);
            this.fld_lkeGEPaymentTermCombo.Name = "fld_lkeGEPaymentTermCombo";
            this.fld_lkeGEPaymentTermCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeGEPaymentTermCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeGEPaymentTermCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeGEPaymentTermCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeGEPaymentTermCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGEPaymentTermCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEPaymentTermCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeGEPaymentTermCombo.Screen = null;
            this.fld_lkeGEPaymentTermCombo.Size = new System.Drawing.Size(315, 20);
            this.fld_lkeGEPaymentTermCombo.TabIndex = 24;
            this.fld_lkeGEPaymentTermCombo.Tag = "SC";
            // 
            // fld_txtGEPaymentTermNo
            // 
            this.fld_txtGEPaymentTermNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEPaymentTermNo.BOSDataMember = "GEPaymentTermNo";
            this.fld_txtGEPaymentTermNo.BOSDataSource = "GEPaymentTerms";
            this.fld_txtGEPaymentTermNo.BOSDescription = null;
            this.fld_txtGEPaymentTermNo.BOSError = null;
            this.fld_txtGEPaymentTermNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEPaymentTermNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEPaymentTermNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEPaymentTermNo.BOSPropertyName = "Text";
            this.fld_txtGEPaymentTermNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEPaymentTermNo.Location = new System.Drawing.Point(146, 10);
            this.fld_txtGEPaymentTermNo.Name = "fld_txtGEPaymentTermNo";
            this.fld_txtGEPaymentTermNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEPaymentTermNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEPaymentTermNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEPaymentTermNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEPaymentTermNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEPaymentTermNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEPaymentTermNo.Screen = null;
            this.fld_txtGEPaymentTermNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtGEPaymentTermNo.TabIndex = 21;
            this.fld_txtGEPaymentTermNo.Tag = "SC";
            // 
            // fld_dgcGEPaymentTerm
            // 
            this.fld_dgcGEPaymentTerm.AllowDrop = true;
            this.fld_dgcGEPaymentTerm.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEPaymentTerm.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEPaymentTerm.BOSDataSource = "GEPaymentTerms";
            this.fld_dgcGEPaymentTerm.BOSDescription = null;
            this.fld_dgcGEPaymentTerm.BOSError = null;
            this.fld_dgcGEPaymentTerm.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEPaymentTerm.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEPaymentTerm.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEPaymentTerm.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEPaymentTerm.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcGEPaymentTerm.Location = new System.Drawing.Point(30, 124);
            this.fld_dgcGEPaymentTerm.MainView = this.fld_dgvGEPaymentTerm;
            this.fld_dgcGEPaymentTerm.Name = "fld_dgcGEPaymentTerm";
            this.fld_dgcGEPaymentTerm.Screen = null;
            this.fld_dgcGEPaymentTerm.Size = new System.Drawing.Size(508, 428);
            this.fld_dgcGEPaymentTerm.TabIndex = 25;
            this.fld_dgcGEPaymentTerm.Tag = "SR";
            this.fld_dgcGEPaymentTerm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEPaymentTerm});
            // 
            // fld_dgvGEPaymentTerm
            // 
            this.fld_dgvGEPaymentTerm.GridControl = this.fld_dgcGEPaymentTerm;
            this.fld_dgvGEPaymentTerm.Name = "fld_dgvGEPaymentTerm";
            this.fld_dgvGEPaymentTerm.PaintStyleName = "Office2003";
            // 
            // fld_lbLoai
            // 
            this.fld_lbLoai.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbLoai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbLoai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbLoai.Appearance.Options.UseBackColor = true;
            this.fld_lbLoai.Appearance.Options.UseFont = true;
            this.fld_lbLoai.Appearance.Options.UseForeColor = true;
            this.fld_lbLoai.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.BOSDescription = null;
            this.fld_lbLoai.BOSError = null;
            this.fld_lbLoai.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbLoai.Location = new System.Drawing.Point(4, 88);
            this.fld_lbLoai.Name = "fld_lbLoai";
            this.fld_lbLoai.Screen = null;
            this.fld_lbLoai.Size = new System.Drawing.Size(20, 13);
            this.fld_lbLoai.TabIndex = 27;
            this.fld_lbLoai.Tag = "SI";
            this.fld_lbLoai.Text = "Loại";
            // 
            // fld_lbPaymentTermNo
            // 
            this.fld_lbPaymentTermNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermNo.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDescription = null;
            this.fld_lbPaymentTermNo.BOSError = null;
            this.fld_lbPaymentTermNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermNo.Location = new System.Drawing.Point(4, 13);
            this.fld_lbPaymentTermNo.Name = "fld_lbPaymentTermNo";
            this.fld_lbPaymentTermNo.Screen = null;
            this.fld_lbPaymentTermNo.Size = new System.Drawing.Size(127, 13);
            this.fld_lbPaymentTermNo.TabIndex = 26;
            this.fld_lbPaymentTermNo.Tag = "SI";
            this.fld_lbPaymentTermNo.Text = "Mã Điều khoản thanh toán";
            // 
            // fld_lbPaymentTermName
            // 
            this.fld_lbPaymentTermName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTermName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbPaymentTermName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermName.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseFont = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermName.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDescription = null;
            this.fld_lbPaymentTermName.BOSError = null;
            this.fld_lbPaymentTermName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lbPaymentTermName.Location = new System.Drawing.Point(4, 39);
            this.fld_lbPaymentTermName.Name = "fld_lbPaymentTermName";
            this.fld_lbPaymentTermName.Screen = null;
            this.fld_lbPaymentTermName.Size = new System.Drawing.Size(136, 13);
            this.fld_lbPaymentTermName.TabIndex = 23;
            this.fld_lbPaymentTermName.Tag = "SI";
            this.fld_lbPaymentTermName.Text = "Tên điều khoản thanh thoán";
            // 
            // SMPT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(572, 567);
            this.Controls.Add(this.fld_medGEPaymentTermName);
            this.Controls.Add(this.fld_lkeGEPaymentTermCombo);
            this.Controls.Add(this.fld_txtGEPaymentTermNo);
            this.Controls.Add(this.fld_dgcGEPaymentTerm);
            this.Controls.Add(this.fld_lbLoai);
            this.Controls.Add(this.fld_lbPaymentTermNo);
            this.Controls.Add(this.fld_lbPaymentTermName);
            this.Name = "SMPT100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lbPaymentTermName, 0);
            this.Controls.SetChildIndex(this.fld_lbPaymentTermNo, 0);
            this.Controls.SetChildIndex(this.fld_lbLoai, 0);
            this.Controls.SetChildIndex(this.fld_dgcGEPaymentTerm, 0);
            this.Controls.SetChildIndex(this.fld_txtGEPaymentTermNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeGEPaymentTermCombo, 0);
            this.Controls.SetChildIndex(this.fld_medGEPaymentTermName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGEPaymentTermName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGEPaymentTermCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEPaymentTermNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEPaymentTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEPaymentTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSMemoEdit fld_medGEPaymentTermName;
        private BOSComponent.BOSLookupEdit fld_lkeGEPaymentTermCombo;
        private BOSComponent.BOSTextBox fld_txtGEPaymentTermNo;
        private BOSSearchResultsGridControl fld_dgcGEPaymentTerm;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEPaymentTerm;
        private BOSComponent.BOSLabel fld_lbLoai;
        private BOSComponent.BOSLabel fld_lbPaymentTermNo;
        private BOSComponent.BOSLabel fld_lbPaymentTermName;
        private IContainer components;
	}
}
