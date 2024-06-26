namespace BOSERP.Modules.ProductConversion
{
    partial class guiShowAll
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
            this.fld_dgcShowAllTargetProduct = new BOSERP.Modules.ProductConversion.ICProductConversionItemViewsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShowAllTargetProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcShowAllTargetProduct
            // 
            this.fld_dgcShowAllTargetProduct.AllowDrop = true;
            this.fld_dgcShowAllTargetProduct.BOSComment = "";
            this.fld_dgcShowAllTargetProduct.BOSDataMember = "";
            this.fld_dgcShowAllTargetProduct.BOSDataSource = "ICProductConversionItems";
            this.fld_dgcShowAllTargetProduct.BOSDescription = null;
            this.fld_dgcShowAllTargetProduct.BOSError = null;
            this.fld_dgcShowAllTargetProduct.BOSFieldGroup = "";
            this.fld_dgcShowAllTargetProduct.BOSFieldRelation = "";
            this.fld_dgcShowAllTargetProduct.BOSGridType = null;
            this.fld_dgcShowAllTargetProduct.BOSPrivilege = "";
            this.fld_dgcShowAllTargetProduct.BOSPropertyName = null;
            this.fld_dgcShowAllTargetProduct.CommodityType = "";
            this.fld_dgcShowAllTargetProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcShowAllTargetProduct.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcShowAllTargetProduct.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcShowAllTargetProduct.MainView = this.gridView1;
            this.fld_dgcShowAllTargetProduct.Name = "fld_dgcShowAllTargetProduct";
            this.fld_dgcShowAllTargetProduct.PrintReport = false;
            this.fld_dgcShowAllTargetProduct.Screen = null;
            this.fld_dgcShowAllTargetProduct.Size = new System.Drawing.Size(974, 625);
            this.fld_dgcShowAllTargetProduct.TabIndex = 6;
            this.fld_dgcShowAllTargetProduct.Tag = "DC";
            this.fld_dgcShowAllTargetProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcShowAllTargetProduct;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // guiShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 625);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcShowAllTargetProduct);
            this.Name = "guiShowAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiShowAll_Load);
            this.Controls.SetChildIndex(this.fld_dgcShowAllTargetProduct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShowAllTargetProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICProductConversionItemViewsGridControl fld_dgcShowAllTargetProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}