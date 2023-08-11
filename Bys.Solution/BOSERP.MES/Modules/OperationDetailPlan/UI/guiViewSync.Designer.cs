namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiViewSync
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcViewSyncInfoGridControls = new BOSERP.Modules.OperationDetailPlan.ViewSyncInfoGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcViewSyncInfoGridControls)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
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
            this.fld_btnClose.Location = new System.Drawing.Point(761, 308);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcViewSyncInfoGridControls
            // 
            this.fld_dgcViewSyncInfoGridControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcViewSyncInfoGridControls.BOSComment = null;
            this.fld_dgcViewSyncInfoGridControls.BOSDataMember = null;
            this.fld_dgcViewSyncInfoGridControls.BOSDataSource = "MMOperationPlanDetails";
            this.fld_dgcViewSyncInfoGridControls.BOSDescription = null;
            this.fld_dgcViewSyncInfoGridControls.BOSError = null;
            this.fld_dgcViewSyncInfoGridControls.BOSFieldGroup = null;
            this.fld_dgcViewSyncInfoGridControls.BOSFieldRelation = null;
            this.fld_dgcViewSyncInfoGridControls.BOSGridType = null;
            this.fld_dgcViewSyncInfoGridControls.BOSPrivilege = null;
            this.fld_dgcViewSyncInfoGridControls.BOSPropertyName = null;
            this.fld_dgcViewSyncInfoGridControls.CommodityType = "";
            this.fld_dgcViewSyncInfoGridControls.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcViewSyncInfoGridControls.MenuManager = this.screenToolbar;
            this.fld_dgcViewSyncInfoGridControls.Name = "fld_dgcViewSyncInfoGridControls";
            this.fld_dgcViewSyncInfoGridControls.PrintReport = false;
            this.fld_dgcViewSyncInfoGridControls.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcViewSyncInfoGridControls, true);
            this.fld_dgcViewSyncInfoGridControls.Size = new System.Drawing.Size(842, 305);
            this.fld_dgcViewSyncInfoGridControls.TabIndex = 6;
            // 
            // guiViewSync
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(841, 339);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcViewSyncInfoGridControls);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "guiViewSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đồng bộ";
            this.Load += new System.EventHandler(this.guiViewSync_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcViewSyncInfoGridControls, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcViewSyncInfoGridControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSButton fld_btnClose;
        private ViewSyncInfoGridControl fld_dgcViewSyncInfoGridControls;
    }
}