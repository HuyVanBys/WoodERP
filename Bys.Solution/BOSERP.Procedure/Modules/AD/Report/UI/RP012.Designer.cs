namespace BOSERP.Modules.Report
{
    partial class RP012
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP012));
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICRP012Products = new BOSERP.Modules.Report.ICRP012ProductsGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            this.fld_lblBRBranchName = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICRP012Products)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            this.fld_lblTitle.Location = new System.Drawing.Point(418, 12);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(149, 19);
            this.fld_lblTitle.TabIndex = 0;
            this.fld_lblTitle.Text = "Tồn kho sản phẩm";
            // 
            // fld_dgcICRP012Products
            // 
            this.fld_dgcICRP012Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICRP012Products.BOSComment = null;
            this.fld_dgcICRP012Products.BOSDataMember = null;
            this.fld_dgcICRP012Products.BOSDataSource = "ICProducts";
            this.fld_dgcICRP012Products.BOSDescription = null;
            this.fld_dgcICRP012Products.BOSError = null;
            this.fld_dgcICRP012Products.BOSFieldGroup = null;
            this.fld_dgcICRP012Products.BOSFieldRelation = null;
            this.fld_dgcICRP012Products.BOSGridType = null;
            this.fld_dgcICRP012Products.BOSPrivilege = null;
            this.fld_dgcICRP012Products.BOSPropertyName = null;
            this.fld_dgcICRP012Products.Location = new System.Drawing.Point(22, 74);
            this.fld_dgcICRP012Products.Name = "fld_dgcICRP012Products";
            this.fld_dgcICRP012Products.Screen = null;
            this.fld_dgcICRP012Products.Size = new System.Drawing.Size(1168, 577);
            this.fld_dgcICRP012Products.TabIndex = 1;
            this.fld_dgcICRP012Products.Tag = "DC";
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.Location = new System.Drawing.Point(1115, 670);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 23);
            this.fld_btnClose.TabIndex = 2;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnExcel
            // 
            this.fld_btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExcel.BOSComment = null;
            this.fld_btnExcel.BOSDataMember = null;
            this.fld_btnExcel.BOSDataSource = null;
            this.fld_btnExcel.BOSDescription = null;
            this.fld_btnExcel.BOSError = null;
            this.fld_btnExcel.BOSFieldGroup = null;
            this.fld_btnExcel.BOSFieldRelation = null;
            this.fld_btnExcel.BOSPrivilege = null;
            this.fld_btnExcel.BOSPropertyName = null;
            this.fld_btnExcel.Location = new System.Drawing.Point(1025, 670);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnExcel.TabIndex = 2;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // fld_lblBRBranchName
            // 
            this.fld_lblBRBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblBRBranchName.Appearance.Options.UseFont = true;
            this.fld_lblBRBranchName.BOSComment = null;
            this.fld_lblBRBranchName.BOSDataMember = null;
            this.fld_lblBRBranchName.BOSDataSource = null;
            this.fld_lblBRBranchName.BOSDescription = null;
            this.fld_lblBRBranchName.BOSError = null;
            this.fld_lblBRBranchName.BOSFieldGroup = null;
            this.fld_lblBRBranchName.BOSFieldRelation = null;
            this.fld_lblBRBranchName.BOSPrivilege = null;
            this.fld_lblBRBranchName.BOSPropertyName = null;
            this.fld_lblBRBranchName.Location = new System.Drawing.Point(573, 12);
            this.fld_lblBRBranchName.Name = "fld_lblBRBranchName";
            this.fld_lblBRBranchName.Screen = null;
            this.fld_lblBRBranchName.Size = new System.Drawing.Size(142, 19);
            this.fld_lblBRBranchName.TabIndex = 0;
            this.fld_lblBRBranchName.Text = "Zahara Willtherin";
            // 
            // RP012
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 705);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_dgcICRP012Products);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_lblBRBranchName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP012";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Tồn kho sản phẩm";
            this.Load += new System.EventHandler(this.RP012_Load);
            this.Controls.SetChildIndex(this.fld_lblBRBranchName, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_dgcICRP012Products, 0);
            this.Controls.SetChildIndex(this.fld_btnExcel, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICRP012Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel fld_lblTitle;
        private ICRP012ProductsGridControl fld_dgcICRP012Products;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExcel;
        private BOSComponent.BOSLabel fld_lblBRBranchName;

    }
}