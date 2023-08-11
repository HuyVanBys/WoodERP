using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InvoiceInTransaction.UI
{
	/// <summary>
    /// Summary description for DMINVB100
	/// </summary>
    partial class DMIIT100
	{
        private APInvoiceInTransactionsGridControl fld_dgcAPInvoiceInTransactions;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMIIT100));
            this.fld_dgcAPInvoiceInTransactions = new BOSERP.Modules.InvoiceInTransaction.APInvoiceInTransactionsGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnImportFromExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcAPInvoiceInTransactions
            // 
            this.fld_dgcAPInvoiceInTransactions.AllowDrop = true;
            this.fld_dgcAPInvoiceInTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPInvoiceInTransactions.BOSComment = " ";
            this.fld_dgcAPInvoiceInTransactions.BOSDataMember = " ";
            this.fld_dgcAPInvoiceInTransactions.BOSDataSource = "APInvoiceInTransactions";
            this.fld_dgcAPInvoiceInTransactions.BOSDescription = null;
            this.fld_dgcAPInvoiceInTransactions.BOSError = null;
            this.fld_dgcAPInvoiceInTransactions.BOSFieldGroup = " ";
            this.fld_dgcAPInvoiceInTransactions.BOSFieldRelation = " ";
            this.fld_dgcAPInvoiceInTransactions.BOSGridType = null;
            this.fld_dgcAPInvoiceInTransactions.BOSPrivilege = " ";
            this.fld_dgcAPInvoiceInTransactions.BOSPropertyName = " ";
            this.fld_dgcAPInvoiceInTransactions.CommodityType = "";
            this.fld_dgcAPInvoiceInTransactions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPInvoiceInTransactions.Location = new System.Drawing.Point(3, 0);
            this.fld_dgcAPInvoiceInTransactions.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcAPInvoiceInTransactions.Name = "fld_dgcAPInvoiceInTransactions";
            this.fld_dgcAPInvoiceInTransactions.PrintReport = false;
            this.fld_dgcAPInvoiceInTransactions.Screen = null;
            this.fld_dgcAPInvoiceInTransactions.Size = new System.Drawing.Size(884, 536);
            this.fld_dgcAPInvoiceInTransactions.TabIndex = 4;
            this.fld_dgcAPInvoiceInTransactions.Tag = "DC";
            this.fld_dgcAPInvoiceInTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcAPInvoiceInTransactions;
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
            this.bosPanel1.Controls.Add(this.fld_dgcAPInvoiceInTransactions);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(890, 581);
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
            this.fld_btnSave.Location = new System.Drawing.Point(778, 542);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(100, 27);
            this.fld_btnSave.TabIndex = 10;
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
            this.fld_btnImportFromExcel.Location = new System.Drawing.Point(651, 542);
            this.fld_btnImportFromExcel.Name = "fld_btnImportFromExcel";
            this.fld_btnImportFromExcel.Screen = null;
            this.fld_btnImportFromExcel.Size = new System.Drawing.Size(121, 27);
            this.fld_btnImportFromExcel.TabIndex = 9;
            this.fld_btnImportFromExcel.Tag = "";
            this.fld_btnImportFromExcel.Text = "Import từ excel";
            this.fld_btnImportFromExcel.Click += new System.EventHandler(this.fld_btnImportFromExcel_Click);
            // 
            // DMIIT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(890, 581);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMIIT100.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Name = "DMIIT100";
            this.Text = "Cập nhật hóa đơn phải trả đầu kỳ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInTransactions)).EndInit();
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
