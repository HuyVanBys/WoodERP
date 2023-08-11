using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ImportData
{
	/// <summary>
	/// Summary description for DMID101
	/// </summary>
	partial class guiImportAccounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiImportAccounting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.GridControl = new System.Windows.Forms.Panel();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.panel1.SuspendLayout();
            this.bosLine4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_btnCancel);
            this.panel1.Controls.Add(this.bosLine4);
            this.panel1.Controls.Add(this.fld_btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 610);
            this.panel1.TabIndex = 0;
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_btnCancel.BOSPropertyName = "";
            this.fld_btnCancel.Location = new System.Drawing.Point(852, 564);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(86, 34);
            this.fld_btnCancel.TabIndex = 7;
            this.fld_btnCancel.Tag = "";
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.GridControl);
            this.bosLine4.Location = new System.Drawing.Point(3, 3);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(947, 555);
            this.bosLine4.TabIndex = 1;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Kiểm tra dữ liệu";
            // 
            // GridControl
            // 
            this.GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl.Location = new System.Drawing.Point(3, 17);
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(941, 535);
            this.GridControl.TabIndex = 1;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnSave.Appearance.Options.UseForeColor = true;
            this.fld_btnSave.BOSComment = "";
            this.fld_btnSave.BOSDataMember = "";
            this.fld_btnSave.BOSDataSource = "";
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = "";
            this.fld_btnSave.BOSFieldRelation = "";
            this.fld_btnSave.BOSPrivilege = "";
            this.fld_btnSave.BOSPropertyName = "";
            this.fld_btnSave.Location = new System.Drawing.Point(725, 564);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(121, 34);
            this.fld_btnSave.TabIndex = 6;
            this.fld_btnSave.Tag = "";
            this.fld_btnSave.Text = "Lưu dữ liệu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiImportAccounting
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiImportAccounting.IconOptions.Icon")));
            this.Name = "guiImportAccounting";
            this.Text = "Import dữ liệu Kế toán";
            this.Load += new System.EventHandler(this.guiImportAccounting_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private Panel panel1;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSLine bosLine4;
        private Panel GridControl;
        private BOSComponent.BOSButton fld_btnCancel;
    }
}
