namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiChooseWeek
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
            this.fld_dgcChooseWeekGridControls = new BOSERP.Modules.OperationDetailPlan.ChooseWeekGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcChooseWeekGridControls)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(264, 308);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcChooseWeekGridControls
            // 
            this.fld_dgcChooseWeekGridControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcChooseWeekGridControls.BOSComment = null;
            this.fld_dgcChooseWeekGridControls.BOSDataMember = null;
            this.fld_dgcChooseWeekGridControls.BOSDataSource = "MMOperationPlanDetails";
            this.fld_dgcChooseWeekGridControls.BOSDescription = null;
            this.fld_dgcChooseWeekGridControls.BOSError = null;
            this.fld_dgcChooseWeekGridControls.BOSFieldGroup = null;
            this.fld_dgcChooseWeekGridControls.BOSFieldRelation = null;
            this.fld_dgcChooseWeekGridControls.BOSGridType = null;
            this.fld_dgcChooseWeekGridControls.BOSPrivilege = null;
            this.fld_dgcChooseWeekGridControls.BOSPropertyName = null;
            this.fld_dgcChooseWeekGridControls.CommodityType = "";
            this.fld_dgcChooseWeekGridControls.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcChooseWeekGridControls.MenuManager = this.screenToolbar;
            this.fld_dgcChooseWeekGridControls.Name = "fld_dgcChooseWeekGridControls";
            this.fld_dgcChooseWeekGridControls.PrintReport = false;
            this.fld_dgcChooseWeekGridControls.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcChooseWeekGridControls, true);
            this.fld_dgcChooseWeekGridControls.Size = new System.Drawing.Size(345, 305);
            this.fld_dgcChooseWeekGridControls.TabIndex = 6;
            // 
            // guiChooseWeek
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(344, 339);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcChooseWeekGridControls);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "guiChooseWeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách tuần trong năm";
            this.Load += new System.EventHandler(this.guiChooseWeek_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcChooseWeekGridControls, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcChooseWeekGridControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSButton fld_btnClose;
        private ChooseWeekGridControl fld_dgcChooseWeekGridControls;
    }
}