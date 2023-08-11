using BOSComponent;
namespace BOSERP.Modules.BatchProduct
{
    partial class guiShowBatchProductMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowBatchProductMessage));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcBatchProductMessagesGridControl = new BOSERP.Modules.BatchProduct.MMBatchProductMessagesGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductMessagesGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(507, 254);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(92, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcBatchProductMessagesGridControl
            // 
            this.fld_dgcBatchProductMessagesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBatchProductMessagesGridControl.BOSComment = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSDataMember = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSDataSource = "MMBatchProductMessages";
            this.fld_dgcBatchProductMessagesGridControl.BOSDescription = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSError = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSFieldGroup = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSFieldRelation = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSGridType = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSPrivilege = null;
            this.fld_dgcBatchProductMessagesGridControl.BOSPropertyName = null;
            this.fld_dgcBatchProductMessagesGridControl.CommodityType = "";
            this.fld_dgcBatchProductMessagesGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcBatchProductMessagesGridControl.Location = new System.Drawing.Point(6, 9);
            this.fld_dgcBatchProductMessagesGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcBatchProductMessagesGridControl.Name = "fld_dgcBatchProductMessagesGridControl";
            this.fld_dgcBatchProductMessagesGridControl.PrintReport = false;
            this.fld_dgcBatchProductMessagesGridControl.Screen = null;
            this.fld_dgcBatchProductMessagesGridControl.Size = new System.Drawing.Size(593, 241);
            this.fld_dgcBatchProductMessagesGridControl.TabIndex = 186;
            this.fld_dgcBatchProductMessagesGridControl.Tag = "";
            this.fld_dgcBatchProductMessagesGridControl.DoubleClick += new System.EventHandler(this.fld_dgcBatchProductMessagesGridControl_DoubleClick);
            // 
            // guiShowBatchProductMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(607, 287);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcBatchProductMessagesGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiShowBatchProductMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.guiChooseProposalItem_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcBatchProductMessagesGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductMessagesGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnClose;
        private MMBatchProductMessagesGridControl fld_dgcBatchProductMessagesGridControl;
    }
}