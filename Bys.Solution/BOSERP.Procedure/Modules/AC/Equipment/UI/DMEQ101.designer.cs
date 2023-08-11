using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Equipment.UI
{
	/// <summary>
	/// Summary description for DMEQ101
	/// </summary>
	partial class DMEQ101
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
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProductIdentifiedEquipments = new BOSERP.Modules.Equipment.ICProductIdentifiedEquipmentGridControl();
            this.fld_dgvAPProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductIdentifiedEquipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPProposalItems)).BeginInit();
            this.bosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcICProductIdentifiedEquipments);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(875, 440);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thông tin định danh";
            // 
            // fld_dgcICProductIdentifiedEquipments
            // 
            this.fld_dgcICProductIdentifiedEquipments.AllowDrop = true;
            this.fld_dgcICProductIdentifiedEquipments.BOSComment = "";
            this.fld_dgcICProductIdentifiedEquipments.BOSDataMember = "";
            this.fld_dgcICProductIdentifiedEquipments.BOSDataSource = "ICProductIdentifiedEquipments";
            this.fld_dgcICProductIdentifiedEquipments.BOSDescription = null;
            this.fld_dgcICProductIdentifiedEquipments.BOSError = null;
            this.fld_dgcICProductIdentifiedEquipments.BOSFieldGroup = "";
            this.fld_dgcICProductIdentifiedEquipments.BOSFieldRelation = "";
            this.fld_dgcICProductIdentifiedEquipments.BOSGridType = null;
            this.fld_dgcICProductIdentifiedEquipments.BOSPrivilege = "";
            this.fld_dgcICProductIdentifiedEquipments.BOSPropertyName = null;
            this.fld_dgcICProductIdentifiedEquipments.CommodityType = "";
            this.fld_dgcICProductIdentifiedEquipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductIdentifiedEquipments.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcICProductIdentifiedEquipments.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcICProductIdentifiedEquipments.MainView = this.fld_dgvAPProposalItems;
            this.fld_dgcICProductIdentifiedEquipments.Name = "fld_dgcICProductIdentifiedEquipments";
            this.fld_dgcICProductIdentifiedEquipments.PrintReport = false;
            this.fld_dgcICProductIdentifiedEquipments.Screen = null;
            this.fld_dgcICProductIdentifiedEquipments.Size = new System.Drawing.Size(871, 418);
            this.fld_dgcICProductIdentifiedEquipments.TabIndex = 2;
            this.fld_dgcICProductIdentifiedEquipments.Tag = "DC";
            this.fld_dgcICProductIdentifiedEquipments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPProposalItems});
            // 
            // fld_dgvAPProposalItems
            // 
            this.fld_dgvAPProposalItems.GridControl = this.fld_dgcICProductIdentifiedEquipments;
            this.fld_dgvAPProposalItems.Name = "fld_dgvAPProposalItems";
            this.fld_dgvAPProposalItems.PaintStyleName = "Office2003";
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosGroupControl2);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(882, 446);
            this.bosPanel2.TabIndex = 7;
            // 
            // DMEQ101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(882, 446);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMEQ101";
            this.Text = "Thông tin định danh";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductIdentifiedEquipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPProposalItems)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ICProductIdentifiedEquipmentGridControl fld_dgcICProductIdentifiedEquipments;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPProposalItems;
        private BOSComponent.BOSPanel bosPanel2;
	}
}
