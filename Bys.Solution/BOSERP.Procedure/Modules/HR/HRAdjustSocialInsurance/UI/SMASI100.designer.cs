using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRAdjustSocialInsurance.UI
{
	/// <summary>
	/// Summary description for SMASI100
	/// </summary>
	partial class SMASI100
	{
		private BOSComponent.BOSTextBox fld_txtHRAdjustSocialInsuranceNo1;
		private BOSComponent.BOSDateEdit fld_dteHRAdjustSocialInsuranceDate1;
        private BOSComponent.BOSTextBox fld_txtHRAdjustSocialInsuranceStatus1;


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
            this.fld_txtHRAdjustSocialInsuranceNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRAdjustSocialInsuranceDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRAdjustSocialInsuranceStatus1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRAdjustSocialInsurances = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRAdjustSocialInsurances = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdjustSocialInsuranceNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdjustSocialInsuranceStatus1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdjustSocialInsurances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAdjustSocialInsurances)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRAdjustSocialInsuranceNo1
            // 
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSDataMember = "HRAdjustSocialInsuranceNo";
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSDescription = null;
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSError = null;
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceNo1.BOSPropertyName = "Text";
            this.fld_txtHRAdjustSocialInsuranceNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceNo1.Location = new System.Drawing.Point(116, 22);
            this.fld_txtHRAdjustSocialInsuranceNo1.Name = "fld_txtHRAdjustSocialInsuranceNo1";
            this.fld_txtHRAdjustSocialInsuranceNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdjustSocialInsuranceNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdjustSocialInsuranceNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdjustSocialInsuranceNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdjustSocialInsuranceNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdjustSocialInsuranceNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdjustSocialInsuranceNo1.Screen = null;
            this.fld_txtHRAdjustSocialInsuranceNo1.Size = new System.Drawing.Size(152, 20);
            this.fld_txtHRAdjustSocialInsuranceNo1.TabIndex = 4;
            this.fld_txtHRAdjustSocialInsuranceNo1.Tag = "SC";
            // 
            // fld_dteHRAdjustSocialInsuranceDate1
            // 
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSDataMember = "HRAdjustSocialInsuranceDate";
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSDescription = null;
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSError = null;
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdjustSocialInsuranceDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRAdjustSocialInsuranceDate1.EditValue = null;
            this.fld_dteHRAdjustSocialInsuranceDate1.Location = new System.Drawing.Point(116, 48);
            this.fld_dteHRAdjustSocialInsuranceDate1.Name = "fld_dteHRAdjustSocialInsuranceDate1";
            this.fld_dteHRAdjustSocialInsuranceDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAdjustSocialInsuranceDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAdjustSocialInsuranceDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAdjustSocialInsuranceDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAdjustSocialInsuranceDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAdjustSocialInsuranceDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAdjustSocialInsuranceDate1.Screen = null;
            this.fld_dteHRAdjustSocialInsuranceDate1.Size = new System.Drawing.Size(152, 20);
            this.fld_dteHRAdjustSocialInsuranceDate1.TabIndex = 5;
            this.fld_dteHRAdjustSocialInsuranceDate1.Tag = "SC";
            // 
            // fld_txtHRAdjustSocialInsuranceStatus1
            // 
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSDataMember = "HRAdjustSocialInsuranceStatus";
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSDescription = null;
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSError = null;
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceStatus1.BOSPropertyName = "Text";
            this.fld_txtHRAdjustSocialInsuranceStatus1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdjustSocialInsuranceStatus1.Location = new System.Drawing.Point(116, 74);
            this.fld_txtHRAdjustSocialInsuranceStatus1.Name = "fld_txtHRAdjustSocialInsuranceStatus1";
            this.fld_txtHRAdjustSocialInsuranceStatus1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdjustSocialInsuranceStatus1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdjustSocialInsuranceStatus1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdjustSocialInsuranceStatus1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdjustSocialInsuranceStatus1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdjustSocialInsuranceStatus1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdjustSocialInsuranceStatus1.Screen = null;
            this.fld_txtHRAdjustSocialInsuranceStatus1.Size = new System.Drawing.Size(152, 20);
            this.fld_txtHRAdjustSocialInsuranceStatus1.TabIndex = 6;
            this.fld_txtHRAdjustSocialInsuranceStatus1.Tag = "SC";
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
            this.bosLabel4.Location = new System.Drawing.Point(21, 77);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 17;
            this.bosLabel4.Text = "Tình trạng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(21, 51);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(25, 13);
            this.bosLabel2.TabIndex = 16;
            this.bosLabel2.Text = "Ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(21, 25);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 15;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_dgcHRAdjustSocialInsurances
            // 
            this.fld_dgcHRAdjustSocialInsurances.AllowDrop = true;
            this.fld_dgcHRAdjustSocialInsurances.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdjustSocialInsurances.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdjustSocialInsurances.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_dgcHRAdjustSocialInsurances.BOSDescription = null;
            this.fld_dgcHRAdjustSocialInsurances.BOSError = null;
            this.fld_dgcHRAdjustSocialInsurances.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdjustSocialInsurances.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdjustSocialInsurances.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdjustSocialInsurances.BOSPropertyName = "Search Result";
            this.fld_dgcHRAdjustSocialInsurances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRAdjustSocialInsurances.Location = new System.Drawing.Point(21, 165);
            this.fld_dgcHRAdjustSocialInsurances.MainView = this.fld_dgvHRAdjustSocialInsurances;
            this.fld_dgcHRAdjustSocialInsurances.Name = "fld_dgcHRAdjustSocialInsurances";
            this.fld_dgcHRAdjustSocialInsurances.Screen = null;
            this.fld_dgcHRAdjustSocialInsurances.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRAdjustSocialInsurances.TabIndex = 18;
            this.fld_dgcHRAdjustSocialInsurances.Tag = "SR";
            this.fld_dgcHRAdjustSocialInsurances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRAdjustSocialInsurances});
            // 
            // fld_dgvHRAdjustSocialInsurances
            // 
            this.fld_dgvHRAdjustSocialInsurances.GridControl = this.fld_dgcHRAdjustSocialInsurances;
            this.fld_dgvHRAdjustSocialInsurances.Name = "fld_dgvHRAdjustSocialInsurances";
            this.fld_dgvHRAdjustSocialInsurances.PaintStyleName = "Office2003";
            // 
            // SMASI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRAdjustSocialInsurances);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtHRAdjustSocialInsuranceNo1);
            this.Controls.Add(this.fld_dteHRAdjustSocialInsuranceDate1);
            this.Controls.Add(this.fld_txtHRAdjustSocialInsuranceStatus1);
            this.Name = "SMASI100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRAdjustSocialInsuranceStatus1, 0);
            this.Controls.SetChildIndex(this.fld_dteHRAdjustSocialInsuranceDate1, 0);
            this.Controls.SetChildIndex(this.fld_txtHRAdjustSocialInsuranceNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRAdjustSocialInsurances, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdjustSocialInsuranceNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdjustSocialInsuranceStatus1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdjustSocialInsurances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAdjustSocialInsurances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRAdjustSocialInsurances;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRAdjustSocialInsurances;
	}
}
