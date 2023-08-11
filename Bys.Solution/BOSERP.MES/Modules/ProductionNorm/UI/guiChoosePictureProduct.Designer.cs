namespace BOSERP.Modules.ProductionNorm.UI
{
    partial class guiChoosePictureProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChoosePictureProduct));
            this.fld_dgcPictureProduct = new BOSERP.Modules.ProductionNorm.PictureProductsGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.iCProductsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fld_btnSetDefualt = new BOSComponent.BOSButton(this.components);
            this.fld_cbxFileExtension = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPictureProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCProductsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcPictureProduct
            // 
            this.fld_dgcPictureProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPictureProduct.BOSComment = null;
            this.fld_dgcPictureProduct.BOSDataMember = null;
            this.fld_dgcPictureProduct.BOSDataSource = "ICProducts";
            this.fld_dgcPictureProduct.BOSDescription = null;
            this.fld_dgcPictureProduct.BOSError = null;
            this.fld_dgcPictureProduct.BOSFieldGroup = null;
            this.fld_dgcPictureProduct.BOSFieldRelation = null;
            this.fld_dgcPictureProduct.BOSGridType = null;
            this.fld_dgcPictureProduct.BOSPrivilege = null;
            this.fld_dgcPictureProduct.BOSPropertyName = null;
            this.fld_dgcPictureProduct.Location = new System.Drawing.Point(1, 12);
            this.fld_dgcPictureProduct.MenuManager = this.screenToolbar;
            this.fld_dgcPictureProduct.Name = "fld_dgcPictureProduct";
            this.fld_dgcPictureProduct.PrintReport = false;
            this.fld_dgcPictureProduct.Screen = null;
            this.fld_dgcPictureProduct.Size = new System.Drawing.Size(805, 656);
            this.fld_dgcPictureProduct.TabIndex = 1;
            this.fld_dgcPictureProduct.Tag = "DC";
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(977, 634);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(109, 34);
            this.fld_btnChoose.TabIndex = 2;
            this.fld_btnChoose.Text = "Thoát";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // iCProductsInfoBindingSource
            // 
            this.iCProductsInfoBindingSource.DataSource = typeof(BOSERP.ICProductsInfo);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(812, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 314);
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // fld_btnSetDefualt
            // 
            this.fld_btnSetDefualt.BOSComment = null;
            this.fld_btnSetDefualt.BOSDataMember = null;
            this.fld_btnSetDefualt.BOSDataSource = null;
            this.fld_btnSetDefualt.BOSDescription = null;
            this.fld_btnSetDefualt.BOSError = null;
            this.fld_btnSetDefualt.BOSFieldGroup = null;
            this.fld_btnSetDefualt.BOSFieldRelation = null;
            this.fld_btnSetDefualt.BOSPrivilege = null;
            this.fld_btnSetDefualt.BOSPropertyName = null;
            this.fld_btnSetDefualt.Location = new System.Drawing.Point(942, 51);
            this.fld_btnSetDefualt.Name = "fld_btnSetDefualt";
            this.fld_btnSetDefualt.Screen = null;
            this.fld_btnSetDefualt.Size = new System.Drawing.Size(144, 34);
            this.fld_btnSetDefualt.TabIndex = 2;
            this.fld_btnSetDefualt.Text = "Mặc định ảnh cho chi tiết.";
            this.fld_btnSetDefualt.Click += new System.EventHandler(this.fld_btnSetDefualt_Click);
            // 
            // fld_cbxFileExtension
            // 
            this.fld_cbxFileExtension.FormattingEnabled = true;
            this.fld_cbxFileExtension.Items.AddRange(new object[] {
            "jpg",
            "pnj"});
            this.fld_cbxFileExtension.Location = new System.Drawing.Point(942, 24);
            this.fld_cbxFileExtension.Name = "fld_cbxFileExtension";
            this.fld_cbxFileExtension.Size = new System.Drawing.Size(144, 21);
            this.fld_cbxFileExtension.TabIndex = 107;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(880, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 108;
            this.labelControl1.Text = "Loại file";
            // 
            // guiChoosePictureProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 678);
            this.ControlBox = true;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_cbxFileExtension);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fld_dgcPictureProduct);
            this.Controls.Add(this.fld_btnSetDefualt);
            this.Controls.Add(this.fld_btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChoosePictureProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Chọn ảnh";
            this.Load += new System.EventHandler(this.guiChoosePictureProduct_Load);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_btnSetDefualt, 0);
            this.Controls.SetChildIndex(this.fld_dgcPictureProduct, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.fld_cbxFileExtension, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPictureProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCProductsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnChoose;
        private PictureProductsGridControl fld_dgcPictureProduct;
        private System.Windows.Forms.BindingSource iCProductsInfoBindingSource;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BOSComponent.BOSButton fld_btnSetDefualt;
        private System.Windows.Forms.ComboBox fld_cbxFileExtension;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}