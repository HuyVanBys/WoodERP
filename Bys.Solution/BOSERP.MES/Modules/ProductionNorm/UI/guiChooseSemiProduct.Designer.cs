namespace BOSERP.Modules.ProductionNorm.UI
{
    partial class guiChooseSemiProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseSemiProduct));
            this.fld_dgcSemiProduct = new BOSERP.Modules.ProductionNorm.SemiProductsGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddNewItem = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcSemiProduct
            // 
            this.fld_dgcSemiProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSemiProduct.BOSComment = null;
            this.fld_dgcSemiProduct.BOSDataMember = null;
            this.fld_dgcSemiProduct.BOSDataSource = "ICProducts";
            this.fld_dgcSemiProduct.BOSDescription = null;
            this.fld_dgcSemiProduct.BOSError = null;
            this.fld_dgcSemiProduct.BOSFieldGroup = null;
            this.fld_dgcSemiProduct.BOSFieldRelation = null;
            this.fld_dgcSemiProduct.BOSGridType = null;
            this.fld_dgcSemiProduct.BOSPrivilege = null;
            this.fld_dgcSemiProduct.BOSPropertyName = null;
            this.fld_dgcSemiProduct.Location = new System.Drawing.Point(1, 1);
            this.fld_dgcSemiProduct.MenuManager = this.screenToolbar;
            this.fld_dgcSemiProduct.Name = "fld_dgcSemiProduct";
            this.fld_dgcSemiProduct.PrintReport = false;
            this.fld_dgcSemiProduct.Screen = null;
            this.fld_dgcSemiProduct.Size = new System.Drawing.Size(860, 471);
            this.fld_dgcSemiProduct.TabIndex = 1;
            this.fld_dgcSemiProduct.Tag = "DC";
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(706, 478);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 2;
            this.fld_btnChoose.Text = "Chọn";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(787, 478);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            // 
            // fld_btnAddNewItem
            // 
            this.fld_btnAddNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddNewItem.BOSComment = null;
            this.fld_btnAddNewItem.BOSDataMember = null;
            this.fld_btnAddNewItem.BOSDataSource = null;
            this.fld_btnAddNewItem.BOSDescription = null;
            this.fld_btnAddNewItem.BOSError = null;
            this.fld_btnAddNewItem.BOSFieldGroup = null;
            this.fld_btnAddNewItem.BOSFieldRelation = null;
            this.fld_btnAddNewItem.BOSPrivilege = null;
            this.fld_btnAddNewItem.BOSPropertyName = null;
            this.fld_btnAddNewItem.Location = new System.Drawing.Point(612, 478);
            this.fld_btnAddNewItem.Name = "fld_btnAddNewItem";
            this.fld_btnAddNewItem.Screen = null;
            this.fld_btnAddNewItem.Size = new System.Drawing.Size(88, 27);
            this.fld_btnAddNewItem.TabIndex = 6;
            this.fld_btnAddNewItem.Text = "Thêm mới";
            this.fld_btnAddNewItem.Click += new System.EventHandler(this.fld_btnAddNewItem_Click);
            // 
            // guiChooseSemiProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnAddNewItem);
            this.Controls.Add(this.fld_dgcSemiProduct);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseSemiProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Chọn Cụm / Chi tiết";
            this.Load += new System.EventHandler(this.guiChooseSemiProduct_Load);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcSemiProduct, 0);
            this.Controls.SetChildIndex(this.fld_btnAddNewItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnChoose;
        private SemiProductsGridControl fld_dgcSemiProduct;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnAddNewItem;
    }
}