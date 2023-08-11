namespace BOSERP.Modules.BatchProductShedule
{
    partial class guiAlternativeMulti
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
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_dgcPnItemsGridControl = new BOSERP.Modules.BatchProductShedule.MMBPNormItemsGridControl();
            this.fld_dgcProductMultisGridControl = new BOSERP.Modules.BatchProductShedule.ICAlternativeMaterialMultisGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPnItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductMultisGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(909, 561);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
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
            this.fld_btnApply.Location = new System.Drawing.Point(820, 561);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Lưu";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(10, 12);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcPnItemsGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_dgcProductMultisGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(982, 543);
            this.splitContainerControl1.SplitterPosition = 365;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // fld_dgcPnItemsGridControl
            // 
            this.fld_dgcPnItemsGridControl.BOSComment = null;
            this.fld_dgcPnItemsGridControl.BOSDataMember = null;
            this.fld_dgcPnItemsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcPnItemsGridControl.BOSDescription = null;
            this.fld_dgcPnItemsGridControl.BOSError = null;
            this.fld_dgcPnItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcPnItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcPnItemsGridControl.BOSGridType = null;
            this.fld_dgcPnItemsGridControl.BOSPrivilege = null;
            this.fld_dgcPnItemsGridControl.BOSPropertyName = null;
            this.fld_dgcPnItemsGridControl.CommodityType = "";
            this.fld_dgcPnItemsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcPnItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcPnItemsGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcPnItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPnItemsGridControl.Name = "fld_dgcPnItemsGridControl";
            this.fld_dgcPnItemsGridControl.PrintReport = false;
            this.fld_dgcPnItemsGridControl.Screen = null;
            this.fld_dgcPnItemsGridControl.Size = new System.Drawing.Size(982, 365);
            this.fld_dgcPnItemsGridControl.TabIndex = 26;
            // 
            // fld_dgcProductMultisGridControl
            // 
            this.fld_dgcProductMultisGridControl.BOSComment = null;
            this.fld_dgcProductMultisGridControl.BOSDataMember = null;
            this.fld_dgcProductMultisGridControl.BOSDataSource = "ICProductAlternatives";
            this.fld_dgcProductMultisGridControl.BOSDescription = null;
            this.fld_dgcProductMultisGridControl.BOSError = null;
            this.fld_dgcProductMultisGridControl.BOSFieldGroup = null;
            this.fld_dgcProductMultisGridControl.BOSFieldRelation = null;
            this.fld_dgcProductMultisGridControl.BOSGridType = null;
            this.fld_dgcProductMultisGridControl.BOSPrivilege = null;
            this.fld_dgcProductMultisGridControl.BOSPropertyName = null;
            this.fld_dgcProductMultisGridControl.CommodityType = "";
            this.fld_dgcProductMultisGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProductMultisGridControl.IsAlterOverConfigMaterial = false;
            this.fld_dgcProductMultisGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcProductMultisGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductMultisGridControl.Name = "fld_dgcProductMultisGridControl";
            this.fld_dgcProductMultisGridControl.PrintReport = false;
            this.fld_dgcProductMultisGridControl.Screen = null;
            this.fld_dgcProductMultisGridControl.Size = new System.Drawing.Size(982, 173);
            this.fld_dgcProductMultisGridControl.TabIndex = 3;
            this.fld_dgcProductMultisGridControl.Tag = "";
            // 
            // guiAlternativeMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(1004, 596);
            this.ControlBox = true;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAlternativeMulti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm có thể thay";
            this.Load += new System.EventHandler(this.guiAlternativeMulti_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPnItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductMultisGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private ICAlternativeMaterialMultisGridControl fld_dgcProductMultisGridControl;
        private MMBPNormItemsGridControl fld_dgcPnItemsGridControl;
    }
}