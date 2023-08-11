using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AccountingSheet.UI
{
	/// <summary>
	/// Summary description for SMBS100
	/// </summary>
	partial class SMBS100
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
            this.fld_dteACAccountingSheetFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACAccountingSheetToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACAccountingSheets = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHREmployeeComission = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAccountingSheets)).BeginInit();
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
            this.bosLabel3.Location = new System.Drawing.Point(19, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 88;
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
            this.bosLabel4.Location = new System.Drawing.Point(19, 44);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 87;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteACAccountingSheetFromDate
            // 
            this.fld_dteACAccountingSheetFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSDataMember = "ACAccountingSheetFromDate";
            this.fld_dteACAccountingSheetFromDate.BOSDataSource = "ACAccountingSheets";
            this.fld_dteACAccountingSheetFromDate.BOSDescription = null;
            this.fld_dteACAccountingSheetFromDate.BOSError = null;
            this.fld_dteACAccountingSheetFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACAccountingSheetFromDate.EditValue = null;
            this.fld_dteACAccountingSheetFromDate.Location = new System.Drawing.Point(89, 12);
            this.fld_dteACAccountingSheetFromDate.Name = "fld_dteACAccountingSheetFromDate";
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAccountingSheetFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAccountingSheetFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAccountingSheetFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAccountingSheetFromDate.Screen = null;
            this.fld_dteACAccountingSheetFromDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteACAccountingSheetFromDate.TabIndex = 85;
            this.fld_dteACAccountingSheetFromDate.Tag = "SC";
            // 
            // fld_dteACAccountingSheetToDate
            // 
            this.fld_dteACAccountingSheetToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSDataMember = "ACAccountingSheetToDate";
            this.fld_dteACAccountingSheetToDate.BOSDataSource = "ACAccountingSheets";
            this.fld_dteACAccountingSheetToDate.BOSDescription = null;
            this.fld_dteACAccountingSheetToDate.BOSError = null;
            this.fld_dteACAccountingSheetToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACAccountingSheetToDate.BOSPropertyName = "EditValue";
            this.fld_dteACAccountingSheetToDate.EditValue = null;
            this.fld_dteACAccountingSheetToDate.Location = new System.Drawing.Point(89, 41);
            this.fld_dteACAccountingSheetToDate.Name = "fld_dteACAccountingSheetToDate";
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAccountingSheetToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAccountingSheetToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAccountingSheetToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAccountingSheetToDate.Screen = null;
            this.fld_dteACAccountingSheetToDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteACAccountingSheetToDate.TabIndex = 86;
            this.fld_dteACAccountingSheetToDate.Tag = "SC";
            // 
            // fld_dgcACAccountingSheets
            // 
            this.fld_dgcACAccountingSheets.AllowDrop = true;
            this.fld_dgcACAccountingSheets.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheets.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheets.BOSDataSource = "ACAccountingSheets";
            this.fld_dgcACAccountingSheets.BOSDescription = null;
            this.fld_dgcACAccountingSheets.BOSError = null;
            this.fld_dgcACAccountingSheets.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheets.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheets.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheets.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACAccountingSheets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACAccountingSheets.Location = new System.Drawing.Point(19, 81);
            this.fld_dgcACAccountingSheets.MainView = this.fld_dgvHREmployeeComission;
            this.fld_dgcACAccountingSheets.Name = "fld_dgcACAccountingSheets";
            this.fld_dgcACAccountingSheets.Screen = null;
            this.fld_dgcACAccountingSheets.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACAccountingSheets.TabIndex = 84;
            this.fld_dgcACAccountingSheets.Tag = "SR";
            this.fld_dgcACAccountingSheets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeComission});
            // 
            // fld_dgvHREmployeeComission
            // 
            this.fld_dgvHREmployeeComission.GridControl = this.fld_dgcACAccountingSheets;
            this.fld_dgvHREmployeeComission.Name = "fld_dgvHREmployeeComission";
            this.fld_dgvHREmployeeComission.PaintStyleName = "Office2003";
            // 
            // SMBS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_dteACAccountingSheetFromDate);
            this.Controls.Add(this.fld_dteACAccountingSheetToDate);
            this.Controls.Add(this.fld_dgcACAccountingSheets);
            this.Name = "SMBS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcACAccountingSheets, 0);
            this.Controls.SetChildIndex(this.fld_dteACAccountingSheetToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteACAccountingSheetFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAccountingSheetToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAccountingSheets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeComission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteACAccountingSheetFromDate;
        private BOSComponent.BOSDateEdit fld_dteACAccountingSheetToDate;
        private BOSSearchResultsGridControl fld_dgcACAccountingSheets;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeComission;
        private IContainer components;
	}
}
