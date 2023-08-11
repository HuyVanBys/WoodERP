namespace BOSERP.Modules.InventoryStockCount.UI
{
    partial class guiImportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiImportData));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.fld_dgcIPInvBalances = new BOSERP.Modules.InventoryStockCount.ImportInventoryStockCountsGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.bosPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcIPInvBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.fld_dgcIPInvBalances);
            this.bosPanel1.Controls.Add(this.fld_btnExit);
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1038, 616);
            this.bosPanel1.TabIndex = 406;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bosLabel16);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.bosLabel18);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 50);
            this.groupBox1.TabIndex = 570;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi chú";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "ICProductNo";
            this.bosLabel1.BOSDataSource = "ICProducts";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(286, 14);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(265, 13);
            this.bosLabel1.TabIndex = 566;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Kho không tồn tại hoặc chưa mapping với dữ liệu nguồn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button1.Location = new System.Drawing.Point(257, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 15);
            this.button1.TabIndex = 567;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "ICProductNo";
            this.bosLabel16.BOSDataSource = "ICProducts";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(39, 15);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(202, 13);
            this.bosLabel16.TabIndex = 559;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Sản phẩm chưa mapping với dữ liệu nguồn";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button4.Location = new System.Drawing.Point(12, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 15);
            this.button4.TabIndex = 564;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "ICProductNo";
            this.bosLabel18.BOSDataSource = "ICProducts";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(39, 33);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(192, 13);
            this.bosLabel18.TabIndex = 560;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Sản phẩm có tên khác với dữ liệu nguồn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button2.Location = new System.Drawing.Point(12, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 15);
            this.button2.TabIndex = 563;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // fld_dgcIPInvBalances
            // 
            this.fld_dgcIPInvBalances.AllowDrop = true;
            this.fld_dgcIPInvBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcIPInvBalances.BOSComment = "";
            this.fld_dgcIPInvBalances.BOSDataMember = "";
            this.fld_dgcIPInvBalances.BOSDataSource = "IPInventoryStockCounts";
            this.fld_dgcIPInvBalances.BOSDescription = null;
            this.fld_dgcIPInvBalances.BOSError = null;
            this.fld_dgcIPInvBalances.BOSFieldGroup = "";
            this.fld_dgcIPInvBalances.BOSFieldRelation = "";
            this.fld_dgcIPInvBalances.BOSGridType = null;
            this.fld_dgcIPInvBalances.BOSPrivilege = "";
            this.fld_dgcIPInvBalances.BOSPropertyName = "";
            this.fld_dgcIPInvBalances.CommodityType = "";
            this.fld_dgcIPInvBalances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcIPInvBalances.Location = new System.Drawing.Point(12, 11);
            this.fld_dgcIPInvBalances.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcIPInvBalances.Name = "fld_dgcIPInvBalances";
            this.fld_dgcIPInvBalances.PrintReport = false;
            this.fld_dgcIPInvBalances.Screen = null;
            this.fld_dgcIPInvBalances.Size = new System.Drawing.Size(1014, 539);
            this.fld_dgcIPInvBalances.TabIndex = 569;
            this.fld_dgcIPInvBalances.Tag = "DC";
            this.fld_dgcIPInvBalances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcIPInvBalances;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
            // 
            // fld_btnExit
            // 
            this.fld_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExit.Location = new System.Drawing.Point(936, 568);
            this.fld_btnExit.Name = "fld_btnExit";
            this.fld_btnExit.Size = new System.Drawing.Size(90, 27);
            this.fld_btnExit.TabIndex = 568;
            this.fld_btnExit.Text = "Thoát";
            this.fld_btnExit.Click += new System.EventHandler(this.fld_btnExit_Click_1);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(836, 568);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(90, 27);
            this.fld_btnOK.TabIndex = 567;
            this.fld_btnOK.Text = "Duyệt Import";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // guiImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 616);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiImportData.IconOptions.Icon")));
            this.Name = "guiImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Danh sách dữ liệu nhập từ Excel";
            this.Load += new System.EventHandler(this.guiImportData_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcIPInvBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSPanel bosPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BOSComponent.BOSLabel bosLabel1;
        private System.Windows.Forms.Button button1;
        private BOSComponent.BOSLabel bosLabel16;
        private System.Windows.Forms.Button button4;
        private BOSComponent.BOSLabel bosLabel18;
        private System.Windows.Forms.Button button2;
        private InventoryStockCount.ImportInventoryStockCountsGridControl fld_dgcIPInvBalances;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;
        private DevExpress.XtraEditors.SimpleButton fld_btnExit;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
    }
}