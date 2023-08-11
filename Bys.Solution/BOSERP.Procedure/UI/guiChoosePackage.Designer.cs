namespace BOSERP
{
    partial class guiChoosePackage<T>
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
            this.fld_pnlPackage = new BOSComponent.BOSPanel(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnOk = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICPackageID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcICPackages = new BOSERP.ICPackagesGridControl();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_pnlPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPackageID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pnlPackage
            // 
            this.fld_pnlPackage.BOSComment = null;
            this.fld_pnlPackage.BOSDataMember = null;
            this.fld_pnlPackage.BOSDataSource = null;
            this.fld_pnlPackage.BOSDescription = null;
            this.fld_pnlPackage.BOSError = null;
            this.fld_pnlPackage.BOSFieldGroup = null;
            this.fld_pnlPackage.BOSFieldRelation = null;
            this.fld_pnlPackage.BOSPrivilege = null;
            this.fld_pnlPackage.BOSPropertyName = null;
            this.fld_pnlPackage.Controls.Add(this.fld_btnCancel);
            this.fld_pnlPackage.Controls.Add(this.fld_btnOk);
            this.fld_pnlPackage.Controls.Add(this.fld_lkeFK_ICPackageID);
            this.fld_pnlPackage.Controls.Add(this.fld_dgcICPackages);
            this.fld_pnlPackage.Controls.Add(this.bosLabel3);
            this.fld_pnlPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlPackage.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlPackage.Name = "fld_pnlPackage";
            this.fld_pnlPackage.Screen = null;
            this.fld_pnlPackage.Size = new System.Drawing.Size(959, 414);
            this.fld_pnlPackage.TabIndex = 504;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(847, 375);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(100, 27);
            this.fld_btnCancel.TabIndex = 394;
            this.fld_btnCancel.Text = "Hủy bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnOk
            // 
            this.fld_btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOk.BOSComment = null;
            this.fld_btnOk.BOSDataMember = null;
            this.fld_btnOk.BOSDataSource = null;
            this.fld_btnOk.BOSDescription = null;
            this.fld_btnOk.BOSError = null;
            this.fld_btnOk.BOSFieldGroup = null;
            this.fld_btnOk.BOSFieldRelation = null;
            this.fld_btnOk.BOSPrivilege = null;
            this.fld_btnOk.BOSPropertyName = null;
            this.fld_btnOk.Location = new System.Drawing.Point(736, 375);
            this.fld_btnOk.Name = "fld_btnOk";
            this.fld_btnOk.Screen = null;
            this.fld_btnOk.Size = new System.Drawing.Size(100, 27);
            this.fld_btnOk.TabIndex = 394;
            this.fld_btnOk.Text = "Đồng ý";
            this.fld_btnOk.Click += new System.EventHandler(this.fld_btnOk_Click);
            // 
            // fld_lkeFK_ICPackageID
            // 
            this.fld_lkeFK_ICPackageID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICPackageID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICPackageID.BOSAllowDummy = false;
            this.fld_lkeFK_ICPackageID.BOSComment = "";
            this.fld_lkeFK_ICPackageID.BOSDataMember = "ICPackageID";
            this.fld_lkeFK_ICPackageID.BOSDataSource = "ICPackages";
            this.fld_lkeFK_ICPackageID.BOSDescription = null;
            this.fld_lkeFK_ICPackageID.BOSError = "";
            this.fld_lkeFK_ICPackageID.BOSFieldGroup = "";
            this.fld_lkeFK_ICPackageID.BOSFieldParent = "";
            this.fld_lkeFK_ICPackageID.BOSFieldRelation = "";
            this.fld_lkeFK_ICPackageID.BOSPrivilege = "";
            this.fld_lkeFK_ICPackageID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICPackageID.BOSSelectType = "";
            this.fld_lkeFK_ICPackageID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICPackageID.CurrentDisplayText = "";
            this.fld_lkeFK_ICPackageID.Location = new System.Drawing.Point(68, 15);
            this.fld_lkeFK_ICPackageID.Name = "fld_lkeFK_ICPackageID";
            this.fld_lkeFK_ICPackageID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICPackageID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICPackageID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICPackageID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICPackageID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICPackageID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICPackageNo", "Mã kiện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICPackagePackNo", "Mã lô hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICPackageOrder", "Số thứ tự"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICPackageSupplierNo", "Mã kiện NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSupplierNo", "Mã sản phẩm NCC")});
            this.fld_lkeFK_ICPackageID.Properties.DisplayMember = "ICPackageNo";
            this.fld_lkeFK_ICPackageID.Properties.NullText = "";
            this.fld_lkeFK_ICPackageID.Properties.PopupWidth = 50;
            this.fld_lkeFK_ICPackageID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICPackageID.Properties.ValueMember = "ICPackageID";
            this.fld_lkeFK_ICPackageID.Screen = null;
            this.fld_lkeFK_ICPackageID.Size = new System.Drawing.Size(864, 20);
            this.fld_lkeFK_ICPackageID.TabIndex = 393;
            this.fld_lkeFK_ICPackageID.Tag = "DC";
            this.fld_lkeFK_ICPackageID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICPackageID_KeyUp);
            // 
            // fld_dgcICPackages
            // 
            this.fld_dgcICPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICPackages.BOSComment = null;
            this.fld_dgcICPackages.BOSDataMember = null;
            this.fld_dgcICPackages.BOSDataSource = "ICPackages";
            this.fld_dgcICPackages.BOSDescription = null;
            this.fld_dgcICPackages.BOSError = null;
            this.fld_dgcICPackages.BOSFieldGroup = null;
            this.fld_dgcICPackages.BOSFieldRelation = null;
            this.fld_dgcICPackages.BOSGridType = null;
            this.fld_dgcICPackages.BOSPrivilege = null;
            this.fld_dgcICPackages.BOSPropertyName = null;
            this.fld_dgcICPackages.Location = new System.Drawing.Point(4, 56);
            this.fld_dgcICPackages.MenuManager = this.screenToolbar;
            this.fld_dgcICPackages.Name = "fld_dgcICPackages";
            this.fld_dgcICPackages.Screen = null;
            this.fld_dgcICPackages.Size = new System.Drawing.Size(955, 313);
            this.fld_dgcICPackages.TabIndex = 392;
            this.fld_dgcICPackages.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(15, 18);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 391;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Kiện hàng";
            // 
            // guiChoosePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 414);
            this.ControlBox = true;
            this.Controls.Add(this.fld_pnlPackage);
            this.Name = "guiChoosePackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn kiện";
            this.Load += new System.EventHandler(this.guiChoosePackage_Load);
            this.Controls.SetChildIndex(this.fld_pnlPackage, 0);
            this.fld_pnlPackage.ResumeLayout(false);
            this.fld_pnlPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPackageID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel fld_pnlPackage;
        private BOSComponent.BOSLabel bosLabel3;
        private ICPackagesGridControl fld_dgcICPackages;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPackageID;
        private BOSComponent.BOSButton fld_btnOk;
        private BOSComponent.BOSButton fld_btnCancel;

    }
}