using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSO101
	/// </summary>
	partial class DMSO103
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
            this.fld_dgcARSaleOrderItemContainers = new BOSERP.Modules.SaleOrder.ARSaleOrderItemContainersGridControl();
            this.fld_dgvARDocumentPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcARSaleOrderItemContainers
            // 
            this.fld_dgcARSaleOrderItemContainers.AllowDrop = true;
            this.fld_dgcARSaleOrderItemContainers.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARSaleOrderItemContainers.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARSaleOrderItemContainers.BOSDataSource = "ARSaleOrderItemContainers";
            this.fld_dgcARSaleOrderItemContainers.BOSDescription = null;
            this.fld_dgcARSaleOrderItemContainers.BOSError = null;
            this.fld_dgcARSaleOrderItemContainers.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARSaleOrderItemContainers.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARSaleOrderItemContainers.BOSGridType = null;
            this.fld_dgcARSaleOrderItemContainers.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARSaleOrderItemContainers.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARSaleOrderItemContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrderItemContainers.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItemContainers.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARSaleOrderItemContainers.MainView = this.fld_dgvARDocumentPayments;
            this.fld_dgcARSaleOrderItemContainers.Name = "fld_dgcARSaleOrderItemContainers";
            this.fld_dgcARSaleOrderItemContainers.PrintReport = false;
            this.fld_dgcARSaleOrderItemContainers.Screen = null;
            this.fld_dgcARSaleOrderItemContainers.Size = new System.Drawing.Size(862, 567);
            this.fld_dgcARSaleOrderItemContainers.TabIndex = 6;
            this.fld_dgcARSaleOrderItemContainers.Tag = "DC";
            this.fld_dgcARSaleOrderItemContainers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARDocumentPayments});
            // 
            // fld_dgvARDocumentPayments
            // 
            this.fld_dgvARDocumentPayments.GridControl = this.fld_dgcARSaleOrderItemContainers;
            this.fld_dgvARDocumentPayments.Name = "fld_dgvARDocumentPayments";
            this.fld_dgvARDocumentPayments.PaintStyleName = "Office2003";
            // 
            // DMSO101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcARSaleOrderItemContainers);
            this.Name = "DMSO103";
            this.Text = "Cont";
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrderItemContainers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private ARSaleOrderItemContainersGridControl fld_dgcARSaleOrderItemContainers;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARDocumentPayments;
	}
}
