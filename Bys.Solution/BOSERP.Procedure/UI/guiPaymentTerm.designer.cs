using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP
{
	/// <summary>
	/// Summary description for DSPL101
	/// </summary>
	partial class guiPaymentTerm
	{
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel10;
		private BOSComponent.BOSLabel fld_lblLabel28;
		private BOSComponent.BOSTextBox fld_txtNetDue;
		private BOSComponent.BOSTextBox fld_txtDiscount;
		private BOSComponent.BOSTextBox fld_txtPayWithin;
		private BOSComponent.BOSButton fld_btnOk;
        private BOSComponent.BOSButton fld_btnCancel;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPaymentTerm));
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtNetDue = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtDiscount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPayWithin = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnOk = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtNetDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPayWithin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 27);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel8.TabIndex = 4;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Trả toàn bộ sau";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(12, 72);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel10.TabIndex = 5;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Giảm giá (%)";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = null;
            this.fld_lblLabel28.Location = new System.Drawing.Point(12, 113);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(134, 13);
            this.fld_lblLabel28.TabIndex = 6;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Giảm giá nếu trả trong vòng";
            // 
            // fld_txtNetDue
            // 
            this.fld_txtNetDue.BOSComment = "";
            this.fld_txtNetDue.BOSDataMember = "TextBox";
            this.fld_txtNetDue.BOSDataSource = "";
            this.fld_txtNetDue.BOSDescription = null;
            this.fld_txtNetDue.BOSError = null;
            this.fld_txtNetDue.BOSFieldGroup = "";
            this.fld_txtNetDue.BOSFieldRelation = "";
            this.fld_txtNetDue.BOSPrivilege = "";
            this.fld_txtNetDue.BOSPropertyName = null;
            this.fld_txtNetDue.EditValue = 90;
            this.fld_txtNetDue.Location = new System.Drawing.Point(150, 24);
            this.fld_txtNetDue.Name = "fld_txtNetDue";
            this.fld_txtNetDue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtNetDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtNetDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtNetDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtNetDue.Properties.Mask.EditMask = "n0";
            this.fld_txtNetDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtNetDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtNetDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtNetDue.Screen = null;
            this.fld_txtNetDue.Size = new System.Drawing.Size(134, 20);
            this.fld_txtNetDue.TabIndex = 7;
            this.fld_txtNetDue.Tag = "DC";
            // 
            // fld_txtDiscount
            // 
            this.fld_txtDiscount.BOSComment = "";
            this.fld_txtDiscount.BOSDataMember = "TextBox";
            this.fld_txtDiscount.BOSDataSource = "";
            this.fld_txtDiscount.BOSDescription = null;
            this.fld_txtDiscount.BOSError = null;
            this.fld_txtDiscount.BOSFieldGroup = "";
            this.fld_txtDiscount.BOSFieldRelation = "";
            this.fld_txtDiscount.BOSPrivilege = "";
            this.fld_txtDiscount.BOSPropertyName = null;
            this.fld_txtDiscount.EditValue = 20;
            this.fld_txtDiscount.Location = new System.Drawing.Point(150, 69);
            this.fld_txtDiscount.Name = "fld_txtDiscount";
            this.fld_txtDiscount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDiscount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDiscount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDiscount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDiscount.Properties.Mask.EditMask = "n2";
            this.fld_txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDiscount.Screen = null;
            this.fld_txtDiscount.Size = new System.Drawing.Size(134, 20);
            this.fld_txtDiscount.TabIndex = 8;
            this.fld_txtDiscount.Tag = "DC";
            // 
            // fld_txtPayWithin
            // 
            this.fld_txtPayWithin.BOSComment = "";
            this.fld_txtPayWithin.BOSDataMember = "TextBox";
            this.fld_txtPayWithin.BOSDataSource = "";
            this.fld_txtPayWithin.BOSDescription = null;
            this.fld_txtPayWithin.BOSError = null;
            this.fld_txtPayWithin.BOSFieldGroup = "";
            this.fld_txtPayWithin.BOSFieldRelation = "";
            this.fld_txtPayWithin.BOSPrivilege = "";
            this.fld_txtPayWithin.BOSPropertyName = null;
            this.fld_txtPayWithin.EditValue = 30;
            this.fld_txtPayWithin.Location = new System.Drawing.Point(150, 110);
            this.fld_txtPayWithin.Name = "fld_txtPayWithin";
            this.fld_txtPayWithin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPayWithin.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPayWithin.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPayWithin.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPayWithin.Properties.Mask.EditMask = "n0";
            this.fld_txtPayWithin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtPayWithin.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPayWithin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPayWithin.Screen = null;
            this.fld_txtPayWithin.Size = new System.Drawing.Size(134, 20);
            this.fld_txtPayWithin.TabIndex = 9;
            this.fld_txtPayWithin.Tag = "DC";
            // 
            // fld_btnOk
            // 
            this.fld_btnOk.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnOk.Appearance.Options.UseForeColor = true;
            this.fld_btnOk.BOSComment = "";
            this.fld_btnOk.BOSDataMember = "";
            this.fld_btnOk.BOSDataSource = "";
            this.fld_btnOk.BOSDescription = null;
            this.fld_btnOk.BOSError = null;
            this.fld_btnOk.BOSFieldGroup = "";
            this.fld_btnOk.BOSFieldRelation = "";
            this.fld_btnOk.BOSPrivilege = "";
            this.fld_btnOk.BOSPropertyName = null;
            this.fld_btnOk.Location = new System.Drawing.Point(179, 187);
            this.fld_btnOk.Name = "fld_btnOk";
            this.fld_btnOk.Screen = null;
            this.fld_btnOk.Size = new System.Drawing.Size(85, 27);
            this.fld_btnOk.TabIndex = 10;
            this.fld_btnOk.Tag = "";
            this.fld_btnOk.Text = "Đồng ý";
            this.fld_btnOk.Click += new System.EventHandler(this.fld_btnOk_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCancel.Appearance.Options.UseForeColor = true;
            this.fld_btnCancel.BOSComment = "";
            this.fld_btnCancel.BOSDataMember = "";
            this.fld_btnCancel.BOSDataSource = "";
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = "";
            this.fld_btnCancel.BOSFieldRelation = "";
            this.fld_btnCancel.BOSPrivilege = "";
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(270, 187);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(85, 27);
            this.fld_btnCancel.TabIndex = 11;
            this.fld_btnCancel.Tag = "";
            this.fld_btnCancel.Text = "Hủy";
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
            this.bosLine1.Location = new System.Drawing.Point(2, 167);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(354, 10);
            this.bosLine1.TabIndex = 12;
            this.bosLine1.TabStop = false;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(290, 27);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(25, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Ngày";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(290, 113);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(25, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Ngày";
            // 
            // guiPaymentTerm
            // 
            this.AcceptButton = this.fld_btnOk;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 223);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLine1);
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.fld_lblLabel10);
            this.Controls.Add(this.fld_lblLabel28);
            this.Controls.Add(this.fld_txtPayWithin);
            this.Controls.Add(this.fld_btnOk);
            this.Controls.Add(this.fld_txtNetDue);
            this.Controls.Add(this.fld_txtDiscount);
            this.Controls.Add(this.fld_btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiPaymentTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều khoản thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtNetDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPayWithin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
	}
}
