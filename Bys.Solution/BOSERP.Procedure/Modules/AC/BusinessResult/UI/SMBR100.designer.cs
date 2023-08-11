using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BusinessResult.UI
{
	/// <summary>
	/// Summary description for SMBR100
	/// </summary>
	partial class SMBR100
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
            this.fld_dteACBusinessResultFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACBusinessResultToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACBusinessResults = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHREmployeeComission = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBusinessResults)).BeginInit();
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
            this.bosLabel3.Location = new System.Drawing.Point(18, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 93;
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
            this.bosLabel4.Location = new System.Drawing.Point(18, 44);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 92;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteACBusinessResultFromDate
            // 
            this.fld_dteACBusinessResultFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultFromDate.BOSDataMember = "ACBusinessResultFromDate";
            this.fld_dteACBusinessResultFromDate.BOSDataSource = "ACBusinessResults";
            this.fld_dteACBusinessResultFromDate.BOSDescription = null;
            this.fld_dteACBusinessResultFromDate.BOSError = null;
            this.fld_dteACBusinessResultFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACBusinessResultFromDate.EditValue = null;
            this.fld_dteACBusinessResultFromDate.Location = new System.Drawing.Point(88, 12);
            this.fld_dteACBusinessResultFromDate.Name = "fld_dteACBusinessResultFromDate";
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBusinessResultFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBusinessResultFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBusinessResultFromDate.Screen = null;
            this.fld_dteACBusinessResultFromDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteACBusinessResultFromDate.TabIndex = 90;
            this.fld_dteACBusinessResultFromDate.Tag = "SC";
            // 
            // fld_dteACBusinessResultToDate
            // 
            this.fld_dteACBusinessResultToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultToDate.BOSDataMember = "ACBusinessResultToDate";
            this.fld_dteACBusinessResultToDate.BOSDataSource = "ACBusinessResults";
            this.fld_dteACBusinessResultToDate.BOSDescription = null;
            this.fld_dteACBusinessResultToDate.BOSError = null;
            this.fld_dteACBusinessResultToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBusinessResultToDate.BOSPropertyName = "EditValue";
            this.fld_dteACBusinessResultToDate.EditValue = null;
            this.fld_dteACBusinessResultToDate.Location = new System.Drawing.Point(88, 41);
            this.fld_dteACBusinessResultToDate.Name = "fld_dteACBusinessResultToDate";
            this.fld_dteACBusinessResultToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBusinessResultToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBusinessResultToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBusinessResultToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBusinessResultToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBusinessResultToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBusinessResultToDate.Screen = null;
            this.fld_dteACBusinessResultToDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteACBusinessResultToDate.TabIndex = 91;
            this.fld_dteACBusinessResultToDate.Tag = "SC";
            // 
            // fld_dgcACBusinessResults
            // 
            this.fld_dgcACBusinessResults.AllowDrop = true;
            this.fld_dgcACBusinessResults.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBusinessResults.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBusinessResults.BOSDataSource = "ACBusinessResults";
            this.fld_dgcACBusinessResults.BOSDescription = null;
            this.fld_dgcACBusinessResults.BOSError = null;
            this.fld_dgcACBusinessResults.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBusinessResults.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBusinessResults.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBusinessResults.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBusinessResults.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBusinessResults.Location = new System.Drawing.Point(18, 81);
            this.fld_dgcACBusinessResults.MainView = this.fld_dgvHREmployeeComission;
            this.fld_dgcACBusinessResults.Name = "fld_dgcACBusinessResults";
            this.fld_dgcACBusinessResults.Screen = null;
            this.fld_dgcACBusinessResults.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACBusinessResults.TabIndex = 89;
            this.fld_dgcACBusinessResults.Tag = "SR";
            this.fld_dgcACBusinessResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeComission});
            // 
            // fld_dgvHREmployeeComission
            // 
            this.fld_dgvHREmployeeComission.GridControl = this.fld_dgcACBusinessResults;
            this.fld_dgvHREmployeeComission.Name = "fld_dgvHREmployeeComission";
            this.fld_dgvHREmployeeComission.PaintStyleName = "Office2003";
            // 
            // SMBR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_dteACBusinessResultFromDate);
            this.Controls.Add(this.fld_dteACBusinessResultToDate);
            this.Controls.Add(this.fld_dgcACBusinessResults);
            this.Name = "SMBR100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcACBusinessResults, 0);
            this.Controls.SetChildIndex(this.fld_dteACBusinessResultToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteACBusinessResultFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBusinessResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeComission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteACBusinessResultFromDate;
        private BOSComponent.BOSDateEdit fld_dteACBusinessResultToDate;
        private BOSSearchResultsGridControl fld_dgcACBusinessResults;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeComission;
        private IContainer components;
	}
}
