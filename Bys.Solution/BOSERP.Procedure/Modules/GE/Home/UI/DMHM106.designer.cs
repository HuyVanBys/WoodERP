using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM106
	/// </summary>
	partial class DMHM106
	{
        private ICReceiptItemsGridControl fld_dgcICReceiptItems;
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
            this.fld_dgcICReceiptItems = new BOSERP.Modules.Home.ICReceiptItemsGridControl();
            this.fld_dgvAPPurchaseOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICReceiptItems
            // 
            this.fld_dgcICReceiptItems.AllowDrop = true;
            this.fld_dgcICReceiptItems.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcICReceiptItems.BOSDescription = null;
            this.fld_dgcICReceiptItems.BOSError = null;
            this.fld_dgcICReceiptItems.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.BOSGridType = null;
            this.fld_dgcICReceiptItems.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICReceiptItems.MainView = this.fld_dgvAPPurchaseOrders;
            this.fld_dgcICReceiptItems.Name = "fld_dgcICReceiptItems";
            this.fld_dgcICReceiptItems.PrintReport = false;
            this.fld_dgcICReceiptItems.Screen = null;
            this.fld_dgcICReceiptItems.Size = new System.Drawing.Size(862, 567);
            this.fld_dgcICReceiptItems.TabIndex = 4;
            this.fld_dgcICReceiptItems.Tag = "DC";
            this.fld_dgcICReceiptItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrders});
            // 
            // fld_dgvAPPurchaseOrders
            // 
            this.fld_dgvAPPurchaseOrders.GridControl = this.fld_dgcICReceiptItems;
            this.fld_dgvAPPurchaseOrders.Name = "fld_dgvAPPurchaseOrders";
            this.fld_dgvAPPurchaseOrders.PaintStyleName = "Office2003";
            // 
            // DMHM106
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcICReceiptItems);
            this.Name = "DMHM106";
            this.Text = "Theo dõi hàng về";
            this.Controls.SetChildIndex(this.fld_dgcICReceiptItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
	}
}
