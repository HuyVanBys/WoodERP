namespace BOSERP
{
    partial class guiShowProductHasComponent<T>
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductsGridControl = new BOSERP.ICProductHasComponentGridControl();
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductsGridControl)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(909, 322);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_dgcICProductsGridControl
            // 
            this.fld_dgcICProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductsGridControl.BOSComment = null;
            this.fld_dgcICProductsGridControl.BOSDataMember = null;
            this.fld_dgcICProductsGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcICProductsGridControl.BOSDescription = null;
            this.fld_dgcICProductsGridControl.BOSError = null;
            this.fld_dgcICProductsGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductsGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductsGridControl.BOSGridType = null;
            this.fld_dgcICProductsGridControl.BOSPrivilege = null;
            this.fld_dgcICProductsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductsGridControl.CommodityType = "";
            this.fld_dgcICProductsGridControl.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcICProductsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductsGridControl.Name = "fld_dgcICProductsGridControl";
            this.fld_dgcICProductsGridControl.PrintReport = false;
            this.fld_dgcICProductsGridControl.Screen = null;
            this.fld_dgcICProductsGridControl.Size = new System.Drawing.Size(980, 304);
            this.fld_dgcICProductsGridControl.TabIndex = 6;
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
            this.fld_btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnApply.Location = new System.Drawing.Point(801, 322);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // guiShowProductHasComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(1004, 361);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.fld_dgcICProductsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Name = "guiShowProductHasComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiShowProductHasComponent_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProductsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private ICProductHasComponentGridControl fld_dgcICProductsGridControl;
        private BOSComponent.BOSButton fld_btnApply;
    }
}