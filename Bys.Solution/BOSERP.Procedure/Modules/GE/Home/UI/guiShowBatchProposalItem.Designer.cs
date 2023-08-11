namespace BOSERP.Modules.Home
{
    partial class guiShowBatchProposalItem
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
            this.fld_dgcBatchProposalItemsGridControl = new BOSERP.Modules.Home.MMProposalItemsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProposalItemsGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(843, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Thoát";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcBatchProposalItemsGridControl
            // 
            this.fld_dgcBatchProposalItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBatchProposalItemsGridControl.BOSComment = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSDataMember = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSDataSource = "MMProposalItems";
            this.fld_dgcBatchProposalItemsGridControl.BOSDescription = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSError = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSGridType = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSPrivilege = null;
            this.fld_dgcBatchProposalItemsGridControl.BOSPropertyName = null;
            this.fld_dgcBatchProposalItemsGridControl.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcBatchProposalItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcBatchProposalItemsGridControl.Name = "fld_dgcBatchProposalItemsGridControl";
            this.fld_dgcBatchProposalItemsGridControl.PrintReport = false;
            this.fld_dgcBatchProposalItemsGridControl.Screen = null;
            this.fld_dgcBatchProposalItemsGridControl.Size = new System.Drawing.Size(914, 526);
            this.fld_dgcBatchProposalItemsGridControl.TabIndex = 6;
            // 
            // guiShowBatchProposalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcBatchProposalItemsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Name = "guiShowBatchProposalItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thành phần";
            this.Load += new System.EventHandler(this.guiShowCollectionComponent_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcBatchProposalItemsGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProposalItemsGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private MMProposalItemsGridControl fld_dgcBatchProposalItemsGridControl;
    }
}