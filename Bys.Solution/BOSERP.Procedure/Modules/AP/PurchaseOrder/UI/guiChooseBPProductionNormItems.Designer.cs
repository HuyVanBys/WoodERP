namespace BOSERP.Modules.PurchaseOrder
{
    partial class guiChooseBPProductionNormItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseBPProductionNormItems));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcBPNormItemsGridControl = new BOSERP.Modules.PurchaseOrder.MMBPNormItemsGridControl();
            this.fld_btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSearchKey = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBPNormItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchKey.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnOK.Location = new System.Drawing.Point(715, 562);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(814, 562);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcBPNormItemsGridControl
            // 
            this.fld_dgcBPNormItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBPNormItemsGridControl.BOSComment = null;
            this.fld_dgcBPNormItemsGridControl.BOSDataMember = null;
            this.fld_dgcBPNormItemsGridControl.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcBPNormItemsGridControl.BOSDescription = null;
            this.fld_dgcBPNormItemsGridControl.BOSError = null;
            this.fld_dgcBPNormItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcBPNormItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcBPNormItemsGridControl.BOSGridType = null;
            this.fld_dgcBPNormItemsGridControl.BOSPrivilege = null;
            this.fld_dgcBPNormItemsGridControl.BOSPropertyName = null;
            this.fld_dgcBPNormItemsGridControl.CommodityType = "";
            this.fld_dgcBPNormItemsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcBPNormItemsGridControl.Location = new System.Drawing.Point(6, 49);
            this.fld_dgcBPNormItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcBPNormItemsGridControl.Name = "fld_dgcBPNormItemsGridControl";
            this.fld_dgcBPNormItemsGridControl.PrintReport = false;
            this.fld_dgcBPNormItemsGridControl.Screen = null;
            this.fld_dgcBPNormItemsGridControl.Size = new System.Drawing.Size(901, 507);
            this.fld_dgcBPNormItemsGridControl.TabIndex = 16;
            this.fld_dgcBPNormItemsGridControl.Tag = "DC";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Location = new System.Drawing.Point(789, 17);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Size = new System.Drawing.Size(107, 23);
            this.fld_btnSearch.TabIndex = 175;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.Fld_btnSearch_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 22);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(39, 13);
            this.bosLabel2.TabIndex = 176;
            this.bosLabel2.Text = "Từ khóa";
            // 
            // fld_txtSearchKey
            // 
            this.fld_txtSearchKey.BOSComment = null;
            this.fld_txtSearchKey.BOSDataMember = null;
            this.fld_txtSearchKey.BOSDataSource = null;
            this.fld_txtSearchKey.BOSDescription = null;
            this.fld_txtSearchKey.BOSError = null;
            this.fld_txtSearchKey.BOSFieldGroup = null;
            this.fld_txtSearchKey.BOSFieldRelation = null;
            this.fld_txtSearchKey.BOSPrivilege = null;
            this.fld_txtSearchKey.BOSPropertyName = null;
            this.fld_txtSearchKey.EditValue = "";
            this.fld_txtSearchKey.Location = new System.Drawing.Point(66, 18);
            this.fld_txtSearchKey.MenuManager = this.screenToolbar;
            this.fld_txtSearchKey.Name = "fld_txtSearchKey";
            this.fld_txtSearchKey.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtSearchKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtSearchKey.Properties.NullValuePrompt = "Nhập vào từ khóa";
            this.fld_txtSearchKey.Properties.NullValuePromptShowForEmptyValue = true;
            this.fld_txtSearchKey.Screen = null;
            this.fld_txtSearchKey.Size = new System.Drawing.Size(717, 20);
            this.fld_txtSearchKey.TabIndex = 174;
            // 
            // guiChooseBPProductionNormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(914, 596);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_txtSearchKey);
            this.Controls.Add(this.fld_dgcBPNormItemsGridControl);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseBPProductionNormItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách mặt hàng đề nghị";
            this.Load += new System.EventHandler(this.guiChooseBPProductionNormItems_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcBPNormItemsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_txtSearchKey, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBPNormItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private MMBPNormItemsGridControl fld_dgcBPNormItemsGridControl;
        private DevExpress.XtraEditors.SimpleButton fld_btnSearch;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtSearchKey;
    }
}