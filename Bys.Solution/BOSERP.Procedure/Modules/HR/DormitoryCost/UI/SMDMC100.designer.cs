using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DormitoryCost.UI
{
	/// <summary>
    /// Summary description for SMRD100
	/// </summary>
    partial class SMDMC100
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
            this.fld_dgcHRDormitoryCosts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRegisterDormitoryNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitoryCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRDormitoryCosts
            // 
            this.fld_dgcHRDormitoryCosts.BOSComment = null;
            this.fld_dgcHRDormitoryCosts.BOSDataMember = null;
            this.fld_dgcHRDormitoryCosts.BOSDataSource = "HRDormitoryCosts";
            this.fld_dgcHRDormitoryCosts.BOSDescription = null;
            this.fld_dgcHRDormitoryCosts.BOSError = null;
            this.fld_dgcHRDormitoryCosts.BOSFieldGroup = null;
            this.fld_dgcHRDormitoryCosts.BOSFieldRelation = null;
            this.fld_dgcHRDormitoryCosts.BOSPrivilege = null;
            this.fld_dgcHRDormitoryCosts.BOSPropertyName = null;
            this.fld_dgcHRDormitoryCosts.Location = new System.Drawing.Point(38, 185);
            this.fld_dgcHRDormitoryCosts.MenuManager = this.screenToolbar;
            this.fld_dgcHRDormitoryCosts.Name = "fld_dgcHRDormitoryCosts";
            this.fld_dgcHRDormitoryCosts.Screen = null;
            this.fld_dgcHRDormitoryCosts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRDormitoryCosts.TabIndex = 101;
            this.fld_dgcHRDormitoryCosts.Tag = "SR";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(43, 45);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 99;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtHRRegisterDormitoryNo
            // 
            this.fld_txtHRRegisterDormitoryNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSDataMember = "HRDormitoryCostNo";
            this.fld_txtHRRegisterDormitoryNo.BOSDataSource = "HRDormitoryCosts";
            this.fld_txtHRRegisterDormitoryNo.BOSDescription = null;
            this.fld_txtHRRegisterDormitoryNo.BOSError = null;
            this.fld_txtHRRegisterDormitoryNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSPropertyName = "Text";
            this.fld_txtHRRegisterDormitoryNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.Location = new System.Drawing.Point(128, 42);
            this.fld_txtHRRegisterDormitoryNo.Name = "fld_txtHRRegisterDormitoryNo";
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRegisterDormitoryNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRegisterDormitoryNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRegisterDormitoryNo.Screen = null;
            this.fld_txtHRRegisterDormitoryNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRRegisterDormitoryNo.TabIndex = 97;
            this.fld_txtHRRegisterDormitoryNo.Tag = "SC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(43, 71);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel14.TabIndex = 104;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ";
            // 
            // fld_dteSearchFromARSaleOrderDate
            // 
            this.fld_dteSearchFromARSaleOrderDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSDataMember = "HRDormitoryCostDate";
            this.fld_dteSearchFromARSaleOrderDate.BOSDataSource = "HRDormitoryCosts";
            this.fld_dteSearchFromARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSError = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARSaleOrderDate.EditValue = null;
            this.fld_dteSearchFromARSaleOrderDate.Location = new System.Drawing.Point(128, 68);
            this.fld_dteSearchFromARSaleOrderDate.Name = "fld_dteSearchFromARSaleOrderDate";
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleOrderDate.Screen = null;
            this.fld_dteSearchFromARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARSaleOrderDate.TabIndex = 102;
            this.fld_dteSearchFromARSaleOrderDate.Tag = "SC";
            // 
            // fld_dteSearchToARSaleOrderDate
            // 
            this.fld_dteSearchToARSaleOrderDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSDataMember = "HRDormitoryCostFromDate";
            this.fld_dteSearchToARSaleOrderDate.BOSDataSource = "HRDormitoryCosts";
            this.fld_dteSearchToARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchToARSaleOrderDate.BOSError = null;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARSaleOrderDate.EditValue = null;
            this.fld_dteSearchToARSaleOrderDate.Location = new System.Drawing.Point(128, 94);
            this.fld_dteSearchToARSaleOrderDate.Name = "fld_dteSearchToARSaleOrderDate";
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleOrderDate.Screen = null;
            this.fld_dteSearchToARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARSaleOrderDate.TabIndex = 103;
            this.fld_dteSearchToARSaleOrderDate.Tag = "SC";
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(43, 97);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 105;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(43, 123);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 107;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosDateEdit1.BOSDataMember = "HRDormitoryCostToDate";
            this.bosDateEdit1.BOSDataSource = "HRDormitoryCosts";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosDateEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosDateEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(128, 120);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 106;
            this.bosDateEdit1.Tag = "SC";
            // 
            // SMDMC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosDateEdit1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dteSearchFromARSaleOrderDate);
            this.Controls.Add(this.fld_dteSearchToARSaleOrderDate);
            this.Controls.Add(this.fld_dgcHRDormitoryCosts);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtHRRegisterDormitoryNo);
            this.Name = "SMDMC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRRegisterDormitoryNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRDormitoryCosts, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosDateEdit1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitoryCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRDormitoryCosts;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtHRRegisterDormitoryNo;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleOrderDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARSaleOrderDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit bosDateEdit1;
	}
}
