using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRMailBox.UI
{
	/// <summary>
	/// Summary description for DMHRMB101
	/// </summary>
	partial class DMHRMB101
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private HRMailBoxSentItemsGridControl fld_dgcHRMails100;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;


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
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRMails100 = new BOSERP.Modules.HRMailBox.HRMailBoxSentItemsGridControl();
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl101 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_wbsMailContent = new System.Windows.Forms.WebBrowser();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMails100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl101)).BeginInit();
            this.fld_grcGroupControl101.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRMails100);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 3);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(314, 593);
            this.fld_grcGroupControl1.TabIndex = 4;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Hộp thư đã gửi";
            // 
            // fld_dgcHRMails100
            // 
            this.fld_dgcHRMails100.AllowDrop = true;
            this.fld_dgcHRMails100.BOSComment = "";
            this.fld_dgcHRMails100.BOSDataMember = "";
            this.fld_dgcHRMails100.BOSDataSource = "HRMails";
            this.fld_dgcHRMails100.BOSDescription = null;
            this.fld_dgcHRMails100.BOSError = null;
            this.fld_dgcHRMails100.BOSFieldGroup = "";
            this.fld_dgcHRMails100.BOSFieldRelation = "";
            this.fld_dgcHRMails100.BOSGridType = null;
            this.fld_dgcHRMails100.BOSPrivilege = "";
            this.fld_dgcHRMails100.BOSPropertyName = "";
            this.fld_dgcHRMails100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRMails100.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRMails100.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRMails100.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRMails100.Name = "fld_dgcHRMails100";
            this.fld_dgcHRMails100.Screen = null;
            this.fld_dgcHRMails100.Size = new System.Drawing.Size(310, 569);
            this.fld_dgcHRMails100.TabIndex = 5;
            this.fld_dgcHRMails100.Tag = "DC";
            this.fld_dgcHRMails100.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRMails100;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl101
            // 
            this.fld_grcGroupControl101.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl101.BOSComment = null;
            this.fld_grcGroupControl101.BOSDataMember = null;
            this.fld_grcGroupControl101.BOSDataSource = null;
            this.fld_grcGroupControl101.BOSDescription = null;
            this.fld_grcGroupControl101.BOSError = null;
            this.fld_grcGroupControl101.BOSFieldGroup = null;
            this.fld_grcGroupControl101.BOSFieldRelation = null;
            this.fld_grcGroupControl101.BOSPrivilege = null;
            this.fld_grcGroupControl101.BOSPropertyName = null;
            this.fld_grcGroupControl101.Controls.Add(this.fld_wbsMailContent);
            this.fld_grcGroupControl101.Location = new System.Drawing.Point(314, 3);
            this.fld_grcGroupControl101.Name = "fld_grcGroupControl101";
            this.fld_grcGroupControl101.Screen = null;
            this.fld_grcGroupControl101.Size = new System.Drawing.Size(550, 593);
            this.fld_grcGroupControl101.TabIndex = 6;
            this.fld_grcGroupControl101.Text = "Nội dung mail";
            // 
            // fld_wbsMailContent
            // 
            this.fld_wbsMailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_wbsMailContent.Location = new System.Drawing.Point(2, 22);
            this.fld_wbsMailContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.fld_wbsMailContent.Name = "fld_wbsMailContent";
            this.fld_wbsMailContent.Size = new System.Drawing.Size(546, 569);
            this.fld_wbsMailContent.TabIndex = 7;
            this.fld_wbsMailContent.Tag = "DC";
            this.fld_wbsMailContent.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.fld_wbsMailContent_DocumentCompleted);
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl101);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(867, 599);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMHRMB101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(867, 599);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRMB101";
            this.Text = "Hộp thư đã gửi";
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRMails100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl101)).EndInit();
            this.fld_grcGroupControl101.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl101;
        private WebBrowser fld_wbsMailContent;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
