namespace BOSERP.Modules.Report
{
    partial class guiReportShowProductSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiReportShowProductSerie));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICInventoryStocks = new BOSERP.Modules.Report.RP013ICProductSeriesGridControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryStocks)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Controls.Add(this.fld_dgcICInventoryStocks);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(832, 332);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(743, 302);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(86, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đóng";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_dgcICInventoryStocks
            // 
            this.fld_dgcICInventoryStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICInventoryStocks.BOSComment = null;
            this.fld_dgcICInventoryStocks.BOSDataMember = null;
            this.fld_dgcICInventoryStocks.BOSDataSource = "ICInventoryStocks";
            this.fld_dgcICInventoryStocks.BOSDescription = null;
            this.fld_dgcICInventoryStocks.BOSError = null;
            this.fld_dgcICInventoryStocks.BOSFieldGroup = null;
            this.fld_dgcICInventoryStocks.BOSFieldRelation = null;
            this.fld_dgcICInventoryStocks.BOSGridType = null;
            this.fld_dgcICInventoryStocks.BOSPrivilege = null;
            this.fld_dgcICInventoryStocks.BOSPropertyName = null;
            this.fld_dgcICInventoryStocks.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICInventoryStocks.MenuManager = this.screenToolbar;
            this.fld_dgcICInventoryStocks.Name = "fld_dgcICInventoryStocks";
            this.fld_dgcICInventoryStocks.Screen = null;
            this.fld_dgcICInventoryStocks.Size = new System.Drawing.Size(832, 296);
            this.fld_dgcICInventoryStocks.TabIndex = 0;
            // 
            // guiReportShowProductSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 332);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiReportShowProductSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách lô hàng";
            this.Load += new System.EventHandler(this.guiReportShowProductSerie_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private RP013ICProductSeriesGridControl fld_dgcICInventoryStocks;
        private BOSComponent.BOSButton fld_btnOK;
    }
}