using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ElectronicInvoiceBKAV.UI
{
	/// <summary>
	/// Summary description for SMBAA100
	/// </summary>
	partial class SMEIBKAV100
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
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACBalanceAmountArisingFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACBalanceAmountArisingToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACEInvoiceGeneralsSearch = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHREmployeeComission = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceGeneralsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeComission)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Location = new System.Drawing.Point(25, 24);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 83;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Từ ngày";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Location = new System.Drawing.Point(25, 53);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 82;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteACBalanceAmountArisingFromDate
            // 
            this.fld_dteACBalanceAmountArisingFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSDataMember = "ACBalanceAmountArisingFromDate";
            this.fld_dteACBalanceAmountArisingFromDate.BOSDataSource = "ACBalanceAmountArisings";
            this.fld_dteACBalanceAmountArisingFromDate.BOSDescription = null;
            this.fld_dteACBalanceAmountArisingFromDate.BOSError = null;
            this.fld_dteACBalanceAmountArisingFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACBalanceAmountArisingFromDate.EditValue = null;
            this.fld_dteACBalanceAmountArisingFromDate.Location = new System.Drawing.Point(95, 21);
            this.fld_dteACBalanceAmountArisingFromDate.Name = "fld_dteACBalanceAmountArisingFromDate";
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBalanceAmountArisingFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBalanceAmountArisingFromDate.Screen = null;
            this.fld_dteACBalanceAmountArisingFromDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteACBalanceAmountArisingFromDate.TabIndex = 80;
            this.fld_dteACBalanceAmountArisingFromDate.Tag = "SC";
            // 
            // fld_dteACBalanceAmountArisingToDate
            // 
            this.fld_dteACBalanceAmountArisingToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSDataMember = "ACBalanceAmountArisingToDate";
            this.fld_dteACBalanceAmountArisingToDate.BOSDataSource = "ACBalanceAmountArisings";
            this.fld_dteACBalanceAmountArisingToDate.BOSDescription = null;
            this.fld_dteACBalanceAmountArisingToDate.BOSError = null;
            this.fld_dteACBalanceAmountArisingToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSPropertyName = "EditValue";
            this.fld_dteACBalanceAmountArisingToDate.EditValue = null;
            this.fld_dteACBalanceAmountArisingToDate.Location = new System.Drawing.Point(95, 50);
            this.fld_dteACBalanceAmountArisingToDate.Name = "fld_dteACBalanceAmountArisingToDate";
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBalanceAmountArisingToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBalanceAmountArisingToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBalanceAmountArisingToDate.Screen = null;
            this.fld_dteACBalanceAmountArisingToDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteACBalanceAmountArisingToDate.TabIndex = 81;
            this.fld_dteACBalanceAmountArisingToDate.Tag = "SC";
            // 
            // fld_dgcACEInvoiceGeneralsSearch
            // 
            this.fld_dgcACEInvoiceGeneralsSearch.AllowDrop = true;
            this.fld_dgcACEInvoiceGeneralsSearch.BOSComment = "";
            this.fld_dgcACEInvoiceGeneralsSearch.BOSDataMember = "";
            this.fld_dgcACEInvoiceGeneralsSearch.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_dgcACEInvoiceGeneralsSearch.BOSDescription = null;
            this.fld_dgcACEInvoiceGeneralsSearch.BOSError = null;
            this.fld_dgcACEInvoiceGeneralsSearch.BOSFieldGroup = "";
            this.fld_dgcACEInvoiceGeneralsSearch.BOSFieldRelation = "";
            this.fld_dgcACEInvoiceGeneralsSearch.BOSPrivilege = "";
            this.fld_dgcACEInvoiceGeneralsSearch.BOSPropertyName = "";
            this.fld_dgcACEInvoiceGeneralsSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEInvoiceGeneralsSearch.Location = new System.Drawing.Point(25, 90);
            this.fld_dgcACEInvoiceGeneralsSearch.MainView = this.fld_dgvHREmployeeComission;
            this.fld_dgcACEInvoiceGeneralsSearch.Name = "fld_dgcACEInvoiceGeneralsSearch";
            this.fld_dgcACEInvoiceGeneralsSearch.Screen = null;
            this.fld_dgcACEInvoiceGeneralsSearch.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACEInvoiceGeneralsSearch.TabIndex = 79;
            this.fld_dgcACEInvoiceGeneralsSearch.Tag = "SR";
            this.fld_dgcACEInvoiceGeneralsSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeComission});
            // 
            // fld_dgvHREmployeeComission
            // 
            this.fld_dgvHREmployeeComission.GridControl = this.fld_dgcACEInvoiceGeneralsSearch;
            this.fld_dgvHREmployeeComission.Name = "fld_dgvHREmployeeComission";
            this.fld_dgvHREmployeeComission.PaintStyleName = "Office2003";
            // 
            // SMEI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_dteACBalanceAmountArisingFromDate);
            this.Controls.Add(this.fld_dteACBalanceAmountArisingToDate);
            this.Controls.Add(this.fld_dgcACEInvoiceGeneralsSearch);
            this.Name = "SMEI100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcACEInvoiceGeneralsSearch, 0);
            this.Controls.SetChildIndex(this.fld_dteACBalanceAmountArisingToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteACBalanceAmountArisingFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceGeneralsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeComission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteACBalanceAmountArisingFromDate;
        private BOSComponent.BOSDateEdit fld_dteACBalanceAmountArisingToDate;
        private BOSSearchResultsGridControl fld_dgcACEInvoiceGeneralsSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeComission;
        private IContainer components;
	}
}
