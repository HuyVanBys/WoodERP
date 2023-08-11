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
	partial class DMPS102
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPS102));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcARProposalAreasGridControl = new BOSERP.Modules.Proposal.ProposalAreasGridControl();
            this.fld_dgvARProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalAreasGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProposalItems)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_dgcARProposalAreasGridControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1211, 721);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_dgcARProposalAreasGridControl
            // 
            this.fld_dgcARProposalAreasGridControl.AllowDrop = true;
            this.fld_dgcARProposalAreasGridControl.BOSComment = "";
            this.fld_dgcARProposalAreasGridControl.BOSDataMember = "";
            this.fld_dgcARProposalAreasGridControl.BOSDataSource = "ARProposalAreas";
            this.fld_dgcARProposalAreasGridControl.BOSDescription = null;
            this.fld_dgcARProposalAreasGridControl.BOSError = null;
            this.fld_dgcARProposalAreasGridControl.BOSFieldGroup = "";
            this.fld_dgcARProposalAreasGridControl.BOSFieldRelation = "";
            this.fld_dgcARProposalAreasGridControl.BOSGridType = null;
            this.fld_dgcARProposalAreasGridControl.BOSPrivilege = "";
            this.fld_dgcARProposalAreasGridControl.BOSPropertyName = null;
            this.fld_dgcARProposalAreasGridControl.CommodityType = "";
            this.fld_dgcARProposalAreasGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARProposalAreasGridControl.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcARProposalAreasGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARProposalAreasGridControl.MainView = this.fld_dgvARProposalItems;
            this.fld_dgcARProposalAreasGridControl.Name = "fld_dgcARProposalAreasGridControl";
            this.fld_dgcARProposalAreasGridControl.PrintReport = false;
            this.fld_dgcARProposalAreasGridControl.Screen = null;
            this.fld_dgcARProposalAreasGridControl.Size = new System.Drawing.Size(1211, 721);
            this.fld_dgcARProposalAreasGridControl.TabIndex = 60;
            this.fld_dgcARProposalAreasGridControl.Tag = "DC";
            this.fld_dgcARProposalAreasGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARProposalItems});
            // 
            // fld_dgvARProposalItems
            // 
            this.fld_dgvARProposalItems.GridControl = this.fld_dgcARProposalAreasGridControl;
            this.fld_dgvARProposalItems.Name = "fld_dgvARProposalItems";
            this.fld_dgvARProposalItems.PaintStyleName = "Office2003";
            // 
            // DMPS102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1211, 721);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPS102.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DMPS102";
            this.Text = "Bảng giá tạm tính";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProposalAreasGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProposalItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private ProposalAreasGridControl fld_dgcARProposalAreasGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARProposalItems;
    }
}
