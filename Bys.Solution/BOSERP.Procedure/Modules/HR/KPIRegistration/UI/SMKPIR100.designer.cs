using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPIRegistration.UI
{
	/// <summary>
	/// Summary description for SMKPIR100
	/// </summary>
	partial class SMKPIR100
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
            this.fld_dgcHRKPIRegistrations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchKPIRegistrationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchKPIRegistrationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRKPIRegistrationNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lblLabel14.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(33, 66);
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
            this.fld_lblLabel17.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(317, 66);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 30;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dgcHRKPIRegistrations
            // 
            this.fld_dgcHRKPIRegistrations.AllowDrop = true;
            this.fld_dgcHRKPIRegistrations.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrations.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrations.BOSDataSource = "HRKPIRegistrations";
            this.fld_dgcHRKPIRegistrations.BOSDescription = null;
            this.fld_dgcHRKPIRegistrations.BOSError = null;
            this.fld_dgcHRKPIRegistrations.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrations.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrations.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrations.BOSPropertyName = null;
            this.fld_dgcHRKPIRegistrations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIRegistrations.Location = new System.Drawing.Point(31, 279);
            this.fld_dgcHRKPIRegistrations.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRKPIRegistrations.Name = "fld_dgcHRKPIRegistrations";
            this.fld_dgcHRKPIRegistrations.Screen = null;
            this.fld_dgcHRKPIRegistrations.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRKPIRegistrations.TabIndex = 33;
            this.fld_dgcHRKPIRegistrations.Tag = "SR";
            this.fld_dgcHRKPIRegistrations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRKPIRegistrations;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchKPIRegistrationFromDate
            // 
            this.fld_dteSearchKPIRegistrationFromDate.BOSComment = string.Empty;
            this.fld_dteSearchKPIRegistrationFromDate.BOSDataMember = "KPIRegistrationFromDate";
            this.fld_dteSearchKPIRegistrationFromDate.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteSearchKPIRegistrationFromDate.BOSDescription = null;
            this.fld_dteSearchKPIRegistrationFromDate.BOSError = null;
            this.fld_dteSearchKPIRegistrationFromDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchKPIRegistrationFromDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchKPIRegistrationFromDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchKPIRegistrationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchKPIRegistrationFromDate.EditValue = null;
            this.fld_dteSearchKPIRegistrationFromDate.Location = new System.Drawing.Point(144, 63);
            this.fld_dteSearchKPIRegistrationFromDate.Name = "fld_dteSearchKPIRegistrationFromDate";
            this.fld_dteSearchKPIRegistrationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchKPIRegistrationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchKPIRegistrationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchKPIRegistrationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchKPIRegistrationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchKPIRegistrationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchKPIRegistrationFromDate.Screen = null;
            this.fld_dteSearchKPIRegistrationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchKPIRegistrationFromDate.TabIndex = 2;
            this.fld_dteSearchKPIRegistrationFromDate.Tag = "SC";
            // 
            // fld_dteSearchKPIRegistrationToDate
            // 
            this.fld_dteSearchKPIRegistrationToDate.BOSComment = string.Empty;
            this.fld_dteSearchKPIRegistrationToDate.BOSDataMember = "KPIRegistrationToDate";
            this.fld_dteSearchKPIRegistrationToDate.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteSearchKPIRegistrationToDate.BOSDescription = null;
            this.fld_dteSearchKPIRegistrationToDate.BOSError = null;
            this.fld_dteSearchKPIRegistrationToDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchKPIRegistrationToDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchKPIRegistrationToDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchKPIRegistrationToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchKPIRegistrationToDate.EditValue = null;
            this.fld_dteSearchKPIRegistrationToDate.Location = new System.Drawing.Point(352, 63);
            this.fld_dteSearchKPIRegistrationToDate.Name = "fld_dteSearchKPIRegistrationToDate";
            this.fld_dteSearchKPIRegistrationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchKPIRegistrationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchKPIRegistrationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchKPIRegistrationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchKPIRegistrationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchKPIRegistrationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchKPIRegistrationToDate.Screen = null;
            this.fld_dteSearchKPIRegistrationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchKPIRegistrationToDate.TabIndex = 3;
            this.fld_dteSearchKPIRegistrationToDate.Tag = "SC";
            // 
            // fld_txtHRKPIRegistrationNo
            // 
            this.fld_txtHRKPIRegistrationNo.BOSComment = string.Empty;
            this.fld_txtHRKPIRegistrationNo.BOSDataMember = "HRKPIRegistrationNo";
            this.fld_txtHRKPIRegistrationNo.BOSDataSource = "HRKPIRegistrationrations";
            this.fld_txtHRKPIRegistrationNo.BOSDescription = null;
            this.fld_txtHRKPIRegistrationNo.BOSError = null;
            this.fld_txtHRKPIRegistrationNo.BOSFieldGroup = string.Empty;
            this.fld_txtHRKPIRegistrationNo.BOSFieldRelation = string.Empty;
            this.fld_txtHRKPIRegistrationNo.BOSPrivilege = string.Empty;
            this.fld_txtHRKPIRegistrationNo.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIRegistrationNo.EditValue = string.Empty;
            this.fld_txtHRKPIRegistrationNo.Location = new System.Drawing.Point(144, 37);
            this.fld_txtHRKPIRegistrationNo.Name = "fld_txtHRKPIRegistrationNo";
            this.fld_txtHRKPIRegistrationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPIRegistrationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPIRegistrationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPIRegistrationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPIRegistrationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPIRegistrationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPIRegistrationNo.Screen = null;
            this.fld_txtHRKPIRegistrationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRKPIRegistrationNo.TabIndex = 0;
            this.fld_txtHRKPIRegistrationNo.Tag = "SC";
            // 
            // SMKPIR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRKPIRegistrations);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtHRKPIRegistrationNo);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dteSearchKPIRegistrationFromDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchKPIRegistrationToDate);
            this.Name = "SMKPIR100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchKPIRegistrationToDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchKPIRegistrationFromDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_txtHRKPIRegistrationNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRKPIRegistrations, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIRegistrationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcHRKPIRegistrations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchKPIRegistrationFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchKPIRegistrationToDate;
        private BOSComponent.BOSTextBox fld_txtHRKPIRegistrationNo;
        private IContainer components;
	}
}
