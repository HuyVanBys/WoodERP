using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRPayRoll
{
	/// <summary>
	/// Summary description for DSPL101
	/// </summary>
	partial class guiShowWarning
	{
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel10;
		private BOSComponent.BOSLabel fld_lblLabel28;
		private BOSComponent.BOSTextBox fld_txtThucNhan;
		private BOSComponent.BOSTextBox fld_txtMin;
		private BOSComponent.BOSTextBox fld_txtMax;
        private BOSComponent.BOSButton fld_btnOk;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowWarning));
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtThucNhan = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMin = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMax = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnOk = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtThucNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMax.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = string.Empty;
            this.fld_lblLabel8.BOSDataMember = string.Empty;
            this.fld_lblLabel8.BOSDataSource = string.Empty;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = string.Empty;
            this.fld_lblLabel8.BOSFieldRelation = string.Empty;
            this.fld_lblLabel8.BOSPrivilege = string.Empty;
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 27);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(82, 13);
            this.fld_lblLabel8.TabIndex = 4;
            this.fld_lblLabel8.Tag = string.Empty;
            this.fld_lblLabel8.Text = "Lương thực nhận";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = string.Empty;
            this.fld_lblLabel10.BOSDataMember = string.Empty;
            this.fld_lblLabel10.BOSDataSource = string.Empty;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = string.Empty;
            this.fld_lblLabel10.BOSFieldRelation = string.Empty;
            this.fld_lblLabel10.BOSPrivilege = string.Empty;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(12, 72);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel10.TabIndex = 5;
            this.fld_lblLabel10.Tag = string.Empty;
            this.fld_lblLabel10.Text = "Lương tối thiểu";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = string.Empty;
            this.fld_lblLabel28.BOSDataMember = string.Empty;
            this.fld_lblLabel28.BOSDataSource = string.Empty;
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = string.Empty;
            this.fld_lblLabel28.BOSFieldRelation = string.Empty;
            this.fld_lblLabel28.BOSPrivilege = string.Empty;
            this.fld_lblLabel28.BOSPropertyName = null;
            this.fld_lblLabel28.Location = new System.Drawing.Point(12, 113);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel28.TabIndex = 6;
            this.fld_lblLabel28.Tag = string.Empty;
            this.fld_lblLabel28.Text = "Lương tối đa";
            // 
            // fld_txtThucNhan
            // 
            this.fld_txtThucNhan.BOSComment = string.Empty;
            this.fld_txtThucNhan.BOSDataMember = "TextBox";
            this.fld_txtThucNhan.BOSDataSource = string.Empty;
            this.fld_txtThucNhan.BOSDescription = null;
            this.fld_txtThucNhan.BOSError = null;
            this.fld_txtThucNhan.BOSFieldGroup = string.Empty;
            this.fld_txtThucNhan.BOSFieldRelation = string.Empty;
            this.fld_txtThucNhan.BOSPrivilege = string.Empty;
            this.fld_txtThucNhan.BOSPropertyName = null;
            this.fld_txtThucNhan.EditValue = "0";
            this.fld_txtThucNhan.Location = new System.Drawing.Point(130, 24);
            this.fld_txtThucNhan.Name = "fld_txtThucNhan";
            this.fld_txtThucNhan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtThucNhan.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtThucNhan.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtThucNhan.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtThucNhan.Properties.Mask.EditMask = "n2";
            this.fld_txtThucNhan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtThucNhan.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtThucNhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtThucNhan.Screen = null;
            this.fld_txtThucNhan.Size = new System.Drawing.Size(134, 20);
            this.fld_txtThucNhan.TabIndex = 7;
            this.fld_txtThucNhan.Tag = "DC";
            // 
            // fld_txtMin
            // 
            this.fld_txtMin.BOSComment = string.Empty;
            this.fld_txtMin.BOSDataMember = "TextBox";
            this.fld_txtMin.BOSDataSource = string.Empty;
            this.fld_txtMin.BOSDescription = null;
            this.fld_txtMin.BOSError = null;
            this.fld_txtMin.BOSFieldGroup = string.Empty;
            this.fld_txtMin.BOSFieldRelation = string.Empty;
            this.fld_txtMin.BOSPrivilege = string.Empty;
            this.fld_txtMin.BOSPropertyName = null;
            this.fld_txtMin.EditValue = "0";
            this.fld_txtMin.Location = new System.Drawing.Point(130, 69);
            this.fld_txtMin.Name = "fld_txtMin";
            this.fld_txtMin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMin.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMin.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMin.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMin.Properties.Mask.EditMask = "n2";
            this.fld_txtMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMin.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMin.Screen = null;
            this.fld_txtMin.Size = new System.Drawing.Size(134, 20);
            this.fld_txtMin.TabIndex = 8;
            this.fld_txtMin.Tag = "DC";
            // 
            // fld_txtMax
            // 
            this.fld_txtMax.BOSComment = string.Empty;
            this.fld_txtMax.BOSDataMember = "TextBox";
            this.fld_txtMax.BOSDataSource = string.Empty;
            this.fld_txtMax.BOSDescription = null;
            this.fld_txtMax.BOSError = null;
            this.fld_txtMax.BOSFieldGroup = string.Empty;
            this.fld_txtMax.BOSFieldRelation = string.Empty;
            this.fld_txtMax.BOSPrivilege = string.Empty;
            this.fld_txtMax.BOSPropertyName = null;
            this.fld_txtMax.EditValue = "0";
            this.fld_txtMax.Location = new System.Drawing.Point(130, 110);
            this.fld_txtMax.Name = "fld_txtMax";
            this.fld_txtMax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMax.Properties.Mask.EditMask = "n2";
            this.fld_txtMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMax.Screen = null;
            this.fld_txtMax.Size = new System.Drawing.Size(134, 20);
            this.fld_txtMax.TabIndex = 9;
            this.fld_txtMax.Tag = "DC";
            // 
            // fld_btnOk
            // 
            this.fld_btnOk.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnOk.Appearance.Options.UseForeColor = true;
            this.fld_btnOk.BOSComment = string.Empty;
            this.fld_btnOk.BOSDataMember = string.Empty;
            this.fld_btnOk.BOSDataSource = string.Empty;
            this.fld_btnOk.BOSDescription = null;
            this.fld_btnOk.BOSError = null;
            this.fld_btnOk.BOSFieldGroup = string.Empty;
            this.fld_btnOk.BOSFieldRelation = string.Empty;
            this.fld_btnOk.BOSPrivilege = string.Empty;
            this.fld_btnOk.BOSPropertyName = null;
            this.fld_btnOk.Location = new System.Drawing.Point(179, 167);
            this.fld_btnOk.Name = "fld_btnOk";
            this.fld_btnOk.Screen = null;
            this.fld_btnOk.Size = new System.Drawing.Size(85, 27);
            this.fld_btnOk.TabIndex = 10;
            this.fld_btnOk.Tag = string.Empty;
            this.fld_btnOk.Text = "Thoát";
            this.fld_btnOk.Click += new System.EventHandler(this.fld_btnOk_Click);
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Location = new System.Drawing.Point(1, 147);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(282, 10);
            this.bosLine1.TabIndex = 12;
            this.bosLine1.TabStop = false;
            // 
            // guiShowWarning
            // 
            this.AcceptButton = this.fld_btnOk;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(281, 202);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.bosLine1);
            this.Controls.Add(this.fld_lblLabel28);
            this.Controls.Add(this.fld_btnOk);
            this.Controls.Add(this.fld_lblLabel10);
            this.Controls.Add(this.fld_txtThucNhan);
            this.Controls.Add(this.fld_txtMin);
            this.Controls.Add(this.fld_txtMax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiShowWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.guiShowWarning_Load);
            this.Controls.SetChildIndex(this.fld_txtMax, 0);
            this.Controls.SetChildIndex(this.fld_txtMin, 0);
            this.Controls.SetChildIndex(this.fld_txtThucNhan, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel10, 0);
            this.Controls.SetChildIndex(this.fld_btnOk, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel28, 0);
            this.Controls.SetChildIndex(this.bosLine1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtThucNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMax.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine bosLine1;
	}
}
