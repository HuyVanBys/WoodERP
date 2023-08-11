using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BonusSales.UI
{
	/// <summary>
	/// Summary description for SMBNS100
	/// </summary>
	partial class SMBNS100
	{
		private BOSSearchResultsGridControl fld_dgcHRBonusSale;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRPayRoll;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSTextBox fld_txtHRBonusSaleNo;
		private BOSComponent.BOSTextBox fld_txtHRBonusSaleName;
        private BOSComponent.BOSDateEdit fld_dteHRBonusSaleDate;


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
            this.fld_dgcHRBonusSale = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRPayRoll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRBonusSaleNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRBonusSaleName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRBonusSaleDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBonusSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRPayRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRBonusSale
            // 
            this.fld_dgcHRBonusSale.AllowDrop = true;
            this.fld_dgcHRBonusSale.BOSComment = string.Empty;
            this.fld_dgcHRBonusSale.BOSDataMember = string.Empty;
            this.fld_dgcHRBonusSale.BOSDataSource = "HRBonusSales";
            this.fld_dgcHRBonusSale.BOSDescription = null;
            this.fld_dgcHRBonusSale.BOSError = null;
            this.fld_dgcHRBonusSale.BOSFieldGroup = string.Empty;
            this.fld_dgcHRBonusSale.BOSFieldRelation = string.Empty;
            this.fld_dgcHRBonusSale.BOSPrivilege = string.Empty;
            this.fld_dgcHRBonusSale.BOSPropertyName = string.Empty;
            this.fld_dgcHRBonusSale.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRBonusSale.Location = new System.Drawing.Point(20, 168);
            this.fld_dgcHRBonusSale.MainView = this.fld_dgvHRPayRoll;
            this.fld_dgcHRBonusSale.Name = "fld_dgcHRBonusSale";
            this.fld_dgcHRBonusSale.Screen = null;
            this.fld_dgcHRBonusSale.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRBonusSale.TabIndex = 4;
            this.fld_dgcHRBonusSale.Tag = "SR";
            this.fld_dgcHRBonusSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRPayRoll});
            // 
            // fld_dgvHRPayRoll
            // 
            this.fld_dgvHRPayRoll.GridControl = this.fld_dgcHRBonusSale;
            this.fld_dgvHRPayRoll.Name = "fld_dgvHRPayRoll";
            this.fld_dgvHRPayRoll.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = string.Empty;
            this.fld_lblLabel.BOSDataMember = string.Empty;
            this.fld_lblLabel.BOSDataSource = string.Empty;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = string.Empty;
            this.fld_lblLabel.BOSFieldRelation = string.Empty;
            this.fld_lblLabel.BOSPrivilege = string.Empty;
            this.fld_lblLabel.BOSPropertyName = string.Empty;
            this.fld_lblLabel.Location = new System.Drawing.Point(60, 19);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = string.Empty;
            this.fld_lblLabel1.BOSDataMember = string.Empty;
            this.fld_lblLabel1.BOSDataSource = string.Empty;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = string.Empty;
            this.fld_lblLabel1.BOSFieldRelation = string.Empty;
            this.fld_lblLabel1.BOSPrivilege = string.Empty;
            this.fld_lblLabel1.BOSPropertyName = string.Empty;
            this.fld_lblLabel1.Location = new System.Drawing.Point(60, 43);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel1.TabIndex = 6;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên chứng từ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = string.Empty;
            this.fld_lblLabel2.BOSDataMember = string.Empty;
            this.fld_lblLabel2.BOSDataSource = string.Empty;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = string.Empty;
            this.fld_lblLabel2.BOSFieldRelation = string.Empty;
            this.fld_lblLabel2.BOSPrivilege = string.Empty;
            this.fld_lblLabel2.BOSPropertyName = string.Empty;
            this.fld_lblLabel2.Location = new System.Drawing.Point(60, 67);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel2.TabIndex = 7;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Tháng";
            // 
            // fld_txtHRBonusSaleNo
            // 
            this.fld_txtHRBonusSaleNo.BOSComment = string.Empty;
            this.fld_txtHRBonusSaleNo.BOSDataMember = "HRBonusSaleNo";
            this.fld_txtHRBonusSaleNo.BOSDataSource = "HRBonusSales";
            this.fld_txtHRBonusSaleNo.BOSDescription = null;
            this.fld_txtHRBonusSaleNo.BOSError = null;
            this.fld_txtHRBonusSaleNo.BOSFieldGroup = string.Empty;
            this.fld_txtHRBonusSaleNo.BOSFieldRelation = string.Empty;
            this.fld_txtHRBonusSaleNo.BOSPrivilege = string.Empty;
            this.fld_txtHRBonusSaleNo.BOSPropertyName = "Text";
            this.fld_txtHRBonusSaleNo.EditValue = string.Empty;
            this.fld_txtHRBonusSaleNo.Location = new System.Drawing.Point(182, 16);
            this.fld_txtHRBonusSaleNo.Name = "fld_txtHRBonusSaleNo";
            this.fld_txtHRBonusSaleNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBonusSaleNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBonusSaleNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBonusSaleNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBonusSaleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBonusSaleNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBonusSaleNo.Screen = null;
            this.fld_txtHRBonusSaleNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRBonusSaleNo.TabIndex = 10;
            this.fld_txtHRBonusSaleNo.Tag = "SC";
            // 
            // fld_txtHRBonusSaleName
            // 
            this.fld_txtHRBonusSaleName.BOSComment = string.Empty;
            this.fld_txtHRBonusSaleName.BOSDataMember = "HRBonusSaleName";
            this.fld_txtHRBonusSaleName.BOSDataSource = "HRBonusSales";
            this.fld_txtHRBonusSaleName.BOSDescription = null;
            this.fld_txtHRBonusSaleName.BOSError = null;
            this.fld_txtHRBonusSaleName.BOSFieldGroup = string.Empty;
            this.fld_txtHRBonusSaleName.BOSFieldRelation = string.Empty;
            this.fld_txtHRBonusSaleName.BOSPrivilege = string.Empty;
            this.fld_txtHRBonusSaleName.BOSPropertyName = "Text";
            this.fld_txtHRBonusSaleName.EditValue = string.Empty;
            this.fld_txtHRBonusSaleName.Location = new System.Drawing.Point(182, 40);
            this.fld_txtHRBonusSaleName.Name = "fld_txtHRBonusSaleName";
            this.fld_txtHRBonusSaleName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBonusSaleName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBonusSaleName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBonusSaleName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBonusSaleName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBonusSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBonusSaleName.Screen = null;
            this.fld_txtHRBonusSaleName.Size = new System.Drawing.Size(335, 20);
            this.fld_txtHRBonusSaleName.TabIndex = 11;
            this.fld_txtHRBonusSaleName.Tag = "SC";
            // 
            // fld_dteHRBonusSaleDate
            // 
            this.fld_dteHRBonusSaleDate.BOSComment = string.Empty;
            this.fld_dteHRBonusSaleDate.BOSDataMember = "HRBonusSaleDate";
            this.fld_dteHRBonusSaleDate.BOSDataSource = "HRBonusSales";
            this.fld_dteHRBonusSaleDate.BOSDescription = null;
            this.fld_dteHRBonusSaleDate.BOSError = null;
            this.fld_dteHRBonusSaleDate.BOSFieldGroup = string.Empty;
            this.fld_dteHRBonusSaleDate.BOSFieldRelation = string.Empty;
            this.fld_dteHRBonusSaleDate.BOSPrivilege = string.Empty;
            this.fld_dteHRBonusSaleDate.BOSPropertyName = "EditValue";
            this.fld_dteHRBonusSaleDate.EditValue = null;
            this.fld_dteHRBonusSaleDate.Location = new System.Drawing.Point(182, 64);
            this.fld_dteHRBonusSaleDate.Name = "fld_dteHRBonusSaleDate";
            this.fld_dteHRBonusSaleDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRBonusSaleDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRBonusSaleDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRBonusSaleDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRBonusSaleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRBonusSaleDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRBonusSaleDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRBonusSaleDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRBonusSaleDate.Screen = null;
            this.fld_dteHRBonusSaleDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRBonusSaleDate.TabIndex = 12;
            this.fld_dteHRBonusSaleDate.Tag = "SC";
            // 
            // SMBNS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRBonusSale);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_txtHRBonusSaleNo);
            this.Controls.Add(this.fld_txtHRBonusSaleName);
            this.Controls.Add(this.fld_dteHRBonusSaleDate);
            this.Name = "SMBNS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteHRBonusSaleDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHRBonusSaleName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRBonusSaleNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRBonusSale, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBonusSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRPayRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
