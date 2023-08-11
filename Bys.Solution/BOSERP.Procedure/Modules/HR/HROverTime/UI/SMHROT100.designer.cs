using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HROverTime.UI
{
	/// <summary>
	/// Summary description for SMHROT100
	/// </summary>
	partial class SMHROT100
	{
		private BOSComponent.BOSTextBox fld_txtHROverTimeNo;
		private BOSComponent.BOSTextBox fld_txtHROverTimeName;
		private BOSComponent.BOSDateEdit fld_dteSearchFromHROverTimeDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToHROverTimeDate;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSSearchResultsGridControl fld_dgcHROverTime;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHROverTime;


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
            this.fld_txtHROverTimeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHROverTimeName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromHROverTimeDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToHROverTimeDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHROverTime = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHROverTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHROverTimeDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHROverTimeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHROverTimeDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHROverTimeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHROverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHROverTime)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHROverTimeNo
            // 
            this.fld_txtHROverTimeNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo.BOSDataMember = "HROverTimeNo";
            this.fld_txtHROverTimeNo.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeNo.BOSDescription = null;
            this.fld_txtHROverTimeNo.BOSError = null;
            this.fld_txtHROverTimeNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo.BOSPropertyName = "Text";
            this.fld_txtHROverTimeNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo.Location = new System.Drawing.Point(157, 63);
            this.fld_txtHROverTimeNo.Name = "fld_txtHROverTimeNo";
            this.fld_txtHROverTimeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHROverTimeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHROverTimeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHROverTimeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHROverTimeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHROverTimeNo.Screen = null;
            this.fld_txtHROverTimeNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHROverTimeNo.TabIndex = 5;
            this.fld_txtHROverTimeNo.Tag = "SC";
            // 
            // fld_txtHROverTimeName
            // 
            this.fld_txtHROverTimeName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName.BOSDataMember = "HROverTimeName";
            this.fld_txtHROverTimeName.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeName.BOSDescription = null;
            this.fld_txtHROverTimeName.BOSError = null;
            this.fld_txtHROverTimeName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName.BOSPropertyName = "Text";
            this.fld_txtHROverTimeName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName.Location = new System.Drawing.Point(157, 87);
            this.fld_txtHROverTimeName.Name = "fld_txtHROverTimeName";
            this.fld_txtHROverTimeName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHROverTimeName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHROverTimeName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHROverTimeName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHROverTimeName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHROverTimeName.Screen = null;
            this.fld_txtHROverTimeName.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHROverTimeName.TabIndex = 6;
            this.fld_txtHROverTimeName.Tag = "SC";
            // 
            // fld_dteSearchFromHROverTimeDate
            // 
            this.fld_dteSearchFromHROverTimeDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHROverTimeDate.BOSDataMember = "HROverTimeDate";
            this.fld_dteSearchFromHROverTimeDate.BOSDataSource = "HROverTimes";
            this.fld_dteSearchFromHROverTimeDate.BOSDescription = null;
            this.fld_dteSearchFromHROverTimeDate.BOSError = null;
            this.fld_dteSearchFromHROverTimeDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHROverTimeDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHROverTimeDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHROverTimeDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHROverTimeDate.EditValue = null;
            this.fld_dteSearchFromHROverTimeDate.Location = new System.Drawing.Point(157, 111);
            this.fld_dteSearchFromHROverTimeDate.Name = "fld_dteSearchFromHROverTimeDate";
            this.fld_dteSearchFromHROverTimeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHROverTimeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHROverTimeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHROverTimeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHROverTimeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHROverTimeDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHROverTimeDate.Screen = null;
            this.fld_dteSearchFromHROverTimeDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromHROverTimeDate.TabIndex = 7;
            this.fld_dteSearchFromHROverTimeDate.Tag = "SC";
            // 
            // fld_dteSearchToHROverTimeDate
            // 
            this.fld_dteSearchToHROverTimeDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHROverTimeDate.BOSDataMember = "HROverTimeDate";
            this.fld_dteSearchToHROverTimeDate.BOSDataSource = "HROverTimes";
            this.fld_dteSearchToHROverTimeDate.BOSDescription = null;
            this.fld_dteSearchToHROverTimeDate.BOSError = null;
            this.fld_dteSearchToHROverTimeDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHROverTimeDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHROverTimeDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHROverTimeDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHROverTimeDate.EditValue = null;
            this.fld_dteSearchToHROverTimeDate.Location = new System.Drawing.Point(157, 135);
            this.fld_dteSearchToHROverTimeDate.Name = "fld_dteSearchToHROverTimeDate";
            this.fld_dteSearchToHROverTimeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHROverTimeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHROverTimeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHROverTimeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHROverTimeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHROverTimeDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHROverTimeDate.Screen = null;
            this.fld_dteSearchToHROverTimeDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToHROverTimeDate.TabIndex = 8;
            this.fld_dteSearchToHROverTimeDate.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.Location = new System.Drawing.Point(54, 66);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel.TabIndex = 9;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã danh sách";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.Location = new System.Drawing.Point(54, 90);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel1.TabIndex = 10;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên danh sách";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(54, 114);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 11;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(54, 138);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 12;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
            // 
            // fld_dgcHROverTime
            // 
            this.fld_dgcHROverTime.AllowDrop = true;
            this.fld_dgcHROverTime.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHROverTime.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHROverTime.BOSDataSource = "HROverTimes";
            this.fld_dgcHROverTime.BOSDescription = null;
            this.fld_dgcHROverTime.BOSError = null;
            this.fld_dgcHROverTime.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHROverTime.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHROverTime.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHROverTime.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHROverTime.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHROverTime.Location = new System.Drawing.Point(10, 178);
            this.fld_dgcHROverTime.MainView = this.fld_dgvHROverTime;
            this.fld_dgcHROverTime.Name = "fld_dgcHROverTime";
            this.fld_dgcHROverTime.Screen = null;
            this.fld_dgcHROverTime.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHROverTime.TabIndex = 13;
            this.fld_dgcHROverTime.Tag = "SR";
            this.fld_dgcHROverTime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHROverTime});
            // 
            // fld_dgvHROverTime
            // 
            this.fld_dgvHROverTime.GridControl = this.fld_dgcHROverTime;
            this.fld_dgvHROverTime.Name = "fld_dgvHROverTime";
            this.fld_dgvHROverTime.PaintStyleName = "Office2003";
            // 
            // SMHROT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_txtHROverTimeNo);
            this.Controls.Add(this.fld_txtHROverTimeName);
            this.Controls.Add(this.fld_dteSearchFromHROverTimeDate);
            this.Controls.Add(this.fld_dteSearchToHROverTimeDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_dgcHROverTime);
            this.Name = "SMHROT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHROverTime, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHROverTimeDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHROverTimeDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHROverTimeName, 0);
            this.Controls.SetChildIndex(this.fld_txtHROverTimeNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHROverTimeDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHROverTimeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHROverTimeDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHROverTimeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHROverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHROverTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
