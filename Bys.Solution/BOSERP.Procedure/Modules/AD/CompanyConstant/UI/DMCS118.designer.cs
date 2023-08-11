using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS118
	/// </summary>
    partial class DMCS118
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
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_btnSaveSalaryEntryType = new BOSComponent.BOSButton(this.components);
            this.fld_dgcSalaryEntryTypes = new BOSERP.Modules.CompanyConstant.SalaryEntryTypeGridControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnSaveSalaryDocumentType = new BOSComponent.BOSButton(this.components);
            this.fld_dgcSalaryDocumentTypes = new BOSERP.Modules.CompanyConstant.SalaryDocumentTypeGridControl();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSalaryEntryTypes)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSalaryDocumentTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(875, 633);
            this.bosPanel1.TabIndex = 334;
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_btnSaveSalaryEntryType);
            this.bosLine2.Controls.Add(this.fld_dgcSalaryEntryTypes);
            this.bosLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(0, 0);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(868, 604);
            this.bosLine2.TabIndex = 65;
            this.bosLine2.TabStop = false;
            // 
            // fld_btnSaveSalaryEntryType
            // 
            this.fld_btnSaveSalaryEntryType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveSalaryEntryType.BOSComment = null;
            this.fld_btnSaveSalaryEntryType.BOSDataMember = null;
            this.fld_btnSaveSalaryEntryType.BOSDataSource = null;
            this.fld_btnSaveSalaryEntryType.BOSDescription = null;
            this.fld_btnSaveSalaryEntryType.BOSError = null;
            this.fld_btnSaveSalaryEntryType.BOSFieldGroup = null;
            this.fld_btnSaveSalaryEntryType.BOSFieldRelation = null;
            this.fld_btnSaveSalaryEntryType.BOSPrivilege = null;
            this.fld_btnSaveSalaryEntryType.BOSPropertyName = null;
            this.fld_btnSaveSalaryEntryType.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveSalaryEntryType.Location = new System.Drawing.Point(786, 565);
            this.fld_btnSaveSalaryEntryType.Name = "fld_btnSaveSalaryEntryType";
            this.fld_btnSaveSalaryEntryType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveSalaryEntryType, true);
            this.fld_btnSaveSalaryEntryType.Size = new System.Drawing.Size(76, 28);
            this.fld_btnSaveSalaryEntryType.TabIndex = 67;
            this.fld_btnSaveSalaryEntryType.Text = "Lưu ";
            this.fld_btnSaveSalaryEntryType.Click += new System.EventHandler(this.fld_btnSaveSalaryEntryType_Click);
            // 
            // fld_dgcSalaryEntryTypes
            // 
            this.fld_dgcSalaryEntryTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSalaryEntryTypes.BOSComment = null;
            this.fld_dgcSalaryEntryTypes.BOSDataMember = null;
            this.fld_dgcSalaryEntryTypes.BOSDataSource = "ACSalaryEntryTypes";
            this.fld_dgcSalaryEntryTypes.BOSDescription = null;
            this.fld_dgcSalaryEntryTypes.BOSError = null;
            this.fld_dgcSalaryEntryTypes.BOSFieldGroup = null;
            this.fld_dgcSalaryEntryTypes.BOSFieldRelation = null;
            this.fld_dgcSalaryEntryTypes.BOSGridType = null;
            this.fld_dgcSalaryEntryTypes.BOSPrivilege = null;
            this.fld_dgcSalaryEntryTypes.BOSPropertyName = null;
            this.fld_dgcSalaryEntryTypes.Location = new System.Drawing.Point(7, 21);
            this.fld_dgcSalaryEntryTypes.MenuManager = this.screenToolbar;
            this.fld_dgcSalaryEntryTypes.Name = "fld_dgcSalaryEntryTypes";
            this.fld_dgcSalaryEntryTypes.PrintReport = false;
            this.fld_dgcSalaryEntryTypes.Screen = null;
            this.fld_dgcSalaryEntryTypes.Size = new System.Drawing.Size(855, 538);
            this.fld_dgcSalaryEntryTypes.TabIndex = 0;
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
            this.bosLine1.Controls.Add(this.fld_btnSaveSalaryDocumentType);
            this.bosLine1.Controls.Add(this.fld_dgcSalaryDocumentTypes);
            this.bosLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(0, 0);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(868, 604);
            this.bosLine1.TabIndex = 64;
            this.bosLine1.TabStop = false;
            // 
            // fld_btnSaveSalaryDocumentType
            // 
            this.fld_btnSaveSalaryDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveSalaryDocumentType.BOSComment = null;
            this.fld_btnSaveSalaryDocumentType.BOSDataMember = null;
            this.fld_btnSaveSalaryDocumentType.BOSDataSource = null;
            this.fld_btnSaveSalaryDocumentType.BOSDescription = null;
            this.fld_btnSaveSalaryDocumentType.BOSError = null;
            this.fld_btnSaveSalaryDocumentType.BOSFieldGroup = null;
            this.fld_btnSaveSalaryDocumentType.BOSFieldRelation = null;
            this.fld_btnSaveSalaryDocumentType.BOSPrivilege = null;
            this.fld_btnSaveSalaryDocumentType.BOSPropertyName = null;
            this.fld_btnSaveSalaryDocumentType.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveSalaryDocumentType.Location = new System.Drawing.Point(786, 565);
            this.fld_btnSaveSalaryDocumentType.Name = "fld_btnSaveSalaryDocumentType";
            this.fld_btnSaveSalaryDocumentType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveSalaryDocumentType, true);
            this.fld_btnSaveSalaryDocumentType.Size = new System.Drawing.Size(76, 28);
            this.fld_btnSaveSalaryDocumentType.TabIndex = 67;
            this.fld_btnSaveSalaryDocumentType.Text = "Lưu ";
            this.fld_btnSaveSalaryDocumentType.Click += new System.EventHandler(this.fld_btnSaveSalaryDocumentType_Click);
            // 
            // fld_dgcSalaryDocumentTypes
            // 
            this.fld_dgcSalaryDocumentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSalaryDocumentTypes.BOSComment = null;
            this.fld_dgcSalaryDocumentTypes.BOSDataMember = null;
            this.fld_dgcSalaryDocumentTypes.BOSDataSource = "ACSalaryDocumentTypes";
            this.fld_dgcSalaryDocumentTypes.BOSDescription = null;
            this.fld_dgcSalaryDocumentTypes.BOSError = null;
            this.fld_dgcSalaryDocumentTypes.BOSFieldGroup = null;
            this.fld_dgcSalaryDocumentTypes.BOSFieldRelation = null;
            this.fld_dgcSalaryDocumentTypes.BOSGridType = null;
            this.fld_dgcSalaryDocumentTypes.BOSPrivilege = null;
            this.fld_dgcSalaryDocumentTypes.BOSPropertyName = null;
            this.fld_dgcSalaryDocumentTypes.Location = new System.Drawing.Point(7, 21);
            this.fld_dgcSalaryDocumentTypes.MenuManager = this.screenToolbar;
            this.fld_dgcSalaryDocumentTypes.Name = "fld_dgcSalaryDocumentTypes";
            this.fld_dgcSalaryDocumentTypes.PrintReport = false;
            this.fld_dgcSalaryDocumentTypes.Screen = null;
            this.fld_dgcSalaryDocumentTypes.Size = new System.Drawing.Size(855, 538);
            this.fld_dgcSalaryDocumentTypes.TabIndex = 0;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(875, 633);
            this.bosTabControl1.TabIndex = 66;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosLine1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(868, 604);
            this.xtraTabPage2.Text = "Cấu hình loại hạch toán";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosLine2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(868, 604);
            this.xtraTabPage3.Text = "Cấu hình loại bút toán";
            // 
            // DMCS118
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(875, 633);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCS118";
            this.Text = "Cấu hình hạch toán lương";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSalaryEntryTypes)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSalaryDocumentTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine1;
        private SalaryDocumentTypeGridControl fld_dgcSalaryDocumentTypes;
        private BOSComponent.BOSButton fld_btnSaveSalaryDocumentType;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton fld_btnSaveSalaryEntryType;
        private SalaryEntryTypeGridControl fld_dgcSalaryEntryTypes;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
	}
}
