namespace BOSERP.Modules.SaleOrder
{
    partial class guiShowCollectionComponent<T>
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
            this.fld_dgcICColectionItemGridControl = new BOSERP.Modules.SaleOrder.ICCollectionItemGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICColectionItemGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
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
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_dgcICColectionItemGridControl
            // 
            this.fld_dgcICColectionItemGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICColectionItemGridControl.BOSComment = null;
            this.fld_dgcICColectionItemGridControl.BOSDataMember = null;
            this.fld_dgcICColectionItemGridControl.BOSDataSource = "ICCollectionItems";
            this.fld_dgcICColectionItemGridControl.BOSDescription = null;
            this.fld_dgcICColectionItemGridControl.BOSError = null;
            this.fld_dgcICColectionItemGridControl.BOSFieldGroup = null;
            this.fld_dgcICColectionItemGridControl.BOSFieldRelation = null;
            this.fld_dgcICColectionItemGridControl.BOSGridType = null;
            this.fld_dgcICColectionItemGridControl.BOSPrivilege = null;
            this.fld_dgcICColectionItemGridControl.BOSPropertyName = null;
            this.fld_dgcICColectionItemGridControl.Location = new System.Drawing.Point(12, 39);
            this.fld_dgcICColectionItemGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICColectionItemGridControl.Name = "fld_dgcICCollectionItemGridControl";
            this.fld_dgcICColectionItemGridControl.PrintReport = false;
            this.fld_dgcICColectionItemGridControl.Screen = null;
            this.fld_dgcICColectionItemGridControl.Size = new System.Drawing.Size(914, 499);
            this.fld_dgcICColectionItemGridControl.TabIndex = 6;
           
            // 
            // guiShowCollectionComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            
            this.Controls.Add(this.fld_dgcICColectionItemGridControl);
            this.Controls.Add(this.fld_btnClose);
            
            this.Name = "guiShowCollectionComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách thành phần";
            this.Load += new System.EventHandler(this.guiShowCollectionComponent_Load);
           
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcICColectionItemGridControl, 0);
           
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICColectionItemGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private ICCollectionItemGridControl fld_dgcICColectionItemGridControl;
    }
}