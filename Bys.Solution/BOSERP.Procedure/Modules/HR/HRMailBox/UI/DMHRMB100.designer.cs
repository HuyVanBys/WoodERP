using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRMailBox.UI
{
	/// <summary>
	/// Summary description for DMHRMB100
	/// </summary>
	partial class DMHRMB100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRMails = new BOSERP.Modules.HRMailBox.HRMailsInboxGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl100 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_wbsContentMail100 = new System.Windows.Forms.WebBrowser();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl100)).BeginInit();
            this.fld_grcGroupControl100.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl100);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(867, 599);
            this.bosPanel1.TabIndex = 9;
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcHRMails);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(314, 593);
            this.fld_grcGroupControl.TabIndex = 7;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Hộp thư đến";
            // 
            // fld_dgcHRMails
            // 
            this.fld_dgcHRMails.AllowDrop = true;
            this.fld_dgcHRMails.BOSComment = "";
            this.fld_dgcHRMails.BOSDataMember = "";
            this.fld_dgcHRMails.BOSDataSource = "HRMails";
            this.fld_dgcHRMails.BOSDescription = null;
            this.fld_dgcHRMails.BOSError = null;
            this.fld_dgcHRMails.BOSFieldGroup = "";
            this.fld_dgcHRMails.BOSFieldRelation = "";
            this.fld_dgcHRMails.BOSGridType = null;
            this.fld_dgcHRMails.BOSPrivilege = "";
            this.fld_dgcHRMails.BOSPropertyName = "";
            this.fld_dgcHRMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRMails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRMails.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRMails.MainView = this.fld_dgvGridControl1;
            this.fld_dgcHRMails.Name = "fld_dgcHRMails";
            this.fld_dgcHRMails.Screen = null;
            this.fld_dgcHRMails.Size = new System.Drawing.Size(310, 569);
            this.fld_dgcHRMails.TabIndex = 5;
            this.fld_dgcHRMails.Tag = "DC";
            this.fld_dgcHRMails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcHRMails;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl100
            // 
            this.fld_grcGroupControl100.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl100.BOSComment = null;
            this.fld_grcGroupControl100.BOSDataMember = null;
            this.fld_grcGroupControl100.BOSDataSource = null;
            this.fld_grcGroupControl100.BOSDescription = null;
            this.fld_grcGroupControl100.BOSError = null;
            this.fld_grcGroupControl100.BOSFieldGroup = null;
            this.fld_grcGroupControl100.BOSFieldRelation = null;
            this.fld_grcGroupControl100.BOSPrivilege = null;
            this.fld_grcGroupControl100.BOSPropertyName = null;
            this.fld_grcGroupControl100.Controls.Add(this.fld_wbsContentMail100);
            this.fld_grcGroupControl100.Location = new System.Drawing.Point(319, 3);
            this.fld_grcGroupControl100.Name = "fld_grcGroupControl100";
            this.fld_grcGroupControl100.Screen = null;
            this.fld_grcGroupControl100.Size = new System.Drawing.Size(545, 593);
            this.fld_grcGroupControl100.TabIndex = 8;
            this.fld_grcGroupControl100.Text = "Nội dung mail";
            // 
            // fld_wbsContentMail100
            // 
            this.fld_wbsContentMail100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_wbsContentMail100.Location = new System.Drawing.Point(2, 22);
            this.fld_wbsContentMail100.MinimumSize = new System.Drawing.Size(20, 20);
            this.fld_wbsContentMail100.Name = "fld_wbsContentMail100";
            this.fld_wbsContentMail100.Size = new System.Drawing.Size(541, 569);
            this.fld_wbsContentMail100.TabIndex = 7;
            this.fld_wbsContentMail100.Tag = "DC";
            this.fld_wbsContentMail100.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.fld_wbsContentMail100_DocumentCompleted);
            // 
            // DMHRMB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(867, 599);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRMB100";
            this.Text = "Hộp thư đến";
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl100)).EndInit();
            this.fld_grcGroupControl100.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private HRMailsInboxGridControl fld_dgcHRMails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl100;
        private WebBrowser fld_wbsContentMail100;
	}
}
