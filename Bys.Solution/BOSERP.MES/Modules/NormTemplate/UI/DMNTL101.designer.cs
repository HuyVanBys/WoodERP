using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.NormTemplate.UI
{
	/// <summary>
    /// Summary description for DMNTL101
	/// </summary>
    partial class DMNTL101
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_dgcMMNormTemplateProducts = new BOSERP.Modules.NormTemplate.MMNormTemplateProductsGridControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.xtraScrollableControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMNormTemplateProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(843, 562);
            this.xtraScrollableControl1.TabIndex = 0;
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
            this.bosPanel1.Controls.Add(this.fld_btnAddProduct);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(843, 562);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.BOSComment = null;
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = null;
            this.fld_btnAddProduct.BOSFieldRelation = null;
            this.fld_btnAddProduct.BOSPrivilege = null;
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(12, 10);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(124, 25);
            this.fld_btnAddProduct.TabIndex = 8;
            this.fld_btnAddProduct.Tag = "DC";
            this.fld_btnAddProduct.Text = "Thêm chi tiết";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAdd_Click);
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
            this.bosGroupControl2.Controls.Add(this.xtraScrollableControl2);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 41);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(837, 518);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Chi tiết hàng hóa áp dụng";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.fld_dgcMMNormTemplateProducts);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(2, 22);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(833, 494);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // fld_dgcMMNormTemplateProducts
            // 
            this.fld_dgcMMNormTemplateProducts.BOSComment = null;
            this.fld_dgcMMNormTemplateProducts.BOSDataMember = null;
            this.fld_dgcMMNormTemplateProducts.BOSDataSource = "MMNormTemplateProducts";
            this.fld_dgcMMNormTemplateProducts.BOSDescription = null;
            this.fld_dgcMMNormTemplateProducts.BOSError = null;
            this.fld_dgcMMNormTemplateProducts.BOSFieldGroup = null;
            this.fld_dgcMMNormTemplateProducts.BOSFieldRelation = null;
            this.fld_dgcMMNormTemplateProducts.BOSGridType = null;
            this.fld_dgcMMNormTemplateProducts.BOSPrivilege = null;
            this.fld_dgcMMNormTemplateProducts.BOSPropertyName = null;
            this.fld_dgcMMNormTemplateProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMNormTemplateProducts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMNormTemplateProducts.MenuManager = this.screenToolbar;
            this.fld_dgcMMNormTemplateProducts.Name = "fld_dgcMMNormTemplateProducts";
            this.fld_dgcMMNormTemplateProducts.PrintReport = false;
            this.fld_dgcMMNormTemplateProducts.Screen = null;
            this.fld_dgcMMNormTemplateProducts.Size = new System.Drawing.Size(833, 494);
            this.fld_dgcMMNormTemplateProducts.TabIndex = 0;
            this.fld_dgcMMNormTemplateProducts.Tag = "DC";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(157, 10);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(114, 25);
            this.fld_btnSave.TabIndex = 8;
            this.fld_btnSave.Tag = "DC";
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // DMNTL101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(843, 562);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMNTL101";
            this.Tag = "DM";
            this.Text = "Danh sách hàng hóa";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMNormTemplateProducts)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private MMNormTemplateProductsGridControl fld_dgcMMNormTemplateProducts;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSButton fld_btnSave;
	}
}
