namespace BOSERP.Modules.ProductConversion
{
    partial class guiShowSimilarSerialNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowSimilarSerialNo));
            this.fld_dgcShowAllSimilarSerialNo = new BOSERP.Modules.ProductConversion.ICProductSerialGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShowAllSimilarSerialNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcShowAllSimilarSerialNo
            // 
            this.fld_dgcShowAllSimilarSerialNo.AllowDrop = true;
            this.fld_dgcShowAllSimilarSerialNo.BOSComment = "";
            this.fld_dgcShowAllSimilarSerialNo.BOSDataMember = "";
            this.fld_dgcShowAllSimilarSerialNo.BOSDataSource = "ICProductSeries";
            this.fld_dgcShowAllSimilarSerialNo.BOSDescription = null;
            this.fld_dgcShowAllSimilarSerialNo.BOSError = null;
            this.fld_dgcShowAllSimilarSerialNo.BOSFieldGroup = "";
            this.fld_dgcShowAllSimilarSerialNo.BOSFieldRelation = "";
            this.fld_dgcShowAllSimilarSerialNo.BOSGridType = null;
            this.fld_dgcShowAllSimilarSerialNo.BOSPrivilege = "";
            this.fld_dgcShowAllSimilarSerialNo.BOSPropertyName = null;
            this.fld_dgcShowAllSimilarSerialNo.CommodityType = "";
            this.fld_dgcShowAllSimilarSerialNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcShowAllSimilarSerialNo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcShowAllSimilarSerialNo.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcShowAllSimilarSerialNo.MainView = this.gridView1;
            this.fld_dgcShowAllSimilarSerialNo.Name = "fld_dgcShowAllSimilarSerialNo";
            this.fld_dgcShowAllSimilarSerialNo.PrintReport = false;
            this.fld_dgcShowAllSimilarSerialNo.Screen = null;
            this.fld_dgcShowAllSimilarSerialNo.Size = new System.Drawing.Size(1002, 639);
            this.fld_dgcShowAllSimilarSerialNo.TabIndex = 6;
            this.fld_dgcShowAllSimilarSerialNo.Tag = "DC";
            this.fld_dgcShowAllSimilarSerialNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcShowAllSimilarSerialNo;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // guiShowSimilarSerialNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 639);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcShowAllSimilarSerialNo);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiShowSimilarSerialNo.IconOptions.Icon")));
            this.Name = "guiShowSimilarSerialNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách mã lô";
            this.Load += new System.EventHandler(this.guiShowAll_Load);
            this.Controls.SetChildIndex(this.fld_dgcShowAllSimilarSerialNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShowAllSimilarSerialNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICProductSerialGridControl fld_dgcShowAllSimilarSerialNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}