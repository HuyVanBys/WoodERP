using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM102
	/// </summary>
	partial class DMHM102
	{
        private APPurchaseOrdersGridControl fld_dgcAPPurchaseOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrders;


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
            this.fld_dgcAPPurchaseOrders = new BOSERP.Modules.Home.APPurchaseOrdersGridControl();
            this.fld_dgvAPPurchaseOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAPPurchaseOrders
            // 
            this.fld_dgcAPPurchaseOrders.AllowDrop = true;
            this.fld_dgcAPPurchaseOrders.BOSComment = "";
            this.fld_dgcAPPurchaseOrders.BOSDataMember = "";
            this.fld_dgcAPPurchaseOrders.BOSDataSource = "APPurchaseOrders";
            this.fld_dgcAPPurchaseOrders.BOSDescription = null;
            this.fld_dgcAPPurchaseOrders.BOSError = null;
            this.fld_dgcAPPurchaseOrders.BOSFieldGroup = "";
            this.fld_dgcAPPurchaseOrders.BOSFieldRelation = "";
            this.fld_dgcAPPurchaseOrders.BOSGridType = null;
            this.fld_dgcAPPurchaseOrders.BOSPrivilege = "";
            this.fld_dgcAPPurchaseOrders.BOSPropertyName = "";
            this.fld_dgcAPPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPPurchaseOrders.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrders.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcAPPurchaseOrders.MainView = this.fld_dgvAPPurchaseOrders;
            this.fld_dgcAPPurchaseOrders.Name = "fld_dgcAPPurchaseOrders";
            this.fld_dgcAPPurchaseOrders.Screen = null;
            this.fld_dgcAPPurchaseOrders.Size = new System.Drawing.Size(862, 567);
            this.fld_dgcAPPurchaseOrders.TabIndex = 4;
            this.fld_dgcAPPurchaseOrders.Tag = "DC";
            this.fld_dgcAPPurchaseOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrders});
            // 
            // fld_dgvAPPurchaseOrders
            // 
            this.fld_dgvAPPurchaseOrders.GridControl = this.fld_dgcAPPurchaseOrders;
            this.fld_dgvAPPurchaseOrders.Name = "fld_dgvAPPurchaseOrders";
            this.fld_dgvAPPurchaseOrders.PaintStyleName = "Office2003";
            // 
            // DMHM102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcAPPurchaseOrders);
            this.Name = "DMHM102";
            this.Text = "Nhắc nhở mua hàng";
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
	}
}
