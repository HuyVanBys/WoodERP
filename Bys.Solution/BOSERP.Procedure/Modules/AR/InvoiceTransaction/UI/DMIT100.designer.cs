using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InvoiceTransaction.UI
{
	/// <summary>
    /// Summary description for DMINVB100
	/// </summary>
    partial class DMIT100
	{
        private ARInvoiceTransactionsGridControl fld_dgcARInvoiceTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMIT100));
            this.fld_dgcARInvoiceTransactions = new BOSERP.Modules.InvoiceTransaction.ARInvoiceTransactionsGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnImportFromExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcARInvoiceTransactions
            // 
            this.fld_dgcARInvoiceTransactions.AllowDrop = true;
            this.fld_dgcARInvoiceTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoiceTransactions.BOSComment = " ";
            this.fld_dgcARInvoiceTransactions.BOSDataMember = " ";
            this.fld_dgcARInvoiceTransactions.BOSDataSource = "ARInvoiceTransactions";
            this.fld_dgcARInvoiceTransactions.BOSDescription = null;
            this.fld_dgcARInvoiceTransactions.BOSError = null;
            this.fld_dgcARInvoiceTransactions.BOSFieldGroup = " ";
            this.fld_dgcARInvoiceTransactions.BOSFieldRelation = " ";
            this.fld_dgcARInvoiceTransactions.BOSGridType = null;
            this.fld_dgcARInvoiceTransactions.BOSPrivilege = " ";
            this.fld_dgcARInvoiceTransactions.BOSPropertyName = " ";
            this.fld_dgcARInvoiceTransactions.CommodityType = null;
            this.fld_dgcARInvoiceTransactions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoiceTransactions.Location = new System.Drawing.Point(3, 0);
            this.fld_dgcARInvoiceTransactions.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcARInvoiceTransactions.Name = "fld_dgcARInvoiceTransactions";
            this.fld_dgcARInvoiceTransactions.PrintReport = false;
            this.fld_dgcARInvoiceTransactions.Screen = null;
            this.fld_dgcARInvoiceTransactions.Size = new System.Drawing.Size(982, 585);
            this.fld_dgcARInvoiceTransactions.TabIndex = 4;
            this.fld_dgcARInvoiceTransactions.Tag = "DC";
            this.fld_dgcARInvoiceTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcARInvoiceTransactions;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Controls.Add(this.fld_btnImportFromExcel);
            this.bosPanel1.Controls.Add(this.fld_dgcARInvoiceTransactions);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(988, 630);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnSave.Appearance.Options.UseForeColor = true;
            this.fld_btnSave.BOSComment = "";
            this.fld_btnSave.BOSDataMember = "";
            this.fld_btnSave.BOSDataSource = "";
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = "";
            this.fld_btnSave.BOSFieldRelation = "";
            this.fld_btnSave.BOSPrivilege = "";
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(863, 591);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(100, 27);
            this.fld_btnSave.TabIndex = 8;
            this.fld_btnSave.Tag = "";
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // fld_btnImportFromExcel
            // 
            this.fld_btnImportFromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnImportFromExcel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnImportFromExcel.Appearance.Options.UseForeColor = true;
            this.fld_btnImportFromExcel.BOSComment = "";
            this.fld_btnImportFromExcel.BOSDataMember = "";
            this.fld_btnImportFromExcel.BOSDataSource = "";
            this.fld_btnImportFromExcel.BOSDescription = null;
            this.fld_btnImportFromExcel.BOSError = null;
            this.fld_btnImportFromExcel.BOSFieldGroup = "";
            this.fld_btnImportFromExcel.BOSFieldRelation = "";
            this.fld_btnImportFromExcel.BOSPrivilege = "";
            this.fld_btnImportFromExcel.BOSPropertyName = null;
            this.fld_btnImportFromExcel.Location = new System.Drawing.Point(736, 591);
            this.fld_btnImportFromExcel.Name = "fld_btnImportFromExcel";
            this.fld_btnImportFromExcel.Screen = null;
            this.fld_btnImportFromExcel.Size = new System.Drawing.Size(121, 27);
            this.fld_btnImportFromExcel.TabIndex = 7;
            this.fld_btnImportFromExcel.Tag = "";
            this.fld_btnImportFromExcel.Text = "Import từ excel";
            this.fld_btnImportFromExcel.Click += new System.EventHandler(this.fld_btnImportFromExcel_Click);
            // 
            // DMIT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(988, 630);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMIT100.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Name = "DMIT100";
            this.Text = "Cập nhật hóa đơn phải thu đầu kỳ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnImportFromExcel;
    }
}
