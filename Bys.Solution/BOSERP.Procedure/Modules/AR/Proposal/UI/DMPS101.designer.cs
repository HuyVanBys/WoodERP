using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Proposal.UI
{
	/// <summary>
	/// Summary description for DMPS100
	/// </summary>
	partial class DMPS101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPS101));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_trlTemplateItemsTreeListControl = new BOSERP.Modules.Proposal.ProposalTemplateItemsTreeListControl();
            this.fld_btnAddProductSection = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProductWork = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlTemplateItemsTreeListControl)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_trlTemplateItemsTreeListControl);
            this.bosPanel1.Controls.Add(this.fld_btnAddProductSection);
            this.bosPanel1.Controls.Add(this.fld_btnAddProductWork);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1199, 707);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_trlTemplateItemsTreeListControl
            // 
            this.fld_trlTemplateItemsTreeListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlTemplateItemsTreeListControl.BOSComment = null;
            this.fld_trlTemplateItemsTreeListControl.BOSDataMember = null;
            this.fld_trlTemplateItemsTreeListControl.BOSDataSource = "ARProposalTemplateItems";
            this.fld_trlTemplateItemsTreeListControl.BOSDescription = null;
            this.fld_trlTemplateItemsTreeListControl.BOSDisplayOption = false;
            this.fld_trlTemplateItemsTreeListControl.BOSDisplayRoot = true;
            this.fld_trlTemplateItemsTreeListControl.BOSError = null;
            this.fld_trlTemplateItemsTreeListControl.BOSFieldGroup = null;
            this.fld_trlTemplateItemsTreeListControl.BOSFieldRelation = null;
            this.fld_trlTemplateItemsTreeListControl.BOSPrivilege = null;
            this.fld_trlTemplateItemsTreeListControl.BOSPropertyName = null;
            this.fld_trlTemplateItemsTreeListControl.Location = new System.Drawing.Point(12, 45);
            this.fld_trlTemplateItemsTreeListControl.Name = "fld_trlTemplateItemsTreeListControl";
            this.fld_trlTemplateItemsTreeListControl.Screen = null;
            this.fld_trlTemplateItemsTreeListControl.Size = new System.Drawing.Size(1175, 650);
            this.fld_trlTemplateItemsTreeListControl.TabIndex = 5;
            // 
            // fld_btnAddProductSection
            // 
            this.fld_btnAddProductSection.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductSection.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductSection.BOSComment = "";
            this.fld_btnAddProductSection.BOSDataMember = null;
            this.fld_btnAddProductSection.BOSDataSource = null;
            this.fld_btnAddProductSection.BOSDescription = null;
            this.fld_btnAddProductSection.BOSError = null;
            this.fld_btnAddProductSection.BOSFieldGroup = "";
            this.fld_btnAddProductSection.BOSFieldRelation = "";
            this.fld_btnAddProductSection.BOSPrivilege = "";
            this.fld_btnAddProductSection.BOSPropertyName = null;
            this.fld_btnAddProductSection.Location = new System.Drawing.Point(12, 12);
            this.fld_btnAddProductSection.Name = "fld_btnAddProductSection";
            this.fld_btnAddProductSection.Screen = null;
            this.fld_btnAddProductSection.Size = new System.Drawing.Size(115, 26);
            this.fld_btnAddProductSection.TabIndex = 3;
            this.fld_btnAddProductSection.Tag = "AddProductSectionButtonName";
            this.fld_btnAddProductSection.Text = "Thêm hạng mục";
            this.fld_btnAddProductSection.Click += new System.EventHandler(this.Fld_btnAddProductSection_Click);
            // 
            // fld_btnAddProductWork
            // 
            this.fld_btnAddProductWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWork.BOSComment = "";
            this.fld_btnAddProductWork.BOSDataMember = null;
            this.fld_btnAddProductWork.BOSDataSource = null;
            this.fld_btnAddProductWork.BOSDescription = null;
            this.fld_btnAddProductWork.BOSError = null;
            this.fld_btnAddProductWork.BOSFieldGroup = "";
            this.fld_btnAddProductWork.BOSFieldRelation = "";
            this.fld_btnAddProductWork.BOSPrivilege = "";
            this.fld_btnAddProductWork.BOSPropertyName = null;
            this.fld_btnAddProductWork.Location = new System.Drawing.Point(133, 12);
            this.fld_btnAddProductWork.Name = "fld_btnAddProductWork";
            this.fld_btnAddProductWork.Screen = null;
            this.fld_btnAddProductWork.Size = new System.Drawing.Size(118, 27);
            this.fld_btnAddProductWork.TabIndex = 4;
            this.fld_btnAddProductWork.Tag = "AddProductWorkButtonName";
            this.fld_btnAddProductWork.Text = "Thêm công việc";
            this.fld_btnAddProductWork.Click += new System.EventHandler(this.Fld_btnAddProductWork_Click);
            // 
            // DMPS101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1199, 707);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPS101.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DMPS101";
            this.Text = "Bảng định mức mẫu";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlTemplateItemsTreeListControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnAddProductSection;
        private BOSComponent.BOSButton fld_btnAddProductWork;
        private Proposal.ProposalTemplateItemsTreeListControl fld_trlTemplateItemsTreeListControl;
    }
}
