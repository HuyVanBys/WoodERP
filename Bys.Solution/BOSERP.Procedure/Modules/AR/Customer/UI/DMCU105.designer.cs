using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Customer.UI
{
	/// <summary>
	/// Summary description for DMCU104
	/// </summary>
    partial class DMCU105
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
            this.fld_dgvARDocumentPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcARCustomerInfoContacts = new BOSERP.Modules.Customer.ARCustomerInfoContactsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerInfoContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvARDocumentPayments
            // 
            this.fld_dgvARDocumentPayments.Name = "fld_dgvARDocumentPayments";
            // 
            // fld_dgcARCustomerInfoContacts
            // 
            this.fld_dgcARCustomerInfoContacts.BOSComment = null;
            this.fld_dgcARCustomerInfoContacts.BOSDataMember = null;
            this.fld_dgcARCustomerInfoContacts.BOSDataSource = "ARCustomerInfoContacts";
            this.fld_dgcARCustomerInfoContacts.BOSDescription = null;
            this.fld_dgcARCustomerInfoContacts.BOSError = null;
            this.fld_dgcARCustomerInfoContacts.BOSFieldGroup = null;
            this.fld_dgcARCustomerInfoContacts.BOSFieldRelation = null;
            this.fld_dgcARCustomerInfoContacts.BOSGridType = null;
            this.fld_dgcARCustomerInfoContacts.BOSPrivilege = null;
            this.fld_dgcARCustomerInfoContacts.BOSPropertyName = null;
            this.fld_dgcARCustomerInfoContacts.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARCustomerInfoContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARCustomerInfoContacts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARCustomerInfoContacts.MenuManager = this.screenToolbar;
            this.fld_dgcARCustomerInfoContacts.Name = "fld_dgcARCustomerInfoContacts";
            this.fld_dgcARCustomerInfoContacts.PrintReport = false;
            this.fld_dgcARCustomerInfoContacts.Screen = null;
            this.fld_dgcARCustomerInfoContacts.Size = new System.Drawing.Size(862, 567);
            this.fld_dgcARCustomerInfoContacts.TabIndex = 17;
            // 
            // DMCU105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcARCustomerInfoContacts);
            this.Name = "DMCU105";
            this.Text = "Thông tin người giới thiệu";
            this.Controls.SetChildIndex(this.fld_dgcARCustomerInfoContacts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerInfoContacts)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARDocumentPayments;
        private ARCustomerInfoContactsGridControl fld_dgcARCustomerInfoContacts;
	}
}
