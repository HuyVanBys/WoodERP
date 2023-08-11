namespace BOSERP.Modules.BatchProduct
{
    partial class guiChooseBPItemOutSourcing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseBPItemOutSourcing));
            this.fld_btnClose = new BOSComponent.BOSButton();
            this.fld_btnApply = new BOSComponent.BOSButton();
            this.fld_dgcMMBPProductionNormItemsGridControl = new BOSERP.Modules.BatchProduct.MMBatchProductItemOutsourcingSearchGridControl();
            this.fld_btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.bosLabel2 = new BOSComponent.BOSLabel();
            this.fld_cmbStocks = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBPProductionNormItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStocks.Properties)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(848, 574);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Thoát";
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
            this.fld_btnApply.Location = new System.Drawing.Point(758, 574);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 0;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcMMBPProductionNormItemsGridControl
            // 
            this.fld_dgcMMBPProductionNormItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSComment = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSDataMember = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSDataSource = "MMBatchProductItemOutSourcings";
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSDescription = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSError = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSGridType = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSPrivilege = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.BOSPropertyName = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.CommodityType = "";
            this.fld_dgcMMBPProductionNormItemsGridControl.Location = new System.Drawing.Point(12, 43);
            this.fld_dgcMMBPProductionNormItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcMMBPProductionNormItemsGridControl.Name = "fld_dgcMMBPProductionNormItemsGridControl";
            this.fld_dgcMMBPProductionNormItemsGridControl.PrintReport = false;
            this.fld_dgcMMBPProductionNormItemsGridControl.Screen = null;
            this.fld_dgcMMBPProductionNormItemsGridControl.Size = new System.Drawing.Size(918, 522);
            this.fld_dgcMMBPProductionNormItemsGridControl.TabIndex = 1;
            this.fld_dgcMMBPProductionNormItemsGridControl.Tag = "";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Location = new System.Drawing.Point(798, 11);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Size = new System.Drawing.Size(99, 23);
            this.fld_btnSearch.TabIndex = 181;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(23, 16);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(18, 13);
            this.bosLabel2.TabIndex = 182;
            this.bosLabel2.Text = "Kho";
            // 
            // fld_cmbStocks
            // 
            this.fld_cmbStocks.Location = new System.Drawing.Point(67, 13);
            this.fld_cmbStocks.MenuManager = this.screenToolbar;
            this.fld_cmbStocks.Name = "fld_cmbStocks";
            this.fld_cmbStocks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbStocks.Properties.DisplayMember = "ICStockName";
            this.fld_cmbStocks.Properties.ValueMember = "ICStockID";
            this.fld_cmbStocks.Size = new System.Drawing.Size(316, 20);
            this.fld_cmbStocks.TabIndex = 183;
            // 
            // guiChooseBPItemOutSourcing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(942, 610);
            this.ControlBox = true;
            this.Controls.Add(this.fld_cmbStocks);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dgcMMBPProductionNormItemsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiChooseBPItemOutSourcing.IconOptions.Icon")));
            this.Name = "guiChooseBPItemOutSourcing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiChooseBPItemOutSourcing_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMBPProductionNormItemsGridControl, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            this.Controls.SetChildIndex(this.fld_cmbStocks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBPProductionNormItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStocks.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private MMBatchProductItemOutsourcingSearchGridControl fld_dgcMMBPProductionNormItemsGridControl;
        private DevExpress.XtraEditors.SimpleButton fld_btnSearch;
        private BOSComponent.BOSLabel bosLabel2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_cmbStocks;
    }
}