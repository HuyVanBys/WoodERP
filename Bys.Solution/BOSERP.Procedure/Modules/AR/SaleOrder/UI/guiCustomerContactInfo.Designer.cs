namespace BOSERP.Modules.SaleOrder
{
    partial class guiCustomerContactInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiCustomerContactInfo));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcCustomerContacts = new BOSERP.Modules.SaleOrder.ARCustomerContactsGridControl();
            this.fld_dgvARCustomerContacts = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerContacts)).BeginInit();
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
            this.fld_btnOK.Location = new System.Drawing.Point(371, 272);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 1;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(452, 272);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcCustomerContacts
            // 
            this.fld_dgcCustomerContacts.AllowDrop = true;
            this.fld_dgcCustomerContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCustomerContacts.BOSComment = "";
            this.fld_dgcCustomerContacts.BOSDataMember = "";
            this.fld_dgcCustomerContacts.BOSDataSource = "ARCustomerContacts";
            this.fld_dgcCustomerContacts.BOSDescription = null;
            this.fld_dgcCustomerContacts.BOSError = null;
            this.fld_dgcCustomerContacts.BOSFieldGroup = "";
            this.fld_dgcCustomerContacts.BOSFieldRelation = "";
            this.fld_dgcCustomerContacts.BOSGridType = null;
            this.fld_dgcCustomerContacts.BOSPrivilege = "";
            this.fld_dgcCustomerContacts.BOSPropertyName = "";
            this.fld_dgcCustomerContacts.CommodityType = "";
            this.fld_dgcCustomerContacts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCustomerContacts.Location = new System.Drawing.Point(0, -4);
            this.fld_dgcCustomerContacts.MainView = this.fld_dgvARCustomerContacts;
            this.fld_dgcCustomerContacts.Name = "fld_dgcCustomerContacts";
            this.fld_dgcCustomerContacts.PrintReport = false;
            this.fld_dgcCustomerContacts.Screen = null;
            this.fld_dgcCustomerContacts.Size = new System.Drawing.Size(539, 265);
            this.fld_dgcCustomerContacts.TabIndex = 6;
            this.fld_dgcCustomerContacts.Tag = "DC";
            this.fld_dgcCustomerContacts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomerContacts});
            // 
            // fld_dgvARCustomerContacts
            // 
            this.fld_dgvARCustomerContacts.GridControl = this.fld_dgcCustomerContacts;
            this.fld_dgvARCustomerContacts.Name = "fld_dgvARCustomerContacts";
            this.fld_dgvARCustomerContacts.PaintStyleName = "Office2003";
            // 
            // guiCustomerContactInfo
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 311);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcCustomerContacts);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiCustomerContactInfo.IconOptions.Icon")));
            this.Name = "guiCustomerContactInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Địa chỉ";
            this.Load += new System.EventHandler(this.guiChooseSupplier_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcCustomerContacts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private ARCustomerContactsGridControl fld_dgcCustomerContacts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomerContacts;
    }
}