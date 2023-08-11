namespace BOSERP.Modules.CarcassBOM.UI
{
    partial class guiCopyMaterial
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
            this.fld_dgcMaterialProduct = new BOSERP.Modules.CarcassBOM.ChooseMaterialsGridControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fld_lkeICProductID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcMaterialProduct
            // 
            this.fld_dgcMaterialProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMaterialProduct.BOSComment = null;
            this.fld_dgcMaterialProduct.BOSDataMember = null;
            this.fld_dgcMaterialProduct.BOSDataSource = "ICProductItemMaterials";
            this.fld_dgcMaterialProduct.BOSDescription = null;
            this.fld_dgcMaterialProduct.BOSError = null;
            this.fld_dgcMaterialProduct.BOSFieldGroup = null;
            this.fld_dgcMaterialProduct.BOSFieldRelation = null;
            this.fld_dgcMaterialProduct.BOSGridType = null;
            this.fld_dgcMaterialProduct.BOSPrivilege = null;
            this.fld_dgcMaterialProduct.BOSPropertyName = null;
            this.fld_dgcMaterialProduct.CommodityType = "";
            this.fld_dgcMaterialProduct.Location = new System.Drawing.Point(0, 47);
            this.fld_dgcMaterialProduct.MenuManager = this.screenToolbar;
            this.fld_dgcMaterialProduct.Name = "fld_dgcMaterialProduct";
            this.fld_dgcMaterialProduct.PrintReport = false;
            this.fld_dgcMaterialProduct.Screen = null;
            this.fld_dgcMaterialProduct.Size = new System.Drawing.Size(1025, 503);
            this.fld_dgcMaterialProduct.TabIndex = 402;
            this.fld_dgcMaterialProduct.Tag = "DC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fld_lkeICProductID1);
            this.panel2.Controls.Add(this.bosLabel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 47);
            this.panel2.TabIndex = 403;
            // 
            // fld_lkeICProductID1
            // 
            this.fld_lkeICProductID1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeICProductID1.BOSAllowAddNew = false;
            this.fld_lkeICProductID1.BOSAllowDummy = true;
            this.fld_lkeICProductID1.BOSComment = "";
            this.fld_lkeICProductID1.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID1.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID1.BOSDescription = null;
            this.fld_lkeICProductID1.BOSError = null;
            this.fld_lkeICProductID1.BOSFieldGroup = "";
            this.fld_lkeICProductID1.BOSFieldParent = "";
            this.fld_lkeICProductID1.BOSFieldRelation = "";
            this.fld_lkeICProductID1.BOSPrivilege = "";
            this.fld_lkeICProductID1.BOSPropertyName = "";
            this.fld_lkeICProductID1.BOSSelectType = "ICProductType";
            this.fld_lkeICProductID1.BOSSelectTypeValue = "Product;SemiProduct";
            this.fld_lkeICProductID1.CurrentDisplayText = "";
            this.fld_lkeICProductID1.Location = new System.Drawing.Point(109, 12);
            this.fld_lkeICProductID1.Name = "fld_lkeICProductID1";
            this.fld_lkeICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID1.Properties.ColumnName = null;
            this.fld_lkeICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeICProductID1.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductID1.Properties.NullText = "";
            this.fld_lkeICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductID1, true);
            this.fld_lkeICProductID1.Size = new System.Drawing.Size(910, 20);
            this.fld_lkeICProductID1.TabIndex = 410;
            this.fld_lkeICProductID1.Tag = "DC";
            this.fld_lkeICProductID1.EditValueChanged += new System.EventHandler(this.fld_lkeICProductID1_EditValueChanged);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(13, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(78, 13);
            this.bosLabel4.TabIndex = 399;
            this.bosLabel4.Text = "Bán thành phẩm";
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_btnClose);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Controls.Add(this.fld_dgcMaterialProduct);
            this.bosPanel1.Controls.Add(this.panel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1031, 586);
            this.bosPanel1.TabIndex = 406;
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
            this.fld_btnClose.Location = new System.Drawing.Point(942, 556);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 405;
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
            this.fld_btnApply.Location = new System.Drawing.Point(853, 556);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 404;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // guiCopyMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 586);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiCopyMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Tạo cây định mức";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiCopyMaterial_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChooseMaterialsGridControl fld_dgcMaterialProduct;
        private System.Windows.Forms.Panel panel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
    }
}