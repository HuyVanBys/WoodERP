using BOSComponent;
namespace BOSERP.Modules.ProductPackage
{
    partial class guiShowPackageProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowPackageProductItem));
            this.fld_dgcICProductPackageItems = new BOSERP.Modules.ProductPackage.ICProductPackageItemsGridControl();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackageItems)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICProductPackageItems
            // 
            this.fld_dgcICProductPackageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductPackageItems.BOSComment = null;
            this.fld_dgcICProductPackageItems.BOSDataMember = null;
            this.fld_dgcICProductPackageItems.BOSDataSource = "ICProductPackageItems";
            this.fld_dgcICProductPackageItems.BOSDescription = null;
            this.fld_dgcICProductPackageItems.BOSError = null;
            this.fld_dgcICProductPackageItems.BOSFieldGroup = null;
            this.fld_dgcICProductPackageItems.BOSFieldRelation = null;
            this.fld_dgcICProductPackageItems.BOSGridType = null;
            this.fld_dgcICProductPackageItems.BOSPrivilege = null;
            this.fld_dgcICProductPackageItems.BOSPropertyName = null;
            this.fld_dgcICProductPackageItems.CommodityType = "";
            this.fld_dgcICProductPackageItems.Location = new System.Drawing.Point(2, 1);
            this.fld_dgcICProductPackageItems.MenuManager = this.screenToolbar;
            this.fld_dgcICProductPackageItems.Name = "fld_dgcICProductPackageItems";
            this.fld_dgcICProductPackageItems.PrintReport = false;
            this.fld_dgcICProductPackageItems.Screen = null;
            this.fld_dgcICProductPackageItems.Size = new System.Drawing.Size(886, 528);
            this.fld_dgcICProductPackageItems.TabIndex = 0;
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
            this.fld_btnOK.Location = new System.Drawing.Point(692, 535);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Visible = false;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(790, 535);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiShowPackageProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_dgcICProductPackageItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiShowPackageProductItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết kiện";
            this.Load += new System.EventHandler(this.guiShowPackageProductItem_Load);
            this.Controls.SetChildIndex(this.fld_dgcICProductPackageItems, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackageItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICProductPackageItemsGridControl fld_dgcICProductPackageItems;
        private BOSButton fld_btnOK;
        private BOSButton fld_btnCancel;
    }
}