namespace BOSERP.Modules.ProductionNorm.UI
{
    partial class guiCreateProductStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiCreateProductStructure));
            this.fld_dgcSemiProduct1 = new BOSERP.Modules.ProductionNorm.ProductItemsGridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fld_lkeICProductID1 = new BOSERP.ItemLookupEdit(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcSemiProduct1
            // 
            this.fld_dgcSemiProduct1.BOSComment = null;
            this.fld_dgcSemiProduct1.BOSDataMember = null;
            this.fld_dgcSemiProduct1.BOSDataSource = "ICProducts";
            this.fld_dgcSemiProduct1.BOSDescription = null;
            this.fld_dgcSemiProduct1.BOSError = null;
            this.fld_dgcSemiProduct1.BOSFieldGroup = null;
            this.fld_dgcSemiProduct1.BOSFieldRelation = null;
            this.fld_dgcSemiProduct1.BOSGridType = null;
            this.fld_dgcSemiProduct1.BOSPrivilege = null;
            this.fld_dgcSemiProduct1.BOSPropertyName = null;
            this.fld_dgcSemiProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcSemiProduct1.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcSemiProduct1.MenuManager = this.screenToolbar;
            this.fld_dgcSemiProduct1.Name = "fld_dgcSemiProduct1";
            this.fld_dgcSemiProduct1.PrintReport = false;
            this.fld_dgcSemiProduct1.Screen = null;
            this.fld_dgcSemiProduct1.Size = new System.Drawing.Size(1004, 462);
            this.fld_dgcSemiProduct1.TabIndex = 402;
            this.fld_dgcSemiProduct1.Tag = "DC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 511);
            this.panel1.TabIndex = 404;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.fld_dgcSemiProduct1);
            this.panel3.Location = new System.Drawing.Point(2, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 462);
            this.panel3.TabIndex = 404;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fld_lkeICProductID1);
            this.panel2.Controls.Add(this.bosButton2);
            this.panel2.Controls.Add(this.bosLabel4);
            this.panel2.Controls.Add(this.fld_btnCancel);
            this.panel2.Controls.Add(this.fld_btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 47);
            this.panel2.TabIndex = 403;
            // 
            // fld_lkeICProductID1
            // 
            this.fld_lkeICProductID1.BOSAllowAddNew = false;
            this.fld_lkeICProductID1.BOSAllowDummy = false;
            this.fld_lkeICProductID1.BOSComment = null;
            this.fld_lkeICProductID1.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID1.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID1.BOSDescription = null;
            this.fld_lkeICProductID1.BOSError = null;
            this.fld_lkeICProductID1.BOSFieldGroup = null;
            this.fld_lkeICProductID1.BOSFieldParent = null;
            this.fld_lkeICProductID1.BOSFieldRelation = null;
            this.fld_lkeICProductID1.BOSPrivilege = null;
            this.fld_lkeICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID1.BOSSelectType = "ICProductType";
            this.fld_lkeICProductID1.BOSSelectTypeValue = "Product";
            this.fld_lkeICProductID1.CurrentDisplayText = null;
            this.fld_lkeICProductID1.Location = new System.Drawing.Point(108, 12);
            this.fld_lkeICProductID1.Name = "fld_lkeICProductID1";
            this.fld_lkeICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeICProductID1.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeICProductID1.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID1.Properties.PopupWidth = 60;
            this.fld_lkeICProductID1.Properties.ReadOnly = true;
            this.fld_lkeICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductID1, true);
            this.fld_lkeICProductID1.Size = new System.Drawing.Size(506, 20);
            this.fld_lkeICProductID1.TabIndex = 0;
            this.fld_lkeICProductID1.Tag = "DC";
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bosButton2.Location = new System.Drawing.Point(884, 9);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(86, 27);
            this.bosButton2.TabIndex = 5;
            this.bosButton2.Text = "Thoát";
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
            this.bosLabel4.Size = new System.Drawing.Size(89, 13);
            this.bosLabel4.TabIndex = 399;
            this.bosLabel4.Text = "Thuộc thành phẩm";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(792, 9);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(86, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(700, 9);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSave.TabIndex = 3;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiCreateProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 511);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiCreateProductStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thêm Cụm / Chi tiết";
            this.Load += new System.EventHandler(this.guiCreateProductStructure_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProductItemsGridControl fld_dgcSemiProduct1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private ItemLookupEdit fld_lkeICProductID1;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnSave;
    }
}