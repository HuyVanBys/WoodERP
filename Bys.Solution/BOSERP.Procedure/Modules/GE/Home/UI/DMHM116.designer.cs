using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM116
	/// </summary>
	partial class DMHM116
    {
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHomeShipments;
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
            this.homeShipmentsGridControl1 = new BOSERP.Modules.Home.HomeShipmentsGridControl();
            this.fld_dgvHomeShipments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.homeShipmentsGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHomeShipments)).BeginInit();
            this.SuspendLayout();
            // 
            // homeShipmentsGridControl1
            // 
            this.homeShipmentsGridControl1.AllowDrop = true;
            this.homeShipmentsGridControl1.BOSComment = null;
            this.homeShipmentsGridControl1.BOSDataMember = null;
            this.homeShipmentsGridControl1.BOSDataSource = "ICShipments";
            this.homeShipmentsGridControl1.BOSDescription = null;
            this.homeShipmentsGridControl1.BOSError = null;
            this.homeShipmentsGridControl1.BOSFieldGroup = null;
            this.homeShipmentsGridControl1.BOSFieldRelation = null;
            this.homeShipmentsGridControl1.BOSGridType = null;
            this.homeShipmentsGridControl1.BOSPrivilege = null;
            this.homeShipmentsGridControl1.BOSPropertyName = null;
            this.homeShipmentsGridControl1.Location = new System.Drawing.Point(0, 0);
            this.homeShipmentsGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.homeShipmentsGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeShipmentsGridControl1.MenuManager = this.screenToolbar;
            this.homeShipmentsGridControl1.MainView = this.fld_dgvHomeShipments;
            this.homeShipmentsGridControl1.Name = "homeShipmentsGridControl1";
            this.homeShipmentsGridControl1.PrintReport = false;
            this.homeShipmentsGridControl1.Screen = null;
            this.homeShipmentsGridControl1.Size = new System.Drawing.Size(863, 464);
            this.homeShipmentsGridControl1.TabIndex = 6;
            this.homeShipmentsGridControl1.Tag = "DC";
            this.homeShipmentsGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHomeShipments});
            // 
            // fld_dgvHomeShipments
            // 
            this.fld_dgvHomeShipments.GridControl = this.homeShipmentsGridControl1;
            this.fld_dgvHomeShipments.Name = "fld_dgvHomeShipments";
            this.fld_dgvHomeShipments.PaintStyleName = "Office2003";
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
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMHM116
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.homeShipmentsGridControl1);
            this.Name = "DMHM116";
            this.Text = "Xuất kho bán hàng";
            this.Controls.SetChildIndex(this.homeShipmentsGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.homeShipmentsGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHomeShipments)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private HomeShipmentsGridControl homeShipmentsGridControl1;
        private IContainer components;
	}
}
