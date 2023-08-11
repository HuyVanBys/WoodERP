namespace BOSERP.Modules.CarcassBOM.UI
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
            this.fld_dgcSemiProduct1 = new BOSERP.Modules.CarcassBOM.ProductItemsGridControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fld_lkeICProductID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
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
            this.fld_dgcSemiProduct1.CommodityType = "";
            this.fld_dgcSemiProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcSemiProduct1.Location = new System.Drawing.Point(0, 47);
            this.fld_dgcSemiProduct1.MenuManager = this.screenToolbar;
            this.fld_dgcSemiProduct1.Name = "fld_dgcSemiProduct1";
            this.fld_dgcSemiProduct1.PrintReport = false;
            this.fld_dgcSemiProduct1.Screen = null;
            this.fld_dgcSemiProduct1.Size = new System.Drawing.Size(1019, 478);
            this.fld_dgcSemiProduct1.TabIndex = 402;
            this.fld_dgcSemiProduct1.Tag = "DC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fld_lkeICProductID1);
            this.panel2.Controls.Add(this.fld_txtQty);
            this.panel2.Controls.Add(this.bosLabel1);
            this.panel2.Controls.Add(this.bosLabel4);
            this.panel2.Controls.Add(this.fld_btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 47);
            this.panel2.TabIndex = 403;
            // 
            // fld_lkeICProductID1
            // 
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
            this.fld_lkeICProductID1.BOSSelectType = "";
            this.fld_lkeICProductID1.BOSSelectTypeValue = "";
            this.fld_lkeICProductID1.CurrentDisplayText = "";
            this.fld_lkeICProductID1.Enabled = false;
            this.fld_lkeICProductID1.Location = new System.Drawing.Point(108, 12);
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
            this.fld_lkeICProductID1.Properties.ReadOnly = true;
            this.fld_lkeICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductID1, true);
            this.fld_lkeICProductID1.Size = new System.Drawing.Size(379, 20);
            this.fld_lkeICProductID1.TabIndex = 410;
            this.fld_lkeICProductID1.Tag = "DC";
            // 
            // fld_txtQty
            // 
            this.fld_txtQty.BOSComment = null;
            this.fld_txtQty.BOSDataMember = null;
            this.fld_txtQty.BOSDataSource = null;
            this.fld_txtQty.BOSDescription = null;
            this.fld_txtQty.BOSError = null;
            this.fld_txtQty.BOSFieldGroup = null;
            this.fld_txtQty.BOSFieldRelation = null;
            this.fld_txtQty.BOSPrivilege = null;
            this.fld_txtQty.BOSPropertyName = null;
            this.fld_txtQty.Location = new System.Drawing.Point(541, 12);
            this.fld_txtQty.MenuManager = this.screenToolbar;
            this.fld_txtQty.Name = "fld_txtQty";
            this.fld_txtQty.Properties.DisplayFormat.FormatString = "n0";
            this.fld_txtQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtQty.Properties.EditFormat.FormatString = "n0";
            this.fld_txtQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtQty.Properties.Mask.BeepOnError = true;
            this.fld_txtQty.Properties.Mask.EditMask = "n0";
            this.fld_txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtQty.Screen = null;
            this.fld_txtQty.Size = new System.Drawing.Size(129, 20);
            this.fld_txtQty.TabIndex = 401;
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(493, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(42, 13);
            this.bosLabel1.TabIndex = 400;
            this.bosLabel1.Text = "Số lượng";
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
            this.bosLabel4.Size = new System.Drawing.Size(65, 13);
            this.bosLabel4.TabIndex = 399;
            this.bosLabel4.Text = "Cụm / Chi tiết";
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
            this.bosPanel1.Controls.Add(this.fld_dgcSemiProduct1);
            this.bosPanel1.Controls.Add(this.panel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1019, 525);
            this.bosPanel1.TabIndex = 406;
            // 
            // guiCreateProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 525);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiCreateProductStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Tạo cây định mức";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiCreateProductStructure_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductItemsGridControl fld_dgcSemiProduct1;
        private System.Windows.Forms.Panel panel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSTextBox fld_txtQty;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID1;
        private BOSComponent.BOSPanel bosPanel1;
    }
}