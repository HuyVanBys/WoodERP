namespace BOSERP.Modules.Template
{
    partial class guiAddProduct<T>
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
            this.fld_btnAddNewProductSectionType = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductsGridControl = new BOSERP.Modules.Template.ProductsGridControl();
            this.fld_txtFind = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnAddNewProductSectionType
            // 
            this.fld_btnAddNewProductSectionType.AllowFocus = false;
            this.fld_btnAddNewProductSectionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddNewProductSectionType.BOSComment = null;
            this.fld_btnAddNewProductSectionType.BOSDataMember = null;
            this.fld_btnAddNewProductSectionType.BOSDataSource = null;
            this.fld_btnAddNewProductSectionType.BOSDescription = null;
            this.fld_btnAddNewProductSectionType.BOSError = null;
            this.fld_btnAddNewProductSectionType.BOSFieldGroup = null;
            this.fld_btnAddNewProductSectionType.BOSFieldRelation = null;
            this.fld_btnAddNewProductSectionType.BOSPrivilege = null;
            this.fld_btnAddNewProductSectionType.BOSPropertyName = null;
            this.fld_btnAddNewProductSectionType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnAddNewProductSectionType.Location = new System.Drawing.Point(811, 27);
            this.fld_btnAddNewProductSectionType.Name = "fld_btnAddNewProductSectionType";
            this.fld_btnAddNewProductSectionType.Screen = null;
            this.fld_btnAddNewProductSectionType.Size = new System.Drawing.Size(115, 26);
            this.fld_btnAddNewProductSectionType.TabIndex = 1;
            this.fld_btnAddNewProductSectionType.Text = "Thêm mới";
            this.fld_btnAddNewProductSectionType.Click += new System.EventHandler(this.fld_btnAddProductSection_Click);
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
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(843, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(754, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProductsGridControl
            // 
            this.fld_dgcProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductsGridControl.BOSComment = null;
            this.fld_dgcProductsGridControl.BOSDataMember = null;
            this.fld_dgcProductsGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcProductsGridControl.BOSDescription = null;
            this.fld_dgcProductsGridControl.BOSError = null;
            this.fld_dgcProductsGridControl.BOSFieldGroup = null;
            this.fld_dgcProductsGridControl.BOSFieldRelation = null;
            this.fld_dgcProductsGridControl.BOSGridType = null;
            this.fld_dgcProductsGridControl.BOSPrivilege = null;
            this.fld_dgcProductsGridControl.BOSPropertyName = null;
            this.fld_dgcProductsGridControl.Location = new System.Drawing.Point(12, 59);
            this.fld_dgcProductsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductsGridControl.Name = "fld_dgcProductsGridControl";
            this.fld_dgcProductsGridControl.PrintReport = false;
            this.fld_dgcProductsGridControl.Screen = null;
            this.fld_dgcProductsGridControl.Size = new System.Drawing.Size(914, 479);
            this.fld_dgcProductsGridControl.TabIndex = 2;
            this.fld_dgcProductsGridControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_txtFind
            // 
            this.fld_txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtFind.BOSComment = null;
            this.fld_txtFind.BOSDataMember = null;
            this.fld_txtFind.BOSDataSource = null;
            this.fld_txtFind.BOSDescription = null;
            this.fld_txtFind.BOSError = null;
            this.fld_txtFind.BOSFieldGroup = null;
            this.fld_txtFind.BOSFieldRelation = null;
            this.fld_txtFind.BOSPrivilege = null;
            this.fld_txtFind.BOSPropertyName = null;
            this.fld_txtFind.EditValue = "Nhập vào từ khóa tìm kiếm";
            this.fld_txtFind.Location = new System.Drawing.Point(12, 31);
            this.fld_txtFind.MenuManager = this.screenToolbar;
            this.fld_txtFind.Name = "fld_txtFind";
            this.fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtFind.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFind.Screen = null;
            this.fld_txtFind.Size = new System.Drawing.Size(793, 20);
            this.fld_txtFind.TabIndex = 0;
            this.fld_txtFind.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_txtFind_EditValueChanging);
            this.fld_txtFind.Leave += new System.EventHandler(this.fld_txtFind_Leave);
            this.fld_txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtFind_KeyUp);
            this.fld_txtFind.Click += new System.EventHandler(this.fld_txtFind_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(136, 13);
            this.bosLabel1.TabIndex = 131;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Tìm kiếm theo mã, tên, mô tả";
            // 
            // guiAddProduct
            // 
            this.AcceptButton = this.fld_btnAddNewProductSectionType;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtFind);
            this.Controls.Add(this.fld_dgcProductsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.fld_btnAddNewProductSectionType);
            this.Name = "guiAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiAddProduct_Load);
            this.Controls.SetChildIndex(this.fld_btnAddNewProductSectionType, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_txtFind, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnAddNewProductSectionType;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ProductsGridControl fld_dgcProductsGridControl;
        private BOSComponent.BOSTextBox fld_txtFind;
        private BOSComponent.BOSLabel bosLabel1;
    }
}